<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsientosRetencionesMes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsientosRetencionesMes))
        Me.TxFechaAsiento = New NetAgro.TxDato(Me.components)
        Me.LbFechaAsiento = New NetAgro.Lb(Me.components)
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.TxFechaAsiento)
        Me.PanelCabecera.Controls.Add(Me.LbFechaAsiento)
        Me.PanelCabecera.Size = New System.Drawing.Size(786, 56)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 56)
        Me.PanelConsulta.Size = New System.Drawing.Size(786, 443)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(486, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(561, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(636, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(711, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(411, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxFechaAsiento
        '
        Me.TxFechaAsiento.Autonumerico = False
        Me.TxFechaAsiento.Buscando = False
        Me.TxFechaAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaAsiento.ClForm = Nothing
        Me.TxFechaAsiento.ClParam = Nothing
        Me.TxFechaAsiento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaAsiento.GridLin = Nothing
        Me.TxFechaAsiento.HaCambiado = False
        Me.TxFechaAsiento.lbbusca = Nothing
        Me.TxFechaAsiento.Location = New System.Drawing.Point(139, 18)
        Me.TxFechaAsiento.MiError = False
        Me.TxFechaAsiento.Name = "TxFechaAsiento"
        Me.TxFechaAsiento.Orden = 0
        Me.TxFechaAsiento.SaltoAlfinal = False
        Me.TxFechaAsiento.Siguiente = 0
        Me.TxFechaAsiento.Size = New System.Drawing.Size(99, 22)
        Me.TxFechaAsiento.TabIndex = 78
        Me.TxFechaAsiento.TeclaRepetida = False
        Me.TxFechaAsiento.TxDatoFinalSemana = Nothing
        Me.TxFechaAsiento.TxDatoInicioSemana = Nothing
        Me.TxFechaAsiento.UltimoValorValidado = Nothing
        '
        'LbFechaAsiento
        '
        Me.LbFechaAsiento.AutoSize = True
        Me.LbFechaAsiento.CL_ControlAsociado = Nothing
        Me.LbFechaAsiento.CL_ValorFijo = False
        Me.LbFechaAsiento.ClForm = Nothing
        Me.LbFechaAsiento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaAsiento.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaAsiento.Location = New System.Drawing.Point(15, 21)
        Me.LbFechaAsiento.Name = "LbFechaAsiento"
        Me.LbFechaAsiento.Size = New System.Drawing.Size(110, 16)
        Me.LbFechaAsiento.TabIndex = 76
        Me.LbFechaAsiento.Text = "Fecha asiento"
        '
        'lbTotal
        '
        Me.lbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbTotal.Location = New System.Drawing.Point(520, 503)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(75, 19)
        Me.lbTotal.TabIndex = 12
        Me.lbTotal.Text = "TOTAL: "
        '
        'FrmAsientosRetencionesMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 562)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAsientosRetencionesMes"
        Me.Text = "Asientos retenciones mes"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.lbTotal, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxFechaAsiento As NetAgro.TxDato
    Friend WithEvents LbFechaAsiento As NetAgro.Lb
    Friend WithEvents lbTotal As System.Windows.Forms.Label
End Class
