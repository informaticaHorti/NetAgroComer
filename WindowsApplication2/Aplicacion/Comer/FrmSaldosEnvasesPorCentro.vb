
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmSaldosEnvasesPorCentro
    Inherits FrConsulta


    Private Class stClaves_SaldoEnvasesPorCentro

        Public IdAlmacen As Integer = 0
        Public Almacen As String = ""
        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public SaldoIni As Decimal = 0
        Public SaldoFin As Decimal = 0
        Public NumVale As String = ""
        Public Fecha As Date = VaDate("")
        Public Operacion As String = ""
        Public TipoOperacion As String = ""
        Public Concepto As String = ""
        Public Referencia As String = ""
        Public TipoLinea As String = ""

        Public Sub New(IdAlmacen As Integer, Almacen As String, IdEnvase As Integer, Envase As String,
                       NumVale As String, Fecha As Date, Operacion As String, TipoOperacion As String, Concepto As String, Referencia As String, TipoLinea As String)

            Me.IdAlmacen = IdAlmacen
            Me.Almacen = Almacen
            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.NumVale = NumVale
            Me.Fecha = Fecha
            Me.Operacion = Operacion
            Me.TipoOperacion = TipoOperacion
            Me.Concepto = Concepto
            Me.Referencia = Referencia
            Me.TipoLinea = TipoLinea

        End Sub

    End Class

    Public Class stDatos_SaldoEnvasesPorCentro

        Public Entrega As Decimal = 0
        Public Retira As Decimal = 0

        Public Sub New(Entrega As Decimal, Retira As Decimal)
            Me.Entrega = Entrega
            Me.Retira = Retira
        End Sub

    End Class


    Public Class ResumenSaldo

        Public SaldoIni As Decimal = 0
        Public SaldoFin As Decimal = 0

        Public Sub New(SaldoIni As Decimal, SaldoFin As Decimal)
            Me.SaldoIni = SaldoIni
            Me.SaldoFin = SaldoFin
        End Sub

    End Class


    Dim err As New Errores

    Private Envases As New E_Envases(Idusuario, cn)
    Private EnvasesInicial As New E_envasesInicial(Idusuario, cn)
    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Envases.ENV_IdEnvase, Lb1)
        ParamTx(TxDato2, Envases.ENV_IdEnvase, Lb2)
        ParamTx(TxDato3, ValeEnvases.VEV_Fecha, Lb3)
        ParamTx(TxDato4, ValeEnvases.VEV_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_2)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)

        GridView1.OptionsView.ShowGroupPanel = True


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


        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)

        Dim dt As DataTable
        If RbSaldos.Checked Then
            dt = ConsultaSaldos(lstAlmacenes, False)
        Else
            dt = ConsultaDetallado(lstAlmacenes)
        End If






        GridView1.Columns.Clear()
        Grid.DataSource = dt


        AjustaColumnas()


        AñadeResumenCampo("SaldoIni", "{0:n2}")
        AñadeResumenCampo("SaldoFin", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Retira", "{0:n2}")


    End Sub


    Private Function ConsultaSaldos(lstAlmacenes As List(Of String), bDetallado As Boolean) As DataTable


        Dim sqlWhere As String = ""
        Dim sqlWhere3 As String = ""

        'Cod Envase
        If VaInt(TxDato1.Text) > 0 Then
            sqlWhere = " WHERE VEL_IdEnvase >= " & TxDato1.Text & vbCrLf
        End If
        If VaInt(TxDato2.Text) > 0 Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
            End If
        End If

        'Puntos de venta
        If lstAlmacenes.Count > 0 Then
            If sqlWhere = "" Then
                sqlWhere = CadenaWhereLista(ValeEnvases.VEV_IdAlmacen, lstAlmacenes, " WHERE") & vbCrLf
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(ValeEnvases.VEV_IdAlmacen, lstAlmacenes, " AND") & vbCrLf
            End If
        End If


        'Hasta aquí ambos where son iguales
        sqlWhere3 = sqlWhere


        'Fechas
        If TxDato3.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEV_Fecha >= '" & TxDato3.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEV_Fecha >= '" & TxDato3.Text & "'" & vbCrLf
            End If
        End If
        If TxDato4.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEV_Fecha <= '" & TxDato4.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEV_Fecha <= '" & TxDato4.Text & "'" & vbCrLf
            End If
        End If


        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)


        'Fechas iniciales
        If sqlWhere3 = "" Then
            sqlWhere3 = " WHERE VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        Else
            sqlWhere3 = sqlWhere3 & " AND VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        End If
        sqlWhere3 = sqlWhere3 & " AND VEV_Fecha < '" & TxDato3.Text & "'" & vbCrLf



        Dim sql1 As String = "SELECT VEV_IdAlmacen as IdAlmacen, " & vbCrLf
        sql1 = sql1 & " AEV_Nombre AS Almacen, " & vbCrLf
        sql1 = sql1 & " VEL_idenvase as IdEnvase, " & vbCrLf
        sql1 = sql1 & " ENV_nombre AS Envase, " & vbCrLf
        sql1 = sql1 & " 0.00 as SaldoI," & vbCrLf
        sql1 = sql1 & " COALESCE(VEL_entrega,0) - COALESCE(VEL_retira,0) as SaldoF" & vbCrLf
        sql1 = sql1 & " FROM ValeEnvases_Lineas " & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN AlmacenEnvases ON VEV_IdAlmacen = AEV_Idalmacen" & vbCrLf
        sql1 = sql1 & sqlWhere
        If lstFamilias.Count > 0 Then
            If sqlWhere.Trim = "" Then
                sql1 = sql1 & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " WHERE ") & vbCrLf
            Else
                sql1 = sql1 & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
            End If
        End If


        Dim sql2 As String = "SELECT ENI_Codigo as IdAlmacen, AEV_Nombre as Almacen," & vbCrLf
        sql2 = sql2 & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql2 = sql2 & " ENI_Inicial as SaldoI, 0.00 as SaldoF" & vbCrLf
        sql2 = sql2 & " FROM EnvasesInicial" & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN AlmacenEnvases ON ENI_Codigo = AEV_Idalmacen " & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        If TxDato1.Text.Trim <> "" Then sql2 = sql2 & " AND ENI_IdEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sql2 = sql2 & " AND ENI_IdEnvase <= " & TxDato2.Text & vbCrLf
        sql2 = sql2 & CadenaWhereLista(EnvasesInicial.ENI_codigo, lstAlmacenes, " AND")
        If lstFamilias.Count > 0 Then
            sql2 = sql2 & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
        End If


        Dim sql3 As String = "SELECT VEV_IdAlmacen as IdAlmacen, AEV_Nombre as Almacen," & vbCrLf
        sql3 = sql3 & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        sql3 = sql3 & " COALESCE(VEL_Entrega,0) - COALESCE(VEL_Retira,0) as SaldoI, 0.00 as SaldoF" & vbCrLf
        sql3 = sql3 & " FROM ValeEnvases VE" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN Envases E ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN AlmacenEnvases ON VEV_IdAlmacen = AEV_Idalmacen" & vbCrLf
        sql3 = sql3 & sqlWhere3
        If lstFamilias.Count > 0 Then
            If sqlWhere3.Trim = "" Then
                sql3 = sql3 & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " WHERE ") & vbCrLf
            Else
                sql3 = sql3 & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
            End If
        End If


        Dim sql As String = ""


        If Not bDetallado Then

            sql = "SELECT IdAlmacen, RIGHT(CAST('00' as varchar) + CAST(IdAlmacen as varchar),2) +  ' ' + Almacen as Almacen," & vbCrLf
            sql = sql & " IdEnvase, Envase, SUM(SaldoI) as SaldoIni, SUM(SaldoI + SaldoF) as SaldoFin" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sql1
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql2
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql3
            sql = sql & " ) AS G" & vbCrLf
            sql = sql & " GROUP BY IdAlmacen, Almacen, IdEnvase, Envase" & vbCrLf
            sql = sql & " HAVING SUM(SaldoI) <> 0 OR SUM(SaldoI + SaldoF) <> 0" & vbCrLf
            sql = sql & " ORDER BY IdAlmacen, IdEnvase" & vbCrLf

        Else

            sql = "SELECT IdAlmacen, RIGHT(CAST('00' as varchar) + CAST(IdAlmacen as varchar),2) + ' ' + Almacen as Almacen," & vbCrLf
            sql = sql & " IdEnvase, RIGHT(CAST('00000' as varchar) + CAST(IdEnvase as varchar), 5) + ' ' + Envase as Envase," & vbCrLf
            sql = sql & " SUM(SaldoI) as SaldoIni, SUM(SaldoI + SaldoF) as SaldoFin," & vbCrLf
            sql = sql & " '' as NumVale, CAST('01/01/1900' AS DATE) as Fecha, '' as Concepto, '' as Referencia, 0.00 as Entrega, 0.00 as Retira," & vbCrLf
            sql = sql & " '' as TipoLinea" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sql1
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql2
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql3
            sql = sql & " ) AS G" & vbCrLf
            sql = sql & " GROUP BY IdAlmacen, Almacen, IdEnvase, Envase" & vbCrLf
            sql = sql & " HAVING SUM(SaldoI) <> 0 OR SUM(SaldoI + SaldoF) <> 0" & vbCrLf

        End If

        Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(sql)



        Return dt

    End Function



    Private Function ConsultaDetallado(lstAlmacenes As List(Of String)) As DataTable


        Dim sqlWhere As String = ""
        'Dim sqlWhere3 As String = ""

        'Cod Envase
        If VaInt(TxDato1.Text) > 0 Then
            sqlWhere = " WHERE VEL_IdEnvase >= " & TxDato1.Text & vbCrLf
        End If
        If VaInt(TxDato2.Text) > 0 Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
            End If
        End If

        'Puntos de venta
        If lstAlmacenes.Count > 0 Then
            If sqlWhere = "" Then
                sqlWhere = CadenaWhereLista(ValeEnvases.VEV_IdAlmacen, lstAlmacenes, " WHERE") & vbCrLf
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(ValeEnvases.VEV_IdAlmacen, lstAlmacenes, " AND") & vbCrLf
            End If
        End If


        ''Hasta aquí ambos where son iguales
        'sqlWhere3 = sqlWhere


        'Fechas
        If TxDato3.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEV_Fecha >= '" & TxDato3.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEV_Fecha >= '" & TxDato3.Text & "'" & vbCrLf
            End If
        End If
        If TxDato4.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE VEV_Fecha <= '" & TxDato4.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND VEV_Fecha <= '" & TxDato4.Text & "'" & vbCrLf
            End If
        End If


        'Familias
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)
        If lstFamilias.Count > 0 Then
            If sqlWhere = "" Then
                sqlWhere = sqlWhere & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " WHERE ")
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ")
            End If
        End If


        ''Fechas iniciales
        'If sqlWhere3 = "" Then
        '    sqlWhere3 = " WHERE VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        'Else
        '    sqlWhere3 = sqlWhere3 & " AND VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        'End If
        'sqlWhere3 = sqlWhere3 & " AND VEV_Fecha < '" & TxDato3.Text & "'" & vbCrLf


        



        Dim dtIniciales As DataTable = ConsultaSaldos(lstAlmacenes, True)


        Dim sql As String = "SELECT VEV_IdAlmacen as IdAlmacen, RIGHT(CAST('00' as varchar) + CAST(VEV_IdAlmacen AS VARCHAR),2) + ' ' + AEV_Nombre as Almacen, " & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, RIGHT(CAST('00000' as varchar) + CAST(VEL_IdEnvase as varchar), 5) + ' ' + ENV_Nombre as Envase," & vbCrLf
        sql = sql & " VEV_IdVale as IdVale, CAST(VEV_Numero AS VARCHAR) as NumVale, VEV_Fecha as Fecha, " & vbCrLf
        sql = sql & " VEV_Operacion as Operacion, '' as TipoOperacion, " & vbCrLf
        sql = sql & " VEV_Concepto as Concepto, VEV_Referencia as Referencia," & vbCrLf
        sql = sql & " SUM(COALESCE(VEL_Entrega,0)) as Entrega, SUM(COALESCE(VEL_Retira,0)) as Retira," & vbCrLf
        sql = sql & " 'D' as TipoLinea" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN AlmacenEnvases ON AEV_IdAlmacen = VEV_IdAlmacen" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " GROUP BY VEV_IdAlmacen, AEV_Nombre, VEL_IdEnvase, ENV_Nombre, VEV_IdVale, VEV_Numero, VEV_Fecha, VEV_Operacion, VEV_Concepto, VEV_Referencia" & vbCrLf

        Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(sql)


        Dim acum As New Acumulador
        Dim DcAlmacenes As New Dictionary(Of Integer, Dictionary(Of Integer, ResumenSaldo))


        'Líneas de saldo inicial
        Dim FechaInicial As Date = MiMaletin.FechaInicioEjercicio
        If VaDate(TxDato3.Text.Trim) > VaDate("") Then FechaInicial = VaDate(TxDato3.Text.Trim)
        For Each row As DataRow In dtIniciales.Rows

            Dim IdAlmacen As Integer = VaInt(row("IdAlmacen"))
            Dim Almacen As String = row("Almacen").ToString & ""
            Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
            Dim Envase As String = row("Envase").ToString & ""
            Dim SaldoIni As Decimal = VaDec(row("SaldoIni"))
            Dim SaldoFin As Decimal = VaDec(row("SaldoFin"))

            Dim stClave As New stClaves_SaldoEnvasesPorCentro(IdAlmacen, Almacen, IdEnvase, Envase, "", FechaInicial, "", "SALDO INICIAL", "Saldo Inicial", "", "")
            Dim stDatos As New stDatos_SaldoEnvasesPorCentro(SaldoIni, 0)
            acum.Suma(stClave, stDatos)

            'Almacena los saldos iniciales y finales de los envases por almacén
            If DcAlmacenes.ContainsKey(IdAlmacen) Then
                Dim DcEnvases As Dictionary(Of Integer, ResumenSaldo) = DcAlmacenes(IdAlmacen)
                If Not DcEnvases.ContainsKey(IdEnvase) Then
                    Dim ResumenSaldo As New ResumenSaldo(SaldoIni, SaldoFin)
                    DcEnvases(IdEnvase) = ResumenSaldo
                    DcAlmacenes(IdAlmacen) = DcEnvases
                End If
            Else
                Dim DcEnvases As New Dictionary(Of Integer, ResumenSaldo)
                DcEnvases(IdEnvase) = New ResumenSaldo(SaldoIni, SaldoFin)
                DcAlmacenes(IdAlmacen) = DcEnvases
            End If

        Next



        Dim dtSaldos As DataTable = acum.DataTable
        If Not IsNothing(dt) Then
            If Not IsNothing(dtSaldos) Then
                dt.Merge(dtSaldos)
            End If
        Else
            If Not IsNothing(dtSaldos) Then
                dt = dtSaldos
            End If
        End If

        If Not IsNothing(dt) Then
            Dim dv As New DataView(dt)
            If RbDetallado.Checked Then
                dv.RowFilter = "Entrega <> 0 OR Retira <> 0"
            Else
                dv.RowFilter = "SaldoIni <> 0 OR SaldoFin <> 0"
            End If
            dv.Sort = "IdAlmacen, IdEnvase, TipoLinea, Fecha, NumVale"
            dt = dv.ToTable
        End If

        'Actualizo SaldoIni y SaldoFin
        For Each row As DataRow In dt.Rows

            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim IdAlmacen As Integer = VaInt(row("IdAlmacen"))
            Dim IdEnvase As Integer = VaInt(row("IdEnvase"))

            Dim Operacion As String = (row("Operacion").ToString & "").Trim
            Dim TipoOperacion As String = TextoTipoOperacion(Operacion)
            If TipoOperacion.Trim <> "" Then row("TipoOperacion") = TipoOperacion

            If DcAlmacenes.ContainsKey(IdAlmacen) Then
                Dim DcEnvases As Dictionary(Of Integer, ResumenSaldo) = DcAlmacenes(IdAlmacen)
                If DcEnvases.ContainsKey(IdEnvase) Then
                    Envase = Envase & " - Saldo Inicial: " & DcEnvases(IdEnvase).SaldoIni.ToString("#,##0.00") & ", Saldo Final: " & DcEnvases(IdEnvase).SaldoFin.ToString("#,##0.00")
                    row("Envase") = Envase
                End If
            End If

        Next



        Return dt

    End Function


    Private Function TextoTipoOperacion(Operacion As String) As String

        Dim res As String = ""

        Select Case Operacion
            Case TipoVale.Devoluciones 'DV
                res = "DEVOLUCION"
            Case TipoVale.AlbaranCompra 'AC
                res = "ALBARAN COMPRA"
            Case TipoVale.EntradaBascula 'EB
                res = "ENTRADA EN BASCULA"
            Case TipoVale.AlbaranSalidaComercio_Retornable 'SC
                res = "ALBARAN SALIDA"
            Case TipoVale.AlbaranSalidaComercio_Material 'SM
                res = "ALBARAN SALIDA MATERIAL"
            Case TipoVale.RetornoInventariables 'RI
                res = "RETORNO INVENTARIABLES"
            Case TipoVale.AlbaranSalidaAlhondiga 'SA
                res = "ALBARAN ALHONDIGA"
            Case TipoVale.TraspasoOrigen 'TO
                res = "TRASPASO DESDE CENTRO"
            Case TipoVale.TraspasoDestino 'TD
                res = "TRASPASO A CENTRO"
            Case TipoVale.Cliente 'CC
                res = "VALE CLIENTE"
            Case TipoVale.Agricultor 'AA
                res = "VALE AGRICULTOR"
            Case TipoVale.VentaTerceros 'VT
                res = "VENTA TERCEROS"
            Case TipoVale.BajasConsumo 'BC
                res = "BAJAS CONSUMO"
            Case TipoVale.ConsumoMateriales 'CN
                res = "CONSUMO MATERIALES"

        End Select


        Return res

    End Function






    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ALMACEN"
                    c.Visible = False
                    c.GroupIndex = 1

                Case "TIPOLINEA", "IDALMACEN", "OPERACION", "IDVALE"
                    c.Visible = False

                Case "IDENVASE"
                    If RbDetallado.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If

                Case "SALDOINI", "SALDOFIN"
                    If RbDetallado.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "TIPOOPERACION"
                    If RbDetallado.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

                Case "ENTREGA", "RETIRA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "ENVASE"
                    If RbSaldos.Checked Then
                        c.Visible = True
                        c.GroupIndex = -1
                    Else
                        c.Visible = False
                        c.GroupIndex = 2
                    End If

            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDENVASE"
                    c.Caption = "CodEnv"
                    c.Width = 60

                Case "SALDOINI", "SALDOFIN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100


            End Select
        Next


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim envases As String = FiltroDesdeHasta("Envases", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbAlmacenes)
        Dim familias As String = FiltroCheckedComboBox("Familias envases", CbFamilias)
        Dim tipolistado As String = ""

        If RbSaldos.Checked Then
            tipolistado = "Tipo listado: Listado de saldos"
        Else
            tipolistado = "Tipo listado: Detallado"
        End If


        If envases <> "" Then LineasDescripcion.Add(envases)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If familias <> "" Then LineasDescripcion.Add(familias)
        If tipolistado <> "" Then LineasDescripcion.Add(tipolistado)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()

        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then


                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbAlmacenes)
                Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)

                If RbSaldos.Checked Then
                    'ImprimirInformeSaldosEnvasesPorCentroResumido(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta)
                    Dim listado As New Listado_InformeSaldosEnvasesPorCentro(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta, False, lstFamilias, TipoImpresion.Preliminar)
                    listado.ImprimirListado()
                Else
                    'ImprimirInformeSaldosEnvasesPorCentroDetallado(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta)
                    Dim listado As New Listado_InformeSaldosEnvasesPorCentro(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta, True, lstFamilias, TipoImpresion.Preliminar)
                    listado.ImprimirListado()
                End If


            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If
        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub



    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Operacion")) Then

            Dim IdVale As Integer = VaInt(row("IdVale"))
            If IdVale > 0 Then
                Dim fr As New FrmValeEnvase(row("Operacion").ToString)
                fr.init(IdVale.ToString)
                fr.ShowDialog()
            End If

        End If

    End Sub


End Class