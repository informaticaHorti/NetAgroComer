<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaTrazabilidadLote

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
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaTrazabilidadLote))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbNombreGenero = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.LbFechaLote = New NetAgro.Lb(Me.components)
        Me.LbCodGenero = New NetAgro.Lb(Me.components)
        Me.GridPartidas = New DevExpress.XtraGrid.GridControl()
        Me.GridPartidasView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Gridpreca = New DevExpress.XtraGrid.GridControl()
        Me.GridViewpreca = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPartidasView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridpreca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewpreca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.Button2)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Gridpreca)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.GridPartidas)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.LbCodGenero)
        Me.PanelCabecera.Controls.Add(Me.LbFechaLote)
        Me.PanelCabecera.Controls.Add(Me.LbNombreGenero)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Size = New System.Drawing.Size(953, 187)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 221)
        Me.PanelConsulta.Size = New System.Drawing.Size(953, 301)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(636, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(728, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(803, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(878, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(561, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(108, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(88, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(40, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Lote"
        '
        'LbNombreGenero
        '
        Me.LbNombreGenero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNombreGenero.CL_ControlAsociado = Nothing
        Me.LbNombreGenero.CL_ValorFijo = False
        Me.LbNombreGenero.ClForm = Nothing
        Me.LbNombreGenero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreGenero.Location = New System.Drawing.Point(539, 13)
        Me.LbNombreGenero.Name = "LbNombreGenero"
        Me.LbNombreGenero.Size = New System.Drawing.Size(392, 23)
        Me.LbNombreGenero.TabIndex = 79
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(401, 16)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(60, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Genero"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(220, 16)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(52, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Fecha"
        '
        'LbFechaLote
        '
        Me.LbFechaLote.BackColor = System.Drawing.Color.White
        Me.LbFechaLote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbFechaLote.CL_ControlAsociado = Nothing
        Me.LbFechaLote.CL_ValorFijo = False
        Me.LbFechaLote.ClForm = Nothing
        Me.LbFechaLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaLote.ForeColor = System.Drawing.Color.Black
        Me.LbFechaLote.Location = New System.Drawing.Point(278, 14)
        Me.LbFechaLote.Name = "LbFechaLote"
        Me.LbFechaLote.Size = New System.Drawing.Size(102, 21)
        Me.LbFechaLote.TabIndex = 116
        Me.LbFechaLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCodGenero
        '
        Me.LbCodGenero.BackColor = System.Drawing.Color.White
        Me.LbCodGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCodGenero.CL_ControlAsociado = Nothing
        Me.LbCodGenero.CL_ValorFijo = False
        Me.LbCodGenero.ClForm = Nothing
        Me.LbCodGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodGenero.ForeColor = System.Drawing.Color.Black
        Me.LbCodGenero.Location = New System.Drawing.Point(467, 13)
        Me.LbCodGenero.Name = "LbCodGenero"
        Me.LbCodGenero.Size = New System.Drawing.Size(63, 22)
        Me.LbCodGenero.TabIndex = 117
        Me.LbCodGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridPartidas
        '
        GridLevelNode3.RelationName = "Level1"
        GridLevelNode4.RelationName = "Level2"
        Me.GridPartidas.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.GridPartidas.Location = New System.Drawing.Point(16, 70)
        Me.GridPartidas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridPartidas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridPartidas.MainView = Me.GridPartidasView
        Me.GridPartidas.Name = "GridPartidas"
        Me.GridPartidas.Size = New System.Drawing.Size(539, 117)
        Me.GridPartidas.TabIndex = 118
        Me.GridPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPartidasView})
        '
        'GridPartidasView
        '
        Me.GridPartidasView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridPartidasView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridPartidasView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridPartidasView.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridPartidasView.Appearance.Row.Options.UseFont = True
        Me.GridPartidasView.GridControl = Me.GridPartidas
        Me.GridPartidasView.Name = "GridPartidasView"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(351, 44)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(204, 25)
        Me.Lb3.TabIndex = 119
        Me.Lb3.Text = "Partidas del lote"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(11, 193)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(179, 25)
        Me.Lb5.TabIndex = 120
        Me.Lb5.Text = "Palets del lote"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(684, 44)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(266, 25)
        Me.Lb6.TabIndex = 121
        Me.Lb6.Text = "Precalibrados del lote"
        '
        'Gridpreca
        '
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.Gridpreca.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.Gridpreca.Location = New System.Drawing.Point(561, 70)
        Me.Gridpreca.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Gridpreca.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Gridpreca.MainView = Me.GridViewpreca
        Me.Gridpreca.Name = "Gridpreca"
        Me.Gridpreca.Size = New System.Drawing.Size(390, 117)
        Me.Gridpreca.TabIndex = 120
        Me.Gridpreca.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewpreca})
        '
        'GridViewpreca
        '
        Me.GridViewpreca.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewpreca.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.GridViewpreca.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridViewpreca.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewpreca.Appearance.Row.Options.UseFont = True
        Me.GridViewpreca.GridControl = Me.Gridpreca
        Me.GridViewpreca.Name = "GridViewpreca"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 23)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "Ver clasificacion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmConsultaTrazabilidadLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 562)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaTrazabilidadLote"
        Me.Text = "Consulta Trazabilidad"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPartidasView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridpreca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewpreca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbNombreGenero As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents LbCodGenero As NetAgro.Lb
    Friend WithEvents LbFechaLote As NetAgro.Lb
    Friend WithEvents GridPartidas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridPartidasView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Gridpreca As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewpreca As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
