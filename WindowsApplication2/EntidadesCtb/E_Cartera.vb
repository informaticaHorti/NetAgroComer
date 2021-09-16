Public Class E_Cartera
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdRegistro As Cdatos.bdcampo
    Public PagoCobro As Cdatos.bdcampo
    Public Cuenta As Cdatos.bdcampo
    Public CuentaCartera As Cdatos.bdcampo
    Public FechaDocumento As Cdatos.bdcampo
    Public NumeroDocumento As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Cartera"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion
            PrefijoContador = ""


            IdRegistro = New Cdatos.bdcampo("IdRegistro", Cdatos.TiposCampo.Entero, 10, 0, True)
            PagoCobro = New Cdatos.bdcampo("PagoCobro", Cdatos.TiposCampo.Cadena, 1)
            Cuenta = New Cdatos.bdcampo("Cuenta", Cdatos.TiposCampo.Cuenta, 15)
            CuentaCartera = New Cdatos.bdcampo("CuentaCartera", Cdatos.TiposCampo.Cuenta, 15)
            FechaDocumento = New Cdatos.bdcampo("FechaDocumento", Cdatos.TiposCampo.Fecha, 10)
            NumeroDocumento = New Cdatos.bdcampo("NumeroDocumento", Cdatos.TiposCampo.Cadena, 15)


            MiListadeCampos = ListadeCampos()



        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    



    Private Sub E_Cartera_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from cartera_lineas where idregistro=" + Me.IdRegistro.Valor
        Me.MiConexion.OrdenSql(sql)

    End Sub
End Class
