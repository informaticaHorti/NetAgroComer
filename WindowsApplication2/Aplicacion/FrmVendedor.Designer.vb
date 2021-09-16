<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendedor
    Inherits NetAgro.FrMantenimiento

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendedor))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaVdor = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Right
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(435, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(283, 207)
        Me.Grid.TabIndex = 71
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(26, 53)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 68
        Me.Lb2.Text = "Nombre"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(26, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Codigo"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.Location = New System.Drawing.Point(103, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.Location = New System.Drawing.Point(103, 51)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.Size = New System.Drawing.Size(326, 22)
        Me.TxDato2.TabIndex = 75
        '
        'BtBuscaVdor
        '
        Me.BtBuscaVdor.CL_CampoOrden = "Nombre"
        Me.BtBuscaVdor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaVdor.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaVdor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaVdor.CL_Entidad = Nothing
        Me.BtBuscaVdor.CL_Filtro = Nothing
        Me.BtBuscaVdor.cl_formu = Nothing
        Me.BtBuscaVdor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaVdor.Location = New System.Drawing.Point(155, 17)
        Me.BtBuscaVdor.Name = "BtBuscaVdor"
        Me.BtBuscaVdor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaVdor.TabIndex = 76
        Me.BtBuscaVdor.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(194, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.Location = New System.Drawing.Point(103, 87)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.Size = New System.Drawing.Size(204, 22)
        Me.TxDato3.TabIndex = 79
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(26, 89)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(70, 16)
        Me.Lb3.TabIndex = 78
        Me.Lb3.Text = "Telefono"
        '
        'FrmVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 241)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaVdor)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmVendedor"
        Me.Text = "Vendedores"
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaVdor, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaVdor As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
End Class
