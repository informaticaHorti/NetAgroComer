Public Class E_Bajas_AEAT
    Inherits Cdatos.Entidad


    Private err As New Errores


    Public IdRegistro As Cdatos.bdcampo
    Public Tipo As Cdatos.bdcampo
    Public NIF As Cdatos.bdcampo
    Public Emisor As Cdatos.bdcampo
    Public TipoIdentificacion As Cdatos.bdcampo
    Public CodigoPais As Cdatos.bdcampo
    Public SerieDocumento As Cdatos.bdcampo
    Public Documento As Cdatos.bdcampo
    Public FechaFac As Cdatos.bdcampo
    Public FechaHora_AEAT As Cdatos.bdcampo
    



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try


            NombreTabla = "Bajas_AEAT"
            NombreBd = ObtenerBDConexion(conexion)
            MiConexion = conexion


            IdRegistro = New Cdatos.bdcampo("IdRegistro", Cdatos.TiposCampo.Entero, 10, 0, True)
            Tipo = New Cdatos.bdcampo("Tipo", Cdatos.TiposCampo.Cadena, 1)
            NIF = New Cdatos.bdcampo("NIF", Cdatos.TiposCampo.Cadena, 20)
            Emisor = New Cdatos.bdcampo("Emisor", Cdatos.TiposCampo.Cadena, 40)
            TipoIdentificacion = New Cdatos.bdcampo("TipoIdentificacion", Cdatos.TiposCampo.Cadena, 2)
            CodigoPais = New Cdatos.bdcampo("CodigoPais", Cdatos.TiposCampo.Cadena, 2)
            SerieDocumento = New Cdatos.bdcampo("SerieDocumento", Cdatos.TiposCampo.Cadena, 10)
            Documento = New Cdatos.bdcampo("Documento", Cdatos.TiposCampo.Cadena, 20)
            FechaFac = New Cdatos.bdcampo("FechaFac", Cdatos.TiposCampo.Fecha, 8)
            FechaHora_AEAT = New Cdatos.bdcampo("FechaHora_AEAT", Cdatos.TiposCampo.Cadena, 14)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub





End Class
