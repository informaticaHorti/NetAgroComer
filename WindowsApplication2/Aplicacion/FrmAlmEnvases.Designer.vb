<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmEnvases))
        Me.LbNombre = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxNombre = New NetAgro.TxDato(Me.components)
        Me.BtBuscaFRM = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxProvincia = New NetAgro.TxDato(Me.components)
        Me.LbProvincia = New NetAgro.Lb(Me.components)
        Me.TxPoblacion = New NetAgro.TxDato(Me.components)
        Me.LbPoblacion = New NetAgro.Lb(Me.components)
        Me.LbCPostal = New NetAgro.Lb(Me.components)
        Me.TxCPostal = New NetAgro.TxDato(Me.components)
        Me.TxDomicilio = New NetAgro.TxDato(Me.components)
        Me.LbDomicilio = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.CL_ControlAsociado = Nothing
        Me.LbNombre.CL_ValorFijo = False
        Me.LbNombre.ClForm = Nothing
        Me.LbNombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Teal
        Me.LbNombre.Location = New System.Drawing.Point(15, 21)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(65, 16)
        Me.LbNombre.TabIndex = 68
        Me.LbNombre.Text = "Nombre"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(18, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Codigo"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(95, 17)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxNombre.Location = New System.Drawing.Point(99, 18)
        Me.TxNombre.MiError = False
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Orden = 0
        Me.TxNombre.SaltoAlfinal = False
        Me.TxNombre.Siguiente = 0
        Me.TxNombre.Size = New System.Drawing.Size(326, 22)
        Me.TxNombre.TabIndex = 75
        Me.TxNombre.TeclaRepetida = False
        Me.TxNombre.TxDatoFinalSemana = Nothing
        Me.TxNombre.TxDatoInicioSemana = Nothing
        Me.TxNombre.UltimoValorValidado = Nothing
        '
        'BtBuscaFRM
        '
        Me.BtBuscaFRM.CL_Ancho = 0
        Me.BtBuscaFRM.CL_BuscaAlb = False
        Me.BtBuscaFRM.CL_campocodigo = Nothing
        Me.BtBuscaFRM.CL_camponombre = Nothing
        Me.BtBuscaFRM.CL_CampoOrden = "Nombre"
        Me.BtBuscaFRM.CL_ch1000 = False
        Me.BtBuscaFRM.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFRM.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaFRM.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFRM.CL_dfecha = Nothing
        Me.BtBuscaFRM.CL_Entidad = Nothing
        Me.BtBuscaFRM.CL_EsId = True
        Me.BtBuscaFRM.CL_Filtro = Nothing
        Me.BtBuscaFRM.cl_formu = Nothing
        Me.BtBuscaFRM.CL_hfecha = Nothing
        Me.BtBuscaFRM.cl_ListaW = Nothing
        Me.BtBuscaFRM.CL_xCentro = False
        Me.BtBuscaFRM.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaFRM.Location = New System.Drawing.Point(147, 17)
        Me.BtBuscaFRM.Name = "BtBuscaFRM"
        Me.BtBuscaFRM.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFRM.TabIndex = 76
        Me.BtBuscaFRM.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(186, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.TxProvincia)
        Me.Panel2.Controls.Add(Me.LbProvincia)
        Me.Panel2.Controls.Add(Me.TxPoblacion)
        Me.Panel2.Controls.Add(Me.TxNombre)
        Me.Panel2.Controls.Add(Me.LbPoblacion)
        Me.Panel2.Controls.Add(Me.LbCPostal)
        Me.Panel2.Controls.Add(Me.LbNombre)
        Me.Panel2.Controls.Add(Me.TxCPostal)
        Me.Panel2.Controls.Add(Me.TxDomicilio)
        Me.Panel2.Controls.Add(Me.LbDomicilio)
        Me.Panel2.Location = New System.Drawing.Point(21, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(710, 129)
        Me.Panel2.TabIndex = 78
        '
        'TxProvincia
        '
        Me.TxProvincia.Autonumerico = False
        Me.TxProvincia.Buscando = False
        Me.TxProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxProvincia.ClForm = Nothing
        Me.TxProvincia.ClParam = Nothing
        Me.TxProvincia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxProvincia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxProvincia.GridLin = Nothing
        Me.TxProvincia.HaCambiado = False
        Me.TxProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxProvincia.lbbusca = Nothing
        Me.TxProvincia.Location = New System.Drawing.Point(499, 84)
        Me.TxProvincia.MiError = False
        Me.TxProvincia.Name = "TxProvincia"
        Me.TxProvincia.Orden = 0
        Me.TxProvincia.SaltoAlfinal = False
        Me.TxProvincia.Siguiente = 0
        Me.TxProvincia.Size = New System.Drawing.Size(190, 22)
        Me.TxProvincia.TabIndex = 94
        Me.TxProvincia.TeclaRepetida = False
        Me.TxProvincia.TxDatoFinalSemana = Nothing
        Me.TxProvincia.TxDatoInicioSemana = Nothing
        Me.TxProvincia.UltimoValorValidado = Nothing
        '
        'LbProvincia
        '
        Me.LbProvincia.AutoSize = True
        Me.LbProvincia.CL_ControlAsociado = Nothing
        Me.LbProvincia.CL_ValorFijo = False
        Me.LbProvincia.ClForm = Nothing
        Me.LbProvincia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProvincia.ForeColor = System.Drawing.Color.Teal
        Me.LbProvincia.Location = New System.Drawing.Point(415, 87)
        Me.LbProvincia.Name = "LbProvincia"
        Me.LbProvincia.Size = New System.Drawing.Size(75, 16)
        Me.LbProvincia.TabIndex = 93
        Me.LbProvincia.Text = "Provincia"
        '
        'TxPoblacion
        '
        Me.TxPoblacion.Autonumerico = False
        Me.TxPoblacion.Buscando = False
        Me.TxPoblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPoblacion.ClForm = Nothing
        Me.TxPoblacion.ClParam = Nothing
        Me.TxPoblacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPoblacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPoblacion.GridLin = Nothing
        Me.TxPoblacion.HaCambiado = False
        Me.TxPoblacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPoblacion.lbbusca = Nothing
        Me.TxPoblacion.Location = New System.Drawing.Point(99, 84)
        Me.TxPoblacion.MiError = False
        Me.TxPoblacion.Name = "TxPoblacion"
        Me.TxPoblacion.Orden = 0
        Me.TxPoblacion.SaltoAlfinal = False
        Me.TxPoblacion.Siguiente = 0
        Me.TxPoblacion.Size = New System.Drawing.Size(289, 22)
        Me.TxPoblacion.TabIndex = 92
        Me.TxPoblacion.TeclaRepetida = False
        Me.TxPoblacion.TxDatoFinalSemana = Nothing
        Me.TxPoblacion.TxDatoInicioSemana = Nothing
        Me.TxPoblacion.UltimoValorValidado = Nothing
        '
        'LbPoblacion
        '
        Me.LbPoblacion.AutoSize = True
        Me.LbPoblacion.CL_ControlAsociado = Nothing
        Me.LbPoblacion.CL_ValorFijo = False
        Me.LbPoblacion.ClForm = Nothing
        Me.LbPoblacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPoblacion.ForeColor = System.Drawing.Color.Teal
        Me.LbPoblacion.Location = New System.Drawing.Point(15, 87)
        Me.LbPoblacion.Name = "LbPoblacion"
        Me.LbPoblacion.Size = New System.Drawing.Size(78, 16)
        Me.LbPoblacion.TabIndex = 91
        Me.LbPoblacion.Text = "Población"
        '
        'LbCPostal
        '
        Me.LbCPostal.AutoSize = True
        Me.LbCPostal.CL_ControlAsociado = Nothing
        Me.LbCPostal.CL_ValorFijo = False
        Me.LbCPostal.ClForm = Nothing
        Me.LbCPostal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCPostal.ForeColor = System.Drawing.Color.Teal
        Me.LbCPostal.Location = New System.Drawing.Point(508, 54)
        Me.LbCPostal.Name = "LbCPostal"
        Me.LbCPostal.Size = New System.Drawing.Size(72, 16)
        Me.LbCPostal.TabIndex = 90
        Me.LbCPostal.Text = "C. Postal"
        '
        'TxCPostal
        '
        Me.TxCPostal.Autonumerico = False
        Me.TxCPostal.Buscando = False
        Me.TxCPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCPostal.ClForm = Nothing
        Me.TxCPostal.ClParam = Nothing
        Me.TxCPostal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCPostal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCPostal.GridLin = Nothing
        Me.TxCPostal.HaCambiado = False
        Me.TxCPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCPostal.lbbusca = Nothing
        Me.TxCPostal.Location = New System.Drawing.Point(586, 51)
        Me.TxCPostal.MiError = False
        Me.TxCPostal.Name = "TxCPostal"
        Me.TxCPostal.Orden = 0
        Me.TxCPostal.SaltoAlfinal = False
        Me.TxCPostal.Siguiente = 0
        Me.TxCPostal.Size = New System.Drawing.Size(103, 22)
        Me.TxCPostal.TabIndex = 89
        Me.TxCPostal.TeclaRepetida = False
        Me.TxCPostal.TxDatoFinalSemana = Nothing
        Me.TxCPostal.TxDatoInicioSemana = Nothing
        Me.TxCPostal.UltimoValorValidado = Nothing
        '
        'TxDomicilio
        '
        Me.TxDomicilio.Autonumerico = False
        Me.TxDomicilio.Buscando = False
        Me.TxDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDomicilio.ClForm = Nothing
        Me.TxDomicilio.ClParam = Nothing
        Me.TxDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDomicilio.GridLin = Nothing
        Me.TxDomicilio.HaCambiado = False
        Me.TxDomicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDomicilio.lbbusca = Nothing
        Me.TxDomicilio.Location = New System.Drawing.Point(99, 51)
        Me.TxDomicilio.MiError = False
        Me.TxDomicilio.Name = "TxDomicilio"
        Me.TxDomicilio.Orden = 0
        Me.TxDomicilio.SaltoAlfinal = False
        Me.TxDomicilio.Siguiente = 0
        Me.TxDomicilio.Size = New System.Drawing.Size(394, 22)
        Me.TxDomicilio.TabIndex = 88
        Me.TxDomicilio.TeclaRepetida = False
        Me.TxDomicilio.TxDatoFinalSemana = Nothing
        Me.TxDomicilio.TxDatoInicioSemana = Nothing
        Me.TxDomicilio.UltimoValorValidado = Nothing
        '
        'LbDomicilio
        '
        Me.LbDomicilio.AutoSize = True
        Me.LbDomicilio.CL_ControlAsociado = Nothing
        Me.LbDomicilio.CL_ValorFijo = False
        Me.LbDomicilio.ClForm = Nothing
        Me.LbDomicilio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilio.ForeColor = System.Drawing.Color.Teal
        Me.LbDomicilio.Location = New System.Drawing.Point(15, 54)
        Me.LbDomicilio.Name = "LbDomicilio"
        Me.LbDomicilio.Size = New System.Drawing.Size(74, 16)
        Me.LbDomicilio.TabIndex = 87
        Me.LbDomicilio.Text = "Domicilio"
        '
        'FrmAlmEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 252)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaFRM)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAlmEnvases"
        Me.Text = "Almacenes de envases"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaFRM, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbNombre As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxNombre As NetAgro.TxDato
    Friend WithEvents BtBuscaFRM As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxProvincia As NetAgro.TxDato
    Friend WithEvents LbProvincia As NetAgro.Lb
    Friend WithEvents TxPoblacion As NetAgro.TxDato
    Friend WithEvents LbPoblacion As NetAgro.Lb
    Friend WithEvents LbCPostal As NetAgro.Lb
    Friend WithEvents TxCPostal As NetAgro.TxDato
    Friend WithEvents TxDomicilio As NetAgro.TxDato
    Friend WithEvents LbDomicilio As NetAgro.Lb
End Class
