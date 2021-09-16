Imports DevExpress.XtraEditors.Controls

Public Class FrmConsultaSaldoEnvases
    Inherits FrConsulta


    Private Enum TipoSujeto
        Agricultor
        Cliente
    End Enum


    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)



    Private err As New Errores()



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Agricultores.AGR_IdAgricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_IdAgricultor, Lb2)
        ParamTx(TxDato3, Nothing, Lb3, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato4, Nothing, Lb3, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato5, Envases.ENV_IdEnvase, Lb5)
        ParamTx(TxDato6, Envases.ENV_IdEnvase, Lb6)
        ParamTx(TxDato7, Nothing, Lb7, , Cdatos.TiposCampo.Importe, 2, 18)


        AsociarControles(TxDato1, BtBusca1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_2)
        AsociarControles(TxDato5, BtBusca5, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_5)
        AsociarControles(TxDato6, BtBusca6, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_6)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        If RbAgricultor.Checked Then
            If RbResumido.Checked Then
                CargaGridAgricultoresResumido()
            Else
                CargaGridDetallado(TipoSujeto.Agricultor)
            End If
        Else
            If RbResumido.Checked Then
                CargaGridClientesResumido()
            Else
                CargaGridDetallado(TipoSujeto.Cliente)
            End If
        End If


        AñadeResumenCampo("Inicial", "{0:n2}")
        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Saldo", "{0:n2}")

        AñadeResumenCampo("InicialValorado", "{0:n2}")
        AñadeResumenCampo("RetiraValorado", "{0:n2}")
        AñadeResumenCampo("EntregaValorado", "{0:n2}")
        AñadeResumenCampo("SaldoValorado", "{0:n2}")

        Funciones.AñadeResumenCampo(GridView1, "SaldoStr", "{0}", DevExpress.Data.SummaryItemType.Custom)

    End Sub


#Region "Agricultores"

    Private Sub CargaGridAgricultoresResumido()

        Dim dt As DataTable = TablaAgricultoresResumido()

        GridView1.Columns.Clear()


        If Not IsNothing(dt) Then


            For Each row As DataRow In dt.Rows

                Dim Saldo As Decimal = 0
                If RbSiValorado.Checked Then
                    Saldo = VaDec(row("SaldoValorado"))
                Else
                    Saldo = VaDec(row("Saldo"))
                End If

                row("SaldoStr") = StSaldo(Saldo)
                row("Agricultor") = VaInt(row("IdAgricultor")).ToString("00000") & " " & row("Agricultor").ToString

            Next


            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim dv As New DataView(dt)
                    Dim filtro As String = ""

                    If RbSiValorado.Checked Then
                        filtro = "(InicialValorado <> 0 or RetiraValorado <> 0 or EntregaValorado <> 0 or SaldoValorado <> 0) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND SaldoValorado > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    ElseIf RbNoValorado.Checked Then
                        filtro = "(Inicial <> 0 or Retira <> 0 or Entrega <> 0 or Saldo <> 0) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND Saldo > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    End If



                    dv.RowFilter = filtro
                    dt = dv.ToTable

                End If
            End If

        End If


        Grid.DataSource = dt

        AjustaColumnas()

    End Sub



    Private Function TablaAgricultoresResumido() As DataTable


        Dim sql As String = "SELECT Codigo as IdAgricultor, Nombre as Agricultor, IdEnvase, NombreEnvase as Envase," & vbCrLf
        sql = sql & " SUM(Inicial) as Inicial, SUM(Retira) as Retira, SUM(Entrega) as Entrega, SUM(Saldo) as Saldo, " & vbCrLf
        sql = sql & " SUM(InicialValorado) as InicialValorado, SUM(RetiraValorado) as RetiraValorado," & vbCrLf
        sql = sql & " SUM(EntregaValorado) as EntregaValorado, SUM(SaldoValorado) as SaldoValorado, '' as SaldoStr" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & ValeEnvases.SaldoEnvases("A", False, TxDato3.Text, TxDato4.Text, TxDato1.Text, TxDato2.Text, TxDato5.Text, TxDato6.Text) & vbCrLf
        sql = sql & " ) AS G" & vbCrLf
        sql = sql & " WHERE COALESCE(IdEnvase,0) <> 0" & vbCrLf
        If RbSiRetornables.Checked Then
            sql = sql & " AND Ret = 'S'" & vbCrLf
        ElseIf RbNoRetornables.Checked Then
            sql = sql & " AND Ret = 'N'" & vbCrLf
        End If
        sql = sql & " GROUP BY Codigo, Nombre, IdEnvase, NombreEnvase" & vbCrLf
        sql = sql & vbCrLf & "ORDER BY Codigo, IdEnvase"


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function

