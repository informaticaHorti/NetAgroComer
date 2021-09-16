<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensaKil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMensaKil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbk1 = New System.Windows.Forms.Label()
        Me.LbKb1 = New System.Windows.Forms.Label()
        Me.LbKb2 = New System.Windows.Forms.Label()
        Me.Lbk2 = New System.Windows.Forms.Label()
        Me.LbDif2 = New System.Windows.Forms.Label()
        Me.Lbdif1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kilos aproximados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kilos báscula"
        '
        'Lbk1
        '
        Me.Lbk1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbk1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbk1.Location = New System.Drawing.Point(164, 41)
        Me.Lbk1.Name = "Lbk1"
        Me.Lbk1.Size = New System.Drawing.Size(104, 23)
        Me.Lbk1.TabIndex = 2
        Me.Lbk1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKb1
        '
        Me.LbKb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKb1.Location = New System.Drawing.Point(289, 41)
        Me.LbKb1.Name = "LbKb1"
        Me.LbKb1.Size = New System.Drawing.Size(88, 23)
        Me.LbKb1.TabIndex = 3
        Me.LbKb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKb2
        '
        Me.LbKb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKb2.Location = New System.Drawing.Point(289, 67)
        Me.LbKb2.Name = "LbKb2"
        Me.LbKb2.Size = New System.Drawing.Size(88, 23)
        Me.LbKb2.TabIndex = 5
        Me.LbKb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbk2
        '
        Me.Lbk2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbk2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbk2.Location = New System.Drawing.Point(164, 67)
        Me.Lbk2.Name = "Lbk2"
        Me.Lbk2.Size = New System.Drawing.Size(104, 23)
        Me.Lbk2.TabIndex = 4
        Me.Lbk2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbDif2
        '
        Me.LbDif2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbDif2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDif2.Location = New System.Drawing.Point(289, 108)
        Me.LbDif2.Name = "LbDif2"
        Me.LbDif2.Size = New System.Drawing.Size(88, 23)
        Me.LbDif2.TabIndex = 8
        Me.LbDif2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbdif1
        '
        Me.Lbdif1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbdif1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbdif1.Location = New System.Drawing.Point(164, 108)
        Me.Lbdif1.Name = "Lbdif1"
        Me.Lbdif1.Size = New System.Drawing.Size(104, 23)
        Me.Lbdif1.TabIndex = 7
        Me.Lbdif1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Diferencia"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(283, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 58)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Bultos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kilos x Bulto"
        '
        'FrmMensaKil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 228)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbDif2)
        Me.Controls.Add(Me.Lbdif1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbKb2)
        Me.Controls.Add(Me.Lbk2)
        Me.Controls.Add(Me.LbKb1)
        Me.Controls.Add(Me.Lbk1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMensaKil"
        Me.Text = "Alerta kilos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbk1 As System.Windows.Forms.Label
    Friend WithEvents LbKb1 As System.Windows.Forms.Label
    Friend WithEvents LbKb2 As System.Windows.Forms.Label
    Friend WithEvents Lbk2 As System.Windows.Forms.Label
    Friend WithEvents LbDif2 As System.Windows.Forms.Label
    Friend WithEvents Lbdif1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
