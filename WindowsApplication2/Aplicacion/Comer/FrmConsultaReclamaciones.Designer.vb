<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaReclamaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaReclamaciones))
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.cbCentros = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lbnom_11 = New NetAgro.Lb(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.BtBusca_11 = New NetAgro.BtBusca(Me.components)
        Me.BtBusca_10 = New NetAgro.BtBusca(Me.components)
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.CBOrigen = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.CbSolucion = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTodosValorados = New System.Windows.Forms.RadioButton()
        Me.RbNoValorados = New System.Windows.Forms.RadioButton()
        Me.RbValorados = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbSolucionadosTODOS = New System.Windows.Forms.RadioButton()
        Me.RbSolucionadosNO = New System.Windows.Forms.RadioButton()
        Me.RbSolucinadosSI = New System.Windows.Forms.RadioButton()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbCentros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbSolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.CbSolucion)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.CBOrigen)
        Me.PanelCabecera.Controls.Add(Me.Lbnom_11)
        Me.PanelCabecera.Controls.Add(Me.Lbnom_10)
        Me.PanelCabecera.Controls.Add(Me.TxDato_11)
        Me.PanelCabecera.Controls.Add(Me.Lb_10)
        Me.PanelCabecera.Controls.Add(Me.BtBusca_11)
        Me.PanelCabecera.Controls.Add(Me.BtBusca_10)
        Me.PanelCabecera.Controls.Add(Me.Lb_11)
        Me.PanelCabecera.Controls.Add(Me.TxDato_10)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.cbCentros)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 117)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 123)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 399)
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
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(125, 89)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 83
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(18, 92)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(95, 16)
        Me.Lb6.TabIndex = 82
        Me.Lb6.Text = "Hasta fecha"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(125, 64)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(102, 22)
        Me.TxDato3.TabIndex = 81
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(18, 67)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(97, 16)
        Me.Lb5.TabIndex = 80
        Me.Lb5.Text = "Desde fecha"
        '
        'cbCentros
        '
        Me.cbCentros.EditValue = ""
        Me.cbCentros.Location = New System.Drawing.Point(337, 65)
        Me.cbCentros.Name = "cbCentros"
        Me.cbCentros.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentros.Size = New System.Drawing.Size(269, 20)
        Me.cbCentros.TabIndex = 100270
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(262, 67)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(57, 16)
        Me.Lb7.TabIndex = 100272
        Me.Lb7.Text = "Centro"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(262, 92)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(69, 16)
        Me.Lb3.TabIndex = 100275
        Me.Lb3.Text = "Familias"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(337, 90)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(269, 20)
        Me.CbFamilias.TabIndex = 100274
        '
        'Lbnom_11
        '
        Me.Lbnom_11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_11.CL_ControlAsociado = Nothing
        Me.Lbnom_11.CL_ValorFijo = False
        Me.Lbnom_11.ClForm = Nothing
        Me.Lbnom_11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_11.Location = New System.Drawing.Point(233, 34)
        Me.Lbnom_11.Name = "Lbnom_11"
        Me.Lbnom_11.Size = New System.Drawing.Size(373, 23)
        Me.Lbnom_11.TabIndex = 100284
        '
        'Lbnom_10
        '
        Me.Lbnom_10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_10.CL_ControlAsociado = Nothing
        Me.Lbnom_10.CL_ValorFijo = False
        Me.Lbnom_10.ClForm = Nothing
        Me.Lbnom_10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_10.Location = New System.Drawing.Point(233, 6)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(373, 23)
        Me.Lbnom_10.TabIndex = 100280
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(125, 34)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(63, 22)
        Me.TxDato_11.TabIndex = 100283
        Me.TxDato_11.TeclaRepetida = False
        '
        'Lb_10
        '
        Me.Lb_10.AutoSize = True
        Me.Lb_10.CL_ControlAsociado = Nothing
        Me.Lb_10.CL_ValorFijo = False
        Me.Lb_10.ClForm = Nothing
        Me.Lb_10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_10.ForeColor = System.Drawing.Color.Teal
        Me.Lb_10.Location = New System.Drawing.Point(18, 9)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(80, 16)
        Me.Lb_10.TabIndex = 100277
        Me.Lb_10.Text = "De cliente"
        '
        'BtBusca_11
        '
        Me.BtBusca_11.CL_BuscaAlb = False
        Me.BtBusca_11.CL_campocodigo = Nothing
        Me.BtBusca_11.CL_camponombre = Nothing
        Me.BtBusca_11.CL_CampoOrden = "Nombre"
        Me.BtBusca_11.CL_ch1000 = False
        Me.BtBusca_11.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_11.CL_ControlAsociado = Nothing
        Me.BtBusca_11.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_11.CL_dfecha = Nothing
        Me.BtBusca_11.CL_Entidad = Nothing
        Me.BtBusca_11.CL_EsId = True
        Me.BtBusca_11.CL_Filtro = Nothing
        Me.BtBusca_11.cl_formu = Nothing
        Me.BtBusca_11.CL_hfecha = Nothing
        Me.BtBusca_11.cl_ListaW = Nothing
        Me.BtBusca_11.CL_xCentro = False
        Me.BtBusca_11.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_11.Location = New System.Drawing.Point(194, 34)
        Me.BtBusca_11.Name = "BtBusca_11"
        Me.BtBusca_11.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_11.TabIndex = 100282
        Me.BtBusca_11.UseVisualStyleBackColor = True
        '
        'BtBusca_10
        '
        Me.BtBusca_10.CL_BuscaAlb = False
        Me.BtBusca_10.CL_campocodigo = Nothing
        Me.BtBusca_10.CL_camponombre = Nothing
        Me.BtBusca_10.CL_CampoOrden = "Nombre"
        Me.BtBusca_10.CL_ch1000 = False
        Me.BtBusca_10.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_10.CL_ControlAsociado = Nothing
        Me.BtBusca_10.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_10.CL_dfecha = Nothing
        Me.BtBusca_10.CL_Entidad = Nothing
        Me.BtBusca_10.CL_EsId = True
        Me.BtBusca_10.CL_Filtro = Nothing
        Me.BtBusca_10.cl_formu = Nothing
        Me.BtBusca_10.CL_hfecha = Nothing
        Me.BtBusca_10.cl_ListaW = Nothing
        Me.BtBusca_10.CL_xCentro = False
        Me.BtBusca_10.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_10.Location = New System.Drawing.Point(194, 6)
        Me.BtBusca_10.Name = "BtBusca_10"
        Me.BtBusca_10.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_10.TabIndex = 100278
        Me.BtBusca_10.UseVisualStyleBackColor = True
        '
        'Lb_11
        '
        Me.Lb_11.AutoSize = True
        Me.Lb_11.CL_ControlAsociado = Nothing
        Me.Lb_11.CL_ValorFijo = False
        Me.Lb_11.ClForm = Nothing
        Me.Lb_11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_11.ForeColor = System.Drawing.Color.Teal
        Me.Lb_11.Location = New System.Drawing.Point(18, 37)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(71, 16)
        Me.Lb_11.TabIndex = 100281
        Me.Lb_11.Text = "A cliente"
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(125, 6)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(63, 22)
        Me.TxDato_10.TabIndex = 100279
        Me.TxDato_10.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(644, 66)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(56, 16)
        Me.Lb1.TabIndex = 100286
        Me.Lb1.Text = "Origen"
        '
        'CBOrigen
        '
        Me.CBOrigen.EditValue = ""
        Me.CBOrigen.Location = New System.Drawing.Point(719, 65)
        Me.CBOrigen.Name = "CBOrigen"
        Me.CBOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBOrigen.Size = New System.Drawing.Size(269, 20)
        Me.CBOrigen.TabIndex = 100285
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(644, 93)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(69, 16)
        Me.Lb2.TabIndex = 100288
        Me.Lb2.Text = "Solucion"
        '
        'CbSolucion
        '
        Me.CbSolucion.EditValue = ""
        Me.CbSolucion.Location = New System.Drawing.Point(719, 90)
        Me.CbSolucion.Name = "CbSolucion"
        Me.CbSolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbSolucion.Size = New System.Drawing.Size(269, 20)
        Me.CbSolucion.TabIndex = 100287
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTodosValorados)
        Me.GroupBox1.Controls.Add(Me.RbNoValorados)
        Me.GroupBox1.Controls.Add(Me.RbValorados)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(642, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 39)
        Me.GroupBox1.TabIndex = 100289
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valoradas"
        '
        'RbTodosValorados
        '
        Me.RbTodosValorados.AutoSize = True
        Me.RbTodosValorados.Checked = True
        Me.RbTodosValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosValorados.Location = New System.Drawing.Point(116, 11)
        Me.RbTodosValorados.Name = "RbTodosValorados"
        Me.RbTodosValorados.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosValorados.TabIndex = 2
        Me.RbTodosValorados.TabStop = True
        Me.RbTodosValorados.Text = "Todos"
        Me.RbTodosValorados.UseVisualStyleBackColor = True
        '
        'RbNoValorados
        '
        Me.RbNoValorados.AutoSize = True
        Me.RbNoValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoValorados.Location = New System.Drawing.Point(63, 11)
        Me.RbNoValorados.Name = "RbNoValorados"
        Me.RbNoValorados.Size = New System.Drawing.Size(47, 20)
        Me.RbNoValorados.TabIndex = 1
        Me.RbNoValorados.Text = "NO"
        Me.RbNoValorados.UseVisualStyleBackColor = True
        '
        'RbValorados
        '
        Me.RbValorados.AutoSize = True
        Me.RbValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbValorados.Location = New System.Drawing.Point(16, 11)
        Me.RbValorados.Name = "RbValorados"
        Me.RbValorados.Size = New System.Drawing.Size(41, 20)
        Me.RbValorados.TabIndex = 0
        Me.RbValorados.Text = "SI"
        Me.RbValorados.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbSolucionadosTODOS)
        Me.GroupBox2.Controls.Add(Me.RbSolucionadosNO)
        Me.GroupBox2.Controls.Add(Me.RbSolucinadosSI)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(859, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 39)
        Me.GroupBox2.TabIndex = 100290
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Solucionadas"
        '
        'RbSolucionadosTODOS
        '
        Me.RbSolucionadosTODOS.AutoSize = True
        Me.RbSolucionadosTODOS.Checked = True
        Me.RbSolucionadosTODOS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSolucionadosTODOS.ForeColor = System.Drawing.Color.Teal
        Me.RbSolucionadosTODOS.Location = New System.Drawing.Point(116, 11)
        Me.RbSolucionadosTODOS.Name = "RbSolucionadosTODOS"
        Me.RbSolucionadosTODOS.Size = New System.Drawing.Size(69, 20)
        Me.RbSolucionadosTODOS.TabIndex = 2
        Me.RbSolucionadosTODOS.TabStop = True
        Me.RbSolucionadosTODOS.Text = "Todos"
        Me.RbSolucionadosTODOS.UseVisualStyleBackColor = True
        '
        'RbSolucionadosNO
        '
        Me.RbSolucionadosNO.AutoSize = True
        Me.RbSolucionadosNO.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSolucionadosNO.ForeColor = System.Drawing.Color.Teal
        Me.RbSolucionadosNO.Location = New System.Drawing.Point(63, 11)
        Me.RbSolucionadosNO.Name = "RbSolucionadosNO"
        Me.RbSolucionadosNO.Size = New System.Drawing.Size(47, 20)
        Me.RbSolucionadosNO.TabIndex = 1
        Me.RbSolucionadosNO.Text = "NO"
        Me.RbSolucionadosNO.UseVisualStyleBackColor = True
        '
        'RbSolucinadosSI
        '
        Me.RbSolucinadosSI.AutoSize = True
        Me.RbSolucinadosSI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSolucinadosSI.ForeColor = System.Drawing.Color.Teal
        Me.RbSolucinadosSI.Location = New System.Drawing.Point(16, 11)
        Me.RbSolucinadosSI.Name = "RbSolucinadosSI"
        Me.RbSolucinadosSI.Size = New System.Drawing.Size(41, 20)
        Me.RbSolucinadosSI.TabIndex = 0
        Me.RbSolucinadosSI.Text = "SI"
        Me.RbSolucinadosSI.UseVisualStyleBackColor = True
        '
        'FrmConsultaReclamaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaReclamaciones"
        Me.Text = "Reclamaciones de clientes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbCentros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbSolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents cbCentros As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lbnom_11 As NetAgro.Lb
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents BtBusca_11 As NetAgro.BtBusca
    Friend WithEvents BtBusca_10 As NetAgro.BtBusca
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents CbSolucion As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CBOrigen As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbSolucionadosTODOS As System.Windows.Forms.RadioButton
    Friend WithEvents RbSolucionadosNO As System.Windows.Forms.RadioButton
    Friend WithEvents RbSolucinadosSI As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbValorados As System.Windows.Forms.RadioButton
End Class
