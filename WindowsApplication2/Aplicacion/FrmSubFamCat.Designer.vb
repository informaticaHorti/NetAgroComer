<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubFamCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubFamCat))
        Me.BtBuscaFamilia = New NetAgro.BtBusca(Me.components)
        Me.TxDato1 = New NetAgro.TxDato(Me.components)
        Me.Lb1 = New NetAgro.Lb(Me.components)
        Me.BtBuscaSfam = New NetAgro.BtBusca(Me.components)
        Me.TxDato2 = New NetAgro.TxDato(Me.components)
        Me.Lb2 = New NetAgro.Lb(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb10 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCatEnt1 = New NetAgro.BtBusca(Me.components)
        Me.TxDato5 = New NetAgro.TxDato(Me.components)
        Me.Lb11 = New NetAgro.Lb(Me.components)
        Me.ClGrid1 = New NetAgro.ClGrid()
        Me.Lb3 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCatSal = New NetAgro.BtBusca(Me.components)
        Me.TxDato3 = New NetAgro.TxDato(Me.components)
        Me.Lb4 = New NetAgro.Lb(Me.components)
        Me.ClGrid2 = New NetAgro.ClGrid()
        Me.Lb5 = New NetAgro.Lb(Me.components)
        Me.BtBuscaCatEnt2 = New NetAgro.BtBusca(Me.components)
        Me.TxDato4 = New NetAgro.TxDato(Me.components)
        Me.Lb6 = New NetAgro.Lb(Me.components)
        Me.Lb7 = New NetAgro.Lb(Me.components)
        Me.Lb8 = New NetAgro.Lb(Me.components)
        Me.SuspendLayout()
        '
        'BtBuscaFamilia
        '
        Me.BtBuscaFamilia.CL_CampoOrden = "Nombre"
        Me.BtBuscaFamilia.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaFamilia.CL_ControlAsociado = Me.TxDato1
        Me.BtBuscaFamilia.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaFamilia.CL_Entidad = Nothing
        Me.BtBuscaFamilia.CL_Filtro = Nothing
        Me.BtBuscaFamilia.cl_formu = Nothing
        Me.BtBuscaFamilia.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaFamilia.Location = New System.Drawing.Point(174, 16)
        Me.BtBuscaFamilia.Name = "BtBuscaFamilia"
        Me.BtBuscaFamilia.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaFamilia.TabIndex = 32
        Me.BtBuscaFamilia.UseVisualStyleBackColor = True
        '
        'TxDato1
        '
        Me.TxDato1.ClForm = Nothing
        Me.TxDato1.ClParam = Nothing
        Me.TxDato1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato1.GridLin = Nothing
        Me.TxDato1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato1.Location = New System.Drawing.Point(109, 16)
        Me.TxDato1.MiError = False
        Me.TxDato1.Name = "TxDato1"
        Me.TxDato1.Orden = 0
        Me.TxDato1.Size = New System.Drawing.Size(59, 22)
        Me.TxDato1.TabIndex = 30
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.CL_ControlAsociado = Nothing
        Me.Lb1.CL_ValorFijo = False
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb1.Location = New System.Drawing.Point(21, 23)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(59, 16)
        Me.Lb1.TabIndex = 31
        Me.Lb1.Text = "Familia"
        '
        'BtBuscaSfam
        '
        Me.BtBuscaSfam.CL_CampoOrden = "Nombre"
        Me.BtBuscaSfam.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaSfam.CL_ControlAsociado = Me.TxDato2
        Me.BtBuscaSfam.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaSfam.CL_Entidad = Nothing
        Me.BtBuscaSfam.CL_Filtro = Nothing
        Me.BtBuscaSfam.cl_formu = Nothing
        Me.BtBuscaSfam.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaSfam.Location = New System.Drawing.Point(174, 42)
        Me.BtBuscaSfam.Name = "BtBuscaSfam"
        Me.BtBuscaSfam.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaSfam.TabIndex = 35
        Me.BtBuscaSfam.UseVisualStyleBackColor = True
        '
        'TxDato2
        '
        Me.TxDato2.ClForm = Nothing
        Me.TxDato2.ClParam = Nothing
        Me.TxDato2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato2.GridLin = Nothing
        Me.TxDato2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato2.Location = New System.Drawing.Point(109, 42)
        Me.TxDato2.MiError = False
        Me.TxDato2.Name = "TxDato2"
        Me.TxDato2.Orden = 0
        Me.TxDato2.Size = New System.Drawing.Size(59, 22)
        Me.TxDato2.TabIndex = 33
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.CL_ControlAsociado = Nothing
        Me.Lb2.CL_ValorFijo = False
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb2.Location = New System.Drawing.Point(21, 49)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(81, 16)
        Me.Lb2.TabIndex = 34
        Me.Lb2.Text = "Subfamilia"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 296)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Entradas"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 296)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Salidas"
        '
        'Lb10
        '
        Me.Lb10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb10.CL_ControlAsociado = Nothing
        Me.Lb10.CL_ValorFijo = False
        Me.Lb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb10.Location = New System.Drawing.Point(203, 92)
        Me.Lb10.Name = "Lb10"
        Me.Lb10.Size = New System.Drawing.Size(156, 23)
        Me.Lb10.TabIndex = 106
        '
        'BtBuscaCatEnt1
        '
        Me.BtBuscaCatEnt1.CL_CampoOrden = "Nombre"
        Me.BtBuscaCatEnt1.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCatEnt1.CL_ControlAsociado = Me.TxDato5
        Me.BtBuscaCatEnt1.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCatEnt1.CL_Entidad = Nothing
        Me.BtBuscaCatEnt1.CL_Filtro = Nothing
        Me.BtBuscaCatEnt1.cl_formu = Nothing
        Me.BtBuscaCatEnt1.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCatEnt1.Location = New System.Drawing.Point(164, 92)
        Me.BtBuscaCatEnt1.Name = "BtBuscaCatEnt1"
        Me.BtBuscaCatEnt1.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCatEnt1.TabIndex = 105
        Me.BtBuscaCatEnt1.UseVisualStyleBackColor = True
        '
        'TxDato5
        '
        Me.TxDato5.ClForm = Nothing
        Me.TxDato5.ClParam = Nothing
        Me.TxDato5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato5.GridLin = Nothing
        Me.TxDato5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato5.Location = New System.Drawing.Point(115, 92)
        Me.TxDato5.MiError = False
        Me.TxDato5.Name = "TxDato5"
        Me.TxDato5.Orden = 0
        Me.TxDato5.Size = New System.Drawing.Size(43, 22)
        Me.TxDato5.TabIndex = 104
        '
        'Lb11
        '
        Me.Lb11.AutoSize = True
        Me.Lb11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lb11.CL_ControlAsociado = Nothing
        Me.Lb11.CL_ValorFijo = False
        Me.Lb11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb11.Location = New System.Drawing.Point(33, 98)
        Me.Lb11.Name = "Lb11"
        Me.Lb11.Size = New System.Drawing.Size(76, 16)
        Me.Lb11.TabIndex = 103
        Me.Lb11.Text = "Categoria"
        '
        'ClGrid1
        '
        Me.ClGrid1.Cargando = False
        Me.ClGrid1.Consulta = Nothing
        Me.ClGrid1.DtLineas = Nothing
        Me.ClGrid1.EntidadLinea = Nothing
        Me.ClGrid1.Formu = Nothing
        Me.ClGrid1.IdLinea = Nothing
        Me.ClGrid1.ListaCamposGr = Nothing
        Me.ClGrid1.Location = New System.Drawing.Point(36, 135)
        Me.ClGrid1.Name = "ClGrid1"
        Me.ClGrid1.Nlinea = 0
        Me.ClGrid1.PrimerControl = 0
        Me.ClGrid1.Saliendo = False
        Me.ClGrid1.Size = New System.Drawing.Size(323, 220)
        Me.ClGrid1.TabIndex = 102
        Me.ClGrid1.UltimoControl = 0
        '
        'Lb3
        '
        Me.Lb3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb3.CL_ControlAsociado = Nothing
        Me.Lb3.CL_ValorFijo = False
        Me.Lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb3.Location = New System.Drawing.Point(571, 90)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(156, 23)
        Me.Lb3.TabIndex = 111
        '
        'BtBuscaCatSal
        '
        Me.BtBuscaCatSal.CL_CampoOrden = "Nombre"
        Me.BtBuscaCatSal.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCatSal.CL_ControlAsociado = Me.TxDato3
        Me.BtBuscaCatSal.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCatSal.CL_Entidad = Nothing
        Me.BtBuscaCatSal.CL_Filtro = Nothing
        Me.BtBuscaCatSal.cl_formu = Nothing
        Me.BtBuscaCatSal.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCatSal.Location = New System.Drawing.Point(532, 91)
        Me.BtBuscaCatSal.Name = "BtBuscaCatSal"
        Me.BtBuscaCatSal.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCatSal.TabIndex = 110
        Me.BtBuscaCatSal.UseVisualStyleBackColor = True
        '
        'TxDato3
        '
        Me.TxDato3.ClForm = Nothing
        Me.TxDato3.ClParam = Nothing
        Me.TxDato3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato3.GridLin = Nothing
        Me.TxDato3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato3.Location = New System.Drawing.Point(483, 91)
        Me.TxDato3.MiError = False
        Me.TxDato3.Name = "TxDato3"
        Me.TxDato3.Orden = 0
        Me.TxDato3.Size = New System.Drawing.Size(43, 22)
        Me.TxDato3.TabIndex = 109
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lb4.CL_ControlAsociado = Nothing
        Me.Lb4.CL_ValorFijo = False
        Me.Lb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb4.Location = New System.Drawing.Point(388, 97)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(76, 16)
        Me.Lb4.TabIndex = 108
        Me.Lb4.Text = "Categoria"
        '
        'ClGrid2
        '
        Me.ClGrid2.Cargando = False
        Me.ClGrid2.Consulta = Nothing
        Me.ClGrid2.DtLineas = Nothing
        Me.ClGrid2.EntidadLinea = Nothing
        Me.ClGrid2.Formu = Nothing
        Me.ClGrid2.IdLinea = Nothing
        Me.ClGrid2.ListaCamposGr = Nothing
        Me.ClGrid2.Location = New System.Drawing.Point(391, 157)
        Me.ClGrid2.Name = "ClGrid2"
        Me.ClGrid2.Nlinea = 0
        Me.ClGrid2.PrimerControl = 0
        Me.ClGrid2.Saliendo = False
        Me.ClGrid2.Size = New System.Drawing.Size(323, 197)
        Me.ClGrid2.TabIndex = 107
        Me.ClGrid2.UltimoControl = 0
        '
        'Lb5
        '
        Me.Lb5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb5.CL_ControlAsociado = Nothing
        Me.Lb5.CL_ValorFijo = False
        Me.Lb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb5.Location = New System.Drawing.Point(571, 113)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(156, 23)
        Me.Lb5.TabIndex = 115
        '
        'BtBuscaCatEnt2
        '
        Me.BtBuscaCatEnt2.CL_CampoOrden = "Nombre"
        Me.BtBuscaCatEnt2.CL_ConsultaSql = "Select * from familias"
        Me.BtBuscaCatEnt2.CL_ControlAsociado = Me.TxDato4
        Me.BtBuscaCatEnt2.CL_DevuelveCampo = "Idfamilia"
        Me.BtBuscaCatEnt2.CL_Entidad = Nothing
        Me.BtBuscaCatEnt2.CL_Filtro = Nothing
        Me.BtBuscaCatEnt2.cl_formu = Nothing
        Me.BtBuscaCatEnt2.Image = Global.NetAgro.My.Resources.Resources.App_file_replace_16x16_32
        Me.BtBuscaCatEnt2.Location = New System.Drawing.Point(532, 114)
        Me.BtBuscaCatEnt2.Name = "BtBuscaCatEnt2"
        Me.BtBuscaCatEnt2.Size = New System.Drawing.Size(33, 23)
        Me.BtBuscaCatEnt2.TabIndex = 114
        Me.BtBuscaCatEnt2.UseVisualStyleBackColor = True
        '
        'TxDato4
        '
        Me.TxDato4.ClForm = Nothing
        Me.TxDato4.ClParam = Nothing
        Me.TxDato4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxDato4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDato4.GridLin = Nothing
        Me.TxDato4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxDato4.Location = New System.Drawing.Point(483, 114)
        Me.TxDato4.MiError = False
        Me.TxDato4.Name = "TxDato4"
        Me.TxDato4.Orden = 0
        Me.TxDato4.Size = New System.Drawing.Size(43, 22)
        Me.TxDato4.TabIndex = 113
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lb6.CL_ControlAsociado = Nothing
        Me.Lb6.CL_ValorFijo = False
        Me.Lb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb6.Location = New System.Drawing.Point(388, 120)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(89, 16)
        Me.Lb6.TabIndex = 112
        Me.Lb6.Text = "Cat.Entrada"
        '
        'Lb7
        '
        Me.Lb7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb7.CL_ControlAsociado = Nothing
        Me.Lb7.CL_ValorFijo = False
        Me.Lb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb7.Location = New System.Drawing.Point(212, 15)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(314, 23)
        Me.Lb7.TabIndex = 116
        '
        'Lb8
        '
        Me.Lb8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb8.CL_ControlAsociado = Nothing
        Me.Lb8.CL_ValorFijo = False
        Me.Lb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb8.Location = New System.Drawing.Point(212, 42)
        Me.Lb8.Name = "Lb8"
        Me.Lb8.Size = New System.Drawing.Size(314, 23)
        Me.Lb8.TabIndex = 117
        '
        'FrmSubFamCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 410)
        Me.Controls.Add(Me.Lb8)
        Me.Controls.Add(Me.Lb7)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.BtBuscaCatEnt2)
        Me.Controls.Add(Me.TxDato4)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.BtBuscaCatSal)
        Me.Controls.Add(Me.TxDato3)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.ClGrid2)
        Me.Controls.Add(Me.Lb10)
        Me.Controls.Add(Me.BtBuscaCatEnt1)
        Me.Controls.Add(Me.TxDato5)
        Me.Controls.Add(Me.Lb11)
        Me.Controls.Add(Me.ClGrid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtBuscaSfam)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxDato2)
        Me.Controls.Add(Me.BtBuscaFamilia)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.TxDato1)
        Me.ListaEtiquetas = CType(resources.GetObject("$this.ListaEtiquetas"), System.Collections.Generic.List(Of Object))
        Me.Name = "FrmSubFamCat"
        Me.Text = "Asociar categorias por subfamilia"
        Me.Controls.SetChildIndex(Me.TxDato1, 0)
        Me.Controls.SetChildIndex(Me.Lb1, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaFamilia, 0)
        Me.Controls.SetChildIndex(Me.TxDato2, 0)
        Me.Controls.SetChildIndex(Me.Lb2, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaSfam, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ClGrid1, 0)
        Me.Controls.SetChildIndex(Me.Lb11, 0)
        Me.Controls.SetChildIndex(Me.TxDato5, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCatEnt1, 0)
        Me.Controls.SetChildIndex(Me.Lb10, 0)
        Me.Controls.SetChildIndex(Me.ClGrid2, 0)
        Me.Controls.SetChildIndex(Me.Lb4, 0)
        Me.Controls.SetChildIndex(Me.TxDato3, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCatSal, 0)
        Me.Controls.SetChildIndex(Me.Lb3, 0)
        Me.Controls.SetChildIndex(Me.Lb6, 0)
        Me.Controls.SetChildIndex(Me.TxDato4, 0)
        Me.Controls.SetChildIndex(Me.BtBuscaCatEnt2, 0)
        Me.Controls.SetChildIndex(Me.Lb5, 0)
        Me.Controls.SetChildIndex(Me.Lb7, 0)
        Me.Controls.SetChildIndex(Me.Lb8, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtBuscaFamilia As NetAgro.BtBusca
    Friend WithEvents TxDato1 As NetAgro.TxDato
    Friend WithEvents Lb1 As NetAgro.Lb
    Friend WithEvents BtBuscaSfam As NetAgro.BtBusca
    Friend WithEvents TxDato2 As NetAgro.TxDato
    Friend WithEvents Lb2 As NetAgro.Lb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lb10 As NetAgro.Lb
    Friend WithEvents BtBuscaCatEnt1 As NetAgro.BtBusca
    Friend WithEvents TxDato5 As NetAgro.TxDato
    Friend WithEvents Lb11 As NetAgro.Lb
    Friend WithEvents ClGrid1 As NetAgro.ClGrid
    Friend WithEvents Lb3 As NetAgro.Lb
    Friend WithEvents BtBuscaCatSal As NetAgro.BtBusca
    Friend WithEvents TxDato3 As NetAgro.TxDato
    Friend WithEvents Lb4 As NetAgro.Lb
    Friend WithEvents ClGrid2 As NetAgro.ClGrid
    Friend WithEvents Lb5 As NetAgro.Lb
    Friend WithEvents BtBuscaCatEnt2 As NetAgro.BtBusca
    Friend WithEvents TxDato4 As NetAgro.TxDato
    Friend WithEvents Lb6 As NetAgro.Lb
    Friend WithEvents Lb7 As NetAgro.Lb
    Friend WithEvents Lb8 As NetAgro.Lb
End Class
