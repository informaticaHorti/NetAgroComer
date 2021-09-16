<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioAgricultor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioAgricultor))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.BtBusca4 = New NetAgro.BtBusca(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.BtBusca5 = New NetAgro.BtBusca(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.LbTotalKilos = New NetAgro.Lb(Me.components)
        Me.LbTotalImporte = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb31 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCabecera.Controls.Add(Me.LbTipo)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb_5)
        Me.PanelCabecera.Controls.Add(Me.BtBusca5)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.TxDato5)
        Me.PanelCabecera.Controls.Add(Me.Lb_4)
        Me.PanelCabecera.Controls.Add(Me.BtBusca4)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb_1)
        Me.PanelCabecera.Controls.Add(Me.BtBusca1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.BtSelTodos)
        Me.PanelCabecera.Controls.Add(Me.BtSelNinguno)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.None
        Me.PanelCabecera.Size = New System.Drawing.Size(1304, 69)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 75)
        Me.PanelConsulta.Size = New System.Drawing.Size(1304, 435)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1004, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1079, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1154, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1229, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(929, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(1269, 38)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100296
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(1242, 38)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100297
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.Color.LightGray
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(240, 8)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(374, 18)
        Me.Lb_1.TabIndex = 100301
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Me.TxDato1
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.Image = CType(resources.GetObject("BtBusca1.Image"), System.Drawing.Image)
        Me.BtBusca1.Location = New System.Drawing.Point(201, 6)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 100300
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(120, 6)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato1.TabIndex = 100298
        Me.TxDato1.TeclaRepetida = False
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
        Me.Lb1.Size = New System.Drawing.Size(102, 16)
        Me.Lb1.TabIndex = 100299
        Me.Lb1.Text = "De Agricultor"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 38)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(75, 16)
        Me.Lb2.TabIndex = 100303
        Me.Lb2.Text = "De Fecha"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(120, 35)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato2.TabIndex = 100302
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(223, 38)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(99, 16)
        Me.Lb3.TabIndex = 100305
        Me.Lb3.Text = "Hasta Fecha"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(328, 35)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(93, 22)
        Me.TxDato3.TabIndex = 100304
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb_4
        '
        Me.Lb_4.BackColor = System.Drawing.Color.LightGray
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_4.Location = New System.Drawing.Point(895, 8)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(374, 18)
        Me.Lb_4.TabIndex = 100309
        '
        'BtBusca4
        '
        Me.BtBusca4.CL_BuscaAlb = False
        Me.BtBusca4.CL_campocodigo = Nothing
        Me.BtBusca4.CL_camponombre = Nothing
        Me.BtBusca4.CL_CampoOrden = "Nombre"
        Me.BtBusca4.CL_ch1000 = False
        Me.BtBusca4.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca4.CL_ControlAsociado = Me.TxDato4
        Me.BtBusca4.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca4.CL_dfecha = Nothing
        Me.BtBusca4.CL_Entidad = Nothing
        Me.BtBusca4.CL_Filtro = Nothing
        Me.BtBusca4.cl_formu = Nothing
        Me.BtBusca4.CL_hfecha = Nothing
        Me.BtBusca4.cl_ListaW = Nothing
        Me.BtBusca4.Image = CType(resources.GetObject("BtBusca4.Image"), System.Drawing.Image)
        Me.BtBusca4.Location = New System.Drawing.Point(856, 6)
        Me.BtBusca4.Name = "BtBusca4"
        Me.BtBusca4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca4.TabIndex = 100308
        Me.BtBusca4.UseVisualStyleBackColor = True
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(775, 6)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(75, 22)
        Me.TxDato4.TabIndex = 100306
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(676, 9)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(93, 16)
        Me.Lb4.TabIndex = 100307
        Me.Lb4.Text = "A Agricultor"
        '
        'Lb_5
        '
        Me.Lb_5.BackColor = System.Drawing.Color.LightGray
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_5.Location = New System.Drawing.Point(895, 37)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(259, 18)
        Me.Lb_5.TabIndex = 100313
        '
        'BtBusca5
        '
        Me.BtBusca5.CL_BuscaAlb = False
        Me.BtBusca5.CL_campocodigo = Nothing
        Me.BtBusca5.CL_camponombre = Nothing
        Me.BtBusca5.CL_CampoOrden = "Nombre"
        Me.BtBusca5.CL_ch1000 = False
        Me.BtBusca5.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca5.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca5.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca5.CL_dfecha = Nothing
        Me.BtBusca5.CL_Entidad = Nothing
        Me.BtBusca5.CL_Filtro = Nothing
        Me.BtBusca5.cl_formu = Nothing
        Me.BtBusca5.CL_hfecha = Nothing
        Me.BtBusca5.cl_ListaW = Nothing
        Me.BtBusca5.Image = CType(resources.GetObject("BtBusca5.Image"), System.Drawing.Image)
        Me.BtBusca5.Location = New System.Drawing.Point(856, 35)
        Me.BtBusca5.Name = "BtBusca5"
        Me.BtBusca5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca5.TabIndex = 100312
        Me.BtBusca5.UseVisualStyleBackColor = True
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(775, 35)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(75, 22)
        Me.TxDato5.TabIndex = 100310
        Me.TxDato5.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(717, 38)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(52, 16)
        Me.Lb5.TabIndex = 100311
        Me.Lb5.Text = "A Tipo"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(427, 38)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(38, 16)
        Me.Lb6.TabIndex = 100314
        Me.Lb6.Text = "Tipo"
        '
        'LbTipo
        '
        Me.LbTipo.BackColor = System.Drawing.Color.LightGray
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = True
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipo.Location = New System.Drawing.Point(471, 37)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(240, 18)
        Me.LbTipo.TabIndex = 100315
        '
        'LbTotalKilos
        '
        Me.LbTotalKilos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTotalKilos.CL_ControlAsociado = Nothing
        Me.LbTotalKilos.CL_ValorFijo = True
        Me.LbTotalKilos.ClForm = Nothing
        Me.LbTotalKilos.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalKilos.ForeColor = System.Drawing.Color.Blue
        Me.LbTotalKilos.Location = New System.Drawing.Point(859, 515)
        Me.LbTotalKilos.Name = "LbTotalKilos"
        Me.LbTotalKilos.Size = New System.Drawing.Size(126, 18)
        Me.LbTotalKilos.TabIndex = 149
        Me.LbTotalKilos.Text = "0,00"
        Me.LbTotalKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbTotalImporte
        '
        Me.LbTotalImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTotalImporte.CL_ControlAsociado = Nothing
        Me.LbTotalImporte.CL_ValorFijo = True
        Me.LbTotalImporte.ClForm = Nothing
        Me.LbTotalImporte.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalImporte.ForeColor = System.Drawing.Color.Blue
        Me.LbTotalImporte.Location = New System.Drawing.Point(1172, 515)
        Me.LbTotalImporte.Name = "LbTotalImporte"
        Me.LbTotalImporte.Size = New System.Drawing.Size(126, 18)
        Me.LbTotalImporte.TabIndex = 148
        Me.LbTotalImporte.Text = "0,00"
        Me.LbTotalImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Blue
        Me.Lb7.Location = New System.Drawing.Point(1029, 515)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(132, 18)
        Me.Lb7.TabIndex = 147
        Me.Lb7.Text = "Total importe:"
        '
        'Lb31
        '
        Me.Lb31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb31.AutoSize = True
        Me.Lb31.CL_ControlAsociado = Nothing
        Me.Lb31.CL_ValorFijo = True
        Me.Lb31.ClForm = Nothing
        Me.Lb31.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb31.ForeColor = System.Drawing.Color.Blue
        Me.Lb31.Location = New System.Drawing.Point(756, 515)
        Me.Lb31.Name = "Lb31"
        Me.Lb31.Size = New System.Drawing.Size(103, 18)
        Me.Lb31.TabIndex = 146
        Me.Lb31.Text = "Total Kilos:"
        '
        'FrmCambioAgricultor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 575)
        Me.Controls.Add(Me.LbTotalKilos)
        Me.Controls.Add(Me.LbTotalImporte)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.Lb31)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCambioAgricultor"
        Me.Text = "Cambiar el agricultor del albarán"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb31, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.LbTotalImporte, 0)
        Me.Controls.SetChildIndex(Me.LbTotalKilos, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents BtBusca4 As NetAgro.BtBusca
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents BtBusca5 As NetAgro.BtBusca
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents LbTotalKilos As NetAgro.Lb
    Friend WithEvents LbTotalImporte As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb31 As NetAgro.Lb
End Class
