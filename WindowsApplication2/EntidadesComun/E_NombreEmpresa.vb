Public Class E_NombreEmpresa
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdEmpresa As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "NombreEmpresa"
            NombreBd = "Comun"
            MiConexion = conexion

            IdEmpresa = New Cdatos.bdcampo("IdEmpresa", Cdatos.TiposCampo.Entero, 3, , True)
            Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
 
            MiListadeCampos = ListadeCampos()


         

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function Tabla() As DataTable
        Dim sql As String = "Select IdEmpresa as id,Nombre from nombreempresa order by idempresa"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        Return dt

    End Function


End Class
