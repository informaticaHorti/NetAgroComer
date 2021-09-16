<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaTrazabilidad

    Inherits NetAgro.FrConsulta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaTrazabilidad))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbNombreAgricultor = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.LbFechaEntrada = New NetAgro.Lb(Me.components)
        Me.LbCodAgricultor = New NetAgro.Lb(Me.components)
        Me.LbAlbCompra = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.GridLotes = New DevExpress.XtraGrid.GridControl()
        Me.GridlotesView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.GridPreca = New DevExpress.XtraGrid.GridControl()
        Me.GridPrecaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbProducto = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridlotesView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GridPreca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPrecaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbProducto)
        Me.PanelCabecera.Controls.Add(Me.Lb12)
        Me.PanelCabecera.Controls.Add(Me.LbBultos)
        Me.PanelCabecera.Controls.Add(Me.Lb11)
        Me.PanelCabecera.Controls.Add(Me.Button2)
        Me.PanelCabecera.Controls.Add(Me.Panel5)
        Me.PanelCabecera.Controls.Add(Me.Panel4)
        Me.PanelCabecera.Controls.Add(Me.LbAlbCompra)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.LbCodAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbFechaEntrada)
        Me.PanelCabecera.Controls.Add(Me.LbKilos)
        Me.PanelCabecera.Controls.Add(Me.LbNombreAgricultor)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1016, 277)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 305)
        Me.PanelConsulta.Size = New System.Drawing.Size(1016, 217)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(716, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(791, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(866, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(941, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(641, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(79, 8)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(112, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 11)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(60, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Partida"
        '
        'LbNombreAgricultor
        '
        Me.LbNombreAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreAgricultor.CL_ControlAsociado = Nothing
        Me.LbNombreAgricultor.CL_ValorFijo = False
        Me.LbNombreAgricultor.ClForm = Nothing
        Me.LbNombreAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreAgricultor.Location = New System.Drawing.Point(392, 8)
        Me.LbNombreAgricultor.Name = "LbNombreAgricultor"
        Me.LbNombreAgricultor.Size = New System.Drawing.Size(536, 23)
        Me.LbNombreAgricultor.TabIndex = 79
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(239, 11)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(79, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Agricultor"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(205, 40)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(113, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Fecha entrada"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(13, 40)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(42, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Kilos"
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.Color.White
        Me.LbKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Black
        Me.LbKilos.Location = New System.Drawing.Point(79, 37)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(112, 22)
        Me.LbKilos.TabIndex = 115
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbFechaEntrada
        '
        Me.LbFechaEntrada.BackColor = System.Drawing.Color.White
        Me.LbFechaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFechaEntrada.CL_ControlAsociado = Nothing
        Me.LbFechaEntrada.CL_ValorFijo = False
        Me.LbFechaEntrada.ClForm = Nothing
        Me.LbFechaEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaEntrada.ForeColor = System.Drawing.Color.Black
        Me.LbFechaEntrada.Location = New System.Drawing.Point(324, 38)
        Me.LbFechaEntrada.Name = "LbFechaEntrada"
        Me.LbFechaEntrada.Size = New System.Drawing.Size(102, 21)
        Me.LbFechaEntrada.TabIndex = 116
        Me.LbFechaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCodAgricultor
        '
        Me.LbCodAgricultor.BackColor = System.Drawing.Color.White
        Me.LbCodAgricultor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCodAgricultor.CL_ControlAsociado = Nothing
        Me.LbCodAgricultor.CL_ValorFijo = False
        Me.LbCodAgricultor.ClForm = Nothing
        Me.LbCodAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodAgricultor.ForeColor = System.Drawing.Color.Black
        Me.LbCodAgricultor.Location = New System.Drawing.Point(323, 8)
        Me.LbCodAgricultor.Name = "LbCodAgricultor"
        Me.LbCodAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.LbCodAgricultor.TabIndex = 117
        Me.LbCodAgricultor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbAlbCompra
        '
        Me.LbAlbCompra.BackColor = System.Drawing.Color.White
        Me.LbAlbCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAlbCompra.CL_ControlAsociado = Nothing
        Me.LbAlbCompra.CL_ValorFijo = False
        Me.LbAlbCompra.ClForm = Nothing
        Me.LbAlbCompra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbCompra.ForeColor = System.Drawing.Color.Black
        Me.LbAlbCompra.Location = New System.Drawing.Point(578, 38)
        Me.LbAlbCompra.Name = "LbAlbCompra"
        Me.LbAlbCompra.Size = New System.Drawing.Size(102, 21)
        Me.LbAlbCompra.TabIndex = 119
        Me.LbAlbCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(475, 40)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(97, 16)
        Me.Lb6.TabIndex = 118
        Me.Lb6.Text = "Alb. Compra"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Lb5)
        Me.Panel4.Controls.Add(Me.GridLotes)
        Me.Panel4.Location = New System.Drawing.Point(3, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(501, 168)
        Me.Panel4.TabIndex = 120
        '
        'Lb5
        '
        Me.Lb5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(0, 0)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(501, 22)
        Me.Lb5.TabIndex = 83
        Me.Lb5.Text = "LOTES ENTRADA"
        Me.Lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLotes
        '
        Me.GridLotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridLotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridLotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLotes.Location = New System.Drawing.Point(0, 25)
        Me.GridLotes.LookAndFeel.SkinName = "Black"
        Me.GridLotes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridLotes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridLotes.MainView = Me.GridlotesView
        Me.GridLotes.Name = "GridLotes"
        Me.GridLotes.Size = New System.Drawing.Size(501, 143)
        Me.GridLotes.TabIndex = 15
        Me.GridLotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridlotesView})
        '
        'GridlotesView
        '
        Me.GridlotesView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridlotesView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridlotesView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridlotesView.Appearance.Empty.Options.UseBackColor = True
        Me.GridlotesView.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridlotesView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridlotesView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridlotesView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridlotesView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridlotesView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridlotesView.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridlotesView.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridlotesView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridlotesView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridlotesView.Appearance.GroupFooter.Options.UseFont = True
        Me.GridlotesView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridlotesView.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridlotesView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridlotesView.Appearance.Row.Options.UseFont = True
        Me.GridlotesView.Appearance.Row.Options.UseForeColor = True
        Me.GridlotesView.GridControl = Me.GridLotes
        Me.GridlotesView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridlotesView.Name = "GridlotesView"
        Me.GridlotesView.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Lb7)
        Me.Panel5.Controls.Add(Me.GridPreca)
        Me.Panel5.Location = New System.Drawing.Point(509, 106)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(501, 168)
        Me.Panel5.TabIndex = 121
        '
        'Lb7
        '
        Me.Lb7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(0, 0)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(501, 22)
        Me.Lb7.TabIndex = 83
        Me.Lb7.Text = "PRECALIBRADO"
        Me.Lb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridPreca
        '
        Me.GridPreca.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPreca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridPreca.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPreca.Location = New System.Drawing.Point(0, 25)
        Me.GridPreca.LookAndFeel.SkinName = "Black"
        Me.GridPreca.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPreca.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPreca.MainView = Me.GridPrecaView
        Me.GridPreca.Name = "GridPreca"
        Me.GridPreca.Size = New System.Drawing.Size(501, 143)
        Me.GridPreca.TabIndex = 15
        Me.GridPreca.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPrecaView})
        '
        'GridPrecaView
        '
        Me.GridPrecaView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPrecaView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridPrecaView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridPrecaView.Appearance.Empty.Options.UseBackColor = True
        Me.GridPrecaView.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridPrecaView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPrecaView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridPrecaView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridPrecaView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridPrecaView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridPrecaView.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridPrecaView.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPrecaView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridPrecaView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridPrecaView.Appearance.GroupFooter.Options.UseFont = True
        Me.GridPrecaView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridPrecaView.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPrecaView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridPrecaView.Appearance.Row.Options.UseFont = True
        Me.GridPrecaView.Appearance.Row.Options.UseForeColor = True
        Me.GridPrecaView.GridControl = Me.GridPreca
        Me.GridPrecaView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridPrecaView.Name = "GridPrecaView"
        Me.GridPrecaView.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Lb8
        '
        Me.Lb8.BackColor = System.Drawing.Color.SpringGreen
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(0, 277)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(1016, 25)
        Me.Lb8.TabIndex = 84
        Me.Lb8.Text = "PALETS"
        Me.Lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(862, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 23)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Ver clasificacion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbBultos
        '
        Me.LbBultos.BackColor = System.Drawing.Color.White
        Me.LbBultos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = False
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.Black
        Me.LbBultos.Location = New System.Drawing.Point(79, 68)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(112, 22)
        Me.LbBultos.TabIndex = 127
        Me.LbBultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(13, 71)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(54, 16)
        Me.Lb11.TabIndex = 126
        Me.Lb11.Text = "Bultos"
        '
        'LbProducto
        '
        Me.LbProducto.BackColor = System.Drawing.Color.White
        Me.LbProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbProducto.CL_ControlAsociado = Nothing
        Me.LbProducto.CL_ValorFijo = False
        Me.LbProducto.ClForm = Nothing
        Me.LbProducto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProducto.ForeColor = System.Drawing.Color.Black
        Me.LbProducto.Location = New System.Drawing.Point(323, 71)
        Me.LbProducto.Name = "LbProducto"
        Me.LbProducto.Size = New System.Drawing.Size(491, 22)
        Me.LbProducto.TabIndex = 129
        Me.LbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(205, 74)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(73, 16)
        Me.Lb12.TabIndex = 128
        Me.Lb12.Text = "Producto"
        '
        'FrmConsultaTrazabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 562)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaTrazabilidad"
        Me.Text = "Consulta Trazabilidad"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridlotesView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridPreca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPrecaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbNombreAgricultor As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbCodAgricultor As NetAgro.Lb
    Friend WithEvents LbFechaEntrada As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbAlbCompra As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Lb7 As NetAgro.Lb
    Public WithEvents GridPreca As DevExpress.XtraGrid.GridControl
    Public WithEvents GridPrecaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb5 As NetAgro.Lb
    Public WithEvents GridLotes As DevExpress.XtraGrid.GridControl
    Public WithEvents GridlotesView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LbProducto As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
End Class
