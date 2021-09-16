<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmisionTalones
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbDocumentoTalon = New NetAgro.CbBox(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.TxImporteLetra2 = New NetAgro.TxDato(Me.components)
        Me.TxImporteLetra1 = New NetAgro.TxDato(Me.components)
        Me.TxDestinatario = New NetAgro.TxDato(Me.components)
        Me.TxImporte = New NetAgro.TxDato(Me.components)
        Me.TxFechaVto = New NetAgro.TxDato(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btAceptar)
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 477)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 31)
        Me.Panel1.TabIndex = 100322
        '
        'btAceptar
        '
        Me.btAceptar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btAceptar.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.btAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAceptar.Location = New System.Drawing.Point(873, 0)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 31)
        Me.btAceptar.TabIndex = 100320
        Me.btAceptar.Text = "Imprimir"
        Me.btAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_right_16x16_32
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(948, 0)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(56, 31)
        Me.btCancelar.TabIndex = 100321
        Me.btCancelar.Text = "Salir"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NetAgro.My.Resources.Resources.pagare_fondo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1004, 401)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TxFecha)
        Me.Panel2.Controls.Add(Me.TxImporteLetra2)
        Me.Panel2.Controls.Add(Me.TxImporteLetra1)
        Me.Panel2.Controls.Add(Me.TxDestinatario)
        Me.Panel2.Controls.Add(Me.TxImporte)
        Me.Panel2.Controls.Add(Me.TxFechaVto)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 401)
        Me.Panel2.TabIndex = 100323
        '
        'CbDocumentoTalon
        '
        Me.CbDocumentoTalon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbDocumentoTalon.Campobd = Nothing
        Me.CbDocumentoTalon.ClForm = Nothing
        Me.CbDocumentoTalon.DeshabilitarRuedaRaton = False
        Me.CbDocumentoTalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDocumentoTalon.FormattingEnabled = True
        Me.CbDocumentoTalon.GridLin = Nothing
        Me.CbDocumentoTalon.Location = New System.Drawing.Point(163, 37)
        Me.CbDocumentoTalon.MiEntidad = Nothing
        Me.CbDocumentoTalon.MiError = False
        Me.CbDocumentoTalon.Name = "CbDocumentoTalon"
        Me.CbDocumentoTalon.Orden = 0
        Me.CbDocumentoTalon.SaltoAlfinal = False
        Me.CbDocumentoTalon.Size = New System.Drawing.Size(490, 21)
        Me.CbDocumentoTalon.TabIndex = 100329
        '
        'Lb1
        '
        Me.Lb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(25, 39)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(132, 16)
        Me.Lb1.TabIndex = 100328
        Me.Lb1.Text = "Documento talón"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(619, 282)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(308, 27)
        Me.TxFecha.TabIndex = 100281
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'TxImporteLetra2
        '
        Me.TxImporteLetra2.Autonumerico = False
        Me.TxImporteLetra2.Buscando = False
        Me.TxImporteLetra2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporteLetra2.ClForm = Nothing
        Me.TxImporteLetra2.ClParam = Nothing
        Me.TxImporteLetra2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporteLetra2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporteLetra2.GridLin = Nothing
        Me.TxImporteLetra2.HaCambiado = False
        Me.TxImporteLetra2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporteLetra2.lbbusca = Nothing
        Me.TxImporteLetra2.Location = New System.Drawing.Point(116, 255)
        Me.TxImporteLetra2.MiError = False
        Me.TxImporteLetra2.Name = "TxImporteLetra2"
        Me.TxImporteLetra2.Orden = 0
        Me.TxImporteLetra2.SaltoAlfinal = False
        Me.TxImporteLetra2.Siguiente = 0
        Me.TxImporteLetra2.Size = New System.Drawing.Size(842, 23)
        Me.TxImporteLetra2.TabIndex = 100280
        Me.TxImporteLetra2.TeclaRepetida = False
        Me.TxImporteLetra2.TxDatoFinalSemana = Nothing
        Me.TxImporteLetra2.TxDatoInicioSemana = Nothing
        Me.TxImporteLetra2.UltimoValorValidado = Nothing
        '
        'TxImporteLetra1
        '
        Me.TxImporteLetra1.Autonumerico = False
        Me.TxImporteLetra1.Buscando = False
        Me.TxImporteLetra1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporteLetra1.ClForm = Nothing
        Me.TxImporteLetra1.ClParam = Nothing
        Me.TxImporteLetra1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporteLetra1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporteLetra1.GridLin = Nothing
        Me.TxImporteLetra1.HaCambiado = False
        Me.TxImporteLetra1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporteLetra1.lbbusca = Nothing
        Me.TxImporteLetra1.Location = New System.Drawing.Point(116, 229)
        Me.TxImporteLetra1.MiError = False
        Me.TxImporteLetra1.Name = "TxImporteLetra1"
        Me.TxImporteLetra1.Orden = 0
        Me.TxImporteLetra1.SaltoAlfinal = False
        Me.TxImporteLetra1.Siguiente = 0
        Me.TxImporteLetra1.Size = New System.Drawing.Size(842, 23)
        Me.TxImporteLetra1.TabIndex = 100279
        Me.TxImporteLetra1.TeclaRepetida = False
        Me.TxImporteLetra1.TxDatoFinalSemana = Nothing
        Me.TxImporteLetra1.TxDatoInicioSemana = Nothing
        Me.TxImporteLetra1.UltimoValorValidado = Nothing
        '
        'TxDestinatario
        '
        Me.TxDestinatario.Autonumerico = False
        Me.TxDestinatario.Buscando = False
        Me.TxDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDestinatario.ClForm = Nothing
        Me.TxDestinatario.ClParam = Nothing
        Me.TxDestinatario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDestinatario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDestinatario.GridLin = Nothing
        Me.TxDestinatario.HaCambiado = False
        Me.TxDestinatario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDestinatario.lbbusca = Nothing
        Me.TxDestinatario.Location = New System.Drawing.Point(116, 203)
        Me.TxDestinatario.MiError = False
        Me.TxDestinatario.Name = "TxDestinatario"
        Me.TxDestinatario.Orden = 0
        Me.TxDestinatario.SaltoAlfinal = False
        Me.TxDestinatario.Siguiente = 0
        Me.TxDestinatario.Size = New System.Drawing.Size(842, 23)
        Me.TxDestinatario.TabIndex = 100278
        Me.TxDestinatario.TeclaRepetida = False
        Me.TxDestinatario.TxDatoFinalSemana = Nothing
        Me.TxDestinatario.TxDatoInicioSemana = Nothing
        Me.TxDestinatario.UltimoValorValidado = Nothing
        '
        'TxImporte
        '
        Me.TxImporte.Autonumerico = False
        Me.TxImporte.Buscando = False
        Me.TxImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte.ClForm = Nothing
        Me.TxImporte.ClParam = Nothing
        Me.TxImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte.GridLin = Nothing
        Me.TxImporte.HaCambiado = False
        Me.TxImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporte.lbbusca = Nothing
        Me.TxImporte.Location = New System.Drawing.Point(732, 147)
        Me.TxImporte.MiError = False
        Me.TxImporte.Name = "TxImporte"
        Me.TxImporte.Orden = 0
        Me.TxImporte.SaltoAlfinal = False
        Me.TxImporte.Siguiente = 0
        Me.TxImporte.Size = New System.Drawing.Size(207, 27)
        Me.TxImporte.TabIndex = 100277
        Me.TxImporte.TeclaRepetida = False
        Me.TxImporte.TxDatoFinalSemana = Nothing
        Me.TxImporte.TxDatoInicioSemana = Nothing
        Me.TxImporte.UltimoValorValidado = Nothing
        '
        'TxFechaVto
        '
        Me.TxFechaVto.Autonumerico = False
        Me.TxFechaVto.Buscando = False
        Me.TxFechaVto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaVto.ClForm = Nothing
        Me.TxFechaVto.ClParam = Nothing
        Me.TxFechaVto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaVto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaVto.GridLin = Nothing
        Me.TxFechaVto.HaCambiado = False
        Me.TxFechaVto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaVto.lbbusca = Nothing
        Me.TxFechaVto.Location = New System.Drawing.Point(199, 147)
        Me.TxFechaVto.MiError = False
        Me.TxFechaVto.Name = "TxFechaVto"
        Me.TxFechaVto.Orden = 0
        Me.TxFechaVto.SaltoAlfinal = False
        Me.TxFechaVto.Siguiente = 0
        Me.TxFechaVto.Size = New System.Drawing.Size(267, 27)
        Me.TxFechaVto.TabIndex = 100273
        Me.TxFechaVto.TeclaRepetida = False
        Me.TxFechaVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxFechaVto.TxDatoFinalSemana = Nothing
        Me.TxFechaVto.TxDatoInicioSemana = Nothing
        Me.TxFechaVto.UltimoValorValidado = Nothing
        '
        'FrmEmisionTalones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 508)
        Me.Controls.Add(Me.CbDocumentoTalon)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEmisionTalones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emision talones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CbDocumentoTalon As NetAgro.CbBox
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxFechaVto As NetAgro.TxDato
    Friend WithEvents TxImporte As NetAgro.TxDato
    Friend WithEvents TxDestinatario As NetAgro.TxDato
    Friend WithEvents TxImporteLetra1 As NetAgro.TxDato
    Friend WithEvents TxImporteLetra2 As NetAgro.TxDato
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
