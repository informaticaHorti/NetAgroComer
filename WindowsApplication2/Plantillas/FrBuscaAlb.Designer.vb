<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrBuscaAlb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrBuscaAlb))
        Me.TxHfecha = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDfecha = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.ChCentros = New System.Windows.Forms.CheckBox()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.ChCentros)
        Me.PanelCabecera.Controls.Add(Me.TxHfecha)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.TxDfecha)
        Me.PanelCabecera.Controls.Add(Me.Lb7)
        Me.PanelCabecera.Controls.Add(Me.Lb10)
        Me.PanelCabecera.Controls.Add(Me.TxCodigo)
        Me.PanelCabecera.Controls.Add(Me.BtBusca2)
        Me.PanelCabecera.Controls.Add(Me.Lb11)
        Me.PanelCabecera.Size = New System.Drawing.Size(962, 72)
        '
        'Panel3
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 72)
        Me.PanelConsulta.Size = New System.Drawing.Size(962, 422)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(662, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(737, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(812, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(887, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(587, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxHfecha
        '
        Me.TxHfecha.Autonumerico = False
        Me.TxHfecha.Buscando = False
        Me.TxHfecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHfecha.ClForm = Nothing
        Me.TxHfecha.ClParam = Nothing
        Me.TxHfecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHfecha.GridLin = Nothing
        Me.TxHfecha.HaCambiado = False
        Me.TxHfecha.lbbusca = Nothing
        Me.TxHfecha.Location = New System.Drawing.Point(352, 44)
        Me.TxHfecha.MiError = False
        Me.TxHfecha.Name = "TxHfecha"
        Me.TxHfecha.Orden = 0
        Me.TxHfecha.SaltoAlfinal = False
        Me.TxHfecha.Siguiente = 0
        Me.TxHfecha.Size = New System.Drawing.Size(102, 22)
        Me.TxHfecha.TabIndex = 95
        Me.TxHfecha.TeclaRepetida = False
        Me.TxHfecha.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(251, 48)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(95, 16)
        Me.Lb6.TabIndex = 94
        Me.Lb6.Text = "Hasta fecha"
        '
        'TxDfecha
        '
        Me.TxDfecha.Autonumerico = False
        Me.TxDfecha.Buscando = False
        Me.TxDfecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDfecha.ClForm = Nothing
        Me.TxDfecha.ClParam = Nothing
        Me.TxDfecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDfecha.GridLin = Nothing
        Me.TxDfecha.HaCambiado = False
        Me.TxDfecha.lbbusca = Nothing
        Me.TxDfecha.Location = New System.Drawing.Point(127, 42)
        Me.TxDfecha.MiError = False
        Me.TxDfecha.Name = "TxDfecha"
        Me.TxDfecha.Orden = 0
        Me.TxDfecha.SaltoAlfinal = False
        Me.TxDfecha.Siguiente = 0
        Me.TxDfecha.Size = New System.Drawing.Size(102, 22)
        Me.TxDfecha.TabIndex = 93
        Me.TxDfecha.TeclaRepetida = False
        Me.TxDfecha.UltimoValorValidado = Nothing
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(14, 44)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(97, 16)
        Me.Lb7.TabIndex = 92
        Me.Lb7.Text = "Desde fecha"
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb10.Location = New System.Drawing.Point(251, 12)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(518, 23)
        Me.Lb10.TabIndex = 87
        '
        'TxCodigo
        '
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(127, 12)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(63, 22)
        Me.TxCodigo.TabIndex = 86
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_Ancho = 0
        Me.BtBusca2.CL_BuscaAlb = False
        Me.BtBusca2.CL_campocodigo = Nothing
        Me.BtBusca2.CL_camponombre = Nothing
        Me.BtBusca2.CL_CampoOrden = "Nombre"
        Me.BtBusca2.CL_ch1000 = False
        Me.BtBusca2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca2.CL_ControlAsociado = Nothing
        Me.BtBusca2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca2.CL_dfecha = Nothing
        Me.BtBusca2.CL_Entidad = Nothing
        Me.BtBusca2.CL_EsId = True
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.CL_xCentro = False
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(196, 12)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 85
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(14, 15)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(58, 16)
        Me.Lb11.TabIndex = 84
        Me.Lb11.Text = "Código"
        '
        'ChCentros
        '
        Me.ChCentros.AutoSize = True
        Me.ChCentros.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChCentros.Location = New System.Drawing.Point(615, 47)
        Me.ChCentros.Name = "ChCentros"
        Me.ChCentros.Size = New System.Drawing.Size(154, 20)
        Me.ChCentros.TabIndex = 12
        Me.ChCentros.Text = "Todos los centros"
        Me.ChCentros.UseVisualStyleBackColor = True
        '
        'FrBuscaAlb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrBuscaAlb"
        Me.Text = "Consulta .."
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHfecha As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDfecha As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents ChCentros As System.Windows.Forms.CheckBox
End Class
