Public Class E_ExistenciasTerceros

    Inherits Cdatos.Entidad

    Public EXT_idparte
    Public EXT_idcentro
    Public EXT_fechafinal As Cdatos.bdcampo
    Public EXT_fechainicial As Cdatos.bdcampo

    Public EXT_IdUsuarioLog As Cdatos.bdcampo
    Public EXT_FechaLog As Cdatos.bdcampo
    Public EXT_HoraLog As Cdatos.bdcampo




    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "existenciasterceros"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            EXT_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            EXT_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 2)
            EXT_fechafinal = New Cdatos.bdcampo(CodigoEntidad & "fechafinal", Cdatos.TiposCampo.Fecha, 10)
            EXT_fechainicial = New Cdatos.bdcampo(CodigoEntidad & "fechatarifa", Cdatos.TiposCampo.Fecha, 10)

            EXT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            EXT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            EXT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

 
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.EXT_idcentro, "Centro")
        consulta.SelCampo(Me.EXT_fechafinal, "FechaFinal")
        consulta.SelCampo(Me.EXT_fechainicial, "FechaInicial")


        _btBusca.CL_CampoOrden = "FechaFinal"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Codigo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaExiTerceros"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = False ' busqueda por codigo
        _btBusca.CL_campocodigo = Nothing
        _btBusca.CL_camponombre = Nothing



    End Sub



    Private Sub E_existenciasterceros_EliminaHijos() Handles Me.EliminaHijos


        Dim sql As String = "Delete from ExistenciasTercerosLineas where EXL_idparte=" + Me.EXT_idparte.Valor
        Me.MiConexion.OrdenSql(sql)


    End Sub

    Public Function LeerExis(idcentro As String, Fecha As String) As Integer
        Dim ret As Integer
        Dim sql As String = "Select EXT_idparte from existenciasterceros where EXT_idcentro=" + idcentro + " and EXT_fechafinal='" + Fecha + "'"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)(0))
            End If
        End If

        Return ret


    End Function


End Class
