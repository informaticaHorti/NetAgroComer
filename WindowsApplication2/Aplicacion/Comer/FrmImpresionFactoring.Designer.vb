<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpresionFactoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpresionFactoring))
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.BtBusca3 = New NetAgro.BtBusca(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.BtBusca4 = New NetAgro.BtBusca(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5_ = New NetAgro.Lb(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.BtBusca5 = New NetAgro.BtBusca(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.chkSoloPendientes = New NetAgro.Chk(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkSoloPendientes)
        Me.Panel2.Controls.Add(Me.Lb_5)
        Me.Panel2.Controls.Add(Me.Lb_4)
        Me.Panel2.Controls.Add(Me.BtBusca5)
        Me.Panel2.Controls.Add(Me.Lb5_)
        Me.Panel2.Controls.Add(Me.TxDato5)
        Me.Panel2.Controls.Add(Me.TxDato4)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.cbPuntoVenta)
        Me.Panel2.Controls.Add(Me.BtBusca4)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.Lb_3)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Controls.Add(Me.BtBusca3)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Size = New System.Drawing.Size(1234, 104)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 110)
        Me.Panel3.Size = New System.Drawing.Size(1234, 412)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(934, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1009, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1084, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1159, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(416, 16)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(63, 22)
        Me.TxDato3.TabIndex = 51
        Me.TxDato3.TeclaRepetida = False
        '
        'BtBusca3
        '
        Me.BtBusca3.CL_BuscaAlb = False
        Me.BtBusca3.CL_campocodigo = Nothing
        Me.BtBusca3.CL_camponombre = Nothing
        Me.BtBusca3.CL_CampoOrden = "Nombre"
        Me.BtBusca3.CL_ch1000 = False
        Me.BtBusca3.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca3.CL_ControlAsociado = Nothing
        Me.BtBusca3.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca3.CL_dfecha = Nothing
        Me.BtBusca3.CL_Entidad = Nothing
        Me.BtBusca3.CL_EsId = True
        Me.BtBusca3.CL_Filtro = Nothing
        Me.BtBusca3.cl_formu = Nothing
        Me.BtBusca3.CL_hfecha = Nothing
        Me.BtBusca3.cl_ListaW = Nothing
        Me.BtBusca3.CL_xCentro = False
        Me.BtBusca3.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca3.Location = New System.Drawing.Point(485, 16)
        Me.BtBusca3.Name = "BtBusca3"
        Me.BtBusca3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca3.TabIndex = 50
        Me.BtBusca3.UseVisualStyleBackColor = True
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(302, 19)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(108, 16)
        Me.Lb3.TabIndex = 49
        Me.Lb3.Text = "Desde Cliente"
        '
        'Lb_3
        '
        Me.Lb_3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_3.Location = New System.Drawing.Point(524, 16)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(420, 23)
        Me.Lb_3.TabIndex = 75
        '
        'Lb_4
        '
        Me.Lb_4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_4.Location = New System.Drawing.Point(524, 43)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(420, 23)
        Me.Lb_4.TabIndex = 79
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
        Me.TxDato4.Location = New System.Drawing.Point(416, 43)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(63, 22)
        Me.TxDato4.TabIndex = 78
        Me.TxDato4.TeclaRepetida = False
        '
        'BtBusca4
        '
        Me.BtBusca4.CL_BuscaAlb = False
        Me.BtBusca4.CL_campocodigo = Nothing
        Me.BtBusca4.CL_camponombre = Nothing
        Me.BtBusca4.CL_CampoOrden = "Nombre"
        Me.BtBusca4.CL_ch1000 = False
        Me.BtBusca4.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca4.CL_ControlAsociado = Nothing
        Me.BtBusca4.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca4.CL_dfecha = Nothing
        Me.BtBusca4.CL_Entidad = Nothing
        Me.BtBusca4.CL_EsId = True
        Me.BtBusca4.CL_Filtro = Nothing
        Me.BtBusca4.cl_formu = Nothing
        Me.BtBusca4.CL_hfecha = Nothing
        Me.BtBusca4.cl_ListaW = Nothing
        Me.BtBusca4.CL_xCentro = False
        Me.BtBusca4.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca4.Location = New System.Drawing.Point(485, 43)
        Me.BtBusca4.Name = "BtBusca4"
        Me.BtBusca4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca4.TabIndex = 77
        Me.BtBusca4.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(302, 46)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(106, 16)
        Me.Lb4.TabIndex = 76
        Me.Lb4.Text = "Hasta Cliente"
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(124, 43)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 83
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(21, 46)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 82
        Me.Lb2.Text = "Hasta fecha"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(124, 16)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 81
        Me.TxDato1.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 19)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Desde fecha"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(705, 71)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'Lb5_
        '
        Me.Lb5_.AutoSize = True
        Me.Lb5_.CL_ControlAsociado = Nothing
        Me.Lb5_.CL_ValorFijo = True
        Me.Lb5_.ClForm = Nothing
        Me.Lb5_.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5_.ForeColor = System.Drawing.Color.Teal
        Me.Lb5_.Location = New System.Drawing.Point(581, 73)
        Me.Lb5_.Name = "Lb5_"
        Me.Lb5_.Size = New System.Drawing.Size(118, 16)
        Me.Lb5_.TabIndex = 100272
        Me.Lb5_.Text = "Punto de venta"
        '
        'Lb_5
        '
        Me.Lb_5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lb_5.Location = New System.Drawing.Point(212, 70)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(306, 23)
        Me.Lb_5.TabIndex = 183
        Me.Lb_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtBusca5
        '
        Me.BtBusca5.CL_BuscaAlb = False
        Me.BtBusca5.CL_campocodigo = Nothing
        Me.BtBusca5.CL_camponombre = Nothing
        Me.BtBusca5.CL_CampoOrden = "Nombre"
        Me.BtBusca5.CL_ch1000 = False
        Me.BtBusca5.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca5.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca5.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca5.CL_dfecha = Nothing
        Me.BtBusca5.CL_Entidad = Nothing
        Me.BtBusca5.CL_EsId = True
        Me.BtBusca5.CL_Filtro = Nothing
        Me.BtBusca5.cl_formu = Nothing
        Me.BtBusca5.CL_hfecha = Nothing
        Me.BtBusca5.cl_ListaW = Nothing
        Me.BtBusca5.CL_xCentro = False
        Me.BtBusca5.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca5.Location = New System.Drawing.Point(173, 70)
        Me.BtBusca5.Name = "BtBusca5"
        Me.BtBusca5.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca5.TabIndex = 182
        Me.BtBusca5.UseVisualStyleBackColor = True
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(124, 70)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(43, 22)
        Me.TxDato5.TabIndex = 181
        Me.TxDato5.TeclaRepetida = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(21, 73)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(62, 16)
        Me.Lb5.TabIndex = 180
        Me.Lb5.Text = "F. Pago"
        '
        'chkSoloPendientes
        '
        Me.chkSoloPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSoloPendientes.AutoSize = True
        Me.chkSoloPendientes.Campobd = Nothing
        Me.chkSoloPendientes.Checked = True
        Me.chkSoloPendientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoloPendientes.ClForm = Nothing
        Me.chkSoloPendientes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloPendientes.ForeColor = System.Drawing.Color.Teal
        Me.chkSoloPendientes.GridLin = Nothing
        Me.chkSoloPendientes.HaCambiado = False
        Me.chkSoloPendientes.Location = New System.Drawing.Point(979, 71)
        Me.chkSoloPendientes.MiEntidad = Nothing
        Me.chkSoloPendientes.MiError = False
        Me.chkSoloPendientes.Name = "chkSoloPendientes"
        Me.chkSoloPendientes.Orden = 0
        Me.chkSoloPendientes.SaltoAlfinal = False
        Me.chkSoloPendientes.Size = New System.Drawing.Size(230, 20)
        Me.chkSoloPendientes.TabIndex = 100287
        Me.chkSoloPendientes.Text = "Sólo pendientes de remesar"
        Me.chkSoloPendientes.UseVisualStyleBackColor = True
        Me.chkSoloPendientes.ValorCampoFalse = Nothing
        Me.chkSoloPendientes.ValorCampoTrue = Nothing
        Me.chkSoloPendientes.ValorDefecto = False
        '
        'FrmImpresionFactoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmImpresionFactoring"
        Me.Text = "Albaranes factoring"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents BtBusca3 As NetAgro.BtBusca
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents BtBusca4 As NetAgro.BtBusca
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5_ As NetAgro.Lb
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents BtBusca5 As NetAgro.BtBusca
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents chkSoloPendientes As NetAgro.Chk
End Class
