<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescripcionGeneroPorIdioma
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
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.LbIdGenero = New NetAgro.Lb(Me.components)
        Me.LbNombreGenero = New NetAgro.Lb(Me.components)
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.PanelGreditable = New System.Windows.Forms.Panel()
        Me.GridEditable = New NetAgro.GridEditable()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.PanelGreditable.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbNombreGenero)
        Me.PanelCabecera.Controls.Add(Me.LbIdGenero)
        Me.PanelCabecera.Controls.Add(Me.LbGenero)
        Me.PanelCabecera.Size = New System.Drawing.Size(884, 57)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(2, 161)
        Me.PanelConsulta.Size = New System.Drawing.Size(884, 0)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(584, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(659, 0)
        '
        'BInforme
        '
        Me.BInforme.Image = Global.NetAgro.My.Resources.Resources.RibbonPrintPreview_ExportFile
        Me.BInforme.Location = New System.Drawing.Point(734, 0)
        Me.BInforme.Text = "Guardar"
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(809, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(509, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(12, 21)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(60, 16)
        Me.LbGenero.TabIndex = 133
        Me.LbGenero.Text = "Genero"
        '
        'LbIdGenero
        '
        Me.LbIdGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbIdGenero.CL_ControlAsociado = Nothing
        Me.LbIdGenero.CL_ValorFijo = False
        Me.LbIdGenero.ClForm = Nothing
        Me.LbIdGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdGenero.Location = New System.Drawing.Point(146, 18)
        Me.LbIdGenero.Name = "LbIdGenero"
        Me.LbIdGenero.Size = New System.Drawing.Size(80, 23)
        Me.LbIdGenero.TabIndex = 135
        '
        'LbNombreGenero
        '
        Me.LbNombreGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreGenero.CL_ControlAsociado = Nothing
        Me.LbNombreGenero.CL_ValorFijo = False
        Me.LbNombreGenero.ClForm = Nothing
        Me.LbNombreGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreGenero.Location = New System.Drawing.Point(233, 18)
        Me.LbNombreGenero.Name = "LbNombreGenero"
        Me.LbNombreGenero.Size = New System.Drawing.Size(495, 23)
        Me.LbNombreGenero.TabIndex = 136
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelEditable.Controls.Add(Me.PanelGreditable)
        Me.PanelEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditable.Location = New System.Drawing.Point(0, 57)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(884, 342)
        Me.PanelEditable.TabIndex = 13
        '
        'PanelGreditable
        '
        Me.PanelGreditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGreditable.Controls.Add(Me.GridEditable)
        Me.PanelGreditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGreditable.Location = New System.Drawing.Point(0, 0)
        Me.PanelGreditable.Name = "PanelGreditable"
        Me.PanelGreditable.Size = New System.Drawing.Size(884, 342)
        Me.PanelGreditable.TabIndex = 139
        '
        'GridEditable
        '
        Me.GridEditable.DataSource = Nothing
        Me.GridEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEditable.Location = New System.Drawing.Point(0, 0)
        Me.GridEditable.Name = "GridEditable"
        Me.GridEditable.NavegarSoloEditables = False
        Me.GridEditable.Orden = -1
        Me.GridEditable.Size = New System.Drawing.Size(884, 342)
        Me.GridEditable.TabIndex = 15
        '
        'FrmDescripcionGeneroPorIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 433)
        Me.Controls.Add(Me.PanelEditable)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmDescripcionGeneroPorIdioma"
        Me.Text = "Descripción de géneros por idioma"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.PanelEditable, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelGreditable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents LbNombreGenero As NetAgro.Lb
    Friend WithEvents LbIdGenero As NetAgro.Lb
    Friend WithEvents PanelEditable As System.Windows.Forms.Panel
    Friend WithEvents PanelGreditable As System.Windows.Forms.Panel
    Friend WithEvents GridEditable As NetAgro.GridEditable
End Class
