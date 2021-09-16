Imports DevExpress.XtraEditors

Public Class FrmRegularizacionExistencias
    Inherits FrMantenimiento



    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim Recuento As New E_Recuento(Idusuario, cn)
    Dim Recuento_Lineas As New E_Recuento_Lineas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Recuento


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Recuento.REC_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Recuento.REC_Fecha, Lb_2, True)

        ParamTx(TxDato_3, Recuento_Lineas.REL_IdMaterial, Lb3, True)
        ParamTx(TxDato_4, Recuento_Lineas.REL_IdMarca, Lb4)
        ParamTx(TxDato_5, Recuento_Lineas.REL_Unidades, Lb5)
        'ParamTx(TxDato_6, Recuento_Lineas.REL_PMC, Lb6)


        AsociarGrid(ClGrid1, TxDato_3, TxDato_5, Recuento_Lineas)


        PropiedadesCamposGr(ClGrid1, "REL_IdLinea", "REL_IdLinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Material", "Material", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Unidades", "Uds.", True, 20, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "PMC", "PMC", True, 20, , "#,##0.000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 22, True, "#,##0.00", "{0:n2}")


        AsociarControles(TxDato_1, BtBuscaParte, Recuento.btBusca, EntidadFrm)
        AsociarControles(TxDato_3, BtBusca_3, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_3)
        AsociarControles(TxDato_4, BtBusca_4, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lb_4)


        FiltroEntidad.Add(Recuento.REC_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Recuento.REC_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Recuento.LeerParte(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" 'AlbEntrada.MaxId


            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        Dim Importe As Decimal = VaDec(Recuento_Lineas.REL_Unidades.Valor) * VaDec(Recuento_Lineas.REL_PMC.Valor)
        LbImporte.Text = Importe.ToString("#,##0.00")

        LbPMC.Text = VaDec(Recuento_Lineas.REL_PMC.Valor).ToString("#,##0.000000")


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        Mi_IdCentro = Recuento.REC_IdCentro.Valor
        LbCampa.Text = Recuento.REC_Campa.Valor
        PintaCentro(Mi_IdCentro)

        ' llenar el grid
        CargaLineasGrid()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Recuento.MaxId
        End If
        If TxDato_1.Text = "+" Then
            TxDato_1.Text = Recuento.MaxIdCampa(LbCampa.Text, LbCentro.Text)
        End If

        Recuento.REC_IdRecuento.Valor = LbId.Text
        Recuento.REC_Campa.Valor = LbCampa.Text
        Recuento.REC_IdCentro.Valor = LbCentro.Text

        Recuento_Lineas.REL_IdRecuento.Valor = LbId.Text
        'Recuento_Lineas.REL_PMC.Valor = VaDec(LbPMC.Text).ToString


        SqlGrid()


        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()
    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbImporte.Text = ""
        LbPMC.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)

        LbImporte.Text = ""
        LbPMC.Text = ""

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)

        ClGrid1.GridView.RefreshData()

    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(Recuento_Lineas.REL_IdLinea, "REL_IdLinea")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Material", Recuento_Lineas.REL_IdMaterial)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Recuento_Lineas.REL_IdMarca)
        CONSULTA.SelCampo(Recuento_Lineas.REL_Unidades, "Unidades")
        CONSULTA.SelCampo(Recuento_Lineas.REL_PMC, "PMC")
        Dim oImporte As New Cdatos.bdcampo("@REL_Unidades * REL_PMC", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")
        CONSULTA.WheCampo(Recuento_Lineas.REL_IdRecuento, "=", id)

        sql = CONSULTA.SQL
        sql = sql + " order by REL_idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub PintaCentro(ByVal Centro As Integer)

        LbCentro.Text = Centro.ToString
        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        Else
            LbNomCentro.Text = ""
        End If

    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub


    Private Function CalculaPMC() As Decimal

        Dim ValIni As Decimal = 0
        Dim ValCom As Decimal = 0
        Dim ExistIni As Decimal = 0
        Dim UdsCom As Decimal = 0


        'Iniciales
        Dim sql As String = "SELECT SUM(COALESCE(ENI_Inicial,0)) as ExistIni, " & vbCrLf
        sql = sql & " SUM(COALESCE(ENI_inicial,0) * COALESCE(ENI_precio,0)) as ValIni" & vbCrLf
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        sql = sql & " AND ENI_Codigo = " & MiMaletin.IdPuntoVenta.ToString & vbCrLf
        sql = sql & " AND ENI_IdEnvase = " & TxDato_3.Text & vbCrLf
        sql = sql & " AND COALESCE(ENI_IdMarca,0) = " & VaInt(TxDato_4.Text).ToString & vbCrLf

        Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            ExistIni = VaDec(dt.Rows(0)("ExistIni"))
            ValIni = VaDec(dt.Rows(0)("ValIni"))
        End If


        'Compras
        sql = "SELECT SUM(COALESCE(VEL_Entrega,0)) as UdsCom," & vbCrLf
        sql = sql & " SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_precioentrega,0)) as ValCom" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        sql = sql & " AND VEV_Fecha <= '" & TxDato_2.Text & "'" & vbCrLf
        sql = sql & " AND VEL_IdEnvase = " & TxDato_3.Text & vbCrLf
        sql = sql & " AND VEL_IdAlmacen = " & MiMaletin.IdPuntoVenta.ToString & vbCrLf
        sql = sql & " AND VEV_Operacion = 'AC'" & vbCrLf

        dt = Envases.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            UdsCom = VaDec(dt.Rows(0)("UdsCom"))
            ValCom = VaDec(dt.Rows(0)("ValCom"))
        End If




        Dim PMC As Decimal = 0
        If (ExistIni + UdsCom) <> 0 Then PMC = (ValIni + ValCom) / (ExistIni + UdsCom)



        Return PMC


    End Function


    Private Sub TxDato_5_Valida(edicion As System.Boolean) Handles TxDato_5.Valida

        

    End Sub


    Private Sub TxDato_4_Valida(edicion As System.Boolean) Handles TxDato_4.Valida

        If edicion Then

            Dim PMC As Decimal = CalculaPMC()
            LbPMC.Text = PMC.ToString("#,##0.000000")

            Recuento_Lineas.REL_PMC.Valor = PMC.ToString

        End If

    End Sub


End Class

