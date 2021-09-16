<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContactos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContactos))
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.Lb9 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.TxDato10 = New NetAgro.TxDato(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Botros = New NetAgro.ClButton()
        Me.BLogistica = New NetAgro.ClButton()
        Me.Bcomercial = New NetAgro.ClButton()
        Me.Badmon = New NetAgro.ClButton()
        Me.Lb_0 = New NetAgro.Lb(Me.components)
        Me.TxDato0 = New NetAgro.TxDato(Me.components)
        Me.Lb0 = New NetAgro.Lb(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.clgrid1 = New NetAgro.ClGrid()
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_PanelCargando
        '
        Me._PanelCargando.Location = New System.Drawing.Point(270, 214)
        Me._PanelCargando.TabIndex = 3
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.ClForm = Nothing
        Me.Lb3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.ForeColor = System.Drawing.Color.Teal
        Me.Lb3.Location = New System.Drawing.Point(16, 47)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(133, 16)
        Me.Lb3.TabIndex = 42
        Me.Lb3.Text = "Persona contacto"
        '
        'TxDato3
        '
        Me.TxDato3.Autonumerico = False
        Me.TxDato3.Buscando = False
        Me.TxDato3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.HaCambiado = False
        Me.TxDato3.lbbusca = Nothing
        Me.TxDato3.Location = New System.Drawing.Point(155, 44)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(570, 22)
        Me.TxDato3.TabIndex = 41
        Me.TxDato3.TeclaRepetida = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.ClForm = Nothing
        Me.Lb4.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.Teal
        Me.Lb4.Location = New System.Drawing.Point(17, 105)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(69, 16)
        Me.Lb4.TabIndex = 43
        Me.Lb4.Text = "Telf. Fijo"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.ClForm = Nothing
        Me.Lb5.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.ForeColor = System.Drawing.Color.Teal
        Me.Lb5.Location = New System.Drawing.Point(324, 105)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(81, 16)
        Me.Lb5.TabIndex = 44
        Me.Lb5.Text = "Telf. Movil"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.ClForm = Nothing
        Me.Lb7.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.ForeColor = System.Drawing.Color.Teal
        Me.Lb7.Location = New System.Drawing.Point(17, 136)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(48, 16)
        Me.Lb7.TabIndex = 45
        Me.Lb7.Text = "Email"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.ClForm = Nothing
        Me.Lb6.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.Teal
        Me.Lb6.Location = New System.Drawing.Point(593, 105)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(33, 16)
        Me.Lb6.TabIndex = 46
        Me.Lb6.Text = "Fax"
        '
        'Lb8
        '
        Me.Lb8.AutoSize = True
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.ClForm = Nothing
        Me.Lb8.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.ForeColor = System.Drawing.Color.Teal
        Me.Lb8.Location = New System.Drawing.Point(593, 136)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(93, 16)
        Me.Lb8.TabIndex = 47
        Me.Lb8.Text = "Clave email"
        '
        'Lb9
        '
        Me.Lb9.AutoSize = True
        Me.Lb9.CL_ControlAsociado = Nothing
        Me.Lb9.CL_ValorFijo = False
        Me.Lb9.ClForm = Nothing
        Me.Lb9.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb9.ForeColor = System.Drawing.Color.Teal
        Me.Lb9.Location = New System.Drawing.Point(16, 171)
        Me.Lb9.Name = "Lb9"
        Me.Lb9.Size = New System.Drawing.Size(115, 16)
        Me.Lb9.TabIndex = 48
        Me.Lb9.Text = "Observaciones"
        '
        'TxDato7
        '
        Me.TxDato7.Autonumerico = False
        Me.TxDato7.Buscando = False
        Me.TxDato7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato7.ClForm = Nothing
        Me.TxDato7.ClParam = Nothing
        Me.TxDato7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato7.GridLin = Nothing
        Me.TxDato7.HaCambiado = False
        Me.TxDato7.lbbusca = Nothing
        Me.TxDato7.Location = New System.Drawing.Point(156, 134)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(421, 22)
        Me.TxDato7.TabIndex = 49
        Me.TxDato7.TeclaRepetida = False
        '
        'TxDato9
        '
        Me.TxDato9.Autonumerico = False
        Me.TxDato9.Buscando = False
        Me.TxDato9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato9.ClForm = Nothing
        Me.TxDato9.ClParam = Nothing
        Me.TxDato9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato9.GridLin = Nothing
        Me.TxDato9.HaCambiado = False
        Me.TxDato9.lbbusca = Nothing
        Me.TxDato9.Location = New System.Drawing.Point(155, 165)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(614, 22)
        Me.TxDato9.TabIndex = 50
        Me.TxDato9.TeclaRepetida = False
        '
        'TxDato10
        '
        Me.TxDato10.Autonumerico = False
        Me.TxDato10.Buscando = False
        Me.TxDato10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato10.ClForm = Nothing
        Me.TxDato10.ClParam = Nothing
        Me.TxDato10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato10.GridLin = Nothing
        Me.TxDato10.HaCambiado = False
        Me.TxDato10.lbbusca = Nothing
        Me.TxDato10.Location = New System.Drawing.Point(155, 193)
        Me.TxDato10.MiError = False
        Me.TxDato10.Name = "TxDato10"
        Me.TxDato10.Orden = 0
        Me.TxDato10.SaltoAlfinal = False
        Me.TxDato10.Siguiente = 0
        Me.TxDato10.Size = New System.Drawing.Size(614, 22)
        Me.TxDato10.TabIndex = 51
        Me.TxDato10.TeclaRepetida = False
        '
        'TxDato8
        '
        Me.TxDato8.Autonumerico = False
        Me.TxDato8.Buscando = False
        Me.TxDato8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato8.ClForm = Nothing
        Me.TxDato8.ClParam = Nothing
        Me.TxDato8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato8.GridLin = Nothing
        Me.TxDato8.HaCambiado = False
        Me.TxDato8.lbbusca = Nothing
        Me.TxDato8.Location = New System.Drawing.Point(726, 134)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(41, 22)
        Me.TxDato8.TabIndex = 52
        Me.TxDato8.TeclaRepetida = False
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
        Me.TxDato4.Location = New System.Drawing.Point(156, 102)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(134, 22)
        Me.TxDato4.TabIndex = 53
        Me.TxDato4.TeclaRepetida = False
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
        Me.TxDato5.Location = New System.Drawing.Point(411, 103)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(134, 22)
        Me.TxDato5.TabIndex = 54
        Me.TxDato5.TeclaRepetida = False
        '
        'TxDato6
        '
        Me.TxDato6.Autonumerico = False
        Me.TxDato6.Buscando = False
        Me.TxDato6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato6.ClForm = Nothing
        Me.TxDato6.ClParam = Nothing
        Me.TxDato6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato6.GridLin = Nothing
        Me.TxDato6.HaCambiado = False
        Me.TxDato6.lbbusca = Nothing
        Me.TxDato6.Location = New System.Drawing.Point(636, 103)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(134, 22)
        Me.TxDato6.TabIndex = 55
        Me.TxDato6.TeclaRepetida = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Botros)
        Me.Panel2.Controls.Add(Me.BLogistica)
        Me.Panel2.Controls.Add(Me.Bcomercial)
        Me.Panel2.Controls.Add(Me.Badmon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 38)
        Me.Panel2.TabIndex = 74
        '
        'Botros
        '
        Me.Botros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botros.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcard_32x32_32
        Me.Botros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Botros.Location = New System.Drawing.Point(642, 1)
        Me.Botros.Name = "Botros"
        Me.Botros.Orden = 0
        Me.Botros.PedirClave = True
        Me.Botros.Size = New System.Drawing.Size(146, 32)
        Me.Botros.TabIndex = 158
        Me.Botros.Text = "Otros"
        Me.Botros.UseVisualStyleBackColor = True
        '
        'BLogistica
        '
        Me.BLogistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogistica.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcard_32x32_32
        Me.BLogistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLogistica.Location = New System.Drawing.Point(450, 1)
        Me.BLogistica.Name = "BLogistica"
        Me.BLogistica.Orden = 0
        Me.BLogistica.PedirClave = True
        Me.BLogistica.Size = New System.Drawing.Size(190, 32)
        Me.BLogistica.TabIndex = 157
        Me.BLogistica.Text = "Logistica"
        Me.BLogistica.UseVisualStyleBackColor = True
        '
        'Bcomercial
        '
        Me.Bcomercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcomercial.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcard_32x32_32
        Me.Bcomercial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bcomercial.Location = New System.Drawing.Point(244, 1)
        Me.Bcomercial.Name = "Bcomercial"
        Me.Bcomercial.Orden = 0
        Me.Bcomercial.PedirClave = True
        Me.Bcomercial.Size = New System.Drawing.Size(200, 32)
        Me.Bcomercial.TabIndex = 156
        Me.Bcomercial.Text = "Comercial"
        Me.Bcomercial.UseVisualStyleBackColor = True
        '
        'Badmon
        '
        Me.Badmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badmon.Image = Global.NetAgro.My.Resources.Resources.Mimetype_vcard_32x32_32
        Me.Badmon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badmon.Location = New System.Drawing.Point(3, 1)
        Me.Badmon.Name = "Badmon"
        Me.Badmon.Orden = 0
        Me.Badmon.PedirClave = True
        Me.Badmon.Size = New System.Drawing.Size(235, 32)
        Me.Badmon.TabIndex = 155
        Me.Badmon.Text = "Administración"
        Me.Badmon.UseVisualStyleBackColor = True
        '
        'Lb_0
        '
        Me.Lb_0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_0.CL_ControlAsociado = Nothing
        Me.Lb_0.CL_ValorFijo = False
        Me.Lb_0.ClForm = Nothing
        Me.Lb_0.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_0.Location = New System.Drawing.Point(176, 6)
        Me.Lb_0.Name = "Lb_0"
        Me.Lb_0.Size = New System.Drawing.Size(589, 23)
        Me.Lb_0.TabIndex = 136
        Me.Lb_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxDato0
        '
        Me.TxDato0.Autonumerico = False
        Me.TxDato0.Buscando = False
        Me.TxDato0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDato0.ClForm = Nothing
        Me.TxDato0.ClParam = Nothing
        Me.TxDato0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato0.GridLin = Nothing
        Me.TxDato0.HaCambiado = False
        Me.TxDato0.lbbusca = Nothing
        Me.TxDato0.Location = New System.Drawing.Point(107, 6)
        Me.TxDato0.MiError = False
        Me.TxDato0.Name = "TxDato0"
        Me.TxDato0.Orden = 0
        Me.TxDato0.SaltoAlfinal = False
        Me.TxDato0.Siguiente = 0
        Me.TxDato0.Size = New System.Drawing.Size(63, 22)
        Me.TxDato0.TabIndex = 42
        Me.TxDato0.TeclaRepetida = False
        '
        'Lb0
        '
        Me.Lb0.AutoSize = True
        Me.Lb0.CL_ControlAsociado = Nothing
        Me.Lb0.CL_ValorFijo = False
        Me.Lb0.ClForm = Nothing
        Me.Lb0.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb0.ForeColor = System.Drawing.Color.Teal
        Me.Lb0.Location = New System.Drawing.Point(13, 9)
        Me.Lb0.Name = "Lb0"
        Me.Lb0.Size = New System.Drawing.Size(73, 16)
        Me.Lb0.TabIndex = 41
        Me.Lb0.Text = "Contacto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.clgrid1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 221)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 213)
        Me.Panel3.TabIndex = 75
        '
        'clgrid1
        '
        Me.clgrid1.AñadirLinea = True
        Me.clgrid1.Cargando = False
        Me.clgrid1.Consulta = Nothing
        Me.clgrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clgrid1.DtLineas = Nothing
        Me.clgrid1.EntidadLinea = Nothing
        Me.clgrid1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clgrid1.Formu = Nothing
        Me.clgrid1.GridEnterAutomatico = False
        Me.clgrid1.IdLinea = Nothing
        Me.clgrid1.LineaBloqueada = False
        Me.clgrid1.ListaCamposGr = Nothing
        Me.clgrid1.Location = New System.Drawing.Point(0, 0)
        Me.clgrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clgrid1.MismaLinea = False
        Me.clgrid1.Name = "clgrid1"
        Me.clgrid1.Nlinea = 0
        Me.clgrid1.OcultarCeros = False
        Me.clgrid1.PrimerControl = 0
        Me.clgrid1.Saliendo = False
        Me.clgrid1.Size = New System.Drawing.Size(788, 211)
        Me.clgrid1.TabIndex = 90
        Me.clgrid1.UltimoControl = 0
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(17, 75)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(51, 16)
        Me.Lb1.TabIndex = 77
        Me.Lb1.Text = "Cargo"
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
        Me.TxDato1.Location = New System.Drawing.Point(156, 72)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(289, 22)
        Me.TxDato1.TabIndex = 76
        Me.TxDato1.TeclaRepetida = False
        '
        'FrmContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 468)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxDato6)
        Me.Controls.Add(Me.TxDato5)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.TxDato8)
        Me.Controls.Add(Me.TxDato10)
        Me.Controls.Add(Me.TxDato9)
        Me.Controls.Add(Me.TxDato7)
        Me.Controls.Add(Me.Lb9)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me._PanelCargando)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmContactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos"
        Me.Controls.SetChildIndex(Me._PanelCargando, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.Controls.SetChildIndex(Me.Lb9, 0)
        Me.Controls.SetChildIndex(Me.TxDato7, 0)
        Me.Controls.SetChildIndex(Me.TxDato9, 0)
        Me.Controls.SetChildIndex(Me.TxDato10, 0)
        Me.Controls.SetChildIndex(Me.TxDato8, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.TxDato5, 0)
        Me.Controls.SetChildIndex(Me.TxDato6, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
    Friend WithEvents Lb9 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents TxDato10 As NetAgro.TxDato
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxDato0 As NetAgro.TxDato
    Friend WithEvents Lb0 As NetAgro.Lb
    Friend WithEvents Lb_0 As NetAgro.Lb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents clgrid1 As NetAgro.ClGrid
    Friend WithEvents Botros As NetAgro.ClButton
    Friend WithEvents BLogistica As NetAgro.ClButton
    Friend WithEvents Bcomercial As NetAgro.ClButton
    Friend WithEvents Badmon As NetAgro.ClButton
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents TxDato1 As NetAgro.TxDato
End Class
