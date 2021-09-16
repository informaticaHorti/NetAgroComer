<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarHistoricosAEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarHistoricosAEN))
        Me.PanelAcciones = New System.Windows.Forms.Panel()
        Me.BtAux = New NetAgro.ClButton()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.BConsulta = New NetAgro.ClButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.PanelAcciones.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAcciones
        '
        Me.PanelAcciones.Controls.Add(Me.BtAux)
        Me.PanelAcciones.Controls.Add(Me.ClButton1)
        Me.PanelAcciones.Controls.Add(Me.BConsulta)
        Me.PanelAcciones.Controls.Add(Me.ProgressBar1)
        Me.PanelAcciones.Controls.Add(Me.Bsalir)
        Me.PanelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAcciones.Location = New System.Drawing.Point(0, 432)
        Me.PanelAcciones.Name = "PanelAcciones"
        Me.PanelAcciones.Size = New System.Drawing.Size(1030, 34)
        Me.PanelAcciones.TabIndex = 4
        '
        'BtAux
        '
        Me.BtAux.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.BtAux.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux.Location = New System.Drawing.Point(730, 0)
        Me.BtAux.Name = "BtAux"
        Me.BtAux.Orden = 0
        Me.BtAux.PedirClave = True
        Me.BtAux.Size = New System.Drawing.Size(75, 34)
        Me.BtAux.TabIndex = 114
        Me.BtAux.Text = "Actualizar"
        Me.BtAux.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux.UseVisualStyleBackColor = True
        '
        'ClButton1
        '
        Me.ClButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClButton1.Location = New System.Drawing.Point(805, 0)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(75, 34)
        Me.ClButton1.TabIndex = 113
        Me.ClButton1.Text = "Imprimir"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'BConsulta
        '
        Me.BConsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsulta.Location = New System.Drawing.Point(880, 0)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Orden = 0
        Me.BConsulta.PedirClave = True
        Me.BConsulta.Size = New System.Drawing.Size(75, 34)
        Me.BConsulta.TabIndex = 112
        Me.BConsulta.Text = "Consultar"
        Me.BConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(319, 23)
        Me.ProgressBar1.TabIndex = 104
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(955, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(75, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 57)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1030, 375)
        Me.Grid.TabIndex = 13
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'prtSystem
        '
        Me.prtSystem.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.Grid
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(996, 26)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100292
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(969, 26)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100293
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'FrmActualizarHistoricosAEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 466)
        Me.Controls.Add(Me.BtSelTodos)
        Me.Controls.Add(Me.BtSelNinguno)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PanelAcciones)
        Me.Name = "FrmActualizarHistoricosAEN"
        Me.Text = "Actualizar Históricos de Albaranes de Entrada"
        Me.PanelAcciones.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelAcciones As System.Windows.Forms.Panel
    Protected WithEvents Bsalir As NetAgro.ClButton
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Protected WithEvents BtAux As NetAgro.ClButton
    Protected WithEvents ClButton1 As NetAgro.ClButton
    Protected WithEvents BConsulta As NetAgro.ClButton
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
End Class
