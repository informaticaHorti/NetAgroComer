<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdicionEntidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdicionEntidades))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.BAnular = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.pnlBuscaPorCampos = New System.Windows.Forms.Panel()
        Me.GridBusqueda = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlEntidades = New System.Windows.Forms.Panel()
        Me.GridEntidades = New DevExpress.XtraGrid.GridControl()
        Me.GridViewEntidades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlResultados = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridEntidad = New DevExpress.XtraGrid.GridControl()
        Me.GridViewEntidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlResultadosBusqueda = New System.Windows.Forms.Panel()
        Me.GridResultados = New DevExpress.XtraGrid.GridControl()
        Me.GridViewResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        Me.pnlBuscaPorCampos.SuspendLayout()
        CType(Me.GridBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEntidades.SuspendLayout()
        CType(Me.GridEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResultados.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResultadosBusqueda.SuspendLayout()
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.BAnular)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 528)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 34)
        Me.Panel1.TabIndex = 3
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(989, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BAnular
        '
        Me.BAnular.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAnular.Image = CType(resources.GetObject("BAnular.Image"), System.Drawing.Image)
        Me.BAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAnular.Location = New System.Drawing.Point(1054, 0)
        Me.BAnular.Name = "BAnular"
        Me.BAnular.Size = New System.Drawing.Size(65, 34)
        Me.BAnular.TabIndex = 99
        Me.BAnular.Text = "Anular"
        Me.BAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnular.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1119, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.pnlBuscaPorCampos)
        Me.pnlBusqueda.Controls.Add(Me.pnlEntidades)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(338, 528)
        Me.pnlBusqueda.TabIndex = 4
        '
        'pnlBuscaPorCampos
        '
        Me.pnlBuscaPorCampos.Controls.Add(Me.GridBusqueda)
        Me.pnlBuscaPorCampos.Controls.Add(Me.Label1)
        Me.pnlBuscaPorCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBuscaPorCampos.Location = New System.Drawing.Point(0, 262)
        Me.pnlBuscaPorCampos.Name = "pnlBuscaPorCampos"
        Me.pnlBuscaPorCampos.Size = New System.Drawing.Size(338, 266)
        Me.pnlBuscaPorCampos.TabIndex = 1
        '
        'GridBusqueda
        '
        Me.GridBusqueda.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBusqueda.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBusqueda.Location = New System.Drawing.Point(0, 30)
        Me.GridBusqueda.LookAndFeel.SkinName = "Black"
        Me.GridBusqueda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridBusqueda.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridBusqueda.MainView = Me.GridViewBusqueda
        Me.GridBusqueda.Name = "GridBusqueda"
        Me.GridBusqueda.Size = New System.Drawing.Size(338, 236)
        Me.GridBusqueda.TabIndex = 12
        Me.GridBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBusqueda})
        '
        'GridViewBusqueda
        '
        Me.GridViewBusqueda.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewBusqueda.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBusqueda.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewBusqueda.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewBusqueda.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewBusqueda.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewBusqueda.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewBusqueda.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBusqueda.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewBusqueda.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewBusqueda.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewBusqueda.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewBusqueda.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBusqueda.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridViewBusqueda.Appearance.Row.Options.UseFont = True
        Me.GridViewBusqueda.Appearance.Row.Options.UseForeColor = True
        Me.GridViewBusqueda.GridControl = Me.GridBusqueda
        Me.GridViewBusqueda.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBusqueda.Name = "GridViewBusqueda"
        Me.GridViewBusqueda.OptionsBehavior.Editable = False
        Me.GridViewBusqueda.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewBusqueda.OptionsView.ShowAutoFilterRow = True
        Me.GridViewBusqueda.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Búsqueda por campo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlEntidades
        '
        Me.pnlEntidades.Controls.Add(Me.GridEntidades)
        Me.pnlEntidades.Controls.Add(Me.Label3)
        Me.pnlEntidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEntidades.Location = New System.Drawing.Point(0, 0)
        Me.pnlEntidades.Name = "pnlEntidades"
        Me.pnlEntidades.Size = New System.Drawing.Size(338, 262)
        Me.pnlEntidades.TabIndex = 0
        '
        'GridEntidades
        '
        Me.GridEntidades.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridEntidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEntidades.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEntidades.Location = New System.Drawing.Point(0, 30)
        Me.GridEntidades.LookAndFeel.SkinName = "Black"
        Me.GridEntidades.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridEntidades.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridEntidades.MainView = Me.GridViewEntidades
        Me.GridEntidades.Name = "GridEntidades"
        Me.GridEntidades.Size = New System.Drawing.Size(338, 232)
        Me.GridEntidades.TabIndex = 11
        Me.GridEntidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewEntidades})
        '
        'GridViewEntidades
        '
        Me.GridViewEntidades.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewEntidades.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidades.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewEntidades.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewEntidades.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewEntidades.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewEntidades.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewEntidades.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidades.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewEntidades.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewEntidades.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewEntidades.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewEntidades.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidades.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridViewEntidades.Appearance.Row.Options.UseFont = True
        Me.GridViewEntidades.Appearance.Row.Options.UseForeColor = True
        Me.GridViewEntidades.GridControl = Me.GridEntidades
        Me.GridViewEntidades.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewEntidades.Name = "GridViewEntidades"
        Me.GridViewEntidades.OptionsBehavior.Editable = False
        Me.GridViewEntidades.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewEntidades.OptionsView.ShowAutoFilterRow = True
        Me.GridViewEntidades.OptionsView.ShowGroupPanel = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entidades"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlResultados
        '
        Me.pnlResultados.Controls.Add(Me.Panel2)
        Me.pnlResultados.Controls.Add(Me.pnlResultadosBusqueda)
        Me.pnlResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResultados.Location = New System.Drawing.Point(338, 0)
        Me.pnlResultados.Name = "pnlResultados"
        Me.pnlResultados.Size = New System.Drawing.Size(846, 528)
        Me.pnlResultados.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridEntidad)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 323)
        Me.Panel2.TabIndex = 1
        '
        'GridEntidad
        '
        Me.GridEntidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridEntidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEntidad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEntidad.Location = New System.Drawing.Point(0, 30)
        Me.GridEntidad.LookAndFeel.SkinName = "Black"
        Me.GridEntidad.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridEntidad.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridEntidad.MainView = Me.GridViewEntidad
        Me.GridEntidad.Name = "GridEntidad"
        Me.GridEntidad.Size = New System.Drawing.Size(846, 293)
        Me.GridEntidad.TabIndex = 12
        Me.GridEntidad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewEntidad})
        '
        'GridViewEntidad
        '
        Me.GridViewEntidad.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewEntidad.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidad.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewEntidad.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewEntidad.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewEntidad.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewEntidad.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewEntidad.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidad.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewEntidad.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewEntidad.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewEntidad.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewEntidad.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewEntidad.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewEntidad.Appearance.Row.Options.UseFont = True
        Me.GridViewEntidad.Appearance.Row.Options.UseForeColor = True
        Me.GridViewEntidad.GridControl = Me.GridEntidad
        Me.GridViewEntidad.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewEntidad.Name = "GridViewEntidad"
        Me.GridViewEntidad.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewEntidad.OptionsView.ShowAutoFilterRow = True
        Me.GridViewEntidad.OptionsView.ShowGroupPanel = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(846, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Valores entidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlResultadosBusqueda
        '
        Me.pnlResultadosBusqueda.Controls.Add(Me.GridResultados)
        Me.pnlResultadosBusqueda.Controls.Add(Me.Label2)
        Me.pnlResultadosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlResultadosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.pnlResultadosBusqueda.Name = "pnlResultadosBusqueda"
        Me.pnlResultadosBusqueda.Size = New System.Drawing.Size(846, 205)
        Me.pnlResultadosBusqueda.TabIndex = 0
        '
        'GridResultados
        '
        Me.GridResultados.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResultados.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridResultados.Location = New System.Drawing.Point(0, 30)
        Me.GridResultados.LookAndFeel.SkinName = "Black"
        Me.GridResultados.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridResultados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridResultados.MainView = Me.GridViewResultados
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.Size = New System.Drawing.Size(846, 175)
        Me.GridResultados.TabIndex = 12
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewResultados})
        '
        'GridViewResultados
        '
        Me.GridViewResultados.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewResultados.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResultados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewResultados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewResultados.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewResultados.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewResultados.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewResultados.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResultados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewResultados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewResultados.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewResultados.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewResultados.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewResultados.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewResultados.Appearance.Row.Options.UseFont = True
        Me.GridViewResultados.Appearance.Row.Options.UseForeColor = True
        Me.GridViewResultados.GridControl = Me.GridResultados
        Me.GridViewResultados.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewResultados.Name = "GridViewResultados"
        Me.GridViewResultados.OptionsBehavior.Editable = False
        Me.GridViewResultados.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewResultados.OptionsView.ShowAutoFilterRow = True
        Me.GridViewResultados.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resultados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEdicionEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 562)
        Me.Controls.Add(Me.pnlResultados)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEdicionEntidades"
        Me.Text = "Edición entidades"
        Me.Panel1.ResumeLayout(False)
        Me.pnlBusqueda.ResumeLayout(False)
        Me.pnlBuscaPorCampos.ResumeLayout(False)
        CType(Me.GridBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEntidades.ResumeLayout(False)
        CType(Me.GridEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResultados.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResultadosBusqueda.ResumeLayout(False)
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents BAnular As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents pnlResultados As System.Windows.Forms.Panel
    Friend WithEvents pnlBuscaPorCampos As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlEntidades As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlResultadosBusqueda As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents GridEntidades As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewEntidades As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridBusqueda As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridEntidad As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewEntidad As DevExpress.XtraGrid.Views.Grid.GridView
End Class
