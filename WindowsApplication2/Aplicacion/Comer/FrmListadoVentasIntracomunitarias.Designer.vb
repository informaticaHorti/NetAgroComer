<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoVentasIntracomunitarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoVentasIntracomunitarias))
        Me.TxHastaCliente = New NetAgro.TxDato(Me.components)
        Me.LbHastaCliente = New NetAgro.Lb(Me.components)
        Me.TxDesdeCliente = New NetAgro.TxDato(Me.components)
        Me.LbDesdeCliente = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbNomDesdeCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaDesdeCliente = New NetAgro.BtBusca(Me.components)
        Me.LbNomHastaCliente = New NetAgro.Lb(Me.components)
        Me.BtBuscaHastaCliente = New NetAgro.BtBusca(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChPaisesNoComunitarios = New System.Windows.Forms.CheckBox()
        Me.ChPaisesComunitarios = New System.Windows.Forms.CheckBox()
        Me.ChMercadoNacional = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LbPersona = New NetAgro.Lb(Me.components)
        Me.TxPersona = New NetAgro.TxDato(Me.components)
        Me.LbPeriodo = New NetAgro.Lb(Me.components)
        Me.TxPeriodo = New NetAgro.TxDato(Me.components)
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.TxEjercicio = New NetAgro.TxDato(Me.components)
        Me.LbRutafichero = New NetAgro.Lb(Me.components)
        Me.TxRutafichero = New NetAgro.TxDato(Me.components)
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ChKCompras = New System.Windows.Forms.CheckBox()
        Me.LbTelefono = New NetAgro.Lb(Me.components)
        Me.TxTelefono = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.ChKCompras)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.LbNomHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.LbNomDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeCliente)
        Me.PanelCabecera.Controls.Add(Me.LbHastaCliente)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeCliente)
        Me.PanelCabecera.Size = New System.Drawing.Size(1007, 302)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 278)
        Me.PanelConsulta.Size = New System.Drawing.Size(1007, 275)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(707, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(782, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(857, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(932, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(632, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxHastaCliente
        '
        Me.TxHastaCliente.Autonumerico = False
        Me.TxHastaCliente.Buscando = False
        Me.TxHastaCliente.ClForm = Nothing
        Me.TxHastaCliente.ClParam = Nothing
        Me.TxHastaCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaCliente.GridLin = Nothing
        Me.TxHastaCliente.HaCambiado = False
        Me.TxHastaCliente.lbbusca = Nothing
        Me.TxHastaCliente.Location = New System.Drawing.Point(152, 87)
        Me.TxHastaCliente.MiError = False
        Me.TxHastaCliente.Name = "TxHastaCliente"
        Me.TxHastaCliente.Orden = 0
        Me.TxHastaCliente.SaltoAlfinal = False
        Me.TxHastaCliente.Siguiente = 0
        Me.TxHastaCliente.Size = New System.Drawing.Size(70, 22)
        Me.TxHastaCliente.TabIndex = 83
        Me.TxHastaCliente.TeclaRepetida = False
        Me.TxHastaCliente.TxDatoFinalSemana = Nothing
        Me.TxHastaCliente.TxDatoInicioSemana = Nothing
        Me.TxHastaCliente.UltimoValorValidado = Nothing
        '
        'LbHastaCliente
        '
        Me.LbHastaCliente.AutoSize = True
        Me.LbHastaCliente.CL_ControlAsociado = Nothing
        Me.LbHastaCliente.CL_ValorFijo = False
        Me.LbHastaCliente.ClForm = Nothing
        Me.LbHastaCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaCliente.Location = New System.Drawing.Point(33, 90)
        Me.LbHastaCliente.Name = "LbHastaCliente"
        Me.LbHastaCliente.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaCliente.TabIndex = 82
        Me.LbHastaCliente.Text = "Hasta Cliente"
        '
        'TxDesdeCliente
        '
        Me.TxDesdeCliente.Autonumerico = False
        Me.TxDesdeCliente.Buscando = False
        Me.TxDesdeCliente.ClForm = Nothing
        Me.TxDesdeCliente.ClParam = Nothing
        Me.TxDesdeCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeCliente.GridLin = Nothing
        Me.TxDesdeCliente.HaCambiado = False
        Me.TxDesdeCliente.lbbusca = Nothing
        Me.TxDesdeCliente.Location = New System.Drawing.Point(152, 58)
        Me.TxDesdeCliente.MiError = False
        Me.TxDesdeCliente.Name = "TxDesdeCliente"
        Me.TxDesdeCliente.Orden = 0
        Me.TxDesdeCliente.SaltoAlfinal = False
        Me.TxDesdeCliente.Siguiente = 0
        Me.TxDesdeCliente.Size = New System.Drawing.Size(70, 22)
        Me.TxDesdeCliente.TabIndex = 81
        Me.TxDesdeCliente.TeclaRepetida = False
        Me.TxDesdeCliente.TxDatoFinalSemana = Nothing
        Me.TxDesdeCliente.TxDatoInicioSemana = Nothing
        Me.TxDesdeCliente.UltimoValorValidado = Nothing
        '
        'LbDesdeCliente
        '
        Me.LbDesdeCliente.AutoSize = True
        Me.LbDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbDesdeCliente.CL_ValorFijo = False
        Me.LbDesdeCliente.ClForm = Nothing
        Me.LbDesdeCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeCliente.Location = New System.Drawing.Point(33, 61)
        Me.LbDesdeCliente.Name = "LbDesdeCliente"
        Me.LbDesdeCliente.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeCliente.TabIndex = 80
        Me.LbDesdeCliente.Text = "Desde Cliente"
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(815, 87)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 100283
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(696, 61)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(101, 16)
        Me.LbDesdeFecha.TabIndex = 100280
        Me.LbDesdeFecha.Text = "Desde Fecha"
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(696, 90)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(99, 16)
        Me.LbHastaFecha.TabIndex = 100282
        Me.LbHastaFecha.Text = "Hasta Fecha"
        '
        'TxDesdeFecha
        '
        Me.TxDesdeFecha.Autonumerico = False
        Me.TxDesdeFecha.Buscando = False
        Me.TxDesdeFecha.ClForm = Nothing
        Me.TxDesdeFecha.ClParam = Nothing
        Me.TxDesdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFecha.GridLin = Nothing
        Me.TxDesdeFecha.HaCambiado = False
        Me.TxDesdeFecha.lbbusca = Nothing
        Me.TxDesdeFecha.Location = New System.Drawing.Point(815, 58)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 100281
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.TxDatoFinalSemana = Nothing
        Me.TxDesdeFecha.TxDatoInicioSemana = Nothing
        Me.TxDesdeFecha.UltimoValorValidado = Nothing
        '
        'LbNomDesdeCliente
        '
        Me.LbNomDesdeCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDesdeCliente.CL_ControlAsociado = Nothing
        Me.LbNomDesdeCliente.CL_ValorFijo = False
        Me.LbNomDesdeCliente.ClForm = Nothing
        Me.LbNomDesdeCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeCliente.Location = New System.Drawing.Point(267, 58)
        Me.LbNomDesdeCliente.Name = "LbNomDesdeCliente"
        Me.LbNomDesdeCliente.Size = New System.Drawing.Size(388, 23)
        Me.LbNomDesdeCliente.TabIndex = 100288
        '
        'BtBuscaDesdeCliente
        '
        Me.BtBuscaDesdeCliente.CL_Ancho = 0
        Me.BtBuscaDesdeCliente.CL_BuscaAlb = False
        Me.BtBuscaDesdeCliente.CL_campocodigo = Nothing
        Me.BtBuscaDesdeCliente.CL_camponombre = Nothing
        Me.BtBuscaDesdeCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeCliente.CL_ch1000 = False
        Me.BtBuscaDesdeCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeCliente.CL_dfecha = Nothing
        Me.BtBuscaDesdeCliente.CL_Entidad = Nothing
        Me.BtBuscaDesdeCliente.CL_EsId = True
        Me.BtBuscaDesdeCliente.CL_Filtro = Nothing
        Me.BtBuscaDesdeCliente.cl_formu = Nothing
        Me.BtBuscaDesdeCliente.CL_hfecha = Nothing
        Me.BtBuscaDesdeCliente.cl_ListaW = Nothing
        Me.BtBuscaDesdeCliente.CL_xCentro = False
        Me.BtBuscaDesdeCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeCliente.Location = New System.Drawing.Point(228, 58)
        Me.BtBuscaDesdeCliente.Name = "BtBuscaDesdeCliente"
        Me.BtBuscaDesdeCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeCliente.TabIndex = 100287
        Me.BtBuscaDesdeCliente.UseVisualStyleBackColor = True
        '
        'LbNomHastaCliente
        '
        Me.LbNomHastaCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomHastaCliente.CL_ControlAsociado = Nothing
        Me.LbNomHastaCliente.CL_ValorFijo = False
        Me.LbNomHastaCliente.ClForm = Nothing
        Me.LbNomHastaCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomHastaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomHastaCliente.Location = New System.Drawing.Point(267, 87)
        Me.LbNomHastaCliente.Name = "LbNomHastaCliente"
        Me.LbNomHastaCliente.Size = New System.Drawing.Size(388, 23)
        Me.LbNomHastaCliente.TabIndex = 100290
        '
        'BtBuscaHastaCliente
        '
        Me.BtBuscaHastaCliente.CL_Ancho = 0
        Me.BtBuscaHastaCliente.CL_BuscaAlb = False
        Me.BtBuscaHastaCliente.CL_campocodigo = Nothing
        Me.BtBuscaHastaCliente.CL_camponombre = Nothing
        Me.BtBuscaHastaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaCliente.CL_ch1000 = False
        Me.BtBuscaHastaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaCliente.CL_dfecha = Nothing
        Me.BtBuscaHastaCliente.CL_Entidad = Nothing
        Me.BtBuscaHastaCliente.CL_EsId = True
        Me.BtBuscaHastaCliente.CL_Filtro = Nothing
        Me.BtBuscaHastaCliente.cl_formu = Nothing
        Me.BtBuscaHastaCliente.CL_hfecha = Nothing
        Me.BtBuscaHastaCliente.cl_ListaW = Nothing
        Me.BtBuscaHastaCliente.CL_xCentro = False
        Me.BtBuscaHastaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaCliente.Location = New System.Drawing.Point(228, 87)
        Me.BtBuscaHastaCliente.Name = "BtBuscaHastaCliente"
        Me.BtBuscaHastaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaCliente.TabIndex = 100289
        Me.BtBuscaHastaCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChPaisesNoComunitarios)
        Me.GroupBox1.Controls.Add(Me.ChPaisesComunitarios)
        Me.GroupBox1.Controls.Add(Me.ChMercadoNacional)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(36, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 46)
        Me.GroupBox1.TabIndex = 100297
        Me.GroupBox1.TabStop = False
        '
        'ChPaisesNoComunitarios
        '
        Me.ChPaisesNoComunitarios.AutoSize = True
        Me.ChPaisesNoComunitarios.Location = New System.Drawing.Point(297, 18)
        Me.ChPaisesNoComunitarios.Name = "ChPaisesNoComunitarios"
        Me.ChPaisesNoComunitarios.Size = New System.Drawing.Size(157, 17)
        Me.ChPaisesNoComunitarios.TabIndex = 2
        Me.ChPaisesNoComunitarios.Text = "Paises no Comunitarios"
        Me.ChPaisesNoComunitarios.UseVisualStyleBackColor = True
        '
        'ChPaisesComunitarios
        '
        Me.ChPaisesComunitarios.AutoSize = True
        Me.ChPaisesComunitarios.Checked = True
        Me.ChPaisesComunitarios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChPaisesComunitarios.Location = New System.Drawing.Point(154, 18)
        Me.ChPaisesComunitarios.Name = "ChPaisesComunitarios"
        Me.ChPaisesComunitarios.Size = New System.Drawing.Size(140, 17)
        Me.ChPaisesComunitarios.TabIndex = 1
        Me.ChPaisesComunitarios.Text = "Paises Comunitarios"
        Me.ChPaisesComunitarios.UseVisualStyleBackColor = True
        '
        'ChMercadoNacional
        '
        Me.ChMercadoNacional.AutoSize = True
        Me.ChMercadoNacional.Location = New System.Drawing.Point(17, 18)
        Me.ChMercadoNacional.Name = "ChMercadoNacional"
        Me.ChMercadoNacional.Size = New System.Drawing.Size(125, 17)
        Me.ChMercadoNacional.TabIndex = 0
        Me.ChMercadoNacional.Text = "Mercado Nacional"
        Me.ChMercadoNacional.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbTelefono)
        Me.GroupBox2.Controls.Add(Me.TxTelefono)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LbPersona)
        Me.GroupBox2.Controls.Add(Me.TxPersona)
        Me.GroupBox2.Controls.Add(Me.LbPeriodo)
        Me.GroupBox2.Controls.Add(Me.TxPeriodo)
        Me.GroupBox2.Controls.Add(Me.LbEjercicio)
        Me.GroupBox2.Controls.Add(Me.TxEjercicio)
        Me.GroupBox2.Controls.Add(Me.LbRutafichero)
        Me.GroupBox2.Controls.Add(Me.TxRutafichero)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 112)
        Me.GroupBox2.TabIndex = 100298
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = Global.NetAgro.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(786, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LbPersona
        '
        Me.LbPersona.AutoSize = True
        Me.LbPersona.CL_ControlAsociado = Nothing
        Me.LbPersona.CL_ValorFijo = True
        Me.LbPersona.ClForm = Nothing
        Me.LbPersona.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPersona.ForeColor = System.Drawing.Color.Teal
        Me.LbPersona.Location = New System.Drawing.Point(17, 77)
        Me.LbPersona.Name = "LbPersona"
        Me.LbPersona.Size = New System.Drawing.Size(110, 16)
        Me.LbPersona.TabIndex = 88
        Me.LbPersona.Text = "Persona Cont."
        '
        'TxPersona
        '
        Me.TxPersona.Autonumerico = False
        Me.TxPersona.Buscando = False
        Me.TxPersona.ClForm = Nothing
        Me.TxPersona.ClParam = Nothing
        Me.TxPersona.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPersona.GridLin = Nothing
        Me.TxPersona.HaCambiado = False
        Me.TxPersona.lbbusca = Nothing
        Me.TxPersona.Location = New System.Drawing.Point(137, 75)
        Me.TxPersona.MiError = False
        Me.TxPersona.Name = "TxPersona"
        Me.TxPersona.Orden = 0
        Me.TxPersona.SaltoAlfinal = False
        Me.TxPersona.Siguiente = 0
        Me.TxPersona.Size = New System.Drawing.Size(643, 22)
        Me.TxPersona.TabIndex = 89
        Me.TxPersona.TeclaRepetida = False
        Me.TxPersona.TxDatoFinalSemana = Nothing
        Me.TxPersona.TxDatoInicioSemana = Nothing
        Me.TxPersona.UltimoValorValidado = Nothing
        '
        'LbPeriodo
        '
        Me.LbPeriodo.AutoSize = True
        Me.LbPeriodo.CL_ControlAsociado = Nothing
        Me.LbPeriodo.CL_ValorFijo = True
        Me.LbPeriodo.ClForm = Nothing
        Me.LbPeriodo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPeriodo.ForeColor = System.Drawing.Color.Teal
        Me.LbPeriodo.Location = New System.Drawing.Point(252, 50)
        Me.LbPeriodo.Name = "LbPeriodo"
        Me.LbPeriodo.Size = New System.Drawing.Size(63, 16)
        Me.LbPeriodo.TabIndex = 86
        Me.LbPeriodo.Text = "Periodo"
        '
        'TxPeriodo
        '
        Me.TxPeriodo.Autonumerico = False
        Me.TxPeriodo.Buscando = False
        Me.TxPeriodo.ClForm = Nothing
        Me.TxPeriodo.ClParam = Nothing
        Me.TxPeriodo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPeriodo.GridLin = Nothing
        Me.TxPeriodo.HaCambiado = False
        Me.TxPeriodo.lbbusca = Nothing
        Me.TxPeriodo.Location = New System.Drawing.Point(321, 48)
        Me.TxPeriodo.MiError = False
        Me.TxPeriodo.Name = "TxPeriodo"
        Me.TxPeriodo.Orden = 0
        Me.TxPeriodo.SaltoAlfinal = False
        Me.TxPeriodo.Siguiente = 0
        Me.TxPeriodo.Size = New System.Drawing.Size(70, 22)
        Me.TxPeriodo.TabIndex = 87
        Me.TxPeriodo.TeclaRepetida = False
        Me.TxPeriodo.TxDatoFinalSemana = Nothing
        Me.TxPeriodo.TxDatoInicioSemana = Nothing
        Me.TxPeriodo.UltimoValorValidado = Nothing
        '
        'LbEjercicio
        '
        Me.LbEjercicio.AutoSize = True
        Me.LbEjercicio.CL_ControlAsociado = Nothing
        Me.LbEjercicio.CL_ValorFijo = True
        Me.LbEjercicio.ClForm = Nothing
        Me.LbEjercicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicio.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicio.Location = New System.Drawing.Point(17, 50)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(70, 16)
        Me.LbEjercicio.TabIndex = 84
        Me.LbEjercicio.Text = "Ejercicio"
        '
        'TxEjercicio
        '
        Me.TxEjercicio.Autonumerico = False
        Me.TxEjercicio.Buscando = False
        Me.TxEjercicio.ClForm = Nothing
        Me.TxEjercicio.ClParam = Nothing
        Me.TxEjercicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjercicio.GridLin = Nothing
        Me.TxEjercicio.HaCambiado = False
        Me.TxEjercicio.lbbusca = Nothing
        Me.TxEjercicio.Location = New System.Drawing.Point(137, 48)
        Me.TxEjercicio.MiError = False
        Me.TxEjercicio.Name = "TxEjercicio"
        Me.TxEjercicio.Orden = 0
        Me.TxEjercicio.SaltoAlfinal = False
        Me.TxEjercicio.Siguiente = 0
        Me.TxEjercicio.Size = New System.Drawing.Size(70, 22)
        Me.TxEjercicio.TabIndex = 85
        Me.TxEjercicio.TeclaRepetida = False
        Me.TxEjercicio.TxDatoFinalSemana = Nothing
        Me.TxEjercicio.TxDatoInicioSemana = Nothing
        Me.TxEjercicio.UltimoValorValidado = Nothing
        '
        'LbRutafichero
        '
        Me.LbRutafichero.AutoSize = True
        Me.LbRutafichero.CL_ControlAsociado = Nothing
        Me.LbRutafichero.CL_ValorFijo = True
        Me.LbRutafichero.ClForm = Nothing
        Me.LbRutafichero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRutafichero.ForeColor = System.Drawing.Color.Teal
        Me.LbRutafichero.Location = New System.Drawing.Point(17, 22)
        Me.LbRutafichero.Name = "LbRutafichero"
        Me.LbRutafichero.Size = New System.Drawing.Size(99, 16)
        Me.LbRutafichero.TabIndex = 82
        Me.LbRutafichero.Text = "Ruta Fichero"
        '
        'TxRutafichero
        '
        Me.TxRutafichero.Autonumerico = False
        Me.TxRutafichero.Buscando = False
        Me.TxRutafichero.ClForm = Nothing
        Me.TxRutafichero.ClParam = Nothing
        Me.TxRutafichero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxRutafichero.GridLin = Nothing
        Me.TxRutafichero.HaCambiado = False
        Me.TxRutafichero.lbbusca = Nothing
        Me.TxRutafichero.Location = New System.Drawing.Point(137, 20)
        Me.TxRutafichero.MiError = False
        Me.TxRutafichero.Name = "TxRutafichero"
        Me.TxRutafichero.Orden = 0
        Me.TxRutafichero.SaltoAlfinal = False
        Me.TxRutafichero.Siguiente = 0
        Me.TxRutafichero.Size = New System.Drawing.Size(643, 22)
        Me.TxRutafichero.TabIndex = 83
        Me.TxRutafichero.TeclaRepetida = False
        Me.TxRutafichero.TxDatoFinalSemana = Nothing
        Me.TxRutafichero.TxDatoInicioSemana = Nothing
        Me.TxRutafichero.UltimoValorValidado = Nothing
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'ChKCompras
        '
        Me.ChKCompras.AutoSize = True
        Me.ChKCompras.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKCompras.Location = New System.Drawing.Point(53, 115)
        Me.ChKCompras.Name = "ChKCompras"
        Me.ChKCompras.Size = New System.Drawing.Size(176, 20)
        Me.ChKCompras.TabIndex = 100299
        Me.ChKCompras.Text = "Incluir adquisiciones"
        Me.ChKCompras.UseVisualStyleBackColor = True
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.CL_ControlAsociado = Nothing
        Me.LbTelefono.CL_ValorFijo = True
        Me.LbTelefono.ClForm = Nothing
        Me.LbTelefono.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono.ForeColor = System.Drawing.Color.Teal
        Me.LbTelefono.Location = New System.Drawing.Point(448, 50)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(70, 16)
        Me.LbTelefono.TabIndex = 91
        Me.LbTelefono.Text = "Telefono"
        '
        'TxTelefono
        '
        Me.TxTelefono.Autonumerico = False
        Me.TxTelefono.Buscando = False
        Me.TxTelefono.ClForm = Nothing
        Me.TxTelefono.ClParam = Nothing
        Me.TxTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTelefono.GridLin = Nothing
        Me.TxTelefono.HaCambiado = False
        Me.TxTelefono.lbbusca = Nothing
        Me.TxTelefono.Location = New System.Drawing.Point(524, 48)
        Me.TxTelefono.MiError = False
        Me.TxTelefono.Name = "TxTelefono"
        Me.TxTelefono.Orden = 0
        Me.TxTelefono.SaltoAlfinal = False
        Me.TxTelefono.Siguiente = 0
        Me.TxTelefono.Size = New System.Drawing.Size(172, 22)
        Me.TxTelefono.TabIndex = 92
        Me.TxTelefono.TeclaRepetida = False
        Me.TxTelefono.TxDatoFinalSemana = Nothing
        Me.TxTelefono.TxDatoInicioSemana = Nothing
        Me.TxTelefono.UltimoValorValidado = Nothing
        '
        'FrmListadoVentasIntracomunitarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 593)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoVentasIntracomunitarias"
        Me.Text = "Listado Compras-Ventas Intracomunitarias de Clientes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaCliente As NetAgro.TxDato
    Friend WithEvents LbHastaCliente As NetAgro.Lb
    Friend WithEvents TxDesdeCliente As NetAgro.TxDato
    Friend WithEvents LbDesdeCliente As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbNomHastaCliente As NetAgro.Lb
    Friend WithEvents BtBuscaHastaCliente As NetAgro.BtBusca
    Friend WithEvents LbNomDesdeCliente As NetAgro.Lb
    Friend WithEvents BtBuscaDesdeCliente As NetAgro.BtBusca
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbPersona As NetAgro.Lb
    Friend WithEvents TxPersona As NetAgro.TxDato
    Friend WithEvents LbPeriodo As NetAgro.Lb
    Friend WithEvents TxPeriodo As NetAgro.TxDato
    Friend WithEvents LbEjercicio As NetAgro.Lb
    Friend WithEvents TxEjercicio As NetAgro.TxDato
    Friend WithEvents LbRutafichero As NetAgro.Lb
    Friend WithEvents TxRutafichero As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChPaisesNoComunitarios As System.Windows.Forms.CheckBox
    Friend WithEvents ChPaisesComunitarios As System.Windows.Forms.CheckBox
    Friend WithEvents ChMercadoNacional As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ChKCompras As System.Windows.Forms.CheckBox
    Friend WithEvents LbTelefono As NetAgro.Lb
    Friend WithEvents TxTelefono As NetAgro.TxDato
End Class
