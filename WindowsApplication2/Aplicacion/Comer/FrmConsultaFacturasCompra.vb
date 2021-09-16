
Public Class FrmConsultaFacturasCompra
    Inherits FrConsulta



    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)


    Dim _DcTotalKilosFactura As New Dictionary(Of Integer, Decimal)
    Dim _DcTotalImporteGenero As New Dictionary(Of Integer, Decimal)
    Dim _DcTotalComision As New Dictionary(Of Integer, Decimal)
    Dim _DcTotalGastos As New Dictionary(Of Integer, Decimal)
    Dim _DcTotalBaseImponible As New Dictionary(Of Integer, Decimal)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeFecha, AlbEntrada.AEN_Fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, AlbEntrada.AEN_Fecha, LbHastaFecha)
        ParamTx(TxDesdeAgricultor, Agricultores.AGR_IdAgricultor, LbDesdeAgricultor)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_IdAgricultor, LbHastaAgricultor)

        AsociarControles(TxDesdeAgricultor, BtBuscaDesdeAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_DesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaHastaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_HastaAgricultor)


    End Sub


    Private Sub FrmConsultaFacturasCompra_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente
        GridView1.OptionsView.ShowGroupPanel = False


        GridView1.OptionsView.AllowCellMerge = True


        BInforme.Visible = False


        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        _DcTotalKilosFactura.Clear()
        _DcTotalImporteGenero.Clear()
        _DcTotalComision.Clear()
        _DcTotalGastos.Clear()
        _DcTotalBaseImponible.Clear()


        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim sql1 As String = "SELECT 'AGRICULTOR' as Tipo, AEH_Id as IdAlbHis, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as Fecha, AEH_Kilos as Kilos, AEH_ImporteGenero as Importe, AEH_IdFactura as IdFactura," & vbCrLf
        sql1 = sql1 & " CAST(FGR_IdEmpresa as nvarchar) + '/' + CAST(FGR_Ejercicio as nvarchar) + '/' + CAST(FGR_Serie as nvarchar) + '-' + CAST(FGR_NumeroFactur as nvarchar) as Factura, FGR_Fecha as FechaFactura, FGR_IdAgricultor as CodAgr, AGR_Nombre as Agricultor," & vbCrLf
        sql1 = sql1 & " (SELECT SUM(FAL_Kilos) FROM FacturaAgr_Lineas WHERE FAL_IdFactura = AEH_IdFactura) as KilosFactura, " & vbCrLf
        sql1 = sql1 & " FGR_IGenero as ImporteGenero, FGR_Comision as Comision, FGR_OtrosGastos as Gastos, FGR_BaseImponible as BaseImponible" & vbCrLf
        sql1 = sql1 & " FROM AlbEntrada_His" & vbCrLf
        sql1 = sql1 & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEH_IdAlbaran" & vbCrLf
        sql1 = sql1 & " LEFT JOIN FacturaAgr ON AEH_IdFactura = FGR_IdFactura" & vbCrLf
        sql1 = sql1 & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FGR_IdAgricultor" & vbCrLf
        sql1 = sql1 & " WHERE AEH_IdFactura > 0" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql1 = sql1 & " AND AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql1 = sql1 & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        If TxDesdeAgricultor.Text.Trim <> "" Then sql1 = sql1 & " AND FGR_IdAgricultor >= " & TxDesdeAgricultor.Text & vbCrLf
        If TxHastaAgricultor.Text.Trim <> "" Then sql1 = sql1 & " AND FGR_IdAgricultor <= " & TxHastaAgricultor.Text & vbCrLf
        sql1 = sql1 & " AND " + CadenaWhereLista(FacturaAgr.FGR_idempresa, ListadeCombo(CbEmpresas))



        Dim sql2 As String = " SELECT 'EMPRESA' AS Tipo, IdAlbHis, CE, Albaran, Fecha, Kilos, Importe, IdFactura, Factura, FechaFactura, CodAgr, Agricultor, KilosFactura, " & vbCrLf
        sql2 = sql2 & " ImpGenero1 + ImpGenero2 + ImpGenero3 + ImpGenero4 as ImpGenero, 0.00 as Comision, 0.00 as Gastos, " & vbCrLf
        sql2 = sql2 & " ImpGenero1 + ImpGenero2 + ImpGenero3 + ImpGenero4 as BaseImponible" & vbCrLf
        sql2 = sql2 & " FROM" & vbCrLf
        sql2 = sql2 & " (" & vbCrLf
        sql2 = sql2 & " SELECT AEH_Id as IdAlbHis, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as Fecha, AEH_Kilos as Kilos, AEH_ImporteGenero as Importe, AEH_IdFacturaFirme as IdFactura," & vbCrLf
        sql2 = sql2 & " CAST(FRR1.FRR_IdEmpresa as nvarchar) + '/' + CAST(FRR1.FRR_Ejercicio as nvarchar) + '/' + CAST(FRR1.FRR_Numero as nvarchar) as Factura, FRR1.FRR_FechaFactura as FechaFactura, " & vbCrLf
        sql2 = sql2 & " FRR1.FRR_IdProveedor as CodAgr, AGR_Nombre as Agricultor, " & vbCrLf
        'sql2 = sql2 & " (SELECT SUM(AEH_Kilos) FROM AlbEntrada_His WHERE AEH_IdFacturaFirme = FRR_Id) as KilosFactura, " & vbCrLf
        sql2 = sql2 & " 0.00 as KilosFactura," & vbCrLf
        sql2 = sql2 & " CASE FRR_Iva1 WHEN 4 THEN COALESCE(FRR_Base1,0) WHEN 10 THEN COALESCE(FRR_Base1,0) ELSE 0 END as ImpGenero1, " & vbCrLf
        sql2 = sql2 & " CASE FRR_Iva2 WHEN 4 THEN COALESCE(FRR_Base2,0) WHEN 10 THEN COALESCE(FRR_Base2,0) ELSE 0 END as ImpGenero2, " & vbCrLf
        sql2 = sql2 & " CASE FRR_Iva3 WHEN 4 THEN COALESCE(FRR_Base3,0) WHEN 10 THEN COALESCE(FRR_Base3,0) ELSE 0 END as ImpGenero3, " & vbCrLf
        sql2 = sql2 & " CASE FRR_Iva4 WHEN 4 THEN COALESCE(FRR_Base4,0) WHEN 10 THEN COALESCE(FRR_Base4,0) ELSE 0 END as ImpGenero4" & vbCrLf
        sql2 = sql2 & " FROM AlbEntrada_His" & vbCrLf
        sql2 = sql2 & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEH_IdAlbaran" & vbCrLf
        sql2 = sql2 & " LEFT JOIN FacturasRecibidas FRR1 ON FRR1.FRR_Id = AEH_IdFacturafirme" & vbCrLf
        sql2 = sql2 & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FRR_IdProveedor" & vbCrLf
        sql2 = sql2 & " WHERE AEH_IdFacturaFirme > 0" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql2 = sql2 & " AND AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql2 = sql2 & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        If TxDesdeAgricultor.Text.Trim <> "" Then sql2 = sql2 & " AND FRR_IdProveedor >= " & TxDesdeAgricultor.Text & vbCrLf
        If TxHastaAgricultor.Text.Trim <> "" Then sql2 = sql2 & " AND FRR_IdProveedor <= " & TxHastaAgricultor.Text & vbCrLf
        sql2 = sql2 & " AND " + CadenaWhereLista(FacturasRecibidas.FRR_IdEmpresa, ListadeCombo(CbEmpresas)) & vbCrLf
        sql2 = sql2 & " ) as A" & vbCrLf
        'sql = sql & " ORDER BY Factura, FGR_NumeroFactur, CE, Albaran" & vbCrLf


        Dim sql As String = ""

        If RbFacturasAgricultores.Checked Then
            sql = sql1
        ElseIf RbFacturasEmpresas.Checked Then
            sql = sql2
        ElseIf RbFacturasTodas.Checked Then
            sql = sql1 & " UNION ALL " & vbCrLf & sql2
        End If



        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        Grid.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDALBHIS", "IDFACTURA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 110
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

                Case "KILOSFACTURA"
                    c.Caption = "KilosFra"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 110
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "IMPORTEGENERO"
                    c.Caption = "ImpGenero"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "COMISION"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "GASTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "BASEIMPONIBLE"
                    c.Caption = "BaseImp"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "CODAGR"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "FECHA"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

                Case "FECHAFACTURA"
                    c.Caption = "FechaFra"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "ALBARAN"
                    c.Width = 75
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

                Case "FACTURA"
                    c.Width = 100
                    c.GroupIndex = 0
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case "AGRICULTOR"
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True

                Case Else
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

            End Select
        Next




        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")
        AñadeResumenCampo("KilosFactura", "{0:n0}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("ImporteGenero", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Comision", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Gastos", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("BaseImponible", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        'AñadeResumenCampo("ImporteGenero", "{0:n2}")


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim FiltroTransp As String = FiltroDesdeHasta("Agricultor", TxDesdeAgricultor.Text, TxHastaAgricultor.Text)
        Dim FiltroFecha As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)
        Dim FiltroEmpresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)

        Dim rbTipoFacturas As RadioButton() = {RbFacturasAgricultores, RbFacturasEmpresas, RbFacturasTodas}
        Dim strTipoFacturas As String() = {"AGRICULTORES", "EMPRESAS", "TODAS"}
        Dim FiltroTipoFacturas As String = FiltroRadioButton("Tipo de factura", rbTipoFacturas, strTipoFacturas)


        If FiltroTransp.Trim <> "" Then LineasDescripcion.Add(FiltroTransp)
        If FiltroFecha.Trim <> "" Then LineasDescripcion.Add(FiltroFecha)
        If FiltroEmpresa.Trim <> "" Then LineasDescripcion.Add(FiltroEmpresa)
        If FiltroTipoFacturas.Trim <> "" Then LineasDescripcion.Add(FiltroTipoFacturas)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item


                    If item.FieldName.Trim.ToUpper = "KILOSFACTURA" Then
                        Dim KilosFactura As Decimal = VaDec(GridView1.GetGroupRowValue(e.GroupRowHandle, GridView1.Columns(item.FieldName)))
                        e.TotalValue = KilosFactura
                        _DcTotalKilosFactura(e.GroupRowHandle) = KilosFactura
                    End If

                    If item.FieldName.Trim.ToUpper = "IMPORTEGENERO" Then
                        Dim ImporteGenero As Decimal = VaDec(GridView1.GetGroupRowValue(e.GroupRowHandle, GridView1.Columns(item.FieldName)))
                        e.TotalValue = ImporteGenero
                        _DcTotalImporteGenero(e.GroupRowHandle) = ImporteGenero
                    End If

                    If item.FieldName.Trim.ToUpper = "COMISION" Then
                        Dim Comision As Decimal = VaDec(GridView1.GetGroupRowValue(e.GroupRowHandle, GridView1.Columns(item.FieldName)))
                        e.TotalValue = Comision
                        _DcTotalComision(e.GroupRowHandle) = Comision
                    End If

                    If item.FieldName.Trim.ToUpper = "GASTOS" Then
                        Dim Gastos As Decimal = VaDec(GridView1.GetGroupRowValue(e.GroupRowHandle, GridView1.Columns(item.FieldName)))
                        e.TotalValue = Gastos
                        _DcTotalGastos(e.GroupRowHandle) = Gastos
                    End If

                    If item.FieldName.Trim.ToUpper = "BASEIMPONIBLE" Then
                        Dim BaseImponible As Decimal = VaDec(GridView1.GetGroupRowValue(e.GroupRowHandle, GridView1.Columns(item.FieldName)))
                        e.TotalValue = BaseImponible
                        _DcTotalBaseImponible(e.GroupRowHandle) = BaseImponible
                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "KILOSFACTURA" Then

                        Dim KilosFactura As Decimal = 0
                        For Each indice As Integer In _DcTotalKilosFactura.Keys
                            KilosFactura = KilosFactura + _DcTotalKilosFactura(indice)
                        Next

                        e.TotalValue = KilosFactura

                    End If

                    If item.FieldName.ToUpper.Trim = "IMPORTEGENERO" Then

                        Dim ImporteGenero As Decimal = 0
                        For Each indice As Integer In _DcTotalImporteGenero.Keys
                            ImporteGenero = ImporteGenero + _DcTotalImporteGenero(indice)
                        Next

                        e.TotalValue = ImporteGenero

                    End If

                    If item.FieldName.ToUpper.Trim = "COMISION" Then

                        Dim Comision As Decimal = 0
                        For Each indice As Integer In _DcTotalComision.Keys
                            Comision = Comision + _DcTotalComision(indice)
                        Next

                        e.TotalValue = Comision

                    End If

                    If item.FieldName.ToUpper.Trim = "GASTOS" Then

                        Dim Gastos As Decimal = 0
                        For Each indice As Integer In _DcTotalGastos.Keys
                            Gastos = Gastos + _DcTotalGastos(indice)
                        Next

                        e.TotalValue = Gastos

                    End If

                    If item.FieldName.ToUpper.Trim = "BASEIMPONIBLE" Then

                        Dim BaseImponible As Decimal = 0
                        For Each indice As Integer In _DcTotalBaseImponible.Keys
                            BaseImponible = BaseImponible + _DcTotalBaseImponible(indice)
                        Next

                        e.TotalValue = BaseImponible

                    End If



                End If

            End If




        Catch ex As Exception

        End Try


    End Sub


    'Public Overrides Sub CustomDrawRowFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
    '    MyBase.CustomDrawRowFooterCell(sender, e)


    '    If e.Column.FieldName.Trim.ToUpper = "KILOSFACTURA" Then

    '        Dim Kilos As Decimal = VaDec(GridView1.GetRowFooterCellText(e.RowHandle, GridView1.Columns("Kilos")))
    '        Dim KilosFactura As Decimal = VaDec(GridView1.GetDataRow(e.RowHandle)("KilosFactura"))

    '        'If VaDec(GridView1.GetDataRow(e.RowHandle)("Kilos")) <> VaDec(GridView1.GetDataRow(e.RowHandle)("KilosFactura")) Then
    '        If Kilos <> KilosFactura Then
    '            e.Appearance.BackColor = Color.Red
    '        End If
    '    End If

    'End Sub


End Class