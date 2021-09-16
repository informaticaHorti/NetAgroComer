<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotesPartida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLotesPartida))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbControladoSN = New NetAgro.Lb(Me.components)
        Me.LbProgramaCalidad = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbColor = New NetAgro.Lb(Me.components)
        Me.TxColor = New NetAgro.TxDato(Me.components)
        Me.LbControlado = New NetAgro.Lb(Me.components)
        Me.LbNomEnvase = New NetAgro.Lb(Me.components)
        Me.BtBuscaEnvase = New NetAgro.BtBusca(Me.components)
        Me.TxEnvase = New NetAgro.TxDato(Me.components)
        Me.LbEnvase = New NetAgro.Lb(Me.components)
        Me.LbCalidad = New NetAgro.Lb(Me.components)
        Me.TxCalidad = New NetAgro.TxDato(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.LbFechaLote = New NetAgro.Lb(Me.components)
        Me.TxFechaLote = New NetAgro.TxDato(Me.components)
        Me.BtNuevo = New NetAgro.ClButton()
        Me.LbNomProductoLote = New NetAgro.Lb(Me.components)
        Me.BtBuscaProducto = New NetAgro.BtBusca(Me.components)
        Me.TxProducto = New NetAgro.TxDato(Me.components)
        Me.LbProductoLote = New NetAgro.Lb(Me.components)
        Me.BtBuscaLote = New NetAgro.BtBusca(Me.components)
        Me.TxNumero = New NetAgro.TxDato(Me.components)
        Me.LbNumero = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxCampaPartida = New NetAgro.TxDato(Me.components)
        Me.ListaNormas = New System.Windows.Forms.ListBox()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbKxB = New NetAgro.Lb(Me.components)
        Me.LbKilosxBulto = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbKilosEntrada = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbBultosEntrada = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbProducto = New NetAgro.Lb(Me.components)
        Me.TxBultos = New NetAgro.TxDato(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.TxKilos = New NetAgro.TxDato(Me.components)
        Me.TxPartida = New NetAgro.TxDato(Me.components)
        Me.LbPartida = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Controls.Add(Me.LbControladoSN)
        Me.Panel4.Controls.Add(Me.LbProgramaCalidad)
        Me.Panel4.Controls.Add(Me.Lb8)
        Me.Panel4.Controls.Add(Me.Lb4)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.LbColor)
        Me.Panel4.Controls.Add(Me.TxColor)
        Me.Panel4.Controls.Add(Me.LbControlado)
        Me.Panel4.Controls.Add(Me.LbNomEnvase)
        Me.Panel4.Controls.Add(Me.BtBuscaEnvase)
        Me.Panel4.Controls.Add(Me.LbEnvase)
        Me.Panel4.Controls.Add(Me.TxEnvase)
        Me.Panel4.Controls.Add(Me.LbCalidad)
        Me.Panel4.Controls.Add(Me.TxCalidad)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.LbFechaLote)
        Me.Panel4.Controls.Add(Me.TxFechaLote)
        Me.Panel4.Controls.Add(Me.BtNuevo)
        Me.Panel4.Controls.Add(Me.LbNomProductoLote)
        Me.Panel4.Controls.Add(Me.BtBuscaProducto)
        Me.Panel4.Controls.Add(Me.LbProductoLote)
        Me.Panel4.Controls.Add(Me.TxProducto)
        Me.Panel4.Controls.Add(Me.BtBuscaLote)
        Me.Panel4.Controls.Add(Me.LbNumero)
        Me.Panel4.Controls.Add(Me.TxNumero)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 125)
        Me.Panel4.TabIndex = 72
        '
        'LbControladoSN
        '
        Me.LbControladoSN.BackColor = System.Drawing.Color.White
        Me.LbControladoSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbControladoSN.CL_ControlAsociado = Nothing
        Me.LbControladoSN.CL_ValorFijo = True
        Me.LbControladoSN.ClForm = Nothing
        Me.LbControladoSN.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LbControladoSN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbControladoSN.Location = New System.Drawing.Point(859, 10)
        Me.LbControladoSN.Name = "LbControladoSN"
        Me.LbControladoSN.Size = New System.Drawing.Size(27, 22)
        Me.LbControladoSN.TabIndex = 211
        Me.LbControladoSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbProgramaCalidad
        '
        Me.LbProgramaCalidad.BackColor = System.Drawing.Color.LightGray
        Me.LbProgramaCalidad.CL_ControlAsociado = Nothing
        Me.LbProgramaCalidad.CL_ValorFijo = True
        Me.LbProgramaCalidad.ClForm = Nothing
        Me.LbProgramaCalidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProgramaCalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbProgramaCalidad.Location = New System.Drawing.Point(207, 91)
        Me.LbProgramaCalidad.Name = "LbProgramaCalidad"
        Me.LbProgramaCalidad.Size = New System.Drawing.Size(401, 19)
        Me.LbProgramaCalidad.TabIndex = 210
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(12, 92)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(157, 16)
        Me.Lb8.TabIndex = 209
        Me.Lb8.Text = "Programa de calidad"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(717, 50)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(112, 13)
        Me.Lb4.TabIndex = 208
        Me.Lb4.Text = "S=Sobremaduro"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(717, 38)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(142, 13)
        Me.Lb1.TabIndex = 207
        Me.Lb1.Text = "N=Normal, P=Pintón,"
        '
        'LbColor
        '
        Me.LbColor.AutoSize = True
        Me.LbColor.CL_ControlAsociado = Nothing
        Me.LbColor.CL_ValorFijo = False
        Me.LbColor.ClForm = Nothing
        Me.LbColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbColor.ForeColor = System.Drawing.Color.Teal
        Me.LbColor.Location = New System.Drawing.Point(616, 42)
        Me.LbColor.Name = "LbColor"
        Me.LbColor.Size = New System.Drawing.Size(46, 16)
        Me.LbColor.TabIndex = 206
        Me.LbColor.Text = "Color"
        '
        'TxColor
        '
        Me.TxColor.Autonumerico = False
        Me.TxColor.Buscando = False
        Me.TxColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxColor.ClForm = Nothing
        Me.TxColor.ClParam = Nothing
        Me.TxColor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxColor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxColor.GridLin = Nothing
        Me.TxColor.HaCambiado = False
        Me.TxColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxColor.lbbusca = Nothing
        Me.TxColor.Location = New System.Drawing.Point(684, 39)
        Me.TxColor.MiError = False
        Me.TxColor.Name = "TxColor"
        Me.TxColor.Orden = 0
        Me.TxColor.SaltoAlfinal = False
        Me.TxColor.Siguiente = 0
        Me.TxColor.Size = New System.Drawing.Size(27, 22)
        Me.TxColor.TabIndex = 205
        Me.TxColor.TeclaRepetida = False
        Me.TxColor.TxDatoFinalSemana = Nothing
        Me.TxColor.TxDatoInicioSemana = Nothing
        Me.TxColor.UltimoValorValidado = Nothing
        '
        'LbControlado
        '
        Me.LbControlado.AutoSize = True
        Me.LbControlado.CL_ControlAsociado = Nothing
        Me.LbControlado.CL_ValorFijo = True
        Me.LbControlado.ClForm = Nothing
        Me.LbControlado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbControlado.ForeColor = System.Drawing.Color.Teal
        Me.LbControlado.Location = New System.Drawing.Point(765, 13)
        Me.LbControlado.Name = "LbControlado"
        Me.LbControlado.Size = New System.Drawing.Size(88, 16)
        Me.LbControlado.TabIndex = 204
        Me.LbControlado.Text = "Controlado"
        '
        'LbNomEnvase
        '
        Me.LbNomEnvase.BackColor = System.Drawing.Color.LightGray
        Me.LbNomEnvase.CL_ControlAsociado = Nothing
        Me.LbNomEnvase.CL_ValorFijo = False
        Me.LbNomEnvase.ClForm = Nothing
        Me.LbNomEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomEnvase.Location = New System.Drawing.Point(207, 66)
        Me.LbNomEnvase.Name = "LbNomEnvase"
        Me.LbNomEnvase.Size = New System.Drawing.Size(401, 19)
        Me.LbNomEnvase.TabIndex = 192
        '
        'BtBuscaEnvase
        '
        Me.BtBuscaEnvase.CL_Ancho = 0
        Me.BtBuscaEnvase.CL_BuscaAlb = False
        Me.BtBuscaEnvase.CL_campocodigo = Nothing
        Me.BtBuscaEnvase.CL_camponombre = Nothing
        Me.BtBuscaEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaEnvase.CL_ch1000 = False
        Me.BtBuscaEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaEnvase.CL_ControlAsociado = Me.TxEnvase
        Me.BtBuscaEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaEnvase.CL_dfecha = Nothing
        Me.BtBuscaEnvase.CL_Entidad = Nothing
        Me.BtBuscaEnvase.CL_EsId = True
        Me.BtBuscaEnvase.CL_Filtro = Nothing
        Me.BtBuscaEnvase.cl_formu = Nothing
        Me.BtBuscaEnvase.CL_hfecha = Nothing
        Me.BtBuscaEnvase.cl_ListaW = Nothing
        Me.BtBuscaEnvase.CL_xCentro = False
        Me.BtBuscaEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaEnvase.Location = New System.Drawing.Point(168, 64)
        Me.BtBuscaEnvase.Name = "BtBuscaEnvase"
        Me.BtBuscaEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaEnvase.TabIndex = 191
        Me.BtBuscaEnvase.UseVisualStyleBackColor = True
        '
        'TxEnvase
        '
        Me.TxEnvase.Autonumerico = False
        Me.TxEnvase.Buscando = False
        Me.TxEnvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEnvase.ClForm = Nothing
        Me.TxEnvase.ClParam = Nothing
        Me.TxEnvase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEnvase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEnvase.GridLin = Nothing
        Me.TxEnvase.HaCambiado = False
        Me.TxEnvase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEnvase.lbbusca = Nothing
        Me.TxEnvase.Location = New System.Drawing.Point(87, 64)
        Me.TxEnvase.MiError = False
        Me.TxEnvase.Name = "TxEnvase"
        Me.TxEnvase.Orden = 0
        Me.TxEnvase.SaltoAlfinal = False
        Me.TxEnvase.Siguiente = 0
        Me.TxEnvase.Size = New System.Drawing.Size(75, 22)
        Me.TxEnvase.TabIndex = 189
        Me.TxEnvase.TeclaRepetida = False
        Me.TxEnvase.TxDatoFinalSemana = Nothing
        Me.TxEnvase.TxDatoInicioSemana = Nothing
        Me.TxEnvase.UltimoValorValidado = Nothing
        '
        'LbEnvase
        '
        Me.LbEnvase.AutoSize = True
        Me.LbEnvase.CL_ControlAsociado = Nothing
        Me.LbEnvase.CL_ValorFijo = False
        Me.LbEnvase.ClForm = Nothing
        Me.LbEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEnvase.ForeColor = System.Drawing.Color.Teal
        Me.LbEnvase.Location = New System.Drawing.Point(12, 67)
        Me.LbEnvase.Name = "LbEnvase"
        Me.LbEnvase.Size = New System.Drawing.Size(61, 16)
        Me.LbEnvase.TabIndex = 190
        Me.LbEnvase.Text = "Envase"
        '
        'LbCalidad
        '
        Me.LbCalidad.AutoSize = True
        Me.LbCalidad.CL_ControlAsociado = Nothing
        Me.LbCalidad.CL_ValorFijo = False
        Me.LbCalidad.ClForm = Nothing
        Me.LbCalidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCalidad.ForeColor = System.Drawing.Color.Teal
        Me.LbCalidad.Location = New System.Drawing.Point(616, 13)
        Me.LbCalidad.Name = "LbCalidad"
        Me.LbCalidad.Size = New System.Drawing.Size(62, 16)
        Me.LbCalidad.TabIndex = 188
        Me.LbCalidad.Text = "Calidad"
        '
        'TxCalidad
        '
        Me.TxCalidad.Autonumerico = False
        Me.TxCalidad.Buscando = False
        Me.TxCalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCalidad.ClForm = Nothing
        Me.TxCalidad.ClParam = Nothing
        Me.TxCalidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCalidad.GridLin = Nothing
        Me.TxCalidad.HaCambiado = False
        Me.TxCalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCalidad.lbbusca = Nothing
        Me.TxCalidad.Location = New System.Drawing.Point(684, 10)
        Me.TxCalidad.MiError = False
        Me.TxCalidad.Name = "TxCalidad"
        Me.TxCalidad.Orden = 0
        Me.TxCalidad.SaltoAlfinal = False
        Me.TxCalidad.Siguiente = 0
        Me.TxCalidad.Size = New System.Drawing.Size(53, 22)
        Me.TxCalidad.TabIndex = 187
        Me.TxCalidad.TeclaRepetida = False
        Me.TxCalidad.TxDatoFinalSemana = Nothing
        Me.TxCalidad.TxDatoInicioSemana = Nothing
        Me.TxCalidad.UltimoValorValidado = Nothing
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.White
        Me.LbCampa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = False
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.Teal
        Me.LbCampa.Location = New System.Drawing.Point(87, 11)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        '
        'LbFechaLote
        '
        Me.LbFechaLote.AutoSize = True
        Me.LbFechaLote.CL_ControlAsociado = Nothing
        Me.LbFechaLote.CL_ValorFijo = False
        Me.LbFechaLote.ClForm = Nothing
        Me.LbFechaLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaLote.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaLote.Location = New System.Drawing.Point(354, 13)
        Me.LbFechaLote.Name = "LbFechaLote"
        Me.LbFechaLote.Size = New System.Drawing.Size(52, 16)
        Me.LbFechaLote.TabIndex = 77
        Me.LbFechaLote.Text = "Fecha"
        '
        'TxFechaLote
        '
        Me.TxFechaLote.Autonumerico = False
        Me.TxFechaLote.Buscando = False
        Me.TxFechaLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaLote.ClForm = Nothing
        Me.TxFechaLote.ClParam = Nothing
        Me.TxFechaLote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaLote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaLote.GridLin = Nothing
        Me.TxFechaLote.HaCambiado = False
        Me.TxFechaLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaLote.lbbusca = Nothing
        Me.TxFechaLote.Location = New System.Drawing.Point(412, 10)
        Me.TxFechaLote.MiError = False
        Me.TxFechaLote.Name = "TxFechaLote"
        Me.TxFechaLote.Orden = 0
        Me.TxFechaLote.SaltoAlfinal = False
        Me.TxFechaLote.Siguiente = 0
        Me.TxFechaLote.Size = New System.Drawing.Size(93, 22)
        Me.TxFechaLote.TabIndex = 76
        Me.TxFechaLote.TeclaRepetida = False
        Me.TxFechaLote.TxDatoFinalSemana = Nothing
        Me.TxFechaLote.TxDatoInicioSemana = Nothing
        Me.TxFechaLote.UltimoValorValidado = Nothing
        '
        'BtNuevo
        '
        Me.BtNuevo.Image = CType(resources.GetObject("BtNuevo.Image"), System.Drawing.Image)
        Me.BtNuevo.Location = New System.Drawing.Point(242, 10)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Orden = 0
        Me.BtNuevo.PedirClave = True
        Me.BtNuevo.Size = New System.Drawing.Size(26, 23)
        Me.BtNuevo.TabIndex = 75
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'LbNomProductoLote
        '
        Me.LbNomProductoLote.BackColor = System.Drawing.Color.LightGray
        Me.LbNomProductoLote.CL_ControlAsociado = Nothing
        Me.LbNomProductoLote.CL_ValorFijo = False
        Me.LbNomProductoLote.ClForm = Nothing
        Me.LbNomProductoLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomProductoLote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomProductoLote.Location = New System.Drawing.Point(207, 41)
        Me.LbNomProductoLote.Name = "LbNomProductoLote"
        Me.LbNomProductoLote.Size = New System.Drawing.Size(401, 19)
        Me.LbNomProductoLote.TabIndex = 74
        '
        'BtBuscaProducto
        '
        Me.BtBuscaProducto.CL_Ancho = 0
        Me.BtBuscaProducto.CL_BuscaAlb = False
        Me.BtBuscaProducto.CL_campocodigo = Nothing
        Me.BtBuscaProducto.CL_camponombre = Nothing
        Me.BtBuscaProducto.CL_CampoOrden = "Nombre"
        Me.BtBuscaProducto.CL_ch1000 = False
        Me.BtBuscaProducto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaProducto.CL_ControlAsociado = Me.TxProducto
        Me.BtBuscaProducto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaProducto.CL_dfecha = Nothing
        Me.BtBuscaProducto.CL_Entidad = Nothing
        Me.BtBuscaProducto.CL_EsId = True
        Me.BtBuscaProducto.CL_Filtro = Nothing
        Me.BtBuscaProducto.cl_formu = Nothing
        Me.BtBuscaProducto.CL_hfecha = Nothing
        Me.BtBuscaProducto.cl_ListaW = Nothing
        Me.BtBuscaProducto.CL_xCentro = False
        Me.BtBuscaProducto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaProducto.Location = New System.Drawing.Point(168, 39)
        Me.BtBuscaProducto.Name = "BtBuscaProducto"
        Me.BtBuscaProducto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaProducto.TabIndex = 73
        Me.BtBuscaProducto.UseVisualStyleBackColor = True
        '
        'TxProducto
        '
        Me.TxProducto.Autonumerico = False
        Me.TxProducto.Buscando = False
        Me.TxProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxProducto.ClForm = Nothing
        Me.TxProducto.ClParam = Nothing
        Me.TxProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxProducto.GridLin = Nothing
        Me.TxProducto.HaCambiado = False
        Me.TxProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxProducto.lbbusca = Nothing
        Me.TxProducto.Location = New System.Drawing.Point(87, 39)
        Me.TxProducto.MiError = False
        Me.TxProducto.Name = "TxProducto"
        Me.TxProducto.Orden = 0
        Me.TxProducto.SaltoAlfinal = False
        Me.TxProducto.Siguiente = 0
        Me.TxProducto.Size = New System.Drawing.Size(75, 22)
        Me.TxProducto.TabIndex = 71
        Me.TxProducto.TeclaRepetida = False
        Me.TxProducto.TxDatoFinalSemana = Nothing
        Me.TxProducto.TxDatoInicioSemana = Nothing
        Me.TxProducto.UltimoValorValidado = Nothing
        '
        'LbProductoLote
        '
        Me.LbProductoLote.AutoSize = True
        Me.LbProductoLote.CL_ControlAsociado = Nothing
        Me.LbProductoLote.CL_ValorFijo = False
        Me.LbProductoLote.ClForm = Nothing
        Me.LbProductoLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProductoLote.ForeColor = System.Drawing.Color.Teal
        Me.LbProductoLote.Location = New System.Drawing.Point(12, 42)
        Me.LbProductoLote.Name = "LbProductoLote"
        Me.LbProductoLote.Size = New System.Drawing.Size(73, 16)
        Me.LbProductoLote.TabIndex = 72
        Me.LbProductoLote.Text = "Producto"
        '
        'BtBuscaLote
        '
        Me.BtBuscaLote.CL_Ancho = 0
        Me.BtBuscaLote.CL_BuscaAlb = False
        Me.BtBuscaLote.CL_campocodigo = Nothing
        Me.BtBuscaLote.CL_camponombre = Nothing
        Me.BtBuscaLote.CL_CampoOrden = "Nombre"
        Me.BtBuscaLote.CL_ch1000 = False
        Me.BtBuscaLote.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaLote.CL_ControlAsociado = Me.TxNumero
        Me.BtBuscaLote.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaLote.CL_dfecha = Nothing
        Me.BtBuscaLote.CL_Entidad = Nothing
        Me.BtBuscaLote.CL_EsId = True
        Me.BtBuscaLote.CL_Filtro = Nothing
        Me.BtBuscaLote.cl_formu = Nothing
        Me.BtBuscaLote.CL_hfecha = Nothing
        Me.BtBuscaLote.cl_ListaW = Nothing
        Me.BtBuscaLote.CL_xCentro = False
        Me.BtBuscaLote.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaLote.Location = New System.Drawing.Point(204, 10)
        Me.BtBuscaLote.Name = "BtBuscaLote"
        Me.BtBuscaLote.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaLote.TabIndex = 70
        Me.BtBuscaLote.UseVisualStyleBackColor = True
        '
        'TxNumero
        '
        Me.TxNumero.Autonumerico = False
        Me.TxNumero.Buscando = False
        Me.TxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumero.ClForm = Nothing
        Me.TxNumero.ClParam = Nothing
        Me.TxNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNumero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNumero.GridLin = Nothing
        Me.TxNumero.HaCambiado = False
        Me.TxNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNumero.lbbusca = Nothing
        Me.TxNumero.Location = New System.Drawing.Point(127, 10)
        Me.TxNumero.MiError = False
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Orden = 0
        Me.TxNumero.SaltoAlfinal = False
        Me.TxNumero.Siguiente = 0
        Me.TxNumero.Size = New System.Drawing.Size(75, 22)
        Me.TxNumero.TabIndex = 65
        Me.TxNumero.TeclaRepetida = False
        Me.TxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxNumero.TxDatoFinalSemana = Nothing
        Me.TxNumero.TxDatoInicioSemana = Nothing
        Me.TxNumero.UltimoValorValidado = Nothing
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.CL_ControlAsociado = Nothing
        Me.LbNumero.CL_ValorFijo = False
        Me.LbNumero.ClForm = Nothing
        Me.LbNumero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Teal
        Me.LbNumero.Location = New System.Drawing.Point(12, 13)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(65, 16)
        Me.LbNumero.TabIndex = 66
        Me.LbNumero.Text = "Número"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TxCampaPartida)
        Me.Panel2.Controls.Add(Me.ListaNormas)
        Me.Panel2.Controls.Add(Me.Lb6)
        Me.Panel2.Controls.Add(Me.LbKxB)
        Me.Panel2.Controls.Add(Me.LbKilosxBulto)
        Me.Panel2.Controls.Add(Me.Lb11)
        Me.Panel2.Controls.Add(Me.LbKilosEntrada)
        Me.Panel2.Controls.Add(Me.Lb9)
        Me.Panel2.Controls.Add(Me.LbBultosEntrada)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.LbFecha)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.LbAlbaran)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.LbAgricultor)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.LbProducto)
        Me.Panel2.Controls.Add(Me.TxBultos)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.LbBultos)
        Me.Panel2.Controls.Add(Me.LbKilos)
        Me.Panel2.Controls.Add(Me.TxKilos)
        Me.Panel2.Controls.Add(Me.TxPartida)
        Me.Panel2.Controls.Add(Me.LbPartida)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 403)
        Me.Panel2.TabIndex = 73
        '
        'TxCampaPartida
        '
        Me.TxCampaPartida.Autonumerico = False
        Me.TxCampaPartida.Buscando = False
        Me.TxCampaPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCampaPartida.ClForm = Nothing
        Me.TxCampaPartida.ClParam = Nothing
        Me.TxCampaPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCampaPartida.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCampaPartida.GridLin = Nothing
        Me.TxCampaPartida.HaCambiado = False
        Me.TxCampaPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCampaPartida.lbbusca = Nothing
        Me.TxCampaPartida.Location = New System.Drawing.Point(87, 8)
        Me.TxCampaPartida.MiError = False
        Me.TxCampaPartida.Name = "TxCampaPartida"
        Me.TxCampaPartida.Orden = 0
        Me.TxCampaPartida.SaltoAlfinal = False
        Me.TxCampaPartida.Siguiente = 0
        Me.TxCampaPartida.Size = New System.Drawing.Size(25, 22)
        Me.TxCampaPartida.TabIndex = 158
        Me.TxCampaPartida.TeclaRepetida = False
        Me.TxCampaPartida.TxDatoFinalSemana = Nothing
        Me.TxCampaPartida.TxDatoInicioSemana = Nothing
        Me.TxCampaPartida.UltimoValorValidado = Nothing
        '
        'ListaNormas
        '
        Me.ListaNormas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaNormas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaNormas.FormattingEnabled = True
        Me.ListaNormas.ItemHeight = 14
        Me.ListaNormas.Location = New System.Drawing.Point(745, 154)
        Me.ListaNormas.Name = "ListaNormas"
        Me.ListaNormas.Size = New System.Drawing.Size(173, 242)
        Me.ListaNormas.TabIndex = 157
        '
        'Lb6
        '
        Me.Lb6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lb6.Location = New System.Drawing.Point(746, 131)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(173, 22)
        Me.Lb6.TabIndex = 156
        Me.Lb6.Text = "Normas Calidad"
        Me.Lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbKxB
        '
        Me.LbKxB.AutoSize = True
        Me.LbKxB.CL_ControlAsociado = Nothing
        Me.LbKxB.CL_ValorFijo = True
        Me.LbKxB.ClForm = Nothing
        Me.LbKxB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKxB.ForeColor = System.Drawing.Color.Teal
        Me.LbKxB.Location = New System.Drawing.Point(12, 98)
        Me.LbKxB.Name = "LbKxB"
        Me.LbKxB.Size = New System.Drawing.Size(36, 16)
        Me.LbKxB.TabIndex = 154
        Me.LbKxB.Text = "KxB"
        '
        'LbKilosxBulto
        '
        Me.LbKilosxBulto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosxBulto.CL_ControlAsociado = Nothing
        Me.LbKilosxBulto.CL_ValorFijo = True
        Me.LbKilosxBulto.ClForm = Nothing
        Me.LbKilosxBulto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosxBulto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosxBulto.Location = New System.Drawing.Point(87, 95)
        Me.LbKilosxBulto.Name = "LbKilosxBulto"
        Me.LbKilosxBulto.Size = New System.Drawing.Size(79, 22)
        Me.LbKilosxBulto.TabIndex = 153
        Me.LbKilosxBulto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(470, 98)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(103, 16)
        Me.Lb11.TabIndex = 152
        Me.Lb11.Text = "Kilos Entrada"
        '
        'LbKilosEntrada
        '
        Me.LbKilosEntrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosEntrada.CL_ControlAsociado = Nothing
        Me.LbKilosEntrada.CL_ValorFijo = True
        Me.LbKilosEntrada.ClForm = Nothing
        Me.LbKilosEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosEntrada.Location = New System.Drawing.Point(578, 95)
        Me.LbKilosEntrada.Name = "LbKilosEntrada"
        Me.LbKilosEntrada.Size = New System.Drawing.Size(79, 22)
        Me.LbKilosEntrada.TabIndex = 151
        Me.LbKilosEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(252, 98)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(115, 16)
        Me.Lb9.TabIndex = 150
        Me.Lb9.Text = "Bultos Entrada"
        '
        'LbBultosEntrada
        '
        Me.LbBultosEntrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbBultosEntrada.CL_ControlAsociado = Nothing
        Me.LbBultosEntrada.CL_ValorFijo = True
        Me.LbBultosEntrada.ClForm = Nothing
        Me.LbBultosEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultosEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbBultosEntrada.Location = New System.Drawing.Point(379, 95)
        Me.LbBultosEntrada.Name = "LbBultosEntrada"
        Me.LbBultosEntrada.Size = New System.Drawing.Size(67, 22)
        Me.LbBultosEntrada.TabIndex = 149
        Me.LbBultosEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(470, 69)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(52, 16)
        Me.Lb7.TabIndex = 148
        Me.Lb7.Text = "Fecha"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = True
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(528, 66)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(130, 22)
        Me.LbFecha.TabIndex = 147
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(252, 69)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(64, 16)
        Me.Lb5.TabIndex = 146
        Me.Lb5.Text = "Albaran"
        '
        'LbAlbaran
        '
        Me.LbAlbaran.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbAlbaran.CL_ControlAsociado = Nothing
        Me.LbAlbaran.CL_ValorFijo = True
        Me.LbAlbaran.ClForm = Nothing
        Me.LbAlbaran.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlbaran.Location = New System.Drawing.Point(337, 66)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(109, 22)
        Me.LbAlbaran.TabIndex = 145
        Me.LbAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(252, 40)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(79, 16)
        Me.Lb3.TabIndex = 144
        Me.Lb3.Text = "Agricultor"
        '
        'LbAgricultor
        '
        Me.LbAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = True
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAgricultor.Location = New System.Drawing.Point(337, 37)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(516, 22)
        Me.LbAgricultor.TabIndex = 143
        Me.LbAgricultor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(252, 11)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(73, 16)
        Me.Lb2.TabIndex = 142
        Me.Lb2.Text = "Producto"
        '
        'LbProducto
        '
        Me.LbProducto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbProducto.CL_ControlAsociado = Nothing
        Me.LbProducto.CL_ValorFijo = True
        Me.LbProducto.ClForm = Nothing
        Me.LbProducto.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbProducto.Location = New System.Drawing.Point(337, 8)
        Me.LbProducto.Name = "LbProducto"
        Me.LbProducto.Size = New System.Drawing.Size(516, 22)
        Me.LbProducto.TabIndex = 141
        Me.LbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxBultos
        '
        Me.TxBultos.Autonumerico = False
        Me.TxBultos.Buscando = False
        Me.TxBultos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBultos.ClForm = Nothing
        Me.TxBultos.ClParam = Nothing
        Me.TxBultos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBultos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBultos.GridLin = Nothing
        Me.TxBultos.HaCambiado = False
        Me.TxBultos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBultos.lbbusca = Nothing
        Me.TxBultos.Location = New System.Drawing.Point(87, 37)
        Me.TxBultos.MiError = False
        Me.TxBultos.Name = "TxBultos"
        Me.TxBultos.Orden = 0
        Me.TxBultos.SaltoAlfinal = False
        Me.TxBultos.Siguiente = 0
        Me.TxBultos.Size = New System.Drawing.Size(74, 22)
        Me.TxBultos.TabIndex = 137
        Me.TxBultos.TeclaRepetida = False
        Me.TxBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxBultos.TxDatoFinalSemana = Nothing
        Me.TxBultos.TxDatoInicioSemana = Nothing
        Me.TxBultos.UltimoValorValidado = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(897, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(875, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbBultos
        '
        Me.LbBultos.AutoSize = True
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = True
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.Teal
        Me.LbBultos.Location = New System.Drawing.Point(12, 40)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(54, 16)
        Me.LbBultos.TabIndex = 117
        Me.LbBultos.Text = "Bultos"
        '
        'LbKilos
        '
        Me.LbKilos.AutoSize = True
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(12, 69)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(42, 16)
        Me.LbKilos.TabIndex = 102
        Me.LbKilos.Text = "Kilos"
        '
        'TxKilos
        '
        Me.TxKilos.Autonumerico = False
        Me.TxKilos.Buscando = False
        Me.TxKilos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilos.ClForm = Nothing
        Me.TxKilos.ClParam = Nothing
        Me.TxKilos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilos.GridLin = Nothing
        Me.TxKilos.HaCambiado = False
        Me.TxKilos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilos.lbbusca = Nothing
        Me.TxKilos.Location = New System.Drawing.Point(87, 66)
        Me.TxKilos.MiError = False
        Me.TxKilos.Name = "TxKilos"
        Me.TxKilos.Orden = 0
        Me.TxKilos.SaltoAlfinal = False
        Me.TxKilos.Siguiente = 0
        Me.TxKilos.Size = New System.Drawing.Size(96, 22)
        Me.TxKilos.TabIndex = 101
        Me.TxKilos.TeclaRepetida = False
        Me.TxKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKilos.TxDatoFinalSemana = Nothing
        Me.TxKilos.TxDatoInicioSemana = Nothing
        Me.TxKilos.UltimoValorValidado = Nothing
        '
        'TxPartida
        '
        Me.TxPartida.Autonumerico = False
        Me.TxPartida.Buscando = False
        Me.TxPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPartida.ClForm = Nothing
        Me.TxPartida.ClParam = Nothing
        Me.TxPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPartida.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPartida.GridLin = Nothing
        Me.TxPartida.HaCambiado = False
        Me.TxPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPartida.lbbusca = Nothing
        Me.TxPartida.Location = New System.Drawing.Point(116, 8)
        Me.TxPartida.MiError = False
        Me.TxPartida.Name = "TxPartida"
        Me.TxPartida.Orden = 0
        Me.TxPartida.SaltoAlfinal = False
        Me.TxPartida.Siguiente = 0
        Me.TxPartida.Size = New System.Drawing.Size(121, 22)
        Me.TxPartida.TabIndex = 71
        Me.TxPartida.TeclaRepetida = False
        Me.TxPartida.TxDatoFinalSemana = Nothing
        Me.TxPartida.TxDatoInicioSemana = Nothing
        Me.TxPartida.UltimoValorValidado = Nothing
        '
        'LbPartida
        '
        Me.LbPartida.AutoSize = True
        Me.LbPartida.CL_ControlAsociado = Nothing
        Me.LbPartida.CL_ValorFijo = False
        Me.LbPartida.ClForm = Nothing
        Me.LbPartida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPartida.ForeColor = System.Drawing.Color.Teal
        Me.LbPartida.Location = New System.Drawing.Point(12, 11)
        Me.LbPartida.Name = "LbPartida"
        Me.LbPartida.Size = New System.Drawing.Size(60, 16)
        Me.LbPartida.TabIndex = 72
        Me.LbPartida.Text = "Partida"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 129)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(747, 270)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmLotesPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmLotesPartida"
        Me.Text = "Lotes de partidas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbNomProductoLote As NetAgro.Lb
    Friend WithEvents BtBuscaProducto As NetAgro.BtBusca
    Friend WithEvents TxProducto As NetAgro.TxDato
    Friend WithEvents LbProductoLote As NetAgro.Lb
    Friend WithEvents BtBuscaLote As NetAgro.BtBusca
    Friend WithEvents TxNumero As NetAgro.TxDato
    Friend WithEvents LbNumero As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents TxPartida As NetAgro.TxDato
    Friend WithEvents LbPartida As NetAgro.Lb
    Friend WithEvents BtNuevo As NetAgro.ClButton
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents LbFechaLote As NetAgro.Lb
    Friend WithEvents TxFechaLote As NetAgro.TxDato
    Friend WithEvents TxKilos As NetAgro.TxDato
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxBultos As NetAgro.TxDato
    Friend WithEvents LbProducto As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbKilosEntrada As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbBultosEntrada As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbAlbaran As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbCalidad As NetAgro.Lb
    Friend WithEvents TxCalidad As NetAgro.TxDato
    Friend WithEvents LbNomEnvase As NetAgro.Lb
    Friend WithEvents BtBuscaEnvase As NetAgro.BtBusca
    Friend WithEvents TxEnvase As NetAgro.TxDato
    Friend WithEvents LbEnvase As NetAgro.Lb
    Friend WithEvents LbControlado As NetAgro.Lb
    Friend WithEvents LbKxB As NetAgro.Lb
    Friend WithEvents LbKilosxBulto As NetAgro.Lb
    Friend WithEvents LbColor As NetAgro.Lb
    Friend WithEvents TxColor As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbProgramaCalidad As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents ListaNormas As System.Windows.Forms.ListBox
    Friend WithEvents LbControladoSN As NetAgro.Lb
    Friend WithEvents TxCampaPartida As NetAgro.TxDato

End Class
