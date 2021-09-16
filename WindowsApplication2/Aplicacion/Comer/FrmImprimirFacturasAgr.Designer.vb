<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirFacturasAgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimirFacturasAgr))
        Me.LbDFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxaFecha = New NetAgro.TxDato(Me.components)
        Me.LbdAgricultor = New NetAgro.Lb(Me.components)
        Me.TxDAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaagr1 = New NetAgro.BtBusca(Me.components)
        Me.LbNomAgr2 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgr2 = New NetAgro.BtBusca(Me.components)
        Me.LbaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbOperacion = New NetAgro.Lb(Me.components)
        Me.BtSelTodos = New System.Windows.Forms.Button()
        Me.BtSelNinguno = New System.Windows.Forms.Button()
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.BtSelTodos)
        Me.PanelCabecera.Controls.Add(Me.BtSelNinguno)
        Me.PanelCabecera.Controls.Add(Me.LbOperacion)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgr2)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgr2)
        Me.PanelCabecera.Controls.Add(Me.LbaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbnomAgr1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaagr1)
        Me.PanelCabecera.Controls.Add(Me.LbdAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxDAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxaFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(1104, 114)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 114)
        Me.PanelConsulta.Size = New System.Drawing.Size(1104, 380)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(804, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(879, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(954, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1029, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(729, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbDFecha
        '
        Me.LbDFecha.AutoSize = True
        Me.LbDFecha.CL_ControlAsociado = Nothing
        Me.LbDFecha.CL_ValorFijo = False
        Me.LbDFecha.ClForm = Nothing
        Me.LbDFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDFecha.Location = New System.Drawing.Point(9, 18)
        Me.LbDFecha.Name = "LbDFecha"
        Me.LbDFecha.Size = New System.Drawing.Size(123, 16)
        Me.LbDFecha.TabIndex = 116
        Me.LbDFecha.Text = "Desde fecha fac"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(139, 15)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxDeFecha.TabIndex = 115
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(263, 18)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(121, 16)
        Me.LbAFecha.TabIndex = 100273
        Me.LbAFecha.Text = "Hasta fecha fac"
        '
        'TxaFecha
        '
        Me.TxaFecha.Autonumerico = False
        Me.TxaFecha.Buscando = False
        Me.TxaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxaFecha.ClForm = Nothing
        Me.TxaFecha.ClParam = Nothing
        Me.TxaFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxaFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxaFecha.GridLin = Nothing
        Me.TxaFecha.HaCambiado = False
        Me.TxaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxaFecha.lbbusca = Nothing
        Me.TxaFecha.Location = New System.Drawing.Point(409, 15)
        Me.TxaFecha.MiError = False
        Me.TxaFecha.Name = "TxaFecha"
        Me.TxaFecha.Orden = 0
        Me.TxaFecha.SaltoAlfinal = False
        Me.TxaFecha.Siguiente = 0
        Me.TxaFecha.Size = New System.Drawing.Size(105, 22)
        Me.TxaFecha.TabIndex = 100272
        Me.TxaFecha.TeclaRepetida = False
        Me.TxaFecha.TxDatoFinalSemana = Nothing
        Me.TxaFecha.TxDatoInicioSemana = Nothing
        Me.TxaFecha.UltimoValorValidado = Nothing
        '
        'LbdAgricultor
        '
        Me.LbdAgricultor.AutoSize = True
        Me.LbdAgricultor.CL_ControlAsociado = Nothing
        Me.LbdAgricultor.CL_ValorFijo = False
        Me.LbdAgricultor.ClForm = Nothing
        Me.LbdAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbdAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbdAgricultor.Location = New System.Drawing.Point(12, 45)
        Me.LbdAgricultor.Name = "LbdAgricultor"
        Me.LbdAgricultor.Size = New System.Drawing.Size(101, 16)
        Me.LbdAgricultor.TabIndex = 100277
        Me.LbdAgricultor.Text = "De agricultor"
        '
        'TxDAgricultor
        '
        Me.TxDAgricultor.Autonumerico = False
        Me.TxDAgricultor.Buscando = False
        Me.TxDAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDAgricultor.ClForm = Nothing
        Me.TxDAgricultor.ClParam = Nothing
        Me.TxDAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDAgricultor.GridLin = Nothing
        Me.TxDAgricultor.HaCambiado = False
        Me.TxDAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDAgricultor.lbbusca = Nothing
        Me.TxDAgricultor.Location = New System.Drawing.Point(138, 43)
        Me.TxDAgricultor.MiError = False
        Me.TxDAgricultor.Name = "TxDAgricultor"
        Me.TxDAgricultor.Orden = 0
        Me.TxDAgricultor.SaltoAlfinal = False
        Me.TxDAgricultor.Siguiente = 0
        Me.TxDAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxDAgricultor.TabIndex = 100276
        Me.TxDAgricultor.TeclaRepetida = False
        Me.TxDAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDAgricultor.UltimoValorValidado = Nothing
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.Color.LightGray
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(242, 45)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(401, 18)
        Me.LbnomAgr1.TabIndex = 100279
        '
        'BtBuscaagr1
        '
        Me.BtBuscaagr1.CL_Ancho = 0
        Me.BtBuscaagr1.CL_BuscaAlb = False
        Me.BtBuscaagr1.CL_campocodigo = Nothing
        Me.BtBuscaagr1.CL_camponombre = Nothing
        Me.BtBuscaagr1.CL_CampoOrden = "Nombre"
        Me.BtBuscaagr1.CL_ch1000 = False
        Me.BtBuscaagr1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaagr1.CL_ControlAsociado = Nothing
        Me.BtBuscaagr1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaagr1.CL_dfecha = Nothing
        Me.BtBuscaagr1.CL_Entidad = Nothing
        Me.BtBuscaagr1.CL_EsId = True
        Me.BtBuscaagr1.CL_Filtro = Nothing
        Me.BtBuscaagr1.cl_formu = Nothing
        Me.BtBuscaagr1.CL_hfecha = Nothing
        Me.BtBuscaagr1.cl_ListaW = Nothing
        Me.BtBuscaagr1.CL_xCentro = False
        Me.BtBuscaagr1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaagr1.Location = New System.Drawing.Point(201, 43)
        Me.BtBuscaagr1.Name = "BtBuscaagr1"
        Me.BtBuscaagr1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaagr1.TabIndex = 100278
        Me.BtBuscaagr1.UseVisualStyleBackColor = True
        '
        'LbNomAgr2
        '
        Me.LbNomAgr2.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgr2.CL_ControlAsociado = Nothing
        Me.LbNomAgr2.CL_ValorFijo = False
        Me.LbNomAgr2.ClForm = Nothing
        Me.LbNomAgr2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgr2.Location = New System.Drawing.Point(242, 74)
        Me.LbNomAgr2.Name = "LbNomAgr2"
        Me.LbNomAgr2.Size = New System.Drawing.Size(401, 18)
        Me.LbNomAgr2.TabIndex = 100283
        '
        'BtBuscaAgr2
        '
        Me.BtBuscaAgr2.CL_Ancho = 0
        Me.BtBuscaAgr2.CL_BuscaAlb = False
        Me.BtBuscaAgr2.CL_campocodigo = Nothing
        Me.BtBuscaAgr2.CL_camponombre = Nothing
        Me.BtBuscaAgr2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgr2.CL_ch1000 = False
        Me.BtBuscaAgr2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgr2.CL_ControlAsociado = Nothing
        Me.BtBuscaAgr2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgr2.CL_dfecha = Nothing
        Me.BtBuscaAgr2.CL_Entidad = Nothing
        Me.BtBuscaAgr2.CL_EsId = True
        Me.BtBuscaAgr2.CL_Filtro = Nothing
        Me.BtBuscaAgr2.cl_formu = Nothing
        Me.BtBuscaAgr2.CL_hfecha = Nothing
        Me.BtBuscaAgr2.cl_ListaW = Nothing
        Me.BtBuscaAgr2.CL_xCentro = False
        Me.BtBuscaAgr2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgr2.Location = New System.Drawing.Point(201, 72)
        Me.BtBuscaAgr2.Name = "BtBuscaAgr2"
        Me.BtBuscaAgr2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgr2.TabIndex = 100282
        Me.BtBuscaAgr2.UseVisualStyleBackColor = True
        '
        'LbaAgricultor
        '
        Me.LbaAgricultor.AutoSize = True
        Me.LbaAgricultor.CL_ControlAsociado = Nothing
        Me.LbaAgricultor.CL_ValorFijo = False
        Me.LbaAgricultor.ClForm = Nothing
        Me.LbaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbaAgricultor.Location = New System.Drawing.Point(12, 74)
        Me.LbaAgricultor.Name = "LbaAgricultor"
        Me.LbaAgricultor.Size = New System.Drawing.Size(92, 16)
        Me.LbaAgricultor.TabIndex = 100281
        Me.LbaAgricultor.Text = "A agricultor"
        '
        'TxAAgricultor
        '
        Me.TxAAgricultor.Autonumerico = False
        Me.TxAAgricultor.Buscando = False
        Me.TxAAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAAgricultor.ClForm = Nothing
        Me.TxAAgricultor.ClParam = Nothing
        Me.TxAAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAAgricultor.GridLin = Nothing
        Me.TxAAgricultor.HaCambiado = False
        Me.TxAAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAAgricultor.lbbusca = Nothing
        Me.TxAAgricultor.Location = New System.Drawing.Point(138, 72)
        Me.TxAAgricultor.MiError = False
        Me.TxAAgricultor.Name = "TxAAgricultor"
        Me.TxAAgricultor.Orden = 0
        Me.TxAAgricultor.SaltoAlfinal = False
        Me.TxAAgricultor.Siguiente = 0
        Me.TxAAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxAAgricultor.TabIndex = 100280
        Me.TxAAgricultor.TeclaRepetida = False
        Me.TxAAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAAgricultor.UltimoValorValidado = Nothing
        '
        'LbOperacion
        '
        Me.LbOperacion.AutoSize = True
        Me.LbOperacion.CL_ControlAsociado = Nothing
        Me.LbOperacion.CL_ValorFijo = True
        Me.LbOperacion.ClForm = Nothing
        Me.LbOperacion.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOperacion.ForeColor = System.Drawing.Color.Teal
        Me.LbOperacion.Location = New System.Drawing.Point(724, 64)
        Me.LbOperacion.Name = "LbOperacion"
        Me.LbOperacion.Size = New System.Drawing.Size(251, 29)
        Me.LbOperacion.TabIndex = 100284
        Me.LbOperacion.Text = "Imprimir facturas"
        '
        'BtSelTodos
        '
        Me.BtSelTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelTodos.Image = CType(resources.GetObject("BtSelTodos.Image"), System.Drawing.Image)
        Me.BtSelTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelTodos.Location = New System.Drawing.Point(1073, 89)
        Me.BtSelTodos.Name = "BtSelTodos"
        Me.BtSelTodos.Size = New System.Drawing.Size(28, 25)
        Me.BtSelTodos.TabIndex = 100298
        Me.BtSelTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelTodos.UseVisualStyleBackColor = True
        '
        'BtSelNinguno
        '
        Me.BtSelNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSelNinguno.Image = CType(resources.GetObject("BtSelNinguno.Image"), System.Drawing.Image)
        Me.BtSelNinguno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtSelNinguno.Location = New System.Drawing.Point(1046, 89)
        Me.BtSelNinguno.Name = "BtSelNinguno"
        Me.BtSelNinguno.Size = New System.Drawing.Size(28, 25)
        Me.BtSelNinguno.TabIndex = 100299
        Me.BtSelNinguno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSelNinguno.UseVisualStyleBackColor = True
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(649, 20)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(240, 20)
        Me.cbCentro.TabIndex = 100318
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(586, 22)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100317
        Me.Lb5.Text = "Centro"
        '
        'FrmImprimirFacturasAgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmImprimirFacturasAgr"
        Me.Text = "Facturas agricultores"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbDFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxaFecha As NetAgro.TxDato
    Friend WithEvents LbdAgricultor As NetAgro.Lb
    Friend WithEvents TxDAgricultor As NetAgro.TxDato
    Friend WithEvents LbNomAgr2 As NetAgro.Lb
    Friend WithEvents BtBuscaAgr2 As NetAgro.BtBusca
    Friend WithEvents LbaAgricultor As NetAgro.Lb
    Friend WithEvents TxAAgricultor As NetAgro.TxDato
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents BtBuscaagr1 As NetAgro.BtBusca
    Friend WithEvents LbOperacion As NetAgro.Lb
    Friend WithEvents BtSelTodos As System.Windows.Forms.Button
    Friend WithEvents BtSelNinguno As System.Windows.Forms.Button
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
