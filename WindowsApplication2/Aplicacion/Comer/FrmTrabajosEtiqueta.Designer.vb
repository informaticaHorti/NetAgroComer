<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrabajosEtiqueta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrabajosEtiqueta))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbPventa = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbMarcaMaterial = New NetAgro.Lb(Me.components)
        Me.Lb22 = New NetAgro.Lb(Me.components)
        Me.LbMarcaEtiquetaCesta = New NetAgro.Lb(Me.components)
        Me.LbEtiquetaCaja = New NetAgro.Lb(Me.components)
        Me.Lb16 = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.LbEtiquetaCesta = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.LbLote = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.LbPiezas = New NetAgro.Lb(Me.components)
        Me.Lb21 = New NetAgro.Lb(Me.components)
        Me.LbBultos = New NetAgro.Lb(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.LbPalets = New NetAgro.Lb(Me.components)
        Me.Lb17 = New NetAgro.Lb(Me.components)
        Me.LbMarca = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.LbCategoria = New NetAgro.Lb(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.LbConfeccion = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.LbPresentacion = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.LbReferencia = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.LbCliente = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lbpedido = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.PanelEstado = New System.Windows.Forms.GroupBox()
        Me.RbFinalizada = New System.Windows.Forms.RadioButton()
        Me.RbPteImprimir = New System.Windows.Forms.RadioButton()
        Me.RbPteConf = New System.Windows.Forms.RadioButton()
        Me.RbPteEnvioMuestra = New System.Windows.Forms.RadioButton()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btMensajes = New System.Windows.Forms.Button()
        Me.btEnvioMuestra = New System.Windows.Forms.Button()
        Me.BtVerPedido = New System.Windows.Forms.Button()
        Me.BtMuestra = New System.Windows.Forms.Button()
        Me.BtVerEtiqueta = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.rbFiltroTodos = New System.Windows.Forms.RadioButton()
        Me.rbFiltroFinalizada = New System.Windows.Forms.RadioButton()
        Me.rbFiltroPteImprimir = New System.Windows.Forms.RadioButton()
        Me.rbFiltroPteConfCliente = New System.Windows.Forms.RadioButton()
        Me.rbFiltroPteEnvioMuestra = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEstado.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.CbPventa)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.PictureBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Size = New System.Drawing.Size(1079, 76)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 82)
        Me.PanelConsulta.Size = New System.Drawing.Size(1079, 284)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(779, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(854, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(929, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1004, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(704, 0)
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
        Me.TxDato1.Location = New System.Drawing.Point(116, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(102, 22)
        Me.TxDato1.TabIndex = 81
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.TxDatoFinalSemana = Nothing
        Me.TxDato1.TxDatoInicioSemana = Nothing
        Me.TxDato1.UltimoValorValidado = Nothing
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
        Me.Lb1.Size = New System.Drawing.Size(100, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Fecha Salida"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(727, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100274
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CbPventa
        '
        Me.CbPventa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPventa.EditValue = ""
        Me.CbPventa.Location = New System.Drawing.Point(820, 14)
        Me.CbPventa.Name = "CbPventa"
        Me.CbPventa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPventa.Size = New System.Drawing.Size(240, 20)
        Me.CbPventa.TabIndex = 100314
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
        Me.Lb5.Location = New System.Drawing.Point(749, 16)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(65, 16)
        Me.Lb5.TabIndex = 100313
        Me.Lb5.Text = "P.Venta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbMarcaMaterial)
        Me.GroupBox1.Controls.Add(Me.Lb22)
        Me.GroupBox1.Controls.Add(Me.LbMarcaEtiquetaCesta)
        Me.GroupBox1.Controls.Add(Me.LbEtiquetaCaja)
        Me.GroupBox1.Controls.Add(Me.Lb16)
        Me.GroupBox1.Controls.Add(Me.Lb12)
        Me.GroupBox1.Controls.Add(Me.LbEtiquetaCesta)
        Me.GroupBox1.Controls.Add(Me.Lb10)
        Me.GroupBox1.Controls.Add(Me.LbLote)
        Me.GroupBox1.Controls.Add(Me.Lb8)
        Me.GroupBox1.Controls.Add(Me.LbPiezas)
        Me.GroupBox1.Controls.Add(Me.Lb21)
        Me.GroupBox1.Controls.Add(Me.LbBultos)
        Me.GroupBox1.Controls.Add(Me.Lb19)
        Me.GroupBox1.Controls.Add(Me.LbPalets)
        Me.GroupBox1.Controls.Add(Me.Lb17)
        Me.GroupBox1.Controls.Add(Me.LbMarca)
        Me.GroupBox1.Controls.Add(Me.Lb15)
        Me.GroupBox1.Controls.Add(Me.LbCategoria)
        Me.GroupBox1.Controls.Add(Me.Lb13)
        Me.GroupBox1.Controls.Add(Me.LbConfeccion)
        Me.GroupBox1.Controls.Add(Me.Lb11)
        Me.GroupBox1.Controls.Add(Me.LbPresentacion)
        Me.GroupBox1.Controls.Add(Me.Lb7)
        Me.GroupBox1.Controls.Add(Me.LbReferencia)
        Me.GroupBox1.Controls.Add(Me.Lb9)
        Me.GroupBox1.Controls.Add(Me.LbCliente)
        Me.GroupBox1.Controls.Add(Me.Lb4)
        Me.GroupBox1.Controls.Add(Me.Lbpedido)
        Me.GroupBox1.Controls.Add(Me.Lb2)
        Me.GroupBox1.Controls.Add(Me.PanelEstado)
        Me.GroupBox1.Controls.Add(Me.PanelBotones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 372)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1079, 189)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos etiqueta"
        '
        'LbMarcaMaterial
        '
        Me.LbMarcaMaterial.BackColor = System.Drawing.Color.White
        Me.LbMarcaMaterial.CL_ControlAsociado = Nothing
        Me.LbMarcaMaterial.CL_ValorFijo = False
        Me.LbMarcaMaterial.ClForm = Nothing
        Me.LbMarcaMaterial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaMaterial.ForeColor = System.Drawing.Color.Blue
        Me.LbMarcaMaterial.Location = New System.Drawing.Point(538, 152)
        Me.LbMarcaMaterial.Name = "LbMarcaMaterial"
        Me.LbMarcaMaterial.Size = New System.Drawing.Size(271, 22)
        Me.LbMarcaMaterial.TabIndex = 136
        '
        'Lb22
        '
        Me.Lb22.AutoSize = True
        Me.Lb22.CL_ControlAsociado = Nothing
        Me.Lb22.CL_ValorFijo = True
        Me.Lb22.ClForm = Nothing
        Me.Lb22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb22.ForeColor = System.Drawing.Color.Teal
        Me.Lb22.Location = New System.Drawing.Point(445, 155)
        Me.Lb22.Name = "Lb22"
        Me.Lb22.Size = New System.Drawing.Size(88, 16)
        Me.Lb22.TabIndex = 135
        Me.Lb22.Text = "Marca Mat."
        '
        'LbMarcaEtiquetaCesta
        '
        Me.LbMarcaEtiquetaCesta.BackColor = System.Drawing.Color.White
        Me.LbMarcaEtiquetaCesta.CL_ControlAsociado = Nothing
        Me.LbMarcaEtiquetaCesta.CL_ValorFijo = False
        Me.LbMarcaEtiquetaCesta.ClForm = Nothing
        Me.LbMarcaEtiquetaCesta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarcaEtiquetaCesta.ForeColor = System.Drawing.Color.Blue
        Me.LbMarcaEtiquetaCesta.Location = New System.Drawing.Point(138, 152)
        Me.LbMarcaEtiquetaCesta.Name = "LbMarcaEtiquetaCesta"
        Me.LbMarcaEtiquetaCesta.Size = New System.Drawing.Size(271, 22)
        Me.LbMarcaEtiquetaCesta.TabIndex = 134
        '
        'LbEtiquetaCaja
        '
        Me.LbEtiquetaCaja.BackColor = System.Drawing.Color.White
        Me.LbEtiquetaCaja.CL_ControlAsociado = Nothing
        Me.LbEtiquetaCaja.CL_ValorFijo = False
        Me.LbEtiquetaCaja.ClForm = Nothing
        Me.LbEtiquetaCaja.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEtiquetaCaja.ForeColor = System.Drawing.Color.Blue
        Me.LbEtiquetaCaja.Location = New System.Drawing.Point(501, 126)
        Me.LbEtiquetaCaja.Name = "LbEtiquetaCaja"
        Me.LbEtiquetaCaja.Size = New System.Drawing.Size(308, 22)
        Me.LbEtiquetaCaja.TabIndex = 133
        '
        'Lb16
        '
        Me.Lb16.AutoSize = True
        Me.Lb16.CL_ControlAsociado = Nothing
        Me.Lb16.CL_ValorFijo = True
        Me.Lb16.ClForm = Nothing
        Me.Lb16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb16.ForeColor = System.Drawing.Color.Teal
        Me.Lb16.Location = New System.Drawing.Point(417, 129)
        Me.Lb16.Name = "Lb16"
        Me.Lb16.Size = New System.Drawing.Size(78, 16)
        Me.Lb16.TabIndex = 132
        Me.Lb16.Text = "Etiq. Caja"
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.ForeColor = System.Drawing.Color.Teal
        Me.Lb12.Location = New System.Drawing.Point(10, 155)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(122, 16)
        Me.Lb12.TabIndex = 131
        Me.Lb12.Text = "Marca Et. Cesta"
        '
        'LbEtiquetaCesta
        '
        Me.LbEtiquetaCesta.BackColor = System.Drawing.Color.White
        Me.LbEtiquetaCesta.CL_ControlAsociado = Nothing
        Me.LbEtiquetaCesta.CL_ValorFijo = False
        Me.LbEtiquetaCesta.ClForm = Nothing
        Me.LbEtiquetaCesta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEtiquetaCesta.ForeColor = System.Drawing.Color.Blue
        Me.LbEtiquetaCesta.Location = New System.Drawing.Point(101, 126)
        Me.LbEtiquetaCesta.Name = "LbEtiquetaCesta"
        Me.LbEtiquetaCesta.Size = New System.Drawing.Size(308, 22)
        Me.LbEtiquetaCesta.TabIndex = 130
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = True
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.ForeColor = System.Drawing.Color.Teal
        Me.Lb10.Location = New System.Drawing.Point(10, 129)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(87, 16)
        Me.Lb10.TabIndex = 129
        Me.Lb10.Text = "Etiq. Cesta"
        '
        'LbLote
        '
        Me.LbLote.BackColor = System.Drawing.Color.White
        Me.LbLote.CL_ControlAsociado = Nothing
        Me.LbLote.CL_ValorFijo = False
        Me.LbLote.ClForm = Nothing
        Me.LbLote.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.ForeColor = System.Drawing.Color.Blue
        Me.LbLote.Location = New System.Drawing.Point(596, 22)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(213, 22)
        Me.LbLote.TabIndex = 128
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = True
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(549, 25)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(40, 16)
        Me.Lb8.TabIndex = 127
        Me.Lb8.Text = "Lote"
        '
        'LbPiezas
        '
        Me.LbPiezas.BackColor = System.Drawing.Color.White
        Me.LbPiezas.CL_ControlAsociado = Nothing
        Me.LbPiezas.CL_ValorFijo = False
        Me.LbPiezas.ClForm = Nothing
        Me.LbPiezas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPiezas.ForeColor = System.Drawing.Color.Blue
        Me.LbPiezas.Location = New System.Drawing.Point(635, 100)
        Me.LbPiezas.Name = "LbPiezas"
        Me.LbPiezas.Size = New System.Drawing.Size(63, 22)
        Me.LbPiezas.TabIndex = 123
        '
        'Lb21
        '
        Me.Lb21.AutoSize = True
        Me.Lb21.CL_ControlAsociado = Nothing
        Me.Lb21.CL_ValorFijo = True
        Me.Lb21.ClForm = Nothing
        Me.Lb21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb21.ForeColor = System.Drawing.Color.Teal
        Me.Lb21.Location = New System.Drawing.Point(576, 103)
        Me.Lb21.Name = "Lb21"
        Me.Lb21.Size = New System.Drawing.Size(55, 16)
        Me.Lb21.TabIndex = 122
        Me.Lb21.Text = "Piezas"
        '
        'LbBultos
        '
        Me.LbBultos.BackColor = System.Drawing.Color.White
        Me.LbBultos.CL_ControlAsociado = Nothing
        Me.LbBultos.CL_ValorFijo = False
        Me.LbBultos.ClForm = Nothing
        Me.LbBultos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBultos.ForeColor = System.Drawing.Color.Blue
        Me.LbBultos.Location = New System.Drawing.Point(501, 100)
        Me.LbBultos.Name = "LbBultos"
        Me.LbBultos.Size = New System.Drawing.Size(63, 22)
        Me.LbBultos.TabIndex = 121
        '
        'Lb19
        '
        Me.Lb19.AutoSize = True
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = True
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.Teal
        Me.Lb19.Location = New System.Drawing.Point(441, 103)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(54, 16)
        Me.Lb19.TabIndex = 120
        Me.Lb19.Text = "Bultos"
        '
        'LbPalets
        '
        Me.LbPalets.BackColor = System.Drawing.Color.White
        Me.LbPalets.CL_ControlAsociado = Nothing
        Me.LbPalets.CL_ValorFijo = False
        Me.LbPalets.ClForm = Nothing
        Me.LbPalets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPalets.ForeColor = System.Drawing.Color.Blue
        Me.LbPalets.Location = New System.Drawing.Point(346, 100)
        Me.LbPalets.Name = "LbPalets"
        Me.LbPalets.Size = New System.Drawing.Size(63, 22)
        Me.LbPalets.TabIndex = 119
        '
        'Lb17
        '
        Me.Lb17.AutoSize = True
        Me.Lb17.CL_ControlAsociado = Nothing
        Me.Lb17.CL_ValorFijo = True
        Me.Lb17.ClForm = Nothing
        Me.Lb17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb17.ForeColor = System.Drawing.Color.Teal
        Me.Lb17.Location = New System.Drawing.Point(287, 103)
        Me.Lb17.Name = "Lb17"
        Me.Lb17.Size = New System.Drawing.Size(53, 16)
        Me.Lb17.TabIndex = 118
        Me.Lb17.Text = "Palets"
        '
        'LbMarca
        '
        Me.LbMarca.BackColor = System.Drawing.Color.White
        Me.LbMarca.CL_ControlAsociado = Nothing
        Me.LbMarca.CL_ValorFijo = False
        Me.LbMarca.ClForm = Nothing
        Me.LbMarca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarca.ForeColor = System.Drawing.Color.Blue
        Me.LbMarca.Location = New System.Drawing.Point(101, 100)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.Size = New System.Drawing.Size(154, 22)
        Me.LbMarca.TabIndex = 117
        '
        'Lb15
        '
        Me.Lb15.AutoSize = True
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = True
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.ForeColor = System.Drawing.Color.Teal
        Me.Lb15.Location = New System.Drawing.Point(10, 103)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(52, 16)
        Me.Lb15.TabIndex = 116
        Me.Lb15.Text = "Marca"
        '
        'LbCategoria
        '
        Me.LbCategoria.BackColor = System.Drawing.Color.White
        Me.LbCategoria.CL_ControlAsociado = Nothing
        Me.LbCategoria.CL_ValorFijo = False
        Me.LbCategoria.ClForm = Nothing
        Me.LbCategoria.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCategoria.ForeColor = System.Drawing.Color.Blue
        Me.LbCategoria.Location = New System.Drawing.Point(635, 74)
        Me.LbCategoria.Name = "LbCategoria"
        Me.LbCategoria.Size = New System.Drawing.Size(174, 22)
        Me.LbCategoria.TabIndex = 115
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = True
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(535, 77)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(79, 16)
        Me.Lb13.TabIndex = 114
        Me.Lb13.Text = "Categoria"
        '
        'LbConfeccion
        '
        Me.LbConfeccion.BackColor = System.Drawing.Color.White
        Me.LbConfeccion.CL_ControlAsociado = Nothing
        Me.LbConfeccion.CL_ValorFijo = False
        Me.LbConfeccion.ClForm = Nothing
        Me.LbConfeccion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConfeccion.ForeColor = System.Drawing.Color.Blue
        Me.LbConfeccion.Location = New System.Drawing.Point(101, 74)
        Me.LbConfeccion.Name = "LbConfeccion"
        Me.LbConfeccion.Size = New System.Drawing.Size(396, 22)
        Me.LbConfeccion.TabIndex = 113
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = True
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.Teal
        Me.Lb11.Location = New System.Drawing.Point(10, 77)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(88, 16)
        Me.Lb11.TabIndex = 112
        Me.Lb11.Text = "Confección"
        '
        'LbPresentacion
        '
        Me.LbPresentacion.BackColor = System.Drawing.Color.White
        Me.LbPresentacion.CL_ControlAsociado = Nothing
        Me.LbPresentacion.CL_ValorFijo = False
        Me.LbPresentacion.ClForm = Nothing
        Me.LbPresentacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPresentacion.ForeColor = System.Drawing.Color.Blue
        Me.LbPresentacion.Location = New System.Drawing.Point(346, 48)
        Me.LbPresentacion.Name = "LbPresentacion"
        Me.LbPresentacion.Size = New System.Drawing.Size(463, 22)
        Me.LbPresentacion.TabIndex = 111
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = True
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(271, 51)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(69, 16)
        Me.Lb7.TabIndex = 110
        Me.Lb7.Text = "Present."
        '
        'LbReferencia
        '
        Me.LbReferencia.BackColor = System.Drawing.Color.White
        Me.LbReferencia.CL_ControlAsociado = Nothing
        Me.LbReferencia.CL_ValorFijo = False
        Me.LbReferencia.ClForm = Nothing
        Me.LbReferencia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbReferencia.ForeColor = System.Drawing.Color.Blue
        Me.LbReferencia.Location = New System.Drawing.Point(101, 48)
        Me.LbReferencia.Name = "LbReferencia"
        Me.LbReferencia.Size = New System.Drawing.Size(154, 22)
        Me.LbReferencia.TabIndex = 109
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = True
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(10, 51)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(85, 16)
        Me.Lb9.TabIndex = 108
        Me.Lb9.Text = "Referencia"
        '
        'LbCliente
        '
        Me.LbCliente.BackColor = System.Drawing.Color.White
        Me.LbCliente.CL_ControlAsociado = Nothing
        Me.LbCliente.CL_ValorFijo = False
        Me.LbCliente.ClForm = Nothing
        Me.LbCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Blue
        Me.LbCliente.Location = New System.Drawing.Point(263, 22)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(270, 22)
        Me.LbCliente.TabIndex = 107
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(198, 25)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(59, 16)
        Me.Lb4.TabIndex = 106
        Me.Lb4.Text = "Cliente"
        '
        'Lbpedido
        '
        Me.Lbpedido.BackColor = System.Drawing.Color.White
        Me.Lbpedido.CL_ControlAsociado = Nothing
        Me.Lbpedido.CL_ValorFijo = False
        Me.Lbpedido.ClForm = Nothing
        Me.Lbpedido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbpedido.ForeColor = System.Drawing.Color.Blue
        Me.Lbpedido.Location = New System.Drawing.Point(101, 22)
        Me.Lbpedido.Name = "Lbpedido"
        Me.Lbpedido.Size = New System.Drawing.Size(85, 22)
        Me.Lbpedido.TabIndex = 105
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(10, 25)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(57, 16)
        Me.Lb2.TabIndex = 104
        Me.Lb2.Text = "Pedido"
        '
        'PanelEstado
        '
        Me.PanelEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEstado.Controls.Add(Me.RbFinalizada)
        Me.PanelEstado.Controls.Add(Me.RbPteImprimir)
        Me.PanelEstado.Controls.Add(Me.RbPteConf)
        Me.PanelEstado.Controls.Add(Me.RbPteEnvioMuestra)
        Me.PanelEstado.Location = New System.Drawing.Point(820, 16)
        Me.PanelEstado.Name = "PanelEstado"
        Me.PanelEstado.Size = New System.Drawing.Size(166, 154)
        Me.PanelEstado.TabIndex = 87
        Me.PanelEstado.TabStop = False
        Me.PanelEstado.Text = "Estado"
        '
        'RbFinalizada
        '
        Me.RbFinalizada.AutoSize = True
        Me.RbFinalizada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFinalizada.Location = New System.Drawing.Point(9, 113)
        Me.RbFinalizada.Name = "RbFinalizada"
        Me.RbFinalizada.Size = New System.Drawing.Size(105, 20)
        Me.RbFinalizada.TabIndex = 90
        Me.RbFinalizada.TabStop = True
        Me.RbFinalizada.Text = "FINALIZADA"
        Me.RbFinalizada.UseVisualStyleBackColor = True
        '
        'RbPteImprimir
        '
        Me.RbPteImprimir.AutoSize = True
        Me.RbPteImprimir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPteImprimir.Location = New System.Drawing.Point(9, 84)
        Me.RbPteImprimir.Name = "RbPteImprimir"
        Me.RbPteImprimir.Size = New System.Drawing.Size(104, 20)
        Me.RbPteImprimir.TabIndex = 89
        Me.RbPteImprimir.TabStop = True
        Me.RbPteImprimir.Text = "Pte Imprimir"
        Me.RbPteImprimir.UseVisualStyleBackColor = True
        '
        'RbPteConf
        '
        Me.RbPteConf.AutoSize = True
        Me.RbPteConf.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPteConf.Location = New System.Drawing.Point(9, 55)
        Me.RbPteConf.Name = "RbPteConf"
        Me.RbPteConf.Size = New System.Drawing.Size(138, 20)
        Me.RbPteConf.TabIndex = 88
        Me.RbPteConf.TabStop = True
        Me.RbPteConf.Text = "Pte Conf. Cliente"
        Me.RbPteConf.UseVisualStyleBackColor = True
        '
        'RbPteEnvioMuestra
        '
        Me.RbPteEnvioMuestra.AutoSize = True
        Me.RbPteEnvioMuestra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPteEnvioMuestra.Location = New System.Drawing.Point(9, 26)
        Me.RbPteEnvioMuestra.Name = "RbPteEnvioMuestra"
        Me.RbPteEnvioMuestra.Size = New System.Drawing.Size(146, 20)
        Me.RbPteEnvioMuestra.TabIndex = 87
        Me.RbPteEnvioMuestra.TabStop = True
        Me.RbPteEnvioMuestra.Text = "Pte Envío Muestra"
        Me.RbPteEnvioMuestra.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.btMensajes)
        Me.PanelBotones.Controls.Add(Me.btEnvioMuestra)
        Me.PanelBotones.Controls.Add(Me.BtVerPedido)
        Me.PanelBotones.Controls.Add(Me.BtMuestra)
        Me.PanelBotones.Controls.Add(Me.BtVerEtiqueta)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBotones.Location = New System.Drawing.Point(992, 16)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(84, 170)
        Me.PanelBotones.TabIndex = 86
        '
        'btMensajes
        '
        Me.btMensajes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btMensajes.Location = New System.Drawing.Point(0, 112)
        Me.btMensajes.Name = "btMensajes"
        Me.btMensajes.Size = New System.Drawing.Size(84, 28)
        Me.btMensajes.TabIndex = 87
        Me.btMensajes.Text = "Mensajes"
        Me.btMensajes.UseVisualStyleBackColor = True
        '
        'btEnvioMuestra
        '
        Me.btEnvioMuestra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btEnvioMuestra.Location = New System.Drawing.Point(0, 84)
        Me.btEnvioMuestra.Name = "btEnvioMuestra"
        Me.btEnvioMuestra.Size = New System.Drawing.Size(84, 28)
        Me.btEnvioMuestra.TabIndex = 86
        Me.btEnvioMuestra.Text = "Envio muestra"
        Me.btEnvioMuestra.UseVisualStyleBackColor = True
        '
        'BtVerPedido
        '
        Me.BtVerPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtVerPedido.Location = New System.Drawing.Point(0, 56)
        Me.BtVerPedido.Name = "BtVerPedido"
        Me.BtVerPedido.Size = New System.Drawing.Size(84, 28)
        Me.BtVerPedido.TabIndex = 83
        Me.BtVerPedido.Text = "Ver pedido"
        Me.BtVerPedido.UseVisualStyleBackColor = True
        '
        'BtMuestra
        '
        Me.BtMuestra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtMuestra.Location = New System.Drawing.Point(0, 28)
        Me.BtMuestra.Name = "BtMuestra"
        Me.BtMuestra.Size = New System.Drawing.Size(84, 28)
        Me.BtMuestra.TabIndex = 85
        Me.BtMuestra.Text = "Muestra"
        Me.BtMuestra.UseVisualStyleBackColor = True
        '
        'BtVerEtiqueta
        '
        Me.BtVerEtiqueta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtVerEtiqueta.Location = New System.Drawing.Point(0, 0)
        Me.BtVerEtiqueta.Name = "BtVerEtiqueta"
        Me.BtVerEtiqueta.Size = New System.Drawing.Size(84, 28)
        Me.BtVerEtiqueta.TabIndex = 84
        Me.BtVerEtiqueta.Text = "Etiq.Cliente"
        Me.BtVerEtiqueta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Lb3)
        Me.GroupBox2.Controls.Add(Me.rbFiltroTodos)
        Me.GroupBox2.Controls.Add(Me.rbFiltroFinalizada)
        Me.GroupBox2.Controls.Add(Me.rbFiltroPteImprimir)
        Me.GroupBox2.Controls.Add(Me.rbFiltroPteConfCliente)
        Me.GroupBox2.Controls.Add(Me.rbFiltroPteEnvioMuestra)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(359, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 45)
        Me.GroupBox2.TabIndex = 100315
        Me.GroupBox2.TabStop = False
        '
        'Lb3
        '
        Me.Lb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(9, 0)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(134, 16)
        Me.Lb3.TabIndex = 100316
        Me.Lb3.Text = "Filtrar por estado"
        '
        'rbFiltroTodos
        '
        Me.rbFiltroTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFiltroTodos.AutoSize = True
        Me.rbFiltroTodos.Checked = True
        Me.rbFiltroTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFiltroTodos.Location = New System.Drawing.Point(599, 18)
        Me.rbFiltroTodos.Name = "rbFiltroTodos"
        Me.rbFiltroTodos.Size = New System.Drawing.Size(75, 20)
        Me.rbFiltroTodos.TabIndex = 92
        Me.rbFiltroTodos.TabStop = True
        Me.rbFiltroTodos.Text = "TODOS"
        Me.rbFiltroTodos.UseVisualStyleBackColor = True
        '
        'rbFiltroFinalizada
        '
        Me.rbFiltroFinalizada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFiltroFinalizada.AutoSize = True
        Me.rbFiltroFinalizada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFiltroFinalizada.Location = New System.Drawing.Point(474, 18)
        Me.rbFiltroFinalizada.Name = "rbFiltroFinalizada"
        Me.rbFiltroFinalizada.Size = New System.Drawing.Size(114, 20)
        Me.rbFiltroFinalizada.TabIndex = 91
        Me.rbFiltroFinalizada.Text = "FINALIZADA"
        Me.rbFiltroFinalizada.UseVisualStyleBackColor = True
        '
        'rbFiltroPteImprimir
        '
        Me.rbFiltroPteImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFiltroPteImprimir.AutoSize = True
        Me.rbFiltroPteImprimir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFiltroPteImprimir.Location = New System.Drawing.Point(346, 18)
        Me.rbFiltroPteImprimir.Name = "rbFiltroPteImprimir"
        Me.rbFiltroPteImprimir.Size = New System.Drawing.Size(117, 20)
        Me.rbFiltroPteImprimir.TabIndex = 90
        Me.rbFiltroPteImprimir.Text = "Pte Imprimir"
        Me.rbFiltroPteImprimir.UseVisualStyleBackColor = True
        '
        'rbFiltroPteConfCliente
        '
        Me.rbFiltroPteConfCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFiltroPteConfCliente.AutoSize = True
        Me.rbFiltroPteConfCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFiltroPteConfCliente.Location = New System.Drawing.Point(188, 18)
        Me.rbFiltroPteConfCliente.Name = "rbFiltroPteConfCliente"
        Me.rbFiltroPteConfCliente.Size = New System.Drawing.Size(141, 20)
        Me.rbFiltroPteConfCliente.TabIndex = 89
        Me.rbFiltroPteConfCliente.Text = "Pte conf.Cliente"
        Me.rbFiltroPteConfCliente.UseVisualStyleBackColor = True
        '
        'rbFiltroPteEnvioMuestra
        '
        Me.rbFiltroPteEnvioMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFiltroPteEnvioMuestra.AutoSize = True
        Me.rbFiltroPteEnvioMuestra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFiltroPteEnvioMuestra.Location = New System.Drawing.Point(12, 18)
        Me.rbFiltroPteEnvioMuestra.Name = "rbFiltroPteEnvioMuestra"
        Me.rbFiltroPteEnvioMuestra.Size = New System.Drawing.Size(159, 20)
        Me.rbFiltroPteEnvioMuestra.TabIndex = 88
        Me.rbFiltroPteEnvioMuestra.Text = "Pte envio muestra"
        Me.rbFiltroPteEnvioMuestra.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 120000
        '
        'FrmTrabajosEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTrabajosEtiqueta"
        Me.Text = "Trabajos etiquetas"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbPventa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEstado.ResumeLayout(False)
        Me.PanelEstado.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CbPventa As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEstado As System.Windows.Forms.GroupBox
    Friend WithEvents RbFinalizada As System.Windows.Forms.RadioButton
    Friend WithEvents RbPteImprimir As System.Windows.Forms.RadioButton
    Friend WithEvents RbPteConf As System.Windows.Forms.RadioButton
    Friend WithEvents RbPteEnvioMuestra As System.Windows.Forms.RadioButton
    Friend WithEvents PanelBotones As System.Windows.Forms.Panel
    Friend WithEvents btEnvioMuestra As System.Windows.Forms.Button
    Friend WithEvents BtVerPedido As System.Windows.Forms.Button
    Friend WithEvents BtMuestra As System.Windows.Forms.Button
    Friend WithEvents BtVerEtiqueta As System.Windows.Forms.Button
    Friend WithEvents btMensajes As System.Windows.Forms.Button
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFiltroTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroFinalizada As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroPteImprimir As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroPteConfCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroPteEnvioMuestra As System.Windows.Forms.RadioButton
    Friend WithEvents LbLote As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents LbPiezas As NetAgro.Lb
    Friend WithEvents Lb21 As NetAgro.Lb
    Friend WithEvents LbBultos As NetAgro.Lb
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents LbPalets As NetAgro.Lb
    Friend WithEvents Lb17 As NetAgro.Lb
    Friend WithEvents LbMarca As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Friend WithEvents LbCategoria As NetAgro.Lb
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents LbConfeccion As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents LbPresentacion As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents LbReferencia As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents LbCliente As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lbpedido As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents LbEtiquetaCesta As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbEtiquetaCaja As NetAgro.Lb
    Friend WithEvents Lb16 As NetAgro.Lb
    Friend WithEvents LbMarcaMaterial As NetAgro.Lb
    Friend WithEvents Lb22 As NetAgro.Lb
    Friend WithEvents LbMarcaEtiquetaCesta As NetAgro.Lb
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
