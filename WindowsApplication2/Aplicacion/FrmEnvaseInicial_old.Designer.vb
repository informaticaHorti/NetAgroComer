<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnvaseInicial_old
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnvaseInicial_old))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.CbEnvases = New NetAgro.CbBox(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomVale = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbnom_13 = New NetAgro.Lb(Me.components)
        Me.TxDato_13 = New NetAgro.TxDato(Me.components)
        Me.Lb_13 = New NetAgro.Lb(Me.components)
        Me.BtBusca_13 = New NetAgro.BtBusca(Me.components)
        Me.Lbnom_15 = New NetAgro.Lb(Me.components)
        Me.TxDato_15 = New NetAgro.TxDato(Me.components)
        Me.Lb_15 = New NetAgro.Lb(Me.components)
        Me.BtBusca_15 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.Lb_12 = New NetAgro.Lb(Me.components)
        Me.TxDato_12 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.BtBusca_10 = New NetAgro.BtBusca(Me.components)
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
        Me.Panel4.Controls.Add(Me.Lb15)
        Me.Panel4.Controls.Add(Me.CbEnvases)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(787, 82)
        Me.Panel4.TabIndex = 72
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = False
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(20, 46)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(42, 16)
        Me.Lb15.TabIndex = 127
        Me.Lb15.Text = "Tipo "
        '
        'CbEnvases
        '
        Me.CbEnvases.Campobd = Nothing
        Me.CbEnvases.ClForm = Nothing
        Me.CbEnvases.FormattingEnabled = True
        Me.CbEnvases.GridLin = Nothing
        Me.CbEnvases.Location = New System.Drawing.Point(112, 45)
        Me.CbEnvases.MiEntidad = Nothing
        Me.CbEnvases.MiError = False
        Me.CbEnvases.Name = "CbEnvases"
        Me.CbEnvases.Orden = 0
        Me.CbEnvases.SaltoAlfinal = False
        Me.CbEnvases.Size = New System.Drawing.Size(159, 21)
        Me.CbEnvases.TabIndex = 126
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNomVale)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 33)
        Me.Panel3.TabIndex = 125
        '
        'LbNomVale
        '
        Me.LbNomVale.AutoSize = True
        Me.LbNomVale.CL_ControlAsociado = Nothing
        Me.LbNomVale.CL_ValorFijo = True
        Me.LbNomVale.ClForm = Nothing
        Me.LbNomVale.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomVale.ForeColor = System.Drawing.Color.Blue
        Me.LbNomVale.Location = New System.Drawing.Point(397, 0)
        Me.LbNomVale.Name = "LbNomVale"
        Me.LbNomVale.Size = New System.Drawing.Size(293, 25)
        Me.LbNomVale.TabIndex = 116
        Me.LbNomVale.Text = "Saldos iniciales envases"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lbnom_13)
        Me.Panel2.Controls.Add(Me.TxDato_13)
        Me.Panel2.Controls.Add(Me.Lb_13)
        Me.Panel2.Controls.Add(Me.BtBusca_13)
        Me.Panel2.Controls.Add(Me.Lbnom_15)
        Me.Panel2.Controls.Add(Me.TxDato_15)
        Me.Panel2.Controls.Add(Me.Lb_15)
        Me.Panel2.Controls.Add(Me.BtBusca_15)
        Me.Panel2.Controls.Add(Me.TxDato_11)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lb_11)
        Me.Panel2.Controls.Add(Me.Lb_12)
        Me.Panel2.Controls.Add(Me.TxDato_12)
        Me.Panel2.Controls.Add(Me.Lbnom_10)
        Me.Panel2.Controls.Add(Me.TxDato_10)
        Me.Panel2.Controls.Add(Me.Lb_10)
        Me.Panel2.Controls.Add(Me.BtBusca_10)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 376)
        Me.Panel2.TabIndex = 73
        '
        'Lbnom_13
        '
        Me.Lbnom_13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_13.CL_ControlAsociado = Nothing
        Me.Lbnom_13.CL_ValorFijo = False
        Me.Lbnom_13.ClForm = Nothing
        Me.Lbnom_13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_13.Location = New System.Drawing.Point(210, 11)
        Me.Lbnom_13.Name = "Lbnom_13"
        Me.Lbnom_13.Size = New System.Drawing.Size(346, 23)
        Me.Lbnom_13.TabIndex = 149
        '
        'TxDato_13
        '
        Me.TxDato_13.Autonumerico = False
        Me.TxDato_13.Buscando = False
        Me.TxDato_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_13.ClForm = Nothing
        Me.TxDato_13.ClParam = Nothing
        Me.TxDato_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_13.GridLin = Nothing
        Me.TxDato_13.HaCambiado = False
        Me.TxDato_13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_13.lbbusca = Nothing
        Me.TxDato_13.Location = New System.Drawing.Point(112, 11)
        Me.TxDato_13.MiError = False
        Me.TxDato_13.Name = "TxDato_13"
        Me.TxDato_13.Orden = 0
        Me.TxDato_13.SaltoAlfinal = False
        Me.TxDato_13.Siguiente = 0
        Me.TxDato_13.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_13.TabIndex = 146
        Me.TxDato_13.TeclaRepetida = False
        '
        'Lb_13
        '
        Me.Lb_13.AutoSize = True
        Me.Lb_13.CL_ControlAsociado = Nothing
        Me.Lb_13.CL_ValorFijo = False
        Me.Lb_13.ClForm = Nothing
        Me.Lb_13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_13.ForeColor = System.Drawing.Color.Teal
        Me.Lb_13.Location = New System.Drawing.Point(20, 14)
        Me.Lb_13.Name = "Lb_13"
        Me.Lb_13.Size = New System.Drawing.Size(58, 16)
        Me.Lb_13.TabIndex = 147
        Me.Lb_13.Text = "Código"
        '
        'BtBusca_13
        '
        Me.BtBusca_13.CL_BuscaAlb = False
        Me.BtBusca_13.CL_campocodigo = Nothing
        Me.BtBusca_13.CL_camponombre = Nothing
        Me.BtBusca_13.CL_CampoOrden = "Nombre"
        Me.BtBusca_13.CL_ch1000 = False
        Me.BtBusca_13.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_13.CL_ControlAsociado = Me.TxDato_13
        Me.BtBusca_13.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_13.CL_dfecha = Nothing
        Me.BtBusca_13.CL_Entidad = Nothing
        Me.BtBusca_13.CL_Filtro = Nothing
        Me.BtBusca_13.cl_formu = Nothing
        Me.BtBusca_13.CL_hfecha = Nothing
        Me.BtBusca_13.cl_ListaW = Nothing
        Me.BtBusca_13.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_13.Location = New System.Drawing.Point(171, 11)
        Me.BtBusca_13.Name = "BtBusca_13"
        Me.BtBusca_13.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_13.TabIndex = 148
        Me.BtBusca_13.UseVisualStyleBackColor = True
        '
        'Lbnom_15
        '
        Me.Lbnom_15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_15.CL_ControlAsociado = Nothing
        Me.Lbnom_15.CL_ValorFijo = False
        Me.Lbnom_15.ClForm = Nothing
        Me.Lbnom_15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_15.Location = New System.Drawing.Point(210, 68)
        Me.Lbnom_15.Name = "Lbnom_15"
        Me.Lbnom_15.Size = New System.Drawing.Size(346, 23)
        Me.Lbnom_15.TabIndex = 145
        '
        'TxDato_15
        '
        Me.TxDato_15.Autonumerico = False
        Me.TxDato_15.Buscando = False
        Me.TxDato_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_15.ClForm = Nothing
        Me.TxDato_15.ClParam = Nothing
        Me.TxDato_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_15.GridLin = Nothing
        Me.TxDato_15.HaCambiado = False
        Me.TxDato_15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_15.lbbusca = Nothing
        Me.TxDato_15.Location = New System.Drawing.Point(112, 69)
        Me.TxDato_15.MiError = False
        Me.TxDato_15.Name = "TxDato_15"
        Me.TxDato_15.Orden = 0
        Me.TxDato_15.SaltoAlfinal = False
        Me.TxDato_15.Siguiente = 0
        Me.TxDato_15.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_15.TabIndex = 142
        Me.TxDato_15.TeclaRepetida = False
        '
        'Lb_15
        '
        Me.Lb_15.AutoSize = True
        Me.Lb_15.CL_ControlAsociado = Nothing
        Me.Lb_15.CL_ValorFijo = False
        Me.Lb_15.ClForm = Nothing
        Me.Lb_15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_15.ForeColor = System.Drawing.Color.Teal
        Me.Lb_15.Location = New System.Drawing.Point(20, 75)
        Me.Lb_15.Name = "Lb_15"
        Me.Lb_15.Size = New System.Drawing.Size(52, 16)
        Me.Lb_15.TabIndex = 143
        Me.Lb_15.Text = "Marca"
        '
        'BtBusca_15
        '
        Me.BtBusca_15.CL_BuscaAlb = False
        Me.BtBusca_15.CL_campocodigo = Nothing
        Me.BtBusca_15.CL_camponombre = Nothing
        Me.BtBusca_15.CL_CampoOrden = "Nombre"
        Me.BtBusca_15.CL_ch1000 = False
        Me.BtBusca_15.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_15.CL_ControlAsociado = Me.TxDato_15
        Me.BtBusca_15.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_15.CL_dfecha = Nothing
        Me.BtBusca_15.CL_Entidad = Nothing
        Me.BtBusca_15.CL_Filtro = Nothing
        Me.BtBusca_15.cl_formu = Nothing
        Me.BtBusca_15.CL_hfecha = Nothing
        Me.BtBusca_15.cl_ListaW = Nothing
        Me.BtBusca_15.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_15.Location = New System.Drawing.Point(171, 69)
        Me.BtBusca_15.Name = "BtBusca_15"
        Me.BtBusca_15.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_15.TabIndex = 144
        Me.BtBusca_15.UseVisualStyleBackColor = True
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(112, 101)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(74, 22)
        Me.TxDato_11.TabIndex = 137
        Me.TxDato_11.TeclaRepetida = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(731, 68)
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
        Me.PictureBox1.Location = New System.Drawing.Point(709, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lb_11
        '
        Me.Lb_11.AutoSize = True
        Me.Lb_11.CL_ControlAsociado = Nothing
        Me.Lb_11.CL_ValorFijo = True
        Me.Lb_11.ClForm = Nothing
        Me.Lb_11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_11.ForeColor = System.Drawing.Color.Teal
        Me.Lb_11.Location = New System.Drawing.Point(20, 104)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(35, 16)
        Me.Lb_11.TabIndex = 117
        Me.Lb_11.Text = "Uds"
        '
        'Lb_12
        '
        Me.Lb_12.AutoSize = True
        Me.Lb_12.CL_ControlAsociado = Nothing
        Me.Lb_12.CL_ValorFijo = False
        Me.Lb_12.ClForm = Nothing
        Me.Lb_12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_12.ForeColor = System.Drawing.Color.Teal
        Me.Lb_12.Location = New System.Drawing.Point(224, 104)
        Me.Lb_12.Name = "Lb_12"
        Me.Lb_12.Size = New System.Drawing.Size(53, 16)
        Me.Lb_12.TabIndex = 102
        Me.Lb_12.Text = "Precio"
        '
        'TxDato_12
        '
        Me.TxDato_12.Autonumerico = False
        Me.TxDato_12.Buscando = False
        Me.TxDato_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_12.ClForm = Nothing
        Me.TxDato_12.ClParam = Nothing
        Me.TxDato_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_12.GridLin = Nothing
        Me.TxDato_12.HaCambiado = False
        Me.TxDato_12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_12.lbbusca = Nothing
        Me.TxDato_12.Location = New System.Drawing.Point(285, 101)
        Me.TxDato_12.MiError = False
        Me.TxDato_12.Name = "TxDato_12"
        Me.TxDato_12.Orden = 0
        Me.TxDato_12.SaltoAlfinal = False
        Me.TxDato_12.Siguiente = 0
        Me.TxDato_12.Size = New System.Drawing.Size(96, 22)
        Me.TxDato_12.TabIndex = 101
        Me.TxDato_12.TeclaRepetida = False
        '
        'Lbnom_10
        '
        Me.Lbnom_10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_10.CL_ControlAsociado = Nothing
        Me.Lbnom_10.CL_ValorFijo = False
        Me.Lbnom_10.ClForm = Nothing
        Me.Lbnom_10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_10.Location = New System.Drawing.Point(210, 40)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(346, 23)
        Me.Lbnom_10.TabIndex = 74
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(112, 40)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_10.TabIndex = 71
        Me.TxDato_10.TeclaRepetida = False
        '
        'Lb_10
        '
        Me.Lb_10.AutoSize = True
        Me.Lb_10.CL_ControlAsociado = Nothing
        Me.Lb_10.CL_ValorFijo = False
        Me.Lb_10.ClForm = Nothing
        Me.Lb_10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_10.ForeColor = System.Drawing.Color.Teal
        Me.Lb_10.Location = New System.Drawing.Point(20, 43)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(61, 16)
        Me.Lb_10.TabIndex = 72
        Me.Lb_10.Text = "Envase"
        '
        'BtBusca_10
        '
        Me.BtBusca_10.CL_BuscaAlb = False
        Me.BtBusca_10.CL_campocodigo = Nothing
        Me.BtBusca_10.CL_camponombre = Nothing
        Me.BtBusca_10.CL_CampoOrden = "Nombre"
        Me.BtBusca_10.CL_ch1000 = False
        Me.BtBusca_10.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_10.CL_ControlAsociado = Me.TxDato_10
        Me.BtBusca_10.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_10.CL_dfecha = Nothing
        Me.BtBusca_10.CL_Entidad = Nothing
        Me.BtBusca_10.CL_Filtro = Nothing
        Me.BtBusca_10.cl_formu = Nothing
        Me.BtBusca_10.CL_hfecha = Nothing
        Me.BtBusca_10.cl_ListaW = Nothing
        Me.BtBusca_10.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_10.Location = New System.Drawing.Point(171, 40)
        Me.BtBusca_10.Name = "BtBusca_10"
        Me.BtBusca_10.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_10.TabIndex = 73
        Me.BtBusca_10.UseVisualStyleBackColor = True
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 129)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(783, 243)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmEnvaseinicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 510)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEnvaseinicial"
        Me.Text = "Saldos inicales envases"
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents BtBusca_10 As NetAgro.BtBusca
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents TxDato_12 As NetAgro.TxDato
    Friend WithEvents Lb_12 As NetAgro.Lb
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LbNomVale As NetAgro.Lb
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents Lbnom_15 As NetAgro.Lb
    Friend WithEvents TxDato_15 As NetAgro.TxDato
    Friend WithEvents Lb_15 As NetAgro.Lb
    Friend WithEvents BtBusca_15 As NetAgro.BtBusca
    Friend WithEvents Lbnom_13 As NetAgro.Lb
    Friend WithEvents TxDato_13 As NetAgro.TxDato
    Friend WithEvents Lb_13 As NetAgro.Lb
    Friend WithEvents BtBusca_13 As NetAgro.BtBusca
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents CbEnvases As NetAgro.CbBox

End Class
