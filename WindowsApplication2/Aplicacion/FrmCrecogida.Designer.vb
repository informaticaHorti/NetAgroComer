<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrecogida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrecogida))
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaFRM = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbnom13 = New NetAgro.Lb(Me.components)
        Me.TxDato13 = New NetAgro.TxDato(Me.components)
        Me.BtBusca13 = New NetAgro.BtBusca(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.Lbnom12 = New NetAgro.Lb(Me.components)
        Me.TxDato12 = New NetAgro.TxDato(Me.components)
        Me.BtBusca12 = New NetAgro.BtBusca(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.LbNom11 = New NetAgro.Lb(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.BtBusca11 = New NetAgro.BtBusca(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbNomAlmacen = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlmacen = New NetAgro.BtBusca(Me.components)
        Me.TxAlmacen = New NetAgro.TxDato(Me.components)
        Me.LbAlmacen = New NetAgro.Lb(Me.components)
        Me.TxCopiasBoletinMuestreo = New NetAgro.TxDato(Me.components)
        Me.LbCopiasBoletinMuestreo = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxCopiasAlbaranEntrada = New NetAgro.TxDato(Me.components)
        Me.LbCopiasAlbaranEntrada = New NetAgro.Lb(Me.components)
        Me.Panel3.SuspendLayout()
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
        Me.Lb2.Location = New System.Drawing.Point(12, 54)
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
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
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
        Me.TxDato1.Location = New System.Drawing.Point(82, 10)
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
        Me.TxDato2.Location = New System.Drawing.Point(82, 51)
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
        'BtBuscaFRM
        '
        Me.BtBuscaFRM.CL_Ancho = 0
        Me.BtBuscaFRM.CL_BuscaAlb = False
        Me.BtBuscaFRM.CL_campocodigo = Nothing
        Me.BtBuscaFRM.CL_camponombre = Nothing
        Me.BtBuscaFRM.CL_CampoOrden = "Nombre"
        Me.BtBuscaFRM.CL_ch1000 = False
        Me.BtBuscaFRM.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFRM.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaFRM.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFRM.CL_dfecha = Nothing
        Me.BtBuscaFRM.CL_Entidad = Nothing
        Me.BtBuscaFRM.CL_EsId = True
        Me.BtBuscaFRM.CL_Filtro = Nothing
        Me.BtBuscaFRM.cl_formu = Nothing
        Me.BtBuscaFRM.CL_hfecha = Nothing
        Me.BtBuscaFRM.cl_ListaW = Nothing
        Me.BtBuscaFRM.CL_xCentro = False
        Me.BtBuscaFRM.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaFRM.Location = New System.Drawing.Point(134, 10)
        Me.BtBuscaFRM.Name = "BtBuscaFRM"
        Me.BtBuscaFRM.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFRM.TabIndex = 76
        Me.BtBuscaFRM.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(173, 9)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Lbnom13)
        Me.Panel3.Controls.Add(Me.TxDato13)
        Me.Panel3.Controls.Add(Me.BtBusca13)
        Me.Panel3.Controls.Add(Me.Lb13)
        Me.Panel3.Controls.Add(Me.Lbnom12)
        Me.Panel3.Controls.Add(Me.TxDato12)
        Me.Panel3.Controls.Add(Me.BtBusca12)
        Me.Panel3.Controls.Add(Me.Lb12)
        Me.Panel3.Controls.Add(Me.LbNom11)
        Me.Panel3.Controls.Add(Me.TxDato11)
        Me.Panel3.Controls.Add(Me.BtBusca11)
        Me.Panel3.Controls.Add(Me.Lb11)
        Me.Panel3.Controls.Add(Me.Lb15)
        Me.Panel3.Controls.Add(Me.ClGrid1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(642, 327)
        Me.Panel3.TabIndex = 104
        '
        'Lbnom13
        '
        Me.Lbnom13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom13.CL_ControlAsociado = Nothing
        Me.Lbnom13.CL_ValorFijo = False
        Me.Lbnom13.ClForm = Nothing
        Me.Lbnom13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom13.Location = New System.Drawing.Point(172, 102)
        Me.Lbnom13.Name = "Lbnom13"
        Me.Lbnom13.Size = New System.Drawing.Size(367, 23)
        Me.Lbnom13.TabIndex = 116
        '
        'TxDato13
        '
        Me.TxDato13.Autonumerico = False
        Me.TxDato13.Buscando = False
        Me.TxDato13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato13.ClForm = Nothing
        Me.TxDato13.ClParam = Nothing
        Me.TxDato13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato13.GridLin = Nothing
        Me.TxDato13.HaCambiado = False
        Me.TxDato13.lbbusca = Nothing
        Me.TxDato13.Location = New System.Drawing.Point(91, 102)
        Me.TxDato13.MiError = False
        Me.TxDato13.Name = "TxDato13"
        Me.TxDato13.Orden = 0
        Me.TxDato13.SaltoAlfinal = False
        Me.TxDato13.Siguiente = 0
        Me.TxDato13.Size = New System.Drawing.Size(38, 22)
        Me.TxDato13.TabIndex = 115
        Me.TxDato13.TeclaRepetida = False
        Me.TxDato13.TxDatoFinalSemana = Nothing
        Me.TxDato13.TxDatoInicioSemana = Nothing
        Me.TxDato13.UltimoValorValidado = Nothing
        '
        'BtBusca13
        '
        Me.BtBusca13.CL_Ancho = 0
        Me.BtBusca13.CL_BuscaAlb = False
        Me.BtBusca13.CL_campocodigo = Nothing
        Me.BtBusca13.CL_camponombre = Nothing
        Me.BtBusca13.CL_CampoOrden = "Nombre"
        Me.BtBusca13.CL_ch1000 = False
        Me.BtBusca13.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca13.CL_ControlAsociado = Nothing
        Me.BtBusca13.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca13.CL_dfecha = Nothing
        Me.BtBusca13.CL_Entidad = Nothing
        Me.BtBusca13.CL_EsId = True
        Me.BtBusca13.CL_Filtro = Nothing
        Me.BtBusca13.cl_formu = Nothing
        Me.BtBusca13.CL_hfecha = Nothing
        Me.BtBusca13.cl_ListaW = Nothing
        Me.BtBusca13.CL_xCentro = False
        Me.BtBusca13.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca13.Location = New System.Drawing.Point(132, 102)
        Me.BtBusca13.Name = "BtBusca13"
        Me.BtBusca13.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca13.TabIndex = 114
        Me.BtBusca13.UseVisualStyleBackColor = True
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = False
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(9, 105)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(74, 16)
        Me.Lb13.TabIndex = 113
        Me.Lb13.Text = "Actividad"
        '
        'Lbnom12
        '
        Me.Lbnom12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom12.CL_ControlAsociado = Nothing
        Me.Lbnom12.CL_ValorFijo = False
        Me.Lbnom12.ClForm = Nothing
        Me.Lbnom12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom12.Location = New System.Drawing.Point(172, 73)
        Me.Lbnom12.Name = "Lbnom12"
        Me.Lbnom12.Size = New System.Drawing.Size(367, 23)
        Me.Lbnom12.TabIndex = 112
        '
        'TxDato12
        '
        Me.TxDato12.Autonumerico = False
        Me.TxDato12.Buscando = False
        Me.TxDato12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato12.ClForm = Nothing
        Me.TxDato12.ClParam = Nothing
        Me.TxDato12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato12.GridLin = Nothing
        Me.TxDato12.HaCambiado = False
        Me.TxDato12.lbbusca = Nothing
        Me.TxDato12.Location = New System.Drawing.Point(91, 73)
        Me.TxDato12.MiError = False
        Me.TxDato12.Name = "TxDato12"
        Me.TxDato12.Orden = 0
        Me.TxDato12.SaltoAlfinal = False
        Me.TxDato12.Siguiente = 0
        Me.TxDato12.Size = New System.Drawing.Size(38, 22)
        Me.TxDato12.TabIndex = 111
        Me.TxDato12.TeclaRepetida = False
        Me.TxDato12.TxDatoFinalSemana = Nothing
        Me.TxDato12.TxDatoInicioSemana = Nothing
        Me.TxDato12.UltimoValorValidado = Nothing
        '
        'BtBusca12
        '
        Me.BtBusca12.CL_Ancho = 0
        Me.BtBusca12.CL_BuscaAlb = False
        Me.BtBusca12.CL_campocodigo = Nothing
        Me.BtBusca12.CL_camponombre = Nothing
        Me.BtBusca12.CL_CampoOrden = "Nombre"
        Me.BtBusca12.CL_ch1000 = False
        Me.BtBusca12.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca12.CL_ControlAsociado = Nothing
        Me.BtBusca12.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca12.CL_dfecha = Nothing
        Me.BtBusca12.CL_Entidad = Nothing
        Me.BtBusca12.CL_EsId = True
        Me.BtBusca12.CL_Filtro = Nothing
        Me.BtBusca12.cl_formu = Nothing
        Me.BtBusca12.CL_hfecha = Nothing
        Me.BtBusca12.cl_ListaW = Nothing
        Me.BtBusca12.CL_xCentro = False
        Me.BtBusca12.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca12.Location = New System.Drawing.Point(132, 73)
        Me.BtBusca12.Name = "BtBusca12"
        Me.BtBusca12.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca12.TabIndex = 110
        Me.BtBusca12.UseVisualStyleBackColor = True
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = False
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(9, 76)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(61, 16)
        Me.Lb12.TabIndex = 109
        Me.Lb12.Text = "Sección"
        '
        'LbNom11
        '
        Me.LbNom11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom11.CL_ControlAsociado = Nothing
        Me.LbNom11.CL_ValorFijo = False
        Me.LbNom11.ClForm = Nothing
        Me.LbNom11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom11.Location = New System.Drawing.Point(172, 44)
        Me.LbNom11.Name = "LbNom11"
        Me.LbNom11.Size = New System.Drawing.Size(367, 23)
        Me.LbNom11.TabIndex = 108
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(91, 44)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(38, 22)
        Me.TxDato11.TabIndex = 107
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.TxDatoFinalSemana = Nothing
        Me.TxDato11.TxDatoInicioSemana = Nothing
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'BtBusca11
        '
        Me.BtBusca11.CL_Ancho = 0
        Me.BtBusca11.CL_BuscaAlb = False
        Me.BtBusca11.CL_campocodigo = Nothing
        Me.BtBusca11.CL_camponombre = Nothing
        Me.BtBusca11.CL_CampoOrden = "Nombre"
        Me.BtBusca11.CL_ch1000 = False
        Me.BtBusca11.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca11.CL_ControlAsociado = Nothing
        Me.BtBusca11.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca11.CL_dfecha = Nothing
        Me.BtBusca11.CL_Entidad = Nothing
        Me.BtBusca11.CL_EsId = True
        Me.BtBusca11.CL_Filtro = Nothing
        Me.BtBusca11.cl_formu = Nothing
        Me.BtBusca11.CL_hfecha = Nothing
        Me.BtBusca11.cl_ListaW = Nothing
        Me.BtBusca11.CL_xCentro = False
        Me.BtBusca11.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca11.Location = New System.Drawing.Point(132, 44)
        Me.BtBusca11.Name = "BtBusca11"
        Me.BtBusca11.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca11.TabIndex = 106
        Me.BtBusca11.UseVisualStyleBackColor = True
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(9, 47)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(59, 16)
        Me.Lb11.TabIndex = 105
        Me.Lb11.Text = "PVenta"
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Blue
        Me.Lb15.Location = New System.Drawing.Point(6, 16)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(159, 18)
        Me.Lb15.TabIndex = 104
        Me.Lb15.Text = "Contabilizaciones"
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
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 142)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(642, 185)
        Me.ClGrid1.TabIndex = 103
        Me.ClGrid1.UltimoControl = 0
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
        Me.TxDato3.Location = New System.Drawing.Point(578, 51)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(30, 22)
        Me.TxDato3.TabIndex = 106
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
        Me.Lb3.Location = New System.Drawing.Point(432, 54)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(140, 16)
        Me.Lb3.TabIndex = 105
        Me.Lb3.Text = "Entrada alhondiga"
        '
        'LbNomAlmacen
        '
        Me.LbNomAlmacen.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomAlmacen.CL_ControlAsociado = Nothing
        Me.LbNomAlmacen.CL_ValorFijo = False
        Me.LbNomAlmacen.ClForm = Nothing
        Me.LbNomAlmacen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAlmacen.Location = New System.Drawing.Point(212, 82)
        Me.LbNomAlmacen.Name = "LbNomAlmacen"
        Me.LbNomAlmacen.Size = New System.Drawing.Size(396, 21)
        Me.LbNomAlmacen.TabIndex = 215
        '
        'BtBuscaAlmacen
        '
        Me.BtBuscaAlmacen.CL_Ancho = 0
        Me.BtBuscaAlmacen.CL_BuscaAlb = False
        Me.BtBuscaAlmacen.CL_campocodigo = Nothing
        Me.BtBuscaAlmacen.CL_camponombre = Nothing
        Me.BtBuscaAlmacen.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlmacen.CL_ch1000 = False
        Me.BtBuscaAlmacen.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlmacen.CL_ControlAsociado = Me.TxAlmacen
        Me.BtBuscaAlmacen.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlmacen.CL_dfecha = Nothing
        Me.BtBuscaAlmacen.CL_Entidad = Nothing
        Me.BtBuscaAlmacen.CL_EsId = True
        Me.BtBuscaAlmacen.CL_Filtro = Nothing
        Me.BtBuscaAlmacen.cl_formu = Nothing
        Me.BtBuscaAlmacen.CL_hfecha = Nothing
        Me.BtBuscaAlmacen.cl_ListaW = Nothing
        Me.BtBuscaAlmacen.CL_xCentro = False
        Me.BtBuscaAlmacen.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlmacen.Location = New System.Drawing.Point(173, 81)
        Me.BtBuscaAlmacen.Name = "BtBuscaAlmacen"
        Me.BtBuscaAlmacen.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlmacen.TabIndex = 214
        Me.BtBuscaAlmacen.UseVisualStyleBackColor = True
        '
        'TxAlmacen
        '
        Me.TxAlmacen.Autonumerico = False
        Me.TxAlmacen.Buscando = False
        Me.TxAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlmacen.ClForm = Nothing
        Me.TxAlmacen.ClParam = Nothing
        Me.TxAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAlmacen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlmacen.GridLin = Nothing
        Me.TxAlmacen.HaCambiado = False
        Me.TxAlmacen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAlmacen.lbbusca = Nothing
        Me.TxAlmacen.Location = New System.Drawing.Point(125, 81)
        Me.TxAlmacen.MiError = False
        Me.TxAlmacen.Name = "TxAlmacen"
        Me.TxAlmacen.Orden = 0
        Me.TxAlmacen.SaltoAlfinal = False
        Me.TxAlmacen.Siguiente = 0
        Me.TxAlmacen.Size = New System.Drawing.Size(42, 22)
        Me.TxAlmacen.TabIndex = 213
        Me.TxAlmacen.TeclaRepetida = False
        Me.TxAlmacen.TxDatoFinalSemana = Nothing
        Me.TxAlmacen.TxDatoInicioSemana = Nothing
        Me.TxAlmacen.UltimoValorValidado = Nothing
        '
        'LbAlmacen
        '
        Me.LbAlmacen.AutoSize = True
        Me.LbAlmacen.CL_ControlAsociado = Nothing
        Me.LbAlmacen.CL_ValorFijo = False
        Me.LbAlmacen.ClForm = Nothing
        Me.LbAlmacen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlmacen.ForeColor = System.Drawing.Color.Teal
        Me.LbAlmacen.Location = New System.Drawing.Point(12, 84)
        Me.LbAlmacen.Name = "LbAlmacen"
        Me.LbAlmacen.Size = New System.Drawing.Size(107, 16)
        Me.LbAlmacen.TabIndex = 212
        Me.LbAlmacen.Text = "Almacen Env."
        '
        'TxCopiasBoletinMuestreo
        '
        Me.TxCopiasBoletinMuestreo.Autonumerico = False
        Me.TxCopiasBoletinMuestreo.Buscando = False
        Me.TxCopiasBoletinMuestreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCopiasBoletinMuestreo.ClForm = Nothing
        Me.TxCopiasBoletinMuestreo.ClParam = Nothing
        Me.TxCopiasBoletinMuestreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCopiasBoletinMuestreo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCopiasBoletinMuestreo.GridLin = Nothing
        Me.TxCopiasBoletinMuestreo.HaCambiado = False
        Me.TxCopiasBoletinMuestreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCopiasBoletinMuestreo.lbbusca = Nothing
        Me.TxCopiasBoletinMuestreo.Location = New System.Drawing.Point(212, 109)
        Me.TxCopiasBoletinMuestreo.MiError = False
        Me.TxCopiasBoletinMuestreo.Name = "TxCopiasBoletinMuestreo"
        Me.TxCopiasBoletinMuestreo.Orden = 0
        Me.TxCopiasBoletinMuestreo.SaltoAlfinal = False
        Me.TxCopiasBoletinMuestreo.Siguiente = 0
        Me.TxCopiasBoletinMuestreo.Size = New System.Drawing.Size(30, 22)
        Me.TxCopiasBoletinMuestreo.TabIndex = 217
        Me.TxCopiasBoletinMuestreo.TeclaRepetida = False
        Me.TxCopiasBoletinMuestreo.TxDatoFinalSemana = Nothing
        Me.TxCopiasBoletinMuestreo.TxDatoInicioSemana = Nothing
        Me.TxCopiasBoletinMuestreo.UltimoValorValidado = Nothing
        '
        'LbCopiasBoletinMuestreo
        '
        Me.LbCopiasBoletinMuestreo.AutoSize = True
        Me.LbCopiasBoletinMuestreo.CL_ControlAsociado = Nothing
        Me.LbCopiasBoletinMuestreo.CL_ValorFijo = False
        Me.LbCopiasBoletinMuestreo.ClForm = Nothing
        Me.LbCopiasBoletinMuestreo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCopiasBoletinMuestreo.ForeColor = System.Drawing.Color.Teal
        Me.LbCopiasBoletinMuestreo.Location = New System.Drawing.Point(12, 112)
        Me.LbCopiasBoletinMuestreo.Name = "LbCopiasBoletinMuestreo"
        Me.LbCopiasBoletinMuestreo.Size = New System.Drawing.Size(185, 16)
        Me.LbCopiasBoletinMuestreo.TabIndex = 216
        Me.LbCopiasBoletinMuestreo.Text = "Copias boletín muestreo"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(248, 114)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(79, 13)
        Me.Lb4.TabIndex = 218
        Me.Lb4.Text = "(vacío = 2)"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(248, 139)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(79, 13)
        Me.Lb5.TabIndex = 221
        Me.Lb5.Text = "(vacío = 2)"
        '
        'TxCopiasAlbaranEntrada
        '
        Me.TxCopiasAlbaranEntrada.Autonumerico = False
        Me.TxCopiasAlbaranEntrada.Buscando = False
        Me.TxCopiasAlbaranEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCopiasAlbaranEntrada.ClForm = Nothing
        Me.TxCopiasAlbaranEntrada.ClParam = Nothing
        Me.TxCopiasAlbaranEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCopiasAlbaranEntrada.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCopiasAlbaranEntrada.GridLin = Nothing
        Me.TxCopiasAlbaranEntrada.HaCambiado = False
        Me.TxCopiasAlbaranEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCopiasAlbaranEntrada.lbbusca = Nothing
        Me.TxCopiasAlbaranEntrada.Location = New System.Drawing.Point(212, 134)
        Me.TxCopiasAlbaranEntrada.MiError = False
        Me.TxCopiasAlbaranEntrada.Name = "TxCopiasAlbaranEntrada"
        Me.TxCopiasAlbaranEntrada.Orden = 0
        Me.TxCopiasAlbaranEntrada.SaltoAlfinal = False
        Me.TxCopiasAlbaranEntrada.Siguiente = 0
        Me.TxCopiasAlbaranEntrada.Size = New System.Drawing.Size(30, 22)
        Me.TxCopiasAlbaranEntrada.TabIndex = 220
        Me.TxCopiasAlbaranEntrada.TeclaRepetida = False
        Me.TxCopiasAlbaranEntrada.TxDatoFinalSemana = Nothing
        Me.TxCopiasAlbaranEntrada.TxDatoInicioSemana = Nothing
        Me.TxCopiasAlbaranEntrada.UltimoValorValidado = Nothing
        '
        'LbCopiasAlbaranEntrada
        '
        Me.LbCopiasAlbaranEntrada.AutoSize = True
        Me.LbCopiasAlbaranEntrada.CL_ControlAsociado = Nothing
        Me.LbCopiasAlbaranEntrada.CL_ValorFijo = False
        Me.LbCopiasAlbaranEntrada.ClForm = Nothing
        Me.LbCopiasAlbaranEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCopiasAlbaranEntrada.ForeColor = System.Drawing.Color.Teal
        Me.LbCopiasAlbaranEntrada.Location = New System.Drawing.Point(12, 137)
        Me.LbCopiasAlbaranEntrada.Name = "LbCopiasAlbaranEntrada"
        Me.LbCopiasAlbaranEntrada.Size = New System.Drawing.Size(177, 16)
        Me.LbCopiasAlbaranEntrada.TabIndex = 219
        Me.LbCopiasAlbaranEntrada.Text = "Copias albarán entrada"
        '
        'FrmCrecogida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 525)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.TxCopiasAlbaranEntrada)
        Me.Controls.Add(Me.LbCopiasAlbaranEntrada)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.TxCopiasBoletinMuestreo)
        Me.Controls.Add(Me.LbCopiasBoletinMuestreo)
        Me.Controls.Add(Me.LbNomAlmacen)
        Me.Controls.Add(Me.BtBuscaAlmacen)
        Me.Controls.Add(Me.TxAlmacen)
        Me.Controls.Add(Me.LbAlmacen)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaFRM)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCrecogida"
        Me.Text = "Centros de Recogida"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaFRM, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.LbAlmacen, 0)
        Me.Controls.SetChildIndex(Me.TxAlmacen, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAlmacen, 0)
        Me.Controls.SetChildIndex(Me.LbNomAlmacen, 0)
        Me.Controls.SetChildIndex(Me.LbCopiasBoletinMuestreo, 0)
        Me.Controls.SetChildIndex(Me.TxCopiasBoletinMuestreo, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.LbCopiasAlbaranEntrada, 0)
        Me.Controls.SetChildIndex(Me.TxCopiasAlbaranEntrada, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaFRM As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lbnom13 As NetAgro.Lb
    Friend WithEvents TxDato13 As NetAgro.TxDato
    Friend WithEvents BtBusca13 As NetAgro.BtBusca
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents Lbnom12 As NetAgro.Lb
    Friend WithEvents TxDato12 As NetAgro.TxDato
    Friend WithEvents BtBusca12 As NetAgro.BtBusca
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents LbNom11 As NetAgro.Lb
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents BtBusca11 As NetAgro.BtBusca
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbNomAlmacen As NetAgro.Lb
    Friend WithEvents BtBuscaAlmacen As NetAgro.BtBusca
    Friend WithEvents TxAlmacen As NetAgro.TxDato
    Friend WithEvents LbAlmacen As NetAgro.Lb
    Friend WithEvents TxCopiasBoletinMuestreo As NetAgro.TxDato
    Friend WithEvents LbCopiasBoletinMuestreo As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxCopiasAlbaranEntrada As NetAgro.TxDato
    Friend WithEvents LbCopiasAlbaranEntrada As NetAgro.Lb
End Class
