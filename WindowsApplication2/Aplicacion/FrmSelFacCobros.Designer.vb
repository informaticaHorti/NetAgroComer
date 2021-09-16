<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelFacCobros
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbNif = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.LbIdCliente = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbTotalSeleccionado = New NetAgro.Lb(Me.components)
        Me.Lb48 = New NetAgro.Lb(Me.components)
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btSeleccionar = New System.Windows.Forms.Button()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LbNif)
        Me.Panel1.Controls.Add(Me.Lb3)
        Me.Panel1.Controls.Add(Me.LbNombre)
        Me.Panel1.Controls.Add(Me.LbIdCliente)
        Me.Panel1.Controls.Add(Me.Lb4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 42)
        Me.Panel1.TabIndex = 110
        '
        'LbNif
        '
        Me.LbNif.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbNif.CL_ControlAsociado = Nothing
        Me.LbNif.CL_ValorFijo = True
        Me.LbNif.ClForm = Nothing
        Me.LbNif.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNif.Location = New System.Drawing.Point(664, 10)
        Me.LbNif.Name = "LbNif"
        Me.LbNif.Size = New System.Drawing.Size(114, 21)
        Me.LbNif.TabIndex = 114
        Me.LbNif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(625, 12)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(33, 16)
        Me.Lb3.TabIndex = 113
        Me.Lb3.Text = "NIF"
        '
        'LbNombre
        '
        Me.LbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = True
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombre.Location = New System.Drawing.Point(164, 10)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(422, 21)
        Me.LbNombre.TabIndex = 112
        Me.LbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbIdCliente
        '
        Me.LbIdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbIdCliente.CL_ControlAsociado = Nothing
        Me.LbIdCliente.CL_ValorFijo = True
        Me.LbIdCliente.ClForm = Nothing
        Me.LbIdCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdCliente.Location = New System.Drawing.Point(94, 10)
        Me.LbIdCliente.Name = "LbIdCliente"
        Me.LbIdCliente.Size = New System.Drawing.Size(64, 21)
        Me.LbIdCliente.TabIndex = 111
        Me.LbIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(12, 12)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(59, 16)
        Me.Lb4.TabIndex = 110
        Me.Lb4.Text = "Cliente"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LbTotalSeleccionado)
        Me.Panel2.Controls.Add(Me.Lb48)
        Me.Panel2.Controls.Add(Me.btSelNinguno)
        Me.Panel2.Controls.Add(Me.btSelTodos)
        Me.Panel2.Controls.Add(Me.btSalir)
        Me.Panel2.Controls.Add(Me.btSeleccionar)
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 462)
        Me.Panel2.TabIndex = 111
        '
        'LbTotalSeleccionado
        '
        Me.LbTotalSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTotalSeleccionado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LbTotalSeleccionado.CL_ControlAsociado = Nothing
        Me.LbTotalSeleccionado.CL_ValorFijo = False
        Me.LbTotalSeleccionado.ClForm = Nothing
        Me.LbTotalSeleccionado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalSeleccionado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTotalSeleccionado.Location = New System.Drawing.Point(667, 430)
        Me.LbTotalSeleccionado.Name = "LbTotalSeleccionado"
        Me.LbTotalSeleccionado.Size = New System.Drawing.Size(156, 21)
        Me.LbTotalSeleccionado.TabIndex = 100282
        Me.LbTotalSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb48
        '
        Me.Lb48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb48.AutoSize = True
        Me.Lb48.CL_ControlAsociado = Nothing
        Me.Lb48.CL_ValorFijo = True
        Me.Lb48.ClForm = Nothing
        Me.Lb48.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb48.ForeColor = System.Drawing.Color.Teal
        Me.Lb48.Location = New System.Drawing.Point(518, 432)
        Me.Lb48.Name = "Lb48"
        Me.Lb48.Size = New System.Drawing.Size(143, 16)
        Me.Lb48.TabIndex = 100281
        Me.Lb48.Text = "Total seleccionado"
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(945, 0)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 122
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(972, 0)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 121
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Image = Global.NetAgro.My.Resources.Resources.Salir16
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSalir.Location = New System.Drawing.Point(924, 422)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 37)
        Me.btSalir.TabIndex = 120
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btSeleccionar
        '
        Me.btSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSeleccionar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.btSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSeleccionar.Location = New System.Drawing.Point(849, 422)
        Me.btSeleccionar.Name = "btSeleccionar"
        Me.btSeleccionar.Size = New System.Drawing.Size(75, 37)
        Me.btSeleccionar.TabIndex = 119
        Me.btSeleccionar.Text = "Seleccionar"
        Me.btSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSeleccionar.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(0, 26)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1006, 390)
        Me.Grid.TabIndex = 118
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.Appearance.Row.Options.UseForeColor = True
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        '
        'FrmSelFacCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSelFacCobros"
        Me.Text = "Seleccionar facturas emitidas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LbNif As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents LbIdCliente As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btSelNinguno As System.Windows.Forms.Button
    Friend WithEvents btSelTodos As System.Windows.Forms.Button
    Friend WithEvents LbTotalSeleccionado As NetAgro.Lb
    Friend WithEvents Lb48 As NetAgro.Lb
End Class
