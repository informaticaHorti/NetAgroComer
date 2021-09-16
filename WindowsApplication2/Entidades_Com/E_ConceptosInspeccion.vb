Public Class E_ConceptosInspeccion
    Inherits Cdatos.Entidad

    Public CIS_Id As Cdatos.bdcampo
    Public CIS_Nombre As Cdatos.bdcampo
    Public CIS_sn As Cdatos.bdcampo

    Public CIS_IdUsuarioLog As Cdatos.bdcampo
    Public CIS_FechaLog As Cdatos.bdcampo
    Public CIS_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ConceptosInspeccion"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CIS_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            CIS_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50, 0)
            CIS_sn = New Cdatos.bdcampo(CodigoEntidad & "SN", Cdatos.TiposCampo.Cadena, 1, 0)

            CIS_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CIS_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CIS_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT CIS_Id as Id, CIS_Nombre as Nombre" & vbCrLf
        sql = sql & " FROM ConceptosInspeccion" & vbCrLf
        sql = sql & " ORDER BY CIS_Id" & vbCrLf


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCaconcepinsp"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