#End Region


#Region "Clientes"

    Private Sub CargaGridClientesResumido()

        Dim dt As DataTable = TablaClientesResumido()

        GridView1.Columns.Clear()


        If Not IsNothing(dt) Then


            For Each row As DataRow In dt.Rows

                Dim Saldo As Decimal = 0
                If RbSiValorado.Checked Then
                    Saldo = VaDec(row("SaldoValorado"))
                Else
                    Saldo = VaDec(row("Saldo"))
                End If

                row("SaldoStr") = StSaldo(Saldo)
                row("Cliente") = VaInt(row("IdCliente")).ToString("00000") & " " & row("Cliente").ToString

            Next


            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim dv As New DataView(dt)
                    Dim filtro As String = ""

                    If RbSiValorado.Checked Then
                        filtro = "(InicialValorado <> 0 or RetiraValorado <> 0 or EntregaValorado <> 0 or SaldoValorado <> 0) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND SaldoValorado > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    ElseIf RbNoValorado.Checked Then
                        filtro = "(Inicial <> 0 or Retira <> 0 or Entrega <> 0 or Saldo <> 0) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND Saldo > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    End If



                    dv.RowFilter = filtro
                    dt = dv.ToTable

                End If
            End If

        End If


        Grid.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Function TablaClientesResumido() As DataTable

        Dim sql As String = "SELECT Codigo as IdCliente, Nombre as Cliente, IdEnvase, NombreEnvase as Envase," & vbCrLf
        sql = sql & " SUM(Inicial) as Inicial, SUM(Retira) as Retira, SUM(Entrega) as Entrega, SUM(Saldo) as Saldo, " & vbCrLf
        sql = sql & " SUM(InicialValorado) as InicialValorado, SUM(RetiraValorado) as RetiraValorado," & vbCrLf
        sql = sql & " SUM(EntregaValorado) as EntregaValorado, SUM(SaldoValorado) as SaldoValorado, '' as SaldoStr" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & ValeEnvases.SaldoEnvases("C", False, TxDato3.Text, TxDato4.Text, TxDato1.Text, TxDato2.Text, TxDato5.Text, TxDato6.Text) & vbCrLf
        sql = sql & " ) AS G" & vbCrLf
        sql = sql & " WHERE COALESCE(IdEnvase,0) <> 0" & vbCrLf
        If RbSiRetornables.Checked Then
            sql = sql & " AND Ret = 'S'" & vbCrLf
        ElseIf RbNoRetornables.Checked Then
            sql = sql & " AND Ret = 'N'" & vbCrLf
        End If
        sql = sql & " GROUP BY Codigo, Nombre, IdEnvase, NombreEnvase" & vbCrLf
        sql = sql & vbCrLf & "ORDER BY Codigo, IdEnvase"


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


#End Region
    


