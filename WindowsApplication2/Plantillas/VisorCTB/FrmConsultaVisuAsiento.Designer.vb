<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaVisuAsiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaVisuAsiento))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btImpresionDirecta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblDescuadre = New NetAgro.Lb(Me.components)
        Me.LbltotalHaber = New NetAgro.Lb(Me.components)
        Me.Lbltotaldebe = New NetAgro.Lb(Me.components)
        Me.LblNumasientos = New NetAgro.Lb(Me.components)
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.LbAsiento = New NetAgro.Lb(Me.components)
        Me.LbEjercicioCentro = New NetAgro.Lb(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(3, 42)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1008, 287)
        Me.Grid.TabIndex = 122
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.FixedLine.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.Appearance.Row.Options.UseForeColor = True
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsPrint.PrintFooter = False
        Me.GridView.OptionsPrint.PrintGroupFooter = False
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btImprimir)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btImpresionDirecta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 42)
        Me.Panel1.TabIndex = 126
        '
        'btImprimir
        '
        Me.btImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImprimir.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.btImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btImprimir.Location = New System.Drawing.Point(852, 3)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 36)
        Me.btImprimir.TabIndex = 128
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.NetAgro.My.Resources.Resources.Salir16
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(933, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btImpresionDirecta
        '
        Me.btImpresionDirecta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImpresionDirecta.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.btImpresionDirecta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btImpresionDirecta.Location = New System.Drawing.Point(771, 3)
        Me.btImpresionDirecta.Name = "btImpresionDirecta"
        Me.btImpresionDirecta.Size = New System.Drawing.Size(75, 36)
        Me.btImpresionDirecta.TabIndex = 126
        Me.btImpresionDirecta.Text = "Imp.Directa"
        Me.btImpresionDirecta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImpresionDirecta.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblDescuadre)
        Me.Panel2.Controls.Add(Me.LbltotalHaber)
        Me.Panel2.Controls.Add(Me.Lbltotaldebe)
        Me.Panel2.Controls.Add(Me.LblNumasientos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1011, 32)
        Me.Panel2.TabIndex = 127
        '
        'LblDescuadre
        '
        Me.LblDescuadre.AutoSize = True
        Me.LblDescuadre.CL_ControlAsociado = Nothing
        Me.LblDescuadre.CL_ValorFijo = False
        Me.LblDescuadre.ClForm = Nothing
        Me.LblDescuadre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescuadre.ForeColor = System.Drawing.Color.Red
        Me.LblDescuadre.Location = New System.Drawing.Point(558, 8)
        Me.LblDescuadre.Name = "LblDescuadre"
        Me.LblDescuadre.Size = New System.Drawing.Size(0, 16)
        Me.LblDescuadre.TabIndex = 3
        '
        'LbltotalHaber
        '
        Me.LbltotalHaber.AutoSize = True
        Me.LbltotalHaber.CL_ControlAsociado = Nothing
        Me.LbltotalHaber.CL_ValorFijo = False
        Me.LbltotalHaber.ClForm = Nothing
        Me.LbltotalHaber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltotalHaber.ForeColor = System.Drawing.Color.Red
        Me.LbltotalHaber.Location = New System.Drawing.Point(361, 8)
        Me.LbltotalHaber.Name = "LbltotalHaber"
        Me.LbltotalHaber.Size = New System.Drawing.Size(0, 16)
        Me.LbltotalHaber.TabIndex = 2
        '
        'Lbltotaldebe
        '
        Me.Lbltotaldebe.AutoSize = True
        Me.Lbltotaldebe.CL_ControlAsociado = Nothing
        Me.Lbltotaldebe.CL_ValorFijo = False
        Me.Lbltotaldebe.ClForm = Nothing
        Me.Lbltotaldebe.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotaldebe.ForeColor = System.Drawing.Color.Red
        Me.Lbltotaldebe.Location = New System.Drawing.Point(160, 8)
        Me.Lbltotaldebe.Name = "Lbltotaldebe"
        Me.Lbltotaldebe.Size = New System.Drawing.Size(0, 16)
        Me.Lbltotaldebe.TabIndex = 1
        '
        'LblNumasientos
        '
        Me.LblNumasientos.AutoSize = True
        Me.LblNumasientos.CL_ControlAsociado = Nothing
        Me.LblNumasientos.CL_ValorFijo = False
        Me.LblNumasientos.ClForm = Nothing
        Me.LblNumasientos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumasientos.ForeColor = System.Drawing.Color.Red
        Me.LblNumasientos.Location = New System.Drawing.Point(12, 8)
        Me.LblNumasientos.Name = "LblNumasientos"
        Me.LblNumasientos.Size = New System.Drawing.Size(0, 16)
        Me.LblNumasientos.TabIndex = 0
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
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "[Page # of Pages #]", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'LbAsiento
        '
        Me.LbAsiento.AutoSize = True
        Me.LbAsiento.CL_ControlAsociado = Nothing
        Me.LbAsiento.CL_ValorFijo = False
        Me.LbAsiento.ClForm = Nothing
        Me.LbAsiento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsiento.ForeColor = System.Drawing.Color.Teal
        Me.LbAsiento.Location = New System.Drawing.Point(12, 11)
        Me.LbAsiento.Name = "LbAsiento"
        Me.LbAsiento.Size = New System.Drawing.Size(63, 16)
        Me.LbAsiento.TabIndex = 128
        Me.LbAsiento.Text = "Asiento"
        '
        'LbEjercicioCentro
        '
        Me.LbEjercicioCentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbEjercicioCentro.CL_ControlAsociado = Nothing
        Me.LbEjercicioCentro.CL_ValorFijo = False
        Me.LbEjercicioCentro.ClForm = Nothing
        Me.LbEjercicioCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicioCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicioCentro.Location = New System.Drawing.Point(707, 11)
        Me.LbEjercicioCentro.Name = "LbEjercicioCentro"
        Me.LbEjercicioCentro.Size = New System.Drawing.Size(292, 16)
        Me.LbEjercicioCentro.TabIndex = 129
        Me.LbEjercicioCentro.Text = "Ejercicio: Centro:"
        Me.LbEjercicioCentro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmConsultaVisuAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 414)
        Me.Controls.Add(Me.LbEjercicioCentro)
        Me.Controls.Add(Me.LbAsiento)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmConsultaVisuAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de asientos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btImpresionDirecta As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblDescuadre As NetAgro.Lb
    Friend WithEvents LbltotalHaber As NetAgro.Lb
    Friend WithEvents Lbltotaldebe As NetAgro.Lb
    Friend WithEvents LblNumasientos As NetAgro.Lb
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents LbAsiento As NetAgro.Lb
    Friend WithEvents LbEjercicioCentro As NetAgro.Lb
End Class
