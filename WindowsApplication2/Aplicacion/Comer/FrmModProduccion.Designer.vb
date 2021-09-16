<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModProduccion))
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.LbNumero = New NetAgro.Lb(Me.components)
        Me.TxNumero = New NetAgro.TxDato(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.BtBuscaProduc = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxAlmacen = New NetAgro.TxDato(Me.components)
        Me.LbAlmcen = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlm = New NetAgro.BtBusca(Me.components)
        Me.LbNomAlmacen = New NetAgro.Lb(Me.components)
        Me.LbNomLinea = New NetAgro.Lb(Me.components)
        Me.BtBuscaLinea = New NetAgro.BtBusca(Me.components)
        Me.TxLinea = New NetAgro.TxDato(Me.components)
        Me.LbLinea = New NetAgro.Lb(Me.components)
        Me.TxPLC = New NetAgro.TxDato(Me.components)
        Me.LbPartidaLote = New NetAgro.Lb(Me.components)
        Me.TxNuparlote = New NetAgro.TxDato(Me.components)
        Me.LbNuParlote = New NetAgro.Lb(Me.components)
        Me.LbNomPartida = New NetAgro.Lb(Me.components)
        Me.TxKilosLinea = New NetAgro.TxDato(Me.components)
        Me.LbKilosLinea = New NetAgro.Lb(Me.components)
        Me.TxKilosconsu = New NetAgro.TxDato(Me.components)
        Me.LbKilosConsu = New NetAgro.Lb(Me.components)
        Me.TxInicio = New NetAgro.TxDato(Me.components)
        Me.LbInicio = New NetAgro.Lb(Me.components)
        Me.TxFinal = New NetAgro.TxDato(Me.components)
        Me.LbFin = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaPartidaLote = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(26, 55)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 68
        Me.LbFecha.Text = "Fecha"
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.CL_ControlAsociado = Nothing
        Me.LbNumero.CL_ValorFijo = False
        Me.LbNumero.ClForm = Nothing
        Me.LbNumero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Teal
        Me.LbNumero.Location = New System.Drawing.Point(26, 26)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(65, 16)
        Me.LbNumero.TabIndex = 66
        Me.LbNumero.Text = "Número"
        '
        'TxNumero
        '
        Me.TxNumero.Autonumerico = False
        Me.TxNumero.Buscando = False
        Me.TxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumero.ClForm = Nothing
        Me.TxNumero.ClParam = Nothing
        Me.TxNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNumero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNumero.GridLin = Nothing
        Me.TxNumero.HaCambiado = False
        Me.TxNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNumero.lbbusca = Nothing
        Me.TxNumero.Location = New System.Drawing.Point(136, 23)
        Me.TxNumero.MiError = False
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Orden = 0
        Me.TxNumero.SaltoAlfinal = False
        Me.TxNumero.Siguiente = 0
        Me.TxNumero.Size = New System.Drawing.Size(118, 22)
        Me.TxNumero.TabIndex = 74
        Me.TxNumero.TeclaRepetida = False
        Me.TxNumero.TxDatoFinalSemana = Nothing
        Me.TxNumero.TxDatoInicioSemana = Nothing
        Me.TxNumero.UltimoValorValidado = Nothing
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
        Me.TxFecha.Location = New System.Drawing.Point(136, 52)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(101, 22)
        Me.TxFecha.TabIndex = 75
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'BtBuscaProduc
        '
        Me.BtBuscaProduc.CL_Ancho = 0
        Me.BtBuscaProduc.CL_BuscaAlb = False
        Me.BtBuscaProduc.CL_campocodigo = Nothing
        Me.BtBuscaProduc.CL_camponombre = Nothing
        Me.BtBuscaProduc.CL_CampoOrden = "Nombre"
        Me.BtBuscaProduc.CL_ch1000 = False
        Me.BtBuscaProduc.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaProduc.CL_ControlAsociado = Me.TxNumero
        Me.BtBuscaProduc.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaProduc.CL_dfecha = Nothing
        Me.BtBuscaProduc.CL_Entidad = Nothing
        Me.BtBuscaProduc.CL_EsId = True
        Me.BtBuscaProduc.CL_Filtro = Nothing
        Me.BtBuscaProduc.cl_formu = Nothing
        Me.BtBuscaProduc.CL_hfecha = Nothing
        Me.BtBuscaProduc.cl_ListaW = Nothing
        Me.BtBuscaProduc.CL_xCentro = False
        Me.BtBuscaProduc.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaProduc.Location = New System.Drawing.Point(260, 23)
        Me.BtBuscaProduc.Name = "BtBuscaProduc"
        Me.BtBuscaProduc.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaProduc.TabIndex = 76
        Me.BtBuscaProduc.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(299, 22)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxAlmacen
        '
        Me.TxAlmacen.Autonumerico = False
        Me.TxAlmacen.Buscando = False
        Me.TxAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlmacen.ClForm = Nothing
        Me.TxAlmacen.ClParam = Nothing
        Me.TxAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAlmacen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlmacen.GridLin = Nothing
        Me.TxAlmacen.HaCambiado = False
        Me.TxAlmacen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAlmacen.lbbusca = Nothing
        Me.TxAlmacen.Location = New System.Drawing.Point(136, 81)
        Me.TxAlmacen.MiError = False
        Me.TxAlmacen.Name = "TxAlmacen"
        Me.TxAlmacen.Orden = 0
        Me.TxAlmacen.SaltoAlfinal = False
        Me.TxAlmacen.Siguiente = 0
        Me.TxAlmacen.Size = New System.Drawing.Size(37, 22)
        Me.TxAlmacen.TabIndex = 79
        Me.TxAlmacen.TeclaRepetida = False
        Me.TxAlmacen.TxDatoFinalSemana = Nothing
        Me.TxAlmacen.TxDatoInicioSemana = Nothing
        Me.TxAlmacen.UltimoValorValidado = Nothing
        '
        'LbAlmcen
        '
        Me.LbAlmcen.AutoSize = True
        Me.LbAlmcen.CL_ControlAsociado = Nothing
        Me.LbAlmcen.CL_ValorFijo = False
        Me.LbAlmcen.ClForm = Nothing
        Me.LbAlmcen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlmcen.ForeColor = System.Drawing.Color.Teal
        Me.LbAlmcen.Location = New System.Drawing.Point(26, 84)
        Me.LbAlmcen.Name = "LbAlmcen"
        Me.LbAlmcen.Size = New System.Drawing.Size(71, 16)
        Me.LbAlmcen.TabIndex = 78
        Me.LbAlmcen.Text = "Almacen"
        '
        'BtBuscaAlm
        '
        Me.BtBuscaAlm.CL_Ancho = 0
        Me.BtBuscaAlm.CL_BuscaAlb = False
        Me.BtBuscaAlm.CL_campocodigo = Nothing
        Me.BtBuscaAlm.CL_camponombre = Nothing
        Me.BtBuscaAlm.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlm.CL_ch1000 = False
        Me.BtBuscaAlm.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlm.CL_ControlAsociado = Me.TxNumero
        Me.BtBuscaAlm.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlm.CL_dfecha = Nothing
        Me.BtBuscaAlm.CL_Entidad = Nothing
        Me.BtBuscaAlm.CL_EsId = True
        Me.BtBuscaAlm.CL_Filtro = Nothing
        Me.BtBuscaAlm.cl_formu = Nothing
        Me.BtBuscaAlm.CL_hfecha = Nothing
        Me.BtBuscaAlm.cl_ListaW = Nothing
        Me.BtBuscaAlm.CL_xCentro = False
        Me.BtBuscaAlm.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlm.Location = New System.Drawing.Point(179, 81)
        Me.BtBuscaAlm.Name = "BtBuscaAlm"
        Me.BtBuscaAlm.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlm.TabIndex = 80
        Me.BtBuscaAlm.UseVisualStyleBackColor = True
        '
        'LbNomAlmacen
        '
        Me.LbNomAlmacen.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAlmacen.CL_ControlAsociado = Nothing
        Me.LbNomAlmacen.CL_ValorFijo = False
        Me.LbNomAlmacen.ClForm = Nothing
        Me.LbNomAlmacen.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAlmacen.Location = New System.Drawing.Point(228, 81)
        Me.LbNomAlmacen.Name = "LbNomAlmacen"
        Me.LbNomAlmacen.Size = New System.Drawing.Size(232, 23)
        Me.LbNomAlmacen.TabIndex = 120
        '
        'LbNomLinea
        '
        Me.LbNomLinea.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomLinea.CL_ControlAsociado = Nothing
        Me.LbNomLinea.CL_ValorFijo = False
        Me.LbNomLinea.ClForm = Nothing
        Me.LbNomLinea.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomLinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomLinea.Location = New System.Drawing.Point(228, 110)
        Me.LbNomLinea.Name = "LbNomLinea"
        Me.LbNomLinea.Size = New System.Drawing.Size(232, 23)
        Me.LbNomLinea.TabIndex = 124
        '
        'BtBuscaLinea
        '
        Me.BtBuscaLinea.CL_Ancho = 0
        Me.BtBuscaLinea.CL_BuscaAlb = False
        Me.BtBuscaLinea.CL_campocodigo = Nothing
        Me.BtBuscaLinea.CL_camponombre = Nothing
        Me.BtBuscaLinea.CL_CampoOrden = "Nombre"
        Me.BtBuscaLinea.CL_ch1000 = False
        Me.BtBuscaLinea.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaLinea.CL_ControlAsociado = Me.TxNumero
        Me.BtBuscaLinea.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaLinea.CL_dfecha = Nothing
        Me.BtBuscaLinea.CL_Entidad = Nothing
        Me.BtBuscaLinea.CL_EsId = True
        Me.BtBuscaLinea.CL_Filtro = Nothing
        Me.BtBuscaLinea.cl_formu = Nothing
        Me.BtBuscaLinea.CL_hfecha = Nothing
        Me.BtBuscaLinea.cl_ListaW = Nothing
        Me.BtBuscaLinea.CL_xCentro = False
        Me.BtBuscaLinea.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaLinea.Location = New System.Drawing.Point(179, 110)
        Me.BtBuscaLinea.Name = "BtBuscaLinea"
        Me.BtBuscaLinea.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaLinea.TabIndex = 123
        Me.BtBuscaLinea.UseVisualStyleBackColor = True
        '
        'TxLinea
        '
        Me.TxLinea.Autonumerico = False
        Me.TxLinea.Buscando = False
        Me.TxLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxLinea.ClForm = Nothing
        Me.TxLinea.ClParam = Nothing
        Me.TxLinea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxLinea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxLinea.GridLin = Nothing
        Me.TxLinea.HaCambiado = False
        Me.TxLinea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxLinea.lbbusca = Nothing
        Me.TxLinea.Location = New System.Drawing.Point(136, 110)
        Me.TxLinea.MiError = False
        Me.TxLinea.Name = "TxLinea"
        Me.TxLinea.Orden = 0
        Me.TxLinea.SaltoAlfinal = False
        Me.TxLinea.Siguiente = 0
        Me.TxLinea.Size = New System.Drawing.Size(37, 22)
        Me.TxLinea.TabIndex = 122
        Me.TxLinea.TeclaRepetida = False
        Me.TxLinea.TxDatoFinalSemana = Nothing
        Me.TxLinea.TxDatoInicioSemana = Nothing
        Me.TxLinea.UltimoValorValidado = Nothing
        '
        'LbLinea
        '
        Me.LbLinea.AutoSize = True
        Me.LbLinea.CL_ControlAsociado = Nothing
        Me.LbLinea.CL_ValorFijo = False
        Me.LbLinea.ClForm = Nothing
        Me.LbLinea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLinea.ForeColor = System.Drawing.Color.Teal
        Me.LbLinea.Location = New System.Drawing.Point(26, 113)
        Me.LbLinea.Name = "LbLinea"
        Me.LbLinea.Size = New System.Drawing.Size(47, 16)
        Me.LbLinea.TabIndex = 121
        Me.LbLinea.Text = "Linea"
        '
        'TxPLC
        '
        Me.TxPLC.Autonumerico = False
        Me.TxPLC.Buscando = False
        Me.TxPLC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPLC.ClForm = Nothing
        Me.TxPLC.ClParam = Nothing
        Me.TxPLC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPLC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPLC.GridLin = Nothing
        Me.TxPLC.HaCambiado = False
        Me.TxPLC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPLC.lbbusca = Nothing
        Me.TxPLC.Location = New System.Drawing.Point(136, 139)
        Me.TxPLC.MiError = False
        Me.TxPLC.Name = "TxPLC"
        Me.TxPLC.Orden = 0
        Me.TxPLC.SaltoAlfinal = False
        Me.TxPLC.Siguiente = 0
        Me.TxPLC.Size = New System.Drawing.Size(37, 22)
        Me.TxPLC.TabIndex = 126
        Me.TxPLC.TeclaRepetida = False
        Me.TxPLC.TxDatoFinalSemana = Nothing
        Me.TxPLC.TxDatoInicioSemana = Nothing
        Me.TxPLC.UltimoValorValidado = Nothing
        '
        'LbPartidaLote
        '
        Me.LbPartidaLote.AutoSize = True
        Me.LbPartidaLote.CL_ControlAsociado = Nothing
        Me.LbPartidaLote.CL_ValorFijo = False
        Me.LbPartidaLote.ClForm = Nothing
        Me.LbPartidaLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPartidaLote.ForeColor = System.Drawing.Color.Teal
        Me.LbPartidaLote.Location = New System.Drawing.Point(26, 142)
        Me.LbPartidaLote.Name = "LbPartidaLote"
        Me.LbPartidaLote.Size = New System.Drawing.Size(69, 16)
        Me.LbPartidaLote.TabIndex = 125
        Me.LbPartidaLote.Text = "P / L / C"
        '
        'TxNuparlote
        '
        Me.TxNuparlote.Autonumerico = False
        Me.TxNuparlote.Buscando = False
        Me.TxNuparlote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNuparlote.ClForm = Nothing
        Me.TxNuparlote.ClParam = Nothing
        Me.TxNuparlote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNuparlote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNuparlote.GridLin = Nothing
        Me.TxNuparlote.HaCambiado = False
        Me.TxNuparlote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNuparlote.lbbusca = Nothing
        Me.TxNuparlote.Location = New System.Drawing.Point(136, 168)
        Me.TxNuparlote.MiError = False
        Me.TxNuparlote.Name = "TxNuparlote"
        Me.TxNuparlote.Orden = 0
        Me.TxNuparlote.SaltoAlfinal = False
        Me.TxNuparlote.Siguiente = 0
        Me.TxNuparlote.Size = New System.Drawing.Size(107, 22)
        Me.TxNuparlote.TabIndex = 128
        Me.TxNuparlote.TeclaRepetida = False
        Me.TxNuparlote.TxDatoFinalSemana = Nothing
        Me.TxNuparlote.TxDatoInicioSemana = Nothing
        Me.TxNuparlote.UltimoValorValidado = Nothing
        '
        'LbNuParlote
        '
        Me.LbNuParlote.AutoSize = True
        Me.LbNuParlote.CL_ControlAsociado = Nothing
        Me.LbNuParlote.CL_ValorFijo = False
        Me.LbNuParlote.ClForm = Nothing
        Me.LbNuParlote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuParlote.ForeColor = System.Drawing.Color.Teal
        Me.LbNuParlote.Location = New System.Drawing.Point(26, 171)
        Me.LbNuParlote.Name = "LbNuParlote"
        Me.LbNuParlote.Size = New System.Drawing.Size(65, 16)
        Me.LbNuParlote.TabIndex = 127
        Me.LbNuParlote.Text = "Numero"
        '
        'LbNomPartida
        '
        Me.LbNomPartida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomPartida.CL_ControlAsociado = Nothing
        Me.LbNomPartida.CL_ValorFijo = False
        Me.LbNomPartida.ClForm = Nothing
        Me.LbNomPartida.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomPartida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomPartida.Location = New System.Drawing.Point(296, 168)
        Me.LbNomPartida.Name = "LbNomPartida"
        Me.LbNomPartida.Size = New System.Drawing.Size(321, 23)
        Me.LbNomPartida.TabIndex = 130
        '
        'TxKilosLinea
        '
        Me.TxKilosLinea.Autonumerico = False
        Me.TxKilosLinea.Buscando = False
        Me.TxKilosLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilosLinea.ClForm = Nothing
        Me.TxKilosLinea.ClParam = Nothing
        Me.TxKilosLinea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilosLinea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilosLinea.GridLin = Nothing
        Me.TxKilosLinea.HaCambiado = False
        Me.TxKilosLinea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilosLinea.lbbusca = Nothing
        Me.TxKilosLinea.Location = New System.Drawing.Point(136, 197)
        Me.TxKilosLinea.MiError = False
        Me.TxKilosLinea.Name = "TxKilosLinea"
        Me.TxKilosLinea.Orden = 0
        Me.TxKilosLinea.SaltoAlfinal = False
        Me.TxKilosLinea.Siguiente = 0
        Me.TxKilosLinea.Size = New System.Drawing.Size(107, 22)
        Me.TxKilosLinea.TabIndex = 132
        Me.TxKilosLinea.TeclaRepetida = False
        Me.TxKilosLinea.TxDatoFinalSemana = Nothing
        Me.TxKilosLinea.TxDatoInicioSemana = Nothing
        Me.TxKilosLinea.UltimoValorValidado = Nothing
        '
        'LbKilosLinea
        '
        Me.LbKilosLinea.AutoSize = True
        Me.LbKilosLinea.CL_ControlAsociado = Nothing
        Me.LbKilosLinea.CL_ValorFijo = False
        Me.LbKilosLinea.ClForm = Nothing
        Me.LbKilosLinea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosLinea.ForeColor = System.Drawing.Color.Teal
        Me.LbKilosLinea.Location = New System.Drawing.Point(26, 200)
        Me.LbKilosLinea.Name = "LbKilosLinea"
        Me.LbKilosLinea.Size = New System.Drawing.Size(81, 16)
        Me.LbKilosLinea.TabIndex = 131
        Me.LbKilosLinea.Text = "Kilos linea"
        '
        'TxKilosconsu
        '
        Me.TxKilosconsu.Autonumerico = False
        Me.TxKilosconsu.Buscando = False
        Me.TxKilosconsu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilosconsu.ClForm = Nothing
        Me.TxKilosconsu.ClParam = Nothing
        Me.TxKilosconsu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilosconsu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilosconsu.GridLin = Nothing
        Me.TxKilosconsu.HaCambiado = False
        Me.TxKilosconsu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilosconsu.lbbusca = Nothing
        Me.TxKilosconsu.Location = New System.Drawing.Point(136, 226)
        Me.TxKilosconsu.MiError = False
        Me.TxKilosconsu.Name = "TxKilosconsu"
        Me.TxKilosconsu.Orden = 0
        Me.TxKilosconsu.SaltoAlfinal = False
        Me.TxKilosconsu.Siguiente = 0
        Me.TxKilosconsu.Size = New System.Drawing.Size(107, 22)
        Me.TxKilosconsu.TabIndex = 134
        Me.TxKilosconsu.TeclaRepetida = False
        Me.TxKilosconsu.TxDatoFinalSemana = Nothing
        Me.TxKilosconsu.TxDatoInicioSemana = Nothing
        Me.TxKilosconsu.UltimoValorValidado = Nothing
        '
        'LbKilosConsu
        '
        Me.LbKilosConsu.AutoSize = True
        Me.LbKilosConsu.CL_ControlAsociado = Nothing
        Me.LbKilosConsu.CL_ValorFijo = False
        Me.LbKilosConsu.ClForm = Nothing
        Me.LbKilosConsu.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilosConsu.ForeColor = System.Drawing.Color.Teal
        Me.LbKilosConsu.Location = New System.Drawing.Point(26, 229)
        Me.LbKilosConsu.Name = "LbKilosConsu"
        Me.LbKilosConsu.Size = New System.Drawing.Size(94, 16)
        Me.LbKilosConsu.TabIndex = 133
        Me.LbKilosConsu.Text = "Kilos consu."
        '
        'TxInicio
        '
        Me.TxInicio.Autonumerico = False
        Me.TxInicio.Buscando = False
        Me.TxInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxInicio.ClForm = Nothing
        Me.TxInicio.ClParam = Nothing
        Me.TxInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxInicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxInicio.GridLin = Nothing
        Me.TxInicio.HaCambiado = False
        Me.TxInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxInicio.lbbusca = Nothing
        Me.TxInicio.Location = New System.Drawing.Point(136, 255)
        Me.TxInicio.MiError = False
        Me.TxInicio.Name = "TxInicio"
        Me.TxInicio.Orden = 0
        Me.TxInicio.SaltoAlfinal = False
        Me.TxInicio.Siguiente = 0
        Me.TxInicio.Size = New System.Drawing.Size(107, 22)
        Me.TxInicio.TabIndex = 136
        Me.TxInicio.TeclaRepetida = False
        Me.TxInicio.TxDatoFinalSemana = Nothing
        Me.TxInicio.TxDatoInicioSemana = Nothing
        Me.TxInicio.UltimoValorValidado = Nothing
        '
        'LbInicio
        '
        Me.LbInicio.AutoSize = True
        Me.LbInicio.CL_ControlAsociado = Nothing
        Me.LbInicio.CL_ValorFijo = False
        Me.LbInicio.ClForm = Nothing
        Me.LbInicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInicio.ForeColor = System.Drawing.Color.Teal
        Me.LbInicio.Location = New System.Drawing.Point(26, 258)
        Me.LbInicio.Name = "LbInicio"
        Me.LbInicio.Size = New System.Drawing.Size(48, 16)
        Me.LbInicio.TabIndex = 135
        Me.LbInicio.Text = "Inicio"
        '
        'TxFinal
        '
        Me.TxFinal.Autonumerico = False
        Me.TxFinal.Buscando = False
        Me.TxFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFinal.ClForm = Nothing
        Me.TxFinal.ClParam = Nothing
        Me.TxFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFinal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFinal.GridLin = Nothing
        Me.TxFinal.HaCambiado = False
        Me.TxFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFinal.lbbusca = Nothing
        Me.TxFinal.Location = New System.Drawing.Point(136, 284)
        Me.TxFinal.MiError = False
        Me.TxFinal.Name = "TxFinal"
        Me.TxFinal.Orden = 0
        Me.TxFinal.SaltoAlfinal = False
        Me.TxFinal.Siguiente = 0
        Me.TxFinal.Size = New System.Drawing.Size(107, 22)
        Me.TxFinal.TabIndex = 138
        Me.TxFinal.TeclaRepetida = False
        Me.TxFinal.TxDatoFinalSemana = Nothing
        Me.TxFinal.TxDatoInicioSemana = Nothing
        Me.TxFinal.UltimoValorValidado = Nothing
        '
        'LbFin
        '
        Me.LbFin.AutoSize = True
        Me.LbFin.CL_ControlAsociado = Nothing
        Me.LbFin.CL_ValorFijo = False
        Me.LbFin.ClForm = Nothing
        Me.LbFin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFin.ForeColor = System.Drawing.Color.Teal
        Me.LbFin.Location = New System.Drawing.Point(26, 287)
        Me.LbFin.Name = "LbFin"
        Me.LbFin.Size = New System.Drawing.Size(30, 16)
        Me.LbFin.TabIndex = 137
        Me.LbFin.Text = "Fin"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.BtBuscaPartidaLote)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(718, 320)
        Me.Panel2.TabIndex = 140
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(181, 142)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(305, 16)
        Me.Lb1.TabIndex = 200
        Me.Lb1.Text = "( P = Partida, L = Lote, C = PreCalibrado)"
        '
        'BtBuscaPartidaLote
        '
        Me.BtBuscaPartidaLote.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.BtBuscaPartidaLote.Location = New System.Drawing.Point(249, 168)
        Me.BtBuscaPartidaLote.Name = "BtBuscaPartidaLote"
        Me.BtBuscaPartidaLote.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaPartidaLote.TabIndex = 199
        Me.BtBuscaPartidaLote.UseVisualStyleBackColor = True
        '
        'FrmModProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 354)
        Me.Controls.Add(Me.TxFinal)
        Me.Controls.Add(Me.LbFin)
        Me.Controls.Add(Me.TxInicio)
        Me.Controls.Add(Me.LbInicio)
        Me.Controls.Add(Me.TxKilosconsu)
        Me.Controls.Add(Me.LbKilosConsu)
        Me.Controls.Add(Me.TxKilosLinea)
        Me.Controls.Add(Me.LbKilosLinea)
        Me.Controls.Add(Me.LbNomPartida)
        Me.Controls.Add(Me.TxNuparlote)
        Me.Controls.Add(Me.LbNuParlote)
        Me.Controls.Add(Me.TxPLC)
        Me.Controls.Add(Me.LbPartidaLote)
        Me.Controls.Add(Me.LbNomLinea)
        Me.Controls.Add(Me.BtBuscaLinea)
        Me.Controls.Add(Me.TxLinea)
        Me.Controls.Add(Me.LbLinea)
        Me.Controls.Add(Me.LbNomAlmacen)
        Me.Controls.Add(Me.BtBuscaAlm)
        Me.Controls.Add(Me.TxAlmacen)
        Me.Controls.Add(Me.LbAlmcen)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaProduc)
        Me.Controls.Add(Me.TxFecha)
        Me.Controls.Add(Me.TxNumero)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.LbNumero)
        Me.Controls.Add(Me._PanelCargando)
        Me.Controls.Add(Me.Panel2)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmModProduccion"
        Me.Text = "Registros de produccion"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbNumero, 0)
        Me.Controls.SetChildIndex(Me.LbFecha, 0)
        Me.Controls.SetChildIndex(Me.TxNumero, 0)
        Me.Controls.SetChildIndex(Me.TxFecha, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaProduc, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.LbAlmcen, 0)
        Me.Controls.SetChildIndex(Me.TxAlmacen, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAlm, 0)
        Me.Controls.SetChildIndex(Me.LbNomAlmacen, 0)
        Me.Controls.SetChildIndex(Me.LbLinea, 0)
        Me.Controls.SetChildIndex(Me.TxLinea, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaLinea, 0)
        Me.Controls.SetChildIndex(Me.LbNomLinea, 0)
        Me.Controls.SetChildIndex(Me.LbPartidaLote, 0)
        Me.Controls.SetChildIndex(Me.TxPLC, 0)
        Me.Controls.SetChildIndex(Me.LbNuParlote, 0)
        Me.Controls.SetChildIndex(Me.TxNuparlote, 0)
        Me.Controls.SetChildIndex(Me.LbNomPartida, 0)
        Me.Controls.SetChildIndex(Me.LbKilosLinea, 0)
        Me.Controls.SetChildIndex(Me.TxKilosLinea, 0)
        Me.Controls.SetChildIndex(Me.LbKilosConsu, 0)
        Me.Controls.SetChildIndex(Me.TxKilosconsu, 0)
        Me.Controls.SetChildIndex(Me.LbInicio, 0)
        Me.Controls.SetChildIndex(Me.TxInicio, 0)
        Me.Controls.SetChildIndex(Me.LbFin, 0)
        Me.Controls.SetChildIndex(Me.TxFinal, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents LbNumero As NetAgro.Lb
    Friend WithEvents TxNumero As NetAgro.TxDato
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents BtBuscaProduc As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxAlmacen As NetAgro.TxDato
    Friend WithEvents LbAlmcen As NetAgro.Lb
    Friend WithEvents BtBuscaAlm As NetAgro.BtBusca
    Friend WithEvents LbNomAlmacen As NetAgro.Lb
    Friend WithEvents LbNomLinea As NetAgro.Lb
    Friend WithEvents BtBuscaLinea As NetAgro.BtBusca
    Friend WithEvents TxLinea As NetAgro.TxDato
    Friend WithEvents LbLinea As NetAgro.Lb
    Friend WithEvents TxPLC As NetAgro.TxDato
    Friend WithEvents LbPartidaLote As NetAgro.Lb
    Friend WithEvents TxNuparlote As NetAgro.TxDato
    Friend WithEvents LbNuParlote As NetAgro.Lb
    Friend WithEvents LbNomPartida As NetAgro.Lb
    Friend WithEvents TxKilosLinea As NetAgro.TxDato
    Friend WithEvents LbKilosLinea As NetAgro.Lb
    Friend WithEvents TxKilosconsu As NetAgro.TxDato
    Friend WithEvents LbKilosConsu As NetAgro.Lb
    Friend WithEvents TxInicio As NetAgro.TxDato
    Friend WithEvents LbInicio As NetAgro.Lb
    Friend WithEvents TxFinal As NetAgro.TxDato
    Friend WithEvents LbFin As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaPartidaLote As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
End Class
