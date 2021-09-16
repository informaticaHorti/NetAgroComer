<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarcas))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarca = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.ChkEnvases = New NetAgro.Chk(Me.components)
        Me.ChkMaterial = New NetAgro.Chk(Me.components)
        Me.ChkEtiqueta = New NetAgro.Chk(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Right
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(493, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(283, 175)
        Me.Grid.TabIndex = 71
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView.Appearance.Row.Options.UseFont = True
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
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
        Me.Lb1.ClForm = Nothing
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
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(103, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        Me.TxDato1.TeclaRepetida = False
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(103, 51)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(326, 22)
        Me.TxDato2.TabIndex = 75
        Me.TxDato2.TeclaRepetida = False
        '
        'BtBuscaMarca
        '
        Me.BtBuscaMarca.CL_BuscaAlb = False
        Me.BtBuscaMarca.CL_campocodigo = Nothing
        Me.BtBuscaMarca.CL_camponombre = Nothing
        Me.BtBuscaMarca.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarca.CL_ch1000 = False
        Me.BtBuscaMarca.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarca.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaMarca.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarca.CL_dfecha = Nothing
        Me.BtBuscaMarca.CL_Entidad = Nothing
        Me.BtBuscaMarca.CL_EsId = True
        Me.BtBuscaMarca.CL_Filtro = Nothing
        Me.BtBuscaMarca.cl_formu = Nothing
        Me.BtBuscaMarca.CL_hfecha = Nothing
        Me.BtBuscaMarca.cl_ListaW = Nothing
        Me.BtBuscaMarca.CL_xCentro = False
        Me.BtBuscaMarca.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMarca.Location = New System.Drawing.Point(155, 17)
        Me.BtBuscaMarca.Name = "BtBuscaMarca"
        Me.BtBuscaMarca.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarca.TabIndex = 76
        Me.BtBuscaMarca.UseVisualStyleBackColor = True
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
        'ChkEnvases
        '
        Me.ChkEnvases.AutoSize = True
        Me.ChkEnvases.Campobd = Nothing
        Me.ChkEnvases.ClForm = Nothing
        Me.ChkEnvases.Enabled = False
        Me.ChkEnvases.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEnvases.ForeColor = System.Drawing.Color.Teal
        Me.ChkEnvases.GridLin = Nothing
        Me.ChkEnvases.HaCambiado = False
        Me.ChkEnvases.Location = New System.Drawing.Point(29, 95)
        Me.ChkEnvases.MiEntidad = Nothing
        Me.ChkEnvases.MiError = False
        Me.ChkEnvases.Name = "ChkEnvases"
        Me.ChkEnvases.Orden = 0
        Me.ChkEnvases.SaltoAlfinal = False
        Me.ChkEnvases.Size = New System.Drawing.Size(88, 20)
        Me.ChkEnvases.TabIndex = 164
        Me.ChkEnvases.Text = "Envases"
        Me.ChkEnvases.UseVisualStyleBackColor = True
        Me.ChkEnvases.ValorCampoFalse = Nothing
        Me.ChkEnvases.ValorCampoTrue = Nothing
        Me.ChkEnvases.ValorDefecto = False
        '
        'ChkMaterial
        '
        Me.ChkMaterial.AutoSize = True
        Me.ChkMaterial.Campobd = Nothing
        Me.ChkMaterial.ClForm = Nothing
        Me.ChkMaterial.Enabled = False
        Me.ChkMaterial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMaterial.ForeColor = System.Drawing.Color.Teal
        Me.ChkMaterial.GridLin = Nothing
        Me.ChkMaterial.HaCambiado = False
        Me.ChkMaterial.Location = New System.Drawing.Point(140, 95)
        Me.ChkMaterial.MiEntidad = Nothing
        Me.ChkMaterial.MiError = False
        Me.ChkMaterial.Name = "ChkMaterial"
        Me.ChkMaterial.Orden = 0
        Me.ChkMaterial.SaltoAlfinal = False
        Me.ChkMaterial.Size = New System.Drawing.Size(103, 20)
        Me.ChkMaterial.TabIndex = 165
        Me.ChkMaterial.Text = "Materiales"
        Me.ChkMaterial.UseVisualStyleBackColor = True
        Me.ChkMaterial.ValorCampoFalse = Nothing
        Me.ChkMaterial.ValorCampoTrue = Nothing
        Me.ChkMaterial.ValorDefecto = False
        '
        'ChkEtiqueta
        '
        Me.ChkEtiqueta.AutoSize = True
        Me.ChkEtiqueta.Campobd = Nothing
        Me.ChkEtiqueta.ClForm = Nothing
        Me.ChkEtiqueta.Enabled = False
        Me.ChkEtiqueta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEtiqueta.ForeColor = System.Drawing.Color.Teal
        Me.ChkEtiqueta.GridLin = Nothing
        Me.ChkEtiqueta.HaCambiado = False
        Me.ChkEtiqueta.Location = New System.Drawing.Point(263, 95)
        Me.ChkEtiqueta.MiEntidad = Nothing
        Me.ChkEtiqueta.MiError = False
        Me.ChkEtiqueta.Name = "ChkEtiqueta"
        Me.ChkEtiqueta.Orden = 0
        Me.ChkEtiqueta.SaltoAlfinal = False
        Me.ChkEtiqueta.Size = New System.Drawing.Size(96, 20)
        Me.ChkEtiqueta.TabIndex = 166
        Me.ChkEtiqueta.Text = "Etiquetas"
        Me.ChkEtiqueta.UseVisualStyleBackColor = True
        Me.ChkEtiqueta.ValorCampoFalse = Nothing
        Me.ChkEtiqueta.ValorCampoTrue = Nothing
        Me.ChkEtiqueta.ValorDefecto = False
        '
        'FrmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 209)
        Me.Controls.Add(Me.ChkEtiqueta)
        Me.Controls.Add(Me.ChkMaterial)
        Me.Controls.Add(Me.ChkEnvases)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaMarca)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmMarcas"
        Me.Text = "Marcas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.ChkEnvases, 0)
        Me.Controls.SetChildIndex(Me.ChkMaterial, 0)
        Me.Controls.SetChildIndex(Me.ChkEtiqueta, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarca As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents ChkEnvases As NetAgro.Chk
    Friend WithEvents ChkMaterial As NetAgro.Chk
    Friend WithEvents ChkEtiqueta As NetAgro.Chk
End Class
