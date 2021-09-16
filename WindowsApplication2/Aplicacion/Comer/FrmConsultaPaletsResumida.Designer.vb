<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPaletsResumida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPaletsResumida))
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RbNoEnExistencias = New System.Windows.Forms.RadioButton()
        Me.RbEnExistencias = New System.Windows.Forms.RadioButton()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNumPalets = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTodasEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.rbNOEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.rbEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.Panel2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.CbFamilias)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.cbPuntoVenta)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Size = New System.Drawing.Size(1234, 97)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 103)
        Me.Panel3.Size = New System.Drawing.Size(1234, 397)
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
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(132, 41)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 83
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(13, 44)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 82
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(132, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 81
        Me.TxDato1.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Desde fecha"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(410, 14)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(203, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(286, 16)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(118, 16)
        Me.Lb3.TabIndex = 100272
        Me.Lb3.Text = "Punto de venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodos)
        Me.GroupBox2.Controls.Add(Me.RbNoEnExistencias)
        Me.GroupBox2.Controls.Add(Me.RbEnExistencias)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(283, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "En existencias"
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Checked = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbTodos.Location = New System.Drawing.Point(154, 16)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbTodos.TabIndex = 2
        Me.RbTodos.TabStop = True
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RbNoEnExistencias
        '
        Me.RbNoEnExistencias.AutoSize = True
        Me.RbNoEnExistencias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoEnExistencias.ForeColor = System.Drawing.Color.Teal
        Me.RbNoEnExistencias.Location = New System.Drawing.Point(79, 16)
        Me.RbNoEnExistencias.Name = "RbNoEnExistencias"
        Me.RbNoEnExistencias.Size = New System.Drawing.Size(47, 20)
        Me.RbNoEnExistencias.TabIndex = 1
        Me.RbNoEnExistencias.Text = "NO"
        Me.RbNoEnExistencias.UseVisualStyleBackColor = True
        '
        'RbEnExistencias
        '
        Me.RbEnExistencias.AutoSize = True
        Me.RbEnExistencias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnExistencias.ForeColor = System.Drawing.Color.Teal
        Me.RbEnExistencias.Location = New System.Drawing.Point(16, 16)
        Me.RbEnExistencias.Name = "RbEnExistencias"
        Me.RbEnExistencias.Size = New System.Drawing.Size(41, 20)
        Me.RbEnExistencias.TabIndex = 0
        Me.RbEnExistencias.Text = "SI"
        Me.RbEnExistencias.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(665, 16)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(69, 16)
        Me.Lb4.TabIndex = 100275
        Me.Lb4.Text = "Familias"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(740, 14)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(203, 20)
        Me.CbFamilias.TabIndex = 100274
        '
        'LbNumPalets
        '
        Me.LbNumPalets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbNumPalets.AutoSize = True
        Me.LbNumPalets.BackColor = System.Drawing.Color.Transparent
        Me.LbNumPalets.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumPalets.ForeColor = System.Drawing.Color.Blue
        Me.LbNumPalets.Location = New System.Drawing.Point(7, 507)
        Me.LbNumPalets.Name = "LbNumPalets"
        Me.LbNumPalets.Size = New System.Drawing.Size(95, 18)
        Me.LbNumPalets.TabIndex = 11
        Me.LbNumPalets.Text = "Nº Palets:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTodasEntradasConfeccionadas)
        Me.GroupBox3.Controls.Add(Me.rbNOEntradasConfeccionadas)
        Me.GroupBox3.Controls.Add(Me.rbEntradasConfeccionadas)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(532, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox3.TabIndex = 100278
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entradas confeccionadas"
        '
        'rbTodasEntradasConfeccionadas
        '
        Me.rbTodasEntradasConfeccionadas.AutoSize = True
        Me.rbTodasEntradasConfeccionadas.Checked = True
        Me.rbTodasEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodasEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbTodasEntradasConfeccionadas.Location = New System.Drawing.Point(154, 16)
        Me.rbTodasEntradasConfeccionadas.Name = "rbTodasEntradasConfeccionadas"
        Me.rbTodasEntradasConfeccionadas.Size = New System.Drawing.Size(69, 20)
        Me.rbTodasEntradasConfeccionadas.TabIndex = 2
        Me.rbTodasEntradasConfeccionadas.TabStop = True
        Me.rbTodasEntradasConfeccionadas.Text = "Todos"
        Me.rbTodasEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'rbNOEntradasConfeccionadas
        '
        Me.rbNOEntradasConfeccionadas.AutoSize = True
        Me.rbNOEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbNOEntradasConfeccionadas.Location = New System.Drawing.Point(79, 16)
        Me.rbNOEntradasConfeccionadas.Name = "rbNOEntradasConfeccionadas"
        Me.rbNOEntradasConfeccionadas.Size = New System.Drawing.Size(47, 20)
        Me.rbNOEntradasConfeccionadas.TabIndex = 1
        Me.rbNOEntradasConfeccionadas.Text = "NO"
        Me.rbNOEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'rbEntradasConfeccionadas
        '
        Me.rbEntradasConfeccionadas.AutoSize = True
        Me.rbEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbEntradasConfeccionadas.Location = New System.Drawing.Point(16, 16)
        Me.rbEntradasConfeccionadas.Name = "rbEntradasConfeccionadas"
        Me.rbEntradasConfeccionadas.Size = New System.Drawing.Size(41, 20)
        Me.rbEntradasConfeccionadas.TabIndex = 0
        Me.rbEntradasConfeccionadas.Text = "SI"
        Me.rbEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'FrmConsultaPaletsResumida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.LbNumPalets)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaPaletsResumida"
        Me.Text = "Consulta palets resumida"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.LbNumPalets, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoEnExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbNumPalets As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodasEntradasConfeccionadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbNOEntradasConfeccionadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbEntradasConfeccionadas As System.Windows.Forms.RadioButton
End Class
