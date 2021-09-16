<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoracionNoFirme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoracionNoFirme))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxTipoPrecio = New NetAgro.TxDato(Me.components)
        Me.LbNuvalora = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxFechaValoracion = New NetAgro.TxDato(Me.components)
        Me.LbFechaValoracion = New NetAgro.Lb(Me.components)
        Me.LbFechaMuestreo = New NetAgro.Lb(Me.components)
        Me.LbPrecioCompra = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.LbFc = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbBascu4 = New NetAgro.Lb(Me.components)
        Me.LbBascu3 = New NetAgro.Lb(Me.components)
        Me.LbBascu2 = New NetAgro.Lb(Me.components)
        Me.LbBascu1 = New NetAgro.Lb(Me.components)
        Me.LbAlba = New NetAgro.Lb(Me.components)
        Me.Lb28 = New NetAgro.Lb(Me.components)
        Me.Lb31 = New NetAgro.Lb(Me.components)
        Me.Lb32 = New NetAgro.Lb(Me.components)
        Me.Lb33 = New NetAgro.Lb(Me.components)
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.Lb27 = New NetAgro.Lb(Me.components)
        Me.LbUdsPartida = New NetAgro.Lb(Me.components)
        Me.LbUdsPartida_1 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.LbNomPv = New NetAgro.Lb(Me.components)
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbNomCategoria = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.TxPrecio = New NetAgro.TxDato(Me.components)
        Me.Lbuds_1 = New NetAgro.Lb(Me.components)
        Me.LbObservaciones = New NetAgro.Lb(Me.components)
        Me.TxObservaciones = New NetAgro.TxDato(Me.components)
        Me.TxObsProveedor = New NetAgro.TxDato(Me.components)
        Me.LbObsProveedor = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel4.Controls.Add(Me.TxTipoPrecio)
        Me.Panel4.Controls.Add(Me.LbNuvalora)
        Me.Panel4.Controls.Add(Me.Lb8)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Controls.Add(Me.TxFechaValoracion)
        Me.Panel4.Controls.Add(Me.LbFechaValoracion)
        Me.Panel4.Controls.Add(Me.LbFechaMuestreo)
        Me.Panel4.Controls.Add(Me.LbPrecioCompra)
        Me.Panel4.Controls.Add(Me.Lb13)
        Me.Panel4.Controls.Add(Me.LbFc)
        Me.Panel4.Controls.Add(Me.Lb10)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.LbBascu4)
        Me.Panel4.Controls.Add(Me.LbBascu3)
        Me.Panel4.Controls.Add(Me.LbBascu2)
        Me.Panel4.Controls.Add(Me.LbBascu1)
        Me.Panel4.Controls.Add(Me.LbAlba)
        Me.Panel4.Controls.Add(Me.Lb28)
        Me.Panel4.Controls.Add(Me.Lb31)
        Me.Panel4.Controls.Add(Me.Lb32)
        Me.Panel4.Controls.Add(Me.Lb33)
        Me.Panel4.Controls.Add(Me.Lb26)
        Me.Panel4.Controls.Add(Me.Lb27)
        Me.Panel4.Controls.Add(Me.LbUdsPartida)
        Me.Panel4.Controls.Add(Me.LbUdsPartida_1)
        Me.Panel4.Controls.Add(Me.LbFecha)
        Me.Panel4.Controls.Add(Me.LbNomPv)
        Me.Panel4.Controls.Add(Me.LbPuntoVenta)
        Me.Panel4.Controls.Add(Me.Lb29)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Lb9)
        Me.Panel4.Controls.Add(Me.Lb19)
        Me.Panel4.Controls.Add(Me.Lb3)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(817, 185)
        Me.Panel4.TabIndex = 72
        '
        'TxTipoPrecio
        '
        Me.TxTipoPrecio.Autonumerico = False
        Me.TxTipoPrecio.Buscando = False
        Me.TxTipoPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipoPrecio.ClForm = Nothing
        Me.TxTipoPrecio.ClParam = Nothing
        Me.TxTipoPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTipoPrecio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipoPrecio.GridLin = Nothing
        Me.TxTipoPrecio.HaCambiado = False
        Me.TxTipoPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTipoPrecio.lbbusca = Nothing
        Me.TxTipoPrecio.Location = New System.Drawing.Point(772, 148)
        Me.TxTipoPrecio.MiError = False
        Me.TxTipoPrecio.Name = "TxTipoPrecio"
        Me.TxTipoPrecio.Orden = 0
        Me.TxTipoPrecio.SaltoAlfinal = False
        Me.TxTipoPrecio.Siguiente = 0
        Me.TxTipoPrecio.Size = New System.Drawing.Size(32, 22)
        Me.TxTipoPrecio.TabIndex = 165
        Me.TxTipoPrecio.TeclaRepetida = False
        Me.TxTipoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxTipoPrecio.TxDatoFinalSemana = Nothing
        Me.TxTipoPrecio.TxDatoInicioSemana = Nothing
        Me.TxTipoPrecio.UltimoValorValidado = Nothing
        '
        'LbNuvalora
        '
        Me.LbNuvalora.BackColor = System.Drawing.Color.White
        Me.LbNuvalora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNuvalora.CL_ControlAsociado = Nothing
        Me.LbNuvalora.CL_ValorFijo = False
        Me.LbNuvalora.ClForm = Nothing
        Me.LbNuvalora.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuvalora.ForeColor = System.Drawing.Color.Teal
        Me.LbNuvalora.Location = New System.Drawing.Point(680, 116)
        Me.LbNuvalora.Name = "LbNuvalora"
        Me.LbNuvalora.Size = New System.Drawing.Size(86, 21)
        Me.LbNuvalora.TabIndex = 164
        Me.LbNuvalora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(543, 118)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(107, 16)
        Me.Lb8.TabIndex = 163
        Me.Lb8.Text = "Nº Valoración"
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
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(235, 13)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 162
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(112, 14)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(117, 22)
        Me.TxDato1.TabIndex = 65
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxFechaValoracion.Location = New System.Drawing.Point(680, 83)
        Me.TxFechaValoracion.MiError = False
        Me.TxFechaValoracion.Name = "TxFechaValoracion"
        Me.TxFechaValoracion.Orden = 0
        Me.TxFechaValoracion.SaltoAlfinal = False
        Me.TxFechaValoracion.Siguiente = 0
        Me.TxFechaValoracion.Size = New System.Drawing.Size(117, 22)
        Me.TxFechaValoracion.TabIndex = 161
        Me.TxFechaValoracion.TeclaRepetida = False
        Me.TxFechaValoracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxFechaValoracion.TxDatoFinalSemana = Nothing
        Me.TxFechaValoracion.TxDatoInicioSemana = Nothing
        Me.TxFechaValoracion.UltimoValorValidado = Nothing
        '
        'LbFechaValoracion
        '
        Me.LbFechaValoracion.AutoSize = True
        Me.LbFechaValoracion.CL_ControlAsociado = Nothing
        Me.LbFechaValoracion.CL_ValorFijo = True
        Me.LbFechaValoracion.ClForm = Nothing
        Me.LbFechaValoracion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaValoracion.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaValoracion.Location = New System.Drawing.Point(543, 86)
        Me.LbFechaValoracion.Name = "LbFechaValoracion"
        Me.LbFechaValoracion.Size = New System.Drawing.Size(132, 16)
        Me.LbFechaValoracion.TabIndex = 160
        Me.LbFechaValoracion.Text = "Fecha valoración"
        '
        'LbFechaMuestreo
        '
        Me.LbFechaMuestreo.BackColor = System.Drawing.Color.White
        Me.LbFechaMuestreo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFechaMuestreo.CL_ControlAsociado = Nothing
        Me.LbFechaMuestreo.CL_ValorFijo = False
        Me.LbFechaMuestreo.ClForm = Nothing
        Me.LbFechaMuestreo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaMuestreo.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaMuestreo.Location = New System.Drawing.Point(380, 147)
        Me.LbFechaMuestreo.Name = "LbFechaMuestreo"
        Me.LbFechaMuestreo.Size = New System.Drawing.Size(115, 22)
        Me.LbFechaMuestreo.TabIndex = 159
        Me.LbFechaMuestreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbPrecioCompra
        '
        Me.LbPrecioCompra.BackColor = System.Drawing.Color.White
        Me.LbPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbPrecioCompra.CL_ControlAsociado = Nothing
        Me.LbPrecioCompra.CL_ValorFijo = False
        Me.LbPrecioCompra.ClForm = Nothing
        Me.LbPrecioCompra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecioCompra.ForeColor = System.Drawing.Color.Teal
        Me.LbPrecioCompra.Location = New System.Drawing.Point(680, 148)
        Me.LbPrecioCompra.Name = "LbPrecioCompra"
        Me.LbPrecioCompra.Size = New System.Drawing.Size(86, 21)
        Me.LbPrecioCompra.TabIndex = 157
        Me.LbPrecioCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(543, 150)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(114, 16)
        Me.Lb13.TabIndex = 156
        Me.Lb13.Text = "Precio Compra"
        '
        'LbFc
        '
        Me.LbFc.BackColor = System.Drawing.Color.White
        Me.LbFc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFc.CL_ControlAsociado = Nothing
        Me.LbFc.CL_ValorFijo = False
        Me.LbFc.ClForm = Nothing
        Me.LbFc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFc.ForeColor = System.Drawing.Color.Teal
        Me.LbFc.Location = New System.Drawing.Point(380, 116)
        Me.LbFc.Name = "LbFc"
        Me.LbFc.Size = New System.Drawing.Size(24, 21)
        Me.LbFc.TabIndex = 155
        Me.LbFc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(239, 118)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(126, 16)
        Me.Lb10.TabIndex = 154
        Me.Lb10.Text = "Tipo Firme/Com"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(595, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 153
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(573, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbBascu4
        '
        Me.LbBascu4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbBascu4.CL_ControlAsociado = Nothing
        Me.LbBascu4.CL_ValorFijo = True
        Me.LbBascu4.ClForm = Nothing
        Me.LbBascu4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBascu4.ForeColor = System.Drawing.Color.Teal
        Me.LbBascu4.Location = New System.Drawing.Point(731, 17)
        Me.LbBascu4.Name = "LbBascu4"
        Me.LbBascu4.Size = New System.Drawing.Size(27, 16)
        Me.LbBascu4.TabIndex = 151
        Me.LbBascu4.Text = "4"
        Me.LbBascu4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbBascu3
        '
        Me.LbBascu3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbBascu3.CL_ControlAsociado = Nothing
        Me.LbBascu3.CL_ValorFijo = True
        Me.LbBascu3.ClForm = Nothing
        Me.LbBascu3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBascu3.ForeColor = System.Drawing.Color.Teal
        Me.LbBascu3.Location = New System.Drawing.Point(700, 17)
        Me.LbBascu3.Name = "LbBascu3"
        Me.LbBascu3.Size = New System.Drawing.Size(27, 16)
        Me.LbBascu3.TabIndex = 150
        Me.LbBascu3.Text = "3"
        Me.LbBascu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbBascu2
        '
        Me.LbBascu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbBascu2.CL_ControlAsociado = Nothing
        Me.LbBascu2.CL_ValorFijo = True
        Me.LbBascu2.ClForm = Nothing
        Me.LbBascu2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBascu2.ForeColor = System.Drawing.Color.Teal
        Me.LbBascu2.Location = New System.Drawing.Point(667, 17)
        Me.LbBascu2.Name = "LbBascu2"
        Me.LbBascu2.Size = New System.Drawing.Size(27, 16)
        Me.LbBascu2.TabIndex = 149
        Me.LbBascu2.Text = "2"
        Me.LbBascu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbBascu1
        '
        Me.LbBascu1.BackColor = System.Drawing.Color.White
        Me.LbBascu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbBascu1.CL_ControlAsociado = Nothing
        Me.LbBascu1.CL_ValorFijo = True
        Me.LbBascu1.ClForm = Nothing
        Me.LbBascu1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBascu1.ForeColor = System.Drawing.Color.Teal
        Me.LbBascu1.Location = New System.Drawing.Point(634, 17)
        Me.LbBascu1.Name = "LbBascu1"
        Me.LbBascu1.Size = New System.Drawing.Size(27, 16)
        Me.LbBascu1.TabIndex = 148
        Me.LbBascu1.Text = "1"
        Me.LbBascu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbAlba
        '
        Me.LbAlba.BackColor = System.Drawing.Color.White
        Me.LbAlba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAlba.CL_ControlAsociado = Nothing
        Me.LbAlba.CL_ValorFijo = False
        Me.LbAlba.ClForm = Nothing
        Me.LbAlba.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlba.ForeColor = System.Drawing.Color.Teal
        Me.LbAlba.Location = New System.Drawing.Point(112, 116)
        Me.LbAlba.Name = "LbAlba"
        Me.LbAlba.Size = New System.Drawing.Size(117, 21)
        Me.LbAlba.TabIndex = 147
        Me.LbAlba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb28
        '
        Me.Lb28.AutoSize = True
        Me.Lb28.CL_ControlAsociado = Nothing
        Me.Lb28.CL_ValorFijo = True
        Me.Lb28.ClForm = Nothing
        Me.Lb28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb28.ForeColor = System.Drawing.Color.Teal
        Me.Lb28.Location = New System.Drawing.Point(10, 118)
        Me.Lb28.Name = "Lb28"
        Me.Lb28.Size = New System.Drawing.Size(64, 16)
        Me.Lb28.TabIndex = 146
        Me.Lb28.Text = "Albarán"
        '
        'Lb31
        '
        Me.Lb31.BackColor = System.Drawing.Color.White
        Me.Lb31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb31.CL_ControlAsociado = Nothing
        Me.Lb31.CL_ValorFijo = False
        Me.Lb31.ClForm = Nothing
        Me.Lb31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb31.ForeColor = System.Drawing.Color.Teal
        Me.Lb31.Location = New System.Drawing.Point(112, 84)
        Me.Lb31.Name = "Lb31"
        Me.Lb31.Size = New System.Drawing.Size(75, 21)
        Me.Lb31.TabIndex = 126
        Me.Lb31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb32
        '
        Me.Lb32.BackColor = System.Drawing.Color.Gainsboro
        Me.Lb32.CL_ControlAsociado = Nothing
        Me.Lb32.CL_ValorFijo = False
        Me.Lb32.ClForm = Nothing
        Me.Lb32.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb32.Location = New System.Drawing.Point(193, 83)
        Me.Lb32.Name = "Lb32"
        Me.Lb32.Size = New System.Drawing.Size(323, 23)
        Me.Lb32.TabIndex = 125
        '
        'Lb33
        '
        Me.Lb33.AutoSize = True
        Me.Lb33.CL_ControlAsociado = Nothing
        Me.Lb33.CL_ValorFijo = True
        Me.Lb33.ClForm = Nothing
        Me.Lb33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb33.ForeColor = System.Drawing.Color.Teal
        Me.Lb33.Location = New System.Drawing.Point(10, 86)
        Me.Lb33.Name = "Lb33"
        Me.Lb33.Size = New System.Drawing.Size(60, 16)
        Me.Lb33.TabIndex = 124
        Me.Lb33.Text = "Genero"
        '
        'Lb26
        '
        Me.Lb26.AutoSize = True
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = True
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.ForeColor = System.Drawing.Color.Teal
        Me.Lb26.Location = New System.Drawing.Point(239, 150)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(126, 16)
        Me.Lb26.TabIndex = 123
        Me.Lb26.Text = "Fecha muestreo"
        '
        'Lb27
        '
        Me.Lb27.BackColor = System.Drawing.Color.White
        Me.Lb27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb27.CL_ControlAsociado = Nothing
        Me.Lb27.CL_ValorFijo = False
        Me.Lb27.ClForm = Nothing
        Me.Lb27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb27.ForeColor = System.Drawing.Color.Teal
        Me.Lb27.Location = New System.Drawing.Point(112, 52)
        Me.Lb27.Name = "Lb27"
        Me.Lb27.Size = New System.Drawing.Size(75, 21)
        Me.Lb27.TabIndex = 119
        Me.Lb27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUdsPartida
        '
        Me.LbUdsPartida.BackColor = System.Drawing.Color.White
        Me.LbUdsPartida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbUdsPartida.CL_ControlAsociado = Nothing
        Me.LbUdsPartida.CL_ValorFijo = False
        Me.LbUdsPartida.ClForm = Nothing
        Me.LbUdsPartida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUdsPartida.ForeColor = System.Drawing.Color.Teal
        Me.LbUdsPartida.Location = New System.Drawing.Point(112, 148)
        Me.LbUdsPartida.Name = "LbUdsPartida"
        Me.LbUdsPartida.Size = New System.Drawing.Size(96, 21)
        Me.LbUdsPartida.TabIndex = 118
        Me.LbUdsPartida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbUdsPartida_1
        '
        Me.LbUdsPartida_1.AutoSize = True
        Me.LbUdsPartida_1.CL_ControlAsociado = Nothing
        Me.LbUdsPartida_1.CL_ValorFijo = True
        Me.LbUdsPartida_1.ClForm = Nothing
        Me.LbUdsPartida_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUdsPartida_1.ForeColor = System.Drawing.Color.Teal
        Me.LbUdsPartida_1.Location = New System.Drawing.Point(10, 150)
        Me.LbUdsPartida_1.Name = "LbUdsPartida_1"
        Me.LbUdsPartida_1.Size = New System.Drawing.Size(98, 16)
        Me.LbUdsPartida_1.TabIndex = 117
        Me.LbUdsPartida_1.Text = "Kilos partida"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.Color.White
        Me.LbFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(680, 52)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(117, 21)
        Me.LbFecha.TabIndex = 116
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LbNomPv.Location = New System.Drawing.Point(429, 15)
        Me.LbNomPv.Name = "LbNomPv"
        Me.LbNomPv.Size = New System.Drawing.Size(117, 21)
        Me.LbNomPv.TabIndex = 112
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
        Me.LbPuntoVenta.Location = New System.Drawing.Point(395, 15)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(28, 21)
        Me.LbPuntoVenta.TabIndex = 111
        Me.LbPuntoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = True
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(362, 17)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(27, 16)
        Me.Lb29.TabIndex = 89
        Me.Lb29.Text = "PV"
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
        Me.LbCampa.Location = New System.Drawing.Point(72, 15)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        Me.LbCampa.Text = "13"
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(543, 54)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(113, 16)
        Me.Lb9.TabIndex = 77
        Me.Lb9.Text = "Fecha Entrada"
        '
        'Lb19
        '
        Me.Lb19.BackColor = System.Drawing.Color.Gainsboro
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = False
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb19.Location = New System.Drawing.Point(193, 51)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(323, 23)
        Me.Lb19.TabIndex = 74
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(10, 54)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(79, 16)
        Me.Lb3.TabIndex = 72
        Me.Lb3.Text = "Agricultor"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(10, 17)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(60, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Partida"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LbCategoria)
        Me.Panel2.Controls.Add(Me.LbKilos)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.LbImporte)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.LbNomCategoria)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Controls.Add(Me.TxPrecio)
        Me.Panel2.Controls.Add(Me.Lbuds_1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 294)
        Me.Panel2.TabIndex = 128
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.Color.White
        Me.LbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = False
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Teal
        Me.LbCategoria.Location = New System.Drawing.Point(17, 34)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(53, 22)
        Me.LbCategoria.TabIndex = 150
        Me.LbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.Color.White
        Me.LbKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(380, 34)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(90, 22)
        Me.LbKilos.TabIndex = 149
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(612, 15)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(67, 16)
        Me.Lb7.TabIndex = 148
        Me.Lb7.Text = "Importe"
        '
        'LbImporte
        '
        Me.LbImporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbImporte.Location = New System.Drawing.Point(578, 34)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(127, 23)
        Me.LbImporte.TabIndex = 147
        Me.LbImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(507, 15)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(53, 16)
        Me.Lb5.TabIndex = 145
        Me.Lb5.Text = "Precio"
        '
        'LbNomCategoria
        '
        Me.LbNomCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategoria.CL_ControlAsociado = Nothing
        Me.LbNomCategoria.CL_ValorFijo = False
        Me.LbNomCategoria.ClForm = Nothing
        Me.LbNomCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategoria.Location = New System.Drawing.Point(76, 34)
        Me.LbNomCategoria.Name = "LbNomCategoria"
        Me.LbNomCategoria.Size = New System.Drawing.Size(283, 23)
        Me.LbNomCategoria.TabIndex = 143
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(10, 15)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(79, 16)
        Me.Lb4.TabIndex = 141
        Me.Lb4.Text = "Categoria"
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
        Me.ClGrid1.Location = New System.Drawing.Point(10, 63)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(800, 223)
        Me.ClGrid1.TabIndex = 109
        Me.ClGrid1.UltimoControl = 0
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
        Me.TxPrecio.Location = New System.Drawing.Point(476, 34)
        Me.TxPrecio.MiError = False
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Orden = 0
        Me.TxPrecio.SaltoAlfinal = False
        Me.TxPrecio.Siguiente = 0
        Me.TxPrecio.Size = New System.Drawing.Size(90, 22)
        Me.TxPrecio.TabIndex = 133
        Me.TxPrecio.TeclaRepetida = False
        Me.TxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPrecio.TxDatoFinalSemana = Nothing
        Me.TxPrecio.TxDatoInicioSemana = Nothing
        Me.TxPrecio.UltimoValorValidado = Nothing
        '
        'Lbuds_1
        '
        Me.Lbuds_1.AutoSize = True
        Me.Lbuds_1.CL_ControlAsociado = Nothing
        Me.Lbuds_1.CL_ValorFijo = True
        Me.Lbuds_1.ClForm = Nothing
        Me.Lbuds_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbuds_1.ForeColor = System.Drawing.Color.Teal
        Me.Lbuds_1.Location = New System.Drawing.Point(411, 15)
        Me.Lbuds_1.Name = "Lbuds_1"
        Me.Lbuds_1.Size = New System.Drawing.Size(46, 16)
        Me.Lbuds_1.TabIndex = 126
        Me.Lbuds_1.Text = "Kilos "
        '
        'LbObservaciones
        '
        Me.LbObservaciones.AutoSize = True
        Me.LbObservaciones.CL_ControlAsociado = Nothing
        Me.LbObservaciones.CL_ValorFijo = True
        Me.LbObservaciones.ClForm = Nothing
        Me.LbObservaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.LbObservaciones.Location = New System.Drawing.Point(12, 492)
        Me.LbObservaciones.Name = "LbObservaciones"
        Me.LbObservaciones.Size = New System.Drawing.Size(105, 16)
        Me.LbObservaciones.TabIndex = 129
        Me.LbObservaciones.Text = "Obs. internas"
        '
        'TxObservaciones
        '
        Me.TxObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TxObservaciones.Location = New System.Drawing.Point(134, 490)
        Me.TxObservaciones.MiError = False
        Me.TxObservaciones.Name = "TxObservaciones"
        Me.TxObservaciones.Orden = 0
        Me.TxObservaciones.SaltoAlfinal = False
        Me.TxObservaciones.Siguiente = 0
        Me.TxObservaciones.Size = New System.Drawing.Size(671, 22)
        Me.TxObservaciones.TabIndex = 130
        Me.TxObservaciones.TeclaRepetida = False
        Me.TxObservaciones.TxDatoFinalSemana = Nothing
        Me.TxObservaciones.TxDatoInicioSemana = Nothing
        Me.TxObservaciones.UltimoValorValidado = Nothing
        '
        'TxObsProveedor
        '
        Me.TxObsProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxObsProveedor.Autonumerico = False
        Me.TxObsProveedor.Buscando = False
        Me.TxObsProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObsProveedor.ClForm = Nothing
        Me.TxObsProveedor.ClParam = Nothing
        Me.TxObsProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObsProveedor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObsProveedor.GridLin = Nothing
        Me.TxObsProveedor.HaCambiado = False
        Me.TxObsProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObsProveedor.lbbusca = Nothing
        Me.TxObsProveedor.Location = New System.Drawing.Point(134, 518)
        Me.TxObsProveedor.MiError = False
        Me.TxObsProveedor.Name = "TxObsProveedor"
        Me.TxObsProveedor.Orden = 0
        Me.TxObsProveedor.SaltoAlfinal = False
        Me.TxObsProveedor.Siguiente = 0
        Me.TxObsProveedor.Size = New System.Drawing.Size(671, 22)
        Me.TxObsProveedor.TabIndex = 132
        Me.TxObsProveedor.TeclaRepetida = False
        Me.TxObsProveedor.TxDatoFinalSemana = Nothing
        Me.TxObsProveedor.TxDatoInicioSemana = Nothing
        Me.TxObsProveedor.UltimoValorValidado = Nothing
        '
        'LbObsProveedor
        '
        Me.LbObsProveedor.AutoSize = True
        Me.LbObsProveedor.CL_ControlAsociado = Nothing
        Me.LbObsProveedor.CL_ValorFijo = True
        Me.LbObsProveedor.ClForm = Nothing
        Me.LbObsProveedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObsProveedor.ForeColor = System.Drawing.Color.Teal
        Me.LbObsProveedor.Location = New System.Drawing.Point(12, 520)
        Me.LbObsProveedor.Name = "LbObsProveedor"
        Me.LbObsProveedor.Size = New System.Drawing.Size(120, 16)
        Me.LbObsProveedor.TabIndex = 131
        Me.LbObsProveedor.Text = "Obs. proveedor"
        '
        'FrmValoracionNoFirme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 603)
        Me.Controls.Add(Me.TxObsProveedor)
        Me.Controls.Add(Me.LbObsProveedor)
        Me.Controls.Add(Me.TxObservaciones)
        Me.Controls.Add(Me.LbObservaciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValoracionNoFirme"
        Me.Text = "Valoración entradas No Firme"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.LbObservaciones, 0)
        Me.Controls.SetChildIndex(Me.TxObservaciones, 0)
        Me.Controls.SetChildIndex(Me.LbObsProveedor, 0)
        Me.Controls.SetChildIndex(Me.TxObsProveedor, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb31 As NetAgro.Lb
    Friend WithEvents Lb32 As NetAgro.Lb
    Friend WithEvents Lb33 As NetAgro.Lb
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents Lb27 As NetAgro.Lb
    Friend WithEvents LbUdsPartida As NetAgro.Lb
    Friend WithEvents LbUdsPartida_1 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbNomCategoria As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxPrecio As NetAgro.TxDato
    Friend WithEvents Lbuds_1 As NetAgro.Lb
    Friend WithEvents LbAlba As NetAgro.Lb
    Friend WithEvents Lb28 As NetAgro.Lb
    Friend WithEvents LbNomPv As NetAgro.Lb
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents LbBascu4 As NetAgro.Lb
    Friend WithEvents LbBascu3 As NetAgro.Lb
    Friend WithEvents LbBascu2 As NetAgro.Lb
    Friend WithEvents LbBascu1 As NetAgro.Lb
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbPrecioCompra As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents LbFc As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbObservaciones As NetAgro.Lb
    Friend WithEvents TxObservaciones As NetAgro.TxDato
    Friend WithEvents TxObsProveedor As NetAgro.TxDato
    Friend WithEvents LbObsProveedor As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents LbFechaMuestreo As NetAgro.Lb
    Friend WithEvents LbFechaValoracion As NetAgro.Lb
    Friend WithEvents TxFechaValoracion As NetAgro.TxDato
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents LbNuvalora As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents TxTipoPrecio As NetAgro.TxDato

End Class
