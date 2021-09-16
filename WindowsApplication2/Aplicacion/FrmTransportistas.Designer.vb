<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransportistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransportistas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtBuscaTransportista = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaNif = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridContactos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewContactos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.CbTipoPorte = New NetAgro.CbBox(Me.components)
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.Lb24 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.GridDelegaciones = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDelegaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lbpais = New NetAgro.Lb(Me.components)
        Me.LbProvincia = New NetAgro.Lb(Me.components)
        Me.LbPoblacion = New NetAgro.Lb(Me.components)
        Me.LbCpostal = New NetAgro.Lb(Me.components)
        Me.LbDomicilio = New NetAgro.Lb(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.Lb25 = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.Panel2.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridDelegaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDelegaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(274, 216)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.BtBuscaTransportista)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.BotonesAvance1)
        Me.Panel2.Controls.Add(Me.BtBuscaNif)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 64)
        Me.Panel2.TabIndex = 6
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
        Me.BtBuscaTransportista.CL_ControlAsociado = Me.TxDato1
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
        Me.BtBuscaTransportista.Location = New System.Drawing.Point(152, 5)
        Me.BtBuscaTransportista.Name = "BtBuscaTransportista"
        Me.BtBuscaTransportista.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTransportista.TabIndex = 28
        Me.BtBuscaTransportista.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(87, 5)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(59, 22)
        Me.TxDato1.TabIndex = 21
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(344, 9)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(27, 16)
        Me.Lb3.TabIndex = 27
        Me.Lb3.Text = "Nif"
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
        Me.TxDato3.Location = New System.Drawing.Point(394, 5)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(136, 22)
        Me.TxDato3.TabIndex = 26
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 36)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 25
        Me.Lb2.Text = "Nombre"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(87, 34)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(508, 22)
        Me.TxDato2.TabIndex = 24
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(191, 4)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 20
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaNif
        '
        Me.BtBuscaNif.CL_Ancho = 0
        Me.BtBuscaNif.CL_BuscaAlb = False
        Me.BtBuscaNif.CL_campocodigo = Nothing
        Me.BtBuscaNif.CL_camponombre = Nothing
        Me.BtBuscaNif.CL_CampoOrden = "Nombre"
        Me.BtBuscaNif.CL_ch1000 = False
        Me.BtBuscaNif.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaNif.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaNif.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaNif.CL_dfecha = Nothing
        Me.BtBuscaNif.CL_Entidad = Nothing
        Me.BtBuscaNif.CL_EsId = True
        Me.BtBuscaNif.CL_Filtro = Nothing
        Me.BtBuscaNif.cl_formu = Nothing
        Me.BtBuscaNif.CL_hfecha = Nothing
        Me.BtBuscaNif.cl_ListaW = Nothing
        Me.BtBuscaNif.CL_xCentro = False
        Me.BtBuscaNif.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaNif.Location = New System.Drawing.Point(536, 4)
        Me.BtBuscaNif.Name = "BtBuscaNif"
        Me.BtBuscaNif.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaNif.TabIndex = 23
        Me.BtBuscaNif.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 22
        Me.Lb1.Text = "Código"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(974, 408)
        Me.XtraTabPage2.Text = "Contactos / Mail"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.GridContactos)
        Me.Panel4.Controls.Add(Me.Lb6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(974, 408)
        Me.Panel4.TabIndex = 73
        '
        'GridContactos
        '
        Me.GridContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridContactos.Location = New System.Drawing.Point(0, 22)
        Me.GridContactos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridContactos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridContactos.MainView = Me.GridViewContactos
        Me.GridContactos.Name = "GridContactos"
        Me.GridContactos.Size = New System.Drawing.Size(974, 386)
        Me.GridContactos.TabIndex = 71
        Me.GridContactos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewContactos, Me.GridView2})
        '
        'GridViewContactos
        '
        Me.GridViewContactos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewContactos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSkyBlue
        Me.GridViewContactos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewContactos.GridControl = Me.GridContactos
        Me.GridViewContactos.Name = "GridViewContactos"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridContactos
        Me.GridView2.Name = "GridView2"
        '
        'Lb6
        '
        Me.Lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(0, 0)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(974, 22)
        Me.Lb6.TabIndex = 70
        Me.Lb6.Text = "Contactos"
        Me.Lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Silver
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Lb7)
        Me.XtraTabPage1.Controls.Add(Me.CbTipoPorte)
        Me.XtraTabPage1.Controls.Add(Me.Lb26)
        Me.XtraTabPage1.Controls.Add(Me.Lb24)
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Lbpais)
        Me.XtraTabPage1.Controls.Add(Me.LbProvincia)
        Me.XtraTabPage1.Controls.Add(Me.LbPoblacion)
        Me.XtraTabPage1.Controls.Add(Me.LbCpostal)
        Me.XtraTabPage1.Controls.Add(Me.LbDomicilio)
        Me.XtraTabPage1.Controls.Add(Me.LbNombre)
        Me.XtraTabPage1.Controls.Add(Me.Lb25)
        Me.XtraTabPage1.Controls.Add(Me.Lb14)
        Me.XtraTabPage1.Controls.Add(Me.Lb13)
        Me.XtraTabPage1.Controls.Add(Me.Lb8)
        Me.XtraTabPage1.Controls.Add(Me.Lb5)
        Me.XtraTabPage1.Controls.Add(Me.Lb4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(974, 408)
        Me.XtraTabPage1.Text = "Datos Fiscales / Delegaciones"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(11, 188)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(81, 16)
        Me.Lb7.TabIndex = 76
        Me.Lb7.Text = "Tipo porte"
        '
        'CbTipoPorte
        '
        Me.CbTipoPorte.Campobd = Nothing
        Me.CbTipoPorte.ClForm = Nothing
        Me.CbTipoPorte.DeshabilitarRuedaRaton = False
        Me.CbTipoPorte.FormattingEnabled = True
        Me.CbTipoPorte.GridLin = Nothing
        Me.CbTipoPorte.Location = New System.Drawing.Point(106, 187)
        Me.CbTipoPorte.MiEntidad = Nothing
        Me.CbTipoPorte.MiError = False
        Me.CbTipoPorte.Name = "CbTipoPorte"
        Me.CbTipoPorte.Orden = 0
        Me.CbTipoPorte.SaltoAlfinal = False
        Me.CbTipoPorte.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoPorte.TabIndex = 75
        '
        'Lb26
        '
        Me.Lb26.BackColor = System.Drawing.Color.White
        Me.Lb26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = False
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.Location = New System.Drawing.Point(356, 143)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(368, 23)
        Me.Lb26.TabIndex = 74
        '
        'Lb24
        '
        Me.Lb24.AutoSize = True
        Me.Lb24.CL_ControlAsociado = Nothing
        Me.Lb24.CL_ValorFijo = True
        Me.Lb24.ClForm = Nothing
        Me.Lb24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb24.ForeColor = System.Drawing.Color.Teal
        Me.Lb24.Location = New System.Drawing.Point(299, 153)
        Me.Lb24.Name = "Lb24"
        Me.Lb24.Size = New System.Drawing.Size(40, 16)
        Me.Lb24.TabIndex = 73
        Me.Lb24.Text = "Web"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Lb12)
        Me.Panel3.Controls.Add(Me.GridDelegaciones)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 242)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 166)
        Me.Panel3.TabIndex = 72
        '
        'Lb12
        '
        Me.Lb12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.Location = New System.Drawing.Point(0, 0)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(974, 19)
        Me.Lb12.TabIndex = 70
        Me.Lb12.Text = "Delegaciones"
        Me.Lb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridDelegaciones
        '
        Me.GridDelegaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridDelegaciones.Location = New System.Drawing.Point(0, 22)
        Me.GridDelegaciones.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridDelegaciones.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridDelegaciones.MainView = Me.GridViewDelegaciones
        Me.GridDelegaciones.Name = "GridDelegaciones"
        Me.GridDelegaciones.Size = New System.Drawing.Size(974, 144)
        Me.GridDelegaciones.TabIndex = 40
        Me.GridDelegaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDelegaciones, Me.GridView3})
        '
        'GridViewDelegaciones
        '
        Me.GridViewDelegaciones.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewDelegaciones.Appearance.FixedLine.BackColor2 = System.Drawing.Color.White
        Me.GridViewDelegaciones.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewDelegaciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewDelegaciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewDelegaciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewDelegaciones.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewDelegaciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewDelegaciones.GridControl = Me.GridDelegaciones
        Me.GridViewDelegaciones.Name = "GridViewDelegaciones"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridDelegaciones
        Me.GridView3.Name = "GridView3"
        '
        'Lbpais
        '
        Me.Lbpais.BackColor = System.Drawing.Color.White
        Me.Lbpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbpais.CL_ControlAsociado = Nothing
        Me.Lbpais.CL_ValorFijo = False
        Me.Lbpais.ClForm = Nothing
        Me.Lbpais.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbpais.Location = New System.Drawing.Point(106, 146)
        Me.Lbpais.Name = "Lbpais"
        Me.Lbpais.Size = New System.Drawing.Size(150, 23)
        Me.Lbpais.TabIndex = 69
        '
        'LbProvincia
        '
        Me.LbProvincia.BackColor = System.Drawing.Color.White
        Me.LbProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbProvincia.CL_ControlAsociado = Nothing
        Me.LbProvincia.CL_ValorFijo = False
        Me.LbProvincia.ClForm = Nothing
        Me.LbProvincia.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProvincia.Location = New System.Drawing.Point(106, 111)
        Me.LbProvincia.Name = "LbProvincia"
        Me.LbProvincia.Size = New System.Drawing.Size(450, 23)
        Me.LbProvincia.TabIndex = 68
        '
        'LbPoblacion
        '
        Me.LbPoblacion.BackColor = System.Drawing.Color.White
        Me.LbPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPoblacion.CL_ControlAsociado = Nothing
        Me.LbPoblacion.CL_ValorFijo = False
        Me.LbPoblacion.ClForm = Nothing
        Me.LbPoblacion.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPoblacion.Location = New System.Drawing.Point(302, 79)
        Me.LbPoblacion.Name = "LbPoblacion"
        Me.LbPoblacion.Size = New System.Drawing.Size(422, 23)
        Me.LbPoblacion.TabIndex = 67
        '
        'LbCpostal
        '
        Me.LbCpostal.BackColor = System.Drawing.Color.White
        Me.LbCpostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCpostal.CL_ControlAsociado = Nothing
        Me.LbCpostal.CL_ValorFijo = False
        Me.LbCpostal.ClForm = Nothing
        Me.LbCpostal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCpostal.Location = New System.Drawing.Point(106, 79)
        Me.LbCpostal.Name = "LbCpostal"
        Me.LbCpostal.Size = New System.Drawing.Size(92, 23)
        Me.LbCpostal.TabIndex = 66
        '
        'LbDomicilio
        '
        Me.LbDomicilio.BackColor = System.Drawing.Color.White
        Me.LbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDomicilio.CL_ControlAsociado = Nothing
        Me.LbDomicilio.CL_ValorFijo = False
        Me.LbDomicilio.ClForm = Nothing
        Me.LbDomicilio.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilio.Location = New System.Drawing.Point(106, 47)
        Me.LbDomicilio.Name = "LbDomicilio"
        Me.LbDomicilio.Size = New System.Drawing.Size(618, 23)
        Me.LbDomicilio.TabIndex = 65
        '
        'LbNombre
        '
        Me.LbNombre.BackColor = System.Drawing.Color.White
        Me.LbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = False
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.Location = New System.Drawing.Point(106, 15)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(450, 23)
        Me.LbNombre.TabIndex = 64
        '
        'Lb25
        '
        Me.Lb25.AutoSize = True
        Me.Lb25.CL_ControlAsociado = Nothing
        Me.Lb25.CL_ValorFijo = True
        Me.Lb25.ClForm = Nothing
        Me.Lb25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb25.ForeColor = System.Drawing.Color.Teal
        Me.Lb25.Location = New System.Drawing.Point(11, 22)
        Me.Lb25.Name = "Lb25"
        Me.Lb25.Size = New System.Drawing.Size(65, 16)
        Me.Lb25.TabIndex = 38
        Me.Lb25.Text = "Nombre"
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(11, 121)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(75, 16)
        Me.Lb14.TabIndex = 37
        Me.Lb14.Text = "Provincia"
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(218, 84)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(78, 16)
        Me.Lb13.TabIndex = 35
        Me.Lb13.Text = "Población"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(11, 88)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(68, 16)
        Me.Lb8.TabIndex = 33
        Me.Lb8.Text = "C.Postal"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(11, 154)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(38, 16)
        Me.Lb5.TabIndex = 31
        Me.Lb5.Text = "Pais"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(11, 55)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(74, 16)
        Me.Lb4.TabIndex = 13
        Me.Lb4.Text = "Domicilio"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XtraTabControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 64)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(980, 434)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'FrmTransportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 532)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTransportistas"
        Me.Text = "Transportistas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridDelegaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDelegaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaTransportista As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaNif As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GridContactos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewContactos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents Lb24 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents GridDelegaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDelegaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lbpais As NetAgro.Lb
    Friend WithEvents LbProvincia As NetAgro.Lb
    Friend WithEvents LbPoblacion As NetAgro.Lb
    Friend WithEvents LbCpostal As NetAgro.Lb
    Friend WithEvents LbDomicilio As NetAgro.Lb
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents Lb25 As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents CbTipoPorte As NetAgro.CbBox
End Class
