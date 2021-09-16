<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresas))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarca = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxDomicilio = New NetAgro.TxDato(Me.components)
        Me.LbDomicilio = New NetAgro.Lb(Me.components)
        Me.TxCIF = New NetAgro.TxDato(Me.components)
        Me.LbCIF = New NetAgro.Lb(Me.components)
        Me.TxTelefono = New NetAgro.TxDato(Me.components)
        Me.LbTelefono = New NetAgro.Lb(Me.components)
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
        Me.Grid.Location = New System.Drawing.Point(664, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(283, 197)
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
        Me.TxDato1.Location = New System.Drawing.Point(111, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.TxDato2.Location = New System.Drawing.Point(111, 51)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(326, 22)
        Me.TxDato2.TabIndex = 75
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BtBuscaMarca
        '
        Me.BtBuscaMarca.CL_Ancho = 0
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
        Me.BtBuscaMarca.Location = New System.Drawing.Point(163, 17)
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
        Me.BotonesAvance1.Location = New System.Drawing.Point(202, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxDomicilio
        '
        Me.TxDomicilio.Autonumerico = False
        Me.TxDomicilio.Buscando = False
        Me.TxDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDomicilio.ClForm = Nothing
        Me.TxDomicilio.ClParam = Nothing
        Me.TxDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDomicilio.GridLin = Nothing
        Me.TxDomicilio.HaCambiado = False
        Me.TxDomicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDomicilio.lbbusca = Nothing
        Me.TxDomicilio.Location = New System.Drawing.Point(111, 85)
        Me.TxDomicilio.MiError = False
        Me.TxDomicilio.Name = "TxDomicilio"
        Me.TxDomicilio.Orden = 0
        Me.TxDomicilio.SaltoAlfinal = False
        Me.TxDomicilio.Siguiente = 0
        Me.TxDomicilio.Size = New System.Drawing.Size(521, 22)
        Me.TxDomicilio.TabIndex = 79
        Me.TxDomicilio.TeclaRepetida = False
        Me.TxDomicilio.TxDatoFinalSemana = Nothing
        Me.TxDomicilio.TxDatoInicioSemana = Nothing
        Me.TxDomicilio.UltimoValorValidado = Nothing
        '
        'LbDomicilio
        '
        Me.LbDomicilio.AutoSize = True
        Me.LbDomicilio.CL_ControlAsociado = Nothing
        Me.LbDomicilio.CL_ValorFijo = False
        Me.LbDomicilio.ClForm = Nothing
        Me.LbDomicilio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilio.ForeColor = System.Drawing.Color.Teal
        Me.LbDomicilio.Location = New System.Drawing.Point(26, 87)
        Me.LbDomicilio.Name = "LbDomicilio"
        Me.LbDomicilio.Size = New System.Drawing.Size(74, 16)
        Me.LbDomicilio.TabIndex = 78
        Me.LbDomicilio.Text = "Domicilio"
        '
        'TxCIF
        '
        Me.TxCIF.Autonumerico = False
        Me.TxCIF.Buscando = False
        Me.TxCIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCIF.ClForm = Nothing
        Me.TxCIF.ClParam = Nothing
        Me.TxCIF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCIF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCIF.GridLin = Nothing
        Me.TxCIF.HaCambiado = False
        Me.TxCIF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCIF.lbbusca = Nothing
        Me.TxCIF.Location = New System.Drawing.Point(111, 117)
        Me.TxCIF.MiError = False
        Me.TxCIF.Name = "TxCIF"
        Me.TxCIF.Orden = 0
        Me.TxCIF.SaltoAlfinal = False
        Me.TxCIF.Siguiente = 0
        Me.TxCIF.Size = New System.Drawing.Size(161, 22)
        Me.TxCIF.TabIndex = 81
        Me.TxCIF.TeclaRepetida = False
        Me.TxCIF.TxDatoFinalSemana = Nothing
        Me.TxCIF.TxDatoInicioSemana = Nothing
        Me.TxCIF.UltimoValorValidado = Nothing
        '
        'LbCIF
        '
        Me.LbCIF.AutoSize = True
        Me.LbCIF.CL_ControlAsociado = Nothing
        Me.LbCIF.CL_ValorFijo = False
        Me.LbCIF.ClForm = Nothing
        Me.LbCIF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCIF.ForeColor = System.Drawing.Color.Teal
        Me.LbCIF.Location = New System.Drawing.Point(26, 119)
        Me.LbCIF.Name = "LbCIF"
        Me.LbCIF.Size = New System.Drawing.Size(33, 16)
        Me.LbCIF.TabIndex = 80
        Me.LbCIF.Text = "CIF"
        '
        'TxTelefono
        '
        Me.TxTelefono.Autonumerico = False
        Me.TxTelefono.Buscando = False
        Me.TxTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTelefono.ClForm = Nothing
        Me.TxTelefono.ClParam = Nothing
        Me.TxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTelefono.GridLin = Nothing
        Me.TxTelefono.HaCambiado = False
        Me.TxTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTelefono.lbbusca = Nothing
        Me.TxTelefono.Location = New System.Drawing.Point(111, 148)
        Me.TxTelefono.MiError = False
        Me.TxTelefono.Name = "TxTelefono"
        Me.TxTelefono.Orden = 0
        Me.TxTelefono.SaltoAlfinal = False
        Me.TxTelefono.Siguiente = 0
        Me.TxTelefono.Size = New System.Drawing.Size(117, 22)
        Me.TxTelefono.TabIndex = 83
        Me.TxTelefono.TeclaRepetida = False
        Me.TxTelefono.TxDatoFinalSemana = Nothing
        Me.TxTelefono.TxDatoInicioSemana = Nothing
        Me.TxTelefono.UltimoValorValidado = Nothing
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.CL_ControlAsociado = Nothing
        Me.LbTelefono.CL_ValorFijo = False
        Me.LbTelefono.ClForm = Nothing
        Me.LbTelefono.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono.ForeColor = System.Drawing.Color.Teal
        Me.LbTelefono.Location = New System.Drawing.Point(26, 150)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(70, 16)
        Me.LbTelefono.TabIndex = 82
        Me.LbTelefono.Text = "Telefono"
        '
        'FrmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 231)
        Me.Controls.Add(Me.TxTelefono)
        Me.Controls.Add(Me.LbTelefono)
        Me.Controls.Add(Me.TxCIF)
        Me.Controls.Add(Me.LbCIF)
        Me.Controls.Add(Me.TxDomicilio)
        Me.Controls.Add(Me.LbDomicilio)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaMarca)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEmpresas"
        Me.Text = "Empresas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.LbDomicilio, 0)
        Me.Controls.SetChildIndex(Me.TxDomicilio, 0)
        Me.Controls.SetChildIndex(Me.LbCIF, 0)
        Me.Controls.SetChildIndex(Me.TxCIF, 0)
        Me.Controls.SetChildIndex(Me.LbTelefono, 0)
        Me.Controls.SetChildIndex(Me.TxTelefono, 0)
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
    Friend WithEvents TxDomicilio As NetAgro.TxDato
    Friend WithEvents LbDomicilio As NetAgro.Lb
    Friend WithEvents TxCIF As NetAgro.TxDato
    Friend WithEvents LbCIF As NetAgro.Lb
    Friend WithEvents TxTelefono As NetAgro.TxDato
    Friend WithEvents LbTelefono As NetAgro.Lb
End Class
