<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerificacionMuestreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerificacionMuestreo))
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 83)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 89)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 433)
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(357, 46)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(254, 49)
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(115, 46)
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(12, 49)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(12, 18)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100283
        Me.LbSemana.Text = "Semana"
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(115, 15)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(43, 22)
        Me.TxSemana.TabIndex = 100282
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'FrmVerificacionMuestreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmVerificacionMuestreo"
        Me.Text = "Verificación muestreo"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
End Class
