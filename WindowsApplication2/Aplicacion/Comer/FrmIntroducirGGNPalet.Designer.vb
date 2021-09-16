<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirGGNPalet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntroducirGGNPalet))
        Me.LbGGN1 = New NetAgro.Lb(Me.components)
        Me.TxGGN1 = New NetAgro.TxDato(Me.components)
        Me.TxIdPalet = New NetAgro.TxDato(Me.components)
        Me.LbIdPalet = New NetAgro.Lb(Me.components)
        Me.LbGGN2 = New NetAgro.Lb(Me.components)
        Me.TxGGN2 = New NetAgro.TxDato(Me.components)
        Me.LbGGN3 = New NetAgro.Lb(Me.components)
        Me.TxGGN3 = New NetAgro.TxDato(Me.components)
        Me.LbGGN4 = New NetAgro.Lb(Me.components)
        Me.TxGGN4 = New NetAgro.TxDato(Me.components)
        Me.TxSufijoGGN1 = New NetAgro.TxDato(Me.components)
        Me.LbSufijoGGN1 = New NetAgro.Lb(Me.components)
        Me.LbSufijoGGN2 = New NetAgro.Lb(Me.components)
        Me.TxSufijoGGN2 = New NetAgro.TxDato(Me.components)
        Me.LbSufijoGGN3 = New NetAgro.Lb(Me.components)
        Me.TxSufijoGGN3 = New NetAgro.TxDato(Me.components)
        Me.LbSufijoGGN4 = New NetAgro.Lb(Me.components)
        Me.TxSufijoGGN4 = New NetAgro.TxDato(Me.components)
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'LbGGN1
        '
        Me.LbGGN1.AutoSize = True
        Me.LbGGN1.CL_ControlAsociado = Nothing
        Me.LbGGN1.CL_ValorFijo = False
        Me.LbGGN1.ClForm = Nothing
        Me.LbGGN1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbGGN1.ForeColor = System.Drawing.Color.Teal
        Me.LbGGN1.Location = New System.Drawing.Point(20, 38)
        Me.LbGGN1.Name = "LbGGN1"
        Me.LbGGN1.Size = New System.Drawing.Size(58, 18)
        Me.LbGGN1.TabIndex = 38
        Me.LbGGN1.Text = "GGN1"
        '
        'TxGGN1
        '
        Me.TxGGN1.Autonumerico = False
        Me.TxGGN1.Buscando = False
        Me.TxGGN1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGGN1.ClForm = Nothing
        Me.TxGGN1.ClParam = Nothing
        Me.TxGGN1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxGGN1.GridLin = Nothing
        Me.TxGGN1.HaCambiado = False
        Me.TxGGN1.lbbusca = Nothing
        Me.TxGGN1.Location = New System.Drawing.Point(94, 32)
        Me.TxGGN1.MiError = False
        Me.TxGGN1.Name = "TxGGN1"
        Me.TxGGN1.Orden = 0
        Me.TxGGN1.SaltoAlfinal = False
        Me.TxGGN1.Siguiente = 0
        Me.TxGGN1.Size = New System.Drawing.Size(253, 30)
        Me.TxGGN1.TabIndex = 37
        Me.TxGGN1.TeclaRepetida = False
        Me.TxGGN1.TxDatoFinalSemana = Nothing
        Me.TxGGN1.TxDatoInicioSemana = Nothing
        Me.TxGGN1.UltimoValorValidado = Nothing
        '
        'TxIdPalet
        '
        Me.TxIdPalet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxIdPalet.Autonumerico = False
        Me.TxIdPalet.Buscando = False
        Me.TxIdPalet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxIdPalet.ClForm = Nothing
        Me.TxIdPalet.ClParam = Nothing
        Me.TxIdPalet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdPalet.GridLin = Nothing
        Me.TxIdPalet.HaCambiado = False
        Me.TxIdPalet.lbbusca = Nothing
        Me.TxIdPalet.Location = New System.Drawing.Point(101, 7)
        Me.TxIdPalet.MiError = False
        Me.TxIdPalet.Name = "TxIdPalet"
        Me.TxIdPalet.Orden = 0
        Me.TxIdPalet.SaltoAlfinal = False
        Me.TxIdPalet.Siguiente = 0
        Me.TxIdPalet.Size = New System.Drawing.Size(86, 22)
        Me.TxIdPalet.TabIndex = 40
        Me.TxIdPalet.TeclaRepetida = False
        Me.TxIdPalet.TxDatoFinalSemana = Nothing
        Me.TxIdPalet.TxDatoInicioSemana = Nothing
        Me.TxIdPalet.UltimoValorValidado = Nothing
        Me.TxIdPalet.Visible = False
        '
        'LbIdPalet
        '
        Me.LbIdPalet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbIdPalet.AutoSize = True
        Me.LbIdPalet.CL_ControlAsociado = Nothing
        Me.LbIdPalet.CL_ValorFijo = False
        Me.LbIdPalet.ClForm = Nothing
        Me.LbIdPalet.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdPalet.ForeColor = System.Drawing.Color.Teal
        Me.LbIdPalet.Location = New System.Drawing.Point(72, 9)
        Me.LbIdPalet.Name = "LbIdPalet"
        Me.LbIdPalet.Size = New System.Drawing.Size(23, 16)
        Me.LbIdPalet.TabIndex = 41
        Me.LbIdPalet.Text = "Id"
        Me.LbIdPalet.Visible = False
        '
        'LbGGN2
        '
        Me.LbGGN2.AutoSize = True
        Me.LbGGN2.CL_ControlAsociado = Nothing
        Me.LbGGN2.CL_ValorFijo = False
        Me.LbGGN2.ClForm = Nothing
        Me.LbGGN2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbGGN2.ForeColor = System.Drawing.Color.Teal
        Me.LbGGN2.Location = New System.Drawing.Point(20, 71)
        Me.LbGGN2.Name = "LbGGN2"
        Me.LbGGN2.Size = New System.Drawing.Size(58, 18)
        Me.LbGGN2.TabIndex = 43
        Me.LbGGN2.Text = "GGN2"
        '
        'TxGGN2
        '
        Me.TxGGN2.Autonumerico = False
        Me.TxGGN2.Buscando = False
        Me.TxGGN2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGGN2.ClForm = Nothing
        Me.TxGGN2.ClParam = Nothing
        Me.TxGGN2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxGGN2.GridLin = Nothing
        Me.TxGGN2.HaCambiado = False
        Me.TxGGN2.lbbusca = Nothing
        Me.TxGGN2.Location = New System.Drawing.Point(94, 65)
        Me.TxGGN2.MiError = False
        Me.TxGGN2.Name = "TxGGN2"
        Me.TxGGN2.Orden = 0
        Me.TxGGN2.SaltoAlfinal = False
        Me.TxGGN2.Siguiente = 0
        Me.TxGGN2.Size = New System.Drawing.Size(253, 30)
        Me.TxGGN2.TabIndex = 42
        Me.TxGGN2.TeclaRepetida = False
        Me.TxGGN2.TxDatoFinalSemana = Nothing
        Me.TxGGN2.TxDatoInicioSemana = Nothing
        Me.TxGGN2.UltimoValorValidado = Nothing
        '
        'LbGGN3
        '
        Me.LbGGN3.AutoSize = True
        Me.LbGGN3.CL_ControlAsociado = Nothing
        Me.LbGGN3.CL_ValorFijo = False
        Me.LbGGN3.ClForm = Nothing
        Me.LbGGN3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbGGN3.ForeColor = System.Drawing.Color.Teal
        Me.LbGGN3.Location = New System.Drawing.Point(20, 104)
        Me.LbGGN3.Name = "LbGGN3"
        Me.LbGGN3.Size = New System.Drawing.Size(58, 18)
        Me.LbGGN3.TabIndex = 45
        Me.LbGGN3.Text = "GGN3"
        '
        'TxGGN3
        '
        Me.TxGGN3.Autonumerico = False
        Me.TxGGN3.Buscando = False
        Me.TxGGN3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGGN3.ClForm = Nothing
        Me.TxGGN3.ClParam = Nothing
        Me.TxGGN3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxGGN3.GridLin = Nothing
        Me.TxGGN3.HaCambiado = False
        Me.TxGGN3.lbbusca = Nothing
        Me.TxGGN3.Location = New System.Drawing.Point(94, 98)
        Me.TxGGN3.MiError = False
        Me.TxGGN3.Name = "TxGGN3"
        Me.TxGGN3.Orden = 0
        Me.TxGGN3.SaltoAlfinal = False
        Me.TxGGN3.Siguiente = 0
        Me.TxGGN3.Size = New System.Drawing.Size(253, 30)
        Me.TxGGN3.TabIndex = 44
        Me.TxGGN3.TeclaRepetida = False
        Me.TxGGN3.TxDatoFinalSemana = Nothing
        Me.TxGGN3.TxDatoInicioSemana = Nothing
        Me.TxGGN3.UltimoValorValidado = Nothing
        '
        'LbGGN4
        '
        Me.LbGGN4.AutoSize = True
        Me.LbGGN4.CL_ControlAsociado = Nothing
        Me.LbGGN4.CL_ValorFijo = False
        Me.LbGGN4.ClForm = Nothing
        Me.LbGGN4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbGGN4.ForeColor = System.Drawing.Color.Teal
        Me.LbGGN4.Location = New System.Drawing.Point(20, 137)
        Me.LbGGN4.Name = "LbGGN4"
        Me.LbGGN4.Size = New System.Drawing.Size(58, 18)
        Me.LbGGN4.TabIndex = 47
        Me.LbGGN4.Text = "GGN4"
        '
        'TxGGN4
        '
        Me.TxGGN4.Autonumerico = False
        Me.TxGGN4.Buscando = False
        Me.TxGGN4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxGGN4.ClForm = Nothing
        Me.TxGGN4.ClParam = Nothing
        Me.TxGGN4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxGGN4.GridLin = Nothing
        Me.TxGGN4.HaCambiado = False
        Me.TxGGN4.lbbusca = Nothing
        Me.TxGGN4.Location = New System.Drawing.Point(94, 131)
        Me.TxGGN4.MiError = False
        Me.TxGGN4.Name = "TxGGN4"
        Me.TxGGN4.Orden = 0
        Me.TxGGN4.SaltoAlfinal = False
        Me.TxGGN4.Siguiente = 0
        Me.TxGGN4.Size = New System.Drawing.Size(253, 30)
        Me.TxGGN4.TabIndex = 46
        Me.TxGGN4.TeclaRepetida = False
        Me.TxGGN4.TxDatoFinalSemana = Nothing
        Me.TxGGN4.TxDatoInicioSemana = Nothing
        Me.TxGGN4.UltimoValorValidado = Nothing
        '
        'TxSufijoGGN1
        '
        Me.TxSufijoGGN1.Autonumerico = False
        Me.TxSufijoGGN1.Buscando = False
        Me.TxSufijoGGN1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSufijoGGN1.ClForm = Nothing
        Me.TxSufijoGGN1.ClParam = Nothing
        Me.TxSufijoGGN1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxSufijoGGN1.GridLin = Nothing
        Me.TxSufijoGGN1.HaCambiado = False
        Me.TxSufijoGGN1.lbbusca = Nothing
        Me.TxSufijoGGN1.Location = New System.Drawing.Point(366, 32)
        Me.TxSufijoGGN1.MiError = False
        Me.TxSufijoGGN1.Name = "TxSufijoGGN1"
        Me.TxSufijoGGN1.Orden = 0
        Me.TxSufijoGGN1.SaltoAlfinal = False
        Me.TxSufijoGGN1.Siguiente = 0
        Me.TxSufijoGGN1.Size = New System.Drawing.Size(40, 30)
        Me.TxSufijoGGN1.TabIndex = 48
        Me.TxSufijoGGN1.TeclaRepetida = False
        Me.TxSufijoGGN1.TxDatoFinalSemana = Nothing
        Me.TxSufijoGGN1.TxDatoInicioSemana = Nothing
        Me.TxSufijoGGN1.UltimoValorValidado = Nothing
        '
        'LbSufijoGGN1
        '
        Me.LbSufijoGGN1.AutoSize = True
        Me.LbSufijoGGN1.CL_ControlAsociado = Nothing
        Me.LbSufijoGGN1.CL_ValorFijo = False
        Me.LbSufijoGGN1.ClForm = Nothing
        Me.LbSufijoGGN1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbSufijoGGN1.ForeColor = System.Drawing.Color.Teal
        Me.LbSufijoGGN1.Location = New System.Drawing.Point(349, 38)
        Me.LbSufijoGGN1.Name = "LbSufijoGGN1"
        Me.LbSufijoGGN1.Size = New System.Drawing.Size(16, 18)
        Me.LbSufijoGGN1.TabIndex = 49
        Me.LbSufijoGGN1.Text = "-"
        '
        'LbSufijoGGN2
        '
        Me.LbSufijoGGN2.AutoSize = True
        Me.LbSufijoGGN2.CL_ControlAsociado = Nothing
        Me.LbSufijoGGN2.CL_ValorFijo = False
        Me.LbSufijoGGN2.ClForm = Nothing
        Me.LbSufijoGGN2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbSufijoGGN2.ForeColor = System.Drawing.Color.Teal
        Me.LbSufijoGGN2.Location = New System.Drawing.Point(349, 71)
        Me.LbSufijoGGN2.Name = "LbSufijoGGN2"
        Me.LbSufijoGGN2.Size = New System.Drawing.Size(16, 18)
        Me.LbSufijoGGN2.TabIndex = 51
        Me.LbSufijoGGN2.Text = "-"
        '
        'TxSufijoGGN2
        '
        Me.TxSufijoGGN2.Autonumerico = False
        Me.TxSufijoGGN2.Buscando = False
        Me.TxSufijoGGN2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSufijoGGN2.ClForm = Nothing
        Me.TxSufijoGGN2.ClParam = Nothing
        Me.TxSufijoGGN2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxSufijoGGN2.GridLin = Nothing
        Me.TxSufijoGGN2.HaCambiado = False
        Me.TxSufijoGGN2.lbbusca = Nothing
        Me.TxSufijoGGN2.Location = New System.Drawing.Point(366, 65)
        Me.TxSufijoGGN2.MiError = False
        Me.TxSufijoGGN2.Name = "TxSufijoGGN2"
        Me.TxSufijoGGN2.Orden = 0
        Me.TxSufijoGGN2.SaltoAlfinal = False
        Me.TxSufijoGGN2.Siguiente = 0
        Me.TxSufijoGGN2.Size = New System.Drawing.Size(40, 30)
        Me.TxSufijoGGN2.TabIndex = 50
        Me.TxSufijoGGN2.TeclaRepetida = False
        Me.TxSufijoGGN2.TxDatoFinalSemana = Nothing
        Me.TxSufijoGGN2.TxDatoInicioSemana = Nothing
        Me.TxSufijoGGN2.UltimoValorValidado = Nothing
        '
        'LbSufijoGGN3
        '
        Me.LbSufijoGGN3.AutoSize = True
        Me.LbSufijoGGN3.CL_ControlAsociado = Nothing
        Me.LbSufijoGGN3.CL_ValorFijo = False
        Me.LbSufijoGGN3.ClForm = Nothing
        Me.LbSufijoGGN3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbSufijoGGN3.ForeColor = System.Drawing.Color.Teal
        Me.LbSufijoGGN3.Location = New System.Drawing.Point(349, 104)
        Me.LbSufijoGGN3.Name = "LbSufijoGGN3"
        Me.LbSufijoGGN3.Size = New System.Drawing.Size(16, 18)
        Me.LbSufijoGGN3.TabIndex = 53
        Me.LbSufijoGGN3.Text = "-"
        '
        'TxSufijoGGN3
        '
        Me.TxSufijoGGN3.Autonumerico = False
        Me.TxSufijoGGN3.Buscando = False
        Me.TxSufijoGGN3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSufijoGGN3.ClForm = Nothing
        Me.TxSufijoGGN3.ClParam = Nothing
        Me.TxSufijoGGN3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxSufijoGGN3.GridLin = Nothing
        Me.TxSufijoGGN3.HaCambiado = False
        Me.TxSufijoGGN3.lbbusca = Nothing
        Me.TxSufijoGGN3.Location = New System.Drawing.Point(366, 98)
        Me.TxSufijoGGN3.MiError = False
        Me.TxSufijoGGN3.Name = "TxSufijoGGN3"
        Me.TxSufijoGGN3.Orden = 0
        Me.TxSufijoGGN3.SaltoAlfinal = False
        Me.TxSufijoGGN3.Siguiente = 0
        Me.TxSufijoGGN3.Size = New System.Drawing.Size(40, 30)
        Me.TxSufijoGGN3.TabIndex = 52
        Me.TxSufijoGGN3.TeclaRepetida = False
        Me.TxSufijoGGN3.TxDatoFinalSemana = Nothing
        Me.TxSufijoGGN3.TxDatoInicioSemana = Nothing
        Me.TxSufijoGGN3.UltimoValorValidado = Nothing
        '
        'LbSufijoGGN4
        '
        Me.LbSufijoGGN4.AutoSize = True
        Me.LbSufijoGGN4.CL_ControlAsociado = Nothing
        Me.LbSufijoGGN4.CL_ValorFijo = False
        Me.LbSufijoGGN4.ClForm = Nothing
        Me.LbSufijoGGN4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbSufijoGGN4.ForeColor = System.Drawing.Color.Teal
        Me.LbSufijoGGN4.Location = New System.Drawing.Point(349, 137)
        Me.LbSufijoGGN4.Name = "LbSufijoGGN4"
        Me.LbSufijoGGN4.Size = New System.Drawing.Size(16, 18)
        Me.LbSufijoGGN4.TabIndex = 55
        Me.LbSufijoGGN4.Text = "-"
        '
        'TxSufijoGGN4
        '
        Me.TxSufijoGGN4.Autonumerico = False
        Me.TxSufijoGGN4.Buscando = False
        Me.TxSufijoGGN4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxSufijoGGN4.ClForm = Nothing
        Me.TxSufijoGGN4.ClParam = Nothing
        Me.TxSufijoGGN4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TxSufijoGGN4.GridLin = Nothing
        Me.TxSufijoGGN4.HaCambiado = False
        Me.TxSufijoGGN4.lbbusca = Nothing
        Me.TxSufijoGGN4.Location = New System.Drawing.Point(366, 131)
        Me.TxSufijoGGN4.MiError = False
        Me.TxSufijoGGN4.Name = "TxSufijoGGN4"
        Me.TxSufijoGGN4.Orden = 0
        Me.TxSufijoGGN4.SaltoAlfinal = False
        Me.TxSufijoGGN4.Siguiente = 0
        Me.TxSufijoGGN4.Size = New System.Drawing.Size(40, 30)
        Me.TxSufijoGGN4.TabIndex = 54
        Me.TxSufijoGGN4.TeclaRepetida = False
        Me.TxSufijoGGN4.TxDatoFinalSemana = Nothing
        Me.TxSufijoGGN4.TxDatoInicioSemana = Nothing
        Me.TxSufijoGGN4.UltimoValorValidado = Nothing
        '
        'FrmIntroducirGGNPalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(434, 222)
        Me.Controls.Add(Me.LbSufijoGGN4)
        Me.Controls.Add(Me.TxSufijoGGN4)
        Me.Controls.Add(Me.LbSufijoGGN3)
        Me.Controls.Add(Me.TxSufijoGGN3)
        Me.Controls.Add(Me.LbSufijoGGN2)
        Me.Controls.Add(Me.TxSufijoGGN2)
        Me.Controls.Add(Me.LbSufijoGGN1)
        Me.Controls.Add(Me.TxSufijoGGN1)
        Me.Controls.Add(Me.LbGGN4)
        Me.Controls.Add(Me.TxGGN4)
        Me.Controls.Add(Me.LbGGN3)
        Me.Controls.Add(Me.TxGGN3)
        Me.Controls.Add(Me.LbGGN2)
        Me.Controls.Add(Me.TxGGN2)
        Me.Controls.Add(Me.LbIdPalet)
        Me.Controls.Add(Me.TxIdPalet)
        Me.Controls.Add(Me.LbGGN1)
        Me.Controls.Add(Me.TxGGN1)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmIntroducirGGNPalet"
        Me.Text = "Introducir GGN Palet"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxGGN1, 0)
        Me.Controls.SetChildIndex(Me.LbGGN1, 0)
        Me.Controls.SetChildIndex(Me.TxIdPalet, 0)
        Me.Controls.SetChildIndex(Me.LbIdPalet, 0)
        Me.Controls.SetChildIndex(Me.TxGGN2, 0)
        Me.Controls.SetChildIndex(Me.LbGGN2, 0)
        Me.Controls.SetChildIndex(Me.TxGGN3, 0)
        Me.Controls.SetChildIndex(Me.LbGGN3, 0)
        Me.Controls.SetChildIndex(Me.TxGGN4, 0)
        Me.Controls.SetChildIndex(Me.LbGGN4, 0)
        Me.Controls.SetChildIndex(Me.TxSufijoGGN1, 0)
        Me.Controls.SetChildIndex(Me.LbSufijoGGN1, 0)
        Me.Controls.SetChildIndex(Me.TxSufijoGGN2, 0)
        Me.Controls.SetChildIndex(Me.LbSufijoGGN2, 0)
        Me.Controls.SetChildIndex(Me.TxSufijoGGN3, 0)
        Me.Controls.SetChildIndex(Me.LbSufijoGGN3, 0)
        Me.Controls.SetChildIndex(Me.TxSufijoGGN4, 0)
        Me.Controls.SetChildIndex(Me.LbSufijoGGN4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbGGN1 As NetAgro.Lb
    Friend WithEvents TxGGN1 As NetAgro.TxDato
    Friend WithEvents TxIdPalet As NetAgro.TxDato
    Friend WithEvents LbIdPalet As NetAgro.Lb
    Friend WithEvents LbGGN2 As NetAgro.Lb
    Friend WithEvents TxGGN2 As NetAgro.TxDato
    Friend WithEvents LbGGN3 As NetAgro.Lb
    Friend WithEvents TxGGN3 As NetAgro.TxDato
    Friend WithEvents LbGGN4 As NetAgro.Lb
    Friend WithEvents TxGGN4 As NetAgro.TxDato
    Friend WithEvents TxSufijoGGN1 As NetAgro.TxDato
    Friend WithEvents LbSufijoGGN1 As NetAgro.Lb
    Friend WithEvents LbSufijoGGN2 As NetAgro.Lb
    Friend WithEvents TxSufijoGGN2 As NetAgro.TxDato
    Friend WithEvents LbSufijoGGN3 As NetAgro.Lb
    Friend WithEvents TxSufijoGGN3 As NetAgro.TxDato
    Friend WithEvents LbSufijoGGN4 As NetAgro.Lb
    Friend WithEvents TxSufijoGGN4 As NetAgro.TxDato
End Class
