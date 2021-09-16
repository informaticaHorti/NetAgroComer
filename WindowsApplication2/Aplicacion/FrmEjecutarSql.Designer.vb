<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjecutarSql
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjecutarSql))
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb26 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCliente = New NetAgro.BtBusca(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.PanelVariables = New System.Windows.Forms.GroupBox()
        Me.NombreVar7 = New NetAgro.Lb(Me.components)
        Me.TxDato9 = New NetAgro.TxDato(Me.components)
        Me.NombreVar6 = New NetAgro.Lb(Me.components)
        Me.TxDato8 = New NetAgro.TxDato(Me.components)
        Me.NombreVar5 = New NetAgro.Lb(Me.components)
        Me.TxDato7 = New NetAgro.TxDato(Me.components)
        Me.NombreVar4 = New NetAgro.Lb(Me.components)
        Me.TxDato6 = New NetAgro.TxDato(Me.components)
        Me.NombreVar3 = New NetAgro.Lb(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.NombreVar2 = New NetAgro.Lb(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.NombreVar1 = New NetAgro.Lb(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Button3 = New NetAgro.ClButton()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVariables.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.PanelCabecera.Controls.Add(Me.Button3)
        Me.PanelCabecera.Controls.Add(Me.PanelVariables)
        Me.PanelCabecera.Controls.Add(Me.TxDato2)
        Me.PanelCabecera.Controls.Add(Me.Lb26)
        Me.PanelCabecera.Controls.Add(Me.BtBuscaCliente)
        Me.PanelCabecera.Controls.Add(Me.Lb1)
        Me.PanelCabecera.Controls.Add(Me.TxDato1)
        Me.PanelCabecera.Size = New System.Drawing.Size(1144, 204)
        '
        'Panel3
        '
        Me.PanelConsulta.Location = New System.Drawing.Point(0, 210)
        Me.PanelConsulta.Size = New System.Drawing.Size(1144, 290)
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(844, 0)
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(919, 0)
        '
        'BInforme
        '
        Me.BInforme.Location = New System.Drawing.Point(994, 0)
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(1069, 0)
        '
        'BtAux
        '
        Me.BtAux.Location = New System.Drawing.Point(769, 0)
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
        Me.TxDato1.Location = New System.Drawing.Point(116, 13)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.SaltoAlfinal = False
        Me.TxDato1.Siguiente = 0
        Me.TxDato1.Size = New System.Drawing.Size(45, 22)
        Me.TxDato1.TabIndex = 81
        Me.TxDato1.TeclaRepetida = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.ClForm = Nothing
        Me.Lb1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.Teal
        Me.Lb1.Location = New System.Drawing.Point(13, 16)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(91, 16)
        Me.Lb1.TabIndex = 80
        Me.Lb1.Text = "Id Consulta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        Me.PictureBox1.Location = New System.Drawing.Point(0, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 100274
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lb26
        '
        Me.Lb26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb26.CL_ControlAsociado = Nothing
        Me.Lb26.CL_ValorFijo = False
        Me.Lb26.ClForm = Nothing
        Me.Lb26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb26.Location = New System.Drawing.Point(206, 12)
        Me.Lb26.Name = "Lb26"
        Me.Lb26.Size = New System.Drawing.Size(438, 23)
        Me.Lb26.TabIndex = 100276
        '
        'BtBuscaCliente
        '
        Me.BtBuscaCliente.CL_BuscaAlb = False
        Me.BtBuscaCliente.CL_campocodigo = Nothing
        Me.BtBuscaCliente.CL_camponombre = Nothing
        Me.BtBuscaCliente.CL_CampoOrden = "Nombre"
        Me.BtBuscaCliente.CL_ch1000 = False
        Me.BtBuscaCliente.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCliente.CL_ControlAsociado = Nothing
        Me.BtBuscaCliente.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCliente.CL_dfecha = Nothing
        Me.BtBuscaCliente.CL_Entidad = Nothing
        Me.BtBuscaCliente.CL_EsId = True
        Me.BtBuscaCliente.CL_Filtro = Nothing
        Me.BtBuscaCliente.cl_formu = Nothing
        Me.BtBuscaCliente.CL_hfecha = Nothing
        Me.BtBuscaCliente.cl_ListaW = Nothing
        Me.BtBuscaCliente.CL_xCentro = False
        Me.BtBuscaCliente.Image = CType(resources.GetObject("BtBuscaCliente.Image"), System.Drawing.Image)
        Me.BtBuscaCliente.Location = New System.Drawing.Point(167, 12)
        Me.BtBuscaCliente.Name = "BtBuscaCliente"
        Me.BtBuscaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCliente.TabIndex = 100275
        Me.BtBuscaCliente.UseVisualStyleBackColor = True
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
        Me.TxDato2.Location = New System.Drawing.Point(16, 50)
        Me.TxDato2.MiError = False
        Me.TxDato2.Multiline = True
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.SaltoAlfinal = False
        Me.TxDato2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxDato2.Siguiente = 0
        Me.TxDato2.Size = New System.Drawing.Size(680, 151)
        Me.TxDato2.TabIndex = 100277
        Me.TxDato2.TeclaRepetida = False
        '
        'PanelVariables
        '
        Me.PanelVariables.Controls.Add(Me.NombreVar7)
        Me.PanelVariables.Controls.Add(Me.TxDato9)
        Me.PanelVariables.Controls.Add(Me.NombreVar6)
        Me.PanelVariables.Controls.Add(Me.TxDato8)
        Me.PanelVariables.Controls.Add(Me.PictureBox1)
        Me.PanelVariables.Controls.Add(Me.NombreVar5)
        Me.PanelVariables.Controls.Add(Me.TxDato7)
        Me.PanelVariables.Controls.Add(Me.NombreVar4)
        Me.PanelVariables.Controls.Add(Me.TxDato6)
        Me.PanelVariables.Controls.Add(Me.NombreVar3)
        Me.PanelVariables.Controls.Add(Me.TxDato5)
        Me.PanelVariables.Controls.Add(Me.NombreVar2)
        Me.PanelVariables.Controls.Add(Me.TxDato4)
        Me.PanelVariables.Controls.Add(Me.NombreVar1)
        Me.PanelVariables.Controls.Add(Me.TxDato3)
        Me.PanelVariables.Location = New System.Drawing.Point(712, 9)
        Me.PanelVariables.Name = "PanelVariables"
        Me.PanelVariables.Size = New System.Drawing.Size(420, 192)
        Me.PanelVariables.TabIndex = 100278
        Me.PanelVariables.TabStop = False
        Me.PanelVariables.Text = "Variables"
        '
        'NombreVar7
        '
        Me.NombreVar7.AutoSize = True
        Me.NombreVar7.CL_ControlAsociado = Nothing
        Me.NombreVar7.CL_ValorFijo = False
        Me.NombreVar7.ClForm = Nothing
        Me.NombreVar7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar7.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar7.Location = New System.Drawing.Point(16, 167)
        Me.NombreVar7.Name = "NombreVar7"
        Me.NombreVar7.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar7.TabIndex = 94
        Me.NombreVar7.Text = "Var1"
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
        Me.TxDato9.Location = New System.Drawing.Point(185, 161)
        Me.TxDato9.MiError = False
        Me.TxDato9.Name = "TxDato9"
        Me.TxDato9.Orden = 0
        Me.TxDato9.SaltoAlfinal = False
        Me.TxDato9.Siguiente = 0
        Me.TxDato9.Size = New System.Drawing.Size(229, 22)
        Me.TxDato9.TabIndex = 95
        Me.TxDato9.TeclaRepetida = False
        '
        'NombreVar6
        '
        Me.NombreVar6.AutoSize = True
        Me.NombreVar6.CL_ControlAsociado = Nothing
        Me.NombreVar6.CL_ValorFijo = False
        Me.NombreVar6.ClForm = Nothing
        Me.NombreVar6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar6.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar6.Location = New System.Drawing.Point(16, 141)
        Me.NombreVar6.Name = "NombreVar6"
        Me.NombreVar6.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar6.TabIndex = 92
        Me.NombreVar6.Text = "Var1"
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
        Me.TxDato8.Location = New System.Drawing.Point(185, 135)
        Me.TxDato8.MiError = False
        Me.TxDato8.Name = "TxDato8"
        Me.TxDato8.Orden = 0
        Me.TxDato8.SaltoAlfinal = False
        Me.TxDato8.Siguiente = 0
        Me.TxDato8.Size = New System.Drawing.Size(229, 22)
        Me.TxDato8.TabIndex = 93
        Me.TxDato8.TeclaRepetida = False
        '
        'NombreVar5
        '
        Me.NombreVar5.AutoSize = True
        Me.NombreVar5.CL_ControlAsociado = Nothing
        Me.NombreVar5.CL_ValorFijo = False
        Me.NombreVar5.ClForm = Nothing
        Me.NombreVar5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar5.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar5.Location = New System.Drawing.Point(16, 116)
        Me.NombreVar5.Name = "NombreVar5"
        Me.NombreVar5.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar5.TabIndex = 90
        Me.NombreVar5.Text = "Var1"
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
        Me.TxDato7.Location = New System.Drawing.Point(185, 110)
        Me.TxDato7.MiError = False
        Me.TxDato7.Name = "TxDato7"
        Me.TxDato7.Orden = 0
        Me.TxDato7.SaltoAlfinal = False
        Me.TxDato7.Siguiente = 0
        Me.TxDato7.Size = New System.Drawing.Size(229, 22)
        Me.TxDato7.TabIndex = 91
        Me.TxDato7.TeclaRepetida = False
        '
        'NombreVar4
        '
        Me.NombreVar4.AutoSize = True
        Me.NombreVar4.CL_ControlAsociado = Nothing
        Me.NombreVar4.CL_ValorFijo = False
        Me.NombreVar4.ClForm = Nothing
        Me.NombreVar4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar4.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar4.Location = New System.Drawing.Point(16, 91)
        Me.NombreVar4.Name = "NombreVar4"
        Me.NombreVar4.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar4.TabIndex = 88
        Me.NombreVar4.Text = "Var1"
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
        Me.TxDato6.Location = New System.Drawing.Point(185, 85)
        Me.TxDato6.MiError = False
        Me.TxDato6.Name = "TxDato6"
        Me.TxDato6.Orden = 0
        Me.TxDato6.SaltoAlfinal = False
        Me.TxDato6.Siguiente = 0
        Me.TxDato6.Size = New System.Drawing.Size(229, 22)
        Me.TxDato6.TabIndex = 89
        Me.TxDato6.TeclaRepetida = False
        '
        'NombreVar3
        '
        Me.NombreVar3.AutoSize = True
        Me.NombreVar3.CL_ControlAsociado = Nothing
        Me.NombreVar3.CL_ValorFijo = False
        Me.NombreVar3.ClForm = Nothing
        Me.NombreVar3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar3.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar3.Location = New System.Drawing.Point(16, 66)
        Me.NombreVar3.Name = "NombreVar3"
        Me.NombreVar3.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar3.TabIndex = 86
        Me.NombreVar3.Text = "Var1"
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
        Me.TxDato5.Location = New System.Drawing.Point(185, 60)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.SaltoAlfinal = False
        Me.TxDato5.Siguiente = 0
        Me.TxDato5.Size = New System.Drawing.Size(229, 22)
        Me.TxDato5.TabIndex = 87
        Me.TxDato5.TeclaRepetida = False
        '
        'NombreVar2
        '
        Me.NombreVar2.AutoSize = True
        Me.NombreVar2.CL_ControlAsociado = Nothing
        Me.NombreVar2.CL_ValorFijo = False
        Me.NombreVar2.ClForm = Nothing
        Me.NombreVar2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar2.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar2.Location = New System.Drawing.Point(16, 41)
        Me.NombreVar2.Name = "NombreVar2"
        Me.NombreVar2.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar2.TabIndex = 84
        Me.NombreVar2.Text = "Var1"
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
        Me.TxDato4.Location = New System.Drawing.Point(185, 35)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.SaltoAlfinal = False
        Me.TxDato4.Siguiente = 0
        Me.TxDato4.Size = New System.Drawing.Size(229, 22)
        Me.TxDato4.TabIndex = 85
        Me.TxDato4.TeclaRepetida = False
        '
        'NombreVar1
        '
        Me.NombreVar1.AutoSize = True
        Me.NombreVar1.CL_ControlAsociado = Nothing
        Me.NombreVar1.CL_ValorFijo = False
        Me.NombreVar1.ClForm = Nothing
        Me.NombreVar1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreVar1.ForeColor = System.Drawing.Color.Teal
        Me.NombreVar1.Location = New System.Drawing.Point(16, 16)
        Me.NombreVar1.Name = "NombreVar1"
        Me.NombreVar1.Size = New System.Drawing.Size(42, 16)
        Me.NombreVar1.TabIndex = 82
        Me.NombreVar1.Text = "Var1"
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
        Me.TxDato3.Location = New System.Drawing.Point(185, 10)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.SaltoAlfinal = False
        Me.TxDato3.Siguiente = 0
        Me.TxDato3.Size = New System.Drawing.Size(229, 22)
        Me.TxDato3.TabIndex = 83
        Me.TxDato3.TeclaRepetida = False
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(670, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Orden = 0
        Me.Button3.PedirClave = True
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 100383
        Me.tt.SetToolTip(Me.Button3, "Nueva consulta")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmEjecutarSql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 562)
        Me.Controls.Add(Me._PanelCargando)
        Me.IncluirTodosLosCamposVisible = True
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmEjecutarSql"
        Me.Text = "Ejecutar consultas"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVariables.ResumeLayout(False)
        Me.PanelVariables.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelVariables As System.Windows.Forms.GroupBox
    Friend WithEvents NombreVar7 As NetAgro.Lb
    Friend WithEvents TxDato9 As NetAgro.TxDato
    Friend WithEvents NombreVar6 As NetAgro.Lb
    Friend WithEvents TxDato8 As NetAgro.TxDato
    Friend WithEvents NombreVar5 As NetAgro.Lb
    Friend WithEvents TxDato7 As NetAgro.TxDato
    Friend WithEvents NombreVar4 As NetAgro.Lb
    Friend WithEvents TxDato6 As NetAgro.TxDato
    Friend WithEvents NombreVar3 As NetAgro.Lb
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents NombreVar2 As NetAgro.Lb
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents NombreVar1 As NetAgro.Lb
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb26 As NetAgro.Lb
    Friend WithEvents BtBuscaCliente As NetAgro.BtBusca
    Friend WithEvents Button3 As NetAgro.ClButton
End Class
