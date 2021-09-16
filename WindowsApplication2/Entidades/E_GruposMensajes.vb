Public Class E_GruposMensajes
    Inherits Cdatos.Entidad


    Public GRM_Id As Cdatos.bdcampo
    Public GRM_Nombre As Cdatos.bdcampo

    Public GRM_IdUsuarioLog As Cdatos.bdcampo
    Public GRM_FechaLog As Cdatos.bdcampo
    Public GRM_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Vendedor As New E_Vendedores(idUsuario, cn)
        Try

            NombreTabla = "GruposMensajes"
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            MiConexion = conexion

            GRM_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 3, 0, True)
            GRM_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            GRM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GRM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GRM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select GRM_Id as IdGrupo, GRM_Nombre as Nombre from GruposMensajes"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdGrupo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaGrupos"
        _btBusca.CL_ch1000 = False

        _btBusca.Params("IdGrupo", "Id", 10)
        _btBusca.cl_formu = "FrmGruposMensajes"

    End Sub



End Class
