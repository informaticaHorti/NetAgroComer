<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalizarLineaProduccion
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
        Me.pnlSerieFactura = New System.Windows.Forms.Panel()
        Me.TxHoraFin = New System.Windows.Forms.TextBox()
        Me.updownHora = New System.Windows.Forms.NumericUpDown()
        Me.updownMinutos = New System.Windows.Forms.NumericUpDown()
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxObservaciones = New NetAgro.TxDato(Me.components)
        Me.LbObservaciones = New NetAgro.Lb(Me.components)
        Me.ChkNoFinalizar = New System.Windows.Forms.CheckBox()
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbFin = New System.Windows.Forms.Label()
        Me.LbInicio = New System.Windows.Forms.Label()
        Me.LbKgLinea = New System.Windows.Forms.Label()
        Me.LbGenero = New System.Windows.Forms.Label()
        Me.LbNumero = New System.Windows.Forms.Label()
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbTipo = New System.Windows.Forms.Label()
        Me.GridLineas = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.TxKilosConsumidos = New NetAgro.TxDato(Me.components)
        Me.btCancelar = New NetAgro.ClButton()
        Me.BtAceptar = New NetAgro.ClButton()
        Me.pnlSerieFactura.SuspendLayout()
        CType(Me.updownHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSerieFactura
        '
        Me.pnlSerieFactura.BackColor = System.Drawing.Color.LightBlue
        Me.pnlSerieFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSerieFactura.Controls.Add(Me.TxHoraFin)
        Me.pnlSerieFactura.Controls.Add(Me.updownHora)
        Me.pnlSerieFactura.Controls.Add(Me.updownMinutos)
        Me.pnlSerieFactura.Controls.Add(Me.Lb7)
        Me.pnlSerieFactura.Controls.Add(Me.TxObservaciones)
        Me.pnlSerieFactura.Controls.Add(Me.LbObservaciones)
        Me.pnlSerieFactura.Controls.Add(Me.ChkNoFinalizar)
        Me.pnlSerieFactura.Controls.Add(Me.Lb6)
        Me.pnlSerieFactura.Controls.Add(Me.Lb5)
        Me.pnlSerieFactura.Controls.Add(Me.Lb3)
        Me.pnlSerieFactura.Controls.Add(Me.Lb2)
        Me.pnlSerieFactura.Controls.Add(Me.Lb1)
        Me.pnlSerieFactura.Controls.Add(Me.LbFin)
        Me.pnlSerieFactura.Controls.Add(Me.LbInicio)
        Me.pnlSerieFactura.Controls.Add(Me.LbKgLinea)
        Me.pnlSerieFactura.Controls.Add(Me.LbGenero)
        Me.pnlSerieFactura.Controls.Add(Me.LbNumero)
        Me.pnlSerieFactura.Controls.Add(Me.Lb9)
        Me.pnlSerieFactura.Controls.Add(Me.LbTipo)
        Me.pnlSerieFactura.Controls.Add(Me.GridLineas)
        Me.pnlSerieFactura.Controls.Add(Me.Lb4)
        Me.pnlSerieFactura.Controls.Add(Me.LbFecha)
        Me.pnlSerieFactura.Controls.Add(Me.Panel1)
        Me.pnlSerieFactura.Controls.Add(Me.btCancelar)
        Me.pnlSerieFactura.Controls.Add(Me.BtAceptar)
        Me.pnlSerieFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSerieFactura.Location = New System.Drawing.Point(0, 0)
        Me.pnlSerieFactura.Name = "pnlSerieFactura"
        Me.pnlSerieFactura.Size = New System.Drawing.Size(785, 413)
        Me.pnlSerieFactura.TabIndex = 179
        '
        'TxHoraFin
        '
        Me.TxHoraFin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxHoraFin.Location = New System.Drawing.Point(386, 15)
        Me.TxHoraFin.Name = "TxHoraFin"
        Me.TxHoraFin.ReadOnly = True
        Me.TxHoraFin.Size = New System.Drawing.Size(50, 22)
        Me.TxHoraFin.TabIndex = 209
        '
        'updownHora
        '
        Me.updownHora.Location = New System.Drawing.Point(368, 16)
        Me.updownHora.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.updownHora.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.updownHora.Name = "updownHora"
        Me.updownHora.Size = New System.Drawing.Size(17, 20)
        Me.updownHora.TabIndex = 208
        Me.updownHora.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'updownMinutos
        '
        Me.updownMinutos.Location = New System.Drawing.Point(437, 16)
        Me.updownMinutos.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.updownMinutos.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.updownMinutos.Name = "updownMinutos"
        Me.updownMinutos.Size = New System.Drawing.Size(17, 20)
        Me.updownMinutos.TabIndex = 207
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Black
        Me.Lb7.Location = New System.Drawing.Point(233, 18)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(129, 16)
        Me.Lb7.TabIndex = 206
        Me.Lb7.Text = "Hora finalización"
        '
        'TxObservaciones
        '
        Me.TxObservaciones.Autonumerico = False
        Me.TxObservaciones.BackColor = System.Drawing.Color.White
        Me.TxObservaciones.Bloqueado = False
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
        Me.TxObservaciones.Location = New System.Drawing.Point(160, 340)
        Me.TxObservaciones.MiError = False
        Me.TxObservaciones.Name = "TxObservaciones"
        Me.TxObservaciones.Orden = 0
        Me.TxObservaciones.SaltoAlfinal = False
        Me.TxObservaciones.Siguiente = 0
        Me.TxObservaciones.Size = New System.Drawing.Size(606, 26)
        Me.TxObservaciones.TabIndex = 205
        Me.TxObservaciones.TeclaRepetida = False
        Me.TxObservaciones.TxDatoFinalSemana = Nothing
        Me.TxObservaciones.TxDatoInicioSemana = Nothing
        Me.TxObservaciones.UltimoValorValidado = Nothing
        '
        'LbObservaciones
        '
        Me.LbObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbObservaciones.AutoSize = True
        Me.LbObservaciones.CL_ControlAsociado = Nothing
        Me.LbObservaciones.CL_ValorFijo = True
        Me.LbObservaciones.ClForm = Nothing
        Me.LbObservaciones.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObservaciones.ForeColor = System.Drawing.Color.Teal
        Me.LbObservaciones.Location = New System.Drawing.Point(17, 344)
        Me.LbObservaciones.Name = "LbObservaciones"
        Me.LbObservaciones.Size = New System.Drawing.Size(137, 18)
        Me.LbObservaciones.TabIndex = 204
        Me.LbObservaciones.Text = "Observaciones"
        '
        'ChkNoFinalizar
        '
        Me.ChkNoFinalizar.AutoSize = True
        Me.ChkNoFinalizar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNoFinalizar.Location = New System.Drawing.Point(644, 15)
        Me.ChkNoFinalizar.Name = "ChkNoFinalizar"
        Me.ChkNoFinalizar.Size = New System.Drawing.Size(122, 23)
        Me.ChkNoFinalizar.TabIndex = 202
        Me.ChkNoFinalizar.Text = "No finalizar"
        Me.ChkNoFinalizar.UseVisualStyleBackColor = True
        '
        'Lb6
        '
        Me.Lb6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(687, 222)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(48, 18)
        Me.Lb6.TabIndex = 201
        Me.Lb6.Text = "Final"
        '
        'Lb5
        '
        Me.Lb5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(602, 222)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(55, 18)
        Me.Lb5.TabIndex = 200
        Me.Lb5.Text = "Inicio"
        '
        'Lb3
        '
        Me.Lb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(491, 222)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(78, 18)
        Me.Lb3.TabIndex = 199
        Me.Lb3.Text = "KgLinea"
        '
        'Lb2
        '
        Me.Lb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(161, 222)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(73, 18)
        Me.Lb2.TabIndex = 198
        Me.Lb2.Text = "Género"
        '
        'Lb1
        '
        Me.Lb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(47, 222)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(78, 18)
        Me.Lb1.TabIndex = 197
        Me.Lb1.Text = "Numero"
        '
        'LbFin
        '
        Me.LbFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbFin.BackColor = System.Drawing.Color.White
        Me.LbFin.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFin.Location = New System.Drawing.Point(687, 245)
        Me.LbFin.Name = "LbFin"
        Me.LbFin.Size = New System.Drawing.Size(79, 32)
        Me.LbFin.TabIndex = 196
        Me.LbFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbInicio
        '
        Me.LbInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbInicio.BackColor = System.Drawing.Color.White
        Me.LbInicio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInicio.Location = New System.Drawing.Point(602, 245)
        Me.LbInicio.Name = "LbInicio"
        Me.LbInicio.Size = New System.Drawing.Size(79, 32)
        Me.LbInicio.TabIndex = 195
        Me.LbInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbKgLinea
        '
        Me.LbKgLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbKgLinea.BackColor = System.Drawing.Color.White
        Me.LbKgLinea.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKgLinea.Location = New System.Drawing.Point(491, 245)
        Me.LbKgLinea.Name = "LbKgLinea"
        Me.LbKgLinea.Size = New System.Drawing.Size(99, 32)
        Me.LbKgLinea.TabIndex = 194
        Me.LbKgLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbGenero
        '
        Me.LbGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbGenero.BackColor = System.Drawing.Color.White
        Me.LbGenero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.Location = New System.Drawing.Point(161, 245)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(324, 32)
        Me.LbGenero.TabIndex = 193
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbNumero
        '
        Me.LbNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbNumero.BackColor = System.Drawing.Color.White
        Me.LbNumero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.Location = New System.Drawing.Point(47, 245)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(108, 32)
        Me.LbNumero.TabIndex = 192
        Me.LbNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb9
        '
        Me.Lb9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(17, 222)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(20, 18)
        Me.Lb9.TabIndex = 191
        Me.Lb9.Text = "T"
        '
        'LbTipo
        '
        Me.LbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbTipo.BackColor = System.Drawing.Color.White
        Me.LbTipo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.Location = New System.Drawing.Point(16, 245)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(25, 32)
        Me.LbTipo.TabIndex = 190
        Me.LbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridLineas
        '
        Me.GridLineas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLineas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridLineas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLineas.Location = New System.Drawing.Point(16, 54)
        Me.GridLineas.LookAndFeel.SkinName = "Black"
        Me.GridLineas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridLineas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridLineas.MainView = Me.GridViewLineas
        Me.GridLineas.Name = "GridLineas"
        Me.GridLineas.Size = New System.Drawing.Size(750, 146)
        Me.GridLineas.TabIndex = 189
        Me.GridLineas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLineas})
        '
        'GridViewLineas
        '
        Me.GridViewLineas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewLineas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridViewLineas.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewLineas.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewLineas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewLineas.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewLineas.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewLineas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewLineas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.SkyBlue
        Me.GridViewLineas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewLineas.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLineas.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewLineas.Appearance.Row.Options.UseFont = True
        Me.GridViewLineas.Appearance.Row.Options.UseForeColor = True
        Me.GridViewLineas.GridControl = Me.GridLineas
        Me.GridViewLineas.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewLineas.Name = "GridViewLineas"
        Me.GridViewLineas.OptionsBehavior.Editable = False
        Me.GridViewLineas.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewLineas.OptionsView.ShowGroupPanel = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Black
        Me.Lb4.Location = New System.Drawing.Point(13, 18)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(52, 16)
        Me.Lb4.TabIndex = 188
        Me.Lb4.Text = "Fecha"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(71, 15)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(120, 23)
        Me.LbFecha.TabIndex = 187
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.Lb23)
        Me.Panel1.Controls.Add(Me.TxKilosConsumidos)
        Me.Panel1.Location = New System.Drawing.Point(16, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 51)
        Me.Panel1.TabIndex = 89
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Black
        Me.Lb23.Location = New System.Drawing.Point(15, 18)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(124, 16)
        Me.Lb23.TabIndex = 81
        Me.Lb23.Text = "Kilos cosumidos"
        '
        'TxKilosConsumidos
        '
        Me.TxKilosConsumidos.Autonumerico = False
        Me.TxKilosConsumidos.Bloqueado = False
        Me.TxKilosConsumidos.Buscando = False
        Me.TxKilosConsumidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilosConsumidos.ClForm = Nothing
        Me.TxKilosConsumidos.ClParam = Nothing
        Me.TxKilosConsumidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilosConsumidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilosConsumidos.GridLin = Nothing
        Me.TxKilosConsumidos.HaCambiado = False
        Me.TxKilosConsumidos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilosConsumidos.lbbusca = Nothing
        Me.TxKilosConsumidos.Location = New System.Drawing.Point(145, 15)
        Me.TxKilosConsumidos.MiError = False
        Me.TxKilosConsumidos.Name = "TxKilosConsumidos"
        Me.TxKilosConsumidos.Orden = 0
        Me.TxKilosConsumidos.SaltoAlfinal = False
        Me.TxKilosConsumidos.Siguiente = 0
        Me.TxKilosConsumidos.Size = New System.Drawing.Size(112, 22)
        Me.TxKilosConsumidos.TabIndex = 80
        Me.TxKilosConsumidos.TeclaRepetida = False
        Me.TxKilosConsumidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKilosConsumidos.TxDatoFinalSemana = Nothing
        Me.TxKilosConsumidos.TxDatoInicioSemana = Nothing
        Me.TxKilosConsumidos.UltimoValorValidado = Nothing
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.NetAgro.My.Resources.Resources.Action_cancel_16x16_32
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(691, 378)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Orden = 0
        Me.btCancelar.PedirClave = True
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 88
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtAceptar.ForeColor = System.Drawing.Color.Black
        Me.BtAceptar.Image = Global.NetAgro.My.Resources.Resources.App_clean_16x16_32
        Me.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAceptar.Location = New System.Drawing.Point(614, 378)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Orden = 0
        Me.BtAceptar.PedirClave = True
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 0
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'FrmFinalizarLineaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 413)
        Me.Controls.Add(Me.pnlSerieFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFinalizarLineaProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalizar linea de produccion"
        Me.pnlSerieFactura.ResumeLayout(False)
        Me.pnlSerieFactura.PerformLayout()
        CType(Me.updownHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSerieFactura As System.Windows.Forms.Panel
    Friend WithEvents BtAceptar As NetAgro.ClButton
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents TxKilosConsumidos As NetAgro.TxDato
    Friend WithEvents btCancelar As NetAgro.ClButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Public WithEvents GridLineas As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbTipo As System.Windows.Forms.Label
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents LbGenero As System.Windows.Forms.Label
    Friend WithEvents LbFin As System.Windows.Forms.Label
    Friend WithEvents LbInicio As System.Windows.Forms.Label
    Friend WithEvents LbKgLinea As System.Windows.Forms.Label
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents ChkNoFinalizar As System.Windows.Forms.CheckBox
    Friend WithEvents LbObservaciones As NetAgro.Lb
    Friend WithEvents TxObservaciones As NetAgro.TxDato
    Friend WithEvents TxHoraFin As TextBox
    Friend WithEvents updownHora As NumericUpDown
    Friend WithEvents updownMinutos As NumericUpDown
    Friend WithEvents Lb7 As Lb
End Class
