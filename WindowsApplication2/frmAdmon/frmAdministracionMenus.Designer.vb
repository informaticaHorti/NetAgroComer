<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministracionMenus
    Inherits NetAgro.FrMantenimiento

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministracionMenus))
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca_1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.CbPerfiles = New NetAgro.CbBox(Me.components)
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(81, 41)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato_1.TabIndex = 44
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'BtBusca_1
        '
        Me.BtBusca_1.CL_Ancho = 0
        Me.BtBusca_1.CL_BuscaAlb = False
        Me.BtBusca_1.CL_campocodigo = Nothing
        Me.BtBusca_1.CL_camponombre = Nothing
        Me.BtBusca_1.CL_CampoOrden = "Nombre"
        Me.BtBusca_1.CL_ch1000 = False
        Me.BtBusca_1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_1.CL_ControlAsociado = Nothing
        Me.BtBusca_1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_1.CL_dfecha = Nothing
        Me.BtBusca_1.CL_Entidad = Nothing
        Me.BtBusca_1.CL_EsId = True
        Me.BtBusca_1.CL_Filtro = Nothing
        Me.BtBusca_1.cl_formu = Nothing
        Me.BtBusca_1.CL_hfecha = Nothing
        Me.BtBusca_1.cl_ListaW = Nothing
        Me.BtBusca_1.CL_xCentro = False
        Me.BtBusca_1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_1.Location = New System.Drawing.Point(150, 41)
        Me.BtBusca_1.Name = "BtBusca_1"
        Me.BtBusca_1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_1.TabIndex = 43
        Me.BtBusca_1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 44)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(45, 16)
        Me.Lb1.TabIndex = 42
        Me.Lb1.Text = "Perfil"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BotonesAvance1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(836, 32)
        Me.Panel3.TabIndex = 77
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(8, 3)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(101, 24)
        Me.BotonesAvance1.TabIndex = 76
        Me.BotonesAvance1.Udato = Nothing
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(10, 74)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(817, 425)
        Me.Grid.TabIndex = 78
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
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(771, 44)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100276
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(796, 44)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.BtSelTodos.TabIndex = 100275
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(189, 41)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(513, 21)
        Me.Lb_1.TabIndex = 100277
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 507)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(148, 16)
        Me.Lb2.TabIndex = 100278
        Me.Lb2.Text = "Copiar permisos de"
        '
        'CbPerfiles
        '
        Me.CbPerfiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPerfiles.Campobd = Nothing
        Me.CbPerfiles.ClForm = Nothing
        Me.CbPerfiles.DeshabilitarRuedaRaton = False
        Me.CbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPerfiles.FormattingEnabled = True
        Me.CbPerfiles.GridLin = Nothing
        Me.CbPerfiles.Location = New System.Drawing.Point(192, 505)
        Me.CbPerfiles.MiEntidad = Nothing
        Me.CbPerfiles.MiError = False
        Me.CbPerfiles.Name = "CbPerfiles"
        Me.CbPerfiles.Orden = 0
        Me.CbPerfiles.SaltoAlfinal = False
        Me.CbPerfiles.Size = New System.Drawing.Size(297, 21)
        Me.CbPerfiles.TabIndex = 100279
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
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'Button2
        '
        Me.Button2.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.Button2.Location = New System.Drawing.Point(723, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 25)
        Me.Button2.TabIndex = 100280
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAdministracionMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(836, 570)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CbPerfiles)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.BtSelNinguno)
        Me.Controls.Add(Me.BtSelTodos)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxDato_1)
        Me.Controls.Add(Me.BtBusca_1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "frmAdministracionMenus"
        Me.Text = "Permisos sobre elementos del menú"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_1, 0)
        Me.Controls.SetChildIndex(Me.TxDato_1, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.BtSelTodos, 0)
        Me.Controls.SetChildIndex(Me.BtSelNinguno, 0)
        Me.Controls.SetChildIndex(Me.Lb_1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.CbPerfiles, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents BtBusca_1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents CbPerfiles As NetAgro.CbBox
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
