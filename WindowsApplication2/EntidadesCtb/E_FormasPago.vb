Public Class E_FormasPago
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdFormaPago AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public idTipoDocumento AS Cdatos.bdcampo
	Public NumRecibos AS Cdatos.bdcampo
	Public Periodicidad AS Cdatos.bdcampo
	Public GeneraCartera AS Cdatos.bdcampo
	Public PrimerVencimiento AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "FormasPago"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdFormaPago = New Cdatos.bdcampo("IdFormaPago", Cdatos.TiposCampo.Entero, 3, 0, True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
            idTipoDocumento = New Cdatos.bdcampo("idTipoDocumento", Cdatos.TiposCampo.Entero, 3)
            NumRecibos = New Cdatos.bdcampo("NumRecibos", Cdatos.TiposCampo.Entero, 3)
            Periodicidad = New Cdatos.bdcampo("Periodicidad", Cdatos.TiposCampo.Entero, 3)
			GeneraCartera = New Cdatos.bdcampo("GeneraCartera", Cdatos.TiposCampo.Cadena, 1)
            PrimerVencimiento = New Cdatos.bdcampo("PrimerVencimiento", Cdatos.TiposCampo.Entero, 3)

			MiListadeCampos = ListadeCampos()

            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select Idformapago,nombre,generacartera from FormasPago"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "idformapago"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaformapago"
            _btBusca.CL_ch1000 = False

		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select Idformapago as Codigo, Nombre from formaspago order by idformapago")
        Return dt
    End Function

    Public Function TipoDocumentoPorFormaPago(ByVal IdFormaPago As Integer) As Integer

        Dim dtTabla As New DataTable
        dtTabla = MiConexion.ConsultaSQL(" select IdTipoDocumento from formaspago where IdFormaPago=" & IdFormaPago.ToString)
        If dtTabla.Rows.Count > 0 Then
            Return VaInt(dtTabla.Rows(0)(0))
        Else
            Return 0
        End If
    End Function

End Class
