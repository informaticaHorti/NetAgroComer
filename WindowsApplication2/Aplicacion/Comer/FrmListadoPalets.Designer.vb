<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoPalets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoPalets))
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbCargados = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RbEnExistencias = New System.Windows.Forms.RadioButton()
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbDetallado = New System.Windows.Forms.RadioButton()
        Me.RbResumido = New System.Windows.Forms.RadioButton()
        Me.LbNomGeneroHasta = New NetAgro.Lb(Me.components)
        Me.TxGeneroHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGeneroDesde = New NetAgro.Lb(Me.components)
        Me.TxGeneroDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.LbNumPalets = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbNoTerminados = New System.Windows.Forms.RadioButton()
        Me.RbTodosTerminados = New System.Windows.Forms.RadioButton()
        Me.RbTerminados = New System.Windows.Forms.RadioButton()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.CbSituacion = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ChkVisualizarMermas = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CbSituacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.ChkVisualizarMermas)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.CbSituacion)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.LbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 124)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 130)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 372)
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
        Me.TxFechaHasta.Location = New System.Drawing.Point(751, 41)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(648, 44)
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
        Me.TxFechaDesde.Location = New System.Drawing.Point(751, 14)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(648, 17)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbCargados)
        Me.GroupBox1.Controls.Add(Me.RbTodos)
        Me.GroupBox1.Controls.Add(Me.RbEnExistencias)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(753, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 42)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de palets"
        '
        'RbCargados
        '
        Me.RbCargados.AutoSize = True
        Me.RbCargados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCargados.ForeColor = System.Drawing.Color.Teal
        Me.RbCargados.Location = New System.Drawing.Point(199, 15)
        Me.RbCargados.Name = "RbCargados"
        Me.RbCargados.Size = New System.Drawing.Size(95, 20)
        Me.RbCargados.TabIndex = 3
        Me.RbCargados.Text = "Cargados"
        Me.RbCargados.UseVisualStyleBackColor = True
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbTodos.Location = New System.Drawing.Point(319, 15)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbTodos.TabIndex = 2
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RbEnExistencias
        '
        Me.RbEnExistencias.AutoSize = True
        Me.RbEnExistencias.Checked = True
        Me.RbEnExistencias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnExistencias.ForeColor = System.Drawing.Color.Teal
        Me.RbEnExistencias.Location = New System.Drawing.Point(40, 15)
        Me.RbEnExistencias.Name = "RbEnExistencias"
        Me.RbEnExistencias.Size = New System.Drawing.Size(131, 20)
        Me.RbEnExistencias.TabIndex = 1
        Me.RbEnExistencias.TabStop = True
        Me.RbEnExistencias.Text = "En Existencias"
        Me.RbEnExistencias.UseVisualStyleBackColor = True
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(967, 15)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.CL_ControlAsociado = Nothing
        Me.LbPuntoVenta.CL_ValorFijo = True
        Me.LbPuntoVenta.ClForm = Nothing
        Me.LbPuntoVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPuntoVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPuntoVenta.Location = New System.Drawing.Point(896, 17)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(65, 16)
        Me.LbPuntoVenta.TabIndex = 100272
        Me.LbPuntoVenta.Text = "P.Venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbDetallado)
        Me.GroupBox2.Controls.Add(Me.RbResumido)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 42)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo listado"
        '
        'RbDetallado
        '
        Me.RbDetallado.AutoSize = True
        Me.RbDetallado.Checked = True
        Me.RbDetallado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetallado.ForeColor = System.Drawing.Color.Teal
        Me.RbDetallado.Location = New System.Drawing.Point(130, 16)
        Me.RbDetallado.Name = "RbDetallado"
        Me.RbDetallado.Size = New System.Drawing.Size(95, 20)
        Me.RbDetallado.TabIndex = 2
        Me.RbDetallado.TabStop = True
        Me.RbDetallado.Text = "Detallado"
        Me.RbDetallado.UseVisualStyleBackColor = True
        '
        'RbResumido
        '
        Me.RbResumido.AutoSize = True
        Me.RbResumido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbResumido.ForeColor = System.Drawing.Color.Teal
        Me.RbResumido.Location = New System.Drawing.Point(16, 16)
        Me.RbResumido.Name = "RbResumido"
        Me.RbResumido.Size = New System.Drawing.Size(97, 20)
        Me.RbResumido.TabIndex = 0
        Me.RbResumido.Text = "Resumido"
        Me.RbResumido.UseVisualStyleBackColor = True
        '
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(240, 41)
        Me.LbNomGeneroHasta.Name = "LbNomGeneroHasta"
        Me.LbNomGeneroHasta.Size = New System.Drawing.Size(392, 23)
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
        Me.TxGeneroHasta.Location = New System.Drawing.Point(132, 41)
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
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(201, 41)
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
        Me.LbHastaGenero.Location = New System.Drawing.Point(12, 44)
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
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(240, 14)
        Me.LbNomGeneroDesde.Name = "LbNomGeneroDesde"
        Me.LbNomGeneroDesde.Size = New System.Drawing.Size(392, 23)
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
        Me.TxGeneroDesde.Location = New System.Drawing.Point(132, 14)
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
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(201, 14)
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
        Me.LbDesdeGenero.Location = New System.Drawing.Point(12, 17)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 100280
        Me.LbDesdeGenero.Text = "Desde Genero"
        '
        'LbNumPalets
        '
        Me.LbNumPalets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbNumPalets.AutoSize = True
        Me.LbNumPalets.BackColor = System.Drawing.Color.Transparent
        Me.LbNumPalets.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumPalets.ForeColor = System.Drawing.Color.Blue
        Me.LbNumPalets.Location = New System.Drawing.Point(6, 506)
        Me.LbNumPalets.Name = "LbNumPalets"
        Me.LbNumPalets.Size = New System.Drawing.Size(95, 18)
        Me.LbNumPalets.TabIndex = 100288
        Me.LbNumPalets.Text = "Nº Palets:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbNoTerminados)
        Me.GroupBox3.Controls.Add(Me.RbTodosTerminados)
        Me.GroupBox3.Controls.Add(Me.RbTerminados)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(269, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 42)
        Me.GroupBox3.TabIndex = 100288
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Terminados"
        '
        'RbNoTerminados
        '
        Me.RbNoTerminados.AutoSize = True
        Me.RbNoTerminados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoTerminados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoTerminados.Location = New System.Drawing.Point(92, 15)
        Me.RbNoTerminados.Name = "RbNoTerminados"
        Me.RbNoTerminados.Size = New System.Drawing.Size(47, 20)
        Me.RbNoTerminados.TabIndex = 3
        Me.RbNoTerminados.Text = "NO"
        Me.RbNoTerminados.UseVisualStyleBackColor = True
        '
        'RbTodosTerminados
        '
        Me.RbTodosTerminados.AutoSize = True
        Me.RbTodosTerminados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosTerminados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosTerminados.Location = New System.Drawing.Point(145, 15)
        Me.RbTodosTerminados.Name = "RbTodosTerminados"
        Me.RbTodosTerminados.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosTerminados.TabIndex = 2
        Me.RbTodosTerminados.Text = "Todos"
        Me.RbTodosTerminados.UseVisualStyleBackColor = True
        '
        'RbTerminados
        '
        Me.RbTerminados.AutoSize = True
        Me.RbTerminados.Checked = True
        Me.RbTerminados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTerminados.ForeColor = System.Drawing.Color.Teal
        Me.RbTerminados.Location = New System.Drawing.Point(40, 15)
        Me.RbTerminados.Name = "RbTerminados"
        Me.RbTerminados.Size = New System.Drawing.Size(41, 20)
        Me.RbTerminados.TabIndex = 1
        Me.RbTerminados.TabStop = True
        Me.RbTerminados.Text = "SI"
        Me.RbTerminados.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(886, 44)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(75, 16)
        Me.Lb1.TabIndex = 100290
        Me.Lb1.Text = "Situación"
        '
        'CbSituacion
        '
        Me.CbSituacion.EditValue = ""
        Me.CbSituacion.Location = New System.Drawing.Point(967, 42)
        Me.CbSituacion.Name = "CbSituacion"
        Me.CbSituacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbSituacion.Size = New System.Drawing.Size(240, 20)
        Me.CbSituacion.TabIndex = 100289
        '
        'ChkVisualizarMermas
        '
        Me.ChkVisualizarMermas.AutoSize = True
        Me.ChkVisualizarMermas.Campobd = Nothing
        Me.ChkVisualizarMermas.ClForm = Nothing
        Me.ChkVisualizarMermas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVisualizarMermas.ForeColor = System.Drawing.Color.Teal
        Me.ChkVisualizarMermas.GridLin = Nothing
        Me.ChkVisualizarMermas.HaCambiado = False
        Me.ChkVisualizarMermas.Location = New System.Drawing.Point(544, 85)
        Me.ChkVisualizarMermas.MiEntidad = Nothing
        Me.ChkVisualizarMermas.MiError = False
        Me.ChkVisualizarMermas.Name = "ChkVisualizarMermas"
        Me.ChkVisualizarMermas.Orden = 0
        Me.ChkVisualizarMermas.SaltoAlfinal = False
        Me.ChkVisualizarMermas.Size = New System.Drawing.Size(162, 20)
        Me.ChkVisualizarMermas.TabIndex = 100291
        Me.ChkVisualizarMermas.Text = "Visualizar mermas"
        Me.ChkVisualizarMermas.UseVisualStyleBackColor = True
        Me.ChkVisualizarMermas.ValorCampoFalse = Nothing
        Me.ChkVisualizarMermas.ValorCampoTrue = Nothing
        Me.ChkVisualizarMermas.ValorDefecto = False
        '
        'FrmListadoPalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.LbNumPalets)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoPalets"
        Me.Text = "Listado palets"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.LbNumPalets, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CbSituacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents RbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents LbNomGeneroHasta As NetAgro.Lb
    Friend WithEvents TxGeneroHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents LbNomGeneroDesde As NetAgro.Lb
    Friend WithEvents TxGeneroDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents RbCargados As System.Windows.Forms.RadioButton
    Friend WithEvents LbNumPalets As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbNoTerminados As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodosTerminados As System.Windows.Forms.RadioButton
    Friend WithEvents RbTerminados As System.Windows.Forms.RadioButton
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CbSituacion As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkVisualizarMermas As NetAgro.Chk
End Class
