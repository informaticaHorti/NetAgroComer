<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoraCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoraCompras))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAg1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Grid2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxPrecioEnv = New NetAgro.TxDato(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.TxImporte1 = New NetAgro.TxDato(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.TxImporte2 = New NetAgro.TxDato(Me.components)
        Me.TxImporte3 = New NetAgro.TxDato(Me.components)
        Me.TxImporte4 = New NetAgro.TxDato(Me.components)
        Me.TxImporte5 = New NetAgro.TxDato(Me.components)
        Me.LbTotalImporte = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.LbPmedio = New NetAgro.Lb(Me.components)
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.TxImporte8 = New NetAgro.TxDato(Me.components)
        Me.TxImporte7 = New NetAgro.TxDato(Me.components)
        Me.TxImporte6 = New NetAgro.TxDato(Me.components)
        Me.LbEnvase = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.BtActualizar = New NetAgro.ClButton()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.chkAgrupar = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Size = New System.Drawing.Size(1284, 39)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(917, 70)
        Me.PanelConsulta.Size = New System.Drawing.Size(362, 178)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(984, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1059, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1134, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1209, 0)
        '
        'BtAux
        '
        Me.BtAux.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtAux.Location = New System.Drawing.Point(909, 0)
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
        Me.TxDato1.Location = New System.Drawing.Point(126, 6)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        '
        'BtBuscaAg1
        '
        Me.BtBuscaAg1.CL_BuscaAlb = False
        Me.BtBuscaAg1.CL_campocodigo = Nothing
        Me.BtBuscaAg1.CL_camponombre = Nothing
        Me.BtBuscaAg1.CL_CampoOrden = "Nombre"
        Me.BtBuscaAg1.CL_ch1000 = False
        Me.BtBuscaAg1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAg1.CL_ControlAsociado = Nothing
        Me.BtBuscaAg1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAg1.CL_dfecha = Nothing
        Me.BtBuscaAg1.CL_Entidad = Nothing
        Me.BtBuscaAg1.CL_Filtro = Nothing
        Me.BtBuscaAg1.cl_formu = Nothing
        Me.BtBuscaAg1.CL_hfecha = Nothing
        Me.BtBuscaAg1.cl_ListaW = Nothing
        Me.BtBuscaAg1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAg1.Location = New System.Drawing.Point(195, 6)
        Me.BtBuscaAg1.Name = "BtBuscaAg1"
        Me.BtBuscaAg1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAg1.TabIndex = 50
        Me.BtBuscaAg1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Codigo"
        '
        'Lb19
        '
        Me.Lb19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = False
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb19.Location = New System.Drawing.Point(250, 6)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(346, 23)
        Me.Lb19.TabIndex = 75
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(984, 6)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(102, 22)
        Me.TxDato3.TabIndex = 83
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(871, 9)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(95, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Hasta fecha"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(742, 6)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 81
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(627, 9)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(97, 16)
        Me.Lb5.TabIndex = 80
        Me.Lb5.Text = "Desde fecha"
        '
        'Lb2
        '
        Me.Lb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(981, 47)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(210, 18)
        Me.Lb2.TabIndex = 81
        Me.Lb2.Text = "Albaranes para valorar"
        '
        'Grid2
        '
        Me.Grid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.Location = New System.Drawing.Point(2, 70)
        Me.Grid2.LookAndFeel.SkinName = "Black"
        Me.Grid2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid2.MainView = Me.GridView2
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(899, 475)
        Me.Grid2.TabIndex = 82
        Me.Grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.GridControl = Me.Grid2
        Me.GridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.AutoCalcPreviewLineCount = True
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbGenero.Location = New System.Drawing.Point(993, 251)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(280, 23)
        Me.LbGenero.TabIndex = 86
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(925, 258)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(60, 16)
        Me.Lb7.TabIndex = 85
        Me.Lb7.Text = "Género"
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = True
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCategoria.Location = New System.Drawing.Point(993, 308)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(190, 23)
        Me.LbCategoria.TabIndex = 88
        Me.LbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(925, 315)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(36, 16)
        Me.Lb9.TabIndex = 87
        Me.Lb9.Text = "CAT"
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(1092, 379)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(85, 16)
        Me.Lb10.TabIndex = 83
        Me.Lb10.Text = "Pr. Envase"
        '
        'TxPrecioEnv
        '
        Me.TxPrecioEnv.Autonumerico = False
        Me.TxPrecioEnv.Buscando = False
        Me.TxPrecioEnv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPrecioEnv.ClForm = Nothing
        Me.TxPrecioEnv.ClParam = Nothing
        Me.TxPrecioEnv.Enabled = False
        Me.TxPrecioEnv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPrecioEnv.GridLin = Nothing
        Me.TxPrecioEnv.HaCambiado = False
        Me.TxPrecioEnv.lbbusca = Nothing
        Me.TxPrecioEnv.Location = New System.Drawing.Point(1183, 377)
        Me.TxPrecioEnv.MiError = False
        Me.TxPrecioEnv.Name = "TxPrecioEnv"
        Me.TxPrecioEnv.Orden = 0
        Me.TxPrecioEnv.SaltoAlfinal = False
        Me.TxPrecioEnv.Siguiente = 0
        Me.TxPrecioEnv.Size = New System.Drawing.Size(88, 22)
        Me.TxPrecioEnv.TabIndex = 84
        Me.TxPrecioEnv.TeclaRepetida = False
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = True
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbKilos.Location = New System.Drawing.Point(993, 338)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(103, 23)
        Me.LbKilos.TabIndex = 90
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(927, 341)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(42, 16)
        Me.Lb11.TabIndex = 89
        Me.Lb11.Text = "Kilos"
        '
        'TxImporte1
        '
        Me.TxImporte1.Autonumerico = False
        Me.TxImporte1.Buscando = False
        Me.TxImporte1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte1.ClForm = Nothing
        Me.TxImporte1.ClParam = Nothing
        Me.TxImporte1.Enabled = False
        Me.TxImporte1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte1.GridLin = Nothing
        Me.TxImporte1.HaCambiado = False
        Me.TxImporte1.lbbusca = Nothing
        Me.TxImporte1.Location = New System.Drawing.Point(922, 422)
        Me.TxImporte1.MiError = False
        Me.TxImporte1.Name = "TxImporte1"
        Me.TxImporte1.Orden = 0
        Me.TxImporte1.SaltoAlfinal = False
        Me.TxImporte1.Siguiente = 0
        Me.TxImporte1.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte1.TabIndex = 91
        Me.TxImporte1.TeclaRepetida = False
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(925, 403)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(75, 16)
        Me.Lb12.TabIndex = 92
        Me.Lb12.Text = "Importes"
        '
        'TxImporte2
        '
        Me.TxImporte2.Autonumerico = False
        Me.TxImporte2.Buscando = False
        Me.TxImporte2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte2.ClForm = Nothing
        Me.TxImporte2.ClParam = Nothing
        Me.TxImporte2.Enabled = False
        Me.TxImporte2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte2.GridLin = Nothing
        Me.TxImporte2.HaCambiado = False
        Me.TxImporte2.lbbusca = Nothing
        Me.TxImporte2.Location = New System.Drawing.Point(922, 447)
        Me.TxImporte2.MiError = False
        Me.TxImporte2.Name = "TxImporte2"
        Me.TxImporte2.Orden = 0
        Me.TxImporte2.SaltoAlfinal = False
        Me.TxImporte2.Siguiente = 0
        Me.TxImporte2.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte2.TabIndex = 93
        Me.TxImporte2.TeclaRepetida = False
        '
        'TxImporte3
        '
        Me.TxImporte3.Autonumerico = False
        Me.TxImporte3.Buscando = False
        Me.TxImporte3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte3.ClForm = Nothing
        Me.TxImporte3.ClParam = Nothing
        Me.TxImporte3.Enabled = False
        Me.TxImporte3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte3.GridLin = Nothing
        Me.TxImporte3.HaCambiado = False
        Me.TxImporte3.lbbusca = Nothing
        Me.TxImporte3.Location = New System.Drawing.Point(922, 472)
        Me.TxImporte3.MiError = False
        Me.TxImporte3.Name = "TxImporte3"
        Me.TxImporte3.Orden = 0
        Me.TxImporte3.SaltoAlfinal = False
        Me.TxImporte3.Siguiente = 0
        Me.TxImporte3.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte3.TabIndex = 94
        Me.TxImporte3.TeclaRepetida = False
        '
        'TxImporte4
        '
        Me.TxImporte4.Autonumerico = False
        Me.TxImporte4.Buscando = False
        Me.TxImporte4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte4.ClForm = Nothing
        Me.TxImporte4.ClParam = Nothing
        Me.TxImporte4.Enabled = False
        Me.TxImporte4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte4.GridLin = Nothing
        Me.TxImporte4.HaCambiado = False
        Me.TxImporte4.lbbusca = Nothing
        Me.TxImporte4.Location = New System.Drawing.Point(922, 497)
        Me.TxImporte4.MiError = False
        Me.TxImporte4.Name = "TxImporte4"
        Me.TxImporte4.Orden = 0
        Me.TxImporte4.SaltoAlfinal = False
        Me.TxImporte4.Siguiente = 0
        Me.TxImporte4.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte4.TabIndex = 95
        Me.TxImporte4.TeclaRepetida = False
        '
        'TxImporte5
        '
        Me.TxImporte5.Autonumerico = False
        Me.TxImporte5.Buscando = False
        Me.TxImporte5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte5.ClForm = Nothing
        Me.TxImporte5.ClParam = Nothing
        Me.TxImporte5.Enabled = False
        Me.TxImporte5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte5.GridLin = Nothing
        Me.TxImporte5.HaCambiado = False
        Me.TxImporte5.lbbusca = Nothing
        Me.TxImporte5.Location = New System.Drawing.Point(922, 522)
        Me.TxImporte5.MiError = False
        Me.TxImporte5.Name = "TxImporte5"
        Me.TxImporte5.Orden = 0
        Me.TxImporte5.SaltoAlfinal = False
        Me.TxImporte5.Siguiente = 0
        Me.TxImporte5.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte5.TabIndex = 96
        Me.TxImporte5.TeclaRepetida = False
        '
        'LbTotalImporte
        '
        Me.LbTotalImporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTotalImporte.CL_ControlAsociado = Nothing
        Me.LbTotalImporte.CL_ValorFijo = False
        Me.LbTotalImporte.ClForm = Nothing
        Me.LbTotalImporte.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTotalImporte.Location = New System.Drawing.Point(1158, 497)
        Me.LbTotalImporte.Name = "LbTotalImporte"
        Me.LbTotalImporte.Size = New System.Drawing.Size(113, 23)
        Me.LbTotalImporte.TabIndex = 98
        Me.LbTotalImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(1049, 500)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(105, 16)
        Me.Lb14.TabIndex = 97
        Me.Lb14.Text = "Total importe"
        '
        'LbPmedio
        '
        Me.LbPmedio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPmedio.CL_ControlAsociado = Nothing
        Me.LbPmedio.CL_ValorFijo = False
        Me.LbPmedio.ClForm = Nothing
        Me.LbPmedio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPmedio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPmedio.Location = New System.Drawing.Point(1183, 522)
        Me.LbPmedio.Name = "LbPmedio"
        Me.LbPmedio.Size = New System.Drawing.Size(88, 23)
        Me.LbPmedio.TabIndex = 100
        Me.LbPmedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(1049, 525)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(65, 16)
        Me.Lb16.TabIndex = 99
        Me.Lb16.Text = "P.Medio"
        '
        'TxImporte8
        '
        Me.TxImporte8.Autonumerico = False
        Me.TxImporte8.Buscando = False
        Me.TxImporte8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte8.ClForm = Nothing
        Me.TxImporte8.ClParam = Nothing
        Me.TxImporte8.Enabled = False
        Me.TxImporte8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte8.GridLin = Nothing
        Me.TxImporte8.HaCambiado = False
        Me.TxImporte8.lbbusca = Nothing
        Me.TxImporte8.Location = New System.Drawing.Point(1163, 472)
        Me.TxImporte8.MiError = False
        Me.TxImporte8.Name = "TxImporte8"
        Me.TxImporte8.Orden = 0
        Me.TxImporte8.SaltoAlfinal = False
        Me.TxImporte8.Siguiente = 0
        Me.TxImporte8.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte8.TabIndex = 103
        Me.TxImporte8.TeclaRepetida = False
        '
        'TxImporte7
        '
        Me.TxImporte7.Autonumerico = False
        Me.TxImporte7.Buscando = False
        Me.TxImporte7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte7.ClForm = Nothing
        Me.TxImporte7.ClParam = Nothing
        Me.TxImporte7.Enabled = False
        Me.TxImporte7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte7.GridLin = Nothing
        Me.TxImporte7.HaCambiado = False
        Me.TxImporte7.lbbusca = Nothing
        Me.TxImporte7.Location = New System.Drawing.Point(1163, 447)
        Me.TxImporte7.MiError = False
        Me.TxImporte7.Name = "TxImporte7"
        Me.TxImporte7.Orden = 0
        Me.TxImporte7.SaltoAlfinal = False
        Me.TxImporte7.Siguiente = 0
        Me.TxImporte7.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte7.TabIndex = 102
        Me.TxImporte7.TeclaRepetida = False
        '
        'TxImporte6
        '
        Me.TxImporte6.Autonumerico = False
        Me.TxImporte6.Buscando = False
        Me.TxImporte6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte6.ClForm = Nothing
        Me.TxImporte6.ClParam = Nothing
        Me.TxImporte6.Enabled = False
        Me.TxImporte6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte6.GridLin = Nothing
        Me.TxImporte6.HaCambiado = False
        Me.TxImporte6.lbbusca = Nothing
        Me.TxImporte6.Location = New System.Drawing.Point(1163, 422)
        Me.TxImporte6.MiError = False
        Me.TxImporte6.Name = "TxImporte6"
        Me.TxImporte6.Orden = 0
        Me.TxImporte6.SaltoAlfinal = False
        Me.TxImporte6.Siguiente = 0
        Me.TxImporte6.Size = New System.Drawing.Size(108, 22)
        Me.TxImporte6.TabIndex = 101
        Me.TxImporte6.TeclaRepetida = False
        '
        'LbEnvase
        '
        Me.LbEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbEnvase.CL_ControlAsociado = Nothing
        Me.LbEnvase.CL_ValorFijo = True
        Me.LbEnvase.ClForm = Nothing
        Me.LbEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbEnvase.Location = New System.Drawing.Point(993, 280)
        Me.LbEnvase.Name = "LbEnvase"
        Me.LbEnvase.Size = New System.Drawing.Size(280, 23)
        Me.LbEnvase.TabIndex = 105
        Me.LbEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(925, 287)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(61, 16)
        Me.Lb6.TabIndex = 104
        Me.Lb6.Text = "Envase"
        '
        'LbBultos
        '
        Me.LbBultos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = True
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbBultos.Location = New System.Drawing.Point(1212, 338)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(61, 23)
        Me.LbBultos.TabIndex = 107
        Me.LbBultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(1152, 341)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(54, 16)
        Me.Lb13.TabIndex = 106
        Me.Lb13.Text = "Bultos"
        '
        'BtActualizar
        '
        Me.BtActualizar.Image = Global.NetAgro.My.Resources.Resources.arrow_refresh
        Me.BtActualizar.Location = New System.Drawing.Point(1145, 522)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(32, 23)
        Me.BtActualizar.TabIndex = 108
        Me.BtActualizar.UseVisualStyleBackColor = True
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(1251, 43)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100288
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(1224, 43)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100289
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'chkAgrupar
        '
        Me.chkAgrupar.AutoSize = True
        Me.chkAgrupar.Campobd = Nothing
        Me.chkAgrupar.Checked = True
        Me.chkAgrupar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAgrupar.ClForm = Nothing
        Me.chkAgrupar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgrupar.ForeColor = System.Drawing.Color.Teal
        Me.chkAgrupar.GridLin = Nothing
        Me.chkAgrupar.HaCambiado = False
        Me.chkAgrupar.Location = New System.Drawing.Point(16, 45)
        Me.chkAgrupar.MiEntidad = Nothing
        Me.chkAgrupar.MiError = False
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Orden = 0
        Me.chkAgrupar.SaltoAlfinal = False
        Me.chkAgrupar.Size = New System.Drawing.Size(248, 20)
        Me.chkAgrupar.TabIndex = 100290
        Me.chkAgrupar.Text = "Agrupar por categoría, envase"
        Me.chkAgrupar.UseVisualStyleBackColor = True
        Me.chkAgrupar.ValorCampoFalse = Nothing
        Me.chkAgrupar.ValorCampoTrue = Nothing
        Me.chkAgrupar.ValorDefecto = False
        '
        'FrmValoraCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 585)
        Me.Controls.Add(Me.chkAgrupar)
        Me.Controls.Add(Me.BtSelTodos)
        Me.Controls.Add(Me.BtSelNinguno)
        Me.Controls.Add(Me.BtActualizar)
        Me.Controls.Add(Me.LbBultos)
        Me.Controls.Add(Me.Lb13)
        Me.Controls.Add(Me.LbEnvase)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.TxImporte8)
        Me.Controls.Add(Me.TxImporte7)
        Me.Controls.Add(Me.TxImporte6)
        Me.Controls.Add(Me.LbPmedio)
        Me.Controls.Add(Me.Lb16)
        Me.Controls.Add(Me.LbTotalImporte)
        Me.Controls.Add(Me.Lb14)
        Me.Controls.Add(Me.TxImporte5)
        Me.Controls.Add(Me.TxImporte4)
        Me.Controls.Add(Me.TxImporte3)
        Me.Controls.Add(Me.TxImporte2)
        Me.Controls.Add(Me.Lb12)
        Me.Controls.Add(Me.TxImporte1)
        Me.Controls.Add(Me.LbKilos)
        Me.Controls.Add(Me.Lb11)
        Me.Controls.Add(Me.LbCategoria)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.LbGenero)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.TxPrecioEnv)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb19)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBuscaAg1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValoraCompras"
        Me.Text = "Valoracion albaranes de compra EN FIRME"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAg1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb19, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Grid2, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.TxPrecioEnv, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.LbGenero, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.LbCategoria, 0)
        Me.Controls.SetChildIndex(Me.Lb11, 0)
        Me.Controls.SetChildIndex(Me.LbKilos, 0)
        Me.Controls.SetChildIndex(Me.TxImporte1, 0)
        Me.Controls.SetChildIndex(Me.Lb12, 0)
        Me.Controls.SetChildIndex(Me.TxImporte2, 0)
        Me.Controls.SetChildIndex(Me.TxImporte3, 0)
        Me.Controls.SetChildIndex(Me.TxImporte4, 0)
        Me.Controls.SetChildIndex(Me.TxImporte5, 0)
        Me.Controls.SetChildIndex(Me.Lb14, 0)
        Me.Controls.SetChildIndex(Me.LbTotalImporte, 0)
        Me.Controls.SetChildIndex(Me.Lb16, 0)
        Me.Controls.SetChildIndex(Me.LbPmedio, 0)
        Me.Controls.SetChildIndex(Me.TxImporte6, 0)
        Me.Controls.SetChildIndex(Me.TxImporte7, 0)
        Me.Controls.SetChildIndex(Me.TxImporte8, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.LbEnvase, 0)
        Me.Controls.SetChildIndex(Me.Lb13, 0)
        Me.Controls.SetChildIndex(Me.LbBultos, 0)
        Me.Controls.SetChildIndex(Me.BtActualizar, 0)
        Me.Controls.SetChildIndex(Me.BtSelNinguno, 0)
        Me.Controls.SetChildIndex(Me.BtSelTodos, 0)
        Me.Controls.SetChildIndex(Me.chkAgrupar, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBuscaAg1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Public WithEvents Grid2 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxPrecioEnv As NetAgro.TxDato
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents TxImporte1 As NetAgro.TxDato
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents TxImporte2 As NetAgro.TxDato
    Friend WithEvents TxImporte3 As NetAgro.TxDato
    Friend WithEvents TxImporte4 As NetAgro.TxDato
    Friend WithEvents TxImporte5 As NetAgro.TxDato
    Friend WithEvents LbTotalImporte As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents LbPmedio As NetAgro.Lb
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents TxImporte8 As NetAgro.TxDato
    Friend WithEvents TxImporte7 As NetAgro.TxDato
    Friend WithEvents TxImporte6 As NetAgro.TxDato
    Friend WithEvents LbEnvase As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents BtActualizar As NetAgro.ClButton
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents chkAgrupar As NetAgro.Chk
End Class
