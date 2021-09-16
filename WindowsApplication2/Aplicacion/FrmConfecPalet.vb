Public Class FrmConfecPalet
    Inherits FrMantenimiento

    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim ConfecPaletLineas As New E_ConfecPaletLineas(Idusuario, cn)
    Dim Umedida As New E_Umedida(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConfecPalet


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConfecPalet.CPA_Idconfec, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConfecPalet.CPA_Nombre, Lb2)

        ParamTx(TxDato3, ConfecPalet.CPA_Abreviatura, Lb3)
        ParamTx(TxCoeficiente, ConfecPalet.CPA_Coeficiente, lbCoeficiente)

        ParamTx(TxDato4, ConfecPaletLineas.CPL_Idmaterial, Lb4)
        ParamTx(TxDato5, ConfecPaletLineas.CPL_Cantidad, Lb5)

        ParamTx(TxDato6, ConfecPalet.CPA_IncrementoTara, Lb8)


        AsociarControles(TxDato1, BtBuscaConfec, ConfecPalet.btBusca, EntidadFrm)
        AsociarControles(TxDato4, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb10)
        BtBuscaEnvase.CL_Filtro = "Tipo='P' or Tipo='M' or Tipo='Q'"

        AsociarGrid(ClGrid1, TxDato4, TxDato5, ConfecPaletLineas)

        PropiedadesCamposGr(ClGrid1, "CPL_idlinea", "", False, 0)
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

        Dim total As Double = VaDec(ClGrid1.GridView.Columns("coste").SummaryItem.SummaryValue)
        ConfecPalet.CPA_TotalCoste.Valor = total.ToString

        Dim sql As String = "Select CPL_idmaterial as idmaterial from confecpaletlineas where CPL_idconfec=" + TxDato1.Text + " order by CPL_idlinea"

        Dim dt As DataTable = ConfecPaletLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count >= 0 Then
                ConfecPalet.CPA_IdPalet.Valor = dt.Rows(0)(0)
            End If
        End If

        CalculoTara()
        ConfecPalet.CPA_TotalTara.Valor = LbTotalTara.Text



        MyBase.Guardar()

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
        CalculoTara()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas



        ConfecPaletLineas.CPL_Idconfec.Valor = TxDato1.Text
        Return MyBase.GuardarLineas(Gr)



    End Function


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub

    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)
        LbUmedida.Text = ""

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
        sql = "Select CPL_idlinea, envases.ENV_nombre as nombreenvase,"
        sql = sql + " CPL_cantidad as Cantidad,envases.ENV_costesalida as precio,"
        sql = sql + " CPL_cantidad * envases.ENV_costesalida as coste,"
        sql = sql + " CPL_cantidad * envases.ENV_tarasalida as tara,"
        sql = sql + " envases.ENV_retornable as ret "

        sql = sql + " from confecpaletlineas,envases where CPL_idconfec=" + TxDato1.Text
        sql = sql + " and CPL_idmaterial=envases.ENV_idenvase"
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
       
    End Sub


    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato4.TextChanged

    End Sub

    Private Sub TxDato4_Valida(ByVal edicion As Boolean) Handles TxDato4.Valida
        If Envases.LeerId(TxDato4.Text) = True Then
            Lb7.Text = Format(VaDec(Envases.ENV_CosteSalida.Valor), "#0.0000")
            Lb9.Text = Format(VaDec(Envases.ENV_TaraSalida.Valor), "#0.0000")
            LbUmedida.Text = ""
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
    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        CalculoTara()
    End Sub
End Class