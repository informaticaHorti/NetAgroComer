<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSemanaConf
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.PanelGreditable = New System.Windows.Forms.Panel()
        Me.GridEditable = New NetAgro.GridEditable()
        Me.PanelPresenta = New System.Windows.Forms.Panel()
        Me.GridPresenta = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPresenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.PanelGreditable.SuspendLayout()
        Me.PanelPresenta.SuspendLayout()
        CType(Me.GridPresenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPresenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbCampa)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaran)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato_1)
        Me.PanelCabecera.Size = New System.Drawing.Size(884, 55)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(2, 161)
        Me.PanelConsulta.Size = New System.Drawing.Size(884, 66)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(584, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(659, 0)
        '
        'BInforme
        '
        Me.BInforme.Image = Global.NetAgro.My.Resources.Resources.Action_reload_16x16_32_reverse
        Me.BInforme.Location = New System.Drawing.Point(734, 0)
        Me.BInforme.Text = "Actualizar"
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(809, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(509, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.White
        Me.LbCampa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = True
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.Teal
        Me.LbCampa.Location = New System.Drawing.Point(119, 17)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 22)
        Me.LbCampa.TabIndex = 82
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_Ancho = 0
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato_1
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(240, 17)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 81
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(159, 17)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_1.TabIndex = 79
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(89, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Nº Semana"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(553, 24)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(146, 16)
        Me.Lb4.TabIndex = 134
        Me.Lb4.Text = "Hasta Fecha salida"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(278, 21)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(144, 16)
        Me.Lb5.TabIndex = 133
        Me.Lb5.Text = "Desde fecha salida"
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDesdeFecha.Location = New System.Drawing.Point(432, 18)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(114, 23)
        Me.LbDesdeFecha.TabIndex = 135
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbHastaFecha.Location = New System.Drawing.Point(707, 20)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(114, 23)
        Me.LbHastaFecha.TabIndex = 136
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelEditable.Controls.Add(Me.PanelGreditable)
        Me.PanelEditable.Controls.Add(Me.PanelPresenta)
        Me.PanelEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditable.Location = New System.Drawing.Point(0, 55)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(884, 440)
        Me.PanelEditable.TabIndex = 13
        '
        'PanelGreditable
        '
        Me.PanelGreditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGreditable.Controls.Add(Me.GridEditable)
        Me.PanelGreditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGreditable.Location = New System.Drawing.Point(0, 0)
        Me.PanelGreditable.Name = "PanelGreditable"
        Me.PanelGreditable.Size = New System.Drawing.Size(884, 261)
        Me.PanelGreditable.TabIndex = 139
        '
        'GridEditable
        '
        Me.GridEditable.DataSource = Nothing
        Me.GridEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEditable.Location = New System.Drawing.Point(0, 0)
        Me.GridEditable.Name = "GridEditable"
        Me.GridEditable.NavegarSoloEditables = False
        Me.GridEditable.Orden = -1
        Me.GridEditable.Size = New System.Drawing.Size(884, 261)
        Me.GridEditable.TabIndex = 15
        '
        'PanelPresenta
        '
        Me.PanelPresenta.Controls.Add(Me.GridPresenta)
        Me.PanelPresenta.Controls.Add(Me.Lb2)
        Me.PanelPresenta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPresenta.Location = New System.Drawing.Point(0, 261)
        Me.PanelPresenta.Name = "PanelPresenta"
        Me.PanelPresenta.Size = New System.Drawing.Size(884, 179)
        Me.PanelPresenta.TabIndex = 138
        '
        'GridPresenta
        '
        Me.GridPresenta.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GridPresenta.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridPresenta.Location = New System.Drawing.Point(0, 18)
        Me.GridPresenta.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPresenta.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPresenta.MainView = Me.GridViewPresenta
        Me.GridPresenta.Name = "GridPresenta"
        Me.GridPresenta.Size = New System.Drawing.Size(884, 161)
        Me.GridPresenta.TabIndex = 136
        Me.GridPresenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPresenta})
        '
        'GridViewPresenta
        '
        Me.GridViewPresenta.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewPresenta.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewPresenta.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewPresenta.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewPresenta.Appearance.Row.Options.UseFont = True
        Me.GridViewPresenta.GridControl = Me.GridPresenta
        Me.GridViewPresenta.Name = "GridViewPresenta"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb2.Location = New System.Drawing.Point(0, 0)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(427, 18)
        Me.Lb2.TabIndex = 135
        Me.Lb2.Text = "Presentaciones con sobrecoste de manipulación"
        '
        'FrmSemanaConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 529)
        Me.Controls.Add(Me.PanelEditable)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmSemanaConf"
        Me.Text = "FrmSemanaConf"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.PanelEditable, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelGreditable.ResumeLayout(False)
        Me.PanelPresenta.ResumeLayout(False)
        Me.PanelPresenta.PerformLayout()
        CType(Me.GridPresenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPresenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents PanelEditable As System.Windows.Forms.Panel
    Friend WithEvents PanelPresenta As System.Windows.Forms.Panel
    Friend WithEvents GridPresenta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPresenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents PanelGreditable As System.Windows.Forms.Panel
    Friend WithEvents GridEditable As NetAgro.GridEditable
End Class
