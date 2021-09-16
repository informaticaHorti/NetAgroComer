<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionPedidosEDI2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecepcionPedidosEDI2))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.ChkMostrarReemplazos = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(814, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(889, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(964, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1039, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(739, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(840, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(199, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 100356
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(1072, 17)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100354
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(1045, 17)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100355
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'ChkMostrarReemplazos
        '
        Me.ChkMostrarReemplazos.AutoSize = True
        Me.ChkMostrarReemplazos.Checked = True
        Me.ChkMostrarReemplazos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMostrarReemplazos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ChkMostrarReemplazos.ForeColor = System.Drawing.Color.Teal
        Me.ChkMostrarReemplazos.Location = New System.Drawing.Point(18, 15)
        Me.ChkMostrarReemplazos.Name = "ChkMostrarReemplazos"
        Me.ChkMostrarReemplazos.Size = New System.Drawing.Size(268, 20)
        Me.ChkMostrarReemplazos.TabIndex = 11
        Me.ChkMostrarReemplazos.Text = "Mostrar solicitudes de reemplazo"
        Me.ChkMostrarReemplazos.UseVisualStyleBackColor = True
        Me.ChkMostrarReemplazos.Visible = False
        '
        'FrmRecepcionPedidosEDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmRecepcionPedidosEDI"
        Me.Text = "Recepción de pedidos EDI"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents ChkMostrarReemplazos As System.Windows.Forms.CheckBox
End Class
