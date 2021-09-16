<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatEntrada))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaCategoria = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.CbBox1 = New NetAgro.CbBox(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.lb6 = New NetAgro.Lb(Me.components)
        Me.LbClasificacion = New NetAgro.Lb(Me.components)
        Me.TxClasificacion = New NetAgro.TxDato(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Grid.Location = New System.Drawing.Point(424, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(229, 194)
        Me.Grid.TabIndex = 57
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(209, 18)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 55
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaCategoria
        '
        Me.BtBuscaCategoria.CL_Ancho = 0
        Me.BtBuscaCategoria.CL_BuscaAlb = False
        Me.BtBuscaCategoria.CL_campocodigo = Nothing
        Me.BtBuscaCategoria.CL_camponombre = Nothing
        Me.BtBuscaCategoria.CL_CampoOrden = "Nombre"
        Me.BtBuscaCategoria.CL_ch1000 = False
        Me.BtBuscaCategoria.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCategoria.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaCategoria.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCategoria.CL_dfecha = Nothing
        Me.BtBuscaCategoria.CL_Entidad = Nothing
        Me.BtBuscaCategoria.CL_EsId = True
        Me.BtBuscaCategoria.CL_Filtro = Nothing
        Me.BtBuscaCategoria.cl_formu = Nothing
        Me.BtBuscaCategoria.CL_hfecha = Nothing
        Me.BtBuscaCategoria.cl_ListaW = Nothing
        Me.BtBuscaCategoria.CL_xCentro = False
        Me.BtBuscaCategoria.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCategoria.Location = New System.Drawing.Point(170, 18)
        Me.BtBuscaCategoria.Name = "BtBuscaCategoria"
        Me.BtBuscaCategoria.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCategoria.TabIndex = 56
        Me.BtBuscaCategoria.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(111, 19)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(53, 22)
        Me.TxDato1.TabIndex = 49
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(222, 51)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(38, 16)
        Me.Lb5.TabIndex = 54
        Me.Lb5.Text = "Tipo"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(6, 54)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(79, 16)
        Me.Lb2.TabIndex = 52
        Me.Lb2.Text = "Categoria"
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
        Me.TxDato2.Location = New System.Drawing.Point(111, 50)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(99, 22)
        Me.TxDato2.TabIndex = 51
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'CbBox1
        '
        Me.CbBox1.Campobd = Nothing
        Me.CbBox1.ClForm = Nothing
        Me.CbBox1.DeshabilitarRuedaRaton = False
        Me.CbBox1.FormattingEnabled = True
        Me.CbBox1.GridLin = Nothing
        Me.CbBox1.Location = New System.Drawing.Point(278, 50)
        Me.CbBox1.MiEntidad = Nothing
        Me.CbBox1.MiError = False
        Me.CbBox1.Name = "CbBox1"
        Me.CbBox1.Orden = 0
        Me.CbBox1.SaltoAlfinal = False
        Me.CbBox1.Size = New System.Drawing.Size(121, 21)
        Me.CbBox1.TabIndex = 53
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(6, 25)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 50
        Me.Lb1.Text = "Codigo"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(6, 125)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(59, 16)
        Me.Lb3.TabIndex = 59
        Me.Lb3.Text = "Calibre"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(111, 119)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(152, 22)
        Me.TxDato3.TabIndex = 58
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(6, 86)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(59, 16)
        Me.Lb4.TabIndex = 61
        Me.Lb4.Text = "Calibre"
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(111, 84)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(43, 22)
        Me.TxDato4.TabIndex = 60
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_Ancho = 0
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Me.TxDato1
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_EsId = True
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.CL_xCentro = False
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(160, 84)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 62
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'lb6
        '
        Me.lb6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb6.CL_ControlAsociado = Nothing
        Me.lb6.CL_ValorFijo = False
        Me.lb6.ClForm = Nothing
        Me.lb6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb6.Location = New System.Drawing.Point(204, 84)
        Me.lb6.Name = "lb6"
        Me.lb6.Size = New System.Drawing.Size(195, 23)
        Me.lb6.TabIndex = 136
        Me.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbClasificacion
        '
        Me.LbClasificacion.AutoSize = True
        Me.LbClasificacion.CL_ControlAsociado = Nothing
        Me.LbClasificacion.CL_ValorFijo = False
        Me.LbClasificacion.ClForm = Nothing
        Me.LbClasificacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClasificacion.ForeColor = System.Drawing.Color.Teal
        Me.LbClasificacion.Location = New System.Drawing.Point(6, 153)
        Me.LbClasificacion.Name = "LbClasificacion"
        Me.LbClasificacion.Size = New System.Drawing.Size(99, 16)
        Me.LbClasificacion.TabIndex = 138
        Me.LbClasificacion.Text = "Clasificacion"
        '
        'TxClasificacion
        '
        Me.TxClasificacion.Autonumerico = False
        Me.TxClasificacion.Buscando = False
        Me.TxClasificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClasificacion.ClForm = Nothing
        Me.TxClasificacion.ClParam = Nothing
        Me.TxClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClasificacion.GridLin = Nothing
        Me.TxClasificacion.HaCambiado = False
        Me.TxClasificacion.lbbusca = Nothing
        Me.TxClasificacion.Location = New System.Drawing.Point(111, 147)
        Me.TxClasificacion.MiError = False
        Me.TxClasificacion.Name = "TxClasificacion"
        Me.TxClasificacion.Orden = 0
        Me.TxClasificacion.SaltoAlfinal = False
        Me.TxClasificacion.Siguiente = 0
        Me.TxClasificacion.Size = New System.Drawing.Size(47, 22)
        Me.TxClasificacion.TabIndex = 137
        Me.TxClasificacion.TeclaRepetida = False
        Me.TxClasificacion.UltimoValorValidado = Nothing
        '
        'FrmCatEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 228)
        Me.Controls.Add(Me.LbClasificacion)
        Me.Controls.Add(Me.TxClasificacion)
        Me.Controls.Add(Me.lb6)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaCategoria)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.CbBox1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCatEntrada"
        Me.Text = "Categorias de entrada"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.CbBox1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCategoria, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.lb6, 0)
        Me.Controls.SetChildIndex(Me.TxClasificacion, 0)
        Me.Controls.SetChildIndex(Me.LbClasificacion, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaCategoria As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents CbBox1 As NetAgro.CbBox
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents lb6 As NetAgro.Lb
    Friend WithEvents LbClasificacion As NetAgro.Lb
    Friend WithEvents TxClasificacion As NetAgro.TxDato
End Class
