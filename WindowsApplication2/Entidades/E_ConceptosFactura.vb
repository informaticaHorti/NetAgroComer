Public Class E_ConceptosFactura
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public COF_idconcepto As Cdatos.bdcampo
    Public COF_nombre As Cdatos.bdcampo
    Public COF_idtipoiva As Cdatos.bdcampo

    Public COF_IdUsuarioLog As Cdatos.bdcampo
    Public COF_FechaLog As Cdatos.bdcampo
    Public COF_HoraLog As Cdatos.bdcampo



	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "ConceptosFactura"
            NombreBd = "NetAgroComer"
			MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            COF_idconcepto = New Cdatos.bdcampo(CodigoEntidad & "idconcepto", Cdatos.TiposCampo.Entero, 10, 0, True)
            COF_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            COF_idtipoiva = New Cdatos.bdcampo(CodigoEntidad & "idtipoiva", Cdatos.TiposCampo.Entero, 10)

            COF_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            COF_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            COF_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select COF_Idconcepto as IdConcepto, COF_Nombre as Nombre from ConceptosFactura"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idconcepto"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaConcepfac"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmConceptosFac"

	 End Sub


End Class
