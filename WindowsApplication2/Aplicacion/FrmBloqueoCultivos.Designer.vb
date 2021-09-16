<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqueoCultivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBloqueoCultivos))
        Me.BtBuscaBloqueos = New NetAgro.BtBusca(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.TxId = New NetAgro.TxDato(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbMotivo = New NetAgro.Lb(Me.components)
        Me.TxMotivo = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbDeFecha = New NetAgro.Lb(Me.components)
        Me.LbAHora = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.TxAHora = New NetAgro.TxDato(Me.components)
        Me.TxAFecha = New NetAgro.TxDato(Me.components)
        Me.LbDeHora = New NetAgro.Lb(Me.components)
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxDeHora = New NetAgro.TxDato(Me.components)
        Me.TxCultivo = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCultivo = New System.Windows.Forms.Button()
        Me.LbNomCultivo = New NetAgro.Lb(Me.components)
        Me.LbCultivo = New NetAgro.Lb(Me.components)
        Me.LbPrincipal = New NetAgro.Lb(Me.components)
        Me.LbNom_Principal = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbNom_Agricultor = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.LbHora = New NetAgro.Lb(Me.components)
        Me.TxHora = New NetAgro.TxDato(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BtBuscaBloqueos
        '
        Me.BtBuscaBloqueos.CL_Ancho = 0
        Me.BtBuscaBloqueos.CL_BuscaAlb = False
        Me.BtBuscaBloqueos.CL_campocodigo = Nothing
        Me.BtBuscaBloqueos.CL_camponombre = Nothing
        Me.BtBuscaBloqueos.CL_CampoOrden = "Nombre"
        Me.BtBuscaBloqueos.CL_ch1000 = False
        Me.BtBuscaBloqueos.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaBloqueos.CL_ControlAsociado = Nothing
        Me.BtBuscaBloqueos.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaBloqueos.CL_dfecha = Nothing
        Me.BtBuscaBloqueos.CL_Entidad = Nothing
        Me.BtBuscaBloqueos.CL_EsId = True
        Me.BtBuscaBloqueos.CL_Filtro = Nothing
        Me.BtBuscaBloqueos.cl_formu = Nothing
        Me.BtBuscaBloqueos.CL_hfecha = Nothing
        Me.BtBuscaBloqueos.cl_ListaW = Nothing
        Me.BtBuscaBloqueos.CL_xCentro = False
        Me.BtBuscaBloqueos.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaBloqueos.Location = New System.Drawing.Point(143, 17)
        Me.BtBuscaBloqueos.Name = "BtBuscaBloqueos"
        Me.BtBuscaBloqueos.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaBloqueos.TabIndex = 39
        Me.BtBuscaBloqueos.UseVisualStyleBackColor = True
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(327, 19)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(50, 16)
        Me.LbFecha.TabIndex = 38
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(391, 16)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxFecha.TabIndex = 37
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(182, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 35
        Me.BotonesAvance1.Udato = Nothing
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = False
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigo.Location = New System.Drawing.Point(10, 20)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(58, 16)
        Me.LbCodigo.TabIndex = 36
        Me.LbCodigo.Text = "Codigo"
        '
        'TxId
        '
        Me.TxId.Autonumerico = False
        Me.TxId.Buscando = False
        Me.TxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxId.ClForm = Nothing
        Me.TxId.ClParam = Nothing
        Me.TxId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxId.GridLin = Nothing
        Me.TxId.HaCambiado = False
        Me.TxId.lbbusca = Nothing
        Me.TxId.Location = New System.Drawing.Point(74, 17)
        Me.TxId.MiError = False
        Me.TxId.Name = "TxId"
        Me.TxId.Orden = 0
        Me.TxId.SaltoAlfinal = False
        Me.TxId.Siguiente = 0
        Me.TxId.Size = New System.Drawing.Size(63, 22)
        Me.TxId.TabIndex = 40
        Me.TxId.TeclaRepetida = False
        Me.TxId.TxDatoFinalSemana = Nothing
        Me.TxId.TxDatoInicioSemana = Nothing
        Me.TxId.UltimoValorValidado = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LbMotivo)
        Me.Panel2.Controls.Add(Me.TxMotivo)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.TxCultivo)
        Me.Panel2.Controls.Add(Me.BtBuscaCultivo)
        Me.Panel2.Controls.Add(Me.LbNomCultivo)
        Me.Panel2.Controls.Add(Me.LbCultivo)
        Me.Panel2.Controls.Add(Me.LbPrincipal)
        Me.Panel2.Controls.Add(Me.LbNom_Principal)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.LbNom_Agricultor)
        Me.Panel2.Controls.Add(Me.BtBuscaAgricultor)
        Me.Panel2.Controls.Add(Me.LbAgricultor)
        Me.Panel2.Controls.Add(Me.TxAgricultor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 275)
        Me.Panel2.TabIndex = 41
        '
        'LbMotivo
        '
        Me.LbMotivo.AutoSize = True
        Me.LbMotivo.CL_ControlAsociado = Nothing
        Me.LbMotivo.CL_ValorFijo = False
        Me.LbMotivo.ClForm = Nothing
        Me.LbMotivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivo.ForeColor = System.Drawing.Color.Teal
        Me.LbMotivo.Location = New System.Drawing.Point(10, 240)
        Me.LbMotivo.Name = "LbMotivo"
        Me.LbMotivo.Size = New System.Drawing.Size(57, 16)
        Me.LbMotivo.TabIndex = 186
        Me.LbMotivo.Text = "Motivo"
        '
        'TxMotivo
        '
        Me.TxMotivo.Autonumerico = False
        Me.TxMotivo.Buscando = False
        Me.TxMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMotivo.ClForm = Nothing
        Me.TxMotivo.ClParam = Nothing
        Me.TxMotivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMotivo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMotivo.GridLin = Nothing
        Me.TxMotivo.HaCambiado = False
        Me.TxMotivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxMotivo.lbbusca = Nothing
        Me.TxMotivo.Location = New System.Drawing.Point(98, 237)
        Me.TxMotivo.MiError = False
        Me.TxMotivo.Name = "TxMotivo"
        Me.TxMotivo.Orden = 0
        Me.TxMotivo.SaltoAlfinal = False
        Me.TxMotivo.Siguiente = 0
        Me.TxMotivo.Size = New System.Drawing.Size(571, 22)
        Me.TxMotivo.TabIndex = 185
        Me.TxMotivo.TeclaRepetida = False
        Me.TxMotivo.TxDatoFinalSemana = Nothing
        Me.TxMotivo.TxDatoInicioSemana = Nothing
        Me.TxMotivo.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbDeFecha)
        Me.GroupBox1.Controls.Add(Me.LbAHora)
        Me.GroupBox1.Controls.Add(Me.TxDeFecha)
        Me.GroupBox1.Controls.Add(Me.TxAHora)
        Me.GroupBox1.Controls.Add(Me.TxAFecha)
        Me.GroupBox1.Controls.Add(Me.LbDeHora)
        Me.GroupBox1.Controls.Add(Me.LbAFecha)
        Me.GroupBox1.Controls.Add(Me.TxDeHora)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 101)
        Me.GroupBox1.TabIndex = 184
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período bloqueo"
        '
        'LbDeFecha
        '
        Me.LbDeFecha.AutoSize = True
        Me.LbDeFecha.CL_ControlAsociado = Nothing
        Me.LbDeFecha.CL_ValorFijo = False
        Me.LbDeFecha.ClForm = Nothing
        Me.LbDeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDeFecha.Location = New System.Drawing.Point(18, 30)
        Me.LbDeFecha.Name = "LbDeFecha"
        Me.LbDeFecha.Size = New System.Drawing.Size(74, 16)
        Me.LbDeFecha.TabIndex = 177
        Me.LbDeFecha.Text = "De Fecha"
        '
        'LbAHora
        '
        Me.LbAHora.AutoSize = True
        Me.LbAHora.CL_ControlAsociado = Nothing
        Me.LbAHora.CL_ValorFijo = False
        Me.LbAHora.ClForm = Nothing
        Me.LbAHora.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAHora.ForeColor = System.Drawing.Color.Teal
        Me.LbAHora.Location = New System.Drawing.Point(230, 58)
        Me.LbAHora.Name = "LbAHora"
        Me.LbAHora.Size = New System.Drawing.Size(43, 16)
        Me.LbAHora.TabIndex = 183
        Me.LbAHora.Text = "Hora"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(106, 27)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxDeFecha.TabIndex = 176
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'TxAHora
        '
        Me.TxAHora.Autonumerico = False
        Me.TxAHora.Buscando = False
        Me.TxAHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAHora.ClForm = Nothing
        Me.TxAHora.ClParam = Nothing
        Me.TxAHora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAHora.GridLin = Nothing
        Me.TxAHora.HaCambiado = False
        Me.TxAHora.lbbusca = Nothing
        Me.TxAHora.Location = New System.Drawing.Point(279, 55)
        Me.TxAHora.MiError = False
        Me.TxAHora.Name = "TxAHora"
        Me.TxAHora.Orden = 0
        Me.TxAHora.SaltoAlfinal = False
        Me.TxAHora.Siguiente = 0
        Me.TxAHora.Size = New System.Drawing.Size(52, 22)
        Me.TxAHora.TabIndex = 182
        Me.TxAHora.TeclaRepetida = False
        Me.TxAHora.TxDatoFinalSemana = Nothing
        Me.TxAHora.TxDatoInicioSemana = Nothing
        Me.TxAHora.UltimoValorValidado = Nothing
        '
        'TxAFecha
        '
        Me.TxAFecha.Autonumerico = False
        Me.TxAFecha.Buscando = False
        Me.TxAFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAFecha.ClForm = Nothing
        Me.TxAFecha.ClParam = Nothing
        Me.TxAFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAFecha.GridLin = Nothing
        Me.TxAFecha.HaCambiado = False
        Me.TxAFecha.lbbusca = Nothing
        Me.TxAFecha.Location = New System.Drawing.Point(106, 56)
        Me.TxAFecha.MiError = False
        Me.TxAFecha.Name = "TxAFecha"
        Me.TxAFecha.Orden = 0
        Me.TxAFecha.SaltoAlfinal = False
        Me.TxAFecha.Siguiente = 0
        Me.TxAFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxAFecha.TabIndex = 178
        Me.TxAFecha.TeclaRepetida = False
        Me.TxAFecha.TxDatoFinalSemana = Nothing
        Me.TxAFecha.TxDatoInicioSemana = Nothing
        Me.TxAFecha.UltimoValorValidado = Nothing
        '
        'LbDeHora
        '
        Me.LbDeHora.AutoSize = True
        Me.LbDeHora.CL_ControlAsociado = Nothing
        Me.LbDeHora.CL_ValorFijo = False
        Me.LbDeHora.ClForm = Nothing
        Me.LbDeHora.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeHora.ForeColor = System.Drawing.Color.Teal
        Me.LbDeHora.Location = New System.Drawing.Point(230, 30)
        Me.LbDeHora.Name = "LbDeHora"
        Me.LbDeHora.Size = New System.Drawing.Size(43, 16)
        Me.LbDeHora.TabIndex = 181
        Me.LbDeHora.Text = "Hora"
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(18, 59)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(63, 16)
        Me.LbAFecha.TabIndex = 179
        Me.LbAFecha.Text = "A Fecha"
        '
        'TxDeHora
        '
        Me.TxDeHora.Autonumerico = False
        Me.TxDeHora.Buscando = False
        Me.TxDeHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeHora.ClForm = Nothing
        Me.TxDeHora.ClParam = Nothing
        Me.TxDeHora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeHora.GridLin = Nothing
        Me.TxDeHora.HaCambiado = False
        Me.TxDeHora.lbbusca = Nothing
        Me.TxDeHora.Location = New System.Drawing.Point(279, 27)
        Me.TxDeHora.MiError = False
        Me.TxDeHora.Name = "TxDeHora"
        Me.TxDeHora.Orden = 0
        Me.TxDeHora.SaltoAlfinal = False
        Me.TxDeHora.Siguiente = 0
        Me.TxDeHora.Size = New System.Drawing.Size(52, 22)
        Me.TxDeHora.TabIndex = 180
        Me.TxDeHora.TeclaRepetida = False
        Me.TxDeHora.TxDatoFinalSemana = Nothing
        Me.TxDeHora.TxDatoInicioSemana = Nothing
        Me.TxDeHora.UltimoValorValidado = Nothing
        '
        'TxCultivo
        '
        Me.TxCultivo.Autonumerico = False
        Me.TxCultivo.Buscando = False
        Me.TxCultivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCultivo.ClForm = Nothing
        Me.TxCultivo.ClParam = Nothing
        Me.TxCultivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCultivo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCultivo.GridLin = Nothing
        Me.TxCultivo.HaCambiado = False
        Me.TxCultivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCultivo.lbbusca = Nothing
        Me.TxCultivo.Location = New System.Drawing.Point(98, 79)
        Me.TxCultivo.MiError = False
        Me.TxCultivo.Name = "TxCultivo"
        Me.TxCultivo.Orden = 0
        Me.TxCultivo.SaltoAlfinal = False
        Me.TxCultivo.Siguiente = 0
        Me.TxCultivo.Size = New System.Drawing.Size(60, 22)
        Me.TxCultivo.TabIndex = 175
        Me.TxCultivo.TeclaRepetida = False
        Me.TxCultivo.TxDatoFinalSemana = Nothing
        Me.TxCultivo.TxDatoInicioSemana = Nothing
        Me.TxCultivo.UltimoValorValidado = Nothing
        '
        'BtBuscaCultivo
        '
        Me.BtBuscaCultivo.Image = CType(resources.GetObject("BtBuscaCultivo.Image"), System.Drawing.Image)
        Me.BtBuscaCultivo.Location = New System.Drawing.Point(164, 79)
        Me.BtBuscaCultivo.Name = "BtBuscaCultivo"
        Me.BtBuscaCultivo.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCultivo.TabIndex = 173
        Me.BtBuscaCultivo.UseVisualStyleBackColor = True
        '
        'LbNomCultivo
        '
        Me.LbNomCultivo.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCultivo.CL_ControlAsociado = Nothing
        Me.LbNomCultivo.CL_ValorFijo = False
        Me.LbNomCultivo.ClForm = Nothing
        Me.LbNomCultivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCultivo.Location = New System.Drawing.Point(199, 79)
        Me.LbNomCultivo.Name = "LbNomCultivo"
        Me.LbNomCultivo.Size = New System.Drawing.Size(470, 23)
        Me.LbNomCultivo.TabIndex = 172
        Me.LbNomCultivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCultivo
        '
        Me.LbCultivo.AutoSize = True
        Me.LbCultivo.CL_ControlAsociado = Nothing
        Me.LbCultivo.CL_ValorFijo = True
        Me.LbCultivo.ClForm = Nothing
        Me.LbCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCultivo.ForeColor = System.Drawing.Color.Teal
        Me.LbCultivo.Location = New System.Drawing.Point(10, 82)
        Me.LbCultivo.Name = "LbCultivo"
        Me.LbCultivo.Size = New System.Drawing.Size(59, 16)
        Me.LbCultivo.TabIndex = 171
        Me.LbCultivo.Text = "Cultivo"
        '
        'LbPrincipal
        '
        Me.LbPrincipal.BackColor = System.Drawing.Color.LightGray
        Me.LbPrincipal.CL_ControlAsociado = Nothing
        Me.LbPrincipal.CL_ValorFijo = False
        Me.LbPrincipal.ClForm = Nothing
        Me.LbPrincipal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrincipal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbPrincipal.Location = New System.Drawing.Point(128, 49)
        Me.LbPrincipal.Name = "LbPrincipal"
        Me.LbPrincipal.Size = New System.Drawing.Size(65, 23)
        Me.LbPrincipal.TabIndex = 81
        Me.LbPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbNom_Principal
        '
        Me.LbNom_Principal.BackColor = System.Drawing.Color.LightGray
        Me.LbNom_Principal.CL_ControlAsociado = Nothing
        Me.LbNom_Principal.CL_ValorFijo = False
        Me.LbNom_Principal.ClForm = Nothing
        Me.LbNom_Principal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Principal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Principal.Location = New System.Drawing.Point(199, 49)
        Me.LbNom_Principal.Name = "LbNom_Principal"
        Me.LbNom_Principal.Size = New System.Drawing.Size(470, 23)
        Me.LbNom_Principal.TabIndex = 80
        Me.LbNom_Principal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(10, 50)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(104, 16)
        Me.Lb2.TabIndex = 79
        Me.Lb2.Text = "Agr. Principal"
        '
        'LbNom_Agricultor
        '
        Me.LbNom_Agricultor.BackColor = System.Drawing.Color.LightGray
        Me.LbNom_Agricultor.CL_ControlAsociado = Nothing
        Me.LbNom_Agricultor.CL_ValorFijo = False
        Me.LbNom_Agricultor.ClForm = Nothing
        Me.LbNom_Agricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Agricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Agricultor.Location = New System.Drawing.Point(199, 19)
        Me.LbNom_Agricultor.Name = "LbNom_Agricultor"
        Me.LbNom_Agricultor.Size = New System.Drawing.Size(470, 23)
        Me.LbNom_Agricultor.TabIndex = 78
        Me.LbNom_Agricultor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtBuscaAgricultor
        '
        Me.BtBuscaAgricultor.CL_Ancho = 0
        Me.BtBuscaAgricultor.CL_BuscaAlb = False
        Me.BtBuscaAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaAgricultor.CL_camponombre = Nothing
        Me.BtBuscaAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultor.CL_ch1000 = False
        Me.BtBuscaAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultor.CL_ControlAsociado = Me.TxAgricultor
        Me.BtBuscaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaAgricultor.CL_EsId = True
        Me.BtBuscaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaAgricultor.cl_formu = Nothing
        Me.BtBuscaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaAgricultor.CL_xCentro = False
        Me.BtBuscaAgricultor.Image = CType(resources.GetObject("BtBuscaAgricultor.Image"), System.Drawing.Image)
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(164, 17)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 77
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
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
        Me.TxAgricultor.Location = New System.Drawing.Point(98, 17)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(60, 22)
        Me.TxAgricultor.TabIndex = 75
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
        Me.LbAgricultor.Location = New System.Drawing.Point(10, 20)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 76
        Me.LbAgricultor.Text = "Agricultor"
        '
        'LbHora
        '
        Me.LbHora.AutoSize = True
        Me.LbHora.CL_ControlAsociado = Nothing
        Me.LbHora.CL_ValorFijo = False
        Me.LbHora.ClForm = Nothing
        Me.LbHora.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.ForeColor = System.Drawing.Color.Teal
        Me.LbHora.Location = New System.Drawing.Point(521, 19)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.Size = New System.Drawing.Size(43, 16)
        Me.LbHora.TabIndex = 43
        Me.LbHora.Text = "Hora"
        '
        'TxHora
        '
        Me.TxHora.Autonumerico = False
        Me.TxHora.Buscando = False
        Me.TxHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHora.ClForm = Nothing
        Me.TxHora.ClParam = Nothing
        Me.TxHora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHora.GridLin = Nothing
        Me.TxHora.HaCambiado = False
        Me.TxHora.lbbusca = Nothing
        Me.TxHora.Location = New System.Drawing.Point(570, 16)
        Me.TxHora.MiError = False
        Me.TxHora.Name = "TxHora"
        Me.TxHora.Orden = 0
        Me.TxHora.SaltoAlfinal = False
        Me.TxHora.Siguiente = 0
        Me.TxHora.Size = New System.Drawing.Size(59, 22)
        Me.TxHora.TabIndex = 42
        Me.TxHora.TeclaRepetida = False
        Me.TxHora.TxDatoFinalSemana = Nothing
        Me.TxHora.TxDatoInicioSemana = Nothing
        Me.TxHora.UltimoValorValidado = Nothing
        '
        'FrmBloqueoCultivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 369)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.TxHora)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxId)
        Me.Controls.Add(Me.BtBuscaBloqueos)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TxFecha)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmBloqueoCultivos"
        Me.Text = "Partes de Bloqueo de Cultivos"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbCodigo, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxFecha, 0)
        Me.Controls.SetChildIndex(Me.LbFecha, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaBloqueos, 0)
        Me.Controls.SetChildIndex(Me.TxId, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.TxHora, 0)
        Me.Controls.SetChildIndex(Me.LbHora, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtBuscaBloqueos As NetAgro.BtBusca
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents TxId As NetAgro.TxDato
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbHora As NetAgro.Lb
    Friend WithEvents TxHora As NetAgro.TxDato
    Friend WithEvents LbNom_Agricultor As NetAgro.Lb
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents LbPrincipal As NetAgro.Lb
    Friend WithEvents LbNom_Principal As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxCultivo As NetAgro.TxDato
    Friend WithEvents BtBuscaCultivo As System.Windows.Forms.Button
    Friend WithEvents LbNomCultivo As NetAgro.Lb
    Friend WithEvents LbCultivo As NetAgro.Lb
    Friend WithEvents LbMotivo As NetAgro.Lb
    Friend WithEvents TxMotivo As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbDeFecha As NetAgro.Lb
    Friend WithEvents LbAHora As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents TxAHora As NetAgro.TxDato
    Friend WithEvents TxAFecha As NetAgro.TxDato
    Friend WithEvents LbDeHora As NetAgro.Lb
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxDeHora As NetAgro.TxDato
End Class
