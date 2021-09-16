Public Class E_ClientesDescargas
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public CLD_Id As Cdatos.bdcampo
    Public CLD_IdCliente As Cdatos.bdcampo
    Public CLD_Domicilio As Cdatos.bdcampo
    Public CLD_Poblacion As Cdatos.bdcampo
    Public CLD_Provincia As Cdatos.bdcampo
    Public CLD_CPostal As Cdatos.bdcampo
    Public CLD_IdPais As Cdatos.bdcampo
    Public CLD_IdZona As Cdatos.bdcampo
    Public CLD_Telefono1 As Cdatos.bdcampo
    Public CLD_Telefono2 As Cdatos.bdcampo
    Public CLD_ILN As Cdatos.bdcampo
    Public CLD_Observaciones As Cdatos.bdcampo
    Public CLD_idtipoporte As Cdatos.bdcampo
    Public CLD_origendestino As Cdatos.bdcampo
    Public CLD_emailalba1 As Cdatos.bdcampo
    Public CLD_emailalba2 As Cdatos.bdcampo
    Public CLD_emailalba3 As Cdatos.bdcampo
    Public CLD_emailped1 As Cdatos.bdcampo
    Public CLD_emailped2 As Cdatos.bdcampo
    Public CLD_emailped3 As Cdatos.bdcampo
    Public CLD_numero As Cdatos.bdcampo
    Public CLD_calidad As Cdatos.bdcampo
    Public CLD_maxdias As Cdatos.bdcampo
    Public CLD_reservapalets As Cdatos.bdcampo
    Public CLD_OpcionEnvio As Cdatos.bdcampo
    Public CLD_IdTarifaPortes As Cdatos.bdcampo
    Public CLD_IdConfecPalet As Cdatos.bdcampo
    Public CLD_IdTransportista As Cdatos.bdcampo

    Public CLD_TransporteRapidoSN As Cdatos.bdcampo

    Public CLD_LugarEntregaCMR As Cdatos.bdcampo

    Public CLD_IdUsuarioLog As Cdatos.bdcampo
    Public CLD_FechaLog As Cdatos.bdcampo
    Public CLD_HoraLog As Cdatos.bdcampo




	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "ClientesDescargas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CLD_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            CLD_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.Entero, 5)
            CLD_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 150)
            CLD_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            CLD_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            CLD_CPostal = New Cdatos.bdcampo(CodigoEntidad & "CPostal", Cdatos.TiposCampo.Cadena, 7)
            CLD_IdPais = New Cdatos.bdcampo(CodigoEntidad & "IdPais", Cdatos.TiposCampo.Entero, 10)
            CLD_IdZona = New Cdatos.bdcampo(CodigoEntidad & "IdZona", Cdatos.TiposCampo.Entero, 10)
            CLD_Telefono1 = New Cdatos.bdcampo(CodigoEntidad & "Telefono1", Cdatos.TiposCampo.Cadena, 15)
            CLD_Telefono2 = New Cdatos.bdcampo(CodigoEntidad & "Telefono2", Cdatos.TiposCampo.Cadena, 15)
            CLD_ILN = New Cdatos.bdcampo(CodigoEntidad & "ILN", Cdatos.TiposCampo.Cadena, 15)
            CLD_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 100)
            CLD_idtipoporte = New Cdatos.bdcampo(CodigoEntidad & "Idtipoporte", Cdatos.TiposCampo.Entero, 3)
            CLD_origendestino = New Cdatos.bdcampo(CodigoEntidad & "origendestino", Cdatos.TiposCampo.Cadena, 1)

            CLD_emailalba1 = New Cdatos.bdcampo(CodigoEntidad & "emailalba1", Cdatos.TiposCampo.Cadena, 50)
            CLD_emailalba2 = New Cdatos.bdcampo(CodigoEntidad & "emailalba2", Cdatos.TiposCampo.Cadena, 50)
            CLD_emailalba3 = New Cdatos.bdcampo(CodigoEntidad & "emailalba3", Cdatos.TiposCampo.Cadena, 50)

            CLD_emailped1 = New Cdatos.bdcampo(CodigoEntidad & "emailped1", Cdatos.TiposCampo.Cadena, 50)
            CLD_emailped2 = New Cdatos.bdcampo(CodigoEntidad & "emailped2", Cdatos.TiposCampo.Cadena, 50)
            CLD_emailped3 = New Cdatos.bdcampo(CodigoEntidad & "emailped3", Cdatos.TiposCampo.Cadena, 50)
            CLD_numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.EnteroPositivo, 3)
            CLD_calidad = New Cdatos.bdcampo(CodigoEntidad & "calidad", Cdatos.TiposCampo.Cadena, 1)
            CLD_maxdias = New Cdatos.bdcampo(CodigoEntidad & "maxdias", Cdatos.TiposCampo.CadenaNumero, 1)
            CLD_reservapalets = New Cdatos.bdcampo(CodigoEntidad & "reservapalets", Cdatos.TiposCampo.Cadena, 1)
            CLD_OpcionEnvio = New Cdatos.bdcampo(CodigoEntidad & "OpcionEnvio", Cdatos.TiposCampo.Cadena, 1)
            CLD_IdTarifaPortes = New Cdatos.bdcampo(CodigoEntidad & "IdTarifaPortes", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLD_IdConfecPalet = New Cdatos.bdcampo(CodigoEntidad & "IdConfecPalet", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLD_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 5)

            CLD_TransporteRapidoSN = New Cdatos.bdcampo(CodigoEntidad & "TransporteRapidoSN", Cdatos.TiposCampo.Cadena, 1)

            CLD_LugarEntregaCMR = New Cdatos.bdcampo(CodigoEntidad & "LugarEntregaCMR", Cdatos.TiposCampo.Cadena, 150)

            CLD_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLD_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CLD_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Numero"
        _btBusca.CL_ConsultaSql = "Select CLD_idcliente as IdCliente, CLD_id as Id,CLD_numero as Numero, CLD_domicilio as Domicilio, CLD_poblacion as Poblacion, CLD_provincia as Provincia from clientesdescargas order by cld_numero"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Numero"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscadescargas"
        _btBusca.CL_ch1000 = False

        _btBusca.Params("Id", , -1)
        _btBusca.Params("Idcliente", , -1)


	 End Sub


    Public Function LeerDomi(idcliente As String, Numero As String) As Integer
        Dim sql As String
        sql = "Select CLD_id from CLIENTESDESCARGAS where CLD_idcliente=" & idcliente + " and CLD_numero=" + Numero
        Dim ret As Integer = 0
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)(0))
            End If
        End If
        Return ret

    End Function


    Public Function MaxNumero(idcliente As String) As Integer
        Dim sql As String
        sql = "Select max(CLD_NUMERO) FROM CLIENTESDESCARGAS WHERE CLD_IDCLIENTE=" & idcliente
        Dim RET As Integer = 0
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                RET = VaInt(dt.Rows(0)(0))
            End If
        End If
        Return RET + 1

    End Function
End Class
