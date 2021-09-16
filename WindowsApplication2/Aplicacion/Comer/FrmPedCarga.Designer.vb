<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedCarga
    Inherits System.Windows.Forms.Form

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
        Me.Lbpedido = New System.Windows.Forms.Label()
        Me.LbCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbPalped = New System.Windows.Forms.Label()
        Me.LbParCar = New System.Windows.Forms.Label()
        Me.LbPalPte = New System.Windows.Forms.Label()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LbAlbaran = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbpedido
        '
        Me.Lbpedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbpedido.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbpedido.Location = New System.Drawing.Point(13, 29)
        Me.Lbpedido.Name = "Lbpedido"
        Me.Lbpedido.Size = New System.Drawing.Size(124, 34)
        Me.Lbpedido.TabIndex = 0
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.Location = New System.Drawing.Point(264, 29)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(442, 34)
        Me.LbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PEDIDOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CARGADOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PENDIENTES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbPalped
        '
        Me.LbPalped.BackColor = System.Drawing.Color.White
        Me.LbPalped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPalped.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalped.Location = New System.Drawing.Point(12, 113)
        Me.LbPalped.Name = "LbPalped"
        Me.LbPalped.Size = New System.Drawing.Size(191, 143)
        Me.LbPalped.TabIndex = 5
        Me.LbPalped.Text = "00"
        Me.LbPalped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbParCar
        '
        Me.LbParCar.BackColor = System.Drawing.Color.White
        Me.LbParCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbParCar.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbParCar.Location = New System.Drawing.Point(243, 113)
        Me.LbParCar.Name = "LbParCar"
        Me.LbParCar.Size = New System.Drawing.Size(191, 143)
        Me.LbParCar.TabIndex = 6
        Me.LbParCar.Text = "00"
        Me.LbParCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbPalPte
        '
        Me.LbPalPte.BackColor = System.Drawing.Color.White
        Me.LbPalPte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPalPte.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalPte.ForeColor = System.Drawing.Color.Red
        Me.LbPalPte.Location = New System.Drawing.Point(466, 113)
        Me.LbPalPte.Name = "LbPalPte"
        Me.LbPalPte.Size = New System.Drawing.Size(191, 143)
        Me.LbPalPte.TabIndex = 7
        Me.LbPalPte.Text = "00"
        Me.LbPalPte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(12, 268)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(645, 219)
        Me.Grid.TabIndex = 100
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
        'LbAlbaran
        '
        Me.LbAlbaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbAlbaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbAlbaran.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran.Location = New System.Drawing.Point(138, 29)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(124, 34)
        Me.LbAlbaran.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Pedido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Albarán"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 23)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Cliente"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FrmPedCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 499)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LbAlbaran)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.LbPalPte)
        Me.Controls.Add(Me.LbParCar)
        Me.Controls.Add(Me.LbPalped)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbCliente)
        Me.Controls.Add(Me.Lbpedido)
        Me.Name = "FrmPedCarga"
        Me.Text = "Estado del pedido"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbpedido As System.Windows.Forms.Label
    Friend WithEvents LbCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbPalped As System.Windows.Forms.Label
    Friend WithEvents LbParCar As System.Windows.Forms.Label
    Friend WithEvents LbPalPte As System.Windows.Forms.Label
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LbAlbaran As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
