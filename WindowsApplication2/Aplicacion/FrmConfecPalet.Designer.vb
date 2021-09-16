<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfecPalet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfecPalet))
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.BtBuscaEnvase = New NetAgro.BtBusca(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaConfec = New NetAgro.BtBusca(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbTotalTara = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.LbUmedida = New NetAgro.Lb(Me.components)
        Me.LbCoeficiente = New NetAgro.Lb(Me.components)
        Me.TxCoeficiente = New NetAgro.TxDato(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb9
        '
        Me.Lb9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.Location = New System.Drawing.Point(307, 226)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(89, 23)
        Me.Lb9.TabIndex = 108
        Me.Lb9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(250, 229)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(40, 16)
        Me.Lb11.TabIndex = 107
        Me.Lb11.Text = "Tara"
        '
        'Lb7
        '
        Me.Lb7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.Location = New System.Drawing.Point(149, 226)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(78, 23)
        Me.Lb7.TabIndex = 106
        Me.Lb7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(12, 229)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(120, 16)
        Me.Lb6.TabIndex = 105
        Me.Lb6.Text = "Coste de Salida"
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(149, 197)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(78, 22)
        Me.TxDato5.TabIndex = 104
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
        Me.Lb5.Location = New System.Drawing.Point(12, 200)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(127, 16)
        Me.Lb5.TabIndex = 103
        Me.Lb5.Text = "Cantidad x palet"
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.Location = New System.Drawing.Point(253, 169)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(288, 23)
        Me.Lb10.TabIndex = 102
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
        Me.BtBuscaEnvase.CL_ControlAsociado = Nothing
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
        Me.BtBuscaEnvase.Location = New System.Drawing.Point(214, 169)
        Me.BtBuscaEnvase.Name = "BtBuscaEnvase"
        Me.BtBuscaEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaEnvase.TabIndex = 101
        Me.BtBuscaEnvase.UseVisualStyleBackColor = True
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(147, 169)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(63, 22)
        Me.TxDato4.TabIndex = 100
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
        Me.Lb4.Location = New System.Drawing.Point(12, 172)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(129, 16)
        Me.Lb4.TabIndex = 99
        Me.Lb4.Text = "Envase/Material"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 74)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(94, 16)
        Me.Lb3.TabIndex = 95
        Me.Lb3.Text = "Abreviatura"
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
        Me.TxDato3.Location = New System.Drawing.Point(109, 71)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(229, 22)
        Me.TxDato3.TabIndex = 94
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
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
        Me.TxDato1.Location = New System.Drawing.Point(109, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 93
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.BtBuscaConfec.Location = New System.Drawing.Point(178, 12)
        Me.BtBuscaConfec.Name = "BtBuscaConfec"
        Me.BtBuscaConfec.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaConfec.TabIndex = 92
        Me.BtBuscaConfec.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 47)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 91
        Me.Lb2.Text = "Nombre"
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
        Me.TxDato2.Location = New System.Drawing.Point(109, 44)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(379, 22)
        Me.TxDato2.TabIndex = 90
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(222, 13)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 88
        Me.BotonesAvance1.Udato = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 89
        Me.Lb1.Text = "Código"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LbTotalTara)
        Me.Panel2.Controls.Add(Me.Lb13)
        Me.Panel2.Controls.Add(Me.TxDato6)
        Me.Panel2.Controls.Add(Me.Lb8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 54)
        Me.Panel2.TabIndex = 109
        '
        'LbTotalTara
        '
        Me.LbTotalTara.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbTotalTara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTotalTara.CL_ControlAsociado = Nothing
        Me.LbTotalTara.CL_ValorFijo = False
        Me.LbTotalTara.ClForm = Nothing
        Me.LbTotalTara.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalTara.Location = New System.Drawing.Point(444, 22)
        Me.LbTotalTara.Name = "LbTotalTara"
        Me.LbTotalTara.Size = New System.Drawing.Size(97, 23)
        Me.LbTotalTara.TabIndex = 91
        Me.LbTotalTara.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(461, 3)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(80, 16)
        Me.Lb13.TabIndex = 90
        Me.Lb13.Text = "Total Tara"
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(268, 22)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(78, 22)
        Me.TxDato6.TabIndex = 72
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(246, 3)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(127, 16)
        Me.Lb8.TabIndex = 71
        Me.Lb8.Text = "Incremento tara"
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 266)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(574, 156)
        Me.ClGrid1.TabIndex = 110
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(402, 229)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(26, 16)
        Me.Lb14.TabIndex = 112
        Me.Lb14.Text = "Kg"
        '
        'LbUmedida
        '
        Me.LbUmedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbUmedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbUmedida.CL_ControlAsociado = Nothing
        Me.LbUmedida.CL_ValorFijo = False
        Me.LbUmedida.ClForm = Nothing
        Me.LbUmedida.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUmedida.Location = New System.Drawing.Point(253, 197)
        Me.LbUmedida.Name = "LbUmedida"
        Me.LbUmedida.Size = New System.Drawing.Size(82, 23)
        Me.LbUmedida.TabIndex = 111
        '
        'LbCoeficiente
        '
        Me.LbCoeficiente.AutoSize = True
        Me.LbCoeficiente.CL_ControlAsociado = Nothing
        Me.LbCoeficiente.CL_ValorFijo = False
        Me.LbCoeficiente.ClForm = Nothing
        Me.LbCoeficiente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCoeficiente.ForeColor = System.Drawing.Color.Teal
        Me.LbCoeficiente.Location = New System.Drawing.Point(12, 102)
        Me.LbCoeficiente.Name = "LbCoeficiente"
        Me.LbCoeficiente.Size = New System.Drawing.Size(90, 16)
        Me.LbCoeficiente.TabIndex = 114
        Me.LbCoeficiente.Text = "Coeficiente"
        '
        'TxCoeficiente
        '
        Me.TxCoeficiente.Autonumerico = False
        Me.TxCoeficiente.Buscando = False
        Me.TxCoeficiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCoeficiente.ClForm = Nothing
        Me.TxCoeficiente.ClParam = Nothing
        Me.TxCoeficiente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCoeficiente.GridLin = Nothing
        Me.TxCoeficiente.HaCambiado = False
        Me.TxCoeficiente.lbbusca = Nothing
        Me.TxCoeficiente.Location = New System.Drawing.Point(109, 99)
        Me.TxCoeficiente.MiError = False
        Me.TxCoeficiente.Name = "TxCoeficiente"
        Me.TxCoeficiente.Orden = 0
        Me.TxCoeficiente.SaltoAlfinal = False
        Me.TxCoeficiente.Siguiente = 0
        Me.TxCoeficiente.Size = New System.Drawing.Size(63, 22)
        Me.TxCoeficiente.TabIndex = 113
        Me.TxCoeficiente.TeclaRepetida = False
        Me.TxCoeficiente.TxDatoFinalSemana = Nothing
        Me.TxCoeficiente.TxDatoInicioSemana = Nothing
        Me.TxCoeficiente.UltimoValorValidado = Nothing
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(178, 103)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(276, 14)
        Me.Lb12.TabIndex = 115
        Me.Lb12.Text = "(0 = No ocupa Hueco, 1 = Ocupa Hueco)"
        '
        'FrmConfecPalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 510)
        Me.Controls.Add(Me.Lb12)
        Me.Controls.Add(Me.LbCoeficiente)
        Me.Controls.Add(Me.TxCoeficiente)
        Me.Controls.Add(Me.Lb14)
        Me.Controls.Add(Me.LbUmedida)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.Lb11)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.TxDato5)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.BtBuscaEnvase)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBuscaConfec)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConfecPalet"
        Me.Text = "Confeccionar Palet"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaConfec, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaEnvase, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.TxDato5, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.Lb11, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.Controls.SetChildIndex(Me.LbUmedida, 0)
        Me.Controls.SetChildIndex(Me.Lb14, 0)
        Me.Controls.SetChildIndex(Me.TxCoeficiente, 0)
        Me.Controls.SetChildIndex(Me.LbCoeficiente, 0)
        Me.Controls.SetChildIndex(Me.Lb12, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents BtBuscaEnvase As NetAgro.BtBusca
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBuscaConfec As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbTotalTara As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents LbUmedida As NetAgro.Lb
    Friend WithEvents LbCoeficiente As NetAgro.Lb
    Friend WithEvents TxCoeficiente As NetAgro.TxDato
    Friend WithEvents Lb12 As NetAgro.Lb
End Class
