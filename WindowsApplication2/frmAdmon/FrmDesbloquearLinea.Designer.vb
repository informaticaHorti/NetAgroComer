<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesbloquearLinea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesbloquearLinea))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BGuardar = New NetAgro.ClButton()
        Me.Bsalir = New NetAgro.ClButton()
        Me.CbLineas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxUsuario = New NetAgro.TxDato(Me.components)
        Me.LbNomUsuario = New NetAgro.Lb(Me.components)
        Me.BtBuscaUsuario = New NetAgro.BtBusca(Me.components)
        Me.LbUsuario = New NetAgro.Lb(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Bsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 34)
        Me.Panel1.TabIndex = 3
        '
        'BGuardar
        '
        Me.BGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BGuardar.Location = New System.Drawing.Point(480, 0)
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
        Me.Bsalir.Location = New System.Drawing.Point(545, 0)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Orden = 0
        Me.Bsalir.PedirClave = True
        Me.Bsalir.Size = New System.Drawing.Size(65, 34)
        Me.Bsalir.TabIndex = 100
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'CbLineas
        '
        Me.CbLineas.EditValue = ""
        Me.CbLineas.Location = New System.Drawing.Point(91, 16)
        Me.CbLineas.Name = "CbLineas"
        Me.CbLineas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbLineas.Size = New System.Drawing.Size(273, 20)
        Me.CbLineas.TabIndex = 100278
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = True
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(16, 50)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 100281
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.BackColor = System.Drawing.Color.White
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(91, 47)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxFecha.TabIndex = 100280
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(16, 18)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(55, 16)
        Me.Lb6.TabIndex = 100279
        Me.Lb6.Text = "Lineas"
        '
        'TxUsuario
        '
        Me.TxUsuario.Autonumerico = False
        Me.TxUsuario.Buscando = False
        Me.TxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxUsuario.ClForm = Nothing
        Me.TxUsuario.ClParam = Nothing
        Me.TxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxUsuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxUsuario.GridLin = Nothing
        Me.TxUsuario.HaCambiado = False
        Me.TxUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxUsuario.lbbusca = Nothing
        Me.TxUsuario.Location = New System.Drawing.Point(91, 79)
        Me.TxUsuario.MiError = False
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Orden = 0
        Me.TxUsuario.SaltoAlfinal = False
        Me.TxUsuario.Siguiente = 0
        Me.TxUsuario.Size = New System.Drawing.Size(66, 22)
        Me.TxUsuario.TabIndex = 100285
        Me.TxUsuario.TeclaRepetida = False
        Me.TxUsuario.UltimoValorValidado = Nothing
        '
        'LbNomUsuario
        '
        Me.LbNomUsuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomUsuario.CL_ControlAsociado = Nothing
        Me.LbNomUsuario.CL_ValorFijo = False
        Me.LbNomUsuario.ClForm = Nothing
        Me.LbNomUsuario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomUsuario.Location = New System.Drawing.Point(202, 79)
        Me.LbNomUsuario.Name = "LbNomUsuario"
        Me.LbNomUsuario.Size = New System.Drawing.Size(381, 23)
        Me.LbNomUsuario.TabIndex = 100284
        Me.LbNomUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtBuscaUsuario
        '
        Me.BtBuscaUsuario.CL_Ancho = 0
        Me.BtBuscaUsuario.CL_BuscaAlb = False
        Me.BtBuscaUsuario.CL_campocodigo = Nothing
        Me.BtBuscaUsuario.CL_camponombre = Nothing
        Me.BtBuscaUsuario.CL_CampoOrden = "Nombre"
        Me.BtBuscaUsuario.CL_ch1000 = False
        Me.BtBuscaUsuario.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaUsuario.CL_ControlAsociado = Nothing
        Me.BtBuscaUsuario.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaUsuario.CL_dfecha = Nothing
        Me.BtBuscaUsuario.CL_Entidad = Nothing
        Me.BtBuscaUsuario.CL_EsId = True
        Me.BtBuscaUsuario.CL_Filtro = Nothing
        Me.BtBuscaUsuario.cl_formu = Nothing
        Me.BtBuscaUsuario.CL_hfecha = Nothing
        Me.BtBuscaUsuario.cl_ListaW = Nothing
        Me.BtBuscaUsuario.CL_xCentro = False
        Me.BtBuscaUsuario.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaUsuario.Location = New System.Drawing.Point(163, 79)
        Me.BtBuscaUsuario.Name = "BtBuscaUsuario"
        Me.BtBuscaUsuario.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaUsuario.TabIndex = 100283
        Me.BtBuscaUsuario.UseVisualStyleBackColor = True
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.CL_ControlAsociado = Nothing
        Me.LbUsuario.CL_ValorFijo = False
        Me.LbUsuario.ClForm = Nothing
        Me.LbUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.ForeColor = System.Drawing.Color.Teal
        Me.LbUsuario.Location = New System.Drawing.Point(16, 82)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(63, 16)
        Me.LbUsuario.TabIndex = 100282
        Me.LbUsuario.Text = "Usuario"
        '
        'FrmDesbloquearLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(610, 152)
        Me.Controls.Add(Me.TxUsuario)
        Me.Controls.Add(Me.LbNomUsuario)
        Me.Controls.Add(Me.BtBuscaUsuario)
        Me.Controls.Add(Me.LbUsuario)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TxFecha)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.CbLineas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDesbloquearLinea"
        Me.Text = "Desbloquear línea producción"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CbLineas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BGuardar As NetAgro.ClButton
    Friend WithEvents Bsalir As NetAgro.ClButton
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents CbLineas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents TxUsuario As NetAgro.TxDato
    Friend WithEvents LbNomUsuario As NetAgro.Lb
    Friend WithEvents BtBuscaUsuario As NetAgro.BtBusca
    Friend WithEvents LbUsuario As NetAgro.Lb
End Class
