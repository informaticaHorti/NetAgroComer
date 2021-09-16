<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResumenConsultaExistencias
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
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.GridResumen = New DevExpress.XtraGrid.GridControl()
        Me.GridViewResumen = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlResumen.SuspendLayout()
        CType(Me.GridResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlResumen
        '
        Me.pnlResumen.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlResumen.Controls.Add(Me.ClButton1)
        Me.pnlResumen.Controls.Add(Me.GridResumen)
        Me.pnlResumen.Controls.Add(Me.Label3)
        Me.pnlResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResumen.Location = New System.Drawing.Point(0, 0)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(500, 482)
        Me.pnlResumen.TabIndex = 119
        '
        'ClButton1
        '
        Me.ClButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClButton1.Location = New System.Drawing.Point(420, 450)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(61, 23)
        Me.ClButton1.TabIndex = 17
        Me.ClButton1.Text = "Cerrar"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'GridResumen
        '
        Me.GridResumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridResumen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridResumen.Location = New System.Drawing.Point(5, 43)
        Me.GridResumen.LookAndFeel.SkinName = "Black"
        Me.GridResumen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridResumen.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridResumen.MainView = Me.GridViewResumen
        Me.GridResumen.Name = "GridResumen"
        Me.GridResumen.Size = New System.Drawing.Size(486, 403)
        Me.GridResumen.TabIndex = 16
        Me.GridResumen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewResumen})
        '
        'GridViewResumen
        '
        Me.GridViewResumen.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewResumen.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewResumen.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewResumen.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewResumen.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewResumen.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewResumen.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewResumen.Appearance.Row.Options.UseFont = True
        Me.GridViewResumen.Appearance.Row.Options.UseForeColor = True
        Me.GridViewResumen.GridControl = Me.GridResumen
        Me.GridViewResumen.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewResumen.Name = "GridViewResumen"
        Me.GridViewResumen.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "RESUMEN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmResumenConsultaExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 482)
        Me.Controls.Add(Me.pnlResumen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmResumenConsultaExistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Resumen consulta existencias"
        Me.pnlResumen.ResumeLayout(False)
        CType(Me.GridResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlResumen As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Public WithEvents GridResumen As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewResumen As DevExpress.XtraGrid.Views.Grid.GridView
End Class
