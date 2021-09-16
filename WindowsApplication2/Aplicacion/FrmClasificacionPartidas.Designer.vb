<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClasificacionPartidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClasificacionPartidas))
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbPartida = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbKilosEntrada = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.GridConfeccion = New DevExpress.XtraGrid.GridControl()
        Me.GridViewConfeccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.GridEditable1 = New NetAgro.GridEditable()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.BtPasarClasificacion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BPreliminar = New NetAgro.ClButton()
        Me.BImpDirecta = New NetAgro.ClButton()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.TxObservaciones = New NetAgro.TxDato(Me.components)
        Me.LbObservaciones = New NetAgro.Lb(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.prtSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.TxObsProveedor = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.LbCultivo = New NetAgro.Lb(Me.components)
        Me.GridHistorial = New DevExpress.XtraGrid.GridControl()
        Me.GridViewHistorial = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btDocumental = New System.Windows.Forms.Button()
        CType(Me.GridConfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewConfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(16, 12)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(60, 16)
        Me.Lb4.TabIndex = 190
        Me.Lb4.Text = "Partida"
        '
        'LbPartida
        '
        Me.LbPartida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPartida.CL_ControlAsociado = Nothing
        Me.LbPartida.CL_ValorFijo = False
        Me.LbPartida.ClForm = Nothing
        Me.LbPartida.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPartida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPartida.Location = New System.Drawing.Point(101, 9)
        Me.LbPartida.Name = "LbPartida"
        Me.LbPartida.Size = New System.Drawing.Size(120, 23)
        Me.LbPartida.TabIndex = 189
        Me.LbPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(16, 42)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(79, 16)
        Me.Lb1.TabIndex = 192
        Me.Lb1.Text = "Agricultor"
        '
        'LbAgricultor
        '
        Me.LbAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbAgricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAgricultor.Location = New System.Drawing.Point(101, 39)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(380, 23)
        Me.LbAgricultor.TabIndex = 191
        Me.LbAgricultor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(16, 102)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(75, 16)
        Me.Lb3.TabIndex = 194
        Me.Lb3.Text = "Kilos Ent."
        '
        'LbKilosEntrada
        '
        Me.LbKilosEntrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilosEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKilosEntrada.CL_ControlAsociado = Nothing
        Me.LbKilosEntrada.CL_ValorFijo = False
        Me.LbKilosEntrada.ClForm = Nothing
        Me.LbKilosEntrada.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilosEntrada.Location = New System.Drawing.Point(101, 99)
        Me.LbKilosEntrada.Name = "LbKilosEntrada"
        Me.LbKilosEntrada.Size = New System.Drawing.Size(120, 23)
        Me.LbKilosEntrada.TabIndex = 193
        Me.LbKilosEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(16, 72)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(60, 16)
        Me.Lb6.TabIndex = 196
        Me.Lb6.Text = "Género"
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = False
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbGenero.Location = New System.Drawing.Point(101, 69)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(380, 23)
        Me.LbGenero.TabIndex = 195
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridConfeccion
        '
        Me.GridConfeccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridConfeccion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridConfeccion.Location = New System.Drawing.Point(12, 163)
        Me.GridConfeccion.LookAndFeel.SkinName = "Black"
        Me.GridConfeccion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridConfeccion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridConfeccion.MainView = Me.GridViewConfeccion
        Me.GridConfeccion.Name = "GridConfeccion"
        Me.GridConfeccion.Size = New System.Drawing.Size(400, 222)
        Me.GridConfeccion.TabIndex = 197
        Me.GridConfeccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewConfeccion})
        '
        'GridViewConfeccion
        '
        Me.GridViewConfeccion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewConfeccion.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewConfeccion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewConfeccion.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewConfeccion.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewConfeccion.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewConfeccion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewConfeccion.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewConfeccion.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewConfeccion.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewConfeccion.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewConfeccion.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewConfeccion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewConfeccion.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewConfeccion.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewConfeccion.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewConfeccion.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewConfeccion.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewConfeccion.Appearance.Row.Options.UseFont = True
        Me.GridViewConfeccion.Appearance.Row.Options.UseForeColor = True
        Me.GridViewConfeccion.GridControl = Me.GridConfeccion
        Me.GridViewConfeccion.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewConfeccion.Name = "GridViewConfeccion"
        Me.GridViewConfeccion.OptionsBehavior.Editable = False
        Me.GridViewConfeccion.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewConfeccion.OptionsView.ShowGroupPanel = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Blue
        Me.Lb2.Location = New System.Drawing.Point(17, 142)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(296, 18)
        Me.Lb2.TabIndex = 198
        Me.Lb2.Text = "CLASIFICACIÓN S/CONFECCIÓN"
        '
        'GridEditable1
        '
        Me.GridEditable1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEditable1.DataSource = Nothing
        Me.GridEditable1.Location = New System.Drawing.Point(501, 33)
        Me.GridEditable1.Name = "GridEditable1"
        Me.GridEditable1.NavegarSoloEditables = False
        Me.GridEditable1.Orden = -1
        Me.GridEditable1.Size = New System.Drawing.Size(482, 258)
        Me.GridEditable1.TabIndex = 199
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Blue
        Me.Lb5.Location = New System.Drawing.Point(498, 11)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(237, 18)
        Me.Lb5.TabIndex = 200
        Me.Lb5.Text = "CLASIFICACIÓN PARTIDA"
        '
        'BtPasarClasificacion
        '
        Me.BtPasarClasificacion.Image = Global.NetAgro.My.Resources.Resources.Action_arrow_blue_flat_right_16x16_32
        Me.BtPasarClasificacion.Location = New System.Drawing.Point(433, 184)
        Me.BtPasarClasificacion.Name = "BtPasarClasificacion"
        Me.BtPasarClasificacion.Size = New System.Drawing.Size(48, 33)
        Me.BtPasarClasificacion.TabIndex = 201
        Me.BtPasarClasificacion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BPreliminar)
        Me.Panel1.Controls.Add(Me.BImpDirecta)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 567)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 34)
        Me.Panel1.TabIndex = 202
        '
        'BPreliminar
        '
        Me.BPreliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPreliminar.Image = CType(resources.GetObject("BPreliminar.Image"), System.Drawing.Image)
        Me.BPreliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPreliminar.Location = New System.Drawing.Point(633, 0)
        Me.BPreliminar.Name = "BPreliminar"
        Me.BPreliminar.Orden = 0
        Me.BPreliminar.PedirClave = True
        Me.BPreliminar.Size = New System.Drawing.Size(75, 34)
        Me.BPreliminar.TabIndex = 102
        Me.BPreliminar.Text = "Preliminar"
        Me.BPreliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BPreliminar.UseVisualStyleBackColor = True
        '
        'BImpDirecta
        '
        Me.BImpDirecta.Dock = System.Windows.Forms.DockStyle.Right
        Me.BImpDirecta.Image = CType(resources.GetObject("BImpDirecta.Image"), System.Drawing.Image)
        Me.BImpDirecta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BImpDirecta.Location = New System.Drawing.Point(708, 0)
        Me.BImpDirecta.Name = "BImpDirecta"
        Me.BImpDirecta.Orden = 0
        Me.BImpDirecta.PedirClave = True
        Me.BImpDirecta.Size = New System.Drawing.Size(75, 34)
        Me.BImpDirecta.TabIndex = 101
        Me.BImpDirecta.Text = "Imp.Directa"
        Me.BImpDirecta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BImpDirecta.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(783, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(148, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar clasificación (F10)"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(931, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(70, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir (F12)"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'TxObservaciones
        '
        Me.TxObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxObservaciones.Autonumerico = False
        Me.TxObservaciones.BackColor = System.Drawing.Color.White
        Me.TxObservaciones.Buscando = False
        Me.TxObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObservaciones.ClForm = Nothing
        Me.TxObservaciones.ClParam = Nothing
        Me.TxObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObservaciones.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObservaciones.GridLin = Nothing
        Me.TxObservaciones.HaCambiado = False
        Me.TxObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObservaciones.lbbusca = Nothing
        Me.TxObservaciones.Location = New System.Drawing.Point(583, 329)
        Me.TxObservaciones.MiError = False
        Me.TxObservaciones.Name = "TxObservaciones"
        Me.TxObservaciones.Orden = 0
        Me.TxObservaciones.SaltoAlfinal = False
        Me.TxObservaciones.Siguiente = 0
        Me.TxObservaciones.Size = New System.Drawing.Size(394, 26)
        Me.TxObservaciones.TabIndex = 209
        Me.TxObservaciones.TeclaRepetida = False
        Me.TxObservaciones.TxDatoFinalSemana = Nothing
        Me.TxObservaciones.TxDatoInicioSemana = Nothing
        Me.TxObservaciones.UltimoValorValidado = Nothing
        '
        'LbObservaciones
        '
        Me.LbObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbObservaciones.AutoSize = True
        Me.LbObservaciones.CL_ControlAsociado = Nothing
        Me.LbObservaciones.CL_ValorFijo = True
        Me.LbObservaciones.ClForm = Nothing
        Me.LbObservaciones.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.LbObservaciones.Location = New System.Drawing.Point(430, 333)
        Me.LbObservaciones.Name = "LbObservaciones"
        Me.LbObservaciones.Size = New System.Drawing.Size(129, 18)
        Me.LbObservaciones.TabIndex = 208
        Me.LbObservaciones.Text = "Obs. Internas"
        '
        'PrintableComponentLink1
        '
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.prtSystem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prtSystem
        '
        'prtSystem
        '
        Me.prtSystem.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'TxObsProveedor
        '
        Me.TxObsProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxObsProveedor.Autonumerico = False
        Me.TxObsProveedor.BackColor = System.Drawing.Color.White
        Me.TxObsProveedor.Buscando = False
        Me.TxObsProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObsProveedor.ClForm = Nothing
        Me.TxObsProveedor.ClParam = Nothing
        Me.TxObsProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObsProveedor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObsProveedor.GridLin = Nothing
        Me.TxObsProveedor.HaCambiado = False
        Me.TxObsProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObsProveedor.lbbusca = Nothing
        Me.TxObsProveedor.Location = New System.Drawing.Point(583, 361)
        Me.TxObsProveedor.MiError = False
        Me.TxObsProveedor.Name = "TxObsProveedor"
        Me.TxObsProveedor.Orden = 0
        Me.TxObsProveedor.SaltoAlfinal = False
        Me.TxObsProveedor.Siguiente = 0
        Me.TxObsProveedor.Size = New System.Drawing.Size(394, 26)
        Me.TxObsProveedor.TabIndex = 211
        Me.TxObsProveedor.TeclaRepetida = False
        Me.TxObsProveedor.TxDatoFinalSemana = Nothing
        Me.TxObsProveedor.TxDatoInicioSemana = Nothing
        Me.TxObsProveedor.UltimoValorValidado = Nothing
        '
        'Lb7
        '
        Me.Lb7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(431, 365)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(146, 18)
        Me.Lb7.TabIndex = 210
        Me.Lb7.Text = "Obs. Proveedor"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(296, 102)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(59, 16)
        Me.Lb8.TabIndex = 213
        Me.Lb8.Text = "Cultivo"
        '
        'LbCultivo
        '
        Me.LbCultivo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCultivo.CL_ControlAsociado = Nothing
        Me.LbCultivo.CL_ValorFijo = False
        Me.LbCultivo.ClForm = Nothing
        Me.LbCultivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCultivo.Location = New System.Drawing.Point(361, 99)
        Me.LbCultivo.Name = "LbCultivo"
        Me.LbCultivo.Size = New System.Drawing.Size(120, 23)
        Me.LbCultivo.TabIndex = 212
        Me.LbCultivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridHistorial
        '
        Me.GridHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridHistorial.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridHistorial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridHistorial.Location = New System.Drawing.Point(12, 415)
        Me.GridHistorial.LookAndFeel.SkinName = "Black"
        Me.GridHistorial.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridHistorial.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridHistorial.MainView = Me.GridViewHistorial
        Me.GridHistorial.Name = "GridHistorial"
        Me.GridHistorial.Size = New System.Drawing.Size(971, 146)
        Me.GridHistorial.TabIndex = 214
        Me.GridHistorial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewHistorial})
        '
        'GridViewHistorial
        '
        Me.GridViewHistorial.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewHistorial.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewHistorial.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewHistorial.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewHistorial.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewHistorial.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewHistorial.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewHistorial.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewHistorial.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewHistorial.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewHistorial.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewHistorial.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewHistorial.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewHistorial.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewHistorial.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewHistorial.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewHistorial.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewHistorial.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewHistorial.Appearance.Row.Options.UseFont = True
        Me.GridViewHistorial.Appearance.Row.Options.UseForeColor = True
        Me.GridViewHistorial.GridControl = Me.GridHistorial
        Me.GridViewHistorial.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewHistorial.Name = "GridViewHistorial"
        Me.GridViewHistorial.OptionsBehavior.Editable = False
        Me.GridViewHistorial.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewHistorial.OptionsView.ShowGroupPanel = False
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Blue
        Me.Lb9.Location = New System.Drawing.Point(17, 394)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(109, 18)
        Me.Lb9.TabIndex = 215
        Me.Lb9.Text = "HISTORIAL"
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(173, 393)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(267, 16)
        Me.Lb10.TabIndex = 100290
        Me.Lb10.Text = "Pulsar para ver Detalle de Muestreo"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(146, 391)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(21, 21)
        Me.Panel3.TabIndex = 100289
        '
        'btDocumental
        '
        Me.btDocumental.Image = Global.NetAgro.My.Resources.Resources.App_warehause_16x16_32
        Me.btDocumental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDocumental.Location = New System.Drawing.Point(433, 299)
        Me.btDocumental.Name = "btDocumental"
        Me.btDocumental.Size = New System.Drawing.Size(110, 25)
        Me.btDocumental.TabIndex = 100291
        Me.btDocumental.Text = "Ver documental"
        Me.btDocumental.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDocumental.UseVisualStyleBackColor = True
        '
        'FrmClasificacionPartidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1001, 601)
        Me.Controls.Add(Me.btDocumental)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.GridHistorial)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.LbCultivo)
        Me.Controls.Add(Me.TxObsProveedor)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.TxObservaciones)
        Me.Controls.Add(Me.LbObservaciones)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtPasarClasificacion)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.GridEditable1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.GridConfeccion)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.LbGenero)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.LbKilosEntrada)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.LbAgricultor)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.LbPartida)
        Me.MinimumSize = New System.Drawing.Size(1017, 639)
        Me.Name = "FrmClasificacionPartidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación partida"
        CType(Me.GridConfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewConfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbPartida As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbKilosEntrada As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbGenero As NetAgro.Lb
    Public WithEvents GridConfeccion As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewConfeccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents GridEditable1 As NetAgro.GridEditable
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents BtPasarClasificacion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents TxObservaciones As NetAgro.TxDato
    Friend WithEvents LbObservaciones As NetAgro.Lb
    Protected WithEvents BImpDirecta As NetAgro.ClButton
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents prtSystem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents TxObsProveedor As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Protected WithEvents BPreliminar As NetAgro.ClButton
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents LbCultivo As NetAgro.Lb
    Public WithEvents GridHistorial As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewHistorial As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btDocumental As System.Windows.Forms.Button
End Class
