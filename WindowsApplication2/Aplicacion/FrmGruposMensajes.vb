Public Class FrmGruposMensajes
    Inherits FrMantenimiento


    Dim GruposMensajes As New E_GruposMensajes(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = GruposMensajes


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, GruposMensajes.GRM_Id, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, GruposMensajes.GRM_Nombre, Lb2)

        AsociarControles(TxDato1, BtBusca1, GruposMensajes.btBusca, EntidadFrm)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub


    Public Overrides Sub Guardar()

       
        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub



End Class