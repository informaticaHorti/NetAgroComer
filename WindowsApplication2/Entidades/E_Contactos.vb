Public Class E_Contactos
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public COT_Id As Cdatos.bdcampo
    Public COT_fichero As Cdatos.bdcampo
    Public COT_idfichero As Cdatos.bdcampo
    Public COT_departamento As Cdatos.bdcampo
    Public COT_Contacto As Cdatos.bdcampo
    Public COT_Telefono As Cdatos.bdcampo
    Public COT_Movil As Cdatos.bdcampo
    Public COT_Mail As Cdatos.bdcampo
    Public COT_Fax As Cdatos.bdcampo
    Public COT_Observaciones1 As Cdatos.bdcampo
    Public COT_Observaciones2 As Cdatos.bdcampo
    Public COT_claveemail As Cdatos.bdcampo
    Public COT_cargo As Cdatos.bdcampo

    Public COT_IdUsuarioLog As Cdatos.bdcampo
    Public COT_FechaLog As Cdatos.bdcampo
    Public COT_HoraLog As Cdatos.bdcampo



	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Contactos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            COT_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            COT_fichero = New Cdatos.bdcampo(CodigoEntidad & "fichero", Cdatos.TiposCampo.Cadena, 50)
            COT_idfichero = New Cdatos.bdcampo(CodigoEntidad & "Idfichero", Cdatos.TiposCampo.Cadena, 10, 0)
            COT_departamento = New Cdatos.bdcampo(CodigoEntidad & "Departamento", Cdatos.TiposCampo.Cadena, 1)
            COT_Contacto = New Cdatos.bdcampo(CodigoEntidad & "Contacto", Cdatos.TiposCampo.Cadena, 30)
            COT_Telefono = New Cdatos.bdcampo(CodigoEntidad & "Telefono", Cdatos.TiposCampo.Cadena, 15)
            COT_Movil = New Cdatos.bdcampo(CodigoEntidad & "Movil", Cdatos.TiposCampo.Cadena, 15)
            COT_Mail = New Cdatos.bdcampo(CodigoEntidad & "Mail", Cdatos.TiposCampo.Cadena, 250)
            COT_Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 15)
            COT_Observaciones1 = New Cdatos.bdcampo(CodigoEntidad & "Observaciones1", Cdatos.TiposCampo.Cadena, 100)
            COT_Observaciones2 = New Cdatos.bdcampo(CodigoEntidad & "Observaciones2", Cdatos.TiposCampo.Cadena, 100)
            COT_claveemail = New Cdatos.bdcampo(CodigoEntidad & "claveemail", Cdatos.TiposCampo.Cadena, 3)
            COT_cargo = New Cdatos.bdcampo(CodigoEntidad & "Cargo", Cdatos.TiposCampo.Cadena, 25)

            COT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            COT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            COT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


End Class
