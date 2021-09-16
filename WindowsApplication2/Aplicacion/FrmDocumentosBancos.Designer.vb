<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentosBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentosBancos))
        Me.LbBanco = New NetAgro.Lb(Me.components)
        Me.TxBanco = New NetAgro.TxDato(Me.components)
        Me.BtBuscaBanco = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxNombreArchivo = New NetAgro.TxDato(Me.components)
        Me.LbNombreArchivo = New NetAgro.Lb(Me.components)
        Me.TxTipoDocumento = New NetAgro.TxDato(Me.components)
        Me.LbTipoDocumento = New NetAgro.Lb(Me.components)
        Me.TxAlias = New NetAgro.TxDato(Me.components)
        Me.LbAlias = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.btArchivo = New System.Windows.Forms.Button()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.LbNumeroCuenta = New NetAgro.Lb(Me.components)
        Me.Lb_NombreBanco = New NetAgro.Lb(Me.components)
        Me.Lb_NumeroCuenta = New NetAgro.Lb(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbBanco
        '
        Me.LbBanco.AutoSize = True
        Me.LbBanco.CL_ControlAsociado = Nothing
        Me.LbBanco.CL_ValorFijo = False
        Me.LbBanco.ClForm = Nothing
        Me.LbBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBanco.ForeColor = System.Drawing.Color.Teal
        Me.LbBanco.Location = New System.Drawing.Point(12, 17)
        Me.LbBanco.Name = "LbBanco"
        Me.LbBanco.Size = New System.Drawing.Size(53, 16)
        Me.LbBanco.TabIndex = 66
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
        Me.TxBanco.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBanco.GridLin = Nothing
        Me.TxBanco.HaCambiado = False
        Me.TxBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxBanco.lbbusca = Nothing
        Me.TxBanco.Location = New System.Drawing.Point(71, 14)
        Me.TxBanco.MiError = False
        Me.TxBanco.Name = "TxBanco"
        Me.TxBanco.Orden = 0
        Me.TxBanco.SaltoAlfinal = False
        Me.TxBanco.Siguiente = 0
        Me.TxBanco.Size = New System.Drawing.Size(46, 22)
        Me.TxBanco.TabIndex = 74
        Me.TxBanco.TeclaRepetida = False
        Me.TxBanco.TxDatoFinalSemana = Nothing
        Me.TxBanco.TxDatoInicioSemana = Nothing
        Me.TxBanco.UltimoValorValidado = Nothing
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
        Me.BtBuscaBanco.CL_ControlAsociado = Me.TxBanco
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
        Me.BtBuscaBanco.Location = New System.Drawing.Point(134, 13)
        Me.BtBuscaBanco.Name = "BtBuscaBanco"
        Me.BtBuscaBanco.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaBanco.TabIndex = 76
        Me.BtBuscaBanco.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(173, 13)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxNombreArchivo
        '
        Me.TxNombreArchivo.Autonumerico = False
        Me.TxNombreArchivo.Buscando = False
        Me.TxNombreArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombreArchivo.ClForm = Nothing
        Me.TxNombreArchivo.ClParam = Nothing
        Me.TxNombreArchivo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNombreArchivo.GridLin = Nothing
        Me.TxNombreArchivo.HaCambiado = False
        Me.TxNombreArchivo.lbbusca = Nothing
        Me.TxNombreArchivo.Location = New System.Drawing.Point(162, 60)
        Me.TxNombreArchivo.MiError = False
        Me.TxNombreArchivo.Name = "TxNombreArchivo"
        Me.TxNombreArchivo.Orden = 0
        Me.TxNombreArchivo.ReadOnly = True
        Me.TxNombreArchivo.SaltoAlfinal = False
        Me.TxNombreArchivo.Siguiente = 0
        Me.TxNombreArchivo.Size = New System.Drawing.Size(427, 22)
        Me.TxNombreArchivo.TabIndex = 127
        Me.TxNombreArchivo.TeclaRepetida = False
        Me.TxNombreArchivo.TxDatoFinalSemana = Nothing
        Me.TxNombreArchivo.TxDatoInicioSemana = Nothing
        Me.TxNombreArchivo.UltimoValorValidado = Nothing
        '
        'LbNombreArchivo
        '
        Me.LbNombreArchivo.AutoSize = True
        Me.LbNombreArchivo.CL_ControlAsociado = Nothing
        Me.LbNombreArchivo.CL_ValorFijo = False
        Me.LbNombreArchivo.ClForm = Nothing
        Me.LbNombreArchivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreArchivo.ForeColor = System.Drawing.Color.Teal
        Me.LbNombreArchivo.Location = New System.Drawing.Point(10, 63)
        Me.LbNombreArchivo.Name = "LbNombreArchivo"
        Me.LbNombreArchivo.Size = New System.Drawing.Size(149, 16)
        Me.LbNombreArchivo.TabIndex = 125
        Me.LbNombreArchivo.Text = "Nombre del archivo"
        '
        'TxTipoDocumento
        '
        Me.TxTipoDocumento.Autonumerico = False
        Me.TxTipoDocumento.Buscando = False
        Me.TxTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTipoDocumento.ClForm = Nothing
        Me.TxTipoDocumento.ClParam = Nothing
        Me.TxTipoDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipoDocumento.GridLin = Nothing
        Me.TxTipoDocumento.HaCambiado = False
        Me.TxTipoDocumento.lbbusca = Nothing
        Me.TxTipoDocumento.Location = New System.Drawing.Point(162, 90)
        Me.TxTipoDocumento.MiError = False
        Me.TxTipoDocumento.Name = "TxTipoDocumento"
        Me.TxTipoDocumento.Orden = 0
        Me.TxTipoDocumento.SaltoAlfinal = False
        Me.TxTipoDocumento.Siguiente = 0
        Me.TxTipoDocumento.Size = New System.Drawing.Size(202, 22)
        Me.TxTipoDocumento.TabIndex = 123
        Me.TxTipoDocumento.TeclaRepetida = False
        Me.TxTipoDocumento.TxDatoFinalSemana = Nothing
        Me.TxTipoDocumento.TxDatoInicioSemana = Nothing
        Me.TxTipoDocumento.UltimoValorValidado = Nothing
        '
        'LbTipoDocumento
        '
        Me.LbTipoDocumento.AutoSize = True
        Me.LbTipoDocumento.CL_ControlAsociado = Nothing
        Me.LbTipoDocumento.CL_ValorFijo = False
        Me.LbTipoDocumento.ClForm = Nothing
        Me.LbTipoDocumento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoDocumento.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoDocumento.Location = New System.Drawing.Point(10, 93)
        Me.LbTipoDocumento.Name = "LbTipoDocumento"
        Me.LbTipoDocumento.Size = New System.Drawing.Size(146, 16)
        Me.LbTipoDocumento.TabIndex = 121
        Me.LbTipoDocumento.Text = "Tipo de documento"
        '
        'TxAlias
        '
        Me.TxAlias.Autonumerico = False
        Me.TxAlias.Buscando = False
        Me.TxAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlias.ClForm = Nothing
        Me.TxAlias.ClParam = Nothing
        Me.TxAlias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlias.GridLin = Nothing
        Me.TxAlias.HaCambiado = False
        Me.TxAlias.lbbusca = Nothing
        Me.TxAlias.Location = New System.Drawing.Point(69, 30)
        Me.TxAlias.MiError = False
        Me.TxAlias.Name = "TxAlias"
        Me.TxAlias.Orden = 0
        Me.TxAlias.SaltoAlfinal = False
        Me.TxAlias.Siguiente = 0
        Me.TxAlias.Size = New System.Drawing.Size(520, 22)
        Me.TxAlias.TabIndex = 119
        Me.TxAlias.TeclaRepetida = False
        Me.TxAlias.TxDatoFinalSemana = Nothing
        Me.TxAlias.TxDatoInicioSemana = Nothing
        Me.TxAlias.UltimoValorValidado = Nothing
        '
        'LbAlias
        '
        Me.LbAlias.AutoSize = True
        Me.LbAlias.CL_ControlAsociado = Nothing
        Me.LbAlias.CL_ValorFijo = False
        Me.LbAlias.ClForm = Nothing
        Me.LbAlias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlias.ForeColor = System.Drawing.Color.Teal
        Me.LbAlias.Location = New System.Drawing.Point(10, 33)
        Me.LbAlias.Name = "LbAlias"
        Me.LbAlias.Size = New System.Drawing.Size(43, 16)
        Me.LbAlias.TabIndex = 117
        Me.LbAlias.Text = "Alias"
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 317)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(683, 228)
        Me.ClGrid1.TabIndex = 129
        Me.ClGrid1.UltimoControl = 0
        '
        'btArchivo
        '
        Me.btArchivo.Location = New System.Drawing.Point(596, 60)
        Me.btArchivo.Name = "btArchivo"
        Me.btArchivo.Size = New System.Drawing.Size(29, 22)
        Me.btArchivo.TabIndex = 130
        Me.btArchivo.Text = "..."
        Me.btArchivo.UseVisualStyleBackColor = True
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LbAlias)
        Me.GroupBox1.Controls.Add(Me.btArchivo)
        Me.GroupBox1.Controls.Add(Me.TxAlias)
        Me.GroupBox1.Controls.Add(Me.LbTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.TxNombreArchivo)
        Me.GroupBox1.Controls.Add(Me.TxTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.LbNombreArchivo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 131)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = True
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Teal
        Me.LbNombre.Location = New System.Drawing.Point(12, 59)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(65, 16)
        Me.LbNombre.TabIndex = 132
        Me.LbNombre.Text = "Nombre"
        '
        'LbNumeroCuenta
        '
        Me.LbNumeroCuenta.AutoSize = True
        Me.LbNumeroCuenta.CL_ControlAsociado = Nothing
        Me.LbNumeroCuenta.CL_ValorFijo = True
        Me.LbNumeroCuenta.ClForm = Nothing
        Me.LbNumeroCuenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumeroCuenta.ForeColor = System.Drawing.Color.Teal
        Me.LbNumeroCuenta.Location = New System.Drawing.Point(12, 89)
        Me.LbNumeroCuenta.Name = "LbNumeroCuenta"
        Me.LbNumeroCuenta.Size = New System.Drawing.Size(82, 16)
        Me.LbNumeroCuenta.TabIndex = 133
        Me.LbNumeroCuenta.Text = "Nº Cuenta"
        '
        'Lb_NombreBanco
        '
        Me.Lb_NombreBanco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_NombreBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_NombreBanco.CL_ControlAsociado = Nothing
        Me.Lb_NombreBanco.CL_ValorFijo = False
        Me.Lb_NombreBanco.ClForm = Nothing
        Me.Lb_NombreBanco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NombreBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_NombreBanco.Location = New System.Drawing.Point(105, 56)
        Me.Lb_NombreBanco.Name = "Lb_NombreBanco"
        Me.Lb_NombreBanco.Size = New System.Drawing.Size(402, 22)
        Me.Lb_NombreBanco.TabIndex = 100280
        '
        'Lb_NumeroCuenta
        '
        Me.Lb_NumeroCuenta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_NumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_NumeroCuenta.CL_ControlAsociado = Nothing
        Me.Lb_NumeroCuenta.CL_ValorFijo = False
        Me.Lb_NumeroCuenta.ClForm = Nothing
        Me.Lb_NumeroCuenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NumeroCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_NumeroCuenta.Location = New System.Drawing.Point(105, 86)
        Me.Lb_NumeroCuenta.Name = "Lb_NumeroCuenta"
        Me.Lb_NumeroCuenta.Size = New System.Drawing.Size(287, 22)
        Me.Lb_NumeroCuenta.TabIndex = 100281
        '
        'FrmDocumentosBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 579)
        Me.Controls.Add(Me.Lb_NumeroCuenta)
        Me.Controls.Add(Me.Lb_NombreBanco)
        Me.Controls.Add(Me.LbNumeroCuenta)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaBanco)
        Me.Controls.Add(Me.TxBanco)
        Me.Controls.Add(Me.LbBanco)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmDocumentosBancos"
        Me.Text = "Definicion de documentos bancarios"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbBanco, 0)
        Me.Controls.SetChildIndex(Me.TxBanco, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaBanco, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.LbNombre, 0)
        Me.Controls.SetChildIndex(Me.LbNumeroCuenta, 0)
        Me.Controls.SetChildIndex(Me.Lb_NombreBanco, 0)
        Me.Controls.SetChildIndex(Me.Lb_NumeroCuenta, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbBanco As NetAgro.Lb
    Friend WithEvents TxBanco As NetAgro.TxDato
    Friend WithEvents BtBuscaBanco As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxNombreArchivo As NetAgro.TxDato
    Friend WithEvents LbNombreArchivo As NetAgro.Lb
    Friend WithEvents TxTipoDocumento As NetAgro.TxDato
    Friend WithEvents LbTipoDocumento As NetAgro.Lb
    Friend WithEvents TxAlias As NetAgro.TxDato
    Friend WithEvents LbAlias As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents btArchivo As System.Windows.Forms.Button
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents LbNumeroCuenta As NetAgro.Lb
    Friend WithEvents Lb_NombreBanco As NetAgro.Lb
    Friend WithEvents Lb_NumeroCuenta As NetAgro.Lb
End Class
