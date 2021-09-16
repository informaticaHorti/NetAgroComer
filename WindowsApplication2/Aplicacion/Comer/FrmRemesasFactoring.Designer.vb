<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemesasFactoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRemesasFactoring))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Lb_29 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtNuevo = New NetAgro.ClButton()
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtBusca3 = New System.Windows.Forms.Button()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbTotalAlb = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.LbGastos = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbCodCliente = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFechaSalida = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb_30 = New NetAgro.Lb(Me.components)
        Me.LbTotalRemesa = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Lb2)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.TxDato2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.BtNuevo)
        Me.Panel4.Controls.Add(Me.BtBusca1)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1019, 48)
        Me.Panel4.TabIndex = 72
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
        Me.LbCampa.Location = New System.Drawing.Point(83, 10)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 22)
        Me.LbCampa.TabIndex = 137
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNomCentro)
        Me.Panel3.Controls.Add(Me.LbCentro)
        Me.Panel3.Controls.Add(Me.Lb_29)
        Me.Panel3.Location = New System.Drawing.Point(725, 3)
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
        'Lb_29
        '
        Me.Lb_29.AutoSize = True
        Me.Lb_29.CL_ControlAsociado = Nothing
        Me.Lb_29.CL_ValorFijo = True
        Me.Lb_29.ClForm = Nothing
        Me.Lb_29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_29.ForeColor = System.Drawing.Color.Teal
        Me.Lb_29.Location = New System.Drawing.Point(6, 7)
        Me.Lb_29.Name = "Lb_29"
        Me.Lb_29.Size = New System.Drawing.Size(57, 16)
        Me.Lb_29.TabIndex = 113
        Me.Lb_29.Text = "Centro"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(306, 13)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(52, 16)
        Me.Lb2.TabIndex = 77
        Me.Lb2.Text = "Fecha"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(679, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(364, 10)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(108, 22)
        Me.TxDato2.TabIndex = 76
        Me.TxDato2.TeclaRepetida = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(657, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'BtNuevo
        '
        Me.BtNuevo.Image = CType(resources.GetObject("BtNuevo.Image"), System.Drawing.Image)
        Me.BtNuevo.Location = New System.Drawing.Point(234, 10)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Orden = 0
        Me.BtNuevo.PedirClave = True
        Me.BtNuevo.Size = New System.Drawing.Size(26, 23)
        Me.BtNuevo.TabIndex = 75
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Me.TxDato1
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_EsId = True
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.CL_xCentro = False
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(199, 10)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 70
        Me.BtBusca1.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(121, 10)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato1.TabIndex = 65
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(65, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Número"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtBusca3)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.LbTotalAlb)
        Me.Panel2.Controls.Add(Me.Lb8)
        Me.Panel2.Controls.Add(Me.LbGastos)
        Me.Panel2.Controls.Add(Me.Lb6)
        Me.Panel2.Controls.Add(Me.LbImporte)
        Me.Panel2.Controls.Add(Me.LbCliente)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.LbCodCliente)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.LbFechaSalida)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1019, 362)
        Me.Panel2.TabIndex = 73
        '
        'BtBusca3
        '
        Me.BtBusca3.Image = CType(resources.GetObject("BtBusca3.Image"), System.Drawing.Image)
        Me.BtBusca3.Location = New System.Drawing.Point(164, 6)
        Me.BtBusca3.Name = "BtBusca3"
        Me.BtBusca3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca3.TabIndex = 100364
        Me.BtBusca3.UseVisualStyleBackColor = True
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(654, 68)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(76, 16)
        Me.Lb7.TabIndex = 155
        Me.Lb7.Text = "Total Alb."
        '
        'LbTotalAlb
        '
        Me.LbTotalAlb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTotalAlb.CL_ControlAsociado = Nothing
        Me.LbTotalAlb.CL_ValorFijo = False
        Me.LbTotalAlb.ClForm = Nothing
        Me.LbTotalAlb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalAlb.ForeColor = System.Drawing.Color.Black
        Me.LbTotalAlb.Location = New System.Drawing.Point(737, 65)
        Me.LbTotalAlb.Name = "LbTotalAlb"
        Me.LbTotalAlb.Size = New System.Drawing.Size(131, 23)
        Me.LbTotalAlb.TabIndex = 154
        Me.LbTotalAlb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(297, 68)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(58, 16)
        Me.Lb8.TabIndex = 153
        Me.Lb8.Text = "Gastos"
        '
        'LbGastos
        '
        Me.LbGastos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbGastos.CL_ControlAsociado = Nothing
        Me.LbGastos.CL_ValorFijo = False
        Me.LbGastos.ClForm = Nothing
        Me.LbGastos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGastos.ForeColor = System.Drawing.Color.Black
        Me.LbGastos.Location = New System.Drawing.Point(361, 65)
        Me.LbGastos.Name = "LbGastos"
        Me.LbGastos.Size = New System.Drawing.Size(131, 23)
        Me.LbGastos.TabIndex = 152
        Me.LbGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(12, 68)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(67, 16)
        Me.Lb6.TabIndex = 151
        Me.Lb6.Text = "Importe"
        '
        'LbImporte
        '
        Me.LbImporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.Black
        Me.LbImporte.Location = New System.Drawing.Point(83, 65)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(131, 23)
        Me.LbImporte.TabIndex = 150
        Me.LbImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = False
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Black
        Me.LbCliente.Location = New System.Drawing.Point(164, 36)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(703, 23)
        Me.LbCliente.TabIndex = 149
        Me.LbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(12, 39)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(59, 16)
        Me.Lb5.TabIndex = 148
        Me.Lb5.Text = "Cliente"
        '
        'LbCodCliente
        '
        Me.LbCodCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCodCliente.CL_ControlAsociado = Nothing
        Me.LbCodCliente.CL_ValorFijo = False
        Me.LbCodCliente.ClForm = Nothing
        Me.LbCodCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodCliente.ForeColor = System.Drawing.Color.Black
        Me.LbCodCliente.Location = New System.Drawing.Point(83, 36)
        Me.LbCodCliente.Name = "LbCodCliente"
        Me.LbCodCliente.Size = New System.Drawing.Size(75, 23)
        Me.LbCodCliente.TabIndex = 147
        Me.LbCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(275, 10)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(83, 16)
        Me.Lb4.TabIndex = 146
        Me.Lb4.Text = "Fecha Sal."
        '
        'LbFechaSalida
        '
        Me.LbFechaSalida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFechaSalida.CL_ControlAsociado = Nothing
        Me.LbFechaSalida.CL_ValorFijo = False
        Me.LbFechaSalida.ClForm = Nothing
        Me.LbFechaSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaSalida.ForeColor = System.Drawing.Color.Black
        Me.LbFechaSalida.Location = New System.Drawing.Point(364, 7)
        Me.LbFechaSalida.Name = "LbFechaSalida"
        Me.LbFechaSalida.Size = New System.Drawing.Size(128, 23)
        Me.LbFechaSalida.TabIndex = 142
        Me.LbFechaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(83, 7)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(75, 22)
        Me.TxDato3.TabIndex = 71
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 10)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(64, 16)
        Me.Lb3.TabIndex = 72
        Me.Lb3.Text = "Albaran"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 101)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1005, 254)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb_30
        '
        Me.Lb_30.AutoSize = True
        Me.Lb_30.CL_ControlAsociado = Nothing
        Me.Lb_30.CL_ValorFijo = True
        Me.Lb_30.ClForm = Nothing
        Me.Lb_30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_30.ForeColor = System.Drawing.Color.Teal
        Me.Lb_30.Location = New System.Drawing.Point(712, 432)
        Me.Lb_30.Name = "Lb_30"
        Me.Lb_30.Size = New System.Drawing.Size(103, 16)
        Me.Lb_30.TabIndex = 103
        Me.Lb_30.Text = "Total remesa"
        '
        'LbTotalRemesa
        '
        Me.LbTotalRemesa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTotalRemesa.CL_ControlAsociado = Nothing
        Me.LbTotalRemesa.CL_ValorFijo = True
        Me.LbTotalRemesa.ClForm = Nothing
        Me.LbTotalRemesa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalRemesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTotalRemesa.Location = New System.Drawing.Point(821, 429)
        Me.LbTotalRemesa.Name = "LbTotalRemesa"
        Me.LbTotalRemesa.Size = New System.Drawing.Size(150, 23)
        Me.LbTotalRemesa.TabIndex = 142
        Me.LbTotalRemesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmRemesasFactoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 510)
        Me.Controls.Add(Me.LbTotalRemesa)
        Me.Controls.Add(Me.Lb_30)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmRemesasFactoring"
        Me.Text = "Remesas factoring"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Lb_30, 0)
        Me.Controls.SetChildIndex(Me.LbTotalRemesa, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents BtNuevo As NetAgro.ClButton
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents Lb_29 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LbFechaSalida As NetAgro.Lb
    Friend WithEvents Lb_30 As NetAgro.Lb
    Friend WithEvents LbTotalRemesa As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbCodCliente As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents LbGastos As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbTotalAlb As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents BtBusca3 As System.Windows.Forms.Button

End Class
