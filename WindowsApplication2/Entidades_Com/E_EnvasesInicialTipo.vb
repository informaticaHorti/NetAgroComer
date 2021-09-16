Public Class E_envasesInicialtipo
    Inherits Cdatos.Entidad


    Public EIT_tipo As Cdatos.bdcampo

    Public EIT_IdUsuarioLog As Cdatos.bdcampo
    Public EIT_FechaLog As Cdatos.bdcampo
    Public EIT_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "envasesinicialtipo"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            EIT_tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 2, 0, True)

            EIT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            EIT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            EIT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
