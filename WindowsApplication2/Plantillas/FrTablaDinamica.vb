Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting

Public Class FrTablaDinamica

    Private _GridControl As DevExpress.XtraGrid.GridControl = Nothing
    Private _Grid As DevExpress.XtraGrid.Views.Grid.GridView = Nothing

    Private _DatosFormularioGrid As String = ""
    Private _Origen As Form = Nothing
    Private _Padre As _FrMPrincipal = Nothing

    Private _ListaCampos As New List(Of PivotGridField)

    Private _LineasDescripcion As New List(Of String)


    Private err As New Errores

    Public Property LineasDescripcion As List(Of String)
        Get
            Return _LineasDescripcion
        End Get
        Set(ByVal value As List(Of String))
            _LineasDescripcion = value
        End Set
    End Property


    Public ReadOnly Property FormularioOrigen As Form
        Get
            Return _Origen
        End Get
    End Property

    Public ReadOnly Property Padre
        Get
            Return _Padre
        End Get
    End Property

    Public Property Gridcontrol As DevExpress.XtraGrid.GridControl
        Get
            Return _GridControl
        End Get
        Set(ByVal value As DevExpress.XtraGrid.GridControl)
            _GridControl = value
        End Set
    End Property

    Public Property Grid As DevExpress.XtraGrid.Views.Grid.GridView
        Get
            Return _Grid
        End Get
        Set(ByVal value As DevExpress.XtraGrid.Views.Grid.GridView)
            _Grid = value
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal origen As Form, ByVal gc As DevExpress.XtraGrid.GridControl, ByVal g As DevExpress.XtraGrid.Views.Grid.GridView)

        InitializeComponent()

        _Origen = origen

        Try

            If Not IsNothing(_Origen.MdiParent) Then _Padre = _Origen.MdiParent

            _DatosFormularioGrid = Idusuario.ToString & "." & _Origen.Name & "." & g.Name

            Me.Text = origen.Text & " - Tabla dinámica"

            _Grid = g
            _GridControl = gc


            If Not IsNothing(gc) Then

                If Not IsNothing(gc.DataSource) Then

                    Dim dtOrigen As DataTable = CType(gc.DataSource, DataTable)
                    Dim dt As DataTable = ActualizaFuenteDatos(dtOrigen, g)
                    PivotGrid.DataSource = dt

                    _ListaCampos.Clear()

                    'Carga los campos
                    For indice As Integer = 0 To dt.Columns.Count - 1

                        Dim bVisible As Boolean = False

                        With g.Columns
                            Dim c As DevExpress.XtraGrid.Columns.GridColumn = .ColumnByFieldName(dt.Columns(indice).ColumnName)
                            If Not IsNothing(c) Then
                                If c.Visible Then bVisible = True
                            End If
                        End With

                        _ListaCampos.Add(New PivotGridField(dt.Columns(indice).ColumnName, PivotArea.FilterArea))
                        _ListaCampos(indice).Name = dt.Columns(indice).ColumnName & indice.ToString

                        'With g.Columns

                        '    Try

                        '        If Not IsNothing(.ColumnByFieldName(dt.Columns(indice).ColumnName)) Then
                        '            'PivotGrid.Fields(dt.Columns(indice).ColumnName).CellFormat = .ColumnByFieldName(dt.Columns(indice).ColumnName).DisplayFormat.FormatString
                        '            PivotGrid.Fields(dt.Columns(indice).ColumnName).CellFormat.FormatString = .ColumnByFieldName(dt.Columns(indice).ColumnName).DisplayFormat.FormatString
                        '        End If

                        '    Catch ex As Exception
                        '        Dim a As String = ""
                        '    End Try

                        'End With


                        If bVisible Then
                            _ListaCampos(indice).AreaIndex = indice
                        Else
                            _ListaCampos(indice).AreaIndex = -1
                        End If

                    Next

                End If


            End If

        Catch ex As Exception
            err.Muestraerror("Error al crear la tabla dinámica", "New", ex.Message)
        End Try


    End Sub


    Private Function ActualizaFuenteDatos(ByVal dtOrigen As DataTable, ByVal g As DevExpress.XtraGrid.Views.Grid.GridView) As DataTable

        Dim dt As DataTable = dtOrigen.Copy
        Dim lst As New List(Of String)      'Contiene las nuevas columnas de los campos calculados


        '1) Añade los campos calculados
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns

            Dim NombreColumna As String = c.FieldName

            If Not dt.Columns.Contains(NombreColumna) Then
                dt.Columns.Add(New DataColumn(c.FieldName, c.ColumnType))
                lst.Add(c.FieldName)

                '1b) Añade a los campos del Pivot
                'Dim pf As New PivotGridField(c.Name, PivotArea.FilterArea)
                'PivotGrid.Fields.Add(pf)
                '_ListaCampos.Add(New PivotGridField(dt.Columns(indice).ColumnName, PivotArea.FilterArea))

            End If

        Next


        '2) Actualiza los datos de la tabla
        For indice As Integer = 0 To g.DataRowCount - 1

            For Each NombreColumna As String In lst
                'Si lo hacemos así y ocultamos los 0, el GetRowCellDisplayText es "", que no es numérico y da error
                'dt.Rows(indice)(NombreColumna) = g.GetRowCellDisplayText(indice, NombreColumna)

                'Hay que pasar el valor de la celda, no el texto
                dt.Rows(indice)(NombreColumna) = g.GetRowCellValue(indice, NombreColumna)
            Next

        Next


        Return dt

    End Function



    'Creamos delegados para poder llamar a las rutinas que utilizan componenetes desde otro hilo
    Private Delegate Sub ShowFields_Delegate(ByVal lst As List(Of PivotGridField))
    Private Sub ShowFields(ByVal lst As List(Of PivotGridField))

        If PivotGrid.Fields.Count < 1 Then
            PivotGrid.Fields.AddRange(lst.ToArray())
        End If

    End Sub

    Private Sub FrTablaDinamica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ShowFields(_ListaCampos)

    End Sub

    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click
        ImprimirExportar()
    End Sub

    Private Sub ImprimirExportar()


        If IsNothing(PivotGrid.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Dim dt As DataTable = CType(PivotGrid.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If


            Catch ex As Exception

            End Try

        End If

        If PivotGrid.IsPrintingAvailable Then

            Dim psu As New PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.Landscape = True
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)


            imprime.Margins.Top = 50
            imprime.Margins.Right = 50
            imprime.Margins.Bottom = 50
            imprime.Margins.Left = 50


            imprime.ShowPreview()

        End If



    End Sub


    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        Dim rec As RectangleF
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)

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


            'Logo
            Try

                rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                e.Graph.DrawImage(logo, rec, BorderSide.None, Color.Transparent)

            Catch ex As Exception

            End Try





            'Separación debajo del logo
            e.Graph.DrawEmptyBrick(New RectangleF(0, logo.Size.Height, e.Graph.ClientPageSize.Width, 10))

            'Línea debajo del logo
            Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

            Dim p1f As New PointF(0, logo.Size.Height + 5)
            Dim p2f As New PointF(e.Graph.ClientPageSize.Width, logo.Size.Height + 5)
            e.Graph.DrawLine(p1f, p2f, c, 1)

            Dim base As Single = p1f.Y + 10

            'Nombre del listado
            Dim nombrelistado As String = "LISTADO " & PivotGrid.Text & " - " & Now.ToString("dd/MM/yyyy")
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

    Private Sub PivotGrid_FieldAreaChanged(sender As System.Object, e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PivotGrid.FieldAreaChanged

        If e.Field.Area = PivotArea.DataArea Then
            If Not IsNothing(_Grid) Then

                If Not IsNothing(_Grid.Columns.ColumnByFieldName(e.Field.FieldName)) Then
                    e.Field.CellFormat.FormatString = _Grid.Columns.ColumnByFieldName(e.Field.FieldName).DisplayFormat.FormatString
                End If

            End If
        End If

    End Sub
End Class