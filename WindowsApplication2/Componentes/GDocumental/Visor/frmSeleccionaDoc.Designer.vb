<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionaDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionaDoc))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxDato_2 = New System.Windows.Forms.TextBox()
        Me.BPrevisualizar = New System.Windows.Forms.Button()
        Me.BAñadir = New System.Windows.Forms.Button()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.BAnular = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNIF = New NetAgro.Lb(Me.components)
        Me.GridDoc = New System.Windows.Forms.DataGridView()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxDato_1 = New System.Windows.Forms.TextBox()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxDato_2)
        Me.Panel1.Controls.Add(Me.BPrevisualizar)
        Me.Panel1.Controls.Add(Me.BAñadir)
        Me.Panel1.Controls.Add(Me.Lb4)
        Me.Panel1.Controls.Add(Me.BAnular)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 572)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 34)
        Me.Panel1.TabIndex = 3
        '
        'TxDato_2
        '
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato_2.Location = New System.Drawing.Point(112, 7)
        Me.TxDato_2.MaxLength = 200
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Size = New System.Drawing.Size(457, 22)
        Me.TxDato_2.TabIndex = 100311
        '
        'BPrevisualizar
        '
        Me.BPrevisualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPrevisualizar.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.BPrevisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BPrevisualizar.Location = New System.Drawing.Point(675, 0)
        Me.BPrevisualizar.Name = "BPrevisualizar"
        Me.BPrevisualizar.Size = New System.Drawing.Size(109, 34)
        Me.BPrevisualizar.TabIndex = 100310
        Me.BPrevisualizar.Text = "Previsualizar"
        Me.BPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BPrevisualizar.UseVisualStyleBackColor = True
        '
        'BAñadir
        '
        Me.BAñadir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAñadir.Image = Global.NetAgro.My.Resources.Resources.Action_db_add_16x16_32
        Me.BAñadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAñadir.Location = New System.Drawing.Point(784, 0)
        Me.BAñadir.Name = "BAñadir"
        Me.BAñadir.Size = New System.Drawing.Size(109, 34)
        Me.BAñadir.TabIndex = 100309
        Me.BAñadir.Text = "Asociar documento"
        Me.BAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAñadir.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(19, 9)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(92, 16)
        Me.Lb4.TabIndex = 100307
        Me.Lb4.Text = "Descripción"
        '
        'BAnular
        '
        Me.BAnular.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAnular.Image = Global.NetAgro.My.Resources.Resources.Action_db_remove_16x16_32
        Me.BAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAnular.Location = New System.Drawing.Point(893, 0)
        Me.BAnular.Name = "BAnular"
        Me.BAnular.Size = New System.Drawing.Size(109, 34)
        Me.BAnular.TabIndex = 99
        Me.BAnular.Text = "Eliminar documento"
        Me.BAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnular.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(1002, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(82, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Location = New System.Drawing.Point(216, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 481)
        Me.Panel2.TabIndex = 4
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(859, 477)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNIF)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 38)
        Me.Panel3.TabIndex = 10
        '
        'LbNIF
        '
        Me.LbNIF.AutoSize = True
        Me.LbNIF.CL_ControlAsociado = Nothing
        Me.LbNIF.CL_ValorFijo = True
        Me.LbNIF.ClForm = Nothing
        Me.LbNIF.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNIF.ForeColor = System.Drawing.Color.Blue
        Me.LbNIF.Location = New System.Drawing.Point(12, 8)
        Me.LbNIF.Name = "LbNIF"
        Me.LbNIF.Size = New System.Drawing.Size(33, 18)
        Me.LbNIF.TabIndex = 123
        Me.LbNIF.Text = "     "
        '
        'GridDoc
        '
        Me.GridDoc.AllowUserToAddRows = False
        Me.GridDoc.AllowUserToDeleteRows = False
        Me.GridDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GridDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDoc.Location = New System.Drawing.Point(6, 75)
        Me.GridDoc.MultiSelect = False
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.ReadOnly = True
        Me.GridDoc.Size = New System.Drawing.Size(204, 450)
        Me.GridDoc.TabIndex = 900001
        Me.GridDoc.TabStop = False
        '
        'dOpenFile
        '
        Me.dOpenFile.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TxDato_1)
        Me.Panel4.Controls.Add(Me.Lb2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 534)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1084, 38)
        Me.Panel4.TabIndex = 900003
        '
        'TxDato_1
        '
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato_1.Location = New System.Drawing.Point(112, 10)
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.ReadOnly = True
        Me.TxDato_1.Size = New System.Drawing.Size(860, 22)
        Me.TxDato_1.TabIndex = 100312
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(19, 13)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(62, 16)
        Me.Lb2.TabIndex = 100308
        Me.Lb2.Text = "Fichero"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 54)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(99, 16)
        Me.Lb1.TabIndex = 900002
        Me.Lb1.Text = "Documentos"
        '
        'frmSeleccionaDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 606)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.GridDoc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSeleccionaDoc"
        Me.Text = "Visualizador documentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BAnular As System.Windows.Forms.Button
    Friend WithEvents Bsalir As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Protected WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNIF As NetAgro.Lb
    Public WithEvents GridDoc As System.Windows.Forms.DataGridView
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BAñadir As System.Windows.Forms.Button
    Friend WithEvents BPrevisualizar As System.Windows.Forms.Button
    Friend WithEvents TxDato_2 As System.Windows.Forms.TextBox
    Friend WithEvents Lb4 As NetAgro.Lb
    Protected WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxDato_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lb2 As NetAgro.Lb
End Class
