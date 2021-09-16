<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPanelSeleccionaLineaTarea
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbLineaTarea = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btAceptar = New NetAgro.ClButton()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 102)
        Me.Panel2.TabIndex = 12
        '
        'CbLineaTarea
        '
        Me.CbLineaTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLineaTarea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbLineaTarea.FormattingEnabled = True
        Me.CbLineaTarea.Location = New System.Drawing.Point(12, 34)
        Me.CbLineaTarea.Name = "CbLineaTarea"
        Me.CbLineaTarea.Size = New System.Drawing.Size(296, 24)
        Me.CbLineaTarea.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbLineaTarea)
        Me.GroupBox1.Controls.Add(Me.btAceptar)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 72)
        Me.GroupBox1.TabIndex = 100300
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de linea y tarea"
        '
        'btAceptar
        '
        Me.btAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.btAceptar.Location = New System.Drawing.Point(311, 35)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Orden = 0
        Me.btAceptar.PedirClave = True
        Me.btAceptar.Size = New System.Drawing.Size(24, 23)
        Me.btAceptar.TabIndex = 100299
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'FrmPanelSeleccionaLineaTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 102)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(466, 261)
        Me.Name = "FrmPanelSeleccionaLineaTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de linea y tarea"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CbLineaTarea As System.Windows.Forms.ComboBox
    Friend WithEvents btAceptar As NetAgro.ClButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
