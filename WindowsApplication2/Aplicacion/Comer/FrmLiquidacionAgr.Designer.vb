<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidacionAgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidacionAgr))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbTransferencia = New System.Windows.Forms.RadioButton()
        Me.RbPagare = New System.Windows.Forms.RadioButton()
        Me.rbTalon = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxFechaVto = New NetAgro.TxDato(Me.components)
        Me.LbFechaVto = New NetAgro.Lb(Me.components)
        Me.LbNom_TipoDoc = New NetAgro.Lb(Me.components)
        Me.TxTipoDoc = New NetAgro.TxDato(Me.components)
        Me.BtBuscaTipoDoc = New NetAgro.BtBusca(Me.components)
        Me.LbTipoDoc = New NetAgro.Lb(Me.components)
        Me.LbNom_SitCartera = New NetAgro.Lb(Me.components)
        Me.TxSitCartera = New NetAgro.TxDato(Me.components)
        Me.BtBuscaSitCartera = New NetAgro.BtBusca(Me.components)
        Me.LbSitCartera = New NetAgro.Lb(Me.components)
        Me.LbTalon = New NetAgro.Lb(Me.components)
        Me.TxTalon = New NetAgro.TxDato(Me.components)
        Me.LbNomBanco = New NetAgro.Lb(Me.components)
        Me.BtBanco = New NetAgro.BtBusca(Me.components)
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.LbAfecha = New NetAgro.Lb(Me.components)
        Me.TxAfecha = New NetAgro.TxDato(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.LbDfecha = New NetAgro.Lb(Me.components)
        Me.TxDFecha = New NetAgro.TxDato(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbAsiento = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbNuCTB = New NetAgro.Lb(Me.components)
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxSerie = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.LbFactura = New NetAgro.Lb(Me.components)
        Me.TxNuliqui = New NetAgro.TxDato(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxSaldo = New NetAgro.TxDato(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbResultado = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.LbPortes = New NetAgro.Lb(Me.components)
        Me.TxPortes = New NetAgro.TxDato(Me.components)
        Me.LbSuministros = New NetAgro.Lb(Me.components)
        Me.TxSuministros = New NetAgro.TxDato(Me.components)
        Me.LbAnticipos = New NetAgro.Lb(Me.components)
        Me.TxAnticipos = New NetAgro.TxDato(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbImpFacturas = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.LbTalon)
        Me.GroupBox1.Controls.Add(Me.TxTalon)
        Me.GroupBox1.Controls.Add(Me.LbNomBanco)
        Me.GroupBox1.Controls.Add(Me.BtBanco)
        Me.GroupBox1.Controls.Add(Me.LbBanco)
        Me.GroupBox1.Controls.Add(Me.TxBanco)
        Me.GroupBox1.Controls.Add(Me.LbAfecha)
        Me.GroupBox1.Controls.Add(Me.TxAfecha)
        Me.GroupBox1.Controls.Add(Me.LbCodigo)
        Me.GroupBox1.Controls.Add(Me.LbDfecha)
        Me.GroupBox1.Controls.Add(Me.TxDFecha)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAlbaran)
        Me.GroupBox1.Controls.Add(Me.TxSerie)
        Me.GroupBox1.Controls.Add(Me.LbnomAgr1)
        Me.GroupBox1.Controls.Add(Me.LbFactura)
        Me.GroupBox1.Controls.Add(Me.TxNuliqui)
        Me.GroupBox1.Controls.Add(Me.LbAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.TxFecha)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 233)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos liquidación"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.RbTransferencia)
        Me.GroupBox4.Controls.Add(Me.RbPagare)
        Me.GroupBox4.Controls.Add(Me.rbTalon)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1036, 99)
        Me.GroupBox4.TabIndex = 100328
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de pago"
        '
        'RbTransferencia
        '
        Me.RbTransferencia.AutoSize = True
        Me.RbTransferencia.ForeColor = System.Drawing.Color.Black
        Me.RbTransferencia.Location = New System.Drawing.Point(168, 22)
        Me.RbTransferencia.Name = "RbTransferencia"
        Me.RbTransferencia.Size = New System.Drawing.Size(125, 20)
        Me.RbTransferencia.TabIndex = 100309
        Me.RbTransferencia.Text = "Transferencia"
        Me.RbTransferencia.UseVisualStyleBackColor = True
        '
        'RbPagare
        '
        Me.RbPagare.AutoSize = True
        Me.RbPagare.ForeColor = System.Drawing.Color.Black
        Me.RbPagare.Location = New System.Drawing.Point(84, 22)
        Me.RbPagare.Name = "RbPagare"
        Me.RbPagare.Size = New System.Drawing.Size(77, 20)
        Me.RbPagare.TabIndex = 100308
        Me.RbPagare.Text = "Pagaré"
        Me.RbPagare.UseVisualStyleBackColor = True
        '
        'rbTalon
        '
        Me.rbTalon.AutoSize = True
        Me.rbTalon.Checked = True
        Me.rbTalon.ForeColor = System.Drawing.Color.Black
        Me.rbTalon.Location = New System.Drawing.Point(11, 22)
        Me.rbTalon.Name = "rbTalon"
        Me.rbTalon.Size = New System.Drawing.Size(65, 20)
        Me.rbTalon.TabIndex = 100307
        Me.rbTalon.TabStop = True
        Me.rbTalon.Text = "Talon"
        Me.rbTalon.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxFechaVto)
        Me.Panel5.Controls.Add(Me.LbFechaVto)
        Me.Panel5.Controls.Add(Me.LbNom_TipoDoc)
        Me.Panel5.Controls.Add(Me.TxTipoDoc)
        Me.Panel5.Controls.Add(Me.BtBuscaTipoDoc)
        Me.Panel5.Controls.Add(Me.LbTipoDoc)
        Me.Panel5.Controls.Add(Me.LbNom_SitCartera)
        Me.Panel5.Controls.Add(Me.TxSitCartera)
        Me.Panel5.Controls.Add(Me.BtBuscaSitCartera)
        Me.Panel5.Controls.Add(Me.LbSitCartera)
        Me.Panel5.Location = New System.Drawing.Point(11, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1019, 42)
        Me.Panel5.TabIndex = 100304
        '
        'TxFechaVto
        '
        Me.TxFechaVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxFechaVto.Autonumerico = False
        Me.TxFechaVto.Buscando = False
        Me.TxFechaVto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaVto.ClForm = Nothing
        Me.TxFechaVto.ClParam = Nothing
        Me.TxFechaVto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaVto.GridLin = Nothing
        Me.TxFechaVto.HaCambiado = False
        Me.TxFechaVto.lbbusca = Nothing
        Me.TxFechaVto.Location = New System.Drawing.Point(93, 8)
        Me.TxFechaVto.MiError = False
        Me.TxFechaVto.Name = "TxFechaVto"
        Me.TxFechaVto.Orden = 0
        Me.TxFechaVto.SaltoAlfinal = False
        Me.TxFechaVto.Siguiente = 0
        Me.TxFechaVto.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaVto.TabIndex = 100329
        Me.TxFechaVto.TeclaRepetida = False
        Me.TxFechaVto.TxDatoFinalSemana = Nothing
        Me.TxFechaVto.TxDatoInicioSemana = Nothing
        Me.TxFechaVto.UltimoValorValidado = Nothing
        '
        'LbFechaVto
        '
        Me.LbFechaVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbFechaVto.AutoSize = True
        Me.LbFechaVto.CL_ControlAsociado = Nothing
        Me.LbFechaVto.CL_ValorFijo = True
        Me.LbFechaVto.ClForm = Nothing
        Me.LbFechaVto.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaVto.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaVto.Location = New System.Drawing.Point(9, 11)
        Me.LbFechaVto.Name = "LbFechaVto"
        Me.LbFechaVto.Size = New System.Drawing.Size(78, 16)
        Me.LbFechaVto.TabIndex = 100327
        Me.LbFechaVto.Text = "Fecha Vto"
        '
        'LbNom_TipoDoc
        '
        Me.LbNom_TipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNom_TipoDoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom_TipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_TipoDoc.CL_ControlAsociado = Nothing
        Me.LbNom_TipoDoc.CL_ValorFijo = False
        Me.LbNom_TipoDoc.ClForm = Nothing
        Me.LbNom_TipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_TipoDoc.Location = New System.Drawing.Point(804, 8)
        Me.LbNom_TipoDoc.Name = "LbNom_TipoDoc"
        Me.LbNom_TipoDoc.Size = New System.Drawing.Size(204, 23)
        Me.LbNom_TipoDoc.TabIndex = 100326
        Me.LbNom_TipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxTipoDoc
        '
        Me.TxTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxTipoDoc.Autonumerico = False
        Me.TxTipoDoc.Buscando = False
        Me.TxTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipoDoc.ClForm = Nothing
        Me.TxTipoDoc.ClParam = Nothing
        Me.TxTipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipoDoc.GridLin = Nothing
        Me.TxTipoDoc.HaCambiado = False
        Me.TxTipoDoc.lbbusca = Nothing
        Me.TxTipoDoc.Location = New System.Drawing.Point(721, 8)
        Me.TxTipoDoc.MiError = False
        Me.TxTipoDoc.Name = "TxTipoDoc"
        Me.TxTipoDoc.Orden = 0
        Me.TxTipoDoc.SaltoAlfinal = False
        Me.TxTipoDoc.Siguiente = 0
        Me.TxTipoDoc.Size = New System.Drawing.Size(38, 22)
        Me.TxTipoDoc.TabIndex = 100325
        Me.TxTipoDoc.TeclaRepetida = False
        Me.TxTipoDoc.TxDatoFinalSemana = Nothing
        Me.TxTipoDoc.TxDatoInicioSemana = Nothing
        Me.TxTipoDoc.UltimoValorValidado = Nothing
        '
        'BtBuscaTipoDoc
        '
        Me.BtBuscaTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtBuscaTipoDoc.CL_Ancho = 0
        Me.BtBuscaTipoDoc.CL_BuscaAlb = False
        Me.BtBuscaTipoDoc.CL_campocodigo = Nothing
        Me.BtBuscaTipoDoc.CL_camponombre = Nothing
        Me.BtBuscaTipoDoc.CL_CampoOrden = "Nombre"
        Me.BtBuscaTipoDoc.CL_ch1000 = False
        Me.BtBuscaTipoDoc.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTipoDoc.CL_ControlAsociado = Nothing
        Me.BtBuscaTipoDoc.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTipoDoc.CL_dfecha = Nothing
        Me.BtBuscaTipoDoc.CL_Entidad = Nothing
        Me.BtBuscaTipoDoc.CL_EsId = True
        Me.BtBuscaTipoDoc.CL_Filtro = Nothing
        Me.BtBuscaTipoDoc.cl_formu = Nothing
        Me.BtBuscaTipoDoc.CL_hfecha = Nothing
        Me.BtBuscaTipoDoc.cl_ListaW = Nothing
        Me.BtBuscaTipoDoc.CL_xCentro = False
        Me.BtBuscaTipoDoc.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTipoDoc.Location = New System.Drawing.Point(765, 8)
        Me.BtBuscaTipoDoc.Name = "BtBuscaTipoDoc"
        Me.BtBuscaTipoDoc.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTipoDoc.TabIndex = 100324
        Me.BtBuscaTipoDoc.UseVisualStyleBackColor = True
        '
        'LbTipoDoc
        '
        Me.LbTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTipoDoc.AutoSize = True
        Me.LbTipoDoc.CL_ControlAsociado = Nothing
        Me.LbTipoDoc.CL_ValorFijo = True
        Me.LbTipoDoc.ClForm = Nothing
        Me.LbTipoDoc.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoDoc.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoDoc.Location = New System.Drawing.Point(650, 11)
        Me.LbTipoDoc.Name = "LbTipoDoc"
        Me.LbTipoDoc.Size = New System.Drawing.Size(67, 16)
        Me.LbTipoDoc.TabIndex = 100323
        Me.LbTipoDoc.Text = "Tipo doc"
        '
        'LbNom_SitCartera
        '
        Me.LbNom_SitCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNom_SitCartera.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom_SitCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_SitCartera.CL_ControlAsociado = Nothing
        Me.LbNom_SitCartera.CL_ValorFijo = False
        Me.LbNom_SitCartera.ClForm = Nothing
        Me.LbNom_SitCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_SitCartera.Location = New System.Drawing.Point(413, 8)
        Me.LbNom_SitCartera.Name = "LbNom_SitCartera"
        Me.LbNom_SitCartera.Size = New System.Drawing.Size(204, 23)
        Me.LbNom_SitCartera.TabIndex = 100322
        Me.LbNom_SitCartera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxSitCartera
        '
        Me.TxSitCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxSitCartera.Autonumerico = False
        Me.TxSitCartera.Buscando = False
        Me.TxSitCartera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSitCartera.ClForm = Nothing
        Me.TxSitCartera.ClParam = Nothing
        Me.TxSitCartera.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSitCartera.GridLin = Nothing
        Me.TxSitCartera.HaCambiado = False
        Me.TxSitCartera.lbbusca = Nothing
        Me.TxSitCartera.Location = New System.Drawing.Point(330, 8)
        Me.TxSitCartera.MiError = False
        Me.TxSitCartera.Name = "TxSitCartera"
        Me.TxSitCartera.Orden = 0
        Me.TxSitCartera.SaltoAlfinal = False
        Me.TxSitCartera.Siguiente = 0
        Me.TxSitCartera.Size = New System.Drawing.Size(38, 22)
        Me.TxSitCartera.TabIndex = 100321
        Me.TxSitCartera.TeclaRepetida = False
        Me.TxSitCartera.TxDatoFinalSemana = Nothing
        Me.TxSitCartera.TxDatoInicioSemana = Nothing
        Me.TxSitCartera.UltimoValorValidado = Nothing
        '
        'BtBuscaSitCartera
        '
        Me.BtBuscaSitCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtBuscaSitCartera.CL_Ancho = 0
        Me.BtBuscaSitCartera.CL_BuscaAlb = False
        Me.BtBuscaSitCartera.CL_campocodigo = Nothing
        Me.BtBuscaSitCartera.CL_camponombre = Nothing
        Me.BtBuscaSitCartera.CL_CampoOrden = "Nombre"
        Me.BtBuscaSitCartera.CL_ch1000 = False
        Me.BtBuscaSitCartera.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaSitCartera.CL_ControlAsociado = Nothing
        Me.BtBuscaSitCartera.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaSitCartera.CL_dfecha = Nothing
        Me.BtBuscaSitCartera.CL_Entidad = Nothing
        Me.BtBuscaSitCartera.CL_EsId = True
        Me.BtBuscaSitCartera.CL_Filtro = Nothing
        Me.BtBuscaSitCartera.cl_formu = Nothing
        Me.BtBuscaSitCartera.CL_hfecha = Nothing
        Me.BtBuscaSitCartera.cl_ListaW = Nothing
        Me.BtBuscaSitCartera.CL_xCentro = False
        Me.BtBuscaSitCartera.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaSitCartera.Location = New System.Drawing.Point(374, 8)
        Me.BtBuscaSitCartera.Name = "BtBuscaSitCartera"
        Me.BtBuscaSitCartera.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaSitCartera.TabIndex = 100320
        Me.BtBuscaSitCartera.UseVisualStyleBackColor = True
        '
        'LbSitCartera
        '
        Me.LbSitCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbSitCartera.AutoSize = True
        Me.LbSitCartera.CL_ControlAsociado = Nothing
        Me.LbSitCartera.CL_ValorFijo = True
        Me.LbSitCartera.ClForm = Nothing
        Me.LbSitCartera.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSitCartera.ForeColor = System.Drawing.Color.Teal
        Me.LbSitCartera.Location = New System.Drawing.Point(234, 11)
        Me.LbSitCartera.Name = "LbSitCartera"
        Me.LbSitCartera.Size = New System.Drawing.Size(90, 16)
        Me.LbSitCartera.TabIndex = 100319
        Me.LbSitCartera.Text = "Sit. Cartera"
        '
        'LbTalon
        '
        Me.LbTalon.AutoSize = True
        Me.LbTalon.CL_ControlAsociado = Nothing
        Me.LbTalon.CL_ValorFijo = False
        Me.LbTalon.ClForm = Nothing
        Me.LbTalon.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTalon.ForeColor = System.Drawing.Color.Teal
        Me.LbTalon.Location = New System.Drawing.Point(597, 91)
        Me.LbTalon.Name = "LbTalon"
        Me.LbTalon.Size = New System.Drawing.Size(67, 16)
        Me.LbTalon.TabIndex = 100327
        Me.LbTalon.Text = "Nº talón"
        '
        'TxTalon
        '
        Me.TxTalon.Autonumerico = False
        Me.TxTalon.Buscando = False
        Me.TxTalon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTalon.ClForm = Nothing
        Me.TxTalon.ClParam = Nothing
        Me.TxTalon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTalon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTalon.GridLin = Nothing
        Me.TxTalon.HaCambiado = False
        Me.TxTalon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTalon.lbbusca = Nothing
        Me.TxTalon.Location = New System.Drawing.Point(671, 88)
        Me.TxTalon.MiError = False
        Me.TxTalon.Name = "TxTalon"
        Me.TxTalon.Orden = 0
        Me.TxTalon.SaltoAlfinal = False
        Me.TxTalon.Siguiente = 0
        Me.TxTalon.Size = New System.Drawing.Size(96, 22)
        Me.TxTalon.TabIndex = 100326
        Me.TxTalon.TeclaRepetida = False
        Me.TxTalon.TxDatoFinalSemana = Nothing
        Me.TxTalon.TxDatoInicioSemana = Nothing
        Me.TxTalon.UltimoValorValidado = Nothing
        '
        'LbNomBanco
        '
        Me.LbNomBanco.BackColor = System.Drawing.Color.LightGray
        Me.LbNomBanco.CL_ControlAsociado = Nothing
        Me.LbNomBanco.CL_ValorFijo = False
        Me.LbNomBanco.ClForm = Nothing
        Me.LbNomBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomBanco.Location = New System.Drawing.Point(771, 59)
        Me.LbNomBanco.Name = "LbNomBanco"
        Me.LbNomBanco.Size = New System.Drawing.Size(224, 18)
        Me.LbNomBanco.TabIndex = 100325
        '
        'BtBanco
        '
        Me.BtBanco.CL_Ancho = 0
        Me.BtBanco.CL_BuscaAlb = False
        Me.BtBanco.CL_campocodigo = Nothing
        Me.BtBanco.CL_camponombre = Nothing
        Me.BtBanco.CL_CampoOrden = "Nombre"
        Me.BtBanco.CL_ch1000 = False
        Me.BtBanco.CL_ConsultaSql = "Select * from familias"
        Me.BtBanco.CL_ControlAsociado = Nothing
        Me.BtBanco.CL_DevuelveCampo = "Idfamilia"
        Me.BtBanco.CL_dfecha = Nothing
        Me.BtBanco.CL_Entidad = Nothing
        Me.BtBanco.CL_EsId = True
        Me.BtBanco.CL_Filtro = Nothing
        Me.BtBanco.cl_formu = Nothing
        Me.BtBanco.CL_hfecha = Nothing
        Me.BtBanco.cl_ListaW = Nothing
        Me.BtBanco.CL_xCentro = False
        Me.BtBanco.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBanco.Location = New System.Drawing.Point(734, 57)
        Me.BtBanco.Name = "BtBanco"
        Me.BtBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBanco.TabIndex = 100324
        Me.BtBanco.UseVisualStyleBackColor = True
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = False
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(597, 60)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(53, 16)
        Me.LbBanco.TabIndex = 100323
        Me.LbBanco.Text = "Banco"
        '
        'TxBanco
        '
        Me.TxBanco.Autonumerico = False
        Me.TxBanco.Buscando = False
        Me.TxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBanco.ClForm = Nothing
        Me.TxBanco.ClParam = Nothing
        Me.TxBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBanco.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(671, 57)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(57, 22)
        Me.TxBanco.TabIndex = 100322
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
        '
        'LbAfecha
        '
        Me.LbAfecha.AutoSize = True
        Me.LbAfecha.CL_ControlAsociado = Nothing
        Me.LbAfecha.CL_ValorFijo = False
        Me.LbAfecha.ClForm = Nothing
        Me.LbAfecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAfecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAfecha.Location = New System.Drawing.Point(257, 91)
        Me.LbAfecha.Name = "LbAfecha"
        Me.LbAfecha.Size = New System.Drawing.Size(95, 16)
        Me.LbAfecha.TabIndex = 100321
        Me.LbAfecha.Text = "Hasta fecha"
        '
        'TxAfecha
        '
        Me.TxAfecha.Autonumerico = False
        Me.TxAfecha.Buscando = False
        Me.TxAfecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAfecha.ClForm = Nothing
        Me.TxAfecha.ClParam = Nothing
        Me.TxAfecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAfecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAfecha.GridLin = Nothing
        Me.TxAfecha.HaCambiado = False
        Me.TxAfecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAfecha.lbbusca = Nothing
        Me.TxAfecha.Location = New System.Drawing.Point(358, 88)
        Me.TxAfecha.MiError = False
        Me.TxAfecha.Name = "TxAfecha"
        Me.TxAfecha.Orden = 0
        Me.TxAfecha.SaltoAlfinal = False
        Me.TxAfecha.Siguiente = 0
        Me.TxAfecha.Size = New System.Drawing.Size(105, 22)
        Me.TxAfecha.TabIndex = 100320
        Me.TxAfecha.TeclaRepetida = False
        Me.TxAfecha.TxDatoFinalSemana = Nothing
        Me.TxAfecha.TxDatoInicioSemana = Nothing
        Me.TxAfecha.UltimoValorValidado = Nothing
        '
        'LbCodigo
        '
        Me.LbCodigo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = False
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCodigo.Location = New System.Drawing.Point(126, 57)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(77, 22)
        Me.LbCodigo.TabIndex = 100319
        '
        'LbDfecha
        '
        Me.LbDfecha.AutoSize = True
        Me.LbDfecha.CL_ControlAsociado = Nothing
        Me.LbDfecha.CL_ValorFijo = False
        Me.LbDfecha.ClForm = Nothing
        Me.LbDfecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDfecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDfecha.Location = New System.Drawing.Point(8, 91)
        Me.LbDfecha.Name = "LbDfecha"
        Me.LbDfecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDfecha.TabIndex = 100318
        Me.LbDfecha.Text = "Desde fecha"
        '
        'TxDFecha
        '
        Me.TxDFecha.Autonumerico = False
        Me.TxDFecha.Buscando = False
        Me.TxDFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDFecha.ClForm = Nothing
        Me.TxDFecha.ClParam = Nothing
        Me.TxDFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDFecha.GridLin = Nothing
        Me.TxDFecha.HaCambiado = False
        Me.TxDFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDFecha.lbbusca = Nothing
        Me.TxDFecha.Location = New System.Drawing.Point(126, 88)
        Me.TxDFecha.MiError = False
        Me.TxDFecha.Name = "TxDFecha"
        Me.TxDFecha.Orden = 0
        Me.TxDFecha.SaltoAlfinal = False
        Me.TxDFecha.Siguiente = 0
        Me.TxDFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxDFecha.TabIndex = 100317
        Me.TxDFecha.TeclaRepetida = False
        Me.TxDFecha.TxDatoFinalSemana = Nothing
        Me.TxDFecha.TxDatoInicioSemana = Nothing
        Me.TxDFecha.UltimoValorValidado = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbAsiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(889, 11)
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
        Me.GroupBox3.Controls.Add(Me.LbNuCTB)
        Me.GroupBox3.Controls.Add(Me.Lbejer)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(788, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(90, 43)
        Me.GroupBox3.TabIndex = 100307
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ejercicio"
        '
        'LbNuCTB
        '
        Me.LbNuCTB.BackColor = System.Drawing.Color.White
        Me.LbNuCTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNuCTB.CL_ControlAsociado = Nothing
        Me.LbNuCTB.CL_ValorFijo = False
        Me.LbNuCTB.ClForm = Nothing
        Me.LbNuCTB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuCTB.ForeColor = System.Drawing.Color.Teal
        Me.LbNuCTB.Location = New System.Drawing.Point(6, 14)
        Me.LbNuCTB.Name = "LbNuCTB"
        Me.LbNuCTB.Size = New System.Drawing.Size(34, 21)
        Me.LbNuCTB.TabIndex = 115
        Me.LbNuCTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Lbejer.Location = New System.Drawing.Point(48, 14)
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
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxSerie
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
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(327, 24)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 189
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxSerie
        '
        Me.TxSerie.Autonumerico = False
        Me.TxSerie.Buscando = False
        Me.TxSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSerie.ClForm = Nothing
        Me.TxSerie.ClParam = Nothing
        Me.TxSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSerie.GridLin = Nothing
        Me.TxSerie.HaCambiado = False
        Me.TxSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSerie.lbbusca = Nothing
        Me.TxSerie.Location = New System.Drawing.Point(126, 24)
        Me.TxSerie.MiError = False
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Orden = 0
        Me.TxSerie.SaltoAlfinal = False
        Me.TxSerie.Siguiente = 0
        Me.TxSerie.Size = New System.Drawing.Size(77, 22)
        Me.TxSerie.TabIndex = 187
        Me.TxSerie.TeclaRepetida = False
        Me.TxSerie.TxDatoFinalSemana = Nothing
        Me.TxSerie.TxDatoInicioSemana = Nothing
        Me.TxSerie.UltimoValorValidado = Nothing
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(220, 57)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(352, 23)
        Me.LbnomAgr1.TabIndex = 87
        '
        'LbFactura
        '
        Me.LbFactura.AutoSize = True
        Me.LbFactura.CL_ControlAsociado = Nothing
        Me.LbFactura.CL_ValorFijo = False
        Me.LbFactura.ClForm = Nothing
        Me.LbFactura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFactura.ForeColor = System.Drawing.Color.Teal
        Me.LbFactura.Location = New System.Drawing.Point(8, 27)
        Me.LbFactura.Name = "LbFactura"
        Me.LbFactura.Size = New System.Drawing.Size(112, 16)
        Me.LbFactura.TabIndex = 84
        Me.LbFactura.Text = "Nº Liquidación"
        '
        'TxNuliqui
        '
        Me.TxNuliqui.Autonumerico = False
        Me.TxNuliqui.Buscando = False
        Me.TxNuliqui.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNuliqui.ClForm = Nothing
        Me.TxNuliqui.ClParam = Nothing
        Me.TxNuliqui.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNuliqui.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNuliqui.GridLin = Nothing
        Me.TxNuliqui.HaCambiado = False
        Me.TxNuliqui.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNuliqui.lbbusca = Nothing
        Me.TxNuliqui.Location = New System.Drawing.Point(220, 24)
        Me.TxNuliqui.MiError = False
        Me.TxNuliqui.Name = "TxNuliqui"
        Me.TxNuliqui.Orden = 0
        Me.TxNuliqui.SaltoAlfinal = False
        Me.TxNuliqui.Siguiente = 0
        Me.TxNuliqui.Size = New System.Drawing.Size(101, 22)
        Me.TxNuliqui.TabIndex = 83
        Me.TxNuliqui.TeclaRepetida = False
        Me.TxNuliqui.TxDatoFinalSemana = Nothing
        Me.TxNuliqui.TxDatoInicioSemana = Nothing
        Me.TxNuliqui.UltimoValorValidado = Nothing
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = True
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(9, 60)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 80
        Me.LbAgricultor.Text = "Agricultor"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(391, 27)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 79
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(449, 24)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxFecha.TabIndex = 78
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TxSaldo)
        Me.Panel4.Controls.Add(Me.Grid)
        Me.Panel4.Controls.Add(Me.LbResultado)
        Me.Panel4.Controls.Add(Me.Lb15)
        Me.Panel4.Controls.Add(Me.LbPortes)
        Me.Panel4.Controls.Add(Me.TxPortes)
        Me.Panel4.Controls.Add(Me.LbSuministros)
        Me.Panel4.Controls.Add(Me.TxSuministros)
        Me.Panel4.Controls.Add(Me.LbAnticipos)
        Me.Panel4.Controls.Add(Me.TxAnticipos)
        Me.Panel4.Controls.Add(Me.Lb10)
        Me.Panel4.Controls.Add(Me.LbImpFacturas)
        Me.Panel4.Controls.Add(Me.Lb8)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1052, 493)
        Me.Panel4.TabIndex = 73
        '
        'TxSaldo
        '
        Me.TxSaldo.Autonumerico = False
        Me.TxSaldo.Buscando = False
        Me.TxSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSaldo.ClForm = Nothing
        Me.TxSaldo.ClParam = Nothing
        Me.TxSaldo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSaldo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSaldo.GridLin = Nothing
        Me.TxSaldo.HaCambiado = False
        Me.TxSaldo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSaldo.lbbusca = Nothing
        Me.TxSaldo.Location = New System.Drawing.Point(131, 287)
        Me.TxSaldo.MiError = False
        Me.TxSaldo.Name = "TxSaldo"
        Me.TxSaldo.Orden = 0
        Me.TxSaldo.SaltoAlfinal = False
        Me.TxSaldo.Siguiente = 0
        Me.TxSaldo.Size = New System.Drawing.Size(141, 22)
        Me.TxSaldo.TabIndex = 100333
        Me.TxSaldo.TeclaRepetida = False
        Me.TxSaldo.TxDatoFinalSemana = Nothing
        Me.TxSaldo.TxDatoInicioSemana = Nothing
        Me.TxSaldo.UltimoValorValidado = Nothing
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Right
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(532, 233)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(516, 256)
        Me.Grid.TabIndex = 100332
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
        'LbResultado
        '
        Me.LbResultado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbResultado.CL_ControlAsociado = Nothing
        Me.LbResultado.CL_ValorFijo = False
        Me.LbResultado.ClForm = Nothing
        Me.LbResultado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbResultado.Location = New System.Drawing.Point(131, 438)
        Me.LbResultado.Name = "LbResultado"
        Me.LbResultado.Size = New System.Drawing.Size(139, 23)
        Me.LbResultado.TabIndex = 100331
        Me.LbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(14, 441)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(80, 16)
        Me.Lb15.TabIndex = 100330
        Me.Lb15.Text = "Resultado"
        '
        'LbPortes
        '
        Me.LbPortes.AutoSize = True
        Me.LbPortes.CL_ControlAsociado = Nothing
        Me.LbPortes.CL_ValorFijo = False
        Me.LbPortes.ClForm = Nothing
        Me.LbPortes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPortes.ForeColor = System.Drawing.Color.Teal
        Me.LbPortes.Location = New System.Drawing.Point(14, 401)
        Me.LbPortes.Name = "LbPortes"
        Me.LbPortes.Size = New System.Drawing.Size(55, 16)
        Me.LbPortes.TabIndex = 100329
        Me.LbPortes.Text = "Portes"
        '
        'TxPortes
        '
        Me.TxPortes.Autonumerico = False
        Me.TxPortes.Buscando = False
        Me.TxPortes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPortes.ClForm = Nothing
        Me.TxPortes.ClParam = Nothing
        Me.TxPortes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPortes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPortes.GridLin = Nothing
        Me.TxPortes.HaCambiado = False
        Me.TxPortes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPortes.lbbusca = Nothing
        Me.TxPortes.Location = New System.Drawing.Point(131, 398)
        Me.TxPortes.MiError = False
        Me.TxPortes.Name = "TxPortes"
        Me.TxPortes.Orden = 0
        Me.TxPortes.SaltoAlfinal = False
        Me.TxPortes.Siguiente = 0
        Me.TxPortes.Size = New System.Drawing.Size(141, 22)
        Me.TxPortes.TabIndex = 100328
        Me.TxPortes.TeclaRepetida = False
        Me.TxPortes.TxDatoFinalSemana = Nothing
        Me.TxPortes.TxDatoInicioSemana = Nothing
        Me.TxPortes.UltimoValorValidado = Nothing
        '
        'LbSuministros
        '
        Me.LbSuministros.AutoSize = True
        Me.LbSuministros.CL_ControlAsociado = Nothing
        Me.LbSuministros.CL_ValorFijo = False
        Me.LbSuministros.ClForm = Nothing
        Me.LbSuministros.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSuministros.ForeColor = System.Drawing.Color.Teal
        Me.LbSuministros.Location = New System.Drawing.Point(14, 363)
        Me.LbSuministros.Name = "LbSuministros"
        Me.LbSuministros.Size = New System.Drawing.Size(94, 16)
        Me.LbSuministros.TabIndex = 100327
        Me.LbSuministros.Text = "Suministros"
        '
        'TxSuministros
        '
        Me.TxSuministros.Autonumerico = False
        Me.TxSuministros.Buscando = False
        Me.TxSuministros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSuministros.ClForm = Nothing
        Me.TxSuministros.ClParam = Nothing
        Me.TxSuministros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSuministros.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSuministros.GridLin = Nothing
        Me.TxSuministros.HaCambiado = False
        Me.TxSuministros.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSuministros.lbbusca = Nothing
        Me.TxSuministros.Location = New System.Drawing.Point(131, 360)
        Me.TxSuministros.MiError = False
        Me.TxSuministros.Name = "TxSuministros"
        Me.TxSuministros.Orden = 0
        Me.TxSuministros.SaltoAlfinal = False
        Me.TxSuministros.Siguiente = 0
        Me.TxSuministros.Size = New System.Drawing.Size(141, 22)
        Me.TxSuministros.TabIndex = 100326
        Me.TxSuministros.TeclaRepetida = False
        Me.TxSuministros.TxDatoFinalSemana = Nothing
        Me.TxSuministros.TxDatoInicioSemana = Nothing
        Me.TxSuministros.UltimoValorValidado = Nothing
        '
        'LbAnticipos
        '
        Me.LbAnticipos.AutoSize = True
        Me.LbAnticipos.CL_ControlAsociado = Nothing
        Me.LbAnticipos.CL_ValorFijo = True
        Me.LbAnticipos.ClForm = Nothing
        Me.LbAnticipos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAnticipos.ForeColor = System.Drawing.Color.Teal
        Me.LbAnticipos.Location = New System.Drawing.Point(14, 325)
        Me.LbAnticipos.Name = "LbAnticipos"
        Me.LbAnticipos.Size = New System.Drawing.Size(75, 16)
        Me.LbAnticipos.TabIndex = 100325
        Me.LbAnticipos.Text = "Anticipos"
        '
        'TxAnticipos
        '
        Me.TxAnticipos.Autonumerico = False
        Me.TxAnticipos.Buscando = False
        Me.TxAnticipos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAnticipos.ClForm = Nothing
        Me.TxAnticipos.ClParam = Nothing
        Me.TxAnticipos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAnticipos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAnticipos.GridLin = Nothing
        Me.TxAnticipos.HaCambiado = False
        Me.TxAnticipos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAnticipos.lbbusca = Nothing
        Me.TxAnticipos.Location = New System.Drawing.Point(131, 322)
        Me.TxAnticipos.MiError = False
        Me.TxAnticipos.Name = "TxAnticipos"
        Me.TxAnticipos.Orden = 0
        Me.TxAnticipos.SaltoAlfinal = False
        Me.TxAnticipos.Siguiente = 0
        Me.TxAnticipos.Size = New System.Drawing.Size(141, 22)
        Me.TxAnticipos.TabIndex = 100324
        Me.TxAnticipos.TeclaRepetida = False
        Me.TxAnticipos.TxDatoFinalSemana = Nothing
        Me.TxAnticipos.TxDatoInicioSemana = Nothing
        Me.TxAnticipos.UltimoValorValidado = Nothing
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(14, 290)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(82, 16)
        Me.Lb10.TabIndex = 100322
        Me.Lb10.Text = "Saldo Ant."
        '
        'LbImpFacturas
        '
        Me.LbImpFacturas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbImpFacturas.CL_ControlAsociado = Nothing
        Me.LbImpFacturas.CL_ValorFijo = False
        Me.LbImpFacturas.ClForm = Nothing
        Me.LbImpFacturas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpFacturas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbImpFacturas.Location = New System.Drawing.Point(131, 255)
        Me.LbImpFacturas.Name = "LbImpFacturas"
        Me.LbImpFacturas.Size = New System.Drawing.Size(139, 23)
        Me.LbImpFacturas.TabIndex = 100321
        Me.LbImpFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(14, 258)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(72, 16)
        Me.Lb8.TabIndex = 100320
        Me.Lb8.Text = "Facturas"
        '
        'FrmLiquidacionAgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 533)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmLiquidacionAgr"
        Me.Text = "Liquidacion agricultores"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbTalon As NetAgro.Lb
    Friend WithEvents TxTalon As NetAgro.TxDato
    Friend WithEvents LbNomBanco As NetAgro.Lb
    Friend WithEvents BtBanco As NetAgro.BtBusca
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents LbAfecha As NetAgro.Lb
    Friend WithEvents TxAfecha As NetAgro.TxDato
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents LbDfecha As NetAgro.Lb
    Friend WithEvents TxDFecha As NetAgro.TxDato
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAsiento As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNuCTB As NetAgro.Lb
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxSerie As NetAgro.TxDato
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents LbFactura As NetAgro.Lb
    Friend WithEvents TxNuliqui As NetAgro.TxDato
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbResultado As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents LbPortes As NetAgro.Lb
    Friend WithEvents TxPortes As NetAgro.TxDato
    Friend WithEvents LbSuministros As NetAgro.Lb
    Friend WithEvents TxSuministros As NetAgro.TxDato
    Friend WithEvents LbAnticipos As NetAgro.Lb
    Friend WithEvents TxAnticipos As NetAgro.TxDato
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbImpFacturas As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxSaldo As NetAgro.TxDato
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents RbPagare As System.Windows.Forms.RadioButton
    Friend WithEvents rbTalon As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TxFechaVto As NetAgro.TxDato
    Friend WithEvents LbFechaVto As NetAgro.Lb
    Friend WithEvents LbNom_TipoDoc As NetAgro.Lb
    Friend WithEvents TxTipoDoc As NetAgro.TxDato
    Friend WithEvents BtBuscaTipoDoc As NetAgro.BtBusca
    Friend WithEvents LbTipoDoc As NetAgro.Lb
    Friend WithEvents LbNom_SitCartera As NetAgro.Lb
    Friend WithEvents TxSitCartera As NetAgro.TxDato
    Friend WithEvents BtBuscaSitCartera As NetAgro.BtBusca
    Friend WithEvents LbSitCartera As NetAgro.Lb

End Class
