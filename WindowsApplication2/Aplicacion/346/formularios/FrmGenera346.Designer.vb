<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenera346

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenera346))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbEjerDevengo = New NetAgro.Lb(Me.components)
        Me.TxEjerDevengo = New NetAgro.TxDato(Me.components)
        Me.LbAno = New NetAgro.Lb(Me.components)
        Me.TxAno = New NetAgro.TxDato(Me.components)
        Me.BtEjercicio = New NetAgro.BtBusca(Me.components)
        Me.TxEjercicio = New NetAgro.TxDato(Me.components)
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbTelefono = New NetAgro.Lb(Me.components)
        Me.TxTelefono = New NetAgro.TxDato(Me.components)
        Me.LbContacto = New NetAgro.Lb(Me.components)
        Me.TxContacto = New NetAgro.TxDato(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.TxNombre = New NetAgro.TxDato(Me.components)
        Me.LbNif = New NetAgro.Lb(Me.components)
        Me.TxNif = New NetAgro.TxDato(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTerceros = New System.Windows.Forms.RadioButton()
        Me.RbNombrePropio = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbTelematico = New System.Windows.Forms.RadioButton()
        Me.RbCdRom = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ChkSustitutiva = New System.Windows.Forms.CheckBox()
        Me.ChkComplementaria = New System.Windows.Forms.CheckBox()
        Me.LbAnterior = New NetAgro.Lb(Me.components)
        Me.TxAnterior = New NetAgro.TxDato(Me.components)
        Me.LbDeclaracion = New NetAgro.Lb(Me.components)
        Me.TxDeclaracion = New NetAgro.TxDato(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxNombreFichero = New NetAgro.TxDato(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Panel1)
        Me.PanelCabecera.Controls.Add(Me.GroupBox5)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1417, 290)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 214)
        Me.PanelConsulta.Size = New System.Drawing.Size(1417, 276)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1117, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1192, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1267, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1342, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(1042, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbEjerDevengo)
        Me.GroupBox1.Controls.Add(Me.TxEjerDevengo)
        Me.GroupBox1.Controls.Add(Me.LbAno)
        Me.GroupBox1.Controls.Add(Me.TxAno)
        Me.GroupBox1.Controls.Add(Me.BtEjercicio)
        Me.GroupBox1.Controls.Add(Me.LbEjercicio)
        Me.GroupBox1.Controls.Add(Me.TxEjercicio)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(26, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 136)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'LbEjerDevengo
        '
        Me.LbEjerDevengo.AutoSize = True
        Me.LbEjerDevengo.CL_ControlAsociado = Nothing
        Me.LbEjerDevengo.CL_ValorFijo = False
        Me.LbEjerDevengo.ClForm = Nothing
        Me.LbEjerDevengo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjerDevengo.ForeColor = System.Drawing.Color.Teal
        Me.LbEjerDevengo.Location = New System.Drawing.Point(13, 77)
        Me.LbEjerDevengo.Name = "LbEjerDevengo"
        Me.LbEjerDevengo.Size = New System.Drawing.Size(90, 16)
        Me.LbEjerDevengo.TabIndex = 84
        Me.LbEjerDevengo.Text = "Ej Devengo"
        '
        'TxEjerDevengo
        '
        Me.TxEjerDevengo.Autonumerico = False
        Me.TxEjerDevengo.Buscando = False
        Me.TxEjerDevengo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjerDevengo.ClForm = Nothing
        Me.TxEjerDevengo.ClParam = Nothing
        Me.TxEjerDevengo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjerDevengo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjerDevengo.GridLin = Nothing
        Me.TxEjerDevengo.HaCambiado = False
        Me.TxEjerDevengo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjerDevengo.lbbusca = Nothing
        Me.TxEjerDevengo.Location = New System.Drawing.Point(114, 74)
        Me.TxEjerDevengo.MiError = False
        Me.TxEjerDevengo.Name = "TxEjerDevengo"
        Me.TxEjerDevengo.Orden = 0
        Me.TxEjerDevengo.SaltoAlfinal = False
        Me.TxEjerDevengo.Siguiente = 0
        Me.TxEjerDevengo.Size = New System.Drawing.Size(62, 22)
        Me.TxEjerDevengo.TabIndex = 83
        Me.TxEjerDevengo.TeclaRepetida = False
        Me.TxEjerDevengo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxEjerDevengo.TxDatoFinalSemana = Nothing
        Me.TxEjerDevengo.TxDatoInicioSemana = Nothing
        Me.TxEjerDevengo.UltimoValorValidado = Nothing
        '
        'LbAno
        '
        Me.LbAno.AutoSize = True
        Me.LbAno.CL_ControlAsociado = Nothing
        Me.LbAno.CL_ValorFijo = False
        Me.LbAno.ClForm = Nothing
        Me.LbAno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAno.ForeColor = System.Drawing.Color.Teal
        Me.LbAno.Location = New System.Drawing.Point(13, 49)
        Me.LbAno.Name = "LbAno"
        Me.LbAno.Size = New System.Drawing.Size(36, 16)
        Me.LbAno.TabIndex = 82
        Me.LbAno.Text = "Año"
        '
        'TxAno
        '
        Me.TxAno.Autonumerico = False
        Me.TxAno.Buscando = False
        Me.TxAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAno.ClForm = Nothing
        Me.TxAno.ClParam = Nothing
        Me.TxAno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAno.GridLin = Nothing
        Me.TxAno.HaCambiado = False
        Me.TxAno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAno.lbbusca = Nothing
        Me.TxAno.Location = New System.Drawing.Point(114, 46)
        Me.TxAno.MiError = False
        Me.TxAno.Name = "TxAno"
        Me.TxAno.Orden = 0
        Me.TxAno.SaltoAlfinal = False
        Me.TxAno.Siguiente = 0
        Me.TxAno.Size = New System.Drawing.Size(62, 22)
        Me.TxAno.TabIndex = 81
        Me.TxAno.TeclaRepetida = False
        Me.TxAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxAno.TxDatoFinalSemana = Nothing
        Me.TxAno.TxDatoInicioSemana = Nothing
        Me.TxAno.UltimoValorValidado = Nothing
        '
        'BtEjercicio
        '
        Me.BtEjercicio.CL_Ancho = 0
        Me.BtEjercicio.CL_BuscaAlb = False
        Me.BtEjercicio.CL_campocodigo = Nothing
        Me.BtEjercicio.CL_camponombre = Nothing
        Me.BtEjercicio.CL_CampoOrden = "Nombre"
        Me.BtEjercicio.CL_ch1000 = False
        Me.BtEjercicio.CL_ConsultaSql = "Select * from familias"
        Me.BtEjercicio.CL_ControlAsociado = Me.TxEjercicio
        Me.BtEjercicio.CL_DevuelveCampo = "Idfamilia"
        Me.BtEjercicio.CL_dfecha = Nothing
        Me.BtEjercicio.CL_Entidad = Nothing
        Me.BtEjercicio.CL_EsId = True
        Me.BtEjercicio.CL_Filtro = Nothing
        Me.BtEjercicio.cl_formu = Nothing
        Me.BtEjercicio.CL_hfecha = Nothing
        Me.BtEjercicio.cl_ListaW = Nothing
        Me.BtEjercicio.CL_xCentro = False
        Me.BtEjercicio.Image = CType(resources.GetObject("BtEjercicio.Image"), System.Drawing.Image)
        Me.BtEjercicio.Location = New System.Drawing.Point(182, 18)
        Me.BtEjercicio.Name = "BtEjercicio"
        Me.BtEjercicio.Size = New System.Drawing.Size(33, 23)
        Me.BtEjercicio.TabIndex = 80
        Me.BtEjercicio.UseVisualStyleBackColor = True
        '
        'TxEjercicio
        '
        Me.TxEjercicio.Autonumerico = False
        Me.TxEjercicio.Buscando = False
        Me.TxEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjercicio.ClForm = Nothing
        Me.TxEjercicio.ClParam = Nothing
        Me.TxEjercicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjercicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjercicio.GridLin = Nothing
        Me.TxEjercicio.HaCambiado = False
        Me.TxEjercicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjercicio.lbbusca = Nothing
        Me.TxEjercicio.Location = New System.Drawing.Point(114, 18)
        Me.TxEjercicio.MiError = False
        Me.TxEjercicio.Name = "TxEjercicio"
        Me.TxEjercicio.Orden = 0
        Me.TxEjercicio.SaltoAlfinal = False
        Me.TxEjercicio.Siguiente = 0
        Me.TxEjercicio.Size = New System.Drawing.Size(62, 22)
        Me.TxEjercicio.TabIndex = 78
        Me.TxEjercicio.TeclaRepetida = False
        Me.TxEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxEjercicio.TxDatoFinalSemana = Nothing
        Me.TxEjercicio.TxDatoInicioSemana = Nothing
        Me.TxEjercicio.UltimoValorValidado = Nothing
        '
        'LbEjercicio
        '
        Me.LbEjercicio.AutoSize = True
        Me.LbEjercicio.CL_ControlAsociado = Nothing
        Me.LbEjercicio.CL_ValorFijo = False
        Me.LbEjercicio.ClForm = Nothing
        Me.LbEjercicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicio.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicio.Location = New System.Drawing.Point(13, 21)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(70, 16)
        Me.LbEjercicio.TabIndex = 79
        Me.LbEjercicio.Text = "Ejercicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbTelefono)
        Me.GroupBox2.Controls.Add(Me.TxTelefono)
        Me.GroupBox2.Controls.Add(Me.LbContacto)
        Me.GroupBox2.Controls.Add(Me.TxContacto)
        Me.GroupBox2.Controls.Add(Me.LbNombre)
        Me.GroupBox2.Controls.Add(Me.TxNombre)
        Me.GroupBox2.Controls.Add(Me.LbNif)
        Me.GroupBox2.Controls.Add(Me.TxNif)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(261, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 136)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPRESA"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.CL_ControlAsociado = Nothing
        Me.LbTelefono.CL_ValorFijo = False
        Me.LbTelefono.ClForm = Nothing
        Me.LbTelefono.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono.ForeColor = System.Drawing.Color.Teal
        Me.LbTelefono.Location = New System.Drawing.Point(13, 92)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(70, 16)
        Me.LbTelefono.TabIndex = 86
        Me.LbTelefono.Text = "Teléfono"
        '
        'TxTelefono
        '
        Me.TxTelefono.Autonumerico = False
        Me.TxTelefono.Buscando = False
        Me.TxTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTelefono.ClForm = Nothing
        Me.TxTelefono.ClParam = Nothing
        Me.TxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTelefono.GridLin = Nothing
        Me.TxTelefono.HaCambiado = False
        Me.TxTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTelefono.lbbusca = Nothing
        Me.TxTelefono.Location = New System.Drawing.Point(114, 89)
        Me.TxTelefono.MiError = False
        Me.TxTelefono.Name = "TxTelefono"
        Me.TxTelefono.Orden = 0
        Me.TxTelefono.SaltoAlfinal = False
        Me.TxTelefono.Siguiente = 0
        Me.TxTelefono.Size = New System.Drawing.Size(190, 22)
        Me.TxTelefono.TabIndex = 85
        Me.TxTelefono.TeclaRepetida = False
        Me.TxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxTelefono.TxDatoFinalSemana = Nothing
        Me.TxTelefono.TxDatoInicioSemana = Nothing
        Me.TxTelefono.UltimoValorValidado = Nothing
        '
        'LbContacto
        '
        Me.LbContacto.AutoSize = True
        Me.LbContacto.CL_ControlAsociado = Nothing
        Me.LbContacto.CL_ValorFijo = False
        Me.LbContacto.ClForm = Nothing
        Me.LbContacto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbContacto.ForeColor = System.Drawing.Color.Teal
        Me.LbContacto.Location = New System.Drawing.Point(13, 66)
        Me.LbContacto.Name = "LbContacto"
        Me.LbContacto.Size = New System.Drawing.Size(74, 16)
        Me.LbContacto.TabIndex = 84
        Me.LbContacto.Text = "Contacto"
        '
        'TxContacto
        '
        Me.TxContacto.Autonumerico = False
        Me.TxContacto.Buscando = False
        Me.TxContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxContacto.ClForm = Nothing
        Me.TxContacto.ClParam = Nothing
        Me.TxContacto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxContacto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxContacto.GridLin = Nothing
        Me.TxContacto.HaCambiado = False
        Me.TxContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxContacto.lbbusca = Nothing
        Me.TxContacto.Location = New System.Drawing.Point(114, 63)
        Me.TxContacto.MiError = False
        Me.TxContacto.Name = "TxContacto"
        Me.TxContacto.Orden = 0
        Me.TxContacto.SaltoAlfinal = False
        Me.TxContacto.Siguiente = 0
        Me.TxContacto.Size = New System.Drawing.Size(396, 22)
        Me.TxContacto.TabIndex = 83
        Me.TxContacto.TeclaRepetida = False
        Me.TxContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxContacto.TxDatoFinalSemana = Nothing
        Me.TxContacto.TxDatoInicioSemana = Nothing
        Me.TxContacto.UltimoValorValidado = Nothing
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = False
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Teal
        Me.LbNombre.Location = New System.Drawing.Point(13, 41)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(65, 16)
        Me.LbNombre.TabIndex = 82
        Me.LbNombre.Text = "Nombre"
        '
        'TxNombre
        '
        Me.TxNombre.Autonumerico = False
        Me.TxNombre.Buscando = False
        Me.TxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombre.ClForm = Nothing
        Me.TxNombre.ClParam = Nothing
        Me.TxNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNombre.GridLin = Nothing
        Me.TxNombre.HaCambiado = False
        Me.TxNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNombre.lbbusca = Nothing
        Me.TxNombre.Location = New System.Drawing.Point(114, 38)
        Me.TxNombre.MiError = False
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Orden = 0
        Me.TxNombre.SaltoAlfinal = False
        Me.TxNombre.Siguiente = 0
        Me.TxNombre.Size = New System.Drawing.Size(429, 22)
        Me.TxNombre.TabIndex = 81
        Me.TxNombre.TeclaRepetida = False
        Me.TxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxNombre.TxDatoFinalSemana = Nothing
        Me.TxNombre.TxDatoInicioSemana = Nothing
        Me.TxNombre.UltimoValorValidado = Nothing
        '
        'LbNif
        '
        Me.LbNif.AutoSize = True
        Me.LbNif.CL_ControlAsociado = Nothing
        Me.LbNif.CL_ValorFijo = False
        Me.LbNif.ClForm = Nothing
        Me.LbNif.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNif.ForeColor = System.Drawing.Color.Teal
        Me.LbNif.Location = New System.Drawing.Point(13, 16)
        Me.LbNif.Name = "LbNif"
        Me.LbNif.Size = New System.Drawing.Size(27, 16)
        Me.LbNif.TabIndex = 79
        Me.LbNif.Text = "Nif"
        '
        'TxNif
        '
        Me.TxNif.Autonumerico = False
        Me.TxNif.Buscando = False
        Me.TxNif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNif.ClForm = Nothing
        Me.TxNif.ClParam = Nothing
        Me.TxNif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNif.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNif.GridLin = Nothing
        Me.TxNif.HaCambiado = False
        Me.TxNif.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNif.lbbusca = Nothing
        Me.TxNif.Location = New System.Drawing.Point(114, 13)
        Me.TxNif.MiError = False
        Me.TxNif.Name = "TxNif"
        Me.TxNif.Orden = 0
        Me.TxNif.SaltoAlfinal = False
        Me.TxNif.Siguiente = 0
        Me.TxNif.Size = New System.Drawing.Size(148, 22)
        Me.TxNif.TabIndex = 78
        Me.TxNif.TeclaRepetida = False
        Me.TxNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxNif.TxDatoFinalSemana = Nothing
        Me.TxNif.TxDatoInicioSemana = Nothing
        Me.TxNif.UltimoValorValidado = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTerceros)
        Me.GroupBox3.Controls.Add(Me.RbNombrePropio)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(828, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 65)
        Me.GroupBox3.TabIndex = 80
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CARACTER INTERVENCION"
        '
        'RbTerceros
        '
        Me.RbTerceros.AutoSize = True
        Me.RbTerceros.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTerceros.ForeColor = System.Drawing.Color.Teal
        Me.RbTerceros.Location = New System.Drawing.Point(21, 39)
        Me.RbTerceros.Name = "RbTerceros"
        Me.RbTerceros.Size = New System.Drawing.Size(191, 20)
        Me.RbTerceros.TabIndex = 1
        Me.RbTerceros.Text = "En nombre de terceros"
        Me.RbTerceros.UseVisualStyleBackColor = True
        '
        'RbNombrePropio
        '
        Me.RbNombrePropio.AutoSize = True
        Me.RbNombrePropio.Checked = True
        Me.RbNombrePropio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNombrePropio.ForeColor = System.Drawing.Color.Teal
        Me.RbNombrePropio.Location = New System.Drawing.Point(21, 15)
        Me.RbNombrePropio.Name = "RbNombrePropio"
        Me.RbNombrePropio.Size = New System.Drawing.Size(154, 20)
        Me.RbNombrePropio.TabIndex = 0
        Me.RbNombrePropio.TabStop = True
        Me.RbNombrePropio.Text = "En nombre propio"
        Me.RbNombrePropio.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbTelematico)
        Me.GroupBox4.Controls.Add(Me.RbCdRom)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(828, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(175, 60)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TIPO DE SOPORTE"
        '
        'RbTelematico
        '
        Me.RbTelematico.AutoSize = True
        Me.RbTelematico.Checked = True
        Me.RbTelematico.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTelematico.ForeColor = System.Drawing.Color.Teal
        Me.RbTelematico.Location = New System.Drawing.Point(21, 35)
        Me.RbTelematico.Name = "RbTelematico"
        Me.RbTelematico.Size = New System.Drawing.Size(106, 20)
        Me.RbTelematico.TabIndex = 1
        Me.RbTelematico.TabStop = True
        Me.RbTelematico.Text = "Telemático"
        Me.RbTelematico.UseVisualStyleBackColor = True
        '
        'RbCdRom
        '
        Me.RbCdRom.AutoSize = True
        Me.RbCdRom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCdRom.ForeColor = System.Drawing.Color.Teal
        Me.RbCdRom.Location = New System.Drawing.Point(21, 15)
        Me.RbCdRom.Name = "RbCdRom"
        Me.RbCdRom.Size = New System.Drawing.Size(82, 20)
        Me.RbCdRom.TabIndex = 0
        Me.RbCdRom.Text = "CD ROM"
        Me.RbCdRom.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChkSustitutiva)
        Me.GroupBox5.Controls.Add(Me.ChkComplementaria)
        Me.GroupBox5.Controls.Add(Me.LbAnterior)
        Me.GroupBox5.Controls.Add(Me.TxAnterior)
        Me.GroupBox5.Controls.Add(Me.LbDeclaracion)
        Me.GroupBox5.Controls.Add(Me.TxDeclaracion)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(1062, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(320, 131)
        Me.GroupBox5.TabIndex = 82
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DECLARACION"
        '
        'ChkSustitutiva
        '
        Me.ChkSustitutiva.AutoSize = True
        Me.ChkSustitutiva.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSustitutiva.ForeColor = System.Drawing.Color.Teal
        Me.ChkSustitutiva.Location = New System.Drawing.Point(114, 105)
        Me.ChkSustitutiva.Name = "ChkSustitutiva"
        Me.ChkSustitutiva.Size = New System.Drawing.Size(121, 20)
        Me.ChkSustitutiva.TabIndex = 84
        Me.ChkSustitutiva.Text = "SUSTITUTIVA"
        Me.ChkSustitutiva.UseVisualStyleBackColor = True
        '
        'ChkComplementaria
        '
        Me.ChkComplementaria.AutoSize = True
        Me.ChkComplementaria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkComplementaria.ForeColor = System.Drawing.Color.Teal
        Me.ChkComplementaria.Location = New System.Drawing.Point(114, 81)
        Me.ChkComplementaria.Name = "ChkComplementaria"
        Me.ChkComplementaria.Size = New System.Drawing.Size(160, 20)
        Me.ChkComplementaria.TabIndex = 83
        Me.ChkComplementaria.Text = "COMPLEMENTARIA"
        Me.ChkComplementaria.UseVisualStyleBackColor = True
        '
        'LbAnterior
        '
        Me.LbAnterior.AutoSize = True
        Me.LbAnterior.CL_ControlAsociado = Nothing
        Me.LbAnterior.CL_ValorFijo = False
        Me.LbAnterior.ClForm = Nothing
        Me.LbAnterior.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAnterior.ForeColor = System.Drawing.Color.Teal
        Me.LbAnterior.Location = New System.Drawing.Point(13, 49)
        Me.LbAnterior.Name = "LbAnterior"
        Me.LbAnterior.Size = New System.Drawing.Size(67, 16)
        Me.LbAnterior.TabIndex = 82
        Me.LbAnterior.Text = "Anterior"
        '
        'TxAnterior
        '
        Me.TxAnterior.Autonumerico = False
        Me.TxAnterior.Buscando = False
        Me.TxAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAnterior.ClForm = Nothing
        Me.TxAnterior.ClParam = Nothing
        Me.TxAnterior.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAnterior.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAnterior.GridLin = Nothing
        Me.TxAnterior.HaCambiado = False
        Me.TxAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAnterior.lbbusca = Nothing
        Me.TxAnterior.Location = New System.Drawing.Point(114, 46)
        Me.TxAnterior.MiError = False
        Me.TxAnterior.Name = "TxAnterior"
        Me.TxAnterior.Orden = 0
        Me.TxAnterior.SaltoAlfinal = False
        Me.TxAnterior.Siguiente = 0
        Me.TxAnterior.Size = New System.Drawing.Size(188, 22)
        Me.TxAnterior.TabIndex = 81
        Me.TxAnterior.TeclaRepetida = False
        Me.TxAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxAnterior.TxDatoFinalSemana = Nothing
        Me.TxAnterior.TxDatoInicioSemana = Nothing
        Me.TxAnterior.UltimoValorValidado = Nothing
        '
        'LbDeclaracion
        '
        Me.LbDeclaracion.AutoSize = True
        Me.LbDeclaracion.CL_ControlAsociado = Nothing
        Me.LbDeclaracion.CL_ValorFijo = False
        Me.LbDeclaracion.ClForm = Nothing
        Me.LbDeclaracion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeclaracion.ForeColor = System.Drawing.Color.Teal
        Me.LbDeclaracion.Location = New System.Drawing.Point(13, 21)
        Me.LbDeclaracion.Name = "LbDeclaracion"
        Me.LbDeclaracion.Size = New System.Drawing.Size(65, 16)
        Me.LbDeclaracion.TabIndex = 79
        Me.LbDeclaracion.Text = "Número"
        '
        'TxDeclaracion
        '
        Me.TxDeclaracion.Autonumerico = False
        Me.TxDeclaracion.Buscando = False
        Me.TxDeclaracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeclaracion.ClForm = Nothing
        Me.TxDeclaracion.ClParam = Nothing
        Me.TxDeclaracion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeclaracion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeclaracion.GridLin = Nothing
        Me.TxDeclaracion.HaCambiado = False
        Me.TxDeclaracion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeclaracion.lbbusca = Nothing
        Me.TxDeclaracion.Location = New System.Drawing.Point(114, 18)
        Me.TxDeclaracion.MiError = False
        Me.TxDeclaracion.Name = "TxDeclaracion"
        Me.TxDeclaracion.Orden = 0
        Me.TxDeclaracion.SaltoAlfinal = False
        Me.TxDeclaracion.Siguiente = 0
        Me.TxDeclaracion.Size = New System.Drawing.Size(188, 22)
        Me.TxDeclaracion.TabIndex = 78
        Me.TxDeclaracion.TeclaRepetida = False
        Me.TxDeclaracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDeclaracion.TxDatoFinalSemana = Nothing
        Me.TxDeclaracion.TxDatoInicioSemana = Nothing
        Me.TxDeclaracion.UltimoValorValidado = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.TxNombreFichero)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Lb1)
        Me.Panel1.Location = New System.Drawing.Point(26, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 61)
        Me.Panel1.TabIndex = 100277
        '
        'TxNombreFichero
        '
        Me.TxNombreFichero.Autonumerico = False
        Me.TxNombreFichero.Buscando = False
        Me.TxNombreFichero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombreFichero.ClForm = Nothing
        Me.TxNombreFichero.ClParam = Nothing
        Me.TxNombreFichero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNombreFichero.GridLin = Nothing
        Me.TxNombreFichero.HaCambiado = False
        Me.TxNombreFichero.lbbusca = Nothing
        Me.TxNombreFichero.Location = New System.Drawing.Point(15, 24)
        Me.TxNombreFichero.MiError = False
        Me.TxNombreFichero.Name = "TxNombreFichero"
        Me.TxNombreFichero.Orden = 0
        Me.TxNombreFichero.SaltoAlfinal = False
        Me.TxNombreFichero.Siguiente = 0
        Me.TxNombreFichero.Size = New System.Drawing.Size(730, 22)
        Me.TxNombreFichero.TabIndex = 88
        Me.TxNombreFichero.TeclaRepetida = False
        Me.TxNombreFichero.TxDatoFinalSemana = Nothing
        Me.TxNombreFichero.TxDatoInicioSemana = Nothing
        Me.TxNombreFichero.UltimoValorValidado = Nothing
        '
        'Button1
        '
        Me.Button1.Image = Global.NetAgro.My.Resources.Resources.Add_Property_16
        Me.Button1.Location = New System.Drawing.Point(751, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 2)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(124, 16)
        Me.Lb1.TabIndex = 83
        Me.Lb1.Text = "Generar Fichero"
        '
        'FrmGenera346
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 530)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGenera346"
        Me.Text = "Consulta datos 346"
        Me.PanelCabecera.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LbAnterior As NetAgro.Lb
    Friend WithEvents TxAnterior As NetAgro.TxDato
    Friend WithEvents LbDeclaracion As NetAgro.Lb
    Friend WithEvents TxDeclaracion As NetAgro.TxDato
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTelematico As System.Windows.Forms.RadioButton
    Friend WithEvents RbCdRom As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTerceros As System.Windows.Forms.RadioButton
    Friend WithEvents RbNombrePropio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbTelefono As NetAgro.Lb
    Friend WithEvents TxTelefono As NetAgro.TxDato
    Friend WithEvents LbContacto As NetAgro.Lb
    Friend WithEvents TxContacto As NetAgro.TxDato
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents TxNombre As NetAgro.TxDato
    Friend WithEvents LbNif As NetAgro.Lb
    Friend WithEvents TxNif As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbEjerDevengo As NetAgro.Lb
    Friend WithEvents TxEjerDevengo As NetAgro.TxDato
    Friend WithEvents LbAno As NetAgro.Lb
    Friend WithEvents TxAno As NetAgro.TxDato
    Friend WithEvents BtEjercicio As NetAgro.BtBusca
    Friend WithEvents TxEjercicio As NetAgro.TxDato
    Friend WithEvents LbEjercicio As NetAgro.Lb
    Friend WithEvents ChkSustitutiva As System.Windows.Forms.CheckBox
    Friend WithEvents ChkComplementaria As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxNombreFichero As NetAgro.TxDato
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
End Class
