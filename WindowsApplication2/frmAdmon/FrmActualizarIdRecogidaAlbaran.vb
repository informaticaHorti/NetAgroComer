Imports DevExpress.XtraEditors


Public Class FrmActualizarIdRecogidaAlbaran

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmActualizarIdRecogidaAlbaran_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()

        Dim sql As String = "SELECT AEN_IdAlbaran as IdAlbaran, AEN_IdPuntoVenta as PV, AEN_Albaran as Albaran, AEN_Fecha as Fecha, AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor, AEN_IdRecogida as CR, AGR_IdcRecogida as CR_Agricultor" & vbCrLf
        sql = sql & " FROM AlbEntrada" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql = sql & " WHERE COALESCE(AEN_IdRecogida,0) = 0 " & vbCrLf
        sql = sql & " ORDER BY AEN_Fecha DESC" & vbCrLf

        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        If XtraMessageBox.Show("¿Desea actualizar los Centros de Recogida de los albaranes con los que tiene por defecto el agricultor?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


            ProgressBar1.Maximum = GridView1.RowCount - 1
            ProgressBar1.Value = 0

            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                    Dim IdCRAgricultor As Integer = VaInt(row("CR_Agricultor"))

                    If AlbEntrada.LeerId(IdAlbaran) Then
                        AlbEntrada.AEN_IdRecogida.Valor = IdCRAgricultor.ToString
                        AlbEntrada.Actualizar()
                    End If

                End If

                ProgressBar1.Value = indice

            Next


            MsgBox("Terminado!")

            Consultar()

        End If

    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click

        If IsNothing(Grid.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Application.DoEvents()

                Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If

                Application.DoEvents()

            Catch ex As Exception

            End Try

        End If


        Application.DoEvents()


        If Grid.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)


            imprime.Margins.Top = 50
            imprime.Margins.Right = 50
            imprime.Margins.Bottom = 50
            imprime.Margins.Left = 50


            Application.DoEvents()

            imprime.ShowPreview()

            Application.DoEvents()

        End If

    End Sub
End Class