<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoAlbaranesSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoAlbaranesSalida))
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.cbPuntoVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LbPuntoVenta = New NetAgro.Lb(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTODOSValorados = New System.Windows.Forms.RadioButton()
        Me.RbNoValorados = New System.Windows.Forms.RadioButton()
        Me.RbSiValorados = New System.Windows.Forms.RadioButton()
        Me.TxAlbaranHasta = New NetAgro.TxDato(Me.components)
        Me.LbDesdeAlbaran = New NetAgro.Lb(Me.components)
        Me.LbHastaAlbaran = New NetAgro.Lb(Me.components)
        Me.TxAlbaranDesde = New NetAgro.TxDato(Me.components)
        Me.LbNomGeneroHasta = New NetAgro.Lb(Me.components)
        Me.TxGeneroHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaGenero = New NetAgro.Lb(Me.components)
        Me.LbNomGeneroDesde = New NetAgro.Lb(Me.components)
        Me.TxGeneroDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaGeneroDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeGenero = New NetAgro.Lb(Me.components)
        Me.TxCategHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCategHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaCateg = New NetAgro.Lb(Me.components)
        Me.TxCategDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCategDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeCateg = New NetAgro.Lb(Me.components)
        Me.LbNomCategDesde = New NetAgro.Lb(Me.components)
        Me.LbNomCategHasta = New NetAgro.Lb(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTODOSFacturado = New System.Windows.Forms.RadioButton()
        Me.RbNOFacturado = New System.Windows.Forms.RadioButton()
        Me.RbSIFacturado = New System.Windows.Forms.RadioButton()
        Me.LbTipoListado = New NetAgro.Lb(Me.components)
        Me.CbTipoListado = New NetAgro.CbBox(Me.components)
        Me.BtBuscaAlbaranHasta = New NetAgro.BtBusca(Me.components)
        Me.BtBuscaAlbaranDesde = New NetAgro.BtBusca(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbTODOSPrecioSalida = New System.Windows.Forms.RadioButton()
        Me.RbNOPrecioSalida = New System.Windows.Forms.RadioButton()
        Me.RbSIPrecioSalida = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbTodasVentas = New System.Windows.Forms.RadioButton()
        Me.RbVtaComision = New System.Windows.Forms.RadioButton()
        Me.RbVtaFirme = New System.Windows.Forms.RadioButton()
        Me.LbNomDomicilioHasta = New NetAgro.Lb(Me.components)
        Me.TxDomicilioHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDomicilioHasta = New NetAgro.BtBusca(Me.components)
        Me.LbDomicilioHasta = New NetAgro.Lb(Me.components)
        Me.LbNomDomicilioDesde = New NetAgro.Lb(Me.components)
        Me.TxDomicilioDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaDomicilioDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDomicilioDesde = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorHasta = New NetAgro.Lb(Me.components)
        Me.TxClienteHasta = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorHasta = New NetAgro.BtBusca(Me.components)
        Me.LbHastaAgricultor = New NetAgro.Lb(Me.components)
        Me.LbNomAgricultorDesde = New NetAgro.Lb(Me.components)
        Me.TxClienteDesde = New NetAgro.TxDato(Me.components)
        Me.BtBuscaAgricultorDesde = New NetAgro.BtBusca(Me.components)
        Me.LbDesdeAgricultor = New NetAgro.Lb(Me.components)
        Me.ChkDesgloseRechazos = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.ChkDesgloseRechazos)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.TxClienteHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.TxClienteDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgricultorDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbNomDomicilioHasta)
        Me.PanelCabecera.Controls.Add(Me.TxDomicilioHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDomicilioHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDomicilioHasta)
        Me.PanelCabecera.Controls.Add(Me.LbNomDomicilioDesde)
        Me.PanelCabecera.Controls.Add(Me.TxDomicilioDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaDomicilioDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDomicilioDesde)
        Me.PanelCabecera.Controls.Add(Me.GroupBox4)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaranHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAlbaranDesde)
        Me.PanelCabecera.Controls.Add(Me.TxCategHasta)
        Me.PanelCabecera.Controls.Add(Me.TxCategDesde)
        Me.PanelCabecera.Controls.Add(Me.CbTipoListado)
        Me.PanelCabecera.Controls.Add(Me.LbTipoListado)
        Me.PanelCabecera.Controls.Add(Me.GroupBox3)
        Me.PanelCabecera.Controls.Add(Me.LbNomCategHasta)
        Me.PanelCabecera.Controls.Add(Me.LbNomCategDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCategHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaCateg)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCategDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeCateg)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroHasta)
        Me.PanelCabecera.Controls.Add(Me.LbHastaGenero)
        Me.PanelCabecera.Controls.Add(Me.LbNomGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.TxGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaGeneroDesde)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeGenero)
        Me.PanelCabecera.Controls.Add(Me.TxAlbaranHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeAlbaran)
        Me.PanelCabecera.Controls.Add(Me.LbHastaAlbaran)
        Me.PanelCabecera.Controls.Add(Me.TxAlbaranDesde)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.LbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.cbPuntoVenta)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1234, 215)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 212)
        Me.PanelConsulta.Size = New System.Drawing.Size(1234, 310)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(934, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1009, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1084, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1159, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(859, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'TxFechaHasta
        '
        Me.TxFechaHasta.Autonumerico = False
        Me.TxFechaHasta.Buscando = False
        Me.TxFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaHasta.ClForm = Nothing
        Me.TxFechaHasta.ClParam = Nothing
        Me.TxFechaHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaHasta.GridLin = Nothing
        Me.TxFechaHasta.HaCambiado = False
        Me.TxFechaHasta.lbbusca = Nothing
        Me.TxFechaHasta.Location = New System.Drawing.Point(835, 34)
        Me.TxFechaHasta.MiError = False
        Me.TxFechaHasta.Name = "TxFechaHasta"
        Me.TxFechaHasta.Orden = 0
        Me.TxFechaHasta.SaltoAlfinal = False
        Me.TxFechaHasta.Siguiente = 0
        Me.TxFechaHasta.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaHasta.TabIndex = 83
        Me.TxFechaHasta.TeclaRepetida = False
        Me.TxFechaHasta.TxDatoFinalSemana = Nothing
        Me.TxFechaHasta.TxDatoInicioSemana = Nothing
        Me.TxFechaHasta.UltimoValorValidado = Nothing
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(732, 37)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 82
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxFechaDesde
        '
        Me.TxFechaDesde.Autonumerico = False
        Me.TxFechaDesde.Buscando = False
        Me.TxFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaDesde.ClForm = Nothing
        Me.TxFechaDesde.ClParam = Nothing
        Me.TxFechaDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaDesde.GridLin = Nothing
        Me.TxFechaDesde.HaCambiado = False
        Me.TxFechaDesde.lbbusca = Nothing
        Me.TxFechaDesde.Location = New System.Drawing.Point(835, 9)
        Me.TxFechaDesde.MiError = False
        Me.TxFechaDesde.Name = "TxFechaDesde"
        Me.TxFechaDesde.Orden = 0
        Me.TxFechaDesde.SaltoAlfinal = False
        Me.TxFechaDesde.Siguiente = 0
        Me.TxFechaDesde.Size = New System.Drawing.Size(102, 22)
        Me.TxFechaDesde.TabIndex = 81
        Me.TxFechaDesde.TeclaRepetida = False
        Me.TxFechaDesde.TxDatoFinalSemana = Nothing
        Me.TxFechaDesde.TxDatoInicioSemana = Nothing
        Me.TxFechaDesde.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(732, 12)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 80
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'cbPuntoVenta
        '
        Me.cbPuntoVenta.EditValue = ""
        Me.cbPuntoVenta.Location = New System.Drawing.Point(835, 138)
        Me.cbPuntoVenta.Name = "cbPuntoVenta"
        Me.cbPuntoVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPuntoVenta.Size = New System.Drawing.Size(378, 20)
        Me.cbPuntoVenta.TabIndex = 100270
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.CL_ControlAsociado = Nothing
        Me.LbPuntoVenta.CL_ValorFijo = True
        Me.LbPuntoVenta.ClForm = Nothing
        Me.LbPuntoVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPuntoVenta.ForeColor = System.Drawing.Color.Teal
        Me.LbPuntoVenta.Location = New System.Drawing.Point(732, 140)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(96, 16)
        Me.LbPuntoVenta.TabIndex = 100272
        Me.LbPuntoVenta.Text = "Punto venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTODOSValorados)
        Me.GroupBox2.Controls.Add(Me.RbNoValorados)
        Me.GroupBox2.Controls.Add(Me.RbSiValorados)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(820, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox2.TabIndex = 100273
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valorados"
        '
        'RbTODOSValorados
        '
        Me.RbTODOSValorados.AutoSize = True
        Me.RbTODOSValorados.Checked = True
        Me.RbTODOSValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODOSValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbTODOSValorados.Location = New System.Drawing.Point(114, 16)
        Me.RbTODOSValorados.Name = "RbTODOSValorados"
        Me.RbTODOSValorados.Size = New System.Drawing.Size(69, 20)
        Me.RbTODOSValorados.TabIndex = 2
        Me.RbTODOSValorados.TabStop = True
        Me.RbTODOSValorados.Text = "Todos"
        Me.RbTODOSValorados.UseVisualStyleBackColor = True
        '
        'RbNoValorados
        '
        Me.RbNoValorados.AutoSize = True
        Me.RbNoValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbNoValorados.Location = New System.Drawing.Point(63, 16)
        Me.RbNoValorados.Name = "RbNoValorados"
        Me.RbNoValorados.Size = New System.Drawing.Size(47, 20)
        Me.RbNoValorados.TabIndex = 1
        Me.RbNoValorados.Text = "NO"
        Me.RbNoValorados.UseVisualStyleBackColor = True
        '
        'RbSiValorados
        '
        Me.RbSiValorados.AutoSize = True
        Me.RbSiValorados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiValorados.ForeColor = System.Drawing.Color.Teal
        Me.RbSiValorados.Location = New System.Drawing.Point(16, 16)
        Me.RbSiValorados.Name = "RbSiValorados"
        Me.RbSiValorados.Size = New System.Drawing.Size(41, 20)
        Me.RbSiValorados.TabIndex = 0
        Me.RbSiValorados.Text = "SI"
        Me.RbSiValorados.UseVisualStyleBackColor = True
        '
        'TxAlbaranHasta
        '
        Me.TxAlbaranHasta.Autonumerico = False
        Me.TxAlbaranHasta.Buscando = False
        Me.TxAlbaranHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlbaranHasta.ClForm = Nothing
        Me.TxAlbaranHasta.ClParam = Nothing
        Me.TxAlbaranHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlbaranHasta.GridLin = Nothing
        Me.TxAlbaranHasta.HaCambiado = False
        Me.TxAlbaranHasta.lbbusca = Nothing
        Me.TxAlbaranHasta.Location = New System.Drawing.Point(1073, 34)
        Me.TxAlbaranHasta.MiError = False
        Me.TxAlbaranHasta.Name = "TxAlbaranHasta"
        Me.TxAlbaranHasta.Orden = 0
        Me.TxAlbaranHasta.SaltoAlfinal = False
        Me.TxAlbaranHasta.Siguiente = 0
        Me.TxAlbaranHasta.Size = New System.Drawing.Size(102, 22)
        Me.TxAlbaranHasta.TabIndex = 100279
        Me.TxAlbaranHasta.TeclaRepetida = False
        Me.TxAlbaranHasta.TxDatoFinalSemana = Nothing
        Me.TxAlbaranHasta.TxDatoInicioSemana = Nothing
        Me.TxAlbaranHasta.UltimoValorValidado = Nothing
        '
        'LbDesdeAlbaran
        '
        Me.LbDesdeAlbaran.AutoSize = True
        Me.LbDesdeAlbaran.CL_ControlAsociado = Nothing
        Me.LbDesdeAlbaran.CL_ValorFijo = False
        Me.LbDesdeAlbaran.ClForm = Nothing
        Me.LbDesdeAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAlbaran.Location = New System.Drawing.Point(955, 12)
        Me.LbDesdeAlbaran.Name = "LbDesdeAlbaran"
        Me.LbDesdeAlbaran.Size = New System.Drawing.Size(112, 16)
        Me.LbDesdeAlbaran.TabIndex = 100276
        Me.LbDesdeAlbaran.Text = "Desde albarán"
        '
        'LbHastaAlbaran
        '
        Me.LbHastaAlbaran.AutoSize = True
        Me.LbHastaAlbaran.CL_ControlAsociado = Nothing
        Me.LbHastaAlbaran.CL_ValorFijo = False
        Me.LbHastaAlbaran.ClForm = Nothing
        Me.LbHastaAlbaran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAlbaran.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAlbaran.Location = New System.Drawing.Point(955, 37)
        Me.LbHastaAlbaran.Name = "LbHastaAlbaran"
        Me.LbHastaAlbaran.Size = New System.Drawing.Size(110, 16)
        Me.LbHastaAlbaran.TabIndex = 100278
        Me.LbHastaAlbaran.Text = "Hasta albarán"
        '
        'TxAlbaranDesde
        '
        Me.TxAlbaranDesde.Autonumerico = False
        Me.TxAlbaranDesde.Buscando = False
        Me.TxAlbaranDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlbaranDesde.ClForm = Nothing
        Me.TxAlbaranDesde.ClParam = Nothing
        Me.TxAlbaranDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlbaranDesde.GridLin = Nothing
        Me.TxAlbaranDesde.HaCambiado = False
        Me.TxAlbaranDesde.lbbusca = Nothing
        Me.TxAlbaranDesde.Location = New System.Drawing.Point(1073, 9)
        Me.TxAlbaranDesde.MiError = False
        Me.TxAlbaranDesde.Name = "TxAlbaranDesde"
        Me.TxAlbaranDesde.Orden = 0
        Me.TxAlbaranDesde.SaltoAlfinal = False
        Me.TxAlbaranDesde.Siguiente = 0
        Me.TxAlbaranDesde.Size = New System.Drawing.Size(102, 22)
        Me.TxAlbaranDesde.TabIndex = 100277
        Me.TxAlbaranDesde.TeclaRepetida = False
        Me.TxAlbaranDesde.TxDatoFinalSemana = Nothing
        Me.TxAlbaranDesde.TxDatoInicioSemana = Nothing
        Me.TxAlbaranDesde.UltimoValorValidado = Nothing
        '
        'LbNomGeneroHasta
        '
        Me.LbNomGeneroHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroHasta.CL_ControlAsociado = Nothing
        Me.LbNomGeneroHasta.CL_ValorFijo = False
        Me.LbNomGeneroHasta.ClForm = Nothing
        Me.LbNomGeneroHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroHasta.Location = New System.Drawing.Point(254, 84)
        Me.LbNomGeneroHasta.Name = "LbNomGeneroHasta"
        Me.LbNomGeneroHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomGeneroHasta.TabIndex = 100287
        '
        'TxGeneroHasta
        '
        Me.TxGeneroHasta.Autonumerico = False
        Me.TxGeneroHasta.Buscando = False
        Me.TxGeneroHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGeneroHasta.ClForm = Nothing
        Me.TxGeneroHasta.ClParam = Nothing
        Me.TxGeneroHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGeneroHasta.GridLin = Nothing
        Me.TxGeneroHasta.HaCambiado = False
        Me.TxGeneroHasta.lbbusca = Nothing
        Me.TxGeneroHasta.Location = New System.Drawing.Point(146, 84)
        Me.TxGeneroHasta.MiError = False
        Me.TxGeneroHasta.Name = "TxGeneroHasta"
        Me.TxGeneroHasta.Orden = 0
        Me.TxGeneroHasta.SaltoAlfinal = False
        Me.TxGeneroHasta.Siguiente = 0
        Me.TxGeneroHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxGeneroHasta.TabIndex = 100286
        Me.TxGeneroHasta.TeclaRepetida = False
        Me.TxGeneroHasta.TxDatoFinalSemana = Nothing
        Me.TxGeneroHasta.TxDatoInicioSemana = Nothing
        Me.TxGeneroHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroHasta
        '
        Me.BtBuscaGeneroHasta.CL_Ancho = 0
        Me.BtBuscaGeneroHasta.CL_BuscaAlb = False
        Me.BtBuscaGeneroHasta.CL_campocodigo = Nothing
        Me.BtBuscaGeneroHasta.CL_camponombre = Nothing
        Me.BtBuscaGeneroHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroHasta.CL_ch1000 = False
        Me.BtBuscaGeneroHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroHasta.CL_dfecha = Nothing
        Me.BtBuscaGeneroHasta.CL_Entidad = Nothing
        Me.BtBuscaGeneroHasta.CL_EsId = True
        Me.BtBuscaGeneroHasta.CL_Filtro = Nothing
        Me.BtBuscaGeneroHasta.cl_formu = Nothing
        Me.BtBuscaGeneroHasta.CL_hfecha = Nothing
        Me.BtBuscaGeneroHasta.cl_ListaW = Nothing
        Me.BtBuscaGeneroHasta.CL_xCentro = False
        Me.BtBuscaGeneroHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroHasta.Location = New System.Drawing.Point(215, 84)
        Me.BtBuscaGeneroHasta.Name = "BtBuscaGeneroHasta"
        Me.BtBuscaGeneroHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroHasta.TabIndex = 100285
        Me.BtBuscaGeneroHasta.UseVisualStyleBackColor = True
        '
        'LbHastaGenero
        '
        Me.LbHastaGenero.AutoSize = True
        Me.LbHastaGenero.CL_ControlAsociado = Nothing
        Me.LbHastaGenero.CL_ValorFijo = False
        Me.LbHastaGenero.ClForm = Nothing
        Me.LbHastaGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaGenero.Location = New System.Drawing.Point(12, 87)
        Me.LbHastaGenero.Name = "LbHastaGenero"
        Me.LbHastaGenero.Size = New System.Drawing.Size(107, 16)
        Me.LbHastaGenero.TabIndex = 100284
        Me.LbHastaGenero.Text = "Hasta Género"
        '
        'LbNomGeneroDesde
        '
        Me.LbNomGeneroDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomGeneroDesde.CL_ControlAsociado = Nothing
        Me.LbNomGeneroDesde.CL_ValorFijo = False
        Me.LbNomGeneroDesde.ClForm = Nothing
        Me.LbNomGeneroDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomGeneroDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomGeneroDesde.Location = New System.Drawing.Point(254, 59)
        Me.LbNomGeneroDesde.Name = "LbNomGeneroDesde"
        Me.LbNomGeneroDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomGeneroDesde.TabIndex = 100283
        '
        'TxGeneroDesde
        '
        Me.TxGeneroDesde.Autonumerico = False
        Me.TxGeneroDesde.Buscando = False
        Me.TxGeneroDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGeneroDesde.ClForm = Nothing
        Me.TxGeneroDesde.ClParam = Nothing
        Me.TxGeneroDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxGeneroDesde.GridLin = Nothing
        Me.TxGeneroDesde.HaCambiado = False
        Me.TxGeneroDesde.lbbusca = Nothing
        Me.TxGeneroDesde.Location = New System.Drawing.Point(146, 59)
        Me.TxGeneroDesde.MiError = False
        Me.TxGeneroDesde.Name = "TxGeneroDesde"
        Me.TxGeneroDesde.Orden = 0
        Me.TxGeneroDesde.SaltoAlfinal = False
        Me.TxGeneroDesde.Siguiente = 0
        Me.TxGeneroDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxGeneroDesde.TabIndex = 100282
        Me.TxGeneroDesde.TeclaRepetida = False
        Me.TxGeneroDesde.TxDatoFinalSemana = Nothing
        Me.TxGeneroDesde.TxDatoInicioSemana = Nothing
        Me.TxGeneroDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaGeneroDesde
        '
        Me.BtBuscaGeneroDesde.CL_Ancho = 0
        Me.BtBuscaGeneroDesde.CL_BuscaAlb = False
        Me.BtBuscaGeneroDesde.CL_campocodigo = Nothing
        Me.BtBuscaGeneroDesde.CL_camponombre = Nothing
        Me.BtBuscaGeneroDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaGeneroDesde.CL_ch1000 = False
        Me.BtBuscaGeneroDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaGeneroDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaGeneroDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaGeneroDesde.CL_dfecha = Nothing
        Me.BtBuscaGeneroDesde.CL_Entidad = Nothing
        Me.BtBuscaGeneroDesde.CL_EsId = True
        Me.BtBuscaGeneroDesde.CL_Filtro = Nothing
        Me.BtBuscaGeneroDesde.cl_formu = Nothing
        Me.BtBuscaGeneroDesde.CL_hfecha = Nothing
        Me.BtBuscaGeneroDesde.cl_ListaW = Nothing
        Me.BtBuscaGeneroDesde.CL_xCentro = False
        Me.BtBuscaGeneroDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaGeneroDesde.Location = New System.Drawing.Point(215, 59)
        Me.BtBuscaGeneroDesde.Name = "BtBuscaGeneroDesde"
        Me.BtBuscaGeneroDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaGeneroDesde.TabIndex = 100281
        Me.BtBuscaGeneroDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeGenero
        '
        Me.LbDesdeGenero.AutoSize = True
        Me.LbDesdeGenero.CL_ControlAsociado = Nothing
        Me.LbDesdeGenero.CL_ValorFijo = False
        Me.LbDesdeGenero.ClForm = Nothing
        Me.LbDesdeGenero.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeGenero.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeGenero.Location = New System.Drawing.Point(12, 62)
        Me.LbDesdeGenero.Name = "LbDesdeGenero"
        Me.LbDesdeGenero.Size = New System.Drawing.Size(109, 16)
        Me.LbDesdeGenero.TabIndex = 100280
        Me.LbDesdeGenero.Text = "Desde Genero"
        '
        'TxCategHasta
        '
        Me.TxCategHasta.Autonumerico = False
        Me.TxCategHasta.Buscando = False
        Me.TxCategHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategHasta.ClForm = Nothing
        Me.TxCategHasta.ClParam = Nothing
        Me.TxCategHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategHasta.GridLin = Nothing
        Me.TxCategHasta.HaCambiado = False
        Me.TxCategHasta.lbbusca = Nothing
        Me.TxCategHasta.Location = New System.Drawing.Point(835, 84)
        Me.TxCategHasta.MiError = False
        Me.TxCategHasta.Name = "TxCategHasta"
        Me.TxCategHasta.Orden = 0
        Me.TxCategHasta.SaltoAlfinal = False
        Me.TxCategHasta.Siguiente = 0
        Me.TxCategHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxCategHasta.TabIndex = 100293
        Me.TxCategHasta.TeclaRepetida = False
        Me.TxCategHasta.TxDatoFinalSemana = Nothing
        Me.TxCategHasta.TxDatoInicioSemana = Nothing
        Me.TxCategHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaCategHasta
        '
        Me.BtBuscaCategHasta.CL_Ancho = 0
        Me.BtBuscaCategHasta.CL_BuscaAlb = False
        Me.BtBuscaCategHasta.CL_campocodigo = Nothing
        Me.BtBuscaCategHasta.CL_camponombre = Nothing
        Me.BtBuscaCategHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaCategHasta.CL_ch1000 = False
        Me.BtBuscaCategHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCategHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaCategHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCategHasta.CL_dfecha = Nothing
        Me.BtBuscaCategHasta.CL_Entidad = Nothing
        Me.BtBuscaCategHasta.CL_EsId = True
        Me.BtBuscaCategHasta.CL_Filtro = Nothing
        Me.BtBuscaCategHasta.cl_formu = Nothing
        Me.BtBuscaCategHasta.CL_hfecha = Nothing
        Me.BtBuscaCategHasta.cl_ListaW = Nothing
        Me.BtBuscaCategHasta.CL_xCentro = False
        Me.BtBuscaCategHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCategHasta.Location = New System.Drawing.Point(904, 84)
        Me.BtBuscaCategHasta.Name = "BtBuscaCategHasta"
        Me.BtBuscaCategHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCategHasta.TabIndex = 100292
        Me.BtBuscaCategHasta.UseVisualStyleBackColor = True
        '
        'LbHastaCateg
        '
        Me.LbHastaCateg.AutoSize = True
        Me.LbHastaCateg.CL_ControlAsociado = Nothing
        Me.LbHastaCateg.CL_ValorFijo = False
        Me.LbHastaCateg.ClForm = Nothing
        Me.LbHastaCateg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaCateg.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaCateg.Location = New System.Drawing.Point(732, 87)
        Me.LbHastaCateg.Name = "LbHastaCateg"
        Me.LbHastaCateg.Size = New System.Drawing.Size(103, 16)
        Me.LbHastaCateg.TabIndex = 100291
        Me.LbHastaCateg.Text = "Hasta Categ."
        '
        'TxCategDesde
        '
        Me.TxCategDesde.Autonumerico = False
        Me.TxCategDesde.Buscando = False
        Me.TxCategDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCategDesde.ClForm = Nothing
        Me.TxCategDesde.ClParam = Nothing
        Me.TxCategDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCategDesde.GridLin = Nothing
        Me.TxCategDesde.HaCambiado = False
        Me.TxCategDesde.lbbusca = Nothing
        Me.TxCategDesde.Location = New System.Drawing.Point(835, 59)
        Me.TxCategDesde.MiError = False
        Me.TxCategDesde.Name = "TxCategDesde"
        Me.TxCategDesde.Orden = 0
        Me.TxCategDesde.SaltoAlfinal = False
        Me.TxCategDesde.Siguiente = 0
        Me.TxCategDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxCategDesde.TabIndex = 100290
        Me.TxCategDesde.TeclaRepetida = False
        Me.TxCategDesde.TxDatoFinalSemana = Nothing
        Me.TxCategDesde.TxDatoInicioSemana = Nothing
        Me.TxCategDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaCategDesde
        '
        Me.BtBuscaCategDesde.CL_Ancho = 0
        Me.BtBuscaCategDesde.CL_BuscaAlb = False
        Me.BtBuscaCategDesde.CL_campocodigo = Nothing
        Me.BtBuscaCategDesde.CL_camponombre = Nothing
        Me.BtBuscaCategDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaCategDesde.CL_ch1000 = False
        Me.BtBuscaCategDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCategDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaCategDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCategDesde.CL_dfecha = Nothing
        Me.BtBuscaCategDesde.CL_Entidad = Nothing
        Me.BtBuscaCategDesde.CL_EsId = True
        Me.BtBuscaCategDesde.CL_Filtro = Nothing
        Me.BtBuscaCategDesde.cl_formu = Nothing
        Me.BtBuscaCategDesde.CL_hfecha = Nothing
        Me.BtBuscaCategDesde.cl_ListaW = Nothing
        Me.BtBuscaCategDesde.CL_xCentro = False
        Me.BtBuscaCategDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCategDesde.Location = New System.Drawing.Point(904, 59)
        Me.BtBuscaCategDesde.Name = "BtBuscaCategDesde"
        Me.BtBuscaCategDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCategDesde.TabIndex = 100289
        Me.BtBuscaCategDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeCateg
        '
        Me.LbDesdeCateg.AutoSize = True
        Me.LbDesdeCateg.CL_ControlAsociado = Nothing
        Me.LbDesdeCateg.CL_ValorFijo = False
        Me.LbDesdeCateg.ClForm = Nothing
        Me.LbDesdeCateg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeCateg.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeCateg.Location = New System.Drawing.Point(732, 62)
        Me.LbDesdeCateg.Name = "LbDesdeCateg"
        Me.LbDesdeCateg.Size = New System.Drawing.Size(105, 16)
        Me.LbDesdeCateg.TabIndex = 100288
        Me.LbDesdeCateg.Text = "Desde Categ."
        '
        'LbNomCategDesde
        '
        Me.LbNomCategDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategDesde.CL_ControlAsociado = Nothing
        Me.LbNomCategDesde.CL_ValorFijo = False
        Me.LbNomCategDesde.ClForm = Nothing
        Me.LbNomCategDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategDesde.Location = New System.Drawing.Point(943, 59)
        Me.LbNomCategDesde.Name = "LbNomCategDesde"
        Me.LbNomCategDesde.Size = New System.Drawing.Size(270, 23)
        Me.LbNomCategDesde.TabIndex = 100294
        '
        'LbNomCategHasta
        '
        Me.LbNomCategHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomCategHasta.CL_ControlAsociado = Nothing
        Me.LbNomCategHasta.CL_ValorFijo = False
        Me.LbNomCategHasta.ClForm = Nothing
        Me.LbNomCategHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCategHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomCategHasta.Location = New System.Drawing.Point(943, 84)
        Me.LbNomCategHasta.Name = "LbNomCategHasta"
        Me.LbNomCategHasta.Size = New System.Drawing.Size(270, 23)
        Me.LbNomCategHasta.TabIndex = 100295
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTODOSFacturado)
        Me.GroupBox3.Controls.Add(Me.RbNOFacturado)
        Me.GroupBox3.Controls.Add(Me.RbSIFacturado)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(1018, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox3.TabIndex = 100296
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturado"
        '
        'RbTODOSFacturado
        '
        Me.RbTODOSFacturado.AutoSize = True
        Me.RbTODOSFacturado.Checked = True
        Me.RbTODOSFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODOSFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbTODOSFacturado.Location = New System.Drawing.Point(114, 16)
        Me.RbTODOSFacturado.Name = "RbTODOSFacturado"
        Me.RbTODOSFacturado.Size = New System.Drawing.Size(69, 20)
        Me.RbTODOSFacturado.TabIndex = 2
        Me.RbTODOSFacturado.TabStop = True
        Me.RbTODOSFacturado.Text = "Todos"
        Me.RbTODOSFacturado.UseVisualStyleBackColor = True
        '
        'RbNOFacturado
        '
        Me.RbNOFacturado.AutoSize = True
        Me.RbNOFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNOFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbNOFacturado.Location = New System.Drawing.Point(63, 16)
        Me.RbNOFacturado.Name = "RbNOFacturado"
        Me.RbNOFacturado.Size = New System.Drawing.Size(47, 20)
        Me.RbNOFacturado.TabIndex = 1
        Me.RbNOFacturado.Text = "NO"
        Me.RbNOFacturado.UseVisualStyleBackColor = True
        '
        'RbSIFacturado
        '
        Me.RbSIFacturado.AutoSize = True
        Me.RbSIFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSIFacturado.ForeColor = System.Drawing.Color.Teal
        Me.RbSIFacturado.Location = New System.Drawing.Point(16, 16)
        Me.RbSIFacturado.Name = "RbSIFacturado"
        Me.RbSIFacturado.Size = New System.Drawing.Size(41, 20)
        Me.RbSIFacturado.TabIndex = 0
        Me.RbSIFacturado.Text = "SI"
        Me.RbSIFacturado.UseVisualStyleBackColor = True
        '
        'LbTipoListado
        '
        Me.LbTipoListado.AutoSize = True
        Me.LbTipoListado.CL_ControlAsociado = Nothing
        Me.LbTipoListado.CL_ValorFijo = True
        Me.LbTipoListado.ClForm = Nothing
        Me.LbTipoListado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoListado.ForeColor = System.Drawing.Color.Teal
        Me.LbTipoListado.Location = New System.Drawing.Point(732, 114)
        Me.LbTipoListado.Name = "LbTipoListado"
        Me.LbTipoListado.Size = New System.Drawing.Size(91, 16)
        Me.LbTipoListado.TabIndex = 100299
        Me.LbTipoListado.Text = "Tipo listado"
        '
        'CbTipoListado
        '
        Me.CbTipoListado.Campobd = Nothing
        Me.CbTipoListado.ClForm = Nothing
        Me.CbTipoListado.DeshabilitarRuedaRaton = False
        Me.CbTipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoListado.FormattingEnabled = True
        Me.CbTipoListado.GridLin = Nothing
        Me.CbTipoListado.Location = New System.Drawing.Point(835, 112)
        Me.CbTipoListado.MiEntidad = Nothing
        Me.CbTipoListado.MiError = False
        Me.CbTipoListado.Name = "CbTipoListado"
        Me.CbTipoListado.Orden = 0
        Me.CbTipoListado.SaltoAlfinal = False
        Me.CbTipoListado.Size = New System.Drawing.Size(378, 21)
        Me.CbTipoListado.TabIndex = 100300
        '
        'BtBuscaAlbaranHasta
        '
        Me.BtBuscaAlbaranHasta.CL_Ancho = 0
        Me.BtBuscaAlbaranHasta.CL_BuscaAlb = False
        Me.BtBuscaAlbaranHasta.CL_campocodigo = Nothing
        Me.BtBuscaAlbaranHasta.CL_camponombre = Nothing
        Me.BtBuscaAlbaranHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaranHasta.CL_ch1000 = False
        Me.BtBuscaAlbaranHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaranHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaAlbaranHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaranHasta.CL_dfecha = Nothing
        Me.BtBuscaAlbaranHasta.CL_Entidad = Nothing
        Me.BtBuscaAlbaranHasta.CL_EsId = True
        Me.BtBuscaAlbaranHasta.CL_Filtro = Nothing
        Me.BtBuscaAlbaranHasta.cl_formu = Nothing
        Me.BtBuscaAlbaranHasta.CL_hfecha = Nothing
        Me.BtBuscaAlbaranHasta.cl_ListaW = Nothing
        Me.BtBuscaAlbaranHasta.CL_xCentro = False
        Me.BtBuscaAlbaranHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaranHasta.Location = New System.Drawing.Point(1180, 34)
        Me.BtBuscaAlbaranHasta.Name = "BtBuscaAlbaranHasta"
        Me.BtBuscaAlbaranHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaranHasta.TabIndex = 100302
        Me.BtBuscaAlbaranHasta.UseVisualStyleBackColor = True
        '
        'BtBuscaAlbaranDesde
        '
        Me.BtBuscaAlbaranDesde.CL_Ancho = 0
        Me.BtBuscaAlbaranDesde.CL_BuscaAlb = False
        Me.BtBuscaAlbaranDesde.CL_campocodigo = Nothing
        Me.BtBuscaAlbaranDesde.CL_camponombre = Nothing
        Me.BtBuscaAlbaranDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaranDesde.CL_ch1000 = False
        Me.BtBuscaAlbaranDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaranDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaAlbaranDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaranDesde.CL_dfecha = Nothing
        Me.BtBuscaAlbaranDesde.CL_Entidad = Nothing
        Me.BtBuscaAlbaranDesde.CL_EsId = True
        Me.BtBuscaAlbaranDesde.CL_Filtro = Nothing
        Me.BtBuscaAlbaranDesde.cl_formu = Nothing
        Me.BtBuscaAlbaranDesde.CL_hfecha = Nothing
        Me.BtBuscaAlbaranDesde.cl_ListaW = Nothing
        Me.BtBuscaAlbaranDesde.CL_xCentro = False
        Me.BtBuscaAlbaranDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaranDesde.Location = New System.Drawing.Point(1180, 9)
        Me.BtBuscaAlbaranDesde.Name = "BtBuscaAlbaranDesde"
        Me.BtBuscaAlbaranDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaranDesde.TabIndex = 100301
        Me.BtBuscaAlbaranDesde.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbTODOSPrecioSalida)
        Me.GroupBox1.Controls.Add(Me.RbNOPrecioSalida)
        Me.GroupBox1.Controls.Add(Me.RbSIPrecioSalida)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(622, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 42)
        Me.GroupBox1.TabIndex = 100303
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Con Prec. Salida"
        '
        'RbTODOSPrecioSalida
        '
        Me.RbTODOSPrecioSalida.AutoSize = True
        Me.RbTODOSPrecioSalida.Checked = True
        Me.RbTODOSPrecioSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTODOSPrecioSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbTODOSPrecioSalida.Location = New System.Drawing.Point(114, 16)
        Me.RbTODOSPrecioSalida.Name = "RbTODOSPrecioSalida"
        Me.RbTODOSPrecioSalida.Size = New System.Drawing.Size(69, 20)
        Me.RbTODOSPrecioSalida.TabIndex = 2
        Me.RbTODOSPrecioSalida.TabStop = True
        Me.RbTODOSPrecioSalida.Text = "Todos"
        Me.RbTODOSPrecioSalida.UseVisualStyleBackColor = True
        '
        'RbNOPrecioSalida
        '
        Me.RbNOPrecioSalida.AutoSize = True
        Me.RbNOPrecioSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNOPrecioSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbNOPrecioSalida.Location = New System.Drawing.Point(63, 16)
        Me.RbNOPrecioSalida.Name = "RbNOPrecioSalida"
        Me.RbNOPrecioSalida.Size = New System.Drawing.Size(47, 20)
        Me.RbNOPrecioSalida.TabIndex = 1
        Me.RbNOPrecioSalida.Text = "NO"
        Me.RbNOPrecioSalida.UseVisualStyleBackColor = True
        '
        'RbSIPrecioSalida
        '
        Me.RbSIPrecioSalida.AutoSize = True
        Me.RbSIPrecioSalida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSIPrecioSalida.ForeColor = System.Drawing.Color.Teal
        Me.RbSIPrecioSalida.Location = New System.Drawing.Point(16, 16)
        Me.RbSIPrecioSalida.Name = "RbSIPrecioSalida"
        Me.RbSIPrecioSalida.Size = New System.Drawing.Size(41, 20)
        Me.RbSIPrecioSalida.TabIndex = 0
        Me.RbSIPrecioSalida.Text = "SI"
        Me.RbSIPrecioSalida.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbTodasVentas)
        Me.GroupBox4.Controls.Add(Me.RbVtaComision)
        Me.GroupBox4.Controls.Add(Me.RbVtaFirme)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(257, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(359, 42)
        Me.GroupBox4.TabIndex = 100304
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de venta"
        '
        'RbTodasVentas
        '
        Me.RbTodasVentas.AutoSize = True
        Me.RbTodasVentas.Checked = True
        Me.RbTodasVentas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodasVentas.ForeColor = System.Drawing.Color.Teal
        Me.RbTodasVentas.Location = New System.Drawing.Point(281, 16)
        Me.RbTodasVentas.Name = "RbTodasVentas"
        Me.RbTodasVentas.Size = New System.Drawing.Size(69, 20)
        Me.RbTodasVentas.TabIndex = 2
        Me.RbTodasVentas.TabStop = True
        Me.RbTodasVentas.Text = "Todos"
        Me.RbTodasVentas.UseVisualStyleBackColor = True
        '
        'RbVtaComision
        '
        Me.RbVtaComision.AutoSize = True
        Me.RbVtaComision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVtaComision.ForeColor = System.Drawing.Color.Teal
        Me.RbVtaComision.Location = New System.Drawing.Point(135, 16)
        Me.RbVtaComision.Name = "RbVtaComision"
        Me.RbVtaComision.Size = New System.Drawing.Size(127, 20)
        Me.RbVtaComision.TabIndex = 1
        Me.RbVtaComision.Text = "Vta. Comisión"
        Me.RbVtaComision.UseVisualStyleBackColor = True
        '
        'RbVtaFirme
        '
        Me.RbVtaFirme.AutoSize = True
        Me.RbVtaFirme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVtaFirme.ForeColor = System.Drawing.Color.Teal
        Me.RbVtaFirme.Location = New System.Drawing.Point(16, 16)
        Me.RbVtaFirme.Name = "RbVtaFirme"
        Me.RbVtaFirme.Size = New System.Drawing.Size(102, 20)
        Me.RbVtaFirme.TabIndex = 0
        Me.RbVtaFirme.Text = "Vta. Firme"
        Me.RbVtaFirme.UseVisualStyleBackColor = True
        '
        'LbNomDomicilioHasta
        '
        Me.LbNomDomicilioHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDomicilioHasta.CL_ControlAsociado = Nothing
        Me.LbNomDomicilioHasta.CL_ValorFijo = False
        Me.LbNomDomicilioHasta.ClForm = Nothing
        Me.LbNomDomicilioHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDomicilioHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDomicilioHasta.Location = New System.Drawing.Point(254, 134)
        Me.LbNomDomicilioHasta.Name = "LbNomDomicilioHasta"
        Me.LbNomDomicilioHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomDomicilioHasta.TabIndex = 100312
        '
        'TxDomicilioHasta
        '
        Me.TxDomicilioHasta.Autonumerico = False
        Me.TxDomicilioHasta.Buscando = False
        Me.TxDomicilioHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDomicilioHasta.ClForm = Nothing
        Me.TxDomicilioHasta.ClParam = Nothing
        Me.TxDomicilioHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDomicilioHasta.GridLin = Nothing
        Me.TxDomicilioHasta.HaCambiado = False
        Me.TxDomicilioHasta.lbbusca = Nothing
        Me.TxDomicilioHasta.Location = New System.Drawing.Point(146, 134)
        Me.TxDomicilioHasta.MiError = False
        Me.TxDomicilioHasta.Name = "TxDomicilioHasta"
        Me.TxDomicilioHasta.Orden = 0
        Me.TxDomicilioHasta.SaltoAlfinal = False
        Me.TxDomicilioHasta.Siguiente = 0
        Me.TxDomicilioHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxDomicilioHasta.TabIndex = 100311
        Me.TxDomicilioHasta.TeclaRepetida = False
        Me.TxDomicilioHasta.TxDatoFinalSemana = Nothing
        Me.TxDomicilioHasta.TxDatoInicioSemana = Nothing
        Me.TxDomicilioHasta.UltimoValorValidado = Nothing
        '
        'BtBuscaDomicilioHasta
        '
        Me.BtBuscaDomicilioHasta.CL_Ancho = 0
        Me.BtBuscaDomicilioHasta.CL_BuscaAlb = False
        Me.BtBuscaDomicilioHasta.CL_campocodigo = Nothing
        Me.BtBuscaDomicilioHasta.CL_camponombre = Nothing
        Me.BtBuscaDomicilioHasta.CL_CampoOrden = "Nombre"
        Me.BtBuscaDomicilioHasta.CL_ch1000 = False
        Me.BtBuscaDomicilioHasta.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDomicilioHasta.CL_ControlAsociado = Nothing
        Me.BtBuscaDomicilioHasta.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDomicilioHasta.CL_dfecha = Nothing
        Me.BtBuscaDomicilioHasta.CL_Entidad = Nothing
        Me.BtBuscaDomicilioHasta.CL_EsId = True
        Me.BtBuscaDomicilioHasta.CL_Filtro = Nothing
        Me.BtBuscaDomicilioHasta.cl_formu = Nothing
        Me.BtBuscaDomicilioHasta.CL_hfecha = Nothing
        Me.BtBuscaDomicilioHasta.cl_ListaW = Nothing
        Me.BtBuscaDomicilioHasta.CL_xCentro = False
        Me.BtBuscaDomicilioHasta.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDomicilioHasta.Location = New System.Drawing.Point(215, 134)
        Me.BtBuscaDomicilioHasta.Name = "BtBuscaDomicilioHasta"
        Me.BtBuscaDomicilioHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDomicilioHasta.TabIndex = 100310
        Me.BtBuscaDomicilioHasta.UseVisualStyleBackColor = True
        '
        'LbDomicilioHasta
        '
        Me.LbDomicilioHasta.AutoSize = True
        Me.LbDomicilioHasta.CL_ControlAsociado = Nothing
        Me.LbDomicilioHasta.CL_ValorFijo = False
        Me.LbDomicilioHasta.ClForm = Nothing
        Me.LbDomicilioHasta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilioHasta.ForeColor = System.Drawing.Color.Teal
        Me.LbDomicilioHasta.Location = New System.Drawing.Point(12, 137)
        Me.LbDomicilioHasta.Name = "LbDomicilioHasta"
        Me.LbDomicilioHasta.Size = New System.Drawing.Size(121, 16)
        Me.LbDomicilioHasta.TabIndex = 100309
        Me.LbDomicilioHasta.Text = "Hasta Domicilio"
        '
        'LbNomDomicilioDesde
        '
        Me.LbNomDomicilioDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomDomicilioDesde.CL_ControlAsociado = Nothing
        Me.LbNomDomicilioDesde.CL_ValorFijo = False
        Me.LbNomDomicilioDesde.ClForm = Nothing
        Me.LbNomDomicilioDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomDomicilioDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomDomicilioDesde.Location = New System.Drawing.Point(254, 109)
        Me.LbNomDomicilioDesde.Name = "LbNomDomicilioDesde"
        Me.LbNomDomicilioDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomDomicilioDesde.TabIndex = 100308
        '
        'TxDomicilioDesde
        '
        Me.TxDomicilioDesde.Autonumerico = False
        Me.TxDomicilioDesde.Buscando = False
        Me.TxDomicilioDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDomicilioDesde.ClForm = Nothing
        Me.TxDomicilioDesde.ClParam = Nothing
        Me.TxDomicilioDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDomicilioDesde.GridLin = Nothing
        Me.TxDomicilioDesde.HaCambiado = False
        Me.TxDomicilioDesde.lbbusca = Nothing
        Me.TxDomicilioDesde.Location = New System.Drawing.Point(146, 109)
        Me.TxDomicilioDesde.MiError = False
        Me.TxDomicilioDesde.Name = "TxDomicilioDesde"
        Me.TxDomicilioDesde.Orden = 0
        Me.TxDomicilioDesde.SaltoAlfinal = False
        Me.TxDomicilioDesde.Siguiente = 0
        Me.TxDomicilioDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxDomicilioDesde.TabIndex = 100307
        Me.TxDomicilioDesde.TeclaRepetida = False
        Me.TxDomicilioDesde.TxDatoFinalSemana = Nothing
        Me.TxDomicilioDesde.TxDatoInicioSemana = Nothing
        Me.TxDomicilioDesde.UltimoValorValidado = Nothing
        '
        'BtBuscaDomicilioDesde
        '
        Me.BtBuscaDomicilioDesde.CL_Ancho = 0
        Me.BtBuscaDomicilioDesde.CL_BuscaAlb = False
        Me.BtBuscaDomicilioDesde.CL_campocodigo = Nothing
        Me.BtBuscaDomicilioDesde.CL_camponombre = Nothing
        Me.BtBuscaDomicilioDesde.CL_CampoOrden = "Nombre"
        Me.BtBuscaDomicilioDesde.CL_ch1000 = False
        Me.BtBuscaDomicilioDesde.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaDomicilioDesde.CL_ControlAsociado = Nothing
        Me.BtBuscaDomicilioDesde.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaDomicilioDesde.CL_dfecha = Nothing
        Me.BtBuscaDomicilioDesde.CL_Entidad = Nothing
        Me.BtBuscaDomicilioDesde.CL_EsId = True
        Me.BtBuscaDomicilioDesde.CL_Filtro = Nothing
        Me.BtBuscaDomicilioDesde.cl_formu = Nothing
        Me.BtBuscaDomicilioDesde.CL_hfecha = Nothing
        Me.BtBuscaDomicilioDesde.cl_ListaW = Nothing
        Me.BtBuscaDomicilioDesde.CL_xCentro = False
        Me.BtBuscaDomicilioDesde.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaDomicilioDesde.Location = New System.Drawing.Point(215, 109)
        Me.BtBuscaDomicilioDesde.Name = "BtBuscaDomicilioDesde"
        Me.BtBuscaDomicilioDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaDomicilioDesde.TabIndex = 100306
        Me.BtBuscaDomicilioDesde.UseVisualStyleBackColor = True
        '
        'LbDomicilioDesde
        '
        Me.LbDomicilioDesde.AutoSize = True
        Me.LbDomicilioDesde.CL_ControlAsociado = Nothing
        Me.LbDomicilioDesde.CL_ValorFijo = False
        Me.LbDomicilioDesde.ClForm = Nothing
        Me.LbDomicilioDesde.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDomicilioDesde.ForeColor = System.Drawing.Color.Teal
        Me.LbDomicilioDesde.Location = New System.Drawing.Point(12, 112)
        Me.LbDomicilioDesde.Name = "LbDomicilioDesde"
        Me.LbDomicilioDesde.Size = New System.Drawing.Size(123, 16)
        Me.LbDomicilioDesde.TabIndex = 100305
        Me.LbDomicilioDesde.Text = "Desde Domicilio"
        '
        'LbNomAgricultorHasta
        '
        Me.LbNomAgricultorHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorHasta.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorHasta.CL_ValorFijo = False
        Me.LbNomAgricultorHasta.ClForm = Nothing
        Me.LbNomAgricultorHasta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorHasta.Location = New System.Drawing.Point(254, 33)
        Me.LbNomAgricultorHasta.Name = "LbNomAgricultorHasta"
        Me.LbNomAgricultorHasta.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorHasta.TabIndex = 100320
        '
        'TxClienteHasta
        '
        Me.TxClienteHasta.Autonumerico = False
        Me.TxClienteHasta.Buscando = False
        Me.TxClienteHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClienteHasta.ClForm = Nothing
        Me.TxClienteHasta.ClParam = Nothing
        Me.TxClienteHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteHasta.GridLin = Nothing
        Me.TxClienteHasta.HaCambiado = False
        Me.TxClienteHasta.lbbusca = Nothing
        Me.TxClienteHasta.Location = New System.Drawing.Point(146, 33)
        Me.TxClienteHasta.MiError = False
        Me.TxClienteHasta.Name = "TxClienteHasta"
        Me.TxClienteHasta.Orden = 0
        Me.TxClienteHasta.SaltoAlfinal = False
        Me.TxClienteHasta.Siguiente = 0
        Me.TxClienteHasta.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteHasta.TabIndex = 100319
        Me.TxClienteHasta.TeclaRepetida = False
        Me.TxClienteHasta.TxDatoFinalSemana = Nothing
        Me.TxClienteHasta.TxDatoInicioSemana = Nothing
        Me.TxClienteHasta.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorHasta.Location = New System.Drawing.Point(215, 33)
        Me.BtBuscaAgricultorHasta.Name = "BtBuscaAgricultorHasta"
        Me.BtBuscaAgricultorHasta.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorHasta.TabIndex = 100318
        Me.BtBuscaAgricultorHasta.UseVisualStyleBackColor = True
        '
        'LbHastaAgricultor
        '
        Me.LbHastaAgricultor.AutoSize = True
        Me.LbHastaAgricultor.CL_ControlAsociado = Nothing
        Me.LbHastaAgricultor.CL_ValorFijo = False
        Me.LbHastaAgricultor.ClForm = Nothing
        Me.LbHastaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaAgricultor.Location = New System.Drawing.Point(12, 36)
        Me.LbHastaAgricultor.Name = "LbHastaAgricultor"
        Me.LbHastaAgricultor.Size = New System.Drawing.Size(106, 16)
        Me.LbHastaAgricultor.TabIndex = 100317
        Me.LbHastaAgricultor.Text = "Hasta Cliente"
        '
        'LbNomAgricultorDesde
        '
        Me.LbNomAgricultorDesde.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LbNomAgricultorDesde.CL_ControlAsociado = Nothing
        Me.LbNomAgricultorDesde.CL_ValorFijo = False
        Me.LbNomAgricultorDesde.ClForm = Nothing
        Me.LbNomAgricultorDesde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgricultorDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgricultorDesde.Location = New System.Drawing.Point(254, 8)
        Me.LbNomAgricultorDesde.Name = "LbNomAgricultorDesde"
        Me.LbNomAgricultorDesde.Size = New System.Drawing.Size(447, 23)
        Me.LbNomAgricultorDesde.TabIndex = 100316
        '
        'TxClienteDesde
        '
        Me.TxClienteDesde.Autonumerico = False
        Me.TxClienteDesde.Buscando = False
        Me.TxClienteDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClienteDesde.ClForm = Nothing
        Me.TxClienteDesde.ClParam = Nothing
        Me.TxClienteDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClienteDesde.GridLin = Nothing
        Me.TxClienteDesde.HaCambiado = False
        Me.TxClienteDesde.lbbusca = Nothing
        Me.TxClienteDesde.Location = New System.Drawing.Point(146, 8)
        Me.TxClienteDesde.MiError = False
        Me.TxClienteDesde.Name = "TxClienteDesde"
        Me.TxClienteDesde.Orden = 0
        Me.TxClienteDesde.SaltoAlfinal = False
        Me.TxClienteDesde.Siguiente = 0
        Me.TxClienteDesde.Size = New System.Drawing.Size(63, 22)
        Me.TxClienteDesde.TabIndex = 100315
        Me.TxClienteDesde.TeclaRepetida = False
        Me.TxClienteDesde.TxDatoFinalSemana = Nothing
        Me.TxClienteDesde.TxDatoInicioSemana = Nothing
        Me.TxClienteDesde.UltimoValorValidado = Nothing
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
        Me.BtBuscaAgricultorDesde.Location = New System.Drawing.Point(215, 8)
        Me.BtBuscaAgricultorDesde.Name = "BtBuscaAgricultorDesde"
        Me.BtBuscaAgricultorDesde.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgricultorDesde.TabIndex = 100314
        Me.BtBuscaAgricultorDesde.UseVisualStyleBackColor = True
        '
        'LbDesdeAgricultor
        '
        Me.LbDesdeAgricultor.AutoSize = True
        Me.LbDesdeAgricultor.CL_ControlAsociado = Nothing
        Me.LbDesdeAgricultor.CL_ValorFijo = False
        Me.LbDesdeAgricultor.ClForm = Nothing
        Me.LbDesdeAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeAgricultor.Location = New System.Drawing.Point(12, 11)
        Me.LbDesdeAgricultor.Name = "LbDesdeAgricultor"
        Me.LbDesdeAgricultor.Size = New System.Drawing.Size(108, 16)
        Me.LbDesdeAgricultor.TabIndex = 100313
        Me.LbDesdeAgricultor.Text = "Desde Cliente"
        '
        'ChkDesgloseRechazos
        '
        Me.ChkDesgloseRechazos.AutoSize = True
        Me.ChkDesgloseRechazos.Campobd = Nothing
        Me.ChkDesgloseRechazos.ClForm = Nothing
        Me.ChkDesgloseRechazos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDesgloseRechazos.ForeColor = System.Drawing.Color.Teal
        Me.ChkDesgloseRechazos.GridLin = Nothing
        Me.ChkDesgloseRechazos.HaCambiado = False
        Me.ChkDesgloseRechazos.Location = New System.Drawing.Point(15, 180)
        Me.ChkDesgloseRechazos.MiEntidad = Nothing
        Me.ChkDesgloseRechazos.MiError = False
        Me.ChkDesgloseRechazos.Name = "ChkDesgloseRechazos"
        Me.ChkDesgloseRechazos.Orden = 0
        Me.ChkDesgloseRechazos.SaltoAlfinal = False
        Me.ChkDesgloseRechazos.Size = New System.Drawing.Size(163, 20)
        Me.ChkDesgloseRechazos.TabIndex = 100403
        Me.ChkDesgloseRechazos.Text = "Desglose rechazos"
        Me.ChkDesgloseRechazos.UseVisualStyleBackColor = True
        Me.ChkDesgloseRechazos.ValorCampoFalse = Nothing
        Me.ChkDesgloseRechazos.ValorCampoTrue = Nothing
        Me.ChkDesgloseRechazos.ValorDefecto = False
        '
        'FrmListadoAlbaranesSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoAlbaranesSalida"
        Me.Text = "Listado albaranes salida"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.cbPuntoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents cbPuntoVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LbPuntoVenta As NetAgro.Lb
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTODOSValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoValorados As System.Windows.Forms.RadioButton
    Friend WithEvents RbSiValorados As System.Windows.Forms.RadioButton
    Friend WithEvents TxAlbaranHasta As NetAgro.TxDato
    Friend WithEvents LbDesdeAlbaran As NetAgro.Lb
    Friend WithEvents LbHastaAlbaran As NetAgro.Lb
    Friend WithEvents TxAlbaranDesde As NetAgro.TxDato
    Friend WithEvents LbNomGeneroHasta As NetAgro.Lb
    Friend WithEvents TxGeneroHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaGenero As NetAgro.Lb
    Friend WithEvents LbNomGeneroDesde As NetAgro.Lb
    Friend WithEvents TxGeneroDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaGeneroDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeGenero As NetAgro.Lb
    Friend WithEvents LbNomCategHasta As NetAgro.Lb
    Friend WithEvents LbNomCategDesde As NetAgro.Lb
    Friend WithEvents TxCategHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaCategHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaCateg As NetAgro.Lb
    Friend WithEvents TxCategDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaCategDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeCateg As NetAgro.Lb
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTODOSFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents RbNOFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents RbSIFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents LbTipoListado As NetAgro.Lb
    Friend WithEvents CbTipoListado As NetAgro.CbBox
    Friend WithEvents BtBuscaAlbaranHasta As NetAgro.BtBusca
    Friend WithEvents BtBuscaAlbaranDesde As NetAgro.BtBusca
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTODOSPrecioSalida As System.Windows.Forms.RadioButton
    Friend WithEvents RbNOPrecioSalida As System.Windows.Forms.RadioButton
    Friend WithEvents RbSIPrecioSalida As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodasVentas As System.Windows.Forms.RadioButton
    Friend WithEvents RbVtaComision As System.Windows.Forms.RadioButton
    Friend WithEvents RbVtaFirme As System.Windows.Forms.RadioButton
    Friend WithEvents LbNomDomicilioHasta As NetAgro.Lb
    Friend WithEvents TxDomicilioHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaDomicilioHasta As NetAgro.BtBusca
    Friend WithEvents LbDomicilioHasta As NetAgro.Lb
    Friend WithEvents LbNomDomicilioDesde As NetAgro.Lb
    Friend WithEvents TxDomicilioDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaDomicilioDesde As NetAgro.BtBusca
    Friend WithEvents LbDomicilioDesde As NetAgro.Lb
    Friend WithEvents LbNomAgricultorHasta As NetAgro.Lb
    Friend WithEvents TxClienteHasta As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorHasta As NetAgro.BtBusca
    Friend WithEvents LbHastaAgricultor As NetAgro.Lb
    Friend WithEvents LbNomAgricultorDesde As NetAgro.Lb
    Friend WithEvents TxClienteDesde As NetAgro.TxDato
    Friend WithEvents BtBuscaAgricultorDesde As NetAgro.BtBusca
    Friend WithEvents LbDesdeAgricultor As NetAgro.Lb
    Friend WithEvents ChkDesgloseRechazos As NetAgro.Chk
End Class
