<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParteSemanal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParteSemanal))
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxNuparte = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDeFechaEnt = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxAFechaEnt = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxAFechaSal = New NetAgro.TxDato(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.TxDeFechaSal = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPorKilos = New System.Windows.Forms.RadioButton()
        Me.RbPorImporte = New System.Windows.Forms.RadioButton()
        Me.BtBuscaParte = New NetAgro.BtBusca(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Balbaranes = New NetAgro.ClButton()
        Me.Banular = New NetAgro.ClButton()
        Me.LbValorado = New NetAgro.Lb(Me.components)
        Me.btPrecios = New NetAgro.ClButton()
        Me.BtRegenerar = New NetAgro.ClButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstFamilias = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.BtPendiente = New NetAgro.ClButton()
        Me.ClButton1 = New NetAgro.ClButton()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.BtCentro = New NetAgro.BtBusca(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.TxCentro = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.lstFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbNomCentro)
        Me.PanelCabecera.Controls.Add(Me.BtCentro)
        Me.PanelCabecera.Controls.Add(Me.LbCentro)
        Me.PanelCabecera.Controls.Add(Me.TxCentro)
        Me.PanelCabecera.Controls.Add(Me.ClButton1)
        Me.PanelCabecera.Controls.Add(Me.BtPendiente)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.Panel1)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaParte)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.TxAFechaSal)
        Me.PanelCabecera.Controls.Add(Me.Lb8)
        Me.PanelCabecera.Controls.Add(Me.TxDeFechaSal)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxAFechaEnt)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDeFechaEnt)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.TxNuparte)
        Me.PanelCabecera.Size = New System.Drawing.Size(1104, 167)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 167)
        Me.PanelConsulta.Size = New System.Drawing.Size(1104, 327)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(804, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(879, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(954, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1029, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(729, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(10, 15)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(108, 16)
        Me.Lb3.TabIndex = 116
        Me.Lb3.Text = "Número parte"
        '
        'TxNuparte
        '
        Me.TxNuparte.Autonumerico = False
        Me.TxNuparte.Buscando = False
        Me.TxNuparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNuparte.ClForm = Nothing
        Me.TxNuparte.ClParam = Nothing
        Me.TxNuparte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNuparte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNuparte.GridLin = Nothing
        Me.TxNuparte.HaCambiado = False
        Me.TxNuparte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNuparte.lbbusca = Nothing
        Me.TxNuparte.Location = New System.Drawing.Point(135, 12)
        Me.TxNuparte.MiError = False
        Me.TxNuparte.Name = "TxNuparte"
        Me.TxNuparte.Orden = 0
        Me.TxNuparte.SaltoAlfinal = False
        Me.TxNuparte.Siguiente = 0
        Me.TxNuparte.Size = New System.Drawing.Size(105, 22)
        Me.TxNuparte.TabIndex = 115
        Me.TxNuparte.TeclaRepetida = False
        Me.TxNuparte.TxDatoFinalSemana = Nothing
        Me.TxNuparte.TxDatoInicioSemana = Nothing
        Me.TxNuparte.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(290, 39)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(97, 16)
        Me.Lb4.TabIndex = 100273
        Me.Lb4.Text = "Desde fecha"
        '
        'TxDeFechaEnt
        '
        Me.TxDeFechaEnt.Autonumerico = False
        Me.TxDeFechaEnt.Buscando = False
        Me.TxDeFechaEnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFechaEnt.ClForm = Nothing
        Me.TxDeFechaEnt.ClParam = Nothing
        Me.TxDeFechaEnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFechaEnt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFechaEnt.GridLin = Nothing
        Me.TxDeFechaEnt.HaCambiado = False
        Me.TxDeFechaEnt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFechaEnt.lbbusca = Nothing
        Me.TxDeFechaEnt.Location = New System.Drawing.Point(402, 34)
        Me.TxDeFechaEnt.MiError = False
        Me.TxDeFechaEnt.Name = "TxDeFechaEnt"
        Me.TxDeFechaEnt.Orden = 0
        Me.TxDeFechaEnt.SaltoAlfinal = False
        Me.TxDeFechaEnt.Siguiente = 0
        Me.TxDeFechaEnt.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFechaEnt.TabIndex = 100272
        Me.TxDeFechaEnt.TeclaRepetida = False
        Me.TxDeFechaEnt.TxDatoFinalSemana = Nothing
        Me.TxDeFechaEnt.TxDatoInicioSemana = Nothing
        Me.TxDeFechaEnt.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 42)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(67, 16)
        Me.Lb1.TabIndex = 100275
        Me.Lb1.Text = "Semana"
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
        Me.TxSemana.Location = New System.Drawing.Point(135, 40)
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
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(290, 64)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 100277
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxAFechaEnt
        '
        Me.TxAFechaEnt.Autonumerico = False
        Me.TxAFechaEnt.Buscando = False
        Me.TxAFechaEnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAFechaEnt.ClForm = Nothing
        Me.TxAFechaEnt.ClParam = Nothing
        Me.TxAFechaEnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAFechaEnt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAFechaEnt.GridLin = Nothing
        Me.TxAFechaEnt.HaCambiado = False
        Me.TxAFechaEnt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAFechaEnt.lbbusca = Nothing
        Me.TxAFechaEnt.Location = New System.Drawing.Point(402, 59)
        Me.TxAFechaEnt.MiError = False
        Me.TxAFechaEnt.Name = "TxAFechaEnt"
        Me.TxAFechaEnt.Orden = 0
        Me.TxAFechaEnt.SaltoAlfinal = False
        Me.TxAFechaEnt.Siguiente = 0
        Me.TxAFechaEnt.Size = New System.Drawing.Size(105, 22)
        Me.TxAFechaEnt.TabIndex = 100276
        Me.TxAFechaEnt.TeclaRepetida = False
        Me.TxAFechaEnt.TxDatoFinalSemana = Nothing
        Me.TxAFechaEnt.TxDatoInicioSemana = Nothing
        Me.TxAFechaEnt.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(369, 6)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(138, 25)
        Me.Lb5.TabIndex = 100278
        Me.Lb5.Text = "ENTRADAS"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(611, 6)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(115, 25)
        Me.Lb6.TabIndex = 100283
        Me.Lb6.Text = "SALIDAS"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(509, 64)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(95, 16)
        Me.Lb7.TabIndex = 100282
        Me.Lb7.Text = "Hasta fecha"
        '
        'TxAFechaSal
        '
        Me.TxAFechaSal.Autonumerico = False
        Me.TxAFechaSal.Buscando = False
        Me.TxAFechaSal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAFechaSal.ClForm = Nothing
        Me.TxAFechaSal.ClParam = Nothing
        Me.TxAFechaSal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAFechaSal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAFechaSal.GridLin = Nothing
        Me.TxAFechaSal.HaCambiado = False
        Me.TxAFechaSal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAFechaSal.lbbusca = Nothing
        Me.TxAFechaSal.Location = New System.Drawing.Point(621, 59)
        Me.TxAFechaSal.MiError = False
        Me.TxAFechaSal.Name = "TxAFechaSal"
        Me.TxAFechaSal.Orden = 0
        Me.TxAFechaSal.SaltoAlfinal = False
        Me.TxAFechaSal.Siguiente = 0
        Me.TxAFechaSal.Size = New System.Drawing.Size(105, 22)
        Me.TxAFechaSal.TabIndex = 100281
        Me.TxAFechaSal.TeclaRepetida = False
        Me.TxAFechaSal.TxDatoFinalSemana = Nothing
        Me.TxAFechaSal.TxDatoInicioSemana = Nothing
        Me.TxAFechaSal.UltimoValorValidado = Nothing
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(509, 39)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(97, 16)
        Me.Lb8.TabIndex = 100280
        Me.Lb8.Text = "Desde fecha"
        '
        'TxDeFechaSal
        '
        Me.TxDeFechaSal.Autonumerico = False
        Me.TxDeFechaSal.Buscando = False
        Me.TxDeFechaSal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFechaSal.ClForm = Nothing
        Me.TxDeFechaSal.ClParam = Nothing
        Me.TxDeFechaSal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFechaSal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFechaSal.GridLin = Nothing
        Me.TxDeFechaSal.HaCambiado = False
        Me.TxDeFechaSal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFechaSal.lbbusca = Nothing
        Me.TxDeFechaSal.Location = New System.Drawing.Point(621, 34)
        Me.TxDeFechaSal.MiError = False
        Me.TxDeFechaSal.Name = "TxDeFechaSal"
        Me.TxDeFechaSal.Orden = 0
        Me.TxDeFechaSal.SaltoAlfinal = False
        Me.TxDeFechaSal.Siguiente = 0
        Me.TxDeFechaSal.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFechaSal.TabIndex = 100279
        Me.TxDeFechaSal.TeclaRepetida = False
        Me.TxDeFechaSal.TxDatoFinalSemana = Nothing
        Me.TxDeFechaSal.TxDatoInicioSemana = Nothing
        Me.TxDeFechaSal.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPorKilos)
        Me.GroupBox1.Controls.Add(Me.RbPorImporte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 46)
        Me.GroupBox1.TabIndex = 100285
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impresión"
        '
        'RbPorKilos
        '
        Me.RbPorKilos.AutoSize = True
        Me.RbPorKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPorKilos.ForeColor = System.Drawing.Color.Teal
        Me.RbPorKilos.Location = New System.Drawing.Point(125, 19)
        Me.RbPorKilos.Name = "RbPorKilos"
        Me.RbPorKilos.Size = New System.Drawing.Size(88, 20)
        Me.RbPorKilos.TabIndex = 2
        Me.RbPorKilos.Text = "Por Kilos"
        Me.RbPorKilos.UseVisualStyleBackColor = True
        '
        'RbPorImporte
        '
        Me.RbPorImporte.AutoSize = True
        Me.RbPorImporte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPorImporte.ForeColor = System.Drawing.Color.Teal
        Me.RbPorImporte.Location = New System.Drawing.Point(6, 17)
        Me.RbPorImporte.Name = "RbPorImporte"
        Me.RbPorImporte.Size = New System.Drawing.Size(113, 20)
        Me.RbPorImporte.TabIndex = 1
        Me.RbPorImporte.Text = "Por Importe"
        Me.RbPorImporte.UseVisualStyleBackColor = True
        '
        'BtBuscaParte
        '
        Me.BtBuscaParte.CL_Ancho = 0
        Me.BtBuscaParte.CL_BuscaAlb = False
        Me.BtBuscaParte.CL_campocodigo = Nothing
        Me.BtBuscaParte.CL_camponombre = Nothing
        Me.BtBuscaParte.CL_CampoOrden = "Nombre"
        Me.BtBuscaParte.CL_ch1000 = False
        Me.BtBuscaParte.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaParte.CL_ControlAsociado = Nothing
        Me.BtBuscaParte.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaParte.CL_dfecha = Nothing
        Me.BtBuscaParte.CL_Entidad = Nothing
        Me.BtBuscaParte.CL_EsId = True
        Me.BtBuscaParte.CL_Filtro = Nothing
        Me.BtBuscaParte.cl_formu = Nothing
        Me.BtBuscaParte.CL_hfecha = Nothing
        Me.BtBuscaParte.cl_ListaW = Nothing
        Me.BtBuscaParte.CL_xCentro = False
        Me.BtBuscaParte.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaParte.Location = New System.Drawing.Point(244, 12)
        Me.BtBuscaParte.Name = "BtBuscaParte"
        Me.BtBuscaParte.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaParte.TabIndex = 100286
        Me.BtBuscaParte.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Balbaranes)
        Me.GroupBox2.Controls.Add(Me.Banular)
        Me.GroupBox2.Controls.Add(Me.LbValorado)
        Me.GroupBox2.Controls.Add(Me.btPrecios)
        Me.GroupBox2.Controls.Add(Me.BtRegenerar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(954, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'Balbaranes
        '
        Me.Balbaranes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Balbaranes.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.Balbaranes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Balbaranes.Location = New System.Drawing.Point(3, 126)
        Me.Balbaranes.Name = "Balbaranes"
        Me.Balbaranes.Orden = 0
        Me.Balbaranes.PedirClave = True
        Me.Balbaranes.Size = New System.Drawing.Size(144, 30)
        Me.Balbaranes.TabIndex = 100291
        Me.Balbaranes.Text = "Ver albaranes"
        Me.Balbaranes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Balbaranes.UseVisualStyleBackColor = True
        '
        'Banular
        '
        Me.Banular.Dock = System.Windows.Forms.DockStyle.Top
        Me.Banular.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.Banular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Banular.Location = New System.Drawing.Point(3, 96)
        Me.Banular.Name = "Banular"
        Me.Banular.Orden = 0
        Me.Banular.PedirClave = True
        Me.Banular.Size = New System.Drawing.Size(144, 30)
        Me.Banular.TabIndex = 100290
        Me.Banular.Text = "Anular parte"
        Me.Banular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Banular.UseVisualStyleBackColor = True
        '
        'LbValorado
        '
        Me.LbValorado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbValorado.CL_ControlAsociado = Nothing
        Me.LbValorado.CL_ValorFijo = True
        Me.LbValorado.ClForm = Nothing
        Me.LbValorado.Dock = System.Windows.Forms.DockStyle.Top
        Me.LbValorado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValorado.ForeColor = System.Drawing.Color.Red
        Me.LbValorado.Location = New System.Drawing.Point(3, 76)
        Me.LbValorado.Name = "LbValorado"
        Me.LbValorado.Size = New System.Drawing.Size(144, 20)
        Me.LbValorado.TabIndex = 100289
        Me.LbValorado.Text = "VALORADA"
        Me.LbValorado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbValorado.Visible = False
        '
        'btPrecios
        '
        Me.btPrecios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btPrecios.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.btPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPrecios.Location = New System.Drawing.Point(3, 46)
        Me.btPrecios.Name = "btPrecios"
        Me.btPrecios.Orden = 0
        Me.btPrecios.PedirClave = True
        Me.btPrecios.Size = New System.Drawing.Size(144, 30)
        Me.btPrecios.TabIndex = 100288
        Me.btPrecios.Text = "Precios liquidación"
        Me.btPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPrecios.UseVisualStyleBackColor = True
        '
        'BtRegenerar
        '
        Me.BtRegenerar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtRegenerar.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.BtRegenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtRegenerar.Location = New System.Drawing.Point(3, 16)
        Me.BtRegenerar.Name = "BtRegenerar"
        Me.BtRegenerar.Orden = 0
        Me.BtRegenerar.PedirClave = True
        Me.BtRegenerar.Size = New System.Drawing.Size(144, 30)
        Me.BtRegenerar.TabIndex = 100285
        Me.BtRegenerar.Text = "Volver a generar parte"
        Me.BtRegenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtRegenerar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lstFamilias)
        Me.Panel1.Controls.Add(Me.chkTodos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(738, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 149)
        Me.Panel1.TabIndex = 100287
        '
        'lstFamilias
        '
        Me.lstFamilias.CheckOnClick = True
        Me.lstFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFamilias.Location = New System.Drawing.Point(0, 46)
        Me.lstFamilias.Name = "lstFamilias"
        Me.lstFamilias.Size = New System.Drawing.Size(210, 101)
        Me.lstFamilias.TabIndex = 100289
        '
        'chkTodos
        '
        Me.chkTodos.BackColor = System.Drawing.Color.White
        Me.chkTodos.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkTodos.Location = New System.Drawing.Point(0, 26)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.chkTodos.Size = New System.Drawing.Size(210, 20)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "TODOS"
        Me.chkTodos.UseVisualStyleBackColor = False
        Me.chkTodos.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FAMILIAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(236, 138)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(496, 23)
        Me.Barra.TabIndex = 100288
        '
        'BtPendiente
        '
        Me.BtPendiente.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.BtPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtPendiente.Location = New System.Drawing.Point(287, 105)
        Me.BtPendiente.Name = "BtPendiente"
        Me.BtPendiente.Orden = 0
        Me.BtPendiente.PedirClave = True
        Me.BtPendiente.Size = New System.Drawing.Size(163, 30)
        Me.BtPendiente.TabIndex = 100292
        Me.BtPendiente.Text = "Pendiente valorar"
        Me.BtPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtPendiente.UseVisualStyleBackColor = True
        '
        'ClButton1
        '
        Me.ClButton1.Image = Global.NetAgro.My.Resources.Resources.App_kservices_16x16_32
        Me.ClButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClButton1.Location = New System.Drawing.Point(514, 105)
        Me.ClButton1.Name = "ClButton1"
        Me.ClButton1.Orden = 0
        Me.ClButton1.PedirClave = True
        Me.ClButton1.Size = New System.Drawing.Size(163, 30)
        Me.ClButton1.TabIndex = 100293
        Me.ClButton1.Text = "Pendiente valorar"
        Me.ClButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClButton1.UseVisualStyleBackColor = True
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = False
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCentro.Location = New System.Drawing.Point(15, 94)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(219, 18)
        Me.LbNomCentro.TabIndex = 100303
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
        Me.BtCentro.Location = New System.Drawing.Point(201, 69)
        Me.BtCentro.Name = "BtCentro"
        Me.BtCentro.Size = New System.Drawing.Size(33, 23)
        Me.BtCentro.TabIndex = 100302
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
        Me.LbCentro.Location = New System.Drawing.Point(15, 72)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(57, 16)
        Me.LbCentro.TabIndex = 100301
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
        Me.TxCentro.Location = New System.Drawing.Point(138, 69)
        Me.TxCentro.MiError = False
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.Orden = 0
        Me.TxCentro.SaltoAlfinal = False
        Me.TxCentro.Siguiente = 0
        Me.TxCentro.Size = New System.Drawing.Size(57, 22)
        Me.TxCentro.TabIndex = 100300
        Me.TxCentro.TeclaRepetida = False
        Me.TxCentro.TxDatoFinalSemana = Nothing
        Me.TxCentro.TxDatoInicioSemana = Nothing
        Me.TxCentro.UltimoValorValidado = Nothing
        '
        'FrmParteSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmParteSemanal"
        Me.Text = "Creación parte semanal"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.lstFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxNuparte As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDeFechaEnt As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxAFechaSal As NetAgro.TxDato
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents TxDeFechaSal As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxAFechaEnt As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbPorKilos As System.Windows.Forms.RadioButton
    Friend WithEvents RbPorImporte As System.Windows.Forms.RadioButton
    Friend WithEvents BtBuscaParte As NetAgro.BtBusca
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btPrecios As NetAgro.ClButton
    Friend WithEvents BtRegenerar As NetAgro.ClButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstFamilias As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents LbValorado As NetAgro.Lb
    Friend WithEvents Banular As NetAgro.ClButton
    Friend WithEvents Balbaranes As NetAgro.ClButton
    Friend WithEvents BtPendiente As NetAgro.ClButton
    Friend WithEvents ClButton1 As NetAgro.ClButton
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents BtCentro As NetAgro.BtBusca
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents TxCentro As NetAgro.TxDato
End Class
