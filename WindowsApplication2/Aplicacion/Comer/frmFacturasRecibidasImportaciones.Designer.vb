<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasRecibidasImportaciones
    Inherits NetAgro.FrMantenimiento

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasRecibidasImportaciones))
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.BtBusca_2 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.BtBusca_3 = New NetAgro.BtBusca(Me.components)
        Me.TxNIF = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.BtBusca_4 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_4 = New NetAgro.TxDato(Me.components)
        Me.TxDato_5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.btSumar = New System.Windows.Forms.Button()
        Me.TxDato_6 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato_7 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.TxDato_8 = New NetAgro.TxDato(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato_9 = New NetAgro.TxDato(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.BtBusca_11 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.CbTipoId = New NetAgro.CbBox(Me.components)
        Me.LbTipoId = New NetAgro.Lb(Me.components)
        Me.TxPais = New NetAgro.TxDato(Me.components)
        Me.LbPais = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(21, 185)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(66, 16)
        Me.Lb4.TabIndex = 88
        Me.Lb4.Text = "Tipo Iva"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(21, 154)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(32, 16)
        Me.Lb3.TabIndex = 84
        Me.Lb3.Text = "NIF"
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Enabled = False
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(125, 27)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.ReadOnly = True
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato_1.TabIndex = 83
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(21, 61)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(60, 16)
        Me.Lb2.TabIndex = 81
        Me.Lb2.Text = "Cuenta"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 30)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(77, 16)
        Me.Lb1.TabIndex = 79
        Me.Lb1.Text = "IdFactura"
        '
        'Lb_2
        '
        Me.Lb_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_2.Location = New System.Drawing.Point(284, 59)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(335, 21)
        Me.Lb_2.TabIndex = 92
        '
        'BtBusca_2
        '
        Me.BtBusca_2.CL_Ancho = 0
        Me.BtBusca_2.CL_BuscaAlb = False
        Me.BtBusca_2.CL_campocodigo = Nothing
        Me.BtBusca_2.CL_camponombre = Nothing
        Me.BtBusca_2.CL_CampoOrden = "Nombre"
        Me.BtBusca_2.CL_ch1000 = False
        Me.BtBusca_2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_2.CL_ControlAsociado = Me.TxDato_2
        Me.BtBusca_2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_2.CL_dfecha = Nothing
        Me.BtBusca_2.CL_Entidad = Nothing
        Me.BtBusca_2.CL_EsId = True
        Me.BtBusca_2.CL_Filtro = Nothing
        Me.BtBusca_2.cl_formu = Nothing
        Me.BtBusca_2.CL_hfecha = Nothing
        Me.BtBusca_2.cl_ListaW = Nothing
        Me.BtBusca_2.CL_xCentro = False
        Me.BtBusca_2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_2.Location = New System.Drawing.Point(246, 58)
        Me.BtBusca_2.Name = "BtBusca_2"
        Me.BtBusca_2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_2.TabIndex = 91
        Me.BtBusca_2.UseVisualStyleBackColor = True
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(125, 58)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(120, 22)
        Me.TxDato_2.TabIndex = 89
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'Lb_3
        '
        Me.Lb_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_3.Location = New System.Drawing.Point(283, 152)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(336, 21)
        Me.Lb_3.TabIndex = 102
        '
        'BtBusca_3
        '
        Me.BtBusca_3.CL_Ancho = 0
        Me.BtBusca_3.CL_BuscaAlb = False
        Me.BtBusca_3.CL_campocodigo = Nothing
        Me.BtBusca_3.CL_camponombre = Nothing
        Me.BtBusca_3.CL_CampoOrden = "Nombre"
        Me.BtBusca_3.CL_ch1000 = False
        Me.BtBusca_3.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_3.CL_ControlAsociado = Me.TxNIF
        Me.BtBusca_3.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_3.CL_dfecha = Nothing
        Me.BtBusca_3.CL_Entidad = Nothing
        Me.BtBusca_3.CL_EsId = True
        Me.BtBusca_3.CL_Filtro = Nothing
        Me.BtBusca_3.cl_formu = Nothing
        Me.BtBusca_3.CL_hfecha = Nothing
        Me.BtBusca_3.cl_ListaW = Nothing
        Me.BtBusca_3.CL_xCentro = False
        Me.BtBusca_3.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_3.Location = New System.Drawing.Point(246, 151)
        Me.BtBusca_3.Name = "BtBusca_3"
        Me.BtBusca_3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_3.TabIndex = 101
        Me.BtBusca_3.UseVisualStyleBackColor = True
        '
        'TxNIF
        '
        Me.TxNIF.Autonumerico = False
        Me.TxNIF.Buscando = False
        Me.TxNIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNIF.ClForm = Nothing
        Me.TxNIF.ClParam = Nothing
        Me.TxNIF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNIF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNIF.GridLin = Nothing
        Me.TxNIF.HaCambiado = False
        Me.TxNIF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNIF.lbbusca = Nothing
        Me.TxNIF.Location = New System.Drawing.Point(125, 151)
        Me.TxNIF.MiError = False
        Me.TxNIF.Name = "TxNIF"
        Me.TxNIF.Orden = 0
        Me.TxNIF.SaltoAlfinal = False
        Me.TxNIF.Siguiente = 0
        Me.TxNIF.Size = New System.Drawing.Size(120, 22)
        Me.TxNIF.TabIndex = 99
        Me.TxNIF.TeclaRepetida = False
        Me.TxNIF.TxDatoFinalSemana = Nothing
        Me.TxNIF.TxDatoInicioSemana = Nothing
        Me.TxNIF.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_4.Location = New System.Drawing.Point(223, 183)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(396, 21)
        Me.Lb_4.TabIndex = 117
        Me.Lb_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtBusca_4
        '
        Me.BtBusca_4.CL_Ancho = 0
        Me.BtBusca_4.CL_BuscaAlb = False
        Me.BtBusca_4.CL_campocodigo = Nothing
        Me.BtBusca_4.CL_camponombre = Nothing
        Me.BtBusca_4.CL_CampoOrden = "Nombre"
        Me.BtBusca_4.CL_ch1000 = False
        Me.BtBusca_4.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_4.CL_ControlAsociado = Me.TxDato_1
        Me.BtBusca_4.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_4.CL_dfecha = Nothing
        Me.BtBusca_4.CL_Entidad = Nothing
        Me.BtBusca_4.CL_EsId = True
        Me.BtBusca_4.CL_Filtro = Nothing
        Me.BtBusca_4.cl_formu = Nothing
        Me.BtBusca_4.CL_hfecha = Nothing
        Me.BtBusca_4.cl_ListaW = Nothing
        Me.BtBusca_4.CL_xCentro = False
        Me.BtBusca_4.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_4.Location = New System.Drawing.Point(184, 182)
        Me.BtBusca_4.Name = "BtBusca_4"
        Me.BtBusca_4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_4.TabIndex = 116
        Me.BtBusca_4.UseVisualStyleBackColor = True
        '
        'TxDato_4
        '
        Me.TxDato_4.Autonumerico = False
        Me.TxDato_4.Buscando = False
        Me.TxDato_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_4.ClForm = Nothing
        Me.TxDato_4.ClParam = Nothing
        Me.TxDato_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_4.GridLin = Nothing
        Me.TxDato_4.HaCambiado = False
        Me.TxDato_4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_4.lbbusca = Nothing
        Me.TxDato_4.Location = New System.Drawing.Point(125, 182)
        Me.TxDato_4.MiError = False
        Me.TxDato_4.Name = "TxDato_4"
        Me.TxDato_4.Orden = 0
        Me.TxDato_4.SaltoAlfinal = False
        Me.TxDato_4.Siguiente = 0
        Me.TxDato_4.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_4.TabIndex = 115
        Me.TxDato_4.TeclaRepetida = False
        Me.TxDato_4.TxDatoFinalSemana = Nothing
        Me.TxDato_4.TxDatoInicioSemana = Nothing
        Me.TxDato_4.UltimoValorValidado = Nothing
        '
        'TxDato_5
        '
        Me.TxDato_5.Autonumerico = False
        Me.TxDato_5.Buscando = False
        Me.TxDato_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_5.ClForm = Nothing
        Me.TxDato_5.ClParam = Nothing
        Me.TxDato_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_5.GridLin = Nothing
        Me.TxDato_5.HaCambiado = False
        Me.TxDato_5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_5.lbbusca = Nothing
        Me.TxDato_5.Location = New System.Drawing.Point(125, 213)
        Me.TxDato_5.MiError = False
        Me.TxDato_5.Name = "TxDato_5"
        Me.TxDato_5.Orden = 0
        Me.TxDato_5.SaltoAlfinal = False
        Me.TxDato_5.Siguiente = 0
        Me.TxDato_5.Size = New System.Drawing.Size(104, 22)
        Me.TxDato_5.TabIndex = 176
        Me.TxDato_5.TeclaRepetida = False
        Me.TxDato_5.TxDatoFinalSemana = Nothing
        Me.TxDato_5.TxDatoInicioSemana = Nothing
        Me.TxDato_5.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(21, 216)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(44, 16)
        Me.Lb5.TabIndex = 175
        Me.Lb5.Text = "Base"
        '
        'btSumar
        '
        Me.btSumar.Location = New System.Drawing.Point(246, 213)
        Me.btSumar.Name = "btSumar"
        Me.btSumar.Size = New System.Drawing.Size(84, 23)
        Me.btSumar.TabIndex = 100326
        Me.btSumar.Text = "Sumar"
        Me.btSumar.UseVisualStyleBackColor = True
        '
        'TxDato_6
        '
        Me.TxDato_6.Autonumerico = False
        Me.TxDato_6.Buscando = False
        Me.TxDato_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_6.ClForm = Nothing
        Me.TxDato_6.ClParam = Nothing
        Me.TxDato_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_6.GridLin = Nothing
        Me.TxDato_6.HaCambiado = False
        Me.TxDato_6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_6.lbbusca = Nothing
        Me.TxDato_6.Location = New System.Drawing.Point(125, 244)
        Me.TxDato_6.MiError = False
        Me.TxDato_6.Name = "TxDato_6"
        Me.TxDato_6.Orden = 0
        Me.TxDato_6.SaltoAlfinal = False
        Me.TxDato_6.Siguiente = 0
        Me.TxDato_6.Size = New System.Drawing.Size(50, 22)
        Me.TxDato_6.TabIndex = 100328
        Me.TxDato_6.TeclaRepetida = False
        Me.TxDato_6.TxDatoFinalSemana = Nothing
        Me.TxDato_6.TxDatoInicioSemana = Nothing
        Me.TxDato_6.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(21, 247)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(49, 16)
        Me.Lb6.TabIndex = 100327
        Me.Lb6.Text = "%IVA"
        '
        'TxDato_7
        '
        Me.TxDato_7.Autonumerico = False
        Me.TxDato_7.Buscando = False
        Me.TxDato_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_7.ClForm = Nothing
        Me.TxDato_7.ClParam = Nothing
        Me.TxDato_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_7.GridLin = Nothing
        Me.TxDato_7.HaCambiado = False
        Me.TxDato_7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_7.lbbusca = Nothing
        Me.TxDato_7.Location = New System.Drawing.Point(125, 275)
        Me.TxDato_7.MiError = False
        Me.TxDato_7.Name = "TxDato_7"
        Me.TxDato_7.Orden = 0
        Me.TxDato_7.SaltoAlfinal = False
        Me.TxDato_7.Siguiente = 0
        Me.TxDato_7.Size = New System.Drawing.Size(104, 22)
        Me.TxDato_7.TabIndex = 100330
        Me.TxDato_7.TeclaRepetida = False
        Me.TxDato_7.TxDatoFinalSemana = Nothing
        Me.TxDato_7.TxDatoInicioSemana = Nothing
        Me.TxDato_7.UltimoValorValidado = Nothing
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(21, 278)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(79, 16)
        Me.Lb7.TabIndex = 100329
        Me.Lb7.Text = "Cuota IVA"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(21, 309)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(76, 16)
        Me.Lb8.TabIndex = 100332
        Me.Lb8.Text = "Concepto"
        '
        'TxDato_8
        '
        Me.TxDato_8.Autonumerico = False
        Me.TxDato_8.Buscando = False
        Me.TxDato_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_8.ClForm = Nothing
        Me.TxDato_8.ClParam = Nothing
        Me.TxDato_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_8.GridLin = Nothing
        Me.TxDato_8.HaCambiado = False
        Me.TxDato_8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_8.lbbusca = Nothing
        Me.TxDato_8.Location = New System.Drawing.Point(125, 306)
        Me.TxDato_8.MiError = False
        Me.TxDato_8.Name = "TxDato_8"
        Me.TxDato_8.Orden = 0
        Me.TxDato_8.SaltoAlfinal = False
        Me.TxDato_8.Siguiente = 0
        Me.TxDato_8.Size = New System.Drawing.Size(276, 22)
        Me.TxDato_8.TabIndex = 100331
        Me.TxDato_8.TeclaRepetida = False
        Me.TxDato_8.TxDatoFinalSemana = Nothing
        Me.TxDato_8.TxDatoInicioSemana = Nothing
        Me.TxDato_8.UltimoValorValidado = Nothing
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(21, 340)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(91, 16)
        Me.Lb9.TabIndex = 100334
        Me.Lb9.Text = "Documento"
        '
        'TxDato_9
        '
        Me.TxDato_9.Autonumerico = False
        Me.TxDato_9.Buscando = False
        Me.TxDato_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_9.ClForm = Nothing
        Me.TxDato_9.ClParam = Nothing
        Me.TxDato_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_9.GridLin = Nothing
        Me.TxDato_9.HaCambiado = False
        Me.TxDato_9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_9.lbbusca = Nothing
        Me.TxDato_9.Location = New System.Drawing.Point(125, 337)
        Me.TxDato_9.MiError = False
        Me.TxDato_9.Name = "TxDato_9"
        Me.TxDato_9.Orden = 0
        Me.TxDato_9.SaltoAlfinal = False
        Me.TxDato_9.Siguiente = 0
        Me.TxDato_9.Size = New System.Drawing.Size(276, 22)
        Me.TxDato_9.TabIndex = 100333
        Me.TxDato_9.TeclaRepetida = False
        Me.TxDato_9.TxDatoFinalSemana = Nothing
        Me.TxDato_9.TxDatoInicioSemana = Nothing
        Me.TxDato_9.UltimoValorValidado = Nothing
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(125, 368)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(104, 22)
        Me.TxDato_10.TabIndex = 100336
        Me.TxDato_10.TeclaRepetida = False
        Me.TxDato_10.TxDatoFinalSemana = Nothing
        Me.TxDato_10.TxDatoInicioSemana = Nothing
        Me.TxDato_10.UltimoValorValidado = Nothing
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(21, 371)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(100, 16)
        Me.Lb10.TabIndex = 100335
        Me.Lb10.Text = "Base suplido"
        '
        'Lb_11
        '
        Me.Lb_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lb_11.CL_ControlAsociado = Nothing
        Me.Lb_11.CL_ValorFijo = False
        Me.Lb_11.ClForm = Nothing
        Me.Lb_11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_11.Location = New System.Drawing.Point(284, 400)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(335, 21)
        Me.Lb_11.TabIndex = 100340
        '
        'BtBusca_11
        '
        Me.BtBusca_11.CL_Ancho = 0
        Me.BtBusca_11.CL_BuscaAlb = False
        Me.BtBusca_11.CL_campocodigo = Nothing
        Me.BtBusca_11.CL_camponombre = Nothing
        Me.BtBusca_11.CL_CampoOrden = "Nombre"
        Me.BtBusca_11.CL_ch1000 = False
        Me.BtBusca_11.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_11.CL_ControlAsociado = Me.TxDato_11
        Me.BtBusca_11.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_11.CL_dfecha = Nothing
        Me.BtBusca_11.CL_Entidad = Nothing
        Me.BtBusca_11.CL_EsId = True
        Me.BtBusca_11.CL_Filtro = Nothing
        Me.BtBusca_11.cl_formu = Nothing
        Me.BtBusca_11.CL_hfecha = Nothing
        Me.BtBusca_11.cl_ListaW = Nothing
        Me.BtBusca_11.CL_xCentro = False
        Me.BtBusca_11.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_11.Location = New System.Drawing.Point(246, 399)
        Me.BtBusca_11.Name = "BtBusca_11"
        Me.BtBusca_11.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_11.TabIndex = 100339
        Me.BtBusca_11.UseVisualStyleBackColor = True
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(125, 399)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(120, 22)
        Me.TxDato_11.TabIndex = 100338
        Me.TxDato_11.TeclaRepetida = False
        Me.TxDato_11.TxDatoFinalSemana = Nothing
        Me.TxDato_11.TxDatoInicioSemana = Nothing
        Me.TxDato_11.UltimoValorValidado = Nothing
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(21, 402)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(89, 16)
        Me.Lb11.TabIndex = 100337
        Me.Lb11.Text = "Cta suplido"
        '
        'CbTipoId
        '
        Me.CbTipoId.Campobd = Nothing
        Me.CbTipoId.ClForm = Nothing
        Me.CbTipoId.DeshabilitarRuedaRaton = False
        Me.CbTipoId.FormattingEnabled = True
        Me.CbTipoId.GridLin = Nothing
        Me.CbTipoId.Location = New System.Drawing.Point(125, 90)
        Me.CbTipoId.MiEntidad = Nothing
        Me.CbTipoId.MiError = False
        Me.CbTipoId.Name = "CbTipoId"
        Me.CbTipoId.Orden = 0
        Me.CbTipoId.SaltoAlfinal = False
        Me.CbTipoId.Size = New System.Drawing.Size(207, 21)
        Me.CbTipoId.TabIndex = 100342
        '
        'LbTipoId
        '
        Me.LbTipoId.AutoSize = True
        Me.LbTipoId.CL_ControlAsociado = Nothing
        Me.LbTipoId.CL_ValorFijo = True
        Me.LbTipoId.ClForm = Nothing
        Me.LbTipoId.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoId.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoId.Location = New System.Drawing.Point(21, 92)
        Me.LbTipoId.Name = "LbTipoId"
        Me.LbTipoId.Size = New System.Drawing.Size(62, 16)
        Me.LbTipoId.TabIndex = 100341
        Me.LbTipoId.Text = "Tipo Id."
        '
        'TxPais
        '
        Me.TxPais.Autonumerico = False
        Me.TxPais.Buscando = False
        Me.TxPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPais.ClForm = Nothing
        Me.TxPais.ClParam = Nothing
        Me.TxPais.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPais.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPais.GridLin = Nothing
        Me.TxPais.HaCambiado = False
        Me.TxPais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPais.lbbusca = Nothing
        Me.TxPais.Location = New System.Drawing.Point(125, 120)
        Me.TxPais.MiError = False
        Me.TxPais.Name = "TxPais"
        Me.TxPais.Orden = 0
        Me.TxPais.SaltoAlfinal = False
        Me.TxPais.Siguiente = 0
        Me.TxPais.Size = New System.Drawing.Size(40, 22)
        Me.TxPais.TabIndex = 100344
        Me.TxPais.TeclaRepetida = False
        Me.TxPais.TxDatoFinalSemana = Nothing
        Me.TxPais.TxDatoInicioSemana = Nothing
        Me.TxPais.UltimoValorValidado = Nothing
        '
        'LbPais
        '
        Me.LbPais.AutoSize = True
        Me.LbPais.CL_ControlAsociado = Nothing
        Me.LbPais.CL_ValorFijo = True
        Me.LbPais.ClForm = Nothing
        Me.LbPais.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPais.ForeColor = System.Drawing.Color.Teal
        Me.LbPais.Location = New System.Drawing.Point(21, 123)
        Me.LbPais.Name = "LbPais"
        Me.LbPais.Size = New System.Drawing.Size(38, 16)
        Me.LbPais.TabIndex = 100343
        Me.LbPais.Text = "Pais"
        '
        'frmFacturasRecibidasImportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(656, 492)
        Me.Controls.Add(Me.TxPais)
        Me.Controls.Add(Me.LbPais)
        Me.Controls.Add(Me.CbTipoId)
        Me.Controls.Add(Me.LbTipoId)
        Me.Controls.Add(Me.Lb_11)
        Me.Controls.Add(Me.BtBusca_11)
        Me.Controls.Add(Me.TxDato_11)
        Me.Controls.Add(Me.Lb11)
        Me.Controls.Add(Me.TxDato_10)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.TxDato_9)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.TxDato_8)
        Me.Controls.Add(Me.TxDato_7)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.TxDato_6)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.btSumar)
        Me.Controls.Add(Me.TxDato_5)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb_4)
        Me.Controls.Add(Me.BtBusca_4)
        Me.Controls.Add(Me.TxDato_4)
        Me.Controls.Add(Me.Lb_3)
        Me.Controls.Add(Me.BtBusca_3)
        Me.Controls.Add(Me.TxNIF)
        Me.Controls.Add(Me.Lb_2)
        Me.Controls.Add(Me.BtBusca_2)
        Me.Controls.Add(Me.TxDato_2)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato_1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "frmFacturasRecibidasImportaciones"
        Me.Text = "Importaciones"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato_1, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.TxDato_2, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_2, 0)
        Me.Controls.SetChildIndex(Me.Lb_2, 0)
        Me.Controls.SetChildIndex(Me.TxNIF, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_3, 0)
        Me.Controls.SetChildIndex(Me.Lb_3, 0)
        Me.Controls.SetChildIndex(Me.TxDato_4, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_4, 0)
        Me.Controls.SetChildIndex(Me.Lb_4, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.TxDato_5, 0)
        Me.Controls.SetChildIndex(Me.btSumar, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.TxDato_6, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.TxDato_7, 0)
        Me.Controls.SetChildIndex(Me.TxDato_8, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.Controls.SetChildIndex(Me.TxDato_9, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.TxDato_10, 0)
        Me.Controls.SetChildIndex(Me.Lb11, 0)
        Me.Controls.SetChildIndex(Me.TxDato_11, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_11, 0)
        Me.Controls.SetChildIndex(Me.Lb_11, 0)
        Me.Controls.SetChildIndex(Me.LbTipoId, 0)
        Me.Controls.SetChildIndex(Me.CbTipoId, 0)
        Me.Controls.SetChildIndex(Me.LbPais, 0)
        Me.Controls.SetChildIndex(Me.TxPais, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents BtBusca_2 As NetAgro.BtBusca
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents BtBusca_3 As NetAgro.BtBusca
    Friend WithEvents TxNIF As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents BtBusca_4 As NetAgro.BtBusca
    Friend WithEvents TxDato_4 As NetAgro.TxDato
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents btSumar As System.Windows.Forms.Button
    Friend WithEvents TxDato_6 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato_7 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents TxDato_8 As NetAgro.TxDato
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato_9 As NetAgro.TxDato
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents BtBusca_11 As NetAgro.BtBusca
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents CbTipoId As NetAgro.CbBox
    Friend WithEvents LbTipoId As NetAgro.Lb
    Friend WithEvents TxPais As NetAgro.TxDato
    Friend WithEvents LbPais As NetAgro.Lb

End Class
