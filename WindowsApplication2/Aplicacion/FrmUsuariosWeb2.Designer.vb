<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuariosWeb2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuariosWeb2))
        Me.LbClave = New NetAgro.Lb(Me.components)
        Me.TxClave = New NetAgro.TxDato(Me.components)
        Me.TxCodigo = New NetAgro.TxDato(Me.components)
        Me.BtBuscaCodigo = New NetAgro.BtBusca(Me.components)
        Me.LbCodigo = New NetAgro.Lb(Me.components)
        Me.Lb15 = New NetAgro.Lb(Me.components)
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.CL_ControlAsociado = Nothing
        Me.LbClave.CL_ValorFijo = False
        Me.LbClave.ClForm = Nothing
        Me.LbClave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClave.ForeColor = System.Drawing.Color.Teal
        Me.LbClave.Location = New System.Drawing.Point(12, 44)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(49, 16)
        Me.LbClave.TabIndex = 50
        Me.LbClave.Text = "Clave"
        '
        'TxClave
        '
        Me.TxClave.Autonumerico = False
        Me.TxClave.Buscando = False
        Me.TxClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxClave.ClForm = Nothing
        Me.TxClave.ClParam = Nothing
        Me.TxClave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClave.GridLin = Nothing
        Me.TxClave.HaCambiado = False
        Me.TxClave.lbbusca = Nothing
        Me.TxClave.Location = New System.Drawing.Point(82, 41)
        Me.TxClave.MiError = False
        Me.TxClave.Name = "TxClave"
        Me.TxClave.Orden = 0
        Me.TxClave.SaltoAlfinal = False
        Me.TxClave.Siguiente = 0
        Me.TxClave.Size = New System.Drawing.Size(229, 22)
        Me.TxClave.TabIndex = 49
        Me.TxClave.TeclaRepetida = False
        Me.TxClave.TxDatoFinalSemana = Nothing
        Me.TxClave.TxDatoInicioSemana = Nothing
        Me.TxClave.UltimoValorValidado = Nothing
        '
        'TxCodigo
        '
        Me.TxCodigo.Autonumerico = False
        Me.TxCodigo.Buscando = False
        Me.TxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCodigo.ClForm = Nothing
        Me.TxCodigo.ClParam = Nothing
        Me.TxCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.GridLin = Nothing
        Me.TxCodigo.HaCambiado = False
        Me.TxCodigo.lbbusca = Nothing
        Me.TxCodigo.Location = New System.Drawing.Point(82, 13)
        Me.TxCodigo.MiError = False
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Orden = 0
        Me.TxCodigo.SaltoAlfinal = False
        Me.TxCodigo.Siguiente = 0
        Me.TxCodigo.Size = New System.Drawing.Size(63, 22)
        Me.TxCodigo.TabIndex = 48
        Me.TxCodigo.TeclaRepetida = False
        Me.TxCodigo.TxDatoFinalSemana = Nothing
        Me.TxCodigo.TxDatoInicioSemana = Nothing
        Me.TxCodigo.UltimoValorValidado = Nothing
        '
        'BtBuscaCodigo
        '
        Me.BtBuscaCodigo.CL_Ancho = 0
        Me.BtBuscaCodigo.CL_BuscaAlb = False
        Me.BtBuscaCodigo.CL_campocodigo = Nothing
        Me.BtBuscaCodigo.CL_camponombre = Nothing
        Me.BtBuscaCodigo.CL_CampoOrden = "Nombre"
        Me.BtBuscaCodigo.CL_ch1000 = False
        Me.BtBuscaCodigo.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCodigo.CL_ControlAsociado = Nothing
        Me.BtBuscaCodigo.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCodigo.CL_dfecha = Nothing
        Me.BtBuscaCodigo.CL_Entidad = Nothing
        Me.BtBuscaCodigo.CL_EsId = True
        Me.BtBuscaCodigo.CL_Filtro = Nothing
        Me.BtBuscaCodigo.cl_formu = Nothing
        Me.BtBuscaCodigo.CL_hfecha = Nothing
        Me.BtBuscaCodigo.cl_ListaW = Nothing
        Me.BtBuscaCodigo.CL_xCentro = False
        Me.BtBuscaCodigo.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCodigo.Location = New System.Drawing.Point(151, 12)
        Me.BtBuscaCodigo.Name = "BtBuscaCodigo"
        Me.BtBuscaCodigo.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCodigo.TabIndex = 47
        Me.BtBuscaCodigo.UseVisualStyleBackColor = True
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.CL_ControlAsociado = Nothing
        Me.LbCodigo.CL_ValorFijo = False
        Me.LbCodigo.ClForm = Nothing
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Teal
        Me.LbCodigo.Location = New System.Drawing.Point(12, 16)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(58, 16)
        Me.LbCodigo.TabIndex = 44
        Me.LbCodigo.Text = "Código"
        '
        'Lb15
        '
        Me.Lb15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb15.CL_ControlAsociado = Nothing
        Me.Lb15.CL_ValorFijo = False
        Me.Lb15.ClForm = Nothing
        Me.Lb15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb15.Location = New System.Drawing.Point(190, 11)
        Me.Lb15.Name = "Lb15"
        Me.Lb15.Size = New System.Drawing.Size(356, 23)
        Me.Lb15.TabIndex = 100297
        Me.Lb15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(4, 95)
        Me.Grid.LookAndFeel.SkinName = "Black"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Grid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(550, 220)
        Me.Grid.TabIndex = 100298
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        '
        'FrmUsuariosWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 370)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Lb15)
        Me.Controls.Add(Me.LbClave)
        Me.Controls.Add(Me.TxClave)
        Me.Controls.Add(Me.TxCodigo)
        Me.Controls.Add(Me.BtBuscaCodigo)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmUsuariosWeb"
        Me.Text = "Usuarios web"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.LbCodigo, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCodigo, 0)
        Me.Controls.SetChildIndex(Me.TxCodigo, 0)
        Me.Controls.SetChildIndex(Me.TxClave, 0)
        Me.Controls.SetChildIndex(Me.LbClave, 0)
        Me.Controls.SetChildIndex(Me.Lb15, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbClave As NetAgro.Lb
    Friend WithEvents TxClave As NetAgro.TxDato
    Friend WithEvents TxCodigo As NetAgro.TxDato
    Friend WithEvents BtBuscaCodigo As NetAgro.BtBusca
    Friend WithEvents LbCodigo As NetAgro.Lb
    Friend WithEvents Lb15 As NetAgro.Lb
    Public WithEvents Grid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
