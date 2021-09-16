<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClaveBloqueoImportaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClaveBloqueoImportaciones))
        Me.PanelClave = New System.Windows.Forms.Panel()
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PanelClave.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelClave
        '
        Me.PanelClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClave.Controls.Add(Me.TxDato1)
        Me.PanelClave.Controls.Add(Me.Lb17)
        Me.PanelClave.Controls.Add(Me.Button2)
        Me.PanelClave.Controls.Add(Me.Lb1)
        Me.PanelClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelClave.Location = New System.Drawing.Point(0, 0)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(200, 63)
        Me.PanelClave.TabIndex = 118
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(63, 8)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(121, 22)
        Me.TxDato1.TabIndex = 163
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb17
        '
        Me.Lb17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = True
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.Teal
        Me.Lb17.Location = New System.Drawing.Point(60, 32)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(125, 16)
        Me.Lb17.TabIndex = 161
        Me.Lb17.Text = "F2=Cierra panel"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(11, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 130
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(8, 11)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(49, 16)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Clave"
        '
        'FrmClaveBloqueoImportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 63)
        Me.Controls.Add(Me.PanelClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClaveBloqueoImportaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clave bloqueo importaciones"
        Me.PanelClave.ResumeLayout(False)
        Me.PanelClave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelClave As System.Windows.Forms.Panel
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb17 As NetAgro.Lb
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
End Class
