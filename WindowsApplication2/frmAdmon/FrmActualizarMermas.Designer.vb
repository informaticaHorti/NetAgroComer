<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarMermas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarMermas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 34)
        Me.Panel1.TabIndex = 3
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(480, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Actualizar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(545, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(16, 18)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(321, 16)
        Me.Lb6.TabIndex = 100279
        Me.Lb6.Text = "Calcular las mermas de las líneas de palets"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(19, 47)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(547, 23)
        Me.ProgressBar1.TabIndex = 100280
        '
        'FrmActualizarMermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(610, 126)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmActualizarMermas"
        Me.Text = "Actualizar Mermas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
