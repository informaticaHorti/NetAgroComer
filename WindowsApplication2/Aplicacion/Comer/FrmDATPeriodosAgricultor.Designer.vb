<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDATPeriodosAgricultor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDATPeriodosAgricultor))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxFechaFin = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb55 = New NetAgro.Lb(Me.components)
        Me.TxFechaInicio = New NetAgro.TxDato(Me.components)
        Me.LbNomGenero = New NetAgro.Lb(Me.components)
        Me.BtBuscaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxGenero = New NetAgro.TxDato(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbNIF = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultor = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(811, 331)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.TxFechaFin)
        Me.GroupBox7.Controls.Add(Me.Lb3)
        Me.GroupBox7.Controls.Add(Me.Lb55)
        Me.GroupBox7.Controls.Add(Me.TxFechaInicio)
        Me.GroupBox7.Controls.Add(Me.LbNomGenero)
        Me.GroupBox7.Controls.Add(Me.BtBuscaGenero)
        Me.GroupBox7.Controls.Add(Me.LbGenero)
        Me.GroupBox7.Controls.Add(Me.Lb23)
        Me.GroupBox7.Controls.Add(Me.TxGenero)
        Me.GroupBox7.Controls.Add(Me.ClGrid2)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(5, -1)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(796, 319)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'TxFechaFin
        '
        Me.TxFechaFin.Autonumerico = False
        Me.TxFechaFin.Bloqueado = False
        Me.TxFechaFin.Buscando = False
        Me.TxFechaFin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaFin.ClForm = Nothing
        Me.TxFechaFin.ClParam = Nothing
        Me.TxFechaFin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaFin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaFin.GridLin = Nothing
        Me.TxFechaFin.HaCambiado = False
        Me.TxFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaFin.lbbusca = Nothing
        Me.TxFechaFin.Location = New System.Drawing.Point(306, 48)
        Me.TxFechaFin.MiError = False
        Me.TxFechaFin.Name = "TxFechaFin"
        Me.TxFechaFin.Orden = 0
        Me.TxFechaFin.SaltoAlfinal = False
        Me.TxFechaFin.Siguiente = 0
        Me.TxFechaFin.Size = New System.Drawing.Size(90, 22)
        Me.TxFechaFin.TabIndex = 148
        Me.TxFechaFin.TeclaRepetida = False
        Me.TxFechaFin.TxDatoFinalSemana = Nothing
        Me.TxFechaFin.TxDatoInicioSemana = Nothing
        Me.TxFechaFin.UltimoValorValidado = Nothing
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(226, 51)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(74, 16)
        Me.Lb3.TabIndex = 147
        Me.Lb3.Text = "Fecha fin"
        '
        'Lb55
        '
        Me.Lb55.AutoSize = True
        Me.Lb55.CL_ControlAsociado = Nothing
        Me.Lb55.CL_ValorFijo = False
        Me.Lb55.ClForm = Nothing
        Me.Lb55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb55.ForeColor = System.Drawing.Color.Teal
        Me.Lb55.Location = New System.Drawing.Point(16, 51)
        Me.Lb55.Name = "Lb55"
        Me.Lb55.Size = New System.Drawing.Size(94, 16)
        Me.Lb55.TabIndex = 146
        Me.Lb55.Text = "Fecha inicio"
        '
        'TxFechaInicio
        '
        Me.TxFechaInicio.Autonumerico = False
        Me.TxFechaInicio.Bloqueado = False
        Me.TxFechaInicio.Buscando = False
        Me.TxFechaInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaInicio.ClForm = Nothing
        Me.TxFechaInicio.ClParam = Nothing
        Me.TxFechaInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaInicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaInicio.GridLin = Nothing
        Me.TxFechaInicio.HaCambiado = False
        Me.TxFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaInicio.lbbusca = Nothing
        Me.TxFechaInicio.Location = New System.Drawing.Point(123, 48)
        Me.TxFechaInicio.MiError = False
        Me.TxFechaInicio.Name = "TxFechaInicio"
        Me.TxFechaInicio.Orden = 0
        Me.TxFechaInicio.SaltoAlfinal = False
        Me.TxFechaInicio.Siguiente = 0
        Me.TxFechaInicio.Size = New System.Drawing.Size(90, 22)
        Me.TxFechaInicio.TabIndex = 145
        Me.TxFechaInicio.TeclaRepetida = False
        Me.TxFechaInicio.TxDatoFinalSemana = Nothing
        Me.TxFechaInicio.TxDatoInicioSemana = Nothing
        Me.TxFechaInicio.UltimoValorValidado = Nothing
        '
        'LbNomGenero
        '
        Me.LbNomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomGenero.CL_ControlAsociado = Nothing
        Me.LbNomGenero.CL_ValorFijo = False
        Me.LbNomGenero.ClForm = Nothing
        Me.LbNomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGenero.Location = New System.Drawing.Point(219, 19)
        Me.LbNomGenero.Name = "LbNomGenero"
        Me.LbNomGenero.Size = New System.Drawing.Size(381, 23)
        Me.LbNomGenero.TabIndex = 131
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
        Me.BtBuscaGenero.CL_ControlAsociado = Me.TxGenero
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
        Me.BtBuscaGenero.Location = New System.Drawing.Point(180, 19)
        Me.BtBuscaGenero.Name = "BtBuscaGenero"
        Me.BtBuscaGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGenero.TabIndex = 130
        Me.BtBuscaGenero.UseVisualStyleBackColor = True
        '
        'TxGenero
        '
        Me.TxGenero.Autonumerico = False
        Me.TxGenero.Bloqueado = False
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
        Me.TxGenero.Location = New System.Drawing.Point(123, 19)
        Me.TxGenero.MiError = False
        Me.TxGenero.Name = "TxGenero"
        Me.TxGenero.Orden = 0
        Me.TxGenero.SaltoAlfinal = False
        Me.TxGenero.Siguiente = 0
        Me.TxGenero.Size = New System.Drawing.Size(53, 22)
        Me.TxGenero.TabIndex = 128
        Me.TxGenero.TeclaRepetida = False
        Me.TxGenero.TxDatoFinalSemana = Nothing
        Me.TxGenero.TxDatoInicioSemana = Nothing
        Me.TxGenero.UltimoValorValidado = Nothing
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = False
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(16, 22)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(60, 16)
        Me.LbGenero.TabIndex = 129
        Me.LbGenero.Text = "Género"
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
        Me.ClGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClGrid2.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.GridEnterAutomatico = False
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.LineaBloqueada = False
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(3, 87)
        Me.ClGrid2.Margin = New System.Windows.Forms.Padding(4)
        Me.ClGrid2.MismaLinea = False
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.OcultarCeros = False
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(790, 232)
        Me.ClGrid2.TabIndex = 120
        Me.ClGrid2.UltimoControl = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.LbNIF)
        Me.Panel4.Controls.Add(Me.Lb2)
        Me.Panel4.Controls.Add(Me.LbNomAgricultor)
        Me.Panel4.Controls.Add(Me.BtBuscaAgricultor)
        Me.Panel4.Controls.Add(Me.BotonesAvance1)
        Me.Panel4.Controls.Add(Me.LbAgricultor)
        Me.Panel4.Controls.Add(Me.TxAgricultor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 87)
        Me.Panel4.TabIndex = 72
        '
        'LbNIF
        '
        Me.LbNIF.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNIF.CL_ControlAsociado = Nothing
        Me.LbNIF.CL_ValorFijo = False
        Me.LbNIF.ClForm = Nothing
        Me.LbNIF.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNIF.Location = New System.Drawing.Point(111, 46)
        Me.LbNIF.Name = "LbNIF"
        Me.LbNIF.Size = New System.Drawing.Size(145, 23)
        Me.LbNIF.TabIndex = 134
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(26, 49)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(33, 16)
        Me.Lb2.TabIndex = 133
        Me.Lb2.Text = "NIF"
        '
        'LbNomAgricultor
        '
        Me.LbNomAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomAgricultor.CL_ValorFijo = False
        Me.LbNomAgricultor.ClForm = Nothing
        Me.LbNomAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultor.Location = New System.Drawing.Point(214, 17)
        Me.LbNomAgricultor.Name = "LbNomAgricultor"
        Me.LbNomAgricultor.Size = New System.Drawing.Size(463, 23)
        Me.LbNomAgricultor.TabIndex = 132
        '
        'BtBuscaAgricultor
        '
        Me.BtBuscaAgricultor.CL_Ancho = 0
        Me.BtBuscaAgricultor.CL_BuscaAlb = False
        Me.BtBuscaAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaAgricultor.CL_camponombre = Nothing
        Me.BtBuscaAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultor.CL_ch1000 = False
        Me.BtBuscaAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultor.CL_ControlAsociado = Me.TxAgricultor
        Me.BtBuscaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaAgricultor.CL_EsId = True
        Me.BtBuscaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaAgricultor.cl_formu = Nothing
        Me.BtBuscaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaAgricultor.CL_xCentro = False
        Me.BtBuscaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(174, 17)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 32
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Bloqueado = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(111, 17)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(59, 22)
        Me.TxAgricultor.TabIndex = 30
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(683, 17)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 29
        Me.BotonesAvance1.Udato = Nothing
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(26, 20)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 31
        Me.LbAgricultor.Text = "Agricultor"
        '
        'prtSystem
        '
        Me.prtSystem.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'FrmDATPeriodosAgricultor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 452)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmDATPeriodosAgricultor"
        Me.Text = "Introducir DAT por periodos por Agricultor"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb55 As NetAgro.Lb
    Friend WithEvents TxFechaInicio As NetAgro.TxDato
    Friend WithEvents LbNomGenero As NetAgro.Lb
    Friend WithEvents BtBuscaGenero As NetAgro.BtBusca
    Friend WithEvents TxGenero As NetAgro.TxDato
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents LbNomAgricultor As NetAgro.Lb
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents LbNIF As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxFechaFin As NetAgro.TxDato

End Class
