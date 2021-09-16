Public Class FrmConceptos346


    Inherits FrMantenimiento
    Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Conceptos346


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Conceptos346.C46_idconcepto, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Conceptos346.C46_nombre, Lb2)
        ParamTx(TxClave, Conceptos346.C46_clave, LbClave)
        ParamTx(TxTipo, Conceptos346.C46_tipo, LbTipo)

        AsociarControles(TxDato1, BtBuscaMarca, Conceptos346.btBusca, EntidadFrm)



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


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    

End Class