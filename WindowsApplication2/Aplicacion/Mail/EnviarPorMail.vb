Public Class DatosMail

    Public DestinatarioMail As New List(Of String)
    Public DestinatarioFax As String
    Public Asunto As String
    Public Body As String
    Public ListaAdjuntos As New List(Of String)
    Public NombreDocumento As String

    Public Sub New(ByVal DestinatariosMail As List(Of String), ByVal DestinatarioFax As String, ByVal Asunto As String, ByVal Body As String, ByVal ListaAdjuntos As List(Of String), ByVal NombreDocumento As String)

        If Not IsNothing(DestinatariosMail) Then Me.DestinatarioMail = DestinatariosMail
        Me.DestinatarioFax = DestinatarioFax
        Me.Asunto = Asunto
        Me.Body = Body
        If Not IsNothing(ListaAdjuntos) Then Me.ListaAdjuntos = ListaAdjuntos
        Me.NombreDocumento = NombreDocumento

    End Sub

End Class

Module EnviarPorMail

    ''' <summary>
    ''' Envia un reporte por email según los datos pasados por parámetros
    ''' </summary>
    ''' <param name="Datos"></param>
    ''' <returns>True si el envio se produjo sin errores</returns>
    ''' <remarks></remarks>
    Public Function EnviarMailOutlook(ByVal Datos As DatosMail, ByVal Fax As Boolean) As String

        Dim txtError As String = ""


        'Dim SecurityManager As New AddinExpress.Outlook.SecurityManager
        'SecurityManager.DisableOOMWarnings = True

        Try

            Dim OutlookApp As New Microsoft.Office.Interop.Outlook.Application
            Dim oMailItem As Microsoft.Office.Interop.Outlook._MailItem = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

            Dim CadenaDestinatarios As String = ""

            ' Se añaden los destinatarios
            If Not Fax Then
                For Each d As String In Datos.DestinatarioMail
                    If d.Trim <> "" Then
                        CadenaDestinatarios = CadenaDestinatarios & d & ";"
                    End If
                Next
            Else
                CadenaDestinatarios = Datos.DestinatarioFax
            End If
            
            oMailItem.To = CadenaDestinatarios

            Dim Asunto As String = Datos.Asunto

            ' Obtengo el PIN que se añade al asunto del fax
            Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim PinFax As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.PIN_FAX)

            If Fax Then Asunto = PinFax & Asunto

            oMailItem.Subject = Asunto
            Dim Body As String = ""

            ' Se comprueba si hay texto en el cuerpo del mensaje
            If Not IsNothing(Datos.Body) Then
                Body = Datos.Body
            End If

            oMailItem.Body = Body

            ' Se añaden los archivos adjuntos
            For Each d As String In Datos.ListaAdjuntos
                oMailItem.Attachments.Add(d)
            Next


            Dim remitente As String = ""

            Dim addrEntry As Microsoft.Office.Interop.Outlook.AddressEntry = OutlookApp.Session.CurrentUser.AddressEntry
            If addrEntry.Type = "EX" Then
                'Usuario de exchange
                Dim CurrentUser As Microsoft.Office.Interop.Outlook.ExchangeUser = OutlookApp.Session.CurrentUser.AddressEntry.GetExchangeUser
                remitente = CurrentUser.PrimarySmtpAddress
            Else
                'Usuario de outlook normal
                remitente = OutlookApp.Session.CurrentUser.Address
            End If


            Dim account As Microsoft.Office.Interop.Outlook.Account = ObtenerCuentafEmail(OutlookApp, remitente)
            oMailItem.SendUsingAccount = account
            oMailItem.Send()


        Catch ex As Exception
            txtError = ex.Message
        End Try


        'SecurityManager.DisableOOMWarnings = False

        Return txtError

    End Function


    Public Function EnviarMailOutlook(lstMails As List(Of String), lstAdjuntos As List(Of String), asunto As String, Optional textomensaje As String = "") As String

        Dim txtError As String = ""

        Try

            Dim OutlookApp As New Microsoft.Office.Interop.Outlook.Application
            Dim oMailItem As Microsoft.Office.Interop.Outlook._MailItem = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

            Dim CadenaDestinatarios As String = ""

            ' Se añaden los destinatarios
            For Each d As String In lstMails
                If d.Trim <> "" Then
                    CadenaDestinatarios = CadenaDestinatarios & d & ";"
                End If
            Next

            oMailItem.To = CadenaDestinatarios


            ' Obtengo el PIN que se añade al asunto del fax
            Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim PinFax As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.PIN_FAX)


            oMailItem.Subject = asunto
            Dim Body As String = ""

            ' Se comprueba si hay texto en el cuerpo del mensaje
            Body = textomensaje

            oMailItem.Body = Body

            ' Se añaden los archivos adjuntos
            For Each d As String In lstAdjuntos
                oMailItem.Attachments.Add(d)
            Next


            Dim remitente As String = ""

            Dim addrEntry As Microsoft.Office.Interop.Outlook.AddressEntry = OutlookApp.Session.CurrentUser.AddressEntry
            If addrEntry.Type = "EX" Then
                'Usuario de exchange
                Dim CurrentUser As Microsoft.Office.Interop.Outlook.ExchangeUser = OutlookApp.Session.CurrentUser.AddressEntry.GetExchangeUser
                remitente = CurrentUser.PrimarySmtpAddress
            Else
                'Usuario de outlook normal
                remitente = OutlookApp.Session.CurrentUser.Address
            End If


            Dim account As Microsoft.Office.Interop.Outlook.Account = ObtenerCuentafEmail(OutlookApp, remitente)
            oMailItem.SendUsingAccount = account
            oMailItem.Send()


        Catch ex As Exception
            txtError = ex.Message
        End Try

        Return txtError

    End Function


    Public Function ObtenerCuentafEmail(application As Microsoft.Office.Interop.Outlook.Application, smtpAddress As String) As Microsoft.Office.Interop.Outlook.Account

        'application.Session.CurrentUser

        ' Loop over the Accounts collection of the current Outlook session.
        Dim accounts As Microsoft.Office.Interop.Outlook.Accounts = application.Session.Accounts
        For Each account As Microsoft.Office.Interop.Outlook.Account In accounts
            ' When the e-mail address matches, return the account.
            If account.SmtpAddress = smtpAddress Then
                Return account
            End If
        Next
        Throw New System.Exception(String.Format("No existe una cuenta con la direccion: {0} ", smtpAddress))
    End Function


    Public Function ObtenerDireccionFax(ByVal NumFax As String) As String

        Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
        Dim Sufijo As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.SUFIJO_CONFIGURACION_FAX)
        Dim NumeroRetorno As String = NumFax

        If Len(NumFax) > 1 AndAlso NumFax.Substring(0, 2).Equals("00") Then
            NumeroRetorno = Replace(NumFax, "00", "+", 1, 1)
        End If
        NumeroRetorno = NumeroRetorno & "@" & Sufijo

        Return NumeroRetorno

    End Function

End Module
