Public Class E_NifDelegaciones
    Inherits Cdatos.Entidad
    Public IdDelegacion As Cdatos.bdcampo
    Public Nif As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Domicilio As Cdatos.bdcampo
    Public Poblacion As Cdatos.bdcampo
    Public Provincia As Cdatos.bdcampo
    Public Cpostal As Cdatos.bdcampo
    Public IdPais As Cdatos.bdcampo
    Public Telefono1 As Cdatos.bdcampo
    Public Telefono2 As Cdatos.bdcampo
    Public Fax As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Delegaciones"
            MiConexion = conexion
            IdDelegacion = New Cdatos.bdcampo(CodigoEntidad & "IdDelegacion", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15, 0)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 150, 0)
            Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            Cpostal = New Cdatos.bdcampo(CodigoEntidad & "Cpostal", Cdatos.TiposCampo.CadenaNumero, 7)
            IdPais = New Cdatos.bdcampo(CodigoEntidad & "idpais", Cdatos.TiposCampo.EnteroPositivo, 3)
            Telefono1 = New Cdatos.bdcampo(CodigoEntidad & "Telefono1", Cdatos.TiposCampo.Cadena, 15)
            Telefono2 = New Cdatos.bdcampo(CodigoEntidad & "Telefono2", Cdatos.TiposCampo.Cadena, 15)
            Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 15)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
