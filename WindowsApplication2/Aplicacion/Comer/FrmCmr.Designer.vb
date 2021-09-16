<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCmr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCmr))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ChkImprimirEtiqueta = New NetAgro.Chk(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LbIdCliente = New NetAgro.Lb(Me.components)
        Me.TxNumRegTemp = New NetAgro.TxDato(Me.components)
        Me.LbNumRegTemp = New NetAgro.Lb(Me.components)
        Me.TxMovilChofer = New NetAgro.TxDato(Me.components)
        Me.LbMovilChofer = New NetAgro.Lb(Me.components)
        Me.TxDato_13 = New NetAgro.TxDato(Me.components)
        Me.Lb13 = New NetAgro.Lb(Me.components)
        Me.TxDato_8 = New NetAgro.TxDato(Me.components)
        Me.Lb_8 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.TxDato_7 = New NetAgro.TxDato(Me.components)
        Me.Lb_7 = New NetAgro.Lb(Me.components)
        Me.TxDato_12 = New NetAgro.TxDato(Me.components)
        Me.TxDato_11 = New NetAgro.TxDato(Me.components)
        Me.TxDato_10 = New NetAgro.TxDato(Me.components)
        Me.TxDato_9 = New NetAgro.TxDato(Me.components)
        Me.Lb_9 = New NetAgro.Lb(Me.components)
        Me.TxDato_6 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_4 = New NetAgro.Lb(Me.components)
        Me.Lb_4 = New NetAgro.Lb(Me.components)
        Me.TxDato_4 = New NetAgro.TxDato(Me.components)
        Me.TxDato_5 = New NetAgro.TxDato(Me.components)
        Me.Lb_5 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbNomCentro = New NetAgro.Lb(Me.components)
        Me.LbCentro = New NetAgro.Lb(Me.components)
        Me.Lb29 = New NetAgro.Lb(Me.components)
        Me.LbCampa = New NetAgro.Lb(Me.components)
        Me.Lb_2 = New NetAgro.Lb(Me.components)
        Me.TxDato_2 = New NetAgro.TxDato(Me.components)
        Me.LbNom_Cliente = New NetAgro.Lb(Me.components)
        Me.Lb_3 = New NetAgro.Lb(Me.components)
        Me.BtBuscaAlbaran = New NetAgro.BtBusca(Me.components)
        Me.TxDato_1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lb_nom52 = New NetAgro.Lb(Me.components)
        Me.TxDato_52 = New NetAgro.TxDato(Me.components)
        Me.Lb_52 = New NetAgro.Lb(Me.components)
        Me.BtBusca_52 = New NetAgro.BtBusca(Me.components)
        Me.Lb_57 = New NetAgro.Lb(Me.components)
        Me.TxDato_57 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_51 = New NetAgro.Lb(Me.components)
        Me.TxDato_51 = New NetAgro.TxDato(Me.components)
        Me.Lb_51 = New NetAgro.Lb(Me.components)
        Me.BtBusca_51 = New NetAgro.BtBusca(Me.components)
        Me.TxDato_53 = New NetAgro.TxDato(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_53 = New NetAgro.Lb(Me.components)
        Me.Lb_55 = New NetAgro.Lb(Me.components)
        Me.TxDato_55 = New NetAgro.TxDato(Me.components)
        Me.Lb_54 = New NetAgro.Lb(Me.components)
        Me.TxDato_54 = New NetAgro.TxDato(Me.components)
        Me.Lbnom_50 = New NetAgro.Lb(Me.components)
        Me.TxDato_50 = New NetAgro.TxDato(Me.components)
        Me.Lb_50 = New NetAgro.Lb(Me.components)
        Me.BtBusca_50 = New NetAgro.BtBusca(Me.components)
        Me.Lb_56 = New NetAgro.Lb(Me.components)
        Me.TxDato_56 = New NetAgro.TxDato(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.ChkImprimirEtiqueta)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.LbIdCliente)
        Me.Panel4.Controls.Add(Me.TxNumRegTemp)
        Me.Panel4.Controls.Add(Me.LbNumRegTemp)
        Me.Panel4.Controls.Add(Me.TxMovilChofer)
        Me.Panel4.Controls.Add(Me.LbMovilChofer)
        Me.Panel4.Controls.Add(Me.TxDato_13)
        Me.Panel4.Controls.Add(Me.Lb13)
        Me.Panel4.Controls.Add(Me.TxDato_8)
        Me.Panel4.Controls.Add(Me.Lb_8)
        Me.Panel4.Controls.Add(Me.Lb6)
        Me.Panel4.Controls.Add(Me.TxDato_7)
        Me.Panel4.Controls.Add(Me.Lb_7)
        Me.Panel4.Controls.Add(Me.TxDato_12)
        Me.Panel4.Controls.Add(Me.TxDato_11)
        Me.Panel4.Controls.Add(Me.TxDato_10)
        Me.Panel4.Controls.Add(Me.TxDato_9)
        Me.Panel4.Controls.Add(Me.Lb_9)
        Me.Panel4.Controls.Add(Me.TxDato_6)
        Me.Panel4.Controls.Add(Me.Lbnom_4)
        Me.Panel4.Controls.Add(Me.Lb_4)
        Me.Panel4.Controls.Add(Me.TxDato_4)
        Me.Panel4.Controls.Add(Me.TxDato_5)
        Me.Panel4.Controls.Add(Me.Lb_5)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.LbCampa)
        Me.Panel4.Controls.Add(Me.Lb_2)
        Me.Panel4.Controls.Add(Me.TxDato_2)
        Me.Panel4.Controls.Add(Me.LbNom_Cliente)
        Me.Panel4.Controls.Add(Me.Lb_3)
        Me.Panel4.Controls.Add(Me.BtBuscaAlbaran)
        Me.Panel4.Controls.Add(Me.Lb1)
        Me.Panel4.Controls.Add(Me.TxDato_1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1202, 227)
        Me.Panel4.TabIndex = 72
        '
        'ChkImprimirEtiqueta
        '
        Me.ChkImprimirEtiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkImprimirEtiqueta.AutoSize = True
        Me.ChkImprimirEtiqueta.Campobd = Nothing
        Me.ChkImprimirEtiqueta.ClForm = Nothing
        Me.ChkImprimirEtiqueta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkImprimirEtiqueta.ForeColor = System.Drawing.Color.Teal
        Me.ChkImprimirEtiqueta.GridLin = Nothing
        Me.ChkImprimirEtiqueta.HaCambiado = False
        Me.ChkImprimirEtiqueta.Location = New System.Drawing.Point(668, 12)
        Me.ChkImprimirEtiqueta.MiEntidad = Nothing
        Me.ChkImprimirEtiqueta.MiError = False
        Me.ChkImprimirEtiqueta.Name = "ChkImprimirEtiqueta"
        Me.ChkImprimirEtiqueta.Orden = 0
        Me.ChkImprimirEtiqueta.SaltoAlfinal = False
        Me.ChkImprimirEtiqueta.Size = New System.Drawing.Size(155, 20)
        Me.ChkImprimirEtiqueta.TabIndex = 100402
        Me.ChkImprimirEtiqueta.Text = "Imprimir Etiqueta"
        Me.ChkImprimirEtiqueta.UseVisualStyleBackColor = True
        Me.ChkImprimirEtiqueta.ValorCampoFalse = Nothing
        Me.ChkImprimirEtiqueta.ValorCampoTrue = Nothing
        Me.ChkImprimirEtiqueta.ValorDefecto = False
        '
        'Button2
        '
        Me.Button2.Image = Global.NetAgro.My.Resources.Resources.Lupa16_
        Me.Button2.Location = New System.Drawing.Point(174, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 159
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbIdCliente
        '
        Me.LbIdCliente.BackColor = System.Drawing.Color.LightGray
        Me.LbIdCliente.CL_ControlAsociado = Nothing
        Me.LbIdCliente.CL_ValorFijo = False
        Me.LbIdCliente.ClForm = Nothing
        Me.LbIdCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIdCliente.Location = New System.Drawing.Point(120, 41)
        Me.LbIdCliente.Name = "LbIdCliente"
        Me.LbIdCliente.Size = New System.Drawing.Size(75, 18)
        Me.LbIdCliente.TabIndex = 158
        '
        'TxNumRegTemp
        '
        Me.TxNumRegTemp.Autonumerico = False
        Me.TxNumRegTemp.Buscando = False
        Me.TxNumRegTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumRegTemp.ClForm = Nothing
        Me.TxNumRegTemp.ClParam = Nothing
        Me.TxNumRegTemp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNumRegTemp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNumRegTemp.GridLin = Nothing
        Me.TxNumRegTemp.HaCambiado = False
        Me.TxNumRegTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxNumRegTemp.lbbusca = Nothing
        Me.TxNumRegTemp.Location = New System.Drawing.Point(986, 188)
        Me.TxNumRegTemp.MiError = False
        Me.TxNumRegTemp.Name = "TxNumRegTemp"
        Me.TxNumRegTemp.Orden = 0
        Me.TxNumRegTemp.SaltoAlfinal = False
        Me.TxNumRegTemp.Siguiente = 0
        Me.TxNumRegTemp.Size = New System.Drawing.Size(194, 22)
        Me.TxNumRegTemp.TabIndex = 157
        Me.TxNumRegTemp.TeclaRepetida = False
        Me.TxNumRegTemp.TxDatoFinalSemana = Nothing
        Me.TxNumRegTemp.TxDatoInicioSemana = Nothing
        Me.TxNumRegTemp.UltimoValorValidado = Nothing
        '
        'LbNumRegTemp
        '
        Me.LbNumRegTemp.AutoSize = True
        Me.LbNumRegTemp.CL_ControlAsociado = Nothing
        Me.LbNumRegTemp.CL_ValorFijo = True
        Me.LbNumRegTemp.ClForm = Nothing
        Me.LbNumRegTemp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumRegTemp.ForeColor = System.Drawing.Color.Teal
        Me.LbNumRegTemp.Location = New System.Drawing.Point(874, 190)
        Me.LbNumRegTemp.Name = "LbNumRegTemp"
        Me.LbNumRegTemp.Size = New System.Drawing.Size(106, 16)
        Me.LbNumRegTemp.TabIndex = 156
        Me.LbNumRegTemp.Text = "Nº Reg Temp."
        '
        'TxMovilChofer
        '
        Me.TxMovilChofer.Autonumerico = False
        Me.TxMovilChofer.Buscando = False
        Me.TxMovilChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxMovilChofer.ClForm = Nothing
        Me.TxMovilChofer.ClParam = Nothing
        Me.TxMovilChofer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxMovilChofer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxMovilChofer.GridLin = Nothing
        Me.TxMovilChofer.HaCambiado = False
        Me.TxMovilChofer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxMovilChofer.lbbusca = Nothing
        Me.TxMovilChofer.Location = New System.Drawing.Point(668, 188)
        Me.TxMovilChofer.MiError = False
        Me.TxMovilChofer.Name = "TxMovilChofer"
        Me.TxMovilChofer.Orden = 0
        Me.TxMovilChofer.SaltoAlfinal = False
        Me.TxMovilChofer.Siguiente = 0
        Me.TxMovilChofer.Size = New System.Drawing.Size(194, 22)
        Me.TxMovilChofer.TabIndex = 155
        Me.TxMovilChofer.TeclaRepetida = False
        Me.TxMovilChofer.TxDatoFinalSemana = Nothing
        Me.TxMovilChofer.TxDatoInicioSemana = Nothing
        Me.TxMovilChofer.UltimoValorValidado = Nothing
        '
        'LbMovilChofer
        '
        Me.LbMovilChofer.AutoSize = True
        Me.LbMovilChofer.CL_ControlAsociado = Nothing
        Me.LbMovilChofer.CL_ValorFijo = True
        Me.LbMovilChofer.ClForm = Nothing
        Me.LbMovilChofer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMovilChofer.ForeColor = System.Drawing.Color.Teal
        Me.LbMovilChofer.Location = New System.Drawing.Point(564, 190)
        Me.LbMovilChofer.Name = "LbMovilChofer"
        Me.LbMovilChofer.Size = New System.Drawing.Size(98, 16)
        Me.LbMovilChofer.TabIndex = 154
        Me.LbMovilChofer.Text = "Movil Chofer"
        '
        'TxDato_13
        '
        Me.TxDato_13.Autonumerico = False
        Me.TxDato_13.Buscando = False
        Me.TxDato_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_13.ClForm = Nothing
        Me.TxDato_13.ClParam = Nothing
        Me.TxDato_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_13.GridLin = Nothing
        Me.TxDato_13.HaCambiado = False
        Me.TxDato_13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_13.lbbusca = Nothing
        Me.TxDato_13.Location = New System.Drawing.Point(498, 156)
        Me.TxDato_13.MiError = False
        Me.TxDato_13.Name = "TxDato_13"
        Me.TxDato_13.Orden = 0
        Me.TxDato_13.SaltoAlfinal = False
        Me.TxDato_13.Siguiente = 0
        Me.TxDato_13.Size = New System.Drawing.Size(35, 22)
        Me.TxDato_13.TabIndex = 153
        Me.TxDato_13.TeclaRepetida = False
        Me.TxDato_13.TxDatoFinalSemana = Nothing
        Me.TxDato_13.TxDatoInicioSemana = Nothing
        Me.TxDato_13.UltimoValorValidado = Nothing
        '
        'Lb13
        '
        Me.Lb13.AutoSize = True
        Me.Lb13.CL_ControlAsociado = Nothing
        Me.Lb13.CL_ValorFijo = False
        Me.Lb13.ClForm = Nothing
        Me.Lb13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb13.ForeColor = System.Drawing.Color.Teal
        Me.Lb13.Location = New System.Drawing.Point(454, 158)
        Me.Lb13.Name = "Lb13"
        Me.Lb13.Size = New System.Drawing.Size(38, 16)
        Me.Lb13.TabIndex = 152
        Me.Lb13.Text = "O/D"
        '
        'TxDato_8
        '
        Me.TxDato_8.Autonumerico = False
        Me.TxDato_8.Buscando = False
        Me.TxDato_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_8.ClForm = Nothing
        Me.TxDato_8.ClParam = Nothing
        Me.TxDato_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_8.GridLin = Nothing
        Me.TxDato_8.HaCambiado = False
        Me.TxDato_8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_8.lbbusca = Nothing
        Me.TxDato_8.Location = New System.Drawing.Point(120, 188)
        Me.TxDato_8.MiError = False
        Me.TxDato_8.Name = "TxDato_8"
        Me.TxDato_8.Orden = 0
        Me.TxDato_8.SaltoAlfinal = False
        Me.TxDato_8.Siguiente = 0
        Me.TxDato_8.Size = New System.Drawing.Size(416, 22)
        Me.TxDato_8.TabIndex = 151
        Me.TxDato_8.TeclaRepetida = False
        Me.TxDato_8.TxDatoFinalSemana = Nothing
        Me.TxDato_8.TxDatoInicioSemana = Nothing
        Me.TxDato_8.UltimoValorValidado = Nothing
        '
        'Lb_8
        '
        Me.Lb_8.AutoSize = True
        Me.Lb_8.CL_ControlAsociado = Nothing
        Me.Lb_8.CL_ValorFijo = False
        Me.Lb_8.ClForm = Nothing
        Me.Lb_8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_8.ForeColor = System.Drawing.Color.Teal
        Me.Lb_8.Location = New System.Drawing.Point(12, 190)
        Me.Lb_8.Name = "Lb_8"
        Me.Lb_8.Size = New System.Drawing.Size(41, 16)
        Me.Lb_8.TabIndex = 150
        Me.Lb_8.Text = "Obs."
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = True
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(160, 146)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(84, 52)
        Me.Lb6.TabIndex = 149
        Me.Lb6.Text = "C=CMR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T=Transitario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D=DCTMC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxDato_7
        '
        Me.TxDato_7.Autonumerico = False
        Me.TxDato_7.Buscando = False
        Me.TxDato_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_7.ClForm = Nothing
        Me.TxDato_7.ClParam = Nothing
        Me.TxDato_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_7.GridLin = Nothing
        Me.TxDato_7.HaCambiado = False
        Me.TxDato_7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_7.lbbusca = Nothing
        Me.TxDato_7.Location = New System.Drawing.Point(119, 156)
        Me.TxDato_7.MiError = False
        Me.TxDato_7.Name = "TxDato_7"
        Me.TxDato_7.Orden = 0
        Me.TxDato_7.SaltoAlfinal = False
        Me.TxDato_7.Siguiente = 0
        Me.TxDato_7.Size = New System.Drawing.Size(35, 22)
        Me.TxDato_7.TabIndex = 148
        Me.TxDato_7.TeclaRepetida = False
        Me.TxDato_7.TxDatoFinalSemana = Nothing
        Me.TxDato_7.TxDatoInicioSemana = Nothing
        Me.TxDato_7.UltimoValorValidado = Nothing
        '
        'Lb_7
        '
        Me.Lb_7.AutoSize = True
        Me.Lb_7.CL_ControlAsociado = Nothing
        Me.Lb_7.CL_ValorFijo = False
        Me.Lb_7.ClForm = Nothing
        Me.Lb_7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_7.ForeColor = System.Drawing.Color.Teal
        Me.Lb_7.Location = New System.Drawing.Point(12, 158)
        Me.Lb_7.Name = "Lb_7"
        Me.Lb_7.Size = New System.Drawing.Size(73, 16)
        Me.Lb_7.TabIndex = 147
        Me.Lb_7.Text = "Tipo doc."
        '
        'TxDato_12
        '
        Me.TxDato_12.Autonumerico = False
        Me.TxDato_12.Buscando = False
        Me.TxDato_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_12.ClForm = Nothing
        Me.TxDato_12.ClParam = Nothing
        Me.TxDato_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_12.GridLin = Nothing
        Me.TxDato_12.HaCambiado = False
        Me.TxDato_12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_12.lbbusca = Nothing
        Me.TxDato_12.Location = New System.Drawing.Point(668, 156)
        Me.TxDato_12.MiError = False
        Me.TxDato_12.Name = "TxDato_12"
        Me.TxDato_12.Orden = 0
        Me.TxDato_12.SaltoAlfinal = False
        Me.TxDato_12.Siguiente = 0
        Me.TxDato_12.Size = New System.Drawing.Size(512, 22)
        Me.TxDato_12.TabIndex = 146
        Me.TxDato_12.TeclaRepetida = False
        Me.TxDato_12.TxDatoFinalSemana = Nothing
        Me.TxDato_12.TxDatoInicioSemana = Nothing
        Me.TxDato_12.UltimoValorValidado = Nothing
        '
        'TxDato_11
        '
        Me.TxDato_11.Autonumerico = False
        Me.TxDato_11.Buscando = False
        Me.TxDato_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_11.ClForm = Nothing
        Me.TxDato_11.ClParam = Nothing
        Me.TxDato_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_11.GridLin = Nothing
        Me.TxDato_11.HaCambiado = False
        Me.TxDato_11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_11.lbbusca = Nothing
        Me.TxDato_11.Location = New System.Drawing.Point(668, 128)
        Me.TxDato_11.MiError = False
        Me.TxDato_11.Name = "TxDato_11"
        Me.TxDato_11.Orden = 0
        Me.TxDato_11.SaltoAlfinal = False
        Me.TxDato_11.Siguiente = 0
        Me.TxDato_11.Size = New System.Drawing.Size(512, 22)
        Me.TxDato_11.TabIndex = 145
        Me.TxDato_11.TeclaRepetida = False
        Me.TxDato_11.TxDatoFinalSemana = Nothing
        Me.TxDato_11.TxDatoInicioSemana = Nothing
        Me.TxDato_11.UltimoValorValidado = Nothing
        '
        'TxDato_10
        '
        Me.TxDato_10.Autonumerico = False
        Me.TxDato_10.Buscando = False
        Me.TxDato_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_10.ClForm = Nothing
        Me.TxDato_10.ClParam = Nothing
        Me.TxDato_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_10.GridLin = Nothing
        Me.TxDato_10.HaCambiado = False
        Me.TxDato_10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_10.lbbusca = Nothing
        Me.TxDato_10.Location = New System.Drawing.Point(668, 102)
        Me.TxDato_10.MiError = False
        Me.TxDato_10.Name = "TxDato_10"
        Me.TxDato_10.Orden = 0
        Me.TxDato_10.SaltoAlfinal = False
        Me.TxDato_10.Siguiente = 0
        Me.TxDato_10.Size = New System.Drawing.Size(512, 22)
        Me.TxDato_10.TabIndex = 144
        Me.TxDato_10.TeclaRepetida = False
        Me.TxDato_10.TxDatoFinalSemana = Nothing
        Me.TxDato_10.TxDatoInicioSemana = Nothing
        Me.TxDato_10.UltimoValorValidado = Nothing
        '
        'TxDato_9
        '
        Me.TxDato_9.Autonumerico = False
        Me.TxDato_9.Buscando = False
        Me.TxDato_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_9.ClForm = Nothing
        Me.TxDato_9.ClParam = Nothing
        Me.TxDato_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_9.GridLin = Nothing
        Me.TxDato_9.HaCambiado = False
        Me.TxDato_9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_9.lbbusca = Nothing
        Me.TxDato_9.Location = New System.Drawing.Point(668, 78)
        Me.TxDato_9.MiError = False
        Me.TxDato_9.Name = "TxDato_9"
        Me.TxDato_9.Orden = 0
        Me.TxDato_9.SaltoAlfinal = False
        Me.TxDato_9.Siguiente = 0
        Me.TxDato_9.Size = New System.Drawing.Size(512, 22)
        Me.TxDato_9.TabIndex = 143
        Me.TxDato_9.TeclaRepetida = False
        Me.TxDato_9.TxDatoFinalSemana = Nothing
        Me.TxDato_9.TxDatoInicioSemana = Nothing
        Me.TxDato_9.UltimoValorValidado = Nothing
        '
        'Lb_9
        '
        Me.Lb_9.AutoSize = True
        Me.Lb_9.CL_ControlAsociado = Nothing
        Me.Lb_9.CL_ValorFijo = False
        Me.Lb_9.ClForm = Nothing
        Me.Lb_9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_9.ForeColor = System.Drawing.Color.Teal
        Me.Lb_9.Location = New System.Drawing.Point(669, 59)
        Me.Lb_9.Name = "Lb_9"
        Me.Lb_9.Size = New System.Drawing.Size(107, 16)
        Me.Lb_9.TabIndex = 142
        Me.Lb_9.Text = "Instrucciones"
        '
        'TxDato_6
        '
        Me.TxDato_6.Autonumerico = False
        Me.TxDato_6.Buscando = False
        Me.TxDato_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_6.ClForm = Nothing
        Me.TxDato_6.ClParam = Nothing
        Me.TxDato_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_6.GridLin = Nothing
        Me.TxDato_6.HaCambiado = False
        Me.TxDato_6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_6.lbbusca = Nothing
        Me.TxDato_6.Location = New System.Drawing.Point(120, 121)
        Me.TxDato_6.MiError = False
        Me.TxDato_6.Name = "TxDato_6"
        Me.TxDato_6.Orden = 0
        Me.TxDato_6.SaltoAlfinal = False
        Me.TxDato_6.Siguiente = 0
        Me.TxDato_6.Size = New System.Drawing.Size(416, 22)
        Me.TxDato_6.TabIndex = 141
        Me.TxDato_6.TeclaRepetida = False
        Me.TxDato_6.TxDatoFinalSemana = Nothing
        Me.TxDato_6.TxDatoInicioSemana = Nothing
        Me.TxDato_6.UltimoValorValidado = Nothing
        '
        'Lbnom_4
        '
        Me.Lbnom_4.BackColor = System.Drawing.Color.LightGray
        Me.Lbnom_4.CL_ControlAsociado = Nothing
        Me.Lbnom_4.CL_ValorFijo = False
        Me.Lbnom_4.ClForm = Nothing
        Me.Lbnom_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_4.Location = New System.Drawing.Point(212, 68)
        Me.Lbnom_4.Name = "Lbnom_4"
        Me.Lbnom_4.Size = New System.Drawing.Size(274, 18)
        Me.Lbnom_4.TabIndex = 140
        '
        'Lb_4
        '
        Me.Lb_4.AutoSize = True
        Me.Lb_4.CL_ControlAsociado = Nothing
        Me.Lb_4.CL_ValorFijo = False
        Me.Lb_4.ClForm = Nothing
        Me.Lb_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_4.ForeColor = System.Drawing.Color.Teal
        Me.Lb_4.Location = New System.Drawing.Point(12, 69)
        Me.Lb_4.Name = "Lb_4"
        Me.Lb_4.Size = New System.Drawing.Size(63, 16)
        Me.Lb_4.TabIndex = 138
        Me.Lb_4.Text = "Destino"
        '
        'TxDato_4
        '
        Me.TxDato_4.Autonumerico = False
        Me.TxDato_4.Buscando = False
        Me.TxDato_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_4.ClForm = Nothing
        Me.TxDato_4.ClParam = Nothing
        Me.TxDato_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_4.GridLin = Nothing
        Me.TxDato_4.HaCambiado = False
        Me.TxDato_4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_4.lbbusca = Nothing
        Me.TxDato_4.Location = New System.Drawing.Point(120, 66)
        Me.TxDato_4.MiError = False
        Me.TxDato_4.Name = "TxDato_4"
        Me.TxDato_4.Orden = 0
        Me.TxDato_4.SaltoAlfinal = False
        Me.TxDato_4.Siguiente = 0
        Me.TxDato_4.Size = New System.Drawing.Size(47, 22)
        Me.TxDato_4.TabIndex = 137
        Me.TxDato_4.TeclaRepetida = False
        Me.TxDato_4.TxDatoFinalSemana = Nothing
        Me.TxDato_4.TxDatoInicioSemana = Nothing
        Me.TxDato_4.UltimoValorValidado = Nothing
        '
        'TxDato_5
        '
        Me.TxDato_5.Autonumerico = False
        Me.TxDato_5.Buscando = False
        Me.TxDato_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_5.ClForm = Nothing
        Me.TxDato_5.ClParam = Nothing
        Me.TxDato_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_5.GridLin = Nothing
        Me.TxDato_5.HaCambiado = False
        Me.TxDato_5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_5.lbbusca = Nothing
        Me.TxDato_5.Location = New System.Drawing.Point(120, 95)
        Me.TxDato_5.MiError = False
        Me.TxDato_5.Name = "TxDato_5"
        Me.TxDato_5.Orden = 0
        Me.TxDato_5.SaltoAlfinal = False
        Me.TxDato_5.Siguiente = 0
        Me.TxDato_5.Size = New System.Drawing.Size(416, 22)
        Me.TxDato_5.TabIndex = 134
        Me.TxDato_5.TeclaRepetida = False
        Me.TxDato_5.TxDatoFinalSemana = Nothing
        Me.TxDato_5.TxDatoInicioSemana = Nothing
        Me.TxDato_5.UltimoValorValidado = Nothing
        '
        'Lb_5
        '
        Me.Lb_5.AutoSize = True
        Me.Lb_5.CL_ControlAsociado = Nothing
        Me.Lb_5.CL_ValorFijo = False
        Me.Lb_5.ClForm = Nothing
        Me.Lb_5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_5.ForeColor = System.Drawing.Color.Teal
        Me.Lb_5.Location = New System.Drawing.Point(12, 97)
        Me.Lb_5.Name = "Lb_5"
        Me.Lb_5.Size = New System.Drawing.Size(93, 16)
        Me.Lb_5.TabIndex = 133
        Me.Lb_5.Text = "Doc Anexos"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbNomCentro)
        Me.Panel3.Controls.Add(Me.LbCentro)
        Me.Panel3.Controls.Add(Me.Lb29)
        Me.Panel3.Location = New System.Drawing.Point(900, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 33)
        Me.Panel3.TabIndex = 125
        '
        'LbNomCentro
        '
        Me.LbNomCentro.BackColor = System.Drawing.Color.White
        Me.LbNomCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbNomCentro.CL_ControlAsociado = Nothing
        Me.LbNomCentro.CL_ValorFijo = True
        Me.LbNomCentro.ClForm = Nothing
        Me.LbNomCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbNomCentro.Location = New System.Drawing.Point(147, 5)
        Me.LbNomCentro.Name = "LbNomCentro"
        Me.LbNomCentro.Size = New System.Drawing.Size(117, 21)
        Me.LbNomCentro.TabIndex = 115
        Me.LbNomCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbCentro
        '
        Me.LbCentro.BackColor = System.Drawing.Color.White
        Me.LbCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCentro.CL_ControlAsociado = Nothing
        Me.LbCentro.CL_ValorFijo = True
        Me.LbCentro.ClForm = Nothing
        Me.LbCentro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCentro.ForeColor = System.Drawing.Color.Teal
        Me.LbCentro.Location = New System.Drawing.Point(114, 5)
        Me.LbCentro.Name = "LbCentro"
        Me.LbCentro.Size = New System.Drawing.Size(28, 21)
        Me.LbCentro.TabIndex = 114
        Me.LbCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb29
        '
        Me.Lb29.AutoSize = True
        Me.Lb29.CL_ControlAsociado = Nothing
        Me.Lb29.CL_ValorFijo = True
        Me.Lb29.ClForm = Nothing
        Me.Lb29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb29.ForeColor = System.Drawing.Color.Teal
        Me.Lb29.Location = New System.Drawing.Point(6, 7)
        Me.Lb29.Name = "Lb29"
        Me.Lb29.Size = New System.Drawing.Size(57, 16)
        Me.Lb29.TabIndex = 113
        Me.Lb29.Text = "Centro"
        '
        'LbCampa
        '
        Me.LbCampa.BackColor = System.Drawing.Color.White
        Me.LbCampa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbCampa.CL_ControlAsociado = Nothing
        Me.LbCampa.CL_ValorFijo = False
        Me.LbCampa.ClForm = Nothing
        Me.LbCampa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCampa.ForeColor = System.Drawing.Color.Teal
        Me.LbCampa.Location = New System.Drawing.Point(120, 11)
        Me.LbCampa.Name = "LbCampa"
        Me.LbCampa.Size = New System.Drawing.Size(34, 21)
        Me.LbCampa.TabIndex = 78
        '
        'Lb_2
        '
        Me.Lb_2.AutoSize = True
        Me.Lb_2.CL_ControlAsociado = Nothing
        Me.Lb_2.CL_ValorFijo = False
        Me.Lb_2.ClForm = Nothing
        Me.Lb_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_2.ForeColor = System.Drawing.Color.Teal
        Me.Lb_2.Location = New System.Drawing.Point(340, 13)
        Me.Lb_2.Name = "Lb_2"
        Me.Lb_2.Size = New System.Drawing.Size(99, 16)
        Me.Lb_2.TabIndex = 77
        Me.Lb_2.Text = "Fecha salida"
        '
        'TxDato_2
        '
        Me.TxDato_2.Autonumerico = False
        Me.TxDato_2.Buscando = False
        Me.TxDato_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_2.ClForm = Nothing
        Me.TxDato_2.ClParam = Nothing
        Me.TxDato_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_2.GridLin = Nothing
        Me.TxDato_2.HaCambiado = False
        Me.TxDato_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_2.lbbusca = Nothing
        Me.TxDato_2.Location = New System.Drawing.Point(492, 10)
        Me.TxDato_2.MiError = False
        Me.TxDato_2.Name = "TxDato_2"
        Me.TxDato_2.Orden = 0
        Me.TxDato_2.SaltoAlfinal = False
        Me.TxDato_2.Siguiente = 0
        Me.TxDato_2.Size = New System.Drawing.Size(93, 22)
        Me.TxDato_2.TabIndex = 76
        Me.TxDato_2.TeclaRepetida = False
        Me.TxDato_2.TxDatoFinalSemana = Nothing
        Me.TxDato_2.TxDatoInicioSemana = Nothing
        Me.TxDato_2.UltimoValorValidado = Nothing
        '
        'LbNom_Cliente
        '
        Me.LbNom_Cliente.BackColor = System.Drawing.Color.LightGray
        Me.LbNom_Cliente.CL_ControlAsociado = Nothing
        Me.LbNom_Cliente.CL_ValorFijo = False
        Me.LbNom_Cliente.ClForm = Nothing
        Me.LbNom_Cliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom_Cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbNom_Cliente.Location = New System.Drawing.Point(212, 41)
        Me.LbNom_Cliente.Name = "LbNom_Cliente"
        Me.LbNom_Cliente.Size = New System.Drawing.Size(385, 18)
        Me.LbNom_Cliente.TabIndex = 74
        '
        'Lb_3
        '
        Me.Lb_3.AutoSize = True
        Me.Lb_3.CL_ControlAsociado = Nothing
        Me.Lb_3.CL_ValorFijo = False
        Me.Lb_3.ClForm = Nothing
        Me.Lb_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_3.ForeColor = System.Drawing.Color.Teal
        Me.Lb_3.Location = New System.Drawing.Point(12, 42)
        Me.Lb_3.Name = "Lb_3"
        Me.Lb_3.Size = New System.Drawing.Size(59, 16)
        Me.Lb_3.TabIndex = 72
        Me.Lb_3.Text = "Cliente"
        '
        'BtBuscaAlbaran
        '
        Me.BtBuscaAlbaran.CL_Ancho = 0
        Me.BtBuscaAlbaran.CL_BuscaAlb = False
        Me.BtBuscaAlbaran.CL_campocodigo = Nothing
        Me.BtBuscaAlbaran.CL_camponombre = Nothing
        Me.BtBuscaAlbaran.CL_CampoOrden = "Nombre"
        Me.BtBuscaAlbaran.CL_ch1000 = False
        Me.BtBuscaAlbaran.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaAlbaran.CL_ControlAsociado = Me.TxDato_1
        Me.BtBuscaAlbaran.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaAlbaran.CL_dfecha = Nothing
        Me.BtBuscaAlbaran.CL_Entidad = Nothing
        Me.BtBuscaAlbaran.CL_EsId = True
        Me.BtBuscaAlbaran.CL_Filtro = Nothing
        Me.BtBuscaAlbaran.cl_formu = Nothing
        Me.BtBuscaAlbaran.CL_hfecha = Nothing
        Me.BtBuscaAlbaran.cl_ListaW = Nothing
        Me.BtBuscaAlbaran.CL_xCentro = False
        Me.BtBuscaAlbaran.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaAlbaran.Location = New System.Drawing.Point(237, 10)
        Me.BtBuscaAlbaran.Name = "BtBuscaAlbaran"
        Me.BtBuscaAlbaran.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaAlbaran.TabIndex = 70
        Me.BtBuscaAlbaran.UseVisualStyleBackColor = True
        '
        'TxDato_1
        '
        Me.TxDato_1.Autonumerico = False
        Me.TxDato_1.Buscando = False
        Me.TxDato_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_1.ClForm = Nothing
        Me.TxDato_1.ClParam = Nothing
        Me.TxDato_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_1.GridLin = Nothing
        Me.TxDato_1.HaCambiado = False
        Me.TxDato_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_1.lbbusca = Nothing
        Me.TxDato_1.Location = New System.Drawing.Point(160, 11)
        Me.TxDato_1.MiError = False
        Me.TxDato_1.Name = "TxDato_1"
        Me.TxDato_1.Orden = 0
        Me.TxDato_1.SaltoAlfinal = False
        Me.TxDato_1.Siguiente = 0
        Me.TxDato_1.Size = New System.Drawing.Size(75, 22)
        Me.TxDato_1.TabIndex = 65
        Me.TxDato_1.TeclaRepetida = False
        Me.TxDato_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxDato_1.TxDatoFinalSemana = Nothing
        Me.TxDato_1.TxDatoInicioSemana = Nothing
        Me.TxDato_1.UltimoValorValidado = Nothing
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(12, 13)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(64, 16)
        Me.Lb1.TabIndex = 66
        Me.Lb1.Text = "Albarán"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lb_nom52)
        Me.Panel2.Controls.Add(Me.TxDato_52)
        Me.Panel2.Controls.Add(Me.Lb_52)
        Me.Panel2.Controls.Add(Me.BtBusca_52)
        Me.Panel2.Controls.Add(Me.Lb_57)
        Me.Panel2.Controls.Add(Me.TxDato_57)
        Me.Panel2.Controls.Add(Me.Lbnom_51)
        Me.Panel2.Controls.Add(Me.TxDato_51)
        Me.Panel2.Controls.Add(Me.Lb_51)
        Me.Panel2.Controls.Add(Me.BtBusca_51)
        Me.Panel2.Controls.Add(Me.TxDato_53)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lb_53)
        Me.Panel2.Controls.Add(Me.Lb_55)
        Me.Panel2.Controls.Add(Me.TxDato_55)
        Me.Panel2.Controls.Add(Me.Lb_54)
        Me.Panel2.Controls.Add(Me.TxDato_54)
        Me.Panel2.Controls.Add(Me.Lbnom_50)
        Me.Panel2.Controls.Add(Me.TxDato_50)
        Me.Panel2.Controls.Add(Me.Lb_50)
        Me.Panel2.Controls.Add(Me.BtBusca_50)
        Me.Panel2.Controls.Add(Me.Lb_56)
        Me.Panel2.Controls.Add(Me.TxDato_56)
        Me.Panel2.Controls.Add(Me.ClGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1202, 277)
        Me.Panel2.TabIndex = 73
        '
        'Lb_nom52
        '
        Me.Lb_nom52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_nom52.CL_ControlAsociado = Nothing
        Me.Lb_nom52.CL_ValorFijo = False
        Me.Lb_nom52.ClForm = Nothing
        Me.Lb_nom52.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nom52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_nom52.Location = New System.Drawing.Point(221, 42)
        Me.Lb_nom52.Name = "Lb_nom52"
        Me.Lb_nom52.Size = New System.Drawing.Size(266, 23)
        Me.Lb_nom52.TabIndex = 150
        '
        'TxDato_52
        '
        Me.TxDato_52.Autonumerico = False
        Me.TxDato_52.Buscando = False
        Me.TxDato_52.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_52.ClForm = Nothing
        Me.TxDato_52.ClParam = Nothing
        Me.TxDato_52.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_52.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_52.GridLin = Nothing
        Me.TxDato_52.HaCambiado = False
        Me.TxDato_52.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_52.lbbusca = Nothing
        Me.TxDato_52.Location = New System.Drawing.Point(119, 42)
        Me.TxDato_52.MiError = False
        Me.TxDato_52.Name = "TxDato_52"
        Me.TxDato_52.Orden = 0
        Me.TxDato_52.SaltoAlfinal = False
        Me.TxDato_52.Siguiente = 0
        Me.TxDato_52.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_52.TabIndex = 147
        Me.TxDato_52.TeclaRepetida = False
        Me.TxDato_52.TxDatoFinalSemana = Nothing
        Me.TxDato_52.TxDatoInicioSemana = Nothing
        Me.TxDato_52.UltimoValorValidado = Nothing
        '
        'Lb_52
        '
        Me.Lb_52.AutoSize = True
        Me.Lb_52.CL_ControlAsociado = Nothing
        Me.Lb_52.CL_ValorFijo = False
        Me.Lb_52.ClForm = Nothing
        Me.Lb_52.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_52.ForeColor = System.Drawing.Color.Teal
        Me.Lb_52.Location = New System.Drawing.Point(12, 45)
        Me.Lb_52.Name = "Lb_52"
        Me.Lb_52.Size = New System.Drawing.Size(45, 16)
        Me.Lb_52.TabIndex = 148
        Me.Lb_52.Text = "Palet"
        '
        'BtBusca_52
        '
        Me.BtBusca_52.CL_Ancho = 0
        Me.BtBusca_52.CL_BuscaAlb = False
        Me.BtBusca_52.CL_campocodigo = Nothing
        Me.BtBusca_52.CL_camponombre = Nothing
        Me.BtBusca_52.CL_CampoOrden = "Nombre"
        Me.BtBusca_52.CL_ch1000 = False
        Me.BtBusca_52.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_52.CL_ControlAsociado = Me.TxDato_52
        Me.BtBusca_52.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_52.CL_dfecha = Nothing
        Me.BtBusca_52.CL_Entidad = Nothing
        Me.BtBusca_52.CL_EsId = True
        Me.BtBusca_52.CL_Filtro = Nothing
        Me.BtBusca_52.cl_formu = Nothing
        Me.BtBusca_52.CL_hfecha = Nothing
        Me.BtBusca_52.cl_ListaW = Nothing
        Me.BtBusca_52.CL_xCentro = False
        Me.BtBusca_52.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_52.Location = New System.Drawing.Point(179, 42)
        Me.BtBusca_52.Name = "BtBusca_52"
        Me.BtBusca_52.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_52.TabIndex = 149
        Me.BtBusca_52.UseVisualStyleBackColor = True
        '
        'Lb_57
        '
        Me.Lb_57.AutoSize = True
        Me.Lb_57.CL_ControlAsociado = Nothing
        Me.Lb_57.CL_ValorFijo = False
        Me.Lb_57.ClForm = Nothing
        Me.Lb_57.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_57.ForeColor = System.Drawing.Color.Teal
        Me.Lb_57.Location = New System.Drawing.Point(671, 78)
        Me.Lb_57.Name = "Lb_57"
        Me.Lb_57.Size = New System.Drawing.Size(88, 16)
        Me.Lb_57.TabIndex = 145
        Me.Lb_57.Text = "Kilos Netos"
        '
        'TxDato_57
        '
        Me.TxDato_57.Autonumerico = False
        Me.TxDato_57.Buscando = False
        Me.TxDato_57.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_57.ClForm = Nothing
        Me.TxDato_57.ClParam = Nothing
        Me.TxDato_57.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_57.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_57.GridLin = Nothing
        Me.TxDato_57.HaCambiado = False
        Me.TxDato_57.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_57.lbbusca = Nothing
        Me.TxDato_57.Location = New System.Drawing.Point(764, 75)
        Me.TxDato_57.MiError = False
        Me.TxDato_57.Name = "TxDato_57"
        Me.TxDato_57.Orden = 0
        Me.TxDato_57.SaltoAlfinal = False
        Me.TxDato_57.Siguiente = 0
        Me.TxDato_57.Size = New System.Drawing.Size(67, 22)
        Me.TxDato_57.TabIndex = 144
        Me.TxDato_57.TeclaRepetida = False
        Me.TxDato_57.TxDatoFinalSemana = Nothing
        Me.TxDato_57.TxDatoInicioSemana = Nothing
        Me.TxDato_57.UltimoValorValidado = Nothing
        '
        'Lbnom_51
        '
        Me.Lbnom_51.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_51.CL_ControlAsociado = Nothing
        Me.Lbnom_51.CL_ValorFijo = False
        Me.Lbnom_51.ClForm = Nothing
        Me.Lbnom_51.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_51.Location = New System.Drawing.Point(742, 11)
        Me.Lbnom_51.Name = "Lbnom_51"
        Me.Lbnom_51.Size = New System.Drawing.Size(178, 23)
        Me.Lbnom_51.TabIndex = 141
        '
        'TxDato_51
        '
        Me.TxDato_51.Autonumerico = False
        Me.TxDato_51.Buscando = False
        Me.TxDato_51.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_51.ClForm = Nothing
        Me.TxDato_51.ClParam = Nothing
        Me.TxDato_51.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_51.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_51.GridLin = Nothing
        Me.TxDato_51.HaCambiado = False
        Me.TxDato_51.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_51.lbbusca = Nothing
        Me.TxDato_51.Location = New System.Drawing.Point(640, 11)
        Me.TxDato_51.MiError = False
        Me.TxDato_51.Name = "TxDato_51"
        Me.TxDato_51.Orden = 0
        Me.TxDato_51.SaltoAlfinal = False
        Me.TxDato_51.Siguiente = 0
        Me.TxDato_51.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_51.TabIndex = 138
        Me.TxDato_51.TeclaRepetida = False
        Me.TxDato_51.TxDatoFinalSemana = Nothing
        Me.TxDato_51.TxDatoInicioSemana = Nothing
        Me.TxDato_51.UltimoValorValidado = Nothing
        '
        'Lb_51
        '
        Me.Lb_51.AutoSize = True
        Me.Lb_51.CL_ControlAsociado = Nothing
        Me.Lb_51.CL_ValorFijo = False
        Me.Lb_51.ClForm = Nothing
        Me.Lb_51.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_51.ForeColor = System.Drawing.Color.Teal
        Me.Lb_51.Location = New System.Drawing.Point(564, 14)
        Me.Lb_51.Name = "Lb_51"
        Me.Lb_51.Size = New System.Drawing.Size(52, 16)
        Me.Lb_51.TabIndex = 139
        Me.Lb_51.Text = "Marca"
        '
        'BtBusca_51
        '
        Me.BtBusca_51.CL_Ancho = 0
        Me.BtBusca_51.CL_BuscaAlb = False
        Me.BtBusca_51.CL_campocodigo = Nothing
        Me.BtBusca_51.CL_camponombre = Nothing
        Me.BtBusca_51.CL_CampoOrden = "Nombre"
        Me.BtBusca_51.CL_ch1000 = False
        Me.BtBusca_51.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_51.CL_ControlAsociado = Me.TxDato_51
        Me.BtBusca_51.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_51.CL_dfecha = Nothing
        Me.BtBusca_51.CL_Entidad = Nothing
        Me.BtBusca_51.CL_EsId = True
        Me.BtBusca_51.CL_Filtro = Nothing
        Me.BtBusca_51.cl_formu = Nothing
        Me.BtBusca_51.CL_hfecha = Nothing
        Me.BtBusca_51.cl_ListaW = Nothing
        Me.BtBusca_51.CL_xCentro = False
        Me.BtBusca_51.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_51.Location = New System.Drawing.Point(700, 11)
        Me.BtBusca_51.Name = "BtBusca_51"
        Me.BtBusca_51.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_51.TabIndex = 140
        Me.BtBusca_51.UseVisualStyleBackColor = True
        '
        'TxDato_53
        '
        Me.TxDato_53.Autonumerico = False
        Me.TxDato_53.Buscando = False
        Me.TxDato_53.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_53.ClForm = Nothing
        Me.TxDato_53.ClParam = Nothing
        Me.TxDato_53.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_53.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_53.GridLin = Nothing
        Me.TxDato_53.HaCambiado = False
        Me.TxDato_53.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_53.lbbusca = Nothing
        Me.TxDato_53.Location = New System.Drawing.Point(640, 42)
        Me.TxDato_53.MiError = False
        Me.TxDato_53.Name = "TxDato_53"
        Me.TxDato_53.Orden = 0
        Me.TxDato_53.SaltoAlfinal = False
        Me.TxDato_53.Siguiente = 0
        Me.TxDato_53.Size = New System.Drawing.Size(280, 22)
        Me.TxDato_53.TabIndex = 137
        Me.TxDato_53.TeclaRepetida = False
        Me.TxDato_53.TxDatoFinalSemana = Nothing
        Me.TxDato_53.TxDatoInicioSemana = Nothing
        Me.TxDato_53.UltimoValorValidado = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        Me.PictureBox2.Location = New System.Drawing.Point(893, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(871, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lb_53
        '
        Me.Lb_53.AutoSize = True
        Me.Lb_53.CL_ControlAsociado = Nothing
        Me.Lb_53.CL_ValorFijo = True
        Me.Lb_53.ClForm = Nothing
        Me.Lb_53.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_53.ForeColor = System.Drawing.Color.Teal
        Me.Lb_53.Location = New System.Drawing.Point(565, 45)
        Me.Lb_53.Name = "Lb_53"
        Me.Lb_53.Size = New System.Drawing.Size(61, 16)
        Me.Lb_53.TabIndex = 117
        Me.Lb_53.Text = "Envase"
        '
        'Lb_55
        '
        Me.Lb_55.AutoSize = True
        Me.Lb_55.CL_ControlAsociado = Nothing
        Me.Lb_55.CL_ValorFijo = False
        Me.Lb_55.ClForm = Nothing
        Me.Lb_55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_55.ForeColor = System.Drawing.Color.Teal
        Me.Lb_55.Location = New System.Drawing.Point(219, 78)
        Me.Lb_55.Name = "Lb_55"
        Me.Lb_55.Size = New System.Drawing.Size(54, 16)
        Me.Lb_55.TabIndex = 106
        Me.Lb_55.Text = "Bultos"
        '
        'TxDato_55
        '
        Me.TxDato_55.Autonumerico = False
        Me.TxDato_55.Buscando = False
        Me.TxDato_55.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_55.ClForm = Nothing
        Me.TxDato_55.ClParam = Nothing
        Me.TxDato_55.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_55.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_55.GridLin = Nothing
        Me.TxDato_55.HaCambiado = False
        Me.TxDato_55.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_55.lbbusca = Nothing
        Me.TxDato_55.Location = New System.Drawing.Point(285, 75)
        Me.TxDato_55.MiError = False
        Me.TxDato_55.Name = "TxDato_55"
        Me.TxDato_55.Orden = 0
        Me.TxDato_55.SaltoAlfinal = False
        Me.TxDato_55.Siguiente = 0
        Me.TxDato_55.Size = New System.Drawing.Size(65, 22)
        Me.TxDato_55.TabIndex = 105
        Me.TxDato_55.TeclaRepetida = False
        Me.TxDato_55.TxDatoFinalSemana = Nothing
        Me.TxDato_55.TxDatoInicioSemana = Nothing
        Me.TxDato_55.UltimoValorValidado = Nothing
        '
        'Lb_54
        '
        Me.Lb_54.AutoSize = True
        Me.Lb_54.CL_ControlAsociado = Nothing
        Me.Lb_54.CL_ValorFijo = False
        Me.Lb_54.ClForm = Nothing
        Me.Lb_54.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_54.ForeColor = System.Drawing.Color.Teal
        Me.Lb_54.Location = New System.Drawing.Point(12, 78)
        Me.Lb_54.Name = "Lb_54"
        Me.Lb_54.Size = New System.Drawing.Size(53, 16)
        Me.Lb_54.TabIndex = 102
        Me.Lb_54.Text = "Palets"
        '
        'TxDato_54
        '
        Me.TxDato_54.Autonumerico = False
        Me.TxDato_54.Buscando = False
        Me.TxDato_54.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_54.ClForm = Nothing
        Me.TxDato_54.ClParam = Nothing
        Me.TxDato_54.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_54.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_54.GridLin = Nothing
        Me.TxDato_54.HaCambiado = False
        Me.TxDato_54.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_54.lbbusca = Nothing
        Me.TxDato_54.Location = New System.Drawing.Point(119, 75)
        Me.TxDato_54.MiError = False
        Me.TxDato_54.Name = "TxDato_54"
        Me.TxDato_54.Orden = 0
        Me.TxDato_54.SaltoAlfinal = False
        Me.TxDato_54.Siguiente = 0
        Me.TxDato_54.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_54.TabIndex = 101
        Me.TxDato_54.TeclaRepetida = False
        Me.TxDato_54.TxDatoFinalSemana = Nothing
        Me.TxDato_54.TxDatoInicioSemana = Nothing
        Me.TxDato_54.UltimoValorValidado = Nothing
        '
        'Lbnom_50
        '
        Me.Lbnom_50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbnom_50.CL_ControlAsociado = Nothing
        Me.Lbnom_50.CL_ValorFijo = False
        Me.Lbnom_50.ClForm = Nothing
        Me.Lbnom_50.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbnom_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbnom_50.Location = New System.Drawing.Point(219, 11)
        Me.Lbnom_50.Name = "Lbnom_50"
        Me.Lbnom_50.Size = New System.Drawing.Size(296, 23)
        Me.Lbnom_50.TabIndex = 74
        '
        'TxDato_50
        '
        Me.TxDato_50.Autonumerico = False
        Me.TxDato_50.Buscando = False
        Me.TxDato_50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_50.ClForm = Nothing
        Me.TxDato_50.ClParam = Nothing
        Me.TxDato_50.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_50.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_50.GridLin = Nothing
        Me.TxDato_50.HaCambiado = False
        Me.TxDato_50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_50.lbbusca = Nothing
        Me.TxDato_50.Location = New System.Drawing.Point(119, 11)
        Me.TxDato_50.MiError = False
        Me.TxDato_50.Name = "TxDato_50"
        Me.TxDato_50.Orden = 0
        Me.TxDato_50.SaltoAlfinal = False
        Me.TxDato_50.Siguiente = 0
        Me.TxDato_50.Size = New System.Drawing.Size(53, 22)
        Me.TxDato_50.TabIndex = 71
        Me.TxDato_50.TeclaRepetida = False
        Me.TxDato_50.TxDatoFinalSemana = Nothing
        Me.TxDato_50.TxDatoInicioSemana = Nothing
        Me.TxDato_50.UltimoValorValidado = Nothing
        '
        'Lb_50
        '
        Me.Lb_50.AutoSize = True
        Me.Lb_50.CL_ControlAsociado = Nothing
        Me.Lb_50.CL_ValorFijo = False
        Me.Lb_50.ClForm = Nothing
        Me.Lb_50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_50.ForeColor = System.Drawing.Color.Teal
        Me.Lb_50.Location = New System.Drawing.Point(12, 14)
        Me.Lb_50.Name = "Lb_50"
        Me.Lb_50.Size = New System.Drawing.Size(61, 16)
        Me.Lb_50.TabIndex = 72
        Me.Lb_50.Text = "Familia"
        '
        'BtBusca_50
        '
        Me.BtBusca_50.CL_Ancho = 0
        Me.BtBusca_50.CL_BuscaAlb = False
        Me.BtBusca_50.CL_campocodigo = Nothing
        Me.BtBusca_50.CL_camponombre = Nothing
        Me.BtBusca_50.CL_CampoOrden = "Nombre"
        Me.BtBusca_50.CL_ch1000 = False
        Me.BtBusca_50.CL_ConsultaSql = "Select * from familias"
        Me.BtBusca_50.CL_ControlAsociado = Me.TxDato_50
        Me.BtBusca_50.CL_DevuelveCampo = "Idfamilia"
        Me.BtBusca_50.CL_dfecha = Nothing
        Me.BtBusca_50.CL_Entidad = Nothing
        Me.BtBusca_50.CL_EsId = True
        Me.BtBusca_50.CL_Filtro = Nothing
        Me.BtBusca_50.cl_formu = Nothing
        Me.BtBusca_50.CL_hfecha = Nothing
        Me.BtBusca_50.cl_ListaW = Nothing
        Me.BtBusca_50.CL_xCentro = False
        Me.BtBusca_50.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBusca_50.Location = New System.Drawing.Point(178, 11)
        Me.BtBusca_50.Name = "BtBusca_50"
        Me.BtBusca_50.Size = New System.Drawing.Size(33, 23)
        Me.BtBusca_50.TabIndex = 73
        Me.BtBusca_50.UseVisualStyleBackColor = True
        '
        'Lb_56
        '
        Me.Lb_56.AutoSize = True
        Me.Lb_56.CL_ControlAsociado = Nothing
        Me.Lb_56.CL_ValorFijo = False
        Me.Lb_56.ClForm = Nothing
        Me.Lb_56.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_56.ForeColor = System.Drawing.Color.Teal
        Me.Lb_56.Location = New System.Drawing.Point(410, 78)
        Me.Lb_56.Name = "Lb_56"
        Me.Lb_56.Size = New System.Drawing.Size(94, 16)
        Me.Lb_56.TabIndex = 80
        Me.Lb_56.Text = "Kilos Brutos"
        '
        'TxDato_56
        '
        Me.TxDato_56.Autonumerico = False
        Me.TxDato_56.Buscando = False
        Me.TxDato_56.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato_56.ClForm = Nothing
        Me.TxDato_56.ClParam = Nothing
        Me.TxDato_56.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato_56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato_56.GridLin = Nothing
        Me.TxDato_56.HaCambiado = False
        Me.TxDato_56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato_56.lbbusca = Nothing
        Me.TxDato_56.Location = New System.Drawing.Point(525, 75)
        Me.TxDato_56.MiError = False
        Me.TxDato_56.Name = "TxDato_56"
        Me.TxDato_56.Orden = 0
        Me.TxDato_56.SaltoAlfinal = False
        Me.TxDato_56.Siguiente = 0
        Me.TxDato_56.Size = New System.Drawing.Size(89, 22)
        Me.TxDato_56.TabIndex = 79
        Me.TxDato_56.TeclaRepetida = False
        Me.TxDato_56.TxDatoFinalSemana = Nothing
        Me.TxDato_56.TxDatoInicioSemana = Nothing
        Me.TxDato_56.UltimoValorValidado = Nothing
        '
        'ClGrid1
        '
        Me.ClGrid1.AñadirLinea = True
        Me.ClGrid1.BackColor = System.Drawing.Color.Transparent
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.GridEnterAutomatico = False
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.LineaBloqueada = False
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(0, 104)
        Me.ClGrid1.MismaLinea = False
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.OcultarCeros = False
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(1198, 169)
        Me.ClGrid1.TabIndex = 77
        Me.ClGrid1.UltimoControl = 0
        '
        'FrmCmr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 540)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmCmr"
        Me.Text = "Datos CMR"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LbNom_Cliente As NetAgro.Lb
    Friend WithEvents Lb_3 As NetAgro.Lb
    Friend WithEvents BtBuscaAlbaran As NetAgro.BtBusca
    Friend WithEvents TxDato_1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lbnom_50 As NetAgro.Lb
    Friend WithEvents BtBusca_50 As NetAgro.BtBusca
    Friend WithEvents TxDato_50 As NetAgro.TxDato
    Friend WithEvents Lb_50 As NetAgro.Lb
    Friend WithEvents LbCampa As NetAgro.Lb
    Friend WithEvents Lb_2 As NetAgro.Lb
    Friend WithEvents TxDato_2 As NetAgro.TxDato
    Friend WithEvents TxDato_56 As NetAgro.TxDato
    Friend WithEvents Lb_56 As NetAgro.Lb
    Friend WithEvents TxDato_55 As NetAgro.TxDato
    Friend WithEvents Lb_55 As NetAgro.Lb
    Friend WithEvents TxDato_54 As NetAgro.TxDato
    Friend WithEvents Lb_54 As NetAgro.Lb
    Friend WithEvents Lb_53 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbNomCentro As NetAgro.Lb
    Friend WithEvents LbCentro As NetAgro.Lb
    Friend WithEvents Lb29 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxDato_5 As NetAgro.TxDato
    Friend WithEvents Lb_5 As NetAgro.Lb
    Friend WithEvents TxDato_53 As NetAgro.TxDato
    Friend WithEvents TxDato_51 As NetAgro.TxDato
    Friend WithEvents Lb_51 As NetAgro.Lb
    Friend WithEvents BtBusca_51 As NetAgro.BtBusca
    Friend WithEvents Lbnom_51 As NetAgro.Lb
    Friend WithEvents Lb_57 As NetAgro.Lb
    Friend WithEvents TxDato_57 As NetAgro.TxDato
    Friend WithEvents Lbnom_4 As NetAgro.Lb
    Friend WithEvents TxDato_4 As NetAgro.TxDato
    Friend WithEvents Lb_4 As NetAgro.Lb
    Friend WithEvents TxDato_7 As NetAgro.TxDato
    Friend WithEvents Lb_7 As NetAgro.Lb
    Friend WithEvents TxDato_12 As NetAgro.TxDato
    Friend WithEvents TxDato_11 As NetAgro.TxDato
    Friend WithEvents TxDato_10 As NetAgro.TxDato
    Friend WithEvents TxDato_9 As NetAgro.TxDato
    Friend WithEvents Lb_9 As NetAgro.Lb
    Friend WithEvents TxDato_6 As NetAgro.TxDato
    Friend WithEvents TxDato_8 As NetAgro.TxDato
    Friend WithEvents Lb_8 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb_nom52 As NetAgro.Lb
    Friend WithEvents TxDato_52 As NetAgro.TxDato
    Friend WithEvents Lb_52 As NetAgro.Lb
    Friend WithEvents BtBusca_52 As NetAgro.BtBusca
    Friend WithEvents TxDato_13 As NetAgro.TxDato
    Friend WithEvents Lb13 As NetAgro.Lb
    Friend WithEvents TxNumRegTemp As NetAgro.TxDato
    Friend WithEvents LbNumRegTemp As NetAgro.Lb
    Friend WithEvents TxMovilChofer As NetAgro.TxDato
    Friend WithEvents LbMovilChofer As NetAgro.Lb
    Friend WithEvents LbIdCliente As NetAgro.Lb
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ChkImprimirEtiqueta As NetAgro.Chk

End Class
