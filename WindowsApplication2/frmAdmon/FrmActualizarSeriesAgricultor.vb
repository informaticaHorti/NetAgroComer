Imports DevExpress.XtraEditors


Public Class FrmActualizarSeriesAgricultor

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmActualizarIdRecogidaAlbaran_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()


        Dim Agricultores As New E_Agricultores(Idusuario, cn)


        Try

            Dim sql As String = "SELECT CDPROVEEDOR, SERIEFACTURAS FROM PROVEEDORES"

            Dim cnHortichuelas As New Cdatos.Conexion(TxCadenaConexion.Text)
            cnHortichuelas.AbrirConexion()

            Dim dtSeries As DataTable = cnHortichuelas.ConsultaSQL(sql)
            If Not IsNothing(dtSeries) Then

                Dim sqlAgr As String = "SELECT AGR_IdAgricultor as CodAgr, AGR_Nombre as Nombre, AGR_Serie as Serie, '' as NuevaSerie" & vbCrLf
                sqlAgr = sqlAgr & " FROM Agricultores" & vbCrLf
                sqlAgr = sqlAgr & " WHERE COALESCE(AGR_Serie, '') = ''" & vbCrLf
                sqlAgr = sqlAgr & " ORDER BY AGR_IdAgricultor" & vbCrLf

                Dim dtAgr As DataTable = Agricultores.MiConexion.ConsultaSQL(sqlAgr)
                If Not IsNothing(dtAgr) Then

                    dtAgr.PrimaryKey = New DataColumn() {dtAgr.Columns("CodAgr")}

                    For Each row As DataRow In dtSeries.Rows

                        Dim CdProveedor As Integer = VaInt(row("CDPROVEEDOR"))
                        Dim SerieFactura As String = (row("SERIEFACTURAS").ToString & "")

                        If SerieFactura.Trim <> "" Then
                            Dim rowAgr As DataRow = dtAgr.Rows.Find(CdProveedor)
                            If Not IsNothing(rowAgr) Then
                                rowAgr("NuevaSerie") = SerieFactura
                            End If
                        End If

                    Next

                End If


                Grid.DataSource = dtAgr

                AjustaColumnas()

            End If



            

            cnHortichuelas.CerrarConexion()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub AjustaColumnas()


        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim
        '        Case "IDALBARAN"
        '            c.Visible = False
        '    End Select
        'Next

        GridView1.BestFitColumns()

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        If XtraMessageBox.Show("¿Desea actualizar las series de los agricultores con las series de la base de datos anterior?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim Agricultores As New E_Agricultores(Idusuario, cn)


            ProgressBar1.Maximum = GridView1.RowCount - 1
            ProgressBar1.Value = 0

            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim IdAgricultor As Integer = (row("CodAgr").ToString & "").Trim
                    Dim NuevaSerie As String = (row("NuevaSerie").ToString & "").Trim

                    If Agricultores.LeerId(IdAgricultor) Then
                        Agricultores.AGR_serie.Valor = NuevaSerie
                        Agricultores.Actualizar()
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

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsulta.Click

        Consultar()

    End Sub
End Class