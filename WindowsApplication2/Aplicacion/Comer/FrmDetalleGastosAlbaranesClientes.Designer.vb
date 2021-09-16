<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleGastosAlbaranesClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleGastosAlbaranesClientes))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTotalizadoCliente = New System.Windows.Forms.RadioButton()
        Me.RbDetalladoAlbaran = New System.Windows.Forms.RadioButton()
        Me.BtBusca4 = New NetAgro.BtBusca(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.BtBusca3 = New NetAgro.BtBusca(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.cbPuntoVenta)
        Me.Panel2.Controls.Add(Me.BtBusca4)
        Me.Panel2.Controls.Add(Me.Lb_4)
        Me.Panel2.Controls.Add(Me.TxDato4)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.Lb_3)
        Me.Panel2.Controls.Add(Me.Lb3)
        Me.Panel2.Controls.Add(Me.TxDato3)
        Me.Panel2.Controls.Add(Me.BtBusca3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Size = New System.Drawing.Size(1184, 102)
        '
        'Panel3
        '
        Me.Panel3.Size = New System.Drawing.Size(1184, 427)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(884, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(959, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1034, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1109, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(809, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(14, 45)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(99, 16)
        Me.Lb2.TabIndex = 100300
        Me.Lb2.Text = "Hasta Fecha"
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
        Me.TxDato2.Location = New System.Drawing.Point(138, 42)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 100301
        Me.TxDato2.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(101, 16)
        Me.Lb1.TabIndex = 100298
        Me.Lb1.Text = "Desde Fecha"
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
        Me.TxDato1.Location = New System.Drawing.Point(138, 10)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 100299
        Me.TxDato1.TeclaRepetida = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTotalizadoCliente)
        Me.GroupBox1.Controls.Add(Me.RbDetalladoAlbaran)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(958, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 75)
        Me.GroupBox1.TabIndex = 100302
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo listado"
        '
        'RbTotalizadoCliente
        '
        Me.RbTotalizadoCliente.AutoSize = True
        Me.RbTotalizadoCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTotalizadoCliente.ForeColor = System.Drawing.Color.Teal
        Me.RbTotalizadoCliente.Location = New System.Drawing.Point(15, 46)
        Me.RbTotalizadoCliente.Name = "RbTotalizadoCliente"
        Me.RbTotalizadoCliente.Size = New System.Drawing.Size(184, 20)
        Me.RbTotalizadoCliente.TabIndex = 2
        Me.RbTotalizadoCliente.Text = "Totalizado por Cliente"
        Me.RbTotalizadoCliente.UseVisualStyleBackColor = True
        '
        'RbDetalladoAlbaran
        '
        Me.RbDetalladoAlbaran.AutoSize = True
        Me.RbDetalladoAlbaran.Checked = True
        Me.RbDetalladoAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetalladoAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.RbDetalladoAlbaran.Location = New System.Drawing.Point(16, 18)
        Me.RbDetalladoAlbaran.Name = "RbDetalladoAlbaran"
        Me.RbDetalladoAlbaran.Size = New System.Drawing.Size(165, 20)
        Me.RbDetalladoAlbaran.TabIndex = 0
        Me.RbDetalladoAlbaran.TabStop = True
        Me.RbDetalladoAlbaran.Text = "Detalle por Albaran"
        Me.RbDetalladoAlbaran.UseVisualStyleBackColor = True
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
        Me.BtBusca4.Location = New System.Drawing.Point(484, 40)
        Me.BtBusca4.Name = "BtBusca4"
        Me.BtBusca4.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca4.TabIndex = 100308
        Me.BtBusca4.UseVisualStyleBackColor = True
        '
        'Lb_4
        '
        Me.Lb_4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_4.Location = New System.Drawing.Point(523, 40)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(392, 23)
        Me.Lb_4.TabIndex = 100310
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
        Me.TxDato4.Location = New System.Drawing.Point(415, 40)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(63, 22)
        Me.TxDato4.TabIndex = 100309
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(301, 43)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(106, 16)
        Me.Lb4.TabIndex = 100307
        Me.Lb4.Text = "Hasta Cliente"
        '
        'Lb_3
        '
        Me.Lb_3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_3.Location = New System.Drawing.Point(523, 12)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(392, 23)
        Me.Lb_3.TabIndex = 100306
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(301, 15)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(108, 16)
        Me.Lb3.TabIndex = 100303
        Me.Lb3.Text = "Desde Cliente"
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
        Me.TxDato3.Location = New System.Drawing.Point(415, 12)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(63, 22)
        Me.TxDato3.TabIndex = 100305
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
        Me.BtBusca3.Location = New System.Drawing.Point(484, 12)
        Me.BtBusca3.Name = "BtBusca3"
        Me.BtBusca3.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca3.TabIndex = 100304
        Me.BtBusca3.UseVisualStyleBackColor = True
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
        Me.Lb5.Location = New System.Drawing.Point(14, 75)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(118, 16)
        Me.Lb5.TabIndex = 100312
        Me.Lb5.Text = "Punto de venta"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(138, 73)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100311
        '
        'FrmDetalleGastosAlbaranesClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmDetalleGastosAlbaranesClientes"
        Me.Text = "Detalle de Gastos Albaranes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTotalizadoCliente As System.Windows.Forms.RadioButton
    Friend WithEvents RbDetalladoAlbaran As System.Windows.Forms.RadioButton
    Friend WithEvents BtBusca4 As NetAgro.BtBusca
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents BtBusca3 As NetAgro.BtBusca
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
