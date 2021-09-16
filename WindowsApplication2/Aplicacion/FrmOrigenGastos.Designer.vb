<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrigenGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrigenGastos))
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaTgasto = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbBox1 = New NetAgro.CbBox(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
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
        Me.BtBuscaTgasto.CL_Ancho = 0
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
        Me.BtBuscaTgasto.CL_EsId = True
        Me.BtBuscaTgasto.CL_Filtro = Nothing
        Me.BtBuscaTgasto.cl_formu = Nothing
        Me.BtBuscaTgasto.CL_hfecha = Nothing
        Me.BtBuscaTgasto.cl_ListaW = Nothing
        Me.BtBuscaTgasto.CL_xCentro = False
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
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.TxDato2.Size = New System.Drawing.Size(381, 22)
        Me.TxDato2.TabIndex = 42
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
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
        Me.Grid.Location = New System.Drawing.Point(680, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(332, 292)
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
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(12, 88)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(38, 16)
        Me.Lb5.TabIndex = 74
        Me.Lb5.Text = "Tipo"
        '
        'CbBox1
        '
        Me.CbBox1.Campobd = Nothing
        Me.CbBox1.ClForm = Nothing
        Me.CbBox1.DeshabilitarRuedaRaton = False
        Me.CbBox1.FormattingEnabled = True
        Me.CbBox1.GridLin = Nothing
        Me.CbBox1.Location = New System.Drawing.Point(86, 87)
        Me.CbBox1.MiEntidad = Nothing
        Me.CbBox1.MiError = False
        Me.CbBox1.Name = "CbBox1"
        Me.CbBox1.Orden = 0
        Me.CbBox1.SaltoAlfinal = False
        Me.CbBox1.Size = New System.Drawing.Size(121, 21)
        Me.CbBox1.TabIndex = 73
        '
        'Lb6
        '
        Me.Lb6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(340, 125)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(334, 23)
        Me.Lb6.TabIndex = 210
        Me.Lb6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(150, 125)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(143, 22)
        Me.TxDato6.TabIndex = 208
        Me.TxDato6.TeclaRepetida = False
        Me.TxDato6.TxDatoFinalSemana = Nothing
        Me.TxDato6.TxDatoInicioSemana = Nothing
        Me.TxDato6.UltimoValorValidado = Nothing
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_Ancho = 0
        Me.BtBusca2.CL_BuscaAlb = False
        Me.BtBusca2.CL_campocodigo = Nothing
        Me.BtBusca2.CL_camponombre = Nothing
        Me.BtBusca2.CL_CampoOrden = "Nombre"
        Me.BtBusca2.CL_ch1000 = False
        Me.BtBusca2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca2.CL_ControlAsociado = Me.TxDato6
        Me.BtBusca2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca2.CL_dfecha = Nothing
        Me.BtBusca2.CL_Entidad = Nothing
        Me.BtBusca2.CL_EsId = True
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.CL_xCentro = False
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(301, 125)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 209
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.BackColor = System.Drawing.Color.Transparent
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(12, 128)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(125, 16)
        Me.Lb15.TabIndex = 207
        Me.Lb15.Text = "Nº cuenta gasto"
        '
        'FrmOrigenGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 326)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.TxDato6)
        Me.Controls.Add(Me.BtBusca2)
        Me.Controls.Add(Me.Lb15)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.CbBox1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaTgasto)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmOrigenGastos"
        Me.Text = "Origen gastos"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaTgasto, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.CbBox1, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.Lb15, 0)
        Me.Controls.SetChildIndex(Me.BtBusca2, 0)
        Me.Controls.SetChildIndex(Me.TxDato6, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
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
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbBox1 As NetAgro.CbBox
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb15 As NetAgro.Lb
End Class
