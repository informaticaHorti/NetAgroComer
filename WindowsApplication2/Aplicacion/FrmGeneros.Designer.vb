<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeneros
    Inherits NetAgro.FrMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeneros))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.TxGasto = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCompuesto = New NetAgro.BtBusca(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaEnvase = New NetAgro.BtBusca(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaFamilia = New NetAgro.BtBusca(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtDescripcionPaises = New System.Windows.Forms.Button()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.XtraTabControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 78)
        Me.XtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1056, 430)
        Me.XtraTabControl1.TabIndex = 12
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Lb11)
        Me.XtraTabPage1.Controls.Add(Me.TxGasto)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaEnvase)
        Me.XtraTabPage1.Controls.Add(Me.Lb6)
        Me.XtraTabPage1.Controls.Add(Me.Lb7)
        Me.XtraTabPage1.Controls.Add(Me.TxDato5)
        Me.XtraTabPage1.Controls.Add(Me.Lb5)
        Me.XtraTabPage1.Controls.Add(Me.TxDato4)
        Me.XtraTabPage1.Controls.Add(Me.BtBuscaFamilia)
        Me.XtraTabPage1.Controls.Add(Me.Lb4)
        Me.XtraTabPage1.Controls.Add(Me.Lb3)
        Me.XtraTabPage1.Controls.Add(Me.TxDato3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1052, 404)
        Me.XtraTabPage1.Text = "Datos generales"
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.BackColor = System.Drawing.Color.Transparent
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(647, 81)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(130, 16)
        Me.Lb11.TabIndex = 55
        Me.Lb11.Text = "Gasto Conf x Kilo"
        '
        'TxGasto
        '
        Me.TxGasto.Autonumerico = False
        Me.TxGasto.Buscando = False
        Me.TxGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGasto.ClForm = Nothing
        Me.TxGasto.ClParam = Nothing
        Me.TxGasto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxGasto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGasto.GridLin = Nothing
        Me.TxGasto.HaCambiado = False
        Me.TxGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxGasto.lbbusca = Nothing
        Me.TxGasto.Location = New System.Drawing.Point(794, 74)
        Me.TxGasto.MiError = False
        Me.TxGasto.Name = "TxGasto"
        Me.TxGasto.Orden = 0
        Me.TxGasto.SaltoAlfinal = False
        Me.TxGasto.Siguiente = 0
        Me.TxGasto.Size = New System.Drawing.Size(90, 23)
        Me.TxGasto.TabIndex = 54
        Me.TxGasto.TeclaRepetida = False
        Me.TxGasto.TxDatoFinalSemana = Nothing
        Me.TxGasto.TxDatoInicioSemana = Nothing
        Me.TxGasto.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.ClGrid1)
        Me.GroupBox1.Controls.Add(Me.Lb10)
        Me.GroupBox1.Controls.Add(Me.TxDato7)
        Me.GroupBox1.Controls.Add(Me.BtBuscaCompuesto)
        Me.GroupBox1.Controls.Add(Me.Lb8)
        Me.GroupBox1.Controls.Add(Me.Lb9)
        Me.GroupBox1.Controls.Add(Me.TxDato6)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 288)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero compuesto"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(3, 92)
        Me.ClGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1040, 193)
        Me.ClGrid1.TabIndex = 101
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(12, 69)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(87, 16)
        Me.Lb10.TabIndex = 100
        Me.Lb10.Text = "Porcentaje"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(116, 62)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(61, 23)
        Me.TxDato7.TabIndex = 99
        Me.TxDato7.TeclaRepetida = False
        Me.TxDato7.TxDatoFinalSemana = Nothing
        Me.TxDato7.TxDatoInicioSemana = Nothing
        Me.TxDato7.UltimoValorValidado = Nothing
        '
        'BtBuscaCompuesto
        '
        Me.BtBuscaCompuesto.CL_Ancho = 0
        Me.BtBuscaCompuesto.CL_BuscaAlb = False
        Me.BtBuscaCompuesto.CL_campocodigo = Nothing
        Me.BtBuscaCompuesto.CL_camponombre = Nothing
        Me.BtBuscaCompuesto.CL_CampoOrden = "Nombre"
        Me.BtBuscaCompuesto.CL_ch1000 = False
        Me.BtBuscaCompuesto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCompuesto.CL_ControlAsociado = Nothing
        Me.BtBuscaCompuesto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCompuesto.CL_dfecha = Nothing
        Me.BtBuscaCompuesto.CL_Entidad = Nothing
        Me.BtBuscaCompuesto.CL_EsId = True
        Me.BtBuscaCompuesto.CL_Filtro = Nothing
        Me.BtBuscaCompuesto.cl_formu = Nothing
        Me.BtBuscaCompuesto.CL_hfecha = Nothing
        Me.BtBuscaCompuesto.cl_ListaW = Nothing
        Me.BtBuscaCompuesto.CL_xCentro = False
        Me.BtBuscaCompuesto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCompuesto.Location = New System.Drawing.Point(183, 33)
        Me.BtBuscaCompuesto.Name = "BtBuscaCompuesto"
        Me.BtBuscaCompuesto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCompuesto.TabIndex = 98
        Me.BtBuscaCompuesto.UseVisualStyleBackColor = True
        '
        'Lb8
        '
        Me.Lb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.Location = New System.Drawing.Point(224, 33)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(300, 23)
        Me.Lb8.TabIndex = 97
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(12, 36)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(60, 16)
        Me.Lb9.TabIndex = 96
        Me.Lb9.Text = "Genero"
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(116, 33)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(61, 23)
        Me.TxDato6.TabIndex = 95
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'BtBuscaEnvase
        '
        Me.BtBuscaEnvase.CL_Ancho = 0
        Me.BtBuscaEnvase.CL_BuscaAlb = False
        Me.BtBuscaEnvase.CL_campocodigo = Nothing
        Me.BtBuscaEnvase.CL_camponombre = Nothing
        Me.BtBuscaEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaEnvase.CL_ch1000 = False
        Me.BtBuscaEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaEnvase.CL_ControlAsociado = Me.TxDato2
        Me.BtBuscaEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaEnvase.CL_dfecha = Nothing
        Me.BtBuscaEnvase.CL_Entidad = Nothing
        Me.BtBuscaEnvase.CL_EsId = True
        Me.BtBuscaEnvase.CL_Filtro = Nothing
        Me.BtBuscaEnvase.cl_formu = Nothing
        Me.BtBuscaEnvase.CL_hfecha = Nothing
        Me.BtBuscaEnvase.cl_ListaW = Nothing
        Me.BtBuscaEnvase.CL_xCentro = False
        Me.BtBuscaEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaEnvase.Location = New System.Drawing.Point(254, 74)
        Me.BtBuscaEnvase.Name = "BtBuscaEnvase"
        Me.BtBuscaEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaEnvase.TabIndex = 53
        Me.BtBuscaEnvase.UseVisualStyleBackColor = True
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(116, 49)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(437, 23)
        Me.TxDato2.TabIndex = 28
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.BackColor = System.Drawing.SystemColors.Control
        Me.Lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(295, 74)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(300, 23)
        Me.Lb6.TabIndex = 52
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.BackColor = System.Drawing.Color.Transparent
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(25, 81)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(97, 16)
        Me.Lb7.TabIndex = 51
        Me.Lb7.Text = "Env.Entrada"
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(187, 74)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(61, 23)
        Me.TxDato5.TabIndex = 50
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.BackColor = System.Drawing.Color.Transparent
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(24, 15)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(94, 16)
        Me.Lb5.TabIndex = 49
        Me.Lb5.Text = "Abreviacion"
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(187, 12)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(258, 23)
        Me.TxDato4.TabIndex = 48
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'BtBuscaFamilia
        '
        Me.BtBuscaFamilia.CL_Ancho = 0
        Me.BtBuscaFamilia.CL_BuscaAlb = False
        Me.BtBuscaFamilia.CL_campocodigo = Nothing
        Me.BtBuscaFamilia.CL_camponombre = Nothing
        Me.BtBuscaFamilia.CL_CampoOrden = "Nombre"
        Me.BtBuscaFamilia.CL_ch1000 = False
        Me.BtBuscaFamilia.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFamilia.CL_ControlAsociado = Me.TxDato2
        Me.BtBuscaFamilia.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFamilia.CL_dfecha = Nothing
        Me.BtBuscaFamilia.CL_Entidad = Nothing
        Me.BtBuscaFamilia.CL_EsId = True
        Me.BtBuscaFamilia.CL_Filtro = Nothing
        Me.BtBuscaFamilia.cl_formu = Nothing
        Me.BtBuscaFamilia.CL_hfecha = Nothing
        Me.BtBuscaFamilia.cl_ListaW = Nothing
        Me.BtBuscaFamilia.CL_xCentro = False
        Me.BtBuscaFamilia.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaFamilia.Location = New System.Drawing.Point(254, 45)
        Me.BtBuscaFamilia.Name = "BtBuscaFamilia"
        Me.BtBuscaFamilia.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFamilia.TabIndex = 47
        Me.BtBuscaFamilia.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.BackColor = System.Drawing.SystemColors.Control
        Me.Lb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.Location = New System.Drawing.Point(295, 45)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(225, 23)
        Me.Lb4.TabIndex = 46
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.BackColor = System.Drawing.Color.Transparent
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(25, 48)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(88, 16)
        Me.Lb3.TabIndex = 45
        Me.Lb3.Text = "SubFamilia"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(187, 45)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(35, 23)
        Me.TxDato3.TabIndex = 44
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(224, 19)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(129, 23)
        Me.BotonesAvance1.TabIndex = 37
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaGenero
        '
        Me.BtBuscaGenero.CL_Ancho = 0
        Me.BtBuscaGenero.CL_BuscaAlb = False
        Me.BtBuscaGenero.CL_campocodigo = Nothing
        Me.BtBuscaGenero.CL_camponombre = Nothing
        Me.BtBuscaGenero.CL_CampoOrden = "NombreGenero"
        Me.BtBuscaGenero.CL_ch1000 = False
        Me.BtBuscaGenero.CL_ConsultaSql = "Select * from Generos"
        Me.BtBuscaGenero.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaGenero.CL_DevuelveCampo = "IdGenero"
        Me.BtBuscaGenero.CL_dfecha = Nothing
        Me.BtBuscaGenero.CL_Entidad = Nothing
        Me.BtBuscaGenero.CL_EsId = True
        Me.BtBuscaGenero.CL_Filtro = Nothing
        Me.BtBuscaGenero.cl_formu = Nothing
        Me.BtBuscaGenero.CL_hfecha = Nothing
        Me.BtBuscaGenero.cl_ListaW = Nothing
        Me.BtBuscaGenero.CL_xCentro = False
        Me.BtBuscaGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGenero.Location = New System.Drawing.Point(185, 19)
        Me.BtBuscaGenero.Name = "BtBuscaGenero"
        Me.BtBuscaGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGenero.TabIndex = 36
        Me.BtBuscaGenero.UseVisualStyleBackColor = True
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(116, 19)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 23)
        Me.TxDato1.TabIndex = 30
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(11, 52)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 29
        Me.Lb2.Text = "Nombre"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 22)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 31
        Me.Lb1.Text = "Código"
        '
        'BtDescripcionPaises
        '
        Me.BtDescripcionPaises.Image = Global.NetAgro.My.Resources.Resources.App_locale_16x16_32
        Me.BtDescripcionPaises.Location = New System.Drawing.Point(559, 49)
        Me.BtDescripcionPaises.Name = "BtDescripcionPaises"
        Me.BtDescripcionPaises.Size = New System.Drawing.Size(27, 23)
        Me.BtDescripcionPaises.TabIndex = 265
        Me.BtDescripcionPaises.UseVisualStyleBackColor = True
        '
        'FrmGeneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 542)
        Me.Controls.Add(Me.BtDescripcionPaises)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaGenero)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGeneros"
        Me.Text = "Generos"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaGenero, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.BtDescripcionPaises, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(false)
        Me.XtraTabPage1.ResumeLayout(false)
        Me.XtraTabPage1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaGenero As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BtBuscaEnvase As NetAgro.BtBusca
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents BtBuscaFamilia As NetAgro.BtBusca
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents BtBuscaCompuesto As NetAgro.BtBusca
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents TxGasto As NetAgro.TxDato
    Friend WithEvents BtDescripcionPaises As System.Windows.Forms.Button
End Class
