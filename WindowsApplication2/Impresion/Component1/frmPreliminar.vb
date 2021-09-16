Public Class frmPreliminar


    Public documento_padre As Object

    Public bCancel As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal documento_padre As Object)
        Me.New()

        Me.documento_padre = documento_padre

    End Sub

    

    Private Sub frmPreliminar_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        C1PrintPreviewControl1.StatusBarVisible = True
        C1PrintPreviewControl1.PreviewProgressBar.Visible = True

    End Sub


    Private Sub btImpresionDirecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        C1PrintPreviewControl1.Document.Print()
    End Sub

    Private Sub btEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEmail.Click

        Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
        Dim ruta As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP)

        Dim doc As C1.C1Preview.C1PrintDocument = C1PrintPreviewControl1.Document


        If Not IsNothing(documento_padre) Then

            If TypeOf documento_padre Is Listado Then

                If Not IsNothing(CType(documento_padre, Listado).DatosMail) Then

                    If Not CompruebaMail(CType(documento_padre, Listado).DatosMail.DestinatarioMail) Then

                        MsgBox("El destinatario no tiene ningún email al que enviar el correo")

                        Dim frm As New FrmPedirDatosEmail
                        frm.ShowDialog()

                        If frm.Resultado = FrmPedirDatosEmail.ResultadoFormulario.Enviar Then
                            CType(documento_padre, Listado).DatosMail.DestinatarioMail = frm.Destinatarios
                            CType(documento_padre, Listado).DatosMail.Asunto = frm.Asunto
                            CType(documento_padre, Listado).DatosMail.Body = frm.Texto
                        End If

                    End If


                    If Not CompruebaMail(CType(documento_padre, Listado).DatosMail.DestinatarioMail) Then
                        MsgBox("El destinatario no tiene ningún email al que enviar el correo")
                        Exit Sub
                    End If


                    Dim nombreArchivo As String = CType(documento_padre, Listado).DatosMail.NombreDocumento
                    doc.Export(ruta & "\" & nombreArchivo)

                    Application.DoEvents()

                    CType(documento_padre, Listado).DatosMail.ListaAdjuntos.Add(ruta & "\" & nombreArchivo)
                    CType(documento_padre, Listado).EnviarPorOutlook(False)

                    Try
                        If IO.File.Exists(ruta & "\" & nombreArchivo) Then
                            IO.File.Delete(ruta & "\" & nombreArchivo)
                        End If
                    Catch ex As Exception
                    End Try

                Else

                    'Formulario que pida los datos
                    Dim frm As New FrmPedirDatosEmail
                    frm.ShowDialog()

                    If frm.Resultado = FrmPedirDatosEmail.ResultadoFormulario.Enviar Then

                        Dim lstAdjuntos As New List(Of String)
                        Dim DatosMail As New DatosMail(frm.Destinatarios, "", frm.Asunto, frm.Texto, lstAdjuntos, "DocumentoERP.pdf")

                        CType(documento_padre, Listado).DatosMail = DatosMail
                        doc.Export(ruta & "\" & DatosMail.NombreDocumento)

                        Application.DoEvents()

                        CType(documento_padre, Listado).DatosMail.ListaAdjuntos.Add(ruta & "\" & DatosMail.NombreDocumento)
                        CType(documento_padre, Listado).EnviarPorOutlook(False)

                        Try
                            If IO.File.Exists(ruta & "\" & DatosMail.NombreDocumento) Then
                                IO.File.Delete(ruta & "\" & DatosMail.NombreDocumento)
                            End If
                        Catch ex As Exception
                        End Try


                    End If


                End If


            ElseIf TypeOf documento_padre Is Impreso Then

                If Not IsNothing(CType(documento_padre, Impreso).DatosMail) Then


                    If Not CompruebaMail(CType(documento_padre, Impreso).DatosMail.DestinatarioMail) Then

                        MsgBox("El destinatario no tiene ningún email al que enviar el correo")

                        Dim frm As New FrmPedirDatosEmail
                        frm.ShowDialog()

                        If frm.Resultado = FrmPedirDatosEmail.ResultadoFormulario.Enviar Then
                            CType(documento_padre, Impreso).DatosMail.DestinatarioMail = frm.Destinatarios
                            CType(documento_padre, Impreso).DatosMail.Asunto = frm.Asunto
                            CType(documento_padre, Impreso).DatosMail.Body = frm.Texto
                        End If

                    End If


                    If Not CompruebaMail(CType(documento_padre, Impreso).DatosMail.DestinatarioMail) Then
                        MsgBox("El destinatario no tiene ningún email al que enviar el correo")
                    End If



                    Dim nombreArchivo As String = CType(documento_padre, Impreso).DatosMail.NombreDocumento
                    doc.Export(ruta & "\" & nombreArchivo)

                    Application.DoEvents()

                    CType(documento_padre, Impreso).DatosMail.ListaAdjuntos.Add(ruta & "\" & nombreArchivo)
                    CType(documento_padre, Impreso).EnviarPorOutlook(False)

                    Try
                        If IO.File.Exists(ruta & "\" & nombreArchivo) Then
                            IO.File.Delete(ruta & "\" & nombreArchivo)
                        End If
                    Catch ex As Exception
                    End Try



                Else

                    'Formulario que pida los datos
                    Dim frm As New FrmPedirDatosEmail
                    frm.ShowDialog()

                    If frm.Resultado = FrmPedirDatosEmail.ResultadoFormulario.Enviar Then

                        Dim lstAdjuntos As New List(Of String)
                        Dim DatosMail As New DatosMail(frm.Destinatarios, "", frm.Asunto, frm.Texto, lstAdjuntos, "DocumentoERP.pdf")

                        CType(documento_padre, Impreso).DatosMail = DatosMail
                        doc.Export(ruta & "\" & DatosMail.NombreDocumento)

                        Application.DoEvents()

                        CType(documento_padre, Impreso).DatosMail.ListaAdjuntos.Add(ruta & "\" & DatosMail.NombreDocumento)
                        CType(documento_padre, Impreso).EnviarPorOutlook(False)

                        Try
                            If IO.File.Exists(ruta & "\" & DatosMail.NombreDocumento) Then
                                IO.File.Delete(ruta & "\" & DatosMail.NombreDocumento)
                            End If
                        Catch ex As Exception
                        End Try


                    End If

                End If


            End If

        End If




        'Dim OutlookApp As New Microsoft.Office.Interop.Outlook.Application
        'Dim nm As Microsoft.Office.Interop.Outlook.NameSpace
        'nm = OutlookApp.GetNamespace("MAPI")

        ''nmsNamespace.Logon("TestMailBox3")
        'nm.Logon(Nothing, Nothing, True, True)

        'Dim BandejaSalida As Microsoft.Office.Interop.Outlook.MAPIFolder = nm.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderOutbox)

        ''Creamos email
        'Dim oMailItem As Microsoft.Office.Interop.Outlook._MailItem = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        'oMailItem.To = "juveno@hotmail.com"
        'oMailItem.Subject = "PINAlbaran Salida [Nº]/[Matricula]/[RefCliente]"
        'oMailItem.Body = ""
        'oMailItem.SaveSentMessageFolder = BandejaSalida
        ''oMailItem.Attachments.Add()
        ''uncomment this to also save this in your draft 
        ''oMailItem.Save(); 
        ''adds it to the outbox 
        'oMailItem.Send()

        'nm.Logoff()



    End Sub


    Private Function CompruebaMail(lstEmail As List(Of String)) As Boolean

        Dim res As Boolean = False


        For Each email As String In lstEmail
            If email.Trim <> "" Then
                res = True
            End If
        Next


        Return res

    End Function



    Private Sub btPaginas_Click(sender As System.Object, e As System.EventArgs) Handles btPaginas.Click

        C1PrintPreviewControl1.NavigationPanelVisible = Not C1PrintPreviewControl1.NavigationPanelVisible

    End Sub


    Private Sub btImpDirecta_Click(sender As System.Object, e As System.EventArgs) Handles btImpDirecta.Click

        C1PrintPreviewControl1.Document.Print()

    End Sub


    Private Sub frmPreliminar_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'bCancel = True
        Try
            documento.Cancel = True
        Catch ex As Exception
        End Try

        Application.DoEvents()

    End Sub



    Private Sub frmPreliminar_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try

            If TypeOf documento_padre Is Listado Then
                CType(documento_padre, Listado).Dispose()
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub C1PrintPreviewControl1_PreviewPane_LongOperation(sender As System.Object, e As C1.C1Preview.LongOperationEventArgs) Handles C1PrintPreviewControl1.PreviewPane.LongOperation

        'If bCancel Then
        '    e.Cancel = True
        'End If

    End Sub


    Private Sub documento_PageAdded(sender As C1.C1Preview.C1PrintDocument, e As C1.C1Preview.PageEventArgs) Handles documento.PageAdded

        If TypeOf documento_padre Is Impreso Then
            CType(documento_padre, Impreso).NuevaPagina()
        End If

    End Sub
End Class