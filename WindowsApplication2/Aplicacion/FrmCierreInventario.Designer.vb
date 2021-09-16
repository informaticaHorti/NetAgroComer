<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierreInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreInventario))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxHastaFecha = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbAgricultores = New System.Windows.Forms.RadioButton()
        Me.RbClientes = New System.Windows.Forms.RadioButton()
        Me.RbInventario = New System.Windows.Forms.RadioButton()
        Me.TxEjerini = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.TxEjerini)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1184, 74)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 80)
        Me.PanelConsulta.Size = New System.Drawing.Size(1184, 455)
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
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(21, 18)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 172
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxHastaFecha
        '
        Me.TxHastaFecha.Autonumerico = False
        Me.TxHastaFecha.Buscando = False
        Me.TxHastaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxHastaFecha.ClForm = Nothing
        Me.TxHastaFecha.ClParam = Nothing
        Me.TxHastaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxHastaFecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHastaFecha.GridLin = Nothing
        Me.TxHastaFecha.HaCambiado = False
        Me.TxHastaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxHastaFecha.lbbusca = Nothing
        Me.TxHastaFecha.Location = New System.Drawing.Point(124, 15)
        Me.TxHastaFecha.MiError = False
        Me.TxHastaFecha.Name = "TxHastaFecha"
        Me.TxHastaFecha.Orden = 0
        Me.TxHastaFecha.SaltoAlfinal = False
        Me.TxHastaFecha.Siguiente = 0
        Me.TxHastaFecha.Size = New System.Drawing.Size(116, 23)
        Me.TxHastaFecha.TabIndex = 176
        Me.TxHastaFecha.TeclaRepetida = False
        Me.TxHastaFecha.TxDatoFinalSemana = Nothing
        Me.TxHastaFecha.TxDatoInicioSemana = Nothing
        Me.TxHastaFecha.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbAgricultores)
        Me.GroupBox1.Controls.Add(Me.RbClientes)
        Me.GroupBox1.Controls.Add(Me.RbInventario)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(265, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 42)
        Me.GroupBox1.TabIndex = 100280
        Me.GroupBox1.TabStop = False
        '
        'RbAgricultores
        '
        Me.RbAgricultores.AutoSize = True
        Me.RbAgricultores.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAgricultores.ForeColor = System.Drawing.Color.Teal
        Me.RbAgricultores.Location = New System.Drawing.Point(272, 15)
        Me.RbAgricultores.Name = "RbAgricultores"
        Me.RbAgricultores.Size = New System.Drawing.Size(114, 20)
        Me.RbAgricultores.TabIndex = 3
        Me.RbAgricultores.Text = "Agricultores"
        Me.RbAgricultores.UseVisualStyleBackColor = True
        '
        'RbClientes
        '
        Me.RbClientes.AutoSize = True
        Me.RbClientes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbClientes.ForeColor = System.Drawing.Color.Teal
        Me.RbClientes.Location = New System.Drawing.Point(145, 15)
        Me.RbClientes.Name = "RbClientes"
        Me.RbClientes.Size = New System.Drawing.Size(85, 20)
        Me.RbClientes.TabIndex = 2
        Me.RbClientes.Text = "Clientes"
        Me.RbClientes.UseVisualStyleBackColor = True
        '
        'RbInventario
        '
        Me.RbInventario.AutoSize = True
        Me.RbInventario.Checked = True
        Me.RbInventario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInventario.ForeColor = System.Drawing.Color.Teal
        Me.RbInventario.Location = New System.Drawing.Point(16, 15)
        Me.RbInventario.Name = "RbInventario"
        Me.RbInventario.Size = New System.Drawing.Size(106, 20)
        Me.RbInventario.TabIndex = 0
        Me.RbInventario.TabStop = True
        Me.RbInventario.Text = "Almacenes"
        Me.RbInventario.UseVisualStyleBackColor = True
        '
        'TxEjerini
        '
        Me.TxEjerini.Autonumerico = False
        Me.TxEjerini.Buscando = False
        Me.TxEjerini.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEjerini.ClForm = Nothing
        Me.TxEjerini.ClParam = Nothing
        Me.TxEjerini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjerini.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjerini.GridLin = Nothing
        Me.TxEjerini.HaCambiado = False
        Me.TxEjerini.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjerini.lbbusca = Nothing
        Me.TxEjerini.Location = New System.Drawing.Point(124, 44)
        Me.TxEjerini.MiError = False
        Me.TxEjerini.Name = "TxEjerini"
        Me.TxEjerini.Orden = 0
        Me.TxEjerini.SaltoAlfinal = False
        Me.TxEjerini.Siguiente = 0
        Me.TxEjerini.Size = New System.Drawing.Size(41, 23)
        Me.TxEjerini.TabIndex = 100282
        Me.TxEjerini.TeclaRepetida = False
        Me.TxEjerini.TxDatoFinalSemana = Nothing
        Me.TxEjerini.TxDatoInicioSemana = Nothing
        Me.TxEjerini.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 47)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(88, 16)
        Me.Lb1.TabIndex = 100281
        Me.Lb1.Text = "Ejer. inicial"
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(265, 48)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(907, 23)
        Me.Barra.TabIndex = 100283
        '
        'FrmCierreInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCierreInventario"
        Me.Text = "Cierre de inventario"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxHastaFecha As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbClientes As System.Windows.Forms.RadioButton
    Friend WithEvents RbInventario As System.Windows.Forms.RadioButton
    Friend WithEvents TxEjerini As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents RbAgricultores As System.Windows.Forms.RadioButton
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
End Class
