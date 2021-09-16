Public Class frmMonedas
    Inherits FrMantenimiento


    Private Monedas As New E_Moneda(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Monedas

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Monedas.MON_IdMoneda, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato2, Monedas.MON_Nombre, Lb2, True)
        ParamTx(TxDato3, Monedas.MON_Cambio, Lb3, True)
        ParamTx(TxAbreviatura, Monedas.MON_Abreviatura, LbAbreviatura, True)
        ParamTx(TxDato4, Monedas.MON_Simbolo, Lb4, False)

        AsociarControles(TxDato1, BtBusca1, Monedas.btBusca, EntidadFrm)

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
            LbId.Text = Monedas.MaxId
            TxDato1.Text = LbId.Text
        End If

        MyBase.Guardar()
    End Sub

    Public Overrides Sub BorraPan()

        MyBase.BorraPan()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub TxDato1_Leave(sender As System.Object, e As System.EventArgs) Handles TxDato1.Leave

        Dim a As String = ""

    End Sub

    Private Sub TxDato1_Enter(sender As System.Object, e As System.EventArgs) Handles TxDato1.Enter
        Dim a As String = ""
    End Sub
End Class