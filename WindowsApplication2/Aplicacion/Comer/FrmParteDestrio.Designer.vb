<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPartedestrio
    Inherits NetAgro.FrMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPartedestrio))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbnom_50 = New NetAgro.Lb(Me.components)
        Me.TxDato_50 = New NetAgro.TxDato(Me.components)
        Me.Lb_50 = New NetAgro.Lb(Me.components)
        Me.BtBusca_50 = New NetAgro.BtBusca(Me.components)
        Me.Lb_56 = New NetAgro.Lb(Me.components)
        Me.TxDato_56 = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Lb_2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato_1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(712, 81)
        Me.Panel4.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNomCentro)
        Me.Panel3.Controls.Add(Me.LbCentro)
        Me.Panel3.Controls.Add(Me.Lb29)
        Me.Panel3.Location = New System.Drawing.Point(7, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 33)
        Me.Panel3.TabIndex = 125
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.White
        Me.LbNomCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = True
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbNomCentro.Location = New System.Drawing.Point(147, 5)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(117, 21)
        Me.LbNomCentro.TabIndex = 115
        Me.LbNomCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCentro
        '
        Me.LbCentro.BackColor = System.Drawing.Color.White
        Me.LbCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = True
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(114, 5)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(28, 21)
        Me.LbCentro.TabIndex = 114
        Me.LbCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = True
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(6, 7)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(57, 16)
        Me.Lb29.TabIndex = 113
        Me.Lb29.Text = "Centro"
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.White
        Me.LbCampa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = False
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.Teal
        Me.LbCampa.Location = New System.Drawing.Point(120, 44)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(297, 46)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(56, 16)
        Me.Lb_2.TabIndex = 77
        Me.Lb_2.Text = "Fecha "
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(398, 44)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_2.TabIndex = 76
        Me.TxDato_2.TeclaRepetida = False
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato_1
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(237, 43)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 70
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(160, 44)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_1.TabIndex = 65
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 46)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(69, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Nº Parte"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbnom_50)
        Me.Panel2.Controls.Add(Me.TxDato_50)
        Me.Panel2.Controls.Add(Me.Lb_50)
        Me.Panel2.Controls.Add(Me.BtBusca_50)
        Me.Panel2.Controls.Add(Me.Lb_56)
        Me.Panel2.Controls.Add(Me.TxDato_56)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 409)
        Me.Panel2.TabIndex = 73
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(893, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(871, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lbnom_50
        '
        Me.Lbnom_50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_50.CL_ControlAsociado = Nothing
        Me.Lbnom_50.CL_ValorFijo = False
        Me.Lbnom_50.ClForm = Nothing
        Me.Lbnom_50.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_50.Location = New System.Drawing.Point(210, 11)
        Me.Lbnom_50.Name = "Lbnom_50"
        Me.Lbnom_50.Size = New System.Drawing.Size(296, 23)
        Me.Lbnom_50.TabIndex = 74
        '
        'TxDato_50
        '
        Me.TxDato_50.Autonumerico = False
        Me.TxDato_50.Buscando = False
        Me.TxDato_50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_50.ClForm = Nothing
        Me.TxDato_50.ClParam = Nothing
        Me.TxDato_50.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_50.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_50.GridLin = Nothing
        Me.TxDato_50.HaCambiado = False
        Me.TxDato_50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_50.lbbusca = Nothing
        Me.TxDato_50.Location = New System.Drawing.Point(110, 11)
        Me.TxDato_50.MiError = False
        Me.TxDato_50.Name = "TxDato_50"
        Me.TxDato_50.Orden = 0
        Me.TxDato_50.SaltoAlfinal = False
        Me.TxDato_50.Siguiente = 0
        Me.TxDato_50.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_50.TabIndex = 71
        Me.TxDato_50.TeclaRepetida = False
        '
        'Lb_50
        '
        Me.Lb_50.AutoSize = True
        Me.Lb_50.CL_ControlAsociado = Nothing
        Me.Lb_50.CL_ValorFijo = False
        Me.Lb_50.ClForm = Nothing
        Me.Lb_50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_50.ForeColor = System.Drawing.Color.Teal
        Me.Lb_50.Location = New System.Drawing.Point(2, 14)
        Me.Lb_50.Name = "Lb_50"
        Me.Lb_50.Size = New System.Drawing.Size(60, 16)
        Me.Lb_50.TabIndex = 72
        Me.Lb_50.Text = "Genero"
        '
        'BtBusca_50
        '
        Me.BtBusca_50.CL_BuscaAlb = False
        Me.BtBusca_50.CL_campocodigo = Nothing
        Me.BtBusca_50.CL_camponombre = Nothing
        Me.BtBusca_50.CL_CampoOrden = "Nombre"
        Me.BtBusca_50.CL_ch1000 = False
        Me.BtBusca_50.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_50.CL_ControlAsociado = Me.TxDato_50
        Me.BtBusca_50.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_50.CL_dfecha = Nothing
        Me.BtBusca_50.CL_Entidad = Nothing
        Me.BtBusca_50.CL_Filtro = Nothing
        Me.BtBusca_50.cl_formu = Nothing
        Me.BtBusca_50.CL_hfecha = Nothing
        Me.BtBusca_50.cl_ListaW = Nothing
        Me.BtBusca_50.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_50.Location = New System.Drawing.Point(169, 11)
        Me.BtBusca_50.Name = "BtBusca_50"
        Me.BtBusca_50.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_50.TabIndex = 73
        Me.BtBusca_50.UseVisualStyleBackColor = True
        '
        'Lb_56
        '
        Me.Lb_56.AutoSize = True
        Me.Lb_56.CL_ControlAsociado = Nothing
        Me.Lb_56.CL_ValorFijo = False
        Me.Lb_56.ClForm = Nothing
        Me.Lb_56.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_56.ForeColor = System.Drawing.Color.Teal
        Me.Lb_56.Location = New System.Drawing.Point(543, 18)
        Me.Lb_56.Name = "Lb_56"
        Me.Lb_56.Size = New System.Drawing.Size(46, 16)
        Me.Lb_56.TabIndex = 80
        Me.Lb_56.Text = "Kilos "
        '
        'TxDato_56
        '
        Me.TxDato_56.Autonumerico = False
        Me.TxDato_56.Buscando = False
        Me.TxDato_56.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_56.ClForm = Nothing
        Me.TxDato_56.ClParam = Nothing
        Me.TxDato_56.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_56.GridLin = Nothing
        Me.TxDato_56.HaCambiado = False
        Me.TxDato_56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_56.lbbusca = Nothing
        Me.TxDato_56.Location = New System.Drawing.Point(603, 12)
        Me.TxDato_56.MiError = False
        Me.TxDato_56.Name = "TxDato_56"
        Me.TxDato_56.Orden = 0
        Me.TxDato_56.SaltoAlfinal = False
        Me.TxDato_56.Siguiente = 0
        Me.TxDato_56.Size = New System.Drawing.Size(89, 22)
        Me.TxDato_56.TabIndex = 79
        Me.TxDato_56.TeclaRepetida = False
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 40)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(708, 365)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmPartedestrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 540)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPartedestrio"
        Me.Text = "Parte Destrio"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_50 As NetAgro.Lb
    Friend WithEvents BtBusca_50 As NetAgro.BtBusca
    Friend WithEvents TxDato_50 As NetAgro.TxDato
    Friend WithEvents Lb_50 As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents TxDato_56 As NetAgro.TxDato
    Friend WithEvents Lb_56 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
