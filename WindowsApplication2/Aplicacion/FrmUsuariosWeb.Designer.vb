<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuariosWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuariosWeb))
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbNom_Codigo = New NetAgro.Lb(Me.components)
        Me.LbClave = New NetAgro.Lb(Me.components)
        Me.TxClave = New NetAgro.TxDato(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCodigo = New NetAgro.BtBusca(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.LbNom_Asociado = New NetAgro.Lb(Me.components)
        Me.TxAsociado = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAsociado = New NetAgro.BtBusca(Me.components)
        Me.LbAsociado = New NetAgro.Lb(Me.components)
        Me.LbEmailCalidad = New NetAgro.Lb(Me.components)
        Me.TxEmailCalidad = New NetAgro.TxDato(Me.components)
        Me.LbMail = New NetAgro.Lb(Me.components)
        Me.TxMail = New NetAgro.TxDato(Me.components)
        Me.LbNomCenvases = New NetAgro.Lb(Me.components)
        Me.BtBuscaCenvases = New NetAgro.BtBusca(Me.components)
        Me.TxCenvases = New NetAgro.TxDato(Me.components)
        Me.LbCenvases = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 241)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(699, 212)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'LbNom_Codigo
        '
        Me.LbNom_Codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNom_Codigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_Codigo.CL_ControlAsociado = Nothing
        Me.LbNom_Codigo.CL_ValorFijo = False
        Me.LbNom_Codigo.ClForm = Nothing
        Me.LbNom_Codigo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Codigo.Location = New System.Drawing.Point(205, 34)
        Me.LbNom_Codigo.Name = "LbNom_Codigo"
        Me.LbNom_Codigo.Size = New System.Drawing.Size(482, 23)
        Me.LbNom_Codigo.TabIndex = 100303
        Me.LbNom_Codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.CL_ControlAsociado = Nothing
        Me.LbClave.CL_ValorFijo = False
        Me.LbClave.ClForm = Nothing
        Me.LbClave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClave.ForeColor = System.Drawing.Color.Teal
        Me.LbClave.Location = New System.Drawing.Point(16, 67)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(49, 16)
        Me.LbClave.TabIndex = 100302
        Me.LbClave.Text = "Clave"
        '
        'TxClave
        '
        Me.TxClave.Autonumerico = False
        Me.TxClave.Buscando = False
        Me.TxClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClave.ClForm = Nothing
        Me.TxClave.ClParam = Nothing
        Me.TxClave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClave.GridLin = Nothing
        Me.TxClave.HaCambiado = False
        Me.TxClave.lbbusca = Nothing
        Me.TxClave.Location = New System.Drawing.Point(96, 64)
        Me.TxClave.MiError = False
        Me.TxClave.Name = "TxClave"
        Me.TxClave.Orden = 0
        Me.TxClave.SaltoAlfinal = False
        Me.TxClave.Siguiente = 0
        Me.TxClave.Size = New System.Drawing.Size(229, 22)
        Me.TxClave.TabIndex = 100301
        Me.TxClave.TeclaRepetida = False
        Me.TxClave.TxDatoFinalSemana = Nothing
        Me.TxClave.TxDatoInicioSemana = Nothing
        Me.TxClave.UltimoValorValidado = Nothing
        '
        'TxCodigo
        '
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(96, 36)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(63, 22)
        Me.TxCodigo.TabIndex = 100300
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.TxDatoFinalSemana = Nothing
        Me.TxCodigo.TxDatoInicioSemana = Nothing
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'BtBuscaCodigo
        '
        Me.BtBuscaCodigo.CL_Ancho = 0
        Me.BtBuscaCodigo.CL_BuscaAlb = False
        Me.BtBuscaCodigo.CL_campocodigo = Nothing
        Me.BtBuscaCodigo.CL_camponombre = Nothing
        Me.BtBuscaCodigo.CL_CampoOrden = "Nombre"
        Me.BtBuscaCodigo.CL_ch1000 = False
        Me.BtBuscaCodigo.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCodigo.CL_ControlAsociado = Nothing
        Me.BtBuscaCodigo.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCodigo.CL_dfecha = Nothing
        Me.BtBuscaCodigo.CL_Entidad = Nothing
        Me.BtBuscaCodigo.CL_EsId = True
        Me.BtBuscaCodigo.CL_Filtro = Nothing
        Me.BtBuscaCodigo.cl_formu = Nothing
        Me.BtBuscaCodigo.CL_hfecha = Nothing
        Me.BtBuscaCodigo.cl_ListaW = Nothing
        Me.BtBuscaCodigo.CL_xCentro = False
        Me.BtBuscaCodigo.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCodigo.Location = New System.Drawing.Point(165, 35)
        Me.BtBuscaCodigo.Name = "BtBuscaCodigo"
        Me.BtBuscaCodigo.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCodigo.TabIndex = 100299
        Me.BtBuscaCodigo.UseVisualStyleBackColor = True
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = False
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigo.Location = New System.Drawing.Point(16, 39)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(58, 16)
        Me.LbCodigo.TabIndex = 100298
        Me.LbCodigo.Text = "Código"
        '
        'LbNom_Asociado
        '
        Me.LbNom_Asociado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNom_Asociado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom_Asociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_Asociado.CL_ControlAsociado = Nothing
        Me.LbNom_Asociado.CL_ValorFijo = False
        Me.LbNom_Asociado.ClForm = Nothing
        Me.LbNom_Asociado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Asociado.Location = New System.Drawing.Point(205, 202)
        Me.LbNom_Asociado.Name = "LbNom_Asociado"
        Me.LbNom_Asociado.Size = New System.Drawing.Size(482, 23)
        Me.LbNom_Asociado.TabIndex = 100307
        Me.LbNom_Asociado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxAsociado
        '
        Me.TxAsociado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxAsociado.Autonumerico = False
        Me.TxAsociado.Buscando = False
        Me.TxAsociado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAsociado.ClForm = Nothing
        Me.TxAsociado.ClParam = Nothing
        Me.TxAsociado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAsociado.GridLin = Nothing
        Me.TxAsociado.HaCambiado = False
        Me.TxAsociado.lbbusca = Nothing
        Me.TxAsociado.Location = New System.Drawing.Point(96, 204)
        Me.TxAsociado.MiError = False
        Me.TxAsociado.Name = "TxAsociado"
        Me.TxAsociado.Orden = 0
        Me.TxAsociado.SaltoAlfinal = False
        Me.TxAsociado.Siguiente = 0
        Me.TxAsociado.Size = New System.Drawing.Size(63, 22)
        Me.TxAsociado.TabIndex = 100306
        Me.TxAsociado.TeclaRepetida = False
        Me.TxAsociado.TxDatoFinalSemana = Nothing
        Me.TxAsociado.TxDatoInicioSemana = Nothing
        Me.TxAsociado.UltimoValorValidado = Nothing
        '
        'BtBuscaAsociado
        '
        Me.BtBuscaAsociado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtBuscaAsociado.CL_Ancho = 0
        Me.BtBuscaAsociado.CL_BuscaAlb = False
        Me.BtBuscaAsociado.CL_campocodigo = Nothing
        Me.BtBuscaAsociado.CL_camponombre = Nothing
        Me.BtBuscaAsociado.CL_CampoOrden = "Nombre"
        Me.BtBuscaAsociado.CL_ch1000 = False
        Me.BtBuscaAsociado.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAsociado.CL_ControlAsociado = Nothing
        Me.BtBuscaAsociado.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAsociado.CL_dfecha = Nothing
        Me.BtBuscaAsociado.CL_Entidad = Nothing
        Me.BtBuscaAsociado.CL_EsId = True
        Me.BtBuscaAsociado.CL_Filtro = Nothing
        Me.BtBuscaAsociado.cl_formu = Nothing
        Me.BtBuscaAsociado.CL_hfecha = Nothing
        Me.BtBuscaAsociado.cl_ListaW = Nothing
        Me.BtBuscaAsociado.CL_xCentro = False
        Me.BtBuscaAsociado.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAsociado.Location = New System.Drawing.Point(165, 203)
        Me.BtBuscaAsociado.Name = "BtBuscaAsociado"
        Me.BtBuscaAsociado.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAsociado.TabIndex = 100305
        Me.BtBuscaAsociado.UseVisualStyleBackColor = True
        '
        'LbAsociado
        '
        Me.LbAsociado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbAsociado.AutoSize = True
        Me.LbAsociado.CL_ControlAsociado = Nothing
        Me.LbAsociado.CL_ValorFijo = False
        Me.LbAsociado.ClForm = Nothing
        Me.LbAsociado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsociado.ForeColor = System.Drawing.Color.Teal
        Me.LbAsociado.Location = New System.Drawing.Point(16, 207)
        Me.LbAsociado.Name = "LbAsociado"
        Me.LbAsociado.Size = New System.Drawing.Size(74, 16)
        Me.LbAsociado.TabIndex = 100304
        Me.LbAsociado.Text = "Asociado"
        '
        'LbEmailCalidad
        '
        Me.LbEmailCalidad.AutoSize = True
        Me.LbEmailCalidad.CL_ControlAsociado = Nothing
        Me.LbEmailCalidad.CL_ValorFijo = False
        Me.LbEmailCalidad.ClForm = Nothing
        Me.LbEmailCalidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmailCalidad.ForeColor = System.Drawing.Color.Teal
        Me.LbEmailCalidad.Location = New System.Drawing.Point(16, 96)
        Me.LbEmailCalidad.Name = "LbEmailCalidad"
        Me.LbEmailCalidad.Size = New System.Drawing.Size(106, 16)
        Me.LbEmailCalidad.TabIndex = 100309
        Me.LbEmailCalidad.Text = "Email Calidad"
        '
        'TxEmailCalidad
        '
        Me.TxEmailCalidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxEmailCalidad.Autonumerico = False
        Me.TxEmailCalidad.Buscando = False
        Me.TxEmailCalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmailCalidad.ClForm = Nothing
        Me.TxEmailCalidad.ClParam = Nothing
        Me.TxEmailCalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmailCalidad.GridLin = Nothing
        Me.TxEmailCalidad.HaCambiado = False
        Me.TxEmailCalidad.lbbusca = Nothing
        Me.TxEmailCalidad.Location = New System.Drawing.Point(128, 93)
        Me.TxEmailCalidad.MiError = False
        Me.TxEmailCalidad.Name = "TxEmailCalidad"
        Me.TxEmailCalidad.Orden = 0
        Me.TxEmailCalidad.SaltoAlfinal = False
        Me.TxEmailCalidad.Siguiente = 0
        Me.TxEmailCalidad.Size = New System.Drawing.Size(559, 22)
        Me.TxEmailCalidad.TabIndex = 100308
        Me.TxEmailCalidad.TeclaRepetida = False
        Me.TxEmailCalidad.TxDatoFinalSemana = Nothing
        Me.TxEmailCalidad.TxDatoInicioSemana = Nothing
        Me.TxEmailCalidad.UltimoValorValidado = Nothing
        '
        'LbMail
        '
        Me.LbMail.AutoSize = True
        Me.LbMail.CL_ControlAsociado = Nothing
        Me.LbMail.CL_ValorFijo = False
        Me.LbMail.ClForm = Nothing
        Me.LbMail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMail.ForeColor = System.Drawing.Color.Teal
        Me.LbMail.Location = New System.Drawing.Point(16, 124)
        Me.LbMail.Name = "LbMail"
        Me.LbMail.Size = New System.Drawing.Size(82, 16)
        Me.LbMail.TabIndex = 100311
        Me.LbMail.Text = "Email Agr."
        '
        'TxMail
        '
        Me.TxMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxMail.Autonumerico = False
        Me.TxMail.Buscando = False
        Me.TxMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMail.ClForm = Nothing
        Me.TxMail.ClParam = Nothing
        Me.TxMail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMail.GridLin = Nothing
        Me.TxMail.HaCambiado = False
        Me.TxMail.lbbusca = Nothing
        Me.TxMail.Location = New System.Drawing.Point(128, 121)
        Me.TxMail.MiError = False
        Me.TxMail.Name = "TxMail"
        Me.TxMail.Orden = 0
        Me.TxMail.SaltoAlfinal = False
        Me.TxMail.Siguiente = 0
        Me.TxMail.Size = New System.Drawing.Size(559, 22)
        Me.TxMail.TabIndex = 100310
        Me.TxMail.TeclaRepetida = False
        Me.TxMail.TxDatoFinalSemana = Nothing
        Me.TxMail.TxDatoInicioSemana = Nothing
        Me.TxMail.UltimoValorValidado = Nothing
        '
        'LbNomCenvases
        '
        Me.LbNomCenvases.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCenvases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCenvases.CL_ControlAsociado = Nothing
        Me.LbNomCenvases.CL_ValorFijo = False
        Me.LbNomCenvases.ClForm = Nothing
        Me.LbNomCenvases.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCenvases.Location = New System.Drawing.Point(237, 150)
        Me.LbNomCenvases.Name = "LbNomCenvases"
        Me.LbNomCenvases.Size = New System.Drawing.Size(328, 21)
        Me.LbNomCenvases.TabIndex = 100315
        Me.LbNomCenvases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtBuscaCenvases
        '
        Me.BtBuscaCenvases.CL_Ancho = 0
        Me.BtBuscaCenvases.CL_BuscaAlb = False
        Me.BtBuscaCenvases.CL_campocodigo = Nothing
        Me.BtBuscaCenvases.CL_camponombre = Nothing
        Me.BtBuscaCenvases.CL_CampoOrden = "Nombre"
        Me.BtBuscaCenvases.CL_ch1000 = False
        Me.BtBuscaCenvases.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCenvases.CL_ControlAsociado = Me.TxCenvases
        Me.BtBuscaCenvases.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCenvases.CL_dfecha = Nothing
        Me.BtBuscaCenvases.CL_Entidad = Nothing
        Me.BtBuscaCenvases.CL_EsId = True
        Me.BtBuscaCenvases.CL_Filtro = Nothing
        Me.BtBuscaCenvases.cl_formu = Nothing
        Me.BtBuscaCenvases.CL_hfecha = Nothing
        Me.BtBuscaCenvases.cl_ListaW = Nothing
        Me.BtBuscaCenvases.CL_xCentro = False
        Me.BtBuscaCenvases.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCenvases.Location = New System.Drawing.Point(198, 149)
        Me.BtBuscaCenvases.Name = "BtBuscaCenvases"
        Me.BtBuscaCenvases.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCenvases.TabIndex = 100314
        Me.BtBuscaCenvases.UseVisualStyleBackColor = True
        '
        'TxCenvases
        '
        Me.TxCenvases.Autonumerico = False
        Me.TxCenvases.Buscando = False
        Me.TxCenvases.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCenvases.ClForm = Nothing
        Me.TxCenvases.ClParam = Nothing
        Me.TxCenvases.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCenvases.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCenvases.GridLin = Nothing
        Me.TxCenvases.HaCambiado = False
        Me.TxCenvases.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCenvases.lbbusca = Nothing
        Me.TxCenvases.Location = New System.Drawing.Point(128, 149)
        Me.TxCenvases.MiError = False
        Me.TxCenvases.Name = "TxCenvases"
        Me.TxCenvases.Orden = 0
        Me.TxCenvases.SaltoAlfinal = False
        Me.TxCenvases.Siguiente = 0
        Me.TxCenvases.Size = New System.Drawing.Size(64, 22)
        Me.TxCenvases.TabIndex = 100313
        Me.TxCenvases.TeclaRepetida = False
        Me.TxCenvases.TxDatoFinalSemana = Nothing
        Me.TxCenvases.TxDatoInicioSemana = Nothing
        Me.TxCenvases.UltimoValorValidado = Nothing
        '
        'LbCenvases
        '
        Me.LbCenvases.AutoSize = True
        Me.LbCenvases.CL_ControlAsociado = Nothing
        Me.LbCenvases.CL_ValorFijo = False
        Me.LbCenvases.ClForm = Nothing
        Me.LbCenvases.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCenvases.ForeColor = System.Drawing.Color.Teal
        Me.LbCenvases.Location = New System.Drawing.Point(16, 152)
        Me.LbCenvases.Name = "LbCenvases"
        Me.LbCenvases.Size = New System.Drawing.Size(84, 16)
        Me.LbCenvases.TabIndex = 100312
        Me.LbCenvases.Text = "C.Envases"
        '
        'FrmUsuariosWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 487)
        Me.Controls.Add(Me.LbNomCenvases)
        Me.Controls.Add(Me.BtBuscaCenvases)
        Me.Controls.Add(Me.TxCenvases)
        Me.Controls.Add(Me.LbCenvases)
        Me.Controls.Add(Me.LbMail)
        Me.Controls.Add(Me.TxMail)
        Me.Controls.Add(Me.LbEmailCalidad)
        Me.Controls.Add(Me.TxEmailCalidad)
        Me.Controls.Add(Me.LbNom_Asociado)
        Me.Controls.Add(Me.TxAsociado)
        Me.Controls.Add(Me.BtBuscaAsociado)
        Me.Controls.Add(Me.LbAsociado)
        Me.Controls.Add(Me.LbNom_Codigo)
        Me.Controls.Add(Me.LbClave)
        Me.Controls.Add(Me.TxClave)
        Me.Controls.Add(Me.TxCodigo)
        Me.Controls.Add(Me.BtBuscaCodigo)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmUsuariosWeb"
        Me.Text = "Usuarios web"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.Controls.SetChildIndex(Me.LbCodigo, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCodigo, 0)
        Me.Controls.SetChildIndex(Me.TxCodigo, 0)
        Me.Controls.SetChildIndex(Me.TxClave, 0)
        Me.Controls.SetChildIndex(Me.LbClave, 0)
        Me.Controls.SetChildIndex(Me.LbNom_Codigo, 0)
        Me.Controls.SetChildIndex(Me.LbAsociado, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAsociado, 0)
        Me.Controls.SetChildIndex(Me.TxAsociado, 0)
        Me.Controls.SetChildIndex(Me.LbNom_Asociado, 0)
        Me.Controls.SetChildIndex(Me.TxEmailCalidad, 0)
        Me.Controls.SetChildIndex(Me.LbEmailCalidad, 0)
        Me.Controls.SetChildIndex(Me.TxMail, 0)
        Me.Controls.SetChildIndex(Me.LbMail, 0)
        Me.Controls.SetChildIndex(Me.LbCenvases, 0)
        Me.Controls.SetChildIndex(Me.TxCenvases, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCenvases, 0)
        Me.Controls.SetChildIndex(Me.LbNomCenvases, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbNom_Codigo As NetAgro.Lb
    Friend WithEvents LbClave As NetAgro.Lb
    Friend WithEvents TxClave As NetAgro.TxDato
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents BtBuscaCodigo As NetAgro.BtBusca
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents LbNom_Asociado As NetAgro.Lb
    Friend WithEvents TxAsociado As NetAgro.TxDato
    Friend WithEvents BtBuscaAsociado As NetAgro.BtBusca
    Friend WithEvents LbAsociado As NetAgro.Lb
    Friend WithEvents LbEmailCalidad As NetAgro.Lb
    Friend WithEvents TxEmailCalidad As NetAgro.TxDato
    Friend WithEvents LbMail As NetAgro.Lb
    Friend WithEvents TxMail As NetAgro.TxDato
    Friend WithEvents LbNomCenvases As NetAgro.Lb
    Friend WithEvents BtBuscaCenvases As NetAgro.BtBusca
    Friend WithEvents TxCenvases As NetAgro.TxDato
    Friend WithEvents LbCenvases As NetAgro.Lb
End Class
