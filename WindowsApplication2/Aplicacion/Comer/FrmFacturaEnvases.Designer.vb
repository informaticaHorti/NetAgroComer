<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturaEnvases

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturaEnvases))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.GridAlbaranes = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAlbaranes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtBuscaSerie = New NetAgro.BtBusca(Me.components)
        Me.LbNomRegimenIva = New NetAgro.Lb(Me.components)
        Me.BtBuscaRegimenIva = New NetAgro.BtBusca(Me.components)
        Me.TxIdRegimenIva = New NetAgro.TxDato(Me.components)
        Me.LbRegimenIva = New NetAgro.Lb(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbAsiento = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_0 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_4 = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxDato_5 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.LbTotEuros = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbTEnvases = New NetAgro.Lb(Me.components)
        Me.TxDato_41 = New NetAgro.TxDato(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.LbCuotaEnv = New NetAgro.Lb(Me.components)
        Me.LbCuotaReEnv = New NetAgro.Lb(Me.components)
        Me.Lb18 = New NetAgro.Lb(Me.components)
        Me.TxDato_44 = New NetAgro.TxDato(Me.components)
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GridCobros = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2.SuspendLayout()
        CType(Me.GridAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GridCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtSelTodos)
        Me.Panel2.Controls.Add(Me.BtSelNinguno)
        Me.Panel2.Controls.Add(Me.Lb12)
        Me.Panel2.Controls.Add(Me.GridAlbaranes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(925, 305)
        Me.Panel2.TabIndex = 73
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(865, 12)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100292
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(838, 12)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100293
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Blue
        Me.Lb12.Location = New System.Drawing.Point(14, 12)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(245, 23)
        Me.Lb12.TabIndex = 135
        Me.Lb12.Text = "Envases para facturar"
        '
        'GridAlbaranes
        '
        GridLevelNode1.RelationName = "Level1"
        Me.GridAlbaranes.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridAlbaranes.Location = New System.Drawing.Point(11, 38)
        Me.GridAlbaranes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridAlbaranes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridAlbaranes.MainView = Me.GridViewAlbaranes
        Me.GridAlbaranes.Name = "GridAlbaranes"
        Me.GridAlbaranes.Size = New System.Drawing.Size(882, 256)
        Me.GridAlbaranes.TabIndex = 124
        Me.GridAlbaranes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAlbaranes})
        '
        'GridViewAlbaranes
        '
        Me.GridViewAlbaranes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewAlbaranes.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewAlbaranes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewAlbaranes.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewAlbaranes.Appearance.Row.Options.UseFont = True
        Me.GridViewAlbaranes.GridControl = Me.GridAlbaranes
        Me.GridViewAlbaranes.Name = "GridViewAlbaranes"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(925, 98)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtBuscaSerie)
        Me.GroupBox1.Controls.Add(Me.LbNomRegimenIva)
        Me.GroupBox1.Controls.Add(Me.BtBuscaRegimenIva)
        Me.GroupBox1.Controls.Add(Me.TxIdRegimenIva)
        Me.GroupBox1.Controls.Add(Me.LbRegimenIva)
        Me.GroupBox1.Controls.Add(Me.BotonesAvance1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAlbaran)
        Me.GroupBox1.Controls.Add(Me.TxDato_0)
        Me.GroupBox1.Controls.Add(Me.Lbnom_4)
        Me.GroupBox1.Controls.Add(Me.Lb_1)
        Me.GroupBox1.Controls.Add(Me.TxDato_1)
        Me.GroupBox1.Controls.Add(Me.BtBuscaCliente)
        Me.GroupBox1.Controls.Add(Me.TxDato_5)
        Me.GroupBox1.Controls.Add(Me.Lb_4)
        Me.GroupBox1.Controls.Add(Me.Lb_2)
        Me.GroupBox1.Controls.Add(Me.TxDato_2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(923, 104)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Factura"
        '
        'BtBuscaSerie
        '
        Me.BtBuscaSerie.CL_Ancho = 0
        Me.BtBuscaSerie.CL_BuscaAlb = False
        Me.BtBuscaSerie.CL_campocodigo = Nothing
        Me.BtBuscaSerie.CL_camponombre = Nothing
        Me.BtBuscaSerie.CL_CampoOrden = "Nombre"
        Me.BtBuscaSerie.CL_ch1000 = False
        Me.BtBuscaSerie.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaSerie.CL_ControlAsociado = Nothing
        Me.BtBuscaSerie.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaSerie.CL_dfecha = Nothing
        Me.BtBuscaSerie.CL_Entidad = Nothing
        Me.BtBuscaSerie.CL_EsId = True
        Me.BtBuscaSerie.CL_Filtro = Nothing
        Me.BtBuscaSerie.cl_formu = Nothing
        Me.BtBuscaSerie.CL_hfecha = Nothing
        Me.BtBuscaSerie.cl_ListaW = Nothing
        Me.BtBuscaSerie.CL_xCentro = False
        Me.BtBuscaSerie.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaSerie.Location = New System.Drawing.Point(100, 15)
        Me.BtBuscaSerie.Name = "BtBuscaSerie"
        Me.BtBuscaSerie.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaSerie.TabIndex = 100424
        Me.BtBuscaSerie.UseVisualStyleBackColor = True
        '
        'LbNomRegimenIva
        '
        Me.LbNomRegimenIva.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomRegimenIva.CL_ControlAsociado = Nothing
        Me.LbNomRegimenIva.CL_ValorFijo = False
        Me.LbNomRegimenIva.ClForm = Nothing
        Me.LbNomRegimenIva.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomRegimenIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomRegimenIva.Location = New System.Drawing.Point(195, 69)
        Me.LbNomRegimenIva.Name = "LbNomRegimenIva"
        Me.LbNomRegimenIva.Size = New System.Drawing.Size(334, 19)
        Me.LbNomRegimenIva.TabIndex = 100423
        '
        'BtBuscaRegimenIva
        '
        Me.BtBuscaRegimenIva.CL_Ancho = 0
        Me.BtBuscaRegimenIva.CL_BuscaAlb = False
        Me.BtBuscaRegimenIva.CL_campocodigo = Nothing
        Me.BtBuscaRegimenIva.CL_camponombre = Nothing
        Me.BtBuscaRegimenIva.CL_CampoOrden = "Nombre"
        Me.BtBuscaRegimenIva.CL_ch1000 = False
        Me.BtBuscaRegimenIva.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaRegimenIva.CL_ControlAsociado = Nothing
        Me.BtBuscaRegimenIva.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaRegimenIva.CL_dfecha = Nothing
        Me.BtBuscaRegimenIva.CL_Entidad = Nothing
        Me.BtBuscaRegimenIva.CL_EsId = True
        Me.BtBuscaRegimenIva.CL_Filtro = Nothing
        Me.BtBuscaRegimenIva.cl_formu = Nothing
        Me.BtBuscaRegimenIva.CL_hfecha = Nothing
        Me.BtBuscaRegimenIva.cl_ListaW = Nothing
        Me.BtBuscaRegimenIva.CL_xCentro = False
        Me.BtBuscaRegimenIva.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaRegimenIva.Location = New System.Drawing.Point(158, 67)
        Me.BtBuscaRegimenIva.Name = "BtBuscaRegimenIva"
        Me.BtBuscaRegimenIva.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaRegimenIva.TabIndex = 100422
        Me.BtBuscaRegimenIva.UseVisualStyleBackColor = True
        '
        'TxIdRegimenIva
        '
        Me.TxIdRegimenIva.Autonumerico = False
        Me.TxIdRegimenIva.Buscando = False
        Me.TxIdRegimenIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIdRegimenIva.ClForm = Nothing
        Me.TxIdRegimenIva.ClParam = Nothing
        Me.TxIdRegimenIva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxIdRegimenIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdRegimenIva.GridLin = Nothing
        Me.TxIdRegimenIva.HaCambiado = False
        Me.TxIdRegimenIva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxIdRegimenIva.lbbusca = Nothing
        Me.TxIdRegimenIva.Location = New System.Drawing.Point(99, 67)
        Me.TxIdRegimenIva.MiError = False
        Me.TxIdRegimenIva.Name = "TxIdRegimenIva"
        Me.TxIdRegimenIva.Orden = 0
        Me.TxIdRegimenIva.SaltoAlfinal = False
        Me.TxIdRegimenIva.Siguiente = 0
        Me.TxIdRegimenIva.Size = New System.Drawing.Size(53, 22)
        Me.TxIdRegimenIva.TabIndex = 100421
        Me.TxIdRegimenIva.TeclaRepetida = False
        Me.TxIdRegimenIva.TxDatoFinalSemana = Nothing
        Me.TxIdRegimenIva.TxDatoInicioSemana = Nothing
        Me.TxIdRegimenIva.UltimoValorValidado = Nothing
        '
        'LbRegimenIva
        '
        Me.LbRegimenIva.AutoSize = True
        Me.LbRegimenIva.CL_ControlAsociado = Nothing
        Me.LbRegimenIva.CL_ValorFijo = False
        Me.LbRegimenIva.ClForm = Nothing
        Me.LbRegimenIva.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRegimenIva.ForeColor = System.Drawing.Color.Teal
        Me.LbRegimenIva.Location = New System.Drawing.Point(7, 69)
        Me.LbRegimenIva.Name = "LbRegimenIva"
        Me.LbRegimenIva.Size = New System.Drawing.Size(63, 16)
        Me.LbRegimenIva.TabIndex = 100420
        Me.LbRegimenIva.Text = "Reg Iva"
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(339, 17)
        Me.BotonesAvance1.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(147, 24)
        Me.BotonesAvance1.TabIndex = 100401
        Me.BotonesAvance1.Udato = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbAsiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(805, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 43)
        Me.GroupBox2.TabIndex = 100309
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asiento"
        '
        'LbAsiento
        '
        Me.LbAsiento.BackColor = System.Drawing.Color.White
        Me.LbAsiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAsiento.CL_ControlAsociado = Nothing
        Me.LbAsiento.CL_ValorFijo = False
        Me.LbAsiento.ClForm = Nothing
        Me.LbAsiento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsiento.ForeColor = System.Drawing.Color.Teal
        Me.LbAsiento.Location = New System.Drawing.Point(11, 14)
        Me.LbAsiento.Name = "LbAsiento"
        Me.LbAsiento.Size = New System.Drawing.Size(83, 21)
        Me.LbAsiento.TabIndex = 114
        Me.LbAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbejer)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(719, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(80, 43)
        Me.GroupBox3.TabIndex = 100307
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ejercicio"
        '
        'Lbejer
        '
        Me.Lbejer.BackColor = System.Drawing.Color.White
        Me.Lbejer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbejer.CL_ControlAsociado = Nothing
        Me.Lbejer.CL_ValorFijo = False
        Me.Lbejer.ClForm = Nothing
        Me.Lbejer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbejer.ForeColor = System.Drawing.Color.Teal
        Me.Lbejer.Location = New System.Drawing.Point(11, 14)
        Me.Lbejer.Name = "Lbejer"
        Me.Lbejer.Size = New System.Drawing.Size(36, 21)
        Me.Lbejer.TabIndex = 114
        Me.Lbejer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato_0
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = CType(resources.GetObject("BtBuscaAlbaran.Image"), System.Drawing.Image)
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(295, 16)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 189
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxDato_0
        '
        Me.TxDato_0.Autonumerico = False
        Me.TxDato_0.Buscando = False
        Me.TxDato_0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_0.ClForm = Nothing
        Me.TxDato_0.ClParam = Nothing
        Me.TxDato_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_0.GridLin = Nothing
        Me.TxDato_0.HaCambiado = False
        Me.TxDato_0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_0.lbbusca = Nothing
        Me.TxDato_0.Location = New System.Drawing.Point(137, 16)
        Me.TxDato_0.MiError = False
        Me.TxDato_0.Name = "TxDato_0"
        Me.TxDato_0.Orden = 0
        Me.TxDato_0.SaltoAlfinal = False
        Me.TxDato_0.Siguiente = 0
        Me.TxDato_0.Size = New System.Drawing.Size(47, 22)
        Me.TxDato_0.TabIndex = 187
        Me.TxDato_0.TeclaRepetida = False
        Me.TxDato_0.TxDatoFinalSemana = Nothing
        Me.TxDato_0.TxDatoInicioSemana = Nothing
        Me.TxDato_0.UltimoValorValidado = Nothing
        '
        'Lbnom_4
        '
        Me.Lbnom_4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_4.CL_ControlAsociado = Nothing
        Me.Lbnom_4.CL_ValorFijo = False
        Me.Lbnom_4.ClForm = Nothing
        Me.Lbnom_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_4.Location = New System.Drawing.Point(195, 43)
        Me.Lbnom_4.Name = "Lbnom_4"
        Me.Lbnom_4.Size = New System.Drawing.Size(431, 21)
        Me.Lbnom_4.TabIndex = 87
        '
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(8, 19)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(86, 16)
        Me.Lb_1.TabIndex = 84
        Me.Lb_1.Text = "Nº Factura"
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
        Me.TxDato_1.Location = New System.Drawing.Point(190, 16)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(101, 22)
        Me.TxDato_1.TabIndex = 83
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_Ancho = 0
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_campocodigo = Nothing
        Me.BtBuscaCliente.CL_camponombre = Nothing
        Me.BtBuscaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaCliente.CL_ch1000 = False
        Me.BtBuscaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCliente.CL_dfecha = Nothing
        Me.BtBuscaCliente.CL_Entidad = Nothing
        Me.BtBuscaCliente.CL_EsId = True
        Me.BtBuscaCliente.CL_Filtro = Nothing
        Me.BtBuscaCliente.cl_formu = Nothing
        Me.BtBuscaCliente.CL_hfecha = Nothing
        Me.BtBuscaCliente.cl_ListaW = Nothing
        Me.BtBuscaCliente.CL_xCentro = False
        Me.BtBuscaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCliente.Location = New System.Drawing.Point(158, 41)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 82
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
        '
        'TxDato_5
        '
        Me.TxDato_5.Autonumerico = False
        Me.TxDato_5.Buscando = False
        Me.TxDato_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_5.ClForm = Nothing
        Me.TxDato_5.ClParam = Nothing
        Me.TxDato_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_5.GridLin = Nothing
        Me.TxDato_5.HaCambiado = False
        Me.TxDato_5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_5.lbbusca = Nothing
        Me.TxDato_5.Location = New System.Drawing.Point(99, 41)
        Me.TxDato_5.MiError = False
        Me.TxDato_5.Name = "TxDato_5"
        Me.TxDato_5.Orden = 0
        Me.TxDato_5.SaltoAlfinal = False
        Me.TxDato_5.Siguiente = 0
        Me.TxDato_5.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_5.TabIndex = 81
        Me.TxDato_5.TeclaRepetida = False
        Me.TxDato_5.TxDatoFinalSemana = Nothing
        Me.TxDato_5.TxDatoInicioSemana = Nothing
        Me.TxDato_5.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(9, 43)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(59, 16)
        Me.Lb_4.TabIndex = 80
        Me.Lb_4.Text = "Cliente"
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(540, 18)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(52, 16)
        Me.Lb_2.TabIndex = 79
        Me.Lb_2.Text = "Fecha"
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
        Me.TxDato_2.Location = New System.Drawing.Point(598, 15)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(105, 22)
        Me.TxDato_2.TabIndex = 78
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'LbTotEuros
        '
        Me.LbTotEuros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTotEuros.CL_ControlAsociado = Nothing
        Me.LbTotEuros.CL_ValorFijo = False
        Me.LbTotEuros.ClForm = Nothing
        Me.LbTotEuros.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotEuros.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbTotEuros.Location = New System.Drawing.Point(736, 545)
        Me.LbTotEuros.Name = "LbTotEuros"
        Me.LbTotEuros.Size = New System.Drawing.Size(162, 23)
        Me.LbTotEuros.TabIndex = 100354
        Me.LbTotEuros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(607, 549)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(104, 16)
        Me.Lb9.TabIndex = 100353
        Me.Lb9.Text = "Total Factura"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(443, 419)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(121, 16)
        Me.Lb4.TabIndex = 100359
        Me.Lb4.Text = "Base Imponible"
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(570, 419)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(53, 16)
        Me.Lb10.TabIndex = 100361
        Me.Lb10.Text = "% Iva"
        '
        'LbTEnvases
        '
        Me.LbTEnvases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTEnvases.CL_ControlAsociado = Nothing
        Me.LbTEnvases.CL_ValorFijo = False
        Me.LbTEnvases.ClForm = Nothing
        Me.LbTEnvases.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTEnvases.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbTEnvases.Location = New System.Drawing.Point(445, 438)
        Me.LbTEnvases.Name = "LbTEnvases"
        Me.LbTEnvases.Size = New System.Drawing.Size(111, 23)
        Me.LbTEnvases.TabIndex = 100366
        Me.LbTEnvases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxDato_41
        '
        Me.TxDato_41.Autonumerico = False
        Me.TxDato_41.Buscando = False
        Me.TxDato_41.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_41.ClForm = Nothing
        Me.TxDato_41.ClParam = Nothing
        Me.TxDato_41.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_41.GridLin = Nothing
        Me.TxDato_41.HaCambiado = False
        Me.TxDato_41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_41.lbbusca = Nothing
        Me.TxDato_41.Location = New System.Drawing.Point(562, 438)
        Me.TxDato_41.MiError = False
        Me.TxDato_41.Name = "TxDato_41"
        Me.TxDato_41.Orden = 0
        Me.TxDato_41.SaltoAlfinal = False
        Me.TxDato_41.Siguiente = 0
        Me.TxDato_41.Size = New System.Drawing.Size(69, 22)
        Me.TxDato_41.TabIndex = 100369
        Me.TxDato_41.TeclaRepetida = False
        Me.TxDato_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxDato_41.TxDatoFinalSemana = Nothing
        Me.TxDato_41.TxDatoInicioSemana = Nothing
        Me.TxDato_41.UltimoValorValidado = Nothing
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(651, 419)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(79, 16)
        Me.Lb23.TabIndex = 100371
        Me.Lb23.Text = "Cuota Iva"
        '
        'LbCuotaEnv
        '
        Me.LbCuotaEnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCuotaEnv.CL_ControlAsociado = Nothing
        Me.LbCuotaEnv.CL_ValorFijo = False
        Me.LbCuotaEnv.ClForm = Nothing
        Me.LbCuotaEnv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuotaEnv.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbCuotaEnv.Location = New System.Drawing.Point(637, 438)
        Me.LbCuotaEnv.Name = "LbCuotaEnv"
        Me.LbCuotaEnv.Size = New System.Drawing.Size(92, 23)
        Me.LbCuotaEnv.TabIndex = 100372
        Me.LbCuotaEnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbCuotaReEnv
        '
        Me.LbCuotaReEnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCuotaReEnv.CL_ControlAsociado = Nothing
        Me.LbCuotaReEnv.CL_ValorFijo = False
        Me.LbCuotaReEnv.ClForm = Nothing
        Me.LbCuotaReEnv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuotaReEnv.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbCuotaReEnv.Location = New System.Drawing.Point(812, 438)
        Me.LbCuotaReEnv.Name = "LbCuotaReEnv"
        Me.LbCuotaReEnv.Size = New System.Drawing.Size(92, 23)
        Me.LbCuotaReEnv.TabIndex = 100380
        Me.LbCuotaReEnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb18
        '
        Me.Lb18.AutoSize = True
        Me.Lb18.CL_ControlAsociado = Nothing
        Me.Lb18.CL_ValorFijo = True
        Me.Lb18.ClForm = Nothing
        Me.Lb18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb18.ForeColor = System.Drawing.Color.Teal
        Me.Lb18.Location = New System.Drawing.Point(826, 419)
        Me.Lb18.Name = "Lb18"
        Me.Lb18.Size = New System.Drawing.Size(73, 16)
        Me.Lb18.TabIndex = 100379
        Me.Lb18.Text = "Cuota Re"
        '
        'TxDato_44
        '
        Me.TxDato_44.Autonumerico = False
        Me.TxDato_44.Buscando = False
        Me.TxDato_44.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_44.ClForm = Nothing
        Me.TxDato_44.ClParam = Nothing
        Me.TxDato_44.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_44.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_44.GridLin = Nothing
        Me.TxDato_44.HaCambiado = False
        Me.TxDato_44.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_44.lbbusca = Nothing
        Me.TxDato_44.Location = New System.Drawing.Point(737, 438)
        Me.TxDato_44.MiError = False
        Me.TxDato_44.Name = "TxDato_44"
        Me.TxDato_44.Orden = 0
        Me.TxDato_44.SaltoAlfinal = False
        Me.TxDato_44.Siguiente = 0
        Me.TxDato_44.Size = New System.Drawing.Size(69, 22)
        Me.TxDato_44.TabIndex = 100377
        Me.TxDato_44.TeclaRepetida = False
        Me.TxDato_44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxDato_44.TxDatoFinalSemana = Nothing
        Me.TxDato_44.TxDatoInicioSemana = Nothing
        Me.TxDato_44.UltimoValorValidado = Nothing
        '
        'Lb26
        '
        Me.Lb26.AutoSize = True
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = True
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.ForeColor = System.Drawing.Color.Teal
        Me.Lb26.Location = New System.Drawing.Point(745, 419)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(47, 16)
        Me.Lb26.TabIndex = 100374
        Me.Lb26.Text = "% Re"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GridCobros)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(11, 419)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(404, 158)
        Me.GroupBox6.TabIndex = 100402
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cobros"
        '
        'GridCobros
        '
        Me.GridCobros.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.GridCobros.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridCobros.Location = New System.Drawing.Point(3, 18)
        Me.GridCobros.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridCobros.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridCobros.MainView = Me.GridView
        Me.GridCobros.Name = "GridCobros"
        Me.GridCobros.Size = New System.Drawing.Size(398, 137)
        Me.GridCobros.TabIndex = 72
        Me.GridCobros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.GridControl = Me.GridCobros
        Me.GridView.Name = "GridView"
        '
        'FrmFacturaEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 629)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.LbCuotaReEnv)
        Me.Controls.Add(Me.Lb18)
        Me.Controls.Add(Me.TxDato_44)
        Me.Controls.Add(Me.Lb26)
        Me.Controls.Add(Me.LbCuotaEnv)
        Me.Controls.Add(Me.Lb23)
        Me.Controls.Add(Me.TxDato_41)
        Me.Controls.Add(Me.LbTEnvases)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.LbTotEuros)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmFacturaEnvases"
        Me.Text = "Facturacion envases"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.LbTotEuros, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.LbTEnvases, 0)
        Me.Controls.SetChildIndex(Me.TxDato_41, 0)
        Me.Controls.SetChildIndex(Me.Lb23, 0)
        Me.Controls.SetChildIndex(Me.LbCuotaEnv, 0)
        Me.Controls.SetChildIndex(Me.Lb26, 0)
        Me.Controls.SetChildIndex(Me.TxDato_44, 0)
        Me.Controls.SetChildIndex(Me.Lb18, 0)
        Me.Controls.SetChildIndex(Me.LbCuotaReEnv, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.GridCobros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents Lbnom_4 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents LbTotEuros As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_0 As NetAgro.TxDato
    Friend WithEvents GridAlbaranes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAlbaranes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents LbTEnvases As NetAgro.Lb
    Friend WithEvents TxDato_41 As NetAgro.TxDato
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents LbCuotaEnv As NetAgro.Lb
    Friend WithEvents LbCuotaReEnv As NetAgro.Lb
    Friend WithEvents Lb18 As NetAgro.Lb
    Friend WithEvents TxDato_44 As NetAgro.TxDato
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAsiento As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GridCobros As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents LbNomRegimenIva As NetAgro.Lb
    Friend WithEvents BtBuscaRegimenIva As NetAgro.BtBusca
    Friend WithEvents TxIdRegimenIva As NetAgro.TxDato
    Friend WithEvents LbRegimenIva As NetAgro.Lb
    Friend WithEvents BtBuscaSerie As NetAgro.BtBusca

End Class
