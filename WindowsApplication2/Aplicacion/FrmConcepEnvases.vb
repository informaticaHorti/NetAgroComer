Public Class FrmConcepEnvases


    Inherits FrMantenimiento
    Dim ConceptosEnvases As New E_ConceptosEnvases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConceptosEnvases


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConceptosEnvases.COE_Idconcepto, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConceptosEnvases.COE_Nombre, Lb2)

        AsociarControles(TxDato1, BtBuscaFRM, ConceptosEnvases.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub






    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


End Class