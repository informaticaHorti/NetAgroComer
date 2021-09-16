<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVactividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVactividad))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtGenerarPalets = New NetAgro.ClButton()
        Me.ChActu = New System.Windows.Forms.CheckBox()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.Panel1.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtGenerarPalets)
        Me.Panel1.Controls.Add(Me.ChActu)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 41)
        Me.Panel1.TabIndex = 5
        '
        'BtGenerarPalets
        '
        Me.BtGenerarPalets.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtGenerarPalets.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtGenerarPalets.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtGenerarPalets.Location = New System.Drawing.Point(493, 0)
        Me.BtGenerarPalets.Name = "BtGenerarPalets"
        Me.BtGenerarPalets.Orden = 0
        Me.BtGenerarPalets.PedirClave = True
        Me.BtGenerarPalets.Size = New System.Drawing.Size(172, 41)
        Me.BtGenerarPalets.TabIndex = 182
        Me.BtGenerarPalets.Text = "Quitar BLOQUEOS"
        Me.BtGenerarPalets.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGenerarPalets.UseVisualStyleBackColor = True
        '
        'ChActu
        '
        Me.ChActu.AutoSize = True
        Me.ChActu.Checked = True
        Me.ChActu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChActu.Location = New System.Drawing.Point(12, 13)
        Me.ChActu.Name = "ChActu"
        Me.ChActu.Size = New System.Drawing.Size(200, 17)
        Me.ChActu.TabIndex = 14
        Me.ChActu.Text = "Actualizar datos de forma automática"
        Me.ChActu.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(665, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(75, 41)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(712, -2)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100290
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(685, -2)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100291
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'GridView
        '
        Me.GridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.Appearance.Row.Options.UseForeColor = True
        Me.GridView.GridControl = Me.Grid
        Me.GridView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 29)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(740, 391)
        Me.Grid.TabIndex = 13
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'FrmVactividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 461)
        Me.Controls.Add(Me.BtSelTodos)
        Me.Controls.Add(Me.BtSelNinguno)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmVactividad"
        Me.Text = "Actividad usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChActu As System.Windows.Forms.CheckBox
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Protected WithEvents BtGenerarPalets As NetAgro.ClButton
    Public WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
End Class
