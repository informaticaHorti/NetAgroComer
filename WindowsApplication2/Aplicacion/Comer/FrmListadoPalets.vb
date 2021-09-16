
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmListadoPalets
    Inherits FrConsulta



    Private Class stClaves_ListadoPaletsResumido

        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdPresentacion As Integer = 0
        Public Presentacion As String = ""
        Public QS As String = ""
        Public DEMETER As String = ""
        Public IdCategoria As Integer = 0
        Public Categoria As String = ""
        Public IdTipoPalet As Integer = 0
        Public TipoPalet As String = ""
        Public KxB As Decimal = 0

        Public Sub New(IdGenero As Integer, Genero As String, IdPresentacion As Integer, presentacion As String, QS As String, DEMETER As String,
                       IdCategoria As Integer, Categoria As String, IdTipoPalet As Integer, TipoPalet As String,
                       KxB As Decimal)

            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdPresentacion = IdPresentacion
            Me.Presentacion = presentacion
            Me.QS = QS
            Me.DEMETER = DEMETER
            Me.IdCategoria = IdCategoria
            Me.Categoria = Categoria
            Me.IdTipoPalet = IdTipoPalet
            Me.TipoPalet = TipoPalet
            Me.KxB = KxB

        End Sub

    End Class


    Private Class stDatos__ListadoPaletsResumido

        Public Palets As Integer = 0
        Public Bultos As Integer = 0
        Public Kilos As Decimal = 0
        Public KgBrutos As Decimal = 0
        Public Reser As Integer = 0

        Public Sub New(Palets As Integer, Bultos As Integer, Kilos As Decimal, KgBrutos As Decimal, Reser As Integer)

            Me.Palets = Palets
            Me.Bultos = Bultos
            Me.Kilos = Kilos
            Me.KgBrutos = KgBrutos
            Me.Reser = Reser

        End Sub

    End Class


    Dim Palets As New E_palets(Idusuario, cn)
    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Usuarios As New E_Usuarios(Idusuario, CnComun)



    Dim err As New Errores



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxGeneroDesde, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxGeneroHasta, Generos.GEN_IdGenero, LbHastaGenero)
        ParamTx(TxFechaDesde, Palets.PAL_fecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, Palets.PAL_fecha, LbHastaFecha, True)

        AsociarControles(TxGeneroDesde, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxGeneroHasta, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)


    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        cbPuntoVenta.CheckAll()
        CbSituacion = ComboPuntoventa(CbSituacion, MiMaletin.IdPuntoVenta)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sqlWhere As String = ""


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgensal, "IdPresentacion")
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idpalet, "IdPalet")
        CONSULTA.SelCampo(Palets.PAL_palet, "NumPalet", Palets_Lineas.PLL_idpalet, Palets.PAL_idpalet)
        CONSULTA.SelCampo(Palets.PAL_Lote, "Lote")
        CONSULTA.SelCampo(Palets.PAL_fecha, "Fecha")
        CONSULTA.SelCampo(Palets_Lineas.PLL_idcategoria, "IdCategoria")
        CONSULTA.SelCampo(Categorias.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria, Categorias.CAS_Id)
        CONSULTA.SelCampo(Palets.PAL_idtipopalet, "IdTipoPalet")
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", Palets.PAL_idtipopalet, ConfecPalet.CPA_Idconfec)
        CONSULTA.SelCampo(ConfecEnvase.CEV_IdEnvase, "IdEnvase", Palets_Lineas.PLL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        CONSULTA.SelCampo(Envases.ENV_Abreviatura, "Envase", ConfecEnvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idmarca, "IdMarca")
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca, Marcas.MAR_Idmarca)
        CONSULTA.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_kilosbrutos, "KgBrutos")
        'CONSULTA.SelCampo(Palets_Lineas.PLL_kilosxbulto, "KxB")
        Dim oKxB As New Cdatos.bdcampo("@CASE COALESCE(PLL_Bultos,0) WHEN 0 THEN 0 ELSE COALESCE(PLL_KilosNetos,0) / PLL_Bultos END", Cdatos.TiposCampo.Importe, Palets_Lineas.PLL_kilosxbulto.Longitud, Palets_Lineas.PLL_kilosxbulto.Decimales)
        CONSULTA.SelCampo(oKxB, "KxB")
        If ChkVisualizarMermas.Checked Then
            CONSULTA.SelCampo(Palets_Lineas.PLL_kilosxbulto, "KxBCliente")
            CONSULTA.SelCampo(Palets_Lineas.PLL_Merma, "Merma")
            Dim KilosTeoricos As New Cdatos.bdcampo("@PLL_Bultos * PLL_KilosxBulto", Cdatos.TiposCampo.Importe, Palets_Lineas.PLL_kiloscliente.Longitud, Palets_Lineas.PLL_kiloscliente.Decimales)
            CONSULTA.SelCampo(KilosTeoricos, "KgTeoricos")
            Dim PorCenMerma As New Cdatos.bdcampo("@CASE COALESCE(PLL_Bultos * PLL_KilosxBulto,0) WHEN 0 THEN 0 ELSE PLL_Merma / (PLL_Bultos * PLL_KilosxBulto) * 100 END", Cdatos.TiposCampo.Importe, 3, 2)
            CONSULTA.SelCampo(PorCenMerma, "PorCenMerma")
            CONSULTA.SelCampo(Palets.PAL_IdUsuarioLog, "IdUsuario")
            CONSULTA.SelCampo(Usuarios.Nombre, "Usuario", Palets.PAL_IdUsuarioLog, Usuarios.IdUsuario)
        End If
        Dim oReservados As New Cdatos.bdcampo("@CASE PLL_TipoReserva WHEN 'R' THEN 1 ELSE 0 END", Cdatos.TiposCampo.Entero, 10)
        CONSULTA.SelCampo(oReservados, "PRes")
        CONSULTA.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "FechaSal", AlbSalida_Palets.ASP_IdAlbaran, AlbSalida.ASA_idalbaran)
        CONSULTA.SelCampo(AlbSalida.ASA_idcliente, "IdCliente")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        CONSULTA.SelCampo(Palets.PAL_HoraConfeccion, "HoraConf")
        CONSULTA.SelCampo(GenerosSalida.GES_GeneroQS, "QS")
        CONSULTA.SelCampo(GenerosSalida.GES_DEMETER, "DEMETER")


        If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "PLL_IdGenero >= " & TxGeneroDesde.Text)
        If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "PLL_IdGenero <= " & TxGeneroHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "PAL_Fecha >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "PAL_Fecha <= '" & TxFechaHasta.Text & "'")
        AñadeCondicion(sqlWhere, CadenaWhereLista(Palets.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta)))


        If RbEnExistencias.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASP_IdAlbaran,0) = 0")
        ElseIf RbCargados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASP_IdAlbaran,0) > 0")
        End If


        If RbTerminados.Checked Then
            AñadeCondicion(sqlWhere, "PAL_finalizado='S'")
        ElseIf RbNoTerminados.Checked Then
            AñadeCondicion(sqlWhere, "PAL_finalizado='N'")
        End If


        'Situacion
        Dim lstSituacion As List(Of String) = ListadeCombo(CbSituacion)
        If lstSituacion.Count > 0 Then

            Dim sqlSituacion As String = ""

            For Each pv As String In lstSituacion
                If sqlSituacion.Trim <> "" Then sqlSituacion = sqlSituacion & " OR "
                sqlSituacion = sqlSituacion & " (CASE COALESCE(PAL_IdPVSituacion,0) WHEN 0 THEN PAL_IdPuntoVenta ELSE PAL_IdPVSituacion END) = " & pv & vbCrLf
            Next

            If sqlWhere = "" Then
                sqlSituacion = " WHERE ( " & sqlSituacion & " )"
            Else
                sqlSituacion = " AND ( " & sqlSituacion & " ) "
            End If
            sqlWhere = sqlWhere & sqlSituacion & vbCrLf

        End If


        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & sqlWhere


        Dim sqlMermas As String = ", KxBCliente, Merma, SUM(KgTeoricos) as KgTeoricos, PorCenMerma, Usuario"
        Dim sqlGroupByMermas As String = ", KxBCliente, Merma, PorCenMerma, Usuario"

        If Not ChkVisualizarMermas.Checked Then
            sqlMermas = ""
            sqlGroupByMermas = ""
        End If

        If RbDetallado.Checked Then

            sql = "SELECT IdGenero, Genero, IdPresentacion, Presentacion, IdPalet, NumPalet, 1 as Palets, Lote, Fecha, IdCategoria, Categoria, TipoPalet, Envase, Marca," & vbCrLf & _
                " SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, SUM(KgBrutos) as KgBrutos, KxB, SUM(PRes) as PRes, FechaSal, Cliente, HoraConf, QS, DEMETER" & vbCrLf & _
                sqlMermas & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY IdGenero, Genero, IdPresentacion, Presentacion, QS, DEMETER, IdCategoria, Categoria, IdPalet, NumPalet, Lote, Fecha, IdTipoPalet, TipoPalet, " & vbCrLf & _
                " Envase, Marca, KxB, FechaSal, IdCliente, Cliente, HoraConf" & sqlGroupByMermas & vbCrLf & _
                " ORDER BY IdGenero, IdPresentacion, IdCategoria, Fecha, NumPalet" & vbCrLf

        ElseIf RbResumido.Checked Then

            sql = "SELECT IdGenero, Genero, IdPresentacion, Presentacion, IdCategoria, Categoria, IdTipoPalet, TipoPalet, IdPalet, 0 as Palets," & _
                " SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, SUM(KgBrutos) as KgBrutos, SUM(PRes) as PRes, HoraConf, QS, DEMETER" & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY IdGenero, Genero, IdPresentacion, Presentacion, QS, DEMETER, IdCategoria, Categoria, IdTipoPalet, TipoPalet, IdPalet, HoraConf" & _
                " ORDER BY IdGenero, IdPresentacion, IdCategoria, IdTipoPalet"

        End If



        GridView1.Columns.Clear()


        Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)

        If RbResumido.Checked Then
            dt = CompletarResumido(dt)
        End If



        Grid.DataSource = dt



        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("Importe", "{0:n2}")
        AñadeResumenCampo("KgBrutos", "{0:n2}")
        AñadeResumenCampo("Merma", "{0:n2}")
        AñadeResumenCampo("KxB", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("KgTeoricos", "{0:n2}")
        AñadeResumenCampo("KxBCliente", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("PorCenMerma", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Palets", "{0:n0}")


        AjustaColumnas()

        If Not RbResumido.Checked Then
            CalculaNumPalets()
        End If


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item



                    If item.FieldName.ToUpper.Trim = "KXB" Then

                        Dim KxB As Decimal = 0

                        Dim Bultos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim KilosNetos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        If Bultos <> 0 Then KxB = KilosNetos / Bultos

                        e.TotalValue = KxB

                    End If

                    If item.FieldName.ToUpper.Trim = "KXBCLIENTE" Then

                        Dim KxBCli As Decimal = 0

                        Dim Bultos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim KilosTeoricos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                        If Bultos <> 0 Then KxBCli = KilosTeoricos / Bultos

                        e.TotalValue = KxBCli

                    End If

                    If item.FieldName.ToUpper.Trim = "PORCENMERMA" Then

                        Dim xMerma As Decimal = 0

                        Dim Merma As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                        Dim KilosTeoricos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                        If KilosTeoricos <> 0 Then xMerma = (Merma / KilosTeoricos) * 100

                        e.TotalValue = xMerma

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "KXB" Then

                        Dim KxB As Decimal = 0

                        Dim Bultos As Decimal = 0
                        Dim KilosNetos As Decimal = 0

                        Dim colBultos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Bultos")
                        If Not IsNothing(colBultos) Then Bultos = VaDec(colBultos.SummaryItem.SummaryValue)

                        Dim colKilosNetos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Kilos")
                        If Not IsNothing(colKilosNetos) Then KilosNetos = VaDec(colKilosNetos.SummaryItem.SummaryValue)

                        If Bultos <> 0 Then KxB = KilosNetos / Bultos

                        e.TotalValue = KxB

                    End If

                    If item.FieldName.ToUpper.Trim = "KXBCLIENTE" Then

                        Dim KxBCli As Decimal = 0
                        Dim Bultos As Decimal = 0
                        Dim KilosTeoricos As Decimal = 0

                        Dim colBultos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Bultos")
                        If Not IsNothing(colBultos) Then Bultos = VaDec(colBultos.SummaryItem.SummaryValue)

                        Dim colKilosTeoricos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("KgTeoricos")
                        If Not IsNothing(colKilosTeoricos) Then KilosTeoricos = VaDec(colKilosTeoricos.SummaryItem.SummaryValue)

                        If Bultos <> 0 Then KxBCli = KilosTeoricos / Bultos

                        e.TotalValue = KxBCli

                    End If

                    If item.FieldName.ToUpper.Trim = "PORCENMERMA" Then

                        Dim xMerma As Decimal = 0
                        Dim Merma As Decimal = 0
                        Dim KilosTeoricos As Decimal = 0

                        Dim colMerma As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Merma")
                        If Not IsNothing(colMerma) Then Merma = VaDec(colMerma.SummaryItem.SummaryValue)

                        Dim colKilosTeoricos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("KgTeoricos")
                        If Not IsNothing(colKilosTeoricos) Then KilosTeoricos = VaDec(colKilosTeoricos.SummaryItem.SummaryValue)

                        If KilosTeoricos <> 0 Then xMerma = (Merma / KilosTeoricos) * 100

                        e.TotalValue = xMerma

                    End If


                End If

            End If




        Catch ex As Exception

        End Try

    End Sub


    Private Function CompletarResumido(ByRef dt As DataTable)


        Dim DcPalets As New Dictionary(Of Integer, Integer)

        Dim acum As New Acumulador



        For Each row As DataRow In dt.Rows

            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim QS As String = (row("QS").ToString & "").Trim : If QS <> "" Then QS = "N"
            Dim DEMETER As String = (row("DEMETER").ToString & "").Trim : If DEMETER <> "" Then DEMETER = "N"
            Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim IdTipoPalet As Integer = VaInt(row("IdTipoPalet"))
            Dim TipoPalet As String = (row("TipoPalet").ToString & "").Trim


            Dim Palets As Integer = 0

            Dim IdPalet As Integer = VaInt(row("IdPalet"))
            If Not DcPalets.ContainsKey(IdPalet) Then
                Palets = 1
                DcPalets(IdPalet) = IdPalet
            End If

            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim KgBrutos As Decimal = VaDec(row("KgBrutos"))
            'Dim KxB As Decimal = VaDec(row("KxB"))

            Dim KxB As Decimal = 0
            If Bultos <> 0 Then KxB = Kilos / Bultos
            Dim Reser As Integer = VaDec(row("Pres"))


            Dim stClave As New stClaves_ListadoPaletsResumido(IdGenero, Genero, IdPresentacion, Presentacion, QS, DEMETER, IdCategoria, Categoria, IdTipoPalet, TipoPalet, KxB)
            Dim stDatos As New stDatos__ListadoPaletsResumido(Palets, Bultos, Kilos, KgBrutos, Reser)
            acum.Suma(stClave, stDatos)

        Next


        dt = acum.DataTable()

        If Not IsNothing(dt) Then
            If dt.Columns.Contains("QS") Then
                dt.Columns("QS").SetOrdinal(dt.Columns.Count - 1)
            End If
            If dt.Columns.Contains("DEMETER") Then
                dt.Columns("DEMETER").SetOrdinal(dt.Columns.Count - 1)
            End If
        End If


        LbNumPalets.Text = "Nº Palets: " & DcPalets.Keys.Count



        Return dt

    End Function



    Private Sub AñadeCondicion(ByRef sqlWhere As String, condicion As String)

        If condicion.Trim <> "" Then

            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & condicion & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND " & condicion & vbCrLf
            End If

        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDGENERO", "GENERO", "PRESENTACION", "NUMPALET", "FECHA", "CATEGORIA", "TIPOPALET", "ENVASE", "MARCA", "PALET", "BULTOS", "KILOS", "KGBRUTOS", "KXB", "PRES", "FECHASAL", "CLIENTE", "LOTE", "QS", "DEMETER"
                    c.Visible = True

                Case "KXBCLIENTE", "USUARIO", "MERMA", "PORCENMERMA"
                    If ChkVisualizarMermas.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

                Case "PALETS"
                    If RbDetallado.Checked Then
                        c.Visible = True
                    End If



                Case Else
                    c.Visible = False

            End Select

        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "NUMPALET"
                    c.Caption = "N.Palet"
                    c.MinWidth = 65
                    c.MaxWidth = 65
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "0000000"

                Case "LOTE"
                    c.MinWidth = 45
                    c.MaxWidth = 45

                Case "FECHA", "FECHASAL"
                    c.MinWidth = 75

                Case "CATEGORIA"
                    c.Width = 90

                Case "TIPOPALET"
                    c.Width = 110

                Case "ENVASE"
                    c.Width = 90

                Case "MARCA"
                    c.Width = 90

                Case "KXB"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "BULTOS", "PALETS", "PRES"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 60

                Case "KILOS", "KGBRUTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70

                Case "KXB"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 40
                    c.MaxWidth = 40

                Case "KXBCLIENTE"
                    c.Caption = "KxBCli"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "MERMA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "PORCENMERMA"
                    c.Caption = "%Merma"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "HORACONF"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    c.DisplayFormat.FormatString = "HH:mm:ss"

                Case "USUARIO"
                    c.Caption = "Usu"
                    c.Width = 120

                Case "QS"
                    c.MinWidth = 25
                    c.MaxWidth = 25
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "DEMETER"
                    c.MinWidth = 55
                    c.MaxWidth = 55
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select

        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True


        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then


                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
                Dim TipoListado As String = ""


                'Tipo listado
                If RbEnExistencias.Checked Then
                    TipoListado = "Palets en existencias"
                ElseIf RbCargados.Checked Then
                    TipoListado = "Palets cargados"
                Else
                    TipoListado = "TODOS"
                End If

                Dim listado As New Listado_ListadoPalets(dt, TxGeneroDesde.Text, TxGeneroHasta.Text, TxFechaDesde.Text, _
                                                         TxFechaHasta.Text, lstPuntoVenta, TipoListado, RbDetallado.Checked, TipoImpresion.Preliminar)
                listado.ImprimirListado()

            Else
                bDatos = False
            End If

        Else
            bDatos = False
        End If


        If Not bDatos Then
            MsgBox("No hay datos que imprimir")
        End If


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim generos As String = FiltroDesdeHasta("Género", TxGeneroDesde.Text, TxGeneroHasta.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxFechaDesde.Text, TxFechaHasta.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Punto de venta", cbPuntoVenta)
        Dim ubicacion As String = FiltroCheckedComboBox("Ubicación", CbSituacion)

        Dim RbTipoListado As RadioButton() = {RbResumido, RbDetallado}
        Dim StrTipoListado As String() = {"Resumido", "Detallado"}
        Dim TipoListado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)

        Dim RbPaletsTerminados As RadioButton() = {RbTerminados, RbNoTerminados, RbTodosTerminados}
        Dim StrPaletsTerminados As String() = {"SI", "NO", "TODOS"}
        Dim PaletsTerminados As String = FiltroRadioButton("Palets terminados", RbPaletsTerminados, StrPaletsTerminados)

        Dim RbTipoPalets As RadioButton() = {RbEnExistencias, RbCargados, RbTodos}
        Dim StrTipoPalets As String() = {"En existencias", "Cargados", "Todos"}
        Dim TipoPalets As String = FiltroRadioButton("Tipo de palets", RbTipoPalets, StrTipoPalets)


        If generos <> "" Then LineasDescripcion.Add(generos)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If ubicacion <> "" Then LineasDescripcion.Add(ubicacion)
        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)
        If PaletsTerminados <> "" Then LineasDescripcion.Add(PaletsTerminados)
        If TipoPalets <> "" Then LineasDescripcion.Add(TipoPalets)


        MyBase.Imprimir()

    End Sub


    Private Sub CalculaNumPalets()

        'Número de palets diferentes
        Dim cont As Integer = 0

        Dim DcPalet As New Dictionary(Of Integer, Integer)
        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                Dim IdPalet As Integer = VaInt(row("IdPalet"))
                If Not DcPalet.ContainsKey(IdPalet) Then
                    DcPalet(IdPalet) = IdPalet
                    cont = cont + 1
                End If
            End If

        Next

        LbNumPalets.Text = "Nº Palets: " & cont.ToString

    End Sub

End Class