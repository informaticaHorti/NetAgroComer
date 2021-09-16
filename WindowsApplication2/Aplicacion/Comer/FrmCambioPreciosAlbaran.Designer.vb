<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioPreciosAlbaran
    Inherits NetAgro.FrConsulta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioPreciosAlbaran))
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.PanelGreditable = New System.Windows.Forms.Panel()
        Me.GridEditable = New NetAgro.GridEditable()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbNom_Referencia = New NetAgro.Lb(Me.components)
        Me.Lb24 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbNom_Domicilio = New NetAgro.Lb(Me.components)
        Me.LbDescarga = New NetAgro.Lb(Me.components)
        Me.LbNom_Cliente = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.LbFC = New System.Windows.Forms.Label()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.PanelGreditable.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbFC)
        Me.PanelCabecera.Controls.Add(Me.LbFecha)
        Me.PanelCabecera.Controls.Add(Me.LbAlbaran)
        Me.PanelCabecera.Controls.Add(Me.PictureBox2)
        Me.PanelCabecera.Controls.Add(Me.PictureBox1)
        Me.PanelCabecera.Controls.Add(Me.LbNom_Referencia)
        Me.PanelCabecera.Controls.Add(Me.Lb24)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.LbNom_Domicilio)
        Me.PanelCabecera.Controls.Add(Me.LbDescarga)
        Me.PanelCabecera.Controls.Add(Me.LbNom_Cliente)
        Me.PanelCabecera.Controls.Add(Me.Lb_1)
        Me.PanelCabecera.Controls.Add(Me.Lb_4)
        Me.PanelCabecera.Controls.Add(Me.Lb_2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1324, 153)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Location = New System.Drawing.Point(2, 608)
        Me.PanelConsulta.Size = New System.Drawing.Size(1284, 25)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(994, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1069, 0)
        '
        'BInforme
        '
        Me.BInforme.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.BInforme.Location = New System.Drawing.Point(1144, 0)
        Me.BInforme.Size = New System.Drawing.Size(105, 34)
        Me.BInforme.Text = "Actualizar precios"
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1249, 0)
        '
        'PlantillaConsulta1
        '
        Me.PlantillaConsulta1.Visible = False
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(919, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelEditable.Controls.Add(Me.PanelGreditable)
        Me.PanelEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditable.Location = New System.Drawing.Point(0, 153)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(1324, 415)
        Me.PanelEditable.TabIndex = 14
        '
        'PanelGreditable
        '
        Me.PanelGreditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGreditable.Controls.Add(Me.GridEditable)
        Me.PanelGreditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGreditable.Location = New System.Drawing.Point(0, 0)
        Me.PanelGreditable.Name = "PanelGreditable"
        Me.PanelGreditable.Size = New System.Drawing.Size(1324, 415)
        Me.PanelGreditable.TabIndex = 139
        '
        'GridEditable
        '
        Me.GridEditable.DataSource = Nothing
        Me.GridEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEditable.Location = New System.Drawing.Point(0, 0)
        Me.GridEditable.Name = "GridEditable"
        Me.GridEditable.NavegarSoloEditables = False
        Me.GridEditable.Orden = -1
        Me.GridEditable.Size = New System.Drawing.Size(1324, 415)
        Me.GridEditable.TabIndex = 140
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(746, 261)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 100437
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(721, 261)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100436
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbNom_Referencia
        '
        Me.LbNom_Referencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_Referencia.CL_ControlAsociado = Nothing
        Me.LbNom_Referencia.CL_ValorFijo = True
        Me.LbNom_Referencia.ClForm = Nothing
        Me.LbNom_Referencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Referencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Referencia.Location = New System.Drawing.Point(136, 108)
        Me.LbNom_Referencia.Name = "LbNom_Referencia"
        Me.LbNom_Referencia.Size = New System.Drawing.Size(164, 23)
        Me.LbNom_Referencia.TabIndex = 100433
        Me.LbNom_Referencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb24
        '
        Me.Lb24.AutoSize = True
        Me.Lb24.CL_ControlAsociado = Nothing
        Me.Lb24.CL_ValorFijo = True
        Me.Lb24.ClForm = Nothing
        Me.Lb24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb24.ForeColor = System.Drawing.Color.Teal
        Me.Lb24.Location = New System.Drawing.Point(13, 111)
        Me.Lb24.Name = "Lb24"
        Me.Lb24.Size = New System.Drawing.Size(85, 16)
        Me.Lb24.TabIndex = 100432
        Me.Lb24.Text = "Referencia"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(457, 19)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(92, 16)
        Me.Lb2.TabIndex = 100427
        Me.Lb2.Text = "Firme/Com"
        '
        'LbNom_Domicilio
        '
        Me.LbNom_Domicilio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_Domicilio.CL_ControlAsociado = Nothing
        Me.LbNom_Domicilio.CL_ValorFijo = False
        Me.LbNom_Domicilio.ClForm = Nothing
        Me.LbNom_Domicilio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Domicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Domicilio.Location = New System.Drawing.Point(136, 81)
        Me.LbNom_Domicilio.Name = "LbNom_Domicilio"
        Me.LbNom_Domicilio.Size = New System.Drawing.Size(536, 23)
        Me.LbNom_Domicilio.TabIndex = 100425
        '
        'LbDescarga
        '
        Me.LbDescarga.AutoSize = True
        Me.LbDescarga.CL_ControlAsociado = Nothing
        Me.LbDescarga.CL_ValorFijo = True
        Me.LbDescarga.ClForm = Nothing
        Me.LbDescarga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescarga.ForeColor = System.Drawing.Color.Teal
        Me.LbDescarga.Location = New System.Drawing.Point(13, 84)
        Me.LbDescarga.Name = "LbDescarga"
        Me.LbDescarga.Size = New System.Drawing.Size(114, 16)
        Me.LbDescarga.TabIndex = 100422
        Me.LbDescarga.Text = "Dom.Descarga"
        '
        'LbNom_Cliente
        '
        Me.LbNom_Cliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_Cliente.CL_ControlAsociado = Nothing
        Me.LbNom_Cliente.CL_ValorFijo = False
        Me.LbNom_Cliente.ClForm = Nothing
        Me.LbNom_Cliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Cliente.Location = New System.Drawing.Point(136, 54)
        Me.LbNom_Cliente.Name = "LbNom_Cliente"
        Me.LbNom_Cliente.Size = New System.Drawing.Size(536, 23)
        Me.LbNom_Cliente.TabIndex = 100421
        '
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = True
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(12, 19)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(64, 16)
        Me.Lb_1.TabIndex = 100420
        Me.Lb_1.Text = "Albaran"
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = True
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(13, 57)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(59, 16)
        Me.Lb_4.TabIndex = 100416
        Me.Lb_4.Text = "Cliente"
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = True
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(270, 19)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(52, 16)
        Me.Lb_2.TabIndex = 100415
        Me.Lb_2.Text = "Fecha"
        '
        'LbAlbaran
        '
        Me.LbAlbaran.BackColor = System.Drawing.Color.White
        Me.LbAlbaran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAlbaran.Location = New System.Drawing.Point(136, 16)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(101, 22)
        Me.LbAlbaran.TabIndex = 100441
        Me.LbAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.Color.White
        Me.LbFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFecha.Location = New System.Drawing.Point(328, 16)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(100, 22)
        Me.LbFecha.TabIndex = 100442
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbFC
        '
        Me.LbFC.BackColor = System.Drawing.Color.White
        Me.LbFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFC.Location = New System.Drawing.Point(555, 16)
        Me.LbFC.Name = "LbFC"
        Me.LbFC.Size = New System.Drawing.Size(24, 22)
        Me.LbFC.TabIndex = 100443
        Me.LbFC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCambioPreciosAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 602)
        Me.Controls.Add(Me.PanelEditable)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmCambioPreciosAlbaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio precios albarán"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.PanelEditable, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelGreditable.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEditable As System.Windows.Forms.Panel
    Friend WithEvents PanelGreditable As System.Windows.Forms.Panel
    Friend WithEvents GridEditable As NetAgro.GridEditable
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbNom_Referencia As NetAgro.Lb
    Friend WithEvents Lb24 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbNom_Domicilio As NetAgro.Lb
    Friend WithEvents LbDescarga As NetAgro.Lb
    Friend WithEvents LbNom_Cliente As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents LbAlbaran As System.Windows.Forms.Label
    Friend WithEvents LbFC As System.Windows.Forms.Label
    Friend WithEvents LbFecha As System.Windows.Forms.Label
End Class
