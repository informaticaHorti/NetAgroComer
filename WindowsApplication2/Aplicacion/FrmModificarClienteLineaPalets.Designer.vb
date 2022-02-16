<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarClienteLineaPalets
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarClienteLineaPalets))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxCliente = New NetAgro.TxDato(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.LbNom_Cliente = New NetAgro.Lb(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 34)
        Me.Panel1.TabIndex = 3
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(409, 0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Orden = 0
        Me.BGuardar.PedirClave = True
        Me.BGuardar.Size = New System.Drawing.Size(65, 34)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), System.Drawing.Image)
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bsalir.Location = New System.Drawing.Point(474, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_Ancho = 0
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_BuscarEnTodosLosCampos = False
        Me.BtBuscaCliente.CL_campocodigo = Nothing
        Me.BtBuscaCliente.CL_camponombre = Nothing
        Me.BtBuscaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaCliente.CL_ch1000 = False
        Me.BtBuscaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCliente.CL_dfecha = Nothing
        Me.BtBuscaCliente.CL_Entidad = Nothing
        Me.BtBuscaCliente.CL_EsId = True
        Me.BtBuscaCliente.CL_Filtro = Nothing
        Me.BtBuscaCliente.cl_formu = Nothing
        Me.BtBuscaCliente.CL_hfecha = Nothing
        Me.BtBuscaCliente.cl_ListaW = Nothing
        Me.BtBuscaCliente.CL_xCentro = False
        Me.BtBuscaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCliente.Location = New System.Drawing.Point(131, 25)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 100402
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
        '
        'TxCliente
        '
        Me.TxCliente.Autonumerico = False
        Me.TxCliente.Bloqueado = False
        Me.TxCliente.Buscando = False
        Me.TxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCliente.ClForm = Nothing
        Me.TxCliente.ClParam = Nothing
        Me.TxCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCliente.GridLin = Nothing
        Me.TxCliente.HaCambiado = False
        Me.TxCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCliente.lbbusca = Nothing
        Me.TxCliente.Location = New System.Drawing.Point(77, 25)
        Me.TxCliente.MiError = False
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.Orden = 0
        Me.TxCliente.SaltoAlfinal = False
        Me.TxCliente.Siguiente = 0
        Me.TxCliente.Size = New System.Drawing.Size(53, 22)
        Me.TxCliente.TabIndex = 100401
        Me.TxCliente.TeclaRepetida = False
        Me.TxCliente.TxDatoFinalSemana = Nothing
        Me.TxCliente.TxDatoInicioSemana = Nothing
        Me.TxCliente.UltimoValorValidado = Nothing
        '
        'LbCliente
        '
        Me.LbCliente.AutoSize = True
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = False
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Teal
        Me.LbCliente.Location = New System.Drawing.Point(12, 28)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(59, 16)
        Me.LbCliente.TabIndex = 100400
        Me.LbCliente.Text = "Cliente"
        '
        'LbNom_Cliente
        '
        Me.LbNom_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNom_Cliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNom_Cliente.CL_ControlAsociado = Nothing
        Me.LbNom_Cliente.CL_ValorFijo = False
        Me.LbNom_Cliente.ClForm = Nothing
        Me.LbNom_Cliente.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Cliente.Location = New System.Drawing.Point(167, 25)
        Me.LbNom_Cliente.Name = "LbNom_Cliente"
        Me.LbNom_Cliente.Size = New System.Drawing.Size(346, 23)
        Me.LbNom_Cliente.TabIndex = 100399
        '
        'FrmModificarClienteLineaPalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(539, 111)
        Me.Controls.Add(Me.BtBuscaCliente)
        Me.Controls.Add(Me.TxCliente)
        Me.Controls.Add(Me.LbCliente)
        Me.Controls.Add(Me.LbNom_Cliente)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmModificarClienteLineaPalets"
        Me.Text = "Modificar cliente de la línea de palet"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents BtBuscaCliente As BtBusca
    Friend WithEvents TxCliente As TxDato
    Friend WithEvents LbCliente As Lb
    Friend WithEvents LbNom_Cliente As Lb
End Class
