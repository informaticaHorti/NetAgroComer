<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIBANAgricultores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIBANAgricultores))
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxIBAN = New NetAgro.TxDato(Me.components)
        Me.LbIBAN = New NetAgro.Lb(Me.components)
        Me.TxEntidad = New NetAgro.TxDato(Me.components)
        Me.LbEntidad = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(23, 24)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 66
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
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(109, 21)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(46, 22)
        Me.TxAgricultor.TabIndex = 74
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(161, 21)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 76
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(200, 20)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxIBAN
        '
        Me.TxIBAN.Autonumerico = False
        Me.TxIBAN.Buscando = False
        Me.TxIBAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIBAN.ClForm = Nothing
        Me.TxIBAN.ClParam = Nothing
        Me.TxIBAN.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIBAN.GridLin = Nothing
        Me.TxIBAN.HaCambiado = False
        Me.TxIBAN.lbbusca = Nothing
        Me.TxIBAN.Location = New System.Drawing.Point(97, 56)
        Me.TxIBAN.MiError = False
        Me.TxIBAN.Name = "TxIBAN"
        Me.TxIBAN.Orden = 0
        Me.TxIBAN.SaltoAlfinal = False
        Me.TxIBAN.Siguiente = 0
        Me.TxIBAN.Size = New System.Drawing.Size(275, 22)
        Me.TxIBAN.TabIndex = 111
        Me.TxIBAN.TeclaRepetida = False
        Me.TxIBAN.TxDatoFinalSemana = Nothing
        Me.TxIBAN.TxDatoInicioSemana = Nothing
        Me.TxIBAN.UltimoValorValidado = Nothing
        '
        'LbIBAN
        '
        Me.LbIBAN.AutoSize = True
        Me.LbIBAN.CL_ControlAsociado = Nothing
        Me.LbIBAN.CL_ValorFijo = False
        Me.LbIBAN.ClForm = Nothing
        Me.LbIBAN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIBAN.ForeColor = System.Drawing.Color.Teal
        Me.LbIBAN.Location = New System.Drawing.Point(27, 59)
        Me.LbIBAN.Name = "LbIBAN"
        Me.LbIBAN.Size = New System.Drawing.Size(44, 16)
        Me.LbIBAN.TabIndex = 109
        Me.LbIBAN.Text = "IBAN"
        '
        'TxEntidad
        '
        Me.TxEntidad.Autonumerico = False
        Me.TxEntidad.Buscando = False
        Me.TxEntidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEntidad.ClForm = Nothing
        Me.TxEntidad.ClParam = Nothing
        Me.TxEntidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEntidad.GridLin = Nothing
        Me.TxEntidad.HaCambiado = False
        Me.TxEntidad.lbbusca = Nothing
        Me.TxEntidad.Location = New System.Drawing.Point(97, 26)
        Me.TxEntidad.MiError = False
        Me.TxEntidad.Name = "TxEntidad"
        Me.TxEntidad.Orden = 0
        Me.TxEntidad.SaltoAlfinal = False
        Me.TxEntidad.Siguiente = 0
        Me.TxEntidad.Size = New System.Drawing.Size(385, 22)
        Me.TxEntidad.TabIndex = 107
        Me.TxEntidad.TeclaRepetida = False
        Me.TxEntidad.TxDatoFinalSemana = Nothing
        Me.TxEntidad.TxDatoInicioSemana = Nothing
        Me.TxEntidad.UltimoValorValidado = Nothing
        '
        'LbEntidad
        '
        Me.LbEntidad.AutoSize = True
        Me.LbEntidad.CL_ControlAsociado = Nothing
        Me.LbEntidad.CL_ValorFijo = False
        Me.LbEntidad.ClForm = Nothing
        Me.LbEntidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntidad.ForeColor = System.Drawing.Color.Teal
        Me.LbEntidad.Location = New System.Drawing.Point(27, 29)
        Me.LbEntidad.Name = "LbEntidad"
        Me.LbEntidad.Size = New System.Drawing.Size(63, 16)
        Me.LbEntidad.TabIndex = 105
        Me.LbEntidad.Text = "Entidad"
        '
        'LbNomAgricultor
        '
        Me.LbNomAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomAgricultor.CL_ValorFijo = False
        Me.LbNomAgricultor.ClForm = Nothing
        Me.LbNomAgricultor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultor.Location = New System.Drawing.Point(109, 52)
        Me.LbNomAgricultor.Name = "LbNomAgricultor"
        Me.LbNomAgricultor.Size = New System.Drawing.Size(474, 21)
        Me.LbNomAgricultor.TabIndex = 215
        Me.LbNomAgricultor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = True
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Teal
        Me.LbNombre.Location = New System.Drawing.Point(23, 52)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(65, 16)
        Me.LbNombre.TabIndex = 216
        Me.LbNombre.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbEntidad)
        Me.GroupBox1.Controls.Add(Me.TxEntidad)
        Me.GroupBox1.Controls.Add(Me.TxIBAN)
        Me.GroupBox1.Controls.Add(Me.LbIBAN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 100)
        Me.GroupBox1.TabIndex = 217
        Me.GroupBox1.TabStop = False
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 191)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.Padding = New System.Windows.Forms.Padding(5)
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(654, 212)
        Me.ClGrid1.TabIndex = 218
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmIBANAgricultores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 437)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.LbNomAgricultor)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaAgricultor)
        Me.Controls.Add(Me.TxAgricultor)
        Me.Controls.Add(Me.LbAgricultor)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmIBANAgricultores"
        Me.Text = "Asignar IBAN a Agricultor"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbAgricultor, 0)
        Me.Controls.SetChildIndex(Me.TxAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.LbNomAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbNombre, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxIBAN As NetAgro.TxDato
    Friend WithEvents LbIBAN As NetAgro.Lb
    Friend WithEvents TxEntidad As NetAgro.TxDato
    Friend WithEvents LbEntidad As NetAgro.Lb
    Friend WithEvents LbNomAgricultor As NetAgro.Lb
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
End Class
