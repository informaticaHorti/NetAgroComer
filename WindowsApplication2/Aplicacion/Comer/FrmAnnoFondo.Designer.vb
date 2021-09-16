<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnnoFondo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnnoFondo))
        Me.TxDesdeFecha = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.btSelNinguno = New System.Windows.Forms.Button()
        Me.btSelTodos = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.btSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.btSelTodos)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1081, 56)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 56)
        Me.PanelConsulta.Size = New System.Drawing.Size(1081, 443)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(781, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(856, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(931, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1006, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(706, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
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
        Me.TxDesdeFecha.Location = New System.Drawing.Point(178, 18)
        Me.TxDesdeFecha.MiError = False
        Me.TxDesdeFecha.Name = "TxDesdeFecha"
        Me.TxDesdeFecha.Orden = 0
        Me.TxDesdeFecha.SaltoAlfinal = False
        Me.TxDesdeFecha.Siguiente = 0
        Me.TxDesdeFecha.Size = New System.Drawing.Size(99, 22)
        Me.TxDesdeFecha.TabIndex = 78
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
        Me.LbDesdeFecha.Location = New System.Drawing.Point(15, 21)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(157, 16)
        Me.LbDesdeFecha.TabIndex = 76
        Me.LbDesdeFecha.Text = "Desde fecha Factura"
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
        Me.TxHastaFecha.Location = New System.Drawing.Point(488, 18)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(99, 22)
        Me.TxHastaFecha.TabIndex = 80
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(325, 21)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(155, 16)
        Me.LbHastaFecha.TabIndex = 79
        Me.LbHastaFecha.Text = "Hasta fecha Factura"
        '
        'btSelNinguno
        '
        Me.btSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelNinguno.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.btSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelNinguno.Location = New System.Drawing.Point(1019, 28)
        Me.btSelNinguno.Name = "btSelNinguno"
        Me.btSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.btSelNinguno.TabIndex = 100308
        Me.btSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelNinguno.UseVisualStyleBackColor = True
        '
        'btSelTodos
        '
        Me.btSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelTodos.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.btSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSelTodos.Location = New System.Drawing.Point(1046, 28)
        Me.btSelTodos.Name = "btSelTodos"
        Me.btSelTodos.Size = New System.Drawing.Size(31, 25)
        Me.btSelTodos.TabIndex = 100307
        Me.btSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSelTodos.UseVisualStyleBackColor = True
        '
        'FrmAnnoFondo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAnnoFondo"
        Me.Text = "Actualizar año fondo operativo"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDesdeFecha As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents btSelNinguno As System.Windows.Forms.Button
    Friend WithEvents btSelTodos As System.Windows.Forms.Button
End Class
