<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaTarifasPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaTarifasPrecios))
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
        Me.RbPorMaterial = New System.Windows.Forms.RadioButton()
        Me.RbPorAcreedor = New System.Windows.Forms.RadioButton()
        Me.TxAMaterial = New NetAgro.TxDato(Me.components)
        Me.TxDMaterial = New NetAgro.TxDato(Me.components)
        Me.LbDeMaterial = New NetAgro.Lb(Me.components)
        Me.LbNombreAMaterial = New NetAgro.Lb(Me.components)
        Me.BtBuscaAMaterial = New NetAgro.BtBusca(Me.components)
        Me.LbAMaterial = New NetAgro.Lb(Me.components)
        Me.LbNombreDMaterial = New NetAgro.Lb(Me.components)
        Me.BtBuscaDMaterial = New NetAgro.BtBusca(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.TxAMaterial)
        Me.PanelCabecera.Controls.Add(Me.TxDMaterial)
        Me.PanelCabecera.Controls.Add(Me.LbDeMaterial)
        Me.PanelCabecera.Controls.Add(Me.LbNombreAMaterial)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAMaterial)
        Me.PanelCabecera.Controls.Add(Me.LbAMaterial)
        Me.PanelCabecera.Controls.Add(Me.LbNombreDMaterial)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDMaterial)
        Me.PanelCabecera.Controls.Add(Me.Lb_2)
        Me.PanelCabecera.Controls.Add(Me.BtBusca2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb_1)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.BtBusca1)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Size = New System.Drawing.Size(1274, 152)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 150)
        Me.PanelConsulta.Size = New System.Drawing.Size(1274, 401)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(974, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1049, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1124, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1199, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(899, 0)
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
        Me.TxDato1.Location = New System.Drawing.Point(137, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(73, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_Ancho = 0
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
        Me.BtBusca1.Location = New System.Drawing.Point(216, 12)
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
        Me.Lb1.Location = New System.Drawing.Point(13, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(123, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Desde Acreedor"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(255, 12)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(472, 23)
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
        Me.Lb_2.Location = New System.Drawing.Point(255, 46)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(472, 23)
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
        Me.TxDato2.Location = New System.Drawing.Point(137, 47)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(73, 22)
        Me.TxDato2.TabIndex = 78
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_Ancho = 0
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
        Me.BtBusca2.Location = New System.Drawing.Point(216, 46)
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
        Me.Lb2.Location = New System.Drawing.Point(13, 50)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(121, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Hasta Acreedor"
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
        Me.TxDato4.Location = New System.Drawing.Point(910, 47)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 83
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(791, 50)
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
        Me.TxDato3.Location = New System.Drawing.Point(910, 13)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(102, 22)
        Me.TxDato3.TabIndex = 81
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(791, 16)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPorMaterial)
        Me.GroupBox1.Controls.Add(Me.RbPorAcreedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(1119, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 69)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informe"
        Me.GroupBox1.Visible = False
        '
        'RbPorMaterial
        '
        Me.RbPorMaterial.AutoSize = True
        Me.RbPorMaterial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPorMaterial.ForeColor = System.Drawing.Color.Teal
        Me.RbPorMaterial.Location = New System.Drawing.Point(8, 42)
        Me.RbPorMaterial.Name = "RbPorMaterial"
        Me.RbPorMaterial.Size = New System.Drawing.Size(113, 20)
        Me.RbPorMaterial.TabIndex = 1
        Me.RbPorMaterial.Text = "Por Material"
        Me.RbPorMaterial.UseVisualStyleBackColor = True
        '
        'RbPorAcreedor
        '
        Me.RbPorAcreedor.AutoSize = True
        Me.RbPorAcreedor.Checked = True
        Me.RbPorAcreedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPorAcreedor.ForeColor = System.Drawing.Color.Teal
        Me.RbPorAcreedor.Location = New System.Drawing.Point(8, 20)
        Me.RbPorAcreedor.Name = "RbPorAcreedor"
        Me.RbPorAcreedor.Size = New System.Drawing.Size(120, 20)
        Me.RbPorAcreedor.TabIndex = 0
        Me.RbPorAcreedor.TabStop = True
        Me.RbPorAcreedor.Text = "Por Acreedor"
        Me.RbPorAcreedor.UseVisualStyleBackColor = True
        '
        'TxAMaterial
        '
        Me.TxAMaterial.Autonumerico = False
        Me.TxAMaterial.Buscando = False
        Me.TxAMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAMaterial.ClForm = Nothing
        Me.TxAMaterial.ClParam = Nothing
        Me.TxAMaterial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAMaterial.GridLin = Nothing
        Me.TxAMaterial.HaCambiado = False
        Me.TxAMaterial.lbbusca = Nothing
        Me.TxAMaterial.Location = New System.Drawing.Point(137, 115)
        Me.TxAMaterial.MiError = False
        Me.TxAMaterial.Name = "TxAMaterial"
        Me.TxAMaterial.Orden = 0
        Me.TxAMaterial.SaltoAlfinal = False
        Me.TxAMaterial.Siguiente = 0
        Me.TxAMaterial.Size = New System.Drawing.Size(73, 22)
        Me.TxAMaterial.TabIndex = 167
        Me.TxAMaterial.TeclaRepetida = False
        Me.TxAMaterial.TxDatoFinalSemana = Nothing
        Me.TxAMaterial.TxDatoInicioSemana = Nothing
        Me.TxAMaterial.UltimoValorValidado = Nothing
        '
        'TxDMaterial
        '
        Me.TxDMaterial.Autonumerico = False
        Me.TxDMaterial.Buscando = False
        Me.TxDMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDMaterial.ClForm = Nothing
        Me.TxDMaterial.ClParam = Nothing
        Me.TxDMaterial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDMaterial.GridLin = Nothing
        Me.TxDMaterial.HaCambiado = False
        Me.TxDMaterial.lbbusca = Nothing
        Me.TxDMaterial.Location = New System.Drawing.Point(137, 81)
        Me.TxDMaterial.MiError = False
        Me.TxDMaterial.Name = "TxDMaterial"
        Me.TxDMaterial.Orden = 0
        Me.TxDMaterial.SaltoAlfinal = False
        Me.TxDMaterial.Siguiente = 0
        Me.TxDMaterial.Size = New System.Drawing.Size(73, 22)
        Me.TxDMaterial.TabIndex = 163
        Me.TxDMaterial.TeclaRepetida = False
        Me.TxDMaterial.TxDatoFinalSemana = Nothing
        Me.TxDMaterial.TxDatoInicioSemana = Nothing
        Me.TxDMaterial.UltimoValorValidado = Nothing
        '
        'LbDeMaterial
        '
        Me.LbDeMaterial.AutoSize = True
        Me.LbDeMaterial.CL_ControlAsociado = Nothing
        Me.LbDeMaterial.CL_ValorFijo = False
        Me.LbDeMaterial.ClForm = Nothing
        Me.LbDeMaterial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeMaterial.ForeColor = System.Drawing.Color.Teal
        Me.LbDeMaterial.Location = New System.Drawing.Point(13, 84)
        Me.LbDeMaterial.Name = "LbDeMaterial"
        Me.LbDeMaterial.Size = New System.Drawing.Size(116, 16)
        Me.LbDeMaterial.TabIndex = 161
        Me.LbDeMaterial.Text = "Desde Material"
        '
        'LbNombreAMaterial
        '
        Me.LbNombreAMaterial.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreAMaterial.CL_ControlAsociado = Nothing
        Me.LbNombreAMaterial.CL_ValorFijo = False
        Me.LbNombreAMaterial.ClForm = Nothing
        Me.LbNombreAMaterial.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreAMaterial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreAMaterial.Location = New System.Drawing.Point(255, 114)
        Me.LbNombreAMaterial.Name = "LbNombreAMaterial"
        Me.LbNombreAMaterial.Size = New System.Drawing.Size(472, 23)
        Me.LbNombreAMaterial.TabIndex = 168
        '
        'BtBuscaAMaterial
        '
        Me.BtBuscaAMaterial.CL_Ancho = 0
        Me.BtBuscaAMaterial.CL_BuscaAlb = False
        Me.BtBuscaAMaterial.CL_campocodigo = Nothing
        Me.BtBuscaAMaterial.CL_camponombre = Nothing
        Me.BtBuscaAMaterial.CL_CampoOrden = "Nombre"
        Me.BtBuscaAMaterial.CL_ch1000 = False
        Me.BtBuscaAMaterial.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAMaterial.CL_ControlAsociado = Nothing
        Me.BtBuscaAMaterial.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAMaterial.CL_dfecha = Nothing
        Me.BtBuscaAMaterial.CL_Entidad = Nothing
        Me.BtBuscaAMaterial.CL_EsId = True
        Me.BtBuscaAMaterial.CL_Filtro = Nothing
        Me.BtBuscaAMaterial.cl_formu = Nothing
        Me.BtBuscaAMaterial.CL_hfecha = Nothing
        Me.BtBuscaAMaterial.cl_ListaW = Nothing
        Me.BtBuscaAMaterial.CL_xCentro = False
        Me.BtBuscaAMaterial.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAMaterial.Location = New System.Drawing.Point(216, 114)
        Me.BtBuscaAMaterial.Name = "BtBuscaAMaterial"
        Me.BtBuscaAMaterial.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAMaterial.TabIndex = 166
        Me.BtBuscaAMaterial.UseVisualStyleBackColor = True
        '
        'LbAMaterial
        '
        Me.LbAMaterial.AutoSize = True
        Me.LbAMaterial.CL_ControlAsociado = Nothing
        Me.LbAMaterial.CL_ValorFijo = False
        Me.LbAMaterial.ClForm = Nothing
        Me.LbAMaterial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAMaterial.ForeColor = System.Drawing.Color.Teal
        Me.LbAMaterial.Location = New System.Drawing.Point(13, 118)
        Me.LbAMaterial.Name = "LbAMaterial"
        Me.LbAMaterial.Size = New System.Drawing.Size(114, 16)
        Me.LbAMaterial.TabIndex = 165
        Me.LbAMaterial.Text = "Hasta Material"
        '
        'LbNombreDMaterial
        '
        Me.LbNombreDMaterial.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreDMaterial.CL_ControlAsociado = Nothing
        Me.LbNombreDMaterial.CL_ValorFijo = False
        Me.LbNombreDMaterial.ClForm = Nothing
        Me.LbNombreDMaterial.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreDMaterial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreDMaterial.Location = New System.Drawing.Point(255, 80)
        Me.LbNombreDMaterial.Name = "LbNombreDMaterial"
        Me.LbNombreDMaterial.Size = New System.Drawing.Size(472, 23)
        Me.LbNombreDMaterial.TabIndex = 164
        '
        'BtBuscaDMaterial
        '
        Me.BtBuscaDMaterial.CL_Ancho = 0
        Me.BtBuscaDMaterial.CL_BuscaAlb = False
        Me.BtBuscaDMaterial.CL_campocodigo = Nothing
        Me.BtBuscaDMaterial.CL_camponombre = Nothing
        Me.BtBuscaDMaterial.CL_CampoOrden = "Nombre"
        Me.BtBuscaDMaterial.CL_ch1000 = False
        Me.BtBuscaDMaterial.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDMaterial.CL_ControlAsociado = Nothing
        Me.BtBuscaDMaterial.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDMaterial.CL_dfecha = Nothing
        Me.BtBuscaDMaterial.CL_Entidad = Nothing
        Me.BtBuscaDMaterial.CL_EsId = True
        Me.BtBuscaDMaterial.CL_Filtro = Nothing
        Me.BtBuscaDMaterial.cl_formu = Nothing
        Me.BtBuscaDMaterial.CL_hfecha = Nothing
        Me.BtBuscaDMaterial.cl_ListaW = Nothing
        Me.BtBuscaDMaterial.CL_xCentro = False
        Me.BtBuscaDMaterial.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDMaterial.Location = New System.Drawing.Point(216, 80)
        Me.BtBuscaDMaterial.Name = "BtBuscaDMaterial"
        Me.BtBuscaDMaterial.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDMaterial.TabIndex = 162
        Me.BtBuscaDMaterial.UseVisualStyleBackColor = True
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(910, 86)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(240, 20)
        Me.CbFamilias.TabIndex = 100281
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(791, 87)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(69, 16)
        Me.Lb5.TabIndex = 100280
        Me.Lb5.Text = "Familias"
        '
        'FrmConsultaTarifasPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 591)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaTarifasPrecios"
        Me.Text = "Consulta Tarifas de Precios"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RbPorMaterial As System.Windows.Forms.RadioButton
    Friend WithEvents RbPorAcreedor As System.Windows.Forms.RadioButton
    Friend WithEvents TxAMaterial As NetAgro.TxDato
    Friend WithEvents TxDMaterial As NetAgro.TxDato
    Friend WithEvents LbDeMaterial As NetAgro.Lb
    Friend WithEvents LbNombreAMaterial As NetAgro.Lb
    Friend WithEvents BtBuscaAMaterial As NetAgro.BtBusca
    Friend WithEvents LbAMaterial As NetAgro.Lb
    Friend WithEvents LbNombreDMaterial As NetAgro.Lb
    Friend WithEvents BtBuscaDMaterial As NetAgro.BtBusca
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
