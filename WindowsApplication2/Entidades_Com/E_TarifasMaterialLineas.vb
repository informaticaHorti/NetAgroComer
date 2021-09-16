Public Class E_TarifasMaterialLineas

    Inherits Cdatos.Entidad

    Public TML_idlinea As Cdatos.bdcampo
    Public TML_idacreedor As Cdatos.bdcampo
    Public TML_idmaterial As Cdatos.bdcampo
    Public TML_idmarca As Cdatos.bdcampo
    Public TML_precio As Cdatos.bdcampo
    Public TML_descuento As Cdatos.bdcampo
    Public TML_referencia As Cdatos.bdcampo

    Public TML_IdUsuarioLog As Cdatos.bdcampo
    Public TML_FechaLog As Cdatos.bdcampo
    Public TML_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "tarifasmateriallineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            TML_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            TML_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.EnteroPositivo, 5)
            TML_idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 6)
            TML_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 6)
            TML_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 10, 6)
            TML_descuento = New Cdatos.bdcampo(CodigoEntidad & "descuento", Cdatos.TiposCampo.Importe, 10, 2)
            TML_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 20)

            TML_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TML_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TML_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



    



End Class
