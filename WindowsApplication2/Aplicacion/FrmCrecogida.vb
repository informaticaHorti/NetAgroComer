Public Class FrmCrecogida
    Inherits FrMantenimiento


    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Centrospventa As New E_Centrospventa(Idusuario, cn)
    Dim Puntoventa As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Seccion As New E_Seccion(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Actividad As New E_Actividad(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)




    Private Sub ParametrosFrm()
        EntidadFrm = CentrosRecogida


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, CentrosRecogida.CER_Idrecogida, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, CentrosRecogida.CER_Nombre, Lb2)
        ParamTx(TxDato3, CentrosRecogida.CER_EntradaAlhondiga, Lb3, True, , , , "SN")
        ParamTx(TxAlmacen, CentrosRecogida.CER_IdAlmacenEnvases, LbAlmacen)
        ParamTx(TxCopiasBoletinMuestreo, CentrosRecogida.CER_CopiasBoletinMuestreo, LbCopiasBoletinMuestreo)
        ParamTx(TxCopiasAlbaranEntrada, CentrosRecogida.CER_CopiasAlbaranEntrada, LbCopiasAlbaranEntrada)


        AsociarControles(TxDato1, BtBuscaFRM, CentrosRecogida.btBusca, EntidadFrm)
        AsociarControles(TxAlmacen, BtBuscaAlmacen, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, LbNomAlmacen)

        ParamTx(TxDato11, Centrospventa.CRP_idpventa, Lb11, True)
        ParamTx(TxDato12, Centrospventa.CRP_idseccion, Lb12, True)
        ParamTx(TxDato13, Centrospventa.CRP_idactividad, Lb13, True)

        AsociarControles(TxDato11, BtBusca11, Puntoventa.btBusca, Puntoventa, Puntoventa.Nombre, LbNom11)
        AsociarControles(TxDato12, BtBusca12, Seccion.btBusca, Seccion, Seccion.Nombre, Lbnom12)
        AsociarControles(TxDato13, BtBusca13, Actividad.btBusca, Actividad, Actividad.Nombre, Lbnom13)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me
        AsociarGrid(ClGrid1, TxDato11, TxDato13, Centrospventa)

        PropiedadesCamposGr(ClGrid1, Centrospventa.CRP_id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Pventa", "Pventa", True, 50)
        PropiedadesCamposGr(ClGrid1, "Seccion", "Seccion", True, 50)
        PropiedadesCamposGr(ClGrid1, "Actividad", "Actividad", True, 50)


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        CargaLineasGrid()

    End Sub
    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Centrospventa.CRP_id)
        consulta.SelCampo(Puntoventa.Nombre, "Pventa", Centrospventa.CRP_idpventa)
        consulta.SelCampo(Seccion.Nombre, "Seccion", Centrospventa.CRP_idseccion)
        consulta.SelCampo(Actividad.Nombre, "Actividad", Centrospventa.CRP_idactividad)
        consulta.WheCampo(Centrospventa.CRP_idcentroR, "=", TxDato1.Text)

        sql = consulta.SQL
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        ' Dim total As Double
        ' total = VaDec(ClGrid1.GridView.Columns("porcentaje").SummaryItem.SummaryValue)
        Centrospventa.CRP_idcentroR.Valor = TxDato1.Text
        Return MyBase.GuardarLineas(Gr)
    End Function




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub FrmCrecogida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmCrecogida_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
    End Sub

    Private Sub FrmCrecogida_ResizeBegin(sender As Object, e As System.EventArgs) Handles Me.ResizeBegin
     

    End Sub
End Class