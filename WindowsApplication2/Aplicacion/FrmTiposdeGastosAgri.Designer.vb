<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiposdeGastosAgri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiposdeGastosAgri))
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.CbBox1 = New NetAgro.CbBox(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BotonesAvance1 = New NetAgro.BotonesAvance()
        Me.BtBuscaTgasto = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaGrupo = New NetAgro.BtBusca(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAcreedor = New NetAgro.BtBusca(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.CbFaccom = New NetAgro.CbBox(Me.components)
        Me.chkImprimirEnEntrada = New NetAgro.Chk(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(19, 88)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(38, 16)
        Me.Lb5.TabIndex = 37
        Me.Lb5.Text = "Tipo"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(19, 56)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(65, 16)
        Me.Lb2.TabIndex = 35
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
        Me.TxDato2.Location = New System.Drawing.Point(169, 49)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(353, 22)
        Me.TxDato2.TabIndex = 34
        Me.TxDato2.TeclaRepetida = False
        '
        'CbBox1
        '
        Me.CbBox1.Campobd = Nothing
        Me.CbBox1.ClForm = Nothing
        Me.CbBox1.FormattingEnabled = True
        Me.CbBox1.GridLin = Nothing
        Me.CbBox1.Location = New System.Drawing.Point(169, 82)
        Me.CbBox1.MiEntidad = Nothing
        Me.CbBox1.MiError = False
        Me.CbBox1.Name = "CbBox1"
        Me.CbBox1.Orden = 0
        Me.CbBox1.SaltoAlfinal = False
        Me.CbBox1.Size = New System.Drawing.Size(121, 21)
        Me.CbBox1.TabIndex = 36
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(19, 25)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(58, 16)
        Me.Lb1.TabIndex = 33
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
        Me.TxDato1.Location = New System.Drawing.Point(169, 18)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(53, 22)
        Me.TxDato1.TabIndex = 32
        Me.TxDato1.TeclaRepetida = False
        '
        'BotonesAvance1
        '
        Me.BotonesAvance1.CampoOrden = Nothing
        Me.BotonesAvance1.Filtro = Nothing
        Me.BotonesAvance1.Formulario = Nothing
        Me.BotonesAvance1.Location = New System.Drawing.Point(267, 17)
        Me.BotonesAvance1.Mientidad = Nothing
        Me.BotonesAvance1.Name = "BotonesAvance1"
        Me.BotonesAvance1.Size = New System.Drawing.Size(127, 24)
        Me.BotonesAvance1.TabIndex = 38
        Me.BotonesAvance1.Udato = Nothing
        '
        'BtBuscaTgasto
        '
        Me.BtBuscaTgasto.CL_BuscaAlb = False
        Me.BtBuscaTgasto.CL_campocodigo = Nothing
        Me.BtBuscaTgasto.CL_camponombre = Nothing
        Me.BtBuscaTgasto.CL_CampoOrden = "Nombre"
        Me.BtBuscaTgasto.CL_ch1000 = False
        Me.BtBuscaTgasto.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaTgasto.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaTgasto.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaTgasto.CL_dfecha = Nothing
        Me.BtBuscaTgasto.CL_Entidad = Nothing
        Me.BtBuscaTgasto.CL_Filtro = Nothing
        Me.BtBuscaTgasto.cl_formu = Nothing
        Me.BtBuscaTgasto.CL_hfecha = Nothing
        Me.BtBuscaTgasto.cl_ListaW = Nothing
        Me.BtBuscaTgasto.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaTgasto.Location = New System.Drawing.Point(228, 17)
        Me.BtBuscaTgasto.Name = "BtBuscaTgasto"
        Me.BtBuscaTgasto.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaTgasto.TabIndex = 39
        Me.BtBuscaTgasto.UseVisualStyleBackColor = True
        '
        'BtBuscaGrupo
        '
        Me.BtBuscaGrupo.CL_BuscaAlb = False
        Me.BtBuscaGrupo.CL_campocodigo = Nothing
        Me.BtBuscaGrupo.CL_camponombre = Nothing
        Me.BtBuscaGrupo.CL_CampoOrden = "Nombre"
        Me.BtBuscaGrupo.CL_ch1000 = False
        Me.BtBuscaGrupo.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGrupo.CL_ControlAsociado = Me.TxDato3
        Me.BtBuscaGrupo.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGrupo.CL_dfecha = Nothing
        Me.BtBuscaGrupo.CL_Entidad = Nothing
        Me.BtBuscaGrupo.CL_Filtro = Nothing
        Me.BtBuscaGrupo.cl_formu = Nothing
        Me.BtBuscaGrupo.CL_hfecha = Nothing
        Me.BtBuscaGrupo.cl_ListaW = Nothing
        Me.BtBuscaGrupo.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGrupo.Location = New System.Drawing.Point(228, 111)
        Me.BtBuscaGrupo.Name = "BtBuscaGrupo"
        Me.BtBuscaGrupo.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGrupo.TabIndex = 42
        Me.BtBuscaGrupo.UseVisualStyleBackColor = True
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
        Me.TxDato3.Location = New System.Drawing.Point(169, 112)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(53, 22)
        Me.TxDato3.TabIndex = 40
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
        Me.Lb3.Location = New System.Drawing.Point(19, 119)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(56, 16)
        Me.Lb3.TabIndex = 41
        Me.Lb3.Text = "Origen"
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.ClForm = Nothing
        Me.Lb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.Location = New System.Drawing.Point(267, 111)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(255, 23)
        Me.Lb10.TabIndex = 67
        '
        'Lb6
        '
        Me.Lb6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.Location = New System.Drawing.Point(267, 146)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(401, 23)
        Me.Lb6.TabIndex = 73
        '
        'BtBuscaAcreedor
        '
        Me.BtBuscaAcreedor.CL_BuscaAlb = False
        Me.BtBuscaAcreedor.CL_campocodigo = Nothing
        Me.BtBuscaAcreedor.CL_camponombre = Nothing
        Me.BtBuscaAcreedor.CL_CampoOrden = "Nombre"
        Me.BtBuscaAcreedor.CL_ch1000 = False
        Me.BtBuscaAcreedor.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAcreedor.CL_ControlAsociado = Me.TxDato4
        Me.BtBuscaAcreedor.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAcreedor.CL_dfecha = Nothing
        Me.BtBuscaAcreedor.CL_Entidad = Nothing
        Me.BtBuscaAcreedor.CL_Filtro = Nothing
        Me.BtBuscaAcreedor.cl_formu = Nothing
        Me.BtBuscaAcreedor.CL_hfecha = Nothing
        Me.BtBuscaAcreedor.cl_ListaW = Nothing
        Me.BtBuscaAcreedor.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAcreedor.Location = New System.Drawing.Point(228, 146)
        Me.BtBuscaAcreedor.Name = "BtBuscaAcreedor"
        Me.BtBuscaAcreedor.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAcreedor.TabIndex = 72
        Me.BtBuscaAcreedor.UseVisualStyleBackColor = True
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(169, 147)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(53, 22)
        Me.TxDato4.TabIndex = 70
        Me.TxDato4.TeclaRepetida = False
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(19, 154)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(74, 16)
        Me.Lb7.TabIndex = 71
        Me.Lb7.Text = "Acreedor"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(377, 189)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(118, 16)
        Me.Lb4.TabIndex = 90
        Me.Lb4.Text = "(* por defecto)"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(18, 190)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(146, 16)
        Me.Lb8.TabIndex = 89
        Me.Lb8.Text = "Factura/Comercial"
        '
        'CbFaccom
        '
        Me.CbFaccom.Campobd = Nothing
        Me.CbFaccom.ClForm = Nothing
        Me.CbFaccom.FormattingEnabled = True
        Me.CbFaccom.GridLin = Nothing
        Me.CbFaccom.Location = New System.Drawing.Point(169, 184)
        Me.CbFaccom.MiEntidad = Nothing
        Me.CbFaccom.MiError = False
        Me.CbFaccom.Name = "CbFaccom"
        Me.CbFaccom.Orden = 0
        Me.CbFaccom.SaltoAlfinal = False
        Me.CbFaccom.Size = New System.Drawing.Size(186, 21)
        Me.CbFaccom.TabIndex = 88
        '
        'chkImprimirEnEntrada
        '
        Me.chkImprimirEnEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImprimirEnEntrada.AutoSize = True
        Me.chkImprimirEnEntrada.Campobd = Nothing
        Me.chkImprimirEnEntrada.ClForm = Nothing
        Me.chkImprimirEnEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimirEnEntrada.ForeColor = System.Drawing.Color.Teal
        Me.chkImprimirEnEntrada.GridLin = Nothing
        Me.chkImprimirEnEntrada.HaCambiado = False
        Me.chkImprimirEnEntrada.Location = New System.Drawing.Point(22, 223)
        Me.chkImprimirEnEntrada.MiEntidad = Nothing
        Me.chkImprimirEnEntrada.MiError = False
        Me.chkImprimirEnEntrada.Name = "chkImprimirEnEntrada"
        Me.chkImprimirEnEntrada.Orden = 0
        Me.chkImprimirEnEntrada.SaltoAlfinal = False
        Me.chkImprimirEnEntrada.Size = New System.Drawing.Size(173, 20)
        Me.chkImprimirEnEntrada.TabIndex = 100272
        Me.chkImprimirEnEntrada.Text = "Imprimir en entrada"
        Me.chkImprimirEnEntrada.UseVisualStyleBackColor = True
        Me.chkImprimirEnEntrada.ValorCampoFalse = Nothing
        Me.chkImprimirEnEntrada.ValorCampoTrue = Nothing
        Me.chkImprimirEnEntrada.ValorDefecto = False
        '
        'FrmTiposdeGastosAgri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 301)
        Me.Controls.Add(Me.chkImprimirEnEntrada)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.CbFaccom)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.BtBuscaAcreedor)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.BtBuscaGrupo)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.BotonesAvance1)
        Me.Controls.Add(Me.BtBuscaTgasto)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.CbBox1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmTiposdeGastosAgri"
        Me.Text = "Gastos agricultores"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.CbBox1, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaTgasto, 0)
        Me.Controls.SetChildIndex(Me.BotonesAvance1, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaGrupo, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaAcreedor, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.CbFaccom, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.chkImprimirEnEntrada, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents CbBox1 As NetAgro.CbBox
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BotonesAvance1 As NetAgro.BotonesAvance
    Friend WithEvents BtBuscaTgasto As NetAgro.BtBusca
    Friend WithEvents BtBuscaGrupo As NetAgro.BtBusca
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents BtBuscaAcreedor As NetAgro.BtBusca
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents CbFaccom As NetAgro.CbBox
    Friend WithEvents chkImprimirEnEntrada As NetAgro.Chk
End Class
