<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKilosDestrio
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
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbFin = New System.Windows.Forms.Label()
        Me.LbInicio = New System.Windows.Forms.Label()
        Me.LbConsumido = New System.Windows.Forms.Label()
        Me.LbGenero = New System.Windows.Forms.Label()
        Me.LbNumero = New System.Windows.Forms.Label()
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbTipo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.TxKilosDestrio = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.btCancelar = New NetAgro.ClButton()
        Me.BtAceptar = New NetAgro.ClButton()
        Me.LbPorcentaje = New NetAgro.Lb(Me.components)
        Me.pnlSerieFactura.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.Lb6)
        Me.pnlSerieFactura.Controls.Add(Me.Lb5)
        Me.pnlSerieFactura.Controls.Add(Me.Lb3)
        Me.pnlSerieFactura.Controls.Add(Me.Lb2)
        Me.pnlSerieFactura.Controls.Add(Me.Lb1)
        Me.pnlSerieFactura.Controls.Add(Me.LbFin)
        Me.pnlSerieFactura.Controls.Add(Me.LbInicio)
        Me.pnlSerieFactura.Controls.Add(Me.LbConsumido)
        Me.pnlSerieFactura.Controls.Add(Me.LbGenero)
        Me.pnlSerieFactura.Controls.Add(Me.LbNumero)
        Me.pnlSerieFactura.Controls.Add(Me.Lb9)
        Me.pnlSerieFactura.Controls.Add(Me.LbTipo)
        Me.pnlSerieFactura.Controls.Add(Me.Panel1)
        Me.pnlSerieFactura.Controls.Add(Me.Lb4)
        Me.pnlSerieFactura.Controls.Add(Me.LbFecha)
        Me.pnlSerieFactura.Controls.Add(Me.btCancelar)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(786, 229)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(680, 65)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(48, 18)
        Me.Lb6.TabIndex = 214
        Me.Lb6.Text = "Final"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(595, 65)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(55, 18)
        Me.Lb5.TabIndex = 213
        Me.Lb5.Text = "Inicio"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(484, 65)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(104, 18)
        Me.Lb3.TabIndex = 212
        Me.Lb3.Text = "Consumido"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(154, 65)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(73, 18)
        Me.Lb2.TabIndex = 211
        Me.Lb2.Text = "Género"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(40, 65)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(78, 18)
        Me.Lb1.TabIndex = 210
        Me.Lb1.Text = "Numero"
        '
        'LbFin
        '
        Me.LbFin.BackColor = System.Drawing.Color.White
        Me.LbFin.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFin.Location = New System.Drawing.Point(680, 88)
        Me.LbFin.Name = "LbFin"
        Me.LbFin.Size = New System.Drawing.Size(79, 32)
        Me.LbFin.TabIndex = 209
        Me.LbFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbInicio
        '
        Me.LbInicio.BackColor = System.Drawing.Color.White
        Me.LbInicio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInicio.Location = New System.Drawing.Point(595, 88)
        Me.LbInicio.Name = "LbInicio"
        Me.LbInicio.Size = New System.Drawing.Size(79, 32)
        Me.LbInicio.TabIndex = 208
        Me.LbInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbConsumido
        '
        Me.LbConsumido.BackColor = System.Drawing.Color.White
        Me.LbConsumido.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConsumido.Location = New System.Drawing.Point(484, 88)
        Me.LbConsumido.Name = "LbConsumido"
        Me.LbConsumido.Size = New System.Drawing.Size(104, 32)
        Me.LbConsumido.TabIndex = 207
        Me.LbConsumido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.Color.White
        Me.LbGenero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.Location = New System.Drawing.Point(154, 88)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(324, 32)
        Me.LbGenero.TabIndex = 206
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbNumero
        '
        Me.LbNumero.BackColor = System.Drawing.Color.White
        Me.LbNumero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.Location = New System.Drawing.Point(40, 88)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(108, 32)
        Me.LbNumero.TabIndex = 205
        Me.LbNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(10, 65)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(20, 18)
        Me.Lb9.TabIndex = 204
        Me.Lb9.Text = "T"
        '
        'LbTipo
        '
        Me.LbTipo.BackColor = System.Drawing.Color.White
        Me.LbTipo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.Location = New System.Drawing.Point(9, 88)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(25, 32)
        Me.LbTipo.TabIndex = 203
        Me.LbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.LbPorcentaje)
        Me.Panel1.Controls.Add(Me.Lb23)
        Me.Panel1.Controls.Add(Me.TxKilosDestrio)
        Me.Panel1.Location = New System.Drawing.Point(9, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 51)
        Me.Panel1.TabIndex = 202
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Black
        Me.Lb23.Location = New System.Drawing.Point(15, 18)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(97, 16)
        Me.Lb23.TabIndex = 81
        Me.Lb23.Text = "Kilos destrío"
        '
        'TxKilosDestrio
        '
        Me.TxKilosDestrio.Autonumerico = False
        Me.TxKilosDestrio.Buscando = False
        Me.TxKilosDestrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilosDestrio.ClForm = Nothing
        Me.TxKilosDestrio.ClParam = Nothing
        Me.TxKilosDestrio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilosDestrio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilosDestrio.GridLin = Nothing
        Me.TxKilosDestrio.HaCambiado = False
        Me.TxKilosDestrio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilosDestrio.lbbusca = Nothing
        Me.TxKilosDestrio.Location = New System.Drawing.Point(118, 15)
        Me.TxKilosDestrio.MiError = False
        Me.TxKilosDestrio.Name = "TxKilosDestrio"
        Me.TxKilosDestrio.Orden = 0
        Me.TxKilosDestrio.SaltoAlfinal = False
        Me.TxKilosDestrio.Siguiente = 0
        Me.TxKilosDestrio.Size = New System.Drawing.Size(112, 22)
        Me.TxKilosDestrio.TabIndex = 80
        Me.TxKilosDestrio.TeclaRepetida = False
        Me.TxKilosDestrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKilosDestrio.UltimoValorValidado = Nothing
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
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(675, 191)
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
        Me.BtAceptar.Location = New System.Drawing.Point(598, 191)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Orden = 0
        Me.BtAceptar.PedirClave = True
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'LbPorcentaje
        '
        Me.LbPorcentaje.AutoSize = True
        Me.LbPorcentaje.CL_ControlAsociado = Nothing
        Me.LbPorcentaje.CL_ValorFijo = True
        Me.LbPorcentaje.ClForm = Nothing
        Me.LbPorcentaje.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcentaje.ForeColor = System.Drawing.Color.Black
        Me.LbPorcentaje.Location = New System.Drawing.Point(355, 18)
        Me.LbPorcentaje.Name = "LbPorcentaje"
        Me.LbPorcentaje.Size = New System.Drawing.Size(25, 16)
        Me.LbPorcentaje.TabIndex = 82
        Me.LbPorcentaje.Text = "%"
        '
        'frmKilosDestrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 229)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKilosDestrio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva linea de produccion"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.pnlSerieFactura.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents btCancelar As NetAgro.ClButton
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbFin As System.Windows.Forms.Label
    Friend WithEvents LbInicio As System.Windows.Forms.Label
    Friend WithEvents LbConsumido As System.Windows.Forms.Label
    Friend WithEvents LbGenero As System.Windows.Forms.Label
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbTipo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents TxKilosDestrio As NetAgro.TxDato
    Friend WithEvents LbPorcentaje As NetAgro.Lb
End Class
