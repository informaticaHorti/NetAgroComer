<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisorPedidoEDI
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisorPedidoEDI))
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtAux3 = New NetAgro.ClButton()
        Me.BtImportar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GridLineas = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LbTObservacionesLin = New NetAgro.Lb(Me.components)
        Me.GridObservacionesLínea = New DevExpress.XtraGrid.GridControl()
        Me.GridViewObservacionesLinea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.LbDesglose = New NetAgro.Lb(Me.components)
        Me.GridDesglose = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDesglose = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GridObservacionesCabecera = New DevExpress.XtraGrid.GridControl()
        Me.GridViewObservacionesCabecera = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbIdClienteComprador = New NetAgro.Lb(Me.components)
        Me.LbClienteComprador = New NetAgro.Lb(Me.components)
        Me.LbTClienteComprador = New NetAgro.Lb(Me.components)
        Me.LbFechaEntregaRequerida = New NetAgro.Lb(Me.components)
        Me.LbTFechaEntregaRequerida = New NetAgro.Lb(Me.components)
        Me.LbTipoMensaje = New System.Windows.Forms.Label()
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.LbTFecha = New NetAgro.Lb(Me.components)
        Me.LbRefCliente = New NetAgro.Lb(Me.components)
        Me.LbTRefCliente = New NetAgro.Lb(Me.components)
        Me.LbNumeroOrden = New NetAgro.Lb(Me.components)
        Me.LbTNumeroOrden = New NetAgro.Lb(Me.components)
        Me.LbIdDomicilio = New NetAgro.Lb(Me.components)
        Me.LbDomicilioDescarga = New NetAgro.Lb(Me.components)
        Me.LbTReceptor = New NetAgro.Lb(Me.components)
        Me.LbDpto = New NetAgro.Lb(Me.components)
        Me.LbBESTELLNR = New NetAgro.Lb(Me.components)
        Me.PanelBotones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridObservacionesLínea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewObservacionesLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GridDesglose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDesglose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridObservacionesCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewObservacionesCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.BtAux3)
        Me.PanelBotones.Controls.Add(Me.BtImportar)
        Me.PanelBotones.Controls.Add(Me.Bsalir)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(0, 543)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(1290, 36)
        Me.PanelBotones.TabIndex = 3
        '
        'BtAux3
        '
        Me.BtAux3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux3.Location = New System.Drawing.Point(1095, 0)
        Me.BtAux3.Name = "BtAux3"
        Me.BtAux3.Orden = 0
        Me.BtAux3.PedirClave = True
        Me.BtAux3.Size = New System.Drawing.Size(65, 36)
        Me.BtAux3.TabIndex = 106
        Me.BtAux3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux3.UseVisualStyleBackColor = True
        Me.BtAux3.Visible = False
        '
        'BtImportar
        '
        Me.BtImportar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtImportar.Image = Global.NetAgro.My.Resources.Resources.Action_window_no_fullscreen_16x16_32
        Me.BtImportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtImportar.Location = New System.Drawing.Point(1160, 0)
        Me.BtImportar.Name = "BtImportar"
        Me.BtImportar.Orden = 0
        Me.BtImportar.PedirClave = True
        Me.BtImportar.Size = New System.Drawing.Size(65, 36)
        Me.BtImportar.TabIndex = 105
        Me.BtImportar.Text = "Importar"
        Me.BtImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtImportar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1225, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 36)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(7, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1283, 417)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(9, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1266, 385)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GridLineas)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1258, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Líneas del pedido"
        '
        'GridLineas
        '
        Me.GridLineas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLineas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridLineas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLineas.Location = New System.Drawing.Point(0, 6)
        Me.GridLineas.LookAndFeel.SkinName = "Black"
        Me.GridLineas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridLineas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridLineas.MainView = Me.GridViewLineas
        Me.GridLineas.Name = "GridLineas"
        Me.GridLineas.Size = New System.Drawing.Size(810, 336)
        Me.GridLineas.TabIndex = 113
        Me.GridLineas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLineas})
        '
        'GridViewLineas
        '
        Me.GridViewLineas.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewLineas.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewLineas.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewLineas.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewLineas.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewLineas.Appearance.Row.Options.UseFont = True
        Me.GridViewLineas.Appearance.Row.Options.UseForeColor = True
        Me.GridViewLineas.GridControl = Me.GridLineas
        Me.GridViewLineas.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewLineas.Name = "GridViewLineas"
        Me.GridViewLineas.OptionsBehavior.Editable = False
        Me.GridViewLineas.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewLineas.OptionsView.ShowGroupPanel = False
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(816, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(436, 340)
        Me.TabControl2.TabIndex = 112
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.LbTObservacionesLin)
        Me.TabPage4.Controls.Add(Me.GridObservacionesLínea)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(428, 310)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Observaciones líneas"
        '
        'LbTObservacionesLin
        '
        Me.LbTObservacionesLin.AutoSize = True
        Me.LbTObservacionesLin.CL_ControlAsociado = Nothing
        Me.LbTObservacionesLin.CL_ValorFijo = True
        Me.LbTObservacionesLin.ClForm = Nothing
        Me.LbTObservacionesLin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbTObservacionesLin.ForeColor = System.Drawing.Color.Teal
        Me.LbTObservacionesLin.Location = New System.Drawing.Point(4, 10)
        Me.LbTObservacionesLin.Name = "LbTObservacionesLin"
        Me.LbTObservacionesLin.Size = New System.Drawing.Size(162, 18)
        Me.LbTObservacionesLin.TabIndex = 117
        Me.LbTObservacionesLin.Text = "OBSERVACIONES"
        '
        'GridObservacionesLínea
        '
        Me.GridObservacionesLínea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridObservacionesLínea.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridObservacionesLínea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridObservacionesLínea.Location = New System.Drawing.Point(7, 31)
        Me.GridObservacionesLínea.LookAndFeel.SkinName = "Black"
        Me.GridObservacionesLínea.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridObservacionesLínea.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridObservacionesLínea.MainView = Me.GridViewObservacionesLinea
        Me.GridObservacionesLínea.Name = "GridObservacionesLínea"
        Me.GridObservacionesLínea.Size = New System.Drawing.Size(415, 276)
        Me.GridObservacionesLínea.TabIndex = 116
        Me.GridObservacionesLínea.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewObservacionesLinea})
        '
        'GridViewObservacionesLinea
        '
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewObservacionesLinea.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewObservacionesLinea.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewObservacionesLinea.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesLinea.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewObservacionesLinea.Appearance.Row.Options.UseFont = True
        Me.GridViewObservacionesLinea.Appearance.Row.Options.UseForeColor = True
        Me.GridViewObservacionesLinea.GridControl = Me.GridObservacionesLínea
        Me.GridViewObservacionesLinea.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewObservacionesLinea.Name = "GridViewObservacionesLinea"
        Me.GridViewObservacionesLinea.OptionsBehavior.Editable = False
        Me.GridViewObservacionesLinea.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewObservacionesLinea.OptionsView.ShowGroupPanel = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.LbDesglose)
        Me.TabPage5.Controls.Add(Me.GridDesglose)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(428, 282)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Desglose líneas (ALCAMPO)"
        '
        'LbDesglose
        '
        Me.LbDesglose.AutoSize = True
        Me.LbDesglose.CL_ControlAsociado = Nothing
        Me.LbDesglose.CL_ValorFijo = True
        Me.LbDesglose.ClForm = Nothing
        Me.LbDesglose.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbDesglose.ForeColor = System.Drawing.Color.Teal
        Me.LbDesglose.Location = New System.Drawing.Point(4, 10)
        Me.LbDesglose.Name = "LbDesglose"
        Me.LbDesglose.Size = New System.Drawing.Size(102, 18)
        Me.LbDesglose.TabIndex = 115
        Me.LbDesglose.Text = "DESGLOSE"
        '
        'GridDesglose
        '
        Me.GridDesglose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDesglose.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridDesglose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDesglose.Location = New System.Drawing.Point(7, 31)
        Me.GridDesglose.LookAndFeel.SkinName = "Black"
        Me.GridDesglose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridDesglose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridDesglose.MainView = Me.GridViewDesglose
        Me.GridDesglose.Name = "GridDesglose"
        Me.GridDesglose.Size = New System.Drawing.Size(415, 253)
        Me.GridDesglose.TabIndex = 114
        Me.GridDesglose.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDesglose})
        '
        'GridViewDesglose
        '
        Me.GridViewDesglose.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewDesglose.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglose.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewDesglose.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewDesglose.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewDesglose.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewDesglose.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewDesglose.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglose.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewDesglose.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewDesglose.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewDesglose.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewDesglose.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglose.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewDesglose.Appearance.Row.Options.UseFont = True
        Me.GridViewDesglose.Appearance.Row.Options.UseForeColor = True
        Me.GridViewDesglose.GridControl = Me.GridDesglose
        Me.GridViewDesglose.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewDesglose.Name = "GridViewDesglose"
        Me.GridViewDesglose.OptionsBehavior.Editable = False
        Me.GridViewDesglose.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewDesglose.OptionsView.ShowGroupPanel = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1258, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Observaciones cabecera"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GridObservacionesCabecera)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1223, 311)
        Me.GroupBox3.TabIndex = 110
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OBSERVACIONES"
        '
        'GridObservacionesCabecera
        '
        Me.GridObservacionesCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridObservacionesCabecera.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridObservacionesCabecera.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridObservacionesCabecera.Location = New System.Drawing.Point(12, 26)
        Me.GridObservacionesCabecera.LookAndFeel.SkinName = "Black"
        Me.GridObservacionesCabecera.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridObservacionesCabecera.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridObservacionesCabecera.MainView = Me.GridViewObservacionesCabecera
        Me.GridObservacionesCabecera.Name = "GridObservacionesCabecera"
        Me.GridObservacionesCabecera.Size = New System.Drawing.Size(1202, 277)
        Me.GridObservacionesCabecera.TabIndex = 115
        Me.GridObservacionesCabecera.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewObservacionesCabecera})
        '
        'GridViewObservacionesCabecera
        '
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewObservacionesCabecera.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewObservacionesCabecera.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewObservacionesCabecera.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewObservacionesCabecera.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewObservacionesCabecera.Appearance.Row.Options.UseFont = True
        Me.GridViewObservacionesCabecera.Appearance.Row.Options.UseForeColor = True
        Me.GridViewObservacionesCabecera.GridControl = Me.GridObservacionesCabecera
        Me.GridViewObservacionesCabecera.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewObservacionesCabecera.Name = "GridViewObservacionesCabecera"
        Me.GridViewObservacionesCabecera.OptionsBehavior.Editable = False
        Me.GridViewObservacionesCabecera.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewObservacionesCabecera.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LbIdClienteComprador)
        Me.GroupBox1.Controls.Add(Me.LbDpto)
        Me.GroupBox1.Controls.Add(Me.LbBESTELLNR)
        Me.GroupBox1.Controls.Add(Me.LbClienteComprador)
        Me.GroupBox1.Controls.Add(Me.LbTClienteComprador)
        Me.GroupBox1.Controls.Add(Me.LbFechaEntregaRequerida)
        Me.GroupBox1.Controls.Add(Me.LbTFechaEntregaRequerida)
        Me.GroupBox1.Controls.Add(Me.LbTipoMensaje)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.LbTFecha)
        Me.GroupBox1.Controls.Add(Me.LbRefCliente)
        Me.GroupBox1.Controls.Add(Me.LbTRefCliente)
        Me.GroupBox1.Controls.Add(Me.LbNumeroOrden)
        Me.GroupBox1.Controls.Add(Me.LbTNumeroOrden)
        Me.GroupBox1.Controls.Add(Me.LbIdDomicilio)
        Me.GroupBox1.Controls.Add(Me.LbDomicilioDescarga)
        Me.GroupBox1.Controls.Add(Me.LbTReceptor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1283, 114)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'LbIdClienteComprador
        '
        Me.LbIdClienteComprador.BackColor = System.Drawing.Color.Gainsboro
        Me.LbIdClienteComprador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbIdClienteComprador.CL_ControlAsociado = Nothing
        Me.LbIdClienteComprador.CL_ValorFijo = True
        Me.LbIdClienteComprador.ClForm = Nothing
        Me.LbIdClienteComprador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdClienteComprador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdClienteComprador.Location = New System.Drawing.Point(181, 45)
        Me.LbIdClienteComprador.Name = "LbIdClienteComprador"
        Me.LbIdClienteComprador.Size = New System.Drawing.Size(43, 23)
        Me.LbIdClienteComprador.TabIndex = 104
        Me.LbIdClienteComprador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbClienteComprador
        '
        Me.LbClienteComprador.BackColor = System.Drawing.Color.Gainsboro
        Me.LbClienteComprador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbClienteComprador.CL_ControlAsociado = Nothing
        Me.LbClienteComprador.CL_ValorFijo = True
        Me.LbClienteComprador.ClForm = Nothing
        Me.LbClienteComprador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClienteComprador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbClienteComprador.Location = New System.Drawing.Point(229, 45)
        Me.LbClienteComprador.Name = "LbClienteComprador"
        Me.LbClienteComprador.Size = New System.Drawing.Size(502, 23)
        Me.LbClienteComprador.TabIndex = 101
        Me.LbClienteComprador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTClienteComprador
        '
        Me.LbTClienteComprador.AutoSize = True
        Me.LbTClienteComprador.CL_ControlAsociado = Nothing
        Me.LbTClienteComprador.CL_ValorFijo = True
        Me.LbTClienteComprador.ClForm = Nothing
        Me.LbTClienteComprador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTClienteComprador.ForeColor = System.Drawing.Color.Teal
        Me.LbTClienteComprador.Location = New System.Drawing.Point(8, 48)
        Me.LbTClienteComprador.Name = "LbTClienteComprador"
        Me.LbTClienteComprador.Size = New System.Drawing.Size(149, 16)
        Me.LbTClienteComprador.TabIndex = 100
        Me.LbTClienteComprador.Text = "Cliente/Comprador"
        '
        'LbFechaEntregaRequerida
        '
        Me.LbFechaEntregaRequerida.BackColor = System.Drawing.Color.Gainsboro
        Me.LbFechaEntregaRequerida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbFechaEntregaRequerida.CL_ControlAsociado = Nothing
        Me.LbFechaEntregaRequerida.CL_ValorFijo = True
        Me.LbFechaEntregaRequerida.ClForm = Nothing
        Me.LbFechaEntregaRequerida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaEntregaRequerida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFechaEntregaRequerida.Location = New System.Drawing.Point(975, 16)
        Me.LbFechaEntregaRequerida.Name = "LbFechaEntregaRequerida"
        Me.LbFechaEntregaRequerida.Size = New System.Drawing.Size(107, 23)
        Me.LbFechaEntregaRequerida.TabIndex = 99
        Me.LbFechaEntregaRequerida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTFechaEntregaRequerida
        '
        Me.LbTFechaEntregaRequerida.AutoSize = True
        Me.LbTFechaEntregaRequerida.CL_ControlAsociado = Nothing
        Me.LbTFechaEntregaRequerida.CL_ValorFijo = True
        Me.LbTFechaEntregaRequerida.ClForm = Nothing
        Me.LbTFechaEntregaRequerida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTFechaEntregaRequerida.ForeColor = System.Drawing.Color.Teal
        Me.LbTFechaEntregaRequerida.Location = New System.Drawing.Point(761, 19)
        Me.LbTFechaEntregaRequerida.Name = "LbTFechaEntregaRequerida"
        Me.LbTFechaEntregaRequerida.Size = New System.Drawing.Size(209, 16)
        Me.LbTFechaEntregaRequerida.TabIndex = 98
        Me.LbTFechaEntregaRequerida.Text = "Fecha de entrega requerida"
        '
        'LbTipoMensaje
        '
        Me.LbTipoMensaje.BackColor = System.Drawing.Color.SteelBlue
        Me.LbTipoMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTipoMensaje.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoMensaje.ForeColor = System.Drawing.Color.White
        Me.LbTipoMensaje.Location = New System.Drawing.Point(1106, 19)
        Me.LbTipoMensaje.Name = "LbTipoMensaje"
        Me.LbTipoMensaje.Size = New System.Drawing.Size(159, 37)
        Me.LbTipoMensaje.TabIndex = 93
        Me.LbTipoMensaje.Text = "PEDIDO NUEVO"
        Me.LbTipoMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.Color.Gainsboro
        Me.LbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = True
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(624, 16)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(107, 23)
        Me.LbFecha.TabIndex = 92
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTFecha
        '
        Me.LbTFecha.AutoSize = True
        Me.LbTFecha.CL_ControlAsociado = Nothing
        Me.LbTFecha.CL_ValorFijo = True
        Me.LbTFecha.ClForm = Nothing
        Me.LbTFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbTFecha.Location = New System.Drawing.Point(566, 19)
        Me.LbTFecha.Name = "LbTFecha"
        Me.LbTFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbTFecha.TabIndex = 91
        Me.LbTFecha.Text = "Fecha"
        '
        'LbRefCliente
        '
        Me.LbRefCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.LbRefCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbRefCliente.CL_ControlAsociado = Nothing
        Me.LbRefCliente.CL_ValorFijo = True
        Me.LbRefCliente.ClForm = Nothing
        Me.LbRefCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRefCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbRefCliente.Location = New System.Drawing.Point(389, 16)
        Me.LbRefCliente.Name = "LbRefCliente"
        Me.LbRefCliente.Size = New System.Drawing.Size(152, 23)
        Me.LbRefCliente.TabIndex = 90
        Me.LbRefCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTRefCliente
        '
        Me.LbTRefCliente.AutoSize = True
        Me.LbTRefCliente.CL_ControlAsociado = Nothing
        Me.LbTRefCliente.CL_ValorFijo = True
        Me.LbTRefCliente.ClForm = Nothing
        Me.LbTRefCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTRefCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbTRefCliente.Location = New System.Drawing.Point(292, 19)
        Me.LbTRefCliente.Name = "LbTRefCliente"
        Me.LbTRefCliente.Size = New System.Drawing.Size(91, 16)
        Me.LbTRefCliente.TabIndex = 89
        Me.LbTRefCliente.Text = "Ref. Cliente"
        '
        'LbNumeroOrden
        '
        Me.LbNumeroOrden.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNumeroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNumeroOrden.CL_ControlAsociado = Nothing
        Me.LbNumeroOrden.CL_ValorFijo = True
        Me.LbNumeroOrden.ClForm = Nothing
        Me.LbNumeroOrden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumeroOrden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNumeroOrden.Location = New System.Drawing.Point(181, 16)
        Me.LbNumeroOrden.Name = "LbNumeroOrden"
        Me.LbNumeroOrden.Size = New System.Drawing.Size(43, 23)
        Me.LbNumeroOrden.TabIndex = 88
        Me.LbNumeroOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTNumeroOrden
        '
        Me.LbTNumeroOrden.AutoSize = True
        Me.LbTNumeroOrden.CL_ControlAsociado = Nothing
        Me.LbTNumeroOrden.CL_ValorFijo = True
        Me.LbTNumeroOrden.ClForm = Nothing
        Me.LbTNumeroOrden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTNumeroOrden.ForeColor = System.Drawing.Color.Teal
        Me.LbTNumeroOrden.Location = New System.Drawing.Point(8, 19)
        Me.LbTNumeroOrden.Name = "LbTNumeroOrden"
        Me.LbTNumeroOrden.Size = New System.Drawing.Size(167, 16)
        Me.LbTNumeroOrden.TabIndex = 85
        Me.LbTNumeroOrden.Text = "Nº Orden en el fichero"
        '
        'LbIdDomicilio
        '
        Me.LbIdDomicilio.BackColor = System.Drawing.Color.Gainsboro
        Me.LbIdDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbIdDomicilio.CL_ControlAsociado = Nothing
        Me.LbIdDomicilio.CL_ValorFijo = True
        Me.LbIdDomicilio.ClForm = Nothing
        Me.LbIdDomicilio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdDomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdDomicilio.Location = New System.Drawing.Point(181, 74)
        Me.LbIdDomicilio.Name = "LbIdDomicilio"
        Me.LbIdDomicilio.Size = New System.Drawing.Size(43, 23)
        Me.LbIdDomicilio.TabIndex = 107
        Me.LbIdDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbDomicilioDescarga
        '
        Me.LbDomicilioDescarga.BackColor = System.Drawing.Color.Gainsboro
        Me.LbDomicilioDescarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDomicilioDescarga.CL_ControlAsociado = Nothing
        Me.LbDomicilioDescarga.CL_ValorFijo = True
        Me.LbDomicilioDescarga.ClForm = Nothing
        Me.LbDomicilioDescarga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilioDescarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDomicilioDescarga.Location = New System.Drawing.Point(229, 74)
        Me.LbDomicilioDescarga.Name = "LbDomicilioDescarga"
        Me.LbDomicilioDescarga.Size = New System.Drawing.Size(502, 23)
        Me.LbDomicilioDescarga.TabIndex = 106
        Me.LbDomicilioDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbTReceptor
        '
        Me.LbTReceptor.AutoSize = True
        Me.LbTReceptor.CL_ControlAsociado = Nothing
        Me.LbTReceptor.CL_ValorFijo = True
        Me.LbTReceptor.ClForm = Nothing
        Me.LbTReceptor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTReceptor.ForeColor = System.Drawing.Color.Teal
        Me.LbTReceptor.Location = New System.Drawing.Point(8, 77)
        Me.LbTReceptor.Name = "LbTReceptor"
        Me.LbTReceptor.Size = New System.Drawing.Size(73, 16)
        Me.LbTReceptor.TabIndex = 105
        Me.LbTReceptor.Text = "Receptor"
        '
        'LbDpto
        '
        Me.LbDpto.BackColor = System.Drawing.Color.Gainsboro
        Me.LbDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDpto.CL_ControlAsociado = Nothing
        Me.LbDpto.CL_ValorFijo = True
        Me.LbDpto.ClForm = Nothing
        Me.LbDpto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDpto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDpto.Location = New System.Drawing.Point(902, 45)
        Me.LbDpto.Name = "LbDpto"
        Me.LbDpto.Size = New System.Drawing.Size(180, 23)
        Me.LbDpto.TabIndex = 103
        Me.LbDpto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbBESTELLNR
        '
        Me.LbBESTELLNR.AutoSize = True
        Me.LbBESTELLNR.CL_ControlAsociado = Nothing
        Me.LbBESTELLNR.CL_ValorFijo = True
        Me.LbBESTELLNR.ClForm = Nothing
        Me.LbBESTELLNR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBESTELLNR.ForeColor = System.Drawing.Color.Teal
        Me.LbBESTELLNR.Location = New System.Drawing.Point(761, 48)
        Me.LbBESTELLNR.Name = "LbBESTELLNR"
        Me.LbBESTELLNR.Size = New System.Drawing.Size(88, 16)
        Me.LbBESTELLNR.TabIndex = 102
        Me.LbBESTELLNR.Text = "BESTELLNR"
        '
        'FrmVisorPedidoEDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelBotones)
        Me.Name = "FrmVisorPedidoEDI"
        Me.Text = "Información pedido EDI"
        Me.PanelBotones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GridObservacionesLínea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewObservacionesLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.GridDesglose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDesglose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridObservacionesCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewObservacionesCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBotones As System.Windows.Forms.Panel
    Friend WithEvents BtAux3 As NetAgro.ClButton
    Friend WithEvents BtImportar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents GridLineas As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents LbDesglose As NetAgro.Lb
    Public WithEvents GridDesglose As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewDesglose As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbClienteComprador As NetAgro.Lb
    Friend WithEvents LbTClienteComprador As NetAgro.Lb
    Friend WithEvents LbFechaEntregaRequerida As NetAgro.Lb
    Friend WithEvents LbTFechaEntregaRequerida As NetAgro.Lb
    Friend WithEvents LbTipoMensaje As System.Windows.Forms.Label
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents LbTFecha As NetAgro.Lb
    Friend WithEvents LbRefCliente As NetAgro.Lb
    Friend WithEvents LbTRefCliente As NetAgro.Lb
    Friend WithEvents LbNumeroOrden As NetAgro.Lb
    Friend WithEvents LbTNumeroOrden As NetAgro.Lb
    Public WithEvents GridObservacionesCabecera As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewObservacionesCabecera As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents LbTObservacionesLin As NetAgro.Lb
    Public WithEvents GridObservacionesLínea As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewObservacionesLinea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbIdClienteComprador As NetAgro.Lb
    Friend WithEvents LbDomicilioDescarga As NetAgro.Lb
    Friend WithEvents LbTReceptor As NetAgro.Lb
    Friend WithEvents LbIdDomicilio As NetAgro.Lb
    Friend WithEvents LbDpto As NetAgro.Lb
    Friend WithEvents LbBESTELLNR As NetAgro.Lb
End Class
