Public Class E_Cmr
    Inherits Cdatos.Entidad

    Public CMR_IdCmr As Cdatos.bdcampo
    Public CMR_Campa As Cdatos.bdcampo
    Public CMR_Idcentro As Cdatos.bdcampo
    Public CMR_Albaran As Cdatos.bdcampo
    Public CMR_FechaSalida As Cdatos.bdcampo
    Public CMR_Idcliente As Cdatos.bdcampo
    Public CMR_Iddestino As Cdatos.bdcampo
    Public CMR_DocAnexos1 As Cdatos.bdcampo
    Public CMR_DocAnexos2 As Cdatos.bdcampo
    Public CMR_Instrucciones1 As Cdatos.bdcampo
    Public CMR_Instrucciones2 As Cdatos.bdcampo
    Public CMR_Instrucciones3 As Cdatos.bdcampo
    Public CMR_Instrucciones4 As Cdatos.bdcampo
    Public CMR_tipodoc As Cdatos.bdcampo
    Public CMR_Observaciones As Cdatos.bdcampo
    Public CMR_OD As Cdatos.bdcampo

    Public CMR_IdUsuarioLog As Cdatos.bdcampo
    Public CMR_FechaLog As Cdatos.bdcampo
    Public CMR_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "cmr"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CMR_IdCmr = New Cdatos.bdcampo(CodigoEntidad & "idcmr", Cdatos.TiposCampo.Entero, 8, 0, True)
            CMR_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            CMR_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            CMR_Albaran = New Cdatos.bdcampo(CodigoEntidad & "albaran", Cdatos.TiposCampo.Entero, 8)
            CMR_fechasalida = New Cdatos.bdcampo(CodigoEntidad & "fechasalida", Cdatos.TiposCampo.Fecha, 10)
            CMR_Idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.Entero, 5)
            CMR_Iddestino = New Cdatos.bdcampo(CodigoEntidad & "iddestino", Cdatos.TiposCampo.Entero, 5)
            CMR_DocAnexos1 = New Cdatos.bdcampo(CodigoEntidad & "DocAnexos1", Cdatos.TiposCampo.Cadena, 50)
            CMR_DocAnexos2 = New Cdatos.bdcampo(CodigoEntidad & "DocAnexos2", Cdatos.TiposCampo.Cadena, 50)
            CMR_Instrucciones1 = New Cdatos.bdcampo(CodigoEntidad & "Instrucciones1", Cdatos.TiposCampo.Cadena, 50)
            CMR_Instrucciones2 = New Cdatos.bdcampo(CodigoEntidad & "Instrucciones2", Cdatos.TiposCampo.Cadena, 50)
            CMR_Instrucciones3 = New Cdatos.bdcampo(CodigoEntidad & "Instrucciones3", Cdatos.TiposCampo.Cadena, 50)
            CMR_Instrucciones4 = New Cdatos.bdcampo(CodigoEntidad & "Instrucciones4", Cdatos.TiposCampo.Cadena, 50)
            CMR_tipodoc = New Cdatos.bdcampo(CodigoEntidad & "tipodoc", Cdatos.TiposCampo.Cadena, 1)
            CMR_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 50)
            CMR_OD = New Cdatos.bdcampo(CodigoEntidad & "OD", Cdatos.TiposCampo.Cadena, 1)

            CMR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CMR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CMR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "CMR"

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Clientes As New E_Clientes(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.CMR_IdCmr, "Idcmr")
        consulta.SelCampo(Me.CMR_Campa, "Campa")
        consulta.SelCampo(Me.CMR_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.CMR_Idcentro)
        consulta.SelCampo(Me.CMR_Albaran, "albaran")
        consulta.SelCampo(Me.CMR_FechaSalida, "Fecha")
        consulta.SelCampo(Me.CMR_Idcliente, "Codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Nombre", Me.CMR_Idcliente)

        _btBusca.Params("IdCentro", , -1)
        _btBusca.Params("Idalb", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idcmr"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCmr"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)


    End Sub

    Public Function LeerCmr(ByVal Campa As Integer, ByVal Centro As Integer, ByVal albaran As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.CMR_Campa, "=", Campa.ToString)
        ' CONSULTA.WheCampo(Me.CMR_Idcentro, "=", Centro.ToString)
        CONSULTA.WheCampo(Me.CMR_Albaran, "=", albaran.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                    CargaCampos(Dt.Rows(0))
                End If
            End If
        End If
        Return ret
    End Function



    Private Sub E_Almmaterial_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from cmr_lineas where cml_idcmr = " + Me.CMR_IdCmr.Valor
        MiConexion.OrdenSql(sql)

    End Sub



End Class
