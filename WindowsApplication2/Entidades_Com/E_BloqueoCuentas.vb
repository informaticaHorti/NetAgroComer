Public Class E_BloqueoCuentas
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public NumeroCuenta As Cdatos.bdcampo
    Public Aviso As Cdatos.bdcampo
    Public BloqueoSN As Cdatos.bdcampo
    Public AvisoSN As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreBd = "NetAgro_Comer"
			NombreTabla = "BloqueoCuentas"
			MiConexion = conexion

            PrefijoContador = ""

            NumeroCuenta = New Cdatos.bdcampo("NumeroCuenta", Cdatos.TiposCampo.Cadena, 15, 0, True)
            Aviso = New Cdatos.bdcampo("Aviso", Cdatos.TiposCampo.Cadena, 1000)
            BloqueoSN = New Cdatos.bdcampo("BloqueoSN", Cdatos.TiposCampo.Cadena, 1)
            AvisoSN = New Cdatos.bdcampo("AvisoSN", Cdatos.TiposCampo.Cadena, 1)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
