<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaletsRFID
    Inherits NetAgro.FrMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaletsRFID))
        Me.BtBuscaPalets = New NetAgro.BtBusca(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxKgBrutos = New NetAgro.TxDato(Me.components)
        Me.LbPalet = New NetAgro.Lb(Me.components)
        Me.TxPalet = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbTaraPalet = New NetAgro.Lb(Me.components)
        Me.LbTaraBultos = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BtBuscaPalets
        '
        Me.BtBuscaPalets.CL_Ancho = 0
        Me.BtBuscaPalets.CL_BuscaAlb = False
        Me.BtBuscaPalets.CL_campocodigo = Nothing
        Me.BtBuscaPalets.CL_camponombre = Nothing
        Me.BtBuscaPalets.CL_CampoOrden = "Nombre"
        Me.BtBuscaPalets.CL_ch1000 = False
        Me.BtBuscaPalets.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaPalets.CL_ControlAsociado = Nothing
        Me.BtBuscaPalets.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaPalets.CL_dfecha = Nothing
        Me.BtBuscaPalets.CL_Entidad = Nothing
        Me.BtBuscaPalets.CL_EsId = True
        Me.BtBuscaPalets.CL_Filtro = Nothing
        Me.BtBuscaPalets.cl_formu = Nothing
        Me.BtBuscaPalets.CL_hfecha = Nothing
        Me.BtBuscaPalets.cl_ListaW = Nothing
        Me.BtBuscaPalets.CL_xCentro = False
        Me.BtBuscaPalets.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaPalets.Location = New System.Drawing.Point(254, 25)
        Me.BtBuscaPalets.Name = "BtBuscaPalets"
        Me.BtBuscaPalets.Size = New System.Drawing.Size(42, 40)
        Me.BtBuscaPalets.TabIndex = 39
        Me.BtBuscaPalets.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(12, 146)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(157, 33)
        Me.Lb4.TabIndex = 38
        Me.Lb4.Text = "Kg. Brutos"
        '
        'TxKgBrutos
        '
        Me.TxKgBrutos.Autonumerico = False
        Me.TxKgBrutos.Buscando = False
        Me.TxKgBrutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKgBrutos.ClForm = Nothing
        Me.TxKgBrutos.ClParam = Nothing
        Me.TxKgBrutos.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKgBrutos.GridLin = Nothing
        Me.TxKgBrutos.HaCambiado = False
        Me.TxKgBrutos.lbbusca = Nothing
        Me.TxKgBrutos.Location = New System.Drawing.Point(183, 142)
        Me.TxKgBrutos.MiError = False
        Me.TxKgBrutos.Name = "TxKgBrutos"
        Me.TxKgBrutos.Orden = 0
        Me.TxKgBrutos.SaltoAlfinal = False
        Me.TxKgBrutos.Siguiente = 0
        Me.TxKgBrutos.Size = New System.Drawing.Size(172, 40)
        Me.TxKgBrutos.TabIndex = 37
        Me.TxKgBrutos.TeclaRepetida = False
        Me.TxKgBrutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKgBrutos.TxDatoFinalSemana = Nothing
        Me.TxKgBrutos.TxDatoInicioSemana = Nothing
        Me.TxKgBrutos.UltimoValorValidado = Nothing
        '
        'LbPalet
        '
        Me.LbPalet.AutoSize = True
        Me.LbPalet.CL_ControlAsociado = Nothing
        Me.LbPalet.CL_ValorFijo = False
        Me.LbPalet.ClForm = Nothing
        Me.LbPalet.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet.Location = New System.Drawing.Point(12, 29)
        Me.LbPalet.Name = "LbPalet"
        Me.LbPalet.Size = New System.Drawing.Size(84, 33)
        Me.LbPalet.TabIndex = 36
        Me.LbPalet.Text = "Palet"
        '
        'TxPalet
        '
        Me.TxPalet.Autonumerico = False
        Me.TxPalet.Buscando = False
        Me.TxPalet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet.ClForm = Nothing
        Me.TxPalet.ClParam = Nothing
        Me.TxPalet.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet.GridLin = Nothing
        Me.TxPalet.HaCambiado = False
        Me.TxPalet.lbbusca = Nothing
        Me.TxPalet.Location = New System.Drawing.Point(110, 25)
        Me.TxPalet.MiError = False
        Me.TxPalet.Name = "TxPalet"
        Me.TxPalet.Orden = 0
        Me.TxPalet.SaltoAlfinal = False
        Me.TxPalet.Siguiente = 0
        Me.TxPalet.Size = New System.Drawing.Size(140, 40)
        Me.TxPalet.TabIndex = 40
        Me.TxPalet.TeclaRepetida = False
        Me.TxPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxPalet.TxDatoFinalSemana = Nothing
        Me.TxPalet.TxDatoInicioSemana = Nothing
        Me.TxPalet.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 29)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(153, 33)
        Me.Lb2.TabIndex = 41
        Me.Lb2.Text = "Tara Palet"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 75)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(168, 33)
        Me.Lb3.TabIndex = 42
        Me.Lb3.Text = "Tara bultos"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(410, 0)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(774, 428)
        Me.Grid.TabIndex = 43
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
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        '
        'LbTaraPalet
        '
        Me.LbTaraPalet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTaraPalet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTaraPalet.CL_ControlAsociado = Nothing
        Me.LbTaraPalet.CL_ValorFijo = False
        Me.LbTaraPalet.ClForm = Nothing
        Me.LbTaraPalet.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTaraPalet.Location = New System.Drawing.Point(183, 29)
        Me.LbTaraPalet.Name = "LbTaraPalet"
        Me.LbTaraPalet.Size = New System.Drawing.Size(142, 33)
        Me.LbTaraPalet.TabIndex = 136
        Me.LbTaraPalet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbTaraBultos
        '
        Me.LbTaraBultos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTaraBultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTaraBultos.CL_ControlAsociado = Nothing
        Me.LbTaraBultos.CL_ValorFijo = False
        Me.LbTaraBultos.ClForm = Nothing
        Me.LbTaraBultos.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTaraBultos.Location = New System.Drawing.Point(183, 75)
        Me.LbTaraBultos.Name = "LbTaraBultos"
        Me.LbTaraBultos.Size = New System.Drawing.Size(142, 33)
        Me.LbTaraBultos.TabIndex = 137
        Me.LbTaraBultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.LbTaraBultos)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.LbTaraPalet)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.TxKgBrutos)
        Me.Panel2.Location = New System.Drawing.Point(7, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 211)
        Me.Panel2.TabIndex = 138
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(317, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 139
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 311)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(377, 95)
        Me.ListBox1.TabIndex = 140
        '
        'FrmPaletsRFID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1184, 462)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TxPalet)
        Me.Controls.Add(Me.BtBuscaPalets)
        Me.Controls.Add(Me.LbPalet)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPaletsRFID"
        Me.Text = "Pesar palets"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbPalet, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaPalets, 0)
        Me.Controls.SetChildIndex(Me.TxPalet, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.ListBox1, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtBuscaPalets As NetAgro.BtBusca
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxKgBrutos As NetAgro.TxDato
    Friend WithEvents LbPalet As NetAgro.Lb
    Friend WithEvents TxPalet As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbTaraPalet As NetAgro.Lb
    Friend WithEvents LbTaraBultos As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
