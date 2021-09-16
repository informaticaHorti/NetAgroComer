Public Class FrmConceptosCobros

    Inherits FrMantenimiento
    Dim ConceptosCobros As New E_ConceptosCobros(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConceptosCobros


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConceptosCobros.COC_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConceptosCobros.COC_Nombre, Lb2)


        AsociarControles(TxDato1, BtBuscaEnvase, ConceptosCobros.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text

    End Sub
    

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
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