Public Class E_RemesasFactoring_Lineas
    Inherits Cdatos.Entidad

    Public RFL_Id As Cdatos.bdcampo
    Public RFL_IdRemesa As Cdatos.bdcampo
    Public RFL_IdAlbaran As Cdatos.bdcampo
    Public RFL_Importe As Cdatos.bdcampo

    Public RFL_IdUsuarioLog As Cdatos.bdcampo
    Public RFL_FechaLog As Cdatos.bdcampo
    Public RFL_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "RemesasFactoring_Lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            RFL_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            RFL_IdRemesa = New Cdatos.bdcampo(CodigoEntidad & "IdRemesa", Cdatos.TiposCampo.Entero, 10)
            RFL_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "IdAlbaran", Cdatos.TiposCampo.Entero, 6)
            RFL_Importe = New Cdatos.bdcampo(CodigoEntidad & "Importe", Cdatos.TiposCampo.Importe, 18, 4)

            RFL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            RFL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            RFL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
