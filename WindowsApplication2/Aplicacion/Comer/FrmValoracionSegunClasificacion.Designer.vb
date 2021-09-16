<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoracionSegunClasificacion
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoracionSegunClasificacion))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.TxCentro = New NetAgro.TxDato(Me.components)
        Me.BtCentro = New NetAgro.BtBusca(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LbNomTipo = New NetAgro.Lb(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.BtBuscaValoracion = New NetAgro.BtBusca(Me.components)
        Me.LbValoracion = New NetAgro.Lb(Me.components)
        Me.TxValoracion = New NetAgro.TxDato(Me.components)
        Me.LbFechaValoracion = New NetAgro.Lb(Me.components)
        Me.TxFechaValoracion = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.CbCentrosRecogida = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxAgricultorHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAg2 = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.TxAgricultorDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAg1 = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelKilos = New System.Windows.Forms.Panel()
        Me.GridKilos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewKilos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGenero = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbNomCategoria = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.TxPrecio = New NetAgro.TxDato(Me.components)
        Me.Lbuds_1 = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.CbCentrosRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelKilos.SuspendLayout()
        CType(Me.GridKilos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewKilos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.LbNomCentro)
        Me.Panel4.Controls.Add(Me.TxCentro)
        Me.Panel4.Controls.Add(Me.BtCentro)
        Me.Panel4.Controls.Add(Me.LbCentro)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.LbNomTipo)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Barra)
        Me.Panel4.Controls.Add(Me.BtBuscaValoracion)
        Me.Panel4.Controls.Add(Me.LbValoracion)
        Me.Panel4.Controls.Add(Me.TxValoracion)
        Me.Panel4.Controls.Add(Me.LbFechaValoracion)
        Me.Panel4.Controls.Add(Me.TxFechaValoracion)
        Me.Panel4.Controls.Add(Me.Lb2)
        Me.Panel4.Controls.Add(Me.CbCentrosRecogida)
        Me.Panel4.Controls.Add(Me.LbNomAgricultorHasta)
        Me.Panel4.Controls.Add(Me.TxAgricultorHasta)
        Me.Panel4.Controls.Add(Me.BtBuscaAg2)
        Me.Panel4.Controls.Add(Me.LbHastaAgricultor)
        Me.Panel4.Controls.Add(Me.LbNomAgricultorDesde)
        Me.Panel4.Controls.Add(Me.TxAgricultorDesde)
        Me.Panel4.Controls.Add(Me.BtBuscaAg1)
        Me.Panel4.Controls.Add(Me.LbDesdeAgricultor)
        Me.Panel4.Controls.Add(Me.LbHastaFecha)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.TxFechaHasta)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.LbSemana)
        Me.Panel4.Controls.Add(Me.TxSemana)
        Me.Panel4.Controls.Add(Me.LbDesdeFecha)
        Me.Panel4.Controls.Add(Me.TxFechaDesde)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1204, 153)
        Me.Panel4.TabIndex = 72
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = False
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentro.Location = New System.Drawing.Point(666, 18)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(221, 23)
        Me.LbNomCentro.TabIndex = 100327
        '
        'TxCentro
        '
        Me.TxCentro.Autonumerico = False
        Me.TxCentro.Buscando = False
        Me.TxCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentro.ClForm = Nothing
        Me.TxCentro.ClParam = Nothing
        Me.TxCentro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentro.GridLin = Nothing
        Me.TxCentro.HaCambiado = False
        Me.TxCentro.lbbusca = Nothing
        Me.TxCentro.Location = New System.Drawing.Point(558, 18)
        Me.TxCentro.MiError = False
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.Orden = 0
        Me.TxCentro.SaltoAlfinal = False
        Me.TxCentro.Siguiente = 0
        Me.TxCentro.Size = New System.Drawing.Size(63, 22)
        Me.TxCentro.TabIndex = 100326
        Me.TxCentro.TeclaRepetida = False
        Me.TxCentro.TxDatoFinalSemana = Nothing
        Me.TxCentro.TxDatoInicioSemana = Nothing
        Me.TxCentro.UltimoValorValidado = Nothing
        '
        'BtCentro
        '
        Me.BtCentro.CL_Ancho = 0
        Me.BtCentro.CL_BuscaAlb = False
        Me.BtCentro.CL_campocodigo = Nothing
        Me.BtCentro.CL_camponombre = Nothing
        Me.BtCentro.CL_CampoOrden = "Nombre"
        Me.BtCentro.CL_ch1000 = False
        Me.BtCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtCentro.CL_ControlAsociado = Nothing
        Me.BtCentro.CL_DevuelveCampo = "Idfamilia"
        Me.BtCentro.CL_dfecha = Nothing
        Me.BtCentro.CL_Entidad = Nothing
        Me.BtCentro.CL_EsId = True
        Me.BtCentro.CL_Filtro = Nothing
        Me.BtCentro.cl_formu = Nothing
        Me.BtCentro.CL_hfecha = Nothing
        Me.BtCentro.cl_ListaW = Nothing
        Me.BtCentro.CL_xCentro = False
        Me.BtCentro.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtCentro.Location = New System.Drawing.Point(627, 18)
        Me.BtCentro.Name = "BtCentro"
        Me.BtCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtCentro.TabIndex = 100325
        Me.BtCentro.UseVisualStyleBackColor = True
        '
        'LbCentro
        '
        Me.LbCentro.AutoSize = True
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = False
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(486, 21)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(57, 16)
        Me.LbCentro.TabIndex = 100324
        Me.LbCentro.Text = "Centro"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1049, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 23)
        Me.Button4.TabIndex = 100323
        Me.Button4.Text = "VER ALBARANES"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LbNomTipo
        '
        Me.LbNomTipo.AutoSize = True
        Me.LbNomTipo.CL_ControlAsociado = Nothing
        Me.LbNomTipo.CL_ValorFijo = True
        Me.LbNomTipo.ClForm = Nothing
        Me.LbNomTipo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomTipo.Location = New System.Drawing.Point(677, 55)
        Me.LbNomTipo.Name = "LbNomTipo"
        Me.LbNomTipo.Size = New System.Drawing.Size(0, 18)
        Me.LbNomTipo.TabIndex = 100322
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(906, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 23)
        Me.Button3.TabIndex = 100321
        Me.Button3.Text = "VALORAR ALBARANES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(906, 115)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(292, 23)
        Me.Barra.TabIndex = 2
        '
        'BtBuscaValoracion
        '
        Me.BtBuscaValoracion.CL_Ancho = 0
        Me.BtBuscaValoracion.CL_BuscaAlb = False
        Me.BtBuscaValoracion.CL_campocodigo = Nothing
        Me.BtBuscaValoracion.CL_camponombre = Nothing
        Me.BtBuscaValoracion.CL_CampoOrden = "Nombre"
        Me.BtBuscaValoracion.CL_ch1000 = False
        Me.BtBuscaValoracion.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaValoracion.CL_ControlAsociado = Nothing
        Me.BtBuscaValoracion.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaValoracion.CL_dfecha = Nothing
        Me.BtBuscaValoracion.CL_Entidad = Nothing
        Me.BtBuscaValoracion.CL_EsId = True
        Me.BtBuscaValoracion.CL_Filtro = Nothing
        Me.BtBuscaValoracion.cl_formu = Nothing
        Me.BtBuscaValoracion.CL_hfecha = Nothing
        Me.BtBuscaValoracion.cl_ListaW = Nothing
        Me.BtBuscaValoracion.CL_xCentro = False
        Me.BtBuscaValoracion.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaValoracion.Location = New System.Drawing.Point(185, 18)
        Me.BtBuscaValoracion.Name = "BtBuscaValoracion"
        Me.BtBuscaValoracion.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaValoracion.TabIndex = 100320
        Me.BtBuscaValoracion.UseVisualStyleBackColor = True
        '
        'LbValoracion
        '
        Me.LbValoracion.AutoSize = True
        Me.LbValoracion.CL_ControlAsociado = Nothing
        Me.LbValoracion.CL_ValorFijo = False
        Me.LbValoracion.ClForm = Nothing
        Me.LbValoracion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValoracion.ForeColor = System.Drawing.Color.Teal
        Me.LbValoracion.Location = New System.Drawing.Point(16, 21)
        Me.LbValoracion.Name = "LbValoracion"
        Me.LbValoracion.Size = New System.Drawing.Size(85, 16)
        Me.LbValoracion.TabIndex = 100318
        Me.LbValoracion.Text = "Valoracion"
        '
        'TxValoracion
        '
        Me.TxValoracion.Autonumerico = False
        Me.TxValoracion.Buscando = False
        Me.TxValoracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxValoracion.ClForm = Nothing
        Me.TxValoracion.ClParam = Nothing
        Me.TxValoracion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxValoracion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxValoracion.GridLin = Nothing
        Me.TxValoracion.HaCambiado = False
        Me.TxValoracion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxValoracion.lbbusca = Nothing
        Me.TxValoracion.Location = New System.Drawing.Point(119, 18)
        Me.TxValoracion.MiError = False
        Me.TxValoracion.Name = "TxValoracion"
        Me.TxValoracion.Orden = 0
        Me.TxValoracion.SaltoAlfinal = False
        Me.TxValoracion.Siguiente = 0
        Me.TxValoracion.Size = New System.Drawing.Size(60, 22)
        Me.TxValoracion.TabIndex = 100317
        Me.TxValoracion.TeclaRepetida = False
        Me.TxValoracion.TxDatoFinalSemana = Nothing
        Me.TxValoracion.TxDatoInicioSemana = Nothing
        Me.TxValoracion.UltimoValorValidado = Nothing
        '
        'LbFechaValoracion
        '
        Me.LbFechaValoracion.AutoSize = True
        Me.LbFechaValoracion.CL_ControlAsociado = Nothing
        Me.LbFechaValoracion.CL_ValorFijo = False
        Me.LbFechaValoracion.ClForm = Nothing
        Me.LbFechaValoracion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaValoracion.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaValoracion.Location = New System.Drawing.Point(245, 21)
        Me.LbFechaValoracion.Name = "LbFechaValoracion"
        Me.LbFechaValoracion.Size = New System.Drawing.Size(102, 16)
        Me.LbFechaValoracion.TabIndex = 100316
        Me.LbFechaValoracion.Text = "F. valoración"
        '
        'TxFechaValoracion
        '
        Me.TxFechaValoracion.Autonumerico = False
        Me.TxFechaValoracion.Buscando = False
        Me.TxFechaValoracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaValoracion.ClForm = Nothing
        Me.TxFechaValoracion.ClParam = Nothing
        Me.TxFechaValoracion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaValoracion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaValoracion.GridLin = Nothing
        Me.TxFechaValoracion.HaCambiado = False
        Me.TxFechaValoracion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaValoracion.lbbusca = Nothing
        Me.TxFechaValoracion.Location = New System.Drawing.Point(355, 18)
        Me.TxFechaValoracion.MiError = False
        Me.TxFechaValoracion.Name = "TxFechaValoracion"
        Me.TxFechaValoracion.Orden = 0
        Me.TxFechaValoracion.SaltoAlfinal = False
        Me.TxFechaValoracion.Siguiente = 0
        Me.TxFechaValoracion.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaValoracion.TabIndex = 100315
        Me.TxFechaValoracion.TeclaRepetida = False
        Me.TxFechaValoracion.TxDatoFinalSemana = Nothing
        Me.TxFechaValoracion.TxDatoInicioSemana = Nothing
        Me.TxFechaValoracion.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(243, 58)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(124, 16)
        Me.Lb2.TabIndex = 100314
        Me.Lb2.Text = "Centro recogida"
        '
        'CbCentrosRecogida
        '
        Me.CbCentrosRecogida.EditValue = ""
        Me.CbCentrosRecogida.Location = New System.Drawing.Point(373, 56)
        Me.CbCentrosRecogida.Name = "CbCentrosRecogida"
        Me.CbCentrosRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentrosRecogida.Size = New System.Drawing.Size(289, 20)
        Me.CbCentrosRecogida.TabIndex = 100313
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(472, 115)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(419, 23)
        Me.LbNomAgricultorHasta.TabIndex = 100291
        '
        'TxAgricultorHasta
        '
        Me.TxAgricultorHasta.Autonumerico = False
        Me.TxAgricultorHasta.Buscando = False
        Me.TxAgricultorHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorHasta.ClForm = Nothing
        Me.TxAgricultorHasta.ClParam = Nothing
        Me.TxAgricultorHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorHasta.GridLin = Nothing
        Me.TxAgricultorHasta.HaCambiado = False
        Me.TxAgricultorHasta.lbbusca = Nothing
        Me.TxAgricultorHasta.Location = New System.Drawing.Point(355, 115)
        Me.TxAgricultorHasta.MiError = False
        Me.TxAgricultorHasta.Name = "TxAgricultorHasta"
        Me.TxAgricultorHasta.Orden = 0
        Me.TxAgricultorHasta.SaltoAlfinal = False
        Me.TxAgricultorHasta.Siguiente = 0
        Me.TxAgricultorHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorHasta.TabIndex = 100290
        Me.TxAgricultorHasta.TeclaRepetida = False
        Me.TxAgricultorHasta.TxDatoFinalSemana = Nothing
        Me.TxAgricultorHasta.TxDatoInicioSemana = Nothing
        Me.TxAgricultorHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaAg2
        '
        Me.BtBuscaAg2.CL_Ancho = 0
        Me.BtBuscaAg2.CL_BuscaAlb = False
        Me.BtBuscaAg2.CL_campocodigo = Nothing
        Me.BtBuscaAg2.CL_camponombre = Nothing
        Me.BtBuscaAg2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAg2.CL_ch1000 = False
        Me.BtBuscaAg2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAg2.CL_ControlAsociado = Nothing
        Me.BtBuscaAg2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAg2.CL_dfecha = Nothing
        Me.BtBuscaAg2.CL_Entidad = Nothing
        Me.BtBuscaAg2.CL_EsId = True
        Me.BtBuscaAg2.CL_Filtro = Nothing
        Me.BtBuscaAg2.cl_formu = Nothing
        Me.BtBuscaAg2.CL_hfecha = Nothing
        Me.BtBuscaAg2.cl_ListaW = Nothing
        Me.BtBuscaAg2.CL_xCentro = False
        Me.BtBuscaAg2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAg2.Location = New System.Drawing.Point(427, 115)
        Me.BtBuscaAg2.Name = "BtBuscaAg2"
        Me.BtBuscaAg2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAg2.TabIndex = 100289
        Me.BtBuscaAg2.UseVisualStyleBackColor = True
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(245, 118)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(92, 16)
        Me.LbHastaAgricultor.TabIndex = 100288
        Me.LbHastaAgricultor.Text = "A agricultor"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(472, 87)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(419, 23)
        Me.LbNomAgricultorDesde.TabIndex = 100287
        '
        'TxAgricultorDesde
        '
        Me.TxAgricultorDesde.Autonumerico = False
        Me.TxAgricultorDesde.Buscando = False
        Me.TxAgricultorDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorDesde.ClForm = Nothing
        Me.TxAgricultorDesde.ClParam = Nothing
        Me.TxAgricultorDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorDesde.GridLin = Nothing
        Me.TxAgricultorDesde.HaCambiado = False
        Me.TxAgricultorDesde.lbbusca = Nothing
        Me.TxAgricultorDesde.Location = New System.Drawing.Point(355, 87)
        Me.TxAgricultorDesde.MiError = False
        Me.TxAgricultorDesde.Name = "TxAgricultorDesde"
        Me.TxAgricultorDesde.Orden = 0
        Me.TxAgricultorDesde.SaltoAlfinal = False
        Me.TxAgricultorDesde.Siguiente = 0
        Me.TxAgricultorDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorDesde.TabIndex = 100286
        Me.TxAgricultorDesde.TeclaRepetida = False
        Me.TxAgricultorDesde.TxDatoFinalSemana = Nothing
        Me.TxAgricultorDesde.TxDatoInicioSemana = Nothing
        Me.TxAgricultorDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaAg1
        '
        Me.BtBuscaAg1.CL_Ancho = 0
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
        Me.BtBuscaAg1.CL_EsId = True
        Me.BtBuscaAg1.CL_Filtro = Nothing
        Me.BtBuscaAg1.cl_formu = Nothing
        Me.BtBuscaAg1.CL_hfecha = Nothing
        Me.BtBuscaAg1.cl_ListaW = Nothing
        Me.BtBuscaAg1.CL_xCentro = False
        Me.BtBuscaAg1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAg1.Location = New System.Drawing.Point(427, 87)
        Me.BtBuscaAg1.Name = "BtBuscaAg1"
        Me.BtBuscaAg1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAg1.TabIndex = 100285
        Me.BtBuscaAg1.UseVisualStyleBackColor = True
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(245, 90)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(101, 16)
        Me.LbDesdeAgricultor.TabIndex = 100284
        Me.LbDesdeAgricultor.Text = "De agricultor"
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(15, 118)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 100283
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(835, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 153
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'TxFechaHasta
        '
        Me.TxFechaHasta.Autonumerico = False
        Me.TxFechaHasta.Buscando = False
        Me.TxFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaHasta.ClForm = Nothing
        Me.TxFechaHasta.ClParam = Nothing
        Me.TxFechaHasta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaHasta.GridLin = Nothing
        Me.TxFechaHasta.HaCambiado = False
        Me.TxFechaHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaHasta.lbbusca = Nothing
        Me.TxFechaHasta.Location = New System.Drawing.Point(118, 115)
        Me.TxFechaHasta.MiError = False
        Me.TxFechaHasta.Name = "TxFechaHasta"
        Me.TxFechaHasta.Orden = 0
        Me.TxFechaHasta.SaltoAlfinal = False
        Me.TxFechaHasta.Siguiente = 0
        Me.TxFechaHasta.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaHasta.TabIndex = 100282
        Me.TxFechaHasta.TeclaRepetida = False
        Me.TxFechaHasta.TxDatoFinalSemana = Nothing
        Me.TxFechaHasta.TxDatoInicioSemana = Nothing
        Me.TxFechaHasta.UltimoValorValidado = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(813, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(15, 59)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100281
        Me.LbSemana.Text = "Semana"
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(118, 56)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(43, 22)
        Me.TxSemana.TabIndex = 100280
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(15, 90)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 100279
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'TxFechaDesde
        '
        Me.TxFechaDesde.Autonumerico = False
        Me.TxFechaDesde.Buscando = False
        Me.TxFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaDesde.ClForm = Nothing
        Me.TxFechaDesde.ClParam = Nothing
        Me.TxFechaDesde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaDesde.GridLin = Nothing
        Me.TxFechaDesde.HaCambiado = False
        Me.TxFechaDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaDesde.lbbusca = Nothing
        Me.TxFechaDesde.Location = New System.Drawing.Point(118, 87)
        Me.TxFechaDesde.MiError = False
        Me.TxFechaDesde.Name = "TxFechaDesde"
        Me.TxFechaDesde.Orden = 0
        Me.TxFechaDesde.SaltoAlfinal = False
        Me.TxFechaDesde.Siguiente = 0
        Me.TxFechaDesde.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaDesde.TabIndex = 100278
        Me.TxFechaDesde.TeclaRepetida = False
        Me.TxFechaDesde.TxDatoFinalSemana = Nothing
        Me.TxFechaDesde.TxDatoInicioSemana = Nothing
        Me.TxFechaDesde.UltimoValorValidado = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PanelKilos)
        Me.Panel2.Controls.Add(Me.LbGenero)
        Me.Panel2.Controls.Add(Me.LbNomGenero)
        Me.Panel2.Controls.Add(Me.Lb10)
        Me.Panel2.Controls.Add(Me.LbCategoria)
        Me.Panel2.Controls.Add(Me.LbKilos)
        Me.Panel2.Controls.Add(Me.Lb7)
        Me.Panel2.Controls.Add(Me.LbImporte)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.LbNomCategoria)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Controls.Add(Me.TxPrecio)
        Me.Panel2.Controls.Add(Me.Lbuds_1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 410)
        Me.Panel2.TabIndex = 128
        '
        'PanelKilos
        '
        Me.PanelKilos.Controls.Add(Me.GridKilos)
        Me.PanelKilos.Controls.Add(Me.Label2)
        Me.PanelKilos.Controls.Add(Me.Panel5)
        Me.PanelKilos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelKilos.Location = New System.Drawing.Point(823, 0)
        Me.PanelKilos.Name = "PanelKilos"
        Me.PanelKilos.Size = New System.Drawing.Size(377, 406)
        Me.PanelKilos.TabIndex = 158
        '
        'GridKilos
        '
        Me.GridKilos.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GridKilos.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridKilos.Location = New System.Drawing.Point(0, 16)
        Me.GridKilos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridKilos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridKilos.MainView = Me.GridViewKilos
        Me.GridKilos.Name = "GridKilos"
        Me.GridKilos.Size = New System.Drawing.Size(377, 358)
        Me.GridKilos.TabIndex = 72
        Me.GridKilos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewKilos})
        '
        'GridViewKilos
        '
        Me.GridViewKilos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewKilos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewKilos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewKilos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewKilos.Appearance.Row.Options.UseFont = True
        Me.GridViewKilos.GridControl = Me.GridKilos
        Me.GridViewKilos.Name = "GridViewKilos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Generos pendientes de valorar"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 374)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(377, 32)
        Me.Panel5.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(236, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Introducir precios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbGenero
        '
        Me.LbGenero.BackColor = System.Drawing.Color.White
        Me.LbGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = False
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(95, 17)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(53, 22)
        Me.LbGenero.TabIndex = 156
        Me.LbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbNomGenero
        '
        Me.LbNomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGenero.CL_ControlAsociado = Nothing
        Me.LbNomGenero.CL_ValorFijo = False
        Me.LbNomGenero.ClForm = Nothing
        Me.LbNomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGenero.Location = New System.Drawing.Point(154, 17)
        Me.LbNomGenero.Name = "LbNomGenero"
        Me.LbNomGenero.Size = New System.Drawing.Size(662, 23)
        Me.LbNomGenero.TabIndex = 155
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(10, 20)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(60, 16)
        Me.Lb10.TabIndex = 154
        Me.Lb10.Text = "Genero"
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.Color.White
        Me.LbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = False
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Teal
        Me.LbCategoria.Location = New System.Drawing.Point(95, 66)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(53, 22)
        Me.LbCategoria.TabIndex = 150
        Me.LbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbKilos
        '
        Me.LbKilos.BackColor = System.Drawing.Color.White
        Me.LbKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(491, 66)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(90, 22)
        Me.LbKilos.TabIndex = 149
        Me.LbKilos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(723, 47)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(67, 16)
        Me.Lb7.TabIndex = 148
        Me.Lb7.Text = "Importe"
        '
        'LbImporte
        '
        Me.LbImporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbImporte.Location = New System.Drawing.Point(689, 66)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(127, 23)
        Me.LbImporte.TabIndex = 147
        Me.LbImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(618, 47)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(53, 16)
        Me.Lb5.TabIndex = 145
        Me.Lb5.Text = "Precio"
        '
        'LbNomCategoria
        '
        Me.LbNomCategoria.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategoria.CL_ControlAsociado = Nothing
        Me.LbNomCategoria.CL_ValorFijo = False
        Me.LbNomCategoria.ClForm = Nothing
        Me.LbNomCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategoria.Location = New System.Drawing.Point(154, 66)
        Me.LbNomCategoria.Name = "LbNomCategoria"
        Me.LbNomCategoria.Size = New System.Drawing.Size(306, 23)
        Me.LbNomCategoria.TabIndex = 143
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(10, 69)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(79, 16)
        Me.Lb4.TabIndex = 141
        Me.Lb4.Text = "Categoria"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(10, 110)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(806, 261)
        Me.ClGrid1.TabIndex = 109
        Me.ClGrid1.UltimoControl = 0
        '
        'TxPrecio
        '
        Me.TxPrecio.Autonumerico = False
        Me.TxPrecio.Buscando = False
        Me.TxPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPrecio.ClForm = Nothing
        Me.TxPrecio.ClParam = Nothing
        Me.TxPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPrecio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPrecio.GridLin = Nothing
        Me.TxPrecio.HaCambiado = False
        Me.TxPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPrecio.lbbusca = Nothing
        Me.TxPrecio.Location = New System.Drawing.Point(587, 66)
        Me.TxPrecio.MiError = False
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Orden = 0
        Me.TxPrecio.SaltoAlfinal = False
        Me.TxPrecio.Siguiente = 0
        Me.TxPrecio.Size = New System.Drawing.Size(90, 22)
        Me.TxPrecio.TabIndex = 133
        Me.TxPrecio.TeclaRepetida = False
        Me.TxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPrecio.TxDatoFinalSemana = Nothing
        Me.TxPrecio.TxDatoInicioSemana = Nothing
        Me.TxPrecio.UltimoValorValidado = Nothing
        '
        'Lbuds_1
        '
        Me.Lbuds_1.AutoSize = True
        Me.Lbuds_1.CL_ControlAsociado = Nothing
        Me.Lbuds_1.CL_ValorFijo = True
        Me.Lbuds_1.ClForm = Nothing
        Me.Lbuds_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbuds_1.ForeColor = System.Drawing.Color.Teal
        Me.Lbuds_1.Location = New System.Drawing.Point(522, 47)
        Me.Lbuds_1.Name = "Lbuds_1"
        Me.Lbuds_1.Size = New System.Drawing.Size(46, 16)
        Me.Lbuds_1.TabIndex = 126
        Me.Lbuds_1.Text = "Kilos "
        '
        'FrmValoracionSegunClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 598)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValoracionSegunClasificacion"
        Me.Text = "Valoración entradas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.CbCentrosRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelKilos.ResumeLayout(False)
        Me.PanelKilos.PerformLayout()
        CType(Me.GridKilos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewKilos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbNomCategoria As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxPrecio As NetAgro.TxDato
    Friend WithEvents Lbuds_1 As NetAgro.Lb
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxAgricultorHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAg2 As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents TxAgricultorDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAg1 As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents CbCentrosRecogida As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents LbNomGenero As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbFechaValoracion As NetAgro.Lb
    Friend WithEvents TxFechaValoracion As NetAgro.TxDato
    Friend WithEvents LbValoracion As NetAgro.Lb
    Friend WithEvents TxValoracion As NetAgro.TxDato
    Friend WithEvents BtBuscaValoracion As NetAgro.BtBusca
    Friend WithEvents PanelKilos As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GridKilos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewKilos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LbNomTipo As NetAgro.Lb
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents TxCentro As NetAgro.TxDato
    Friend WithEvents BtCentro As NetAgro.BtBusca
    Friend WithEvents LbCentro As NetAgro.Lb

End Class
