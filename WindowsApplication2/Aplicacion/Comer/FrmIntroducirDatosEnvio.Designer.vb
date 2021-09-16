<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirDatosEnvio
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
        Me.LbTitulo1 = New System.Windows.Forms.Label()
        Me.LbDestino = New System.Windows.Forms.Label()
        Me.TxDestino = New System.Windows.Forms.TextBox()
        Me.LbAsunto = New System.Windows.Forms.Label()
        Me.TxAsunto = New System.Windows.Forms.TextBox()
        Me.BtEnviar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.LbExplicacion = New System.Windows.Forms.Label()
        Me.LbTitulo2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbTitulo1
        '
        Me.LbTitulo1.AutoSize = True
        Me.LbTitulo1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbTitulo1.ForeColor = System.Drawing.Color.Teal
        Me.LbTitulo1.Location = New System.Drawing.Point(12, 9)
        Me.LbTitulo1.Name = "LbTitulo1"
        Me.LbTitulo1.Size = New System.Drawing.Size(294, 16)
        Me.LbTitulo1.TabIndex = 0
        Me.LbTitulo1.Text = "No se encuentran los datos de destino. "
        '
        'LbDestino
        '
        Me.LbDestino.AutoSize = True
        Me.LbDestino.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbDestino.ForeColor = System.Drawing.Color.Teal
        Me.LbDestino.Location = New System.Drawing.Point(12, 65)
        Me.LbDestino.Name = "LbDestino"
        Me.LbDestino.Size = New System.Drawing.Size(63, 16)
        Me.LbDestino.TabIndex = 1
        Me.LbDestino.Text = "Destino"
        '
        'TxDestino
        '
        Me.TxDestino.Location = New System.Drawing.Point(81, 64)
        Me.TxDestino.Name = "TxDestino"
        Me.TxDestino.Size = New System.Drawing.Size(337, 20)
        Me.TxDestino.TabIndex = 2
        '
        'LbAsunto
        '
        Me.LbAsunto.AutoSize = True
        Me.LbAsunto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbAsunto.ForeColor = System.Drawing.Color.Teal
        Me.LbAsunto.Location = New System.Drawing.Point(12, 93)
        Me.LbAsunto.Name = "LbAsunto"
        Me.LbAsunto.Size = New System.Drawing.Size(59, 16)
        Me.LbAsunto.TabIndex = 3
        Me.LbAsunto.Text = "Asunto"
        '
        'TxAsunto
        '
        Me.TxAsunto.Location = New System.Drawing.Point(81, 92)
        Me.TxAsunto.Name = "TxAsunto"
        Me.TxAsunto.Size = New System.Drawing.Size(337, 20)
        Me.TxAsunto.TabIndex = 4
        '
        'BtEnviar
        '
        Me.BtEnviar.Location = New System.Drawing.Point(262, 118)
        Me.BtEnviar.Name = "BtEnviar"
        Me.BtEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtEnviar.TabIndex = 5
        Me.BtEnviar.Text = "Enviar"
        Me.BtEnviar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(343, 118)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtCancelar.TabIndex = 6
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'LbExplicacion
        '
        Me.LbExplicacion.AutoSize = True
        Me.LbExplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbExplicacion.Location = New System.Drawing.Point(12, 48)
        Me.LbExplicacion.Name = "LbExplicacion"
        Me.LbExplicacion.Size = New System.Drawing.Size(282, 13)
        Me.LbExplicacion.TabIndex = 7
        Me.LbExplicacion.Text = "Introduzca varias direcciones separadas por punto y coma"
        '
        'LbTitulo2
        '
        Me.LbTitulo2.AutoSize = True
        Me.LbTitulo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbTitulo2.ForeColor = System.Drawing.Color.Teal
        Me.LbTitulo2.Location = New System.Drawing.Point(12, 25)
        Me.LbTitulo2.Name = "LbTitulo2"
        Me.LbTitulo2.Size = New System.Drawing.Size(223, 16)
        Me.LbTitulo2.TabIndex = 8
        Me.LbTitulo2.Text = "Introduzcalos a continuación:"
        '
        'FrmIntroducirDatosEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 150)
        Me.Controls.Add(Me.LbTitulo2)
        Me.Controls.Add(Me.LbExplicacion)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtEnviar)
        Me.Controls.Add(Me.TxAsunto)
        Me.Controls.Add(Me.LbAsunto)
        Me.Controls.Add(Me.TxDestino)
        Me.Controls.Add(Me.LbDestino)
        Me.Controls.Add(Me.LbTitulo1)
        Me.Name = "FrmIntroducirDatosEnvio"
        Me.Text = "Faltan Datos de Envío"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbTitulo1 As System.Windows.Forms.Label
    Friend WithEvents LbDestino As System.Windows.Forms.Label
    Friend WithEvents TxDestino As System.Windows.Forms.TextBox
    Friend WithEvents LbAsunto As System.Windows.Forms.Label
    Friend WithEvents TxAsunto As System.Windows.Forms.TextBox
    Friend WithEvents BtEnviar As System.Windows.Forms.Button
    Friend WithEvents BtCancelar As System.Windows.Forms.Button
    Friend WithEvents LbExplicacion As System.Windows.Forms.Label
    Friend WithEvents LbTitulo2 As System.Windows.Forms.Label
End Class
