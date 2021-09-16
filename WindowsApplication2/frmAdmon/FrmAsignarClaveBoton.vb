Imports System.Reflection

Public Class FrmAsignarClaveBoton

    Private err As New Errores
    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Private PermisosBoton As New E_PermisosBotones(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = PermisosBoton.PBT_Clave
        cl.Tipo = Cdatos.TiposCampo.Cadena
        cl.Longitud = PermisosBoton.PBT_Clave.Longitud

        TxDato1.Orden = 0
        TxDato1.ClParam = cl

        TxDato1.ClForm = Me
        Lb1.CL_ControlAsociado = TxDato1
        Lb1.CL_ValorFijo = True


        cl = New Cdatos.PropiedadesTx
        cl.CampoBd = PermisosBoton.PBT_Descripcion
        cl.Tipo = Cdatos.TiposCampo.Cadena
        cl.Longitud = PermisosBoton.PBT_Descripcion.Longitud

        TxDato2.Orden = 1
        TxDato2.ClParam = cl

        TxDato2.ClForm = Me
        Lb4.CL_ControlAsociado = TxDato2
        Lb4.CL_ValorFijo = True

        chkQuitarClave.ClForm = Me
        chkQuitarClave.Orden = 2
        chkQuitarClave.Campobd = Nothing
        chkQuitarClave.ValorCampoTrue = "S"
        chkQuitarClave.ValorCampoFalse = "N"


    End Sub


    Private Sub FrmAsignarClaveBoton_Load(sender As Object, e As System.EventArgs) Handles Me.Load


    End Sub


    Private Sub CargaBotones(row As DataRow)

        Dim dt As New DataTable
        Dim col As New DataColumn("Boton", GetType(String))
        dt.Columns.Add(col)
        col = New DataColumn("NombreBoton", GetType(String))
        dt.Columns.Add(col)
        col = New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)



        Try

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
            Dim NombreFormulario As String = (row("NombreFormulario").ToString & "").Trim
            'Dim NombreFormulario As String = CbFormularios.Items(CbFormularios.SelectedIndex)("NombreFormulario")


            If NombreFormulario.Trim <> "" Then

                Dim Formulario As Type = asm.GetType("NetAgro." & NombreFormulario)
                Dim f As Form = DirectCast(Activator.CreateInstance(Formulario), Form)


                Dim lst As List(Of ClButton) = ObtenerBotones(f)
                For Each b As ClButton In lst
                    Dim fila As DataRow = dt.NewRow()
                    fila("Boton") = b.Text & " (" & b.Name & ")"
                    fila("NombreBoton") = b.Name
                    dt.Rows.Add(fila)
                Next

                Dim dv As New DataView(dt)
                dv.Sort = "Boton"
                dt = dv.ToTable


            End If

        Catch ex As Exception
            err.Muestraerror("Error al obtener el formulario ", "CargaBotones", ex.Message)
        End Try


        GridBotones.DataSource = dt

        With GridViewBotones.Columns
            If Not IsNothing(.ColumnByFieldName("S")) Then .ColumnByFieldName("S").MaxWidth = 25
            If Not IsNothing(.ColumnByFieldName("NombreBoton")) Then .ColumnByFieldName("NombreBoton").Visible = False
        End With

        If GridViewBotones.RowCount > 0 Then

            GridViewBotones.FocusedRowHandle = 0
            Dim rf As DataRow = GridViewBotones.GetFocusedDataRow()
            If Not IsNothing(rf) Then
                MuestraBotonFila(rf)
            End If

        Else

            TxDato1.Text = ""
            TxDato2.Text = ""
            chkQuitarClave.Checked = False
            chkQuitarClave.Enabled = False

        End If

    End Sub


    Public Function ObtenerBotones(ctrl As Control) As List(Of ClButton)

        Dim lst As New List(Of ClButton)


        For Each c As Control In ctrl.Controls

            '
            If TypeOf c Is ClButton Then
                lst.Add(c)
            End If

            ''
            If c.HasChildren Then
                Dim lst2 As List(Of ClButton) = ObtenerBotones(c)
                lst.AddRange(lst2)
            End If

        Next


        Return lst

    End Function

    Private Sub GridViewBotones_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewBotones.RowCellClick

        Dim row As DataRow = GridViewBotones.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.ToUpper.Trim = "S" Then
                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If
            End If

            MuestraBotonFila(row)

        End If


    End Sub


    Private Sub MuestraBotonFila(rowBoton As DataRow)


        TxDato1.Text = ""
        TxDato2.Text = ""
        chkQuitarClave.Checked = False
        chkQuitarClave.Enabled = False


        ClButton1.Width = 98
        ClButton1.Height = 36
        ClButton1.Text = ""
        ClButton1.Image = Nothing


        Dim NombreBoton As String = (rowBoton("NombreBoton").ToString & "").Trim.ToLower
        Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

        Dim rowFormulario As DataRow = GridViewFormularios.GetFocusedDataRow()
        If Not IsNothing(rowFormulario) Then

            'Dim NombreFormulario As String = CbFormularios.Items(CbFormularios.SelectedIndex)("NombreFormulario")
            Dim NombreFormulario As String = (rowFormulario("NombreFormulario").ToString & "").Trim

            'Muestra botón
            If NombreFormulario.Trim <> "" Then

                Dim Formulario As Type = asm.GetType("NetAgro." & NombreFormulario)
                Dim f As Form = DirectCast(Activator.CreateInstance(Formulario), Form)


                Dim lst As List(Of ClButton) = ObtenerBotones(f)
                For Each b As ClButton In lst

                    If b.Name.ToLower.Trim = NombreBoton Then

                        'Dim myPropInfo As PropertyInfo = FrmAcreedores.BGuardar.GetType().GetProperty("Visible", BindingFlags.Public Or BindingFlags.Instance)
                        'Dim bv As Boolean = myPropInfo.GetValue(b, Nothing)


                        ClButton1.ImageAlign = b.ImageAlign
                        ClButton1.TextAlign = b.TextAlign
                        ClButton1.Width = b.Width
                        ClButton1.Height = b.Height
                        ClButton1.Text = b.Text
                        ClButton1.Image = b.Image
                    End If

                Next


            End If


            'Muestra datos permisos
            Dim Clave As String = ""
            Dim Descripcion As String = ""
            If PermisosBoton.ExisteRegistro(NombreFormulario.Trim.ToLower & "." & NombreBoton.Trim.ToLower, Clave, Descripcion) Then
                TxDato1.Text = Clave
                TxDato2.Text = Descripcion
                chkQuitarClave.Enabled = True
            Else
                chkQuitarClave.Enabled = False
            End If


        End If


    End Sub



    Private Sub GridViewBotones_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewBotones.FocusedRowChanged

        Dim row As DataRow = GridViewBotones.GetDataRow(e.FocusedRowHandle)
        If Not IsNothing(row) Then
            MuestraBotonFila(row)
        End If

    End Sub


    Private Sub GridViewBotones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewBotones.KeyDown
        If e.KeyCode = Keys.Space Then

            Dim row As DataRow = GridViewBotones.GetFocusedDataRow()
            If Not IsNothing(row) Then
                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If
            End If

        ElseIf e.KeyCode = Keys.Enter Then
            TxDato1.Select()
            TxDato1.Focus()
        End If
    End Sub

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        Dim lstBotones As New List(Of String)
        Dim rowFormulario As DataRow = GridViewFormularios.GetFocusedDataRow()

        If Not IsNothing(rowFormulario) Then

            Dim NombreFormulario As String = (rowFormulario("NombreFormulario").ToString & "").Trim.ToLower

            For indice As Integer = 0 To GridViewBotones.RowCount - 1
                Dim rowBoton As DataRow = GridViewBotones.GetDataRow(indice)
                If Not IsNothing(rowBoton) Then
                    If rowBoton("S") = True Then

                        Dim NombreBoton As String = (rowBoton("NombreBoton").ToString & "").Trim.ToLower
                        lstBotones.Add(NombreFormulario & "." & NombreBoton.Trim.ToLower)

                    End If
                End If
            Next


            If lstBotones.Count = 0 Then
                MsgBox("No se ha seleccionado ningún botón")
                Exit Sub
            End If



            If chkQuitarClave.Checked Then
                PermisosBoton.BorrarClave(lstBotones)
            Else
                PermisosBoton.AñadirClave(lstBotones, TxDato1.Text, TxDato2.Text)
            End If



            MsgBox("Cambios guardados!")

            TxDato1.Text = ""
            TxDato2.Text = ""
            chkQuitarClave.Checked = False
            chkQuitarClave.Enabled = False

            GridViewFormularios.Focus()

        End If


    End Sub


    Private Sub GridViewFormularios_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewFormularios.FocusedRowChanged

        Dim row As DataRow = GridViewFormularios.GetDataRow(e.FocusedRowHandle)
        If Not IsNothing(row) Then
            CargaBotones(row)
        End If

    End Sub

  
    Private Sub GridViewFormularios_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewFormularios.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridBotones.Select()
            GridBotones.Focus()
            GridViewBotones.Focus()
        End If
    End Sub

    Private Sub TxDato2_Valida(edicion As System.Boolean) Handles TxDato2.Valida

        If Not TxDato2.MiError Then
            If chkQuitarClave.Enabled Then
                chkQuitarClave.Select()
                chkQuitarClave.Focus()
            Else
                BGuardar.Select()
                BGuardar.Focus()
            End If
        End If

    End Sub

   
    Private Sub TxDato1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato1.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxDato2.Select()
            TxDato2.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            GridBotones.Select()
            GridBotones.Focus()
            GridViewBotones.Focus()
        End If

    End Sub

    Private Sub TxDato2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato2.KeyDown
        If e.KeyCode = Keys.Up Then
            TxDato1.Select()
            TxDato1.Focus()
        End If
    End Sub

    Private Sub chkQuitarClave_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles chkQuitarClave.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BGuardar.Select()
            BGuardar.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxDato2.Select()
            TxDato2.Focus()
        End If
    End Sub

    Private Sub chkQuitarClave_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles chkQuitarClave.EnabledChanged
        If chkQuitarClave.Enabled Then
            chkQuitarClave.ForeColor = Color.SteelBlue
        Else
            chkQuitarClave.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub GridViewFormularios_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewFormularios.RowCellClick

        Dim row As DataRow = GridViewFormularios.GetFocusedDataRow()
        If Not IsNothing(row) Then
            CargaBotones(row)
        End If

    End Sub


    Private Function ObtenerFormularios(ByRef TextoError As String) As DataTable

        Barra.Value = 0


        Dim dt As New DataTable

        Try

            dt.Columns.Add(New DataColumn("NombreFormulario", GetType(System.String)))      'Se refiere al nombre del control
            dt.Columns.Add(New DataColumn("Formulario", GetType(System.String)))            'Se refiere al texto del formulario

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
            Dim Fr As System.Type() = asm.GetTypes
            Barra.Maximum = Fr.Length

            For Each ty As Type In Fr
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                    Application.DoEvents()
                End If

                Dim NombreFormulario As Type = asm.GetType(ty.FullName)

                If Not NombreFormulario.FullName.StartsWith("Microsoft.") Then

                    If ty.BaseType.Name.ToLower = "frmantenimiento" Or
                        ty.BaseType.Name.ToLower = "frconsulta" Then


                        Dim f As Form = DirectCast(Activator.CreateInstance(NombreFormulario), Form)
                        Dim fila As DataRow = dt.NewRow()
                        fila("NombreFormulario") = ty.Name
                        fila("Formulario") = f.Text & " (" & f.Name & ")"
                        dt.Rows.Add(fila)

                    End If

                End If

            Next


            Dim dv As New DataView(dt)
            dv.Sort = "Formulario"
            dt = dv.ToTable

        Catch ex As Exception
            TextoError = ex.Message
        End Try



        Return dt

    End Function


    Private Sub FrmAsignarClaveBoton_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Dim TextoError As String = ""
        Dim dtFormularios As DataTable = ObtenerFormularios(TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los formularios", "FrmAsignarClaveBoton_Shown", TextoError)
            Exit Sub
        End If


        GridFormularios.DataSource = dtFormularios

        With GridViewFormularios.Columns
            If Not IsNothing(.ColumnByFieldName("NombreFormulario")) Then .ColumnByFieldName("NombreFormulario").Visible = False
        End With


        GridViewFormularios.OptionsBehavior.Editable = False
        GridViewFormularios.OptionsView.ShowGroupPanel = False
        GridViewBotones.OptionsBehavior.Editable = False
        GridViewBotones.OptionsView.ShowGroupPanel = False

        GridFormularios.Select()
        GridFormularios.Focus()
        GridViewFormularios.Focus()

        GridViewFormularios.ShowFindPanel()

        chkQuitarClave.Enabled = False

    End Sub
End Class