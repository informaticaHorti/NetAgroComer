<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArregloValoracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArregloValoracion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Button2)
        Me.PanelCabecera.Controls.Add(Me.Button1)
        Me.PanelCabecera.Controls.Add(Me.TextBox1)
        Me.PanelCabecera.Controls.Add(Me.Label1)
        Me.PanelCabecera.Size = New System.Drawing.Size(677, 73)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 89)
        Me.PanelConsulta.Size = New System.Drawing.Size(677, 433)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(377, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(452, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(527, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(602, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(302, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "BORRAR VALORACION COMISION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadena conexion copia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(528, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Driver={SQL Server Native Client 10.0};Server=SAT2006;Database=NETAGROCOMER_COPIA" & _
    ";Uid=sa;Persist Security Info=true;Pwd=Adminis;"
        '
        'ArregloValoracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "ArregloValoracion"
        Me.Text = "Consulta Listado Proveedores"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
