Public Class Listado_Ventas_Gastos_Albaran
    Inherits Listado_ImpresionBase

    Property Datos As DataTable
    Property DesdeCliente As String
    Property HastaCliente As String
    Property DesdeFecha As String
    Property HastaFecha As String
    Property PuntoVenta As String
    Property AlbValorados As String
    Property AlbFacturados As String
    Property TipoVenta As String
    Property Empresa As String
    Property Ancho As Integer = 195
    Property AnchoHorizontal As Integer = 280
    Property TipoImpresion As TipoImpresion


    Dim FiltroCliente As String
    Dim FiltroFecha As String

    Dim TipoVent As String
    Dim AlbFac As String



    'CABECERA
    Property Cabecera = "ALBAR.||FECHA||MATRICULA||KILOS||IMP.VENTA||IMP.ENVASES||TOT.VENTA||GTOS.FACT.||VEN.NETA||GTOS.COMER.||GTOS.ALMAC.||VEN.FINAL"
    Property Formato As String = "13|5|13|5|16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16"
    Property FormatoCli As String = "15|5|32|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16"
    'Property FormatoTot As String = "62|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|5|>16|4|>16"

    Public Sub New(ByVal Datos As DataTable, ByVal DesdeCliente As String, ByVal HastaCliente As String, ByVal DesdeFecha As String, ByVal HastaFecha As String,
                   ByVal PuntoVenta As String, ByVal AlbValorados As String, ByVal AlbFacturados As String,
                   ByVal TipoVenta As String, ByVal Empresa As String, ByVal tipoImpresion As TipoImpresion)



        If PuntoVenta = "" Then PuntoVenta = "TODOS"

        Me.Datos = Datos
        Me.DesdeCliente = DesdeCliente
        Me.HastaCliente = HastaCliente
        Me.Empresa = Empresa
        Me.DesdeFecha = DesdeFecha
        Me.HastaFecha = HastaFecha
        Me.PuntoVenta = PuntoVenta
        Me.AlbValorados = AlbValorados
        Me.AlbFacturados = AlbFacturados
        Me.TipoVenta = TipoVenta

        Me.TipoImpresion = tipoImpresion

    End Sub

    Public Overrides Sub ImprimirListado()


        MargenSup = 10
        MargenIzq = 8
        MargenDer = 8
        MargenInf = 10

        'Tipo de Impresion Y orientacion segun el listado
   
        EstableceListado(Orientacion.Horizontal, TipoImpresion)

        Try

            ImprimirCabecera()
            ImprimirDetalle()

            Select Case TipoImpresion
                Case NetAgro.TipoImpresion.Preliminar
                    Previsualiza()
                Case NetAgro.TipoImpresion.ImpresoraPorDefecto
                    ImprimeDirecto()
            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ImprimirCabecera()

        Dim texto As String = MiMaletin.NombreEmpresa.ToString

        Listado.Cabecera.Linea(texto, AnchoHorizontal.ToString, Estilos.Cabecera)
        Listado.Cabecera.Linea("", AnchoHorizontal.ToString, Estilos.Minima)

        texto = "Listado Ventas y Gastos por Albaran"
        Listado.Cabecera.Linea(texto, "220", Estilos.GrandeBold)

        Filtros()
        FiltrosPaginaHorizontal()

    End Sub


    Public Sub Filtros()

        Select Case Me.TipoVenta
            Case "F"
                TipoVent = "Venta Firme"
            Case "C"
                TipoVent = "Venta Comision"
            Case "T"
                TipoVent = "TODOS"
        End Select

        Select Case Me.AlbFacturados
            Case "S"
                AlbFac = "SI"
            Case "N"
                AlbFac = "NO"
            Case "T"
                AlbFac = "TODOS"

        End Select

        Select Case Me.AlbValorados
            Case "S"
                AlbValorados = "SI"
            Case "N"
                AlbValorados = "NO"
            Case "T"
                AlbValorados = "TODOS"

        End Select

        If DesdeCliente = "" Then DesdeCliente = "00001"
        If HastaCliente = "" Then HastaCliente = "99999"


        FiltroCliente = FiltroDesdeHasta("Cliente", DesdeCliente, HastaCliente)
        FiltroFecha = FiltroDesdeHasta("Fecha", DesdeFecha, HastaFecha)


    End Sub



    Private Sub FiltrosPaginaHorizontal()

        Dim texto As String = ""


        texto = FiltroCliente & "|Tipo de Venta: " & TipoVent
        Listado.Cabecera.Linea(texto, "140|>140", Estilos.ReducidaBold)


        texto = FiltroFecha & "|Albaranes Facturados: " & AlbFac
        Listado.Cabecera.Linea(texto, "140|>140", Estilos.ReducidaBold)


        texto = PuntoVenta & "|Albaranes Valorados: " & AlbValorados
        Listado.Cabecera.Linea(texto, "140|>140", Estilos.ReducidaBold)

        texto = Empresa
        Listado.Cabecera.Linea(texto, "140", Estilos.ReducidaBold)

        'Espacio
        Listado.Cabecera.Linea("", AnchoHorizontal.ToString, Estilos.Minima)

    End Sub



    Private Sub ImprimirDetalle()

        ImprimeListado()

    End Sub

    'Imprimir Listado
    Private Sub ImprimeListado()

        Dim texto As String = ""

        Dim Totalkilos As Decimal = 0
        Dim TotalImpVenta As Decimal = 0
        Dim TotalImpEnvases As Decimal = 0

        Dim TotalVenta As Decimal = 0
        Dim TotalGFactura As Decimal = 0
        Dim TotalVentaNeta As Decimal = 0

        Dim TotalGastosComercial As Decimal = 0
        Dim TotalGastosAlmacen As Decimal = 0
        Dim TotalVentaFinal As Decimal = 0

        Dim STotalkilos As Decimal = 0
        Dim STotalImpVenta As Decimal = 0
        Dim STotalImpEnvases As Decimal = 0

        Dim STotalVenta As Decimal = 0
        Dim STotalGFactura As Decimal = 0
        Dim STotalVentaNeta As Decimal = 0

        Dim STotalGastosComercial As Decimal = 0
        Dim STotalGastosAlmacen As Decimal = 0
        Dim STotalVentaFinal As Decimal = 0

        Dim AuxIdCliente As String = ""
        Dim AuxNombreCliente As String = ""

        Dim bCliResumen As Boolean = False
        Dim bPrimero As Boolean = True

        'Cabecera líneas
        Listado.Cabecera.Linea(Cabecera, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", AnchoHorizontal.ToString, Estilos.Minima)

        For Each row As DataRow In Datos.Rows

            Dim Albaran As Integer = VaInt((row("Albaran").ToString & "").Trim)
            Dim FechaSalida As Date = VaDate((row("FechaSalida").ToString & "").Trim)
            Dim Matricula As String = (row("Matricula").ToString & "").Trim
            Dim Kilos As Decimal = VaDec((row("Kilos").ToString & "").Trim)
            Dim ImporteVen As Decimal = VaDec((row("ImporteVen").ToString & "").Trim)
            Dim ImporteEnv As Decimal = VaDec((row("ImporteEnv").ToString & "").Trim)
            Dim TotalVent As Decimal = VaDec((row("TotalVenta").ToString & "").Trim)
            Dim GastosFac As Decimal = VaDec((row("GastosFac").ToString & "").Trim)
            Dim VentaNeta As Decimal = VaDec((row("VentaNeta").ToString & "").Trim)
            Dim GastosComer As Decimal = VaDec((row("GastosComer").ToString & "").Trim)
            Dim GastosAlm As Decimal = VaDec((row("GastosAlm").ToString & "").Trim)
            Dim VentaFinal As Decimal = VaDec((row("VentaFinal").ToString & "").Trim)
            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
            Dim NombreCliente As String = (row("Cliente").ToString & "").Trim
            If bPrimero = False And AuxIdCliente <> IdCliente Then
                bCliResumen = True
            End If


            ' Escribe Cliente Resumen
            If bCliResumen Then

                texto = VaInt(AuxIdCliente).ToString("00000") & "||"
                texto = texto & AuxNombreCliente & "||"
                texto = texto & Totalkilos.ToString("#,##0") & "||"
                texto = texto & TotalImpVenta.ToString("#,##0.00") & "||"
                texto = texto & TotalImpEnvases.ToString("#,##0.00") & "||"
                texto = texto & TotalVenta.ToString("#,##0.00") & "||"
                texto = texto & TotalGFactura.ToString("#,##0.00") & "||"
                texto = texto & TotalVentaNeta.ToString("#,##0.00") & "||"
                texto = texto & TotalGastosComercial.ToString("#,##0.00") & "||"
                texto = texto & TotalGastosAlmacen.ToString("#,##0.00") & "||"
                texto = texto & TotalVentaFinal.ToString("#,##0.00")

                Listado.Detalle.Linea("", AnchoHorizontal.ToString, Estilos.Reducida)
                Listado.Detalle.Linea(texto, FormatoCli, Estilos.MinimaBold)
                Listado.Detalle.Linea("", AnchoHorizontal.ToString, Estilos.Reducida)
                Listado.Detalle.Linea("", AnchoHorizontal.ToString, Estilos.ReducidaBoldLineaEncima)

                Totalkilos = 0
                TotalImpVenta = 0
                TotalImpEnvases = 0

                TotalVenta = 0
                TotalGFactura = 0
                TotalVentaNeta = 0

                TotalGastosComercial = 0
                TotalGastosAlmacen = 0
                TotalVentaFinal = 0



                bCliResumen = False

            End If


            'Líneas detalle
            texto = Albaran.ToString & "||"
            texto = texto & FechaSalida.ToString("dd/MM/yyyy") & "||"
            texto = texto & Matricula & "||"
            texto = texto & Kilos.ToString("#,##0") & "||"
            texto = texto & ImporteVen.ToString("#,##0.00") & "||"
            texto = texto & ImporteEnv.ToString("#,##0.00") & "||"
            texto = texto & TotalVent.ToString("#,##0.00") & "||"
            texto = texto & GastosFac.ToString("#,##0.00") & "||"
            texto = texto & VentaNeta.ToString("#,##0.00") & "||"
            texto = texto & GastosComer.ToString("#,##0.00") & "||"
            texto = texto & GastosAlm.ToString("#,##0.00") & "||"
            texto = texto & VentaFinal.ToString("#,##0.00")

            Listado.Detalle.Linea(texto, Formato, Estilos.Minima)

            Totalkilos = Totalkilos + Kilos
            TotalImpVenta = TotalImpVenta + ImporteVen
            TotalImpEnvases = TotalImpEnvases + ImporteEnv

            TotalVenta = TotalVenta + TotalVent
            TotalGFactura = TotalGFactura + GastosFac
            TotalVentaNeta = TotalVentaNeta + VentaNeta

            TotalGastosComercial = TotalGastosComercial + GastosComer
            TotalGastosAlmacen = TotalGastosAlmacen + GastosAlm
            TotalVentaFinal = TotalVentaFinal + VentaFinal

            STotalkilos = STotalkilos + Kilos
            STotalImpVenta = STotalImpVenta + ImporteVen
            STotalImpEnvases = STotalImpEnvases + ImporteEnv

            STotalVenta = STotalVenta + TotalVent
            STotalGFactura = STotalGFactura + GastosFac
            STotalVentaNeta = STotalVentaNeta + VentaNeta

            STotalGastosComercial = STotalGastosComercial + GastosComer
            STotalGastosAlmacen = STotalGastosAlmacen + GastosAlm
            STotalVentaFinal = STotalVentaFinal + VentaFinal

            AuxIdCliente = IdCliente
            AuxNombreCliente = NombreCliente
            bPrimero = False

            Application.DoEvents()

        Next

        'Escribe el total del ultimo
        texto = VaInt(AuxIdCliente).ToString("00000") & "||"
        texto = texto & AuxNombreCliente & "||"
        texto = texto & Totalkilos.ToString("#,##0") & "||"
        texto = texto & TotalImpVenta.ToString("#,##0.00") & "||"
        texto = texto & TotalImpEnvases.ToString("#,##0.00") & "||"
        texto = texto & TotalVenta.ToString("#,##0.00") & "||"
        texto = texto & TotalGFactura.ToString("#,##0.00") & "||"
        texto = texto & TotalVentaNeta.ToString("#,##0.00") & "||"
        texto = texto & TotalGastosComercial.ToString("#,##0.00") & "||"
        texto = texto & TotalGastosAlmacen.ToString("#,##0.00") & "||"
        texto = texto & TotalVentaFinal.ToString("#,##0.00")

        Listado.Detalle.Linea("", AnchoHorizontal.ToString, Estilos.Reducida)
        Listado.Detalle.Linea(texto, FormatoCli, Estilos.MinimaBold)


        'Gran total
        texto = "||TOTAL LISTADO" & "||"
        texto = texto & STotalkilos.ToString("#,##0") & "||"
        texto = texto & STotalImpVenta.ToString("#,##0.00") & "||"
        texto = texto & STotalImpEnvases.ToString("#,##0.00") & "||"
        texto = texto & STotalVenta.ToString("#,##0.00") & "||"
        texto = texto & STotalGFactura.ToString("#,##0.00") & "||"
        texto = texto & STotalVentaNeta.ToString("#,##0.00") & "||"
        texto = texto & STotalGastosComercial.ToString("#,##0.00") & "||"
        texto = texto & STotalGastosAlmacen.ToString("#,##0.00") & "||"
        texto = texto & STotalVentaFinal.ToString("#,##0.00")

        Listado.Detalle.Linea("", FormatoCli, Estilos.ReducidaBold)
        Listado.Detalle.Linea(texto, FormatoCli, Estilos.MinimaBoldLineaEncima)


    End Sub


End Class
