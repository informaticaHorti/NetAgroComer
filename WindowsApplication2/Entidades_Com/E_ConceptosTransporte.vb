Public Class E_ConceptosTransporte
    Inherits Cdatos.Entidad

    Public CTR_Id As Cdatos.bdcampo
    Public CTR_Nombre As Cdatos.bdcampo
    Public CTR_Reparto As Cdatos.bdcampo

    Public CTR_IdUsuarioLog As Cdatos.bdcampo
    Public CTR_FechaLog As Cdatos.bdcampo
    Public CTR_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ConceptosTransporte"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CTR_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            CTR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50, 0)
            CTR_Reparto = New Cdatos.bdcampo(CodigoEntidad & "Reparto", Cdatos.TiposCampo.Cadena, 1)

            CTR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CTR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CTR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT CTR_Id as Id, CTR_Nombre as Nombre" & vbCrLf
        sql = sql & " FROM ConceptosTransporte" & vbCrLf
        sql = sql & " ORDER BY CTR_Id" & vbCrLf


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaConceptosTra"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
