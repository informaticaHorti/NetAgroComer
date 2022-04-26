<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgricultores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgricultores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtObserva = New NetAgro.ClButton()
        Me.btNifs = New System.Windows.Forms.Button()
        Me.BtBuscaAgri = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.TxDato_3 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.ChkNoFacturar = New NetAgro.Chk(Me.components)
        Me.BtContactos = New NetAgro.ClButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridAsociados = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAsociados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChkAsignarAcreedor = New NetAgro.Chk(Me.components)
        Me.Lbnom_45 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCentroRec = New NetAgro.BtBusca(Me.components)
        Me.TxDato_45 = New NetAgro.TxDato(Me.components)
        Me.Lb_45 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.CbFaccom = New NetAgro.CbBox(Me.components)
        Me.Lbnom_44 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAcreedor = New NetAgro.BtBusca(Me.components)
        Me.TxDato_44 = New NetAgro.TxDato(Me.components)
        Me.Lb_44 = New NetAgro.Lb(Me.components)
        Me.Chprin = New NetAgro.Chk(Me.components)
        Me.ChFija = New NetAgro.Chk(Me.components)
        Me.TxDato_43 = New NetAgro.TxDato(Me.components)
        Me.Lb_43 = New NetAgro.Lb(Me.components)
        Me.Lb_Nom42 = New NetAgro.Lb(Me.components)
        Me.BtBuscaGasto = New NetAgro.BtBusca(Me.components)
        Me.TxDato_42 = New NetAgro.TxDato(Me.components)
        Me.Lb_42 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridMed = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LbEmailCalidad = New NetAgro.Lb(Me.components)
        Me.TxEmailCalidad = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btEditarIBAN = New NetAgro.ClButton()
        Me.btIBAN = New System.Windows.Forms.Button()
        Me.RbTransferencia = New System.Windows.Forms.RadioButton()
        Me.RbPagare = New System.Windows.Forms.RadioButton()
        Me.rbTalon = New System.Windows.Forms.RadioButton()
        Me.LbIBAN = New NetAgro.Lb(Me.components)
        Me.TxIBAN = New NetAgro.TxDato(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxDiasVto = New NetAgro.TxDato(Me.components)
        Me.LbDiasVto = New NetAgro.Lb(Me.components)
        Me.LbNom_TipoDoc = New NetAgro.Lb(Me.components)
        Me.TxTipoDoc = New NetAgro.TxDato(Me.components)
        Me.BtBuscaTipoDoc = New NetAgro.BtBusca(Me.components)
        Me.LbTipoDoc = New NetAgro.Lb(Me.components)
        Me.LbNom_SitCartera = New NetAgro.Lb(Me.components)
        Me.TxSitCartera = New NetAgro.TxDato(Me.components)
        Me.BtBuscaSitCartera = New NetAgro.BtBusca(Me.components)
        Me.LbSitCartera = New NetAgro.Lb(Me.components)
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.BtCentro = New NetAgro.BtBusca(Me.components)
        Me.TxCentro = New NetAgro.TxDato(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.LbNomBanco = New NetAgro.Lb(Me.components)
        Me.BtBanco = New NetAgro.BtBusca(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.LbSerie = New NetAgro.Lb(Me.components)
        Me.TxSerie = New NetAgro.TxDato(Me.components)
        Me.LbAltaopfh = New NetAgro.Lb(Me.components)
        Me.TxAltaOpFH = New NetAgro.TxDato(Me.components)
        Me.LbNomCrecogida = New NetAgro.Lb(Me.components)
        Me.BtBuscaCRecogida = New NetAgro.BtBusca(Me.components)
        Me.TxCrecogida = New NetAgro.TxDato(Me.components)
        Me.LbCrecogida = New NetAgro.Lb(Me.components)
        Me.LbNomEmpresa = New NetAgro.Lb(Me.components)
        Me.BtBuscaEmpresa = New NetAgro.BtBusca(Me.components)
        Me.TxEmpresa = New NetAgro.TxDato(Me.components)
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.LbNomCenvases = New NetAgro.Lb(Me.components)
        Me.BtBuscaCenvases = New NetAgro.BtBusca(Me.components)
        Me.TxCenvases = New NetAgro.TxDato(Me.components)
        Me.LbCenvases = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxMensaje = New NetAgro.TxDato(Me.components)
        Me.ChkMostrarMensaje = New NetAgro.Chk(Me.components)
        Me.ChkBloqueoPagos = New NetAgro.Chk(Me.components)
        Me.Lb_25 = New NetAgro.Lb(Me.components)
        Me.TxDato_25 = New NetAgro.TxDato(Me.components)
        Me.TxDato_26 = New NetAgro.TxDato(Me.components)
        Me.Lb_26 = New NetAgro.Lb(Me.components)
        Me.TxDato_24 = New NetAgro.TxDato(Me.components)
        Me.Lb_24 = New NetAgro.Lb(Me.components)
        Me.TxDato_23 = New NetAgro.TxDato(Me.components)
        Me.Lb_23 = New NetAgro.Lb(Me.components)
        Me.Lbret = New NetAgro.Lb(Me.components)
        Me.Lb42 = New NetAgro.Lb(Me.components)
        Me.Lbiva = New NetAgro.Lb(Me.components)
        Me.Lb40 = New NetAgro.Lb(Me.components)
        Me.LbNom_14 = New NetAgro.Lb(Me.components)
        Me.BtBuscaPrinci = New NetAgro.BtBusca(Me.components)
        Me.TxDato_14 = New NetAgro.TxDato(Me.components)
        Me.Lb_14 = New NetAgro.Lb(Me.components)
        Me.TxDato_12 = New NetAgro.TxDato(Me.components)
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.ChBloqueo = New NetAgro.Chk(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.BtBuscaTipoProv = New NetAgro.BtBusca(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.Lb_13 = New NetAgro.Lb(Me.components)
        Me.TxDato_13 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_9 = New NetAgro.Lb(Me.components)
        Me.BtBuscaPais = New NetAgro.BtBusca(Me.components)
        Me.TxDato_9 = New NetAgro.TxDato(Me.components)
        Me.Lb_9 = New NetAgro.Lb(Me.components)
        Me.Lb_8 = New NetAgro.Lb(Me.components)
        Me.TxDato_8 = New NetAgro.TxDato(Me.components)
        Me.Lb_7 = New NetAgro.Lb(Me.components)
        Me.TxDato_7 = New NetAgro.TxDato(Me.components)
        Me.Lb_6 = New NetAgro.Lb(Me.components)
        Me.TxDato_6 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.TxDato_4 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_5 = New NetAgro.Lb(Me.components)
        Me.btBuscaZona = New NetAgro.BtBusca(Me.components)
        Me.TxDato_5 = New NetAgro.TxDato(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridSaldosEnvases = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSaldosEnvases = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridSaldos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSaldos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GridFacturasPendientesPago = New DevExpress.XtraGrid.GridControl()
        Me.GridViewFacturasPendientesPago = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridAlbaranesPendientesFacturar = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAlbaranesPendientesFacturar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridSaldosEnvases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSaldosEnvases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridFacturasPendientesPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFacturasPendientesPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAlbaranesPendientesFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAlbaranesPendientesFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.BtObserva)
        Me.Panel2.Controls.Add(Me.btNifs)
        Me.Panel2.Controls.Add(Me.BtBuscaAgri)
        Me.Panel2.Controls.Add(Me.Lb_2)
        Me.Panel2.Controls.Add(Me.TxDato_2)
        Me.Panel2.Controls.Add(Me.Lb_3)
        Me.Panel2.Controls.Add(Me.TxDato_3)
        Me.Panel2.Controls.Add(Me.BotonesAvance1)
        Me.Panel2.Controls.Add(Me.Lb_1)
        Me.Panel2.Controls.Add(Me.ChkNoFacturar)
        Me.Panel2.Controls.Add(Me.TxDato_1)
        Me.Panel2.Controls.Add(Me.BtContactos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 64)
        Me.Panel2.TabIndex = 6
        '
        'BtObserva
        '
        Me.BtObserva.Image = CType(resources.GetObject("BtObserva.Image"), System.Drawing.Image)
        Me.BtObserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtObserva.Location = New System.Drawing.Point(785, 4)
        Me.BtObserva.Name = "BtObserva"
        Me.BtObserva.Orden = 0
        Me.BtObserva.PedirClave = True
        Me.BtObserva.Size = New System.Drawing.Size(95, 31)
        Me.BtObserva.TabIndex = 181
        Me.BtObserva.Text = "Observ."
        Me.BtObserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtObserva.UseVisualStyleBackColor = True
        '
        'btNifs
        '
        Me.btNifs.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.btNifs.Location = New System.Drawing.Point(533, 5)
        Me.btNifs.Name = "btNifs"
        Me.btNifs.Size = New System.Drawing.Size(33, 23)
        Me.btNifs.TabIndex = 29
        Me.btNifs.UseVisualStyleBackColor = True
        '
        'BtBuscaAgri
        '
        Me.BtBuscaAgri.CL_Ancho = 0
        Me.BtBuscaAgri.CL_BuscaAlb = False
        Me.BtBuscaAgri.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaAgri.CL_campocodigo = Nothing
        Me.BtBuscaAgri.CL_camponombre = Nothing
        Me.BtBuscaAgri.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgri.CL_ch1000 = False
        Me.BtBuscaAgri.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgri.CL_ControlAsociado = Me.TxDato_1
        Me.BtBuscaAgri.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgri.CL_dfecha = Nothing
        Me.BtBuscaAgri.CL_Entidad = Nothing
        Me.BtBuscaAgri.CL_EsId = True
        Me.BtBuscaAgri.CL_Filtro = Nothing
        Me.BtBuscaAgri.cl_formu = Nothing
        Me.BtBuscaAgri.CL_hfecha = Nothing
        Me.BtBuscaAgri.cl_ListaW = Nothing
        Me.BtBuscaAgri.CL_xCentro = False
        Me.BtBuscaAgri.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgri.Location = New System.Drawing.Point(152, 5)
        Me.BtBuscaAgri.Name = "BtBuscaAgri"
        Me.BtBuscaAgri.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgri.TabIndex = 28
        Me.BtBuscaAgri.UseVisualStyleBackColor = True
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Bloqueado = False
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
        Me.TxDato_1.Location = New System.Drawing.Point(87, 5)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(59, 22)
        Me.TxDato_1.TabIndex = 21
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(344, 9)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(26, 16)
        Me.Lb_2.TabIndex = 27
        Me.Lb_2.Text = "Nif"
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Bloqueado = False
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
        Me.TxDato_2.Location = New System.Drawing.Point(394, 6)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(136, 22)
        Me.TxDato_2.TabIndex = 26
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(12, 36)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(64, 16)
        Me.Lb_3.TabIndex = 25
        Me.Lb_3.Text = "Nombre"
        '
        'TxDato_3
        '
        Me.TxDato_3.Autonumerico = False
        Me.TxDato_3.Bloqueado = False
        Me.TxDato_3.Buscando = False
        Me.TxDato_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_3.ClForm = Nothing
        Me.TxDato_3.ClParam = Nothing
        Me.TxDato_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_3.GridLin = Nothing
        Me.TxDato_3.HaCambiado = False
        Me.TxDato_3.lbbusca = Nothing
        Me.TxDato_3.Location = New System.Drawing.Point(87, 33)
        Me.TxDato_3.MiError = False
        Me.TxDato_3.Name = "TxDato_3"
        Me.TxDato_3.Orden = 0
        Me.TxDato_3.SaltoAlfinal = False
        Me.TxDato_3.Siguiente = 0
        Me.TxDato_3.Size = New System.Drawing.Size(508, 22)
        Me.TxDato_3.TabIndex = 24
        Me.TxDato_3.TeclaRepetida = False
        Me.TxDato_3.TxDatoFinalSemana = Nothing
        Me.TxDato_3.TxDatoInicioSemana = Nothing
        Me.TxDato_3.UltimoValorValidado = Nothing
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
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(12, 9)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(57, 16)
        Me.Lb_1.TabIndex = 22
        Me.Lb_1.Text = "Código"
        '
        'ChkNoFacturar
        '
        Me.ChkNoFacturar.AutoSize = True
        Me.ChkNoFacturar.Campobd = Nothing
        Me.ChkNoFacturar.ClForm = Nothing
        Me.ChkNoFacturar.Enabled = False
        Me.ChkNoFacturar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNoFacturar.ForeColor = System.Drawing.Color.Teal
        Me.ChkNoFacturar.GridLin = Nothing
        Me.ChkNoFacturar.HaCambiado = False
        Me.ChkNoFacturar.Location = New System.Drawing.Point(645, 34)
        Me.ChkNoFacturar.MiEntidad = Nothing
        Me.ChkNoFacturar.MiError = False
        Me.ChkNoFacturar.Name = "ChkNoFacturar"
        Me.ChkNoFacturar.Orden = 0
        Me.ChkNoFacturar.SaltoAlfinal = False
        Me.ChkNoFacturar.Size = New System.Drawing.Size(126, 20)
        Me.ChkNoFacturar.TabIndex = 216
        Me.ChkNoFacturar.Text = "NO FACTURAR"
        Me.ChkNoFacturar.UseVisualStyleBackColor = True
        Me.ChkNoFacturar.ValorCampoFalse = Nothing
        Me.ChkNoFacturar.ValorCampoTrue = Nothing
        Me.ChkNoFacturar.ValorDefecto = False
        '
        'BtContactos
        '
        Me.BtContactos.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcard_32x32_32
        Me.BtContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtContactos.Location = New System.Drawing.Point(882, 4)
        Me.BtContactos.Name = "BtContactos"
        Me.BtContactos.Orden = 0
        Me.BtContactos.PedirClave = True
        Me.BtContactos.Size = New System.Drawing.Size(95, 31)
        Me.BtContactos.TabIndex = 180
        Me.BtContactos.Text = "Contactos"
        Me.BtContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtContactos.UseVisualStyleBackColor = True
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridAsociados
        Me.GridView2.Name = "GridView2"
        '
        'GridAsociados
        '
        Me.GridAsociados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridAsociados.Location = New System.Drawing.Point(36, 46)
        Me.GridAsociados.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridAsociados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridAsociados.MainView = Me.GridViewAsociados
        Me.GridAsociados.Name = "GridAsociados"
        Me.GridAsociados.Size = New System.Drawing.Size(409, 415)
        Me.GridAsociados.TabIndex = 176
        Me.GridAsociados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAsociados, Me.GridView3, Me.GridView2})
        '
        'GridViewAsociados
        '
        Me.GridViewAsociados.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewAsociados.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewAsociados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewAsociados.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewAsociados.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewAsociados.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridViewAsociados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewAsociados.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewAsociados.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAsociados.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewAsociados.Appearance.Row.Options.UseFont = True
        Me.GridViewAsociados.Appearance.Row.Options.UseForeColor = True
        Me.GridViewAsociados.GridControl = Me.GridAsociados
        Me.GridViewAsociados.Name = "GridViewAsociados"
        Me.GridViewAsociados.OptionsView.ShowGroupPanel = False
        '
        'GridView3
        '
        Me.GridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView3.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.Row.Options.UseForeColor = True
        Me.GridView3.GridControl = Me.GridAsociados
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ChkAsignarAcreedor)
        Me.XtraTabPage3.Controls.Add(Me.Lbnom_45)
        Me.XtraTabPage3.Controls.Add(Me.BtBuscaCentroRec)
        Me.XtraTabPage3.Controls.Add(Me.TxDato_45)
        Me.XtraTabPage3.Controls.Add(Me.Lb_45)
        Me.XtraTabPage3.Controls.Add(Me.Lb8)
        Me.XtraTabPage3.Controls.Add(Me.CbFaccom)
        Me.XtraTabPage3.Controls.Add(Me.Lbnom_44)
        Me.XtraTabPage3.Controls.Add(Me.BtBuscaAcreedor)
        Me.XtraTabPage3.Controls.Add(Me.TxDato_44)
        Me.XtraTabPage3.Controls.Add(Me.Lb_44)
        Me.XtraTabPage3.Controls.Add(Me.Chprin)
        Me.XtraTabPage3.Controls.Add(Me.ChFija)
        Me.XtraTabPage3.Controls.Add(Me.TxDato_43)
        Me.XtraTabPage3.Controls.Add(Me.Lb_43)
        Me.XtraTabPage3.Controls.Add(Me.Lb_Nom42)
        Me.XtraTabPage3.Controls.Add(Me.BtBuscaGasto)
        Me.XtraTabPage3.Controls.Add(Me.TxDato_42)
        Me.XtraTabPage3.Controls.Add(Me.Lb_42)
        Me.XtraTabPage3.Controls.Add(Me.ClGrid1)
        Me.XtraTabPage3.Controls.Add(Me.Label3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(976, 484)
        Me.XtraTabPage3.Text = "Gastos"
        '
        'ChkAsignarAcreedor
        '
        Me.ChkAsignarAcreedor.AutoSize = True
        Me.ChkAsignarAcreedor.Campobd = Nothing
        Me.ChkAsignarAcreedor.ClForm = Nothing
        Me.ChkAsignarAcreedor.Enabled = False
        Me.ChkAsignarAcreedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAsignarAcreedor.ForeColor = System.Drawing.Color.Teal
        Me.ChkAsignarAcreedor.GridLin = Nothing
        Me.ChkAsignarAcreedor.HaCambiado = False
        Me.ChkAsignarAcreedor.Location = New System.Drawing.Point(60, 184)
        Me.ChkAsignarAcreedor.MiEntidad = Nothing
        Me.ChkAsignarAcreedor.MiError = False
        Me.ChkAsignarAcreedor.Name = "ChkAsignarAcreedor"
        Me.ChkAsignarAcreedor.Orden = 0
        Me.ChkAsignarAcreedor.SaltoAlfinal = False
        Me.ChkAsignarAcreedor.Size = New System.Drawing.Size(233, 20)
        Me.ChkAsignarAcreedor.TabIndex = 112
        Me.ChkAsignarAcreedor.Text = "Asignar acreedor de entrada"
        Me.ChkAsignarAcreedor.UseVisualStyleBackColor = True
        Me.ChkAsignarAcreedor.ValorCampoFalse = Nothing
        Me.ChkAsignarAcreedor.ValorCampoTrue = Nothing
        Me.ChkAsignarAcreedor.ValorDefecto = False
        '
        'Lbnom_45
        '
        Me.Lbnom_45.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_45.CL_ControlAsociado = Nothing
        Me.Lbnom_45.CL_ValorFijo = False
        Me.Lbnom_45.ClForm = Nothing
        Me.Lbnom_45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_45.Location = New System.Drawing.Point(249, 210)
        Me.Lbnom_45.Name = "Lbnom_45"
        Me.Lbnom_45.Size = New System.Drawing.Size(194, 23)
        Me.Lbnom_45.TabIndex = 111
        '
        'BtBuscaCentroRec
        '
        Me.BtBuscaCentroRec.CL_Ancho = 0
        Me.BtBuscaCentroRec.CL_BuscaAlb = False
        Me.BtBuscaCentroRec.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaCentroRec.CL_campocodigo = Nothing
        Me.BtBuscaCentroRec.CL_camponombre = Nothing
        Me.BtBuscaCentroRec.CL_CampoOrden = "Nombre"
        Me.BtBuscaCentroRec.CL_ch1000 = False
        Me.BtBuscaCentroRec.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCentroRec.CL_ControlAsociado = Me.TxDato_45
        Me.BtBuscaCentroRec.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCentroRec.CL_dfecha = Nothing
        Me.BtBuscaCentroRec.CL_Entidad = Nothing
        Me.BtBuscaCentroRec.CL_EsId = True
        Me.BtBuscaCentroRec.CL_Filtro = Nothing
        Me.BtBuscaCentroRec.cl_formu = Nothing
        Me.BtBuscaCentroRec.CL_hfecha = Nothing
        Me.BtBuscaCentroRec.cl_ListaW = Nothing
        Me.BtBuscaCentroRec.CL_xCentro = False
        Me.BtBuscaCentroRec.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCentroRec.Location = New System.Drawing.Point(210, 210)
        Me.BtBuscaCentroRec.Name = "BtBuscaCentroRec"
        Me.BtBuscaCentroRec.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCentroRec.TabIndex = 110
        Me.BtBuscaCentroRec.UseVisualStyleBackColor = True
        '
        'TxDato_45
        '
        Me.TxDato_45.Autonumerico = False
        Me.TxDato_45.Bloqueado = False
        Me.TxDato_45.Buscando = False
        Me.TxDato_45.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_45.ClForm = Nothing
        Me.TxDato_45.ClParam = Nothing
        Me.TxDato_45.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_45.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_45.GridLin = Nothing
        Me.TxDato_45.HaCambiado = False
        Me.TxDato_45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_45.lbbusca = Nothing
        Me.TxDato_45.Location = New System.Drawing.Point(164, 211)
        Me.TxDato_45.MiError = False
        Me.TxDato_45.Name = "TxDato_45"
        Me.TxDato_45.Orden = 0
        Me.TxDato_45.SaltoAlfinal = False
        Me.TxDato_45.Siguiente = 0
        Me.TxDato_45.Size = New System.Drawing.Size(43, 22)
        Me.TxDato_45.TabIndex = 109
        Me.TxDato_45.TeclaRepetida = False
        Me.TxDato_45.TxDatoFinalSemana = Nothing
        Me.TxDato_45.TxDatoInicioSemana = Nothing
        Me.TxDato_45.UltimoValorValidado = Nothing
        '
        'Lb_45
        '
        Me.Lb_45.AutoSize = True
        Me.Lb_45.BackColor = System.Drawing.Color.Transparent
        Me.Lb_45.CL_ControlAsociado = Nothing
        Me.Lb_45.CL_ValorFijo = False
        Me.Lb_45.ClForm = Nothing
        Me.Lb_45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_45.ForeColor = System.Drawing.Color.Teal
        Me.Lb_45.Location = New System.Drawing.Point(57, 214)
        Me.Lb_45.Name = "Lb_45"
        Me.Lb_45.Size = New System.Drawing.Size(86, 16)
        Me.Lb_45.TabIndex = 108
        Me.Lb_45.Text = "Centro Rec"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(57, 121)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(37, 16)
        Me.Lb8.TabIndex = 107
        Me.Lb8.Text = "Tipo"
        '
        'CbFaccom
        '
        Me.CbFaccom.Campobd = Nothing
        Me.CbFaccom.ClForm = Nothing
        Me.CbFaccom.DeshabilitarRuedaRaton = False
        Me.CbFaccom.FormattingEnabled = True
        Me.CbFaccom.GridLin = Nothing
        Me.CbFaccom.Location = New System.Drawing.Point(164, 120)
        Me.CbFaccom.MiEntidad = Nothing
        Me.CbFaccom.MiError = False
        Me.CbFaccom.Name = "CbFaccom"
        Me.CbFaccom.Orden = 0
        Me.CbFaccom.SaltoAlfinal = False
        Me.CbFaccom.Size = New System.Drawing.Size(186, 21)
        Me.CbFaccom.TabIndex = 106
        '
        'Lbnom_44
        '
        Me.Lbnom_44.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_44.CL_ControlAsociado = Nothing
        Me.Lbnom_44.CL_ValorFijo = False
        Me.Lbnom_44.ClForm = Nothing
        Me.Lbnom_44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_44.Location = New System.Drawing.Point(249, 149)
        Me.Lbnom_44.Name = "Lbnom_44"
        Me.Lbnom_44.Size = New System.Drawing.Size(349, 23)
        Me.Lbnom_44.TabIndex = 105
        '
        'BtBuscaAcreedor
        '
        Me.BtBuscaAcreedor.CL_Ancho = 0
        Me.BtBuscaAcreedor.CL_BuscaAlb = False
        Me.BtBuscaAcreedor.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaAcreedor.CL_campocodigo = Nothing
        Me.BtBuscaAcreedor.CL_camponombre = Nothing
        Me.BtBuscaAcreedor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAcreedor.CL_ch1000 = False
        Me.BtBuscaAcreedor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAcreedor.CL_ControlAsociado = Me.TxDato_44
        Me.BtBuscaAcreedor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAcreedor.CL_dfecha = Nothing
        Me.BtBuscaAcreedor.CL_Entidad = Nothing
        Me.BtBuscaAcreedor.CL_EsId = True
        Me.BtBuscaAcreedor.CL_Filtro = Nothing
        Me.BtBuscaAcreedor.cl_formu = Nothing
        Me.BtBuscaAcreedor.CL_hfecha = Nothing
        Me.BtBuscaAcreedor.cl_ListaW = Nothing
        Me.BtBuscaAcreedor.CL_xCentro = False
        Me.BtBuscaAcreedor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAcreedor.Location = New System.Drawing.Point(210, 149)
        Me.BtBuscaAcreedor.Name = "BtBuscaAcreedor"
        Me.BtBuscaAcreedor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAcreedor.TabIndex = 104
        Me.BtBuscaAcreedor.UseVisualStyleBackColor = True
        '
        'TxDato_44
        '
        Me.TxDato_44.Autonumerico = False
        Me.TxDato_44.Bloqueado = False
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
        Me.TxDato_44.Location = New System.Drawing.Point(164, 150)
        Me.TxDato_44.MiError = False
        Me.TxDato_44.Name = "TxDato_44"
        Me.TxDato_44.Orden = 0
        Me.TxDato_44.SaltoAlfinal = False
        Me.TxDato_44.Siguiente = 0
        Me.TxDato_44.Size = New System.Drawing.Size(43, 22)
        Me.TxDato_44.TabIndex = 103
        Me.TxDato_44.TeclaRepetida = False
        Me.TxDato_44.TxDatoFinalSemana = Nothing
        Me.TxDato_44.TxDatoInicioSemana = Nothing
        Me.TxDato_44.UltimoValorValidado = Nothing
        '
        'Lb_44
        '
        Me.Lb_44.AutoSize = True
        Me.Lb_44.BackColor = System.Drawing.Color.Transparent
        Me.Lb_44.CL_ControlAsociado = Nothing
        Me.Lb_44.CL_ValorFijo = False
        Me.Lb_44.ClForm = Nothing
        Me.Lb_44.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_44.ForeColor = System.Drawing.Color.Teal
        Me.Lb_44.Location = New System.Drawing.Point(57, 153)
        Me.Lb_44.Name = "Lb_44"
        Me.Lb_44.Size = New System.Drawing.Size(73, 16)
        Me.Lb_44.TabIndex = 102
        Me.Lb_44.Text = "Acreedor"
        '
        'Chprin
        '
        Me.Chprin.AutoSize = True
        Me.Chprin.Campobd = Nothing
        Me.Chprin.ClForm = Nothing
        Me.Chprin.Enabled = False
        Me.Chprin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chprin.ForeColor = System.Drawing.Color.Teal
        Me.Chprin.GridLin = Nothing
        Me.Chprin.HaCambiado = False
        Me.Chprin.Location = New System.Drawing.Point(449, 94)
        Me.Chprin.MiEntidad = Nothing
        Me.Chprin.MiError = False
        Me.Chprin.Name = "Chprin"
        Me.Chprin.Orden = 0
        Me.Chprin.SaltoAlfinal = False
        Me.Chprin.Size = New System.Drawing.Size(154, 20)
        Me.Chprin.TabIndex = 101
        Me.Chprin.Text = "Pedir en entradas"
        Me.Chprin.UseVisualStyleBackColor = True
        Me.Chprin.ValorCampoFalse = Nothing
        Me.Chprin.ValorCampoTrue = Nothing
        Me.Chprin.ValorDefecto = False
        '
        'ChFija
        '
        Me.ChFija.AutoSize = True
        Me.ChFija.Campobd = Nothing
        Me.ChFija.ClForm = Nothing
        Me.ChFija.Enabled = False
        Me.ChFija.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChFija.ForeColor = System.Drawing.Color.Teal
        Me.ChFija.GridLin = Nothing
        Me.ChFija.HaCambiado = False
        Me.ChFija.Location = New System.Drawing.Point(306, 93)
        Me.ChFija.MiEntidad = Nothing
        Me.ChFija.MiError = False
        Me.ChFija.Name = "ChFija"
        Me.ChFija.Orden = 0
        Me.ChFija.SaltoAlfinal = False
        Me.ChFija.Size = New System.Drawing.Size(99, 20)
        Me.ChFija.TabIndex = 100
        Me.ChFija.Text = "Gasto Fijo"
        Me.ChFija.UseVisualStyleBackColor = True
        Me.ChFija.ValorCampoFalse = Nothing
        Me.ChFija.ValorCampoTrue = Nothing
        Me.ChFija.ValorDefecto = False
        '
        'TxDato_43
        '
        Me.TxDato_43.Autonumerico = False
        Me.TxDato_43.Bloqueado = False
        Me.TxDato_43.Buscando = False
        Me.TxDato_43.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_43.ClForm = Nothing
        Me.TxDato_43.ClParam = Nothing
        Me.TxDato_43.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_43.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_43.GridLin = Nothing
        Me.TxDato_43.HaCambiado = False
        Me.TxDato_43.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_43.lbbusca = Nothing
        Me.TxDato_43.Location = New System.Drawing.Point(164, 92)
        Me.TxDato_43.MiError = False
        Me.TxDato_43.Name = "TxDato_43"
        Me.TxDato_43.Orden = 0
        Me.TxDato_43.SaltoAlfinal = False
        Me.TxDato_43.Siguiente = 0
        Me.TxDato_43.Size = New System.Drawing.Size(107, 22)
        Me.TxDato_43.TabIndex = 78
        Me.TxDato_43.TeclaRepetida = False
        Me.TxDato_43.TxDatoFinalSemana = Nothing
        Me.TxDato_43.TxDatoInicioSemana = Nothing
        Me.TxDato_43.UltimoValorValidado = Nothing
        '
        'Lb_43
        '
        Me.Lb_43.AutoSize = True
        Me.Lb_43.BackColor = System.Drawing.Color.Transparent
        Me.Lb_43.CL_ControlAsociado = Nothing
        Me.Lb_43.CL_ValorFijo = False
        Me.Lb_43.ClForm = Nothing
        Me.Lb_43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_43.ForeColor = System.Drawing.Color.Teal
        Me.Lb_43.Location = New System.Drawing.Point(57, 92)
        Me.Lb_43.Name = "Lb_43"
        Me.Lb_43.Size = New System.Drawing.Size(45, 16)
        Me.Lb_43.TabIndex = 77
        Me.Lb_43.Text = "Valor"
        '
        'Lb_Nom42
        '
        Me.Lb_Nom42.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_Nom42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Nom42.CL_ControlAsociado = Nothing
        Me.Lb_Nom42.CL_ValorFijo = False
        Me.Lb_Nom42.ClForm = Nothing
        Me.Lb_Nom42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Nom42.Location = New System.Drawing.Point(252, 61)
        Me.Lb_Nom42.Name = "Lb_Nom42"
        Me.Lb_Nom42.Size = New System.Drawing.Size(349, 23)
        Me.Lb_Nom42.TabIndex = 76
        '
        'BtBuscaGasto
        '
        Me.BtBuscaGasto.CL_Ancho = 0
        Me.BtBuscaGasto.CL_BuscaAlb = False
        Me.BtBuscaGasto.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaGasto.CL_campocodigo = Nothing
        Me.BtBuscaGasto.CL_camponombre = Nothing
        Me.BtBuscaGasto.CL_CampoOrden = "Nombre"
        Me.BtBuscaGasto.CL_ch1000 = False
        Me.BtBuscaGasto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGasto.CL_ControlAsociado = Me.TxDato_42
        Me.BtBuscaGasto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGasto.CL_dfecha = Nothing
        Me.BtBuscaGasto.CL_Entidad = Nothing
        Me.BtBuscaGasto.CL_EsId = True
        Me.BtBuscaGasto.CL_Filtro = Nothing
        Me.BtBuscaGasto.cl_formu = Nothing
        Me.BtBuscaGasto.CL_hfecha = Nothing
        Me.BtBuscaGasto.cl_ListaW = Nothing
        Me.BtBuscaGasto.CL_xCentro = False
        Me.BtBuscaGasto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGasto.Location = New System.Drawing.Point(213, 61)
        Me.BtBuscaGasto.Name = "BtBuscaGasto"
        Me.BtBuscaGasto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGasto.TabIndex = 75
        Me.BtBuscaGasto.UseVisualStyleBackColor = True
        '
        'TxDato_42
        '
        Me.TxDato_42.Autonumerico = False
        Me.TxDato_42.Bloqueado = False
        Me.TxDato_42.Buscando = False
        Me.TxDato_42.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_42.ClForm = Nothing
        Me.TxDato_42.ClParam = Nothing
        Me.TxDato_42.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_42.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_42.GridLin = Nothing
        Me.TxDato_42.HaCambiado = False
        Me.TxDato_42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_42.lbbusca = Nothing
        Me.TxDato_42.Location = New System.Drawing.Point(164, 62)
        Me.TxDato_42.MiError = False
        Me.TxDato_42.Name = "TxDato_42"
        Me.TxDato_42.Orden = 0
        Me.TxDato_42.SaltoAlfinal = False
        Me.TxDato_42.Siguiente = 0
        Me.TxDato_42.Size = New System.Drawing.Size(43, 22)
        Me.TxDato_42.TabIndex = 74
        Me.TxDato_42.TeclaRepetida = False
        Me.TxDato_42.TxDatoFinalSemana = Nothing
        Me.TxDato_42.TxDatoInicioSemana = Nothing
        Me.TxDato_42.UltimoValorValidado = Nothing
        '
        'Lb_42
        '
        Me.Lb_42.AutoSize = True
        Me.Lb_42.BackColor = System.Drawing.Color.Transparent
        Me.Lb_42.CL_ControlAsociado = Nothing
        Me.Lb_42.CL_ValorFijo = False
        Me.Lb_42.ClForm = Nothing
        Me.Lb_42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_42.ForeColor = System.Drawing.Color.Teal
        Me.Lb_42.Location = New System.Drawing.Point(57, 65)
        Me.Lb_42.Name = "Lb_42"
        Me.Lb_42.Size = New System.Drawing.Size(102, 16)
        Me.Lb_42.TabIndex = 73
        Me.Lb_42.Text = "Código gasto"
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
        Me.ClGrid1.Location = New System.Drawing.Point(38, 258)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(560, 188)
        Me.ClGrid1.TabIndex = 72
        Me.ClGrid1.UltimoControl = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(593, 437)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Otros gastos"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridMed)
        Me.XtraTabPage2.Controls.Add(Me.Label2)
        Me.XtraTabPage2.Controls.Add(Me.GridAsociados)
        Me.XtraTabPage2.Controls.Add(Me.Lb1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(976, 484)
        Me.XtraTabPage2.Text = "Otros datos"
        '
        'GridMed
        '
        Me.GridMed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridMed.Location = New System.Drawing.Point(483, 27)
        Me.GridMed.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridMed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridMed.MainView = Me.GridView7
        Me.GridMed.Name = "GridMed"
        Me.GridMed.Size = New System.Drawing.Size(483, 434)
        Me.GridMed.TabIndex = 179
        Me.GridMed.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7, Me.GridView8, Me.GridView9})
        '
        'GridView7
        '
        Me.GridView7.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView7.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView7.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView7.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView7.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView7.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView7.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView7.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView7.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView7.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView7.Appearance.Row.Options.UseFont = True
        Me.GridView7.Appearance.Row.Options.UseForeColor = True
        Me.GridView7.GridControl = Me.GridMed
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.GridMed
        Me.GridView8.Name = "GridView8"
        '
        'GridView9
        '
        Me.GridView9.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView9.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView9.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView9.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView9.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView9.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView9.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView9.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView9.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView9.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView9.Appearance.Row.Options.UseFont = True
        Me.GridView9.Appearance.Row.Options.UseForeColor = True
        Me.GridView9.GridControl = Me.GridMed
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 464)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Medianerías"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Blue
        Me.Lb1.Location = New System.Drawing.Point(24, 15)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(172, 16)
        Me.Lb1.TabIndex = 173
        Me.Lb1.Text = "Agricultores asociados"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.LbEmailCalidad)
        Me.XtraTabPage1.Controls.Add(Me.TxEmailCalidad)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.LbNomCentro)
        Me.XtraTabPage1.Controls.Add(Me.BtCentro)
        Me.XtraTabPage1.Controls.Add(Me.TxCentro)
        Me.XtraTabPage1.Controls.Add(Me.LbCentro)
        Me.XtraTabPage1.Controls.Add(Me.LbNomBanco)
        Me.XtraTabPage1.Controls.Add(Me.BtBanco)
        Me.XtraTabPage1.Controls.Add(Me.TxBanco)
        Me.XtraTabPage1.Controls.Add(Me.LbBanco)
        Me.XtraTabPage1.Controls.Add(Me.LbSerie)
        Me.XtraTabPage1.Controls.Add(Me.TxSerie)
        Me.XtraTabPage1.Controls.Add(Me.LbAltaopfh)
        Me.XtraTabPage1.Controls.Add(Me.TxAltaOpFH)
        Me.XtraTabPage1.Controls.Add(Me.LbNomCrecogida)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaCRecogida)
        Me.XtraTabPage1.Controls.Add(Me.TxCrecogida)
        Me.XtraTabPage1.Controls.Add(Me.LbCrecogida)
        Me.XtraTabPage1.Controls.Add(Me.LbNomEmpresa)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaEmpresa)
        Me.XtraTabPage1.Controls.Add(Me.TxEmpresa)
        Me.XtraTabPage1.Controls.Add(Me.LbEmpresa)
        Me.XtraTabPage1.Controls.Add(Me.LbNomCenvases)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaCenvases)
        Me.XtraTabPage1.Controls.Add(Me.TxCenvases)
        Me.XtraTabPage1.Controls.Add(Me.LbCenvases)
        Me.XtraTabPage1.Controls.Add(Me.Lb3)
        Me.XtraTabPage1.Controls.Add(Me.TxDato1)
        Me.XtraTabPage1.Controls.Add(Me.Lb2)
        Me.XtraTabPage1.Controls.Add(Me.TxMensaje)
        Me.XtraTabPage1.Controls.Add(Me.ChkMostrarMensaje)
        Me.XtraTabPage1.Controls.Add(Me.ChkBloqueoPagos)
        Me.XtraTabPage1.Controls.Add(Me.Lb_25)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_25)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_26)
        Me.XtraTabPage1.Controls.Add(Me.Lb_26)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_24)
        Me.XtraTabPage1.Controls.Add(Me.Lb_24)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_23)
        Me.XtraTabPage1.Controls.Add(Me.Lb_23)
        Me.XtraTabPage1.Controls.Add(Me.Lbret)
        Me.XtraTabPage1.Controls.Add(Me.Lb42)
        Me.XtraTabPage1.Controls.Add(Me.Lbiva)
        Me.XtraTabPage1.Controls.Add(Me.Lb40)
        Me.XtraTabPage1.Controls.Add(Me.LbNom_14)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaPrinci)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_14)
        Me.XtraTabPage1.Controls.Add(Me.Lb_14)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_12)
        Me.XtraTabPage1.Controls.Add(Me.Lb_11)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_11)
        Me.XtraTabPage1.Controls.Add(Me.ChBloqueo)
        Me.XtraTabPage1.Controls.Add(Me.Lbnom_10)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaTipoProv)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_10)
        Me.XtraTabPage1.Controls.Add(Me.Lb_10)
        Me.XtraTabPage1.Controls.Add(Me.Lb_13)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_13)
        Me.XtraTabPage1.Controls.Add(Me.Lbnom_9)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaPais)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_9)
        Me.XtraTabPage1.Controls.Add(Me.Lb_9)
        Me.XtraTabPage1.Controls.Add(Me.Lb_8)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_8)
        Me.XtraTabPage1.Controls.Add(Me.Lb_7)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_7)
        Me.XtraTabPage1.Controls.Add(Me.Lb_6)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_6)
        Me.XtraTabPage1.Controls.Add(Me.Lb_4)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_4)
        Me.XtraTabPage1.Controls.Add(Me.Lbnom_5)
        Me.XtraTabPage1.Controls.Add(Me.btBuscaZona)
        Me.XtraTabPage1.Controls.Add(Me.TxDato_5)
        Me.XtraTabPage1.Controls.Add(Me.Lb_5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(976, 484)
        Me.XtraTabPage1.Text = "Datos Fiscales"
        '
        'LbEmailCalidad
        '
        Me.LbEmailCalidad.AutoSize = True
        Me.LbEmailCalidad.CL_ControlAsociado = Nothing
        Me.LbEmailCalidad.CL_ValorFijo = False
        Me.LbEmailCalidad.ClForm = Nothing
        Me.LbEmailCalidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmailCalidad.ForeColor = System.Drawing.Color.Teal
        Me.LbEmailCalidad.Location = New System.Drawing.Point(9, 166)
        Me.LbEmailCalidad.Name = "LbEmailCalidad"
        Me.LbEmailCalidad.Size = New System.Drawing.Size(94, 16)
        Me.LbEmailCalidad.TabIndex = 100309
        Me.LbEmailCalidad.Text = "Mail Calidad"
        '
        'TxEmailCalidad
        '
        Me.TxEmailCalidad.Autonumerico = False
        Me.TxEmailCalidad.Bloqueado = False
        Me.TxEmailCalidad.Buscando = False
        Me.TxEmailCalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmailCalidad.ClForm = Nothing
        Me.TxEmailCalidad.ClParam = Nothing
        Me.TxEmailCalidad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmailCalidad.GridLin = Nothing
        Me.TxEmailCalidad.HaCambiado = False
        Me.TxEmailCalidad.lbbusca = Nothing
        Me.TxEmailCalidad.Location = New System.Drawing.Point(105, 163)
        Me.TxEmailCalidad.MiError = False
        Me.TxEmailCalidad.Name = "TxEmailCalidad"
        Me.TxEmailCalidad.Orden = 0
        Me.TxEmailCalidad.SaltoAlfinal = False
        Me.TxEmailCalidad.Siguiente = 0
        Me.TxEmailCalidad.Size = New System.Drawing.Size(847, 22)
        Me.TxEmailCalidad.TabIndex = 100308
        Me.TxEmailCalidad.TeclaRepetida = False
        Me.TxEmailCalidad.TxDatoFinalSemana = Nothing
        Me.TxEmailCalidad.TxDatoInicioSemana = Nothing
        Me.TxEmailCalidad.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btEditarIBAN)
        Me.GroupBox1.Controls.Add(Me.btIBAN)
        Me.GroupBox1.Controls.Add(Me.RbTransferencia)
        Me.GroupBox1.Controls.Add(Me.RbPagare)
        Me.GroupBox1.Controls.Add(Me.rbTalon)
        Me.GroupBox1.Controls.Add(Me.LbIBAN)
        Me.GroupBox1.Controls.Add(Me.TxIBAN)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(10, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(956, 81)
        Me.GroupBox1.TabIndex = 100307
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de pago"
        '
        'btEditarIBAN
        '
        Me.btEditarIBAN.Image = Global.NetAgro.My.Resources.Resources.icons8_padlock_16__1_
        Me.btEditarIBAN.Location = New System.Drawing.Point(382, 47)
        Me.btEditarIBAN.Name = "btEditarIBAN"
        Me.btEditarIBAN.Orden = 0
        Me.btEditarIBAN.PedirClave = True
        Me.btEditarIBAN.Size = New System.Drawing.Size(23, 23)
        Me.btEditarIBAN.TabIndex = 100312
        Me.btEditarIBAN.UseVisualStyleBackColor = True
        '
        'btIBAN
        '
        Me.btIBAN.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.btIBAN.Location = New System.Drawing.Point(65, 48)
        Me.btIBAN.Name = "btIBAN"
        Me.btIBAN.Size = New System.Drawing.Size(33, 23)
        Me.btIBAN.TabIndex = 100310
        Me.btIBAN.UseVisualStyleBackColor = True
        '
        'RbTransferencia
        '
        Me.RbTransferencia.AutoSize = True
        Me.RbTransferencia.ForeColor = System.Drawing.Color.Black
        Me.RbTransferencia.Location = New System.Drawing.Point(179, 23)
        Me.RbTransferencia.Name = "RbTransferencia"
        Me.RbTransferencia.Size = New System.Drawing.Size(113, 19)
        Me.RbTransferencia.TabIndex = 100309
        Me.RbTransferencia.Text = "Transferencia"
        Me.RbTransferencia.UseVisualStyleBackColor = True
        '
        'RbPagare
        '
        Me.RbPagare.AutoSize = True
        Me.RbPagare.ForeColor = System.Drawing.Color.Black
        Me.RbPagare.Location = New System.Drawing.Point(95, 23)
        Me.RbPagare.Name = "RbPagare"
        Me.RbPagare.Size = New System.Drawing.Size(71, 19)
        Me.RbPagare.TabIndex = 100308
        Me.RbPagare.Text = "Pagaré"
        Me.RbPagare.UseVisualStyleBackColor = True
        '
        'rbTalon
        '
        Me.rbTalon.AutoSize = True
        Me.rbTalon.Checked = True
        Me.rbTalon.ForeColor = System.Drawing.Color.Black
        Me.rbTalon.Location = New System.Drawing.Point(22, 23)
        Me.rbTalon.Name = "rbTalon"
        Me.rbTalon.Size = New System.Drawing.Size(61, 19)
        Me.rbTalon.TabIndex = 100307
        Me.rbTalon.TabStop = True
        Me.rbTalon.Text = "Talon"
        Me.rbTalon.UseVisualStyleBackColor = True
        '
        'LbIBAN
        '
        Me.LbIBAN.AutoSize = True
        Me.LbIBAN.CL_ControlAsociado = Nothing
        Me.LbIBAN.CL_ValorFijo = False
        Me.LbIBAN.ClForm = Nothing
        Me.LbIBAN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIBAN.ForeColor = System.Drawing.Color.Teal
        Me.LbIBAN.Location = New System.Drawing.Point(21, 50)
        Me.LbIBAN.Name = "LbIBAN"
        Me.LbIBAN.Size = New System.Drawing.Size(43, 16)
        Me.LbIBAN.TabIndex = 100305
        Me.LbIBAN.Text = "IBAN"
        '
        'TxIBAN
        '
        Me.TxIBAN.Autonumerico = False
        Me.TxIBAN.Bloqueado = False
        Me.TxIBAN.Buscando = False
        Me.TxIBAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIBAN.ClForm = Nothing
        Me.TxIBAN.ClParam = Nothing
        Me.TxIBAN.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIBAN.GridLin = Nothing
        Me.TxIBAN.HaCambiado = False
        Me.TxIBAN.lbbusca = Nothing
        Me.TxIBAN.Location = New System.Drawing.Point(102, 48)
        Me.TxIBAN.MiError = False
        Me.TxIBAN.Name = "TxIBAN"
        Me.TxIBAN.Orden = 0
        Me.TxIBAN.SaltoAlfinal = False
        Me.TxIBAN.Siguiente = 0
        Me.TxIBAN.Size = New System.Drawing.Size(277, 22)
        Me.TxIBAN.TabIndex = 100306
        Me.TxIBAN.TeclaRepetida = False
        Me.TxIBAN.TxDatoFinalSemana = Nothing
        Me.TxIBAN.TxDatoInicioSemana = Nothing
        Me.TxIBAN.UltimoValorValidado = Nothing
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxDiasVto)
        Me.Panel5.Controls.Add(Me.LbDiasVto)
        Me.Panel5.Controls.Add(Me.LbNom_TipoDoc)
        Me.Panel5.Controls.Add(Me.TxTipoDoc)
        Me.Panel5.Controls.Add(Me.BtBuscaTipoDoc)
        Me.Panel5.Controls.Add(Me.LbTipoDoc)
        Me.Panel5.Controls.Add(Me.LbNom_SitCartera)
        Me.Panel5.Controls.Add(Me.TxSitCartera)
        Me.Panel5.Controls.Add(Me.BtBuscaSitCartera)
        Me.Panel5.Controls.Add(Me.LbSitCartera)
        Me.Panel5.Location = New System.Drawing.Point(414, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(532, 62)
        Me.Panel5.TabIndex = 100304
        '
        'TxDiasVto
        '
        Me.TxDiasVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxDiasVto.Autonumerico = False
        Me.TxDiasVto.Bloqueado = False
        Me.TxDiasVto.Buscando = False
        Me.TxDiasVto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDiasVto.ClForm = Nothing
        Me.TxDiasVto.ClParam = Nothing
        Me.TxDiasVto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDiasVto.GridLin = Nothing
        Me.TxDiasVto.HaCambiado = False
        Me.TxDiasVto.lbbusca = Nothing
        Me.TxDiasVto.Location = New System.Drawing.Point(87, 9)
        Me.TxDiasVto.MiError = False
        Me.TxDiasVto.Name = "TxDiasVto"
        Me.TxDiasVto.Orden = 0
        Me.TxDiasVto.SaltoAlfinal = False
        Me.TxDiasVto.Siguiente = 0
        Me.TxDiasVto.Size = New System.Drawing.Size(36, 22)
        Me.TxDiasVto.TabIndex = 100329
        Me.TxDiasVto.TeclaRepetida = False
        Me.TxDiasVto.TxDatoFinalSemana = Nothing
        Me.TxDiasVto.TxDatoInicioSemana = Nothing
        Me.TxDiasVto.UltimoValorValidado = Nothing
        '
        'LbDiasVto
        '
        Me.LbDiasVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDiasVto.AutoSize = True
        Me.LbDiasVto.CL_ControlAsociado = Nothing
        Me.LbDiasVto.CL_ValorFijo = True
        Me.LbDiasVto.ClForm = Nothing
        Me.LbDiasVto.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDiasVto.ForeColor = System.Drawing.Color.Teal
        Me.LbDiasVto.Location = New System.Drawing.Point(13, 11)
        Me.LbDiasVto.Name = "LbDiasVto"
        Me.LbDiasVto.Size = New System.Drawing.Size(67, 16)
        Me.LbDiasVto.TabIndex = 100327
        Me.LbDiasVto.Text = "Dias Vto"
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
        Me.LbNom_TipoDoc.Location = New System.Drawing.Point(317, 33)
        Me.LbNom_TipoDoc.Name = "LbNom_TipoDoc"
        Me.LbNom_TipoDoc.Size = New System.Drawing.Size(204, 23)
        Me.LbNom_TipoDoc.TabIndex = 100326
        Me.LbNom_TipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxTipoDoc
        '
        Me.TxTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxTipoDoc.Autonumerico = False
        Me.TxTipoDoc.Bloqueado = False
        Me.TxTipoDoc.Buscando = False
        Me.TxTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipoDoc.ClForm = Nothing
        Me.TxTipoDoc.ClParam = Nothing
        Me.TxTipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipoDoc.GridLin = Nothing
        Me.TxTipoDoc.HaCambiado = False
        Me.TxTipoDoc.lbbusca = Nothing
        Me.TxTipoDoc.Location = New System.Drawing.Point(234, 33)
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
        Me.BtBuscaTipoDoc.CL_BuscarEnTodosLosCampos = False
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
        Me.BtBuscaTipoDoc.Location = New System.Drawing.Point(278, 33)
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
        Me.LbTipoDoc.Location = New System.Drawing.Point(138, 36)
        Me.LbTipoDoc.Name = "LbTipoDoc"
        Me.LbTipoDoc.Size = New System.Drawing.Size(66, 16)
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
        Me.LbNom_SitCartera.Location = New System.Drawing.Point(317, 8)
        Me.LbNom_SitCartera.Name = "LbNom_SitCartera"
        Me.LbNom_SitCartera.Size = New System.Drawing.Size(204, 23)
        Me.LbNom_SitCartera.TabIndex = 100322
        Me.LbNom_SitCartera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxSitCartera
        '
        Me.TxSitCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxSitCartera.Autonumerico = False
        Me.TxSitCartera.Bloqueado = False
        Me.TxSitCartera.Buscando = False
        Me.TxSitCartera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSitCartera.ClForm = Nothing
        Me.TxSitCartera.ClParam = Nothing
        Me.TxSitCartera.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSitCartera.GridLin = Nothing
        Me.TxSitCartera.HaCambiado = False
        Me.TxSitCartera.lbbusca = Nothing
        Me.TxSitCartera.Location = New System.Drawing.Point(234, 8)
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
        Me.BtBuscaSitCartera.CL_BuscarEnTodosLosCampos = False
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
        Me.BtBuscaSitCartera.Location = New System.Drawing.Point(278, 8)
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
        Me.LbSitCartera.Location = New System.Drawing.Point(138, 10)
        Me.LbSitCartera.Name = "LbSitCartera"
        Me.LbSitCartera.Size = New System.Drawing.Size(89, 16)
        Me.LbSitCartera.TabIndex = 100319
        Me.LbSitCartera.Text = "Sit. Cartera"
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = False
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.Location = New System.Drawing.Point(214, 374)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(328, 21)
        Me.LbNomCentro.TabIndex = 224
        '
        'BtCentro
        '
        Me.BtCentro.CL_Ancho = 0
        Me.BtCentro.CL_BuscaAlb = False
        Me.BtCentro.CL_BuscarEnTodosLosCampos = False
        Me.BtCentro.CL_campocodigo = Nothing
        Me.BtCentro.CL_camponombre = Nothing
        Me.BtCentro.CL_CampoOrden = "Nombre"
        Me.BtCentro.CL_ch1000 = False
        Me.BtCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtCentro.CL_ControlAsociado = Me.TxCentro
        Me.BtCentro.CL_DevuelveCampo = "Idfamilia"
        Me.BtCentro.CL_dfecha = Nothing
        Me.BtCentro.CL_Entidad = Nothing
        Me.BtCentro.CL_EsId = True
        Me.BtCentro.CL_Filtro = Nothing
        Me.BtCentro.cl_formu = Nothing
        Me.BtCentro.CL_hfecha = Nothing
        Me.BtCentro.cl_ListaW = Nothing
        Me.BtCentro.CL_xCentro = False
        Me.BtCentro.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtCentro.Location = New System.Drawing.Point(175, 373)
        Me.BtCentro.Name = "BtCentro"
        Me.BtCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtCentro.TabIndex = 223
        Me.BtCentro.UseVisualStyleBackColor = True
        '
        'TxCentro
        '
        Me.TxCentro.Autonumerico = False
        Me.TxCentro.Bloqueado = False
        Me.TxCentro.Buscando = False
        Me.TxCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentro.ClForm = Nothing
        Me.TxCentro.ClParam = Nothing
        Me.TxCentro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCentro.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentro.GridLin = Nothing
        Me.TxCentro.HaCambiado = False
        Me.TxCentro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCentro.lbbusca = Nothing
        Me.TxCentro.Location = New System.Drawing.Point(105, 373)
        Me.TxCentro.MiError = False
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.Orden = 0
        Me.TxCentro.SaltoAlfinal = False
        Me.TxCentro.Siguiente = 0
        Me.TxCentro.Size = New System.Drawing.Size(64, 22)
        Me.TxCentro.TabIndex = 222
        Me.TxCentro.TeclaRepetida = False
        Me.TxCentro.TxDatoFinalSemana = Nothing
        Me.TxCentro.TxDatoInicioSemana = Nothing
        Me.TxCentro.UltimoValorValidado = Nothing
        '
        'LbCentro
        '
        Me.LbCentro.AutoSize = True
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = False
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(9, 376)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(56, 16)
        Me.LbCentro.TabIndex = 221
        Me.LbCentro.Text = "Centro"
        '
        'LbNomBanco
        '
        Me.LbNomBanco.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomBanco.CL_ControlAsociado = Nothing
        Me.LbNomBanco.CL_ValorFijo = False
        Me.LbNomBanco.ClForm = Nothing
        Me.LbNomBanco.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomBanco.Location = New System.Drawing.Point(732, 353)
        Me.LbNomBanco.Name = "LbNomBanco"
        Me.LbNomBanco.Size = New System.Drawing.Size(234, 21)
        Me.LbNomBanco.TabIndex = 220
        '
        'BtBanco
        '
        Me.BtBanco.CL_Ancho = 0
        Me.BtBanco.CL_BuscaAlb = False
        Me.BtBanco.CL_BuscarEnTodosLosCampos = False
        Me.BtBanco.CL_campocodigo = Nothing
        Me.BtBanco.CL_camponombre = Nothing
        Me.BtBanco.CL_CampoOrden = "Nombre"
        Me.BtBanco.CL_ch1000 = False
        Me.BtBanco.CL_ConsultaSql = "Select * from familias"
        Me.BtBanco.CL_ControlAsociado = Me.TxBanco
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
        Me.BtBanco.Location = New System.Drawing.Point(693, 353)
        Me.BtBanco.Name = "BtBanco"
        Me.BtBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBanco.TabIndex = 219
        Me.BtBanco.UseVisualStyleBackColor = True
        '
        'TxBanco
        '
        Me.TxBanco.Autonumerico = False
        Me.TxBanco.Bloqueado = False
        Me.TxBanco.Buscando = False
        Me.TxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBanco.ClForm = Nothing
        Me.TxBanco.ClParam = Nothing
        Me.TxBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBanco.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(653, 353)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(34, 22)
        Me.TxBanco.TabIndex = 218
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = False
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(559, 356)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(52, 16)
        Me.LbBanco.TabIndex = 217
        Me.LbBanco.Text = "Banco"
        '
        'LbSerie
        '
        Me.LbSerie.AutoSize = True
        Me.LbSerie.CL_ControlAsociado = Nothing
        Me.LbSerie.CL_ValorFijo = False
        Me.LbSerie.ClForm = Nothing
        Me.LbSerie.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSerie.ForeColor = System.Drawing.Color.Teal
        Me.LbSerie.Location = New System.Drawing.Point(414, 141)
        Me.LbSerie.Name = "LbSerie"
        Me.LbSerie.Size = New System.Drawing.Size(44, 16)
        Me.LbSerie.TabIndex = 215
        Me.LbSerie.Text = "Serie"
        '
        'TxSerie
        '
        Me.TxSerie.Autonumerico = False
        Me.TxSerie.Bloqueado = False
        Me.TxSerie.Buscando = False
        Me.TxSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSerie.ClForm = Nothing
        Me.TxSerie.ClParam = Nothing
        Me.TxSerie.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSerie.GridLin = Nothing
        Me.TxSerie.HaCambiado = False
        Me.TxSerie.lbbusca = Nothing
        Me.TxSerie.Location = New System.Drawing.Point(465, 138)
        Me.TxSerie.MaxLength = 5
        Me.TxSerie.MiError = False
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Orden = 0
        Me.TxSerie.SaltoAlfinal = False
        Me.TxSerie.Siguiente = 0
        Me.TxSerie.Size = New System.Drawing.Size(95, 22)
        Me.TxSerie.TabIndex = 214
        Me.TxSerie.TeclaRepetida = False
        Me.TxSerie.TxDatoFinalSemana = Nothing
        Me.TxSerie.TxDatoInicioSemana = Nothing
        Me.TxSerie.UltimoValorValidado = Nothing
        '
        'LbAltaopfh
        '
        Me.LbAltaopfh.AutoSize = True
        Me.LbAltaopfh.CL_ControlAsociado = Nothing
        Me.LbAltaopfh.CL_ValorFijo = False
        Me.LbAltaopfh.ClForm = Nothing
        Me.LbAltaopfh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAltaopfh.ForeColor = System.Drawing.Color.Teal
        Me.LbAltaopfh.Location = New System.Drawing.Point(559, 327)
        Me.LbAltaopfh.Name = "LbAltaopfh"
        Me.LbAltaopfh.Size = New System.Drawing.Size(80, 16)
        Me.LbAltaopfh.TabIndex = 213
        Me.LbAltaopfh.Text = "Alta OPFH"
        '
        'TxAltaOpFH
        '
        Me.TxAltaOpFH.Autonumerico = False
        Me.TxAltaOpFH.Bloqueado = False
        Me.TxAltaOpFH.Buscando = False
        Me.TxAltaOpFH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAltaOpFH.ClForm = Nothing
        Me.TxAltaOpFH.ClParam = Nothing
        Me.TxAltaOpFH.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAltaOpFH.GridLin = Nothing
        Me.TxAltaOpFH.HaCambiado = False
        Me.TxAltaOpFH.lbbusca = Nothing
        Me.TxAltaOpFH.Location = New System.Drawing.Point(653, 325)
        Me.TxAltaOpFH.MiError = False
        Me.TxAltaOpFH.Name = "TxAltaOpFH"
        Me.TxAltaOpFH.Orden = 0
        Me.TxAltaOpFH.SaltoAlfinal = False
        Me.TxAltaOpFH.Siguiente = 0
        Me.TxAltaOpFH.Size = New System.Drawing.Size(117, 22)
        Me.TxAltaOpFH.TabIndex = 212
        Me.TxAltaOpFH.TeclaRepetida = False
        Me.TxAltaOpFH.TxDatoFinalSemana = Nothing
        Me.TxAltaOpFH.TxDatoInicioSemana = Nothing
        Me.TxAltaOpFH.UltimoValorValidado = Nothing
        '
        'LbNomCrecogida
        '
        Me.LbNomCrecogida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCrecogida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCrecogida.CL_ControlAsociado = Nothing
        Me.LbNomCrecogida.CL_ValorFijo = False
        Me.LbNomCrecogida.ClForm = Nothing
        Me.LbNomCrecogida.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCrecogida.Location = New System.Drawing.Point(214, 348)
        Me.LbNomCrecogida.Name = "LbNomCrecogida"
        Me.LbNomCrecogida.Size = New System.Drawing.Size(328, 21)
        Me.LbNomCrecogida.TabIndex = 211
        '
        'BtBuscaCRecogida
        '
        Me.BtBuscaCRecogida.CL_Ancho = 0
        Me.BtBuscaCRecogida.CL_BuscaAlb = False
        Me.BtBuscaCRecogida.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaCRecogida.CL_campocodigo = Nothing
        Me.BtBuscaCRecogida.CL_camponombre = Nothing
        Me.BtBuscaCRecogida.CL_CampoOrden = "Nombre"
        Me.BtBuscaCRecogida.CL_ch1000 = False
        Me.BtBuscaCRecogida.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCRecogida.CL_ControlAsociado = Me.TxCrecogida
        Me.BtBuscaCRecogida.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCRecogida.CL_dfecha = Nothing
        Me.BtBuscaCRecogida.CL_Entidad = Nothing
        Me.BtBuscaCRecogida.CL_EsId = True
        Me.BtBuscaCRecogida.CL_Filtro = Nothing
        Me.BtBuscaCRecogida.cl_formu = Nothing
        Me.BtBuscaCRecogida.CL_hfecha = Nothing
        Me.BtBuscaCRecogida.cl_ListaW = Nothing
        Me.BtBuscaCRecogida.CL_xCentro = False
        Me.BtBuscaCRecogida.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCRecogida.Location = New System.Drawing.Point(175, 347)
        Me.BtBuscaCRecogida.Name = "BtBuscaCRecogida"
        Me.BtBuscaCRecogida.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCRecogida.TabIndex = 210
        Me.BtBuscaCRecogida.UseVisualStyleBackColor = True
        '
        'TxCrecogida
        '
        Me.TxCrecogida.Autonumerico = False
        Me.TxCrecogida.Bloqueado = False
        Me.TxCrecogida.Buscando = False
        Me.TxCrecogida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCrecogida.ClForm = Nothing
        Me.TxCrecogida.ClParam = Nothing
        Me.TxCrecogida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCrecogida.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCrecogida.GridLin = Nothing
        Me.TxCrecogida.HaCambiado = False
        Me.TxCrecogida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCrecogida.lbbusca = Nothing
        Me.TxCrecogida.Location = New System.Drawing.Point(105, 347)
        Me.TxCrecogida.MiError = False
        Me.TxCrecogida.Name = "TxCrecogida"
        Me.TxCrecogida.Orden = 0
        Me.TxCrecogida.SaltoAlfinal = False
        Me.TxCrecogida.Siguiente = 0
        Me.TxCrecogida.Size = New System.Drawing.Size(64, 22)
        Me.TxCrecogida.TabIndex = 209
        Me.TxCrecogida.TeclaRepetida = False
        Me.TxCrecogida.TxDatoFinalSemana = Nothing
        Me.TxCrecogida.TxDatoInicioSemana = Nothing
        Me.TxCrecogida.UltimoValorValidado = Nothing
        '
        'LbCrecogida
        '
        Me.LbCrecogida.AutoSize = True
        Me.LbCrecogida.CL_ControlAsociado = Nothing
        Me.LbCrecogida.CL_ValorFijo = False
        Me.LbCrecogida.ClForm = Nothing
        Me.LbCrecogida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCrecogida.ForeColor = System.Drawing.Color.Teal
        Me.LbCrecogida.Location = New System.Drawing.Point(9, 350)
        Me.LbCrecogida.Name = "LbCrecogida"
        Me.LbCrecogida.Size = New System.Drawing.Size(88, 16)
        Me.LbCrecogida.TabIndex = 208
        Me.LbCrecogida.Text = "C.Recogida"
        '
        'LbNomEmpresa
        '
        Me.LbNomEmpresa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomEmpresa.CL_ControlAsociado = Nothing
        Me.LbNomEmpresa.CL_ValorFijo = False
        Me.LbNomEmpresa.ClForm = Nothing
        Me.LbNomEmpresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEmpresa.Location = New System.Drawing.Point(214, 323)
        Me.LbNomEmpresa.Name = "LbNomEmpresa"
        Me.LbNomEmpresa.Size = New System.Drawing.Size(328, 21)
        Me.LbNomEmpresa.TabIndex = 207
        '
        'BtBuscaEmpresa
        '
        Me.BtBuscaEmpresa.CL_Ancho = 0
        Me.BtBuscaEmpresa.CL_BuscaAlb = False
        Me.BtBuscaEmpresa.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaEmpresa.CL_campocodigo = Nothing
        Me.BtBuscaEmpresa.CL_camponombre = Nothing
        Me.BtBuscaEmpresa.CL_CampoOrden = "Nombre"
        Me.BtBuscaEmpresa.CL_ch1000 = False
        Me.BtBuscaEmpresa.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaEmpresa.CL_ControlAsociado = Me.TxEmpresa
        Me.BtBuscaEmpresa.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaEmpresa.CL_dfecha = Nothing
        Me.BtBuscaEmpresa.CL_Entidad = Nothing
        Me.BtBuscaEmpresa.CL_EsId = True
        Me.BtBuscaEmpresa.CL_Filtro = Nothing
        Me.BtBuscaEmpresa.cl_formu = Nothing
        Me.BtBuscaEmpresa.CL_hfecha = Nothing
        Me.BtBuscaEmpresa.cl_ListaW = Nothing
        Me.BtBuscaEmpresa.CL_xCentro = False
        Me.BtBuscaEmpresa.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaEmpresa.Location = New System.Drawing.Point(175, 322)
        Me.BtBuscaEmpresa.Name = "BtBuscaEmpresa"
        Me.BtBuscaEmpresa.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaEmpresa.TabIndex = 206
        Me.BtBuscaEmpresa.UseVisualStyleBackColor = True
        '
        'TxEmpresa
        '
        Me.TxEmpresa.Autonumerico = False
        Me.TxEmpresa.Bloqueado = False
        Me.TxEmpresa.Buscando = False
        Me.TxEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmpresa.ClForm = Nothing
        Me.TxEmpresa.ClParam = Nothing
        Me.TxEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEmpresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmpresa.GridLin = Nothing
        Me.TxEmpresa.HaCambiado = False
        Me.TxEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEmpresa.lbbusca = Nothing
        Me.TxEmpresa.Location = New System.Drawing.Point(105, 322)
        Me.TxEmpresa.MiError = False
        Me.TxEmpresa.Name = "TxEmpresa"
        Me.TxEmpresa.Orden = 0
        Me.TxEmpresa.SaltoAlfinal = False
        Me.TxEmpresa.Siguiente = 0
        Me.TxEmpresa.Size = New System.Drawing.Size(64, 22)
        Me.TxEmpresa.TabIndex = 205
        Me.TxEmpresa.TeclaRepetida = False
        Me.TxEmpresa.TxDatoFinalSemana = Nothing
        Me.TxEmpresa.TxDatoInicioSemana = Nothing
        Me.TxEmpresa.UltimoValorValidado = Nothing
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = False
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(9, 325)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(71, 16)
        Me.LbEmpresa.TabIndex = 204
        Me.LbEmpresa.Text = "Empresa"
        '
        'LbNomCenvases
        '
        Me.LbNomCenvases.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCenvases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCenvases.CL_ControlAsociado = Nothing
        Me.LbNomCenvases.CL_ValorFijo = False
        Me.LbNomCenvases.ClForm = Nothing
        Me.LbNomCenvases.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCenvases.Location = New System.Drawing.Point(214, 298)
        Me.LbNomCenvases.Name = "LbNomCenvases"
        Me.LbNomCenvases.Size = New System.Drawing.Size(328, 21)
        Me.LbNomCenvases.TabIndex = 203
        '
        'BtBuscaCenvases
        '
        Me.BtBuscaCenvases.CL_Ancho = 0
        Me.BtBuscaCenvases.CL_BuscaAlb = False
        Me.BtBuscaCenvases.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaCenvases.CL_campocodigo = Nothing
        Me.BtBuscaCenvases.CL_camponombre = Nothing
        Me.BtBuscaCenvases.CL_CampoOrden = "Nombre"
        Me.BtBuscaCenvases.CL_ch1000 = False
        Me.BtBuscaCenvases.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCenvases.CL_ControlAsociado = Me.TxCenvases
        Me.BtBuscaCenvases.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCenvases.CL_dfecha = Nothing
        Me.BtBuscaCenvases.CL_Entidad = Nothing
        Me.BtBuscaCenvases.CL_EsId = True
        Me.BtBuscaCenvases.CL_Filtro = Nothing
        Me.BtBuscaCenvases.cl_formu = Nothing
        Me.BtBuscaCenvases.CL_hfecha = Nothing
        Me.BtBuscaCenvases.cl_ListaW = Nothing
        Me.BtBuscaCenvases.CL_xCentro = False
        Me.BtBuscaCenvases.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCenvases.Location = New System.Drawing.Point(175, 297)
        Me.BtBuscaCenvases.Name = "BtBuscaCenvases"
        Me.BtBuscaCenvases.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCenvases.TabIndex = 202
        Me.BtBuscaCenvases.UseVisualStyleBackColor = True
        '
        'TxCenvases
        '
        Me.TxCenvases.Autonumerico = False
        Me.TxCenvases.Bloqueado = False
        Me.TxCenvases.Buscando = False
        Me.TxCenvases.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCenvases.ClForm = Nothing
        Me.TxCenvases.ClParam = Nothing
        Me.TxCenvases.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCenvases.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCenvases.GridLin = Nothing
        Me.TxCenvases.HaCambiado = False
        Me.TxCenvases.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCenvases.lbbusca = Nothing
        Me.TxCenvases.Location = New System.Drawing.Point(105, 297)
        Me.TxCenvases.MiError = False
        Me.TxCenvases.Name = "TxCenvases"
        Me.TxCenvases.Orden = 0
        Me.TxCenvases.SaltoAlfinal = False
        Me.TxCenvases.Siguiente = 0
        Me.TxCenvases.Size = New System.Drawing.Size(64, 22)
        Me.TxCenvases.TabIndex = 201
        Me.TxCenvases.TeclaRepetida = False
        Me.TxCenvases.TxDatoFinalSemana = Nothing
        Me.TxCenvases.TxDatoInicioSemana = Nothing
        Me.TxCenvases.UltimoValorValidado = Nothing
        '
        'LbCenvases
        '
        Me.LbCenvases.AutoSize = True
        Me.LbCenvases.CL_ControlAsociado = Nothing
        Me.LbCenvases.CL_ValorFijo = False
        Me.LbCenvases.ClForm = Nothing
        Me.LbCenvases.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCenvases.ForeColor = System.Drawing.Color.Teal
        Me.LbCenvases.Location = New System.Drawing.Point(9, 300)
        Me.LbCenvases.Name = "LbCenvases"
        Me.LbCenvases.Size = New System.Drawing.Size(83, 16)
        Me.LbCenvases.TabIndex = 200
        Me.LbCenvases.Text = "C.Envases"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(698, 141)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(252, 16)
        Me.Lb3.TabIndex = 199
        Me.Lb3.Text = "* Firme-Comision-S/Clasificacion"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Bloqueado = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(666, 138)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(23, 22)
        Me.TxDato1.TabIndex = 198
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
        Me.Lb2.Location = New System.Drawing.Point(603, 141)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(53, 16)
        Me.Lb2.TabIndex = 197
        Me.Lb2.Text = "F/C/S"
        '
        'TxMensaje
        '
        Me.TxMensaje.Autonumerico = False
        Me.TxMensaje.Bloqueado = False
        Me.TxMensaje.Buscando = False
        Me.TxMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMensaje.ClForm = Nothing
        Me.TxMensaje.ClParam = Nothing
        Me.TxMensaje.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMensaje.GridLin = Nothing
        Me.TxMensaje.HaCambiado = False
        Me.TxMensaje.lbbusca = Nothing
        Me.TxMensaje.Location = New System.Drawing.Point(591, 217)
        Me.TxMensaje.MiError = False
        Me.TxMensaje.Multiline = True
        Me.TxMensaje.Name = "TxMensaje"
        Me.TxMensaje.Orden = 0
        Me.TxMensaje.SaltoAlfinal = False
        Me.TxMensaje.Siguiente = 0
        Me.TxMensaje.Size = New System.Drawing.Size(340, 46)
        Me.TxMensaje.TabIndex = 196
        Me.TxMensaje.TeclaRepetida = False
        Me.TxMensaje.TxDatoFinalSemana = Nothing
        Me.TxMensaje.TxDatoInicioSemana = Nothing
        Me.TxMensaje.UltimoValorValidado = Nothing
        '
        'ChkMostrarMensaje
        '
        Me.ChkMostrarMensaje.AutoSize = True
        Me.ChkMostrarMensaje.Campobd = Nothing
        Me.ChkMostrarMensaje.ClForm = Nothing
        Me.ChkMostrarMensaje.Enabled = False
        Me.ChkMostrarMensaje.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMostrarMensaje.ForeColor = System.Drawing.Color.Teal
        Me.ChkMostrarMensaje.GridLin = Nothing
        Me.ChkMostrarMensaje.HaCambiado = False
        Me.ChkMostrarMensaje.Location = New System.Drawing.Point(443, 242)
        Me.ChkMostrarMensaje.MiEntidad = Nothing
        Me.ChkMostrarMensaje.MiError = False
        Me.ChkMostrarMensaje.Name = "ChkMostrarMensaje"
        Me.ChkMostrarMensaje.Orden = 0
        Me.ChkMostrarMensaje.SaltoAlfinal = False
        Me.ChkMostrarMensaje.Size = New System.Drawing.Size(149, 20)
        Me.ChkMostrarMensaje.TabIndex = 195
        Me.ChkMostrarMensaje.Text = "Mostrar mensaje"
        Me.ChkMostrarMensaje.UseVisualStyleBackColor = True
        Me.ChkMostrarMensaje.ValorCampoFalse = Nothing
        Me.ChkMostrarMensaje.ValorCampoTrue = Nothing
        Me.ChkMostrarMensaje.ValorDefecto = False
        '
        'ChkBloqueoPagos
        '
        Me.ChkBloqueoPagos.AutoSize = True
        Me.ChkBloqueoPagos.Campobd = Nothing
        Me.ChkBloqueoPagos.ClForm = Nothing
        Me.ChkBloqueoPagos.Enabled = False
        Me.ChkBloqueoPagos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBloqueoPagos.ForeColor = System.Drawing.Color.Teal
        Me.ChkBloqueoPagos.GridLin = Nothing
        Me.ChkBloqueoPagos.HaCambiado = False
        Me.ChkBloqueoPagos.Location = New System.Drawing.Point(443, 217)
        Me.ChkBloqueoPagos.MiEntidad = Nothing
        Me.ChkBloqueoPagos.MiError = False
        Me.ChkBloqueoPagos.Name = "ChkBloqueoPagos"
        Me.ChkBloqueoPagos.Orden = 0
        Me.ChkBloqueoPagos.SaltoAlfinal = False
        Me.ChkBloqueoPagos.Size = New System.Drawing.Size(133, 20)
        Me.ChkBloqueoPagos.TabIndex = 194
        Me.ChkBloqueoPagos.Text = "Bloqueo pagos"
        Me.ChkBloqueoPagos.UseVisualStyleBackColor = True
        Me.ChkBloqueoPagos.ValorCampoFalse = Nothing
        Me.ChkBloqueoPagos.ValorCampoTrue = Nothing
        Me.ChkBloqueoPagos.ValorDefecto = False
        '
        'Lb_25
        '
        Me.Lb_25.AutoSize = True
        Me.Lb_25.CL_ControlAsociado = Nothing
        Me.Lb_25.CL_ValorFijo = False
        Me.Lb_25.ClForm = Nothing
        Me.Lb_25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_25.ForeColor = System.Drawing.Color.Teal
        Me.Lb_25.Location = New System.Drawing.Point(726, 65)
        Me.Lb_25.Name = "Lb_25"
        Me.Lb_25.Size = New System.Drawing.Size(84, 16)
        Me.Lb_25.TabIndex = 191
        Me.Lb_25.Text = "Fecha Alta"
        '
        'TxDato_25
        '
        Me.TxDato_25.Autonumerico = False
        Me.TxDato_25.Bloqueado = False
        Me.TxDato_25.Buscando = False
        Me.TxDato_25.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_25.ClForm = Nothing
        Me.TxDato_25.ClParam = Nothing
        Me.TxDato_25.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_25.GridLin = Nothing
        Me.TxDato_25.HaCambiado = False
        Me.TxDato_25.lbbusca = Nothing
        Me.TxDato_25.Location = New System.Drawing.Point(814, 62)
        Me.TxDato_25.MiError = False
        Me.TxDato_25.Name = "TxDato_25"
        Me.TxDato_25.Orden = 0
        Me.TxDato_25.SaltoAlfinal = False
        Me.TxDato_25.Siguiente = 0
        Me.TxDato_25.Size = New System.Drawing.Size(117, 22)
        Me.TxDato_25.TabIndex = 190
        Me.TxDato_25.TeclaRepetida = False
        Me.TxDato_25.TxDatoFinalSemana = Nothing
        Me.TxDato_25.TxDatoInicioSemana = Nothing
        Me.TxDato_25.UltimoValorValidado = Nothing
        '
        'TxDato_26
        '
        Me.TxDato_26.Autonumerico = False
        Me.TxDato_26.Bloqueado = False
        Me.TxDato_26.Buscando = False
        Me.TxDato_26.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_26.ClForm = Nothing
        Me.TxDato_26.ClParam = Nothing
        Me.TxDato_26.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_26.GridLin = Nothing
        Me.TxDato_26.HaCambiado = False
        Me.TxDato_26.lbbusca = Nothing
        Me.TxDato_26.Location = New System.Drawing.Point(653, 297)
        Me.TxDato_26.MiError = False
        Me.TxDato_26.Name = "TxDato_26"
        Me.TxDato_26.Orden = 0
        Me.TxDato_26.SaltoAlfinal = False
        Me.TxDato_26.Siguiente = 0
        Me.TxDato_26.Size = New System.Drawing.Size(299, 22)
        Me.TxDato_26.TabIndex = 189
        Me.TxDato_26.TeclaRepetida = False
        Me.TxDato_26.TxDatoFinalSemana = Nothing
        Me.TxDato_26.TxDatoInicioSemana = Nothing
        Me.TxDato_26.UltimoValorValidado = Nothing
        '
        'Lb_26
        '
        Me.Lb_26.AutoSize = True
        Me.Lb_26.CL_ControlAsociado = Nothing
        Me.Lb_26.CL_ValorFijo = False
        Me.Lb_26.ClForm = Nothing
        Me.Lb_26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_26.ForeColor = System.Drawing.Color.Teal
        Me.Lb_26.Location = New System.Drawing.Point(559, 300)
        Me.Lb_26.Name = "Lb_26"
        Me.Lb_26.Size = New System.Drawing.Size(47, 16)
        Me.Lb_26.TabIndex = 188
        Me.Lb_26.Text = "Email"
        '
        'TxDato_24
        '
        Me.TxDato_24.Autonumerico = False
        Me.TxDato_24.Bloqueado = False
        Me.TxDato_24.Buscando = False
        Me.TxDato_24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_24.ClForm = Nothing
        Me.TxDato_24.ClParam = Nothing
        Me.TxDato_24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_24.GridLin = Nothing
        Me.TxDato_24.HaCambiado = False
        Me.TxDato_24.lbbusca = Nothing
        Me.TxDato_24.Location = New System.Drawing.Point(814, 88)
        Me.TxDato_24.MiError = False
        Me.TxDato_24.Name = "TxDato_24"
        Me.TxDato_24.Orden = 0
        Me.TxDato_24.SaltoAlfinal = False
        Me.TxDato_24.Siguiente = 0
        Me.TxDato_24.Size = New System.Drawing.Size(117, 22)
        Me.TxDato_24.TabIndex = 186
        Me.TxDato_24.TeclaRepetida = False
        Me.TxDato_24.TxDatoFinalSemana = Nothing
        Me.TxDato_24.TxDatoInicioSemana = Nothing
        Me.TxDato_24.UltimoValorValidado = Nothing
        '
        'Lb_24
        '
        Me.Lb_24.AutoSize = True
        Me.Lb_24.CL_ControlAsociado = Nothing
        Me.Lb_24.CL_ValorFijo = False
        Me.Lb_24.ClForm = Nothing
        Me.Lb_24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_24.ForeColor = System.Drawing.Color.Teal
        Me.Lb_24.Location = New System.Drawing.Point(726, 91)
        Me.Lb_24.Name = "Lb_24"
        Me.Lb_24.Size = New System.Drawing.Size(77, 16)
        Me.Lb_24.TabIndex = 185
        Me.Lb_24.Text = "Tel. movil"
        '
        'TxDato_23
        '
        Me.TxDato_23.Autonumerico = False
        Me.TxDato_23.Bloqueado = False
        Me.TxDato_23.Buscando = False
        Me.TxDato_23.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_23.ClForm = Nothing
        Me.TxDato_23.ClParam = Nothing
        Me.TxDato_23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_23.GridLin = Nothing
        Me.TxDato_23.HaCambiado = False
        Me.TxDato_23.lbbusca = Nothing
        Me.TxDato_23.Location = New System.Drawing.Point(570, 88)
        Me.TxDato_23.MiError = False
        Me.TxDato_23.Name = "TxDato_23"
        Me.TxDato_23.Orden = 0
        Me.TxDato_23.SaltoAlfinal = False
        Me.TxDato_23.Siguiente = 0
        Me.TxDato_23.Size = New System.Drawing.Size(117, 22)
        Me.TxDato_23.TabIndex = 184
        Me.TxDato_23.TeclaRepetida = False
        Me.TxDato_23.TxDatoFinalSemana = Nothing
        Me.TxDato_23.TxDatoInicioSemana = Nothing
        Me.TxDato_23.UltimoValorValidado = Nothing
        '
        'Lb_23
        '
        Me.Lb_23.AutoSize = True
        Me.Lb_23.CL_ControlAsociado = Nothing
        Me.Lb_23.CL_ValorFijo = False
        Me.Lb_23.ClForm = Nothing
        Me.Lb_23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_23.ForeColor = System.Drawing.Color.Teal
        Me.Lb_23.Location = New System.Drawing.Point(464, 91)
        Me.Lb_23.Name = "Lb_23"
        Me.Lb_23.Size = New System.Drawing.Size(96, 16)
        Me.Lb_23.TabIndex = 183
        Me.Lb_23.Text = "Telefono fijo"
        '
        'Lbret
        '
        Me.Lbret.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbret.CL_ControlAsociado = Nothing
        Me.Lbret.CL_ValorFijo = False
        Me.Lbret.ClForm = Nothing
        Me.Lbret.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbret.Location = New System.Drawing.Point(272, 139)
        Me.Lbret.Name = "Lbret"
        Me.Lbret.Size = New System.Drawing.Size(74, 21)
        Me.Lbret.TabIndex = 178
        Me.Lbret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb42
        '
        Me.Lb42.AutoSize = True
        Me.Lb42.CL_ControlAsociado = Nothing
        Me.Lb42.CL_ValorFijo = True
        Me.Lb42.ClForm = Nothing
        Me.Lb42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb42.ForeColor = System.Drawing.Color.Teal
        Me.Lb42.Location = New System.Drawing.Point(211, 141)
        Me.Lb42.Name = "Lb42"
        Me.Lb42.Size = New System.Drawing.Size(54, 16)
        Me.Lb42.TabIndex = 177
        Me.Lb42.Text = "% RET"
        '
        'Lbiva
        '
        Me.Lbiva.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbiva.CL_ControlAsociado = Nothing
        Me.Lbiva.CL_ValorFijo = False
        Me.Lbiva.ClForm = Nothing
        Me.Lbiva.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiva.Location = New System.Drawing.Point(105, 139)
        Me.Lbiva.Name = "Lbiva"
        Me.Lbiva.Size = New System.Drawing.Size(74, 21)
        Me.Lbiva.TabIndex = 176
        Me.Lbiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb40
        '
        Me.Lb40.AutoSize = True
        Me.Lb40.CL_ControlAsociado = Nothing
        Me.Lb40.CL_ValorFijo = True
        Me.Lb40.ClForm = Nothing
        Me.Lb40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb40.ForeColor = System.Drawing.Color.Teal
        Me.Lb40.Location = New System.Drawing.Point(9, 141)
        Me.Lb40.Name = "Lb40"
        Me.Lb40.Size = New System.Drawing.Size(54, 16)
        Me.Lb40.TabIndex = 175
        Me.Lb40.Text = "% IVA"
        '
        'LbNom_14
        '
        Me.LbNom_14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_14.CL_ControlAsociado = Nothing
        Me.LbNom_14.CL_ValorFijo = False
        Me.LbNom_14.ClForm = Nothing
        Me.LbNom_14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_14.Location = New System.Drawing.Point(214, 274)
        Me.LbNom_14.Name = "LbNom_14"
        Me.LbNom_14.Size = New System.Drawing.Size(328, 21)
        Me.LbNom_14.TabIndex = 148
        '
        'BtBuscaPrinci
        '
        Me.BtBuscaPrinci.CL_Ancho = 0
        Me.BtBuscaPrinci.CL_BuscaAlb = False
        Me.BtBuscaPrinci.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaPrinci.CL_campocodigo = Nothing
        Me.BtBuscaPrinci.CL_camponombre = Nothing
        Me.BtBuscaPrinci.CL_CampoOrden = "Nombre"
        Me.BtBuscaPrinci.CL_ch1000 = False
        Me.BtBuscaPrinci.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaPrinci.CL_ControlAsociado = Me.TxDato_14
        Me.BtBuscaPrinci.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaPrinci.CL_dfecha = Nothing
        Me.BtBuscaPrinci.CL_Entidad = Nothing
        Me.BtBuscaPrinci.CL_EsId = True
        Me.BtBuscaPrinci.CL_Filtro = Nothing
        Me.BtBuscaPrinci.cl_formu = Nothing
        Me.BtBuscaPrinci.CL_hfecha = Nothing
        Me.BtBuscaPrinci.cl_ListaW = Nothing
        Me.BtBuscaPrinci.CL_xCentro = False
        Me.BtBuscaPrinci.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaPrinci.Location = New System.Drawing.Point(175, 273)
        Me.BtBuscaPrinci.Name = "BtBuscaPrinci"
        Me.BtBuscaPrinci.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaPrinci.TabIndex = 147
        Me.BtBuscaPrinci.UseVisualStyleBackColor = True
        '
        'TxDato_14
        '
        Me.TxDato_14.Autonumerico = False
        Me.TxDato_14.Bloqueado = False
        Me.TxDato_14.Buscando = False
        Me.TxDato_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_14.ClForm = Nothing
        Me.TxDato_14.ClParam = Nothing
        Me.TxDato_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_14.GridLin = Nothing
        Me.TxDato_14.HaCambiado = False
        Me.TxDato_14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_14.lbbusca = Nothing
        Me.TxDato_14.Location = New System.Drawing.Point(105, 273)
        Me.TxDato_14.MiError = False
        Me.TxDato_14.Name = "TxDato_14"
        Me.TxDato_14.Orden = 0
        Me.TxDato_14.SaltoAlfinal = False
        Me.TxDato_14.Siguiente = 0
        Me.TxDato_14.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_14.TabIndex = 146
        Me.TxDato_14.TeclaRepetida = False
        Me.TxDato_14.TxDatoFinalSemana = Nothing
        Me.TxDato_14.TxDatoInicioSemana = Nothing
        Me.TxDato_14.UltimoValorValidado = Nothing
        '
        'Lb_14
        '
        Me.Lb_14.AutoSize = True
        Me.Lb_14.CL_ControlAsociado = Nothing
        Me.Lb_14.CL_ValorFijo = False
        Me.Lb_14.ClForm = Nothing
        Me.Lb_14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_14.ForeColor = System.Drawing.Color.Teal
        Me.Lb_14.Location = New System.Drawing.Point(9, 276)
        Me.Lb_14.Name = "Lb_14"
        Me.Lb_14.Size = New System.Drawing.Size(84, 16)
        Me.Lb_14.TabIndex = 145
        Me.Lb_14.Text = "C.Principal"
        '
        'TxDato_12
        '
        Me.TxDato_12.Autonumerico = False
        Me.TxDato_12.Bloqueado = False
        Me.TxDato_12.Buscando = False
        Me.TxDato_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_12.ClForm = Nothing
        Me.TxDato_12.ClParam = Nothing
        Me.TxDato_12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_12.GridLin = Nothing
        Me.TxDato_12.HaCambiado = False
        Me.TxDato_12.lbbusca = Nothing
        Me.TxDato_12.Location = New System.Drawing.Point(13, 241)
        Me.TxDato_12.MiError = False
        Me.TxDato_12.Name = "TxDato_12"
        Me.TxDato_12.Orden = 0
        Me.TxDato_12.SaltoAlfinal = False
        Me.TxDato_12.Siguiente = 0
        Me.TxDato_12.Size = New System.Drawing.Size(403, 22)
        Me.TxDato_12.TabIndex = 138
        Me.TxDato_12.TeclaRepetida = False
        Me.TxDato_12.TxDatoFinalSemana = Nothing
        Me.TxDato_12.TxDatoInicioSemana = Nothing
        Me.TxDato_12.UltimoValorValidado = Nothing
        '
        'Lb_11
        '
        Me.Lb_11.AutoSize = True
        Me.Lb_11.CL_ControlAsociado = Nothing
        Me.Lb_11.CL_ValorFijo = False
        Me.Lb_11.ClForm = Nothing
        Me.Lb_11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_11.ForeColor = System.Drawing.Color.Teal
        Me.Lb_11.Location = New System.Drawing.Point(119, 195)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(113, 16)
        Me.Lb_11.TabIndex = 137
        Me.Lb_11.Text = "Texto Mensaje"
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Bloqueado = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(13, 217)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(403, 22)
        Me.TxDato_11.TabIndex = 136
        Me.TxDato_11.TeclaRepetida = False
        Me.TxDato_11.TxDatoFinalSemana = Nothing
        Me.TxDato_11.TxDatoInicioSemana = Nothing
        Me.TxDato_11.UltimoValorValidado = Nothing
        '
        'ChBloqueo
        '
        Me.ChBloqueo.AutoSize = True
        Me.ChBloqueo.Campobd = Nothing
        Me.ChBloqueo.ClForm = Nothing
        Me.ChBloqueo.Enabled = False
        Me.ChBloqueo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBloqueo.ForeColor = System.Drawing.Color.Teal
        Me.ChBloqueo.GridLin = Nothing
        Me.ChBloqueo.HaCambiado = False
        Me.ChBloqueo.Location = New System.Drawing.Point(13, 194)
        Me.ChBloqueo.MiEntidad = Nothing
        Me.ChBloqueo.MiError = False
        Me.ChBloqueo.Name = "ChBloqueo"
        Me.ChBloqueo.Orden = 0
        Me.ChBloqueo.SaltoAlfinal = False
        Me.ChBloqueo.Size = New System.Drawing.Size(103, 20)
        Me.ChBloqueo.TabIndex = 135
        Me.ChBloqueo.Text = "Bloqueado"
        Me.ChBloqueo.UseVisualStyleBackColor = True
        Me.ChBloqueo.ValorCampoFalse = Nothing
        Me.ChBloqueo.ValorCampoTrue = Nothing
        Me.ChBloqueo.ValorDefecto = False
        '
        'Lbnom_10
        '
        Me.Lbnom_10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_10.CL_ControlAsociado = Nothing
        Me.Lbnom_10.CL_ValorFijo = False
        Me.Lbnom_10.ClForm = Nothing
        Me.Lbnom_10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_10.Location = New System.Drawing.Point(214, 114)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(539, 21)
        Me.Lbnom_10.TabIndex = 134
        '
        'BtBuscaTipoProv
        '
        Me.BtBuscaTipoProv.CL_Ancho = 0
        Me.BtBuscaTipoProv.CL_BuscaAlb = False
        Me.BtBuscaTipoProv.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaTipoProv.CL_campocodigo = Nothing
        Me.BtBuscaTipoProv.CL_camponombre = Nothing
        Me.BtBuscaTipoProv.CL_CampoOrden = "Nombre"
        Me.BtBuscaTipoProv.CL_ch1000 = False
        Me.BtBuscaTipoProv.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTipoProv.CL_ControlAsociado = Me.TxDato_10
        Me.BtBuscaTipoProv.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTipoProv.CL_dfecha = Nothing
        Me.BtBuscaTipoProv.CL_Entidad = Nothing
        Me.BtBuscaTipoProv.CL_EsId = True
        Me.BtBuscaTipoProv.CL_Filtro = Nothing
        Me.BtBuscaTipoProv.cl_formu = Nothing
        Me.BtBuscaTipoProv.CL_hfecha = Nothing
        Me.BtBuscaTipoProv.cl_ListaW = Nothing
        Me.BtBuscaTipoProv.CL_xCentro = False
        Me.BtBuscaTipoProv.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTipoProv.Location = New System.Drawing.Point(175, 113)
        Me.BtBuscaTipoProv.Name = "BtBuscaTipoProv"
        Me.BtBuscaTipoProv.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTipoProv.TabIndex = 133
        Me.BtBuscaTipoProv.UseVisualStyleBackColor = True
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Bloqueado = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(105, 113)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_10.TabIndex = 132
        Me.TxDato_10.TeclaRepetida = False
        Me.TxDato_10.TxDatoFinalSemana = Nothing
        Me.TxDato_10.TxDatoInicioSemana = Nothing
        Me.TxDato_10.UltimoValorValidado = Nothing
        '
        'Lb_10
        '
        Me.Lb_10.AutoSize = True
        Me.Lb_10.CL_ControlAsociado = Nothing
        Me.Lb_10.CL_ValorFijo = False
        Me.Lb_10.ClForm = Nothing
        Me.Lb_10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_10.ForeColor = System.Drawing.Color.Teal
        Me.Lb_10.Location = New System.Drawing.Point(9, 116)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(61, 16)
        Me.Lb_10.TabIndex = 131
        Me.Lb_10.Text = "Tipo pr."
        '
        'Lb_13
        '
        Me.Lb_13.AutoSize = True
        Me.Lb_13.CL_ControlAsociado = Nothing
        Me.Lb_13.CL_ValorFijo = False
        Me.Lb_13.ClForm = Nothing
        Me.Lb_13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_13.ForeColor = System.Drawing.Color.Teal
        Me.Lb_13.Location = New System.Drawing.Point(559, 275)
        Me.Lb_13.Name = "Lb_13"
        Me.Lb_13.Size = New System.Drawing.Size(87, 16)
        Me.Lb_13.TabIndex = 130
        Me.Lb_13.Text = "P.Contacto"
        '
        'TxDato_13
        '
        Me.TxDato_13.Autonumerico = False
        Me.TxDato_13.Bloqueado = False
        Me.TxDato_13.Buscando = False
        Me.TxDato_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_13.ClForm = Nothing
        Me.TxDato_13.ClParam = Nothing
        Me.TxDato_13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_13.GridLin = Nothing
        Me.TxDato_13.HaCambiado = False
        Me.TxDato_13.lbbusca = Nothing
        Me.TxDato_13.Location = New System.Drawing.Point(653, 272)
        Me.TxDato_13.MiError = False
        Me.TxDato_13.Name = "TxDato_13"
        Me.TxDato_13.Orden = 0
        Me.TxDato_13.SaltoAlfinal = False
        Me.TxDato_13.Siguiente = 0
        Me.TxDato_13.Size = New System.Drawing.Size(299, 22)
        Me.TxDato_13.TabIndex = 129
        Me.TxDato_13.TeclaRepetida = False
        Me.TxDato_13.TxDatoFinalSemana = Nothing
        Me.TxDato_13.TxDatoInicioSemana = Nothing
        Me.TxDato_13.UltimoValorValidado = Nothing
        '
        'Lbnom_9
        '
        Me.Lbnom_9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_9.CL_ControlAsociado = Nothing
        Me.Lbnom_9.CL_ValorFijo = False
        Me.Lbnom_9.ClForm = Nothing
        Me.Lbnom_9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_9.Location = New System.Drawing.Point(214, 89)
        Me.Lbnom_9.Name = "Lbnom_9"
        Me.Lbnom_9.Size = New System.Drawing.Size(245, 21)
        Me.Lbnom_9.TabIndex = 128
        '
        'BtBuscaPais
        '
        Me.BtBuscaPais.CL_Ancho = 0
        Me.BtBuscaPais.CL_BuscaAlb = False
        Me.BtBuscaPais.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaPais.CL_campocodigo = Nothing
        Me.BtBuscaPais.CL_camponombre = Nothing
        Me.BtBuscaPais.CL_CampoOrden = "Nombre"
        Me.BtBuscaPais.CL_ch1000 = False
        Me.BtBuscaPais.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaPais.CL_ControlAsociado = Me.TxDato_9
        Me.BtBuscaPais.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaPais.CL_dfecha = Nothing
        Me.BtBuscaPais.CL_Entidad = Nothing
        Me.BtBuscaPais.CL_EsId = True
        Me.BtBuscaPais.CL_Filtro = Nothing
        Me.BtBuscaPais.cl_formu = Nothing
        Me.BtBuscaPais.CL_hfecha = Nothing
        Me.BtBuscaPais.cl_ListaW = Nothing
        Me.BtBuscaPais.CL_xCentro = False
        Me.BtBuscaPais.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaPais.Location = New System.Drawing.Point(175, 88)
        Me.BtBuscaPais.Name = "BtBuscaPais"
        Me.BtBuscaPais.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaPais.TabIndex = 127
        Me.BtBuscaPais.UseVisualStyleBackColor = True
        '
        'TxDato_9
        '
        Me.TxDato_9.Autonumerico = False
        Me.TxDato_9.Bloqueado = False
        Me.TxDato_9.Buscando = False
        Me.TxDato_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_9.ClForm = Nothing
        Me.TxDato_9.ClParam = Nothing
        Me.TxDato_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_9.GridLin = Nothing
        Me.TxDato_9.HaCambiado = False
        Me.TxDato_9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_9.lbbusca = Nothing
        Me.TxDato_9.Location = New System.Drawing.Point(105, 88)
        Me.TxDato_9.MiError = False
        Me.TxDato_9.Name = "TxDato_9"
        Me.TxDato_9.Orden = 0
        Me.TxDato_9.SaltoAlfinal = False
        Me.TxDato_9.Siguiente = 0
        Me.TxDato_9.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_9.TabIndex = 126
        Me.TxDato_9.TeclaRepetida = False
        Me.TxDato_9.TxDatoFinalSemana = Nothing
        Me.TxDato_9.TxDatoInicioSemana = Nothing
        Me.TxDato_9.UltimoValorValidado = Nothing
        '
        'Lb_9
        '
        Me.Lb_9.AutoSize = True
        Me.Lb_9.CL_ControlAsociado = Nothing
        Me.Lb_9.CL_ValorFijo = False
        Me.Lb_9.ClForm = Nothing
        Me.Lb_9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_9.ForeColor = System.Drawing.Color.Teal
        Me.Lb_9.Location = New System.Drawing.Point(9, 91)
        Me.Lb_9.Name = "Lb_9"
        Me.Lb_9.Size = New System.Drawing.Size(37, 16)
        Me.Lb_9.TabIndex = 125
        Me.Lb_9.Text = "País"
        '
        'Lb_8
        '
        Me.Lb_8.AutoSize = True
        Me.Lb_8.CL_ControlAsociado = Nothing
        Me.Lb_8.CL_ValorFijo = False
        Me.Lb_8.ClForm = Nothing
        Me.Lb_8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_8.ForeColor = System.Drawing.Color.Teal
        Me.Lb_8.Location = New System.Drawing.Point(464, 65)
        Me.Lb_8.Name = "Lb_8"
        Me.Lb_8.Size = New System.Drawing.Size(67, 16)
        Me.Lb_8.TabIndex = 124
        Me.Lb_8.Text = "C.Postal"
        '
        'TxDato_8
        '
        Me.TxDato_8.Autonumerico = False
        Me.TxDato_8.Bloqueado = False
        Me.TxDato_8.Buscando = False
        Me.TxDato_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_8.ClForm = Nothing
        Me.TxDato_8.ClParam = Nothing
        Me.TxDato_8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_8.GridLin = Nothing
        Me.TxDato_8.HaCambiado = False
        Me.TxDato_8.lbbusca = Nothing
        Me.TxDato_8.Location = New System.Drawing.Point(570, 62)
        Me.TxDato_8.MiError = False
        Me.TxDato_8.Name = "TxDato_8"
        Me.TxDato_8.Orden = 0
        Me.TxDato_8.SaltoAlfinal = False
        Me.TxDato_8.Siguiente = 0
        Me.TxDato_8.Size = New System.Drawing.Size(117, 22)
        Me.TxDato_8.TabIndex = 123
        Me.TxDato_8.TeclaRepetida = False
        Me.TxDato_8.TxDatoFinalSemana = Nothing
        Me.TxDato_8.TxDatoInicioSemana = Nothing
        Me.TxDato_8.UltimoValorValidado = Nothing
        '
        'Lb_7
        '
        Me.Lb_7.AutoSize = True
        Me.Lb_7.CL_ControlAsociado = Nothing
        Me.Lb_7.CL_ValorFijo = False
        Me.Lb_7.ClForm = Nothing
        Me.Lb_7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_7.ForeColor = System.Drawing.Color.Teal
        Me.Lb_7.Location = New System.Drawing.Point(9, 65)
        Me.Lb_7.Name = "Lb_7"
        Me.Lb_7.Size = New System.Drawing.Size(74, 16)
        Me.Lb_7.TabIndex = 122
        Me.Lb_7.Text = "Provincia"
        '
        'TxDato_7
        '
        Me.TxDato_7.Autonumerico = False
        Me.TxDato_7.Bloqueado = False
        Me.TxDato_7.Buscando = False
        Me.TxDato_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_7.ClForm = Nothing
        Me.TxDato_7.ClParam = Nothing
        Me.TxDato_7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_7.GridLin = Nothing
        Me.TxDato_7.HaCambiado = False
        Me.TxDato_7.lbbusca = Nothing
        Me.TxDato_7.Location = New System.Drawing.Point(105, 62)
        Me.TxDato_7.MiError = False
        Me.TxDato_7.Name = "TxDato_7"
        Me.TxDato_7.Orden = 0
        Me.TxDato_7.SaltoAlfinal = False
        Me.TxDato_7.Siguiente = 0
        Me.TxDato_7.Size = New System.Drawing.Size(328, 22)
        Me.TxDato_7.TabIndex = 121
        Me.TxDato_7.TeclaRepetida = False
        Me.TxDato_7.TxDatoFinalSemana = Nothing
        Me.TxDato_7.TxDatoInicioSemana = Nothing
        Me.TxDato_7.UltimoValorValidado = Nothing
        '
        'Lb_6
        '
        Me.Lb_6.AutoSize = True
        Me.Lb_6.CL_ControlAsociado = Nothing
        Me.Lb_6.CL_ValorFijo = False
        Me.Lb_6.ClForm = Nothing
        Me.Lb_6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_6.ForeColor = System.Drawing.Color.Teal
        Me.Lb_6.Location = New System.Drawing.Point(464, 40)
        Me.Lb_6.Name = "Lb_6"
        Me.Lb_6.Size = New System.Drawing.Size(77, 16)
        Me.Lb_6.TabIndex = 120
        Me.Lb_6.Text = "Población"
        '
        'TxDato_6
        '
        Me.TxDato_6.Autonumerico = False
        Me.TxDato_6.Bloqueado = False
        Me.TxDato_6.Buscando = False
        Me.TxDato_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_6.ClForm = Nothing
        Me.TxDato_6.ClParam = Nothing
        Me.TxDato_6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_6.GridLin = Nothing
        Me.TxDato_6.HaCambiado = False
        Me.TxDato_6.lbbusca = Nothing
        Me.TxDato_6.Location = New System.Drawing.Point(570, 37)
        Me.TxDato_6.MiError = False
        Me.TxDato_6.Name = "TxDato_6"
        Me.TxDato_6.Orden = 0
        Me.TxDato_6.SaltoAlfinal = False
        Me.TxDato_6.Siguiente = 0
        Me.TxDato_6.Size = New System.Drawing.Size(382, 22)
        Me.TxDato_6.TabIndex = 119
        Me.TxDato_6.TeclaRepetida = False
        Me.TxDato_6.TxDatoFinalSemana = Nothing
        Me.TxDato_6.TxDatoInicioSemana = Nothing
        Me.TxDato_6.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(9, 15)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(73, 16)
        Me.Lb_4.TabIndex = 118
        Me.Lb_4.Text = "Domicilio"
        '
        'TxDato_4
        '
        Me.TxDato_4.Autonumerico = False
        Me.TxDato_4.Bloqueado = False
        Me.TxDato_4.Buscando = False
        Me.TxDato_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_4.ClForm = Nothing
        Me.TxDato_4.ClParam = Nothing
        Me.TxDato_4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_4.GridLin = Nothing
        Me.TxDato_4.HaCambiado = False
        Me.TxDato_4.lbbusca = Nothing
        Me.TxDato_4.Location = New System.Drawing.Point(105, 12)
        Me.TxDato_4.MiError = False
        Me.TxDato_4.Name = "TxDato_4"
        Me.TxDato_4.Orden = 0
        Me.TxDato_4.SaltoAlfinal = False
        Me.TxDato_4.Siguiente = 0
        Me.TxDato_4.Size = New System.Drawing.Size(568, 22)
        Me.TxDato_4.TabIndex = 117
        Me.TxDato_4.TeclaRepetida = False
        Me.TxDato_4.TxDatoFinalSemana = Nothing
        Me.TxDato_4.TxDatoInicioSemana = Nothing
        Me.TxDato_4.UltimoValorValidado = Nothing
        '
        'Lbnom_5
        '
        Me.Lbnom_5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_5.CL_ControlAsociado = Nothing
        Me.Lbnom_5.CL_ValorFijo = False
        Me.Lbnom_5.ClForm = Nothing
        Me.Lbnom_5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_5.Location = New System.Drawing.Point(214, 38)
        Me.Lbnom_5.Name = "Lbnom_5"
        Me.Lbnom_5.Size = New System.Drawing.Size(245, 21)
        Me.Lbnom_5.TabIndex = 86
        '
        'btBuscaZona
        '
        Me.btBuscaZona.CL_Ancho = 0
        Me.btBuscaZona.CL_BuscaAlb = False
        Me.btBuscaZona.CL_BuscarEnTodosLosCampos = False
        Me.btBuscaZona.CL_campocodigo = Nothing
        Me.btBuscaZona.CL_camponombre = Nothing
        Me.btBuscaZona.CL_CampoOrden = "Nombre"
        Me.btBuscaZona.CL_ch1000 = False
        Me.btBuscaZona.CL_ConsultaSql = "Select * from familias"
        Me.btBuscaZona.CL_ControlAsociado = Me.TxDato_5
        Me.btBuscaZona.CL_DevuelveCampo = "Idfamilia"
        Me.btBuscaZona.CL_dfecha = Nothing
        Me.btBuscaZona.CL_Entidad = Nothing
        Me.btBuscaZona.CL_EsId = True
        Me.btBuscaZona.CL_Filtro = Nothing
        Me.btBuscaZona.cl_formu = Nothing
        Me.btBuscaZona.CL_hfecha = Nothing
        Me.btBuscaZona.cl_ListaW = Nothing
        Me.btBuscaZona.CL_xCentro = False
        Me.btBuscaZona.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.btBuscaZona.Location = New System.Drawing.Point(175, 37)
        Me.btBuscaZona.Name = "btBuscaZona"
        Me.btBuscaZona.Size = New System.Drawing.Size(33, 23)
        Me.btBuscaZona.TabIndex = 85
        Me.btBuscaZona.UseVisualStyleBackColor = True
        '
        'TxDato_5
        '
        Me.TxDato_5.Autonumerico = False
        Me.TxDato_5.Bloqueado = False
        Me.TxDato_5.Buscando = False
        Me.TxDato_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_5.ClForm = Nothing
        Me.TxDato_5.ClParam = Nothing
        Me.TxDato_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_5.GridLin = Nothing
        Me.TxDato_5.HaCambiado = False
        Me.TxDato_5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_5.lbbusca = Nothing
        Me.TxDato_5.Location = New System.Drawing.Point(105, 37)
        Me.TxDato_5.MiError = False
        Me.TxDato_5.Name = "TxDato_5"
        Me.TxDato_5.Orden = 0
        Me.TxDato_5.SaltoAlfinal = False
        Me.TxDato_5.Siguiente = 0
        Me.TxDato_5.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_5.TabIndex = 84
        Me.TxDato_5.TeclaRepetida = False
        Me.TxDato_5.TxDatoFinalSemana = Nothing
        Me.TxDato_5.TxDatoInicioSemana = Nothing
        Me.TxDato_5.UltimoValorValidado = Nothing
        '
        'Lb_5
        '
        Me.Lb_5.AutoSize = True
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.Teal
        Me.Lb_5.Location = New System.Drawing.Point(9, 40)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(43, 16)
        Me.Lb_5.TabIndex = 83
        Me.Lb_5.Text = "Zona"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XtraTabControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 64)
        Me.XtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(980, 510)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridSaldosEnvases)
        Me.XtraTabPage4.Controls.Add(Me.Panel4)
        Me.XtraTabPage4.Controls.Add(Me.GridSaldos)
        Me.XtraTabPage4.Controls.Add(Me.Panel3)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(976, 484)
        Me.XtraTabPage4.Text = "Datos Economicos"
        '
        'GridSaldosEnvases
        '
        Me.GridSaldosEnvases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSaldosEnvases.Location = New System.Drawing.Point(0, 234)
        Me.GridSaldosEnvases.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridSaldosEnvases.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridSaldosEnvases.MainView = Me.GridViewSaldosEnvases
        Me.GridSaldosEnvases.Name = "GridSaldosEnvases"
        Me.GridSaldosEnvases.Size = New System.Drawing.Size(976, 250)
        Me.GridSaldosEnvases.TabIndex = 180
        Me.GridSaldosEnvases.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSaldosEnvases, Me.GridView11, Me.GridView12})
        '
        'GridViewSaldosEnvases
        '
        Me.GridViewSaldosEnvases.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewSaldosEnvases.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewSaldosEnvases.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewSaldosEnvases.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSaldosEnvases.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewSaldosEnvases.Appearance.Row.Options.UseFont = True
        Me.GridViewSaldosEnvases.Appearance.Row.Options.UseForeColor = True
        Me.GridViewSaldosEnvases.GridControl = Me.GridSaldosEnvases
        Me.GridViewSaldosEnvases.Name = "GridViewSaldosEnvases"
        Me.GridViewSaldosEnvases.OptionsBehavior.Editable = False
        Me.GridViewSaldosEnvases.OptionsView.ShowGroupPanel = False
        '
        'GridView11
        '
        Me.GridView11.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView11.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView11.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView11.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView11.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView11.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView11.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView11.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView11.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView11.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView11.Appearance.Row.Options.UseFont = True
        Me.GridView11.Appearance.Row.Options.UseForeColor = True
        Me.GridView11.GridControl = Me.GridSaldosEnvases
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'GridView12
        '
        Me.GridView12.GridControl = Me.GridSaldosEnvases
        Me.GridView12.Name = "GridView12"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 212)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(976, 22)
        Me.Panel4.TabIndex = 179
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(976, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SALDOS ENVASES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridSaldos
        '
        Me.GridSaldos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridSaldos.Location = New System.Drawing.Point(0, 22)
        Me.GridSaldos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridSaldos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridSaldos.MainView = Me.GridViewSaldos
        Me.GridSaldos.Name = "GridSaldos"
        Me.GridSaldos.Size = New System.Drawing.Size(976, 190)
        Me.GridSaldos.TabIndex = 178
        Me.GridSaldos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSaldos, Me.GridView5, Me.GridView6})
        '
        'GridViewSaldos
        '
        Me.GridViewSaldos.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewSaldos.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewSaldos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewSaldos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewSaldos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewSaldos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridViewSaldos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewSaldos.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewSaldos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSaldos.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewSaldos.Appearance.Row.Options.UseFont = True
        Me.GridViewSaldos.Appearance.Row.Options.UseForeColor = True
        Me.GridViewSaldos.GridControl = Me.GridSaldos
        Me.GridViewSaldos.Name = "GridViewSaldos"
        Me.GridViewSaldos.OptionsBehavior.Editable = False
        Me.GridViewSaldos.OptionsView.ShowGroupPanel = False
        '
        'GridView5
        '
        Me.GridView5.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView5.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView5.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView5.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView5.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView5.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView5.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView5.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView5.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView5.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView5.Appearance.Row.Options.UseFont = True
        Me.GridView5.Appearance.Row.Options.UseForeColor = True
        Me.GridView5.GridControl = Me.GridSaldos
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GridSaldos
        Me.GridView6.Name = "GridView6"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(976, 22)
        Me.Panel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(976, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SALDOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.Label7)
        Me.XtraTabPage5.Controls.Add(Me.Label6)
        Me.XtraTabPage5.Controls.Add(Me.GridFacturasPendientesPago)
        Me.XtraTabPage5.Controls.Add(Me.GridAlbaranesPendientesFacturar)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(976, 484)
        Me.XtraTabPage5.Text = "Otros datos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(31, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 20)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "FACTURAS PTES. DE PAGO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(31, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 20)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "ALBARANES PTES. FACTURAR"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridFacturasPendientesPago
        '
        Me.GridFacturasPendientesPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturasPendientesPago.Location = New System.Drawing.Point(21, 252)
        Me.GridFacturasPendientesPago.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridFacturasPendientesPago.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridFacturasPendientesPago.MainView = Me.GridViewFacturasPendientesPago
        Me.GridFacturasPendientesPago.Name = "GridFacturasPendientesPago"
        Me.GridFacturasPendientesPago.Size = New System.Drawing.Size(936, 223)
        Me.GridFacturasPendientesPago.TabIndex = 180
        Me.GridFacturasPendientesPago.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFacturasPendientesPago, Me.GridView15, Me.GridView16})
        '
        'GridViewFacturasPendientesPago
        '
        Me.GridViewFacturasPendientesPago.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewFacturasPendientesPago.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewFacturasPendientesPago.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewFacturasPendientesPago.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewFacturasPendientesPago.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewFacturasPendientesPago.Appearance.Row.Options.UseFont = True
        Me.GridViewFacturasPendientesPago.Appearance.Row.Options.UseForeColor = True
        Me.GridViewFacturasPendientesPago.GridControl = Me.GridFacturasPendientesPago
        Me.GridViewFacturasPendientesPago.Name = "GridViewFacturasPendientesPago"
        Me.GridViewFacturasPendientesPago.OptionsBehavior.Editable = False
        Me.GridViewFacturasPendientesPago.OptionsView.ShowGroupPanel = False
        '
        'GridView15
        '
        Me.GridView15.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView15.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView15.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView15.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView15.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView15.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView15.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView15.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView15.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView15.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView15.Appearance.Row.Options.UseFont = True
        Me.GridView15.Appearance.Row.Options.UseForeColor = True
        Me.GridView15.GridControl = Me.GridFacturasPendientesPago
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'GridView16
        '
        Me.GridView16.GridControl = Me.GridFacturasPendientesPago
        Me.GridView16.Name = "GridView16"
        '
        'GridAlbaranesPendientesFacturar
        '
        Me.GridAlbaranesPendientesFacturar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAlbaranesPendientesFacturar.Location = New System.Drawing.Point(21, 33)
        Me.GridAlbaranesPendientesFacturar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridAlbaranesPendientesFacturar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridAlbaranesPendientesFacturar.MainView = Me.GridViewAlbaranesPendientesFacturar
        Me.GridAlbaranesPendientesFacturar.Name = "GridAlbaranesPendientesFacturar"
        Me.GridAlbaranesPendientesFacturar.Size = New System.Drawing.Size(936, 189)
        Me.GridAlbaranesPendientesFacturar.TabIndex = 179
        Me.GridAlbaranesPendientesFacturar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAlbaranesPendientesFacturar, Me.GridView10, Me.GridView13})
        '
        'GridViewAlbaranesPendientesFacturar
        '
        Me.GridViewAlbaranesPendientesFacturar.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridViewAlbaranesPendientesFacturar.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewAlbaranesPendientesFacturar.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewAlbaranesPendientesFacturar.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewAlbaranesPendientesFacturar.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewAlbaranesPendientesFacturar.Appearance.Row.Options.UseFont = True
        Me.GridViewAlbaranesPendientesFacturar.Appearance.Row.Options.UseForeColor = True
        Me.GridViewAlbaranesPendientesFacturar.GridControl = Me.GridAlbaranesPendientesFacturar
        Me.GridViewAlbaranesPendientesFacturar.Name = "GridViewAlbaranesPendientesFacturar"
        Me.GridViewAlbaranesPendientesFacturar.OptionsBehavior.Editable = False
        Me.GridViewAlbaranesPendientesFacturar.OptionsView.ShowGroupPanel = False
        '
        'GridView10
        '
        Me.GridView10.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView10.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView10.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView10.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView10.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView10.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView10.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView10.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView10.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView10.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView10.Appearance.Row.Options.UseFont = True
        Me.GridView10.Appearance.Row.Options.UseForeColor = True
        Me.GridView10.GridControl = Me.GridAlbaranesPendientesFacturar
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'GridView13
        '
        Me.GridView13.GridControl = Me.GridAlbaranesPendientesFacturar
        Me.GridView13.Name = "GridView13"
        '
        'FrmAgricultores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 608)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAgricultores"
        Me.Text = "Agricultores"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GridMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridSaldosEnvases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSaldosEnvases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.GridFacturasPendientesPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFacturasPendientesPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAlbaranesPendientesFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAlbaranesPendientesFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaAgri As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btNifs As System.Windows.Forms.Button
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridAsociados As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewAsociados As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lbnom_45 As NetAgro.Lb
    Friend WithEvents BtBuscaCentroRec As NetAgro.BtBusca
    Friend WithEvents TxDato_45 As NetAgro.TxDato
    Friend WithEvents Lb_45 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents CbFaccom As NetAgro.CbBox
    Friend WithEvents Lbnom_44 As NetAgro.Lb
    Friend WithEvents BtBuscaAcreedor As NetAgro.BtBusca
    Friend WithEvents TxDato_44 As NetAgro.TxDato
    Friend WithEvents Lb_44 As NetAgro.Lb
    Friend WithEvents Chprin As NetAgro.Chk
    Friend WithEvents ChFija As NetAgro.Chk
    Friend WithEvents TxDato_43 As NetAgro.TxDato
    Friend WithEvents Lb_43 As NetAgro.Lb
    Friend WithEvents Lb_Nom42 As NetAgro.Lb
    Friend WithEvents BtBuscaGasto As NetAgro.BtBusca
    Friend WithEvents TxDato_42 As NetAgro.TxDato
    Friend WithEvents Lb_42 As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxMensaje As NetAgro.TxDato
    Friend WithEvents ChkMostrarMensaje As NetAgro.Chk
    Friend WithEvents ChkBloqueoPagos As NetAgro.Chk
    Friend WithEvents Lb_25 As NetAgro.Lb
    Friend WithEvents TxDato_25 As NetAgro.TxDato
    Friend WithEvents TxDato_26 As NetAgro.TxDato
    Friend WithEvents Lb_26 As NetAgro.Lb
    Friend WithEvents TxDato_24 As NetAgro.TxDato
    Friend WithEvents Lb_24 As NetAgro.Lb
    Friend WithEvents TxDato_23 As NetAgro.TxDato
    Friend WithEvents Lb_23 As NetAgro.Lb
    Friend WithEvents BtContactos As NetAgro.ClButton
    Friend WithEvents Lbret As NetAgro.Lb
    Friend WithEvents Lb42 As NetAgro.Lb
    Friend WithEvents Lbiva As NetAgro.Lb
    Friend WithEvents Lb40 As NetAgro.Lb
    Friend WithEvents LbNom_14 As NetAgro.Lb
    Friend WithEvents BtBuscaPrinci As NetAgro.BtBusca
    Friend WithEvents TxDato_14 As NetAgro.TxDato
    Friend WithEvents Lb_14 As NetAgro.Lb
    Friend WithEvents TxDato_12 As NetAgro.TxDato
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents ChBloqueo As NetAgro.Chk
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents BtBuscaTipoProv As NetAgro.BtBusca
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents Lb_13 As NetAgro.Lb
    Friend WithEvents TxDato_13 As NetAgro.TxDato
    Friend WithEvents Lbnom_9 As NetAgro.Lb
    Friend WithEvents BtBuscaPais As NetAgro.BtBusca
    Friend WithEvents TxDato_9 As NetAgro.TxDato
    Friend WithEvents Lb_9 As NetAgro.Lb
    Friend WithEvents Lb_8 As NetAgro.Lb
    Friend WithEvents TxDato_8 As NetAgro.TxDato
    Friend WithEvents Lb_7 As NetAgro.Lb
    Friend WithEvents TxDato_7 As NetAgro.TxDato
    Friend WithEvents Lb_6 As NetAgro.Lb
    Friend WithEvents TxDato_6 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents TxDato_4 As NetAgro.TxDato
    Friend WithEvents Lbnom_5 As NetAgro.Lb
    Friend WithEvents btBuscaZona As NetAgro.BtBusca
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents GridMed As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtObserva As NetAgro.ClButton
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbAltaopfh As NetAgro.Lb
    Friend WithEvents TxAltaOpFH As NetAgro.TxDato
    Friend WithEvents LbNomCrecogida As NetAgro.Lb
    Friend WithEvents BtBuscaCRecogida As NetAgro.BtBusca
    Friend WithEvents TxCrecogida As NetAgro.TxDato
    Friend WithEvents LbCrecogida As NetAgro.Lb
    Friend WithEvents LbNomEmpresa As NetAgro.Lb
    Friend WithEvents BtBuscaEmpresa As NetAgro.BtBusca
    Friend WithEvents TxEmpresa As NetAgro.TxDato
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents LbNomCenvases As NetAgro.Lb
    Friend WithEvents BtBuscaCenvases As NetAgro.BtBusca
    Friend WithEvents TxCenvases As NetAgro.TxDato
    Friend WithEvents LbCenvases As NetAgro.Lb
    Friend WithEvents LbSerie As NetAgro.Lb
    Friend WithEvents TxSerie As NetAgro.TxDato
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents GridSaldosEnvases As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewSaldosEnvases As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents GridSaldos As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewSaldos As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents GridAlbaranesPendientesFacturar As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewAlbaranesPendientesFacturar As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridFacturasPendientesPago As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewFacturasPendientesPago As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkNoFacturar As NetAgro.Chk
    Friend WithEvents LbNomBanco As NetAgro.Lb
    Friend WithEvents BtBanco As NetAgro.BtBusca
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents ChkAsignarAcreedor As NetAgro.Chk
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents BtCentro As NetAgro.BtBusca
    Friend WithEvents TxCentro As NetAgro.TxDato
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbIBAN As NetAgro.Lb
    Friend WithEvents TxIBAN As NetAgro.TxDato
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TxDiasVto As NetAgro.TxDato
    Friend WithEvents LbDiasVto As NetAgro.Lb
    Friend WithEvents LbNom_TipoDoc As NetAgro.Lb
    Friend WithEvents TxTipoDoc As NetAgro.TxDato
    Friend WithEvents BtBuscaTipoDoc As NetAgro.BtBusca
    Friend WithEvents LbTipoDoc As NetAgro.Lb
    Friend WithEvents LbNom_SitCartera As NetAgro.Lb
    Friend WithEvents TxSitCartera As NetAgro.TxDato
    Friend WithEvents BtBuscaSitCartera As NetAgro.BtBusca
    Friend WithEvents LbSitCartera As NetAgro.Lb
    Friend WithEvents RbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents RbPagare As System.Windows.Forms.RadioButton
    Friend WithEvents rbTalon As System.Windows.Forms.RadioButton
    Friend WithEvents LbEmailCalidad As NetAgro.Lb
    Friend WithEvents TxEmailCalidad As NetAgro.TxDato
    Friend WithEvents btIBAN As System.Windows.Forms.Button
    Friend WithEvents btEditarIBAN As NetAgro.ClButton
End Class
