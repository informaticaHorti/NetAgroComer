<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaldoEnvases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldoEnvases))
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.chkSoloRetornables = New NetAgro.Chk(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ChkDetallarMarcas = New NetAgro.Chk(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.cbAlmacenes = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.cbAlmacenes)
        Me.PanelCabecera.Controls.Add(Me.ChkDetallarMarcas)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.chkSoloRetornables)
        Me.PanelCabecera.Controls.Add(Me.LbCampa)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.LbTipo)
        Me.PanelCabecera.Controls.Add(Me.TxDato5)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Controls.Add(Me.Lb10)
        Me.PanelCabecera.Controls.Add(Me.TxDato8)
        Me.PanelCabecera.Controls.Add(Me.BtBusca2)
        Me.PanelCabecera.Controls.Add(Me.Lb11)
        Me.PanelCabecera.Size = New System.Drawing.Size(1084, 110)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 110)
        Me.PanelConsulta.Size = New System.Drawing.Size(1084, 378)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(784, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(859, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(934, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1009, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(709, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(960, 54)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(102, 22)
        Me.TxDato5.TabIndex = 95
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.TxDatoFinalSemana = Nothing
        Me.TxDato5.TxDatoInicioSemana = Nothing
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(859, 57)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(95, 16)
        Me.Lb6.TabIndex = 94
        Me.Lb6.Text = "Hasta fecha"
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.Color.Gainsboro
        Me.Lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb10.Location = New System.Drawing.Point(234, 54)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(362, 23)
        Me.Lb10.TabIndex = 87
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(126, 54)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(63, 22)
        Me.TxDato8.TabIndex = 86
        Me.TxDato8.TeclaRepetida = False
        Me.TxDato8.TxDatoFinalSemana = Nothing
        Me.TxDato8.TxDatoInicioSemana = Nothing
        Me.TxDato8.UltimoValorValidado = Nothing
        '
        'BtBusca2
        '
        Me.BtBusca2.CL_Ancho = 0
        Me.BtBusca2.CL_BuscaAlb = False
        Me.BtBusca2.CL_campocodigo = Nothing
        Me.BtBusca2.CL_camponombre = Nothing
        Me.BtBusca2.CL_CampoOrden = "Nombre"
        Me.BtBusca2.CL_ch1000 = False
        Me.BtBusca2.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca2.CL_ControlAsociado = Nothing
        Me.BtBusca2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca2.CL_dfecha = Nothing
        Me.BtBusca2.CL_Entidad = Nothing
        Me.BtBusca2.CL_EsId = True
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.CL_xCentro = False
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(195, 54)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 85
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(13, 57)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(58, 16)
        Me.Lb11.TabIndex = 84
        Me.Lb11.Text = "Código"
        '
        'LbTipo
        '
        Me.LbTipo.BackColor = System.Drawing.Color.Transparent
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = True
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipo.Location = New System.Drawing.Point(13, 9)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(346, 23)
        Me.LbTipo.TabIndex = 96
        '
        'Lb1
        '
        Me.Lb1.BackColor = System.Drawing.SystemColors.Control
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb1.Location = New System.Drawing.Point(873, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(114, 23)
        Me.Lb1.TabIndex = 97
        Me.Lb1.Text = "Ejercicio"
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.Transparent
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = True
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCampa.Location = New System.Drawing.Point(993, 9)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(84, 23)
        Me.LbCampa.TabIndex = 98
        '
        'chkSoloRetornables
        '
        Me.chkSoloRetornables.AutoSize = True
        Me.chkSoloRetornables.Campobd = Nothing
        Me.chkSoloRetornables.ClForm = Nothing
        Me.chkSoloRetornables.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloRetornables.ForeColor = System.Drawing.Color.Teal
        Me.chkSoloRetornables.GridLin = Nothing
        Me.chkSoloRetornables.HaCambiado = False
        Me.chkSoloRetornables.Location = New System.Drawing.Point(17, 83)
        Me.chkSoloRetornables.MiEntidad = Nothing
        Me.chkSoloRetornables.MiError = False
        Me.chkSoloRetornables.Name = "chkSoloRetornables"
        Me.chkSoloRetornables.Orden = 0
        Me.chkSoloRetornables.SaltoAlfinal = False
        Me.chkSoloRetornables.Size = New System.Drawing.Size(146, 20)
        Me.chkSoloRetornables.TabIndex = 100272
        Me.chkSoloRetornables.Text = "Sólo retornables"
        Me.chkSoloRetornables.UseVisualStyleBackColor = True
        Me.chkSoloRetornables.ValorCampoFalse = Nothing
        Me.chkSoloRetornables.ValorCampoTrue = Nothing
        Me.chkSoloRetornables.ValorDefecto = False
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(749, 54)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 100274
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.TxDatoFinalSemana = Nothing
        Me.TxDato4.TxDatoInicioSemana = Nothing
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(648, 57)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(97, 16)
        Me.Lb4.TabIndex = 100273
        Me.Lb4.Text = "Desde fecha"
        '
        'ChkDetallarMarcas
        '
        Me.ChkDetallarMarcas.AutoSize = True
        Me.ChkDetallarMarcas.Campobd = Nothing
        Me.ChkDetallarMarcas.ClForm = Nothing
        Me.ChkDetallarMarcas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDetallarMarcas.ForeColor = System.Drawing.Color.Teal
        Me.ChkDetallarMarcas.GridLin = Nothing
        Me.ChkDetallarMarcas.HaCambiado = False
        Me.ChkDetallarMarcas.Location = New System.Drawing.Point(195, 83)
        Me.ChkDetallarMarcas.MiEntidad = Nothing
        Me.ChkDetallarMarcas.MiError = False
        Me.ChkDetallarMarcas.Name = "ChkDetallarMarcas"
        Me.ChkDetallarMarcas.Orden = 0
        Me.ChkDetallarMarcas.SaltoAlfinal = False
        Me.ChkDetallarMarcas.Size = New System.Drawing.Size(142, 20)
        Me.ChkDetallarMarcas.TabIndex = 100275
        Me.ChkDetallarMarcas.Text = "Detallar marcas"
        Me.ChkDetallarMarcas.UseVisualStyleBackColor = True
        Me.ChkDetallarMarcas.ValorCampoFalse = Nothing
        Me.ChkDetallarMarcas.ValorCampoTrue = Nothing
        Me.ChkDetallarMarcas.ValorDefecto = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(648, 85)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(71, 16)
        Me.Lb5.TabIndex = 100294
        Me.Lb5.Text = "Almacén"
        '
        'cbAlmacenes
        '
        Me.cbAlmacenes.EditValue = ""
        Me.cbAlmacenes.Location = New System.Drawing.Point(749, 83)
        Me.cbAlmacenes.Name = "cbAlmacenes"
        Me.cbAlmacenes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlmacenes.Size = New System.Drawing.Size(315, 20)
        Me.cbAlmacenes.TabIndex = 100293
        '
        'FrmSaldoEnvases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 522)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmSaldoEnvases"
        Me.Text = "Consulta saldo de envases"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbAlmacenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents chkSoloRetornables As NetAgro.Chk
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents ChkDetallarMarcas As NetAgro.Chk
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents cbAlmacenes As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
