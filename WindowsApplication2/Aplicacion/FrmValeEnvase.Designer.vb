<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValeEnvase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValeEnvase))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxTractora = New NetAgro.TxDato(Me.components)
        Me.LbTractora = New NetAgro.Lb(Me.components)
        Me.TxMatricula = New NetAgro.TxDato(Me.components)
        Me.LbMatricula = New NetAgro.Lb(Me.components)
        Me.LbNomTransportista = New NetAgro.Lb(Me.components)
        Me.BtBuscaTransportista = New NetAgro.BtBusca(Me.components)
        Me.TxTransportista = New NetAgro.TxDato(Me.components)
        Me.LbTransportista = New NetAgro.Lb(Me.components)
        Me.chkImprimirCMR = New NetAgro.Chk(Me.components)
        Me.LbNumFac = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.Lb_7 = New NetAgro.Lb(Me.components)
        Me.TxDato_7 = New NetAgro.TxDato(Me.components)
        Me.TxDato_6 = New NetAgro.TxDato(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.BtBusca_5 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_5 = New NetAgro.TxDato(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.BtBusca_4 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_4 = New NetAgro.TxDato(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomVale = New NetAgro.Lb(Me.components)
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.LbNom_4 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.BtNuevo = New NetAgro.ClButton()
        Me.Lbnom_3 = New NetAgro.Lb(Me.components)
        Me.BtBusca_3 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_3 = New NetAgro.TxDato(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbnom_16 = New NetAgro.Lb(Me.components)
        Me.Lb_16 = New NetAgro.Lb(Me.components)
        Me.BtBusca_16 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_16 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_15 = New NetAgro.Lb(Me.components)
        Me.TxDato_15 = New NetAgro.TxDato(Me.components)
        Me.Lb_15 = New NetAgro.Lb(Me.components)
        Me.BtBusca_15 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_11 = New NetAgro.Lb(Me.components)
        Me.Lb_13 = New NetAgro.Lb(Me.components)
        Me.TxDato_13 = New NetAgro.TxDato(Me.components)
        Me.Lb_12 = New NetAgro.Lb(Me.components)
        Me.TxDato_12 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.BtBusca_10 = New NetAgro.BtBusca(Me.components)
        Me.Lb_14 = New NetAgro.Lb(Me.components)
        Me.TxDato_14 = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Controls.Add(Me.TxTractora)
        Me.Panel4.Controls.Add(Me.LbTractora)
        Me.Panel4.Controls.Add(Me.TxMatricula)
        Me.Panel4.Controls.Add(Me.LbMatricula)
        Me.Panel4.Controls.Add(Me.LbNomTransportista)
        Me.Panel4.Controls.Add(Me.BtBuscaTransportista)
        Me.Panel4.Controls.Add(Me.TxTransportista)
        Me.Panel4.Controls.Add(Me.LbTransportista)
        Me.Panel4.Controls.Add(Me.chkImprimirCMR)
        Me.Panel4.Controls.Add(Me.LbNumFac)
        Me.Panel4.Controls.Add(Me.Lb13)
        Me.Panel4.Controls.Add(Me.Lb_7)
        Me.Panel4.Controls.Add(Me.TxDato_7)
        Me.Panel4.Controls.Add(Me.TxDato_6)
        Me.Panel4.Controls.Add(Me.Lb_5)
        Me.Panel4.Controls.Add(Me.BtBusca_5)
        Me.Panel4.Controls.Add(Me.TxDato_5)
        Me.Panel4.Controls.Add(Me.Lb_4)
        Me.Panel4.Controls.Add(Me.BtBusca_4)
        Me.Panel4.Controls.Add(Me.TxDato_4)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.LbNom_4)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Lb_2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Controls.Add(Me.BtNuevo)
        Me.Panel4.Controls.Add(Me.Lbnom_3)
        Me.Panel4.Controls.Add(Me.BtBusca_3)
        Me.Panel4.Controls.Add(Me.Lb_3)
        Me.Panel4.Controls.Add(Me.TxDato_3)
        Me.Panel4.Controls.Add(Me.BotonesAvance1)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato_1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1044, 197)
        Me.Panel4.TabIndex = 72
        '
        'TxTractora
        '
        Me.TxTractora.Autonumerico = False
        Me.TxTractora.Buscando = False
        Me.TxTractora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTractora.ClForm = Nothing
        Me.TxTractora.ClParam = Nothing
        Me.TxTractora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTractora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTractora.GridLin = Nothing
        Me.TxTractora.HaCambiado = False
        Me.TxTractora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTractora.lbbusca = Nothing
        Me.TxTractora.Location = New System.Drawing.Point(894, 133)
        Me.TxTractora.MiError = False
        Me.TxTractora.Name = "TxTractora"
        Me.TxTractora.Orden = 0
        Me.TxTractora.SaltoAlfinal = False
        Me.TxTractora.Siguiente = 0
        Me.TxTractora.Size = New System.Drawing.Size(124, 22)
        Me.TxTractora.TabIndex = 100380
        Me.TxTractora.TeclaRepetida = False
        Me.TxTractora.TxDatoFinalSemana = Nothing
        Me.TxTractora.TxDatoInicioSemana = Nothing
        Me.TxTractora.UltimoValorValidado = Nothing
        '
        'LbTractora
        '
        Me.LbTractora.AutoSize = True
        Me.LbTractora.CL_ControlAsociado = Nothing
        Me.LbTractora.CL_ValorFijo = False
        Me.LbTractora.ClForm = Nothing
        Me.LbTractora.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTractora.ForeColor = System.Drawing.Color.Teal
        Me.LbTractora.Location = New System.Drawing.Point(777, 136)
        Me.LbTractora.Name = "LbTractora"
        Me.LbTractora.Size = New System.Drawing.Size(105, 16)
        Me.LbTractora.TabIndex = 100379
        Me.LbTractora.Text = "Mat. Tractora"
        '
        'TxMatricula
        '
        Me.TxMatricula.Autonumerico = False
        Me.TxMatricula.Buscando = False
        Me.TxMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMatricula.ClForm = Nothing
        Me.TxMatricula.ClParam = Nothing
        Me.TxMatricula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMatricula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMatricula.GridLin = Nothing
        Me.TxMatricula.HaCambiado = False
        Me.TxMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxMatricula.lbbusca = Nothing
        Me.TxMatricula.Location = New System.Drawing.Point(894, 103)
        Me.TxMatricula.MiError = False
        Me.TxMatricula.Name = "TxMatricula"
        Me.TxMatricula.Orden = 0
        Me.TxMatricula.SaltoAlfinal = False
        Me.TxMatricula.Siguiente = 0
        Me.TxMatricula.Size = New System.Drawing.Size(124, 22)
        Me.TxMatricula.TabIndex = 100378
        Me.TxMatricula.TeclaRepetida = False
        Me.TxMatricula.TxDatoFinalSemana = Nothing
        Me.TxMatricula.TxDatoInicioSemana = Nothing
        Me.TxMatricula.UltimoValorValidado = Nothing
        '
        'LbMatricula
        '
        Me.LbMatricula.AutoSize = True
        Me.LbMatricula.CL_ControlAsociado = Nothing
        Me.LbMatricula.CL_ValorFijo = False
        Me.LbMatricula.ClForm = Nothing
        Me.LbMatricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMatricula.ForeColor = System.Drawing.Color.Teal
        Me.LbMatricula.Location = New System.Drawing.Point(777, 106)
        Me.LbMatricula.Name = "LbMatricula"
        Me.LbMatricula.Size = New System.Drawing.Size(116, 16)
        Me.LbMatricula.TabIndex = 100377
        Me.LbMatricula.Text = "Mat. Remolque"
        '
        'LbNomTransportista
        '
        Me.LbNomTransportista.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomTransportista.CL_ControlAsociado = Nothing
        Me.LbNomTransportista.CL_ValorFijo = False
        Me.LbNomTransportista.ClForm = Nothing
        Me.LbNomTransportista.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomTransportista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomTransportista.Location = New System.Drawing.Point(272, 133)
        Me.LbNomTransportista.Name = "LbNomTransportista"
        Me.LbNomTransportista.Size = New System.Drawing.Size(401, 23)
        Me.LbNomTransportista.TabIndex = 100376
        '
        'BtBuscaTransportista
        '
        Me.BtBuscaTransportista.CL_Ancho = 0
        Me.BtBuscaTransportista.CL_BuscaAlb = False
        Me.BtBuscaTransportista.CL_campocodigo = Nothing
        Me.BtBuscaTransportista.CL_camponombre = Nothing
        Me.BtBuscaTransportista.CL_CampoOrden = "Nombre"
        Me.BtBuscaTransportista.CL_ch1000 = False
        Me.BtBuscaTransportista.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTransportista.CL_ControlAsociado = Nothing
        Me.BtBuscaTransportista.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTransportista.CL_dfecha = Nothing
        Me.BtBuscaTransportista.CL_Entidad = Nothing
        Me.BtBuscaTransportista.CL_EsId = True
        Me.BtBuscaTransportista.CL_Filtro = Nothing
        Me.BtBuscaTransportista.cl_formu = Nothing
        Me.BtBuscaTransportista.CL_hfecha = Nothing
        Me.BtBuscaTransportista.cl_ListaW = Nothing
        Me.BtBuscaTransportista.CL_xCentro = False
        Me.BtBuscaTransportista.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTransportista.Location = New System.Drawing.Point(231, 133)
        Me.BtBuscaTransportista.Name = "BtBuscaTransportista"
        Me.BtBuscaTransportista.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTransportista.TabIndex = 100375
        Me.BtBuscaTransportista.UseVisualStyleBackColor = True
        '
        'TxTransportista
        '
        Me.TxTransportista.Autonumerico = False
        Me.TxTransportista.Buscando = False
        Me.TxTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTransportista.ClForm = Nothing
        Me.TxTransportista.ClParam = Nothing
        Me.TxTransportista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTransportista.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTransportista.GridLin = Nothing
        Me.TxTransportista.HaCambiado = False
        Me.TxTransportista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTransportista.lbbusca = Nothing
        Me.TxTransportista.Location = New System.Drawing.Point(114, 133)
        Me.TxTransportista.MiError = False
        Me.TxTransportista.Name = "TxTransportista"
        Me.TxTransportista.Orden = 0
        Me.TxTransportista.SaltoAlfinal = False
        Me.TxTransportista.Siguiente = 0
        Me.TxTransportista.Size = New System.Drawing.Size(53, 22)
        Me.TxTransportista.TabIndex = 100374
        Me.TxTransportista.TeclaRepetida = False
        Me.TxTransportista.TxDatoFinalSemana = Nothing
        Me.TxTransportista.TxDatoInicioSemana = Nothing
        Me.TxTransportista.UltimoValorValidado = Nothing
        '
        'LbTransportista
        '
        Me.LbTransportista.AutoSize = True
        Me.LbTransportista.CL_ControlAsociado = Nothing
        Me.LbTransportista.CL_ValorFijo = False
        Me.LbTransportista.ClForm = Nothing
        Me.LbTransportista.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTransportista.ForeColor = System.Drawing.Color.Teal
        Me.LbTransportista.Location = New System.Drawing.Point(6, 136)
        Me.LbTransportista.Name = "LbTransportista"
        Me.LbTransportista.Size = New System.Drawing.Size(105, 16)
        Me.LbTransportista.TabIndex = 100373
        Me.LbTransportista.Text = "Transportista"
        '
        'chkImprimirCMR
        '
        Me.chkImprimirCMR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImprimirCMR.AutoSize = True
        Me.chkImprimirCMR.Campobd = Nothing
        Me.chkImprimirCMR.ClForm = Nothing
        Me.chkImprimirCMR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimirCMR.ForeColor = System.Drawing.Color.Teal
        Me.chkImprimirCMR.GridLin = Nothing
        Me.chkImprimirCMR.HaCambiado = False
        Me.chkImprimirCMR.Location = New System.Drawing.Point(893, 165)
        Me.chkImprimirCMR.MiEntidad = Nothing
        Me.chkImprimirCMR.MiError = False
        Me.chkImprimirCMR.Name = "chkImprimirCMR"
        Me.chkImprimirCMR.Orden = 0
        Me.chkImprimirCMR.SaltoAlfinal = False
        Me.chkImprimirCMR.Size = New System.Drawing.Size(125, 20)
        Me.chkImprimirCMR.TabIndex = 100287
        Me.chkImprimirCMR.Text = "Imprimir CMR"
        Me.chkImprimirCMR.UseVisualStyleBackColor = True
        Me.chkImprimirCMR.ValorCampoFalse = Nothing
        Me.chkImprimirCMR.ValorCampoTrue = Nothing
        Me.chkImprimirCMR.ValorDefecto = False
        '
        'LbNumFac
        '
        Me.LbNumFac.BackColor = System.Drawing.Color.White
        Me.LbNumFac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNumFac.CL_ControlAsociado = Nothing
        Me.LbNumFac.CL_ValorFijo = False
        Me.LbNumFac.ClForm = Nothing
        Me.LbNumFac.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumFac.ForeColor = System.Drawing.Color.Teal
        Me.LbNumFac.Location = New System.Drawing.Point(790, 43)
        Me.LbNumFac.Name = "LbNumFac"
        Me.LbNumFac.Size = New System.Drawing.Size(107, 22)
        Me.LbNumFac.TabIndex = 149
        Me.LbNumFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(698, 46)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(86, 16)
        Me.Lb13.TabIndex = 148
        Me.Lb13.Text = "Nº Factura"
        '
        'Lb_7
        '
        Me.Lb_7.AutoSize = True
        Me.Lb_7.CL_ControlAsociado = Nothing
        Me.Lb_7.CL_ValorFijo = False
        Me.Lb_7.ClForm = Nothing
        Me.Lb_7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_7.ForeColor = System.Drawing.Color.Teal
        Me.Lb_7.Location = New System.Drawing.Point(509, 106)
        Me.Lb_7.Name = "Lb_7"
        Me.Lb_7.Size = New System.Drawing.Size(85, 16)
        Me.Lb_7.TabIndex = 136
        Me.Lb_7.Text = "Referencia"
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
        Me.TxDato_7.Location = New System.Drawing.Point(600, 103)
        Me.TxDato_7.MiError = False
        Me.TxDato_7.Name = "TxDato_7"
        Me.TxDato_7.Orden = 0
        Me.TxDato_7.SaltoAlfinal = False
        Me.TxDato_7.Siguiente = 0
        Me.TxDato_7.Size = New System.Drawing.Size(150, 22)
        Me.TxDato_7.TabIndex = 135
        Me.TxDato_7.TeclaRepetida = False
        Me.TxDato_7.TxDatoFinalSemana = Nothing
        Me.TxDato_7.TxDatoInicioSemana = Nothing
        Me.TxDato_7.UltimoValorValidado = Nothing
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
        Me.TxDato_6.Location = New System.Drawing.Point(270, 164)
        Me.TxDato_6.MiError = False
        Me.TxDato_6.Name = "TxDato_6"
        Me.TxDato_6.Orden = 0
        Me.TxDato_6.SaltoAlfinal = False
        Me.TxDato_6.Siguiente = 0
        Me.TxDato_6.Size = New System.Drawing.Size(403, 22)
        Me.TxDato_6.TabIndex = 134
        Me.TxDato_6.TeclaRepetida = False
        Me.TxDato_6.TxDatoFinalSemana = Nothing
        Me.TxDato_6.TxDatoInicioSemana = Nothing
        Me.TxDato_6.UltimoValorValidado = Nothing
        '
        'Lb_5
        '
        Me.Lb_5.AutoSize = True
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.Teal
        Me.Lb_5.Location = New System.Drawing.Point(6, 167)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(77, 16)
        Me.Lb_5.TabIndex = 133
        Me.Lb_5.Text = "Concepto"
        '
        'BtBusca_5
        '
        Me.BtBusca_5.CL_Ancho = 0
        Me.BtBusca_5.CL_BuscaAlb = False
        Me.BtBusca_5.CL_campocodigo = Nothing
        Me.BtBusca_5.CL_camponombre = Nothing
        Me.BtBusca_5.CL_CampoOrden = "Nombre"
        Me.BtBusca_5.CL_ch1000 = False
        Me.BtBusca_5.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_5.CL_ControlAsociado = Me.TxDato_5
        Me.BtBusca_5.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_5.CL_dfecha = Nothing
        Me.BtBusca_5.CL_Entidad = Nothing
        Me.BtBusca_5.CL_EsId = True
        Me.BtBusca_5.CL_Filtro = Nothing
        Me.BtBusca_5.cl_formu = Nothing
        Me.BtBusca_5.CL_hfecha = Nothing
        Me.BtBusca_5.cl_ListaW = Nothing
        Me.BtBusca_5.CL_xCentro = False
        Me.BtBusca_5.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_5.Location = New System.Drawing.Point(231, 164)
        Me.BtBusca_5.Name = "BtBusca_5"
        Me.BtBusca_5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_5.TabIndex = 132
        Me.BtBusca_5.UseVisualStyleBackColor = True
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
        Me.TxDato_5.Location = New System.Drawing.Point(114, 164)
        Me.TxDato_5.MiError = False
        Me.TxDato_5.Name = "TxDato_5"
        Me.TxDato_5.Orden = 0
        Me.TxDato_5.SaltoAlfinal = False
        Me.TxDato_5.Siguiente = 0
        Me.TxDato_5.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_5.TabIndex = 131
        Me.TxDato_5.TeclaRepetida = False
        Me.TxDato_5.TxDatoFinalSemana = Nothing
        Me.TxDato_5.TxDatoInicioSemana = Nothing
        Me.TxDato_5.UltimoValorValidado = Nothing
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(6, 106)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(71, 16)
        Me.Lb_4.TabIndex = 130
        Me.Lb_4.Text = "Almacén"
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
        Me.BtBusca_4.CL_ControlAsociado = Me.TxDato_4
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
        Me.BtBusca_4.Location = New System.Drawing.Point(231, 103)
        Me.BtBusca_4.Name = "BtBusca_4"
        Me.BtBusca_4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_4.TabIndex = 129
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
        Me.TxDato_4.Location = New System.Drawing.Point(114, 103)
        Me.TxDato_4.MiError = False
        Me.TxDato_4.Name = "TxDato_4"
        Me.TxDato_4.Orden = 0
        Me.TxDato_4.SaltoAlfinal = False
        Me.TxDato_4.Siguiente = 0
        Me.TxDato_4.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_4.TabIndex = 128
        Me.TxDato_4.TeclaRepetida = False
        Me.TxDato_4.TxDatoFinalSemana = Nothing
        Me.TxDato_4.TxDatoInicioSemana = Nothing
        Me.TxDato_4.UltimoValorValidado = Nothing
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNomVale)
        Me.Panel3.Controls.Add(Me.LbNomCentro)
        Me.Panel3.Controls.Add(Me.LbCentro)
        Me.Panel3.Controls.Add(Me.Lb29)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(693, 33)
        Me.Panel3.TabIndex = 125
        '
        'LbNomVale
        '
        Me.LbNomVale.AutoSize = True
        Me.LbNomVale.CL_ControlAsociado = Nothing
        Me.LbNomVale.CL_ValorFijo = True
        Me.LbNomVale.ClForm = Nothing
        Me.LbNomVale.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomVale.ForeColor = System.Drawing.Color.Blue
        Me.LbNomVale.Location = New System.Drawing.Point(316, 1)
        Me.LbNomVale.Name = "LbNomVale"
        Me.LbNomVale.Size = New System.Drawing.Size(264, 25)
        Me.LbNomVale.TabIndex = 116
        Me.LbNomVale.Text = "Albaranes de entrada"
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.White
        Me.LbNomCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = True
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbNomCentro.Location = New System.Drawing.Point(147, 5)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(117, 21)
        Me.LbNomCentro.TabIndex = 115
        Me.LbNomCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCentro
        '
        Me.LbCentro.BackColor = System.Drawing.Color.White
        Me.LbCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = True
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(114, 5)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(28, 21)
        Me.LbCentro.TabIndex = 114
        Me.LbCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = True
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(6, 7)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(57, 16)
        Me.Lb29.TabIndex = 113
        Me.Lb29.Text = "Centro"
        '
        'LbNom_4
        '
        Me.LbNom_4.BackColor = System.Drawing.Color.LightGray
        Me.LbNom_4.CL_ControlAsociado = Nothing
        Me.LbNom_4.CL_ValorFijo = False
        Me.LbNom_4.ClForm = Nothing
        Me.LbNom_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_4.Location = New System.Drawing.Point(270, 105)
        Me.LbNom_4.Name = "LbNom_4"
        Me.LbNom_4.Size = New System.Drawing.Size(204, 18)
        Me.LbNom_4.TabIndex = 86
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.White
        Me.LbCampa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = False
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.Teal
        Me.LbCampa.Location = New System.Drawing.Point(114, 44)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(421, 46)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(52, 16)
        Me.Lb_2.TabIndex = 77
        Me.Lb_2.Text = "Fecha"
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
        Me.TxDato_2.Location = New System.Drawing.Point(487, 43)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_2.TabIndex = 76
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'BtNuevo
        '
        Me.BtNuevo.Image = CType(resources.GetObject("BtNuevo.Image"), System.Drawing.Image)
        Me.BtNuevo.Location = New System.Drawing.Point(380, 43)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Orden = 0
        Me.BtNuevo.PedirClave = True
        Me.BtNuevo.Size = New System.Drawing.Size(26, 23)
        Me.BtNuevo.TabIndex = 75
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'Lbnom_3
        '
        Me.Lbnom_3.BackColor = System.Drawing.Color.LightGray
        Me.Lbnom_3.CL_ControlAsociado = Nothing
        Me.Lbnom_3.CL_ValorFijo = False
        Me.Lbnom_3.ClForm = Nothing
        Me.Lbnom_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_3.Location = New System.Drawing.Point(272, 75)
        Me.Lbnom_3.Name = "Lbnom_3"
        Me.Lbnom_3.Size = New System.Drawing.Size(401, 18)
        Me.Lbnom_3.TabIndex = 74
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
        Me.BtBusca_3.CL_ControlAsociado = Me.TxDato_3
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
        Me.BtBusca_3.Location = New System.Drawing.Point(231, 73)
        Me.BtBusca_3.Name = "BtBusca_3"
        Me.BtBusca_3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_3.TabIndex = 73
        Me.BtBusca_3.UseVisualStyleBackColor = True
        '
        'TxDato_3
        '
        Me.TxDato_3.Autonumerico = False
        Me.TxDato_3.Buscando = False
        Me.TxDato_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_3.ClForm = Nothing
        Me.TxDato_3.ClParam = Nothing
        Me.TxDato_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_3.GridLin = Nothing
        Me.TxDato_3.HaCambiado = False
        Me.TxDato_3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_3.lbbusca = Nothing
        Me.TxDato_3.Location = New System.Drawing.Point(114, 73)
        Me.TxDato_3.MiError = False
        Me.TxDato_3.Name = "TxDato_3"
        Me.TxDato_3.Orden = 0
        Me.TxDato_3.SaltoAlfinal = False
        Me.TxDato_3.Siguiente = 0
        Me.TxDato_3.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_3.TabIndex = 71
        Me.TxDato_3.TeclaRepetida = False
        Me.TxDato_3.TxDatoFinalSemana = Nothing
        Me.TxDato_3.TxDatoInicioSemana = Nothing
        Me.TxDato_3.UltimoValorValidado = Nothing
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(6, 76)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(58, 16)
        Me.Lb_3.TabIndex = 72
        Me.Lb_3.Text = "Código"
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(270, 42)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 69
        Me.BotonesAvance1.Udato = Nothing
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
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato_1
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
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(231, 43)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 70
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(152, 43)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_1.TabIndex = 65
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(6, 46)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(65, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Número"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lbnom_16)
        Me.Panel2.Controls.Add(Me.Lb_16)
        Me.Panel2.Controls.Add(Me.BtBusca_16)
        Me.Panel2.Controls.Add(Me.TxDato_16)
        Me.Panel2.Controls.Add(Me.Lbnom_15)
        Me.Panel2.Controls.Add(Me.TxDato_15)
        Me.Panel2.Controls.Add(Me.Lb_15)
        Me.Panel2.Controls.Add(Me.BtBusca_15)
        Me.Panel2.Controls.Add(Me.TxDato_11)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lb_11)
        Me.Panel2.Controls.Add(Me.Lb_13)
        Me.Panel2.Controls.Add(Me.TxDato_13)
        Me.Panel2.Controls.Add(Me.Lb_12)
        Me.Panel2.Controls.Add(Me.TxDato_12)
        Me.Panel2.Controls.Add(Me.Lbnom_10)
        Me.Panel2.Controls.Add(Me.TxDato_10)
        Me.Panel2.Controls.Add(Me.Lb_10)
        Me.Panel2.Controls.Add(Me.BtBusca_10)
        Me.Panel2.Controls.Add(Me.Lb_14)
        Me.Panel2.Controls.Add(Me.TxDato_14)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 308)
        Me.Panel2.TabIndex = 73
        '
        'Lbnom_16
        '
        Me.Lbnom_16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_16.CL_ControlAsociado = Nothing
        Me.Lbnom_16.CL_ValorFijo = False
        Me.Lbnom_16.ClForm = Nothing
        Me.Lbnom_16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_16.Location = New System.Drawing.Point(214, 69)
        Me.Lbnom_16.Name = "Lbnom_16"
        Me.Lbnom_16.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_16.TabIndex = 146
        '
        'Lb_16
        '
        Me.Lb_16.AutoSize = True
        Me.Lb_16.CL_ControlAsociado = Nothing
        Me.Lb_16.CL_ValorFijo = False
        Me.Lb_16.ClForm = Nothing
        Me.Lb_16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_16.ForeColor = System.Drawing.Color.Teal
        Me.Lb_16.Location = New System.Drawing.Point(6, 74)
        Me.Lb_16.Name = "Lb_16"
        Me.Lb_16.Size = New System.Drawing.Size(71, 16)
        Me.Lb_16.TabIndex = 145
        Me.Lb_16.Text = "Almacén"
        '
        'BtBusca_16
        '
        Me.BtBusca_16.CL_Ancho = 0
        Me.BtBusca_16.CL_BuscaAlb = False
        Me.BtBusca_16.CL_campocodigo = Nothing
        Me.BtBusca_16.CL_camponombre = Nothing
        Me.BtBusca_16.CL_CampoOrden = "Nombre"
        Me.BtBusca_16.CL_ch1000 = False
        Me.BtBusca_16.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_16.CL_ControlAsociado = Me.TxDato_16
        Me.BtBusca_16.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_16.CL_dfecha = Nothing
        Me.BtBusca_16.CL_Entidad = Nothing
        Me.BtBusca_16.CL_EsId = True
        Me.BtBusca_16.CL_Filtro = Nothing
        Me.BtBusca_16.cl_formu = Nothing
        Me.BtBusca_16.CL_hfecha = Nothing
        Me.BtBusca_16.cl_ListaW = Nothing
        Me.BtBusca_16.CL_xCentro = False
        Me.BtBusca_16.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_16.Location = New System.Drawing.Point(175, 69)
        Me.BtBusca_16.Name = "BtBusca_16"
        Me.BtBusca_16.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_16.TabIndex = 144
        Me.BtBusca_16.UseVisualStyleBackColor = True
        '
        'TxDato_16
        '
        Me.TxDato_16.Autonumerico = False
        Me.TxDato_16.Buscando = False
        Me.TxDato_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_16.ClForm = Nothing
        Me.TxDato_16.ClParam = Nothing
        Me.TxDato_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_16.GridLin = Nothing
        Me.TxDato_16.HaCambiado = False
        Me.TxDato_16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_16.lbbusca = Nothing
        Me.TxDato_16.Location = New System.Drawing.Point(114, 69)
        Me.TxDato_16.MiError = False
        Me.TxDato_16.Name = "TxDato_16"
        Me.TxDato_16.Orden = 0
        Me.TxDato_16.SaltoAlfinal = False
        Me.TxDato_16.Siguiente = 0
        Me.TxDato_16.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_16.TabIndex = 143
        Me.TxDato_16.TeclaRepetida = False
        Me.TxDato_16.TxDatoFinalSemana = Nothing
        Me.TxDato_16.TxDatoInicioSemana = Nothing
        Me.TxDato_16.UltimoValorValidado = Nothing
        '
        'Lbnom_15
        '
        Me.Lbnom_15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_15.CL_ControlAsociado = Nothing
        Me.Lbnom_15.CL_ValorFijo = False
        Me.Lbnom_15.ClForm = Nothing
        Me.Lbnom_15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_15.Location = New System.Drawing.Point(214, 37)
        Me.Lbnom_15.Name = "Lbnom_15"
        Me.Lbnom_15.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_15.TabIndex = 141
        '
        'TxDato_15
        '
        Me.TxDato_15.Autonumerico = False
        Me.TxDato_15.Buscando = False
        Me.TxDato_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_15.ClForm = Nothing
        Me.TxDato_15.ClParam = Nothing
        Me.TxDato_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_15.GridLin = Nothing
        Me.TxDato_15.HaCambiado = False
        Me.TxDato_15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_15.lbbusca = Nothing
        Me.TxDato_15.Location = New System.Drawing.Point(114, 38)
        Me.TxDato_15.MiError = False
        Me.TxDato_15.Name = "TxDato_15"
        Me.TxDato_15.Orden = 0
        Me.TxDato_15.SaltoAlfinal = False
        Me.TxDato_15.Siguiente = 0
        Me.TxDato_15.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_15.TabIndex = 138
        Me.TxDato_15.TeclaRepetida = False
        Me.TxDato_15.TxDatoFinalSemana = Nothing
        Me.TxDato_15.TxDatoInicioSemana = Nothing
        Me.TxDato_15.UltimoValorValidado = Nothing
        '
        'Lb_15
        '
        Me.Lb_15.AutoSize = True
        Me.Lb_15.CL_ControlAsociado = Nothing
        Me.Lb_15.CL_ValorFijo = False
        Me.Lb_15.ClForm = Nothing
        Me.Lb_15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_15.ForeColor = System.Drawing.Color.Teal
        Me.Lb_15.Location = New System.Drawing.Point(6, 40)
        Me.Lb_15.Name = "Lb_15"
        Me.Lb_15.Size = New System.Drawing.Size(52, 16)
        Me.Lb_15.TabIndex = 139
        Me.Lb_15.Text = "Marca"
        '
        'BtBusca_15
        '
        Me.BtBusca_15.CL_Ancho = 0
        Me.BtBusca_15.CL_BuscaAlb = False
        Me.BtBusca_15.CL_campocodigo = Nothing
        Me.BtBusca_15.CL_camponombre = Nothing
        Me.BtBusca_15.CL_CampoOrden = "Nombre"
        Me.BtBusca_15.CL_ch1000 = False
        Me.BtBusca_15.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_15.CL_ControlAsociado = Me.TxDato_15
        Me.BtBusca_15.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_15.CL_dfecha = Nothing
        Me.BtBusca_15.CL_Entidad = Nothing
        Me.BtBusca_15.CL_EsId = True
        Me.BtBusca_15.CL_Filtro = Nothing
        Me.BtBusca_15.cl_formu = Nothing
        Me.BtBusca_15.CL_hfecha = Nothing
        Me.BtBusca_15.cl_ListaW = Nothing
        Me.BtBusca_15.CL_xCentro = False
        Me.BtBusca_15.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_15.Location = New System.Drawing.Point(175, 38)
        Me.BtBusca_15.Name = "BtBusca_15"
        Me.BtBusca_15.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_15.TabIndex = 140
        Me.BtBusca_15.UseVisualStyleBackColor = True
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
        Me.TxDato_11.Location = New System.Drawing.Point(611, 8)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(74, 22)
        Me.TxDato_11.TabIndex = 137
        Me.TxDato_11.TeclaRepetida = False
        Me.TxDato_11.TxDatoFinalSemana = Nothing
        Me.TxDato_11.TxDatoInicioSemana = Nothing
        Me.TxDato_11.UltimoValorValidado = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(897, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(875, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lb_11
        '
        Me.Lb_11.AutoSize = True
        Me.Lb_11.CL_ControlAsociado = Nothing
        Me.Lb_11.CL_ValorFijo = True
        Me.Lb_11.ClForm = Nothing
        Me.Lb_11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_11.ForeColor = System.Drawing.Color.Teal
        Me.Lb_11.Location = New System.Drawing.Point(543, 10)
        Me.Lb_11.Name = "Lb_11"
        Me.Lb_11.Size = New System.Drawing.Size(51, 16)
        Me.Lb_11.TabIndex = 117
        Me.Lb_11.Text = "Retira"
        '
        'Lb_13
        '
        Me.Lb_13.AutoSize = True
        Me.Lb_13.CL_ControlAsociado = Nothing
        Me.Lb_13.CL_ValorFijo = False
        Me.Lb_13.ClForm = Nothing
        Me.Lb_13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_13.ForeColor = System.Drawing.Color.Teal
        Me.Lb_13.Location = New System.Drawing.Point(543, 41)
        Me.Lb_13.Name = "Lb_13"
        Me.Lb_13.Size = New System.Drawing.Size(65, 16)
        Me.Lb_13.TabIndex = 106
        Me.Lb_13.Text = "Entrega"
        '
        'TxDato_13
        '
        Me.TxDato_13.Autonumerico = False
        Me.TxDato_13.Buscando = False
        Me.TxDato_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_13.ClForm = Nothing
        Me.TxDato_13.ClParam = Nothing
        Me.TxDato_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_13.GridLin = Nothing
        Me.TxDato_13.HaCambiado = False
        Me.TxDato_13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_13.lbbusca = Nothing
        Me.TxDato_13.Location = New System.Drawing.Point(611, 39)
        Me.TxDato_13.MiError = False
        Me.TxDato_13.Name = "TxDato_13"
        Me.TxDato_13.Orden = 0
        Me.TxDato_13.SaltoAlfinal = False
        Me.TxDato_13.Siguiente = 0
        Me.TxDato_13.Size = New System.Drawing.Size(74, 22)
        Me.TxDato_13.TabIndex = 105
        Me.TxDato_13.TeclaRepetida = False
        Me.TxDato_13.TxDatoFinalSemana = Nothing
        Me.TxDato_13.TxDatoInicioSemana = Nothing
        Me.TxDato_13.UltimoValorValidado = Nothing
        '
        'Lb_12
        '
        Me.Lb_12.AutoSize = True
        Me.Lb_12.CL_ControlAsociado = Nothing
        Me.Lb_12.CL_ValorFijo = False
        Me.Lb_12.ClForm = Nothing
        Me.Lb_12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_12.ForeColor = System.Drawing.Color.Teal
        Me.Lb_12.Location = New System.Drawing.Point(698, 10)
        Me.Lb_12.Name = "Lb_12"
        Me.Lb_12.Size = New System.Drawing.Size(53, 16)
        Me.Lb_12.TabIndex = 102
        Me.Lb_12.Text = "Precio"
        '
        'TxDato_12
        '
        Me.TxDato_12.Autonumerico = False
        Me.TxDato_12.Buscando = False
        Me.TxDato_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_12.ClForm = Nothing
        Me.TxDato_12.ClParam = Nothing
        Me.TxDato_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_12.GridLin = Nothing
        Me.TxDato_12.HaCambiado = False
        Me.TxDato_12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_12.lbbusca = Nothing
        Me.TxDato_12.Location = New System.Drawing.Point(769, 8)
        Me.TxDato_12.MiError = False
        Me.TxDato_12.Name = "TxDato_12"
        Me.TxDato_12.Orden = 0
        Me.TxDato_12.SaltoAlfinal = False
        Me.TxDato_12.Siguiente = 0
        Me.TxDato_12.Size = New System.Drawing.Size(96, 22)
        Me.TxDato_12.TabIndex = 101
        Me.TxDato_12.TeclaRepetida = False
        Me.TxDato_12.TxDatoFinalSemana = Nothing
        Me.TxDato_12.TxDatoInicioSemana = Nothing
        Me.TxDato_12.UltimoValorValidado = Nothing
        '
        'Lbnom_10
        '
        Me.Lbnom_10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_10.CL_ControlAsociado = Nothing
        Me.Lbnom_10.CL_ValorFijo = False
        Me.Lbnom_10.ClForm = Nothing
        Me.Lbnom_10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_10.Location = New System.Drawing.Point(214, 8)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_10.TabIndex = 74
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
        Me.TxDato_10.Location = New System.Drawing.Point(114, 8)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_10.TabIndex = 71
        Me.TxDato_10.TeclaRepetida = False
        Me.TxDato_10.TxDatoFinalSemana = Nothing
        Me.TxDato_10.TxDatoInicioSemana = Nothing
        Me.TxDato_10.UltimoValorValidado = Nothing
        '
        'Lb_10
        '
        Me.Lb_10.AutoSize = True
        Me.Lb_10.CL_ControlAsociado = Nothing
        Me.Lb_10.CL_ValorFijo = False
        Me.Lb_10.ClForm = Nothing
        Me.Lb_10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_10.ForeColor = System.Drawing.Color.Teal
        Me.Lb_10.Location = New System.Drawing.Point(6, 10)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(61, 16)
        Me.Lb_10.TabIndex = 72
        Me.Lb_10.Text = "Envase"
        '
        'BtBusca_10
        '
        Me.BtBusca_10.CL_Ancho = 0
        Me.BtBusca_10.CL_BuscaAlb = False
        Me.BtBusca_10.CL_campocodigo = Nothing
        Me.BtBusca_10.CL_camponombre = Nothing
        Me.BtBusca_10.CL_CampoOrden = "Nombre"
        Me.BtBusca_10.CL_ch1000 = False
        Me.BtBusca_10.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_10.CL_ControlAsociado = Me.TxDato_10
        Me.BtBusca_10.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_10.CL_dfecha = Nothing
        Me.BtBusca_10.CL_Entidad = Nothing
        Me.BtBusca_10.CL_EsId = True
        Me.BtBusca_10.CL_Filtro = Nothing
        Me.BtBusca_10.cl_formu = Nothing
        Me.BtBusca_10.CL_hfecha = Nothing
        Me.BtBusca_10.cl_ListaW = Nothing
        Me.BtBusca_10.CL_xCentro = False
        Me.BtBusca_10.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_10.Location = New System.Drawing.Point(175, 8)
        Me.BtBusca_10.Name = "BtBusca_10"
        Me.BtBusca_10.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_10.TabIndex = 73
        Me.BtBusca_10.UseVisualStyleBackColor = True
        '
        'Lb_14
        '
        Me.Lb_14.AutoSize = True
        Me.Lb_14.CL_ControlAsociado = Nothing
        Me.Lb_14.CL_ValorFijo = False
        Me.Lb_14.ClForm = Nothing
        Me.Lb_14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_14.ForeColor = System.Drawing.Color.Teal
        Me.Lb_14.Location = New System.Drawing.Point(698, 45)
        Me.Lb_14.Name = "Lb_14"
        Me.Lb_14.Size = New System.Drawing.Size(53, 16)
        Me.Lb_14.TabIndex = 80
        Me.Lb_14.Text = "Precio"
        '
        'TxDato_14
        '
        Me.TxDato_14.Autonumerico = False
        Me.TxDato_14.Buscando = False
        Me.TxDato_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_14.ClForm = Nothing
        Me.TxDato_14.ClParam = Nothing
        Me.TxDato_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_14.GridLin = Nothing
        Me.TxDato_14.HaCambiado = False
        Me.TxDato_14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_14.lbbusca = Nothing
        Me.TxDato_14.Location = New System.Drawing.Point(769, 39)
        Me.TxDato_14.MiError = False
        Me.TxDato_14.Name = "TxDato_14"
        Me.TxDato_14.Orden = 0
        Me.TxDato_14.SaltoAlfinal = False
        Me.TxDato_14.Siguiente = 0
        Me.TxDato_14.Size = New System.Drawing.Size(96, 22)
        Me.TxDato_14.TabIndex = 79
        Me.TxDato_14.TeclaRepetida = False
        Me.TxDato_14.TxDatoFinalSemana = Nothing
        Me.TxDato_14.TxDatoInicioSemana = Nothing
        Me.TxDato_14.UltimoValorValidado = Nothing
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 113)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1040, 191)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmValeEnvase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 539)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ImprimirDespuesDeGuardar = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValeEnvase"
        Me.Text = "Vale de envases"
        Me.TextoPreguntaImpresion = "¿Desea imprimir el vale?"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lbnom_3 As NetAgro.Lb
    Friend WithEvents BtBusca_3 As NetAgro.BtBusca
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents BtBusca_10 As NetAgro.BtBusca
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents BtNuevo As NetAgro.ClButton
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents TxDato_14 As NetAgro.TxDato
    Friend WithEvents Lb_14 As NetAgro.Lb
    Friend WithEvents TxDato_13 As NetAgro.TxDato
    Friend WithEvents Lb_13 As NetAgro.Lb
    Friend WithEvents TxDato_12 As NetAgro.TxDato
    Friend WithEvents Lb_12 As NetAgro.Lb
    Friend WithEvents LbNom_4 As NetAgro.Lb
    Friend WithEvents Lb_11 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents BtBusca_4 As NetAgro.BtBusca
    Friend WithEvents TxDato_4 As NetAgro.TxDato
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxDato_6 As NetAgro.TxDato
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents BtBusca_5 As NetAgro.BtBusca
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents LbNomVale As NetAgro.Lb
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents Lb_7 As NetAgro.Lb
    Friend WithEvents TxDato_7 As NetAgro.TxDato
    Friend WithEvents TxDato_15 As NetAgro.TxDato
    Friend WithEvents Lb_15 As NetAgro.Lb
    Friend WithEvents BtBusca_15 As NetAgro.BtBusca
    Friend WithEvents Lbnom_16 As NetAgro.Lb
    Friend WithEvents Lb_16 As NetAgro.Lb
    Friend WithEvents BtBusca_16 As NetAgro.BtBusca
    Friend WithEvents TxDato_16 As NetAgro.TxDato
    Friend WithEvents Lbnom_15 As NetAgro.Lb
    Friend WithEvents LbNumFac As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents chkImprimirCMR As NetAgro.Chk
    Friend WithEvents TxMatricula As NetAgro.TxDato
    Friend WithEvents LbMatricula As NetAgro.Lb
    Friend WithEvents LbNomTransportista As NetAgro.Lb
    Friend WithEvents BtBuscaTransportista As NetAgro.BtBusca
    Friend WithEvents TxTransportista As NetAgro.TxDato
    Friend WithEvents LbTransportista As NetAgro.Lb
    Friend WithEvents TxTractora As NetAgro.TxDato
    Friend WithEvents LbTractora As NetAgro.Lb

End Class
