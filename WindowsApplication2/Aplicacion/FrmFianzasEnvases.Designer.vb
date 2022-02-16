<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFianzasEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFianzasEnvases))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbnomDestino = New NetAgro.Lb(Me.components)
        Me.BtBuscaDestino = New NetAgro.BtBusca(Me.components)
        Me.TxDomicilio = New NetAgro.TxDato(Me.components)
        Me.LbDescarga = New NetAgro.Lb(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.TxTipo = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbSubfamilia = New NetAgro.Lb(Me.components)
        Me.TxSubfamilia = New NetAgro.TxDato(Me.components)
        Me.LbNomSubfamilia = New NetAgro.Lb(Me.components)
        Me.BtSubfamilia = New NetAgro.BtBusca(Me.components)
        Me.LbNomCliente = New NetAgro.Lb(Me.components)
        Me.BtCliente = New NetAgro.BtBusca(Me.components)
        Me.TxCliente = New NetAgro.TxDato(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.LbNomCliente)
        Me.Panel4.Controls.Add(Me.BtCliente)
        Me.Panel4.Controls.Add(Me.LbCliente)
        Me.Panel4.Controls.Add(Me.TxCliente)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(876, 462)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Lb5)
        Me.GroupBox1.Controls.Add(Me.Lb4)
        Me.GroupBox1.Controls.Add(Me.Lb3)
        Me.GroupBox1.Controls.Add(Me.Lb2)
        Me.GroupBox1.Controls.Add(Me.Lb1)
        Me.GroupBox1.Controls.Add(Me.LbnomDestino)
        Me.GroupBox1.Controls.Add(Me.BtBuscaDestino)
        Me.GroupBox1.Controls.Add(Me.TxDomicilio)
        Me.GroupBox1.Controls.Add(Me.LbDescarga)
        Me.GroupBox1.Controls.Add(Me.LbTipo)
        Me.GroupBox1.Controls.Add(Me.TxTipo)
        Me.GroupBox1.Controls.Add(Me.ClGrid1)
        Me.GroupBox1.Controls.Add(Me.LbSubfamilia)
        Me.GroupBox1.Controls.Add(Me.TxSubfamilia)
        Me.GroupBox1.Controls.Add(Me.LbNomSubfamilia)
        Me.GroupBox1.Controls.Add(Me.BtSubfamilia)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 399)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(625, 79)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(106, 13)
        Me.Lb3.TabIndex = 211
        Me.Lb3.Text = "C = No facturar"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(625, 65)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(213, 13)
        Me.Lb2.TabIndex = 210
        Me.Lb2.Text = "B = Facturar aparte del albarán"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(625, 51)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(163, 13)
        Me.Lb1.TabIndex = 209
        Me.Lb1.Text = "A = Facturar en albarán"
        '
        'LbnomDestino
        '
        Me.LbnomDestino.BackColor = System.Drawing.Color.Gainsboro
        Me.LbnomDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbnomDestino.CL_ControlAsociado = Nothing
        Me.LbnomDestino.CL_ValorFijo = False
        Me.LbnomDestino.ClForm = Nothing
        Me.LbnomDestino.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomDestino.Location = New System.Drawing.Point(199, 19)
        Me.LbnomDestino.Name = "LbnomDestino"
        Me.LbnomDestino.Size = New System.Drawing.Size(518, 23)
        Me.LbnomDestino.TabIndex = 208
        '
        'BtBuscaDestino
        '
        Me.BtBuscaDestino.CL_Ancho = 0
        Me.BtBuscaDestino.CL_BuscaAlb = False
        Me.BtBuscaDestino.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaDestino.CL_campocodigo = Nothing
        Me.BtBuscaDestino.CL_camponombre = Nothing
        Me.BtBuscaDestino.CL_CampoOrden = "Nombre"
        Me.BtBuscaDestino.CL_ch1000 = False
        Me.BtBuscaDestino.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDestino.CL_ControlAsociado = Nothing
        Me.BtBuscaDestino.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDestino.CL_dfecha = Nothing
        Me.BtBuscaDestino.CL_Entidad = Nothing
        Me.BtBuscaDestino.CL_EsId = True
        Me.BtBuscaDestino.CL_Filtro = Nothing
        Me.BtBuscaDestino.cl_formu = Nothing
        Me.BtBuscaDestino.CL_hfecha = Nothing
        Me.BtBuscaDestino.cl_ListaW = Nothing
        Me.BtBuscaDestino.CL_xCentro = False
        Me.BtBuscaDestino.Image = CType(resources.GetObject("BtBuscaDestino.Image"), System.Drawing.Image)
        Me.BtBuscaDestino.Location = New System.Drawing.Point(163, 19)
        Me.BtBuscaDestino.Name = "BtBuscaDestino"
        Me.BtBuscaDestino.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDestino.TabIndex = 207
        Me.BtBuscaDestino.UseVisualStyleBackColor = True
        '
        'TxDomicilio
        '
        Me.TxDomicilio.Autonumerico = False
        Me.TxDomicilio.Bloqueado = False
        Me.TxDomicilio.Buscando = False
        Me.TxDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDomicilio.ClForm = Nothing
        Me.TxDomicilio.ClParam = Nothing
        Me.TxDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDomicilio.GridLin = Nothing
        Me.TxDomicilio.HaCambiado = False
        Me.TxDomicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDomicilio.lbbusca = Nothing
        Me.TxDomicilio.Location = New System.Drawing.Point(104, 19)
        Me.TxDomicilio.MiError = False
        Me.TxDomicilio.Name = "TxDomicilio"
        Me.TxDomicilio.Orden = 0
        Me.TxDomicilio.SaltoAlfinal = False
        Me.TxDomicilio.Siguiente = 0
        Me.TxDomicilio.Size = New System.Drawing.Size(53, 22)
        Me.TxDomicilio.TabIndex = 206
        Me.TxDomicilio.TeclaRepetida = False
        Me.TxDomicilio.TxDatoFinalSemana = Nothing
        Me.TxDomicilio.TxDatoInicioSemana = Nothing
        Me.TxDomicilio.UltimoValorValidado = Nothing
        '
        'LbDescarga
        '
        Me.LbDescarga.AutoSize = True
        Me.LbDescarga.CL_ControlAsociado = Nothing
        Me.LbDescarga.CL_ValorFijo = False
        Me.LbDescarga.ClForm = Nothing
        Me.LbDescarga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescarga.ForeColor = System.Drawing.Color.Teal
        Me.LbDescarga.Location = New System.Drawing.Point(7, 22)
        Me.LbDescarga.Name = "LbDescarga"
        Me.LbDescarga.Size = New System.Drawing.Size(74, 16)
        Me.LbDescarga.TabIndex = 205
        Me.LbDescarga.Text = "Domicilio"
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = False
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.Teal
        Me.LbTipo.Location = New System.Drawing.Point(480, 52)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(104, 16)
        Me.LbTipo.TabIndex = 204
        Me.LbTipo.Text = "Tipo (A/B/C)"
        '
        'TxTipo
        '
        Me.TxTipo.Autonumerico = False
        Me.TxTipo.Bloqueado = False
        Me.TxTipo.Buscando = False
        Me.TxTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipo.ClForm = Nothing
        Me.TxTipo.ClParam = Nothing
        Me.TxTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTipo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipo.GridLin = Nothing
        Me.TxTipo.HaCambiado = False
        Me.TxTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTipo.lbbusca = Nothing
        Me.TxTipo.Location = New System.Drawing.Point(596, 49)
        Me.TxTipo.MiError = False
        Me.TxTipo.Name = "TxTipo"
        Me.TxTipo.Orden = 0
        Me.TxTipo.SaltoAlfinal = False
        Me.TxTipo.Siguiente = 0
        Me.TxTipo.Size = New System.Drawing.Size(24, 22)
        Me.TxTipo.TabIndex = 203
        Me.TxTipo.TeclaRepetida = False
        Me.TxTipo.TxDatoFinalSemana = Nothing
        Me.TxTipo.TxDatoInicioSemana = Nothing
        Me.TxTipo.UltimoValorValidado = Nothing
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(3, 130)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(846, 266)
        Me.ClGrid1.TabIndex = 198
        Me.ClGrid1.UltimoControl = 0
        '
        'LbSubfamilia
        '
        Me.LbSubfamilia.AutoSize = True
        Me.LbSubfamilia.CL_ControlAsociado = Nothing
        Me.LbSubfamilia.CL_ValorFijo = False
        Me.LbSubfamilia.ClForm = Nothing
        Me.LbSubfamilia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubfamilia.ForeColor = System.Drawing.Color.Teal
        Me.LbSubfamilia.Location = New System.Drawing.Point(6, 52)
        Me.LbSubfamilia.Name = "LbSubfamilia"
        Me.LbSubfamilia.Size = New System.Drawing.Size(84, 16)
        Me.LbSubfamilia.TabIndex = 72
        Me.LbSubfamilia.Text = "Subfamilia"
        '
        'TxSubfamilia
        '
        Me.TxSubfamilia.Autonumerico = False
        Me.TxSubfamilia.Bloqueado = False
        Me.TxSubfamilia.Buscando = False
        Me.TxSubfamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSubfamilia.ClForm = Nothing
        Me.TxSubfamilia.ClParam = Nothing
        Me.TxSubfamilia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSubfamilia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSubfamilia.GridLin = Nothing
        Me.TxSubfamilia.HaCambiado = False
        Me.TxSubfamilia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSubfamilia.lbbusca = Nothing
        Me.TxSubfamilia.Location = New System.Drawing.Point(95, 49)
        Me.TxSubfamilia.MiError = False
        Me.TxSubfamilia.Name = "TxSubfamilia"
        Me.TxSubfamilia.Orden = 0
        Me.TxSubfamilia.SaltoAlfinal = False
        Me.TxSubfamilia.Siguiente = 0
        Me.TxSubfamilia.Size = New System.Drawing.Size(62, 22)
        Me.TxSubfamilia.TabIndex = 71
        Me.TxSubfamilia.TeclaRepetida = False
        Me.TxSubfamilia.TxDatoFinalSemana = Nothing
        Me.TxSubfamilia.TxDatoInicioSemana = Nothing
        Me.TxSubfamilia.UltimoValorValidado = Nothing
        '
        'LbNomSubfamilia
        '
        Me.LbNomSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomSubfamilia.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNomSubfamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomSubfamilia.CL_ControlAsociado = Nothing
        Me.LbNomSubfamilia.CL_ValorFijo = False
        Me.LbNomSubfamilia.ClForm = Nothing
        Me.LbNomSubfamilia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomSubfamilia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomSubfamilia.Location = New System.Drawing.Point(202, 49)
        Me.LbNomSubfamilia.Name = "LbNomSubfamilia"
        Me.LbNomSubfamilia.Size = New System.Drawing.Size(252, 23)
        Me.LbNomSubfamilia.TabIndex = 74
        '
        'BtSubfamilia
        '
        Me.BtSubfamilia.CL_Ancho = 0
        Me.BtSubfamilia.CL_BuscaAlb = False
        Me.BtSubfamilia.CL_BuscarEnTodosLosCampos = False
        Me.BtSubfamilia.CL_campocodigo = Nothing
        Me.BtSubfamilia.CL_camponombre = Nothing
        Me.BtSubfamilia.CL_CampoOrden = "Nombre"
        Me.BtSubfamilia.CL_ch1000 = False
        Me.BtSubfamilia.CL_ConsultaSql = "Select * from familias"
        Me.BtSubfamilia.CL_ControlAsociado = Me.TxSubfamilia
        Me.BtSubfamilia.CL_DevuelveCampo = "Idfamilia"
        Me.BtSubfamilia.CL_dfecha = Nothing
        Me.BtSubfamilia.CL_Entidad = Nothing
        Me.BtSubfamilia.CL_EsId = True
        Me.BtSubfamilia.CL_Filtro = Nothing
        Me.BtSubfamilia.cl_formu = Nothing
        Me.BtSubfamilia.CL_hfecha = Nothing
        Me.BtSubfamilia.cl_ListaW = Nothing
        Me.BtSubfamilia.CL_xCentro = False
        Me.BtSubfamilia.Image = CType(resources.GetObject("BtSubfamilia.Image"), System.Drawing.Image)
        Me.BtSubfamilia.Location = New System.Drawing.Point(163, 49)
        Me.BtSubfamilia.Name = "BtSubfamilia"
        Me.BtSubfamilia.Size = New System.Drawing.Size(33, 23)
        Me.BtSubfamilia.TabIndex = 73
        Me.BtSubfamilia.UseVisualStyleBackColor = True
        '
        'LbNomCliente
        '
        Me.LbNomCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCliente.CL_ControlAsociado = Nothing
        Me.LbNomCliente.CL_ValorFijo = False
        Me.LbNomCliente.ClForm = Nothing
        Me.LbNomCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCliente.Location = New System.Drawing.Point(191, 16)
        Me.LbNomCliente.Name = "LbNomCliente"
        Me.LbNomCliente.Size = New System.Drawing.Size(610, 23)
        Me.LbNomCliente.TabIndex = 198
        '
        'BtCliente
        '
        Me.BtCliente.CL_Ancho = 0
        Me.BtCliente.CL_BuscaAlb = False
        Me.BtCliente.CL_BuscarEnTodosLosCampos = False
        Me.BtCliente.CL_campocodigo = Nothing
        Me.BtCliente.CL_camponombre = Nothing
        Me.BtCliente.CL_CampoOrden = "Nombre"
        Me.BtCliente.CL_ch1000 = False
        Me.BtCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtCliente.CL_ControlAsociado = Me.TxCliente
        Me.BtCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtCliente.CL_dfecha = Nothing
        Me.BtCliente.CL_Entidad = Nothing
        Me.BtCliente.CL_EsId = True
        Me.BtCliente.CL_Filtro = Nothing
        Me.BtCliente.cl_formu = Nothing
        Me.BtCliente.CL_hfecha = Nothing
        Me.BtCliente.cl_ListaW = Nothing
        Me.BtCliente.CL_xCentro = False
        Me.BtCliente.Image = CType(resources.GetObject("BtCliente.Image"), System.Drawing.Image)
        Me.BtCliente.Location = New System.Drawing.Point(155, 16)
        Me.BtCliente.Name = "BtCliente"
        Me.BtCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtCliente.TabIndex = 70
        Me.BtCliente.UseVisualStyleBackColor = True
        '
        'TxCliente
        '
        Me.TxCliente.Autonumerico = False
        Me.TxCliente.Bloqueado = False
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
        Me.TxCliente.Location = New System.Drawing.Point(87, 16)
        Me.TxCliente.MiError = False
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.Orden = 0
        Me.TxCliente.SaltoAlfinal = False
        Me.TxCliente.Siguiente = 0
        Me.TxCliente.Size = New System.Drawing.Size(62, 22)
        Me.TxCliente.TabIndex = 65
        Me.TxCliente.TeclaRepetida = False
        Me.TxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxCliente.TxDatoFinalSemana = Nothing
        Me.TxCliente.TxDatoInicioSemana = Nothing
        Me.TxCliente.UltimoValorValidado = Nothing
        '
        'LbCliente
        '
        Me.LbCliente.AutoSize = True
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = False
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbCliente.Location = New System.Drawing.Point(21, 19)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(59, 16)
        Me.LbCliente.TabIndex = 66
        Me.LbCliente.Text = "Cliente"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(625, 92)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(230, 13)
        Me.Lb4.TabIndex = 212
        Me.Lb4.Text = "D = En depósito Empresas Locales"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(625, 105)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(159, 13)
        Me.Lb5.TabIndex = 213
        Me.Lb5.Text = "E = Facturar y declarar"
        '
        'FrmFianzasEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 496)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmFianzasEnvases"
        Me.Text = "Fianzas Envases"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbNomSubfamilia As NetAgro.Lb
    Friend WithEvents BtSubfamilia As NetAgro.BtBusca
    Friend WithEvents TxSubfamilia As NetAgro.TxDato
    Friend WithEvents LbSubfamilia As NetAgro.Lb
    Friend WithEvents BtCliente As NetAgro.BtBusca
    Friend WithEvents TxCliente As NetAgro.TxDato
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents LbNomCliente As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents TxTipo As NetAgro.TxDato
    Friend WithEvents LbnomDestino As NetAgro.Lb
    Friend WithEvents BtBuscaDestino As NetAgro.BtBusca
    Friend WithEvents TxDomicilio As NetAgro.TxDato
    Friend WithEvents LbDescarga As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb5 As Lb
    Friend WithEvents Lb4 As Lb
End Class
