Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing



Public Class FrmConsultaSalidasCostesPartida


    Private AlbSalida As New E_AlbSalida(Idusuario, cn)


    Private err As New Errores

    Private _IdLineaPalet As String = ""
    Private _LineasDescripcion As New List(Of String)


    Public Event AntesCargarDataTable()
    Public Event DespuesCargarDataTable()


    Public Property LineasDescripcion As List(Of String)
        Get
            Return _LineasDescripcion
        End Get
        Set(ByVal value As List(Of String))
            _LineasDescripcion = value
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal IdLineaPalet As String)

        InitializeComponent()

        _IdLineaPalet = IdLineaPalet

    End Sub


    Private Sub FrmConsultaSalidasCostesPalets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ttImprimir.SetToolTip(btImprimir, "Imprimir")
        ttImprimir.SetToolTip(btImpresionDirecta, "Impresion directa")
        ttImprimir.SetToolTip(btSalir, "Salir")

        CargaGrid()


    End Sub


    Protected Overridable Sub CargaGrid()

        RaiseEvent AntesCargarDataTable()


        Dim sql As String = AlbSalida.ConsultaCostesPartida(_IdLineaPalet, True)
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        Grid.DataSource = dt
        AjustaColumnas()

        RaiseEvent DespuesCargarDataTable()

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDLINEAENTRADA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "PALET"
                    c.Width = "70"
                Case "FECHA"
                    c.Width = "75"
                Case "KILOS", "BULTOS"
                    c.Width = "75"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PRECIO"
                    c.Width = "75"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"

            End Select
        Next

        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("Bultos", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "Precio", "{0:n6}", DevExpress.Data.SummaryItemType.Average)


    End Sub



    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub


    Protected Sub AñadeResumenCampo(ByVal NombreColumna As String, ByVal Formato As String, Optional ByVal Tipo As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)

        Try

            If Not IsNothing(GridView1.Columns.ColumnByFieldName(NombreColumna)) Then

                Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreColumna)

                columna.SummaryItem.DisplayFormat = Formato
                columna.SummaryItem.SummaryType = Tipo
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

                Dim item As New DevExpress.XtraGrid.GridGroupSummaryItem
                item.FieldName = columna.FieldName
                item.SummaryType = Tipo
                item.DisplayFormat = Formato
                item.ShowInGroupColumnFooter = columna
                GridView1.GroupSummary.Add(item)
                GridView1.UpdateSummary()

                GridView1.OptionsView.ShowFooter = True
                GridView1.OptionsView.ShowGroupedColumns = True

            End If

        Catch ex As Exception
            err.Muestraerror("Error al aplicar el resumen del campo " & NombreColumna, "AñadeResumenCampo", ex.Message)
        End Try
    End Sub


    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        Dim rec As RectangleF
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)

        'Logo
        Try

            Dim s As New SizeF(0, 0)

            'Logo
            Try

                Dim fichero_logo As String = "logo.png"

                Select Case MiMaletin.IdEmpresaCTB
                    Case 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
                End Select

                Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                e.Graph.DrawImage(logo, rec, BorderSide.None, Color.Transparent)
                s = logo.Size

            Catch ex As Exception

            End Try


            'Separación debajo del logo
            e.Graph.DrawEmptyBrick(New RectangleF(0, s.Height, e.Graph.ClientPageSize.Width, 10))

            'Línea debajo del logo
            Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

            Dim p1f As New PointF(0, s.Height + 5)
            Dim p2f As New PointF(e.Graph.ClientPageSize.Width, s.Height + 5)
            e.Graph.DrawLine(p1f, p2f, c, 1)

            Dim base As Single = p1f.Y + 10

            'Nombre del listado
            Dim nombrelistado As String = "LISTADO " & Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
            If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

            'Espacio en blanco debajo del nombre del listado
            rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
            e.Graph.DrawString(nombrelistado, c, rec, BorderSide.None)

            base = base + 25


            If _LineasDescripcion.Count > 0 Then

                e.Graph.Font = New Font("Arial", 11, FontStyle.Regular)

                For Each linea As String In _LineasDescripcion

                    rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 20)
                    e.Graph.DrawString(linea, c, rec, BorderSide.None)
                    base = base + 20

                Next

            End If


            'Último separador en blanco
            e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



        Catch ex As Exception


        End Try

    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        ImprimirExportar(True)
    End Sub


    Private Sub ImprimirExportar(ByVal bPrevisualizar As Boolean)


        If IsNothing(Grid.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If


            Catch ex As Exception

            End Try

        End If

        If Grid.IsPrintingAvailable Then

            Dim psu As New PrinterSettingsUsing
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

            If bPrevisualizar Then
                imprime.ShowPreview()
            Else
                imprime.CreateDocument()
                Dim prt As New PrinterSettings
                prtSystem.Print(prt.PrinterName)
            End If


        End If



    End Sub

    Private Sub btImpresionDirecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImpresionDirecta.Click
        ImprimirExportar(False)
    End Sub

    
End Class




