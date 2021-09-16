<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPedidos))
        Me.TxFechaSalida = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbLineas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.chkMostrarStock = New NetAgro.Chk(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbSalidos = New System.Windows.Forms.RadioButton()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.rbTerminados = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkSoloStock = New NetAgro.Chk(Me.components)
        Me.LbNomCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxCliente = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.LbNomGenero = New NetAgro.Lb(Me.components)
        Me.BtBuscaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxGenero = New NetAgro.TxDato(Me.components)
        Me.Lb27 = New NetAgro.Lb(Me.components)
        Me.chkRefrescar = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.chkRefrescar)
        Me.PanelCabecera.Controls.Add(Me.LbNomGenero)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGenero)
        Me.PanelCabecera.Controls.Add(Me.TxGenero)
        Me.PanelCabecera.Controls.Add(Me.Lb27)
        Me.PanelCabecera.Controls.Add(Me.LbNomCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCliente)
        Me.PanelCabecera.Controls.Add(Me.TxCliente)
        Me.PanelCabecera.Controls.Add(Me.Lb_4)
        Me.PanelCabecera.Controls.Add(Me.ChkSoloStock)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.chkMostrarStock)
        Me.PanelCabecera.Controls.Add(Me.CbLineas)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.PictureBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxFechaSalida)
        Me.PanelCabecera.Size = New System.Drawing.Size(1370, 97)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 103)
        Me.PanelConsulta.Size = New System.Drawing.Size(1370, 499)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1053, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1145, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1220, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1295, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(978, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxFechaSalida
        '
        Me.TxFechaSalida.Autonumerico = False
        Me.TxFechaSalida.Buscando = False
        Me.TxFechaSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaSalida.ClForm = Nothing
        Me.TxFechaSalida.ClParam = Nothing
        Me.TxFechaSalida.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaSalida.GridLin = Nothing
        Me.TxFechaSalida.HaCambiado = False
        Me.TxFechaSalida.lbbusca = Nothing
        Me.TxFechaSalida.Location = New System.Drawing.Point(109, 13)
        Me.TxFechaSalida.MiError = False
        Me.TxFechaSalida.Name = "TxFechaSalida"
        Me.TxFechaSalida.Orden = 0
        Me.TxFechaSalida.SaltoAlfinal = False
        Me.TxFechaSalida.Siguiente = 0
        Me.TxFechaSalida.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaSalida.TabIndex = 81
        Me.TxFechaSalida.TeclaRepetida = False
        Me.TxFechaSalida.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(7, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(100, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Fecha Salida"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(727, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100274
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(321, 14)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(240, 20)
        Me.cbCentro.TabIndex = 100314
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(258, 16)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100313
        Me.Lb5.Text = "Centro"
        '
        'CbLineas
        '
        Me.CbLineas.EditValue = ""
        Me.CbLineas.Location = New System.Drawing.Point(660, 14)
        Me.CbLineas.Name = "CbLineas"
        Me.CbLineas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbLineas.Size = New System.Drawing.Size(240, 20)
        Me.CbLineas.TabIndex = 100316
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(603, 16)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(47, 16)
        Me.Lb3.TabIndex = 100315
        Me.Lb3.Text = "Linea"
        '
        'chkMostrarStock
        '
        Me.chkMostrarStock.AutoSize = True
        Me.chkMostrarStock.Campobd = Nothing
        Me.chkMostrarStock.Checked = True
        Me.chkMostrarStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarStock.ClForm = Nothing
        Me.chkMostrarStock.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarStock.ForeColor = System.Drawing.Color.Teal
        Me.chkMostrarStock.GridLin = Nothing
        Me.chkMostrarStock.HaCambiado = False
        Me.chkMostrarStock.Location = New System.Drawing.Point(606, 42)
        Me.chkMostrarStock.MiEntidad = Nothing
        Me.chkMostrarStock.MiError = False
        Me.chkMostrarStock.Name = "chkMostrarStock"
        Me.chkMostrarStock.Orden = 0
        Me.chkMostrarStock.SaltoAlfinal = False
        Me.chkMostrarStock.Size = New System.Drawing.Size(126, 20)
        Me.chkMostrarStock.TabIndex = 100317
        Me.chkMostrarStock.Text = "Mostrar stock"
        Me.chkMostrarStock.UseVisualStyleBackColor = True
        Me.chkMostrarStock.ValorCampoFalse = Nothing
        Me.chkMostrarStock.ValorCampoTrue = Nothing
        Me.chkMostrarStock.ValorDefecto = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbSalidos)
        Me.GroupBox2.Controls.Add(Me.rbPendientes)
        Me.GroupBox2.Controls.Add(Me.rbTerminados)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(918, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 57)
        Me.GroupBox2.TabIndex = 100318
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.ForeColor = System.Drawing.Color.Teal
        Me.rbTodos.Location = New System.Drawing.Point(346, 21)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(69, 20)
        Me.rbTodos.TabIndex = 3
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbSalidos
        '
        Me.rbSalidos.AutoSize = True
        Me.rbSalidos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSalidos.ForeColor = System.Drawing.Color.Teal
        Me.rbSalidos.Location = New System.Drawing.Point(258, 21)
        Me.rbSalidos.Name = "rbSalidos"
        Me.rbSalidos.Size = New System.Drawing.Size(78, 20)
        Me.rbSalidos.TabIndex = 2
        Me.rbSalidos.Text = "Salidos"
        Me.rbSalidos.UseVisualStyleBackColor = True
        '
        'rbPendientes
        '
        Me.rbPendientes.AutoSize = True
        Me.rbPendientes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendientes.ForeColor = System.Drawing.Color.Teal
        Me.rbPendientes.Location = New System.Drawing.Point(139, 21)
        Me.rbPendientes.Name = "rbPendientes"
        Me.rbPendientes.Size = New System.Drawing.Size(107, 20)
        Me.rbPendientes.TabIndex = 1
        Me.rbPendientes.Text = "Pendientes"
        Me.rbPendientes.UseVisualStyleBackColor = True
        '
        'rbTerminados
        '
        Me.rbTerminados.AutoSize = True
        Me.rbTerminados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTerminados.ForeColor = System.Drawing.Color.Teal
        Me.rbTerminados.Location = New System.Drawing.Point(18, 21)
        Me.rbTerminados.Name = "rbTerminados"
        Me.rbTerminados.Size = New System.Drawing.Size(111, 20)
        Me.rbTerminados.TabIndex = 0
        Me.rbTerminados.Text = "Terminados"
        Me.rbTerminados.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'ChkSoloStock
        '
        Me.ChkSoloStock.AutoSize = True
        Me.ChkSoloStock.Campobd = Nothing
        Me.ChkSoloStock.ClForm = Nothing
        Me.ChkSoloStock.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSoloStock.ForeColor = System.Drawing.Color.Teal
        Me.ChkSoloStock.GridLin = Nothing
        Me.ChkSoloStock.HaCambiado = False
        Me.ChkSoloStock.Location = New System.Drawing.Point(740, 42)
        Me.ChkSoloStock.MiEntidad = Nothing
        Me.ChkSoloStock.MiError = False
        Me.ChkSoloStock.Name = "ChkSoloStock"
        Me.ChkSoloStock.Orden = 0
        Me.ChkSoloStock.SaltoAlfinal = False
        Me.ChkSoloStock.Size = New System.Drawing.Size(160, 20)
        Me.ChkSoloStock.TabIndex = 100319
        Me.ChkSoloStock.Text = "Mostrar sólo stock"
        Me.ChkSoloStock.UseVisualStyleBackColor = True
        Me.ChkSoloStock.ValorCampoFalse = Nothing
        Me.ChkSoloStock.ValorCampoTrue = Nothing
        Me.ChkSoloStock.ValorDefecto = False
        '
        'LbNomCliente
        '
        Me.LbNomCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCliente.CL_ControlAsociado = Nothing
        Me.LbNomCliente.CL_ValorFijo = False
        Me.LbNomCliente.ClForm = Nothing
        Me.LbNomCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCliente.Location = New System.Drawing.Point(204, 41)
        Me.LbNomCliente.Name = "LbNomCliente"
        Me.LbNomCliente.Size = New System.Drawing.Size(386, 23)
        Me.LbNomCliente.TabIndex = 100323
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_Ancho = 0
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_campocodigo = Nothing
        Me.BtBuscaCliente.CL_camponombre = Nothing
        Me.BtBuscaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaCliente.CL_ch1000 = False
        Me.BtBuscaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCliente.CL_dfecha = Nothing
        Me.BtBuscaCliente.CL_Entidad = Nothing
        Me.BtBuscaCliente.CL_EsId = True
        Me.BtBuscaCliente.CL_Filtro = Nothing
        Me.BtBuscaCliente.cl_formu = Nothing
        Me.BtBuscaCliente.CL_hfecha = Nothing
        Me.BtBuscaCliente.cl_ListaW = Nothing
        Me.BtBuscaCliente.CL_xCentro = False
        Me.BtBuscaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCliente.Location = New System.Drawing.Point(165, 41)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 100322
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
        '
        'TxCliente
        '
        Me.TxCliente.Autonumerico = False
        Me.TxCliente.Buscando = False
        Me.TxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCliente.ClForm = Nothing
        Me.TxCliente.ClParam = Nothing
        Me.TxCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCliente.GridLin = Nothing
        Me.TxCliente.HaCambiado = False
        Me.TxCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCliente.lbbusca = Nothing
        Me.TxCliente.Location = New System.Drawing.Point(109, 41)
        Me.TxCliente.MiError = False
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.Orden = 0
        Me.TxCliente.SaltoAlfinal = False
        Me.TxCliente.Siguiente = 0
        Me.TxCliente.Size = New System.Drawing.Size(53, 22)
        Me.TxCliente.TabIndex = 100321
        Me.TxCliente.TeclaRepetida = False
        Me.TxCliente.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(7, 44)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(59, 16)
        Me.Lb_4.TabIndex = 100320
        Me.Lb_4.Text = "Cliente"
        '
        'LbNomGenero
        '
        Me.LbNomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGenero.CL_ControlAsociado = Nothing
        Me.LbNomGenero.CL_ValorFijo = False
        Me.LbNomGenero.ClForm = Nothing
        Me.LbNomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGenero.Location = New System.Drawing.Point(204, 69)
        Me.LbNomGenero.Name = "LbNomGenero"
        Me.LbNomGenero.Size = New System.Drawing.Size(386, 23)
        Me.LbNomGenero.TabIndex = 100327
        '
        'BtBuscaGenero
        '
        Me.BtBuscaGenero.CL_Ancho = 0
        Me.BtBuscaGenero.CL_BuscaAlb = False
        Me.BtBuscaGenero.CL_campocodigo = Nothing
        Me.BtBuscaGenero.CL_camponombre = Nothing
        Me.BtBuscaGenero.CL_CampoOrden = "Nombre"
        Me.BtBuscaGenero.CL_ch1000 = False
        Me.BtBuscaGenero.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGenero.CL_ControlAsociado = Nothing
        Me.BtBuscaGenero.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGenero.CL_dfecha = Nothing
        Me.BtBuscaGenero.CL_Entidad = Nothing
        Me.BtBuscaGenero.CL_EsId = True
        Me.BtBuscaGenero.CL_Filtro = Nothing
        Me.BtBuscaGenero.cl_formu = Nothing
        Me.BtBuscaGenero.CL_hfecha = Nothing
        Me.BtBuscaGenero.cl_ListaW = Nothing
        Me.BtBuscaGenero.CL_xCentro = False
        Me.BtBuscaGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGenero.Location = New System.Drawing.Point(165, 69)
        Me.BtBuscaGenero.Name = "BtBuscaGenero"
        Me.BtBuscaGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGenero.TabIndex = 100326
        Me.BtBuscaGenero.UseVisualStyleBackColor = True
        '
        'TxGenero
        '
        Me.TxGenero.Autonumerico = False
        Me.TxGenero.Buscando = False
        Me.TxGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGenero.ClForm = Nothing
        Me.TxGenero.ClParam = Nothing
        Me.TxGenero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGenero.GridLin = Nothing
        Me.TxGenero.HaCambiado = False
        Me.TxGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxGenero.lbbusca = Nothing
        Me.TxGenero.Location = New System.Drawing.Point(109, 69)
        Me.TxGenero.MiError = False
        Me.TxGenero.Name = "TxGenero"
        Me.TxGenero.Orden = 0
        Me.TxGenero.SaltoAlfinal = False
        Me.TxGenero.Siguiente = 0
        Me.TxGenero.Size = New System.Drawing.Size(53, 22)
        Me.TxGenero.TabIndex = 100325
        Me.TxGenero.TeclaRepetida = False
        Me.TxGenero.UltimoValorValidado = Nothing
        '
        'Lb27
        '
        Me.Lb27.AutoSize = True
        Me.Lb27.CL_ControlAsociado = Nothing
        Me.Lb27.CL_ValorFijo = False
        Me.Lb27.ClForm = Nothing
        Me.Lb27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb27.ForeColor = System.Drawing.Color.Teal
        Me.Lb27.Location = New System.Drawing.Point(7, 72)
        Me.Lb27.Name = "Lb27"
        Me.Lb27.Size = New System.Drawing.Size(60, 16)
        Me.Lb27.TabIndex = 100324
        Me.Lb27.Text = "Genero"
        '
        'chkRefrescar
        '
        Me.chkRefrescar.AutoSize = True
        Me.chkRefrescar.Campobd = Nothing
        Me.chkRefrescar.Checked = True
        Me.chkRefrescar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRefrescar.ClForm = Nothing
        Me.chkRefrescar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRefrescar.ForeColor = System.Drawing.Color.Teal
        Me.chkRefrescar.GridLin = Nothing
        Me.chkRefrescar.HaCambiado = False
        Me.chkRefrescar.Location = New System.Drawing.Point(606, 70)
        Me.chkRefrescar.MiEntidad = Nothing
        Me.chkRefrescar.MiError = False
        Me.chkRefrescar.Name = "chkRefrescar"
        Me.chkRefrescar.Orden = 0
        Me.chkRefrescar.SaltoAlfinal = False
        Me.chkRefrescar.Size = New System.Drawing.Size(141, 20)
        Me.chkRefrescar.TabIndex = 100328
        Me.chkRefrescar.Text = "Refrescar datos"
        Me.chkRefrescar.UseVisualStyleBackColor = True
        Me.chkRefrescar.ValorCampoFalse = Nothing
        Me.chkRefrescar.ValorCampoTrue = Nothing
        Me.chkRefrescar.ValorDefecto = False
        Me.chkRefrescar.Visible = False
        '
        'FrmConsultaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 642)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaPedidos"
        Me.Text = "Consulta pedidos"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxFechaSalida As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbLineas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents chkMostrarStock As NetAgro.Chk
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSalidos As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerminados As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChkSoloStock As NetAgro.Chk
    Friend WithEvents LbNomCliente As NetAgro.Lb
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents TxCliente As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents LbNomGenero As NetAgro.Lb
    Friend WithEvents BtBuscaGenero As NetAgro.BtBusca
    Friend WithEvents TxGenero As NetAgro.TxDato
    Friend WithEvents Lb27 As NetAgro.Lb
    Friend WithEvents chkRefrescar As NetAgro.Chk
End Class
