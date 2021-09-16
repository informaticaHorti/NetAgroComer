<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFamilias))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btGenerar = New System.Windows.Forms.Button()
        Me.BtBuscaFamilia = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LbDtoFirmeSinClasificar = New NetAgro.Lb(Me.components)
        Me.TxDtoFirmeSinClasificar = New NetAgro.TxDato(Me.components)
        Me.LbDtoFirme = New NetAgro.Lb(Me.components)
        Me.TxDtoFirme = New NetAgro.TxDato(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCentro = New NetAgro.BtBusca(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.TxDato14 = New NetAgro.TxDato(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridCateSal = New DevExpress.XtraGrid.GridControl()
        Me.GridCateSalView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.GridCateEnt = New DevExpress.XtraGrid.GridControl()
        Me.GridCatEntView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridCateSal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCateSalView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridCateEnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCatEntView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btGenerar)
        Me.Panel2.Controls.Add(Me.BtBuscaFamilia)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.BotonesAvance1)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 64)
        Me.Panel2.TabIndex = 10
        '
        'btGenerar
        '
        Me.btGenerar.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.btGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGenerar.Location = New System.Drawing.Point(640, 33)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(165, 23)
        Me.btGenerar.TabIndex = 102
        Me.btGenerar.Text = "Generar gastos por centro"
        Me.btGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGenerar.UseVisualStyleBackColor = True
        Me.btGenerar.Visible = False
        '
        'BtBuscaFamilia
        '
        Me.BtBuscaFamilia.CL_Ancho = 0
        Me.BtBuscaFamilia.CL_BuscaAlb = False
        Me.BtBuscaFamilia.CL_campocodigo = Nothing
        Me.BtBuscaFamilia.CL_camponombre = Nothing
        Me.BtBuscaFamilia.CL_CampoOrden = "Nombre"
        Me.BtBuscaFamilia.CL_ch1000 = False
        Me.BtBuscaFamilia.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFamilia.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaFamilia.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFamilia.CL_dfecha = Nothing
        Me.BtBuscaFamilia.CL_Entidad = Nothing
        Me.BtBuscaFamilia.CL_EsId = True
        Me.BtBuscaFamilia.CL_Filtro = Nothing
        Me.BtBuscaFamilia.cl_formu = Nothing
        Me.BtBuscaFamilia.CL_hfecha = Nothing
        Me.BtBuscaFamilia.cl_ListaW = Nothing
        Me.BtBuscaFamilia.CL_xCentro = False
        Me.BtBuscaFamilia.Image = CType(resources.GetObject("BtBuscaFamilia.Image"), System.Drawing.Image)
        Me.BtBuscaFamilia.Location = New System.Drawing.Point(152, 5)
        Me.BtBuscaFamilia.Name = "BtBuscaFamilia"
        Me.BtBuscaFamilia.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFamilia.TabIndex = 28
        Me.BtBuscaFamilia.UseVisualStyleBackColor = True
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
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxDato2.Size = New System.Drawing.Size(336, 22)
        Me.TxDato2.TabIndex = 24
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.XtraTabControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 64)
        Me.XtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(831, 407)
        Me.XtraTabControl1.TabIndex = 11
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.LbDtoFirmeSinClasificar)
        Me.XtraTabPage3.Controls.Add(Me.TxDtoFirmeSinClasificar)
        Me.XtraTabPage3.Controls.Add(Me.LbDtoFirme)
        Me.XtraTabPage3.Controls.Add(Me.TxDtoFirme)
        Me.XtraTabPage3.Controls.Add(Me.ClGrid2)
        Me.XtraTabPage3.Controls.Add(Me.Lb15)
        Me.XtraTabPage3.Controls.Add(Me.BtBuscaCentro)
        Me.XtraTabPage3.Controls.Add(Me.Lb14)
        Me.XtraTabPage3.Controls.Add(Me.TxDato14)
        Me.XtraTabPage3.Controls.Add(Me.Lb10)
        Me.XtraTabPage3.Controls.Add(Me.TxDato10)
        Me.XtraTabPage3.Controls.Add(Me.Lb11)
        Me.XtraTabPage3.Controls.Add(Me.TxDato11)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(827, 381)
        Me.XtraTabPage3.Text = "Gastos x centro"
        '
        'LbDtoFirmeSinClasificar
        '
        Me.LbDtoFirmeSinClasificar.AutoSize = True
        Me.LbDtoFirmeSinClasificar.CL_ControlAsociado = Nothing
        Me.LbDtoFirmeSinClasificar.CL_ValorFijo = False
        Me.LbDtoFirmeSinClasificar.ClForm = Nothing
        Me.LbDtoFirmeSinClasificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDtoFirmeSinClasificar.ForeColor = System.Drawing.Color.Teal
        Me.LbDtoFirmeSinClasificar.Location = New System.Drawing.Point(33, 140)
        Me.LbDtoFirmeSinClasificar.Name = "LbDtoFirmeSinClasificar"
        Me.LbDtoFirmeSinClasificar.Size = New System.Drawing.Size(189, 16)
        Me.LbDtoFirmeSinClasificar.TabIndex = 100
        Me.LbDtoFirmeSinClasificar.Text = "% Dto Firme (Sin Clasif.)"
        '
        'TxDtoFirmeSinClasificar
        '
        Me.TxDtoFirmeSinClasificar.Autonumerico = False
        Me.TxDtoFirmeSinClasificar.Buscando = False
        Me.TxDtoFirmeSinClasificar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDtoFirmeSinClasificar.ClForm = Nothing
        Me.TxDtoFirmeSinClasificar.ClParam = Nothing
        Me.TxDtoFirmeSinClasificar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDtoFirmeSinClasificar.GridLin = Nothing
        Me.TxDtoFirmeSinClasificar.HaCambiado = False
        Me.TxDtoFirmeSinClasificar.lbbusca = Nothing
        Me.TxDtoFirmeSinClasificar.Location = New System.Drawing.Point(239, 137)
        Me.TxDtoFirmeSinClasificar.MiError = False
        Me.TxDtoFirmeSinClasificar.Name = "TxDtoFirmeSinClasificar"
        Me.TxDtoFirmeSinClasificar.Orden = 0
        Me.TxDtoFirmeSinClasificar.SaltoAlfinal = False
        Me.TxDtoFirmeSinClasificar.Siguiente = 0
        Me.TxDtoFirmeSinClasificar.Size = New System.Drawing.Size(78, 22)
        Me.TxDtoFirmeSinClasificar.TabIndex = 99
        Me.TxDtoFirmeSinClasificar.TeclaRepetida = False
        Me.TxDtoFirmeSinClasificar.TxDatoFinalSemana = Nothing
        Me.TxDtoFirmeSinClasificar.TxDatoInicioSemana = Nothing
        Me.TxDtoFirmeSinClasificar.UltimoValorValidado = Nothing
        '
        'LbDtoFirme
        '
        Me.LbDtoFirme.AutoSize = True
        Me.LbDtoFirme.CL_ControlAsociado = Nothing
        Me.LbDtoFirme.CL_ValorFijo = False
        Me.LbDtoFirme.ClForm = Nothing
        Me.LbDtoFirme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDtoFirme.ForeColor = System.Drawing.Color.Teal
        Me.LbDtoFirme.Location = New System.Drawing.Point(33, 112)
        Me.LbDtoFirme.Name = "LbDtoFirme"
        Me.LbDtoFirme.Size = New System.Drawing.Size(100, 16)
        Me.LbDtoFirme.TabIndex = 98
        Me.LbDtoFirme.Text = "% Dto Firme"
        '
        'TxDtoFirme
        '
        Me.TxDtoFirme.Autonumerico = False
        Me.TxDtoFirme.Buscando = False
        Me.TxDtoFirme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDtoFirme.ClForm = Nothing
        Me.TxDtoFirme.ClParam = Nothing
        Me.TxDtoFirme.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDtoFirme.GridLin = Nothing
        Me.TxDtoFirme.HaCambiado = False
        Me.TxDtoFirme.lbbusca = Nothing
        Me.TxDtoFirme.Location = New System.Drawing.Point(239, 109)
        Me.TxDtoFirme.MiError = False
        Me.TxDtoFirme.Name = "TxDtoFirme"
        Me.TxDtoFirme.Orden = 0
        Me.TxDtoFirme.SaltoAlfinal = False
        Me.TxDtoFirme.Siguiente = 0
        Me.TxDtoFirme.Size = New System.Drawing.Size(78, 22)
        Me.TxDtoFirme.TabIndex = 97
        Me.TxDtoFirme.TeclaRepetida = False
        Me.TxDtoFirme.TxDatoFinalSemana = Nothing
        Me.TxDtoFirme.TxDatoInicioSemana = Nothing
        Me.TxDtoFirme.UltimoValorValidado = Nothing
        '
        'ClGrid2
        '
        Me.ClGrid2.AñadirLinea = True
        Me.ClGrid2.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.GridEnterAutomatico = False
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.LineaBloqueada = False
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(0, 201)
        Me.ClGrid2.MismaLinea = False
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.OcultarCeros = False
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(827, 180)
        Me.ClGrid2.TabIndex = 96
        Me.ClGrid2.UltimoControl = 0
        '
        'Lb15
        '
        Me.Lb15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = False
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.Location = New System.Drawing.Point(278, 25)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(236, 23)
        Me.Lb15.TabIndex = 95
        '
        'BtBuscaCentro
        '
        Me.BtBuscaCentro.CL_Ancho = 0
        Me.BtBuscaCentro.CL_BuscaAlb = False
        Me.BtBuscaCentro.CL_campocodigo = Nothing
        Me.BtBuscaCentro.CL_camponombre = Nothing
        Me.BtBuscaCentro.CL_CampoOrden = "Nombre"
        Me.BtBuscaCentro.CL_ch1000 = False
        Me.BtBuscaCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCentro.CL_ControlAsociado = Me.TxDato4
        Me.BtBuscaCentro.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCentro.CL_dfecha = Nothing
        Me.BtBuscaCentro.CL_Entidad = Nothing
        Me.BtBuscaCentro.CL_EsId = True
        Me.BtBuscaCentro.CL_Filtro = Nothing
        Me.BtBuscaCentro.cl_formu = Nothing
        Me.BtBuscaCentro.CL_hfecha = Nothing
        Me.BtBuscaCentro.cl_ListaW = Nothing
        Me.BtBuscaCentro.CL_xCentro = False
        Me.BtBuscaCentro.Image = CType(resources.GetObject("BtBuscaCentro.Image"), System.Drawing.Image)
        Me.BtBuscaCentro.Location = New System.Drawing.Point(239, 25)
        Me.BtBuscaCentro.Name = "BtBuscaCentro"
        Me.BtBuscaCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCentro.TabIndex = 94
        Me.BtBuscaCentro.UseVisualStyleBackColor = True
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(164, 68)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(66, 22)
        Me.TxDato4.TabIndex = 28
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = False
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(33, 84)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(187, 16)
        Me.Lb14.TabIndex = 93
        Me.Lb14.Text = "Gasto Estrúctura (x Kilo)"
        '
        'TxDato14
        '
        Me.TxDato14.Autonumerico = False
        Me.TxDato14.Buscando = False
        Me.TxDato14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato14.ClForm = Nothing
        Me.TxDato14.ClParam = Nothing
        Me.TxDato14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato14.GridLin = Nothing
        Me.TxDato14.HaCambiado = False
        Me.TxDato14.lbbusca = Nothing
        Me.TxDato14.Location = New System.Drawing.Point(239, 81)
        Me.TxDato14.MiError = False
        Me.TxDato14.Name = "TxDato14"
        Me.TxDato14.Orden = 0
        Me.TxDato14.SaltoAlfinal = False
        Me.TxDato14.Siguiente = 0
        Me.TxDato14.Size = New System.Drawing.Size(78, 22)
        Me.TxDato14.TabIndex = 92
        Me.TxDato14.TeclaRepetida = False
        Me.TxDato14.TxDatoFinalSemana = Nothing
        Me.TxDato14.TxDatoInicioSemana = Nothing
        Me.TxDato14.UltimoValorValidado = Nothing
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(33, 56)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(200, 16)
        Me.Lb10.TabIndex = 86
        Me.Lb10.Text = "% Dto Báscula (Comisión)"
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(239, 53)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(78, 22)
        Me.TxDato10.TabIndex = 85
        Me.TxDato10.TeclaRepetida = False
        Me.TxDato10.TxDatoFinalSemana = Nothing
        Me.TxDato10.TxDatoInicioSemana = Nothing
        Me.TxDato10.UltimoValorValidado = Nothing
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(33, 28)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(124, 16)
        Me.Lb11.TabIndex = 84
        Me.Lb11.Text = "Centro recogida"
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(201, 25)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(32, 22)
        Me.TxDato11.TabIndex = 83
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.TxDatoFinalSemana = Nothing
        Me.TxDato11.TxDatoInicioSemana = Nothing
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Lb7)
        Me.XtraTabPage1.Controls.Add(Me.TxDato7)
        Me.XtraTabPage1.Controls.Add(Me.Lb6)
        Me.XtraTabPage1.Controls.Add(Me.TxDato6)
        Me.XtraTabPage1.Controls.Add(Me.Lb5)
        Me.XtraTabPage1.Controls.Add(Me.TxDato5)
        Me.XtraTabPage1.Controls.Add(Me.Lb4)
        Me.XtraTabPage1.Controls.Add(Me.TxDato4)
        Me.XtraTabPage1.Controls.Add(Me.Lb3)
        Me.XtraTabPage1.Controls.Add(Me.TxDato3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(827, 381)
        Me.XtraTabPage1.Text = "Datos intrastat"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(28, 154)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(130, 16)
        Me.Lb7.TabIndex = 35
        Me.Lb7.Text = "Valor estadístico"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(164, 152)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(66, 22)
        Me.TxDato7.TabIndex = 34
        Me.TxDato7.TeclaRepetida = False
        Me.TxDato7.TxDatoFinalSemana = Nothing
        Me.TxDato7.TxDatoInicioSemana = Nothing
        Me.TxDato7.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(28, 126)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(71, 16)
        Me.Lb6.TabIndex = 33
        Me.Lb6.Text = "Código 2"
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(164, 124)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(153, 22)
        Me.TxDato6.TabIndex = 32
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(28, 98)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(99, 16)
        Me.Lb5.TabIndex = 31
        Me.Lb5.Text = "Hasta DDMM"
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(164, 96)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(66, 22)
        Me.TxDato5.TabIndex = 30
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(28, 70)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(101, 16)
        Me.Lb4.TabIndex = 29
        Me.Lb4.Text = "Desde DDMM"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(28, 42)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(71, 16)
        Me.Lb3.TabIndex = 27
        Me.Lb3.Text = "Código 1"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(164, 40)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(153, 22)
        Me.TxDato3.TabIndex = 26
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ClGrid1)
        Me.XtraTabPage2.Controls.Add(Me.Lb9)
        Me.XtraTabPage2.Controls.Add(Me.TxDato9)
        Me.XtraTabPage2.Controls.Add(Me.Lb8)
        Me.XtraTabPage2.Controls.Add(Me.TxDato8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(827, 381)
        Me.XtraTabPage2.Text = "SubFamilias"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
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
        Me.ClGrid1.Location = New System.Drawing.Point(34, 85)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(758, 284)
        Me.ClGrid1.TabIndex = 73
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(31, 55)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(65, 16)
        Me.Lb9.TabIndex = 31
        Me.Lb9.Text = "Nombre"
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(106, 52)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(219, 22)
        Me.TxDato9.TabIndex = 30
        Me.TxDato9.TeclaRepetida = False
        Me.TxDato9.TxDatoFinalSemana = Nothing
        Me.TxDato9.TxDatoInicioSemana = Nothing
        Me.TxDato9.UltimoValorValidado = Nothing
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(31, 25)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(58, 16)
        Me.Lb8.TabIndex = 29
        Me.Lb8.Text = "Código"
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(106, 22)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(32, 22)
        Me.TxDato8.TabIndex = 28
        Me.TxDato8.TeclaRepetida = False
        Me.TxDato8.TxDatoFinalSemana = Nothing
        Me.TxDato8.TxDatoInicioSemana = Nothing
        Me.TxDato8.UltimoValorValidado = Nothing
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Panel4)
        Me.XtraTabPage4.Controls.Add(Me.Panel3)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(827, 381)
        Me.XtraTabPage4.Text = "Categorias"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GridCateSal)
        Me.Panel4.Controls.Add(Me.Lb17)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(224, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 381)
        Me.Panel4.TabIndex = 77
        '
        'GridCateSal
        '
        Me.GridCateSal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCateSal.Location = New System.Drawing.Point(15, 34)
        Me.GridCateSal.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridCateSal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridCateSal.MainView = Me.GridCateSalView
        Me.GridCateSal.Name = "GridCateSal"
        Me.GridCateSal.Size = New System.Drawing.Size(305, 298)
        Me.GridCateSal.TabIndex = 77
        Me.GridCateSal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridCateSalView})
        '
        'GridCateSalView
        '
        Me.GridCateSalView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridCateSalView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridCateSalView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridCateSalView.GridControl = Me.GridCateSal
        Me.GridCateSalView.Name = "GridCateSalView"
        Me.GridCateSalView.OptionsView.ShowGroupPanel = False
        '
        'Lb17
        '
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = True
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb17.Location = New System.Drawing.Point(58, 15)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(225, 16)
        Me.Lb17.TabIndex = 76
        Me.Lb17.Text = "Categorias Salida/Comerciales"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Lb16)
        Me.Panel3.Controls.Add(Me.GridCateEnt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(224, 381)
        Me.Panel3.TabIndex = 76
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb16.Location = New System.Drawing.Point(24, 15)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(141, 16)
        Me.Lb16.TabIndex = 76
        Me.Lb16.Text = "Categorias entrada"
        '
        'GridCateEnt
        '
        Me.GridCateEnt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCateEnt.Location = New System.Drawing.Point(17, 34)
        Me.GridCateEnt.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridCateEnt.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridCateEnt.MainView = Me.GridCatEntView
        Me.GridCateEnt.Name = "GridCateEnt"
        Me.GridCateEnt.Size = New System.Drawing.Size(199, 298)
        Me.GridCateEnt.TabIndex = 75
        Me.GridCateEnt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridCatEntView})
        '
        'GridCatEntView
        '
        Me.GridCatEntView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridCatEntView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridCatEntView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridCatEntView.GridControl = Me.GridCateEnt
        Me.GridCatEntView.Name = "GridCatEntView"
        Me.GridCatEntView.OptionsView.ShowGroupPanel = False
        '
        'FrmFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 505)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmFamilias"
        Me.Text = "Familias"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GridCateSal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCateSalView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridCateEnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCatEntView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaFamilia As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents TxDato14 As NetAgro.TxDato
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents BtBuscaCentro As NetAgro.BtBusca
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GridCateSal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridCateSalView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb17 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents GridCateEnt As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridCatEntView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbDtoFirmeSinClasificar As NetAgro.Lb
    Friend WithEvents TxDtoFirmeSinClasificar As NetAgro.TxDato
    Friend WithEvents LbDtoFirme As NetAgro.Lb
    Friend WithEvents TxDtoFirme As NetAgro.TxDato
    Friend WithEvents btGenerar As System.Windows.Forms.Button
End Class
