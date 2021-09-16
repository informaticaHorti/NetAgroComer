<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreviones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPreviones))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbAgr = New NetAgro.Lb(Me.components)
        Me.LbNomAgr = New NetAgro.Lb(Me.components)
        Me.BtAgr = New NetAgro.BtBusca(Me.components)
        Me.TxObserva = New NetAgro.TxDato(Me.components)
        Me.LbObserva = New NetAgro.Lb(Me.components)
        Me.LbFecha = New NetAgro.Lb(Me.components)
        Me.TxFecha = New NetAgro.TxDato(Me.components)
        Me.TxAgricultor = New NetAgro.TxDato(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LbObs = New NetAgro.Lb(Me.components)
        Me.TxObs = New NetAgro.TxDato(Me.components)
        Me.LbNomCultivo2 = New NetAgro.Lb(Me.components)
        Me.LbNomCultivo1 = New NetAgro.Lb(Me.components)
        Me.TxCultivo = New NetAgro.TxDato(Me.components)
        Me.LbCultivo = New NetAgro.Lb(Me.components)
        Me.LbNombreFinca = New NetAgro.Lb(Me.components)
        Me.BtBuscaFinca = New NetAgro.BtBusca(Me.components)
        Me.TxFinca = New NetAgro.TxDato(Me.components)
        Me.LbFinca = New NetAgro.Lb(Me.components)
        Me.LbNomProducto = New NetAgro.Lb(Me.components)
        Me.BtBuscaProducto = New NetAgro.BtBusca(Me.components)
        Me.TxProducto = New NetAgro.TxDato(Me.components)
        Me.LbProducto = New NetAgro.Lb(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbKilos = New NetAgro.Lb(Me.components)
        Me.TxKilos = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Controls.Add(Me.LbAgr)
        Me.Panel4.Controls.Add(Me.LbNomAgr)
        Me.Panel4.Controls.Add(Me.BtAgr)
        Me.Panel4.Controls.Add(Me.LbObserva)
        Me.Panel4.Controls.Add(Me.TxObserva)
        Me.Panel4.Controls.Add(Me.LbFecha)
        Me.Panel4.Controls.Add(Me.TxFecha)
        Me.Panel4.Controls.Add(Me.TxAgricultor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(641, 117)
        Me.Panel4.TabIndex = 72
        '
        'LbAgr
        '
        Me.LbAgr.AutoSize = True
        Me.LbAgr.CL_ControlAsociado = Nothing
        Me.LbAgr.CL_ValorFijo = True
        Me.LbAgr.ClForm = Nothing
        Me.LbAgr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgr.ForeColor = System.Drawing.Color.Teal
        Me.LbAgr.Location = New System.Drawing.Point(12, 12)
        Me.LbAgr.Name = "LbAgr"
        Me.LbAgr.Size = New System.Drawing.Size(79, 16)
        Me.LbAgr.TabIndex = 193
        Me.LbAgr.Text = "Agricultor"
        '
        'LbNomAgr
        '
        Me.LbNomAgr.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgr.CL_ControlAsociado = Nothing
        Me.LbNomAgr.CL_ValorFijo = False
        Me.LbNomAgr.ClForm = Nothing
        Me.LbNomAgr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgr.Location = New System.Drawing.Point(207, 9)
        Me.LbNomAgr.Name = "LbNomAgr"
        Me.LbNomAgr.Size = New System.Drawing.Size(401, 23)
        Me.LbNomAgr.TabIndex = 192
        '
        'BtAgr
        '
        Me.BtAgr.CL_Ancho = 0
        Me.BtAgr.CL_BuscaAlb = False
        Me.BtAgr.CL_campocodigo = Nothing
        Me.BtAgr.CL_camponombre = Nothing
        Me.BtAgr.CL_CampoOrden = "Nombre"
        Me.BtAgr.CL_ch1000 = False
        Me.BtAgr.CL_ConsultaSql = "Select * from familias"
        Me.BtAgr.CL_ControlAsociado = Me.TxObserva
        Me.BtAgr.CL_DevuelveCampo = "Idfamilia"
        Me.BtAgr.CL_dfecha = Nothing
        Me.BtAgr.CL_Entidad = Nothing
        Me.BtAgr.CL_EsId = True
        Me.BtAgr.CL_Filtro = Nothing
        Me.BtAgr.cl_formu = Nothing
        Me.BtAgr.CL_hfecha = Nothing
        Me.BtAgr.cl_ListaW = Nothing
        Me.BtAgr.CL_xCentro = False
        Me.BtAgr.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtAgr.Location = New System.Drawing.Point(168, 9)
        Me.BtAgr.Name = "BtAgr"
        Me.BtAgr.Size = New System.Drawing.Size(33, 23)
        Me.BtAgr.TabIndex = 191
        Me.BtAgr.UseVisualStyleBackColor = True
        '
        'TxObserva
        '
        Me.TxObserva.Autonumerico = False
        Me.TxObserva.Buscando = False
        Me.TxObserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObserva.ClForm = Nothing
        Me.TxObserva.ClParam = Nothing
        Me.TxObserva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObserva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObserva.GridLin = Nothing
        Me.TxObserva.HaCambiado = False
        Me.TxObserva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObserva.lbbusca = Nothing
        Me.TxObserva.Location = New System.Drawing.Point(91, 72)
        Me.TxObserva.MiError = False
        Me.TxObserva.Name = "TxObserva"
        Me.TxObserva.Orden = 0
        Me.TxObserva.SaltoAlfinal = False
        Me.TxObserva.Siguiente = 0
        Me.TxObserva.Size = New System.Drawing.Size(521, 22)
        Me.TxObserva.TabIndex = 189
        Me.TxObserva.TeclaRepetida = False
        Me.TxObserva.TxDatoFinalSemana = Nothing
        Me.TxObserva.TxDatoInicioSemana = Nothing
        Me.TxObserva.UltimoValorValidado = Nothing
        '
        'LbObserva
        '
        Me.LbObserva.AutoSize = True
        Me.LbObserva.CL_ControlAsociado = Nothing
        Me.LbObserva.CL_ValorFijo = False
        Me.LbObserva.ClForm = Nothing
        Me.LbObserva.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObserva.ForeColor = System.Drawing.Color.Teal
        Me.LbObserva.Location = New System.Drawing.Point(12, 75)
        Me.LbObserva.Name = "LbObserva"
        Me.LbObserva.Size = New System.Drawing.Size(65, 16)
        Me.LbObserva.TabIndex = 190
        Me.LbObserva.Text = "Observ."
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.CL_ControlAsociado = Nothing
        Me.LbFecha.CL_ValorFijo = False
        Me.LbFecha.ClForm = Nothing
        Me.LbFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbFecha.Location = New System.Drawing.Point(12, 44)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(52, 16)
        Me.LbFecha.TabIndex = 77
        Me.LbFecha.Text = "Fecha"
        '
        'TxFecha
        '
        Me.TxFecha.Autonumerico = False
        Me.TxFecha.Buscando = False
        Me.TxFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFecha.ClForm = Nothing
        Me.TxFecha.ClParam = Nothing
        Me.TxFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFecha.GridLin = Nothing
        Me.TxFecha.HaCambiado = False
        Me.TxFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFecha.lbbusca = Nothing
        Me.TxFecha.Location = New System.Drawing.Point(91, 40)
        Me.TxFecha.MiError = False
        Me.TxFecha.Name = "TxFecha"
        Me.TxFecha.Orden = 0
        Me.TxFecha.SaltoAlfinal = False
        Me.TxFecha.Siguiente = 0
        Me.TxFecha.Size = New System.Drawing.Size(93, 22)
        Me.TxFecha.TabIndex = 76
        Me.TxFecha.TeclaRepetida = False
        Me.TxFecha.TxDatoFinalSemana = Nothing
        Me.TxFecha.TxDatoInicioSemana = Nothing
        Me.TxFecha.UltimoValorValidado = Nothing
        '
        'TxAgricultor
        '
        Me.TxAgricultor.Autonumerico = False
        Me.TxAgricultor.Buscando = False
        Me.TxAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultor.ClForm = Nothing
        Me.TxAgricultor.ClParam = Nothing
        Me.TxAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultor.GridLin = Nothing
        Me.TxAgricultor.HaCambiado = False
        Me.TxAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAgricultor.lbbusca = Nothing
        Me.TxAgricultor.Location = New System.Drawing.Point(91, 10)
        Me.TxAgricultor.MiError = False
        Me.TxAgricultor.Name = "TxAgricultor"
        Me.TxAgricultor.Orden = 0
        Me.TxAgricultor.SaltoAlfinal = False
        Me.TxAgricultor.Siguiente = 0
        Me.TxAgricultor.Size = New System.Drawing.Size(75, 22)
        Me.TxAgricultor.TabIndex = 65
        Me.TxAgricultor.TeclaRepetida = False
        Me.TxAgricultor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAgricultor.UltimoValorValidado = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.LbObs)
        Me.Panel2.Controls.Add(Me.TxObs)
        Me.Panel2.Controls.Add(Me.LbNomCultivo2)
        Me.Panel2.Controls.Add(Me.LbNomCultivo1)
        Me.Panel2.Controls.Add(Me.LbCultivo)
        Me.Panel2.Controls.Add(Me.TxCultivo)
        Me.Panel2.Controls.Add(Me.LbNombreFinca)
        Me.Panel2.Controls.Add(Me.BtBuscaFinca)
        Me.Panel2.Controls.Add(Me.LbFinca)
        Me.Panel2.Controls.Add(Me.TxFinca)
        Me.Panel2.Controls.Add(Me.LbNomProducto)
        Me.Panel2.Controls.Add(Me.BtBuscaProducto)
        Me.Panel2.Controls.Add(Me.LbProducto)
        Me.Panel2.Controls.Add(Me.TxProducto)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.LbKilos)
        Me.Panel2.Controls.Add(Me.TxKilos)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 374)
        Me.Panel2.TabIndex = 73
        '
        'Button2
        '
        Me.Button2.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.Button2.Location = New System.Drawing.Point(172, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 193
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbObs
        '
        Me.LbObs.AutoSize = True
        Me.LbObs.CL_ControlAsociado = Nothing
        Me.LbObs.CL_ValorFijo = False
        Me.LbObs.ClForm = Nothing
        Me.LbObs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObs.ForeColor = System.Drawing.Color.Teal
        Me.LbObs.Location = New System.Drawing.Point(16, 163)
        Me.LbObs.Name = "LbObs"
        Me.LbObs.Size = New System.Drawing.Size(65, 16)
        Me.LbObs.TabIndex = 192
        Me.LbObs.Text = "Observ."
        '
        'TxObs
        '
        Me.TxObs.Autonumerico = False
        Me.TxObs.Buscando = False
        Me.TxObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxObs.ClForm = Nothing
        Me.TxObs.ClParam = Nothing
        Me.TxObs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxObs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxObs.GridLin = Nothing
        Me.TxObs.HaCambiado = False
        Me.TxObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxObs.lbbusca = Nothing
        Me.TxObs.Location = New System.Drawing.Point(93, 161)
        Me.TxObs.MiError = False
        Me.TxObs.Name = "TxObs"
        Me.TxObs.Orden = 0
        Me.TxObs.SaltoAlfinal = False
        Me.TxObs.Siguiente = 0
        Me.TxObs.Size = New System.Drawing.Size(521, 22)
        Me.TxObs.TabIndex = 191
        Me.TxObs.TeclaRepetida = False
        Me.TxObs.TxDatoFinalSemana = Nothing
        Me.TxObs.TxDatoInicioSemana = Nothing
        Me.TxObs.UltimoValorValidado = Nothing
        '
        'LbNomCultivo2
        '
        Me.LbNomCultivo2.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCultivo2.CL_ControlAsociado = Nothing
        Me.LbNomCultivo2.CL_ValorFijo = False
        Me.LbNomCultivo2.ClForm = Nothing
        Me.LbNomCultivo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCultivo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCultivo2.Location = New System.Drawing.Point(211, 130)
        Me.LbNomCultivo2.Name = "LbNomCultivo2"
        Me.LbNomCultivo2.Size = New System.Drawing.Size(401, 23)
        Me.LbNomCultivo2.TabIndex = 149
        '
        'LbNomCultivo1
        '
        Me.LbNomCultivo1.BackColor = System.Drawing.Color.LightGray
        Me.LbNomCultivo1.CL_ControlAsociado = Nothing
        Me.LbNomCultivo1.CL_ValorFijo = False
        Me.LbNomCultivo1.ClForm = Nothing
        Me.LbNomCultivo1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCultivo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCultivo1.Location = New System.Drawing.Point(211, 103)
        Me.LbNomCultivo1.Name = "LbNomCultivo1"
        Me.LbNomCultivo1.Size = New System.Drawing.Size(401, 23)
        Me.LbNomCultivo1.TabIndex = 148
        '
        'TxCultivo
        '
        Me.TxCultivo.Autonumerico = False
        Me.TxCultivo.Buscando = False
        Me.TxCultivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCultivo.ClForm = Nothing
        Me.TxCultivo.ClParam = Nothing
        Me.TxCultivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCultivo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCultivo.GridLin = Nothing
        Me.TxCultivo.HaCambiado = False
        Me.TxCultivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCultivo.lbbusca = Nothing
        Me.TxCultivo.Location = New System.Drawing.Point(91, 103)
        Me.TxCultivo.MiError = False
        Me.TxCultivo.Name = "TxCultivo"
        Me.TxCultivo.Orden = 0
        Me.TxCultivo.SaltoAlfinal = False
        Me.TxCultivo.Siguiente = 0
        Me.TxCultivo.Size = New System.Drawing.Size(75, 22)
        Me.TxCultivo.TabIndex = 145
        Me.TxCultivo.TeclaRepetida = False
        Me.TxCultivo.TxDatoFinalSemana = Nothing
        Me.TxCultivo.TxDatoInicioSemana = Nothing
        Me.TxCultivo.UltimoValorValidado = Nothing
        '
        'LbCultivo
        '
        Me.LbCultivo.AutoSize = True
        Me.LbCultivo.CL_ControlAsociado = Nothing
        Me.LbCultivo.CL_ValorFijo = False
        Me.LbCultivo.ClForm = Nothing
        Me.LbCultivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCultivo.ForeColor = System.Drawing.Color.Teal
        Me.LbCultivo.Location = New System.Drawing.Point(16, 106)
        Me.LbCultivo.Name = "LbCultivo"
        Me.LbCultivo.Size = New System.Drawing.Size(59, 16)
        Me.LbCultivo.TabIndex = 146
        Me.LbCultivo.Text = "Cultivo"
        '
        'LbNombreFinca
        '
        Me.LbNombreFinca.BackColor = System.Drawing.Color.LightGray
        Me.LbNombreFinca.CL_ControlAsociado = Nothing
        Me.LbNombreFinca.CL_ValorFijo = False
        Me.LbNombreFinca.ClForm = Nothing
        Me.LbNombreFinca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreFinca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNombreFinca.Location = New System.Drawing.Point(211, 75)
        Me.LbNombreFinca.Name = "LbNombreFinca"
        Me.LbNombreFinca.Size = New System.Drawing.Size(401, 23)
        Me.LbNombreFinca.TabIndex = 144
        '
        'BtBuscaFinca
        '
        Me.BtBuscaFinca.CL_Ancho = 0
        Me.BtBuscaFinca.CL_BuscaAlb = False
        Me.BtBuscaFinca.CL_campocodigo = Nothing
        Me.BtBuscaFinca.CL_camponombre = Nothing
        Me.BtBuscaFinca.CL_CampoOrden = "Nombre"
        Me.BtBuscaFinca.CL_ch1000 = False
        Me.BtBuscaFinca.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFinca.CL_ControlAsociado = Me.TxFinca
        Me.BtBuscaFinca.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFinca.CL_dfecha = Nothing
        Me.BtBuscaFinca.CL_Entidad = Nothing
        Me.BtBuscaFinca.CL_EsId = True
        Me.BtBuscaFinca.CL_Filtro = Nothing
        Me.BtBuscaFinca.cl_formu = Nothing
        Me.BtBuscaFinca.CL_hfecha = Nothing
        Me.BtBuscaFinca.cl_ListaW = Nothing
        Me.BtBuscaFinca.CL_xCentro = False
        Me.BtBuscaFinca.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaFinca.Location = New System.Drawing.Point(172, 75)
        Me.BtBuscaFinca.Name = "BtBuscaFinca"
        Me.BtBuscaFinca.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFinca.TabIndex = 143
        Me.BtBuscaFinca.UseVisualStyleBackColor = True
        '
        'TxFinca
        '
        Me.TxFinca.Autonumerico = False
        Me.TxFinca.Buscando = False
        Me.TxFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFinca.ClForm = Nothing
        Me.TxFinca.ClParam = Nothing
        Me.TxFinca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFinca.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFinca.GridLin = Nothing
        Me.TxFinca.HaCambiado = False
        Me.TxFinca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFinca.lbbusca = Nothing
        Me.TxFinca.Location = New System.Drawing.Point(91, 75)
        Me.TxFinca.MiError = False
        Me.TxFinca.Name = "TxFinca"
        Me.TxFinca.Orden = 0
        Me.TxFinca.SaltoAlfinal = False
        Me.TxFinca.Siguiente = 0
        Me.TxFinca.Size = New System.Drawing.Size(75, 22)
        Me.TxFinca.TabIndex = 141
        Me.TxFinca.TeclaRepetida = False
        Me.TxFinca.TxDatoFinalSemana = Nothing
        Me.TxFinca.TxDatoInicioSemana = Nothing
        Me.TxFinca.UltimoValorValidado = Nothing
        '
        'LbFinca
        '
        Me.LbFinca.AutoSize = True
        Me.LbFinca.CL_ControlAsociado = Nothing
        Me.LbFinca.CL_ValorFijo = False
        Me.LbFinca.ClForm = Nothing
        Me.LbFinca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFinca.ForeColor = System.Drawing.Color.Teal
        Me.LbFinca.Location = New System.Drawing.Point(16, 78)
        Me.LbFinca.Name = "LbFinca"
        Me.LbFinca.Size = New System.Drawing.Size(47, 16)
        Me.LbFinca.TabIndex = 142
        Me.LbFinca.Text = "Finca"
        '
        'LbNomProducto
        '
        Me.LbNomProducto.BackColor = System.Drawing.Color.LightGray
        Me.LbNomProducto.CL_ControlAsociado = Nothing
        Me.LbNomProducto.CL_ValorFijo = False
        Me.LbNomProducto.ClForm = Nothing
        Me.LbNomProducto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomProducto.Location = New System.Drawing.Point(211, 14)
        Me.LbNomProducto.Name = "LbNomProducto"
        Me.LbNomProducto.Size = New System.Drawing.Size(401, 23)
        Me.LbNomProducto.TabIndex = 140
        '
        'BtBuscaProducto
        '
        Me.BtBuscaProducto.CL_Ancho = 0
        Me.BtBuscaProducto.CL_BuscaAlb = False
        Me.BtBuscaProducto.CL_campocodigo = Nothing
        Me.BtBuscaProducto.CL_camponombre = Nothing
        Me.BtBuscaProducto.CL_CampoOrden = "Nombre"
        Me.BtBuscaProducto.CL_ch1000 = False
        Me.BtBuscaProducto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaProducto.CL_ControlAsociado = Me.TxProducto
        Me.BtBuscaProducto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaProducto.CL_dfecha = Nothing
        Me.BtBuscaProducto.CL_Entidad = Nothing
        Me.BtBuscaProducto.CL_EsId = True
        Me.BtBuscaProducto.CL_Filtro = Nothing
        Me.BtBuscaProducto.cl_formu = Nothing
        Me.BtBuscaProducto.CL_hfecha = Nothing
        Me.BtBuscaProducto.cl_ListaW = Nothing
        Me.BtBuscaProducto.CL_xCentro = False
        Me.BtBuscaProducto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaProducto.Location = New System.Drawing.Point(172, 14)
        Me.BtBuscaProducto.Name = "BtBuscaProducto"
        Me.BtBuscaProducto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaProducto.TabIndex = 139
        Me.BtBuscaProducto.UseVisualStyleBackColor = True
        '
        'TxProducto
        '
        Me.TxProducto.Autonumerico = False
        Me.TxProducto.Buscando = False
        Me.TxProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxProducto.ClForm = Nothing
        Me.TxProducto.ClParam = Nothing
        Me.TxProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxProducto.GridLin = Nothing
        Me.TxProducto.HaCambiado = False
        Me.TxProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxProducto.lbbusca = Nothing
        Me.TxProducto.Location = New System.Drawing.Point(91, 14)
        Me.TxProducto.MiError = False
        Me.TxProducto.Name = "TxProducto"
        Me.TxProducto.Orden = 0
        Me.TxProducto.SaltoAlfinal = False
        Me.TxProducto.Siguiente = 0
        Me.TxProducto.Size = New System.Drawing.Size(75, 22)
        Me.TxProducto.TabIndex = 137
        Me.TxProducto.TeclaRepetida = False
        Me.TxProducto.TxDatoFinalSemana = Nothing
        Me.TxProducto.TxDatoInicioSemana = Nothing
        Me.TxProducto.UltimoValorValidado = Nothing
        '
        'LbProducto
        '
        Me.LbProducto.AutoSize = True
        Me.LbProducto.CL_ControlAsociado = Nothing
        Me.LbProducto.CL_ValorFijo = False
        Me.LbProducto.ClForm = Nothing
        Me.LbProducto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProducto.ForeColor = System.Drawing.Color.Teal
        Me.LbProducto.Location = New System.Drawing.Point(16, 17)
        Me.LbProducto.Name = "LbProducto"
        Me.LbProducto.Size = New System.Drawing.Size(73, 16)
        Me.LbProducto.TabIndex = 138
        Me.LbProducto.Text = "Producto"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(897, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(875, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LbKilos
        '
        Me.LbKilos.AutoSize = True
        Me.LbKilos.CL_ControlAsociado = Nothing
        Me.LbKilos.CL_ValorFijo = False
        Me.LbKilos.ClForm = Nothing
        Me.LbKilos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKilos.ForeColor = System.Drawing.Color.Teal
        Me.LbKilos.Location = New System.Drawing.Point(16, 48)
        Me.LbKilos.Name = "LbKilos"
        Me.LbKilos.Size = New System.Drawing.Size(42, 16)
        Me.LbKilos.TabIndex = 102
        Me.LbKilos.Text = "Kilos"
        '
        'TxKilos
        '
        Me.TxKilos.Autonumerico = False
        Me.TxKilos.Buscando = False
        Me.TxKilos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxKilos.ClForm = Nothing
        Me.TxKilos.ClParam = Nothing
        Me.TxKilos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxKilos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKilos.GridLin = Nothing
        Me.TxKilos.HaCambiado = False
        Me.TxKilos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxKilos.lbbusca = Nothing
        Me.TxKilos.Location = New System.Drawing.Point(91, 42)
        Me.TxKilos.MiError = False
        Me.TxKilos.Name = "TxKilos"
        Me.TxKilos.Orden = 0
        Me.TxKilos.SaltoAlfinal = False
        Me.TxKilos.Siguiente = 0
        Me.TxKilos.Size = New System.Drawing.Size(96, 22)
        Me.TxKilos.TabIndex = 101
        Me.TxKilos.TeclaRepetida = False
        Me.TxKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxKilos.TxDatoFinalSemana = Nothing
        Me.TxKilos.TxDatoInicioSemana = Nothing
        Me.TxKilos.UltimoValorValidado = Nothing
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(-3, 193)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(637, 170)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmPreviones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 528)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmPreviones"
        Me.Text = "Previsiones"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxAgricultor As NetAgro.TxDato
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbFecha As NetAgro.Lb
    Friend WithEvents TxFecha As NetAgro.TxDato
    Friend WithEvents TxKilos As NetAgro.TxDato
    Friend WithEvents LbKilos As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LbNomAgr As NetAgro.Lb
    Friend WithEvents BtAgr As NetAgro.BtBusca
    Friend WithEvents TxObserva As NetAgro.TxDato
    Friend WithEvents LbObserva As NetAgro.Lb
    Friend WithEvents LbAgr As NetAgro.Lb
    Friend WithEvents LbNomProducto As NetAgro.Lb
    Friend WithEvents BtBuscaProducto As NetAgro.BtBusca
    Friend WithEvents TxProducto As NetAgro.TxDato
    Friend WithEvents LbProducto As NetAgro.Lb
    Friend WithEvents LbObs As NetAgro.Lb
    Friend WithEvents TxObs As NetAgro.TxDato
    Friend WithEvents LbNomCultivo2 As NetAgro.Lb
    Friend WithEvents LbNomCultivo1 As NetAgro.Lb
    Friend WithEvents TxCultivo As NetAgro.TxDato
    Friend WithEvents LbCultivo As NetAgro.Lb
    Friend WithEvents LbNombreFinca As NetAgro.Lb
    Friend WithEvents BtBuscaFinca As NetAgro.BtBusca
    Friend WithEvents TxFinca As NetAgro.TxDato
    Friend WithEvents LbFinca As NetAgro.Lb
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
