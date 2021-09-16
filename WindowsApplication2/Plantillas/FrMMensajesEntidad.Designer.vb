<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMMensajesEntidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMMensajesEntidad))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RbLeidosNO = New System.Windows.Forms.RadioButton()
        Me.RbLeidosSI = New System.Windows.Forms.RadioButton()
        Me.RbLeidosTodos = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RbRecibidos = New System.Windows.Forms.RadioButton()
        Me.RbEnviados = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.dOpenFileBuzon = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb18 = New NetAgro.Lb(Me.components)
        Me.ChUsuarios = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.ChGrupos = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxMensaje = New System.Windows.Forms.TextBox()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ClButton2 = New NetAgro.ClButton()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ChUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 436)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 34)
        Me.Panel1.TabIndex = 3
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1226, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(82, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1308, 16)
        Me.Panel3.TabIndex = 10
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ClButton2)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 394)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1308, 42)
        Me.Panel4.TabIndex = 900003
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RbLeidosNO)
        Me.Panel6.Controls.Add(Me.RbLeidosSI)
        Me.Panel6.Controls.Add(Me.RbLeidosTodos)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(971, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(337, 42)
        Me.Panel6.TabIndex = 100317
        '
        'RbLeidosNO
        '
        Me.RbLeidosNO.AutoSize = True
        Me.RbLeidosNO.Checked = True
        Me.RbLeidosNO.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLeidosNO.Location = New System.Drawing.Point(210, 9)
        Me.RbLeidosNO.Name = "RbLeidosNO"
        Me.RbLeidosNO.Size = New System.Drawing.Size(124, 22)
        Me.RbLeidosNO.TabIndex = 2
        Me.RbLeidosNO.TabStop = True
        Me.RbLeidosNO.Text = "Pendientes"
        Me.RbLeidosNO.UseVisualStyleBackColor = True
        '
        'RbLeidosSI
        '
        Me.RbLeidosSI.AutoSize = True
        Me.RbLeidosSI.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLeidosSI.Location = New System.Drawing.Point(111, 9)
        Me.RbLeidosSI.Name = "RbLeidosSI"
        Me.RbLeidosSI.Size = New System.Drawing.Size(82, 22)
        Me.RbLeidosSI.TabIndex = 1
        Me.RbLeidosSI.Text = "Leidos"
        Me.RbLeidosSI.UseVisualStyleBackColor = True
        '
        'RbLeidosTodos
        '
        Me.RbLeidosTodos.AutoSize = True
        Me.RbLeidosTodos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLeidosTodos.Location = New System.Drawing.Point(9, 9)
        Me.RbLeidosTodos.Name = "RbLeidosTodos"
        Me.RbLeidosTodos.Size = New System.Drawing.Size(80, 22)
        Me.RbLeidosTodos.TabIndex = 0
        Me.RbLeidosTodos.Text = "Todos"
        Me.RbLeidosTodos.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RbRecibidos)
        Me.Panel5.Controls.Add(Me.RbEnviados)
        Me.Panel5.Controls.Add(Me.RbTodos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(320, 42)
        Me.Panel5.TabIndex = 100316
        '
        'RbRecibidos
        '
        Me.RbRecibidos.AutoSize = True
        Me.RbRecibidos.Checked = True
        Me.RbRecibidos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbRecibidos.Location = New System.Drawing.Point(206, 9)
        Me.RbRecibidos.Name = "RbRecibidos"
        Me.RbRecibidos.Size = New System.Drawing.Size(109, 22)
        Me.RbRecibidos.TabIndex = 2
        Me.RbRecibidos.TabStop = True
        Me.RbRecibidos.Text = "Recibidos"
        Me.RbRecibidos.UseVisualStyleBackColor = True
        '
        'RbEnviados
        '
        Me.RbEnviados.AutoSize = True
        Me.RbEnviados.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnviados.Location = New System.Drawing.Point(96, 9)
        Me.RbEnviados.Name = "RbEnviados"
        Me.RbEnviados.Size = New System.Drawing.Size(104, 22)
        Me.RbEnviados.TabIndex = 1
        Me.RbEnviados.Text = "Enviados"
        Me.RbEnviados.UseVisualStyleBackColor = True
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.Location = New System.Drawing.Point(10, 9)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(80, 22)
        Me.RbTodos.TabIndex = 0
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'dOpenFileBuzon
        '
        Me.dOpenFileBuzon.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lb18)
        Me.Panel2.Controls.Add(Me.ChUsuarios)
        Me.Panel2.Controls.Add(Me.Lb16)
        Me.Panel2.Controls.Add(Me.ChGrupos)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ClButton1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxMensaje)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(971, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 378)
        Me.Panel2.TabIndex = 900005
        '
        'Lb18
        '
        Me.Lb18.AutoSize = True
        Me.Lb18.CL_ControlAsociado = Nothing
        Me.Lb18.CL_ValorFijo = True
        Me.Lb18.ClForm = Nothing
        Me.Lb18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb18.ForeColor = System.Drawing.Color.Teal
        Me.Lb18.Location = New System.Drawing.Point(144, 86)
        Me.Lb18.Name = "Lb18"
        Me.Lb18.Size = New System.Drawing.Size(84, 18)
        Me.Lb18.TabIndex = 100322
        Me.Lb18.Text = "Usuarios"
        '
        'ChUsuarios
        '
        Me.ChUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChUsuarios.Location = New System.Drawing.Point(147, 107)
        Me.ChUsuarios.Name = "ChUsuarios"
        Me.ChUsuarios.Size = New System.Drawing.Size(187, 231)
        Me.ChUsuarios.TabIndex = 100321
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(6, 86)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(71, 18)
        Me.Lb16.TabIndex = 100320
        Me.Lb16.Text = "Grupos"
        '
        'ChGrupos
        '
        Me.ChGrupos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChGrupos.Location = New System.Drawing.Point(9, 107)
        Me.ChGrupos.Name = "ChGrupos"
        Me.ChGrupos.Size = New System.Drawing.Size(132, 231)
        Me.ChGrupos.TabIndex = 100319
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 20)
        Me.Label1.TabIndex = 100318
        Me.Label1.Text = "PARA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClButton1
        '
        Me.ClButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClButton1.Image = CType(resources.GetObject("ClButton1.Image"), System.Drawing.Image)
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClButton1.Location = New System.Drawing.Point(0, 344)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(337, 34)
        Me.ClButton1.TabIndex = 100317
        Me.ClButton1.Text = "Enviar mensajes"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 100316
        Me.Label2.Text = "Nuevo mensaje"
        '
        'TxMensaje
        '
        Me.TxMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxMensaje.Location = New System.Drawing.Point(6, 24)
        Me.TxMensaje.MaxLength = 200
        Me.TxMensaje.Name = "TxMensaje"
        Me.TxMensaje.Size = New System.Drawing.Size(328, 22)
        Me.TxMensaje.TabIndex = 100315
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 16)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(971, 378)
        Me.Grid.TabIndex = 900006
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
        'ClButton2
        '
        Me.ClButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClButton2.Image = CType(resources.GetObject("ClButton2.Image"), System.Drawing.Image)
        Me.ClButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClButton2.Location = New System.Drawing.Point(889, 0)
        Me.ClButton2.Name = "ClButton2"
        Me.ClButton2.Orden = 0
        Me.ClButton2.PedirClave = True
        Me.ClButton2.Size = New System.Drawing.Size(82, 42)
        Me.ClButton2.TabIndex = 100318
        Me.ClButton2.Text = "Actualizar"
        Me.ClButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClButton2.UseVisualStyleBackColor = True
        '
        'FrMMensajesEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 470)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrMMensajesEntidad"
        Me.Text = "Mensajes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ChUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bsalir As NetAgro.ClButton
    Protected WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNIF As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Lb4 As NetAgro.Lb
    Protected WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents dOpenFileBuzon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents RbLeidosNO As System.Windows.Forms.RadioButton
    Friend WithEvents RbLeidosSI As System.Windows.Forms.RadioButton
    Friend WithEvents RbLeidosTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RbRecibidos As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnviados As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Lb18 As NetAgro.Lb
    Friend WithEvents ChUsuarios As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents ChGrupos As DevExpress.XtraEditors.CheckedListBoxControl
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ClButton2 As NetAgro.ClButton
End Class
