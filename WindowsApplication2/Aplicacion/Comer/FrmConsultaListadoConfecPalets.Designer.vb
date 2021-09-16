<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaListadoConfecPalets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaListadoConfecPalets))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbResumido = New System.Windows.Forms.RadioButton()
        Me.RbDetallado = New System.Windows.Forms.RadioButton()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1023, 64)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 59)
        Me.PanelConsulta.Size = New System.Drawing.Size(1023, 463)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(723, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(798, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(873, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(948, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(648, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbResumido)
        Me.GroupBox2.Controls.Add(Me.RbDetallado)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(22, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 42)
        Me.GroupBox2.TabIndex = 100274
        Me.GroupBox2.TabStop = False
        '
        'RbResumido
        '
        Me.RbResumido.AutoSize = True
        Me.RbResumido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbResumido.ForeColor = System.Drawing.Color.Teal
        Me.RbResumido.Location = New System.Drawing.Point(178, 16)
        Me.RbResumido.Name = "RbResumido"
        Me.RbResumido.Size = New System.Drawing.Size(97, 20)
        Me.RbResumido.TabIndex = 1
        Me.RbResumido.Text = "Resumido"
        Me.RbResumido.UseVisualStyleBackColor = True
        '
        'RbDetallado
        '
        Me.RbDetallado.AutoSize = True
        Me.RbDetallado.Checked = True
        Me.RbDetallado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetallado.ForeColor = System.Drawing.Color.Teal
        Me.RbDetallado.Location = New System.Drawing.Point(16, 16)
        Me.RbDetallado.Name = "RbDetallado"
        Me.RbDetallado.Size = New System.Drawing.Size(95, 20)
        Me.RbDetallado.TabIndex = 0
        Me.RbDetallado.TabStop = True
        Me.RbDetallado.Text = "Detallado"
        Me.RbDetallado.UseVisualStyleBackColor = True
        '
        'FrmConsultaListadoConfecEnvase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaListadoConfecEnvase"
        Me.Text = "Consulta Listado Confecciones Palets"
        Me.PanelCabecera.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents RbDetallado As System.Windows.Forms.RadioButton
End Class
