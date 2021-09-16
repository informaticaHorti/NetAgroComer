<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiposdeClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiposdeClientes))
        Me.BtBuscaTipoCli = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChRec = New NetAgro.Chk(Me.components)
        Me.ChExento = New NetAgro.Chk(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.BtBuscaTipoIva = New NetAgro.BtBusca(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbnom9 = New NetAgro.Lb(Me.components)
        Me.Lbnom8 = New NetAgro.Lb(Me.components)
        Me.BtBusca9 = New NetAgro.BtBusca(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.BtBusca8 = New NetAgro.BtBusca(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.LbNom7 = New NetAgro.Lb(Me.components)
        Me.Lbnom6 = New NetAgro.Lb(Me.components)
        Me.BtBusca7 = New NetAgro.BtBusca(Me.components)
        Me.BtBusca6 = New NetAgro.BtBusca(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxCtaCliente = New NetAgro.TxDato(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbnom13 = New NetAgro.Lb(Me.components)
        Me.BtBusca13 = New NetAgro.BtBusca(Me.components)
        Me.Lb22 = New NetAgro.Lb(Me.components)
        Me.TxDato13 = New NetAgro.TxDato(Me.components)
        Me.Lbnom10 = New NetAgro.Lb(Me.components)
        Me.Lbnom11 = New NetAgro.Lb(Me.components)
        Me.Lbnom12 = New NetAgro.Lb(Me.components)
        Me.BtBusca10 = New NetAgro.BtBusca(Me.components)
        Me.Lb19 = New NetAgro.Lb(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.BtBusca11 = New NetAgro.BtBusca(Me.components)
        Me.BtBusca12 = New NetAgro.BtBusca(Me.components)
        Me.Lb20 = New NetAgro.Lb(Me.components)
        Me.TxDato11 = New NetAgro.TxDato(Me.components)
        Me.Lb21 = New NetAgro.Lb(Me.components)
        Me.TxDato12 = New NetAgro.TxDato(Me.components)
        Me.ChInterno = New NetAgro.Chk(Me.components)
        Me.ChkGeneraAsiento = New NetAgro.Chk(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'BtBuscaTipoCli
        '
        Me.BtBuscaTipoCli.CL_Ancho = 0
        Me.BtBuscaTipoCli.CL_BuscaAlb = False
        Me.BtBuscaTipoCli.CL_campocodigo = Nothing
        Me.BtBuscaTipoCli.CL_camponombre = Nothing
        Me.BtBuscaTipoCli.CL_CampoOrden = "Nombre"
        Me.BtBuscaTipoCli.CL_ch1000 = False
        Me.BtBuscaTipoCli.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTipoCli.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaTipoCli.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTipoCli.CL_dfecha = Nothing
        Me.BtBuscaTipoCli.CL_Entidad = Nothing
        Me.BtBuscaTipoCli.CL_EsId = True
        Me.BtBuscaTipoCli.CL_Filtro = Nothing
        Me.BtBuscaTipoCli.cl_formu = Nothing
        Me.BtBuscaTipoCli.CL_hfecha = Nothing
        Me.BtBuscaTipoCli.cl_ListaW = Nothing
        Me.BtBuscaTipoCli.CL_xCentro = False
        Me.BtBuscaTipoCli.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTipoCli.Location = New System.Drawing.Point(156, 17)
        Me.BtBuscaTipoCli.Name = "BtBuscaTipoCli"
        Me.BtBuscaTipoCli.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTipoCli.TabIndex = 34
        Me.BtBuscaTipoCli.UseVisualStyleBackColor = True
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
        Me.TxDato1.Location = New System.Drawing.Point(91, 17)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(59, 22)
        Me.TxDato1.TabIndex = 30
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(16, 48)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 33
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
        Me.TxDato2.Location = New System.Drawing.Point(91, 46)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(379, 22)
        Me.TxDato2.TabIndex = 32
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(195, 16)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 29
        Me.BotonesAvance1.Udato = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(16, 21)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 31
        Me.Lb1.Text = "Código"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChRec)
        Me.Panel2.Controls.Add(Me.ChExento)
        Me.Panel2.Controls.Add(Me.Lb10)
        Me.Panel2.Controls.Add(Me.BtBuscaTipoIva)
        Me.Panel2.Controls.Add(Me.Lb5)
        Me.Panel2.Controls.Add(Me.TxDato5)
        Me.Panel2.Location = New System.Drawing.Point(19, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 69)
        Me.Panel2.TabIndex = 35
        '
        'ChRec
        '
        Me.ChRec.AutoSize = True
        Me.ChRec.Campobd = Nothing
        Me.ChRec.ClForm = Nothing
        Me.ChRec.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChRec.ForeColor = System.Drawing.Color.Teal
        Me.ChRec.GridLin = Nothing
        Me.ChRec.HaCambiado = False
        Me.ChRec.Location = New System.Drawing.Point(118, 41)
        Me.ChRec.MiEntidad = Nothing
        Me.ChRec.MiError = False
        Me.ChRec.Name = "ChRec"
        Me.ChRec.Orden = 0
        Me.ChRec.SaltoAlfinal = False
        Me.ChRec.Size = New System.Drawing.Size(155, 20)
        Me.ChRec.TabIndex = 102
        Me.ChRec.Text = "Req. Equivalencia"
        Me.ChRec.UseVisualStyleBackColor = True
        Me.ChRec.ValorCampoFalse = Nothing
        Me.ChRec.ValorCampoTrue = Nothing
        Me.ChRec.ValorDefecto = False
        '
        'ChExento
        '
        Me.ChExento.AutoSize = True
        Me.ChExento.Campobd = Nothing
        Me.ChExento.ClForm = Nothing
        Me.ChExento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChExento.ForeColor = System.Drawing.Color.Teal
        Me.ChExento.GridLin = Nothing
        Me.ChExento.HaCambiado = False
        Me.ChExento.Location = New System.Drawing.Point(9, 41)
        Me.ChExento.MiEntidad = Nothing
        Me.ChExento.MiError = False
        Me.ChExento.Name = "ChExento"
        Me.ChExento.Orden = 0
        Me.ChExento.SaltoAlfinal = False
        Me.ChExento.Size = New System.Drawing.Size(78, 20)
        Me.ChExento.TabIndex = 101
        Me.ChExento.Text = "Exento"
        Me.ChExento.UseVisualStyleBackColor = True
        Me.ChExento.ValorCampoFalse = Nothing
        Me.ChExento.ValorCampoTrue = Nothing
        Me.ChExento.ValorDefecto = False
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.Location = New System.Drawing.Point(200, 9)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(241, 23)
        Me.Lb10.TabIndex = 66
        '
        'BtBuscaTipoIva
        '
        Me.BtBuscaTipoIva.CL_Ancho = 0
        Me.BtBuscaTipoIva.CL_BuscaAlb = False
        Me.BtBuscaTipoIva.CL_campocodigo = Nothing
        Me.BtBuscaTipoIva.CL_camponombre = Nothing
        Me.BtBuscaTipoIva.CL_CampoOrden = "Nombre"
        Me.BtBuscaTipoIva.CL_ch1000 = False
        Me.BtBuscaTipoIva.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTipoIva.CL_ControlAsociado = Me.TxDato5
        Me.BtBuscaTipoIva.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTipoIva.CL_dfecha = Nothing
        Me.BtBuscaTipoIva.CL_Entidad = Nothing
        Me.BtBuscaTipoIva.CL_EsId = True
        Me.BtBuscaTipoIva.CL_Filtro = Nothing
        Me.BtBuscaTipoIva.cl_formu = Nothing
        Me.BtBuscaTipoIva.CL_hfecha = Nothing
        Me.BtBuscaTipoIva.cl_ListaW = Nothing
        Me.BtBuscaTipoIva.CL_xCentro = False
        Me.BtBuscaTipoIva.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTipoIva.Location = New System.Drawing.Point(161, 9)
        Me.BtBuscaTipoIva.Name = "BtBuscaTipoIva"
        Me.BtBuscaTipoIva.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTipoIva.TabIndex = 38
        Me.BtBuscaTipoIva.UseVisualStyleBackColor = True
        '
        'TxDato5
        '
        Me.TxDato5.Autonumerico = False
        Me.TxDato5.Buscando = False
        Me.TxDato5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.HaCambiado = False
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.lbbusca = Nothing
        Me.TxDato5.Location = New System.Drawing.Point(118, 9)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(37, 22)
        Me.TxDato5.TabIndex = 36
        Me.TxDato5.TeclaRepetida = False
        Me.TxDato5.UltimoValorValidado = Nothing
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(9, 12)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(101, 16)
        Me.Lb5.TabIndex = 37
        Me.Lb5.Text = "Regimen IVA"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbnom9)
        Me.Panel3.Controls.Add(Me.Lbnom8)
        Me.Panel3.Controls.Add(Me.BtBusca9)
        Me.Panel3.Controls.Add(Me.Lb9)
        Me.Panel3.Controls.Add(Me.TxDato9)
        Me.Panel3.Controls.Add(Me.BtBusca8)
        Me.Panel3.Controls.Add(Me.Lb8)
        Me.Panel3.Controls.Add(Me.TxDato8)
        Me.Panel3.Controls.Add(Me.LbNom7)
        Me.Panel3.Controls.Add(Me.Lbnom6)
        Me.Panel3.Controls.Add(Me.BtBusca7)
        Me.Panel3.Controls.Add(Me.BtBusca6)
        Me.Panel3.Controls.Add(Me.Lb7)
        Me.Panel3.Controls.Add(Me.TxDato7)
        Me.Panel3.Controls.Add(Me.Lb6)
        Me.Panel3.Controls.Add(Me.TxCtaCliente)
        Me.Panel3.Location = New System.Drawing.Point(19, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 130)
        Me.Panel3.TabIndex = 36
        '
        'Lbnom9
        '
        Me.Lbnom9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom9.CL_ControlAsociado = Nothing
        Me.Lbnom9.CL_ValorFijo = False
        Me.Lbnom9.ClForm = Nothing
        Me.Lbnom9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom9.Location = New System.Drawing.Point(309, 96)
        Me.Lbnom9.Name = "Lbnom9"
        Me.Lbnom9.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom9.TabIndex = 77
        '
        'Lbnom8
        '
        Me.Lbnom8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom8.CL_ControlAsociado = Nothing
        Me.Lbnom8.CL_ValorFijo = False
        Me.Lbnom8.ClForm = Nothing
        Me.Lbnom8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom8.Location = New System.Drawing.Point(309, 69)
        Me.Lbnom8.Name = "Lbnom8"
        Me.Lbnom8.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom8.TabIndex = 76
        '
        'BtBusca9
        '
        Me.BtBusca9.CL_Ancho = 0
        Me.BtBusca9.CL_BuscaAlb = False
        Me.BtBusca9.CL_campocodigo = Nothing
        Me.BtBusca9.CL_camponombre = Nothing
        Me.BtBusca9.CL_CampoOrden = "Nombre"
        Me.BtBusca9.CL_ch1000 = False
        Me.BtBusca9.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca9.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca9.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca9.CL_dfecha = Nothing
        Me.BtBusca9.CL_Entidad = Nothing
        Me.BtBusca9.CL_EsId = True
        Me.BtBusca9.CL_Filtro = Nothing
        Me.BtBusca9.cl_formu = Nothing
        Me.BtBusca9.CL_hfecha = Nothing
        Me.BtBusca9.cl_ListaW = Nothing
        Me.BtBusca9.CL_xCentro = False
        Me.BtBusca9.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca9.Location = New System.Drawing.Point(270, 95)
        Me.BtBusca9.Name = "BtBusca9"
        Me.BtBusca9.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca9.TabIndex = 75
        Me.BtBusca9.UseVisualStyleBackColor = True
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(9, 102)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(54, 16)
        Me.Lb9.TabIndex = 74
        Me.Lb9.Text = "Varios"
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(137, 96)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(126, 22)
        Me.TxDato9.TabIndex = 73
        Me.TxDato9.TeclaRepetida = False
        Me.TxDato9.UltimoValorValidado = Nothing
        '
        'BtBusca8
        '
        Me.BtBusca8.CL_Ancho = 0
        Me.BtBusca8.CL_BuscaAlb = False
        Me.BtBusca8.CL_campocodigo = Nothing
        Me.BtBusca8.CL_camponombre = Nothing
        Me.BtBusca8.CL_CampoOrden = "Nombre"
        Me.BtBusca8.CL_ch1000 = False
        Me.BtBusca8.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca8.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca8.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca8.CL_dfecha = Nothing
        Me.BtBusca8.CL_Entidad = Nothing
        Me.BtBusca8.CL_EsId = True
        Me.BtBusca8.CL_Filtro = Nothing
        Me.BtBusca8.cl_formu = Nothing
        Me.BtBusca8.CL_hfecha = Nothing
        Me.BtBusca8.cl_ListaW = Nothing
        Me.BtBusca8.CL_xCentro = False
        Me.BtBusca8.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca8.Location = New System.Drawing.Point(270, 67)
        Me.BtBusca8.Name = "BtBusca8"
        Me.BtBusca8.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca8.TabIndex = 72
        Me.BtBusca8.UseVisualStyleBackColor = True
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(9, 74)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(69, 16)
        Me.Lb8.TabIndex = 71
        Me.Lb8.Text = "Envases"
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(137, 68)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(126, 22)
        Me.TxDato8.TabIndex = 70
        Me.TxDato8.TeclaRepetida = False
        Me.TxDato8.UltimoValorValidado = Nothing
        '
        'LbNom7
        '
        Me.LbNom7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbNom7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNom7.CL_ControlAsociado = Nothing
        Me.LbNom7.CL_ValorFijo = False
        Me.LbNom7.ClForm = Nothing
        Me.LbNom7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom7.Location = New System.Drawing.Point(309, 38)
        Me.LbNom7.Name = "LbNom7"
        Me.LbNom7.Size = New System.Drawing.Size(313, 23)
        Me.LbNom7.TabIndex = 67
        '
        'Lbnom6
        '
        Me.Lbnom6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom6.CL_ControlAsociado = Nothing
        Me.Lbnom6.CL_ValorFijo = False
        Me.Lbnom6.ClForm = Nothing
        Me.Lbnom6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom6.Location = New System.Drawing.Point(309, 9)
        Me.Lbnom6.Name = "Lbnom6"
        Me.Lbnom6.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom6.TabIndex = 66
        Me.Lbnom6.Visible = False
        '
        'BtBusca7
        '
        Me.BtBusca7.CL_Ancho = 0
        Me.BtBusca7.CL_BuscaAlb = False
        Me.BtBusca7.CL_campocodigo = Nothing
        Me.BtBusca7.CL_camponombre = Nothing
        Me.BtBusca7.CL_CampoOrden = "Nombre"
        Me.BtBusca7.CL_ch1000 = False
        Me.BtBusca7.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca7.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca7.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca7.CL_dfecha = Nothing
        Me.BtBusca7.CL_Entidad = Nothing
        Me.BtBusca7.CL_EsId = True
        Me.BtBusca7.CL_Filtro = Nothing
        Me.BtBusca7.cl_formu = Nothing
        Me.BtBusca7.CL_hfecha = Nothing
        Me.BtBusca7.cl_ListaW = Nothing
        Me.BtBusca7.CL_xCentro = False
        Me.BtBusca7.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca7.Location = New System.Drawing.Point(270, 38)
        Me.BtBusca7.Name = "BtBusca7"
        Me.BtBusca7.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca7.TabIndex = 41
        Me.BtBusca7.UseVisualStyleBackColor = True
        '
        'BtBusca6
        '
        Me.BtBusca6.CL_Ancho = 0
        Me.BtBusca6.CL_BuscaAlb = False
        Me.BtBusca6.CL_campocodigo = Nothing
        Me.BtBusca6.CL_camponombre = Nothing
        Me.BtBusca6.CL_CampoOrden = "Nombre"
        Me.BtBusca6.CL_ch1000 = False
        Me.BtBusca6.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca6.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca6.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca6.CL_dfecha = Nothing
        Me.BtBusca6.CL_Entidad = Nothing
        Me.BtBusca6.CL_EsId = True
        Me.BtBusca6.CL_Filtro = Nothing
        Me.BtBusca6.cl_formu = Nothing
        Me.BtBusca6.CL_hfecha = Nothing
        Me.BtBusca6.cl_ListaW = Nothing
        Me.BtBusca6.CL_xCentro = False
        Me.BtBusca6.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca6.Location = New System.Drawing.Point(270, 9)
        Me.BtBusca6.Name = "BtBusca6"
        Me.BtBusca6.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca6.TabIndex = 40
        Me.BtBusca6.UseVisualStyleBackColor = True
        Me.BtBusca6.Visible = False
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(9, 44)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(59, 16)
        Me.Lb7.TabIndex = 37
        Me.Lb7.Text = "Ventas"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(137, 38)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(126, 22)
        Me.TxDato7.TabIndex = 36
        Me.TxDato7.TeclaRepetida = False
        Me.TxDato7.UltimoValorValidado = Nothing
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(9, 16)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(59, 16)
        Me.Lb6.TabIndex = 35
        Me.Lb6.Text = "Cliente"
        '
        'TxCtaCliente
        '
        Me.TxCtaCliente.Autonumerico = False
        Me.TxCtaCliente.Buscando = False
        Me.TxCtaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCtaCliente.ClForm = Nothing
        Me.TxCtaCliente.ClParam = Nothing
        Me.TxCtaCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxCtaCliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCtaCliente.GridLin = Nothing
        Me.TxCtaCliente.HaCambiado = False
        Me.TxCtaCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxCtaCliente.lbbusca = Nothing
        Me.TxCtaCliente.Location = New System.Drawing.Point(137, 10)
        Me.TxCtaCliente.MaxLength = 6
        Me.TxCtaCliente.MiError = False
        Me.TxCtaCliente.Name = "TxCtaCliente"
        Me.TxCtaCliente.Orden = 0
        Me.TxCtaCliente.SaltoAlfinal = False
        Me.TxCtaCliente.Siguiente = 0
        Me.TxCtaCliente.Size = New System.Drawing.Size(126, 22)
        Me.TxCtaCliente.TabIndex = 34
        Me.TxCtaCliente.TeclaRepetida = False
        Me.TxCtaCliente.UltimoValorValidado = Nothing
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Lbnom13)
        Me.Panel4.Controls.Add(Me.BtBusca13)
        Me.Panel4.Controls.Add(Me.Lb22)
        Me.Panel4.Controls.Add(Me.TxDato13)
        Me.Panel4.Controls.Add(Me.Lbnom10)
        Me.Panel4.Controls.Add(Me.Lbnom11)
        Me.Panel4.Controls.Add(Me.Lbnom12)
        Me.Panel4.Controls.Add(Me.BtBusca10)
        Me.Panel4.Controls.Add(Me.Lb19)
        Me.Panel4.Controls.Add(Me.TxDato10)
        Me.Panel4.Controls.Add(Me.BtBusca11)
        Me.Panel4.Controls.Add(Me.BtBusca12)
        Me.Panel4.Controls.Add(Me.Lb20)
        Me.Panel4.Controls.Add(Me.TxDato11)
        Me.Panel4.Controls.Add(Me.Lb21)
        Me.Panel4.Controls.Add(Me.TxDato12)
        Me.Panel4.Location = New System.Drawing.Point(19, 310)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(632, 131)
        Me.Panel4.TabIndex = 37
        '
        'Lbnom13
        '
        Me.Lbnom13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom13.CL_ControlAsociado = Nothing
        Me.Lbnom13.CL_ValorFijo = False
        Me.Lbnom13.ClForm = Nothing
        Me.Lbnom13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom13.Location = New System.Drawing.Point(309, 97)
        Me.Lbnom13.Name = "Lbnom13"
        Me.Lbnom13.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom13.TabIndex = 73
        '
        'BtBusca13
        '
        Me.BtBusca13.CL_Ancho = 0
        Me.BtBusca13.CL_BuscaAlb = False
        Me.BtBusca13.CL_campocodigo = Nothing
        Me.BtBusca13.CL_camponombre = Nothing
        Me.BtBusca13.CL_CampoOrden = "Nombre"
        Me.BtBusca13.CL_ch1000 = False
        Me.BtBusca13.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca13.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca13.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca13.CL_dfecha = Nothing
        Me.BtBusca13.CL_Entidad = Nothing
        Me.BtBusca13.CL_EsId = True
        Me.BtBusca13.CL_Filtro = Nothing
        Me.BtBusca13.cl_formu = Nothing
        Me.BtBusca13.CL_hfecha = Nothing
        Me.BtBusca13.cl_ListaW = Nothing
        Me.BtBusca13.CL_xCentro = False
        Me.BtBusca13.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca13.Location = New System.Drawing.Point(270, 96)
        Me.BtBusca13.Name = "BtBusca13"
        Me.BtBusca13.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca13.TabIndex = 72
        Me.BtBusca13.UseVisualStyleBackColor = True
        '
        'Lb22
        '
        Me.Lb22.AutoSize = True
        Me.Lb22.CL_ControlAsociado = Nothing
        Me.Lb22.CL_ValorFijo = False
        Me.Lb22.ClForm = Nothing
        Me.Lb22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb22.ForeColor = System.Drawing.Color.Teal
        Me.Lb22.Location = New System.Drawing.Point(9, 103)
        Me.Lb22.Name = "Lb22"
        Me.Lb22.Size = New System.Drawing.Size(85, 16)
        Me.Lb22.TabIndex = 71
        Me.Lb22.Text = "Cta Rec Eq"
        '
        'TxDato13
        '
        Me.TxDato13.Autonumerico = False
        Me.TxDato13.Buscando = False
        Me.TxDato13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato13.ClForm = Nothing
        Me.TxDato13.ClParam = Nothing
        Me.TxDato13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato13.GridLin = Nothing
        Me.TxDato13.HaCambiado = False
        Me.TxDato13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato13.lbbusca = Nothing
        Me.TxDato13.Location = New System.Drawing.Point(137, 97)
        Me.TxDato13.MiError = False
        Me.TxDato13.Name = "TxDato13"
        Me.TxDato13.Orden = 0
        Me.TxDato13.SaltoAlfinal = False
        Me.TxDato13.Siguiente = 0
        Me.TxDato13.Size = New System.Drawing.Size(126, 22)
        Me.TxDato13.TabIndex = 70
        Me.TxDato13.TeclaRepetida = False
        Me.TxDato13.UltimoValorValidado = Nothing
        '
        'Lbnom10
        '
        Me.Lbnom10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom10.CL_ControlAsociado = Nothing
        Me.Lbnom10.CL_ValorFijo = False
        Me.Lbnom10.ClForm = Nothing
        Me.Lbnom10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom10.Location = New System.Drawing.Point(309, 68)
        Me.Lbnom10.Name = "Lbnom10"
        Me.Lbnom10.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom10.TabIndex = 69
        '
        'Lbnom11
        '
        Me.Lbnom11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom11.CL_ControlAsociado = Nothing
        Me.Lbnom11.CL_ValorFijo = False
        Me.Lbnom11.ClForm = Nothing
        Me.Lbnom11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom11.Location = New System.Drawing.Point(309, 41)
        Me.Lbnom11.Name = "Lbnom11"
        Me.Lbnom11.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom11.TabIndex = 68
        '
        'Lbnom12
        '
        Me.Lbnom12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbnom12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbnom12.CL_ControlAsociado = Nothing
        Me.Lbnom12.CL_ValorFijo = False
        Me.Lbnom12.ClForm = Nothing
        Me.Lbnom12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom12.Location = New System.Drawing.Point(309, 12)
        Me.Lbnom12.Name = "Lbnom12"
        Me.Lbnom12.Size = New System.Drawing.Size(313, 23)
        Me.Lbnom12.TabIndex = 67
        '
        'BtBusca10
        '
        Me.BtBusca10.CL_Ancho = 0
        Me.BtBusca10.CL_BuscaAlb = False
        Me.BtBusca10.CL_campocodigo = Nothing
        Me.BtBusca10.CL_camponombre = Nothing
        Me.BtBusca10.CL_CampoOrden = "Nombre"
        Me.BtBusca10.CL_ch1000 = False
        Me.BtBusca10.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca10.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca10.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca10.CL_dfecha = Nothing
        Me.BtBusca10.CL_Entidad = Nothing
        Me.BtBusca10.CL_EsId = True
        Me.BtBusca10.CL_Filtro = Nothing
        Me.BtBusca10.cl_formu = Nothing
        Me.BtBusca10.CL_hfecha = Nothing
        Me.BtBusca10.cl_ListaW = Nothing
        Me.BtBusca10.CL_xCentro = False
        Me.BtBusca10.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca10.Location = New System.Drawing.Point(270, 67)
        Me.BtBusca10.Name = "BtBusca10"
        Me.BtBusca10.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca10.TabIndex = 45
        Me.BtBusca10.UseVisualStyleBackColor = True
        '
        'Lb19
        '
        Me.Lb19.AutoSize = True
        Me.Lb19.CL_ControlAsociado = Nothing
        Me.Lb19.CL_ValorFijo = False
        Me.Lb19.ClForm = Nothing
        Me.Lb19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb19.ForeColor = System.Drawing.Color.Teal
        Me.Lb19.Location = New System.Drawing.Point(9, 74)
        Me.Lb19.Name = "Lb19"
        Me.Lb19.Size = New System.Drawing.Size(111, 16)
        Me.Lb19.TabIndex = 44
        Me.Lb19.Text = "Cta Iva Varios"
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(137, 68)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(126, 22)
        Me.TxDato10.TabIndex = 43
        Me.TxDato10.TeclaRepetida = False
        Me.TxDato10.UltimoValorValidado = Nothing
        '
        'BtBusca11
        '
        Me.BtBusca11.CL_Ancho = 0
        Me.BtBusca11.CL_BuscaAlb = False
        Me.BtBusca11.CL_campocodigo = Nothing
        Me.BtBusca11.CL_camponombre = Nothing
        Me.BtBusca11.CL_CampoOrden = "Nombre"
        Me.BtBusca11.CL_ch1000 = False
        Me.BtBusca11.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca11.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca11.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca11.CL_dfecha = Nothing
        Me.BtBusca11.CL_Entidad = Nothing
        Me.BtBusca11.CL_EsId = True
        Me.BtBusca11.CL_Filtro = Nothing
        Me.BtBusca11.cl_formu = Nothing
        Me.BtBusca11.CL_hfecha = Nothing
        Me.BtBusca11.cl_ListaW = Nothing
        Me.BtBusca11.CL_xCentro = False
        Me.BtBusca11.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca11.Location = New System.Drawing.Point(270, 39)
        Me.BtBusca11.Name = "BtBusca11"
        Me.BtBusca11.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca11.TabIndex = 42
        Me.BtBusca11.UseVisualStyleBackColor = True
        '
        'BtBusca12
        '
        Me.BtBusca12.CL_Ancho = 0
        Me.BtBusca12.CL_BuscaAlb = False
        Me.BtBusca12.CL_campocodigo = Nothing
        Me.BtBusca12.CL_camponombre = Nothing
        Me.BtBusca12.CL_CampoOrden = "Nombre"
        Me.BtBusca12.CL_ch1000 = False
        Me.BtBusca12.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca12.CL_ControlAsociado = Me.TxDato5
        Me.BtBusca12.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca12.CL_dfecha = Nothing
        Me.BtBusca12.CL_Entidad = Nothing
        Me.BtBusca12.CL_EsId = True
        Me.BtBusca12.CL_Filtro = Nothing
        Me.BtBusca12.cl_formu = Nothing
        Me.BtBusca12.CL_hfecha = Nothing
        Me.BtBusca12.cl_ListaW = Nothing
        Me.BtBusca12.CL_xCentro = False
        Me.BtBusca12.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca12.Location = New System.Drawing.Point(270, 12)
        Me.BtBusca12.Name = "BtBusca12"
        Me.BtBusca12.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca12.TabIndex = 41
        Me.BtBusca12.UseVisualStyleBackColor = True
        '
        'Lb20
        '
        Me.Lb20.AutoSize = True
        Me.Lb20.CL_ControlAsociado = Nothing
        Me.Lb20.CL_ValorFijo = False
        Me.Lb20.ClForm = Nothing
        Me.Lb20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb20.ForeColor = System.Drawing.Color.Teal
        Me.Lb20.Location = New System.Drawing.Point(9, 46)
        Me.Lb20.Name = "Lb20"
        Me.Lb20.Size = New System.Drawing.Size(126, 16)
        Me.Lb20.TabIndex = 39
        Me.Lb20.Text = "Cta Iva Envases"
        '
        'TxDato11
        '
        Me.TxDato11.Autonumerico = False
        Me.TxDato11.Buscando = False
        Me.TxDato11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato11.ClForm = Nothing
        Me.TxDato11.ClParam = Nothing
        Me.TxDato11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato11.GridLin = Nothing
        Me.TxDato11.HaCambiado = False
        Me.TxDato11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato11.lbbusca = Nothing
        Me.TxDato11.Location = New System.Drawing.Point(137, 40)
        Me.TxDato11.MiError = False
        Me.TxDato11.Name = "TxDato11"
        Me.TxDato11.Orden = 0
        Me.TxDato11.SaltoAlfinal = False
        Me.TxDato11.Siguiente = 0
        Me.TxDato11.Size = New System.Drawing.Size(126, 22)
        Me.TxDato11.TabIndex = 38
        Me.TxDato11.TeclaRepetida = False
        Me.TxDato11.UltimoValorValidado = Nothing
        '
        'Lb21
        '
        Me.Lb21.AutoSize = True
        Me.Lb21.CL_ControlAsociado = Nothing
        Me.Lb21.CL_ValorFijo = False
        Me.Lb21.ClForm = Nothing
        Me.Lb21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb21.ForeColor = System.Drawing.Color.Teal
        Me.Lb21.Location = New System.Drawing.Point(9, 18)
        Me.Lb21.Name = "Lb21"
        Me.Lb21.Size = New System.Drawing.Size(116, 16)
        Me.Lb21.TabIndex = 37
        Me.Lb21.Text = "Cta Iva Ventas"
        '
        'TxDato12
        '
        Me.TxDato12.Autonumerico = False
        Me.TxDato12.Buscando = False
        Me.TxDato12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato12.ClForm = Nothing
        Me.TxDato12.ClParam = Nothing
        Me.TxDato12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato12.GridLin = Nothing
        Me.TxDato12.HaCambiado = False
        Me.TxDato12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato12.lbbusca = Nothing
        Me.TxDato12.Location = New System.Drawing.Point(137, 12)
        Me.TxDato12.MiError = False
        Me.TxDato12.Name = "TxDato12"
        Me.TxDato12.Orden = 0
        Me.TxDato12.SaltoAlfinal = False
        Me.TxDato12.Siguiente = 0
        Me.TxDato12.Size = New System.Drawing.Size(126, 22)
        Me.TxDato12.TabIndex = 36
        Me.TxDato12.TeclaRepetida = False
        Me.TxDato12.UltimoValorValidado = Nothing
        '
        'ChInterno
        '
        Me.ChInterno.AutoSize = True
        Me.ChInterno.Campobd = Nothing
        Me.ChInterno.ClForm = Nothing
        Me.ChInterno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChInterno.ForeColor = System.Drawing.Color.Teal
        Me.ChInterno.GridLin = Nothing
        Me.ChInterno.HaCambiado = False
        Me.ChInterno.Location = New System.Drawing.Point(513, 18)
        Me.ChInterno.MiEntidad = Nothing
        Me.ChInterno.MiError = False
        Me.ChInterno.Name = "ChInterno"
        Me.ChInterno.Orden = 0
        Me.ChInterno.SaltoAlfinal = False
        Me.ChInterno.Size = New System.Drawing.Size(134, 20)
        Me.ChInterno.TabIndex = 78
        Me.ChInterno.Text = "Cliente interno"
        Me.ChInterno.UseVisualStyleBackColor = True
        Me.ChInterno.ValorCampoFalse = Nothing
        Me.ChInterno.ValorCampoTrue = Nothing
        Me.ChInterno.ValorDefecto = False
        '
        'ChkGeneraAsiento
        '
        Me.ChkGeneraAsiento.AutoSize = True
        Me.ChkGeneraAsiento.Campobd = Nothing
        Me.ChkGeneraAsiento.ClForm = Nothing
        Me.ChkGeneraAsiento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGeneraAsiento.ForeColor = System.Drawing.Color.Teal
        Me.ChkGeneraAsiento.GridLin = Nothing
        Me.ChkGeneraAsiento.HaCambiado = False
        Me.ChkGeneraAsiento.Location = New System.Drawing.Point(513, 47)
        Me.ChkGeneraAsiento.MiEntidad = Nothing
        Me.ChkGeneraAsiento.MiError = False
        Me.ChkGeneraAsiento.Name = "ChkGeneraAsiento"
        Me.ChkGeneraAsiento.Orden = 0
        Me.ChkGeneraAsiento.SaltoAlfinal = False
        Me.ChkGeneraAsiento.Size = New System.Drawing.Size(138, 20)
        Me.ChkGeneraAsiento.TabIndex = 79
        Me.ChkGeneraAsiento.Text = "Genera Asiento"
        Me.ChkGeneraAsiento.UseVisualStyleBackColor = True
        Me.ChkGeneraAsiento.ValorCampoFalse = Nothing
        Me.ChkGeneraAsiento.ValorCampoTrue = Nothing
        Me.ChkGeneraAsiento.ValorDefecto = False
        '
        'FrmTiposdeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 488)
        Me.Controls.Add(Me.ChkGeneraAsiento)
        Me.Controls.Add(Me.ChInterno)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtBuscaTipoCli)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTiposdeClientes"
        Me.Text = "Tipos de clientes"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaTipoCli, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.ChInterno, 0)
        Me.Controls.SetChildIndex(Me.ChkGeneraAsiento, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtBuscaTipoCli As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtBuscaTipoIva As NetAgro.BtBusca
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtBusca7 As NetAgro.BtBusca
    Friend WithEvents BtBusca6 As NetAgro.BtBusca
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents TxCtaCliente As NetAgro.TxDato
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents LbNom7 As NetAgro.Lb
    Friend WithEvents Lbnom6 As NetAgro.Lb
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Lbnom10 As NetAgro.Lb
    Friend WithEvents Lbnom11 As NetAgro.Lb
    Friend WithEvents Lbnom12 As NetAgro.Lb
    Friend WithEvents BtBusca10 As NetAgro.BtBusca
    Friend WithEvents Lb19 As NetAgro.Lb
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents BtBusca11 As NetAgro.BtBusca
    Friend WithEvents BtBusca12 As NetAgro.BtBusca
    Friend WithEvents Lb20 As NetAgro.Lb
    Friend WithEvents TxDato11 As NetAgro.TxDato
    Friend WithEvents Lb21 As NetAgro.Lb
    Friend WithEvents TxDato12 As NetAgro.TxDato
    Friend WithEvents Lbnom13 As NetAgro.Lb
    Friend WithEvents BtBusca13 As NetAgro.BtBusca
    Friend WithEvents Lb22 As NetAgro.Lb
    Friend WithEvents TxDato13 As NetAgro.TxDato
    Friend WithEvents ChInterno As NetAgro.Chk
    Friend WithEvents ChExento As NetAgro.Chk
    Friend WithEvents ChRec As NetAgro.Chk
    Friend WithEvents ChkGeneraAsiento As NetAgro.Chk
    Friend WithEvents Lbnom9 As NetAgro.Lb
    Friend WithEvents Lbnom8 As NetAgro.Lb
    Friend WithEvents BtBusca9 As NetAgro.BtBusca
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents BtBusca8 As NetAgro.BtBusca
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
End Class
