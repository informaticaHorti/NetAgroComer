<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCartelones
    Inherits System.Windows.Forms.Form

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
        Me.pnlSerieFactura = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.FontDialog3 = New System.Windows.Forms.FontDialog()
        Me.FontDialog4 = New System.Windows.Forms.FontDialog()
        Me.FontDialog5 = New System.Windows.Forms.FontDialog()
        Me.TxBultos = New NetAgro.TxDato(Me.components)
        Me.TxFechaConfeccion = New NetAgro.TxDato(Me.components)
        Me.TxFechaSalida = New NetAgro.TxDato(Me.components)
        Me.TxCategoria = New NetAgro.TxDato(Me.components)
        Me.TxPresentacion = New NetAgro.TxDato(Me.components)
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.LbFechaConfeccion = New NetAgro.Lb(Me.components)
        Me.LbFechaSalida = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.LbPresentacion = New NetAgro.Lb(Me.components)
        Me.LbCopias = New NetAgro.Lb(Me.components)
        Me.TxCopias = New NetAgro.TxDato(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClButton1 = New NetAgro.ClButton()
        Me.btFuentePresentacion = New System.Windows.Forms.Button()
        Me.btCancelar = New NetAgro.ClButton()
        Me.BtAceptar = New NetAgro.ClButton()
        Me.btFuenteCategoria = New System.Windows.Forms.Button()
        Me.btFuenteFechaSalida = New System.Windows.Forms.Button()
        Me.btFuenteFechaConfeccion = New System.Windows.Forms.Button()
        Me.btFuenteBultos = New System.Windows.Forms.Button()
        Me.pnlSerieFactura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.ClButton1)
        Me.pnlSerieFactura.Controls.Add(Me.GroupBox1)
        Me.pnlSerieFactura.Controls.Add(Me.btCancelar)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Controls.Add(Me.LbCopias)
        Me.pnlSerieFactura.Controls.Add(Me.TxCopias)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(558, 433)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btFuenteBultos)
        Me.GroupBox1.Controls.Add(Me.btFuenteFechaConfeccion)
        Me.GroupBox1.Controls.Add(Me.btFuenteFechaSalida)
        Me.GroupBox1.Controls.Add(Me.btFuenteCategoria)
        Me.GroupBox1.Controls.Add(Me.btFuentePresentacion)
        Me.GroupBox1.Controls.Add(Me.TxBultos)
        Me.GroupBox1.Controls.Add(Me.TxFechaConfeccion)
        Me.GroupBox1.Controls.Add(Me.TxFechaSalida)
        Me.GroupBox1.Controls.Add(Me.TxCategoria)
        Me.GroupBox1.Controls.Add(Me.TxPresentacion)
        Me.GroupBox1.Controls.Add(Me.LbBultos)
        Me.GroupBox1.Controls.Add(Me.LbFechaConfeccion)
        Me.GroupBox1.Controls.Add(Me.LbFechaSalida)
        Me.GroupBox1.Controls.Add(Me.LbCategoria)
        Me.GroupBox1.Controls.Add(Me.LbPresentacion)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 378)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        '
        'TxBultos
        '
        Me.TxBultos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxBultos.Autonumerico = False
        Me.TxBultos.Buscando = False
        Me.TxBultos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBultos.ClForm = Nothing
        Me.TxBultos.ClParam = Nothing
        Me.TxBultos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBultos.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBultos.GridLin = Nothing
        Me.TxBultos.HaCambiado = False
        Me.TxBultos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBultos.lbbusca = Nothing
        Me.TxBultos.Location = New System.Drawing.Point(18, 309)
        Me.TxBultos.MiError = False
        Me.TxBultos.Name = "TxBultos"
        Me.TxBultos.Orden = 0
        Me.TxBultos.SaltoAlfinal = False
        Me.TxBultos.Siguiente = 0
        Me.TxBultos.Size = New System.Drawing.Size(469, 30)
        Me.TxBultos.TabIndex = 91
        Me.TxBultos.TeclaRepetida = False
        Me.TxBultos.TxDatoFinalSemana = Nothing
        Me.TxBultos.TxDatoInicioSemana = Nothing
        Me.TxBultos.UltimoValorValidado = Nothing
        '
        'TxFechaConfeccion
        '
        Me.TxFechaConfeccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxFechaConfeccion.Autonumerico = False
        Me.TxFechaConfeccion.Buscando = False
        Me.TxFechaConfeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaConfeccion.ClForm = Nothing
        Me.TxFechaConfeccion.ClParam = Nothing
        Me.TxFechaConfeccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaConfeccion.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaConfeccion.GridLin = Nothing
        Me.TxFechaConfeccion.HaCambiado = False
        Me.TxFechaConfeccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaConfeccion.lbbusca = Nothing
        Me.TxFechaConfeccion.Location = New System.Drawing.Point(18, 245)
        Me.TxFechaConfeccion.MiError = False
        Me.TxFechaConfeccion.Name = "TxFechaConfeccion"
        Me.TxFechaConfeccion.Orden = 0
        Me.TxFechaConfeccion.SaltoAlfinal = False
        Me.TxFechaConfeccion.Siguiente = 0
        Me.TxFechaConfeccion.Size = New System.Drawing.Size(469, 30)
        Me.TxFechaConfeccion.TabIndex = 89
        Me.TxFechaConfeccion.TeclaRepetida = False
        Me.TxFechaConfeccion.TxDatoFinalSemana = Nothing
        Me.TxFechaConfeccion.TxDatoInicioSemana = Nothing
        Me.TxFechaConfeccion.UltimoValorValidado = Nothing
        '
        'TxFechaSalida
        '
        Me.TxFechaSalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxFechaSalida.Autonumerico = False
        Me.TxFechaSalida.Buscando = False
        Me.TxFechaSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaSalida.ClForm = Nothing
        Me.TxFechaSalida.ClParam = Nothing
        Me.TxFechaSalida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaSalida.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaSalida.GridLin = Nothing
        Me.TxFechaSalida.HaCambiado = False
        Me.TxFechaSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaSalida.lbbusca = Nothing
        Me.TxFechaSalida.Location = New System.Drawing.Point(18, 181)
        Me.TxFechaSalida.MiError = False
        Me.TxFechaSalida.Name = "TxFechaSalida"
        Me.TxFechaSalida.Orden = 0
        Me.TxFechaSalida.SaltoAlfinal = False
        Me.TxFechaSalida.Siguiente = 0
        Me.TxFechaSalida.Size = New System.Drawing.Size(469, 30)
        Me.TxFechaSalida.TabIndex = 87
        Me.TxFechaSalida.TeclaRepetida = False
        Me.TxFechaSalida.TxDatoFinalSemana = Nothing
        Me.TxFechaSalida.TxDatoInicioSemana = Nothing
        Me.TxFechaSalida.UltimoValorValidado = Nothing
        '
        'TxCategoria
        '
        Me.TxCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxCategoria.Autonumerico = False
        Me.TxCategoria.Buscando = False
        Me.TxCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategoria.ClForm = Nothing
        Me.TxCategoria.ClParam = Nothing
        Me.TxCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCategoria.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategoria.GridLin = Nothing
        Me.TxCategoria.HaCambiado = False
        Me.TxCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCategoria.lbbusca = Nothing
        Me.TxCategoria.Location = New System.Drawing.Point(18, 117)
        Me.TxCategoria.MiError = False
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.Orden = 0
        Me.TxCategoria.SaltoAlfinal = False
        Me.TxCategoria.Siguiente = 0
        Me.TxCategoria.Size = New System.Drawing.Size(469, 30)
        Me.TxCategoria.TabIndex = 85
        Me.TxCategoria.TeclaRepetida = False
        Me.TxCategoria.TxDatoFinalSemana = Nothing
        Me.TxCategoria.TxDatoInicioSemana = Nothing
        Me.TxCategoria.UltimoValorValidado = Nothing
        '
        'TxPresentacion
        '
        Me.TxPresentacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxPresentacion.Autonumerico = False
        Me.TxPresentacion.Buscando = False
        Me.TxPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPresentacion.ClForm = Nothing
        Me.TxPresentacion.ClParam = Nothing
        Me.TxPresentacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPresentacion.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPresentacion.GridLin = Nothing
        Me.TxPresentacion.HaCambiado = False
        Me.TxPresentacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPresentacion.lbbusca = Nothing
        Me.TxPresentacion.Location = New System.Drawing.Point(18, 53)
        Me.TxPresentacion.MiError = False
        Me.TxPresentacion.Name = "TxPresentacion"
        Me.TxPresentacion.Orden = 0
        Me.TxPresentacion.SaltoAlfinal = False
        Me.TxPresentacion.Siguiente = 0
        Me.TxPresentacion.Size = New System.Drawing.Size(469, 30)
        Me.TxPresentacion.TabIndex = 83
        Me.TxPresentacion.TeclaRepetida = False
        Me.TxPresentacion.TxDatoFinalSemana = Nothing
        Me.TxPresentacion.TxDatoInicioSemana = Nothing
        Me.TxPresentacion.UltimoValorValidado = Nothing
        '
        'LbBultos
        '
        Me.LbBultos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbBultos.AutoSize = True
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = True
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.Black
        Me.LbBultos.Location = New System.Drawing.Point(15, 293)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(64, 16)
        Me.LbBultos.TabIndex = 90
        Me.LbBultos.Text = "BULTOS"
        '
        'LbFechaConfeccion
        '
        Me.LbFechaConfeccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbFechaConfeccion.AutoSize = True
        Me.LbFechaConfeccion.CL_ControlAsociado = Nothing
        Me.LbFechaConfeccion.CL_ValorFijo = True
        Me.LbFechaConfeccion.ClForm = Nothing
        Me.LbFechaConfeccion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaConfeccion.ForeColor = System.Drawing.Color.Black
        Me.LbFechaConfeccion.Location = New System.Drawing.Point(15, 229)
        Me.LbFechaConfeccion.Name = "LbFechaConfeccion"
        Me.LbFechaConfeccion.Size = New System.Drawing.Size(157, 16)
        Me.LbFechaConfeccion.TabIndex = 88
        Me.LbFechaConfeccion.Text = "FECHA CONFECCION"
        '
        'LbFechaSalida
        '
        Me.LbFechaSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbFechaSalida.AutoSize = True
        Me.LbFechaSalida.CL_ControlAsociado = Nothing
        Me.LbFechaSalida.CL_ValorFijo = True
        Me.LbFechaSalida.ClForm = Nothing
        Me.LbFechaSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaSalida.ForeColor = System.Drawing.Color.Black
        Me.LbFechaSalida.Location = New System.Drawing.Point(15, 165)
        Me.LbFechaSalida.Name = "LbFechaSalida"
        Me.LbFechaSalida.Size = New System.Drawing.Size(114, 16)
        Me.LbFechaSalida.TabIndex = 86
        Me.LbFechaSalida.Text = "FECHA SALIDA"
        '
        'LbCategoria
        '
        Me.LbCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbCategoria.AutoSize = True
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = True
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Black
        Me.LbCategoria.Location = New System.Drawing.Point(15, 101)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(91, 16)
        Me.LbCategoria.TabIndex = 84
        Me.LbCategoria.Text = "CATEGORÍA"
        '
        'LbPresentacion
        '
        Me.LbPresentacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbPresentacion.AutoSize = True
        Me.LbPresentacion.CL_ControlAsociado = Nothing
        Me.LbPresentacion.CL_ValorFijo = True
        Me.LbPresentacion.ClForm = Nothing
        Me.LbPresentacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPresentacion.ForeColor = System.Drawing.Color.Black
        Me.LbPresentacion.Location = New System.Drawing.Point(15, 37)
        Me.LbPresentacion.Name = "LbPresentacion"
        Me.LbPresentacion.Size = New System.Drawing.Size(118, 16)
        Me.LbPresentacion.TabIndex = 82
        Me.LbPresentacion.Text = "PRESENTACION"
        '
        'LbCopias
        '
        Me.LbCopias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbCopias.AutoSize = True
        Me.LbCopias.CL_ControlAsociado = Nothing
        Me.LbCopias.CL_ValorFijo = True
        Me.LbCopias.ClForm = Nothing
        Me.LbCopias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCopias.ForeColor = System.Drawing.Color.Black
        Me.LbCopias.Location = New System.Drawing.Point(32, 401)
        Me.LbCopias.Name = "LbCopias"
        Me.LbCopias.Size = New System.Drawing.Size(57, 16)
        Me.LbCopias.TabIndex = 81
        Me.LbCopias.Text = "Copias"
        '
        'TxCopias
        '
        Me.TxCopias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxCopias.Autonumerico = False
        Me.TxCopias.Buscando = False
        Me.TxCopias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCopias.ClForm = Nothing
        Me.TxCopias.ClParam = Nothing
        Me.TxCopias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCopias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCopias.GridLin = Nothing
        Me.TxCopias.HaCambiado = False
        Me.TxCopias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCopias.lbbusca = Nothing
        Me.TxCopias.Location = New System.Drawing.Point(95, 398)
        Me.TxCopias.MiError = False
        Me.TxCopias.Name = "TxCopias"
        Me.TxCopias.Orden = 0
        Me.TxCopias.SaltoAlfinal = False
        Me.TxCopias.Siguiente = 0
        Me.TxCopias.Size = New System.Drawing.Size(52, 22)
        Me.TxCopias.TabIndex = 80
        Me.TxCopias.TeclaRepetida = False
        Me.TxCopias.TxDatoFinalSemana = Nothing
        Me.TxCopias.TxDatoInicioSemana = Nothing
        Me.TxCopias.UltimoValorValidado = Nothing
        '
        'ClButton1
        '
        Me.ClButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ClButton1.ForeColor = System.Drawing.Color.Black
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClButton1.Location = New System.Drawing.Point(310, 398)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(75, 23)
        Me.ClButton1.TabIndex = 90
        Me.ClButton1.Text = "Preliminar"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'btFuentePresentacion
        '
        Me.btFuentePresentacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFuentePresentacion.Image = Global.NetAgro.My.Resources.Resources.Action_fonts_16x16_32
        Me.btFuentePresentacion.Location = New System.Drawing.Point(493, 56)
        Me.btFuentePresentacion.Name = "btFuentePresentacion"
        Me.btFuentePresentacion.Size = New System.Drawing.Size(25, 25)
        Me.btFuentePresentacion.TabIndex = 92
        Me.btFuentePresentacion.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_right_16x16_32
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(464, 398)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Orden = 0
        Me.btCancelar.PedirClave = True
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 88
        Me.btCancelar.Text = "Salir"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtAceptar.ForeColor = System.Drawing.Color.Black
        Me.BtAceptar.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAceptar.Location = New System.Drawing.Point(387, 398)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Orden = 0
        Me.BtAceptar.PedirClave = True
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Imprimir"
        Me.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'btFuenteCategoria
        '
        Me.btFuenteCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFuenteCategoria.Image = Global.NetAgro.My.Resources.Resources.Action_fonts_16x16_32
        Me.btFuenteCategoria.Location = New System.Drawing.Point(493, 120)
        Me.btFuenteCategoria.Name = "btFuenteCategoria"
        Me.btFuenteCategoria.Size = New System.Drawing.Size(25, 25)
        Me.btFuenteCategoria.TabIndex = 93
        Me.btFuenteCategoria.UseVisualStyleBackColor = True
        '
        'btFuenteFechaSalida
        '
        Me.btFuenteFechaSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFuenteFechaSalida.Image = Global.NetAgro.My.Resources.Resources.Action_fonts_16x16_32
        Me.btFuenteFechaSalida.Location = New System.Drawing.Point(493, 184)
        Me.btFuenteFechaSalida.Name = "btFuenteFechaSalida"
        Me.btFuenteFechaSalida.Size = New System.Drawing.Size(25, 25)
        Me.btFuenteFechaSalida.TabIndex = 94
        Me.btFuenteFechaSalida.UseVisualStyleBackColor = True
        '
        'btFuenteFechaConfeccion
        '
        Me.btFuenteFechaConfeccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFuenteFechaConfeccion.Image = Global.NetAgro.My.Resources.Resources.Action_fonts_16x16_32
        Me.btFuenteFechaConfeccion.Location = New System.Drawing.Point(493, 248)
        Me.btFuenteFechaConfeccion.Name = "btFuenteFechaConfeccion"
        Me.btFuenteFechaConfeccion.Size = New System.Drawing.Size(25, 25)
        Me.btFuenteFechaConfeccion.TabIndex = 95
        Me.btFuenteFechaConfeccion.UseVisualStyleBackColor = True
        '
        'btFuenteBultos
        '
        Me.btFuenteBultos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFuenteBultos.Image = Global.NetAgro.My.Resources.Resources.Action_fonts_16x16_32
        Me.btFuenteBultos.Location = New System.Drawing.Point(493, 312)
        Me.btFuenteBultos.Name = "btFuenteBultos"
        Me.btFuenteBultos.Size = New System.Drawing.Size(25, 25)
        Me.btFuenteBultos.TabIndex = 96
        Me.btFuenteBultos.UseVisualStyleBackColor = True
        '
        'FrmCartelones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 433)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.Name = "FrmCartelones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir cartelones"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.pnlSerieFactura.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents LbCopias As NetAgro.Lb
    Friend WithEvents TxCopias As NetAgro.TxDato
    Friend WithEvents btCancelar As NetAgro.ClButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxBultos As NetAgro.TxDato
    Friend WithEvents TxFechaConfeccion As NetAgro.TxDato
    Friend WithEvents TxFechaSalida As NetAgro.TxDato
    Friend WithEvents TxCategoria As NetAgro.TxDato
    Friend WithEvents TxPresentacion As NetAgro.TxDato
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents LbFechaConfeccion As NetAgro.Lb
    Friend WithEvents LbFechaSalida As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents LbPresentacion As NetAgro.Lb
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btFuentePresentacion As System.Windows.Forms.Button
    Friend WithEvents FontDialog2 As System.Windows.Forms.FontDialog
    Friend WithEvents FontDialog3 As System.Windows.Forms.FontDialog
    Friend WithEvents FontDialog4 As System.Windows.Forms.FontDialog
    Friend WithEvents FontDialog5 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btFuenteBultos As System.Windows.Forms.Button
    Friend WithEvents btFuenteFechaConfeccion As System.Windows.Forms.Button
    Friend WithEvents btFuenteFechaSalida As System.Windows.Forms.Button
    Friend WithEvents btFuenteCategoria As System.Windows.Forms.Button
End Class
