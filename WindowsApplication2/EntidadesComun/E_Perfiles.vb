Public Class E_Perfiles
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdPerfil AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public Administrador AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Perfiles"
            NombreBd = "Comun"
			MiConexion = conexion

            IdPerfil = New Cdatos.bdcampo(CodigoEntidad & "IdPerfil", Cdatos.TiposCampo.Entero, 10, , True)
			Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
			Administrador = New Cdatos.bdcampo(CodigoEntidad & "Administrador", Cdatos.TiposCampo.Cadena, 1)

            MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdPerfil,Nombre from Perfiles where idperfil > 0"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdPerfil"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaPerfiles"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function TablaPerfiles() As DataTable

        Dim sql As String = "SELECT IdPerfil AS Id, Nombre FROM Perfiles WHERE IdPerfil > 0 ORDER BY Nombre"

        Try
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            Return dt

        Catch ex As Exception
            Return New DataTable
        End Try

        
    End Function


End Class
