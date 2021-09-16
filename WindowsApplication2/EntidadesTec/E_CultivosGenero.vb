Public Class E_CultivosGenero

    Inherits Cdatos.Entidad

    Public CGE_Id As Cdatos.bdcampo
    Public CGE_IdCultivo As Cdatos.bdcampo
    Public CGE_IdGenero As Cdatos.bdcampo

    Public CGE_IdUsuarioLog As Cdatos.bdcampo
    Public CGE_FechaLog As Cdatos.bdcampo
    Public CGE_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CultivosGenero"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE TecnicosNet
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CGE_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            CGE_IdCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdCultivo", Cdatos.TiposCampo.EnteroPositivo, 10)
            CGE_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.EnteroPositivo, 10)


            CGE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CGE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CGE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "SELECT CGE_IdCultivo as IdCultivo, CGE_IdGenero as IdGenero FROM CultivosGenero"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCultivosGenero"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
