Public Class E_DevEnvases_Lineas
    Inherits Cdatos.Entidad

    Public DEL_id As Cdatos.bdcampo
    Public DEL_idvale As Cdatos.bdcampo
    Public DEL_idenvase As Cdatos.bdcampo
    Public DEL_cantidad As Cdatos.bdcampo

    Public DEL_IdUsuarioLog As Cdatos.bdcampo
    Public DEL_FechaLog As Cdatos.bdcampo
    Public DEL_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DevEnvases_Lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DEL_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 8, 0, True)
            DEL_idvale = New Cdatos.bdcampo(CodigoEntidad & "idvale", Cdatos.TiposCampo.Entero, 8)
            DEL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.Entero, 8)
            DEL_cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 10, 2)

            DEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)
 

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
