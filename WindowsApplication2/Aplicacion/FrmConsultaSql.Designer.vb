<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSql
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSql))
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarca = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(26, 53)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 68
        Me.Lb2.Text = "Nombre"
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(26, 20)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Codigo"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(103, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(46, 22)
        Me.TxDato1.TabIndex = 74
        Me.TxDato1.TeclaRepetida = False
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(103, 51)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(603, 22)
        Me.TxDato2.TabIndex = 75
        Me.TxDato2.TeclaRepetida = False
        '
        'BtBuscaMarca
        '
        Me.BtBuscaMarca.CL_BuscaAlb = False
        Me.BtBuscaMarca.CL_campocodigo = Nothing
        Me.BtBuscaMarca.CL_camponombre = Nothing
        Me.BtBuscaMarca.CL_CampoOrden = "Nombre"
        Me.BtBuscaMarca.CL_ch1000 = False
        Me.BtBuscaMarca.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMarca.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaMarca.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMarca.CL_dfecha = Nothing
        Me.BtBuscaMarca.CL_Entidad = Nothing
        Me.BtBuscaMarca.CL_EsId = True
        Me.BtBuscaMarca.CL_Filtro = Nothing
        Me.BtBuscaMarca.cl_formu = Nothing
        Me.BtBuscaMarca.CL_hfecha = Nothing
        Me.BtBuscaMarca.cl_ListaW = Nothing
        Me.BtBuscaMarca.CL_xCentro = False
        Me.BtBuscaMarca.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMarca.Location = New System.Drawing.Point(155, 17)
        Me.BtBuscaMarca.Name = "BtBuscaMarca"
        Me.BtBuscaMarca.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMarca.TabIndex = 76
        Me.BtBuscaMarca.UseVisualStyleBackColor = True
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(194, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 77
        Me.BotonesAvance1.Udato = Nothing
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(29, 98)
        Me.TxDato3.MiError = False
        Me.TxDato3.Multiline = True
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(677, 292)
        Me.TxDato3.TabIndex = 79
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
        Me.Lb3.Location = New System.Drawing.Point(321, 79)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(72, 16)
        Me.Lb3.TabIndex = 78
        Me.Lb3.Text = "Consulta"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(30, 405)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(378, 16)
        Me.Lb4.TabIndex = 80
        Me.Lb4.Text = "Variables: #F_fechas#, #S_string#, #N_números#"
        '
        'FrmConsultaSql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 473)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaMarca)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaSql"
        Me.Text = "ConsultasSql"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarca As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
End Class
