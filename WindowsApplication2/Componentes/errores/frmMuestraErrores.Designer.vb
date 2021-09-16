Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestraErrores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAbortar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MemoEdit1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 331)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Green
        Me.Label1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Label1.Appearance.BorderColor = System.Drawing.Color.Red
        Me.Label1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Label1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(500, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 71)
        Me.Label1.TabIndex = 7
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 71)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.MemoEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(434, 260)
        Me.MemoEdit1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtAbortar)
        Me.Panel2.Controls.Add(Me.txtIgnorar)
        Me.Panel2.Controls.Add(Me.SimpleButton4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 31)
        Me.Panel2.TabIndex = 8
        '
        'txtAbortar
        '
        Me.txtAbortar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtAbortar.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtAbortar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.txtAbortar.Appearance.Options.UseBackColor = True
        Me.txtAbortar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAbortar.Location = New System.Drawing.Point(258, 3)
        Me.txtAbortar.Name = "txtAbortar"
        Me.txtAbortar.Size = New System.Drawing.Size(84, 25)
        Me.txtAbortar.TabIndex = 3
        Me.txtAbortar.Text = "Abortar"
        Me.txtAbortar.ToolTip = "Salir de la aplicación"
        '
        'txtIgnorar
        '
        Me.txtIgnorar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txtIgnorar.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtIgnorar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.txtIgnorar.Appearance.Options.UseBackColor = True
        Me.txtIgnorar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtIgnorar.Location = New System.Drawing.Point(348, 3)
        Me.txtIgnorar.Name = "txtIgnorar"
        Me.txtIgnorar.Size = New System.Drawing.Size(86, 25)
        Me.txtIgnorar.TabIndex = 2
        Me.txtIgnorar.Text = "Ignorar"
        Me.txtIgnorar.ToolTip = "Continua pasando por alto el error"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SimpleButton4.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton4.Image = Global.NetAgro.My.Resources.Resources.Action_button_info_16x16_32
        Me.SimpleButton4.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(24, 25)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.ToolTip = "Información detallada del error"
        '
        'frmMuestraErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 331)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMuestraErrores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de errores"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAbortar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
End Class
