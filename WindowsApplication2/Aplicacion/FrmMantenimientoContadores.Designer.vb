<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoContadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoContadores))
        Me.GbFicheros = New System.Windows.Forms.GroupBox()
        Me.RbLiqAgri = New System.Windows.Forms.RadioButton()
        Me.RbFacAgri = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.BSalir = New NetAgro.ClButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxSerie = New System.Windows.Forms.TextBox()
        Me.TxUltimo = New System.Windows.Forms.TextBox()
        Me.LbUltimo = New NetAgro.Lb(Me.components)
        Me.LbSerie = New NetAgro.Lb(Me.components)
        Me.rbFacturasClientes = New System.Windows.Forms.RadioButton()
        Me.GbFicheros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbFicheros
        '
        Me.GbFicheros.Controls.Add(Me.rbFacturasClientes)
        Me.GbFicheros.Controls.Add(Me.RbLiqAgri)
        Me.GbFicheros.Controls.Add(Me.RbFacAgri)
        Me.GbFicheros.Location = New System.Drawing.Point(12, 12)
        Me.GbFicheros.Name = "GbFicheros"
        Me.GbFicheros.Size = New System.Drawing.Size(199, 217)
        Me.GbFicheros.TabIndex = 100327
        Me.GbFicheros.TabStop = False
        Me.GbFicheros.Text = "Ficheros"
        '
        'RbLiqAgri
        '
        Me.RbLiqAgri.AutoSize = True
        Me.RbLiqAgri.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbLiqAgri.ForeColor = System.Drawing.Color.Teal
        Me.RbLiqAgri.Location = New System.Drawing.Point(6, 50)
        Me.RbLiqAgri.Name = "RbLiqAgri"
        Me.RbLiqAgri.Size = New System.Drawing.Size(166, 20)
        Me.RbLiqAgri.TabIndex = 9
        Me.RbLiqAgri.TabStop = True
        Me.RbLiqAgri.Text = "Liquid. Agricultores"
        Me.RbLiqAgri.UseVisualStyleBackColor = True
        '
        'RbFacAgri
        '
        Me.RbFacAgri.AutoSize = True
        Me.RbFacAgri.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbFacAgri.ForeColor = System.Drawing.Color.Teal
        Me.RbFacAgri.Location = New System.Drawing.Point(6, 25)
        Me.RbFacAgri.Name = "RbFacAgri"
        Me.RbFacAgri.Size = New System.Drawing.Size(182, 20)
        Me.RbFacAgri.TabIndex = 8
        Me.RbFacAgri.TabStop = True
        Me.RbFacAgri.Text = "Facturas Agricultores"
        Me.RbFacAgri.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Location = New System.Drawing.Point(220, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 43)
        Me.Panel1.TabIndex = 100332
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(85, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 43)
        Me.BGuardar.TabIndex = 102
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSalir.Location = New System.Drawing.Point(150, 0)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Orden = 0
        Me.BSalir.PedirClave = True
        Me.BSalir.Size = New System.Drawing.Size(65, 43)
        Me.BSalir.TabIndex = 101
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxSerie)
        Me.Panel2.Controls.Add(Me.TxUltimo)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.LbUltimo)
        Me.Panel2.Controls.Add(Me.LbSerie)
        Me.Panel2.Controls.Add(Me.GbFicheros)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 268)
        Me.Panel2.TabIndex = 100333
        '
        'TxSerie
        '
        Me.TxSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxSerie.Location = New System.Drawing.Point(321, 31)
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Size = New System.Drawing.Size(114, 22)
        Me.TxSerie.TabIndex = 100336
        '
        'TxUltimo
        '
        Me.TxUltimo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxUltimo.Location = New System.Drawing.Point(321, 56)
        Me.TxUltimo.Name = "TxUltimo"
        Me.TxUltimo.Size = New System.Drawing.Size(114, 22)
        Me.TxUltimo.TabIndex = 100335
        '
        'LbUltimo
        '
        Me.LbUltimo.AutoSize = True
        Me.LbUltimo.CL_ControlAsociado = Nothing
        Me.LbUltimo.CL_ValorFijo = False
        Me.LbUltimo.ClForm = Nothing
        Me.LbUltimo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUltimo.ForeColor = System.Drawing.Color.Teal
        Me.LbUltimo.Location = New System.Drawing.Point(217, 59)
        Me.LbUltimo.Name = "LbUltimo"
        Me.LbUltimo.Size = New System.Drawing.Size(97, 16)
        Me.LbUltimo.TabIndex = 100334
        Me.LbUltimo.Text = "Último Núm."
        '
        'LbSerie
        '
        Me.LbSerie.AutoSize = True
        Me.LbSerie.CL_ControlAsociado = Nothing
        Me.LbSerie.CL_ValorFijo = True
        Me.LbSerie.ClForm = Nothing
        Me.LbSerie.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSerie.ForeColor = System.Drawing.Color.Teal
        Me.LbSerie.Location = New System.Drawing.Point(217, 33)
        Me.LbSerie.Name = "LbSerie"
        Me.LbSerie.Size = New System.Drawing.Size(45, 16)
        Me.LbSerie.TabIndex = 100332
        Me.LbSerie.Text = "Serie"
        '
        'rbFacturasClientes
        '
        Me.rbFacturasClientes.AutoSize = True
        Me.rbFacturasClientes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFacturasClientes.ForeColor = System.Drawing.Color.Teal
        Me.rbFacturasClientes.Location = New System.Drawing.Point(6, 75)
        Me.rbFacturasClientes.Name = "rbFacturasClientes"
        Me.rbFacturasClientes.Size = New System.Drawing.Size(153, 20)
        Me.rbFacturasClientes.TabIndex = 10
        Me.rbFacturasClientes.TabStop = True
        Me.rbFacturasClientes.Text = "Facturas Clientes"
        Me.rbFacturasClientes.UseVisualStyleBackColor = True
        '
        'FrmMantenimientoContadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 268)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmMantenimientoContadores"
        Me.Text = "Mantenimiento Contadores"
        Me.GbFicheros.ResumeLayout(False)
        Me.GbFicheros.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbFicheros As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbUltimo As NetAgro.Lb
    Friend WithEvents LbSerie As NetAgro.Lb
    Friend WithEvents BSalir As NetAgro.ClButton
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents TxUltimo As System.Windows.Forms.TextBox
    Friend WithEvents RbFacAgri As System.Windows.Forms.RadioButton
    Friend WithEvents TxSerie As System.Windows.Forms.TextBox
    Friend WithEvents RbLiqAgri As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturasClientes As System.Windows.Forms.RadioButton
End Class
