Public Class E_Recuento_Lineas
    Inherits Cdatos.Entidad

    Public REL_IdLinea As Cdatos.bdcampo
    Public REL_IdRecuento As Cdatos.bdcampo
    Public REL_IdMaterial As Cdatos.bdcampo
    Public REL_IdMarca As Cdatos.bdcampo
    Public REL_Unidades As Cdatos.bdcampo
    Public REL_PMC As Cdatos.bdcampo

    Public REL_IdUsuarioLog As Cdatos.bdcampo
    Public REL_FechaLog As Cdatos.bdcampo
    Public REL_HoraLog As Cdatos.bdcampo




    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Recuento_Lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            REL_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            REL_IdRecuento = New Cdatos.bdcampo(CodigoEntidad & "IdRecuento", Cdatos.TiposCampo.EnteroPositivo, 10)
            REL_IdMaterial = New Cdatos.bdcampo(CodigoEntidad & "IdMaterial", Cdatos.TiposCampo.EnteroPositivo, 8)
            REL_IdMarca = New Cdatos.bdcampo(CodigoEntidad & "IdMarca", Cdatos.TiposCampo.EnteroPositivo, 8)
            REL_Unidades = New Cdatos.bdcampo(CodigoEntidad & "Unidades", Cdatos.TiposCampo.Importe, 10, 2)
            REL_PMC = New Cdatos.bdcampo(CodigoEntidad & "PMC", Cdatos.TiposCampo.Importe, 12, 6)

            REL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            REL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            REL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
