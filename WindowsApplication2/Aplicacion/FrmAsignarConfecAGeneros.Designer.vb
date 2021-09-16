<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarConfecAGeneros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarConfecAGeneros))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.BtBusca1 = New NetAgro.BtBusca(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Lb_1 = New NetAgro.Lb(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ChActivo = New NetAgro.Chk(Me.components)
        Me.ChPesoFijo = New NetAgro.Chk(Me.components)
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridExistentes = New DevExpress.XtraGrid.GridControl()
        Me.GridViewExistentes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.Controls.Add(Me.Lb3)
        Me.PanelCabecera.Controls.Add(Me.TxDato3)
        Me.PanelCabecera.Controls.Add(Me.ChActivo)
        Me.PanelCabecera.Controls.Add(Me.ChPesoFijo)
        Me.PanelCabecera.Controls.Add(Me.Lb4)
        Me.PanelCabecera.Controls.Add(Me.Lb2)
        Me.PanelCabecera.Controls.Add(Me.TxDato4)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Size = New System.Drawing.Size(751, 106)
        '
        'PanelConsulta
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 326)
        Me.PanelConsulta.Size = New System.Drawing.Size(751, 210)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(451, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(526, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(601, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(676, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(376, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
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
        Me.TxDato1.Location = New System.Drawing.Point(136, 15)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(63, 22)
        Me.TxDato1.TabIndex = 51
        Me.TxDato1.TeclaRepetida = False
        Me.TxDato1.UltimoValorValidado = Nothing
        '
        'BtBusca1
        '
        Me.BtBusca1.CL_Ancho = 0
        Me.BtBusca1.CL_BuscaAlb = False
        Me.BtBusca1.CL_campocodigo = Nothing
        Me.BtBusca1.CL_camponombre = Nothing
        Me.BtBusca1.CL_CampoOrden = "Nombre"
        Me.BtBusca1.CL_ch1000 = False
        Me.BtBusca1.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca1.CL_ControlAsociado = Nothing
        Me.BtBusca1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca1.CL_dfecha = Nothing
        Me.BtBusca1.CL_Entidad = Nothing
        Me.BtBusca1.CL_EsId = True
        Me.BtBusca1.CL_Filtro = Nothing
        Me.BtBusca1.cl_formu = Nothing
        Me.BtBusca1.CL_hfecha = Nothing
        Me.BtBusca1.cl_ListaW = Nothing
        Me.BtBusca1.CL_xCentro = False
        Me.BtBusca1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca1.Location = New System.Drawing.Point(210, 15)
        Me.BtBusca1.Name = "BtBusca1"
        Me.BtBusca1.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca1.TabIndex = 50
        Me.BtBusca1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(10, 18)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(120, 16)
        Me.Lb1.TabIndex = 49
        Me.Lb1.Text = "Tipo confección"
        '
        'Lb_1
        '
        Me.Lb_1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_1.CL_ControlAsociado = Nothing
        Me.Lb_1.CL_ValorFijo = False
        Me.Lb_1.ClForm = Nothing
        Me.Lb_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_1.Location = New System.Drawing.Point(244, 15)
        Me.Lb_1.Name = "Lb_1"
        Me.Lb_1.Size = New System.Drawing.Size(391, 23)
        Me.Lb_1.TabIndex = 75
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
        Me.TxDato2.Location = New System.Drawing.Point(136, 44)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(63, 22)
        Me.TxDato2.TabIndex = 53
        Me.TxDato2.TeclaRepetida = False
        Me.TxDato2.UltimoValorValidado = Nothing
        '
        'TxDato4
        '
        Me.TxDato4.Autonumerico = False
        Me.TxDato4.Buscando = False
        Me.TxDato4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.HaCambiado = False
        Me.TxDato4.lbbusca = Nothing
        Me.TxDato4.Location = New System.Drawing.Point(232, 75)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(102, 22)
        Me.TxDato4.TabIndex = 55
        Me.TxDato4.TeclaRepetida = False
        Me.TxDato4.UltimoValorValidado = Nothing
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(10, 47)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(97, 16)
        Me.Lb2.TabIndex = 103
        Me.Lb2.Text = "Kilos x Bulto"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(10, 78)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(172, 16)
        Me.Lb4.TabIndex = 109
        Me.Lb4.Text = "Sobrecoste confeccion"
        '
        'ChActivo
        '
        Me.ChActivo.AutoSize = True
        Me.ChActivo.Campobd = Nothing
        Me.ChActivo.ClForm = Nothing
        Me.ChActivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChActivo.ForeColor = System.Drawing.Color.Teal
        Me.ChActivo.GridLin = Nothing
        Me.ChActivo.HaCambiado = False
        Me.ChActivo.Location = New System.Drawing.Point(492, 76)
        Me.ChActivo.MiEntidad = Nothing
        Me.ChActivo.MiError = False
        Me.ChActivo.Name = "ChActivo"
        Me.ChActivo.Orden = 0
        Me.ChActivo.SaltoAlfinal = False
        Me.ChActivo.Size = New System.Drawing.Size(73, 20)
        Me.ChActivo.TabIndex = 111
        Me.ChActivo.Text = "Activo"
        Me.ChActivo.UseVisualStyleBackColor = True
        Me.ChActivo.ValorCampoFalse = Nothing
        Me.ChActivo.ValorCampoTrue = Nothing
        Me.ChActivo.ValorDefecto = False
        '
        'ChPesoFijo
        '
        Me.ChPesoFijo.AutoSize = True
        Me.ChPesoFijo.Campobd = Nothing
        Me.ChPesoFijo.ClForm = Nothing
        Me.ChPesoFijo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPesoFijo.ForeColor = System.Drawing.Color.Teal
        Me.ChPesoFijo.GridLin = Nothing
        Me.ChPesoFijo.HaCambiado = False
        Me.ChPesoFijo.Location = New System.Drawing.Point(363, 76)
        Me.ChPesoFijo.MiEntidad = Nothing
        Me.ChPesoFijo.MiError = False
        Me.ChPesoFijo.Name = "ChPesoFijo"
        Me.ChPesoFijo.Orden = 0
        Me.ChPesoFijo.SaltoAlfinal = False
        Me.ChPesoFijo.Size = New System.Drawing.Size(89, 20)
        Me.ChPesoFijo.TabIndex = 110
        Me.ChPesoFijo.Text = "Peso fijo"
        Me.ChPesoFijo.UseVisualStyleBackColor = True
        Me.ChPesoFijo.ValorCampoFalse = Nothing
        Me.ChPesoFijo.ValorCampoTrue = Nothing
        Me.ChPesoFijo.ValorDefecto = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(247, 47)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(110, 16)
        Me.Lb3.TabIndex = 113
        Me.Lb3.Text = "Piezas x Bulto"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(363, 44)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(53, 23)
        Me.TxDato3.TabIndex = 112
        Me.TxDato3.TeclaRepetida = False
        Me.TxDato3.UltimoValorValidado = Nothing
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GridExistentes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(751, 210)
        Me.Panel4.TabIndex = 76
        '
        'GridExistentes
        '
        Me.GridExistentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridExistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExistentes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridExistentes.Location = New System.Drawing.Point(0, 0)
        Me.GridExistentes.LookAndFeel.SkinName = "Black"
        Me.GridExistentes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridExistentes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridExistentes.MainView = Me.GridViewExistentes
        Me.GridExistentes.Name = "GridExistentes"
        Me.GridExistentes.Size = New System.Drawing.Size(751, 210)
        Me.GridExistentes.TabIndex = 12
        Me.GridExistentes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewExistentes})
        '
        'GridViewExistentes
        '
        Me.GridViewExistentes.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridViewExistentes.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExistentes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridViewExistentes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridViewExistentes.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewExistentes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridViewExistentes.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.GridViewExistentes.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExistentes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridViewExistentes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridViewExistentes.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewExistentes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridViewExistentes.Appearance.Row.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewExistentes.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridViewExistentes.Appearance.Row.Options.UseFont = True
        Me.GridViewExistentes.Appearance.Row.Options.UseForeColor = True
        Me.GridViewExistentes.GridControl = Me.GridExistentes
        Me.GridViewExistentes.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewExistentes.Name = "GridViewExistentes"
        Me.GridViewExistentes.OptionsBehavior.Editable = False
        Me.GridViewExistentes.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridViewExistentes.OptionsView.ShowGroupPanel = False
        '
        'FrmAsignarConfecAGeneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 573)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Lb_1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.BtBusca1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmAsignarConfecAGeneros"
        Me.Text = "Asignar Tipo de Confección a Géneros"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.PanelCabecera, 0)
        Me.Controls.SetChildIndex(Me.PanelConsulta, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBusca1, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb_1, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents BtBusca1 As NetAgro.BtBusca
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Lb_1 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents ChActivo As NetAgro.Chk
    Friend WithEvents ChPesoFijo As NetAgro.Chk
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents GridExistentes As DevExpress.XtraGrid.GridControl
    Public WithEvents GridViewExistentes As DevExpress.XtraGrid.Views.Grid.GridView
End Class
