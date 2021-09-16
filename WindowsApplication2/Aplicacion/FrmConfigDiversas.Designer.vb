<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigDiversas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigDiversas))
        Me.gBox1 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gBox2 = New DevExpress.XtraEditors.GroupControl()
        Me.BAnular = New NetAgro.ClButton()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        CType(Me.gBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBox1
        '
        Me.gBox1.Controls.Add(Me.Grid)
        Me.gBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gBox1.Location = New System.Drawing.Point(0, 0)
        Me.gBox1.Name = "gBox1"
        Me.gBox1.ShowCaption = False
        Me.gBox1.Size = New System.Drawing.Size(862, 360)
        Me.gBox1.TabIndex = 105
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeColumns = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clave, Me.valor, Me.IdCentro, Me.IdPuntoVenta, Me.Usuario})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(2, 2)
        Me.Grid.Name = "Grid"
        Me.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(858, 356)
        Me.Grid.TabIndex = 7
        '
        'clave
        '
        Me.clave.Frozen = True
        Me.clave.HeaderText = "Clave"
        Me.clave.MinimumWidth = 250
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clave.Width = 250
        '
        'valor
        '
        Me.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.valor.HeaderText = "Valor"
        Me.valor.MaxInputLength = 250
        Me.valor.Name = "valor"
        '
        'IdCentro
        '
        Me.IdCentro.HeaderText = "IdCentro"
        Me.IdCentro.Name = "IdCentro"
        '
        'IdPuntoVenta
        '
        Me.IdPuntoVenta.HeaderText = "IdPuntoVenta"
        Me.IdPuntoVenta.Name = "IdPuntoVenta"
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "IdUsuario"
        Me.Usuario.Name = "Usuario"
        '
        'gBox2
        '
        Me.gBox2.Controls.Add(Me.BAnular)
        Me.gBox2.Controls.Add(Me.BGuardar)
        Me.gBox2.Controls.Add(Me.Bsalir)
        Me.gBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gBox2.Location = New System.Drawing.Point(0, 360)
        Me.gBox2.Name = "gBox2"
        Me.gBox2.ShowCaption = False
        Me.gBox2.Size = New System.Drawing.Size(862, 60)
        Me.gBox2.TabIndex = 106
        '
        'BAnular
        '
        Me.BAnular.Image = CType(resources.GetObject("BAnular.Image"), System.Drawing.Image)
        Me.BAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BAnular.Location = New System.Drawing.Point(72, 12)
        Me.BAnular.Name = "BAnular"
        Me.BAnular.Orden = 0
        Me.BAnular.PedirClave = True
        Me.BAnular.Size = New System.Drawing.Size(65, 34)
        Me.BAnular.TabIndex = 107
        Me.BAnular.Text = "Anular"
        Me.BAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAnular.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(7, 12)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 105
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(791, 12)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 106
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'FrmConfigDiversas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 420)
        Me.Controls.Add(Me.gBox1)
        Me.Controls.Add(Me.gBox2)
        Me.MaximizeBox = False
        Me.Name = "FrmConfigDiversas"
        Me.Text = "Configuraciones Diversas "
        CType(Me.gBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBox1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gBox1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gBox2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BAnular As NetAgro.ClButton
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPuntoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
