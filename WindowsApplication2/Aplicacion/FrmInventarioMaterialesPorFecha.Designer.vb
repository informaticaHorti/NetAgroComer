<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioMaterialesPorFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioMaterialesPorFecha))
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.chkMarcas = New NetAgro.Chk(Me.components)
        Me.CbAlmacenes = New NetAgro.CbBox(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CbAlmacenes)
        Me.Panel2.Controls.Add(Me.chkMarcas)
        Me.Panel2.Controls.Add(Me.TxDato2)
        Me.Panel2.Controls.Add(Me.Lb4)
        Me.Panel2.Controls.Add(Me.Lb2)
        Me.Panel2.Controls.Add(Me.TxDato1)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Size = New System.Drawing.Size(1184, 45)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Size = New System.Drawing.Size(1184, 484)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(884, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(959, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(1034, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1109, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(809, 0)
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(322, 223)
        Me._PanelCargando.TabIndex = 11
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = True
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(21, 14)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(97, 16)
        Me.Lb1.TabIndex = 148
        Me.Lb1.Text = "Desde fecha"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = True
        Me.Lb2.ClForm = Nothing
        Me.Lb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.Teal
        Me.Lb2.Location = New System.Drawing.Point(266, 14)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(95, 16)
        Me.Lb2.TabIndex = 172
        Me.Lb2.Text = "Hasta fecha"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = True
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(715, 14)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(71, 16)
        Me.Lb4.TabIndex = 175
        Me.Lb4.Text = "Almacén"
        '
        'TxDato1
        '
        Me.TxDato1.Autonumerico = False
        Me.TxDato1.Buscando = False
        Me.TxDato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.HaCambiado = False
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.lbbusca = Nothing
        Me.TxDato1.Location = New System.Drawing.Point(124, 11)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(116, 23)
        Me.TxDato1.TabIndex = 152
        Me.TxDato1.TeclaRepetida = False
        '
        'TxDato2
        '
        Me.TxDato2.Autonumerico = False
        Me.TxDato2.Buscando = False
        Me.TxDato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.HaCambiado = False
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.lbbusca = Nothing
        Me.TxDato2.Location = New System.Drawing.Point(367, 11)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(116, 23)
        Me.TxDato2.TabIndex = 176
        Me.TxDato2.TeclaRepetida = False
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
        Me.chkMarcas.Location = New System.Drawing.Point(525, 12)
        Me.chkMarcas.MiEntidad = Nothing
        Me.chkMarcas.MiError = False
        Me.chkMarcas.Name = "chkMarcas"
        Me.chkMarcas.Orden = 0
        Me.chkMarcas.SaltoAlfinal = False
        Me.chkMarcas.Size = New System.Drawing.Size(141, 20)
        Me.chkMarcas.TabIndex = 100273
        Me.chkMarcas.Text = "Mostrar marcas"
        Me.chkMarcas.UseVisualStyleBackColor = True
        Me.chkMarcas.ValorCampoFalse = Nothing
        Me.chkMarcas.ValorCampoTrue = Nothing
        Me.chkMarcas.ValorDefecto = False
        '
        'CbAlmacenes
        '
        Me.CbAlmacenes.Campobd = Nothing
        Me.CbAlmacenes.ClForm = Nothing
        Me.CbAlmacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmacenes.FormattingEnabled = True
        Me.CbAlmacenes.GridLin = Nothing
        Me.CbAlmacenes.Location = New System.Drawing.Point(792, 10)
        Me.CbAlmacenes.MiEntidad = Nothing
        Me.CbAlmacenes.MiError = False
        Me.CbAlmacenes.Name = "CbAlmacenes"
        Me.CbAlmacenes.Orden = 0
        Me.CbAlmacenes.SaltoAlfinal = False
        Me.CbAlmacenes.Size = New System.Drawing.Size(344, 24)
        Me.CbAlmacenes.TabIndex = 100274
        '
        'FrmInventarioMaterialesPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 575)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmInventarioMaterialesPorFecha"
        Me.Text = "Inventario de materiales por fecha"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents chkMarcas As NetAgro.Chk
    Friend WithEvents CbAlmacenes As NetAgro.CbBox
End Class
