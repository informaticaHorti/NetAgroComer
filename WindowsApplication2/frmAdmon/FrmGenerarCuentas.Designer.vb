<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarCuentas))
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.chkDetallarClasificacion = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.chkDetallarClasificacion)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.ProgressBar1)
        Me.PanelCabecera.Controls.Add(Me.BtSelTodos)
        Me.PanelCabecera.Controls.Add(Me.BtSelNinguno)
        Me.PanelCabecera.Size = New System.Drawing.Size(922, 66)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 72)
        Me.PanelConsulta.Size = New System.Drawing.Size(922, 416)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(622, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(697, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(772, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(847, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(547, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(889, 34)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100296
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(862, 34)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100297
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(109, 35)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(747, 23)
        Me.ProgressBar1.TabIndex = 100298
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(29, 38)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(73, 16)
        Me.Lb3.TabIndex = 100299
        Me.Lb3.Text = "Progreso"
        '
        'chkDetallarClasificacion
        '
        Me.chkDetallarClasificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDetallarClasificacion.AutoSize = True
        Me.chkDetallarClasificacion.Campobd = Nothing
        Me.chkDetallarClasificacion.ClForm = Nothing
        Me.chkDetallarClasificacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetallarClasificacion.ForeColor = System.Drawing.Color.Teal
        Me.chkDetallarClasificacion.GridLin = Nothing
        Me.chkDetallarClasificacion.HaCambiado = False
        Me.chkDetallarClasificacion.Location = New System.Drawing.Point(36, 9)
        Me.chkDetallarClasificacion.MiEntidad = Nothing
        Me.chkDetallarClasificacion.MiError = False
        Me.chkDetallarClasificacion.Name = "chkDetallarClasificacion"
        Me.chkDetallarClasificacion.Orden = 0
        Me.chkDetallarClasificacion.SaltoAlfinal = False
        Me.chkDetallarClasificacion.Size = New System.Drawing.Size(330, 20)
        Me.chkDetallarClasificacion.TabIndex = 100300
        Me.chkDetallarClasificacion.Text = "Actualizar solo NIF de cuentas de clientes"
        Me.chkDetallarClasificacion.UseVisualStyleBackColor = True
        Me.chkDetallarClasificacion.ValorCampoFalse = Nothing
        Me.chkDetallarClasificacion.ValorCampoTrue = Nothing
        Me.chkDetallarClasificacion.ValorDefecto = False
        '
        'FrmGenerarCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGenerarCuentas"
        Me.Text = "Generar cuentas agricultores y clientes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents chkDetallarClasificacion As NetAgro.Chk
End Class
