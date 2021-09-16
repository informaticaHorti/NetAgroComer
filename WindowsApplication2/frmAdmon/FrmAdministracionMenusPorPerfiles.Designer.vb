<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministracionMenusPorPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministracionMenusPorPerfiles))
        Me.Partidas = New System.Windows.Forms.GroupBox()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.CbFormularios = New NetAgro.CbBox(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.Partidas.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Partidas
        '
        Me.Partidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Partidas.Controls.Add(Me.BtSelTodos)
        Me.Partidas.Controls.Add(Me.BtSelNinguno)
        Me.Partidas.Controls.Add(Me.Grid)
        Me.Partidas.Location = New System.Drawing.Point(12, 48)
        Me.Partidas.Name = "Partidas"
        Me.Partidas.Size = New System.Drawing.Size(617, 448)
        Me.Partidas.TabIndex = 0
        Me.Partidas.TabStop = False
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(3, 43)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(611, 399)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        '
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(12, 20)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(87, 16)
        Me.Lb_1.TabIndex = 91
        Me.Lb_1.Text = "Formulario"
        '
        'CbFormularios
        '
        Me.CbFormularios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFormularios.Campobd = Nothing
        Me.CbFormularios.ClForm = Nothing
        Me.CbFormularios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFormularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFormularios.FormattingEnabled = True
        Me.CbFormularios.GridLin = Nothing
        Me.CbFormularios.Location = New System.Drawing.Point(105, 16)
        Me.CbFormularios.MiEntidad = Nothing
        Me.CbFormularios.MiError = False
        Me.CbFormularios.Name = "CbFormularios"
        Me.CbFormularios.Orden = 0
        Me.CbFormularios.SaltoAlfinal = False
        Me.CbFormularios.Size = New System.Drawing.Size(521, 24)
        Me.CbFormularios.TabIndex = 100282
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 34)
        Me.Panel1.TabIndex = 100283
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(511, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(576, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(582, 12)
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
        Me.BtSelNinguno.Location = New System.Drawing.Point(555, 12)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100293
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'FrmAdministracionMenusPorPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbFormularios)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.Partidas)
        Me.Name = "FrmAdministracionMenusPorPerfiles"
        Me.Text = "Permisos sobre elementos del menú (por perfiles)"
        Me.Partidas.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Partidas As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents CbFormularios As NetAgro.CbBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
End Class
