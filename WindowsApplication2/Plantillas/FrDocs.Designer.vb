<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDocs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrDocs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClButton2 = New NetAgro.ClButton()
        Me.LbFechaHora = New System.Windows.Forms.Label()
        Me.BPrevisualizar = New NetAgro.ClButton()
        Me.BAñadir = New NetAgro.ClButton()
        Me.BAnular = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbidEntidad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbentidad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbBasedatos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btCambiarTipoDoc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxDato_2 = New System.Windows.Forms.TextBox()
        Me.dOpenFileBuzon = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSeleccionarEscaner = New System.Windows.Forms.Button()
        Me.btCapturar = New System.Windows.Forms.Button()
        Me.Lbbuzon = New System.Windows.Forms.Label()
        Me.RbMiequipo = New System.Windows.Forms.RadioButton()
        Me.RbBuzon = New System.Windows.Forms.RadioButton()
        Me.RbScaner = New System.Windows.Forms.RadioButton()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbCargando = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClButton2)
        Me.Panel1.Controls.Add(Me.LbFechaHora)
        Me.Panel1.Controls.Add(Me.BPrevisualizar)
        Me.Panel1.Controls.Add(Me.BAñadir)
        Me.Panel1.Controls.Add(Me.BAnular)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 572)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 34)
        Me.Panel1.TabIndex = 3
        '
        'ClButton2
        '
        Me.ClButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClButton2.Image = CType(resources.GetObject("ClButton2.Image"), System.Drawing.Image)
        Me.ClButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClButton2.Location = New System.Drawing.Point(684, 0)
        Me.ClButton2.Name = "ClButton2"
        Me.ClButton2.Orden = 0
        Me.ClButton2.PedirClave = True
        Me.ClButton2.Size = New System.Drawing.Size(109, 34)
        Me.ClButton2.TabIndex = 100313
        Me.ClButton2.Text = "Añadir nuevo"
        Me.ClButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClButton2.UseVisualStyleBackColor = True
        '
        'LbFechaHora
        '
        Me.LbFechaHora.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbFechaHora.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaHora.Location = New System.Drawing.Point(232, 7)
        Me.LbFechaHora.Name = "LbFechaHora"
        Me.LbFechaHora.Size = New System.Drawing.Size(236, 18)
        Me.LbFechaHora.TabIndex = 100311
        Me.LbFechaHora.Visible = False
        '
        'BPrevisualizar
        '
        Me.BPrevisualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPrevisualizar.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.BPrevisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPrevisualizar.Location = New System.Drawing.Point(793, 0)
        Me.BPrevisualizar.Name = "BPrevisualizar"
        Me.BPrevisualizar.Orden = 0
        Me.BPrevisualizar.PedirClave = True
        Me.BPrevisualizar.Size = New System.Drawing.Size(109, 34)
        Me.BPrevisualizar.TabIndex = 100310
        Me.BPrevisualizar.Text = "Buscar"
        Me.BPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BPrevisualizar.UseVisualStyleBackColor = True
        '
        'BAñadir
        '
        Me.BAñadir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAñadir.Image = CType(resources.GetObject("BAñadir.Image"), System.Drawing.Image)
        Me.BAñadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAñadir.Location = New System.Drawing.Point(902, 0)
        Me.BAñadir.Name = "BAñadir"
        Me.BAñadir.Orden = 0
        Me.BAñadir.PedirClave = True
        Me.BAñadir.Size = New System.Drawing.Size(109, 34)
        Me.BAñadir.TabIndex = 100309
        Me.BAñadir.Text = "Subir a Bd"
        Me.BAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAñadir.UseVisualStyleBackColor = True
        '
        'BAnular
        '
        Me.BAnular.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAnular.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.BAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAnular.Location = New System.Drawing.Point(1011, 0)
        Me.BAnular.Name = "BAnular"
        Me.BAnular.Orden = 0
        Me.BAnular.PedirClave = True
        Me.BAnular.Size = New System.Drawing.Size(109, 34)
        Me.BAnular.TabIndex = 99
        Me.BAnular.Text = "Eliminar"
        Me.BAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnular.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1120, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(82, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Location = New System.Drawing.Point(440, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 481)
        Me.Panel2.TabIndex = 4
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(753, 477)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbidEntidad)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Lbentidad)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LbBasedatos)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1202, 38)
        Me.Panel3.TabIndex = 10
        '
        'LbidEntidad
        '
        Me.LbidEntidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbidEntidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbidEntidad.Location = New System.Drawing.Point(729, 7)
        Me.LbidEntidad.Name = "LbidEntidad"
        Me.LbidEntidad.Size = New System.Drawing.Size(130, 18)
        Me.LbidEntidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(687, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Id"
        '
        'Lbentidad
        '
        Me.Lbentidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbentidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbentidad.Location = New System.Drawing.Point(413, 9)
        Me.Lbentidad.Name = "Lbentidad"
        Me.Lbentidad.Size = New System.Drawing.Size(244, 16)
        Me.Lbentidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Entidad"
        '
        'LbBasedatos
        '
        Me.LbBasedatos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbBasedatos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBasedatos.Location = New System.Drawing.Point(145, 9)
        Me.LbBasedatos.Name = "LbBasedatos"
        Me.LbBasedatos.Size = New System.Drawing.Size(184, 16)
        Me.LbBasedatos.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Base de datos"
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btCambiarTipoDoc)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TxTipoDoc)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 534)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1202, 38)
        Me.Panel4.TabIndex = 900003
        '
        'btCambiarTipoDoc
        '
        Me.btCambiarTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCambiarTipoDoc.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.btCambiarTipoDoc.Location = New System.Drawing.Point(513, 10)
        Me.btCambiarTipoDoc.Name = "btCambiarTipoDoc"
        Me.btCambiarTipoDoc.Size = New System.Drawing.Size(25, 23)
        Me.btCambiarTipoDoc.TabIndex = 100317
        Me.btCambiarTipoDoc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 100316
        Me.Label4.Text = "Tipo documento"
        '
        'TxTipoDoc
        '
        Me.TxTipoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxTipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxTipoDoc.Location = New System.Drawing.Point(142, 10)
        Me.TxTipoDoc.MaxLength = 50
        Me.TxTipoDoc.Name = "TxTipoDoc"
        Me.TxTipoDoc.Size = New System.Drawing.Size(367, 22)
        Me.TxTipoDoc.TabIndex = 100315
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 100314
        Me.Label2.Text = "Descripción"
        '
        'TxDato_2
        '
        Me.TxDato_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato_2.Location = New System.Drawing.Point(666, 11)
        Me.TxDato_2.MaxLength = 200
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Size = New System.Drawing.Size(510, 22)
        Me.TxDato_2.TabIndex = 100313
        '
        'dOpenFileBuzon
        '
        Me.dOpenFileBuzon.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btSeleccionarEscaner)
        Me.GroupBox1.Controls.Add(Me.btCapturar)
        Me.GroupBox1.Controls.Add(Me.Lbbuzon)
        Me.GroupBox1.Controls.Add(Me.RbMiequipo)
        Me.GroupBox1.Controls.Add(Me.RbBuzon)
        Me.GroupBox1.Controls.Add(Me.RbScaner)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 211)
        Me.GroupBox1.TabIndex = 100314
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar en ...."
        '
        'btSeleccionarEscaner
        '
        Me.btSeleccionarEscaner.Enabled = False
        Me.btSeleccionarEscaner.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarEscaner.Location = New System.Drawing.Point(302, 38)
        Me.btSeleccionarEscaner.Name = "btSeleccionarEscaner"
        Me.btSeleccionarEscaner.Size = New System.Drawing.Size(96, 40)
        Me.btSeleccionarEscaner.TabIndex = 5
        Me.btSeleccionarEscaner.Text = "Seleccionar escaner"
        Me.btSeleccionarEscaner.UseVisualStyleBackColor = True
        '
        'btCapturar
        '
        Me.btCapturar.Enabled = False
        Me.btCapturar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapturar.Location = New System.Drawing.Point(200, 38)
        Me.btCapturar.Name = "btCapturar"
        Me.btCapturar.Size = New System.Drawing.Size(96, 40)
        Me.btCapturar.TabIndex = 4
        Me.btCapturar.Text = "Capturar"
        Me.btCapturar.UseVisualStyleBackColor = True
        '
        'Lbbuzon
        '
        Me.Lbbuzon.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbbuzon.Location = New System.Drawing.Point(81, 115)
        Me.Lbbuzon.Name = "Lbbuzon"
        Me.Lbbuzon.Size = New System.Drawing.Size(341, 23)
        Me.Lbbuzon.TabIndex = 3
        '
        'RbMiequipo
        '
        Me.RbMiequipo.Image = CType(resources.GetObject("RbMiequipo.Image"), System.Drawing.Image)
        Me.RbMiequipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbMiequipo.Location = New System.Drawing.Point(9, 141)
        Me.RbMiequipo.Name = "RbMiequipo"
        Me.RbMiequipo.Size = New System.Drawing.Size(187, 40)
        Me.RbMiequipo.TabIndex = 2
        Me.RbMiequipo.Text = "Mi equipo"
        Me.RbMiequipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbMiequipo.UseVisualStyleBackColor = True
        '
        'RbBuzon
        '
        Me.RbBuzon.Checked = True
        Me.RbBuzon.Image = CType(resources.GetObject("RbBuzon.Image"), System.Drawing.Image)
        Me.RbBuzon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbBuzon.Location = New System.Drawing.Point(9, 84)
        Me.RbBuzon.Name = "RbBuzon"
        Me.RbBuzon.Size = New System.Drawing.Size(238, 40)
        Me.RbBuzon.TabIndex = 1
        Me.RbBuzon.TabStop = True
        Me.RbBuzon.Text = "Buzon entrada"
        Me.RbBuzon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbBuzon.UseVisualStyleBackColor = True
        '
        'RbScaner
        '
        Me.RbScaner.Image = CType(resources.GetObject("RbScaner.Image"), System.Drawing.Image)
        Me.RbScaner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbScaner.Location = New System.Drawing.Point(9, 30)
        Me.RbScaner.Name = "RbScaner"
        Me.RbScaner.Size = New System.Drawing.Size(154, 57)
        Me.RbScaner.TabIndex = 0
        Me.RbScaner.Text = "Scaner"
        Me.RbScaner.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbScaner.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(6, 44)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(430, 248)
        Me.Grid.TabIndex = 900004
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
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
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LbCargando
        '
        Me.LbCargando.BackColor = System.Drawing.Color.Firebrick
        Me.LbCargando.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCargando.ForeColor = System.Drawing.Color.White
        Me.LbCargando.Location = New System.Drawing.Point(220, 297)
        Me.LbCargando.Name = "LbCargando"
        Me.LbCargando.Size = New System.Drawing.Size(212, 23)
        Me.LbCargando.TabIndex = 900005
        Me.LbCargando.Text = "CARGANDO DOCUMENTOS"
        Me.LbCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 606)
        Me.Controls.Add(Me.LbCargando)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrDocs"
        Me.Text = "Visualizador documentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BAnular As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Protected WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNIF As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents BAñadir As NetAgro.ClButton
    Friend WithEvents BPrevisualizar As NetAgro.ClButton
    Protected WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbidEntidad As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbentidad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbBasedatos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxDato_2 As System.Windows.Forms.TextBox
    Friend WithEvents LbFechaHora As System.Windows.Forms.Label
    Friend WithEvents dOpenFileBuzon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ClButton2 As NetAgro.ClButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbMiequipo As System.Windows.Forms.RadioButton
    Friend WithEvents RbBuzon As System.Windows.Forms.RadioButton
    Friend WithEvents RbScaner As System.Windows.Forms.RadioButton
    Friend WithEvents Lbbuzon As System.Windows.Forms.Label
    Friend WithEvents btCapturar As System.Windows.Forms.Button
    Friend WithEvents btSeleccionarEscaner As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents btCambiarTipoDoc As System.Windows.Forms.Button
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbCargando As System.Windows.Forms.Label
End Class
