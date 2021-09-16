Public Class E_Aplicacion
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdAplicacion AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public Version AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Aplicacion"
            NombreBd = "Comun"
			MiConexion = conexion

            IdAplicacion = New Cdatos.bdcampo(CodigoEntidad & "IdAplicacion", Cdatos.TiposCampo.Entero, 10, , True)
			Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
			Version = New Cdatos.bdcampo(CodigoEntidad & "Version", Cdatos.TiposCampo.Cadena, 50)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function TablaAplicaciones() As DataTable


        Dim dt As DataTable = Nothing

        Try
            dt = MiConexion.ConsultaSQL("Select IdAplicacion,Nombre From Aplicacion order by nombre")
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


End Class
