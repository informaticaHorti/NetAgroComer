<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoEnvasesPorAlbaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoEnvasesPorAlbaran))
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
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodosFacturados = New System.Windows.Forms.RadioButton()
        Me.RbNoFacturados = New System.Windows.Forms.RadioButton()
        Me.RbSiFacturados = New System.Windows.Forms.RadioButton()
        Me.chkSoloPrecio = New NetAgro.Chk(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.BtBusca6 = New NetAgro.BtBusca(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb_6 = New NetAgro.Lb(Me.components)
        Me.BtBusca5 = New NetAgro.BtBusca(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxDato6)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.BtBusca6)
        Me.Panel2.Controls.Add(Me.Lb6)
        Me.Panel2.Controls.Add(Me.Lb_5)
        Me.Panel2.Controls.Add(Me.TxDato5)
        Me.Panel2.Controls.Add(Me.Lb_6)
        Me.Panel2.Controls.Add(Me.BtBusca5)
        Me.Panel2.Controls.Add(Me.TxDato7)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.chkSoloPrecio)
        Me.Panel2.Controls.Add(Me.Lb_2)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Lb15)
        Me.Panel2.Controls.Add(Me.cbPuntoVenta)
        Me.Panel2.Controls.Add(Me.TxDato4)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Size = New System.Drawing.Size(1234, 124)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 130)
        Me.Panel3.Size = New System.Drawing.Size(1234, 392)
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
        Me.TxDato1.Location = New System.Drawing.Point(127, 8)
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
        Me.BtBusca1.Location = New System.Drawing.Point(196, 8)
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
        Me.Lb1.Location = New System.Drawing.Point(13, 11)
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
        Me.Lb_1.Location = New System.Drawing.Point(235, 8)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(414, 23)
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
        Me.Lb_2.Location = New System.Drawing.Point(235, 36)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(414, 23)
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
        Me.TxDato2.Location = New System.Drawing.Point(127, 36)
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
        Me.BtBusca2.Location = New System.Drawing.Point(196, 36)
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
        Me.Lb2.Location = New System.Drawing.Point(13, 39)
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
        Me.TxDato4.Location = New System.Drawing.Point(840, 36)
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
        Me.Lb4.Location = New System.Drawing.Point(737, 39)
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
        Me.TxDato3.Location = New System.Drawing.Point(840, 8)
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
        Me.Lb3.Location = New System.Drawing.Point(737, 11)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Desde fecha"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(961, 93)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(251, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(837, 95)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(118, 16)
        Me.Lb15.TabIndex = 100272
        Me.Lb15.Text = "Punto de venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodosFacturados)
        Me.GroupBox2.Controls.Add(Me.RbNoFacturados)
        Me.GroupBox2.Controls.Add(Me.RbSiFacturados)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(954, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 42)
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
        Me.RbTodosFacturados.Location = New System.Drawing.Point(154, 16)
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
        Me.RbNoFacturados.Location = New System.Drawing.Point(79, 16)
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
        Me.RbSiFacturados.Location = New System.Drawing.Point(16, 16)
        Me.RbSiFacturados.Name = "RbSiFacturados"
        Me.RbSiFacturados.Size = New System.Drawing.Size(41, 20)
        Me.RbSiFacturados.TabIndex = 0
        Me.RbSiFacturados.Text = "SI"
        Me.RbSiFacturados.UseVisualStyleBackColor = True
        '
        'chkSoloPrecio
        '
        Me.chkSoloPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSoloPrecio.AutoSize = True
        Me.chkSoloPrecio.Campobd = Nothing
        Me.chkSoloPrecio.ClForm = Nothing
        Me.chkSoloPrecio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloPrecio.ForeColor = System.Drawing.Color.Teal
        Me.chkSoloPrecio.GridLin = Nothing
        Me.chkSoloPrecio.HaCambiado = False
        Me.chkSoloPrecio.Location = New System.Drawing.Point(682, 93)
        Me.chkSoloPrecio.MiEntidad = Nothing
        Me.chkSoloPrecio.MiError = False
        Me.chkSoloPrecio.Name = "chkSoloPrecio"
        Me.chkSoloPrecio.Orden = 0
        Me.chkSoloPrecio.SaltoAlfinal = False
        Me.chkSoloPrecio.Size = New System.Drawing.Size(137, 20)
        Me.chkSoloPrecio.TabIndex = 100274
        Me.chkSoloPrecio.Text = "Solo con precio"
        Me.chkSoloPrecio.UseVisualStyleBackColor = True
        Me.chkSoloPrecio.ValorCampoFalse = Nothing
        Me.chkSoloPrecio.ValorCampoTrue = Nothing
        Me.chkSoloPrecio.ValorDefecto = True
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
        Me.TxDato7.Location = New System.Drawing.Point(840, 64)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(102, 22)
        Me.TxDato7.TabIndex = 100276
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
        Me.Lb7.Location = New System.Drawing.Point(679, 67)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(153, 16)
        Me.Lb7.TabIndex = 100275
        Me.Lb7.Text = "Desde fecha factura"
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
        Me.TxDato6.Location = New System.Drawing.Point(127, 92)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(63, 22)
        Me.TxDato6.TabIndex = 100283
        Me.TxDato6.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(13, 67)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(110, 16)
        Me.Lb5.TabIndex = 100277
        Me.Lb5.Text = "Desde Envase"
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
        Me.BtBusca6.Location = New System.Drawing.Point(196, 92)
        Me.BtBusca6.Name = "BtBusca6"
        Me.BtBusca6.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca6.TabIndex = 100282
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
        Me.Lb6.Location = New System.Drawing.Point(13, 95)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(108, 16)
        Me.Lb6.TabIndex = 100281
        Me.Lb6.Text = "Hasta Envase"
        '
        'Lb_5
        '
        Me.Lb_5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_5.Location = New System.Drawing.Point(235, 64)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(414, 23)
        Me.Lb_5.TabIndex = 100280
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
        Me.TxDato5.Location = New System.Drawing.Point(127, 64)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(63, 22)
        Me.TxDato5.TabIndex = 100279
        Me.TxDato5.TeclaRepetida = False
        '
        'Lb_6
        '
        Me.Lb_6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_6.CL_ControlAsociado = Nothing
        Me.Lb_6.CL_ValorFijo = False
        Me.Lb_6.ClForm = Nothing
        Me.Lb_6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_6.Location = New System.Drawing.Point(235, 92)
        Me.Lb_6.Name = "Lb_6"
        Me.Lb_6.Size = New System.Drawing.Size(414, 23)
        Me.Lb_6.TabIndex = 100284
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
        Me.BtBusca5.Location = New System.Drawing.Point(196, 64)
        Me.BtBusca5.Name = "BtBusca5"
        Me.BtBusca5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca5.TabIndex = 100278
        Me.BtBusca5.UseVisualStyleBackColor = True
        '
        'FrmListadoEnvasesPorAlbaran
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
        Me.Name = "FrmListadoEnvasesPorAlbaran"
        Me.Text = "Listado albaranes con envases"
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
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodosFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents chkSoloPrecio As NetAgro.Chk
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents BtBusca6 As NetAgro.BtBusca
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb_6 As NetAgro.Lb
    Friend WithEvents BtBusca5 As NetAgro.BtBusca
End Class
