Public Class FrmZonas
    Inherits FrMantenimiento


    Dim Zonas As New E_Zonas(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = Zonas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Zonas.ZON_Idzona, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Zonas.ZON_Nombre, Lb2)

        AsociarControles(TxDato1, BtBuscaZonas, Zonas.btBusca, EntidadFrm)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub


    Public Overrides Sub Guardar()

        If TxDato1.Text = "+" Then
            LbId.Text = Zonas.MaxId
            TxDato1.Text = LbId.Text
        End If

        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    
End Class