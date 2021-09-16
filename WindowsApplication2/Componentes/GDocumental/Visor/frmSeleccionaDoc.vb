Imports DevExpress.XtraEditors


Public Class frmSeleccionaDoc

    Private err As New Errores
    Private _NIF As String = ""
    Private _Id As String = ""
    Private _IdRegistro As String = ""
    Private _lstIdRegistro As New List(Of String)







    Dim oEnlace As EnlaceDocumentos
    Dim oConfig As New ConfiguracionEnlace


    Public ReadOnly Property Registros As List(Of String)
        Get
            Return _lstIdRegistro
        End Get
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub Init(nif As String)

        _NIF = nif

        oConfig.CargaXML()

        'Clave
        Dim clave As String = "FraRecibida|" & nif
        If clave = "" Then
            oConfig.MiId = "RegistroDocumentos_" & _IdRegistro
        Else
            oConfig.MiId = clave
        End If

        'Descripción
        Dim descripcion As String = ""
        If descripcion = "" Then
            oConfig.MiDescripcion = "RegistroDocumentos"
        Else
            oConfig.MiDescripcion = descripcion
        End If


        TxDato_2.Text = descripcion.Trim

        oConfig.miCopia = ""


        'BAñadir.Visible = False
        BAnular.Visible = False


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

        For Each row As DataGridViewRow In GridDoc.Rows
            If row.Cells(3).Value = True Then
                _lstIdRegistro.Add(row.Cells(0).Value.ToString & "")
            End If
        Next

        If _lstIdRegistro.Count > 0 Then
            Me.Close()
        Else
            MsgBox("No ha seleccionado ningún documento")
        End If

    End Sub


    Private Sub Limpiame()

        TxDato_1.Text = ""
        TxDato_2.Text = ""

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

            Dim dt As DataTable = oEnlace.RecogeFicherosPorNif(_NIF)

            Dim colSel As New DataColumn("S", GetType(Boolean))
            colSel.DefaultValue = False
            dt.Columns.Add(colSel)
            'dt.Rows.Add(DBNull.Value, "", "", False)


            GridDoc.DataSource = dt

            If GridDoc.Rows.Count > 1 Then

                GridDoc.Columns(0).Visible = False
                GridDoc.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                GridDoc.Columns(2).Visible = False
                GridDoc.Columns(3).Width = 30

            End If



        Catch ex As Exception
            GridDoc.DataSource = New DataTable
            err.Muestraerror("Error al cargar el grid con los documentos", "CargaGrid", ex.Message)
        End Try

    End Sub



    Private Sub CargaDocumento(Optional indice As Integer = 0)


        'If GridDoc.Rows.Count >= indice Then
        If GridDoc.Rows.Count > indice Then

            If GridDoc.Rows(indice).Cells(2).Value IsNot Nothing Then

                VisualizaDoc(oEnlace.VisualizaFichero(GridDoc.Rows(indice).Cells(2).Value.ToString))
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

            If e.ColumnIndex <> 3 Then
                CargaDocumento(e.RowIndex)
            End If

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

        If e.KeyCode = Keys.Enter Then
            BAñadir.Select()
            BAñadir.Focus()
        End If

    End Sub


    Private Sub GridDoc_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDoc.CellContentClick

        If e.ColumnIndex = 3 Then

            If GridDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                GridDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
            Else
                GridDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
            End If

        End If

        If e.RowIndex >= 0 Then
            CargaDocumento(e.RowIndex)
        End If

    End Sub

End Class