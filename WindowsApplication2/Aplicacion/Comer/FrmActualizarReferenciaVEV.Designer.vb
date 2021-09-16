<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarReferenciaVEV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarReferenciaVEV))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.btSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.btSelTodos)
        Me.PanelCabecera.Controls.Add(Me.LbEjercicio)
        Me.PanelCabecera.Controls.Add(Me.ProgressBar1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 53)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 53)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 475)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(934, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1009, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1084, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1159, 0)
        '
        'BtAux
        '
        Me.BtAux.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        Me.BtAux.Text = "Actualizar"
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(668, 21)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(416, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'LbEjercicio
        '
        Me.LbEjercicio.BackColor = System.Drawing.Color.White
        Me.LbEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbEjercicio.CL_ControlAsociado = Nothing
        Me.LbEjercicio.CL_ValorFijo = True
        Me.LbEjercicio.ClForm = Nothing
        Me.LbEjercicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicio.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicio.Location = New System.Drawing.Point(104, 18)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(32, 23)
        Me.LbEjercicio.TabIndex = 84
        Me.LbEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(1169, 25)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 100306
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(1196, 25)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 100305
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(28, 21)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(70, 16)
        Me.Lb1.TabIndex = 100307
        Me.Lb1.Text = "Ejercicio"
        '
        'FrmActualizarReferenciaVEV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmActualizarReferenciaVEV"
        Me.Text = "Actualizar referencias VEV"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LbEjercicio As NetAgro.Lb
    Friend WithEvents btSelNinguno As System.Windows.Forms.Button
    Friend WithEvents btSelTodos As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
End Class
