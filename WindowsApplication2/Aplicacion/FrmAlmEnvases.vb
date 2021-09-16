Public Class FrmAlmEnvases
    Inherits FrMantenimiento


    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = AlmacenEnvases


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, AlmacenEnvases.AEV_Idalmacen, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxNombre, AlmacenEnvases.AEV_Nombre, LbNombre)
        ParamTx(TxDomicilio, AlmacenEnvases.AEV_Domicilio, LbDomicilio)
        ParamTx(TxCPostal, AlmacenEnvases.AEV_CPostal, LbCPostal)
        ParamTx(TxPoblacion, AlmacenEnvases.AEV_Poblacion, LbPoblacion)
        ParamTx(TxProvincia, AlmacenEnvases.AEV_Provincia, LbProvincia)



        AsociarControles(TxDato1, BtBuscaFRM, AlmacenEnvases.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text

    End Sub



    


End Class