#Region "Detallado (común)"

    Private Sub CargaGridDetallado(TipoSujeto As TipoSujeto)


        Dim dt As DataTable = TablaDetallado(TipoSujeto)
        dt.Columns.Add(New DataColumn("Saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("SaldoValorado", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("SaldoStr", GetType(String)))



        If Not IsNothing(dt) Then

            Dim Saldo As Decimal = 0


            Dim AuxIdEnvase As String = ""
            Dim AuxCodigo As String = ""

            For Each row As DataRow In dt.Rows

                Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
                Dim Codigo As String = (row("Codigo").ToString & "").Trim

                row("Envase") = VaInt(row("IdEnvase")).ToString("00000") & " " & row("Envase")


                If AuxIdEnvase <> IdEnvase Or AuxCodigo <> Codigo Then
                    Saldo = 0
                End If


                If RbSiValorado.Checked Then
                    Saldo = Saldo + VaDec(row("InicialValorado")) + VaDec(row("RetiraValorado")) - VaDec(row("EntregaValorado"))
                    row("SaldoValorado") = Saldo
                Else
                    Saldo = Saldo + VaDec(row("Inicial")) + VaDec(row("Retira")) - VaDec(row("Entrega"))
                    row("Saldo") = Saldo
                End If


                row("SaldoStr") = StSaldo(Saldo)
                row("Nombre") = VaInt(row("Codigo")).ToString("00000") & " " & row("Nombre").ToString


                AuxIdEnvase = IdEnvase
                AuxCodigo = Codigo

            Next


            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim dv As New DataView(dt)
                    Dim filtro As String = ""

                    If RbSiValorado.Checked Then
                        filtro = "(InicialValorado <> 0 or RetiraValorado <> 0 or EntregaValorado <> 0) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND SaldoValorado > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    ElseIf RbNoValorado.Checked Then
                        filtro = "(Inicial <> 0 or Retira <> 0 or Entrega <> 0 ) "
                        If VaDec(TxDato7.Text) <> 0 Then
                            filtro = filtro & " AND Saldo > " & VaDec(TxDato7.Text).ToString("###0.00").Replace(",", ".")
                        End If
                    End If



                    dv.RowFilter = filtro
                    dt = dv.ToTable

                End If
            End If

        End If




        GridView1.Columns.Clear()

        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Function TablaDetallado(TipoSujeto As TipoSujeto) As DataTable

        Dim Tipo As String = ""
        Select Case TipoSujeto
            Case FrmConsultaSaldoEnvases.TipoSujeto.Agricultor
                Tipo = "A"
            Case FrmConsultaSaldoEnvases.TipoSujeto.Cliente
                Tipo = "C"
        End Select

        Dim CodDesde As String = TxDato1.Text
        Dim CodHasta As String = TxDato2.Text
        Dim EnvDesde As String = TxDato5.Text
        Dim EnvHasta As String = TxDato6.Text
        Dim FechaDesde As String = TxDato3.Text
        Dim FechaHasta As String = TxDato4.Text


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



        Dim sqlBase As String = "SELECT VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        sqlBase = sqlBase & " ENV_Retornable as Ret," & vbCrLf
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



        Dim sqlInicial2 As String = "SELECT VEV_Codigo as Codigo, " & Pref & "Nombre as Nombre, VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        sqlInicial2 = sqlInicial2 & " ENV_Retornable as Ret," & vbCrLf
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



        Dim sqlInicial As String = ""

        If Tipo = "A" Then
            sqlInicial = sqlInicial & " SELECT ENI_Codigo as Codigo, AGR_Nombre as Nombre, "
            sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase,"
            sqlInicial = sqlInicial & " ENV_Retornable as Ret," & vbCrLf
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
            sqlInicial = sqlInicial & " SELECT ENI_Codigo as Codigo, CLI_Nombre as Nombre, "
            sqlInicial = sqlInicial & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase,"
            sqlInicial = sqlInicial & " ENV_Retornable as Ret," & vbCrLf
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


        Dim sql As String = "SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 AS Inicial, 0 AS InicialValorado, Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, 'D' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlBase & vbCrLf
        sql = sql & " ) AS R" & vbCrLf
        sql = sql & " WHERE COALESCE(PrecioRetira, 0) = 0" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 AS Inicial, 0 AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " RetiraValorado, 0 AS EntregaValorado, 'D' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlBase
        sql = sql & " ) AS RV" & vbCrLf
        sql = sql & " WHERE COALESCE(PrecioRetira, 0) <> 0" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 AS Inicial, 0 AS InicialValorado, 0 AS Retira, Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, 'D' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlBase
        sql = sql & " ) AS E" & vbCrLf
        sql = sql & " WHERE COALESCE(PrecioEntrega, 0) = 0" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 AS Inicial, 0 AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, EntregaValorado, 'D' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlBase
        sql = sql & " ) AS E" & vbCrLf
        sql = sql & " WHERE COALESCE(PrecioEntrega, 0) <> 0" & vbCrLf

        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " Inicial, 0 AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, '' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlInicial
        sql = sql & " ) AS I" & vbCrLf
        sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 as Inicial, Inicial AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, '' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlInicial
        sql = sql & " ) AS IV" & vbCrLf
        sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf


        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " Inicial2 as Inicial, 0 AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, '' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlInicial2
        sql = sql & " ) AS I2" & vbCrLf
        sql = sql & " WHERE COALESCE(Precio, 0) = 0" & vbCrLf

        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT Codigo, Nombre, IdEnvase, Envase, Ret, " & vbCrLf
        sql = sql & " 0 as Inicial, Inicial2Valorado AS InicialValorado, 0 AS Retira, 0 AS Entrega, " & vbCrLf
        sql = sql & " 0 AS RetiraValorado, 0 AS EntregaValorado, '' as TipoLinea" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sqlInicial2
        sql = sql & " ) AS I2V" & vbCrLf
        sql = sql & " WHERE COALESCE(Precio, 0) <> 0" & vbCrLf
        If RbSiRetornables.Checked Then
            sql = sql & " AND Ret = 'S'" & vbCrLf
        ElseIf RbNoRetornables.Checked Then
            sql = sql & " AND Ret = 'N'" & vbCrLf
        End If
        sql = sql & " ORDER BY Codigo, IdEnvase, TipoLinea"


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)


        Return dt

    End Function

#End Region



    Private Sub AjustaColumnas()


        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("IdAgricultor")) Then .ColumnByFieldName("IdAgricultor").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdCliente")) Then .ColumnByFieldName("IdCliente").Visible = False
            If Not IsNothing(.ColumnByFieldName("Saldo")) Then .ColumnByFieldName("Saldo").Visible = False
            If Not IsNothing(.ColumnByFieldName("SaldoValorado")) Then .ColumnByFieldName("SaldoValorado").Visible = False
            If Not IsNothing(.ColumnByFieldName("Ret")) Then .ColumnByFieldName("Ret").Visible = False
            If Not IsNothing(.ColumnByFieldName("Codigo")) Then .ColumnByFieldName("Codigo").Visible = False
            If Not IsNothing(.ColumnByFieldName("TipoLinea")) Then .ColumnByFieldName("TipoLinea").Visible = False


            If Not IsNothing(.ColumnByFieldName("Agricultor")) Then
                .ColumnByFieldName("Agricultor").Visible = False
                .ColumnByFieldName("Agricultor").GroupIndex = 1
            End If
            If Not IsNothing(.ColumnByFieldName("Cliente")) Then
                .ColumnByFieldName("Cliente").Visible = False
                .ColumnByFieldName("Cliente").GroupIndex = 1
            End If
            If Not IsNothing(.ColumnByFieldName("Nombre")) Then
                .ColumnByFieldName("Nombre").Visible = False
                .ColumnByFieldName("Nombre").GroupIndex = 1
            End If


            If RbSiValorado.Checked Then
                If Not IsNothing(.ColumnByFieldName("Inicial")) Then .ColumnByFieldName("Inicial").Visible = False
                If Not IsNothing(.ColumnByFieldName("Retira")) Then .ColumnByFieldName("Retira").Visible = False
                If Not IsNothing(.ColumnByFieldName("Entrega")) Then .ColumnByFieldName("Entrega").Visible = False
            ElseIf RbNoValorado.Checked Then
                If Not IsNothing(.ColumnByFieldName("InicialValorado")) Then .ColumnByFieldName("InicialValorado").Visible = False
                If Not IsNothing(.ColumnByFieldName("RetiraValorado")) Then .ColumnByFieldName("RetiraValorado").Visible = False
                If Not IsNothing(.ColumnByFieldName("EntregaValorado")) Then .ColumnByFieldName("EntregaValorado").Visible = False
            End If

            If RbDetallado.Checked Then
                If Not IsNothing(.ColumnByFieldName("IdEnvase")) Then .ColumnByFieldName("IdEnvase").Visible = False
                If Not IsNothing(.ColumnByFieldName("Envase")) Then
                    .ColumnByFieldName("Envase").Visible = False
                    .ColumnByFieldName("Envase").GroupIndex = 2
                End If
            ElseIf RbResumido.Checked Then
                If Not IsNothing(.ColumnByFieldName("IdEnvase")) Then .ColumnByFieldName("IdEnvase").Visible = True
                If Not IsNothing(.ColumnByFieldName("Envase")) Then
                    .ColumnByFieldName("Envase").Visible = True
                    .ColumnByFieldName("Envase").GroupIndex = -1
                End If
            End If

        End With



        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "NOMBRE"
                    If RbAgricultor.Checked Then
                        c.Caption = "Agricultor"
                    Else
                        c.Caption = "Cliente"
                    End If


                Case "IDENVASE"
                    c.Caption = "CodEnv"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "IDENVASE"
                    c.Caption = "CodEnv"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "INICIAL", "INICIALVALORADO"
                    c.Caption = "Sal.Anterior"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "RETIRA", "ENTREGA", "SALDO", "RETIRAVALORADO", "ENTREGAVALORADO", "SALDOVALORADO"
                    'If RbSiValorado.Checked Then c.Caption = c.FieldName & "Valorado"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "SALDOSTR"
                    If RbSiValorado.Checked Then
                        c.Caption = "Saldo Valorado"
                    Else
                        c.Caption = "Saldo"
                    End If
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    c.Width = 80

            End Select

        Next



    End Sub



    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva

        GridView1.OptionsView.ShowGroupPanel = False

        BInforme.Visible = False


        CargaFamilias()

    End Sub


    Private Sub CargaFamilias()

        Dim dt As New DataTable
        Dim sql As String = "SELECT FEV_IdFamilia as Familia, FEV_Nombre as Nombre FROM FamiliaEnvases ORDER BY Familia"
        dt = cn.ConsultaSQL(sql)

        CbFamilias.Properties.DataSource = dt
        CbFamilias.Properties.ValueMember = "Familia"
        CbFamilias.Properties.DisplayMember = "Nombre"
        CbFamilias.CheckAll()

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim agricultores_cliente As String = ""
        If RbAgricultor.Checked Then
            agricultores_cliente = FiltroDesdeHasta("Agricultor", TxDato1.Text, TxDato2.Text)
        Else
            agricultores_cliente = FiltroDesdeHasta("Cliente", TxDato1.Text, TxDato2.Text)
        End If
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim envases As String = FiltroDesdeHasta("Envase", TxDato5.Text, TxDato6.Text)

        Dim RbValorados As RadioButton() = {RbSiValorado, RbNoValorado}
        Dim StrValorados As String() = {"SI", "NO"}
        Dim Valorados As String = FiltroRadioButton("Valorados", RbValorados, StrValorados)

        Dim RbRetornables As RadioButton() = {RbSiRetornables, RbNoRetornables, RbTodosRetornables}
        Dim StrRetornables As String() = {"SI", "NO", "Todos"}
        Dim Retornables As String = FiltroRadioButton("Retornables", RbRetornables, StrRetornables)

        Dim RbTipoListado As RadioButton() = {RbResumido, RbDetallado}
        Dim StrTipoListado As String() = {"Resumido", "Detallado"}
        Dim TipoListado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)


        If agricultores_cliente <> "" Then LineasDescripcion.Add(agricultores_cliente)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If envases <> "" Then LineasDescripcion.Add(envases)
        If Retornables <> "" Then LineasDescripcion.Add(Retornables)
        If Valorados <> "" Then LineasDescripcion.Add(Valorados)
        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)
        If VaDec(TxDato7.Text) Then LineasDescripcion.Add("Saldo superior a " & VaDec(TxDato7.Text).ToString("#,##0.00"))


        Dim Informe As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
        Informe.Landscape = False


        MyBase.Imprimir()

    End Sub



    Private Sub CambiaSujeto()


        TxDato1.Text = ""
        TxDato2.Text = ""
        Lb_1.Text = ""
        Lb_2.Text = ""


        If RbAgricultor.Checked Then

            TxDato1.ClParam.CampoBd = Agricultores.AGR_IdAgricultor
            TxDato2.ClParam.CampoBd = Agricultores.AGR_IdAgricultor

            AsociarControles(TxDato1, BtBusca1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_1)
            AsociarControles(TxDato2, BtBusca2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_2)

            Lb1.Text = "Desde Agricultor"
            Lb2.Text = "Desde Agricultor"

        Else

            TxDato1.ClParam.CampoBd = Clientes.CLI_Codigo
            TxDato2.ClParam.CampoBd = Clientes.CLI_Codigo

            AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
            AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)

            Lb1.Text = "Desde Cliente"
            Lb2.Text = "Desde Cliente"

        End If

    End Sub


    Private Sub RbCliente_Click(sender As System.Object, e As System.EventArgs) Handles RbCliente.Click
        CambiaSujeto()
    End Sub


    Private Sub RbAgricultor_Click(sender As System.Object, e As System.EventArgs) Handles RbAgricultor.Click
        CambiaSujeto()
    End Sub


    Public Overrides Sub CustomDrawRowFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)
        MyBase.CustomDrawRowFooter(sender, e)

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim rowLevel As Integer = view.GetRowLevel(e.RowHandle)


        If RbDetallado.Checked Then

            If rowLevel = 0 Then
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(175, 201, 228)
            Else
                e.Appearance.BackColor = Color.FromArgb(215, 228, 242)
            End If

        Else
            e.Appearance.BackColor = SystemColors.Control
        End If


    End Sub


    Public Overrides Sub GroupLevelStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs)
        MyBase.GroupLevelStyle(sender, e)

        If RbDetallado.Checked Then
            If e.Level = 0 Then
                e.LevelAppearance.BackColor = System.Drawing.Color.FromArgb(175, 201, 228)
            Else
                e.LevelAppearance.BackColor = Color.FromArgb(215, 228, 242)
            End If

        Else
            e.LevelAppearance.BackColor = SystemColors.Control
        End If

    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)

        'If e.GroupLevel = 0 Then
        '    Exit Sub
        'End If



        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then

                Dim saldo As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "SALDOSTR" Then

                    If RbNoValorado.Checked Then
                        Dim Inicial As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim Retira As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        Dim Entrega As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                        saldo = Inicial + Retira - Entrega
                    ElseIf RbSiValorado.Checked Then
                        Dim InicialValorado As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                        Dim RetiraValorado As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                        Dim EntregaValorado As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        saldo = InicialValorado + RetiraValorado - EntregaValorado
                    End If

                End If
                e.TotalValue = saldo


            End If


            If e.IsTotalSummary Then

                Dim saldo As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "SALDOSTR" Then

                    Dim Inicial As Decimal = 0
                    Dim Retira As Decimal = 0
                    Dim Entrega As Decimal = 0

                    If RbNoValorado.Checked Then
                        Dim colInicial As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Inicial")
                        If Not IsNothing(colInicial) Then Inicial = VaDec(colInicial.SummaryItem.SummaryValue)
                        Dim colRetira As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Retira")
                        If Not IsNothing(colRetira) Then Retira = VaDec(colRetira.SummaryItem.SummaryValue)
                        Dim colEntrega As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Entrega")
                        If Not IsNothing(colEntrega) Then Entrega = VaDec(colEntrega.SummaryItem.SummaryValue)
                    ElseIf RbSiValorado.Checked Then
                        Dim colInicial As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("InicialValorado")
                        If Not IsNothing(colInicial) Then Inicial = VaDec(colInicial.SummaryItem.SummaryValue)
                        Dim colRetira As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("RetiraValorado")
                        If Not IsNothing(colRetira) Then Retira = VaDec(colRetira.SummaryItem.SummaryValue)
                        Dim colEntrega As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("EntregaValorado")
                        If Not IsNothing(colEntrega) Then Entrega = VaDec(colEntrega.SummaryItem.SummaryValue)
                    End If
                    saldo = Inicial + Retira - Entrega

                End If
                e.TotalValue = StSaldo(saldo)

            End If

        End If


    End Sub


    Private Sub RbDetallado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbDetallado.CheckedChanged

        If RbDetallado.Checked Then
            TxDato7.Text = ""
            TxDato7.Enabled = False
        End If

    End Sub

    Private Sub RbResumido_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbResumido.CheckedChanged

        If RbResumido.Checked Then
            TxDato7.Enabled = True
        End If

    End Sub
End Class

