Public Class FrmIntroducirDatosEnvio

    Private mFax As Boolean
    Public Property Fax() As Boolean
        Get
            Return mFax
        End Get
        Set(ByVal value As Boolean)
            mFax = value
        End Set
    End Property

    Private mImpresoListado As Object
    Public Property ImpresoListado() As Object
        Get
            Return mImpresoListado
        End Get
        Set(ByVal value As Object)
            mImpresoListado = value
        End Set
    End Property



    Public Sub New(ByRef ImpresoListado As Object, ByVal Fax As Boolean)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ImpresoListado = ImpresoListado
        Me.Fax = Fax
        IniciarCamposTexto()
    End Sub

    Private Sub IniciarCamposTexto()
        If Fax Then
            TxDestino.Text = ImpresoListado.DatosMail.DestinatarioFax
        Else
            Dim Destino As String = ""
            For Each email As String In ImpresoListado.DatosMail.DestinatarioMail
                Destino = Destino & email & ";"
            Next
            TxDestino.Text = Destino
        End If
        TxAsunto.Text = ImpresoListado.DatosMail.Asunto
    End Sub

    Private Sub FrmIntroducirDatosEnvio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Fax Then LbExplicacion.Visible = False
    End Sub

    Private Sub BtEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEnviar.Click
        If Not Fax Then
            Dim Destinatarios As Array = TxDestino.Text.Trim.Split(";")
            For Each element As String In Destinatarios
                Me.ImpresoListado.DatosMail.DestinatarioMail.add(element)
            Next
        Else
            Me.ImpresoListado.DatosMail.DestinatarioFax = TxDestino.Text.ToString
        End If
        Me.ImpresoListado.DatosMail.Asunto = TxAsunto.Text.ToString
        Me.ImpresoListado.EnviarPorOutlook(Me.Fax)
    End Sub

    Private Sub BtCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCancelar.Click
        Me.Close()
    End Sub

End Class