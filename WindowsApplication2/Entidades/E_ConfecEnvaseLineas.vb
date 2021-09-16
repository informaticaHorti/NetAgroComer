Public Class E_ConfecEnvaseLineas
    Inherits Cdatos.Entidad


    Public CEL_Idlinea As Cdatos.bdcampo
    Public CEL_Idconfec As Cdatos.bdcampo
    Public CEL_Idmaterial As Cdatos.bdcampo
    Public CEL_Cantidad As Cdatos.bdcampo
    Public CEL_TipoEtiqueta As Cdatos.bdcampo

    Public CEL_IdUsuarioLog As Cdatos.bdcampo
    Public CEL_FechaLog As Cdatos.bdcampo
    Public CEL_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "confecenvaselineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CEL_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            CEL_Idconfec = New Cdatos.bdcampo(CodigoEntidad & "idconfec", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            CEL_Idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            CEL_Cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 6, 4)
            CEL_TipoEtiqueta = New Cdatos.bdcampo(CodigoEntidad & "TipoEtiqueta", Cdatos.TiposCampo.Cadena, 1)

            CEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub
End Class
