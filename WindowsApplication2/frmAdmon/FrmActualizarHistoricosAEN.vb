Imports DevExpress.XtraEditors


Public Class FrmActualizarHistoricosAEN

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmActualizarIdRecogidaAlbaran_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()


        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


        Try

            Dim sql As String = "SELECT IdAlbaran, PV, Albaran, Fecha, SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, SUM(LineasCla) as LineasCla, SUM(LineasHis) as LineasHis" & vbCrLf
            sql = sql & " FROM" & vbCrLf
            sql = sql & " (" & vbCrLf
            sql = sql & " SELECT AEN_IdAlbaran as IdAlbaran, AEN_IdPuntoVenta as PV, AEN_Albaran as Albaran, AEN_Fecha as Fecha, " & vbCrLf
            sql = sql & " AEL_Bultos as Bultos, AEL_KilosNetos as Kilos," & vbCrLf
            sql = sql & " (SELECT count(ALC_Id) FROM AlbEntrada_LineasCla WHERE ALC_Idlineaentrada = AEL_IdLinea) as LineasCla," & vbCrLf
            sql = sql & " (SELECT count(AHL_Id) FROM AlbEntrada_HisLineas WHERE AHL_IdLineaEntrada = AEL_IdLinea) as LineasHis" & vbCrLf
            sql = sql & " FROM AlbEntrada" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
            sql = sql & " ) as G" & vbCrLf
            sql = sql & " GROUP BY IdAlbaran, PV, Albaran, Fecha" & vbCrLf


            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

            Dim colSel As New DataColumn("S", GetType(Boolean))
            colSel.DefaultValue = False
            dt.Columns.Add(colSel)


            Grid.DataSource = dt
            AjustaColumnas()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN"
                    c.Visible = False
                Case "S"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select
        Next

            GridView1.BestFitColumns()

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        If XtraMessageBox.Show("¿Desea actualizar los históricos de todos los albaranes de entrada?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            ProgressBar1.Maximum = GridView1.RowCount - 1
            ProgressBar1.Value = 0


            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If row("S") = True Then
                        Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))
                        Agro_GeneraAlbaranEntrada(IdAlbaran)
                    End If

                End If

                ProgressBar1.Value = indice

            Next


            MsgBox("Terminado!")


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

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsulta.Click

        Consultar()

    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click


        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub

    
    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If

        End If

    End Sub
End Class