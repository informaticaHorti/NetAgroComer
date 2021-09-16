<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreliminar))
        Me.documento = New C1.C1Preview.C1PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.btImpDirecta = New System.Windows.Forms.ToolStripButton()
        Me.btPaginas = New System.Windows.Forms.ToolStripButton()
        Me.btEmail = New System.Windows.Forms.ToolStripButton()
        CType(Me.documento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'documento
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 494)
        Me.Panel1.TabIndex = 3
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.AvailablePreviewActions = CType(((((((((((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.FileSave Or C1.Win.C1Preview.C1PreviewActionFlags.Print) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageSingle) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageContinuous) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacing) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacingContinuous) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoFirst) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoLast) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPage) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HandTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.SelectTextTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.Find), C1.Win.C1Preview.C1PreviewActionFlags)
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        Me.C1PrintPreviewControl1.OutlineViewCaption = "Marcar"
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.documento
        Me.C1PrintPreviewControl1.PreviewPane.ExportOptions.Content = New C1.Win.C1Preview.ExporterOptions() {New C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "C1.C1Preview.Export.C1dOptionsForm", False, True, False), New C1.Win.C1Preview.ExporterOptions("C1dxExportProvider", "C1.C1Preview.Export.C1dOptionsForm", False, True, False), New C1.Win.C1Preview.ExporterOptions("C1dbExportProvider", "C1.C1Preview.Export.C1dOptionsForm", False, True, False), New C1.Win.C1Preview.ExporterOptions("C1mdxExportProvider", "C1.C1Preview.Export.C1mdxOptionsForm", False, True, False)}
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewPane.ZoomFactor = 0.85R
        Me.C1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.Custom
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(903, 494)
        Me.C1PrintPreviewControl1.StatusBarVisible = False
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "º"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Image = Global.NetAgro.My.Resources.Resources.RibbonPrintPreview_ExportFile
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.File.Open, Me.C1PrintPreviewControl1.ToolBars.File.Save, Me.C1PrintPreviewControl1.ToolBars.File.PageSetup, Me.C1PrintPreviewControl1.ToolBars.File.Print, Me.btImpDirecta, Me.btEmail, Me.btPaginas, Me.C1PrintPreviewControl1.ToolBars.File.Reflow})
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.Name = "fileStrip"
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.Size = New System.Drawing.Size(127, 25)
        Me.C1PrintPreviewControl1.ToolBars.File.ToolStrip.TabIndex = 0
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = Global.NetAgro.My.Resources.Resources.Primero16
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = Global.NetAgro.My.Resources.Resources.Ultimo16
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = Global.NetAgro.My.Resources.Resources.Siguiente16
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = Global.NetAgro.My.Resources.Resources.Anterior16
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_right_16x16_32
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_left_16x16_32
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst, Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev, Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage, Me.C1PrintPreviewControl1.ToolBars.Navigation.PageNo, Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages, Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext, Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast, Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev, Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext})
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.Location = New System.Drawing.Point(283, 0)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.Name = "navigationStrip"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.Size = New System.Drawing.Size(270, 25)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolStrip.TabIndex = 2
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Name = "btnCloseSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Tag = "C1PreviewActionEnum.CloseSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.ToolTipText = "Close"
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Name = "btnMatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Size = New System.Drawing.Size(73, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Tag = "C1PreviewActionEnum.MatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Text = "Match Case"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.ToolTipText = "Search with case sensitivity"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.Name = "btnMatchWholeWord"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.Size = New System.Drawing.Size(77, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.Tag = "C1PreviewActionEnum.MatchWholeWord"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.Text = "Whole Word"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.ToolTipText = "Match whole word only"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Name = "lblSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Tag = "C1PreviewActionEnum.SearchLabel"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Text = "Find:"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Name = "btnSearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Tag = "C1PreviewActionEnum.SearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.ToolTipText = "Search Next"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Name = "btnSearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Tag = "C1PreviewActionEnum.SearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.ToolTipText = "Search Previous"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchText.Name = "txtSearchText"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchText.Size = New System.Drawing.Size(200, 25)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchText.Tag = "C1PreviewActionEnum.SearchText"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchText.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel, Me.C1PrintPreviewControl1.ToolBars.Search.SearchText, Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext, Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious, Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase, Me.C1PrintPreviewControl1.ToolBars.Search.MatchWholeWord, Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch})
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Name = "searchStrip"
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Size = New System.Drawing.Size(444, 25)
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.TabIndex = 6
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Tag = "C1PreviewSearchToolStrip"
        Me.C1PrintPreviewControl1.ToolBars.Search.ToolStrip.Visible = False
        '
        'btImpDirecta
        '
        Me.btImpDirecta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btImpDirecta.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.btImpDirecta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btImpDirecta.Name = "btImpDirecta"
        Me.btImpDirecta.Size = New System.Drawing.Size(23, 22)
        Me.btImpDirecta.ToolTipText = "Impresión directa"
        '
        'btPaginas
        '
        Me.btPaginas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btPaginas.Image = Global.NetAgro.My.Resources.Resources.Action_view_choose_16x16_32
        Me.btPaginas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPaginas.Name = "btPaginas"
        Me.btPaginas.Size = New System.Drawing.Size(23, 22)
        Me.btPaginas.Text = "ToolStripButton1"
        Me.btPaginas.ToolTipText = "Ocultar/mostrar panel navegación"
        '
        'btEmail
        '
        Me.btEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btEmail.Image = Global.NetAgro.My.Resources.Resources.App_xf_mail_16x16_32
        Me.btEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEmail.Name = "btEmail"
        Me.btEmail.Size = New System.Drawing.Size(23, 22)
        '
        'frmPreliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPreliminar"
        Me.Text = "Preliminar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.documento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents documento As C1.C1Preview.C1PrintDocument
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents btImpDirecta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btPaginas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEmail As System.Windows.Forms.ToolStripButton
End Class
