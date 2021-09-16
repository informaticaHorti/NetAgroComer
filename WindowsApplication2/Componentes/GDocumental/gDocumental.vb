Public Class gDocumental

    Private _id As String
    Private _miTipo As tipoGD
    Private err As New Errores
    Private txPath As String

    Dim oEnlace As EnlaceNuxeo
    Dim oConfig As New ConfiguracionEnlace

    Public Enum tipoGD
        Liquidaciones
        Liquidaciones_Transportistas
        CuentasContables
        Pagos
        Cobros
        Agricultores
        Transportistas
        Clientes
    End Enum

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        GridDoc.ReadOnly = True
       

    End Sub
    Public Sub inicializa(ByVal id As String, ByVal miTipo As tipoGD, tabla As String)


        _id = id
        _miTipo = miTipo


        oConfig.CargaXML()
        oConfig.MiId = _miTipo.ToString & "_" & _id
        oEnlace = New EnlaceNuxeo(oConfig, tabla)

        CargaDocumentos()

    End Sub


    Public Sub borrainicializa()
        _id = ""
        oConfig.MiId = ""

        'VisualizaDoc(My.Application.Info.DirectoryPath & "\Cargando.pdf")
        viewUid.DocumentText = ""


        btnAsignar.Enabled = False
        GridDoc.DataSource = Nothing

    End Sub



    Private Sub CargaDocumentos()
        Try

            GridDoc.DataSource = oEnlace.RecogeFicheros()

            If GridDoc.Rows.Count > 1 Then

                GridDoc.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                GridDoc.Columns(1).Visible = False

            End If

        Catch ex As Exception
            GridDoc.DataSource = New DataTable
            Err.Muestraerror("Error al cargar el grid con los documentos", "CargaGrid", ex.Message)
        End Try

    End Sub




    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click
        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros pdf (*.pdf)|*.pdf"
        dOpenFile.ShowDialog()
        If dOpenFile.FileName.Trim <> "" Then
            txPath = dOpenFile.FileName
            VisualizaDoc(txPath)

            If VaInt(_id) > 0 Then
                btnAsignar.Enabled = True
            End If


        End If
    End Sub


    Private Sub VisualizaDoc(ByVal direccionUrl As String)

        viewUid.Navigate(direccionUrl)

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


    

    Private Sub GridDoc_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDoc.RowEnter
        txPath = ""
        btnAsignar.Enabled = False
        If e.RowIndex >= 0 Then
            CargaDocumento(e.RowIndex)
        End If

    End Sub

    Private Sub btnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignar.Click




        Dim NombreDocumento As String = txPath
        If txPath.Contains("\") And txPath.Length > 1 Then
            Dim pos As Integer = txPath.LastIndexOf("\") + 1
            Dim lon As Integer = txPath.Length - (txPath.LastIndexOf("\") + 1)
            NombreDocumento = txPath.Substring(pos, lon)
        End If

        Try

            If txPath.Trim <> "" Then

                oEnlace.AñadirArchivo(txPath, oConfig.MiId, "")

                If My.Computer.FileSystem.FileExists(txPath) Then

                    Dim fichero As New System.IO.FileInfo(txPath)

                    'If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Cargando.pdf") = False Then
                    '    IO.File.Create(My.Application.Info.DirectoryPath & "\Cargando.pdf")
                    'End If

                    'VisualizaDoc(My.Application.Info.DirectoryPath & "\Cargando.pdf")

                    viewUid.DocumentText = ""
                    Application.DoEvents()

                    My.Computer.FileSystem.DeleteFile(txPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

                End If

                CargaDocumentos()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
