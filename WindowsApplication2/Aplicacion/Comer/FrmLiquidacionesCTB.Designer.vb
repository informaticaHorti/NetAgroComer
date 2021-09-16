<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidacionesCTB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidacionesCTB))
        Me.LbDFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxaFecha = New NetAgro.TxDato(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1117, 60)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 60)
        Me.PanelConsulta.Size = New System.Drawing.Size(1117, 434)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(817, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(892, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(967, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1042, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(742, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbDFecha
        '
        Me.LbDFecha.AutoSize = True
        Me.LbDFecha.CL_ControlAsociado = Nothing
        Me.LbDFecha.CL_ValorFijo = False
        Me.LbDFecha.ClForm = Nothing
        Me.LbDFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDFecha.Location = New System.Drawing.Point(7, 14)
        Me.LbDFecha.Name = "LbDFecha"
        Me.LbDFecha.Size = New System.Drawing.Size(179, 16)
        Me.LbDFecha.TabIndex = 116
        Me.LbDFecha.Text = "Desde fecha liquidación"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(196, 11)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFecha.TabIndex = 115
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(347, 14)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(177, 16)
        Me.LbAFecha.TabIndex = 100273
        Me.LbAFecha.Text = "Hasta fecha liquidación"
        '
        'TxaFecha
        '
        Me.TxaFecha.Autonumerico = False
        Me.TxaFecha.Buscando = False
        Me.TxaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxaFecha.ClForm = Nothing
        Me.TxaFecha.ClParam = Nothing
        Me.TxaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxaFecha.GridLin = Nothing
        Me.TxaFecha.HaCambiado = False
        Me.TxaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxaFecha.lbbusca = Nothing
        Me.TxaFecha.Location = New System.Drawing.Point(533, 11)
        Me.TxaFecha.MiError = False
        Me.TxaFecha.Name = "TxaFecha"
        Me.TxaFecha.Orden = 0
        Me.TxaFecha.SaltoAlfinal = False
        Me.TxaFecha.Siguiente = 0
        Me.TxaFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxaFecha.TabIndex = 100272
        Me.TxaFecha.TeclaRepetida = False
        Me.TxaFecha.TxDatoFinalSemana = Nothing
        Me.TxaFecha.TxDatoInicioSemana = Nothing
        Me.TxaFecha.UltimoValorValidado = Nothing
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(729, 9)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(363, 23)
        Me.Barra.TabIndex = 100285
        '
        'FrmLiquidacionesCTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmLiquidacionesCTB"
        Me.Text = "Contabilizar liquidaciones"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbDFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxaFecha As NetAgro.TxDato
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
End Class
