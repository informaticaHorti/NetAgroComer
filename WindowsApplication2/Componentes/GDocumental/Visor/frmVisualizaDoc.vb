Imports DevExpress.XtraEditors


Public Class frmVisualizaDoc

    Private err As New Errores
    Private _NIF As String = ""
    Private _IdRegistro As String = ""




    Dim oEnlace As EnlaceDocumentos
    Dim oConfig As New ConfiguracionEnlace


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub Init(nif As String, IdRegistro As String, Optional clave As String = "", Optional descripcion As String = "", Optional tipodocumento As String = "", Optional bSoloVisualizar As Boolean = False)

        _NIF = nif
        _IdRegistro = IdRegistro


        oConfig.CargaXML()

        'Clave
        If clave = "" Then
            oConfig.MiId = "RegistroDocumentos_" & _IdRegistro
        Else
            oConfig.MiId = clave
        End If

        'Descripción
        If descripcion = "" Then
            oConfig.MiDescripcion = "RegistroDocumentos"
        Else
            oConfig.MiDescripcion = descripcion
        End If


        TxDato_2.Text = descripcion.Trim
        TxTipoDoc.Text = tipodocumento.Trim

        oConfig.miCopia = ""


        If bSoloVisualizar Then
            BAñadir.Visible = False
            BAnular.Visible = False
        End If


        If oConfig.tipodoc.Valor = "nuxeo" Then
            oEnlace = New EnlaceNuxeo(oConfig, "DOC1")
        Else
            oEnlace = New EnlaceFichero(oConfig, "DOC1")
        End If


    End Sub

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()
    End Sub

    Private Sub BAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BAñadir.Click

        If TxDato_1.Text.Trim = "" Then
            TxDato_1.Text = ObtenerFichero()
        End If


        Dim NombreDocumento As String = TxDato_1.Text
        If TxDato_1.Text.Contains("\") And TxDato_1.Text.Length > 1 Then
            Dim pos As Integer = TxDato_1.Text.LastIndexOf("\") + 1
            Dim lon As Integer = TxDato_1.Text.Length - (TxDato_1.Text.LastIndexOf("\") + 1)
            NombreDocumento = TxDato_1.Text.Substring(pos, lon)
        End If


        If TxDato_2.Text.Trim = "" Then
            XtraMessageBox.Show("Debe introducir una descripción")
            TxDato_2.SelectAll()
            TxDato_2.Focus()
            Exit Sub
        End If


        If XtraMessageBox.Show("Se va a añadir el documento '" & NombreDocumento & "' a la gestión documental para el nif " & _NIF & ". ¿Desea continuar?", "Añadir documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If TxDato_2.Text.Trim <> "" Then

                Try

                    If TxDato_1.Text.Trim <> "" Then

                        oEnlace.AñadirArchivo(TxDato_1.Text, TxDato_2.Text.Trim & ".pdf", TxTipoDoc.Text.Trim)

                        If My.Computer.FileSystem.FileExists(TxDato_1.Text) Then

                            Dim fichero As New System.IO.FileInfo(TxDato_1.Text)

                            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Cargando.pdf") = False Then
                                IO.File.Create(My.Application.Info.DirectoryPath & "\Cargando.pdf")
                            End If

                            VisualizaDoc(My.Application.Info.DirectoryPath & "\Cargando.pdf")
                            Application.DoEvents()

                            My.Computer.FileSystem.DeleteFile(TxDato_1.Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

                        End If

                        CargaGrid()
                        Limpiame()

                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try

            Else
                XtraMessageBox.Show("Debe introducir una descripcion")
            End If

        End If

    End Sub


    Private Sub Limpiame()

        TxDato_1.Text = ""
        TxDato_2.Text = ""
        TxTipoDoc.Text = ""

    End Sub


    Private Function ObtenerFichero() As String

        Dim resultado As String = ""

        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros pdf (*.pdf)|*.pdf"
        dOpenFile.ShowDialog()

        If dOpenFile.FileName.Trim <> "" Then
            resultado = dOpenFile.FileName

        End If

        Return resultado

    End Function



    Private Sub BAnular_Click(sender As System.Object, e As System.EventArgs) Handles BAnular.Click

        If GridDoc.SelectedRows.Count > 0 Then

            Dim row As DataGridViewRow = GridDoc.SelectedRows(0)
            Dim fichero As String = row.Cells(1).Value & ""
            Dim descripcion As String = row.Cells(0).Value & ""

            If fichero.Trim <> "" Then
                If XtraMessageBox.Show("Se va a eliminar el documento " & descripcion & " de la gestión documental. ¿Desea continuar?", "Eliminar documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    oEnlace.BorrarArchivo(fichero)
                    CargaGrid()
                    Limpiame()

                End If
            End If

        Else
            XtraMessageBox.Show("No hay ningun documento seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub frmVisualizaDoc_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        With GridDoc
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .ReadOnly = True
        End With


   

        'Muestra el documento seleccionado (si existe)
        CargaDocumento()


    End Sub


    Private Sub CargaGrid()

        Try

            GridDoc.DataSource = oEnlace.RecogeFicheros()

            If GridDoc.Rows.Count > 1 Then

                GridDoc.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                GridDoc.Columns(1).Visible = False

            End If

        Catch ex As Exception
            GridDoc.DataSource = New DataTable
            err.Muestraerror("Error al cargar el grid con los documentos", "CargaGrid", ex.Message)
        End Try

    End Sub



    Private Sub CargaDocumento(Optional indice As Integer = 0)


        If GridDoc.Rows.Count >= indice Then

            If GridDoc.Rows(indice).Cells(1).Value IsNot Nothing Then

                VisualizaDoc(oEnlace.VisualizaFichero(GridDoc.Rows(indice).Cells(1).Value.ToString))
                GridDoc.Rows(indice).Selected = True

            Else
                VisualizaDoc("")
            End If
        Else
            VisualizaDoc("")
        End If


    End Sub


    Private Sub VisualizaDoc(ByVal direccionUrl As String)

        WebBrowser1.Navigate(direccionUrl)

    End Sub


    Private Sub GridDoc_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDoc.RowEnter

        If e.RowIndex >= 0 Then
            CargaDocumento(e.RowIndex)
        End If

    End Sub

    Private Sub BPrevisualizar_Click(sender As System.Object, e As System.EventArgs) Handles BPrevisualizar.Click

        Dim RutaFichero As String = ObtenerFichero()

        If RutaFichero.Trim <> "" Then

            TxDato_1.Text = RutaFichero
            VisualizaDoc(RutaFichero)

        End If

    End Sub

    Private Sub TxDato_2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_2.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BAñadir.Select()
            BAñadir.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxTipoDoc.Select()
            TxTipoDoc.Focus()
        End If

    End Sub

    Private Sub TxTipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipoDoc.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxDato_2.Select()
            TxDato_2.Focus()
        End If

    End Sub
End Class