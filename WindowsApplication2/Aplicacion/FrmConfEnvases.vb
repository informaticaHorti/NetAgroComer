Public Class FrmConfEnvases
    Inherits FrMantenimiento
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
    Dim Umedida As New E_Umedida(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConfecEnvase


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConfecEnvase.CEV_Idconfec, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConfecEnvase.CEV_Nombre, Lb2)

        ParamTx(TxDato3, ConfecEnvase.CEV_Abreviatura, Lb3)

        ParamTx(TxDato4, ConfecEnvaseLineas.CEL_Idmaterial, Lb4)
        ParamTx(TxDato5, ConfecEnvaseLineas.CEL_Cantidad, Lb5)

        ParamTx(TxDato6, ConfecEnvase.CEV_IncrementoTara, Lb8)


        AsociarControles(TxDato1, BtBuscaConfec, ConfecEnvase.btBusca, EntidadFrm)
        AsociarControles(TxDato4, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb10)
        BtBuscaEnvase.CL_Filtro = "Tipo='E' or Tipo='M' or TIPO='Q' "
        AsociarGrid(ClGrid1, TxDato4, TxDato5, ConfecEnvaseLineas)

        PropiedadesCamposGr(ClGrid1, "CEL_idlinea", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "NombreEnvase", "Nombre", True, 30)
        PropiedadesCamposGr(ClGrid1, "Ret", "Ret", True, 5)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Coste", "Coste", True, 10, True, "#0.000000", "{0:n6}")
        PropiedadesCamposGr(ClGrid1, "Tara", "Tara", True, 10, True, "#0.0000", "{0:n4}")

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Guardar()


        Dim total As Decimal = VaDec(ClGrid1.GridView.Columns("coste").SummaryItem.SummaryValue)
        ConfecEnvase.CEV_TotalCoste.Valor = total.ToString

        Dim sql As String = "Select CEL_idmaterial as idmaterial from confecenvaselineas where CEL_idconfec=" + TxDato1.Text + " order by CEL_idlinea"
        Dim dt As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count >= 0 Then
                ConfecEnvase.CEV_IdEnvase.Valor = dt.Rows(0)(0)
            End If
        End If

        CalculoTara()
        ConfecEnvase.CEV_TotalTara.Valor = LbTotalTara.Text

        MyBase.Guardar()

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        ' llenar el grid
        CargaLineasGrid()
        CalculoTara()


    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        rbCesta.Checked = False
        rbCaja.Checked = False



        Dim TipoEtiqueta As String = (ConfecEnvaseLineas.CEL_TipoEtiqueta.Valor & "").ToUpper.Trim
        If TipoEtiqueta = "C" Then
            rbCesta.Checked = True
        ElseIf TipoEtiqueta = "J" Then
            rbCaja.Checked = True
        End If

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        ConfecEnvaseLineas.CEL_Idconfec.Valor = TxDato1.Text


        Dim TipoEtiqueta As String = ""
        If rbCesta.Checked Then
            ConfecEnvaseLineas.CEL_TipoEtiqueta.Valor = "C"
        ElseIf rbCaja.Checked Then
            ConfecEnvaseLineas.CEL_TipoEtiqueta.Valor = "J"
        End If


        Return MyBase.GuardarLineas(Gr)


    End Function

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        rbCesta.Checked = False
        rbCaja.Checked = False

    End Sub

    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)

        LbUmedida.Text = ""
        rbCesta.Checked = False
        rbCaja.Checked = False

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select CEL_idlinea, Envases.ENV_nombre as nombreenvase,"
        sql = sql + " CEL_cantidad as Cantidad, Envases.ENV_costesalida as precio,"
        sql = sql + " CEL_cantidad * Envases.ENV_costesalida as coste,"
        sql = sql + " CEL_cantidad * Envases.ENV_tarasalida as tara,"
        sql = sql + " envases.ENV_retornable as ret "
        sql = sql + " from confecenvaselineas,envases where CEL_idconfec=" + TxDato1.Text
        sql = sql + " and CEL_idmaterial=Envases.ENV_idenvase"
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub
    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        CalculoTara()
    End Sub

    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato4.TextChanged

    End Sub

    Private Sub TxDato4_Valida(ByVal edicion As Boolean) Handles TxDato4.Valida
        If Envases.LeerId(TxDato4.Text) = True Then
            Lb7.Text = Format(VaDec(Envases.ENV_CosteSalida.Valor), "#0.0000")
            Lb9.Text = Format(VaDec(Envases.ENV_TaraSalida.Valor), "#0.0000")
            If Umedida.LeerId(Envases.ENV_Udmedida.Valor) = True Then
                LbUmedida.Text = Umedida.UME_Nombre.Valor
            End If

        End If
    End Sub

    Private Sub FrmConfEnvases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CalculoTara()

        Dim DT As DataTable = ClGrid1.Grid.DataSource
        Dim Ttara As Double = 0

        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                Ttara = VaDec(DT.Compute("SUM(Tara)", ""))
            End If
        End If


        LbTotalTara.Text = Format(Ttara + VaDec(TxDato6.Text), "#,###0.0000")
    End Sub

    Private Sub TxDato6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato6.TextChanged

    End Sub

    Private Sub TxDato6_Valida(ByVal edicion As Boolean) Handles TxDato6.Valida
        CalculoTara()
    End Sub

    Private Sub TxDato4_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato4.EnabledChanged
        GroupBox4.Enabled = TxDato4.Enabled
    End Sub
End Class