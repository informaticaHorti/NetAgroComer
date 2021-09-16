<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaPalet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargaPalet))
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbCarga = New NetAgro.Lb(Me.components)
        Me.TxPalet = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCarga = New NetAgro.BtBusca(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.LbTipoPalet = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbMuelle = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
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
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(0, 72)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(739, 170)
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
        'LbCarga
        '
        Me.LbCarga.AutoSize = True
        Me.LbCarga.CL_ControlAsociado = Nothing
        Me.LbCarga.CL_ValorFijo = False
        Me.LbCarga.ClForm = Nothing
        Me.LbCarga.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCarga.ForeColor = System.Drawing.Color.Teal
        Me.LbCarga.Location = New System.Drawing.Point(8, 6)
        Me.LbCarga.Name = "LbCarga"
        Me.LbCarga.Size = New System.Drawing.Size(106, 16)
        Me.LbCarga.TabIndex = 66
        Me.LbCarga.Text = "Número palet"
        '
        'TxPalet
        '
        Me.TxPalet.Autonumerico = False
        Me.TxPalet.Buscando = False
        Me.TxPalet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPalet.ClForm = Nothing
        Me.TxPalet.ClParam = Nothing
        Me.TxPalet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxPalet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPalet.GridLin = Nothing
        Me.TxPalet.HaCambiado = False
        Me.TxPalet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxPalet.lbbusca = Nothing
        Me.TxPalet.Location = New System.Drawing.Point(124, 4)
        Me.TxPalet.MiError = False
        Me.TxPalet.Name = "TxPalet"
        Me.TxPalet.Orden = 0
        Me.TxPalet.SaltoAlfinal = False
        Me.TxPalet.Siguiente = 0
        Me.TxPalet.Size = New System.Drawing.Size(91, 22)
        Me.TxPalet.TabIndex = 74
        Me.TxPalet.TeclaRepetida = False
        Me.TxPalet.TxDatoFinalSemana = Nothing
        Me.TxPalet.TxDatoInicioSemana = Nothing
        Me.TxPalet.UltimoValorValidado = Nothing
        '
        'BtBuscaCarga
        '
        Me.BtBuscaCarga.CL_Ancho = 0
        Me.BtBuscaCarga.CL_BuscaAlb = False
        Me.BtBuscaCarga.CL_campocodigo = Nothing
        Me.BtBuscaCarga.CL_camponombre = Nothing
        Me.BtBuscaCarga.CL_CampoOrden = "Nombre"
        Me.BtBuscaCarga.CL_ch1000 = False
        Me.BtBuscaCarga.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCarga.CL_ControlAsociado = Me.TxPalet
        Me.BtBuscaCarga.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCarga.CL_dfecha = Nothing
        Me.BtBuscaCarga.CL_Entidad = Nothing
        Me.BtBuscaCarga.CL_EsId = True
        Me.BtBuscaCarga.CL_Filtro = Nothing
        Me.BtBuscaCarga.cl_formu = Nothing
        Me.BtBuscaCarga.CL_hfecha = Nothing
        Me.BtBuscaCarga.cl_ListaW = Nothing
        Me.BtBuscaCarga.CL_xCentro = False
        Me.BtBuscaCarga.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCarga.Location = New System.Drawing.Point(221, 4)
        Me.BtBuscaCarga.Name = "BtBuscaCarga"
        Me.BtBuscaCarga.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCarga.TabIndex = 76
        Me.BtBuscaCarga.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(269, 7)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(52, 16)
        Me.Lb3.TabIndex = 77
        Me.Lb3.Text = "Fecha"
        '
        'LbFecha
        '
        Me.LbFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFecha.Location = New System.Drawing.Point(327, 5)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(100, 21)
        Me.LbFecha.TabIndex = 95
        '
        'LbTipoPalet
        '
        Me.LbTipoPalet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTipoPalet.CL_ControlAsociado = Nothing
        Me.LbTipoPalet.CL_ValorFijo = False
        Me.LbTipoPalet.ClForm = Nothing
        Me.LbTipoPalet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoPalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipoPalet.Location = New System.Drawing.Point(127, 34)
        Me.LbTipoPalet.Name = "LbTipoPalet"
        Me.LbTipoPalet.Size = New System.Drawing.Size(300, 21)
        Me.LbTipoPalet.TabIndex = 97
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(8, 34)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(79, 16)
        Me.Lb2.TabIndex = 96
        Me.Lb2.Text = "Tipo palet"
        '
        'LbMuelle
        '
        Me.LbMuelle.BackColor = System.Drawing.Color.White
        Me.LbMuelle.CL_ControlAsociado = Nothing
        Me.LbMuelle.CL_ValorFijo = True
        Me.LbMuelle.ClForm = Nothing
        Me.LbMuelle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMuelle.ForeColor = System.Drawing.Color.Red
        Me.LbMuelle.Location = New System.Drawing.Point(693, 5)
        Me.LbMuelle.Name = "LbMuelle"
        Me.LbMuelle.Size = New System.Drawing.Size(35, 21)
        Me.LbMuelle.TabIndex = 104
        Me.LbMuelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(619, 7)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(55, 16)
        Me.Lb1.TabIndex = 103
        Me.Lb1.Text = "Muelle"
        '
        'SerialPort1
        '
        '
        'FrmCargaPalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 276)
        Me.Controls.Add(Me.LbMuelle)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.LbTipoPalet)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.BtBuscaCarga)
        Me.Controls.Add(Me.TxPalet)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.LbCarga)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCargaPalet"
        Me.Text = "Cargas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbCarga, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.TxPalet, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCarga, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.LbFecha, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.LbTipoPalet, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.LbMuelle, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbCarga As NetAgro.Lb
    Friend WithEvents TxPalet As NetAgro.TxDato
    Friend WithEvents BtBuscaCarga As NetAgro.BtBusca
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents LbTipoPalet As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbMuelle As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
End Class
