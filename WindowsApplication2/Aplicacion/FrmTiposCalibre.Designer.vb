<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiposCalibre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiposCalibre))
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaTgasto = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(184, 22)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 46
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaTgasto
        '
        Me.BtBuscaTgasto.CL_BuscaAlb = False
        Me.BtBuscaTgasto.CL_campocodigo = Nothing
        Me.BtBuscaTgasto.CL_camponombre = Nothing
        Me.BtBuscaTgasto.CL_CampoOrden = "Nombre"
        Me.BtBuscaTgasto.CL_ch1000 = False
        Me.BtBuscaTgasto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTgasto.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaTgasto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTgasto.CL_dfecha = Nothing
        Me.BtBuscaTgasto.CL_Entidad = Nothing
        Me.BtBuscaTgasto.CL_Filtro = Nothing
        Me.BtBuscaTgasto.cl_formu = Nothing
        Me.BtBuscaTgasto.CL_hfecha = Nothing
        Me.BtBuscaTgasto.cl_ListaW = Nothing
        Me.BtBuscaTgasto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTgasto.Location = New System.Drawing.Point(145, 22)
        Me.BtBuscaTgasto.Name = "BtBuscaTgasto"
        Me.BtBuscaTgasto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTgasto.TabIndex = 47
        Me.BtBuscaTgasto.UseVisualStyleBackColor = True
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(86, 23)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(53, 22)
        Me.TxDato1.TabIndex = 40
        Me.TxDato1.TeclaRepetida = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 56)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 43
        Me.Lb2.Text = "Nombre"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(86, 54)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(121, 22)
        Me.TxDato2.TabIndex = 42
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
        Me.Lb1.Location = New System.Drawing.Point(12, 25)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 41
        Me.Lb1.Text = "Codigo"
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Right
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(317, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(252, 199)
        Me.Grid.TabIndex = 72
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
        'FrmTiposCalibre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 233)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaTgasto)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTiposCalibre"
        Me.Text = "Tipos de calibre"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaTgasto, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaTgasto As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
