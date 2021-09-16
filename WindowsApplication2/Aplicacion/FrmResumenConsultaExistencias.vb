Public Class FrmResumenConsultaExistencias

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Private _dt As DataTable = Nothing
    Private _x As Integer = Me.Location.X
    Private _y As Integer = Me.Location.Y


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(dt As DataTable, x As Integer, y As Integer)
        Me.New()

        _dt = dt
        _x = x
        _y = y

    End Sub


    Private Sub FrmResumenConsultaExistencias_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.Location = New Point(_x, _y)


        GridResumen.DataSource = _dt
        AjustaColumnas(GridViewResumen)

    End Sub


    Private Sub AjustaColumnas(gridview As DevExpress.XtraGrid.Views.Grid.GridView)


        gridview.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PARTIDA", "LOTE", "ALBARAN"
                    c.Width = 90
                Case "CATEGORIA"
                    c.Width = 100
                    c.MaxWidth = 120
                Case "PRODUCTO"
                    c.Width = 200
                    c.MaxWidth = 220
                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "DIAS"
                    c.MinWidth = 40
                    c.MaxWidth = 40
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "KILOSPARTIDA", "KILOSLOTE", "KILOSCONSUMIDOS", "KILOSENLOTES", "KILOS"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    Funciones.AñadeResumenCampo(gridview, c.FieldName, "{0:n0}")

                Case "NETO"
                    c.Caption = "Existencias"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    Funciones.AñadeResumenCampo(gridview, c.FieldName, "{0:n0}")
                Case "PRE"
                    c.MinWidth = 35
                    c.MaxWidth = 35
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "CAL"
                    c.MinWidth = 35
                    c.MaxWidth = 35
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End Select
        Next

    End Sub


    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click

        Me.Close()

    End Sub




    
End Class
