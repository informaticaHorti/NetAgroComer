<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaPedidosAlmacen
    Inherits NetAgro.FrConsulta

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPedidosAlmacen))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbLineas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkRefrescar = New NetAgro.Chk(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbReferencia = New System.Windows.Forms.TextBox()
        Me.LbLote = New System.Windows.Forms.TextBox()
        Me.LbObs2 = New System.Windows.Forms.TextBox()
        Me.LbObs1 = New System.Windows.Forms.TextBox()
        Me.LbBultosxPalet = New System.Windows.Forms.TextBox()
        Me.LbTipoPalet = New System.Windows.Forms.TextBox()
        Me.LbEstadoEtiqueta = New System.Windows.Forms.TextBox()
        Me.LbCalidad = New System.Windows.Forms.TextBox()
        Me.LbMarcaMaterial = New System.Windows.Forms.TextBox()
        Me.LbMarcaEtiqueta = New System.Windows.Forms.TextBox()
        Me.LbEtiquetaCesta = New System.Windows.Forms.TextBox()
        Me.LbPiezasxBulto = New System.Windows.Forms.TextBox()
        Me.LbMarca = New System.Windows.Forms.TextBox()
        Me.LbEnvase = New System.Windows.Forms.TextBox()
        Me.LbFecha = New System.Windows.Forms.TextBox()
        Me.LbGenero = New System.Windows.Forms.TextBox()
        Me.LbPresentacion = New System.Windows.Forms.TextBox()
        Me.LbCliente = New System.Windows.Forms.TextBox()
        Me.LbPedido = New System.Windows.Forms.TextBox()
        Me.LbCategoria = New System.Windows.Forms.TextBox()
        Me.LbEtiquetaCaja = New System.Windows.Forms.TextBox()
        Me.Lb32 = New NetAgro.Lb(Me.components)
        Me.Lb30 = New NetAgro.Lb(Me.components)
        Me.Lb28 = New NetAgro.Lb(Me.components)
        Me.Lb25 = New NetAgro.Lb(Me.components)
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.Lb24 = New NetAgro.Lb(Me.components)
        Me.Lb22 = New NetAgro.Lb(Me.components)
        Me.Lb20 = New NetAgro.Lb(Me.components)
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.Lb21 = New NetAgro.Lb(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GridDesglosePedidos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDesglosePedidos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbNomCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxCliente = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.LbNomGenero = New NetAgro.Lb(Me.components)
        Me.BtBuscaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxGenero = New NetAgro.TxDato(Me.components)
        Me.Lb27 = New NetAgro.Lb(Me.components)
        Me.ChkOcultarCargados = New NetAgro.Chk(Me.components)
        Me.TxDiasHasta = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ChkCompras = New NetAgro.Chk(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbSalidos = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btCartelones = New System.Windows.Forms.Button()
        Me.btNuevoPaletStock = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btNuevoPalet = New System.Windows.Forms.Button()
        Me.BtVerPedido = New System.Windows.Forms.Button()
        Me.BtMuestra = New System.Windows.Forms.Button()
        Me.BtVerEtiqueta = New System.Windows.Forms.Button()
        Me.LbExceso = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbPtes = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbStock = New NetAgro.Lb(Me.components)
        Me.Lb18 = New NetAgro.Lb(Me.components)
        Me.LbReserv = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbPalets = New NetAgro.Lb(Me.components)
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GridDesglosePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDesglosePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.ChkCompras)
        Me.PanelCabecera.Controls.Add(Me.chkRefrescar)
        Me.PanelCabecera.Controls.Add(Me.NumericUpDown1)
        Me.PanelCabecera.Controls.Add(Me.Lb29)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.TxDiasHasta)
        Me.PanelCabecera.Controls.Add(Me.ChkOcultarCargados)
        Me.PanelCabecera.Controls.Add(Me.LbNomGenero)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGenero)
        Me.PanelCabecera.Controls.Add(Me.TxGenero)
        Me.PanelCabecera.Controls.Add(Me.Lb27)
        Me.PanelCabecera.Controls.Add(Me.LbNomCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCliente)
        Me.PanelCabecera.Controls.Add(Me.TxCliente)
        Me.PanelCabecera.Controls.Add(Me.Lb_4)
        Me.PanelCabecera.Controls.Add(Me.CbLineas)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.PictureBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1370, 97)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 97)
        Me.PanelConsulta.Size = New System.Drawing.Size(1370, 322)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1070, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1145, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1220, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1295, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(995, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Bloqueado = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(109, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 81
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(7, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(100, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Fecha Salida"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(727, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100274
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(321, 14)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100314
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(251, 16)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(64, 16)
        Me.Lb5.TabIndex = 100313
        Me.Lb5.Text = "P.venta"
        '
        'CbLineas
        '
        Me.CbLineas.EditValue = ""
        Me.CbLineas.Location = New System.Drawing.Point(660, 14)
        Me.CbLineas.Name = "CbLineas"
        Me.CbLineas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbLineas.Size = New System.Drawing.Size(240, 20)
        Me.CbLineas.TabIndex = 100316
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(603, 16)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(47, 16)
        Me.Lb3.TabIndex = 100315
        Me.Lb3.Text = "Linea"
        '
        'Timer1
        '
        Me.Timer1.Interval = 600000
        '
        'chkRefrescar
        '
        Me.chkRefrescar.AutoSize = True
        Me.chkRefrescar.Campobd = Nothing
        Me.chkRefrescar.Checked = True
        Me.chkRefrescar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRefrescar.ClForm = Nothing
        Me.chkRefrescar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRefrescar.ForeColor = System.Drawing.Color.Teal
        Me.chkRefrescar.GridLin = Nothing
        Me.chkRefrescar.HaCambiado = False
        Me.chkRefrescar.Location = New System.Drawing.Point(887, 42)
        Me.chkRefrescar.MiEntidad = Nothing
        Me.chkRefrescar.MiError = False
        Me.chkRefrescar.Name = "chkRefrescar"
        Me.chkRefrescar.Orden = 0
        Me.chkRefrescar.SaltoAlfinal = False
        Me.chkRefrescar.Size = New System.Drawing.Size(141, 20)
        Me.chkRefrescar.TabIndex = 100319
        Me.chkRefrescar.Text = "Refrescar datos"
        Me.chkRefrescar.UseVisualStyleBackColor = True
        Me.chkRefrescar.ValorCampoFalse = Nothing
        Me.chkRefrescar.ValorCampoTrue = Nothing
        Me.chkRefrescar.ValorDefecto = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 425)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1367, 186)
        Me.XtraTabControl1.TabIndex = 203
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1361, 160)
        Me.XtraTabPage1.Text = "Datos pedido"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.LbReferencia)
        Me.Panel4.Controls.Add(Me.LbLote)
        Me.Panel4.Controls.Add(Me.LbObs2)
        Me.Panel4.Controls.Add(Me.LbObs1)
        Me.Panel4.Controls.Add(Me.LbBultosxPalet)
        Me.Panel4.Controls.Add(Me.LbTipoPalet)
        Me.Panel4.Controls.Add(Me.LbEstadoEtiqueta)
        Me.Panel4.Controls.Add(Me.LbCalidad)
        Me.Panel4.Controls.Add(Me.LbMarcaMaterial)
        Me.Panel4.Controls.Add(Me.LbMarcaEtiqueta)
        Me.Panel4.Controls.Add(Me.LbEtiquetaCesta)
        Me.Panel4.Controls.Add(Me.LbPiezasxBulto)
        Me.Panel4.Controls.Add(Me.LbMarca)
        Me.Panel4.Controls.Add(Me.LbEnvase)
        Me.Panel4.Controls.Add(Me.LbFecha)
        Me.Panel4.Controls.Add(Me.LbGenero)
        Me.Panel4.Controls.Add(Me.LbPresentacion)
        Me.Panel4.Controls.Add(Me.LbCliente)
        Me.Panel4.Controls.Add(Me.LbPedido)
        Me.Panel4.Controls.Add(Me.LbCategoria)
        Me.Panel4.Controls.Add(Me.LbEtiquetaCaja)
        Me.Panel4.Controls.Add(Me.Lb32)
        Me.Panel4.Controls.Add(Me.Lb30)
        Me.Panel4.Controls.Add(Me.Lb28)
        Me.Panel4.Controls.Add(Me.Lb25)
        Me.Panel4.Controls.Add(Me.Lb26)
        Me.Panel4.Controls.Add(Me.Lb24)
        Me.Panel4.Controls.Add(Me.Lb22)
        Me.Panel4.Controls.Add(Me.Lb20)
        Me.Panel4.Controls.Add(Me.Lb16)
        Me.Panel4.Controls.Add(Me.Lb14)
        Me.Panel4.Controls.Add(Me.Lb12)
        Me.Panel4.Controls.Add(Me.Lb8)
        Me.Panel4.Controls.Add(Me.Lb23)
        Me.Panel4.Controls.Add(Me.Lb21)
        Me.Panel4.Controls.Add(Me.Lb19)
        Me.Panel4.Controls.Add(Me.Lb15)
        Me.Panel4.Controls.Add(Me.Lb13)
        Me.Panel4.Controls.Add(Me.Lb9)
        Me.Panel4.Controls.Add(Me.Lb4)
        Me.Panel4.Controls.Add(Me.Lb2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1361, 160)
        Me.Panel4.TabIndex = 12
        '
        'LbReferencia
        '
        Me.LbReferencia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbReferencia.ForeColor = System.Drawing.Color.Blue
        Me.LbReferencia.Location = New System.Drawing.Point(385, 129)
        Me.LbReferencia.Name = "LbReferencia"
        Me.LbReferencia.ReadOnly = True
        Me.LbReferencia.Size = New System.Drawing.Size(162, 21)
        Me.LbReferencia.TabIndex = 100322
        '
        'LbLote
        '
        Me.LbLote.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbLote.ForeColor = System.Drawing.Color.Blue
        Me.LbLote.Location = New System.Drawing.Point(75, 129)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.ReadOnly = True
        Me.LbLote.Size = New System.Drawing.Size(190, 21)
        Me.LbLote.TabIndex = 100322
        '
        'LbObs2
        '
        Me.LbObs2.BackColor = System.Drawing.Color.LemonChiffon
        Me.LbObs2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObs2.ForeColor = System.Drawing.Color.Red
        Me.LbObs2.Location = New System.Drawing.Point(622, 129)
        Me.LbObs2.Name = "LbObs2"
        Me.LbObs2.ReadOnly = True
        Me.LbObs2.Size = New System.Drawing.Size(441, 23)
        Me.LbObs2.TabIndex = 100323
        '
        'LbObs1
        '
        Me.LbObs1.BackColor = System.Drawing.Color.LemonChiffon
        Me.LbObs1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObs1.ForeColor = System.Drawing.Color.Red
        Me.LbObs1.Location = New System.Drawing.Point(622, 105)
        Me.LbObs1.Name = "LbObs1"
        Me.LbObs1.ReadOnly = True
        Me.LbObs1.Size = New System.Drawing.Size(441, 23)
        Me.LbObs1.TabIndex = 100321
        '
        'LbBultosxPalet
        '
        Me.LbBultosxPalet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbBultosxPalet.ForeColor = System.Drawing.Color.Blue
        Me.LbBultosxPalet.Location = New System.Drawing.Point(484, 105)
        Me.LbBultosxPalet.Name = "LbBultosxPalet"
        Me.LbBultosxPalet.ReadOnly = True
        Me.LbBultosxPalet.Size = New System.Drawing.Size(63, 21)
        Me.LbBultosxPalet.TabIndex = 100321
        Me.LbBultosxPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbTipoPalet
        '
        Me.LbTipoPalet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbTipoPalet.ForeColor = System.Drawing.Color.Blue
        Me.LbTipoPalet.Location = New System.Drawing.Point(75, 105)
        Me.LbTipoPalet.Name = "LbTipoPalet"
        Me.LbTipoPalet.ReadOnly = True
        Me.LbTipoPalet.Size = New System.Drawing.Size(222, 21)
        Me.LbTipoPalet.TabIndex = 100321
        '
        'LbEstadoEtiqueta
        '
        Me.LbEstadoEtiqueta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbEstadoEtiqueta.ForeColor = System.Drawing.Color.Blue
        Me.LbEstadoEtiqueta.Location = New System.Drawing.Point(838, 81)
        Me.LbEstadoEtiqueta.Name = "LbEstadoEtiqueta"
        Me.LbEstadoEtiqueta.ReadOnly = True
        Me.LbEstadoEtiqueta.Size = New System.Drawing.Size(225, 21)
        Me.LbEstadoEtiqueta.TabIndex = 100321
        '
        'LbCalidad
        '
        Me.LbCalidad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCalidad.ForeColor = System.Drawing.Color.Blue
        Me.LbCalidad.Location = New System.Drawing.Point(622, 81)
        Me.LbCalidad.Name = "LbCalidad"
        Me.LbCalidad.ReadOnly = True
        Me.LbCalidad.Size = New System.Drawing.Size(63, 21)
        Me.LbCalidad.TabIndex = 100321
        '
        'LbMarcaMaterial
        '
        Me.LbMarcaMaterial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbMarcaMaterial.ForeColor = System.Drawing.Color.Blue
        Me.LbMarcaMaterial.Location = New System.Drawing.Point(385, 81)
        Me.LbMarcaMaterial.Name = "LbMarcaMaterial"
        Me.LbMarcaMaterial.ReadOnly = True
        Me.LbMarcaMaterial.Size = New System.Drawing.Size(162, 21)
        Me.LbMarcaMaterial.TabIndex = 100321
        '
        'LbMarcaEtiqueta
        '
        Me.LbMarcaEtiqueta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbMarcaEtiqueta.ForeColor = System.Drawing.Color.Blue
        Me.LbMarcaEtiqueta.Location = New System.Drawing.Point(901, 57)
        Me.LbMarcaEtiqueta.Name = "LbMarcaEtiqueta"
        Me.LbMarcaEtiqueta.ReadOnly = True
        Me.LbMarcaEtiqueta.Size = New System.Drawing.Size(162, 21)
        Me.LbMarcaEtiqueta.TabIndex = 100321
        '
        'LbEtiquetaCesta
        '
        Me.LbEtiquetaCesta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbEtiquetaCesta.ForeColor = System.Drawing.Color.Blue
        Me.LbEtiquetaCesta.Location = New System.Drawing.Point(576, 57)
        Me.LbEtiquetaCesta.Name = "LbEtiquetaCesta"
        Me.LbEtiquetaCesta.ReadOnly = True
        Me.LbEtiquetaCesta.Size = New System.Drawing.Size(259, 21)
        Me.LbEtiquetaCesta.TabIndex = 100321
        '
        'LbPiezasxBulto
        '
        Me.LbPiezasxBulto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbPiezasxBulto.ForeColor = System.Drawing.Color.Blue
        Me.LbPiezasxBulto.Location = New System.Drawing.Point(423, 57)
        Me.LbPiezasxBulto.Name = "LbPiezasxBulto"
        Me.LbPiezasxBulto.ReadOnly = True
        Me.LbPiezasxBulto.Size = New System.Drawing.Size(63, 21)
        Me.LbPiezasxBulto.TabIndex = 100321
        Me.LbPiezasxBulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbMarca
        '
        Me.LbMarca.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbMarca.ForeColor = System.Drawing.Color.Blue
        Me.LbMarca.Location = New System.Drawing.Point(901, 33)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.ReadOnly = True
        Me.LbMarca.Size = New System.Drawing.Size(162, 21)
        Me.LbMarca.TabIndex = 100321
        '
        'LbEnvase
        '
        Me.LbEnvase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbEnvase.ForeColor = System.Drawing.Color.Blue
        Me.LbEnvase.Location = New System.Drawing.Point(576, 33)
        Me.LbEnvase.Name = "LbEnvase"
        Me.LbEnvase.ReadOnly = True
        Me.LbEnvase.Size = New System.Drawing.Size(259, 21)
        Me.LbEnvase.TabIndex = 100321
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(965, 9)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.ReadOnly = True
        Me.LbFecha.Size = New System.Drawing.Size(98, 21)
        Me.LbFecha.TabIndex = 100322
        Me.LbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbGenero
        '
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbGenero.ForeColor = System.Drawing.Color.Blue
        Me.LbGenero.Location = New System.Drawing.Point(576, 9)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.ReadOnly = True
        Me.LbGenero.Size = New System.Drawing.Size(259, 21)
        Me.LbGenero.TabIndex = 100321
        '
        'LbPresentacion
        '
        Me.LbPresentacion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbPresentacion.ForeColor = System.Drawing.Color.Blue
        Me.LbPresentacion.Location = New System.Drawing.Point(75, 33)
        Me.LbPresentacion.Name = "LbPresentacion"
        Me.LbPresentacion.ReadOnly = True
        Me.LbPresentacion.Size = New System.Drawing.Size(409, 21)
        Me.LbPresentacion.TabIndex = 100321
        '
        'LbCliente
        '
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCliente.ForeColor = System.Drawing.Color.Blue
        Me.LbCliente.Location = New System.Drawing.Point(247, 9)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.ReadOnly = True
        Me.LbCliente.Size = New System.Drawing.Size(239, 21)
        Me.LbCliente.TabIndex = 100321
        '
        'LbPedido
        '
        Me.LbPedido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbPedido.ForeColor = System.Drawing.Color.Blue
        Me.LbPedido.Location = New System.Drawing.Point(75, 9)
        Me.LbPedido.Name = "LbPedido"
        Me.LbPedido.ReadOnly = True
        Me.LbPedido.Size = New System.Drawing.Size(85, 21)
        Me.LbPedido.TabIndex = 100320
        '
        'LbCategoria
        '
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCategoria.ForeColor = System.Drawing.Color.Blue
        Me.LbCategoria.Location = New System.Drawing.Point(75, 57)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.ReadOnly = True
        Me.LbCategoria.Size = New System.Drawing.Size(190, 21)
        Me.LbCategoria.TabIndex = 100320
        '
        'LbEtiquetaCaja
        '
        Me.LbEtiquetaCaja.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbEtiquetaCaja.ForeColor = System.Drawing.Color.Blue
        Me.LbEtiquetaCaja.Location = New System.Drawing.Point(75, 81)
        Me.LbEtiquetaCaja.Name = "LbEtiquetaCaja"
        Me.LbEtiquetaCaja.ReadOnly = True
        Me.LbEtiquetaCaja.Size = New System.Drawing.Size(222, 21)
        Me.LbEtiquetaCaja.TabIndex = 100319
        '
        'Lb32
        '
        Me.Lb32.AutoSize = True
        Me.Lb32.CL_ControlAsociado = Nothing
        Me.Lb32.CL_ValorFijo = True
        Me.Lb32.ClForm = Nothing
        Me.Lb32.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb32.ForeColor = System.Drawing.Color.Teal
        Me.Lb32.Location = New System.Drawing.Point(845, 60)
        Me.Lb32.Name = "Lb32"
        Me.Lb32.Size = New System.Drawing.Size(47, 14)
        Me.Lb32.TabIndex = 136
        Me.Lb32.Text = "Marca"
        '
        'Lb30
        '
        Me.Lb30.AutoSize = True
        Me.Lb30.CL_ControlAsociado = Nothing
        Me.Lb30.CL_ValorFijo = True
        Me.Lb30.ClForm = Nothing
        Me.Lb30.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb30.ForeColor = System.Drawing.Color.Teal
        Me.Lb30.Location = New System.Drawing.Point(496, 60)
        Me.Lb30.Name = "Lb30"
        Me.Lb30.Size = New System.Drawing.Size(77, 14)
        Me.Lb30.TabIndex = 134
        Me.Lb30.Text = "Etiq. Cesta"
        '
        'Lb28
        '
        Me.Lb28.AutoSize = True
        Me.Lb28.CL_ControlAsociado = Nothing
        Me.Lb28.CL_ValorFijo = True
        Me.Lb28.ClForm = Nothing
        Me.Lb28.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb28.ForeColor = System.Drawing.Color.Teal
        Me.Lb28.Location = New System.Drawing.Point(300, 84)
        Me.Lb28.Name = "Lb28"
        Me.Lb28.Size = New System.Drawing.Size(79, 14)
        Me.Lb28.TabIndex = 132
        Me.Lb28.Text = "Marca Mat."
        '
        'Lb25
        '
        Me.Lb25.AutoSize = True
        Me.Lb25.CL_ControlAsociado = Nothing
        Me.Lb25.CL_ValorFijo = True
        Me.Lb25.ClForm = Nothing
        Me.Lb25.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb25.ForeColor = System.Drawing.Color.Teal
        Me.Lb25.Location = New System.Drawing.Point(3, 84)
        Me.Lb25.Name = "Lb25"
        Me.Lb25.Size = New System.Drawing.Size(70, 14)
        Me.Lb25.TabIndex = 130
        Me.Lb25.Text = "Etiq. Caja"
        '
        'Lb26
        '
        Me.Lb26.AutoSize = True
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = True
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.ForeColor = System.Drawing.Color.Teal
        Me.Lb26.Location = New System.Drawing.Point(709, 84)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(109, 14)
        Me.Lb26.TabIndex = 128
        Me.Lb26.Text = "Estado etiqueta"
        '
        'Lb24
        '
        Me.Lb24.AutoSize = True
        Me.Lb24.CL_ControlAsociado = Nothing
        Me.Lb24.CL_ValorFijo = True
        Me.Lb24.ClForm = Nothing
        Me.Lb24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb24.ForeColor = System.Drawing.Color.Teal
        Me.Lb24.Location = New System.Drawing.Point(559, 84)
        Me.Lb24.Name = "Lb24"
        Me.Lb24.Size = New System.Drawing.Size(56, 14)
        Me.Lb24.TabIndex = 124
        Me.Lb24.Text = "Calidad"
        '
        'Lb22
        '
        Me.Lb22.AutoSize = True
        Me.Lb22.CL_ControlAsociado = Nothing
        Me.Lb22.CL_ValorFijo = True
        Me.Lb22.ClForm = Nothing
        Me.Lb22.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb22.ForeColor = System.Drawing.Color.Teal
        Me.Lb22.Location = New System.Drawing.Point(496, 36)
        Me.Lb22.Name = "Lb22"
        Me.Lb22.Size = New System.Drawing.Size(54, 14)
        Me.Lb22.TabIndex = 122
        Me.Lb22.Text = "Envase"
        '
        'Lb20
        '
        Me.Lb20.AutoSize = True
        Me.Lb20.CL_ControlAsociado = Nothing
        Me.Lb20.CL_ValorFijo = True
        Me.Lb20.ClForm = Nothing
        Me.Lb20.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb20.ForeColor = System.Drawing.Color.Teal
        Me.Lb20.Location = New System.Drawing.Point(884, 12)
        Me.Lb20.Name = "Lb20"
        Me.Lb20.Size = New System.Drawing.Size(75, 14)
        Me.Lb20.TabIndex = 120
        Me.Lb20.Text = "Fecha Sal."
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(496, 12)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(55, 14)
        Me.Lb16.TabIndex = 118
        Me.Lb16.Text = "Genero"
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(559, 108)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(37, 14)
        Me.Lb14.TabIndex = 108
        Me.Lb14.Text = "Conf"
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(3, 108)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(53, 14)
        Me.Lb12.TabIndex = 106
        Me.Lb12.Text = "T.Palet"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(3, 36)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(62, 14)
        Me.Lb8.TabIndex = 104
        Me.Lb8.Text = "Present."
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(3, 132)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(36, 14)
        Me.Lb23.TabIndex = 101
        Me.Lb23.Text = "Lote"
        '
        'Lb21
        '
        Me.Lb21.AutoSize = True
        Me.Lb21.CL_ControlAsociado = Nothing
        Me.Lb21.CL_ValorFijo = True
        Me.Lb21.ClForm = Nothing
        Me.Lb21.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb21.ForeColor = System.Drawing.Color.Teal
        Me.Lb21.Location = New System.Drawing.Point(322, 60)
        Me.Lb21.Name = "Lb21"
        Me.Lb21.Size = New System.Drawing.Size(100, 14)
        Me.Lb21.TabIndex = 99
        Me.Lb21.Text = "Piezas x Bulto"
        '
        'Lb19
        '
        Me.Lb19.AutoSize = True
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = True
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.Teal
        Me.Lb19.Location = New System.Drawing.Point(380, 108)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(98, 14)
        Me.Lb19.TabIndex = 97
        Me.Lb19.Text = "Bultos x Palet"
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(845, 36)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(47, 14)
        Me.Lb15.TabIndex = 93
        Me.Lb15.Text = "Marca"
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(3, 60)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(33, 14)
        Me.Lb13.TabIndex = 91
        Me.Lb13.Text = "Cat."
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(350, 132)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(29, 14)
        Me.Lb9.TabIndex = 85
        Me.Lb9.Text = "Ref"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(188, 12)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(53, 14)
        Me.Lb4.TabIndex = 83
        Me.Lb4.Text = "Cliente"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(3, 12)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(52, 14)
        Me.Lb2.TabIndex = 81
        Me.Lb2.Text = "Pedido"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1361, 160)
        Me.XtraTabPage2.Text = "Desglose pedido"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel7.Controls.Add(Me.GridDesglosePedidos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1361, 160)
        Me.Panel7.TabIndex = 13
        '
        'GridDesglosePedidos
        '
        Me.GridDesglosePedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDesglosePedidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridDesglosePedidos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDesglosePedidos.Location = New System.Drawing.Point(6, 8)
        Me.GridDesglosePedidos.LookAndFeel.SkinName = "Black"
        Me.GridDesglosePedidos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridDesglosePedidos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridDesglosePedidos.MainView = Me.GridViewDesglosePedidos
        Me.GridDesglosePedidos.Name = "GridDesglosePedidos"
        Me.GridDesglosePedidos.Size = New System.Drawing.Size(813, 148)
        Me.GridDesglosePedidos.TabIndex = 12
        Me.GridDesglosePedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDesglosePedidos})
        '
        'GridViewDesglosePedidos
        '
        Me.GridViewDesglosePedidos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewDesglosePedidos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewDesglosePedidos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewDesglosePedidos.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewDesglosePedidos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewDesglosePedidos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewDesglosePedidos.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDesglosePedidos.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewDesglosePedidos.Appearance.Row.Options.UseFont = True
        Me.GridViewDesglosePedidos.Appearance.Row.Options.UseForeColor = True
        Me.GridViewDesglosePedidos.GridControl = Me.GridDesglosePedidos
        Me.GridViewDesglosePedidos.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewDesglosePedidos.Name = "GridViewDesglosePedidos"
        Me.GridViewDesglosePedidos.OptionsBehavior.Editable = False
        Me.GridViewDesglosePedidos.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewDesglosePedidos.OptionsView.ShowGroupPanel = False
        '
        'LbNomCliente
        '
        Me.LbNomCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCliente.CL_ControlAsociado = Nothing
        Me.LbNomCliente.CL_ValorFijo = False
        Me.LbNomCliente.ClForm = Nothing
        Me.LbNomCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCliente.Location = New System.Drawing.Point(204, 41)
        Me.LbNomCliente.Name = "LbNomCliente"
        Me.LbNomCliente.Size = New System.Drawing.Size(357, 23)
        Me.LbNomCliente.TabIndex = 100323
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_Ancho = 0
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_BuscarEnTodosLosCampos = False
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
        Me.BtBuscaCliente.Location = New System.Drawing.Point(165, 41)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 100322
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
        '
        'TxCliente
        '
        Me.TxCliente.Autonumerico = False
        Me.TxCliente.Bloqueado = False
        Me.TxCliente.Buscando = False
        Me.TxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCliente.ClForm = Nothing
        Me.TxCliente.ClParam = Nothing
        Me.TxCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCliente.GridLin = Nothing
        Me.TxCliente.HaCambiado = False
        Me.TxCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCliente.lbbusca = Nothing
        Me.TxCliente.Location = New System.Drawing.Point(109, 41)
        Me.TxCliente.MiError = False
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.Orden = 0
        Me.TxCliente.SaltoAlfinal = False
        Me.TxCliente.Siguiente = 0
        Me.TxCliente.Size = New System.Drawing.Size(53, 22)
        Me.TxCliente.TabIndex = 100321
        Me.TxCliente.TeclaRepetida = False
        Me.TxCliente.TxDatoFinalSemana = Nothing
        Me.TxCliente.TxDatoInicioSemana = Nothing
        Me.TxCliente.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(7, 44)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(59, 16)
        Me.Lb_4.TabIndex = 100320
        Me.Lb_4.Text = "Cliente"
        '
        'LbNomGenero
        '
        Me.LbNomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGenero.CL_ControlAsociado = Nothing
        Me.LbNomGenero.CL_ValorFijo = False
        Me.LbNomGenero.ClForm = Nothing
        Me.LbNomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGenero.Location = New System.Drawing.Point(204, 69)
        Me.LbNomGenero.Name = "LbNomGenero"
        Me.LbNomGenero.Size = New System.Drawing.Size(357, 23)
        Me.LbNomGenero.TabIndex = 100327
        '
        'BtBuscaGenero
        '
        Me.BtBuscaGenero.CL_Ancho = 0
        Me.BtBuscaGenero.CL_BuscaAlb = False
        Me.BtBuscaGenero.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaGenero.CL_campocodigo = Nothing
        Me.BtBuscaGenero.CL_camponombre = Nothing
        Me.BtBuscaGenero.CL_CampoOrden = "Nombre"
        Me.BtBuscaGenero.CL_ch1000 = False
        Me.BtBuscaGenero.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGenero.CL_ControlAsociado = Nothing
        Me.BtBuscaGenero.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGenero.CL_dfecha = Nothing
        Me.BtBuscaGenero.CL_Entidad = Nothing
        Me.BtBuscaGenero.CL_EsId = True
        Me.BtBuscaGenero.CL_Filtro = Nothing
        Me.BtBuscaGenero.cl_formu = Nothing
        Me.BtBuscaGenero.CL_hfecha = Nothing
        Me.BtBuscaGenero.cl_ListaW = Nothing
        Me.BtBuscaGenero.CL_xCentro = False
        Me.BtBuscaGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGenero.Location = New System.Drawing.Point(165, 69)
        Me.BtBuscaGenero.Name = "BtBuscaGenero"
        Me.BtBuscaGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGenero.TabIndex = 100326
        Me.BtBuscaGenero.UseVisualStyleBackColor = True
        '
        'TxGenero
        '
        Me.TxGenero.Autonumerico = False
        Me.TxGenero.Bloqueado = False
        Me.TxGenero.Buscando = False
        Me.TxGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGenero.ClForm = Nothing
        Me.TxGenero.ClParam = Nothing
        Me.TxGenero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGenero.GridLin = Nothing
        Me.TxGenero.HaCambiado = False
        Me.TxGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxGenero.lbbusca = Nothing
        Me.TxGenero.Location = New System.Drawing.Point(109, 69)
        Me.TxGenero.MiError = False
        Me.TxGenero.Name = "TxGenero"
        Me.TxGenero.Orden = 0
        Me.TxGenero.SaltoAlfinal = False
        Me.TxGenero.Siguiente = 0
        Me.TxGenero.Size = New System.Drawing.Size(53, 22)
        Me.TxGenero.TabIndex = 100325
        Me.TxGenero.TeclaRepetida = False
        Me.TxGenero.TxDatoFinalSemana = Nothing
        Me.TxGenero.TxDatoInicioSemana = Nothing
        Me.TxGenero.UltimoValorValidado = Nothing
        '
        'Lb27
        '
        Me.Lb27.AutoSize = True
        Me.Lb27.CL_ControlAsociado = Nothing
        Me.Lb27.CL_ValorFijo = False
        Me.Lb27.ClForm = Nothing
        Me.Lb27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb27.ForeColor = System.Drawing.Color.Teal
        Me.Lb27.Location = New System.Drawing.Point(7, 72)
        Me.Lb27.Name = "Lb27"
        Me.Lb27.Size = New System.Drawing.Size(60, 16)
        Me.Lb27.TabIndex = 100324
        Me.Lb27.Text = "Genero"
        '
        'ChkOcultarCargados
        '
        Me.ChkOcultarCargados.AutoSize = True
        Me.ChkOcultarCargados.Campobd = Nothing
        Me.ChkOcultarCargados.Checked = True
        Me.ChkOcultarCargados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkOcultarCargados.ClForm = Nothing
        Me.ChkOcultarCargados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOcultarCargados.ForeColor = System.Drawing.Color.Teal
        Me.ChkOcultarCargados.GridLin = Nothing
        Me.ChkOcultarCargados.HaCambiado = False
        Me.ChkOcultarCargados.Location = New System.Drawing.Point(887, 70)
        Me.ChkOcultarCargados.MiEntidad = Nothing
        Me.ChkOcultarCargados.MiError = False
        Me.ChkOcultarCargados.Name = "ChkOcultarCargados"
        Me.ChkOcultarCargados.Orden = 0
        Me.ChkOcultarCargados.SaltoAlfinal = False
        Me.ChkOcultarCargados.Size = New System.Drawing.Size(151, 20)
        Me.ChkOcultarCargados.TabIndex = 100328
        Me.ChkOcultarCargados.Text = "Ocultar cargados"
        Me.ChkOcultarCargados.UseVisualStyleBackColor = True
        Me.ChkOcultarCargados.ValorCampoFalse = Nothing
        Me.ChkOcultarCargados.ValorCampoTrue = Nothing
        Me.ChkOcultarCargados.ValorDefecto = False
        '
        'TxDiasHasta
        '
        Me.TxDiasHasta.Autonumerico = False
        Me.TxDiasHasta.Bloqueado = False
        Me.TxDiasHasta.Buscando = False
        Me.TxDiasHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDiasHasta.ClForm = Nothing
        Me.TxDiasHasta.ClParam = Nothing
        Me.TxDiasHasta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDiasHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDiasHasta.GridLin = Nothing
        Me.TxDiasHasta.HaCambiado = False
        Me.TxDiasHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDiasHasta.lbbusca = Nothing
        Me.TxDiasHasta.Location = New System.Drawing.Point(624, 69)
        Me.TxDiasHasta.MiError = False
        Me.TxDiasHasta.Name = "TxDiasHasta"
        Me.TxDiasHasta.Orden = 0
        Me.TxDiasHasta.SaltoAlfinal = False
        Me.TxDiasHasta.Siguiente = 0
        Me.TxDiasHasta.Size = New System.Drawing.Size(31, 22)
        Me.TxDiasHasta.TabIndex = 100329
        Me.TxDiasHasta.TeclaRepetida = False
        Me.TxDiasHasta.TxDatoFinalSemana = Nothing
        Me.TxDiasHasta.TxDatoInicioSemana = Nothing
        Me.TxDiasHasta.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(569, 72)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(51, 16)
        Me.Lb6.TabIndex = 100330
        Me.Lb6.Text = "Hasta"
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = True
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(690, 72)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(155, 16)
        Me.Lb29.TabIndex = 100331
        Me.Lb29.Text = "días (contando hoy)"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(657, 70)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(18, 20)
        Me.NumericUpDown1.TabIndex = 100332
        '
        'ChkCompras
        '
        Me.ChkCompras.AutoSize = True
        Me.ChkCompras.Campobd = Nothing
        Me.ChkCompras.ClForm = Nothing
        Me.ChkCompras.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCompras.ForeColor = System.Drawing.Color.Tomato
        Me.ChkCompras.GridLin = Nothing
        Me.ChkCompras.HaCambiado = False
        Me.ChkCompras.Location = New System.Drawing.Point(1056, 70)
        Me.ChkCompras.MiEntidad = Nothing
        Me.ChkCompras.MiError = False
        Me.ChkCompras.Name = "ChkCompras"
        Me.ChkCompras.Orden = 0
        Me.ChkCompras.SaltoAlfinal = False
        Me.ChkCompras.Size = New System.Drawing.Size(140, 20)
        Me.ChkCompras.TabIndex = 100334
        Me.ChkCompras.Text = "Incluir compras"
        Me.ChkCompras.UseVisualStyleBackColor = True
        Me.ChkCompras.ValorCampoFalse = Nothing
        Me.ChkCompras.ValorCampoTrue = Nothing
        Me.ChkCompras.ValorDefecto = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbSalidos)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(918, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 39)
        Me.GroupBox2.TabIndex = 100335
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.ForeColor = System.Drawing.Color.Teal
        Me.rbTodos.Location = New System.Drawing.Point(124, 13)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(69, 20)
        Me.rbTodos.TabIndex = 3
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbSalidos
        '
        Me.rbSalidos.AutoSize = True
        Me.rbSalidos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSalidos.ForeColor = System.Drawing.Color.Teal
        Me.rbSalidos.Location = New System.Drawing.Point(29, 13)
        Me.rbSalidos.Name = "rbSalidos"
        Me.rbSalidos.Size = New System.Drawing.Size(78, 20)
        Me.rbSalidos.TabIndex = 2
        Me.rbSalidos.Text = "Salidos"
        Me.rbSalidos.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.LbExceso)
        Me.Panel6.Controls.Add(Me.Lb11)
        Me.Panel6.Controls.Add(Me.LbPtes)
        Me.Panel6.Controls.Add(Me.Lb7)
        Me.Panel6.Controls.Add(Me.LbStock)
        Me.Panel6.Controls.Add(Me.Lb18)
        Me.Panel6.Controls.Add(Me.LbReserv)
        Me.Panel6.Controls.Add(Me.Lb10)
        Me.Panel6.Controls.Add(Me.LbPalets)
        Me.Panel6.Controls.Add(Me.Lb17)
        Me.Panel6.Location = New System.Drawing.Point(1070, 446)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 160)
        Me.Panel6.TabIndex = 100324
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btCartelones)
        Me.Panel5.Controls.Add(Me.btNuevoPaletStock)
        Me.Panel5.Controls.Add(Me.PanelBotones)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(203, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 160)
        Me.Panel5.TabIndex = 128
        '
        'btCartelones
        '
        Me.btCartelones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btCartelones.Location = New System.Drawing.Point(0, 137)
        Me.btCartelones.Name = "btCartelones"
        Me.btCartelones.Size = New System.Drawing.Size(97, 23)
        Me.btCartelones.TabIndex = 89
        Me.btCartelones.Text = "Cartelones"
        Me.btCartelones.UseVisualStyleBackColor = True
        '
        'btNuevoPaletStock
        '
        Me.btNuevoPaletStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btNuevoPaletStock.Location = New System.Drawing.Point(0, 102)
        Me.btNuevoPaletStock.Name = "btNuevoPaletStock"
        Me.btNuevoPaletStock.Size = New System.Drawing.Size(97, 35)
        Me.btNuevoPaletStock.TabIndex = 88
        Me.btNuevoPaletStock.Text = "NUEVO PALET STOCK"
        Me.btNuevoPaletStock.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.btNuevoPalet)
        Me.PanelBotones.Controls.Add(Me.BtVerPedido)
        Me.PanelBotones.Controls.Add(Me.BtMuestra)
        Me.PanelBotones.Controls.Add(Me.BtVerEtiqueta)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotones.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(97, 102)
        Me.PanelBotones.TabIndex = 87
        '
        'btNuevoPalet
        '
        Me.btNuevoPalet.Dock = System.Windows.Forms.DockStyle.Top
        Me.btNuevoPalet.Location = New System.Drawing.Point(0, 72)
        Me.btNuevoPalet.Name = "btNuevoPalet"
        Me.btNuevoPalet.Size = New System.Drawing.Size(97, 30)
        Me.btNuevoPalet.TabIndex = 86
        Me.btNuevoPalet.Text = "NUEVO PALET"
        Me.btNuevoPalet.UseVisualStyleBackColor = True
        '
        'BtVerPedido
        '
        Me.BtVerPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtVerPedido.Location = New System.Drawing.Point(0, 48)
        Me.BtVerPedido.Name = "BtVerPedido"
        Me.BtVerPedido.Size = New System.Drawing.Size(97, 24)
        Me.BtVerPedido.TabIndex = 83
        Me.BtVerPedido.Text = "Ver pedido"
        Me.BtVerPedido.UseVisualStyleBackColor = True
        '
        'BtMuestra
        '
        Me.BtMuestra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtMuestra.Location = New System.Drawing.Point(0, 24)
        Me.BtMuestra.Name = "BtMuestra"
        Me.BtMuestra.Size = New System.Drawing.Size(97, 24)
        Me.BtMuestra.TabIndex = 85
        Me.BtMuestra.Text = "Muestra"
        Me.BtMuestra.UseVisualStyleBackColor = True
        '
        'BtVerEtiqueta
        '
        Me.BtVerEtiqueta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtVerEtiqueta.Location = New System.Drawing.Point(0, 0)
        Me.BtVerEtiqueta.Name = "BtVerEtiqueta"
        Me.BtVerEtiqueta.Size = New System.Drawing.Size(97, 24)
        Me.BtVerEtiqueta.TabIndex = 84
        Me.BtVerEtiqueta.Text = "Etiq.Cliente"
        Me.BtVerEtiqueta.UseVisualStyleBackColor = True
        '
        'LbExceso
        '
        Me.LbExceso.BackColor = System.Drawing.Color.White
        Me.LbExceso.CL_ControlAsociado = Nothing
        Me.LbExceso.CL_ValorFijo = False
        Me.LbExceso.ClForm = Nothing
        Me.LbExceso.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbExceso.ForeColor = System.Drawing.Color.Blue
        Me.LbExceso.Location = New System.Drawing.Point(130, 104)
        Me.LbExceso.Name = "LbExceso"
        Me.LbExceso.Size = New System.Drawing.Size(63, 22)
        Me.LbExceso.TabIndex = 127
        Me.LbExceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(7, 107)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(117, 16)
        Me.Lb11.TabIndex = 126
        Me.Lb11.Text = "Sobrante stock"
        '
        'LbPtes
        '
        Me.LbPtes.BackColor = System.Drawing.Color.White
        Me.LbPtes.CL_ControlAsociado = Nothing
        Me.LbPtes.CL_ValorFijo = False
        Me.LbPtes.ClForm = Nothing
        Me.LbPtes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPtes.ForeColor = System.Drawing.Color.Blue
        Me.LbPtes.Location = New System.Drawing.Point(130, 80)
        Me.LbPtes.Name = "LbPtes"
        Me.LbPtes.Size = New System.Drawing.Size(63, 22)
        Me.LbPtes.TabIndex = 125
        Me.LbPtes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(7, 83)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(89, 16)
        Me.Lb7.TabIndex = 124
        Me.Lb7.Text = "Palets ptes"
        '
        'LbStock
        '
        Me.LbStock.BackColor = System.Drawing.Color.White
        Me.LbStock.CL_ControlAsociado = Nothing
        Me.LbStock.CL_ValorFijo = False
        Me.LbStock.ClForm = Nothing
        Me.LbStock.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStock.ForeColor = System.Drawing.Color.Blue
        Me.LbStock.Location = New System.Drawing.Point(130, 56)
        Me.LbStock.Name = "LbStock"
        Me.LbStock.Size = New System.Drawing.Size(63, 22)
        Me.LbStock.TabIndex = 123
        Me.LbStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb18
        '
        Me.Lb18.AutoSize = True
        Me.Lb18.CL_ControlAsociado = Nothing
        Me.Lb18.CL_ValorFijo = True
        Me.Lb18.ClForm = Nothing
        Me.Lb18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb18.ForeColor = System.Drawing.Color.Teal
        Me.Lb18.Location = New System.Drawing.Point(7, 59)
        Me.Lb18.Name = "Lb18"
        Me.Lb18.Size = New System.Drawing.Size(96, 16)
        Me.Lb18.TabIndex = 122
        Me.Lb18.Text = "Palets stock"
        '
        'LbReserv
        '
        Me.LbReserv.BackColor = System.Drawing.Color.White
        Me.LbReserv.CL_ControlAsociado = Nothing
        Me.LbReserv.CL_ValorFijo = False
        Me.LbReserv.ClForm = Nothing
        Me.LbReserv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReserv.ForeColor = System.Drawing.Color.Blue
        Me.LbReserv.Location = New System.Drawing.Point(130, 32)
        Me.LbReserv.Name = "LbReserv"
        Me.LbReserv.Size = New System.Drawing.Size(63, 22)
        Me.LbReserv.TabIndex = 121
        Me.LbReserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(7, 35)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(109, 16)
        Me.Lb10.TabIndex = 120
        Me.Lb10.Text = "Palets reserv."
        '
        'LbPalets
        '
        Me.LbPalets.BackColor = System.Drawing.Color.White
        Me.LbPalets.CL_ControlAsociado = Nothing
        Me.LbPalets.CL_ValorFijo = False
        Me.LbPalets.ClForm = Nothing
        Me.LbPalets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalets.ForeColor = System.Drawing.Color.Blue
        Me.LbPalets.Location = New System.Drawing.Point(130, 8)
        Me.LbPalets.Name = "LbPalets"
        Me.LbPalets.Size = New System.Drawing.Size(63, 22)
        Me.LbPalets.TabIndex = 119
        Me.LbPalets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb17
        '
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = True
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.Teal
        Me.Lb17.Location = New System.Drawing.Point(7, 11)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(114, 16)
        Me.Lb17.TabIndex = 118
        Me.Lb17.Text = "Palets pedidos"
        '
        'FrmConsultaPedidosAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 642)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me._PanelCargando)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaPedidosAlmacen"
        Me.Text = "Consulta pedidos"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Panel6, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GridDesglosePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDesglosePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.PanelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbLineas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbReferencia As System.Windows.Forms.TextBox
    Friend WithEvents LbLote As System.Windows.Forms.TextBox
    Friend WithEvents LbObs2 As System.Windows.Forms.TextBox
    Friend WithEvents LbObs1 As System.Windows.Forms.TextBox
    Friend WithEvents LbBultosxPalet As System.Windows.Forms.TextBox
    Friend WithEvents LbTipoPalet As System.Windows.Forms.TextBox
    Friend WithEvents LbEstadoEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents LbCalidad As System.Windows.Forms.TextBox
    Friend WithEvents LbMarcaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents LbMarcaEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents LbEtiquetaCesta As System.Windows.Forms.TextBox
    Friend WithEvents LbPiezasxBulto As System.Windows.Forms.TextBox
    Friend WithEvents LbMarca As System.Windows.Forms.TextBox
    Friend WithEvents LbEnvase As System.Windows.Forms.TextBox
    Friend WithEvents LbFecha As System.Windows.Forms.TextBox
    Friend WithEvents LbGenero As System.Windows.Forms.TextBox
    Friend WithEvents LbPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents LbCliente As System.Windows.Forms.TextBox
    Friend WithEvents LbPedido As System.Windows.Forms.TextBox
    Friend WithEvents LbCategoria As System.Windows.Forms.TextBox
    Friend WithEvents LbEtiquetaCaja As System.Windows.Forms.TextBox
    Friend WithEvents Lb32 As NetAgro.Lb
    Friend WithEvents Lb30 As NetAgro.Lb
    Friend WithEvents Lb28 As NetAgro.Lb
    Friend WithEvents Lb25 As NetAgro.Lb
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents Lb24 As NetAgro.Lb
    Friend WithEvents Lb22 As NetAgro.Lb
    Friend WithEvents Lb20 As NetAgro.Lb
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents Lb21 As NetAgro.Lb
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Public WithEvents GridDesglosePedidos As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewDesglosePedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkRefrescar As NetAgro.Chk
    Friend WithEvents LbNomCliente As NetAgro.Lb
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents TxCliente As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents LbNomGenero As NetAgro.Lb
    Friend WithEvents BtBuscaGenero As NetAgro.BtBusca
    Friend WithEvents TxGenero As NetAgro.TxDato
    Friend WithEvents Lb27 As NetAgro.Lb
    Friend WithEvents ChkOcultarCargados As NetAgro.Chk
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDiasHasta As NetAgro.TxDato
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChkCompras As NetAgro.Chk
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbSalidos As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btCartelones As Button
    Friend WithEvents btNuevoPaletStock As Button
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents btNuevoPalet As Button
    Friend WithEvents BtVerPedido As Button
    Friend WithEvents BtMuestra As Button
    Friend WithEvents BtVerEtiqueta As Button
    Friend WithEvents LbExceso As Lb
    Friend WithEvents Lb11 As Lb
    Friend WithEvents LbPtes As Lb
    Friend WithEvents Lb7 As Lb
    Friend WithEvents LbStock As Lb
    Friend WithEvents Lb18 As Lb
    Friend WithEvents LbReserv As Lb
    Friend WithEvents Lb10 As Lb
    Friend WithEvents LbPalets As Lb
    Friend WithEvents Lb17 As Lb
End Class
