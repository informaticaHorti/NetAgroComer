<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrazaSalida
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
        Me.LbCodCliente = New NetAgro.Lb(Me.components)
        Me.LbFechaSalida = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.LbNombreCliente = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.PanelPalets = New System.Windows.Forms.Panel()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.GridPalets = New DevExpress.XtraGrid.GridControl()
        Me.GridPaletsView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.GridPreca = New DevExpress.XtraGrid.GridControl()
        Me.GridPrecaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.GridLotes = New DevExpress.XtraGrid.GridControl()
        Me.GridlotesView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelPalets.SuspendLayout()
        CType(Me.GridPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPaletsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GridPreca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPrecaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridlotesView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Panel4)
        Me.PanelCabecera.Controls.Add(Me.Panel5)
        Me.PanelCabecera.Controls.Add(Me.PanelPalets)
        Me.PanelCabecera.Controls.Add(Me.LbCodCliente)
        Me.PanelCabecera.Controls.Add(Me.LbFechaSalida)
        Me.PanelCabecera.Controls.Add(Me.LbKilos)
        Me.PanelCabecera.Controls.Add(Me.LbNombreCliente)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1240, 251)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 281)
        Me.PanelConsulta.Size = New System.Drawing.Size(1240, 163)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(940, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1015, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1090, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1165, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(865, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbCodCliente
        '
        Me.LbCodCliente.BackColor = System.Drawing.Color.White
        Me.LbCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCodCliente.CL_ControlAsociado = Nothing
        Me.LbCodCliente.CL_ValorFijo = False
        Me.LbCodCliente.ClForm = Nothing
        Me.LbCodCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodCliente.ForeColor = System.Drawing.Color.Black
        Me.LbCodCliente.Location = New System.Drawing.Point(322, 6)
        Me.LbCodCliente.Name = "LbCodCliente"
        Me.LbCodCliente.Size = New System.Drawing.Size(63, 22)
        Me.LbCodCliente.TabIndex = 126
        Me.LbCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbFechaSalida
        '
        Me.LbFechaSalida.BackColor = System.Drawing.Color.White
        Me.LbFechaSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFechaSalida.CL_ControlAsociado = Nothing
        Me.LbFechaSalida.CL_ValorFijo = False
        Me.LbFechaSalida.ClForm = Nothing
        Me.LbFechaSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaSalida.ForeColor = System.Drawing.Color.Black
        Me.LbFechaSalida.Location = New System.Drawing.Point(323, 36)
        Me.LbFechaSalida.Name = "LbFechaSalida"
        Me.LbFechaSalida.Size = New System.Drawing.Size(102, 21)
        Me.LbFechaSalida.TabIndex = 125
        Me.LbFechaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LbKilos.Location = New System.Drawing.Point(78, 35)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(112, 22)
        Me.LbKilos.TabIndex = 124
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbNombreCliente
        '
        Me.LbNombreCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreCliente.CL_ControlAsociado = Nothing
        Me.LbNombreCliente.CL_ValorFijo = False
        Me.LbNombreCliente.ClForm = Nothing
        Me.LbNombreCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreCliente.Location = New System.Drawing.Point(391, 6)
        Me.LbNombreCliente.Name = "LbNombreCliente"
        Me.LbNombreCliente.Size = New System.Drawing.Size(536, 23)
        Me.LbNombreCliente.TabIndex = 121
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 38)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(42, 16)
        Me.Lb3.TabIndex = 122
        Me.Lb3.Text = "Kilos"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(64, 16)
        Me.Lb1.TabIndex = 118
        Me.Lb1.Text = "Albarán"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(78, 6)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(112, 22)
        Me.TxDato1.TabIndex = 119
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(204, 38)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(99, 16)
        Me.Lb4.TabIndex = 123
        Me.Lb4.Text = "Fecha salida"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(204, 9)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(59, 16)
        Me.Lb2.TabIndex = 120
        Me.Lb2.Text = "Cliente"
        '
        'PanelPalets
        '
        Me.PanelPalets.Controls.Add(Me.Lb6)
        Me.PanelPalets.Controls.Add(Me.GridPalets)
        Me.PanelPalets.Location = New System.Drawing.Point(3, 70)
        Me.PanelPalets.Name = "PanelPalets"
        Me.PanelPalets.Size = New System.Drawing.Size(453, 168)
        Me.PanelPalets.TabIndex = 127
        '
        'Lb6
        '
        Me.Lb6.BackColor = System.Drawing.Color.PaleGreen
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(0, 0)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(453, 22)
        Me.Lb6.TabIndex = 83
        Me.Lb6.Text = "PALETS"
        Me.Lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridPalets
        '
        Me.GridPalets.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPalets.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridPalets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPalets.Location = New System.Drawing.Point(0, 25)
        Me.GridPalets.LookAndFeel.SkinName = "Black"
        Me.GridPalets.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPalets.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPalets.MainView = Me.GridPaletsView
        Me.GridPalets.Name = "GridPalets"
        Me.GridPalets.Size = New System.Drawing.Size(453, 143)
        Me.GridPalets.TabIndex = 15
        Me.GridPalets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPaletsView})
        '
        'GridPaletsView
        '
        Me.GridPaletsView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPaletsView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridPaletsView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridPaletsView.Appearance.Empty.Options.UseBackColor = True
        Me.GridPaletsView.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridPaletsView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPaletsView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridPaletsView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridPaletsView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridPaletsView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridPaletsView.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridPaletsView.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPaletsView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridPaletsView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridPaletsView.Appearance.GroupFooter.Options.UseFont = True
        Me.GridPaletsView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridPaletsView.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPaletsView.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridPaletsView.Appearance.Row.Options.UseFont = True
        Me.GridPaletsView.Appearance.Row.Options.UseForeColor = True
        Me.GridPaletsView.GridControl = Me.GridPalets
        Me.GridPaletsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridPaletsView.Name = "GridPaletsView"
        Me.GridPaletsView.OptionsView.AutoCalcPreviewLineCount = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Lb7)
        Me.Panel5.Controls.Add(Me.GridPreca)
        Me.Panel5.Location = New System.Drawing.Point(462, 70)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(382, 168)
        Me.Panel5.TabIndex = 128
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
        Me.Lb7.Size = New System.Drawing.Size(382, 22)
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
        Me.GridPreca.Size = New System.Drawing.Size(382, 143)
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Lb5)
        Me.Panel4.Controls.Add(Me.GridLotes)
        Me.Panel4.Location = New System.Drawing.Point(850, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(378, 168)
        Me.Panel4.TabIndex = 129
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
        Me.Lb5.Size = New System.Drawing.Size(378, 22)
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
        Me.GridLotes.Size = New System.Drawing.Size(378, 143)
        Me.GridLotes.TabIndex = 15
        Me.GridLotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridlotesView, Me.GridView2})
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridLotes
        Me.GridView2.Name = "GridView2"
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
        Me.Lb8.Location = New System.Drawing.Point(0, 251)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(1240, 25)
        Me.Lb8.TabIndex = 86
        Me.Lb8.Text = "PARTIDAS"
        Me.Lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmTrazaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 478)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmTrazaSalida"
        Me.Text = "Trazabilidad albarán"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelPalets.ResumeLayout(False)
        CType(Me.GridPalets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPaletsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridPreca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPrecaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridlotesView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbCodCliente As NetAgro.Lb
    Friend WithEvents LbFechaSalida As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbNombreCliente As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents PanelPalets As System.Windows.Forms.Panel
    Friend WithEvents Lb6 As NetAgro.Lb
    Public WithEvents GridPalets As DevExpress.XtraGrid.GridControl
    Public WithEvents GridPaletsView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Lb7 As NetAgro.Lb
    Public WithEvents GridPreca As DevExpress.XtraGrid.GridControl
    Public WithEvents GridPrecaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lb5 As NetAgro.Lb
    Public WithEvents GridLotes As DevExpress.XtraGrid.GridControl
    Public WithEvents GridlotesView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb8 As NetAgro.Lb
End Class
