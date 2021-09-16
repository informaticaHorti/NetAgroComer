<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodoMedioExpedicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodoMedioExpedicion))
        Me.LbNombreDesdeGenero = New NetAgro.Lb(Me.components)
        Me.TxDesdeGenero = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDesdeGenero = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.BtBuscaHastaGenero = New NetAgro.BtBusca(Me.components)
        Me.TxHastaGenero = New NetAgro.TxDato(Me.components)
        Me.LbNombreHastaGenero = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.TxHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNombreHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbNombreDesdeGenero)
        Me.PanelCabecera.Size = New System.Drawing.Size(922, 74)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 74)
        Me.PanelConsulta.Size = New System.Drawing.Size(922, 420)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(622, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(697, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(772, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(847, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(547, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbNombreDesdeGenero
        '
        Me.LbNombreDesdeGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreDesdeGenero.CL_ControlAsociado = Nothing
        Me.LbNombreDesdeGenero.CL_ValorFijo = False
        Me.LbNombreDesdeGenero.ClForm = Nothing
        Me.LbNombreDesdeGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreDesdeGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreDesdeGenero.Location = New System.Drawing.Point(476, 11)
        Me.LbNombreDesdeGenero.Name = "LbNombreDesdeGenero"
        Me.LbNombreDesdeGenero.Size = New System.Drawing.Size(409, 23)
        Me.LbNombreDesdeGenero.TabIndex = 79
        '
        'TxDesdeGenero
        '
        Me.TxDesdeGenero.Autonumerico = False
        Me.TxDesdeGenero.Buscando = False
        Me.TxDesdeGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDesdeGenero.ClForm = Nothing
        Me.TxDesdeGenero.ClParam = Nothing
        Me.TxDesdeGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesdeGenero.GridLin = Nothing
        Me.TxDesdeGenero.HaCambiado = False
        Me.TxDesdeGenero.lbbusca = Nothing
        Me.TxDesdeGenero.Location = New System.Drawing.Point(368, 11)
        Me.TxDesdeGenero.MiError = False
        Me.TxDesdeGenero.Name = "TxDesdeGenero"
        Me.TxDesdeGenero.Orden = 0
        Me.TxDesdeGenero.SaltoAlfinal = False
        Me.TxDesdeGenero.Siguiente = 0
        Me.TxDesdeGenero.Size = New System.Drawing.Size(63, 22)
        Me.TxDesdeGenero.TabIndex = 78
        Me.TxDesdeGenero.TeclaRepetida = False
        Me.TxDesdeGenero.TxDatoFinalSemana = Nothing
        Me.TxDesdeGenero.TxDatoInicioSemana = Nothing
        Me.TxDesdeGenero.UltimoValorValidado = Nothing
        '
        'BtBuscaDesdeGenero
        '
        Me.BtBuscaDesdeGenero.CL_Ancho = 0
        Me.BtBuscaDesdeGenero.CL_BuscaAlb = False
        Me.BtBuscaDesdeGenero.CL_campocodigo = Nothing
        Me.BtBuscaDesdeGenero.CL_camponombre = Nothing
        Me.BtBuscaDesdeGenero.CL_CampoOrden = "Nombre"
        Me.BtBuscaDesdeGenero.CL_ch1000 = False
        Me.BtBuscaDesdeGenero.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDesdeGenero.CL_ControlAsociado = Nothing
        Me.BtBuscaDesdeGenero.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDesdeGenero.CL_dfecha = Nothing
        Me.BtBuscaDesdeGenero.CL_Entidad = Nothing
        Me.BtBuscaDesdeGenero.CL_EsId = True
        Me.BtBuscaDesdeGenero.CL_Filtro = Nothing
        Me.BtBuscaDesdeGenero.cl_formu = Nothing
        Me.BtBuscaDesdeGenero.CL_hfecha = Nothing
        Me.BtBuscaDesdeGenero.cl_ListaW = Nothing
        Me.BtBuscaDesdeGenero.CL_xCentro = False
        Me.BtBuscaDesdeGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDesdeGenero.Location = New System.Drawing.Point(437, 11)
        Me.BtBuscaDesdeGenero.Name = "BtBuscaDesdeGenero"
        Me.BtBuscaDesdeGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDesdeGenero.TabIndex = 77
        Me.BtBuscaDesdeGenero.UseVisualStyleBackColor = True
        '
        'LbDesdeGenero
        '
        Me.LbDesdeGenero.AutoSize = True
        Me.LbDesdeGenero.CL_ControlAsociado = Nothing
        Me.LbDesdeGenero.CL_ValorFijo = False
        Me.LbDesdeGenero.ClForm = Nothing
        Me.LbDesdeGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeGenero.Location = New System.Drawing.Point(253, 14)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 76
        Me.LbDesdeGenero.Text = "Desde Género"
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(110, 38)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(7, 41)
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(110, 11)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(7, 14)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbHastaGenero
        '
        Me.LbHastaGenero.AutoSize = True
        Me.LbHastaGenero.CL_ControlAsociado = Nothing
        Me.LbHastaGenero.CL_ValorFijo = False
        Me.LbHastaGenero.ClForm = Nothing
        Me.LbHastaGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaGenero.Location = New System.Drawing.Point(253, 41)
        Me.LbHastaGenero.Name = "LbHastaGenero"
        Me.LbHastaGenero.Size = New System.Drawing.Size(107, 16)
        Me.LbHastaGenero.TabIndex = 84
        Me.LbHastaGenero.Text = "Hasta Género"
        '
        'BtBuscaHastaGenero
        '
        Me.BtBuscaHastaGenero.CL_Ancho = 0
        Me.BtBuscaHastaGenero.CL_BuscaAlb = False
        Me.BtBuscaHastaGenero.CL_campocodigo = Nothing
        Me.BtBuscaHastaGenero.CL_camponombre = Nothing
        Me.BtBuscaHastaGenero.CL_CampoOrden = "Nombre"
        Me.BtBuscaHastaGenero.CL_ch1000 = False
        Me.BtBuscaHastaGenero.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaHastaGenero.CL_ControlAsociado = Nothing
        Me.BtBuscaHastaGenero.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaHastaGenero.CL_dfecha = Nothing
        Me.BtBuscaHastaGenero.CL_Entidad = Nothing
        Me.BtBuscaHastaGenero.CL_EsId = True
        Me.BtBuscaHastaGenero.CL_Filtro = Nothing
        Me.BtBuscaHastaGenero.cl_formu = Nothing
        Me.BtBuscaHastaGenero.CL_hfecha = Nothing
        Me.BtBuscaHastaGenero.cl_ListaW = Nothing
        Me.BtBuscaHastaGenero.CL_xCentro = False
        Me.BtBuscaHastaGenero.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaHastaGenero.Location = New System.Drawing.Point(437, 38)
        Me.BtBuscaHastaGenero.Name = "BtBuscaHastaGenero"
        Me.BtBuscaHastaGenero.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaHastaGenero.TabIndex = 85
        Me.BtBuscaHastaGenero.UseVisualStyleBackColor = True
        '
        'TxHastaGenero
        '
        Me.TxHastaGenero.Autonumerico = False
        Me.TxHastaGenero.Buscando = False
        Me.TxHastaGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaGenero.ClForm = Nothing
        Me.TxHastaGenero.ClParam = Nothing
        Me.TxHastaGenero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaGenero.GridLin = Nothing
        Me.TxHastaGenero.HaCambiado = False
        Me.TxHastaGenero.lbbusca = Nothing
        Me.TxHastaGenero.Location = New System.Drawing.Point(368, 38)
        Me.TxHastaGenero.MiError = False
        Me.TxHastaGenero.Name = "TxHastaGenero"
        Me.TxHastaGenero.Orden = 0
        Me.TxHastaGenero.SaltoAlfinal = False
        Me.TxHastaGenero.Siguiente = 0
        Me.TxHastaGenero.Size = New System.Drawing.Size(63, 22)
        Me.TxHastaGenero.TabIndex = 86
        Me.TxHastaGenero.TeclaRepetida = False
        Me.TxHastaGenero.TxDatoFinalSemana = Nothing
        Me.TxHastaGenero.TxDatoInicioSemana = Nothing
        Me.TxHastaGenero.UltimoValorValidado = Nothing
        '
        'LbNombreHastaGenero
        '
        Me.LbNombreHastaGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreHastaGenero.CL_ControlAsociado = Nothing
        Me.LbNombreHastaGenero.CL_ValorFijo = False
        Me.LbNombreHastaGenero.ClForm = Nothing
        Me.LbNombreHastaGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreHastaGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreHastaGenero.Location = New System.Drawing.Point(476, 38)
        Me.LbNombreHastaGenero.Name = "LbNombreHastaGenero"
        Me.LbNombreHastaGenero.Size = New System.Drawing.Size(409, 23)
        Me.LbNombreHastaGenero.TabIndex = 87
        '
        'FrmPeriodoMedioExpedicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPeriodoMedioExpedicion"
        Me.Text = "Periodos Medios"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbNombreDesdeGenero As NetAgro.Lb
    Friend WithEvents TxDesdeGenero As NetAgro.TxDato
    Friend WithEvents BtBuscaDesdeGenero As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents BtBuscaHastaGenero As NetAgro.BtBusca
    Friend WithEvents TxHastaGenero As NetAgro.TxDato
    Friend WithEvents LbNombreHastaGenero As NetAgro.Lb
End Class
