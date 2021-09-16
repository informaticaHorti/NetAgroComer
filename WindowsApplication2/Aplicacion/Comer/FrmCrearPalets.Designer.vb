<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearPalets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearPalets))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtImprimirTickets = New NetAgro.ClButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtGenerarPalets = New NetAgro.ClButton()
        Me.BConsultar = New NetAgro.ClButton()
        Me.BImprimir = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlLineasCostes = New System.Windows.Forms.Panel()
        Me.GridPalets = New DevExpress.XtraGrid.GridControl()
        Me.GridViewpalets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlGastosPorPalets = New System.Windows.Forms.Panel()
        Me.GridNuevosPalets = New DevExpress.XtraGrid.GridControl()
        Me.GridViewNuevosPalets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlLineasCostes.SuspendLayout()
        CType(Me.GridPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewpalets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlGastosPorPalets.SuspendLayout()
        CType(Me.GridNuevosPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewNuevosPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtImprimirTickets)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtGenerarPalets)
        Me.Panel1.Controls.Add(Me.BConsultar)
        Me.Panel1.Controls.Add(Me.BImprimir)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 41)
        Me.Panel1.TabIndex = 4
        '
        'BtImprimirTickets
        '
        Me.BtImprimirTickets.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.BtImprimirTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtImprimirTickets.Location = New System.Drawing.Point(577, 7)
        Me.BtImprimirTickets.Name = "BtImprimirTickets"
        Me.BtImprimirTickets.Orden = 0
        Me.BtImprimirTickets.PedirClave = True
        Me.BtImprimirTickets.Size = New System.Drawing.Size(148, 28)
        Me.BtImprimirTickets.TabIndex = 182
        Me.BtImprimirTickets.Text = "Imprimir tickets de palets"
        Me.BtImprimirTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtImprimirTickets.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(835, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 35)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'BtGenerarPalets
        '
        Me.BtGenerarPalets.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtGenerarPalets.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtGenerarPalets.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtGenerarPalets.Location = New System.Drawing.Point(969, 0)
        Me.BtGenerarPalets.Name = "BtGenerarPalets"
        Me.BtGenerarPalets.Orden = 0
        Me.BtGenerarPalets.PedirClave = True
        Me.BtGenerarPalets.Size = New System.Drawing.Size(90, 41)
        Me.BtGenerarPalets.TabIndex = 102
        Me.BtGenerarPalets.Text = "Generar palets"
        Me.BtGenerarPalets.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGenerarPalets.UseVisualStyleBackColor = True
        '
        'BConsultar
        '
        Me.BConsultar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsultar.Image = CType(resources.GetObject("BConsultar.Image"), System.Drawing.Image)
        Me.BConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsultar.Location = New System.Drawing.Point(1059, 0)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Orden = 0
        Me.BConsultar.PedirClave = True
        Me.BConsultar.Size = New System.Drawing.Size(75, 41)
        Me.BConsultar.TabIndex = 101
        Me.BConsultar.Text = "Consultar"
        Me.BConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BConsultar.UseVisualStyleBackColor = True
        '
        'BImprimir
        '
        Me.BImprimir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BImprimir.Image = CType(resources.GetObject("BImprimir.Image"), System.Drawing.Image)
        Me.BImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BImprimir.Location = New System.Drawing.Point(1134, 0)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Orden = 0
        Me.BImprimir.PedirClave = True
        Me.BImprimir.Size = New System.Drawing.Size(75, 41)
        Me.BImprimir.TabIndex = 98
        Me.BImprimir.Text = "Imprimir"
        Me.BImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BImprimir.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1209, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(75, 41)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlLineasCostes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 225)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 228)
        Me.Panel2.TabIndex = 5
        '
        'pnlLineasCostes
        '
        Me.pnlLineasCostes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLineasCostes.Controls.Add(Me.GridPalets)
        Me.pnlLineasCostes.Controls.Add(Me.Label3)
        Me.pnlLineasCostes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLineasCostes.Location = New System.Drawing.Point(0, 0)
        Me.pnlLineasCostes.Name = "pnlLineasCostes"
        Me.pnlLineasCostes.Size = New System.Drawing.Size(1284, 228)
        Me.pnlLineasCostes.TabIndex = 1
        '
        'GridPalets
        '
        Me.GridPalets.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPalets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPalets.Location = New System.Drawing.Point(0, 26)
        Me.GridPalets.LookAndFeel.SkinName = "Black"
        Me.GridPalets.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPalets.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPalets.MainView = Me.GridViewpalets
        Me.GridPalets.Name = "GridPalets"
        Me.GridPalets.Size = New System.Drawing.Size(1280, 198)
        Me.GridPalets.TabIndex = 13
        Me.GridPalets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewpalets})
        '
        'GridViewpalets
        '
        Me.GridViewpalets.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewpalets.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewpalets.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewpalets.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewpalets.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewpalets.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewpalets.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewpalets.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewpalets.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewpalets.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewpalets.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewpalets.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewpalets.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewpalets.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewpalets.Appearance.Row.Options.UseFont = True
        Me.GridViewpalets.Appearance.Row.Options.UseForeColor = True
        Me.GridViewpalets.GridControl = Me.GridPalets
        Me.GridViewpalets.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewpalets.Name = "GridViewpalets"
        Me.GridViewpalets.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewpalets.OptionsView.ShowGroupPanel = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1280, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PALETS YA GENERADOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnlGastosPorPalets)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 225)
        Me.Panel3.TabIndex = 6
        '
        'pnlGastosPorPalets
        '
        Me.pnlGastosPorPalets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGastosPorPalets.Controls.Add(Me.GridNuevosPalets)
        Me.pnlGastosPorPalets.Controls.Add(Me.Label1)
        Me.pnlGastosPorPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGastosPorPalets.Location = New System.Drawing.Point(0, 0)
        Me.pnlGastosPorPalets.Name = "pnlGastosPorPalets"
        Me.pnlGastosPorPalets.Size = New System.Drawing.Size(1284, 225)
        Me.pnlGastosPorPalets.TabIndex = 2
        '
        'GridNuevosPalets
        '
        Me.GridNuevosPalets.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridNuevosPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNuevosPalets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridNuevosPalets.Location = New System.Drawing.Point(0, 26)
        Me.GridNuevosPalets.LookAndFeel.SkinName = "Black"
        Me.GridNuevosPalets.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridNuevosPalets.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridNuevosPalets.MainView = Me.GridViewNuevosPalets
        Me.GridNuevosPalets.Name = "GridNuevosPalets"
        Me.GridNuevosPalets.Size = New System.Drawing.Size(1280, 195)
        Me.GridNuevosPalets.TabIndex = 12
        Me.GridNuevosPalets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewNuevosPalets})
        '
        'GridViewNuevosPalets
        '
        Me.GridViewNuevosPalets.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewNuevosPalets.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewNuevosPalets.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewNuevosPalets.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewNuevosPalets.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewNuevosPalets.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewNuevosPalets.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewNuevosPalets.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewNuevosPalets.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewNuevosPalets.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewNuevosPalets.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewNuevosPalets.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewNuevosPalets.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewNuevosPalets.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewNuevosPalets.Appearance.Row.Options.UseFont = True
        Me.GridViewNuevosPalets.Appearance.Row.Options.UseForeColor = True
        Me.GridViewNuevosPalets.GridControl = Me.GridNuevosPalets
        Me.GridViewNuevosPalets.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewNuevosPalets.Name = "GridViewNuevosPalets"
        Me.GridViewNuevosPalets.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewNuevosPalets.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1280, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVOS PALETS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCrearPalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCrearPalets"
        Me.Text = "Crear palets desde entradas directas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlLineasCostes.ResumeLayout(False)
        CType(Me.GridPalets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewpalets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlGastosPorPalets.ResumeLayout(False)
        CType(Me.GridNuevosPalets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewNuevosPalets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents BImprimir As NetAgro.ClButton
    Protected WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlLineasCostes As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlGastosPorPalets As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents GridNuevosPalets As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewNuevosPalets As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridPalets As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewpalets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents BConsultar As NetAgro.ClButton
    Protected WithEvents BtGenerarPalets As NetAgro.ClButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtImprimirTickets As NetAgro.ClButton
End Class
