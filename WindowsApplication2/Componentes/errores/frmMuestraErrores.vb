Imports System.Reflection
Imports DevExpress.XtraEditors
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class frmMuestraErrores
    <DllImport("wininet.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function InternetGetConnectedState(ByRef lpdwFlags As ConnectionState, ByVal dwReserved As Integer) As Boolean
    End Function
    Private _proyecto As String
    Private _err As String
    Private ListaFormularios As New List(Of XtraForm)
    Private _ClaseProcedimiento As String
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private _texto As String = ""
    Public Sub New(ByVal err As String, ByVal Proyecto As String, ByVal clase As String, ByVal Procedimiento As String, ByVal texto As String)
        InitializeComponent()

        Me.MemoEdit1.Text = err
        _err = err
        _proyecto = Proyecto
        _texto = texto

        Me.Text = "Errores encontrados en " & Proyecto
        Label1.Text = "Se encontró el siguiente error en la clase :" & clase & " procedimiento: " & Procedimiento & "." & vbCrLf & _
                 " A continuación se muestra la información sobre el error producido:"

        _ClaseProcedimiento = Label1.Text

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim f As New frmInfoError(_texto)
        f.ShowDialog()

    End Sub


    Private Sub txtAbortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbortar.Click
        System.Windows.Forms.Application.ExitThread()

    End Sub

    Private Sub txtIgnorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIgnorar.Click
        Me.Close()
    End Sub
    Private Function ValidarEmail(ByVal ServidorSmtp As String, ByVal PuertoSmpt As String, ByVal usuarioSmpt As String, ByVal ContraseñaSmpt As String, ByVal EmailEmisor As String, ByVal EmailReceptor As String) As Boolean
        If ServidorSmtp.Equals("") Then
            MessageBox.Show(Me, "No existe el servidor SMTP", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf PuertoSmpt.Equals("") Then
            MessageBox.Show(Me, "No existe el puerto SMTP", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf usuarioSmpt.Equals("") Then
            MessageBox.Show(Me, "No existe el usuario SMTP", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf ContraseñaSmpt.Equals("") Then
            MessageBox.Show(Me, "No existe la contraseña SMTP", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf EmailEmisor.Equals("") Then
            MessageBox.Show(Me, "Debe proporcionar una direccion email de destino", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf EmailReceptor.Equals("") Then
            Return False
        End If

        Return True
    End Function
    Private Function ValidacionCorreo(ByVal email As String) As Boolean
        Dim regx As New Regex("([a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)", RegexOptions.IgnoreCase)
        If regx.IsMatch(email) Then
            Return True
        End If
        Return False
    End Function

    Private Sub txtEnvioEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Descripcion As ConnectionState = 0
        Dim conn As Boolean = InternetGetConnectedState(Descripcion, 0)

        If conn = False Then
            XtraMessageBox.Show("No está conectado a internet", "No hay conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        Else

            If Me.ValidarEmail("smtp.gmail.com", "587", "claveerpnet@gmail.com", "28912580", "claveerpnet@gmail.com", "claveerpnet@gmail.com") Then
                If ValidacionCorreo("claveerpnet@gmail.com") Then
                    Dim message As New MailMessage()
                    message.From = New MailAddress("claveerpnet@gmail.com")
                    message.IsBodyHtml = True

                    message.Subject = "Error automatico en" & _proyecto & " con fecha" & Date.Now.ToLongDateString
                    message.Body = _ClaseProcedimiento & vbCrLf
                    message.Body = message.Body & _texto & vbCrLf
                    message.Body = message.Body & _err


                    Dim client As New SmtpClient()
                    client.Host = "smtp.gmail.com"
                    client.Port = 587
                    client.EnableSsl = True
                    client.UseDefaultCredentials = False
                    client.Credentials = New System.Net.NetworkCredential("claveerpnet@gmail.com", "28912580")

                    Try

                        message.[To].Add(New MailAddress("claveerpnet@gmail.com"))
                        client.Send(message)

                        XtraMessageBox.Show("El e-mail fue enviado con éxito", "EMail", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()

                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try



                Else
                    MessageBox.Show(Me, "No hay Conexion a internet", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(Me, "No existe el destinatario", "Email", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

        End If
    End Sub


    Private Sub frmMuestraErrores_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Text = ""
    End Sub
End Class
