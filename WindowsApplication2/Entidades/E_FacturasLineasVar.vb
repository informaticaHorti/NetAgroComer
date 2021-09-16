Public Class E_FacturasLineasVar

    Inherits Cdatos.Entidad

    Public FLV_idlinea As Cdatos.bdcampo
    Public FLV_idfactura As Cdatos.bdcampo
    Public FLV_tipoGEC As Cdatos.bdcampo
    Public FLV_codigo As Cdatos.bdcampo
    Public FLV_cantidad As Cdatos.bdcampo
    Public FLV_precio As Cdatos.bdcampo

    Public FLV_IdUsuarioLog As Cdatos.bdcampo
    Public FLV_FechaLog As Cdatos.bdcampo
    Public FLV_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Facturaslineasvar"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FLV_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            FLV_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 10)
            FLV_tipoGEC = New Cdatos.bdcampo(CodigoEntidad & "tipoGEC", Cdatos.TiposCampo.Cadena, 1)
            FLV_codigo = New Cdatos.bdcampo(CodigoEntidad & "codigo", Cdatos.TiposCampo.EnteroPositivo, 10)
            FLV_cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 10, 2)
            FLV_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 12, 6)

            FLV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FLV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FLV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub




End Class
