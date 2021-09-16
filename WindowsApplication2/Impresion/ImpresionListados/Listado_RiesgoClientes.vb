Public Class Listado_RiesgoClientes
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property FechaListado As String
    Property ClienteDesde As String
    Property ClienteHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property CalculoSobreSalida As Boolean
    Property PendientesFacturar As Boolean
    Property Detallado As Boolean
    Property TipoImpresion As TipoImpresion



    Dim CabeceraDetallado As String = "CE | N.FACT | F.FACTURA | F.SALIDA | DIFAC | DISAL | -30 DIAS | -45 DIAS | -60 DIAS | -90 DIAS | +90 DIAS | CONCED. | SALDO | DISPONIBLE | SALDO CTB"
    Dim CabeceraResumido As String = "Cliente | DIFAC | DISAL | -30 DIAS | -45 DIAS | -60 DIAS | -90 DIAS | +90 DIAS | CONCED. | SALDO | DISPONIBLE | SALDO CTB"
    Dim FormatoDetallado As String = "8|17|17|17|>10|>10|>20|>20|>20|>20|>20|>24|>24|>24|>26"
    Dim FormatoResumido As String = "59|>10|>10|>20|>20|>20|>20|>20|>24|>24|>24|>26"
    'Dim FormatoTotales As String = "79|>20|>20|>20|>20|>20|>24|>24|>24|>26"

    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina
    Dim ListaPuntosVenta As String = ""


    Public Sub New(ByVal dt As DataTable, ByVal fechaListado As String, ByVal clienteDesde As String, ByVal clienteHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal calculoSobreSalida As Boolean, _
                   ByVal pendientesFacturar As Boolean, ByVal detallado As Boolean, ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.FechaListado = fechaListado
        Me.ClienteDesde = clienteDesde
        Me.ClienteHasta = clienteHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.CalculoSobreSalida = calculoSobreSalida
        Me.PendientesFacturar = pendientesFacturar
        Me.Detallado = detallado
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 10
        MargenDer = 10

        EstableceListado(Orientacion.Horizontal, TipoImpresion)
        Ancho = AnchoPagina - MargenIzq - MargenDer

        Try

            ConfiguraListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub ConfiguraListado()
       

        ConfiguraCabecera()

       
        If Detallado Then
            Listado.Cabecera.Linea(CabeceraDetallado, FormatoDetallado, Estilos.ReducidaBoldLineaDebajo)
        Else
            Listado.Cabecera.Linea(CabeceraResumido, FormatoResumido, Estilos.ReducidaBoldLineaDebajo)
        End If
        Listado.Cabecera.Linea("", Formato, Estilos.Reducida)

        Dim listaCampos As New List(Of String)
        listaCampos.Add("30")
        listaCampos.Add("45")
        listaCampos.Add("60")
        listaCampos.Add("90")
        listaCampos.Add("+90")
        listaCampos.Add("t.saldo")
        listaCampos.Add("ImpDiasFra")
        listaCampos.Add("ImpDiasSal")

        Dim totalCliente As New AcumuladorTotales(listaCampos)
        Dim total As New AcumuladorTotales(listaCampos)

        Dim totalConcedidos As Decimal = 0
        Dim totalSaldoCtb As Decimal = 0

        Dim idClienteActual As Integer = 0
        Dim clienteActual As String = ""
        Dim concedidoActual As Decimal = 0
        Dim saldoCtbActual As Decimal = 0
        Dim primera As Boolean = True

        For Each r As DataRow In Dt.Rows

            Dim idCliente As Integer = VaInt(r("IdCliente"))
            Dim cliente As String = r("Cliente").ToString
            Dim diFac As Integer = VaInt(r("DiasFra"))
            Dim diSal As Integer = VaInt(r("DiasSal"))
            Dim pendiente30 As Decimal = VaDec(r("Pendiente30"))
            Dim pendiente45 As Decimal = VaDec(r("Pendiente45"))
            Dim pendiente60 As Decimal = VaDec(r("Pendiente60"))
            Dim pendiente90 As Decimal = VaDec(r("Pendiente90"))
            Dim pendiente90Plus As Decimal = VaDec(r("Pendiente90Plus"))
            Dim concedido As Decimal = VaDec(r("Concedido"))
            Dim saldo As Decimal = VaDec(r("Saldo"))
            Dim disponible As Decimal = VaDec(r("Disponible"))
            Dim saldoCtb As Decimal = VaDec(r("SaldoCtb"))
            Dim ImpDiasFra As Decimal = VaDec(r("ImpDiasFra"))
            Dim ImpDiasSal As Decimal = VaDec(r("ImpDiasSal"))


            If Not idCliente = idClienteActual And Not primera Then


                Dim TDiasFra As Integer = 0
                Dim TDiasSal As Integer = 0

                Dim TSaldo As Decimal = totalCliente.GetValor("t.saldo")
                Dim TImpDiasFra As Decimal = totalCliente.GetValor("ImpDiasFra")
                Dim TImpDiasSal As Decimal = totalCliente.GetValor("ImpDiasSal")

                If TSaldo <> 0 Then
                    TDiasFra = TImpDiasFra / TSaldo
                    TDiasSal = TImpDiasSal / TSaldo
                End If


                If Detallado Then
                    Texto = clienteActual & " | "
                    Texto = Texto & TDiasFra.ToString & " | "
                    Texto = Texto & TDiasSal.ToString & " | "
                    If Not totalCliente.GetValor("30") = 0 Then Texto = Texto & totalCliente.GetValor("30").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not totalCliente.GetValor("45") = 0 Then Texto = Texto & totalCliente.GetValor("45").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not totalCliente.GetValor("60") = 0 Then Texto = Texto & totalCliente.GetValor("60").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not totalCliente.GetValor("90") = 0 Then Texto = Texto & totalCliente.GetValor("90").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not totalCliente.GetValor("+90") = 0 Then Texto = Texto & totalCliente.GetValor("+90").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not concedidoActual = 0 Then Texto = Texto & concedidoActual.ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not totalCliente.GetValor("t.saldo") = 0 Then Texto = Texto & totalCliente.GetValor("t.saldo").ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not (concedidoActual - totalCliente.GetValor("t.saldo")) = 0 Then Texto = Texto & (concedidoActual - totalCliente.GetValor("t.saldo")).ToString("#,##0.00")
                    Texto = Texto & " | "
                    If Not saldoCtbActual = 0 Then Texto = Texto & StSaldoDec(saldoCtbActual)
                    Listado.Detalle.Linea(Texto, FormatoResumido, Estilos.ReducidaBold)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaDebajo)

                End If

                totalSaldoCtb = totalSaldoCtb + saldoCtbActual
                totalConcedidos = totalConcedidos + concedidoActual
                totalCliente.ReiniciarValores()

            End If




            If Detallado Then

                Dim centro As String = r("CE").ToString
                Dim factura As String = r("Factura").ToString
                Dim fechaFactura As String = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
                Dim fechaSalida As String = VaDate(r("FechaSalida")).ToString("dd/MM/yyyy")

                'diFac = 0
                'diSal = 0

                Texto = centro & " | "
                Texto = Texto & factura & " | "
                Texto = Texto & fechaFactura & " | "
                Texto = Texto & fechaSalida & " | "

                Texto = Texto & diFac.ToString("#,###") & " | "
                Texto = Texto & diSal.ToString("#,###") & " | "
                If Not pendiente30 = 0 Then Texto = Texto & pendiente30.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente45 = 0 Then Texto = Texto & pendiente45.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente60 = 0 Then Texto = Texto & pendiente60.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente90 = 0 Then Texto = Texto & pendiente90.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente90Plus = 0 Then Texto = Texto & pendiente90Plus.ToString("#,##0.00")
                Texto = Texto & " ||||"

                Listado.Detalle.Linea(Texto, FormatoDetallado, Estilos.Reducida)

            Else

                Texto = cliente & " | "

                Texto = Texto & diFac.ToString("#,###") & " | "
                Texto = Texto & diSal.ToString("#,###") & " | "
                If Not pendiente30 = 0 Then Texto = Texto & pendiente30.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente45 = 0 Then Texto = Texto & pendiente45.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente60 = 0 Then Texto = Texto & pendiente60.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente90 = 0 Then Texto = Texto & pendiente90.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not pendiente90Plus = 0 Then Texto = Texto & pendiente90Plus.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not concedido = 0 Then Texto = Texto & concedido.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not saldo = 0 Then Texto = Texto & saldo.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not disponible = 0 Then Texto = Texto & disponible.ToString("#,##0.00")
                Texto = Texto & " | "
                If Not saldoCtb = 0 Then Texto = Texto & StSaldoDec(saldoCtb)

                Listado.Detalle.Linea(Texto, FormatoResumido, Estilos.Reducida)

            End If




            Dim listaValores As New List(Of Decimal)
            listaValores.Add(pendiente30)
            listaValores.Add(pendiente45)
            listaValores.Add(pendiente60)
            listaValores.Add(pendiente90)
            listaValores.Add(pendiente90Plus)
            listaValores.Add(saldo)
            listaValores.Add(ImpDiasFra)
            listaValores.Add(ImpDiasSal)

            totalCliente.Suma(listaValores)
            total.Suma(listaValores)

            idClienteActual = idCliente
            clienteActual = cliente
            concedidoActual = concedido
            saldoCtbActual = saldoCtb

            primera = False


            Application.DoEvents()

        Next



        If Detallado Then

            Dim TDiasFra As Integer = 0
            Dim TDiasSal As Integer = 0

            Dim TSaldo As Decimal = totalCliente.GetValor("t.saldo")
            Dim TImpDiasFra As Decimal = totalCliente.GetValor("ImpDiasFra")
            Dim TImpDiasSal As Decimal = totalCliente.GetValor("ImpDiasSal")

            If TSaldo <> 0 Then
                TDiasFra = TImpDiasFra / TSaldo
                TDiasSal = TImpDiasSal / TSaldo
            End If

            Texto = clienteActual & " | "
            Texto = Texto & TDiasFra.ToString & " | "
            Texto = Texto & TDiasSal.ToString & " | "
            If Not totalCliente.GetValor("30") = 0 Then Texto = Texto & totalCliente.GetValor("30").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not totalCliente.GetValor("45") = 0 Then Texto = Texto & totalCliente.GetValor("45").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not totalCliente.GetValor("60") = 0 Then Texto = Texto & totalCliente.GetValor("60").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not totalCliente.GetValor("90") = 0 Then Texto = Texto & totalCliente.GetValor("90").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not totalCliente.GetValor("+90") = 0 Then Texto = Texto & totalCliente.GetValor("+90").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not concedidoActual = 0 Then Texto = Texto & concedidoActual.ToString("#,##0.00")
            Texto = Texto & " | "
            If Not totalCliente.GetValor("t.saldo") = 0 Then Texto = Texto & totalCliente.GetValor("t.saldo").ToString("#,##0.00")
            Texto = Texto & " | "
            If Not (concedidoActual - totalCliente.GetValor("t.saldo")) = 0 Then Texto = Texto & (concedidoActual - totalCliente.GetValor("t.saldo")).ToString("#,##0.00")
            Texto = Texto & " | "
            If Not saldoCtbActual = 0 Then Texto = Texto & StSaldoDec(saldoCtbActual)
            Listado.Detalle.Linea(Texto, FormatoResumido, Estilos.ReducidaBold)

        End If


        totalSaldoCtb = totalSaldoCtb + saldoCtbActual
        totalConcedidos = totalConcedidos + concedidoActual

        Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaDebajo)


        'Gran total
        Dim TTDiasFra As Integer = 0
        Dim TTDiasSal As Integer = 0

        Dim TTSaldo As Decimal = total.GetValor("t.saldo")
        Dim TTImpDiasFra As Decimal = total.GetValor("ImpDiasFra")
        Dim TTImpDiasSal As Decimal = total.GetValor("ImpDiasSal")

        If TTSaldo <> 0 Then
            TTDiasFra = TTImpDiasFra / TTSaldo
            TTDiasSal = TTImpDiasSal / TTSaldo
        End If


        Texto = "TOTAL LISTADO | "
        Texto = Texto & TTDiasFra.ToString & " | "
        Texto = Texto & TTDiasSal.ToString & " | "
        If Not total.GetValor("30") = 0 Then Texto = Texto & total.GetValor("30").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not total.GetValor("45") = 0 Then Texto = Texto & total.GetValor("45").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not total.GetValor("60") = 0 Then Texto = Texto & total.GetValor("60").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not total.GetValor("90") = 0 Then Texto = Texto & total.GetValor("90").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not total.GetValor("+90") = 0 Then Texto = Texto & total.GetValor("+90").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not totalConcedidos = 0 Then Texto = Texto & totalConcedidos.ToString("#,##0.00")
        Texto = Texto & " | "
        If Not total.GetValor("t.saldo") = 0 Then Texto = Texto & total.GetValor("t.saldo").ToString("#,##0.00")
        Texto = Texto & " | "
        If Not (totalConcedidos - total.GetValor("t.saldo")) = 0 Then Texto = Texto & (totalConcedidos - total.GetValor("t.saldo")).ToString("#,##0.00")
        Texto = Texto & " | "
        If Not totalSaldoCtb = 0 Then Texto = Texto & StSaldoDec(totalSaldoCtb)
        Listado.Detalle.Linea(Texto, FormatoResumido, Estilos.ReducidaBold)

    End Sub


    'Private Sub ConfiguraListadoDetallado()
    '    ConfiguraCabecera()

    '    'Texto = "CE | N.FACT | F.FACTURA | F.SALIDA | DIFAC | DISAL | -30 DIAS | -45 DIAS | -60 DIAS | -90 DIAS | +90 DIAS | "
    '    'Texto = Texto & "CONCED. | SALDO | DISPONIBLE | SALDO CTB"
    '    'Formato = "8|17|17|17|>10|>10|>20|>20|>20|>20|>20|>24|>24|>24|>26"

    '    Listado.Cabecera.Linea(CabeceraDetallado, FormatoDetallado, Estilos.ReducidaBoldLineaDebajo)
    '    Listado.Cabecera.Linea("", Formato, Estilos.Reducida)

    '    Dim listaCampos As New List(Of String)
    '    listaCampos.Add("30")
    '    listaCampos.Add("45")
    '    listaCampos.Add("60")
    '    listaCampos.Add("90")
    '    listaCampos.Add("+90")
    '    listaCampos.Add("t.saldo")

    '    Dim totalCliente As New AcumuladorTotales(listaCampos)
    '    Dim total As New AcumuladorTotales(listaCampos)

    '    Dim totalConcedidos As Decimal = 0
    '    Dim totalSaldoCtb As Decimal = 0

    '    Dim idClienteActual As Integer = 0
    '    Dim clienteActual As String = ""
    '    Dim concedidoActual As Decimal = 0
    '    Dim saldoCtbActual As Decimal = 0
    '    Dim primera As Boolean = True

    '    For Each r As DataRow In Dt.Rows

    '        Dim idCliente As Integer = VaInt(r("IdCliente"))
    '        Dim cliente As String = r("Cliente").ToString
    '        Dim centro As String = r("CE").ToString
    '        Dim factura As String = r("Factura").ToString
    '        Dim fechaFactura As String = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
    '        Dim fechaSalida As String = VaDate(r("FechaSalida")).ToString("dd/MM/yyyy")
    '        Dim diFac As Integer = VaInt(r("DiasFra"))
    '        Dim diSal As Integer = VaInt(r("DiasSal"))
    '        Dim pendiente30 As Decimal = VaDec(r("Pendiente30"))
    '        Dim pendiente45 As Decimal = VaDec(r("Pendiente45"))
    '        Dim pendiente60 As Decimal = VaDec(r("Pendiente60"))
    '        Dim pendiente90 As Decimal = VaDec(r("Pendiente90"))
    '        Dim pendiente90Plus As Decimal = VaDec(r("Pendiente90Plus"))
    '        Dim concedido As Decimal = VaDec(r("Concedido"))
    '        Dim saldo As Decimal = VaDec(r("Saldo"))
    '        Dim disponible As Decimal = VaDec(r("Disponible"))
    '        Dim saldoCtb As Decimal = VaDec(r("SaldoCtb"))

    '        If Not idCliente = idClienteActual And Not primera Then
    '            Texto = clienteActual & " | "
    '            If Not totalCliente.GetValor("30") = 0 Then Texto = Texto & totalCliente.GetValor("30").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not totalCliente.GetValor("45") = 0 Then Texto = Texto & totalCliente.GetValor("45").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not totalCliente.GetValor("60") = 0 Then Texto = Texto & totalCliente.GetValor("60").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not totalCliente.GetValor("90") = 0 Then Texto = Texto & totalCliente.GetValor("90").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not totalCliente.GetValor("+90") = 0 Then Texto = Texto & totalCliente.GetValor("+90").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not concedidoActual = 0 Then Texto = Texto & concedidoActual.ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not totalCliente.GetValor("t.saldo") = 0 Then Texto = Texto & totalCliente.GetValor("t.saldo").ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not (concedidoActual - totalCliente.GetValor("t.saldo")) = 0 Then Texto = Texto & (concedidoActual - totalCliente.GetValor("t.saldo")).ToString("#,##0.00")
    '            Texto = Texto & " | "
    '            If Not saldoCtbActual = 0 Then Texto = Texto & StSaldoDec(saldoCtbActual)
    '            Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.ReducidaBold)
    '            Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaDebajo)

    '            totalSaldoCtb = totalSaldoCtb + saldoCtbActual
    '            totalConcedidos = totalConcedidos + concedidoActual
    '            totalCliente.ReiniciarValores()
    '        End If

    '        If Detallado Then
    '            Texto = centro & " | "
    '            Texto = Texto & factura & " | "
    '            Texto = Texto & fechaFactura & " | "
    '            Texto = Texto & fechaSalida & " | "
    '        Else
    '            Texto = cliente & " | "
    '        End If
    '        Texto = Texto & diFac & " | "
    '        Texto = Texto & diSal & " | "
    '        If Not pendiente30 = 0 Then Texto = Texto & pendiente30.ToString("#,##0.00")
    '        Texto = Texto & " | "
    '        If Not pendiente45 = 0 Then Texto = Texto & pendiente45.ToString("#,##0.00")
    '        Texto = Texto & " | "
    '        If Not pendiente60 = 0 Then Texto = Texto & pendiente60.ToString("#,##0.00")
    '        Texto = Texto & " | "
    '        If Not pendiente90 = 0 Then Texto = Texto & pendiente90.ToString("#,##0.00")
    '        Texto = Texto & " | "
    '        If Not pendiente90Plus = 0 Then Texto = Texto & pendiente90Plus.ToString("#,##0.00")
    '        Texto = Texto & " ||||"
    '        Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)

    '        Dim listaValores As New List(Of Decimal)
    '        listaValores.Add(pendiente30)
    '        listaValores.Add(pendiente45)
    '        listaValores.Add(pendiente60)
    '        listaValores.Add(pendiente90)
    '        listaValores.Add(pendiente90Plus)
    '        listaValores.Add(saldo)

    '        totalCliente.Suma(listaValores)
    '        total.Suma(listaValores)

    '        idClienteActual = idCliente
    '        clienteActual = cliente
    '        concedidoActual = concedido
    '        saldoCtbActual = saldoCtb

    '        primera = False
    '    Next

    '    Texto = clienteActual & " | "
    '    If Not totalCliente.GetValor("30") = 0 Then Texto = Texto & totalCliente.GetValor("30").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalCliente.GetValor("45") = 0 Then Texto = Texto & totalCliente.GetValor("45").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalCliente.GetValor("60") = 0 Then Texto = Texto & totalCliente.GetValor("60").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalCliente.GetValor("90") = 0 Then Texto = Texto & totalCliente.GetValor("90").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalCliente.GetValor("+90") = 0 Then Texto = Texto & totalCliente.GetValor("+90").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not concedidoActual = 0 Then Texto = Texto & concedidoActual.ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalCliente.GetValor("t.saldo") = 0 Then Texto = Texto & totalCliente.GetValor("t.saldo").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not (concedidoActual - totalCliente.GetValor("t.saldo")) = 0 Then Texto = Texto & (concedidoActual - totalCliente.GetValor("t.saldo")).ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not saldoCtbActual = 0 Then Texto = Texto & StSaldoDec(saldoCtbActual)
    '    Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.ReducidaBold)
    '    Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaDebajo)

    '    totalSaldoCtb = totalSaldoCtb + saldoCtbActual
    '    totalConcedidos = totalConcedidos + concedidoActual

    '    Texto = "TOTAL LISTADO | "
    '    If Not total.GetValor("30") = 0 Then Texto = Texto & total.GetValor("30").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not total.GetValor("45") = 0 Then Texto = Texto & total.GetValor("45").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not total.GetValor("60") = 0 Then Texto = Texto & total.GetValor("60").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not total.GetValor("90") = 0 Then Texto = Texto & total.GetValor("90").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not total.GetValor("+90") = 0 Then Texto = Texto & total.GetValor("+90").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalConcedidos = 0 Then Texto = Texto & totalConcedidos.ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not total.GetValor("t.saldo") = 0 Then Texto = Texto & total.GetValor("t.saldo").ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not (totalConcedidos - total.GetValor("t.saldo")) = 0 Then Texto = Texto & (totalConcedidos - total.GetValor("t.saldo")).ToString("#,##0.00")
    '    Texto = Texto & " | "
    '    If Not totalSaldoCtb = 0 Then Texto = Texto & StSaldoDec(totalSaldoCtb)
    '    Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.ReducidaBold)
    'End Sub

    Private Sub ConfiguraListadoResumido()
        ConfiguraCabecera()
    End Sub

    Private Sub ConfiguraCabecera()
        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Dim tipoListado As String = "Resumido"
        If Detallado Then tipoListado = "Detallado"

        Texto = "Listado Riesgos de Clientes - " & tipoListado
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        MetodosComunesListados.FormatoFiltro(ClienteDesde)
        MetodosComunesListados.FormatoFiltro(ClienteHasta, 5, LimiteFiltro.Superior)
        If Not Len(FechaDesde.Trim) > 0 Then FechaDesde = "01/01/1900"
        If Not Len(FechaHasta.Trim) > 0 Then FechaHasta = FechaListado

        Texto = "Desde fecha: " & FechaDesde & "; Hasta fecha: " & FechaHasta & " | Fecha informe: " & FechaListado
        Formato = (Ancho - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Dim sobreFecha As String = "Rgo S/Fecha Factura"
        If CalculoSobreSalida Then sobreFecha = "Rgo S/Fecha Salida"

        Texto = "Desde cliente: " & ClienteDesde & "; Hasta cliente: " & ClienteHasta & " | " & sobreFecha
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Dim albaranesPendientes As String = "N"
        If PendientesFacturar Then albaranesPendientes = "S"
        Texto = "Albaranes pendientes de facturar: " & albaranesPendientes
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)
    End Sub


End Class
