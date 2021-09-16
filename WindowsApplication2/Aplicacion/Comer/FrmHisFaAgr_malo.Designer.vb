<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHisfaAgr_malo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHisfaAgr_malo))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxPrecio = New NetAgro.TxDato(Me.components)
        Me.TxKilos = New NetAgro.TxDato(Me.components)
        Me.LbPrecio = New NetAgro.Lb(Me.components)
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.LbNomCate = New NetAgro.Lb(Me.components)
        Me.BtCategoria = New NetAgro.BtBusca(Me.components)
        Me.TxCategoria = New NetAgro.TxDato(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb14 = New NetAgro.Lb(Me.components)
        Me.LbNumAlb = New NetAgro.Lb(Me.components)
        Me.TxPartida = New NetAgro.TxDato(Me.components)
        Me.LbPartida = New NetAgro.Lb(Me.components)
        Me.LbnomGenero = New NetAgro.Lb(Me.components)
        Me.BtGenero = New NetAgro.BtBusca(Me.components)
        Me.TxGenero = New NetAgro.TxDato(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtSemana = New NetAgro.BtBusca(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.Lbsemana = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbAsiento = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbNuCTB = New NetAgro.Lb(Me.components)
        Me.Lbejer = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxSerie = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr2 = New NetAgro.Lb(Me.components)
        Me.BtAgriAlb = New NetAgro.BtBusca(Me.components)
        Me.TxAgricultorAlb = New NetAgro.TxDato(Me.components)
        Me.LbAgricultor2 = New NetAgro.Lb(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.LbFactura = New NetAgro.Lb(Me.components)
        Me.TxFactura = New NetAgro.TxDato(Me.components)
        Me.BtAgri = New NetAgro.BtBusca(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.LbImpTotal = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbImpGenero = New NetAgro.Lb(Me.components)
        Me.LbImpComi = New NetAgro.Lb(Me.components)
        Me.Lbporcom = New NetAgro.Lb(Me.components)
        Me.LbImpBase = New NetAgro.Lb(Me.components)
        Me.TxPorCom = New NetAgro.TxDato(Me.components)
        Me.TxIva = New NetAgro.TxDato(Me.components)
        Me.TxTipoRet = New NetAgro.TxDato(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.Lbimpret = New NetAgro.Lb(Me.components)
        Me.TxGastos = New NetAgro.TxDato(Me.components)
        Me.Lbgastos = New NetAgro.Lb(Me.components)
        Me.Lb27 = New NetAgro.Lb(Me.components)
        Me.Lbporret = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lbiva = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbimpCuota = New NetAgro.Lb(Me.components)
        Me.TxPorRet = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxporFondo = New NetAgro.TxDato(Me.components)
        Me.lbporfondo = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbImpFondo = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1039, 317)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxPrecio)
        Me.GroupBox5.Controls.Add(Me.TxKilos)
        Me.GroupBox5.Controls.Add(Me.LbPrecio)
        Me.GroupBox5.Controls.Add(Me.LbKilos)
        Me.GroupBox5.Controls.Add(Me.LbNomCate)
        Me.GroupBox5.Controls.Add(Me.BtCategoria)
        Me.GroupBox5.Controls.Add(Me.TxCategoria)
        Me.GroupBox5.Controls.Add(Me.LbCategoria)
        Me.GroupBox5.Controls.Add(Me.Lb14)
        Me.GroupBox5.Controls.Add(Me.LbNumAlb)
        Me.GroupBox5.Controls.Add(Me.TxPartida)
        Me.GroupBox5.Controls.Add(Me.LbPartida)
        Me.GroupBox5.Controls.Add(Me.LbnomGenero)
        Me.GroupBox5.Controls.Add(Me.BtGenero)
        Me.GroupBox5.Controls.Add(Me.TxGenero)
        Me.GroupBox5.Controls.Add(Me.LbGenero)
        Me.GroupBox5.Controls.Add(Me.ClGrid1)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1057, 307)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
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
        Me.TxPrecio.Location = New System.Drawing.Point(914, 49)
        Me.TxPrecio.MiError = False
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Orden = 0
        Me.TxPrecio.SaltoAlfinal = False
        Me.TxPrecio.Siguiente = 0
        Me.TxPrecio.Size = New System.Drawing.Size(92, 22)
        Me.TxPrecio.TabIndex = 184
        Me.TxPrecio.TeclaRepetida = False
        Me.TxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPrecio.TxDatoFinalSemana = Nothing
        Me.TxPrecio.TxDatoInicioSemana = Nothing
        Me.TxPrecio.UltimoValorValidado = Nothing
        '
        'TxKilos
        '
        Me.TxKilos.Autonumerico = False
        Me.TxKilos.Buscando = False
        Me.TxKilos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilos.ClForm = Nothing
        Me.TxKilos.ClParam = Nothing
        Me.TxKilos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilos.GridLin = Nothing
        Me.TxKilos.HaCambiado = False
        Me.TxKilos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilos.lbbusca = Nothing
        Me.TxKilos.Location = New System.Drawing.Point(679, 49)
        Me.TxKilos.MiError = False
        Me.TxKilos.Name = "TxKilos"
        Me.TxKilos.Orden = 0
        Me.TxKilos.SaltoAlfinal = False
        Me.TxKilos.Siguiente = 0
        Me.TxKilos.Size = New System.Drawing.Size(92, 22)
        Me.TxKilos.TabIndex = 183
        Me.TxKilos.TeclaRepetida = False
        Me.TxKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKilos.TxDatoFinalSemana = Nothing
        Me.TxKilos.TxDatoInicioSemana = Nothing
        Me.TxKilos.UltimoValorValidado = Nothing
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.CL_ControlAsociado = Nothing
        Me.LbPrecio.CL_ValorFijo = True
        Me.LbPrecio.ClForm = Nothing
        Me.LbPrecio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecio.ForeColor = System.Drawing.Color.Teal
        Me.LbPrecio.Location = New System.Drawing.Point(823, 52)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(53, 16)
        Me.LbPrecio.TabIndex = 169
        Me.LbPrecio.Text = "Precio"
        '
        'LbKilos
        '
        Me.LbKilos.AutoSize = True
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = True
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(631, 52)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(42, 16)
        Me.LbKilos.TabIndex = 182
        Me.LbKilos.Text = "Kilos"
        '
        'LbNomCate
        '
        Me.LbNomCate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCate.CL_ControlAsociado = Nothing
        Me.LbNomCate.CL_ValorFijo = False
        Me.LbNomCate.ClForm = Nothing
        Me.LbNomCate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCate.Location = New System.Drawing.Point(371, 49)
        Me.LbNomCate.Name = "LbNomCate"
        Me.LbNomCate.Size = New System.Drawing.Size(233, 23)
        Me.LbNomCate.TabIndex = 181
        '
        'BtCategoria
        '
        Me.BtCategoria.CL_Ancho = 0
        Me.BtCategoria.CL_BuscaAlb = False
        Me.BtCategoria.CL_campocodigo = Nothing
        Me.BtCategoria.CL_camponombre = Nothing
        Me.BtCategoria.CL_CampoOrden = "Nombre"
        Me.BtCategoria.CL_ch1000 = False
        Me.BtCategoria.CL_ConsultaSql = "Select * from familias"
        Me.BtCategoria.CL_ControlAsociado = Nothing
        Me.BtCategoria.CL_DevuelveCampo = "Idfamilia"
        Me.BtCategoria.CL_dfecha = Nothing
        Me.BtCategoria.CL_Entidad = Nothing
        Me.BtCategoria.CL_EsId = True
        Me.BtCategoria.CL_Filtro = Nothing
        Me.BtCategoria.cl_formu = Nothing
        Me.BtCategoria.CL_hfecha = Nothing
        Me.BtCategoria.cl_ListaW = Nothing
        Me.BtCategoria.CL_xCentro = False
        Me.BtCategoria.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtCategoria.Location = New System.Drawing.Point(330, 49)
        Me.BtCategoria.Name = "BtCategoria"
        Me.BtCategoria.Size = New System.Drawing.Size(33, 23)
        Me.BtCategoria.TabIndex = 180
        Me.BtCategoria.UseVisualStyleBackColor = True
        '
        'TxCategoria
        '
        Me.TxCategoria.Autonumerico = False
        Me.TxCategoria.Buscando = False
        Me.TxCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategoria.ClForm = Nothing
        Me.TxCategoria.ClParam = Nothing
        Me.TxCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCategoria.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategoria.GridLin = Nothing
        Me.TxCategoria.HaCambiado = False
        Me.TxCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCategoria.lbbusca = Nothing
        Me.TxCategoria.Location = New System.Drawing.Point(266, 49)
        Me.TxCategoria.MiError = False
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.Orden = 0
        Me.TxCategoria.SaltoAlfinal = False
        Me.TxCategoria.Siguiente = 0
        Me.TxCategoria.Size = New System.Drawing.Size(59, 22)
        Me.TxCategoria.TabIndex = 179
        Me.TxCategoria.TeclaRepetida = False
        Me.TxCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxCategoria.TxDatoFinalSemana = Nothing
        Me.TxCategoria.TxDatoInicioSemana = Nothing
        Me.TxCategoria.UltimoValorValidado = Nothing
        '
        'LbCategoria
        '
        Me.LbCategoria.AutoSize = True
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = True
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Teal
        Me.LbCategoria.Location = New System.Drawing.Point(182, 52)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(79, 16)
        Me.LbCategoria.TabIndex = 178
        Me.LbCategoria.Text = "Categoria"
        '
        'Lb14
        '
        Me.Lb14.AutoSize = True
        Me.Lb14.CL_ControlAsociado = Nothing
        Me.Lb14.CL_ValorFijo = True
        Me.Lb14.ClForm = Nothing
        Me.Lb14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb14.ForeColor = System.Drawing.Color.Teal
        Me.Lb14.Location = New System.Drawing.Point(7, 52)
        Me.Lb14.Name = "Lb14"
        Me.Lb14.Size = New System.Drawing.Size(64, 16)
        Me.Lb14.TabIndex = 175
        Me.Lb14.Text = "Albarán"
        '
        'LbNumAlb
        '
        Me.LbNumAlb.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNumAlb.CL_ControlAsociado = Nothing
        Me.LbNumAlb.CL_ValorFijo = True
        Me.LbNumAlb.ClForm = Nothing
        Me.LbNumAlb.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumAlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNumAlb.Location = New System.Drawing.Point(77, 49)
        Me.LbNumAlb.Name = "LbNumAlb"
        Me.LbNumAlb.Size = New System.Drawing.Size(93, 23)
        Me.LbNumAlb.TabIndex = 174
        '
        'TxPartida
        '
        Me.TxPartida.Autonumerico = False
        Me.TxPartida.Buscando = False
        Me.TxPartida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPartida.ClForm = Nothing
        Me.TxPartida.ClParam = Nothing
        Me.TxPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPartida.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPartida.GridLin = Nothing
        Me.TxPartida.HaCambiado = False
        Me.TxPartida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPartida.lbbusca = Nothing
        Me.TxPartida.Location = New System.Drawing.Point(74, 16)
        Me.TxPartida.MiError = False
        Me.TxPartida.Name = "TxPartida"
        Me.TxPartida.Orden = 0
        Me.TxPartida.SaltoAlfinal = False
        Me.TxPartida.Siguiente = 0
        Me.TxPartida.Size = New System.Drawing.Size(96, 22)
        Me.TxPartida.TabIndex = 173
        Me.TxPartida.TeclaRepetida = False
        Me.TxPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPartida.TxDatoFinalSemana = Nothing
        Me.TxPartida.TxDatoInicioSemana = Nothing
        Me.TxPartida.UltimoValorValidado = Nothing
        '
        'LbPartida
        '
        Me.LbPartida.AutoSize = True
        Me.LbPartida.CL_ControlAsociado = Nothing
        Me.LbPartida.CL_ValorFijo = True
        Me.LbPartida.ClForm = Nothing
        Me.LbPartida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPartida.ForeColor = System.Drawing.Color.Teal
        Me.LbPartida.Location = New System.Drawing.Point(9, 19)
        Me.LbPartida.Name = "LbPartida"
        Me.LbPartida.Size = New System.Drawing.Size(60, 16)
        Me.LbPartida.TabIndex = 172
        Me.LbPartida.Text = "Partida"
        '
        'LbnomGenero
        '
        Me.LbnomGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbnomGenero.CL_ControlAsociado = Nothing
        Me.LbnomGenero.CL_ValorFijo = False
        Me.LbnomGenero.ClForm = Nothing
        Me.LbnomGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomGenero.Location = New System.Drawing.Point(369, 16)
        Me.LbnomGenero.Name = "LbnomGenero"
        Me.LbnomGenero.Size = New System.Drawing.Size(324, 23)
        Me.LbnomGenero.TabIndex = 171
        '
        'BtGenero
        '
        Me.BtGenero.CL_Ancho = 0
        Me.BtGenero.CL_BuscaAlb = False
        Me.BtGenero.CL_campocodigo = Nothing
        Me.BtGenero.CL_camponombre = Nothing
        Me.BtGenero.CL_CampoOrden = "Nombre"
        Me.BtGenero.CL_ch1000 = False
        Me.BtGenero.CL_ConsultaSql = "Select * from familias"
        Me.BtGenero.CL_ControlAsociado = Nothing
        Me.BtGenero.CL_DevuelveCampo = "Idfamilia"
        Me.BtGenero.CL_dfecha = Nothing
        Me.BtGenero.CL_Entidad = Nothing
        Me.BtGenero.CL_EsId = True
        Me.BtGenero.CL_Filtro = Nothing
        Me.BtGenero.cl_formu = Nothing
        Me.BtGenero.CL_hfecha = Nothing
        Me.BtGenero.cl_ListaW = Nothing
        Me.BtGenero.CL_xCentro = False
        Me.BtGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtGenero.Location = New System.Drawing.Point(330, 16)
        Me.BtGenero.Name = "BtGenero"
        Me.BtGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtGenero.TabIndex = 170
        Me.BtGenero.UseVisualStyleBackColor = True
        '
        'TxGenero
        '
        Me.TxGenero.Autonumerico = False
        Me.TxGenero.Buscando = False
        Me.TxGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGenero.ClForm = Nothing
        Me.TxGenero.ClParam = Nothing
        Me.TxGenero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGenero.GridLin = Nothing
        Me.TxGenero.HaCambiado = False
        Me.TxGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxGenero.lbbusca = Nothing
        Me.TxGenero.Location = New System.Drawing.Point(266, 16)
        Me.TxGenero.MiError = False
        Me.TxGenero.Name = "TxGenero"
        Me.TxGenero.Orden = 0
        Me.TxGenero.SaltoAlfinal = False
        Me.TxGenero.Siguiente = 0
        Me.TxGenero.Size = New System.Drawing.Size(59, 22)
        Me.TxGenero.TabIndex = 159
        Me.TxGenero.TeclaRepetida = False
        Me.TxGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxGenero.TxDatoFinalSemana = Nothing
        Me.TxGenero.TxDatoInicioSemana = Nothing
        Me.TxGenero.UltimoValorValidado = Nothing
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(182, 19)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(60, 16)
        Me.LbGenero.TabIndex = 156
        Me.LbGenero.Text = "Género"
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
        Me.ClGrid1.Location = New System.Drawing.Point(3, 80)
        Me.ClGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1003, 225)
        Me.ClGrid1.TabIndex = 120
        Me.ClGrid1.UltimoControl = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1039, 127)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtSemana)
        Me.GroupBox1.Controls.Add(Me.TxSemana)
        Me.GroupBox1.Controls.Add(Me.Lbsemana)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAlbaran)
        Me.GroupBox1.Controls.Add(Me.TxSerie)
        Me.GroupBox1.Controls.Add(Me.LbnomAgr2)
        Me.GroupBox1.Controls.Add(Me.BtAgriAlb)
        Me.GroupBox1.Controls.Add(Me.TxAgricultorAlb)
        Me.GroupBox1.Controls.Add(Me.LbAgricultor2)
        Me.GroupBox1.Controls.Add(Me.LbnomAgr1)
        Me.GroupBox1.Controls.Add(Me.LbFactura)
        Me.GroupBox1.Controls.Add(Me.TxFactura)
        Me.GroupBox1.Controls.Add(Me.BtAgri)
        Me.GroupBox1.Controls.Add(Me.TxAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.TxFecha)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1050, 113)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Factura"
        '
        'BtSemana
        '
        Me.BtSemana.CL_Ancho = 0
        Me.BtSemana.CL_BuscaAlb = False
        Me.BtSemana.CL_campocodigo = Nothing
        Me.BtSemana.CL_camponombre = Nothing
        Me.BtSemana.CL_CampoOrden = "Nombre"
        Me.BtSemana.CL_ch1000 = False
        Me.BtSemana.CL_ConsultaSql = "Select * from familias"
        Me.BtSemana.CL_ControlAsociado = Nothing
        Me.BtSemana.CL_DevuelveCampo = "Idfamilia"
        Me.BtSemana.CL_dfecha = Nothing
        Me.BtSemana.CL_Entidad = Nothing
        Me.BtSemana.CL_EsId = True
        Me.BtSemana.CL_Filtro = Nothing
        Me.BtSemana.cl_formu = Nothing
        Me.BtSemana.CL_hfecha = Nothing
        Me.BtSemana.cl_ListaW = Nothing
        Me.BtSemana.CL_xCentro = False
        Me.BtSemana.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtSemana.Location = New System.Drawing.Point(712, 85)
        Me.BtSemana.Name = "BtSemana"
        Me.BtSemana.Size = New System.Drawing.Size(33, 23)
        Me.BtSemana.TabIndex = 100312
        Me.BtSemana.UseVisualStyleBackColor = True
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
        Me.TxSemana.Location = New System.Drawing.Point(653, 85)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(53, 22)
        Me.TxSemana.TabIndex = 100311
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'Lbsemana
        '
        Me.Lbsemana.AutoSize = True
        Me.Lbsemana.CL_ControlAsociado = Nothing
        Me.Lbsemana.CL_ValorFijo = False
        Me.Lbsemana.ClForm = Nothing
        Me.Lbsemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbsemana.ForeColor = System.Drawing.Color.Teal
        Me.Lbsemana.Location = New System.Drawing.Point(562, 88)
        Me.Lbsemana.Name = "Lbsemana"
        Me.Lbsemana.Size = New System.Drawing.Size(67, 16)
        Me.Lbsemana.TabIndex = 100310
        Me.Lbsemana.Text = "Semana"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbAsiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(907, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 43)
        Me.GroupBox2.TabIndex = 100309
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asiento"
        '
        'LbAsiento
        '
        Me.LbAsiento.BackColor = System.Drawing.Color.White
        Me.LbAsiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAsiento.CL_ControlAsociado = Nothing
        Me.LbAsiento.CL_ValorFijo = False
        Me.LbAsiento.ClForm = Nothing
        Me.LbAsiento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsiento.ForeColor = System.Drawing.Color.Teal
        Me.LbAsiento.Location = New System.Drawing.Point(11, 14)
        Me.LbAsiento.Name = "LbAsiento"
        Me.LbAsiento.Size = New System.Drawing.Size(83, 21)
        Me.LbAsiento.TabIndex = 114
        Me.LbAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbNuCTB)
        Me.GroupBox3.Controls.Add(Me.Lbejer)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(821, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(80, 43)
        Me.GroupBox3.TabIndex = 100307
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ejercicio"
        '
        'LbNuCTB
        '
        Me.LbNuCTB.BackColor = System.Drawing.Color.White
        Me.LbNuCTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNuCTB.CL_ControlAsociado = Nothing
        Me.LbNuCTB.CL_ValorFijo = False
        Me.LbNuCTB.ClForm = Nothing
        Me.LbNuCTB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuCTB.ForeColor = System.Drawing.Color.Teal
        Me.LbNuCTB.Location = New System.Drawing.Point(6, 14)
        Me.LbNuCTB.Name = "LbNuCTB"
        Me.LbNuCTB.Size = New System.Drawing.Size(27, 21)
        Me.LbNuCTB.TabIndex = 115
        Me.LbNuCTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Lbejer.Location = New System.Drawing.Point(37, 14)
        Me.Lbejer.Name = "Lbejer"
        Me.Lbejer.Size = New System.Drawing.Size(36, 21)
        Me.Lbejer.TabIndex = 114
        Me.Lbejer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxSerie
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = CType(resources.GetObject("BtBuscaAlbaran.Image"), System.Drawing.Image)
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(286, 20)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 189
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxSerie
        '
        Me.TxSerie.Autonumerico = False
        Me.TxSerie.Buscando = False
        Me.TxSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSerie.ClForm = Nothing
        Me.TxSerie.ClParam = Nothing
        Me.TxSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSerie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSerie.GridLin = Nothing
        Me.TxSerie.HaCambiado = False
        Me.TxSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSerie.lbbusca = Nothing
        Me.TxSerie.Location = New System.Drawing.Point(100, 20)
        Me.TxSerie.MiError = False
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.Orden = 0
        Me.TxSerie.SaltoAlfinal = False
        Me.TxSerie.Siguiente = 0
        Me.TxSerie.Size = New System.Drawing.Size(73, 22)
        Me.TxSerie.TabIndex = 187
        Me.TxSerie.TeclaRepetida = False
        Me.TxSerie.TxDatoFinalSemana = Nothing
        Me.TxSerie.TxDatoInicioSemana = Nothing
        Me.TxSerie.UltimoValorValidado = Nothing
        '
        'LbnomAgr2
        '
        Me.LbnomAgr2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbnomAgr2.CL_ControlAsociado = Nothing
        Me.LbnomAgr2.CL_ValorFijo = False
        Me.LbnomAgr2.ClForm = Nothing
        Me.LbnomAgr2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr2.Location = New System.Drawing.Point(196, 86)
        Me.LbnomAgr2.Name = "LbnomAgr2"
        Me.LbnomAgr2.Size = New System.Drawing.Size(334, 23)
        Me.LbnomAgr2.TabIndex = 127
        '
        'BtAgriAlb
        '
        Me.BtAgriAlb.CL_Ancho = 0
        Me.BtAgriAlb.CL_BuscaAlb = False
        Me.BtAgriAlb.CL_campocodigo = Nothing
        Me.BtAgriAlb.CL_camponombre = Nothing
        Me.BtAgriAlb.CL_CampoOrden = "Nombre"
        Me.BtAgriAlb.CL_ch1000 = False
        Me.BtAgriAlb.CL_ConsultaSql = "Select * from familias"
        Me.BtAgriAlb.CL_ControlAsociado = Nothing
        Me.BtAgriAlb.CL_DevuelveCampo = "Idfamilia"
        Me.BtAgriAlb.CL_dfecha = Nothing
        Me.BtAgriAlb.CL_Entidad = Nothing
        Me.BtAgriAlb.CL_EsId = True
        Me.BtAgriAlb.CL_Filtro = Nothing
        Me.BtAgriAlb.cl_formu = Nothing
        Me.BtAgriAlb.CL_hfecha = Nothing
        Me.BtAgriAlb.cl_ListaW = Nothing
        Me.BtAgriAlb.CL_xCentro = False
        Me.BtAgriAlb.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtAgriAlb.Location = New System.Drawing.Point(159, 86)
        Me.BtAgriAlb.Name = "BtAgriAlb"
        Me.BtAgriAlb.Size = New System.Drawing.Size(33, 23)
        Me.BtAgriAlb.TabIndex = 126
        Me.BtAgriAlb.UseVisualStyleBackColor = True
        '
        'TxAgricultorAlb
        '
        Me.TxAgricultorAlb.Autonumerico = False
        Me.TxAgricultorAlb.Buscando = False
        Me.TxAgricultorAlb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorAlb.ClForm = Nothing
        Me.TxAgricultorAlb.ClParam = Nothing
        Me.TxAgricultorAlb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultorAlb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorAlb.GridLin = Nothing
        Me.TxAgricultorAlb.HaCambiado = False
        Me.TxAgricultorAlb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultorAlb.lbbusca = Nothing
        Me.TxAgricultorAlb.Location = New System.Drawing.Point(100, 86)
        Me.TxAgricultorAlb.MiError = False
        Me.TxAgricultorAlb.Name = "TxAgricultorAlb"
        Me.TxAgricultorAlb.Orden = 0
        Me.TxAgricultorAlb.SaltoAlfinal = False
        Me.TxAgricultorAlb.Siguiente = 0
        Me.TxAgricultorAlb.Size = New System.Drawing.Size(53, 22)
        Me.TxAgricultorAlb.TabIndex = 125
        Me.TxAgricultorAlb.TeclaRepetida = False
        Me.TxAgricultorAlb.TxDatoFinalSemana = Nothing
        Me.TxAgricultorAlb.TxDatoInicioSemana = Nothing
        Me.TxAgricultorAlb.UltimoValorValidado = Nothing
        '
        'LbAgricultor2
        '
        Me.LbAgricultor2.AutoSize = True
        Me.LbAgricultor2.CL_ControlAsociado = Nothing
        Me.LbAgricultor2.CL_ValorFijo = False
        Me.LbAgricultor2.ClForm = Nothing
        Me.LbAgricultor2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor2.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor2.Location = New System.Drawing.Point(9, 89)
        Me.LbAgricultor2.Name = "LbAgricultor2"
        Me.LbAgricultor2.Size = New System.Drawing.Size(73, 16)
        Me.LbAgricultor2.TabIndex = 124
        Me.LbAgricultor2.Text = "Agri. alb."
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(196, 57)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(334, 23)
        Me.LbnomAgr1.TabIndex = 87
        '
        'LbFactura
        '
        Me.LbFactura.AutoSize = True
        Me.LbFactura.CL_ControlAsociado = Nothing
        Me.LbFactura.CL_ValorFijo = False
        Me.LbFactura.ClForm = Nothing
        Me.LbFactura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFactura.ForeColor = System.Drawing.Color.Teal
        Me.LbFactura.Location = New System.Drawing.Point(8, 23)
        Me.LbFactura.Name = "LbFactura"
        Me.LbFactura.Size = New System.Drawing.Size(86, 16)
        Me.LbFactura.TabIndex = 84
        Me.LbFactura.Text = "Nº Factura"
        '
        'TxFactura
        '
        Me.TxFactura.Autonumerico = False
        Me.TxFactura.Buscando = False
        Me.TxFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFactura.ClForm = Nothing
        Me.TxFactura.ClParam = Nothing
        Me.TxFactura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFactura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFactura.GridLin = Nothing
        Me.TxFactura.HaCambiado = False
        Me.TxFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFactura.lbbusca = Nothing
        Me.TxFactura.Location = New System.Drawing.Point(181, 20)
        Me.TxFactura.MiError = False
        Me.TxFactura.Name = "TxFactura"
        Me.TxFactura.Orden = 0
        Me.TxFactura.SaltoAlfinal = False
        Me.TxFactura.Siguiente = 0
        Me.TxFactura.Size = New System.Drawing.Size(101, 22)
        Me.TxFactura.TabIndex = 83
        Me.TxFactura.TeclaRepetida = False
        Me.TxFactura.TxDatoFinalSemana = Nothing
        Me.TxFactura.TxDatoInicioSemana = Nothing
        Me.TxFactura.UltimoValorValidado = Nothing
        '
        'BtAgri
        '
        Me.BtAgri.CL_Ancho = 0
        Me.BtAgri.CL_BuscaAlb = False
        Me.BtAgri.CL_campocodigo = Nothing
        Me.BtAgri.CL_camponombre = Nothing
        Me.BtAgri.CL_CampoOrden = "Nombre"
        Me.BtAgri.CL_ch1000 = False
        Me.BtAgri.CL_ConsultaSql = "Select * from familias"
        Me.BtAgri.CL_ControlAsociado = Nothing
        Me.BtAgri.CL_DevuelveCampo = "Idfamilia"
        Me.BtAgri.CL_dfecha = Nothing
        Me.BtAgri.CL_Entidad = Nothing
        Me.BtAgri.CL_EsId = True
        Me.BtAgri.CL_Filtro = Nothing
        Me.BtAgri.cl_formu = Nothing
        Me.BtAgri.CL_hfecha = Nothing
        Me.BtAgri.cl_ListaW = Nothing
        Me.BtAgri.CL_xCentro = False
        Me.BtAgri.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtAgri.Location = New System.Drawing.Point(159, 57)
        Me.BtAgri.Name = "BtAgri"
        Me.BtAgri.Size = New System.Drawing.Size(33, 23)
        Me.BtAgri.TabIndex = 82
        Me.BtAgri.UseVisualStyleBackColor = True
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(100, 57)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(53, 22)
        Me.TxAgricultor.TabIndex = 81
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(9, 60)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 80
        Me.LbAgricultor.Text = "Agricultor"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(358, 23)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 79
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(416, 20)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxFecha.TabIndex = 78
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'LbImpTotal
        '
        Me.LbImpTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpTotal.CL_ControlAsociado = Nothing
        Me.LbImpTotal.CL_ValorFijo = True
        Me.LbImpTotal.ClForm = Nothing
        Me.LbImpTotal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbImpTotal.Location = New System.Drawing.Point(898, 522)
        Me.LbImpTotal.Name = "LbImpTotal"
        Me.LbImpTotal.Size = New System.Drawing.Size(128, 23)
        Me.LbImpTotal.TabIndex = 100354
        Me.LbImpTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(916, 503)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(108, 16)
        Me.Lb9.TabIndex = 100353
        Me.Lb9.Text = "Total a cobrar"
        '
        'LbImpGenero
        '
        Me.LbImpGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpGenero.CL_ControlAsociado = Nothing
        Me.LbImpGenero.CL_ValorFijo = True
        Me.LbImpGenero.ClForm = Nothing
        Me.LbImpGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpGenero.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbImpGenero.Location = New System.Drawing.Point(333, 476)
        Me.LbImpGenero.Name = "LbImpGenero"
        Me.LbImpGenero.Size = New System.Drawing.Size(111, 23)
        Me.LbImpGenero.TabIndex = 100360
        Me.LbImpGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbImpComi
        '
        Me.LbImpComi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpComi.CL_ControlAsociado = Nothing
        Me.LbImpComi.CL_ValorFijo = True
        Me.LbImpComi.ClForm = Nothing
        Me.LbImpComi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpComi.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbImpComi.Location = New System.Drawing.Point(522, 476)
        Me.LbImpComi.Name = "LbImpComi"
        Me.LbImpComi.Size = New System.Drawing.Size(92, 23)
        Me.LbImpComi.TabIndex = 100362
        Me.LbImpComi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbporcom
        '
        Me.Lbporcom.AutoSize = True
        Me.Lbporcom.CL_ControlAsociado = Nothing
        Me.Lbporcom.CL_ValorFijo = True
        Me.Lbporcom.ClForm = Nothing
        Me.Lbporcom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbporcom.ForeColor = System.Drawing.Color.Teal
        Me.Lbporcom.Location = New System.Drawing.Point(454, 458)
        Me.Lbporcom.Name = "Lbporcom"
        Me.Lbporcom.Size = New System.Drawing.Size(62, 16)
        Me.Lbporcom.TabIndex = 100361
        Me.Lbporcom.Text = "% Com"
        '
        'LbImpBase
        '
        Me.LbImpBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpBase.CL_ControlAsociado = Nothing
        Me.LbImpBase.CL_ValorFijo = True
        Me.LbImpBase.ClForm = Nothing
        Me.LbImpBase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpBase.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbImpBase.Location = New System.Drawing.Point(722, 476)
        Me.LbImpBase.Name = "LbImpBase"
        Me.LbImpBase.Size = New System.Drawing.Size(111, 23)
        Me.LbImpBase.TabIndex = 100366
        Me.LbImpBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxPorCom
        '
        Me.TxPorCom.Autonumerico = False
        Me.TxPorCom.Buscando = False
        Me.TxPorCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPorCom.ClForm = Nothing
        Me.TxPorCom.ClParam = Nothing
        Me.TxPorCom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPorCom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPorCom.GridLin = Nothing
        Me.TxPorCom.HaCambiado = False
        Me.TxPorCom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPorCom.lbbusca = Nothing
        Me.TxPorCom.Location = New System.Drawing.Point(448, 476)
        Me.TxPorCom.MiError = False
        Me.TxPorCom.Name = "TxPorCom"
        Me.TxPorCom.Orden = 0
        Me.TxPorCom.SaltoAlfinal = False
        Me.TxPorCom.Siguiente = 0
        Me.TxPorCom.Size = New System.Drawing.Size(69, 22)
        Me.TxPorCom.TabIndex = 100368
        Me.TxPorCom.TeclaRepetida = False
        Me.TxPorCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPorCom.TxDatoFinalSemana = Nothing
        Me.TxPorCom.TxDatoInicioSemana = Nothing
        Me.TxPorCom.UltimoValorValidado = Nothing
        '
        'TxIva
        '
        Me.TxIva.Autonumerico = False
        Me.TxIva.Buscando = False
        Me.TxIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIva.ClForm = Nothing
        Me.TxIva.ClParam = Nothing
        Me.TxIva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIva.GridLin = Nothing
        Me.TxIva.HaCambiado = False
        Me.TxIva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxIva.lbbusca = Nothing
        Me.TxIva.Location = New System.Drawing.Point(839, 476)
        Me.TxIva.MiError = False
        Me.TxIva.Name = "TxIva"
        Me.TxIva.Orden = 0
        Me.TxIva.SaltoAlfinal = False
        Me.TxIva.Siguiente = 0
        Me.TxIva.Size = New System.Drawing.Size(69, 22)
        Me.TxIva.TabIndex = 100369
        Me.TxIva.TeclaRepetida = False
        Me.TxIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxIva.TxDatoFinalSemana = Nothing
        Me.TxIva.TxDatoInicioSemana = Nothing
        Me.TxIva.UltimoValorValidado = Nothing
        '
        'TxTipoRet
        '
        Me.TxTipoRet.Autonumerico = False
        Me.TxTipoRet.Buscando = False
        Me.TxTipoRet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipoRet.ClForm = Nothing
        Me.TxTipoRet.ClParam = Nothing
        Me.TxTipoRet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTipoRet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipoRet.GridLin = Nothing
        Me.TxTipoRet.HaCambiado = False
        Me.TxTipoRet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTipoRet.lbbusca = Nothing
        Me.TxTipoRet.Location = New System.Drawing.Point(337, 522)
        Me.TxTipoRet.MiError = False
        Me.TxTipoRet.Name = "TxTipoRet"
        Me.TxTipoRet.Orden = 0
        Me.TxTipoRet.SaltoAlfinal = False
        Me.TxTipoRet.Siguiente = 0
        Me.TxTipoRet.Size = New System.Drawing.Size(26, 22)
        Me.TxTipoRet.TabIndex = 100370
        Me.TxTipoRet.TeclaRepetida = False
        Me.TxTipoRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxTipoRet.TxDatoFinalSemana = Nothing
        Me.TxTipoRet.TxDatoInicioSemana = Nothing
        Me.TxTipoRet.UltimoValorValidado = Nothing
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = True
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(533, 458)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(75, 16)
        Me.Lb23.TabIndex = 100371
        Me.Lb23.Text = "Comisión"
        '
        'Lbimpret
        '
        Me.Lbimpret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbimpret.CL_ControlAsociado = Nothing
        Me.Lbimpret.CL_ValorFijo = True
        Me.Lbimpret.ClForm = Nothing
        Me.Lbimpret.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbimpret.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lbimpret.Location = New System.Drawing.Point(448, 522)
        Me.Lbimpret.Name = "Lbimpret"
        Me.Lbimpret.Size = New System.Drawing.Size(92, 23)
        Me.Lbimpret.TabIndex = 100380
        Me.Lbimpret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxGastos
        '
        Me.TxGastos.Autonumerico = False
        Me.TxGastos.Buscando = False
        Me.TxGastos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGastos.ClForm = Nothing
        Me.TxGastos.ClParam = Nothing
        Me.TxGastos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxGastos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGastos.GridLin = Nothing
        Me.TxGastos.HaCambiado = False
        Me.TxGastos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxGastos.lbbusca = Nothing
        Me.TxGastos.Location = New System.Drawing.Point(620, 476)
        Me.TxGastos.MiError = False
        Me.TxGastos.Name = "TxGastos"
        Me.TxGastos.Orden = 0
        Me.TxGastos.SaltoAlfinal = False
        Me.TxGastos.Siguiente = 0
        Me.TxGastos.Size = New System.Drawing.Size(96, 22)
        Me.TxGastos.TabIndex = 100376
        Me.TxGastos.TeclaRepetida = False
        Me.TxGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxGastos.TxDatoFinalSemana = Nothing
        Me.TxGastos.TxDatoInicioSemana = Nothing
        Me.TxGastos.UltimoValorValidado = Nothing
        '
        'Lbgastos
        '
        Me.Lbgastos.AutoSize = True
        Me.Lbgastos.CL_ControlAsociado = Nothing
        Me.Lbgastos.CL_ValorFijo = True
        Me.Lbgastos.ClForm = Nothing
        Me.Lbgastos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbgastos.ForeColor = System.Drawing.Color.Teal
        Me.Lbgastos.Location = New System.Drawing.Point(617, 458)
        Me.Lbgastos.Name = "Lbgastos"
        Me.Lbgastos.Size = New System.Drawing.Size(101, 16)
        Me.Lbgastos.TabIndex = 100374
        Me.Lbgastos.Text = "Otros gastos"
        '
        'Lb27
        '
        Me.Lb27.AutoSize = True
        Me.Lb27.CL_ControlAsociado = Nothing
        Me.Lb27.CL_ValorFijo = True
        Me.Lb27.ClForm = Nothing
        Me.Lb27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb27.ForeColor = System.Drawing.Color.Teal
        Me.Lb27.Location = New System.Drawing.Point(337, 458)
        Me.Lb27.Name = "Lb27"
        Me.Lb27.Size = New System.Drawing.Size(98, 16)
        Me.Lb27.TabIndex = 100382
        Me.Lb27.Text = "Imp. Género"
        '
        'Lbporret
        '
        Me.Lbporret.AutoSize = True
        Me.Lbporret.CL_ControlAsociado = Nothing
        Me.Lbporret.CL_ValorFijo = True
        Me.Lbporret.ClForm = Nothing
        Me.Lbporret.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbporret.ForeColor = System.Drawing.Color.Teal
        Me.Lbporret.Location = New System.Drawing.Point(334, 503)
        Me.Lbporret.Name = "Lbporret"
        Me.Lbporret.Size = New System.Drawing.Size(101, 16)
        Me.Lbporret.TabIndex = 100383
        Me.Lbporret.Text = "% Retención"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(724, 458)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(82, 16)
        Me.Lb1.TabIndex = 100395
        Me.Lb1.Text = "Base Imp."
        '
        'Lbiva
        '
        Me.Lbiva.AutoSize = True
        Me.Lbiva.CL_ControlAsociado = Nothing
        Me.Lbiva.CL_ValorFijo = True
        Me.Lbiva.ClForm = Nothing
        Me.Lbiva.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiva.ForeColor = System.Drawing.Color.Teal
        Me.Lbiva.Location = New System.Drawing.Point(846, 458)
        Me.Lbiva.Name = "Lbiva"
        Me.Lbiva.Size = New System.Drawing.Size(55, 16)
        Me.Lbiva.TabIndex = 100396
        Me.Lbiva.Text = "% IVA"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(916, 458)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(81, 16)
        Me.Lb3.TabIndex = 100398
        Me.Lb3.Text = "Cuota IVA"
        '
        'LbimpCuota
        '
        Me.LbimpCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbimpCuota.CL_ControlAsociado = Nothing
        Me.LbimpCuota.CL_ValorFijo = True
        Me.LbimpCuota.ClForm = Nothing
        Me.LbimpCuota.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbimpCuota.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbimpCuota.Location = New System.Drawing.Point(914, 476)
        Me.LbimpCuota.Name = "LbimpCuota"
        Me.LbimpCuota.Size = New System.Drawing.Size(111, 23)
        Me.LbimpCuota.TabIndex = 100397
        Me.LbimpCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxPorRet
        '
        Me.TxPorRet.Autonumerico = False
        Me.TxPorRet.Buscando = False
        Me.TxPorRet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPorRet.ClForm = Nothing
        Me.TxPorRet.ClParam = Nothing
        Me.TxPorRet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPorRet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPorRet.GridLin = Nothing
        Me.TxPorRet.HaCambiado = False
        Me.TxPorRet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPorRet.lbbusca = Nothing
        Me.TxPorRet.Location = New System.Drawing.Point(369, 522)
        Me.TxPorRet.MiError = False
        Me.TxPorRet.Name = "TxPorRet"
        Me.TxPorRet.Orden = 0
        Me.TxPorRet.SaltoAlfinal = False
        Me.TxPorRet.Siguiente = 0
        Me.TxPorRet.Size = New System.Drawing.Size(58, 22)
        Me.TxPorRet.TabIndex = 100399
        Me.TxPorRet.TeclaRepetida = False
        Me.TxPorRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxPorRet.TxDatoFinalSemana = Nothing
        Me.TxPorRet.TxDatoInicioSemana = Nothing
        Me.TxPorRet.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(452, 503)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(80, 16)
        Me.Lb5.TabIndex = 100400
        Me.Lb5.Text = "Retención"
        '
        'TxporFondo
        '
        Me.TxporFondo.Autonumerico = False
        Me.TxporFondo.Buscando = False
        Me.TxporFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxporFondo.ClForm = Nothing
        Me.TxporFondo.ClParam = Nothing
        Me.TxporFondo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxporFondo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxporFondo.GridLin = Nothing
        Me.TxporFondo.HaCambiado = False
        Me.TxporFondo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxporFondo.lbbusca = Nothing
        Me.TxporFondo.Location = New System.Drawing.Point(546, 522)
        Me.TxporFondo.MiError = False
        Me.TxporFondo.Name = "TxporFondo"
        Me.TxporFondo.Orden = 0
        Me.TxporFondo.SaltoAlfinal = False
        Me.TxporFondo.Siguiente = 0
        Me.TxporFondo.Size = New System.Drawing.Size(69, 22)
        Me.TxporFondo.TabIndex = 100402
        Me.TxporFondo.TeclaRepetida = False
        Me.TxporFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxporFondo.TxDatoFinalSemana = Nothing
        Me.TxporFondo.TxDatoInicioSemana = Nothing
        Me.TxporFondo.UltimoValorValidado = Nothing
        '
        'lbporfondo
        '
        Me.lbporfondo.AutoSize = True
        Me.lbporfondo.CL_ControlAsociado = Nothing
        Me.lbporfondo.CL_ValorFijo = True
        Me.lbporfondo.ClForm = Nothing
        Me.lbporfondo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbporfondo.ForeColor = System.Drawing.Color.Teal
        Me.lbporfondo.Location = New System.Drawing.Point(547, 503)
        Me.lbporfondo.Name = "lbporfondo"
        Me.lbporfondo.Size = New System.Drawing.Size(74, 16)
        Me.lbporfondo.TabIndex = 100401
        Me.lbporfondo.Text = "% Fondo"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(627, 503)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(94, 16)
        Me.Lb7.TabIndex = 100404
        Me.Lb7.Text = "F.Operativo"
        '
        'LbImpFondo
        '
        Me.LbImpFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImpFondo.CL_ControlAsociado = Nothing
        Me.LbImpFondo.CL_ValorFijo = True
        Me.LbImpFondo.ClForm = Nothing
        Me.LbImpFondo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImpFondo.ForeColor = System.Drawing.Color.SteelBlue
        Me.LbImpFondo.Location = New System.Drawing.Point(629, 522)
        Me.LbImpFondo.Name = "LbImpFondo"
        Me.LbImpFondo.Size = New System.Drawing.Size(92, 23)
        Me.LbImpFondo.TabIndex = 100403
        Me.LbImpFondo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmHisfaAgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 585)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.LbImpFondo)
        Me.Controls.Add(Me.TxporFondo)
        Me.Controls.Add(Me.lbporfondo)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.TxPorRet)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.LbimpCuota)
        Me.Controls.Add(Me.Lbiva)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.Lbporret)
        Me.Controls.Add(Me.Lb27)
        Me.Controls.Add(Me.Lbimpret)
        Me.Controls.Add(Me.TxGastos)
        Me.Controls.Add(Me.Lbgastos)
        Me.Controls.Add(Me.Lb23)
        Me.Controls.Add(Me.TxTipoRet)
        Me.Controls.Add(Me.TxIva)
        Me.Controls.Add(Me.TxPorCom)
        Me.Controls.Add(Me.LbImpBase)
        Me.Controls.Add(Me.LbImpComi)
        Me.Controls.Add(Me.Lbporcom)
        Me.Controls.Add(Me.LbImpGenero)
        Me.Controls.Add(Me.LbImpTotal)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmHisfaAgr"
        Me.Text = "Historico Facturas Agricultores"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.LbImpTotal, 0)
        Me.Controls.SetChildIndex(Me.LbImpGenero, 0)
        Me.Controls.SetChildIndex(Me.Lbporcom, 0)
        Me.Controls.SetChildIndex(Me.LbImpComi, 0)
        Me.Controls.SetChildIndex(Me.LbImpBase, 0)
        Me.Controls.SetChildIndex(Me.TxPorCom, 0)
        Me.Controls.SetChildIndex(Me.TxIva, 0)
        Me.Controls.SetChildIndex(Me.TxTipoRet, 0)
        Me.Controls.SetChildIndex(Me.Lb23, 0)
        Me.Controls.SetChildIndex(Me.Lbgastos, 0)
        Me.Controls.SetChildIndex(Me.TxGastos, 0)
        Me.Controls.SetChildIndex(Me.Lbimpret, 0)
        Me.Controls.SetChildIndex(Me.Lb27, 0)
        Me.Controls.SetChildIndex(Me.Lbporret, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lbiva, 0)
        Me.Controls.SetChildIndex(Me.LbimpCuota, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxPorRet, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.lbporfondo, 0)
        Me.Controls.SetChildIndex(Me.TxporFondo, 0)
        Me.Controls.SetChildIndex(Me.LbImpFondo, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents LbNomCate As NetAgro.Lb
    Friend WithEvents BtCategoria As NetAgro.BtBusca
    Friend WithEvents TxCategoria As NetAgro.TxDato
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents Lb14 As NetAgro.Lb
    Friend WithEvents LbNumAlb As NetAgro.Lb
    Friend WithEvents TxPartida As NetAgro.TxDato
    Friend WithEvents LbPartida As NetAgro.Lb


    Friend WithEvents TxPrecio As NetAgro.TxDato
    Friend WithEvents TxKilos As NetAgro.TxDato
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents BtSemana As NetAgro.BtBusca
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents Lbsemana As NetAgro.Lb

    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents TxDato_4 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents Lbnom_4 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxDato_29 As NetAgro.TxDato
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents TxDato_27 As NetAgro.TxDato
    Friend WithEvents Lb_28 As NetAgro.Lb
    Friend WithEvents Lb_27 As NetAgro.Lb
    Friend WithEvents TxDato_7 As NetAgro.TxDato
    Friend WithEvents Lb_7 As NetAgro.Lb
    Friend WithEvents Lbnom_6 As NetAgro.Lb
    Friend WithEvents BtBusca_6 As NetAgro.BtBusca
    Friend WithEvents TxDato_6 As NetAgro.TxDato
    Friend WithEvents Lb_6 As NetAgro.Lb
    Friend WithEvents Lbnom_5 As NetAgro.Lb
    Friend WithEvents BtBuscaClienteAlb As NetAgro.BtBusca
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents TxDato_28 As NetAgro.TxDato
    Friend WithEvents LbTotDivisa As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbTotEuros As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbGastosCom As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents LbTGeneros As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbCuotaGen As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_9 As NetAgro.TxDato
    Friend WithEvents Lb_9 As NetAgro.Lb
    Friend WithEvents Lbnom_8 As NetAgro.Lb
    Friend WithEvents BtBusca_8 As NetAgro.BtBusca
    Friend WithEvents TxDato_8 As NetAgro.TxDato
    Friend WithEvents Lb_8 As NetAgro.Lb
    Friend WithEvents Lbnom_3 As NetAgro.Lb
    Friend WithEvents BtBusca_3 As NetAgro.BtBusca
    Friend WithEvents TxDato_0 As NetAgro.TxDato
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents GridAlbaranes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAlbaranes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb_30 As NetAgro.Lb
    Friend WithEvents TxDato_30 As NetAgro.TxDato
    Friend WithEvents Lb_29 As NetAgro.Lb
    Friend WithEvents GridGastos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewGastos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents Lbnom_27 As NetAgro.Lb
    Friend WithEvents BtBusca_GEC As NetAgro.BtBusca
    Friend WithEvents LbTEnvases As NetAgro.Lb
    Friend WithEvents LbTVarios As NetAgro.Lb
    Friend WithEvents TxDato_40 As NetAgro.TxDato
    Friend WithEvents TxDato_41 As NetAgro.TxDato
    Friend WithEvents TxDato_42 As NetAgro.TxDato
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents LbCuotaEnv As NetAgro.Lb
    Friend WithEvents LbCuotaVar As NetAgro.Lb
    Friend WithEvents LbCuotaReVar As NetAgro.Lb
    Friend WithEvents LbCuotaReEnv As NetAgro.Lb
    Friend WithEvents Lb18 As NetAgro.Lb
    Friend WithEvents TxDato_45 As NetAgro.TxDato
    Friend WithEvents TxDato_44 As NetAgro.TxDato
    Friend WithEvents TxDato_43 As NetAgro.TxDato
    Friend WithEvents LbCuotaReGen As NetAgro.Lb
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents Lb27 As NetAgro.Lb
    Friend WithEvents Lb28 As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents TxDato_52 As NetAgro.TxDato
    Friend WithEvents TxDato_51 As NetAgro.TxDato
    Friend WithEvents Lb30 As NetAgro.Lb
    Friend WithEvents BtBusca_51 As NetAgro.BtBusca
    Friend WithEvents BtBusca_52 As NetAgro.BtBusca
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbComerciales As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Lb_51 As NetAgro.Lb
    Friend WithEvents Lb_52 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAsiento As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbejer As NetAgro.Lb
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomPv As NetAgro.Lb
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxReferencia As NetAgro.TxDato
    Friend WithEvents LbReferencia As NetAgro.Lb
    Friend WithEvents LbNuCTB As NetAgro.Lb

    Friend WithEvents LbnomGenero As NetAgro.Lb
    Friend WithEvents BtGenero As NetAgro.BtBusca
    Friend WithEvents LbPrecio As NetAgro.Lb
    Friend WithEvents TxGenero As NetAgro.TxDato
    Friend WithEvents LbGenero As NetAgro.Lb

    Friend WithEvents TxSerie As NetAgro.TxDato
    Friend WithEvents LbnomAgr2 As NetAgro.Lb
    Friend WithEvents BtAgriAlb As NetAgro.BtBusca
    Friend WithEvents TxAgricultorAlb As NetAgro.TxDato
    Friend WithEvents LbAgricultor2 As NetAgro.Lb
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents LbFactura As NetAgro.Lb
    Friend WithEvents TxFactura As NetAgro.TxDato
    Friend WithEvents BtAgri As NetAgro.BtBusca
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents LbImpTotal As NetAgro.Lb
    Friend WithEvents LbImpGenero As NetAgro.Lb
    Friend WithEvents LbImpComi As NetAgro.Lb
    Friend WithEvents Lbporcom As NetAgro.Lb
    Friend WithEvents LbImpBase As NetAgro.Lb
    Friend WithEvents TxPorCom As NetAgro.TxDato
    Friend WithEvents TxIva As NetAgro.TxDato
    Friend WithEvents TxTipoRet As NetAgro.TxDato
    Friend WithEvents Lbimpret As NetAgro.Lb
    Friend WithEvents TxGastos As NetAgro.TxDato
    Friend WithEvents Lbgastos As NetAgro.Lb
    Friend WithEvents Lbporret As NetAgro.Lb
    Friend WithEvents Lbiva As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbimpCuota As NetAgro.Lb
    Friend WithEvents TxPorRet As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxporFondo As NetAgro.TxDato
    Friend WithEvents lbporfondo As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbImpFondo As NetAgro.Lb

End Class
