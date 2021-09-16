<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConceptos346
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConceptos346))
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaMarca = New NetAgro.BtBusca(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.TxClave = New NetAgro.TxDato(Me.components)
        Me.LbClave = New NetAgro.Lb(Me.components)
        Me.TxTipo = New NetAgro.TxDato(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
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
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
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
        Me.TxDato2.Size = New System.Drawing.Size(565, 22)
        Me.TxDato2.TabIndex = 75
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BtBuscaMarca
        '
        Me.BtBuscaMarca.CL_Ancho = 0
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
        'TxClave
        '
        Me.TxClave.Autonumerico = False
        Me.TxClave.Buscando = False
        Me.TxClave.ClForm = Nothing
        Me.TxClave.ClParam = Nothing
        Me.TxClave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxClave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClave.GridLin = Nothing
        Me.TxClave.HaCambiado = False
        Me.TxClave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxClave.lbbusca = Nothing
        Me.TxClave.Location = New System.Drawing.Point(103, 79)
        Me.TxClave.MiError = False
        Me.TxClave.Name = "TxClave"
        Me.TxClave.Orden = 0
        Me.TxClave.SaltoAlfinal = False
        Me.TxClave.Siguiente = 0
        Me.TxClave.Size = New System.Drawing.Size(46, 22)
        Me.TxClave.TabIndex = 79
        Me.TxClave.TeclaRepetida = False
        Me.TxClave.TxDatoFinalSemana = Nothing
        Me.TxClave.TxDatoInicioSemana = Nothing
        Me.TxClave.UltimoValorValidado = Nothing
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.CL_ControlAsociado = Nothing
        Me.LbClave.CL_ValorFijo = False
        Me.LbClave.ClForm = Nothing
        Me.LbClave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClave.ForeColor = System.Drawing.Color.Teal
        Me.LbClave.Location = New System.Drawing.Point(26, 81)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(49, 16)
        Me.LbClave.TabIndex = 78
        Me.LbClave.Text = "Clave"
        '
        'TxTipo
        '
        Me.TxTipo.Autonumerico = False
        Me.TxTipo.Buscando = False
        Me.TxTipo.ClForm = Nothing
        Me.TxTipo.ClParam = Nothing
        Me.TxTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxTipo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipo.GridLin = Nothing
        Me.TxTipo.HaCambiado = False
        Me.TxTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxTipo.lbbusca = Nothing
        Me.TxTipo.Location = New System.Drawing.Point(103, 107)
        Me.TxTipo.MiError = False
        Me.TxTipo.Name = "TxTipo"
        Me.TxTipo.Orden = 0
        Me.TxTipo.SaltoAlfinal = False
        Me.TxTipo.Siguiente = 0
        Me.TxTipo.Size = New System.Drawing.Size(46, 22)
        Me.TxTipo.TabIndex = 81
        Me.TxTipo.TeclaRepetida = False
        Me.TxTipo.TxDatoFinalSemana = Nothing
        Me.TxTipo.TxDatoInicioSemana = Nothing
        Me.TxTipo.UltimoValorValidado = Nothing
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = False
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.Teal
        Me.LbTipo.Location = New System.Drawing.Point(26, 109)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(38, 16)
        Me.LbTipo.TabIndex = 80
        Me.LbTipo.Text = "Tipo"
        '
        'FrmConceptos346
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 241)
        Me.Controls.Add(Me.TxTipo)
        Me.Controls.Add(Me.LbTipo)
        Me.Controls.Add(Me.TxClave)
        Me.Controls.Add(Me.LbClave)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaMarca)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConceptos346"
        Me.Text = "Conceptos 346"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaMarca, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.LbClave, 0)
        Me.Controls.SetChildIndex(Me.TxClave, 0)
        Me.Controls.SetChildIndex(Me.LbTipo, 0)
        Me.Controls.SetChildIndex(Me.TxTipo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BtBuscaMarca As NetAgro.BtBusca
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents TxClave As NetAgro.TxDato
    Friend WithEvents LbClave As NetAgro.Lb
    Friend WithEvents TxTipo As NetAgro.TxDato
    Friend WithEvents LbTipo As NetAgro.Lb
End Class
