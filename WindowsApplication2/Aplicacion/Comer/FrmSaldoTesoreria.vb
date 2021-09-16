Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls

Public Class FrmSaldoTesoreria

    Inherits FrConsulta


    Private Enum misGrupos
        Clientes
        Fito
        Iva
        Impagos
        Agricultor
        Anticipo
        Acreedor
        Efectos
        Prestamos
        Personal
        Hacienda
    End Enum

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxdeFecha, Nothing, Lb5, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxhaFecha, Nothing, Lb4, False, Cdatos.TiposCampo.Fecha)

        'cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Fechaspordefecto()
    End Sub
    Private Sub Fechaspordefecto()
        TxdeFecha.Text = Format(DateAdd(DateInterval.WeekOfYear, -6, Now), "dd/MM/yyyy")
        TxhaFecha.Text = Format(DateAdd(DateInterval.Day, -1, Now), "dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim miTable As New DataTable
        miTable = SaldoTesoreria(TxdeFecha.Text, TxhaFecha.Text)

        Grid.DataSource = miTable

        ''Agrupar y expander
        'With GridView1.Columns
        '    If Not IsNothing(.ColumnByFieldName("Pais")) Then
        '        .ColumnByFieldName("Pais").GroupIndex = 1
        '    End If
        'End With
        'GridView1.ExpandAllGroups()

        AjustaColumnas()

        ''OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Saldo", "{0:n2}")
        AñadeResumenCampo("Saldon1", "{0:n2}")


    End Sub

    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim _miInforme As New miInforme(False)

        Dim altoGrafico As Integer = 245
        Dim anchoGrafico As Integer = 620

        _miInforme.Cabecera("|H Costa de Almeria", "70|400", milinea.stilos.Cabecera)
        _miInforme.Cabecera("Analisis de Saldo de Tesoreria|Fecha: " + Format(Now, "dd/MM/yyyy"), "400|>200", milinea.stilos.Grande)
        _miInforme.Cabecera("Desde fecha: " + TxdeFecha.Text + " hasta fecha: " + TxhaFecha.Text + "|Consolidado de cuentas", "400|>200", milinea.stilos.Normal)
        _miInforme.Cabecera("", "400|>200", milinea.stilos.Normal)


        Dim fichero_logo As String = "logo.png"

        Select Case MiMaletin.IdEmpresaCTB
            Case 1
                fichero_logo = "logo.png"
            Case Else
                fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
        End Select


        _miInforme.logo(Application.StartupPath & "\" & fichero_logo, 0, 0, 70, 30)



        Dim midetalle As New subInforme()
        Dim midetalle2 As New subInforme()


        Dim anchodetalle As String = "240|>150|>150|>150|>50"

        Dim graf As New DevExpress.XtraCharts.ChartControl
        AddHandler graf.CustomDrawSeriesPoint, AddressOf chart_CustomDrawSeriesPoint

        graf.Width = anchoGrafico
        graf.Height = altoGrafico

        Dim series1 As New Series("Campa15", ViewType.Bar)
        Dim series2 As New Series("Campa14", ViewType.Bar)
        Dim total As Double = 0
        Dim totaln1 As Double = 0

        'Dim _series(9) As Series
        'For grSerie As Integer = 0 To 9
        ' _series(grSerie) = New Series(nombreGruposgr(grSerie), ViewType.Bar)
        ' Next
        midetalle = New subInforme()
        midetalle.Cabecera("Concepto|Campaña 15|Campaña 14|Diferencia|%", anchodetalle, milinea.stilos.NormalBold)

        Dim miTable As New DataTable
        miTable = Grid.DataSource
        For Each orow As DataRow In miTable.Rows


            midetalle.Cabecera(orow("Concepto") + "|" + Format(orow("Saldo"), "#,##0.00") + "|" + _
                               Format(orow("Saldon1"), "#,##0.00") + "|" + _
                               Format(orow("Saldo") - orow("Saldon1"), "#,##0.00") + "|" + _
                                Format((Math.Abs(orow("Saldo") - orow("Saldon1")) * 100) / Math.Abs(orow("Saldo")), "#,##0.00"), anchodetalle, milinea.stilos.Normal)
            total += orow("Saldo")
            totaln1 += orow("Saldon1")

            'Creo una seriepoint y la agrego a la serie correspondiente
            Dim miSerieP As SeriesPoint

            miSerieP = New SeriesPoint(CType(orow("Grupo"), misGrupos).ToString, orow("Saldo"))
            series1.Points.Add(miSerieP)
            miSerieP = New SeriesPoint(CType(orow("Grupo"), misGrupos).ToString, orow("Saldon1"))
            series2.Points.Add(miSerieP)

        Next

        midetalle.Pie("Saldo total|" + Format(total, "#,##0.00") + "|" + Format(totaln1, "#,##0.00") + "|" + _
                     Format(total - totaln1, "#,##0.00") + "|" + _
                     Format((Math.Abs(total - totaln1) * 100) / Math.Abs(total), "#,##0.00"), anchodetalle, milinea.stilos.NormalBold)
        midetalle.Pie("", "100", milinea.stilos.Grande)
        _miInforme.AñadeDetalles(midetalle)

        midetalle = New subInforme()
        'For Each ser As Series In _series
        '    graf.Series.Add(ser)
        'Next
        graf.Series.Add(series1)
        graf.Series.Add(series2)
        graf.Legend.Visible = True
        midetalle.AñadeDetalles(graf)
        _miInforme.AñadeDetalles(midetalle)


        _miInforme.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    End Sub
    Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, _
ByVal e As CustomDrawSeriesPointEventArgs)
        'Si el valor el menor de la cantidad puesta, no visualiza los numeros.
        'If Math.Abs(e.SeriesPoint(0)) < 1000000 Then
        e.LabelText = ""
        'End If
    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()
        GridView1.OptionsBehavior.Editable = False

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "KILOS"
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                    Case "SALDO", "SALDON1"
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"

                End Select

            Next

        Catch ex As Exception
            'err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub


    Private Sub FrmConsultaAlbaranes_AntesDeMostrarTablaDinamica(ByVal f As NetAgro.FrTablaDinamica) Handles MyBase.AntesDeMostrarTablaDinamica

        'Ejemplo para añadir descripciones al informe
        'Dim lst As New List(Of String)
        'lst.Add("Aquí se pueden añadir")
        'lst.Add("líneas de descripción")
        'f.LineasDescripcion = lst

    End Sub


    Private Sub FrmConsultaAlbaranes_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles MyBase.DespuesDeIncluirCampoCalculado
        AñadeResumenCampo(c.FieldName, "{0:n2}")
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()
        LineasDescripcion.Add("De fecha: " & TxdeFecha.Text)
        LineasDescripcion.Add("A fecha: " & TxhaFecha.Text)

        MyBase.Imprimir()

    End Sub


    Public Function SaldoTesoreria(ByVal dfecha As String, ByVal hfecha As String) As DataTable
        Dim sqlstr As String

        Dim Tbtemp As New DataTable

        Dim newDt As New DataTable
        Dim miRow As DataRow
        Dim eDiario As New E_Asientos(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim dfechan1 As String = Format(DateAdd(DateInterval.Year, -1, CDate(dfecha)), "dd/MM/yyyy")
        Dim hfechan1 As String = Format(DateAdd(DateInterval.Year, -1, CDate(hfecha)), "dd/MM/yyyy")


        newDt.Columns.Add(New DataColumn("Concepto", GetType(String)))
        newDt.Columns.Add(New DataColumn("Saldo", GetType(Double)))
        newDt.Columns.Add(New DataColumn("Saldon1", GetType(Double)))
        newDt.Columns.Add(New DataColumn("Grupo", GetType(Integer)))

        '***************** Cobros a clientes ************************************
        sqlstr = "select sum(total) as total, sum(totaln1) as totaln1 from ("
        sqlstr += "select sum(cobradoeuros) as total, 0 as totaln1 from CobrosPagos.dbo.cobros "
        sqlstr += " where fechacobro>='" + dfecha + "' and fechacobro<='" + hfecha + "' and left(CuentaCliente,6)='430000' "
        sqlstr += " union all "
        sqlstr += "select 0 as totaln1 , sum(cobradoeuros) as total from CobrosPagos.dbo.cobros "
        sqlstr += " where fechacobro>='" + dfechan1 + "' and fechacobro<='" + hfechan1 + "' and left(CuentaCliente,6)='430000' "
        sqlstr += " ) as lin"

        ' restar vencimientos pendientes " select  sum(Importe)  from CobrosVencimientos  where CobrosVencimientos.Fecha > '26/04/2014' "

        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Cobro de clientes"
        miRow("Saldo") = Tbtemp.Rows(0)("total")
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1")
        miRow("Grupo") = CInt(misGrupos.Clientes)
        newDt.Rows.Add(miRow)

        '***************** Cobros a clientes ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ("
        sqlstr += "select sum(cobradoeuros) as total, 0 as totaln1 from CobrosPagos.dbo.cobros " & _
           " where fechacobro>='" + dfecha + "' and fechacobro<='" + hfecha + "' and left(CuentaCliente,6)='430007' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(cobradoeuros) as totaln1 from CobrosPagos.dbo.cobros " & _
            " where fechacobro>='" + dfechan1 + "' and fechacobro<='" + hfechan1 + "' and left(CuentaCliente,6)='430007' "
        sqlstr += " ) as lin "

        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Cobro de clientes (Fito)"
        miRow("Saldo") = Tbtemp.Rows(0)("total")
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1")
        miRow("Grupo") = CInt(misGrupos.Fito)
        newDt.Rows.Add(miRow)

        '***************** Devolucion de iva ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ("
        sqlstr += "select sum(haber) as total, 0 as totaln1 from AsientoLineas where NumeroCuenta='47090000000' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' and documento<>'@@@' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(haber) as totaln1 from AsientoLineas where NumeroCuenta='47090000000' and Fecha >='" + dfechan1 + "' and Fecha<='" + hfechan1 + "' and documento<>'@@@' "
        sqlstr += " ) as lin "
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Devolucion de IVA"
        miRow("Saldo") = Tbtemp.Rows(0)("total")
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1")
        miRow("Grupo") = CInt(misGrupos.Iva)
        newDt.Rows.Add(miRow)

        '***************** Pago a agricultores ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "SELECT sum(ImporteTalon1 + ImporteTalon2 + ImporteTalon3 + ImporteTalon4) as total, 0 as totaln1  FROM CobrosPagos.dbo.LiquidacionesAgricultores " & _
                " where FechaEmision >= '" + dfecha + "' and FechaEmision <= '" + hfecha + "'"
        sqlstr += " union all "
        sqlstr += "SELECT 0 as total, sum(ImporteTalon1 + ImporteTalon2 + ImporteTalon3 + ImporteTalon4) as totaln1  FROM CobrosPagos.dbo.LiquidacionesAgricultores " & _
                " where FechaEmision >= '" + dfechan1 + "' and FechaEmision <= '" + hfechan1 + "'"
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Pagos Agricultores"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Agricultor)
        newDt.Rows.Add(miRow)

        '***************** Anticipo a agricultores ************************************
        'sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        'sqlstr += "SELECT sum(importe) as total, 0 as totaln1 FROM CobrosPagos.dbo.Pagos " & _
        '    " where left(idcuenta,3)='407' and fechapago>='" + dfecha + "' and fechapago<= '" + hfecha + "'"
        'sqlstr += " union all "
        'sqlstr += "SELECT 0 as total, sum(importe) as totaln1 FROM CobrosPagos.dbo.Pagos " & _
        '    " where left(idcuenta,3)='407' and fechapago>='" + dfechan1 + "' and fechapago<= '" + hfechan1 + "'"
        'sqlstr += ") as lin"
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select sum(debe) as total, 0 as totaln1 from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,5)='40700' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' and documento<>'@@@' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(debe) as totaln1 from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,5)='40700' and Fecha >='" + dfechan1 + "' and Fecha<='" + hfechan1 + "' and documento<>'@@@' "
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Anticipos Agricultores"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Anticipo)
        newDt.Rows.Add(miRow)

        '***************** Pago acreedores ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select sum(importe) as total, 0 as totaln1 from CobrosPagos.dbo.pagos " & _
                " where (left(idcuenta,5)= '41000' or left(idcuenta,5)= '41100' or left(idcuenta,5)= '40100' or left(idcuenta,5)= '41090' or left(idcuenta,5)= '41900') " & _
               " and  fechapago>='" + dfecha + "' and fechapago<= '" + hfecha + "'"
        sqlstr += " union all "
        sqlstr += "select 0 as totaln1, sum(importe) as total from CobrosPagos.dbo.pagos " & _
                " where (left(idcuenta,5)= '41000' or left(idcuenta,5)= '41100' or left(idcuenta,5)= '40100' or left(idcuenta,5)= '41090' or left(idcuenta,5)= '41900') " & _
               " and  fechapago>='" + dfechan1 + "' and fechapago<= '" + hfechan1 + "'"
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Acreedores, proveedores de material y diversos"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Acreedor)
        newDt.Rows.Add(miRow)

        '***************** Efectos pendientes de cobro ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select  sum(Importe) as total, 0 as totaln1 from CobrosPagos.dbo.CobrosVencimientos  as v inner join CobrosPagos.dbo.Cobros as c on  v.IdCobro = c.IdCobro where  c.FechaCobro>= '" + dfecha + "' and c.FechaCobro <= '" + hfecha + "' and v.Fecha >  '" + hfecha + "'"
        sqlstr += " union all "
        sqlstr += "select  0 as total, sum(Importe) as totaln1 from CobrosPagos.dbo.CobrosVencimientos  as v inner join CobrosPagos.dbo.Cobros as c on  v.IdCobro = c.IdCobro where  c.FechaCobro>= '" + dfechan1 + "' and c.FechaCobro <= '" + hfechan1 + "' and v.Fecha >  '" + hfechan1 + "'"
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Efectos pendientes de cobro (Clientes)"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Efectos)
        newDt.Rows.Add(miRow)

        '***************** Personal ************************************
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select sum(debe) as total, 0 as totaln1 from Contabilidadcosta.dbo.AsientoLineas where NumeroCuenta='46500000000' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' and documento<>'@@@' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(debe) as totaln1 from Contabilidadcosta.dbo.AsientoLineas where NumeroCuenta='46500000000' and Fecha >='" + dfechan1 + "' and Fecha<='" + hfechan1 + "' and documento<>'@@@' "
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Personal"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Personal)
        newDt.Rows.Add(miRow)

        '***************** Hacienda y SS ************************************
        'sqlstr = "select sum(debe) as totaliva from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,10)='4760000000' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' "
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select sum(debe) as total, 0 as totaln1 from Contabilidadcosta.dbo.AsientoLineas where NumeroCuenta='47510500000' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' and documento<>'@@@' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(debe) as totaln1 from Contabilidadcosta.dbo.AsientoLineas where NumeroCuenta='47510500000' and Fecha >='" + dfechan1 + "' and Fecha<='" + hfechan1 + "' and documento<>'@@@' "
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Hacienda (retenciones y S.S.)"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Hacienda)
        newDt.Rows.Add(miRow)

        '***************** Prestamos ************************************
        'sqlstr = "select sum(debe) as totaliva from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,8)='52000000' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' "
        'Itemp = oSql.ConsultaSQLUltimoRegistro(sqlstr)
        sqlstr = " select sum(total) as total, sum(totaln1) as totaln1 from ( "
        sqlstr += "select sum(debe) as total, 0 as totaln1 from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,3)='527' and Fecha >='" + dfecha + "' and Fecha<='" + hfecha + "' and documento<>'@@@' "
        sqlstr += " union all "
        sqlstr += "select 0 as total, sum(debe) as totaln1 from Contabilidadcosta.dbo.AsientoLineas where left(NumeroCuenta,3)='527' and Fecha >='" + dfechan1 + "' and Fecha<='" + hfechan1 + "' and documento<>'@@@' "
        sqlstr += ") as lin"
        Tbtemp = eDiario.MiConexion.ConsultaSQL(sqlstr)
        miRow = newDt.NewRow()
        miRow("Concepto") = "Prestamos e intereses polizas"
        miRow("Saldo") = Tbtemp.Rows(0)("total") * -1
        miRow("Saldon1") = Tbtemp.Rows(0)("totaln1") * -1
        miRow("Grupo") = CInt(misGrupos.Prestamos)
        newDt.Rows.Add(miRow)



        Return newDt
    End Function

End Class
