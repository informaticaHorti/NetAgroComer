Imports DevExpress.XtraGrid.Columns

Public Class FrBuscarNew

    Dim Primero As Boolean = True
    Dim Buscando As Boolean = False

    Dim DtS As DataTable
    Dim ListaColNombre As List(Of String)
    Dim ListaColLg As List(Of Integer)

    Dim Segundos As Integer = 0
    Dim _Dt As DataTable = Nothing
    Dim _dtOriginal As DataTable = Nothing
    Dim _ColumnaBusqueda As String = ""
    Dim _Filtro As String = ""
    Dim _ch1000 As Boolean = False

    Dim _AuxFiltro As String = ""

    Dim _ValorAnterior As String = ""

    Dim DcTablaCampo As New Dictionary(Of String, DataTable)


    Public Sub InitDta(ByVal Dt As DataTable, ByVal ColumnaBusqueda As String, Optional ByVal Filtro As String = "", Optional ByVal ch1000 As Boolean = False)

        _dtOriginal = Dt
        _Dt = Dt
        _ColumnaBusqueda = ColumnaBusqueda & ""
        _Filtro = Filtro & ""
        _ch1000 = ch1000


        CargaComboOrdenarPor()

        CargaGrid()


    End Sub

    Public Sub InitCol(ByVal listawith As List(Of Integer))

        ListaColLg = listawith

        If IsNothing(ListaColLg) Then
            GridView1.OptionsView.ColumnAutoWidth = True
        ElseIf ListaColLg.Count = 0 Then
            GridView1.OptionsView.ColumnAutoWidth = True
        Else
            GridView1.OptionsView.ColumnAutoWidth = False
        End If

    End Sub


    Private Sub AjustaColumnas()

        If ListaColLg Is Nothing Then Exit Sub
        If ListaColLg.Count = 0 Then Exit Sub


        Dim r As Integer = 0
        Dim c As New DevExpress.XtraGrid.Columns.GridColumn
        For Each c In GridView1.Columns
            If r <= ListaColLg.Count - 1 Then
                If ListaColLg(r) = -1 Then
                    c.Visible = False
                Else
                    c.Width = ListaColLg(r)
                End If
                r = r + 1
            End If
        Next

        GridView1.BestFitColumns()



    End Sub

    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    Private Function Buscar(ByVal sTexto As String, ByVal Siguiente As Boolean, ByVal nombrecol As String) As Boolean

        Dim Err As Errores = Nothing

        Try

            Dim iInicio As Integer
            Dim bEncontrado As Boolean = False

            Dim TextoBusqueda As String = ""
            TextoBusqueda = sTexto


            Dim I As Integer = 0

            Try

                For iIndice As Integer = iInicio To GridView1.RowCount - 1

                    If GridView1.GetDataRow(iIndice) Is Nothing Then
                        Exit For
                    End If

                    Dim campoABuscar As String = GridView1.GetDataRow(iIndice)(nombrecol).ToString

                    campoABuscar = campoABuscar + Space(100)
                    campoABuscar = campoABuscar.Substring(0, TextoBusqueda.Length)
                    campoABuscar = campoABuscar.ToLower


                    Dim tipo As Type = GetType(String)
                    If _Dt.Columns.Contains(ComboBox1.Text.Trim) Then
                        tipo = _Dt.Columns(ComboBox1.Text.Trim).DataType
                    End If


                    If campoABuscar <> "" Then
                        If campoABuscar = TextoBusqueda.ToLower Then
                            bEncontrado = True
                            I = iIndice
                            Exit For
                        Else
                            If ComparaCampo(campoABuscar, TextoBusqueda.ToLower, tipo) >= 0 Then
                                bEncontrado = True
                                I = iIndice
                                Exit For
                            End If
                        End If
                    Else
                        If ComparaCampo(campoABuscar, TextoBusqueda.ToLower, tipo) >= 0 Then
                            bEncontrado = True
                            I = iIndice
                            Exit For
                        End If
                    End If


                Next
            Catch ex As Exception
                bEncontrado = False
            End Try


            If bEncontrado = True Then
                GridView1.SelectRow(I)
                GridView1.MoveBy(I)

            End If

            Return bEncontrado

        Catch ex As Exception
            Err.Muestraerror("No se pudo buscar el texto " & sTexto & " de la columna " & nombrecol & "  en el grid " & GridView1.Name, "Function Buscar()", ex.Message)
            Return False
        End Try

    End Function


    Private Function ComparaCampo(campoABuscar As String, TextoBusqueda As String, Tipo As System.Type) As String

        Dim res As Integer


        If Not IsDate(TextoBusqueda) And Not IsNumeric(TextoBusqueda) Then Tipo = GetType(String)


        Select Case Tipo

            Case GetType(DateTime)
                'Fecha
                res = Date.Compare(VaDate(campoABuscar), VaDate(TextoBusqueda))

            Case GetType(Date)
                'Fecha
                res = Date.Compare(VaDate(campoABuscar), VaDate(TextoBusqueda))

            Case GetType(Char), GetType(String)
                'Cadenas
                res = String.Compare(campoABuscar, TextoBusqueda.ToLower)

            Case Else
                'Numéricos en general
                res = Decimal.Compare(VaDec(campoABuscar), VaDec(TextoBusqueda.ToLower))

        End Select



        Return res

    End Function



    Private Sub FrBuscar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        'Primero = False
        CbBuscar.SelectAll()
        CbBuscar.Focus()

        Application.DoEvents()

    End Sub

    Private Sub FrBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        BuscarRow = Nothing


        'CbBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'CbBuscar.DropDownStyle = ComboBoxStyle.DropDown
        'CbBuscar.AutoCompleteSource = AutoCompleteSource.ListItems


        Timer1.Start()

    End Sub


    Private Sub CargaGrid()

        Application.DoEvents()

        Dim Segundos As Integer = 0
        GridView1.Appearance.Row.Font = New Font("Verdana", 8)


        If _ch1000 = True Then
            Chk1000.Checked = True
            Chk1000.Visible = True
            Panel1.Visible = False
            ChBusca.Visible = False
            GridView1.OptionsCustomization.AllowSort = True
            Application.DoEvents()
        Else
            Chk1000.Visible = False
            Panel1.Visible = True
            ChBusca.Visible = True
            Application.DoEvents()
        End If


        Application.DoEvents()
        Grid.DataSource = OrdenaYFiltra(_Dt, ComboBox1.Text, _Filtro)
        Application.DoEvents()

        AjustaColumnas()
        Application.DoEvents()

    End Sub


    Private Sub CargaComboOrdenarPor()

        Dim Dtcol As New DataTable
        Dim j = 0
        Dim indiceCol As Integer = 0

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Columna"))


        If Not IsNothing(ListaColLg) Then
            For r As Integer = 0 To _Dt.Columns.Count - 1
                If r <= ListaColLg.Count - 1 Then
                    If ListaColLg(r) > -1 Then
                        'Visible
                        Dtcol.Rows.Add(r, _Dt.Columns(r).ColumnName)
                        If _ColumnaBusqueda.ToLower = _Dt.Columns(r).ColumnName.ToLower Then
                            indiceCol = r
                        End If
                    End If
                End If
            Next
        Else
            For r As Integer = 0 To _Dt.Columns.Count - 1
                Dtcol.Rows.Add(r, _Dt.Columns(r).ColumnName)
                If _ColumnaBusqueda.ToLower = _Dt.Columns(r).ColumnName.ToLower Then
                    indiceCol = r
                End If
            Next
        End If



        ComboBox1.DataSource = Dtcol
        ComboBox1.DisplayMember = "Columna"
        Primero = False
        ComboBox1.Text = _ColumnaBusqueda


        'Inicializamos las tablas distinct
        For Each row As DataRow In Dtcol.Rows
            Dim campo As String = (row("Columna").ToString & "").Trim
            DcTablaCampo(campo) = Nothing
        Next

        'Cargamos la primera tabla
        CargaDistinct(_ColumnaBusqueda.Trim)


    End Sub


    Private Sub CargaDistinct(campo As String)

        If DcTablaCampo.ContainsKey(campo) Then

            If IsNothing(DcTablaCampo(campo)) Then

                Dim dv As New DataView(_Dt)
                dv.RowFilter = _Filtro
                dv.Sort = campo
                Dim dt As DataTable = dv.ToTable(True, campo)
                DcTablaCampo(campo) = dt

            End If

            Buscando = True
            CbBuscar.DataSource = DcTablaCampo(campo)
            CbBuscar.DisplayMember = campo
            CbBuscar.SelectedIndex = -1
            Buscando = False

        Else
            CbBuscar.DataSource = Nothing
        End If

    End Sub


    Private Function OrdenaYFiltra(dtOrigen As DataTable, ByVal nombrecolumna As String, Optional Filtro As String = "") As DataTable

        Dim dt As DataTable = dtOrigen.Copy
        Dim err As New Errores


        If nombrecolumna.Trim <> "" Or Filtro.Trim <> "" Then

            Try

                Dim dv As New DataView(dt)

                If nombrecolumna.Trim <> "" Then

                    GridView1.OptionsCustomization.AllowSort = True
                    dv.Sort = nombrecolumna & " ASC"
                    _ColumnaBusqueda = nombrecolumna ' MODIFICADO 04-06-2013
                    GridView1.OptionsCustomization.AllowSort = False

                End If

                If Filtro.Trim <> "" Then
                    dv.RowFilter = Filtro
                End If

                dt = dv.ToTable

            Catch ex As Exception
                err.Muestraerror("Error al ejecutar el orden de la columna " & nombrecolumna, "sub orden", ex.Message)
            End Try

        End If

        Return dt

    End Function


    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        CbBuscar.BackColor = Color.White
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        If Primero = False Then

            CbBuscar.Text = ""

            Grid.DataSource = OrdenaYFiltra(_Dt, ComboBox1.Text, _Filtro)
            AjustaColumnas()

            CargaDistinct((ComboBox1.Text & "").Trim)

        End If

        'CbBuscar.SelectAll()
        'CbBuscar.Focus()


    End Sub


    'Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress

    '    If e.KeyChar = Chr(13) Then
    '        Intro()
    '    End If

    'End Sub


    Private Sub Intro()

        If CbBuscar.Focused Then
            CompruebaBusqueda(True)
            Grid.Select()
            Grid.Focus()
            Exit Sub
        End If

        Dim row As System.Data.DataRow

        row = GridView1.GetFocusedDataRow()
        If Not row Is Nothing Then
            BuscarRow = row
            Me.Close()
        End If

    End Sub


    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)
        BuscarRow = row
        Me.Close()
    End Sub


    Private Sub ChBusca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBusca.CheckedChanged
        GridView1.MoveFirst()
        CbBuscar.SelectAll()
        CbBuscar.Focus()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        CompruebaBusqueda(False)

    End Sub


    Private Sub CompruebaBusqueda(bIntro As Boolean)

        Segundos = Segundos + 1

        If Segundos > 5 Or bIntro Then


            Dim tipo As Type = GetType(String)
            If _dtOriginal.Columns.Contains(ComboBox1.Text.Trim) Then
                tipo = _dtOriginal.Columns(ComboBox1.Text.Trim).DataType
            End If

            Dim filtro As String = ""
            If CbBuscar.Text.Trim <> "" Then

                Select Case tipo

                    Case GetType(String), GetType(Char)
                        'String
                        filtro = ComboBox1.Text & " LIKE '" & CbBuscar.Text & "%'"

                    Case GetType(Date), GetType(DateTime)
                        'Fecha
                        If IsDate(CbBuscar.Text) Then
                            filtro = ComboBox1.Text.Trim & " = '" & CbBuscar.Text & "'"
                        End If

                    Case Else
                        'Numérico: sólo filtra cuando damos al intro
                        If IsNumeric(CbBuscar.Text) And bIntro Then
                            filtro = ComboBox1.Text.Trim & " = " & CbBuscar.Text
                        End If
                        'If IsNumeric(CbBuscar.Text) Then
                        '    filtro = "CONVERT(" & ComboBox1.Text & ", System.String) LIKE '" & CbBuscar.Text & "%'"
                        'End If

                End Select


            End If



            If (CbBuscar.Text & "") <> "" Or _AuxFiltro <> filtro Then
                If ChBusca.Checked = False Then
                    Timer1.Stop()

                    'Filtra grid principal
                    If _AuxFiltro <> filtro Then

                        _AuxFiltro = filtro

                        If _Filtro.Trim <> "" Then

                            If filtro.Trim <> "" Then
                                filtro = _Filtro & " AND " & filtro
                            Else
                                filtro = _Filtro
                            End If

                        End If

                        Dim dt As DataTable = OrdenaYFiltra(_dtOriginal, ComboBox1.Text.Trim, filtro)
                        Grid.DataSource = dt

                    End If

                    GridView1.MoveFirst()
                    Buscar((CbBuscar.Text & ""), False, _ColumnaBusqueda)

                    Timer1.Start()

                End If
            End If

            Segundos = 0

        End If

    End Sub


    Private Sub CbBuscar_Enter(sender As System.Object, e As System.EventArgs) Handles CbBuscar.Enter
        CbBuscar.BackColor = Color.LightYellow
        Timer1.Start()
    End Sub


    Private Sub CbBuscar_Leave(sender As System.Object, e As System.EventArgs) Handles CbBuscar.Leave
        Timer1.Stop()
    End Sub


    Private Sub CbBuscar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbBuscar.KeyDown

        If e.KeyCode = Keys.Enter Or (e.KeyCode = Keys.Right And CbBuscar.SelectionStart = CbBuscar.Text.Length) Then

            Intro()

        ElseIf e.KeyCode = Keys.Left And CbBuscar.SelectionStart = 0 Then

            ComboBox1.DroppedDown = True
            ComboBox1.Select()
            ComboBox1.Focus()

        ElseIf e.KeyCode = Keys.Escape Then

            If CbBuscar.Text <> "" Then
                _ValorAnterior = CbBuscar.Text
                CbBuscar.Text = ""
            Else
                CbBuscar.Text = _ValorAnterior
                CbBuscar.SelectAll()
            End If

        ElseIf e.KeyCode = Keys.F2 Then
            CbBuscar.DroppedDown = Not CbBuscar.DroppedDown
        End If

    End Sub


    Private Sub CbBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles CbBuscar.TextChanged

        If Not Buscando Then

            If ChBusca.Checked = False Then
                Segundos = 0
            Else
                GridView1.Columns(1).FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
                GridView1.ApplyFindFilter(CbBuscar.Text & "")
            End If

        Else
            CbBuscar.Text = ""
        End If

    End Sub


    Private Sub ComboBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Right Then
            CbBuscar.SelectAll()
            CbBuscar.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            ComboBox1.DroppedDown = Not ComboBox1.DroppedDown
        End If

    End Sub

    Private Sub GridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown

        If e.KeyCode = Keys.Enter Then

            Intro()

        ElseIf e.KeyCode = Keys.Up Then

            If GridView1.FocusedRowHandle = 0 Then
                CbBuscar.SelectAll()
                CbBuscar.Focus()
            End If

        End If

    End Sub
End Class