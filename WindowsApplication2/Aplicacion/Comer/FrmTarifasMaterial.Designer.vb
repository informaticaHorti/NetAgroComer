<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarifasMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTarifasMaterial))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_3 = New NetAgro.Lb(Me.components)
        Me.BtBusca_3 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_3 = New NetAgro.TxDato(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbnom_15 = New NetAgro.Lb(Me.components)
        Me.TxDato_15 = New NetAgro.TxDato(Me.components)
        Me.Lb_15 = New NetAgro.Lb(Me.components)
        Me.BtBusca_15 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.Lb_13 = New NetAgro.Lb(Me.components)
        Me.TxDato_13 = New NetAgro.TxDato(Me.components)
        Me.Lb_12 = New NetAgro.Lb(Me.components)
        Me.TxDato_12 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.BtBusca_10 = New NetAgro.BtBusca(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
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
        Me.Panel4.Controls.Add(Me.Lb_2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Controls.Add(Me.Lbnom_3)
        Me.Panel4.Controls.Add(Me.BtBusca_3)
        Me.Panel4.Controls.Add(Me.Lb_3)
        Me.Panel4.Controls.Add(Me.TxDato_3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 56)
        Me.Panel4.TabIndex = 72
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(683, 16)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(52, 16)
        Me.Lb_2.TabIndex = 77
        Me.Lb_2.Text = "Fecha"
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(749, 13)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_2.TabIndex = 76
        Me.TxDato_2.TeclaRepetida = False
        '
        'Lbnom_3
        '
        Me.Lbnom_3.BackColor = System.Drawing.Color.LightGray
        Me.Lbnom_3.CL_ControlAsociado = Nothing
        Me.Lbnom_3.CL_ValorFijo = False
        Me.Lbnom_3.ClForm = Nothing
        Me.Lbnom_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_3.Location = New System.Drawing.Point(239, 17)
        Me.Lbnom_3.Name = "Lbnom_3"
        Me.Lbnom_3.Size = New System.Drawing.Size(401, 18)
        Me.Lbnom_3.TabIndex = 74
        '
        'BtBusca_3
        '
        Me.BtBusca_3.CL_BuscaAlb = False
        Me.BtBusca_3.CL_campocodigo = Nothing
        Me.BtBusca_3.CL_camponombre = Nothing
        Me.BtBusca_3.CL_CampoOrden = "Nombre"
        Me.BtBusca_3.CL_ch1000 = False
        Me.BtBusca_3.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_3.CL_ControlAsociado = Me.TxDato_3
        Me.BtBusca_3.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_3.CL_dfecha = Nothing
        Me.BtBusca_3.CL_Entidad = Nothing
        Me.BtBusca_3.CL_Filtro = Nothing
        Me.BtBusca_3.cl_formu = Nothing
        Me.BtBusca_3.CL_hfecha = Nothing
        Me.BtBusca_3.cl_ListaW = Nothing
        Me.BtBusca_3.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_3.Location = New System.Drawing.Point(200, 15)
        Me.BtBusca_3.Name = "BtBusca_3"
        Me.BtBusca_3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_3.TabIndex = 73
        Me.BtBusca_3.UseVisualStyleBackColor = True
        '
        'TxDato_3
        '
        Me.TxDato_3.Autonumerico = False
        Me.TxDato_3.Buscando = False
        Me.TxDato_3.ClForm = Nothing
        Me.TxDato_3.ClParam = Nothing
        Me.TxDato_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_3.GridLin = Nothing
        Me.TxDato_3.HaCambiado = False
        Me.TxDato_3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_3.lbbusca = Nothing
        Me.TxDato_3.Location = New System.Drawing.Point(114, 16)
        Me.TxDato_3.MiError = False
        Me.TxDato_3.Name = "TxDato_3"
        Me.TxDato_3.Orden = 0
        Me.TxDato_3.SaltoAlfinal = False
        Me.TxDato_3.Siguiente = 0
        Me.TxDato_3.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_3.TabIndex = 71
        Me.TxDato_3.TeclaRepetida = False
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(11, 19)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(74, 16)
        Me.Lb_3.TabIndex = 72
        Me.Lb_3.Text = "Acreedor"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lbnom_15)
        Me.Panel2.Controls.Add(Me.TxDato_15)
        Me.Panel2.Controls.Add(Me.Lb_15)
        Me.Panel2.Controls.Add(Me.BtBusca_15)
        Me.Panel2.Controls.Add(Me.TxDato_11)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lb_11)
        Me.Panel2.Controls.Add(Me.Lb_13)
        Me.Panel2.Controls.Add(Me.TxDato_13)
        Me.Panel2.Controls.Add(Me.Lb_12)
        Me.Panel2.Controls.Add(Me.TxDato_12)
        Me.Panel2.Controls.Add(Me.Lbnom_10)
        Me.Panel2.Controls.Add(Me.TxDato_10)
        Me.Panel2.Controls.Add(Me.Lb_10)
        Me.Panel2.Controls.Add(Me.BtBusca_10)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 387)
        Me.Panel2.TabIndex = 73
        '
        'Lbnom_15
        '
        Me.Lbnom_15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_15.CL_ControlAsociado = Nothing
        Me.Lbnom_15.CL_ValorFijo = False
        Me.Lbnom_15.ClForm = Nothing
        Me.Lbnom_15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_15.Location = New System.Drawing.Point(214, 37)
        Me.Lbnom_15.Name = "Lbnom_15"
        Me.Lbnom_15.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_15.TabIndex = 141
        '
        'TxDato_15
        '
        Me.TxDato_15.Autonumerico = False
        Me.TxDato_15.Buscando = False
        Me.TxDato_15.ClForm = Nothing
        Me.TxDato_15.ClParam = Nothing
        Me.TxDato_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_15.GridLin = Nothing
        Me.TxDato_15.HaCambiado = False
        Me.TxDato_15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_15.lbbusca = Nothing
        Me.TxDato_15.Location = New System.Drawing.Point(114, 38)
        Me.TxDato_15.MiError = False
        Me.TxDato_15.Name = "TxDato_15"
        Me.TxDato_15.Orden = 0
        Me.TxDato_15.SaltoAlfinal = False
        Me.TxDato_15.Siguiente = 0
        Me.TxDato_15.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_15.TabIndex = 138
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
        Me.Lb_15.Location = New System.Drawing.Point(6, 40)
        Me.Lb_15.Name = "Lb_15"
        Me.Lb_15.Size = New System.Drawing.Size(52, 16)
        Me.Lb_15.TabIndex = 139
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
        Me.BtBusca_15.Location = New System.Drawing.Point(175, 38)
        Me.BtBusca_15.Name = "BtBusca_15"
        Me.BtBusca_15.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_15.TabIndex = 140
        Me.BtBusca_15.UseVisualStyleBackColor = True
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(634, 8)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(114, 22)
        Me.TxDato_11.TabIndex = 137
        Me.TxDato_11.TeclaRepetida = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(897, 4)
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
        Me.PictureBox1.Location = New System.Drawing.Point(875, 5)
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
        Me.Lb_11.Location = New System.Drawing.Point(543, 10)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(53, 16)
        Me.Lb_11.TabIndex = 117
        Me.Lb_11.Text = "Precio"
        '
        'Lb_13
        '
        Me.Lb_13.AutoSize = True
        Me.Lb_13.CL_ControlAsociado = Nothing
        Me.Lb_13.CL_ValorFijo = False
        Me.Lb_13.ClForm = Nothing
        Me.Lb_13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_13.ForeColor = System.Drawing.Color.Teal
        Me.Lb_13.Location = New System.Drawing.Point(543, 41)
        Me.Lb_13.Name = "Lb_13"
        Me.Lb_13.Size = New System.Drawing.Size(85, 16)
        Me.Lb_13.TabIndex = 106
        Me.Lb_13.Text = "Referencia"
        '
        'TxDato_13
        '
        Me.TxDato_13.Autonumerico = False
        Me.TxDato_13.Buscando = False
        Me.TxDato_13.ClForm = Nothing
        Me.TxDato_13.ClParam = Nothing
        Me.TxDato_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_13.GridLin = Nothing
        Me.TxDato_13.HaCambiado = False
        Me.TxDato_13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_13.lbbusca = Nothing
        Me.TxDato_13.Location = New System.Drawing.Point(634, 41)
        Me.TxDato_13.MiError = False
        Me.TxDato_13.Name = "TxDato_13"
        Me.TxDato_13.Orden = 0
        Me.TxDato_13.SaltoAlfinal = False
        Me.TxDato_13.Siguiente = 0
        Me.TxDato_13.Size = New System.Drawing.Size(231, 22)
        Me.TxDato_13.TabIndex = 105
        Me.TxDato_13.TeclaRepetida = False
        '
        'Lb_12
        '
        Me.Lb_12.AutoSize = True
        Me.Lb_12.CL_ControlAsociado = Nothing
        Me.Lb_12.CL_ValorFijo = False
        Me.Lb_12.ClForm = Nothing
        Me.Lb_12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_12.ForeColor = System.Drawing.Color.Teal
        Me.Lb_12.Location = New System.Drawing.Point(754, 10)
        Me.Lb_12.Name = "Lb_12"
        Me.Lb_12.Size = New System.Drawing.Size(54, 16)
        Me.Lb_12.TabIndex = 102
        Me.Lb_12.Text = "% Dto"
        '
        'TxDato_12
        '
        Me.TxDato_12.Autonumerico = False
        Me.TxDato_12.Buscando = False
        Me.TxDato_12.ClForm = Nothing
        Me.TxDato_12.ClParam = Nothing
        Me.TxDato_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_12.GridLin = Nothing
        Me.TxDato_12.HaCambiado = False
        Me.TxDato_12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_12.lbbusca = Nothing
        Me.TxDato_12.Location = New System.Drawing.Point(814, 8)
        Me.TxDato_12.MiError = False
        Me.TxDato_12.Name = "TxDato_12"
        Me.TxDato_12.Orden = 0
        Me.TxDato_12.SaltoAlfinal = False
        Me.TxDato_12.Siguiente = 0
        Me.TxDato_12.Size = New System.Drawing.Size(55, 22)
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
        Me.Lbnom_10.Location = New System.Drawing.Point(214, 8)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_10.TabIndex = 74
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(114, 8)
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
        Me.Lb_10.Location = New System.Drawing.Point(6, 10)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(67, 16)
        Me.Lb_10.TabIndex = 72
        Me.Lb_10.Text = "Material"
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
        Me.BtBusca_10.Location = New System.Drawing.Point(175, 8)
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
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 67)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(916, 316)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmTarifasMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 510)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTarifasMaterial"
        Me.Text = "Tarifas materiales"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lbnom_3 As NetAgro.Lb
    Friend WithEvents BtBusca_3 As NetAgro.BtBusca
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents BtBusca_10 As NetAgro.BtBusca
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents TxDato_13 As NetAgro.TxDato
    Friend WithEvents Lb_13 As NetAgro.Lb
    Friend WithEvents TxDato_12 As NetAgro.TxDato
    Friend WithEvents Lb_12 As NetAgro.Lb
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents TxDato_15 As NetAgro.TxDato
    Friend WithEvents Lb_15 As NetAgro.Lb
    Friend WithEvents BtBusca_15 As NetAgro.BtBusca
    Friend WithEvents Lbnom_15 As NetAgro.Lb

End Class
