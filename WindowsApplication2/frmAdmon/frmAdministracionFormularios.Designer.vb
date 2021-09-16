<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministracionFormularios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministracionFormularios))
        Me.CbPerfiles = New NetAgro.CbBox(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.CbPerfilesOrigen = New NetAgro.CbBox(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.ChkAltas = New NetAgro.Chk(Me.components)
        Me.ChkModificaciones = New NetAgro.Chk(Me.components)
        Me.ChkBajas = New NetAgro.Chk(Me.components)
        Me.btTodos = New System.Windows.Forms.Button()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'CbPerfiles
        '
        Me.CbPerfiles.Campobd = Nothing
        Me.CbPerfiles.ClForm = Nothing
        Me.CbPerfiles.DeshabilitarRuedaRaton = False
        Me.CbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPerfiles.FormattingEnabled = True
        Me.CbPerfiles.GridLin = Nothing
        Me.CbPerfiles.Location = New System.Drawing.Point(63, 13)
        Me.CbPerfiles.MiEntidad = Nothing
        Me.CbPerfiles.MiError = False
        Me.CbPerfiles.Name = "CbPerfiles"
        Me.CbPerfiles.Orden = 0
        Me.CbPerfiles.SaltoAlfinal = False
        Me.CbPerfiles.Size = New System.Drawing.Size(347, 21)
        Me.CbPerfiles.TabIndex = 100281
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 15)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(45, 16)
        Me.Lb1.TabIndex = 100280
        Me.Lb1.Text = "Perfil"
        '
        'CbPerfilesOrigen
        '
        Me.CbPerfilesOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPerfilesOrigen.Campobd = Nothing
        Me.CbPerfilesOrigen.ClForm = Nothing
        Me.CbPerfilesOrigen.DeshabilitarRuedaRaton = False
        Me.CbPerfilesOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPerfilesOrigen.FormattingEnabled = True
        Me.CbPerfilesOrigen.GridLin = Nothing
        Me.CbPerfilesOrigen.Location = New System.Drawing.Point(192, 476)
        Me.CbPerfilesOrigen.MiEntidad = Nothing
        Me.CbPerfilesOrigen.MiError = False
        Me.CbPerfilesOrigen.Name = "CbPerfilesOrigen"
        Me.CbPerfilesOrigen.Orden = 0
        Me.CbPerfilesOrigen.SaltoAlfinal = False
        Me.CbPerfilesOrigen.Size = New System.Drawing.Size(347, 21)
        Me.CbPerfilesOrigen.TabIndex = 100286
        '
        'Lb2
        '
        Me.Lb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 477)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(148, 16)
        Me.Lb2.TabIndex = 100285
        Me.Lb2.Text = "Copiar permisos de"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(12, 70)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(862, 400)
        Me.Grid.TabIndex = 100282
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
        'Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Lb3
        '
        Me.Lb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(478, 15)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(127, 16)
        Me.Lb3.TabIndex = 100287
        Me.Lb3.Text = "Marcar todas las"
        '
        'ChkAltas
        '
        Me.ChkAltas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAltas.AutoSize = True
        Me.ChkAltas.Campobd = Nothing
        Me.ChkAltas.ClForm = Nothing
        Me.ChkAltas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAltas.ForeColor = System.Drawing.Color.Teal
        Me.ChkAltas.GridLin = Nothing
        Me.ChkAltas.HaCambiado = False
        Me.ChkAltas.Location = New System.Drawing.Point(617, 14)
        Me.ChkAltas.MiEntidad = Nothing
        Me.ChkAltas.MiError = False
        Me.ChkAltas.Name = "ChkAltas"
        Me.ChkAltas.Orden = 0
        Me.ChkAltas.SaltoAlfinal = False
        Me.ChkAltas.Size = New System.Drawing.Size(59, 18)
        Me.ChkAltas.TabIndex = 100288
        Me.ChkAltas.Text = "Altas"
        Me.ChkAltas.UseVisualStyleBackColor = True
        Me.ChkAltas.ValorCampoFalse = Nothing
        Me.ChkAltas.ValorCampoTrue = Nothing
        Me.ChkAltas.ValorDefecto = False
        '
        'ChkModificaciones
        '
        Me.ChkModificaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkModificaciones.AutoSize = True
        Me.ChkModificaciones.Campobd = Nothing
        Me.ChkModificaciones.ClForm = Nothing
        Me.ChkModificaciones.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkModificaciones.ForeColor = System.Drawing.Color.Teal
        Me.ChkModificaciones.GridLin = Nothing
        Me.ChkModificaciones.HaCambiado = False
        Me.ChkModificaciones.Location = New System.Drawing.Point(683, 14)
        Me.ChkModificaciones.MiEntidad = Nothing
        Me.ChkModificaciones.MiError = False
        Me.ChkModificaciones.Name = "ChkModificaciones"
        Me.ChkModificaciones.Orden = 0
        Me.ChkModificaciones.SaltoAlfinal = False
        Me.ChkModificaciones.Size = New System.Drawing.Size(123, 18)
        Me.ChkModificaciones.TabIndex = 100289
        Me.ChkModificaciones.Text = "Modificaciones"
        Me.ChkModificaciones.UseVisualStyleBackColor = True
        Me.ChkModificaciones.ValorCampoFalse = Nothing
        Me.ChkModificaciones.ValorCampoTrue = Nothing
        Me.ChkModificaciones.ValorDefecto = False
        '
        'ChkBajas
        '
        Me.ChkBajas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBajas.AutoSize = True
        Me.ChkBajas.Campobd = Nothing
        Me.ChkBajas.ClForm = Nothing
        Me.ChkBajas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBajas.ForeColor = System.Drawing.Color.Teal
        Me.ChkBajas.GridLin = Nothing
        Me.ChkBajas.HaCambiado = False
        Me.ChkBajas.Location = New System.Drawing.Point(812, 14)
        Me.ChkBajas.MiEntidad = Nothing
        Me.ChkBajas.MiError = False
        Me.ChkBajas.Name = "ChkBajas"
        Me.ChkBajas.Orden = 0
        Me.ChkBajas.SaltoAlfinal = False
        Me.ChkBajas.Size = New System.Drawing.Size(63, 18)
        Me.ChkBajas.TabIndex = 100290
        Me.ChkBajas.Text = "Bajas"
        Me.ChkBajas.UseVisualStyleBackColor = True
        Me.ChkBajas.ValorCampoFalse = Nothing
        Me.ChkBajas.ValorCampoTrue = Nothing
        Me.ChkBajas.ValorDefecto = False
        '
        'btTodos
        '
        Me.btTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btTodos.Location = New System.Drawing.Point(649, 475)
        Me.btTodos.Name = "btTodos"
        Me.btTodos.Size = New System.Drawing.Size(225, 23)
        Me.btTodos.TabIndex = 100291
        Me.btTodos.Text = "Dar todos los permisos a todos los usuarios"
        Me.btTodos.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(12, 40)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(398, 23)
        Me.Barra.TabIndex = 100292
        '
        'frmAdministracionFormularios
        '
        Me.ClientSize = New System.Drawing.Size(886, 541)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.btTodos)
        Me.Controls.Add(Me.ChkBajas)
        Me.Controls.Add(Me.ChkModificaciones)
        Me.Controls.Add(Me.ChkAltas)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.CbPerfilesOrigen)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.CbPerfiles)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "frmAdministracionFormularios"
        Me.Text = "Permisos sobre formularios"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.CbPerfiles, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.CbPerfilesOrigen, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.ChkAltas, 0)
        Me.Controls.SetChildIndex(Me.ChkModificaciones, 0)
        Me.Controls.SetChildIndex(Me.ChkBajas, 0)
        Me.Controls.SetChildIndex(Me.btTodos, 0)
        Me.Controls.SetChildIndex(Me.Barra, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbPerfiles As NetAgro.CbBox
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CbPerfilesOrigen As NetAgro.CbBox
    Friend WithEvents Lb2 As NetAgro.Lb
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents ChkAltas As NetAgro.Chk
    Friend WithEvents ChkModificaciones As NetAgro.Chk
    Friend WithEvents ChkBajas As NetAgro.Chk
    Friend WithEvents btTodos As System.Windows.Forms.Button
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar

End Class
