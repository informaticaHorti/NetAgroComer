<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleMuestreoPartida
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
        Me.PanelClave = New System.Windows.Forms.Panel()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.lbFechaEntrada = New NetAgro.Lb(Me.components)
        Me.LbFechaConfeccion = New NetAgro.Lb(Me.components)
        Me.LbFechaMuestreo = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelClave.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelClave
        '
        Me.PanelClave.BackColor = System.Drawing.Color.Azure
        Me.PanelClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClave.Controls.Add(Me.Grid)
        Me.PanelClave.Controls.Add(Me.LbFechaMuestreo)
        Me.PanelClave.Controls.Add(Me.LbFechaConfeccion)
        Me.PanelClave.Controls.Add(Me.lbFechaEntrada)
        Me.PanelClave.Controls.Add(Me.Lb3)
        Me.PanelClave.Controls.Add(Me.Lb2)
        Me.PanelClave.Controls.Add(Me.Label1)
        Me.PanelClave.Controls.Add(Me.Lb1)
        Me.PanelClave.Controls.Add(Me.btSalir)
        Me.PanelClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelClave.Location = New System.Drawing.Point(0, 0)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(421, 540)
        Me.PanelClave.TabIndex = 118
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalir.Location = New System.Drawing.Point(347, 507)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(63, 25)
        Me.btSalir.TabIndex = 167
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 33)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "DETALLE MUESTREO PARTIDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Black
        Me.Lb1.Location = New System.Drawing.Point(25, 58)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(172, 23)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Fecha Entrada:"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Black
        Me.Lb2.Location = New System.Drawing.Point(25, 96)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(206, 23)
        Me.Lb2.TabIndex = 169
        Me.Lb2.Text = "Fecha Confección:"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Black
        Me.Lb3.Location = New System.Drawing.Point(25, 133)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(188, 23)
        Me.Lb3.TabIndex = 170
        Me.Lb3.Text = "Fecha Muestreo:"
        '
        'lbFechaEntrada
        '
        Me.lbFechaEntrada.AutoSize = True
        Me.lbFechaEntrada.CL_ControlAsociado = Nothing
        Me.lbFechaEntrada.CL_ValorFijo = True
        Me.lbFechaEntrada.ClForm = Nothing
        Me.lbFechaEntrada.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaEntrada.ForeColor = System.Drawing.Color.Black
        Me.lbFechaEntrada.Location = New System.Drawing.Point(244, 58)
        Me.lbFechaEntrada.Name = "lbFechaEntrada"
        Me.lbFechaEntrada.Size = New System.Drawing.Size(148, 23)
        Me.lbFechaEntrada.TabIndex = 171
        Me.lbFechaEntrada.Text = "01/01/1900"
        '
        'LbFechaConfeccion
        '
        Me.LbFechaConfeccion.AutoSize = True
        Me.LbFechaConfeccion.CL_ControlAsociado = Nothing
        Me.LbFechaConfeccion.CL_ValorFijo = True
        Me.LbFechaConfeccion.ClForm = Nothing
        Me.LbFechaConfeccion.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaConfeccion.ForeColor = System.Drawing.Color.Black
        Me.LbFechaConfeccion.Location = New System.Drawing.Point(244, 96)
        Me.LbFechaConfeccion.Name = "LbFechaConfeccion"
        Me.LbFechaConfeccion.Size = New System.Drawing.Size(148, 23)
        Me.LbFechaConfeccion.TabIndex = 172
        Me.LbFechaConfeccion.Text = "01/01/1900"
        '
        'LbFechaMuestreo
        '
        Me.LbFechaMuestreo.AutoSize = True
        Me.LbFechaMuestreo.CL_ControlAsociado = Nothing
        Me.LbFechaMuestreo.CL_ValorFijo = True
        Me.LbFechaMuestreo.ClForm = Nothing
        Me.LbFechaMuestreo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaMuestreo.ForeColor = System.Drawing.Color.Black
        Me.LbFechaMuestreo.Location = New System.Drawing.Point(244, 133)
        Me.LbFechaMuestreo.Name = "LbFechaMuestreo"
        Me.LbFechaMuestreo.Size = New System.Drawing.Size(148, 23)
        Me.LbFechaMuestreo.TabIndex = 173
        Me.LbFechaMuestreo.Text = "01/01/1900"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(6, 202)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(408, 299)
        Me.Grid.TabIndex = 174
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
        'FrmDetalleMuestreoPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 540)
        Me.Controls.Add(Me.PanelClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDetalleMuestreoPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle muestreo partida"
        Me.PanelClave.ResumeLayout(False)
        Me.PanelClave.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelClave As System.Windows.Forms.Panel
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbFechaMuestreo As NetAgro.Lb
    Friend WithEvents LbFechaConfeccion As NetAgro.Lb
    Friend WithEvents lbFechaEntrada As NetAgro.Lb
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
