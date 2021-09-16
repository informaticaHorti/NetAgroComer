Public Class E_LogusuariosApl
    Inherits Cdatos.Entidad
    Public Id As Cdatos.bdcampo
    Public Iduser As Cdatos.bdcampo
    Public Fecha As Cdatos.bdcampo
    Public hora As Cdatos.bdcampo
    Public operacion As Cdatos.bdcampo
    Public idaplicacion As Cdatos.bdcampo
    Public tabla As Cdatos.bdcampo
    Public clave As Cdatos.bdcampo
    Public datosregistro As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "LogUsuariosApl"
            MiConexion = conexion
            CampoContador = "idaplicacion"
            NombreBd = "NetAgroComer"

            Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 8, 0, True)
            Iduser = New Cdatos.bdcampo(CodigoEntidad & "iduser", Cdatos.TiposCampo.EnteroPositivo, 3)
            Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            hora = New Cdatos.bdcampo(CodigoEntidad & "hora", Cdatos.TiposCampo.Cadena, 8)
            operacion = New Cdatos.bdcampo(CodigoEntidad & "operacion", Cdatos.TiposCampo.Cadena, 1)
            idaplicacion = New Cdatos.bdcampo(CodigoEntidad & "idaplicacion", Cdatos.TiposCampo.EnteroPositivo, 3)
            tabla = New Cdatos.bdcampo(CodigoEntidad & "tabla", Cdatos.TiposCampo.Cadena, 50)
            clave = New Cdatos.bdcampo(CodigoEntidad & "clave", Cdatos.TiposCampo.Cadena, 50)
            datosregistro = New Cdatos.bdcampo(CodigoEntidad & "datosregistro", Cdatos.TiposCampo.Cadena, 1024)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

End Class
