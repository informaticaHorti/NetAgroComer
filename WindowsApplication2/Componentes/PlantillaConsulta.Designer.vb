<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlantillaConsulta
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lbPlantilla = New DevExpress.XtraEditors.LabelControl()
        Me.txtTexto = New DevExpress.XtraEditors.TextEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.barra = New System.Windows.Forms.ToolStrip()
        Me.pnl = New DevExpress.XtraEditors.PanelControl()
        Me.cbPlantilla = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuGuardarPlantilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrarPlantilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerEnTablaDinamica = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAñadirCampoCalculado = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscribaElNombreDebajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNombreCampo = New System.Windows.Forms.ToolStripTextBox()
        Me.mnuScrollHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectorColumnas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMostrarTodosCampos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAjustePerfecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorFiltros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPanelBusqueda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilaFiltrado = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.txtTexto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.barra.SuspendLayout()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.cbPlantilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPlantilla
        '
        Me.lbPlantilla.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlantilla.Location = New System.Drawing.Point(10, 9)
        Me.lbPlantilla.Name = "lbPlantilla"
        Me.lbPlantilla.Size = New System.Drawing.Size(39, 14)
        Me.lbPlantilla.TabIndex = 4
        Me.lbPlantilla.Text = "Plantilla"
        '
        'txtTexto
        '
        Me.txtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTexto.Location = New System.Drawing.Point(65, 6)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(197, 20)
        Me.txtTexto.TabIndex = 3
        Me.txtTexto.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.barra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(268, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(64, 26)
        Me.Panel1.TabIndex = 6
        '
        'barra
        '
        Me.barra.CanOverflow = False
        Me.barra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btMenu})
        Me.barra.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(64, 26)
        Me.barra.TabIndex = 0
        Me.barra.Text = "ToolStrip1"
        '
        'pnl
        '
        Me.pnl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.pnl.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.pnl.Appearance.Options.UseBackColor = True
        Me.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.txtTexto)
        Me.pnl.Controls.Add(Me.lbPlantilla)
        Me.pnl.Controls.Add(Me.cbPlantilla)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(335, 32)
        Me.pnl.TabIndex = 0
        '
        'cbPlantilla
        '
        Me.cbPlantilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPlantilla.Location = New System.Drawing.Point(65, 6)
        Me.cbPlantilla.Name = "cbPlantilla"
        Me.cbPlantilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPlantilla.Size = New System.Drawing.Size(197, 20)
        Me.cbPlantilla.TabIndex = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'btMenu
        '
        Me.btMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGuardarPlantilla, Me.mnuBorrarPlantilla, Me.mnuVerEnTablaDinamica, Me.mnuAñadirCampoCalculado, Me.mnuScrollHorizontal, Me.ToolStripSeparator1, Me.mnuSelectorColumnas, Me.mnuMostrarTodosCampos, Me.mnuAjustePerfecto, Me.mnuEditorFiltros, Me.mnuPanelBusqueda, Me.mnuFilaFiltrado})
        Me.btMenu.Image = Global.NetAgro.My.Resources.Resources.favorites
        Me.btMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(29, 23)
        Me.btMenu.Text = "ToolStripDropDownButton1"
        '
        'mnuGuardarPlantilla
        '
        Me.mnuGuardarPlantilla.Image = Global.NetAgro.My.Resources.Resources.RibbonPrintPreview_ExportFile
        Me.mnuGuardarPlantilla.Name = "mnuGuardarPlantilla"
        Me.mnuGuardarPlantilla.Size = New System.Drawing.Size(229, 22)
        Me.mnuGuardarPlantilla.Text = "Guardar plantilla como..."
        '
        'mnuBorrarPlantilla
        '
        Me.mnuBorrarPlantilla.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.mnuBorrarPlantilla.Name = "mnuBorrarPlantilla"
        Me.mnuBorrarPlantilla.Size = New System.Drawing.Size(229, 22)
        Me.mnuBorrarPlantilla.Text = "Borrar plantilla actual"
        '
        'mnuVerEnTablaDinamica
        '
        Me.mnuVerEnTablaDinamica.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcalendar_16x16_32
        Me.mnuVerEnTablaDinamica.Name = "mnuVerEnTablaDinamica"
        Me.mnuVerEnTablaDinamica.Size = New System.Drawing.Size(229, 22)
        Me.mnuVerEnTablaDinamica.Text = "Ver en tabla dinámica"
        '
        'mnuAñadirCampoCalculado
        '
        Me.mnuAñadirCampoCalculado.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EscribaElNombreDebajoToolStripMenuItem, Me.txtNombreCampo})
        Me.mnuAñadirCampoCalculado.Name = "mnuAñadirCampoCalculado"
        Me.mnuAñadirCampoCalculado.Size = New System.Drawing.Size(229, 22)
        Me.mnuAñadirCampoCalculado.Text = "Añadir campo calculado"
        '
        'EscribaElNombreDebajoToolStripMenuItem
        '
        Me.EscribaElNombreDebajoToolStripMenuItem.Name = "EscribaElNombreDebajoToolStripMenuItem"
        Me.EscribaElNombreDebajoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EscribaElNombreDebajoToolStripMenuItem.Text = "Escriba el nombre debajo"
        '
        'txtNombreCampo
        '
        Me.txtNombreCampo.BackColor = System.Drawing.Color.Yellow
        Me.txtNombreCampo.Name = "txtNombreCampo"
        Me.txtNombreCampo.Size = New System.Drawing.Size(150, 21)
        '
        'mnuScrollHorizontal
        '
        Me.mnuScrollHorizontal.Image = Global.NetAgro.My.Resources.Resources.Resize_Horizontal_16
        Me.mnuScrollHorizontal.Name = "mnuScrollHorizontal"
        Me.mnuScrollHorizontal.Size = New System.Drawing.Size(229, 22)
        Me.mnuScrollHorizontal.Text = "Mostrar/Ocultar barra horizontal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'mnuSelectorColumnas
        '
        Me.mnuSelectorColumnas.Name = "mnuSelectorColumnas"
        Me.mnuSelectorColumnas.Size = New System.Drawing.Size(229, 22)
        Me.mnuSelectorColumnas.Text = "Mostrar selector de columnas"
        '
        'mnuMostrarTodosCampos
        '
        Me.mnuMostrarTodosCampos.Name = "mnuMostrarTodosCampos"
        Me.mnuMostrarTodosCampos.Size = New System.Drawing.Size(229, 22)
        Me.mnuMostrarTodosCampos.Text = "Incluir todas las columnas"
        '
        'mnuAjustePerfecto
        '
        Me.mnuAjustePerfecto.Name = "mnuAjustePerfecto"
        Me.mnuAjustePerfecto.Size = New System.Drawing.Size(229, 22)
        Me.mnuAjustePerfecto.Text = "Ajuste perfecto de columnas"
        '
        'mnuEditorFiltros
        '
        Me.mnuEditorFiltros.Name = "mnuEditorFiltros"
        Me.mnuEditorFiltros.Size = New System.Drawing.Size(229, 22)
        Me.mnuEditorFiltros.Text = "Mostrar editor de filtros"
        '
        'mnuPanelBusqueda
        '
        Me.mnuPanelBusqueda.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.mnuPanelBusqueda.Name = "mnuPanelBusqueda"
        Me.mnuPanelBusqueda.Size = New System.Drawing.Size(229, 22)
        Me.mnuPanelBusqueda.Text = "Mostrar panel de búsqueda"
        '
        'mnuFilaFiltrado
        '
        Me.mnuFilaFiltrado.Name = "mnuFilaFiltrado"
        Me.mnuFilaFiltrado.Size = New System.Drawing.Size(229, 22)
        Me.mnuFilaFiltrado.Text = "Mostrar/Ocultar fila de filtrado"
        '
        'PlantillaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnl)
        Me.Name = "PlantillaConsulta"
        Me.Size = New System.Drawing.Size(335, 32)
        CType(Me.txtTexto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.barra.ResumeLayout(False)
        Me.barra.PerformLayout()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.cbPlantilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbPlantilla As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTexto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barra As System.Windows.Forms.ToolStrip
    Friend WithEvents btMenu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuGuardarPlantilla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrarPlantilla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerEnTablaDinamica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAñadirCampoCalculado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectorColumnas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAjustePerfecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditorFiltros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPanelBusqueda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilaFiltrado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtNombreCampo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EscribaElNombreDebajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbPlantilla As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents mnuMostrarTodosCampos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScrollHorizontal As System.Windows.Forms.ToolStripMenuItem

End Class
