Public Class E_PventaUsuario
    Inherits Cdatos.Entidad

    Public PVU_Id As Cdatos.bdcampo
    Public PVU_IdUsuario As Cdatos.bdcampo
    Public PVU_Idpventa As Cdatos.bdcampo
    Public PVU_IdUsuarioLog As Cdatos.bdcampo
    Public PVU_FechaLog As Cdatos.bdcampo
    Public PVU_HoraLog As Cdatos.bdcampo

    Dim err As Errores





    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "PventaUsuario"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PVU_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PVU_IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "Idusuario", Cdatos.TiposCampo.EnteroPositivo, 4)
            PVU_Idpventa = New Cdatos.bdcampo(CodigoEntidad & "IdPventa", Cdatos.TiposCampo.EnteroPositivo, 4)

            PVU_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PVU_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PVU_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

       

    End Sub


    Public Function LeerUsuario_Pventa(ByVal idusuario As String, ByVal idpventa As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select PVU_Id as Id from Pventausuario where PVU_Idusuario=" + idusuario + " and PVU_Idpventa=" + idpventa
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function

    Public Function CentrosPermitidos(ByVal idusuario As String, nctb As Integer) As DataTable
        Dim ret As New DataTable
        ' obtengo un datatable con los centros permitidos en funcion de los punto de venta por usuario.
        Dim Dc As New Dictionary(Of Integer, String)

        Dim puntoventa As New E_PuntoVenta(idusuario, ConexCtb(nctb))
        Dim centros As New E_centros(idusuario, ConexCtb(nctb))
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Me.PVU_Idpventa, "IdPuntoventa")
        Consulta.SelCampo(puntoventa.IdCentro, "idcentro", Me.PVU_Idpventa)
        Consulta.SelCampo(centros.Nombre, "Nombre", puntoventa.IdCentro)

        Consulta.WheCampo(Me.PVU_IdUsuario, "=", idusuario)
        Dim sql As String = Consulta.SQL + " order by Idcentro"
        ret = Me.MiConexion.ConsultaSQL(sql)

        For Each rw In ret.Rows
            If Dc.ContainsKey(VaInt(rw("idcentro"))) = False Then
                Dc.Add(VaInt(rw("idcentro")), rw("nombre").ToString)
            End If
        Next
        Dim DT As New DataTable
        Dim idcentro As New DataColumn("IdCentro", GetType(Integer))
        DT.Columns.Add(idcentro)

        Dim Nombre As New DataColumn("Nombre", GetType(String))
        DT.Columns.Add(Nombre)

        For Each id In Dc.Keys
            DT.Rows.Add(id, Dc(id))
        Next

        Return DT

    End Function

    Public Function Tabla(ByVal idusuario As String, nctb As Integer) As DataTable
        Dim ret As New DataTable


        Dim puntoventa As New E_PuntoVenta(idusuario, ConexCtb(nctb))
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Me.PVU_Idpventa, "IdPuntoventa")
        Consulta.SelCampo(puntoventa.Nombre, "Nombre", Me.PVU_Idpventa)
        Consulta.WheCampo(Me.PVU_IdUsuario, "=", idusuario)
        Dim sql As String = Consulta.SQL + " order by IdPuntoventa"
        ret = Me.MiConexion.ConsultaSQL(sql)


        Return ret


    End Function


    Public Function FiltroPventaBd(Campo As Cdatos.bdcampo, Prefijo As String)
        Dim ret As String

        Dim ListaPventa As New List(Of String)
        Dim dt As DataTable = Me.Tabla(Idusuario, MiMaletin.IdEmpresaCTB)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ListaPventa.Add(rw("idpuntoventa").ToString)
            Next
        End If
        ret = CadenaWhereLista(Campo, ListaPventa, Prefijo)
        Return ret

    End Function

    Public Function FiltroPventaGrid(NombreCampo As String, Prefijo As String)
        Dim ret As String
        Dim Campo As New Cdatos.bdcampo(NombreCampo, Cdatos.TiposCampo.EnteroPositivo, 10)
        Dim ListaPventa As New List(Of String)
        Dim dt As DataTable = Me.Tabla(Idusuario, MiMaletin.IdEmpresaCTB)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ListaPventa.Add(rw("idpuntoventa").ToString)
            Next
        End If
        ret = CadenaWhereLista(Campo, ListaPventa, Prefijo)
        Return ret

    End Function

End Class
