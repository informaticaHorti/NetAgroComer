<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPedidoMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPedidoMaterial))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBusca2 = New NetAgro.BtBusca(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTodosFinalizados = New System.Windows.Forms.RadioButton()
        Me.RbNoFinalizados = New System.Windows.Forms.RadioButton()
        Me.RbFinalizados = New System.Windows.Forms.RadioButton()
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 117)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 123)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 399)
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
        Me.TxDato1.Location = New System.Drawing.Point(137, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Nothing
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(206, 13)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 50
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(123, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Desde Acreedor"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(245, 13)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(420, 23)
        Me.Lb_1.TabIndex = 75
        '
        'Lb_2
        '
        Me.Lb_2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_2.Location = New System.Drawing.Point(245, 47)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(420, 23)
        Me.Lb_2.TabIndex = 79
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
        Me.TxDato2.Location = New System.Drawing.Point(137, 47)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(63, 22)
        Me.TxDato2.TabIndex = 78
        Me.TxDato2.TeclaRepetida = False
        '
        'BtBusca2
        '
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
        Me.BtBusca2.CL_Filtro = Nothing
        Me.BtBusca2.cl_formu = Nothing
        Me.BtBusca2.CL_hfecha = Nothing
        Me.BtBusca2.cl_ListaW = Nothing
        Me.BtBusca2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca2.Location = New System.Drawing.Point(206, 47)
        Me.BtBusca2.Name = "BtBusca2"
        Me.BtBusca2.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca2.TabIndex = 77
        Me.BtBusca2.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(13, 50)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(121, 16)
        Me.Lb2.TabIndex = 76
        Me.Lb2.Text = "Hasta Acreedor"
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
        Me.TxDato4.Location = New System.Drawing.Point(805, 47)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 83
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
        Me.Lb4.Location = New System.Drawing.Point(686, 50)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(95, 16)
        Me.Lb4.TabIndex = 82
        Me.Lb4.Text = "Hasta fecha"
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
        Me.TxDato3.Location = New System.Drawing.Point(805, 13)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(102, 22)
        Me.TxDato3.TabIndex = 81
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(686, 16)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(97, 16)
        Me.Lb3.TabIndex = 80
        Me.Lb3.Text = "Desde fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTodosFinalizados)
        Me.GroupBox1.Controls.Add(Me.RbNoFinalizados)
        Me.GroupBox1.Controls.Add(Me.RbFinalizados)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(956, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 42)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Finalizado"
        '
        'RbTodosFinalizados
        '
        Me.RbTodosFinalizados.AutoSize = True
        Me.RbTodosFinalizados.Checked = True
        Me.RbTodosFinalizados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodosFinalizados.ForeColor = System.Drawing.Color.Teal
        Me.RbTodosFinalizados.Location = New System.Drawing.Point(157, 15)
        Me.RbTodosFinalizados.Name = "RbTodosFinalizados"
        Me.RbTodosFinalizados.Size = New System.Drawing.Size(69, 20)
        Me.RbTodosFinalizados.TabIndex = 2
        Me.RbTodosFinalizados.TabStop = True
        Me.RbTodosFinalizados.Text = "Todos"
        Me.RbTodosFinalizados.UseVisualStyleBackColor = True
        '
        'RbNoFinalizados
        '
        Me.RbNoFinalizados.AutoSize = True
        Me.RbNoFinalizados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoFinalizados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoFinalizados.Location = New System.Drawing.Point(81, 15)
        Me.RbNoFinalizados.Name = "RbNoFinalizados"
        Me.RbNoFinalizados.Size = New System.Drawing.Size(47, 20)
        Me.RbNoFinalizados.TabIndex = 1
        Me.RbNoFinalizados.Text = "NO"
        Me.RbNoFinalizados.UseVisualStyleBackColor = True
        '
        'RbFinalizados
        '
        Me.RbFinalizados.AutoSize = True
        Me.RbFinalizados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFinalizados.ForeColor = System.Drawing.Color.Teal
        Me.RbFinalizados.Location = New System.Drawing.Point(16, 15)
        Me.RbFinalizados.Name = "RbFinalizados"
        Me.RbFinalizados.Size = New System.Drawing.Size(41, 20)
        Me.RbFinalizados.TabIndex = 0
        Me.RbFinalizados.Text = "SI"
        Me.RbFinalizados.UseVisualStyleBackColor = True
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(137, 83)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(240, 20)
        Me.cbCentro.TabIndex = 100270
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(13, 84)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100272
        Me.Lb5.Text = "Centro"
        '
        'FrmConsultaPedidoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.Lb_2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BtBusca2)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaPedidoMaterial"
        Me.Text = "Consulta pedido material"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb_1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBusca2, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb_2, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBusca2 As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents RbTodosFinalizados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoFinalizados As System.Windows.Forms.RadioButton
    Friend WithEvents RbFinalizados As System.Windows.Forms.RadioButton
End Class
