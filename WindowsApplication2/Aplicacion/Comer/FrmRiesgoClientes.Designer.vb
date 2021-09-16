<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRiesgoClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRiesgoClientes))
        Me.TxHastaCliente = New NetAgro.TxDato(Me.components)
        Me.LbHastaCliente = New NetAgro.Lb(Me.components)
        Me.TxDesdeCliente = New NetAgro.TxDato(Me.components)
        Me.LbDesdeCliente = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbFechaFactura = New System.Windows.Forms.RadioButton()
        Me.RbFechaSalida = New System.Windows.Forms.RadioButton()
        Me.chkDetallarFacturas = New NetAgro.Chk(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.ChkAlbaranesPendientes = New NetAgro.Chk(Me.components)
        Me.TxFechaListado = New NetAgro.TxDato(Me.components)
        Me.LbFechaListado = New NetAgro.Lb(Me.components)
        Me.LbNomDesdeCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaDesdeCliente = New NetAgro.BtBusca(Me.components)
        Me.LbNomHastaCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaHastaCliente = New NetAgro.BtBusca(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbNomHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.LbNomDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.TxFechaListado)
        Me.PanelCabecera.Controls.Add(Me.LbFechaListado)
        Me.PanelCabecera.Controls.Add(Me.ChkAlbaranesPendientes)
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
        Me.TxHastaCliente.Location = New System.Drawing.Point(132, 36)
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
        Me.LbHastaCliente.Location = New System.Drawing.Point(13, 39)
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
        Me.TxDesdeCliente.Location = New System.Drawing.Point(132, 7)
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
        Me.LbDesdeCliente.Location = New System.Drawing.Point(13, 10)
        Me.LbDesdeCliente.Name = "LbDesdeCliente"
        Me.LbDesdeCliente.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeCliente.TabIndex = 80
        Me.LbDesdeCliente.Text = "Desde Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbFechaFactura)
        Me.GroupBox2.Controls.Add(Me.RbFechaSalida)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(665, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 71)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cálculo de días"
        '
        'RbFechaFactura
        '
        Me.RbFechaFactura.AutoSize = True
        Me.RbFechaFactura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaFactura.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaFactura.Location = New System.Drawing.Point(16, 46)
        Me.RbFechaFactura.Name = "RbFechaFactura"
        Me.RbFechaFactura.Size = New System.Drawing.Size(148, 20)
        Me.RbFechaFactura.TabIndex = 1
        Me.RbFechaFactura.Text = "S/Fecha Factura"
        Me.RbFechaFactura.UseVisualStyleBackColor = True
        '
        'RbFechaSalida
        '
        Me.RbFechaSalida.AutoSize = True
        Me.RbFechaSalida.Checked = True
        Me.RbFechaSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaSalida.Location = New System.Drawing.Point(16, 19)
        Me.RbFechaSalida.Name = "RbFechaSalida"
        Me.RbFechaSalida.Size = New System.Drawing.Size(136, 20)
        Me.RbFechaSalida.TabIndex = 0
        Me.RbFechaSalida.TabStop = True
        Me.RbFechaSalida.Text = "S/Fecha Salida"
        Me.RbFechaSalida.UseVisualStyleBackColor = True
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
        Me.chkDetallarFacturas.Location = New System.Drawing.Point(900, 8)
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(132, 94)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(13, 68)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(13, 97)
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(132, 65)
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
        'ChkAlbaranesPendientes
        '
        Me.ChkAlbaranesPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAlbaranesPendientes.AutoSize = True
        Me.ChkAlbaranesPendientes.Campobd = Nothing
        Me.ChkAlbaranesPendientes.ClForm = Nothing
        Me.ChkAlbaranesPendientes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAlbaranesPendientes.ForeColor = System.Drawing.Color.Teal
        Me.ChkAlbaranesPendientes.GridLin = Nothing
        Me.ChkAlbaranesPendientes.HaCambiado = False
        Me.ChkAlbaranesPendientes.Location = New System.Drawing.Point(900, 37)
        Me.ChkAlbaranesPendientes.MiEntidad = Nothing
        Me.ChkAlbaranesPendientes.MiError = False
        Me.ChkAlbaranesPendientes.Name = "ChkAlbaranesPendientes"
        Me.ChkAlbaranesPendientes.Orden = 0
        Me.ChkAlbaranesPendientes.SaltoAlfinal = False
        Me.ChkAlbaranesPendientes.Size = New System.Drawing.Size(318, 20)
        Me.ChkAlbaranesPendientes.TabIndex = 100284
        Me.ChkAlbaranesPendientes.Text = "Incluir albaranes pendientes de facturar"
        Me.ChkAlbaranesPendientes.UseVisualStyleBackColor = True
        Me.ChkAlbaranesPendientes.ValorCampoFalse = Nothing
        Me.ChkAlbaranesPendientes.ValorCampoTrue = Nothing
        Me.ChkAlbaranesPendientes.ValorDefecto = False
        '
        'TxFechaListado
        '
        Me.TxFechaListado.Autonumerico = False
        Me.TxFechaListado.Buscando = False
        Me.TxFechaListado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaListado.ClForm = Nothing
        Me.TxFechaListado.ClParam = Nothing
        Me.TxFechaListado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaListado.GridLin = Nothing
        Me.TxFechaListado.HaCambiado = False
        Me.TxFechaListado.lbbusca = Nothing
        Me.TxFechaListado.Location = New System.Drawing.Point(1016, 65)
        Me.TxFechaListado.MiError = False
        Me.TxFechaListado.Name = "TxFechaListado"
        Me.TxFechaListado.Orden = 0
        Me.TxFechaListado.SaltoAlfinal = False
        Me.TxFechaListado.Siguiente = 0
        Me.TxFechaListado.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaListado.TabIndex = 100286
        Me.TxFechaListado.TeclaRepetida = False
        Me.TxFechaListado.TxDatoFinalSemana = Nothing
        Me.TxFechaListado.TxDatoInicioSemana = Nothing
        Me.TxFechaListado.UltimoValorValidado = Nothing
        '
        'LbFechaListado
        '
        Me.LbFechaListado.AutoSize = True
        Me.LbFechaListado.CL_ControlAsociado = Nothing
        Me.LbFechaListado.CL_ValorFijo = False
        Me.LbFechaListado.ClForm = Nothing
        Me.LbFechaListado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaListado.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaListado.Location = New System.Drawing.Point(897, 68)
        Me.LbFechaListado.Name = "LbFechaListado"
        Me.LbFechaListado.Size = New System.Drawing.Size(105, 16)
        Me.LbFechaListado.TabIndex = 100285
        Me.LbFechaListado.Text = "Fecha listado"
        '
        'LbNomDesdeCliente
        '
        Me.LbNomDesdeCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbNomDesdeCliente.CL_ValorFijo = False
        Me.LbNomDesdeCliente.ClForm = Nothing
        Me.LbNomDesdeCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeCliente.Location = New System.Drawing.Point(247, 7)
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
        Me.BtBuscaDesdeCliente.Location = New System.Drawing.Point(208, 7)
        Me.BtBuscaDesdeCliente.Name = "BtBuscaDesdeCliente"
        Me.BtBuscaDesdeCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeCliente.TabIndex = 100287
        Me.BtBuscaDesdeCliente.UseVisualStyleBackColor = True
        '
        'LbNomHastaCliente
        '
        Me.LbNomHastaCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomHastaCliente.CL_ControlAsociado = Nothing
        Me.LbNomHastaCliente.CL_ValorFijo = False
        Me.LbNomHastaCliente.ClForm = Nothing
        Me.LbNomHastaCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomHastaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomHastaCliente.Location = New System.Drawing.Point(247, 34)
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
        Me.BtBuscaHastaCliente.Location = New System.Drawing.Point(208, 34)
        Me.BtBuscaHastaCliente.Name = "BtBuscaHastaCliente"
        Me.BtBuscaHastaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaCliente.TabIndex = 100289
        Me.BtBuscaHastaCliente.UseVisualStyleBackColor = True
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(358, 95)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(518, 20)
        Me.cbPuntoVenta.TabIndex = 100318
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(288, 97)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(64, 16)
        Me.Lb5.TabIndex = 100317
        Me.Lb5.Text = "P.venta"
        '
        'FrmRiesgoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmRiesgoClientes"
        Me.Text = "Listado de riesgos de clientes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaCliente As NetAgro.TxDato
    Friend WithEvents LbHastaCliente As NetAgro.Lb
    Friend WithEvents TxDesdeCliente As NetAgro.TxDato
    Friend WithEvents LbDesdeCliente As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFechaFactura As System.Windows.Forms.RadioButton
    Friend WithEvents RbFechaSalida As System.Windows.Forms.RadioButton
    Friend WithEvents chkDetallarFacturas As NetAgro.Chk
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents ChkAlbaranesPendientes As NetAgro.Chk
    Friend WithEvents TxFechaListado As NetAgro.TxDato
    Friend WithEvents LbFechaListado As NetAgro.Lb
    Friend WithEvents LbNomHastaCliente As NetAgro.Lb
    Friend WithEvents BtBuscaHastaCliente As NetAgro.BtBusca
    Friend WithEvents LbNomDesdeCliente As NetAgro.Lb
    Friend WithEvents BtBuscaDesdeCliente As NetAgro.BtBusca
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
