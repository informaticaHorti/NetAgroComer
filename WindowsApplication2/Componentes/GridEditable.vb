Public Class GridEditable


    Public Structure Celda
        Dim RowHandle As Single
        Dim FieldName As String
    End Structure

    Public Structure CampoTabla
        Dim Nombre As String
        Dim Tipo As Cdatos.TiposCampo
        Dim Longitud As Integer
        Dim NumDecimales As Integer
        Dim Mcadena As String
        Dim Obligatorio As Boolean
    End Structure


    Public Event AntesDeEditar(row As DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
    Public Event DespuesDeEditar(row As DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
    Public Event CancelarEdicion()
    Public Event GuardarCambios(row As DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
    Public Event Valida(row As DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
    Public Event RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
    Public Event ProcessGridKey(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
    Public Event CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)
    Public Event ColumnaSiguiente(IndiceFila As Integer, IndiceColumna As Integer, ByRef NuevaFila As Integer, ByRef NuevaColumna As Integer)
    Public Event ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
    Public Event RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)


    Public _lstCambios As New List(Of Celda)
    Public _dtOriginal As DataTable = Nothing
    Public _dcEditables As New Dictionary(Of String, CampoTabla)

    Private repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()


    Dim _Orden As Integer = -1

    Public Property Orden As Integer
        Set(ByVal value As Integer)
            _Orden = value

        End Set
        Get
            Return _Orden

        End Get
    End Property


    Dim _NavegarSoloEditables As Boolean = False
    Public Property NavegarSoloEditables As Boolean
        Get
            Return _NavegarSoloEditables
        End Get
        Set(value As Boolean)
            _NavegarSoloEditables = value
        End Set
    End Property



    Public Property DataSource As DataTable

        Get
            Return Grid.DataSource
        End Get

        Set(value As DataTable)

            'Guarda copia del original
            If Not IsNothing(value) Then
                _dtOriginal = CType(value, DataTable).Copy
            End If

            GridView.Columns.Clear()
            Grid.DataSource = value

            'Por defecto, todas no editables
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
                col.OptionsColumn.AllowEdit = False
            Next

        End Set

    End Property


    

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ToolTipGridEditable.SetToolTip(BtGuardar, "Guardar cambios")
        ToolTipGridEditable.SetToolTip(BtCancelar, "Deshacer cambios")


        repositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper

    End Sub


    'Por si nos es más cómodo tratar con un bdcampo
    Public Sub Campo(ByVal Nombre As String, ByVal Campo As Cdatos.bdcampo, Optional bEditable As Boolean = False,
                     Optional bVisible As Boolean = True, Optional bTotal As Boolean = False,
                     Optional bObligatorio As Boolean = False, Optional ancho As Integer = 0)

        Me.Campo(Nombre, Campo.TipoBd, Campo.Longitud, Campo.Decimales, bEditable, bVisible, bTotal, bObligatorio, ancho)

    End Sub


    Public Sub Campo(ByVal Nombre As String, ByVal Tipo As Cdatos.TiposCampo, ByVal lg As Integer, Optional ByVal NumDecimales As Integer = 0,
                     Optional bEditable As Boolean = False, Optional bVisible As Boolean = True, Optional bTotal As Boolean = False,
                     Optional bObligatorio As Boolean = False, Optional ancho As Integer = 0)

        With GridView.Columns

            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = .ColumnByFieldName(Nombre)
            If Not IsNothing(columna) Then

                columna.OptionsColumn.AllowEdit = bEditable
                columna.Visible = bVisible
                If ancho > 0 Then columna.Width = ancho

                'Formato
                If Tipo = Cdatos.TiposCampo.Entero Or Tipo = Cdatos.TiposCampo.EnteroPositivo Or Tipo = Cdatos.TiposCampo.Importe Then

                    Dim Formato As String = "#,##0"
                    Dim FormatoTotal As String = "{0:n0}"

                    If Tipo = Cdatos.TiposCampo.Importe Then
                        If NumDecimales > 0 Then
                            Formato = Formato & "." & "".PadRight(NumDecimales, Convert.ToChar("0"))
                            FormatoTotal = "{0:n" & NumDecimales.ToString & "}"
                        End If
                    End If

                    columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    columna.DisplayFormat.FormatString = Formato

                    'Total
                    If bTotal Then
                        AñadeResumenCampo(GridView, columna.FieldName, FormatoTotal)
                    End If

                End If



                'Almacenamos los datos del campo editable
                Dim campo As New CampoTabla
                campo.Nombre = Nombre.ToUpper.Trim
                campo.Tipo = Tipo
                campo.Longitud = lg
                campo.NumDecimales = NumDecimales
                campo.Obligatorio = bObligatorio

                Select Case campo.Tipo
                    Case Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.CadenaNumero, Cdatos.TiposCampo.Fecha, Cdatos.TiposCampo.Hora, Cdatos.TiposCampo.Cuenta, Cdatos.TiposCampo.CuentaCliente
                        campo.Mcadena = "0123456789"
                    Case Cdatos.TiposCampo.Entero
                        campo.Mcadena = "01234567890-"
                    Case Cdatos.TiposCampo.Importe
                        campo.Mcadena = "0123456789.,-"
                    Case Cdatos.TiposCampo.FechaHora
                        campo.Mcadena = "0123456789:/ "
                    Case Else
                        campo.Mcadena = ""
                End Select

                _dcEditables(campo.Nombre) = campo


                columna.ColumnEdit = repositoryItemTextEdit1


                'Marcamos las cabeceras de los campos editables
                If bEditable Then
                    Dim fuente As Font = columna.AppearanceHeader.Font
                    Dim nueva_fuente As New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)
                    columna.AppearanceHeader.Font = nueva_fuente
                End If


            End If

        End With

    End Sub


    'Cancela la edicion y mantiene los valores anteriores
    Private Sub BtCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtCancelar.Click

        RaiseEvent CancelarEdicion()
        Grid.DataSource = _dtOriginal.Copy

        _lstCambios.Clear()
        GridView.ClearColumnErrors()

        BtGuardar.Enabled = False
        BtCancelar.Enabled = False

        Siguiente()

    End Sub


    'Guarda los cambios
    Private Sub BtGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtGuardar.Click

        Try

            For Each celda As Celda In _lstCambios

                Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView.Columns.ColumnByFieldName(celda.FieldName)

                If celda.RowHandle >= 0 And celda.RowHandle < GridView.RowCount And Not IsNothing(col) Then
                    RaiseEvent GuardarCambios(GridView.GetDataRow(celda.RowHandle), col)
                End If

            Next

            _lstCambios.Clear()
            GridView.ClearColumnErrors()

            BtGuardar.Enabled = False
            BtCancelar.Enabled = False

            Siguiente()

        Catch ex As Exception
        End Try


    End Sub


    Private Sub GridView_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanging

        If e.RowHandle >= 0 Then
            Dim row As DataRow = GridView.GetDataRow(e.RowHandle)
            RaiseEvent AntesDeEditar(row, e.Column)

            BtGuardar.Enabled = True
            BtCancelar.Enabled = True
        End If

    End Sub

    Private Sub GridView_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanged

        If e.RowHandle >= 0 Then

            Dim row As DataRow = GridView.GetDataRow(e.RowHandle)

            'Actualiza grid
            GridView.RefreshData()

            'Evento DespuesDeEditar va antes que Evento Validar
            RaiseEvent DespuesDeEditar(row, e.Column)

            'Mostrar error en caso de no pasar la validación
            Validar(row, e.Column)


            'Si no hay error, incluimos la celda en la lista de cambios
            If Not GridView.HasColumnErrors Then

                Dim celda As New Celda
                celda.RowHandle = e.RowHandle
                celda.FieldName = e.Column.FieldName
                _lstCambios.Add(celda)

                SiguienteColumna(e.Column.VisibleIndex, e.RowHandle)

            Else
                BtGuardar.Enabled = False
            End If

        End If

    End Sub


    Private Sub SiguienteColumna(IndiceColumna As Integer, IndiceFila As Integer)

        'Pasamos a la siguiente celda
        Dim SiguienteColumna As Integer = IndiceColumna + 1


        Try

            Dim NuevaFila As Integer = -1
            Dim NuevaColumna As Integer = -1

            RaiseEvent ColumnaSiguiente(IndiceFila, IndiceColumna, NuevaFila, NuevaColumna)

            If NuevaFila > 0 And NuevaColumna >= 0 Then

                If NuevaColumna < GridView.VisibleColumns.Count Then
                    GridView.FocusedColumn = GridView.VisibleColumns(NuevaColumna)
                    If NuevaFila <= GridView.RowCount - 1 Then GridView.FocusedRowHandle = NuevaFila
                Else
                    If NuevaFila < GridView.RowCount Then

                        GridView.FocusedRowHandle = NuevaFila

                        If _NavegarSoloEditables Then

                            Dim bHayEditables As Boolean = False
                            For indice As Integer = 0 To GridView.VisibleColumns.Count - 1
                                If Not IsNothing(GridView.VisibleColumns(indice)) Then
                                    If GridView.VisibleColumns(indice).OptionsColumn.AllowEdit Then
                                        GridView.FocusedColumn = GridView.VisibleColumns(indice)
                                        bHayEditables = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If Not bHayEditables Then
                                GridView.FocusedColumn = GridView.VisibleColumns(0)
                            End If
                        Else
                            GridView.FocusedColumn = GridView.VisibleColumns(0)
                        End If

                    End If
                End If
            Else

                If SiguienteColumna < GridView.VisibleColumns.Count Then
                    GridView.FocusedColumn = GridView.VisibleColumns(SiguienteColumna)
                Else
                    Dim SiguienteFila As Integer = IndiceFila + 1
                    If SiguienteFila < GridView.RowCount Then

                        GridView.FocusedRowHandle = SiguienteFila

                        If _NavegarSoloEditables Then

                            Dim bHayEditables As Boolean = False
                            For indice As Integer = 0 To GridView.VisibleColumns.Count - 1
                                If Not IsNothing(GridView.VisibleColumns(indice)) Then
                                    If GridView.VisibleColumns(indice).OptionsColumn.AllowEdit Then
                                        GridView.FocusedColumn = GridView.VisibleColumns(indice)
                                        bHayEditables = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If Not bHayEditables Then
                                GridView.FocusedColumn = GridView.VisibleColumns(0)
                            End If
                        Else
                            GridView.FocusedColumn = GridView.VisibleColumns(0)
                        End If

                    End If
                End If

            End If


        Catch ex As Exception

        End Try

    End Sub


    Protected Overridable Sub Validar(row As DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)

        GridView.SetColumnError(column, Nothing)
        Dim bError As Boolean = False


        'De qué campo hablamos?
        Dim Nombre As String = column.FieldName.ToUpper.Trim
        If _dcEditables.ContainsKey(Nombre) Then

            Dim campo As CampoTabla = _dcEditables(Nombre)
            'Dim texto As String = GridView.GetFocusedDisplayText()
            Dim texto As String = GridView.ActiveEditor.Text & ""

            Select Case campo.Tipo

                Case Cdatos.TiposCampo.Fecha
                    If texto = "" Then
                        texto = SinMascara(Cdatos.TiposCampo.Fecha, FnFechaHoy)
                    Else
                        texto = FnFecha(SinMascara(Cdatos.TiposCampo.Fecha, texto))
                        If texto <> "" Then
                            texto = Mascara(texto, Cdatos.TiposCampo.Fecha)
                        End If
                    End If

                Case Cdatos.TiposCampo.Hora
                    If texto = "" Then
                        texto = SinMascara(Cdatos.TiposCampo.Hora, Now.ToString("HH:mm:ss"))
                    Else
                        texto = FnHora(SinMascara(Cdatos.TiposCampo.Hora, texto))
                        If texto <> "" Then
                            texto = Mascara(texto, Cdatos.TiposCampo.Hora)
                        End If
                    End If

                Case Cdatos.TiposCampo.FechaHora
                    If texto = "" Then
                        texto = SinMascara(Cdatos.TiposCampo.FechaHora, Now.ToString("dd/MM/yyyy HH:mm:ss"))
                    Else
                        If texto <> "" Then
                            texto = Mascara(texto, Cdatos.TiposCampo.FechaHora)
                        End If
                    End If


                Case Cdatos.TiposCampo.Cuenta
                    If texto <> "" Then
                        texto = FnCuenta11(texto)
                    End If
                Case Cdatos.TiposCampo.CuentaCliente
                    If texto <> "" Then
                        texto = FnCuentaCliente(texto)
                    End If

            End Select


            If campo.Obligatorio = True And texto = "" Then
                GridView.SetColumnError(column, "Error, debe introducir un valor")
                bError = True
            Else
                If Not bError Then
                    RaiseEvent Valida(row, column)
                End If
            End If


        End If



    End Sub


    Protected Sub GridView_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView.KeyDown


        'Sale del grid con escape y va a los botones
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Tab Then

            'Si no estamos editando y presionamos escape, el foco va al botón de guardar
            'If Not GridView.ActiveEditor.IsEditorActive Then
            If IsNothing(GridView.ActiveEditor) Then
                If BtGuardar.Enabled Then
                    If BtGuardar.Enabled Then
                        BtGuardar.Select()
                        BtGuardar.Focus()
                    Else
                        Siguiente()
                    End If
                End If
            End If

        ElseIf e.KeyCode = Keys.Up Then
            If GridView.FocusedRowHandle = 0 Then Anterior()
        ElseIf e.KeyCode = Keys.Down Then
            If GridView.FocusedRowHandle = GridView.RowCount - 1 Then Siguiente()
        ElseIf e.KeyCode = Keys.Enter Then

            Dim Nombre As String = GridView.FocusedColumn.FieldName.ToUpper.Trim

            'Si no es editable o si está editando   , que avance a la siguiente, si lo es, que active el editor
            If Not _dcEditables.ContainsKey(Nombre) Or (_dcEditables.ContainsKey(Nombre) And Not IsNothing(GridView.ActiveEditor)) Then
                SiguienteColumna(GridView.FocusedColumn.VisibleIndex, GridView.FocusedRowHandle)
            End If
        Else
            Me.OnKeyDown(e)
        End If


    End Sub

    Private Sub BtGuardar_Enter(sender As System.Object, e As System.EventArgs) Handles BtGuardar.Enter
        BtGuardar.BackColor = Color.Yellow
    End Sub

    Private Sub BtGuardar_Leave(sender As System.Object, e As System.EventArgs) Handles BtGuardar.Leave
        BtGuardar.BackColor = Color.LightBlue
    End Sub

    Private Sub BtCancelar_Enter(sender As System.Object, e As System.EventArgs) Handles BtCancelar.Enter
        BtCancelar.BackColor = Color.Yellow
    End Sub

    Private Sub BtCancelar_Leave(sender As System.Object, e As System.EventArgs) Handles BtCancelar.Leave
        BtCancelar.BackColor = Color.LightBlue
    End Sub


    Private Sub Siguiente()

        If Orden > -1 Then

            Dim padre As Form = Me.ParentForm
            If TypeOf padre Is FrMantenimiento Then
                CType(padre, FrMantenimiento).Siguiente(Orden)
            ElseIf TypeOf padre Is FrConsulta Then
                CType(padre, FrConsulta).Siguiente(Orden)
            End If

        End If


    End Sub


    Private Sub Anterior()

        If Orden > 0 Then

            Dim padre As Form = Me.ParentForm
            If TypeOf padre Is FrMantenimiento Then
                CType(padre, FrMantenimiento).Anterior(Orden)
            ElseIf TypeOf padre Is FrConsulta Then
                CType(padre, FrConsulta).Anterior(Orden)
            End If

        End If

    End Sub


    'Editor
    Private Sub Grid_EditorKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Grid.EditorKeyPress

        If Asc(e.KeyChar) <> Keys.Return And Asc(e.KeyChar) <> 8 Then

            'De qué campo estamos hablando?
            Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView.FocusedColumn
            If Not IsNothing(col) Then

                Dim Nombre As String = col.FieldName.ToUpper.Trim
                If _dcEditables.ContainsKey(Nombre) Then

                    Dim campo As CampoTabla = _dcEditables(Nombre)
                    'Dim texto As String = GridView.GetFocusedDisplayText()
                    Dim texto As String = GridView.ActiveEditor.Text & ""


                    'Longitud
                    If campo.Tipo <> Cdatos.TiposCampo.Fecha And campo.Tipo <> Cdatos.TiposCampo.Hora And campo.Tipo <> Cdatos.TiposCampo.FechaHora Then
                        Dim editor As DevExpress.XtraEditors.TextEdit = GridView.ActiveEditor
                        If editor.SelectedText <> editor.Text Then
                            If texto.Length >= campo.Longitud Then
                                e.KeyChar = CChar(String.Empty)
                            End If
                        End If
                    End If
                    

                    'Coma decimal
                    If campo.Tipo = Cdatos.TiposCampo.Importe Then
                        If e.KeyChar = "." Then
                            e.KeyChar = ","
                        End If
                    End If

                    'Caracteres no permitidos
                    If campo.Mcadena <> "" And InStr(campo.Mcadena, e.KeyChar) = 0 Then
                        e.KeyChar = CChar(String.Empty)
                    End If

                End If


            End If


        End If

    End Sub


    'Errores
    Public Sub PonError(col As DevExpress.XtraGrid.Columns.GridColumn, texto_error As String)
        GridView.SetColumnError(col, texto_error)
    End Sub


    Public Sub QuitaError(col As DevExpress.XtraGrid.Columns.GridColumn, texto_error As String)
        GridView.SetColumnError(col, Nothing)
    End Sub


    Public Sub BorraErrores()
        GridView.ClearColumnErrors()
    End Sub

    
   
    Private Sub GridView_BeforeLeaveRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles GridView.BeforeLeaveRow

        If GridView.HasColumnErrors Then
            e.Allow = False
            BtGuardar.Enabled = False
        End If

    End Sub


    Private Sub Grid_EditorKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Grid.EditorKeyDown

        If e.KeyCode = Keys.Enter Then

            If Not IsNothing(GridView.FocusedColumn) Then

                If _dcEditables.ContainsKey(GridView.FocusedColumn.FieldName.ToUpper.Trim) Then
                    Dim campo As CampoTabla = _dcEditables(GridView.FocusedColumn.FieldName.ToUpper.Trim)

                    'Permite mostrar el calendario con pulsar el intro
                    If campo.Tipo = Cdatos.TiposCampo.Fecha Then

                        'If Not CType(GridView.ActiveEditor, DevExpress.XtraEditors.DateEdit).IsPopupOpen Then
                        '    CType(GridView.ActiveEditor, DevExpress.XtraEditors.DateEdit).ShowPopup()
                        '    e.Handled = True
                        'End If


                    End If

                End If

            End If

        End If

    End Sub

    Private Sub GridView_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        RaiseEvent RowCellClick(sender, e)
        GridView.RefreshData()
    End Sub

    Private Sub Grid_ProcessGridKey(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Grid.ProcessGridKey
        RaiseEvent ProcessGridKey(sender, e)
        GridView.RefreshData()
    End Sub

    Private Sub GridView_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView.CustomSummaryCalculate
        RaiseEvent CustomSummaryCalculate(sender, e)
    End Sub


    Private Sub GridView_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GridView.ShowingEditor
        RaiseEvent ShowingEditor(sender, e)
    End Sub

    Private Sub GridView_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView.RowCellStyle
        RaiseEvent RowCellStyle(sender, e)
    End Sub

End Class
