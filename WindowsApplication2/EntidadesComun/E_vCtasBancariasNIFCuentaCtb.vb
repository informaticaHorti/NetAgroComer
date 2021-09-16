Public Class E_vCtasBancariasNIFCuentaCtb
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public NIF AS Cdatos.bdcampo
	Public CuentaCtb AS Cdatos.bdcampo
	Public CCC AS Cdatos.bdcampo
	Public IdCuenta AS Cdatos.bdcampo
	Public IdOficina AS Cdatos.bdcampo
	Public IdEntidad AS Cdatos.bdcampo
	Public NumeroBanco AS Cdatos.bdcampo
	Public NumeroOficina AS Cdatos.bdcampo
	Public DC AS Cdatos.bdcampo
	Public NumeroCuenta AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "vCtasBancariasNIFCuentaCtb"
            MiConexion = conexion
            NombreBd = "Comun"

			NIF = New Cdatos.bdcampo(CodigoEntidad & "NIF", Cdatos.TiposCampo.Cadena, 15)
			CuentaCtb = New Cdatos.bdcampo(CodigoEntidad & "CuentaCtb", Cdatos.TiposCampo.Cadena, 15)
			CCC = New Cdatos.bdcampo(CodigoEntidad & "CCC", Cdatos.TiposCampo.Cadena, 23)
			IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "IdCuenta", Cdatos.TiposCampo.Entero, 10)
			IdOficina = New Cdatos.bdcampo(CodigoEntidad & "IdOficina", Cdatos.TiposCampo.Entero, 10)
			IdEntidad = New Cdatos.bdcampo(CodigoEntidad & "IdEntidad", Cdatos.TiposCampo.Entero, 10)
			NumeroBanco = New Cdatos.bdcampo(CodigoEntidad & "NumeroBanco", Cdatos.TiposCampo.Cadena, 4)
			NumeroOficina = New Cdatos.bdcampo(CodigoEntidad & "NumeroOficina", Cdatos.TiposCampo.Cadena, 4)
			DC = New Cdatos.bdcampo(CodigoEntidad & "DC", Cdatos.TiposCampo.Cadena, 2)
			NumeroCuenta = New Cdatos.bdcampo(CodigoEntidad & "NumeroCuenta", Cdatos.TiposCampo.Cadena, 10)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
