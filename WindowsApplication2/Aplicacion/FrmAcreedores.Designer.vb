<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcreedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcreedores))
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxDias = New NetAgro.TxDato(Me.components)
        Me.LbDias = New NetAgro.Lb(Me.components)
        Me.LbNomTipo = New NetAgro.Lb(Me.components)
        Me.TxTipo = New NetAgro.TxDato(Me.components)
        Me.BtTipo = New NetAgro.BtBusca(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.LbNomBanco = New NetAgro.Lb(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.BtBanco = New NetAgro.BtBusca(Me.components)
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.TxProvincia = New NetAgro.TxDato(Me.components)
        Me.LbProvincia = New NetAgro.Lb(Me.components)
        Me.TxDato13 = New NetAgro.TxDato(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.TxDato14 = New NetAgro.TxDato(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.ChOrigen = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Lb_12 = New NetAgro.Lb(Me.components)
        Me.TxDato12 = New NetAgro.TxDato(Me.components)
        Me.BtBusca12 = New NetAgro.BtBusca(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.BtBusca7 = New NetAgro.BtBusca(Me.components)
        Me.TxCodigoFianza = New NetAgro.TxDato(Me.components)
        Me.LbCodigoFianza = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.ChOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(19, 13)
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
        Me.TxDato1.Location = New System.Drawing.Point(103, 10)
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
        'BtBusca1
        '
        Me.BtBusca1.CL_Ancho = 0
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
        Me.BtBusca1.CL_EsId = True
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.CL_xCentro = False
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(155, 10)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 76
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(203, 9)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxCodigoFianza)
        Me.Panel2.Controls.Add(Me.LbCodigoFianza)
        Me.Panel2.Controls.Add(Me.TxDias)
        Me.Panel2.Controls.Add(Me.LbDias)
        Me.Panel2.Controls.Add(Me.LbNomTipo)
        Me.Panel2.Controls.Add(Me.TxTipo)
        Me.Panel2.Controls.Add(Me.BtTipo)
        Me.Panel2.Controls.Add(Me.LbTipo)
        Me.Panel2.Controls.Add(Me.LbNomBanco)
        Me.Panel2.Controls.Add(Me.TxBanco)
        Me.Panel2.Controls.Add(Me.BtBanco)
        Me.Panel2.Controls.Add(Me.LbBanco)
        Me.Panel2.Controls.Add(Me.Lb6)
        Me.Panel2.Controls.Add(Me.TxDato6)
        Me.Panel2.Controls.Add(Me.BtBusca2)
        Me.Panel2.Controls.Add(Me.Lb15)
        Me.Panel2.Controls.Add(Me.TxProvincia)
        Me.Panel2.Controls.Add(Me.LbProvincia)
        Me.Panel2.Controls.Add(Me.TxDato13)
        Me.Panel2.Controls.Add(Me.Lb14)
        Me.Panel2.Controls.Add(Me.TxDato14)
        Me.Panel2.Controls.Add(Me.Lb13)
        Me.Panel2.Controls.Add(Me.ChOrigen)
        Me.Panel2.Controls.Add(Me.Lb_12)
        Me.Panel2.Controls.Add(Me.TxDato12)
        Me.Panel2.Controls.Add(Me.BtBusca12)
        Me.Panel2.Controls.Add(Me.Lb12)
        Me.Panel2.Controls.Add(Me.TxDato10)
        Me.Panel2.Controls.Add(Me.TxDato9)
        Me.Panel2.Controls.Add(Me.TxDato8)
        Me.Panel2.Controls.Add(Me.TxDato11)
        Me.Panel2.Controls.Add(Me.TxDato5)
        Me.Panel2.Controls.Add(Me.TxDato4)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Controls.Add(Me.Lb11)
        Me.Panel2.Controls.Add(Me.Lb10)
        Me.Panel2.Controls.Add(Me.Lb9)
        Me.Panel2.Controls.Add(Me.Lb8)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Location = New System.Drawing.Point(12, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 362)
        Me.Panel2.TabIndex = 169
        '
        'TxDias
        '
        Me.TxDias.Autonumerico = False
        Me.TxDias.Buscando = False
        Me.TxDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDias.ClForm = Nothing
        Me.TxDias.ClParam = Nothing
        Me.TxDias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDias.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDias.GridLin = Nothing
        Me.TxDias.HaCambiado = False
        Me.TxDias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDias.lbbusca = Nothing
        Me.TxDias.Location = New System.Drawing.Point(754, 298)
        Me.TxDias.MiError = False
        Me.TxDias.Name = "TxDias"
        Me.TxDias.Orden = 0
        Me.TxDias.SaltoAlfinal = False
        Me.TxDias.Siguiente = 0
        Me.TxDias.Size = New System.Drawing.Size(49, 22)
        Me.TxDias.TabIndex = 216
        Me.TxDias.TeclaRepetida = False
        Me.TxDias.TxDatoFinalSemana = Nothing
        Me.TxDias.TxDatoInicioSemana = Nothing
        Me.TxDias.UltimoValorValidado = Nothing
        '
        'LbDias
        '
        Me.LbDias.AutoSize = True
        Me.LbDias.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LbDias.CL_ControlAsociado = Nothing
        Me.LbDias.CL_ValorFijo = True
        Me.LbDias.ClForm = Nothing
        Me.LbDias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDias.ForeColor = System.Drawing.Color.Teal
        Me.LbDias.Location = New System.Drawing.Point(669, 304)
        Me.LbDias.Name = "LbDias"
        Me.LbDias.Size = New System.Drawing.Size(79, 16)
        Me.LbDias.TabIndex = 215
        Me.LbDias.Text = "Dias pago"
        '
        'LbNomTipo
        '
        Me.LbNomTipo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomTipo.CL_ControlAsociado = Nothing
        Me.LbNomTipo.CL_ValorFijo = False
        Me.LbNomTipo.ClForm = Nothing
        Me.LbNomTipo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTipo.Location = New System.Drawing.Point(371, 298)
        Me.LbNomTipo.Name = "LbNomTipo"
        Me.LbNomTipo.Size = New System.Drawing.Size(234, 23)
        Me.LbNomTipo.TabIndex = 214
        Me.LbNomTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxTipo
        '
        Me.TxTipo.Autonumerico = False
        Me.TxTipo.Buscando = False
        Me.TxTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipo.ClForm = Nothing
        Me.TxTipo.ClParam = Nothing
        Me.TxTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTipo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipo.GridLin = Nothing
        Me.TxTipo.HaCambiado = False
        Me.TxTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTipo.lbbusca = Nothing
        Me.TxTipo.Location = New System.Drawing.Point(275, 299)
        Me.TxTipo.MiError = False
        Me.TxTipo.Name = "TxTipo"
        Me.TxTipo.Orden = 0
        Me.TxTipo.SaltoAlfinal = False
        Me.TxTipo.Siguiente = 0
        Me.TxTipo.Size = New System.Drawing.Size(49, 22)
        Me.TxTipo.TabIndex = 212
        Me.TxTipo.TeclaRepetida = False
        Me.TxTipo.TxDatoFinalSemana = Nothing
        Me.TxTipo.TxDatoInicioSemana = Nothing
        Me.TxTipo.UltimoValorValidado = Nothing
        '
        'BtTipo
        '
        Me.BtTipo.CL_Ancho = 0
        Me.BtTipo.CL_BuscaAlb = False
        Me.BtTipo.CL_campocodigo = Nothing
        Me.BtTipo.CL_camponombre = Nothing
        Me.BtTipo.CL_CampoOrden = "Nombre"
        Me.BtTipo.CL_ch1000 = False
        Me.BtTipo.CL_ConsultaSql = "Select * from familias"
        Me.BtTipo.CL_ControlAsociado = Me.TxTipo
        Me.BtTipo.CL_DevuelveCampo = "Idfamilia"
        Me.BtTipo.CL_dfecha = Nothing
        Me.BtTipo.CL_Entidad = Nothing
        Me.BtTipo.CL_EsId = True
        Me.BtTipo.CL_Filtro = Nothing
        Me.BtTipo.cl_formu = Nothing
        Me.BtTipo.CL_hfecha = Nothing
        Me.BtTipo.cl_ListaW = Nothing
        Me.BtTipo.CL_xCentro = False
        Me.BtTipo.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtTipo.Location = New System.Drawing.Point(332, 298)
        Me.BtTipo.Name = "BtTipo"
        Me.BtTipo.Size = New System.Drawing.Size(33, 23)
        Me.BtTipo.TabIndex = 213
        Me.BtTipo.UseVisualStyleBackColor = True
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = True
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.Teal
        Me.LbTipo.Location = New System.Drawing.Point(216, 304)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(48, 16)
        Me.LbTipo.TabIndex = 211
        Me.LbTipo.Text = "T.Doc"
        '
        'LbNomBanco
        '
        Me.LbNomBanco.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomBanco.CL_ControlAsociado = Nothing
        Me.LbNomBanco.CL_ValorFijo = False
        Me.LbNomBanco.ClForm = Nothing
        Me.LbNomBanco.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomBanco.Location = New System.Drawing.Point(371, 269)
        Me.LbNomBanco.Name = "LbNomBanco"
        Me.LbNomBanco.Size = New System.Drawing.Size(234, 23)
        Me.LbNomBanco.TabIndex = 210
        Me.LbNomBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxBanco
        '
        Me.TxBanco.Autonumerico = False
        Me.TxBanco.Buscando = False
        Me.TxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBanco.ClForm = Nothing
        Me.TxBanco.ClParam = Nothing
        Me.TxBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBanco.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(275, 270)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(49, 22)
        Me.TxBanco.TabIndex = 208
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
        '
        'BtBanco
        '
        Me.BtBanco.CL_Ancho = 0
        Me.BtBanco.CL_BuscaAlb = False
        Me.BtBanco.CL_campocodigo = Nothing
        Me.BtBanco.CL_camponombre = Nothing
        Me.BtBanco.CL_CampoOrden = "Nombre"
        Me.BtBanco.CL_ch1000 = False
        Me.BtBanco.CL_ConsultaSql = "Select * from familias"
        Me.BtBanco.CL_ControlAsociado = Me.TxBanco
        Me.BtBanco.CL_DevuelveCampo = "Idfamilia"
        Me.BtBanco.CL_dfecha = Nothing
        Me.BtBanco.CL_Entidad = Nothing
        Me.BtBanco.CL_EsId = True
        Me.BtBanco.CL_Filtro = Nothing
        Me.BtBanco.cl_formu = Nothing
        Me.BtBanco.CL_hfecha = Nothing
        Me.BtBanco.cl_ListaW = Nothing
        Me.BtBanco.CL_xCentro = False
        Me.BtBanco.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBanco.Location = New System.Drawing.Point(332, 269)
        Me.BtBanco.Name = "BtBanco"
        Me.BtBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBanco.TabIndex = 209
        Me.BtBanco.UseVisualStyleBackColor = True
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = True
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(216, 275)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(53, 16)
        Me.LbBanco.TabIndex = 207
        Me.LbBanco.Text = "Banco"
        '
        'Lb6
        '
        Me.Lb6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(371, 234)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(434, 23)
        Me.Lb6.TabIndex = 206
        Me.Lb6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(181, 234)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(143, 22)
        Me.TxDato6.TabIndex = 204
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_Ancho = 0
        Me.BtBusca2.CL_BuscaAlb = False
        Me.BtBusca2.CL_campocodigo = Nothing
        Me.BtBusca2.CL_camponombre = Nothing
        Me.BtBusca2.CL_CampoOrden = "Nombre"
        Me.BtBusca2.CL_ch1000 = False
        Me.BtBusca2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca2.CL_ControlAsociado = Me.TxDato6
        Me.BtBusca2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca2.CL_dfecha = Nothing
        Me.BtBusca2.CL_Entidad = Nothing
        Me.BtBusca2.CL_EsId = True
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.CL_xCentro = False
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(332, 234)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 205
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(13, 234)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(125, 16)
        Me.Lb15.TabIndex = 203
        Me.Lb15.Text = "Nº cuenta gasto"
        '
        'TxProvincia
        '
        Me.TxProvincia.Autonumerico = False
        Me.TxProvincia.Buscando = False
        Me.TxProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxProvincia.ClForm = Nothing
        Me.TxProvincia.ClParam = Nothing
        Me.TxProvincia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxProvincia.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxProvincia.GridLin = Nothing
        Me.TxProvincia.HaCambiado = False
        Me.TxProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxProvincia.lbbusca = Nothing
        Me.TxProvincia.Location = New System.Drawing.Point(294, 108)
        Me.TxProvincia.MiError = False
        Me.TxProvincia.Name = "TxProvincia"
        Me.TxProvincia.Orden = 0
        Me.TxProvincia.SaltoAlfinal = False
        Me.TxProvincia.Siguiente = 0
        Me.TxProvincia.Size = New System.Drawing.Size(258, 22)
        Me.TxProvincia.TabIndex = 202
        Me.TxProvincia.TeclaRepetida = False
        Me.TxProvincia.TxDatoFinalSemana = Nothing
        Me.TxProvincia.TxDatoInicioSemana = Nothing
        Me.TxProvincia.UltimoValorValidado = Nothing
        '
        'LbProvincia
        '
        Me.LbProvincia.AutoSize = True
        Me.LbProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LbProvincia.CL_ControlAsociado = Nothing
        Me.LbProvincia.CL_ValorFijo = True
        Me.LbProvincia.ClForm = Nothing
        Me.LbProvincia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProvincia.ForeColor = System.Drawing.Color.Teal
        Me.LbProvincia.Location = New System.Drawing.Point(213, 111)
        Me.LbProvincia.Name = "LbProvincia"
        Me.LbProvincia.Size = New System.Drawing.Size(75, 16)
        Me.LbProvincia.TabIndex = 201
        Me.LbProvincia.Text = "Provincia"
        '
        'TxDato13
        '
        Me.TxDato13.Autonumerico = False
        Me.TxDato13.Buscando = False
        Me.TxDato13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato13.ClForm = Nothing
        Me.TxDato13.ClParam = Nothing
        Me.TxDato13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato13.GridLin = Nothing
        Me.TxDato13.HaCambiado = False
        Me.TxDato13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato13.lbbusca = Nothing
        Me.TxDato13.Location = New System.Drawing.Point(101, 269)
        Me.TxDato13.MiError = False
        Me.TxDato13.Name = "TxDato13"
        Me.TxDato13.Orden = 0
        Me.TxDato13.SaltoAlfinal = False
        Me.TxDato13.Siguiente = 0
        Me.TxDato13.Size = New System.Drawing.Size(61, 22)
        Me.TxDato13.TabIndex = 200
        Me.TxDato13.TeclaRepetida = False
        Me.TxDato13.TxDatoFinalSemana = Nothing
        Me.TxDato13.TxDatoInicioSemana = Nothing
        Me.TxDato13.UltimoValorValidado = Nothing
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(19, 303)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(53, 16)
        Me.Lb14.TabIndex = 199
        Me.Lb14.Text = "% Ret"
        '
        'TxDato14
        '
        Me.TxDato14.Autonumerico = False
        Me.TxDato14.Buscando = False
        Me.TxDato14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato14.ClForm = Nothing
        Me.TxDato14.ClParam = Nothing
        Me.TxDato14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato14.GridLin = Nothing
        Me.TxDato14.HaCambiado = False
        Me.TxDato14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato14.lbbusca = Nothing
        Me.TxDato14.Location = New System.Drawing.Point(101, 297)
        Me.TxDato14.MiError = False
        Me.TxDato14.Name = "TxDato14"
        Me.TxDato14.Orden = 0
        Me.TxDato14.SaltoAlfinal = False
        Me.TxDato14.Siguiente = 0
        Me.TxDato14.Size = New System.Drawing.Size(61, 22)
        Me.TxDato14.TabIndex = 198
        Me.TxDato14.TeclaRepetida = False
        Me.TxDato14.TxDatoFinalSemana = Nothing
        Me.TxDato14.TxDatoInicioSemana = Nothing
        Me.TxDato14.UltimoValorValidado = Nothing
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(17, 272)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(55, 16)
        Me.Lb13.TabIndex = 197
        Me.Lb13.Text = "% IVA"
        '
        'ChOrigen
        '
        Me.ChOrigen.Location = New System.Drawing.Point(809, 28)
        Me.ChOrigen.Name = "ChOrigen"
        Me.ChOrigen.Size = New System.Drawing.Size(199, 283)
        Me.ChOrigen.TabIndex = 196
        '
        'Lb_12
        '
        Me.Lb_12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_12.CL_ControlAsociado = Nothing
        Me.Lb_12.CL_ValorFijo = False
        Me.Lb_12.ClForm = Nothing
        Me.Lb_12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_12.Location = New System.Drawing.Point(371, 206)
        Me.Lb_12.Name = "Lb_12"
        Me.Lb_12.Size = New System.Drawing.Size(434, 23)
        Me.Lb_12.TabIndex = 195
        Me.Lb_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDato12
        '
        Me.TxDato12.Autonumerico = False
        Me.TxDato12.Buscando = False
        Me.TxDato12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato12.ClForm = Nothing
        Me.TxDato12.ClParam = Nothing
        Me.TxDato12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato12.GridLin = Nothing
        Me.TxDato12.HaCambiado = False
        Me.TxDato12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato12.lbbusca = Nothing
        Me.TxDato12.Location = New System.Drawing.Point(181, 206)
        Me.TxDato12.MiError = False
        Me.TxDato12.Name = "TxDato12"
        Me.TxDato12.Orden = 0
        Me.TxDato12.SaltoAlfinal = False
        Me.TxDato12.Siguiente = 0
        Me.TxDato12.Size = New System.Drawing.Size(143, 22)
        Me.TxDato12.TabIndex = 193
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
        Me.BtBusca12.CL_ControlAsociado = Me.TxDato12
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
        Me.BtBusca12.Location = New System.Drawing.Point(332, 206)
        Me.BtBusca12.Name = "BtBusca12"
        Me.BtBusca12.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca12.TabIndex = 194
        Me.BtBusca12.UseVisualStyleBackColor = True
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(13, 206)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(149, 16)
        Me.Lb12.TabIndex = 192
        Me.Lb12.Text = "Nº cuenta acreedor"
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(622, 139)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(143, 22)
        Me.TxDato10.TabIndex = 191
        Me.TxDato10.TeclaRepetida = False
        Me.TxDato10.TxDatoFinalSemana = Nothing
        Me.TxDato10.TxDatoInicioSemana = Nothing
        Me.TxDato10.UltimoValorValidado = Nothing
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(409, 139)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(143, 22)
        Me.TxDato9.TabIndex = 190
        Me.TxDato9.TeclaRepetida = False
        Me.TxDato9.TxDatoFinalSemana = Nothing
        Me.TxDato9.TxDatoInicioSemana = Nothing
        Me.TxDato9.UltimoValorValidado = Nothing
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(97, 139)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(143, 22)
        Me.TxDato8.TabIndex = 189
        Me.TxDato8.TeclaRepetida = False
        Me.TxDato8.TxDatoFinalSemana = Nothing
        Me.TxDato8.TxDatoInicioSemana = Nothing
        Me.TxDato8.UltimoValorValidado = Nothing
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(97, 172)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(600, 22)
        Me.TxDato11.TabIndex = 188
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.TxDatoFinalSemana = Nothing
        Me.TxDato11.TxDatoInicioSemana = Nothing
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(97, 108)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(78, 22)
        Me.TxDato5.TabIndex = 184
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(97, 77)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(403, 22)
        Me.TxDato4.TabIndex = 183
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(97, 47)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(600, 22)
        Me.TxDato3.TabIndex = 182
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(13, 175)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(48, 16)
        Me.Lb11.TabIndex = 181
        Me.Lb11.Text = "Email"
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(578, 142)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(35, 16)
        Me.Lb10.TabIndex = 180
        Me.Lb10.Text = "Fax"
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(284, 142)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(114, 16)
        Me.Lb9.TabIndex = 179
        Me.Lb9.Text = "Teléfono móvil"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(13, 142)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(70, 16)
        Me.Lb8.TabIndex = 178
        Me.Lb8.Text = "Teléfono"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(13, 80)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(78, 16)
        Me.Lb4.TabIndex = 177
        Me.Lb4.Text = "Población"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(13, 111)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(68, 16)
        Me.Lb5.TabIndex = 176
        Me.Lb5.Text = "C.Postal"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(13, 50)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(74, 16)
        Me.Lb3.TabIndex = 174
        Me.Lb3.Text = "Domicilio"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(13, 19)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 170
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
        Me.TxDato2.Location = New System.Drawing.Point(97, 16)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(508, 22)
        Me.TxDato2.TabIndex = 169
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
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
        Me.Lb7.Location = New System.Drawing.Point(356, 13)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(33, 16)
        Me.Lb7.TabIndex = 173
        Me.Lb7.Text = "NIF"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(395, 10)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(136, 22)
        Me.TxDato7.TabIndex = 172
        Me.TxDato7.TeclaRepetida = False
        Me.TxDato7.TxDatoFinalSemana = Nothing
        Me.TxDato7.TxDatoInicioSemana = Nothing
        Me.TxDato7.UltimoValorValidado = Nothing
        '
        'BtBusca7
        '
        Me.BtBusca7.CL_Ancho = 0
        Me.BtBusca7.CL_BuscaAlb = False
        Me.BtBusca7.CL_campocodigo = Nothing
        Me.BtBusca7.CL_camponombre = Nothing
        Me.BtBusca7.CL_CampoOrden = "Nombre"
        Me.BtBusca7.CL_ch1000 = False
        Me.BtBusca7.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca7.CL_ControlAsociado = Me.TxDato1
        Me.BtBusca7.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca7.CL_dfecha = Nothing
        Me.BtBusca7.CL_Entidad = Nothing
        Me.BtBusca7.CL_EsId = True
        Me.BtBusca7.CL_Filtro = Nothing
        Me.BtBusca7.cl_formu = Nothing
        Me.BtBusca7.CL_hfecha = Nothing
        Me.BtBusca7.cl_ListaW = Nothing
        Me.BtBusca7.CL_xCentro = False
        Me.BtBusca7.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca7.Location = New System.Drawing.Point(537, 10)
        Me.BtBusca7.Name = "BtBusca7"
        Me.BtBusca7.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca7.TabIndex = 171
        Me.BtBusca7.UseVisualStyleBackColor = True
        '
        'TxCodigoFianza
        '
        Me.TxCodigoFianza.Autonumerico = False
        Me.TxCodigoFianza.Buscando = False
        Me.TxCodigoFianza.ClForm = Nothing
        Me.TxCodigoFianza.ClParam = Nothing
        Me.TxCodigoFianza.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCodigoFianza.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigoFianza.GridLin = Nothing
        Me.TxCodigoFianza.HaCambiado = False
        Me.TxCodigoFianza.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCodigoFianza.lbbusca = Nothing
        Me.TxCodigoFianza.Location = New System.Drawing.Point(190, 332)
        Me.TxCodigoFianza.MiError = False
        Me.TxCodigoFianza.Name = "TxCodigoFianza"
        Me.TxCodigoFianza.Orden = 0
        Me.TxCodigoFianza.SaltoAlfinal = False
        Me.TxCodigoFianza.Siguiente = 0
        Me.TxCodigoFianza.Size = New System.Drawing.Size(262, 22)
        Me.TxCodigoFianza.TabIndex = 230
        Me.TxCodigoFianza.TeclaRepetida = False
        Me.TxCodigoFianza.TxDatoFinalSemana = Nothing
        Me.TxCodigoFianza.TxDatoInicioSemana = Nothing
        Me.TxCodigoFianza.UltimoValorValidado = Nothing
        '
        'LbCodigoFianza
        '
        Me.LbCodigoFianza.AutoSize = True
        Me.LbCodigoFianza.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LbCodigoFianza.CL_ControlAsociado = Nothing
        Me.LbCodigoFianza.CL_ValorFijo = True
        Me.LbCodigoFianza.ClForm = Nothing
        Me.LbCodigoFianza.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigoFianza.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigoFianza.Location = New System.Drawing.Point(17, 334)
        Me.LbCodigoFianza.Name = "LbCodigoFianza"
        Me.LbCodigoFianza.Size = New System.Drawing.Size(171, 16)
        Me.LbCodigoFianza.TabIndex = 229
        Me.LbCodigoFianza.Text = "Codigo fianza envases"
        '
        'FrmAcreedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 445)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.BtBusca7)
        Me.Controls.Add(Me.TxDato7)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAcreedores"
        Me.Text = "Acreedores servicios"
        Me.Controls.SetChildIndex(Me.TxDato7, 0)
        Me.Controls.SetChildIndex(Me.BtBusca7, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ChOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents BtBusca7 As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb_12 As NetAgro.Lb
    Friend WithEvents TxDato12 As NetAgro.TxDato
    Friend WithEvents BtBusca12 As NetAgro.BtBusca
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents ChOrigen As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents TxDato13 As NetAgro.TxDato
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents TxDato14 As NetAgro.TxDato
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents TxProvincia As NetAgro.TxDato
    Friend WithEvents LbProvincia As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents TxDias As NetAgro.TxDato
    Friend WithEvents LbDias As NetAgro.Lb
    Friend WithEvents LbNomTipo As NetAgro.Lb
    Friend WithEvents TxTipo As NetAgro.TxDato
    Friend WithEvents BtTipo As NetAgro.BtBusca
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents LbNomBanco As NetAgro.Lb
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents BtBanco As NetAgro.BtBusca
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents TxCodigoFianza As NetAgro.TxDato
    Friend WithEvents LbCodigoFianza As NetAgro.Lb
End Class
