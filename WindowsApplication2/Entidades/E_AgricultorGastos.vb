Public Class E_AgricultorGastos
    Inherits Cdatos.Entidad

    Public AGG_Id As Cdatos.bdcampo
    Public AGG_IdAgricultor As Cdatos.bdcampo
    Public AGG_IdGasto As Cdatos.bdcampo
    Public AGG_Valor As Cdatos.bdcampo
    Public AGG_GastoFijo As Cdatos.bdcampo
    Public AGG_PedirEntrada As Cdatos.bdcampo
    Public AGG_IdAcreedor As Cdatos.bdcampo
    Public AGG_TipoFC As Cdatos.bdcampo
    Public AGG_idcentrorec As Cdatos.bdcampo
    Public AGG_AsignarAcreedorAlbaran As Cdatos.bdcampo

    Public AGG_IdUsuarioLog As Cdatos.bdcampo
    Public AGG_FechaLog As Cdatos.bdcampo
    Public AGG_HoraLog As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "AgricultorGastos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            AGG_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 5, 0, True)
            AGG_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.Entero, 5, 0, False)
            AGG_IdGasto = New Cdatos.bdcampo(CodigoEntidad & "idgasto", Cdatos.TiposCampo.Entero, 4, 0, False)
            AGG_Valor = New Cdatos.bdcampo(CodigoEntidad & "valor", Cdatos.TiposCampo.Importe, 8, 6)
            AGG_GastoFijo = New Cdatos.bdcampo(CodigoEntidad & "gastofijo", Cdatos.TiposCampo.Cadena, 1, 0)
            AGG_PedirEntrada = New Cdatos.bdcampo(CodigoEntidad & "pedirentrada", Cdatos.TiposCampo.Cadena, 1, 0)
            AGG_IdAcreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5, 0, False)
            AGG_TipoFC = New Cdatos.bdcampo(CodigoEntidad & "tipofc", Cdatos.TiposCampo.Cadena, 1, 0)
            AGG_idcentrorec = New Cdatos.bdcampo(CodigoEntidad & "idcentrorec", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            AGG_AsignarAcreedorAlbaran = New Cdatos.bdcampo(CodigoEntidad & "AsignarAcreedorAlbaran", Cdatos.TiposCampo.Cadena, 1, 0)


            AGG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AGG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub



End Class
