<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoraRef
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoraRef))
        Me.BtBuscaCli1 = New NetAgro.BtBusca(Me.components)
        Me.TxCliente = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbNomCli1 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDFecha = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.TxAfecha = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxCambio = New NetAgro.TxDato(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.PanelGreditable = New System.Windows.Forms.Panel()
        Me.GridEditable = New NetAgro.GridEditable()
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.PanelGreditable.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxCambio)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.TxAfecha)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDFecha)
        Me.PanelCabecera.Controls.Add(Me.LbNomCli1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCli1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxCliente)
        Me.PanelCabecera.Size = New System.Drawing.Size(1092, 92)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(2, 92)
        Me.PanelConsulta.Size = New System.Drawing.Size(1092, 0)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(792, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(867, 0)
        '
        'BInforme
        '
        Me.BInforme.Image = CType(resources.GetObject("BInforme.Image"), System.Drawing.Image)
        Me.BInforme.Location = New System.Drawing.Point(942, 0)
        Me.BInforme.Text = "Actualizar"
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1017, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(717, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(415, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'BtBuscaCli1
        '
        Me.BtBuscaCli1.CL_Ancho = 0
        Me.BtBuscaCli1.CL_BuscaAlb = False
        Me.BtBuscaCli1.CL_campocodigo = Nothing
        Me.BtBuscaCli1.CL_camponombre = Nothing
        Me.BtBuscaCli1.CL_CampoOrden = "Nombre"
        Me.BtBuscaCli1.CL_ch1000 = False
        Me.BtBuscaCli1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCli1.CL_ControlAsociado = Me.TxCliente
        Me.BtBuscaCli1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCli1.CL_dfecha = Nothing
        Me.BtBuscaCli1.CL_Entidad = Nothing
        Me.BtBuscaCli1.CL_EsId = True
        Me.BtBuscaCli1.CL_Filtro = Nothing
        Me.BtBuscaCli1.cl_formu = Nothing
        Me.BtBuscaCli1.CL_hfecha = Nothing
        Me.BtBuscaCli1.cl_ListaW = Nothing
        Me.BtBuscaCli1.CL_xCentro = False
        Me.BtBuscaCli1.Image = CType(resources.GetObject("BtBuscaCli1.Image"), System.Drawing.Image)
        Me.BtBuscaCli1.Location = New System.Drawing.Point(205, 17)
        Me.BtBuscaCli1.Name = "BtBuscaCli1"
        Me.BtBuscaCli1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCli1.TabIndex = 81
        Me.BtBuscaCli1.UseVisualStyleBackColor = True
        '
        'TxCliente
        '
        Me.TxCliente.Autonumerico = False
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
        Me.TxCliente.Location = New System.Drawing.Point(124, 17)
        Me.TxCliente.MiError = False
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.Orden = 0
        Me.TxCliente.SaltoAlfinal = False
        Me.TxCliente.Siguiente = 0
        Me.TxCliente.Size = New System.Drawing.Size(75, 22)
        Me.TxCliente.TabIndex = 79
        Me.TxCliente.TeclaRepetida = False
        Me.TxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxCliente.TxDatoFinalSemana = Nothing
        Me.TxCliente.TxDatoInicioSemana = Nothing
        Me.TxCliente.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(59, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Cliente"
        '
        'LbNomCli1
        '
        Me.LbNomCli1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCli1.CL_ControlAsociado = Nothing
        Me.LbNomCli1.CL_ValorFijo = False
        Me.LbNomCli1.ClForm = Nothing
        Me.LbNomCli1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCli1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCli1.Location = New System.Drawing.Point(244, 16)
        Me.LbNomCli1.Name = "LbNomCli1"
        Me.LbNomCli1.Size = New System.Drawing.Size(362, 23)
        Me.LbNomCli1.TabIndex = 136
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(12, 49)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(101, 16)
        Me.Lb4.TabIndex = 142
        Me.Lb4.Text = "Desde Fecha"
        '
        'TxDFecha
        '
        Me.TxDFecha.Autonumerico = False
        Me.TxDFecha.Buscando = False
        Me.TxDFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDFecha.ClForm = Nothing
        Me.TxDFecha.ClParam = Nothing
        Me.TxDFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDFecha.GridLin = Nothing
        Me.TxDFecha.HaCambiado = False
        Me.TxDFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDFecha.lbbusca = Nothing
        Me.TxDFecha.Location = New System.Drawing.Point(124, 46)
        Me.TxDFecha.MiError = False
        Me.TxDFecha.Name = "TxDFecha"
        Me.TxDFecha.Orden = 0
        Me.TxDFecha.SaltoAlfinal = False
        Me.TxDFecha.Siguiente = 0
        Me.TxDFecha.Size = New System.Drawing.Size(98, 22)
        Me.TxDFecha.TabIndex = 141
        Me.TxDFecha.TeclaRepetida = False
        Me.TxDFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDFecha.TxDatoFinalSemana = Nothing
        Me.TxDFecha.TxDatoInicioSemana = Nothing
        Me.TxDFecha.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(252, 50)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(99, 16)
        Me.Lb5.TabIndex = 144
        Me.Lb5.Text = "Hasta Fecha"
        '
        'TxAfecha
        '
        Me.TxAfecha.Autonumerico = False
        Me.TxAfecha.Buscando = False
        Me.TxAfecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAfecha.ClForm = Nothing
        Me.TxAfecha.ClParam = Nothing
        Me.TxAfecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAfecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAfecha.GridLin = Nothing
        Me.TxAfecha.HaCambiado = False
        Me.TxAfecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAfecha.lbbusca = Nothing
        Me.TxAfecha.Location = New System.Drawing.Point(364, 47)
        Me.TxAfecha.MiError = False
        Me.TxAfecha.Name = "TxAfecha"
        Me.TxAfecha.Orden = 0
        Me.TxAfecha.SaltoAlfinal = False
        Me.TxAfecha.Siguiente = 0
        Me.TxAfecha.Size = New System.Drawing.Size(98, 22)
        Me.TxAfecha.TabIndex = 143
        Me.TxAfecha.TeclaRepetida = False
        Me.TxAfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxAfecha.TxDatoFinalSemana = Nothing
        Me.TxAfecha.TxDatoInicioSemana = Nothing
        Me.TxAfecha.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(537, 52)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(110, 16)
        Me.Lb2.TabIndex = 146
        Me.Lb2.Text = "Cambio divisa"
        '
        'TxCambio
        '
        Me.TxCambio.Autonumerico = False
        Me.TxCambio.Buscando = False
        Me.TxCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCambio.ClForm = Nothing
        Me.TxCambio.ClParam = Nothing
        Me.TxCambio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCambio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCambio.GridLin = Nothing
        Me.TxCambio.HaCambiado = False
        Me.TxCambio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCambio.lbbusca = Nothing
        Me.TxCambio.Location = New System.Drawing.Point(649, 49)
        Me.TxCambio.MiError = False
        Me.TxCambio.Name = "TxCambio"
        Me.TxCambio.Orden = 0
        Me.TxCambio.SaltoAlfinal = False
        Me.TxCambio.Siguiente = 0
        Me.TxCambio.Size = New System.Drawing.Size(75, 22)
        Me.TxCambio.TabIndex = 145
        Me.TxCambio.TeclaRepetida = False
        Me.TxCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxCambio.TxDatoFinalSemana = Nothing
        Me.TxCambio.TxDatoInicioSemana = Nothing
        Me.TxCambio.UltimoValorValidado = Nothing
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(624, 16)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(248, 23)
        Me.Barra.TabIndex = 147
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelEditable.Controls.Add(Me.PanelGreditable)
        Me.PanelEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditable.Location = New System.Drawing.Point(0, 92)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(1092, 403)
        Me.PanelEditable.TabIndex = 15
        '
        'PanelGreditable
        '
        Me.PanelGreditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGreditable.Controls.Add(Me.GridEditable)
        Me.PanelGreditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGreditable.Location = New System.Drawing.Point(0, 0)
        Me.PanelGreditable.Name = "PanelGreditable"
        Me.PanelGreditable.Size = New System.Drawing.Size(1092, 403)
        Me.PanelGreditable.TabIndex = 141
        '
        'GridEditable
        '
        Me.GridEditable.DataSource = Nothing
        Me.GridEditable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEditable.Location = New System.Drawing.Point(0, 0)
        Me.GridEditable.Name = "GridEditable"
        Me.GridEditable.NavegarSoloEditables = False
        Me.GridEditable.Orden = -1
        Me.GridEditable.Size = New System.Drawing.Size(1092, 403)
        Me.GridEditable.TabIndex = 142
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(820, 50)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(237, 20)
        Me.cbCentro.TabIndex = 100326
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(757, 52)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(57, 16)
        Me.Lb3.TabIndex = 100325
        Me.Lb3.Text = "Centro"
        '
        'FrmValoraRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 529)
        Me.Controls.Add(Me.PanelEditable)
        Me.Controls.Add(Me._PanelCargando)
        Me.Name = "FrmValoraRef"
        Me.Text = "Valoracion a precio de referencia"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.PanelEditable, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelGreditable.ResumeLayout(False)
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtBuscaCli1 As NetAgro.BtBusca
    Friend WithEvents TxCliente As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDFecha As NetAgro.TxDato
    Friend WithEvents LbNomCli1 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxCambio As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents TxAfecha As NetAgro.TxDato
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents PanelEditable As System.Windows.Forms.Panel
    Friend WithEvents PanelGreditable As System.Windows.Forms.Panel
    Friend WithEvents GridEditable As NetAgro.GridEditable
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
End Class
