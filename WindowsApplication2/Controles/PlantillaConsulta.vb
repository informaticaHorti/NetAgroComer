Public Class PlantillaConsulta

    Dim err As New Errores
    Dim _EntidadConfiguracion As E_Configuracion
    Dim _DatosFormularioGrid As String = ""
    Dim _DatosFormularioPivotGrid As String = ""

    Private _GridControl As DevExpress.XtraGrid.GridControl = Nothing
    Private _Grid As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
    Private _PivotGrid As DevExpress.XtraPivotGrid.PivotGridControl = Nothing
    Private _FormularioOrigen As String = ""

    Public Const POR_DEFECTO As String = "POR DEFECTO"

    Private _VisibleBtGuardarPlantilla As Boolean = True
    Private _VisibleBtIrAPivot As Boolean = True
    Private _VisibleBtCampoCalculado As Boolean = True

    Private _OpcionesPlantilla As DevExpress.Utils.OptionsLayoutGrid = Nothing


    Public Event AntesDeMostrarTablaDinamica(ByVal f As FrTablaDinamica)
    Public Event DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn)


    Public Property OpcionesPlantilla As DevExpress.Utils.OptionsLayoutGrid
        Get
            Return _OpcionesPlantilla
        End Get
        Set(ByVal value As DevExpress.Utils.OptionsLayoutGrid)
            _OpcionesPlantilla = value
        End Set
    End Property



    Public Property VisibleBotonGuardarPlantilla As Boolean
        Get
            Return _VisibleBtGuardarPlantilla
        End Get
        Set(ByVal value As Boolean)
            _VisibleBtGuardarPlantilla = value
        End Set
    End Property

    Public Property VisibleBotonIrAPivot As Boolean
        Get
            Return _VisibleBtIrAPivot
        End Get
        Set(ByVal value As Boolean)
            _VisibleBtIrAPivot = value
        End Set
    End Property


    Public Property VisibleBotonCampoCalculado As Boolean
        Get
            Return _VisibleBtCampoCalculado
        End Get
        Set(ByVal value As Boolean)
            _VisibleBtCampoCalculado = value
        End Set
    End Property


    Public ReadOnly Property Etiqueta As DevExpress.XtraEditors.LabelControl
        Get
            Return Me.lbPlantilla
        End Get
    End Property


    Public ReadOnly Property PlantillaActual As String
        Get
            If Not IsNothing(cbPlantilla.EditValue) Then
                Return cbPlantilla.EditValue.ToString() & ""
            Else
                Return ""
            End If
        End Get
    End Property


    Public Property GridControl As DevExpress.XtraGrid.GridControl

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

    Public Property PivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
        Get
            Return _PivotGrid
        End Get
        Set(ByVal value As DevExpress.XtraPivotGrid.PivotGridControl)
            _PivotGrid = value
        End Set
    End Property


    'Public Property FormularioOrigen As String
    '    Get
    '        Return _FormularioOrigen
    '    End Get
    '    Set(ByVal value As String)
    '        _FormularioOrigen = value
    '        'If Not DesignMode Then
    '        '    _DatosFormularioPivotGrid = Idusuario.ToString & "." & _FormularioOrigen & ".Pivot." & _PivotGrid.Name
    '        'End If
    '    End Set
    'End Property



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        _EntidadConfiguracion = New E_Configuracion(Idusuario, cn)


    End Sub

    Private Function ExistenDatosGrid() As Boolean

        Dim bDatos As Boolean = True

        If IsNothing(GridControl) Then
            bDatos = False
        ElseIf IsNothing(GridControl.DataSource) Then
            bDatos = False
        Else
            Dim dt As DataTable = CType(GridControl.DataSource, DataTable)
            If dt.Rows.Count < 1 Then bDatos = False
        End If


        Return bDatos

    End Function


    Private Function ExistenDatosPivotGrid() As Boolean

        Dim bDatos As Boolean = True

        If IsNothing(_PivotGrid) Then
            bDatos = False
        ElseIf IsNothing(_PivotGrid.DataSource) Then
            bDatos = False
        Else
            Dim dt As DataTable = CType(_PivotGrid.DataSource, DataTable)
            If dt.Rows.Count < 1 Then bDatos = False
        End If


        Return bDatos

    End Function



    Private Sub btGuardarPlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardarPlantilla.Click

        Try

            Dim bDatosGrid As Boolean = ExistenDatosGrid()
            Dim bDatosPivotGrid As Boolean = ExistenDatosPivotGrid()


            If (bDatosGrid And Not IsNothing(_Grid)) Or (bDatosPivotGrid And Not IsNothing(_PivotGrid)) Then

                If txtPlantilla.Visible Then

                    Dim NombreConfiguracion As String = txtPlantilla.Text

                    GuardaConfiguracionPlantilla(NombreConfiguracion)
                    CargaConfiguracionesPlantilla()


                    cbPlantilla.EditValue = NombreConfiguracion
                    btGuardarPlantilla.Image = Global.NetAgro.My.Resources.RibbonPrintPreview_Customize
                    txtPlantilla.Visible = False
                    cbPlantilla.Select()
                    cbPlantilla.Focus()

                Else

                    If IsNothing(cbPlantilla.EditValue) Then cbPlantilla.EditValue = ""
                    btGuardarPlantilla.Image = Global.NetAgro.My.Resources.RibbonPrintPreview_ExportFile
                    txtPlantilla.Text = PlantillaActual
                    txtPlantilla.Visible = True
                    txtPlantilla.Select()
                    txtPlantilla.Focus()

                End If

            Else

                MsgBox("No hay datos")

            End If

        Catch ex As Exception
            err.Muestraerror("Error al pulsar en el botón de guardar consulta", "btGuardarPlantilla_Click", ex.Message)
        End Try

    End Sub


    Private Sub GuardaConfiguracionPlantilla(ByVal NombreConfiguracion As String)

        If Not IsNothing(Grid) Then

            If NombreConfiguracion.ToUpper() = POR_DEFECTO Then
                MsgBox("No se puede guardar la plantilla con el nombre 'POR DEFECTO'")
                Exit Sub
            End If

            Dim xml As String = GridAXML()
            _EntidadConfiguracion.GuardarConfiguracion(Idusuario, _DatosFormularioGrid, xml, NombreConfiguracion)

        End If


        If Not IsNothing(_PivotGrid) Then

            If NombreConfiguracion.ToUpper() = POR_DEFECTO Then
                MsgBox("No se puede guardar la plantilla con el nombre 'POR DEFECTO'")
                Exit Sub
            End If

            Dim xml As String = PivotAXML()
            _EntidadConfiguracion.GuardarConfiguracion(Idusuario, _DatosFormularioPivotGrid, xml, NombreConfiguracion)

        End If

    End Sub


    Private Sub CargaConfiguracionesPlantilla()


        Try

            If Not IsNothing(Grid) Then

                Dim dt As DataTable = _EntidadConfiguracion.ObtenerConfiguracion(Idusuario, _DatosFormularioGrid, "", True)
                Dim bExistePorDefecto As Boolean = False

                cbPlantilla.Properties.Items.Clear()

                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)
                    Dim NombreConfiguracion As String = row("NombreConfiguracion").ToString & ""

                    If NombreConfiguracion.Trim = "" And indice = 0 Then
                        NombreConfiguracion = POR_DEFECTO
                        bExistePorDefecto = True
                    End If
                    cbPlantilla.Properties.Items.Add(NombreConfiguracion)

                Next


                If PlantillaActual = "" And bExistePorDefecto Then
                    cbPlantilla.EditValue = POR_DEFECTO
                End If

            End If


            If Not IsNothing(_PivotGrid) Then

                Dim dt As DataTable = _EntidadConfiguracion.ObtenerConfiguracion(Idusuario, _DatosFormularioPivotGrid, "", True)
                Dim bExistePorDefecto As Boolean = False

                cbPlantilla.Properties.Items.Clear()

                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)
                    Dim NombreConfiguracion As String = row("NombreConfiguracion").ToString & ""

                    If NombreConfiguracion.Trim = "" And indice = 0 Then
                        NombreConfiguracion = POR_DEFECTO
                        bExistePorDefecto = True
                    End If
                    cbPlantilla.Properties.Items.Add(NombreConfiguracion)

                Next


                If PlantillaActual = "" And bExistePorDefecto Then
                    cbPlantilla.EditValue = POR_DEFECTO
                End If

            End If


        Catch ex As Exception
            err.Muestraerror("Error al cargar las configuraciones de plantilla", "CargaConfiguracionesPlantilla", ex.Message)
        End Try


    End Sub


    Private Sub AplicaConfiguracionPlantilla()

        Try

            If Not IsNothing(_Grid) Then

                Dim NombreConfiguracion As String = PlantillaActual
                If NombreConfiguracion.ToUpper.Trim = POR_DEFECTO Then NombreConfiguracion = ""

                Dim dt As DataTable = _EntidadConfiguracion.ObtenerConfiguracion(Idusuario, _DatosFormularioGrid, NombreConfiguracion, False)

                If dt.Rows.Count = 1 Then

                    Dim xml As String = dt.Rows(0)("xml").ToString & ""
                    If xml.Trim <> "" Then
                        XMLAGrid(xml)
                    End If

                End If

            End If


            If Not IsNothing(_PivotGrid) Then

                Dim NombreConfiguracion As String = PlantillaActual
                If NombreConfiguracion.ToUpper.Trim = POR_DEFECTO Then NombreConfiguracion = ""

                Dim dt As DataTable = _EntidadConfiguracion.ObtenerConfiguracion(Idusuario, _DatosFormularioPivotGrid, NombreConfiguracion, False)

                If dt.Rows.Count = 1 Then

                    Dim xml As String = dt.Rows(0)("xml").ToString & ""
                    If xml.Trim <> "" Then
                        XMLAPivot(xml)
                    End If

                End If

            End If


        Catch ex As Exception
            err.Muestraerror("Error al aplicar la configuración de la plantilla", "AplicaConfiguracionPlantilla", ex.Message)
        End Try

    End Sub


    Private Function GridAXML() As String

        Dim ms As New IO.MemoryStream()

        'If Not IsNothing(_OpcionesPlantilla) Then
        '    Grid.SaveLayoutToStream(ms, _OpcionesPlantilla)
        'Else
        '    Grid.SaveLayoutToStream(ms)
        'End If

        _Grid.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutGrid.FullLayout)

        ms.Flush()
        ms.Position = 0

        Dim sr As New IO.StreamReader(ms)
        Return sr.ReadToEnd()

    End Function


    Private Sub XMLAGrid(ByVal xml As String)


        Dim ms As New IO.MemoryStream()
        Dim sw As New IO.StreamWriter(ms)

        sw.Write(xml)
        sw.Flush()
        ms.Position = 0

        'If Not IsNothing(_OpcionesPlantilla) Then
        '    _Grid.RestoreLayoutFromStream(ms, _OpcionesPlantilla)
        'Else
        '    _Grid.RestoreLayoutFromStream(ms)
        'End If

        _Grid.RestoreLayoutFromStream(ms, DevExpress.Utils.OptionsLayoutGrid.FullLayout)


    End Sub


    Private Function PivotAXML() As String

        Dim ms As New IO.MemoryStream()
        _PivotGrid.SaveLayoutToStream(ms)

        ms.Flush()
        ms.Position = 0

        Dim sr As New IO.StreamReader(ms)
        Return sr.ReadToEnd()

    End Function


    Private Sub XMLAPivot(ByVal xml As String)

        Dim ms As New IO.MemoryStream()
        Dim sw As New IO.StreamWriter(ms)

        sw.Write(xml)
        sw.Flush()
        ms.Position = 0

        _PivotGrid.RestoreLayoutFromStream(ms)


    End Sub


    Private Sub PlantillaConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not DesignMode Then

            Dim bFaltaGrid As Boolean = IsNothing(_Grid)
            Dim bFaltaGridControl As Boolean = IsNothing(_GridControl)
            Dim bFaltaPivot As Boolean = IsNothing(_PivotGrid)
            Dim bError As Boolean = False


            If Not bFaltaPivot And (bFaltaGrid And bFaltaGridControl) Then
                bError = False
            ElseIf bFaltaPivot And (Not bFaltaGrid And Not bFaltaGridControl) Then
                bError = False
            Else
                bError = True
            End If


            If bError Then
                err.Muestraerror("Es necesario establecer el valor de Grid y Gridcontrol o bien establecer el valor de PivotGrid.", "Load", "PlantillaConsulta debe usar Grid con GridControl o sólo PivotGrid")
                Exit Sub
            End If


            If Not IsNothing(_PivotGrid) Then _VisibleBtIrAPivot = False
            If Not IsNothing(_PivotGrid) Then _VisibleBtCampoCalculado = False

            btGuardarPlantilla.Visible = _VisibleBtGuardarPlantilla
            btIrAPivot.Visible = _VisibleBtIrAPivot
            'btCampoCalculado.Visible = _VisibleBtCampoCalculado
            pop.Visible = _VisibleBtCampoCalculado
            popControl.PopupContainerProperties.ShowPopupCloseButton = False


            'Throw New Exception("AH")

            If Not IsNothing(_Grid) Then
                _DatosFormularioGrid = Idusuario.ToString & "." & Me.FindForm.Name & "." & Me._Grid.Name
                _OpcionesPlantilla = _Grid.OptionsLayout
                _OpcionesPlantilla.Columns.StoreAllOptions = True
            End If

            If Not IsNothing(_PivotGrid) Then _DatosFormularioPivotGrid = Idusuario.ToString & "." & _FormularioOrigen & ".Pivot." & _PivotGrid.Name


            txtPlantilla.Properties.MaxLength = _EntidadConfiguracion.NombreConfiguracion.Longitud

            CargaConfiguracionesPlantilla()

        End If


    End Sub


    ''' <summary>
    ''' Este método hay que llamarlo desde fuera, pues PantillaConsulta no sabe cuándo se han cargado los datos para hacer la primera copia
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GuardaPlantillaPorDefecto()

        Try

            Dim bExistePorDefecto As Boolean = False
            For Each item As String In cbPlantilla.Properties.Items
                If item.ToUpper.Trim = POR_DEFECTO Then
                    bExistePorDefecto = True
                    Exit For
                End If
            Next


            If Not bExistePorDefecto Then


                If Not IsNothing(_Grid) Then

                    Dim xml As String = GridAXML()
                    _EntidadConfiguracion.GuardaConfiguracionPorDefecto(Idusuario, _DatosFormularioGrid, xml)

                    CargaConfiguracionesPlantilla()

                End If


                If Not IsNothing(_PivotGrid) Then

                    Dim xml As String = PivotAXML()
                    _EntidadConfiguracion.GuardaConfiguracionPorDefecto(Idusuario, _DatosFormularioPivotGrid, xml)

                    CargaConfiguracionesPlantilla()

                End If

            End If


        Catch ex As Exception
            err.Muestraerror("Error al guardar la plantilla por defecto", "GuardaPlantillaPorDefecto", ex.Message)
        End Try

    End Sub


    Private Sub cbPlantilla_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPlantilla.EditValueChanged

        AplicaConfiguracionPlantilla()

    End Sub

    Private Sub txtPlantilla_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlantilla.KeyPress

        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Convert.ToChar("_") Then
            e.KeyChar = CChar(e.KeyChar.ToString.ToUpper)
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub btIrAPivot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btIrAPivot.Click


        If Not IsNothing(_Grid) Then

            If ExistenDatosGrid() Then
                Dim f As New FrTablaDinamica(Me.FindForm, Me.GridControl, Me.Grid)
                RaiseEvent AntesDeMostrarTablaDinamica(f)
                f.Show()
            Else
                MsgBox("No hay datos")
            End If

        ElseIf Not IsNothing(_PivotGrid) Then

            If ExistenDatosPivotGrid() Then
                Dim f As New FrTablaDinamica(Me.FindForm, Me.GridControl, Me.Grid)
                RaiseEvent AntesDeMostrarTablaDinamica(f)
                f.Show()
            Else
                MsgBox("No hay datos")
            End If

        End If


    End Sub


    Public Sub EstableceFormularioOrigen(ByVal nombre As String)

        _FormularioOrigen = nombre
        _DatosFormularioPivotGrid = Idusuario.ToString & "." & _FormularioOrigen & ".Pivot." & _PivotGrid.Name

    End Sub


    Private Sub btCampoCalculado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCampoCalculado.Click


        

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If txtNombreCampo.Text.Trim = "" Then
            MsgBox("Debe introducir un nombre para el campo calculado")
            Exit Sub
        End If

        'Sepuede hacer lo mismo en el PivotGrid, pero no tiene mucho sentido en NetAgro
        If Not IsNothing(_Grid) Then

            If ExistenDatosGrid() Then

                _GridControl.ForceInitialize()

                Dim NombreColumna As String = txtNombreCampo.Text

                Dim unbColumn As DevExpress.XtraGrid.Columns.GridColumn = _Grid.Columns.AddField(NombreColumna)
                unbColumn.VisibleIndex = _Grid.Columns.Count
                unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                unbColumn.OptionsColumn.AllowEdit = False
                unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                unbColumn.DisplayFormat.FormatString = "#,###0.00"
                unbColumn.AppearanceCell.BackColor = Color.LemonChiffon

                RaiseEvent DespuesDeIncluirCampoCalculado(unbColumn)

                _Grid.OptionsLayout.StoreAllOptions = True
                _Grid.Columns(NombreColumna).ShowUnboundExpressionMenu = True
                _Grid.ShowUnboundExpressionEditor(_Grid.Columns(NombreColumna))

            Else
                MsgBox("No hay datos")
            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        pop.ClosePopup()
    End Sub

    Private Sub txtNombreCampo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCampo.KeyPress

        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Convert.ToChar("_") Then
            'e.KeyChar = CChar(e.KeyChar.ToString.ToUpper)
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub
End Class
