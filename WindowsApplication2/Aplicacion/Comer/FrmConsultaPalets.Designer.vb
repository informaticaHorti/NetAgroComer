<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPalets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPalets))
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.RbNoEnExistencias = New System.Windows.Forms.RadioButton()
        Me.RbEnExistencias = New System.Windows.Forms.RadioButton()
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.CbFamilias = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNumPalets = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTodasEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.rbNOEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.rbEntradasConfeccionadas = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbEnvPropioTodos = New System.Windows.Forms.RadioButton()
        Me.RbEnvPropioNO = New System.Windows.Forms.RadioButton()
        Me.RbEnvPropioSI = New System.Windows.Forms.RadioButton()
        Me.chkMostrarPartidas = New NetAgro.Chk(Me.components)
        Me.RbClientePalet = New System.Windows.Forms.RadioButton()
        Me.RbClienteSalidas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.CbSituacion = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ChkVisualizarMermas = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbSituacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.ChkVisualizarMermas)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.CbSituacion)
        Me.PanelCabecera.Controls.Add(Me.chkMostrarPartidas)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.CbFamilias)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1279, 123)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 126)
        Me.PanelConsulta.Size = New System.Drawing.Size(1279, 374)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(979, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1054, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1129, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1204, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(904, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
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
        Me.TxDato2.Location = New System.Drawing.Point(132, 39)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(102, 22)
        Me.TxDato2.TabIndex = 83
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.TxDatoFinalSemana = Nothing
        Me.TxDato2.TxDatoInicioSemana = Nothing
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(13, 42)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 82
        Me.Lb2.Text = "Hasta fecha"
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
        Me.TxDato1.Location = New System.Drawing.Point(132, 11)
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
        Me.Lb1.Location = New System.Drawing.Point(13, 14)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Desde fecha"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(423, 12)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(240, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = True
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(286, 14)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(131, 16)
        Me.Lb3.TabIndex = 100272
        Me.Lb3.Text = "P.Venta creación"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTodos)
        Me.GroupBox2.Controls.Add(Me.RbNoEnExistencias)
        Me.GroupBox2.Controls.Add(Me.RbEnExistencias)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(537, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "En existencias"
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbTodos.Location = New System.Drawing.Point(154, 16)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbTodos.TabIndex = 2
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'RbNoEnExistencias
        '
        Me.RbNoEnExistencias.AutoSize = True
        Me.RbNoEnExistencias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoEnExistencias.ForeColor = System.Drawing.Color.Teal
        Me.RbNoEnExistencias.Location = New System.Drawing.Point(79, 16)
        Me.RbNoEnExistencias.Name = "RbNoEnExistencias"
        Me.RbNoEnExistencias.Size = New System.Drawing.Size(47, 20)
        Me.RbNoEnExistencias.TabIndex = 1
        Me.RbNoEnExistencias.Text = "NO"
        Me.RbNoEnExistencias.UseVisualStyleBackColor = True
        '
        'RbEnExistencias
        '
        Me.RbEnExistencias.AutoSize = True
        Me.RbEnExistencias.Checked = True
        Me.RbEnExistencias.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnExistencias.ForeColor = System.Drawing.Color.Teal
        Me.RbEnExistencias.Location = New System.Drawing.Point(16, 16)
        Me.RbEnExistencias.Name = "RbEnExistencias"
        Me.RbEnExistencias.Size = New System.Drawing.Size(41, 20)
        Me.RbEnExistencias.TabIndex = 0
        Me.RbEnExistencias.TabStop = True
        Me.RbEnExistencias.Text = "SI"
        Me.RbEnExistencias.UseVisualStyleBackColor = True
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(703, 14)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(69, 16)
        Me.Lb4.TabIndex = 100275
        Me.Lb4.Text = "Familias"
        '
        'CbFamilias
        '
        Me.CbFamilias.EditValue = ""
        Me.CbFamilias.Location = New System.Drawing.Point(778, 12)
        Me.CbFamilias.Name = "CbFamilias"
        Me.CbFamilias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbFamilias.Size = New System.Drawing.Size(203, 20)
        Me.CbFamilias.TabIndex = 100274
        '
        'LbNumPalets
        '
        Me.LbNumPalets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbNumPalets.AutoSize = True
        Me.LbNumPalets.BackColor = System.Drawing.Color.Transparent
        Me.LbNumPalets.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumPalets.ForeColor = System.Drawing.Color.Blue
        Me.LbNumPalets.Location = New System.Drawing.Point(7, 507)
        Me.LbNumPalets.Name = "LbNumPalets"
        Me.LbNumPalets.Size = New System.Drawing.Size(95, 18)
        Me.LbNumPalets.TabIndex = 11
        Me.LbNumPalets.Text = "Nº Palets:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTodasEntradasConfeccionadas)
        Me.GroupBox3.Controls.Add(Me.rbNOEntradasConfeccionadas)
        Me.GroupBox3.Controls.Add(Me.rbEntradasConfeccionadas)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(786, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox3.TabIndex = 100277
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entradas directas"
        '
        'rbTodasEntradasConfeccionadas
        '
        Me.rbTodasEntradasConfeccionadas.AutoSize = True
        Me.rbTodasEntradasConfeccionadas.Checked = True
        Me.rbTodasEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodasEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbTodasEntradasConfeccionadas.Location = New System.Drawing.Point(154, 16)
        Me.rbTodasEntradasConfeccionadas.Name = "rbTodasEntradasConfeccionadas"
        Me.rbTodasEntradasConfeccionadas.Size = New System.Drawing.Size(69, 20)
        Me.rbTodasEntradasConfeccionadas.TabIndex = 2
        Me.rbTodasEntradasConfeccionadas.TabStop = True
        Me.rbTodasEntradasConfeccionadas.Text = "Todos"
        Me.rbTodasEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'rbNOEntradasConfeccionadas
        '
        Me.rbNOEntradasConfeccionadas.AutoSize = True
        Me.rbNOEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbNOEntradasConfeccionadas.Location = New System.Drawing.Point(79, 16)
        Me.rbNOEntradasConfeccionadas.Name = "rbNOEntradasConfeccionadas"
        Me.rbNOEntradasConfeccionadas.Size = New System.Drawing.Size(47, 20)
        Me.rbNOEntradasConfeccionadas.TabIndex = 1
        Me.rbNOEntradasConfeccionadas.Text = "NO"
        Me.rbNOEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'rbEntradasConfeccionadas
        '
        Me.rbEntradasConfeccionadas.AutoSize = True
        Me.rbEntradasConfeccionadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEntradasConfeccionadas.ForeColor = System.Drawing.Color.Teal
        Me.rbEntradasConfeccionadas.Location = New System.Drawing.Point(16, 16)
        Me.rbEntradasConfeccionadas.Name = "rbEntradasConfeccionadas"
        Me.rbEntradasConfeccionadas.Size = New System.Drawing.Size(41, 20)
        Me.rbEntradasConfeccionadas.TabIndex = 0
        Me.rbEntradasConfeccionadas.Text = "SI"
        Me.rbEntradasConfeccionadas.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbEnvPropioTodos)
        Me.GroupBox4.Controls.Add(Me.RbEnvPropioNO)
        Me.GroupBox4.Controls.Add(Me.RbEnvPropioSI)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(1026, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox4.TabIndex = 100278
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Envase propio"
        '
        'RbEnvPropioTodos
        '
        Me.RbEnvPropioTodos.AutoSize = True
        Me.RbEnvPropioTodos.Checked = True
        Me.RbEnvPropioTodos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnvPropioTodos.ForeColor = System.Drawing.Color.Teal
        Me.RbEnvPropioTodos.Location = New System.Drawing.Point(154, 16)
        Me.RbEnvPropioTodos.Name = "RbEnvPropioTodos"
        Me.RbEnvPropioTodos.Size = New System.Drawing.Size(69, 20)
        Me.RbEnvPropioTodos.TabIndex = 2
        Me.RbEnvPropioTodos.TabStop = True
        Me.RbEnvPropioTodos.Text = "Todos"
        Me.RbEnvPropioTodos.UseVisualStyleBackColor = True
        '
        'RbEnvPropioNO
        '
        Me.RbEnvPropioNO.AutoSize = True
        Me.RbEnvPropioNO.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnvPropioNO.ForeColor = System.Drawing.Color.Teal
        Me.RbEnvPropioNO.Location = New System.Drawing.Point(79, 16)
        Me.RbEnvPropioNO.Name = "RbEnvPropioNO"
        Me.RbEnvPropioNO.Size = New System.Drawing.Size(47, 20)
        Me.RbEnvPropioNO.TabIndex = 1
        Me.RbEnvPropioNO.Text = "NO"
        Me.RbEnvPropioNO.UseVisualStyleBackColor = True
        '
        'RbEnvPropioSI
        '
        Me.RbEnvPropioSI.AutoSize = True
        Me.RbEnvPropioSI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEnvPropioSI.ForeColor = System.Drawing.Color.Teal
        Me.RbEnvPropioSI.Location = New System.Drawing.Point(16, 16)
        Me.RbEnvPropioSI.Name = "RbEnvPropioSI"
        Me.RbEnvPropioSI.Size = New System.Drawing.Size(41, 20)
        Me.RbEnvPropioSI.TabIndex = 0
        Me.RbEnvPropioSI.Text = "SI"
        Me.RbEnvPropioSI.UseVisualStyleBackColor = True
        '
        'chkMostrarPartidas
        '
        Me.chkMostrarPartidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMostrarPartidas.AutoSize = True
        Me.chkMostrarPartidas.Campobd = Nothing
        Me.chkMostrarPartidas.ClForm = Nothing
        Me.chkMostrarPartidas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarPartidas.ForeColor = System.Drawing.Color.Teal
        Me.chkMostrarPartidas.GridLin = Nothing
        Me.chkMostrarPartidas.HaCambiado = False
        Me.chkMostrarPartidas.Location = New System.Drawing.Point(1030, 12)
        Me.chkMostrarPartidas.MiEntidad = Nothing
        Me.chkMostrarPartidas.MiError = False
        Me.chkMostrarPartidas.Name = "chkMostrarPartidas"
        Me.chkMostrarPartidas.Orden = 0
        Me.chkMostrarPartidas.SaltoAlfinal = False
        Me.chkMostrarPartidas.Size = New System.Drawing.Size(246, 20)
        Me.chkMostrarPartidas.TabIndex = 100279
        Me.chkMostrarPartidas.Text = "Mostrar partidas en el informe"
        Me.chkMostrarPartidas.UseVisualStyleBackColor = True
        Me.chkMostrarPartidas.ValorCampoFalse = Nothing
        Me.chkMostrarPartidas.ValorCampoTrue = Nothing
        Me.chkMostrarPartidas.ValorDefecto = False
        '
        'RbClientePalet
        '
        Me.RbClientePalet.AutoSize = True
        Me.RbClientePalet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbClientePalet.ForeColor = System.Drawing.Color.Teal
        Me.RbClientePalet.Location = New System.Drawing.Point(16, 16)
        Me.RbClientePalet.Name = "RbClientePalet"
        Me.RbClientePalet.Size = New System.Drawing.Size(75, 20)
        Me.RbClientePalet.TabIndex = 0
        Me.RbClientePalet.Text = "Pedido"
        Me.RbClientePalet.UseVisualStyleBackColor = True
        '
        'RbClienteSalidas
        '
        Me.RbClienteSalidas.AutoSize = True
        Me.RbClienteSalidas.Checked = True
        Me.RbClienteSalidas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbClienteSalidas.ForeColor = System.Drawing.Color.Teal
        Me.RbClienteSalidas.Location = New System.Drawing.Point(121, 16)
        Me.RbClienteSalidas.Name = "RbClienteSalidas"
        Me.RbClienteSalidas.Size = New System.Drawing.Size(78, 20)
        Me.RbClienteSalidas.TabIndex = 1
        Me.RbClienteSalidas.TabStop = True
        Me.RbClienteSalidas.Text = "Salidas"
        Me.RbClienteSalidas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbClienteSalidas)
        Me.GroupBox1.Controls.Add(Me.RbClientePalet)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(289, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 42)
        Me.GroupBox1.TabIndex = 100276
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imprimir cliente"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(342, 42)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(75, 16)
        Me.Lb5.TabIndex = 100281
        Me.Lb5.Text = "Situación"
        '
        'CbSituacion
        '
        Me.CbSituacion.EditValue = ""
        Me.CbSituacion.Location = New System.Drawing.Point(423, 40)
        Me.CbSituacion.Name = "CbSituacion"
        Me.CbSituacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbSituacion.Size = New System.Drawing.Size(240, 20)
        Me.CbSituacion.TabIndex = 100280
        '
        'ChkVisualizarMermas
        '
        Me.ChkVisualizarMermas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkVisualizarMermas.AutoSize = True
        Me.ChkVisualizarMermas.Campobd = Nothing
        Me.ChkVisualizarMermas.ClForm = Nothing
        Me.ChkVisualizarMermas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVisualizarMermas.ForeColor = System.Drawing.Color.Teal
        Me.ChkVisualizarMermas.GridLin = Nothing
        Me.ChkVisualizarMermas.HaCambiado = False
        Me.ChkVisualizarMermas.Location = New System.Drawing.Point(1030, 40)
        Me.ChkVisualizarMermas.MiEntidad = Nothing
        Me.ChkVisualizarMermas.MiError = False
        Me.ChkVisualizarMermas.Name = "ChkVisualizarMermas"
        Me.ChkVisualizarMermas.Orden = 0
        Me.ChkVisualizarMermas.SaltoAlfinal = False
        Me.ChkVisualizarMermas.Size = New System.Drawing.Size(162, 20)
        Me.ChkVisualizarMermas.TabIndex = 100282
        Me.ChkVisualizarMermas.Text = "Visualizar mermas"
        Me.ChkVisualizarMermas.UseVisualStyleBackColor = True
        Me.ChkVisualizarMermas.ValorCampoFalse = Nothing
        Me.ChkVisualizarMermas.ValorCampoTrue = Nothing
        Me.ChkVisualizarMermas.ValorDefecto = False
        '
        'FrmConsultaPalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 562)
        Me.Controls.Add(Me.LbNumPalets)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsultaPalets"
        Me.Text = "Consulta palets"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.LbNumPalets, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbFamilias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbSituacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoEnExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents CbFamilias As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbNumPalets As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodasEntradasConfeccionadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbNOEntradasConfeccionadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbEntradasConfeccionadas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbEnvPropioTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnvPropioNO As System.Windows.Forms.RadioButton
    Friend WithEvents RbEnvPropioSI As System.Windows.Forms.RadioButton
    Friend WithEvents chkMostrarPartidas As NetAgro.Chk
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbClienteSalidas As System.Windows.Forms.RadioButton
    Friend WithEvents RbClientePalet As System.Windows.Forms.RadioButton
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents CbSituacion As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ChkVisualizarMermas As NetAgro.Chk
End Class
