Public Class E_EmpresasUsuario
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public Id As Cdatos.bdcampo
    Public IdUsuario As Cdatos.bdcampo
    Public IdEmpresa As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "EmpresasUsuario"
            NombreBd = "Comun"
            MiConexion = conexion

            Me.Id = New Cdatos.bdcampo("Id", Cdatos.TiposCampo.Entero, 10, , True)
            Me.IdUsuario = New Cdatos.bdcampo("IdUsuario", Cdatos.TiposCampo.Entero, 10)
            Me.IdEmpresa = New Cdatos.bdcampo("IdEmpresa", Cdatos.TiposCampo.Entero, 3)

            MiListadeCampos = ListadeCampos()




        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function EmpresasAutorizadas(IdUsuario As String) As DataTable

        Dim NombreEmpresa As New E_NombreEmpresa(IdUsuario, Cncomun)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Me.IdEmpresa, "Id")
        CONSULTA.SelCampo(NombreEmpresa.Nombre, "Nombre", Me.IdEmpresa)
        CONSULTA.WheCampo(Me.IdUsuario, "=", IdUsuario)


        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If IsNothing(dt) Then
            dt = New DataTable
        End If



        Return dt

    End Function


End Class
