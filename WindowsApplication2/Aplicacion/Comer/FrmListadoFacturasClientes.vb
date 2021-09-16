Imports System.Reflection

Public Class FrmListadoFacturasClientes
    Inherits FrConsulta


    


    Private Class stClave_ListadoFacturas

        Public IdCliente As Integer = 0
        Public Cliente As String = ""
        Public IdPais As Integer = 0
        Public Pais As String = ""
        Public Asegurado As String = ""
        Public IdFactura As Integer = 0
        Public Factura As String = ""
        Public Fecha As String = ""
        Public Albaran As String = ""
        Public Referencia As String = ""
        Public FechaSalida As String = ""

        Public Sub New(IdCliente As Integer, Cliente As String, IdPais As Integer, Pais As String, Asegurado As String, IdFactura As Integer, Factura As String, Fecha As String, Albaran As String, Referencia As String, FechaSalida As String)
            Me.IdCliente = IdCliente
            Me.Cliente = Cliente
            Me.IdPais = IdPais
            Me.Pais = Pais
            Me.Asegurado = Asegurado
            Me.IdFactura = IdFactura
            Me.Factura = Factura
            Me.Fecha = Fecha
            Me.Albaran = Albaran
            Me.Referencia = Referencia
            Me.FechaSalida = FechaSalida
        End Sub

    End Class

    Private Class stDatos_ListadoFacturas

        Public BaseImpGen As Decimal = 0
        Public BaseImpEnv As Decimal = 0
        Public BaseImpVar As Decimal = 0
        Public Iva As Decimal = 0
        Public GastoSup As Decimal = 0
        Public TotalFactura As Decimal = 0
        Public Cobrado As Decimal = 0
        Public Pendiente As Decimal = 0
        Public AcumPte As Decimal = 0

        Public Sub New(BaseImpGen As Decimal, BaseImpEnv As Decimal, BaseImpVar As Decimal, Iva As Decimal, GastoSup As Decimal, TotalFactura As Decimal, Cobrado As Decimal, Pendiente As Decimal, AcumPte As Decimal)
            Me.BaseImpGen = BaseImpGen
            Me.BaseImpEnv = BaseImpEnv
            Me.BaseImpVar = BaseImpVar
            Me.Iva = Iva
            Me.GastoSup = GastoSup
            Me.TotalFactura = TotalFactura
            Me.Cobrado = Cobrado
            Me.Pendiente = Pendiente
            Me.AcumPte = AcumPte
        End Sub

    End Class



    Private Clientes As New E_Clientes(Idusuario, cn)
    Private Facturas As New E_Facturas(Idusuario, cn)


    Private AcumConcedido As Decimal = 0


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDesdeCliente, Clientes.CLI_Codigo, LbDesdeCliente)
        ParamTx(TxHastaCliente, Clientes.CLI_Codigo, LbHastaCliente)
        ParamTx(TxDesdeFecha, Facturas.FRA_fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, Facturas.FRA_fecha, LbHastaFecha)
        ParamTx(TxDesdeSerie, Facturas.FRA_serie, LbDesdeSerie)
        ParamTx(TxHastaSerie, Facturas.FRA_serie, LbHastaSerie)
        ParamChk(chkDetallarFacturas, Nothing, "S", "N")

        AsociarControles(TxDesdeCliente, BtBuscaDesdeCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomDesdeCliente)
        AsociarControles(TxHastaCliente, BtBuscaHastaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomHastaCliente)


    End Sub


    Private Sub FrmConsultaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)
        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

        ChkEuros.Checked = True

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sqlWhere As String = CadenaWhereLista(Facturas.FRA_idempresa, ListadeCombo(CbEmpresas), "WHERE")
        sqlWhere = sqlWhere + CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")


        'Fechas
        If TxDesdeFecha.Text.Trim <> "" Then

            If RbFechaFactura.Checked Then

                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE FRA_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
                End If

            Else
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & TxDesdeFecha.Text & "'" & vbCrLf
                Else
                    sqlWhere = sqlWhere & " AND (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & TxDesdeFecha.Text & "'" & vbCrLf
                End If
            End If

            
        End If
        If TxHastaFecha.Text.Trim <> "" Then

            If RbFechaFactura.Checked Then

                If sqlWhere = "" Then
                    sqlWhere = " WHERE FRA_Fecha <= '" & TxDesdeFecha.Text & "'" & vbCrLf
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
                End If

            Else

                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & TxHastaFecha.Text & "'" & vbCrLf
                Else
                    sqlWhere = sqlWhere & " AND (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & TxHastaFecha.Text & "'" & vbCrLf
                End If

            End If

            
        End If


        'Clientes
        If TxDesdeCliente.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_IdCliente >= " & TxDesdeCliente.Text & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente >= " & TxDesdeCliente.Text & vbCrLf
            End If
        End If
        If TxHastaCliente.Text.Trim <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE FRA_IdCliente <= " & TxDesdeCliente.Text & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente <= " & TxHastaCliente.Text & vbCrLf
            End If
        End If

        'Serie
        If TxDesdeSerie.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_Serie >= '" & TxDesdeSerie.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Serie >= '" & TxDesdeSerie.Text & "'" & vbCrLf
            End If
        End If
        If TxHastaSerie.Text.Trim <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE FRA_Serie <= '" & TxDesdeSerie.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Serie <= '" & TxHastaSerie.Text & "'" & vbCrLf
            End If
        End If




        Dim sql As String = "SELECT IdFactura, IdCliente, RIGHT('00000' + CAST(IdCliente as varchar),5) + ' - ' + Cliente as Cliente, IdPais, Pais, Asegurado, Factura, Fecha, Albaran," & vbCrLf
        sql = sql & " Referencia, FechaSalida," & vbCrLf
        sql = sql & " BaseImpGen, BaseImpEnv, BaseImpVar, Iva, GastoSup, TotalFactura, Cobrado, COALESCE(TotalFactura,0) - COALESCE(Cobrado,0) as Pendiente" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, FRA_IdCliente as IdCliente, CLI_Nombre as Cliente, " & vbCrLf
        sql = sql & " CLI_IdPais as IdPais, Paises.Nombre as Pais, CLI_Asegurado as Asegurado," & vbCrLf
        sql = sql & " FRA_Serie + '-' + CAST(FRA_Factura as varchar) as Factura, FRA_Fecha as Fecha," & vbCrLf
        sql = sql & " (SELECT TOP 1 CAST(ASA_IdCentro as varchar) + '-' + CAST(ASA_Albaran as varchar) FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) as Albaran," & vbCrLf
        sql = sql & " FRA_RefCliente as Referencia, " & vbCrLf
        sql = sql & " (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) as FechaSalida," & vbCrLf

        If ChkEuros.Checked Then
            'sql = sql & " COALESCE(FRA_Base1,0) + COALESCE(FRA_Base2,0) + COALESCE(FRA_Base3,0) + COALESCE(FRA_Base4,0) as BaseImp, " & vbCrLf
            sql = sql & " COALESCE(FRA_Base1,0) * COALESCE(FRA_ValorCambio,1) as BaseImpGen, COALESCE(FRA_Base2,0) * COALESCE(FRA_ValorCambio,1) as BaseImpEnv, COALESCE(FRA_Base3,0) * COALESCE(FRA_ValorCambio,1) + COALESCE(FRA_Base4,0) * COALESCE(FRA_ValorCambio,1) as BaseImpVar, " & vbCrLf
            sql = sql & " COALESCE(FRA_Cuota1,0) * COALESCE(FRA_ValorCambio,1) + COALESCE(FRA_Cuota2,0) * COALESCE(FRA_ValorCambio,1) + COALESCE(FRA_Cuota3,0) * COALESCE(FRA_ValorCambio,1) + COALESCE(FRA_Cuota4,0) * COALESCE(FRA_ValorCambio,1) as Iva," & vbCrLf
            sql = sql & " FRA_Suplido * COALESCE(FRA_ValorCambio,1) as GastoSup," & vbCrLf
            sql = sql & " FRA_totalfactura * COALESCE(FRA_ValorCambio,1) as TotalFactura," & vbCrLf
            sql = sql & " COALESCE((SELECT SUM(CBL_ImporteCobradoDivisa * COALESCE(CBL_Cambio,1)) as Importe FROM CobrosLineas WHERE CBL_IdFactura = FRA_IdFactura),0) as Cobrado" & vbCrLf
        Else
            'sql = sql & " COALESCE(FRA_Base1,0) + COALESCE(FRA_Base2,0) + COALESCE(FRA_Base3,0) + COALESCE(FRA_Base4,0) as BaseImp, " & vbCrLf
            sql = sql & " COALESCE(FRA_Base1,0) as BaseImpGen, COALESCE(FRA_Base2,0) as BaseImpEnv, COALESCE(FRA_Base3,0) + COALESCE(FRA_Base4,0) as BaseImpVar, " & vbCrLf
            sql = sql & " COALESCE(FRA_Cuota1,0) + COALESCE(FRA_Cuota2,0) + COALESCE(FRA_Cuota3,0) + COALESCE(FRA_Cuota4,0) as Iva," & vbCrLf
            sql = sql & " FRA_Suplido as GastoSup," & vbCrLf
            sql = sql & " FRA_totalfactura as TotalFactura," & vbCrLf
            sql = sql & " COALESCE((SELECT SUM(CBL_ImporteCobradoDivisa) as Importe FROM CobrosLineas WHERE CBL_IdFactura = FRA_IdFactura),0) as Cobrado" & vbCrLf
        End If
        
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Comun.dbo.Paises ON CLI_IdPais = Paises.IdPais" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as X" & vbCrLf
        If RbSICobradas.Checked Then
            sql = sql & " WHERE (ABS(COALESCE(TotalFactura,0)) - ABS(COALESCE(Cobrado,0))) <= 0" & vbCrLf
        ElseIf RbNOCobradas.Checked Then
            sql = sql & " WHERE (ABS(COALESCE(TotalFactura,0)) - ABS(COALESCE(Cobrado,0))) > 0" & vbCrLf
        End If
        sql = sql & " ORDER BY IdCliente, Fecha, FechaSalida" & vbCrLf



        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)



        Dim acum As New Acumulador

        If Not IsNothing(dt) Then


            Dim AuxIdCliente As String = ""
            Dim AcumPte As Decimal = 0


            For Each row As DataRow In dt.Rows

                Dim IdCliente As Integer = VaInt(row("IdCliente"))
                Dim Cliente As String = (row("Cliente").ToString & "").Trim
                Dim IdPais As Integer = VaInt(row("IdPais"))
                Dim Pais As String = (row("Pais").ToString & "").Trim
                Dim Asegurado As String = (row("Asegurado").ToString & "").Trim
                Dim IdFactura As Integer = VaInt(row("IdFactura"))
                Dim Factura As String = (row("Factura").ToString & "").Trim
                Dim Fecha As String = ""
                If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim Albaran As String = (row("Albaran").ToString & "").Trim
                Dim Referencia As String = (row("Referencia").ToString & "").Trim
                Dim FechaSalida As String = ""
                If VaDate(row("FechaSalida")) > VaDate("") Then FechaSalida = VaDate(row("FechaSalida")).ToString("dd/MM/yyyy")

                Dim BaseImpGen As Decimal = VaDec(row("BaseImpGen"))
                Dim BaseImpEnv As Decimal = VaDec(row("BaseImpEnv"))
                Dim BaseImpVar As Decimal = VaDec(row("BaseImpVar"))

                Dim Iva As Decimal = VaDec(row("Iva"))
                Dim GastoSup As Decimal = VaDec(row("GastoSup"))
                Dim TotalFactura As Decimal = VaDec(row("TotalFactura"))
                Dim Cobrado As Decimal = VaDec(row("Cobrado"))
                Dim Pendiente As Decimal = VaDec(row("Pendiente"))


                If (row("IdCliente").ToString & "").Trim <> AuxIdCliente Then
                    AcumPte = 0
                End If

                If chkDetallarFacturas.Checked Then
                    AcumPte = AcumPte + Pendiente
                Else
                    IdFactura = 0
                    Factura = ""
                    Fecha = ""
                    Albaran = ""
                    Referencia = ""
                    FechaSalida = ""
                    AcumPte = Pendiente
                End If


                Dim stClave As New stClave_ListadoFacturas(IdCliente, Cliente, IdPais, Pais, Asegurado, IdFactura, Factura, Fecha, Albaran, Referencia, FechaSalida)
                Dim stDatos As New stDatos_ListadoFacturas(BaseImpGen, BaseImpEnv, BaseImpVar, Iva, GastoSup, TotalFactura, Cobrado, Pendiente, AcumPte)
                acum.Suma(stClave, stDatos)


                AuxIdCliente = (row("IdCliente").ToString & "").Trim

            Next

        End If


        GridView1.Columns.Clear()



        Grid.DataSource = acum.DataTable


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("BaseImpGen", "{0:n2}")
        AñadeResumenCampo("BaseImpEnv", "{0:n2}")
        AñadeResumenCampo("BaseImpVar", "{0:n2}")
        AñadeResumenCampo("Iva", "{0:n2}")
        AñadeResumenCampo("GastoSup", "{0:n2}")
        AñadeResumenCampo("TotalFactura", "{0:n2}")
        AñadeResumenCampo("Cobrado", "{0:n2}")
        AñadeResumenCampo("Pendiente", "{0:n2}")
        If chkDetallarFacturas.Checked Then
            AñadeResumenCampo("AcumPte", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        Else
            AñadeResumenCampo("AcumPte", "{0:n2}")
        End If


        AjustaColumnas()



    End Sub



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDCLIENTE", "IDFACTURA", "IDPAIS"
                    c.Visible = False

                Case "CLIENTE"
                    If chkDetallarFacturas.Checked Then
                        c.GroupIndex = 1
                        c.Visible = False
                    End If
                Case "IDFACTURA", "FACTURA", "FECHA", "ALBARAN", "REFERENCIA", "FECHASALIDA"
                    If chkDetallarFacturas.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

                Case "PAIS", "ASEGURADO"
                    If chkListadoSeguro.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

            End Select

        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BASEIMPGEN", "BASEIMPENV", "BASEIMPVAR", "IVA", "GASTOSUP", "TOTALFACTURA", "COBRADO", "PENDIENTE", "ACUMPTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
            End Select
        Next


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim empresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)
        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDesdeCliente.Text, TxHastaCliente.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)

        Dim RbFecha As RadioButton() = {RbFechaFactura, RbFechaSalida}
        Dim StrFecha As String() = {"Fecha de Factura", "Fecha de Salida"}
        Dim FiltroFecha As String = FiltroRadioButton("Filtrar por", RbFecha, StrFecha)

        Dim series As String = FiltroDesdeHasta("Serie", TxDesdeSerie.Text, TxHastaSerie.Text)
        Dim detallarfacturas As String = FiltroCheckBox("Detallar facturas", chkDetallarFacturas, "SI", "NO")


        'Dim RbTipoListado As RadioButton() = {RbResumido, RbDetallado}
        'Dim StrTipoListado As String() = {"Resumido", "Detallado"}
        'Dim tipolistado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)

        Dim RbCobradas As RadioButton() = {RbSICobradas, RbNOCobradas, RbTodasCobradas}
        Dim StrCobradas As String() = {"SI", "NO", "Todas"}
        Dim Cobradas As String = FiltroRadioButton("Facturas cobradas", RbCobradas, StrCobradas)

        If empresa <> "" Then LineasDescripcion.Add(empresa)
        'If tipolistado <> "" Then LineasDescripcion.Add(tipolistado)
        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If FiltroFecha <> "" Then LineasDescripcion.Add(FiltroFecha)
        If series <> "" Then LineasDescripcion.Add(series)
        If detallarfacturas <> "" Then LineasDescripcion.Add(detallarfacturas)
        If Cobradas <> "" Then LineasDescripcion.Add(Cobradas)

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim dt As DataTable = CType(Grid.DataSource, DataTable)



        Dim bDatos As Boolean = True

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then


                Dim lstEmpresas As List(Of String) = ListadeCombo(CbEmpresas)
                Dim cobradas As String = "TODAS"
                If RbSICobradas.Checked Then
                    cobradas = "SI"
                ElseIf RbNOCobradas.Checked Then
                    cobradas = "NO"
                End If

                Dim listado As New Listado_FacturasClientes(dt, lstEmpresas, TxDesdeCliente.Text, TxHastaCliente.Text, TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeSerie.Text, TxHastaSerie.Text, chkDetallarFacturas.Checked, cobradas, TipoImpresion.Preliminar)
                Listado.ImprimirListado()


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



    Public Overrides Sub CustomDrawFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
        MyBase.CustomDrawFooterCell(sender, e)


        Dim columna As String = e.Column.FieldName.ToUpper.Trim

        If chkDetallarFacturas.Checked Then

            Select Case columna
                Case "ACUMPTE"
                    Dim total As String = VaDec(ObtenerTotal(e.Column.FieldName, 8)).ToString("#,##0.00")
                    e.Info.DisplayText = total
            End Select

        End If


    End Sub


    Private Function ObtenerTotal(columna As String, indice_grupo As Integer) As Decimal

        Dim acum As Decimal = 0

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(columna)
            If Not IsNothing(col) Then

                Try
                    Dim cadena As String = GridView1.GetGroupSummaryValue(indice, GridView1.GroupSummary.Item(indice_grupo)) & ""
                    Dim valor As Decimal = VaDec(cadena)
                    acum = acum + VaDec(valor)
                Catch ex As Exception
                    Dim a As String = ""
                End Try

            End If

        Next


        Return acum

    End Function


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try



            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then


                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "ACUMPTE" Then

                        Try
                            Dim acumpte As Decimal = 0
                            acumpte = e.FieldValue
                            e.TotalValue = acumpte
                        Catch ex As Exception
                            Dim a As String = ""
                        End Try
                        

                    End If

                End If


            End If


        Catch ex As Exception

        End Try

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then

            If column.FieldName.Trim.ToUpper = "FACTURA" Then

                Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                If VaDec(IdFactura) > 0 Then
                    Dim frm As New FrmFacturacion
                    frm.init(IdFactura)
                    frm.ShowDialog()
                End If

            End If

        End If

    End Sub


End Class