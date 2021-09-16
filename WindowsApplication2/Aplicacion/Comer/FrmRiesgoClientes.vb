Imports DevExpress.XtraEditors.Controls

Public Class FrmRiesgoClientes
    Inherits FrConsulta


    Private Enum EmpresaCtb

        Hortichuelas = 1
        HortiHorticola = 2
        EcoPark = 10
        Todas = 99

    End Enum


    Private Class DiasCliente

        Public IdCliente As String = ""
        Public DiasFra As Decimal = 0
        Public DiasSal As Decimal = 0

        Public Sub New(IdCliente As String, DiasFra As Decimal, DiasSal As Decimal)
            Me.IdCliente = IdCliente
            Me.DiasFra = DiasFra
            Me.DiasSal = DiasSal
        End Sub

    End Class


    Private Clientes As New E_Clientes(Idusuario, cn)
    Private Facturas As New E_Facturas(Idusuario, cn)
    Private AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim PVentaUsuario As New E_PventaUsuario(Idusuario, cn)


    Private DcDiasCliente As New Dictionary(Of String, DiasCliente)



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
        ParamChk(chkDetallarFacturas, Nothing, "S", "N")
        ParamChk(ChkAlbaranesPendientes, Nothing, "S", "N")
        ParamTx(TxFechaListado, Facturas.FRA_fecha, LbFechaListado)

        AsociarControles(TxDesdeCliente, BtBuscaDesdeCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomDesdeCliente)
        AsociarControles(TxHastaCliente, BtBuscaHastaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomHastaCliente)


    End Sub


    Private Sub FrmConsultaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente


        Dim dt As DataTable = PVentaUsuario.Tabla(Idusuario, MiMaletin.IdEmpresaCTB)
        cbPuntoVenta.Properties.DataSource = dt
        cbPuntoVenta.Properties.ValueMember = "IdPuntoventa"
        cbPuntoVenta.Properties.DisplayMember = "Nombre"

        For Each it As CheckedListBoxItem In cbPuntoVenta.Properties.GetItems()
            If it.Value = MiMaletin.IdPuntoVenta Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next

        'cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
        TxFechaListado.Text = Now.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        DcDiasCliente.Clear()



        'Dim FechaDias As String = "FRA_Fecha"
        'If RbFechaFactura.Checked Then
        '    FechaDias = "FRA_Fecha"
        'Else
        '    FechaDias = "ASA_FechaSalida"
        'End If


        Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
        Dim empresa As EmpresaCtb = ObtenerEmpresaCtb(lst)


        Dim sql30 As String = PendientePorDias(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                             TxFechaListado.Text, RbFechaFactura.Checked, "", " < 30", lst)

        Dim sql30a45 As String = PendientePorDias(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                             TxFechaListado.Text, RbFechaFactura.Checked, " >= 30", " < 45", lst)

        Dim sql45a60 As String = PendientePorDias(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                             TxFechaListado.Text, RbFechaFactura.Checked, " >= 45", " < 60", lst)

        Dim sql60a90 As String = PendientePorDias(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                             TxFechaListado.Text, RbFechaFactura.Checked, " >= 60", " < 90", lst)

        Dim sql90plus As String = PendientePorDias(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                             TxFechaListado.Text, RbFechaFactura.Checked, " >= 90", "", lst)




        Dim Prefijo As String = ""
        Dim Sufijo As String = ""

        If chkDetallarFacturas.Checked Then
            Prefijo = "SELECT IdCliente, Cliente, Tipo, IdFactura, CE, Factura, Fecha, FechaSalida, DiasFra, DiasSal," & vbCrLf
            Prefijo = Prefijo & " Pendiente30, Pendiente45, Pendiente60, Pendiente90, Pendiente90Plus, " & vbCrLf
            Prefijo = Prefijo & " Concedido, Saldo, Disponible, SaldoCtb, ImpDiasFra, ImpDiasSal" & vbCrLf
            Prefijo = Prefijo & " FROM ( " & vbCrLf

            Sufijo = " ) AS H" & vbCrLf
        Else
            Prefijo = "SELECT IdCliente, Cliente, " & vbCrLf
            Prefijo = Prefijo & " CASE WHEN COALESCE(SUM(Saldo),0) = 0 THEN 0 ELSE SUM(ImpDiasFra)/SUM(Saldo) END as DiasFra," & vbCrLf
            Prefijo = Prefijo & " CASE WHEN COALESCE(SUM(Saldo),0) = 0 THEN 0 ELSE SUM(ImpDiasSal)/SUM(Saldo) END as DiasSal," & vbCrLf
            Prefijo = Prefijo & " SUM(Pendiente30) as Pendiente30, SUM(Pendiente45) as Pendiente45," & vbCrLf
            Prefijo = Prefijo & " SUM(Pendiente60) as Pendiente60, SUM(Pendiente90) as Pendiente90, SUM(Pendiente90Plus) as Pendiente90Plus," & vbCrLf
            Prefijo = Prefijo & " Concedido, SUM(Saldo) as Saldo, Concedido - SUM(Saldo) as Disponible, SaldoCtb," & vbCrLf
            Prefijo = Prefijo & " SUM(ImpDiasFra) as ImpDiasFra, SUM(ImpDiasSal) as ImpDiasSal" & vbCrLf
            Prefijo = Prefijo & " FROM (" & vbCrLf

            Sufijo = " ) AS H" & vbCrLf
            Sufijo = Sufijo & " GROUP BY IdCliente, Cliente, Concedido, SaldoCtb" & vbCrLf

        End If


        Dim sql As String = ""
        sql = sql & Prefijo & "SELECT IdCliente, Cliente, 'F' as Tipo, IdFactura, CE, Factura, Fecha, FechaSalida, DiasFra, DiasSal," & vbCrLf
        sql = sql & " Pendiente30, Pendiente45, Pendiente60, Pendiente90, Pendiente90Plus, Concedido, Saldo, Disponible, COALESCE(SaldoCtb,0) AS SaldoCtb," & vbCrLf
        sql = sql & " COALESCE(Saldo,0) * COALESCE(DiasFra,0) as ImpDiasFra, COALESCE(Saldo,0) * COALESCE(DiasSal,0) as ImpDiasSal" & vbCrLf
        sql = sql & " FROM ("
        sql = sql & "SELECT FRA_IdCliente as IdCliente, RIGHT('00000' + CAST(FRA_IdCliente as varchar), 5) + ' - ' + CLI_Nombre as Cliente, X.IdFactura, " & vbCrLf
        sql = sql & " FRA_IdCentro as CE, FRA_Serie + '-' + CAST(FRA_Factura as varchar) as Factura, " & vbCrLf
        sql = sql & " FRA_Fecha as Fecha, " & vbCrLf
        sql = sql & " (SELECT TOP 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura) as FechaSalida," & vbCrLf
        sql = sql & " DiasFra, DiasSal, Pendiente30, Pendiente45, Pendiente60, Pendiente90, Pendiente90Plus, " & vbCrLf
        sql = sql & " CLI_RiesgoMaximo as Concedido, Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus as Saldo," & vbCrLf
        sql = sql & " COALESCE(CLI_RiesgoMaximo,0) - (Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus) as Disponible," & vbCrLf
        Select Case VaInt(empresa)
            Case VaInt(EmpresaCtb.Hortichuelas), VaInt(EmpresaCtb.HortiHorticola)
                sql = sql & " (SELECT SUM(Debe - Haber) FROM Contabilidad.dbo.AsientoLineas WHERE NumeroCuenta = " & vbCrLf
            Case VaInt(EmpresaCtb.EcoPark)
                sql = sql & " (SELECT SUM(Debe - Haber) FROM Contabilidad_10.dbo.AsientoLineas WHERE NumeroCuenta = " & vbCrLf
            Case VaInt(EmpresaCtb.Todas)
                sql = sql & " (SELECT SUM(Debe - Haber) FROM SaldoClientes WHERE NumeroCuenta = " & vbCrLf
        End Select
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT LEFT(CAST(TPC_CtaCliente as varchar) + '000000',6) + RIGHT('00000' + CAST(CLI_IdCliente as varchar),5) FROM Clientes " & vbCrLf
        sql = sql & " LEFT JOIN TiposClientes ON TPC_IdTipo = CLI_IdTipo" & vbCrLf
        sql = sql & " WHERE(CLI_IdCliente = FRA_IdCliente)" & vbCrLf
        sql = sql & " )" & vbCrLf
        sql = sql & " AND Fecha <= '" & TxFechaListado.Text & "'" & vbCrLf
        sql = sql & " ) as SaldoCtb" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, DiasFra, DiasSal," & vbCrLf
        sql = sql & " SUM(Pendiente30) as Pendiente30, SUM(Pendiente45) as Pendiente45, SUM(Pendiente60) as Pendiente60, " & vbCrLf
        sql = sql & " SUM(Pendiente90) as Pendiente90, SUM(Pendiente90Plus) as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT IdFactura, DiasFra, DiasSal, Pendiente as Pendiente30, 0.00 as Pendiente45," & vbCrLf
        sql = sql & " 0.00 as Pendiente60, 0.00 as Pendiente90, 0.00 as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sql30 & vbCrLf
        sql = sql & ") AS P30" & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT IdFactura, DiasFra, DiasSal, 0.00 AS Pendiente30, Pendiente as Pendiente45," & vbCrLf
        sql = sql & " 0.00 as Pendiente60, 0.00 as Pendiente90, 0.00 as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sql30a45 & vbCrLf
        sql = sql & " ) AS P45" & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT IdFactura, DiasFra, DiasSal, 0.00 AS Pendiente30, 0.00 as Pendiente45," & vbCrLf
        sql = sql & " Pendiente as Pendiente60, 0.00 as Pendiente90, 0.00 as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sql45a60 & vbCrLf
        sql = sql & " ) AS P60" & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT IdFactura, DiasFra, DiasSal, 0.00 AS Pendiente30, 0.00 as Pendiente45," & vbCrLf
        sql = sql & " 0.00 as Pendiente60, Pendiente as Pendiente90, 0.00 as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sql60a90 & vbCrLf
        sql = sql & " ) AS P90" & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT IdFactura, DiasFra, DiasSal, 0.00 AS Pendiente30, 0.00 as Pendiente45," & vbCrLf
        sql = sql & " 0.00 as Pendiente60, 0.00 as Pendiente90, Pendiente as Pendiente90Plus" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & sql90plus & vbCrLf
        sql = sql & " ) AS P90Plus" & vbCrLf
        sql = sql & " ) AS P" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON P.IdFactura = FRA_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = FRA_IdCliente" & vbCrLf
        sql = sql & " GROUP BY FRA_IdFactura, DiasFra, DiasSal" & vbCrLf
        sql = sql & " HAVING SUM(Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus) <> 0 "
        sql = sql & " ) AS X" & vbCrLf
        sql = sql & " LEFT JOIN Facturas F ON X.IdFactura = FRA_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = FRA_IdCliente" & vbCrLf
        sql = sql & " ) as F"


        If ChkAlbaranesPendientes.Checked Then

            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT IdCliente, Cliente, 'A' as Tipo, IdFactura, CE, Factura, '01/01/1900' as Fecha, FechaSalida, 0 as DiasFra, DiasSal, Pendiente30, Pendiente45, Pendiente60," & vbCrLf
            sql = sql & " Pendiente90, Pendiente90Plus," & vbCrLf
            sql = sql & " CLI_RiesgoMaximo as Concedido, Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus as Saldo," & vbCrLf
            sql = sql & " COALESCE(CLI_RiesgoMaximo,0) - (Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus) as Disponible, " & vbCrLf
            Select Case VaInt(empresa)
                Case VaInt(EmpresaCtb.Hortichuelas), VaInt(EmpresaCtb.HortiHorticola)
                    sql = sql & " COALESCE((SELECT SUM(Debe - Haber) FROM Contabilidad.dbo.AsientoLineas WHERE NumeroCuenta = " & vbCrLf
                Case VaInt(EmpresaCtb.EcoPark)
                    sql = sql & " COALESCE((SELECT SUM(Debe - Haber) FROM Contabilidad_10.dbo.AsientoLineas WHERE NumeroCuenta = " & vbCrLf
                Case VaInt(EmpresaCtb.Todas)
                    sql = sql & " COALESCE((SELECT SUM(Debe - Haber) FROM SaldoClientes WHERE NumeroCuenta = " & vbCrLf
            End Select
            sql = sql & " (" & vbCrLf
            sql = sql & " SELECT LEFT(CAST(TPC_CtaCliente as varchar) + '000000',6) + RIGHT('00000' + CAST(CLI_IdCliente as varchar),5) FROM Clientes " & vbCrLf
            sql = sql & " LEFT JOIN TiposClientes ON TPC_IdTipo = CLI_IdTipo" & vbCrLf
            sql = sql & " WHERE CLI_IdCliente = IdCliente" & vbCrLf
            sql = sql & " )" & vbCrLf
            sql = sql & " AND Fecha <= '" & TxFechaListado.Text & "'" & vbCrLf
            sql = sql & " ),0) as SaldoCtb," & vbCrLf
            sql = sql & " 0 as ImpDiasFra, COALESCE(Pendiente30 + Pendiente45 + Pendiente60 + Pendiente90 + Pendiente90Plus,0) * COALESCE(DiasSal,0) as ImpDiasSal" & vbCrLf
            sql = sql & " FROM" & vbCrLf
            sql = sql & " (" & vbCrLf
            sql = sql & " SELECT IdCliente, Cliente, IdFactura, CE, Factura, Fecha, FechaSalida, DiasSal," & vbCrLf
            sql = sql & " CASE WHEN DiasSal < 30 THEN Importe ELSE 0 END as Pendiente30," & vbCrLf
            sql = sql & " CASE WHEN DiasSal >= 30 AND DiasSal < 45 THEN Importe ELSE 0 END as Pendiente45," & vbCrLf
            sql = sql & " CASE WHEN DiasSal >= 45 AND DiasSal < 60 THEN Importe ELSE 0 END as Pendiente60," & vbCrLf
            sql = sql & " CASE WHEN DiasSal >= 60 AND DiasSal < 90 THEN Importe ELSE 0 END as Pendiente90," & vbCrLf
            sql = sql & " CASE WHEN DiasSal >= 90 THEN Importe ELSE 0 END as Pendiente90Plus" & vbCrLf
            sql = sql & " FROM" & vbCrLf
            sql = sql & " (" & vbCrLf
            sql = sql & " SELECT ASA_IdCliente as IdCliente, RIGHT('00000' + CAST(ASA_IdCliente as varchar), 5) + ' - ' + CLI_Nombre as Cliente, ASA_IdAlbaran as IdFactura, ASA_idcentro as CE," & vbCrLf
            sql = sql & " 'ALB-' + CAST(ASA_Albaran as varchar) as Factura, null as Fecha, ASA_FechaSalida as FechaSalida, " & vbCrLf
            sql = sql & " DATEDIFF(day, ASA_FechaSalida, '" & TxFechaListado.Text & "') as DiasSal," & vbCrLf
            sql = sql & " (SELECT SUM(ASL_ImporteGeneroVta) FROM AlbSalida_lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran) * COALESCE(ASA_ValorCambio,1) as Importe" & vbCrLf
            sql = sql & " FROM AlbSalida" & vbCrLf
            sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente" & vbCrLf
            sql = sql & " WHERE COALESCE(ASA_IdFactura,0) = 0 " & vbCrLf
            If TxDesdeCliente.Text.Trim <> "" Then sql = sql & " AND ASA_IdCliente >= " & TxDesdeCliente.Text & vbCrLf
            If TxHastaCliente.Text.Trim <> "" Then sql = sql & " AND ASA_IdCliente <= " & TxHastaCliente.Text & vbCrLf
            If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND ASA_FechaSalida >= '" & TxDesdeFecha.Text & "'" & vbCrLf
            If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND ASA_FechaSalida <= '" & TxHastaFecha.Text & "'" & vbCrLf
            If lst.Count > 0 Then sql = sql & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, lst, " AND ") & vbCrLf
            sql = sql & " ) as A" & vbCrLf
            sql = sql & " ) as B" & vbCrLf
            sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = B.IdCliente" & vbCrLf

        End If

        sql = sql & Sufijo

        If Not chkDetallarFacturas.Checked Then
            sql = sql & " ORDER BY IdCliente" & vbCrLf
        Else
            sql = sql & " ORDER BY IdCliente, CE, Tipo DESC, Fecha, FechaSalida, DiasFra, DiasSal" & vbCrLf
        End If


        GridView1.Columns.Clear()
        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)


        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Pendiente30", "{0:n2}")
        AñadeResumenCampo("Pendiente45", "{0:n2}")
        AñadeResumenCampo("Pendiente60", "{0:n2}")
        AñadeResumenCampo("Pendiente90", "{0:n2}")
        AñadeResumenCampo("Pendiente90Plus", "{0:n2}")

        If chkDetallarFacturas.Checked Then
            AñadeResumenCampo("Concedido", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
            AñadeResumenCampo("Saldo", "{0:n2}")
            AñadeResumenCampo("Disponible", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
            AñadeResumenCampo("SaldoCtb", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        Else
            AñadeResumenCampo("Concedido", "{0:n2}")
            AñadeResumenCampo("Saldo", "{0:n2}")
            AñadeResumenCampo("Disponible", "{0:n2}")
            AñadeResumenCampo("SaldoCtb", "{0:n2}")
        End If

        AñadeResumenCampo("ImpDiasFra", "{0:n2}")
        AñadeResumenCampo("ImpDiasSal", "{0:n2}")
        AñadeResumenCampo("DiasFra", "{0:n0}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("DiasSal", "{0:n0}", DevExpress.Data.SummaryItemType.Custom)


        AjustaColumnas()



    End Sub



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                'Case "IDFACTURA", "CONCEDIDO", "SALDO", "DISPONIBLE"
                Case "IDFACTURA", "IDCLIENTE", "IMPDIASFRA", "IMPDIASSAL"
                    c.Visible = False
                Case "CLIENTE"
                    If Not chkDetallarFacturas.Checked Then
                        c.GroupIndex = -1
                    Else
                        c.GroupIndex = 1
                        'AcumConcedido = 0
                        c.Visible = False
                    End If

            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "DIASFRA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "DIASSAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PENDIENTE30"
                    c.Caption = "-30 Dias"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PENDIENTE45"
                    c.Caption = "-45 Dias"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PENDIENTE60"
                    c.Caption = "-60 Dias"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PENDIENTE90"
                    c.Caption = "-90 Dias"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "PENDIENTE90PLUS"
                    c.Caption = "+90 Dias"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "CONCEDIDO", "SALDO", "DISPONIBLE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 90
                Case "SALDOCTB"
                    c.Width = 90

            End Select
        Next


    End Sub



    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDesdeCliente.Text, TxHastaCliente.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)
        Dim detallarfacturas As String = FiltroCheckBox("Detallar facturas", chkDetallarFacturas, "SI", "NO")
        Dim incluiralbaranes As String = FiltroCheckBox("Incluir albaranes pendientes", ChkAlbaranesPendientes, "SI", "NO")

        Dim RbCalculoDias As RadioButton() = {RbFechaSalida, RbFechaFactura}
        Dim StrCalculoDias As String() = {"S/Fecha Salida", "S/Fecha Factura"}
        Dim calculodias As String = FiltroRadioButton("Cálculo días", RbCalculoDias, StrCalculoDias)

        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If detallarfacturas <> "" Then LineasDescripcion.Add(detallarfacturas)
        If incluiralbaranes <> "" Then LineasDescripcion.Add(incluiralbaranes)
        If calculodias <> "" Then LineasDescripcion.Add(calculodias)

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim dt As DataTable = CType(Grid.DataSource, DataTable)



        Dim bDatos As Boolean = True

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim listado As New Listado_RiesgoClientes(dt, TxFechaListado.Text.Trim, TxDesdeCliente.Text.Trim, TxHastaCliente.Text.Trim, TxDesdeFecha.Text.Trim, TxHastaFecha.Text.Trim, RbFechaSalida.Checked, ChkAlbaranesPendientes.Checked, chkDetallarFacturas.Checked, TipoImpresion.Preliminar)
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


    Public Function PendientePorDias(FechaDesde As String, FechaHasta As String, CliDesde As String, CliHasta As String, bDivisa As Boolean,
                                     FechaListado As String, bFechaFactura As Boolean, CondicionDiasDesde As String, CondicionDiasHasta As String,
                                     lstPuntosVenta As List(Of String)) As String


        If bFechaFactura Then
            If CondicionDiasHasta.Trim <> "" Then CondicionDiasHasta = " DATEDIFF(day, FRA_Fecha, '" & TxFechaListado.Text & "') " & CondicionDiasHasta
            If CondicionDiasDesde.Trim <> "" Then CondicionDiasDesde = " DATEDIFF(day, FRA_Fecha, '" & TxFechaListado.Text & "') " & CondicionDiasDesde
        Else
            If CondicionDiasHasta.Trim <> "" Then CondicionDiasHasta = " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) " & CondicionDiasHasta
            If CondicionDiasDesde.Trim <> "" Then CondicionDiasDesde = " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) " & CondicionDiasDesde
        End If



        Dim sqlWhere As String = ""

        'Fechas
        If bFechaFactura Then
            If FechaDesde.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE FRA_Fecha >= '" & FechaDesde & "'"
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha >= '" & FechaDesde & "'"
                End If
            End If
            If FechaHasta.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE FRA_Fecha <= '" & FechaHasta & "'"
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha <= '" & FechaHasta & "'"
                End If
            End If
        Else
            If FechaDesde.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & FechaDesde & "'"
                Else
                    sqlWhere = sqlWhere & " AND (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & FechaDesde & "'"
                End If
            End If
            If FechaHasta.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & FechaHasta & "'"
                Else
                    sqlWhere = sqlWhere & " AND (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & FechaHasta & "'"
                End If
            End If
        End If


        'Clientes
        If CliDesde.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_IdCliente >= '" & CliDesde & "'"
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente >= '" & CliDesde & "'"
            End If
        End If
        If CliHasta.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_IdCliente <= '" & CliHasta & "'"
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente <= '" & CliHasta & "'"
            End If
        End If


        If CondicionDiasDesde.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & CondicionDiasDesde
            Else
                sqlWhere = sqlWhere & " AND " & CondicionDiasDesde
            End If
        End If

        If CondicionDiasHasta.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & CondicionDiasHasta
            Else
                sqlWhere = sqlWhere & " AND " & CondicionDiasHasta
            End If
        End If

        If lstPuntosVenta.Count > 0 Then
            If sqlWhere.Trim = "" Then
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ") & vbCrLf
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ") & vbCrLf
            End If
        End If


        Dim sql As String = "SELECT IdFactura, DiasFra, DiasSal," & vbCrLf
        sql = sql & " SUM(TotalFactura - Cobrado) as Pendiente"
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura," & vbCrLf
        sql = sql & " (SELECT DATEDIFF(day, FRA_Fecha, '" & FechaListado & "')) as DiasFra," & vbCrLf
        sql = sql & " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) as DiasSal," & vbCrLf
        If Not bDivisa Then
            sql = sql & " (FRA_TotalFactura * COALESCE(FRA_ValorCambio,1)) as TotalFactura, 0.00 as Cobrado" & vbCrLf
        Else
            sql = sql & " (FRA_TotalFactura) as TotalFactura, 0.00 as Cobrado" & vbCrLf
        End If
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = FRA_IdCliente" & vbCrLf
        sql = sql & sqlWhere & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, " & vbCrLf
        sql = sql & " (SELECT DATEDIFF(day, FRA_Fecha, '" & FechaListado & "')) as DiasFra," & vbCrLf
        sql = sql & " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) as DiasSal," & vbCrLf
        If Not bDivisa Then
            sql = sql & " 0 as TotalFactura, SUM(CBL_ImporteCobradoDivisa * COALESCE(FRA_ValorCambio,1)) as Cobrado" & vbCrLf
        Else
            sql = sql & " 0 as TotalFactura, SUM(CBL_ImporteCobradoDivisa) as Cobrado" & vbCrLf
        End If
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " INNER JOIN CobrosLineas ON FRA_IdFactura = CBL_IdFactura" & vbCrLf
        sql = sql & sqlWhere & vbCrLf
        sql = sql & " GROUP BY FRA_IdFactura, FRA_Fecha" & vbCrLf
        sql = sql & " ) AS G" & vbCrLf
        sql = sql & " GROUP BY IdFactura, DiasFra, DiasSal" & vbCrLf



        'If bIncluirAlbaranes Then



        'End If


        Return sql

    End Function


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then


                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "CONCEDIDO" Then

                        Dim concedido As Decimal = 0
                        concedido = e.FieldValue
                        e.TotalValue = concedido


                        'AcumConcedido = concedido

                    ElseIf item.FieldName.ToUpper.Trim = "SALDOCTB" Then

                        Dim saldoctb As Decimal = 0
                        saldoctb = VaDec(e.FieldValue)
                        e.TotalValue = StSaldoDec(saldoctb)

                    ElseIf item.FieldName.ToUpper.Trim = "DISPONIBLE" Then

                        Dim concedido As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                        Dim saldo As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        'If Kilos <> 0 Then precio = Importe / Kilos
                        e.TotalValue = concedido - saldo

                    ElseIf item.FieldName.ToUpper.Trim = "DIASFRA" Then

                        'TODO: Calcular el período medio de cobro ponderado sobre el total de lo cobrado del cliente
                        Dim IdCliente As String = (e.GetValue("IdCliente").ToString & "").Trim
                        e.TotalValue = ObtenerDiasFraCliente(IdCliente)


                        'Dim dias As Integer = 0
                        'Dim ImporteDias As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(9)))
                        'Dim Importe As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        'If Importe <> 0 Then dias = ImporteDias / Importe
                        'e.TotalValue = dias

                    ElseIf item.FieldName.ToUpper.Trim = "DIASSAL" Then

                        'TODO: Calcular el período medio de cobro ponderado sobre el total de lo cobrado del cliente
                        Dim IdCliente As String = (e.GetValue("IdCliente").ToString & "").Trim
                        e.TotalValue = ObtenerDiasSalCliente(IdCliente)

                        'Dim dias As Integer = 0
                        'Dim ImporteDias As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(10)))
                        'Dim Importe As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        'If Importe <> 0 Then dias = ImporteDias / Importe
                        'e.TotalValue = dias

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "SALDOCTB" Then

                        e.TotalValue = e.TotalValue

                    ElseIf item.FieldName.ToUpper.Trim = "DIASFRA" Then

                        'Calcular el período medio de cobro ponderado sobre el total de lo cobrado de los clientes
                        Dim DiasFra As Decimal = 0
                        Dim DiasSal As Decimal = 0

                        Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
                        PeriodoMedioCobroPonderadoClientes(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                                           TxFechaListado.Text, RbFechaFactura.Checked, "", "", lst,
                                                           DcDiasCliente, DiasFra, DiasSal)
                        e.TotalValue = DiasFra


                    ElseIf item.FieldName.ToUpper.Trim = "DIASSAL" Then

                        'Calcular el período medio de cobro ponderado sobre el total de lo cobrado de los clientes
                        Dim DiasFra As Decimal = 0
                        Dim DiasSal As Decimal = 0

                        Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
                        PeriodoMedioCobroPonderadoClientes(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                                           TxFechaListado.Text, RbFechaFactura.Checked, "", "", lst,
                                                           DcDiasCliente, DiasFra, DiasSal)
                        e.TotalValue = DiasSal


                    End If



                End If

            End If


        Catch ex As Exception

        End Try

    End Sub


    Private Function ObtenerDiasFraCliente(IdCliente As String) As Decimal

        Dim DiasFra As Decimal = 0


        If Not DcDiasCliente.ContainsKey(IdCliente) Then

            Dim DiasSal As Decimal = 0

            Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
            PeriodoMedioCobroPonderadoClientes(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                                TxFechaListado.Text, RbFechaFactura.Checked, "", "", lst,
                                                IdCliente, DiasFra, DiasSal)

            DcDiasCliente(IdCliente) = New DiasCliente(IdCliente, DiasFra, DiasSal)

        Else
            DiasFra = DcDiasCliente(IdCliente).DiasFra
        End If


        Return DiasFra

    End Function


    Private Function ObtenerDiasSalCliente(IdCliente As String) As Decimal

        Dim DiasSal As Decimal = 0


        If Not DcDiasCliente.ContainsKey(IdCliente) Then

            Dim DiasFra As Decimal = 0

            Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
            PeriodoMedioCobroPonderadoClientes(TxDesdeFecha.Text, TxHastaFecha.Text, TxDesdeCliente.Text, TxHastaCliente.Text, False,
                                                TxFechaListado.Text, RbFechaFactura.Checked, "", "", lst,
                                                IdCliente, DiasFra, DiasSal)

            DcDiasCliente(IdCliente) = New DiasCliente(IdCliente, DiasFra, DiasSal)

        Else
            DiasSal = DcDiasCliente(IdCliente).DiasSal
        End If


        Return DiasSal

    End Function


    Private Sub PeriodoMedioCobroPonderadoClientes(FechaDesde As String, FechaHasta As String, CliDesde As String, CliHasta As String, bDivisa As Boolean,
                                     FechaListado As String, bFechaFactura As Boolean, CondicionDiasDesde As String, CondicionDiasHasta As String,
                                     lstPuntosVenta As List(Of String),
                                     ByVal lst As List(Of String), ByRef DiasFra As Decimal, ByRef DiasSal As Decimal)

        DiasFra = 0
        DiasSal = 0



        If bFechaFactura Then
            If CondicionDiasHasta.Trim <> "" Then CondicionDiasHasta = " DATEDIFF(day, FRA_Fecha, '" & TxFechaListado.Text & "') " & CondicionDiasHasta
            If CondicionDiasDesde.Trim <> "" Then CondicionDiasDesde = " DATEDIFF(day, FRA_Fecha, '" & TxFechaListado.Text & "') " & CondicionDiasDesde
        Else
            If CondicionDiasHasta.Trim <> "" Then CondicionDiasHasta = " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) " & CondicionDiasHasta
            If CondicionDiasDesde.Trim <> "" Then CondicionDiasDesde = " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & FechaListado & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) " & CondicionDiasDesde
        End If



        Dim sqlWhere As String = ""

        'Fechas
        If bFechaFactura Then
            If FechaDesde.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE FRA_Fecha >= '" & FechaDesde & "'"
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha >= '" & FechaDesde & "'"
                End If
            End If
            If FechaHasta.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE FRA_Fecha <= '" & FechaHasta & "'"
                Else
                    sqlWhere = sqlWhere & " AND FRA_Fecha <= '" & FechaHasta & "'"
                End If
            End If
        Else
            If FechaDesde.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & FechaDesde & "'"
                Else
                    sqlWhere = sqlWhere & " AND (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) >= '" & FechaDesde & "'"
                End If
            End If
            If FechaHasta.Trim <> "" Then
                If sqlWhere.Trim = "" Then
                    sqlWhere = " WHERE (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & FechaHasta & "'"
                Else
                    sqlWhere = sqlWhere & " AND (SELECT Top 1 ASA_FechaSalida FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) <= '" & FechaHasta & "'"
                End If
            End If
        End If


        'Clientes
        If CliDesde.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_IdCliente >= '" & CliDesde & "'"
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente >= '" & CliDesde & "'"
            End If
        End If
        If CliHasta.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_IdCliente <= '" & CliHasta & "'"
            Else
                sqlWhere = sqlWhere & " AND FRA_IdCliente <= '" & CliHasta & "'"
            End If
        End If


        If CondicionDiasDesde.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & CondicionDiasDesde
            Else
                sqlWhere = sqlWhere & " AND " & CondicionDiasDesde
            End If
        End If

        If CondicionDiasHasta.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & CondicionDiasHasta
            Else
                sqlWhere = sqlWhere & " AND " & CondicionDiasHasta
            End If
        End If

        If lstPuntosVenta.Count > 0 Then
            If sqlWhere.Trim = "" Then
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ") & vbCrLf
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ") & vbCrLf
            End If
        End If

        If lst.Count > 0 Then
            If sqlWhere.Trim = "" Then
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idcliente, lst, " WHERE ", True) & vbCrLf
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(Facturas.FRA_idcliente, lst, " AND ", True) & vbCrLf
            End If
        End If




        Dim sql As String = "SELECT " & vbCrLf
        sql = sql & " CASE SUM(Importe) WHEN 0 THEN 0 ELSE SUM(Importe * DiasFra) / SUM(Importe) END as MDiasFra," & vbCrLf
        sql = sql & " CASE SUM(Importe) WHEN 0 THEN 0 ELSE SUM(Importe * DiasSal) / SUM(Importe) END as MDiasSal" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT COALESCE(CBL_ImporteCobradoDivisa,0) * COALESCE(COB_Cambio,1) as Importe, " & vbCrLf
        sql = sql & " DATEDIFF(day, FRA_Fecha, '" & TxFechaListado.Text & "') as DiasFra," & vbCrLf
        sql = sql & " (SELECT Top 1 DATEDIFF(day, ASA_FechaSalida, '" & TxFechaListado.Text & "') FROM AlbSalida WHERE ASA_IdFactura = FRA_IdFactura ORDER BY ASA_FechaSalida) as DiasSal" & vbCrLf
        sql = sql & " FROM CobrosLineas" & vbCrLf
        sql = sql & " INNER JOIN Facturas ON FRA_IdFactura = CBL_IdFactura " & vbCrLf
        sql = sql & " LEFT JOIN Cobros ON CBL_IdCobro = COB_IdCobro" & vbCrLf
        sql = sql & sqlWhere
        'sql = sql & CadenaWhereLista(Facturas.FRA_idcliente, lst, " WHERE ", True) & vbCrLf
        sql = sql & " ) as C" & vbCrLf


        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then
                DiasFra = VaDec(dt.Rows(0)("MDiasFra"))
                DiasSal = VaDec(dt.Rows(0)("MDiasSal"))
            End If

        End If



    End Sub


    Private Sub PeriodoMedioCobroPonderadoClientes(FechaDesde As String, FechaHasta As String, CliDesde As String, CliHasta As String, bDivisa As Boolean,
                                     FechaListado As String, bFechaFactura As Boolean, CondicionDiasDesde As String, CondicionDiasHasta As String,
                                     lstPuntosVenta As List(Of String),
                                     ByVal IdCliente As String, ByRef DiasFra As Decimal, ByRef DiasSal As Decimal)

        Dim lst As New List(Of String)
        lst.Add(IdCliente)

        PeriodoMedioCobroPonderadoClientes(FechaDesde, FechaHasta, CliDesde, CliHasta, bDivisa, FechaListado, bFechaFactura, CondicionDiasDesde,
                                           CondicionDiasHasta, lstPuntosVenta, lst, DiasFra, DiasSal)

    End Sub


    Private Sub PeriodoMedioCobroPonderadoClientes(FechaDesde As String, FechaHasta As String, CliDesde As String, CliHasta As String, bDivisa As Boolean,
                                     FechaListado As String, bFechaFactura As Boolean, CondicionDiasDesde As String, CondicionDiasHasta As String,
                                     lstPuntosVenta As List(Of String),
                                     Dc As Dictionary(Of String, DiasCliente), ByRef DiasFra As Decimal, ByRef DiasSal As Decimal)

        Dim lst As New List(Of String)
        For Each IdCliente As String In Dc.Keys
            lst.Add(IdCliente)
        Next

        PeriodoMedioCobroPonderadoClientes(FechaDesde, FechaHasta, CliDesde, CliHasta, bDivisa, FechaListado, bFechaFactura, CondicionDiasDesde,
                                           CondicionDiasHasta, lstPuntosVenta, lst, DiasFra, DiasSal)

    End Sub


    Public Overrides Sub CustomDrawFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
        MyBase.CustomDrawFooterCell(sender, e)


        Dim columna As String = e.Column.FieldName.ToUpper.Trim

        If chkDetallarFacturas.Checked Then

            Select Case columna
                Case "CONCEDIDO"
                    e.Info.DisplayText = ObtenerTotal(e.Column.FieldName, 5).ToString("#,##0.00")
                Case "DISPONIBLE"
                    e.Info.DisplayText = ObtenerTotal(e.Column.FieldName, 7).ToString("#,##0.00")
                Case "SALDOCTB"
                    e.Info.DisplayText = StSaldoDec(ObtenerTotal(e.Column.FieldName, 8))
            End Select

        Else

            If columna = "SALDOCTB" Then
                e.Info.DisplayText = StSaldoDec(e.Info.Value)
            End If

        End If


    End Sub


    Private Function ObtenerTotal(columna As String, indice_grupo As Integer) As Decimal

        Dim acum As Decimal = 0

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(columna)
            If Not IsNothing(col) Then

                Dim cadena As String = GridView1.GetGroupSummaryValue(indice, GridView1.GroupSummary.Item(indice_grupo)) & ""
                Dim valor As Decimal = VaDec(cadena.Replace("D", "").Replace("H", ""))
                If cadena.ToUpper.Contains("H") Then valor = -valor
                acum = acum + VaDec(valor)

            End If

        Next


        Return acum

    End Function


    Public Overrides Sub CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        MyBase.CustomColumnDisplayText(sender, e)

        Dim columna As String = e.Column.FieldName.Trim.ToUpper

        If chkDetallarFacturas.Checked Then
            If columna = "CONCEDIDO" Or columna = "SALDO" Or columna = "DISPONIBLE" Or columna = "SALDOCTB" Then
                e.DisplayText = ""
            End If
        ElseIf columna = "SALDOCTB" Then
            e.DisplayText = StSaldoDec(VaDec(e.Value))
        End If

        If columna = "FECHA" Or columna = "FECHASALIDA" Then
            If e.DisplayText = "01/01/1900" Then
                e.DisplayText = ""
            End If
        End If


        'If columna = "SALDOCTB" Then
        '    Dim ent As DictionaryEntry = GridView1.GetRowSummaryItem(e.RowHandle, column)
        'End If



    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If Not IsNothing(row) Then

            If column.FieldName.Trim.ToUpper = "DISPONIBLE" Then

                If VaDec(row("Disponible")) < 0 Then
                    e.Appearance.BackColor = Color.Red
                End If

            End If

        End If

    End Sub


    Private Function ObtenerEmpresaCtb(ByVal lst As List(Of String)) As EmpresaCtb

        Dim empresa As EmpresaCtb = EmpresaCtb.Hortichuelas

        Dim bCtb1 As Boolean = False
        Dim bCtb2 As Boolean = False
        Dim bCtb10 As Boolean = False


        For Each Ctb As String In lst

            If VaInt(Ctb) = VaInt(EmpresaCtb.Hortichuelas) Then
                bCtb1 = True
            End If
            If VaInt(Ctb) = VaInt(EmpresaCtb.HortiHorticola) Then
                bCtb2 = True
            End If
            If VaInt(Ctb) = VaInt(EmpresaCtb.EcoPark) Then
                bCtb10 = True
            End If

        Next


        If bCtb1 Or bCtb2 Then
            '1, 2 y 10
            If bCtb10 Then
                empresa = EmpresaCtb.Todas
            Else
                '1 ó 2
                empresa = EmpresaCtb.Hortichuelas
            End If
        ElseIf bCtb10 Then
            '10
            empresa = EmpresaCtb.EcoPark
        ElseIf lst.Count > 0 Then
            'hay puntos de venta seleccionados, pero no son de ninguna empresa
            empresa = EmpresaCtb.Hortichuelas
        Else
            'ninguna empresa seleccionada = todas las empresas
            empresa = EmpresaCtb.Todas
        End If


        Return empresa

    End Function


End Class