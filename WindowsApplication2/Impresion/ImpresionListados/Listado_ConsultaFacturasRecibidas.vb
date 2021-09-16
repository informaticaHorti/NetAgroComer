Public Class Listado_ConsultaFacturasRecibidas
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property FechaDesde As String
    Property FechaHasta As String
    Property CtaDesde As String
    Property CtaHasta As String
    Property TipoImpresion As TipoImpresion



    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim Formato2 As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina



    Public Sub New(ByVal dt As DataTable, ByVal fechaDesde As String, ByVal fechaHasta As String, _
                   ByVal ctaDesde As String, ByVal ctaHasta As String, TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.CtaDesde = ctaDesde
        Me.CtaHasta = ctaHasta
        Me.TipoImpresion = TipoImpresion
    End Sub



    Public Overrides Sub ImprimirListado()

        MargenIzq = 5
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
        ConfiguraDetalle()


    End Sub


    Private Sub ConfiguraCabecera()

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado Facturas Recibidas"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        Texto = "Desde fecha " & FechaDesde & " hasta " & FechaHasta
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Texto = "Desde Cta. Prov. " & CtaDesde & " hasta Cta. Prov. " & CtaHasta & " | "
        Texto = Texto & "Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
        Formato = (263 - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        'Detalle
        Formato = "24|5|=21|85|>32|>32|>32|>32"
        Formato2 = "24|24|=21|>32|32"

        Texto = "Factura|CE|Fecha|Proveedor|Base|CuotaIva|Ret|Total"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)
    End Sub

    Private Sub ConfiguraDetalle()
        Dim idFacturaActual As String = ""
        Dim idAlbaranActual As String = ""

        Dim sumaAlbaranes As Decimal = 0
        Dim sumaBases As Decimal = 0
        Dim sumaIva As Decimal = 0
        Dim sumaRet As Decimal = 0
        Dim sumaTotal As Decimal = 0

        For Each r As DataRow In Dt.Rows
            Dim idFactura As String = (r("IdFactura").ToString & "").Trim
            Dim idAlbaran As String = (r("IdAlbaran").ToString & "").Trim

            'Nueva factura
            If Not idFacturaActual.Equals(idFactura) Then
                If Len(idFacturaActual) > 0 Then
                    If VaInt(idAlbaranActual) > 0 Then
                        'Total suma importe albaranes
                        Texto = "|TOTAL ALB.:||"
                        Texto = Texto & sumaAlbaranes.ToString("#,##0.00") & "|"
                        Listado.Detalle.Linea(Texto, Formato2, Estilos.ReducidaBoldLineaEncima)
                    End If

                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)

                    sumaAlbaranes = 0
                End If

                'Nueva factura
                Dim Factura As String = r("Factura").ToString
                Dim CE As String = r("CE").ToString
                Dim Fecha As String = ""
                If VaDate(r("Fecha")) > VaDate("") Then Fecha = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
                Dim Proveedor As String = r("Proveedor").ToString
                Dim Base As Decimal = VaDec(r("Base"))
                Dim CuotaIva As Decimal = VaDec(r("CuotaIva"))
                Dim CuotaRet As Decimal = VaDec(r("CuotaRet"))
                Dim TotalFactura As Decimal = VaDec(r("TotalFactura"))

                Texto = Factura & "|"
                Texto = Texto & CE & "|"
                Texto = Texto & Fecha & "|"
                Texto = Texto & Proveedor & "|"
                Texto = Texto & Base.ToString("#,##0.00") & "|"
                Texto = Texto & CuotaIva.ToString("#,##0.00") & "|"
                Texto = Texto & CuotaRet.ToString("#,##0.00") & "|"
                Texto = Texto & TotalFactura.ToString("#,##0.00")
                Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBold)

                sumaBases = sumaBases + Base
                sumaIva = sumaIva + CuotaIva
                sumaRet = sumaRet + CuotaRet
                sumaTotal = sumaTotal + TotalFactura
            End If

            'Albaranes
            If VaInt(idAlbaran) > 0 Then
                Dim Albaran As String = r("Albaran").ToString
                Dim FechaAlbaran As String = ""
                If VaDate(r("FechaAlbaran")) > VaDate("") Then FechaAlbaran = VaDate(r("FechaAlbaran")).ToString("dd/MM/yyyy")
                Dim Importe As Decimal = VaDec(r("TotalAlb"))
                Dim Referencia As String = r("Referencia").ToString

                Texto = "|Alb. nº: " & Albaran & "|"
                Texto = Texto & FechaAlbaran & "|"
                Texto = Texto & Importe.ToString("#,##0.00") & "|Ref.: "
                Texto = Texto & Referencia
                Listado.Detalle.Linea(Texto, Formato2, Estilos.Reducida)

                sumaAlbaranes = sumaAlbaranes + Importe
            End If

            idFacturaActual = idFactura
            idAlbaranActual = idAlbaran


            Application.DoEvents()
        Next
    End Sub

    
End Class
