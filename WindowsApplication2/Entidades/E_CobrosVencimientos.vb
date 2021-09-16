Public Class E_CobrosVencimientos
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public CVT_IdVencimiento As Cdatos.bdcampo
    Public CVT_Fecha As Cdatos.bdcampo
    Public CVT_Importe As Cdatos.bdcampo
    Public CVT_IdCobro As Cdatos.bdcampo
    Public CVT_Concepto As Cdatos.bdcampo
    Public CVT_Tipodocumento As Cdatos.bdcampo
    Public CVT_Idconcepto As Cdatos.bdcampo

    Public CVT_IdUsuarioLog As Cdatos.bdcampo
    Public CVT_FechaLog As Cdatos.bdcampo
    Public CVT_HoraLog As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "CobrosVencimientos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            CVT_IdVencimiento = New Cdatos.bdcampo(CodigoEntidad & "IdVencimiento", Cdatos.TiposCampo.Entero, 10, 0, True)
            CVT_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            CVT_Importe = New Cdatos.bdcampo(CodigoEntidad & "Importe", Cdatos.TiposCampo.Importe, 19, 2)
            CVT_IdCobro = New Cdatos.bdcampo(CodigoEntidad & "IdCobro", Cdatos.TiposCampo.Entero, 10)
            CVT_Concepto = New Cdatos.bdcampo(CodigoEntidad & "Concepto", Cdatos.TiposCampo.Cadena, 50)
            CVT_Tipodocumento = New Cdatos.bdcampo(CodigoEntidad & "tipodocumento", Cdatos.TiposCampo.Entero, 3)
            CVT_Idconcepto = New Cdatos.bdcampo(CodigoEntidad & "idconcepto", Cdatos.TiposCampo.Entero, 3)

            CVT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CVT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CVT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function ObtenerVencimientosCobro(ByVal IdCobro As String)

        Dim sql As String = "SELECT CVT_Fecha as Fecha, CVT_Concepto as Concepto, CVT_Importe as Importe FROM CobrosVencimientos WHERE CVT_IdCobro=" + VaInt(IdCobro).ToString
        Return MiConexion.ConsultaSQL(sql)

    End Function


End Class
