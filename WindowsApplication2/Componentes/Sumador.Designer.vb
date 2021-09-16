<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sumador
    Inherits System.Windows.Forms.Form

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ControlGrid = New DevExpress.XtraGrid.GridControl()
        Me.Grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ControlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ControlGrid)
        Me.Panel1.Controls.Add(Me.Lb5)
        Me.Panel1.Controls.Add(Me.TxDato_1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 244)
        Me.Panel1.TabIndex = 0
        '
        'ControlGrid
        '
        Me.ControlGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlGrid.Location = New System.Drawing.Point(6, 61)
        Me.ControlGrid.MainView = Me.Grid
        Me.ControlGrid.Name = "ControlGrid"
        Me.ControlGrid.Size = New System.Drawing.Size(185, 170)
        Me.ControlGrid.TabIndex = 100205
        Me.ControlGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid})
        '
        'Grid
        '
        Me.Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Grid.GridControl = Me.ControlGrid
        Me.Grid.Name = "Grid"
        Me.Grid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid.OptionsBehavior.Editable = False
        Me.Grid.OptionsNavigation.AutoMoveRowFocus = False
        Me.Grid.OptionsView.AutoCalcPreviewLineCount = True
        Me.Grid.OptionsView.ShowFooter = True
        Me.Grid.OptionsView.ShowGroupedColumns = True
        Me.Grid.OptionsView.ShowGroupPanel = False
        '
        'Lb5
        '
        Me.Lb5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(124, 14)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(67, 16)
        Me.Lb5.TabIndex = 178
        Me.Lb5.Text = "Importe"
        '
        'TxDato_1
        '
        Me.TxDato_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(51, 33)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(140, 22)
        Me.TxDato_1.TabIndex = 177
        Me.TxDato_1.TeclaRepetida = False
        '
        'Sumador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 244)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Sumador"
        Me.Text = "Sumador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ControlGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Public WithEvents ControlGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents Grid As DevExpress.XtraGrid.Views.Grid.GridView

End Class
