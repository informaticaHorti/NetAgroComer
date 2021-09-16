<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaExistencias
    Inherits NetAgro.FrConsulta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaExistencias))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbDesdeFechaEntrada = New NetAgro.Lb(Me.components)
        Me.TxDesdeFechaEntrada = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.rbNOMuestreadas = New System.Windows.Forms.RadioButton()
        Me.RbTODASMuestreadas = New System.Windows.Forms.RadioButton()
        Me.RbSIMuestreadas = New System.Windows.Forms.RadioButton()
        Me.CbNormas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbPrograma = New NetAgro.Lb(Me.components)
        Me.chkMostrarAgricultorYCultivo = New NetAgro.Chk(Me.components)
        Me.CbGeneros = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.CbPventa = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlPartidasYLotes = New System.Windows.Forms.Panel()
        Me.pnlPartidas = New System.Windows.Forms.Panel()
        Me.GridPartidas = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPartidas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlLotes = New System.Windows.Forms.Panel()
        Me.GridLotes = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLotes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GridPrecalibrado = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPrecalibrado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GridResumen = New DevExpress.XtraGrid.GridControl()
        Me.GridViewResumen = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prtSystem2 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink_1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink_2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.CompositeLink1 = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbNormas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbGeneros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.pnlPartidasYLotes.SuspendLayout()
        Me.pnlPartidas.SuspendLayout()
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLotes.SuspendLayout()
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GridPrecalibrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPrecalibrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GridResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink_1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink_2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Panel4)
        Me.PanelCabecera.Size = New System.Drawing.Size(1291, 73)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 73)
        Me.PanelConsulta.Size = New System.Drawing.Size(1291, 515)
        Me.PanelConsulta.Visible = False
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(991, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1066, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1141, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1216, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(916, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.CbNormas)
        Me.Panel4.Controls.Add(Me.LbPrograma)
        Me.Panel4.Controls.Add(Me.chkMostrarAgricultorYCultivo)
        Me.Panel4.Controls.Add(Me.CbGeneros)
        Me.Panel4.Controls.Add(Me.LbGenero)
        Me.Panel4.Controls.Add(Me.CbPventa)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1291, 70)
        Me.Panel4.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbDesdeFechaEntrada)
        Me.GroupBox1.Controls.Add(Me.TxDesdeFechaEntrada)
        Me.GroupBox1.Controls.Add(Me.Lb3)
        Me.GroupBox1.Controls.Add(Me.rbNOMuestreadas)
        Me.GroupBox1.Controls.Add(Me.RbTODASMuestreadas)
        Me.GroupBox1.Controls.Add(Me.RbSIMuestreadas)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(822, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 65)
        Me.GroupBox1.TabIndex = 100321
        Me.GroupBox1.TabStop = False
        '
        'LbDesdeFechaEntrada
        '
        Me.LbDesdeFechaEntrada.AutoSize = True
        Me.LbDesdeFechaEntrada.CL_ControlAsociado = Nothing
        Me.LbDesdeFechaEntrada.CL_ValorFijo = False
        Me.LbDesdeFechaEntrada.ClForm = Nothing
        Me.LbDesdeFechaEntrada.Enabled = False
        Me.LbDesdeFechaEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFechaEntrada.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFechaEntrada.Location = New System.Drawing.Point(77, 39)
        Me.LbDesdeFechaEntrada.Name = "LbDesdeFechaEntrada"
        Me.LbDesdeFechaEntrada.Size = New System.Drawing.Size(158, 16)
        Me.LbDesdeFechaEntrada.TabIndex = 100323
        Me.LbDesdeFechaEntrada.Text = "Desde fecha entrada"
        '
        'TxDesdeFechaEntrada
        '
        Me.TxDesdeFechaEntrada.Autonumerico = False
        Me.TxDesdeFechaEntrada.Buscando = False
        Me.TxDesdeFechaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeFechaEntrada.ClForm = Nothing
        Me.TxDesdeFechaEntrada.ClParam = Nothing
        Me.TxDesdeFechaEntrada.Enabled = False
        Me.TxDesdeFechaEntrada.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFechaEntrada.GridLin = Nothing
        Me.TxDesdeFechaEntrada.HaCambiado = False
        Me.TxDesdeFechaEntrada.lbbusca = Nothing
        Me.TxDesdeFechaEntrada.Location = New System.Drawing.Point(252, 36)
        Me.TxDesdeFechaEntrada.MiError = False
        Me.TxDesdeFechaEntrada.Name = "TxDesdeFechaEntrada"
        Me.TxDesdeFechaEntrada.Orden = 0
        Me.TxDesdeFechaEntrada.SaltoAlfinal = False
        Me.TxDesdeFechaEntrada.Siguiente = 0
        Me.TxDesdeFechaEntrada.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFechaEntrada.TabIndex = 100324
        Me.TxDesdeFechaEntrada.TeclaRepetida = False
        Me.TxDesdeFechaEntrada.TxDatoFinalSemana = Nothing
        Me.TxDesdeFechaEntrada.TxDatoInicioSemana = Nothing
        Me.TxDesdeFechaEntrada.UltimoValorValidado = Nothing
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(17, 14)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(168, 16)
        Me.Lb3.TabIndex = 100322
        Me.Lb3.Text = "Partidas muestreadas"
        '
        'rbNOMuestreadas
        '
        Me.rbNOMuestreadas.AutoSize = True
        Me.rbNOMuestreadas.Checked = True
        Me.rbNOMuestreadas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOMuestreadas.ForeColor = System.Drawing.Color.Teal
        Me.rbNOMuestreadas.Location = New System.Drawing.Point(241, 13)
        Me.rbNOMuestreadas.Name = "rbNOMuestreadas"
        Me.rbNOMuestreadas.Size = New System.Drawing.Size(43, 17)
        Me.rbNOMuestreadas.TabIndex = 3
        Me.rbNOMuestreadas.TabStop = True
        Me.rbNOMuestreadas.Text = "NO"
        Me.rbNOMuestreadas.UseVisualStyleBackColor = True
        '
        'RbTODASMuestreadas
        '
        Me.RbTODASMuestreadas.AutoSize = True
        Me.RbTODASMuestreadas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODASMuestreadas.ForeColor = System.Drawing.Color.Teal
        Me.RbTODASMuestreadas.Location = New System.Drawing.Point(290, 13)
        Me.RbTODASMuestreadas.Name = "RbTODASMuestreadas"
        Me.RbTODASMuestreadas.Size = New System.Drawing.Size(64, 17)
        Me.RbTODASMuestreadas.TabIndex = 2
        Me.RbTODASMuestreadas.Text = "Todas"
        Me.RbTODASMuestreadas.UseVisualStyleBackColor = True
        '
        'RbSIMuestreadas
        '
        Me.RbSIMuestreadas.AutoSize = True
        Me.RbSIMuestreadas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSIMuestreadas.ForeColor = System.Drawing.Color.Teal
        Me.RbSIMuestreadas.Location = New System.Drawing.Point(196, 13)
        Me.RbSIMuestreadas.Name = "RbSIMuestreadas"
        Me.RbSIMuestreadas.Size = New System.Drawing.Size(39, 17)
        Me.RbSIMuestreadas.TabIndex = 1
        Me.RbSIMuestreadas.Text = "SI"
        Me.RbSIMuestreadas.UseVisualStyleBackColor = True
        '
        'CbNormas
        '
        Me.CbNormas.EditValue = ""
        Me.CbNormas.Location = New System.Drawing.Point(523, 37)
        Me.CbNormas.Name = "CbNormas"
        Me.CbNormas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbNormas.Size = New System.Drawing.Size(293, 20)
        Me.CbNormas.TabIndex = 100320
        '
        'LbPrograma
        '
        Me.LbPrograma.AutoSize = True
        Me.LbPrograma.CL_ControlAsociado = Nothing
        Me.LbPrograma.CL_ValorFijo = True
        Me.LbPrograma.ClForm = Nothing
        Me.LbPrograma.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrograma.ForeColor = System.Drawing.Color.Teal
        Me.LbPrograma.Location = New System.Drawing.Point(375, 39)
        Me.LbPrograma.Name = "LbPrograma"
        Me.LbPrograma.Size = New System.Drawing.Size(142, 16)
        Me.LbPrograma.TabIndex = 100319
        Me.LbPrograma.Text = "Normas de calidad"
        '
        'chkMostrarAgricultorYCultivo
        '
        Me.chkMostrarAgricultorYCultivo.AutoSize = True
        Me.chkMostrarAgricultorYCultivo.Campobd = Nothing
        Me.chkMostrarAgricultorYCultivo.ClForm = Nothing
        Me.chkMostrarAgricultorYCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarAgricultorYCultivo.ForeColor = System.Drawing.Color.Teal
        Me.chkMostrarAgricultorYCultivo.GridLin = Nothing
        Me.chkMostrarAgricultorYCultivo.HaCambiado = False
        Me.chkMostrarAgricultorYCultivo.Location = New System.Drawing.Point(15, 37)
        Me.chkMostrarAgricultorYCultivo.MiEntidad = Nothing
        Me.chkMostrarAgricultorYCultivo.MiError = False
        Me.chkMostrarAgricultorYCultivo.Name = "chkMostrarAgricultorYCultivo"
        Me.chkMostrarAgricultorYCultivo.Orden = 0
        Me.chkMostrarAgricultorYCultivo.SaltoAlfinal = False
        Me.chkMostrarAgricultorYCultivo.Size = New System.Drawing.Size(223, 20)
        Me.chkMostrarAgricultorYCultivo.TabIndex = 100318
        Me.chkMostrarAgricultorYCultivo.Text = "Mostrar agricultor y cultivo"
        Me.chkMostrarAgricultorYCultivo.UseVisualStyleBackColor = True
        Me.chkMostrarAgricultorYCultivo.ValorCampoFalse = Nothing
        Me.chkMostrarAgricultorYCultivo.ValorCampoTrue = Nothing
        Me.chkMostrarAgricultorYCultivo.ValorDefecto = False
        '
        'CbGeneros
        '
        Me.CbGeneros.EditValue = ""
        Me.CbGeneros.Location = New System.Drawing.Point(441, 11)
        Me.CbGeneros.Name = "CbGeneros"
        Me.CbGeneros.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbGeneros.Size = New System.Drawing.Size(375, 20)
        Me.CbGeneros.TabIndex = 100317
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(375, 13)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(60, 16)
        Me.LbGenero.TabIndex = 100281
        Me.LbGenero.Text = "Género"
        '
        'CbPventa
        '
        Me.CbPventa.EditValue = ""
        Me.CbPventa.Location = New System.Drawing.Point(97, 11)
        Me.CbPventa.Name = "CbPventa"
        Me.CbPventa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPventa.Size = New System.Drawing.Size(240, 20)
        Me.CbPventa.TabIndex = 100279
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(65, 16)
        Me.Lb1.TabIndex = 33
        Me.Lb1.Text = "P.Venta"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(0, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(647, 30)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "LOTES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 73)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1291, 515)
        Me.XtraTabControl1.TabIndex = 11
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage1.Controls.Add(Me.pnlPartidasYLotes)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1285, 484)
        Me.XtraTabPage1.Text = "PARTIDAS Y LOTES"
        '
        'pnlPartidasYLotes
        '
        Me.pnlPartidasYLotes.Controls.Add(Me.pnlPartidas)
        Me.pnlPartidasYLotes.Controls.Add(Me.pnlLotes)
        Me.pnlPartidasYLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPartidasYLotes.Location = New System.Drawing.Point(0, 0)
        Me.pnlPartidasYLotes.Name = "pnlPartidasYLotes"
        Me.pnlPartidasYLotes.Size = New System.Drawing.Size(1285, 484)
        Me.pnlPartidasYLotes.TabIndex = 0
        '
        'pnlPartidas
        '
        Me.pnlPartidas.Controls.Add(Me.GridPartidas)
        Me.pnlPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPartidas.Location = New System.Drawing.Point(0, 0)
        Me.pnlPartidas.Name = "pnlPartidas"
        Me.pnlPartidas.Size = New System.Drawing.Size(1285, 252)
        Me.pnlPartidas.TabIndex = 1
        '
        'GridPartidas
        '
        Me.GridPartidas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPartidas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPartidas.Location = New System.Drawing.Point(0, 0)
        Me.GridPartidas.LookAndFeel.SkinName = "Black"
        Me.GridPartidas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPartidas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPartidas.MainView = Me.GridViewPartidas
        Me.GridPartidas.Name = "GridPartidas"
        Me.GridPartidas.Size = New System.Drawing.Size(1285, 252)
        Me.GridPartidas.TabIndex = 15
        Me.GridPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPartidas})
        '
        'GridViewPartidas
        '
        Me.GridViewPartidas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPartidas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewPartidas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewPartidas.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewPartidas.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewPartidas.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPartidas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewPartidas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewPartidas.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewPartidas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewPartidas.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewPartidas.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPartidas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewPartidas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewPartidas.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewPartidas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewPartidas.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPartidas.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewPartidas.Appearance.Row.Options.UseFont = True
        Me.GridViewPartidas.Appearance.Row.Options.UseForeColor = True
        Me.GridViewPartidas.GridControl = Me.GridPartidas
        Me.GridViewPartidas.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPartidas.Name = "GridViewPartidas"
        Me.GridViewPartidas.OptionsView.AutoCalcPreviewLineCount = True
        '
        'pnlLotes
        '
        Me.pnlLotes.Controls.Add(Me.GridLotes)
        Me.pnlLotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLotes.Location = New System.Drawing.Point(0, 252)
        Me.pnlLotes.Name = "pnlLotes"
        Me.pnlLotes.Size = New System.Drawing.Size(1285, 232)
        Me.pnlLotes.TabIndex = 0
        '
        'GridLotes
        '
        Me.GridLotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLotes.Location = New System.Drawing.Point(0, 0)
        Me.GridLotes.LookAndFeel.SkinName = "Black"
        Me.GridLotes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridLotes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridLotes.MainView = Me.GridViewLotes
        Me.GridLotes.Name = "GridLotes"
        Me.GridLotes.Size = New System.Drawing.Size(1285, 232)
        Me.GridLotes.TabIndex = 14
        Me.GridLotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLotes})
        '
        'GridViewLotes
        '
        Me.GridViewLotes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewLotes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewLotes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewLotes.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewLotes.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewLotes.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLotes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewLotes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewLotes.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewLotes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewLotes.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewLotes.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLotes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewLotes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewLotes.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewLotes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewLotes.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLotes.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewLotes.Appearance.Row.Options.UseFont = True
        Me.GridViewLotes.Appearance.Row.Options.UseForeColor = True
        Me.GridViewLotes.GridControl = Me.GridLotes
        Me.GridViewLotes.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewLotes.Name = "GridViewLotes"
        Me.GridViewLotes.OptionsView.AutoCalcPreviewLineCount = True
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage2.Controls.Add(Me.Panel6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1285, 484)
        Me.XtraTabPage2.Text = "PRECALIBRADO"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GridPrecalibrado)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1285, 484)
        Me.Panel6.TabIndex = 0
        '
        'GridPrecalibrado
        '
        Me.GridPrecalibrado.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPrecalibrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrecalibrado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPrecalibrado.Location = New System.Drawing.Point(0, 0)
        Me.GridPrecalibrado.LookAndFeel.SkinName = "Black"
        Me.GridPrecalibrado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPrecalibrado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPrecalibrado.MainView = Me.GridViewPrecalibrado
        Me.GridPrecalibrado.Name = "GridPrecalibrado"
        Me.GridPrecalibrado.Size = New System.Drawing.Size(1285, 484)
        Me.GridPrecalibrado.TabIndex = 20
        Me.GridPrecalibrado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPrecalibrado})
        '
        'GridViewPrecalibrado
        '
        Me.GridViewPrecalibrado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPrecalibrado.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewPrecalibrado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewPrecalibrado.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewPrecalibrado.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewPrecalibrado.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPrecalibrado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewPrecalibrado.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewPrecalibrado.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewPrecalibrado.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewPrecalibrado.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewPrecalibrado.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPrecalibrado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewPrecalibrado.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewPrecalibrado.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewPrecalibrado.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewPrecalibrado.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPrecalibrado.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewPrecalibrado.Appearance.Row.Options.UseFont = True
        Me.GridViewPrecalibrado.Appearance.Row.Options.UseForeColor = True
        Me.GridViewPrecalibrado.GridControl = Me.GridPrecalibrado
        Me.GridViewPrecalibrado.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewPrecalibrado.Name = "GridViewPrecalibrado"
        Me.GridViewPrecalibrado.OptionsView.AutoCalcPreviewLineCount = True
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage3.Controls.Add(Me.Panel5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1285, 484)
        Me.XtraTabPage3.Text = "RESUMEN"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridResumen)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1285, 484)
        Me.Panel5.TabIndex = 0
        '
        'GridResumen
        '
        Me.GridResumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResumen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridResumen.Location = New System.Drawing.Point(0, 0)
        Me.GridResumen.LookAndFeel.SkinName = "Black"
        Me.GridResumen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridResumen.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridResumen.MainView = Me.GridViewResumen
        Me.GridResumen.Name = "GridResumen"
        Me.GridResumen.Size = New System.Drawing.Size(1285, 484)
        Me.GridResumen.TabIndex = 16
        Me.GridResumen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewResumen})
        '
        'GridViewResumen
        '
        Me.GridViewResumen.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewResumen.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewResumen.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewResumen.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewResumen.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewResumen.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewResumen.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewResumen.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewResumen.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResumen.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewResumen.Appearance.Row.Options.UseFont = True
        Me.GridViewResumen.Appearance.Row.Options.UseForeColor = True
        Me.GridViewResumen.GridControl = Me.GridResumen
        Me.GridViewResumen.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewResumen.Name = "GridViewResumen"
        Me.GridViewResumen.OptionsView.AutoCalcPreviewLineCount = True
        '
        'prtSystem2
        '
        Me.prtSystem2.Links.AddRange(New Object() {Me.PrintableComponentLink_1, Me.PrintableComponentLink_2, Me.CompositeLink1})
        '
        'PrintableComponentLink_1
        '
        Me.PrintableComponentLink_1.Component = Me.GridPartidas
        '
        '
        '
        Me.PrintableComponentLink_1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink_1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink_1.Landscape = True
        Me.PrintableComponentLink_1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink_1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink_1.PrintingSystem = Me.prtSystem2
        Me.PrintableComponentLink_1.PrintingSystemBase = Me.prtSystem2
        '
        'PrintableComponentLink_2
        '
        Me.PrintableComponentLink_2.Component = Me.GridLotes
        '
        '
        '
        Me.PrintableComponentLink_2.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink_2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink_2.Landscape = True
        Me.PrintableComponentLink_2.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink_2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink_2.PrintingSystem = Me.prtSystem2
        Me.PrintableComponentLink_2.PrintingSystemBase = Me.prtSystem2
        '
        'CompositeLink1
        '
        '
        '
        '
        Me.CompositeLink1.ImageCollection.ImageStream = CType(resources.GetObject("CompositeLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.CompositeLink1.Landscape = True
        Me.CompositeLink1.Links.AddRange(New Object() {Me.PrintableComponentLink_1, Me.PrintableComponentLink_2})
        Me.CompositeLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.CompositeLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "[Page # of Pages #]", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.CompositeLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.CompositeLink1.PrintingSystem = Me.prtSystem2
        Me.CompositeLink1.PrintingSystemBase = Me.prtSystem2
        '
        'FrmConsultaExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 622)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaExistencias"
        Me.Text = "Consulta existencias"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbNormas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbGeneros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.pnlPartidasYLotes.ResumeLayout(False)
        Me.pnlPartidas.ResumeLayout(False)
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLotes.ResumeLayout(False)
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.GridPrecalibrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPrecalibrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink_1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink_2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CbPventa As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbGeneros As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlPartidasYLotes As System.Windows.Forms.Panel
    Friend WithEvents pnlPartidas As System.Windows.Forms.Panel
    Public WithEvents GridPartidas As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewPartidas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlLotes As System.Windows.Forms.Panel
    Public WithEvents GridLotes As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewLotes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Public WithEvents GridPrecalibrado As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewPrecalibrado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents GridResumen As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewResumen As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents prtSystem2 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink_1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink_2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents CompositeLink1 As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents chkMostrarAgricultorYCultivo As NetAgro.Chk
    Friend WithEvents LbPrograma As NetAgro.Lb
    Friend WithEvents CbNormas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNOMuestreadas As System.Windows.Forms.RadioButton
    Friend WithEvents RbTODASMuestreadas As System.Windows.Forms.RadioButton
    Friend WithEvents RbSIMuestreadas As System.Windows.Forms.RadioButton
    Friend WithEvents LbDesdeFechaEntrada As NetAgro.Lb
    Friend WithEvents TxDesdeFechaEntrada As NetAgro.TxDato
End Class
