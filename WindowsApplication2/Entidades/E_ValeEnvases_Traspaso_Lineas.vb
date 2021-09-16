Public Class E_ValeEnvases_traspaso_Lineas
    Inherits Cdatos.Entidad

    Public VTL_Id As Cdatos.bdcampo
    Public VTL_idvaletraspaso As Cdatos.bdcampo
    Public VTL_idenvase As Cdatos.bdcampo
    Public VTL_uds As Cdatos.bdcampo
    Public VTL_precio As Cdatos.bdcampo
    Public VTL_idmarca As Cdatos.bdcampo

    Public VTL_IdUsuarioLog As Cdatos.bdcampo
    Public VTL_FechaLog As Cdatos.bdcampo
    Public VTL_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValeEnvases_traspaso_Lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VTL_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 8, 0, True)
            VTL_idvaletraspaso = New Cdatos.bdcampo(CodigoEntidad & "idvaletraspaso", Cdatos.TiposCampo.Entero, 8)
            VTL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.Entero, 8)
            VTL_uds = New Cdatos.bdcampo(CodigoEntidad & "uds", Cdatos.TiposCampo.Entero, 8)
            VTL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 20, 6)
            VTL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.Entero, 8)

            VTL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VTL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VTL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
