Public Class E_PedidosMaterialLineas

    Inherits Cdatos.Entidad

    Public PML_idlinea As Cdatos.bdcampo
    Public PML_idpedido As Cdatos.bdcampo
    Public PML_idmaterial As Cdatos.bdcampo
    Public PML_idmarca As Cdatos.bdcampo
    Public PML_precio As Cdatos.bdcampo
    Public PML_cantidad As Cdatos.bdcampo
    Public PML_descuento As Cdatos.bdcampo
    Public PML_referencia As Cdatos.bdcampo
    Public PML_finalizado As Cdatos.bdcampo

    Public PML_IdUsuarioLog As Cdatos.bdcampo
    Public PML_FechaLog As Cdatos.bdcampo
    Public PML_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "pedidosmateriallineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PML_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PML_idpedido = New Cdatos.bdcampo(CodigoEntidad & "idpedido", Cdatos.TiposCampo.EnteroPositivo, 6)
            PML_idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 6)
            PML_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 6)
            PML_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 10, 6)
            PML_cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 18, 4)
            PML_descuento = New Cdatos.bdcampo(CodigoEntidad & "descuento", Cdatos.TiposCampo.Importe, 10, 2)
            PML_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 20)
            PML_finalizado = New Cdatos.bdcampo(CodigoEntidad & "finalizado", Cdatos.TiposCampo.Cadena, 1)

            PML_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PML_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PML_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



   


End Class
