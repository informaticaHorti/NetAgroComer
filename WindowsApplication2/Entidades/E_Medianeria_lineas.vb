Public Class E_Medianeria_lineas
    Inherits Cdatos.Entidad


    Public MEL_Id As Cdatos.bdcampo
    Public MEL_Idmedianeria As Cdatos.bdcampo
    Public MEL_Idagricultor As Cdatos.bdcampo
    Public MEL_porcentaje As Cdatos.bdcampo

    Public MEL_IdUsuarioLog As Cdatos.bdcampo
    Public MEL_FechaLog As Cdatos.bdcampo
    Public MEL_HoraLog As Cdatos.bdcampo

    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Medianeria_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            MEL_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            MEL_Idmedianeria = New Cdatos.bdcampo(CodigoEntidad & "idmedianeria", Cdatos.TiposCampo.EnteroPositivo, 5)
            MEL_Idagricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.EnteroPositivo, 5)
            MEL_porcentaje = New Cdatos.bdcampo(CodigoEntidad & "porcentaje", Cdatos.TiposCampo.Importe, 6, 2)

            MEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            MEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            MEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

End Class
