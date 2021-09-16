<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarLiquidaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarLiquidaciones))
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
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaLiq = New NetAgro.TxDato(Me.components)
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.BtCentro = New NetAgro.BtBusca(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.TxCentro = New NetAgro.TxDato(Me.components)
        Me.LbSerie = New NetAgro.Lb(Me.components)
        Me.TxSerie = New NetAgro.TxDato(Me.components)
        Me.LbFeSemana1 = New NetAgro.Lb(Me.components)
        Me.BtSemana1 = New NetAgro.BtBusca(Me.components)
        Me.LbSemana1 = New NetAgro.Lb(Me.components)
        Me.TxSemana1 = New NetAgro.TxDato(Me.components)
        Me.LbFeSemana2 = New NetAgro.Lb(Me.components)
        Me.BtSemana2 = New NetAgro.BtBusca(Me.components)
        Me.LbSemana2 = New NetAgro.Lb(Me.components)
        Me.TxSemana2 = New NetAgro.TxDato(Me.components)
        Me.LbEjerFac = New NetAgro.Lb(Me.components)
        Me.TxEjerfac = New NetAgro.TxDato(Me.components)
        Me.LbFechaVtoPagare = New NetAgro.Lb(Me.components)
        Me.TxFechaVtoPagare = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbFechaVtoPagare)
        Me.PanelCabecera.Controls.Add(Me.TxFechaVtoPagare)
        Me.PanelCabecera.Controls.Add(Me.LbEjerFac)
        Me.PanelCabecera.Controls.Add(Me.TxEjerfac)
        Me.PanelCabecera.Controls.Add(Me.LbFeSemana2)
        Me.PanelCabecera.Controls.Add(Me.BtSemana2)
        Me.PanelCabecera.Controls.Add(Me.LbSemana2)
        Me.PanelCabecera.Controls.Add(Me.TxSemana2)
        Me.PanelCabecera.Controls.Add(Me.LbFeSemana1)
        Me.PanelCabecera.Controls.Add(Me.BtSemana1)
        Me.PanelCabecera.Controls.Add(Me.LbSemana1)
        Me.PanelCabecera.Controls.Add(Me.TxSemana1)
        Me.PanelCabecera.Controls.Add(Me.LbSerie)
        Me.PanelCabecera.Controls.Add(Me.TxSerie)
        Me.PanelCabecera.Controls.Add(Me.LbNomCentro)
        Me.PanelCabecera.Controls.Add(Me.BtCentro)
        Me.PanelCabecera.Controls.Add(Me.LbCentro)
        Me.PanelCabecera.Controls.Add(Me.TxCentro)
        Me.PanelCabecera.Controls.Add(Me.LbFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaLiq)
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
        Me.PanelCabecera.Size = New System.Drawing.Size(1128, 189)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 189)
        Me.PanelConsulta.Size = New System.Drawing.Size(1128, 345)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(828, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(903, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(978, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1053, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(753, 0)
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
        Me.LbDFecha.Location = New System.Drawing.Point(7, 16)
        Me.LbDFecha.Name = "LbDFecha"
        Me.LbDFecha.Size = New System.Drawing.Size(153, 16)
        Me.LbDFecha.TabIndex = 116
        Me.LbDFecha.Text = "Desde fecha factura"
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
        Me.TxDeFecha.Location = New System.Drawing.Point(177, 13)
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
        Me.LbAFecha.Location = New System.Drawing.Point(331, 16)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(151, 16)
        Me.LbAFecha.TabIndex = 100273
        Me.LbAFecha.Text = "Hasta fecha factura"
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
        Me.TxaFecha.Location = New System.Drawing.Point(490, 13)
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
        Me.LbdAgricultor.Location = New System.Drawing.Point(7, 73)
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
        Me.TxDAgricultor.Location = New System.Drawing.Point(128, 70)
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
        Me.LbnomAgr1.Location = New System.Drawing.Point(232, 72)
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
        Me.BtBuscaagr1.Location = New System.Drawing.Point(191, 70)
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
        Me.LbNomAgr2.Location = New System.Drawing.Point(232, 101)
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
        Me.BtBuscaAgr2.Location = New System.Drawing.Point(191, 99)
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
        Me.LbaAgricultor.Location = New System.Drawing.Point(7, 102)
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
        Me.TxAAgricultor.Location = New System.Drawing.Point(128, 99)
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
        Me.Barra.Location = New System.Drawing.Point(890, 14)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(202, 23)
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
        Me.LbNomEmpresa.Location = New System.Drawing.Point(232, 130)
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
        Me.BtEmpresa.Location = New System.Drawing.Point(191, 128)
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
        Me.Lbempresa.Location = New System.Drawing.Point(7, 131)
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
        Me.TxEmpresa.Location = New System.Drawing.Point(128, 128)
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
        Me.LbCentroRecogida.Location = New System.Drawing.Point(723, 158)
        Me.LbCentroRecogida.Name = "LbCentroRecogida"
        Me.LbCentroRecogida.Size = New System.Drawing.Size(108, 16)
        Me.LbCentroRecogida.TabIndex = 100291
        Me.LbCentroRecogida.Text = "C.R.Agricultor"
        '
        'CbCentroRecogida
        '
        Me.CbCentroRecogida.EditValue = ""
        Me.CbCentroRecogida.Location = New System.Drawing.Point(874, 157)
        Me.CbCentroRecogida.Name = "CbCentroRecogida"
        Me.CbCentroRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentroRecogida.Size = New System.Drawing.Size(240, 20)
        Me.CbCentroRecogida.TabIndex = 100290
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(723, 103)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(134, 16)
        Me.LbFecha.TabIndex = 100295
        Me.LbFecha.Text = "Fecha liquidacion"
        '
        'TxFechaLiq
        '
        Me.TxFechaLiq.Autonumerico = False
        Me.TxFechaLiq.Buscando = False
        Me.TxFechaLiq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaLiq.ClForm = Nothing
        Me.TxFechaLiq.ClParam = Nothing
        Me.TxFechaLiq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaLiq.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaLiq.GridLin = Nothing
        Me.TxFechaLiq.HaCambiado = False
        Me.TxFechaLiq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaLiq.lbbusca = Nothing
        Me.TxFechaLiq.Location = New System.Drawing.Point(874, 101)
        Me.TxFechaLiq.MiError = False
        Me.TxFechaLiq.Name = "TxFechaLiq"
        Me.TxFechaLiq.Orden = 0
        Me.TxFechaLiq.SaltoAlfinal = False
        Me.TxFechaLiq.Siguiente = 0
        Me.TxFechaLiq.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaLiq.TabIndex = 100294
        Me.TxFechaLiq.TeclaRepetida = False
        Me.TxFechaLiq.TxDatoFinalSemana = Nothing
        Me.TxFechaLiq.TxDatoInicioSemana = Nothing
        Me.TxFechaLiq.UltimoValorValidado = Nothing
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = False
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentro.Location = New System.Drawing.Point(887, 48)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(197, 18)
        Me.LbNomCentro.TabIndex = 100299
        '
        'BtCentro
        '
        Me.BtCentro.CL_Ancho = 0
        Me.BtCentro.CL_BuscaAlb = False
        Me.BtCentro.CL_campocodigo = Nothing
        Me.BtCentro.CL_camponombre = Nothing
        Me.BtCentro.CL_CampoOrden = "Nombre"
        Me.BtCentro.CL_ch1000 = False
        Me.BtCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtCentro.CL_ControlAsociado = Nothing
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
        Me.BtCentro.Location = New System.Drawing.Point(850, 46)
        Me.BtCentro.Name = "BtCentro"
        Me.BtCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtCentro.TabIndex = 100298
        Me.BtCentro.UseVisualStyleBackColor = True
        '
        'LbCentro
        '
        Me.LbCentro.AutoSize = True
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = False
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(723, 50)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(57, 16)
        Me.LbCentro.TabIndex = 100297
        Me.LbCentro.Text = "Centro"
        '
        'TxCentro
        '
        Me.TxCentro.Autonumerico = False
        Me.TxCentro.Buscando = False
        Me.TxCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentro.ClForm = Nothing
        Me.TxCentro.ClParam = Nothing
        Me.TxCentro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCentro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentro.GridLin = Nothing
        Me.TxCentro.HaCambiado = False
        Me.TxCentro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCentro.lbbusca = Nothing
        Me.TxCentro.Location = New System.Drawing.Point(787, 47)
        Me.TxCentro.MiError = False
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.Orden = 0
        Me.TxCentro.SaltoAlfinal = False
        Me.TxCentro.Siguiente = 0
        Me.TxCentro.Size = New System.Drawing.Size(57, 22)
        Me.TxCentro.TabIndex = 100296
        Me.TxCentro.TeclaRepetida = False
        Me.TxCentro.TxDatoFinalSemana = Nothing
        Me.TxCentro.TxDatoInicioSemana = Nothing
        Me.TxCentro.UltimoValorValidado = Nothing
        '
        'LbSerie
        '
        Me.LbSerie.AutoSize = True
        Me.LbSerie.CL_ControlAsociado = Nothing
        Me.LbSerie.CL_ValorFijo = False
        Me.LbSerie.ClForm = Nothing
        Me.LbSerie.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSerie.ForeColor = System.Drawing.Color.Teal
        Me.LbSerie.Location = New System.Drawing.Point(723, 75)
        Me.LbSerie.Name = "LbSerie"
        Me.LbSerie.Size = New System.Drawing.Size(45, 16)
        Me.LbSerie.TabIndex = 100301
        Me.LbSerie.Text = "Serie"
        '
        'TxSerie
        '
        Me.TxSerie.Autonumerico = False
        Me.TxSerie.Buscando = False
        Me.TxSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSerie.ClForm = Nothing
        Me.TxSerie.ClParam = Nothing
        Me.TxSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSerie.GridLin = Nothing
        Me.TxSerie.HaCambiado = False
        Me.TxSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSerie.lbbusca = Nothing
        Me.TxSerie.Location = New System.Drawing.Point(787, 72)
        Me.TxSerie.MiError = False
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Orden = 0
        Me.TxSerie.SaltoAlfinal = False
        Me.TxSerie.Siguiente = 0
        Me.TxSerie.Size = New System.Drawing.Size(57, 22)
        Me.TxSerie.TabIndex = 100300
        Me.TxSerie.TeclaRepetida = False
        Me.TxSerie.TxDatoFinalSemana = Nothing
        Me.TxSerie.TxDatoInicioSemana = Nothing
        Me.TxSerie.UltimoValorValidado = Nothing
        '
        'LbFeSemana1
        '
        Me.LbFeSemana1.BackColor = System.Drawing.Color.LightGray
        Me.LbFeSemana1.CL_ControlAsociado = Nothing
        Me.LbFeSemana1.CL_ValorFijo = False
        Me.LbFeSemana1.ClForm = Nothing
        Me.LbFeSemana1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFeSemana1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFeSemana1.Location = New System.Drawing.Point(232, 43)
        Me.LbFeSemana1.Name = "LbFeSemana1"
        Me.LbFeSemana1.Size = New System.Drawing.Size(117, 18)
        Me.LbFeSemana1.TabIndex = 100305
        '
        'BtSemana1
        '
        Me.BtSemana1.CL_Ancho = 0
        Me.BtSemana1.CL_BuscaAlb = False
        Me.BtSemana1.CL_campocodigo = Nothing
        Me.BtSemana1.CL_camponombre = Nothing
        Me.BtSemana1.CL_CampoOrden = "Nombre"
        Me.BtSemana1.CL_ch1000 = False
        Me.BtSemana1.CL_ConsultaSql = "Select * from familias"
        Me.BtSemana1.CL_ControlAsociado = Nothing
        Me.BtSemana1.CL_DevuelveCampo = "Idfamilia"
        Me.BtSemana1.CL_dfecha = Nothing
        Me.BtSemana1.CL_Entidad = Nothing
        Me.BtSemana1.CL_EsId = True
        Me.BtSemana1.CL_Filtro = Nothing
        Me.BtSemana1.cl_formu = Nothing
        Me.BtSemana1.CL_hfecha = Nothing
        Me.BtSemana1.cl_ListaW = Nothing
        Me.BtSemana1.CL_xCentro = False
        Me.BtSemana1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtSemana1.Location = New System.Drawing.Point(191, 41)
        Me.BtSemana1.Name = "BtSemana1"
        Me.BtSemana1.Size = New System.Drawing.Size(33, 23)
        Me.BtSemana1.TabIndex = 100304
        Me.BtSemana1.UseVisualStyleBackColor = True
        '
        'LbSemana1
        '
        Me.LbSemana1.AutoSize = True
        Me.LbSemana1.CL_ControlAsociado = Nothing
        Me.LbSemana1.CL_ValorFijo = False
        Me.LbSemana1.ClForm = Nothing
        Me.LbSemana1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana1.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana1.Location = New System.Drawing.Point(7, 44)
        Me.LbSemana1.Name = "LbSemana1"
        Me.LbSemana1.Size = New System.Drawing.Size(113, 16)
        Me.LbSemana1.TabIndex = 100303
        Me.LbSemana1.Text = "Semana inicial"
        '
        'TxSemana1
        '
        Me.TxSemana1.Autonumerico = False
        Me.TxSemana1.Buscando = False
        Me.TxSemana1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana1.ClForm = Nothing
        Me.TxSemana1.ClParam = Nothing
        Me.TxSemana1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSemana1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana1.GridLin = Nothing
        Me.TxSemana1.HaCambiado = False
        Me.TxSemana1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSemana1.lbbusca = Nothing
        Me.TxSemana1.Location = New System.Drawing.Point(128, 41)
        Me.TxSemana1.MiError = False
        Me.TxSemana1.Name = "TxSemana1"
        Me.TxSemana1.Orden = 0
        Me.TxSemana1.SaltoAlfinal = False
        Me.TxSemana1.Siguiente = 0
        Me.TxSemana1.Size = New System.Drawing.Size(57, 22)
        Me.TxSemana1.TabIndex = 100302
        Me.TxSemana1.TeclaRepetida = False
        Me.TxSemana1.TxDatoFinalSemana = Nothing
        Me.TxSemana1.TxDatoInicioSemana = Nothing
        Me.TxSemana1.UltimoValorValidado = Nothing
        '
        'LbFeSemana2
        '
        Me.LbFeSemana2.BackColor = System.Drawing.Color.LightGray
        Me.LbFeSemana2.CL_ControlAsociado = Nothing
        Me.LbFeSemana2.CL_ValorFijo = False
        Me.LbFeSemana2.ClForm = Nothing
        Me.LbFeSemana2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFeSemana2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFeSemana2.Location = New System.Drawing.Point(594, 43)
        Me.LbFeSemana2.Name = "LbFeSemana2"
        Me.LbFeSemana2.Size = New System.Drawing.Size(117, 18)
        Me.LbFeSemana2.TabIndex = 100309
        '
        'BtSemana2
        '
        Me.BtSemana2.CL_Ancho = 0
        Me.BtSemana2.CL_BuscaAlb = False
        Me.BtSemana2.CL_campocodigo = Nothing
        Me.BtSemana2.CL_camponombre = Nothing
        Me.BtSemana2.CL_CampoOrden = "Nombre"
        Me.BtSemana2.CL_ch1000 = False
        Me.BtSemana2.CL_ConsultaSql = "Select * from familias"
        Me.BtSemana2.CL_ControlAsociado = Nothing
        Me.BtSemana2.CL_DevuelveCampo = "Idfamilia"
        Me.BtSemana2.CL_dfecha = Nothing
        Me.BtSemana2.CL_Entidad = Nothing
        Me.BtSemana2.CL_EsId = True
        Me.BtSemana2.CL_Filtro = Nothing
        Me.BtSemana2.cl_formu = Nothing
        Me.BtSemana2.CL_hfecha = Nothing
        Me.BtSemana2.cl_ListaW = Nothing
        Me.BtSemana2.CL_xCentro = False
        Me.BtSemana2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtSemana2.Location = New System.Drawing.Point(553, 41)
        Me.BtSemana2.Name = "BtSemana2"
        Me.BtSemana2.Size = New System.Drawing.Size(33, 23)
        Me.BtSemana2.TabIndex = 100308
        Me.BtSemana2.UseVisualStyleBackColor = True
        '
        'LbSemana2
        '
        Me.LbSemana2.AutoSize = True
        Me.LbSemana2.CL_ControlAsociado = Nothing
        Me.LbSemana2.CL_ValorFijo = False
        Me.LbSemana2.ClForm = Nothing
        Me.LbSemana2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana2.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana2.Location = New System.Drawing.Point(369, 44)
        Me.LbSemana2.Name = "LbSemana2"
        Me.LbSemana2.Size = New System.Drawing.Size(102, 16)
        Me.LbSemana2.TabIndex = 100307
        Me.LbSemana2.Text = "Semana final"
        '
        'TxSemana2
        '
        Me.TxSemana2.Autonumerico = False
        Me.TxSemana2.Buscando = False
        Me.TxSemana2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana2.ClForm = Nothing
        Me.TxSemana2.ClParam = Nothing
        Me.TxSemana2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSemana2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana2.GridLin = Nothing
        Me.TxSemana2.HaCambiado = False
        Me.TxSemana2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSemana2.lbbusca = Nothing
        Me.TxSemana2.Location = New System.Drawing.Point(490, 41)
        Me.TxSemana2.MiError = False
        Me.TxSemana2.Name = "TxSemana2"
        Me.TxSemana2.Orden = 0
        Me.TxSemana2.SaltoAlfinal = False
        Me.TxSemana2.Siguiente = 0
        Me.TxSemana2.Size = New System.Drawing.Size(57, 22)
        Me.TxSemana2.TabIndex = 100306
        Me.TxSemana2.TeclaRepetida = False
        Me.TxSemana2.TxDatoFinalSemana = Nothing
        Me.TxSemana2.TxDatoInicioSemana = Nothing
        Me.TxSemana2.UltimoValorValidado = Nothing
        '
        'LbEjerFac
        '
        Me.LbEjerFac.AutoSize = True
        Me.LbEjerFac.CL_ControlAsociado = Nothing
        Me.LbEjerFac.CL_ValorFijo = False
        Me.LbEjerFac.ClForm = Nothing
        Me.LbEjerFac.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjerFac.ForeColor = System.Drawing.Color.Teal
        Me.LbEjerFac.Location = New System.Drawing.Point(630, 16)
        Me.LbEjerFac.Name = "LbEjerFac"
        Me.LbEjerFac.Size = New System.Drawing.Size(138, 16)
        Me.LbEjerFac.TabIndex = 100311
        Me.LbEjerFac.Text = "Ejercicio Facturas"
        '
        'TxEjerfac
        '
        Me.TxEjerfac.Autonumerico = False
        Me.TxEjerfac.Buscando = False
        Me.TxEjerfac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjerfac.ClForm = Nothing
        Me.TxEjerfac.ClParam = Nothing
        Me.TxEjerfac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjerfac.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjerfac.GridLin = Nothing
        Me.TxEjerfac.HaCambiado = False
        Me.TxEjerfac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjerfac.lbbusca = Nothing
        Me.TxEjerfac.Location = New System.Drawing.Point(787, 13)
        Me.TxEjerfac.MiError = False
        Me.TxEjerfac.Name = "TxEjerfac"
        Me.TxEjerfac.Orden = 0
        Me.TxEjerfac.SaltoAlfinal = False
        Me.TxEjerfac.Siguiente = 0
        Me.TxEjerfac.Size = New System.Drawing.Size(47, 22)
        Me.TxEjerfac.TabIndex = 100310
        Me.TxEjerfac.TeclaRepetida = False
        Me.TxEjerfac.TxDatoFinalSemana = Nothing
        Me.TxEjerfac.TxDatoInicioSemana = Nothing
        Me.TxEjerfac.UltimoValorValidado = Nothing
        '
        'LbFechaVtoPagare
        '
        Me.LbFechaVtoPagare.AutoSize = True
        Me.LbFechaVtoPagare.CL_ControlAsociado = Nothing
        Me.LbFechaVtoPagare.CL_ValorFijo = False
        Me.LbFechaVtoPagare.ClForm = Nothing
        Me.LbFechaVtoPagare.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaVtoPagare.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaVtoPagare.Location = New System.Drawing.Point(723, 131)
        Me.LbFechaVtoPagare.Name = "LbFechaVtoPagare"
        Me.LbFechaVtoPagare.Size = New System.Drawing.Size(149, 16)
        Me.LbFechaVtoPagare.TabIndex = 100313
        Me.LbFechaVtoPagare.Text = "Fecha Vto. Pagarés"
        '
        'TxFechaVtoPagare
        '
        Me.TxFechaVtoPagare.Autonumerico = False
        Me.TxFechaVtoPagare.Buscando = False
        Me.TxFechaVtoPagare.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaVtoPagare.ClForm = Nothing
        Me.TxFechaVtoPagare.ClParam = Nothing
        Me.TxFechaVtoPagare.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaVtoPagare.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaVtoPagare.GridLin = Nothing
        Me.TxFechaVtoPagare.HaCambiado = False
        Me.TxFechaVtoPagare.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaVtoPagare.lbbusca = Nothing
        Me.TxFechaVtoPagare.Location = New System.Drawing.Point(874, 128)
        Me.TxFechaVtoPagare.MiError = False
        Me.TxFechaVtoPagare.Name = "TxFechaVtoPagare"
        Me.TxFechaVtoPagare.Orden = 0
        Me.TxFechaVtoPagare.SaltoAlfinal = False
        Me.TxFechaVtoPagare.Siguiente = 0
        Me.TxFechaVtoPagare.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaVtoPagare.TabIndex = 100312
        Me.TxFechaVtoPagare.TeclaRepetida = False
        Me.TxFechaVtoPagare.TxDatoFinalSemana = Nothing
        Me.TxFechaVtoPagare.TxDatoInicioSemana = Nothing
        Me.TxFechaVtoPagare.UltimoValorValidado = Nothing
        '
        'FrmGenerarLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 568)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGenerarLiquidaciones"
        Me.Text = "Generar liquidaciones"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFechaLiq As NetAgro.TxDato
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents BtCentro As NetAgro.BtBusca
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents TxCentro As NetAgro.TxDato
    Friend WithEvents LbSerie As NetAgro.Lb
    Friend WithEvents TxSerie As NetAgro.TxDato
    Friend WithEvents LbFeSemana2 As NetAgro.Lb
    Friend WithEvents BtSemana2 As NetAgro.BtBusca
    Friend WithEvents LbSemana2 As NetAgro.Lb
    Friend WithEvents TxSemana2 As NetAgro.TxDato
    Friend WithEvents LbFeSemana1 As NetAgro.Lb
    Friend WithEvents BtSemana1 As NetAgro.BtBusca
    Friend WithEvents LbSemana1 As NetAgro.Lb
    Friend WithEvents TxSemana1 As NetAgro.TxDato
    Friend WithEvents LbEjerFac As NetAgro.Lb
    Friend WithEvents TxEjerfac As NetAgro.TxDato
    Friend WithEvents LbFechaVtoPagare As NetAgro.Lb
    Friend WithEvents TxFechaVtoPagare As NetAgro.TxDato
End Class
