<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gDocumental
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gDocumental))
        Me.grupoGrid = New System.Windows.Forms.GroupBox()
        Me.GridDoc = New System.Windows.Forms.DataGridView()
        Me.grupoBotones = New System.Windows.Forms.GroupBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.GrupoVisor = New System.Windows.Forms.GroupBox()
        Me.viewUid = New System.Windows.Forms.WebBrowser()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.grupoGrid.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoBotones.SuspendLayout()
        Me.GrupoVisor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoGrid
        '
        Me.grupoGrid.Controls.Add(Me.GridDoc)
        Me.grupoGrid.Controls.Add(Me.grupoBotones)
        Me.grupoGrid.Dock = System.Windows.Forms.DockStyle.Left
        Me.grupoGrid.Location = New System.Drawing.Point(0, 0)
        Me.grupoGrid.Name = "grupoGrid"
        Me.grupoGrid.Size = New System.Drawing.Size(217, 324)
        Me.grupoGrid.TabIndex = 0
        Me.grupoGrid.TabStop = False
        '
        'GridDoc
        '
        Me.GridDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDoc.Location = New System.Drawing.Point(3, 16)
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.Size = New System.Drawing.Size(211, 189)
        Me.GridDoc.TabIndex = 1
        '
        'grupoBotones
        '
        Me.grupoBotones.Controls.Add(Me.btnExaminar)
        Me.grupoBotones.Controls.Add(Me.btnAsignar)
        Me.grupoBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupoBotones.Location = New System.Drawing.Point(3, 205)
        Me.grupoBotones.Name = "grupoBotones"
        Me.grupoBotones.Size = New System.Drawing.Size(211, 116)
        Me.grupoBotones.TabIndex = 0
        Me.grupoBotones.TabStop = False
        '
        'btnExaminar
        '
        Me.btnExaminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar.Image = CType(resources.GetObject("btnExaminar.Image"), System.Drawing.Image)
        Me.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExaminar.Location = New System.Drawing.Point(133, 34)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(72, 54)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Enabled = False
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAsignar.Location = New System.Drawing.Point(6, 34)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 54)
        Me.btnAsignar.TabIndex = 0
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'GrupoVisor
        '
        Me.GrupoVisor.Controls.Add(Me.viewUid)
        Me.GrupoVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrupoVisor.Location = New System.Drawing.Point(217, 0)
        Me.GrupoVisor.Name = "GrupoVisor"
        Me.GrupoVisor.Size = New System.Drawing.Size(335, 324)
        Me.GrupoVisor.TabIndex = 1
        Me.GrupoVisor.TabStop = False
        '
        'viewUid
        '
        Me.viewUid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewUid.Location = New System.Drawing.Point(3, 16)
        Me.viewUid.MinimumSize = New System.Drawing.Size(20, 20)
        Me.viewUid.Name = "viewUid"
        Me.viewUid.Size = New System.Drawing.Size(329, 305)
        Me.viewUid.TabIndex = 0
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'gDocumental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrupoVisor)
        Me.Controls.Add(Me.grupoGrid)
        Me.Name = "gDocumental"
        Me.Size = New System.Drawing.Size(552, 324)
        Me.grupoGrid.ResumeLayout(False)
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoBotones.ResumeLayout(False)
        Me.GrupoVisor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoGrid As System.Windows.Forms.GroupBox
    Friend WithEvents grupoBotones As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoVisor As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents viewUid As System.Windows.Forms.WebBrowser
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridDoc As System.Windows.Forms.DataGridView

End Class
