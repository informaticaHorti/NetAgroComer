<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoracionComision
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoracionComision))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.BtAnula = New NetAgro.ClButton()
        Me.btPrecios = New NetAgro.ClButton()
        Me.PanelGridFam = New System.Windows.Forms.Panel()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbHastaSal = New NetAgro.Lb(Me.components)
        Me.LbDesdeSal = New NetAgro.Lb(Me.components)
        Me.LbHastaEnt = New NetAgro.Lb(Me.components)
        Me.LbDesdeEnt = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbEjer = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LbNuParte = New NetAgro.Lb(Me.components)
        Me.TxNuParte = New NetAgro.TxDato(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbFechas = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.LbDiferenciaGen = New NetAgro.Lb(Me.components)
        Me.LbMediaGen = New NetAgro.Lb(Me.components)
        Me.LbKilosGen = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbDisponible = New NetAgro.Lb(Me.components)
        Me.LbPrecioAprox = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGenero = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbDiferencia = New NetAgro.Lb(Me.components)
        Me.LbPrecioLiquidacion = New NetAgro.Lb(Me.components)
        Me.LbNomCategoria = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.TxPrecioLiquidacion = New NetAgro.TxDato(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lb_MediaGen = New NetAgro.Lb(Me.components)
        Me.Lb_DiferenciaGen = New NetAgro.Lb(Me.components)
        Me.Lb_KilosGen = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        Me.PanelGridFam.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Barra)
        Me.Panel4.Controls.Add(Me.BtAnula)
        Me.Panel4.Controls.Add(Me.btPrecios)
        Me.Panel4.Controls.Add(Me.PanelGridFam)
        Me.Panel4.Controls.Add(Me.LbHastaSal)
        Me.Panel4.Controls.Add(Me.LbDesdeSal)
        Me.Panel4.Controls.Add(Me.LbHastaEnt)
        Me.Panel4.Controls.Add(Me.LbDesdeEnt)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.LbNuParte)
        Me.Panel4.Controls.Add(Me.TxNuParte)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.LbFechas)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1084, 155)
        Me.Panel4.TabIndex = 72
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(163, 125)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(222, 23)
        Me.Barra.TabIndex = 100329
        '
        'BtAnula
        '
        Me.BtAnula.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtAnula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAnula.Location = New System.Drawing.Point(13, 118)
        Me.BtAnula.Name = "BtAnula"
        Me.BtAnula.Orden = 0
        Me.BtAnula.PedirClave = True
        Me.BtAnula.Size = New System.Drawing.Size(129, 30)
        Me.BtAnula.TabIndex = 100328
        Me.BtAnula.Text = "Anular valoracion"
        Me.BtAnula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAnula.UseVisualStyleBackColor = True
        '
        'btPrecios
        '
        Me.btPrecios.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.btPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPrecios.Location = New System.Drawing.Point(13, 88)
        Me.btPrecios.Name = "btPrecios"
        Me.btPrecios.Orden = 0
        Me.btPrecios.PedirClave = True
        Me.btPrecios.Size = New System.Drawing.Size(129, 30)
        Me.btPrecios.TabIndex = 100327
        Me.btPrecios.Text = "Valorar "
        Me.btPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPrecios.UseVisualStyleBackColor = True
        '
        'PanelGridFam
        '
        Me.PanelGridFam.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelGridFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGridFam.Controls.Add(Me.Grid)
        Me.PanelGridFam.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelGridFam.Location = New System.Drawing.Point(425, 0)
        Me.PanelGridFam.Name = "PanelGridFam"
        Me.PanelGridFam.Size = New System.Drawing.Size(655, 151)
        Me.PanelGridFam.TabIndex = 100326
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(653, 149)
        Me.Grid.TabIndex = 72
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        '
        'LbHastaSal
        '
        Me.LbHastaSal.BackColor = System.Drawing.Color.White
        Me.LbHastaSal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbHastaSal.CL_ControlAsociado = Nothing
        Me.LbHastaSal.CL_ValorFijo = False
        Me.LbHastaSal.ClForm = Nothing
        Me.LbHastaSal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaSal.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaSal.Location = New System.Drawing.Point(274, 92)
        Me.LbHastaSal.Name = "LbHastaSal"
        Me.LbHastaSal.Size = New System.Drawing.Size(105, 22)
        Me.LbHastaSal.TabIndex = 100324
        Me.LbHastaSal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbDesdeSal
        '
        Me.LbDesdeSal.BackColor = System.Drawing.Color.White
        Me.LbDesdeSal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbDesdeSal.CL_ControlAsociado = Nothing
        Me.LbDesdeSal.CL_ValorFijo = False
        Me.LbDesdeSal.ClForm = Nothing
        Me.LbDesdeSal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeSal.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeSal.Location = New System.Drawing.Point(163, 92)
        Me.LbDesdeSal.Name = "LbDesdeSal"
        Me.LbDesdeSal.Size = New System.Drawing.Size(105, 22)
        Me.LbDesdeSal.TabIndex = 100324
        Me.LbDesdeSal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbHastaEnt
        '
        Me.LbHastaEnt.BackColor = System.Drawing.Color.White
        Me.LbHastaEnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbHastaEnt.CL_ControlAsociado = Nothing
        Me.LbHastaEnt.CL_ValorFijo = False
        Me.LbHastaEnt.ClForm = Nothing
        Me.LbHastaEnt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaEnt.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaEnt.Location = New System.Drawing.Point(274, 58)
        Me.LbHastaEnt.Name = "LbHastaEnt"
        Me.LbHastaEnt.Size = New System.Drawing.Size(105, 22)
        Me.LbHastaEnt.TabIndex = 100324
        Me.LbHastaEnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbDesdeEnt
        '
        Me.LbDesdeEnt.BackColor = System.Drawing.Color.White
        Me.LbDesdeEnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbDesdeEnt.CL_ControlAsociado = Nothing
        Me.LbDesdeEnt.CL_ValorFijo = False
        Me.LbDesdeEnt.ClForm = Nothing
        Me.LbDesdeEnt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeEnt.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeEnt.Location = New System.Drawing.Point(163, 58)
        Me.LbDesdeEnt.Name = "LbDesdeEnt"
        Me.LbDesdeEnt.Size = New System.Drawing.Size(105, 22)
        Me.LbDesdeEnt.TabIndex = 100323
        Me.LbDesdeEnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbEjer)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(299, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 43)
        Me.GroupBox2.TabIndex = 100319
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ejercicio"
        '
        'LbEjer
        '
        Me.LbEjer.BackColor = System.Drawing.Color.White
        Me.LbEjer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbEjer.CL_ControlAsociado = Nothing
        Me.LbEjer.CL_ValorFijo = False
        Me.LbEjer.ClForm = Nothing
        Me.LbEjer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjer.ForeColor = System.Drawing.Color.Teal
        Me.LbEjer.Location = New System.Drawing.Point(11, 14)
        Me.LbEjer.Name = "LbEjer"
        Me.LbEjer.Size = New System.Drawing.Size(36, 21)
        Me.LbEjer.TabIndex = 114
        Me.LbEjer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(121, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 153
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'LbNuParte
        '
        Me.LbNuParte.AutoSize = True
        Me.LbNuParte.CL_ControlAsociado = Nothing
        Me.LbNuParte.CL_ValorFijo = False
        Me.LbNuParte.ClForm = Nothing
        Me.LbNuParte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuParte.ForeColor = System.Drawing.Color.Teal
        Me.LbNuParte.Location = New System.Drawing.Point(27, 18)
        Me.LbNuParte.Name = "LbNuParte"
        Me.LbNuParte.Size = New System.Drawing.Size(66, 16)
        Me.LbNuParte.TabIndex = 100281
        Me.LbNuParte.Text = "N. Parte"
        '
        'TxNuParte
        '
        Me.TxNuParte.Autonumerico = False
        Me.TxNuParte.Buscando = False
        Me.TxNuParte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNuParte.ClForm = Nothing
        Me.TxNuParte.ClParam = Nothing
        Me.TxNuParte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNuParte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNuParte.GridLin = Nothing
        Me.TxNuParte.HaCambiado = False
        Me.TxNuParte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNuParte.lbbusca = Nothing
        Me.TxNuParte.Location = New System.Drawing.Point(163, 16)
        Me.TxNuParte.MiError = False
        Me.TxNuParte.Name = "TxNuParte"
        Me.TxNuParte.Orden = 0
        Me.TxNuParte.SaltoAlfinal = False
        Me.TxNuParte.Siguiente = 0
        Me.TxNuParte.Size = New System.Drawing.Size(79, 22)
        Me.TxNuParte.TabIndex = 100280
        Me.TxNuParte.TeclaRepetida = False
        Me.TxNuParte.TxDatoFinalSemana = Nothing
        Me.TxNuParte.TxDatoInicioSemana = Nothing
        Me.TxNuParte.UltimoValorValidado = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(99, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbFechas
        '
        Me.LbFechas.AutoSize = True
        Me.LbFechas.CL_ControlAsociado = Nothing
        Me.LbFechas.CL_ValorFijo = False
        Me.LbFechas.ClForm = Nothing
        Me.LbFechas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechas.ForeColor = System.Drawing.Color.Teal
        Me.LbFechas.Location = New System.Drawing.Point(16, 61)
        Me.LbFechas.Name = "LbFechas"
        Me.LbFechas.Size = New System.Drawing.Size(141, 16)
        Me.LbFechas.TabIndex = 100279
        Me.LbFechas.Text = "Fechas (Ent / Sal)"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lb13)
        Me.Panel2.Controls.Add(Me.LbDiferenciaGen)
        Me.Panel2.Controls.Add(Me.LbMediaGen)
        Me.Panel2.Controls.Add(Me.LbKilosGen)
        Me.Panel2.Controls.Add(Me.LbKilos)
        Me.Panel2.Controls.Add(Me.Lb8)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.LbDisponible)
        Me.Panel2.Controls.Add(Me.LbPrecioAprox)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.LbGenero)
        Me.Panel2.Controls.Add(Me.LbNomGenero)
        Me.Panel2.Controls.Add(Me.Lb10)
        Me.Panel2.Controls.Add(Me.LbCategoria)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.LbDiferencia)
        Me.Panel2.Controls.Add(Me.LbPrecioLiquidacion)
        Me.Panel2.Controls.Add(Me.LbNomCategoria)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Controls.Add(Me.TxPrecioLiquidacion)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 437)
        Me.Panel2.TabIndex = 128
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Black
        Me.Lb13.Location = New System.Drawing.Point(13, 34)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(144, 14)
        Me.Lb13.TabIndex = 176
        Me.Lb13.Text = "Resumen de Género:"
        '
        'LbDiferenciaGen
        '
        Me.LbDiferenciaGen.BackColor = System.Drawing.Color.White
        Me.LbDiferenciaGen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbDiferenciaGen.CL_ControlAsociado = Nothing
        Me.LbDiferenciaGen.CL_ValorFijo = False
        Me.LbDiferenciaGen.ClForm = Nothing
        Me.LbDiferenciaGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDiferenciaGen.ForeColor = System.Drawing.Color.Teal
        Me.LbDiferenciaGen.Location = New System.Drawing.Point(273, 74)
        Me.LbDiferenciaGen.Name = "LbDiferenciaGen"
        Me.LbDiferenciaGen.Size = New System.Drawing.Size(106, 22)
        Me.LbDiferenciaGen.TabIndex = 174
        Me.LbDiferenciaGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbMediaGen
        '
        Me.LbMediaGen.BackColor = System.Drawing.Color.White
        Me.LbMediaGen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbMediaGen.CL_ControlAsociado = Nothing
        Me.LbMediaGen.CL_ValorFijo = False
        Me.LbMediaGen.ClForm = Nothing
        Me.LbMediaGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMediaGen.ForeColor = System.Drawing.Color.Teal
        Me.LbMediaGen.Location = New System.Drawing.Point(155, 74)
        Me.LbMediaGen.Name = "LbMediaGen"
        Me.LbMediaGen.Size = New System.Drawing.Size(106, 22)
        Me.LbMediaGen.TabIndex = 172
        Me.LbMediaGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKilosGen
        '
        Me.LbKilosGen.BackColor = System.Drawing.Color.White
        Me.LbKilosGen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKilosGen.CL_ControlAsociado = Nothing
        Me.LbKilosGen.CL_ValorFijo = False
        Me.LbKilosGen.ClForm = Nothing
        Me.LbKilosGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosGen.ForeColor = System.Drawing.Color.Teal
        Me.LbKilosGen.Location = New System.Drawing.Point(39, 74)
        Me.LbKilosGen.Name = "LbKilosGen"
        Me.LbKilosGen.Size = New System.Drawing.Size(90, 22)
        Me.LbKilosGen.TabIndex = 170
        Me.LbKilosGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.Color.White
        Me.LbKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(448, 74)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(90, 22)
        Me.LbKilos.TabIndex = 162
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(472, 55)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(42, 16)
        Me.Lb8.TabIndex = 161
        Me.Lb8.Text = "Kilos"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(579, 55)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(83, 16)
        Me.Lb5.TabIndex = 160
        Me.Lb5.Text = "Disponible"
        '
        'LbDisponible
        '
        Me.LbDisponible.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDisponible.CL_ControlAsociado = Nothing
        Me.LbDisponible.CL_ValorFijo = False
        Me.LbDisponible.ClForm = Nothing
        Me.LbDisponible.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDisponible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDisponible.Location = New System.Drawing.Point(556, 74)
        Me.LbDisponible.Name = "LbDisponible"
        Me.LbDisponible.Size = New System.Drawing.Size(127, 23)
        Me.LbDisponible.TabIndex = 159
        Me.LbDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbPrecioAprox
        '
        Me.LbPrecioAprox.BackColor = System.Drawing.Color.White
        Me.LbPrecioAprox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbPrecioAprox.CL_ControlAsociado = Nothing
        Me.LbPrecioAprox.CL_ValorFijo = False
        Me.LbPrecioAprox.ClForm = Nothing
        Me.LbPrecioAprox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecioAprox.ForeColor = System.Drawing.Color.Teal
        Me.LbPrecioAprox.Location = New System.Drawing.Point(702, 74)
        Me.LbPrecioAprox.Name = "LbPrecioAprox"
        Me.LbPrecioAprox.Size = New System.Drawing.Size(90, 22)
        Me.LbPrecioAprox.TabIndex = 158
        Me.LbPrecioAprox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(695, 55)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(105, 16)
        Me.Lb3.TabIndex = 157
        Me.Lb3.Text = "Precio Aprox."
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.Color.White
        Me.LbGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = False
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(95, 9)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(53, 22)
        Me.LbGenero.TabIndex = 156
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbNomGenero
        '
        Me.LbNomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGenero.CL_ControlAsociado = Nothing
        Me.LbNomGenero.CL_ValorFijo = False
        Me.LbNomGenero.ClForm = Nothing
        Me.LbNomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGenero.Location = New System.Drawing.Point(154, 9)
        Me.LbNomGenero.Name = "LbNomGenero"
        Me.LbNomGenero.Size = New System.Drawing.Size(505, 23)
        Me.LbNomGenero.TabIndex = 155
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(10, 12)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(73, 16)
        Me.Lb10.TabIndex = 154
        Me.Lb10.Text = "Producto"
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.Color.White
        Me.LbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = False
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Teal
        Me.LbCategoria.Location = New System.Drawing.Point(784, 8)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(53, 22)
        Me.LbCategoria.TabIndex = 150
        Me.LbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(950, 55)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(81, 16)
        Me.Lb7.TabIndex = 148
        Me.Lb7.Text = "Diferencia"
        '
        'LbDiferencia
        '
        Me.LbDiferencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDiferencia.CL_ControlAsociado = Nothing
        Me.LbDiferencia.CL_ValorFijo = False
        Me.LbDiferencia.ClForm = Nothing
        Me.LbDiferencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDiferencia.Location = New System.Drawing.Point(927, 74)
        Me.LbDiferencia.Name = "LbDiferencia"
        Me.LbDiferencia.Size = New System.Drawing.Size(127, 23)
        Me.LbDiferencia.TabIndex = 147
        Me.LbDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbPrecioLiquidacion
        '
        Me.LbPrecioLiquidacion.AutoSize = True
        Me.LbPrecioLiquidacion.CL_ControlAsociado = Nothing
        Me.LbPrecioLiquidacion.CL_ValorFijo = True
        Me.LbPrecioLiquidacion.ClForm = Nothing
        Me.LbPrecioLiquidacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecioLiquidacion.ForeColor = System.Drawing.Color.Teal
        Me.LbPrecioLiquidacion.Location = New System.Drawing.Point(810, 55)
        Me.LbPrecioLiquidacion.Name = "LbPrecioLiquidacion"
        Me.LbPrecioLiquidacion.Size = New System.Drawing.Size(105, 16)
        Me.LbPrecioLiquidacion.TabIndex = 145
        Me.LbPrecioLiquidacion.Text = "Precio Liquid."
        '
        'LbNomCategoria
        '
        Me.LbNomCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategoria.CL_ControlAsociado = Nothing
        Me.LbNomCategoria.CL_ValorFijo = False
        Me.LbNomCategoria.ClForm = Nothing
        Me.LbNomCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategoria.Location = New System.Drawing.Point(849, 8)
        Me.LbNomCategoria.Name = "LbNomCategoria"
        Me.LbNomCategoria.Size = New System.Drawing.Size(213, 23)
        Me.LbNomCategoria.TabIndex = 143
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(699, 11)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(79, 16)
        Me.Lb4.TabIndex = 141
        Me.Lb4.Text = "Categoria"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(10, 110)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1067, 320)
        Me.ClGrid1.TabIndex = 109
        Me.ClGrid1.UltimoControl = 0
        '
        'TxPrecioLiquidacion
        '
        Me.TxPrecioLiquidacion.Autonumerico = False
        Me.TxPrecioLiquidacion.Buscando = False
        Me.TxPrecioLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPrecioLiquidacion.ClForm = Nothing
        Me.TxPrecioLiquidacion.ClParam = Nothing
        Me.TxPrecioLiquidacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPrecioLiquidacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPrecioLiquidacion.GridLin = Nothing
        Me.TxPrecioLiquidacion.HaCambiado = False
        Me.TxPrecioLiquidacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPrecioLiquidacion.lbbusca = Nothing
        Me.TxPrecioLiquidacion.Location = New System.Drawing.Point(817, 74)
        Me.TxPrecioLiquidacion.MiError = False
        Me.TxPrecioLiquidacion.Name = "TxPrecioLiquidacion"
        Me.TxPrecioLiquidacion.Orden = 0
        Me.TxPrecioLiquidacion.SaltoAlfinal = False
        Me.TxPrecioLiquidacion.Siguiente = 0
        Me.TxPrecioLiquidacion.Size = New System.Drawing.Size(90, 22)
        Me.TxPrecioLiquidacion.TabIndex = 133
        Me.TxPrecioLiquidacion.TeclaRepetida = False
        Me.TxPrecioLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPrecioLiquidacion.TxDatoFinalSemana = Nothing
        Me.TxPrecioLiquidacion.TxDatoInicioSemana = Nothing
        Me.TxPrecioLiquidacion.UltimoValorValidado = Nothing
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Lb_MediaGen)
        Me.Panel3.Controls.Add(Me.Lb_DiferenciaGen)
        Me.Panel3.Controls.Add(Me.Lb_KilosGen)
        Me.Panel3.Location = New System.Drawing.Point(15, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 56)
        Me.Panel3.TabIndex = 175
        '
        'Lb_MediaGen
        '
        Me.Lb_MediaGen.AutoSize = True
        Me.Lb_MediaGen.BackColor = System.Drawing.Color.Transparent
        Me.Lb_MediaGen.CL_ControlAsociado = Nothing
        Me.Lb_MediaGen.CL_ValorFijo = True
        Me.Lb_MediaGen.ClForm = Nothing
        Me.Lb_MediaGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_MediaGen.ForeColor = System.Drawing.Color.Teal
        Me.Lb_MediaGen.Location = New System.Drawing.Point(171, 7)
        Me.Lb_MediaGen.Name = "Lb_MediaGen"
        Me.Lb_MediaGen.Size = New System.Drawing.Size(51, 16)
        Me.Lb_MediaGen.TabIndex = 175
        Me.Lb_MediaGen.Text = "Media"
        '
        'Lb_DiferenciaGen
        '
        Me.Lb_DiferenciaGen.AutoSize = True
        Me.Lb_DiferenciaGen.BackColor = System.Drawing.Color.Transparent
        Me.Lb_DiferenciaGen.CL_ControlAsociado = Nothing
        Me.Lb_DiferenciaGen.CL_ValorFijo = True
        Me.Lb_DiferenciaGen.ClForm = Nothing
        Me.Lb_DiferenciaGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_DiferenciaGen.ForeColor = System.Drawing.Color.Teal
        Me.Lb_DiferenciaGen.Location = New System.Drawing.Point(273, 7)
        Me.Lb_DiferenciaGen.Name = "Lb_DiferenciaGen"
        Me.Lb_DiferenciaGen.Size = New System.Drawing.Size(81, 16)
        Me.Lb_DiferenciaGen.TabIndex = 176
        Me.Lb_DiferenciaGen.Text = "Diferencia"
        '
        'Lb_KilosGen
        '
        Me.Lb_KilosGen.AutoSize = True
        Me.Lb_KilosGen.BackColor = System.Drawing.Color.Transparent
        Me.Lb_KilosGen.CL_ControlAsociado = Nothing
        Me.Lb_KilosGen.CL_ValorFijo = True
        Me.Lb_KilosGen.ClForm = Nothing
        Me.Lb_KilosGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_KilosGen.ForeColor = System.Drawing.Color.Teal
        Me.Lb_KilosGen.Location = New System.Drawing.Point(48, 7)
        Me.Lb_KilosGen.Name = "Lb_KilosGen"
        Me.Lb_KilosGen.Size = New System.Drawing.Size(42, 16)
        Me.Lb_KilosGen.TabIndex = 174
        Me.Lb_KilosGen.Text = "Kilos"
        '
        'FrmValoracionComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 646)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValoracionComision"
        Me.Text = "Valoración entradas  Comisión"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelGridFam.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbNomCategoria As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxPrecioLiquidacion As NetAgro.TxDato
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbDiferencia As NetAgro.Lb
    Friend WithEvents LbPrecioLiquidacion As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents LbNuParte As NetAgro.Lb
    Friend WithEvents TxNuParte As NetAgro.TxDato
    Friend WithEvents LbFechas As NetAgro.Lb
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents LbNomGenero As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbEjer As NetAgro.Lb
    Friend WithEvents LbDesdeEnt As NetAgro.Lb
    Friend WithEvents LbHastaEnt As NetAgro.Lb
    Friend WithEvents LbHastaSal As NetAgro.Lb
    Friend WithEvents LbDesdeSal As NetAgro.Lb
    Friend WithEvents LbPrecioAprox As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbDisponible As NetAgro.Lb
    Friend WithEvents PanelGridFam As System.Windows.Forms.Panel
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtAnula As NetAgro.ClButton
    Friend WithEvents btPrecios As NetAgro.ClButton
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents LbDiferenciaGen As NetAgro.Lb
    Friend WithEvents LbMediaGen As NetAgro.Lb
    Friend WithEvents LbKilosGen As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lb_DiferenciaGen As NetAgro.Lb
    Friend WithEvents Lb_MediaGen As NetAgro.Lb
    Friend WithEvents Lb_KilosGen As NetAgro.Lb

End Class
