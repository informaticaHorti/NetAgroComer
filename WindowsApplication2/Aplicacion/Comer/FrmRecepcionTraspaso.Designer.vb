<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionTraspaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecepcionTraspaso))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.BSelTodos = New System.Windows.Forms.Button()
        Me.BSelNinguno = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelConsulta.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Controls.Add(Me.BtSelTodos)
        Me.PanelCabecera.Controls.Add(Me.BtSelNinguno)
        Me.PanelCabecera.Size = New System.Drawing.Size(763, 59)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Controls.Add(Me.BSelTodos)
        Me.PanelConsulta.Controls.Add(Me.BSelNinguno)
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 65)
        Me.PanelConsulta.Size = New System.Drawing.Size(763, 445)
        Me.PanelConsulta.Controls.SetChildIndex(Me.BSelNinguno, 0)
        Me.PanelConsulta.Controls.SetChildIndex(Me.BSelTodos, 0)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(463, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(538, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(613, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(688, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(388, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(728, 65)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100296
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(701, 65)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100297
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 22)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(75, 16)
        Me.Lb3.TabIndex = 100303
        Me.Lb3.Text = "De Fecha"
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
        Me.TxDeFecha.Location = New System.Drawing.Point(93, 19)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxDeFecha.TabIndex = 100302
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(223, 22)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(99, 16)
        Me.Lb4.TabIndex = 100305
        Me.Lb4.Text = "Hasta Fecha"
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(326, 19)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxHastaFecha.TabIndex = 100304
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'BSelTodos
        '
        Me.BSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSelTodos.Image = CType(resources.GetObject("BSelTodos.Image"), System.Drawing.Image)
        Me.BSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSelTodos.Location = New System.Drawing.Point(728, 36)
        Me.BSelTodos.Name = "BSelTodos"
        Me.BSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BSelTodos.TabIndex = 100292
        Me.BSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BSelTodos.UseVisualStyleBackColor = True
        '
        'BSelNinguno
        '
        Me.BSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSelNinguno.Image = CType(resources.GetObject("BSelNinguno.Image"), System.Drawing.Image)
        Me.BSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BSelNinguno.Location = New System.Drawing.Point(701, 36)
        Me.BSelNinguno.Name = "BSelNinguno"
        Me.BSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BSelNinguno.TabIndex = 100293
        Me.BSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BSelNinguno.UseVisualStyleBackColor = True
        '
        'FrmRecepcionTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmRecepcionTraspaso"
        Me.Text = "Recepción traspasos"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelConsulta.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents BSelTodos As System.Windows.Forms.Button
    Friend WithEvents BSelNinguno As System.Windows.Forms.Button
End Class
