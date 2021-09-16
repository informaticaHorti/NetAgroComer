Public Class FrTrazaReg

    Dim _nombreEntidad As String

    Dim _id As String
    Dim _Ulog As String
    Dim _Flog As String
    Dim _Hlog As String


    Public Sub initClave(Enti As Cdatos.Entidad, Id As String)

        _nombreEntidad = Enti.NombreTabla
        _id = Id
        Dim clave As String = Enti.ClavePrimaria.NombreCampo
        Dim prefijo As String = ""
        If Len(clave) > 4 Then
            Dim i As Integer = InStr(clave, "_")
            If i > 0 Then
                prefijo = Mid(clave, 1, 4)
            End If
        End If
        _Ulog = Enti.ValorCampoTxt(prefijo + "IdUsuarioLog")
        _Flog = Enti.ValorCampoTxt(prefijo + "FechaLog")
        _Hlog = Enti.ValorCampoTxt(prefijo + "HoraLog")

        CargaDatos()

    End Sub

    Private Sub CargaDatos()


        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True
        Dim sql As String = ""
        Dim Log As New E_LogusuariosApl(Idusuario, cn)
        Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Log.Id, "id")
        consulta.SelCampo(Log.Fecha, "Fecha")
        consulta.SelCampo(Log.hora, "Hora")
        consulta.SelCampo(Log.Iduser, "iduser")
        consulta.SelCampo(Usuarios.Nombre, "Usuario", Log.Iduser)
        consulta.SelCampo(Log.operacion, "BM")
        consulta.SelCampo(Log.datosregistro, "DatosRegistro")
        consulta.WheCampo(Log.idaplicacion, "=", IdAplicacion)
        consulta.WheCampo(Log.tabla, "=", _nombreEntidad)
        consulta.WheCampo(Log.clave, "=", _id)
        sql = consulta.SQL
        Dim dt As DataTable = Log.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        If Usuarios.LeerId(_Ulog) = True Then
            LbUsuario.Text = _Ulog + " " + Usuarios.Nombre.Valor
        Else
            LbUsuario.Text = _Ulog
        End If
        LbFecha.Text = _Flog + "  " + _Hlog

    End Sub


    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim frm As New FrVerLog
        Dim id As String = GridView1.GetRowCellValue(e.RowHandle, "id")
        frm.init(CInt(id))
        frm.ShowDialog()
    End Sub

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub
End Class