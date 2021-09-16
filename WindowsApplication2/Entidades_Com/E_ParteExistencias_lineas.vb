Public Class E_ParteExistencias_lineas
    Inherits Cdatos.Entidad

    Public PSL_idlinea As Cdatos.bdcampo
    Public PSL_idparte As Cdatos.bdcampo
    Public PSL_idgenero As Cdatos.bdcampo
    Public PSL_idtipoconfeccion As Cdatos.bdcampo
    Public PSL_idcategoria As Cdatos.bdcampo
    Public PSL_categoria As Cdatos.bdcampo
    Public PSL_idmarca As Cdatos.bdcampo
    Public PSL_kilos As Cdatos.bdcampo
    Public PSL_bultos As Cdatos.bdcampo
    Public PSL_palets As Cdatos.bdcampo
    Public PSL_precio As Cdatos.bdcampo
    Public PSL_observaciones As Cdatos.bdcampo

    Public PSL_IdUsuarioLog As Cdatos.bdcampo
    Public PSL_FechaLog As Cdatos.bdcampo
    Public PSL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "parteExistencias_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PSL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PSL_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 6)
            PSL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PSL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 5)
            PSL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PSL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PSL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 10)
            PSL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            PSL_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 6)
            PSL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 10, 5)
            PSL_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)

            PSL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PSL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PSL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
