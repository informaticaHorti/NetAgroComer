Public Class Listado_IvaRepercutido
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property Detallado As Boolean
    Property Iva As Decimal
    Property FechaDesde As String
    Property FechaHasta As String
    Property SerieDesde As String
    Property SerieHasta As String
    Property TipoCliente As String
    Property PuntosVenta As List(Of String)
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina


    Public Sub New(ByVal dt As DataTable, detallado As Boolean, ByVal iva As Decimal, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal serieDesde As String, _
                   ByVal serieHasta As String, ByVal tipoCliente As String, puntosVenta As List(Of String), ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.Detallado = detallado
        Me.Iva = iva
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.SerieDesde = serieDesde
        Me.SerieHasta = serieHasta
        Me.TipoCliente = tipoCliente
        Me.PuntosVenta = puntosVenta
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 5
        EstableceListado(Orientacion.Horizontal)
        Ancho = AnchoPagina - MargenDer - MargenIzq

        Try

            ConfiguraListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub ConfiguraListado()
        
        ConfiguraCabecera()
        ConfiguraDetalle()

    End Sub

    Private Sub ConfiguraCabecera()

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "LISTADO IVA REPERCUTIDO"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Not Iva = 0 Then
            Texto = "Tipo de IVA: " & Iva.ToString("#,##0.00") & " %"
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        If Len(FechaDesde.Trim) > 0 Or Len(FechaHasta.Trim) > 0 Then
            Texto = "Desde " & FechaDesde & " hasta " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If Len(SerieDesde.Trim) > 0 Or Len(SerieHasta.Trim) > 0 Then
            Texto = "Desde serie " & SerieDesde & " hasta serie " & SerieHasta
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Dim cadenaCliente As String = "Todos"
        Texto = "Clientes: "
        Select Case TipoCliente
            Case "N"
                cadenaCliente = "Nacionales"
            Case "C"
                cadenaCliente = "Comunitarios"
            Case "NC"
                cadenaCliente = "No comunitarios"
        End Select
        Texto = Texto & cadenaCliente
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Dim listaPuntosVenta As String = MetodosComunesListados.ObtenerListaFiltros(PuntosVenta)
        If Len(listaPuntosVenta.Trim) > 0 Then
            Texto = "Punto Venta: " & listaPuntosVenta
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Texto = "Detallar Facturas: "
        If Detallado Then
            Texto = Texto & "SI"
        Else
            Texto = Texto & "NO"
        End If
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        Texto = "Nº.FACT. | CE | FECHA | COD | CLIENTE | NIF | BASE IMP. | % IVA | CUOTA IVA | % R.E. | CUOTA R.EQ. | T.FACTURA"
        Formato = "22|=15|24|15|50|24|>24|>15|>22|>15|>24|>30"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Reducida)
    End Sub

    Private Sub ConfiguraDetalle()
        If Detallado Then
            Dim dtResumen As DataTable = ImprimirDetallado(Dt)

            Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)

            ImprimirResumido(dtResumen)
        Else
            ImprimirResumido(Dt)
        End If
    End Sub

    Private Function ImprimirDetallado(ByVal dt As DataTable) As DataTable
        Dim acum As New Acumulador

        Dim listaCampos As New List(Of String)
        listaCampos.Add("base")
        listaCampos.Add("iva")
        listaCampos.Add("recargo")
        listaCampos.Add("factura")

        Dim acumTotales As New AcumuladorTotales(listaCampos)

        For Each r As DataRow In dt.Rows
            Dim Factura As String = (r("Factura").ToString & "").Trim
            Dim IdCentro As String = (r("IdCentro").ToString & "").Trim
            Dim Fecha As String = ""
            If VaDate(r("Fecha")) <> VaDate("") Then Fecha = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
            Dim IdCliente As String = (r("IdCliente").ToString & "").Trim
            Dim Cliente As String = (r("Cliente").ToString & "").Trim
            Dim NIF As String = (r("NIF").ToString & "").Trim
            Dim Base As Decimal = VaDec(r("Base"))
            Dim Iva As Decimal = VaDec(r("Iva"))
            Dim CuotaIva As Decimal = VaDec(r("CuotaIva"))
            Dim Ret As Decimal = VaDec(r("Re"))
            Dim CuotaRe As Decimal = VaDec(r("CuotaRe"))
            Dim TotalFactura As Decimal = VaDec(r("TotalFactura"))

            Dim listaValores As New List(Of Decimal)
            listaValores.Add(Base)
            listaValores.Add(CuotaIva)
            listaValores.Add(CuotaRe)
            listaValores.Add(TotalFactura)

            acumTotales.Suma(listaValores)

            Dim stClave As New stClaves_IvaRepercutido(Iva)
            Dim stDatos As New stDatos_IvaRepercutido(Base, CuotaIva)
            acum.Suma(stClave, stDatos)

            Texto = Factura & "|"
            Texto = Texto & IdCentro & "|"
            Texto = Texto & Fecha & "|"
            Texto = Texto & VaInt(IdCliente).ToString("00000") & "|"
            Texto = Texto & Cliente & "|"
            Texto = Texto & NIF & "|"
            Texto = Texto & VaDec(r("Base")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("Iva")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("CuotaIva")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("Re")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("CuotaRe")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("TotalFactura")).ToString("#,##0.00")
            Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)


            Application.DoEvents()

        Next

        Texto = "||||TOTAL LISTADO||"
        Texto = Texto & acumTotales.GetValor("base").ToString("#,##0.00") & "||"
        Texto = Texto & acumTotales.GetValor("iva").ToString("#,##0.00") & "||"
        Texto = Texto & acumTotales.GetValor("recargo").ToString("#,##0.00") & "|"
        Texto = Texto & acumTotales.GetValor("factura").ToString("#,##0.00")
        Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)

        Return acum.DataTable
    End Function

    Private Sub ImprimirResumido(dt As DataTable)
        Dim dv As New DataView(dt)
        dv.Sort = "Iva"
        dt = dv.ToTable

        For Each r As DataRow In dt.Rows
            Dim base As Decimal = VaDec(r("Base"))
            Dim iva As Decimal = VaDec(r("Iva"))
            Dim cuotaIva As Decimal = VaDec(r("CuotaIva"))

            Texto = "||||Base Imponible|%|Cuota|||||"
            Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBold)

            Texto = "||||"
            Texto = Texto & VaDec(r("Base")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("Iva")).ToString("#,##0.00") & "|"
            Texto = Texto & VaDec(r("CuotaIva")).ToString("#,##0.00") & "|||||"
            Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)

            Application.DoEvents()

        Next
    End Sub


    Private Class stClaves_IvaRepercutido
        Public Iva As Decimal = 0

        Public Sub New(Iva As Decimal)
            Me.Iva = Iva
        End Sub
    End Class

    Public Class stDatos_IvaRepercutido
        Public Base As Decimal = 0
        Public CuotaIva As Decimal = 0
        Public Sub New(Base As Decimal, CuotaIva As Decimal)
            Me.Base = Base
            Me.CuotaIva = CuotaIva
        End Sub
    End Class

    
End Class
