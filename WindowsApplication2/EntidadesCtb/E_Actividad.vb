Public Class E_Actividad
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdActividad AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Actividad"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdActividad = New Cdatos.bdcampo("IdActividad", Cdatos.TiposCampo.Entero, 10, , True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdActividad,Nombre from Actividad"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdActividad"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaActividades"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdActividad, Nombre from Actividad order by idactividad")
        Return dt
    End Function


End Class
