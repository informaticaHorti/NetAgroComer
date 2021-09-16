<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtractoEnvases
    Inherits NetAgro.FrConsulta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExtractoEnvases))
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.LbEnvase = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbNomEnvase = New NetAgro.Lb(Me.components)
        Me.LbDfecha = New NetAgro.Lb(Me.components)
        Me.LbHfecha = New NetAgro.Lb(Me.components)
        Me.LbSaldoini = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.LbSaldoiniV = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.LbSaldoFinV = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbSaldoFin = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.LbSaldoFinV)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.LbSaldoFin)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbSaldoiniV)
        Me.PanelCabecera.Controls.Add(Me.Lb14)
        Me.PanelCabecera.Controls.Add(Me.LbSaldoini)
        Me.PanelCabecera.Controls.Add(Me.Lb12)
        Me.PanelCabecera.Controls.Add(Me.LbHfecha)
        Me.PanelCabecera.Controls.Add(Me.LbDfecha)
        Me.PanelCabecera.Controls.Add(Me.LbNomEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbEnvase)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.LbCodigo)
        Me.PanelCabecera.Controls.Add(Me.LbTipo)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.LbNombre)
        Me.PanelCabecera.Controls.Add(Me.Lb11)
        Me.PanelCabecera.Size = New System.Drawing.Size(962, 126)
        '
        'Panel3
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 126)
        Me.PanelConsulta.Size = New System.Drawing.Size(962, 368)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(662, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(737, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(812, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(887, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(587, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(711, 18)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(95, 16)
        Me.Lb6.TabIndex = 94
        Me.Lb6.Text = "Hasta fecha"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(459, 18)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(97, 16)
        Me.Lb7.TabIndex = 92
        Me.Lb7.Text = "Desde fecha"
        '
        'LbNombre
        '
        Me.LbNombre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = True
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombre.Location = New System.Drawing.Point(134, 56)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(346, 23)
        Me.LbNombre.TabIndex = 87
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(13, 59)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(58, 16)
        Me.Lb11.TabIndex = 84
        Me.Lb11.Text = "Código"
        '
        'LbTipo
        '
        Me.LbTipo.BackColor = System.Drawing.SystemColors.Control
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = True
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipo.Location = New System.Drawing.Point(13, 18)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(346, 23)
        Me.LbTipo.TabIndex = 96
        '
        'LbCodigo
        '
        Me.LbCodigo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = True
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCodigo.Location = New System.Drawing.Point(77, 56)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(51, 23)
        Me.LbCodigo.TabIndex = 97
        '
        'LbEnvase
        '
        Me.LbEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbEnvase.CL_ControlAsociado = Nothing
        Me.LbEnvase.CL_ValorFijo = True
        Me.LbEnvase.ClForm = Nothing
        Me.LbEnvase.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbEnvase.Location = New System.Drawing.Point(77, 87)
        Me.LbEnvase.Name = "LbEnvase"
        Me.LbEnvase.Size = New System.Drawing.Size(51, 23)
        Me.LbEnvase.TabIndex = 99
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(13, 90)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(61, 16)
        Me.Lb3.TabIndex = 98
        Me.Lb3.Text = "Envase"
        '
        'LbNomEnvase
        '
        Me.LbNomEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomEnvase.CL_ControlAsociado = Nothing
        Me.LbNomEnvase.CL_ValorFijo = True
        Me.LbNomEnvase.ClForm = Nothing
        Me.LbNomEnvase.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomEnvase.Location = New System.Drawing.Point(134, 88)
        Me.LbNomEnvase.Name = "LbNomEnvase"
        Me.LbNomEnvase.Size = New System.Drawing.Size(346, 23)
        Me.LbNomEnvase.TabIndex = 100
        '
        'LbDfecha
        '
        Me.LbDfecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDfecha.CL_ControlAsociado = Nothing
        Me.LbDfecha.CL_ValorFijo = True
        Me.LbDfecha.ClForm = Nothing
        Me.LbDfecha.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDfecha.Location = New System.Drawing.Point(562, 15)
        Me.LbDfecha.Name = "LbDfecha"
        Me.LbDfecha.Size = New System.Drawing.Size(138, 23)
        Me.LbDfecha.TabIndex = 101
        Me.LbDfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbHfecha
        '
        Me.LbHfecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbHfecha.CL_ControlAsociado = Nothing
        Me.LbHfecha.CL_ValorFijo = True
        Me.LbHfecha.ClForm = Nothing
        Me.LbHfecha.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbHfecha.Location = New System.Drawing.Point(812, 15)
        Me.LbHfecha.Name = "LbHfecha"
        Me.LbHfecha.Size = New System.Drawing.Size(138, 23)
        Me.LbHfecha.TabIndex = 102
        Me.LbHfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbSaldoini
        '
        Me.LbSaldoini.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbSaldoini.CL_ControlAsociado = Nothing
        Me.LbSaldoini.CL_ValorFijo = True
        Me.LbSaldoini.ClForm = Nothing
        Me.LbSaldoini.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldoini.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbSaldoini.Location = New System.Drawing.Point(609, 55)
        Me.LbSaldoini.Name = "LbSaldoini"
        Me.LbSaldoini.Size = New System.Drawing.Size(91, 23)
        Me.LbSaldoini.TabIndex = 104
        Me.LbSaldoini.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(490, 58)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(96, 16)
        Me.Lb12.TabIndex = 103
        Me.Lb12.Text = "Saldo Inicial"
        '
        'LbSaldoiniV
        '
        Me.LbSaldoiniV.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbSaldoiniV.CL_ControlAsociado = Nothing
        Me.LbSaldoiniV.CL_ValorFijo = True
        Me.LbSaldoiniV.ClForm = Nothing
        Me.LbSaldoiniV.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldoiniV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbSaldoiniV.Location = New System.Drawing.Point(856, 55)
        Me.LbSaldoiniV.Name = "LbSaldoiniV"
        Me.LbSaldoiniV.Size = New System.Drawing.Size(91, 23)
        Me.LbSaldoiniV.TabIndex = 106
        Me.LbSaldoiniV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(734, 58)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(110, 16)
        Me.Lb14.TabIndex = 105
        Me.Lb14.Text = "Saldo Inicial V"
        '
        'LbSaldoFinV
        '
        Me.LbSaldoFinV.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbSaldoFinV.CL_ControlAsociado = Nothing
        Me.LbSaldoFinV.CL_ValorFijo = True
        Me.LbSaldoFinV.ClForm = Nothing
        Me.LbSaldoFinV.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldoFinV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbSaldoFinV.Location = New System.Drawing.Point(856, 88)
        Me.LbSaldoFinV.Name = "LbSaldoFinV"
        Me.LbSaldoFinV.Size = New System.Drawing.Size(91, 23)
        Me.LbSaldoFinV.TabIndex = 110
        Me.LbSaldoFinV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(734, 91)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(109, 16)
        Me.Lb2.TabIndex = 109
        Me.Lb2.Text = "Saldo FINAL V"
        '
        'LbSaldoFin
        '
        Me.LbSaldoFin.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbSaldoFin.CL_ControlAsociado = Nothing
        Me.LbSaldoFin.CL_ValorFijo = True
        Me.LbSaldoFin.ClForm = Nothing
        Me.LbSaldoFin.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldoFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbSaldoFin.Location = New System.Drawing.Point(609, 88)
        Me.LbSaldoFin.Name = "LbSaldoFin"
        Me.LbSaldoFin.Size = New System.Drawing.Size(91, 23)
        Me.LbSaldoFin.TabIndex = 108
        Me.LbSaldoFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(490, 91)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(95, 16)
        Me.Lb5.TabIndex = 107
        Me.Lb5.Text = "Saldo FINAL"
        '
        'FrmExtractoEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmExtractoEnvases"
        Me.Text = "Extracto de envases"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents LbSaldoiniV As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents LbSaldoini As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents LbHfecha As NetAgro.Lb
    Friend WithEvents LbDfecha As NetAgro.Lb
    Friend WithEvents LbNomEnvase As NetAgro.Lb
    Friend WithEvents LbEnvase As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents LbSaldoFinV As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbSaldoFin As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
