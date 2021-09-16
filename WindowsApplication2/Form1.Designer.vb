<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form
    'Inherits NetAgro.FrMantenimiento

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
        Me.pnlBotonesGD = New NetAgro.GridEditable()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.SuspendLayout()
        '
        'pnlBotonesGD
        '
        Me.pnlBotonesGD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBotonesGD.DataSource = Nothing
        Me.pnlBotonesGD.Location = New System.Drawing.Point(23, 44)
        Me.pnlBotonesGD.Name = "pnlBotonesGD"
        Me.pnlBotonesGD.NavegarSoloEditables = False
        Me.pnlBotonesGD.Orden = 0
        Me.pnlBotonesGD.Size = New System.Drawing.Size(1136, 243)
        Me.pnlBotonesGD.TabIndex = 4
        '
        'ClButton1
        '
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Copy_16
        Me.ClButton1.Location = New System.Drawing.Point(386, 293)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(75, 23)
        Me.ClButton1.TabIndex = 5
        Me.ClButton1.Text = "ClButton1"
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 320)
        Me.Controls.Add(Me.ClButton1)
        Me.Controls.Add(Me.pnlBotonesGD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotonesGD As NetAgro.GridEditable
    Friend WithEvents ClButton1 As NetAgro.ClButton
End Class
