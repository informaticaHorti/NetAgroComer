Public Class E_DatosUsuario
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdUsuario AS Cdatos.bdcampo
	Public IdCentro AS Cdatos.bdcampo
	Public IdEjercicio AS Cdatos.bdcampo
	Public IdActividad AS Cdatos.bdcampo
	Public IdSeccion AS Cdatos.bdcampo
	Public Peticionario AS Cdatos.bdcampo
	Public VistoBueno AS Cdatos.bdcampo
    Public IdPVenta As Cdatos.bdcampo
    Public Email As Cdatos.bdcampo
    Public idgrupo As Cdatos.bdcampo
    Public IdEmpresa As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "DatosUsuario"
            NombreBd = "Comun"
			MiConexion = conexion

            Me.IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10, , True)
			IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 10)
			IdEjercicio = New Cdatos.bdcampo(CodigoEntidad & "IdEjercicio", Cdatos.TiposCampo.Entero, 10)
			IdActividad = New Cdatos.bdcampo(CodigoEntidad & "IdActividad", Cdatos.TiposCampo.Entero, 10)
			IdSeccion = New Cdatos.bdcampo(CodigoEntidad & "IdSeccion", Cdatos.TiposCampo.Entero, 10)
			Peticionario = New Cdatos.bdcampo(CodigoEntidad & "Peticionario", Cdatos.TiposCampo.Cadena, 1)
			VistoBueno = New Cdatos.bdcampo(CodigoEntidad & "VistoBueno", Cdatos.TiposCampo.Cadena, 1)
            IdPVenta = New Cdatos.bdcampo(CodigoEntidad & "IdPVenta", Cdatos.TiposCampo.Entero, 10)
            Email = New Cdatos.bdcampo(CodigoEntidad & "Email", Cdatos.TiposCampo.Cadena, 255)
            idgrupo = New Cdatos.bdcampo(CodigoEntidad & "Idgrupo", Cdatos.TiposCampo.Entero, 10)
            IdEmpresa = New Cdatos.bdcampo("IdEmpresa", Cdatos.TiposCampo.Entero, 10)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
