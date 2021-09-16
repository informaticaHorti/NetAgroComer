<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmarEmail
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
        Me.PanelAcciones = New System.Windows.Forms.Panel()
        Me.BEnviar = New NetAgro.ClButton()
        Me.BCancelar = New NetAgro.ClButton()
        Me.TxEmail = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PanelAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAcciones
        '
        Me.PanelAcciones.Controls.Add(Me.BEnviar)
        Me.PanelAcciones.Controls.Add(Me.BCancelar)
        Me.PanelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAcciones.Location = New System.Drawing.Point(0, 61)
        Me.PanelAcciones.Name = "PanelAcciones"
        Me.PanelAcciones.Size = New System.Drawing.Size(690, 34)
        Me.PanelAcciones.TabIndex = 4
        '
        'BEnviar
        '
        Me.BEnviar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BEnviar.Image = Global.NetAgro.My.Resources.Resources.App_xf_mail_16x16_321
        Me.BEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BEnviar.Location = New System.Drawing.Point(540, 0)
        Me.BEnviar.Name = "BEnviar"
        Me.BEnviar.Orden = 0
        Me.BEnviar.PedirClave = True
        Me.BEnviar.Size = New System.Drawing.Size(75, 34)
        Me.BEnviar.TabIndex = 102
        Me.BEnviar.Text = "Enviar"
        Me.BEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BEnviar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BCancelar.Location = New System.Drawing.Point(615, 0)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Orden = 0
        Me.BCancelar.PedirClave = True
        Me.BCancelar.Size = New System.Drawing.Size(75, 34)
        Me.BCancelar.TabIndex = 100
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'TxEmail
        '
        Me.TxEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxEmail.Autonumerico = False
        Me.TxEmail.Buscando = False
        Me.TxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmail.ClForm = Nothing
        Me.TxEmail.ClParam = Nothing
        Me.TxEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmail.GridLin = Nothing
        Me.TxEmail.HaCambiado = False
        Me.TxEmail.lbbusca = Nothing
        Me.TxEmail.Location = New System.Drawing.Point(168, 18)
        Me.TxEmail.MiError = False
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.Orden = 0
        Me.TxEmail.SaltoAlfinal = False
        Me.TxEmail.Siguiente = 0
        Me.TxEmail.Size = New System.Drawing.Size(495, 22)
        Me.TxEmail.TabIndex = 53
        Me.TxEmail.TeclaRepetida = False
        Me.TxEmail.TxDatoFinalSemana = Nothing
        Me.TxEmail.TxDatoInicioSemana = Nothing
        Me.TxEmail.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(22, 21)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(140, 16)
        Me.Lb1.TabIndex = 52
        Me.Lb1.Text = "Email destinatario"
        '
        'FrmConfirmarEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 95)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.PanelAcciones)
        Me.Name = "FrmConfirmarEmail"
        Me.Text = "Confirmar dirección de correo electrónico de destino"
        Me.PanelAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelAcciones As System.Windows.Forms.Panel
    Protected WithEvents BEnviar As NetAgro.ClButton
    Protected WithEvents BCancelar As NetAgro.ClButton
    Friend WithEvents TxEmail As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
End Class
