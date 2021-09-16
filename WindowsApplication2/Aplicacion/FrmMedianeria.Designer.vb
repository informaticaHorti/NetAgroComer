<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmedianeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmedianeria))
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultor = New NetAgro.BtBusca(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.LbNomAgri = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxDato_16 = New NetAgro.TxDato(Me.components)
        Me.Lb_16 = New NetAgro.Lb(Me.components)
        Me.Lbnom_15 = New NetAgro.Lb(Me.components)
        Me.BtBuscaMed1 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_15 = New NetAgro.TxDato(Me.components)
        Me.Lb_15 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbPorAgri = New NetAgro.Lb(Me.components)
        Me.Lb38 = New NetAgro.Lb(Me.components)
        Me.Button2 = New NetAgro.ClButton()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(12, 74)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(65, 16)
        Me.Lb3.TabIndex = 50
        Me.Lb3.Text = "Nombre"
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
        Me.TxDato3.Location = New System.Drawing.Point(106, 72)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(440, 22)
        Me.TxDato3.TabIndex = 49
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.TxDatoFinalSemana = Nothing
        Me.TxDato3.TxDatoInicioSemana = Nothing
        Me.TxDato3.UltimoValorValidado = Nothing
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
        Me.TxDato1.Location = New System.Drawing.Point(106, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 48
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'BtBuscaAgricultor
        '
        Me.BtBuscaAgricultor.CL_Ancho = 0
        Me.BtBuscaAgricultor.CL_BuscaAlb = False
        Me.BtBuscaAgricultor.CL_campocodigo = Nothing
        Me.BtBuscaAgricultor.CL_camponombre = Nothing
        Me.BtBuscaAgricultor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgricultor.CL_ch1000 = False
        Me.BtBuscaAgricultor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgricultor.CL_ControlAsociado = Nothing
        Me.BtBuscaAgricultor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgricultor.CL_dfecha = Nothing
        Me.BtBuscaAgricultor.CL_Entidad = Nothing
        Me.BtBuscaAgricultor.CL_EsId = True
        Me.BtBuscaAgricultor.CL_Filtro = Nothing
        Me.BtBuscaAgricultor.cl_formu = Nothing
        Me.BtBuscaAgricultor.CL_hfecha = Nothing
        Me.BtBuscaAgricultor.cl_ListaW = Nothing
        Me.BtBuscaAgricultor.CL_xCentro = False
        Me.BtBuscaAgricultor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgricultor.Location = New System.Drawing.Point(175, 12)
        Me.BtBuscaAgricultor.Name = "BtBuscaAgricultor"
        Me.BtBuscaAgricultor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultor.TabIndex = 47
        Me.BtBuscaAgricultor.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(12, 46)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 46
        Me.Lb2.Text = "Numero"
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
        Me.TxDato2.Location = New System.Drawing.Point(106, 44)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(33, 22)
        Me.TxDato2.TabIndex = 45
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 19)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(79, 16)
        Me.Lb1.TabIndex = 44
        Me.Lb1.Text = "Agricultor"
        '
        'LbNomAgri
        '
        Me.LbNomAgri.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNomAgri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNomAgri.CL_ControlAsociado = Nothing
        Me.LbNomAgri.CL_ValorFijo = False
        Me.LbNomAgri.ClForm = Nothing
        Me.LbNomAgri.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgri.Location = New System.Drawing.Point(217, 12)
        Me.LbNomAgri.Name = "LbNomAgri"
        Me.LbNomAgri.Size = New System.Drawing.Size(524, 23)
        Me.LbNomAgri.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.TxDato_16)
        Me.Panel3.Controls.Add(Me.Lb_16)
        Me.Panel3.Controls.Add(Me.Lbnom_15)
        Me.Panel3.Controls.Add(Me.BtBuscaMed1)
        Me.Panel3.Controls.Add(Me.TxDato_15)
        Me.Panel3.Controls.Add(Me.Lb_15)
        Me.Panel3.Controls.Add(Me.ClGrid1)
        Me.Panel3.Location = New System.Drawing.Point(3, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(823, 329)
        Me.Panel3.TabIndex = 91
        '
        'TxDato_16
        '
        Me.TxDato_16.Autonumerico = False
        Me.TxDato_16.Buscando = False
        Me.TxDato_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_16.ClForm = Nothing
        Me.TxDato_16.ClParam = Nothing
        Me.TxDato_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_16.GridLin = Nothing
        Me.TxDato_16.HaCambiado = False
        Me.TxDato_16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_16.lbbusca = Nothing
        Me.TxDato_16.Location = New System.Drawing.Point(738, 20)
        Me.TxDato_16.MiError = False
        Me.TxDato_16.Name = "TxDato_16"
        Me.TxDato_16.Orden = 0
        Me.TxDato_16.SaltoAlfinal = False
        Me.TxDato_16.Siguiente = 0
        Me.TxDato_16.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_16.TabIndex = 179
        Me.TxDato_16.TeclaRepetida = False
        Me.TxDato_16.TxDatoFinalSemana = Nothing
        Me.TxDato_16.TxDatoInicioSemana = Nothing
        Me.TxDato_16.UltimoValorValidado = Nothing
        '
        'Lb_16
        '
        Me.Lb_16.AutoSize = True
        Me.Lb_16.CL_ControlAsociado = Nothing
        Me.Lb_16.CL_ValorFijo = False
        Me.Lb_16.ClForm = Nothing
        Me.Lb_16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_16.ForeColor = System.Drawing.Color.Teal
        Me.Lb_16.Location = New System.Drawing.Point(693, 23)
        Me.Lb_16.Name = "Lb_16"
        Me.Lb_16.Size = New System.Drawing.Size(25, 16)
        Me.Lb_16.TabIndex = 178
        Me.Lb_16.Text = "%"
        '
        'Lbnom_15
        '
        Me.Lbnom_15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom_15.CL_ControlAsociado = Nothing
        Me.Lbnom_15.CL_ValorFijo = False
        Me.Lbnom_15.ClForm = Nothing
        Me.Lbnom_15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_15.Location = New System.Drawing.Point(214, 22)
        Me.Lbnom_15.Name = "Lbnom_15"
        Me.Lbnom_15.Size = New System.Drawing.Size(462, 21)
        Me.Lbnom_15.TabIndex = 177
        '
        'BtBuscaMed1
        '
        Me.BtBuscaMed1.CL_Ancho = 0
        Me.BtBuscaMed1.CL_BuscaAlb = False
        Me.BtBuscaMed1.CL_campocodigo = Nothing
        Me.BtBuscaMed1.CL_camponombre = Nothing
        Me.BtBuscaMed1.CL_CampoOrden = "Nombre"
        Me.BtBuscaMed1.CL_ch1000 = False
        Me.BtBuscaMed1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaMed1.CL_ControlAsociado = Me.TxDato_15
        Me.BtBuscaMed1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaMed1.CL_dfecha = Nothing
        Me.BtBuscaMed1.CL_Entidad = Nothing
        Me.BtBuscaMed1.CL_EsId = True
        Me.BtBuscaMed1.CL_Filtro = Nothing
        Me.BtBuscaMed1.cl_formu = Nothing
        Me.BtBuscaMed1.CL_hfecha = Nothing
        Me.BtBuscaMed1.cl_ListaW = Nothing
        Me.BtBuscaMed1.CL_xCentro = False
        Me.BtBuscaMed1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaMed1.Location = New System.Drawing.Point(175, 21)
        Me.BtBuscaMed1.Name = "BtBuscaMed1"
        Me.BtBuscaMed1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaMed1.TabIndex = 176
        Me.BtBuscaMed1.UseVisualStyleBackColor = True
        '
        'TxDato_15
        '
        Me.TxDato_15.Autonumerico = False
        Me.TxDato_15.Buscando = False
        Me.TxDato_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_15.ClForm = Nothing
        Me.TxDato_15.ClParam = Nothing
        Me.TxDato_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_15.GridLin = Nothing
        Me.TxDato_15.HaCambiado = False
        Me.TxDato_15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_15.lbbusca = Nothing
        Me.TxDato_15.Location = New System.Drawing.Point(105, 21)
        Me.TxDato_15.MiError = False
        Me.TxDato_15.Name = "TxDato_15"
        Me.TxDato_15.Orden = 0
        Me.TxDato_15.SaltoAlfinal = False
        Me.TxDato_15.Siguiente = 0
        Me.TxDato_15.Size = New System.Drawing.Size(64, 22)
        Me.TxDato_15.TabIndex = 175
        Me.TxDato_15.TeclaRepetida = False
        Me.TxDato_15.TxDatoFinalSemana = Nothing
        Me.TxDato_15.TxDatoInicioSemana = Nothing
        Me.TxDato_15.UltimoValorValidado = Nothing
        '
        'Lb_15
        '
        Me.Lb_15.AutoSize = True
        Me.Lb_15.CL_ControlAsociado = Nothing
        Me.Lb_15.CL_ValorFijo = False
        Me.Lb_15.ClForm = Nothing
        Me.Lb_15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_15.ForeColor = System.Drawing.Color.Teal
        Me.Lb_15.Location = New System.Drawing.Point(10, 24)
        Me.Lb_15.Name = "Lb_15"
        Me.Lb_15.Size = New System.Drawing.Size(58, 16)
        Me.Lb_15.TabIndex = 174
        Me.Lb_15.Text = "Código"
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
        Me.ClGrid1.Location = New System.Drawing.Point(0, 60)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(823, 269)
        Me.ClGrid1.TabIndex = 90
        Me.ClGrid1.UltimoControl = 0
        '
        'LbPorAgri
        '
        Me.LbPorAgri.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbPorAgri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPorAgri.CL_ControlAsociado = Nothing
        Me.LbPorAgri.CL_ValorFijo = False
        Me.LbPorAgri.ClForm = Nothing
        Me.LbPorAgri.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorAgri.Location = New System.Drawing.Point(655, 71)
        Me.LbPorAgri.Name = "LbPorAgri"
        Me.LbPorAgri.Size = New System.Drawing.Size(74, 21)
        Me.LbPorAgri.TabIndex = 181
        Me.LbPorAgri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb38
        '
        Me.Lb38.AutoSize = True
        Me.Lb38.CL_ControlAsociado = Nothing
        Me.Lb38.CL_ValorFijo = True
        Me.Lb38.ClForm = Nothing
        Me.Lb38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb38.ForeColor = System.Drawing.Color.Teal
        Me.Lb38.Location = New System.Drawing.Point(646, 51)
        Me.Lb38.Name = "Lb38"
        Me.Lb38.Size = New System.Drawing.Size(100, 16)
        Me.Lb38.TabIndex = 180
        Me.Lb38.Text = "% Agricultor"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(143, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Orden = 0
        Me.Button2.PedirClave = True
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 182
        Me.tt.SetToolTip(Me.Button2, "Consulta medianerias")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frmmedianeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 474)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LbPorAgri)
        Me.Controls.Add(Me.Lb38)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LbNomAgri)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBuscaAgricultor)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "Frmmedianeria"
        Me.Text = "Medianeria"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAgricultor, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.LbNomAgri, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Lb38, 0)
        Me.Controls.SetChildIndex(Me.LbPorAgri, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultor As NetAgro.BtBusca
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents LbNomAgri As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents TxDato_16 As NetAgro.TxDato
    Friend WithEvents Lb_16 As NetAgro.Lb
    Friend WithEvents Lbnom_15 As NetAgro.Lb
    Friend WithEvents BtBuscaMed1 As NetAgro.BtBusca
    Friend WithEvents TxDato_15 As NetAgro.TxDato
    Friend WithEvents Lb_15 As NetAgro.Lb
    Friend WithEvents LbPorAgri As NetAgro.Lb
    Friend WithEvents Lb38 As NetAgro.Lb
    Friend WithEvents Button2 As NetAgro.ClButton
End Class
