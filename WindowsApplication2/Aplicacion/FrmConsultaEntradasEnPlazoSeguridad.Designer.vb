<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaEntradasEnPlazoSeguridad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaEntradasEnPlazoSeguridad))
        Me.TxDesdeAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAg1 = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxHastaAgricultor = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAg2 = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbTipoEntrada = New NetAgro.Lb(Me.components)
        Me.CbTipoEntrada = New NetAgro.CbBox(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbTipoEntrada)
        Me.PanelCabecera.Controls.Add(Me.LbTipoEntrada)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1040, 95)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 95)
        Me.PanelConsulta.Size = New System.Drawing.Size(1040, 399)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(740, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(815, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(890, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(965, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(665, 0)
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
        Me.TxDesdeAgricultor.Location = New System.Drawing.Point(147, 8)
        Me.TxDesdeAgricultor.MiError = False
        Me.TxDesdeAgricultor.Name = "TxDesdeAgricultor"
        Me.TxDesdeAgricultor.Orden = 0
        Me.TxDesdeAgricultor.SaltoAlfinal = False
        Me.TxDesdeAgricultor.Siguiente = 0
        Me.TxDesdeAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeAgricultor.TabIndex = 51
        Me.TxDesdeAgricultor.TeclaRepetida = False
        Me.TxDesdeAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDesdeAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDesdeAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaAg1
        '
        Me.BtBuscaAg1.CL_Ancho = 0
        Me.BtBuscaAg1.CL_BuscaAlb = False
        Me.BtBuscaAg1.CL_campocodigo = Nothing
        Me.BtBuscaAg1.CL_camponombre = Nothing
        Me.BtBuscaAg1.CL_CampoOrden = "Nombre"
        Me.BtBuscaAg1.CL_ch1000 = False
        Me.BtBuscaAg1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAg1.CL_ControlAsociado = Nothing
        Me.BtBuscaAg1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAg1.CL_dfecha = Nothing
        Me.BtBuscaAg1.CL_Entidad = Nothing
        Me.BtBuscaAg1.CL_EsId = True
        Me.BtBuscaAg1.CL_Filtro = Nothing
        Me.BtBuscaAg1.cl_formu = Nothing
        Me.BtBuscaAg1.CL_hfecha = Nothing
        Me.BtBuscaAg1.cl_ListaW = Nothing
        Me.BtBuscaAg1.CL_xCentro = False
        Me.BtBuscaAg1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAg1.Location = New System.Drawing.Point(211, 8)
        Me.BtBuscaAg1.Name = "BtBuscaAg1"
        Me.BtBuscaAg1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAg1.TabIndex = 50
        Me.BtBuscaAg1.UseVisualStyleBackColor = True
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(13, 11)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(128, 16)
        Me.LbDesdeAgricultor.TabIndex = 49
        Me.LbDesdeAgricultor.Text = "Desde Agricultor"
        '
        'LbNomDesdeAgricultor
        '
        Me.LbNomDesdeAgricultor.BackColor = System.Drawing.Color.LightGray
        Me.LbNomDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomDesdeAgricultor.CL_ValorFijo = False
        Me.LbNomDesdeAgricultor.ClForm = Nothing
        Me.LbNomDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDesdeAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDesdeAgricultor.Location = New System.Drawing.Point(250, 8)
        Me.LbNomDesdeAgricultor.Name = "LbNomDesdeAgricultor"
        Me.LbNomDesdeAgricultor.Size = New System.Drawing.Size(387, 23)
        Me.LbNomDesdeAgricultor.TabIndex = 75
        '
        'LbNomHastaAgricultor
        '
        Me.LbNomHastaAgricultor.BackColor = System.Drawing.Color.LightGray
        Me.LbNomHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomHastaAgricultor.CL_ValorFijo = False
        Me.LbNomHastaAgricultor.ClForm = Nothing
        Me.LbNomHastaAgricultor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomHastaAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomHastaAgricultor.Location = New System.Drawing.Point(250, 34)
        Me.LbNomHastaAgricultor.Name = "LbNomHastaAgricultor"
        Me.LbNomHastaAgricultor.Size = New System.Drawing.Size(387, 23)
        Me.LbNomHastaAgricultor.TabIndex = 79
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
        Me.TxHastaAgricultor.Location = New System.Drawing.Point(147, 34)
        Me.TxHastaAgricultor.MiError = False
        Me.TxHastaAgricultor.Name = "TxHastaAgricultor"
        Me.TxHastaAgricultor.Orden = 0
        Me.TxHastaAgricultor.SaltoAlfinal = False
        Me.TxHastaAgricultor.Siguiente = 0
        Me.TxHastaAgricultor.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaAgricultor.TabIndex = 78
        Me.TxHastaAgricultor.TeclaRepetida = False
        Me.TxHastaAgricultor.TxDatoFinalSemana = Nothing
        Me.TxHastaAgricultor.TxDatoInicioSemana = Nothing
        Me.TxHastaAgricultor.UltimoValorValidado = Nothing
        '
        'BtBuscaAg2
        '
        Me.BtBuscaAg2.CL_Ancho = 0
        Me.BtBuscaAg2.CL_BuscaAlb = False
        Me.BtBuscaAg2.CL_campocodigo = Nothing
        Me.BtBuscaAg2.CL_camponombre = Nothing
        Me.BtBuscaAg2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAg2.CL_ch1000 = False
        Me.BtBuscaAg2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAg2.CL_ControlAsociado = Nothing
        Me.BtBuscaAg2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAg2.CL_dfecha = Nothing
        Me.BtBuscaAg2.CL_Entidad = Nothing
        Me.BtBuscaAg2.CL_EsId = True
        Me.BtBuscaAg2.CL_Filtro = Nothing
        Me.BtBuscaAg2.cl_formu = Nothing
        Me.BtBuscaAg2.CL_hfecha = Nothing
        Me.BtBuscaAg2.cl_ListaW = Nothing
        Me.BtBuscaAg2.CL_xCentro = False
        Me.BtBuscaAg2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAg2.Location = New System.Drawing.Point(211, 34)
        Me.BtBuscaAg2.Name = "BtBuscaAg2"
        Me.BtBuscaAg2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAg2.TabIndex = 77
        Me.BtBuscaAg2.UseVisualStyleBackColor = True
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(13, 37)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(126, 16)
        Me.LbHastaAgricultor.TabIndex = 76
        Me.LbHastaAgricultor.Text = "Hasta Agricultor"
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(793, 34)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHastaFecha.TabIndex = 83
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(690, 37)
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(793, 8)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDesdeFecha.TabIndex = 81
        Me.TxDesdeFecha.TeclaRepetida = False
        Me.TxDesdeFecha.TxDatoFinalSemana = Nothing
        Me.TxDesdeFecha.TxDatoInicioSemana = Nothing
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(690, 11)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbTipoEntrada
        '
        Me.LbTipoEntrada.AutoSize = True
        Me.LbTipoEntrada.CL_ControlAsociado = Nothing
        Me.LbTipoEntrada.CL_ValorFijo = True
        Me.LbTipoEntrada.ClForm = Nothing
        Me.LbTipoEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoEntrada.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoEntrada.Location = New System.Drawing.Point(13, 63)
        Me.LbTipoEntrada.Name = "LbTipoEntrada"
        Me.LbTipoEntrada.Size = New System.Drawing.Size(99, 16)
        Me.LbTipoEntrada.TabIndex = 100274
        Me.LbTipoEntrada.Text = "Tipo entrada"
        '
        'CbTipoEntrada
        '
        Me.CbTipoEntrada.Campobd = Nothing
        Me.CbTipoEntrada.ClForm = Nothing
        Me.CbTipoEntrada.DeshabilitarRuedaRaton = False
        Me.CbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoEntrada.FormattingEnabled = True
        Me.CbTipoEntrada.GridLin = Nothing
        Me.CbTipoEntrada.Location = New System.Drawing.Point(147, 61)
        Me.CbTipoEntrada.MiEntidad = Nothing
        Me.CbTipoEntrada.MiError = False
        Me.CbTipoEntrada.Name = "CbTipoEntrada"
        Me.CbTipoEntrada.Orden = 0
        Me.CbTipoEntrada.SaltoAlfinal = False
        Me.CbTipoEntrada.Size = New System.Drawing.Size(284, 23)
        Me.CbTipoEntrada.TabIndex = 100275
        '
        'FrmConsultaEntradasEnPlazoSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 528)
        Me.Controls.Add(Me.LbNomHastaAgricultor)
        Me.Controls.Add(Me.TxHastaAgricultor)
        Me.Controls.Add(Me.BtBuscaAg2)
        Me.Controls.Add(Me.LbHastaAgricultor)
        Me.Controls.Add(Me.LbNomDesdeAgricultor)
        Me.Controls.Add(Me.TxDesdeAgricultor)
        Me.Controls.Add(Me.BtBuscaAg1)
        Me.Controls.Add(Me.LbDesdeAgricultor)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaEntradasEnPlazoSeguridad"
        Me.Text = "Consulta de Entradas en Plazo de Seguridad"
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAg1, 0)
        Me.Controls.SetChildIndex(Me.TxDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbNomDesdeAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbHastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAg2, 0)
        Me.Controls.SetChildIndex(Me.TxHastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.LbNomHastaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDesdeAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaAg1 As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents LbNomDesdeAgricultor As NetAgro.Lb
    Friend WithEvents LbNomHastaAgricultor As NetAgro.Lb
    Friend WithEvents TxHastaAgricultor As NetAgro.TxDato
    Friend WithEvents BtBuscaAg2 As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbTipoEntrada As NetAgro.Lb
    Friend WithEvents CbTipoEntrada As NetAgro.CbBox
End Class
