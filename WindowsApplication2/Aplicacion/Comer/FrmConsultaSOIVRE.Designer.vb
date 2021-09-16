<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSOIVRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSOIVRE))
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxAFecha = New NetAgro.TxDato(Me.components)
        Me.LbDeFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSubFamilias = New System.Windows.Forms.RadioButton()
        Me.rbFamilias = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbNoComunitario = New System.Windows.Forms.RadioButton()
        Me.rbComunitario = New System.Windows.Forms.RadioButton()
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxAFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(895, 105)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 108)
        Me.PanelConsulta.Size = New System.Drawing.Size(895, 413)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(595, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(670, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(745, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(820, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(520, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(222, 43)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(66, 16)
        Me.LbAFecha.TabIndex = 100289
        Me.LbAFecha.Text = "A Fecha"
        '
        'TxAFecha
        '
        Me.TxAFecha.Autonumerico = False
        Me.TxAFecha.Buscando = False
        Me.TxAFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAFecha.ClForm = Nothing
        Me.TxAFecha.ClParam = Nothing
        Me.TxAFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAFecha.GridLin = Nothing
        Me.TxAFecha.HaCambiado = False
        Me.TxAFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAFecha.lbbusca = Nothing
        Me.TxAFecha.Location = New System.Drawing.Point(294, 40)
        Me.TxAFecha.MiError = False
        Me.TxAFecha.Name = "TxAFecha"
        Me.TxAFecha.Orden = 0
        Me.TxAFecha.SaltoAlfinal = False
        Me.TxAFecha.Siguiente = 0
        Me.TxAFecha.Size = New System.Drawing.Size(95, 22)
        Me.TxAFecha.TabIndex = 100288
        Me.TxAFecha.TeclaRepetida = False
        Me.TxAFecha.TxDatoFinalSemana = Nothing
        Me.TxAFecha.TxDatoInicioSemana = Nothing
        Me.TxAFecha.UltimoValorValidado = Nothing
        '
        'LbDeFecha
        '
        Me.LbDeFecha.AutoSize = True
        Me.LbDeFecha.CL_ControlAsociado = Nothing
        Me.LbDeFecha.CL_ValorFijo = False
        Me.LbDeFecha.ClForm = Nothing
        Me.LbDeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDeFecha.Location = New System.Drawing.Point(12, 43)
        Me.LbDeFecha.Name = "LbDeFecha"
        Me.LbDeFecha.Size = New System.Drawing.Size(75, 16)
        Me.LbDeFecha.TabIndex = 100285
        Me.LbDeFecha.Text = "De Fecha"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(93, 40)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(95, 22)
        Me.TxDeFecha.TabIndex = 100284
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(93, 9)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(63, 22)
        Me.TxSemana.TabIndex = 100310
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(12, 12)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100309
        Me.LbSemana.Text = "Semana"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbSubFamilias)
        Me.GroupBox1.Controls.Add(Me.rbFamilias)
        Me.GroupBox1.Location = New System.Drawing.Point(454, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 90)
        Me.GroupBox1.TabIndex = 100311
        Me.GroupBox1.TabStop = False
        '
        'rbSubFamilias
        '
        Me.rbSubFamilias.AutoSize = True
        Me.rbSubFamilias.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSubFamilias.ForeColor = System.Drawing.Color.Blue
        Me.rbSubFamilias.Location = New System.Drawing.Point(13, 54)
        Me.rbSubFamilias.Name = "rbSubFamilias"
        Me.rbSubFamilias.Size = New System.Drawing.Size(129, 18)
        Me.rbSubFamilias.TabIndex = 1
        Me.rbSubFamilias.Text = "Por Subfamilias"
        Me.rbSubFamilias.UseVisualStyleBackColor = True
        '
        'rbFamilias
        '
        Me.rbFamilias.AutoSize = True
        Me.rbFamilias.Checked = True
        Me.rbFamilias.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFamilias.ForeColor = System.Drawing.Color.Blue
        Me.rbFamilias.Location = New System.Drawing.Point(13, 20)
        Me.rbFamilias.Name = "rbFamilias"
        Me.rbFamilias.Size = New System.Drawing.Size(107, 18)
        Me.rbFamilias.TabIndex = 0
        Me.rbFamilias.TabStop = True
        Me.rbFamilias.Text = "Por Familias"
        Me.rbFamilias.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbNoComunitario)
        Me.GroupBox2.Controls.Add(Me.rbComunitario)
        Me.GroupBox2.Location = New System.Drawing.Point(627, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 90)
        Me.GroupBox2.TabIndex = 100312
        Me.GroupBox2.TabStop = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.ForeColor = System.Drawing.Color.Blue
        Me.rbTodos.Location = New System.Drawing.Point(13, 62)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(64, 18)
        Me.rbTodos.TabIndex = 2
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbNoComunitario
        '
        Me.rbNoComunitario.AutoSize = True
        Me.rbNoComunitario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoComunitario.ForeColor = System.Drawing.Color.Blue
        Me.rbNoComunitario.Location = New System.Drawing.Point(13, 38)
        Me.rbNoComunitario.Name = "rbNoComunitario"
        Me.rbNoComunitario.Size = New System.Drawing.Size(181, 18)
        Me.rbNoComunitario.TabIndex = 1
        Me.rbNoComunitario.Text = "Países No Comunitarios"
        Me.rbNoComunitario.UseVisualStyleBackColor = True
        '
        'rbComunitario
        '
        Me.rbComunitario.AutoSize = True
        Me.rbComunitario.Checked = True
        Me.rbComunitario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComunitario.ForeColor = System.Drawing.Color.Blue
        Me.rbComunitario.Location = New System.Drawing.Point(13, 14)
        Me.rbComunitario.Name = "rbComunitario"
        Me.rbComunitario.Size = New System.Drawing.Size(157, 18)
        Me.rbComunitario.TabIndex = 0
        Me.rbComunitario.TabStop = True
        Me.rbComunitario.Text = "Países comunitarios"
        Me.rbComunitario.UseVisualStyleBackColor = True
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.CL_ControlAsociado = Nothing
        Me.LbPuntoVenta.CL_ValorFijo = True
        Me.LbPuntoVenta.ClForm = Nothing
        Me.LbPuntoVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPuntoVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPuntoVenta.Location = New System.Drawing.Point(12, 70)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(65, 16)
        Me.LbPuntoVenta.TabIndex = 100314
        Me.LbPuntoVenta.Text = "P.Venta"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(93, 68)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(296, 20)
        Me.cbPuntoVenta.TabIndex = 100313
        '
        'FrmConsultaSOIVRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 561)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaSOIVRE"
        Me.Text = "Declaracion SOIVRE"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxAFecha As NetAgro.TxDato
    Friend WithEvents LbDeFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFamilias As System.Windows.Forms.RadioButton
    Friend WithEvents rbSubFamilias As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoComunitario As System.Windows.Forms.RadioButton
    Friend WithEvents rbComunitario As System.Windows.Forms.RadioButton
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
