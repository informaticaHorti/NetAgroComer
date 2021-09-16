<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioMateriales))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbAlmacenes = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbAlmacenes)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 100)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 100)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 441)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(884, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(959, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1034, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1109, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(809, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(21, 15)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 172
        Me.Lb2.Text = "Hasta fecha"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(785, 15)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(71, 16)
        Me.Lb4.TabIndex = 175
        Me.Lb4.Text = "Almacén"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(124, 12)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(116, 23)
        Me.TxDato2.TabIndex = 176
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(306, 14)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(151, 16)
        Me.Lb6.TabIndex = 100277
        Me.Lb6.Text = "Familias materiales"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(463, 12)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(270, 20)
        Me.CbFamilias.TabIndex = 100276
        '
        'cbAlmacenes
        '
        Me.cbAlmacenes.EditValue = ""
        Me.cbAlmacenes.Location = New System.Drawing.Point(862, 13)
        Me.cbAlmacenes.Name = "cbAlmacenes"
        Me.cbAlmacenes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlmacenes.Size = New System.Drawing.Size(295, 20)
        Me.cbAlmacenes.TabIndex = 100278
        '
        'FrmInventarioMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"),System.Collections.Generic.List(Of Object))
        Me.Name = "FrmInventarioMateriales"
        Me.Text = "Inventario de materiales por fecha"
        Me.PanelCabecera.ResumeLayout(false)
        Me.PanelCabecera.PerformLayout
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CbFamilias.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbAlmacenes.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbAlmacenes As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
