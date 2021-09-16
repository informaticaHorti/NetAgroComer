<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfecGenero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfecGenero))
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaMarcaEti = New NetAgro.BtBusca(Me.components)
        Me.LbMarcaEti = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.TxDato16 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarcaMat = New NetAgro.BtBusca(Me.components)
        Me.LbMarcaMat = New NetAgro.Lb(Me.components)
        Me.Lb27 = New NetAgro.Lb(Me.components)
        Me.TxDato15 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarcaEnv = New NetAgro.BtBusca(Me.components)
        Me.LbMarcaEnv = New NetAgro.Lb(Me.components)
        Me.Lb22 = New NetAgro.Lb(Me.components)
        Me.TxDato13 = New NetAgro.TxDato(Me.components)
        Me.LbTcosteBulto = New NetAgro.Lb(Me.components)
        Me.Lb20 = New NetAgro.Lb(Me.components)
        Me.LbTcosteKilo = New NetAgro.Lb(Me.components)
        Me.Lb21 = New NetAgro.Lb(Me.components)
        Me.LbCosteConf = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.Lb24 = New NetAgro.Lb(Me.components)
        Me.Lb25 = New NetAgro.Lb(Me.components)
        Me.TxDato14 = New NetAgro.TxDato(Me.components)
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.TxDato12 = New NetAgro.TxDato(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.ChActivo = New NetAgro.Chk(Me.components)
        Me.ChPesoFijo = New NetAgro.Chk(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaConfec = New NetAgro.BtBusca(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb18 = New NetAgro.Lb(Me.components)
        Me.ChMarcas = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.ChCategoria = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ChMarcaMatPal = New NetAgro.Chk(Me.components)
        Me.ChMarcaEtiPal = New NetAgro.Chk(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato20 = New NetAgro.TxDato(Me.components)
        Me.LbGastoManiGenero = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.chkGeneroQS = New NetAgro.Chk(Me.components)
        Me.chkDemeter = New NetAgro.Chk(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(224, 18)
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
        Me.BtBuscaGenero.Location = New System.Drawing.Point(185, 18)
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
        Me.TxDato1.Location = New System.Drawing.Point(116, 18)
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
        Me.Lb2.Location = New System.Drawing.Point(359, 21)
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
        Me.Lb1.Location = New System.Drawing.Point(15, 21)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 31
        Me.Lb1.Text = "Código"
        '
        'BtBuscaMarcaEti
        '
        Me.BtBuscaMarcaEti.CL_Ancho = 0
        Me.BtBuscaMarcaEti.CL_BuscaAlb = False
        Me.BtBuscaMarcaEti.CL_campocodigo = Nothing
        Me.BtBuscaMarcaEti.CL_camponombre = Nothing
        Me.BtBuscaMarcaEti.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarcaEti.CL_ch1000 = False
        Me.BtBuscaMarcaEti.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarcaEti.CL_ControlAsociado = Nothing
        Me.BtBuscaMarcaEti.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarcaEti.CL_dfecha = Nothing
        Me.BtBuscaMarcaEti.CL_Entidad = Nothing
        Me.BtBuscaMarcaEti.CL_EsId = True
        Me.BtBuscaMarcaEti.CL_Filtro = Nothing
        Me.BtBuscaMarcaEti.cl_formu = Nothing
        Me.BtBuscaMarcaEti.CL_hfecha = Nothing
        Me.BtBuscaMarcaEti.cl_ListaW = Nothing
        Me.BtBuscaMarcaEti.CL_xCentro = False
        Me.BtBuscaMarcaEti.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMarcaEti.Location = New System.Drawing.Point(626, 243)
        Me.BtBuscaMarcaEti.Name = "BtBuscaMarcaEti"
        Me.BtBuscaMarcaEti.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarcaEti.TabIndex = 254
        Me.BtBuscaMarcaEti.UseVisualStyleBackColor = True
        '
        'LbMarcaEti
        '
        Me.LbMarcaEti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMarcaEti.CL_ControlAsociado = Nothing
        Me.LbMarcaEti.CL_ValorFijo = False
        Me.LbMarcaEti.ClForm = Nothing
        Me.LbMarcaEti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbMarcaEti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaEti.Location = New System.Drawing.Point(453, 269)
        Me.LbMarcaEti.Name = "LbMarcaEti"
        Me.LbMarcaEti.Size = New System.Drawing.Size(204, 23)
        Me.LbMarcaEti.TabIndex = 253
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = False
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(455, 246)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(125, 16)
        Me.Lb29.TabIndex = 252
        Me.Lb29.Text = "Marca Etiquetas"
        '
        'TxDato16
        '
        Me.TxDato16.Autonumerico = False
        Me.TxDato16.Buscando = False
        Me.TxDato16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato16.ClForm = Nothing
        Me.TxDato16.ClParam = Nothing
        Me.TxDato16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato16.GridLin = Nothing
        Me.TxDato16.HaCambiado = False
        Me.TxDato16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato16.lbbusca = Nothing
        Me.TxDato16.Location = New System.Drawing.Point(583, 243)
        Me.TxDato16.MiError = False
        Me.TxDato16.Name = "TxDato16"
        Me.TxDato16.Orden = 0
        Me.TxDato16.SaltoAlfinal = False
        Me.TxDato16.Siguiente = 0
        Me.TxDato16.Size = New System.Drawing.Size(37, 23)
        Me.TxDato16.TabIndex = 251
        Me.TxDato16.TeclaRepetida = False
        Me.TxDato16.TxDatoFinalSemana = Nothing
        Me.TxDato16.TxDatoInicioSemana = Nothing
        Me.TxDato16.UltimoValorValidado = Nothing
        '
        'BtBuscaMarcaMat
        '
        Me.BtBuscaMarcaMat.CL_Ancho = 0
        Me.BtBuscaMarcaMat.CL_BuscaAlb = False
        Me.BtBuscaMarcaMat.CL_campocodigo = Nothing
        Me.BtBuscaMarcaMat.CL_camponombre = Nothing
        Me.BtBuscaMarcaMat.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarcaMat.CL_ch1000 = False
        Me.BtBuscaMarcaMat.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarcaMat.CL_ControlAsociado = Nothing
        Me.BtBuscaMarcaMat.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarcaMat.CL_dfecha = Nothing
        Me.BtBuscaMarcaMat.CL_Entidad = Nothing
        Me.BtBuscaMarcaMat.CL_EsId = True
        Me.BtBuscaMarcaMat.CL_Filtro = Nothing
        Me.BtBuscaMarcaMat.cl_formu = Nothing
        Me.BtBuscaMarcaMat.CL_hfecha = Nothing
        Me.BtBuscaMarcaMat.cl_ListaW = Nothing
        Me.BtBuscaMarcaMat.CL_xCentro = False
        Me.BtBuscaMarcaMat.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMarcaMat.Location = New System.Drawing.Point(404, 243)
        Me.BtBuscaMarcaMat.Name = "BtBuscaMarcaMat"
        Me.BtBuscaMarcaMat.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarcaMat.TabIndex = 250
        Me.BtBuscaMarcaMat.UseVisualStyleBackColor = True
        '
        'LbMarcaMat
        '
        Me.LbMarcaMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMarcaMat.CL_ControlAsociado = Nothing
        Me.LbMarcaMat.CL_ValorFijo = False
        Me.LbMarcaMat.ClForm = Nothing
        Me.LbMarcaMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbMarcaMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaMat.Location = New System.Drawing.Point(236, 269)
        Me.LbMarcaMat.Name = "LbMarcaMat"
        Me.LbMarcaMat.Size = New System.Drawing.Size(201, 23)
        Me.LbMarcaMat.TabIndex = 249
        '
        'Lb27
        '
        Me.Lb27.AutoSize = True
        Me.Lb27.CL_ControlAsociado = Nothing
        Me.Lb27.CL_ValorFijo = False
        Me.Lb27.ClForm = Nothing
        Me.Lb27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb27.ForeColor = System.Drawing.Color.Teal
        Me.Lb27.Location = New System.Drawing.Point(233, 246)
        Me.Lb27.Name = "Lb27"
        Me.Lb27.Size = New System.Drawing.Size(115, 16)
        Me.Lb27.TabIndex = 248
        Me.Lb27.Text = "Marca Material"
        '
        'TxDato15
        '
        Me.TxDato15.Autonumerico = False
        Me.TxDato15.Buscando = False
        Me.TxDato15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato15.ClForm = Nothing
        Me.TxDato15.ClParam = Nothing
        Me.TxDato15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato15.GridLin = Nothing
        Me.TxDato15.HaCambiado = False
        Me.TxDato15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato15.lbbusca = Nothing
        Me.TxDato15.Location = New System.Drawing.Point(361, 243)
        Me.TxDato15.MiError = False
        Me.TxDato15.Name = "TxDato15"
        Me.TxDato15.Orden = 0
        Me.TxDato15.SaltoAlfinal = False
        Me.TxDato15.Siguiente = 0
        Me.TxDato15.Size = New System.Drawing.Size(37, 23)
        Me.TxDato15.TabIndex = 247
        Me.TxDato15.TeclaRepetida = False
        Me.TxDato15.TxDatoFinalSemana = Nothing
        Me.TxDato15.TxDatoInicioSemana = Nothing
        Me.TxDato15.UltimoValorValidado = Nothing
        '
        'BtBuscaMarcaEnv
        '
        Me.BtBuscaMarcaEnv.CL_Ancho = 0
        Me.BtBuscaMarcaEnv.CL_BuscaAlb = False
        Me.BtBuscaMarcaEnv.CL_campocodigo = Nothing
        Me.BtBuscaMarcaEnv.CL_camponombre = Nothing
        Me.BtBuscaMarcaEnv.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarcaEnv.CL_ch1000 = False
        Me.BtBuscaMarcaEnv.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarcaEnv.CL_ControlAsociado = Nothing
        Me.BtBuscaMarcaEnv.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarcaEnv.CL_dfecha = Nothing
        Me.BtBuscaMarcaEnv.CL_Entidad = Nothing
        Me.BtBuscaMarcaEnv.CL_EsId = True
        Me.BtBuscaMarcaEnv.CL_Filtro = Nothing
        Me.BtBuscaMarcaEnv.cl_formu = Nothing
        Me.BtBuscaMarcaEnv.CL_hfecha = Nothing
        Me.BtBuscaMarcaEnv.cl_ListaW = Nothing
        Me.BtBuscaMarcaEnv.CL_xCentro = False
        Me.BtBuscaMarcaEnv.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMarcaEnv.Location = New System.Drawing.Point(186, 243)
        Me.BtBuscaMarcaEnv.Name = "BtBuscaMarcaEnv"
        Me.BtBuscaMarcaEnv.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarcaEnv.TabIndex = 246
        Me.BtBuscaMarcaEnv.UseVisualStyleBackColor = True
        '
        'LbMarcaEnv
        '
        Me.LbMarcaEnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbMarcaEnv.CL_ControlAsociado = Nothing
        Me.LbMarcaEnv.CL_ValorFijo = False
        Me.LbMarcaEnv.ClForm = Nothing
        Me.LbMarcaEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbMarcaEnv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaEnv.Location = New System.Drawing.Point(17, 269)
        Me.LbMarcaEnv.Name = "LbMarcaEnv"
        Me.LbMarcaEnv.Size = New System.Drawing.Size(202, 23)
        Me.LbMarcaEnv.TabIndex = 245
        '
        'Lb22
        '
        Me.Lb22.AutoSize = True
        Me.Lb22.CL_ControlAsociado = Nothing
        Me.Lb22.CL_ValorFijo = False
        Me.Lb22.ClForm = Nothing
        Me.Lb22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb22.ForeColor = System.Drawing.Color.Teal
        Me.Lb22.Location = New System.Drawing.Point(15, 246)
        Me.Lb22.Name = "Lb22"
        Me.Lb22.Size = New System.Drawing.Size(109, 16)
        Me.Lb22.TabIndex = 244
        Me.Lb22.Text = "Marca Envase"
        '
        'TxDato13
        '
        Me.TxDato13.Autonumerico = False
        Me.TxDato13.Buscando = False
        Me.TxDato13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato13.ClForm = Nothing
        Me.TxDato13.ClParam = Nothing
        Me.TxDato13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato13.GridLin = Nothing
        Me.TxDato13.HaCambiado = False
        Me.TxDato13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato13.lbbusca = Nothing
        Me.TxDato13.Location = New System.Drawing.Point(143, 243)
        Me.TxDato13.MiError = False
        Me.TxDato13.Name = "TxDato13"
        Me.TxDato13.Orden = 0
        Me.TxDato13.SaltoAlfinal = False
        Me.TxDato13.Siguiente = 0
        Me.TxDato13.Size = New System.Drawing.Size(37, 23)
        Me.TxDato13.TabIndex = 243
        Me.TxDato13.TeclaRepetida = False
        Me.TxDato13.TxDatoFinalSemana = Nothing
        Me.TxDato13.TxDatoInicioSemana = Nothing
        Me.TxDato13.UltimoValorValidado = Nothing
        '
        'LbTcosteBulto
        '
        Me.LbTcosteBulto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbTcosteBulto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTcosteBulto.CL_ControlAsociado = Nothing
        Me.LbTcosteBulto.CL_ValorFijo = True
        Me.LbTcosteBulto.ClForm = Nothing
        Me.LbTcosteBulto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTcosteBulto.ForeColor = System.Drawing.Color.Blue
        Me.LbTcosteBulto.Location = New System.Drawing.Point(673, 175)
        Me.LbTcosteBulto.Name = "LbTcosteBulto"
        Me.LbTcosteBulto.Size = New System.Drawing.Size(92, 23)
        Me.LbTcosteBulto.TabIndex = 238
        Me.LbTcosteBulto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb20
        '
        Me.Lb20.AutoSize = True
        Me.Lb20.CL_ControlAsociado = Nothing
        Me.Lb20.CL_ValorFijo = True
        Me.Lb20.ClForm = Nothing
        Me.Lb20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb20.ForeColor = System.Drawing.Color.Teal
        Me.Lb20.Location = New System.Drawing.Point(527, 179)
        Me.Lb20.Name = "Lb20"
        Me.Lb20.Size = New System.Drawing.Size(142, 16)
        Me.Lb20.TabIndex = 237
        Me.Lb20.Text = "Total coste x bulto"
        '
        'LbTcosteKilo
        '
        Me.LbTcosteKilo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbTcosteKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTcosteKilo.CL_ControlAsociado = Nothing
        Me.LbTcosteKilo.CL_ValorFijo = True
        Me.LbTcosteKilo.ClForm = Nothing
        Me.LbTcosteKilo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTcosteKilo.ForeColor = System.Drawing.Color.Blue
        Me.LbTcosteKilo.Location = New System.Drawing.Point(673, 204)
        Me.LbTcosteKilo.Name = "LbTcosteKilo"
        Me.LbTcosteKilo.Size = New System.Drawing.Size(92, 23)
        Me.LbTcosteKilo.TabIndex = 236
        Me.LbTcosteKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb21
        '
        Me.Lb21.AutoSize = True
        Me.Lb21.CL_ControlAsociado = Nothing
        Me.Lb21.CL_ValorFijo = True
        Me.Lb21.ClForm = Nothing
        Me.Lb21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb21.ForeColor = System.Drawing.Color.Teal
        Me.Lb21.Location = New System.Drawing.Point(527, 208)
        Me.Lb21.Name = "Lb21"
        Me.Lb21.Size = New System.Drawing.Size(130, 16)
        Me.Lb21.TabIndex = 235
        Me.Lb21.Text = "Total coste x kilo"
        '
        'LbCosteConf
        '
        Me.LbCosteConf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbCosteConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCosteConf.CL_ControlAsociado = Nothing
        Me.LbCosteConf.CL_ValorFijo = True
        Me.LbCosteConf.ClForm = Nothing
        Me.LbCosteConf.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCosteConf.Location = New System.Drawing.Point(226, 82)
        Me.LbCosteConf.Name = "LbCosteConf"
        Me.LbCosteConf.Size = New System.Drawing.Size(92, 23)
        Me.LbCosteConf.TabIndex = 234
        Me.LbCosteConf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(15, 85)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(190, 16)
        Me.Lb23.TabIndex = 233
        Me.Lb23.Text = "Gasto de Material x Bulto"
        '
        'Lb24
        '
        Me.Lb24.AutoSize = True
        Me.Lb24.CL_ControlAsociado = Nothing
        Me.Lb24.CL_ValorFijo = True
        Me.Lb24.ClForm = Nothing
        Me.Lb24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb24.ForeColor = System.Drawing.Color.Teal
        Me.Lb24.Location = New System.Drawing.Point(350, 223)
        Me.Lb24.Name = "Lb24"
        Me.Lb24.Size = New System.Drawing.Size(60, 16)
        Me.Lb24.TabIndex = 232
        Me.Lb24.Text = "X Bulto"
        '
        'Lb25
        '
        Me.Lb25.AutoSize = True
        Me.Lb25.CL_ControlAsociado = Nothing
        Me.Lb25.CL_ValorFijo = False
        Me.Lb25.ClForm = Nothing
        Me.Lb25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb25.ForeColor = System.Drawing.Color.Teal
        Me.Lb25.Location = New System.Drawing.Point(15, 220)
        Me.Lb25.Name = "Lb25"
        Me.Lb25.Size = New System.Drawing.Size(151, 16)
        Me.Lb25.TabIndex = 231
        Me.Lb25.Text = "SobreCosteMaterial"
        '
        'TxDato14
        '
        Me.TxDato14.Autonumerico = False
        Me.TxDato14.Buscando = False
        Me.TxDato14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato14.ClForm = Nothing
        Me.TxDato14.ClParam = Nothing
        Me.TxDato14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato14.GridLin = Nothing
        Me.TxDato14.HaCambiado = False
        Me.TxDato14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato14.lbbusca = Nothing
        Me.TxDato14.Location = New System.Drawing.Point(252, 218)
        Me.TxDato14.MiError = False
        Me.TxDato14.Name = "TxDato14"
        Me.TxDato14.Orden = 0
        Me.TxDato14.SaltoAlfinal = False
        Me.TxDato14.Siguiente = 0
        Me.TxDato14.Size = New System.Drawing.Size(92, 23)
        Me.TxDato14.TabIndex = 230
        Me.TxDato14.TeclaRepetida = False
        Me.TxDato14.TxDatoFinalSemana = Nothing
        Me.TxDato14.TxDatoInicioSemana = Nothing
        Me.TxDato14.UltimoValorValidado = Nothing
        '
        'Lb17
        '
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = False
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.Teal
        Me.Lb17.Location = New System.Drawing.Point(15, 197)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(178, 16)
        Me.Lb17.TabIndex = 229
        Me.Lb17.Text = "Sobre coste man. x Kilo"
        '
        'ClGrid2
        '
        Me.ClGrid2.AñadirLinea = True
        Me.ClGrid2.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.GridEnterAutomatico = False
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.LineaBloqueada = False
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(0, 327)
        Me.ClGrid2.MismaLinea = False
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.OcultarCeros = False
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(1098, 254)
        Me.ClGrid2.TabIndex = 228
        Me.ClGrid2.UltimoControl = 0
        '
        'TxDato12
        '
        Me.TxDato12.Autonumerico = False
        Me.TxDato12.Buscando = False
        Me.TxDato12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato12.ClForm = Nothing
        Me.TxDato12.ClParam = Nothing
        Me.TxDato12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato12.GridLin = Nothing
        Me.TxDato12.HaCambiado = False
        Me.TxDato12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato12.lbbusca = Nothing
        Me.TxDato12.Location = New System.Drawing.Point(252, 192)
        Me.TxDato12.MiError = False
        Me.TxDato12.Name = "TxDato12"
        Me.TxDato12.Orden = 0
        Me.TxDato12.SaltoAlfinal = False
        Me.TxDato12.Siguiente = 0
        Me.TxDato12.Size = New System.Drawing.Size(92, 23)
        Me.TxDato12.TabIndex = 227
        Me.TxDato12.TeclaRepetida = False
        Me.TxDato12.TxDatoFinalSemana = Nothing
        Me.TxDato12.TxDatoInicioSemana = Nothing
        Me.TxDato12.UltimoValorValidado = Nothing
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = False
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(496, 85)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(110, 16)
        Me.Lb15.TabIndex = 226
        Me.Lb15.Text = "Piezas x Bulto"
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(612, 82)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(53, 23)
        Me.TxDato11.TabIndex = 225
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.TxDatoFinalSemana = Nothing
        Me.TxDato11.TxDatoInicioSemana = Nothing
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = False
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(324, 85)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(97, 16)
        Me.Lb14.TabIndex = 224
        Me.Lb14.Text = "Kilos x Bulto"
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(427, 82)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(63, 23)
        Me.TxDato10.TabIndex = 223
        Me.TxDato10.TeclaRepetida = False
        Me.TxDato10.TxDatoFinalSemana = Nothing
        Me.TxDato10.TxDatoInicioSemana = Nothing
        Me.TxDato10.UltimoValorValidado = Nothing
        '
        'ChActivo
        '
        Me.ChActivo.AutoSize = True
        Me.ChActivo.Campobd = Nothing
        Me.ChActivo.ClForm = Nothing
        Me.ChActivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChActivo.ForeColor = System.Drawing.Color.Teal
        Me.ChActivo.GridLin = Nothing
        Me.ChActivo.HaCambiado = False
        Me.ChActivo.Location = New System.Drawing.Point(676, 86)
        Me.ChActivo.MiEntidad = Nothing
        Me.ChActivo.MiError = False
        Me.ChActivo.Name = "ChActivo"
        Me.ChActivo.Orden = 0
        Me.ChActivo.SaltoAlfinal = False
        Me.ChActivo.Size = New System.Drawing.Size(73, 20)
        Me.ChActivo.TabIndex = 222
        Me.ChActivo.Text = "Activo"
        Me.ChActivo.UseVisualStyleBackColor = True
        Me.ChActivo.ValorCampoFalse = Nothing
        Me.ChActivo.ValorCampoTrue = Nothing
        Me.ChActivo.ValorDefecto = False
        '
        'ChPesoFijo
        '
        Me.ChPesoFijo.AutoSize = True
        Me.ChPesoFijo.Campobd = Nothing
        Me.ChPesoFijo.ClForm = Nothing
        Me.ChPesoFijo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPesoFijo.ForeColor = System.Drawing.Color.Teal
        Me.ChPesoFijo.GridLin = Nothing
        Me.ChPesoFijo.HaCambiado = False
        Me.ChPesoFijo.Location = New System.Drawing.Point(676, 52)
        Me.ChPesoFijo.MiEntidad = Nothing
        Me.ChPesoFijo.MiError = False
        Me.ChPesoFijo.Name = "ChPesoFijo"
        Me.ChPesoFijo.Orden = 0
        Me.ChPesoFijo.SaltoAlfinal = False
        Me.ChPesoFijo.Size = New System.Drawing.Size(89, 20)
        Me.ChPesoFijo.TabIndex = 221
        Me.ChPesoFijo.Text = "Peso fijo"
        Me.ChPesoFijo.UseVisualStyleBackColor = True
        Me.ChPesoFijo.ValorCampoFalse = Nothing
        Me.ChPesoFijo.ValorCampoTrue = Nothing
        Me.ChPesoFijo.ValorDefecto = False
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = False
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(15, 117)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(65, 16)
        Me.Lb13.TabIndex = 220
        Me.Lb13.Text = "Nombre"
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(116, 114)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(537, 23)
        Me.TxDato9.TabIndex = 219
        Me.TxDato9.TeclaRepetida = False
        Me.TxDato9.TxDatoFinalSemana = Nothing
        Me.TxDato9.TxDatoInicioSemana = Nothing
        Me.TxDato9.UltimoValorValidado = Nothing
        '
        'BtBuscaConfec
        '
        Me.BtBuscaConfec.CL_Ancho = 0
        Me.BtBuscaConfec.CL_BuscaAlb = False
        Me.BtBuscaConfec.CL_campocodigo = Nothing
        Me.BtBuscaConfec.CL_camponombre = Nothing
        Me.BtBuscaConfec.CL_CampoOrden = "Nombre"
        Me.BtBuscaConfec.CL_ch1000 = False
        Me.BtBuscaConfec.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaConfec.CL_ControlAsociado = Nothing
        Me.BtBuscaConfec.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaConfec.CL_dfecha = Nothing
        Me.BtBuscaConfec.CL_Entidad = Nothing
        Me.BtBuscaConfec.CL_EsId = True
        Me.BtBuscaConfec.CL_Filtro = Nothing
        Me.BtBuscaConfec.cl_formu = Nothing
        Me.BtBuscaConfec.CL_hfecha = Nothing
        Me.BtBuscaConfec.cl_ListaW = Nothing
        Me.BtBuscaConfec.CL_xCentro = False
        Me.BtBuscaConfec.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaConfec.Location = New System.Drawing.Point(186, 51)
        Me.BtBuscaConfec.Name = "BtBuscaConfec"
        Me.BtBuscaConfec.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaConfec.TabIndex = 218
        Me.BtBuscaConfec.UseVisualStyleBackColor = True
        '
        'Lb11
        '
        Me.Lb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.Location = New System.Drawing.Point(236, 51)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(429, 23)
        Me.Lb11.TabIndex = 217
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = False
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(15, 54)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(88, 16)
        Me.Lb12.TabIndex = 216
        Me.Lb12.Text = "Confección"
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(116, 51)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(61, 23)
        Me.TxDato8.TabIndex = 215
        Me.TxDato8.TeclaRepetida = False
        Me.TxDato8.TxDatoFinalSemana = Nothing
        Me.TxDato8.TxDatoInicioSemana = Nothing
        Me.TxDato8.UltimoValorValidado = Nothing
        '
        'LbNombre
        '
        Me.LbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = False
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.Location = New System.Drawing.Point(432, 18)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(429, 23)
        Me.LbNombre.TabIndex = 255
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Lb18)
        Me.GroupBox1.Controls.Add(Me.ChMarcas)
        Me.GroupBox1.Controls.Add(Me.Lb16)
        Me.GroupBox1.Controls.Add(Me.ChCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(787, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 270)
        Me.GroupBox1.TabIndex = 256
        Me.GroupBox1.TabStop = False
        '
        'Lb18
        '
        Me.Lb18.AutoSize = True
        Me.Lb18.CL_ControlAsociado = Nothing
        Me.Lb18.CL_ValorFijo = True
        Me.Lb18.ClForm = Nothing
        Me.Lb18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb18.ForeColor = System.Drawing.Color.Teal
        Me.Lb18.Location = New System.Drawing.Point(139, 18)
        Me.Lb18.Name = "Lb18"
        Me.Lb18.Size = New System.Drawing.Size(71, 18)
        Me.Lb18.TabIndex = 246
        Me.Lb18.Text = "Marcas"
        '
        'ChMarcas
        '
        Me.ChMarcas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChMarcas.Location = New System.Drawing.Point(146, 38)
        Me.ChMarcas.Name = "ChMarcas"
        Me.ChMarcas.Size = New System.Drawing.Size(136, 214)
        Me.ChMarcas.TabIndex = 245
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(2, 18)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(103, 18)
        Me.Lb16.TabIndex = 244
        Me.Lb16.Text = "Categorias"
        '
        'ChCategoria
        '
        Me.ChCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChCategoria.Location = New System.Drawing.Point(5, 39)
        Me.ChCategoria.Name = "ChCategoria"
        Me.ChCategoria.Size = New System.Drawing.Size(136, 212)
        Me.ChCategoria.TabIndex = 243
        '
        'ChMarcaMatPal
        '
        Me.ChMarcaMatPal.AutoSize = True
        Me.ChMarcaMatPal.Campobd = Nothing
        Me.ChMarcaMatPal.ClForm = Nothing
        Me.ChMarcaMatPal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChMarcaMatPal.ForeColor = System.Drawing.Color.Teal
        Me.ChMarcaMatPal.GridLin = Nothing
        Me.ChMarcaMatPal.HaCambiado = False
        Me.ChMarcaMatPal.Location = New System.Drawing.Point(236, 295)
        Me.ChMarcaMatPal.MiEntidad = Nothing
        Me.ChMarcaMatPal.MiError = False
        Me.ChMarcaMatPal.Name = "ChMarcaMatPal"
        Me.ChMarcaMatPal.Orden = 0
        Me.ChMarcaMatPal.SaltoAlfinal = False
        Me.ChMarcaMatPal.Size = New System.Drawing.Size(211, 20)
        Me.ChMarcaMatPal.TabIndex = 257
        Me.ChMarcaMatPal.Text = "Pedir en pedidos,palets .."
        Me.ChMarcaMatPal.UseVisualStyleBackColor = True
        Me.ChMarcaMatPal.ValorCampoFalse = Nothing
        Me.ChMarcaMatPal.ValorCampoTrue = Nothing
        Me.ChMarcaMatPal.ValorDefecto = False
        '
        'ChMarcaEtiPal
        '
        Me.ChMarcaEtiPal.AutoSize = True
        Me.ChMarcaEtiPal.Campobd = Nothing
        Me.ChMarcaEtiPal.ClForm = Nothing
        Me.ChMarcaEtiPal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChMarcaEtiPal.ForeColor = System.Drawing.Color.Teal
        Me.ChMarcaEtiPal.GridLin = Nothing
        Me.ChMarcaEtiPal.HaCambiado = False
        Me.ChMarcaEtiPal.Location = New System.Drawing.Point(458, 295)
        Me.ChMarcaEtiPal.MiEntidad = Nothing
        Me.ChMarcaEtiPal.MiError = False
        Me.ChMarcaEtiPal.Name = "ChMarcaEtiPal"
        Me.ChMarcaEtiPal.Orden = 0
        Me.ChMarcaEtiPal.SaltoAlfinal = False
        Me.ChMarcaEtiPal.Size = New System.Drawing.Size(211, 20)
        Me.ChMarcaEtiPal.TabIndex = 258
        Me.ChMarcaEtiPal.Text = "Pedir en pedidos,palets .."
        Me.ChMarcaEtiPal.UseVisualStyleBackColor = True
        Me.ChMarcaEtiPal.ValorCampoFalse = Nothing
        Me.ChMarcaEtiPal.ValorCampoTrue = Nothing
        Me.ChMarcaEtiPal.ValorDefecto = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(15, 144)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(99, 16)
        Me.Lb3.TabIndex = 260
        Me.Lb3.Text = "Descrip. Alb."
        '
        'TxDato20
        '
        Me.TxDato20.Autonumerico = False
        Me.TxDato20.Buscando = False
        Me.TxDato20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato20.ClForm = Nothing
        Me.TxDato20.ClParam = Nothing
        Me.TxDato20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato20.GridLin = Nothing
        Me.TxDato20.HaCambiado = False
        Me.TxDato20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato20.lbbusca = Nothing
        Me.TxDato20.Location = New System.Drawing.Point(116, 141)
        Me.TxDato20.MiError = False
        Me.TxDato20.Name = "TxDato20"
        Me.TxDato20.Orden = 0
        Me.TxDato20.SaltoAlfinal = False
        Me.TxDato20.Siguiente = 0
        Me.TxDato20.Size = New System.Drawing.Size(537, 23)
        Me.TxDato20.TabIndex = 259
        Me.TxDato20.TeclaRepetida = False
        Me.TxDato20.TxDatoFinalSemana = Nothing
        Me.TxDato20.TxDatoInicioSemana = Nothing
        Me.TxDato20.UltimoValorValidado = Nothing
        '
        'LbGastoManiGenero
        '
        Me.LbGastoManiGenero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbGastoManiGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbGastoManiGenero.CL_ControlAsociado = Nothing
        Me.LbGastoManiGenero.CL_ValorFijo = True
        Me.LbGastoManiGenero.ClForm = Nothing
        Me.LbGastoManiGenero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGastoManiGenero.Location = New System.Drawing.Point(252, 167)
        Me.LbGastoManiGenero.Name = "LbGastoManiGenero"
        Me.LbGastoManiGenero.Size = New System.Drawing.Size(92, 23)
        Me.LbGastoManiGenero.TabIndex = 262
        Me.LbGastoManiGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(15, 172)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(156, 16)
        Me.Lb5.TabIndex = 261
        Me.Lb5.Text = "Gasto de Confección"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(350, 172)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(48, 16)
        Me.Lb6.TabIndex = 263
        Me.Lb6.Text = "X Kilo"
        '
        'chkGeneroQS
        '
        Me.chkGeneroQS.AutoSize = True
        Me.chkGeneroQS.Campobd = Nothing
        Me.chkGeneroQS.ClForm = Nothing
        Me.chkGeneroQS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGeneroQS.ForeColor = System.Drawing.Color.Teal
        Me.chkGeneroQS.GridLin = Nothing
        Me.chkGeneroQS.HaCambiado = False
        Me.chkGeneroQS.Location = New System.Drawing.Point(676, 115)
        Me.chkGeneroQS.MiEntidad = Nothing
        Me.chkGeneroQS.MiError = False
        Me.chkGeneroQS.Name = "chkGeneroQS"
        Me.chkGeneroQS.Orden = 0
        Me.chkGeneroQS.SaltoAlfinal = False
        Me.chkGeneroQS.Size = New System.Drawing.Size(103, 20)
        Me.chkGeneroQS.TabIndex = 264
        Me.chkGeneroQS.Text = "Genero QS"
        Me.chkGeneroQS.UseVisualStyleBackColor = True
        Me.chkGeneroQS.ValorCampoFalse = Nothing
        Me.chkGeneroQS.ValorCampoTrue = Nothing
        Me.chkGeneroQS.ValorDefecto = False
        '
        'chkDemeter
        '
        Me.chkDemeter.AutoSize = True
        Me.chkDemeter.Campobd = Nothing
        Me.chkDemeter.ClForm = Nothing
        Me.chkDemeter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDemeter.ForeColor = System.Drawing.Color.Teal
        Me.chkDemeter.GridLin = Nothing
        Me.chkDemeter.HaCambiado = False
        Me.chkDemeter.Location = New System.Drawing.Point(676, 142)
        Me.chkDemeter.MiEntidad = Nothing
        Me.chkDemeter.MiError = False
        Me.chkDemeter.Name = "chkDemeter"
        Me.chkDemeter.Orden = 0
        Me.chkDemeter.SaltoAlfinal = False
        Me.chkDemeter.Size = New System.Drawing.Size(93, 20)
        Me.chkDemeter.TabIndex = 265
        Me.chkDemeter.Text = "DEMETER"
        Me.chkDemeter.UseVisualStyleBackColor = True
        Me.chkDemeter.ValorCampoFalse = Nothing
        Me.chkDemeter.ValorCampoTrue = Nothing
        Me.chkDemeter.ValorDefecto = False
        '
        'FrmConfecGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 615)
        Me.Controls.Add(Me.chkDemeter)
        Me.Controls.Add(Me.chkGeneroQS)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.LbGastoManiGenero)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato20)
        Me.Controls.Add(Me.ChMarcaEtiPal)
        Me.Controls.Add(Me.ChMarcaMatPal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.BtBuscaMarcaEti)
        Me.Controls.Add(Me.LbMarcaEti)
        Me.Controls.Add(Me.Lb29)
        Me.Controls.Add(Me.TxDato16)
        Me.Controls.Add(Me.BtBuscaMarcaMat)
        Me.Controls.Add(Me.LbMarcaMat)
        Me.Controls.Add(Me.Lb27)
        Me.Controls.Add(Me.TxDato15)
        Me.Controls.Add(Me.BtBuscaMarcaEnv)
        Me.Controls.Add(Me.LbMarcaEnv)
        Me.Controls.Add(Me.Lb22)
        Me.Controls.Add(Me.TxDato13)
        Me.Controls.Add(Me.LbTcosteBulto)
        Me.Controls.Add(Me.Lb20)
        Me.Controls.Add(Me.LbTcosteKilo)
        Me.Controls.Add(Me.Lb21)
        Me.Controls.Add(Me.LbCosteConf)
        Me.Controls.Add(Me.Lb23)
        Me.Controls.Add(Me.Lb24)
        Me.Controls.Add(Me.Lb25)
        Me.Controls.Add(Me.TxDato14)
        Me.Controls.Add(Me.Lb17)
        Me.Controls.Add(Me.ClGrid2)
        Me.Controls.Add(Me.TxDato12)
        Me.Controls.Add(Me.Lb15)
        Me.Controls.Add(Me.TxDato11)
        Me.Controls.Add(Me.Lb14)
        Me.Controls.Add(Me.TxDato10)
        Me.Controls.Add(Me.ChActivo)
        Me.Controls.Add(Me.ChPesoFijo)
        Me.Controls.Add(Me.Lb13)
        Me.Controls.Add(Me.TxDato9)
        Me.Controls.Add(Me.BtBuscaConfec)
        Me.Controls.Add(Me.Lb11)
        Me.Controls.Add(Me.Lb12)
        Me.Controls.Add(Me.TxDato8)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaGenero)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConfecGenero"
        Me.Text = "Confecciones por género"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaGenero, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxDato8, 0)
        Me.Controls.SetChildIndex(Me.Lb12, 0)
        Me.Controls.SetChildIndex(Me.Lb11, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaConfec, 0)
        Me.Controls.SetChildIndex(Me.TxDato9, 0)
        Me.Controls.SetChildIndex(Me.Lb13, 0)
        Me.Controls.SetChildIndex(Me.ChPesoFijo, 0)
        Me.Controls.SetChildIndex(Me.ChActivo, 0)
        Me.Controls.SetChildIndex(Me.TxDato10, 0)
        Me.Controls.SetChildIndex(Me.Lb14, 0)
        Me.Controls.SetChildIndex(Me.TxDato11, 0)
        Me.Controls.SetChildIndex(Me.Lb15, 0)
        Me.Controls.SetChildIndex(Me.TxDato12, 0)
        Me.Controls.SetChildIndex(Me.ClGrid2, 0)
        Me.Controls.SetChildIndex(Me.Lb17, 0)
        Me.Controls.SetChildIndex(Me.TxDato14, 0)
        Me.Controls.SetChildIndex(Me.Lb25, 0)
        Me.Controls.SetChildIndex(Me.Lb24, 0)
        Me.Controls.SetChildIndex(Me.Lb23, 0)
        Me.Controls.SetChildIndex(Me.LbCosteConf, 0)
        Me.Controls.SetChildIndex(Me.Lb21, 0)
        Me.Controls.SetChildIndex(Me.LbTcosteKilo, 0)
        Me.Controls.SetChildIndex(Me.Lb20, 0)
        Me.Controls.SetChildIndex(Me.LbTcosteBulto, 0)
        Me.Controls.SetChildIndex(Me.TxDato13, 0)
        Me.Controls.SetChildIndex(Me.Lb22, 0)
        Me.Controls.SetChildIndex(Me.LbMarcaEnv, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarcaEnv, 0)
        Me.Controls.SetChildIndex(Me.TxDato15, 0)
        Me.Controls.SetChildIndex(Me.Lb27, 0)
        Me.Controls.SetChildIndex(Me.LbMarcaMat, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarcaMat, 0)
        Me.Controls.SetChildIndex(Me.TxDato16, 0)
        Me.Controls.SetChildIndex(Me.Lb29, 0)
        Me.Controls.SetChildIndex(Me.LbMarcaEti, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarcaEti, 0)
        Me.Controls.SetChildIndex(Me.LbNombre, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ChMarcaMatPal, 0)
        Me.Controls.SetChildIndex(Me.ChMarcaEtiPal, 0)
        Me.Controls.SetChildIndex(Me.TxDato20, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.LbGastoManiGenero, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.chkGeneroQS, 0)
        Me.Controls.SetChildIndex(Me.chkDemeter, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ChMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaGenero As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents BtBuscaMarcaEti As NetAgro.BtBusca
    Friend WithEvents LbMarcaEti As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents TxDato16 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarcaMat As NetAgro.BtBusca
    Friend WithEvents LbMarcaMat As NetAgro.Lb
    Friend WithEvents Lb27 As NetAgro.Lb
    Friend WithEvents TxDato15 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarcaEnv As NetAgro.BtBusca
    Friend WithEvents LbMarcaEnv As NetAgro.Lb
    Friend WithEvents Lb22 As NetAgro.Lb
    Friend WithEvents TxDato13 As NetAgro.TxDato
    Friend WithEvents LbTcosteBulto As NetAgro.Lb
    Friend WithEvents Lb20 As NetAgro.Lb
    Friend WithEvents LbTcosteKilo As NetAgro.Lb
    Friend WithEvents Lb21 As NetAgro.Lb
    Friend WithEvents LbCosteConf As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents Lb24 As NetAgro.Lb
    Friend WithEvents Lb25 As NetAgro.Lb
    Friend WithEvents TxDato14 As NetAgro.TxDato
    Friend WithEvents Lb17 As NetAgro.Lb
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents TxDato12 As NetAgro.TxDato
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents ChActivo As NetAgro.Chk
    Friend WithEvents ChPesoFijo As NetAgro.Chk
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents BtBuscaConfec As NetAgro.BtBusca
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb18 As NetAgro.Lb
    Friend WithEvents ChMarcas As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents ChCategoria As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ChMarcaMatPal As NetAgro.Chk
    Friend WithEvents ChMarcaEtiPal As NetAgro.Chk
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato20 As NetAgro.TxDato
    Friend WithEvents LbGastoManiGenero As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents chkGeneroQS As NetAgro.Chk
    Friend WithEvents chkDemeter As NetAgro.Chk
End Class
