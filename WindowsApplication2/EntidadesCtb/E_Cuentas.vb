Public Class E_Cuentas
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public NumeroCuenta AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public Nif AS Cdatos.bdcampo
	Public CtaContraPartidaGasto AS Cdatos.bdcampo
	Public IdIvaSoportado AS Cdatos.bdcampo
	Public ClaveIrpf AS Cdatos.bdcampo
	Public RegimenInterno AS Cdatos.bdcampo
	Public IdIvaRepercutido AS Cdatos.bdcampo
	Public Poblacion AS Cdatos.bdcampo
	Public Provincia AS Cdatos.bdcampo
	Public IdPais AS Cdatos.bdcampo
	Public Domicilio AS Cdatos.bdcampo
	Public CodPostal AS Cdatos.bdcampo
	Public PorcenIrpf AS Cdatos.bdcampo
	Public CuentaBancaria AS Cdatos.bdcampo
	Public Interna AS Cdatos.bdcampo
	Public IdFPago AS Cdatos.bdcampo
	Public IdBanco AS Cdatos.bdcampo
	Public CtaEfecto AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "Cuentas"
			MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)


            PrefijoContador = ""

            NumeroCuenta = New Cdatos.bdcampo("NumeroCuenta", Cdatos.TiposCampo.Cuenta, 15, 0, True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
			Nif = New Cdatos.bdcampo("Nif", Cdatos.TiposCampo.Cadena, 15)
            CtaContraPartidaGasto = New Cdatos.bdcampo("CtaContraPartidaGasto", Cdatos.TiposCampo.Cuenta, 15)
			IdIvaSoportado = New Cdatos.bdcampo("IdIvaSoportado", Cdatos.TiposCampo.Entero, 10)
			ClaveIrpf = New Cdatos.bdcampo("ClaveIrpf", Cdatos.TiposCampo.Cadena, 15)
			RegimenInterno = New Cdatos.bdcampo("RegimenInterno", Cdatos.TiposCampo.Cadena, 1)
			IdIvaRepercutido = New Cdatos.bdcampo("IdIvaRepercutido", Cdatos.TiposCampo.Entero, 10)
			Poblacion = New Cdatos.bdcampo("Poblacion", Cdatos.TiposCampo.Cadena, 50)
			Provincia = New Cdatos.bdcampo("Provincia", Cdatos.TiposCampo.Cadena, 50)
			IdPais = New Cdatos.bdcampo("IdPais", Cdatos.TiposCampo.Entero, 10)
			Domicilio = New Cdatos.bdcampo("Domicilio", Cdatos.TiposCampo.Cadena, 50)
			CodPostal = New Cdatos.bdcampo("CodPostal", Cdatos.TiposCampo.Cadena, 7)
			PorcenIrpf = New Cdatos.bdcampo("PorcenIrpf", Cdatos.TiposCampo.Importe, 19, 2)
            CuentaBancaria = New Cdatos.bdcampo("CuentaBancaria", Cdatos.TiposCampo.Cadena, 20)
			Interna = New Cdatos.bdcampo("Interna", Cdatos.TiposCampo.Cadena, 1)
			IdFPago = New Cdatos.bdcampo("IdFPago", Cdatos.TiposCampo.Entero, 10)
			IdBanco = New Cdatos.bdcampo("IdBanco", Cdatos.TiposCampo.Entero, 10)
            CtaEfecto = New Cdatos.bdcampo("CtaEfecto", Cdatos.TiposCampo.Cuenta, 15)

			MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select NumeroCuenta,nombre,nif from Cuentas"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "numerocuenta"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscacuenta"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
