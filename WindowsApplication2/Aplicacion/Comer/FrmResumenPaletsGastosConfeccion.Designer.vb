<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResumenPaletsGastosConfeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResumenPaletsGastosConfeccion))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbDetallado = New System.Windows.Forms.RadioButton()
        Me.RbResumido = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbFechaPalet = New System.Windows.Forms.RadioButton()
        Me.RbFechaAlbSalida = New System.Windows.Forms.RadioButton()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 89)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 95)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 440)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(884, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(959, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1034, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1109, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(809, 0)
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
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(14, 55)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(99, 16)
        Me.Lb2.TabIndex = 100300
        Me.Lb2.Text = "Hasta Fecha"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(119, 52)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 100301
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 23)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(101, 16)
        Me.Lb1.TabIndex = 100298
        Me.Lb1.Text = "Desde Fecha"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(119, 20)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 100299
        Me.TxDato1.TeclaRepetida = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbDetallado)
        Me.GroupBox1.Controls.Add(Me.RbResumido)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(246, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 75)
        Me.GroupBox1.TabIndex = 100302
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo listado"
        '
        'RbDetallado
        '
        Me.RbDetallado.AutoSize = True
        Me.RbDetallado.Checked = True
        Me.RbDetallado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetallado.ForeColor = System.Drawing.Color.Teal
        Me.RbDetallado.Location = New System.Drawing.Point(15, 46)
        Me.RbDetallado.Name = "RbDetallado"
        Me.RbDetallado.Size = New System.Drawing.Size(95, 20)
        Me.RbDetallado.TabIndex = 2
        Me.RbDetallado.TabStop = True
        Me.RbDetallado.Text = "Detallado"
        Me.RbDetallado.UseVisualStyleBackColor = True
        '
        'RbResumido
        '
        Me.RbResumido.AutoSize = True
        Me.RbResumido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbResumido.ForeColor = System.Drawing.Color.Teal
        Me.RbResumido.Location = New System.Drawing.Point(16, 18)
        Me.RbResumido.Name = "RbResumido"
        Me.RbResumido.Size = New System.Drawing.Size(97, 20)
        Me.RbResumido.TabIndex = 0
        Me.RbResumido.Text = "Resumido"
        Me.RbResumido.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbFechaPalet)
        Me.GroupBox2.Controls.Add(Me.RbFechaAlbSalida)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(410, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 75)
        Me.GroupBox2.TabIndex = 100303
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por fechas"
        '
        'RbFechaPalet
        '
        Me.RbFechaPalet.AutoSize = True
        Me.RbFechaPalet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaPalet.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaPalet.Location = New System.Drawing.Point(15, 46)
        Me.RbFechaPalet.Name = "RbFechaPalet"
        Me.RbFechaPalet.Size = New System.Drawing.Size(139, 20)
        Me.RbFechaPalet.TabIndex = 2
        Me.RbFechaPalet.Text = "Por Fecha Palet"
        Me.RbFechaPalet.UseVisualStyleBackColor = True
        '
        'RbFechaAlbSalida
        '
        Me.RbFechaAlbSalida.AutoSize = True
        Me.RbFechaAlbSalida.Checked = True
        Me.RbFechaAlbSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFechaAlbSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbFechaAlbSalida.Location = New System.Drawing.Point(16, 18)
        Me.RbFechaAlbSalida.Name = "RbFechaAlbSalida"
        Me.RbFechaAlbSalida.Size = New System.Drawing.Size(228, 20)
        Me.RbFechaAlbSalida.TabIndex = 0
        Me.RbFechaAlbSalida.TabStop = True
        Me.RbFechaAlbSalida.Text = "Por Fecha Albarán de Salida"
        Me.RbFechaAlbSalida.UseVisualStyleBackColor = True
        '
        'FrmResumenPaletsGastosConfeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmResumenPaletsGastosConfeccion"
        Me.Text = "Resumen de Palets y Gastos de Confección"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents RbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbFechaPalet As System.Windows.Forms.RadioButton
    Friend WithEvents RbFechaAlbSalida As System.Windows.Forms.RadioButton
End Class
