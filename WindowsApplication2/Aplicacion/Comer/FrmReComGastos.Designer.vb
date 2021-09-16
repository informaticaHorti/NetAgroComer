<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecomGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecomGastos))
        Me.LbHastaFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaHasta = New NetAgro.TxDato(Me.components)
        Me.LbDesdeFecha = New NetAgro.Lb(Me.components)
        Me.TxFechaDesde = New NetAgro.TxDato(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkExiPal = New NetAgro.Chk(Me.components)
        Me.ChkAlbSalida = New NetAgro.Chk(Me.components)
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Button1)
        Me.PanelCabecera.Controls.Add(Me.Barra)
        Me.PanelCabecera.Controls.Add(Me.GroupBox2)
        Me.PanelCabecera.Controls.Add(Me.LbHastaFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaHasta)
        Me.PanelCabecera.Controls.Add(Me.LbDesdeFecha)
        Me.PanelCabecera.Controls.Add(Me.TxFechaDesde)
        Me.PanelCabecera.Size = New System.Drawing.Size(1066, 98)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 104)
        Me.PanelConsulta.Size = New System.Drawing.Size(1066, 418)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(766, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(841, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(916, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(991, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(691, 0)
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
        Me.LbHastaFecha.Location = New System.Drawing.Point(14, 43)
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
        Me.TxFechaHasta.Location = New System.Drawing.Point(117, 40)
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
        'LbDesdeFecha
        '
        Me.LbDesdeFecha.AutoSize = True
        Me.LbDesdeFecha.CL_ControlAsociado = Nothing
        Me.LbDesdeFecha.CL_ValorFijo = False
        Me.LbDesdeFecha.ClForm = Nothing
        Me.LbDesdeFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesdeFecha.ForeColor = System.Drawing.Color.Teal
        Me.LbDesdeFecha.Location = New System.Drawing.Point(14, 15)
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
        Me.TxFechaDesde.Location = New System.Drawing.Point(117, 12)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkExiPal)
        Me.GroupBox2.Controls.Add(Me.ChkAlbSalida)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 62)
        Me.GroupBox2.TabIndex = 100291
        Me.GroupBox2.TabStop = False
        '
        'ChkExiPal
        '
        Me.ChkExiPal.AutoSize = True
        Me.ChkExiPal.Campobd = Nothing
        Me.ChkExiPal.Checked = True
        Me.ChkExiPal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkExiPal.ClForm = Nothing
        Me.ChkExiPal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkExiPal.GridLin = Nothing
        Me.ChkExiPal.HaCambiado = False
        Me.ChkExiPal.Location = New System.Drawing.Point(3, 33)
        Me.ChkExiPal.MiEntidad = Nothing
        Me.ChkExiPal.MiError = False
        Me.ChkExiPal.Name = "ChkExiPal"
        Me.ChkExiPal.Orden = 0
        Me.ChkExiPal.SaltoAlfinal = False
        Me.ChkExiPal.Size = New System.Drawing.Size(127, 17)
        Me.ChkExiPal.TabIndex = 3
        Me.ChkExiPal.Text = "Existencias palets"
        Me.ChkExiPal.UseVisualStyleBackColor = True
        Me.ChkExiPal.ValorCampoFalse = Nothing
        Me.ChkExiPal.ValorCampoTrue = Nothing
        Me.ChkExiPal.ValorDefecto = True
        '
        'ChkAlbSalida
        '
        Me.ChkAlbSalida.AutoSize = True
        Me.ChkAlbSalida.Campobd = Nothing
        Me.ChkAlbSalida.Checked = True
        Me.ChkAlbSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAlbSalida.ClForm = Nothing
        Me.ChkAlbSalida.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAlbSalida.GridLin = Nothing
        Me.ChkAlbSalida.HaCambiado = False
        Me.ChkAlbSalida.Location = New System.Drawing.Point(3, 16)
        Me.ChkAlbSalida.MiEntidad = Nothing
        Me.ChkAlbSalida.MiError = False
        Me.ChkAlbSalida.Name = "ChkAlbSalida"
        Me.ChkAlbSalida.Orden = 0
        Me.ChkAlbSalida.SaltoAlfinal = False
        Me.ChkAlbSalida.Size = New System.Drawing.Size(138, 17)
        Me.ChkAlbSalida.TabIndex = 0
        Me.ChkAlbSalida.Text = "Albaranes de salida"
        Me.ChkAlbSalida.UseVisualStyleBackColor = True
        Me.ChkAlbSalida.ValorCampoFalse = Nothing
        Me.ChkAlbSalida.ValorCampoTrue = Nothing
        Me.ChkAlbSalida.ValorDefecto = True
        '
        'Barra
        '
        Me.Barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Barra.Location = New System.Drawing.Point(0, 75)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1066, 23)
        Me.Barra.TabIndex = 100292
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(710, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 47)
        Me.Button1.TabIndex = 100293
        Me.Button1.Text = "Recomponer gastos origen"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FrmRecomGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmRecomGastos"
        Me.Text = "Recomponer gastos origen (Estructura y materiales)"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkExiPal As NetAgro.Chk
    Friend WithEvents ChkAlbSalida As NetAgro.Chk
    Friend WithEvents LbHastaFecha As NetAgro.Lb
    Friend WithEvents TxFechaHasta As NetAgro.TxDato
    Friend WithEvents LbDesdeFecha As NetAgro.Lb
    Friend WithEvents TxFechaDesde As NetAgro.TxDato
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
