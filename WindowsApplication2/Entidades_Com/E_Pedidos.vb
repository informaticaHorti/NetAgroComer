Public Class E_Pedidos
    Inherits Cdatos.Entidad

    Public PED_idpedido As Cdatos.bdcampo
    Public PED_ejercicio As Cdatos.bdcampo
    Public PED_idpuntoventa As Cdatos.bdcampo
    Public PED_idcentro As Cdatos.bdcampo
    Public PED_pedido As Cdatos.bdcampo
    Public PED_fechasalida As Cdatos.bdcampo
    Public PED_fechapedido As Cdatos.bdcampo
    Public PED_idcliente As Cdatos.bdcampo
    Public PED_iddestino As Cdatos.bdcampo
    Public PED_referencia As Cdatos.bdcampo
    Public PED_idporte As Cdatos.bdcampo
    Public PED_idtransportista As Cdatos.bdcampo
    Public PED_matriculacamion As Cdatos.bdcampo
    Public PED_matricularemolque As Cdatos.bdcampo
    Public PED_iddivisa As Cdatos.bdcampo
    Public PED_valorcambio As Cdatos.bdcampo
    Public PED_obs1 As Cdatos.bdcampo
    Public PED_obs2 As Cdatos.bdcampo
    Public PED_obs3 As Cdatos.bdcampo
    Public PED_obs4 As Cdatos.bdcampo
    Public PED_FechaLlegada As Cdatos.bdcampo
    Public PED_BESTELLNR As Cdatos.bdcampo
    Public PED_MovilChofer As Cdatos.bdcampo
    Public PED_TransporteRapidoSN As Cdatos.bdcampo

    Public PED_IdUsuarioLog As Cdatos.bdcampo
    Public PED_FechaLog As Cdatos.bdcampo
    Public PED_HoraLog As Cdatos.bdcampo


    Public Clientes As New E_Clientes(Idusuario, cn)

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)
        Try
            NombreTabla = "Pedidos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PED_idpedido = New Cdatos.bdcampo(CodigoEntidad & "idpedido", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PED_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "ejercicio", Cdatos.TiposCampo.EnteroPositivo, 2)
            PED_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 3)
            PED_idpuntoventa = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.EnteroPositivo, 3)
            PED_pedido = New Cdatos.bdcampo(CodigoEntidad & "pedido", Cdatos.TiposCampo.EnteroPositivo, 6)
            PED_fechasalida = New Cdatos.bdcampo(CodigoEntidad & "fechasalida", Cdatos.TiposCampo.Fecha, 10)
            PED_fechapedido = New Cdatos.bdcampo(CodigoEntidad & "fechapedido", Cdatos.TiposCampo.Fecha, 10)
            PED_idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            PED_iddestino = New Cdatos.bdcampo(CodigoEntidad & "iddestino", Cdatos.TiposCampo.EnteroPositivo, 5)
            PED_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 50)
            PED_idporte = New Cdatos.bdcampo(CodigoEntidad & "idporte", Cdatos.TiposCampo.EnteroPositivo, 2)
            PED_idtransportista = New Cdatos.bdcampo(CodigoEntidad & "idtransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            PED_matriculacamion = New Cdatos.bdcampo(CodigoEntidad & "matriculacamion", Cdatos.TiposCampo.Cadena, 20)
            PED_matricularemolque = New Cdatos.bdcampo(CodigoEntidad & "matricularemolque", Cdatos.TiposCampo.Cadena, 20)
            PED_iddivisa = New Cdatos.bdcampo(CodigoEntidad & "iddivisa", Cdatos.TiposCampo.EnteroPositivo, 3)
            PED_valorcambio = New Cdatos.bdcampo(CodigoEntidad & "valorcambio", Cdatos.TiposCampo.Importe, 12, 4)
            PED_obs1 = New Cdatos.bdcampo(CodigoEntidad & "obs1", Cdatos.TiposCampo.Cadena, 50)
            PED_obs2 = New Cdatos.bdcampo(CodigoEntidad & "obs2", Cdatos.TiposCampo.Cadena, 50)
            PED_obs3 = New Cdatos.bdcampo(CodigoEntidad & "obs3", Cdatos.TiposCampo.Cadena, 50)
            PED_obs4 = New Cdatos.bdcampo(CodigoEntidad & "obs4", Cdatos.TiposCampo.Cadena, 50)
            PED_FechaLlegada = New Cdatos.bdcampo(CodigoEntidad & "FechaLlegada", Cdatos.TiposCampo.Fecha, 10)
            PED_BESTELLNR = New Cdatos.bdcampo(CodigoEntidad & "BESTELLNR", Cdatos.TiposCampo.Cadena, 16)
            PED_MovilChofer = New Cdatos.bdcampo(CodigoEntidad & "MovilChofer", Cdatos.TiposCampo.Cadena, 12)

            PED_TransporteRapidoSN = New Cdatos.bdcampo(CodigoEntidad & "TransporteRapidoSN", Cdatos.TiposCampo.Cadena, 1)

            PED_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PED_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PED_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.PED_pedido)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Pedido"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PED_idpedido, "IdPedido")
        consulta.SelCampo(Me.PED_pedido, "Pedido")
        consulta.SelCampo(Me.PED_fechasalida, "Fecha")
        consulta.SelCampo(Me.PED_ejercicio, "Ejercicio")
        consulta.SelCampo(Me.PED_idcliente, "Codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Nombre", Me.PED_idcliente)
        consulta.SelCampo(Me.PED_referencia, "Referencia")
        consulta.WheCampo(Me.PED_idcentro, "=", MiMaletin.IdCentro.ToString)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " ORDER BY PED_fechasalida DESC"



        _btBusca.Params("IdPedido", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio
        _btBusca.CL_Filtro = "PED_IdCentro = " & MiMaletin.IdCentro.ToString

        '_btBusca.CL_CampoOrden = "Nombre"
        '_btBusca.CL_CampoOrden = "Fecha DESC"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdPedido"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaPedido"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)

    End Sub


    Public Function LeerPedido(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Numpedido As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PED_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PED_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PED_pedido, "=", Numpedido.ToString)

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


    Public Function ExistePedido(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Numpedido As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PED_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PED_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PED_pedido, "=", Numpedido.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                End If
            End If
        End If


        Return ret

    End Function


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)

                End If

                existe = ExistePedido(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de pedidos", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Public Function PedidosPteCarga(FechaSalida As String) As DataTable
        Dim ret As New DataTable

        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim Transportistas As New E_Transportistas(Idusuario, cn)
        Dim Albsalida As New E_AlbSalida(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PED_idpedido, "idpedido")
        consulta.SelCampo(Me.PED_pedido, "Pedido")
        consulta.SelCampo(Me.PED_fechasalida, "FechaSalida")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.PED_idcliente)
        consulta.SelCampo(Me.PED_referencia, "Referencia")
        consulta.SelCampo(Me.PED_matriculacamion, "Matricula")
        consulta.SelCampo(Transportistas.TTA_Nombre, "Transportista", Me.PED_idtransportista)
        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Me.PED_idpedido, Albsalida.ASA_idpedido)
        consulta.WheCampo(Me.PED_fechasalida, ">=", FechaSalida)
        Dim SQL As String = consulta.SQL
        ret = Me.MiConexion.ConsultaSQL(SQL)
        If Not ret Is Nothing Then
            ret.Columns.Add("Palets", GetType(Decimal))
            For Each rw In ret.Rows
                rw("Palets") = PaletsPedidos(VaInt(rw("idpedido")))
                If VaInt(rw("albaran")) = 0 Then
                    rw("albaran") = 0
                End If
            Next
        End If

        Dim dv As New DataView(ret)
        dv.RowFilter = "Albaran = 0"

        Return dv.ToTable

    End Function


    Private Function PaletsPedidos(idpedido As Integer) As Decimal
        Dim ret As Decimal = 0

        Dim sql As String = "Select sum(PEL_PALETS) as palets from pedidos_lineas where pel_idpedido=" + idpedido.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            ret = VaDec(dt.Rows(0)("palets"))
        End If


        Return ret

    End Function


    Private Sub E_Pedidos_EliminaHijos() Handles Me.EliminaHijos

        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)

        Dim sql As String = "SELECT * FROM Pedidos_Lineas WHERE PEL_IdPedido = " & Me.PED_idpedido.Valor

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                Pedidos_Lineas.CargaCampos(rw)
                Pedidos_Lineas.Eliminar()
            Next
        End If

    End Sub



    Public Function ObtenerKilosBrutos(KilosNetos As Decimal, Bultos As Integer, IdConfecEnvase As String, IdConfecPalet As String) As Decimal

        Dim Brutos As Decimal = KilosNetos


        If VaInt(IdConfecPalet) > 0 Then
            Brutos = Brutos + ObtenerTaraPalet(IdConfecPalet)
        End If


        If VaInt(IdConfecEnvase) > 0 Then

            Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
            If ConfecEnvase.LeerId(IdConfecEnvase) Then

                Dim TaraLinea As Decimal = VaDec(ConfecEnvase.CEV_TotalTara.Valor) * Bultos
                Brutos = Brutos + TaraLinea

            End If

        End If




        Return Brutos

    End Function



    Private Function ObtenerTaraPalet(IdConfecPalet As String) As Decimal

        Dim TotalTara As Decimal = 0


        If VaInt(IdConfecPalet) > 0 Then

            Dim sql As String = "SELECT SUM(Tara) AS TotalTara" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT CPA_IncrementoTara as Tara " & vbCrLf
            sql = sql & " FROM Confecpalet" & vbCrLf
            sql = sql & " WHERE CPA_IdConfec = " & IdConfecPalet & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT COALESCE(CPL_Cantidad,0) * COALESCE(ENV_TaraSalida,0) as Tara" & vbCrLf
            sql = sql & " FROM ConfecPaletLineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
            sql = sql & " WHERE CPL_IdConfec = " & IdConfecPalet & vbCrLf
            sql = sql & " ) AS T" & vbCrLf

            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    'TotalTara = Math.Round(VaDec(dt.Rows(0)("TotalTara")), 2)
                    TotalTara = VaDec(dt.Rows(0)("TotalTara"))
                End If
            End If


        End If


        Return TotalTara

    End Function


End Class
