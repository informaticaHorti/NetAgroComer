<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAportacionesExtraordinarias

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAportacionesExtraordinarias))
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.LbNumero = New NetAgro.Lb(Me.components)
        Me.TxNumero = New NetAgro.TxDato(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbNom_Agricultor = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaAportacion = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.LbAportacionFondo = New NetAgro.Lb(Me.components)
        Me.TxTotalAportacion = New NetAgro.TxDato(Me.components)
        Me.BtBuscaBanco = New NetAgro.BtBusca(Me.components)
        Me.LbNom_Banco = New NetAgro.Lb(Me.components)
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxAnnoFondo = New NetAgro.TxDato(Me.components)
        Me.LbAnnoFondo = New NetAgro.Lb(Me.components)
        Me.ChkNoContabilizar = New System.Windows.Forms.CheckBox()
        Me.TxConcepto = New NetAgro.TxDato(Me.components)
        Me.LbConcepto = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbImporteAportacionNoFondoMasIVA = New NetAgro.Lb(Me.components)
        Me.LbTotalAportacion = New NetAgro.Lb(Me.components)
        Me.TxAportacionFondo = New NetAgro.TxDato(Me.components)
        Me.LbAportacionNoFondoMasIVA = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbAsientoHortiHorto = New NetAgro.Lb(Me.components)
        Me.LbAsientoHortichuelas = New NetAgro.Lb(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(533, 24)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(100, 23)
        Me.TxFecha.TabIndex = 1
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(475, 27)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 6
        Me.LbFecha.Text = "Fecha"
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.CL_ControlAsociado = Nothing
        Me.LbNumero.CL_ValorFijo = False
        Me.LbNumero.ClForm = Nothing
        Me.LbNumero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbNumero.ForeColor = System.Drawing.Color.Teal
        Me.LbNumero.Location = New System.Drawing.Point(28, 27)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(65, 16)
        Me.LbNumero.TabIndex = 18
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
        Me.TxNumero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNumero.GridLin = Nothing
        Me.TxNumero.HaCambiado = False
        Me.TxNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNumero.lbbusca = Nothing
        Me.TxNumero.Location = New System.Drawing.Point(112, 24)
        Me.TxNumero.MiError = False
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Orden = 0
        Me.TxNumero.SaltoAlfinal = False
        Me.TxNumero.Siguiente = 0
        Me.TxNumero.Size = New System.Drawing.Size(63, 23)
        Me.TxNumero.TabIndex = 17
        Me.TxNumero.TeclaRepetida = False
        Me.TxNumero.TxDatoFinalSemana = Nothing
        Me.TxNumero.TxDatoInicioSemana = Nothing
        Me.TxNumero.UltimoValorValidado = Nothing
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(28, 70)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 21
        Me.LbAgricultor.Text = "Agricultor"
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(112, 67)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(63, 23)
        Me.TxAgricultor.TabIndex = 20
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
        '
        'LbNom_Agricultor
        '
        Me.LbNom_Agricultor.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNom_Agricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_Agricultor.CL_ControlAsociado = Nothing
        Me.LbNom_Agricultor.CL_ValorFijo = False
        Me.LbNom_Agricultor.ClForm = Nothing
        Me.LbNom_Agricultor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbNom_Agricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbNom_Agricultor.Location = New System.Drawing.Point(216, 67)
        Me.LbNom_Agricultor.Name = "LbNom_Agricultor"
        Me.LbNom_Agricultor.Size = New System.Drawing.Size(417, 23)
        Me.LbNom_Agricultor.TabIndex = 24
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
        Me.BtBuscaAgricultor.CL_ControlAsociado = Me.TxFecha
        Me.BtBuscaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaAgricultor.CL_EsId = True
        Me.BtBuscaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaAgricultor.cl_formu = Nothing
        Me.BtBuscaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaAgricultor.CL_xCentro = False
        Me.BtBuscaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(177, 67)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 25
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
        '
        'BtBuscaAportacion
        '
        Me.BtBuscaAportacion.CL_Ancho = 0
        Me.BtBuscaAportacion.CL_BuscaAlb = False
        Me.BtBuscaAportacion.CL_campocodigo = Nothing
        Me.BtBuscaAportacion.CL_camponombre = Nothing
        Me.BtBuscaAportacion.CL_CampoOrden = "NombreGenero"
        Me.BtBuscaAportacion.CL_ch1000 = False
        Me.BtBuscaAportacion.CL_ConsultaSql = "Select * from Generos"
        Me.BtBuscaAportacion.CL_ControlAsociado = Me.TxNumero
        Me.BtBuscaAportacion.CL_DevuelveCampo = "IdGenero"
        Me.BtBuscaAportacion.CL_dfecha = Nothing
        Me.BtBuscaAportacion.CL_Entidad = Nothing
        Me.BtBuscaAportacion.CL_EsId = True
        Me.BtBuscaAportacion.CL_Filtro = Nothing
        Me.BtBuscaAportacion.cl_formu = Nothing
        Me.BtBuscaAportacion.CL_hfecha = Nothing
        Me.BtBuscaAportacion.cl_ListaW = Nothing
        Me.BtBuscaAportacion.CL_xCentro = False
        Me.BtBuscaAportacion.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAportacion.Location = New System.Drawing.Point(177, 24)
        Me.BtBuscaAportacion.Name = "BtBuscaAportacion"
        Me.BtBuscaAportacion.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAportacion.TabIndex = 26
        Me.BtBuscaAportacion.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(216, 25)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(129, 23)
        Me.BotonesAvance1.TabIndex = 27
        Me.BotonesAvance1.Udato = Nothing
        '
        'LbAportacionFondo
        '
        Me.LbAportacionFondo.AutoSize = True
        Me.LbAportacionFondo.CL_ControlAsociado = Nothing
        Me.LbAportacionFondo.CL_ValorFijo = False
        Me.LbAportacionFondo.ClForm = Nothing
        Me.LbAportacionFondo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbAportacionFondo.ForeColor = System.Drawing.Color.Teal
        Me.LbAportacionFondo.Location = New System.Drawing.Point(16, 50)
        Me.LbAportacionFondo.Name = "LbAportacionFondo"
        Me.LbAportacionFondo.Size = New System.Drawing.Size(136, 16)
        Me.LbAportacionFondo.TabIndex = 29
        Me.LbAportacionFondo.Text = "Aportación Fondo"
        '
        'TxTotalAportacion
        '
        Me.TxTotalAportacion.Autonumerico = False
        Me.TxTotalAportacion.Buscando = False
        Me.TxTotalAportacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTotalAportacion.ClForm = Nothing
        Me.TxTotalAportacion.ClParam = Nothing
        Me.TxTotalAportacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTotalAportacion.GridLin = Nothing
        Me.TxTotalAportacion.HaCambiado = False
        Me.TxTotalAportacion.lbbusca = Nothing
        Me.TxTotalAportacion.Location = New System.Drawing.Point(229, 16)
        Me.TxTotalAportacion.MiError = False
        Me.TxTotalAportacion.Name = "TxTotalAportacion"
        Me.TxTotalAportacion.Orden = 0
        Me.TxTotalAportacion.SaltoAlfinal = False
        Me.TxTotalAportacion.Siguiente = 0
        Me.TxTotalAportacion.Size = New System.Drawing.Size(115, 23)
        Me.TxTotalAportacion.TabIndex = 28
        Me.TxTotalAportacion.TeclaRepetida = False
        Me.TxTotalAportacion.TxDatoFinalSemana = Nothing
        Me.TxTotalAportacion.TxDatoInicioSemana = Nothing
        Me.TxTotalAportacion.UltimoValorValidado = Nothing
        '
        'BtBuscaBanco
        '
        Me.BtBuscaBanco.CL_Ancho = 0
        Me.BtBuscaBanco.CL_BuscaAlb = False
        Me.BtBuscaBanco.CL_campocodigo = Nothing
        Me.BtBuscaBanco.CL_camponombre = Nothing
        Me.BtBuscaBanco.CL_CampoOrden = "Nombre"
        Me.BtBuscaBanco.CL_ch1000 = False
        Me.BtBuscaBanco.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaBanco.CL_ControlAsociado = Me.TxFecha
        Me.BtBuscaBanco.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaBanco.CL_dfecha = Nothing
        Me.BtBuscaBanco.CL_Entidad = Nothing
        Me.BtBuscaBanco.CL_EsId = True
        Me.BtBuscaBanco.CL_Filtro = Nothing
        Me.BtBuscaBanco.cl_formu = Nothing
        Me.BtBuscaBanco.CL_hfecha = Nothing
        Me.BtBuscaBanco.cl_ListaW = Nothing
        Me.BtBuscaBanco.CL_xCentro = False
        Me.BtBuscaBanco.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaBanco.Location = New System.Drawing.Point(149, 276)
        Me.BtBuscaBanco.Name = "BtBuscaBanco"
        Me.BtBuscaBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaBanco.TabIndex = 33
        Me.BtBuscaBanco.UseVisualStyleBackColor = True
        '
        'LbNom_Banco
        '
        Me.LbNom_Banco.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNom_Banco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom_Banco.CL_ControlAsociado = Nothing
        Me.LbNom_Banco.CL_ValorFijo = False
        Me.LbNom_Banco.ClForm = Nothing
        Me.LbNom_Banco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbNom_Banco.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbNom_Banco.Location = New System.Drawing.Point(186, 276)
        Me.LbNom_Banco.Name = "LbNom_Banco"
        Me.LbNom_Banco.Size = New System.Drawing.Size(447, 23)
        Me.LbNom_Banco.TabIndex = 32
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = False
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(28, 279)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(53, 16)
        Me.LbBanco.TabIndex = 31
        Me.LbBanco.Text = "Banco"
        '
        'TxBanco
        '
        Me.TxBanco.Autonumerico = False
        Me.TxBanco.Buscando = False
        Me.TxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBanco.ClForm = Nothing
        Me.TxBanco.ClParam = Nothing
        Me.TxBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxBanco.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(112, 276)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(35, 23)
        Me.TxBanco.TabIndex = 30
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxAnnoFondo)
        Me.GroupBox1.Controls.Add(Me.LbAnnoFondo)
        Me.GroupBox1.Controls.Add(Me.ChkNoContabilizar)
        Me.GroupBox1.Controls.Add(Me.TxConcepto)
        Me.GroupBox1.Controls.Add(Me.LbConcepto)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.LbNumero)
        Me.GroupBox1.Controls.Add(Me.BtBuscaBanco)
        Me.GroupBox1.Controls.Add(Me.TxNumero)
        Me.GroupBox1.Controls.Add(Me.LbNom_Banco)
        Me.GroupBox1.Controls.Add(Me.TxFecha)
        Me.GroupBox1.Controls.Add(Me.LbBanco)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.TxBanco)
        Me.GroupBox1.Controls.Add(Me.TxAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbNom_Agricultor)
        Me.GroupBox1.Controls.Add(Me.BotonesAvance1)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAgricultor)
        Me.GroupBox1.Controls.Add(Me.BtBuscaAportacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 355)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'TxAnnoFondo
        '
        Me.TxAnnoFondo.Autonumerico = False
        Me.TxAnnoFondo.Buscando = False
        Me.TxAnnoFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAnnoFondo.ClForm = Nothing
        Me.TxAnnoFondo.ClParam = Nothing
        Me.TxAnnoFondo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAnnoFondo.GridLin = Nothing
        Me.TxAnnoFondo.HaCambiado = False
        Me.TxAnnoFondo.lbbusca = Nothing
        Me.TxAnnoFondo.Location = New System.Drawing.Point(112, 99)
        Me.TxAnnoFondo.MiError = False
        Me.TxAnnoFondo.Name = "TxAnnoFondo"
        Me.TxAnnoFondo.Orden = 0
        Me.TxAnnoFondo.SaltoAlfinal = False
        Me.TxAnnoFondo.Siguiente = 0
        Me.TxAnnoFondo.Size = New System.Drawing.Size(63, 23)
        Me.TxAnnoFondo.TabIndex = 43
        Me.TxAnnoFondo.TeclaRepetida = False
        Me.TxAnnoFondo.TxDatoFinalSemana = Nothing
        Me.TxAnnoFondo.TxDatoInicioSemana = Nothing
        Me.TxAnnoFondo.UltimoValorValidado = Nothing
        '
        'LbAnnoFondo
        '
        Me.LbAnnoFondo.AutoSize = True
        Me.LbAnnoFondo.CL_ControlAsociado = Nothing
        Me.LbAnnoFondo.CL_ValorFijo = False
        Me.LbAnnoFondo.ClForm = Nothing
        Me.LbAnnoFondo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbAnnoFondo.ForeColor = System.Drawing.Color.Teal
        Me.LbAnnoFondo.Location = New System.Drawing.Point(28, 102)
        Me.LbAnnoFondo.Name = "LbAnnoFondo"
        Me.LbAnnoFondo.Size = New System.Drawing.Size(81, 16)
        Me.LbAnnoFondo.TabIndex = 44
        Me.LbAnnoFondo.Text = "Año fondo"
        '
        'ChkNoContabilizar
        '
        Me.ChkNoContabilizar.AutoSize = True
        Me.ChkNoContabilizar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ChkNoContabilizar.ForeColor = System.Drawing.Color.Teal
        Me.ChkNoContabilizar.Location = New System.Drawing.Point(488, 153)
        Me.ChkNoContabilizar.Name = "ChkNoContabilizar"
        Me.ChkNoContabilizar.Size = New System.Drawing.Size(135, 20)
        Me.ChkNoContabilizar.TabIndex = 42
        Me.ChkNoContabilizar.Text = "No contabilizar"
        Me.ChkNoContabilizar.UseVisualStyleBackColor = True
        '
        'TxConcepto
        '
        Me.TxConcepto.Autonumerico = False
        Me.TxConcepto.Buscando = False
        Me.TxConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxConcepto.ClForm = Nothing
        Me.TxConcepto.ClParam = Nothing
        Me.TxConcepto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxConcepto.GridLin = Nothing
        Me.TxConcepto.HaCambiado = False
        Me.TxConcepto.lbbusca = Nothing
        Me.TxConcepto.Location = New System.Drawing.Point(112, 310)
        Me.TxConcepto.MiError = False
        Me.TxConcepto.Name = "TxConcepto"
        Me.TxConcepto.Orden = 0
        Me.TxConcepto.SaltoAlfinal = False
        Me.TxConcepto.Siguiente = 0
        Me.TxConcepto.Size = New System.Drawing.Size(521, 23)
        Me.TxConcepto.TabIndex = 39
        Me.TxConcepto.TeclaRepetida = False
        Me.TxConcepto.TxDatoFinalSemana = Nothing
        Me.TxConcepto.TxDatoInicioSemana = Nothing
        Me.TxConcepto.UltimoValorValidado = Nothing
        '
        'LbConcepto
        '
        Me.LbConcepto.AutoSize = True
        Me.LbConcepto.CL_ControlAsociado = Nothing
        Me.LbConcepto.CL_ValorFijo = False
        Me.LbConcepto.ClForm = Nothing
        Me.LbConcepto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbConcepto.ForeColor = System.Drawing.Color.Teal
        Me.LbConcepto.Location = New System.Drawing.Point(28, 313)
        Me.LbConcepto.Name = "LbConcepto"
        Me.LbConcepto.Size = New System.Drawing.Size(77, 16)
        Me.LbConcepto.TabIndex = 40
        Me.LbConcepto.Text = "Concepto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LbAportacionFondo)
        Me.Panel2.Controls.Add(Me.LbImporteAportacionNoFondoMasIVA)
        Me.Panel2.Controls.Add(Me.TxTotalAportacion)
        Me.Panel2.Controls.Add(Me.LbTotalAportacion)
        Me.Panel2.Controls.Add(Me.TxAportacionFondo)
        Me.Panel2.Controls.Add(Me.LbAportacionNoFondoMasIVA)
        Me.Panel2.Location = New System.Drawing.Point(83, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 120)
        Me.Panel2.TabIndex = 38
        '
        'LbImporteAportacionNoFondoMasIVA
        '
        Me.LbImporteAportacionNoFondoMasIVA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbImporteAportacionNoFondoMasIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImporteAportacionNoFondoMasIVA.CL_ControlAsociado = Nothing
        Me.LbImporteAportacionNoFondoMasIVA.CL_ValorFijo = False
        Me.LbImporteAportacionNoFondoMasIVA.ClForm = Nothing
        Me.LbImporteAportacionNoFondoMasIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbImporteAportacionNoFondoMasIVA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporteAportacionNoFondoMasIVA.ForeColor = System.Drawing.Color.Blue
        Me.LbImporteAportacionNoFondoMasIVA.Location = New System.Drawing.Point(229, 78)
        Me.LbImporteAportacionNoFondoMasIVA.Name = "LbImporteAportacionNoFondoMasIVA"
        Me.LbImporteAportacionNoFondoMasIVA.Size = New System.Drawing.Size(115, 23)
        Me.LbImporteAportacionNoFondoMasIVA.TabIndex = 37
        Me.LbImporteAportacionNoFondoMasIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbTotalAportacion
        '
        Me.LbTotalAportacion.AutoSize = True
        Me.LbTotalAportacion.CL_ControlAsociado = Nothing
        Me.LbTotalAportacion.CL_ValorFijo = True
        Me.LbTotalAportacion.ClForm = Nothing
        Me.LbTotalAportacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbTotalAportacion.ForeColor = System.Drawing.Color.Teal
        Me.LbTotalAportacion.Location = New System.Drawing.Point(16, 19)
        Me.LbTotalAportacion.Name = "LbTotalAportacion"
        Me.LbTotalAportacion.Size = New System.Drawing.Size(126, 16)
        Me.LbTotalAportacion.TabIndex = 36
        Me.LbTotalAportacion.Text = "Total aportación"
        '
        'TxAportacionFondo
        '
        Me.TxAportacionFondo.Autonumerico = False
        Me.TxAportacionFondo.Buscando = False
        Me.TxAportacionFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAportacionFondo.ClForm = Nothing
        Me.TxAportacionFondo.ClParam = Nothing
        Me.TxAportacionFondo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAportacionFondo.GridLin = Nothing
        Me.TxAportacionFondo.HaCambiado = False
        Me.TxAportacionFondo.lbbusca = Nothing
        Me.TxAportacionFondo.Location = New System.Drawing.Point(229, 47)
        Me.TxAportacionFondo.MiError = False
        Me.TxAportacionFondo.Name = "TxAportacionFondo"
        Me.TxAportacionFondo.Orden = 0
        Me.TxAportacionFondo.SaltoAlfinal = False
        Me.TxAportacionFondo.Siguiente = 0
        Me.TxAportacionFondo.Size = New System.Drawing.Size(115, 23)
        Me.TxAportacionFondo.TabIndex = 34
        Me.TxAportacionFondo.TeclaRepetida = False
        Me.TxAportacionFondo.TxDatoFinalSemana = Nothing
        Me.TxAportacionFondo.TxDatoInicioSemana = Nothing
        Me.TxAportacionFondo.UltimoValorValidado = Nothing
        '
        'LbAportacionNoFondoMasIVA
        '
        Me.LbAportacionNoFondoMasIVA.AutoSize = True
        Me.LbAportacionNoFondoMasIVA.CL_ControlAsociado = Nothing
        Me.LbAportacionNoFondoMasIVA.CL_ValorFijo = True
        Me.LbAportacionNoFondoMasIVA.ClForm = Nothing
        Me.LbAportacionNoFondoMasIVA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LbAportacionNoFondoMasIVA.ForeColor = System.Drawing.Color.Teal
        Me.LbAportacionNoFondoMasIVA.Location = New System.Drawing.Point(16, 81)
        Me.LbAportacionNoFondoMasIVA.Name = "LbAportacionNoFondoMasIVA"
        Me.LbAportacionNoFondoMasIVA.Size = New System.Drawing.Size(206, 16)
        Me.LbAportacionNoFondoMasIVA.TabIndex = 35
        Me.LbAportacionNoFondoMasIVA.Text = "Aportación NO Fondo + IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LbAsientoHortiHorto)
        Me.GroupBox2.Controls.Add(Me.LbAsientoHortichuelas)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(746, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 77)
        Me.GroupBox2.TabIndex = 100310
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asientos"
        '
        'LbAsientoHortiHorto
        '
        Me.LbAsientoHortiHorto.BackColor = System.Drawing.Color.White
        Me.LbAsientoHortiHorto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAsientoHortiHorto.CL_ControlAsociado = Nothing
        Me.LbAsientoHortiHorto.CL_ValorFijo = False
        Me.LbAsientoHortiHorto.ClForm = Nothing
        Me.LbAsientoHortiHorto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsientoHortiHorto.ForeColor = System.Drawing.Color.Teal
        Me.LbAsientoHortiHorto.Location = New System.Drawing.Point(11, 46)
        Me.LbAsientoHortiHorto.Name = "LbAsientoHortiHorto"
        Me.LbAsientoHortiHorto.Size = New System.Drawing.Size(83, 21)
        Me.LbAsientoHortiHorto.TabIndex = 115
        Me.LbAsientoHortiHorto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbAsientoHortichuelas
        '
        Me.LbAsientoHortichuelas.BackColor = System.Drawing.Color.White
        Me.LbAsientoHortichuelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAsientoHortichuelas.CL_ControlAsociado = Nothing
        Me.LbAsientoHortichuelas.CL_ValorFijo = False
        Me.LbAsientoHortichuelas.ClForm = Nothing
        Me.LbAsientoHortichuelas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAsientoHortichuelas.ForeColor = System.Drawing.Color.Teal
        Me.LbAsientoHortichuelas.Location = New System.Drawing.Point(11, 17)
        Me.LbAsientoHortichuelas.Name = "LbAsientoHortichuelas"
        Me.LbAsientoHortichuelas.Size = New System.Drawing.Size(83, 21)
        Me.LbAsientoHortichuelas.TabIndex = 114
        Me.LbAsientoHortichuelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmAportacionesExtraordinarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(860, 432)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAportacionesExtraordinarias"
        Me.Text = "Aportaciones extraordinarias"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents LbNumero As NetAgro.Lb
    Friend WithEvents TxNumero As NetAgro.TxDato
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents LbNom_Agricultor As NetAgro.Lb
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents BtBuscaAportacion As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents LbAportacionFondo As NetAgro.Lb
    Friend WithEvents TxTotalAportacion As NetAgro.TxDato
    Friend WithEvents BtBuscaBanco As NetAgro.BtBusca
    Friend WithEvents LbNom_Banco As NetAgro.Lb
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAsientoHortiHorto As NetAgro.Lb
    Friend WithEvents LbAsientoHortichuelas As NetAgro.Lb
    Friend WithEvents LbImporteAportacionNoFondoMasIVA As NetAgro.Lb
    Friend WithEvents LbTotalAportacion As NetAgro.Lb
    Friend WithEvents LbAportacionNoFondoMasIVA As NetAgro.Lb
    Friend WithEvents TxAportacionFondo As NetAgro.TxDato
    Friend WithEvents TxConcepto As NetAgro.TxDato
    Friend WithEvents LbConcepto As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ChkNoContabilizar As System.Windows.Forms.CheckBox
    Friend WithEvents TxAnnoFondo As NetAgro.TxDato
    Friend WithEvents LbAnnoFondo As NetAgro.Lb

End Class
