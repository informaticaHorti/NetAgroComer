Public Class E_ConfecPaletLineas
    Inherits Cdatos.Entidad

    Public CPL_Idlinea As Cdatos.bdcampo
    Public CPL_Idconfec As Cdatos.bdcampo
    Public CPL_Idmaterial As Cdatos.bdcampo
    Public CPL_Cantidad As Cdatos.bdcampo

    Public CPL_IdUsuarioLog As Cdatos.bdcampo
    Public CPL_FechaLog As Cdatos.bdcampo
    Public CPL_HoraLog As Cdatos.bdcampo

    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "confecpaletlineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CPL_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            CPL_Idconfec = New Cdatos.bdcampo(CodigoEntidad & "idconfec", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            CPL_Idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            CPL_Cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 6, 4)

            CPL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CPL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CPL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub
End Class
