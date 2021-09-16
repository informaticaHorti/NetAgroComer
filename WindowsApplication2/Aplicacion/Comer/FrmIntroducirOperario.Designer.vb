<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirOperario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbNombreOperario = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btValidar = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.PanelClave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelClave
        '
        Me.PanelClave.BackColor = System.Drawing.Color.Azure
        Me.PanelClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClave.Controls.Add(Me.GroupBox1)
        Me.PanelClave.Controls.Add(Me.btSalir)
        Me.PanelClave.Controls.Add(Me.btCancelar)
        Me.PanelClave.Controls.Add(Me.btValidar)
        Me.PanelClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelClave.Location = New System.Drawing.Point(0, 0)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(533, 149)
        Me.PanelClave.TabIndex = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lb1)
        Me.GroupBox1.Controls.Add(Me.TxCodigo)
        Me.GroupBox1.Controls.Add(Me.LbNombreOperario)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 102)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        '
        'LbNombreOperario
        '
        Me.LbNombreOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNombreOperario.BackColor = System.Drawing.Color.PaleTurquoise
        Me.LbNombreOperario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNombreOperario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreOperario.Location = New System.Drawing.Point(9, 47)
        Me.LbNombreOperario.Name = "LbNombreOperario"
        Me.LbNombreOperario.Size = New System.Drawing.Size(489, 37)
        Me.LbNombreOperario.TabIndex = 164
        Me.LbNombreOperario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_right_16x16_32
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalir.Location = New System.Drawing.Point(448, 116)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(63, 25)
        Me.btSalir.TabIndex = 167
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(374, 116)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(72, 25)
        Me.btCancelar.TabIndex = 166
        Me.btCancelar.Text = "Borrar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btValidar
        '
        Me.btValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btValidar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.btValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btValidar.Location = New System.Drawing.Point(292, 116)
        Me.btValidar.Name = "btValidar"
        Me.btValidar.Size = New System.Drawing.Size(79, 25)
        Me.btValidar.TabIndex = 165
        Me.btValidar.Text = "Validar"
        Me.btValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btValidar.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(6, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(148, 18)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Codigo operario"
        '
        'TxCodigo
        '
        Me.TxCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(169, 14)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(329, 22)
        Me.TxCodigo.TabIndex = 163
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxCodigo.TxDatoFinalSemana = Nothing
        Me.TxCodigo.TxDatoInicioSemana = Nothing
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'FrmIntroducirOperario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 149)
        Me.Controls.Add(Me.PanelClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmIntroducirOperario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introducir operario"
        Me.PanelClave.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelClave As System.Windows.Forms.Panel
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbNombreOperario As System.Windows.Forms.Label
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btValidar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
