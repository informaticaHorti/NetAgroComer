<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGasComerCompra
    Inherits NetAgro.FrMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGasComerCompra))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LbNuFactura = New NetAgro.Lb(Me.components)
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.LbNomAcreedor = New NetAgro.Lb(Me.components)
        Me.BtBuscaAcreedor = New NetAgro.BtBusca(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.CbBox2 = New NetAgro.CbBox(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaGasto = New NetAgro.BtBusca(Me.components)
        Me.TxDato22 = New NetAgro.TxDato(Me.components)
        Me.Lb32 = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.LbIgeneros = New NetAgro.Lb(Me.components)
        Me.Lb24 = New NetAgro.Lb(Me.components)
        Me.LbPalets = New NetAgro.Lb(Me.components)
        Me.Lb21 = New NetAgro.Lb(Me.components)
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbNomPv = New NetAgro.Lb(Me.components)
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.LbGastosCom = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 354)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LbNuFactura)
        Me.GroupBox7.Controls.Add(Me.Lb17)
        Me.GroupBox7.Controls.Add(Me.LbNomAcreedor)
        Me.GroupBox7.Controls.Add(Me.BtBuscaAcreedor)
        Me.GroupBox7.Controls.Add(Me.Lb7)
        Me.GroupBox7.Controls.Add(Me.TxDato11)
        Me.GroupBox7.Controls.Add(Me.Lb12)
        Me.GroupBox7.Controls.Add(Me.TxDato10)
        Me.GroupBox7.Controls.Add(Me.CbBox2)
        Me.GroupBox7.Controls.Add(Me.Lb8)
        Me.GroupBox7.Controls.Add(Me.Lb1)
        Me.GroupBox7.Controls.Add(Me.BtBuscaGasto)
        Me.GroupBox7.Controls.Add(Me.Lb32)
        Me.GroupBox7.Controls.Add(Me.Lb23)
        Me.GroupBox7.Controls.Add(Me.TxDato22)
        Me.GroupBox7.Controls.Add(Me.ClGrid2)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1070, 343)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Gastos comerciales"
        '
        'LbNuFactura
        '
        Me.LbNuFactura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNuFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNuFactura.CL_ControlAsociado = Nothing
        Me.LbNuFactura.CL_ValorFijo = True
        Me.LbNuFactura.ClForm = Nothing
        Me.LbNuFactura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuFactura.ForeColor = System.Drawing.Color.Red
        Me.LbNuFactura.Location = New System.Drawing.Point(640, 51)
        Me.LbNuFactura.Name = "LbNuFactura"
        Me.LbNuFactura.Size = New System.Drawing.Size(113, 23)
        Me.LbNuFactura.TabIndex = 154
        Me.LbNuFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb17
        '
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = True
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.Teal
        Me.Lb17.Location = New System.Drawing.Point(526, 54)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(86, 16)
        Me.Lb17.TabIndex = 153
        Me.Lb17.Text = "Nº Factura"
        '
        'LbNomAcreedor
        '
        Me.LbNomAcreedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAcreedor.CL_ControlAsociado = Nothing
        Me.LbNomAcreedor.CL_ValorFijo = False
        Me.LbNomAcreedor.ClForm = Nothing
        Me.LbNomAcreedor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAcreedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAcreedor.Location = New System.Drawing.Point(208, 49)
        Me.LbNomAcreedor.Name = "LbNomAcreedor"
        Me.LbNomAcreedor.Size = New System.Drawing.Size(312, 23)
        Me.LbNomAcreedor.TabIndex = 152
        '
        'BtBuscaAcreedor
        '
        Me.BtBuscaAcreedor.CL_Ancho = 0
        Me.BtBuscaAcreedor.CL_BuscaAlb = False
        Me.BtBuscaAcreedor.CL_campocodigo = Nothing
        Me.BtBuscaAcreedor.CL_camponombre = Nothing
        Me.BtBuscaAcreedor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAcreedor.CL_ch1000 = False
        Me.BtBuscaAcreedor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAcreedor.CL_ControlAsociado = Me.TxDato11
        Me.BtBuscaAcreedor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAcreedor.CL_dfecha = Nothing
        Me.BtBuscaAcreedor.CL_Entidad = Nothing
        Me.BtBuscaAcreedor.CL_EsId = True
        Me.BtBuscaAcreedor.CL_Filtro = Nothing
        Me.BtBuscaAcreedor.cl_formu = Nothing
        Me.BtBuscaAcreedor.CL_hfecha = Nothing
        Me.BtBuscaAcreedor.cl_ListaW = Nothing
        Me.BtBuscaAcreedor.CL_xCentro = False
        Me.BtBuscaAcreedor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAcreedor.Location = New System.Drawing.Point(162, 48)
        Me.BtBuscaAcreedor.Name = "BtBuscaAcreedor"
        Me.BtBuscaAcreedor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAcreedor.TabIndex = 151
        Me.BtBuscaAcreedor.UseVisualStyleBackColor = True
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(103, 48)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(53, 22)
        Me.TxDato11.TabIndex = 149
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.TxDatoFinalSemana = Nothing
        Me.TxDato11.TxDatoInicioSemana = Nothing
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(16, 51)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(74, 16)
        Me.Lb7.TabIndex = 150
        Me.Lb7.Text = "Acreedor"
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = False
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(786, 22)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(46, 16)
        Me.Lb12.TabIndex = 146
        Me.Lb12.Text = "Valor"
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(865, 19)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(122, 22)
        Me.TxDato10.TabIndex = 145
        Me.TxDato10.TeclaRepetida = False
        Me.TxDato10.TxDatoFinalSemana = Nothing
        Me.TxDato10.TxDatoInicioSemana = Nothing
        Me.TxDato10.UltimoValorValidado = Nothing
        '
        'CbBox2
        '
        Me.CbBox2.Campobd = Nothing
        Me.CbBox2.ClForm = Nothing
        Me.CbBox2.DeshabilitarRuedaRaton = False
        Me.CbBox2.FormattingEnabled = True
        Me.CbBox2.GridLin = Nothing
        Me.CbBox2.Location = New System.Drawing.Point(613, 19)
        Me.CbBox2.MiEntidad = Nothing
        Me.CbBox2.MiError = False
        Me.CbBox2.Name = "CbBox2"
        Me.CbBox2.Orden = 0
        Me.CbBox2.SaltoAlfinal = False
        Me.CbBox2.Size = New System.Drawing.Size(140, 24)
        Me.CbBox2.TabIndex = 144
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(528, 23)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(38, 16)
        Me.Lb8.TabIndex = 143
        Me.Lb8.Text = "Tipo"
        '
        'Lb1
        '
        Me.Lb1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb1.Location = New System.Drawing.Point(208, 19)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(314, 23)
        Me.Lb1.TabIndex = 131
        '
        'BtBuscaGasto
        '
        Me.BtBuscaGasto.CL_Ancho = 0
        Me.BtBuscaGasto.CL_BuscaAlb = False
        Me.BtBuscaGasto.CL_campocodigo = Nothing
        Me.BtBuscaGasto.CL_camponombre = Nothing
        Me.BtBuscaGasto.CL_CampoOrden = "Nombre"
        Me.BtBuscaGasto.CL_ch1000 = False
        Me.BtBuscaGasto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGasto.CL_ControlAsociado = Me.TxDato22
        Me.BtBuscaGasto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGasto.CL_dfecha = Nothing
        Me.BtBuscaGasto.CL_Entidad = Nothing
        Me.BtBuscaGasto.CL_EsId = True
        Me.BtBuscaGasto.CL_Filtro = Nothing
        Me.BtBuscaGasto.cl_formu = Nothing
        Me.BtBuscaGasto.CL_hfecha = Nothing
        Me.BtBuscaGasto.cl_ListaW = Nothing
        Me.BtBuscaGasto.CL_xCentro = False
        Me.BtBuscaGasto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGasto.Location = New System.Drawing.Point(162, 19)
        Me.BtBuscaGasto.Name = "BtBuscaGasto"
        Me.BtBuscaGasto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGasto.TabIndex = 130
        Me.BtBuscaGasto.UseVisualStyleBackColor = True
        '
        'TxDato22
        '
        Me.TxDato22.Autonumerico = False
        Me.TxDato22.Buscando = False
        Me.TxDato22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato22.ClForm = Nothing
        Me.TxDato22.ClParam = Nothing
        Me.TxDato22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato22.GridLin = Nothing
        Me.TxDato22.HaCambiado = False
        Me.TxDato22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato22.lbbusca = Nothing
        Me.TxDato22.Location = New System.Drawing.Point(103, 19)
        Me.TxDato22.MiError = False
        Me.TxDato22.Name = "TxDato22"
        Me.TxDato22.Orden = 0
        Me.TxDato22.SaltoAlfinal = False
        Me.TxDato22.Siguiente = 0
        Me.TxDato22.Size = New System.Drawing.Size(53, 22)
        Me.TxDato22.TabIndex = 128
        Me.TxDato22.TeclaRepetida = False
        Me.TxDato22.TxDatoFinalSemana = Nothing
        Me.TxDato22.TxDatoInicioSemana = Nothing
        Me.TxDato22.UltimoValorValidado = Nothing
        '
        'Lb32
        '
        Me.Lb32.AutoSize = True
        Me.Lb32.CL_ControlAsociado = Nothing
        Me.Lb32.CL_ValorFijo = False
        Me.Lb32.ClForm = Nothing
        Me.Lb32.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb32.ForeColor = System.Drawing.Color.Teal
        Me.Lb32.Location = New System.Drawing.Point(16, 22)
        Me.Lb32.Name = "Lb32"
        Me.Lb32.Size = New System.Drawing.Size(50, 16)
        Me.Lb32.TabIndex = 129
        Me.Lb32.Text = "Gasto"
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = False
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(-215, 179)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(59, 16)
        Me.Lb23.TabIndex = 129
        Me.Lb23.Text = "Cultivo"
        '
        'ClGrid2
        '
        Me.ClGrid2.AñadirLinea = True
        Me.ClGrid2.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.GridEnterAutomatico = False
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.LineaBloqueada = False
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(3, 90)
        Me.ClGrid2.Margin = New System.Windows.Forms.Padding(4)
        Me.ClGrid2.MismaLinea = False
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.OcultarCeros = False
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(1064, 250)
        Me.ClGrid2.TabIndex = 120
        Me.ClGrid2.UltimoControl = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1085, 160)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxDato1)
        Me.GroupBox1.Controls.Add(Me.LbIgeneros)
        Me.GroupBox1.Controls.Add(Me.Lb24)
        Me.GroupBox1.Controls.Add(Me.LbPalets)
        Me.GroupBox1.Controls.Add(Me.Lb21)
        Me.GroupBox1.Controls.Add(Me.LbBultos)
        Me.GroupBox1.Controls.Add(Me.Lb16)
        Me.GroupBox1.Controls.Add(Me.LbKilos)
        Me.GroupBox1.Controls.Add(Me.Lb13)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAlbaran)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LbCliente)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Lb_1)
        Me.GroupBox1.Controls.Add(Me.TxDato_1)
        Me.GroupBox1.Controls.Add(Me.Lb_4)
        Me.GroupBox1.Controls.Add(Me.Lb_2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 135)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Albaran"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(205, 20)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(27, 22)
        Me.TxDato1.TabIndex = 200
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'LbIgeneros
        '
        Me.LbIgeneros.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbIgeneros.CL_ControlAsociado = Nothing
        Me.LbIgeneros.CL_ValorFijo = True
        Me.LbIgeneros.ClForm = Nothing
        Me.LbIgeneros.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIgeneros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIgeneros.Location = New System.Drawing.Point(667, 91)
        Me.LbIgeneros.Name = "LbIgeneros"
        Me.LbIgeneros.Size = New System.Drawing.Size(123, 23)
        Me.LbIgeneros.TabIndex = 199
        Me.LbIgeneros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb24
        '
        Me.Lb24.AutoSize = True
        Me.Lb24.CL_ControlAsociado = Nothing
        Me.Lb24.CL_ValorFijo = True
        Me.Lb24.ClForm = Nothing
        Me.Lb24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb24.ForeColor = System.Drawing.Color.Teal
        Me.Lb24.Location = New System.Drawing.Point(540, 94)
        Me.Lb24.Name = "Lb24"
        Me.Lb24.Size = New System.Drawing.Size(79, 16)
        Me.Lb24.TabIndex = 198
        Me.Lb24.Text = "I.Generos"
        '
        'LbPalets
        '
        Me.LbPalets.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPalets.CL_ControlAsociado = Nothing
        Me.LbPalets.CL_ValorFijo = True
        Me.LbPalets.ClForm = Nothing
        Me.LbPalets.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalets.Location = New System.Drawing.Point(455, 91)
        Me.LbPalets.Name = "LbPalets"
        Me.LbPalets.Size = New System.Drawing.Size(63, 23)
        Me.LbPalets.TabIndex = 197
        Me.LbPalets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb21
        '
        Me.Lb21.AutoSize = True
        Me.Lb21.CL_ControlAsociado = Nothing
        Me.Lb21.CL_ValorFijo = True
        Me.Lb21.ClForm = Nothing
        Me.Lb21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb21.ForeColor = System.Drawing.Color.Teal
        Me.Lb21.Location = New System.Drawing.Point(377, 94)
        Me.Lb21.Name = "Lb21"
        Me.Lb21.Size = New System.Drawing.Size(53, 16)
        Me.Lb21.TabIndex = 196
        Me.Lb21.Text = "Palets"
        '
        'LbBultos
        '
        Me.LbBultos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = True
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbBultos.Location = New System.Drawing.Point(284, 91)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(67, 23)
        Me.LbBultos.TabIndex = 195
        Me.LbBultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(206, 94)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(54, 16)
        Me.Lb16.TabIndex = 194
        Me.Lb16.Text = "Bultos"
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = True
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilos.Location = New System.Drawing.Point(95, 91)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(104, 23)
        Me.LbKilos.TabIndex = 193
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(9, 94)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(42, 16)
        Me.Lb13.TabIndex = 192
        Me.Lb13.Text = "Kilos"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = True
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(395, 16)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(131, 23)
        Me.LbFecha.TabIndex = 190
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_Ancho = 0
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_ControlAsociado = Nothing
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = CType(resources.GetObject("BtBuscaAlbaran.Image"), System.Drawing.Image)
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(238, 19)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 189
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbejer)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(815, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 43)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ejercicio"
        '
        'Lbejer
        '
        Me.Lbejer.BackColor = System.Drawing.Color.White
        Me.Lbejer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbejer.CL_ControlAsociado = Nothing
        Me.Lbejer.CL_ValorFijo = False
        Me.Lbejer.ClForm = Nothing
        Me.Lbejer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbejer.ForeColor = System.Drawing.Color.Teal
        Me.Lbejer.Location = New System.Drawing.Point(11, 14)
        Me.Lbejer.Name = "Lbejer"
        Me.Lbejer.Size = New System.Drawing.Size(36, 21)
        Me.Lbejer.TabIndex = 114
        Me.Lbejer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = True
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente.Location = New System.Drawing.Point(95, 53)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(431, 23)
        Me.LbCliente.TabIndex = 87
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbNomPv)
        Me.GroupBox3.Controls.Add(Me.LbPuntoVenta)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(901, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 43)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Punto de Venta"
        '
        'LbNomPv
        '
        Me.LbNomPv.BackColor = System.Drawing.Color.White
        Me.LbNomPv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNomPv.CL_ControlAsociado = Nothing
        Me.LbNomPv.CL_ValorFijo = False
        Me.LbNomPv.ClForm = Nothing
        Me.LbNomPv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomPv.ForeColor = System.Drawing.Color.Teal
        Me.LbNomPv.Location = New System.Drawing.Point(40, 14)
        Me.LbNomPv.Name = "LbNomPv"
        Me.LbNomPv.Size = New System.Drawing.Size(117, 21)
        Me.LbNomPv.TabIndex = 114
        Me.LbNomPv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.BackColor = System.Drawing.Color.White
        Me.LbPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbPuntoVenta.CL_ControlAsociado = Nothing
        Me.LbPuntoVenta.CL_ValorFijo = False
        Me.LbPuntoVenta.ClForm = Nothing
        Me.LbPuntoVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPuntoVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPuntoVenta.Location = New System.Drawing.Point(6, 14)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(28, 21)
        Me.LbPuntoVenta.TabIndex = 113
        Me.LbPuntoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(8, 23)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(64, 16)
        Me.Lb_1.TabIndex = 84
        Me.Lb_1.Text = "Albaran"
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(98, 20)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(101, 22)
        Me.TxDato_1.TabIndex = 83
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = True
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(9, 56)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(83, 16)
        Me.Lb_4.TabIndex = 80
        Me.Lb_4.Text = "Proveedor"
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = True
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(334, 19)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(52, 16)
        Me.Lb_2.TabIndex = 79
        Me.Lb_2.Text = "Fecha"
        '
        'LbGastosCom
        '
        Me.LbGastosCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbGastosCom.CL_ControlAsociado = Nothing
        Me.LbGastosCom.CL_ValorFijo = False
        Me.LbGastosCom.ClForm = Nothing
        Me.LbGastosCom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGastosCom.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbGastosCom.Location = New System.Drawing.Point(915, 519)
        Me.LbGastosCom.Name = "LbGastosCom"
        Me.LbGastosCom.Size = New System.Drawing.Size(109, 23)
        Me.LbGastosCom.TabIndex = 100358
        Me.LbGastosCom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(778, 526)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(117, 16)
        Me.Lb15.TabIndex = 100357
        Me.Lb15.Text = "G. Comerciales"
        '
        'FrmGasComerCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 585)
        Me.Controls.Add(Me.LbGastosCom)
        Me.Controls.Add(Me.Lb15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ImprimirDespuesDeGuardar = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGasComerCompra"
        Me.Text = "Gastos comerciales albaranes compra"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Lb15, 0)
        Me.Controls.SetChildIndex(Me.LbGastosCom, 0)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomAcreedor As NetAgro.Lb
    Friend WithEvents BtBuscaAcreedor As NetAgro.BtBusca
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents CbBox2 As NetAgro.CbBox
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents BtBuscaGasto As NetAgro.BtBusca
    Friend WithEvents TxDato22 As NetAgro.TxDato
    Friend WithEvents Lb32 As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents LbGastosCom As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents LbNuFactura As NetAgro.Lb
    Friend WithEvents Lb17 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbIgeneros As NetAgro.Lb
    Friend WithEvents Lb24 As NetAgro.Lb
    Friend WithEvents LbPalets As NetAgro.Lb
    Friend WithEvents Lb21 As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomPv As NetAgro.Lb
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato

End Class
