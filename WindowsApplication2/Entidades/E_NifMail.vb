Public Class E_NifMail
    Inherits Cdatos.Entidad
    Public IdMail As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public PersonaContacto As Cdatos.bdcampo
    Public Mail As Cdatos.bdcampo
    Public Cargo As Cdatos.bdcampo
    Public idproceso As Cdatos.bdcampo
    Public iddelegacion As Cdatos.bdcampo
    Public Nif As Cdatos.bdcampo
    Public Movil As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "MailNif"
            MiConexion = conexion
            NombreBd = "Comun"

            IdMail = New Cdatos.bdcampo(CodigoEntidad & "IdMail", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15, 0)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            PersonaContacto = New Cdatos.bdcampo(CodigoEntidad & "PersonaContacto", Cdatos.TiposCampo.Cadena, 50, 0)
            Mail = New Cdatos.bdcampo(CodigoEntidad & "EMail", Cdatos.TiposCampo.Cadena, 150)
            Cargo = New Cdatos.bdcampo(CodigoEntidad & "Cargo", Cdatos.TiposCampo.Cadena, 50)
            idproceso = New Cdatos.bdcampo(CodigoEntidad & "IdProceso", Cdatos.TiposCampo.EnteroPositivo, 2)
            iddelegacion = New Cdatos.bdcampo(CodigoEntidad & "iddelegacion", Cdatos.TiposCampo.EnteroPositivo, 5)
            Movil = New Cdatos.bdcampo(CodigoEntidad & "Movil", Cdatos.TiposCampo.Cadena, 15)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub



End Class
