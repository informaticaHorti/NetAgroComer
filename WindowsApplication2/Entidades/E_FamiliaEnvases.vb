Public Class E_FamiliaEnvases
    Inherits Cdatos.Entidad

    Public FEV_IdFamilia As Cdatos.bdcampo
    Public FEV_Nombre As Cdatos.bdcampo

    Public FEV_IdUsuarioLog As Cdatos.bdcampo
    Public FEV_FechaLog As Cdatos.bdcampo
    Public FEV_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
      Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FamiliaEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FEV_IdFamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 4, 0, True)
            FEV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 40)

            FEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select FEV_Idfamilia as IdFamilia, FEV_Nombre as Nombre from FamiliaEnvases"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idfamilia"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFamiliaEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmFamiliaEnvases"
        

    End Sub

End Class
