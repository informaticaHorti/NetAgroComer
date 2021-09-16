<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGasComerSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGasComerSalidas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LbAlba = New NetAgro.Lb(Me.components)
        Me.LbTipo = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.LbIgasto = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.LbGasto = New NetAgro.Lb(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbReferencia = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.LbMatricula = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.LbFechaSal = New NetAgro.Lb(Me.components)
        Me.LbAlbaran = New NetAgro.Lb(Me.components)
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.TxImporte = New NetAgro.TxDato(Me.components)
        Me.LbNomGasto = New NetAgro.Lb(Me.components)
        Me.Lb32 = New NetAgro.Lb(Me.components)
        Me.Lb23 = New NetAgro.Lb(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxNumfac = New NetAgro.TxDato(Me.components)
        Me.LbNumFAc = New NetAgro.Lb(Me.components)
        Me.TxFechaFac = New NetAgro.TxDato(Me.components)
        Me.BtAcreedor = New NetAgro.BtBusca(Me.components)
        Me.LbNomAcreedor = New NetAgro.Lb(Me.components)
        Me.LbAcreedor = New NetAgro.Lb(Me.components)
        Me.TxAcreedor = New NetAgro.TxDato(Me.components)
        Me.LbFechaFac = New NetAgro.Lb(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 426)
        Me.Panel2.TabIndex = 73
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LbAlba)
        Me.GroupBox7.Controls.Add(Me.LbTipo)
        Me.GroupBox7.Controls.Add(Me.Lb2)
        Me.GroupBox7.Controls.Add(Me.LbIgasto)
        Me.GroupBox7.Controls.Add(Me.Lb13)
        Me.GroupBox7.Controls.Add(Me.LbGasto)
        Me.GroupBox7.Controls.Add(Me.LbCliente)
        Me.GroupBox7.Controls.Add(Me.Lb10)
        Me.GroupBox7.Controls.Add(Me.LbReferencia)
        Me.GroupBox7.Controls.Add(Me.Lb8)
        Me.GroupBox7.Controls.Add(Me.LbMatricula)
        Me.GroupBox7.Controls.Add(Me.Lb6)
        Me.GroupBox7.Controls.Add(Me.LbFechaSal)
        Me.GroupBox7.Controls.Add(Me.LbAlbaran)
        Me.GroupBox7.Controls.Add(Me.LbImporte)
        Me.GroupBox7.Controls.Add(Me.TxImporte)
        Me.GroupBox7.Controls.Add(Me.LbNomGasto)
        Me.GroupBox7.Controls.Add(Me.Lb32)
        Me.GroupBox7.Controls.Add(Me.Lb23)
        Me.GroupBox7.Controls.Add(Me.ClGrid2)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1070, 415)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Gastos comerciales"
        '
        'LbAlba
        '
        Me.LbAlba.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbAlba.CL_ControlAsociado = Nothing
        Me.LbAlba.CL_ValorFijo = True
        Me.LbAlba.ClForm = Nothing
        Me.LbAlba.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbAlba.Location = New System.Drawing.Point(99, 16)
        Me.LbAlba.Name = "LbAlba"
        Me.LbAlba.Size = New System.Drawing.Size(92, 23)
        Me.LbAlba.TabIndex = 161
        '
        'LbTipo
        '
        Me.LbTipo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbTipo.CL_ControlAsociado = Nothing
        Me.LbTipo.CL_ValorFijo = True
        Me.LbTipo.ClForm = Nothing
        Me.LbTipo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTipo.Location = New System.Drawing.Point(628, 75)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(32, 23)
        Me.LbTipo.TabIndex = 160
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(525, 78)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(98, 16)
        Me.Lb2.TabIndex = 159
        Me.Lb2.Text = "Tipo K/B/P.."
        '
        'LbIgasto
        '
        Me.LbIgasto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbIgasto.CL_ControlAsociado = Nothing
        Me.LbIgasto.CL_ValorFijo = True
        Me.LbIgasto.ClForm = Nothing
        Me.LbIgasto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIgasto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIgasto.Location = New System.Drawing.Point(893, 45)
        Me.LbIgasto.Name = "LbIgasto"
        Me.LbIgasto.Size = New System.Drawing.Size(133, 23)
        Me.LbIgasto.TabIndex = 158
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(771, 47)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(95, 16)
        Me.Lb13.TabIndex = 157
        Me.Lb13.Text = "Valor actual"
        '
        'LbGasto
        '
        Me.LbGasto.AutoSize = True
        Me.LbGasto.CL_ControlAsociado = Nothing
        Me.LbGasto.CL_ValorFijo = True
        Me.LbGasto.ClForm = Nothing
        Me.LbGasto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGasto.ForeColor = System.Drawing.Color.Teal
        Me.LbGasto.Location = New System.Drawing.Point(12, 79)
        Me.LbGasto.Name = "LbGasto"
        Me.LbGasto.Size = New System.Drawing.Size(50, 16)
        Me.LbGasto.TabIndex = 156
        Me.LbGasto.Text = "Gasto"
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = True
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbCliente.Location = New System.Drawing.Point(99, 45)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(403, 23)
        Me.LbCliente.TabIndex = 155
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(12, 47)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(59, 16)
        Me.Lb10.TabIndex = 154
        Me.Lb10.Text = "Cliente"
        '
        'LbReferencia
        '
        Me.LbReferencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbReferencia.CL_ControlAsociado = Nothing
        Me.LbReferencia.CL_ValorFijo = True
        Me.LbReferencia.ClForm = Nothing
        Me.LbReferencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbReferencia.Location = New System.Drawing.Point(890, 14)
        Me.LbReferencia.Name = "LbReferencia"
        Me.LbReferencia.Size = New System.Drawing.Size(136, 23)
        Me.LbReferencia.TabIndex = 153
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(771, 18)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(85, 16)
        Me.Lb8.TabIndex = 152
        Me.Lb8.Text = "Referencia"
        '
        'LbMatricula
        '
        Me.LbMatricula.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbMatricula.CL_ControlAsociado = Nothing
        Me.LbMatricula.CL_ValorFijo = True
        Me.LbMatricula.ClForm = Nothing
        Me.LbMatricula.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMatricula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbMatricula.Location = New System.Drawing.Point(629, 14)
        Me.LbMatricula.Name = "LbMatricula"
        Me.LbMatricula.Size = New System.Drawing.Size(136, 23)
        Me.LbMatricula.TabIndex = 151
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(525, 18)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(75, 16)
        Me.Lb6.TabIndex = 150
        Me.Lb6.Text = "Matricula"
        '
        'LbFechaSal
        '
        Me.LbFechaSal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbFechaSal.CL_ControlAsociado = Nothing
        Me.LbFechaSal.CL_ValorFijo = True
        Me.LbFechaSal.ClForm = Nothing
        Me.LbFechaSal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaSal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFechaSal.Location = New System.Drawing.Point(366, 16)
        Me.LbFechaSal.Name = "LbFechaSal"
        Me.LbFechaSal.Size = New System.Drawing.Size(136, 23)
        Me.LbFechaSal.TabIndex = 149
        '
        'LbAlbaran
        '
        Me.LbAlbaran.AutoSize = True
        Me.LbAlbaran.CL_ControlAsociado = Nothing
        Me.LbAlbaran.CL_ValorFijo = True
        Me.LbAlbaran.ClForm = Nothing
        Me.LbAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbAlbaran.Location = New System.Drawing.Point(12, 21)
        Me.LbAlbaran.Name = "LbAlbaran"
        Me.LbAlbaran.Size = New System.Drawing.Size(64, 16)
        Me.LbAlbaran.TabIndex = 148
        Me.LbAlbaran.Text = "Albarán"
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.Teal
        Me.LbImporte.Location = New System.Drawing.Point(771, 79)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(103, 16)
        Me.LbImporte.TabIndex = 146
        Me.LbImporte.Text = "Importe Fact"
        '
        'TxImporte
        '
        Me.TxImporte.Autonumerico = False
        Me.TxImporte.Buscando = False
        Me.TxImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxImporte.ClForm = Nothing
        Me.TxImporte.ClParam = Nothing
        Me.TxImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxImporte.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxImporte.GridLin = Nothing
        Me.TxImporte.HaCambiado = False
        Me.TxImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxImporte.lbbusca = Nothing
        Me.TxImporte.Location = New System.Drawing.Point(904, 76)
        Me.TxImporte.MiError = False
        Me.TxImporte.Name = "TxImporte"
        Me.TxImporte.Orden = 0
        Me.TxImporte.SaltoAlfinal = False
        Me.TxImporte.Siguiente = 0
        Me.TxImporte.Size = New System.Drawing.Size(122, 22)
        Me.TxImporte.TabIndex = 145
        Me.TxImporte.TeclaRepetida = False
        Me.TxImporte.TxDatoFinalSemana = Nothing
        Me.TxImporte.TxDatoInicioSemana = Nothing
        Me.TxImporte.UltimoValorValidado = Nothing
        '
        'LbNomGasto
        '
        Me.LbNomGasto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGasto.CL_ControlAsociado = Nothing
        Me.LbNomGasto.CL_ValorFijo = True
        Me.LbNomGasto.ClForm = Nothing
        Me.LbNomGasto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGasto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGasto.Location = New System.Drawing.Point(99, 76)
        Me.LbNomGasto.Name = "LbNomGasto"
        Me.LbNomGasto.Size = New System.Drawing.Size(400, 23)
        Me.LbNomGasto.TabIndex = 131
        '
        'Lb32
        '
        Me.Lb32.AutoSize = True
        Me.Lb32.CL_ControlAsociado = Nothing
        Me.Lb32.CL_ValorFijo = False
        Me.Lb32.ClForm = Nothing
        Me.Lb32.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb32.ForeColor = System.Drawing.Color.Teal
        Me.Lb32.Location = New System.Drawing.Point(251, 20)
        Me.Lb32.Name = "Lb32"
        Me.Lb32.Size = New System.Drawing.Size(99, 16)
        Me.Lb32.TabIndex = 129
        Me.Lb32.Text = "Fecha salida"
        '
        'Lb23
        '
        Me.Lb23.AutoSize = True
        Me.Lb23.CL_ControlAsociado = Nothing
        Me.Lb23.CL_ValorFijo = False
        Me.Lb23.ClForm = Nothing
        Me.Lb23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb23.ForeColor = System.Drawing.Color.Teal
        Me.Lb23.Location = New System.Drawing.Point(-215, 179)
        Me.Lb23.Name = "Lb23"
        Me.Lb23.Size = New System.Drawing.Size(59, 16)
        Me.Lb23.TabIndex = 129
        Me.Lb23.Text = "Cultivo"
        '
        'ClGrid2
        '
        Me.ClGrid2.AñadirLinea = True
        Me.ClGrid2.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.GridEnterAutomatico = False
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.LineaBloqueada = False
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(3, 105)
        Me.ClGrid2.Margin = New System.Windows.Forms.Padding(4)
        Me.ClGrid2.MismaLinea = False
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.OcultarCeros = False
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(1064, 307)
        Me.ClGrid2.TabIndex = 120
        Me.ClGrid2.UltimoControl = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1085, 92)
        Me.Panel4.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxNumfac)
        Me.GroupBox1.Controls.Add(Me.LbNumFAc)
        Me.GroupBox1.Controls.Add(Me.TxFechaFac)
        Me.GroupBox1.Controls.Add(Me.BtAcreedor)
        Me.GroupBox1.Controls.Add(Me.LbNomAcreedor)
        Me.GroupBox1.Controls.Add(Me.LbAcreedor)
        Me.GroupBox1.Controls.Add(Me.TxAcreedor)
        Me.GroupBox1.Controls.Add(Me.LbFechaFac)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 83)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Factura"
        '
        'TxNumfac
        '
        Me.TxNumfac.Autonumerico = False
        Me.TxNumfac.Buscando = False
        Me.TxNumfac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumfac.ClForm = Nothing
        Me.TxNumfac.ClParam = Nothing
        Me.TxNumfac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNumfac.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNumfac.GridLin = Nothing
        Me.TxNumfac.HaCambiado = False
        Me.TxNumfac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNumfac.lbbusca = Nothing
        Me.TxNumfac.Location = New System.Drawing.Point(413, 49)
        Me.TxNumfac.MiError = False
        Me.TxNumfac.Name = "TxNumfac"
        Me.TxNumfac.Orden = 0
        Me.TxNumfac.SaltoAlfinal = False
        Me.TxNumfac.Siguiente = 0
        Me.TxNumfac.Size = New System.Drawing.Size(121, 22)
        Me.TxNumfac.TabIndex = 202
        Me.TxNumfac.TeclaRepetida = False
        Me.TxNumfac.TxDatoFinalSemana = Nothing
        Me.TxNumfac.TxDatoInicioSemana = Nothing
        Me.TxNumfac.UltimoValorValidado = Nothing
        '
        'LbNumFAc
        '
        Me.LbNumFAc.AutoSize = True
        Me.LbNumFAc.CL_ControlAsociado = Nothing
        Me.LbNumFAc.CL_ValorFijo = True
        Me.LbNumFAc.ClForm = Nothing
        Me.LbNumFAc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumFAc.ForeColor = System.Drawing.Color.Teal
        Me.LbNumFAc.Location = New System.Drawing.Point(271, 52)
        Me.LbNumFAc.Name = "LbNumFAc"
        Me.LbNumFAc.Size = New System.Drawing.Size(125, 16)
        Me.LbNumFAc.TabIndex = 201
        Me.LbNumFAc.Text = "Número  factura"
        '
        'TxFechaFac
        '
        Me.TxFechaFac.Autonumerico = False
        Me.TxFechaFac.Buscando = False
        Me.TxFechaFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaFac.ClForm = Nothing
        Me.TxFechaFac.ClParam = Nothing
        Me.TxFechaFac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaFac.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaFac.GridLin = Nothing
        Me.TxFechaFac.HaCambiado = False
        Me.TxFechaFac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaFac.lbbusca = Nothing
        Me.TxFechaFac.Location = New System.Drawing.Point(122, 49)
        Me.TxFechaFac.MiError = False
        Me.TxFechaFac.Name = "TxFechaFac"
        Me.TxFechaFac.Orden = 0
        Me.TxFechaFac.SaltoAlfinal = False
        Me.TxFechaFac.Siguiente = 0
        Me.TxFechaFac.Size = New System.Drawing.Size(121, 22)
        Me.TxFechaFac.TabIndex = 200
        Me.TxFechaFac.TeclaRepetida = False
        Me.TxFechaFac.TxDatoFinalSemana = Nothing
        Me.TxFechaFac.TxDatoInicioSemana = Nothing
        Me.TxFechaFac.UltimoValorValidado = Nothing
        '
        'BtAcreedor
        '
        Me.BtAcreedor.CL_Ancho = 0
        Me.BtAcreedor.CL_BuscaAlb = False
        Me.BtAcreedor.CL_campocodigo = Nothing
        Me.BtAcreedor.CL_camponombre = Nothing
        Me.BtAcreedor.CL_CampoOrden = "Nombre"
        Me.BtAcreedor.CL_ch1000 = False
        Me.BtAcreedor.CL_ConsultaSql = "Select * from familias"
        Me.BtAcreedor.CL_ControlAsociado = Nothing
        Me.BtAcreedor.CL_DevuelveCampo = "Idfamilia"
        Me.BtAcreedor.CL_dfecha = Nothing
        Me.BtAcreedor.CL_Entidad = Nothing
        Me.BtAcreedor.CL_EsId = True
        Me.BtAcreedor.CL_Filtro = Nothing
        Me.BtAcreedor.cl_formu = Nothing
        Me.BtAcreedor.CL_hfecha = Nothing
        Me.BtAcreedor.cl_ListaW = Nothing
        Me.BtAcreedor.CL_xCentro = False
        Me.BtAcreedor.Image = CType(resources.GetObject("BtAcreedor.Image"), System.Drawing.Image)
        Me.BtAcreedor.Location = New System.Drawing.Point(207, 20)
        Me.BtAcreedor.Name = "BtAcreedor"
        Me.BtAcreedor.Size = New System.Drawing.Size(33, 23)
        Me.BtAcreedor.TabIndex = 189
        Me.BtAcreedor.UseVisualStyleBackColor = True
        '
        'LbNomAcreedor
        '
        Me.LbNomAcreedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAcreedor.CL_ControlAsociado = Nothing
        Me.LbNomAcreedor.CL_ValorFijo = True
        Me.LbNomAcreedor.ClForm = Nothing
        Me.LbNomAcreedor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAcreedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAcreedor.Location = New System.Drawing.Point(246, 19)
        Me.LbNomAcreedor.Name = "LbNomAcreedor"
        Me.LbNomAcreedor.Size = New System.Drawing.Size(431, 23)
        Me.LbNomAcreedor.TabIndex = 87
        '
        'LbAcreedor
        '
        Me.LbAcreedor.AutoSize = True
        Me.LbAcreedor.CL_ControlAsociado = Nothing
        Me.LbAcreedor.CL_ValorFijo = False
        Me.LbAcreedor.ClForm = Nothing
        Me.LbAcreedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAcreedor.ForeColor = System.Drawing.Color.Teal
        Me.LbAcreedor.Location = New System.Drawing.Point(8, 23)
        Me.LbAcreedor.Name = "LbAcreedor"
        Me.LbAcreedor.Size = New System.Drawing.Size(74, 16)
        Me.LbAcreedor.TabIndex = 84
        Me.LbAcreedor.Text = "Acreedor"
        '
        'TxAcreedor
        '
        Me.TxAcreedor.Autonumerico = False
        Me.TxAcreedor.Buscando = False
        Me.TxAcreedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAcreedor.ClForm = Nothing
        Me.TxAcreedor.ClParam = Nothing
        Me.TxAcreedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAcreedor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAcreedor.GridLin = Nothing
        Me.TxAcreedor.HaCambiado = False
        Me.TxAcreedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAcreedor.lbbusca = Nothing
        Me.TxAcreedor.Location = New System.Drawing.Point(121, 20)
        Me.TxAcreedor.MiError = False
        Me.TxAcreedor.Name = "TxAcreedor"
        Me.TxAcreedor.Orden = 0
        Me.TxAcreedor.SaltoAlfinal = False
        Me.TxAcreedor.Siguiente = 0
        Me.TxAcreedor.Size = New System.Drawing.Size(80, 22)
        Me.TxAcreedor.TabIndex = 83
        Me.TxAcreedor.TeclaRepetida = False
        Me.TxAcreedor.TxDatoFinalSemana = Nothing
        Me.TxAcreedor.TxDatoInicioSemana = Nothing
        Me.TxAcreedor.UltimoValorValidado = Nothing
        '
        'LbFechaFac
        '
        Me.LbFechaFac.AutoSize = True
        Me.LbFechaFac.CL_ControlAsociado = Nothing
        Me.LbFechaFac.CL_ValorFijo = True
        Me.LbFechaFac.ClForm = Nothing
        Me.LbFechaFac.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaFac.ForeColor = System.Drawing.Color.Teal
        Me.LbFechaFac.Location = New System.Drawing.Point(8, 52)
        Me.LbFechaFac.Name = "LbFechaFac"
        Me.LbFechaFac.Size = New System.Drawing.Size(108, 16)
        Me.LbFechaFac.TabIndex = 79
        Me.LbFechaFac.Text = "Fecha factura"
        '
        'FrmGasComerSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 585)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGasComerSalidas"
        Me.Text = "Gastos comerciales albaran salida"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents TxImporte As NetAgro.TxDato
    Friend WithEvents LbNomGasto As NetAgro.Lb
    Friend WithEvents Lb32 As NetAgro.Lb
    Friend WithEvents Lb23 As NetAgro.Lb
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtAcreedor As NetAgro.BtBusca
    Friend WithEvents LbNomAcreedor As NetAgro.Lb
    Friend WithEvents LbAcreedor As NetAgro.Lb
    Friend WithEvents TxAcreedor As NetAgro.TxDato
    Friend WithEvents LbFechaFac As NetAgro.Lb
    Friend WithEvents LbIgasto As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents LbGasto As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbReferencia As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents LbMatricula As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents LbFechaSal As NetAgro.Lb
    Friend WithEvents LbAlbaran As NetAgro.Lb
    Friend WithEvents TxNumfac As NetAgro.TxDato
    Friend WithEvents LbNumFAc As NetAgro.Lb
    Friend WithEvents TxFechaFac As NetAgro.TxDato
    Friend WithEvents LbTipo As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents LbAlba As NetAgro.Lb

End Class
