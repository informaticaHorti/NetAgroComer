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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlantillaConsulta))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.popControl = New DevExpress.XtraEditors.PopupContainerControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombreCampo = New System.Windows.Forms.TextBox()
        Me.pop = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.btCampoCalculado = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPlantilla = New DevExpress.XtraEditors.TextEdit()
        Me.cbPlantilla = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbPlantilla = New DevExpress.XtraEditors.LabelControl()
        Me.btIrAPivot = New DevExpress.XtraEditors.SimpleButton()
        Me.btGuardarPlantilla = New DevExpress.XtraEditors.SimpleButton()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popControl.SuspendLayout()
        CType(Me.pop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlantilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPlantilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl1.Controls.Add(Me.popControl)
        Me.PanelControl1.Controls.Add(Me.pop)
        Me.PanelControl1.Controls.Add(Me.txtPlantilla)
        Me.PanelControl1.Controls.Add(Me.cbPlantilla)
        Me.PanelControl1.Controls.Add(Me.lbPlantilla)
        Me.PanelControl1.Controls.Add(Me.btIrAPivot)
        Me.PanelControl1.Controls.Add(Me.btGuardarPlantilla)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(324, 32)
        Me.PanelControl1.TabIndex = 0
        '
        'popControl
        '
        Me.popControl.Controls.Add(Me.Lb1)
        Me.popControl.Controls.Add(Me.btnCancelar)
        Me.popControl.Controls.Add(Me.btCampoCalculado)
        Me.popControl.Controls.Add(Me.btnOk)
        Me.popControl.Controls.Add(Me.txtNombreCampo)
        Me.popControl.Location = New System.Drawing.Point(65, 3)
        Me.popControl.MinimumSize = New System.Drawing.Size(202, 56)
        Me.popControl.Name = "popControl"
        Me.popControl.Size = New System.Drawing.Size(202, 56)
        Me.popControl.TabIndex = 15
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(137, 32)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(54, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(92, 32)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(39, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        '
        'txtNombreCampo
        '
        Me.txtNombreCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCampo.Location = New System.Drawing.Point(57, 4)
        Me.txtNombreCampo.Name = "txtNombreCampo"
        Me.txtNombreCampo.Size = New System.Drawing.Size(140, 20)
        Me.txtNombreCampo.TabIndex = 0
        '
        'pop
        '
        Me.pop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pop.Location = New System.Drawing.Point(294, 6)
        Me.pop.Name = "pop"
        Me.pop.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pop.Properties.Appearance.Options.UseBackColor = True
        Me.pop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("pop.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.pop.Properties.PopupControl = Me.popControl
        Me.pop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.pop.Size = New System.Drawing.Size(20, 20)
        Me.pop.TabIndex = 6
        '
        'btCampoCalculado
        '
        Me.btCampoCalculado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCampoCalculado.Image = Global.NetAgro.My.Resources.Resources.add
        Me.btCampoCalculado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btCampoCalculado.Location = New System.Drawing.Point(0, 3)
        Me.btCampoCalculado.Name = "btCampoCalculado"
        Me.btCampoCalculado.Size = New System.Drawing.Size(20, 20)
        Me.btCampoCalculado.TabIndex = 5
        Me.btCampoCalculado.ToolTip = "Añadir campo calculado"
        Me.btCampoCalculado.Visible = False
        '
        'txtPlantilla
        '
        Me.txtPlantilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlantilla.Location = New System.Drawing.Point(65, 6)
        Me.txtPlantilla.Name = "txtPlantilla"
        Me.txtPlantilla.Size = New System.Drawing.Size(186, 20)
        Me.txtPlantilla.TabIndex = 3
        Me.txtPlantilla.Visible = False
        '
        'cbPlantilla
        '
        Me.cbPlantilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPlantilla.Location = New System.Drawing.Point(65, 6)
        Me.cbPlantilla.Name = "cbPlantilla"
        Me.cbPlantilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPlantilla.Size = New System.Drawing.Size(186, 20)
        Me.cbPlantilla.TabIndex = 0
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
        'btIrAPivot
        '
        Me.btIrAPivot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btIrAPivot.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcalendar_16x16_32
        Me.btIrAPivot.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btIrAPivot.Location = New System.Drawing.Point(273, 6)
        Me.btIrAPivot.Name = "btIrAPivot"
        Me.btIrAPivot.Size = New System.Drawing.Size(20, 20)
        Me.btIrAPivot.TabIndex = 2
        Me.btIrAPivot.ToolTip = "Ver en tabla dinámica"
        '
        'btGuardarPlantilla
        '
        Me.btGuardarPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btGuardarPlantilla.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btGuardarPlantilla.Appearance.Options.UseForeColor = True
        Me.btGuardarPlantilla.Image = Global.NetAgro.My.Resources.Resources.RibbonPrintPreview_Customize
        Me.btGuardarPlantilla.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btGuardarPlantilla.Location = New System.Drawing.Point(252, 6)
        Me.btGuardarPlantilla.Name = "btGuardarPlantilla"
        Me.btGuardarPlantilla.Size = New System.Drawing.Size(20, 20)
        Me.btGuardarPlantilla.TabIndex = 1
        Me.btGuardarPlantilla.ToolTip = "Guardar plantilla"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.Location = New System.Drawing.Point(4, 8)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(44, 13)
        Me.Lb1.TabIndex = 3
        Me.Lb1.Text = "Nombre"
        '
        'PlantillaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "PlantillaConsulta"
        Me.Size = New System.Drawing.Size(324, 32)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.popControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popControl.ResumeLayout(False)
        Me.popControl.PerformLayout()
        CType(Me.pop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlantilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPlantilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbPlantilla As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btGuardarPlantilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btIrAPivot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPlantilla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbPlantilla As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btCampoCalculado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pop As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents popControl As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCampo As System.Windows.Forms.TextBox
    Friend WithEvents Lb1 As NetAgro.Lb

End Class
