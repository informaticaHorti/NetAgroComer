<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMuestreoPartidas_OLD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMuestreoPartidas_OLD))
        Me.TxDesdeAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDesdeAgricultor = New NetAgro.BtBusca(Me.components)
        Me.LbDeAgr = New NetAgro.Lb(Me.components)
        Me.LbNom_DesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNom_HastaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxHastaAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaHastaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgr = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbGeneros = New NetAgro.Lb(Me.components)
        Me.CbGeneros = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbGeneros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.LbGeneros)
        Me.PanelCabecera.Controls.Add(Me.CbGeneros)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 83)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 89)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 433)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(917, 0)
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
        Me.BtAux.Location = New System.Drawing.Point(842, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDesdeAgricultor
        '
        Me.TxDesdeAgricultor.Autonumerico = False
        Me.TxDesdeAgricultor.Buscando = False
        Me.TxDesdeAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeAgricultor.ClForm = Nothing
        Me.TxDesdeAgricultor.ClParam = Nothing
        Me.TxDesdeAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeAgricultor.GridLin = Nothing
        Me.TxDesdeAgricultor.HaCambiado = False
        Me.TxDesdeAgricultor.lbbusca = Nothing
        Me.TxDesdeAgricultor.Location = New System.Drawing.Point(684, 13)
        Me.TxDesdeAgricultor.MiError = False
        Me.TxDesdeAgricultor.Name = "TxDesdeAgricultor"
        Me.TxDesdeAgricultor.Orden = 0
        Me.TxDesdeAgricultor.SaltoAlfinal = False
        Me.TxDesdeAgricultor.Siguiente = 0
        Me.TxDesdeAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeAgricultor.TabIndex = 51
        Me.TxDesdeAgricultor.TeclaRepetida = False
        Me.TxDesdeAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaDesdeAgricultor
        '
        Me.BtBuscaDesdeAgricultor.CL_Ancho = 0
        Me.BtBuscaDesdeAgricultor.CL_BuscaAlb = False
        Me.BtBuscaDesdeAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaDesdeAgricultor.CL_camponombre = Nothing
        Me.BtBuscaDesdeAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeAgricultor.CL_ch1000 = False
        Me.BtBuscaDesdeAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeAgricultor.CL_dfecha = Nothing
        Me.BtBuscaDesdeAgricultor.CL_Entidad = Nothing
        Me.BtBuscaDesdeAgricultor.CL_EsId = True
        Me.BtBuscaDesdeAgricultor.CL_Filtro = Nothing
        Me.BtBuscaDesdeAgricultor.cl_formu = Nothing
        Me.BtBuscaDesdeAgricultor.CL_hfecha = Nothing
        Me.BtBuscaDesdeAgricultor.cl_ListaW = Nothing
        Me.BtBuscaDesdeAgricultor.CL_xCentro = False
        Me.BtBuscaDesdeAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeAgricultor.Location = New System.Drawing.Point(751, 13)
        Me.BtBuscaDesdeAgricultor.Name = "BtBuscaDesdeAgricultor"
        Me.BtBuscaDesdeAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeAgricultor.TabIndex = 50
        Me.BtBuscaDesdeAgricultor.UseVisualStyleBackColor = True
        '
        'LbDeAgr
        '
        Me.LbDeAgr.AutoSize = True
        Me.LbDeAgr.CL_ControlAsociado = Nothing
        Me.LbDeAgr.CL_ValorFijo = False
        Me.LbDeAgr.ClForm = Nothing
        Me.LbDeAgr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeAgr.ForeColor = System.Drawing.Color.Teal
        Me.LbDeAgr.Location = New System.Drawing.Point(554, 16)
        Me.LbDeAgr.Name = "LbDeAgr"
        Me.LbDeAgr.Size = New System.Drawing.Size(128, 16)
        Me.LbDeAgr.TabIndex = 49
        Me.LbDeAgr.Text = "Desde Agricultor"
        '
        'LbNom_DesdeAgricultor
        '
        Me.LbNom_DesdeAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_DesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbNom_DesdeAgricultor.CL_ValorFijo = False
        Me.LbNom_DesdeAgricultor.ClForm = Nothing
        Me.LbNom_DesdeAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_DesdeAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_DesdeAgricultor.Location = New System.Drawing.Point(786, 13)
        Me.LbNom_DesdeAgricultor.Name = "LbNom_DesdeAgricultor"
        Me.LbNom_DesdeAgricultor.Size = New System.Drawing.Size(427, 23)
        Me.LbNom_DesdeAgricultor.TabIndex = 75
        '
        'LbNom_HastaAgricultor
        '
        Me.LbNom_HastaAgricultor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_HastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbNom_HastaAgricultor.CL_ValorFijo = False
        Me.LbNom_HastaAgricultor.ClForm = Nothing
        Me.LbNom_HastaAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_HastaAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_HastaAgricultor.Location = New System.Drawing.Point(786, 47)
        Me.LbNom_HastaAgricultor.Name = "LbNom_HastaAgricultor"
        Me.LbNom_HastaAgricultor.Size = New System.Drawing.Size(427, 23)
        Me.LbNom_HastaAgricultor.TabIndex = 79
        '
        'TxHastaAgricultor
        '
        Me.TxHastaAgricultor.Autonumerico = False
        Me.TxHastaAgricultor.Buscando = False
        Me.TxHastaAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaAgricultor.ClForm = Nothing
        Me.TxHastaAgricultor.ClParam = Nothing
        Me.TxHastaAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaAgricultor.GridLin = Nothing
        Me.TxHastaAgricultor.HaCambiado = False
        Me.TxHastaAgricultor.lbbusca = Nothing
        Me.TxHastaAgricultor.Location = New System.Drawing.Point(684, 47)
        Me.TxHastaAgricultor.MiError = False
        Me.TxHastaAgricultor.Name = "TxHastaAgricultor"
        Me.TxHastaAgricultor.Orden = 0
        Me.TxHastaAgricultor.SaltoAlfinal = False
        Me.TxHastaAgricultor.Siguiente = 0
        Me.TxHastaAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaAgricultor.TabIndex = 78
        Me.TxHastaAgricultor.TeclaRepetida = False
        Me.TxHastaAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaHastaAgricultor
        '
        Me.BtBuscaHastaAgricultor.CL_Ancho = 0
        Me.BtBuscaHastaAgricultor.CL_BuscaAlb = False
        Me.BtBuscaHastaAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaHastaAgricultor.CL_camponombre = Nothing
        Me.BtBuscaHastaAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaAgricultor.CL_ch1000 = False
        Me.BtBuscaHastaAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaAgricultor.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaHastaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaHastaAgricultor.CL_EsId = True
        Me.BtBuscaHastaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaHastaAgricultor.cl_formu = Nothing
        Me.BtBuscaHastaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaHastaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaHastaAgricultor.CL_xCentro = False
        Me.BtBuscaHastaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaAgricultor.Location = New System.Drawing.Point(751, 47)
        Me.BtBuscaHastaAgricultor.Name = "BtBuscaHastaAgricultor"
        Me.BtBuscaHastaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaAgricultor.TabIndex = 77
        Me.BtBuscaHastaAgricultor.UseVisualStyleBackColor = True
        '
        'LbHastaAgr
        '
        Me.LbHastaAgr.AutoSize = True
        Me.LbHastaAgr.CL_ControlAsociado = Nothing
        Me.LbHastaAgr.CL_ValorFijo = False
        Me.LbHastaAgr.ClForm = Nothing
        Me.LbHastaAgr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgr.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgr.Location = New System.Drawing.Point(554, 50)
        Me.LbHastaAgr.Name = "LbHastaAgr"
        Me.LbHastaAgr.Size = New System.Drawing.Size(126, 16)
        Me.LbHastaAgr.TabIndex = 76
        Me.LbHastaAgr.Text = "Hasta Agricultor"
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(115, 47)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 83
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(12, 50)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxDesdeFecha
        '
        Me.TxDesdeFecha.Autonumerico = False
        Me.TxDesdeFecha.Buscando = False
        Me.TxDesdeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeFecha.ClForm = Nothing
        Me.TxDesdeFecha.ClParam = Nothing
        Me.TxDesdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeFecha.GridLin = Nothing
        Me.TxDesdeFecha.HaCambiado = False
        Me.TxDesdeFecha.lbbusca = Nothing
        Me.TxDesdeFecha.Location = New System.Drawing.Point(115, 13)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 81
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(12, 16)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbGeneros
        '
        Me.LbGeneros.AutoSize = True
        Me.LbGeneros.CL_ControlAsociado = Nothing
        Me.LbGeneros.CL_ValorFijo = True
        Me.LbGeneros.ClForm = Nothing
        Me.LbGeneros.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGeneros.ForeColor = System.Drawing.Color.Teal
        Me.LbGeneros.Location = New System.Drawing.Point(253, 16)
        Me.LbGeneros.Name = "LbGeneros"
        Me.LbGeneros.Size = New System.Drawing.Size(60, 16)
        Me.LbGeneros.TabIndex = 100275
        Me.LbGeneros.Text = "Género"
        '
        'CbGeneros
        '
        Me.CbGeneros.EditValue = ""
        Me.CbGeneros.Location = New System.Drawing.Point(319, 14)
        Me.CbGeneros.Name = "CbGeneros"
        Me.CbGeneros.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbGeneros.Size = New System.Drawing.Size(221, 20)
        Me.CbGeneros.TabIndex = 100274
        '
        'FrmMuestreoPartidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.TxHastaAgricultor)
        Me.Controls.Add(Me.TxDesdeAgricultor)
        Me.Controls.Add(Me.LbNom_HastaAgricultor)
        Me.Controls.Add(Me.BtBuscaHastaAgricultor)
        Me.Controls.Add(Me.LbHastaAgr)
        Me.Controls.Add(Me.LbNom_DesdeAgricultor)
        Me.Controls.Add(Me.BtBuscaDesdeAgricultor)
        Me.Controls.Add(Me.LbDeAgr)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmMuestreoPartidas"
        Me.Text = "Muestreo partidas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.LbDeAgr, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbNom_DesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbHastaAgr, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaHastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbNom_HastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.TxDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.TxHastaAgricultor, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbGeneros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDesdeAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaDesdeAgricultor As NetAgro.BtBusca
    Friend WithEvents LbDeAgr As NetAgro.Lb
    Friend WithEvents LbNom_DesdeAgricultor As NetAgro.Lb
    Friend WithEvents LbNom_HastaAgricultor As NetAgro.Lb
    Friend WithEvents TxHastaAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaHastaAgricultor As NetAgro.BtBusca
    Friend WithEvents LbHastaAgr As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbGeneros As NetAgro.Lb
    Friend WithEvents CbGeneros As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
