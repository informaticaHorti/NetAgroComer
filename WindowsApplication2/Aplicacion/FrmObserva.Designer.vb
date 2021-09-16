<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmObserva
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
        Me.TxDato = New System.Windows.Forms.TextBox()
        Me.BotonGuardar = New NetAgro.ClButton()
        Me.BotonSalir = New NetAgro.ClButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BotonGuardar)
        Me.Panel1.Controls.Add(Me.BotonSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 44)
        Me.Panel1.TabIndex = 0
        '
        'TxDato
        '
        Me.TxDato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxDato.Location = New System.Drawing.Point(0, 0)
        Me.TxDato.Multiline = True
        Me.TxDato.Name = "TxDato"
        Me.TxDato.Size = New System.Drawing.Size(706, 211)
        Me.TxDato.TabIndex = 1
        '
        'BotonGuardar
        '
        Me.BotonGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BotonGuardar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.BotonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BotonGuardar.Location = New System.Drawing.Point(0, 0)
        Me.BotonGuardar.Name = "BotonGuardar"
        Me.BotonGuardar.Orden = 0
        Me.BotonGuardar.PedirClave = True
        Me.BotonGuardar.Size = New System.Drawing.Size(68, 44)
        Me.BotonGuardar.TabIndex = 81
        Me.BotonGuardar.Text = "Guardar"
        Me.BotonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BotonGuardar.UseVisualStyleBackColor = True
        '
        'BotonSalir
        '
        Me.BotonSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BotonSalir.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_24x24_32
        Me.BotonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BotonSalir.Location = New System.Drawing.Point(638, 0)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Orden = 0
        Me.BotonSalir.PedirClave = True
        Me.BotonSalir.Size = New System.Drawing.Size(68, 44)
        Me.BotonSalir.TabIndex = 80
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BotonSalir.UseVisualStyleBackColor = True
        '
        'FrmObserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 255)
        Me.Controls.Add(Me.TxDato)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmObserva"
        Me.Text = "Observaciones"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxDato As System.Windows.Forms.TextBox
    Friend WithEvents BotonGuardar As NetAgro.ClButton
    Friend WithEvents BotonSalir As NetAgro.ClButton
End Class
