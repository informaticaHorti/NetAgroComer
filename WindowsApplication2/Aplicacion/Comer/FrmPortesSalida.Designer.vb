<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPortesSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPortesSalida))
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
        Me.LbPVenta = New NetAgro.Lb(Me.components)
        Me.CbTipoPorte = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbHastaTransp = New NetAgro.Lb(Me.components)
        Me.LbDesdeTransp = New NetAgro.Lb(Me.components)
        Me.TxHastaTransp = New NetAgro.TxDato(Me.components)
        Me.LbNomHastaTransp = New NetAgro.Lb(Me.components)
        Me.LbNomDesdeTransp = New NetAgro.Lb(Me.components)
        Me.TxDesdeTransp = New NetAgro.TxDato(Me.components)
        Me.BtBuscaHastaTransp = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaDesdeTrasnp = New NetAgro.BtBusca(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbTipoPorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbHastaTransp)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeTransp)
        Me.PanelCabecera.Controls.Add(Me.TxHastaTransp)
        Me.PanelCabecera.Controls.Add(Me.LbNomHastaTransp)
        Me.PanelCabecera.Controls.Add(Me.LbNomDesdeTransp)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeTransp)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaTransp)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeTrasnp)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.LbNomClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.LbNomClienteDesde)
        Me.PanelCabecera.Controls.Add(Me.LbPVenta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.CbTipoPorte)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.TxClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.TxClienteDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaClienteDesde)
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
        Me.TxClienteDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClienteDesde.ClForm = Nothing
        Me.TxClienteDesde.ClParam = Nothing
        Me.TxClienteDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteDesde.GridLin = Nothing
        Me.TxClienteDesde.HaCambiado = False
        Me.TxClienteDesde.lbbusca = Nothing
        Me.TxClienteDesde.Location = New System.Drawing.Point(146, 67)
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
        Me.BtBuscaClienteDesde.Location = New System.Drawing.Point(215, 67)
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
        Me.LbDesdeCliente.Location = New System.Drawing.Point(12, 70)
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
        Me.LbNomClienteDesde.Location = New System.Drawing.Point(254, 67)
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
        Me.LbNomClienteHasta.Location = New System.Drawing.Point(254, 94)
        Me.LbNomClienteHasta.Name = "LbNomClienteHasta"
        Me.LbNomClienteHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomClienteHasta.TabIndex = 79
        '
        'TxClienteHasta
        '
        Me.TxClienteHasta.Autonumerico = False
        Me.TxClienteHasta.Buscando = False
        Me.TxClienteHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClienteHasta.ClForm = Nothing
        Me.TxClienteHasta.ClParam = Nothing
        Me.TxClienteHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteHasta.GridLin = Nothing
        Me.TxClienteHasta.HaCambiado = False
        Me.TxClienteHasta.lbbusca = Nothing
        Me.TxClienteHasta.Location = New System.Drawing.Point(146, 94)
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
        Me.BtBuscaClienteHasta.Location = New System.Drawing.Point(215, 94)
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
        Me.LbHastaCliente.Location = New System.Drawing.Point(12, 97)
        Me.LbHastaCliente.Name = "LbHastaCliente"
        Me.LbHastaCliente.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaCliente.TabIndex = 76
        Me.LbHastaCliente.Text = "Hasta Cliente"
        '
        'TxFechaHasta
        '
        Me.TxFechaHasta.Autonumerico = False
        Me.TxFechaHasta.Buscando = False
        Me.TxFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaHasta.ClForm = Nothing
        Me.TxFechaHasta.ClParam = Nothing
        Me.TxFechaHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaHasta.GridLin = Nothing
        Me.TxFechaHasta.HaCambiado = False
        Me.TxFechaHasta.lbbusca = Nothing
        Me.TxFechaHasta.Location = New System.Drawing.Point(879, 39)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(745, 42)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxFechaDesde
        '
        Me.TxFechaDesde.Autonumerico = False
        Me.TxFechaDesde.Buscando = False
        Me.TxFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaDesde.ClForm = Nothing
        Me.TxFechaDesde.ClParam = Nothing
        Me.TxFechaDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaDesde.GridLin = Nothing
        Me.TxFechaDesde.HaCambiado = False
        Me.TxFechaDesde.lbbusca = Nothing
        Me.TxFechaDesde.Location = New System.Drawing.Point(879, 12)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(745, 15)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
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
        Me.LbPVenta.Location = New System.Drawing.Point(745, 71)
        Me.LbPVenta.Name = "LbPVenta"
        Me.LbPVenta.Size = New System.Drawing.Size(81, 16)
        Me.LbPVenta.TabIndex = 100285
        Me.LbPVenta.Text = "Tipo Porte"
        '
        'CbTipoPorte
        '
        Me.CbTipoPorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTipoPorte.EditValue = ""
        Me.CbTipoPorte.Location = New System.Drawing.Point(842, 69)
        Me.CbTipoPorte.Name = "CbTipoPorte"
        Me.CbTipoPorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbTipoPorte.Size = New System.Drawing.Size(311, 20)
        Me.CbTipoPorte.TabIndex = 100284
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(745, 96)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100302
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(842, 95)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(311, 20)
        Me.CbEmpresas.TabIndex = 100301
        '
        'LbHastaTransp
        '
        Me.LbHastaTransp.AutoSize = True
        Me.LbHastaTransp.CL_ControlAsociado = Nothing
        Me.LbHastaTransp.CL_ValorFijo = False
        Me.LbHastaTransp.ClForm = Nothing
        Me.LbHastaTransp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaTransp.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaTransp.Location = New System.Drawing.Point(12, 38)
        Me.LbHastaTransp.Name = "LbHastaTransp"
        Me.LbHastaTransp.Size = New System.Drawing.Size(104, 16)
        Me.LbHastaTransp.TabIndex = 100307
        Me.LbHastaTransp.Text = "Hasta Transp"
        '
        'LbDesdeTransp
        '
        Me.LbDesdeTransp.AutoSize = True
        Me.LbDesdeTransp.CL_ControlAsociado = Nothing
        Me.LbDesdeTransp.CL_ValorFijo = False
        Me.LbDesdeTransp.ClForm = Nothing
        Me.LbDesdeTransp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeTransp.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeTransp.Location = New System.Drawing.Point(12, 11)
        Me.LbDesdeTransp.Name = "LbDesdeTransp"
        Me.LbDesdeTransp.Size = New System.Drawing.Size(106, 16)
        Me.LbDesdeTransp.TabIndex = 100303
        Me.LbDesdeTransp.Text = "Desde Transp"
        '
        'TxHastaTransp
        '
        Me.TxHastaTransp.Autonumerico = False
        Me.TxHastaTransp.Buscando = False
        Me.TxHastaTransp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaTransp.ClForm = Nothing
        Me.TxHastaTransp.ClParam = Nothing
        Me.TxHastaTransp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaTransp.GridLin = Nothing
        Me.TxHastaTransp.HaCambiado = False
        Me.TxHastaTransp.lbbusca = Nothing
        Me.TxHastaTransp.Location = New System.Drawing.Point(146, 35)
        Me.TxHastaTransp.MiError = False
        Me.TxHastaTransp.Name = "TxHastaTransp"
        Me.TxHastaTransp.Orden = 0
        Me.TxHastaTransp.SaltoAlfinal = False
        Me.TxHastaTransp.Siguiente = 0
        Me.TxHastaTransp.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaTransp.TabIndex = 100309
        Me.TxHastaTransp.TeclaRepetida = False
        Me.TxHastaTransp.TxDatoFinalSemana = Nothing
        Me.TxHastaTransp.TxDatoInicioSemana = Nothing
        Me.TxHastaTransp.UltimoValorValidado = Nothing
        '
        'LbNomHastaTransp
        '
        Me.LbNomHastaTransp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomHastaTransp.CL_ControlAsociado = Nothing
        Me.LbNomHastaTransp.CL_ValorFijo = False
        Me.LbNomHastaTransp.ClForm = Nothing
        Me.LbNomHastaTransp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomHastaTransp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomHastaTransp.Location = New System.Drawing.Point(254, 36)
        Me.LbNomHastaTransp.Name = "LbNomHastaTransp"
        Me.LbNomHastaTransp.Size = New System.Drawing.Size(447, 23)
        Me.LbNomHastaTransp.TabIndex = 100310
        '
        'LbNomDesdeTransp
        '
        Me.LbNomDesdeTransp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDesdeTransp.CL_ControlAsociado = Nothing
        Me.LbNomDesdeTransp.CL_ValorFijo = False
        Me.LbNomDesdeTransp.ClForm = Nothing
        Me.LbNomDesdeTransp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeTransp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeTransp.Location = New System.Drawing.Point(254, 8)
        Me.LbNomDesdeTransp.Name = "LbNomDesdeTransp"
        Me.LbNomDesdeTransp.Size = New System.Drawing.Size(447, 23)
        Me.LbNomDesdeTransp.TabIndex = 100306
        '
        'TxDesdeTransp
        '
        Me.TxDesdeTransp.Autonumerico = False
        Me.TxDesdeTransp.Buscando = False
        Me.TxDesdeTransp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeTransp.ClForm = Nothing
        Me.TxDesdeTransp.ClParam = Nothing
        Me.TxDesdeTransp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeTransp.GridLin = Nothing
        Me.TxDesdeTransp.HaCambiado = False
        Me.TxDesdeTransp.lbbusca = Nothing
        Me.TxDesdeTransp.Location = New System.Drawing.Point(146, 8)
        Me.TxDesdeTransp.MiError = False
        Me.TxDesdeTransp.Name = "TxDesdeTransp"
        Me.TxDesdeTransp.Orden = 0
        Me.TxDesdeTransp.SaltoAlfinal = False
        Me.TxDesdeTransp.Siguiente = 0
        Me.TxDesdeTransp.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeTransp.TabIndex = 100305
        Me.TxDesdeTransp.TeclaRepetida = False
        Me.TxDesdeTransp.TxDatoFinalSemana = Nothing
        Me.TxDesdeTransp.TxDatoInicioSemana = Nothing
        Me.TxDesdeTransp.UltimoValorValidado = Nothing
        '
        'BtBuscaHastaTransp
        '
        Me.BtBuscaHastaTransp.CL_Ancho = 0
        Me.BtBuscaHastaTransp.CL_BuscaAlb = False
        Me.BtBuscaHastaTransp.CL_campocodigo = Nothing
        Me.BtBuscaHastaTransp.CL_camponombre = Nothing
        Me.BtBuscaHastaTransp.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaTransp.CL_ch1000 = False
        Me.BtBuscaHastaTransp.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaTransp.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaTransp.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaTransp.CL_dfecha = Nothing
        Me.BtBuscaHastaTransp.CL_Entidad = Nothing
        Me.BtBuscaHastaTransp.CL_EsId = True
        Me.BtBuscaHastaTransp.CL_Filtro = Nothing
        Me.BtBuscaHastaTransp.cl_formu = Nothing
        Me.BtBuscaHastaTransp.CL_hfecha = Nothing
        Me.BtBuscaHastaTransp.cl_ListaW = Nothing
        Me.BtBuscaHastaTransp.CL_xCentro = False
        Me.BtBuscaHastaTransp.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaTransp.Location = New System.Drawing.Point(215, 35)
        Me.BtBuscaHastaTransp.Name = "BtBuscaHastaTransp"
        Me.BtBuscaHastaTransp.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaTransp.TabIndex = 100308
        Me.BtBuscaHastaTransp.UseVisualStyleBackColor = True
        '
        'BtBuscaDesdeTrasnp
        '
        Me.BtBuscaDesdeTrasnp.CL_Ancho = 0
        Me.BtBuscaDesdeTrasnp.CL_BuscaAlb = False
        Me.BtBuscaDesdeTrasnp.CL_campocodigo = Nothing
        Me.BtBuscaDesdeTrasnp.CL_camponombre = Nothing
        Me.BtBuscaDesdeTrasnp.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeTrasnp.CL_ch1000 = False
        Me.BtBuscaDesdeTrasnp.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeTrasnp.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeTrasnp.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeTrasnp.CL_dfecha = Nothing
        Me.BtBuscaDesdeTrasnp.CL_Entidad = Nothing
        Me.BtBuscaDesdeTrasnp.CL_EsId = True
        Me.BtBuscaDesdeTrasnp.CL_Filtro = Nothing
        Me.BtBuscaDesdeTrasnp.cl_formu = Nothing
        Me.BtBuscaDesdeTrasnp.CL_hfecha = Nothing
        Me.BtBuscaDesdeTrasnp.cl_ListaW = Nothing
        Me.BtBuscaDesdeTrasnp.CL_xCentro = False
        Me.BtBuscaDesdeTrasnp.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeTrasnp.Location = New System.Drawing.Point(215, 8)
        Me.BtBuscaDesdeTrasnp.Name = "BtBuscaDesdeTrasnp"
        Me.BtBuscaDesdeTrasnp.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeTrasnp.TabIndex = 100304
        Me.BtBuscaDesdeTrasnp.UseVisualStyleBackColor = True
        '
        'FrmPortesSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 570)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPortesSalida"
        Me.Text = "Listado Portes de Salida"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbTipoPorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents LbPVenta As NetAgro.Lb
    Friend WithEvents CbTipoPorte As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbHastaTransp As NetAgro.Lb
    Friend WithEvents LbDesdeTransp As NetAgro.Lb
    Friend WithEvents TxHastaTransp As NetAgro.TxDato
    Friend WithEvents LbNomHastaTransp As NetAgro.Lb
    Friend WithEvents LbNomDesdeTransp As NetAgro.Lb
    Friend WithEvents TxDesdeTransp As NetAgro.TxDato
    Friend WithEvents BtBuscaHastaTransp As NetAgro.BtBusca
    Friend WithEvents BtBuscaDesdeTrasnp As NetAgro.BtBusca
End Class
