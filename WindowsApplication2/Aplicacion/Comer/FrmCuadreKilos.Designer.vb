<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuadreKilos
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
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.LbDesdeFechaSal = New NetAgro.Lb(Me.components)
        Me.LbHastaFechaSal = New NetAgro.Lb(Me.components)
        Me.LbHFechaEnt = New NetAgro.Lb(Me.components)
        Me.LbDfechaEnt = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ChkMostrarCategorias = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.ChkMostrarCategorias)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.LbHFechaEnt)
        Me.PanelCabecera.Controls.Add(Me.LbDfechaEnt)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFechaSal)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFechaSal)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbCampa)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaran)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato_1)
        Me.PanelCabecera.Size = New System.Drawing.Size(884, 118)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 118)
        Me.PanelConsulta.Size = New System.Drawing.Size(884, 377)
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
        Me.BInforme.Location = New System.Drawing.Point(734, 0)
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
        Me.Lb4.Location = New System.Drawing.Point(577, 52)
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
        Me.Lb5.Location = New System.Drawing.Point(295, 52)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(144, 16)
        Me.Lb5.TabIndex = 133
        Me.Lb5.Text = "Desde fecha salida"
        '
        'LbDesdeFechaSal
        '
        Me.LbDesdeFechaSal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDesdeFechaSal.CL_ControlAsociado = Nothing
        Me.LbDesdeFechaSal.CL_ValorFijo = False
        Me.LbDesdeFechaSal.ClForm = Nothing
        Me.LbDesdeFechaSal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFechaSal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDesdeFechaSal.Location = New System.Drawing.Point(456, 49)
        Me.LbDesdeFechaSal.Name = "LbDesdeFechaSal"
        Me.LbDesdeFechaSal.Size = New System.Drawing.Size(114, 23)
        Me.LbDesdeFechaSal.TabIndex = 135
        '
        'LbHastaFechaSal
        '
        Me.LbHastaFechaSal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbHastaFechaSal.CL_ControlAsociado = Nothing
        Me.LbHastaFechaSal.CL_ValorFijo = False
        Me.LbHastaFechaSal.ClForm = Nothing
        Me.LbHastaFechaSal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFechaSal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbHastaFechaSal.Location = New System.Drawing.Point(741, 49)
        Me.LbHastaFechaSal.Name = "LbHastaFechaSal"
        Me.LbHastaFechaSal.Size = New System.Drawing.Size(114, 23)
        Me.LbHastaFechaSal.TabIndex = 136
        '
        'LbHFechaEnt
        '
        Me.LbHFechaEnt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbHFechaEnt.CL_ControlAsociado = Nothing
        Me.LbHFechaEnt.CL_ValorFijo = False
        Me.LbHFechaEnt.ClForm = Nothing
        Me.LbHFechaEnt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHFechaEnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbHFechaEnt.Location = New System.Drawing.Point(741, 17)
        Me.LbHFechaEnt.Name = "LbHFechaEnt"
        Me.LbHFechaEnt.Size = New System.Drawing.Size(114, 23)
        Me.LbHFechaEnt.TabIndex = 140
        '
        'LbDfechaEnt
        '
        Me.LbDfechaEnt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbDfechaEnt.CL_ControlAsociado = Nothing
        Me.LbDfechaEnt.CL_ValorFijo = False
        Me.LbDfechaEnt.ClForm = Nothing
        Me.LbDfechaEnt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDfechaEnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbDfechaEnt.Location = New System.Drawing.Point(456, 17)
        Me.LbDfechaEnt.Name = "LbDfechaEnt"
        Me.LbDfechaEnt.Size = New System.Drawing.Size(114, 23)
        Me.LbDfechaEnt.TabIndex = 139
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(577, 20)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(160, 16)
        Me.Lb6.TabIndex = 138
        Me.Lb6.Text = "Hasta Fecha Entrada"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(295, 20)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(158, 16)
        Me.Lb7.TabIndex = 137
        Me.Lb7.Text = "Desde fecha Entrada"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 52)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 100295
        Me.Lb2.Text = "Centros"
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(15, 71)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(235, 20)
        Me.cbCentro.TabIndex = 100294
        '
        'ChkMostrarCategorias
        '
        Me.ChkMostrarCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMostrarCategorias.AutoSize = True
        Me.ChkMostrarCategorias.Campobd = Nothing
        Me.ChkMostrarCategorias.Checked = True
        Me.ChkMostrarCategorias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMostrarCategorias.ClForm = Nothing
        Me.ChkMostrarCategorias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMostrarCategorias.ForeColor = System.Drawing.Color.Teal
        Me.ChkMostrarCategorias.GridLin = Nothing
        Me.ChkMostrarCategorias.HaCambiado = False
        Me.ChkMostrarCategorias.Location = New System.Drawing.Point(691, 90)
        Me.ChkMostrarCategorias.MiEntidad = Nothing
        Me.ChkMostrarCategorias.MiError = False
        Me.ChkMostrarCategorias.Name = "ChkMostrarCategorias"
        Me.ChkMostrarCategorias.Orden = 0
        Me.ChkMostrarCategorias.SaltoAlfinal = False
        Me.ChkMostrarCategorias.Size = New System.Drawing.Size(164, 20)
        Me.ChkMostrarCategorias.TabIndex = 100402
        Me.ChkMostrarCategorias.Text = "Mostrar categorias"
        Me.ChkMostrarCategorias.UseVisualStyleBackColor = True
        Me.ChkMostrarCategorias.ValorCampoFalse = Nothing
        Me.ChkMostrarCategorias.ValorCampoTrue = Nothing
        Me.ChkMostrarCategorias.ValorDefecto = False
        '
        'FrmCuadreKilos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 529)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmCuadreKilos"
        Me.Text = "Cuadre de kilos"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents LbHastaFechaSal As NetAgro.Lb
    Friend WithEvents LbDesdeFechaSal As NetAgro.Lb
    Friend WithEvents LbHFechaEnt As NetAgro.Lb
    Friend WithEvents LbDfechaEnt As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkMostrarCategorias As NetAgro.Chk
End Class
