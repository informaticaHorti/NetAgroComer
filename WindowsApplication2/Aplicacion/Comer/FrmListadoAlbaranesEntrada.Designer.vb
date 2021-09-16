<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoAlbaranesEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoAlbaranesEntrada))
        Me.TxAgricultorDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxAgricultorHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbFirmeSClasific = New System.Windows.Forms.RadioButton()
        Me.RbTodosFC = New System.Windows.Forms.RadioButton()
        Me.RbComision = New System.Windows.Forms.RadioButton()
        Me.RbFirme = New System.Windows.Forms.RadioButton()
        Me.CbCentroRecogida = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.chkDetallarAlbaranesResumidos = New NetAgro.Chk(Me.components)
        Me.LbCentroRecogida = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodosConfeccionado = New System.Windows.Forms.RadioButton()
        Me.RbNoConfeccionado = New System.Windows.Forms.RadioButton()
        Me.RbSiConfeccionado = New System.Windows.Forms.RadioButton()
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.TxAlbaranHasta = New NetAgro.TxDato(Me.components)
        Me.LbDesdeAlbaran = New NetAgro.Lb(Me.components)
        Me.LbHastaAlbaran = New NetAgro.Lb(Me.components)
        Me.TxAlbaranDesde = New NetAgro.TxDato(Me.components)
        Me.LbNomGeneroHasta = New NetAgro.Lb(Me.components)
        Me.TxGeneroHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGeneroDesde = New NetAgro.Lb(Me.components)
        Me.TxGeneroDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.TxCategHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCategHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaCateg = New NetAgro.Lb(Me.components)
        Me.TxCategDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCategDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeCateg = New NetAgro.Lb(Me.components)
        Me.LbNomCategDesde = New NetAgro.Lb(Me.components)
        Me.LbNomCategHasta = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTODOSFacturado = New System.Windows.Forms.RadioButton()
        Me.RbNOFacturado = New System.Windows.Forms.RadioButton()
        Me.RbSIFacturado = New System.Windows.Forms.RadioButton()
        Me.ChkIncluirSinCategoria = New NetAgro.Chk(Me.components)
        Me.ChkOcultarObservaciones = New NetAgro.Chk(Me.components)
        Me.LbTipoListado = New NetAgro.Lb(Me.components)
        Me.CbTipoListado = New NetAgro.CbBox(Me.components)
        Me.BtBuscaAlbaranHasta = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaAlbaranDesde = New NetAgro.BtBusca(Me.components)
        Me.ChkDetallarCultivo = New NetAgro.Chk(Me.components)
        Me.ChkDesgloseFondoOperativo = New NetAgro.Chk(Me.components)
        Me.CbPventa = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbPventa)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.ChkDesgloseFondoOperativo)
        Me.PanelCabecera.Controls.Add(Me.ChkDetallarCultivo)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaranHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaranDesde)
        Me.PanelCabecera.Controls.Add(Me.TxCategHasta)
        Me.PanelCabecera.Controls.Add(Me.TxCategDesde)
        Me.PanelCabecera.Controls.Add(Me.CbTipoListado)
        Me.PanelCabecera.Controls.Add(Me.LbTipoListado)
        Me.PanelCabecera.Controls.Add(Me.ChkOcultarObservaciones)
        Me.PanelCabecera.Controls.Add(Me.ChkIncluirSinCategoria)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.LbNomCategHasta)
        Me.PanelCabecera.Controls.Add(Me.LbNomCategDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCategHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaCateg)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCategDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeCateg)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.TxAlbaranHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAlbaran)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAlbaran)
        Me.PanelCabecera.Controls.Add(Me.TxAlbaranDesde)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.LbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.chkDetallarAlbaranesResumidos)
        Me.PanelCabecera.Controls.Add(Me.CbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 226)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 226)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 302)
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
        'TxAgricultorDesde
        '
        Me.TxAgricultorDesde.Autonumerico = False
        Me.TxAgricultorDesde.Buscando = False
        Me.TxAgricultorDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorDesde.ClForm = Nothing
        Me.TxAgricultorDesde.ClParam = Nothing
        Me.TxAgricultorDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorDesde.GridLin = Nothing
        Me.TxAgricultorDesde.HaCambiado = False
        Me.TxAgricultorDesde.lbbusca = Nothing
        Me.TxAgricultorDesde.Location = New System.Drawing.Point(146, 9)
        Me.TxAgricultorDesde.MiError = False
        Me.TxAgricultorDesde.Name = "TxAgricultorDesde"
        Me.TxAgricultorDesde.Orden = 0
        Me.TxAgricultorDesde.SaltoAlfinal = False
        Me.TxAgricultorDesde.Siguiente = 0
        Me.TxAgricultorDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorDesde.TabIndex = 51
        Me.TxAgricultorDesde.TeclaRepetida = False
        Me.TxAgricultorDesde.TxDatoFinalSemana = Nothing
        Me.TxAgricultorDesde.TxDatoInicioSemana = Nothing
        Me.TxAgricultorDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaAgricultorDesde
        '
        Me.BtBuscaAgricultorDesde.CL_Ancho = 0
        Me.BtBuscaAgricultorDesde.CL_BuscaAlb = False
        Me.BtBuscaAgricultorDesde.CL_campocodigo = Nothing
        Me.BtBuscaAgricultorDesde.CL_camponombre = Nothing
        Me.BtBuscaAgricultorDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultorDesde.CL_ch1000 = False
        Me.BtBuscaAgricultorDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultorDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaAgricultorDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultorDesde.CL_dfecha = Nothing
        Me.BtBuscaAgricultorDesde.CL_Entidad = Nothing
        Me.BtBuscaAgricultorDesde.CL_EsId = True
        Me.BtBuscaAgricultorDesde.CL_Filtro = Nothing
        Me.BtBuscaAgricultorDesde.cl_formu = Nothing
        Me.BtBuscaAgricultorDesde.CL_hfecha = Nothing
        Me.BtBuscaAgricultorDesde.cl_ListaW = Nothing
        Me.BtBuscaAgricultorDesde.CL_xCentro = False
        Me.BtBuscaAgricultorDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(215, 9)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 50
        Me.BtBuscaAgricultorDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(12, 12)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(128, 16)
        Me.LbDesdeAgricultor.TabIndex = 49
        Me.LbDesdeAgricultor.Text = "Desde Agricultor"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(254, 9)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorDesde.TabIndex = 75
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(254, 36)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorHasta.TabIndex = 79
        '
        'TxAgricultorHasta
        '
        Me.TxAgricultorHasta.Autonumerico = False
        Me.TxAgricultorHasta.Buscando = False
        Me.TxAgricultorHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorHasta.ClForm = Nothing
        Me.TxAgricultorHasta.ClParam = Nothing
        Me.TxAgricultorHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorHasta.GridLin = Nothing
        Me.TxAgricultorHasta.HaCambiado = False
        Me.TxAgricultorHasta.lbbusca = Nothing
        Me.TxAgricultorHasta.Location = New System.Drawing.Point(146, 36)
        Me.TxAgricultorHasta.MiError = False
        Me.TxAgricultorHasta.Name = "TxAgricultorHasta"
        Me.TxAgricultorHasta.Orden = 0
        Me.TxAgricultorHasta.SaltoAlfinal = False
        Me.TxAgricultorHasta.Siguiente = 0
        Me.TxAgricultorHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorHasta.TabIndex = 78
        Me.TxAgricultorHasta.TeclaRepetida = False
        Me.TxAgricultorHasta.TxDatoFinalSemana = Nothing
        Me.TxAgricultorHasta.TxDatoInicioSemana = Nothing
        Me.TxAgricultorHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaAgricultorHasta
        '
        Me.BtBuscaAgricultorHasta.CL_Ancho = 0
        Me.BtBuscaAgricultorHasta.CL_BuscaAlb = False
        Me.BtBuscaAgricultorHasta.CL_campocodigo = Nothing
        Me.BtBuscaAgricultorHasta.CL_camponombre = Nothing
        Me.BtBuscaAgricultorHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultorHasta.CL_ch1000 = False
        Me.BtBuscaAgricultorHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultorHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaAgricultorHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultorHasta.CL_dfecha = Nothing
        Me.BtBuscaAgricultorHasta.CL_Entidad = Nothing
        Me.BtBuscaAgricultorHasta.CL_EsId = True
        Me.BtBuscaAgricultorHasta.CL_Filtro = Nothing
        Me.BtBuscaAgricultorHasta.cl_formu = Nothing
        Me.BtBuscaAgricultorHasta.CL_hfecha = Nothing
        Me.BtBuscaAgricultorHasta.cl_ListaW = Nothing
        Me.BtBuscaAgricultorHasta.CL_xCentro = False
        Me.BtBuscaAgricultorHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(215, 36)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 77
        Me.BtBuscaAgricultorHasta.UseVisualStyleBackColor = True
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(12, 39)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(126, 16)
        Me.LbHastaAgricultor.TabIndex = 76
        Me.LbHastaAgricultor.Text = "Hasta Agricultor"
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
        Me.TxFechaHasta.Location = New System.Drawing.Point(835, 36)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(732, 39)
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
        Me.TxFechaDesde.Location = New System.Drawing.Point(835, 9)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(732, 12)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbFirmeSClasific)
        Me.GroupBox1.Controls.Add(Me.RbTodosFC)
        Me.GroupBox1.Controls.Add(Me.RbComision)
        Me.GroupBox1.Controls.Add(Me.RbFirme)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(414, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 42)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Albarán"
        '
        'RbFirmeSClasific
        '
        Me.RbFirmeSClasific.AutoSize = True
        Me.RbFirmeSClasific.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFirmeSClasific.ForeColor = System.Drawing.Color.Teal
        Me.RbFirmeSClasific.Location = New System.Drawing.Point(183, 15)
        Me.RbFirmeSClasific.Name = "RbFirmeSClasific"
        Me.RbFirmeSClasific.Size = New System.Drawing.Size(147, 20)
        Me.RbFirmeSClasific.TabIndex = 3
        Me.RbFirmeSClasific.Text = "Firme S/Clasific."
        Me.RbFirmeSClasific.UseVisualStyleBackColor = True
        '
        'RbTodosFC
        '
        Me.RbTodosFC.AutoSize = True
        Me.RbTodosFC.Checked = True
        Me.RbTodosFC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosFC.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosFC.Location = New System.Drawing.Point(331, 15)
        Me.RbTodosFC.Name = "RbTodosFC"
        Me.RbTodosFC.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosFC.TabIndex = 2
        Me.RbTodosFC.TabStop = True
        Me.RbTodosFC.Text = "Todos"
        Me.RbTodosFC.UseVisualStyleBackColor = True
        '
        'RbComision
        '
        Me.RbComision.AutoSize = True
        Me.RbComision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbComision.ForeColor = System.Drawing.Color.Teal
        Me.RbComision.Location = New System.Drawing.Point(85, 15)
        Me.RbComision.Name = "RbComision"
        Me.RbComision.Size = New System.Drawing.Size(93, 20)
        Me.RbComision.TabIndex = 1
        Me.RbComision.Text = "Comisión"
        Me.RbComision.UseVisualStyleBackColor = True
        '
        'RbFirme
        '
        Me.RbFirme.AutoSize = True
        Me.RbFirme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFirme.ForeColor = System.Drawing.Color.Teal
        Me.RbFirme.Location = New System.Drawing.Point(11, 15)
        Me.RbFirme.Name = "RbFirme"
        Me.RbFirme.Size = New System.Drawing.Size(68, 20)
        Me.RbFirme.TabIndex = 0
        Me.RbFirme.Text = "Firme"
        Me.RbFirme.UseVisualStyleBackColor = True
        '
        'CbCentroRecogida
        '
        Me.CbCentroRecogida.EditValue = ""
        Me.CbCentroRecogida.Location = New System.Drawing.Point(146, 121)
        Me.CbCentroRecogida.Name = "CbCentroRecogida"
        Me.CbCentroRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentroRecogida.Size = New System.Drawing.Size(240, 20)
        Me.CbCentroRecogida.TabIndex = 100270
        '
        'chkDetallarAlbaranesResumidos
        '
        Me.chkDetallarAlbaranesResumidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDetallarAlbaranesResumidos.AutoSize = True
        Me.chkDetallarAlbaranesResumidos.Campobd = Nothing
        Me.chkDetallarAlbaranesResumidos.Checked = True
        Me.chkDetallarAlbaranesResumidos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDetallarAlbaranesResumidos.ClForm = Nothing
        Me.chkDetallarAlbaranesResumidos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetallarAlbaranesResumidos.ForeColor = System.Drawing.Color.Teal
        Me.chkDetallarAlbaranesResumidos.GridLin = Nothing
        Me.chkDetallarAlbaranesResumidos.HaCambiado = False
        Me.chkDetallarAlbaranesResumidos.Location = New System.Drawing.Point(522, 171)
        Me.chkDetallarAlbaranesResumidos.MiEntidad = Nothing
        Me.chkDetallarAlbaranesResumidos.MiError = False
        Me.chkDetallarAlbaranesResumidos.Name = "chkDetallarAlbaranesResumidos"
        Me.chkDetallarAlbaranesResumidos.Orden = 0
        Me.chkDetallarAlbaranesResumidos.SaltoAlfinal = False
        Me.chkDetallarAlbaranesResumidos.Size = New System.Drawing.Size(292, 20)
        Me.chkDetallarAlbaranesResumidos.TabIndex = 100271
        Me.chkDetallarAlbaranesResumidos.Text = "Detallar albaranes en List. Resumido"
        Me.chkDetallarAlbaranesResumidos.UseVisualStyleBackColor = True
        Me.chkDetallarAlbaranesResumidos.ValorCampoFalse = Nothing
        Me.chkDetallarAlbaranesResumidos.ValorCampoTrue = Nothing
        Me.chkDetallarAlbaranesResumidos.ValorDefecto = False
        '
        'LbCentroRecogida
        '
        Me.LbCentroRecogida.AutoSize = True
        Me.LbCentroRecogida.CL_ControlAsociado = Nothing
        Me.LbCentroRecogida.CL_ValorFijo = True
        Me.LbCentroRecogida.ClForm = Nothing
        Me.LbCentroRecogida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentroRecogida.ForeColor = System.Drawing.Color.Teal
        Me.LbCentroRecogida.Location = New System.Drawing.Point(12, 122)
        Me.LbCentroRecogida.Name = "LbCentroRecogida"
        Me.LbCentroRecogida.Size = New System.Drawing.Size(112, 16)
        Me.LbCentroRecogida.TabIndex = 100272
        Me.LbCentroRecogida.Text = "C.R. Agricultor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodosConfeccionado)
        Me.GroupBox2.Controls.Add(Me.RbNoConfeccionado)
        Me.GroupBox2.Controls.Add(Me.RbSiConfeccionado)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(824, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entradas directas"
        '
        'RbTodosConfeccionado
        '
        Me.RbTodosConfeccionado.AutoSize = True
        Me.RbTodosConfeccionado.Checked = True
        Me.RbTodosConfeccionado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosConfeccionado.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosConfeccionado.Location = New System.Drawing.Point(114, 16)
        Me.RbTodosConfeccionado.Name = "RbTodosConfeccionado"
        Me.RbTodosConfeccionado.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosConfeccionado.TabIndex = 2
        Me.RbTodosConfeccionado.TabStop = True
        Me.RbTodosConfeccionado.Text = "Todos"
        Me.RbTodosConfeccionado.UseVisualStyleBackColor = True
        '
        'RbNoConfeccionado
        '
        Me.RbNoConfeccionado.AutoSize = True
        Me.RbNoConfeccionado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoConfeccionado.ForeColor = System.Drawing.Color.Teal
        Me.RbNoConfeccionado.Location = New System.Drawing.Point(63, 16)
        Me.RbNoConfeccionado.Name = "RbNoConfeccionado"
        Me.RbNoConfeccionado.Size = New System.Drawing.Size(47, 20)
        Me.RbNoConfeccionado.TabIndex = 1
        Me.RbNoConfeccionado.Text = "NO"
        Me.RbNoConfeccionado.UseVisualStyleBackColor = True
        '
        'RbSiConfeccionado
        '
        Me.RbSiConfeccionado.AutoSize = True
        Me.RbSiConfeccionado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiConfeccionado.ForeColor = System.Drawing.Color.Teal
        Me.RbSiConfeccionado.Location = New System.Drawing.Point(16, 16)
        Me.RbSiConfeccionado.Name = "RbSiConfeccionado"
        Me.RbSiConfeccionado.Size = New System.Drawing.Size(41, 20)
        Me.RbSiConfeccionado.TabIndex = 0
        Me.RbSiConfeccionado.Text = "SI"
        Me.RbSiConfeccionado.UseVisualStyleBackColor = True
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 147)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100275
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(146, 146)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(240, 20)
        Me.CbEmpresas.TabIndex = 100274
        '
        'TxAlbaranHasta
        '
        Me.TxAlbaranHasta.Autonumerico = False
        Me.TxAlbaranHasta.Buscando = False
        Me.TxAlbaranHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlbaranHasta.ClForm = Nothing
        Me.TxAlbaranHasta.ClParam = Nothing
        Me.TxAlbaranHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlbaranHasta.GridLin = Nothing
        Me.TxAlbaranHasta.HaCambiado = False
        Me.TxAlbaranHasta.lbbusca = Nothing
        Me.TxAlbaranHasta.Location = New System.Drawing.Point(1073, 36)
        Me.TxAlbaranHasta.MiError = False
        Me.TxAlbaranHasta.Name = "TxAlbaranHasta"
        Me.TxAlbaranHasta.Orden = 0
        Me.TxAlbaranHasta.SaltoAlfinal = False
        Me.TxAlbaranHasta.Siguiente = 0
        Me.TxAlbaranHasta.Size = New System.Drawing.Size(102, 22)
        Me.TxAlbaranHasta.TabIndex = 100279
        Me.TxAlbaranHasta.TeclaRepetida = False
        Me.TxAlbaranHasta.TxDatoFinalSemana = Nothing
        Me.TxAlbaranHasta.TxDatoInicioSemana = Nothing
        Me.TxAlbaranHasta.UltimoValorValidado = Nothing
        '
        'LbDesdeAlbaran
        '
        Me.LbDesdeAlbaran.AutoSize = True
        Me.LbDesdeAlbaran.CL_ControlAsociado = Nothing
        Me.LbDesdeAlbaran.CL_ValorFijo = False
        Me.LbDesdeAlbaran.ClForm = Nothing
        Me.LbDesdeAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAlbaran.Location = New System.Drawing.Point(955, 12)
        Me.LbDesdeAlbaran.Name = "LbDesdeAlbaran"
        Me.LbDesdeAlbaran.Size = New System.Drawing.Size(112, 16)
        Me.LbDesdeAlbaran.TabIndex = 100276
        Me.LbDesdeAlbaran.Text = "Desde albarán"
        '
        'LbHastaAlbaran
        '
        Me.LbHastaAlbaran.AutoSize = True
        Me.LbHastaAlbaran.CL_ControlAsociado = Nothing
        Me.LbHastaAlbaran.CL_ValorFijo = False
        Me.LbHastaAlbaran.ClForm = Nothing
        Me.LbHastaAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAlbaran.Location = New System.Drawing.Point(955, 39)
        Me.LbHastaAlbaran.Name = "LbHastaAlbaran"
        Me.LbHastaAlbaran.Size = New System.Drawing.Size(110, 16)
        Me.LbHastaAlbaran.TabIndex = 100278
        Me.LbHastaAlbaran.Text = "Hasta albarán"
        '
        'TxAlbaranDesde
        '
        Me.TxAlbaranDesde.Autonumerico = False
        Me.TxAlbaranDesde.Buscando = False
        Me.TxAlbaranDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlbaranDesde.ClForm = Nothing
        Me.TxAlbaranDesde.ClParam = Nothing
        Me.TxAlbaranDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlbaranDesde.GridLin = Nothing
        Me.TxAlbaranDesde.HaCambiado = False
        Me.TxAlbaranDesde.lbbusca = Nothing
        Me.TxAlbaranDesde.Location = New System.Drawing.Point(1073, 9)
        Me.TxAlbaranDesde.MiError = False
        Me.TxAlbaranDesde.Name = "TxAlbaranDesde"
        Me.TxAlbaranDesde.Orden = 0
        Me.TxAlbaranDesde.SaltoAlfinal = False
        Me.TxAlbaranDesde.Siguiente = 0
        Me.TxAlbaranDesde.Size = New System.Drawing.Size(102, 22)
        Me.TxAlbaranDesde.TabIndex = 100277
        Me.TxAlbaranDesde.TeclaRepetida = False
        Me.TxAlbaranDesde.TxDatoFinalSemana = Nothing
        Me.TxAlbaranDesde.TxDatoInicioSemana = Nothing
        Me.TxAlbaranDesde.UltimoValorValidado = Nothing
        '
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(254, 90)
        Me.LbNomGeneroHasta.Name = "LbNomGeneroHasta"
        Me.LbNomGeneroHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomGeneroHasta.TabIndex = 100287
        '
        'TxGeneroHasta
        '
        Me.TxGeneroHasta.Autonumerico = False
        Me.TxGeneroHasta.Buscando = False
        Me.TxGeneroHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGeneroHasta.ClForm = Nothing
        Me.TxGeneroHasta.ClParam = Nothing
        Me.TxGeneroHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGeneroHasta.GridLin = Nothing
        Me.TxGeneroHasta.HaCambiado = False
        Me.TxGeneroHasta.lbbusca = Nothing
        Me.TxGeneroHasta.Location = New System.Drawing.Point(146, 90)
        Me.TxGeneroHasta.MiError = False
        Me.TxGeneroHasta.Name = "TxGeneroHasta"
        Me.TxGeneroHasta.Orden = 0
        Me.TxGeneroHasta.SaltoAlfinal = False
        Me.TxGeneroHasta.Siguiente = 0
        Me.TxGeneroHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxGeneroHasta.TabIndex = 100286
        Me.TxGeneroHasta.TeclaRepetida = False
        Me.TxGeneroHasta.TxDatoFinalSemana = Nothing
        Me.TxGeneroHasta.TxDatoInicioSemana = Nothing
        Me.TxGeneroHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroHasta
        '
        Me.BtBuscaGeneroHasta.CL_Ancho = 0
        Me.BtBuscaGeneroHasta.CL_BuscaAlb = False
        Me.BtBuscaGeneroHasta.CL_campocodigo = Nothing
        Me.BtBuscaGeneroHasta.CL_camponombre = Nothing
        Me.BtBuscaGeneroHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroHasta.CL_ch1000 = False
        Me.BtBuscaGeneroHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroHasta.CL_dfecha = Nothing
        Me.BtBuscaGeneroHasta.CL_Entidad = Nothing
        Me.BtBuscaGeneroHasta.CL_EsId = True
        Me.BtBuscaGeneroHasta.CL_Filtro = Nothing
        Me.BtBuscaGeneroHasta.cl_formu = Nothing
        Me.BtBuscaGeneroHasta.CL_hfecha = Nothing
        Me.BtBuscaGeneroHasta.cl_ListaW = Nothing
        Me.BtBuscaGeneroHasta.CL_xCentro = False
        Me.BtBuscaGeneroHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(215, 90)
        Me.BtBuscaGeneroHasta.Name = "BtBuscaGeneroHasta"
        Me.BtBuscaGeneroHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroHasta.TabIndex = 100285
        Me.BtBuscaGeneroHasta.UseVisualStyleBackColor = True
        '
        'LbHastaGenero
        '
        Me.LbHastaGenero.AutoSize = True
        Me.LbHastaGenero.CL_ControlAsociado = Nothing
        Me.LbHastaGenero.CL_ValorFijo = False
        Me.LbHastaGenero.ClForm = Nothing
        Me.LbHastaGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaGenero.Location = New System.Drawing.Point(12, 93)
        Me.LbHastaGenero.Name = "LbHastaGenero"
        Me.LbHastaGenero.Size = New System.Drawing.Size(107, 16)
        Me.LbHastaGenero.TabIndex = 100284
        Me.LbHastaGenero.Text = "Hasta Género"
        '
        'LbNomGeneroDesde
        '
        Me.LbNomGeneroDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroDesde.CL_ControlAsociado = Nothing
        Me.LbNomGeneroDesde.CL_ValorFijo = False
        Me.LbNomGeneroDesde.ClForm = Nothing
        Me.LbNomGeneroDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(254, 63)
        Me.LbNomGeneroDesde.Name = "LbNomGeneroDesde"
        Me.LbNomGeneroDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomGeneroDesde.TabIndex = 100283
        '
        'TxGeneroDesde
        '
        Me.TxGeneroDesde.Autonumerico = False
        Me.TxGeneroDesde.Buscando = False
        Me.TxGeneroDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGeneroDesde.ClForm = Nothing
        Me.TxGeneroDesde.ClParam = Nothing
        Me.TxGeneroDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGeneroDesde.GridLin = Nothing
        Me.TxGeneroDesde.HaCambiado = False
        Me.TxGeneroDesde.lbbusca = Nothing
        Me.TxGeneroDesde.Location = New System.Drawing.Point(146, 63)
        Me.TxGeneroDesde.MiError = False
        Me.TxGeneroDesde.Name = "TxGeneroDesde"
        Me.TxGeneroDesde.Orden = 0
        Me.TxGeneroDesde.SaltoAlfinal = False
        Me.TxGeneroDesde.Siguiente = 0
        Me.TxGeneroDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxGeneroDesde.TabIndex = 100282
        Me.TxGeneroDesde.TeclaRepetida = False
        Me.TxGeneroDesde.TxDatoFinalSemana = Nothing
        Me.TxGeneroDesde.TxDatoInicioSemana = Nothing
        Me.TxGeneroDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroDesde
        '
        Me.BtBuscaGeneroDesde.CL_Ancho = 0
        Me.BtBuscaGeneroDesde.CL_BuscaAlb = False
        Me.BtBuscaGeneroDesde.CL_campocodigo = Nothing
        Me.BtBuscaGeneroDesde.CL_camponombre = Nothing
        Me.BtBuscaGeneroDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroDesde.CL_ch1000 = False
        Me.BtBuscaGeneroDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroDesde.CL_dfecha = Nothing
        Me.BtBuscaGeneroDesde.CL_Entidad = Nothing
        Me.BtBuscaGeneroDesde.CL_EsId = True
        Me.BtBuscaGeneroDesde.CL_Filtro = Nothing
        Me.BtBuscaGeneroDesde.cl_formu = Nothing
        Me.BtBuscaGeneroDesde.CL_hfecha = Nothing
        Me.BtBuscaGeneroDesde.cl_ListaW = Nothing
        Me.BtBuscaGeneroDesde.CL_xCentro = False
        Me.BtBuscaGeneroDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(215, 63)
        Me.BtBuscaGeneroDesde.Name = "BtBuscaGeneroDesde"
        Me.BtBuscaGeneroDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroDesde.TabIndex = 100281
        Me.BtBuscaGeneroDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeGenero
        '
        Me.LbDesdeGenero.AutoSize = True
        Me.LbDesdeGenero.CL_ControlAsociado = Nothing
        Me.LbDesdeGenero.CL_ValorFijo = False
        Me.LbDesdeGenero.ClForm = Nothing
        Me.LbDesdeGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeGenero.Location = New System.Drawing.Point(12, 66)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 100280
        Me.LbDesdeGenero.Text = "Desde Genero"
        '
        'TxCategHasta
        '
        Me.TxCategHasta.Autonumerico = False
        Me.TxCategHasta.Buscando = False
        Me.TxCategHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategHasta.ClForm = Nothing
        Me.TxCategHasta.ClParam = Nothing
        Me.TxCategHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategHasta.GridLin = Nothing
        Me.TxCategHasta.HaCambiado = False
        Me.TxCategHasta.lbbusca = Nothing
        Me.TxCategHasta.Location = New System.Drawing.Point(835, 90)
        Me.TxCategHasta.MiError = False
        Me.TxCategHasta.Name = "TxCategHasta"
        Me.TxCategHasta.Orden = 0
        Me.TxCategHasta.SaltoAlfinal = False
        Me.TxCategHasta.Siguiente = 0
        Me.TxCategHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxCategHasta.TabIndex = 100293
        Me.TxCategHasta.TeclaRepetida = False
        Me.TxCategHasta.TxDatoFinalSemana = Nothing
        Me.TxCategHasta.TxDatoInicioSemana = Nothing
        Me.TxCategHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaCategHasta
        '
        Me.BtBuscaCategHasta.CL_Ancho = 0
        Me.BtBuscaCategHasta.CL_BuscaAlb = False
        Me.BtBuscaCategHasta.CL_campocodigo = Nothing
        Me.BtBuscaCategHasta.CL_camponombre = Nothing
        Me.BtBuscaCategHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaCategHasta.CL_ch1000 = False
        Me.BtBuscaCategHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCategHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaCategHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCategHasta.CL_dfecha = Nothing
        Me.BtBuscaCategHasta.CL_Entidad = Nothing
        Me.BtBuscaCategHasta.CL_EsId = True
        Me.BtBuscaCategHasta.CL_Filtro = Nothing
        Me.BtBuscaCategHasta.cl_formu = Nothing
        Me.BtBuscaCategHasta.CL_hfecha = Nothing
        Me.BtBuscaCategHasta.cl_ListaW = Nothing
        Me.BtBuscaCategHasta.CL_xCentro = False
        Me.BtBuscaCategHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCategHasta.Location = New System.Drawing.Point(904, 90)
        Me.BtBuscaCategHasta.Name = "BtBuscaCategHasta"
        Me.BtBuscaCategHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCategHasta.TabIndex = 100292
        Me.BtBuscaCategHasta.UseVisualStyleBackColor = True
        '
        'LbHastaCateg
        '
        Me.LbHastaCateg.AutoSize = True
        Me.LbHastaCateg.CL_ControlAsociado = Nothing
        Me.LbHastaCateg.CL_ValorFijo = False
        Me.LbHastaCateg.ClForm = Nothing
        Me.LbHastaCateg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaCateg.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaCateg.Location = New System.Drawing.Point(732, 93)
        Me.LbHastaCateg.Name = "LbHastaCateg"
        Me.LbHastaCateg.Size = New System.Drawing.Size(103, 16)
        Me.LbHastaCateg.TabIndex = 100291
        Me.LbHastaCateg.Text = "Hasta Categ."
        '
        'TxCategDesde
        '
        Me.TxCategDesde.Autonumerico = False
        Me.TxCategDesde.Buscando = False
        Me.TxCategDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategDesde.ClForm = Nothing
        Me.TxCategDesde.ClParam = Nothing
        Me.TxCategDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategDesde.GridLin = Nothing
        Me.TxCategDesde.HaCambiado = False
        Me.TxCategDesde.lbbusca = Nothing
        Me.TxCategDesde.Location = New System.Drawing.Point(835, 63)
        Me.TxCategDesde.MiError = False
        Me.TxCategDesde.Name = "TxCategDesde"
        Me.TxCategDesde.Orden = 0
        Me.TxCategDesde.SaltoAlfinal = False
        Me.TxCategDesde.Siguiente = 0
        Me.TxCategDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxCategDesde.TabIndex = 100290
        Me.TxCategDesde.TeclaRepetida = False
        Me.TxCategDesde.TxDatoFinalSemana = Nothing
        Me.TxCategDesde.TxDatoInicioSemana = Nothing
        Me.TxCategDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaCategDesde
        '
        Me.BtBuscaCategDesde.CL_Ancho = 0
        Me.BtBuscaCategDesde.CL_BuscaAlb = False
        Me.BtBuscaCategDesde.CL_campocodigo = Nothing
        Me.BtBuscaCategDesde.CL_camponombre = Nothing
        Me.BtBuscaCategDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaCategDesde.CL_ch1000 = False
        Me.BtBuscaCategDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCategDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaCategDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCategDesde.CL_dfecha = Nothing
        Me.BtBuscaCategDesde.CL_Entidad = Nothing
        Me.BtBuscaCategDesde.CL_EsId = True
        Me.BtBuscaCategDesde.CL_Filtro = Nothing
        Me.BtBuscaCategDesde.cl_formu = Nothing
        Me.BtBuscaCategDesde.CL_hfecha = Nothing
        Me.BtBuscaCategDesde.cl_ListaW = Nothing
        Me.BtBuscaCategDesde.CL_xCentro = False
        Me.BtBuscaCategDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCategDesde.Location = New System.Drawing.Point(904, 63)
        Me.BtBuscaCategDesde.Name = "BtBuscaCategDesde"
        Me.BtBuscaCategDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCategDesde.TabIndex = 100289
        Me.BtBuscaCategDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeCateg
        '
        Me.LbDesdeCateg.AutoSize = True
        Me.LbDesdeCateg.CL_ControlAsociado = Nothing
        Me.LbDesdeCateg.CL_ValorFijo = False
        Me.LbDesdeCateg.ClForm = Nothing
        Me.LbDesdeCateg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeCateg.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeCateg.Location = New System.Drawing.Point(732, 66)
        Me.LbDesdeCateg.Name = "LbDesdeCateg"
        Me.LbDesdeCateg.Size = New System.Drawing.Size(105, 16)
        Me.LbDesdeCateg.TabIndex = 100288
        Me.LbDesdeCateg.Text = "Desde Categ."
        '
        'LbNomCategDesde
        '
        Me.LbNomCategDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategDesde.CL_ControlAsociado = Nothing
        Me.LbNomCategDesde.CL_ValorFijo = False
        Me.LbNomCategDesde.ClForm = Nothing
        Me.LbNomCategDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategDesde.Location = New System.Drawing.Point(943, 63)
        Me.LbNomCategDesde.Name = "LbNomCategDesde"
        Me.LbNomCategDesde.Size = New System.Drawing.Size(270, 23)
        Me.LbNomCategDesde.TabIndex = 100294
        '
        'LbNomCategHasta
        '
        Me.LbNomCategHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategHasta.CL_ControlAsociado = Nothing
        Me.LbNomCategHasta.CL_ValorFijo = False
        Me.LbNomCategHasta.ClForm = Nothing
        Me.LbNomCategHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategHasta.Location = New System.Drawing.Point(943, 90)
        Me.LbNomCategHasta.Name = "LbNomCategHasta"
        Me.LbNomCategHasta.Size = New System.Drawing.Size(270, 23)
        Me.LbNomCategHasta.TabIndex = 100295
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTODOSFacturado)
        Me.GroupBox3.Controls.Add(Me.RbNOFacturado)
        Me.GroupBox3.Controls.Add(Me.RbSIFacturado)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(1022, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox3.TabIndex = 100296
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturado"
        '
        'RbTODOSFacturado
        '
        Me.RbTODOSFacturado.AutoSize = True
        Me.RbTODOSFacturado.Checked = True
        Me.RbTODOSFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODOSFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbTODOSFacturado.Location = New System.Drawing.Point(114, 16)
        Me.RbTODOSFacturado.Name = "RbTODOSFacturado"
        Me.RbTODOSFacturado.Size = New System.Drawing.Size(69, 20)
        Me.RbTODOSFacturado.TabIndex = 2
        Me.RbTODOSFacturado.TabStop = True
        Me.RbTODOSFacturado.Text = "Todos"
        Me.RbTODOSFacturado.UseVisualStyleBackColor = True
        '
        'RbNOFacturado
        '
        Me.RbNOFacturado.AutoSize = True
        Me.RbNOFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNOFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbNOFacturado.Location = New System.Drawing.Point(63, 16)
        Me.RbNOFacturado.Name = "RbNOFacturado"
        Me.RbNOFacturado.Size = New System.Drawing.Size(47, 20)
        Me.RbNOFacturado.TabIndex = 1
        Me.RbNOFacturado.Text = "NO"
        Me.RbNOFacturado.UseVisualStyleBackColor = True
        '
        'RbSIFacturado
        '
        Me.RbSIFacturado.AutoSize = True
        Me.RbSIFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSIFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbSIFacturado.Location = New System.Drawing.Point(16, 16)
        Me.RbSIFacturado.Name = "RbSIFacturado"
        Me.RbSIFacturado.Size = New System.Drawing.Size(41, 20)
        Me.RbSIFacturado.TabIndex = 0
        Me.RbSIFacturado.Text = "SI"
        Me.RbSIFacturado.UseVisualStyleBackColor = True
        '
        'ChkIncluirSinCategoria
        '
        Me.ChkIncluirSinCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIncluirSinCategoria.AutoSize = True
        Me.ChkIncluirSinCategoria.Campobd = Nothing
        Me.ChkIncluirSinCategoria.ClForm = Nothing
        Me.ChkIncluirSinCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIncluirSinCategoria.ForeColor = System.Drawing.Color.Teal
        Me.ChkIncluirSinCategoria.GridLin = Nothing
        Me.ChkIncluirSinCategoria.HaCambiado = False
        Me.ChkIncluirSinCategoria.Location = New System.Drawing.Point(831, 171)
        Me.ChkIncluirSinCategoria.MiEntidad = Nothing
        Me.ChkIncluirSinCategoria.MiError = False
        Me.ChkIncluirSinCategoria.Name = "ChkIncluirSinCategoria"
        Me.ChkIncluirSinCategoria.Orden = 0
        Me.ChkIncluirSinCategoria.SaltoAlfinal = False
        Me.ChkIncluirSinCategoria.Size = New System.Drawing.Size(174, 20)
        Me.ChkIncluirSinCategoria.TabIndex = 100297
        Me.ChkIncluirSinCategoria.Text = "Incluir Sin Categoría"
        Me.ChkIncluirSinCategoria.UseVisualStyleBackColor = True
        Me.ChkIncluirSinCategoria.ValorCampoFalse = Nothing
        Me.ChkIncluirSinCategoria.ValorCampoTrue = Nothing
        Me.ChkIncluirSinCategoria.ValorDefecto = False
        '
        'ChkOcultarObservaciones
        '
        Me.ChkOcultarObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkOcultarObservaciones.AutoSize = True
        Me.ChkOcultarObservaciones.Campobd = Nothing
        Me.ChkOcultarObservaciones.ClForm = Nothing
        Me.ChkOcultarObservaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOcultarObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.ChkOcultarObservaciones.GridLin = Nothing
        Me.ChkOcultarObservaciones.HaCambiado = False
        Me.ChkOcultarObservaciones.Location = New System.Drawing.Point(1023, 171)
        Me.ChkOcultarObservaciones.MiEntidad = Nothing
        Me.ChkOcultarObservaciones.MiError = False
        Me.ChkOcultarObservaciones.Name = "ChkOcultarObservaciones"
        Me.ChkOcultarObservaciones.Orden = 0
        Me.ChkOcultarObservaciones.SaltoAlfinal = False
        Me.ChkOcultarObservaciones.Size = New System.Drawing.Size(190, 20)
        Me.ChkOcultarObservaciones.TabIndex = 100298
        Me.ChkOcultarObservaciones.Text = "Ocultar observaciones"
        Me.ChkOcultarObservaciones.UseVisualStyleBackColor = True
        Me.ChkOcultarObservaciones.ValorCampoFalse = Nothing
        Me.ChkOcultarObservaciones.ValorCampoTrue = Nothing
        Me.ChkOcultarObservaciones.ValorDefecto = False
        '
        'LbTipoListado
        '
        Me.LbTipoListado.AutoSize = True
        Me.LbTipoListado.CL_ControlAsociado = Nothing
        Me.LbTipoListado.CL_ValorFijo = True
        Me.LbTipoListado.ClForm = Nothing
        Me.LbTipoListado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoListado.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoListado.Location = New System.Drawing.Point(12, 196)
        Me.LbTipoListado.Name = "LbTipoListado"
        Me.LbTipoListado.Size = New System.Drawing.Size(91, 16)
        Me.LbTipoListado.TabIndex = 100299
        Me.LbTipoListado.Text = "Tipo listado"
        '
        'CbTipoListado
        '
        Me.CbTipoListado.Campobd = Nothing
        Me.CbTipoListado.ClForm = Nothing
        Me.CbTipoListado.DeshabilitarRuedaRaton = False
        Me.CbTipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoListado.FormattingEnabled = True
        Me.CbTipoListado.GridLin = Nothing
        Me.CbTipoListado.Location = New System.Drawing.Point(146, 194)
        Me.CbTipoListado.MiEntidad = Nothing
        Me.CbTipoListado.MiError = False
        Me.CbTipoListado.Name = "CbTipoListado"
        Me.CbTipoListado.Orden = 0
        Me.CbTipoListado.SaltoAlfinal = False
        Me.CbTipoListado.Size = New System.Drawing.Size(347, 21)
        Me.CbTipoListado.TabIndex = 100300
        '
        'BtBuscaAlbaranHasta
        '
        Me.BtBuscaAlbaranHasta.CL_Ancho = 0
        Me.BtBuscaAlbaranHasta.CL_BuscaAlb = False
        Me.BtBuscaAlbaranHasta.CL_campocodigo = Nothing
        Me.BtBuscaAlbaranHasta.CL_camponombre = Nothing
        Me.BtBuscaAlbaranHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaranHasta.CL_ch1000 = False
        Me.BtBuscaAlbaranHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaranHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaAlbaranHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaranHasta.CL_dfecha = Nothing
        Me.BtBuscaAlbaranHasta.CL_Entidad = Nothing
        Me.BtBuscaAlbaranHasta.CL_EsId = True
        Me.BtBuscaAlbaranHasta.CL_Filtro = Nothing
        Me.BtBuscaAlbaranHasta.cl_formu = Nothing
        Me.BtBuscaAlbaranHasta.CL_hfecha = Nothing
        Me.BtBuscaAlbaranHasta.cl_ListaW = Nothing
        Me.BtBuscaAlbaranHasta.CL_xCentro = False
        Me.BtBuscaAlbaranHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaranHasta.Location = New System.Drawing.Point(1180, 36)
        Me.BtBuscaAlbaranHasta.Name = "BtBuscaAlbaranHasta"
        Me.BtBuscaAlbaranHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaranHasta.TabIndex = 100302
        Me.BtBuscaAlbaranHasta.UseVisualStyleBackColor = True
        '
        'BtBuscaAlbaranDesde
        '
        Me.BtBuscaAlbaranDesde.CL_Ancho = 0
        Me.BtBuscaAlbaranDesde.CL_BuscaAlb = False
        Me.BtBuscaAlbaranDesde.CL_campocodigo = Nothing
        Me.BtBuscaAlbaranDesde.CL_camponombre = Nothing
        Me.BtBuscaAlbaranDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaranDesde.CL_ch1000 = False
        Me.BtBuscaAlbaranDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaranDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaAlbaranDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaranDesde.CL_dfecha = Nothing
        Me.BtBuscaAlbaranDesde.CL_Entidad = Nothing
        Me.BtBuscaAlbaranDesde.CL_EsId = True
        Me.BtBuscaAlbaranDesde.CL_Filtro = Nothing
        Me.BtBuscaAlbaranDesde.cl_formu = Nothing
        Me.BtBuscaAlbaranDesde.CL_hfecha = Nothing
        Me.BtBuscaAlbaranDesde.cl_ListaW = Nothing
        Me.BtBuscaAlbaranDesde.CL_xCentro = False
        Me.BtBuscaAlbaranDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaranDesde.Location = New System.Drawing.Point(1180, 9)
        Me.BtBuscaAlbaranDesde.Name = "BtBuscaAlbaranDesde"
        Me.BtBuscaAlbaranDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaranDesde.TabIndex = 100301
        Me.BtBuscaAlbaranDesde.UseVisualStyleBackColor = True
        '
        'ChkDetallarCultivo
        '
        Me.ChkDetallarCultivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDetallarCultivo.AutoSize = True
        Me.ChkDetallarCultivo.Campobd = Nothing
        Me.ChkDetallarCultivo.ClForm = Nothing
        Me.ChkDetallarCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDetallarCultivo.ForeColor = System.Drawing.Color.Teal
        Me.ChkDetallarCultivo.GridLin = Nothing
        Me.ChkDetallarCultivo.HaCambiado = False
        Me.ChkDetallarCultivo.Location = New System.Drawing.Point(1023, 200)
        Me.ChkDetallarCultivo.MiEntidad = Nothing
        Me.ChkDetallarCultivo.MiError = False
        Me.ChkDetallarCultivo.Name = "ChkDetallarCultivo"
        Me.ChkDetallarCultivo.Orden = 0
        Me.ChkDetallarCultivo.SaltoAlfinal = False
        Me.ChkDetallarCultivo.Size = New System.Drawing.Size(176, 20)
        Me.ChkDetallarCultivo.TabIndex = 100303
        Me.ChkDetallarCultivo.Text = "Detallar Cod. Cultivo"
        Me.ChkDetallarCultivo.UseVisualStyleBackColor = True
        Me.ChkDetallarCultivo.ValorCampoFalse = Nothing
        Me.ChkDetallarCultivo.ValorCampoTrue = Nothing
        Me.ChkDetallarCultivo.ValorDefecto = False
        '
        'ChkDesgloseFondoOperativo
        '
        Me.ChkDesgloseFondoOperativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDesgloseFondoOperativo.AutoSize = True
        Me.ChkDesgloseFondoOperativo.Campobd = Nothing
        Me.ChkDesgloseFondoOperativo.ClForm = Nothing
        Me.ChkDesgloseFondoOperativo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDesgloseFondoOperativo.ForeColor = System.Drawing.Color.Teal
        Me.ChkDesgloseFondoOperativo.GridLin = Nothing
        Me.ChkDesgloseFondoOperativo.HaCambiado = False
        Me.ChkDesgloseFondoOperativo.Location = New System.Drawing.Point(522, 200)
        Me.ChkDesgloseFondoOperativo.MiEntidad = Nothing
        Me.ChkDesgloseFondoOperativo.MiError = False
        Me.ChkDesgloseFondoOperativo.Name = "ChkDesgloseFondoOperativo"
        Me.ChkDesgloseFondoOperativo.Orden = 0
        Me.ChkDesgloseFondoOperativo.SaltoAlfinal = False
        Me.ChkDesgloseFondoOperativo.Size = New System.Drawing.Size(218, 20)
        Me.ChkDesgloseFondoOperativo.TabIndex = 100304
        Me.ChkDesgloseFondoOperativo.Text = "Desglose Fondo Operativo"
        Me.ChkDesgloseFondoOperativo.UseVisualStyleBackColor = True
        Me.ChkDesgloseFondoOperativo.ValorCampoFalse = Nothing
        Me.ChkDesgloseFondoOperativo.ValorCampoTrue = Nothing
        Me.ChkDesgloseFondoOperativo.ValorDefecto = False
        '
        'CbPventa
        '
        Me.CbPventa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPventa.EditValue = ""
        Me.CbPventa.Location = New System.Drawing.Point(146, 170)
        Me.CbPventa.Name = "CbPventa"
        Me.CbPventa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPventa.Size = New System.Drawing.Size(240, 20)
        Me.CbPventa.TabIndex = 100318
        '
        'Lb5
        '
        Me.Lb5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(12, 171)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(65, 16)
        Me.Lb5.TabIndex = 100317
        Me.Lb5.Text = "P.Venta"
        '
        'FrmListadoAlbaranesEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.LbNomAgricultorHasta)
        Me.Controls.Add(Me.TxAgricultorHasta)
        Me.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.Controls.Add(Me.LbHastaAgricultor)
        Me.Controls.Add(Me.LbNomAgricultorDesde)
        Me.Controls.Add(Me.TxAgricultorDesde)
        Me.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.Controls.Add(Me.LbDesdeAgricultor)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoAlbaranesEntrada"
        Me.Text = "Listado albaranes entrada"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.LbDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAgricultorDesde, 0)
        Me.Controls.SetChildIndex(Me.TxAgricultorDesde, 0)
        Me.Controls.SetChildIndex(Me.LbNomAgricultorDesde, 0)
        Me.Controls.SetChildIndex(Me.LbHastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAgricultorHasta, 0)
        Me.Controls.SetChildIndex(Me.TxAgricultorHasta, 0)
        Me.Controls.SetChildIndex(Me.LbNomAgricultorHasta, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxAgricultorDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxAgricultorHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbCentroRecogida As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents chkDetallarAlbaranesResumidos As NetAgro.Chk
    Friend WithEvents LbCentroRecogida As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosConfeccionado As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoConfeccionado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiConfeccionado As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodosFC As System.Windows.Forms.RadioButton
    Friend WithEvents RbComision As System.Windows.Forms.RadioButton
    Friend WithEvents RbFirme As System.Windows.Forms.RadioButton
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents TxAlbaranHasta As NetAgro.TxDato
    Friend WithEvents LbDesdeAlbaran As NetAgro.Lb
    Friend WithEvents LbHastaAlbaran As NetAgro.Lb
    Friend WithEvents TxAlbaranDesde As NetAgro.TxDato
    Friend WithEvents LbNomGeneroHasta As NetAgro.Lb
    Friend WithEvents TxGeneroHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents LbNomGeneroDesde As NetAgro.Lb
    Friend WithEvents TxGeneroDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents LbNomCategHasta As NetAgro.Lb
    Friend WithEvents LbNomCategDesde As NetAgro.Lb
    Friend WithEvents TxCategHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaCategHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaCateg As NetAgro.Lb
    Friend WithEvents TxCategDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaCategDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeCateg As NetAgro.Lb
    Friend WithEvents RbFirmeSClasific As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTODOSFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents RbNOFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSIFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents ChkOcultarObservaciones As NetAgro.Chk
    Friend WithEvents ChkIncluirSinCategoria As NetAgro.Chk
    Friend WithEvents LbTipoListado As NetAgro.Lb
    Friend WithEvents CbTipoListado As NetAgro.CbBox
    Friend WithEvents BtBuscaAlbaranHasta As NetAgro.BtBusca
    Friend WithEvents BtBuscaAlbaranDesde As NetAgro.BtBusca
    Friend WithEvents ChkDetallarCultivo As NetAgro.Chk
    Friend WithEvents ChkDesgloseFondoOperativo As NetAgro.Chk
    Friend WithEvents CbPventa As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
