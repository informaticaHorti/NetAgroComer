<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioMateriales_OLD
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
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.chkMarcas = New NetAgro.Chk(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbAlmacenes = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.CbMarcas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbMarcas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbMarcas)
        Me.PanelCabecera.Controls.Add(Me.ClButton1)
        Me.PanelCabecera.Controls.Add(Me.cbAlmacenes)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.chkMarcas)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 74)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 80)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 455)
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
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 14)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 148
        Me.Lb1.Text = "Desde fecha"
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
        Me.Lb2.Location = New System.Drawing.Point(21, 42)
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
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(124, 11)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(116, 23)
        Me.TxDato1.TabIndex = 152
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxDato2.Location = New System.Drawing.Point(124, 39)
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
        'chkMarcas
        '
        Me.chkMarcas.AutoSize = True
        Me.chkMarcas.Campobd = Nothing
        Me.chkMarcas.ClForm = Nothing
        Me.chkMarcas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarcas.ForeColor = System.Drawing.Color.Teal
        Me.chkMarcas.GridLin = Nothing
        Me.chkMarcas.HaCambiado = False
        Me.chkMarcas.Location = New System.Drawing.Point(309, 12)
        Me.chkMarcas.MiEntidad = Nothing
        Me.chkMarcas.MiError = False
        Me.chkMarcas.Name = "chkMarcas"
        Me.chkMarcas.Orden = 0
        Me.chkMarcas.SaltoAlfinal = False
        Me.chkMarcas.Size = New System.Drawing.Size(141, 20)
        Me.chkMarcas.TabIndex = 100273
        Me.chkMarcas.Text = "Mostrar marcas"
        Me.chkMarcas.UseVisualStyleBackColor = True
        Me.chkMarcas.ValorCampoFalse = Nothing
        Me.chkMarcas.ValorCampoTrue = Nothing
        Me.chkMarcas.ValorDefecto = False
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(306, 42)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(151, 16)
        Me.Lb6.TabIndex = 100277
        Me.Lb6.Text = "Familias materiales"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(463, 40)
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
        'ClButton1
        '
        Me.ClButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Action_button_info_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClButton1.Location = New System.Drawing.Point(940, 39)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(217, 25)
        Me.ClButton1.TabIndex = 100279
        Me.ClButton1.Text = "Comprobar precios de compra"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'CbMarcas
        '
        Me.CbMarcas.EditValue = ""
        Me.CbMarcas.Location = New System.Drawing.Point(463, 13)
        Me.CbMarcas.Name = "CbMarcas"
        Me.CbMarcas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbMarcas.Size = New System.Drawing.Size(270, 20)
        Me.CbMarcas.TabIndex = 100280
        '
        'FrmInventarioMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmInventarioMateriales"
        Me.Text = "Inventario de materiales por fecha"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbMarcas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents chkMarcas As NetAgro.Chk
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbAlmacenes As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Friend WithEvents CbMarcas As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
