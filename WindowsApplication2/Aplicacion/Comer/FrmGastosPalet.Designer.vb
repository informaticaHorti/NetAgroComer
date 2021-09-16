<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastosPalet
    Inherits NetAgro.FrMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastosPalet))
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lbnom_15 = New NetAgro.Lb(Me.components)
        Me.TxDato_15 = New NetAgro.TxDato(Me.components)
        Me.Lb_15 = New NetAgro.Lb(Me.components)
        Me.BtBusca_15 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_3 = New NetAgro.TxDato(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.Lbnom_10 = New NetAgro.Lb(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.Lb_10 = New NetAgro.Lb(Me.components)
        Me.BtBusca_10 = New NetAgro.BtBusca(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(629, 10)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(78, 22)
        Me.TxDato_2.TabIndex = 104
        Me.TxDato_2.TeclaRepetida = False
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(536, 13)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(73, 16)
        Me.Lb_2.TabIndex = 103
        Me.Lb_2.Text = "Cantidad"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Enabled = False
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(508, 37)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(24, 22)
        Me.TxDato1.TabIndex = 114
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.Visible = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(505, 27)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(23, 16)
        Me.Lb2.TabIndex = 113
        Me.Lb2.Text = "Id"
        Me.Lb2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(759, 28)
        Me.Panel2.TabIndex = 121
        '
        'ClGrid1
        '
        Me.ClGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 67)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(759, 271)
        Me.ClGrid1.TabIndex = 122
        Me.ClGrid1.UltimoControl = 0
        '
        'Lbnom_15
        '
        Me.Lbnom_15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_15.CL_ControlAsociado = Nothing
        Me.Lbnom_15.CL_ValorFijo = False
        Me.Lbnom_15.ClForm = Nothing
        Me.Lbnom_15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_15.Location = New System.Drawing.Point(188, 37)
        Me.Lbnom_15.Name = "Lbnom_15"
        Me.Lbnom_15.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_15.TabIndex = 149
        '
        'TxDato_15
        '
        Me.TxDato_15.Autonumerico = False
        Me.TxDato_15.Buscando = False
        Me.TxDato_15.ClForm = Nothing
        Me.TxDato_15.ClParam = Nothing
        Me.TxDato_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_15.GridLin = Nothing
        Me.TxDato_15.HaCambiado = False
        Me.TxDato_15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_15.lbbusca = Nothing
        Me.TxDato_15.Location = New System.Drawing.Point(90, 38)
        Me.TxDato_15.MiError = False
        Me.TxDato_15.Name = "TxDato_15"
        Me.TxDato_15.Orden = 0
        Me.TxDato_15.SaltoAlfinal = False
        Me.TxDato_15.Siguiente = 0
        Me.TxDato_15.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_15.TabIndex = 146
        Me.TxDato_15.TeclaRepetida = False
        '
        'Lb_15
        '
        Me.Lb_15.AutoSize = True
        Me.Lb_15.CL_ControlAsociado = Nothing
        Me.Lb_15.CL_ValorFijo = False
        Me.Lb_15.ClForm = Nothing
        Me.Lb_15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_15.ForeColor = System.Drawing.Color.Teal
        Me.Lb_15.Location = New System.Drawing.Point(12, 43)
        Me.Lb_15.Name = "Lb_15"
        Me.Lb_15.Size = New System.Drawing.Size(52, 16)
        Me.Lb_15.TabIndex = 147
        Me.Lb_15.Text = "Marca"
        '
        'BtBusca_15
        '
        Me.BtBusca_15.CL_BuscaAlb = False
        Me.BtBusca_15.CL_campocodigo = Nothing
        Me.BtBusca_15.CL_camponombre = Nothing
        Me.BtBusca_15.CL_CampoOrden = "Nombre"
        Me.BtBusca_15.CL_ch1000 = False
        Me.BtBusca_15.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_15.CL_ControlAsociado = Me.TxDato_15
        Me.BtBusca_15.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_15.CL_dfecha = Nothing
        Me.BtBusca_15.CL_Entidad = Nothing
        Me.BtBusca_15.CL_Filtro = Nothing
        Me.BtBusca_15.cl_formu = Nothing
        Me.BtBusca_15.CL_hfecha = Nothing
        Me.BtBusca_15.cl_ListaW = Nothing
        Me.BtBusca_15.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_15.Location = New System.Drawing.Point(149, 38)
        Me.BtBusca_15.Name = "BtBusca_15"
        Me.BtBusca_15.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_15.TabIndex = 148
        Me.BtBusca_15.UseVisualStyleBackColor = True
        '
        'TxDato_3
        '
        Me.TxDato_3.Autonumerico = False
        Me.TxDato_3.Buscando = False
        Me.TxDato_3.ClForm = Nothing
        Me.TxDato_3.ClParam = Nothing
        Me.TxDato_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_3.GridLin = Nothing
        Me.TxDato_3.HaCambiado = False
        Me.TxDato_3.lbbusca = Nothing
        Me.TxDato_3.Location = New System.Drawing.Point(629, 38)
        Me.TxDato_3.MiError = False
        Me.TxDato_3.Name = "TxDato_3"
        Me.TxDato_3.Orden = 0
        Me.TxDato_3.SaltoAlfinal = False
        Me.TxDato_3.Siguiente = 0
        Me.TxDato_3.Size = New System.Drawing.Size(78, 22)
        Me.TxDato_3.TabIndex = 157
        Me.TxDato_3.TeclaRepetida = False
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(536, 41)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(53, 16)
        Me.Lb_3.TabIndex = 156
        Me.Lb_3.Text = "Precio"
        '
        'Lbnom_10
        '
        Me.Lbnom_10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_10.CL_ControlAsociado = Nothing
        Me.Lbnom_10.CL_ValorFijo = False
        Me.Lbnom_10.ClForm = Nothing
        Me.Lbnom_10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_10.Location = New System.Drawing.Point(188, 6)
        Me.Lbnom_10.Name = "Lbnom_10"
        Me.Lbnom_10.Size = New System.Drawing.Size(314, 23)
        Me.Lbnom_10.TabIndex = 163
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(90, 6)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_10.TabIndex = 160
        Me.TxDato_10.TeclaRepetida = False
        '
        'Lb_10
        '
        Me.Lb_10.AutoSize = True
        Me.Lb_10.CL_ControlAsociado = Nothing
        Me.Lb_10.CL_ValorFijo = False
        Me.Lb_10.ClForm = Nothing
        Me.Lb_10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_10.ForeColor = System.Drawing.Color.Teal
        Me.Lb_10.Location = New System.Drawing.Point(12, 10)
        Me.Lb_10.Name = "Lb_10"
        Me.Lb_10.Size = New System.Drawing.Size(61, 16)
        Me.Lb_10.TabIndex = 161
        Me.Lb_10.Text = "Envase"
        '
        'BtBusca_10
        '
        Me.BtBusca_10.CL_BuscaAlb = False
        Me.BtBusca_10.CL_campocodigo = Nothing
        Me.BtBusca_10.CL_camponombre = Nothing
        Me.BtBusca_10.CL_CampoOrden = "Nombre"
        Me.BtBusca_10.CL_ch1000 = False
        Me.BtBusca_10.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_10.CL_ControlAsociado = Me.TxDato_10
        Me.BtBusca_10.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_10.CL_dfecha = Nothing
        Me.BtBusca_10.CL_Entidad = Nothing
        Me.BtBusca_10.CL_Filtro = Nothing
        Me.BtBusca_10.cl_formu = Nothing
        Me.BtBusca_10.CL_hfecha = Nothing
        Me.BtBusca_10.cl_ListaW = Nothing
        Me.BtBusca_10.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_10.Location = New System.Drawing.Point(149, 6)
        Me.BtBusca_10.Name = "BtBusca_10"
        Me.BtBusca_10.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_10.TabIndex = 162
        Me.BtBusca_10.UseVisualStyleBackColor = True
        '
        'FrmGastosPalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 400)
        Me.Controls.Add(Me.Lbnom_10)
        Me.Controls.Add(Me.TxDato_10)
        Me.Controls.Add(Me.Lb_10)
        Me.Controls.Add(Me.BtBusca_10)
        Me.Controls.Add(Me.TxDato_3)
        Me.Controls.Add(Me.Lb_3)
        Me.Controls.Add(Me.Lbnom_15)
        Me.Controls.Add(Me.TxDato_15)
        Me.Controls.Add(Me.Lb_15)
        Me.Controls.Add(Me.BtBusca_15)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato_2)
        Me.Controls.Add(Me.Lb_2)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGastosPalet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos Palet"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb_2, 0)
        Me.Controls.SetChildIndex(Me.TxDato_2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_15, 0)
        Me.Controls.SetChildIndex(Me.Lb_15, 0)
        Me.Controls.SetChildIndex(Me.TxDato_15, 0)
        Me.Controls.SetChildIndex(Me.Lbnom_15, 0)
        Me.Controls.SetChildIndex(Me.Lb_3, 0)
        Me.Controls.SetChildIndex(Me.TxDato_3, 0)
        Me.Controls.SetChildIndex(Me.BtBusca_10, 0)
        Me.Controls.SetChildIndex(Me.Lb_10, 0)
        Me.Controls.SetChildIndex(Me.TxDato_10, 0)
        Me.Controls.SetChildIndex(Me.Lbnom_10, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_15 As NetAgro.Lb
    Friend WithEvents TxDato_15 As NetAgro.TxDato
    Friend WithEvents Lb_15 As NetAgro.Lb
    Friend WithEvents BtBusca_15 As NetAgro.BtBusca
    Friend WithEvents TxDato_3 As NetAgro.TxDato
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents Lbnom_10 As NetAgro.Lb
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents Lb_10 As NetAgro.Lb
    Friend WithEvents BtBusca_10 As NetAgro.BtBusca
End Class
