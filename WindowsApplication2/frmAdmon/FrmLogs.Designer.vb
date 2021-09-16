<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs))
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.CbUsuario = New NetAgro.CbBox(Me.components)
        Me.CbTabla = New NetAgro.CbBox(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.CbOperacion = New NetAgro.CbBox(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Size = New System.Drawing.Size(916, 82)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 85)
        Me.PanelConsulta.Size = New System.Drawing.Size(916, 379)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(616, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(691, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(766, 0)
        Me.BInforme.Visible = False
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(841, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(541, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(115, 43)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato_2.TabIndex = 83
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 46)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 82
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(115, 11)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato_1.TabIndex = 81
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 14)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Desde fecha"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(259, 14)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(63, 16)
        Me.Lb3.TabIndex = 84
        Me.Lb3.Text = "Usuario"
        '
        'CbUsuario
        '
        Me.CbUsuario.Campobd = Nothing
        Me.CbUsuario.ClForm = Nothing
        Me.CbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbUsuario.FormattingEnabled = True
        Me.CbUsuario.GridLin = Nothing
        Me.CbUsuario.Location = New System.Drawing.Point(328, 10)
        Me.CbUsuario.MiEntidad = Nothing
        Me.CbUsuario.MiError = False
        Me.CbUsuario.Name = "CbUsuario"
        Me.CbUsuario.Orden = 0
        Me.CbUsuario.SaltoAlfinal = False
        Me.CbUsuario.Size = New System.Drawing.Size(167, 24)
        Me.CbUsuario.TabIndex = 85
        '
        'CbTabla
        '
        Me.CbTabla.Campobd = Nothing
        Me.CbTabla.ClForm = Nothing
        Me.CbTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTabla.FormattingEnabled = True
        Me.CbTabla.GridLin = Nothing
        Me.CbTabla.Location = New System.Drawing.Point(328, 42)
        Me.CbTabla.MiEntidad = Nothing
        Me.CbTabla.MiError = False
        Me.CbTabla.Name = "CbTabla"
        Me.CbTabla.Orden = 0
        Me.CbTabla.SaltoAlfinal = False
        Me.CbTabla.Size = New System.Drawing.Size(167, 24)
        Me.CbTabla.TabIndex = 87
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(259, 46)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(47, 16)
        Me.Lb4.TabIndex = 86
        Me.Lb4.Text = "Tabla"
        '
        'CbOperacion
        '
        Me.CbOperacion.Campobd = Nothing
        Me.CbOperacion.ClForm = Nothing
        Me.CbOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbOperacion.FormattingEnabled = True
        Me.CbOperacion.GridLin = Nothing
        Me.CbOperacion.Location = New System.Drawing.Point(632, 10)
        Me.CbOperacion.MiEntidad = Nothing
        Me.CbOperacion.MiError = False
        Me.CbOperacion.Name = "CbOperacion"
        Me.CbOperacion.Orden = 0
        Me.CbOperacion.SaltoAlfinal = False
        Me.CbOperacion.Size = New System.Drawing.Size(119, 24)
        Me.CbOperacion.TabIndex = 91
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(534, 14)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(82, 16)
        Me.Lb5.TabIndex = 90
        Me.Lb5.Text = "Operacion"
        '
        'FrmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 504)
        Me.Controls.Add(Me.CbOperacion)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.CbTabla)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.CbUsuario)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato_2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato_1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Usuarios"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato_1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato_2, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.CbUsuario, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.CbTabla, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.CbOperacion, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents CbUsuario As NetAgro.CbBox
    Friend WithEvents CbTabla As NetAgro.CbBox
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents CbOperacion As NetAgro.CbBox
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
