<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaLineaProduccion
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
        Me.rdbPrecalibrado = New System.Windows.Forms.RadioButton()
        Me.rdbLote = New System.Windows.Forms.RadioButton()
        Me.rdbPartida = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxCampa = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbProducto = New NetAgro.Lb(Me.components)
        Me.btCancelar = New NetAgro.ClButton()
        Me.BtAceptar = New NetAgro.ClButton()
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.TxNumero = New NetAgro.TxDato(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbKilosPendientes = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbKilosConsumidos = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbKilosPartidaLote = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.pnlSerieFactura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.TxCampa)
        Me.pnlSerieFactura.Controls.Add(Me.Lb4)
        Me.pnlSerieFactura.Controls.Add(Me.LbFecha)
        Me.pnlSerieFactura.Controls.Add(Me.Lb2)
        Me.pnlSerieFactura.Controls.Add(Me.LbCategoria)
        Me.pnlSerieFactura.Controls.Add(Me.Lb1)
        Me.pnlSerieFactura.Controls.Add(Me.LbProducto)
        Me.pnlSerieFactura.Controls.Add(Me.btCancelar)
        Me.pnlSerieFactura.Controls.Add(Me.GroupBox1)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Controls.Add(Me.Lb23)
        Me.pnlSerieFactura.Controls.Add(Me.TxNumero)
        Me.pnlSerieFactura.Controls.Add(Me.Panel1)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(411, 379)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rdbPrecalibrado)
        Me.GroupBox1.Controls.Add(Me.rdbLote)
        Me.GroupBox1.Controls.Add(Me.rdbPartida)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 41)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'rdbPrecalibrado
        '
        Me.rdbPrecalibrado.AutoSize = True
        Me.rdbPrecalibrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrecalibrado.ForeColor = System.Drawing.Color.Teal
        Me.rdbPrecalibrado.Location = New System.Drawing.Point(191, 14)
        Me.rdbPrecalibrado.Name = "rdbPrecalibrado"
        Me.rdbPrecalibrado.Size = New System.Drawing.Size(116, 20)
        Me.rdbPrecalibrado.TabIndex = 3
        Me.rdbPrecalibrado.Text = "Precalibrado"
        Me.rdbPrecalibrado.UseVisualStyleBackColor = True
        '
        'rdbLote
        '
        Me.rdbLote.AutoSize = True
        Me.rdbLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLote.ForeColor = System.Drawing.Color.Teal
        Me.rdbLote.Location = New System.Drawing.Point(116, 14)
        Me.rdbLote.Name = "rdbLote"
        Me.rdbLote.Size = New System.Drawing.Size(56, 20)
        Me.rdbLote.TabIndex = 2
        Me.rdbLote.Text = "Lote"
        Me.rdbLote.UseVisualStyleBackColor = True
        '
        'rdbPartida
        '
        Me.rdbPartida.AutoSize = True
        Me.rdbPartida.Checked = True
        Me.rdbPartida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPartida.ForeColor = System.Drawing.Color.Teal
        Me.rdbPartida.Location = New System.Drawing.Point(21, 14)
        Me.rdbPartida.Name = "rdbPartida"
        Me.rdbPartida.Size = New System.Drawing.Size(76, 20)
        Me.rdbPartida.TabIndex = 1
        Me.rdbPartida.TabStop = True
        Me.rdbPartida.Text = "Partida"
        Me.rdbPartida.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lb9)
        Me.Panel1.Controls.Add(Me.LbKilosPendientes)
        Me.Panel1.Controls.Add(Me.Lb7)
        Me.Panel1.Controls.Add(Me.LbKilosConsumidos)
        Me.Panel1.Controls.Add(Me.Lb5)
        Me.Panel1.Controls.Add(Me.LbKilosPartidaLote)
        Me.Panel1.Controls.Add(Me.Lb3)
        Me.Panel1.Controls.Add(Me.LbKilos)
        Me.Panel1.Location = New System.Drawing.Point(13, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 135)
        Me.Panel1.TabIndex = 184
        '
        'TxCampa
        '
        Me.TxCampa.Autonumerico = False
        Me.TxCampa.Bloqueado = False
        Me.TxCampa.Buscando = False
        Me.TxCampa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCampa.ClForm = Nothing
        Me.TxCampa.ClParam = Nothing
        Me.TxCampa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCampa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCampa.GridLin = Nothing
        Me.TxCampa.HaCambiado = False
        Me.TxCampa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCampa.lbbusca = Nothing
        Me.TxCampa.Location = New System.Drawing.Point(90, 114)
        Me.TxCampa.MiError = False
        Me.TxCampa.Name = "TxCampa"
        Me.TxCampa.Orden = 0
        Me.TxCampa.SaltoAlfinal = False
        Me.TxCampa.Siguiente = 0
        Me.TxCampa.Size = New System.Drawing.Size(25, 22)
        Me.TxCampa.TabIndex = 187
        Me.TxCampa.TeclaRepetida = False
        Me.TxCampa.TxDatoFinalSemana = Nothing
        Me.TxCampa.TxDatoInicioSemana = Nothing
        Me.TxCampa.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Black
        Me.Lb4.Location = New System.Drawing.Point(10, 14)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(52, 16)
        Me.Lb4.TabIndex = 186
        Me.Lb4.Text = "Fecha"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(89, 11)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(120, 23)
        Me.LbFecha.TabIndex = 185
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Black
        Me.Lb2.Location = New System.Drawing.Point(11, 174)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(56, 16)
        Me.Lb2.TabIndex = 175
        Me.Lb2.Text = "Categ."
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = False
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCategoria.Location = New System.Drawing.Point(90, 171)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(120, 23)
        Me.LbCategoria.TabIndex = 174
        Me.LbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Black
        Me.Lb1.Location = New System.Drawing.Point(11, 148)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(73, 16)
        Me.Lb1.TabIndex = 173
        Me.Lb1.Text = "Producto"
        '
        'LbProducto
        '
        Me.LbProducto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbProducto.CL_ControlAsociado = Nothing
        Me.LbProducto.CL_ValorFijo = False
        Me.LbProducto.ClForm = Nothing
        Me.LbProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbProducto.Location = New System.Drawing.Point(90, 145)
        Me.LbProducto.Name = "LbProducto"
        Me.LbProducto.Size = New System.Drawing.Size(297, 23)
        Me.LbProducto.TabIndex = 172
        Me.LbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(317, 344)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Orden = 0
        Me.btCancelar.PedirClave = True
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 88
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtAceptar.ForeColor = System.Drawing.Color.Black
        Me.BtAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAceptar.Location = New System.Drawing.Point(240, 344)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Orden = 0
        Me.BtAceptar.PedirClave = True
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Black
        Me.Lb23.Location = New System.Drawing.Point(11, 117)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(65, 16)
        Me.Lb23.TabIndex = 81
        Me.Lb23.Text = "Numero"
        '
        'TxNumero
        '
        Me.TxNumero.Autonumerico = False
        Me.TxNumero.Bloqueado = False
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
        Me.TxNumero.Location = New System.Drawing.Point(117, 114)
        Me.TxNumero.MiError = False
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Orden = 0
        Me.TxNumero.SaltoAlfinal = False
        Me.TxNumero.Siguiente = 0
        Me.TxNumero.Size = New System.Drawing.Size(167, 22)
        Me.TxNumero.TabIndex = 80
        Me.TxNumero.TeclaRepetida = False
        Me.TxNumero.TxDatoFinalSemana = Nothing
        Me.TxNumero.TxDatoInicioSemana = Nothing
        Me.TxNumero.UltimoValorValidado = Nothing
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.BackColor = System.Drawing.Color.Azure
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Black
        Me.Lb9.Location = New System.Drawing.Point(28, 97)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(116, 16)
        Me.Lb9.TabIndex = 191
        Me.Lb9.Text = "Kg. Pendientes"
        '
        'LbKilosPendientes
        '
        Me.LbKilosPendientes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKilosPendientes.CL_ControlAsociado = Nothing
        Me.LbKilosPendientes.CL_ValorFijo = False
        Me.LbKilosPendientes.ClForm = Nothing
        Me.LbKilosPendientes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosPendientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosPendientes.Location = New System.Drawing.Point(162, 94)
        Me.LbKilosPendientes.Name = "LbKilosPendientes"
        Me.LbKilosPendientes.Size = New System.Drawing.Size(120, 23)
        Me.LbKilosPendientes.TabIndex = 190
        Me.LbKilosPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.BackColor = System.Drawing.Color.Azure
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Black
        Me.Lb7.Location = New System.Drawing.Point(28, 71)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(124, 16)
        Me.Lb7.TabIndex = 189
        Me.Lb7.Text = "Kg. Consumidos"
        '
        'LbKilosConsumidos
        '
        Me.LbKilosConsumidos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosConsumidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKilosConsumidos.CL_ControlAsociado = Nothing
        Me.LbKilosConsumidos.CL_ValorFijo = False
        Me.LbKilosConsumidos.ClForm = Nothing
        Me.LbKilosConsumidos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosConsumidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosConsumidos.Location = New System.Drawing.Point(162, 68)
        Me.LbKilosConsumidos.Name = "LbKilosConsumidos"
        Me.LbKilosConsumidos.Size = New System.Drawing.Size(120, 23)
        Me.LbKilosConsumidos.TabIndex = 188
        Me.LbKilosConsumidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.BackColor = System.Drawing.Color.Azure
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Black
        Me.Lb5.Location = New System.Drawing.Point(28, 45)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(128, 16)
        Me.Lb5.TabIndex = 187
        Me.Lb5.Text = "Kg. Partida/Lote"
        '
        'LbKilosPartidaLote
        '
        Me.LbKilosPartidaLote.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosPartidaLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKilosPartidaLote.CL_ControlAsociado = Nothing
        Me.LbKilosPartidaLote.CL_ValorFijo = False
        Me.LbKilosPartidaLote.ClForm = Nothing
        Me.LbKilosPartidaLote.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosPartidaLote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosPartidaLote.Location = New System.Drawing.Point(162, 42)
        Me.LbKilosPartidaLote.Name = "LbKilosPartidaLote"
        Me.LbKilosPartidaLote.Size = New System.Drawing.Size(120, 23)
        Me.LbKilosPartidaLote.TabIndex = 186
        Me.LbKilosPartidaLote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.BackColor = System.Drawing.Color.Azure
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Black
        Me.Lb3.Location = New System.Drawing.Point(28, 19)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(42, 16)
        Me.Lb3.TabIndex = 185
        Me.Lb3.Text = "Kilos"
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilos.Location = New System.Drawing.Point(162, 16)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(120, 23)
        Me.LbKilos.TabIndex = 184
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmNuevaLineaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 379)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNuevaLineaProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva linea de produccion"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.pnlSerieFactura.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents TxNumero As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbLote As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPartida As System.Windows.Forms.RadioButton
    Friend WithEvents btCancelar As NetAgro.ClButton
    Friend WithEvents LbProducto As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbKilosPendientes As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbKilosConsumidos As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbKilosPartidaLote As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents rdbPrecalibrado As System.Windows.Forms.RadioButton
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxCampa As NetAgro.TxDato
End Class
