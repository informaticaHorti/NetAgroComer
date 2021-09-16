Public Class E_ExistenciasTercerosLineas

    Inherits Cdatos.Entidad

    Public EXL_idlinea As Cdatos.bdcampo
    Public EXL_idparte As Cdatos.bdcampo
    Public EXL_partida As Cdatos.bdcampo
    Public EXL_bultos As Cdatos.bdcampo
    Public EXL_kilos As Cdatos.bdcampo
    Public EXL_idlineasEnt As Cdatos.bdcampo

    Public EXL_IdUsuarioLog As Cdatos.bdcampo
    Public EXL_FechaLog As Cdatos.bdcampo
    Public EXL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "existenciasterceroslineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            EXL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            EXL_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 10)
            EXL_partida = New Cdatos.bdcampo(CodigoEntidad & "partida", Cdatos.TiposCampo.EnteroPositivo, 10)
            EXL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.EnteroPositivo, 6)
            EXL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 10, 2)
            EXL_idlineasEnt = New Cdatos.bdcampo(CodigoEntidad & "idlineasent", Cdatos.TiposCampo.EnteroPositivo, 10)

            EXL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            EXL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            EXL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub







End Class
