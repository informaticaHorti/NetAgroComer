Imports NetAgro.Cdatos
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrConsulta

    Dim usuarios_procesos As E_usuarios_procesos = Nothing

    Protected Enum TipoConsulta

        Consulta
        Imprimir
        Informe
        BtAux

    End Enum


    Public Ncontrol As Integer

    Dim _ListaControles As New List(Of Object)
    Dim _ListaEtiquetas As New List(Of Object)
    Private _LineasDescripcion As New List(Of String)
    Protected Primero As Boolean
    Public Const tipofrm As ETipoFrm = ETipoFrm.Consulta
    Dim err As New Errores


    Public Event AntesDeMostrarTablaDinamica(ByVal f As FrTablaDinamica)
    Public Event DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn)
    Public Event DespuesDeAplicarPlantilla()


    Protected _PanelCargando As New PanelCargando
    Protected _TipoConsulta As TipoConsulta = Nothing

    Protected _DcMostrarCeroEnColumna As New Dictionary(Of String, Boolean)
    Protected _bOcultarCeros As Boolean = True

    Protected _IncluirTodosLosCampos As Boolean = False
    Protected _IncluirTodosLosCamposVisible As Boolean = False



    Public Property ScrollHorizontalGrid As Boolean
        Get
            Return GridView1.OptionsView.ColumnAutoWidth
        End Get
        Set(value As Boolean)
            GridView1.OptionsView.ColumnAutoWidth = Not value

            'If value = True Then
            '    'Mostrar barra horizontal
            '    GridView1.BestFitColumns()
            'End If

        End Set
    End Property


    Public Property ListaControles As List(Of Object)
        ' lista de controles editables
        Set(ByVal value As List(Of Object))
            _ListaControles = value

        End Set
        Get
            Return _ListaControles

        End Get
    End Property

    Public Property ListaEtiquetas As List(Of Object)
        ' lista de etiquetas variables
        Set(ByVal value As List(Of Object))
            _ListaEtiquetas = value

        End Set
        Get
            Return _ListaEtiquetas

        End Get
    End Property


    Public Property LineasDescripcion As List(Of String)
        Get
            Return _LineasDescripcion
        End Get
        Set(ByVal value As List(Of String))
            _LineasDescripcion = value
        End Set
    End Property


    Public Property OcultarCeros As Boolean
        Get
            Return _bOcultarCeros
        End Get
        Set(value As Boolean)
            _bOcultarCeros = value
        End Set
    End Property


    Public ReadOnly Property MostrarCeroEnColumna As Dictionary(Of String, Boolean)
        Get
            Return _DcMostrarCeroEnColumna
        End Get
    End Property


    Public Property IncluirTodosLosCampos As Boolean
        Get
            Return _IncluirTodosLosCampos
        End Get
        Set(value As Boolean)
            _IncluirTodosLosCampos = value
        End Set
    End Property

    Public Property IncluirTodosLosCamposVisible As Boolean
        Get
            Return _IncluirTodosLosCamposVisible
        End Get
        Set(value As Boolean)
            _IncluirTodosLosCamposVisible = value
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        PanelAcciones.BackColor = Color_PV_BarraEstado

    End Sub

    Protected Overridable Sub InicializaCargando()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not IsNothing(_PanelCargando) Then

            _PanelCargando.Visible = False

            'Si yo añado en diseño el PanelCargando, se me va a acoplar a uno de los dos paneles, por eso lo añado a mano aquí,
            'para que pertenezca al formulario. De esta forma, yo controlo su posición exacta
            Me.Controls.Add(_PanelCargando)

            Dim x As Integer = 0
            Dim y As Integer = 0

            x = Me.Size.Width / 2 - _PanelCargando.Size.Width / 2
            y = Me.Size.Height / 2 - _PanelCargando.Size.Height / 2

            _PanelCargando.Location = New Point(x, y)

        End If

    End Sub

    Private Sub FrConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If Not IsNothing(usuarios_procesos) Then
            usuarios_procesos.AñadirProceso(Me.Text, "Cerrando consulta", "", "")
        End If

        'Libera memoria
        ClearMemory()

    End Sub




    Protected Overridable Sub FrConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)


        InicializaCargando()


        Ncontrol = 0

        Dim lc As New List(Of Object)

        If Not DesignMode Then
            ListaEtiquetas = lc
            CreaListaEtiquetas(Me)
        End If


        Primero = True
        GridView1.OptionsBehavior.Editable = False


        '
        GridView1.OptionsPrint.PrintDetails = True
        GridView1.OptionsPrint.ExpandAllDetails = False
        GridView1.OptionsPrint.ExpandAllGroups = False


        If Not DesignMode Then

            BorraPan()
            If PlantillaConsulta1.Visible = True Then
                PlantillaConsulta1.AplicaConfiguracionPlantilla()
            End If

            usuarios_procesos = New E_usuarios_procesos(Idusuario, cn)
            usuarios_procesos.AñadirProceso(Me.Text, "Abriendo consulta", "", "")

        End If

        If _IncluirTodosLosCamposVisible Then
            PlantillaConsulta1.mnuMostrarTodosCampos.Enabled = True
        Else
            PlantillaConsulta1.mnuMostrarTodosCampos.Enabled = False
        End If

        tt.SetToolTip(BtExportarExcel, "Exportar grid a excel")


    End Sub


    Public Overridable Sub TeclaFuncion(ByVal Tecla As System.Windows.Forms.Keys, ByVal obj As Object)

        'MsgBox("ha pulsado " + Tecla.ToString + " en " + tx.Name)

        Select Case Tecla

            Case Keys.F5
                BConsultar.PerformClick()

            Case Keys.F12
                'MsgBox("Salir")
                Bsalir.PerformClick()

        End Select


    End Sub


    Protected Sub CreaListaEtiquetas(ByVal Panel As Control)
        'crea una lista con las etiquetas variables del formulario
        Try

            For Each CC As Object In Panel.Controls
                If TypeOf (CC) Is Lb Then

                    ListaEtiquetas.Add(CC)
                Else
                    CreaListaEtiquetas(CC)
                End If

            Next
        Catch ex As Exception
            Dim a
            a = ""
        End Try

    End Sub
    Dim _OrdenControl As Integer

    Public Property OrdenControl As Integer
        Set(ByVal value As Integer)
            _OrdenControl = value
        End Set
        Get
            Return _OrdenControl

        End Get
    End Property

    Overloads Sub ParamTx(ByVal Control As TxDato, ByVal CampoBd As bdcampo, Optional ByVal LbFija As Lb = Nothing, Optional ByVal Obl As Boolean = False, Optional ByVal tipo As Cdatos.TiposCampo = -1, Optional ByVal ndec As Integer = -1, Optional ByVal lg As Integer = -1, Optional ByVal ex As String = "")


        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = CampoBd

        If tipo = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Tipo = CampoBd.TipoBd
            Else
                cl.Tipo = TiposCampo.Cadena
            End If
        Else
            cl.Tipo = tipo
        End If
        If cl.Tipo = TiposCampo.Importe Then
            Control.TextAlign = LeftRightAlignment.Right
        End If
        If lg = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Longitud = CampoBd.Longitud
            Else
                cl.Longitud = 10
            End If
        Else
            cl.Longitud = lg
        End If
        If ndec = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Decimales = CampoBd.Decimales
            Else
                cl.Decimales = 0
            End If
        Else
            cl.Decimales = ndec
        End If
        cl.Exclusivos = ex
        cl.Obligatorio = Obl
        Control.Orden = Ncontrol
        Control.ClParam = cl
        Control.ClForm = Me
        If Not LbFija Is Nothing Then
            LbFija.CL_ControlAsociado = Control
            LbFija.CL_ValorFijo = True
        End If

        Me.ListaControles.Add(Control)

        Ncontrol = Ncontrol + 1
    End Sub

    Overloads Sub ParamCb(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal Enti As Entidad, ByVal CampoId As bdcampo, ByVal CampoNombre As bdcampo, ByVal lbfija As Lb, Optional ByVal Dt As DataTable = Nothing)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.MiEntidad = Enti
        Cb.DisplayMember = CampoNombre.NombreCampo
        Cb.ValueMember = CampoId.NombreCampo

        If Not Dt Is Nothing Then
            Cb.DataSource = Dt
        ElseIf Not Enti Is Nothing Then
            Cb.MiEntidad = Enti
            sql = "Select "
            sql = sql + CampoId.NombreCampo + "," + CampoNombre.NombreCampo + " from "
            sql = sql + Enti.NombreTabla
            sql = sql + " order by " + CampoId.NombreCampo
            Cb.DataSource = Enti.MiConexion.ConsultaSQL(sql)


        End If

        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub
    Overloads Sub ParamCb_Copia(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal lbfija As Lb, ByVal CbCajon As CbBox)
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DataSource = CbCajon.DataSource
        Cb.DisplayMember = CbCajon.DisplayMember
        Cb.ValueMember = CbCajon.ValueMember
        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1

    End Sub
    Overloads Sub ParamCbFIJO(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal dT As DataTable, ByVal lbfija As Lb)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DisplayMember = "nombre"
        Cb.ValueMember = "id"

        If Not dT Is Nothing Then
            Cb.DataSource = dT
        End If

        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub

    Overloads Sub ParamChk(ByVal Cb As Chk, ByVal CampoBd As bdcampo, ByVal ValorTrue As String, ByVal ValorFalse As String)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        Cb.ValorCampoTrue = ValorTrue
        Cb.ValorCampoFalse = ValorFalse
        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub


    Overloads Sub Siguiente(ByVal Orden As Integer)


        If TypeOf ListaControles(Orden) Is TxDato Then
            If CType(ListaControles(Orden), TxDato).SaltoAlfinal = True Then
                If BConsultar.Enabled = True Then
                    BConsultar.Select()
                ElseIf Bsalir.Enabled = True Then
                    Bsalir.Select()
                End If
                Exit Sub

            End If
        ElseIf TypeOf ListaControles(Orden) Is CbBox Then
            If CType(ListaControles(Orden), CbBox).SaltoAlfinal = True Then
                If BConsultar.Enabled = True Then
                    BConsultar.Select()
                ElseIf Bsalir.Enabled = True Then
                    Bsalir.Select()
                End If
                Exit Sub

            End If

        ElseIf TypeOf ListaControles(Orden) Is Chk Then
            If CType(ListaControles(Orden), Chk).SaltoAlfinal = True Then
                If BConsultar.Enabled = True Then
                    BConsultar.Select()
                ElseIf Bsalir.Enabled = True Then
                    Bsalir.Select()
                End If
                Exit Sub

            End If
        End If



        If Orden + 1 <= ListaControles.Count - 1 Then
            ListaControles(Orden + 1).select()
            If TypeOf ListaControles(Orden + 1) Is CbBox Then
                CType(ListaControles(Orden + 1), CbBox).DroppedDown = True
            End If
        Else
            If BConsultar.Enabled = True Then
                BConsultar.Select()
            ElseIf Bsalir.Enabled = True Then
                Bsalir.Select()
            End If

        End If
    End Sub

    Overloads Sub PonError(ByVal orden As Integer)
        Try

            If TypeOf ListaControles(orden) Is TxDato Then ListaControles(orden).select()

            Dim Ic As New Windows.Forms.PictureBox
            Ic.Parent = ListaControles(orden).parent

            Ic.Image = IconoError.Image
            Ic.Width = IconoError.Width
            Ic.Height = ListaControles(orden).Height
            Ic.Top = ListaControles(orden).top + 1
            Ic.Left = ListaControles(orden).left + ListaControles(orden).width - Ic.Width - 1
            Ic.Visible = True
            Ic.Name = "IC" & orden.ToString
            Ic.Parent.Controls.Add(Ic)
            Ic.BringToFront()
        Catch ex As Exception

        End Try

    End Sub
    Overloads Sub QuitaError(ByVal Orden As Integer)

        Dim c As Control
        c = BuscaObj(Me, "IC" & Orden.ToString)
        If Not c Is Nothing Then
            c.Visible = False
            c.Parent.Controls.Remove(c)
        End If




    End Sub

    Overloads Function BuscaObj(ByVal Panel As Control, ByVal Nombre As String) As Control
        Dim C As Control = Nothing
        Try
            For Each ic As Object In Panel.Controls
                If ic.Name = Nombre Then
                    C = ic
                Else
                    C = BuscaObj(ic, Nombre)
                End If
                If Not C Is Nothing Then
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
        Return C
    End Function
    Overloads Sub Anterior(ByVal Orden As Integer)
        If Orden > 0 Then
            ListaControles(Orden - 1).select()
            If TypeOf ListaControles(Orden - 1) Is CbBox Then
                CType(ListaControles(Orden - 1), CbBox).DroppedDown = True
            End If

        End If
    End Sub
    Public Overridable Sub BorraPan()

        For Each l As Lb In ListaEtiquetas
            If l.CL_ValorFijo = False Then
                l.Text = ""
            End If
        Next

        For Each l As Object In ListaControles
            If TypeOf (l) Is TxDato Then
                CType(l, TxDato).Text = ""
                If CType(l, TxDato).MiError = True Then
                    QuitaError(CType(l, TxDato).Orden)
                    CType(l, TxDato).MiError = False
                End If
                Dim gr As New ClGrid
                gr = CType(l, TxDato).GridLin
                If Not gr Is Nothing Then
                    If gr.GridView.RowCount > 0 Then
                        gr.Grid.DataSource = Nothing
                    End If
                End If
                CType(l, TxDato).UltimoValorValidado = Nothing
            ElseIf TypeOf (l) Is CbBox Then
                'CType(l, CbBox).SelectedValue = 0
                CType(l, CbBox).SelectedIndex = -1
            ElseIf TypeOf (l) Is Chk Then
                CType(l, Chk).Checked = CType(l, Chk).ValorDefecto
            End If

        Next

        'Comprueba si hay nueva versión
        'ComprobarCambioVersion()


        If ListaControles.Count > 0 Then ListaControles(0).select()


        'Libera memoria
        ClearMemory()

    End Sub

    Public Sub AsociarControles(ByRef tx As TxDato, ByRef boconsu As BtBusca, ByVal Origen As BtBusca, ByVal Tabla As Entidad,
                                Optional ByVal Campo As bdcampo = Nothing, Optional ByVal Etiq As Lb = Nothing,
                                Optional ByVal TextoToolTip As String = "Búsqueda alfabética")

        If Not boconsu Is Nothing Then
            If Not Origen Is Nothing Then
                boconsu.Image = Origen.Image
                boconsu.CL_CampoOrden = Origen.CL_CampoOrden
                boconsu.CL_DevuelveCampo = Origen.CL_DevuelveCampo
                boconsu.CL_ConsultaSql = Origen.CL_ConsultaSql
                boconsu.cl_formu = Origen.cl_formu
                boconsu.CL_BuscaAlb = Origen.CL_BuscaAlb
                boconsu.CL_campocodigo = Origen.CL_campocodigo
                boconsu.CL_camponombre = Origen.CL_camponombre
                boconsu.CL_dfecha = Origen.CL_dfecha
                boconsu.CL_hfecha = Origen.CL_hfecha
                boconsu.CL_ParamBusqueda = Origen.CL_ParamBusqueda
                boconsu.CL_xCentro = Origen.CL_xCentro
                boconsu.CL_EsId = Origen.CL_EsId
                boconsu.CL_CONSULTA = Origen.CL_CONSULTA

            End If
            tx.ClParam.BtBusca = boconsu
            tt.SetToolTip(tx.ClParam.BtBusca, TextoToolTip)
            boconsu.CL_ControlAsociado = tx
            boconsu.CL_Entidad = Tabla

        End If
        If Not Campo Is Nothing Then
            tx.ClParam.CampoEnlace = Campo
            tx.ClParam.Entidadenlace = Tabla
            tx.ClParam.LabelEnlace = Etiq
            If Not IsNothing(Etiq) Then
                Etiq.CL_ValorFijo = False
                Etiq.CL_ControlAsociado = tx
            End If
        End If
    End Sub

    Protected Delegate Sub Consultar_Delegate()
    Public Overridable Sub Consultar()
        GridView1.GroupSummary.Clear()
    End Sub


    Protected Delegate Sub Imprimir_Delegate()
    Public Overridable Sub Imprimir()

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


    Protected Delegate Sub Informe_Delegate()
    Public Overridable Sub Informe()

    End Sub


    Protected Delegate Sub Auxiliar_Delegate()
    Public Overridable Sub Auxiliar()

    End Sub


    Public Overridable Sub Salir()

        'Dim bPrimerControlVacio As Boolean = True

        'If ListaControles.Count > 0 Then
        '    If TypeOf ListaControles(0) Is TxDato Then
        '        If CType(ListaControles(0), TxDato).Text.Trim <> "" Then
        '            bPrimerControlVacio = False
        '        End If
        '    End If
        'End If


        'If OrdenControl = 0 And bPrimerControlVacio Then
        If OrdenControl = 0 Then
            Me.Close()
        Else
            Grid.DataSource = Nothing
            BorraPan()
        End If

    End Sub






    Private Sub BConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsultar.Click

        _TipoConsulta = TipoConsulta.Consulta
        MuestraCargando()
        Application.DoEvents()
        _BackgroundWorker.RunWorkerAsync()

    End Sub


    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click

        _TipoConsulta = TipoConsulta.Imprimir
        MuestraCargando()
        Application.DoEvents()
        _BackgroundWorker.RunWorkerAsync()
        Application.DoEvents()

    End Sub


    Private Sub BInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BInforme.Click

        _TipoConsulta = TipoConsulta.Informe
        MuestraCargando()
        Application.DoEvents()
        _BackgroundWorker.RunWorkerAsync()
        Application.DoEvents()

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        _TipoConsulta = TipoConsulta.BtAux
        MuestraCargando()
        Application.DoEvents()
        _BackgroundWorker.RunWorkerAsync()
        Application.DoEvents()

    End Sub


    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Salir()
    End Sub

    Private Sub GridView1_CellMerge(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles GridView1.CellMerge
        CellMerge(sender, e)
    End Sub

    Protected Overridable Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)
        GridClik(row, e.Column)
    End Sub


    Public Overridable Sub CellMerge(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs)

    End Sub

    Public Overridable Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)

    End Sub



    Private Sub Grid_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not DesignMode Then

            If Not IsNothing(Grid.DataSource) Then

                If Not IsNothing(PlantillaConsulta1) Then
                    If PlantillaConsulta1.Visible = True Then
                        PlantillaConsulta1.GuardaPlantillaPorDefecto()
                    End If
                End If

            End If

        End If

    End Sub


    Private Sub PlantillaConsulta1_AntesDeMostrarTablaDinamica(ByVal f As FrTablaDinamica) Handles PlantillaConsulta1.AntesDeMostrarTablaDinamica
        RaiseEvent AntesDeMostrarTablaDinamica(f)
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

    'Private Sub GridView1_CustomDrawGroupRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)

    'For indice As Integer = 0 To GridView1.GroupSummary.Item.count - 1

    'Next

    'GridView1.GroupSummary.Item(indice)

    'Dim info As GridGroupRowInfo = e.Info
    'info.GroupText = info.GroupText & " kg"
    'Dim texto As String = GridView1.GetGroupRowDisplayText(e.RowHandle)
    'Dim tamaño As SizeF = e.Appearance.CalcTextSize(e.Graphics, texto, e.Bounds.Width)
    'Dim x As Integer = info.IndicatorRect.X + info.IndicatorRect.Width + info.IndentRect.X + info.IndentRect.Width
    'Dim ancho As Integer = tamaño.Width



    'End Sub


    Private Sub btCampoCalculado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Grid.ForceInitialize()

        Dim NombreColumna As String = "Total"

        Dim unbColumn As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.AddField(NombreColumna)
        unbColumn.VisibleIndex = GridView1.Columns.Count
        unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
        unbColumn.OptionsColumn.AllowEdit = False
        unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        unbColumn.DisplayFormat.FormatString = "#,###0.00"
        unbColumn.AppearanceCell.BackColor = Color.LemonChiffon


        'TODO: Esto habría que comprobarlo en PlantillaGrid
        GridView1.OptionsLayout.StoreAllOptions = True


        GridView1.Columns(NombreColumna).ShowUnboundExpressionMenu = True
        GridView1.ShowUnboundExpressionEditor(GridView1.Columns(NombreColumna))

        AñadeResumenCampo(NombreColumna, "{0:n2}")


    End Sub


    Private Sub PlantillaConsulta1_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles PlantillaConsulta1.DespuesDeIncluirCampoCalculado
        RaiseEvent DespuesDeIncluirCampoCalculado(c)
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        Dim margen_izq_parametros As Integer = 10
        Dim base_parametros As Integer = 10

        Dim rec As RectangleF
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)




        Dim s As New SizeF(0, 0)

        Try

            'Logo
            Try

                Dim fichero_logo As String = "logo.png"

                Select Case MiMaletin.IdEmpresaCTB
                    Case 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
                End Select


                If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                    Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                    rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                    e.Graph.DrawImage(logo, rec, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                    s = logo.Size

                    margen_izq_parametros = margen_izq_parametros + logo.Size.Width

                End If

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
            e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

            base = base + 25


            If _LineasDescripcion.Count > 0 Then

                'e.Graph.Font = New Font("Arial", 11, FontStyle.Regular)

                'For Each linea As String In _LineasDescripcion

                '    rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 20)
                '    e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                '    base = base + 20

                'Next




                e.Graph.Font = New Font("Arial", 9, FontStyle.Regular)


                Dim bp As Integer = base_parametros
                Dim alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                Dim ancho As Integer = e.Graph.ClientPageSize.Width - margen_izq_parametros - 5

                For indice As Integer = 0 To _LineasDescripcion.Count - 1

                    If indice <= 12 Then

                        If indice = 6 Then
                            '2ª columna
                            ancho = ancho / 2
                            margen_izq_parametros = margen_izq_parametros + ancho
                            bp = base_parametros
                            alineacion = DevExpress.Utils.HorzAlignment.Far

                        End If

                        Dim linea As String = _LineasDescripcion(indice)

                        rec = New RectangleF(margen_izq_parametros, bp, ancho, 20)
                        Dim tb As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                        tb.HorzAlignment = alineacion
                        bp = bp + 15

                    End If


                Next



            End If


            'Último separador en blanco
            e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



        Catch ex As Exception


        End Try

    End Sub



    Protected Overridable Sub MuestraCargando()

        'Deshabilita botones
        For Each obj In Me.Controls

            Try
                If Not TypeOf obj Is PanelCargando Then obj.Enabled = False
            Catch ex As Exception

            End Try

        Next

        _PanelCargando.Visible = True
        _PanelCargando.BringToFront()

    End Sub


    Protected Overridable Sub OcultaCargando()

        _PanelCargando.Visible = False

        'Habilita botones
        For Each obj In Me.Controls

            Try
                obj.Enabled = True
            Catch ex As Exception

            End Try

        Next

        If TypeOf Me Is FrConsulta Then

            If _TipoConsulta <> TipoConsulta.Imprimir And _TipoConsulta <> TipoConsulta.Informe Then

                Me.BConsultar.Select()
                Me.BConsultar.Focus()

            End If

        End If

    End Sub



    'Realiza las acciones en un hilo para poder mostrar 'Cargando...'
    Private Sub _BackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles _BackgroundWorker.DoWork


        Application.DoEvents()


        Select Case _TipoConsulta

            Case TipoConsulta.Consulta
                Me.Invoke(New Consultar_Delegate(AddressOf Consultar))

            Case TipoConsulta.Imprimir
                Me.Invoke(New Consultar_Delegate(AddressOf Imprimir))

            Case TipoConsulta.Informe
                Me.Invoke(New Consultar_Delegate(AddressOf Informe))

            Case TipoConsulta.BtAux
                Me.Invoke(New Consultar_Delegate(AddressOf Auxiliar))

        End Select


        Application.DoEvents()




    End Sub


    Private Sub _BackgroundWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _BackgroundWorker.RunWorkerCompleted

        OcultaCargando()

        If _TipoConsulta = TipoConsulta.Consulta Then
            PlantillaConsulta1.AplicaConfiguracionPlantilla()
        End If

        RaiseEvent DespuesDeAplicarPlantilla()

    End Sub


    Public Overridable Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)
        RowCellStyle(row, e.Column, sender, e)

    End Sub

    Protected Overridable Sub RowCellStyle(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn, sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
    End Sub

    Protected Overridable Sub GridView1_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

        CustomColumnDisplayText(sender, e)

    End Sub


    Public Overridable Sub CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

        Try

            'If IsNumeric(e.Value) And VaDec(e.Value) = 0 And e.Column.ColumnType <> GetType(String) Then
            If IsNumeric(e.Value) And VaDec(e.Value) = 0 And (e.Column.ColumnType <> GetType(String) Or (e.Column.ColumnType = GetType(String) And Not (e.Value.ToString & "").ToUpper.Contains("E"))) Then

                If _bOcultarCeros Then
                    If _DcMostrarCeroEnColumna.Count = 0 Then
                        'Oculta los ceros en todos los casos
                        e.DisplayText = ""
                    Else
                        If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) Then
                            If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) = False Then
                                e.DisplayText = ""
                            End If
                        ElseIf e.Column.DisplayFormat.FormatString <> "" Then
                            e.DisplayText = ""
                        End If
                    End If
                Else
                    If _DcMostrarCeroEnColumna.Count > 0 Then
                        If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) Then
                            If _DcMostrarCeroEnColumna(e.Column.FieldName) = False Then
                                e.DisplayText = ""
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown

        If e.KeyCode = Keys.Enter Then
            intro()

        ElseIf e.KeyCode = Keys.F5 Or e.KeyCode = Keys.F12 Then
            Me.TeclaFuncion(e.KeyCode, GridView1)
            e.Handled = True
        End If

    End Sub


    Public Overridable Sub intro()

    End Sub

    Private Sub GridView1_ColumnFilterChanged(sender As System.Object, e As System.EventArgs) Handles GridView1.ColumnFilterChanged
        ColumnFilterChanged(sender, e)
    End Sub

    Public Overridable Sub ColumnFilterChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub GridView1_CustomDrawGroupRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow

    '    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
    '    Dim rowLevel As Integer = view.GetRowLevel(e.RowHandle)
    '    If rowLevel = 0 Then
    '        e.Appearance.BackColor = System.Drawing.Color.FromArgb(37, 136, 169)
    '    End If

    'End Sub

    Private Sub GridView1_CustomDrawRowFooter(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawRowFooter
        CustomDrawRowFooter(sender, e)
    End Sub

    Public Overridable Sub CustomDrawRowFooter(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawRowFooter
    End Sub

    Private Sub GridView1_GroupLevelStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles GridView1.GroupLevelStyle
        GroupLevelStyle(sender, e)
    End Sub

    Public Overridable Sub GroupLevelStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles GridView1.GroupLevelStyle
    End Sub


    Public Overridable Sub MostrarTodosLosCampos()
        BConsultar.PerformClick()
    End Sub

    Private Sub PlantillaConsulta1_MostrarTodosLosCampos() Handles PlantillaConsulta1.MostrarTodosLosCampos

        _IncluirTodosLosCampos = PlantillaConsulta1.mnuMostrarTodosCampos.Checked

        MostrarTodosLosCampos()

    End Sub

    Private Sub GridView1_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate

        CustomSummaryCalculate(sender, e)

    End Sub


    Public Overridable Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate

    End Sub

   
    Private Sub GridView1_FocusedRowLoaded(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles GridView1.FocusedRowLoaded
        FocusedRowLoaded(sender, e)
    End Sub


    Public Overridable Sub FocusedRowLoaded(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles GridView1.FocusedRowLoaded
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        FocusedRowChanged(sender, e)
    End Sub

    Public Overridable Sub FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
    End Sub

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub

    Private Sub GridView1_StartGrouping(sender As System.Object, e As System.EventArgs) Handles GridView1.StartGrouping
        StartGrouping(sender, e)
    End Sub

    Public Overridable Sub StartGrouping(sender As System.Object, e As System.EventArgs)

    End Sub


	Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        PanelCabecera.Visible = True
        PanelConsulta.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonEsconder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEsconder.Click
        PanelCabecera.Visible = False
        PanelConsulta.Dock = DockStyle.Fill
    End Sub

    'Private Sub GridView1_CustomDrawGroupPanel(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles GridView1.CustomDrawGroupPanel
    '    CustomDrawGroupPanel(sender, e)
    'End Sub

    'Public Overridable Sub CustomDrawGroupPanel(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles GridView1.CustomDrawGroupPanel

    'End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        CustomDrawRowFooter(sender, e)
    End Sub

    Public Overridable Sub CustomDrawFooterCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell

    End Sub

    Private Sub GridView1_CustomDrawRowFooterCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawRowFooterCell
        CustomDrawRowFooterCell(sender, e)
    End Sub

    Public Overridable Sub CustomDrawRowFooterCell(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawRowFooterCell

    End Sub

    Private Sub GridView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridView1.DoubleClick
        GridDoubleClick(sender, e)
    End Sub

    Public Overridable Sub GridDoubleClick(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub BtExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles BtExportarExcel.Click

        ExportarAExcel()

    End Sub


    Public Overridable Sub ExportarAExcel()

        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then


                Dim sd As SaveFileDialog = New SaveFileDialog()

                sd.Title = "Guardar datos como..."
                sd.Filter = "Excel 1997-2003 (*.xls)|*.xls"
                sd.FilterIndex = 1
                If sd.ShowDialog() = DialogResult.OK Then

                    Try

                        Dim fichero As String = sd.FileName


                        Dim options As New DevExpress.XtraPrinting.XlsExportOptions
                        options.SheetName = "Hoja1"
                        options.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value
                        options.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile



                        'Dim options as New XlsExportOptions() With { Key .SheetName = "Hoja1", 
                        '                                            Key .TextExportMode = TextExportMode.Text, 
                        '                                            Key .RawDataMode = True, 
                        '                                            Key .ExportMode = XlsExportMode.SingleFile }

                        Grid.ExportToXls(fichero, options)
                        Try
                            System.Diagnostics.Process.Start(fichero)
                        Catch ex As Exception
                            MsgBox("Error al abrir la hoja de excel en " & fichero)
                        End Try





                    Catch ex As Exception
                        MsgBox("Error al exportar a Excel: " & ex.Message)
                    End Try


                End If

            Else
                MsgBox("No hay datos que exportar")
            End If
        Else
            MsgBox("No hay datos para exportar")
        End If

    End Sub

End Class