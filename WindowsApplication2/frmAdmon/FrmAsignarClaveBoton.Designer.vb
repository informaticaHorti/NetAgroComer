<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarClaveBoton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarClaveBoton))
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.chkQuitarClave = New NetAgro.Chk(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.ClButton1 = New NetAgro.ClButton()
        Me.GridBotones = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBotones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridFormularios = New DevExpress.XtraGrid.GridControl()
        Me.GridViewFormularios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridFormularios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFormularios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(9, 12)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(94, 16)
        Me.Lb1.TabIndex = 100283
        Me.Lb1.Text = "Formularios"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GridBotones)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 208)
        Me.GroupBox1.TabIndex = 100284
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lb4)
        Me.Panel1.Controls.Add(Me.TxDato2)
        Me.Panel1.Controls.Add(Me.chkQuitarClave)
        Me.Panel1.Controls.Add(Me.Lb2)
        Me.Panel1.Controls.Add(Me.TxDato1)
        Me.Panel1.Controls.Add(Me.ClButton1)
        Me.Panel1.Location = New System.Drawing.Point(348, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 184)
        Me.Panel1.TabIndex = 104
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lb4.Location = New System.Drawing.Point(11, 146)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(51, 16)
        Me.Lb4.TabIndex = 100289
        Me.Lb4.Text = "DESC."
        '
        'TxDato2
        '
        Me.TxDato2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(77, 143)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(383, 22)
        Me.TxDato2.TabIndex = 100288
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'chkQuitarClave
        '
        Me.chkQuitarClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkQuitarClave.AutoSize = True
        Me.chkQuitarClave.Campobd = Nothing
        Me.chkQuitarClave.ClForm = Nothing
        Me.chkQuitarClave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuitarClave.ForeColor = System.Drawing.Color.SteelBlue
        Me.chkQuitarClave.GridLin = Nothing
        Me.chkQuitarClave.HaCambiado = False
        Me.chkQuitarClave.Location = New System.Drawing.Point(357, 113)
        Me.chkQuitarClave.MiEntidad = Nothing
        Me.chkQuitarClave.MiError = False
        Me.chkQuitarClave.Name = "chkQuitarClave"
        Me.chkQuitarClave.Orden = 0
        Me.chkQuitarClave.SaltoAlfinal = False
        Me.chkQuitarClave.Size = New System.Drawing.Size(115, 20)
        Me.chkQuitarClave.TabIndex = 100287
        Me.chkQuitarClave.Text = "Quitar clave"
        Me.chkQuitarClave.UseVisualStyleBackColor = True
        Me.chkQuitarClave.ValorCampoFalse = Nothing
        Me.chkQuitarClave.ValorCampoTrue = Nothing
        Me.chkQuitarClave.ValorDefecto = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lb2.Location = New System.Drawing.Point(11, 115)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(55, 16)
        Me.Lb2.TabIndex = 69
        Me.Lb2.Text = "CLAVE"
        '
        'TxDato1
        '
        Me.TxDato1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(77, 112)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(256, 22)
        Me.TxDato1.TabIndex = 68
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'ClButton1
        '
        Me.ClButton1.Location = New System.Drawing.Point(11, 13)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = False
        Me.ClButton1.Size = New System.Drawing.Size(98, 36)
        Me.ClButton1.TabIndex = 12
        Me.ClButton1.Text = "Botón"
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'GridBotones
        '
        Me.GridBotones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBotones.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridBotones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBotones.Location = New System.Drawing.Point(3, 10)
        Me.GridBotones.LookAndFeel.SkinName = "Black"
        Me.GridBotones.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridBotones.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridBotones.MainView = Me.GridViewBotones
        Me.GridBotones.Name = "GridBotones"
        Me.GridBotones.Size = New System.Drawing.Size(336, 192)
        Me.GridBotones.TabIndex = 11
        Me.GridBotones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBotones})
        '
        'GridViewBotones
        '
        Me.GridViewBotones.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewBotones.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBotones.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewBotones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewBotones.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewBotones.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewBotones.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewBotones.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBotones.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewBotones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewBotones.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewBotones.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewBotones.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewBotones.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewBotones.Appearance.Row.Options.UseFont = True
        Me.GridViewBotones.Appearance.Row.Options.UseForeColor = True
        Me.GridViewBotones.GridControl = Me.GridBotones
        'Me.GridViewBotones.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewBotones.Name = "GridViewBotones"
        Me.GridViewBotones.OptionsView.AutoCalcPreviewLineCount = True
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(722, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 101
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(787, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = False
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 102
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GridFormularios)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 223)
        Me.GroupBox2.TabIndex = 100285
        Me.GroupBox2.TabStop = False
        '
        'GridFormularios
        '
        Me.GridFormularios.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFormularios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFormularios.Location = New System.Drawing.Point(3, 16)
        Me.GridFormularios.LookAndFeel.SkinName = "Black"
        Me.GridFormularios.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridFormularios.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridFormularios.MainView = Me.GridViewFormularios
        Me.GridFormularios.Name = "GridFormularios"
        Me.GridFormularios.Size = New System.Drawing.Size(823, 204)
        Me.GridFormularios.TabIndex = 12
        Me.GridFormularios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFormularios})
        '
        'GridViewFormularios
        '
        Me.GridViewFormularios.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewFormularios.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewFormularios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewFormularios.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewFormularios.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewFormularios.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewFormularios.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewFormularios.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewFormularios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewFormularios.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewFormularios.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewFormularios.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewFormularios.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewFormularios.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewFormularios.Appearance.Row.Options.UseFont = True
        Me.GridViewFormularios.Appearance.Row.Options.UseForeColor = True
        Me.GridViewFormularios.GridControl = Me.GridFormularios
        'Me.GridViewFormularios.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewFormularios.Name = "GridViewFormularios"
        Me.GridViewFormularios.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BGuardar)
        Me.Panel2.Controls.Add(Me.Bsalir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 479)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 34)
        Me.Panel2.TabIndex = 100286
        '
        'Lb3
        '
        Me.Lb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(9, 256)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(68, 16)
        Me.Lb3.TabIndex = 100287
        Me.Lb3.Text = "Botones"
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(203, 5)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(635, 23)
        Me.Barra.TabIndex = 100288
        '
        'FrmAsignarClaveBoton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 513)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "FrmAsignarClaveBoton"
        Me.Text = "Asignar clave a botón de formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridBotones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridFormularios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFormularios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GridBotones As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewBotones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents GridFormularios As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewFormularios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents chkQuitarClave As NetAgro.Chk
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
End Class
