<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerosFacturadosAgricultores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerosFacturadosAgricultores))
        Me.LbAFecha = New NetAgro.Lb(Me.components)
        Me.TxAFecha = New NetAgro.TxDato(Me.components)
        Me.LbDeFecha = New NetAgro.Lb(Me.components)
        Me.TxDeFecha = New NetAgro.TxDato(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.LbEmpresa = New NetAgro.Lb(Me.components)
        Me.CbEmpresas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxAgricultorHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.LbAAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.TxAgricultorDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDeAgricultor = New NetAgro.Lb(Me.components)
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.LbAAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.TxAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbEmpresa)
        Me.PanelCabecera.Controls.Add(Me.CbEmpresas)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.LbAFecha)
        Me.PanelCabecera.Controls.Add(Me.TxAFecha)
        Me.PanelCabecera.Controls.Add(Me.LbDeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxDeFecha)
        Me.PanelCabecera.Size = New System.Drawing.Size(964, 105)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 108)
        Me.PanelConsulta.Size = New System.Drawing.Size(964, 413)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(664, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(739, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(814, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(889, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(589, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbAFecha
        '
        Me.LbAFecha.AutoSize = True
        Me.LbAFecha.CL_ControlAsociado = Nothing
        Me.LbAFecha.CL_ValorFijo = False
        Me.LbAFecha.ClForm = Nothing
        Me.LbAFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbAFecha.Location = New System.Drawing.Point(222, 75)
        Me.LbAFecha.Name = "LbAFecha"
        Me.LbAFecha.Size = New System.Drawing.Size(66, 16)
        Me.LbAFecha.TabIndex = 100289
        Me.LbAFecha.Text = "A Fecha"
        '
        'TxAFecha
        '
        Me.TxAFecha.Autonumerico = False
        Me.TxAFecha.Buscando = False
        Me.TxAFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAFecha.ClForm = Nothing
        Me.TxAFecha.ClParam = Nothing
        Me.TxAFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAFecha.GridLin = Nothing
        Me.TxAFecha.HaCambiado = False
        Me.TxAFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAFecha.lbbusca = Nothing
        Me.TxAFecha.Location = New System.Drawing.Point(294, 72)
        Me.TxAFecha.MiError = False
        Me.TxAFecha.Name = "TxAFecha"
        Me.TxAFecha.Orden = 0
        Me.TxAFecha.SaltoAlfinal = False
        Me.TxAFecha.Siguiente = 0
        Me.TxAFecha.Size = New System.Drawing.Size(95, 22)
        Me.TxAFecha.TabIndex = 100288
        Me.TxAFecha.TeclaRepetida = False
        Me.TxAFecha.TxDatoFinalSemana = Nothing
        Me.TxAFecha.TxDatoInicioSemana = Nothing
        Me.TxAFecha.UltimoValorValidado = Nothing
        '
        'LbDeFecha
        '
        Me.LbDeFecha.AutoSize = True
        Me.LbDeFecha.CL_ControlAsociado = Nothing
        Me.LbDeFecha.CL_ValorFijo = False
        Me.LbDeFecha.ClForm = Nothing
        Me.LbDeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDeFecha.Location = New System.Drawing.Point(12, 75)
        Me.LbDeFecha.Name = "LbDeFecha"
        Me.LbDeFecha.Size = New System.Drawing.Size(75, 16)
        Me.LbDeFecha.TabIndex = 100285
        Me.LbDeFecha.Text = "De Fecha"
        '
        'TxDeFecha
        '
        Me.TxDeFecha.Autonumerico = False
        Me.TxDeFecha.Buscando = False
        Me.TxDeFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDeFecha.ClForm = Nothing
        Me.TxDeFecha.ClParam = Nothing
        Me.TxDeFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDeFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeFecha.GridLin = Nothing
        Me.TxDeFecha.HaCambiado = False
        Me.TxDeFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDeFecha.lbbusca = Nothing
        Me.TxDeFecha.Location = New System.Drawing.Point(93, 72)
        Me.TxDeFecha.MiError = False
        Me.TxDeFecha.Name = "TxDeFecha"
        Me.TxDeFecha.Orden = 0
        Me.TxDeFecha.SaltoAlfinal = False
        Me.TxDeFecha.Siguiente = 0
        Me.TxDeFecha.Size = New System.Drawing.Size(95, 22)
        Me.TxDeFecha.TabIndex = 100284
        Me.TxDeFecha.TeclaRepetida = False
        Me.TxDeFecha.TxDatoFinalSemana = Nothing
        Me.TxDeFecha.TxDatoInicioSemana = Nothing
        Me.TxDeFecha.UltimoValorValidado = Nothing
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(93, 42)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(63, 22)
        Me.TxSemana.TabIndex = 100310
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(12, 45)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100309
        Me.LbSemana.Text = "Semana"
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.CL_ControlAsociado = Nothing
        Me.LbEmpresa.CL_ValorFijo = True
        Me.LbEmpresa.ClForm = Nothing
        Me.LbEmpresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.ForeColor = System.Drawing.Color.Teal
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 15)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(72, 16)
        Me.LbEmpresa.TabIndex = 100312
        Me.LbEmpresa.Text = "Empresa"
        '
        'CbEmpresas
        '
        Me.CbEmpresas.EditValue = ""
        Me.CbEmpresas.Location = New System.Drawing.Point(93, 13)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbEmpresas.Size = New System.Drawing.Size(296, 20)
        Me.CbEmpresas.TabIndex = 100311
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(632, 72)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(319, 23)
        Me.LbNomAgricultorHasta.TabIndex = 100320
        '
        'TxAgricultorHasta
        '
        Me.TxAgricultorHasta.Autonumerico = False
        Me.TxAgricultorHasta.Buscando = False
        Me.TxAgricultorHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorHasta.ClForm = Nothing
        Me.TxAgricultorHasta.ClParam = Nothing
        Me.TxAgricultorHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorHasta.GridLin = Nothing
        Me.TxAgricultorHasta.HaCambiado = False
        Me.TxAgricultorHasta.lbbusca = Nothing
        Me.TxAgricultorHasta.Location = New System.Drawing.Point(524, 72)
        Me.TxAgricultorHasta.MiError = False
        Me.TxAgricultorHasta.Name = "TxAgricultorHasta"
        Me.TxAgricultorHasta.Orden = 0
        Me.TxAgricultorHasta.SaltoAlfinal = False
        Me.TxAgricultorHasta.Siguiente = 0
        Me.TxAgricultorHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorHasta.TabIndex = 100319
        Me.TxAgricultorHasta.TeclaRepetida = False
        Me.TxAgricultorHasta.TxDatoFinalSemana = Nothing
        Me.TxAgricultorHasta.TxDatoInicioSemana = Nothing
        Me.TxAgricultorHasta.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(593, 72)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 100318
        Me.BtBuscaAgricultorHasta.UseVisualStyleBackColor = True
        '
        'LbAAgricultor
        '
        Me.LbAAgricultor.AutoSize = True
        Me.LbAAgricultor.CL_ControlAsociado = Nothing
        Me.LbAAgricultor.CL_ValorFijo = False
        Me.LbAAgricultor.ClForm = Nothing
        Me.LbAAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbAAgricultor.Location = New System.Drawing.Point(416, 75)
        Me.LbAAgricultor.Name = "LbAAgricultor"
        Me.LbAAgricultor.Size = New System.Drawing.Size(93, 16)
        Me.LbAAgricultor.TabIndex = 100317
        Me.LbAAgricultor.Text = "A Agricultor"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(632, 42)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(319, 23)
        Me.LbNomAgricultorDesde.TabIndex = 100316
        '
        'TxAgricultorDesde
        '
        Me.TxAgricultorDesde.Autonumerico = False
        Me.TxAgricultorDesde.Buscando = False
        Me.TxAgricultorDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAgricultorDesde.ClForm = Nothing
        Me.TxAgricultorDesde.ClParam = Nothing
        Me.TxAgricultorDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAgricultorDesde.GridLin = Nothing
        Me.TxAgricultorDesde.HaCambiado = False
        Me.TxAgricultorDesde.lbbusca = Nothing
        Me.TxAgricultorDesde.Location = New System.Drawing.Point(524, 42)
        Me.TxAgricultorDesde.MiError = False
        Me.TxAgricultorDesde.Name = "TxAgricultorDesde"
        Me.TxAgricultorDesde.Orden = 0
        Me.TxAgricultorDesde.SaltoAlfinal = False
        Me.TxAgricultorDesde.Siguiente = 0
        Me.TxAgricultorDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxAgricultorDesde.TabIndex = 100315
        Me.TxAgricultorDesde.TeclaRepetida = False
        Me.TxAgricultorDesde.TxDatoFinalSemana = Nothing
        Me.TxAgricultorDesde.TxDatoInicioSemana = Nothing
        Me.TxAgricultorDesde.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(593, 42)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 100314
        Me.BtBuscaAgricultorDesde.UseVisualStyleBackColor = True
        '
        'LbDeAgricultor
        '
        Me.LbDeAgricultor.AutoSize = True
        Me.LbDeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDeAgricultor.CL_ValorFijo = False
        Me.LbDeAgricultor.ClForm = Nothing
        Me.LbDeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDeAgricultor.Location = New System.Drawing.Point(416, 45)
        Me.LbDeAgricultor.Name = "LbDeAgricultor"
        Me.LbDeAgricultor.Size = New System.Drawing.Size(102, 16)
        Me.LbDeAgricultor.TabIndex = 100313
        Me.LbDeAgricultor.Text = "De Agricultor"
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(524, 12)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(240, 20)
        Me.cbCentro.TabIndex = 100322
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(416, 13)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100321
        Me.Lb5.Text = "Centro"
        '
        'FrmGenerosFacturadosAgricultores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 561)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmGenerosFacturadosAgricultores"
        Me.Text = "Géneros facturados de agricultores"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.CbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbAFecha As NetAgro.Lb
    Friend WithEvents TxAFecha As NetAgro.TxDato
    Friend WithEvents LbDeFecha As NetAgro.Lb
    Friend WithEvents TxDeFecha As NetAgro.TxDato
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents LbEmpresa As NetAgro.Lb
    Friend WithEvents CbEmpresas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxAgricultorHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents LbAAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents TxAgricultorDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents LbDeAgricultor As NetAgro.Lb
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
