<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebBrowser
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
        Me.pnlWebBrowser = New System.Windows.Forms.Panel()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'pnlWebBrowser
        '
        Me.pnlWebBrowser.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.pnlWebBrowser.Name = "pnlWebBrowser"
        Me.pnlWebBrowser.Size = New System.Drawing.Size(1007, 600)
        Me.pnlWebBrowser.TabIndex = 15
        '
        'bw
        '
        '
        'FrmWebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1007, 600)
        Me.Controls.Add(Me.pnlWebBrowser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWebBrowser"
        Me.Text = "Navegador"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnlWebBrowser As System.Windows.Forms.Panel
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
End Class
