<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoGastosPr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoGastosPr))
        Me.LbNomAgr2 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAgr2 = New NetAgro.BtBusca(Me.components)
        Me.LbaAgricultor = New NetAgro.Lb(Me.components)
        Me.TxAAgricultor = New NetAgro.TxDato(Me.components)
        Me.LbnomAgr1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaagr1 = New NetAgro.BtBusca(Me.components)
        Me.LbdAgricultor = New NetAgro.Lb(Me.components)
        Me.TxDAgricultor = New NetAgro.TxDato(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.LbNomAgr2)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaAgr2)
        Me.PanelCabecera.Controls.Add(Me.LbaAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxAAgricultor)
        Me.PanelCabecera.Controls.Add(Me.LbnomAgr1)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaagr1)
        Me.PanelCabecera.Controls.Add(Me.LbdAgricultor)
        Me.PanelCabecera.Controls.Add(Me.TxDAgricultor)
        Me.PanelCabecera.Size = New System.Drawing.Size(670, 117)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 97)
        Me.PanelConsulta.Size = New System.Drawing.Size(670, 425)
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
        'LbNomAgr2
        '
        Me.LbNomAgr2.BackColor = System.Drawing.Color.LightGray
        Me.LbNomAgr2.CL_ControlAsociado = Nothing
        Me.LbNomAgr2.CL_ValorFijo = False
        Me.LbNomAgr2.ClForm = Nothing
        Me.LbNomAgr2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomAgr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNomAgr2.Location = New System.Drawing.Point(244, 52)
        Me.LbNomAgr2.Name = "LbNomAgr2"
        Me.LbNomAgr2.Size = New System.Drawing.Size(401, 18)
        Me.LbNomAgr2.TabIndex = 100291
        '
        'BtBuscaAgr2
        '
        Me.BtBuscaAgr2.CL_Ancho = 0
        Me.BtBuscaAgr2.CL_BuscaAlb = False
        Me.BtBuscaAgr2.CL_campocodigo = Nothing
        Me.BtBuscaAgr2.CL_camponombre = Nothing
        Me.BtBuscaAgr2.CL_CampoOrden = "Nombre"
        Me.BtBuscaAgr2.CL_ch1000 = False
        Me.BtBuscaAgr2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAgr2.CL_ControlAsociado = Nothing
        Me.BtBuscaAgr2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAgr2.CL_dfecha = Nothing
        Me.BtBuscaAgr2.CL_Entidad = Nothing
        Me.BtBuscaAgr2.CL_EsId = True
        Me.BtBuscaAgr2.CL_Filtro = Nothing
        Me.BtBuscaAgr2.cl_formu = Nothing
        Me.BtBuscaAgr2.CL_hfecha = Nothing
        Me.BtBuscaAgr2.cl_ListaW = Nothing
        Me.BtBuscaAgr2.CL_xCentro = False
        Me.BtBuscaAgr2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAgr2.Location = New System.Drawing.Point(203, 50)
        Me.BtBuscaAgr2.Name = "BtBuscaAgr2"
        Me.BtBuscaAgr2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAgr2.TabIndex = 100290
        Me.BtBuscaAgr2.UseVisualStyleBackColor = True
        '
        'LbaAgricultor
        '
        Me.LbaAgricultor.AutoSize = True
        Me.LbaAgricultor.CL_ControlAsociado = Nothing
        Me.LbaAgricultor.CL_ValorFijo = False
        Me.LbaAgricultor.ClForm = Nothing
        Me.LbaAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbaAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbaAgricultor.Location = New System.Drawing.Point(33, 53)
        Me.LbaAgricultor.Name = "LbaAgricultor"
        Me.LbaAgricultor.Size = New System.Drawing.Size(92, 16)
        Me.LbaAgricultor.TabIndex = 100289
        Me.LbaAgricultor.Text = "A agricultor"
        '
        'TxAAgricultor
        '
        Me.TxAAgricultor.Autonumerico = False
        Me.TxAAgricultor.Buscando = False
        Me.TxAAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAAgricultor.ClForm = Nothing
        Me.TxAAgricultor.ClParam = Nothing
        Me.TxAAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxAAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAAgricultor.GridLin = Nothing
        Me.TxAAgricultor.HaCambiado = False
        Me.TxAAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxAAgricultor.lbbusca = Nothing
        Me.TxAAgricultor.Location = New System.Drawing.Point(140, 50)
        Me.TxAAgricultor.MiError = False
        Me.TxAAgricultor.Name = "TxAAgricultor"
        Me.TxAAgricultor.Orden = 0
        Me.TxAAgricultor.SaltoAlfinal = False
        Me.TxAAgricultor.Siguiente = 0
        Me.TxAAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxAAgricultor.TabIndex = 100288
        Me.TxAAgricultor.TeclaRepetida = False
        Me.TxAAgricultor.TxDatoFinalSemana = Nothing
        Me.TxAAgricultor.TxDatoInicioSemana = Nothing
        Me.TxAAgricultor.UltimoValorValidado = Nothing
        '
        'LbnomAgr1
        '
        Me.LbnomAgr1.BackColor = System.Drawing.Color.LightGray
        Me.LbnomAgr1.CL_ControlAsociado = Nothing
        Me.LbnomAgr1.CL_ValorFijo = False
        Me.LbnomAgr1.ClForm = Nothing
        Me.LbnomAgr1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbnomAgr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbnomAgr1.Location = New System.Drawing.Point(244, 23)
        Me.LbnomAgr1.Name = "LbnomAgr1"
        Me.LbnomAgr1.Size = New System.Drawing.Size(401, 18)
        Me.LbnomAgr1.TabIndex = 100287
        '
        'BtBuscaagr1
        '
        Me.BtBuscaagr1.CL_Ancho = 0
        Me.BtBuscaagr1.CL_BuscaAlb = False
        Me.BtBuscaagr1.CL_campocodigo = Nothing
        Me.BtBuscaagr1.CL_camponombre = Nothing
        Me.BtBuscaagr1.CL_CampoOrden = "Nombre"
        Me.BtBuscaagr1.CL_ch1000 = False
        Me.BtBuscaagr1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaagr1.CL_ControlAsociado = Nothing
        Me.BtBuscaagr1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaagr1.CL_dfecha = Nothing
        Me.BtBuscaagr1.CL_Entidad = Nothing
        Me.BtBuscaagr1.CL_EsId = True
        Me.BtBuscaagr1.CL_Filtro = Nothing
        Me.BtBuscaagr1.cl_formu = Nothing
        Me.BtBuscaagr1.CL_hfecha = Nothing
        Me.BtBuscaagr1.cl_ListaW = Nothing
        Me.BtBuscaagr1.CL_xCentro = False
        Me.BtBuscaagr1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaagr1.Location = New System.Drawing.Point(203, 21)
        Me.BtBuscaagr1.Name = "BtBuscaagr1"
        Me.BtBuscaagr1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaagr1.TabIndex = 100286
        Me.BtBuscaagr1.UseVisualStyleBackColor = True
        '
        'LbdAgricultor
        '
        Me.LbdAgricultor.AutoSize = True
        Me.LbdAgricultor.CL_ControlAsociado = Nothing
        Me.LbdAgricultor.CL_ValorFijo = False
        Me.LbdAgricultor.ClForm = Nothing
        Me.LbdAgricultor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbdAgricultor.ForeColor = System.Drawing.Color.Teal
        Me.LbdAgricultor.Location = New System.Drawing.Point(33, 24)
        Me.LbdAgricultor.Name = "LbdAgricultor"
        Me.LbdAgricultor.Size = New System.Drawing.Size(101, 16)
        Me.LbdAgricultor.TabIndex = 100285
        Me.LbdAgricultor.Text = "De agricultor"
        '
        'TxDAgricultor
        '
        Me.TxDAgricultor.Autonumerico = False
        Me.TxDAgricultor.Buscando = False
        Me.TxDAgricultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDAgricultor.ClForm = Nothing
        Me.TxDAgricultor.ClParam = Nothing
        Me.TxDAgricultor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDAgricultor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDAgricultor.GridLin = Nothing
        Me.TxDAgricultor.HaCambiado = False
        Me.TxDAgricultor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDAgricultor.lbbusca = Nothing
        Me.TxDAgricultor.Location = New System.Drawing.Point(140, 21)
        Me.TxDAgricultor.MiError = False
        Me.TxDAgricultor.Name = "TxDAgricultor"
        Me.TxDAgricultor.Orden = 0
        Me.TxDAgricultor.SaltoAlfinal = False
        Me.TxDAgricultor.Siguiente = 0
        Me.TxDAgricultor.Size = New System.Drawing.Size(57, 22)
        Me.TxDAgricultor.TabIndex = 100284
        Me.TxDAgricultor.TeclaRepetida = False
        Me.TxDAgricultor.TxDatoFinalSemana = Nothing
        Me.TxDAgricultor.TxDatoInicioSemana = Nothing
        Me.TxDAgricultor.UltimoValorValidado = Nothing
        '
        'FrmListadoGastosPr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmListadoGastosPr"
        Me.Text = "Listado gastos proveedores"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbNomAgr2 As NetAgro.Lb
    Friend WithEvents BtBuscaAgr2 As NetAgro.BtBusca
    Friend WithEvents LbaAgricultor As NetAgro.Lb
    Friend WithEvents TxAAgricultor As NetAgro.TxDato
    Friend WithEvents LbnomAgr1 As NetAgro.Lb
    Friend WithEvents BtBuscaagr1 As NetAgro.BtBusca
    Friend WithEvents LbdAgricultor As NetAgro.Lb
    Friend WithEvents TxDAgricultor As NetAgro.TxDato
End Class
