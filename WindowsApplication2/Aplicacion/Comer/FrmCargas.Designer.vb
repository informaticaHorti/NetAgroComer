<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargas
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargas))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbCarga = New NetAgro.Lb(Me.components)
        Me.TxCarga = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCarga = New NetAgro.BtBusca(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.BtBuscaTransportista = New NetAgro.BtBusca(Me.components)
        Me.TxTransportista = New NetAgro.TxDato(Me.components)
        Me.LbTransportista = New NetAgro.Lb(Me.components)
        Me.TxMatricula = New NetAgro.TxDato(Me.components)
        Me.LbMatricula = New NetAgro.Lb(Me.components)
        Me.BtBuscaConcepto = New NetAgro.BtBusca(Me.components)
        Me.TxIdConcepto = New NetAgro.TxDato(Me.components)
        Me.LbConcepto = New NetAgro.Lb(Me.components)
        Me.TxConcepto = New NetAgro.TxDato(Me.components)
        Me.TxReparto = New NetAgro.TxDato(Me.components)
        Me.LbReparto = New NetAgro.Lb(Me.components)
        Me.TxTemperatura = New NetAgro.TxDato(Me.components)
        Me.LbTemperatura = New NetAgro.Lb(Me.components)
        Me.BtBuscaCargador = New NetAgro.BtBusca(Me.components)
        Me.TxCargador = New NetAgro.TxDato(Me.components)
        Me.LbCargador = New NetAgro.Lb(Me.components)
        Me.LbNomTransportista = New NetAgro.Lb(Me.components)
        Me.LbNomCargador = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbPalet6 = New NetAgro.Lb(Me.components)
        Me.LbPalet5 = New NetAgro.Lb(Me.components)
        Me.LbPalet4 = New NetAgro.Lb(Me.components)
        Me.LbPalet3 = New NetAgro.Lb(Me.components)
        Me.LbPalet2 = New NetAgro.Lb(Me.components)
        Me.LbPalet1 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxPedido6 = New NetAgro.TxDato(Me.components)
        Me.TxPedido5 = New NetAgro.TxDato(Me.components)
        Me.TxPedido4 = New NetAgro.TxDato(Me.components)
        Me.TxPedido3 = New NetAgro.TxDato(Me.components)
        Me.TxPedido2 = New NetAgro.TxDato(Me.components)
        Me.TxPedido1 = New NetAgro.TxDato(Me.components)
        Me.LbAlbaran6 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran5 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran4 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran3 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran2 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran1 = New NetAgro.Lb(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.Rb6 = New System.Windows.Forms.RadioButton()
        Me.LbCliente6 = New NetAgro.Lb(Me.components)
        Me.Rb5 = New System.Windows.Forms.RadioButton()
        Me.LbCliente5 = New NetAgro.Lb(Me.components)
        Me.Rb4 = New System.Windows.Forms.RadioButton()
        Me.LbCliente4 = New NetAgro.Lb(Me.components)
        Me.Rb3 = New System.Windows.Forms.RadioButton()
        Me.LbCliente3 = New NetAgro.Lb(Me.components)
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.LbCliente2 = New NetAgro.Lb(Me.components)
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.LbCliente1 = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbPedido = New NetAgro.Lb(Me.components)
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.GridInspec = New DevExpress.XtraGrid.GridControl()
        Me.GridViewInspec = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtPalet = New System.Windows.Forms.Button()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbMuelle = New NetAgro.Lb(Me.components)
        Me.LbNumPaletAlbaran = New NetAgro.Lb(Me.components)
        Me.LbNumPaletTotal = New NetAgro.Lb(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPedido = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbAlbaran = New System.Windows.Forms.Label()
        Me.GridPedido = New DevExpress.XtraGrid.GridControl()
        Me.GridPedidoView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbPalPte = New System.Windows.Forms.Label()
        Me.LbParCar = New System.Windows.Forms.Label()
        Me.LbPalped = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbCliente = New System.Windows.Forms.Label()
        Me.LbNped = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.GridInspec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewInspec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPedido.SuspendLayout()
        CType(Me.GridPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPedidoView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Grid
        '
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(11, 377)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(514, 151)
        Me.Grid.TabIndex = 71
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        '
        'LbCarga
        '
        Me.LbCarga.AutoSize = True
        Me.LbCarga.CL_ControlAsociado = Nothing
        Me.LbCarga.CL_ValorFijo = False
        Me.LbCarga.ClForm = Nothing
        Me.LbCarga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCarga.ForeColor = System.Drawing.Color.Teal
        Me.LbCarga.Location = New System.Drawing.Point(8, 6)
        Me.LbCarga.Name = "LbCarga"
        Me.LbCarga.Size = New System.Drawing.Size(110, 16)
        Me.LbCarga.TabIndex = 66
        Me.LbCarga.Text = "Número carga"
        '
        'TxCarga
        '
        Me.TxCarga.Autonumerico = False
        Me.TxCarga.Buscando = False
        Me.TxCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCarga.ClForm = Nothing
        Me.TxCarga.ClParam = Nothing
        Me.TxCarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCarga.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCarga.GridLin = Nothing
        Me.TxCarga.HaCambiado = False
        Me.TxCarga.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCarga.lbbusca = Nothing
        Me.TxCarga.Location = New System.Drawing.Point(124, 4)
        Me.TxCarga.MiError = False
        Me.TxCarga.Name = "TxCarga"
        Me.TxCarga.Orden = 0
        Me.TxCarga.SaltoAlfinal = False
        Me.TxCarga.Siguiente = 0
        Me.TxCarga.Size = New System.Drawing.Size(69, 22)
        Me.TxCarga.TabIndex = 74
        Me.TxCarga.TeclaRepetida = False
        Me.TxCarga.TxDatoFinalSemana = Nothing
        Me.TxCarga.TxDatoInicioSemana = Nothing
        Me.TxCarga.UltimoValorValidado = Nothing
        '
        'BtBuscaCarga
        '
        Me.BtBuscaCarga.CL_Ancho = 0
        Me.BtBuscaCarga.CL_BuscaAlb = False
        Me.BtBuscaCarga.CL_campocodigo = Nothing
        Me.BtBuscaCarga.CL_camponombre = Nothing
        Me.BtBuscaCarga.CL_CampoOrden = "Nombre"
        Me.BtBuscaCarga.CL_ch1000 = False
        Me.BtBuscaCarga.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCarga.CL_ControlAsociado = Me.TxCarga
        Me.BtBuscaCarga.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCarga.CL_dfecha = Nothing
        Me.BtBuscaCarga.CL_Entidad = Nothing
        Me.BtBuscaCarga.CL_EsId = True
        Me.BtBuscaCarga.CL_Filtro = Nothing
        Me.BtBuscaCarga.cl_formu = Nothing
        Me.BtBuscaCarga.CL_hfecha = Nothing
        Me.BtBuscaCarga.cl_ListaW = Nothing
        Me.BtBuscaCarga.CL_xCentro = False
        Me.BtBuscaCarga.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCarga.Location = New System.Drawing.Point(200, 4)
        Me.BtBuscaCarga.Name = "BtBuscaCarga"
        Me.BtBuscaCarga.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCarga.TabIndex = 76
        Me.BtBuscaCarga.UseVisualStyleBackColor = True
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
        Me.TxFecha.Location = New System.Drawing.Point(325, 4)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(116, 22)
        Me.TxFecha.TabIndex = 78
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(256, 6)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 77
        Me.LbFecha.Text = "Fecha"
        '
        'BtBuscaTransportista
        '
        Me.BtBuscaTransportista.CL_Ancho = 0
        Me.BtBuscaTransportista.CL_BuscaAlb = False
        Me.BtBuscaTransportista.CL_campocodigo = Nothing
        Me.BtBuscaTransportista.CL_camponombre = Nothing
        Me.BtBuscaTransportista.CL_CampoOrden = "Nombre"
        Me.BtBuscaTransportista.CL_ch1000 = False
        Me.BtBuscaTransportista.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTransportista.CL_ControlAsociado = Me.TxTransportista
        Me.BtBuscaTransportista.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTransportista.CL_dfecha = Nothing
        Me.BtBuscaTransportista.CL_Entidad = Nothing
        Me.BtBuscaTransportista.CL_EsId = True
        Me.BtBuscaTransportista.CL_Filtro = Nothing
        Me.BtBuscaTransportista.cl_formu = Nothing
        Me.BtBuscaTransportista.CL_hfecha = Nothing
        Me.BtBuscaTransportista.cl_ListaW = Nothing
        Me.BtBuscaTransportista.CL_xCentro = False
        Me.BtBuscaTransportista.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTransportista.Location = New System.Drawing.Point(200, 32)
        Me.BtBuscaTransportista.Name = "BtBuscaTransportista"
        Me.BtBuscaTransportista.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTransportista.TabIndex = 81
        Me.BtBuscaTransportista.UseVisualStyleBackColor = True
        '
        'TxTransportista
        '
        Me.TxTransportista.Autonumerico = False
        Me.TxTransportista.Buscando = False
        Me.TxTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTransportista.ClForm = Nothing
        Me.TxTransportista.ClParam = Nothing
        Me.TxTransportista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTransportista.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTransportista.GridLin = Nothing
        Me.TxTransportista.HaCambiado = False
        Me.TxTransportista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTransportista.lbbusca = Nothing
        Me.TxTransportista.Location = New System.Drawing.Point(124, 32)
        Me.TxTransportista.MiError = False
        Me.TxTransportista.Name = "TxTransportista"
        Me.TxTransportista.Orden = 0
        Me.TxTransportista.SaltoAlfinal = False
        Me.TxTransportista.Siguiente = 0
        Me.TxTransportista.Size = New System.Drawing.Size(69, 22)
        Me.TxTransportista.TabIndex = 80
        Me.TxTransportista.TeclaRepetida = False
        Me.TxTransportista.TxDatoFinalSemana = Nothing
        Me.TxTransportista.TxDatoInicioSemana = Nothing
        Me.TxTransportista.UltimoValorValidado = Nothing
        '
        'LbTransportista
        '
        Me.LbTransportista.AutoSize = True
        Me.LbTransportista.CL_ControlAsociado = Nothing
        Me.LbTransportista.CL_ValorFijo = False
        Me.LbTransportista.ClForm = Nothing
        Me.LbTransportista.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTransportista.ForeColor = System.Drawing.Color.Teal
        Me.LbTransportista.Location = New System.Drawing.Point(8, 34)
        Me.LbTransportista.Name = "LbTransportista"
        Me.LbTransportista.Size = New System.Drawing.Size(105, 16)
        Me.LbTransportista.TabIndex = 79
        Me.LbTransportista.Text = "Transportista"
        '
        'TxMatricula
        '
        Me.TxMatricula.Autonumerico = False
        Me.TxMatricula.Buscando = False
        Me.TxMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMatricula.ClForm = Nothing
        Me.TxMatricula.ClParam = Nothing
        Me.TxMatricula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMatricula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMatricula.GridLin = Nothing
        Me.TxMatricula.HaCambiado = False
        Me.TxMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxMatricula.lbbusca = Nothing
        Me.TxMatricula.Location = New System.Drawing.Point(124, 58)
        Me.TxMatricula.MiError = False
        Me.TxMatricula.Name = "TxMatricula"
        Me.TxMatricula.Orden = 0
        Me.TxMatricula.SaltoAlfinal = False
        Me.TxMatricula.Siguiente = 0
        Me.TxMatricula.Size = New System.Drawing.Size(143, 22)
        Me.TxMatricula.TabIndex = 83
        Me.TxMatricula.TeclaRepetida = False
        Me.TxMatricula.TxDatoFinalSemana = Nothing
        Me.TxMatricula.TxDatoInicioSemana = Nothing
        Me.TxMatricula.UltimoValorValidado = Nothing
        '
        'LbMatricula
        '
        Me.LbMatricula.AutoSize = True
        Me.LbMatricula.CL_ControlAsociado = Nothing
        Me.LbMatricula.CL_ValorFijo = False
        Me.LbMatricula.ClForm = Nothing
        Me.LbMatricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMatricula.ForeColor = System.Drawing.Color.Teal
        Me.LbMatricula.Location = New System.Drawing.Point(8, 60)
        Me.LbMatricula.Name = "LbMatricula"
        Me.LbMatricula.Size = New System.Drawing.Size(75, 16)
        Me.LbMatricula.TabIndex = 82
        Me.LbMatricula.Text = "Matricula"
        '
        'BtBuscaConcepto
        '
        Me.BtBuscaConcepto.CL_Ancho = 0
        Me.BtBuscaConcepto.CL_BuscaAlb = False
        Me.BtBuscaConcepto.CL_campocodigo = Nothing
        Me.BtBuscaConcepto.CL_camponombre = Nothing
        Me.BtBuscaConcepto.CL_CampoOrden = "Nombre"
        Me.BtBuscaConcepto.CL_ch1000 = False
        Me.BtBuscaConcepto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaConcepto.CL_ControlAsociado = Me.TxIdConcepto
        Me.BtBuscaConcepto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaConcepto.CL_dfecha = Nothing
        Me.BtBuscaConcepto.CL_Entidad = Nothing
        Me.BtBuscaConcepto.CL_EsId = True
        Me.BtBuscaConcepto.CL_Filtro = Nothing
        Me.BtBuscaConcepto.cl_formu = Nothing
        Me.BtBuscaConcepto.CL_hfecha = Nothing
        Me.BtBuscaConcepto.cl_ListaW = Nothing
        Me.BtBuscaConcepto.CL_xCentro = False
        Me.BtBuscaConcepto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaConcepto.Location = New System.Drawing.Point(200, 86)
        Me.BtBuscaConcepto.Name = "BtBuscaConcepto"
        Me.BtBuscaConcepto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaConcepto.TabIndex = 86
        Me.BtBuscaConcepto.UseVisualStyleBackColor = True
        '
        'TxIdConcepto
        '
        Me.TxIdConcepto.Autonumerico = False
        Me.TxIdConcepto.Buscando = False
        Me.TxIdConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIdConcepto.ClForm = Nothing
        Me.TxIdConcepto.ClParam = Nothing
        Me.TxIdConcepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxIdConcepto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdConcepto.GridLin = Nothing
        Me.TxIdConcepto.HaCambiado = False
        Me.TxIdConcepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxIdConcepto.lbbusca = Nothing
        Me.TxIdConcepto.Location = New System.Drawing.Point(124, 86)
        Me.TxIdConcepto.MiError = False
        Me.TxIdConcepto.Name = "TxIdConcepto"
        Me.TxIdConcepto.Orden = 0
        Me.TxIdConcepto.SaltoAlfinal = False
        Me.TxIdConcepto.Siguiente = 0
        Me.TxIdConcepto.Size = New System.Drawing.Size(69, 22)
        Me.TxIdConcepto.TabIndex = 85
        Me.TxIdConcepto.TeclaRepetida = False
        Me.TxIdConcepto.TxDatoFinalSemana = Nothing
        Me.TxIdConcepto.TxDatoInicioSemana = Nothing
        Me.TxIdConcepto.UltimoValorValidado = Nothing
        '
        'LbConcepto
        '
        Me.LbConcepto.AutoSize = True
        Me.LbConcepto.CL_ControlAsociado = Nothing
        Me.LbConcepto.CL_ValorFijo = False
        Me.LbConcepto.ClForm = Nothing
        Me.LbConcepto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConcepto.ForeColor = System.Drawing.Color.Teal
        Me.LbConcepto.Location = New System.Drawing.Point(8, 88)
        Me.LbConcepto.Name = "LbConcepto"
        Me.LbConcepto.Size = New System.Drawing.Size(77, 16)
        Me.LbConcepto.TabIndex = 84
        Me.LbConcepto.Text = "Concepto"
        '
        'TxConcepto
        '
        Me.TxConcepto.Autonumerico = False
        Me.TxConcepto.Buscando = False
        Me.TxConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxConcepto.ClForm = Nothing
        Me.TxConcepto.ClParam = Nothing
        Me.TxConcepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxConcepto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxConcepto.GridLin = Nothing
        Me.TxConcepto.HaCambiado = False
        Me.TxConcepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxConcepto.lbbusca = Nothing
        Me.TxConcepto.Location = New System.Drawing.Point(239, 86)
        Me.TxConcepto.MiError = False
        Me.TxConcepto.Name = "TxConcepto"
        Me.TxConcepto.Orden = 0
        Me.TxConcepto.SaltoAlfinal = False
        Me.TxConcepto.Siguiente = 0
        Me.TxConcepto.Size = New System.Drawing.Size(241, 22)
        Me.TxConcepto.TabIndex = 87
        Me.TxConcepto.TeclaRepetida = False
        Me.TxConcepto.TxDatoFinalSemana = Nothing
        Me.TxConcepto.TxDatoInicioSemana = Nothing
        Me.TxConcepto.UltimoValorValidado = Nothing
        '
        'TxReparto
        '
        Me.TxReparto.Autonumerico = False
        Me.TxReparto.Buscando = False
        Me.TxReparto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxReparto.ClForm = Nothing
        Me.TxReparto.ClParam = Nothing
        Me.TxReparto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxReparto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxReparto.GridLin = Nothing
        Me.TxReparto.HaCambiado = False
        Me.TxReparto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxReparto.lbbusca = Nothing
        Me.TxReparto.Location = New System.Drawing.Point(124, 114)
        Me.TxReparto.MiError = False
        Me.TxReparto.Name = "TxReparto"
        Me.TxReparto.Orden = 0
        Me.TxReparto.SaltoAlfinal = False
        Me.TxReparto.Siguiente = 0
        Me.TxReparto.Size = New System.Drawing.Size(29, 22)
        Me.TxReparto.TabIndex = 89
        Me.TxReparto.TeclaRepetida = False
        Me.TxReparto.TxDatoFinalSemana = Nothing
        Me.TxReparto.TxDatoInicioSemana = Nothing
        Me.TxReparto.UltimoValorValidado = Nothing
        '
        'LbReparto
        '
        Me.LbReparto.AutoSize = True
        Me.LbReparto.CL_ControlAsociado = Nothing
        Me.LbReparto.CL_ValorFijo = False
        Me.LbReparto.ClForm = Nothing
        Me.LbReparto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReparto.ForeColor = System.Drawing.Color.Teal
        Me.LbReparto.Location = New System.Drawing.Point(8, 116)
        Me.LbReparto.Name = "LbReparto"
        Me.LbReparto.Size = New System.Drawing.Size(115, 16)
        Me.LbReparto.TabIndex = 88
        Me.LbReparto.Text = "Reparto K/P/B"
        '
        'TxTemperatura
        '
        Me.TxTemperatura.Autonumerico = False
        Me.TxTemperatura.Buscando = False
        Me.TxTemperatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTemperatura.ClForm = Nothing
        Me.TxTemperatura.ClParam = Nothing
        Me.TxTemperatura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTemperatura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTemperatura.GridLin = Nothing
        Me.TxTemperatura.HaCambiado = False
        Me.TxTemperatura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTemperatura.lbbusca = Nothing
        Me.TxTemperatura.Location = New System.Drawing.Point(372, 114)
        Me.TxTemperatura.MiError = False
        Me.TxTemperatura.Name = "TxTemperatura"
        Me.TxTemperatura.Orden = 0
        Me.TxTemperatura.SaltoAlfinal = False
        Me.TxTemperatura.Siguiente = 0
        Me.TxTemperatura.Size = New System.Drawing.Size(56, 22)
        Me.TxTemperatura.TabIndex = 91
        Me.TxTemperatura.TeclaRepetida = False
        Me.TxTemperatura.TxDatoFinalSemana = Nothing
        Me.TxTemperatura.TxDatoInicioSemana = Nothing
        Me.TxTemperatura.UltimoValorValidado = Nothing
        '
        'LbTemperatura
        '
        Me.LbTemperatura.AutoSize = True
        Me.LbTemperatura.CL_ControlAsociado = Nothing
        Me.LbTemperatura.CL_ValorFijo = False
        Me.LbTemperatura.ClForm = Nothing
        Me.LbTemperatura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTemperatura.ForeColor = System.Drawing.Color.Teal
        Me.LbTemperatura.Location = New System.Drawing.Point(256, 116)
        Me.LbTemperatura.Name = "LbTemperatura"
        Me.LbTemperatura.Size = New System.Drawing.Size(102, 16)
        Me.LbTemperatura.TabIndex = 90
        Me.LbTemperatura.Text = "Temperatura"
        '
        'BtBuscaCargador
        '
        Me.BtBuscaCargador.CL_Ancho = 0
        Me.BtBuscaCargador.CL_BuscaAlb = False
        Me.BtBuscaCargador.CL_campocodigo = Nothing
        Me.BtBuscaCargador.CL_camponombre = Nothing
        Me.BtBuscaCargador.CL_CampoOrden = "Nombre"
        Me.BtBuscaCargador.CL_ch1000 = False
        Me.BtBuscaCargador.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCargador.CL_ControlAsociado = Me.TxCargador
        Me.BtBuscaCargador.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCargador.CL_dfecha = Nothing
        Me.BtBuscaCargador.CL_Entidad = Nothing
        Me.BtBuscaCargador.CL_EsId = True
        Me.BtBuscaCargador.CL_Filtro = Nothing
        Me.BtBuscaCargador.cl_formu = Nothing
        Me.BtBuscaCargador.CL_hfecha = Nothing
        Me.BtBuscaCargador.cl_ListaW = Nothing
        Me.BtBuscaCargador.CL_xCentro = False
        Me.BtBuscaCargador.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCargador.Location = New System.Drawing.Point(200, 141)
        Me.BtBuscaCargador.Name = "BtBuscaCargador"
        Me.BtBuscaCargador.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCargador.TabIndex = 94
        Me.BtBuscaCargador.UseVisualStyleBackColor = True
        '
        'TxCargador
        '
        Me.TxCargador.Autonumerico = False
        Me.TxCargador.Buscando = False
        Me.TxCargador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCargador.ClForm = Nothing
        Me.TxCargador.ClParam = Nothing
        Me.TxCargador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCargador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCargador.GridLin = Nothing
        Me.TxCargador.HaCambiado = False
        Me.TxCargador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCargador.lbbusca = Nothing
        Me.TxCargador.Location = New System.Drawing.Point(124, 141)
        Me.TxCargador.MiError = False
        Me.TxCargador.Name = "TxCargador"
        Me.TxCargador.Orden = 0
        Me.TxCargador.SaltoAlfinal = False
        Me.TxCargador.Siguiente = 0
        Me.TxCargador.Size = New System.Drawing.Size(69, 22)
        Me.TxCargador.TabIndex = 93
        Me.TxCargador.TeclaRepetida = False
        Me.TxCargador.TxDatoFinalSemana = Nothing
        Me.TxCargador.TxDatoInicioSemana = Nothing
        Me.TxCargador.UltimoValorValidado = Nothing
        '
        'LbCargador
        '
        Me.LbCargador.AutoSize = True
        Me.LbCargador.CL_ControlAsociado = Nothing
        Me.LbCargador.CL_ValorFijo = False
        Me.LbCargador.ClForm = Nothing
        Me.LbCargador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCargador.ForeColor = System.Drawing.Color.Teal
        Me.LbCargador.Location = New System.Drawing.Point(8, 143)
        Me.LbCargador.Name = "LbCargador"
        Me.LbCargador.Size = New System.Drawing.Size(81, 16)
        Me.LbCargador.TabIndex = 92
        Me.LbCargador.Text = "Verificado"
        '
        'LbNomTransportista
        '
        Me.LbNomTransportista.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomTransportista.CL_ControlAsociado = Nothing
        Me.LbNomTransportista.CL_ValorFijo = False
        Me.LbNomTransportista.ClForm = Nothing
        Me.LbNomTransportista.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTransportista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomTransportista.Location = New System.Drawing.Point(256, 32)
        Me.LbNomTransportista.Name = "LbNomTransportista"
        Me.LbNomTransportista.Size = New System.Drawing.Size(224, 21)
        Me.LbNomTransportista.TabIndex = 95
        '
        'LbNomCargador
        '
        Me.LbNomCargador.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCargador.CL_ControlAsociado = Nothing
        Me.LbNomCargador.CL_ValorFijo = False
        Me.LbNomCargador.ClForm = Nothing
        Me.LbNomCargador.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCargador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCargador.Location = New System.Drawing.Point(256, 142)
        Me.LbNomCargador.Name = "LbNomCargador"
        Me.LbNomCargador.Size = New System.Drawing.Size(224, 21)
        Me.LbNomCargador.TabIndex = 96
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.LbPalet6)
        Me.Panel2.Controls.Add(Me.LbPalet5)
        Me.Panel2.Controls.Add(Me.LbPalet4)
        Me.Panel2.Controls.Add(Me.LbPalet3)
        Me.Panel2.Controls.Add(Me.LbPalet2)
        Me.Panel2.Controls.Add(Me.LbPalet1)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.TxPedido6)
        Me.Panel2.Controls.Add(Me.TxPedido5)
        Me.Panel2.Controls.Add(Me.TxPedido4)
        Me.Panel2.Controls.Add(Me.TxPedido3)
        Me.Panel2.Controls.Add(Me.TxPedido2)
        Me.Panel2.Controls.Add(Me.TxPedido1)
        Me.Panel2.Controls.Add(Me.LbAlbaran6)
        Me.Panel2.Controls.Add(Me.LbAlbaran5)
        Me.Panel2.Controls.Add(Me.LbAlbaran4)
        Me.Panel2.Controls.Add(Me.LbAlbaran3)
        Me.Panel2.Controls.Add(Me.LbAlbaran2)
        Me.Panel2.Controls.Add(Me.LbAlbaran1)
        Me.Panel2.Controls.Add(Me.Lb19)
        Me.Panel2.Controls.Add(Me.Rb6)
        Me.Panel2.Controls.Add(Me.LbCliente6)
        Me.Panel2.Controls.Add(Me.Rb5)
        Me.Panel2.Controls.Add(Me.LbCliente5)
        Me.Panel2.Controls.Add(Me.Rb4)
        Me.Panel2.Controls.Add(Me.LbCliente4)
        Me.Panel2.Controls.Add(Me.Rb3)
        Me.Panel2.Controls.Add(Me.LbCliente3)
        Me.Panel2.Controls.Add(Me.Rb2)
        Me.Panel2.Controls.Add(Me.LbCliente2)
        Me.Panel2.Controls.Add(Me.Rb1)
        Me.Panel2.Controls.Add(Me.LbCliente1)
        Me.Panel2.Controls.Add(Me.Lb12)
        Me.Panel2.Controls.Add(Me.Lb11)
        Me.Panel2.Controls.Add(Me.LbPedido)
        Me.Panel2.Location = New System.Drawing.Point(12, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 201)
        Me.Panel2.TabIndex = 97
        '
        'LbPalet6
        '
        Me.LbPalet6.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet6.CL_ControlAsociado = Nothing
        Me.LbPalet6.CL_ValorFijo = False
        Me.LbPalet6.ClForm = Nothing
        Me.LbPalet6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet6.Location = New System.Drawing.Point(375, 166)
        Me.LbPalet6.Name = "LbPalet6"
        Me.LbPalet6.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet6.TabIndex = 135
        '
        'LbPalet5
        '
        Me.LbPalet5.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet5.CL_ControlAsociado = Nothing
        Me.LbPalet5.CL_ValorFijo = False
        Me.LbPalet5.ClForm = Nothing
        Me.LbPalet5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet5.Location = New System.Drawing.Point(375, 139)
        Me.LbPalet5.Name = "LbPalet5"
        Me.LbPalet5.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet5.TabIndex = 134
        '
        'LbPalet4
        '
        Me.LbPalet4.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet4.CL_ControlAsociado = Nothing
        Me.LbPalet4.CL_ValorFijo = False
        Me.LbPalet4.ClForm = Nothing
        Me.LbPalet4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet4.Location = New System.Drawing.Point(375, 111)
        Me.LbPalet4.Name = "LbPalet4"
        Me.LbPalet4.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet4.TabIndex = 133
        '
        'LbPalet3
        '
        Me.LbPalet3.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet3.CL_ControlAsociado = Nothing
        Me.LbPalet3.CL_ValorFijo = False
        Me.LbPalet3.ClForm = Nothing
        Me.LbPalet3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet3.Location = New System.Drawing.Point(375, 83)
        Me.LbPalet3.Name = "LbPalet3"
        Me.LbPalet3.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet3.TabIndex = 132
        '
        'LbPalet2
        '
        Me.LbPalet2.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet2.CL_ControlAsociado = Nothing
        Me.LbPalet2.CL_ValorFijo = False
        Me.LbPalet2.ClForm = Nothing
        Me.LbPalet2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet2.Location = New System.Drawing.Point(375, 55)
        Me.LbPalet2.Name = "LbPalet2"
        Me.LbPalet2.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet2.TabIndex = 131
        '
        'LbPalet1
        '
        Me.LbPalet1.BackColor = System.Drawing.SystemColors.Control
        Me.LbPalet1.CL_ControlAsociado = Nothing
        Me.LbPalet1.CL_ValorFijo = False
        Me.LbPalet1.ClForm = Nothing
        Me.LbPalet1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet1.Location = New System.Drawing.Point(375, 26)
        Me.LbPalet1.Name = "LbPalet1"
        Me.LbPalet1.Size = New System.Drawing.Size(41, 21)
        Me.LbPalet1.TabIndex = 130
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Blue
        Me.Lb1.Location = New System.Drawing.Point(369, 6)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(47, 13)
        Me.Lb1.TabIndex = 129
        Me.Lb1.Text = "Palets"
        '
        'TxPedido6
        '
        Me.TxPedido6.Autonumerico = False
        Me.TxPedido6.Buscando = False
        Me.TxPedido6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido6.ClForm = Nothing
        Me.TxPedido6.ClParam = Nothing
        Me.TxPedido6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido6.GridLin = Nothing
        Me.TxPedido6.HaCambiado = False
        Me.TxPedido6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido6.lbbusca = Nothing
        Me.TxPedido6.Location = New System.Drawing.Point(3, 166)
        Me.TxPedido6.MiError = False
        Me.TxPedido6.Name = "TxPedido6"
        Me.TxPedido6.Orden = 0
        Me.TxPedido6.SaltoAlfinal = False
        Me.TxPedido6.Siguiente = 0
        Me.TxPedido6.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido6.TabIndex = 128
        Me.TxPedido6.TeclaRepetida = False
        Me.TxPedido6.TxDatoFinalSemana = Nothing
        Me.TxPedido6.TxDatoInicioSemana = Nothing
        Me.TxPedido6.UltimoValorValidado = Nothing
        '
        'TxPedido5
        '
        Me.TxPedido5.Autonumerico = False
        Me.TxPedido5.Buscando = False
        Me.TxPedido5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido5.ClForm = Nothing
        Me.TxPedido5.ClParam = Nothing
        Me.TxPedido5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido5.GridLin = Nothing
        Me.TxPedido5.HaCambiado = False
        Me.TxPedido5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido5.lbbusca = Nothing
        Me.TxPedido5.Location = New System.Drawing.Point(3, 139)
        Me.TxPedido5.MiError = False
        Me.TxPedido5.Name = "TxPedido5"
        Me.TxPedido5.Orden = 0
        Me.TxPedido5.SaltoAlfinal = False
        Me.TxPedido5.Siguiente = 0
        Me.TxPedido5.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido5.TabIndex = 127
        Me.TxPedido5.TeclaRepetida = False
        Me.TxPedido5.TxDatoFinalSemana = Nothing
        Me.TxPedido5.TxDatoInicioSemana = Nothing
        Me.TxPedido5.UltimoValorValidado = Nothing
        '
        'TxPedido4
        '
        Me.TxPedido4.Autonumerico = False
        Me.TxPedido4.Buscando = False
        Me.TxPedido4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido4.ClForm = Nothing
        Me.TxPedido4.ClParam = Nothing
        Me.TxPedido4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido4.GridLin = Nothing
        Me.TxPedido4.HaCambiado = False
        Me.TxPedido4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido4.lbbusca = Nothing
        Me.TxPedido4.Location = New System.Drawing.Point(3, 111)
        Me.TxPedido4.MiError = False
        Me.TxPedido4.Name = "TxPedido4"
        Me.TxPedido4.Orden = 0
        Me.TxPedido4.SaltoAlfinal = False
        Me.TxPedido4.Siguiente = 0
        Me.TxPedido4.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido4.TabIndex = 126
        Me.TxPedido4.TeclaRepetida = False
        Me.TxPedido4.TxDatoFinalSemana = Nothing
        Me.TxPedido4.TxDatoInicioSemana = Nothing
        Me.TxPedido4.UltimoValorValidado = Nothing
        '
        'TxPedido3
        '
        Me.TxPedido3.Autonumerico = False
        Me.TxPedido3.Buscando = False
        Me.TxPedido3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido3.ClForm = Nothing
        Me.TxPedido3.ClParam = Nothing
        Me.TxPedido3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido3.GridLin = Nothing
        Me.TxPedido3.HaCambiado = False
        Me.TxPedido3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido3.lbbusca = Nothing
        Me.TxPedido3.Location = New System.Drawing.Point(3, 83)
        Me.TxPedido3.MiError = False
        Me.TxPedido3.Name = "TxPedido3"
        Me.TxPedido3.Orden = 0
        Me.TxPedido3.SaltoAlfinal = False
        Me.TxPedido3.Siguiente = 0
        Me.TxPedido3.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido3.TabIndex = 125
        Me.TxPedido3.TeclaRepetida = False
        Me.TxPedido3.TxDatoFinalSemana = Nothing
        Me.TxPedido3.TxDatoInicioSemana = Nothing
        Me.TxPedido3.UltimoValorValidado = Nothing
        '
        'TxPedido2
        '
        Me.TxPedido2.Autonumerico = False
        Me.TxPedido2.Buscando = False
        Me.TxPedido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido2.ClForm = Nothing
        Me.TxPedido2.ClParam = Nothing
        Me.TxPedido2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido2.GridLin = Nothing
        Me.TxPedido2.HaCambiado = False
        Me.TxPedido2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido2.lbbusca = Nothing
        Me.TxPedido2.Location = New System.Drawing.Point(3, 55)
        Me.TxPedido2.MiError = False
        Me.TxPedido2.Name = "TxPedido2"
        Me.TxPedido2.Orden = 0
        Me.TxPedido2.SaltoAlfinal = False
        Me.TxPedido2.Siguiente = 0
        Me.TxPedido2.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido2.TabIndex = 124
        Me.TxPedido2.TeclaRepetida = False
        Me.TxPedido2.TxDatoFinalSemana = Nothing
        Me.TxPedido2.TxDatoInicioSemana = Nothing
        Me.TxPedido2.UltimoValorValidado = Nothing
        '
        'TxPedido1
        '
        Me.TxPedido1.Autonumerico = False
        Me.TxPedido1.Buscando = False
        Me.TxPedido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPedido1.ClForm = Nothing
        Me.TxPedido1.ClParam = Nothing
        Me.TxPedido1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPedido1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPedido1.GridLin = Nothing
        Me.TxPedido1.HaCambiado = False
        Me.TxPedido1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPedido1.lbbusca = Nothing
        Me.TxPedido1.Location = New System.Drawing.Point(3, 26)
        Me.TxPedido1.MiError = False
        Me.TxPedido1.Name = "TxPedido1"
        Me.TxPedido1.Orden = 0
        Me.TxPedido1.SaltoAlfinal = False
        Me.TxPedido1.Siguiente = 0
        Me.TxPedido1.Size = New System.Drawing.Size(61, 21)
        Me.TxPedido1.TabIndex = 123
        Me.TxPedido1.TeclaRepetida = False
        Me.TxPedido1.TxDatoFinalSemana = Nothing
        Me.TxPedido1.TxDatoInicioSemana = Nothing
        Me.TxPedido1.UltimoValorValidado = Nothing
        '
        'LbAlbaran6
        '
        Me.LbAlbaran6.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran6.CL_ControlAsociado = Nothing
        Me.LbAlbaran6.CL_ValorFijo = False
        Me.LbAlbaran6.ClForm = Nothing
        Me.LbAlbaran6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran6.Location = New System.Drawing.Point(70, 166)
        Me.LbAlbaran6.Name = "LbAlbaran6"
        Me.LbAlbaran6.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran6.TabIndex = 122
        '
        'LbAlbaran5
        '
        Me.LbAlbaran5.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran5.CL_ControlAsociado = Nothing
        Me.LbAlbaran5.CL_ValorFijo = False
        Me.LbAlbaran5.ClForm = Nothing
        Me.LbAlbaran5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran5.Location = New System.Drawing.Point(70, 139)
        Me.LbAlbaran5.Name = "LbAlbaran5"
        Me.LbAlbaran5.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran5.TabIndex = 121
        '
        'LbAlbaran4
        '
        Me.LbAlbaran4.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran4.CL_ControlAsociado = Nothing
        Me.LbAlbaran4.CL_ValorFijo = False
        Me.LbAlbaran4.ClForm = Nothing
        Me.LbAlbaran4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran4.Location = New System.Drawing.Point(70, 111)
        Me.LbAlbaran4.Name = "LbAlbaran4"
        Me.LbAlbaran4.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran4.TabIndex = 120
        '
        'LbAlbaran3
        '
        Me.LbAlbaran3.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran3.CL_ControlAsociado = Nothing
        Me.LbAlbaran3.CL_ValorFijo = False
        Me.LbAlbaran3.ClForm = Nothing
        Me.LbAlbaran3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran3.Location = New System.Drawing.Point(70, 83)
        Me.LbAlbaran3.Name = "LbAlbaran3"
        Me.LbAlbaran3.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran3.TabIndex = 119
        '
        'LbAlbaran2
        '
        Me.LbAlbaran2.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran2.CL_ControlAsociado = Nothing
        Me.LbAlbaran2.CL_ValorFijo = False
        Me.LbAlbaran2.ClForm = Nothing
        Me.LbAlbaran2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran2.Location = New System.Drawing.Point(70, 55)
        Me.LbAlbaran2.Name = "LbAlbaran2"
        Me.LbAlbaran2.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran2.TabIndex = 118
        '
        'LbAlbaran1
        '
        Me.LbAlbaran1.BackColor = System.Drawing.SystemColors.Control
        Me.LbAlbaran1.CL_ControlAsociado = Nothing
        Me.LbAlbaran1.CL_ValorFijo = False
        Me.LbAlbaran1.ClForm = Nothing
        Me.LbAlbaran1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran1.Location = New System.Drawing.Point(70, 26)
        Me.LbAlbaran1.Name = "LbAlbaran1"
        Me.LbAlbaran1.Size = New System.Drawing.Size(56, 21)
        Me.LbAlbaran1.TabIndex = 117
        '
        'Lb19
        '
        Me.Lb19.AutoSize = True
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = True
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.Blue
        Me.Lb19.Location = New System.Drawing.Point(70, 6)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(58, 13)
        Me.Lb19.TabIndex = 116
        Me.Lb19.Text = "Albarán"
        '
        'Rb6
        '
        Me.Rb6.AutoSize = True
        Me.Rb6.Location = New System.Drawing.Point(422, 171)
        Me.Rb6.Name = "Rb6"
        Me.Rb6.Size = New System.Drawing.Size(14, 13)
        Me.Rb6.TabIndex = 115
        Me.Rb6.TabStop = True
        Me.Rb6.UseVisualStyleBackColor = True
        '
        'LbCliente6
        '
        Me.LbCliente6.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente6.CL_ControlAsociado = Nothing
        Me.LbCliente6.CL_ValorFijo = False
        Me.LbCliente6.ClForm = Nothing
        Me.LbCliente6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente6.Location = New System.Drawing.Point(132, 166)
        Me.LbCliente6.Name = "LbCliente6"
        Me.LbCliente6.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente6.TabIndex = 113
        '
        'Rb5
        '
        Me.Rb5.AutoSize = True
        Me.Rb5.Location = New System.Drawing.Point(422, 143)
        Me.Rb5.Name = "Rb5"
        Me.Rb5.Size = New System.Drawing.Size(14, 13)
        Me.Rb5.TabIndex = 112
        Me.Rb5.TabStop = True
        Me.Rb5.UseVisualStyleBackColor = True
        '
        'LbCliente5
        '
        Me.LbCliente5.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente5.CL_ControlAsociado = Nothing
        Me.LbCliente5.CL_ValorFijo = False
        Me.LbCliente5.ClForm = Nothing
        Me.LbCliente5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente5.Location = New System.Drawing.Point(132, 139)
        Me.LbCliente5.Name = "LbCliente5"
        Me.LbCliente5.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente5.TabIndex = 110
        '
        'Rb4
        '
        Me.Rb4.AutoSize = True
        Me.Rb4.Location = New System.Drawing.Point(422, 115)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(14, 13)
        Me.Rb4.TabIndex = 109
        Me.Rb4.TabStop = True
        Me.Rb4.UseVisualStyleBackColor = True
        '
        'LbCliente4
        '
        Me.LbCliente4.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente4.CL_ControlAsociado = Nothing
        Me.LbCliente4.CL_ValorFijo = False
        Me.LbCliente4.ClForm = Nothing
        Me.LbCliente4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente4.Location = New System.Drawing.Point(132, 111)
        Me.LbCliente4.Name = "LbCliente4"
        Me.LbCliente4.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente4.TabIndex = 107
        '
        'Rb3
        '
        Me.Rb3.AutoSize = True
        Me.Rb3.Location = New System.Drawing.Point(422, 87)
        Me.Rb3.Name = "Rb3"
        Me.Rb3.Size = New System.Drawing.Size(14, 13)
        Me.Rb3.TabIndex = 106
        Me.Rb3.TabStop = True
        Me.Rb3.UseVisualStyleBackColor = True
        '
        'LbCliente3
        '
        Me.LbCliente3.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente3.CL_ControlAsociado = Nothing
        Me.LbCliente3.CL_ValorFijo = False
        Me.LbCliente3.ClForm = Nothing
        Me.LbCliente3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente3.Location = New System.Drawing.Point(132, 83)
        Me.LbCliente3.Name = "LbCliente3"
        Me.LbCliente3.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente3.TabIndex = 104
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Location = New System.Drawing.Point(422, 60)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(14, 13)
        Me.Rb2.TabIndex = 103
        Me.Rb2.TabStop = True
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'LbCliente2
        '
        Me.LbCliente2.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente2.CL_ControlAsociado = Nothing
        Me.LbCliente2.CL_ValorFijo = False
        Me.LbCliente2.ClForm = Nothing
        Me.LbCliente2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente2.Location = New System.Drawing.Point(132, 55)
        Me.LbCliente2.Name = "LbCliente2"
        Me.LbCliente2.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente2.TabIndex = 101
        '
        'Rb1
        '
        Me.Rb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb1.Location = New System.Drawing.Point(422, 30)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(14, 24)
        Me.Rb1.TabIndex = 100
        Me.Rb1.TabStop = True
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'LbCliente1
        '
        Me.LbCliente1.BackColor = System.Drawing.SystemColors.Control
        Me.LbCliente1.CL_ControlAsociado = Nothing
        Me.LbCliente1.CL_ValorFijo = False
        Me.LbCliente1.ClForm = Nothing
        Me.LbCliente1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente1.Location = New System.Drawing.Point(132, 26)
        Me.LbCliente1.Name = "LbCliente1"
        Me.LbCliente1.Size = New System.Drawing.Size(238, 21)
        Me.LbCliente1.TabIndex = 97
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Blue
        Me.Lb12.Location = New System.Drawing.Point(419, 6)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(45, 13)
        Me.Lb12.TabIndex = 80
        Me.Lb12.Text = "Carga"
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Blue
        Me.Lb11.Location = New System.Drawing.Point(134, 6)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(52, 13)
        Me.Lb11.TabIndex = 79
        Me.Lb11.Text = "Cliente"
        '
        'LbPedido
        '
        Me.LbPedido.AutoSize = True
        Me.LbPedido.CL_ControlAsociado = Nothing
        Me.LbPedido.CL_ValorFijo = False
        Me.LbPedido.ClForm = Nothing
        Me.LbPedido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPedido.ForeColor = System.Drawing.Color.Blue
        Me.LbPedido.Location = New System.Drawing.Point(13, 6)
        Me.LbPedido.Name = "LbPedido"
        Me.LbPedido.Size = New System.Drawing.Size(51, 13)
        Me.LbPedido.TabIndex = 78
        Me.LbPedido.Text = "Pedido"
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.GridInspec)
        Me.PanelGrid.Location = New System.Drawing.Point(486, 34)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(161, 205)
        Me.PanelGrid.TabIndex = 99
        '
        'GridInspec
        '
        Me.GridInspec.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.GridInspec.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridInspec.Location = New System.Drawing.Point(0, 0)
        Me.GridInspec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridInspec.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridInspec.MainView = Me.GridViewInspec
        Me.GridInspec.Name = "GridInspec"
        Me.GridInspec.Size = New System.Drawing.Size(161, 205)
        Me.GridInspec.TabIndex = 99
        Me.GridInspec.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewInspec})
        '
        'GridViewInspec
        '
        Me.GridViewInspec.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewInspec.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewInspec.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewInspec.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewInspec.Appearance.Row.Options.UseFont = True
        Me.GridViewInspec.GridControl = Me.GridInspec
        Me.GridViewInspec.Name = "GridViewInspec"
        '
        'BtPalet
        '
        Me.BtPalet.Location = New System.Drawing.Point(499, 245)
        Me.BtPalet.Name = "BtPalet"
        Me.BtPalet.Size = New System.Drawing.Size(114, 25)
        Me.BtPalet.TabIndex = 100
        Me.BtPalet.Text = "Cargar palet"
        Me.BtPalet.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(538, 6)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(55, 16)
        Me.Lb2.TabIndex = 101
        Me.Lb2.Text = "Muelle"
        '
        'LbMuelle
        '
        Me.LbMuelle.BackColor = System.Drawing.Color.White
        Me.LbMuelle.CL_ControlAsociado = Nothing
        Me.LbMuelle.CL_ValorFijo = True
        Me.LbMuelle.ClForm = Nothing
        Me.LbMuelle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMuelle.ForeColor = System.Drawing.Color.Red
        Me.LbMuelle.Location = New System.Drawing.Point(612, 4)
        Me.LbMuelle.Name = "LbMuelle"
        Me.LbMuelle.Size = New System.Drawing.Size(35, 21)
        Me.LbMuelle.TabIndex = 102
        Me.LbMuelle.Text = "1"
        Me.LbMuelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbNumPaletAlbaran
        '
        Me.LbNumPaletAlbaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNumPaletAlbaran.CL_ControlAsociado = Nothing
        Me.LbNumPaletAlbaran.CL_ValorFijo = True
        Me.LbNumPaletAlbaran.ClForm = Nothing
        Me.LbNumPaletAlbaran.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumPaletAlbaran.ForeColor = System.Drawing.Color.Red
        Me.LbNumPaletAlbaran.Location = New System.Drawing.Point(546, 377)
        Me.LbNumPaletAlbaran.Name = "LbNumPaletAlbaran"
        Me.LbNumPaletAlbaran.Size = New System.Drawing.Size(86, 72)
        Me.LbNumPaletAlbaran.TabIndex = 103
        Me.LbNumPaletAlbaran.Text = "00"
        Me.LbNumPaletAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbNumPaletTotal
        '
        Me.LbNumPaletTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LbNumPaletTotal.CL_ControlAsociado = Nothing
        Me.LbNumPaletTotal.CL_ValorFijo = True
        Me.LbNumPaletTotal.ClForm = Nothing
        Me.LbNumPaletTotal.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumPaletTotal.ForeColor = System.Drawing.Color.Red
        Me.LbNumPaletTotal.Location = New System.Drawing.Point(486, 277)
        Me.LbNumPaletTotal.Name = "LbNumPaletTotal"
        Me.LbNumPaletTotal.Size = New System.Drawing.Size(146, 89)
        Me.LbNumPaletTotal.TabIndex = 104
        Me.LbNumPaletTotal.Text = "00"
        Me.LbNumPaletTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PanelPedido
        '
        Me.PanelPedido.BackColor = System.Drawing.Color.Blue
        Me.PanelPedido.Controls.Add(Me.Button2)
        Me.PanelPedido.Controls.Add(Me.Label7)
        Me.PanelPedido.Controls.Add(Me.Label6)
        Me.PanelPedido.Controls.Add(Me.Label5)
        Me.PanelPedido.Controls.Add(Me.LbAlbaran)
        Me.PanelPedido.Controls.Add(Me.GridPedido)
        Me.PanelPedido.Controls.Add(Me.LbPalPte)
        Me.PanelPedido.Controls.Add(Me.LbParCar)
        Me.PanelPedido.Controls.Add(Me.LbPalped)
        Me.PanelPedido.Controls.Add(Me.Label3)
        Me.PanelPedido.Controls.Add(Me.Label2)
        Me.PanelPedido.Controls.Add(Me.Label4)
        Me.PanelPedido.Controls.Add(Me.LbCliente)
        Me.PanelPedido.Controls.Add(Me.LbNped)
        Me.PanelPedido.Location = New System.Drawing.Point(12, 4)
        Me.PanelPedido.Name = "PanelPedido"
        Me.PanelPedido.Size = New System.Drawing.Size(27, 23)
        Me.PanelPedido.TabIndex = 105
        Me.PanelPedido.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(469, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 41)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "Cerrar ventana"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 23)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 23)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Albarán"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Pedido"
        '
        'LbAlbaran
        '
        Me.LbAlbaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbAlbaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbAlbaran.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran.Location = New System.Drawing.Point(132, 38)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(124, 34)
        Me.LbAlbaran.TabIndex = 114
        '
        'GridPedido
        '
        GridLevelNode3.RelationName = "Level1"
        Me.GridPedido.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        Me.GridPedido.Location = New System.Drawing.Point(7, 259)
        Me.GridPedido.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPedido.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPedido.MainView = Me.GridPedidoView
        Me.GridPedido.Name = "GridPedido"
        Me.GridPedido.Size = New System.Drawing.Size(585, 183)
        Me.GridPedido.TabIndex = 113
        Me.GridPedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPedidoView})
        '
        'GridPedidoView
        '
        Me.GridPedidoView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridPedidoView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridPedidoView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridPedidoView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridPedidoView.Appearance.Row.Options.UseFont = True
        Me.GridPedidoView.GridControl = Me.GridPedido
        Me.GridPedidoView.Name = "GridPedidoView"
        '
        'LbPalPte
        '
        Me.LbPalPte.BackColor = System.Drawing.Color.White
        Me.LbPalPte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPalPte.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalPte.ForeColor = System.Drawing.Color.Red
        Me.LbPalPte.Location = New System.Drawing.Point(401, 113)
        Me.LbPalPte.Name = "LbPalPte"
        Me.LbPalPte.Size = New System.Drawing.Size(191, 143)
        Me.LbPalPte.TabIndex = 112
        Me.LbPalPte.Text = "00"
        Me.LbPalPte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbParCar
        '
        Me.LbParCar.BackColor = System.Drawing.Color.White
        Me.LbParCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbParCar.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbParCar.Location = New System.Drawing.Point(204, 113)
        Me.LbParCar.Name = "LbParCar"
        Me.LbParCar.Size = New System.Drawing.Size(191, 143)
        Me.LbParCar.TabIndex = 111
        Me.LbParCar.Text = "00"
        Me.LbParCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbPalped
        '
        Me.LbPalped.BackColor = System.Drawing.Color.White
        Me.LbPalped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPalped.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalped.Location = New System.Drawing.Point(7, 113)
        Me.LbPalped.Name = "LbPalped"
        Me.LbPalped.Size = New System.Drawing.Size(191, 143)
        Me.LbPalped.TabIndex = 110
        Me.LbPalped.Text = "00"
        Me.LbPalped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 34)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "PENDIENTES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 34)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "CARGADOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 34)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "PEDIDOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.Location = New System.Drawing.Point(258, 38)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(334, 34)
        Me.LbCliente.TabIndex = 106
        '
        'LbNped
        '
        Me.LbNped.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbNped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNped.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNped.Location = New System.Drawing.Point(7, 38)
        Me.LbNped.Name = "LbNped"
        Me.LbNped.Size = New System.Drawing.Size(124, 34)
        Me.LbNped.TabIndex = 105
        '
        'FrmCargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 568)
        Me.Controls.Add(Me.PanelPedido)
        Me.Controls.Add(Me.LbNumPaletTotal)
        Me.Controls.Add(Me.LbNumPaletAlbaran)
        Me.Controls.Add(Me.LbMuelle)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.BtPalet)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LbNomCargador)
        Me.Controls.Add(Me.LbNomTransportista)
        Me.Controls.Add(Me.BtBuscaCargador)
        Me.Controls.Add(Me.TxCargador)
        Me.Controls.Add(Me.LbCargador)
        Me.Controls.Add(Me.TxTemperatura)
        Me.Controls.Add(Me.LbTemperatura)
        Me.Controls.Add(Me.TxReparto)
        Me.Controls.Add(Me.LbReparto)
        Me.Controls.Add(Me.TxConcepto)
        Me.Controls.Add(Me.BtBuscaConcepto)
        Me.Controls.Add(Me.TxIdConcepto)
        Me.Controls.Add(Me.LbConcepto)
        Me.Controls.Add(Me.TxMatricula)
        Me.Controls.Add(Me.LbMatricula)
        Me.Controls.Add(Me.BtBuscaTransportista)
        Me.Controls.Add(Me.TxTransportista)
        Me.Controls.Add(Me.LbTransportista)
        Me.Controls.Add(Me.TxFecha)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.BtBuscaCarga)
        Me.Controls.Add(Me.TxCarga)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.LbCarga)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCargas"
        Me.Text = "Cargas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbCarga, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxCarga, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCarga, 0)
        Me.Controls.SetChildIndex(Me.LbFecha, 0)
        Me.Controls.SetChildIndex(Me.TxFecha, 0)
        Me.Controls.SetChildIndex(Me.LbTransportista, 0)
        Me.Controls.SetChildIndex(Me.TxTransportista, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaTransportista, 0)
        Me.Controls.SetChildIndex(Me.LbMatricula, 0)
        Me.Controls.SetChildIndex(Me.TxMatricula, 0)
        Me.Controls.SetChildIndex(Me.LbConcepto, 0)
        Me.Controls.SetChildIndex(Me.TxIdConcepto, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaConcepto, 0)
        Me.Controls.SetChildIndex(Me.TxConcepto, 0)
        Me.Controls.SetChildIndex(Me.LbReparto, 0)
        Me.Controls.SetChildIndex(Me.TxReparto, 0)
        Me.Controls.SetChildIndex(Me.LbTemperatura, 0)
        Me.Controls.SetChildIndex(Me.TxTemperatura, 0)
        Me.Controls.SetChildIndex(Me.LbCargador, 0)
        Me.Controls.SetChildIndex(Me.TxCargador, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCargador, 0)
        Me.Controls.SetChildIndex(Me.LbNomTransportista, 0)
        Me.Controls.SetChildIndex(Me.LbNomCargador, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.PanelGrid, 0)
        Me.Controls.SetChildIndex(Me.BtPalet, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.LbMuelle, 0)
        Me.Controls.SetChildIndex(Me.LbNumPaletAlbaran, 0)
        Me.Controls.SetChildIndex(Me.LbNumPaletTotal, 0)
        Me.Controls.SetChildIndex(Me.PanelPedido, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.GridInspec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewInspec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPedido.ResumeLayout(False)
        Me.PanelPedido.PerformLayout()
        CType(Me.GridPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPedidoView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbCarga As NetAgro.Lb
    Friend WithEvents TxCarga As NetAgro.TxDato
    Friend WithEvents BtBuscaCarga As NetAgro.BtBusca
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents BtBuscaTransportista As NetAgro.BtBusca
    Friend WithEvents TxTransportista As NetAgro.TxDato
    Friend WithEvents LbTransportista As NetAgro.Lb
    Friend WithEvents TxMatricula As NetAgro.TxDato
    Friend WithEvents LbMatricula As NetAgro.Lb
    Friend WithEvents BtBuscaConcepto As NetAgro.BtBusca
    Friend WithEvents TxIdConcepto As NetAgro.TxDato
    Friend WithEvents LbConcepto As NetAgro.Lb
    Friend WithEvents TxConcepto As NetAgro.TxDato
    Friend WithEvents TxReparto As NetAgro.TxDato
    Friend WithEvents LbReparto As NetAgro.Lb
    Friend WithEvents TxTemperatura As NetAgro.TxDato
    Friend WithEvents LbTemperatura As NetAgro.Lb
    Friend WithEvents BtBuscaCargador As NetAgro.BtBusca
    Friend WithEvents TxCargador As NetAgro.TxDato
    Friend WithEvents LbCargador As NetAgro.Lb
    Friend WithEvents LbNomTransportista As NetAgro.Lb
    Friend WithEvents LbNomCargador As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbAlbaran6 As NetAgro.Lb
    Friend WithEvents LbAlbaran5 As NetAgro.Lb
    Friend WithEvents LbAlbaran4 As NetAgro.Lb
    Friend WithEvents LbAlbaran3 As NetAgro.Lb
    Friend WithEvents LbAlbaran2 As NetAgro.Lb
    Friend WithEvents LbAlbaran1 As NetAgro.Lb
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents Rb6 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente6 As NetAgro.Lb
    Friend WithEvents Rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente5 As NetAgro.Lb
    Friend WithEvents Rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente4 As NetAgro.Lb
    Friend WithEvents Rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente3 As NetAgro.Lb
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente2 As NetAgro.Lb
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents LbCliente1 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbPedido As NetAgro.Lb
    Friend WithEvents TxPedido6 As NetAgro.TxDato
    Friend WithEvents TxPedido5 As NetAgro.TxDato
    Friend WithEvents TxPedido4 As NetAgro.TxDato
    Friend WithEvents TxPedido3 As NetAgro.TxDato
    Friend WithEvents TxPedido2 As NetAgro.TxDato
    Friend WithEvents TxPedido1 As NetAgro.TxDato
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents GridInspec As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewInspec As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbPalet6 As NetAgro.Lb
    Friend WithEvents LbPalet5 As NetAgro.Lb
    Friend WithEvents LbPalet4 As NetAgro.Lb
    Friend WithEvents LbPalet3 As NetAgro.Lb
    Friend WithEvents LbPalet2 As NetAgro.Lb
    Friend WithEvents LbPalet1 As NetAgro.Lb
    Friend WithEvents BtPalet As System.Windows.Forms.Button
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbMuelle As NetAgro.Lb
    Friend WithEvents LbNumPaletAlbaran As NetAgro.Lb
    Friend WithEvents LbNumPaletTotal As NetAgro.Lb
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelPedido As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LbAlbaran As System.Windows.Forms.Label
    Friend WithEvents GridPedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridPedidoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbPalPte As System.Windows.Forms.Label
    Friend WithEvents LbParCar As System.Windows.Forms.Label
    Friend WithEvents LbPalped As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbCliente As System.Windows.Forms.Label
    Friend WithEvents LbNped As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
