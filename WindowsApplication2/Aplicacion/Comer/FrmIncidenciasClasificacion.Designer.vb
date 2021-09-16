<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIncidenciasClasificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIncidenciasClasificacion))
        Me.LbNomAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.CbCultivo = New NetAgro.CbBox(Me.components)
        Me.LbCultivo = New NetAgro.Lb(Me.components)
        Me.LbGenero = New NetAgro.Lb(Me.components)
        Me.CbGenero = New NetAgro.CbBox(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.btHistorico = New NetAgro.ClButton()
        Me.TxCultivo = New NetAgro.TxDato(Me.components)
        Me.LbNomCultivo = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbCampaCultivo = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbCampaCultivo)
        Me.PanelCabecera.Controls.Add(Me.TxCultivo)
        Me.PanelCabecera.Controls.Add(Me.LbNomCultivo)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.btHistorico)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.Panel1)
        Me.PanelCabecera.Controls.Add(Me.LbGenero)
        Me.PanelCabecera.Controls.Add(Me.CbGenero)
        Me.PanelCabecera.Controls.Add(Me.LbCultivo)
        Me.PanelCabecera.Controls.Add(Me.CbCultivo)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultor)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbAgricultor)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 102)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 414)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(934, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1009, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1084, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1159, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbNomAgricultor
        '
        Me.LbNomAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomAgricultor.CL_ValorFijo = False
        Me.LbNomAgricultor.ClForm = Nothing
        Me.LbNomAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultor.Location = New System.Drawing.Point(206, 13)
        Me.LbNomAgricultor.Name = "LbNomAgricultor"
        Me.LbNomAgricultor.Size = New System.Drawing.Size(420, 23)
        Me.LbNomAgricultor.TabIndex = 100278
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(98, 13)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultor.TabIndex = 100277
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
        Me.BtBuscaAgricultor.CL_ControlAsociado = Nothing
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
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(167, 13)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 100276
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(13, 16)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 100275
        Me.LbAgricultor.Text = "Agricultor"
        '
        'CbCultivo
        '
        Me.CbCultivo.Campobd = Nothing
        Me.CbCultivo.ClForm = Nothing
        Me.CbCultivo.DeshabilitarRuedaRaton = False
        Me.CbCultivo.FormattingEnabled = True
        Me.CbCultivo.GridLin = Nothing
        Me.CbCultivo.Location = New System.Drawing.Point(98, 41)
        Me.CbCultivo.MiEntidad = Nothing
        Me.CbCultivo.MiError = False
        Me.CbCultivo.Name = "CbCultivo"
        Me.CbCultivo.Orden = 0
        Me.CbCultivo.SaltoAlfinal = False
        Me.CbCultivo.Size = New System.Drawing.Size(349, 21)
        Me.CbCultivo.TabIndex = 100279
        '
        'LbCultivo
        '
        Me.LbCultivo.AutoSize = True
        Me.LbCultivo.CL_ControlAsociado = Nothing
        Me.LbCultivo.CL_ValorFijo = True
        Me.LbCultivo.ClForm = Nothing
        Me.LbCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCultivo.ForeColor = System.Drawing.Color.Teal
        Me.LbCultivo.Location = New System.Drawing.Point(13, 42)
        Me.LbCultivo.Name = "LbCultivo"
        Me.LbCultivo.Size = New System.Drawing.Size(59, 16)
        Me.LbCultivo.TabIndex = 100280
        Me.LbCultivo.Text = "Cultivo"
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.CL_ControlAsociado = Nothing
        Me.LbGenero.CL_ValorFijo = True
        Me.LbGenero.ClForm = Nothing
        Me.LbGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbGenero.Location = New System.Drawing.Point(13, 68)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(60, 16)
        Me.LbGenero.TabIndex = 100282
        Me.LbGenero.Text = "Genero"
        '
        'CbGenero
        '
        Me.CbGenero.Campobd = Nothing
        Me.CbGenero.ClForm = Nothing
        Me.CbGenero.DeshabilitarRuedaRaton = False
        Me.CbGenero.FormattingEnabled = True
        Me.CbGenero.GridLin = Nothing
        Me.CbGenero.Location = New System.Drawing.Point(98, 66)
        Me.CbGenero.MiEntidad = Nothing
        Me.CbGenero.MiError = False
        Me.CbGenero.Name = "CbGenero"
        Me.CbGenero.Orden = 0
        Me.CbGenero.SaltoAlfinal = False
        Me.CbGenero.Size = New System.Drawing.Size(349, 21)
        Me.CbGenero.TabIndex = 100281
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(475, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 21)
        Me.Panel1.TabIndex = 100283
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(502, 68)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(267, 16)
        Me.Lb1.TabIndex = 100284
        Me.Lb1.Text = "Pulsar para ver Detalle de Muestreo"
        '
        'btHistorico
        '
        Me.btHistorico.Location = New System.Drawing.Point(1000, 61)
        Me.btHistorico.Name = "btHistorico"
        Me.btHistorico.Orden = 0
        Me.btHistorico.PedirClave = True
        Me.btHistorico.Size = New System.Drawing.Size(222, 29)
        Me.btHistorico.TabIndex = 100285
        Me.btHistorico.Text = "CONSULTAR HISTORICO DEL CULTIVO"
        Me.btHistorico.UseVisualStyleBackColor = True
        '
        'TxCultivo
        '
        Me.TxCultivo.Autonumerico = False
        Me.TxCultivo.Buscando = False
        Me.TxCultivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCultivo.ClForm = Nothing
        Me.TxCultivo.ClParam = Nothing
        Me.TxCultivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCultivo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCultivo.GridLin = Nothing
        Me.TxCultivo.HaCambiado = False
        Me.TxCultivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCultivo.lbbusca = Nothing
        Me.TxCultivo.Location = New System.Drawing.Point(753, 13)
        Me.TxCultivo.MiError = False
        Me.TxCultivo.Name = "TxCultivo"
        Me.TxCultivo.Orden = 0
        Me.TxCultivo.SaltoAlfinal = False
        Me.TxCultivo.Siguiente = 0
        Me.TxCultivo.Size = New System.Drawing.Size(72, 22)
        Me.TxCultivo.TabIndex = 100289
        Me.TxCultivo.TeclaRepetida = False
        Me.TxCultivo.TxDatoFinalSemana = Nothing
        Me.TxCultivo.TxDatoInicioSemana = Nothing
        Me.TxCultivo.UltimoValorValidado = Nothing
        '
        'LbNomCultivo
        '
        Me.LbNomCultivo.BackColor = System.Drawing.Color.Gainsboro
        Me.LbNomCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomCultivo.CL_ControlAsociado = Nothing
        Me.LbNomCultivo.CL_ValorFijo = False
        Me.LbNomCultivo.ClForm = Nothing
        Me.LbNomCultivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCultivo.Location = New System.Drawing.Point(831, 13)
        Me.LbNomCultivo.Name = "LbNomCultivo"
        Me.LbNomCultivo.Size = New System.Drawing.Size(388, 23)
        Me.LbNomCultivo.TabIndex = 100287
        Me.LbNomCultivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(653, 16)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(59, 16)
        Me.Lb2.TabIndex = 100286
        Me.Lb2.Text = "Cultivo"
        '
        'LbCampaCultivo
        '
        Me.LbCampaCultivo.BackColor = System.Drawing.Color.Gainsboro
        Me.LbCampaCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCampaCultivo.CL_ControlAsociado = Nothing
        Me.LbCampaCultivo.CL_ValorFijo = True
        Me.LbCampaCultivo.ClForm = Nothing
        Me.LbCampaCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampaCultivo.ForeColor = System.Drawing.Color.Blue
        Me.LbCampaCultivo.Location = New System.Drawing.Point(718, 13)
        Me.LbCampaCultivo.Name = "LbCampaCultivo"
        Me.LbCampaCultivo.Size = New System.Drawing.Size(32, 22)
        Me.LbCampaCultivo.TabIndex = 100291
        Me.LbCampaCultivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmIncidenciasClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmIncidenciasClasificacion"
        Me.Text = "Registro incidencias clasificacion"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbNomAgricultor As NetAgro.Lb
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents LbGenero As NetAgro.Lb
    Friend WithEvents CbGenero As NetAgro.CbBox
    Friend WithEvents LbCultivo As NetAgro.Lb
    Friend WithEvents CbCultivo As NetAgro.CbBox
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btHistorico As NetAgro.ClButton
    Friend WithEvents TxCultivo As NetAgro.TxDato
    Friend WithEvents LbNomCultivo As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbCampaCultivo As NetAgro.Lb
End Class
