Public Class E_MotivosQueja
    Inherits Cdatos.Entidad

    Public MTQ_Id As Cdatos.bdcampo
    Public MTQ_Idorigen As Cdatos.bdcampo
    Public MTQ_Nombre As Cdatos.bdcampo

    Public MTQ_IdUsuarioLog As Cdatos.bdcampo
    Public MTQ_FechaLog As Cdatos.bdcampo
    Public MTQ_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "MotivosQueja"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            MTQ_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            MTQ_Idorigen = New Cdatos.bdcampo(CodigoEntidad & "IdOrigen", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            MTQ_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)

            MTQ_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            MTQ_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            MTQ_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT MTQ_Id as Id, MTQ_IdOrigen as IdOrigen, RCO_Nombre as Origen, MTQ_Nombre as Nombre" & vbCrLf
        sql = sql & " FROM MotivosQueja" & vbCrLf
        sql = sql & " LEFT JOIN Reclama_Origen ON RCO_IdOrigen = MTQ_IdOrigen" & vbCrLf
        sql = sql & " ORDER BY MTQ_Id" & vbCrLf


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaMotivoQueja"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
