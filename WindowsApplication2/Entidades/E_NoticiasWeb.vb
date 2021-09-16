Public Class E_NoticiasWeb
    Inherits Cdatos.Entidad

    Public NWB_Id As Cdatos.bdcampo
    Public NWB_Fecha As Cdatos.bdcampo
    Public NWB_Titular As Cdatos.bdcampo
    Public NWB_Adjunto As Cdatos.bdcampo
    Public NWB_Noticia As Cdatos.bdcampo

    Public NWB_IdUsuarioLog As Cdatos.bdcampo
    Public NWB_FechaLog As Cdatos.bdcampo
    Public NWB_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "NoticiasWeb"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            NWB_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            NWB_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 8)
            NWB_Titular = New Cdatos.bdcampo(CodigoEntidad & "Titular", Cdatos.TiposCampo.Cadena, 512)
            NWB_Adjunto = New Cdatos.bdcampo(CodigoEntidad & "Adjunto", Cdatos.TiposCampo.Cadena, 512)
            NWB_Noticia = New Cdatos.bdcampo(CodigoEntidad & "Noticia", Cdatos.TiposCampo.Cadena, 1000)

            NWB_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            NWB_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            NWB_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Fecha DESC"
        _btBusca.CL_ConsultaSql = "Select NWB_Id as Id, NWB_Fecha as Fecha, NWB_Titular as Titular FROM NoticiasWeb"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaNoticiasWeb"
        _btBusca.CL_ch1000 = False


    End Sub

End Class
