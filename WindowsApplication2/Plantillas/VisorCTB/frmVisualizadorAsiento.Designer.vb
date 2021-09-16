<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisualizadorAsiento
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btVisualizar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.lblAsiento = New System.Windows.Forms.Label()
        Me.btImpresionDirecta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 8.75!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.ForeColor = System.Drawing.Color.Navy
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(475, 98)
        Me.ListBox1.TabIndex = 631
        '
        'btVisualizar
        '
        Me.btVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btVisualizar.Location = New System.Drawing.Point(400, 104)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btVisualizar.TabIndex = 2
        Me.btVisualizar.Text = "Visualizar"
        Me.btVisualizar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.Location = New System.Drawing.Point(0, 104)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'lblAsiento
        '
        Me.lblAsiento.Location = New System.Drawing.Point(90, 109)
        Me.lblAsiento.Name = "lblAsiento"
        Me.lblAsiento.Size = New System.Drawing.Size(125, 13)
        Me.lblAsiento.TabIndex = 634
        '
        'btImpresionDirecta
        '
        Me.btImpresionDirecta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImpresionDirecta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btImpresionDirecta.Location = New System.Drawing.Point(319, 104)
        Me.btImpresionDirecta.Name = "btImpresionDirecta"
        Me.btImpresionDirecta.Size = New System.Drawing.Size(75, 23)
        Me.btImpresionDirecta.TabIndex = 1
        Me.btImpresionDirecta.Text = "Imp.Directa"
        Me.btImpresionDirecta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImpresionDirecta.UseVisualStyleBackColor = True
        '
        'frmVisualizadorAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 131)
        Me.Controls.Add(Me.btImpresionDirecta)
        Me.Controls.Add(Me.lblAsiento)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.btVisualizar)
        Me.Controls.Add(Me.ListBox1)
        Me.MinimumSize = New System.Drawing.Size(313, 159)
        Me.Name = "frmVisualizadorAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de asientos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents lblAsiento As System.Windows.Forms.Label
    Friend WithEvents btImpresionDirecta As System.Windows.Forms.Button
End Class
