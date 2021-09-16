<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirLote
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
        Me.btSalir = New NetAgro.ClButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbLote = New NetAgro.Lb(Me.components)
        Me.TxLote = New NetAgro.TxDato(Me.components)
        Me.BtAceptar = New NetAgro.ClButton()
        Me.pnlSerieFactura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.btSalir)
        Me.pnlSerieFactura.Controls.Add(Me.GroupBox1)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(339, 114)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btSalir.ForeColor = System.Drawing.Color.Black
        Me.btSalir.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalir.Location = New System.Drawing.Point(267, 80)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Orden = 0
        Me.btSalir.PedirClave = True
        Me.btSalir.Size = New System.Drawing.Size(50, 23)
        Me.btSalir.TabIndex = 83
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbLote)
        Me.GroupBox1.Controls.Add(Me.TxLote)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 61)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'LbLote
        '
        Me.LbLote.AutoSize = True
        Me.LbLote.CL_ControlAsociado = Nothing
        Me.LbLote.CL_ValorFijo = True
        Me.LbLote.ClForm = Nothing
        Me.LbLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.ForeColor = System.Drawing.Color.Black
        Me.LbLote.Location = New System.Drawing.Point(18, 25)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(186, 16)
        Me.LbLote.TabIndex = 81
        Me.LbLote.Text = "Introduzca lote del palet"
        '
        'TxLote
        '
        Me.TxLote.Autonumerico = False
        Me.TxLote.Buscando = False
        Me.TxLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxLote.ClForm = Nothing
        Me.TxLote.ClParam = Nothing
        Me.TxLote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxLote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxLote.GridLin = Nothing
        Me.TxLote.HaCambiado = False
        Me.TxLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxLote.lbbusca = Nothing
        Me.TxLote.Location = New System.Drawing.Point(210, 23)
        Me.TxLote.MiError = False
        Me.TxLote.Name = "TxLote"
        Me.TxLote.Orden = 0
        Me.TxLote.SaltoAlfinal = False
        Me.TxLote.Siguiente = 0
        Me.TxLote.Size = New System.Drawing.Size(66, 22)
        Me.TxLote.TabIndex = 80
        Me.TxLote.TeclaRepetida = False
        Me.TxLote.TxDatoFinalSemana = Nothing
        Me.TxLote.TxDatoInicioSemana = Nothing
        Me.TxLote.UltimoValorValidado = Nothing
        '
        'BtAceptar
        '
        Me.BtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtAceptar.ForeColor = System.Drawing.Color.Black
        Me.BtAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAceptar.Location = New System.Drawing.Point(191, 80)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Orden = 0
        Me.BtAceptar.PedirClave = True
        Me.BtAceptar.Size = New System.Drawing.Size(70, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'FrmIntroducirLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 114)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmIntroducirLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introducir lote del palet"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents LbLote As NetAgro.Lb
    Friend WithEvents TxLote As NetAgro.TxDato
    Friend WithEvents btSalir As NetAgro.ClButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
