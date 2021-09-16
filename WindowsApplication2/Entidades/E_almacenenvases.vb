Public Class E_AlmacenEnvases
    Inherits Cdatos.Entidad

    Public AEV_Idalmacen As Cdatos.bdcampo
    Public AEV_Nombre As Cdatos.bdcampo

    Public AEV_Domicilio As Cdatos.bdcampo
    Public AEV_CPostal As Cdatos.bdcampo
    Public AEV_Poblacion As Cdatos.bdcampo
    Public AEV_Provincia As Cdatos.bdcampo

    Public AEV_IdUsuarioLog As Cdatos.bdcampo
    Public AEV_FechaLog As Cdatos.bdcampo
    Public AEV_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "AlmacenEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AEV_Idalmacen = New Cdatos.bdcampo(CodigoEntidad & "Idalmacen", Cdatos.TiposCampo.Entero, 3, 0, True)
            AEV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)

            AEV_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 150)
            AEV_CPostal = New Cdatos.bdcampo(CodigoEntidad & "CPostal", Cdatos.TiposCampo.Cadena, 7)
            AEV_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 150)
            AEV_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 150)

            AEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select AEV_Idalmacen as IdAlmacen, AEV_Nombre as Nombre from almacenenvases"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idalmacen"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAlmacenenvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmAlmEnvases"

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select AEV_Idalmacen, AEV_Nombre from almacenenvases order by AEV_idalmacen")

        Return dt
    End Function

End Class
