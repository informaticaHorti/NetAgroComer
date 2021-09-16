Public Class E_Cargas_Palets
    Inherits Cdatos.Entidad

    Public CGL_idpalet As Cdatos.bdcampo
    Public CGL_idmuelle As Cdatos.bdcampo
    Public CGL_hora As Cdatos.bdcampo
    Public CGL_nupalet As Cdatos.bdcampo

    Public CGL_IdUsuarioLog As Cdatos.bdcampo
    Public CGL_FechaLog As Cdatos.bdcampo
    Public CGL_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Cargas_Palets"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CGL_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CGL_idmuelle = New Cdatos.bdcampo(CodigoEntidad & "idmuelle", Cdatos.TiposCampo.EnteroPositivo, 2)
            CGL_hora = New Cdatos.bdcampo(CodigoEntidad & "hora", Cdatos.TiposCampo.Cadena, 10)
            CGL_nupalet = New Cdatos.bdcampo(CodigoEntidad & "nupalet", Cdatos.TiposCampo.EnteroPositivo, 8)

            CGL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CGL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CGL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
