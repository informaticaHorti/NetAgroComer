<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrazabilidadPalet
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LbFechaAlbaran = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbAlbaran = New NetAgro.Lb(Me.components)
        Me.TxAlbaran = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LbPalet = New NetAgro.Lb(Me.components)
        Me.LbNomTipoPalet = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbNumAlb = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxPalet = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.BtBuscaPalet = New NetAgro.BtBusca(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbNomPv = New NetAgro.Lb(Me.components)
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.LbCliAlb = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1101, 131)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 131)
        Me.PanelConsulta.Size = New System.Drawing.Size(1101, 420)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(801, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(876, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(951, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1026, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(726, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LbCliAlb)
        Me.GroupBox1.Controls.Add(Me.Lb23)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1101, 134)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LbFechaAlbaran)
        Me.GroupBox5.Controls.Add(Me.Lb3)
        Me.GroupBox5.Controls.Add(Me.LbAlbaran)
        Me.GroupBox5.Controls.Add(Me.TxAlbaran)
        Me.GroupBox5.Controls.Add(Me.BtBuscaAlbaran)
        Me.GroupBox5.Location = New System.Drawing.Point(676, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 82)
        Me.GroupBox5.TabIndex = 100377
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Albaran"
        '
        'LbFechaAlbaran
        '
        Me.LbFechaAlbaran.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFechaAlbaran.CL_ControlAsociado = Nothing
        Me.LbFechaAlbaran.CL_ValorFijo = False
        Me.LbFechaAlbaran.ClForm = Nothing
        Me.LbFechaAlbaran.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaAlbaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFechaAlbaran.Location = New System.Drawing.Point(76, 50)
        Me.LbFechaAlbaran.Name = "LbFechaAlbaran"
        Me.LbFechaAlbaran.Size = New System.Drawing.Size(147, 21)
        Me.LbFechaAlbaran.TabIndex = 100376
        Me.LbFechaAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(6, 52)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(52, 16)
        Me.Lb3.TabIndex = 100375
        Me.Lb3.Text = "Fecha"
        '
        'LbAlbaran
        '
        Me.LbAlbaran.AutoSize = True
        Me.LbAlbaran.CL_ControlAsociado = Nothing
        Me.LbAlbaran.CL_ValorFijo = False
        Me.LbAlbaran.ClForm = Nothing
        Me.LbAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbAlbaran.Location = New System.Drawing.Point(6, 23)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(64, 16)
        Me.LbAlbaran.TabIndex = 100372
        Me.LbAlbaran.Text = "Albaran"
        '
        'TxAlbaran
        '
        Me.TxAlbaran.Autonumerico = False
        Me.TxAlbaran.Buscando = False
        Me.TxAlbaran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlbaran.ClForm = Nothing
        Me.TxAlbaran.ClParam = Nothing
        Me.TxAlbaran.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAlbaran.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlbaran.GridLin = Nothing
        Me.TxAlbaran.HaCambiado = False
        Me.TxAlbaran.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAlbaran.lbbusca = Nothing
        Me.TxAlbaran.Location = New System.Drawing.Point(76, 20)
        Me.TxAlbaran.MiError = False
        Me.TxAlbaran.Name = "TxAlbaran"
        Me.TxAlbaran.Orden = 0
        Me.TxAlbaran.SaltoAlfinal = False
        Me.TxAlbaran.Siguiente = 0
        Me.TxAlbaran.Size = New System.Drawing.Size(91, 22)
        Me.TxAlbaran.TabIndex = 100373
        Me.TxAlbaran.TeclaRepetida = False
        Me.TxAlbaran.TxDatoFinalSemana = Nothing
        Me.TxAlbaran.TxDatoInicioSemana = Nothing
        Me.TxAlbaran.UltimoValorValidado = Nothing
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_Ancho = 0
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxAlbaran
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(173, 20)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 100374
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LbPalet)
        Me.GroupBox4.Controls.Add(Me.LbNomTipoPalet)
        Me.GroupBox4.Controls.Add(Me.Lb13)
        Me.GroupBox4.Controls.Add(Me.Lb7)
        Me.GroupBox4.Controls.Add(Me.LbNumAlb)
        Me.GroupBox4.Controls.Add(Me.LbFecha)
        Me.GroupBox4.Controls.Add(Me.TxPalet)
        Me.GroupBox4.Controls.Add(Me.Lb4)
        Me.GroupBox4.Controls.Add(Me.BtBuscaPalet)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(665, 82)
        Me.GroupBox4.TabIndex = 100376
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Palet"
        '
        'LbPalet
        '
        Me.LbPalet.AutoSize = True
        Me.LbPalet.CL_ControlAsociado = Nothing
        Me.LbPalet.CL_ValorFijo = False
        Me.LbPalet.ClForm = Nothing
        Me.LbPalet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet.Location = New System.Drawing.Point(16, 23)
        Me.LbPalet.Name = "LbPalet"
        Me.LbPalet.Size = New System.Drawing.Size(45, 16)
        Me.LbPalet.TabIndex = 100369
        Me.LbPalet.Text = "Palet"
        '
        'LbNomTipoPalet
        '
        Me.LbNomTipoPalet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomTipoPalet.CL_ControlAsociado = Nothing
        Me.LbNomTipoPalet.CL_ValorFijo = False
        Me.LbNomTipoPalet.ClForm = Nothing
        Me.LbNomTipoPalet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTipoPalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomTipoPalet.Location = New System.Drawing.Point(81, 50)
        Me.LbNomTipoPalet.Name = "LbNomTipoPalet"
        Me.LbNomTipoPalet.Size = New System.Drawing.Size(249, 21)
        Me.LbNomTipoPalet.TabIndex = 100375
        Me.LbNomTipoPalet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(455, 23)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(86, 16)
        Me.Lb13.TabIndex = 124
        Me.Lb13.Text = "Nº Albarán"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(16, 52)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(62, 16)
        Me.Lb7.TabIndex = 100374
        Me.Lb7.Text = "T. Palet"
        '
        'LbNumAlb
        '
        Me.LbNumAlb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNumAlb.CL_ControlAsociado = Nothing
        Me.LbNumAlb.CL_ValorFijo = False
        Me.LbNumAlb.ClForm = Nothing
        Me.LbNumAlb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumAlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNumAlb.Location = New System.Drawing.Point(547, 20)
        Me.LbNumAlb.Name = "LbNumAlb"
        Me.LbNumAlb.Size = New System.Drawing.Size(107, 22)
        Me.LbNumAlb.TabIndex = 147
        Me.LbNumAlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(291, 21)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(147, 21)
        Me.LbFecha.TabIndex = 100373
        Me.LbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxPalet
        '
        Me.TxPalet.Autonumerico = False
        Me.TxPalet.Buscando = False
        Me.TxPalet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet.ClForm = Nothing
        Me.TxPalet.ClParam = Nothing
        Me.TxPalet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPalet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet.GridLin = Nothing
        Me.TxPalet.HaCambiado = False
        Me.TxPalet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPalet.lbbusca = Nothing
        Me.TxPalet.Location = New System.Drawing.Point(81, 20)
        Me.TxPalet.MiError = False
        Me.TxPalet.Name = "TxPalet"
        Me.TxPalet.Orden = 0
        Me.TxPalet.SaltoAlfinal = False
        Me.TxPalet.Siguiente = 0
        Me.TxPalet.Size = New System.Drawing.Size(91, 22)
        Me.TxPalet.TabIndex = 100370
        Me.TxPalet.TeclaRepetida = False
        Me.TxPalet.TxDatoFinalSemana = Nothing
        Me.TxPalet.TxDatoInicioSemana = Nothing
        Me.TxPalet.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(233, 23)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(52, 16)
        Me.Lb4.TabIndex = 100372
        Me.Lb4.Text = "Fecha"
        '
        'BtBuscaPalet
        '
        Me.BtBuscaPalet.CL_Ancho = 0
        Me.BtBuscaPalet.CL_BuscaAlb = False
        Me.BtBuscaPalet.CL_campocodigo = Nothing
        Me.BtBuscaPalet.CL_camponombre = Nothing
        Me.BtBuscaPalet.CL_CampoOrden = "Nombre"
        Me.BtBuscaPalet.CL_ch1000 = False
        Me.BtBuscaPalet.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaPalet.CL_ControlAsociado = Me.TxPalet
        Me.BtBuscaPalet.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaPalet.CL_dfecha = Nothing
        Me.BtBuscaPalet.CL_Entidad = Nothing
        Me.BtBuscaPalet.CL_EsId = True
        Me.BtBuscaPalet.CL_Filtro = Nothing
        Me.BtBuscaPalet.cl_formu = Nothing
        Me.BtBuscaPalet.CL_hfecha = Nothing
        Me.BtBuscaPalet.cl_ListaW = Nothing
        Me.BtBuscaPalet.CL_xCentro = False
        Me.BtBuscaPalet.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaPalet.Location = New System.Drawing.Point(178, 20)
        Me.BtBuscaPalet.Name = "BtBuscaPalet"
        Me.BtBuscaPalet.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaPalet.TabIndex = 100371
        Me.BtBuscaPalet.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbejer)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1008, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 43)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ejercicio"
        '
        'Lbejer
        '
        Me.Lbejer.BackColor = System.Drawing.Color.White
        Me.Lbejer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbejer.CL_ControlAsociado = Nothing
        Me.Lbejer.CL_ValorFijo = False
        Me.Lbejer.ClForm = Nothing
        Me.Lbejer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbejer.ForeColor = System.Drawing.Color.Teal
        Me.Lbejer.Location = New System.Drawing.Point(11, 14)
        Me.Lbejer.Name = "Lbejer"
        Me.Lbejer.Size = New System.Drawing.Size(36, 21)
        Me.Lbejer.TabIndex = 114
        Me.Lbejer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbNomPv)
        Me.GroupBox3.Controls.Add(Me.LbPuntoVenta)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(919, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 43)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Punto de Venta"
        '
        'LbNomPv
        '
        Me.LbNomPv.BackColor = System.Drawing.Color.White
        Me.LbNomPv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNomPv.CL_ControlAsociado = Nothing
        Me.LbNomPv.CL_ValorFijo = False
        Me.LbNomPv.ClForm = Nothing
        Me.LbNomPv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomPv.ForeColor = System.Drawing.Color.Teal
        Me.LbNomPv.Location = New System.Drawing.Point(40, 14)
        Me.LbNomPv.Name = "LbNomPv"
        Me.LbNomPv.Size = New System.Drawing.Size(117, 21)
        Me.LbNomPv.TabIndex = 114
        Me.LbNomPv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.BackColor = System.Drawing.Color.White
        Me.LbPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbPuntoVenta.CL_ControlAsociado = Nothing
        Me.LbPuntoVenta.CL_ValorFijo = False
        Me.LbPuntoVenta.ClForm = Nothing
        Me.LbPuntoVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPuntoVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPuntoVenta.Location = New System.Drawing.Point(6, 14)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(28, 21)
        Me.LbPuntoVenta.TabIndex = 113
        Me.LbPuntoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCliAlb
        '
        Me.LbCliAlb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCliAlb.CL_ControlAsociado = Nothing
        Me.LbCliAlb.CL_ValorFijo = False
        Me.LbCliAlb.ClForm = Nothing
        Me.LbCliAlb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliAlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliAlb.Location = New System.Drawing.Point(90, 101)
        Me.LbCliAlb.Name = "LbCliAlb"
        Me.LbCliAlb.Size = New System.Drawing.Size(812, 22)
        Me.LbCliAlb.TabIndex = 152
        Me.LbCliAlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(25, 104)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(59, 16)
        Me.Lb23.TabIndex = 151
        Me.Lb23.Text = "Cliente"
        '
        'FrmTrazabilidadPalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 585)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmTrazabilidadPalet"
        Me.Text = "Trazabilidad palet"
        Me.PanelCabecera.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomTipoPalet As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents BtBuscaPalet As NetAgro.BtBusca
    Friend WithEvents TxPalet As NetAgro.TxDato
    Friend WithEvents LbPalet As NetAgro.Lb
    Friend WithEvents LbCliAlb As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents LbNumAlb As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomPv As NetAgro.Lb
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAlbaran As NetAgro.Lb
    Friend WithEvents TxAlbaran As NetAgro.TxDato
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents LbFechaAlbaran As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
End Class
