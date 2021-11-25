<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnvioFianzasEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnvioFianzasEnvases))
        Me.TxDesdeProveedor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDesdeProveedor = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeProveedor = New NetAgro.Lb(Me.components)
        Me.LbNomDesdeProveedor = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbNombreCliente = New NetAgro.Lb(Me.components)
        Me.TxIdCliente = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.LbNomDEnvase = New NetAgro.Lb(Me.components)
        Me.TxDEnvase = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDEnvase = New NetAgro.BtBusca(Me.components)
        Me.LbDEnvase = New NetAgro.Lb(Me.components)
        Me.LbNomAEnvase = New NetAgro.Lb(Me.components)
        Me.TxAEnvase = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAEnvase = New NetAgro.BtBusca(Me.components)
        Me.LbAEnvase = New NetAgro.Lb(Me.components)
        Me.RbIfco = New System.Windows.Forms.RadioButton()
        Me.RbChep = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.GridExcel = New DevExpress.XtraGrid.GridControl()
        Me.GridViewExcel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.btSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.btSelTodos)
        Me.PanelCabecera.Controls.Add(Me.LbNomAEnvase)
        Me.PanelCabecera.Controls.Add(Me.TxAEnvase)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbAEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbNomDEnvase)
        Me.PanelCabecera.Controls.Add(Me.TxDEnvase)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbDEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbCliente)
        Me.PanelCabecera.Controls.Add(Me.LbNombreCliente)
        Me.PanelCabecera.Controls.Add(Me.TxIdCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCliente)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.LbNomDesdeProveedor)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeProveedor)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeProveedor)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeProveedor)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 122)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 122)
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
        Me.BtAux.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDesdeProveedor
        '
        Me.TxDesdeProveedor.Autonumerico = False
        Me.TxDesdeProveedor.Bloqueado = False
        Me.TxDesdeProveedor.Buscando = False
        Me.TxDesdeProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeProveedor.ClForm = Nothing
        Me.TxDesdeProveedor.ClParam = Nothing
        Me.TxDesdeProveedor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeProveedor.GridLin = Nothing
        Me.TxDesdeProveedor.HaCambiado = False
        Me.TxDesdeProveedor.lbbusca = Nothing
        Me.TxDesdeProveedor.Location = New System.Drawing.Point(152, 21)
        Me.TxDesdeProveedor.MiError = False
        Me.TxDesdeProveedor.Name = "TxDesdeProveedor"
        Me.TxDesdeProveedor.Orden = 0
        Me.TxDesdeProveedor.SaltoAlfinal = False
        Me.TxDesdeProveedor.Siguiente = 0
        Me.TxDesdeProveedor.Size = New System.Drawing.Size(59, 22)
        Me.TxDesdeProveedor.TabIndex = 51
        Me.TxDesdeProveedor.TeclaRepetida = False
        Me.TxDesdeProveedor.TxDatoFinalSemana = Nothing
        Me.TxDesdeProveedor.TxDatoInicioSemana = Nothing
        Me.TxDesdeProveedor.UltimoValorValidado = Nothing
        '
        'BtBuscaDesdeProveedor
        '
        Me.BtBuscaDesdeProveedor.CL_Ancho = 0
        Me.BtBuscaDesdeProveedor.CL_BuscaAlb = False
        Me.BtBuscaDesdeProveedor.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaDesdeProveedor.CL_campocodigo = Nothing
        Me.BtBuscaDesdeProveedor.CL_camponombre = Nothing
        Me.BtBuscaDesdeProveedor.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeProveedor.CL_ch1000 = False
        Me.BtBuscaDesdeProveedor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeProveedor.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeProveedor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeProveedor.CL_dfecha = Nothing
        Me.BtBuscaDesdeProveedor.CL_Entidad = Nothing
        Me.BtBuscaDesdeProveedor.CL_EsId = True
        Me.BtBuscaDesdeProveedor.CL_Filtro = Nothing
        Me.BtBuscaDesdeProveedor.cl_formu = Nothing
        Me.BtBuscaDesdeProveedor.CL_hfecha = Nothing
        Me.BtBuscaDesdeProveedor.cl_ListaW = Nothing
        Me.BtBuscaDesdeProveedor.CL_xCentro = False
        Me.BtBuscaDesdeProveedor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeProveedor.Location = New System.Drawing.Point(215, 21)
        Me.BtBuscaDesdeProveedor.Name = "BtBuscaDesdeProveedor"
        Me.BtBuscaDesdeProveedor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeProveedor.TabIndex = 50
        Me.BtBuscaDesdeProveedor.UseVisualStyleBackColor = True
        '
        'LbDesdeProveedor
        '
        Me.LbDesdeProveedor.AutoSize = True
        Me.LbDesdeProveedor.CL_ControlAsociado = Nothing
        Me.LbDesdeProveedor.CL_ValorFijo = False
        Me.LbDesdeProveedor.ClForm = Nothing
        Me.LbDesdeProveedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeProveedor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeProveedor.Location = New System.Drawing.Point(12, 23)
        Me.LbDesdeProveedor.Name = "LbDesdeProveedor"
        Me.LbDesdeProveedor.Size = New System.Drawing.Size(134, 16)
        Me.LbDesdeProveedor.TabIndex = 49
        Me.LbDesdeProveedor.Text = "Acreedor Fianzas"
        '
        'LbNomDesdeProveedor
        '
        Me.LbNomDesdeProveedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDesdeProveedor.CL_ControlAsociado = Nothing
        Me.LbNomDesdeProveedor.CL_ValorFijo = False
        Me.LbNomDesdeProveedor.ClForm = Nothing
        Me.LbNomDesdeProveedor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeProveedor.Location = New System.Drawing.Point(254, 21)
        Me.LbNomDesdeProveedor.Name = "LbNomDesdeProveedor"
        Me.LbNomDesdeProveedor.Size = New System.Drawing.Size(365, 23)
        Me.LbNomDesdeProveedor.TabIndex = 75
        Me.LbNomDesdeProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Bloqueado = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(983, 20)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(880, 23)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxDesdeFecha
        '
        Me.TxDesdeFecha.Autonumerico = False
        Me.TxDesdeFecha.Bloqueado = False
        Me.TxDesdeFecha.Buscando = False
        Me.TxDesdeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeFecha.ClForm = Nothing
        Me.TxDesdeFecha.ClParam = Nothing
        Me.TxDesdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFecha.GridLin = Nothing
        Me.TxDesdeFecha.HaCambiado = False
        Me.TxDesdeFecha.lbbusca = Nothing
        Me.TxDesdeFecha.Location = New System.Drawing.Point(743, 20)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(640, 23)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbNombreCliente
        '
        Me.LbNombreCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreCliente.CL_ControlAsociado = Nothing
        Me.LbNombreCliente.CL_ValorFijo = False
        Me.LbNombreCliente.ClForm = Nothing
        Me.LbNombreCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreCliente.Location = New System.Drawing.Point(807, 54)
        Me.LbNombreCliente.Name = "LbNombreCliente"
        Me.LbNombreCliente.Size = New System.Drawing.Size(278, 23)
        Me.LbNombreCliente.TabIndex = 100298
        Me.LbNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxIdCliente
        '
        Me.TxIdCliente.Autonumerico = False
        Me.TxIdCliente.Bloqueado = False
        Me.TxIdCliente.Buscando = False
        Me.TxIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIdCliente.ClForm = Nothing
        Me.TxIdCliente.ClParam = Nothing
        Me.TxIdCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdCliente.GridLin = Nothing
        Me.TxIdCliente.HaCambiado = False
        Me.TxIdCliente.lbbusca = Nothing
        Me.TxIdCliente.Location = New System.Drawing.Point(705, 54)
        Me.TxIdCliente.MiError = False
        Me.TxIdCliente.Name = "TxIdCliente"
        Me.TxIdCliente.Orden = 0
        Me.TxIdCliente.SaltoAlfinal = False
        Me.TxIdCliente.Siguiente = 0
        Me.TxIdCliente.Size = New System.Drawing.Size(59, 22)
        Me.TxIdCliente.TabIndex = 100297
        Me.TxIdCliente.TeclaRepetida = False
        Me.TxIdCliente.TxDatoFinalSemana = Nothing
        Me.TxIdCliente.TxDatoInicioSemana = Nothing
        Me.TxIdCliente.UltimoValorValidado = Nothing
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
        Me.BtBuscaCliente.Location = New System.Drawing.Point(768, 54)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 100296
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
        '
        'LbCliente
        '
        Me.LbCliente.AutoSize = True
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = False
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbCliente.Location = New System.Drawing.Point(640, 57)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(59, 16)
        Me.LbCliente.TabIndex = 100299
        Me.LbCliente.Text = "Cliente"
        '
        'LbNomDEnvase
        '
        Me.LbNomDEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDEnvase.CL_ControlAsociado = Nothing
        Me.LbNomDEnvase.CL_ValorFijo = False
        Me.LbNomDEnvase.ClForm = Nothing
        Me.LbNomDEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDEnvase.Location = New System.Drawing.Point(204, 55)
        Me.LbNomDEnvase.Name = "LbNomDEnvase"
        Me.LbNomDEnvase.Size = New System.Drawing.Size(415, 23)
        Me.LbNomDEnvase.TabIndex = 100303
        Me.LbNomDEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDEnvase
        '
        Me.TxDEnvase.Autonumerico = False
        Me.TxDEnvase.Bloqueado = False
        Me.TxDEnvase.Buscando = False
        Me.TxDEnvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDEnvase.ClForm = Nothing
        Me.TxDEnvase.ClParam = Nothing
        Me.TxDEnvase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDEnvase.GridLin = Nothing
        Me.TxDEnvase.HaCambiado = False
        Me.TxDEnvase.lbbusca = Nothing
        Me.TxDEnvase.Location = New System.Drawing.Point(102, 55)
        Me.TxDEnvase.MiError = False
        Me.TxDEnvase.Name = "TxDEnvase"
        Me.TxDEnvase.Orden = 0
        Me.TxDEnvase.SaltoAlfinal = False
        Me.TxDEnvase.Siguiente = 0
        Me.TxDEnvase.Size = New System.Drawing.Size(59, 22)
        Me.TxDEnvase.TabIndex = 100302
        Me.TxDEnvase.TeclaRepetida = False
        Me.TxDEnvase.TxDatoFinalSemana = Nothing
        Me.TxDEnvase.TxDatoInicioSemana = Nothing
        Me.TxDEnvase.UltimoValorValidado = Nothing
        '
        'BtBuscaDEnvase
        '
        Me.BtBuscaDEnvase.CL_Ancho = 0
        Me.BtBuscaDEnvase.CL_BuscaAlb = False
        Me.BtBuscaDEnvase.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaDEnvase.CL_campocodigo = Nothing
        Me.BtBuscaDEnvase.CL_camponombre = Nothing
        Me.BtBuscaDEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaDEnvase.CL_ch1000 = False
        Me.BtBuscaDEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDEnvase.CL_ControlAsociado = Nothing
        Me.BtBuscaDEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDEnvase.CL_dfecha = Nothing
        Me.BtBuscaDEnvase.CL_Entidad = Nothing
        Me.BtBuscaDEnvase.CL_EsId = True
        Me.BtBuscaDEnvase.CL_Filtro = Nothing
        Me.BtBuscaDEnvase.cl_formu = Nothing
        Me.BtBuscaDEnvase.CL_hfecha = Nothing
        Me.BtBuscaDEnvase.cl_ListaW = Nothing
        Me.BtBuscaDEnvase.CL_xCentro = False
        Me.BtBuscaDEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDEnvase.Location = New System.Drawing.Point(165, 55)
        Me.BtBuscaDEnvase.Name = "BtBuscaDEnvase"
        Me.BtBuscaDEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDEnvase.TabIndex = 100301
        Me.BtBuscaDEnvase.UseVisualStyleBackColor = True
        '
        'LbDEnvase
        '
        Me.LbDEnvase.AutoSize = True
        Me.LbDEnvase.CL_ControlAsociado = Nothing
        Me.LbDEnvase.CL_ValorFijo = False
        Me.LbDEnvase.ClForm = Nothing
        Me.LbDEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDEnvase.ForeColor = System.Drawing.Color.Teal
        Me.LbDEnvase.Location = New System.Drawing.Point(12, 57)
        Me.LbDEnvase.Name = "LbDEnvase"
        Me.LbDEnvase.Size = New System.Drawing.Size(84, 16)
        Me.LbDEnvase.TabIndex = 100300
        Me.LbDEnvase.Text = "De Envase"
        '
        'LbNomAEnvase
        '
        Me.LbNomAEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAEnvase.CL_ControlAsociado = Nothing
        Me.LbNomAEnvase.CL_ValorFijo = False
        Me.LbNomAEnvase.ClForm = Nothing
        Me.LbNomAEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAEnvase.Location = New System.Drawing.Point(204, 84)
        Me.LbNomAEnvase.Name = "LbNomAEnvase"
        Me.LbNomAEnvase.Size = New System.Drawing.Size(415, 23)
        Me.LbNomAEnvase.TabIndex = 100307
        Me.LbNomAEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxAEnvase
        '
        Me.TxAEnvase.Autonumerico = False
        Me.TxAEnvase.Bloqueado = False
        Me.TxAEnvase.Buscando = False
        Me.TxAEnvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAEnvase.ClForm = Nothing
        Me.TxAEnvase.ClParam = Nothing
        Me.TxAEnvase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAEnvase.GridLin = Nothing
        Me.TxAEnvase.HaCambiado = False
        Me.TxAEnvase.lbbusca = Nothing
        Me.TxAEnvase.Location = New System.Drawing.Point(102, 84)
        Me.TxAEnvase.MiError = False
        Me.TxAEnvase.Name = "TxAEnvase"
        Me.TxAEnvase.Orden = 0
        Me.TxAEnvase.SaltoAlfinal = False
        Me.TxAEnvase.Siguiente = 0
        Me.TxAEnvase.Size = New System.Drawing.Size(59, 22)
        Me.TxAEnvase.TabIndex = 100306
        Me.TxAEnvase.TeclaRepetida = False
        Me.TxAEnvase.TxDatoFinalSemana = Nothing
        Me.TxAEnvase.TxDatoInicioSemana = Nothing
        Me.TxAEnvase.UltimoValorValidado = Nothing
        '
        'BtBuscaAEnvase
        '
        Me.BtBuscaAEnvase.CL_Ancho = 0
        Me.BtBuscaAEnvase.CL_BuscaAlb = False
        Me.BtBuscaAEnvase.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaAEnvase.CL_campocodigo = Nothing
        Me.BtBuscaAEnvase.CL_camponombre = Nothing
        Me.BtBuscaAEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaAEnvase.CL_ch1000 = False
        Me.BtBuscaAEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAEnvase.CL_ControlAsociado = Nothing
        Me.BtBuscaAEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAEnvase.CL_dfecha = Nothing
        Me.BtBuscaAEnvase.CL_Entidad = Nothing
        Me.BtBuscaAEnvase.CL_EsId = True
        Me.BtBuscaAEnvase.CL_Filtro = Nothing
        Me.BtBuscaAEnvase.cl_formu = Nothing
        Me.BtBuscaAEnvase.CL_hfecha = Nothing
        Me.BtBuscaAEnvase.cl_ListaW = Nothing
        Me.BtBuscaAEnvase.CL_xCentro = False
        Me.BtBuscaAEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAEnvase.Location = New System.Drawing.Point(165, 84)
        Me.BtBuscaAEnvase.Name = "BtBuscaAEnvase"
        Me.BtBuscaAEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAEnvase.TabIndex = 100305
        Me.BtBuscaAEnvase.UseVisualStyleBackColor = True
        '
        'LbAEnvase
        '
        Me.LbAEnvase.AutoSize = True
        Me.LbAEnvase.CL_ControlAsociado = Nothing
        Me.LbAEnvase.CL_ValorFijo = False
        Me.LbAEnvase.ClForm = Nothing
        Me.LbAEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAEnvase.ForeColor = System.Drawing.Color.Teal
        Me.LbAEnvase.Location = New System.Drawing.Point(12, 86)
        Me.LbAEnvase.Name = "LbAEnvase"
        Me.LbAEnvase.Size = New System.Drawing.Size(75, 16)
        Me.LbAEnvase.TabIndex = 100304
        Me.LbAEnvase.Text = "A Envase"
        '
        'RbIfco
        '
        Me.RbIfco.AutoSize = True
        Me.RbIfco.Checked = True
        Me.RbIfco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbIfco.ForeColor = System.Drawing.Color.Teal
        Me.RbIfco.Location = New System.Drawing.Point(16, 14)
        Me.RbIfco.Name = "RbIfco"
        Me.RbIfco.Size = New System.Drawing.Size(54, 20)
        Me.RbIfco.TabIndex = 0
        Me.RbIfco.TabStop = True
        Me.RbIfco.Text = "Ifco"
        Me.RbIfco.UseVisualStyleBackColor = True
        '
        'RbChep
        '
        Me.RbChep.AutoSize = True
        Me.RbChep.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbChep.ForeColor = System.Drawing.Color.Teal
        Me.RbChep.Location = New System.Drawing.Point(16, 33)
        Me.RbChep.Name = "RbChep"
        Me.RbChep.Size = New System.Drawing.Size(63, 20)
        Me.RbChep.TabIndex = 1
        Me.RbChep.Text = "Chep"
        Me.RbChep.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbChep)
        Me.GroupBox1.Controls.Add(Me.RbIfco)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(1102, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 61)
        Me.GroupBox1.TabIndex = 100294
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato"
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(1170, 95)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 100310
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(1197, 95)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 100309
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'GridExcel
        '
        Me.GridExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExcel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridExcel.Location = New System.Drawing.Point(0, 0)
        Me.GridExcel.LookAndFeel.SkinName = "Black"
        Me.GridExcel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridExcel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridExcel.MainView = Me.GridViewExcel
        Me.GridExcel.Name = "GridExcel"
        Me.GridExcel.Size = New System.Drawing.Size(1234, 562)
        Me.GridExcel.TabIndex = 14
        Me.GridExcel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewExcel})
        Me.GridExcel.Visible = False
        '
        'GridViewExcel
        '
        Me.GridViewExcel.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewExcel.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExcel.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewExcel.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewExcel.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewExcel.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewExcel.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewExcel.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExcel.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewExcel.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewExcel.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewExcel.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewExcel.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExcel.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewExcel.Appearance.Row.Options.UseFont = True
        Me.GridViewExcel.Appearance.Row.Options.UseForeColor = True
        Me.GridViewExcel.GridControl = Me.GridExcel
        Me.GridViewExcel.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewExcel.Name = "GridViewExcel"
        Me.GridViewExcel.OptionsView.AutoCalcPreviewLineCount = True
        '
        'FrmEnvioFianzasEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.Controls.Add(Me.GridExcel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEnvioFianzasEnvases"
        Me.Text = "Envio Fianzas de Envases"
        Me.Controls.SetChildIndex(Me.GridExcel, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDesdeProveedor As NetAgro.TxDato
    Friend WithEvents BtBuscaDesdeProveedor As NetAgro.BtBusca
    Friend WithEvents LbDesdeProveedor As NetAgro.Lb
    Friend WithEvents LbNomDesdeProveedor As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents LbNombreCliente As NetAgro.Lb
    Friend WithEvents TxIdCliente As NetAgro.TxDato
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents LbNomAEnvase As NetAgro.Lb
    Friend WithEvents TxAEnvase As NetAgro.TxDato
    Friend WithEvents BtBuscaAEnvase As NetAgro.BtBusca
    Friend WithEvents LbAEnvase As NetAgro.Lb
    Friend WithEvents LbNomDEnvase As NetAgro.Lb
    Friend WithEvents TxDEnvase As NetAgro.TxDato
    Friend WithEvents BtBuscaDEnvase As NetAgro.BtBusca
    Friend WithEvents LbDEnvase As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbChep As System.Windows.Forms.RadioButton
    Friend WithEvents RbIfco As System.Windows.Forms.RadioButton
    Friend WithEvents btSelNinguno As Button
    Friend WithEvents btSelTodos As Button
    Public WithEvents GridExcel As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewExcel As DevExpress.XtraGrid.Views.Grid.GridView
End Class
