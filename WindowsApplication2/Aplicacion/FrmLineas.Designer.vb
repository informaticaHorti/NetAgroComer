<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLineas))
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarca = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaCentro = New NetAgro.BtBusca(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.ChSubFamilias = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.chkSoloPrecalibrado = New NetAgro.Chk(Me.components)
        Me.ChkPermitirPrecalibrado = New NetAgro.Chk(Me.components)
        Me.LbNombreLineaCalidad = New NetAgro.Lb(Me.components)
        Me.BtBuscaLineaCalidad = New NetAgro.BtBusca(Me.components)
        Me.TxLineaCalidad = New NetAgro.TxDato(Me.components)
        Me.LbLineaCalidad = New NetAgro.Lb(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChSubFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(20, 64)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 68
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
        Me.Lb1.Location = New System.Drawing.Point(20, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Codigo"
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
        Me.TxDato1.Location = New System.Drawing.Point(97, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxDato2.Location = New System.Drawing.Point(97, 61)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(326, 22)
        Me.TxDato2.TabIndex = 75
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BtBuscaMarca
        '
        Me.BtBuscaMarca.CL_Ancho = 0
        Me.BtBuscaMarca.CL_BuscaAlb = False
        Me.BtBuscaMarca.CL_campocodigo = Nothing
        Me.BtBuscaMarca.CL_camponombre = Nothing
        Me.BtBuscaMarca.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarca.CL_ch1000 = False
        Me.BtBuscaMarca.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarca.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaMarca.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarca.CL_dfecha = Nothing
        Me.BtBuscaMarca.CL_Entidad = Nothing
        Me.BtBuscaMarca.CL_EsId = True
        Me.BtBuscaMarca.CL_Filtro = Nothing
        Me.BtBuscaMarca.cl_formu = Nothing
        Me.BtBuscaMarca.CL_hfecha = Nothing
        Me.BtBuscaMarca.cl_ListaW = Nothing
        Me.BtBuscaMarca.CL_xCentro = False
        Me.BtBuscaMarca.Image = CType(resources.GetObject("BtBuscaMarca.Image"), System.Drawing.Image)
        Me.BtBuscaMarca.Location = New System.Drawing.Point(149, 17)
        Me.BtBuscaMarca.Name = "BtBuscaMarca"
        Me.BtBuscaMarca.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarca.TabIndex = 76
        Me.BtBuscaMarca.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(188, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaCentro
        '
        Me.BtBuscaCentro.CL_Ancho = 0
        Me.BtBuscaCentro.CL_BuscaAlb = False
        Me.BtBuscaCentro.CL_campocodigo = Nothing
        Me.BtBuscaCentro.CL_camponombre = Nothing
        Me.BtBuscaCentro.CL_CampoOrden = "Nombre"
        Me.BtBuscaCentro.CL_ch1000 = False
        Me.BtBuscaCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCentro.CL_ControlAsociado = Me.TxDato3
        Me.BtBuscaCentro.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCentro.CL_dfecha = Nothing
        Me.BtBuscaCentro.CL_Entidad = Nothing
        Me.BtBuscaCentro.CL_EsId = True
        Me.BtBuscaCentro.CL_Filtro = Nothing
        Me.BtBuscaCentro.cl_formu = Nothing
        Me.BtBuscaCentro.CL_hfecha = Nothing
        Me.BtBuscaCentro.cl_ListaW = Nothing
        Me.BtBuscaCentro.CL_xCentro = False
        Me.BtBuscaCentro.Image = CType(resources.GetObject("BtBuscaCentro.Image"), System.Drawing.Image)
        Me.BtBuscaCentro.Location = New System.Drawing.Point(149, 96)
        Me.BtBuscaCentro.Name = "BtBuscaCentro"
        Me.BtBuscaCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCentro.TabIndex = 80
        Me.BtBuscaCentro.UseVisualStyleBackColor = True
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
        Me.TxDato3.Location = New System.Drawing.Point(97, 96)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(46, 22)
        Me.TxDato3.TabIndex = 79
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(20, 99)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(65, 16)
        Me.Lb3.TabIndex = 78
        Me.Lb3.Text = "P.Venta"
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
        Me.TxDato4.Location = New System.Drawing.Point(188, 131)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(326, 22)
        Me.TxDato4.TabIndex = 82
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(20, 134)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(139, 16)
        Me.Lb4.TabIndex = 81
        Me.Lb4.Text = "Responsable linea"
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
        Me.TxDato5.Location = New System.Drawing.Point(188, 166)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(326, 22)
        Me.TxDato5.TabIndex = 84
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(20, 169)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(165, 16)
        Me.Lb5.TabIndex = 83
        Me.Lb5.Text = "Responsable limpieza"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Lb16)
        Me.GroupBox1.Controls.Add(Me.ChSubFamilias)
        Me.GroupBox1.Location = New System.Drawing.Point(522, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 324)
        Me.GroupBox1.TabIndex = 257
        Me.GroupBox1.TabStop = False
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(-2, 18)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(88, 18)
        Me.Lb16.TabIndex = 244
        Me.Lb16.Text = "Producto"
        '
        'ChSubFamilias
        '
        Me.ChSubFamilias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChSubFamilias.Location = New System.Drawing.Point(6, 39)
        Me.ChSubFamilias.Name = "ChSubFamilias"
        Me.ChSubFamilias.Size = New System.Drawing.Size(248, 279)
        Me.ChSubFamilias.TabIndex = 243
        '
        'LbCentro
        '
        Me.LbCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = False
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.Location = New System.Drawing.Point(188, 96)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(235, 23)
        Me.LbCentro.TabIndex = 258
        '
        'chkSoloPrecalibrado
        '
        Me.chkSoloPrecalibrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSoloPrecalibrado.AutoSize = True
        Me.chkSoloPrecalibrado.Campobd = Nothing
        Me.chkSoloPrecalibrado.ClForm = Nothing
        Me.chkSoloPrecalibrado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloPrecalibrado.ForeColor = System.Drawing.Color.Teal
        Me.chkSoloPrecalibrado.GridLin = Nothing
        Me.chkSoloPrecalibrado.HaCambiado = False
        Me.chkSoloPrecalibrado.Location = New System.Drawing.Point(20, 204)
        Me.chkSoloPrecalibrado.MiEntidad = Nothing
        Me.chkSoloPrecalibrado.MiError = False
        Me.chkSoloPrecalibrado.Name = "chkSoloPrecalibrado"
        Me.chkSoloPrecalibrado.Orden = 0
        Me.chkSoloPrecalibrado.SaltoAlfinal = False
        Me.chkSoloPrecalibrado.Size = New System.Drawing.Size(153, 20)
        Me.chkSoloPrecalibrado.TabIndex = 100275
        Me.chkSoloPrecalibrado.Text = "Sólo precalibrado"
        Me.chkSoloPrecalibrado.UseVisualStyleBackColor = True
        Me.chkSoloPrecalibrado.ValorCampoFalse = Nothing
        Me.chkSoloPrecalibrado.ValorCampoTrue = Nothing
        Me.chkSoloPrecalibrado.ValorDefecto = False
        '
        'ChkPermitirPrecalibrado
        '
        Me.ChkPermitirPrecalibrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPermitirPrecalibrado.AutoSize = True
        Me.ChkPermitirPrecalibrado.Campobd = Nothing
        Me.ChkPermitirPrecalibrado.ClForm = Nothing
        Me.ChkPermitirPrecalibrado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPermitirPrecalibrado.ForeColor = System.Drawing.Color.Teal
        Me.ChkPermitirPrecalibrado.GridLin = Nothing
        Me.ChkPermitirPrecalibrado.HaCambiado = False
        Me.ChkPermitirPrecalibrado.Location = New System.Drawing.Point(20, 239)
        Me.ChkPermitirPrecalibrado.MiEntidad = Nothing
        Me.ChkPermitirPrecalibrado.MiError = False
        Me.ChkPermitirPrecalibrado.Name = "ChkPermitirPrecalibrado"
        Me.ChkPermitirPrecalibrado.Orden = 0
        Me.ChkPermitirPrecalibrado.SaltoAlfinal = False
        Me.ChkPermitirPrecalibrado.Size = New System.Drawing.Size(180, 20)
        Me.ChkPermitirPrecalibrado.TabIndex = 100276
        Me.ChkPermitirPrecalibrado.Text = "Permitir precalibrado"
        Me.ChkPermitirPrecalibrado.UseVisualStyleBackColor = True
        Me.ChkPermitirPrecalibrado.ValorCampoFalse = Nothing
        Me.ChkPermitirPrecalibrado.ValorCampoTrue = Nothing
        Me.ChkPermitirPrecalibrado.ValorDefecto = False
        '
        'LbNombreLineaCalidad
        '
        Me.LbNombreLineaCalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNombreLineaCalidad.CL_ControlAsociado = Nothing
        Me.LbNombreLineaCalidad.CL_ValorFijo = False
        Me.LbNombreLineaCalidad.ClForm = Nothing
        Me.LbNombreLineaCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbNombreLineaCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreLineaCalidad.Location = New System.Drawing.Point(265, 274)
        Me.LbNombreLineaCalidad.Name = "LbNombreLineaCalidad"
        Me.LbNombreLineaCalidad.Size = New System.Drawing.Size(235, 23)
        Me.LbNombreLineaCalidad.TabIndex = 100280
        '
        'BtBuscaLineaCalidad
        '
        Me.BtBuscaLineaCalidad.CL_Ancho = 0
        Me.BtBuscaLineaCalidad.CL_BuscaAlb = False
        Me.BtBuscaLineaCalidad.CL_campocodigo = Nothing
        Me.BtBuscaLineaCalidad.CL_camponombre = Nothing
        Me.BtBuscaLineaCalidad.CL_CampoOrden = "Nombre"
        Me.BtBuscaLineaCalidad.CL_ch1000 = False
        Me.BtBuscaLineaCalidad.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaLineaCalidad.CL_ControlAsociado = Me.TxLineaCalidad
        Me.BtBuscaLineaCalidad.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaLineaCalidad.CL_dfecha = Nothing
        Me.BtBuscaLineaCalidad.CL_Entidad = Nothing
        Me.BtBuscaLineaCalidad.CL_EsId = True
        Me.BtBuscaLineaCalidad.CL_Filtro = Nothing
        Me.BtBuscaLineaCalidad.cl_formu = Nothing
        Me.BtBuscaLineaCalidad.CL_hfecha = Nothing
        Me.BtBuscaLineaCalidad.cl_ListaW = Nothing
        Me.BtBuscaLineaCalidad.CL_xCentro = False
        Me.BtBuscaLineaCalidad.Image = CType(resources.GetObject("BtBuscaLineaCalidad.Image"), System.Drawing.Image)
        Me.BtBuscaLineaCalidad.Location = New System.Drawing.Point(226, 274)
        Me.BtBuscaLineaCalidad.Name = "BtBuscaLineaCalidad"
        Me.BtBuscaLineaCalidad.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaLineaCalidad.TabIndex = 100279
        Me.BtBuscaLineaCalidad.UseVisualStyleBackColor = True
        '
        'TxLineaCalidad
        '
        Me.TxLineaCalidad.Autonumerico = False
        Me.TxLineaCalidad.Buscando = False
        Me.TxLineaCalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxLineaCalidad.ClForm = Nothing
        Me.TxLineaCalidad.ClParam = Nothing
        Me.TxLineaCalidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxLineaCalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxLineaCalidad.GridLin = Nothing
        Me.TxLineaCalidad.HaCambiado = False
        Me.TxLineaCalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxLineaCalidad.lbbusca = Nothing
        Me.TxLineaCalidad.Location = New System.Drawing.Point(174, 274)
        Me.TxLineaCalidad.MiError = False
        Me.TxLineaCalidad.Name = "TxLineaCalidad"
        Me.TxLineaCalidad.Orden = 0
        Me.TxLineaCalidad.SaltoAlfinal = False
        Me.TxLineaCalidad.Siguiente = 0
        Me.TxLineaCalidad.Size = New System.Drawing.Size(46, 22)
        Me.TxLineaCalidad.TabIndex = 100278
        Me.TxLineaCalidad.TeclaRepetida = False
        Me.TxLineaCalidad.TxDatoFinalSemana = Nothing
        Me.TxLineaCalidad.TxDatoInicioSemana = Nothing
        Me.TxLineaCalidad.UltimoValorValidado = Nothing
        '
        'LbLineaCalidad
        '
        Me.LbLineaCalidad.AutoSize = True
        Me.LbLineaCalidad.CL_ControlAsociado = Nothing
        Me.LbLineaCalidad.CL_ValorFijo = False
        Me.LbLineaCalidad.ClForm = Nothing
        Me.LbLineaCalidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLineaCalidad.ForeColor = System.Drawing.Color.Teal
        Me.LbLineaCalidad.Location = New System.Drawing.Point(20, 277)
        Me.LbLineaCalidad.Name = "LbLineaCalidad"
        Me.LbLineaCalidad.Size = New System.Drawing.Size(148, 16)
        Me.LbLineaCalidad.TabIndex = 100277
        Me.LbLineaCalidad.Text = "Línea ticaje calidad"
        '
        'FrmLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 366)
        Me.Controls.Add(Me.LbNombreLineaCalidad)
        Me.Controls.Add(Me.BtBuscaLineaCalidad)
        Me.Controls.Add(Me.TxLineaCalidad)
        Me.Controls.Add(Me.LbLineaCalidad)
        Me.Controls.Add(Me.ChkPermitirPrecalibrado)
        Me.Controls.Add(Me.chkSoloPrecalibrado)
        Me.Controls.Add(Me.LbCentro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxDato5)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.BtBuscaCentro)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaMarca)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmLineas"
        Me.Text = "Lineas de producción"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCentro, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.TxDato5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.LbCentro, 0)
        Me.Controls.SetChildIndex(Me.chkSoloPrecalibrado, 0)
        Me.Controls.SetChildIndex(Me.ChkPermitirPrecalibrado, 0)
        Me.Controls.SetChildIndex(Me.LbLineaCalidad, 0)
        Me.Controls.SetChildIndex(Me.TxLineaCalidad, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaLineaCalidad, 0)
        Me.Controls.SetChildIndex(Me.LbNombreLineaCalidad, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ChSubFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarca As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaCentro As NetAgro.BtBusca
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents ChSubFamilias As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents chkSoloPrecalibrado As NetAgro.Chk
    Friend WithEvents ChkPermitirPrecalibrado As NetAgro.Chk
    Friend WithEvents LbNombreLineaCalidad As NetAgro.Lb
    Friend WithEvents BtBuscaLineaCalidad As NetAgro.BtBusca
    Friend WithEvents TxLineaCalidad As NetAgro.TxDato
    Friend WithEvents LbLineaCalidad As NetAgro.Lb
End Class
