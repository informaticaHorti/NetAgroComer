<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalidasporcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalidasporcliente))
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
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
        Me.ChAlmacen = New System.Windows.Forms.CheckBox()
        Me.ChMarca = New System.Windows.Forms.CheckBox()
        Me.ChCategoria = New System.Windows.Forms.CheckBox()
        Me.ChConfeccion = New System.Windows.Forms.CheckBox()
        Me.ChAlbaran = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbGeneroCliente = New System.Windows.Forms.RadioButton()
        Me.RbClienteGenero = New System.Windows.Forms.RadioButton()
        Me.RbCliente = New System.Windows.Forms.RadioButton()
        Me.RbGenero = New System.Windows.Forms.RadioButton()
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxClienteHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.TxClienteDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.ChReferencia = New System.Windows.Forms.CheckBox()
        Me.ChKilo = New System.Windows.Forms.CheckBox()
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.ChKilo)
        Me.PanelCabecera.Controls.Add(Me.ChReferencia)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.TxClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.TxClienteDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.TxCategHasta)
        Me.PanelCabecera.Controls.Add(Me.TxCategDesde)
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
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 215)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 212)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 310)
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
        Me.TxFechaHasta.Location = New System.Drawing.Point(835, 34)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(732, 37)
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
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(254, 84)
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
        Me.TxGeneroHasta.Location = New System.Drawing.Point(146, 84)
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
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(215, 84)
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
        Me.LbHastaGenero.Location = New System.Drawing.Point(12, 87)
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
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(254, 59)
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
        Me.TxGeneroDesde.Location = New System.Drawing.Point(146, 59)
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
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(215, 59)
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
        Me.LbDesdeGenero.Location = New System.Drawing.Point(12, 62)
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
        Me.TxCategHasta.Location = New System.Drawing.Point(835, 84)
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
        Me.BtBuscaCategHasta.Location = New System.Drawing.Point(904, 84)
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
        Me.LbHastaCateg.Location = New System.Drawing.Point(732, 87)
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
        Me.TxCategDesde.Location = New System.Drawing.Point(835, 59)
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
        Me.BtBuscaCategDesde.Location = New System.Drawing.Point(904, 59)
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
        Me.LbDesdeCateg.Location = New System.Drawing.Point(732, 62)
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
        Me.LbNomCategDesde.Location = New System.Drawing.Point(943, 59)
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
        Me.LbNomCategHasta.Location = New System.Drawing.Point(943, 84)
        Me.LbNomCategHasta.Name = "LbNomCategHasta"
        Me.LbNomCategHasta.Size = New System.Drawing.Size(270, 23)
        Me.LbNomCategHasta.TabIndex = 100295
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChAlmacen)
        Me.GroupBox3.Controls.Add(Me.ChMarca)
        Me.GroupBox3.Controls.Add(Me.ChCategoria)
        Me.GroupBox3.Controls.Add(Me.ChConfeccion)
        Me.GroupBox3.Controls.Add(Me.ChAlbaran)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(307, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 99)
        Me.GroupBox3.TabIndex = 100296
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detallar"
        '
        'ChAlmacen
        '
        Me.ChAlmacen.AutoSize = True
        Me.ChAlmacen.Location = New System.Drawing.Point(4, 82)
        Me.ChAlmacen.Name = "ChAlmacen"
        Me.ChAlmacen.Size = New System.Drawing.Size(128, 17)
        Me.ChAlmacen.TabIndex = 4
        Me.ChAlmacen.Text = "Gastos almacén"
        Me.ChAlmacen.UseVisualStyleBackColor = True
        '
        'ChMarca
        '
        Me.ChMarca.AutoSize = True
        Me.ChMarca.Location = New System.Drawing.Point(4, 64)
        Me.ChMarca.Name = "ChMarca"
        Me.ChMarca.Size = New System.Drawing.Size(64, 17)
        Me.ChMarca.TabIndex = 3
        Me.ChMarca.Text = "Marca"
        Me.ChMarca.UseVisualStyleBackColor = True
        '
        'ChCategoria
        '
        Me.ChCategoria.AutoSize = True
        Me.ChCategoria.Location = New System.Drawing.Point(3, 47)
        Me.ChCategoria.Name = "ChCategoria"
        Me.ChCategoria.Size = New System.Drawing.Size(88, 17)
        Me.ChCategoria.TabIndex = 2
        Me.ChCategoria.Text = "Categoria"
        Me.ChCategoria.UseVisualStyleBackColor = True
        '
        'ChConfeccion
        '
        Me.ChConfeccion.AutoSize = True
        Me.ChConfeccion.Location = New System.Drawing.Point(3, 30)
        Me.ChConfeccion.Name = "ChConfeccion"
        Me.ChConfeccion.Size = New System.Drawing.Size(152, 17)
        Me.ChConfeccion.TabIndex = 1
        Me.ChConfeccion.Text = "Tipos de confección"
        Me.ChConfeccion.UseVisualStyleBackColor = True
        '
        'ChAlbaran
        '
        Me.ChAlbaran.AutoSize = True
        Me.ChAlbaran.Location = New System.Drawing.Point(3, 13)
        Me.ChAlbaran.Name = "ChAlbaran"
        Me.ChAlbaran.Size = New System.Drawing.Size(91, 17)
        Me.ChAlbaran.TabIndex = 0
        Me.ChAlbaran.Text = "Albaranes"
        Me.ChAlbaran.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbGeneroCliente)
        Me.GroupBox4.Controls.Add(Me.RbClienteGenero)
        Me.GroupBox4.Controls.Add(Me.RbCliente)
        Me.GroupBox4.Controls.Add(Me.RbGenero)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 68)
        Me.GroupBox4.TabIndex = 100304
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones"
        '
        'RbGeneroCliente
        '
        Me.RbGeneroCliente.AutoSize = True
        Me.RbGeneroCliente.Checked = True
        Me.RbGeneroCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbGeneroCliente.ForeColor = System.Drawing.Color.Teal
        Me.RbGeneroCliente.Location = New System.Drawing.Point(128, 42)
        Me.RbGeneroCliente.Name = "RbGeneroCliente"
        Me.RbGeneroCliente.Size = New System.Drawing.Size(144, 20)
        Me.RbGeneroCliente.TabIndex = 3
        Me.RbGeneroCliente.TabStop = True
        Me.RbGeneroCliente.Text = "Genero - Cliente"
        Me.RbGeneroCliente.UseVisualStyleBackColor = True
        '
        'RbClienteGenero
        '
        Me.RbClienteGenero.AutoSize = True
        Me.RbClienteGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbClienteGenero.ForeColor = System.Drawing.Color.Teal
        Me.RbClienteGenero.Location = New System.Drawing.Point(128, 16)
        Me.RbClienteGenero.Name = "RbClienteGenero"
        Me.RbClienteGenero.Size = New System.Drawing.Size(144, 20)
        Me.RbClienteGenero.TabIndex = 2
        Me.RbClienteGenero.Text = "Cliente - Genero"
        Me.RbClienteGenero.UseVisualStyleBackColor = True
        '
        'RbCliente
        '
        Me.RbCliente.AutoSize = True
        Me.RbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCliente.ForeColor = System.Drawing.Color.Teal
        Me.RbCliente.Location = New System.Drawing.Point(17, 42)
        Me.RbCliente.Name = "RbCliente"
        Me.RbCliente.Size = New System.Drawing.Size(77, 20)
        Me.RbCliente.TabIndex = 1
        Me.RbCliente.Text = "Cliente"
        Me.RbCliente.UseVisualStyleBackColor = True
        '
        'RbGenero
        '
        Me.RbGenero.AutoSize = True
        Me.RbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbGenero.ForeColor = System.Drawing.Color.Teal
        Me.RbGenero.Location = New System.Drawing.Point(16, 16)
        Me.RbGenero.Name = "RbGenero"
        Me.RbGenero.Size = New System.Drawing.Size(78, 20)
        Me.RbGenero.TabIndex = 0
        Me.RbGenero.Text = "Genero"
        Me.RbGenero.UseVisualStyleBackColor = True
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(254, 33)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorHasta.TabIndex = 100320
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
        Me.TxClienteHasta.Location = New System.Drawing.Point(146, 33)
        Me.TxClienteHasta.MiError = False
        Me.TxClienteHasta.Name = "TxClienteHasta"
        Me.TxClienteHasta.Orden = 0
        Me.TxClienteHasta.SaltoAlfinal = False
        Me.TxClienteHasta.Siguiente = 0
        Me.TxClienteHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteHasta.TabIndex = 100319
        Me.TxClienteHasta.TeclaRepetida = False
        Me.TxClienteHasta.TxDatoFinalSemana = Nothing
        Me.TxClienteHasta.TxDatoInicioSemana = Nothing
        Me.TxClienteHasta.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(215, 33)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 100318
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
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(12, 36)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaAgricultor.TabIndex = 100317
        Me.LbHastaAgricultor.Text = "Hasta Cliente"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(254, 8)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorDesde.TabIndex = 100316
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
        Me.TxClienteDesde.Location = New System.Drawing.Point(146, 8)
        Me.TxClienteDesde.MiError = False
        Me.TxClienteDesde.Name = "TxClienteDesde"
        Me.TxClienteDesde.Orden = 0
        Me.TxClienteDesde.SaltoAlfinal = False
        Me.TxClienteDesde.Siguiente = 0
        Me.TxClienteDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteDesde.TabIndex = 100315
        Me.TxClienteDesde.TeclaRepetida = False
        Me.TxClienteDesde.TxDatoFinalSemana = Nothing
        Me.TxClienteDesde.TxDatoInicioSemana = Nothing
        Me.TxClienteDesde.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(215, 8)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 100314
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
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(12, 11)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeAgricultor.TabIndex = 100313
        Me.LbDesdeAgricultor.Text = "Desde Cliente"
        '
        'ChReferencia
        '
        Me.ChReferencia.AutoSize = True
        Me.ChReferencia.Checked = True
        Me.ChReferencia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChReferencia.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChReferencia.Location = New System.Drawing.Point(482, 123)
        Me.ChReferencia.Name = "ChReferencia"
        Me.ChReferencia.Size = New System.Drawing.Size(233, 18)
        Me.ChReferencia.TabIndex = 100321
        Me.ChReferencia.Text = "Incluir salidas a precio referencia"
        Me.ChReferencia.UseVisualStyleBackColor = True
        '
        'ChKilo
        '
        Me.ChKilo.AutoSize = True
        Me.ChKilo.Checked = True
        Me.ChKilo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChKilo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKilo.Location = New System.Drawing.Point(482, 146)
        Me.ChKilo.Name = "ChKilo"
        Me.ChKilo.Size = New System.Drawing.Size(105, 18)
        Me.ChKilo.TabIndex = 100322
        Me.ChKilo.Text = "Mostar x kilo"
        Me.ChKilo.UseVisualStyleBackColor = True
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(835, 121)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(160, 20)
        Me.cbCentro.TabIndex = 100324
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(734, 123)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100323
        Me.Lb5.Text = "Centro"
        '
        'FrmSalidasporcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmSalidasporcliente"
        Me.Text = "Salidas por cliente"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbClienteGenero As System.Windows.Forms.RadioButton
    Friend WithEvents RbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents RbGenero As System.Windows.Forms.RadioButton
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxClienteHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents TxClienteDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents RbGeneroCliente As System.Windows.Forms.RadioButton
    Friend WithEvents ChKilo As System.Windows.Forms.CheckBox
    Friend WithEvents ChReferencia As System.Windows.Forms.CheckBox
    Friend WithEvents ChAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents ChMarca As System.Windows.Forms.CheckBox
    Friend WithEvents ChCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents ChConfeccion As System.Windows.Forms.CheckBox
    Friend WithEvents ChAlbaran As System.Windows.Forms.CheckBox
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
