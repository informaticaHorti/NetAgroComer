<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaFacturasCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaFacturasCompra))
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.TxHastaAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbNom_HastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNom_DesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.TxDesdeAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaHastaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaDesdeAgricultor = New NetAgro.BtBusca(Me.components)
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbFacturasTodas = New System.Windows.Forms.RadioButton()
        Me.RbFacturasEmpresas = New System.Windows.Forms.RadioButton()
        Me.RbFacturasAgricultores = New System.Windows.Forms.RadioButton()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbNom_HastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNom_DesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 110)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 110)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 426)
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(124, 42)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 83
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(23, 45)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(124, 15)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 81
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.TxDatoFinalSemana = Nothing
        Me.TxDesdeFecha.TxDatoInicioSemana = Nothing
        Me.TxDesdeFecha.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(23, 18)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(252, 45)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(126, 16)
        Me.LbHastaAgricultor.TabIndex = 100307
        Me.LbHastaAgricultor.Text = "Hasta Agricultor"
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(252, 18)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(128, 16)
        Me.LbDesdeAgricultor.TabIndex = 100303
        Me.LbDesdeAgricultor.Text = "Desde Agricultor"
        '
        'TxHastaAgricultor
        '
        Me.TxHastaAgricultor.Autonumerico = False
        Me.TxHastaAgricultor.Buscando = False
        Me.TxHastaAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaAgricultor.ClForm = Nothing
        Me.TxHastaAgricultor.ClParam = Nothing
        Me.TxHastaAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaAgricultor.GridLin = Nothing
        Me.TxHastaAgricultor.HaCambiado = False
        Me.TxHastaAgricultor.lbbusca = Nothing
        Me.TxHastaAgricultor.Location = New System.Drawing.Point(386, 42)
        Me.TxHastaAgricultor.MiError = False
        Me.TxHastaAgricultor.Name = "TxHastaAgricultor"
        Me.TxHastaAgricultor.Orden = 0
        Me.TxHastaAgricultor.SaltoAlfinal = False
        Me.TxHastaAgricultor.Siguiente = 0
        Me.TxHastaAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaAgricultor.TabIndex = 100309
        Me.TxHastaAgricultor.TeclaRepetida = False
        Me.TxHastaAgricultor.TxDatoFinalSemana = Nothing
        Me.TxHastaAgricultor.TxDatoInicioSemana = Nothing
        Me.TxHastaAgricultor.UltimoValorValidado = Nothing
        '
        'LbNom_HastaAgricultor
        '
        Me.LbNom_HastaAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_HastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbNom_HastaAgricultor.CL_ValorFijo = False
        Me.LbNom_HastaAgricultor.ClForm = Nothing
        Me.LbNom_HastaAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_HastaAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_HastaAgricultor.Location = New System.Drawing.Point(494, 42)
        Me.LbNom_HastaAgricultor.Name = "LbNom_HastaAgricultor"
        Me.LbNom_HastaAgricultor.Size = New System.Drawing.Size(447, 23)
        Me.LbNom_HastaAgricultor.TabIndex = 100310
        '
        'LbNom_DesdeAgricultor
        '
        Me.LbNom_DesdeAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_DesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbNom_DesdeAgricultor.CL_ValorFijo = False
        Me.LbNom_DesdeAgricultor.ClForm = Nothing
        Me.LbNom_DesdeAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_DesdeAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_DesdeAgricultor.Location = New System.Drawing.Point(494, 15)
        Me.LbNom_DesdeAgricultor.Name = "LbNom_DesdeAgricultor"
        Me.LbNom_DesdeAgricultor.Size = New System.Drawing.Size(447, 23)
        Me.LbNom_DesdeAgricultor.TabIndex = 100306
        '
        'TxDesdeAgricultor
        '
        Me.TxDesdeAgricultor.Autonumerico = False
        Me.TxDesdeAgricultor.Buscando = False
        Me.TxDesdeAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeAgricultor.ClForm = Nothing
        Me.TxDesdeAgricultor.ClParam = Nothing
        Me.TxDesdeAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeAgricultor.GridLin = Nothing
        Me.TxDesdeAgricultor.HaCambiado = False
        Me.TxDesdeAgricultor.lbbusca = Nothing
        Me.TxDesdeAgricultor.Location = New System.Drawing.Point(386, 15)
        Me.TxDesdeAgricultor.MiError = False
        Me.TxDesdeAgricultor.Name = "TxDesdeAgricultor"
        Me.TxDesdeAgricultor.Orden = 0
        Me.TxDesdeAgricultor.SaltoAlfinal = False
        Me.TxDesdeAgricultor.Siguiente = 0
        Me.TxDesdeAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeAgricultor.TabIndex = 100305
        Me.TxDesdeAgricultor.TeclaRepetida = False
        Me.TxDesdeAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDesdeAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDesdeAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaHastaAgricultor
        '
        Me.BtBuscaHastaAgricultor.CL_Ancho = 0
        Me.BtBuscaHastaAgricultor.CL_BuscaAlb = False
        Me.BtBuscaHastaAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaHastaAgricultor.CL_camponombre = Nothing
        Me.BtBuscaHastaAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaAgricultor.CL_ch1000 = False
        Me.BtBuscaHastaAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaAgricultor.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaHastaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaHastaAgricultor.CL_EsId = True
        Me.BtBuscaHastaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaHastaAgricultor.cl_formu = Nothing
        Me.BtBuscaHastaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaHastaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaHastaAgricultor.CL_xCentro = False
        Me.BtBuscaHastaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaAgricultor.Location = New System.Drawing.Point(455, 42)
        Me.BtBuscaHastaAgricultor.Name = "BtBuscaHastaAgricultor"
        Me.BtBuscaHastaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaAgricultor.TabIndex = 100308
        Me.BtBuscaHastaAgricultor.UseVisualStyleBackColor = True
        '
        'BtBuscaDesdeAgricultor
        '
        Me.BtBuscaDesdeAgricultor.CL_Ancho = 0
        Me.BtBuscaDesdeAgricultor.CL_BuscaAlb = False
        Me.BtBuscaDesdeAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaDesdeAgricultor.CL_camponombre = Nothing
        Me.BtBuscaDesdeAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeAgricultor.CL_ch1000 = False
        Me.BtBuscaDesdeAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeAgricultor.CL_dfecha = Nothing
        Me.BtBuscaDesdeAgricultor.CL_Entidad = Nothing
        Me.BtBuscaDesdeAgricultor.CL_EsId = True
        Me.BtBuscaDesdeAgricultor.CL_Filtro = Nothing
        Me.BtBuscaDesdeAgricultor.cl_formu = Nothing
        Me.BtBuscaDesdeAgricultor.CL_hfecha = Nothing
        Me.BtBuscaDesdeAgricultor.cl_ListaW = Nothing
        Me.BtBuscaDesdeAgricultor.CL_xCentro = False
        Me.BtBuscaDesdeAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeAgricultor.Location = New System.Drawing.Point(455, 15)
        Me.BtBuscaDesdeAgricultor.Name = "BtBuscaDesdeAgricultor"
        Me.BtBuscaDesdeAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeAgricultor.TabIndex = 100304
        Me.BtBuscaDesdeAgricultor.UseVisualStyleBackColor = True
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(23, 78)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100326
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(124, 76)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(325, 20)
        Me.CbEmpresas.TabIndex = 100325
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbFacturasTodas)
        Me.GroupBox4.Controls.Add(Me.RbFacturasEmpresas)
        Me.GroupBox4.Controls.Add(Me.RbFacturasAgricultores)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(617, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(337, 38)
        Me.GroupBox4.TabIndex = 100327
        Me.GroupBox4.TabStop = False
        '
        'RbFacturasTodas
        '
        Me.RbFacturasTodas.AutoSize = True
        Me.RbFacturasTodas.Checked = True
        Me.RbFacturasTodas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturasTodas.ForeColor = System.Drawing.Color.Teal
        Me.RbFacturasTodas.Location = New System.Drawing.Point(258, 14)
        Me.RbFacturasTodas.Name = "RbFacturasTodas"
        Me.RbFacturasTodas.Size = New System.Drawing.Size(69, 20)
        Me.RbFacturasTodas.TabIndex = 2
        Me.RbFacturasTodas.TabStop = True
        Me.RbFacturasTodas.Text = "Todas"
        Me.RbFacturasTodas.UseVisualStyleBackColor = True
        '
        'RbFacturasEmpresas
        '
        Me.RbFacturasEmpresas.AutoSize = True
        Me.RbFacturasEmpresas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturasEmpresas.ForeColor = System.Drawing.Color.Teal
        Me.RbFacturasEmpresas.Location = New System.Drawing.Point(145, 14)
        Me.RbFacturasEmpresas.Name = "RbFacturasEmpresas"
        Me.RbFacturasEmpresas.Size = New System.Drawing.Size(98, 20)
        Me.RbFacturasEmpresas.TabIndex = 1
        Me.RbFacturasEmpresas.Text = "Empresas"
        Me.RbFacturasEmpresas.UseVisualStyleBackColor = True
        '
        'RbFacturasAgricultores
        '
        Me.RbFacturasAgricultores.AutoSize = True
        Me.RbFacturasAgricultores.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturasAgricultores.ForeColor = System.Drawing.Color.Teal
        Me.RbFacturasAgricultores.Location = New System.Drawing.Point(16, 14)
        Me.RbFacturasAgricultores.Name = "RbFacturasAgricultores"
        Me.RbFacturasAgricultores.Size = New System.Drawing.Size(114, 20)
        Me.RbFacturasAgricultores.TabIndex = 0
        Me.RbFacturasAgricultores.Text = "Agricultores"
        Me.RbFacturasAgricultores.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(491, 78)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(124, 16)
        Me.Lb1.TabIndex = 100328
        Me.Lb1.Text = "Tipo de facturas"
        '
        'FrmConsultaFacturasCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 570)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaFacturasCompra"
        Me.Text = "Listado Facturas de Compras"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents TxHastaAgricultor As NetAgro.TxDato
    Friend WithEvents LbNom_HastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNom_DesdeAgricultor As NetAgro.Lb
    Friend WithEvents TxDesdeAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaHastaAgricultor As NetAgro.BtBusca
    Friend WithEvents BtBuscaDesdeAgricultor As NetAgro.BtBusca
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFacturasTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbFacturasEmpresas As System.Windows.Forms.RadioButton
    Friend WithEvents RbFacturasAgricultores As System.Windows.Forms.RadioButton
End Class
