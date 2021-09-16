Public Class E_AlbMaterialLineas

    Inherits Cdatos.Entidad

    Public AML_idlinea As Cdatos.bdcampo
    Public AML_idalb As Cdatos.bdcampo
    Public AML_idmaterial As Cdatos.bdcampo
    Public AML_idmarca As Cdatos.bdcampo
    Public AML_precio As Cdatos.bdcampo
    Public AML_cantidad As Cdatos.bdcampo
    Public AML_descuento As Cdatos.bdcampo
    Public AML_referencia As Cdatos.bdcampo
    Public AML_idlineapedido As Cdatos.bdcampo
    Public AML_finpedido As Cdatos.bdcampo

    Public AML_IdUsuarioLog As Cdatos.bdcampo
    Public AML_FechaLog As Cdatos.bdcampo
    Public AML_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "albmateriallineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AML_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            AML_idalb = New Cdatos.bdcampo(CodigoEntidad & "idalb", Cdatos.TiposCampo.EnteroPositivo, 6)
            AML_idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 6)
            AML_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 6)
            AML_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 10, 6)
            AML_cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 18, 4)
            AML_descuento = New Cdatos.bdcampo(CodigoEntidad & "descuento", Cdatos.TiposCampo.Importe, 10, 2)
            AML_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 20)
            AML_idlineapedido = New Cdatos.bdcampo(CodigoEntidad & "idlineapedido", Cdatos.TiposCampo.EnteroPositivo, 10)
            AML_finpedido = New Cdatos.bdcampo(CodigoEntidad & "finpedido", Cdatos.TiposCampo.Cadena, 1)

            AML_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AML_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AML_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub






End Class
