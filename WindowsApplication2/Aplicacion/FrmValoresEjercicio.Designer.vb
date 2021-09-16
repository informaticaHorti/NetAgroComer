<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoresEjercicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoresEjercicio))
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaFRM = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.LbNomUsu = New NetAgro.Lb(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbTipoConexionTecnicos = New NetAgro.CbBox(Me.components)
        Me.LbTipoConexionTecnicos = New NetAgro.Lb(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ChkBloquear = New NetAgro.Chk(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(14, 18)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(70, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Ejercicio"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Bloqueado = False
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
        Me.TxDato1.Location = New System.Drawing.Point(99, 15)
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
        Me.BtBuscaFRM.Location = New System.Drawing.Point(151, 15)
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
        Me.BotonesAvance1.Location = New System.Drawing.Point(190, 14)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'LbNomUsu
        '
        Me.LbNomUsu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomUsu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomUsu.CL_ControlAsociado = Nothing
        Me.LbNomUsu.CL_ValorFijo = False
        Me.LbNomUsu.ClForm = Nothing
        Me.LbNomUsu.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomUsu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomUsu.Location = New System.Drawing.Point(309, 15)
        Me.LbNomUsu.Name = "LbNomUsu"
        Me.LbNomUsu.Size = New System.Drawing.Size(343, 23)
        Me.LbNomUsu.TabIndex = 82
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Wheat
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.XtraTabControl1.Location = New System.Drawing.Point(17, 59)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(640, 183)
        Me.XtraTabControl1.TabIndex = 85
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Silver
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(632, 155)
        Me.XtraTabPage1.Text = "General"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel2.Controls.Add(Me.ChkBloquear)
        Me.Panel2.Controls.Add(Me.CbTipoConexionTecnicos)
        Me.Panel2.Controls.Add(Me.LbTipoConexionTecnicos)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(632, 152)
        Me.Panel2.TabIndex = 0
        '
        'CbTipoConexionTecnicos
        '
        Me.CbTipoConexionTecnicos.Campobd = Nothing
        Me.CbTipoConexionTecnicos.ClForm = Nothing
        Me.CbTipoConexionTecnicos.DeshabilitarRuedaRaton = False
        Me.CbTipoConexionTecnicos.FormattingEnabled = True
        Me.CbTipoConexionTecnicos.GridLin = Nothing
        Me.CbTipoConexionTecnicos.Location = New System.Drawing.Point(162, 17)
        Me.CbTipoConexionTecnicos.MiEntidad = Nothing
        Me.CbTipoConexionTecnicos.MiError = False
        Me.CbTipoConexionTecnicos.Name = "CbTipoConexionTecnicos"
        Me.CbTipoConexionTecnicos.Orden = 0
        Me.CbTipoConexionTecnicos.SaltoAlfinal = False
        Me.CbTipoConexionTecnicos.Size = New System.Drawing.Size(285, 21)
        Me.CbTipoConexionTecnicos.TabIndex = 103
        '
        'LbTipoConexionTecnicos
        '
        Me.LbTipoConexionTecnicos.AutoSize = True
        Me.LbTipoConexionTecnicos.CL_ControlAsociado = Nothing
        Me.LbTipoConexionTecnicos.CL_ValorFijo = True
        Me.LbTipoConexionTecnicos.ClForm = Nothing
        Me.LbTipoConexionTecnicos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoConexionTecnicos.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoConexionTecnicos.Location = New System.Drawing.Point(13, 18)
        Me.LbTipoConexionTecnicos.Name = "LbTipoConexionTecnicos"
        Me.LbTipoConexionTecnicos.Size = New System.Drawing.Size(143, 16)
        Me.LbTipoConexionTecnicos.TabIndex = 85
        Me.LbTipoConexionTecnicos.Text = "Conexión Técnicos"
        '
        'ChkBloquear
        '
        Me.ChkBloquear.AutoSize = True
        Me.ChkBloquear.Campobd = Nothing
        Me.ChkBloquear.ClForm = Nothing
        Me.ChkBloquear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBloquear.ForeColor = System.Drawing.Color.Teal
        Me.ChkBloquear.GridLin = Nothing
        Me.ChkBloquear.HaCambiado = False
        Me.ChkBloquear.Location = New System.Drawing.Point(13, 48)
        Me.ChkBloquear.MiEntidad = Nothing
        Me.ChkBloquear.MiError = False
        Me.ChkBloquear.Name = "ChkBloquear"
        Me.ChkBloquear.Orden = 0
        Me.ChkBloquear.SaltoAlfinal = False
        Me.ChkBloquear.Size = New System.Drawing.Size(552, 20)
        Me.ChkBloquear.TabIndex = 100401
        Me.ChkBloquear.Text = "Bloquear campaña para Partidas, Lotes, Precalibrados y Carga de palets"
        Me.ChkBloquear.UseVisualStyleBackColor = True
        Me.ChkBloquear.ValorCampoFalse = Nothing
        Me.ChkBloquear.ValorCampoTrue = Nothing
        Me.ChkBloquear.ValorDefecto = False
        '
        'FrmValoresEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 297)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LbNomUsu)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaFRM)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmValoresEjercicio"
        Me.Text = "Valores por Ejercicio"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaFRM, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.LbNomUsu, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBuscaFRM As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents LbNomUsu As NetAgro.Lb
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbTipoConexionTecnicos As NetAgro.Lb
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents CbTipoConexionTecnicos As NetAgro.CbBox
    Friend WithEvents ChkBloquear As NetAgro.Chk
End Class
