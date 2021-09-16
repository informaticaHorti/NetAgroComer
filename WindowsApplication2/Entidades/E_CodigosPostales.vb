Public Class E_CodigosPostales
    Inherits Cdatos.Entidad
    Public IdCodpostal As Cdatos.bdcampo
    Public Poblacion As Cdatos.bdcampo
    Public Provincia As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CodigosPostales"
            MiConexion = conexion
            IdCodpostal = New Cdatos.bdcampo(CodigoEntidad & "IdCodpostal", Cdatos.TiposCampo.Entero, 5, 0, True)
            Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub
End Class
