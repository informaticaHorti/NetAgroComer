<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmitirCarta346

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmitirCarta346))
        Me.BtEjercicio = New NetAgro.BtBusca(Me.components)
        Me.TxEjercicio = New NetAgro.TxDato(Me.components)
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAgricultorHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.TxAgricultorDesde = New NetAgro.TxDato(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxNombreFichero = New NetAgro.TxDato(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Panel1)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.BtEjercicio)
        Me.PanelCabecera.Controls.Add(Me.LbEjercicio)
        Me.PanelCabecera.Controls.Add(Me.TxEjercicio)
        Me.PanelCabecera.Size = New System.Drawing.Size(1000, 202)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 192)
        Me.PanelConsulta.Size = New System.Drawing.Size(584, 390)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(700, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(775, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(850, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(925, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(625, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
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
        Me.BtEjercicio.Location = New System.Drawing.Point(185, 16)
        Me.BtEjercicio.Name = "BtEjercicio"
        Me.BtEjercicio.Size = New System.Drawing.Size(33, 23)
        Me.BtEjercicio.TabIndex = 73
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
        Me.TxEjercicio.Location = New System.Drawing.Point(117, 16)
        Me.TxEjercicio.MiError = False
        Me.TxEjercicio.Name = "TxEjercicio"
        Me.TxEjercicio.Orden = 0
        Me.TxEjercicio.SaltoAlfinal = False
        Me.TxEjercicio.Siguiente = 0
        Me.TxEjercicio.Size = New System.Drawing.Size(62, 22)
        Me.TxEjercicio.TabIndex = 71
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
        Me.LbEjercicio.Location = New System.Drawing.Point(12, 18)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(70, 16)
        Me.LbEjercicio.TabIndex = 72
        Me.LbEjercicio.Text = "Ejercicio"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(590, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(410, 582)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(224, 72)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(356, 23)
        Me.LbNomAgricultorHasta.TabIndex = 87
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(12, 47)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(98, 16)
        Me.LbDesdeAgricultor.TabIndex = 80
        Me.LbDesdeAgricultor.Text = "D. Agricultor"
        '
        'TxAgricultorHasta
        '
        Me.TxAgricultorHasta.Autonumerico = False
        Me.TxAgricultorHasta.Buscando = False
        Me.TxAgricultorHasta.ClForm = Nothing
        Me.TxAgricultorHasta.ClParam = Nothing
        Me.TxAgricultorHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorHasta.GridLin = Nothing
        Me.TxAgricultorHasta.HaCambiado = False
        Me.TxAgricultorHasta.lbbusca = Nothing
        Me.TxAgricultorHasta.Location = New System.Drawing.Point(116, 72)
        Me.TxAgricultorHasta.MiError = False
        Me.TxAgricultorHasta.Name = "TxAgricultorHasta"
        Me.TxAgricultorHasta.Orden = 0
        Me.TxAgricultorHasta.SaltoAlfinal = False
        Me.TxAgricultorHasta.Siguiente = 0
        Me.TxAgricultorHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorHasta.TabIndex = 86
        Me.TxAgricultorHasta.TeclaRepetida = False
        Me.TxAgricultorHasta.TxDatoFinalSemana = Nothing
        Me.TxAgricultorHasta.TxDatoInicioSemana = Nothing
        Me.TxAgricultorHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaAgricultorDesde
        '
        Me.BtBuscaAgricultorDesde.CL_Ancho = 0
        Me.BtBuscaAgricultorDesde.CL_BuscaAlb = False
        Me.BtBuscaAgricultorDesde.CL_campocodigo = Nothing
        Me.BtBuscaAgricultorDesde.CL_camponombre = Nothing
        Me.BtBuscaAgricultorDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultorDesde.CL_ch1000 = False
        Me.BtBuscaAgricultorDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultorDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaAgricultorDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultorDesde.CL_dfecha = Nothing
        Me.BtBuscaAgricultorDesde.CL_Entidad = Nothing
        Me.BtBuscaAgricultorDesde.CL_EsId = True
        Me.BtBuscaAgricultorDesde.CL_Filtro = Nothing
        Me.BtBuscaAgricultorDesde.cl_formu = Nothing
        Me.BtBuscaAgricultorDesde.CL_hfecha = Nothing
        Me.BtBuscaAgricultorDesde.cl_ListaW = Nothing
        Me.BtBuscaAgricultorDesde.CL_xCentro = False
        Me.BtBuscaAgricultorDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(185, 45)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 81
        Me.BtBuscaAgricultorDesde.UseVisualStyleBackColor = True
        '
        'BtBuscaAgricultorHasta
        '
        Me.BtBuscaAgricultorHasta.CL_Ancho = 0
        Me.BtBuscaAgricultorHasta.CL_BuscaAlb = False
        Me.BtBuscaAgricultorHasta.CL_campocodigo = Nothing
        Me.BtBuscaAgricultorHasta.CL_camponombre = Nothing
        Me.BtBuscaAgricultorHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultorHasta.CL_ch1000 = False
        Me.BtBuscaAgricultorHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultorHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaAgricultorHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultorHasta.CL_dfecha = Nothing
        Me.BtBuscaAgricultorHasta.CL_Entidad = Nothing
        Me.BtBuscaAgricultorHasta.CL_EsId = True
        Me.BtBuscaAgricultorHasta.CL_Filtro = Nothing
        Me.BtBuscaAgricultorHasta.cl_formu = Nothing
        Me.BtBuscaAgricultorHasta.CL_hfecha = Nothing
        Me.BtBuscaAgricultorHasta.cl_ListaW = Nothing
        Me.BtBuscaAgricultorHasta.CL_xCentro = False
        Me.BtBuscaAgricultorHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(185, 72)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 85
        Me.BtBuscaAgricultorHasta.UseVisualStyleBackColor = True
        '
        'TxAgricultorDesde
        '
        Me.TxAgricultorDesde.Autonumerico = False
        Me.TxAgricultorDesde.Buscando = False
        Me.TxAgricultorDesde.ClForm = Nothing
        Me.TxAgricultorDesde.ClParam = Nothing
        Me.TxAgricultorDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorDesde.GridLin = Nothing
        Me.TxAgricultorDesde.HaCambiado = False
        Me.TxAgricultorDesde.lbbusca = Nothing
        Me.TxAgricultorDesde.Location = New System.Drawing.Point(116, 45)
        Me.TxAgricultorDesde.MiError = False
        Me.TxAgricultorDesde.Name = "TxAgricultorDesde"
        Me.TxAgricultorDesde.Orden = 0
        Me.TxAgricultorDesde.SaltoAlfinal = False
        Me.TxAgricultorDesde.Siguiente = 0
        Me.TxAgricultorDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorDesde.TabIndex = 82
        Me.TxAgricultorDesde.TeclaRepetida = False
        Me.TxAgricultorDesde.TxDatoFinalSemana = Nothing
        Me.TxAgricultorDesde.TxDatoInicioSemana = Nothing
        Me.TxAgricultorDesde.UltimoValorValidado = Nothing
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(12, 74)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(99, 16)
        Me.LbHastaAgricultor.TabIndex = 84
        Me.LbHastaAgricultor.Text = "H. Agricultor"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(224, 45)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(356, 23)
        Me.LbNomAgricultorDesde.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.TxNombreFichero)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Lb1)
        Me.Panel1.Location = New System.Drawing.Point(12, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 61)
        Me.Panel1.TabIndex = 100278
        '
        'TxNombreFichero
        '
        Me.TxNombreFichero.Autonumerico = False
        Me.TxNombreFichero.Buscando = False
        Me.TxNombreFichero.ClForm = Nothing
        Me.TxNombreFichero.ClParam = Nothing
        Me.TxNombreFichero.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNombreFichero.GridLin = Nothing
        Me.TxNombreFichero.HaCambiado = False
        Me.TxNombreFichero.lbbusca = Nothing
        Me.TxNombreFichero.Location = New System.Drawing.Point(15, 24)
        Me.TxNombreFichero.MiError = False
        Me.TxNombreFichero.Name = "TxNombreFichero"
        Me.TxNombreFichero.Orden = 0
        Me.TxNombreFichero.SaltoAlfinal = False
        Me.TxNombreFichero.Siguiente = 0
        Me.TxNombreFichero.Size = New System.Drawing.Size(503, 22)
        Me.TxNombreFichero.TabIndex = 88
        Me.TxNombreFichero.TeclaRepetida = False
        Me.TxNombreFichero.TxDatoFinalSemana = Nothing
        Me.TxNombreFichero.TxDatoInicioSemana = Nothing
        Me.TxNombreFichero.UltimoValorValidado = Nothing
        '
        'Button1
        '
        Me.Button1.Image = Global.NetAgro.My.Resources.Resources.Add_Property_16
        Me.Button1.Location = New System.Drawing.Point(524, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 3)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(106, 16)
        Me.Lb1.TabIndex = 83
        Me.Lb1.Text = "Fichero Carta"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmEmitirCarta346
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 622)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEmitirCarta346"
        Me.Text = "Emitir Carta 346"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox1, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtEjercicio As NetAgro.BtBusca
    Friend WithEvents TxEjercicio As NetAgro.TxDato
    Friend WithEvents LbEjercicio As NetAgro.Lb
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents TxAgricultorHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents TxAgricultorDesde As NetAgro.TxDato
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxNombreFichero As NetAgro.TxDato
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
