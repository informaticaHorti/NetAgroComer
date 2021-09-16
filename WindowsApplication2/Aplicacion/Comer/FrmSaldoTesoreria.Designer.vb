<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaldoTesoreria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldoTesoreria))
        Me.TxhaFecha = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxdeFecha = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Size = New System.Drawing.Size(760, 79)
        '
        'Panel3
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 79)
        Me.PanelConsulta.Size = New System.Drawing.Size(760, 415)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(460, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(535, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(610, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(685, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(385, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxhaFecha
        '
        Me.TxhaFecha.Autonumerico = False
        Me.TxhaFecha.Buscando = False
        Me.TxhaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxhaFecha.ClForm = Nothing
        Me.TxhaFecha.ClParam = Nothing
        Me.TxhaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxhaFecha.GridLin = Nothing
        Me.TxhaFecha.HaCambiado = False
        Me.TxhaFecha.lbbusca = Nothing
        Me.TxhaFecha.Location = New System.Drawing.Point(126, 40)
        Me.TxhaFecha.MiError = False
        Me.TxhaFecha.Name = "TxhaFecha"
        Me.TxhaFecha.Orden = 0
        Me.TxhaFecha.SaltoAlfinal = False
        Me.TxhaFecha.Siguiente = 0
        Me.TxhaFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxhaFecha.TabIndex = 83
        Me.TxhaFecha.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(13, 48)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(95, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Hasta fecha"
        '
        'TxdeFecha
        '
        Me.TxdeFecha.Autonumerico = False
        Me.TxdeFecha.Buscando = False
        Me.TxdeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxdeFecha.ClForm = Nothing
        Me.TxdeFecha.ClParam = Nothing
        Me.TxdeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxdeFecha.GridLin = Nothing
        Me.TxdeFecha.HaCambiado = False
        Me.TxdeFecha.lbbusca = Nothing
        Me.TxdeFecha.Location = New System.Drawing.Point(126, 8)
        Me.TxdeFecha.MiError = False
        Me.TxdeFecha.Name = "TxdeFecha"
        Me.TxdeFecha.Orden = 0
        Me.TxdeFecha.SaltoAlfinal = False
        Me.TxdeFecha.Siguiente = 0
        Me.TxdeFecha.Size = New System.Drawing.Size(102, 22)
        Me.TxdeFecha.TabIndex = 81
        Me.TxdeFecha.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(11, 12)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(97, 16)
        Me.Lb5.TabIndex = 80
        Me.Lb5.Text = "Desde fecha"
        '
        'FrmSaldoTesoreria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 528)
        Me.Controls.Add(Me.TxhaFecha)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.TxdeFecha)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmSaldoTesoreria"
        Me.Text = "Analisis del saldo de tesoreria"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.TxdeFecha, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.TxhaFecha, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxhaFecha As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxdeFecha As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb

End Class
