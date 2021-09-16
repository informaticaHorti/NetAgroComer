<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImporte346
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImporte346))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.TxImporte = New NetAgro.TxDato(Me.components)
        Me.LbConcepto = New NetAgro.Lb(Me.components)
        Me.TxConcepto = New NetAgro.TxDato(Me.components)
        Me.LbNomConcepto = New NetAgro.Lb(Me.components)
        Me.BtConcepto = New NetAgro.BtBusca(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbNomAgricultor = New NetAgro.Lb(Me.components)
        Me.BtAgricultor = New NetAgro.BtBusca(Me.components)
        Me.BtEjercicio = New NetAgro.BtBusca(Me.components)
        Me.TxEjercicio = New NetAgro.TxDato(Me.components)
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.BtEjercicio)
        Me.Panel4.Controls.Add(Me.LbEjercicio)
        Me.Panel4.Controls.Add(Me.TxEjercicio)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(781, 371)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LbImporte)
        Me.GroupBox1.Controls.Add(Me.TxImporte)
        Me.GroupBox1.Controls.Add(Me.LbConcepto)
        Me.GroupBox1.Controls.Add(Me.TxConcepto)
        Me.GroupBox1.Controls.Add(Me.LbNomConcepto)
        Me.GroupBox1.Controls.Add(Me.BtConcepto)
        Me.GroupBox1.Controls.Add(Me.ClGrid1)
        Me.GroupBox1.Controls.Add(Me.LbAgricultor)
        Me.GroupBox1.Controls.Add(Me.TxAgricultor)
        Me.GroupBox1.Controls.Add(Me.LbNomAgricultor)
        Me.GroupBox1.Controls.Add(Me.BtAgricultor)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 310)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.Teal
        Me.LbImporte.Location = New System.Drawing.Point(10, 86)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(67, 16)
        Me.LbImporte.TabIndex = 204
        Me.LbImporte.Text = "Importe"
        '
        'TxImporte
        '
        Me.TxImporte.Autonumerico = False
        Me.TxImporte.Buscando = False
        Me.TxImporte.ClForm = Nothing
        Me.TxImporte.ClParam = Nothing
        Me.TxImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte.GridLin = Nothing
        Me.TxImporte.HaCambiado = False
        Me.TxImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporte.lbbusca = Nothing
        Me.TxImporte.Location = New System.Drawing.Point(103, 82)
        Me.TxImporte.MiError = False
        Me.TxImporte.Name = "TxImporte"
        Me.TxImporte.Orden = 0
        Me.TxImporte.SaltoAlfinal = False
        Me.TxImporte.Siguiente = 0
        Me.TxImporte.Size = New System.Drawing.Size(134, 22)
        Me.TxImporte.TabIndex = 203
        Me.TxImporte.TeclaRepetida = False
        Me.TxImporte.TxDatoFinalSemana = Nothing
        Me.TxImporte.TxDatoInicioSemana = Nothing
        Me.TxImporte.UltimoValorValidado = Nothing
        '
        'LbConcepto
        '
        Me.LbConcepto.AutoSize = True
        Me.LbConcepto.CL_ControlAsociado = Nothing
        Me.LbConcepto.CL_ValorFijo = False
        Me.LbConcepto.ClForm = Nothing
        Me.LbConcepto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConcepto.ForeColor = System.Drawing.Color.Teal
        Me.LbConcepto.Location = New System.Drawing.Point(10, 58)
        Me.LbConcepto.Name = "LbConcepto"
        Me.LbConcepto.Size = New System.Drawing.Size(77, 16)
        Me.LbConcepto.TabIndex = 200
        Me.LbConcepto.Text = "Concepto"
        '
        'TxConcepto
        '
        Me.TxConcepto.Autonumerico = False
        Me.TxConcepto.Buscando = False
        Me.TxConcepto.ClForm = Nothing
        Me.TxConcepto.ClParam = Nothing
        Me.TxConcepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxConcepto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxConcepto.GridLin = Nothing
        Me.TxConcepto.HaCambiado = False
        Me.TxConcepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxConcepto.lbbusca = Nothing
        Me.TxConcepto.Location = New System.Drawing.Point(103, 54)
        Me.TxConcepto.MiError = False
        Me.TxConcepto.Name = "TxConcepto"
        Me.TxConcepto.Orden = 0
        Me.TxConcepto.SaltoAlfinal = False
        Me.TxConcepto.Siguiente = 0
        Me.TxConcepto.Size = New System.Drawing.Size(62, 22)
        Me.TxConcepto.TabIndex = 199
        Me.TxConcepto.TeclaRepetida = False
        Me.TxConcepto.TxDatoFinalSemana = Nothing
        Me.TxConcepto.TxDatoInicioSemana = Nothing
        Me.TxConcepto.UltimoValorValidado = Nothing
        '
        'LbNomConcepto
        '
        Me.LbNomConcepto.BackColor = System.Drawing.Color.LightGray
        Me.LbNomConcepto.CL_ControlAsociado = Nothing
        Me.LbNomConcepto.CL_ValorFijo = False
        Me.LbNomConcepto.ClForm = Nothing
        Me.LbNomConcepto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomConcepto.Location = New System.Drawing.Point(243, 56)
        Me.LbNomConcepto.Name = "LbNomConcepto"
        Me.LbNomConcepto.Size = New System.Drawing.Size(493, 18)
        Me.LbNomConcepto.TabIndex = 202
        '
        'BtConcepto
        '
        Me.BtConcepto.CL_Ancho = 0
        Me.BtConcepto.CL_BuscaAlb = False
        Me.BtConcepto.CL_campocodigo = Nothing
        Me.BtConcepto.CL_camponombre = Nothing
        Me.BtConcepto.CL_CampoOrden = "Nombre"
        Me.BtConcepto.CL_ch1000 = False
        Me.BtConcepto.CL_ConsultaSql = "Select * from familias"
        Me.BtConcepto.CL_ControlAsociado = Me.TxConcepto
        Me.BtConcepto.CL_DevuelveCampo = "Idfamilia"
        Me.BtConcepto.CL_dfecha = Nothing
        Me.BtConcepto.CL_Entidad = Nothing
        Me.BtConcepto.CL_EsId = True
        Me.BtConcepto.CL_Filtro = Nothing
        Me.BtConcepto.cl_formu = Nothing
        Me.BtConcepto.CL_hfecha = Nothing
        Me.BtConcepto.cl_ListaW = Nothing
        Me.BtConcepto.CL_xCentro = False
        Me.BtConcepto.Image = CType(resources.GetObject("BtConcepto.Image"), System.Drawing.Image)
        Me.BtConcepto.Location = New System.Drawing.Point(204, 54)
        Me.BtConcepto.Name = "BtConcepto"
        Me.BtConcepto.Size = New System.Drawing.Size(33, 23)
        Me.BtConcepto.TabIndex = 201
        Me.BtConcepto.UseVisualStyleBackColor = True
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(3, 120)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(751, 187)
        Me.ClGrid1.TabIndex = 198
        Me.ClGrid1.UltimoControl = 0
        '
        'LbAgricultor
        '
        Me.LbAgricultor.AutoSize = True
        Me.LbAgricultor.CL_ControlAsociado = Nothing
        Me.LbAgricultor.CL_ValorFijo = False
        Me.LbAgricultor.ClForm = Nothing
        Me.LbAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAgricultor.Location = New System.Drawing.Point(10, 29)
        Me.LbAgricultor.Name = "LbAgricultor"
        Me.LbAgricultor.Size = New System.Drawing.Size(79, 16)
        Me.LbAgricultor.TabIndex = 72
        Me.LbAgricultor.Text = "Agricultor"
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(103, 26)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(62, 22)
        Me.TxAgricultor.TabIndex = 71
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
        '
        'LbNomAgricultor
        '
        Me.LbNomAgricultor.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgricultor.CL_ControlAsociado = Nothing
        Me.LbNomAgricultor.CL_ValorFijo = False
        Me.LbNomAgricultor.ClForm = Nothing
        Me.LbNomAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultor.Location = New System.Drawing.Point(243, 27)
        Me.LbNomAgricultor.Name = "LbNomAgricultor"
        Me.LbNomAgricultor.Size = New System.Drawing.Size(493, 18)
        Me.LbNomAgricultor.TabIndex = 74
        '
        'BtAgricultor
        '
        Me.BtAgricultor.CL_Ancho = 0
        Me.BtAgricultor.CL_BuscaAlb = False
        Me.BtAgricultor.CL_campocodigo = Nothing
        Me.BtAgricultor.CL_camponombre = Nothing
        Me.BtAgricultor.CL_CampoOrden = "Nombre"
        Me.BtAgricultor.CL_ch1000 = False
        Me.BtAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtAgricultor.CL_ControlAsociado = Me.TxAgricultor
        Me.BtAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtAgricultor.CL_dfecha = Nothing
        Me.BtAgricultor.CL_Entidad = Nothing
        Me.BtAgricultor.CL_EsId = True
        Me.BtAgricultor.CL_Filtro = Nothing
        Me.BtAgricultor.cl_formu = Nothing
        Me.BtAgricultor.CL_hfecha = Nothing
        Me.BtAgricultor.cl_ListaW = Nothing
        Me.BtAgricultor.CL_xCentro = False
        Me.BtAgricultor.Image = CType(resources.GetObject("BtAgricultor.Image"), System.Drawing.Image)
        Me.BtAgricultor.Location = New System.Drawing.Point(204, 25)
        Me.BtAgricultor.Name = "BtAgricultor"
        Me.BtAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtAgricultor.TabIndex = 73
        Me.BtAgricultor.UseVisualStyleBackColor = True
        '
        'BtEjercicio
        '
        Me.BtEjercicio.CL_Ancho = 0
        Me.BtEjercicio.CL_BuscaAlb = False
        Me.BtEjercicio.CL_campocodigo = Nothing
        Me.BtEjercicio.CL_camponombre = Nothing
        Me.BtEjercicio.CL_CampoOrden = "Nombre"
        Me.BtEjercicio.CL_ch1000 = False
        Me.BtEjercicio.CL_ConsultaSql = "Select * from familias"
        Me.BtEjercicio.CL_ControlAsociado = Me.TxEjercicio
        Me.BtEjercicio.CL_DevuelveCampo = "Idfamilia"
        Me.BtEjercicio.CL_dfecha = Nothing
        Me.BtEjercicio.CL_Entidad = Nothing
        Me.BtEjercicio.CL_EsId = True
        Me.BtEjercicio.CL_Filtro = Nothing
        Me.BtEjercicio.cl_formu = Nothing
        Me.BtEjercicio.CL_hfecha = Nothing
        Me.BtEjercicio.cl_ListaW = Nothing
        Me.BtEjercicio.CL_xCentro = False
        Me.BtEjercicio.Image = CType(resources.GetObject("BtEjercicio.Image"), System.Drawing.Image)
        Me.BtEjercicio.Location = New System.Drawing.Point(156, 14)
        Me.BtEjercicio.Name = "BtEjercicio"
        Me.BtEjercicio.Size = New System.Drawing.Size(33, 23)
        Me.BtEjercicio.TabIndex = 70
        Me.BtEjercicio.UseVisualStyleBackColor = True
        '
        'TxEjercicio
        '
        Me.TxEjercicio.Autonumerico = False
        Me.TxEjercicio.Buscando = False
        Me.TxEjercicio.ClForm = Nothing
        Me.TxEjercicio.ClParam = Nothing
        Me.TxEjercicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjercicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjercicio.GridLin = Nothing
        Me.TxEjercicio.HaCambiado = False
        Me.TxEjercicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjercicio.lbbusca = Nothing
        Me.TxEjercicio.Location = New System.Drawing.Point(88, 14)
        Me.TxEjercicio.MiError = False
        Me.TxEjercicio.Name = "TxEjercicio"
        Me.TxEjercicio.Orden = 0
        Me.TxEjercicio.SaltoAlfinal = False
        Me.TxEjercicio.Siguiente = 0
        Me.TxEjercicio.Size = New System.Drawing.Size(62, 22)
        Me.TxEjercicio.TabIndex = 65
        Me.TxEjercicio.TeclaRepetida = False
        Me.TxEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxEjercicio.TxDatoFinalSemana = Nothing
        Me.TxEjercicio.TxDatoInicioSemana = Nothing
        Me.TxEjercicio.UltimoValorValidado = Nothing
        '
        'LbEjercicio
        '
        Me.LbEjercicio.AutoSize = True
        Me.LbEjercicio.CL_ControlAsociado = Nothing
        Me.LbEjercicio.CL_ValorFijo = False
        Me.LbEjercicio.ClForm = Nothing
        Me.LbEjercicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicio.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicio.Location = New System.Drawing.Point(10, 17)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(70, 16)
        Me.LbEjercicio.TabIndex = 66
        Me.LbEjercicio.Text = "Ejercicio"
        '
        'FrmImporte346
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 405)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmImporte346"
        Me.Text = "Importes 346"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbNomAgricultor As NetAgro.Lb
    Friend WithEvents BtAgricultor As NetAgro.BtBusca
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents LbAgricultor As NetAgro.Lb
    Friend WithEvents BtEjercicio As NetAgro.BtBusca
    Friend WithEvents TxEjercicio As NetAgro.TxDato
    Friend WithEvents LbEjercicio As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbConcepto As NetAgro.Lb
    Friend WithEvents TxConcepto As NetAgro.TxDato
    Friend WithEvents LbNomConcepto As NetAgro.Lb
    Friend WithEvents BtConcepto As NetAgro.BtBusca
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents TxImporte As NetAgro.TxDato

End Class
