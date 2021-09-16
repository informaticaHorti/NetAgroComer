<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraspasosCentros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraspasosCentros))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.BtBuscaPartidaLote = New System.Windows.Forms.Button()
        Me.LbNomProducto = New NetAgro.Lb(Me.components)
        Me.LbProducto = New NetAgro.Lb(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbExp = New NetAgro.Lb(Me.components)
        Me.TxTipo = New NetAgro.TxDato(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.BtNuevo = New NetAgro.ClButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxTractora = New NetAgro.TxDato(Me.components)
        Me.LbTractora = New NetAgro.Lb(Me.components)
        Me.TxObservaciones = New NetAgro.TxDato(Me.components)
        Me.LbObservaciones = New NetAgro.Lb(Me.components)
        Me.LbNomCentroDestino = New NetAgro.Lb(Me.components)
        Me.BtBuscaCentroDestino = New NetAgro.BtBusca(Me.components)
        Me.TxCentroDestino = New NetAgro.TxDato(Me.components)
        Me.LbCentroDestino = New NetAgro.Lb(Me.components)
        Me.TxMatricula = New NetAgro.TxDato(Me.components)
        Me.LbMatricula = New NetAgro.Lb(Me.components)
        Me.LbNomTransportista = New NetAgro.Lb(Me.components)
        Me.BtBuscaTransportista = New NetAgro.BtBusca(Me.components)
        Me.TxTransportista = New NetAgro.TxDato(Me.components)
        Me.LbTransportista = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtBuscaTraspaso = New NetAgro.BtBusca(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.LbNomCentroOrigen = New NetAgro.Lb(Me.components)
        Me.LbNumero = New NetAgro.Lb(Me.components)
        Me.TxNumero = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCentroOrigen = New NetAgro.BtBusca(Me.components)
        Me.TxCentroOrigen = New NetAgro.TxDato(Me.components)
        Me.LbCentroOrigen = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.btAnularRecepcion = New NetAgro.ClButton()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Location = New System.Drawing.Point(0, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 292)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Lb3)
        Me.GroupBox5.Controls.Add(Me.BtBuscaPartidaLote)
        Me.GroupBox5.Controls.Add(Me.LbNomProducto)
        Me.GroupBox5.Controls.Add(Me.LbProducto)
        Me.GroupBox5.Controls.Add(Me.LbCodigo)
        Me.GroupBox5.Controls.Add(Me.TxCodigo)
        Me.GroupBox5.Controls.Add(Me.Lb2)
        Me.GroupBox5.Controls.Add(Me.Lb1)
        Me.GroupBox5.Controls.Add(Me.LbExp)
        Me.GroupBox5.Controls.Add(Me.TxTipo)
        Me.GroupBox5.Controls.Add(Me.LbTipo)
        Me.GroupBox5.Controls.Add(Me.ClGrid1)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1039, 286)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(77, 56)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(115, 13)
        Me.Lb3.TabIndex = 100369
        Me.Lb3.Text = "C = Precalibrado"
        '
        'BtBuscaPartidaLote
        '
        Me.BtBuscaPartidaLote.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.BtBuscaPartidaLote.Location = New System.Drawing.Point(396, 15)
        Me.BtBuscaPartidaLote.Name = "BtBuscaPartidaLote"
        Me.BtBuscaPartidaLote.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaPartidaLote.TabIndex = 100368
        Me.BtBuscaPartidaLote.UseVisualStyleBackColor = True
        '
        'LbNomProducto
        '
        Me.LbNomProducto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomProducto.CL_ControlAsociado = Nothing
        Me.LbNomProducto.CL_ValorFijo = False
        Me.LbNomProducto.ClForm = Nothing
        Me.LbNomProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomProducto.Location = New System.Drawing.Point(539, 17)
        Me.LbNomProducto.Name = "LbNomProducto"
        Me.LbNomProducto.Size = New System.Drawing.Size(484, 23)
        Me.LbNomProducto.TabIndex = 100367
        '
        'LbProducto
        '
        Me.LbProducto.AutoSize = True
        Me.LbProducto.CL_ControlAsociado = Nothing
        Me.LbProducto.CL_ValorFijo = True
        Me.LbProducto.ClForm = Nothing
        Me.LbProducto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProducto.ForeColor = System.Drawing.Color.Teal
        Me.LbProducto.Location = New System.Drawing.Point(460, 19)
        Me.LbProducto.Name = "LbProducto"
        Me.LbProducto.Size = New System.Drawing.Size(73, 16)
        Me.LbProducto.TabIndex = 128
        Me.LbProducto.Text = "Producto"
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = True
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigo.Location = New System.Drawing.Point(194, 19)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(65, 16)
        Me.LbCodigo.TabIndex = 127
        Me.LbCodigo.Text = "Numero"
        '
        'TxCodigo
        '
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(265, 16)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(125, 22)
        Me.TxCodigo.TabIndex = 126
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.TxDatoFinalSemana = Nothing
        Me.TxCodigo.TxDatoInicioSemana = Nothing
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(77, 42)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 13)
        Me.Lb2.TabIndex = 125
        Me.Lb2.Text = "T = Palet"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(77, 29)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(59, 13)
        Me.Lb1.TabIndex = 124
        Me.Lb1.Text = "L = Lote"
        '
        'LbExp
        '
        Me.LbExp.AutoSize = True
        Me.LbExp.CL_ControlAsociado = Nothing
        Me.LbExp.CL_ValorFijo = True
        Me.LbExp.ClForm = Nothing
        Me.LbExp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbExp.ForeColor = System.Drawing.Color.Teal
        Me.LbExp.Location = New System.Drawing.Point(77, 16)
        Me.LbExp.Name = "LbExp"
        Me.LbExp.Size = New System.Drawing.Size(79, 13)
        Me.LbExp.TabIndex = 123
        Me.LbExp.Text = "P = Partida"
        '
        'TxTipo
        '
        Me.TxTipo.Autonumerico = False
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
        Me.TxTipo.Location = New System.Drawing.Point(48, 16)
        Me.TxTipo.MiError = False
        Me.TxTipo.Name = "TxTipo"
        Me.TxTipo.Orden = 0
        Me.TxTipo.SaltoAlfinal = False
        Me.TxTipo.Siguiente = 0
        Me.TxTipo.Size = New System.Drawing.Size(23, 22)
        Me.TxTipo.TabIndex = 122
        Me.TxTipo.TeclaRepetida = False
        Me.TxTipo.TxDatoFinalSemana = Nothing
        Me.TxTipo.TxDatoInicioSemana = Nothing
        Me.TxTipo.UltimoValorValidado = Nothing
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = False
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.Teal
        Me.LbTipo.Location = New System.Drawing.Point(6, 19)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(38, 16)
        Me.LbTipo.TabIndex = 121
        Me.LbTipo.Text = "Tipo"
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
        Me.ClGrid1.Location = New System.Drawing.Point(4, 73)
        Me.ClGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1034, 210)
        Me.ClGrid1.TabIndex = 120
        Me.ClGrid1.UltimoControl = 0
        '
        'BtNuevo
        '
        Me.BtNuevo.Image = CType(resources.GetObject("BtNuevo.Image"), System.Drawing.Image)
        Me.BtNuevo.Location = New System.Drawing.Point(191, 18)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Orden = 0
        Me.BtNuevo.PedirClave = True
        Me.BtNuevo.Size = New System.Drawing.Size(26, 23)
        Me.BtNuevo.TabIndex = 75
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1049, 165)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btAnularRecepcion)
        Me.GroupBox1.Controls.Add(Me.TxTractora)
        Me.GroupBox1.Controls.Add(Me.LbTractora)
        Me.GroupBox1.Controls.Add(Me.TxObservaciones)
        Me.GroupBox1.Controls.Add(Me.LbObservaciones)
        Me.GroupBox1.Controls.Add(Me.LbNomCentroDestino)
        Me.GroupBox1.Controls.Add(Me.BtBuscaCentroDestino)
        Me.GroupBox1.Controls.Add(Me.TxCentroDestino)
        Me.GroupBox1.Controls.Add(Me.LbCentroDestino)
        Me.GroupBox1.Controls.Add(Me.TxMatricula)
        Me.GroupBox1.Controls.Add(Me.LbMatricula)
        Me.GroupBox1.Controls.Add(Me.LbNomTransportista)
        Me.GroupBox1.Controls.Add(Me.BtBuscaTransportista)
        Me.GroupBox1.Controls.Add(Me.TxTransportista)
        Me.GroupBox1.Controls.Add(Me.LbTransportista)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BtBuscaTraspaso)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LbNomCentroOrigen)
        Me.GroupBox1.Controls.Add(Me.BtNuevo)
        Me.GroupBox1.Controls.Add(Me.LbNumero)
        Me.GroupBox1.Controls.Add(Me.TxNumero)
        Me.GroupBox1.Controls.Add(Me.BtBuscaCentroOrigen)
        Me.GroupBox1.Controls.Add(Me.TxCentroOrigen)
        Me.GroupBox1.Controls.Add(Me.LbCentroOrigen)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.TxFecha)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1039, 155)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'TxTractora
        '
        Me.TxTractora.Autonumerico = False
        Me.TxTractora.Buscando = False
        Me.TxTractora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTractora.ClForm = Nothing
        Me.TxTractora.ClParam = Nothing
        Me.TxTractora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTractora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTractora.GridLin = Nothing
        Me.TxTractora.HaCambiado = False
        Me.TxTractora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTractora.lbbusca = Nothing
        Me.TxTractora.Location = New System.Drawing.Point(899, 117)
        Me.TxTractora.MiError = False
        Me.TxTractora.Name = "TxTractora"
        Me.TxTractora.Orden = 0
        Me.TxTractora.SaltoAlfinal = False
        Me.TxTractora.Siguiente = 0
        Me.TxTractora.Size = New System.Drawing.Size(124, 22)
        Me.TxTractora.TabIndex = 100376
        Me.TxTractora.TeclaRepetida = False
        Me.TxTractora.TxDatoFinalSemana = Nothing
        Me.TxTractora.TxDatoInicioSemana = Nothing
        Me.TxTractora.UltimoValorValidado = Nothing
        '
        'LbTractora
        '
        Me.LbTractora.AutoSize = True
        Me.LbTractora.CL_ControlAsociado = Nothing
        Me.LbTractora.CL_ValorFijo = False
        Me.LbTractora.ClForm = Nothing
        Me.LbTractora.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTractora.ForeColor = System.Drawing.Color.Teal
        Me.LbTractora.Location = New System.Drawing.Point(777, 120)
        Me.LbTractora.Name = "LbTractora"
        Me.LbTractora.Size = New System.Drawing.Size(105, 16)
        Me.LbTractora.TabIndex = 100375
        Me.LbTractora.Text = "Mat. Tractora"
        '
        'TxObservaciones
        '
        Me.TxObservaciones.Autonumerico = False
        Me.TxObservaciones.Buscando = False
        Me.TxObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObservaciones.ClForm = Nothing
        Me.TxObservaciones.ClParam = Nothing
        Me.TxObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObservaciones.GridLin = Nothing
        Me.TxObservaciones.HaCambiado = False
        Me.TxObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObservaciones.lbbusca = Nothing
        Me.TxObservaciones.Location = New System.Drawing.Point(123, 118)
        Me.TxObservaciones.MiError = False
        Me.TxObservaciones.Name = "TxObservaciones"
        Me.TxObservaciones.Orden = 0
        Me.TxObservaciones.SaltoAlfinal = False
        Me.TxObservaciones.Siguiente = 0
        Me.TxObservaciones.Size = New System.Drawing.Size(599, 22)
        Me.TxObservaciones.TabIndex = 100374
        Me.TxObservaciones.TeclaRepetida = False
        Me.TxObservaciones.TxDatoFinalSemana = Nothing
        Me.TxObservaciones.TxDatoInicioSemana = Nothing
        Me.TxObservaciones.UltimoValorValidado = Nothing
        '
        'LbObservaciones
        '
        Me.LbObservaciones.AutoSize = True
        Me.LbObservaciones.CL_ControlAsociado = Nothing
        Me.LbObservaciones.CL_ValorFijo = False
        Me.LbObservaciones.ClForm = Nothing
        Me.LbObservaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.LbObservaciones.Location = New System.Drawing.Point(6, 122)
        Me.LbObservaciones.Name = "LbObservaciones"
        Me.LbObservaciones.Size = New System.Drawing.Size(116, 16)
        Me.LbObservaciones.TabIndex = 100373
        Me.LbObservaciones.Text = "Observaciones"
        '
        'LbNomCentroDestino
        '
        Me.LbNomCentroDestino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCentroDestino.CL_ControlAsociado = Nothing
        Me.LbNomCentroDestino.CL_ValorFijo = False
        Me.LbNomCentroDestino.ClForm = Nothing
        Me.LbNomCentroDestino.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentroDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentroDestino.Location = New System.Drawing.Point(728, 60)
        Me.LbNomCentroDestino.Name = "LbNomCentroDestino"
        Me.LbNomCentroDestino.Size = New System.Drawing.Size(295, 23)
        Me.LbNomCentroDestino.TabIndex = 100372
        '
        'BtBuscaCentroDestino
        '
        Me.BtBuscaCentroDestino.CL_Ancho = 0
        Me.BtBuscaCentroDestino.CL_BuscaAlb = False
        Me.BtBuscaCentroDestino.CL_campocodigo = Nothing
        Me.BtBuscaCentroDestino.CL_camponombre = Nothing
        Me.BtBuscaCentroDestino.CL_CampoOrden = "Nombre"
        Me.BtBuscaCentroDestino.CL_ch1000 = False
        Me.BtBuscaCentroDestino.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCentroDestino.CL_ControlAsociado = Nothing
        Me.BtBuscaCentroDestino.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCentroDestino.CL_dfecha = Nothing
        Me.BtBuscaCentroDestino.CL_Entidad = Nothing
        Me.BtBuscaCentroDestino.CL_EsId = True
        Me.BtBuscaCentroDestino.CL_Filtro = Nothing
        Me.BtBuscaCentroDestino.cl_formu = Nothing
        Me.BtBuscaCentroDestino.CL_hfecha = Nothing
        Me.BtBuscaCentroDestino.cl_ListaW = Nothing
        Me.BtBuscaCentroDestino.CL_xCentro = False
        Me.BtBuscaCentroDestino.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCentroDestino.Location = New System.Drawing.Point(689, 60)
        Me.BtBuscaCentroDestino.Name = "BtBuscaCentroDestino"
        Me.BtBuscaCentroDestino.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCentroDestino.TabIndex = 100371
        Me.BtBuscaCentroDestino.UseVisualStyleBackColor = True
        '
        'TxCentroDestino
        '
        Me.TxCentroDestino.Autonumerico = False
        Me.TxCentroDestino.Buscando = False
        Me.TxCentroDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentroDestino.ClForm = Nothing
        Me.TxCentroDestino.ClParam = Nothing
        Me.TxCentroDestino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCentroDestino.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentroDestino.GridLin = Nothing
        Me.TxCentroDestino.HaCambiado = False
        Me.TxCentroDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCentroDestino.lbbusca = Nothing
        Me.TxCentroDestino.Location = New System.Drawing.Point(636, 60)
        Me.TxCentroDestino.MiError = False
        Me.TxCentroDestino.Name = "TxCentroDestino"
        Me.TxCentroDestino.Orden = 0
        Me.TxCentroDestino.SaltoAlfinal = False
        Me.TxCentroDestino.Siguiente = 0
        Me.TxCentroDestino.Size = New System.Drawing.Size(53, 22)
        Me.TxCentroDestino.TabIndex = 100370
        Me.TxCentroDestino.TeclaRepetida = False
        Me.TxCentroDestino.TxDatoFinalSemana = Nothing
        Me.TxCentroDestino.TxDatoInicioSemana = Nothing
        Me.TxCentroDestino.UltimoValorValidado = Nothing
        '
        'LbCentroDestino
        '
        Me.LbCentroDestino.AutoSize = True
        Me.LbCentroDestino.CL_ControlAsociado = Nothing
        Me.LbCentroDestino.CL_ValorFijo = False
        Me.LbCentroDestino.ClForm = Nothing
        Me.LbCentroDestino.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentroDestino.ForeColor = System.Drawing.Color.Teal
        Me.LbCentroDestino.Location = New System.Drawing.Point(548, 63)
        Me.LbCentroDestino.Name = "LbCentroDestino"
        Me.LbCentroDestino.Size = New System.Drawing.Size(85, 16)
        Me.LbCentroDestino.TabIndex = 100369
        Me.LbCentroDestino.Text = "Pv Destino"
        '
        'TxMatricula
        '
        Me.TxMatricula.Autonumerico = False
        Me.TxMatricula.Buscando = False
        Me.TxMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMatricula.ClForm = Nothing
        Me.TxMatricula.ClParam = Nothing
        Me.TxMatricula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMatricula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMatricula.GridLin = Nothing
        Me.TxMatricula.HaCambiado = False
        Me.TxMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxMatricula.lbbusca = Nothing
        Me.TxMatricula.Location = New System.Drawing.Point(899, 89)
        Me.TxMatricula.MiError = False
        Me.TxMatricula.Name = "TxMatricula"
        Me.TxMatricula.Orden = 0
        Me.TxMatricula.SaltoAlfinal = False
        Me.TxMatricula.Siguiente = 0
        Me.TxMatricula.Size = New System.Drawing.Size(124, 22)
        Me.TxMatricula.TabIndex = 100368
        Me.TxMatricula.TeclaRepetida = False
        Me.TxMatricula.TxDatoFinalSemana = Nothing
        Me.TxMatricula.TxDatoInicioSemana = Nothing
        Me.TxMatricula.UltimoValorValidado = Nothing
        '
        'LbMatricula
        '
        Me.LbMatricula.AutoSize = True
        Me.LbMatricula.CL_ControlAsociado = Nothing
        Me.LbMatricula.CL_ValorFijo = False
        Me.LbMatricula.ClForm = Nothing
        Me.LbMatricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMatricula.ForeColor = System.Drawing.Color.Teal
        Me.LbMatricula.Location = New System.Drawing.Point(777, 92)
        Me.LbMatricula.Name = "LbMatricula"
        Me.LbMatricula.Size = New System.Drawing.Size(116, 16)
        Me.LbMatricula.TabIndex = 100367
        Me.LbMatricula.Text = "Mat. Remolque"
        '
        'LbNomTransportista
        '
        Me.LbNomTransportista.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomTransportista.CL_ControlAsociado = Nothing
        Me.LbNomTransportista.CL_ValorFijo = False
        Me.LbNomTransportista.ClForm = Nothing
        Me.LbNomTransportista.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTransportista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomTransportista.Location = New System.Drawing.Point(217, 89)
        Me.LbNomTransportista.Name = "LbNomTransportista"
        Me.LbNomTransportista.Size = New System.Drawing.Size(413, 23)
        Me.LbNomTransportista.TabIndex = 100366
        '
        'BtBuscaTransportista
        '
        Me.BtBuscaTransportista.CL_Ancho = 0
        Me.BtBuscaTransportista.CL_BuscaAlb = False
        Me.BtBuscaTransportista.CL_campocodigo = Nothing
        Me.BtBuscaTransportista.CL_camponombre = Nothing
        Me.BtBuscaTransportista.CL_CampoOrden = "Nombre"
        Me.BtBuscaTransportista.CL_ch1000 = False
        Me.BtBuscaTransportista.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTransportista.CL_ControlAsociado = Nothing
        Me.BtBuscaTransportista.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTransportista.CL_dfecha = Nothing
        Me.BtBuscaTransportista.CL_Entidad = Nothing
        Me.BtBuscaTransportista.CL_EsId = True
        Me.BtBuscaTransportista.CL_Filtro = Nothing
        Me.BtBuscaTransportista.cl_formu = Nothing
        Me.BtBuscaTransportista.CL_hfecha = Nothing
        Me.BtBuscaTransportista.cl_ListaW = Nothing
        Me.BtBuscaTransportista.CL_xCentro = False
        Me.BtBuscaTransportista.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTransportista.Location = New System.Drawing.Point(178, 89)
        Me.BtBuscaTransportista.Name = "BtBuscaTransportista"
        Me.BtBuscaTransportista.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTransportista.TabIndex = 100365
        Me.BtBuscaTransportista.UseVisualStyleBackColor = True
        '
        'TxTransportista
        '
        Me.TxTransportista.Autonumerico = False
        Me.TxTransportista.Buscando = False
        Me.TxTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTransportista.ClForm = Nothing
        Me.TxTransportista.ClParam = Nothing
        Me.TxTransportista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTransportista.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTransportista.GridLin = Nothing
        Me.TxTransportista.HaCambiado = False
        Me.TxTransportista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTransportista.lbbusca = Nothing
        Me.TxTransportista.Location = New System.Drawing.Point(123, 89)
        Me.TxTransportista.MiError = False
        Me.TxTransportista.Name = "TxTransportista"
        Me.TxTransportista.Orden = 0
        Me.TxTransportista.SaltoAlfinal = False
        Me.TxTransportista.Siguiente = 0
        Me.TxTransportista.Size = New System.Drawing.Size(53, 22)
        Me.TxTransportista.TabIndex = 100364
        Me.TxTransportista.TeclaRepetida = False
        Me.TxTransportista.TxDatoFinalSemana = Nothing
        Me.TxTransportista.TxDatoInicioSemana = Nothing
        Me.TxTransportista.UltimoValorValidado = Nothing
        '
        'LbTransportista
        '
        Me.LbTransportista.AutoSize = True
        Me.LbTransportista.CL_ControlAsociado = Nothing
        Me.LbTransportista.CL_ValorFijo = False
        Me.LbTransportista.ClForm = Nothing
        Me.LbTransportista.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTransportista.ForeColor = System.Drawing.Color.Teal
        Me.LbTransportista.Location = New System.Drawing.Point(6, 92)
        Me.LbTransportista.Name = "LbTransportista"
        Me.LbTransportista.Size = New System.Drawing.Size(105, 16)
        Me.LbTransportista.TabIndex = 100363
        Me.LbTransportista.Text = "Transportista"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(280, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 100362
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(255, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100361
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'BtBuscaTraspaso
        '
        Me.BtBuscaTraspaso.CL_Ancho = 0
        Me.BtBuscaTraspaso.CL_BuscaAlb = False
        Me.BtBuscaTraspaso.CL_campocodigo = Nothing
        Me.BtBuscaTraspaso.CL_camponombre = Nothing
        Me.BtBuscaTraspaso.CL_CampoOrden = "Nombre"
        Me.BtBuscaTraspaso.CL_ch1000 = False
        Me.BtBuscaTraspaso.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTraspaso.CL_ControlAsociado = Nothing
        Me.BtBuscaTraspaso.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTraspaso.CL_dfecha = Nothing
        Me.BtBuscaTraspaso.CL_Entidad = Nothing
        Me.BtBuscaTraspaso.CL_EsId = True
        Me.BtBuscaTraspaso.CL_Filtro = Nothing
        Me.BtBuscaTraspaso.cl_formu = Nothing
        Me.BtBuscaTraspaso.CL_hfecha = Nothing
        Me.BtBuscaTraspaso.cl_ListaW = Nothing
        Me.BtBuscaTraspaso.CL_xCentro = False
        Me.BtBuscaTraspaso.Image = CType(resources.GetObject("BtBuscaTraspaso.Image"), System.Drawing.Image)
        Me.BtBuscaTraspaso.Location = New System.Drawing.Point(216, 18)
        Me.BtBuscaTraspaso.Name = "BtBuscaTraspaso"
        Me.BtBuscaTraspaso.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTraspaso.TabIndex = 100360
        Me.BtBuscaTraspaso.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Lbejer)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(950, 9)
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
        'LbNomCentroOrigen
        '
        Me.LbNomCentroOrigen.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCentroOrigen.CL_ControlAsociado = Nothing
        Me.LbNomCentroOrigen.CL_ValorFijo = False
        Me.LbNomCentroOrigen.ClForm = Nothing
        Me.LbNomCentroOrigen.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentroOrigen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentroOrigen.Location = New System.Drawing.Point(217, 60)
        Me.LbNomCentroOrigen.Name = "LbNomCentroOrigen"
        Me.LbNomCentroOrigen.Size = New System.Drawing.Size(295, 23)
        Me.LbNomCentroOrigen.TabIndex = 87
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.CL_ControlAsociado = Nothing
        Me.LbNumero.CL_ValorFijo = False
        Me.LbNumero.ClForm = Nothing
        Me.LbNumero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Teal
        Me.LbNumero.Location = New System.Drawing.Point(6, 21)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(65, 16)
        Me.LbNumero.TabIndex = 84
        Me.LbNumero.Text = "Numero"
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
        Me.TxNumero.Location = New System.Drawing.Point(90, 18)
        Me.TxNumero.MiError = False
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Orden = 0
        Me.TxNumero.SaltoAlfinal = False
        Me.TxNumero.Siguiente = 0
        Me.TxNumero.Size = New System.Drawing.Size(101, 22)
        Me.TxNumero.TabIndex = 83
        Me.TxNumero.TeclaRepetida = False
        Me.TxNumero.TxDatoFinalSemana = Nothing
        Me.TxNumero.TxDatoInicioSemana = Nothing
        Me.TxNumero.UltimoValorValidado = Nothing
        '
        'BtBuscaCentroOrigen
        '
        Me.BtBuscaCentroOrigen.CL_Ancho = 0
        Me.BtBuscaCentroOrigen.CL_BuscaAlb = False
        Me.BtBuscaCentroOrigen.CL_campocodigo = Nothing
        Me.BtBuscaCentroOrigen.CL_camponombre = Nothing
        Me.BtBuscaCentroOrigen.CL_CampoOrden = "Nombre"
        Me.BtBuscaCentroOrigen.CL_ch1000 = False
        Me.BtBuscaCentroOrigen.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCentroOrigen.CL_ControlAsociado = Nothing
        Me.BtBuscaCentroOrigen.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCentroOrigen.CL_dfecha = Nothing
        Me.BtBuscaCentroOrigen.CL_Entidad = Nothing
        Me.BtBuscaCentroOrigen.CL_EsId = True
        Me.BtBuscaCentroOrigen.CL_Filtro = Nothing
        Me.BtBuscaCentroOrigen.cl_formu = Nothing
        Me.BtBuscaCentroOrigen.CL_hfecha = Nothing
        Me.BtBuscaCentroOrigen.cl_ListaW = Nothing
        Me.BtBuscaCentroOrigen.CL_xCentro = False
        Me.BtBuscaCentroOrigen.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCentroOrigen.Location = New System.Drawing.Point(178, 60)
        Me.BtBuscaCentroOrigen.Name = "BtBuscaCentroOrigen"
        Me.BtBuscaCentroOrigen.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCentroOrigen.TabIndex = 82
        Me.BtBuscaCentroOrigen.UseVisualStyleBackColor = True
        '
        'TxCentroOrigen
        '
        Me.TxCentroOrigen.Autonumerico = False
        Me.TxCentroOrigen.Buscando = False
        Me.TxCentroOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentroOrigen.ClForm = Nothing
        Me.TxCentroOrigen.ClParam = Nothing
        Me.TxCentroOrigen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCentroOrigen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentroOrigen.GridLin = Nothing
        Me.TxCentroOrigen.HaCambiado = False
        Me.TxCentroOrigen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCentroOrigen.lbbusca = Nothing
        Me.TxCentroOrigen.Location = New System.Drawing.Point(123, 60)
        Me.TxCentroOrigen.MiError = False
        Me.TxCentroOrigen.Name = "TxCentroOrigen"
        Me.TxCentroOrigen.Orden = 0
        Me.TxCentroOrigen.SaltoAlfinal = False
        Me.TxCentroOrigen.Siguiente = 0
        Me.TxCentroOrigen.Size = New System.Drawing.Size(53, 22)
        Me.TxCentroOrigen.TabIndex = 81
        Me.TxCentroOrigen.TeclaRepetida = False
        Me.TxCentroOrigen.TxDatoFinalSemana = Nothing
        Me.TxCentroOrigen.TxDatoInicioSemana = Nothing
        Me.TxCentroOrigen.UltimoValorValidado = Nothing
        '
        'LbCentroOrigen
        '
        Me.LbCentroOrigen.AutoSize = True
        Me.LbCentroOrigen.CL_ControlAsociado = Nothing
        Me.LbCentroOrigen.CL_ValorFijo = False
        Me.LbCentroOrigen.ClForm = Nothing
        Me.LbCentroOrigen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentroOrigen.ForeColor = System.Drawing.Color.Teal
        Me.LbCentroOrigen.Location = New System.Drawing.Point(6, 63)
        Me.LbCentroOrigen.Name = "LbCentroOrigen"
        Me.LbCentroOrigen.Size = New System.Drawing.Size(78, 16)
        Me.LbCentroOrigen.TabIndex = 80
        Me.LbCentroOrigen.Text = "Pv Origen"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(309, 21)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 79
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(367, 18)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxFecha.TabIndex = 78
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'btAnularRecepcion
        '
        Me.btAnularRecepcion.BackColor = System.Drawing.Color.IndianRed
        Me.btAnularRecepcion.FlatAppearance.BorderSize = 0
        Me.btAnularRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAnularRecepcion.ForeColor = System.Drawing.Color.White
        Me.btAnularRecepcion.Location = New System.Drawing.Point(780, 23)
        Me.btAnularRecepcion.Name = "btAnularRecepcion"
        Me.btAnularRecepcion.Orden = 0
        Me.btAnularRecepcion.PedirClave = True
        Me.btAnularRecepcion.Size = New System.Drawing.Size(152, 23)
        Me.btAnularRecepcion.TabIndex = 100377
        Me.btAnularRecepcion.Text = "Anular recepción"
        Me.btAnularRecepcion.UseVisualStyleBackColor = False
        Me.btAnularRecepcion.Visible = False
        '
        'FrmTraspasosCentros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 495)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTraspasosCentros"
        Me.Text = "Traspasos entre centros"
        Me.TextoPreguntaImpresion = "¿Desea imprimir el pedido?"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtNuevo As NetAgro.ClButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents BtBuscaCentroOrigen As NetAgro.BtBusca
    Friend WithEvents TxCentroOrigen As NetAgro.TxDato
    Friend WithEvents LbCentroOrigen As NetAgro.Lb
    Friend WithEvents LbNomCentroOrigen As NetAgro.Lb
    Friend WithEvents LbNumero As NetAgro.Lb
    Friend WithEvents TxNumero As NetAgro.TxDato
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents BtBuscaTraspaso As NetAgro.BtBusca
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxMatricula As NetAgro.TxDato
    Friend WithEvents LbMatricula As NetAgro.Lb
    Friend WithEvents LbNomTransportista As NetAgro.Lb
    Friend WithEvents BtBuscaTransportista As NetAgro.BtBusca
    Friend WithEvents TxTransportista As NetAgro.TxDato
    Friend WithEvents LbTransportista As NetAgro.Lb
    Friend WithEvents LbNomCentroDestino As NetAgro.Lb
    Friend WithEvents BtBuscaCentroDestino As NetAgro.BtBusca
    Friend WithEvents TxCentroDestino As NetAgro.TxDato
    Friend WithEvents LbCentroDestino As NetAgro.Lb
    Friend WithEvents TxObservaciones As NetAgro.TxDato
    Friend WithEvents LbObservaciones As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbExp As NetAgro.Lb
    Friend WithEvents TxTipo As NetAgro.TxDato
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents LbNomProducto As NetAgro.Lb
    Friend WithEvents LbProducto As NetAgro.Lb
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents BtBuscaPartidaLote As System.Windows.Forms.Button
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxTractora As NetAgro.TxDato
    Friend WithEvents LbTractora As NetAgro.Lb
    Friend WithEvents btAnularRecepcion As NetAgro.ClButton

End Class
