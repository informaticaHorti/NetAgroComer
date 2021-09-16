<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoFacturasClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoFacturasClientes))
        Me.TxHastaCliente = New NetAgro.TxDato(Me.components)
        Me.LbHastaCliente = New NetAgro.Lb(Me.components)
        Me.TxDesdeCliente = New NetAgro.TxDato(Me.components)
        Me.LbDesdeCliente = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbNomDesdeCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaDesdeCliente = New NetAgro.BtBusca(Me.components)
        Me.LbNomHastaCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaHastaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxHastaSerie = New NetAgro.TxDato(Me.components)
        Me.LbDesdeSerie = New NetAgro.Lb(Me.components)
        Me.LbHastaSerie = New NetAgro.Lb(Me.components)
        Me.TxDesdeSerie = New NetAgro.TxDato(Me.components)
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.chkDetallarFacturas = New NetAgro.Chk(Me.components)
        Me.RbSICobradas = New System.Windows.Forms.RadioButton()
        Me.RbNOCobradas = New System.Windows.Forms.RadioButton()
        Me.RbTodasCobradas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbFechaSalida = New System.Windows.Forms.RadioButton()
        Me.RbFechaFactura = New System.Windows.Forms.RadioButton()
        Me.ChkEuros = New NetAgro.Chk(Me.components)
        Me.chkListadoSeguro = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.chkListadoSeguro)
        Me.PanelCabecera.Controls.Add(Me.ChkEuros)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.Lb8)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.TxHastaSerie)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeSerie)
        Me.PanelCabecera.Controls.Add(Me.LbHastaSerie)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeSerie)
        Me.PanelCabecera.Controls.Add(Me.LbNomHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.LbNomDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.chkDetallarFacturas)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.TxHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.LbHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeCliente)
        Me.PanelCabecera.Size = New System.Drawing.Size(1279, 127)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 127)
        Me.PanelConsulta.Size = New System.Drawing.Size(1279, 401)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(979, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1054, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1129, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1204, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(904, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxHastaCliente
        '
        Me.TxHastaCliente.Autonumerico = False
        Me.TxHastaCliente.Buscando = False
        Me.TxHastaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaCliente.ClForm = Nothing
        Me.TxHastaCliente.ClParam = Nothing
        Me.TxHastaCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaCliente.GridLin = Nothing
        Me.TxHastaCliente.HaCambiado = False
        Me.TxHastaCliente.lbbusca = Nothing
        Me.TxHastaCliente.Location = New System.Drawing.Point(132, 41)
        Me.TxHastaCliente.MiError = False
        Me.TxHastaCliente.Name = "TxHastaCliente"
        Me.TxHastaCliente.Orden = 0
        Me.TxHastaCliente.SaltoAlfinal = False
        Me.TxHastaCliente.Siguiente = 0
        Me.TxHastaCliente.Size = New System.Drawing.Size(70, 22)
        Me.TxHastaCliente.TabIndex = 83
        Me.TxHastaCliente.TeclaRepetida = False
        Me.TxHastaCliente.TxDatoFinalSemana = Nothing
        Me.TxHastaCliente.TxDatoInicioSemana = Nothing
        Me.TxHastaCliente.UltimoValorValidado = Nothing
        '
        'LbHastaCliente
        '
        Me.LbHastaCliente.AutoSize = True
        Me.LbHastaCliente.CL_ControlAsociado = Nothing
        Me.LbHastaCliente.CL_ValorFijo = False
        Me.LbHastaCliente.ClForm = Nothing
        Me.LbHastaCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaCliente.Location = New System.Drawing.Point(13, 44)
        Me.LbHastaCliente.Name = "LbHastaCliente"
        Me.LbHastaCliente.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaCliente.TabIndex = 82
        Me.LbHastaCliente.Text = "Hasta Cliente"
        '
        'TxDesdeCliente
        '
        Me.TxDesdeCliente.Autonumerico = False
        Me.TxDesdeCliente.Buscando = False
        Me.TxDesdeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeCliente.ClForm = Nothing
        Me.TxDesdeCliente.ClParam = Nothing
        Me.TxDesdeCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeCliente.GridLin = Nothing
        Me.TxDesdeCliente.HaCambiado = False
        Me.TxDesdeCliente.lbbusca = Nothing
        Me.TxDesdeCliente.Location = New System.Drawing.Point(132, 12)
        Me.TxDesdeCliente.MiError = False
        Me.TxDesdeCliente.Name = "TxDesdeCliente"
        Me.TxDesdeCliente.Orden = 0
        Me.TxDesdeCliente.SaltoAlfinal = False
        Me.TxDesdeCliente.Siguiente = 0
        Me.TxDesdeCliente.Size = New System.Drawing.Size(70, 22)
        Me.TxDesdeCliente.TabIndex = 81
        Me.TxDesdeCliente.TeclaRepetida = False
        Me.TxDesdeCliente.TxDatoFinalSemana = Nothing
        Me.TxDesdeCliente.TxDatoInicioSemana = Nothing
        Me.TxDesdeCliente.UltimoValorValidado = Nothing
        '
        'LbDesdeCliente
        '
        Me.LbDesdeCliente.AutoSize = True
        Me.LbDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbDesdeCliente.CL_ValorFijo = False
        Me.LbDesdeCliente.ClForm = Nothing
        Me.LbDesdeCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeCliente.Location = New System.Drawing.Point(13, 15)
        Me.LbDesdeCliente.Name = "LbDesdeCliente"
        Me.LbDesdeCliente.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeCliente.TabIndex = 80
        Me.LbDesdeCliente.Text = "Desde Cliente"
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(132, 99)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 100283
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(13, 73)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(101, 16)
        Me.LbDesdeFecha.TabIndex = 100280
        Me.LbDesdeFecha.Text = "Desde Fecha"
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(13, 102)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(99, 16)
        Me.LbHastaFecha.TabIndex = 100282
        Me.LbHastaFecha.Text = "Hasta Fecha"
        '
        'TxDesdeFecha
        '
        Me.TxDesdeFecha.Autonumerico = False
        Me.TxDesdeFecha.Buscando = False
        Me.TxDesdeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeFecha.ClForm = Nothing
        Me.TxDesdeFecha.ClParam = Nothing
        Me.TxDesdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFecha.GridLin = Nothing
        Me.TxDesdeFecha.HaCambiado = False
        Me.TxDesdeFecha.lbbusca = Nothing
        Me.TxDesdeFecha.Location = New System.Drawing.Point(132, 70)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 100281
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.TxDatoFinalSemana = Nothing
        Me.TxDesdeFecha.TxDatoInicioSemana = Nothing
        Me.TxDesdeFecha.UltimoValorValidado = Nothing
        '
        'LbNomDesdeCliente
        '
        Me.LbNomDesdeCliente.BackColor = System.Drawing.Color.LightGray
        Me.LbNomDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbNomDesdeCliente.CL_ValorFijo = False
        Me.LbNomDesdeCliente.ClForm = Nothing
        Me.LbNomDesdeCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeCliente.Location = New System.Drawing.Point(247, 12)
        Me.LbNomDesdeCliente.Name = "LbNomDesdeCliente"
        Me.LbNomDesdeCliente.Size = New System.Drawing.Size(388, 23)
        Me.LbNomDesdeCliente.TabIndex = 100288
        '
        'BtBuscaDesdeCliente
        '
        Me.BtBuscaDesdeCliente.CL_Ancho = 0
        Me.BtBuscaDesdeCliente.CL_BuscaAlb = False
        Me.BtBuscaDesdeCliente.CL_campocodigo = Nothing
        Me.BtBuscaDesdeCliente.CL_camponombre = Nothing
        Me.BtBuscaDesdeCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeCliente.CL_ch1000 = False
        Me.BtBuscaDesdeCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeCliente.CL_dfecha = Nothing
        Me.BtBuscaDesdeCliente.CL_Entidad = Nothing
        Me.BtBuscaDesdeCliente.CL_EsId = True
        Me.BtBuscaDesdeCliente.CL_Filtro = Nothing
        Me.BtBuscaDesdeCliente.cl_formu = Nothing
        Me.BtBuscaDesdeCliente.CL_hfecha = Nothing
        Me.BtBuscaDesdeCliente.cl_ListaW = Nothing
        Me.BtBuscaDesdeCliente.CL_xCentro = False
        Me.BtBuscaDesdeCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeCliente.Location = New System.Drawing.Point(208, 12)
        Me.BtBuscaDesdeCliente.Name = "BtBuscaDesdeCliente"
        Me.BtBuscaDesdeCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeCliente.TabIndex = 100287
        Me.BtBuscaDesdeCliente.UseVisualStyleBackColor = True
        '
        'LbNomHastaCliente
        '
        Me.LbNomHastaCliente.BackColor = System.Drawing.Color.LightGray
        Me.LbNomHastaCliente.CL_ControlAsociado = Nothing
        Me.LbNomHastaCliente.CL_ValorFijo = False
        Me.LbNomHastaCliente.ClForm = Nothing
        Me.LbNomHastaCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomHastaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomHastaCliente.Location = New System.Drawing.Point(247, 41)
        Me.LbNomHastaCliente.Name = "LbNomHastaCliente"
        Me.LbNomHastaCliente.Size = New System.Drawing.Size(388, 23)
        Me.LbNomHastaCliente.TabIndex = 100290
        '
        'BtBuscaHastaCliente
        '
        Me.BtBuscaHastaCliente.CL_Ancho = 0
        Me.BtBuscaHastaCliente.CL_BuscaAlb = False
        Me.BtBuscaHastaCliente.CL_campocodigo = Nothing
        Me.BtBuscaHastaCliente.CL_camponombre = Nothing
        Me.BtBuscaHastaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaCliente.CL_ch1000 = False
        Me.BtBuscaHastaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaCliente.CL_dfecha = Nothing
        Me.BtBuscaHastaCliente.CL_Entidad = Nothing
        Me.BtBuscaHastaCliente.CL_EsId = True
        Me.BtBuscaHastaCliente.CL_Filtro = Nothing
        Me.BtBuscaHastaCliente.cl_formu = Nothing
        Me.BtBuscaHastaCliente.CL_hfecha = Nothing
        Me.BtBuscaHastaCliente.cl_ListaW = Nothing
        Me.BtBuscaHastaCliente.CL_xCentro = False
        Me.BtBuscaHastaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaCliente.Location = New System.Drawing.Point(208, 41)
        Me.BtBuscaHastaCliente.Name = "BtBuscaHastaCliente"
        Me.BtBuscaHastaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaCliente.TabIndex = 100289
        Me.BtBuscaHastaCliente.UseVisualStyleBackColor = True
        '
        'TxHastaSerie
        '
        Me.TxHastaSerie.Autonumerico = False
        Me.TxHastaSerie.Buscando = False
        Me.TxHastaSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaSerie.ClForm = Nothing
        Me.TxHastaSerie.ClParam = Nothing
        Me.TxHastaSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaSerie.GridLin = Nothing
        Me.TxHastaSerie.HaCambiado = False
        Me.TxHastaSerie.lbbusca = Nothing
        Me.TxHastaSerie.Location = New System.Drawing.Point(772, 41)
        Me.TxHastaSerie.MiError = False
        Me.TxHastaSerie.Name = "TxHastaSerie"
        Me.TxHastaSerie.Orden = 0
        Me.TxHastaSerie.SaltoAlfinal = False
        Me.TxHastaSerie.Siguiente = 0
        Me.TxHastaSerie.Size = New System.Drawing.Size(59, 22)
        Me.TxHastaSerie.TabIndex = 100294
        Me.TxHastaSerie.TeclaRepetida = False
        Me.TxHastaSerie.TxDatoFinalSemana = Nothing
        Me.TxHastaSerie.TxDatoInicioSemana = Nothing
        Me.TxHastaSerie.UltimoValorValidado = Nothing
        '
        'LbDesdeSerie
        '
        Me.LbDesdeSerie.AutoSize = True
        Me.LbDesdeSerie.CL_ControlAsociado = Nothing
        Me.LbDesdeSerie.CL_ValorFijo = False
        Me.LbDesdeSerie.ClForm = Nothing
        Me.LbDesdeSerie.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeSerie.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeSerie.Location = New System.Drawing.Point(672, 15)
        Me.LbDesdeSerie.Name = "LbDesdeSerie"
        Me.LbDesdeSerie.Size = New System.Drawing.Size(94, 16)
        Me.LbDesdeSerie.TabIndex = 100291
        Me.LbDesdeSerie.Text = "Desde Serie"
        '
        'LbHastaSerie
        '
        Me.LbHastaSerie.AutoSize = True
        Me.LbHastaSerie.CL_ControlAsociado = Nothing
        Me.LbHastaSerie.CL_ValorFijo = False
        Me.LbHastaSerie.ClForm = Nothing
        Me.LbHastaSerie.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaSerie.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaSerie.Location = New System.Drawing.Point(672, 44)
        Me.LbHastaSerie.Name = "LbHastaSerie"
        Me.LbHastaSerie.Size = New System.Drawing.Size(92, 16)
        Me.LbHastaSerie.TabIndex = 100293
        Me.LbHastaSerie.Text = "Hasta Serie"
        '
        'TxDesdeSerie
        '
        Me.TxDesdeSerie.Autonumerico = False
        Me.TxDesdeSerie.Buscando = False
        Me.TxDesdeSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeSerie.ClForm = Nothing
        Me.TxDesdeSerie.ClParam = Nothing
        Me.TxDesdeSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeSerie.GridLin = Nothing
        Me.TxDesdeSerie.HaCambiado = False
        Me.TxDesdeSerie.lbbusca = Nothing
        Me.TxDesdeSerie.Location = New System.Drawing.Point(772, 12)
        Me.TxDesdeSerie.MiError = False
        Me.TxDesdeSerie.Name = "TxDesdeSerie"
        Me.TxDesdeSerie.Orden = 0
        Me.TxDesdeSerie.SaltoAlfinal = False
        Me.TxDesdeSerie.Siguiente = 0
        Me.TxDesdeSerie.Size = New System.Drawing.Size(59, 22)
        Me.TxDesdeSerie.TabIndex = 100292
        Me.TxDesdeSerie.TeclaRepetida = False
        Me.TxDesdeSerie.TxDatoFinalSemana = Nothing
        Me.TxDesdeSerie.TxDatoInicioSemana = Nothing
        Me.TxDesdeSerie.UltimoValorValidado = Nothing
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(672, 73)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100296
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(772, 71)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(301, 20)
        Me.CbEmpresas.TabIndex = 100295
        '
        'chkDetallarFacturas
        '
        Me.chkDetallarFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDetallarFacturas.AutoSize = True
        Me.chkDetallarFacturas.Campobd = Nothing
        Me.chkDetallarFacturas.ClForm = Nothing
        Me.chkDetallarFacturas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetallarFacturas.ForeColor = System.Drawing.Color.Teal
        Me.chkDetallarFacturas.GridLin = Nothing
        Me.chkDetallarFacturas.HaCambiado = False
        Me.chkDetallarFacturas.Location = New System.Drawing.Point(490, 71)
        Me.chkDetallarFacturas.MiEntidad = Nothing
        Me.chkDetallarFacturas.MiError = False
        Me.chkDetallarFacturas.Name = "chkDetallarFacturas"
        Me.chkDetallarFacturas.Orden = 0
        Me.chkDetallarFacturas.SaltoAlfinal = False
        Me.chkDetallarFacturas.Size = New System.Drawing.Size(148, 20)
        Me.chkDetallarFacturas.TabIndex = 100279
        Me.chkDetallarFacturas.Text = "Detallar facturas"
        Me.chkDetallarFacturas.UseVisualStyleBackColor = True
        Me.chkDetallarFacturas.ValorCampoFalse = Nothing
        Me.chkDetallarFacturas.ValorCampoTrue = Nothing
        Me.chkDetallarFacturas.ValorDefecto = False
        '
        'RbSICobradas
        '
        Me.RbSICobradas.AutoSize = True
        Me.RbSICobradas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSICobradas.ForeColor = System.Drawing.Color.Teal
        Me.RbSICobradas.Location = New System.Drawing.Point(24, 18)
        Me.RbSICobradas.Name = "RbSICobradas"
        Me.RbSICobradas.Size = New System.Drawing.Size(41, 20)
        Me.RbSICobradas.TabIndex = 0
        Me.RbSICobradas.Text = "SI"
        Me.RbSICobradas.UseVisualStyleBackColor = True
        '
        'RbNOCobradas
        '
        Me.RbNOCobradas.AutoSize = True
        Me.RbNOCobradas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNOCobradas.ForeColor = System.Drawing.Color.Teal
        Me.RbNOCobradas.Location = New System.Drawing.Point(85, 18)
        Me.RbNOCobradas.Name = "RbNOCobradas"
        Me.RbNOCobradas.Size = New System.Drawing.Size(47, 20)
        Me.RbNOCobradas.TabIndex = 1
        Me.RbNOCobradas.Text = "NO"
        Me.RbNOCobradas.UseVisualStyleBackColor = True
        '
        'RbTodasCobradas
        '
        Me.RbTodasCobradas.AutoSize = True
        Me.RbTodasCobradas.Checked = True
        Me.RbTodasCobradas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodasCobradas.ForeColor = System.Drawing.Color.Teal
        Me.RbTodasCobradas.Location = New System.Drawing.Point(154, 18)
        Me.RbTodasCobradas.Name = "RbTodasCobradas"
        Me.RbTodasCobradas.Size = New System.Drawing.Size(69, 20)
        Me.RbTodasCobradas.TabIndex = 2
        Me.RbTodasCobradas.TabStop = True
        Me.RbTodasCobradas.Text = "Todas"
        Me.RbTodasCobradas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodasCobradas)
        Me.GroupBox2.Controls.Add(Me.RbNOCobradas)
        Me.GroupBox2.Controls.Add(Me.RbSICobradas)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(911, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 50)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas cobradas"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(803, 100)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(270, 20)
        Me.cbPuntoVenta.TabIndex = 100298
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(672, 102)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(118, 16)
        Me.Lb8.TabIndex = 100297
        Me.Lb8.Text = "Punto de venta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbFechaSalida)
        Me.GroupBox1.Controls.Add(Me.RbFechaFactura)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(250, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 50)
        Me.GroupBox1.TabIndex = 100299
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por fecha"
        '
        'RbFechaSalida
        '
        Me.RbFechaSalida.AutoSize = True
        Me.RbFechaSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaSalida.Location = New System.Drawing.Point(125, 20)
        Me.RbFechaSalida.Name = "RbFechaSalida"
        Me.RbFechaSalida.Size = New System.Drawing.Size(92, 20)
        Me.RbFechaSalida.TabIndex = 2
        Me.RbFechaSalida.Text = "de Salida"
        Me.RbFechaSalida.UseVisualStyleBackColor = True
        '
        'RbFechaFactura
        '
        Me.RbFechaFactura.AutoSize = True
        Me.RbFechaFactura.Checked = True
        Me.RbFechaFactura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaFactura.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaFactura.Location = New System.Drawing.Point(14, 20)
        Me.RbFechaFactura.Name = "RbFechaFactura"
        Me.RbFechaFactura.Size = New System.Drawing.Size(104, 20)
        Me.RbFechaFactura.TabIndex = 0
        Me.RbFechaFactura.TabStop = True
        Me.RbFechaFactura.Text = "de Factura"
        Me.RbFechaFactura.UseVisualStyleBackColor = True
        '
        'ChkEuros
        '
        Me.ChkEuros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEuros.AutoSize = True
        Me.ChkEuros.Campobd = Nothing
        Me.ChkEuros.ClForm = Nothing
        Me.ChkEuros.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEuros.ForeColor = System.Drawing.Color.Teal
        Me.ChkEuros.GridLin = Nothing
        Me.ChkEuros.HaCambiado = False
        Me.ChkEuros.Location = New System.Drawing.Point(490, 100)
        Me.ChkEuros.MiEntidad = Nothing
        Me.ChkEuros.MiError = False
        Me.ChkEuros.Name = "ChkEuros"
        Me.ChkEuros.Orden = 0
        Me.ChkEuros.SaltoAlfinal = False
        Me.ChkEuros.Size = New System.Drawing.Size(174, 20)
        Me.ChkEuros.TabIndex = 100300
        Me.ChkEuros.Text = "Resultados en Euros"
        Me.ChkEuros.UseVisualStyleBackColor = True
        Me.ChkEuros.ValorCampoFalse = Nothing
        Me.ChkEuros.ValorCampoTrue = Nothing
        Me.ChkEuros.ValorDefecto = False
        '
        'chkListadoSeguro
        '
        Me.chkListadoSeguro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkListadoSeguro.AutoSize = True
        Me.chkListadoSeguro.Campobd = Nothing
        Me.chkListadoSeguro.ClForm = Nothing
        Me.chkListadoSeguro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkListadoSeguro.ForeColor = System.Drawing.Color.Teal
        Me.chkListadoSeguro.GridLin = Nothing
        Me.chkListadoSeguro.HaCambiado = False
        Me.chkListadoSeguro.Location = New System.Drawing.Point(1090, 100)
        Me.chkListadoSeguro.MiEntidad = Nothing
        Me.chkListadoSeguro.MiError = False
        Me.chkListadoSeguro.Name = "chkListadoSeguro"
        Me.chkListadoSeguro.Orden = 0
        Me.chkListadoSeguro.SaltoAlfinal = False
        Me.chkListadoSeguro.Size = New System.Drawing.Size(135, 20)
        Me.chkListadoSeguro.TabIndex = 100301
        Me.chkListadoSeguro.Text = "Listado Seguro"
        Me.chkListadoSeguro.UseVisualStyleBackColor = True
        Me.chkListadoSeguro.ValorCampoFalse = Nothing
        Me.chkListadoSeguro.ValorCampoTrue = Nothing
        Me.chkListadoSeguro.ValorDefecto = False
        '
        'FrmListadoFacturasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoFacturasClientes"
        Me.Text = "Listado de facturas de clientes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaCliente As NetAgro.TxDato
    Friend WithEvents LbHastaCliente As NetAgro.Lb
    Friend WithEvents TxDesdeCliente As NetAgro.TxDato
    Friend WithEvents LbDesdeCliente As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbNomHastaCliente As NetAgro.Lb
    Friend WithEvents BtBuscaHastaCliente As NetAgro.BtBusca
    Friend WithEvents LbNomDesdeCliente As NetAgro.Lb
    Friend WithEvents BtBuscaDesdeCliente As NetAgro.BtBusca
    Friend WithEvents TxHastaSerie As NetAgro.TxDato
    Friend WithEvents LbDesdeSerie As NetAgro.Lb
    Friend WithEvents LbHastaSerie As NetAgro.Lb
    Friend WithEvents TxDesdeSerie As NetAgro.TxDato
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents chkDetallarFacturas As NetAgro.Chk
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodasCobradas As System.Windows.Forms.RadioButton
    Friend WithEvents RbNOCobradas As System.Windows.Forms.RadioButton
    Friend WithEvents RbSICobradas As System.Windows.Forms.RadioButton
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFechaSalida As System.Windows.Forms.RadioButton
    Friend WithEvents RbFechaFactura As System.Windows.Forms.RadioButton
    Friend WithEvents ChkEuros As NetAgro.Chk
    Friend WithEvents chkListadoSeguro As NetAgro.Chk
End Class
