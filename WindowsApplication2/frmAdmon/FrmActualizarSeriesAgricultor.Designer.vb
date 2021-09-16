<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarSeriesAgricultor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarSeriesAgricultor))
        Me.PanelAcciones = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.TxCadenaConexion = New System.Windows.Forms.TextBox()
        Me.LbCadenaConexion = New NetAgro.Lb(Me.components)
        Me.BConsulta = New NetAgro.ClButton()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.BtAux = New NetAgro.ClButton()
        Me.PanelAcciones.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAcciones
        '
        Me.PanelAcciones.Controls.Add(Me.BtAux)
        Me.PanelAcciones.Controls.Add(Me.ClButton1)
        Me.PanelAcciones.Controls.Add(Me.BConsulta)
        Me.PanelAcciones.Controls.Add(Me.ProgressBar1)
        Me.PanelAcciones.Controls.Add(Me.Bsalir)
        Me.PanelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAcciones.Location = New System.Drawing.Point(0, 432)
        Me.PanelAcciones.Name = "PanelAcciones"
        Me.PanelAcciones.Size = New System.Drawing.Size(1030, 34)
        Me.PanelAcciones.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(319, 23)
        Me.ProgressBar1.TabIndex = 104
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(955, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(75, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 57)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1030, 375)
        Me.Grid.TabIndex = 13
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'TxCadenaConexion
        '
        Me.TxCadenaConexion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxCadenaConexion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxCadenaConexion.Location = New System.Drawing.Point(151, 15)
        Me.TxCadenaConexion.Name = "TxCadenaConexion"
        Me.TxCadenaConexion.Size = New System.Drawing.Size(867, 22)
        Me.TxCadenaConexion.TabIndex = 14
        Me.TxCadenaConexion.Text = "Driver={SQL Server Native Client 11.0};Server=SAT2015;Database=Hortichuelas;Uid=s" & _
    "a;Persist Security Info=true;"
        '
        'LbCadenaConexion
        '
        Me.LbCadenaConexion.AutoSize = True
        Me.LbCadenaConexion.CL_ControlAsociado = Nothing
        Me.LbCadenaConexion.CL_ValorFijo = True
        Me.LbCadenaConexion.ClForm = Nothing
        Me.LbCadenaConexion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCadenaConexion.ForeColor = System.Drawing.Color.Teal
        Me.LbCadenaConexion.Location = New System.Drawing.Point(12, 18)
        Me.LbCadenaConexion.Name = "LbCadenaConexion"
        Me.LbCadenaConexion.Size = New System.Drawing.Size(133, 16)
        Me.LbCadenaConexion.TabIndex = 100276
        Me.LbCadenaConexion.Text = "Cadena conexión"
        '
        'BConsulta
        '
        Me.BConsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BConsulta.Location = New System.Drawing.Point(880, 0)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Orden = 0
        Me.BConsulta.PedirClave = True
        Me.BConsulta.Size = New System.Drawing.Size(75, 34)
        Me.BConsulta.TabIndex = 112
        Me.BConsulta.Text = "Consultar"
        Me.BConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'ClButton1
        '
        Me.ClButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClButton1.Location = New System.Drawing.Point(805, 0)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(75, 34)
        Me.ClButton1.TabIndex = 113
        Me.ClButton1.Text = "Imprimir"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'BtAux
        '
        Me.BtAux.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtAux.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.BtAux.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtAux.Location = New System.Drawing.Point(730, 0)
        Me.BtAux.Name = "BtAux"
        Me.BtAux.Orden = 0
        Me.BtAux.PedirClave = True
        Me.BtAux.Size = New System.Drawing.Size(75, 34)
        Me.BtAux.TabIndex = 114
        Me.BtAux.Text = "Actualizar"
        Me.BtAux.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAux.UseVisualStyleBackColor = True
        '
        'FrmActualizarSeriesAgricultor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 466)
        Me.Controls.Add(Me.LbCadenaConexion)
        Me.Controls.Add(Me.TxCadenaConexion)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PanelAcciones)
        Me.Name = "FrmActualizarSeriesAgricultor"
        Me.Text = "Actualizar Series Agricultor"
        Me.PanelAcciones.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelAcciones As System.Windows.Forms.Panel
    Protected WithEvents Bsalir As NetAgro.ClButton
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TxCadenaConexion As System.Windows.Forms.TextBox
    Friend WithEvents LbCadenaConexion As NetAgro.Lb
    Protected WithEvents BtAux As NetAgro.ClButton
    Protected WithEvents ClButton1 As NetAgro.ClButton
    Protected WithEvents BConsulta As NetAgro.ClButton
End Class
