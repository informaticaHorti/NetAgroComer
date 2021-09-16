<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParteExistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParteExistencias))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.TxDato_3 = New NetAgro.TxDato(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb_58 = New NetAgro.Lb(Me.components)
        Me.TxDato_58 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_53 = New NetAgro.Lb(Me.components)
        Me.TxDato_53 = New NetAgro.TxDato(Me.components)
        Me.Lb_53 = New NetAgro.Lb(Me.components)
        Me.BtBusca_53 = New NetAgro.BtBusca(Me.components)
        Me.Lb_nom52 = New NetAgro.Lb(Me.components)
        Me.TxDato_52 = New NetAgro.TxDato(Me.components)
        Me.Lb_52 = New NetAgro.Lb(Me.components)
        Me.BtBusca_52 = New NetAgro.BtBusca(Me.components)
        Me.Lb_57 = New NetAgro.Lb(Me.components)
        Me.TxDato_57 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_51 = New NetAgro.Lb(Me.components)
        Me.TxDato_51 = New NetAgro.TxDato(Me.components)
        Me.Lb_51 = New NetAgro.Lb(Me.components)
        Me.BtBusca_51 = New NetAgro.BtBusca(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_55 = New NetAgro.Lb(Me.components)
        Me.TxDato_55 = New NetAgro.TxDato(Me.components)
        Me.Lb_54 = New NetAgro.Lb(Me.components)
        Me.TxDato_54 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_50 = New NetAgro.Lb(Me.components)
        Me.TxDato_50 = New NetAgro.TxDato(Me.components)
        Me.Lb_50 = New NetAgro.Lb(Me.components)
        Me.BtBusca_50 = New NetAgro.BtBusca(Me.components)
        Me.Lb_56 = New NetAgro.Lb(Me.components)
        Me.TxDato_56 = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbCampa = New NetAgro.Lb(Me.components)
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
        Me.Panel4.Controls.Add(Me.Lb_3)
        Me.Panel4.Controls.Add(Me.TxDato_3)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Lb_2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(948, 68)
        Me.Panel4.TabIndex = 72
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(10, 40)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(98, 16)
        Me.Lb_3.TabIndex = 127
        Me.Lb_3.Text = "Fecha inicial"
        '
        'TxDato_3
        '
        Me.TxDato_3.Autonumerico = False
        Me.TxDato_3.Buscando = False
        Me.TxDato_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_3.ClForm = Nothing
        Me.TxDato_3.ClParam = Nothing
        Me.TxDato_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_3.GridLin = Nothing
        Me.TxDato_3.HaCambiado = False
        Me.TxDato_3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_3.lbbusca = Nothing
        Me.TxDato_3.Location = New System.Drawing.Point(138, 38)
        Me.TxDato_3.MiError = False
        Me.TxDato_3.Name = "TxDato_3"
        Me.TxDato_3.Orden = 0
        Me.TxDato_3.SaltoAlfinal = False
        Me.TxDato_3.Siguiente = 0
        Me.TxDato_3.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_3.TabIndex = 126
        Me.TxDato_3.TeclaRepetida = False
        Me.TxDato_3.UltimoValorValidado = Nothing
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbCampa)
        Me.Panel3.Controls.Add(Me.LbNomCentro)
        Me.Panel3.Controls.Add(Me.LbCentro)
        Me.Panel3.Controls.Add(Me.Lb29)
        Me.Panel3.Location = New System.Drawing.Point(581, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(328, 33)
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
        Me.LbNomCentro.Location = New System.Drawing.Point(208, 5)
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
        Me.LbCentro.Location = New System.Drawing.Point(175, 5)
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
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(10, 13)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(87, 16)
        Me.Lb_2.TabIndex = 77
        Me.Lb_2.Text = "Fecha final"
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
        Me.TxDato_2.Location = New System.Drawing.Point(138, 10)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_2.TabIndex = 76
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_Ancho = 0
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(237, 10)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 70
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lb_58)
        Me.Panel2.Controls.Add(Me.TxDato_58)
        Me.Panel2.Controls.Add(Me.Lbnom_53)
        Me.Panel2.Controls.Add(Me.TxDato_53)
        Me.Panel2.Controls.Add(Me.Lb_53)
        Me.Panel2.Controls.Add(Me.BtBusca_53)
        Me.Panel2.Controls.Add(Me.Lb_nom52)
        Me.Panel2.Controls.Add(Me.TxDato_52)
        Me.Panel2.Controls.Add(Me.Lb_52)
        Me.Panel2.Controls.Add(Me.BtBusca_52)
        Me.Panel2.Controls.Add(Me.Lb_57)
        Me.Panel2.Controls.Add(Me.TxDato_57)
        Me.Panel2.Controls.Add(Me.Lbnom_51)
        Me.Panel2.Controls.Add(Me.TxDato_51)
        Me.Panel2.Controls.Add(Me.Lb_51)
        Me.Panel2.Controls.Add(Me.BtBusca_51)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lb_55)
        Me.Panel2.Controls.Add(Me.TxDato_55)
        Me.Panel2.Controls.Add(Me.Lb_54)
        Me.Panel2.Controls.Add(Me.TxDato_54)
        Me.Panel2.Controls.Add(Me.Lbnom_50)
        Me.Panel2.Controls.Add(Me.TxDato_50)
        Me.Panel2.Controls.Add(Me.Lb_50)
        Me.Panel2.Controls.Add(Me.BtBusca_50)
        Me.Panel2.Controls.Add(Me.Lb_56)
        Me.Panel2.Controls.Add(Me.TxDato_56)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(948, 409)
        Me.Panel2.TabIndex = 73
        '
        'Lb_58
        '
        Me.Lb_58.AutoSize = True
        Me.Lb_58.CL_ControlAsociado = Nothing
        Me.Lb_58.CL_ValorFijo = False
        Me.Lb_58.ClForm = Nothing
        Me.Lb_58.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_58.ForeColor = System.Drawing.Color.Teal
        Me.Lb_58.Location = New System.Drawing.Point(3, 103)
        Me.Lb_58.Name = "Lb_58"
        Me.Lb_58.Size = New System.Drawing.Size(116, 16)
        Me.Lb_58.TabIndex = 156
        Me.Lb_58.Text = "Observaciones"
        '
        'TxDato_58
        '
        Me.TxDato_58.Autonumerico = False
        Me.TxDato_58.Buscando = False
        Me.TxDato_58.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_58.ClForm = Nothing
        Me.TxDato_58.ClParam = Nothing
        Me.TxDato_58.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_58.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_58.GridLin = Nothing
        Me.TxDato_58.HaCambiado = False
        Me.TxDato_58.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_58.lbbusca = Nothing
        Me.TxDato_58.Location = New System.Drawing.Point(125, 101)
        Me.TxDato_58.MiError = False
        Me.TxDato_58.Name = "TxDato_58"
        Me.TxDato_58.Orden = 0
        Me.TxDato_58.SaltoAlfinal = False
        Me.TxDato_58.Siguiente = 0
        Me.TxDato_58.Size = New System.Drawing.Size(480, 22)
        Me.TxDato_58.TabIndex = 155
        Me.TxDato_58.TeclaRepetida = False
        Me.TxDato_58.UltimoValorValidado = Nothing
        '
        'Lbnom_53
        '
        Me.Lbnom_53.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_53.CL_ControlAsociado = Nothing
        Me.Lbnom_53.CL_ValorFijo = False
        Me.Lbnom_53.ClForm = Nothing
        Me.Lbnom_53.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_53.Location = New System.Drawing.Point(742, 34)
        Me.Lbnom_53.Name = "Lbnom_53"
        Me.Lbnom_53.Size = New System.Drawing.Size(178, 23)
        Me.Lbnom_53.TabIndex = 154
        '
        'TxDato_53
        '
        Me.TxDato_53.Autonumerico = False
        Me.TxDato_53.Buscando = False
        Me.TxDato_53.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_53.ClForm = Nothing
        Me.TxDato_53.ClParam = Nothing
        Me.TxDato_53.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_53.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_53.GridLin = Nothing
        Me.TxDato_53.HaCambiado = False
        Me.TxDato_53.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_53.lbbusca = Nothing
        Me.TxDato_53.Location = New System.Drawing.Point(640, 34)
        Me.TxDato_53.MiError = False
        Me.TxDato_53.Name = "TxDato_53"
        Me.TxDato_53.Orden = 0
        Me.TxDato_53.SaltoAlfinal = False
        Me.TxDato_53.Siguiente = 0
        Me.TxDato_53.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_53.TabIndex = 151
        Me.TxDato_53.TeclaRepetida = False
        Me.TxDato_53.UltimoValorValidado = Nothing
        '
        'Lb_53
        '
        Me.Lb_53.AutoSize = True
        Me.Lb_53.CL_ControlAsociado = Nothing
        Me.Lb_53.CL_ValorFijo = False
        Me.Lb_53.ClForm = Nothing
        Me.Lb_53.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_53.ForeColor = System.Drawing.Color.Teal
        Me.Lb_53.Location = New System.Drawing.Point(532, 37)
        Me.Lb_53.Name = "Lb_53"
        Me.Lb_53.Size = New System.Drawing.Size(79, 16)
        Me.Lb_53.TabIndex = 152
        Me.Lb_53.Text = "Categoria"
        '
        'BtBusca_53
        '
        Me.BtBusca_53.CL_Ancho = 0
        Me.BtBusca_53.CL_BuscaAlb = False
        Me.BtBusca_53.CL_campocodigo = Nothing
        Me.BtBusca_53.CL_camponombre = Nothing
        Me.BtBusca_53.CL_CampoOrden = "Nombre"
        Me.BtBusca_53.CL_ch1000 = False
        Me.BtBusca_53.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_53.CL_ControlAsociado = Me.TxDato_53
        Me.BtBusca_53.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_53.CL_dfecha = Nothing
        Me.BtBusca_53.CL_Entidad = Nothing
        Me.BtBusca_53.CL_EsId = True
        Me.BtBusca_53.CL_Filtro = Nothing
        Me.BtBusca_53.cl_formu = Nothing
        Me.BtBusca_53.CL_hfecha = Nothing
        Me.BtBusca_53.cl_ListaW = Nothing
        Me.BtBusca_53.CL_xCentro = False
        Me.BtBusca_53.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_53.Location = New System.Drawing.Point(700, 34)
        Me.BtBusca_53.Name = "BtBusca_53"
        Me.BtBusca_53.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_53.TabIndex = 153
        Me.BtBusca_53.UseVisualStyleBackColor = True
        '
        'Lb_nom52
        '
        Me.Lb_nom52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_nom52.CL_ControlAsociado = Nothing
        Me.Lb_nom52.CL_ValorFijo = False
        Me.Lb_nom52.ClForm = Nothing
        Me.Lb_nom52.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nom52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_nom52.Location = New System.Drawing.Point(212, 38)
        Me.Lb_nom52.Name = "Lb_nom52"
        Me.Lb_nom52.Size = New System.Drawing.Size(294, 23)
        Me.Lb_nom52.TabIndex = 150
        '
        'TxDato_52
        '
        Me.TxDato_52.Autonumerico = False
        Me.TxDato_52.Buscando = False
        Me.TxDato_52.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_52.ClForm = Nothing
        Me.TxDato_52.ClParam = Nothing
        Me.TxDato_52.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_52.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_52.GridLin = Nothing
        Me.TxDato_52.HaCambiado = False
        Me.TxDato_52.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_52.lbbusca = Nothing
        Me.TxDato_52.Location = New System.Drawing.Point(110, 38)
        Me.TxDato_52.MiError = False
        Me.TxDato_52.Name = "TxDato_52"
        Me.TxDato_52.Orden = 0
        Me.TxDato_52.SaltoAlfinal = False
        Me.TxDato_52.Siguiente = 0
        Me.TxDato_52.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_52.TabIndex = 147
        Me.TxDato_52.TeclaRepetida = False
        Me.TxDato_52.UltimoValorValidado = Nothing
        '
        'Lb_52
        '
        Me.Lb_52.AutoSize = True
        Me.Lb_52.CL_ControlAsociado = Nothing
        Me.Lb_52.CL_ValorFijo = False
        Me.Lb_52.ClForm = Nothing
        Me.Lb_52.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_52.ForeColor = System.Drawing.Color.Teal
        Me.Lb_52.Location = New System.Drawing.Point(2, 41)
        Me.Lb_52.Name = "Lb_52"
        Me.Lb_52.Size = New System.Drawing.Size(88, 16)
        Me.Lb_52.TabIndex = 148
        Me.Lb_52.Text = "Confeccion"
        '
        'BtBusca_52
        '
        Me.BtBusca_52.CL_Ancho = 0
        Me.BtBusca_52.CL_BuscaAlb = False
        Me.BtBusca_52.CL_campocodigo = Nothing
        Me.BtBusca_52.CL_camponombre = Nothing
        Me.BtBusca_52.CL_CampoOrden = "Nombre"
        Me.BtBusca_52.CL_ch1000 = False
        Me.BtBusca_52.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_52.CL_ControlAsociado = Me.TxDato_52
        Me.BtBusca_52.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_52.CL_dfecha = Nothing
        Me.BtBusca_52.CL_Entidad = Nothing
        Me.BtBusca_52.CL_EsId = True
        Me.BtBusca_52.CL_Filtro = Nothing
        Me.BtBusca_52.cl_formu = Nothing
        Me.BtBusca_52.CL_hfecha = Nothing
        Me.BtBusca_52.cl_ListaW = Nothing
        Me.BtBusca_52.CL_xCentro = False
        Me.BtBusca_52.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_52.Location = New System.Drawing.Point(170, 38)
        Me.BtBusca_52.Name = "BtBusca_52"
        Me.BtBusca_52.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_52.TabIndex = 149
        Me.BtBusca_52.UseVisualStyleBackColor = True
        '
        'Lb_57
        '
        Me.Lb_57.AutoSize = True
        Me.Lb_57.CL_ControlAsociado = Nothing
        Me.Lb_57.CL_ValorFijo = False
        Me.Lb_57.ClForm = Nothing
        Me.Lb_57.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_57.ForeColor = System.Drawing.Color.Teal
        Me.Lb_57.Location = New System.Drawing.Point(662, 72)
        Me.Lb_57.Name = "Lb_57"
        Me.Lb_57.Size = New System.Drawing.Size(39, 16)
        Me.Lb_57.TabIndex = 145
        Me.Lb_57.Text = "PMC"
        '
        'TxDato_57
        '
        Me.TxDato_57.Autonumerico = False
        Me.TxDato_57.Buscando = False
        Me.TxDato_57.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_57.ClForm = Nothing
        Me.TxDato_57.ClParam = Nothing
        Me.TxDato_57.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_57.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_57.GridLin = Nothing
        Me.TxDato_57.HaCambiado = False
        Me.TxDato_57.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_57.lbbusca = Nothing
        Me.TxDato_57.Location = New System.Drawing.Point(707, 69)
        Me.TxDato_57.MiError = False
        Me.TxDato_57.Name = "TxDato_57"
        Me.TxDato_57.Orden = 0
        Me.TxDato_57.SaltoAlfinal = False
        Me.TxDato_57.Siguiente = 0
        Me.TxDato_57.Size = New System.Drawing.Size(85, 22)
        Me.TxDato_57.TabIndex = 144
        Me.TxDato_57.TeclaRepetida = False
        Me.TxDato_57.UltimoValorValidado = Nothing
        '
        'Lbnom_51
        '
        Me.Lbnom_51.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_51.CL_ControlAsociado = Nothing
        Me.Lbnom_51.CL_ValorFijo = False
        Me.Lbnom_51.ClForm = Nothing
        Me.Lbnom_51.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_51.Location = New System.Drawing.Point(742, 7)
        Me.Lbnom_51.Name = "Lbnom_51"
        Me.Lbnom_51.Size = New System.Drawing.Size(178, 23)
        Me.Lbnom_51.TabIndex = 141
        '
        'TxDato_51
        '
        Me.TxDato_51.Autonumerico = False
        Me.TxDato_51.Buscando = False
        Me.TxDato_51.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_51.ClForm = Nothing
        Me.TxDato_51.ClParam = Nothing
        Me.TxDato_51.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_51.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_51.GridLin = Nothing
        Me.TxDato_51.HaCambiado = False
        Me.TxDato_51.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_51.lbbusca = Nothing
        Me.TxDato_51.Location = New System.Drawing.Point(640, 7)
        Me.TxDato_51.MiError = False
        Me.TxDato_51.Name = "TxDato_51"
        Me.TxDato_51.Orden = 0
        Me.TxDato_51.SaltoAlfinal = False
        Me.TxDato_51.Siguiente = 0
        Me.TxDato_51.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_51.TabIndex = 138
        Me.TxDato_51.TeclaRepetida = False
        Me.TxDato_51.UltimoValorValidado = Nothing
        '
        'Lb_51
        '
        Me.Lb_51.AutoSize = True
        Me.Lb_51.CL_ControlAsociado = Nothing
        Me.Lb_51.CL_ValorFijo = False
        Me.Lb_51.ClForm = Nothing
        Me.Lb_51.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_51.ForeColor = System.Drawing.Color.Teal
        Me.Lb_51.Location = New System.Drawing.Point(532, 10)
        Me.Lb_51.Name = "Lb_51"
        Me.Lb_51.Size = New System.Drawing.Size(52, 16)
        Me.Lb_51.TabIndex = 139
        Me.Lb_51.Text = "Marca"
        '
        'BtBusca_51
        '
        Me.BtBusca_51.CL_Ancho = 0
        Me.BtBusca_51.CL_BuscaAlb = False
        Me.BtBusca_51.CL_campocodigo = Nothing
        Me.BtBusca_51.CL_camponombre = Nothing
        Me.BtBusca_51.CL_CampoOrden = "Nombre"
        Me.BtBusca_51.CL_ch1000 = False
        Me.BtBusca_51.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_51.CL_ControlAsociado = Me.TxDato_51
        Me.BtBusca_51.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_51.CL_dfecha = Nothing
        Me.BtBusca_51.CL_Entidad = Nothing
        Me.BtBusca_51.CL_EsId = True
        Me.BtBusca_51.CL_Filtro = Nothing
        Me.BtBusca_51.cl_formu = Nothing
        Me.BtBusca_51.CL_hfecha = Nothing
        Me.BtBusca_51.cl_ListaW = Nothing
        Me.BtBusca_51.CL_xCentro = False
        Me.BtBusca_51.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_51.Location = New System.Drawing.Point(700, 7)
        Me.BtBusca_51.Name = "BtBusca_51"
        Me.BtBusca_51.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_51.TabIndex = 140
        Me.BtBusca_51.UseVisualStyleBackColor = True
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
        'Lb_55
        '
        Me.Lb_55.AutoSize = True
        Me.Lb_55.CL_ControlAsociado = Nothing
        Me.Lb_55.CL_ValorFijo = False
        Me.Lb_55.ClForm = Nothing
        Me.Lb_55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_55.ForeColor = System.Drawing.Color.Teal
        Me.Lb_55.Location = New System.Drawing.Point(210, 72)
        Me.Lb_55.Name = "Lb_55"
        Me.Lb_55.Size = New System.Drawing.Size(54, 16)
        Me.Lb_55.TabIndex = 106
        Me.Lb_55.Text = "Bultos"
        '
        'TxDato_55
        '
        Me.TxDato_55.Autonumerico = False
        Me.TxDato_55.Buscando = False
        Me.TxDato_55.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_55.ClForm = Nothing
        Me.TxDato_55.ClParam = Nothing
        Me.TxDato_55.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_55.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_55.GridLin = Nothing
        Me.TxDato_55.HaCambiado = False
        Me.TxDato_55.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_55.lbbusca = Nothing
        Me.TxDato_55.Location = New System.Drawing.Point(276, 69)
        Me.TxDato_55.MiError = False
        Me.TxDato_55.Name = "TxDato_55"
        Me.TxDato_55.Orden = 0
        Me.TxDato_55.SaltoAlfinal = False
        Me.TxDato_55.Siguiente = 0
        Me.TxDato_55.Size = New System.Drawing.Size(65, 22)
        Me.TxDato_55.TabIndex = 105
        Me.TxDato_55.TeclaRepetida = False
        Me.TxDato_55.UltimoValorValidado = Nothing
        '
        'Lb_54
        '
        Me.Lb_54.AutoSize = True
        Me.Lb_54.CL_ControlAsociado = Nothing
        Me.Lb_54.CL_ValorFijo = False
        Me.Lb_54.ClForm = Nothing
        Me.Lb_54.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_54.ForeColor = System.Drawing.Color.Teal
        Me.Lb_54.Location = New System.Drawing.Point(3, 72)
        Me.Lb_54.Name = "Lb_54"
        Me.Lb_54.Size = New System.Drawing.Size(53, 16)
        Me.Lb_54.TabIndex = 102
        Me.Lb_54.Text = "Palets"
        '
        'TxDato_54
        '
        Me.TxDato_54.Autonumerico = False
        Me.TxDato_54.Buscando = False
        Me.TxDato_54.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_54.ClForm = Nothing
        Me.TxDato_54.ClParam = Nothing
        Me.TxDato_54.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_54.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_54.GridLin = Nothing
        Me.TxDato_54.HaCambiado = False
        Me.TxDato_54.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_54.lbbusca = Nothing
        Me.TxDato_54.Location = New System.Drawing.Point(110, 69)
        Me.TxDato_54.MiError = False
        Me.TxDato_54.Name = "TxDato_54"
        Me.TxDato_54.Orden = 0
        Me.TxDato_54.SaltoAlfinal = False
        Me.TxDato_54.Siguiente = 0
        Me.TxDato_54.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_54.TabIndex = 101
        Me.TxDato_54.TeclaRepetida = False
        Me.TxDato_54.UltimoValorValidado = Nothing
        '
        'Lbnom_50
        '
        Me.Lbnom_50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_50.CL_ControlAsociado = Nothing
        Me.Lbnom_50.CL_ValorFijo = False
        Me.Lbnom_50.ClForm = Nothing
        Me.Lbnom_50.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_50.Location = New System.Drawing.Point(210, 7)
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
        Me.TxDato_50.Location = New System.Drawing.Point(110, 7)
        Me.TxDato_50.MiError = False
        Me.TxDato_50.Name = "TxDato_50"
        Me.TxDato_50.Orden = 0
        Me.TxDato_50.SaltoAlfinal = False
        Me.TxDato_50.Siguiente = 0
        Me.TxDato_50.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_50.TabIndex = 71
        Me.TxDato_50.TeclaRepetida = False
        Me.TxDato_50.UltimoValorValidado = Nothing
        '
        'Lb_50
        '
        Me.Lb_50.AutoSize = True
        Me.Lb_50.CL_ControlAsociado = Nothing
        Me.Lb_50.CL_ValorFijo = False
        Me.Lb_50.ClForm = Nothing
        Me.Lb_50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_50.ForeColor = System.Drawing.Color.Teal
        Me.Lb_50.Location = New System.Drawing.Point(2, 10)
        Me.Lb_50.Name = "Lb_50"
        Me.Lb_50.Size = New System.Drawing.Size(60, 16)
        Me.Lb_50.TabIndex = 72
        Me.Lb_50.Text = "Genero"
        '
        'BtBusca_50
        '
        Me.BtBusca_50.CL_Ancho = 0
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
        Me.BtBusca_50.CL_EsId = True
        Me.BtBusca_50.CL_Filtro = Nothing
        Me.BtBusca_50.cl_formu = Nothing
        Me.BtBusca_50.CL_hfecha = Nothing
        Me.BtBusca_50.cl_ListaW = Nothing
        Me.BtBusca_50.CL_xCentro = False
        Me.BtBusca_50.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_50.Location = New System.Drawing.Point(169, 7)
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
        Me.Lb_56.Location = New System.Drawing.Point(401, 72)
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
        Me.TxDato_56.Location = New System.Drawing.Point(453, 69)
        Me.TxDato_56.MiError = False
        Me.TxDato_56.Name = "TxDato_56"
        Me.TxDato_56.Orden = 0
        Me.TxDato_56.SaltoAlfinal = False
        Me.TxDato_56.Siguiente = 0
        Me.TxDato_56.Size = New System.Drawing.Size(89, 22)
        Me.TxDato_56.TabIndex = 79
        Me.TxDato_56.TeclaRepetida = False
        Me.TxDato_56.UltimoValorValidado = Nothing
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 131)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(944, 274)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
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
        Me.LbCampa.Location = New System.Drawing.Point(126, 5)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 116
        '
        'FrmParteSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 540)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmParteSemanal"
        Me.Text = "Parte Semanal"
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_50 As NetAgro.Lb
    Friend WithEvents BtBusca_50 As NetAgro.BtBusca
    Friend WithEvents TxDato_50 As NetAgro.TxDato
    Friend WithEvents Lb_50 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents TxDato_56 As NetAgro.TxDato
    Friend WithEvents Lb_56 As NetAgro.Lb
    Friend WithEvents TxDato_55 As NetAgro.TxDato
    Friend WithEvents Lb_55 As NetAgro.Lb
    Friend WithEvents TxDato_54 As NetAgro.TxDato
    Friend WithEvents Lb_54 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxDato_51 As NetAgro.TxDato
    Friend WithEvents Lb_51 As NetAgro.Lb
    Friend WithEvents BtBusca_51 As NetAgro.BtBusca
    Friend WithEvents Lbnom_51 As NetAgro.Lb
    Friend WithEvents Lb_57 As NetAgro.Lb
    Friend WithEvents TxDato_57 As NetAgro.TxDato
    Friend WithEvents Lb_nom52 As NetAgro.Lb
    Friend WithEvents TxDato_52 As NetAgro.TxDato
    Friend WithEvents Lb_52 As NetAgro.Lb
    Friend WithEvents BtBusca_52 As NetAgro.BtBusca
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents Lbnom_53 As NetAgro.Lb
    Friend WithEvents TxDato_53 As NetAgro.TxDato
    Friend WithEvents Lb_53 As NetAgro.Lb
    Friend WithEvents BtBusca_53 As NetAgro.BtBusca
    Friend WithEvents Lb_58 As NetAgro.Lb
    Friend WithEvents TxDato_58 As NetAgro.TxDato
    Friend WithEvents LbCampa As NetAgro.Lb

End Class
