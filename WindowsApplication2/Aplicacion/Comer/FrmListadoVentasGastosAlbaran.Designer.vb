<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoVentasGastosAlbaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoVentasGastosAlbaran))
        Me.TxClienteDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaClienteDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeCliente = New NetAgro.Lb(Me.components)
        Me.LbNomClienteDesde = New NetAgro.Lb(Me.components)
        Me.LbNomClienteHasta = New NetAgro.Lb(Me.components)
        Me.TxClienteHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaClienteHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaCliente = New NetAgro.Lb(Me.components)
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RbComision = New System.Windows.Forms.RadioButton()
        Me.RbFirme = New System.Windows.Forms.RadioButton()
        Me.LbPVenta = New NetAgro.Lb(Me.components)
        Me.CbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTodosValorado = New System.Windows.Forms.RadioButton()
        Me.RbNoValorado = New System.Windows.Forms.RadioButton()
        Me.RbSiValorado = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTodosFacturados = New System.Windows.Forms.RadioButton()
        Me.RbNoFacturados = New System.Windows.Forms.RadioButton()
        Me.RbSiFacturados = New System.Windows.Forms.RadioButton()
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.LbNomClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.LbPVenta)
        Me.PanelCabecera.Controls.Add(Me.CbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 130)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 130)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 406)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(934, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1009, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1084, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1159, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxClienteDesde
        '
        Me.TxClienteDesde.Autonumerico = False
        Me.TxClienteDesde.Buscando = False
        Me.TxClienteDesde.ClForm = Nothing
        Me.TxClienteDesde.ClParam = Nothing
        Me.TxClienteDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteDesde.GridLin = Nothing
        Me.TxClienteDesde.HaCambiado = False
        Me.TxClienteDesde.lbbusca = Nothing
        Me.TxClienteDesde.Location = New System.Drawing.Point(146, 8)
        Me.TxClienteDesde.MiError = False
        Me.TxClienteDesde.Name = "TxClienteDesde"
        Me.TxClienteDesde.Orden = 0
        Me.TxClienteDesde.SaltoAlfinal = False
        Me.TxClienteDesde.Siguiente = 0
        Me.TxClienteDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteDesde.TabIndex = 51
        Me.TxClienteDesde.TeclaRepetida = False
        Me.TxClienteDesde.TxDatoFinalSemana = Nothing
        Me.TxClienteDesde.TxDatoInicioSemana = Nothing
        Me.TxClienteDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaClienteDesde
        '
        Me.BtBuscaClienteDesde.CL_Ancho = 0
        Me.BtBuscaClienteDesde.CL_BuscaAlb = False
        Me.BtBuscaClienteDesde.CL_campocodigo = Nothing
        Me.BtBuscaClienteDesde.CL_camponombre = Nothing
        Me.BtBuscaClienteDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaClienteDesde.CL_ch1000 = False
        Me.BtBuscaClienteDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaClienteDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaClienteDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaClienteDesde.CL_dfecha = Nothing
        Me.BtBuscaClienteDesde.CL_Entidad = Nothing
        Me.BtBuscaClienteDesde.CL_EsId = True
        Me.BtBuscaClienteDesde.CL_Filtro = Nothing
        Me.BtBuscaClienteDesde.cl_formu = Nothing
        Me.BtBuscaClienteDesde.CL_hfecha = Nothing
        Me.BtBuscaClienteDesde.cl_ListaW = Nothing
        Me.BtBuscaClienteDesde.CL_xCentro = False
        Me.BtBuscaClienteDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaClienteDesde.Location = New System.Drawing.Point(215, 8)
        Me.BtBuscaClienteDesde.Name = "BtBuscaClienteDesde"
        Me.BtBuscaClienteDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaClienteDesde.TabIndex = 50
        Me.BtBuscaClienteDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeCliente
        '
        Me.LbDesdeCliente.AutoSize = True
        Me.LbDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbDesdeCliente.CL_ValorFijo = False
        Me.LbDesdeCliente.ClForm = Nothing
        Me.LbDesdeCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeCliente.Location = New System.Drawing.Point(12, 11)
        Me.LbDesdeCliente.Name = "LbDesdeCliente"
        Me.LbDesdeCliente.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeCliente.TabIndex = 49
        Me.LbDesdeCliente.Text = "Desde Cliente"
        '
        'LbNomClienteDesde
        '
        Me.LbNomClienteDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomClienteDesde.CL_ControlAsociado = Nothing
        Me.LbNomClienteDesde.CL_ValorFijo = False
        Me.LbNomClienteDesde.ClForm = Nothing
        Me.LbNomClienteDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomClienteDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomClienteDesde.Location = New System.Drawing.Point(254, 8)
        Me.LbNomClienteDesde.Name = "LbNomClienteDesde"
        Me.LbNomClienteDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomClienteDesde.TabIndex = 75
        '
        'LbNomClienteHasta
        '
        Me.LbNomClienteHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomClienteHasta.CL_ControlAsociado = Nothing
        Me.LbNomClienteHasta.CL_ValorFijo = False
        Me.LbNomClienteHasta.ClForm = Nothing
        Me.LbNomClienteHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomClienteHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomClienteHasta.Location = New System.Drawing.Point(254, 36)
        Me.LbNomClienteHasta.Name = "LbNomClienteHasta"
        Me.LbNomClienteHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomClienteHasta.TabIndex = 79
        '
        'TxClienteHasta
        '
        Me.TxClienteHasta.Autonumerico = False
        Me.TxClienteHasta.Buscando = False
        Me.TxClienteHasta.ClForm = Nothing
        Me.TxClienteHasta.ClParam = Nothing
        Me.TxClienteHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteHasta.GridLin = Nothing
        Me.TxClienteHasta.HaCambiado = False
        Me.TxClienteHasta.lbbusca = Nothing
        Me.TxClienteHasta.Location = New System.Drawing.Point(146, 35)
        Me.TxClienteHasta.MiError = False
        Me.TxClienteHasta.Name = "TxClienteHasta"
        Me.TxClienteHasta.Orden = 0
        Me.TxClienteHasta.SaltoAlfinal = False
        Me.TxClienteHasta.Siguiente = 0
        Me.TxClienteHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteHasta.TabIndex = 78
        Me.TxClienteHasta.TeclaRepetida = False
        Me.TxClienteHasta.TxDatoFinalSemana = Nothing
        Me.TxClienteHasta.TxDatoInicioSemana = Nothing
        Me.TxClienteHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaClienteHasta
        '
        Me.BtBuscaClienteHasta.CL_Ancho = 0
        Me.BtBuscaClienteHasta.CL_BuscaAlb = False
        Me.BtBuscaClienteHasta.CL_campocodigo = Nothing
        Me.BtBuscaClienteHasta.CL_camponombre = Nothing
        Me.BtBuscaClienteHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaClienteHasta.CL_ch1000 = False
        Me.BtBuscaClienteHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaClienteHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaClienteHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaClienteHasta.CL_dfecha = Nothing
        Me.BtBuscaClienteHasta.CL_Entidad = Nothing
        Me.BtBuscaClienteHasta.CL_EsId = True
        Me.BtBuscaClienteHasta.CL_Filtro = Nothing
        Me.BtBuscaClienteHasta.cl_formu = Nothing
        Me.BtBuscaClienteHasta.CL_hfecha = Nothing
        Me.BtBuscaClienteHasta.cl_ListaW = Nothing
        Me.BtBuscaClienteHasta.CL_xCentro = False
        Me.BtBuscaClienteHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaClienteHasta.Location = New System.Drawing.Point(215, 35)
        Me.BtBuscaClienteHasta.Name = "BtBuscaClienteHasta"
        Me.BtBuscaClienteHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaClienteHasta.TabIndex = 77
        Me.BtBuscaClienteHasta.UseVisualStyleBackColor = True
        '
        'LbHastaCliente
        '
        Me.LbHastaCliente.AutoSize = True
        Me.LbHastaCliente.CL_ControlAsociado = Nothing
        Me.LbHastaCliente.CL_ValorFijo = False
        Me.LbHastaCliente.ClForm = Nothing
        Me.LbHastaCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaCliente.Location = New System.Drawing.Point(12, 38)
        Me.LbHastaCliente.Name = "LbHastaCliente"
        Me.LbHastaCliente.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaCliente.TabIndex = 76
        Me.LbHastaCliente.Text = "Hasta Cliente"
        '
        'TxFechaHasta
        '
        Me.TxFechaHasta.Autonumerico = False
        Me.TxFechaHasta.Buscando = False
        Me.TxFechaHasta.ClForm = Nothing
        Me.TxFechaHasta.ClParam = Nothing
        Me.TxFechaHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaHasta.GridLin = Nothing
        Me.TxFechaHasta.HaCambiado = False
        Me.TxFechaHasta.lbbusca = Nothing
        Me.TxFechaHasta.Location = New System.Drawing.Point(146, 96)
        Me.TxFechaHasta.MiError = False
        Me.TxFechaHasta.Name = "TxFechaHasta"
        Me.TxFechaHasta.Orden = 0
        Me.TxFechaHasta.SaltoAlfinal = False
        Me.TxFechaHasta.Siguiente = 0
        Me.TxFechaHasta.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaHasta.TabIndex = 83
        Me.TxFechaHasta.TeclaRepetida = False
        Me.TxFechaHasta.TxDatoFinalSemana = Nothing
        Me.TxFechaHasta.TxDatoInicioSemana = Nothing
        Me.TxFechaHasta.UltimoValorValidado = Nothing
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(12, 99)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxFechaDesde
        '
        Me.TxFechaDesde.Autonumerico = False
        Me.TxFechaDesde.Buscando = False
        Me.TxFechaDesde.ClForm = Nothing
        Me.TxFechaDesde.ClParam = Nothing
        Me.TxFechaDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaDesde.GridLin = Nothing
        Me.TxFechaDesde.HaCambiado = False
        Me.TxFechaDesde.lbbusca = Nothing
        Me.TxFechaDesde.Location = New System.Drawing.Point(146, 69)
        Me.TxFechaDesde.MiError = False
        Me.TxFechaDesde.Name = "TxFechaDesde"
        Me.TxFechaDesde.Orden = 0
        Me.TxFechaDesde.SaltoAlfinal = False
        Me.TxFechaDesde.Siguiente = 0
        Me.TxFechaDesde.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaDesde.TabIndex = 81
        Me.TxFechaDesde.TeclaRepetida = False
        Me.TxFechaDesde.TxDatoFinalSemana = Nothing
        Me.TxFechaDesde.TxDatoInicioSemana = Nothing
        Me.TxFechaDesde.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(12, 72)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodos)
        Me.GroupBox2.Controls.Add(Me.RbComision)
        Me.GroupBox2.Controls.Add(Me.RbFirme)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(752, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 51)
        Me.GroupBox2.TabIndex = 100274
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Venta"
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Checked = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbTodos.Location = New System.Drawing.Point(189, 16)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbTodos.TabIndex = 3
        Me.RbTodos.TabStop = True
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RbComision
        '
        Me.RbComision.AutoSize = True
        Me.RbComision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbComision.ForeColor = System.Drawing.Color.Teal
        Me.RbComision.Location = New System.Drawing.Point(90, 16)
        Me.RbComision.Name = "RbComision"
        Me.RbComision.Size = New System.Drawing.Size(93, 20)
        Me.RbComision.TabIndex = 2
        Me.RbComision.Text = "Comisión"
        Me.RbComision.UseVisualStyleBackColor = True
        '
        'RbFirme
        '
        Me.RbFirme.AutoSize = True
        Me.RbFirme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFirme.ForeColor = System.Drawing.Color.Teal
        Me.RbFirme.Location = New System.Drawing.Point(16, 16)
        Me.RbFirme.Name = "RbFirme"
        Me.RbFirme.Size = New System.Drawing.Size(68, 20)
        Me.RbFirme.TabIndex = 0
        Me.RbFirme.Text = "Firme"
        Me.RbFirme.UseVisualStyleBackColor = True
        '
        'LbPVenta
        '
        Me.LbPVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbPVenta.AutoSize = True
        Me.LbPVenta.CL_ControlAsociado = Nothing
        Me.LbPVenta.CL_ValorFijo = True
        Me.LbPVenta.ClForm = Nothing
        Me.LbPVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPVenta.Location = New System.Drawing.Point(749, 15)
        Me.LbPVenta.Name = "LbPVenta"
        Me.LbPVenta.Size = New System.Drawing.Size(69, 16)
        Me.LbPVenta.TabIndex = 100285
        Me.LbPVenta.Text = "P. Venta"
        '
        'CbPuntoVenta
        '
        Me.CbPuntoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPuntoVenta.EditValue = ""
        Me.CbPuntoVenta.Location = New System.Drawing.Point(846, 13)
        Me.CbPuntoVenta.Name = "CbPuntoVenta"
        Me.CbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPuntoVenta.Size = New System.Drawing.Size(311, 20)
        Me.CbPuntoVenta.TabIndex = 100284
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTodosValorado)
        Me.GroupBox1.Controls.Add(Me.RbNoValorado)
        Me.GroupBox1.Controls.Add(Me.RbSiValorado)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(502, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 51)
        Me.GroupBox1.TabIndex = 100275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alb. Valorados"
        '
        'RbTodosValorado
        '
        Me.RbTodosValorado.AutoSize = True
        Me.RbTodosValorado.Checked = True
        Me.RbTodosValorado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosValorado.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosValorado.Location = New System.Drawing.Point(112, 16)
        Me.RbTodosValorado.Name = "RbTodosValorado"
        Me.RbTodosValorado.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosValorado.TabIndex = 3
        Me.RbTodosValorado.TabStop = True
        Me.RbTodosValorado.Text = "Todos"
        Me.RbTodosValorado.UseVisualStyleBackColor = True
        '
        'RbNoValorado
        '
        Me.RbNoValorado.AutoSize = True
        Me.RbNoValorado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoValorado.ForeColor = System.Drawing.Color.Teal
        Me.RbNoValorado.Location = New System.Drawing.Point(61, 16)
        Me.RbNoValorado.Name = "RbNoValorado"
        Me.RbNoValorado.Size = New System.Drawing.Size(45, 20)
        Me.RbNoValorado.TabIndex = 2
        Me.RbNoValorado.Text = "No"
        Me.RbNoValorado.UseVisualStyleBackColor = True
        '
        'RbSiValorado
        '
        Me.RbSiValorado.AutoSize = True
        Me.RbSiValorado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiValorado.ForeColor = System.Drawing.Color.Teal
        Me.RbSiValorado.Location = New System.Drawing.Point(16, 16)
        Me.RbSiValorado.Name = "RbSiValorado"
        Me.RbSiValorado.Size = New System.Drawing.Size(39, 20)
        Me.RbSiValorado.TabIndex = 0
        Me.RbSiValorado.Text = "Si"
        Me.RbSiValorado.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTodosFacturados)
        Me.GroupBox3.Controls.Add(Me.RbNoFacturados)
        Me.GroupBox3.Controls.Add(Me.RbSiFacturados)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(295, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 51)
        Me.GroupBox3.TabIndex = 100276
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alb. Facturados"
        '
        'RbTodosFacturados
        '
        Me.RbTodosFacturados.AutoSize = True
        Me.RbTodosFacturados.Checked = True
        Me.RbTodosFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosFacturados.Location = New System.Drawing.Point(112, 16)
        Me.RbTodosFacturados.Name = "RbTodosFacturados"
        Me.RbTodosFacturados.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosFacturados.TabIndex = 3
        Me.RbTodosFacturados.TabStop = True
        Me.RbTodosFacturados.Text = "Todos"
        Me.RbTodosFacturados.UseVisualStyleBackColor = True
        '
        'RbNoFacturados
        '
        Me.RbNoFacturados.AutoSize = True
        Me.RbNoFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoFacturados.Location = New System.Drawing.Point(61, 16)
        Me.RbNoFacturados.Name = "RbNoFacturados"
        Me.RbNoFacturados.Size = New System.Drawing.Size(45, 20)
        Me.RbNoFacturados.TabIndex = 2
        Me.RbNoFacturados.Text = "No"
        Me.RbNoFacturados.UseVisualStyleBackColor = True
        '
        'RbSiFacturados
        '
        Me.RbSiFacturados.AutoSize = True
        Me.RbSiFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbSiFacturados.Location = New System.Drawing.Point(16, 16)
        Me.RbSiFacturados.Name = "RbSiFacturados"
        Me.RbSiFacturados.Size = New System.Drawing.Size(39, 20)
        Me.RbSiFacturados.TabIndex = 0
        Me.RbSiFacturados.Text = "Si"
        Me.RbSiFacturados.UseVisualStyleBackColor = True
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(749, 40)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100302
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(846, 39)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(311, 20)
        Me.CbEmpresas.TabIndex = 100301
        '
        'FrmListadoVentasGastosAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 570)
        Me.Controls.Add(Me.LbNomClienteDesde)
        Me.Controls.Add(Me.LbHastaCliente)
        Me.Controls.Add(Me.LbDesdeCliente)
        Me.Controls.Add(Me.TxClienteHasta)
        Me.Controls.Add(Me.TxClienteDesde)
        Me.Controls.Add(Me.BtBuscaClienteHasta)
        Me.Controls.Add(Me.BtBuscaClienteDesde)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoVentasGastosAlbaran"
        Me.Text = "Listado Ventas y Gastos por Albaran"
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaClienteDesde, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaClienteHasta, 0)
        Me.Controls.SetChildIndex(Me.TxClienteDesde, 0)
        Me.Controls.SetChildIndex(Me.TxClienteHasta, 0)
        Me.Controls.SetChildIndex(Me.LbDesdeCliente, 0)
        Me.Controls.SetChildIndex(Me.LbHastaCliente, 0)
        Me.Controls.SetChildIndex(Me.LbNomClienteDesde, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxClienteDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaClienteDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeCliente As NetAgro.Lb
    Friend WithEvents LbNomClienteDesde As NetAgro.Lb
    Friend WithEvents LbNomClienteHasta As NetAgro.Lb
    Friend WithEvents TxClienteHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaClienteHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaCliente As NetAgro.Lb
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbComision As System.Windows.Forms.RadioButton
    Friend WithEvents RbFirme As System.Windows.Forms.RadioButton
    Friend WithEvents LbPVenta As NetAgro.Lb
    Friend WithEvents CbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosValorado As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoValorado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiValorado As System.Windows.Forms.RadioButton
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
