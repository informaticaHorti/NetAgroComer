<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSerieNumeroFactura
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
        Me.BtAceptar = New NetAgro.ClButton()
        Me.Lb48 = New NetAgro.Lb(Me.components)
        Me.Lb45 = New NetAgro.Lb(Me.components)
        Me.TxFactura = New NetAgro.TxDato(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.TxSerie = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.pnlSerieFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.Lb1)
        Me.pnlSerieFactura.Controls.Add(Me.TxFecha)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Controls.Add(Me.Lb48)
        Me.pnlSerieFactura.Controls.Add(Me.Lb45)
        Me.pnlSerieFactura.Controls.Add(Me.TxFactura)
        Me.pnlSerieFactura.Controls.Add(Me.Lb23)
        Me.pnlSerieFactura.Controls.Add(Me.TxSerie)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(339, 185)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'BtAceptar
        '
        Me.BtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtAceptar.ForeColor = System.Drawing.Color.Black
        Me.BtAceptar.Location = New System.Drawing.Point(253, 153)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'Lb48
        '
        Me.Lb48.CL_ControlAsociado = Nothing
        Me.Lb48.CL_ValorFijo = True
        Me.Lb48.ClForm = Nothing
        Me.Lb48.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb48.ForeColor = System.Drawing.Color.Teal
        Me.Lb48.Location = New System.Drawing.Point(17, 73)
        Me.Lb48.Name = "Lb48"
        Me.Lb48.Size = New System.Drawing.Size(291, 34)
        Me.Lb48.TabIndex = 84
        Me.Lb48.Text = "(Deje el número en blanco para asignar un número de factura automáticamente)"
        '
        'Lb45
        '
        Me.Lb45.AutoSize = True
        Me.Lb45.CL_ControlAsociado = Nothing
        Me.Lb45.CL_ValorFijo = True
        Me.Lb45.ClForm = Nothing
        Me.Lb45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb45.ForeColor = System.Drawing.Color.Black
        Me.Lb45.Location = New System.Drawing.Point(13, 51)
        Me.Lb45.Name = "Lb45"
        Me.Lb45.Size = New System.Drawing.Size(121, 16)
        Me.Lb45.TabIndex = 83
        Me.Lb45.Text = "Número factura"
        '
        'TxFactura
        '
        Me.TxFactura.Autonumerico = False
        Me.TxFactura.Buscando = False
        Me.TxFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFactura.ClForm = Nothing
        Me.TxFactura.ClParam = Nothing
        Me.TxFactura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFactura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFactura.GridLin = Nothing
        Me.TxFactura.HaCambiado = False
        Me.TxFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFactura.lbbusca = Nothing
        Me.TxFactura.Location = New System.Drawing.Point(144, 46)
        Me.TxFactura.MiError = False
        Me.TxFactura.Name = "TxFactura"
        Me.TxFactura.Orden = 0
        Me.TxFactura.SaltoAlfinal = False
        Me.TxFactura.Siguiente = 0
        Me.TxFactura.Size = New System.Drawing.Size(153, 22)
        Me.TxFactura.TabIndex = 82
        Me.TxFactura.TeclaRepetida = False
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Black
        Me.Lb23.Location = New System.Drawing.Point(13, 25)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(101, 16)
        Me.Lb23.TabIndex = 81
        Me.Lb23.Text = "Serie factura"
        '
        'TxSerie
        '
        Me.TxSerie.Autonumerico = False
        Me.TxSerie.Buscando = False
        Me.TxSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSerie.ClForm = Nothing
        Me.TxSerie.ClParam = Nothing
        Me.TxSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSerie.GridLin = Nothing
        Me.TxSerie.HaCambiado = False
        Me.TxSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSerie.lbbusca = Nothing
        Me.TxSerie.Location = New System.Drawing.Point(144, 20)
        Me.TxSerie.MiError = False
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Orden = 0
        Me.TxSerie.SaltoAlfinal = False
        Me.TxSerie.Siguiente = 0
        Me.TxSerie.Size = New System.Drawing.Size(66, 22)
        Me.TxSerie.TabIndex = 80
        Me.TxSerie.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Black
        Me.Lb1.Location = New System.Drawing.Point(13, 115)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(108, 16)
        Me.Lb1.TabIndex = 86
        Me.Lb1.Text = "Fecha factura"
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
        Me.TxFecha.Location = New System.Drawing.Point(144, 110)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(153, 22)
        Me.TxFecha.TabIndex = 85
        Me.TxFecha.TeclaRepetida = False
        '
        'FrmSerieNumeroFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 185)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSerieNumeroFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduzca serie y número de la factura"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.pnlSerieFactura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents Lb48 As NetAgro.Lb
    Friend WithEvents Lb45 As NetAgro.Lb
    Friend WithEvents TxFactura As NetAgro.TxDato
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents TxSerie As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
End Class
