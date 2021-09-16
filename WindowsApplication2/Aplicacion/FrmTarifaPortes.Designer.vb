<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarifaPortes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTarifaPortes))
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBusca = New NetAgro.BtBusca(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.TxNombre = New NetAgro.TxDato(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.LbNomGasto = New NetAgro.Lb(Me.components)
        Me.BtGasto = New NetAgro.BtBusca(Me.components)
        Me.LbGasto = New NetAgro.Lb(Me.components)
        Me.TxGasto = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbPalet4 = New NetAgro.Lb(Me.components)
        Me.TxPalet4 = New NetAgro.TxDato(Me.components)
        Me.LbPalet3 = New NetAgro.Lb(Me.components)
        Me.TxPalet3 = New NetAgro.TxDato(Me.components)
        Me.LbPalet2 = New NetAgro.Lb(Me.components)
        Me.TxPalet2 = New NetAgro.TxDato(Me.components)
        Me.LbPalet1 = New NetAgro.Lb(Me.components)
        Me.TxPalet1 = New NetAgro.TxDato(Me.components)
        Me.LbEnvio = New NetAgro.Lb(Me.components)
        Me.TxEnvio = New NetAgro.TxDato(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(187, 21)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 66
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBusca
        '
        Me.BtBusca.CL_Ancho = 0
        Me.BtBusca.CL_BuscaAlb = False
        Me.BtBusca.CL_campocodigo = Nothing
        Me.BtBusca.CL_camponombre = Nothing
        Me.BtBusca.CL_CampoOrden = "Nombre"
        Me.BtBusca.CL_ch1000 = False
        Me.BtBusca.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca.CL_ControlAsociado = Me.TxCodigo
        Me.BtBusca.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca.CL_dfecha = Nothing
        Me.BtBusca.CL_Entidad = Nothing
        Me.BtBusca.CL_EsId = True
        Me.BtBusca.CL_Filtro = Nothing
        Me.BtBusca.cl_formu = Nothing
        Me.BtBusca.CL_hfecha = Nothing
        Me.BtBusca.cl_ListaW = Nothing
        Me.BtBusca.CL_xCentro = False
        Me.BtBusca.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca.Location = New System.Drawing.Point(148, 21)
        Me.BtBusca.Name = "BtBusca"
        Me.BtBusca.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca.TabIndex = 67
        Me.BtBusca.UseVisualStyleBackColor = True
        '
        'TxCodigo
        '
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(89, 21)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(53, 22)
        Me.TxCodigo.TabIndex = 60
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.TxDatoFinalSemana = Nothing
        Me.TxCodigo.TxDatoInicioSemana = Nothing
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = False
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Teal
        Me.LbNombre.Location = New System.Drawing.Point(12, 52)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(65, 16)
        Me.LbNombre.TabIndex = 63
        Me.LbNombre.Text = "Nombre"
        '
        'TxNombre
        '
        Me.TxNombre.Autonumerico = False
        Me.TxNombre.Buscando = False
        Me.TxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombre.ClForm = Nothing
        Me.TxNombre.ClParam = Nothing
        Me.TxNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNombre.GridLin = Nothing
        Me.TxNombre.HaCambiado = False
        Me.TxNombre.lbbusca = Nothing
        Me.TxNombre.Location = New System.Drawing.Point(89, 49)
        Me.TxNombre.MiError = False
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Orden = 0
        Me.TxNombre.SaltoAlfinal = False
        Me.TxNombre.Siguiente = 0
        Me.TxNombre.Size = New System.Drawing.Size(415, 22)
        Me.TxNombre.TabIndex = 62
        Me.TxNombre.TeclaRepetida = False
        Me.TxNombre.TxDatoFinalSemana = Nothing
        Me.TxNombre.TxDatoInicioSemana = Nothing
        Me.TxNombre.UltimoValorValidado = Nothing
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = False
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigo.Location = New System.Drawing.Point(12, 24)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(58, 16)
        Me.LbCodigo.TabIndex = 61
        Me.LbCodigo.Text = "Codigo"
        '
        'LbNomGasto
        '
        Me.LbNomGasto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomGasto.CL_ControlAsociado = Nothing
        Me.LbNomGasto.CL_ValorFijo = False
        Me.LbNomGasto.ClForm = Nothing
        Me.LbNomGasto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGasto.Location = New System.Drawing.Point(525, 133)
        Me.LbNomGasto.Name = "LbNomGasto"
        Me.LbNomGasto.Size = New System.Drawing.Size(271, 23)
        Me.LbNomGasto.TabIndex = 144
        Me.LbNomGasto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtGasto
        '
        Me.BtGasto.CL_Ancho = 0
        Me.BtGasto.CL_BuscaAlb = False
        Me.BtGasto.CL_campocodigo = Nothing
        Me.BtGasto.CL_camponombre = Nothing
        Me.BtGasto.CL_CampoOrden = "Nombre"
        Me.BtGasto.CL_ch1000 = False
        Me.BtGasto.CL_ConsultaSql = "Select * from familias"
        Me.BtGasto.CL_ControlAsociado = Me.TxCodigo
        Me.BtGasto.CL_DevuelveCampo = "Idfamilia"
        Me.BtGasto.CL_dfecha = Nothing
        Me.BtGasto.CL_Entidad = Nothing
        Me.BtGasto.CL_EsId = True
        Me.BtGasto.CL_Filtro = Nothing
        Me.BtGasto.cl_formu = Nothing
        Me.BtGasto.CL_hfecha = Nothing
        Me.BtGasto.cl_ListaW = Nothing
        Me.BtGasto.CL_xCentro = False
        Me.BtGasto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtGasto.Location = New System.Drawing.Point(486, 133)
        Me.BtGasto.Name = "BtGasto"
        Me.BtGasto.Size = New System.Drawing.Size(33, 23)
        Me.BtGasto.TabIndex = 143
        Me.BtGasto.UseVisualStyleBackColor = True
        '
        'LbGasto
        '
        Me.LbGasto.AutoSize = True
        Me.LbGasto.CL_ControlAsociado = Nothing
        Me.LbGasto.CL_ValorFijo = False
        Me.LbGasto.ClForm = Nothing
        Me.LbGasto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGasto.ForeColor = System.Drawing.Color.Teal
        Me.LbGasto.Location = New System.Drawing.Point(323, 136)
        Me.LbGasto.Name = "LbGasto"
        Me.LbGasto.Size = New System.Drawing.Size(54, 16)
        Me.LbGasto.TabIndex = 142
        Me.LbGasto.Text = "Gasto "
        '
        'TxGasto
        '
        Me.TxGasto.Autonumerico = False
        Me.TxGasto.Buscando = False
        Me.TxGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGasto.ClForm = Nothing
        Me.TxGasto.ClParam = Nothing
        Me.TxGasto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGasto.GridLin = Nothing
        Me.TxGasto.HaCambiado = False
        Me.TxGasto.lbbusca = Nothing
        Me.TxGasto.Location = New System.Drawing.Point(437, 133)
        Me.TxGasto.MiError = False
        Me.TxGasto.Name = "TxGasto"
        Me.TxGasto.Orden = 0
        Me.TxGasto.SaltoAlfinal = False
        Me.TxGasto.Siguiente = 0
        Me.TxGasto.Size = New System.Drawing.Size(43, 22)
        Me.TxGasto.TabIndex = 141
        Me.TxGasto.TeclaRepetida = False
        Me.TxGasto.TxDatoFinalSemana = Nothing
        Me.TxGasto.TxDatoInicioSemana = Nothing
        Me.TxGasto.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbPalet4)
        Me.GroupBox1.Controls.Add(Me.TxPalet4)
        Me.GroupBox1.Controls.Add(Me.LbPalet3)
        Me.GroupBox1.Controls.Add(Me.TxPalet3)
        Me.GroupBox1.Controls.Add(Me.LbPalet2)
        Me.GroupBox1.Controls.Add(Me.TxPalet2)
        Me.GroupBox1.Controls.Add(Me.LbPalet1)
        Me.GroupBox1.Controls.Add(Me.TxPalet1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 141)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Precios por tipo palet"
        '
        'LbPalet4
        '
        Me.LbPalet4.AutoSize = True
        Me.LbPalet4.CL_ControlAsociado = Nothing
        Me.LbPalet4.CL_ValorFijo = False
        Me.LbPalet4.ClForm = Nothing
        Me.LbPalet4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet4.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet4.Location = New System.Drawing.Point(6, 104)
        Me.LbPalet4.Name = "LbPalet4"
        Me.LbPalet4.Size = New System.Drawing.Size(58, 16)
        Me.LbPalet4.TabIndex = 153
        Me.LbPalet4.Text = "Palet 4"
        '
        'TxPalet4
        '
        Me.TxPalet4.Autonumerico = False
        Me.TxPalet4.Buscando = False
        Me.TxPalet4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet4.ClForm = Nothing
        Me.TxPalet4.ClParam = Nothing
        Me.TxPalet4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet4.GridLin = Nothing
        Me.TxPalet4.HaCambiado = False
        Me.TxPalet4.lbbusca = Nothing
        Me.TxPalet4.Location = New System.Drawing.Point(162, 101)
        Me.TxPalet4.MiError = False
        Me.TxPalet4.Name = "TxPalet4"
        Me.TxPalet4.Orden = 0
        Me.TxPalet4.SaltoAlfinal = False
        Me.TxPalet4.Siguiente = 0
        Me.TxPalet4.Size = New System.Drawing.Size(101, 22)
        Me.TxPalet4.TabIndex = 152
        Me.TxPalet4.TeclaRepetida = False
        Me.TxPalet4.TxDatoFinalSemana = Nothing
        Me.TxPalet4.TxDatoInicioSemana = Nothing
        Me.TxPalet4.UltimoValorValidado = Nothing
        '
        'LbPalet3
        '
        Me.LbPalet3.AutoSize = True
        Me.LbPalet3.CL_ControlAsociado = Nothing
        Me.LbPalet3.CL_ValorFijo = False
        Me.LbPalet3.ClForm = Nothing
        Me.LbPalet3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet3.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet3.Location = New System.Drawing.Point(6, 76)
        Me.LbPalet3.Name = "LbPalet3"
        Me.LbPalet3.Size = New System.Drawing.Size(58, 16)
        Me.LbPalet3.TabIndex = 151
        Me.LbPalet3.Text = "Palet 3"
        '
        'TxPalet3
        '
        Me.TxPalet3.Autonumerico = False
        Me.TxPalet3.Buscando = False
        Me.TxPalet3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet3.ClForm = Nothing
        Me.TxPalet3.ClParam = Nothing
        Me.TxPalet3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet3.GridLin = Nothing
        Me.TxPalet3.HaCambiado = False
        Me.TxPalet3.lbbusca = Nothing
        Me.TxPalet3.Location = New System.Drawing.Point(162, 73)
        Me.TxPalet3.MiError = False
        Me.TxPalet3.Name = "TxPalet3"
        Me.TxPalet3.Orden = 0
        Me.TxPalet3.SaltoAlfinal = False
        Me.TxPalet3.Siguiente = 0
        Me.TxPalet3.Size = New System.Drawing.Size(101, 22)
        Me.TxPalet3.TabIndex = 150
        Me.TxPalet3.TeclaRepetida = False
        Me.TxPalet3.TxDatoFinalSemana = Nothing
        Me.TxPalet3.TxDatoInicioSemana = Nothing
        Me.TxPalet3.UltimoValorValidado = Nothing
        '
        'LbPalet2
        '
        Me.LbPalet2.AutoSize = True
        Me.LbPalet2.CL_ControlAsociado = Nothing
        Me.LbPalet2.CL_ValorFijo = False
        Me.LbPalet2.ClForm = Nothing
        Me.LbPalet2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet2.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet2.Location = New System.Drawing.Point(6, 48)
        Me.LbPalet2.Name = "LbPalet2"
        Me.LbPalet2.Size = New System.Drawing.Size(58, 16)
        Me.LbPalet2.TabIndex = 149
        Me.LbPalet2.Text = "Palet 2"
        '
        'TxPalet2
        '
        Me.TxPalet2.Autonumerico = False
        Me.TxPalet2.Buscando = False
        Me.TxPalet2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet2.ClForm = Nothing
        Me.TxPalet2.ClParam = Nothing
        Me.TxPalet2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet2.GridLin = Nothing
        Me.TxPalet2.HaCambiado = False
        Me.TxPalet2.lbbusca = Nothing
        Me.TxPalet2.Location = New System.Drawing.Point(162, 45)
        Me.TxPalet2.MiError = False
        Me.TxPalet2.Name = "TxPalet2"
        Me.TxPalet2.Orden = 0
        Me.TxPalet2.SaltoAlfinal = False
        Me.TxPalet2.Siguiente = 0
        Me.TxPalet2.Size = New System.Drawing.Size(101, 22)
        Me.TxPalet2.TabIndex = 148
        Me.TxPalet2.TeclaRepetida = False
        Me.TxPalet2.TxDatoFinalSemana = Nothing
        Me.TxPalet2.TxDatoInicioSemana = Nothing
        Me.TxPalet2.UltimoValorValidado = Nothing
        '
        'LbPalet1
        '
        Me.LbPalet1.AutoSize = True
        Me.LbPalet1.CL_ControlAsociado = Nothing
        Me.LbPalet1.CL_ValorFijo = False
        Me.LbPalet1.ClForm = Nothing
        Me.LbPalet1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalet1.ForeColor = System.Drawing.Color.Teal
        Me.LbPalet1.Location = New System.Drawing.Point(6, 20)
        Me.LbPalet1.Name = "LbPalet1"
        Me.LbPalet1.Size = New System.Drawing.Size(58, 16)
        Me.LbPalet1.TabIndex = 147
        Me.LbPalet1.Text = "Palet 1"
        '
        'TxPalet1
        '
        Me.TxPalet1.Autonumerico = False
        Me.TxPalet1.Buscando = False
        Me.TxPalet1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet1.ClForm = Nothing
        Me.TxPalet1.ClParam = Nothing
        Me.TxPalet1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet1.GridLin = Nothing
        Me.TxPalet1.HaCambiado = False
        Me.TxPalet1.lbbusca = Nothing
        Me.TxPalet1.Location = New System.Drawing.Point(162, 17)
        Me.TxPalet1.MiError = False
        Me.TxPalet1.Name = "TxPalet1"
        Me.TxPalet1.Orden = 0
        Me.TxPalet1.SaltoAlfinal = False
        Me.TxPalet1.Siguiente = 0
        Me.TxPalet1.Size = New System.Drawing.Size(101, 22)
        Me.TxPalet1.TabIndex = 146
        Me.TxPalet1.TeclaRepetida = False
        Me.TxPalet1.TxDatoFinalSemana = Nothing
        Me.TxPalet1.TxDatoInicioSemana = Nothing
        Me.TxPalet1.UltimoValorValidado = Nothing
        '
        'LbEnvio
        '
        Me.LbEnvio.AutoSize = True
        Me.LbEnvio.CL_ControlAsociado = Nothing
        Me.LbEnvio.CL_ValorFijo = False
        Me.LbEnvio.ClForm = Nothing
        Me.LbEnvio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEnvio.ForeColor = System.Drawing.Color.Teal
        Me.LbEnvio.Location = New System.Drawing.Point(323, 104)
        Me.LbEnvio.Name = "LbEnvio"
        Me.LbEnvio.Size = New System.Drawing.Size(110, 16)
        Me.LbEnvio.TabIndex = 157
        Me.LbEnvio.Text = "Precio x Envio"
        '
        'TxEnvio
        '
        Me.TxEnvio.Autonumerico = False
        Me.TxEnvio.Buscando = False
        Me.TxEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEnvio.ClForm = Nothing
        Me.TxEnvio.ClParam = Nothing
        Me.TxEnvio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEnvio.GridLin = Nothing
        Me.TxEnvio.HaCambiado = False
        Me.TxEnvio.lbbusca = Nothing
        Me.TxEnvio.Location = New System.Drawing.Point(437, 101)
        Me.TxEnvio.MiError = False
        Me.TxEnvio.Name = "TxEnvio"
        Me.TxEnvio.Orden = 0
        Me.TxEnvio.SaltoAlfinal = False
        Me.TxEnvio.Siguiente = 0
        Me.TxEnvio.Size = New System.Drawing.Size(101, 22)
        Me.TxEnvio.TabIndex = 156
        Me.TxEnvio.TeclaRepetida = False
        Me.TxEnvio.TxDatoFinalSemana = Nothing
        Me.TxEnvio.TxDatoInicioSemana = Nothing
        Me.TxEnvio.UltimoValorValidado = Nothing
        '
        'FrmTarifaPortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 279)
        Me.Controls.Add(Me.LbEnvio)
        Me.Controls.Add(Me.TxEnvio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbNomGasto)
        Me.Controls.Add(Me.BtGasto)
        Me.Controls.Add(Me.LbGasto)
        Me.Controls.Add(Me.TxGasto)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBusca)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me.TxCodigo)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTarifaPortes"
        Me.Text = "Tarifa de portes"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxCodigo, 0)
        Me.Controls.SetChildIndex(Me.LbCodigo, 0)
        Me.Controls.SetChildIndex(Me.TxNombre, 0)
        Me.Controls.SetChildIndex(Me.LbNombre, 0)
        Me.Controls.SetChildIndex(Me.BtBusca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxGasto, 0)
        Me.Controls.SetChildIndex(Me.LbGasto, 0)
        Me.Controls.SetChildIndex(Me.BtGasto, 0)
        Me.Controls.SetChildIndex(Me.LbNomGasto, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxEnvio, 0)
        Me.Controls.SetChildIndex(Me.LbEnvio, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBusca As NetAgro.BtBusca
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents TxNombre As NetAgro.TxDato
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents LbNomGasto As NetAgro.Lb
    Friend WithEvents BtGasto As NetAgro.BtBusca
    Friend WithEvents LbGasto As NetAgro.Lb
    Friend WithEvents TxGasto As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbPalet4 As NetAgro.Lb
    Friend WithEvents TxPalet4 As NetAgro.TxDato
    Friend WithEvents LbPalet3 As NetAgro.Lb
    Friend WithEvents TxPalet3 As NetAgro.TxDato
    Friend WithEvents LbPalet2 As NetAgro.Lb
    Friend WithEvents TxPalet2 As NetAgro.TxDato
    Friend WithEvents LbPalet1 As NetAgro.Lb
    Friend WithEvents TxPalet1 As NetAgro.TxDato
    Friend WithEvents LbEnvio As NetAgro.Lb
    Friend WithEvents TxEnvio As NetAgro.TxDato
End Class
