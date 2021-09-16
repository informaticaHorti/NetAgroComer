Public Class E_DatosEmpresa
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public id AS Cdatos.bdcampo
	Public NifDeclarante AS Cdatos.bdcampo
	Public RazonSocial AS Cdatos.bdcampo
	Public Telefono AS Cdatos.bdcampo
	Public PersonaContacto AS Cdatos.bdcampo
	Public TipoSoporte AS Cdatos.bdcampo
	Public EjerPresentacion AS Cdatos.bdcampo
	Public PerPresentacion AS Cdatos.bdcampo
	Public NumPresentacion AS Cdatos.bdcampo
	Public ComSust AS Cdatos.bdcampo
	Public DecAnterior AS Cdatos.bdcampo
	Public Periodo AS Cdatos.bdcampo
	Public CodigoAuto AS Cdatos.bdcampo
	Public Poblacion AS Cdatos.bdcampo
	Public Provincia AS Cdatos.bdcampo
	Public Domicilio AS Cdatos.bdcampo
	Public PINFacturas As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "DatosEmpresa"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, , True)
			NifDeclarante = New Cdatos.bdcampo(CodigoEntidad & "NifDeclarante", Cdatos.TiposCampo.Cadena, 9)
			RazonSocial = New Cdatos.bdcampo(CodigoEntidad & "RazonSocial", Cdatos.TiposCampo.Cadena, 40)
			Telefono = New Cdatos.bdcampo(CodigoEntidad & "Telefono", Cdatos.TiposCampo.Cadena, 9)
			PersonaContacto = New Cdatos.bdcampo(CodigoEntidad & "PersonaContacto", Cdatos.TiposCampo.Cadena, 40)
			TipoSoporte = New Cdatos.bdcampo(CodigoEntidad & "TipoSoporte", Cdatos.TiposCampo.Cadena, 1)
			EjerPresentacion = New Cdatos.bdcampo(CodigoEntidad & "EjerPresentacion", Cdatos.TiposCampo.Cadena, 4)
			PerPresentacion = New Cdatos.bdcampo(CodigoEntidad & "PerPresentacion", Cdatos.TiposCampo.Cadena, 2)
			NumPresentacion = New Cdatos.bdcampo(CodigoEntidad & "NumPresentacion", Cdatos.TiposCampo.Cadena, 4)
			ComSust = New Cdatos.bdcampo(CodigoEntidad & "ComSust", Cdatos.TiposCampo.Cadena, 1)
			DecAnterior = New Cdatos.bdcampo(CodigoEntidad & "DecAnterior", Cdatos.TiposCampo.Cadena, 13)
			Periodo = New Cdatos.bdcampo(CodigoEntidad & "Periodo", Cdatos.TiposCampo.Cadena, 2)
			CodigoAuto = New Cdatos.bdcampo(CodigoEntidad & "CodigoAuto", Cdatos.TiposCampo.Cadena, 16)
			Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 150)
			Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 150)
			Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 200)
			PINFacturas = New Cdatos.bdcampo("PINFacturas", Cdatos.TiposCampo.Cadena, 10)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
