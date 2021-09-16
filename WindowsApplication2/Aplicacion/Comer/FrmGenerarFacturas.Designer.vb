<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarFacturas))
        Me.LbDFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxaFecha = New NetAgro.TxDato(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbdAgricultor = New NetAgro.Lb(Me.components)
        Me.TxDAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaagr1 = New NetAgro.BtBusca(Me.components)
        Me.LbNomAgr2 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgr2 = New NetAgro.BtBusca(Me.components)
        Me.LbaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaSemana = New NetAgro.BtBusca(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChSc = New NetAgro.Chk(Me.components)
        Me.ChkComision = New NetAgro.Chk(Me.components)
        Me.LbNomEmpresa = New NetAgro.Lb(Me.components)
        Me.BtEmpresa = New NetAgro.BtBusca(Me.components)
        Me.Lbempresa = New NetAgro.Lb(Me.components)
        Me.TxEmpresa = New NetAgro.TxDato(Me.components)
        Me.LbCentroRecogida = New NetAgro.Lb(Me.components)
        Me.CbCentroRecogida = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.BtCentro = New NetAgro.BtBusca(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.TxCentro = New NetAgro.TxDato(Me.components)
        Me.LbEjeAlbaranes = New NetAgro.Lb(Me.components)
        Me.TxEjAlbaranes = New NetAgro.TxDato(Me.components)
        Me.LbFechaAsientoREA = New NetAgro.Lb(Me.components)
        Me.TxFechaAsientoREA = New NetAgro.TxDato(Me.components)
        Me.LbEjercicioREA = New NetAgro.Lb(Me.components)
        Me.TxEjercicioREA = New NetAgro.TxDato(Me.components)
        Me.LbAnoFondo = New NetAgro.Lb(Me.components)
        Me.TxAnnoFondo = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbAnoFondo)
        Me.PanelCabecera.Controls.Add(Me.TxAnnoFondo)
        Me.PanelCabecera.Controls.Add(Me.LbEjercicioREA)
        Me.PanelCabecera.Controls.Add(Me.TxEjercicioREA)
        Me.PanelCabecera.Controls.Add(Me.LbFechaAsientoREA)
        Me.PanelCabecera.Controls.Add(Me.TxFechaAsientoREA)
        Me.PanelCabecera.Controls.Add(Me.LbEjeAlbaranes)
        Me.PanelCabecera.Controls.Add(Me.TxEjAlbaranes)
        Me.PanelCabecera.Controls.Add(Me.LbNomCentro)
        Me.PanelCabecera.Controls.Add(Me.BtCentro)
        Me.PanelCabecera.Controls.Add(Me.LbCentro)
        Me.PanelCabecera.Controls.Add(Me.TxCentro)
        Me.PanelCabecera.Controls.Add(Me.LbFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFecha)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.LbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.CbCentroRecogida)
        Me.PanelCabecera.Controls.Add(Me.LbNomEmpresa)
        Me.PanelCabecera.Controls.Add(Me.BtEmpresa)
        Me.PanelCabecera.Controls.Add(Me.Lbempresa)
        Me.PanelCabecera.Controls.Add(Me.TxEmpresa)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaSemana)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgr2)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgr2)
        Me.PanelCabecera.Controls.Add(Me.LbaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbnomAgr1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaagr1)
        Me.PanelCabecera.Controls.Add(Me.LbdAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxDAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1119, 187)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 187)
        Me.PanelConsulta.Size = New System.Drawing.Size(1119, 320)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(819, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(894, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(969, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1044, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(744, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbDFecha
        '
        Me.LbDFecha.AutoSize = True
        Me.LbDFecha.CL_ControlAsociado = Nothing
        Me.LbDFecha.CL_ValorFijo = False
        Me.LbDFecha.ClForm = Nothing
        Me.LbDFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDFecha.Location = New System.Drawing.Point(230, 48)
        Me.LbDFecha.Name = "LbDFecha"
        Me.LbDFecha.Size = New System.Drawing.Size(123, 16)
        Me.LbDFecha.TabIndex = 116
        Me.LbDFecha.Text = "Desde fecha alb"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(357, 45)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFecha.TabIndex = 115
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(484, 48)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(121, 16)
        Me.LbAFecha.TabIndex = 100273
        Me.LbAFecha.Text = "Hasta fecha alb"
        '
        'TxaFecha
        '
        Me.TxaFecha.Autonumerico = False
        Me.TxaFecha.Buscando = False
        Me.TxaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxaFecha.ClForm = Nothing
        Me.TxaFecha.ClParam = Nothing
        Me.TxaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxaFecha.GridLin = Nothing
        Me.TxaFecha.HaCambiado = False
        Me.TxaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxaFecha.lbbusca = Nothing
        Me.TxaFecha.Location = New System.Drawing.Point(613, 45)
        Me.TxaFecha.MiError = False
        Me.TxaFecha.Name = "TxaFecha"
        Me.TxaFecha.Orden = 0
        Me.TxaFecha.SaltoAlfinal = False
        Me.TxaFecha.Siguiente = 0
        Me.TxaFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxaFecha.TabIndex = 100272
        Me.TxaFecha.TeclaRepetida = False
        Me.TxaFecha.TxDatoFinalSemana = Nothing
        Me.TxaFecha.TxDatoInicioSemana = Nothing
        Me.TxaFecha.UltimoValorValidado = Nothing
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(14, 48)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100275
        Me.LbSemana.Text = "Semana"
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
        Me.TxSemana.Location = New System.Drawing.Point(130, 46)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(43, 22)
        Me.TxSemana.TabIndex = 100274
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbdAgricultor
        '
        Me.LbdAgricultor.AutoSize = True
        Me.LbdAgricultor.CL_ControlAsociado = Nothing
        Me.LbdAgricultor.CL_ValorFijo = False
        Me.LbdAgricultor.ClForm = Nothing
        Me.LbdAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbdAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbdAgricultor.Location = New System.Drawing.Point(14, 77)
        Me.LbdAgricultor.Name = "LbdAgricultor"
        Me.LbdAgricultor.Size = New System.Drawing.Size(101, 16)
        Me.LbdAgricultor.TabIndex = 100277
        Me.LbdAgricultor.Text = "De agricultor"
        '
        'TxDAgricultor
        '
        Me.TxDAgricultor.Autonumerico = False
        Me.TxDAgricultor.Buscando = False
        Me.TxDAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDAgricultor.ClForm = Nothing
        Me.TxDAgricultor.ClParam = Nothing
        Me.TxDAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDAgricultor.GridLin = Nothing
        Me.TxDAgricultor.HaCambiado = False
        Me.TxDAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDAgricultor.lbbusca = Nothing
        Me.TxDAgricultor.Location = New System.Drawing.Point(130, 74)
        Me.TxDAgricultor.MiError = False
        Me.TxDAgricultor.Name = "TxDAgricultor"
        Me.TxDAgricultor.Orden = 0
        Me.TxDAgricultor.SaltoAlfinal = False
        Me.TxDAgricultor.Siguiente = 0
        Me.TxDAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxDAgricultor.TabIndex = 100276
        Me.TxDAgricultor.TeclaRepetida = False
        Me.TxDAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDAgricultor.UltimoValorValidado = Nothing
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.Color.LightGray
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(232, 76)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(401, 18)
        Me.LbnomAgr1.TabIndex = 100279
        '
        'BtBuscaagr1
        '
        Me.BtBuscaagr1.CL_Ancho = 0
        Me.BtBuscaagr1.CL_BuscaAlb = False
        Me.BtBuscaagr1.CL_campocodigo = Nothing
        Me.BtBuscaagr1.CL_camponombre = Nothing
        Me.BtBuscaagr1.CL_CampoOrden = "Nombre"
        Me.BtBuscaagr1.CL_ch1000 = False
        Me.BtBuscaagr1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaagr1.CL_ControlAsociado = Nothing
        Me.BtBuscaagr1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaagr1.CL_dfecha = Nothing
        Me.BtBuscaagr1.CL_Entidad = Nothing
        Me.BtBuscaagr1.CL_EsId = True
        Me.BtBuscaagr1.CL_Filtro = Nothing
        Me.BtBuscaagr1.cl_formu = Nothing
        Me.BtBuscaagr1.CL_hfecha = Nothing
        Me.BtBuscaagr1.cl_ListaW = Nothing
        Me.BtBuscaagr1.CL_xCentro = False
        Me.BtBuscaagr1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaagr1.Location = New System.Drawing.Point(191, 74)
        Me.BtBuscaagr1.Name = "BtBuscaagr1"
        Me.BtBuscaagr1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaagr1.TabIndex = 100278
        Me.BtBuscaagr1.UseVisualStyleBackColor = True
        '
        'LbNomAgr2
        '
        Me.LbNomAgr2.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgr2.CL_ControlAsociado = Nothing
        Me.LbNomAgr2.CL_ValorFijo = False
        Me.LbNomAgr2.ClForm = Nothing
        Me.LbNomAgr2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgr2.Location = New System.Drawing.Point(232, 102)
        Me.LbNomAgr2.Name = "LbNomAgr2"
        Me.LbNomAgr2.Size = New System.Drawing.Size(401, 18)
        Me.LbNomAgr2.TabIndex = 100283
        '
        'BtBuscaAgr2
        '
        Me.BtBuscaAgr2.CL_Ancho = 0
        Me.BtBuscaAgr2.CL_BuscaAlb = False
        Me.BtBuscaAgr2.CL_campocodigo = Nothing
        Me.BtBuscaAgr2.CL_camponombre = Nothing
        Me.BtBuscaAgr2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgr2.CL_ch1000 = False
        Me.BtBuscaAgr2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgr2.CL_ControlAsociado = Nothing
        Me.BtBuscaAgr2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgr2.CL_dfecha = Nothing
        Me.BtBuscaAgr2.CL_Entidad = Nothing
        Me.BtBuscaAgr2.CL_EsId = True
        Me.BtBuscaAgr2.CL_Filtro = Nothing
        Me.BtBuscaAgr2.cl_formu = Nothing
        Me.BtBuscaAgr2.CL_hfecha = Nothing
        Me.BtBuscaAgr2.cl_ListaW = Nothing
        Me.BtBuscaAgr2.CL_xCentro = False
        Me.BtBuscaAgr2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgr2.Location = New System.Drawing.Point(191, 100)
        Me.BtBuscaAgr2.Name = "BtBuscaAgr2"
        Me.BtBuscaAgr2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgr2.TabIndex = 100282
        Me.BtBuscaAgr2.UseVisualStyleBackColor = True
        '
        'LbaAgricultor
        '
        Me.LbaAgricultor.AutoSize = True
        Me.LbaAgricultor.CL_ControlAsociado = Nothing
        Me.LbaAgricultor.CL_ValorFijo = False
        Me.LbaAgricultor.ClForm = Nothing
        Me.LbaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbaAgricultor.Location = New System.Drawing.Point(14, 103)
        Me.LbaAgricultor.Name = "LbaAgricultor"
        Me.LbaAgricultor.Size = New System.Drawing.Size(92, 16)
        Me.LbaAgricultor.TabIndex = 100281
        Me.LbaAgricultor.Text = "A agricultor"
        '
        'TxAAgricultor
        '
        Me.TxAAgricultor.Autonumerico = False
        Me.TxAAgricultor.Buscando = False
        Me.TxAAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAAgricultor.ClForm = Nothing
        Me.TxAAgricultor.ClParam = Nothing
        Me.TxAAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAAgricultor.GridLin = Nothing
        Me.TxAAgricultor.HaCambiado = False
        Me.TxAAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAAgricultor.lbbusca = Nothing
        Me.TxAAgricultor.Location = New System.Drawing.Point(130, 100)
        Me.TxAAgricultor.MiError = False
        Me.TxAAgricultor.Name = "TxAAgricultor"
        Me.TxAAgricultor.Orden = 0
        Me.TxAAgricultor.SaltoAlfinal = False
        Me.TxAAgricultor.Siguiente = 0
        Me.TxAAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxAAgricultor.TabIndex = 100280
        Me.TxAAgricultor.TeclaRepetida = False
        Me.TxAAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaSemana
        '
        Me.BtBuscaSemana.CL_Ancho = 0
        Me.BtBuscaSemana.CL_BuscaAlb = False
        Me.BtBuscaSemana.CL_campocodigo = Nothing
        Me.BtBuscaSemana.CL_camponombre = Nothing
        Me.BtBuscaSemana.CL_CampoOrden = "Nombre"
        Me.BtBuscaSemana.CL_ch1000 = False
        Me.BtBuscaSemana.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaSemana.CL_ControlAsociado = Nothing
        Me.BtBuscaSemana.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaSemana.CL_dfecha = Nothing
        Me.BtBuscaSemana.CL_Entidad = Nothing
        Me.BtBuscaSemana.CL_EsId = True
        Me.BtBuscaSemana.CL_Filtro = Nothing
        Me.BtBuscaSemana.cl_formu = Nothing
        Me.BtBuscaSemana.CL_hfecha = Nothing
        Me.BtBuscaSemana.cl_ListaW = Nothing
        Me.BtBuscaSemana.CL_xCentro = False
        Me.BtBuscaSemana.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaSemana.Location = New System.Drawing.Point(191, 46)
        Me.BtBuscaSemana.Name = "BtBuscaSemana"
        Me.BtBuscaSemana.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaSemana.TabIndex = 100284
        Me.BtBuscaSemana.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(925, 6)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(183, 23)
        Me.Barra.TabIndex = 100285
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChSc)
        Me.GroupBox1.Controls.Add(Me.ChkComision)
        Me.GroupBox1.Location = New System.Drawing.Point(639, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 79)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Albaran"
        '
        'ChSc
        '
        Me.ChSc.AutoSize = True
        Me.ChSc.Campobd = Nothing
        Me.ChSc.ClForm = Nothing
        Me.ChSc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChSc.GridLin = Nothing
        Me.ChSc.HaCambiado = False
        Me.ChSc.Location = New System.Drawing.Point(6, 50)
        Me.ChSc.MiEntidad = Nothing
        Me.ChSc.MiError = False
        Me.ChSc.Name = "ChSc"
        Me.ChSc.Orden = 0
        Me.ChSc.SaltoAlfinal = False
        Me.ChSc.Size = New System.Drawing.Size(91, 20)
        Me.ChSc.TabIndex = 2
        Me.ChSc.Text = "Firme S/C"
        Me.ChSc.UseVisualStyleBackColor = True
        Me.ChSc.ValorCampoFalse = Nothing
        Me.ChSc.ValorCampoTrue = Nothing
        Me.ChSc.ValorDefecto = False
        '
        'ChkComision
        '
        Me.ChkComision.AutoSize = True
        Me.ChkComision.Campobd = Nothing
        Me.ChkComision.ClForm = Nothing
        Me.ChkComision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkComision.GridLin = Nothing
        Me.ChkComision.HaCambiado = False
        Me.ChkComision.Location = New System.Drawing.Point(6, 22)
        Me.ChkComision.MiEntidad = Nothing
        Me.ChkComision.MiError = False
        Me.ChkComision.Name = "ChkComision"
        Me.ChkComision.Orden = 0
        Me.ChkComision.SaltoAlfinal = False
        Me.ChkComision.Size = New System.Drawing.Size(84, 20)
        Me.ChkComision.TabIndex = 0
        Me.ChkComision.Text = "Comisión"
        Me.ChkComision.UseVisualStyleBackColor = True
        Me.ChkComision.ValorCampoFalse = Nothing
        Me.ChkComision.ValorCampoTrue = Nothing
        Me.ChkComision.ValorDefecto = False
        '
        'LbNomEmpresa
        '
        Me.LbNomEmpresa.BackColor = System.Drawing.Color.LightGray
        Me.LbNomEmpresa.CL_ControlAsociado = Nothing
        Me.LbNomEmpresa.CL_ValorFijo = False
        Me.LbNomEmpresa.ClForm = Nothing
        Me.LbNomEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomEmpresa.Location = New System.Drawing.Point(232, 128)
        Me.LbNomEmpresa.Name = "LbNomEmpresa"
        Me.LbNomEmpresa.Size = New System.Drawing.Size(401, 18)
        Me.LbNomEmpresa.TabIndex = 100289
        '
        'BtEmpresa
        '
        Me.BtEmpresa.CL_Ancho = 0
        Me.BtEmpresa.CL_BuscaAlb = False
        Me.BtEmpresa.CL_campocodigo = Nothing
        Me.BtEmpresa.CL_camponombre = Nothing
        Me.BtEmpresa.CL_CampoOrden = "Nombre"
        Me.BtEmpresa.CL_ch1000 = False
        Me.BtEmpresa.CL_ConsultaSql = "Select * from familias"
        Me.BtEmpresa.CL_ControlAsociado = Nothing
        Me.BtEmpresa.CL_DevuelveCampo = "Idfamilia"
        Me.BtEmpresa.CL_dfecha = Nothing
        Me.BtEmpresa.CL_Entidad = Nothing
        Me.BtEmpresa.CL_EsId = True
        Me.BtEmpresa.CL_Filtro = Nothing
        Me.BtEmpresa.cl_formu = Nothing
        Me.BtEmpresa.CL_hfecha = Nothing
        Me.BtEmpresa.cl_ListaW = Nothing
        Me.BtEmpresa.CL_xCentro = False
        Me.BtEmpresa.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtEmpresa.Location = New System.Drawing.Point(191, 126)
        Me.BtEmpresa.Name = "BtEmpresa"
        Me.BtEmpresa.Size = New System.Drawing.Size(33, 23)
        Me.BtEmpresa.TabIndex = 100288
        Me.BtEmpresa.UseVisualStyleBackColor = True
        '
        'Lbempresa
        '
        Me.Lbempresa.AutoSize = True
        Me.Lbempresa.CL_ControlAsociado = Nothing
        Me.Lbempresa.CL_ValorFijo = False
        Me.Lbempresa.ClForm = Nothing
        Me.Lbempresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbempresa.ForeColor = System.Drawing.Color.Teal
        Me.Lbempresa.Location = New System.Drawing.Point(14, 129)
        Me.Lbempresa.Name = "Lbempresa"
        Me.Lbempresa.Size = New System.Drawing.Size(72, 16)
        Me.Lbempresa.TabIndex = 100287
        Me.Lbempresa.Text = "Empresa"
        '
        'TxEmpresa
        '
        Me.TxEmpresa.Autonumerico = False
        Me.TxEmpresa.Buscando = False
        Me.TxEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmpresa.ClForm = Nothing
        Me.TxEmpresa.ClParam = Nothing
        Me.TxEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEmpresa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmpresa.GridLin = Nothing
        Me.TxEmpresa.HaCambiado = False
        Me.TxEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEmpresa.lbbusca = Nothing
        Me.TxEmpresa.Location = New System.Drawing.Point(130, 126)
        Me.TxEmpresa.MiError = False
        Me.TxEmpresa.Name = "TxEmpresa"
        Me.TxEmpresa.Orden = 0
        Me.TxEmpresa.SaltoAlfinal = False
        Me.TxEmpresa.Siguiente = 0
        Me.TxEmpresa.Size = New System.Drawing.Size(57, 22)
        Me.TxEmpresa.TabIndex = 100286
        Me.TxEmpresa.TeclaRepetida = False
        Me.TxEmpresa.TxDatoFinalSemana = Nothing
        Me.TxEmpresa.TxDatoInicioSemana = Nothing
        Me.TxEmpresa.UltimoValorValidado = Nothing
        '
        'LbCentroRecogida
        '
        Me.LbCentroRecogida.AutoSize = True
        Me.LbCentroRecogida.CL_ControlAsociado = Nothing
        Me.LbCentroRecogida.CL_ValorFijo = True
        Me.LbCentroRecogida.ClForm = Nothing
        Me.LbCentroRecogida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentroRecogida.ForeColor = System.Drawing.Color.Teal
        Me.LbCentroRecogida.Location = New System.Drawing.Point(14, 155)
        Me.LbCentroRecogida.Name = "LbCentroRecogida"
        Me.LbCentroRecogida.Size = New System.Drawing.Size(108, 16)
        Me.LbCentroRecogida.TabIndex = 100291
        Me.LbCentroRecogida.Text = "C.R.Agricultor"
        '
        'CbCentroRecogida
        '
        Me.CbCentroRecogida.EditValue = ""
        Me.CbCentroRecogida.Location = New System.Drawing.Point(130, 153)
        Me.CbCentroRecogida.Name = "CbCentroRecogida"
        Me.CbCentroRecogida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbCentroRecogida.Size = New System.Drawing.Size(240, 20)
        Me.CbCentroRecogida.TabIndex = 100290
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(746, 83)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(86, 16)
        Me.Lb1.TabIndex = 100293
        Me.Lb1.Text = "PRODUCTO"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(749, 101)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(240, 20)
        Me.CbFamilias.TabIndex = 100292
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(401, 155)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(120, 16)
        Me.LbFecha.TabIndex = 100295
        Me.LbFecha.Text = "Fecha Facturas"
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
        Me.TxFecha.Location = New System.Drawing.Point(527, 152)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxFecha.TabIndex = 100294
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = False
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentro.Location = New System.Drawing.Point(911, 128)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(197, 18)
        Me.LbNomCentro.TabIndex = 100299
        '
        'BtCentro
        '
        Me.BtCentro.CL_Ancho = 0
        Me.BtCentro.CL_BuscaAlb = False
        Me.BtCentro.CL_campocodigo = Nothing
        Me.BtCentro.CL_camponombre = Nothing
        Me.BtCentro.CL_CampoOrden = "Nombre"
        Me.BtCentro.CL_ch1000 = False
        Me.BtCentro.CL_ConsultaSql = "Select * from familias"
        Me.BtCentro.CL_ControlAsociado = Nothing
        Me.BtCentro.CL_DevuelveCampo = "Idfamilia"
        Me.BtCentro.CL_dfecha = Nothing
        Me.BtCentro.CL_Entidad = Nothing
        Me.BtCentro.CL_EsId = True
        Me.BtCentro.CL_Filtro = Nothing
        Me.BtCentro.cl_formu = Nothing
        Me.BtCentro.CL_hfecha = Nothing
        Me.BtCentro.cl_ListaW = Nothing
        Me.BtCentro.CL_xCentro = False
        Me.BtCentro.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtCentro.Location = New System.Drawing.Point(874, 126)
        Me.BtCentro.Name = "BtCentro"
        Me.BtCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtCentro.TabIndex = 100298
        Me.BtCentro.UseVisualStyleBackColor = True
        '
        'LbCentro
        '
        Me.LbCentro.AutoSize = True
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = False
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(747, 129)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(57, 16)
        Me.LbCentro.TabIndex = 100297
        Me.LbCentro.Text = "Centro"
        '
        'TxCentro
        '
        Me.TxCentro.Autonumerico = False
        Me.TxCentro.Buscando = False
        Me.TxCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCentro.ClForm = Nothing
        Me.TxCentro.ClParam = Nothing
        Me.TxCentro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCentro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCentro.GridLin = Nothing
        Me.TxCentro.HaCambiado = False
        Me.TxCentro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCentro.lbbusca = Nothing
        Me.TxCentro.Location = New System.Drawing.Point(811, 126)
        Me.TxCentro.MiError = False
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.Orden = 0
        Me.TxCentro.SaltoAlfinal = False
        Me.TxCentro.Siguiente = 0
        Me.TxCentro.Size = New System.Drawing.Size(57, 22)
        Me.TxCentro.TabIndex = 100296
        Me.TxCentro.TeclaRepetida = False
        Me.TxCentro.TxDatoFinalSemana = Nothing
        Me.TxCentro.TxDatoInicioSemana = Nothing
        Me.TxCentro.UltimoValorValidado = Nothing
        '
        'LbEjeAlbaranes
        '
        Me.LbEjeAlbaranes.AutoSize = True
        Me.LbEjeAlbaranes.CL_ControlAsociado = Nothing
        Me.LbEjeAlbaranes.CL_ValorFijo = False
        Me.LbEjeAlbaranes.ClForm = Nothing
        Me.LbEjeAlbaranes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjeAlbaranes.ForeColor = System.Drawing.Color.Teal
        Me.LbEjeAlbaranes.Location = New System.Drawing.Point(14, 21)
        Me.LbEjeAlbaranes.Name = "LbEjeAlbaranes"
        Me.LbEjeAlbaranes.Size = New System.Drawing.Size(104, 16)
        Me.LbEjeAlbaranes.TabIndex = 100301
        Me.LbEjeAlbaranes.Text = "Ej. Albaranes"
        '
        'TxEjAlbaranes
        '
        Me.TxEjAlbaranes.Autonumerico = False
        Me.TxEjAlbaranes.Buscando = False
        Me.TxEjAlbaranes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjAlbaranes.ClForm = Nothing
        Me.TxEjAlbaranes.ClParam = Nothing
        Me.TxEjAlbaranes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjAlbaranes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjAlbaranes.GridLin = Nothing
        Me.TxEjAlbaranes.HaCambiado = False
        Me.TxEjAlbaranes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjAlbaranes.lbbusca = Nothing
        Me.TxEjAlbaranes.Location = New System.Drawing.Point(130, 19)
        Me.TxEjAlbaranes.MiError = False
        Me.TxEjAlbaranes.Name = "TxEjAlbaranes"
        Me.TxEjAlbaranes.Orden = 0
        Me.TxEjAlbaranes.SaltoAlfinal = False
        Me.TxEjAlbaranes.Siguiente = 0
        Me.TxEjAlbaranes.Size = New System.Drawing.Size(43, 22)
        Me.TxEjAlbaranes.TabIndex = 100300
        Me.TxEjAlbaranes.TeclaRepetida = False
        Me.TxEjAlbaranes.TxDatoFinalSemana = Nothing
        Me.TxEjAlbaranes.TxDatoInicioSemana = Nothing
        Me.TxEjAlbaranes.UltimoValorValidado = Nothing
        '
        'LbFechaAsientoREA
        '
        Me.LbFechaAsientoREA.AutoSize = True
        Me.LbFechaAsientoREA.CL_ControlAsociado = Nothing
        Me.LbFechaAsientoREA.CL_ValorFijo = False
        Me.LbFechaAsientoREA.ClForm = Nothing
        Me.LbFechaAsientoREA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaAsientoREA.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaAsientoREA.Location = New System.Drawing.Point(662, 155)
        Me.LbFechaAsientoREA.Name = "LbFechaAsientoREA"
        Me.LbFechaAsientoREA.Size = New System.Drawing.Size(143, 16)
        Me.LbFechaAsientoREA.TabIndex = 100303
        Me.LbFechaAsientoREA.Text = "Fecha Asiento REA"
        '
        'TxFechaAsientoREA
        '
        Me.TxFechaAsientoREA.Autonumerico = False
        Me.TxFechaAsientoREA.Buscando = False
        Me.TxFechaAsientoREA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaAsientoREA.ClForm = Nothing
        Me.TxFechaAsientoREA.ClParam = Nothing
        Me.TxFechaAsientoREA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaAsientoREA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaAsientoREA.GridLin = Nothing
        Me.TxFechaAsientoREA.HaCambiado = False
        Me.TxFechaAsientoREA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaAsientoREA.lbbusca = Nothing
        Me.TxFechaAsientoREA.Location = New System.Drawing.Point(811, 152)
        Me.TxFechaAsientoREA.MiError = False
        Me.TxFechaAsientoREA.Name = "TxFechaAsientoREA"
        Me.TxFechaAsientoREA.Orden = 0
        Me.TxFechaAsientoREA.SaltoAlfinal = False
        Me.TxFechaAsientoREA.Siguiente = 0
        Me.TxFechaAsientoREA.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaAsientoREA.TabIndex = 100302
        Me.TxFechaAsientoREA.TeclaRepetida = False
        Me.TxFechaAsientoREA.TxDatoFinalSemana = Nothing
        Me.TxFechaAsientoREA.TxDatoInicioSemana = Nothing
        Me.TxFechaAsientoREA.UltimoValorValidado = Nothing
        '
        'LbEjercicioREA
        '
        Me.LbEjercicioREA.AutoSize = True
        Me.LbEjercicioREA.CL_ControlAsociado = Nothing
        Me.LbEjercicioREA.CL_ValorFijo = False
        Me.LbEjercicioREA.ClForm = Nothing
        Me.LbEjercicioREA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicioREA.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicioREA.Location = New System.Drawing.Point(942, 155)
        Me.LbEjercicioREA.Name = "LbEjercicioREA"
        Me.LbEjercicioREA.Size = New System.Drawing.Size(102, 16)
        Me.LbEjercicioREA.TabIndex = 100305
        Me.LbEjercicioREA.Text = "Ejercicio REA"
        '
        'TxEjercicioREA
        '
        Me.TxEjercicioREA.Autonumerico = False
        Me.TxEjercicioREA.Buscando = False
        Me.TxEjercicioREA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjercicioREA.ClForm = Nothing
        Me.TxEjercicioREA.ClParam = Nothing
        Me.TxEjercicioREA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjercicioREA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjercicioREA.GridLin = Nothing
        Me.TxEjercicioREA.HaCambiado = False
        Me.TxEjercicioREA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjercicioREA.lbbusca = Nothing
        Me.TxEjercicioREA.Location = New System.Drawing.Point(1050, 152)
        Me.TxEjercicioREA.MiError = False
        Me.TxEjercicioREA.Name = "TxEjercicioREA"
        Me.TxEjercicioREA.Orden = 0
        Me.TxEjercicioREA.SaltoAlfinal = False
        Me.TxEjercicioREA.Siguiente = 0
        Me.TxEjercicioREA.Size = New System.Drawing.Size(54, 22)
        Me.TxEjercicioREA.TabIndex = 100304
        Me.TxEjercicioREA.TeclaRepetida = False
        Me.TxEjercicioREA.TxDatoFinalSemana = Nothing
        Me.TxEjercicioREA.TxDatoInicioSemana = Nothing
        Me.TxEjercicioREA.UltimoValorValidado = Nothing
        '
        'LbAnoFondo
        '
        Me.LbAnoFondo.AutoSize = True
        Me.LbAnoFondo.CL_ControlAsociado = Nothing
        Me.LbAnoFondo.CL_ValorFijo = False
        Me.LbAnoFondo.ClForm = Nothing
        Me.LbAnoFondo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAnoFondo.ForeColor = System.Drawing.Color.Teal
        Me.LbAnoFondo.Location = New System.Drawing.Point(747, 48)
        Me.LbAnoFondo.Name = "LbAnoFondo"
        Me.LbAnoFondo.Size = New System.Drawing.Size(85, 16)
        Me.LbAnoFondo.TabIndex = 100307
        Me.LbAnoFondo.Text = "Año Fondo"
        '
        'TxAnnoFondo
        '
        Me.TxAnnoFondo.Autonumerico = False
        Me.TxAnnoFondo.Buscando = False
        Me.TxAnnoFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAnnoFondo.ClForm = Nothing
        Me.TxAnnoFondo.ClParam = Nothing
        Me.TxAnnoFondo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAnnoFondo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAnnoFondo.GridLin = Nothing
        Me.TxAnnoFondo.HaCambiado = False
        Me.TxAnnoFondo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAnnoFondo.lbbusca = Nothing
        Me.TxAnnoFondo.Location = New System.Drawing.Point(838, 45)
        Me.TxAnnoFondo.MiError = False
        Me.TxAnnoFondo.Name = "TxAnnoFondo"
        Me.TxAnnoFondo.Orden = 0
        Me.TxAnnoFondo.SaltoAlfinal = False
        Me.TxAnnoFondo.Siguiente = 0
        Me.TxAnnoFondo.Size = New System.Drawing.Size(46, 22)
        Me.TxAnnoFondo.TabIndex = 100306
        Me.TxAnnoFondo.TeclaRepetida = False
        Me.TxAnnoFondo.TxDatoFinalSemana = Nothing
        Me.TxAnnoFondo.TxDatoInicioSemana = Nothing
        Me.TxAnnoFondo.UltimoValorValidado = Nothing
        '
        'FrmGenerarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 541)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGenerarFacturas"
        Me.Text = "Generar Facturas"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbCentroRecogida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbDFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxaFecha As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbdAgricultor As NetAgro.Lb
    Friend WithEvents TxDAgricultor As NetAgro.TxDato
    Friend WithEvents LbNomAgr2 As NetAgro.Lb
    Friend WithEvents BtBuscaAgr2 As NetAgro.BtBusca
    Friend WithEvents LbaAgricultor As NetAgro.Lb
    Friend WithEvents TxAAgricultor As NetAgro.TxDato
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents BtBuscaagr1 As NetAgro.BtBusca
    Friend WithEvents BtBuscaSemana As NetAgro.BtBusca
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents LbNomEmpresa As NetAgro.Lb
    Friend WithEvents BtEmpresa As NetAgro.BtBusca
    Friend WithEvents Lbempresa As NetAgro.Lb
    Friend WithEvents TxEmpresa As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCentroRecogida As NetAgro.Lb
    Friend WithEvents CbCentroRecogida As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChSc As NetAgro.Chk
    Friend WithEvents ChkComision As NetAgro.Chk
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents BtCentro As NetAgro.BtBusca
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents TxCentro As NetAgro.TxDato
    Friend WithEvents LbEjeAlbaranes As NetAgro.Lb
    Friend WithEvents TxEjAlbaranes As NetAgro.TxDato
    Friend WithEvents LbEjercicioREA As NetAgro.Lb
    Friend WithEvents TxEjercicioREA As NetAgro.TxDato
    Friend WithEvents LbFechaAsientoREA As NetAgro.Lb
    Friend WithEvents TxFechaAsientoREA As NetAgro.TxDato
    Friend WithEvents LbAnoFondo As NetAgro.Lb
    Friend WithEvents TxAnnoFondo As NetAgro.TxDato
End Class
