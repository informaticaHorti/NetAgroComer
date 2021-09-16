Public Class TipoVale
    Public Const Devoluciones As String = "DV"
    Public Const AlbaranCompra As String = "AC"
    Public Const EntradaBascula As String = "EB"
    Public Const AlbaranSalidaComercio_Retornable As String = "SC"
    Public Const AlbaranSalidaComercio_Material As String = "SM"
    Public Const RetornoInventariables As String = "RI"
    Public Const AlbaranSalidaAlhondiga As String = "SA"
    Public Const TraspasoOrigen As String = "TO"
    Public Const TraspasoDestino As String = "TD"
    Public Const Cliente As String = "CC"
    Public Const Agricultor As String = "AA"
    Public Const VentaTerceros As String = "VT"
    Public Const BajasConsumo As String = "BC"
    Public Const ConsumoMateriales As String = "CN"
End Class


Public Class E_ValeEnvases
    Inherits Cdatos.Entidad

    Public VEV_Idvale As Cdatos.bdcampo
    Public VEV_Operacion As Cdatos.bdcampo
    Public VEV_Campa As Cdatos.bdcampo
    Public VEV_Idcentro As Cdatos.bdcampo
    Public VEV_Numero As Cdatos.bdcampo
    Public VEV_Fecha As Cdatos.bdcampo
    Public VEV_IdAlmacen As Cdatos.bdcampo
    Public VEV_IdConcepto As Cdatos.bdcampo
    Public VEV_Concepto As Cdatos.bdcampo
    Public VEV_TipoSujeto As Cdatos.bdcampo
    Public VEV_Codigo As Cdatos.bdcampo
    Public VEV_Referencia As Cdatos.bdcampo
    Public VEV_idfactura As Cdatos.bdcampo
    Public VEV_IdTransportista As Cdatos.bdcampo
    Public VEV_Matricula As Cdatos.bdcampo
    Public VEV_Tractora As Cdatos.bdcampo

    Public VEV_IdUsuarioLog As Cdatos.bdcampo
    Public VEV_FechaLog As Cdatos.bdcampo
    Public VEV_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValeEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VEV_Idvale = New Cdatos.bdcampo(CodigoEntidad & "idvale", Cdatos.TiposCampo.Entero, 8, 0, True)
            VEV_Operacion = New Cdatos.bdcampo(CodigoEntidad & "operacion", Cdatos.TiposCampo.Cadena, 2)
            VEV_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            VEV_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            VEV_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            VEV_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            VEV_IdAlmacen = New Cdatos.bdcampo(CodigoEntidad & "idalmacen", Cdatos.TiposCampo.Entero, 3)
            VEV_IdConcepto = New Cdatos.bdcampo(CodigoEntidad & "idconcepto", Cdatos.TiposCampo.Entero, 3)
            VEV_Concepto = New Cdatos.bdcampo(CodigoEntidad & "concepto", Cdatos.TiposCampo.Cadena, 30)
            VEV_TipoSujeto = New Cdatos.bdcampo(CodigoEntidad & "tiposujeto", Cdatos.TiposCampo.Cadena, 1)
            VEV_Codigo = New Cdatos.bdcampo(CodigoEntidad & "codigo", Cdatos.TiposCampo.Entero, 5)
            VEV_Referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 50)
            VEV_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.Entero, 8)
            VEV_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            VEV_Matricula = New Cdatos.bdcampo(CodigoEntidad & "Matricula", Cdatos.TiposCampo.Cadena, 20)
            VEV_Tractora = New Cdatos.bdcampo(CodigoEntidad & "Tractora", Cdatos.TiposCampo.Cadena, 20)

            VEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.VEV_Numero)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Vale de Envases"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(idUsuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.VEV_Idvale, "IdVale")
        consulta.SelCampo(Me.VEV_Operacion, "Operacion")
        consulta.SelCampo(Me.VEV_Codigo, "Codigo")
        consulta.SelCampo(Me.VEV_Campa, "Campa")
        consulta.SelCampo(Me.VEV_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.VEV_Idcentro, Centros.IdCentro)
        consulta.SelCampo(Me.VEV_Numero, "Numero")
        consulta.SelCampo(Me.VEV_Fecha, "Fecha")

        _btBusca.Params("IdCentro", , -1)


        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdVale"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValeEnvases"
        _btBusca.CL_ch1000 = False



        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Nothing
        _btBusca.CL_camponombre = Nothing
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


    End Sub

    Public Function LeerVale(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Oper As String, ByVal numvale As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VEV_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.VEV_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.VEV_Numero, "=", numvale.ToString)
        CONSULTA.WheCampo(Me.VEV_Operacion, "=", Oper)

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


    Public Function ExisteVale(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Oper As String, ByVal numvale As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VEV_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.VEV_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.VEV_Numero, "=", numvale.ToString)
        CONSULTA.WheCampo(Me.VEV_Operacion, "=", Oper)

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


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, ByVal oper As String, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString + "_" + oper, vmax)
                Else
                    max = ValorMaximo(Campa.ToString + "_" + "00" + "_" + oper, vmax)

                End If
                existe = ExisteVale(Campa, Centro, oper, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de envases", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Private Sub E_ValeEnvases_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from valeenvases_lineas where VEL_idvale=" + Me.VEV_Idvale.Valor
        MiConexion.OrdenSql(sql)
    End Sub


    Public Function LineasFacturadas(IdVale As String) As Boolean

        Dim bRes As Boolean = False

        If VaDec(IdVale) > 0 Then

            Dim sql As String = "SELECT Count(VEL_Id) as Cont FROM ValeEnvases_Lineas WHERE VEL_IdFacturaEnvase > 0 AND VEL_IdVale = " & IdVale
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    If VaInt(row("Cont")) > 0 Then
                        bRes = True
                    End If
                End If
            End If

        End If


        Return bRes

    End Function





    Public Function SaldoEnvases(ByVal Tipo As String, ByVal bMarcas As Boolean, ByVal FechaDesde As String, ByVal FechaHasta As String,
                             ByVal CodDesde As String, ByVal CodHasta As String, ByVal EnvDesde As String, ByVal EnvHasta As String,
                             Optional lstAlmacenes As List(Of String) = Nothing) As String




        Dim sqlWhere As String = " WHERE VEV_TipoSujeto = '" & Tipo & "'" & vbCrLf
        If VaInt(CodDesde) > 0 Then sqlWhere = sqlWhere & " AND VEV_Codigo >= " & CodDesde & vbCrLf
        If VaInt(CodHasta) > 0 Then sqlWhere = sqlWhere & " AND VEV_Codigo <= " & CodHasta & vbCrLf
        If VaInt(EnvDesde) > 0 Then sqlWhere = sqlWhere & " AND VEL_IdEnvase >= " & EnvDesde & vbCrLf
        If VaInt(EnvHasta) > 0 Then sqlWhere = sqlWhere & " AND VEL_IdEnvase <= " & EnvHasta & vbCrLf

        Dim sqlWhereFecha As String = ""
        If FechaDesde.Trim <> "" Then sqlWhereFecha = sqlWhereFecha & " AND VEV_Fecha >= '" & FechaDesde & "'" & vbCrLf
        If FechaHasta.Trim <> "" Then sqlWhereFecha = sqlWhereFecha & " AND VEV_Fecha <= '" & FechaHasta & "'" & vbCrLf



        Dim sqlWhereFecha2 As String = ""
        sqlWhereFecha2 = sqlWhereFecha2 & " AND VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        If FechaDesde.Trim <> "" Then sqlWhereFecha2 = sqlWhereFecha2 & " AND VEV_Fecha < '" & FechaDesde & "'" & vbCrLf



        Dim Pref As String = ""
        If Tipo = "C" Then
            Pref = "CLI_"
        ElseIf Tipo = "A" Then
            Pref = "AGR_"
        End If



        If bMarcas Then

            Dim sqlBase As String = "SELECT VEV_TipoSujeto as Tipo, VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase, " & vbCrLf
            sqlBase = sqlBase & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
            sqlBase = sqlBase & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
            sqlBase = sqlBase & " VEL_Retira as Retira, VEL_Entrega as Entrega, VEL_Retira as RetiraValorado, VEL_Entrega as EntregaValorado," & vbCrLf
            sqlBase = sqlBase & " VEL_PrecioRetira as PrecioRetira, VEL_PrecioEntrega as PrecioEntrega," & vbCrLf
            sqlBase = sqlBase & " 0 as Inicial, 0 AS InicialValorado" & vbCrLf
            sqlBase = sqlBase & " FROM ValeEnvases VE" & vbCrLf
            sqlBase = sqlBase & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
            If Tipo = "A" Then
                sqlBase = sqlBase & " LEFT JOIN Agricultores A ON VEV_Codigo = AGR_IdAgricultor" & vbCrLf
            ElseIf Tipo = "C" Then
                sqlBase = sqlBase & " LEFT JOIN Clientes A ON VEV_Codigo = CLI_IdCliente" & vbCrLf
            End If
            sqlBase = sqlBase & " LEFT JOIN Envases E ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sqlBase = sqlBase & " LEFT JOIN Marcas ON VEL_IdMarca = MAR_IdMarca" & vbCrLf
            sqlBase = sqlBase & sqlWhere & sqlWhereFecha
            If Not IsNothing(lstAlmacenes) Then
                If lstAlmacenes.Count > 0 Then
                    If sqlWhere = "" And sqlWhereFecha = "" Then
                        sqlBase = sqlBase & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " WHERE ") & vbCrLf
                    Else
                        sqlBase = sqlBase & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " AND ") & vbCrLf
                    End If
                End If
            End If




            Dim sqlInicial2 As String = "SELECT VEV_TipoSujeto as Tipo, VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase, " & vbCrLf
            sqlInicial2 = sqlInicial2 & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
            sqlInicial2 = sqlInicial2 & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
            sqlInicial2 = sqlInicial2 & " COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0) as Inicial2," & vbCrLf
            sqlInicial2 = sqlInicial2 & " (COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0)) as Inicial2Valorado," & vbCrLf
            sqlInicial2 = sqlInicial2 & " COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0) as Precio" & vbCrLf
            sqlInicial2 = sqlInicial2 & " FROM ValeEnvases VE" & vbCrLf
            sqlInicial2 = sqlInicial2 & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
            If Tipo = "A" Then
                sqlInicial2 = sqlInicial2 & " LEFT JOIN Agricultores A ON VEV_Codigo = AGR_IdAgricultor" & vbCrLf
            ElseIf Tipo = "C" Then
                sqlInicial2 = sqlInicial2 & " LEFT JOIN Clientes A ON VEV_Codigo = CLI_IdCliente" & vbCrLf
            End If
            sqlInicial2 = sqlInicial2 & " LEFT JOIN Envases E ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sqlInicial2 = sqlInicial2 & " LEFT JOIN Marcas ON VEL_IdMarca = MAR_IdMarca" & vbCrLf
            sqlInicial2 = sqlInicial2 & sqlWhere & sqlWhereFecha2
            If Not IsNothing(lstAlmacenes) Then
                If lstAlmacenes.Count > 0 Then
                    If sqlWhere = "" And sqlWhereFecha2 = "" Then
                        sqlInicial2 = sqlInicial2 & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " WHERE ") & vbCrLf
                    Else
                        sqlInicial2 = sqlInicial2 & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " AND ") & vbCrLf
                    End If
                End If
            End If




            Dim sqlInicial As String = ""

            If Tipo = "A" Then
                sqlInicial = sqlInicial & " SELECT 'A' as Tipo, " & vbCrLf
                sqlInicial = sqlInicial & " ENI_Codigo as Codigo, AGR_Nombre as Nombre, " & vbCrLf
                sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase," & vbCrLf
                sqlInicial = sqlInicial & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
                sqlInicial = sqlInicial & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
                sqlInicial = sqlInicial & " ENI_Inicial as Inicial, ENI_Precio as Precio" & vbCrLf
                sqlInicial = sqlInicial & " FROM EnvasesInicial" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Agricultores ON AGR_IdAgricultor = ENI_Codigo" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Marcas ON ENI_IdMarca = MAR_IdMarca" & vbCrLf
                sqlInicial = sqlInicial & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & vbCrLf
                sqlInicial = sqlInicial & " AND ENI_Tipo = 'AG'" & vbCrLf
                If VaInt(CodDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo >= " & CodDesde & vbCrLf
                If VaInt(CodHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo <= " & CodHasta & vbCrLf
                If VaInt(EnvDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase >= " & EnvDesde & vbCrLf
                If VaInt(EnvHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase <= " & EnvHasta & vbCrLf

            ElseIf Tipo = "C" Then
                sqlInicial = sqlInicial & " SELECT 'C' as Tipo, " & vbCrLf
                sqlInicial = sqlInicial & " ENI_Codigo as Codigo, CLI_Nombre as Nombre, " & vbCrLf
                sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase," & vbCrLf
                sqlInicial = sqlInicial & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
                sqlInicial = sqlInicial & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
                sqlInicial = sqlInicial & " ENI_Inicial as Inicial, ENI_Precio as Precio" & vbCrLf
                sqlInicial = sqlInicial & " FROM EnvasesInicial" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Clientes ON CLI_IdCliente = ENI_Codigo" & vbCrLf
                sqlInicial = sqlInicial & " LEFT JOIN Marcas ON ENI_IdMarca = MAR_IdMarca" & vbCrLf
                sqlInicial = sqlInicial & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & vbCrLf
                sqlInicial = sqlInicial & " AND ENI_Tipo = 'CL'" & vbCrLf
                If VaInt(CodDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo >= " & CodDesde & vbCrLf
                If VaInt(CodHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo <= " & CodHasta & vbCrLf
                If VaInt(EnvDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase >= " & EnvDesde & vbCrLf
                If VaInt(EnvHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase <= " & EnvHasta & vbCrLf
            End If


            Dim sql As String = "SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase & vbCrLf
            sql = sql & " ) AS R" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioRetira, 0) = 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS RV" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioRetira, 0) <> 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS E" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioEntrega, 0) = 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS E" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioEntrega, 0) <> 0" & vbCrLf



            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial
            sql = sql & " ) AS I" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 as Inicial, Inicial AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial
            sql = sql & " ) AS IV" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf


            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " Inicial2 as Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial2
            sql = sql & " ) AS I2" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 as Inicial, Inicial2Valorado AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial2
            sql = sql & " ) AS I2V" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf





            sql = "SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca," & vbCrLf & _
                " Sum(Inicial) as Inicial," & vbCrLf & _
                " Sum(Retira) AS Retira, Sum(Entrega) AS Entrega," & vbCrLf & _
                " Sum(Inicial + Retira - Entrega) as Saldo," & vbCrLf & _
                " Sum(InicialValorado) as InicialValorado," & vbCrLf & _
                " Sum(RetiraValorado) as RetiraValorado, Sum(EntregaValorado) as EntregaValorado," & vbCrLf & _
                " Sum(InicialValorado + RetiraValorado - EntregaValorado) as SaldoValorado" & vbCrLf & _
                " FROM (" & sql & vbCrLf & _
                " ) AS G" & vbCrLf & _
                " GROUP BY Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, IdMarca, Marca" & vbCrLf

            Return sql

        Else

            Dim sqlBase As String = "SELECT VEV_TipoSujeto as Tipo, VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase, " & vbCrLf
            sqlBase = sqlBase & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
            sqlBase = sqlBase & " VEL_Retira as Retira, VEL_Entrega as Entrega, VEL_Retira as RetiraValorado, VEL_Entrega as EntregaValorado," & vbCrLf
            sqlBase = sqlBase & " VEL_PrecioRetira as PrecioRetira, VEL_PrecioEntrega as PrecioEntrega," & vbCrLf
            sqlBase = sqlBase & " 0 as Inicial, 0 AS InicialValorado" & vbCrLf
            sqlBase = sqlBase & " FROM ValeEnvases VE" & vbCrLf
            sqlBase = sqlBase & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
            If Tipo = "A" Then
                sqlBase = sqlBase & " LEFT JOIN Agricultores A ON VEV_Codigo = AGR_IdAgricultor" & vbCrLf
            ElseIf Tipo = "C" Then
                sqlBase = sqlBase & " LEFT JOIN Clientes A ON VEV_Codigo = CLI_IdCliente" & vbCrLf
            End If
            sqlBase = sqlBase & " LEFT JOIN Envases E ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sqlBase = sqlBase & sqlWhere & sqlWhereFecha
            If Not IsNothing(lstAlmacenes) Then
                If lstAlmacenes.Count > 0 Then
                    If sqlWhere = "" And sqlWhereFecha = "" Then
                        sqlBase = sqlBase & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " WHERE ")
                    Else
                        sqlBase = sqlBase & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " AND ")
                    End If
                End If
            End If




            Dim sqlInicial2 As String = "SELECT VEV_TipoSujeto as Tipo, VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase, " & vbCrLf
            sqlInicial2 = sqlInicial2 & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
            sqlInicial2 = sqlInicial2 & " COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0) as Inicial2," & vbCrLf
            sqlInicial2 = sqlInicial2 & " (COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0)) as Inicial2Valorado," & vbCrLf
            sqlInicial2 = sqlInicial2 & " COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0) as Precio" & vbCrLf
            sqlInicial2 = sqlInicial2 & " FROM ValeEnvases VE" & vbCrLf
            sqlInicial2 = sqlInicial2 & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
            If Tipo = "A" Then
                sqlInicial2 = sqlInicial2 & " LEFT JOIN Agricultores A ON VEV_Codigo = AGR_IdAgricultor" & vbCrLf
            ElseIf Tipo = "C" Then
                sqlInicial2 = sqlInicial2 & " LEFT JOIN Clientes A ON VEV_Codigo = CLI_IdCliente" & vbCrLf
            End If
            sqlInicial2 = sqlInicial2 & " LEFT JOIN Envases E ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sqlInicial2 = sqlInicial2 & sqlWhere & sqlWhereFecha2
            If Not IsNothing(lstAlmacenes) Then
                If lstAlmacenes.Count > 0 Then
                    If sqlWhere = "" And sqlWhereFecha2 = "" Then
                        sqlInicial2 = sqlInicial2 & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " WHERE ")
                    Else
                        sqlInicial2 = sqlInicial2 & CadenaWhereLista(Me.VEV_IdAlmacen, lstAlmacenes, " AND ")
                    End If
                End If
            End If




            Dim sqlInicial As String = ""

            If Tipo = "A" Then
                sqlInicial = sqlInicial & " SELECT 'A' as Tipo, "
                sqlInicial = sqlInicial & " ENI_Codigo as Codigo, AGR_Nombre as Nombre, "
                sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase,"
                sqlInicial = sqlInicial & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
                sqlInicial = sqlInicial & " ENI_Inicial as Inicial, ENI_Precio as Precio"
                sqlInicial = sqlInicial & " FROM EnvasesInicial"
                sqlInicial = sqlInicial & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase"
                sqlInicial = sqlInicial & " LEFT JOIN Agricultores ON AGR_IdAgricultor = ENI_Codigo"
                sqlInicial = sqlInicial & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString
                sqlInicial = sqlInicial & " AND ENI_Tipo = 'AG'"
                If VaInt(CodDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo >= " & CodDesde & vbCrLf
                If VaInt(CodHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo <= " & CodHasta & vbCrLf
                If VaInt(EnvDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase >= " & EnvDesde & vbCrLf
                If VaInt(EnvHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase <= " & EnvHasta & vbCrLf

            ElseIf Tipo = "C" Then
                sqlInicial = sqlInicial & " SELECT 'C' as Tipo, "
                sqlInicial = sqlInicial & " ENI_Codigo as Codigo, CLI_Nombre as Nombre, "
                sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as NombreEnvase,"
                sqlInicial = sqlInicial & " ENV_Tipo as TipoEnv, ENV_Retornable as Ret," & vbCrLf
                sqlInicial = sqlInicial & " ENI_Inicial as Inicial, ENI_Precio as Precio"
                sqlInicial = sqlInicial & " FROM EnvasesInicial"
                sqlInicial = sqlInicial & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase"
                sqlInicial = sqlInicial & " LEFT JOIN Clientes ON CLI_IdCliente = ENI_Codigo"
                sqlInicial = sqlInicial & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString
                sqlInicial = sqlInicial & " AND ENI_Tipo = 'CL'"
                If VaInt(CodDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo >= " & CodDesde & vbCrLf
                If VaInt(CodHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_Codigo <= " & CodHasta & vbCrLf
                If VaInt(EnvDesde) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase >= " & EnvDesde & vbCrLf
                If VaInt(EnvHasta) > 0 Then sqlInicial = sqlInicial & " AND ENI_IdEnvase <= " & EnvHasta & vbCrLf
            End If


            Dim sql As String = "SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase & vbCrLf
            sql = sql & " ) AS R" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioRetira, 0) = 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS RV" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioRetira, 0) <> 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS E" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioEntrega, 0) = 0" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 AS Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlBase
            sql = sql & " ) AS E" & vbCrLf
            sql = sql & " WHERE COALESCE(PrecioEntrega, 0) <> 0" & vbCrLf



            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial
            sql = sql & " ) AS I" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 as Inicial, Inicial AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial
            sql = sql & " ) AS IV" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf


            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " Inicial2 as Inicial, 0 AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial2
            sql = sql & " ) AS I2" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, 0 AS Retira, 0 AS Entrega, " & vbCrLf
            sql = sql & " 0 as Inicial, Inicial2Valorado AS InicialValorado, " & vbCrLf
            sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sqlInicial2
            sql = sql & " ) AS I2V" & vbCrLf
            sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf





            sql = "SELECT Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret, " & vbCrLf & _
                " Sum(Inicial) as Inicial," & vbCrLf & _
                " Sum(Retira) AS Retira, Sum(Entrega) AS Entrega," & vbCrLf & _
                " Sum(Inicial + Retira - Entrega) as Saldo," & vbCrLf & _
                " Sum(InicialValorado) as InicialValorado," & vbCrLf & _
                " Sum(RetiraValorado) as RetiraValorado, Sum(EntregaValorado) as EntregaValorado," & vbCrLf & _
                " Sum(InicialValorado + RetiraValorado - EntregaValorado) as SaldoValorado" & vbCrLf & _
                " FROM (" & sql & vbCrLf & _
                " ) AS G" & vbCrLf & _
                " GROUP BY Tipo, Codigo, Nombre, IdEnvase, NombreEnvase, TipoEnv, Ret" & vbCrLf

            Return sql

        End If




    End Function




End Class
