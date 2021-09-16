Public Class EnviarMail

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim config As New Configuracion
        Dim Adj As New List(Of String)
        config.Puerto = TextBox2.Text
        config.Servidor = TextBox1.Text
        config.SSL = False
        config.Usuario = TextBox4.Text
        config.Clave = TextBox5.Text
        Dim mail As New ClvMail(TextBox8.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text, Adj, Nothing)
        mail.Configuracion = config
        mail.Enviar()
    End Sub
End Class