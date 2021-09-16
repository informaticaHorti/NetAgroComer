<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarRegistrosAmortizaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportarRegistrosAmortizaciones))
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxRutafichero = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.btExplorar = New System.Windows.Forms.Button()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.btExplorar)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxRutafichero)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.ProgressBar1)
        Me.PanelCabecera.Controls.Add(Me.BtSelTodos)
        Me.PanelCabecera.Controls.Add(Me.BtSelNinguno)
        Me.PanelCabecera.Size = New System.Drawing.Size(984, 99)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 99)
        Me.PanelConsulta.Size = New System.Drawing.Size(984, 428)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(684, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(759, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(834, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(909, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(609, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(951, 59)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100296
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(924, 59)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100297
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(524, 60)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(385, 23)
        Me.ProgressBar1.TabIndex = 100298
        '
        'Lb3
        '
        Me.Lb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(442, 65)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(73, 16)
        Me.Lb3.TabIndex = 100299
        Me.Lb3.Text = "Progreso"
        '
        'TxRutafichero
        '
        Me.TxRutafichero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxRutafichero.Autonumerico = False
        Me.TxRutafichero.BackColor = System.Drawing.Color.White
        Me.TxRutafichero.Buscando = False
        Me.TxRutafichero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRutafichero.ClForm = Nothing
        Me.TxRutafichero.ClParam = Nothing
        Me.TxRutafichero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxRutafichero.GridLin = Nothing
        Me.TxRutafichero.HaCambiado = False
        Me.TxRutafichero.lbbusca = Nothing
        Me.TxRutafichero.Location = New System.Drawing.Point(123, 32)
        Me.TxRutafichero.MiError = False
        Me.TxRutafichero.Name = "TxRutafichero"
        Me.TxRutafichero.Orden = 0
        Me.TxRutafichero.ReadOnly = True
        Me.TxRutafichero.SaltoAlfinal = False
        Me.TxRutafichero.Siguiente = 0
        Me.TxRutafichero.Size = New System.Drawing.Size(743, 22)
        Me.TxRutafichero.TabIndex = 100300
        Me.TxRutafichero.TeclaRepetida = False
        Me.TxRutafichero.TxDatoFinalSemana = Nothing
        Me.TxRutafichero.TxDatoInicioSemana = Nothing
        Me.TxRutafichero.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 34)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(105, 16)
        Me.Lb1.TabIndex = 100301
        Me.Lb1.Text = "Fichero Excel"
        '
        'btExplorar
        '
        Me.btExplorar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btExplorar.Location = New System.Drawing.Point(869, 32)
        Me.btExplorar.Name = "btExplorar"
        Me.btExplorar.Size = New System.Drawing.Size(40, 22)
        Me.btExplorar.TabIndex = 100302
        Me.btExplorar.Text = "..."
        Me.btExplorar.UseVisualStyleBackColor = True
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'FrmImportarRegistrosAmortizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmImportarRegistrosAmortizaciones"
        Me.Text = "Importar registros de amortizaciones desde Excel"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxRutafichero As NetAgro.TxDato
    Friend WithEvents btExplorar As System.Windows.Forms.Button
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
End Class
