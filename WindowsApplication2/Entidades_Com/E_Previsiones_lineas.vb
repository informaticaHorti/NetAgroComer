Public Class E_Previsiones_lineas


    Inherits Cdatos.Entidad

    Public PRL_id
    Public PRL_idprevision As Cdatos.bdcampo
    Public PRL_idgenero As Cdatos.bdcampo
    Public PRL_KILOS As Cdatos.bdcampo
    Public PRL_IDfinca As Cdatos.bdcampo
    Public PRL_Observaciones As Cdatos.bdcampo
    Public PRL_IdCultivo As Cdatos.bdcampo

    Public PRL_IdUsuarioLog As Cdatos.bdcampo
    Public PRL_FechaLog As Cdatos.bdcampo
    Public PRL_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Previsiones_lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PRL_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PRL_idprevision = New Cdatos.bdcampo(CodigoEntidad & "idprevision", Cdatos.TiposCampo.Entero, 5)
            PRL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.Entero, 5)
            PRL_KILOS = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Entero, 10)
            PRL_IDfinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PRL_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 50)
            PRL_IdCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdCultivo", Cdatos.TiposCampo.Entero, 10)

            PRL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PRL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PRL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




    End Sub





End Class
