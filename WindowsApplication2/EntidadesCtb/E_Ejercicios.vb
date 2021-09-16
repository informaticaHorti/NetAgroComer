Public Class E_Ejercicios
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdEjercicio AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public FechaDesde AS Cdatos.bdcampo
	Public FechaHasta AS Cdatos.bdcampo
	Public FechaTrabDesde AS Cdatos.bdcampo
    Public FechaTrabHasta As Cdatos.bdcampo
    Public ConexionAlhondiga As Cdatos.bdcampo
    Public FechaApertura As Cdatos.bdcampo
    Public FechaBloqueoIva As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "Ejercicios"
            MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)


            PrefijoContador = ""

            IdEjercicio = New Cdatos.bdcampo(CodigoEntidad & "IdEjercicio", Cdatos.TiposCampo.Entero, 10, 0, True)
			Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
			FechaDesde = New Cdatos.bdcampo(CodigoEntidad & "FechaDesde", Cdatos.TiposCampo.Fecha, 8)
			FechaHasta = New Cdatos.bdcampo(CodigoEntidad & "FechaHasta", Cdatos.TiposCampo.Fecha, 8)
			FechaTrabDesde = New Cdatos.bdcampo(CodigoEntidad & "FechaTrabDesde", Cdatos.TiposCampo.Fecha, 8)
            FechaTrabHasta = New Cdatos.bdcampo(CodigoEntidad & "FechaTrabHasta", Cdatos.TiposCampo.Fecha, 8)
            ConexionAlhondiga = New Cdatos.bdcampo(CodigoEntidad & "ConexionAlhondiga", Cdatos.TiposCampo.Cadena, 512)
            FechaApertura = New Cdatos.bdcampo(CodigoEntidad & "FechaApertura", Cdatos.TiposCampo.Fecha, 8)
            FechaBloqueoIva = New Cdatos.bdcampo(CodigoEntidad & "FechaBloqueoIva", Cdatos.TiposCampo.Fecha, 8)

			MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdEjercicio,Nombre from Ejercicios"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdEjercicio"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaEjercicios"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select Idejercicio, Nombre,FechaDesde,FechaHasta from ejercicios order by idejercicio")
        Return dt
    End Function


End Class
