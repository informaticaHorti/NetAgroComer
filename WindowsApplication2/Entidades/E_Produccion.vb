Public Class E_Produccion
    Inherits Cdatos.Entidad


    Public PRD_Id As Cdatos.bdcampo
    Public PRD_Fecha As Cdatos.bdcampo
    Public PRD_IdLinea As Cdatos.bdcampo
    Public PRD_IdCentro As Cdatos.bdcampo
    Public PRD_IdLineaEntrada As Cdatos.bdcampo
    Public PRD_IdLote As Cdatos.bdcampo
    Public PRD_KilosConsumidos As Cdatos.bdcampo
    Public PRD_KilosLinea As Cdatos.bdcampo
    Public PRD_HoraInicio As Cdatos.bdcampo
    Public PRD_HoraFinal As Cdatos.bdcampo
    Public PRD_IdLoteProduccion As Cdatos.bdcampo
    Public PRD_KilosDestrio As Cdatos.bdcampo
    Public PRD_HoraInicialCompleta As Cdatos.bdcampo
    Public PRD_HoraFinalCompleta As Cdatos.bdcampo

    Public PRD_IdUsuarioLog As Cdatos.bdcampo
    Public PRD_FechaLog As Cdatos.bdcampo
    Public PRD_HoraLog As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Generos As New E_Generos(idUsuario, cn)


        Try
            NombreTabla = "Produccion"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PRD_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PRD_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            PRD_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 4)
            PRD_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.EnteroPositivo, 2) ' es el punto de venta
            PRD_IdLineaEntrada = New Cdatos.bdcampo(CodigoEntidad & "IdLineaEntrada", Cdatos.TiposCampo.EnteroPositivo, 6)
            PRD_IdLote = New Cdatos.bdcampo(CodigoEntidad & "IdLote", Cdatos.TiposCampo.EnteroPositivo, 6)
            PRD_KilosConsumidos = New Cdatos.bdcampo(CodigoEntidad & "KilosConsumidos", Cdatos.TiposCampo.EnteroPositivo, 12)
            PRD_KilosLinea = New Cdatos.bdcampo(CodigoEntidad & "KilosLinea", Cdatos.TiposCampo.EnteroPositivo, 12)
            PRD_HoraInicio = New Cdatos.bdcampo(CodigoEntidad & "HoraInicio", Cdatos.TiposCampo.Cadena, 10)
            PRD_HoraFinal = New Cdatos.bdcampo(CodigoEntidad & "HoraFinal", Cdatos.TiposCampo.Cadena, 10)
            PRD_IdLoteProduccion = New Cdatos.bdcampo(CodigoEntidad & "IdLoteProduccion", Cdatos.TiposCampo.EnteroPositivo, 6)
            PRD_KilosDestrio = New Cdatos.bdcampo(CodigoEntidad & "KilosDestrio", Cdatos.TiposCampo.EnteroPositivo, 12)
            PRD_HoraInicialCompleta = New Cdatos.bdcampo(CodigoEntidad & "HoraInicialCompleta", Cdatos.TiposCampo.FechaHora, 19)
            PRD_HoraFinalCompleta = New Cdatos.bdcampo(CodigoEntidad & "HoraFinalCompleta", Cdatos.TiposCampo.FechaHora, 19)

            PRD_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PRD_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PRD_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim lineas As New E_Lineas(idUsuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(idUsuario, cn)
        Dim Lotes As New E_Lotes(idUsuario, cn)
        Dim LotesProduccion As New E_LotesProduccion(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PRD_Id, "id")
        consulta.SelCampo(Me.PRD_Fecha, "Fecha")
        consulta.SelCampo(Me.PRD_IdLinea, "Codigo")
        consulta.SelCampo(lineas.LIN_Nombre, "Linea", Me.PRD_IdLinea)
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", Me.PRD_IdLineaEntrada)
        consulta.SelCampo(Lotes.LTE_Lote, "Lote", Me.PRD_IdLote)
        consulta.SelCampo(LotesProduccion.LPD_Lote, "PreCalib", Me.PRD_IdLoteProduccion)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " ORDER BY Fecha DESC, Id DESC"




        _btBusca.Params("Idlote", , -1)
        _btBusca.Params("Partida", , 75)
        _btBusca.Params("Lote", , 75)
        _btBusca.Params("PreCalib", , 75)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = lineas.LIN_Idlinea
        _btBusca.CL_camponombre = lineas.LIN_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "ID"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaProduccion"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = False


    End Sub


    Public Function KilosDestrio_Partida(idpartida As Integer) As Decimal
        Dim ret As Decimal

        Dim sql As String = "Select sum(PRD_KilosDestrio) as Kdestrio from produccion where prd_idlineaentrada=" + idpartida.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("kdestrio"))
            End If

        End If

        Return ret

    End Function

    Public Function KilosDestrio_Lote(idlote As Integer) As Decimal
        Dim ret As Decimal

        Dim sql As String = "Select sum(PRD_KilosDestrio) as Kdestrio from produccion where prd_idlote=" + idlote.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("kdestrio"))
            End If

        End If

        Return ret

    End Function


    Public Function KilosDestrio_LoteProduccion(idlotep As Integer) As Decimal
        Dim ret As Decimal

        Dim sql As String = "Select sum(PRD_KilosDestrio) as Kdestrio from produccion where prd_idloteproduccion=" + idlotep.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("kdestrio"))
            End If

        End If

        Return ret

    End Function



End Class
