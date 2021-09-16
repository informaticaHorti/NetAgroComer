<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMantenimiento))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTTraza = New System.Windows.Forms.Button()
        Me.BtImprimirForm = New NetAgro.ClButton()
        Me.BtDoc = New NetAgro.ClButton()
        Me.BtAux3 = New NetAgro.ClButton()
        Me.BtAux2 = New NetAgro.ClButton()
        Me.BTaux1 = New NetAgro.ClButton()
        Me.Button1 = New NetAgro.ClButton()
        Me.PanelId = New System.Windows.Forms.Panel()
        Me.LbId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BGuardar = New NetAgro.ClButton()
        Me.BModificar = New NetAgro.ClButton()
        Me.BAnular = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me._BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.IconoError = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.PanelId.SuspendLayout()
        CType(Me.IconoError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTTraza)
        Me.Panel1.Controls.Add(Me.BtImprimirForm)
        Me.Panel1.Controls.Add(Me.BtDoc)
        Me.Panel1.Controls.Add(Me.BtAux3)
        Me.Panel1.Controls.Add(Me.BtAux2)
        Me.Panel1.Controls.Add(Me.BTaux1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PanelId)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.BModificar)
        Me.Panel1.Controls.Add(Me.BAnular)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 426)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 34)
        Me.Panel1.TabIndex = 2
        '
        'BTTraza
        '
        Me.BTTraza.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTTraza.Image = CType(resources.GetObject("BTTraza.Image"), System.Drawing.Image)
        Me.BTTraza.Location = New System.Drawing.Point(134, 0)
        Me.BTTraza.Name = "BTTraza"
        Me.BTTraza.Size = New System.Drawing.Size(20, 34)
        Me.BTTraza.TabIndex = 110
        Me.BTTraza.UseVisualStyleBackColor = True
        '
        'BtImprimirForm
        '
        Me.BtImprimirForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtImprimirForm.Image = Global.NetAgro.My.Resources.Resources.Action_frame_print_24x24_32
        Me.BtImprimirForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtImprimirForm.Location = New System.Drawing.Point(95, 0)
        Me.BtImprimirForm.Name = "BtImprimirForm"
        Me.BtImprimirForm.Orden = 0
        Me.BtImprimirForm.PedirClave = True
        Me.BtImprimirForm.Size = New System.Drawing.Size(39, 34)
        Me.BtImprimirForm.TabIndex = 108
        Me.BtImprimirForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtImprimirForm.UseVisualStyleBackColor = True
        '
        'BtDoc
        '
        Me.BtDoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtDoc.Image = Global.NetAgro.My.Resources.Resources.GD_INACTIVO
        Me.BtDoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtDoc.Location = New System.Drawing.Point(56, 0)
        Me.BtDoc.Name = "BtDoc"
        Me.BtDoc.Orden = 0
        Me.BtDoc.PedirClave = True
        Me.BtDoc.Size = New System.Drawing.Size(39, 34)
        Me.BtDoc.TabIndex = 107
        Me.BtDoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtDoc.UseVisualStyleBackColor = True
        '
        'BtAux3
        '
        Me.BtAux3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux3.Location = New System.Drawing.Point(72, 0)
        Me.BtAux3.Name = "BtAux3"
        Me.BtAux3.Orden = 0
        Me.BtAux3.PedirClave = True
        Me.BtAux3.Size = New System.Drawing.Size(65, 34)
        Me.BtAux3.TabIndex = 106
        Me.BtAux3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux3.UseVisualStyleBackColor = True
        Me.BtAux3.Visible = False
        '
        'BtAux2
        '
        Me.BtAux2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux2.Location = New System.Drawing.Point(137, 0)
        Me.BtAux2.Name = "BtAux2"
        Me.BtAux2.Orden = 0
        Me.BtAux2.PedirClave = True
        Me.BtAux2.Size = New System.Drawing.Size(65, 34)
        Me.BtAux2.TabIndex = 105
        Me.BtAux2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux2.UseVisualStyleBackColor = True
        Me.BtAux2.Visible = False
        '
        'BTaux1
        '
        Me.BTaux1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTaux1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTaux1.Location = New System.Drawing.Point(202, 0)
        Me.BTaux1.Name = "BTaux1"
        Me.BTaux1.Orden = 0
        Me.BTaux1.PedirClave = True
        Me.BTaux1.Size = New System.Drawing.Size(65, 34)
        Me.BTaux1.TabIndex = 104
        Me.BTaux1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTaux1.UseVisualStyleBackColor = True
        Me.BTaux1.Visible = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(267, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Orden = 0
        Me.Button1.PedirClave = True
        Me.Button1.Size = New System.Drawing.Size(65, 34)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PanelId
        '
        Me.PanelId.Controls.Add(Me.LbId)
        Me.PanelId.Controls.Add(Me.Label1)
        Me.PanelId.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelId.Location = New System.Drawing.Point(0, 0)
        Me.PanelId.Name = "PanelId"
        Me.PanelId.Size = New System.Drawing.Size(56, 34)
        Me.PanelId.TabIndex = 102
        '
        'LbId
        '
        Me.LbId.BackColor = System.Drawing.Color.White
        Me.LbId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbId.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LbId.Location = New System.Drawing.Point(0, 13)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(56, 21)
        Me.LbId.TabIndex = 1
        Me.LbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(332, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(90, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar (F10)"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BModificar.Image = CType(resources.GetObject("BModificar.Image"), System.Drawing.Image)
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BModificar.Location = New System.Drawing.Point(422, 0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Orden = 0
        Me.BModificar.PedirClave = True
        Me.BModificar.Size = New System.Drawing.Size(90, 34)
        Me.BModificar.TabIndex = 98
        Me.BModificar.Text = "Modificar (F9)"
        Me.BModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BAnular
        '
        Me.BAnular.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAnular.Image = CType(resources.GetObject("BAnular.Image"), System.Drawing.Image)
        Me.BAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAnular.Location = New System.Drawing.Point(512, 0)
        Me.BAnular.Name = "BAnular"
        Me.BAnular.Orden = 0
        Me.BAnular.PedirClave = True
        Me.BAnular.Size = New System.Drawing.Size(65, 34)
        Me.BAnular.TabIndex = 99
        Me.BAnular.Text = "Anular"
        Me.BAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnular.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(577, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(70, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir (F12)"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        '_BackgroundWorker
        '
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'IconoError
        '
        Me.IconoError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IconoError.Enabled = False
        Me.IconoError.Image = CType(resources.GetObject("IconoError.Image"), System.Drawing.Image)
        Me.IconoError.Location = New System.Drawing.Point(0, -2)
        Me.IconoError.Name = "IconoError"
        Me.IconoError.Size = New System.Drawing.Size(17, 17)
        Me.IconoError.TabIndex = 1
        Me.IconoError.TabStop = False
        Me.IconoError.Visible = False
        '
        'FrMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconoError)
        Me.Name = "FrMantenimiento"
        Me.Text = "Formulario de Mantenimiento"
        Me.Panel1.ResumeLayout(False)
        Me.PanelId.ResumeLayout(False)
        CType(Me.IconoError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconoError As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents BAnular As NetAgro.ClButton
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents BModificar As NetAgro.ClButton
    Friend WithEvents PanelId As System.Windows.Forms.Panel
    Friend WithEvents LbId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As NetAgro.ClButton
    Friend WithEvents BtAux3 As NetAgro.ClButton
    Friend WithEvents BtAux2 As NetAgro.ClButton
    Friend WithEvents BTaux1 As NetAgro.ClButton
    Friend WithEvents _BackgroundWorker As System.ComponentModel.BackgroundWorker
    Public WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents BtImprimirForm As NetAgro.ClButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Public WithEvents BtDoc As NetAgro.ClButton
    Friend WithEvents BTTraza As System.Windows.Forms.Button
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
