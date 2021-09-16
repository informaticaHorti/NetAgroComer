<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBandView
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
        Me.GridBalanceMasas = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBalanceMasas = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.bandEntradas = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasControladoNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasNoControladoNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotalBruto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntradasTotalDestrio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandEntadasTotalNeto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidas = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasNoControlado = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bandSalidasTotal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.GridBalanceMasas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBalanceMasas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridBalanceMasas
        '
        Me.GridBalanceMasas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridBalanceMasas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBalanceMasas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBalanceMasas.Location = New System.Drawing.Point(0, 0)
        Me.GridBalanceMasas.LookAndFeel.SkinName = "Black"
        Me.GridBalanceMasas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridBalanceMasas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridBalanceMasas.MainView = Me.GridViewBalanceMasas
        Me.GridBalanceMasas.Name = "GridBalanceMasas"
        Me.GridBalanceMasas.Size = New System.Drawing.Size(1184, 484)
        Me.GridBalanceMasas.TabIndex = 13
        Me.GridBalanceMasas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBalanceMasas})
        '
        'GridViewBalanceMasas
        '
        Me.GridViewBalanceMasas.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewBalanceMasas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewBalanceMasas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridViewBalanceMasas.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewBalanceMasas.Appearance.Row.Options.UseFont = True
        Me.GridViewBalanceMasas.Appearance.Row.Options.UseForeColor = True
        Me.GridViewBalanceMasas.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradas, Me.bandSalidas})
        Me.GridViewBalanceMasas.GridControl = Me.GridBalanceMasas
        Me.GridViewBalanceMasas.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBalanceMasas.Name = "GridViewBalanceMasas"
        Me.GridViewBalanceMasas.OptionsBehavior.Editable = False
        Me.GridViewBalanceMasas.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewBalanceMasas.OptionsView.ColumnAutoWidth = True
        '
        'bandEntradas
        '
        Me.bandEntradas.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bandEntradas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradas.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradas.AppearanceHeader.Options.UseFont = True
        Me.bandEntradas.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradas.Caption = "ENTRADAS"
        Me.bandEntradas.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasControlado, Me.bandEntradasNoControlado, Me.bandEntradasTotal})
        Me.bandEntradas.Name = "bandEntradas"
        Me.bandEntradas.Width = 630
        '
        'bandEntradasControlado
        '
        Me.bandEntradasControlado.AppearanceHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.bandEntradasControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasControlado.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControlado.Caption = "CONTROLADO"
        Me.bandEntradasControlado.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasControladoBruto, Me.bandEntradasControladoDestrio, Me.bandEntradasControladoNeto})
        Me.bandEntradasControlado.Name = "bandEntradasControlado"
        Me.bandEntradasControlado.Width = 210
        '
        'bandEntradasControladoBruto
        '
        Me.bandEntradasControladoBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoBruto.Caption = "Bruto"
        Me.bandEntradasControladoBruto.Name = "bandEntradasControladoBruto"
        '
        'bandEntradasControladoDestrio
        '
        Me.bandEntradasControladoDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoDestrio.Caption = "Destrio"
        Me.bandEntradasControladoDestrio.Name = "bandEntradasControladoDestrio"
        '
        'bandEntradasControladoNeto
        '
        Me.bandEntradasControladoNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasControladoNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasControladoNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasControladoNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasControladoNeto.Caption = "Neto"
        Me.bandEntradasControladoNeto.Name = "bandEntradasControladoNeto"
        '
        'bandEntradasNoControlado
        '
        Me.bandEntradasNoControlado.AppearanceHeader.BackColor = System.Drawing.Color.LightSalmon
        Me.bandEntradasNoControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControlado.Caption = "NO CONTROLADO"
        Me.bandEntradasNoControlado.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasNoControladoBruto, Me.bandEntradasNoControladoDestrio, Me.bandEntradasNoControladoNeto})
        Me.bandEntradasNoControlado.Name = "bandEntradasNoControlado"
        Me.bandEntradasNoControlado.Width = 210
        '
        'bandEntradasNoControladoBruto
        '
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoBruto.Caption = "Bruto"
        Me.bandEntradasNoControladoBruto.Name = "bandEntradasNoControladoBruto"
        '
        'bandEntradasNoControladoDestrio
        '
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoDestrio.Caption = "Destrio"
        Me.bandEntradasNoControladoDestrio.Name = "bandEntradasNoControladoDestrio"
        '
        'bandEntradasNoControladoNeto
        '
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasNoControladoNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasNoControladoNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasNoControladoNeto.Caption = "Neto"
        Me.bandEntradasNoControladoNeto.Name = "bandEntradasNoControladoNeto"
        '
        'bandEntradasTotal
        '
        Me.bandEntradasTotal.AppearanceHeader.BackColor = System.Drawing.Color.Moccasin
        Me.bandEntradasTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotal.AppearanceHeader.Options.UseBackColor = True
        Me.bandEntradasTotal.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotal.Caption = "TOTAL"
        Me.bandEntradasTotal.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandEntradasTotalBruto, Me.bandEntradasTotalDestrio, Me.bandEntadasTotalNeto})
        Me.bandEntradasTotal.Name = "bandEntradasTotal"
        Me.bandEntradasTotal.Width = 210
        '
        'bandEntradasTotalBruto
        '
        Me.bandEntradasTotalBruto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotalBruto.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotalBruto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotalBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotalBruto.Caption = "Bruto"
        Me.bandEntradasTotalBruto.Name = "bandEntradasTotalBruto"
        '
        'bandEntradasTotalDestrio
        '
        Me.bandEntradasTotalDestrio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntradasTotalDestrio.AppearanceHeader.Options.UseFont = True
        Me.bandEntradasTotalDestrio.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntradasTotalDestrio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntradasTotalDestrio.Caption = "Destrio"
        Me.bandEntradasTotalDestrio.Name = "bandEntradasTotalDestrio"
        '
        'bandEntadasTotalNeto
        '
        Me.bandEntadasTotalNeto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandEntadasTotalNeto.AppearanceHeader.Options.UseFont = True
        Me.bandEntadasTotalNeto.AppearanceHeader.Options.UseTextOptions = True
        Me.bandEntadasTotalNeto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandEntadasTotalNeto.Caption = "Neto"
        Me.bandEntadasTotalNeto.Name = "bandEntadasTotalNeto"
        '
        'bandSalidas
        '
        Me.bandSalidas.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise
        Me.bandSalidas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidas.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidas.AppearanceHeader.Options.UseFont = True
        Me.bandSalidas.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidas.Caption = "SALIDAS"
        Me.bandSalidas.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandSalidasControlado, Me.bandSalidasNoControlado, Me.bandSalidasTotal})
        Me.bandSalidas.Name = "bandSalidas"
        Me.bandSalidas.Width = 210
        '
        'bandSalidasControlado
        '
        Me.bandSalidasControlado.AppearanceHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.bandSalidasControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasControlado.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasControlado.Caption = "CONTROLADO"
        Me.bandSalidasControlado.Name = "bandSalidasControlado"
        '
        'bandSalidasNoControlado
        '
        Me.bandSalidasNoControlado.AppearanceHeader.BackColor = System.Drawing.Color.LightSalmon
        Me.bandSalidasNoControlado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasNoControlado.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasNoControlado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasNoControlado.Caption = "NO CONTROLADO"
        Me.bandSalidasNoControlado.Name = "bandSalidasNoControlado"
        '
        'bandSalidasTotal
        '
        Me.bandSalidasTotal.AppearanceHeader.BackColor = System.Drawing.Color.Moccasin
        Me.bandSalidasTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bandSalidasTotal.AppearanceHeader.Options.UseBackColor = True
        Me.bandSalidasTotal.AppearanceHeader.Options.UseFont = True
        Me.bandSalidasTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.bandSalidasTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bandSalidasTotal.Caption = "TOTAL"
        Me.bandSalidasTotal.Name = "bandSalidasTotal"
        '
        'FrmBandView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 484)
        Me.Controls.Add(Me.GridBalanceMasas)
        Me.Name = "FrmBandView"
        Me.Text = "FrmBandView"
        CType(Me.GridBalanceMasas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBalanceMasas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GridBalanceMasas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBalanceMasas As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents bandEntradas As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasControladoNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasNoControladoNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotalBruto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntradasTotalDestrio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandEntadasTotalNeto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidas As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasNoControlado As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bandSalidasTotal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
