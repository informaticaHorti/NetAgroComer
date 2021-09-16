Public Class E_RRHH

    Inherits Cdatos.Entidad
    Public IdCentro As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public CuentaCliente As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "horas"
            MiConexion = conexion


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

End Class
