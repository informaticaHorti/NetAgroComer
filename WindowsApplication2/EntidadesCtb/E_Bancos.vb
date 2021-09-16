Public Class E_Bancos
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdBanco AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public Numerocuenta AS Cdatos.bdcampo
	Public CuentaTesoreria AS Cdatos.bdcampo
	Public RiesgoEfectos AS Cdatos.bdcampo
	Public nif AS Cdatos.bdcampo
	Public Domicilio AS Cdatos.bdcampo
	Public Poblacion AS Cdatos.bdcampo
	Public Provincia AS Cdatos.bdcampo
	Public CtaTotalIntereses AS Cdatos.bdcampo
	Public CtaBancoAlhondi AS Cdatos.bdcampo
	Public BancoAlhondi AS Cdatos.bdcampo
    Public _MadurarEfectos As Cdatos.bdcampo
    Public BIC As Cdatos.bdcampo
    Public IBAN As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Bancos"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdBanco = New Cdatos.bdcampo("IdBanco", Cdatos.TiposCampo.Entero, 10, 0, True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
			Numerocuenta = New Cdatos.bdcampo("Numerocuenta", Cdatos.TiposCampo.Cadena, 20)
			CuentaTesoreria = New Cdatos.bdcampo("CuentaTesoreria", Cdatos.TiposCampo.Cadena, 15)
			RiesgoEfectos = New Cdatos.bdcampo("RiesgoEfectos", Cdatos.TiposCampo.Cadena, 15)
			nif = New Cdatos.bdcampo("nif", Cdatos.TiposCampo.Cadena, 15)
			Domicilio = New Cdatos.bdcampo("Domicilio", Cdatos.TiposCampo.Cadena, 50)
			Poblacion = New Cdatos.bdcampo("Poblacion", Cdatos.TiposCampo.Cadena, 50)
			Provincia = New Cdatos.bdcampo("Provincia", Cdatos.TiposCampo.Cadena, 50)
			CtaTotalIntereses = New Cdatos.bdcampo("CtaTotalIntereses", Cdatos.TiposCampo.Cadena, 50)
			CtaBancoAlhondi = New Cdatos.bdcampo("CtaBancoAlhondi", Cdatos.TiposCampo.Cadena, 15)
			BancoAlhondi = New Cdatos.bdcampo("BancoAlhondi", Cdatos.TiposCampo.Cadena, 1)
            _MadurarEfectos = New Cdatos.bdcampo("_MadurarEfectos", Cdatos.TiposCampo.Cadena, 1)
            BIC = New Cdatos.bdcampo("BIC", Cdatos.TiposCampo.Cadena, 50)
            IBAN = New Cdatos.bdcampo("IBAN", Cdatos.TiposCampo.Cadena, 50)

			MiListadeCampos = ListadeCampos()


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Me.IdBanco)
            CONSULTA.SelCampo(Me.Nombre)
            CONSULTA.SelCampo(Me.Numerocuenta)
            Dim Sql As String = CONSULTA.SQL

            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = CONSULTA.SQL + " order by nombre"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdBanco"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaBancos"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
