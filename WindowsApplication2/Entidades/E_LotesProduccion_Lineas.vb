Public Class E_LotesProduccion_Lineas
    Inherits Cdatos.Entidad


    Public LPL_Idlinea As Cdatos.bdcampo
    Public LPL_Idlote As Cdatos.bdcampo
    Public LPL_IdlineaEntrada As Cdatos.bdcampo
    Public LPL_IdLotePartida As Cdatos.bdcampo
    Public LPL_Bultos As Cdatos.bdcampo
    Public LPL_Kilos As Cdatos.bdcampo
    Public LPL_IdProgramaCliente As Cdatos.bdcampo

    Public LPL_IdUsuarioLog As Cdatos.bdcampo
    Public LPL_FechaLog As Cdatos.bdcampo
    Public LPL_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Generos As New E_Generos(idUsuario, cn)


        Try
            NombreTabla = "LotesProduccion_lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LPL_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "Idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            LPL_Idlote = New Cdatos.bdcampo(CodigoEntidad & "IdLote", Cdatos.TiposCampo.EnteroPositivo, 6)
            LPL_Idlineaentrada = New Cdatos.bdcampo(CodigoEntidad & "IdLineaEntrada", Cdatos.TiposCampo.EnteroPositivo, 6)
            LPL_IdLotePartida = New Cdatos.bdcampo(CodigoEntidad & "IdLotePartida", Cdatos.TiposCampo.EnteroPositivo, 6)
            LPL_Bultos = New Cdatos.bdcampo(CodigoEntidad & "Bultos", Cdatos.TiposCampo.Importe, 10)
            LPL_Kilos = New Cdatos.bdcampo(CodigoEntidad & "Kilos", Cdatos.TiposCampo.Importe, 10)
            LPL_IdProgramaCliente = New Cdatos.bdcampo(CodigoEntidad & "IdProgramaCliente", Cdatos.TiposCampo.EnteroPositivo, 6)

            LPL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LPL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LPL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

End Class
