<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaldoEnvasesAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldoEnvasesAlmacen))
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.chkMarcas = New NetAgro.Chk(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.chkMarcas)
        Me.PanelCabecera.Controls.Add(Me.TxDato5)
        Me.PanelCabecera.Controls.Add(Me.Lb6)
        Me.PanelCabecera.Size = New System.Drawing.Size(1008, 52)
        '
        'Panel3
        '
        Me.PanelConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 52)
        Me.PanelConsulta.Size = New System.Drawing.Size(1008, 442)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(708, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(783, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(858, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(933, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(633, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
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
        Me.TxDato5.Location = New System.Drawing.Point(113, 15)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(102, 22)
        Me.TxDato5.TabIndex = 95
        Me.TxDato5.TeclaRepetida = False
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(12, 18)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(95, 16)
        Me.Lb6.TabIndex = 94
        Me.Lb6.Text = "Hasta fecha"
        '
        'chkMarcas
        '
        Me.chkMarcas.AutoSize = True
        Me.chkMarcas.Campobd = Nothing
        Me.chkMarcas.ClForm = Nothing
        Me.chkMarcas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarcas.ForeColor = System.Drawing.Color.Teal
        Me.chkMarcas.GridLin = Nothing
        Me.chkMarcas.HaCambiado = False
        Me.chkMarcas.Location = New System.Drawing.Point(260, 16)
        Me.chkMarcas.MiEntidad = Nothing
        Me.chkMarcas.MiError = False
        Me.chkMarcas.Name = "chkMarcas"
        Me.chkMarcas.Orden = 0
        Me.chkMarcas.SaltoAlfinal = False
        Me.chkMarcas.Size = New System.Drawing.Size(141, 20)
        Me.chkMarcas.TabIndex = 100272
        Me.chkMarcas.Text = "Mostrar marcas"
        Me.chkMarcas.UseVisualStyleBackColor = True
        Me.chkMarcas.ValorCampoFalse = Nothing
        Me.chkMarcas.ValorCampoTrue = Nothing
        Me.chkMarcas.ValorDefecto = False
        '
        'FrmSaldoEnvasesAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 528)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmSaldoEnvasesAlmacen"
        Me.Text = "Existencias envases almacenes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents chkMarcas As NetAgro.Chk
End Class
