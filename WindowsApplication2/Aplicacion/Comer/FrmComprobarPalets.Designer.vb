<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobarPalets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobarPalets))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BConsultar = New System.Windows.Forms.Button()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlGastosPorPalets = New System.Windows.Forms.Panel()
        Me.GridGastosPalets = New DevExpress.XtraGrid.GridControl()
        Me.GridViewGastosPalets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGastosTotales = New System.Windows.Forms.Panel()
        Me.GridGastosTotales = New DevExpress.XtraGrid.GridControl()
        Me.GridViewGastosTotales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridLineasAlbaran = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLineasAlbaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlGastosPorPalets.SuspendLayout()
        CType(Me.GridGastosPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGastosPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGastosTotales.SuspendLayout()
        CType(Me.GridGastosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGastosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridLineasAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLineasAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BConsultar)
        Me.Panel1.Controls.Add(Me.BImprimir)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 34)
        Me.Panel1.TabIndex = 4
        '
        'BConsultar
        '
        Me.BConsultar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsultar.Image = CType(resources.GetObject("BConsultar.Image"), System.Drawing.Image)
        Me.BConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsultar.Location = New System.Drawing.Point(1059, 0)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Size = New System.Drawing.Size(75, 34)
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
        Me.BImprimir.Size = New System.Drawing.Size(75, 34)
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
        Me.Bsalir.Size = New System.Drawing.Size(75, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnlGastosPorPalets)
        Me.Panel3.Controls.Add(Me.pnlGastosTotales)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 232)
        Me.Panel3.TabIndex = 6
        '
        'pnlGastosPorPalets
        '
        Me.pnlGastosPorPalets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGastosPorPalets.Controls.Add(Me.GridGastosPalets)
        Me.pnlGastosPorPalets.Controls.Add(Me.Label1)
        Me.pnlGastosPorPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGastosPorPalets.Location = New System.Drawing.Point(0, 0)
        Me.pnlGastosPorPalets.Name = "pnlGastosPorPalets"
        Me.pnlGastosPorPalets.Size = New System.Drawing.Size(928, 232)
        Me.pnlGastosPorPalets.TabIndex = 2
        '
        'GridGastosPalets
        '
        Me.GridGastosPalets.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridGastosPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosPalets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridGastosPalets.Location = New System.Drawing.Point(0, 26)
        Me.GridGastosPalets.LookAndFeel.SkinName = "Black"
        Me.GridGastosPalets.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridGastosPalets.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridGastosPalets.MainView = Me.GridViewGastosPalets
        Me.GridGastosPalets.Name = "GridGastosPalets"
        Me.GridGastosPalets.Size = New System.Drawing.Size(924, 202)
        Me.GridGastosPalets.TabIndex = 12
        Me.GridGastosPalets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewGastosPalets})
        '
        'GridViewGastosPalets
        '
        Me.GridViewGastosPalets.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewGastosPalets.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosPalets.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewGastosPalets.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewGastosPalets.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewGastosPalets.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewGastosPalets.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewGastosPalets.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosPalets.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewGastosPalets.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewGastosPalets.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewGastosPalets.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewGastosPalets.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosPalets.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewGastosPalets.Appearance.Row.Options.UseFont = True
        Me.GridViewGastosPalets.Appearance.Row.Options.UseForeColor = True
        Me.GridViewGastosPalets.GridControl = Me.GridGastosPalets
        Me.GridViewGastosPalets.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewGastosPalets.Name = "GridViewGastosPalets"
        Me.GridViewGastosPalets.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewGastosPalets.OptionsView.ShowGroupPanel = False
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
        Me.Label1.Size = New System.Drawing.Size(924, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GASTOS POR PALETS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlGastosTotales
        '
        Me.pnlGastosTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGastosTotales.Controls.Add(Me.GridGastosTotales)
        Me.pnlGastosTotales.Controls.Add(Me.Label2)
        Me.pnlGastosTotales.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlGastosTotales.Location = New System.Drawing.Point(928, 0)
        Me.pnlGastosTotales.Name = "pnlGastosTotales"
        Me.pnlGastosTotales.Size = New System.Drawing.Size(356, 232)
        Me.pnlGastosTotales.TabIndex = 1
        '
        'GridGastosTotales
        '
        Me.GridGastosTotales.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridGastosTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosTotales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridGastosTotales.Location = New System.Drawing.Point(0, 26)
        Me.GridGastosTotales.LookAndFeel.SkinName = "Black"
        Me.GridGastosTotales.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridGastosTotales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridGastosTotales.MainView = Me.GridViewGastosTotales
        Me.GridGastosTotales.Name = "GridGastosTotales"
        Me.GridGastosTotales.Size = New System.Drawing.Size(352, 202)
        Me.GridGastosTotales.TabIndex = 13
        Me.GridGastosTotales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewGastosTotales})
        '
        'GridViewGastosTotales
        '
        Me.GridViewGastosTotales.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewGastosTotales.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosTotales.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewGastosTotales.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewGastosTotales.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewGastosTotales.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewGastosTotales.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewGastosTotales.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosTotales.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewGastosTotales.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewGastosTotales.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewGastosTotales.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewGastosTotales.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewGastosTotales.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewGastosTotales.Appearance.Row.Options.UseFont = True
        Me.GridViewGastosTotales.Appearance.Row.Options.UseForeColor = True
        Me.GridViewGastosTotales.GridControl = Me.GridGastosTotales
        Me.GridViewGastosTotales.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewGastosTotales.Name = "GridViewGastosTotales"
        Me.GridViewGastosTotales.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewGastosTotales.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GASTOS TOTALES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridLineasAlbaran)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 228)
        Me.Panel2.TabIndex = 5
        '
        'GridLineasAlbaran
        '
        Me.GridLineasAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridLineasAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLineasAlbaran.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLineasAlbaran.Location = New System.Drawing.Point(0, 26)
        Me.GridLineasAlbaran.LookAndFeel.SkinName = "Black"
        Me.GridLineasAlbaran.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridLineasAlbaran.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridLineasAlbaran.MainView = Me.GridViewLineasAlbaran
        Me.GridLineasAlbaran.Name = "GridLineasAlbaran"
        Me.GridLineasAlbaran.Size = New System.Drawing.Size(1284, 202)
        Me.GridLineasAlbaran.TabIndex = 16
        Me.GridLineasAlbaran.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLineasAlbaran})
        '
        'GridViewLineasAlbaran
        '
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewLineasAlbaran.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewLineasAlbaran.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewLineasAlbaran.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineasAlbaran.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewLineasAlbaran.Appearance.Row.Options.UseFont = True
        Me.GridViewLineasAlbaran.Appearance.Row.Options.UseForeColor = True
        Me.GridViewLineasAlbaran.GridControl = Me.GridLineasAlbaran
        Me.GridViewLineasAlbaran.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewLineasAlbaran.Name = "GridViewLineasAlbaran"
        Me.GridViewLineasAlbaran.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewLineasAlbaran.OptionsView.ShowGroupPanel = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1284, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "LINEAS ALBARAN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmComprobarPalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmComprobarPalets"
        Me.Text = "Comprobar datos palets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlGastosPorPalets.ResumeLayout(False)
        CType(Me.GridGastosPalets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGastosPalets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGastosTotales.ResumeLayout(False)
        CType(Me.GridGastosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGastosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridLineasAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLineasAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents BImprimir As System.Windows.Forms.Button
    Protected WithEvents Bsalir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlGastosPorPalets As System.Windows.Forms.Panel
    Friend WithEvents pnlGastosTotales As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents GridGastosPalets As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewGastosPalets As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridGastosTotales As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewGastosTotales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents BConsultar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents GridLineasAlbaran As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewLineasAlbaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
