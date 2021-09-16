<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoticiasWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNoticiasWeb))
        Me.BtBuscaNoticias = New NetAgro.BtBusca(Me.components)
        Me.LbTitular = New NetAgro.Lb(Me.components)
        Me.TxTitular = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxId = New NetAgro.TxDato(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.LbAdjunto = New NetAgro.Lb(Me.components)
        Me.TxAdjunto = New NetAgro.TxDato(Me.components)
        Me.BtAdjunto = New System.Windows.Forms.Button()
        Me.LbNoticia = New NetAgro.Lb(Me.components)
        Me.TxNoticia = New NetAgro.TxDato(Me.components)
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BtBuscaNoticias
        '
        Me.BtBuscaNoticias.CL_Ancho = 0
        Me.BtBuscaNoticias.CL_BuscaAlb = False
        Me.BtBuscaNoticias.CL_campocodigo = Nothing
        Me.BtBuscaNoticias.CL_camponombre = Nothing
        Me.BtBuscaNoticias.CL_CampoOrden = "Nombre"
        Me.BtBuscaNoticias.CL_ch1000 = False
        Me.BtBuscaNoticias.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaNoticias.CL_ControlAsociado = Nothing
        Me.BtBuscaNoticias.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaNoticias.CL_dfecha = Nothing
        Me.BtBuscaNoticias.CL_Entidad = Nothing
        Me.BtBuscaNoticias.CL_EsId = True
        Me.BtBuscaNoticias.CL_Filtro = Nothing
        Me.BtBuscaNoticias.cl_formu = Nothing
        Me.BtBuscaNoticias.CL_hfecha = Nothing
        Me.BtBuscaNoticias.cl_ListaW = Nothing
        Me.BtBuscaNoticias.CL_xCentro = False
        Me.BtBuscaNoticias.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaNoticias.Location = New System.Drawing.Point(151, 12)
        Me.BtBuscaNoticias.Name = "BtBuscaNoticias"
        Me.BtBuscaNoticias.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaNoticias.TabIndex = 39
        Me.BtBuscaNoticias.UseVisualStyleBackColor = True
        '
        'LbTitular
        '
        Me.LbTitular.AutoSize = True
        Me.LbTitular.CL_ControlAsociado = Nothing
        Me.LbTitular.CL_ValorFijo = False
        Me.LbTitular.ClForm = Nothing
        Me.LbTitular.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitular.ForeColor = System.Drawing.Color.Teal
        Me.LbTitular.Location = New System.Drawing.Point(12, 105)
        Me.LbTitular.Name = "LbTitular"
        Me.LbTitular.Size = New System.Drawing.Size(54, 16)
        Me.LbTitular.TabIndex = 38
        Me.LbTitular.Text = "Titular"
        '
        'TxTitular
        '
        Me.TxTitular.Autonumerico = False
        Me.TxTitular.Buscando = False
        Me.TxTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTitular.ClForm = Nothing
        Me.TxTitular.ClParam = Nothing
        Me.TxTitular.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTitular.GridLin = Nothing
        Me.TxTitular.HaCambiado = False
        Me.TxTitular.lbbusca = Nothing
        Me.TxTitular.Location = New System.Drawing.Point(82, 102)
        Me.TxTitular.MiError = False
        Me.TxTitular.Name = "TxTitular"
        Me.TxTitular.Orden = 0
        Me.TxTitular.SaltoAlfinal = False
        Me.TxTitular.Siguiente = 0
        Me.TxTitular.Size = New System.Drawing.Size(479, 22)
        Me.TxTitular.TabIndex = 37
        Me.TxTitular.TeclaRepetida = False
        Me.TxTitular.TxDatoFinalSemana = Nothing
        Me.TxTitular.TxDatoInicioSemana = Nothing
        Me.TxTitular.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(190, 11)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 35
        Me.BotonesAvance1.Udato = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 15)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(23, 16)
        Me.Lb1.TabIndex = 36
        Me.Lb1.Text = "Id"
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
        Me.TxId.Location = New System.Drawing.Point(82, 12)
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
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(12, 69)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(50, 16)
        Me.LbFecha.TabIndex = 42
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
        Me.TxFecha.Location = New System.Drawing.Point(82, 66)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(111, 22)
        Me.TxFecha.TabIndex = 41
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'LbAdjunto
        '
        Me.LbAdjunto.AutoSize = True
        Me.LbAdjunto.CL_ControlAsociado = Nothing
        Me.LbAdjunto.CL_ValorFijo = False
        Me.LbAdjunto.ClForm = Nothing
        Me.LbAdjunto.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAdjunto.ForeColor = System.Drawing.Color.Teal
        Me.LbAdjunto.Location = New System.Drawing.Point(12, 138)
        Me.LbAdjunto.Name = "LbAdjunto"
        Me.LbAdjunto.Size = New System.Drawing.Size(64, 16)
        Me.LbAdjunto.TabIndex = 44
        Me.LbAdjunto.Text = "Adjunto"
        '
        'TxAdjunto
        '
        Me.TxAdjunto.Autonumerico = False
        Me.TxAdjunto.Buscando = False
        Me.TxAdjunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAdjunto.ClForm = Nothing
        Me.TxAdjunto.ClParam = Nothing
        Me.TxAdjunto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAdjunto.GridLin = Nothing
        Me.TxAdjunto.HaCambiado = False
        Me.TxAdjunto.lbbusca = Nothing
        Me.TxAdjunto.Location = New System.Drawing.Point(82, 135)
        Me.TxAdjunto.MiError = False
        Me.TxAdjunto.Name = "TxAdjunto"
        Me.TxAdjunto.Orden = 0
        Me.TxAdjunto.ReadOnly = True
        Me.TxAdjunto.SaltoAlfinal = False
        Me.TxAdjunto.Siguiente = 0
        Me.TxAdjunto.Size = New System.Drawing.Size(436, 22)
        Me.TxAdjunto.TabIndex = 43
        Me.TxAdjunto.TeclaRepetida = False
        Me.TxAdjunto.TxDatoFinalSemana = Nothing
        Me.TxAdjunto.TxDatoInicioSemana = Nothing
        Me.TxAdjunto.UltimoValorValidado = Nothing
        '
        'BtAdjunto
        '
        Me.BtAdjunto.Location = New System.Drawing.Point(524, 135)
        Me.BtAdjunto.Name = "BtAdjunto"
        Me.BtAdjunto.Size = New System.Drawing.Size(37, 23)
        Me.BtAdjunto.TabIndex = 45
        Me.BtAdjunto.Text = "..."
        Me.BtAdjunto.UseVisualStyleBackColor = True
        '
        'LbNoticia
        '
        Me.LbNoticia.AutoSize = True
        Me.LbNoticia.CL_ControlAsociado = Nothing
        Me.LbNoticia.CL_ValorFijo = False
        Me.LbNoticia.ClForm = Nothing
        Me.LbNoticia.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNoticia.ForeColor = System.Drawing.Color.Teal
        Me.LbNoticia.Location = New System.Drawing.Point(12, 171)
        Me.LbNoticia.Name = "LbNoticia"
        Me.LbNoticia.Size = New System.Drawing.Size(57, 16)
        Me.LbNoticia.TabIndex = 46
        Me.LbNoticia.Text = "Noticia"
        '
        'TxNoticia
        '
        Me.TxNoticia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxNoticia.Autonumerico = False
        Me.TxNoticia.Buscando = False
        Me.TxNoticia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNoticia.ClForm = Nothing
        Me.TxNoticia.ClParam = Nothing
        Me.TxNoticia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNoticia.GridLin = Nothing
        Me.TxNoticia.HaCambiado = False
        Me.TxNoticia.lbbusca = Nothing
        Me.TxNoticia.Location = New System.Drawing.Point(82, 169)
        Me.TxNoticia.MiError = False
        Me.TxNoticia.Multiline = True
        Me.TxNoticia.Name = "TxNoticia"
        Me.TxNoticia.Orden = 0
        Me.TxNoticia.SaltoAlfinal = False
        Me.TxNoticia.Siguiente = 0
        Me.TxNoticia.Size = New System.Drawing.Size(479, 180)
        Me.TxNoticia.TabIndex = 47
        Me.TxNoticia.TeclaRepetida = False
        Me.TxNoticia.TxDatoFinalSemana = Nothing
        Me.TxNoticia.TxDatoInicioSemana = Nothing
        Me.TxNoticia.UltimoValorValidado = Nothing
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'FrmNoticiasWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 412)
        Me.Controls.Add(Me.TxNoticia)
        Me.Controls.Add(Me.LbNoticia)
        Me.Controls.Add(Me.BtAdjunto)
        Me.Controls.Add(Me.LbAdjunto)
        Me.Controls.Add(Me.TxAdjunto)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TxFecha)
        Me.Controls.Add(Me.TxId)
        Me.Controls.Add(Me.BtBuscaNoticias)
        Me.Controls.Add(Me.LbTitular)
        Me.Controls.Add(Me.TxTitular)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmNoticiasWeb"
        Me.Text = "Noticias Web"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxTitular, 0)
        Me.Controls.SetChildIndex(Me.LbTitular, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaNoticias, 0)
        Me.Controls.SetChildIndex(Me.TxId, 0)
        Me.Controls.SetChildIndex(Me.TxFecha, 0)
        Me.Controls.SetChildIndex(Me.LbFecha, 0)
        Me.Controls.SetChildIndex(Me.TxAdjunto, 0)
        Me.Controls.SetChildIndex(Me.LbAdjunto, 0)
        Me.Controls.SetChildIndex(Me.BtAdjunto, 0)
        Me.Controls.SetChildIndex(Me.LbNoticia, 0)
        Me.Controls.SetChildIndex(Me.TxNoticia, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtBuscaNoticias As NetAgro.BtBusca
    Friend WithEvents LbTitular As NetAgro.Lb
    Friend WithEvents TxTitular As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxId As NetAgro.TxDato
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents LbAdjunto As NetAgro.Lb
    Friend WithEvents TxAdjunto As NetAgro.TxDato
    Friend WithEvents BtAdjunto As System.Windows.Forms.Button
    Friend WithEvents LbNoticia As NetAgro.Lb
    Friend WithEvents TxNoticia As NetAgro.TxDato
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
End Class
