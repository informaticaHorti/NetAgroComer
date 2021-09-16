<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSaldoEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSaldoEnvases))
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbAgricultor = New System.Windows.Forms.RadioButton()
        Me.RbCliente = New System.Windows.Forms.RadioButton()
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.BtBusca5 = New NetAgro.BtBusca(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb_6 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.BtBusca6 = New NetAgro.BtBusca(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbNoValorado = New System.Windows.Forms.RadioButton()
        Me.RbSiValorado = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTodosRetornables = New System.Windows.Forms.RadioButton()
        Me.RbNoRetornables = New System.Windows.Forms.RadioButton()
        Me.RbSiRetornables = New System.Windows.Forms.RadioButton()
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbDetallado = New System.Windows.Forms.RadioButton()
        Me.RbResumido = New System.Windows.Forms.RadioButton()
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb9)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.Lb8)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxDato7)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.Lb_6)
        Me.PanelCabecera.Controls.Add(Me.TxDato6)
        Me.PanelCabecera.Controls.Add(Me.BtBusca6)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb_5)
        Me.PanelCabecera.Controls.Add(Me.TxDato5)
        Me.PanelCabecera.Controls.Add(Me.BtBusca5)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.Lb_2)
        Me.PanelCabecera.Controls.Add(Me.BtBusca2)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.Lb_1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.BtBusca1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 149)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 149)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 392)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(884, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(959, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1034, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1109, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(809, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(584, 10)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 148
        Me.Lb3.Text = "Desde fecha"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(584, 36)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(95, 16)
        Me.Lb4.TabIndex = 172
        Me.Lb4.Text = "Hasta fecha"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(720, 7)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(116, 23)
        Me.TxDato3.TabIndex = 152
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(720, 33)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(116, 23)
        Me.TxDato4.TabIndex = 176
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb_2
        '
        Me.Lb_2.BackColor = System.Drawing.Color.LightGray
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_2.Location = New System.Drawing.Point(251, 34)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(309, 23)
        Me.Lb_2.TabIndex = 100282
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
        Me.TxDato2.Location = New System.Drawing.Point(143, 34)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(63, 22)
        Me.TxDato2.TabIndex = 100281
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
        Me.BtBusca2.Location = New System.Drawing.Point(212, 34)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 100280
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
        Me.Lb2.Location = New System.Drawing.Point(9, 37)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(126, 16)
        Me.Lb2.TabIndex = 100279
        Me.Lb2.Text = "Hasta Agricultor"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.Color.LightGray
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(251, 7)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(309, 23)
        Me.Lb_1.TabIndex = 100278
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
        Me.TxDato1.Location = New System.Drawing.Point(143, 7)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 100277
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
        Me.BtBusca1.Location = New System.Drawing.Point(212, 7)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 100276
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
        Me.Lb1.Location = New System.Drawing.Point(9, 10)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(128, 16)
        Me.Lb1.TabIndex = 100275
        Me.Lb1.Text = "Desde Agricultor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbAgricultor)
        Me.GroupBox2.Controls.Add(Me.RbCliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(880, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 73)
        Me.GroupBox2.TabIndex = 100290
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de sujeto"
        '
        'RbAgricultor
        '
        Me.RbAgricultor.AutoSize = True
        Me.RbAgricultor.Checked = True
        Me.RbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.RbAgricultor.Location = New System.Drawing.Point(17, 42)
        Me.RbAgricultor.Name = "RbAgricultor"
        Me.RbAgricultor.Size = New System.Drawing.Size(97, 20)
        Me.RbAgricultor.TabIndex = 1
        Me.RbAgricultor.TabStop = True
        Me.RbAgricultor.Text = "Agricultor"
        Me.RbAgricultor.UseVisualStyleBackColor = True
        '
        'RbCliente
        '
        Me.RbCliente.AutoSize = True
        Me.RbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCliente.ForeColor = System.Drawing.Color.Teal
        Me.RbCliente.Location = New System.Drawing.Point(17, 17)
        Me.RbCliente.Name = "RbCliente"
        Me.RbCliente.Size = New System.Drawing.Size(77, 20)
        Me.RbCliente.TabIndex = 0
        Me.RbCliente.Text = "Cliente"
        Me.RbCliente.UseVisualStyleBackColor = True
        '
        'Lb_5
        '
        Me.Lb_5.BackColor = System.Drawing.Color.LightGray
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_5.Location = New System.Drawing.Point(251, 61)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(309, 23)
        Me.Lb_5.TabIndex = 100294
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
        Me.TxDato5.Location = New System.Drawing.Point(143, 61)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(63, 22)
        Me.TxDato5.TabIndex = 100293
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'BtBusca5
        '
        Me.BtBusca5.CL_Ancho = 0
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
        Me.BtBusca5.Location = New System.Drawing.Point(212, 61)
        Me.BtBusca5.Name = "BtBusca5"
        Me.BtBusca5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca5.TabIndex = 100292
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
        Me.Lb5.Location = New System.Drawing.Point(9, 64)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(110, 16)
        Me.Lb5.TabIndex = 100291
        Me.Lb5.Text = "Desde Envase"
        '
        'Lb_6
        '
        Me.Lb_6.BackColor = System.Drawing.Color.LightGray
        Me.Lb_6.CL_ControlAsociado = Nothing
        Me.Lb_6.CL_ValorFijo = False
        Me.Lb_6.ClForm = Nothing
        Me.Lb_6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_6.Location = New System.Drawing.Point(251, 88)
        Me.Lb_6.Name = "Lb_6"
        Me.Lb_6.Size = New System.Drawing.Size(309, 23)
        Me.Lb_6.TabIndex = 100298
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
        Me.TxDato6.Location = New System.Drawing.Point(143, 88)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(63, 22)
        Me.TxDato6.TabIndex = 100297
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'BtBusca6
        '
        Me.BtBusca6.CL_Ancho = 0
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
        Me.BtBusca6.Location = New System.Drawing.Point(212, 88)
        Me.BtBusca6.Name = "BtBusca6"
        Me.BtBusca6.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca6.TabIndex = 100296
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
        Me.Lb6.Location = New System.Drawing.Point(9, 91)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(108, 16)
        Me.Lb6.TabIndex = 100295
        Me.Lb6.Text = "Hasta Envase"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(720, 60)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(116, 23)
        Me.TxDato7.TabIndex = 100300
        Me.TxDato7.TeclaRepetida = False
        Me.TxDato7.TxDatoFinalSemana = Nothing
        Me.TxDato7.TxDatoInicioSemana = Nothing
        Me.TxDato7.UltimoValorValidado = Nothing
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(584, 63)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(125, 16)
        Me.Lb7.TabIndex = 100299
        Me.Lb7.Text = "Saldo superior a"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbNoValorado)
        Me.GroupBox1.Controls.Add(Me.RbSiValorado)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(1034, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 42)
        Me.GroupBox1.TabIndex = 100301
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valorados"
        '
        'RbNoValorado
        '
        Me.RbNoValorado.AutoSize = True
        Me.RbNoValorado.Checked = True
        Me.RbNoValorado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoValorado.ForeColor = System.Drawing.Color.Teal
        Me.RbNoValorado.Location = New System.Drawing.Point(74, 15)
        Me.RbNoValorado.Name = "RbNoValorado"
        Me.RbNoValorado.Size = New System.Drawing.Size(47, 20)
        Me.RbNoValorado.TabIndex = 1
        Me.RbNoValorado.TabStop = True
        Me.RbNoValorado.Text = "NO"
        Me.RbNoValorado.UseVisualStyleBackColor = True
        '
        'RbSiValorado
        '
        Me.RbSiValorado.AutoSize = True
        Me.RbSiValorado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiValorado.ForeColor = System.Drawing.Color.Teal
        Me.RbSiValorado.Location = New System.Drawing.Point(20, 15)
        Me.RbSiValorado.Name = "RbSiValorado"
        Me.RbSiValorado.Size = New System.Drawing.Size(41, 20)
        Me.RbSiValorado.TabIndex = 0
        Me.RbSiValorado.Text = "SI"
        Me.RbSiValorado.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTodosRetornables)
        Me.GroupBox3.Controls.Add(Me.RbNoRetornables)
        Me.GroupBox3.Controls.Add(Me.RbSiRetornables)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(1034, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 81)
        Me.GroupBox3.TabIndex = 100302
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Retornables"
        '
        'RbTodosRetornables
        '
        Me.RbTodosRetornables.AutoSize = True
        Me.RbTodosRetornables.Checked = True
        Me.RbTodosRetornables.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosRetornables.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosRetornables.Location = New System.Drawing.Point(20, 56)
        Me.RbTodosRetornables.Name = "RbTodosRetornables"
        Me.RbTodosRetornables.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosRetornables.TabIndex = 2
        Me.RbTodosRetornables.TabStop = True
        Me.RbTodosRetornables.Text = "Todos"
        Me.RbTodosRetornables.UseVisualStyleBackColor = True
        '
        'RbNoRetornables
        '
        Me.RbNoRetornables.AutoSize = True
        Me.RbNoRetornables.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoRetornables.ForeColor = System.Drawing.Color.Teal
        Me.RbNoRetornables.Location = New System.Drawing.Point(20, 34)
        Me.RbNoRetornables.Name = "RbNoRetornables"
        Me.RbNoRetornables.Size = New System.Drawing.Size(47, 20)
        Me.RbNoRetornables.TabIndex = 1
        Me.RbNoRetornables.Text = "NO"
        Me.RbNoRetornables.UseVisualStyleBackColor = True
        '
        'RbSiRetornables
        '
        Me.RbSiRetornables.AutoSize = True
        Me.RbSiRetornables.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiRetornables.ForeColor = System.Drawing.Color.Teal
        Me.RbSiRetornables.Location = New System.Drawing.Point(20, 13)
        Me.RbSiRetornables.Name = "RbSiRetornables"
        Me.RbSiRetornables.Size = New System.Drawing.Size(41, 20)
        Me.RbSiRetornables.TabIndex = 0
        Me.RbSiRetornables.Text = "SI"
        Me.RbSiRetornables.UseVisualStyleBackColor = True
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(706, 101)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(91, 16)
        Me.Lb8.TabIndex = 100304
        Me.Lb8.Text = "Tipo listado"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbDetallado)
        Me.GroupBox4.Controls.Add(Me.RbResumido)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(802, 84)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(217, 42)
        Me.GroupBox4.TabIndex = 100303
        Me.GroupBox4.TabStop = False
        '
        'RbDetallado
        '
        Me.RbDetallado.AutoSize = True
        Me.RbDetallado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetallado.ForeColor = System.Drawing.Color.Teal
        Me.RbDetallado.Location = New System.Drawing.Point(116, 15)
        Me.RbDetallado.Name = "RbDetallado"
        Me.RbDetallado.Size = New System.Drawing.Size(95, 20)
        Me.RbDetallado.TabIndex = 1
        Me.RbDetallado.Text = "Detallado"
        Me.RbDetallado.UseVisualStyleBackColor = True
        '
        'RbResumido
        '
        Me.RbResumido.AutoSize = True
        Me.RbResumido.Checked = True
        Me.RbResumido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbResumido.ForeColor = System.Drawing.Color.Teal
        Me.RbResumido.Location = New System.Drawing.Point(11, 15)
        Me.RbResumido.Name = "RbResumido"
        Me.RbResumido.Size = New System.Drawing.Size(97, 20)
        Me.RbResumido.TabIndex = 0
        Me.RbResumido.TabStop = True
        Me.RbResumido.Text = "Resumido"
        Me.RbResumido.UseVisualStyleBackColor = True
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(9, 119)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(69, 16)
        Me.Lb9.TabIndex = 100406
        Me.Lb9.Text = "Familias"
        Me.Lb9.Visible = False
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(143, 117)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(417, 20)
        Me.CbFamilias.TabIndex = 100405
        Me.CbFamilias.Visible = False
        '
        'FrmConsultaSaldoEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaSaldoEnvases"
        Me.Text = "Saldos envases por tipo sujeto"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbAgricultor As System.Windows.Forms.RadioButton
    Friend WithEvents RbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents Lb_6 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents BtBusca6 As NetAgro.BtBusca
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents BtBusca5 As NetAgro.BtBusca
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbNoValorado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiValorado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents RbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
