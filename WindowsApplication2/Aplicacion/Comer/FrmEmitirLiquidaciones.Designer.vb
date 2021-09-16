<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmitirLiquidaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmitirLiquidaciones))
        Me.LbDFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxaFecha = New NetAgro.TxDato(Me.components)
        Me.LbdAgricultor = New NetAgro.Lb(Me.components)
        Me.TxDAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaagr1 = New NetAgro.BtBusca(Me.components)
        Me.LbNomAgr2 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgr2 = New NetAgro.BtBusca(Me.components)
        Me.LbaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAAgricultor = New NetAgro.TxDato(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.LbNomEmpresa = New NetAgro.Lb(Me.components)
        Me.BtEmpresa = New NetAgro.BtBusca(Me.components)
        Me.Lbempresa = New NetAgro.Lb(Me.components)
        Me.TxEmpresa = New NetAgro.TxDato(Me.components)
        Me.LbCentroRecogida = New NetAgro.Lb(Me.components)
        Me.CbCentroRecogida = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNomBanco = New NetAgro.Lb(Me.components)
        Me.BtBanco = New NetAgro.BtBusca(Me.components)
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.LbTalon = New NetAgro.Lb(Me.components)
        Me.TxTalon = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChImprimirPagos = New NetAgro.Chk(Me.components)
        Me.ChResumen = New NetAgro.Chk(Me.components)
        Me.ChClasificaciones = New NetAgro.Chk(Me.components)
        Me.ChFacturas = New NetAgro.Chk(Me.components)
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.CbDocumentoTalon = New NetAgro.CbBox(Me.components)
        Me.LbTipoDocumento = New NetAgro.Lb(Me.components)
        Me.CbTipoDocPago = New NetAgro.CbBox(Me.components)
        Me.chkMatricial = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.chkMatricial)
        Me.PanelCabecera.Controls.Add(Me.LbTipoDocumento)
        Me.PanelCabecera.Controls.Add(Me.CbTipoDocPago)
        Me.PanelCabecera.Controls.Add(Me.CbDocumentoTalon)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.btSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.btSelTodos)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.LbTalon)
        Me.PanelCabecera.Controls.Add(Me.TxTalon)
        Me.PanelCabecera.Controls.Add(Me.LbNomBanco)
        Me.PanelCabecera.Controls.Add(Me.BtBanco)
        Me.PanelCabecera.Controls.Add(Me.LbBanco)
        Me.PanelCabecera.Controls.Add(Me.TxBanco)
        Me.PanelCabecera.Controls.Add(Me.LbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.CbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.LbNomEmpresa)
        Me.PanelCabecera.Controls.Add(Me.BtEmpresa)
        Me.PanelCabecera.Controls.Add(Me.Lbempresa)
        Me.PanelCabecera.Controls.Add(Me.TxEmpresa)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgr2)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgr2)
        Me.PanelCabecera.Controls.Add(Me.LbaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbnomAgr1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaagr1)
        Me.PanelCabecera.Controls.Add(Me.LbdAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxDAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1370, 161)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 161)
        Me.PanelConsulta.Size = New System.Drawing.Size(1370, 333)
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
        'LbDFecha
        '
        Me.LbDFecha.AutoSize = True
        Me.LbDFecha.CL_ControlAsociado = Nothing
        Me.LbDFecha.CL_ValorFijo = False
        Me.LbDFecha.ClForm = Nothing
        Me.LbDFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDFecha.Location = New System.Drawing.Point(7, 14)
        Me.LbDFecha.Name = "LbDFecha"
        Me.LbDFecha.Size = New System.Drawing.Size(179, 16)
        Me.LbDFecha.TabIndex = 116
        Me.LbDFecha.Text = "Desde fecha liquidación"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(191, 12)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFecha.TabIndex = 115
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(335, 14)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(177, 16)
        Me.LbAFecha.TabIndex = 100273
        Me.LbAFecha.Text = "Hasta fecha liquidación"
        '
        'TxaFecha
        '
        Me.TxaFecha.Autonumerico = False
        Me.TxaFecha.Buscando = False
        Me.TxaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxaFecha.ClForm = Nothing
        Me.TxaFecha.ClParam = Nothing
        Me.TxaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxaFecha.GridLin = Nothing
        Me.TxaFecha.HaCambiado = False
        Me.TxaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxaFecha.lbbusca = Nothing
        Me.TxaFecha.Location = New System.Drawing.Point(528, 11)
        Me.TxaFecha.MiError = False
        Me.TxaFecha.Name = "TxaFecha"
        Me.TxaFecha.Orden = 0
        Me.TxaFecha.SaltoAlfinal = False
        Me.TxaFecha.Siguiente = 0
        Me.TxaFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxaFecha.TabIndex = 100272
        Me.TxaFecha.TeclaRepetida = False
        Me.TxaFecha.TxDatoFinalSemana = Nothing
        Me.TxaFecha.TxDatoInicioSemana = Nothing
        Me.TxaFecha.UltimoValorValidado = Nothing
        '
        'LbdAgricultor
        '
        Me.LbdAgricultor.AutoSize = True
        Me.LbdAgricultor.CL_ControlAsociado = Nothing
        Me.LbdAgricultor.CL_ValorFijo = False
        Me.LbdAgricultor.ClForm = Nothing
        Me.LbdAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbdAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbdAgricultor.Location = New System.Drawing.Point(10, 46)
        Me.LbdAgricultor.Name = "LbdAgricultor"
        Me.LbdAgricultor.Size = New System.Drawing.Size(101, 16)
        Me.LbdAgricultor.TabIndex = 100277
        Me.LbdAgricultor.Text = "De agricultor"
        '
        'TxDAgricultor
        '
        Me.TxDAgricultor.Autonumerico = False
        Me.TxDAgricultor.Buscando = False
        Me.TxDAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDAgricultor.ClForm = Nothing
        Me.TxDAgricultor.ClParam = Nothing
        Me.TxDAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDAgricultor.GridLin = Nothing
        Me.TxDAgricultor.HaCambiado = False
        Me.TxDAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDAgricultor.lbbusca = Nothing
        Me.TxDAgricultor.Location = New System.Drawing.Point(128, 43)
        Me.TxDAgricultor.MiError = False
        Me.TxDAgricultor.Name = "TxDAgricultor"
        Me.TxDAgricultor.Orden = 0
        Me.TxDAgricultor.SaltoAlfinal = False
        Me.TxDAgricultor.Siguiente = 0
        Me.TxDAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxDAgricultor.TabIndex = 100276
        Me.TxDAgricultor.TeclaRepetida = False
        Me.TxDAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDAgricultor.UltimoValorValidado = Nothing
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.Color.LightGray
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(232, 45)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(401, 18)
        Me.LbnomAgr1.TabIndex = 100279
        '
        'BtBuscaagr1
        '
        Me.BtBuscaagr1.CL_Ancho = 0
        Me.BtBuscaagr1.CL_BuscaAlb = False
        Me.BtBuscaagr1.CL_campocodigo = Nothing
        Me.BtBuscaagr1.CL_camponombre = Nothing
        Me.BtBuscaagr1.CL_CampoOrden = "Nombre"
        Me.BtBuscaagr1.CL_ch1000 = False
        Me.BtBuscaagr1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaagr1.CL_ControlAsociado = Nothing
        Me.BtBuscaagr1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaagr1.CL_dfecha = Nothing
        Me.BtBuscaagr1.CL_Entidad = Nothing
        Me.BtBuscaagr1.CL_EsId = True
        Me.BtBuscaagr1.CL_Filtro = Nothing
        Me.BtBuscaagr1.cl_formu = Nothing
        Me.BtBuscaagr1.CL_hfecha = Nothing
        Me.BtBuscaagr1.cl_ListaW = Nothing
        Me.BtBuscaagr1.CL_xCentro = False
        Me.BtBuscaagr1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaagr1.Location = New System.Drawing.Point(191, 43)
        Me.BtBuscaagr1.Name = "BtBuscaagr1"
        Me.BtBuscaagr1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaagr1.TabIndex = 100278
        Me.BtBuscaagr1.UseVisualStyleBackColor = True
        '
        'LbNomAgr2
        '
        Me.LbNomAgr2.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgr2.CL_ControlAsociado = Nothing
        Me.LbNomAgr2.CL_ValorFijo = False
        Me.LbNomAgr2.ClForm = Nothing
        Me.LbNomAgr2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgr2.Location = New System.Drawing.Point(232, 74)
        Me.LbNomAgr2.Name = "LbNomAgr2"
        Me.LbNomAgr2.Size = New System.Drawing.Size(401, 18)
        Me.LbNomAgr2.TabIndex = 100283
        '
        'BtBuscaAgr2
        '
        Me.BtBuscaAgr2.CL_Ancho = 0
        Me.BtBuscaAgr2.CL_BuscaAlb = False
        Me.BtBuscaAgr2.CL_campocodigo = Nothing
        Me.BtBuscaAgr2.CL_camponombre = Nothing
        Me.BtBuscaAgr2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgr2.CL_ch1000 = False
        Me.BtBuscaAgr2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgr2.CL_ControlAsociado = Nothing
        Me.BtBuscaAgr2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgr2.CL_dfecha = Nothing
        Me.BtBuscaAgr2.CL_Entidad = Nothing
        Me.BtBuscaAgr2.CL_EsId = True
        Me.BtBuscaAgr2.CL_Filtro = Nothing
        Me.BtBuscaAgr2.cl_formu = Nothing
        Me.BtBuscaAgr2.CL_hfecha = Nothing
        Me.BtBuscaAgr2.cl_ListaW = Nothing
        Me.BtBuscaAgr2.CL_xCentro = False
        Me.BtBuscaAgr2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgr2.Location = New System.Drawing.Point(191, 72)
        Me.BtBuscaAgr2.Name = "BtBuscaAgr2"
        Me.BtBuscaAgr2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgr2.TabIndex = 100282
        Me.BtBuscaAgr2.UseVisualStyleBackColor = True
        '
        'LbaAgricultor
        '
        Me.LbaAgricultor.AutoSize = True
        Me.LbaAgricultor.CL_ControlAsociado = Nothing
        Me.LbaAgricultor.CL_ValorFijo = False
        Me.LbaAgricultor.ClForm = Nothing
        Me.LbaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbaAgricultor.Location = New System.Drawing.Point(10, 75)
        Me.LbaAgricultor.Name = "LbaAgricultor"
        Me.LbaAgricultor.Size = New System.Drawing.Size(92, 16)
        Me.LbaAgricultor.TabIndex = 100281
        Me.LbaAgricultor.Text = "A agricultor"
        '
        'TxAAgricultor
        '
        Me.TxAAgricultor.Autonumerico = False
        Me.TxAAgricultor.Buscando = False
        Me.TxAAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAAgricultor.ClForm = Nothing
        Me.TxAAgricultor.ClParam = Nothing
        Me.TxAAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAAgricultor.GridLin = Nothing
        Me.TxAAgricultor.HaCambiado = False
        Me.TxAAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAAgricultor.lbbusca = Nothing
        Me.TxAAgricultor.Location = New System.Drawing.Point(128, 72)
        Me.TxAAgricultor.MiError = False
        Me.TxAAgricultor.Name = "TxAAgricultor"
        Me.TxAAgricultor.Orden = 0
        Me.TxAAgricultor.SaltoAlfinal = False
        Me.TxAAgricultor.Siguiente = 0
        Me.TxAAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxAAgricultor.TabIndex = 100280
        Me.TxAAgricultor.TeclaRepetida = False
        Me.TxAAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAAgricultor.UltimoValorValidado = Nothing
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(1050, 11)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(313, 23)
        Me.Barra.TabIndex = 100285
        '
        'LbNomEmpresa
        '
        Me.LbNomEmpresa.BackColor = System.Drawing.Color.LightGray
        Me.LbNomEmpresa.CL_ControlAsociado = Nothing
        Me.LbNomEmpresa.CL_ValorFijo = False
        Me.LbNomEmpresa.ClForm = Nothing
        Me.LbNomEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomEmpresa.Location = New System.Drawing.Point(232, 103)
        Me.LbNomEmpresa.Name = "LbNomEmpresa"
        Me.LbNomEmpresa.Size = New System.Drawing.Size(401, 18)
        Me.LbNomEmpresa.TabIndex = 100289
        '
        'BtEmpresa
        '
        Me.BtEmpresa.CL_Ancho = 0
        Me.BtEmpresa.CL_BuscaAlb = False
        Me.BtEmpresa.CL_campocodigo = Nothing
        Me.BtEmpresa.CL_camponombre = Nothing
        Me.BtEmpresa.CL_CampoOrden = "Nombre"
        Me.BtEmpresa.CL_ch1000 = False
        Me.BtEmpresa.CL_ConsultaSql = "Select * from familias"
        Me.BtEmpresa.CL_ControlAsociado = Nothing
        Me.BtEmpresa.CL_DevuelveCampo = "Idfamilia"
        Me.BtEmpresa.CL_dfecha = Nothing
        Me.BtEmpresa.CL_Entidad = Nothing
        Me.BtEmpresa.CL_EsId = True
        Me.BtEmpresa.CL_Filtro = Nothing
        Me.BtEmpresa.cl_formu = Nothing
        Me.BtEmpresa.CL_hfecha = Nothing
        Me.BtEmpresa.cl_ListaW = Nothing
        Me.BtEmpresa.CL_xCentro = False
        Me.BtEmpresa.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtEmpresa.Location = New System.Drawing.Point(191, 101)
        Me.BtEmpresa.Name = "BtEmpresa"
        Me.BtEmpresa.Size = New System.Drawing.Size(33, 23)
        Me.BtEmpresa.TabIndex = 100288
        Me.BtEmpresa.UseVisualStyleBackColor = True
        '
        'Lbempresa
        '
        Me.Lbempresa.AutoSize = True
        Me.Lbempresa.CL_ControlAsociado = Nothing
        Me.Lbempresa.CL_ValorFijo = False
        Me.Lbempresa.ClForm = Nothing
        Me.Lbempresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbempresa.ForeColor = System.Drawing.Color.Teal
        Me.Lbempresa.Location = New System.Drawing.Point(10, 104)
        Me.Lbempresa.Name = "Lbempresa"
        Me.Lbempresa.Size = New System.Drawing.Size(72, 16)
        Me.Lbempresa.TabIndex = 100287
        Me.Lbempresa.Text = "Empresa"
        '
        'TxEmpresa
        '
        Me.TxEmpresa.Autonumerico = False
        Me.TxEmpresa.Buscando = False
        Me.TxEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmpresa.ClForm = Nothing
        Me.TxEmpresa.ClParam = Nothing
        Me.TxEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEmpresa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmpresa.GridLin = Nothing
        Me.TxEmpresa.HaCambiado = False
        Me.TxEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEmpresa.lbbusca = Nothing
        Me.TxEmpresa.Location = New System.Drawing.Point(128, 101)
        Me.TxEmpresa.MiError = False
        Me.TxEmpresa.Name = "TxEmpresa"
        Me.TxEmpresa.Orden = 0
        Me.TxEmpresa.SaltoAlfinal = False
        Me.TxEmpresa.Siguiente = 0
        Me.TxEmpresa.Size = New System.Drawing.Size(57, 22)
        Me.TxEmpresa.TabIndex = 100286
        Me.TxEmpresa.TeclaRepetida = False
        Me.TxEmpresa.TxDatoFinalSemana = Nothing
        Me.TxEmpresa.TxDatoInicioSemana = Nothing
        Me.TxEmpresa.UltimoValorValidado = Nothing
        '
        'LbCentroRecogida
        '
        Me.LbCentroRecogida.AutoSize = True
        Me.LbCentroRecogida.CL_ControlAsociado = Nothing
        Me.LbCentroRecogida.CL_ValorFijo = True
        Me.LbCentroRecogida.ClForm = Nothing
        Me.LbCentroRecogida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentroRecogida.ForeColor = System.Drawing.Color.Teal
        Me.LbCentroRecogida.Location = New System.Drawing.Point(10, 134)
        Me.LbCentroRecogida.Name = "LbCentroRecogida"
        Me.LbCentroRecogida.Size = New System.Drawing.Size(108, 16)
        Me.LbCentroRecogida.TabIndex = 100291
        Me.LbCentroRecogida.Text = "C.R.Agricultor"
        '
        'CbCentroRecogida
        '
        Me.CbCentroRecogida.EditValue = ""
        Me.CbCentroRecogida.Location = New System.Drawing.Point(128, 132)
        Me.CbCentroRecogida.Name = "CbCentroRecogida"
        Me.CbCentroRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentroRecogida.Size = New System.Drawing.Size(240, 20)
        Me.CbCentroRecogida.TabIndex = 100290
        '
        'LbNomBanco
        '
        Me.LbNomBanco.BackColor = System.Drawing.Color.LightGray
        Me.LbNomBanco.CL_ControlAsociado = Nothing
        Me.LbNomBanco.CL_ValorFijo = False
        Me.LbNomBanco.ClForm = Nothing
        Me.LbNomBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomBanco.Location = New System.Drawing.Point(836, 13)
        Me.LbNomBanco.Name = "LbNomBanco"
        Me.LbNomBanco.Size = New System.Drawing.Size(197, 18)
        Me.LbNomBanco.TabIndex = 100299
        '
        'BtBanco
        '
        Me.BtBanco.CL_Ancho = 0
        Me.BtBanco.CL_BuscaAlb = False
        Me.BtBanco.CL_campocodigo = Nothing
        Me.BtBanco.CL_camponombre = Nothing
        Me.BtBanco.CL_CampoOrden = "Nombre"
        Me.BtBanco.CL_ch1000 = False
        Me.BtBanco.CL_ConsultaSql = "Select * from familias"
        Me.BtBanco.CL_ControlAsociado = Nothing
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
        Me.BtBanco.Location = New System.Drawing.Point(799, 11)
        Me.BtBanco.Name = "BtBanco"
        Me.BtBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBanco.TabIndex = 100298
        Me.BtBanco.UseVisualStyleBackColor = True
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = False
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(672, 14)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(53, 16)
        Me.LbBanco.TabIndex = 100297
        Me.LbBanco.Text = "Banco"
        '
        'TxBanco
        '
        Me.TxBanco.Autonumerico = False
        Me.TxBanco.Buscando = False
        Me.TxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBanco.ClForm = Nothing
        Me.TxBanco.ClParam = Nothing
        Me.TxBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBanco.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(736, 11)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(57, 22)
        Me.TxBanco.TabIndex = 100296
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
        '
        'LbTalon
        '
        Me.LbTalon.AutoSize = True
        Me.LbTalon.CL_ControlAsociado = Nothing
        Me.LbTalon.CL_ValorFijo = False
        Me.LbTalon.ClForm = Nothing
        Me.LbTalon.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTalon.ForeColor = System.Drawing.Color.Teal
        Me.LbTalon.Location = New System.Drawing.Point(1051, 104)
        Me.LbTalon.Name = "LbTalon"
        Me.LbTalon.Size = New System.Drawing.Size(119, 16)
        Me.LbTalon.TabIndex = 100301
        Me.LbTalon.Text = "Nº primer talon"
        '
        'TxTalon
        '
        Me.TxTalon.Autonumerico = False
        Me.TxTalon.Buscando = False
        Me.TxTalon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTalon.ClForm = Nothing
        Me.TxTalon.ClParam = Nothing
        Me.TxTalon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTalon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTalon.GridLin = Nothing
        Me.TxTalon.HaCambiado = False
        Me.TxTalon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTalon.lbbusca = Nothing
        Me.TxTalon.Location = New System.Drawing.Point(1178, 101)
        Me.TxTalon.MiError = False
        Me.TxTalon.Name = "TxTalon"
        Me.TxTalon.Orden = 0
        Me.TxTalon.SaltoAlfinal = False
        Me.TxTalon.Siguiente = 0
        Me.TxTalon.Size = New System.Drawing.Size(119, 22)
        Me.TxTalon.TabIndex = 100300
        Me.TxTalon.TeclaRepetida = False
        Me.TxTalon.TxDatoFinalSemana = Nothing
        Me.TxTalon.TxDatoInicioSemana = Nothing
        Me.TxTalon.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChImprimirPagos)
        Me.GroupBox1.Controls.Add(Me.ChResumen)
        Me.GroupBox1.Controls.Add(Me.ChClasificaciones)
        Me.GroupBox1.Controls.Add(Me.ChFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(675, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 72)
        Me.GroupBox1.TabIndex = 100302
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imprimir"
        '
        'ChImprimirPagos
        '
        Me.ChImprimirPagos.AutoSize = True
        Me.ChImprimirPagos.Campobd = Nothing
        Me.ChImprimirPagos.ClForm = Nothing
        Me.ChImprimirPagos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChImprimirPagos.GridLin = Nothing
        Me.ChImprimirPagos.HaCambiado = False
        Me.ChImprimirPagos.Location = New System.Drawing.Point(149, 40)
        Me.ChImprimirPagos.MiEntidad = Nothing
        Me.ChImprimirPagos.MiError = False
        Me.ChImprimirPagos.Name = "ChImprimirPagos"
        Me.ChImprimirPagos.Orden = 0
        Me.ChImprimirPagos.SaltoAlfinal = False
        Me.ChImprimirPagos.Size = New System.Drawing.Size(154, 18)
        Me.ChImprimirPagos.TabIndex = 3
        Me.ChImprimirPagos.Text = "DOCUMENTOS PAGO"
        Me.ChImprimirPagos.UseVisualStyleBackColor = True
        Me.ChImprimirPagos.ValorCampoFalse = Nothing
        Me.ChImprimirPagos.ValorCampoTrue = Nothing
        Me.ChImprimirPagos.ValorDefecto = False
        '
        'ChResumen
        '
        Me.ChResumen.AutoSize = True
        Me.ChResumen.Campobd = Nothing
        Me.ChResumen.ClForm = Nothing
        Me.ChResumen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChResumen.GridLin = Nothing
        Me.ChResumen.HaCambiado = False
        Me.ChResumen.Location = New System.Drawing.Point(149, 16)
        Me.ChResumen.MiEntidad = Nothing
        Me.ChResumen.MiError = False
        Me.ChResumen.Name = "ChResumen"
        Me.ChResumen.Orden = 0
        Me.ChResumen.SaltoAlfinal = False
        Me.ChResumen.Size = New System.Drawing.Size(117, 18)
        Me.ChResumen.TabIndex = 2
        Me.ChResumen.Text = "Hoja Resumen"
        Me.ChResumen.UseVisualStyleBackColor = True
        Me.ChResumen.ValorCampoFalse = Nothing
        Me.ChResumen.ValorCampoTrue = Nothing
        Me.ChResumen.ValorDefecto = False
        '
        'ChClasificaciones
        '
        Me.ChClasificaciones.AutoSize = True
        Me.ChClasificaciones.Campobd = Nothing
        Me.ChClasificaciones.ClForm = Nothing
        Me.ChClasificaciones.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChClasificaciones.GridLin = Nothing
        Me.ChClasificaciones.HaCambiado = False
        Me.ChClasificaciones.Location = New System.Drawing.Point(13, 40)
        Me.ChClasificaciones.MiEntidad = Nothing
        Me.ChClasificaciones.MiError = False
        Me.ChClasificaciones.Name = "ChClasificaciones"
        Me.ChClasificaciones.Orden = 0
        Me.ChClasificaciones.SaltoAlfinal = False
        Me.ChClasificaciones.Size = New System.Drawing.Size(117, 18)
        Me.ChClasificaciones.TabIndex = 1
        Me.ChClasificaciones.Text = "Clasificaciones"
        Me.ChClasificaciones.UseVisualStyleBackColor = True
        Me.ChClasificaciones.ValorCampoFalse = Nothing
        Me.ChClasificaciones.ValorCampoTrue = Nothing
        Me.ChClasificaciones.ValorDefecto = False
        '
        'ChFacturas
        '
        Me.ChFacturas.AutoSize = True
        Me.ChFacturas.Campobd = Nothing
        Me.ChFacturas.ClForm = Nothing
        Me.ChFacturas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChFacturas.GridLin = Nothing
        Me.ChFacturas.HaCambiado = False
        Me.ChFacturas.Location = New System.Drawing.Point(13, 16)
        Me.ChFacturas.MiEntidad = Nothing
        Me.ChFacturas.MiError = False
        Me.ChFacturas.Name = "ChFacturas"
        Me.ChFacturas.Orden = 0
        Me.ChFacturas.SaltoAlfinal = False
        Me.ChFacturas.Size = New System.Drawing.Size(79, 18)
        Me.ChFacturas.TabIndex = 0
        Me.ChFacturas.Text = "Facturas"
        Me.ChFacturas.UseVisualStyleBackColor = True
        Me.ChFacturas.ValorCampoFalse = Nothing
        Me.ChFacturas.ValorCampoTrue = Nothing
        Me.ChFacturas.ValorDefecto = False
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(1309, 130)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 100304
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(1336, 130)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 100303
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(672, 134)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(132, 16)
        Me.Lb1.TabIndex = 100305
        Me.Lb1.Text = "Documento talón"
        '
        'CbDocumentoTalon
        '
        Me.CbDocumentoTalon.Campobd = Nothing
        Me.CbDocumentoTalon.ClForm = Nothing
        Me.CbDocumentoTalon.DeshabilitarRuedaRaton = False
        Me.CbDocumentoTalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDocumentoTalon.FormattingEnabled = True
        Me.CbDocumentoTalon.GridLin = Nothing
        Me.CbDocumentoTalon.Location = New System.Drawing.Point(810, 132)
        Me.CbDocumentoTalon.MiEntidad = Nothing
        Me.CbDocumentoTalon.MiError = False
        Me.CbDocumentoTalon.Name = "CbDocumentoTalon"
        Me.CbDocumentoTalon.Orden = 0
        Me.CbDocumentoTalon.SaltoAlfinal = False
        Me.CbDocumentoTalon.Size = New System.Drawing.Size(490, 21)
        Me.CbDocumentoTalon.TabIndex = 100306
        '
        'LbTipoDocumento
        '
        Me.LbTipoDocumento.AutoSize = True
        Me.LbTipoDocumento.CL_ControlAsociado = Nothing
        Me.LbTipoDocumento.CL_ValorFijo = False
        Me.LbTipoDocumento.ClForm = Nothing
        Me.LbTipoDocumento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoDocumento.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoDocumento.Location = New System.Drawing.Point(1051, 46)
        Me.LbTipoDocumento.Name = "LbTipoDocumento"
        Me.LbTipoDocumento.Size = New System.Drawing.Size(114, 16)
        Me.LbTipoDocumento.TabIndex = 100308
        Me.LbTipoDocumento.Text = "Tipo Doc. Pago"
        '
        'CbTipoDocPago
        '
        Me.CbTipoDocPago.Campobd = Nothing
        Me.CbTipoDocPago.ClForm = Nothing
        Me.CbTipoDocPago.DeshabilitarRuedaRaton = False
        Me.CbTipoDocPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoDocPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoDocPago.FormattingEnabled = True
        Me.CbTipoDocPago.GridLin = Nothing
        Me.CbTipoDocPago.Location = New System.Drawing.Point(1177, 43)
        Me.CbTipoDocPago.MiEntidad = Nothing
        Me.CbTipoDocPago.MiError = False
        Me.CbTipoDocPago.Name = "CbTipoDocPago"
        Me.CbTipoDocPago.Orden = 0
        Me.CbTipoDocPago.SaltoAlfinal = False
        Me.CbTipoDocPago.Size = New System.Drawing.Size(160, 23)
        Me.CbTipoDocPago.TabIndex = 100307
        '
        'chkMatricial
        '
        Me.chkMatricial.AutoSize = True
        Me.chkMatricial.Campobd = Nothing
        Me.chkMatricial.ClForm = Nothing
        Me.chkMatricial.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMatricial.GridLin = Nothing
        Me.chkMatricial.HaCambiado = False
        Me.chkMatricial.Location = New System.Drawing.Point(556, 133)
        Me.chkMatricial.MiEntidad = Nothing
        Me.chkMatricial.MiError = False
        Me.chkMatricial.Name = "chkMatricial"
        Me.chkMatricial.Orden = 0
        Me.chkMatricial.SaltoAlfinal = False
        Me.chkMatricial.Size = New System.Drawing.Size(110, 18)
        Me.chkMatricial.TabIndex = 4
        Me.chkMatricial.Text = "Imp. matricial"
        Me.chkMatricial.UseVisualStyleBackColor = True
        Me.chkMatricial.ValorCampoFalse = Nothing
        Me.chkMatricial.ValorCampoTrue = Nothing
        Me.chkMatricial.ValorDefecto = False
        '
        'FrmEmitirLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEmitirLiquidaciones"
        Me.Text = "Emitir liquidaciones"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbDFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxaFecha As NetAgro.TxDato
    Friend WithEvents LbdAgricultor As NetAgro.Lb
    Friend WithEvents TxDAgricultor As NetAgro.TxDato
    Friend WithEvents LbNomAgr2 As NetAgro.Lb
    Friend WithEvents BtBuscaAgr2 As NetAgro.BtBusca
    Friend WithEvents LbaAgricultor As NetAgro.Lb
    Friend WithEvents TxAAgricultor As NetAgro.TxDato
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents BtBuscaagr1 As NetAgro.BtBusca
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents LbNomEmpresa As NetAgro.Lb
    Friend WithEvents BtEmpresa As NetAgro.BtBusca
    Friend WithEvents Lbempresa As NetAgro.Lb
    Friend WithEvents TxEmpresa As NetAgro.TxDato
    Friend WithEvents LbCentroRecogida As NetAgro.Lb
    Friend WithEvents CbCentroRecogida As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbNomBanco As NetAgro.Lb
    Friend WithEvents BtBanco As NetAgro.BtBusca
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents LbTalon As NetAgro.Lb
    Friend WithEvents TxTalon As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChImprimirPagos As NetAgro.Chk
    Friend WithEvents ChResumen As NetAgro.Chk
    Friend WithEvents ChClasificaciones As NetAgro.Chk
    Friend WithEvents ChFacturas As NetAgro.Chk
    Friend WithEvents btSelNinguno As System.Windows.Forms.Button
    Friend WithEvents btSelTodos As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CbDocumentoTalon As NetAgro.CbBox
    Friend WithEvents LbTipoDocumento As NetAgro.Lb
    Friend WithEvents CbTipoDocPago As NetAgro.CbBox
    Friend WithEvents chkMatricial As NetAgro.Chk
End Class
