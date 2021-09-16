<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvancePrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAvancePrecios))
        Me.LbDesdeParte = New NetAgro.Lb(Me.components)
        Me.TxDesdeParte = New NetAgro.TxDato(Me.components)
        Me.BtBuscaParteDesde = New NetAgro.BtBusca(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.BtBuscaParteHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaParte = New NetAgro.Lb(Me.components)
        Me.TxHastaParte = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbFechaDesde = New NetAgro.Lb(Me.components)
        Me.LbFechaHasta = New NetAgro.Lb(Me.components)
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbFechaDesde)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaParteHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaParte)
        Me.PanelCabecera.Controls.Add(Me.TxHastaParte)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaParteDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeParte)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeParte)
        Me.PanelCabecera.Size = New System.Drawing.Size(1104, 82)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 82)
        Me.PanelConsulta.Size = New System.Drawing.Size(1104, 412)
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
        'LbDesdeParte
        '
        Me.LbDesdeParte.AutoSize = True
        Me.LbDesdeParte.CL_ControlAsociado = Nothing
        Me.LbDesdeParte.CL_ValorFijo = False
        Me.LbDesdeParte.ClForm = Nothing
        Me.LbDesdeParte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeParte.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeParte.Location = New System.Drawing.Point(10, 15)
        Me.LbDesdeParte.Name = "LbDesdeParte"
        Me.LbDesdeParte.Size = New System.Drawing.Size(96, 16)
        Me.LbDesdeParte.TabIndex = 116
        Me.LbDesdeParte.Text = "Desde parte"
        '
        'TxDesdeParte
        '
        Me.TxDesdeParte.Autonumerico = False
        Me.TxDesdeParte.Buscando = False
        Me.TxDesdeParte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeParte.ClForm = Nothing
        Me.TxDesdeParte.ClParam = Nothing
        Me.TxDesdeParte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDesdeParte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeParte.GridLin = Nothing
        Me.TxDesdeParte.HaCambiado = False
        Me.TxDesdeParte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDesdeParte.lbbusca = Nothing
        Me.TxDesdeParte.Location = New System.Drawing.Point(112, 12)
        Me.TxDesdeParte.MiError = False
        Me.TxDesdeParte.Name = "TxDesdeParte"
        Me.TxDesdeParte.Orden = 0
        Me.TxDesdeParte.SaltoAlfinal = False
        Me.TxDesdeParte.Siguiente = 0
        Me.TxDesdeParte.Size = New System.Drawing.Size(105, 22)
        Me.TxDesdeParte.TabIndex = 115
        Me.TxDesdeParte.TeclaRepetida = False
        Me.TxDesdeParte.TxDatoFinalSemana = Nothing
        Me.TxDesdeParte.TxDatoInicioSemana = Nothing
        Me.TxDesdeParte.UltimoValorValidado = Nothing
        '
        'BtBuscaParteDesde
        '
        Me.BtBuscaParteDesde.CL_Ancho = 0
        Me.BtBuscaParteDesde.CL_BuscaAlb = False
        Me.BtBuscaParteDesde.CL_campocodigo = Nothing
        Me.BtBuscaParteDesde.CL_camponombre = Nothing
        Me.BtBuscaParteDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaParteDesde.CL_ch1000 = False
        Me.BtBuscaParteDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaParteDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaParteDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaParteDesde.CL_dfecha = Nothing
        Me.BtBuscaParteDesde.CL_Entidad = Nothing
        Me.BtBuscaParteDesde.CL_EsId = True
        Me.BtBuscaParteDesde.CL_Filtro = Nothing
        Me.BtBuscaParteDesde.cl_formu = Nothing
        Me.BtBuscaParteDesde.CL_hfecha = Nothing
        Me.BtBuscaParteDesde.cl_ListaW = Nothing
        Me.BtBuscaParteDesde.CL_xCentro = False
        Me.BtBuscaParteDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaParteDesde.Location = New System.Drawing.Point(221, 12)
        Me.BtBuscaParteDesde.Name = "BtBuscaParteDesde"
        Me.BtBuscaParteDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaParteDesde.TabIndex = 100286
        Me.BtBuscaParteDesde.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.Location = New System.Drawing.Point(787, 12)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(305, 23)
        Me.Barra.TabIndex = 100288
        '
        'BtBuscaParteHasta
        '
        Me.BtBuscaParteHasta.CL_Ancho = 0
        Me.BtBuscaParteHasta.CL_BuscaAlb = False
        Me.BtBuscaParteHasta.CL_campocodigo = Nothing
        Me.BtBuscaParteHasta.CL_camponombre = Nothing
        Me.BtBuscaParteHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaParteHasta.CL_ch1000 = False
        Me.BtBuscaParteHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaParteHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaParteHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaParteHasta.CL_dfecha = Nothing
        Me.BtBuscaParteHasta.CL_Entidad = Nothing
        Me.BtBuscaParteHasta.CL_EsId = True
        Me.BtBuscaParteHasta.CL_Filtro = Nothing
        Me.BtBuscaParteHasta.cl_formu = Nothing
        Me.BtBuscaParteHasta.CL_hfecha = Nothing
        Me.BtBuscaParteHasta.cl_ListaW = Nothing
        Me.BtBuscaParteHasta.CL_xCentro = False
        Me.BtBuscaParteHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaParteHasta.Location = New System.Drawing.Point(221, 40)
        Me.BtBuscaParteHasta.Name = "BtBuscaParteHasta"
        Me.BtBuscaParteHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaParteHasta.TabIndex = 100291
        Me.BtBuscaParteHasta.UseVisualStyleBackColor = True
        '
        'LbHastaParte
        '
        Me.LbHastaParte.AutoSize = True
        Me.LbHastaParte.CL_ControlAsociado = Nothing
        Me.LbHastaParte.CL_ValorFijo = False
        Me.LbHastaParte.ClForm = Nothing
        Me.LbHastaParte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaParte.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaParte.Location = New System.Drawing.Point(10, 43)
        Me.LbHastaParte.Name = "LbHastaParte"
        Me.LbHastaParte.Size = New System.Drawing.Size(94, 16)
        Me.LbHastaParte.TabIndex = 100290
        Me.LbHastaParte.Text = "Hasta parte"
        '
        'TxHastaParte
        '
        Me.TxHastaParte.Autonumerico = False
        Me.TxHastaParte.Buscando = False
        Me.TxHastaParte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaParte.ClForm = Nothing
        Me.TxHastaParte.ClParam = Nothing
        Me.TxHastaParte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxHastaParte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaParte.GridLin = Nothing
        Me.TxHastaParte.HaCambiado = False
        Me.TxHastaParte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxHastaParte.lbbusca = Nothing
        Me.TxHastaParte.Location = New System.Drawing.Point(112, 40)
        Me.TxHastaParte.MiError = False
        Me.TxHastaParte.Name = "TxHastaParte"
        Me.TxHastaParte.Orden = 0
        Me.TxHastaParte.SaltoAlfinal = False
        Me.TxHastaParte.Siguiente = 0
        Me.TxHastaParte.Size = New System.Drawing.Size(105, 22)
        Me.TxHastaParte.TabIndex = 100289
        Me.TxHastaParte.TeclaRepetida = False
        Me.TxHastaParte.TxDatoFinalSemana = Nothing
        Me.TxHastaParte.TxDatoInicioSemana = Nothing
        Me.TxHastaParte.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(260, 15)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(53, 16)
        Me.Lb4.TabIndex = 100292
        Me.Lb4.Text = "Desde"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(260, 43)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(51, 16)
        Me.Lb1.TabIndex = 100293
        Me.Lb1.Text = "Hasta"
        '
        'LbFechaDesde
        '
        Me.LbFechaDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFechaDesde.CL_ControlAsociado = Nothing
        Me.LbFechaDesde.CL_ValorFijo = False
        Me.LbFechaDesde.ClForm = Nothing
        Me.LbFechaDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFechaDesde.Location = New System.Drawing.Point(319, 12)
        Me.LbFechaDesde.Name = "LbFechaDesde"
        Me.LbFechaDesde.Size = New System.Drawing.Size(129, 23)
        Me.LbFechaDesde.TabIndex = 100294
        '
        'LbFechaHasta
        '
        Me.LbFechaHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFechaHasta.CL_ControlAsociado = Nothing
        Me.LbFechaHasta.CL_ValorFijo = False
        Me.LbFechaHasta.ClForm = Nothing
        Me.LbFechaHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFechaHasta.Location = New System.Drawing.Point(319, 40)
        Me.LbFechaHasta.Name = "LbFechaHasta"
        Me.LbFechaHasta.Size = New System.Drawing.Size(129, 23)
        Me.LbFechaHasta.TabIndex = 100296
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(542, 43)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(240, 20)
        Me.cbCentro.TabIndex = 100318
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(479, 45)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100317
        Me.Lb5.Text = "Centro"
        '
        'FrmAvancePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAvancePrecios"
        Me.Text = "Avance de precios para varios partes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbDesdeParte As NetAgro.Lb
    Friend WithEvents TxDesdeParte As NetAgro.TxDato
    Friend WithEvents BtBuscaParteDesde As NetAgro.BtBusca
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents BtBuscaParteHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaParte As NetAgro.Lb
    Friend WithEvents TxHastaParte As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbFechaHasta As NetAgro.Lb
    Friend WithEvents LbFechaDesde As NetAgro.Lb
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
