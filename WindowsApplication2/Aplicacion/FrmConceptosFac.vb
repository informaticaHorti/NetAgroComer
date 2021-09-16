Public Class FrmConceptosFac

    Inherits FrMantenimiento
    Dim ConcepFac As New E_ConceptosFactura(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConcepFac


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConcepFac.COF_idconcepto, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConcepFac.COF_nombre, Lb2)


        ParamCb_Copia(CbTipoIva, ConcepFac.COF_idtipoiva, Lb9, Combos.ComboIvaEnv)


        AsociarControles(TxDato1, BtBuscaConcep, ConcepFac.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        Dim a = ""
        MyBase.Guardar()
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


    Private Sub FrmConceptosFac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class