Public Class E_SubDepartamentos
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdSubDepartamento AS Cdatos.bdcampo
	Public IdDepartamento AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "SubDepartamentos"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdSubDepartamento = New Cdatos.bdcampo("IdSubDepartamento", Cdatos.TiposCampo.Entero, 10, , True)
			IdDepartamento = New Cdatos.bdcampo("IdDepartamento", Cdatos.TiposCampo.Entero, 10)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdSubDepartamento,Nombre from Subdepartamentos"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdSubDepartamento"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaSubDepartamentos"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdSubDepartamento, Nombre from Subdepartamentos order by idsubdepartamento")
        Return dt
    End Function

End Class
