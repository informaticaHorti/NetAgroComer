Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing



Public Class FrConsultaGenerica

    Private err As New Errores

    Private _Resultado As DialogResult = Windows.Forms.DialogResult.Cancel
    Private _DataTable As DataTable = Nothing
    Private _CamposTotales As New List(Of String)
    Private _Parametros As New List(Of Parametros)
    Private _LineasDescripcion As New List(Of String)
    Private _AlturaMax As Integer = 600
    Private _AnchoMax As Integer = 800


    Public Event AntesCargarDataTable()
    Public Event DespuesCargarDataTable()

    Public Property AlturaMax As Integer
        Get
            Return _AlturaMax
        End Get
        Set(ByVal value As Integer)
            _AlturaMax = value
        End Set
    End Property

    Public Property AnchoMax As Integer
        Get
            Return _AnchoMax
        End Get
        Set(ByVal value As Integer)
            _AnchoMax = value
        End Set
    End Property


    Public Property Datatable As DataTable
        Get
            Return _DataTable
        End Get
        Set(ByVal value As DataTable)

            _DataTable = value
            If Not IsNothing(_DataTable) Then
                CargaGrid()
            End If

        End Set
    End Property


    Public Property CamposTotales As List(Of String)
        Get
            Return _CamposTotales
        End Get
        Set(ByVal value As List(Of String))
            _CamposTotales = value
        End Set
    End Property


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


    Public Sub New(ByVal dt As DataTable, ByVal lstParametros As List(Of Parametros), ByVal TextoFormulario As String)

        InitializeComponent()

        _DataTable = dt


        _Parametros = lstParametros

        For Each p As Parametros In lstParametros
            If p.EsResumen Then _CamposTotales.Add(p.NombreCampo)
        Next

        Me.Text = TextoFormulario

    End Sub

    Private Sub FrConsultaGenerica_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Me.DialogResult = _Resultado

    End Sub


    Private Sub FrConsultaGenerica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ttImprimir.SetToolTip(btImprimir, "Imprimir")
        ttImprimir.SetToolTip(btImpresionDirecta, "Impresion directa")
        ttImprimir.SetToolTip(btSalir, "Salir")

        If Not IsNothing(_DataTable) Then
            CargaGrid()
        End If


    End Sub


    Protected Overridable Sub CargaGrid()

        RaiseEvent AntesCargarDataTable()

        Grid.DataSource = _DataTable

        For Each campo As String In _CamposTotales
            AñadeResumenCampo(campo, "{0:n2}")
        Next


        If _DataTable.Columns.Count > 0 Then


            Dim AnchoTotal As Integer = 0
            For Each p As Parametros In _Parametros
                If p.Longitud >= 0 Then
                    AnchoTotal = AnchoTotal + p.Longitud
                End If
            Next
            AnchoTotal = AnchoTotal + ((_DataTable.Columns.Count - _Parametros.Count) * 100)
            AnchoTotal = AnchoTotal + (Me.Width - Me.Grid.Width)

            If AnchoTotal < AnchoMax Then
                Me.Width = AnchoTotal
            End If



        Else
            Me.Width = AnchoMax
        End If

        If _DataTable.Rows.Count > 0 Then
            If 45 + (35 * _DataTable.Rows.Count) < AlturaMax Then
                Me.Height = 150 + (35 * _DataTable.Rows.Count)
            End If
        Else
            Me.Height = AlturaMax
        End If


        GridView1.BestFitColumns()

        For Each p As Parametros In _Parametros

            Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(p.NombreCampo)
            If Not IsNothing(col) Then

                If p.Formato.Trim <> "" Then
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    col.DisplayFormat.FormatString = p.Formato
                End If
                If p.Longitud > 0 Then col.Width = p.Longitud
                If p.Longitud < 0 Then col.Visible = False
            End If

        Next

        RaiseEvent DespuesCargarDataTable()

    End Sub


    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click

        RowDePaso = Nothing
        Me.Close()

    End Sub


    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)

        If Not IsNothing(row) Then
            RowDePaso = row
            _Resultado = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

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

            Dim fichero_logo As String = "logo.png"

            Select Case MiMaletin.IdEmpresaCTB
                Case 1
                    fichero_logo = "logo.png"
                Case Else
                    fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
            End Select


            Try
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

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub
End Class


Public Class Parametros

    Public NombreCampo As String
    Public EsResumen As Boolean
    Public Formato As String
    Public Longitud As Integer

    Public DcCondiciones As Dictionary(Of Object, Color) = Nothing

    Public Sub New(ByVal NombreCampo As String, ByVal EsResumen As Boolean, ByVal Formato As String, ByVal Longitud As Integer,
                   Optional DcCondiciones As Dictionary(Of Object, Color) = Nothing)

        Me.NombreCampo = NombreCampo
        Me.EsResumen = EsResumen
        Me.Formato = Formato
        Me.Longitud = Longitud

        Me.DcCondiciones = DcCondiciones

    End Sub

End Class

