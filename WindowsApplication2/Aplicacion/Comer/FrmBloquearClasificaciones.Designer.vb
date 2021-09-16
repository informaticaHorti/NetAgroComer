<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqueoClasificaciones
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
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btQuitarBloqueo = New System.Windows.Forms.Button()
        Me.PanelClave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelClave
        '
        Me.PanelClave.BackColor = System.Drawing.Color.Azure
        Me.PanelClave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClave.Controls.Add(Me.btQuitarBloqueo)
        Me.PanelClave.Controls.Add(Me.GroupBox1)
        Me.PanelClave.Controls.Add(Me.btSalir)
        Me.PanelClave.Controls.Add(Me.btAceptar)
        Me.PanelClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelClave.Location = New System.Drawing.Point(0, 0)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(546, 97)
        Me.PanelClave.TabIndex = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Lb2)
        Me.GroupBox1.Controls.Add(Me.Lb1)
        Me.GroupBox1.Controls.Add(Me.TxFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 44)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(287, 16)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(215, 16)
        Me.Lb2.TabIndex = 164
        Me.Lb2.Text = "hacia atrás (inclusive fecha)"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(6, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(165, 16)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Bloquear desde fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(177, 13)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(104, 22)
        Me.TxFecha.TabIndex = 163
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalir.Location = New System.Drawing.Point(461, 64)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(63, 25)
        Me.btSalir.TabIndex = 167
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.btAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAceptar.Location = New System.Drawing.Point(376, 64)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(79, 25)
        Me.btAceptar.TabIndex = 165
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btQuitarBloqueo
        '
        Me.btQuitarBloqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btQuitarBloqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btQuitarBloqueo.Image = Global.NetAgro.My.Resources.Resources.decrypted
        Me.btQuitarBloqueo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btQuitarBloqueo.Location = New System.Drawing.Point(236, 64)
        Me.btQuitarBloqueo.Name = "btQuitarBloqueo"
        Me.btQuitarBloqueo.Size = New System.Drawing.Size(134, 25)
        Me.btQuitarBloqueo.TabIndex = 169
        Me.btQuitarBloqueo.Text = "Quitar bloqueo"
        Me.btQuitarBloqueo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btQuitarBloqueo.UseVisualStyleBackColor = True
        '
        'FrmBloqueoClasificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 97)
        Me.Controls.Add(Me.PanelClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBloqueoClasificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloquear clasificaciones"
        Me.PanelClave.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelClave As System.Windows.Forms.Panel
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents btQuitarBloqueo As System.Windows.Forms.Button
End Class
