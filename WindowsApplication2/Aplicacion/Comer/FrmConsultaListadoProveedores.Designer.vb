<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaListadoProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaListadoProveedores))
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Size = New System.Drawing.Size(1320, 117)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 0)
        Me.PanelConsulta.Size = New System.Drawing.Size(1320, 522)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1020, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1095, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1170, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1245, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(945, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'FrmConsultaListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaListadoProveedores"
        Me.Text = "Consulta Listado Proveedores"
        Me.ResumeLayout(False)

    End Sub
End Class
