
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaPalets
    Inherits FrConsulta


    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim ConfecPalets As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasGeneros As New E_FamiliasGeneros(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)

    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)

    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Usuarios As New E_Usuarios(Idusuario, CnComun)


    Dim err As New Errores

    Dim _NumPalets As Integer = 0


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Palets.PAL_fecha, Lb1)
        ParamTx(TxDato2, Palets.PAL_fecha, Lb2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        cbPuntoVenta.CheckAll()
        CbSituacion = ComboPuntoventa(CbSituacion, MiMaletin.IdPuntoVenta)
        CbFamilias = ComboFamilias(CbFamilias)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()
        _NumPalets = 0

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_Lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(Palets_Lineas.PLL_idpalet, "IdPalet")
        consulta.SelCampo(Palets.PAL_palet, "Palet", Palets_Lineas.PLL_idpalet, Palets.PAL_idpalet)
        consulta.SelCampo(Palets.PAL_Lote, "Lote")
        consulta.SelCampo(Palets.PAL_fecha, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PVenta", Palets.PAL_idpuntoventa, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(Palets_Lineas.PLL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria, CategoriasSalida.CAS_Id)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca)
        consulta.SelCampo(ConfecPalets.CPA_Nombre, "ConfecPalet", Palets.PAL_idtipopalet, ConfecPalets.CPA_Idconfec)
        consulta.SelCampo(Palets_Lineas.PLL_idtipoconfeccion, "IdConfecEnvase")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "ConfecEnvase", Palets_Lineas.PLL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        consulta.SelCampo(Palets_Lineas.PLL_idgensal, "IdPresentacion")
        consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ConfecEnvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(Palets_Lineas.PLL_calidad, "Cal")
        Dim oDias As New Cdatos.bdcampo("@DATEDIFF(day, PAL_Fecha, GETDATE())", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(oDias, "Dias")
        Dim oNumPalets As New Cdatos.bdcampo("@0", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(oNumPalets, "NumPalets")
        consulta.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosnetos, "KilosNetos")
        Dim oKxB As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, Palets_Lineas.PLL_kilosxbulto.Longitud, Palets_Lineas.PLL_kilosxbulto.Decimales)
        consulta.SelCampo(oKxB, "KxB")
        consulta.SelCampo(Palets_Lineas.PLL_kilosbrutos, "KgBrutos")
        If ChkVisualizarMermas.Checked Then
            consulta.SelCampo(Palets_Lineas.PLL_kilosxbulto, "KxBCliente")
            consulta.SelCampo(Palets_Lineas.PLL_Merma, "Merma")
            Dim KilosTeoricos As New Cdatos.bdcampo("@PLL_Bultos * PLL_KilosxBulto", Cdatos.TiposCampo.Importe, Palets_Lineas.PLL_kiloscliente.Longitud, Palets_Lineas.PLL_kiloscliente.Decimales)
            consulta.SelCampo(KilosTeoricos, "KgTeoricos")
            Dim PorCenMerma As New Cdatos.bdcampo("@CASE COALESCE(PLL_Bultos * PLL_KilosxBulto,0) WHEN 0 THEN 0 ELSE PLL_Merma / (PLL_Bultos * PLL_KilosxBulto) * 100 END", Cdatos.TiposCampo.Importe, 3, 2)
            consulta.SelCampo(PorCenMerma, "PorCenMerma")
            consulta.SelCampo(Palets.PAL_IdUsuarioLog, "IdUsuario")
            consulta.SelCampo(Usuarios.Nombre, "Usuario", Palets.PAL_IdUsuarioLog, Usuarios.IdUsuario)
        End If
        consulta.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Palets.ASP_IdAlbaran)
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "FSalida")
        If RbClienteSalidas.Checked = True Then
            consulta.SelCampo(AlbSalida.ASA_idcliente, "CodCli")
            consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)
        Else
            consulta.SelCampo(Palets.PAL_idclientepedido, "CodCli")
            consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Palets.PAL_idclientepedido)
        End If
        consulta.SelCampo(Palets.PAL_HoraConfeccion, "HoraConf")


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Palets.PAL_fecha, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Palets.PAL_fecha, "<=", TxDato2.Text)


        Dim WHE As String = consulta.Whe

        'Existencias
        If RbEnExistencias.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) = 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) = 0" & vbCrLf
            End If
        ElseIf RbNoEnExistencias.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) <> 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) <> 0" & vbCrLf
            End If
        End If


        'Entradas confeccionadas
        If rbEntradasConfeccionadas.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(PLL_IdLineaEntradaConfeccionada,0) <> 0 "
            Else
                WHE = WHE & " AND COALESCE(PLL_IdLineaEntradaConfeccionada,0) <> 0 "
            End If
        ElseIf rbNOEntradasConfeccionadas.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(PLL_IdLineaEntradaConfeccionada,0) = 0 "
            Else
                WHE = WHE & " AND COALESCE(PLL_IdLineaEntradaConfeccionada,0) = 0 "
            End If
        End If

        'envase propio
        If RbEnvPropioSI.Checked Then
            If WHE = "" Then
                WHE = " WHERE PAL_ENVASEPROPIO='S'"
            Else
                WHE = WHE & " AND PAL_ENVASEPROPIO='S' "
            End If
        ElseIf RbEnvPropioNO.Checked Then
            If WHE = "" Then
                WHE = " WHERE PAL_ENVASEPROPIO<>'S' "
            Else
                WHE = WHE & " AND PAL_ENVASEPROPIO<>'S' "
            End If
        End If


        'PV
        If WHE = "" Then
            WHE = CadenaWhereLista(Palets.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Palets.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If


        'Situacion
        Dim lstSituacion As List(Of String) = ListadeCombo(CbSituacion)
        If lstSituacion.Count > 0 Then

            Dim sqlSituacion As String = ""

            For Each pv As String In lstSituacion
                If sqlSituacion.Trim <> "" Then sqlSituacion = sqlSituacion & " OR "
                sqlSituacion = sqlSituacion & " (CASE COALESCE(PAL_IdPVSituacion,0) WHEN 0 THEN PAL_IdPuntoVenta ELSE PAL_IdPVSituacion END) = " & pv & vbCrLf
            Next

            If WHE = "" Then
                sqlSituacion = " WHERE ( " & sqlSituacion & " )"
            Else
                sqlSituacion = " AND ( " & sqlSituacion & " ) "
            End If
            WHE = WHE & sqlSituacion & vbCrLf

        End If



        'Dim sql As String = consulta.Sel(ChkTodos.Checked) + WHE + " order by fecha"
        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) + WHE + " order by fecha"


        GridView1.Columns.Clear()
        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)


        Dim DcPalets As New Dictionary(Of Integer, Integer)
        For Each row As DataRow In dt.Rows
            Dim IdPalet As Integer = VaInt(row("IdPalet"))
            If Not DcPalets.ContainsKey(IdPalet) Then

                row("NumPalets") = 1
                DcPalets(IdPalet) = IdPalet

                Dim KxB As Decimal = 0
                Dim KilosNetos As Decimal = VaDec(row("KilosNetos"))
                Dim Bultos As Integer = VaInt(row("Bultos"))

                If Bultos <> 0 Then KxB = KilosNetos / Bultos

                row("KxB") = KxB

            End If
        Next

        'Número real del total de palets distintos
        _NumPalets = DcPalets.Keys.Count



        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("KilosNetos", "{0:n2}")
        AñadeResumenCampo("NumPalets", "{0:n0}")
        AñadeResumenCampo("KgBrutos", "{0:n2}")
        AñadeResumenCampo("Merma", "{0:n2}")
        AñadeResumenCampo("KxB", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("KgTeoricos", "{0:n2}")
        AñadeResumenCampo("KxBCliente", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("PorCenMerma", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)



        AjustaColumnas()


        CalculaNumPalets()


    End Sub


  
    Private Sub AjustaColumnas()

        ''Si hay agrupación, muestra la columna con palets
        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    If Not IsNothing(GridView1.Columns.ColumnByFieldName("Palets")) Then
        '        GridView1.Columns.ColumnByFieldName("Palets").Visible = False
        '        If c.GroupIndex >= 0 Then
        '            GridView1.Columns.ColumnByFieldName("Palets").Visible = True
        '        End If
        '    End If
        'Next


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "PALET", "FECHA", "PVENTA", "GENERO", "CATEGORIA", "MARCA", "CONFECPALET", "BULTOS", "KILOSNETOS", "KGBRUTOS", "ALBARAN", "FSALIDA", "CODCLI", "CLIENTE", "CAL", "DIAS", "PRESENTACION", "LOTE", "KXB", "KXBCLIENTE", "MERMA", "PORCENMERMA", "USUARIO"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PALET"
                    c.MinWidth = 75
                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 85
                Case "KILOSNETOS", "KGBRUTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85
                Case "CATEGORIA"
                    c.Width = 75
                Case "FECHA"
                    c.MinWidth = 80
                    c.MaxWidth = 80

                Case "FSALIDA"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.Caption = "F.Salida"

                Case "CODCLI"
                    c.Width = 50

                Case "LOTE"
                    c.MinWidth = 45
                    c.MaxWidth = 45

                Case "KXB"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 45
                    c.MaxWidth = 45

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


            End Select
        Next


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
                        Dim KilosTeoricos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        If Bultos <> 0 Then KxBCli = KilosTeoricos / Bultos

                        e.TotalValue = KxBCli

                    End If

                    If item.FieldName.ToUpper.Trim = "PORCENMERMA" Then

                        Dim xMerma As Decimal = 0

                        Dim Merma As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                        Dim KilosTeoricos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
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

                        Dim colKilosNetos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("KilosNetos")
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


    Public Overrides Sub ColumnFilterChanged(sender As Object, e As System.EventArgs)
        MyBase.ColumnFilterChanged(sender, e)

        CalculaNumPalets()

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


    Public Overrides Sub Imprimir()

        Dim PuntoVenta As String = ""
        Dim Familias As String = ""

        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)

        For Each s As String In lstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next
        For Each s As String In lstFamilias
            If Familias <> "" Then Familias = Familias & ","
            Familias = Familias & s
        Next



        LineasDescripcion.Clear()
        If TxDato1.Text.Trim <> "" Or TxDato2.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDato1.Text & " hasta " & TxDato2.Text)
        If PuntoVenta <> "" Then LineasDescripcion.Add("Punto de Venta: " & PuntoVenta)
        If Familias <> "" Then LineasDescripcion.Add("Familias: " & Familias)
        If RbClientePalet.Checked Then
            LineasDescripcion.Add("Imprimir cliente palets")
        ElseIf RbClienteSalidas.Checked Then
            LineasDescripcion.Add("Imprimir cliente salidas")
        End If
        If RbEnExistencias.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: SI")
        ElseIf RbNoEnExistencias.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: NO")
        ElseIf RbTodos.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: TODOS")
        End If
        If rbEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas directas: SI")
        ElseIf rbNOEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas directas: NO")
        ElseIf rbTodasEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas directas: TODOS")
        End If


        MyBase.Imprimir()
    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim dt As DataTable = CType(Grid.DataSource, DataTable)



        Dim bDatos As Boolean = True

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim dv As New DataView(dt)
                dv.Sort = "IdGenero, IdPresentacion, Palet, Fecha"
                dt = dv.ToTable

                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
                Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)
                Dim ImprimirCliente As String = ""
                Dim MostrarPartidas As String = ""
                Dim EnExistencias As String = "En existencias: "
                Dim Confeccionadas As String = "Entradas directas: "
                Dim EnvasePropio As String = "Envase propio: "

                If RbClientePalet.Checked Then
                    ImprimirCliente = "Imprimir cliente: PALET"
                ElseIf RbClienteSalidas.Checked Then
                    ImprimirCliente = "Imprimir cliente: PALET"
                End If


                If RbEnExistencias.Checked Then
                    EnExistencias = EnExistencias & "SI"
                ElseIf RbNoEnExistencias.Checked Then
                    EnExistencias = EnExistencias & "NO"
                ElseIf RbTodos.Checked Then
                    EnExistencias = EnExistencias & "Todo"
                End If

                If rbEntradasConfeccionadas.Checked Then
                    Confeccionadas = Confeccionadas & "SI"
                ElseIf rbNOEntradasConfeccionadas.Checked Then
                    Confeccionadas = Confeccionadas & "NO"
                ElseIf rbTodasEntradasConfeccionadas.Checked Then
                    Confeccionadas = Confeccionadas & "Todo"
                End If

                If RbEnvPropioSI.Checked Then
                    EnvasePropio = EnvasePropio & "SI"
                ElseIf RbEnvPropioNO.Checked Then
                    EnvasePropio = EnvasePropio & "NO"
                ElseIf RbEnvPropioTodos.Checked Then
                    EnvasePropio = EnvasePropio & "Todo"
                End If


                'ImprimirConsultaPalets(dt, TxDato1.Text, TxDato2.Text, lstPuntoVenta, lstFamilias, ImprimirCliente,
                '                        EnExistencias, Confeccionadas, EnvasePropio, chkMostrarPartidas.Checked)

                Dim listado As New Listado_ConsultaPalets(dt, TxDato1.Text, TxDato2.Text, lstPuntoVenta, lstFamilias,
                                        ImprimirCliente, EnExistencias, Confeccionadas, EnvasePropio, chkMostrarPartidas.Checked, TipoImpresion.Preliminar)
                listado.ImprimirListado()

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


    Public Overrides Sub StartGrouping(sender As Object, e As System.EventArgs)
        MyBase.StartGrouping(sender, e)


        'Si hay agrupación, muestra la columna con palets
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            If Not IsNothing(GridView1.Columns.ColumnByFieldName("NumPalets")) Then
                GridView1.Columns.ColumnByFieldName("NumPalets").Visible = False
                If c.GroupIndex >= 0 Then
                    GridView1.Columns.ColumnByFieldName("NumPalets").Visible = True
                    Exit For
                End If
            End If
        Next

    End Sub

    
End Class