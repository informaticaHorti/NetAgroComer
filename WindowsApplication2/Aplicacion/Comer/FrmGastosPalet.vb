Public Class FrmGastosPalet

    Inherits FrMantenimiento

    Dim palets As New E_palets(Idusuario, cn)
    Dim palet_costes As New E_palets_costes(Idusuario, cn)
    Dim envases As New E_Envases(Idusuario, cn)
    Dim marcas As New E_Marcas(Idusuario, cn)
    Dim almacenenvases As New E_AlmacenEnvases(Idusuario, cn)

    Dim Idlinea As Integer
    Dim PosTp As Long = -1
    Dim PosLf As Long = -1
   
   
    Private Sub ParametrosFrm()
        EntidadFrm = palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, palet_costes.PLC_idpalet, Lb2)


        ParamTx(TxDato_10, palet_costes.PLC_idmaterial, Lb_10, True)
        ParamTx(TxDato_15, palet_costes.PLC_idmarca, Lb_15, False)

        ParamTx(TxDato_2, palet_costes.PLC_cantidad, Lb_2)
        ParamTx(TxDato_3, palet_costes.PLC_precio, Lb_3)



        AsociarControles(TxDato_10, BtBusca_10, envases.btBusca, envases, envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, marcas.btBusca, marcas, marcas.MAR_Nombre, Lbnom_15)

        AsociarGrid(ClGrid1, TxDato_10, TxDato_3, palet_costes)


        BAnular.Visible = False
        BModificar.Visible = False
        BGuardar.Visible = False

        PropiedadesCamposGr(ClGrid1, "PLC_idcoste", "PLC_idcoste", False, 0)
        PropiedadesCamposGr(ClGrid1, "Material", "Material", True, 10)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 10, True)

    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        CargaLineasGrid()

    End Sub
    Public Overrides Sub Guardar()

        MyBase.Guardar()
        ActuGasto()
    End Sub

    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        MyBase.Entidad_a_DatosLin(Grid)

    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas


        Dim e As Boolean


        palet_costes.PLC_idpalet.Valor = LbId.Text
        palet_costes.PLC_idlineapalet.Valor = Idlinea.ToString

        e = MyBase.GuardarLineas(Gr)
        ActuGasto()
        Return e
    End Function
    Private Sub ActuGasto()
        CalculoTotal()
        palet_costes.PLC_idpalet.Valor = LbId.Text
        

    End Sub

    Public Sub initLinea(ByVal idlineapalet As String)
        Idlinea = VaInt(idlineapalet)
    End Sub
    Public Overrides Sub init(ByVal Id As String)
        MyBase.init(Id)
        Dim i As Double = 0
        If Id <> "" Then
            ' If VentasLineas.LeerId(LbId.Text) = True Then
            ' LbKilos.Text = Format(VaDec(VentasLineas.VNL_KilosCom.Valor), "#,###0.00")
            '
            '           CalculoTotal()
        End If

    End Sub

    Public Sub Initpos(ByVal Tp As Long, ByVal Lf As Long)
        PosTp = Tp
        PosLf = Lf
    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
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
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(palet_costes.PLC_idcoste)
        consulta.SelCampo(envases.ENV_Nombre, "Material", palet_costes.PLC_idmaterial)
        consulta.SelCampo(marcas.MAR_Nombre, "Marca", palet_costes.PLC_idmarca)
        consulta.SelCampo(palet_costes.PLC_cantidad, "Cantidad")
        consulta.SelCampo(palet_costes.PLC_precio, "Precio")
        consulta.SelCampo(palet_costes.PLC_precio, "Importe")
        consulta.SelCampo(palet_costes.PLC_automatico, "Aut")
        consulta.WheCampo(palet_costes.PLC_idpalet, "=", LbId.Text)
        consulta.WheCampo(palet_costes.PLC_idlineapalet, "=", Idlinea.ToString)
        sql = consulta.SQL + " order by plc_idmaterial"

        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
        CalculoTotal()

    End Sub



 

    Private Sub FrmGastosFac_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If PosTp > 0 Then
            Me.Top = PosTp

        End If
        If PosLf > 0 Then
            Me.Left = PosLf
        End If
    End Sub

    Private Sub FrmGastosFac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalculoTotal()


    End Sub

    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato4_Valida(ByVal edicion As Boolean)
    End Sub

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)

        Dim sql As String = ""

        ' Dim DTG As DataTable = gr.GridView.DataSource
        Dim Importe As Double = 0



        For Each rw In gr.GridView.DataSource

            Importe = VaDec(rw("Cantidad")) * VaDec(rw("Precio"))
            rw("importe") = Format(Importe, "#,###0.00")
        Next
        MyBase.DespuesdeCargarLineas(gr)
    End Sub
End Class