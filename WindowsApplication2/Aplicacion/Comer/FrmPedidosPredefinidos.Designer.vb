<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidosPredefinidos
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
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.PanelGreditable = New System.Windows.Forms.Panel()
        Me.GridEditable = New NetAgro.GridEditable()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RbNo = New System.Windows.Forms.RadioButton()
        Me.RbSi = New System.Windows.Forms.RadioButton()
        Me.TxLote = New NetAgro.TxDato(Me.components)
        Me.LbLote = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.PanelGreditable.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.TxLote)
        Me.PanelCabecera.Controls.Add(Me.LbLote)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1284, 64)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(2, 92)
        Me.PanelConsulta.Size = New System.Drawing.Size(1284, 150)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(984, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1059, 0)
        '
        'BInforme
        '
        Me.BInforme.Image = Global.NetAgro.My.Resources.Resources.Action_window_no_fullscreen_16x16_32
        Me.BInforme.Location = New System.Drawing.Point(1134, 0)
        Me.BInforme.Text = "Insertar"
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1209, 0)
        '
        'PlantillaConsulta1
        '
        Me.PlantillaConsulta1.Visible = False
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(909, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelEditable.Controls.Add(Me.PanelGreditable)
        Me.PanelEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditable.Location = New System.Drawing.Point(0, 64)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(1284, 381)
        Me.PanelEditable.TabIndex = 14
        '
        'PanelGreditable
        '
        Me.PanelGreditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGreditable.Controls.Add(Me.GridEditable)
        Me.PanelGreditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGreditable.Location = New System.Drawing.Point(0, 0)
        Me.PanelGreditable.Name = "PanelGreditable"
        Me.PanelGreditable.Size = New System.Drawing.Size(1284, 381)
        Me.PanelGreditable.TabIndex = 139
        '
        'GridEditable
        '
        Me.GridEditable.DataSource = Nothing
        Me.GridEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEditable.Location = New System.Drawing.Point(0, 0)
        Me.GridEditable.Name = "GridEditable"
        Me.GridEditable.NavegarSoloEditables = False
        Me.GridEditable.Orden = -1
        Me.GridEditable.Size = New System.Drawing.Size(1284, 381)
        Me.GridEditable.TabIndex = 140
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RbTodos)
        Me.GroupBox1.Controls.Add(Me.RbNo)
        Me.GroupBox1.Controls.Add(Me.RbSi)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(1074, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 41)
        Me.GroupBox1.TabIndex = 100276
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activos"
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbTodos.Location = New System.Drawing.Point(112, 16)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbTodos.TabIndex = 3
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RbNo
        '
        Me.RbNo.AutoSize = True
        Me.RbNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNo.ForeColor = System.Drawing.Color.Teal
        Me.RbNo.Location = New System.Drawing.Point(61, 16)
        Me.RbNo.Name = "RbNo"
        Me.RbNo.Size = New System.Drawing.Size(45, 20)
        Me.RbNo.TabIndex = 2
        Me.RbNo.Text = "No"
        Me.RbNo.UseVisualStyleBackColor = True
        '
        'RbSi
        '
        Me.RbSi.AutoSize = True
        Me.RbSi.Checked = True
        Me.RbSi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSi.ForeColor = System.Drawing.Color.Teal
        Me.RbSi.Location = New System.Drawing.Point(16, 16)
        Me.RbSi.Name = "RbSi"
        Me.RbSi.Size = New System.Drawing.Size(39, 20)
        Me.RbSi.TabIndex = 0
        Me.RbSi.TabStop = True
        Me.RbSi.Text = "Si"
        Me.RbSi.UseVisualStyleBackColor = True
        '
        'TxLote
        '
        Me.TxLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxLote.Autonumerico = False
        Me.TxLote.Buscando = False
        Me.TxLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxLote.ClForm = Nothing
        Me.TxLote.ClParam = Nothing
        Me.TxLote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxLote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxLote.GridLin = Nothing
        Me.TxLote.HaCambiado = False
        Me.TxLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxLote.lbbusca = Nothing
        Me.TxLote.Location = New System.Drawing.Point(901, 25)
        Me.TxLote.MiError = False
        Me.TxLote.Name = "TxLote"
        Me.TxLote.Orden = 0
        Me.TxLote.SaltoAlfinal = False
        Me.TxLote.Siguiente = 0
        Me.TxLote.Size = New System.Drawing.Size(149, 22)
        Me.TxLote.TabIndex = 100372
        Me.TxLote.TeclaRepetida = False
        Me.TxLote.TxDatoFinalSemana = Nothing
        Me.TxLote.TxDatoInicioSemana = Nothing
        Me.TxLote.UltimoValorValidado = Nothing
        '
        'LbLote
        '
        Me.LbLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLote.AutoSize = True
        Me.LbLote.CL_ControlAsociado = Nothing
        Me.LbLote.CL_ValorFijo = False
        Me.LbLote.ClForm = Nothing
        Me.LbLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.ForeColor = System.Drawing.Color.Teal
        Me.LbLote.Location = New System.Drawing.Point(855, 28)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(40, 16)
        Me.LbLote.TabIndex = 100371
        Me.LbLote.Text = "Lote"
        '
        'FrmPedidosPredefinidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 479)
        Me.Controls.Add(Me.PanelEditable)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmPedidosPredefinidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insertar líneas de pedido habituales"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.PanelEditable, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelGreditable.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEditable As System.Windows.Forms.Panel
    Friend WithEvents PanelGreditable As System.Windows.Forms.Panel
    Friend WithEvents GridEditable As NetAgro.GridEditable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbSi As System.Windows.Forms.RadioButton
    Friend WithEvents TxLote As NetAgro.TxDato
    Friend WithEvents LbLote As NetAgro.Lb
End Class
