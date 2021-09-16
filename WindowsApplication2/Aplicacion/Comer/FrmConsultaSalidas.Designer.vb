<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSalidas))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTodosValorados = New System.Windows.Forms.RadioButton()
        Me.RbNoValorados = New System.Windows.Forms.RadioButton()
        Me.RbValorados = New System.Windows.Forms.RadioButton()
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodosFacturados = New System.Windows.Forms.RadioButton()
        Me.RbNoFacturados = New System.Windows.Forms.RadioButton()
        Me.RbSiFacturados = New System.Windows.Forms.RadioButton()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.RbPventa = New System.Windows.Forms.RadioButton()
        Me.RbCostes = New System.Windows.Forms.RadioButton()
        Me.ChkKilo = New System.Windows.Forms.CheckBox()
        Me.ChActu = New System.Windows.Forms.CheckBox()
        Me.Button1 = New NetAgro.ClButton()
        Me.ChkPbulto = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbFcTodos = New System.Windows.Forms.RadioButton()
        Me.RbComi = New System.Windows.Forms.RadioButton()
        Me.RbFirme = New System.Windows.Forms.RadioButton()
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxDato5)
        Me.Panel2.Controls.Add(Me.Lb8)
        Me.Panel2.Controls.Add(Me.TxDato7)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.ChkPbulto)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ChActu)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.ChkKilo)
        Me.Panel2.Controls.Add(Me.RbCostes)
        Me.Panel2.Controls.Add(Me.Lb_2)
        Me.Panel2.Controls.Add(Me.RbPventa)
        Me.Panel2.Controls.Add(Me.Lb6)
        Me.Panel2.Controls.Add(Me.CbFamilias)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.cbPuntoVenta)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.TxDato4)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Size = New System.Drawing.Size(1234, 117)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 123)
        Me.Panel3.Size = New System.Drawing.Size(1234, 399)
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
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(137, 9)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Nothing
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_EsId = True
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.CL_xCentro = False
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(206, 9)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 50
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 12)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(108, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Desde Cliente"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(245, 9)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(392, 23)
        Me.Lb_1.TabIndex = 75
        '
        'Lb_2
        '
        Me.Lb_2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_2.Location = New System.Drawing.Point(245, 37)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(392, 23)
        Me.Lb_2.TabIndex = 79
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(137, 37)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(63, 22)
        Me.TxDato2.TabIndex = 78
        Me.TxDato2.TeclaRepetida = False
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_BuscaAlb = False
        Me.BtBusca2.CL_campocodigo = Nothing
        Me.BtBusca2.CL_camponombre = Nothing
        Me.BtBusca2.CL_CampoOrden = "Nombre"
        Me.BtBusca2.CL_ch1000 = False
        Me.BtBusca2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca2.CL_ControlAsociado = Nothing
        Me.BtBusca2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca2.CL_dfecha = Nothing
        Me.BtBusca2.CL_Entidad = Nothing
        Me.BtBusca2.CL_EsId = True
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.CL_xCentro = False
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(206, 37)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 77
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(13, 40)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(106, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Hasta Cliente"
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
        Me.TxDato4.Location = New System.Drawing.Point(828, 37)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 83
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(650, 40)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(95, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Hasta fecha"
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
        Me.TxDato3.Location = New System.Drawing.Point(828, 9)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(102, 22)
        Me.TxDato3.TabIndex = 81
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(650, 12)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTodosValorados)
        Me.GroupBox1.Controls.Add(Me.RbNoValorados)
        Me.GroupBox1.Controls.Add(Me.RbValorados)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(931, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 75)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valorados"
        '
        'RbTodosValorados
        '
        Me.RbTodosValorados.AutoSize = True
        Me.RbTodosValorados.Checked = True
        Me.RbTodosValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosValorados.Location = New System.Drawing.Point(15, 49)
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
        Me.RbNoValorados.Location = New System.Drawing.Point(16, 29)
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
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(137, 64)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(238, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(13, 66)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(118, 16)
        Me.Lb5.TabIndex = 100272
        Me.Lb5.Text = "Punto de venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodosFacturados)
        Me.GroupBox2.Controls.Add(Me.RbNoFacturados)
        Me.GroupBox2.Controls.Add(Me.RbSiFacturados)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(1033, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 75)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturado"
        '
        'RbTodosFacturados
        '
        Me.RbTodosFacturados.AutoSize = True
        Me.RbTodosFacturados.Checked = True
        Me.RbTodosFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosFacturados.Location = New System.Drawing.Point(16, 47)
        Me.RbTodosFacturados.Name = "RbTodosFacturados"
        Me.RbTodosFacturados.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosFacturados.TabIndex = 2
        Me.RbTodosFacturados.TabStop = True
        Me.RbTodosFacturados.Text = "Todos"
        Me.RbTodosFacturados.UseVisualStyleBackColor = True
        '
        'RbNoFacturados
        '
        Me.RbNoFacturados.AutoSize = True
        Me.RbNoFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoFacturados.Location = New System.Drawing.Point(16, 29)
        Me.RbNoFacturados.Name = "RbNoFacturados"
        Me.RbNoFacturados.Size = New System.Drawing.Size(47, 20)
        Me.RbNoFacturados.TabIndex = 1
        Me.RbNoFacturados.Text = "NO"
        Me.RbNoFacturados.UseVisualStyleBackColor = True
        '
        'RbSiFacturados
        '
        Me.RbSiFacturados.AutoSize = True
        Me.RbSiFacturados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiFacturados.ForeColor = System.Drawing.Color.Teal
        Me.RbSiFacturados.Location = New System.Drawing.Point(16, 12)
        Me.RbSiFacturados.Name = "RbSiFacturados"
        Me.RbSiFacturados.Size = New System.Drawing.Size(41, 20)
        Me.RbSiFacturados.TabIndex = 0
        Me.RbSiFacturados.Text = "SI"
        Me.RbSiFacturados.UseVisualStyleBackColor = True
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(13, 90)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(69, 16)
        Me.Lb6.TabIndex = 100275
        Me.Lb6.Text = "Familias"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(137, 88)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(240, 20)
        Me.CbFamilias.TabIndex = 100274
        '
        'RbPventa
        '
        Me.RbPventa.AutoSize = True
        Me.RbPventa.Checked = True
        Me.RbPventa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPventa.ForeColor = System.Drawing.Color.Teal
        Me.RbPventa.Location = New System.Drawing.Point(431, 70)
        Me.RbPventa.Name = "RbPventa"
        Me.RbPventa.Size = New System.Drawing.Size(83, 20)
        Me.RbPventa.TabIndex = 100276
        Me.RbPventa.TabStop = True
        Me.RbPventa.Text = "P.Venta"
        Me.RbPventa.UseVisualStyleBackColor = True
        '
        'RbCostes
        '
        Me.RbCostes.AutoSize = True
        Me.RbCostes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCostes.ForeColor = System.Drawing.Color.Teal
        Me.RbCostes.Location = New System.Drawing.Point(431, 90)
        Me.RbCostes.Name = "RbCostes"
        Me.RbCostes.Size = New System.Drawing.Size(76, 20)
        Me.RbCostes.TabIndex = 100277
        Me.RbCostes.Text = "Costes"
        Me.RbCostes.UseVisualStyleBackColor = True
        '
        'ChkKilo
        '
        Me.ChkKilo.AutoSize = True
        Me.ChkKilo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKilo.Location = New System.Drawing.Point(520, 91)
        Me.ChkKilo.Name = "ChkKilo"
        Me.ChkKilo.Size = New System.Drawing.Size(100, 18)
        Me.ChkKilo.TabIndex = 100278
        Me.ChkKilo.Text = "Coste x Kilo"
        Me.ChkKilo.UseVisualStyleBackColor = True
        '
        'ChActu
        '
        Me.ChActu.AutoSize = True
        Me.ChActu.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChActu.ForeColor = System.Drawing.Color.Red
        Me.ChActu.Location = New System.Drawing.Point(957, 90)
        Me.ChActu.Name = "ChActu"
        Me.ChActu.Size = New System.Drawing.Size(184, 18)
        Me.ChActu.TabIndex = 100279
        Me.ChActu.Text = "Actualizar costes origen"
        Me.ChActu.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1147, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 100280
        Me.Button1.Text = "Estimado"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ChkPbulto
        '
        Me.ChkPbulto.AutoSize = True
        Me.ChkPbulto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPbulto.Location = New System.Drawing.Point(520, 71)
        Me.ChkPbulto.Name = "ChkPbulto"
        Me.ChkPbulto.Size = New System.Drawing.Size(117, 18)
        Me.ChkPbulto.TabIndex = 100281
        Me.ChkPbulto.Text = "Pventa x bulto"
        Me.ChkPbulto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbFcTodos)
        Me.GroupBox3.Controls.Add(Me.RbComi)
        Me.GroupBox3.Controls.Add(Me.RbFirme)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(1132, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 75)
        Me.GroupBox3.TabIndex = 100282
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "F/C"
        '
        'RbFcTodos
        '
        Me.RbFcTodos.AutoSize = True
        Me.RbFcTodos.Checked = True
        Me.RbFcTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFcTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbFcTodos.Location = New System.Drawing.Point(16, 47)
        Me.RbFcTodos.Name = "RbFcTodos"
        Me.RbFcTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbFcTodos.TabIndex = 2
        Me.RbFcTodos.TabStop = True
        Me.RbFcTodos.Text = "Todos"
        Me.RbFcTodos.UseVisualStyleBackColor = True
        '
        'RbComi
        '
        Me.RbComi.AutoSize = True
        Me.RbComi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbComi.ForeColor = System.Drawing.Color.Teal
        Me.RbComi.Location = New System.Drawing.Point(16, 29)
        Me.RbComi.Name = "RbComi"
        Me.RbComi.Size = New System.Drawing.Size(64, 20)
        Me.RbComi.TabIndex = 1
        Me.RbComi.Text = "Com."
        Me.RbComi.UseVisualStyleBackColor = True
        '
        'RbFirme
        '
        Me.RbFirme.AutoSize = True
        Me.RbFirme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFirme.ForeColor = System.Drawing.Color.Teal
        Me.RbFirme.Location = New System.Drawing.Point(16, 12)
        Me.RbFirme.Name = "RbFirme"
        Me.RbFirme.Size = New System.Drawing.Size(68, 20)
        Me.RbFirme.TabIndex = 0
        Me.RbFirme.Text = "Firme"
        Me.RbFirme.UseVisualStyleBackColor = True
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(828, 63)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(102, 22)
        Me.TxDato7.TabIndex = 100284
        Me.TxDato7.TeclaRepetida = False
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(650, 66)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(153, 16)
        Me.Lb7.TabIndex = 100283
        Me.Lb7.Text = "Desde fecha factura"
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(828, 87)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(102, 22)
        Me.TxDato5.TabIndex = 100286
        Me.TxDato5.TeclaRepetida = False
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(650, 90)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(177, 16)
        Me.Lb8.TabIndex = 100285
        Me.Lb8.Text = "Desde fecha valoracion"
        '
        'FrmConsultaSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BtBusca2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaSalidas"
        Me.Text = "Consulta salidas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb_1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBusca2, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodosValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbValorados As System.Windows.Forms.RadioButton
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkKilo As System.Windows.Forms.CheckBox
    Friend WithEvents RbCostes As System.Windows.Forms.RadioButton
    Friend WithEvents RbPventa As System.Windows.Forms.RadioButton
    Friend WithEvents ChActu As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As NetAgro.ClButton
    Friend WithEvents ChkPbulto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFcTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbComi As System.Windows.Forms.RadioButton
    Friend WithEvents RbFirme As System.Windows.Forms.RadioButton
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb8 As NetAgro.Lb
End Class
