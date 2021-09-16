Public Class E_TipoDocumento
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdTipodocumento AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
    Public CalCuloInteres As Cdatos.bdcampo
    Public GeneraAsientoVto As Cdatos.bdcampo
    Public EmitirPago As Cdatos.bdcampo



	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "TipoDocumento"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdTipodocumento = New Cdatos.bdcampo("IdTipodocumento", Cdatos.TiposCampo.Entero, 10, 0, True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
			CalCuloInteres = New Cdatos.bdcampo("CalCuloInteres", Cdatos.TiposCampo.Cadena, 1)
            GeneraAsientoVto = New Cdatos.bdcampo("GeneraAsientoVto", Cdatos.TiposCampo.Cadena, 1)
            EmitirPago = New Cdatos.bdcampo("EmitirPago", Cdatos.TiposCampo.Cadena, 1)

			MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdtipoDocumento,nombre from TipoDocumento"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "idtipodocumento"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscatipodocumento"
            _btBusca.CL_ch1000 = False

		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Shared Function ObtieneUltimoNumero(ByVal IdBanco As Integer, ByVal idTipoDoc As Integer) As Int32

        Dim resultado As Integer = 1
        Dim dt As New DataTable
        dt = cn.ConsultaSQL("Select max (UltimoNumero) FROM NumeroTalones Where IdBanco=" & IdBanco & " AND IdTipoDoc=" & idTipoDoc)
        If dt.Rows.Count > 0 Then
            resultado = VaInt(dt.Rows(0)(0)) + 1
        End If

        Return resultado

    End Function


End Class
