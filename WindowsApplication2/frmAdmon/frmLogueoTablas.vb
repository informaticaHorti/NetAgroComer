Public Class frmLogueoTablas

    Private err As New Errores

    Private LogTablas As New E_LogTablas(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim lc As New List(Of Object)
        ListaControles = lc

        EntidadFrm = LogTablas

    End Sub


    Public Overrides Sub BorraPan()

    End Sub


    Public Overrides Sub Guardar()

        'No loguear ninguna tabla
        LogTablas.NoRegistrarTablas()

        'Loguear sólo las marcadas
        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)

            If row("LogSN") = True Then
                Dim Tabla As String = (row("Tabla").ToString & "").Trim
                LogTablas.RegistrarTabla(Tabla)
            End If

        Next


    End Sub


    Public Overrides Sub Modificar()
        Modificando = True
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("LogSN")) Then
            GridView1.Columns.ColumnByFieldName("LogSN").OptionsColumn.AllowEdit = True
        End If

    End Sub


    Private Sub frmLogueoTablas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        PanelId.Visible = False

        Button1.Visible = False
        BAnular.Visible = False
        GridView1.OptionsBehavior.Editable = False


        'Obtengo las tablas de la aplicación
        Dim dt As DataTable = ObtenerTablasAplicacion()
        Grid.DataSource = dt


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("LogSN")) Then
            With GridView1.Columns.ColumnByFieldName("LogSN")
                .OptionsColumn.AllowEdit = False
                .Width = 20
                .MaxWidth = 75
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With
        End If


        'Muestro el valor del campo LogSN de cada tabla
        SqlGrid()

    End Sub


    Private Sub SqlGrid()

        Dim dt As DataTable = LogTablas.Tablas

        Dim DcTablas As New Dictionary(Of String, Boolean)
        For Each row As DataRow In dt.Rows
            Dim Tabla As String = (row("Tabla").ToString & "").Trim.ToLower
            Dim SN As Boolean = (row("LogSN").ToString & "").Trim.ToUpper = "S"
            DcTablas(Tabla) = SN
        Next


        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            Dim Tabla As String = (row("Tabla").ToString & "").Trim.ToLower
            If DcTablas.ContainsKey(Tabla) Then
                If DcTablas(Tabla) Then
                    row("LogSN") = True
                Else
                    row("LogSN") = False
                End If
            End If
        Next


    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("LogSN")) Then
            If GridView1.Columns.ColumnByFieldName("LogSN").OptionsColumn.AllowEdit Then

                For indice As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    row("LogSN") = True
                Next

            End If
        End If

    End Sub

    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("LogSN")) Then
            If GridView1.Columns.ColumnByFieldName("LogSN").OptionsColumn.AllowEdit Then

                For indice As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    row("LogSN") = False
                Next

            End If
        End If


    End Sub


    Private Sub GridView1_RowClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("LogSN")) Then

            If GridView1.Columns.ColumnByFieldName("LogSN").OptionsColumn.AllowEdit Then

                If row("LogSN") = True Then
                    row("LogSN") = False
                Else
                    row("LogSN") = True
                End If

            End If

        End If


    End Sub
End Class
