<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClGrid))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BotonNuevo = New System.Windows.Forms.Button()
        Me.BotonModificar = New System.Windows.Forms.Button()
        Me.BotonAnular = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ttImprimir = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BotonNuevo)
        Me.Panel1.Controls.Add(Me.BotonModificar)
        Me.Panel1.Controls.Add(Me.BotonAnular)
        Me.Panel1.Controls.Add(Me.BotonSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(495, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 176)
        Me.Panel1.TabIndex = 0
        '
        'BotonNuevo
        '
        Me.BotonNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonNuevo.Image = CType(resources.GetObject("BotonNuevo.Image"), System.Drawing.Image)
        Me.BotonNuevo.Location = New System.Drawing.Point(0, 84)
        Me.BotonNuevo.Name = "BotonNuevo"
        Me.BotonNuevo.Size = New System.Drawing.Size(33, 28)
        Me.BotonNuevo.TabIndex = 3
        '
        'BotonModificar
        '
        Me.BotonModificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonModificar.Image = CType(resources.GetObject("BotonModificar.Image"), System.Drawing.Image)
        Me.BotonModificar.Location = New System.Drawing.Point(0, 56)
        Me.BotonModificar.Name = "BotonModificar"
        Me.BotonModificar.Size = New System.Drawing.Size(33, 28)
        Me.BotonModificar.TabIndex = 2
        '
        'BotonAnular
        '
        Me.BotonAnular.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonAnular.Image = CType(resources.GetObject("BotonAnular.Image"), System.Drawing.Image)
        Me.BotonAnular.Location = New System.Drawing.Point(0, 28)
        Me.BotonAnular.Name = "BotonAnular"
        Me.BotonAnular.Size = New System.Drawing.Size(33, 28)
        Me.BotonAnular.TabIndex = 1
        '
        'BotonSalir
        '
        Me.BotonSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
        Me.BotonSalir.Location = New System.Drawing.Point(0, 0)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(33, 28)
        Me.BotonSalir.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 176)
        Me.Panel2.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(495, 166)
        Me.Grid.TabIndex = 5
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
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 10)
        Me.Panel3.TabIndex = 4
        '
        'ClGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClGrid"
        Me.Size = New System.Drawing.Size(528, 176)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BotonNuevo As Button
    Friend WithEvents BotonModificar As Button
    Friend WithEvents BotonAnular As Button
    Friend WithEvents BotonSalir As Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ttImprimir As System.Windows.Forms.ToolTip
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView

End Class
