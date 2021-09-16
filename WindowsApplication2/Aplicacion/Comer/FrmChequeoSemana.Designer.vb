<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChequeoSemana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChequeoSemana))
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbSemana = New NetAgro.Lb(Me.components)
        Me.TxSemana = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkClasif = New NetAgro.Chk(Me.components)
        Me.ChkFirme = New NetAgro.Chk(Me.components)
        Me.ChkComision = New NetAgro.Chk(Me.components)
        Me.ChkSprecio = New NetAgro.Chk(Me.components)
        Me.ChkSvalor = New NetAgro.Chk(Me.components)
        Me.ChkSmuestreo = New NetAgro.Chk(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkFirmeSprecio = New NetAgro.Chk(Me.components)
        Me.ChkSCuenta = New NetAgro.Chk(Me.components)
        Me.cbCentro = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.cbCentro)
        Me.PanelCabecera.Controls.Add(Me.Lb5)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.GroupBox1)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbSemana)
        Me.PanelCabecera.Controls.Add(Me.TxSemana)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(670, 166)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 172)
        Me.PanelConsulta.Size = New System.Drawing.Size(670, 350)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(370, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(445, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(520, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(595, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(295, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'LbHastaFecha
        '
        Me.LbHastaFecha.AutoSize = True
        Me.LbHastaFecha.CL_ControlAsociado = Nothing
        Me.LbHastaFecha.CL_ValorFijo = False
        Me.LbHastaFecha.ClForm = Nothing
        Me.LbHastaFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHastaFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbHastaFecha.Location = New System.Drawing.Point(12, 68)
        Me.LbHastaFecha.Name = "LbHastaFecha"
        Me.LbHastaFecha.Size = New System.Drawing.Size(95, 16)
        Me.LbHastaFecha.TabIndex = 100289
        Me.LbHastaFecha.Text = "Hasta fecha"
        '
        'TxFechaHasta
        '
        Me.TxFechaHasta.Autonumerico = False
        Me.TxFechaHasta.Buscando = False
        Me.TxFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaHasta.ClForm = Nothing
        Me.TxFechaHasta.ClParam = Nothing
        Me.TxFechaHasta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaHasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaHasta.GridLin = Nothing
        Me.TxFechaHasta.HaCambiado = False
        Me.TxFechaHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaHasta.lbbusca = Nothing
        Me.TxFechaHasta.Location = New System.Drawing.Point(115, 65)
        Me.TxFechaHasta.MiError = False
        Me.TxFechaHasta.Name = "TxFechaHasta"
        Me.TxFechaHasta.Orden = 0
        Me.TxFechaHasta.SaltoAlfinal = False
        Me.TxFechaHasta.Siguiente = 0
        Me.TxFechaHasta.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaHasta.TabIndex = 100288
        Me.TxFechaHasta.TeclaRepetida = False
        Me.TxFechaHasta.TxDatoFinalSemana = Nothing
        Me.TxFechaHasta.TxDatoInicioSemana = Nothing
        Me.TxFechaHasta.UltimoValorValidado = Nothing
        '
        'LbSemana
        '
        Me.LbSemana.AutoSize = True
        Me.LbSemana.CL_ControlAsociado = Nothing
        Me.LbSemana.CL_ValorFijo = False
        Me.LbSemana.ClForm = Nothing
        Me.LbSemana.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSemana.ForeColor = System.Drawing.Color.Teal
        Me.LbSemana.Location = New System.Drawing.Point(12, 9)
        Me.LbSemana.Name = "LbSemana"
        Me.LbSemana.Size = New System.Drawing.Size(67, 16)
        Me.LbSemana.TabIndex = 100287
        Me.LbSemana.Text = "Semana"
        '
        'TxSemana
        '
        Me.TxSemana.Autonumerico = False
        Me.TxSemana.Buscando = False
        Me.TxSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSemana.ClForm = Nothing
        Me.TxSemana.ClParam = Nothing
        Me.TxSemana.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxSemana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSemana.GridLin = Nothing
        Me.TxSemana.HaCambiado = False
        Me.TxSemana.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxSemana.lbbusca = Nothing
        Me.TxSemana.Location = New System.Drawing.Point(115, 6)
        Me.TxSemana.MiError = False
        Me.TxSemana.Name = "TxSemana"
        Me.TxSemana.Orden = 0
        Me.TxSemana.SaltoAlfinal = False
        Me.TxSemana.Siguiente = 0
        Me.TxSemana.Size = New System.Drawing.Size(43, 22)
        Me.TxSemana.TabIndex = 100286
        Me.TxSemana.TeclaRepetida = False
        Me.TxSemana.TxDatoFinalSemana = Nothing
        Me.TxSemana.TxDatoInicioSemana = Nothing
        Me.TxSemana.UltimoValorValidado = Nothing
        '
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(12, 40)
        Me.LbDesdeFecha.Name = "LbDesdeFecha"
        Me.LbDesdeFecha.Size = New System.Drawing.Size(97, 16)
        Me.LbDesdeFecha.TabIndex = 100285
        Me.LbDesdeFecha.Text = "Desde fecha"
        '
        'TxFechaDesde
        '
        Me.TxFechaDesde.Autonumerico = False
        Me.TxFechaDesde.Buscando = False
        Me.TxFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFechaDesde.ClForm = Nothing
        Me.TxFechaDesde.ClParam = Nothing
        Me.TxFechaDesde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFechaDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFechaDesde.GridLin = Nothing
        Me.TxFechaDesde.HaCambiado = False
        Me.TxFechaDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxFechaDesde.lbbusca = Nothing
        Me.TxFechaDesde.Location = New System.Drawing.Point(115, 37)
        Me.TxFechaDesde.MiError = False
        Me.TxFechaDesde.Name = "TxFechaDesde"
        Me.TxFechaDesde.Orden = 0
        Me.TxFechaDesde.SaltoAlfinal = False
        Me.TxFechaDesde.Siguiente = 0
        Me.TxFechaDesde.Size = New System.Drawing.Size(105, 22)
        Me.TxFechaDesde.TabIndex = 100284
        Me.TxFechaDesde.TeclaRepetida = False
        Me.TxFechaDesde.TxDatoFinalSemana = Nothing
        Me.TxFechaDesde.TxDatoInicioSemana = Nothing
        Me.TxFechaDesde.UltimoValorValidado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkClasif)
        Me.GroupBox1.Controls.Add(Me.ChkFirme)
        Me.GroupBox1.Controls.Add(Me.ChkComision)
        Me.GroupBox1.Controls.Add(Me.ChkSprecio)
        Me.GroupBox1.Controls.Add(Me.ChkSvalor)
        Me.GroupBox1.Controls.Add(Me.ChkSmuestreo)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 151)
        Me.GroupBox1.TabIndex = 100290
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chequear Compras"
        '
        'ChkClasif
        '
        Me.ChkClasif.AutoSize = True
        Me.ChkClasif.Campobd = Nothing
        Me.ChkClasif.ClForm = Nothing
        Me.ChkClasif.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkClasif.GridLin = Nothing
        Me.ChkClasif.HaCambiado = False
        Me.ChkClasif.Location = New System.Drawing.Point(3, 134)
        Me.ChkClasif.MiEntidad = Nothing
        Me.ChkClasif.MiError = False
        Me.ChkClasif.Name = "ChkClasif"
        Me.ChkClasif.Orden = 0
        Me.ChkClasif.SaltoAlfinal = False
        Me.ChkClasif.Size = New System.Drawing.Size(71, 17)
        Me.ChkClasif.TabIndex = 7
        Me.ChkClasif.Text = "S/Clasif"
        Me.ChkClasif.UseVisualStyleBackColor = True
        Me.ChkClasif.ValorCampoFalse = Nothing
        Me.ChkClasif.ValorCampoTrue = Nothing
        Me.ChkClasif.ValorDefecto = False
        '
        'ChkFirme
        '
        Me.ChkFirme.AutoSize = True
        Me.ChkFirme.Campobd = Nothing
        Me.ChkFirme.ClForm = Nothing
        Me.ChkFirme.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFirme.GridLin = Nothing
        Me.ChkFirme.HaCambiado = False
        Me.ChkFirme.Location = New System.Drawing.Point(3, 116)
        Me.ChkFirme.MiEntidad = Nothing
        Me.ChkFirme.MiError = False
        Me.ChkFirme.Name = "ChkFirme"
        Me.ChkFirme.Orden = 0
        Me.ChkFirme.SaltoAlfinal = False
        Me.ChkFirme.Size = New System.Drawing.Size(58, 17)
        Me.ChkFirme.TabIndex = 6
        Me.ChkFirme.Text = "Firme"
        Me.ChkFirme.UseVisualStyleBackColor = True
        Me.ChkFirme.ValorCampoFalse = Nothing
        Me.ChkFirme.ValorCampoTrue = Nothing
        Me.ChkFirme.ValorDefecto = False
        '
        'ChkComision
        '
        Me.ChkComision.AutoSize = True
        Me.ChkComision.Campobd = Nothing
        Me.ChkComision.ClForm = Nothing
        Me.ChkComision.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkComision.GridLin = Nothing
        Me.ChkComision.HaCambiado = False
        Me.ChkComision.Location = New System.Drawing.Point(3, 100)
        Me.ChkComision.MiEntidad = Nothing
        Me.ChkComision.MiError = False
        Me.ChkComision.Name = "ChkComision"
        Me.ChkComision.Orden = 0
        Me.ChkComision.SaltoAlfinal = False
        Me.ChkComision.Size = New System.Drawing.Size(79, 17)
        Me.ChkComision.TabIndex = 5
        Me.ChkComision.Text = "Comision"
        Me.ChkComision.UseVisualStyleBackColor = True
        Me.ChkComision.ValorCampoFalse = Nothing
        Me.ChkComision.ValorCampoTrue = Nothing
        Me.ChkComision.ValorDefecto = False
        '
        'ChkSprecio
        '
        Me.ChkSprecio.AutoSize = True
        Me.ChkSprecio.Campobd = Nothing
        Me.ChkSprecio.ClForm = Nothing
        Me.ChkSprecio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSprecio.GridLin = Nothing
        Me.ChkSprecio.HaCambiado = False
        Me.ChkSprecio.Location = New System.Drawing.Point(3, 51)
        Me.ChkSprecio.MiEntidad = Nothing
        Me.ChkSprecio.MiError = False
        Me.ChkSprecio.Name = "ChkSprecio"
        Me.ChkSprecio.Orden = 0
        Me.ChkSprecio.SaltoAlfinal = False
        Me.ChkSprecio.Size = New System.Drawing.Size(148, 17)
        Me.ChkSprecio.TabIndex = 4
        Me.ChkSprecio.Text = " Valoradas a precio 0"
        Me.ChkSprecio.UseVisualStyleBackColor = True
        Me.ChkSprecio.ValorCampoFalse = Nothing
        Me.ChkSprecio.ValorCampoTrue = Nothing
        Me.ChkSprecio.ValorDefecto = False
        '
        'ChkSvalor
        '
        Me.ChkSvalor.AutoSize = True
        Me.ChkSvalor.Campobd = Nothing
        Me.ChkSvalor.ClForm = Nothing
        Me.ChkSvalor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSvalor.GridLin = Nothing
        Me.ChkSvalor.HaCambiado = False
        Me.ChkSvalor.Location = New System.Drawing.Point(3, 33)
        Me.ChkSvalor.MiEntidad = Nothing
        Me.ChkSvalor.MiError = False
        Me.ChkSvalor.Name = "ChkSvalor"
        Me.ChkSvalor.Orden = 0
        Me.ChkSvalor.SaltoAlfinal = False
        Me.ChkSvalor.Size = New System.Drawing.Size(141, 17)
        Me.ChkSvalor.TabIndex = 3
        Me.ChkSvalor.Text = " Partidas sin valorar"
        Me.ChkSvalor.UseVisualStyleBackColor = True
        Me.ChkSvalor.ValorCampoFalse = Nothing
        Me.ChkSvalor.ValorCampoTrue = Nothing
        Me.ChkSvalor.ValorDefecto = False
        '
        'ChkSmuestreo
        '
        Me.ChkSmuestreo.AutoSize = True
        Me.ChkSmuestreo.Campobd = Nothing
        Me.ChkSmuestreo.ClForm = Nothing
        Me.ChkSmuestreo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSmuestreo.GridLin = Nothing
        Me.ChkSmuestreo.HaCambiado = False
        Me.ChkSmuestreo.Location = New System.Drawing.Point(3, 16)
        Me.ChkSmuestreo.MiEntidad = Nothing
        Me.ChkSmuestreo.MiError = False
        Me.ChkSmuestreo.Name = "ChkSmuestreo"
        Me.ChkSmuestreo.Orden = 0
        Me.ChkSmuestreo.SaltoAlfinal = False
        Me.ChkSmuestreo.Size = New System.Drawing.Size(159, 17)
        Me.ChkSmuestreo.TabIndex = 0
        Me.ChkSmuestreo.Text = " Partidas sin muestrear"
        Me.ChkSmuestreo.UseVisualStyleBackColor = True
        Me.ChkSmuestreo.ValorCampoFalse = Nothing
        Me.ChkSmuestreo.ValorCampoTrue = Nothing
        Me.ChkSmuestreo.ValorDefecto = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkFirmeSprecio)
        Me.GroupBox2.Controls.Add(Me.ChkSCuenta)
        Me.GroupBox2.Location = New System.Drawing.Point(458, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 106)
        Me.GroupBox2.TabIndex = 100291
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chequear Ventas"
        '
        'ChkFirmeSprecio
        '
        Me.ChkFirmeSprecio.AutoSize = True
        Me.ChkFirmeSprecio.Campobd = Nothing
        Me.ChkFirmeSprecio.ClForm = Nothing
        Me.ChkFirmeSprecio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFirmeSprecio.GridLin = Nothing
        Me.ChkFirmeSprecio.HaCambiado = False
        Me.ChkFirmeSprecio.Location = New System.Drawing.Point(3, 33)
        Me.ChkFirmeSprecio.MiEntidad = Nothing
        Me.ChkFirmeSprecio.MiError = False
        Me.ChkFirmeSprecio.Name = "ChkFirmeSprecio"
        Me.ChkFirmeSprecio.Orden = 0
        Me.ChkFirmeSprecio.SaltoAlfinal = False
        Me.ChkFirmeSprecio.Size = New System.Drawing.Size(133, 17)
        Me.ChkFirmeSprecio.TabIndex = 3
        Me.ChkFirmeSprecio.Text = "Salidas 'F' precio 0"
        Me.ChkFirmeSprecio.UseVisualStyleBackColor = True
        Me.ChkFirmeSprecio.ValorCampoFalse = Nothing
        Me.ChkFirmeSprecio.ValorCampoTrue = Nothing
        Me.ChkFirmeSprecio.ValorDefecto = False
        '
        'ChkSCuenta
        '
        Me.ChkSCuenta.AutoSize = True
        Me.ChkSCuenta.Campobd = Nothing
        Me.ChkSCuenta.ClForm = Nothing
        Me.ChkSCuenta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSCuenta.GridLin = Nothing
        Me.ChkSCuenta.HaCambiado = False
        Me.ChkSCuenta.Location = New System.Drawing.Point(3, 16)
        Me.ChkSCuenta.MiEntidad = Nothing
        Me.ChkSCuenta.MiError = False
        Me.ChkSCuenta.Name = "ChkSCuenta"
        Me.ChkSCuenta.Orden = 0
        Me.ChkSCuenta.SaltoAlfinal = False
        Me.ChkSCuenta.Size = New System.Drawing.Size(151, 17)
        Me.ChkSCuenta.TabIndex = 0
        Me.ChkSCuenta.Text = "Salidas 'C' sin valorar"
        Me.ChkSCuenta.UseVisualStyleBackColor = True
        Me.ChkSCuenta.ValorCampoFalse = Nothing
        Me.ChkSCuenta.ValorCampoTrue = Nothing
        Me.ChkSCuenta.ValorDefecto = False
        '
        'cbCentro
        '
        Me.cbCentro.EditValue = ""
        Me.cbCentro.Location = New System.Drawing.Point(79, 135)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(160, 20)
        Me.cbCentro.TabIndex = 100318
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = True
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(16, 137)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(57, 16)
        Me.Lb5.TabIndex = 100317
        Me.Lb5.Text = "Centro"
        '
        'FrmChequeoSemana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmChequeoSemana"
        Me.Text = "Chequeo Semanal"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkFirmeSprecio As NetAgro.Chk
    Friend WithEvents ChkSCuenta As NetAgro.Chk
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkSprecio As NetAgro.Chk
    Friend WithEvents ChkSvalor As NetAgro.Chk
    Friend WithEvents ChkSmuestreo As NetAgro.Chk
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbSemana As NetAgro.Lb
    Friend WithEvents TxSemana As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents ChkClasif As NetAgro.Chk
    Friend WithEvents ChkFirme As NetAgro.Chk
    Friend WithEvents ChkComision As NetAgro.Chk
    Friend WithEvents cbCentro As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Lb5 As NetAgro.Lb
End Class
