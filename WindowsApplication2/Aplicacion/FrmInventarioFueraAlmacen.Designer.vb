<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioFueraAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioFueraAlmacen))
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.BtBusca4 = New NetAgro.BtBusca(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.BtBusca3 = New NetAgro.BtBusca(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbDetallado = New System.Windows.Forms.RadioButton()
        Me.RbResumido = New System.Windows.Forms.RadioButton()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTodosRetornables = New System.Windows.Forms.RadioButton()
        Me.RbNoRetornables = New System.Windows.Forms.RadioButton()
        Me.RbSiRetornables = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbNoValorado = New System.Windows.Forms.RadioButton()
        Me.RbSiValorado = New System.Windows.Forms.RadioButton()
        Me.ChkIncluirSaldoAnterior = New NetAgro.Chk(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.cbAlmacenes = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.cbAlmacenes)
        Me.PanelCabecera.Controls.Add(Me.ChkIncluirSaldoAnterior)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb_4)
        Me.PanelCabecera.Controls.Add(Me.BtBusca4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb_3)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Controls.Add(Me.BtBusca3)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 106)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 112)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 423)
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
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 14)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 148
        Me.Lb1.Text = "Desde fecha"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(21, 43)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 172
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(124, 11)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(116, 23)
        Me.TxDato1.TabIndex = 152
        Me.TxDato1.TeclaRepetida = False
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(124, 40)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(116, 23)
        Me.TxDato2.TabIndex = 176
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb_4
        '
        Me.Lb_4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_4.Location = New System.Drawing.Point(509, 40)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(420, 23)
        Me.Lb_4.TabIndex = 100282
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
        Me.TxDato4.Location = New System.Drawing.Point(401, 40)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(63, 22)
        Me.TxDato4.TabIndex = 100281
        Me.TxDato4.TeclaRepetida = False
        '
        'BtBusca4
        '
        Me.BtBusca4.CL_BuscaAlb = False
        Me.BtBusca4.CL_campocodigo = Nothing
        Me.BtBusca4.CL_camponombre = Nothing
        Me.BtBusca4.CL_CampoOrden = "Nombre"
        Me.BtBusca4.CL_ch1000 = False
        Me.BtBusca4.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca4.CL_ControlAsociado = Nothing
        Me.BtBusca4.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca4.CL_dfecha = Nothing
        Me.BtBusca4.CL_Entidad = Nothing
        Me.BtBusca4.CL_Filtro = Nothing
        Me.BtBusca4.cl_formu = Nothing
        Me.BtBusca4.CL_hfecha = Nothing
        Me.BtBusca4.cl_ListaW = Nothing
        Me.BtBusca4.CL_xCentro = False
        Me.BtBusca4.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca4.Location = New System.Drawing.Point(470, 40)
        Me.BtBusca4.Name = "BtBusca4"
        Me.BtBusca4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca4.TabIndex = 100280
        Me.BtBusca4.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(285, 43)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(108, 16)
        Me.Lb4.TabIndex = 100279
        Me.Lb4.Text = "Hasta Envase"
        '
        'Lb_3
        '
        Me.Lb_3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_3.Location = New System.Drawing.Point(509, 11)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(420, 23)
        Me.Lb_3.TabIndex = 100278
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
        Me.TxDato3.Location = New System.Drawing.Point(401, 11)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(63, 22)
        Me.TxDato3.TabIndex = 100277
        Me.TxDato3.TeclaRepetida = False
        '
        'BtBusca3
        '
        Me.BtBusca3.CL_BuscaAlb = False
        Me.BtBusca3.CL_campocodigo = Nothing
        Me.BtBusca3.CL_camponombre = Nothing
        Me.BtBusca3.CL_CampoOrden = "Nombre"
        Me.BtBusca3.CL_ch1000 = False
        Me.BtBusca3.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca3.CL_ControlAsociado = Nothing
        Me.BtBusca3.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca3.CL_dfecha = Nothing
        Me.BtBusca3.CL_Entidad = Nothing
        Me.BtBusca3.CL_Filtro = Nothing
        Me.BtBusca3.cl_formu = Nothing
        Me.BtBusca3.CL_hfecha = Nothing
        Me.BtBusca3.cl_ListaW = Nothing
        Me.BtBusca3.CL_xCentro = False
        Me.BtBusca3.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca3.Location = New System.Drawing.Point(470, 11)
        Me.BtBusca3.Name = "BtBusca3"
        Me.BtBusca3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca3.TabIndex = 100276
        Me.BtBusca3.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(285, 14)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(110, 16)
        Me.Lb3.TabIndex = 100275
        Me.Lb3.Text = "Desde Envase"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbDetallado)
        Me.GroupBox1.Controls.Add(Me.RbResumido)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(712, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 42)
        Me.GroupBox1.TabIndex = 100284
        Me.GroupBox1.TabStop = False
        '
        'RbDetallado
        '
        Me.RbDetallado.AutoSize = True
        Me.RbDetallado.Checked = True
        Me.RbDetallado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetallado.ForeColor = System.Drawing.Color.Teal
        Me.RbDetallado.Location = New System.Drawing.Point(116, 15)
        Me.RbDetallado.Name = "RbDetallado"
        Me.RbDetallado.Size = New System.Drawing.Size(95, 20)
        Me.RbDetallado.TabIndex = 1
        Me.RbDetallado.TabStop = True
        Me.RbDetallado.Text = "Detallado"
        Me.RbDetallado.UseVisualStyleBackColor = True
        '
        'RbResumido
        '
        Me.RbResumido.AutoSize = True
        Me.RbResumido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbResumido.ForeColor = System.Drawing.Color.Teal
        Me.RbResumido.Location = New System.Drawing.Point(11, 15)
        Me.RbResumido.Name = "RbResumido"
        Me.RbResumido.Size = New System.Drawing.Size(97, 20)
        Me.RbResumido.TabIndex = 0
        Me.RbResumido.Text = "Resumido"
        Me.RbResumido.UseVisualStyleBackColor = True
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(610, 76)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(91, 16)
        Me.Lb6.TabIndex = 100285
        Me.Lb6.Text = "Tipo listado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTodosRetornables)
        Me.GroupBox3.Controls.Add(Me.RbNoRetornables)
        Me.GroupBox3.Controls.Add(Me.RbSiRetornables)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(950, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 42)
        Me.GroupBox3.TabIndex = 100288
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Retornables"
        '
        'RbTodosRetornables
        '
        Me.RbTodosRetornables.AutoSize = True
        Me.RbTodosRetornables.Checked = True
        Me.RbTodosRetornables.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosRetornables.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosRetornables.Location = New System.Drawing.Point(130, 15)
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
        Me.RbNoRetornables.Location = New System.Drawing.Point(74, 15)
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
        Me.RbSiRetornables.Location = New System.Drawing.Point(20, 15)
        Me.RbSiRetornables.Name = "RbSiRetornables"
        Me.RbSiRetornables.Size = New System.Drawing.Size(41, 20)
        Me.RbSiRetornables.TabIndex = 0
        Me.RbSiRetornables.Text = "SI"
        Me.RbSiRetornables.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbNoValorado)
        Me.GroupBox2.Controls.Add(Me.RbSiValorado)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(1034, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 42)
        Me.GroupBox2.TabIndex = 100289
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valorados"
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
        'ChkIncluirSaldoAnterior
        '
        Me.ChkIncluirSaldoAnterior.AutoSize = True
        Me.ChkIncluirSaldoAnterior.Campobd = Nothing
        Me.ChkIncluirSaldoAnterior.Checked = True
        Me.ChkIncluirSaldoAnterior.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkIncluirSaldoAnterior.ClForm = Nothing
        Me.ChkIncluirSaldoAnterior.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIncluirSaldoAnterior.ForeColor = System.Drawing.Color.Teal
        Me.ChkIncluirSaldoAnterior.GridLin = Nothing
        Me.ChkIncluirSaldoAnterior.HaCambiado = False
        Me.ChkIncluirSaldoAnterior.Location = New System.Drawing.Point(401, 74)
        Me.ChkIncluirSaldoAnterior.MiEntidad = Nothing
        Me.ChkIncluirSaldoAnterior.MiError = False
        Me.ChkIncluirSaldoAnterior.Name = "ChkIncluirSaldoAnterior"
        Me.ChkIncluirSaldoAnterior.Orden = 0
        Me.ChkIncluirSaldoAnterior.SaltoAlfinal = False
        Me.ChkIncluirSaldoAnterior.Size = New System.Drawing.Size(178, 20)
        Me.ChkIncluirSaldoAnterior.TabIndex = 100290
        Me.ChkIncluirSaldoAnterior.Text = "Incluir saldo anterior"
        Me.ChkIncluirSaldoAnterior.UseVisualStyleBackColor = True
        Me.ChkIncluirSaldoAnterior.ValorCampoFalse = Nothing
        Me.ChkIncluirSaldoAnterior.ValorCampoTrue = Nothing
        Me.ChkIncluirSaldoAnterior.ValorDefecto = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(21, 76)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(71, 16)
        Me.Lb5.TabIndex = 100292
        Me.Lb5.Text = "Almacén"
        '
        'cbAlmacenes
        '
        Me.cbAlmacenes.EditValue = ""
        Me.cbAlmacenes.Location = New System.Drawing.Point(124, 74)
        Me.cbAlmacenes.Name = "cbAlmacenes"
        Me.cbAlmacenes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlmacenes.Size = New System.Drawing.Size(269, 20)
        Me.cbAlmacenes.TabIndex = 100291
        '
        'FrmInventarioFueraAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmInventarioFueraAlmacen"
        Me.Text = "Saldos por tipo envase - Agricultores"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents BtBusca4 As NetAgro.BtBusca
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents BtBusca3 As NetAgro.BtBusca
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents RbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiRetornables As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbNoValorado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiValorado As System.Windows.Forms.RadioButton
    Friend WithEvents ChkIncluirSaldoAnterior As NetAgro.Chk
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents cbAlmacenes As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
