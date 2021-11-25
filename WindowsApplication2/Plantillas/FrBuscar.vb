Imports DevExpress.XtraGrid.Columns

Public Class FrBuscar
    Dim Primero As Boolean = True
    Dim DtS As DataTable
    Dim ListaColNombre As List(Of String)
    'Dim ListaColLg As List(Of Integer)

    Dim Segundos As Integer = 0
    Dim _Dt As DataTable = Nothing
    Dim _ColumnaBusqueda As String = ""
    Dim _Filtro As String = ""
    Dim _ch1000 As Boolean = False

    Dim _DcParametros As New Dictionary(Of String, Parametros)

    Public Sub InitDta(ByVal Dt As DataTable, ByVal ColumnaBusqueda As String, Optional ByVal Filtro As String = "", Optional ByVal ch1000 As Boolean = False,
                       Optional bBuscarEnTodosLosCampos As Boolean = False)

        _Dt = Dt
        _ColumnaBusqueda = ColumnaBusqueda & ""
        _Filtro = Filtro & ""
        _ch1000 = ch1000

        ChBusca.Checked = bBuscarEnTodosLosCampos


        CargaGrid()

        Grid.DataSource = OrdenaYFiltra(_Dt, ComboBox1.Text, _Filtro)
        CargaComboOrdenarPor()

        If Not IsNothing(Grid.DataSource) Then
            Dim dv As New DataView(Grid.DataSource)
            dv.Sort = ComboBox1.Text
            Grid.DataSource = dv.ToTable
            'GridView1.Columns(ComboBox1.Text).SortIndex = 0
        End If


        AjustaColumnas()
        Application.DoEvents()



    End Sub

    Public Sub InitCol(ParamBusqueda As Dictionary(Of String, Parametros), Ancho As Integer)

        _DcParametros = ParamBusqueda
        If Ancho > 0 Then
            Me.Width = Ancho
        End If
    End Sub


    Private Sub AjustaColumnas()

      
        For Each NombreCampo As String In _DcParametros.Keys

            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreCampo)
            If Not IsNothing(columna) Then

                Dim param As Parametros = _DcParametros(NombreCampo)
                If param.NombreCampo.Trim <> "" Then columna.Caption = param.NombreCampo
                If param.Formato.Trim <> "" Then
                    columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    columna.DisplayFormat.FormatString = param.Formato
                End If
                If param.Longitud < 0 Then columna.Visible = False
                If param.EsResumen Then AñadeResumenCampo(GridView1, NombreCampo, "{0:n2}")

            End If

        Next


        'Una vez hemos quitado las no visibles, ajustamos los tamaños y aplicamos los anchos
        GridView1.BestFitColumns()


        For Each NombreCampo As String In _DcParametros.Keys
            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreCampo)
            If Not IsNothing(columna) Then
                Dim param As Parametros = _DcParametros(NombreCampo)
                If param.Longitud > 0 Then columna.Width = param.Longitud
            End If
        Next

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



                    Dim Nombre As String = (GridView1.GetDataRow(iIndice)(nombrecol).ToString & "").Trim

                    If campoABuscar.ToLower.Trim <> "" Then
                        Dim C As String = ""
                    End If

                    If FnLeft(Nombre.ToUpper, 7) = "FRÜCHTE" And TextBox1.Text.ToUpper = "FRUT" Then
                        Dim a As String = ""
                    End If
                    Dim b As Integer = String.Compare(campoABuscar, TextoBusqueda.ToLower)



                    If campoABuscar <> "" Then
                        If campoABuscar = TextoBusqueda.ToLower Then
                            bEncontrado = True
                            I = iIndice
                            Exit For
                        Else
                            'If campoABuscar >= TextoBusqueda.ToLower Then
                            If String.Compare(campoABuscar, TextoBusqueda.ToLower) >= 0 Then
                                bEncontrado = True
                                I = iIndice
                                Exit For
                            End If
                        End If
                    Else
                        'If campoABuscar >= TextoBusqueda.ToLower Then
                        If String.Compare(campoABuscar, TextoBusqueda.ToLower) >= 0 Then
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

    Private Sub FrBuscar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        'If Primero Then CargaGrid()

        Primero = False
        TextBox1.Select()

        Application.DoEvents()

    End Sub

    Private Sub FrBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.Appearance.Row.Font = New Font("Lucida Sans", 10, FontStyle.Bold)

        GridView1.Appearance.HeaderPanel.GradientMode = Drawing2D.LinearGradientMode.Vertical
        GridView1.Appearance.HeaderPanel.BackColor = Color.FromArgb(192, 192, 255)
        GridView1.Appearance.HeaderPanel.BackColor2 = Color.FromArgb(192, 255, 255)
        GridView1.OptionsBehavior.Editable = False




        BuscarRow = Nothing


        'CargaGrid()

        Timer1.Start()

    End Sub


    Private Sub CargaGrid()

        Application.DoEvents()

        Dim Segundos As Integer = 0



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


        
    End Sub


    Private Sub CargaComboOrdenarPor()

        Dim Dtcol As New DataTable
        Dtcol.Columns.Add(New DataColumn("Id"))
        Dtcol.Columns.Add(New DataColumn("Columna"))


        For indice As Integer = 0 To GridView1.Columns.Count - 1

            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns(indice)
            Dim bVisible As Boolean = True

            If _DcParametros.ContainsKey(columna.FieldName) Then
                If _DcParametros(columna.FieldName).Longitud < 0 Then
                    bVisible = False
                End If
            End If

            If bVisible Then
                Dtcol.Rows.Add(indice, _Dt.Columns(indice).ColumnName)
            End If

        Next


        ComboBox1.DataSource = Dtcol
        ComboBox1.DisplayMember = "Columna"
        ComboBox1.Text = _ColumnaBusqueda


    End Sub

   
    Private Function OrdenaYFiltra(dtOrigen As DataTable, ByVal nombrecolumna As String, Optional Filtro As String = "") As DataTable

        If dtOrigen Is Nothing Then Return dtOrigen
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
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Primero = False Then

            'orden(ComboBox1.Text)
            Grid.DataSource = OrdenaYFiltra(_Dt, ComboBox1.Text, _Filtro)
            AjustaColumnas()

        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.LightYellow
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Down Then
            Grid.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Intro()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If ChBusca.Checked = False Then
            GridView1.ApplyFindFilter("")
            Segundos = 0
        Else
            GridView1.Columns(1).FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
            GridView1.ApplyFindFilter(TextBox1.Text)
        End If

    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            Intro()
        End If

    End Sub

    Private Sub Intro()
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

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub

    Private Sub ChBusca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBusca.CheckedChanged
        GridView1.MoveFirst()
        TextBox1.Select()
    End Sub

    Private Sub Chk1000_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk1000.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Segundos = Segundos + 1

        If Segundos > 5 Then

            If TextBox1.Text <> "" Then
                If ChBusca.Checked = False Then
                    Timer1.Stop()
                    GridView1.MoveFirst()
                    Buscar(TextBox1.Text, False, _ColumnaBusqueda)
                    Timer1.Start()
                End If
            End If

            Segundos = 0

        End If


    End Sub

    Private Sub PlantillaConsulta1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox1.Leave
        Timer1.Stop()
    End Sub

    Private Sub TextBox1_Enter(sender As System.Object, e As System.EventArgs) Handles TextBox1.Enter
        Timer1.Start()
    End Sub


    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If _DcParametros.ContainsKey(e.Column.FieldName) Then

                Dim DcCondiciones As Dictionary(Of Object, Color) = _DcParametros(e.Column.FieldName).DcCondiciones
                If Not IsNothing(DcCondiciones) Then

                    If DcCondiciones.ContainsKey(row(e.Column.FieldName)) Then
                        e.Appearance.BackColor = DcCondiciones(row(e.Column.FieldName))
                        'ElseIf DcCondiciones.ContainsKey(Nothing) Then
                        '    e.Appearance.BackColor = DcCondiciones(Nothing)
                    End If
                    
                End If


            End If

        End If

    End Sub

End Class