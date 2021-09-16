Public Class E_Lotes_lineas
    Inherits Cdatos.Entidad


    Public LTL_Idlinea As Cdatos.bdcampo
    Public LTL_Idlote As Cdatos.bdcampo
    Public LTL_Idlineaentrada As Cdatos.bdcampo
    Public LTL_Bultos As Cdatos.bdcampo
    Public LTL_Kilos As Cdatos.bdcampo
    Public LTL_Idprogramacliente As Cdatos.bdcampo

    Public LTL_IdUsuarioLog As Cdatos.bdcampo
    Public LTL_FechaLog As Cdatos.bdcampo
    Public LTL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Generos As New E_Generos(idUsuario, cn)


        Try
            NombreTabla = "Lotes_lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LTL_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "Idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            LTL_Idlote = New Cdatos.bdcampo(CodigoEntidad & "idlote", Cdatos.TiposCampo.EnteroPositivo, 6)
            LTL_Idlineaentrada = New Cdatos.bdcampo(CodigoEntidad & "IdLineaentrada", Cdatos.TiposCampo.EnteroPositivo, 6)
            LTL_Bultos = New Cdatos.bdcampo(CodigoEntidad & "Bultos", Cdatos.TiposCampo.Importe, 10)
            LTL_Kilos = New Cdatos.bdcampo(CodigoEntidad & "Kilos", Cdatos.TiposCampo.Importe, 10)
            LTL_Idprogramacliente = New Cdatos.bdcampo(CodigoEntidad & "Idprogramacliente", Cdatos.TiposCampo.EnteroPositivo, 6)

            LTL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LTL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LTL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

End Class
