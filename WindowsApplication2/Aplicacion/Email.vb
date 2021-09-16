Imports System.Net
Imports System.Net.Mail

Public Structure Configuracion

    Dim Servidor As String
    Dim Puerto As String
    Dim SSL As Boolean

    Dim Usuario As String
    Dim Clave As String

    Dim CorreoDe As String
    Dim CopiaPara As String
    Dim CopiaError As String

    Dim CarpetaMail As String

    Dim Intervalo As Integer

    Dim UsarHorario As Boolean
    Dim Desde As Date
    Dim Hasta As Date

    Dim TimeoutEnvio As Integer

End Structure

Public Class ClvMail

    Dim _Configuracion As Configuracion
    Dim _Log As Ficheros

    Dim _Texto_Error As String

    Dim _De As String = ""
    Dim _Para As New List(Of String)

    Dim _CopiaPara As New List(Of String)
    Dim _CopiaOcultaPara As New List(Of String)
    Dim _CopiaErrorPara As New List(Of String)

    Dim _Asunto As String = ""
    Dim _Texto As New List(Of String)
    Dim _Adjuntos As New List(Of String)


    Public Property Log As Ficheros
        Get
            Return _Log
        End Get
        Set(value As Ficheros)
            _Log = value
        End Set
    End Property


    Public Property Configuracion As Configuracion
        Get
            Return _Configuracion
        End Get
        Set(ByVal value As Configuracion)
            _Configuracion = value
        End Set
    End Property

    Public Property Texto_Error As String
        Get
            Return _Texto_Error
        End Get
        Set(ByVal value As String)
            _Texto_Error = value
        End Set
    End Property

    Public Property De As String
        Get
            Return _De
        End Get
        Set(ByVal value As String)
            _De = value
        End Set
    End Property

    Public Property Para As List(Of String)
        Get
            Return _Para
        End Get
        Set(ByVal value As List(Of String))
            _Para = value
        End Set
    End Property

    Public Property CopiaPara As List(Of String)
        Get
            Return _CopiaPara
        End Get
        Set(ByVal value As List(Of String))
            _CopiaPara = value
        End Set
    End Property

    Public Property CopiaOcultaPara As List(Of String)
        Get
            Return _CopiaOcultaPara
        End Get
        Set(ByVal value As List(Of String))
            _CopiaOcultaPara = value
        End Set
    End Property

    Public Property CopiaErrorPara As List(Of String)
        Get
            Return _CopiaErrorPara
        End Get
        Set(ByVal value As List(Of String))
            _CopiaErrorPara = value
        End Set
    End Property

    Public Property Asunto As String
        Get
            Return _Asunto
        End Get
        Set(ByVal value As String)
            _Asunto = value
        End Set
    End Property

    Public Property Texto As List(Of String)
        Get
            Return _Texto
        End Get
        Set(ByVal value As List(Of String))
            _Texto = value
        End Set
    End Property

    Public Property Adjuntos As List(Of String)
        Get
            Return _Adjuntos
        End Get
        Set(ByVal value As List(Of String))
            _Adjuntos = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal De As String, ByVal Para As String, ByVal Asunto As String, _
                   ByVal Mensaje As String, ByVal Adjuntos As List(Of String), log As Ficheros)

        If De <> "" And Para <> "" And Asunto <> "" And Mensaje <> "" Then

            _De = De
            _Para.Add(Para)
            _Asunto = Asunto
            _Texto.Add(Mensaje)
            _Adjuntos = Adjuntos

            Enviar()

        End If

        _Log = log

    End Sub

    Public Function Enviar() As Boolean

        Dim bRes As Boolean = False
        _Texto_Error = ""

        If _Configuracion.Servidor <> "" And Val(_Configuracion.Puerto) > 0 Then

            Dim cliente As New SmtpClient

            ' configuracion
            cliente.Host = _Configuracion.Servidor
            cliente.Port = Val(_Configuracion.Puerto)
            cliente.EnableSsl = _Configuracion.SSL

            If _De.Trim = "" Then _De = _Configuracion.CorreoDe

            If _Configuracion.Usuario <> "" And _Configuracion.Clave <> "" Then

                Dim mensaje As New MailMessage()

                cliente.UseDefaultCredentials = False
                cliente.Credentials = New System.Net.NetworkCredential(_Configuracion.Usuario, _Configuracion.Clave)

                mensaje.From = New MailAddress(_De)
                mensaje.IsBodyHtml = False
                mensaje.Subject = Asunto

                For Each p As String In _Para
                    If p.Trim <> "" Then mensaje.To.Add(New MailAddress(p))
                Next

                For Each t As String In Texto
                    If t.Trim <> "" Then mensaje.Body = mensaje.Body & t & vbCrLf
                Next

                If Adjuntos.Count > 0 Then
                    For Each f As String In Adjuntos
                        If f.Trim <> "" Then mensaje.Attachments.Add(New Attachment(f))
                    Next
                End If

                Try
                    cliente.Send(mensaje)
                    bRes = True
                Catch ex As Exception
                    _Texto_Error = Err.Description
                End Try

            Else
                _Texto_Error = "Falta el usuario o la contraseña."
            End If

        Else
            _Texto_Error = "Falta el servidor o el puerto."
        End If

        Return bRes

    End Function

    Public Function EnviarCorreo() As Boolean

        Dim bRes As Boolean = False
        _Texto_Error = ""

        '_Log.ActualizarLog("Enviando mensaje ")


        Try

            If _Configuracion.Servidor <> "" And Val(_Configuracion.Puerto) > 0 Then

                Dim cliente As New SmtpClient
                cliente.Timeout = _Configuracion.TimeoutEnvio

                cliente.Host = _Configuracion.Servidor
                cliente.Port = Val(_Configuracion.Puerto)
                cliente.EnableSsl = _Configuracion.SSL

                If _De.Trim = "" Then _De = _Configuracion.CorreoDe

                If _Configuracion.Usuario <> "" And _Configuracion.Clave <> "" Then

                    Dim mensaje As New MailMessage()

                    cliente.UseDefaultCredentials = False
                    cliente.Credentials = New System.Net.NetworkCredential(_Configuracion.Usuario, _Configuracion.Clave)

                    mensaje.From = New MailAddress(_De)
                    mensaje.IsBodyHtml = False
                    mensaje.Subject = _Asunto

                    For Each p As String In _Para
                        If p.Trim <> "" Then mensaje.To.Add(New MailAddress(p))
                    Next

                    'If _Configuracion.CopiaPara.Trim <> "" Then
                    '    mensaje.CC.Add(New MailAddress(_Configuracion.CopiaPara))
                    'End If

                    For Each cc As String In _CopiaPara
                        If cc.Trim <> "" Then mensaje.CC.Add(New MailAddress(cc))
                    Next

                    For Each bcc As String In _CopiaOcultaPara
                        If bcc.Trim <> "" Then mensaje.Bcc.Add(New MailAddress(bcc))
                    Next

                    For Each t As String In _Texto
                        If t.Trim <> "" Then mensaje.Body = mensaje.Body & t & vbCrLf
                    Next

                    For Each f As String In _Adjuntos
                        If f.Trim <> "" Then mensaje.Attachments.Add(New Attachment(f))
                    Next

                    ' ???
                    'For Each pe As String In _CopiaErrorPara
                    '    If pe.Trim <> "" Then mensaje.To.Add(New MailAddress(pe))
                    'Next

                    Try
                        'Dim a As Integer = cliente.Timeout
                        cliente.Send(mensaje)
                        bRes = True
                    Catch ex As Exception
                        _Texto_Error = Err.Description
                    End Try

                    mensaje.Attachments.Dispose()
                    mensaje.Dispose()
                    mensaje = Nothing

                Else
                    _Texto_Error = "Falta el usuario o la contraseña."
                End If

            Else
                _Texto_Error = "Falta el servidor o el puerto."
            End If

        Catch ex As Exception
            _Texto_Error = ex.Message

        End Try


        Return bRes

    End Function

    ' email de notificacion, copiando los datos necesarios de la
    '   configuracion general y del email pasado, que se acaba de 
    '   enviar con éxito ...
    Public Sub NotificarOk()

        _Texto_Error = ""

        Try
            If _Configuracion.CopiaPara.Trim = "" Then Exit Sub

            Dim cliente As New SmtpClient
            Dim mensaje As New MailMessage()

            cliente.Host = _Configuracion.Servidor
            cliente.Port = Val(_Configuracion.Puerto)
            cliente.EnableSsl = _Configuracion.SSL

            cliente.UseDefaultCredentials = False
            cliente.Credentials = New System.Net.NetworkCredential(_Configuracion.Usuario, _Configuracion.Clave)

            mensaje.From = New MailAddress(_De)
            mensaje.IsBodyHtml = False
            'mensaje.Subject = "Notificación de envío de un email."
            mensaje.Subject = _Asunto.Trim & " - CorreoNET."

            mensaje.To.Add(New MailAddress(_Configuracion.CopiaPara))

            'mensaje.Body = "El correo con el asunto '" & _Asunto.Trim & "', " & vbCrLf
            'mensaje.Body = mensaje.Body & "ha sido enviado a los siguientes destinatarios, " & vbCrLf

            mensaje.Body = "El correo con el asunto que se copia en el asunto de este " & vbCrLf
            mensaje.Body = mensaje.Body & "mensaje fue enviado a los siguientes destinatarios, " & vbCrLf
            For Each p In _Para
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "para: " & p.ToString & vbCrLf
            Next
            For Each p In _CopiaPara
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "copia para: " & p.ToString & vbCrLf
            Next
            For Each p In _CopiaOcultaPara
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "copia oculta para: " & p.ToString & vbCrLf
            Next
            mensaje.Body = mensaje.Body & "en la fecha y hora " & Now.ToString & ". "

            cliente.Send(mensaje)

        Catch ex As Exception
            _Texto_Error = "Error 'NotificarOK': " & ex.Message

        End Try

    End Sub

    Public Sub NotificarError()

        _Texto_Error = ""

        Try
            If _Configuracion.CopiaError.Trim = "" Then Exit Sub

            Dim cliente As New SmtpClient
            Dim mensaje As New MailMessage()

            cliente.Host = _Configuracion.Servidor
            cliente.Port = Val(_Configuracion.Puerto)
            cliente.EnableSsl = _Configuracion.SSL

            cliente.UseDefaultCredentials = False
            cliente.Credentials = New System.Net.NetworkCredential(_Configuracion.Usuario, _Configuracion.Clave)

            mensaje.From = New MailAddress(_De)
            mensaje.IsBodyHtml = False
            'mensaje.Subject = "Notificación de ERROR en el envío de un email."
            mensaje.Subject = "ERROR: " & _Asunto.Trim & " - CorreoNET."

            mensaje.To.Add(New MailAddress(_Configuracion.CopiaError))

            'mensaje.Body = "El correo con el asunto '" & _Asunto.Trim & "', " & vbCrLf
            'mensaje.Body = mensaje.Body & "no pudo ser enviado a los siguientes destinatarios, " & vbCrLf

            mensaje.Body = "El correo con el asunto que se copia en el asunto de este mensaje " & vbCrLf
            mensaje.Body = mensaje.Body & "no pudo ser enviado a los siguientes destinatarios, " & vbCrLf
            For Each p In _Para
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "para: " & p.ToString & vbCrLf
            Next
            For Each p In _CopiaPara
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "copia para: " & p.ToString & vbCrLf
            Next
            For Each p In _CopiaOcultaPara
                If p.Trim <> "" Then mensaje.Body = mensaje.Body & "copia oculta para: " & p.ToString & vbCrLf
            Next
            mensaje.Body = mensaje.Body & "en la fecha y hora " & Now.ToString & ". "

            cliente.Send(mensaje)

        Catch ex As Exception
            _Texto_Error = "Error 'NotificarError': " & ex.Message

        End Try

    End Sub

End Class
