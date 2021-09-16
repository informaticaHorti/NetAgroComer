Public Class E_envasesInicial

    Inherits Cdatos.Entidad

    Public ENI_id As Cdatos.bdcampo
    Public ENI_campa As Cdatos.bdcampo
    Public ENI_tipo As Cdatos.bdcampo
    Public ENI_codigo As Cdatos.bdcampo
    Public ENI_idenvase As Cdatos.bdcampo
    Public ENI_idmarca As Cdatos.bdcampo
    Public ENI_inicial As Cdatos.bdcampo
    Public ENI_precio As Cdatos.bdcampo

    Public ENI_IdUsuarioLog As Cdatos.bdcampo
    Public ENI_FechaLog As Cdatos.bdcampo
    Public ENI_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "envasesinicial"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ENI_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            ENI_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.EnteroPositivo, 2)
            ENI_tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 2)
            ENI_codigo = New Cdatos.bdcampo(CodigoEntidad & "codigo", Cdatos.TiposCampo.EnteroPositivo, 6)
            ENI_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 6)
            ENI_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 6)
            ENI_inicial = New Cdatos.bdcampo(CodigoEntidad & "inicial", Cdatos.TiposCampo.Importe, 10, 2)
            ENI_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 21, 8)

            ENI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ENI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ENI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
