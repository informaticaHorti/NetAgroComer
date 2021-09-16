Public Class E_SubFamiliaEnvases
    Inherits Cdatos.Entidad

    Public SFE_IdsubFamilia As Cdatos.bdcampo
    Public SFE_Nombre As Cdatos.bdcampo

    Public SFE_IdUsuarioLog As Cdatos.bdcampo
    Public SFE_FechaLog As Cdatos.bdcampo
    Public SFE_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "SubFamiliaEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            SFE_IdsubFamilia = New Cdatos.bdcampo(CodigoEntidad & "IdsubFamilia", Cdatos.TiposCampo.Entero, 4, 0, True)
            SFE_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 40)

            SFE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            SFE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            SFE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select SFE_Idsubfamilia as Id, SFE_Nombre as Nombre from SubFamiliaEnvases"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaSubFamiliaEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmSubFamiliaEnvases"


    End Sub

End Class
