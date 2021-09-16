<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioFirme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecioFirme))
        Me.LbPcalidad = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbPalet = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbEnvase = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.LbCultivo = New NetAgro.Lb(Me.components)
        Me.Lb25 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb30 = New NetAgro.Lb(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.LbTipoPrecio = New NetAgro.Lb(Me.components)
        Me.TxImporte = New NetAgro.TxDato(Me.components)
        Me.LbValorada = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.LbPiezas = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.TxPrecio = New NetAgro.TxDato(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Lb48 = New NetAgro.Lb(Me.components)
        Me.LbGensal = New NetAgro.Lb(Me.components)
        Me.Lb50 = New NetAgro.Lb(Me.components)
        Me.LbMarca = New NetAgro.Lb(Me.components)
        Me.LbTpalet = New NetAgro.Lb(Me.components)
        Me.Lb52 = New NetAgro.Lb(Me.components)
        Me.Lb59 = New NetAgro.Lb(Me.components)
        Me.LbIdCultivo = New NetAgro.Lb(Me.components)
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.LbIdCalidad = New NetAgro.Lb(Me.components)
        Me.LBPARTIDA = New NetAgro.Lb(Me.components)
        Me.Lb58 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbNomProve = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.BtDetallesAlbaran = New System.Windows.Forms.Button()
        Me.Lb60 = New NetAgro.Lb(Me.components)
        Me.Lb64 = New NetAgro.Lb(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btBuscaPartidas = New System.Windows.Forms.Button()
        Me.LbBuscarPorPartida = New NetAgro.Lb(Me.components)
        Me.TxBuscarPorPartida = New NetAgro.TxDato(Me.components)
        Me.LbTipoFCS = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFechaValoracion = New NetAgro.Lb(Me.components)
        Me.TxFechaValoracion = New NetAgro.TxDato(Me.components)
        Me.LbMatricula = New NetAgro.Lb(Me.components)
        Me.LbReferencia = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbPcalidad
        '
        Me.LbPcalidad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPcalidad.CL_ControlAsociado = Nothing
        Me.LbPcalidad.CL_ValorFijo = True
        Me.LbPcalidad.ClForm = Nothing
        Me.LbPcalidad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPcalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPcalidad.Location = New System.Drawing.Point(640, 33)
        Me.LbPcalidad.Name = "LbPcalidad"
        Me.LbPcalidad.Size = New System.Drawing.Size(219, 23)
        Me.LbPcalidad.TabIndex = 124
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
        Me.ClGrid1.Location = New System.Drawing.Point(13, 210)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(997, 265)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(15, 98)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(45, 16)
        Me.Lb6.TabIndex = 80
        Me.Lb6.Text = "Palet"
        '
        'LbPalet
        '
        Me.LbPalet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPalet.CL_ControlAsociado = Nothing
        Me.LbPalet.CL_ValorFijo = True
        Me.LbPalet.ClForm = Nothing
        Me.LbPalet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPalet.Location = New System.Drawing.Point(105, 95)
        Me.LbPalet.Name = "LbPalet"
        Me.LbPalet.Size = New System.Drawing.Size(260, 23)
        Me.LbPalet.TabIndex = 82
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(15, 68)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(61, 16)
        Me.Lb11.TabIndex = 84
        Me.Lb11.Text = "Envase"
        '
        'LbEnvase
        '
        Me.LbEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbEnvase.CL_ControlAsociado = Nothing
        Me.LbEnvase.CL_ValorFijo = True
        Me.LbEnvase.ClForm = Nothing
        Me.LbEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbEnvase.Location = New System.Drawing.Point(105, 66)
        Me.LbEnvase.Name = "LbEnvase"
        Me.LbEnvase.Size = New System.Drawing.Size(260, 23)
        Me.LbEnvase.TabIndex = 86
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(15, 155)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(87, 16)
        Me.Lb14.TabIndex = 89
        Me.Lb14.Text = "Kilos netos"
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(15, 127)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(54, 16)
        Me.Lb16.TabIndex = 91
        Me.Lb16.Text = "Bultos"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(15, 10)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(60, 16)
        Me.Lb5.TabIndex = 72
        Me.Lb5.Text = "Genero"
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbGenero.Location = New System.Drawing.Point(105, 9)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(315, 23)
        Me.LbGenero.TabIndex = 74
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(535, 11)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(59, 16)
        Me.Lb23.TabIndex = 102
        Me.Lb23.Text = "Cultivo"
        '
        'LbCultivo
        '
        Me.LbCultivo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCultivo.CL_ControlAsociado = Nothing
        Me.LbCultivo.CL_ValorFijo = True
        Me.LbCultivo.ClForm = Nothing
        Me.LbCultivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCultivo.Location = New System.Drawing.Point(638, 4)
        Me.LbCultivo.Name = "LbCultivo"
        Me.LbCultivo.Size = New System.Drawing.Size(273, 23)
        Me.LbCultivo.TabIndex = 104
        '
        'Lb25
        '
        Me.Lb25.AutoSize = True
        Me.Lb25.CL_ControlAsociado = Nothing
        Me.Lb25.CL_ValorFijo = True
        Me.Lb25.ClForm = Nothing
        Me.Lb25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb25.ForeColor = System.Drawing.Color.Teal
        Me.Lb25.Location = New System.Drawing.Point(15, 40)
        Me.Lb25.Name = "Lb25"
        Me.Lb25.Size = New System.Drawing.Size(79, 16)
        Me.Lb25.TabIndex = 106
        Me.Lb25.Text = "Categoria"
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = True
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCategoria.Location = New System.Drawing.Point(105, 37)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(199, 23)
        Me.LbCategoria.TabIndex = 108
        '
        'Lb30
        '
        Me.Lb30.AutoSize = True
        Me.Lb30.CL_ControlAsociado = Nothing
        Me.Lb30.CL_ValorFijo = True
        Me.Lb30.ClForm = Nothing
        Me.Lb30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb30.ForeColor = System.Drawing.Color.Teal
        Me.Lb30.Location = New System.Drawing.Point(214, 126)
        Me.Lb30.Name = "Lb30"
        Me.Lb30.Size = New System.Drawing.Size(60, 16)
        Me.Lb30.TabIndex = 109
        Me.Lb30.Text = "Partida"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(424, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(462, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.LbTipoPrecio)
        Me.Panel.Controls.Add(Me.TxImporte)
        Me.Panel.Controls.Add(Me.LbValorada)
        Me.Panel.Controls.Add(Me.Lb15)
        Me.Panel.Controls.Add(Me.LbPiezas)
        Me.Panel.Controls.Add(Me.LbKilos)
        Me.Panel.Controls.Add(Me.LbBultos)
        Me.Panel.Controls.Add(Me.TxPrecio)
        Me.Panel.Controls.Add(Me.Panel6)
        Me.Panel.Controls.Add(Me.Lb59)
        Me.Panel.Controls.Add(Me.LbIdCultivo)
        Me.Panel.Controls.Add(Me.PictureBox2)
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Controls.Add(Me.Lb30)
        Me.Panel.Controls.Add(Me.LbCategoria)
        Me.Panel.Controls.Add(Me.Lb25)
        Me.Panel.Controls.Add(Me.LbCultivo)
        Me.Panel.Controls.Add(Me.Lb23)
        Me.Panel.Controls.Add(Me.LbGenero)
        Me.Panel.Controls.Add(Me.Lb5)
        Me.Panel.Controls.Add(Me.Lb16)
        Me.Panel.Controls.Add(Me.Lb14)
        Me.Panel.Controls.Add(Me.LbEnvase)
        Me.Panel.Controls.Add(Me.Lb11)
        Me.Panel.Controls.Add(Me.LbPalet)
        Me.Panel.Controls.Add(Me.Lb6)
        Me.Panel.Controls.Add(Me.ClGrid1)
        Me.Panel.Controls.Add(Me.LbPcalidad)
        Me.Panel.Controls.Add(Me.Lb26)
        Me.Panel.Controls.Add(Me.LbIdCalidad)
        Me.Panel.Controls.Add(Me.LBPARTIDA)
        Me.Panel.Controls.Add(Me.Lb58)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 100)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1011, 474)
        Me.Panel.TabIndex = 73
        '
        'LbTipoPrecio
        '
        Me.LbTipoPrecio.BackColor = System.Drawing.Color.LightGray
        Me.LbTipoPrecio.CL_ControlAsociado = Nothing
        Me.LbTipoPrecio.CL_ValorFijo = True
        Me.LbTipoPrecio.ClForm = Nothing
        Me.LbTipoPrecio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipoPrecio.Location = New System.Drawing.Point(345, 178)
        Me.LbTipoPrecio.Name = "LbTipoPrecio"
        Me.LbTipoPrecio.Size = New System.Drawing.Size(28, 21)
        Me.LbTipoPrecio.TabIndex = 174
        Me.LbTipoPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxImporte
        '
        Me.TxImporte.Autonumerico = False
        Me.TxImporte.Buscando = False
        Me.TxImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte.ClForm = Nothing
        Me.TxImporte.ClParam = Nothing
        Me.TxImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte.GridLin = Nothing
        Me.TxImporte.HaCambiado = False
        Me.TxImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporte.lbbusca = Nothing
        Me.TxImporte.Location = New System.Drawing.Point(468, 177)
        Me.TxImporte.MiError = False
        Me.TxImporte.Name = "TxImporte"
        Me.TxImporte.Orden = 0
        Me.TxImporte.SaltoAlfinal = False
        Me.TxImporte.Siguiente = 0
        Me.TxImporte.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte.TabIndex = 173
        Me.TxImporte.TeclaRepetida = False
        Me.TxImporte.TxDatoFinalSemana = Nothing
        Me.TxImporte.TxDatoInicioSemana = Nothing
        Me.TxImporte.UltimoValorValidado = Nothing
        '
        'LbValorada
        '
        Me.LbValorada.BackColor = System.Drawing.Color.Red
        Me.LbValorada.CL_ControlAsociado = Nothing
        Me.LbValorada.CL_ValorFijo = True
        Me.LbValorada.ClForm = Nothing
        Me.LbValorada.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValorada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbValorada.Location = New System.Drawing.Point(854, 169)
        Me.LbValorada.Name = "LbValorada"
        Me.LbValorada.Size = New System.Drawing.Size(136, 30)
        Me.LbValorada.TabIndex = 172
        Me.LbValorada.Text = "VALORADA"
        Me.LbValorada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbValorada.Visible = False
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(395, 180)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(67, 16)
        Me.Lb15.TabIndex = 170
        Me.Lb15.Text = "Importe"
        '
        'LbPiezas
        '
        Me.LbPiezas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPiezas.CL_ControlAsociado = Nothing
        Me.LbPiezas.CL_ValorFijo = True
        Me.LbPiezas.ClForm = Nothing
        Me.LbPiezas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPiezas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPiezas.Location = New System.Drawing.Point(105, 177)
        Me.LbPiezas.Name = "LbPiezas"
        Me.LbPiezas.Size = New System.Drawing.Size(89, 23)
        Me.LbPiezas.TabIndex = 169
        Me.LbPiezas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = True
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilos.Location = New System.Drawing.Point(105, 148)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(89, 23)
        Me.LbKilos.TabIndex = 168
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbBultos
        '
        Me.LbBultos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = True
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbBultos.Location = New System.Drawing.Point(105, 122)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(89, 23)
        Me.LbBultos.TabIndex = 167
        Me.LbBultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxPrecio
        '
        Me.TxPrecio.Autonumerico = False
        Me.TxPrecio.Buscando = False
        Me.TxPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPrecio.ClForm = Nothing
        Me.TxPrecio.ClParam = Nothing
        Me.TxPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPrecio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPrecio.GridLin = Nothing
        Me.TxPrecio.HaCambiado = False
        Me.TxPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPrecio.lbbusca = Nothing
        Me.TxPrecio.Location = New System.Drawing.Point(250, 177)
        Me.TxPrecio.MiError = False
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Orden = 0
        Me.TxPrecio.SaltoAlfinal = False
        Me.TxPrecio.Siguiente = 0
        Me.TxPrecio.Size = New System.Drawing.Size(90, 22)
        Me.TxPrecio.TabIndex = 164
        Me.TxPrecio.TeclaRepetida = False
        Me.TxPrecio.TxDatoFinalSemana = Nothing
        Me.TxPrecio.TxDatoInicioSemana = Nothing
        Me.TxPrecio.UltimoValorValidado = Nothing
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightBlue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Lb48)
        Me.Panel6.Controls.Add(Me.LbGensal)
        Me.Panel6.Controls.Add(Me.Lb50)
        Me.Panel6.Controls.Add(Me.LbMarca)
        Me.Panel6.Controls.Add(Me.LbTpalet)
        Me.Panel6.Controls.Add(Me.Lb52)
        Me.Panel6.Location = New System.Drawing.Point(393, 68)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(597, 93)
        Me.Panel6.TabIndex = 163
        Me.Panel6.Visible = False
        '
        'Lb48
        '
        Me.Lb48.AutoSize = True
        Me.Lb48.CL_ControlAsociado = Nothing
        Me.Lb48.CL_ValorFijo = True
        Me.Lb48.ClForm = Nothing
        Me.Lb48.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb48.ForeColor = System.Drawing.Color.Teal
        Me.Lb48.Location = New System.Drawing.Point(2, 8)
        Me.Lb48.Name = "Lb48"
        Me.Lb48.Size = New System.Drawing.Size(69, 16)
        Me.Lb48.TabIndex = 146
        Me.Lb48.Text = "Present."
        '
        'LbGensal
        '
        Me.LbGensal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbGensal.CL_ControlAsociado = Nothing
        Me.LbGensal.CL_ValorFijo = True
        Me.LbGensal.ClForm = Nothing
        Me.LbGensal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGensal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbGensal.Location = New System.Drawing.Point(77, 6)
        Me.LbGensal.Name = "LbGensal"
        Me.LbGensal.Size = New System.Drawing.Size(500, 23)
        Me.LbGensal.TabIndex = 148
        '
        'Lb50
        '
        Me.Lb50.AutoSize = True
        Me.Lb50.CL_ControlAsociado = Nothing
        Me.Lb50.CL_ValorFijo = True
        Me.Lb50.ClForm = Nothing
        Me.Lb50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb50.ForeColor = System.Drawing.Color.Teal
        Me.Lb50.Location = New System.Drawing.Point(2, 36)
        Me.Lb50.Name = "Lb50"
        Me.Lb50.Size = New System.Drawing.Size(58, 16)
        Me.Lb50.TabIndex = 150
        Me.Lb50.Text = "T.palet"
        '
        'LbMarca
        '
        Me.LbMarca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbMarca.CL_ControlAsociado = Nothing
        Me.LbMarca.CL_ValorFijo = True
        Me.LbMarca.ClForm = Nothing
        Me.LbMarca.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbMarca.Location = New System.Drawing.Point(77, 65)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.Size = New System.Drawing.Size(199, 23)
        Me.LbMarca.TabIndex = 156
        '
        'LbTpalet
        '
        Me.LbTpalet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTpalet.CL_ControlAsociado = Nothing
        Me.LbTpalet.CL_ValorFijo = True
        Me.LbTpalet.ClForm = Nothing
        Me.LbTpalet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTpalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTpalet.Location = New System.Drawing.Point(77, 35)
        Me.LbTpalet.Name = "LbTpalet"
        Me.LbTpalet.Size = New System.Drawing.Size(386, 23)
        Me.LbTpalet.TabIndex = 152
        '
        'Lb52
        '
        Me.Lb52.AutoSize = True
        Me.Lb52.CL_ControlAsociado = Nothing
        Me.Lb52.CL_ValorFijo = True
        Me.Lb52.ClForm = Nothing
        Me.Lb52.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb52.ForeColor = System.Drawing.Color.Teal
        Me.Lb52.Location = New System.Drawing.Point(2, 66)
        Me.Lb52.Name = "Lb52"
        Me.Lb52.Size = New System.Drawing.Size(52, 16)
        Me.Lb52.TabIndex = 154
        Me.Lb52.Text = "Marca"
        '
        'Lb59
        '
        Me.Lb59.AutoSize = True
        Me.Lb59.CL_ControlAsociado = Nothing
        Me.Lb59.CL_ValorFijo = True
        Me.Lb59.ClForm = Nothing
        Me.Lb59.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb59.ForeColor = System.Drawing.Color.Teal
        Me.Lb59.Location = New System.Drawing.Point(253, 155)
        Me.Lb59.Name = "Lb59"
        Me.Lb59.Size = New System.Drawing.Size(112, 16)
        Me.Lb59.TabIndex = 161
        Me.Lb59.Text = "Precio compra"
        '
        'LbIdCultivo
        '
        Me.LbIdCultivo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbIdCultivo.CL_ControlAsociado = Nothing
        Me.LbIdCultivo.CL_ValorFijo = True
        Me.LbIdCultivo.ClForm = Nothing
        Me.LbIdCultivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdCultivo.Location = New System.Drawing.Point(598, 6)
        Me.LbIdCultivo.Name = "LbIdCultivo"
        Me.LbIdCultivo.Size = New System.Drawing.Size(36, 23)
        Me.LbIdCultivo.TabIndex = 143
        '
        'Lb26
        '
        Me.Lb26.AutoSize = True
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = True
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.ForeColor = System.Drawing.Color.Teal
        Me.Lb26.Location = New System.Drawing.Point(536, 34)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(45, 16)
        Me.Lb26.TabIndex = 140
        Me.Lb26.Text = "P.Cal"
        '
        'LbIdCalidad
        '
        Me.LbIdCalidad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbIdCalidad.CL_ControlAsociado = Nothing
        Me.LbIdCalidad.CL_ValorFijo = True
        Me.LbIdCalidad.ClForm = Nothing
        Me.LbIdCalidad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdCalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdCalidad.Location = New System.Drawing.Point(598, 33)
        Me.LbIdCalidad.Name = "LbIdCalidad"
        Me.LbIdCalidad.Size = New System.Drawing.Size(36, 23)
        Me.LbIdCalidad.TabIndex = 142
        '
        'LBPARTIDA
        '
        Me.LBPARTIDA.BackColor = System.Drawing.Color.LightGray
        Me.LBPARTIDA.CL_ControlAsociado = Nothing
        Me.LBPARTIDA.CL_ValorFijo = True
        Me.LBPARTIDA.ClForm = Nothing
        Me.LBPARTIDA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPARTIDA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBPARTIDA.Location = New System.Drawing.Point(277, 122)
        Me.LBPARTIDA.Name = "LBPARTIDA"
        Me.LBPARTIDA.Size = New System.Drawing.Size(88, 21)
        Me.LBPARTIDA.TabIndex = 144
        '
        'Lb58
        '
        Me.Lb58.AutoSize = True
        Me.Lb58.CL_ControlAsociado = Nothing
        Me.Lb58.CL_ValorFijo = True
        Me.Lb58.ClForm = Nothing
        Me.Lb58.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb58.ForeColor = System.Drawing.Color.Teal
        Me.Lb58.Location = New System.Drawing.Point(15, 180)
        Me.Lb58.Name = "Lb58"
        Me.Lb58.Size = New System.Drawing.Size(55, 16)
        Me.Lb58.TabIndex = 166
        Me.Lb58.Text = "Piezas"
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
        Me.TxDato1.Location = New System.Drawing.Point(120, 7)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato1.TabIndex = 65
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(10, 10)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(64, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Albarán"
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
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato1
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
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(201, 7)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 70
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(10, 40)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(83, 16)
        Me.Lb3.TabIndex = 72
        Me.Lb3.Text = "Proveedor"
        '
        'LbNomProve
        '
        Me.LbNomProve.BackColor = System.Drawing.Color.LightGray
        Me.LbNomProve.CL_ControlAsociado = Nothing
        Me.LbNomProve.CL_ValorFijo = True
        Me.LbNomProve.ClForm = Nothing
        Me.LbNomProve.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomProve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomProve.Location = New System.Drawing.Point(120, 36)
        Me.LbNomProve.Name = "LbNomProve"
        Me.LbNomProve.Size = New System.Drawing.Size(461, 25)
        Me.LbNomProve.TabIndex = 74
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(618, 40)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(52, 16)
        Me.Lb9.TabIndex = 77
        Me.Lb9.Text = "Fecha"
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
        Me.LbCampa.Location = New System.Drawing.Point(80, 8)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        Me.LbCampa.Text = "13"
        '
        'BtDetallesAlbaran
        '
        Me.BtDetallesAlbaran.Image = Global.NetAgro.My.Resources.Resources.Action_button_info_16x16_32
        Me.BtDetallesAlbaran.Location = New System.Drawing.Point(240, 7)
        Me.BtDetallesAlbaran.Name = "BtDetallesAlbaran"
        Me.BtDetallesAlbaran.Size = New System.Drawing.Size(26, 23)
        Me.BtDetallesAlbaran.TabIndex = 116
        Me.BtDetallesAlbaran.UseVisualStyleBackColor = True
        '
        'Lb60
        '
        Me.Lb60.AutoSize = True
        Me.Lb60.CL_ControlAsociado = Nothing
        Me.Lb60.CL_ValorFijo = True
        Me.Lb60.ClForm = Nothing
        Me.Lb60.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb60.ForeColor = System.Drawing.Color.Teal
        Me.Lb60.Location = New System.Drawing.Point(10, 69)
        Me.Lb60.Name = "Lb60"
        Me.Lb60.Size = New System.Drawing.Size(92, 16)
        Me.Lb60.TabIndex = 183
        Me.Lb60.Text = "Ref.Albarán"
        '
        'Lb64
        '
        Me.Lb64.AutoSize = True
        Me.Lb64.CL_ControlAsociado = Nothing
        Me.Lb64.CL_ValorFijo = True
        Me.Lb64.ClForm = Nothing
        Me.Lb64.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb64.ForeColor = System.Drawing.Color.Teal
        Me.Lb64.Location = New System.Drawing.Point(349, 69)
        Me.Lb64.Name = "Lb64"
        Me.Lb64.Size = New System.Drawing.Size(75, 16)
        Me.Lb64.TabIndex = 197
        Me.Lb64.Text = "Matricula"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btBuscaPartidas)
        Me.Panel4.Controls.Add(Me.LbBuscarPorPartida)
        Me.Panel4.Controls.Add(Me.TxBuscarPorPartida)
        Me.Panel4.Controls.Add(Me.LbTipoFCS)
        Me.Panel4.Controls.Add(Me.Lb4)
        Me.Panel4.Controls.Add(Me.LbFechaValoracion)
        Me.Panel4.Controls.Add(Me.TxFechaValoracion)
        Me.Panel4.Controls.Add(Me.LbMatricula)
        Me.Panel4.Controls.Add(Me.LbReferencia)
        Me.Panel4.Controls.Add(Me.LbFecha)
        Me.Panel4.Controls.Add(Me.Lb64)
        Me.Panel4.Controls.Add(Me.Lb60)
        Me.Panel4.Controls.Add(Me.BtDetallesAlbaran)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Lb9)
        Me.Panel4.Controls.Add(Me.LbNomProve)
        Me.Panel4.Controls.Add(Me.Lb3)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1011, 100)
        Me.Panel4.TabIndex = 72
        '
        'btBuscaPartidas
        '
        Me.btBuscaPartidas.Image = CType(resources.GetObject("btBuscaPartidas.Image"), System.Drawing.Image)
        Me.btBuscaPartidas.Location = New System.Drawing.Point(513, 7)
        Me.btBuscaPartidas.Name = "btBuscaPartidas"
        Me.btBuscaPartidas.Size = New System.Drawing.Size(26, 23)
        Me.btBuscaPartidas.TabIndex = 214
        Me.btBuscaPartidas.UseVisualStyleBackColor = True
        '
        'LbBuscarPorPartida
        '
        Me.LbBuscarPorPartida.AutoSize = True
        Me.LbBuscarPorPartida.CL_ControlAsociado = Nothing
        Me.LbBuscarPorPartida.CL_ValorFijo = True
        Me.LbBuscarPorPartida.ClForm = Nothing
        Me.LbBuscarPorPartida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBuscarPorPartida.ForeColor = System.Drawing.Color.Teal
        Me.LbBuscarPorPartida.Location = New System.Drawing.Point(277, 10)
        Me.LbBuscarPorPartida.Name = "LbBuscarPorPartida"
        Me.LbBuscarPorPartida.Size = New System.Drawing.Size(134, 16)
        Me.LbBuscarPorPartida.TabIndex = 213
        Me.LbBuscarPorPartida.Text = "Bucar por partida"
        '
        'TxBuscarPorPartida
        '
        Me.TxBuscarPorPartida.Autonumerico = False
        Me.TxBuscarPorPartida.Buscando = False
        Me.TxBuscarPorPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBuscarPorPartida.ClForm = Nothing
        Me.TxBuscarPorPartida.ClParam = Nothing
        Me.TxBuscarPorPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBuscarPorPartida.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBuscarPorPartida.GridLin = Nothing
        Me.TxBuscarPorPartida.HaCambiado = False
        Me.TxBuscarPorPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBuscarPorPartida.lbbusca = Nothing
        Me.TxBuscarPorPartida.Location = New System.Drawing.Point(417, 7)
        Me.TxBuscarPorPartida.MiError = False
        Me.TxBuscarPorPartida.Name = "TxBuscarPorPartida"
        Me.TxBuscarPorPartida.Orden = 0
        Me.TxBuscarPorPartida.SaltoAlfinal = False
        Me.TxBuscarPorPartida.Siguiente = 0
        Me.TxBuscarPorPartida.Size = New System.Drawing.Size(93, 22)
        Me.TxBuscarPorPartida.TabIndex = 212
        Me.TxBuscarPorPartida.TeclaRepetida = False
        Me.TxBuscarPorPartida.TxDatoFinalSemana = Nothing
        Me.TxBuscarPorPartida.TxDatoInicioSemana = Nothing
        Me.TxBuscarPorPartida.UltimoValorValidado = Nothing
        '
        'LbTipoFCS
        '
        Me.LbTipoFCS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTipoFCS.CL_ControlAsociado = Nothing
        Me.LbTipoFCS.CL_ValorFijo = True
        Me.LbTipoFCS.ClForm = Nothing
        Me.LbTipoFCS.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoFCS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipoFCS.Location = New System.Drawing.Point(726, 66)
        Me.LbTipoFCS.Name = "LbTipoFCS"
        Me.LbTipoFCS.Size = New System.Drawing.Size(42, 23)
        Me.LbTipoFCS.TabIndex = 204
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(618, 69)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(102, 16)
        Me.Lb4.TabIndex = 203
        Me.Lb4.Text = "Tipo (F/C/S)"
        '
        'LbFechaValoracion
        '
        Me.LbFechaValoracion.AutoSize = True
        Me.LbFechaValoracion.CL_ControlAsociado = Nothing
        Me.LbFechaValoracion.CL_ValorFijo = False
        Me.LbFechaValoracion.ClForm = Nothing
        Me.LbFechaValoracion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaValoracion.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaValoracion.Location = New System.Drawing.Point(618, 10)
        Me.LbFechaValoracion.Name = "LbFechaValoracion"
        Me.LbFechaValoracion.Size = New System.Drawing.Size(132, 16)
        Me.LbFechaValoracion.TabIndex = 202
        Me.LbFechaValoracion.Text = "Fecha valoración"
        '
        'TxFechaValoracion
        '
        Me.TxFechaValoracion.Autonumerico = False
        Me.TxFechaValoracion.Buscando = False
        Me.TxFechaValoracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaValoracion.ClForm = Nothing
        Me.TxFechaValoracion.ClParam = Nothing
        Me.TxFechaValoracion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaValoracion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaValoracion.GridLin = Nothing
        Me.TxFechaValoracion.HaCambiado = False
        Me.TxFechaValoracion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaValoracion.lbbusca = Nothing
        Me.TxFechaValoracion.Location = New System.Drawing.Point(756, 7)
        Me.TxFechaValoracion.MiError = False
        Me.TxFechaValoracion.Name = "TxFechaValoracion"
        Me.TxFechaValoracion.Orden = 0
        Me.TxFechaValoracion.SaltoAlfinal = False
        Me.TxFechaValoracion.Siguiente = 0
        Me.TxFechaValoracion.Size = New System.Drawing.Size(119, 22)
        Me.TxFechaValoracion.TabIndex = 201
        Me.TxFechaValoracion.TeclaRepetida = False
        Me.TxFechaValoracion.TxDatoFinalSemana = Nothing
        Me.TxFechaValoracion.TxDatoInicioSemana = Nothing
        Me.TxFechaValoracion.UltimoValorValidado = Nothing
        '
        'LbMatricula
        '
        Me.LbMatricula.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbMatricula.CL_ControlAsociado = Nothing
        Me.LbMatricula.CL_ValorFijo = True
        Me.LbMatricula.ClForm = Nothing
        Me.LbMatricula.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMatricula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbMatricula.Location = New System.Drawing.Point(430, 66)
        Me.LbMatricula.Name = "LbMatricula"
        Me.LbMatricula.Size = New System.Drawing.Size(149, 23)
        Me.LbMatricula.TabIndex = 200
        '
        'LbReferencia
        '
        Me.LbReferencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbReferencia.CL_ControlAsociado = Nothing
        Me.LbReferencia.CL_ValorFijo = True
        Me.LbReferencia.ClForm = Nothing
        Me.LbReferencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbReferencia.Location = New System.Drawing.Point(120, 66)
        Me.LbReferencia.Name = "LbReferencia"
        Me.LbReferencia.Size = New System.Drawing.Size(149, 23)
        Me.LbReferencia.TabIndex = 199
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = True
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(676, 37)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(152, 23)
        Me.LbFecha.TabIndex = 198
        '
        'FrmPrecioFirme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 614)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPrecioFirme"
        Me.Text = "Valorar albaranes firme"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbPcalidad As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbPalet As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbEnvase As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents LbCultivo As NetAgro.Lb
    Friend WithEvents Lb25 As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents Lb30 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents LbIdCultivo As NetAgro.Lb
    Friend WithEvents LbIdCalidad As NetAgro.Lb
    Friend WithEvents LBPARTIDA As NetAgro.Lb
    Friend WithEvents LbTpalet As NetAgro.Lb
    Friend WithEvents Lb50 As NetAgro.Lb
    Friend WithEvents LbGensal As NetAgro.Lb
    Friend WithEvents Lb48 As NetAgro.Lb
    Friend WithEvents LbMarca As NetAgro.Lb
    Friend WithEvents Lb52 As NetAgro.Lb
    Friend WithEvents Lb59 As NetAgro.Lb
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TxPrecio As NetAgro.TxDato
    Friend WithEvents Lb58 As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents LbPiezas As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbNomProve As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents BtDetallesAlbaran As System.Windows.Forms.Button
    Friend WithEvents Lb60 As NetAgro.Lb
    Friend WithEvents Lb64 As NetAgro.Lb
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbMatricula As NetAgro.Lb
    Friend WithEvents LbReferencia As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents LbFechaValoracion As NetAgro.Lb
    Friend WithEvents TxFechaValoracion As NetAgro.TxDato
    Friend WithEvents LbValorada As NetAgro.Lb
    Friend WithEvents LbTipoFCS As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents btBuscaPartidas As System.Windows.Forms.Button
    Friend WithEvents LbBuscarPorPartida As NetAgro.Lb
    Friend WithEvents TxBuscarPorPartida As NetAgro.TxDato
    Friend WithEvents TxImporte As NetAgro.TxDato
    Friend WithEvents LbTipoPrecio As NetAgro.Lb

End Class
