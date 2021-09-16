<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrConsulta))
        Me.PanelAcciones = New System.Windows.Forms.Panel()
        Me.BtExportarExcel = New System.Windows.Forms.Button()
        Me.BtAux = New NetAgro.ClButton()
        Me.PlantillaConsulta1 = New NetAgro.PlantillaConsulta()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.BConsultar = New NetAgro.ClButton()
        Me.BImprimir = New NetAgro.ClButton()
        Me.BInforme = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.IconoError = New System.Windows.Forms.PictureBox()
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.PanelConsulta = New System.Windows.Forms.Panel()
        Me.PanelBotonesAmpliar = New System.Windows.Forms.Panel()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.ButtonEsconder = New System.Windows.Forms.Button()
        Me._BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelAcciones.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconoError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConsulta.SuspendLayout()
        Me.PanelBotonesAmpliar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAcciones
        '
        Me.PanelAcciones.Controls.Add(Me.BtExportarExcel)
        Me.PanelAcciones.Controls.Add(Me.BtAux)
        Me.PanelAcciones.Controls.Add(Me.PlantillaConsulta1)
        Me.PanelAcciones.Controls.Add(Me.BConsultar)
        Me.PanelAcciones.Controls.Add(Me.BImprimir)
        Me.PanelAcciones.Controls.Add(Me.BInforme)
        Me.PanelAcciones.Controls.Add(Me.Bsalir)
        Me.PanelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAcciones.Location = New System.Drawing.Point(0, 439)
        Me.PanelAcciones.Name = "PanelAcciones"
        Me.PanelAcciones.Size = New System.Drawing.Size(930, 34)
        Me.PanelAcciones.TabIndex = 3
        '
        'BtExportarExcel
        '
        Me.BtExportarExcel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtExportarExcel.Image = Global.NetAgro.My.Resources.Resources.Excel_15_16x16
        Me.BtExportarExcel.Location = New System.Drawing.Point(373, 0)
        Me.BtExportarExcel.Name = "BtExportarExcel"
        Me.BtExportarExcel.Size = New System.Drawing.Size(24, 34)
        Me.BtExportarExcel.TabIndex = 103
        Me.tt.SetToolTip(Me.BtExportarExcel, "Mostrar Filtros")
        Me.BtExportarExcel.UseVisualStyleBackColor = True
        '
        'BtAux
        '
        Me.BtAux.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux.Location = New System.Drawing.Point(555, 0)
        Me.BtAux.Name = "BtAux"
        Me.BtAux.Orden = 0
        Me.BtAux.PedirClave = True
        Me.BtAux.Size = New System.Drawing.Size(75, 34)
        Me.BtAux.TabIndex = 102
        Me.BtAux.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux.UseVisualStyleBackColor = True
        Me.BtAux.Visible = False
        '
        'PlantillaConsulta1
        '
        Me.PlantillaConsulta1.BackColor = System.Drawing.Color.Transparent
        Me.PlantillaConsulta1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PlantillaConsulta1.Grid = Me.GridView1
        Me.PlantillaConsulta1.GridControl = Me.Grid
        Me.PlantillaConsulta1.Location = New System.Drawing.Point(0, 0)
        Me.PlantillaConsulta1.Name = "PlantillaConsulta1"
        Me.PlantillaConsulta1.OpcionesPlantilla = Nothing
        Me.PlantillaConsulta1.PivotGrid = Nothing
        Me.PlantillaConsulta1.Size = New System.Drawing.Size(373, 34)
        Me.PlantillaConsulta1.TabIndex = 101
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 30)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(930, 307)
        Me.Grid.TabIndex = 12
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BConsultar
        '
        Me.BConsultar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsultar.Image = CType(resources.GetObject("BConsultar.Image"), System.Drawing.Image)
        Me.BConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsultar.Location = New System.Drawing.Point(630, 0)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Orden = 0
        Me.BConsultar.PedirClave = True
        Me.BConsultar.Size = New System.Drawing.Size(75, 34)
        Me.BConsultar.TabIndex = 97
        Me.BConsultar.Text = "Consultar"
        Me.BConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BConsultar.UseVisualStyleBackColor = True
        '
        'BImprimir
        '
        Me.BImprimir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BImprimir.Image = CType(resources.GetObject("BImprimir.Image"), System.Drawing.Image)
        Me.BImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BImprimir.Location = New System.Drawing.Point(705, 0)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Orden = 0
        Me.BImprimir.PedirClave = True
        Me.BImprimir.Size = New System.Drawing.Size(75, 34)
        Me.BImprimir.TabIndex = 98
        Me.BImprimir.Text = "Imprimir"
        Me.BImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BImprimir.UseVisualStyleBackColor = True
        '
        'BInforme
        '
        Me.BInforme.Dock = System.Windows.Forms.DockStyle.Right
        Me.BInforme.Image = CType(resources.GetObject("BInforme.Image"), System.Drawing.Image)
        Me.BInforme.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BInforme.Location = New System.Drawing.Point(780, 0)
        Me.BInforme.Name = "BInforme"
        Me.BInforme.Orden = 0
        Me.BInforme.PedirClave = True
        Me.BInforme.Size = New System.Drawing.Size(75, 34)
        Me.BInforme.TabIndex = 99
        Me.BInforme.Text = "Informe"
        Me.BInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BInforme.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(855, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(75, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'IconoError
        '
        Me.IconoError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IconoError.Enabled = False
        Me.IconoError.Image = CType(resources.GetObject("IconoError.Image"), System.Drawing.Image)
        Me.IconoError.Location = New System.Drawing.Point(305, 221)
        Me.IconoError.Name = "IconoError"
        Me.IconoError.Size = New System.Drawing.Size(17, 17)
        Me.IconoError.TabIndex = 7
        Me.IconoError.TabStop = False
        Me.IconoError.Visible = False
        '
        'prtSystem
        '
        Me.prtSystem.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.Grid
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "[Page # of Pages #]", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(930, 102)
        Me.PanelCabecera.TabIndex = 9
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Controls.Add(Me.Grid)
        Me.PanelConsulta.Controls.Add(Me.PanelBotonesAmpliar)
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 102)
        Me.PanelConsulta.Name = "PanelConsulta"
        Me.PanelConsulta.Size = New System.Drawing.Size(930, 337)
        Me.PanelConsulta.TabIndex = 10
        '
        'PanelBotonesAmpliar
        '
        Me.PanelBotonesAmpliar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelBotonesAmpliar.Controls.Add(Me.ButtonMostrar)
        Me.PanelBotonesAmpliar.Controls.Add(Me.ButtonEsconder)
        Me.PanelBotonesAmpliar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotonesAmpliar.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotonesAmpliar.Name = "PanelBotonesAmpliar"
        Me.PanelBotonesAmpliar.Size = New System.Drawing.Size(930, 30)
        Me.PanelBotonesAmpliar.TabIndex = 11
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_down_16x16_32
        Me.ButtonMostrar.Location = New System.Drawing.Point(831, 3)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(45, 23)
        Me.ButtonMostrar.TabIndex = 1
        Me.tt.SetToolTip(Me.ButtonMostrar, "Mostrar Filtros")
        Me.ButtonMostrar.UseVisualStyleBackColor = True
        '
        'ButtonEsconder
        '
        Me.ButtonEsconder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEsconder.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_up_16x16_32
        Me.ButtonEsconder.Location = New System.Drawing.Point(882, 3)
        Me.ButtonEsconder.Name = "ButtonEsconder"
        Me.ButtonEsconder.Size = New System.Drawing.Size(45, 23)
        Me.ButtonEsconder.TabIndex = 0
        Me.tt.SetToolTip(Me.ButtonEsconder, "Ocultar Filtros")
        Me.ButtonEsconder.UseVisualStyleBackColor = True
        '
        '_BackgroundWorker
        '
        '
        'FrConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 473)
        Me.Controls.Add(Me.PanelConsulta)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.IconoError)
        Me.Controls.Add(Me.PanelAcciones)
        Me.Name = "FrConsulta"
        Me.Text = "Formulario de Consulta"
        Me.PanelAcciones.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconoError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConsulta.ResumeLayout(False)
        Me.PanelBotonesAmpliar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelAcciones As System.Windows.Forms.Panel
    Friend WithEvents IconoError As System.Windows.Forms.PictureBox
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Protected WithEvents PanelCabecera As System.Windows.Forms.Panel
    Protected WithEvents PanelConsulta As System.Windows.Forms.Panel
    Protected WithEvents BConsultar As NetAgro.ClButton
    Protected WithEvents BImprimir As NetAgro.ClButton
    Protected WithEvents BInforme As NetAgro.ClButton
    Protected WithEvents Bsalir As NetAgro.ClButton
    Protected WithEvents PlantillaConsulta1 As NetAgro.PlantillaConsulta
    Protected WithEvents BtAux As NetAgro.ClButton
    Friend WithEvents _BackgroundWorker As System.ComponentModel.BackgroundWorker
    Public WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents PanelBotonesAmpliar As System.Windows.Forms.Panel
    Friend WithEvents ButtonMostrar As System.Windows.Forms.Button
    Friend WithEvents ButtonEsconder As System.Windows.Forms.Button
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents BtExportarExcel As System.Windows.Forms.Button
End Class
