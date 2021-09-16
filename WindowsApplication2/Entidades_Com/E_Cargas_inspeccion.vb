Public Class E_Cargas_inspeccion
    Inherits Cdatos.Entidad

    Public CGI_id As Cdatos.bdcampo
    Public CGI_idcarga As Cdatos.bdcampo
    Public CGI_idinspeccion As Cdatos.bdcampo
    Public CGI_sn As Cdatos.bdcampo

    Public CGI_IdUsuarioLog As Cdatos.bdcampo
    Public CGI_FechaLog As Cdatos.bdcampo
    Public CGI_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Cargas_inspeccion"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CGI_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CGI_idcarga = New Cdatos.bdcampo(CodigoEntidad & "idcarga", Cdatos.TiposCampo.EnteroPositivo, 5)
            CGI_idinspeccion = New Cdatos.bdcampo(CodigoEntidad & "idinspeccion", Cdatos.TiposCampo.EnteroPositivo, 6)
            CGI_sn = New Cdatos.bdcampo(CodigoEntidad & "sn", Cdatos.TiposCampo.Cadena, 1)

            CGI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CGI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CGI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
