<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBalanceMasas
    Inherits NetAgro.FrConsulta

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBalanceMasas))
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.GridBalanceMasas = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBalanceMasas = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.bandGeneroFamilia = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandIdFamilia = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.IdFamilia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bandFamilia = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandIdGenero = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandGenero = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradas = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotalBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotalDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntadasTotalNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidas = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasNoControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasTotal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.EntContBruto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntContDestrio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntContNeto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntNoContBruto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntNoContDestrio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntNoContNeto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntTotalBruto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntTotalDestrio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.EntTotalNeto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.SalCont = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.SalNoCont = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.SalTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Familia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.IdGenero = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Genero = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LbNomGeneroHasta = New NetAgro.Lb(Me.components)
        Me.TxHastaGenero = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGeneroDesde = New NetAgro.Lb(Me.components)
        Me.TxDesdeGenero = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelConsulta.SuspendLayout()
        CType(Me.GridBalanceMasas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBalanceMasas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.TxHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(930, 100)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Controls.Add(Me.GridBalanceMasas)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 100)
        Me.PanelConsulta.Size = New System.Drawing.Size(930, 449)
        Me.PanelConsulta.Controls.SetChildIndex(Me.GridBalanceMasas, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(120, 37)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 83
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(17, 40)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxDesdeFecha
        '
        Me.TxDesdeFecha.Autonumerico = False
        Me.TxDesdeFecha.Buscando = False
        Me.TxDesdeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeFecha.ClForm = Nothing
        Me.TxDesdeFecha.ClParam = Nothing
        Me.TxDesdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFecha.GridLin = Nothing
        Me.TxDesdeFecha.HaCambiado = False
        Me.TxDesdeFecha.lbbusca = Nothing
        Me.TxDesdeFecha.Location = New System.Drawing.Point(120, 11)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 81
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.TxDatoFinalSemana = Nothing
        Me.TxDesdeFecha.TxDatoInicioSemana = Nothing
        Me.TxDesdeFecha.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(17, 14)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'GridBalanceMasas
        '
        Me.GridBalanceMasas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridBalanceMasas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBalanceMasas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBalanceMasas.Location = New System.Drawing.Point(0, 30)
        Me.GridBalanceMasas.LookAndFeel.SkinName = "Black"
        Me.GridBalanceMasas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridBalanceMasas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridBalanceMasas.MainView = Me.GridViewBalanceMasas
        Me.GridBalanceMasas.Name = "GridBalanceMasas"
        Me.GridBalanceMasas.Size = New System.Drawing.Size(930, 419)
        Me.GridBalanceMasas.TabIndex = 14
        Me.GridBalanceMasas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBalanceMasas})
        '
        'GridViewBalanceMasas
        '
        Me.GridViewBalanceMasas.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewBalanceMasas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewBalanceMasas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridViewBalanceMasas.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewBalanceMasas.Appearance.Row.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.Row.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandGeneroFamilia, Me.bandEntradas, Me.bandSalidas})
        Me.GridViewBalanceMasas.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.EntContBruto, Me.EntContDestrio, Me.EntContNeto, Me.EntNoContBruto, Me.EntNoContDestrio, Me.EntNoContNeto, Me.EntTotalBruto, Me.EntTotalDestrio, Me.EntTotalNeto, Me.SalCont, Me.SalNoCont, Me.SalTotal, Me.IdFamilia, Me.Familia, Me.IdGenero, Me.Genero})
        Me.GridViewBalanceMasas.GridControl = Me.GridBalanceMasas
        Me.GridViewBalanceMasas.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBalanceMasas.Name = "GridViewBalanceMasas"
        Me.GridViewBalanceMasas.OptionsBehavior.Editable = False
        Me.GridViewBalanceMasas.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewBalanceMasas.OptionsView.ColumnAutoWidth = True
        '
        'bandGeneroFamilia
        '
        Me.bandGeneroFamilia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandGeneroFamilia.AppearanceHeader.Options.UseFont = True
        Me.bandGeneroFamilia.AppearanceHeader.Options.UseTextOptions = True
        Me.bandGeneroFamilia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandGeneroFamilia.Caption = "Familia/Genero"
        Me.bandGeneroFamilia.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandIdFamilia, Me.bandFamilia, Me.bandIdGenero, Me.bandGenero})
        Me.bandGeneroFamilia.Name = "bandGeneroFamilia"
        Me.bandGeneroFamilia.Width = 140
        '
        'bandIdFamilia
        '
        Me.bandIdFamilia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandIdFamilia.AppearanceHeader.Options.UseFont = True
        Me.bandIdFamilia.AppearanceHeader.Options.UseTextOptions = True
        Me.bandIdFamilia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandIdFamilia.Caption = "IdFamilia"
        Me.bandIdFamilia.Columns.Add(Me.IdFamilia)
        Me.bandIdFamilia.Name = "bandIdFamilia"
        Me.bandIdFamilia.Visible = False
        '
        'IdFamilia
        '
        Me.IdFamilia.Caption = "IdFamilia"
        Me.IdFamilia.FieldName = "IdFamilia"
        Me.IdFamilia.Name = "IdFamilia"
        '
        'bandFamilia
        '
        Me.bandFamilia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandFamilia.AppearanceHeader.Options.UseFont = True
        Me.bandFamilia.AppearanceHeader.Options.UseTextOptions = True
        Me.bandFamilia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandFamilia.Caption = "Familia"
        Me.bandFamilia.Name = "bandFamilia"
        '
        'bandIdGenero
        '
        Me.bandIdGenero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandIdGenero.AppearanceHeader.Options.UseFont = True
        Me.bandIdGenero.AppearanceHeader.Options.UseTextOptions = True
        Me.bandIdGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandIdGenero.Caption = "IdGenero"
        Me.bandIdGenero.Name = "bandIdGenero"
        Me.bandIdGenero.Visible = False
        '
        'bandGenero
        '
        Me.bandGenero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandGenero.AppearanceHeader.Options.UseFont = True
        Me.bandGenero.AppearanceHeader.Options.UseTextOptions = True
        Me.bandGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandGenero.Caption = "Genero"
        Me.bandGenero.Name = "bandGenero"
        '
        'bandEntradas
        '
        Me.bandEntradas.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bandEntradas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradas.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradas.AppearanceHeader.Options.UseFont = True
        Me.bandEntradas.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradas.Caption = "ENTRADAS"
        Me.bandEntradas.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasControlado, Me.bandEntradasNoControlado, Me.bandEntradasTotal})
        Me.bandEntradas.Name = "bandEntradas"
        Me.bandEntradas.Width = 630
        '
        'bandEntradasControlado
        '
        Me.bandEntradasControlado.AppearanceHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.bandEntradasControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasControlado.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControlado.Caption = "CONTROLADO"
        Me.bandEntradasControlado.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasControladoBruto, Me.bandEntradasControladoDestrio, Me.bandEntradasControladoNeto})
        Me.bandEntradasControlado.Name = "bandEntradasControlado"
        Me.bandEntradasControlado.Width = 210
        '
        'bandEntradasControladoBruto
        '
        Me.bandEntradasControladoBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoBruto.Caption = "Bruto"
        Me.bandEntradasControladoBruto.Name = "bandEntradasControladoBruto"
        '
        'bandEntradasControladoDestrio
        '
        Me.bandEntradasControladoDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoDestrio.Caption = "Destrio"
        Me.bandEntradasControladoDestrio.Name = "bandEntradasControladoDestrio"
        '
        'bandEntradasControladoNeto
        '
        Me.bandEntradasControladoNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoNeto.Caption = "Neto"
        Me.bandEntradasControladoNeto.Name = "bandEntradasControladoNeto"
        '
        'bandEntradasNoControlado
        '
        Me.bandEntradasNoControlado.AppearanceHeader.BackColor = System.Drawing.Color.LightSalmon
        Me.bandEntradasNoControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControlado.Caption = "NO CONTROLADO"
        Me.bandEntradasNoControlado.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasNoControladoBruto, Me.bandEntradasNoControladoDestrio, Me.bandEntradasNoControladoNeto})
        Me.bandEntradasNoControlado.Name = "bandEntradasNoControlado"
        Me.bandEntradasNoControlado.Width = 210
        '
        'bandEntradasNoControladoBruto
        '
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoBruto.Caption = "Bruto"
        Me.bandEntradasNoControladoBruto.Name = "bandEntradasNoControladoBruto"
        '
        'bandEntradasNoControladoDestrio
        '
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoDestrio.Caption = "Destrio"
        Me.bandEntradasNoControladoDestrio.Name = "bandEntradasNoControladoDestrio"
        '
        'bandEntradasNoControladoNeto
        '
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoNeto.Caption = "Neto"
        Me.bandEntradasNoControladoNeto.Name = "bandEntradasNoControladoNeto"
        '
        'bandEntradasTotal
        '
        Me.bandEntradasTotal.AppearanceHeader.BackColor = System.Drawing.Color.Moccasin
        Me.bandEntradasTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotal.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasTotal.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotal.Caption = "TOTAL"
        Me.bandEntradasTotal.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasTotalBruto, Me.bandEntradasTotalDestrio, Me.bandEntadasTotalNeto})
        Me.bandEntradasTotal.Name = "bandEntradasTotal"
        Me.bandEntradasTotal.Width = 210
        '
        'bandEntradasTotalBruto
        '
        Me.bandEntradasTotalBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotalBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotalBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotalBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotalBruto.Caption = "Bruto"
        Me.bandEntradasTotalBruto.Name = "bandEntradasTotalBruto"
        '
        'bandEntradasTotalDestrio
        '
        Me.bandEntradasTotalDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotalDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotalDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotalDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotalDestrio.Caption = "Destrio"
        Me.bandEntradasTotalDestrio.Name = "bandEntradasTotalDestrio"
        '
        'bandEntadasTotalNeto
        '
        Me.bandEntadasTotalNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntadasTotalNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntadasTotalNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntadasTotalNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntadasTotalNeto.Caption = "Neto"
        Me.bandEntadasTotalNeto.Name = "bandEntadasTotalNeto"
        '
        'bandSalidas
        '
        Me.bandSalidas.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise
        Me.bandSalidas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidas.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidas.AppearanceHeader.Options.UseFont = True
        Me.bandSalidas.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidas.Caption = "SALIDAS"
        Me.bandSalidas.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandSalidasControlado, Me.bandSalidasNoControlado, Me.bandSalidasTotal})
        Me.bandSalidas.Name = "bandSalidas"
        Me.bandSalidas.Width = 210
        '
        'bandSalidasControlado
        '
        Me.bandSalidasControlado.AppearanceHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.bandSalidasControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasControlado.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasControlado.Caption = "CONTROLADO"
        Me.bandSalidasControlado.Name = "bandSalidasControlado"
        '
        'bandSalidasNoControlado
        '
        Me.bandSalidasNoControlado.AppearanceHeader.BackColor = System.Drawing.Color.LightSalmon
        Me.bandSalidasNoControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasNoControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasNoControlado.Caption = "NO CONT."
        Me.bandSalidasNoControlado.Name = "bandSalidasNoControlado"
        '
        'bandSalidasTotal
        '
        Me.bandSalidasTotal.AppearanceHeader.BackColor = System.Drawing.Color.Moccasin
        Me.bandSalidasTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasTotal.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasTotal.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasTotal.Caption = "TOTAL"
        Me.bandSalidasTotal.Name = "bandSalidasTotal"
        '
        'EntContBruto
        '
        Me.EntContBruto.Caption = "Bruto"
        Me.EntContBruto.FieldName = "EntContBruto"
        Me.EntContBruto.Name = "EntContBruto"
        Me.EntContBruto.Visible = True
        '
        'EntContDestrio
        '
        Me.EntContDestrio.Caption = "Destrio"
        Me.EntContDestrio.FieldName = "EntContDestrio"
        Me.EntContDestrio.Name = "EntContDestrio"
        Me.EntContDestrio.Visible = True
        '
        'EntContNeto
        '
        Me.EntContNeto.Caption = "Neto"
        Me.EntContNeto.FieldName = "EntContNeto"
        Me.EntContNeto.Name = "EntContNeto"
        Me.EntContNeto.Visible = True
        '
        'EntNoContBruto
        '
        Me.EntNoContBruto.Caption = "Bruto"
        Me.EntNoContBruto.FieldName = "EntNoContBruto"
        Me.EntNoContBruto.Name = "EntNoContBruto"
        Me.EntNoContBruto.Visible = True
        '
        'EntNoContDestrio
        '
        Me.EntNoContDestrio.Caption = "Destrio"
        Me.EntNoContDestrio.FieldName = "EntNoContDestrio"
        Me.EntNoContDestrio.Name = "EntNoContDestrio"
        Me.EntNoContDestrio.Visible = True
        '
        'EntNoContNeto
        '
        Me.EntNoContNeto.Caption = "Neto"
        Me.EntNoContNeto.FieldName = "EntNoContNeto"
        Me.EntNoContNeto.Name = "EntNoContNeto"
        Me.EntNoContNeto.Visible = True
        '
        'EntTotalBruto
        '
        Me.EntTotalBruto.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.EntTotalBruto.AppearanceCell.Options.UseBackColor = True
        Me.EntTotalBruto.Caption = "Bruto"
        Me.EntTotalBruto.FieldName = "EntTotalBruto"
        Me.EntTotalBruto.Name = "EntTotalBruto"
        Me.EntTotalBruto.Visible = True
        '
        'EntTotalDestrio
        '
        Me.EntTotalDestrio.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.EntTotalDestrio.AppearanceCell.Options.UseBackColor = True
        Me.EntTotalDestrio.Caption = "Destrio"
        Me.EntTotalDestrio.FieldName = "EntTotalDestrio"
        Me.EntTotalDestrio.Name = "EntTotalDestrio"
        Me.EntTotalDestrio.Visible = True
        '
        'EntTotalNeto
        '
        Me.EntTotalNeto.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.EntTotalNeto.AppearanceCell.Options.UseBackColor = True
        Me.EntTotalNeto.Caption = "Neto"
        Me.EntTotalNeto.FieldName = "EntTotalNeto"
        Me.EntTotalNeto.Name = "EntTotalNeto"
        Me.EntTotalNeto.Visible = True
        '
        'SalCont
        '
        Me.SalCont.Caption = "Controlado"
        Me.SalCont.FieldName = "SalCont"
        Me.SalCont.Name = "SalCont"
        Me.SalCont.Visible = True
        '
        'SalNoCont
        '
        Me.SalNoCont.Caption = "No controlado"
        Me.SalNoCont.FieldName = "SalNoCont"
        Me.SalNoCont.Name = "SalNoCont"
        Me.SalNoCont.Visible = True
        '
        'SalTotal
        '
        Me.SalTotal.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.SalTotal.AppearanceCell.Options.UseBackColor = True
        Me.SalTotal.Caption = "Total"
        Me.SalTotal.FieldName = "SalTotal"
        Me.SalTotal.Name = "SalTotal"
        Me.SalTotal.Visible = True
        '
        'Familia
        '
        Me.Familia.Caption = "Familia"
        Me.Familia.FieldName = "Familia"
        Me.Familia.Name = "Familia"
        Me.Familia.Visible = True
        '
        'IdGenero
        '
        Me.IdGenero.Caption = "IdGenero"
        Me.IdGenero.FieldName = "IdGenero"
        Me.IdGenero.Name = "IdGenero"
        Me.IdGenero.Visible = True
        '
        'Genero
        '
        Me.Genero.Caption = "Genero"
        Me.Genero.FieldName = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.Visible = True
        '
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(487, 36)
        Me.LbNomGeneroHasta.Name = "LbNomGeneroHasta"
        Me.LbNomGeneroHasta.Size = New System.Drawing.Size(402, 23)
        Me.LbNomGeneroHasta.TabIndex = 91
        '
        'TxHastaGenero
        '
        Me.TxHastaGenero.Autonumerico = False
        Me.TxHastaGenero.Buscando = False
        Me.TxHastaGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaGenero.ClForm = Nothing
        Me.TxHastaGenero.ClParam = Nothing
        Me.TxHastaGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaGenero.GridLin = Nothing
        Me.TxHastaGenero.HaCambiado = False
        Me.TxHastaGenero.lbbusca = Nothing
        Me.TxHastaGenero.Location = New System.Drawing.Point(379, 36)
        Me.TxHastaGenero.MiError = False
        Me.TxHastaGenero.Name = "TxHastaGenero"
        Me.TxHastaGenero.Orden = 0
        Me.TxHastaGenero.SaltoAlfinal = False
        Me.TxHastaGenero.Siguiente = 0
        Me.TxHastaGenero.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaGenero.TabIndex = 90
        Me.TxHastaGenero.TeclaRepetida = False
        Me.TxHastaGenero.TxDatoFinalSemana = Nothing
        Me.TxHastaGenero.TxDatoInicioSemana = Nothing
        Me.TxHastaGenero.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroHasta
        '
        Me.BtBuscaGeneroHasta.CL_Ancho = 0
        Me.BtBuscaGeneroHasta.CL_BuscaAlb = False
        Me.BtBuscaGeneroHasta.CL_campocodigo = Nothing
        Me.BtBuscaGeneroHasta.CL_camponombre = Nothing
        Me.BtBuscaGeneroHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroHasta.CL_ch1000 = False
        Me.BtBuscaGeneroHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroHasta.CL_dfecha = Nothing
        Me.BtBuscaGeneroHasta.CL_Entidad = Nothing
        Me.BtBuscaGeneroHasta.CL_EsId = True
        Me.BtBuscaGeneroHasta.CL_Filtro = Nothing
        Me.BtBuscaGeneroHasta.cl_formu = Nothing
        Me.BtBuscaGeneroHasta.CL_hfecha = Nothing
        Me.BtBuscaGeneroHasta.cl_ListaW = Nothing
        Me.BtBuscaGeneroHasta.CL_xCentro = False
        Me.BtBuscaGeneroHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(448, 36)
        Me.BtBuscaGeneroHasta.Name = "BtBuscaGeneroHasta"
        Me.BtBuscaGeneroHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroHasta.TabIndex = 89
        Me.BtBuscaGeneroHasta.UseVisualStyleBackColor = True
        '
        'LbHastaGenero
        '
        Me.LbHastaGenero.AutoSize = True
        Me.LbHastaGenero.CL_ControlAsociado = Nothing
        Me.LbHastaGenero.CL_ValorFijo = False
        Me.LbHastaGenero.ClForm = Nothing
        Me.LbHastaGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaGenero.Location = New System.Drawing.Point(266, 39)
        Me.LbHastaGenero.Name = "LbHastaGenero"
        Me.LbHastaGenero.Size = New System.Drawing.Size(107, 16)
        Me.LbHastaGenero.TabIndex = 88
        Me.LbHastaGenero.Text = "Hasta Genero"
        '
        'LbNomGeneroDesde
        '
        Me.LbNomGeneroDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroDesde.CL_ControlAsociado = Nothing
        Me.LbNomGeneroDesde.CL_ValorFijo = False
        Me.LbNomGeneroDesde.ClForm = Nothing
        Me.LbNomGeneroDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(487, 10)
        Me.LbNomGeneroDesde.Name = "LbNomGeneroDesde"
        Me.LbNomGeneroDesde.Size = New System.Drawing.Size(402, 23)
        Me.LbNomGeneroDesde.TabIndex = 87
        '
        'TxDesdeGenero
        '
        Me.TxDesdeGenero.Autonumerico = False
        Me.TxDesdeGenero.Buscando = False
        Me.TxDesdeGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeGenero.ClForm = Nothing
        Me.TxDesdeGenero.ClParam = Nothing
        Me.TxDesdeGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeGenero.GridLin = Nothing
        Me.TxDesdeGenero.HaCambiado = False
        Me.TxDesdeGenero.lbbusca = Nothing
        Me.TxDesdeGenero.Location = New System.Drawing.Point(379, 10)
        Me.TxDesdeGenero.MiError = False
        Me.TxDesdeGenero.Name = "TxDesdeGenero"
        Me.TxDesdeGenero.Orden = 0
        Me.TxDesdeGenero.SaltoAlfinal = False
        Me.TxDesdeGenero.Siguiente = 0
        Me.TxDesdeGenero.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeGenero.TabIndex = 86
        Me.TxDesdeGenero.TeclaRepetida = False
        Me.TxDesdeGenero.TxDatoFinalSemana = Nothing
        Me.TxDesdeGenero.TxDatoInicioSemana = Nothing
        Me.TxDesdeGenero.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroDesde
        '
        Me.BtBuscaGeneroDesde.CL_Ancho = 0
        Me.BtBuscaGeneroDesde.CL_BuscaAlb = False
        Me.BtBuscaGeneroDesde.CL_campocodigo = Nothing
        Me.BtBuscaGeneroDesde.CL_camponombre = Nothing
        Me.BtBuscaGeneroDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroDesde.CL_ch1000 = False
        Me.BtBuscaGeneroDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroDesde.CL_dfecha = Nothing
        Me.BtBuscaGeneroDesde.CL_Entidad = Nothing
        Me.BtBuscaGeneroDesde.CL_EsId = True
        Me.BtBuscaGeneroDesde.CL_Filtro = Nothing
        Me.BtBuscaGeneroDesde.cl_formu = Nothing
        Me.BtBuscaGeneroDesde.CL_hfecha = Nothing
        Me.BtBuscaGeneroDesde.cl_ListaW = Nothing
        Me.BtBuscaGeneroDesde.CL_xCentro = False
        Me.BtBuscaGeneroDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(448, 10)
        Me.BtBuscaGeneroDesde.Name = "BtBuscaGeneroDesde"
        Me.BtBuscaGeneroDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroDesde.TabIndex = 85
        Me.BtBuscaGeneroDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeGenero
        '
        Me.LbDesdeGenero.AutoSize = True
        Me.LbDesdeGenero.CL_ControlAsociado = Nothing
        Me.LbDesdeGenero.CL_ValorFijo = False
        Me.LbDesdeGenero.ClForm = Nothing
        Me.LbDesdeGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeGenero.Location = New System.Drawing.Point(266, 13)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 84
        Me.LbDesdeGenero.Text = "Desde Genero"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(120, 65)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100316
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(17, 66)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(64, 16)
        Me.Lb5.TabIndex = 100315
        Me.Lb5.Text = "P.venta"
        '
        'FrmBalanceMasas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 583)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmBalanceMasas"
        Me.Text = "Balance de masas"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelConsulta.ResumeLayout(False)
        CType(Me.GridBalanceMasas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBalanceMasas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Public WithEvents GridBalanceMasas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBalanceMasas As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents EntContBruto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntContDestrio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntContNeto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntNoContBruto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntNoContDestrio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntNoContNeto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntTotalBruto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntTotalDestrio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents EntTotalNeto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SalCont As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SalNoCont As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SalTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents IdFamilia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Familia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents IdGenero As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Genero As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bandGeneroFamilia As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandIdFamilia As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandFamilia As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandIdGenero As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandGenero As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradas As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotalBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotalDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntadasTotalNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidas As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasNoControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasTotal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LbNomGeneroHasta As NetAgro.Lb
    Friend WithEvents TxHastaGenero As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents LbNomGeneroDesde As NetAgro.Lb
    Friend WithEvents TxDesdeGenero As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
