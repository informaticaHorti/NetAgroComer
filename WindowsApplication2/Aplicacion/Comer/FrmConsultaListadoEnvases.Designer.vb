<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaListadoEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaListadoEnvases))
        Me.LbNomAEnvase = New NetAgro.Lb(Me.components)
        Me.TxAEnvase = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAEnvase = New NetAgro.BtBusca(Me.components)
        Me.LbAEnvase = New NetAgro.Lb(Me.components)
        Me.LbNomDEnvase = New NetAgro.Lb(Me.components)
        Me.TxDEnvase = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDEnvase = New NetAgro.BtBusca(Me.components)
        Me.LbDEnvase = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.LbNomAEnvase)
        Me.PanelCabecera.Controls.Add(Me.TxAEnvase)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbAEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbNomDEnvase)
        Me.PanelCabecera.Controls.Add(Me.TxDEnvase)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDEnvase)
        Me.PanelCabecera.Controls.Add(Me.LbDEnvase)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 87)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 87)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 441)
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
        'LbNomAEnvase
        '
        Me.LbNomAEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAEnvase.CL_ControlAsociado = Nothing
        Me.LbNomAEnvase.CL_ValorFijo = False
        Me.LbNomAEnvase.ClForm = Nothing
        Me.LbNomAEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAEnvase.Location = New System.Drawing.Point(204, 45)
        Me.LbNomAEnvase.Name = "LbNomAEnvase"
        Me.LbNomAEnvase.Size = New System.Drawing.Size(415, 23)
        Me.LbNomAEnvase.TabIndex = 100315
        Me.LbNomAEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxAEnvase
        '
        Me.TxAEnvase.Autonumerico = False
        Me.TxAEnvase.Buscando = False
        Me.TxAEnvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAEnvase.ClForm = Nothing
        Me.TxAEnvase.ClParam = Nothing
        Me.TxAEnvase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAEnvase.GridLin = Nothing
        Me.TxAEnvase.HaCambiado = False
        Me.TxAEnvase.lbbusca = Nothing
        Me.TxAEnvase.Location = New System.Drawing.Point(102, 45)
        Me.TxAEnvase.MiError = False
        Me.TxAEnvase.Name = "TxAEnvase"
        Me.TxAEnvase.Orden = 0
        Me.TxAEnvase.SaltoAlfinal = False
        Me.TxAEnvase.Siguiente = 0
        Me.TxAEnvase.Size = New System.Drawing.Size(59, 22)
        Me.TxAEnvase.TabIndex = 100314
        Me.TxAEnvase.TeclaRepetida = False
        Me.TxAEnvase.TxDatoFinalSemana = Nothing
        Me.TxAEnvase.TxDatoInicioSemana = Nothing
        Me.TxAEnvase.UltimoValorValidado = Nothing
        '
        'BtBuscaAEnvase
        '
        Me.BtBuscaAEnvase.CL_Ancho = 0
        Me.BtBuscaAEnvase.CL_BuscaAlb = False
        Me.BtBuscaAEnvase.CL_campocodigo = Nothing
        Me.BtBuscaAEnvase.CL_camponombre = Nothing
        Me.BtBuscaAEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaAEnvase.CL_ch1000 = False
        Me.BtBuscaAEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAEnvase.CL_ControlAsociado = Nothing
        Me.BtBuscaAEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAEnvase.CL_dfecha = Nothing
        Me.BtBuscaAEnvase.CL_Entidad = Nothing
        Me.BtBuscaAEnvase.CL_EsId = True
        Me.BtBuscaAEnvase.CL_Filtro = Nothing
        Me.BtBuscaAEnvase.cl_formu = Nothing
        Me.BtBuscaAEnvase.CL_hfecha = Nothing
        Me.BtBuscaAEnvase.cl_ListaW = Nothing
        Me.BtBuscaAEnvase.CL_xCentro = False
        Me.BtBuscaAEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAEnvase.Location = New System.Drawing.Point(165, 45)
        Me.BtBuscaAEnvase.Name = "BtBuscaAEnvase"
        Me.BtBuscaAEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAEnvase.TabIndex = 100313
        Me.BtBuscaAEnvase.UseVisualStyleBackColor = True
        '
        'LbAEnvase
        '
        Me.LbAEnvase.AutoSize = True
        Me.LbAEnvase.CL_ControlAsociado = Nothing
        Me.LbAEnvase.CL_ValorFijo = False
        Me.LbAEnvase.ClForm = Nothing
        Me.LbAEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAEnvase.ForeColor = System.Drawing.Color.Teal
        Me.LbAEnvase.Location = New System.Drawing.Point(12, 47)
        Me.LbAEnvase.Name = "LbAEnvase"
        Me.LbAEnvase.Size = New System.Drawing.Size(75, 16)
        Me.LbAEnvase.TabIndex = 100312
        Me.LbAEnvase.Text = "A Envase"
        '
        'LbNomDEnvase
        '
        Me.LbNomDEnvase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDEnvase.CL_ControlAsociado = Nothing
        Me.LbNomDEnvase.CL_ValorFijo = False
        Me.LbNomDEnvase.ClForm = Nothing
        Me.LbNomDEnvase.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDEnvase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDEnvase.Location = New System.Drawing.Point(204, 16)
        Me.LbNomDEnvase.Name = "LbNomDEnvase"
        Me.LbNomDEnvase.Size = New System.Drawing.Size(415, 23)
        Me.LbNomDEnvase.TabIndex = 100311
        Me.LbNomDEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDEnvase
        '
        Me.TxDEnvase.Autonumerico = False
        Me.TxDEnvase.Buscando = False
        Me.TxDEnvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDEnvase.ClForm = Nothing
        Me.TxDEnvase.ClParam = Nothing
        Me.TxDEnvase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDEnvase.GridLin = Nothing
        Me.TxDEnvase.HaCambiado = False
        Me.TxDEnvase.lbbusca = Nothing
        Me.TxDEnvase.Location = New System.Drawing.Point(102, 16)
        Me.TxDEnvase.MiError = False
        Me.TxDEnvase.Name = "TxDEnvase"
        Me.TxDEnvase.Orden = 0
        Me.TxDEnvase.SaltoAlfinal = False
        Me.TxDEnvase.Siguiente = 0
        Me.TxDEnvase.Size = New System.Drawing.Size(59, 22)
        Me.TxDEnvase.TabIndex = 100310
        Me.TxDEnvase.TeclaRepetida = False
        Me.TxDEnvase.TxDatoFinalSemana = Nothing
        Me.TxDEnvase.TxDatoInicioSemana = Nothing
        Me.TxDEnvase.UltimoValorValidado = Nothing
        '
        'BtBuscaDEnvase
        '
        Me.BtBuscaDEnvase.CL_Ancho = 0
        Me.BtBuscaDEnvase.CL_BuscaAlb = False
        Me.BtBuscaDEnvase.CL_campocodigo = Nothing
        Me.BtBuscaDEnvase.CL_camponombre = Nothing
        Me.BtBuscaDEnvase.CL_CampoOrden = "Nombre"
        Me.BtBuscaDEnvase.CL_ch1000 = False
        Me.BtBuscaDEnvase.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDEnvase.CL_ControlAsociado = Nothing
        Me.BtBuscaDEnvase.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDEnvase.CL_dfecha = Nothing
        Me.BtBuscaDEnvase.CL_Entidad = Nothing
        Me.BtBuscaDEnvase.CL_EsId = True
        Me.BtBuscaDEnvase.CL_Filtro = Nothing
        Me.BtBuscaDEnvase.cl_formu = Nothing
        Me.BtBuscaDEnvase.CL_hfecha = Nothing
        Me.BtBuscaDEnvase.cl_ListaW = Nothing
        Me.BtBuscaDEnvase.CL_xCentro = False
        Me.BtBuscaDEnvase.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDEnvase.Location = New System.Drawing.Point(165, 16)
        Me.BtBuscaDEnvase.Name = "BtBuscaDEnvase"
        Me.BtBuscaDEnvase.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDEnvase.TabIndex = 100309
        Me.BtBuscaDEnvase.UseVisualStyleBackColor = True
        '
        'LbDEnvase
        '
        Me.LbDEnvase.AutoSize = True
        Me.LbDEnvase.CL_ControlAsociado = Nothing
        Me.LbDEnvase.CL_ValorFijo = False
        Me.LbDEnvase.ClForm = Nothing
        Me.LbDEnvase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDEnvase.ForeColor = System.Drawing.Color.Teal
        Me.LbDEnvase.Location = New System.Drawing.Point(12, 18)
        Me.LbDEnvase.Name = "LbDEnvase"
        Me.LbDEnvase.Size = New System.Drawing.Size(84, 16)
        Me.LbDEnvase.TabIndex = 100308
        Me.LbDEnvase.Text = "De Envase"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(655, 18)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(69, 16)
        Me.Lb7.TabIndex = 100408
        Me.Lb7.Text = "Familias"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(730, 16)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(312, 20)
        Me.CbFamilias.TabIndex = 100407
        '
        'FrmConsultaListadoEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaListadoEnvases"
        Me.Text = "Consulta Listado Envases"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbNomAEnvase As NetAgro.Lb
    Friend WithEvents TxAEnvase As NetAgro.TxDato
    Friend WithEvents BtBuscaAEnvase As NetAgro.BtBusca
    Friend WithEvents LbAEnvase As NetAgro.Lb
    Friend WithEvents LbNomDEnvase As NetAgro.Lb
    Friend WithEvents TxDEnvase As NetAgro.TxDato
    Friend WithEvents BtBuscaDEnvase As NetAgro.BtBusca
    Friend WithEvents LbDEnvase As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
