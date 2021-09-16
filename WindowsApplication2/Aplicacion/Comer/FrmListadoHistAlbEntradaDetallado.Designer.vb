<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoHistAlbEntradaDetallado

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoHistAlbEntradaDetallado))
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
        Me.RbValorTodos = New System.Windows.Forms.RadioButton()
        Me.RbValorno = New System.Windows.Forms.RadioButton()
        Me.RbValorSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbMuestreoTodos = New System.Windows.Forms.RadioButton()
        Me.RbMuestreoNo = New System.Windows.Forms.RadioButton()
        Me.RbMuestreoSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbFacturadosTodos = New System.Windows.Forms.RadioButton()
        Me.RbFacturadosNo = New System.Windows.Forms.RadioButton()
        Me.RbFacturadosSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RbConfecTodas = New System.Windows.Forms.RadioButton()
        Me.RbConfecNo = New System.Windows.Forms.RadioButton()
        Me.RbConfecSi = New System.Windows.Forms.RadioButton()
        Me.Lb_6 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.BtBusca6 = New NetAgro.BtBusca(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.BtBusca5 = New NetAgro.BtBusca(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.Lb_6)
        Me.PanelCabecera.Controls.Add(Me.TxDato6)
        Me.PanelCabecera.Controls.Add(Me.BtBusca6)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb_5)
        Me.PanelCabecera.Controls.Add(Me.TxDato5)
        Me.PanelCabecera.Controls.Add(Me.BtBusca5)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.GroupBox5)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 130)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 136)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 386)
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
        Me.TxDato1.Location = New System.Drawing.Point(147, 9)
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
        Me.BtBusca1.Location = New System.Drawing.Point(216, 9)
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
        Me.Lb1.Size = New System.Drawing.Size(128, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Desde Agricultor"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(255, 9)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(420, 23)
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
        Me.Lb_2.Location = New System.Drawing.Point(255, 38)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(420, 23)
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
        Me.TxDato2.Location = New System.Drawing.Point(147, 38)
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
        Me.BtBusca2.Location = New System.Drawing.Point(216, 38)
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
        Me.Lb2.Location = New System.Drawing.Point(13, 41)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(126, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Hasta Agricultor"
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
        Me.TxDato4.Location = New System.Drawing.Point(805, 38)
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
        Me.Lb4.Location = New System.Drawing.Point(696, 41)
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
        Me.TxDato3.Location = New System.Drawing.Point(805, 9)
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
        Me.Lb3.Location = New System.Drawing.Point(696, 12)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbValorTodos)
        Me.GroupBox1.Controls.Add(Me.RbValorno)
        Me.GroupBox1.Controls.Add(Me.RbValorSi)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(943, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 34)
        Me.GroupBox1.TabIndex = 100278
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valorados"
        '
        'RbValorTodos
        '
        Me.RbValorTodos.AutoSize = True
        Me.RbValorTodos.Checked = True
        Me.RbValorTodos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbValorTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbValorTodos.Location = New System.Drawing.Point(110, 16)
        Me.RbValorTodos.Name = "RbValorTodos"
        Me.RbValorTodos.Size = New System.Drawing.Size(64, 17)
        Me.RbValorTodos.TabIndex = 2
        Me.RbValorTodos.TabStop = True
        Me.RbValorTodos.Text = "Todos"
        Me.RbValorTodos.UseVisualStyleBackColor = True
        '
        'RbValorno
        '
        Me.RbValorno.AutoSize = True
        Me.RbValorno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbValorno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbValorno.Location = New System.Drawing.Point(61, 15)
        Me.RbValorno.Name = "RbValorno"
        Me.RbValorno.Size = New System.Drawing.Size(43, 17)
        Me.RbValorno.TabIndex = 1
        Me.RbValorno.Text = "NO"
        Me.RbValorno.UseVisualStyleBackColor = True
        '
        'RbValorSi
        '
        Me.RbValorSi.AutoSize = True
        Me.RbValorSi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbValorSi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbValorSi.Location = New System.Drawing.Point(16, 15)
        Me.RbValorSi.Name = "RbValorSi"
        Me.RbValorSi.Size = New System.Drawing.Size(39, 17)
        Me.RbValorSi.TabIndex = 0
        Me.RbValorSi.Text = "SI"
        Me.RbValorSi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbMuestreoTodos)
        Me.GroupBox3.Controls.Add(Me.RbMuestreoNo)
        Me.GroupBox3.Controls.Add(Me.RbMuestreoSi)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Green
        Me.GroupBox3.Location = New System.Drawing.Point(943, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 34)
        Me.GroupBox3.TabIndex = 100279
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lineas muestreadas"
        '
        'RbMuestreoTodos
        '
        Me.RbMuestreoTodos.AutoSize = True
        Me.RbMuestreoTodos.Checked = True
        Me.RbMuestreoTodos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMuestreoTodos.ForeColor = System.Drawing.Color.Green
        Me.RbMuestreoTodos.Location = New System.Drawing.Point(110, 16)
        Me.RbMuestreoTodos.Name = "RbMuestreoTodos"
        Me.RbMuestreoTodos.Size = New System.Drawing.Size(64, 17)
        Me.RbMuestreoTodos.TabIndex = 2
        Me.RbMuestreoTodos.TabStop = True
        Me.RbMuestreoTodos.Text = "Todos"
        Me.RbMuestreoTodos.UseVisualStyleBackColor = True
        '
        'RbMuestreoNo
        '
        Me.RbMuestreoNo.AutoSize = True
        Me.RbMuestreoNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMuestreoNo.ForeColor = System.Drawing.Color.Green
        Me.RbMuestreoNo.Location = New System.Drawing.Point(61, 15)
        Me.RbMuestreoNo.Name = "RbMuestreoNo"
        Me.RbMuestreoNo.Size = New System.Drawing.Size(43, 17)
        Me.RbMuestreoNo.TabIndex = 1
        Me.RbMuestreoNo.Text = "NO"
        Me.RbMuestreoNo.UseVisualStyleBackColor = True
        '
        'RbMuestreoSi
        '
        Me.RbMuestreoSi.AutoSize = True
        Me.RbMuestreoSi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMuestreoSi.ForeColor = System.Drawing.Color.Green
        Me.RbMuestreoSi.Location = New System.Drawing.Point(16, 15)
        Me.RbMuestreoSi.Name = "RbMuestreoSi"
        Me.RbMuestreoSi.Size = New System.Drawing.Size(39, 17)
        Me.RbMuestreoSi.TabIndex = 0
        Me.RbMuestreoSi.Text = "SI"
        Me.RbMuestreoSi.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbFacturadosTodos)
        Me.GroupBox4.Controls.Add(Me.RbFacturadosNo)
        Me.GroupBox4.Controls.Add(Me.RbFacturadosSi)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(1125, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(99, 74)
        Me.GroupBox4.TabIndex = 100280
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facturados"
        '
        'RbFacturadosTodos
        '
        Me.RbFacturadosTodos.AutoSize = True
        Me.RbFacturadosTodos.Checked = True
        Me.RbFacturadosTodos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturadosTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbFacturadosTodos.Location = New System.Drawing.Point(14, 50)
        Me.RbFacturadosTodos.Name = "RbFacturadosTodos"
        Me.RbFacturadosTodos.Size = New System.Drawing.Size(64, 17)
        Me.RbFacturadosTodos.TabIndex = 2
        Me.RbFacturadosTodos.TabStop = True
        Me.RbFacturadosTodos.Text = "Todos"
        Me.RbFacturadosTodos.UseVisualStyleBackColor = True
        '
        'RbFacturadosNo
        '
        Me.RbFacturadosNo.AutoSize = True
        Me.RbFacturadosNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturadosNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbFacturadosNo.Location = New System.Drawing.Point(15, 31)
        Me.RbFacturadosNo.Name = "RbFacturadosNo"
        Me.RbFacturadosNo.Size = New System.Drawing.Size(43, 17)
        Me.RbFacturadosNo.TabIndex = 1
        Me.RbFacturadosNo.Text = "NO"
        Me.RbFacturadosNo.UseVisualStyleBackColor = True
        '
        'RbFacturadosSi
        '
        Me.RbFacturadosSi.AutoSize = True
        Me.RbFacturadosSi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFacturadosSi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbFacturadosSi.Location = New System.Drawing.Point(16, 15)
        Me.RbFacturadosSi.Name = "RbFacturadosSi"
        Me.RbFacturadosSi.Size = New System.Drawing.Size(39, 17)
        Me.RbFacturadosSi.TabIndex = 0
        Me.RbFacturadosSi.Text = "SI"
        Me.RbFacturadosSi.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RbConfecTodas)
        Me.GroupBox5.Controls.Add(Me.RbConfecNo)
        Me.GroupBox5.Controls.Add(Me.RbConfecSi)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(943, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(218, 34)
        Me.GroupBox5.TabIndex = 100281
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ent.Confeccionadas"
        '
        'RbConfecTodas
        '
        Me.RbConfecTodas.AutoSize = True
        Me.RbConfecTodas.Checked = True
        Me.RbConfecTodas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbConfecTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbConfecTodas.Location = New System.Drawing.Point(110, 16)
        Me.RbConfecTodas.Name = "RbConfecTodas"
        Me.RbConfecTodas.Size = New System.Drawing.Size(64, 17)
        Me.RbConfecTodas.TabIndex = 2
        Me.RbConfecTodas.TabStop = True
        Me.RbConfecTodas.Text = "Todas"
        Me.RbConfecTodas.UseVisualStyleBackColor = True
        '
        'RbConfecNo
        '
        Me.RbConfecNo.AutoSize = True
        Me.RbConfecNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbConfecNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbConfecNo.Location = New System.Drawing.Point(61, 15)
        Me.RbConfecNo.Name = "RbConfecNo"
        Me.RbConfecNo.Size = New System.Drawing.Size(43, 17)
        Me.RbConfecNo.TabIndex = 1
        Me.RbConfecNo.Text = "NO"
        Me.RbConfecNo.UseVisualStyleBackColor = True
        '
        'RbConfecSi
        '
        Me.RbConfecSi.AutoSize = True
        Me.RbConfecSi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbConfecSi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbConfecSi.Location = New System.Drawing.Point(16, 15)
        Me.RbConfecSi.Name = "RbConfecSi"
        Me.RbConfecSi.Size = New System.Drawing.Size(39, 17)
        Me.RbConfecSi.TabIndex = 0
        Me.RbConfecSi.Text = "SI"
        Me.RbConfecSi.UseVisualStyleBackColor = True
        '
        'Lb_6
        '
        Me.Lb_6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_6.CL_ControlAsociado = Nothing
        Me.Lb_6.CL_ValorFijo = False
        Me.Lb_6.ClForm = Nothing
        Me.Lb_6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_6.Location = New System.Drawing.Point(255, 96)
        Me.Lb_6.Name = "Lb_6"
        Me.Lb_6.Size = New System.Drawing.Size(420, 23)
        Me.Lb_6.TabIndex = 100289
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(147, 96)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(63, 22)
        Me.TxDato6.TabIndex = 100288
        Me.TxDato6.TeclaRepetida = False
        '
        'BtBusca6
        '
        Me.BtBusca6.CL_BuscaAlb = False
        Me.BtBusca6.CL_campocodigo = Nothing
        Me.BtBusca6.CL_camponombre = Nothing
        Me.BtBusca6.CL_CampoOrden = "Nombre"
        Me.BtBusca6.CL_ch1000 = False
        Me.BtBusca6.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca6.CL_ControlAsociado = Nothing
        Me.BtBusca6.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca6.CL_dfecha = Nothing
        Me.BtBusca6.CL_Entidad = Nothing
        Me.BtBusca6.CL_EsId = True
        Me.BtBusca6.CL_Filtro = Nothing
        Me.BtBusca6.cl_formu = Nothing
        Me.BtBusca6.CL_hfecha = Nothing
        Me.BtBusca6.cl_ListaW = Nothing
        Me.BtBusca6.CL_xCentro = False
        Me.BtBusca6.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca6.Location = New System.Drawing.Point(216, 96)
        Me.BtBusca6.Name = "BtBusca6"
        Me.BtBusca6.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca6.TabIndex = 100287
        Me.BtBusca6.UseVisualStyleBackColor = True
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(13, 99)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(74, 16)
        Me.Lb6.TabIndex = 100286
        Me.Lb6.Text = "A Genero"
        '
        'Lb_5
        '
        Me.Lb_5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_5.Location = New System.Drawing.Point(255, 67)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(420, 23)
        Me.Lb_5.TabIndex = 100285
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
        Me.TxDato5.Location = New System.Drawing.Point(147, 67)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(63, 22)
        Me.TxDato5.TabIndex = 100284
        Me.TxDato5.TeclaRepetida = False
        '
        'BtBusca5
        '
        Me.BtBusca5.CL_BuscaAlb = False
        Me.BtBusca5.CL_campocodigo = Nothing
        Me.BtBusca5.CL_camponombre = Nothing
        Me.BtBusca5.CL_CampoOrden = "Nombre"
        Me.BtBusca5.CL_ch1000 = False
        Me.BtBusca5.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca5.CL_ControlAsociado = Nothing
        Me.BtBusca5.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca5.CL_dfecha = Nothing
        Me.BtBusca5.CL_Entidad = Nothing
        Me.BtBusca5.CL_EsId = True
        Me.BtBusca5.CL_Filtro = Nothing
        Me.BtBusca5.cl_formu = Nothing
        Me.BtBusca5.CL_hfecha = Nothing
        Me.BtBusca5.cl_ListaW = Nothing
        Me.BtBusca5.CL_xCentro = False
        Me.BtBusca5.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca5.Location = New System.Drawing.Point(216, 67)
        Me.BtBusca5.Name = "BtBusca5"
        Me.BtBusca5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca5.TabIndex = 100283
        Me.BtBusca5.UseVisualStyleBackColor = True
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(13, 70)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(83, 16)
        Me.Lb5.TabIndex = 100282
        Me.Lb5.Text = "De Genero"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(696, 72)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(118, 16)
        Me.Lb7.TabIndex = 100291
        Me.Lb7.Text = "Punto de venta"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(699, 92)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(235, 20)
        Me.cbPuntoVenta.TabIndex = 100290
        '
        'FrmListadoHistAlbEntradaDetallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.Lb_2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BtBusca2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoHistAlbEntradaDetallado"
        Me.Text = "Listado de Albaranes de Entrada (Detallado)"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb_1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBusca2, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb_2, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFacturadosTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbFacturadosNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbFacturadosSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbMuestreoTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbMuestreoNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbMuestreoSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbValorTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbValorno As System.Windows.Forms.RadioButton
    Friend WithEvents RbValorSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RbConfecTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbConfecNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbConfecSi As System.Windows.Forms.RadioButton
    Friend WithEvents Lb_6 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents BtBusca6 As NetAgro.BtBusca
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents BtBusca5 As NetAgro.BtBusca
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
