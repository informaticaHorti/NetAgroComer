Imports DevExpress.XtraEditors


Public Class frmAdministracionFormularios

    Private err As New Errores


    Private Perfiles As New E_Perfiles(Idusuario, CnComun)
    Private PerfilCb As New E_Perfiles(Idusuario, CnComun)
    Private LogFormularios As New E_LogFormularios(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Perfiles


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamCbFIJO(CbPerfiles, Perfiles.IdPerfil, Perfiles.TablaPerfiles(), Lb1)
        CampoClave = 0 ' ultimo campo de la clave
        ParamCbFIJO(CbPerfilesOrigen, PerfilCb.IdPerfil, PerfilCb.TablaPerfiles, Lb2)


    End Sub


    Public Overrides Sub ControlClave()
        Dim IdPerfil As Integer = VaInt(CbPerfiles.SelectedValue)
        If IdPerfil > 0 Then
            LbId.Text = IdPerfil.ToString
        End If
    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Modificando = True
        MyBase.BModificar_Click(sender, e)
    End Sub

    Public Sub SqlGrid(ByVal IdPerfil As Integer)


        Dim TextoError As String = ""

        Dim dt As DataTable = ObtenerPermisosFormularios(VaInt(IdPerfil), TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del perfil", "frmAdministracionMenus_Load", TextoError)
            Exit Sub
        End If


        Dim DcFormularios As New Dictionary(Of String, String)

        For Each row As DataRow In dt.Rows
            Dim formulario As String = row("NombreFormulario").ToString.ToLower & ""
            Dim permisos As String = row("Permisos").ToString & ""
            DcFormularios(formulario) = permisos
        Next


        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim rowGrid As DataRow = GridView1.GetDataRow(indice)
            Dim formulario As String = rowGrid("NombreFormulario").ToString & ""

            Dim bAltas As Boolean = False
            Dim bModificaciones As Boolean = False
            Dim bBajas As Boolean = False

            If DcFormularios.ContainsKey(formulario.ToLower.Trim) Then
                Dim permisos As String = DcFormularios(formulario.ToLower.Trim)

                If permisos.ToUpper.Contains(PermisosFormularios.Alta) Then bAltas = True
                If permisos.ToUpper.Contains(PermisosFormularios.Modificaciones) Then bModificaciones = True
                If permisos.ToUpper.Contains(PermisosFormularios.Bajas) Then bBajas = True

            End If

            rowGrid("Altas") = bAltas
            rowGrid("Modificaciones") = bModificaciones
            rowGrid("Bajas") = bBajas

        Next


    End Sub


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()


        ChkAltas.Checked = False
        ChkBajas.Checked = False
        ChkModificaciones.Checked = False

        ChkAltas.Enabled = False
        ChkModificaciones.Enabled = False
        ChkBajas.Enabled = False

        For indice As Integer = 0 To GridView1.RowCount - 1
            GridView1.GetDataRow(indice)("Altas") = False
            GridView1.GetDataRow(indice)("Modificaciones") = False
            GridView1.GetDataRow(indice)("Bajas") = False
        Next


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Altas")) Then GridView1.Columns.ColumnByFieldName("Altas").OptionsColumn.AllowEdit = False
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Modificaciones")) Then GridView1.Columns.ColumnByFieldName("Modificaciones").OptionsColumn.AllowEdit = False
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Bajas")) Then GridView1.Columns.ColumnByFieldName("Bajas").OptionsColumn.AllowEdit = False

        LbId.Text = ""
        CbPerfilesOrigen.Enabled = False


    End Sub



    Private Sub frmAdministracionFormularios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)

        If e.Column.FieldName.ToUpper = "ALTAS" And e.Column.OptionsColumn.AllowEdit Then
            If row("Altas") = False Then
                row("Altas") = True
            Else
                row("Altas") = False
            End If

        ElseIf e.Column.FieldName.ToUpper = "MODIFICACIONES" And e.Column.OptionsColumn.AllowEdit Then
            If row("Modificaciones") = False Then
                row("Modificaciones") = True
            Else
                row("Modificaciones") = False
            End If

        ElseIf e.Column.FieldName.ToUpper = "BAJAS" And e.Column.OptionsColumn.AllowEdit Then
            If row("Bajas") = False Then
                row("Bajas") = True
            Else
                row("Bajas") = False
            End If

        End If


    End Sub


    Private Sub ChkAltas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAltas.CheckedChanged

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            row("Altas") = ChkAltas.Checked
        Next

    End Sub

    Private Sub ChkModificaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkModificaciones.CheckedChanged

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            row("Modificaciones") = ChkModificaciones.Checked
        Next

    End Sub

    Private Sub ChkBajas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBajas.CheckedChanged

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            row("Bajas") = ChkBajas.Checked
        Next

    End Sub


    Public Overrides Sub Guardar()
        'MyBase.Guardar()



        Dim nIdPerfil As Integer = VaInt(CbPerfiles.SelectedValue)
        If nIdPerfil > 0 Then

            'Borra permisos para perfil
            LogFormularios.BorrarPermisosPerfil(nIdPerfil)


            'Añade los permisos individualmente
            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim formulario As String = GridView1.GetDataRow(indice)("NombreFormulario").ToString & ""
                Dim permisos As String = ""

                If GridView1.GetDataRow(indice)("Altas") = True Then permisos = permisos & PermisosFormularios.Alta
                If GridView1.GetDataRow(indice)("Modificaciones") = True Then permisos = permisos & PermisosFormularios.Modificaciones
                If GridView1.GetDataRow(indice)("Bajas") = True Then permisos = permisos & PermisosFormularios.Bajas

                If permisos.Trim <> "" Then
                    LogFormularios.AñadirPermisosPerfil(nIdPerfil, formulario.ToLower.Trim, permisos.ToUpper())
                End If

            Next

            BorraPan()

        End If


    End Sub


    Public Overrides Sub Modificar()
        'MyBase.Modificar()

        If VaInt(LbId.Text) > 0 Then

            ChkAltas.Enabled = True
            ChkModificaciones.Enabled = True
            ChkBajas.Enabled = True

            If Not IsNothing(GridView1.Columns.ColumnByFieldName("Altas")) Then GridView1.Columns.ColumnByFieldName("Altas").OptionsColumn.AllowEdit = True
            If Not IsNothing(GridView1.Columns.ColumnByFieldName("Modificaciones")) Then GridView1.Columns.ColumnByFieldName("Modificaciones").OptionsColumn.AllowEdit = True
            If Not IsNothing(GridView1.Columns.ColumnByFieldName("Bajas")) Then GridView1.Columns.ColumnByFieldName("Bajas").OptionsColumn.AllowEdit = True

            CbPerfilesOrigen.Enabled = True

        End If

    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()

        If VaInt(LbId.Text) > 0 Then

            If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then

                LogFormularios.BorrarPermisosPerfil(LbId.Text)
                BorraPan()
            End If

        End If

    End Sub


    Public Overrides Sub Salir()
        'MyBase.Salir()

        If LbId.Text.Trim = "" Then
            Me.Close()
        Else
            LbId.Text = ""
            Perfiles.VaciaEntidad()
            BorraPan()
        End If


    End Sub


    Private Sub CbPerfiles_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPerfiles.SelectionChangeCommitted

        ControlClave()
        If Perfiles.LeerId(LbId.Text) Then
            If VaInt(LbId.Text) > 0 Then
                SqlGrid(LbId.Text)
            Else
                BorraPan()
            End If
        End If

    End Sub

    Private Sub CbPerfilesOrigen_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPerfilesOrigen.SelectionChangeCommitted

        Dim IdPerfilOrigen As Integer = VaInt(CbPerfilesOrigen.SelectedValue)
        If IdPerfilOrigen > 0 Then
            SqlGrid(IdPerfilOrigen.ToString)
        End If

    End Sub

    Private Sub btTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTodos.Click


        If XtraMessageBox.Show("¿Está seguro de conceder permisos totales a TODOS los usuarios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Enabled = False


            Try

                Dim dt As DataTable = Perfiles.TablaPerfiles()

                If Not IsNothing(dt) Then

                    For Each row As DataRow In dt.Rows

                        Dim IdPerfil As String = (row("Id").ToString & "").Trim
                        Dim permisos As String = PermisosFormularios.Alta & PermisosFormularios.Modificaciones & PermisosFormularios.Bajas

                        For indice As Integer = 0 To GridView1.RowCount - 1

                            Dim formulario As String = GridView1.GetDataRow(indice)("NombreFormulario").ToString & ""
                            LogFormularios.AñadirPermisosPerfil(IdPerfil, formulario.ToLower.Trim, permisos.ToUpper())

                            Application.DoEvents()

                        Next

                    Next

                End If





                MsgBox("Terminado!")


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try



            Me.Enabled = True




        End If




    End Sub

    Private Function ObtenerFormulariosMantenimiento(ByRef TextoError As String) As DataTable


        Dim dt As New DataTable

        Try

            dt.Columns.Add(New DataColumn("NombreFormulario", GetType(System.String)))      'Se refiere al nombre del control
            dt.Columns.Add(New DataColumn("Formulario", GetType(System.String)))            'Se refiere al texto del formulario

            Dim colAltas As New DataColumn("Altas", GetType(System.Boolean))
            Dim colModificaciones As New DataColumn("Modificaciones", GetType(System.Boolean))
            Dim colBajas As New DataColumn("Bajas", GetType(System.Boolean))

            colAltas.DefaultValue = False
            colModificaciones.DefaultValue = False
            colBajas.DefaultValue = False

            dt.Columns.Add(colAltas)
            dt.Columns.Add(colModificaciones)
            dt.Columns.Add(colBajas)




            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
            Dim Fr As System.Type() = asm.GetTypes
            Barra.Maximum = Fr.Length

            For Each ty As Type In Fr
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1

                End If
                Dim NombreFormulario As Type = asm.GetType(ty.FullName)

                'If NombreFormulario.FullName.Equals("Microsoft.Office.Interop.Outlook.Account") Then
                '    Dim a As String = ""
                'End If

                ' System.IO.File.AppendAllText("c:\temp\MyTest.txt", NombreFormulario.FullName.ToString & vbCrLf)

                If Not NombreFormulario.FullName.StartsWith("Microsoft.") Then


                    If ty.BaseType.Name.ToLower = "frmantenimiento" Then

                        Try

                            Dim f As FrMantenimiento = DirectCast(Activator.CreateInstance(NombreFormulario), FrMantenimiento)

                            Dim fila As DataRow = dt.NewRow()
                            fila("NombreFormulario") = f.Name
                            fila("Formulario") = f.Text
                            dt.Rows.Add(fila)

                        Catch ex As Exception

                            Dim a As String = ""

                        End Try

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


    Private Sub frmAdministracionFormularios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.AllowCellMerge = True


        Dim TextoError As String = ""
        Dim dtFormularios As DataTable = ObtenerFormulariosMantenimiento(TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del menú", "frmAdministracionMenus_Load", TextoError)
            Exit Sub
        End If

        Grid.DataSource = dtFormularios



        If Not IsNothing(GridView1.Columns.ColumnByFieldName("NombreFormulario")) Then GridView1.Columns.ColumnByFieldName("NombreFormulario").Visible = False

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Altas")) Then
            With GridView1.Columns.ColumnByFieldName("Altas")
                .OptionsColumn.AllowEdit = False
                .Width = 30
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            End With
        End If

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Modificaciones")) Then
            With GridView1.Columns.ColumnByFieldName("Modificaciones")
                .OptionsColumn.AllowEdit = False
                .Width = 30
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            End With
        End If

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Bajas")) Then
            With GridView1.Columns.ColumnByFieldName("Bajas")
                .OptionsColumn.AllowEdit = False
                .Width = 30
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            End With
        End If



    End Sub
End Class
