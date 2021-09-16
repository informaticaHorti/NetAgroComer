<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClasificacionesProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClasificacionesProveedor))
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNomGeneroHasta = New NetAgro.Lb(Me.components)
        Me.TxGeneroHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGeneroDesde = New NetAgro.Lb(Me.components)
        Me.TxGeneroDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.ChkMostrarObservaciones = New NetAgro.Chk(Me.components)
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxAgricultorHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.TxAgricultorDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSClasif = New System.Windows.Forms.RadioButton()
        Me.RbFCSTodos = New System.Windows.Forms.RadioButton()
        Me.RbComision = New System.Windows.Forms.RadioButton()
        Me.RbFirme = New System.Windows.Forms.RadioButton()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbCentrosRecogida = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ChkHojaPorCliente = New NetAgro.Chk(Me.components)
        Me.ChkGenerarPDF = New NetAgro.Chk(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxRutaPDF = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btRuta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNOValorados = New System.Windows.Forms.RadioButton()
        Me.RbTODOSValorados = New System.Windows.Forms.RadioButton()
        Me.RbSIValorados = New System.Windows.Forms.RadioButton()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.ChkDetallarPrecios = New NetAgro.Chk(Me.components)
        Me.CbPventa = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbCentrosRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbPventa)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.ChkDetallarPrecios)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.btRuta)
        Me.PanelCabecera.Controls.Add(Me.TxRutaPDF)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.ChkGenerarPDF)
        Me.PanelCabecera.Controls.Add(Me.ChkHojaPorCliente)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.CbCentrosRecogida)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.ChkMostrarObservaciones)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 184)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 201)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 408)
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
        Me.TxFechaHasta.Location = New System.Drawing.Point(821, 69)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(718, 72)
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
        Me.TxFechaDesde.Location = New System.Drawing.Point(821, 41)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(718, 44)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(718, 98)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(66, 16)
        Me.LbEmpresa.TabIndex = 100275
        Me.LbEmpresa.Text = "Empesa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(821, 96)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(240, 20)
        Me.CbEmpresas.TabIndex = 100274
        '
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(254, 124)
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
        Me.TxGeneroHasta.Location = New System.Drawing.Point(146, 124)
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
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(215, 124)
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
        Me.LbHastaGenero.Location = New System.Drawing.Point(12, 127)
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
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(254, 95)
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
        Me.TxGeneroDesde.Location = New System.Drawing.Point(146, 95)
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
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(215, 95)
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
        Me.LbDesdeGenero.Location = New System.Drawing.Point(12, 98)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 100280
        Me.LbDesdeGenero.Text = "Desde Genero"
        '
        'ChkMostrarObservaciones
        '
        Me.ChkMostrarObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMostrarObservaciones.AutoSize = True
        Me.ChkMostrarObservaciones.Campobd = Nothing
        Me.ChkMostrarObservaciones.Checked = True
        Me.ChkMostrarObservaciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMostrarObservaciones.ClForm = Nothing
        Me.ChkMostrarObservaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMostrarObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.ChkMostrarObservaciones.GridLin = Nothing
        Me.ChkMostrarObservaciones.HaCambiado = False
        Me.ChkMostrarObservaciones.Location = New System.Drawing.Point(1081, 73)
        Me.ChkMostrarObservaciones.MiEntidad = Nothing
        Me.ChkMostrarObservaciones.MiError = False
        Me.ChkMostrarObservaciones.Name = "ChkMostrarObservaciones"
        Me.ChkMostrarObservaciones.Orden = 0
        Me.ChkMostrarObservaciones.SaltoAlfinal = False
        Me.ChkMostrarObservaciones.Size = New System.Drawing.Size(118, 20)
        Me.ChkMostrarObservaciones.TabIndex = 100298
        Me.ChkMostrarObservaciones.Text = "Mostrar obs."
        Me.ChkMostrarObservaciones.UseVisualStyleBackColor = True
        Me.ChkMostrarObservaciones.ValorCampoFalse = Nothing
        Me.ChkMostrarObservaciones.ValorCampoTrue = Nothing
        Me.ChkMostrarObservaciones.ValorDefecto = False
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(254, 66)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorHasta.TabIndex = 100306
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
        Me.TxAgricultorHasta.Location = New System.Drawing.Point(146, 66)
        Me.TxAgricultorHasta.MiError = False
        Me.TxAgricultorHasta.Name = "TxAgricultorHasta"
        Me.TxAgricultorHasta.Orden = 0
        Me.TxAgricultorHasta.SaltoAlfinal = False
        Me.TxAgricultorHasta.Siguiente = 0
        Me.TxAgricultorHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorHasta.TabIndex = 100305
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
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(215, 66)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 100304
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
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(12, 69)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(126, 16)
        Me.LbHastaAgricultor.TabIndex = 100303
        Me.LbHastaAgricultor.Text = "Hasta Agricultor"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(254, 38)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorDesde.TabIndex = 100302
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
        Me.TxAgricultorDesde.Location = New System.Drawing.Point(146, 38)
        Me.TxAgricultorDesde.MiError = False
        Me.TxAgricultorDesde.Name = "TxAgricultorDesde"
        Me.TxAgricultorDesde.Orden = 0
        Me.TxAgricultorDesde.SaltoAlfinal = False
        Me.TxAgricultorDesde.Siguiente = 0
        Me.TxAgricultorDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorDesde.TabIndex = 100301
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
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(215, 38)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 100300
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
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(12, 41)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(128, 16)
        Me.LbDesdeAgricultor.TabIndex = 100299
        Me.LbDesdeAgricultor.Text = "Desde Agricultor"
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(146, 8)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(63, 22)
        Me.TxSemana.TabIndex = 100308
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(12, 11)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100307
        Me.LbSemana.Text = "Semana"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbSClasif)
        Me.GroupBox2.Controls.Add(Me.RbFCSTodos)
        Me.GroupBox2.Controls.Add(Me.RbComision)
        Me.GroupBox2.Controls.Add(Me.RbFirme)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(835, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 33)
        Me.GroupBox2.TabIndex = 100309
        Me.GroupBox2.TabStop = False
        '
        'rbSClasif
        '
        Me.rbSClasif.AutoSize = True
        Me.rbSClasif.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSClasif.ForeColor = System.Drawing.Color.Blue
        Me.rbSClasif.Location = New System.Drawing.Point(191, 12)
        Me.rbSClasif.Name = "rbSClasif"
        Me.rbSClasif.Size = New System.Drawing.Size(85, 17)
        Me.rbSClasif.TabIndex = 3
        Me.rbSClasif.Text = "S/ Clasif."
        Me.rbSClasif.UseVisualStyleBackColor = True
        '
        'RbFCSTodos
        '
        Me.RbFCSTodos.AutoSize = True
        Me.RbFCSTodos.Checked = True
        Me.RbFCSTodos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFCSTodos.ForeColor = System.Drawing.Color.Blue
        Me.RbFCSTodos.Location = New System.Drawing.Point(291, 12)
        Me.RbFCSTodos.Name = "RbFCSTodos"
        Me.RbFCSTodos.Size = New System.Drawing.Size(64, 17)
        Me.RbFCSTodos.TabIndex = 2
        Me.RbFCSTodos.TabStop = True
        Me.RbFCSTodos.Text = "Todos"
        Me.RbFCSTodos.UseVisualStyleBackColor = True
        '
        'RbComision
        '
        Me.RbComision.AutoSize = True
        Me.RbComision.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbComision.ForeColor = System.Drawing.Color.Blue
        Me.RbComision.Location = New System.Drawing.Point(89, 12)
        Me.RbComision.Name = "RbComision"
        Me.RbComision.Size = New System.Drawing.Size(84, 17)
        Me.RbComision.TabIndex = 1
        Me.RbComision.Text = "Comision"
        Me.RbComision.UseVisualStyleBackColor = True
        '
        'RbFirme
        '
        Me.RbFirme.AutoSize = True
        Me.RbFirme.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFirme.ForeColor = System.Drawing.Color.Blue
        Me.RbFirme.Location = New System.Drawing.Point(10, 12)
        Me.RbFirme.Name = "RbFirme"
        Me.RbFirme.Size = New System.Drawing.Size(63, 17)
        Me.RbFirme.TabIndex = 0
        Me.RbFirme.Text = "Firme"
        Me.RbFirme.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Blue
        Me.Lb1.Location = New System.Drawing.Point(718, 17)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(99, 16)
        Me.Lb1.TabIndex = 100310
        Me.Lb1.Text = "Tipo entrada"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(254, 11)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(108, 16)
        Me.Lb5.TabIndex = 100312
        Me.Lb5.Text = "C.R.Agricultor"
        '
        'CbCentrosRecogida
        '
        Me.CbCentrosRecogida.EditValue = ""
        Me.CbCentrosRecogida.Location = New System.Drawing.Point(390, 9)
        Me.CbCentrosRecogida.Name = "CbCentrosRecogida"
        Me.CbCentrosRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentrosRecogida.Size = New System.Drawing.Size(312, 20)
        Me.CbCentrosRecogida.TabIndex = 100311
        '
        'ChkHojaPorCliente
        '
        Me.ChkHojaPorCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHojaPorCliente.AutoSize = True
        Me.ChkHojaPorCliente.Campobd = Nothing
        Me.ChkHojaPorCliente.ClForm = Nothing
        Me.ChkHojaPorCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHojaPorCliente.ForeColor = System.Drawing.Color.Teal
        Me.ChkHojaPorCliente.GridLin = Nothing
        Me.ChkHojaPorCliente.HaCambiado = False
        Me.ChkHojaPorCliente.Location = New System.Drawing.Point(1081, 97)
        Me.ChkHojaPorCliente.MiEntidad = Nothing
        Me.ChkHojaPorCliente.MiError = False
        Me.ChkHojaPorCliente.Name = "ChkHojaPorCliente"
        Me.ChkHojaPorCliente.Orden = 0
        Me.ChkHojaPorCliente.SaltoAlfinal = False
        Me.ChkHojaPorCliente.Size = New System.Drawing.Size(131, 20)
        Me.ChkHojaPorCliente.TabIndex = 100313
        Me.ChkHojaPorCliente.Text = "Hoja por prov."
        Me.ChkHojaPorCliente.UseVisualStyleBackColor = True
        Me.ChkHojaPorCliente.ValorCampoFalse = Nothing
        Me.ChkHojaPorCliente.ValorCampoTrue = Nothing
        Me.ChkHojaPorCliente.ValorDefecto = False
        '
        'ChkGenerarPDF
        '
        Me.ChkGenerarPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkGenerarPDF.AutoSize = True
        Me.ChkGenerarPDF.Campobd = Nothing
        Me.ChkGenerarPDF.ClForm = Nothing
        Me.ChkGenerarPDF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGenerarPDF.ForeColor = System.Drawing.Color.Teal
        Me.ChkGenerarPDF.GridLin = Nothing
        Me.ChkGenerarPDF.HaCambiado = False
        Me.ChkGenerarPDF.Location = New System.Drawing.Point(1081, 123)
        Me.ChkGenerarPDF.MiEntidad = Nothing
        Me.ChkGenerarPDF.MiError = False
        Me.ChkGenerarPDF.Name = "ChkGenerarPDF"
        Me.ChkGenerarPDF.Orden = 0
        Me.ChkGenerarPDF.SaltoAlfinal = False
        Me.ChkGenerarPDF.Size = New System.Drawing.Size(113, 20)
        Me.ChkGenerarPDF.TabIndex = 100314
        Me.ChkGenerarPDF.Text = "GenerarPDF"
        Me.ChkGenerarPDF.UseVisualStyleBackColor = True
        Me.ChkGenerarPDF.ValorCampoFalse = Nothing
        Me.ChkGenerarPDF.ValorCampoTrue = Nothing
        Me.ChkGenerarPDF.ValorDefecto = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 157)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(73, 16)
        Me.Lb2.TabIndex = 100315
        Me.Lb2.Text = "Ruta PDF"
        '
        'TxRutaPDF
        '
        Me.TxRutaPDF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxRutaPDF.Location = New System.Drawing.Point(146, 154)
        Me.TxRutaPDF.Name = "TxRutaPDF"
        Me.TxRutaPDF.ReadOnly = True
        Me.TxRutaPDF.Size = New System.Drawing.Size(729, 22)
        Me.TxRutaPDF.TabIndex = 100316
        '
        'btRuta
        '
        Me.btRuta.Location = New System.Drawing.Point(881, 154)
        Me.btRuta.Name = "btRuta"
        Me.btRuta.Size = New System.Drawing.Size(27, 23)
        Me.btRuta.TabIndex = 100317
        Me.btRuta.Text = "..."
        Me.btRuta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNOValorados)
        Me.GroupBox1.Controls.Add(Me.RbTODOSValorados)
        Me.GroupBox1.Controls.Add(Me.RbSIValorados)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(1024, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 33)
        Me.GroupBox1.TabIndex = 100318
        Me.GroupBox1.TabStop = False
        '
        'rbNOValorados
        '
        Me.rbNOValorados.AutoSize = True
        Me.rbNOValorados.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOValorados.ForeColor = System.Drawing.Color.Blue
        Me.rbNOValorados.Location = New System.Drawing.Point(57, 12)
        Me.rbNOValorados.Name = "rbNOValorados"
        Me.rbNOValorados.Size = New System.Drawing.Size(43, 17)
        Me.rbNOValorados.TabIndex = 3
        Me.rbNOValorados.Text = "NO"
        Me.rbNOValorados.UseVisualStyleBackColor = True
        '
        'RbTODOSValorados
        '
        Me.RbTODOSValorados.AutoSize = True
        Me.RbTODOSValorados.Checked = True
        Me.RbTODOSValorados.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODOSValorados.ForeColor = System.Drawing.Color.Blue
        Me.RbTODOSValorados.Location = New System.Drawing.Point(106, 12)
        Me.RbTODOSValorados.Name = "RbTODOSValorados"
        Me.RbTODOSValorados.Size = New System.Drawing.Size(64, 17)
        Me.RbTODOSValorados.TabIndex = 2
        Me.RbTODOSValorados.TabStop = True
        Me.RbTODOSValorados.Text = "Todos"
        Me.RbTODOSValorados.UseVisualStyleBackColor = True
        '
        'RbSIValorados
        '
        Me.RbSIValorados.AutoSize = True
        Me.RbSIValorados.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSIValorados.ForeColor = System.Drawing.Color.Blue
        Me.RbSIValorados.Location = New System.Drawing.Point(12, 12)
        Me.RbSIValorados.Name = "RbSIValorados"
        Me.RbSIValorados.Size = New System.Drawing.Size(39, 17)
        Me.RbSIValorados.TabIndex = 1
        Me.RbSIValorados.Text = "SI"
        Me.RbSIValorados.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Blue
        Me.Lb3.Location = New System.Drawing.Point(937, 44)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(81, 16)
        Me.Lb3.TabIndex = 100319
        Me.Lb3.Text = "Valorados"
        '
        'ChkDetallarPrecios
        '
        Me.ChkDetallarPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDetallarPrecios.AutoSize = True
        Me.ChkDetallarPrecios.Campobd = Nothing
        Me.ChkDetallarPrecios.ClForm = Nothing
        Me.ChkDetallarPrecios.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDetallarPrecios.ForeColor = System.Drawing.Color.Teal
        Me.ChkDetallarPrecios.GridLin = Nothing
        Me.ChkDetallarPrecios.HaCambiado = False
        Me.ChkDetallarPrecios.Location = New System.Drawing.Point(1081, 149)
        Me.ChkDetallarPrecios.MiEntidad = Nothing
        Me.ChkDetallarPrecios.MiError = False
        Me.ChkDetallarPrecios.Name = "ChkDetallarPrecios"
        Me.ChkDetallarPrecios.Orden = 0
        Me.ChkDetallarPrecios.SaltoAlfinal = False
        Me.ChkDetallarPrecios.Size = New System.Drawing.Size(141, 20)
        Me.ChkDetallarPrecios.TabIndex = 100320
        Me.ChkDetallarPrecios.Text = "Detallar precios"
        Me.ChkDetallarPrecios.UseVisualStyleBackColor = True
        Me.ChkDetallarPrecios.ValorCampoFalse = Nothing
        Me.ChkDetallarPrecios.ValorCampoTrue = Nothing
        Me.ChkDetallarPrecios.ValorDefecto = False
        '
        'CbPventa
        '
        Me.CbPventa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPventa.EditValue = ""
        Me.CbPventa.Location = New System.Drawing.Point(821, 122)
        Me.CbPventa.Name = "CbPventa"
        Me.CbPventa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPventa.Size = New System.Drawing.Size(240, 20)
        Me.CbPventa.TabIndex = 100322
        '
        'Lb4
        '
        Me.Lb4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(719, 123)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(65, 16)
        Me.Lb4.TabIndex = 100321
        Me.Lb4.Text = "P.Venta"
        '
        'FrmClasificacionesProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 649)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmClasificacionesProveedor"
        Me.Text = "Listado de clasificaciones por proveedor"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbCentrosRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbNomGeneroHasta As NetAgro.Lb
    Friend WithEvents TxGeneroHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents LbNomGeneroDesde As NetAgro.Lb
    Friend WithEvents TxGeneroDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents ChkMostrarObservaciones As NetAgro.Chk
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxAgricultorHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents TxAgricultorDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFCSTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbComision As System.Windows.Forms.RadioButton
    Friend WithEvents RbFirme As System.Windows.Forms.RadioButton
    Friend WithEvents rbSClasif As System.Windows.Forms.RadioButton
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbCentrosRecogida As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkHojaPorCliente As NetAgro.Chk
    Friend WithEvents ChkGenerarPDF As NetAgro.Chk
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxRutaPDF As System.Windows.Forms.TextBox
    Friend WithEvents btRuta As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNOValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbTODOSValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbSIValorados As System.Windows.Forms.RadioButton
    Friend WithEvents ChkDetallarPrecios As NetAgro.Chk
    Friend WithEvents CbPventa As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb4 As NetAgro.Lb
End Class
