<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta346

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulta346))
        Me.BtEjercicio = New NetAgro.BtBusca(Me.components)
        Me.TxEjercicio = New NetAgro.TxDato(Me.components)
        Me.LbEjercicio = New NetAgro.Lb(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.BtEjercicio)
        Me.PanelCabecera.Controls.Add(Me.LbEjercicio)
        Me.PanelCabecera.Controls.Add(Me.TxEjercicio)
        Me.PanelCabecera.Size = New System.Drawing.Size(1312, 51)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 57)
        Me.PanelConsulta.Size = New System.Drawing.Size(1312, 433)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(1012, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1087, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1162, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1237, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(937, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'BtEjercicio
        '
        Me.BtEjercicio.CL_Ancho = 0
        Me.BtEjercicio.CL_BuscaAlb = False
        Me.BtEjercicio.CL_campocodigo = Nothing
        Me.BtEjercicio.CL_camponombre = Nothing
        Me.BtEjercicio.CL_CampoOrden = "Nombre"
        Me.BtEjercicio.CL_ch1000 = False
        Me.BtEjercicio.CL_ConsultaSql = "Select * from familias"
        Me.BtEjercicio.CL_ControlAsociado = Me.TxEjercicio
        Me.BtEjercicio.CL_DevuelveCampo = "Idfamilia"
        Me.BtEjercicio.CL_dfecha = Nothing
        Me.BtEjercicio.CL_Entidad = Nothing
        Me.BtEjercicio.CL_EsId = True
        Me.BtEjercicio.CL_Filtro = Nothing
        Me.BtEjercicio.cl_formu = Nothing
        Me.BtEjercicio.CL_hfecha = Nothing
        Me.BtEjercicio.cl_ListaW = Nothing
        Me.BtEjercicio.CL_xCentro = False
        Me.BtEjercicio.Image = CType(resources.GetObject("BtEjercicio.Image"), System.Drawing.Image)
        Me.BtEjercicio.Location = New System.Drawing.Point(170, 12)
        Me.BtEjercicio.Name = "BtEjercicio"
        Me.BtEjercicio.Size = New System.Drawing.Size(33, 23)
        Me.BtEjercicio.TabIndex = 73
        Me.BtEjercicio.UseVisualStyleBackColor = True
        '
        'TxEjercicio
        '
        Me.TxEjercicio.Autonumerico = False
        Me.TxEjercicio.Buscando = False
        Me.TxEjercicio.ClForm = Nothing
        Me.TxEjercicio.ClParam = Nothing
        Me.TxEjercicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxEjercicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEjercicio.GridLin = Nothing
        Me.TxEjercicio.HaCambiado = False
        Me.TxEjercicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxEjercicio.lbbusca = Nothing
        Me.TxEjercicio.Location = New System.Drawing.Point(102, 12)
        Me.TxEjercicio.MiError = False
        Me.TxEjercicio.Name = "TxEjercicio"
        Me.TxEjercicio.Orden = 0
        Me.TxEjercicio.SaltoAlfinal = False
        Me.TxEjercicio.Siguiente = 0
        Me.TxEjercicio.Size = New System.Drawing.Size(62, 22)
        Me.TxEjercicio.TabIndex = 71
        Me.TxEjercicio.TeclaRepetida = False
        Me.TxEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxEjercicio.TxDatoFinalSemana = Nothing
        Me.TxEjercicio.TxDatoInicioSemana = Nothing
        Me.TxEjercicio.UltimoValorValidado = Nothing
        '
        'LbEjercicio
        '
        Me.LbEjercicio.AutoSize = True
        Me.LbEjercicio.CL_ControlAsociado = Nothing
        Me.LbEjercicio.CL_ValorFijo = False
        Me.LbEjercicio.ClForm = Nothing
        Me.LbEjercicio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEjercicio.ForeColor = System.Drawing.Color.Teal
        Me.LbEjercicio.Location = New System.Drawing.Point(24, 15)
        Me.LbEjercicio.Name = "LbEjercicio"
        Me.LbEjercicio.Size = New System.Drawing.Size(70, 16)
        Me.LbEjercicio.TabIndex = 72
        Me.LbEjercicio.Text = "Ejercicio"
        '
        'FrmConsulta346
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 530)
        Me.Controls.Add(Me._PanelCargando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmConsulta346"
        Me.Text = "Consulta datos 346"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtEjercicio As NetAgro.BtBusca
    Friend WithEvents TxEjercicio As NetAgro.TxDato
    Friend WithEvents LbEjercicio As NetAgro.Lb
End Class
