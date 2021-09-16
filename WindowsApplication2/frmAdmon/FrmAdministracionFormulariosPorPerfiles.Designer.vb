<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministracionFormulariosPorPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministracionFormulariosPorPerfiles))
        Me.Partidas = New System.Windows.Forms.GroupBox()
        Me.ChkTodas = New NetAgro.Chk(Me.components)
        Me.ChkBajas = New NetAgro.Chk(Me.components)
        Me.ChkModificaciones = New NetAgro.Chk(Me.components)
        Me.ChkAltas = New NetAgro.Chk(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.CbFormularios = New NetAgro.CbBox(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.Partidas.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Partidas
        '
        Me.Partidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Partidas.Controls.Add(Me.ChkTodas)
        Me.Partidas.Controls.Add(Me.ChkBajas)
        Me.Partidas.Controls.Add(Me.ChkModificaciones)
        Me.Partidas.Controls.Add(Me.ChkAltas)
        Me.Partidas.Controls.Add(Me.Lb3)
        Me.Partidas.Controls.Add(Me.Grid)
        Me.Partidas.Location = New System.Drawing.Point(12, 75)
        Me.Partidas.Name = "Partidas"
        Me.Partidas.Size = New System.Drawing.Size(673, 421)
        Me.Partidas.TabIndex = 0
        Me.Partidas.TabStop = False
        '
        'ChkTodas
        '
        Me.ChkTodas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkTodas.AutoSize = True
        Me.ChkTodas.Campobd = Nothing
        Me.ChkTodas.ClForm = Nothing
        Me.ChkTodas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTodas.ForeColor = System.Drawing.Color.Teal
        Me.ChkTodas.GridLin = Nothing
        Me.ChkTodas.HaCambiado = False
        Me.ChkTodas.Location = New System.Drawing.Point(602, 17)
        Me.ChkTodas.MiEntidad = Nothing
        Me.ChkTodas.MiError = False
        Me.ChkTodas.Name = "ChkTodas"
        Me.ChkTodas.Orden = 0
        Me.ChkTodas.SaltoAlfinal = False
        Me.ChkTodas.Size = New System.Drawing.Size(65, 18)
        Me.ChkTodas.TabIndex = 100295
        Me.ChkTodas.Text = "Todas"
        Me.ChkTodas.UseVisualStyleBackColor = True
        Me.ChkTodas.ValorCampoFalse = Nothing
        Me.ChkTodas.ValorCampoTrue = Nothing
        Me.ChkTodas.ValorDefecto = False
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
        Me.ChkBajas.Location = New System.Drawing.Point(527, 17)
        Me.ChkBajas.MiEntidad = Nothing
        Me.ChkBajas.MiError = False
        Me.ChkBajas.Name = "ChkBajas"
        Me.ChkBajas.Orden = 0
        Me.ChkBajas.SaltoAlfinal = False
        Me.ChkBajas.Size = New System.Drawing.Size(63, 18)
        Me.ChkBajas.TabIndex = 100294
        Me.ChkBajas.Text = "Bajas"
        Me.ChkBajas.UseVisualStyleBackColor = True
        Me.ChkBajas.ValorCampoFalse = Nothing
        Me.ChkBajas.ValorCampoTrue = Nothing
        Me.ChkBajas.ValorDefecto = False
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
        Me.ChkModificaciones.Location = New System.Drawing.Point(392, 17)
        Me.ChkModificaciones.MiEntidad = Nothing
        Me.ChkModificaciones.MiError = False
        Me.ChkModificaciones.Name = "ChkModificaciones"
        Me.ChkModificaciones.Orden = 0
        Me.ChkModificaciones.SaltoAlfinal = False
        Me.ChkModificaciones.Size = New System.Drawing.Size(123, 18)
        Me.ChkModificaciones.TabIndex = 100293
        Me.ChkModificaciones.Text = "Modificaciones"
        Me.ChkModificaciones.UseVisualStyleBackColor = True
        Me.ChkModificaciones.ValorCampoFalse = Nothing
        Me.ChkModificaciones.ValorCampoTrue = Nothing
        Me.ChkModificaciones.ValorDefecto = False
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
        Me.ChkAltas.Location = New System.Drawing.Point(321, 17)
        Me.ChkAltas.MiEntidad = Nothing
        Me.ChkAltas.MiError = False
        Me.ChkAltas.Name = "ChkAltas"
        Me.ChkAltas.Orden = 0
        Me.ChkAltas.SaltoAlfinal = False
        Me.ChkAltas.Size = New System.Drawing.Size(59, 18)
        Me.ChkAltas.TabIndex = 100292
        Me.ChkAltas.Text = "Altas"
        Me.ChkAltas.UseVisualStyleBackColor = True
        Me.ChkAltas.ValorCampoFalse = Nothing
        Me.ChkAltas.ValorCampoTrue = Nothing
        Me.ChkAltas.ValorDefecto = False
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
        Me.Lb3.Location = New System.Drawing.Point(176, 18)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(127, 16)
        Me.Lb3.TabIndex = 100291
        Me.Lb3.Text = "Marcar todas las"
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(3, 43)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(667, 372)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        '
        'Lb_1
        '
        Me.Lb_1.AutoSize = True
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.Teal
        Me.Lb_1.Location = New System.Drawing.Point(12, 20)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(87, 16)
        Me.Lb_1.TabIndex = 91
        Me.Lb_1.Text = "Formulario"
        '
        'CbFormularios
        '
        Me.CbFormularios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFormularios.Campobd = Nothing
        Me.CbFormularios.ClForm = Nothing
        Me.CbFormularios.DeshabilitarRuedaRaton = False
        Me.CbFormularios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFormularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFormularios.FormattingEnabled = True
        Me.CbFormularios.GridLin = Nothing
        Me.CbFormularios.Location = New System.Drawing.Point(105, 16)
        Me.CbFormularios.MiEntidad = Nothing
        Me.CbFormularios.MiError = False
        Me.CbFormularios.Name = "CbFormularios"
        Me.CbFormularios.Orden = 0
        Me.CbFormularios.SaltoAlfinal = False
        Me.CbFormularios.Size = New System.Drawing.Size(577, 24)
        Me.CbFormularios.TabIndex = 100282
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 34)
        Me.Panel1.TabIndex = 100283
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(567, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(632, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(105, 46)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(574, 23)
        Me.Barra.TabIndex = 100293
        '
        'FrmAdministracionFormulariosPorPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 541)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbFormularios)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.Partidas)
        Me.Name = "FrmAdministracionFormulariosPorPerfiles"
        Me.Text = "Permisos sobre formularios (por perfiles)"
        Me.Partidas.ResumeLayout(False)
        Me.Partidas.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Partidas As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tt As System.Windows.Forms.ToolTip
    Friend WithEvents CbFormularios As NetAgro.CbBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents ChkTodas As NetAgro.Chk
    Friend WithEvents ChkBajas As NetAgro.Chk
    Friend WithEvents ChkModificaciones As NetAgro.Chk
    Friend WithEvents ChkAltas As NetAgro.Chk
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
End Class
