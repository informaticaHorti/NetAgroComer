Public Class Listado_InformeSaldosEnvasesPorCentro
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property EnvDesde As String
    Property EnvHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property PuntosVenta As List(Of String)
    Property Detallado As Boolean
    Property Familias As List(Of String)
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 210
    Dim Ancho As Integer = AnchoPagina
    Dim ListaPuntosVenta As String = ""
    Dim ListaFamilias As String = ""


    Public Sub New(ByVal dt As DataTable, ByVal envDesde As String, ByVal envHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal puntosVenta As List(Of String), _
                   ByVal detallado As Boolean, ByVal familias As List(Of String), ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.EnvDesde = envDesde
        Me.EnvHasta = envHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.PuntosVenta = puntosVenta
        Me.Detallado = detallado
        Me.Familias = familias
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 13
        EstableceListado(Orientacion.Vertical, TipoImpresion)
        Ancho = AnchoPagina - MargenIzq - MargenDer

        Try

            ConfiguraCabecera()

            If Detallado Then
                ConfiguraDetalleDetallado()
            Else
                ConfiguraDetalleResumido()
            End If

            Previsualiza()

        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub ConfiguraCabecera()
        

        ListaPuntosVenta = MetodosComunesListados.ObtenerListaFiltros(PuntosVenta)
        ListaFamilias = MetodosComunesListados.ObtenerListaFiltros(Familias)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Saldo de envases por centro resumido"
        If Detallado Then Texto = "Saldo de envases por centro detallado"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        FormatoFiltro(EnvDesde, 3, LimiteFiltro.Inferior)
        FormatoFiltro(EnvHasta, 3, LimiteFiltro.Superior)

        Texto = "Desde Envase " & EnvDesde & " hasta Envase " & EnvHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
        Formato = (Ancho - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        If FechaDesde <> "" Or FechaHasta <> "" Then
            Texto = "Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        If ListaPuntosVenta <> "" Then
            Texto = "Punto de Venta: " & ListaPuntosVenta
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        If ListaFamilias <> "" Then
            Texto = "Familias envases: " & ListaFamilias
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)
    End Sub

    Private Sub ConfiguraDetalleDetallado()

        'Formato = "19|20|74|30|>21|>21"
        Formato = "19|20|32|42|30|>21|>21"

        Texto = "Num.Vale | Fecha | TipoOp | Concepto | Referencia | Entrega | Retira"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)

        Dim TotalEntrega As Decimal = 0
        Dim TotalRetira As Decimal = 0
        Dim TotalAlmEntrega As Decimal = 0
        Dim TotalAlmRetira As Decimal = 0
        Dim TotalEnvEntrega As Decimal = 0
        Dim TotalEnvRetira As Decimal = 0

        Dim AuxIdAlmacen As String = ""
        Dim AuxIdEnvase As String = ""

        For Each row As DataRow In Dt.Rows

            Dim IdAlmacen As String = (row("IdAlmacen").ToString & "").Trim
            Dim Almacen As String = row("Almacen").ToString & ""
            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
            Dim Envase As String = row("Envase").ToString & ""

            Dim NumVale As String = row("NumVale").ToString & ""
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim TipoOperacion As String = (row("TipoOperacion").ToString & "").Trim
            Dim Concepto As String = row("Concepto").ToString & ""
            Dim Referencia As String = row("Referencia").ToString & ""
            Dim Entrega As Decimal = VaDec(row("Entrega"))
            Dim Retira As Decimal = VaDec(row("Retira"))

            'Cambio de almacén
            If AuxIdAlmacen <> IdAlmacen Then
                If AuxIdAlmacen <> "" Then
                    'Total por envase
                    Dim totalenv As String = "||TOTAL ENV.|||"
                    totalenv = totalenv & TotalEnvEntrega.ToString("#,##0.00") & "|"
                    totalenv = totalenv & TotalEnvRetira.ToString("#,##0.00")
                    Listado.Detalle.Linea(totalenv, Formato, Estilos.ReducidaBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                    TotalEnvEntrega = 0
                    TotalEnvRetira = 0

                    'Total por almacén
                    Dim totalalm As String = "||TOTAL ALM.|||"
                    totalalm = totalalm & TotalAlmEntrega.ToString("#,##0.00") & "|"
                    totalalm = totalalm & TotalAlmRetira.ToString("#,##0.00")
                    Listado.Detalle.Linea(totalalm, Formato, Estilos.ReducidaBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                    TotalAlmEntrega = 0
                    TotalAlmRetira = 0
                End If

                'Línea de almacén
                Listado.Detalle.Linea(Almacen, Ancho.ToString, Estilos.NormalBoldLineaDebajo)
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                'Linea de envase
                Listado.Detalle.Linea(Envase, Ancho.ToString, Estilos.NormalBold)
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
            Else
                'Cambio de envase
                If (AuxIdEnvase <> IdEnvase) Then
                    If AuxIdEnvase <> "" Then
                        'Total por envase
                        Dim totalenv As String = "||TOTAL ENV.|||"
                        totalenv = totalenv & TotalEnvEntrega.ToString("#,##0.00") & "|"
                        totalenv = totalenv & TotalEnvRetira.ToString("#,##0.00")
                        Listado.Detalle.Linea(totalenv, Formato, Estilos.ReducidaBoldLineaEncima)
                        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                        TotalEnvEntrega = 0
                        TotalEnvRetira = 0
                    End If

                    'Linea de envase
                    Listado.Detalle.Linea(Envase, Ancho.ToString, Estilos.NormalBold)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
                End If
            End If

            Dim det As String = NumVale & "|"
            det = det & Fecha & "|"
            det = det & TipoOperacion & "|"
            det = det & Concepto & "|"
            det = det & Referencia & "|"
            det = det & Entrega.ToString("#,##0.00") & "|"
            det = det & Retira.ToString("#,##0.00")
            Listado.Detalle.Linea(det, Formato, Estilos.Reducida)

            TotalEntrega = TotalEntrega + Entrega
            TotalRetira = TotalRetira + Retira
            TotalAlmEntrega = TotalAlmEntrega + Entrega
            TotalAlmRetira = TotalAlmRetira + Retira
            TotalEnvEntrega = TotalEnvEntrega + Entrega
            TotalEnvRetira = TotalEnvRetira + Retira

            AuxIdAlmacen = IdAlmacen
            AuxIdEnvase = IdEnvase


            Application.DoEvents()

        Next

        'Último total envases
        Dim totalenv2 As String = "||TOTAL ENV.|||"
        totalenv2 = totalenv2 & TotalEnvEntrega.ToString("#,##0.00") & "|"
        totalenv2 = totalenv2 & TotalEnvRetira.ToString("#,##0.00")
        Listado.Detalle.Linea(totalenv2, Formato, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

        'Ultimo total almacén
        Dim totalalm2 As String = "||TOTAL ALM.|||"
        totalalm2 = totalalm2 & TotalAlmEntrega.ToString("#,##0.00") & "|"
        totalalm2 = totalalm2 & TotalAlmRetira.ToString("#,##0.00")
        Listado.Detalle.Linea(totalalm2, Formato, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

        'Total
        Dim total As String = "||TOTAL|||"
        total = total & TotalEntrega.ToString("#,##0.00") & "|"
        total = total & TotalRetira.ToString("#,##0.00")

        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
        Listado.Detalle.Linea(total, Formato, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfiguraDetalleResumido()
        Formato = "19|102|>32|>32"
        Texto = "Codigo | Envase | Saldo Inicial | Saldo Final"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)

        Dim TotalIni As Decimal = 0
        Dim TotalFin As Decimal = 0
        Dim TotalAlmIni As Decimal = 0
        Dim TotalAlmFin As Decimal = 0

        Dim AuxIdAlmacen As String = ""

        For Each row As DataRow In Dt.Rows

            Dim IdAlmacen As String = (row("IdAlmacen").ToString & "").Trim
            Dim Almacen As String = row("Almacen").ToString & ""
            Dim Codigo As String = VaInt(row("IdEnvase")).ToString("00000")
            Dim Envase As String = row("Envase").ToString & ""
            Dim SaldoIni As Decimal = VaDec(row("SaldoIni"))
            Dim SaldoFin As Decimal = VaDec(row("SaldoFin"))

            If AuxIdAlmacen <> IdAlmacen Then
                If AuxIdAlmacen <> "" Then
                    'Total por almacén
                    Dim totalalm As String = "|TOTAL ALM.|"
                    totalalm = totalalm & TotalAlmIni.ToString("#,##0.00") & "|"
                    totalalm = totalalm & TotalAlmFin.ToString("#,##0.00")
                    Listado.Detalle.Linea(totalalm, Formato, Estilos.NormalBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                    TotalAlmIni = 0
                    TotalAlmFin = 0
                End If

                'Línea de almacén
                Listado.Detalle.Linea(Almacen, Ancho.ToString, Estilos.GrandeBold)
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
            End If

            Dim det As String = Codigo & "|"
            det = det & Envase & "|"
            det = det & SaldoIni.ToString("#,##0.00") & "|"
            det = det & SaldoFin.ToString("#,##0.00")
            Listado.Detalle.Linea(det, Formato, Estilos.Normal)

            TotalIni = TotalIni + SaldoIni
            TotalFin = TotalFin + SaldoFin
            TotalAlmIni = TotalAlmIni + SaldoIni
            TotalAlmFin = TotalAlmFin + SaldoFin

            AuxIdAlmacen = IdAlmacen


            Application.DoEvents()

        Next

        'Último total
        Dim totalalm2 As String = "|TOTAL ALM.|"
        totalalm2 = totalalm2 & TotalAlmIni.ToString("#,##0.00") & "|"
        totalalm2 = totalalm2 & TotalAlmFin.ToString("#,##0.00")
        Listado.Detalle.Linea(totalalm2, Formato, Estilos.NormalBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

        'Total
        Dim total As String = "|TOTAL|"
        total = total & TotalIni.ToString("#,##0.00") & "|"
        total = total & TotalFin.ToString("#,##0.00")

        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
        Listado.Detalle.Linea(total, Formato, Estilos.NormalBoldLineaEncima)
    End Sub

    
End Class
