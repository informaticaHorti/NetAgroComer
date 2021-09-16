<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrClientesNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrClientesNew))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.CbBoxSN = New NetAgro.CbBox(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbBox1 = New NetAgro.CbBox(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.LbImporte = New NetAgro.Lb(Me.components)
        Me.Lb12 = New NetAgro.Lb(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.BotonesAvance1)
        Me.Panel2.Controls.Add(Me.BtBuscaCliente)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 64)
        Me.Panel2.TabIndex = 4
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.Location = New System.Drawing.Point(12, 36)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(63, 16)
        Me.Lb2.TabIndex = 25
        Me.Lb2.Text = "Nombre"
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
        Me.TxDato2.Location = New System.Drawing.Point(87, 34)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(425, 22)
        Me.TxDato2.TabIndex = 24
        Me.TxDato2.TeclaRepetida = False
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(195, 4)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 20
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_campocodigo = Nothing
        Me.BtBuscaCliente.CL_camponombre = Nothing
        Me.BtBuscaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaCliente.CL_ch1000 = False
        Me.BtBuscaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCliente.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCliente.CL_dfecha = Nothing
        Me.BtBuscaCliente.CL_Entidad = Nothing
        Me.BtBuscaCliente.CL_EsId = True
        Me.BtBuscaCliente.CL_Filtro = Nothing
        Me.BtBuscaCliente.cl_formu = Nothing
        Me.BtBuscaCliente.CL_hfecha = Nothing
        Me.BtBuscaCliente.cl_ListaW = Nothing
        Me.BtBuscaCliente.CL_xCentro = False
        Me.BtBuscaCliente.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCliente.Location = New System.Drawing.Point(156, 5)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 23
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(87, 5)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 21
        Me.TxDato1.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(12, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 22
        Me.Lb1.Text = "Código"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 64)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(776, 352)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Silver
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Lb8)
        Me.XtraTabPage1.Controls.Add(Me.CbBoxSN)
        Me.XtraTabPage1.Controls.Add(Me.Lb5)
        Me.XtraTabPage1.Controls.Add(Me.CbBox1)
        Me.XtraTabPage1.Controls.Add(Me.TxDato3)
        Me.XtraTabPage1.Controls.Add(Me.Lb3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(770, 326)
        Me.XtraTabPage1.Text = "Datos postales"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.Location = New System.Drawing.Point(29, 65)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(81, 16)
        Me.Lb8.TabIndex = 33
        Me.Lb8.Text = "Activo S/N"
        '
        'CbBoxSN
        '
        Me.CbBoxSN.Campobd = Nothing
        Me.CbBoxSN.ClForm = Nothing
        Me.CbBoxSN.FormattingEnabled = True
        Me.CbBoxSN.GridLin = Nothing
        Me.CbBoxSN.Location = New System.Drawing.Point(116, 64)
        Me.CbBoxSN.MiEntidad = Nothing
        Me.CbBoxSN.MiError = False
        Me.CbBoxSN.Name = "CbBoxSN"
        Me.CbBoxSN.Orden = 0
        Me.CbBoxSN.SaltoAlfinal = False
        Me.CbBoxSN.Size = New System.Drawing.Size(47, 21)
        Me.CbBoxSN.TabIndex = 32
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.Location = New System.Drawing.Point(29, 143)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(39, 16)
        Me.Lb5.TabIndex = 31
        Me.Lb5.Text = "Pais"
        '
        'CbBox1
        '
        Me.CbBox1.Campobd = Nothing
        Me.CbBox1.ClForm = Nothing
        Me.CbBox1.FormattingEnabled = True
        Me.CbBox1.GridLin = Nothing
        Me.CbBox1.Location = New System.Drawing.Point(116, 143)
        Me.CbBox1.MiEntidad = Nothing
        Me.CbBox1.MiError = False
        Me.CbBox1.Name = "CbBox1"
        Me.CbBox1.Orden = 0
        Me.CbBox1.SaltoAlfinal = False
        Me.CbBox1.Size = New System.Drawing.Size(121, 21)
        Me.CbBox1.TabIndex = 30
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
        Me.TxDato3.Location = New System.Drawing.Point(116, 102)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(100, 22)
        Me.TxDato3.TabIndex = 12
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.Location = New System.Drawing.Point(29, 108)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(51, 16)
        Me.Lb3.TabIndex = 13
        Me.Lb3.Text = "Fecha"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ClGrid1)
        Me.XtraTabPage3.Controls.Add(Me.LbImporte)
        Me.XtraTabPage3.Controls.Add(Me.Lb12)
        Me.XtraTabPage3.Controls.Add(Me.Lb11)
        Me.XtraTabPage3.Controls.Add(Me.TxDato9)
        Me.XtraTabPage3.Controls.Add(Me.Lb10)
        Me.XtraTabPage3.Controls.Add(Me.TxDato8)
        Me.XtraTabPage3.Controls.Add(Me.Lb4)
        Me.XtraTabPage3.Controls.Add(Me.TxDato4)
        Me.XtraTabPage3.Controls.Add(Me.Lb9)
        Me.XtraTabPage3.Controls.Add(Me.TxDato7)
        Me.XtraTabPage3.Controls.Add(Me.Lb7)
        Me.XtraTabPage3.Controls.Add(Me.TxDato6)
        Me.XtraTabPage3.Controls.Add(Me.Lb6)
        Me.XtraTabPage3.Controls.Add(Me.TxDato5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(770, 326)
        Me.XtraTabPage3.Text = "Domicilios descarga"
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(14, 96)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(690, 177)
        Me.ClGrid1.TabIndex = 39
        Me.ClGrid1.UltimoControl = 0
        '
        'LbImporte
        '
        Me.LbImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LbImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbImporte.CL_ControlAsociado = Nothing
        Me.LbImporte.CL_ValorFijo = False
        Me.LbImporte.ClForm = Nothing
        Me.LbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.Location = New System.Drawing.Point(591, 68)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(108, 22)
        Me.LbImporte.TabIndex = 38
        Me.LbImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb12
        '
        Me.Lb12.AutoSize = True
        Me.Lb12.CL_ControlAsociado = Nothing
        Me.Lb12.CL_ValorFijo = True
        Me.Lb12.ClForm = Nothing
        Me.Lb12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb12.Location = New System.Drawing.Point(639, 44)
        Me.Lb12.Name = "Lb12"
        Me.Lb12.Size = New System.Drawing.Size(60, 16)
        Me.Lb12.TabIndex = 37
        Me.Lb12.Text = "Importe"
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.ClForm = Nothing
        Me.Lb11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.Location = New System.Drawing.Point(484, 44)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(53, 16)
        Me.Lb11.TabIndex = 36
        Me.Lb11.Text = "Precio"
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(458, 68)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(108, 22)
        Me.TxDato9.TabIndex = 35
        Me.TxDato9.TeclaRepetida = False
        '
        'Lb10
        '
        Me.Lb10.AutoSize = True
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.Location = New System.Drawing.Point(363, 44)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(42, 16)
        Me.Lb10.TabIndex = 34
        Me.Lb10.Text = "Kilos"
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(337, 68)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(108, 22)
        Me.TxDato8.TabIndex = 33
        Me.TxDato8.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.Location = New System.Drawing.Point(8, 294)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(113, 16)
        Me.Lb4.TabIndex = 32
        Me.Lb4.Text = "Observaciones"
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
        Me.TxDato4.Location = New System.Drawing.Point(127, 288)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(460, 22)
        Me.TxDato4.TabIndex = 31
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.Location = New System.Drawing.Point(11, 74)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(73, 16)
        Me.Lb9.TabIndex = 30
        Me.Lb9.Text = "Provincia"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(96, 68)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(235, 22)
        Me.TxDato7.TabIndex = 29
        Me.TxDato7.TeclaRepetida = False
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.Location = New System.Drawing.Point(9, 44)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(78, 16)
        Me.Lb7.TabIndex = 28
        Me.Lb7.Text = "Poblacion"
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(96, 38)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(235, 22)
        Me.TxDato6.TabIndex = 27
        Me.TxDato6.TeclaRepetida = False
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(9, 14)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(73, 16)
        Me.Lb6.TabIndex = 26
        Me.Lb6.Text = "Domicilio"
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(96, 8)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(470, 22)
        Me.TxDato5.TabIndex = 25
        Me.TxDato5.TeclaRepetida = False
        '
        'FrClientesNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrClientesNew"
        Me.Text = "FrClientesNew"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents CbBoxSN As NetAgro.CbBox
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbBox1 As NetAgro.CbBox
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents LbImporte As NetAgro.Lb
    Friend WithEvents Lb12 As NetAgro.Lb
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
End Class
