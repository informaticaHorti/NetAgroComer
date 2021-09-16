Imports DevExpress.XtraEditors
Imports SharpSsh





Public Class FrMMensajesEntidad

    Dim _entidad As String = ""
    Dim _identidad As String = ""
    Dim _referencia As String = ""
    Dim MensajesEntidades As New E_mensajesentidades(Idusuario, cn)
    Dim usuarios As New E_Usuarios(Idusuario, CnComun)
    Dim Valoresusuarios As New E_valoresusuario(Idusuario, cn)
    Dim Gruposmensajes As New E_GruposMensajes(Idusuario, cn)

    Dim err As New Errores()

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub Init(ByVal NombreEntidad As String, ByVal IdEntidad As String, ReferenciaEntidad As String)



        _entidad = NombreEntidad
        _identidad = IdEntidad
        _referencia = ReferenciaEntidad


        'Muestra el nif y los documentos asociados
        Me.Refresh()

        'Muestra el documento seleccionado (si existe)
        CargaChGrupo()
        CargaMensajes()

    End Sub

    Private Sub CargaMensajes()
        Dim sql As String = ""

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(MensajesEntidades.PMJ_id, "id")
        consulta.SelCampo(MensajesEntidades.PMJ_fecha, "Fecha")
        consulta.SelCampo(MensajesEntidades.PMJ_hora, "Hora")
        consulta.SelCampo(MensajesEntidades.PMJ_mensaje, "Mensaje")
        consulta.SelCampo(usuarios.Nombre, "De", MensajesEntidades.PMJ_idusuarioDe)
        consulta.SelCampo(usuarios.Nombre, "Para")
        ' Dim Usuariopara As New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50, 0, False, usuarios, , , "Usuariopara", "NombrePara")
        ' consulta.SelCampo(Usuariopara, "Para", MensajesEntidades.PMJ_idusuarioPara)
        consulta.SelCampo(usuarios.Nombre, "LeidoPor")
        consulta.SelCampo(MensajesEntidades.PMJ_fechaleido, "FechaL")
        consulta.SelCampo(MensajesEntidades.PMJ_horaleido, "HoraL")
        consulta.SelCampo(MensajesEntidades.PMJ_idusuarioPara, "idusuariopara")
        consulta.SelCampo(MensajesEntidades.PMJ_idusuarioLeido, "idusuarioleido")

        consulta.WheCampo(MensajesEntidades.PMJ_entidad, "=", _entidad)
        consulta.WheCampo(MensajesEntidades.PMJ_identidad, "=", _identidad)
        If RbLeidosSI.Checked = True Then
            consulta.WheCampo(MensajesEntidades.PMJ_idusuarioLeido, "<>", "0")

        End If
        If RbLeidosNO.Checked = True Then
            consulta.WheCampo(MensajesEntidades.PMJ_idusuarioLeido, "=", "0")

        End If

        If RbEnviados.Checked = True Then
            consulta.WheCampo(MensajesEntidades.PMJ_idusuarioDe, "=", Idusuario.ToString)
        End If

        If RbRecibidos.Checked = True Then
            consulta.WheCampo(MensajesEntidades.PMJ_idusuarioPara, "=", Idusuario.ToString)
        End If
        sql = consulta.SQL
        Dim dt As DataTable = MensajesEntidades.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add(New DataColumn("LEIDO", GetType(Boolean)))

        If dt.Columns.Contains("LEIDO") Then
            dt.Columns("LEIDO").SetOrdinal(6)
        End If

        For Each RW In dt.Rows
            If usuarios.LeerId(RW("idusuariopara").ToString) = True Then
                RW("para") = usuarios.Nombre.Valor
            End If
            If VaInt(RW("idusuarioleido")) > 0 Then
                RW("LEIDO") = True
                If usuarios.LeerId(RW("idusuarioleido").ToString) = True Then
                    RW("LeidoPor") = usuarios.Nombre.Valor
                End If
            Else
                RW("LEIDO") = False
                RW("LEIDOPOR") = ""
            End If
        Next
        Grid.DataSource = dt

        AjustaColumnas()

    End Sub
    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click

        Me.Close()
    End Sub

    Private Sub AjustaColumnas()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "FECHA", "HORA", "FECHAL", "HORAL", "LEIDO"
                    c.Width = 60

                Case "DE", "PARA", "LEIDOPOR"
                    c.Width = 100


                Case "MENSAJE"
                    c.Width = 200

                Case Else
                    c.Visible = False
            End Select
        Next
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False

    End Sub

    Protected Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)



        Select Case row("LEIDO")
            Case True
                e.Appearance.BackColor = Color.LightGreen
         
        End Select



       
    End Sub

    Private Sub EnviarMensaje(Mensaje As String)

        Dim n As Integer
        For indice As Integer = 0 To ChUsuarios.ItemCount - 1

            If ChUsuarios.GetItemChecked(indice) = True Then

                Dim row As DataRowView = ChUsuarios.GetItem(indice)
                Dim a As String = row("Codigo").ToString


                Dim id As String
                id = MensajesEntidades.MaxId
                MensajesEntidades.PMJ_id.Valor = id
                MensajesEntidades.PMJ_entidad.Valor = _entidad
                MensajesEntidades.PMJ_identidad.Valor = _identidad
                MensajesEntidades.PMJ_fecha.Valor = Format(Now, "dd/MM/yyyy")
                MensajesEntidades.PMJ_hora.Valor = Format(Now, "hh:mm")
                MensajesEntidades.PMJ_idusuarioDe.Valor = Idusuario.ToString
                MensajesEntidades.PMJ_idusuarioPara.Valor = a
                MensajesEntidades.PMJ_mensaje.Valor = Mensaje
                MensajesEntidades.PMJ_fechaleido.Valor = ""
                MensajesEntidades.PMJ_horaleido.Valor = ""
                MensajesEntidades.PMJ_idusuarioLeido.Valor = "0"
                MensajesEntidades.PMJ_Referencia.Valor = _referencia
                MensajesEntidades.Insertar()
                n = n + 1

            End If
        Next
        MsgBox("Se enviaron " & Str(n) & " mensajes")
        If n > 0 Then
            TxMensaje.Text = ""
            CargaMensajes()
        End If

    End Sub

    Private Sub CargaChGrupo()

        Dim dt As New DataTable
        Dim sql As String
        Dim GruposMensajes As New E_GruposMensajes(Idusuario, cn)
        Dim Usuarios As New E_Usuarios(Idusuario, cn)
        Dim DatosUsuario As New E_DatosUsuario(Idusuario, cn)


        Dim Consulta2 As New Cdatos.E_select

        Consulta2.SelCampo(Usuarios.IdUsuario, "Codigo")
        Consulta2.SelCampo(Usuarios.Nombre, "Nombre")
        Consulta2.SelCampo(Valoresusuarios.VUS_idgrupomensajes, "idgrupo", Usuarios.IdUsuario)
        Consulta2.WheCampo(Valoresusuarios.VUS_idgrupomensajes, ">", 0)
        sql = Consulta2.SQL + " order by VUS_idgrupomensajes"
        dt = Usuarios.MiConexion.ConsultaSQL(sql)

        ChUsuarios.DataSource = dt
        ChUsuarios.ValueMember = "Codigo"
        ChUsuarios.DisplayMember = "Nombre"


        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(GruposMensajes.GRM_Id, "Codigo")
        consulta.SelCampo(GruposMensajes.GRM_Nombre, "Nombre")
        sql = consulta.SQL + " order by GRM_id"
        dt = GruposMensajes.MiConexion.ConsultaSQL(sql)

        ChGrupos.DataSource = dt
        ChGrupos.ValueMember = "Codigo"
        ChGrupos.DisplayMember = "Nombre"


    End Sub

    Private Sub ChGrupos_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles ChGrupos.ItemCheck
        Dim v As Boolean
        If e.State = CheckState.Checked Then
            v = True
        Else
            v = False
        End If
        Dim C As String = ChGrupos.GetItemValue(e.Index)
        MarcaUusuario(C, v)
    End Sub

    Private Sub MarcaUusuario(Idgrupo As String, v As Boolean)


        For indice As Integer = 0 To ChUsuarios.ItemCount - 1

            '   If ChOrigen.GetItemChecked(indice) = True Then
            ' MsgBox("Checked: " & row("Nombre").ToString)
            ' End If

            Dim row As DataRowView = ChUsuarios.GetItem(indice)
            Dim a As String = row("Codigo").ToString
            If Valoresusuarios.LeerId(a) = True Then
                If VaInt(Valoresusuarios.VUS_idgrupomensajes.Valor) = VaInt(Idgrupo) Then
                    ChUsuarios.SetItemChecked(indice, v)
                End If
            End If
        Next
    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click
        If TxMensaje.Text <> "" Then
            EnviarMensaje(TxMensaje.Text)
        End If
    End Sub

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RbRecibidos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbRecibidos.CheckedChanged
        CargaMensajes()
    End Sub

    Private Sub RbEnviados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbEnviados.CheckedChanged
        CargaMensajes()
    End Sub

    Private Sub RbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbTodos.CheckedChanged
        CargaMensajes()
    End Sub

    Private Sub RbLeidosTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbLeidosTodos.CheckedChanged
        CargaMensajes()

    End Sub

    Private Sub RbLeidosSI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbLeidosSI.CheckedChanged
        CargaMensajes()
    End Sub

    Private Sub RbLeidosNO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbLeidosNO.CheckedChanged
        CargaMensajes()
    End Sub

    
    Private Sub Grid_Click_2(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub
    Private Sub Grid_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If FnLeft(e.DisplayText, 10) = "01/01/1900" Then
            e.DisplayText = ""
        End If
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Column.FieldName.ToUpper = "LEIDO" Then
            If e.CellValue = True Then
                GridView1.SetRowCellValue(e.RowHandle, e.Column, False)
            Else
                GridView1.SetRowCellValue(e.RowHandle, e.Column, True)

            End If
            Dim idlinea As String
            Dim rw As DataRow
            rw = GridView1.GetDataRow(e.RowHandle)
            idlinea = rw("id")
            MarcaLinea(idlinea, e.CellValue)
        End If
    End Sub

    Private Sub MarcaLinea(idmensaje As String, V As Boolean)

        If MensajesEntidades.LeerId(idmensaje) = True Then
            If V = True Then
                MensajesEntidades.PMJ_idusuarioLeido.Valor = Idusuario.ToString
                MensajesEntidades.PMJ_fechaleido.Valor = Format(Now, "dd/MM/yyyy")
                MensajesEntidades.PMJ_horaleido.Valor = Format(Now, "hh:mm")
            Else
                MensajesEntidades.PMJ_idusuarioLeido.Valor = "0"
                MensajesEntidades.PMJ_fechaleido.Valor = ""
                MensajesEntidades.PMJ_horaleido.Valor = ""
            End If

            MensajesEntidades.Actualizar()
        End If

    End Sub

    Private Sub TxMensaje_GotFocus(sender As Object, e As System.EventArgs) Handles TxMensaje.GotFocus
        TxMensaje.BackColor = Color.Yellow
    End Sub

    Private Sub TxMensaje_LostFocus(sender As Object, e As System.EventArgs) Handles TxMensaje.LostFocus
        TxMensaje.BackColor = Color.White
    End Sub

    Private Sub TxMensaje_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxMensaje.TextChanged

    End Sub

    Private Sub ClButton2_Click(sender As System.Object, e As System.EventArgs) Handles ClButton2.Click
        CargaMensajes()
    End Sub
End Class