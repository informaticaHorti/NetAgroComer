Public Class E_PuntoVenta
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdPuntoVenta AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public IdCentro AS Cdatos.bdcampo
	Public IdActividad AS Cdatos.bdcampo
	Public IdSeccion AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "PuntoVenta"
            MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)


            PrefijoContador = ""

            IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "IdPuntoVenta", Cdatos.TiposCampo.Entero, 10, 0, True)
			Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 150)
			IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 10)
			IdActividad = New Cdatos.bdcampo(CodigoEntidad & "IdActividad", Cdatos.TiposCampo.Entero, 10)
			IdSeccion = New Cdatos.bdcampo(CodigoEntidad & "IdSeccion", Cdatos.TiposCampo.Entero, 10)

            MiListadeCampos = ListadeCampos()


            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select idpuntoventa,nombre from puntoventa"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idpuntoventa"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaPuntoVenta"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub

    Public Function Tabla(Optional ByVal IdCentro As String = "") As DataTable
        Dim dt As New DataTable
        If IdCentro = "" Then
            dt = MiConexion.ConsultaSQL("Select IdPuntoventa, Nombre from puntoventa order by idpuntoventa")
        Else
            dt = MiConexion.ConsultaSQL("Select IdPuntoventa, Nombre from puntoventa where idcentro=" + IdCentro + " order by idpuntoventa")

        End If

        Return dt
    End Function



End Class
