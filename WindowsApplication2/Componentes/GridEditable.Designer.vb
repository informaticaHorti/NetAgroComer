<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridEditable
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
        Me.pnlFondo = New System.Windows.Forms.Panel()
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlDerecha = New System.Windows.Forms.Panel()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.ToolTipGridEditable = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlFondo.SuspendLayout()
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDerecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFondo
        '
        Me.pnlFondo.Controls.Add(Me.pnlIzquierda)
        Me.pnlFondo.Controls.Add(Me.pnlDerecha)
        Me.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFondo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFondo.Name = "pnlFondo"
        Me.pnlFondo.Size = New System.Drawing.Size(507, 219)
        Me.pnlFondo.TabIndex = 0
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.Controls.Add(Me.Grid)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(471, 219)
        Me.pnlIzquierda.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(471, 219)
        Me.Grid.TabIndex = 11
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue
        Me.GridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView.Appearance.FocusedRow.Options.UseForeColor = True
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
        'pnlDerecha
        '
        Me.pnlDerecha.BackColor = System.Drawing.Color.LightBlue
        Me.pnlDerecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDerecha.Controls.Add(Me.BtCancelar)
        Me.pnlDerecha.Controls.Add(Me.BtGuardar)
        Me.pnlDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDerecha.Location = New System.Drawing.Point(471, 0)
        Me.pnlDerecha.Name = "pnlDerecha"
        Me.pnlDerecha.Size = New System.Drawing.Size(36, 219)
        Me.pnlDerecha.TabIndex = 0
        '
        'BtCancelar
        '
        Me.BtCancelar.Enabled = False
        Me.BtCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_24x24_32
        Me.BtCancelar.Location = New System.Drawing.Point(0, 32)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(32, 32)
        Me.BtCancelar.TabIndex = 5
        '
        'BtGuardar
        '
        Me.BtGuardar.Enabled = False
        Me.BtGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtGuardar.Image = Global.NetAgro.My.Resources.Resources.Device_zip_24x24_32
        Me.BtGuardar.Location = New System.Drawing.Point(0, 0)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(32, 32)
        Me.BtGuardar.TabIndex = 4
        '
        'GridEditable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlFondo)
        Me.Name = "GridEditable"
        Me.Size = New System.Drawing.Size(507, 219)
        Me.pnlFondo.ResumeLayout(False)
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDerecha.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtCancelar As System.Windows.Forms.Button
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    Public WithEvents pnlDerecha As System.Windows.Forms.Panel
    Public WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Public WithEvents pnlFondo As System.Windows.Forms.Panel
    Friend WithEvents ToolTipGridEditable As System.Windows.Forms.ToolTip

End Class
