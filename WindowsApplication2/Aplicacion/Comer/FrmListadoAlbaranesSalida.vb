
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmListadoAlbaranesSalida
    Inherits FrConsulta


    Private Enum TipoListado
        Detallado = 1
        Resumido = 2
        DetalladoPorPalet = 3
        ResumidoPorGeneroYCateg = 4
        ResumidoPorGenero = 5
    End Enum



    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
    Dim _IdDomicilioDesde As Integer
    Dim _IdDomicilioHasta As Integer


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

        ParamTx(TxClienteDesde, Clientes.CLI_Codigo, LbDesdeAgricultor)
        ParamTx(TxClienteHasta, Clientes.CLI_Codigo, LbHastaAgricultor)
        ParamTx(TxFechaDesde, AlbSalida.ASA_fechasalida, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbSalida.ASA_fechasalida, LbHastaFecha, True)
        ParamTx(TxAlbaranDesde, AlbSalida.ASA_albaran, LbDesdeAlbaran)
        ParamTx(TxAlbaranHasta, AlbSalida.ASA_albaran, LbHastaAlbaran)
        ParamTx(TxGeneroDesde, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxGeneroHasta, Generos.GEN_IdGenero, LbHastaGenero)
        ParamTx(TxCategDesde, Categorias.CAS_Id, LbDesdeCateg)
        ParamTx(TxCategHasta, Categorias.CAS_Id, LbHastaCateg)
        ParamTx(TxDomicilioDesde, ClientesDescargas.CLD_Id, LbDomicilioDesde)
        ParamTx(TxDomicilioHasta, ClientesDescargas.CLD_Id, LbDomicilioHasta)



        AsociarControles(TxClienteDesde, BtBuscaAgricultorDesde, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxClienteHasta, BtBuscaAgricultorHasta, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomAgricultorHasta)
        AsociarControles(TxAlbaranDesde, BtBuscaAlbaranDesde, AlbSalida.btBusca, AlbSalida)
        AsociarControles(TxAlbaranHasta, BtBuscaAlbaranHasta, AlbSalida.btBusca, AlbSalida)
        AsociarControles(TxGeneroDesde, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxGeneroHasta, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)
        AsociarControles(TxCategDesde, BtBuscaCategDesde, Categorias.btBusca, Categorias, Categorias.CAS_CategoriaCalibre, LbNomCategDesde)
        AsociarControles(TxCategHasta, BtBuscaCategHasta, Categorias.btBusca, Categorias, Categorias.CAS_CategoriaCalibre, LbNomCategHasta)
        AsociarControles(TxDomicilioDesde, BtBuscaDomicilioDesde, ClientesDescargas.btBusca, ClientesDescargas)
        AsociarControles(TxDomicilioHasta, BtBuscaDomicilioHasta, ClientesDescargas.btBusca, ClientesDescargas)




    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'BImprimir.Visible = False


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente



        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        CargaComboTipoListado()


        CbTipoListado.SelectedIndex = 0

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

        BtBuscaDomicilioDesde.CL_Filtro = ""
        BtBuscaDomicilioHasta.CL_Filtro = ""
        LbNomDomicilioDesde.Text = ""
        LbNomDomicilioHasta.Text = ""
        _IdDomicilioDesde = 0
        _IdDomicilioHasta = 0

    End Sub


    Private Sub CargaComboTipoListado()

        Dim dt As New DataTable
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        Dim row As DataRow = dt.NewRow()
        row("Id") = TipoListado.Detallado
        row("Nombre") = "Detallado"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.Resumido
        row("Nombre") = "Resumido"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.DetalladoPorPalet
        row("Nombre") = "Detallado por palet"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.ResumidoPorGeneroYCateg
        row("Nombre") = "Resumido por Género y Categoría"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.ResumidoPorGenero
        row("Nombre") = "Resumido por Género"
        dt.Rows.Add(row)


        CbTipoListado.DataSource = dt
        CbTipoListado.ValueMember = "Id"
        CbTipoListado.DisplayMember = "Nombre"

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim IdTipoListado As Integer = VaInt(CbTipoListado.SelectedValue)
        If IdTipoListado > 0 Then


            Dim sql As String = ""

            Select Case IdTipoListado

                Case TipoListado.Detallado
                    sql = SQL_Detallado()

                Case TipoListado.Resumido
                    sql = SQL_Resumido()

                Case TipoListado.DetalladoPorPalet
                    sql = SQL_DetalladoPorPalet()

                Case TipoListado.ResumidoPorGeneroYCateg
                    sql = SQL_ResumidoPorGeneroYCateg()

                Case TipoListado.ResumidoPorGenero
                    sql = SQL_ResumidoGenero()

            End Select



            GridView1.Columns.Clear()



            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            Grid.DataSource = dt



            'OJO con las mayúsculas / minúsculas
            AñadeResumenCampo("BultosSal", "{0:n0}")
            AñadeResumenCampo("BultosVen", "{0:n0}")
            AñadeResumenCampo("KilosSal", "{0:n0}")
            AñadeResumenCampo("KilosVen", "{0:n0}")
            AñadeResumenCampo("ImporteSal", "{0:n2}")
            AñadeResumenCampo("ImporteVen", "{0:n2}")
            'AñadeResumenCampo("PrecioSal", "{0:n4}")
            AñadeResumenCampo("PrecioVen", "{0:n4}", DevExpress.Data.SummaryItemType.Custom)
            
            AñadeResumenCampo("Diferencia", "{0:n2}")
            AñadeResumenCampo("BultosRechazados", "{0:n0}")
            AñadeResumenCampo("PorCenRechazados", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
            AñadeResumenCampo("NivelServicio", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
            AñadeResumenCampo("ImporteEnv", "{0:n2}")


            AjustaColumnas()

            If IdTipoListado = TipoListado.ResumidoPorGeneroYCateg Then
                If Not IsNothing(GridView1.Columns.ColumnByFieldName("Presentacion")) Then
                    GridView1.Columns.ColumnByFieldName("Presentacion").Visible = True
                End If

            End If


        End If


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PRECIOVEN" Then

                        Dim precio As Decimal = 0

                        Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                        Dim Importe As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                        If Kilos <> 0 Then precio = Importe / Kilos

                        e.TotalValue = precio

                    ElseIf item.FieldName.ToUpper.Trim = "PORCENRECHAZADOS" Then

                        Dim porcentaje As Decimal = 0

                        Dim BultosSal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim BultosRechazados As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))
                        If BultosSal <> 0 Then porcentaje = BultosRechazados / BultosSal * 100

                        e.TotalValue = porcentaje

                    ElseIf item.FieldName.Trim.ToUpper = "NIVELSERVICIO" Then

                        Dim servicio As Decimal = 100.0
                        Dim porcentaje As Decimal = 0

                        Dim BultosSal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim BultosRechazados As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))

                        If BultosSal <> 0 Then porcentaje = BultosRechazados / BultosSal * 100

                        e.TotalValue = servicio - porcentaje

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim precio As Decimal = 0

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PRECIOVEN" Then

                        Dim kilos As Decimal = 0
                        Dim Importe As Decimal = 0

                        Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("KilosVen")
                        If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                        Dim colImporte As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("ImporteVen")
                        If Not IsNothing(colImporte) Then Importe = VaDec(colImporte.SummaryItem.SummaryValue)

                        If kilos <> 0 Then precio = Importe / kilos

                        e.TotalValue = precio

                    ElseIf item.FieldName.Trim.ToUpper = "PORCENRECHAZADOS" Then

                        Dim BultosSal As Decimal = 0
                        Dim BultosRechazados As Decimal = 0
                        Dim porcentaje As Decimal = 0

                        Dim colBultosSal As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("BultosSal")
                        If Not IsNothing(colBultosSal) Then BultosSal = VaDec(colBultosSal.SummaryItem.SummaryValue)

                        Dim colBultosRechazados As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("BultosRechazados")
                        If Not IsNothing(colBultosRechazados) Then BultosRechazados = VaDec(colBultosRechazados.SummaryItem.SummaryValue)


                        If BultosSal <> 0 Then porcentaje = BultosRechazados / BultosSal * 100

                        e.TotalValue = porcentaje


                    ElseIf item.FieldName.Trim.ToUpper = "NIVELSERVICIO" Then

                        Dim BultosSal As Decimal = 0
                        Dim BultosRechazados As Decimal = 0
                        Dim servicio As Decimal = 100.0
                        Dim porcentaje As Decimal = 0


                        Dim colBultosSal As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("BultosSal")
                        If Not IsNothing(colBultosSal) Then BultosSal = VaDec(colBultosSal.SummaryItem.SummaryValue)

                        Dim colBultosRechazados As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("BultosRechazados")
                        If Not IsNothing(colBultosRechazados) Then BultosRechazados = VaDec(colBultosRechazados.SummaryItem.SummaryValue)


                        If BultosSal <> 0 Then porcentaje = BultosRechazados / BultosSal * 100

                        e.TotalValue = servicio - porcentaje

                    End If



                End If

            End If




        Catch ex As Exception

        End Try

    End Sub


    Public Function SQL_Detallado() As String

        Dim sqlBase As String = SQL_ConsultaBase()


        Dim sql As String = "SELECT IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran," & vbCrLf
        If ChkDesgloseRechazos.Checked Then
            sql = sql & " Referencia," & vbCrLf
        End If
        sql = sql & " Fecha, IdPedido, Pedido, IdFactura, Campa, Serie, Factura, Matricula," & vbCrLf
        sql = sql & " IdGenero, Genero, IdFamilia, Familia, IdPresentacion, Presentacion, IdCategoria, Categoria, " & vbCrLf
        sql = sql & " SUM(BultosSal) as BultosSal, SUM(BultosVen) as BultosVen, SUM(KilosSal) as KilosSal, SUM(KilosVen) as KilosVen," & vbCrLf
        sql = sql & " PrecioSal, PrecioVen, TipoPrecio as TP, SUM(ImporteSal) as ImporteSal, SUM(ImporteVen) as ImporteVen," & vbCrLf
        If ChkDesgloseRechazos.Checked Then
            sql = sql & " SUM(COALESCE(ImporteVen,0) - COALESCE(ImporteSal,0)) as Diferencia, ImporteEnv," & vbCrLf
            sql = sql & " SUM(COALESCE(BultosRechazados,0)) as BultosRechazados, " & vbCrLf
            sql = sql & " CASE SUM(COALESCE(BultosSal, 0)) WHEN 0 THEN 0 ELSE SUM(COALESCE(BultosRechazados,0)) / SUM(COALESCE(BultosSal, 0)) * 100 END AS PorCenRechazados," & vbCrLf
            sql = sql & " CASE SUM(COALESCE(BultosSal, 0)) WHEN 0 THEN 100 ELSE 100 - (SUM(COALESCE(BultosRechazados,0)) / SUM(COALESCE(BultosSal, 0)) * 100) END AS NivelServicio " & vbCrLf
        Else
            sql = sql & " SUM(COALESCE(ImporteVen,0) - COALESCE(ImporteSal,0)) as Diferencia, ImporteEnv" & vbCrLf
        End If
        sql = sql & " FROM" & vbCrLf
        sql = sql & "  (" & vbCrLf & sqlBase & ") as G" & vbCrLf
        sql = sql & " GROUP BY IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran, Referencia, Fecha, IdPedido, Pedido, IdFactura, Campa, Serie, Factura, Matricula," & vbCrLf
        sql = sql & " IdGenero, Genero, IdFamilia, Familia, IdPresentacion, Presentacion, IdCategoria, Categoria, PrecioSal, TipoPrecio, PrecioVen, ImporteEnv" & vbCrLf
        sql = sql & "  ORDER BY IdCliente, IdDomicilio, Albaran, Fecha, IdGenero, IdPresentacion, IdCategoria" & vbCrLf


        Return sql

    End Function


    Public Function SQL_Resumido() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran, Fecha, IdPedido, Pedido, IdFactura, Campa, Serie, Factura, Matricula," & vbCrLf & _
            " SUM(BultosSal) as BultosSal, SUM(BultosVen) as BultosVen, SUM(KilosSal) as KilosSal, SUM(KilosVen) as KilosVen," & vbCrLf & _
            " SUM(ImporteSal) as ImporteSal, SUM(ImporteVen) as ImporteVen," & vbCrLf & _
            " SUM(COALESCE(ImporteVen,0) - COALESCE(ImporteSal,0)) as Diferencia, ImporteEnv" & vbCrLf & _
            " FROM" & vbCrLf & _
            " (" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran, Fecha, IdPedido, Pedido, IdFactura, Campa, Serie, Factura, Matricula," & vbCrLf & _
            " ImporteEnv" & vbCrLf & _
            " ORDER BY IdCliente, IdDomicilio, Albaran, Fecha" & vbCrLf



        Return sql

    End Function


    Public Function SQL_DetalladoPorPalet() As String

        Dim sql As String = SQL_ConsultaBasePalets()


        sql = "SELECT IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran, Fecha, IdPedido, Pedido, IdPresentacion, Presentacion, IdFamilia, Familia, IdCategoria, Categoria, " & vbCrLf & _
            " IdMarca, Marca, IdPalet, Palet, FechaPal, 0 as Palets, SUM(Bultos) as Bultos, SUM(Kilos) as Kilos" & vbCrLf & _
            " FROM" & vbCrLf & _
            " (" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdCliente, Cliente, IdDomicilio, Domicilio, IdAlbaran, Albaran, Fecha, IdPedido, Pedido, IdPresentacion, Presentacion, IdFamilia, Familia, IdCategoria, Categoria, " & vbCrLf & _
            " IdMarca, Marca, IdPalet, Palet, FechaPal" & vbCrLf & _
            "ORDER BY IdCliente, IdDomicilio, Albaran, Fecha, IdPresentacion, IdCategoria" & vbCrLf




        Return sql

    End Function


    Public Function SQL_ResumidoPorGeneroYCateg() As String

        Dim sql As String = SQL_ConsultaBase()

        sql = "SELECT IdGenero, Genero, IdFamilia, Familia, IdCategoria, Categoria, IdPresentacion, Presentacion," & vbCrLf & _
            " SUM(KilosSal) as KilosSal, SUM(KilosVen) as KilosVen," & vbCrLf & _
            " SUM(COALESCE(KilosVen,0) - COALESCE(KilosSal,0)) as DifKilos," & vbCrLf & _
            " SUM(ImporteSal) as ImporteSal, SUM(ImporteVen) as ImporteVen," & vbCrLf & _
            " SUM(COALESCE(ImporteVen,0) - COALESCE(ImporteSal,0)) as Diferencia" & vbCrLf & _
            " FROM" & vbCrLf & _
            " (" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdGenero, Genero, IdFamilia, Familia, IdPresentacion, Presentacion, IdCategoria, Categoria" & vbCrLf & _
            " ORDER BY IdGenero, IdPresentacion, IdCategoria" & vbCrLf


        Return sql

    End Function


    Public Function SQL_ResumidoGenero() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdGenero, Genero, IdFamilia, Familia," & vbCrLf & _
            " SUM(KilosSal) as KilosSal, SUM(KilosVen) as KilosVen," & vbCrLf & _
            " SUM(COALESCE(KilosVen,0) - COALESCE(KilosSal,0)) as DifKilos," & vbCrLf & _
            " SUM(ImporteSal) as ImporteSal, SUM(ImporteVen) as ImporteVen," & vbCrLf & _
            " SUM(COALESCE(ImporteVen,0) - COALESCE(ImporteSal,0)) as Diferencia" & vbCrLf & _
            " FROM" & vbCrLf & _
            " (" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdGenero, Genero, IdFamilia, Familia" & vbCrLf & _
            " ORDER BY IdGenero " & vbCrLf



        Return sql

    End Function



    Private Function SQL_ConsultaBase() As String

        Dim sql As String = ""
        Dim sqlWhere As String = ""


        sql = sql & "SELECT ASA_IdCliente as IdCliente, CLI_Nombre as Cliente, ASA_IdAlbaran as IdAlbaran, ASA_IdFactura as IdFactura, FRA_Campa as Campa, " & vbCrLf
        sql = sql & " FRA_Serie as Serie, FRA_Factura as Factura, ASA_MatriculaRemolque as Matricula," & vbCrLf
        'sql = sql & " CLD_Numero as IdDomicilio, CLD_Poblacion + ' / ' + CLD_Provincia as Domicilio," & vbCrLf
        sql = sql & " CLD_Numero as IdDomicilio, CLD_Domicilio as Domicilio," & vbCrLf
        sql = sql & " ASA_Albaran as Albaran, ASA_Referencia as Referencia, ASA_FechaSalida as Fecha, ASA_IdPedido as IdPedido, PED_Pedido as Pedido, ASL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " SFA_IdFamilia as IdFamilia, FAG_Nombre as Familia," & vbCrLf
        sql = sql & " ASL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, " & vbCrLf
        sql = sql & " ASL_IdCategoria as IdCategoria, CAS_CategoriaCalibre as Categoria, ASL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " ASL_Bultos as BultosSal, ASL_BultosVendidos as BultosVen," & vbCrLf
        sql = sql & " ASL_KilosNetos as KilosSal, ASL_KilosVendidos as KilosVen," & vbCrLf
        sql = sql & " COALESCE(ASL_Precio,0) * COALESCE(ASA_ValorCambio,1) as PrecioSal, COALESCE(ASL_PrecioVenta,0) * COALESCE(ASA_ValorCambio,1) as PrecioVen," & vbCrLf
        sql = sql & " CASE COALESCE(ASL_TipoPrecio,'K') WHEN '' THEN 'K' ELSE COALESCE(ASL_TipoPrecio,'K') END as TipoPrecio," & vbCrLf
        sql = sql & " COALESCE(ASL_ImporteGenero,0) * COALESCE(ASA_ValorCambio,1) as ImporteSal, COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1) as ImporteVen," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase) as ImporteEnv"
        If ChkDesgloseRechazos.Checked Then
            sql = sql & ", CAST(RCL_BultosEstimados AS DECIMAL) as BultosRechazados"
        End If
        sql = sql & vbCrLf

        sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON ASL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_idsubfamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN FamiliasGeneros ON FAG_idfamilia = SFA_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasSalida ON CAS_Id = ASL_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = ASA_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = ASL_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN ClientesDescargas ON CLD_Id = ASA_IdDomicilio" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON ASL_IdMarca = MAR_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Pedidos ON PED_IdPedido = ASA_IdPedido" & vbCrLf
        If ChkDesgloseRechazos.Checked Then
            sql = sql & " LEFT JOIN Reclama ON RCL_IdLinAlb = ASL_IdLinea" & vbCrLf
        End If

        If TxClienteDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente >= " & TxClienteDesde.Text)
        If TxClienteHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente <= " & TxClienteHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida <= '" & TxFechaHasta.Text & "'")
        If TxAlbaranDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_Albaran >= " & TxAlbaranDesde.Text)
        If TxAlbaranHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_Albaran <= " & TxAlbaranHasta.Text)
        If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdGenero >= " & TxGeneroDesde.Text)
        If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdGenero <= " & TxGeneroHasta.Text)
        If TxCategDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdCategoria >= " & TxCategDesde.Text)
        If TxCategHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdCategoria <= " & TxCategHasta.Text)
        If _IdDomicilioDesde <> 0 Then AñadeCondicion(sqlWhere, "ASA_IdDomicilio >= " & _IdDomicilioDesde.ToString)
        If _IdDomicilioHasta <> 0 Then AñadeCondicion(sqlWhere, "ASA_IdDomicilio <= " & _IdDomicilioHasta.ToString)
        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta)))

        'FC
        If RbVtaFirme.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'F'")
        ElseIf RbVtaComision.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'C'")
        End If

        'Precio Salida
        If RbSIPrecioSalida.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASL_Precio,0) <> 0")
        ElseIf RbNOPrecioSalida.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASL_Precio,0) = 0")
        End If

        'Valorados
        If RbSiValorados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_FechaValoracion, '" & VaDate("").ToString("dd/MM/yyyy") & "') > '" & VaDate("").ToString("dd/MM/yyyy") & "'")
        ElseIf RbNoValorados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_FechaValoracion, '" & VaDate("").ToString("dd/MM/yyyy") & "') <= '" & VaDate("").ToString("dd/MM/yyyy") & "'")
        End If

        'Facturado
        If RbSIFacturado.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) > 0")
        ElseIf RbNOFacturado.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) = 0")
        End If



        sql = sql & sqlWhere



        Return sql

    End Function


    Private Function SQL_ConsultaBasePalets() As String

        Dim sql As String = ""
        Dim sqlWhere As String = ""


        sql = sql & " SELECT ASA_IdCliente as IdCliente, CLI_Nombre as Cliente, ASA_IdAlbaran as IdAlbaran, " & vbCrLf
        sql = sql & " CLD_Numero as IdDomicilio, CLD_Poblacion + ' / ' + CLD_Provincia as Domicilio," & vbCrLf
        sql = sql & " ASA_Albaran as Albaran, ASA_FechaSalida as Fecha, ASA_IdPedido as IdPedido, PED_Pedido as Pedido," & vbCrLf
        sql = sql & " SFA_IdFamilia as IdFamilia, FAG_Nombre as Familia," & vbCrLf
        sql = sql & " ASL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " ASL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion," & vbCrLf
        sql = sql & " ASL_IdCategoria as IdCategoria, CAS_CategoriaCalibre as Categoria, ASL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " ASP_IdPalet as IdPalet, PAL_Palet as Palet, PAL_Fecha as FechaPal, " & vbCrLf
        sql = sql & " (SELECT SUM(PLL_Bultos) as Bultos FROM Palets_Lineas WHERE PLL_IdPalet = ASP_IdPalet) as Bultos," & vbCrLf
        sql = sql & " (SELECT SUM(PLL_KilosNetos) as Kilos FROM Palets_Lineas WHERE PLL_IdPalet = ASP_IdPalet) as Kilos" & vbCrLf
        sql = sql & " FROM AlbSalida_Palets" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Lineas ON ASL_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON ASL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_idsubfamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN FamiliasGeneros ON FAG_idfamilia = SFA_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasSalida ON CAS_Id = ASL_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = ASA_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = ASL_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN ClientesDescargas ON CLD_Id = ASA_IdDomicilio" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON ASL_IdMarca = MAR_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = ASP_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN Pedidos ON PED_IdPedido = ASA_IdPedido" & vbCrLf

        If TxClienteDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente >= " & TxClienteDesde.Text)
        If TxClienteHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente <= " & TxClienteHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida <= '" & TxFechaHasta.Text & "'")
        If TxAlbaranDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_Albaran >= " & TxAlbaranDesde.Text)
        If TxAlbaranHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_Albaran <= " & TxAlbaranHasta.Text)
        If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdGenero >= " & TxGeneroDesde.Text)
        If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdGenero <= " & TxGeneroHasta.Text)
        If TxCategDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdCategoria >= " & TxCategDesde.Text)
        If TxCategHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASL_IdCategoria <= " & TxCategHasta.Text)
        If TxDomicilioDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdDomicilio >= " & TxDomicilioDesde.Text)
        If TxDomicilioHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdDomicilio <= " & TxDomicilioHasta.Text)
        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta)))

        'FC
        If RbVtaFirme.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'F'")
        ElseIf RbVtaComision.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'C'")
        End If

        'Precio Salida
        If RbSIPrecioSalida.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASL_Precio,0) <> 0")
        ElseIf RbNOPrecioSalida.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASL_Precio,0) = 0")
        End If

        'Valorados
        If RbSiValorados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_FechaValoracion, '" & VaDate("").ToString("dd/MM/yyyy") & "') > '" & VaDate("").ToString("dd/MM/yyyy") & "'")
        ElseIf RbNoValorados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_FechaValoracion, '" & VaDate("").ToString("dd/MM/yyyy") & "') <= '" & VaDate("").ToString("dd/MM/yyyy") & "'")
        End If

        'Facturado
        If RbSIFacturado.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) > 0")
        ElseIf RbNOFacturado.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) = 0")
        End If



        sql = sql & sqlWhere



        Return sql

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

                Case "CLIENTE", "CAMPA", "SERIE", "FACTURA", "MATRICULA", "FECHA", "ALBARAN", "GENERO", "CATEGORIA", "BULTOSSAL", "BULTOSVEN", "KILOSSAL", "KILOSVEN", "PRECIOSAL", "PRECIOVEN", "IMPORTESAL", "IMPORTEVEN", "DIFERENCIA", "PRECIOENV", "IMPORTEENV", "MARCA", "PALET", "PALETS", "FECHAPAL", "BULTOS", "KILOS", "PEDIDO", "TP", "BULTOSRECHAZADOS", "PORCENRECHAZADOS", "NIVELSERVICIO", "REFERENCIA"
                    c.Visible = True

                Case Else
                    c.Visible = False

            End Select

        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDCLIENTE"
                    c.Caption = "CodCli"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    'c.GroupIndex = 0

                Case "ALBARAN"
                    'c.GroupIndex = 1

                Case "IDCATEGORIA"
                    c.Caption = "IdCat"
                    c.MinWidth = 45
                    c.MaxWidth = 45

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "BULTOSSAL", "BULTOSVEN", "PALETS", "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 60

                Case "PRECIOSAL", "PRECIOVEN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"

                Case "KILOSSAL", "KILOSVEN", "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70

                Case "IMPORTESAL", "IMPORTEVEN", "IMPORTEENV", "DIFERENCIA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 90

                Case "FECHA"
                    c.MinWidth = 80

                Case "FECHAPAL"
                    c.Caption = "F.Confec"
                    c.MinWidth = 80

                Case "PALET"
                    c.Caption = "N.Palet"
                    c.MinWidth = 65

                Case "TP"
                    c.MinWidth = 20
                    c.MaxWidth = 20

                Case "BULTOSRECHAZADOS"
                    c.Caption = "B.Rechazados"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 60

                Case "PORCENRECHAZADOS"
                    c.Caption = "%Rech"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "NIVELSERVICIO"
                    c.Caption = "N.Servicio"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "REFERENCIA"
                    c.Width = 85



            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True


        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then

                Dim IdTipoListado As Integer = VaInt(CbTipoListado.SelectedValue)
                If IdTipoListado > 0 Then


                    Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
                    Dim TipoVenta As String = ""
                    Dim ConPrecioSalida As String = ""
                    Dim Valorados As String = ""
                    Dim Facturados As String = ""


                    'FCS
                    If RbVtaFirme.Checked Then
                        TipoVenta = "Sólo Vta. Firme"
                    ElseIf RbVtaComision.Checked Then
                        TipoVenta = "Sólo Vta. Comisión"
                    Else
                        TipoVenta = "TODOS"
                    End If


                    'Precio Salida
                    If RbSIPrecioSalida.Checked Then
                        ConPrecioSalida = "Sólo CON precio salida"
                    ElseIf RbNOPrecioSalida.Checked Then
                        ConPrecioSalida = "Sólo SIN precio salida"
                    Else
                        ConPrecioSalida = "TODOS"
                    End If

                    'Valorados
                    If RbSiValorados.Checked Then
                        Valorados = "Sólo valorados"
                    ElseIf RbNoValorados.Checked Then
                        Valorados = "Sólo NO valorados"
                    Else
                        Valorados = "TODOS"
                    End If

                    'Facturados 
                    If RbSIFacturado.Checked Then
                        Facturados = "Sólo facturados"
                    ElseIf RbNOFacturado.Checked Then
                        Facturados = "Sólo NO facturados"
                    Else
                        Facturados = "TODOS"
                    End If

                    Dim tList As Integer = 0

                    Select Case IdTipoListado
                        Case TipoListado.Detallado
                            tList = 0
                        Case TipoListado.Resumido
                            tList = 1
                        Case TipoListado.DetalladoPorPalet
                            tList = 2
                        Case TipoListado.ResumidoPorGeneroYCateg
                            tList = 3
                        Case TipoListado.ResumidoPorGenero
                            tList = 4
                    End Select

                    Dim listado As New Listado_ListadoAlbaranesSalida(dt, TxClienteDesde.Text, TxClienteHasta.Text, TxFechaDesde.Text, _
                                                                      TxFechaHasta.Text, TxAlbaranDesde.Text, TxAlbaranHasta.Text, _
                                                                      TxGeneroDesde.Text, TxGeneroHasta.Text, TxCategDesde.Text, _
                                                                      TxCategHasta.Text, TxDomicilioDesde.Text, TxDomicilioHasta.Text, _
                                                                      lstPuntoVenta, TipoVenta, ConPrecioSalida, Valorados, Facturados, tList,
                                                                      TipoImpresion.Preliminar)
                    listado.ImprimirListado()
                Else
                    MsgBox("Debe escoger un tipo de listado")
                End If

            Else
                bDatos = False
            End If
            Else
                bDatos = False
            End If


        If Not bdatos Then
            MsgBox("No hay datos que imprimir")
        End If


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim clientes As String = FiltroDesdeHasta("Cliente", TxClienteDesde.Text, TxClienteHasta.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxFechaDesde.Text, TxFechaHasta.Text)
        Dim generos As String = FiltroDesdeHasta("Genero", TxGeneroDesde.Text, TxGeneroHasta.Text)
        Dim categorias As String = FiltroDesdeHasta("Categoria", TxCategDesde.Text, TxCategHasta.Text)
        Dim domicilios As String = FiltroDesdeHasta("Domicilio", TxDomicilioDesde.Text, TxDomicilioHasta.Text)
        Dim tipolistado As String = CbTipoListado.SelectedText & ""
        Dim puntosventa As String = FiltroCheckedComboBox("Punto de venta", cbPuntoVenta)

        Dim RbTipoVenta As RadioButton() = {RbVtaFirme, RbVtaComision, RbTodasVentas}
        Dim StrTipoVenta As String() = {"FIRME", "COMISION", "TODAS"}
        Dim tipoventa As String = FiltroRadioButton("Tipo de venta", RbTipoVenta, StrTipoVenta)

        Dim RbPrecioSalida As RadioButton() = {RbSIPrecioSalida, RbNOPrecioSalida, RbTODOSPrecioSalida}
        Dim StrPrecioSalida As String() = {"SI", "NO", "TODOS"}
        Dim PrecioSalida As String = FiltroRadioButton("Con precio de salida", RbPrecioSalida, StrPrecioSalida)

        Dim RbValorados As RadioButton() = {RbSiValorados, RbNoValorados, RbTODOSValorados}
        Dim StrValorados As String() = {"SI", "NO", "TODOS"}
        Dim valorados As String = FiltroRadioButton("Valorados", RbValorados, StrValorados)

        Dim RbFacturados As RadioButton() = {RbSIFacturado, RbNOFacturado, RbTODOSFacturado}
        Dim StrFacturados As String() = {"SI", "NO", "TODOS"}
        Dim facturados As String = FiltroRadioButton("Facturados", RbValorados, StrValorados)

        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If generos <> "" Then LineasDescripcion.Add(generos)
        If categorias <> "" Then LineasDescripcion.Add(categorias)
        If domicilios <> "" Then LineasDescripcion.Add(domicilios)
        If tipolistado <> "" Then LineasDescripcion.Add(tipolistado)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If tipoventa <> "" Then LineasDescripcion.Add(tipoventa)
        If PrecioSalida <> "" Then LineasDescripcion.Add(PrecioSalida)
        If valorados <> "" Then LineasDescripcion.Add(valorados)
        If facturados <> "" Then LineasDescripcion.Add(facturados)


        MyBase.Imprimir()

    End Sub


    Private Sub TxClienteDesde_Valida(edicion As System.Boolean) Handles TxClienteDesde.Valida

        FiltroDomicilioCliente()

    End Sub


    Private Sub TxClienteHasta_Valida(edicion As System.Boolean) Handles TxClienteHasta.Valida

        FiltroDomicilioCliente()

    End Sub


    Private Sub FiltroDomicilioCliente()

        Dim filtro As String = ""


        If TxClienteDesde.Text.Trim <> "" Then filtro = "IdCliente >= " & TxClienteDesde.Text

        If TxClienteHasta.Text.Trim <> "" Then

            If filtro.Trim = "" Then
                filtro = "IdCliente <= " & TxClienteHasta.Text
            Else
                filtro = filtro & " AND IdCliente <= " & TxClienteHasta.Text
            End If

        End If


        BtBuscaDomicilioDesde.CL_Filtro = filtro
        BtBuscaDomicilioHasta.CL_Filtro = filtro

    End Sub

    Private Sub TxDomicilioDesde_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDomicilioDesde.TextChanged

    End Sub

    Private Sub TxDomicilioDesde_Valida(edicion As Boolean) Handles TxDomicilioDesde.Valida
        _IdDomicilioDesde = 0
        If TxDomicilioDesde.Text <> "" Then
            _IdDomicilioDesde = ClientesDescargas.LeerDomi(TxClienteDesde.Text, TxDomicilioDesde.Text)
            If _IdDomicilioDesde > 0 Then

                If ClientesDescargas.LeerId(_IdDomicilioDesde) = True Then

                    LbNomDomicilioDesde.Text = ClientesDescargas.CLD_Domicilio.Valor

                End If
            Else
                TxDomicilioDesde.MiError = True
                MsgBox("Domicilio inexistente")
            End If


        End If
    End Sub

    Private Sub TxDomicilioHasta_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDomicilioHasta.TextChanged

    End Sub

    Private Sub TxDomicilioHasta_Valida(edicion As Boolean) Handles TxDomicilioHasta.Valida
        _IdDomicilioHasta = 0
        If TxDomicilioHasta.Text <> "" Then
            _IdDomicilioHasta = ClientesDescargas.LeerDomi(TxClienteHasta.Text, TxDomicilioHasta.Text)
            If _IdDomicilioHasta > 0 Then

                If ClientesDescargas.LeerId(_IdDomicilioHasta) = True Then

                    LbNomDomicilioHasta.Text = ClientesDescargas.CLD_Domicilio.Valor

                End If
            Else
                TxDomicilioHasta.MiError = True
                MsgBox("Domicilio inexistente")
            End If


        End If

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

       Select column.FieldName.Trim.ToUpper

            Case "ALBARAN"

                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                If VaDec(IdAlbaran) > 0 Then

                    Dim frm As New FrmHiAlbSal
                    frm.init(IdAlbaran)
                    frm.ShowDialog()

                End If


            Case "FACTURA"

                Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                If VaDec(IdFactura) > 0 Then

                    Dim frm As New FrmFacturacion
                    frm.init(IdFactura)
                    frm.ShowDialog()

                End If

            Case "PEDIDO"

                Dim IdPedido As String = (row("IdPedido").ToString & "").Trim
                If VaDec(IdPedido) > 0 Then

                    Dim frm As New FrmPedidos
                    frm.init(IdPedido)
                    frm.ShowDialog()

                End If




        End Select



    End Sub

End Class