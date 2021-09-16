<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscaneoPagosLiquidaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEscaneoPagosLiquidaciones))
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ChkBorrar = New NetAgro.Chk(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.LbRuta = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbRuta)
        Me.PanelCabecera.Controls.Add(Me.btSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.btSelTodos)
        Me.PanelCabecera.Controls.Add(Me.ProgressBar1)
        Me.PanelCabecera.Controls.Add(Me.ChkBorrar)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Size = New System.Drawing.Size(922, 105)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 105)
        Me.PanelConsulta.Size = New System.Drawing.Size(922, 389)
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
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(22, 14)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(138, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Carpeta de origen"
        '
        'ChkBorrar
        '
        Me.ChkBorrar.AutoSize = True
        Me.ChkBorrar.Campobd = Nothing
        Me.ChkBorrar.Checked = True
        Me.ChkBorrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBorrar.ClForm = Nothing
        Me.ChkBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBorrar.ForeColor = System.Drawing.Color.Teal
        Me.ChkBorrar.GridLin = Nothing
        Me.ChkBorrar.HaCambiado = False
        Me.ChkBorrar.Location = New System.Drawing.Point(25, 43)
        Me.ChkBorrar.MiEntidad = Nothing
        Me.ChkBorrar.MiError = False
        Me.ChkBorrar.Name = "ChkBorrar"
        Me.ChkBorrar.Orden = 0
        Me.ChkBorrar.SaltoAlfinal = False
        Me.ChkBorrar.Size = New System.Drawing.Size(211, 20)
        Me.ChkBorrar.TabIndex = 100298
        Me.ChkBorrar.Text = "Borrar archivos en origen"
        Me.ChkBorrar.UseVisualStyleBackColor = True
        Me.ChkBorrar.ValorCampoFalse = Nothing
        Me.ChkBorrar.ValorCampoTrue = Nothing
        Me.ChkBorrar.ValorDefecto = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(652, 42)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(258, 23)
        Me.ProgressBar1.TabIndex = 100299
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(852, 77)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 100306
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(879, 77)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 100305
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'LbRuta
        '
        Me.LbRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbRuta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbRuta.CL_ControlAsociado = Nothing
        Me.LbRuta.CL_ValorFijo = False
        Me.LbRuta.ClForm = Nothing
        Me.LbRuta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRuta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbRuta.Location = New System.Drawing.Point(166, 12)
        Me.LbRuta.Name = "LbRuta"
        Me.LbRuta.Size = New System.Drawing.Size(744, 23)
        Me.LbRuta.TabIndex = 100307
        '
        'FrmEscaneoPagosLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEscaneoPagosLiquidaciones"
        Me.Text = "Procesar Pagos de Liquidaciones Escaneados"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents ChkBorrar As NetAgro.Chk
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btSelNinguno As System.Windows.Forms.Button
    Friend WithEvents btSelTodos As System.Windows.Forms.Button
    Friend WithEvents LbRuta As NetAgro.Lb
End Class
