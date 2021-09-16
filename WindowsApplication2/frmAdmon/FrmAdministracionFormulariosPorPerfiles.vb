Public Class FrmAdministracionFormulariosPorPerfiles

    Private Enum TipoMarca
        Altas
        Bajas
        Modificaciones
        Todas
    End Enum


    Private err As New Errores()
    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Private Perfiles As New E_Perfiles(Idusuario, CnComun)
    Private LogFormularios As New E_LogFormularios(Idusuario, cn)

    Private bCargado As Boolean = False



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmAdministracionMenusPorPerfiles_Load(sender As Object, e As System.EventArgs) Handles Me.Load


    End Sub


    Private Sub CargaGrid()

        Dim formulario As String = CbFormularios.SelectedValue
        If Not IsNothing(formulario) Then

            Dim dt As DataTable = Perfiles.TablaPerfiles

            Dim ColAltas As New DataColumn("Altas", GetType(Boolean))
            ColAltas.DefaultValue = False
            dt.Columns.Add(ColAltas)

            Dim ColModif As New DataColumn("Modificaciones", GetType(Boolean))
            ColModif.DefaultValue = False
            dt.Columns.Add(ColModif)

            Dim ColBajas As New DataColumn("Bajas", GetType(Boolean))
            ColBajas.DefaultValue = False
            dt.Columns.Add(ColBajas)



            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(LogFormularios.LOF_Permisos, "Permisos")
            CONSULTA.SelCampo(LogFormularios.LOF_IdPerfil, "IdPerfil")
            CONSULTA.WheCampo(LogFormularios.LOF_NombreFormulario, "=", formulario.ToLower.Trim)
            Dim sql As String = CONSULTA.SQL

            Dim dtPermisos As DataTable = LogFormularios.MiConexion.ConsultaSQL(sql)
            Dim DcPermisos As New Dictionary(Of Integer, String)

            For Each row As DataRow In dtPermisos.Rows
                Dim IdPerfil As Integer = VaInt(row("IdPerfil"))
                Dim Permisos As String = (row("Permisos").ToString & "").Trim.ToUpper
                DcPermisos(IdPerfil) = Permisos
            Next


            For Each row As DataRow In dt.Rows
                Dim IdPerfil As Integer = VaInt(row("Id"))
                If DcPermisos.ContainsKey(IdPerfil) Then

                    Dim Permisos As String = DcPermisos(IdPerfil)
                    If Permisos.Contains("A") Then row("Altas") = True
                    If Permisos.Contains("M") Then row("Modificaciones") = True
                    If Permisos.Contains("B") Then row("Bajas") = True

                End If
            Next


            Grid.DataSource = dt
            AjustaColumnas()

        End If

    End Sub



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID"
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ALTAS", "BAJAS"
                    c.MinWidth = 55
                    c.MaxWidth = 55
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "MODIFICACIONES"
                    c.Caption = "Modif."
                    c.MinWidth = 55
                    c.MaxWidth = 55
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End Select
        Next



    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click
        ActualizaPermisos()
    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub CbFormularios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbFormularios.SelectedIndexChanged

        If bCargado Then
            CargaGrid()
        End If

    End Sub


    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim NombreColumna As String = e.Column.FieldName.Trim.ToUpper

        If NombreColumna = "ALTAS" Or NombreColumna = "MODIFICACIONES" Or NombreColumna = "BAJAS" Then
            Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not IsNothing(row) Then

                If row(NombreColumna) = True Then
                    row(NombreColumna) = False
                Else
                    row(NombreColumna) = True
                End If

            End If
        End If

    End Sub


    Private Sub ActualizaPermisos()

        Dim NombreFormulario As String = CbFormularios.SelectedValue & ""

        If NombreFormulario.Trim <> "" Then

            Dim sql As String = "DELETE FROM LogFormularios WHERE LOF_NombreFormulario = '" & NombreFormulario & "'"
            LogFormularios.MiConexion.ConsultaSQL(sql)

            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim Permisos As String = ""
                    If row("Altas") = True Then Permisos = "A"
                    If row("Modificaciones") = True Then Permisos = Permisos & "M"
                    If row("Bajas") = True Then Permisos = Permisos & "B"

                    If Permisos <> "" Then

                        Dim IdPerfil As String = VaInt(row("Id")).ToString
                        Dim LogFormularios As New E_LogFormularios(Idusuario, cn)
                        LogFormularios.LOF_Id.Valor = LogFormularios.MaxId()
                        LogFormularios.LOF_NombreFormulario.Valor = NombreFormulario
                        LogFormularios.LOF_IdPerfil.Valor = IdPerfil
                        LogFormularios.LOF_Permisos.Valor = Permisos
                        LogFormularios.Insertar()

                    End If
                End If
            Next


        End If

        MsgBox("Cambios guardados!")

    End Sub


    Private Sub MarcarColumna(Tipo As TipoMarca, valor As Boolean)

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                Select Case Tipo

                    Case TipoMarca.Altas
                        row("Altas") = valor
                    Case TipoMarca.Modificaciones
                        row("Modificaciones") = valor
                    Case TipoMarca.Bajas
                        row("Bajas") = valor
                    Case TipoMarca.Todas
                        row("Altas") = valor
                        row("Modificaciones") = valor
                        row("Bajas") = valor

                End Select

            End If
        Next


    End Sub


    Private Sub ChkAltas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkAltas.CheckedChanged
        MarcarColumna(TipoMarca.Altas, ChkAltas.Checked)
    End Sub

    Private Sub ChkModificaciones_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkModificaciones.CheckedChanged
        MarcarColumna(TipoMarca.Modificaciones, ChkModificaciones.Checked)
    End Sub

    Private Sub ChkBajas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkBajas.CheckedChanged
        MarcarColumna(TipoMarca.Bajas, ChkBajas.Checked)
    End Sub

    Private Sub ChkTodas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkTodas.CheckedChanged
        MarcarColumna(TipoMarca.Todas, ChkTodas.Checked)
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

    Private Sub FrmAdministracionFormulariosPorPerfiles_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False

        Dim TextoError As String = ""
        Dim dtBotones As DataTable = ObtenerFormulariosMantenimiento(TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del menú", "FrmAdministracionFormulariosPorPerfiles_Load", TextoError)
            Exit Sub
        End If


        CbFormularios.DataSource = dtBotones
        CbFormularios.DisplayMember = "Formulario"
        CbFormularios.ValueMember = "NombreFormulario"


        CargaGrid()

        bCargado = True


    End Sub
End Class