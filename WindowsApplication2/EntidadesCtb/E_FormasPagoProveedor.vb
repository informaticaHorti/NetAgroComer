Public Class E_FormasPagoProveedor
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdFormaPago AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public idTipoDocumento AS Cdatos.bdcampo
	Public NumRecibos AS Cdatos.bdcampo
	Public Periodicidad AS Cdatos.bdcampo
	Public GeneraCartera AS Cdatos.bdcampo
    Public Tipo As Cdatos.bdcampo
    Public DescContable As Cdatos.bdcampo


    Public Enum TipoFormaPagoProveedor

        ReciboALaVista = 1
        Reposicion = 2
        ReciboDomiciliado = 3
        Prepago = 4
        Contado = 5
        Confirming = 6

    End Enum


    Public ReadOnly Property TipoFormaPago As TipoFormaPagoProveedor
        Get
            If Me IsNot Nothing Then
                If Me.Tipo IsNot Nothing Then
                    If Me.Tipo.Valor IsNot Nothing Then
                        If VaInt(Me.Tipo.Valor) > 0 Then
                            Return CType(VaInt(Me.Tipo.Valor), TipoFormaPagoProveedor)
                        Else
                            Return 0
                        End If
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Get
    End Property


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "FormasPagoProveedor"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdFormaPago = New Cdatos.bdcampo("IdFormaPago", Cdatos.TiposCampo.Entero, 10, , True)
			Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
			idTipoDocumento = New Cdatos.bdcampo("idTipoDocumento", Cdatos.TiposCampo.Entero, 10)
			NumRecibos = New Cdatos.bdcampo("NumRecibos", Cdatos.TiposCampo.Entero, 10)
			Periodicidad = New Cdatos.bdcampo("Periodicidad", Cdatos.TiposCampo.Entero, 10)
			GeneraCartera = New Cdatos.bdcampo("GeneraCartera", Cdatos.TiposCampo.Cadena, 1)
            Tipo = New Cdatos.bdcampo("Tipo", Cdatos.TiposCampo.Entero, 10)
            DescContable = New Cdatos.bdcampo("DescContable", Cdatos.TiposCampo.Cadena, 3)

            MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select Idformapago,nombre,generacartera from FormasPagoProveedor"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "idformapago"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaformapagoProveedor"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Function TablaFormasPagoProveedor() As DataTable

        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdFormaPago,Nombre,generacartera from FormasPagoProveedor order by idformapago")
        Return dt


    End Function

	Public Function CbTipoFpago() As DataTable
        Dim dT As New DataTable



        dT.Columns.Add(New DataColumn("Id"))
        dT.Columns.Add(New DataColumn("Nombre"))
        dT.Rows.Add("1", "Recibo a la vista")
        dT.Rows.Add("2", "Reposición")
        dT.Rows.Add("3", "Recibo domiciliado")
        dT.Rows.Add("4", "Prepago")
        dT.Rows.Add("5", "Contado")
        dT.Rows.Add("6", "Confirming")


        Return dT

    End Function

End Class
