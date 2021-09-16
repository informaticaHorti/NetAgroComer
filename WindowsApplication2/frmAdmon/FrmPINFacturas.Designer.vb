<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPINFacturas
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
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelClave.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelClave
        '
        Me.PanelClave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelClave.BackColor = System.Drawing.Color.LightBlue
        Me.PanelClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClave.Controls.Add(Me.BtCancelar)
        Me.PanelClave.Controls.Add(Me.BtAceptar)
        Me.PanelClave.Controls.Add(Me.TxDato1)
        Me.PanelClave.Controls.Add(Me.Lb1)
        Me.PanelClave.Location = New System.Drawing.Point(18, 17)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(287, 42)
        Me.PanelClave.TabIndex = 118
        '
        'BtCancelar
        '
        Me.BtCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.BtCancelar.Location = New System.Drawing.Point(252, 7)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(24, 24)
        Me.BtCancelar.TabIndex = 165
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.BtAceptar.Location = New System.Drawing.Point(229, 7)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(24, 24)
        Me.BtAceptar.TabIndex = 164
        Me.BtAceptar.UseVisualStyleBackColor = True
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
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(165, 22)
        Me.TxDato1.TabIndex = 163
        Me.TxDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lb1.Location = New System.Drawing.Point(8, 11)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(49, 16)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Clave"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PanelClave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 78)
        Me.Panel1.TabIndex = 119
        '
        'FrmClaveBoton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 78)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClaveBoton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar clave a botones de formulario"
        Me.PanelClave.ResumeLayout(False)
        Me.PanelClave.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelClave As System.Windows.Forms.Panel
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents BtAceptar As System.Windows.Forms.Button
    Friend WithEvents BtCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
