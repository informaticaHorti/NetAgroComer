<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDomiciliosFianzas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDomiciliosFianzas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.LbDomicilio = New NetAgro.Lb(Me.components)
        Me.GridEditable1 = New NetAgro.GridEditable()
        Me.BConsultar = New NetAgro.ClButton()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BConsultar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 533)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 34)
        Me.Panel1.TabIndex = 202
        '
        'Lb2
        '
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Black
        Me.Lb2.Location = New System.Drawing.Point(12, 40)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(75, 22)
        Me.Lb2.TabIndex = 207
        Me.Lb2.Text = "Domicilio"
        Me.Lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb1
        '
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Black
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(75, 22)
        Me.Lb1.TabIndex = 206
        Me.Lb1.Text = "Cliente"
        Me.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCliente
        '
        Me.LbCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.LbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = True
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Black
        Me.LbCliente.Location = New System.Drawing.Point(93, 13)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(527, 22)
        Me.LbCliente.TabIndex = 205
        Me.LbCliente.Text = "Cliente"
        Me.LbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbDomicilio
        '
        Me.LbDomicilio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDomicilio.BackColor = System.Drawing.Color.Gainsboro
        Me.LbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDomicilio.CL_ControlAsociado = Nothing
        Me.LbDomicilio.CL_ValorFijo = True
        Me.LbDomicilio.ClForm = Nothing
        Me.LbDomicilio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilio.ForeColor = System.Drawing.Color.Black
        Me.LbDomicilio.Location = New System.Drawing.Point(93, 40)
        Me.LbDomicilio.Name = "LbDomicilio"
        Me.LbDomicilio.Size = New System.Drawing.Size(527, 22)
        Me.LbDomicilio.TabIndex = 204
        Me.LbDomicilio.Text = "Domicilio"
        Me.LbDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridEditable1
        '
        Me.GridEditable1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEditable1.DataSource = Nothing
        Me.GridEditable1.Location = New System.Drawing.Point(12, 68)
        Me.GridEditable1.Name = "GridEditable1"
        Me.GridEditable1.Orden = -1
        Me.GridEditable1.Size = New System.Drawing.Size(646, 451)
        Me.GridEditable1.TabIndex = 203
        '
        'BConsultar
        '
        Me.BConsultar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsultar.Image = CType(resources.GetObject("BConsultar.Image"), System.Drawing.Image)
        Me.BConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsultar.Location = New System.Drawing.Point(421, 0)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Orden = 0
        Me.BConsultar.PedirClave = True
        Me.BConsultar.Size = New System.Drawing.Size(85, 34)
        Me.BConsultar.TabIndex = 101
        Me.BConsultar.Text = "Consultar (F5)"
        Me.BConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BConsultar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(506, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(94, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar (F10)"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(600, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(70, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir (F12)"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'FrmDomiciliosFianzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(670, 567)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.LbCliente)
        Me.Controls.Add(Me.LbDomicilio)
        Me.Controls.Add(Me.GridEditable1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDomiciliosFianzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de códigos de fianzas de envase por domicilio de descarga"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Protected WithEvents BConsultar As NetAgro.ClButton
    Friend WithEvents GridEditable1 As NetAgro.GridEditable
    Friend WithEvents LbDomicilio As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
End Class
