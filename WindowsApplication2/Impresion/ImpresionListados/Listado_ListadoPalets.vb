Public Class Listado_ListadoPalets
    Inherits Listado_ImpresionBase


    Property Datos As DataTable
    Property GenDesde As String
    Property GenHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property LstPuntoVenta As List(Of String)
    Property TipoListado As String
    Property Detallado As Boolean
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal datos As DataTable, ByVal genDesde As String, ByVal genHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, _
                   ByVal lstPuntoVenta As List(Of String), ByVal tipoListado As String, _
                   ByVal detallado As Boolean, ByVal TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.GenDesde = genDesde
        Me.GenHasta = genHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.LstPuntoVenta = lstPuntoVenta
        Me.TipoListado = tipoListado
        Me.Detallado = detallado
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"

        MargenSup = 10
        MargenIzq = 10

        Try

            If Detallado Then
                EstableceListado(Orientacion.Horizontal, TipoImpresion)
                ConfigurarListadoDetallado()
            Else
                EstableceListado(Orientacion.Vertical, TipoImpresion)
                ConfigurarListadoResumido()
            End If


            Previsualiza()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ConfigurarListadoResumido()
        Dim PuntoVenta As String = ""

        For Each s As String In LstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next

        If PuntoVenta = "" Then PuntoVenta = "TODOS"



        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("EXISTENCIAS DE PALETS|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.GrandeBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto Venta: " & PuntoVenta & "|Listado Resumido", "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Mostrar palets: " & TipoListado, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        'Dim DLin As String = "66|2|23|2|23|2|>10|>18|>18|>12|>14"
        Dim DLin As String = "48|2|23|2|23|2|>10|>18|>18|>18|>12|>14"
        Dim DLinTotal As String = "100|>10|>18|>18|>18|>26"
        Dim Cabecera As String = "Producto||Cat/Calibre||TipoPalet||Palets|Bultos|Kilos|KBrutos|KxB|Reser."
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "180", Estilos.ReducidaBold)

        Dim TotalPaletsGen As Integer = 0
        Dim TotalBultosGen As Integer = 0
        Dim TotalKilosGen As Decimal = 0
        Dim TotalBrutosGen As Decimal = 0
        Dim TotalReserGen As Integer = 0
        Dim TotalPalets As Integer = 0
        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalBrutos As Decimal = 0
        Dim TotalReser As Integer = 0
        Dim AuxIdGenero As String = ""
        Dim AuxGenero As String = ""

        Dim DcPalets As New Dictionary(Of String, String)

        For Each row As DataRow In Datos.Rows
            Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdPresentacion As String = VaInt(row("IdPresentacion")).ToString
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim IdCategoria As String = VaInt(row("IdCategoria")).ToString
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Palets As Integer = VaInt(row("Palets"))
            'Dim palets As Integer = 0
            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Brutos As Decimal = VaDec(row("KgBrutos"))
            'Dim Reser As Integer = 0
            Dim Reser As Integer = VaInt(row("Reser"))
            Dim TipoPalet As String = row("TipoPalet").ToString
            Dim KxB As String = VaDec(row("KxB")).ToString("#,##0.00")

            Dim bCambioGenero As Boolean = IdGenero <> AuxIdGenero And AuxIdGenero <> ""

            'Cambio de Género
            If bCambioGenero Then
                'Resumen género anterior
                Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                Listado.Detalle.Linea("TOTAL " & AuxGenero & "|" & _
                                      TotalPaletsGen.ToString("#,##0") & "|" & _
                                      TotalBultosGen.ToString("#,##0") & "|" & _
                                      TotalKilosGen.ToString("#,##0") & "|" & _
                                      TotalBrutosGen.ToString("#,##0") & "|" & _
                                      TotalReserGen.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
                Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                TotalPaletsGen = 0
                TotalBultosGen = 0
                TotalKilosGen = 0
                TotalBrutosGen = 0
                TotalReserGen = 0
            End If

            'Líneas de listado
            Dim det As String = Genero & " / " & Presentacion & "||"
            det = det & Categoria & "||"
            det = det & TipoPalet & "||"
            det = det & Palets.ToString("#,##0") & "|"
            det = det & Bultos.ToString("#,##0") & "|"
            det = det & Kilos.ToString("#,##0") & "|"
            det = det & Brutos.ToString("#,##0") & "|"
            det = det & KxB & "|"
            det = det & Reser.ToString("#,##0")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalPaletsGen = TotalPaletsGen + Palets
            TotalBultosGen = TotalBultosGen + Bultos
            TotalKilosGen = TotalKilosGen + Kilos
            TotalBrutosGen = TotalBrutosGen + Brutos
            TotalReserGen = TotalReserGen + Reser

            TotalPalets = TotalPalets + Palets
            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos
            TotalBrutos = TotalBrutos + Brutos
            TotalReser = TotalReser + Reser

            AuxIdGenero = IdGenero
            AuxGenero = Genero


            Application.DoEvents()

        Next

        'Último resumen género
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("TOTAL " & AuxGenero & "|" & _
                              TotalPaletsGen.ToString("#,##0") & "|" & _
                              TotalBultosGen.ToString("#,##0") & "|" & _
                              TotalKilosGen.ToString("#,##0") & "|" & _
                              TotalBrutosGen.ToString("#,##0") & "|" & _
                              TotalReserGen.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

        'Total
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("TOTAL LISTADO|" & _
                              TotalPalets.ToString("#,##0") & "|" & _
                              TotalBultos.ToString("#,##0") & "|" & _
                              TotalKilos.ToString("#,##0") & "|" & _
                              TotalBrutos.ToString("#,##0") & "|" & _
                              TotalReser.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)
    End Sub

    Private Sub ConfigurarListadoDetallado()
        Dim PuntoVenta As String = ""
        For Each s As String In LstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next

        If PuntoVenta = "" Then PuntoVenta = "TODOS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("EXISTENCIAS DE PALETS|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "200|>75", Estilos.GrandeBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "138|>137", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto Venta: " & PuntoVenta & "|Listado Detallado", "138|>137", Estilos.NormalBold)
        Listado.Cabecera.Linea("Mostrar palets: " & TipoListado, "275", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        Dim DLin As String = "15|15|2|18|2|28|2|18|2|22|2|>10|>15|>18|>18|>15|>15|=19|2|40"
        Dim DLinSubTotal As String = "102|24|>10|>15|>18|>18|>30|>71"
        Dim DLinTotal As String = "126|>10|>15|>18|>18|>30|>71"
        Dim Cabecera As String = "N.Palet|Fecha||Cat/Cal||TipoPalet||Envase||Marca||Palets|Bultos|Kilos|KBrutos|KxB|Reser.|FecSal||Cliente"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)

        Dim TotalPaletsCat As Integer = 0
        Dim TotalBultosCat As Integer = 0
        Dim TotalKilosCat As Decimal = 0
        Dim TotalBrutosCat As Decimal = 0
        Dim TotalResCat As Integer = 0

        Dim TotalPaletsPresen As Integer = 0
        Dim TotalBultosPresen As Integer = 0
        Dim TotalKilosPresen As Decimal = 0
        Dim TotalBrutosPresen As Decimal = 0
        Dim TotalResPresen As Integer = 0

        Dim TotalPaletsGen As Integer = 0
        Dim TotalBultosGen As Integer = 0
        Dim TotalKilosGen As Decimal = 0
        Dim TotalBrutosGen As Decimal = 0
        Dim TotalResGen As Integer = 0

        Dim TotalPalets As Integer = 0
        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalBrutos As Decimal = 0
        Dim TotalRes As Integer = 0

        Dim AuxIdGenero As String = ""
        Dim AuxGenero As String = ""
        Dim AuxIdPresentacion As String = ""
        Dim AuxPresentacion As String = ""
        Dim AuxIdCategoria As String = ""
        Dim AuxCategoria As String = ""

        Dim DcPalets As New Dictionary(Of String, String)

        For Each row As DataRow In Datos.Rows
            Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdPresentacion As String = VaInt(row("IdPresentacion")).ToString
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim IdCategoria As String = VaInt(row("IdCategoria")).ToString
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim IdPalet As String = (row("IdPalet").ToString & "").Trim

            Dim Palets As Integer = 0
            If Not DcPalets.ContainsKey(IdPalet) Then
                Palets = 1
                DcPalets(IdPalet) = IdPalet
            End If
            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Brutos As Decimal = VaDec(row("KgBrutos"))
            Dim PRes As Integer = VaInt(row("PRes"))

            Dim NumPalet As String = VaInt(row("NumPalet")).ToString("0000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim TipoPalet As String = row("TipoPalet").ToString
            Dim Envase As String = row("Envase").ToString
            Dim Marca As String = row("Marca").ToString
            Dim KxB As String = VaDec(row("KxB")).ToString("#,##0.00")
            Dim FechaSal As String = ""
            If VaDate(row("FechaSal")) > VaDate("") Then FechaSal = VaDate(row("FechaSal")).ToString("dd/MM/yyyy")
            Dim Cliente As String = row("Cliente").ToString

            Dim bCambioGenero As Boolean = IdGenero <> AuxIdGenero And AuxIdGenero <> ""
            Dim bCambioPresentacion As Boolean = IdPresentacion <> AuxIdPresentacion And AuxIdPresentacion <> ""
            Dim bCambioCategoria As Boolean = IdCategoria <> AuxIdCategoria And AuxIdCategoria <> ""

            bCambioPresentacion = bCambioPresentacion Or bCambioGenero
            bCambioCategoria = bCambioCategoria Or bCambioPresentacion Or bCambioGenero

            'Cambio de categoría
            If bCambioCategoria Then
                'Resumen categoría anterior
                Listado.Detalle.Linea("|T. Cat/Cal" & "|" & _
                                      TotalPaletsCat.ToString("#,##0") & "|" & _
                                      TotalBultosCat.ToString("#,##0") & "|" & _
                                      TotalKilosCat.ToString("#,##0") & "|" & _
                                      TotalBrutosCat.ToString("#,##0") & "|" & _
                                      TotalResCat.ToString("#,##0") & "|", DLinSubTotal, Estilos.Reducida)

                TotalPaletsCat = 0
                TotalBultosCat = 0
                TotalKilosCat = 0
                TotalBrutosCat = 0
                TotalResCat = 0
            End If

            'Cambio de presentación
            If bCambioPresentacion Then
                'Resumen presentación anterior
                Listado.Detalle.Linea("|T. Presen." & "|" & _
                                      TotalPaletsPresen.ToString("#,##0") & "|" & _
                                      TotalBultosPresen.ToString("#,##0") & "|" & _
                                      TotalKilosPresen.ToString("#,##0") & "|" & _
                                      TotalBrutosPresen.ToString("#,##0") & "|" & _
                                      TotalResPresen.ToString("#,##0") & "|", DLinSubTotal, Estilos.ReducidaBold)
                Listado.Detalle.Linea("", "180", Estilos.ReducidaBold)

                TotalPaletsCat = 0
                TotalBultosCat = 0
                TotalKilosCat = 0
                TotalBrutosCat = 0
                TotalResCat = 0

                TotalPaletsPresen = 0
                TotalBultosPresen = 0
                TotalKilosPresen = 0
                TotalBrutosPresen = 0
                TotalResPresen = 0
            End If

            'Cambio de Género
            If bCambioGenero Then
                'Resumen género anterior
                Listado.Detalle.Linea("", "275", Estilos.ReducidaBoldLineaDebajo)
                Listado.Detalle.Linea("TOTAL " & AuxGenero & "|" & _
                                      TotalPaletsGen.ToString("#,##0") & "|" & _
                                      TotalBultosGen.ToString("#,##0") & "|" & _
                                      TotalKilosGen.ToString("#,##0") & "|" & _
                                      TotalBrutosGen.ToString("#,##0") & "|" & _
                                      TotalResGen.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
                Listado.Detalle.Linea("", "180", Estilos.ReducidaBold)

                TotalPaletsCat = 0
                TotalBultosCat = 0
                TotalKilosCat = 0
                TotalBrutosCat = 0
                TotalResCat = 0

                TotalPaletsPresen = 0
                TotalBultosPresen = 0
                TotalKilosPresen = 0
                TotalBrutosPresen = 0
                TotalResPresen = 0

                TotalPaletsGen = 0
                TotalBultosGen = 0
                TotalKilosGen = 0
                TotalBrutosGen = 0
                TotalResGen = 0
            End If

            'Nueva presentación
            If IdPresentacion <> AuxIdPresentacion Or AuxIdPresentacion = "" Then
                Listado.Detalle.Linea("", "180", Estilos.NormalBold)
                Listado.Detalle.Linea(Genero & " / " & Presentacion, "275", Estilos.NormalBold)
            End If
            'Líneas de listado
            Dim det As String = NumPalet & "|"
            det = det & Fecha & "||"
            det = det & Categoria & "||"
            det = det & TipoPalet & "||"
            det = det & Envase & "||"
            det = det & Marca & "||"
            det = det & Palets.ToString("#,##0") & "|"
            det = det & Bultos.ToString("#,##0") & "|"
            det = det & Kilos.ToString("#,##0") & "|"
            det = det & Brutos.ToString("#,##0") & "|"
            det = det & KxB & "|"
            det = det & PRes.ToString("#,##0") & "|"
            det = det & FechaSal & "||"
            det = det & Cliente
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalPaletsCat = TotalPaletsCat + Palets
            TotalBultosCat = TotalBultosCat + Bultos
            TotalKilosCat = TotalKilosCat + Kilos
            TotalBrutosCat = TotalBrutosCat + Brutos
            TotalResCat = TotalResCat + PRes

            TotalPaletsPresen = TotalPaletsPresen + Palets
            TotalBultosPresen = TotalBultosPresen + Bultos
            TotalKilosPresen = TotalKilosPresen + Kilos
            TotalBrutosPresen = TotalBrutosPresen + Brutos
            TotalResPresen = TotalResPresen + PRes

            TotalPaletsGen = TotalPaletsGen + Palets
            TotalBultosGen = TotalBultosGen + Bultos
            TotalKilosGen = TotalKilosGen + Kilos
            TotalBrutosGen = TotalBrutosGen + Brutos
            TotalResGen = TotalResGen + PRes

            TotalPalets = TotalPalets + Palets
            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos
            TotalBrutos = TotalBrutos + Brutos
            TotalRes = TotalRes + PRes

            AuxIdGenero = IdGenero
            AuxGenero = Genero
            AuxIdPresentacion = IdPresentacion
            AuxPresentacion = Presentacion
            AuxIdCategoria = IdCategoria
            AuxCategoria = Categoria


            Application.DoEvents()

        Next

        'Ùltimo resumen categoría
        Listado.Detalle.Linea("|T. Cat/Cal" & "|" & _
                              TotalPaletsCat.ToString("#,##0") & "|" & _
                              TotalBultosCat.ToString("#,##0") & "|" & _
                              TotalKilosCat.ToString("#,##0") & "|" & _
                              TotalBrutosCat.ToString("#,##0") & "|" & _
                              TotalResCat.ToString("#,##0") & "|", DLinSubTotal, Estilos.Reducida)

        'Último resumen presentación
        Listado.Detalle.Linea("|T. Presen." & "|" & _
                                      TotalPaletsPresen.ToString("#,##0") & "|" & _
                                      TotalBultosPresen.ToString("#,##0") & "|" & _
                                      TotalKilosPresen.ToString("#,##0") & "|" & _
                                      TotalBrutosPresen.ToString("#,##0") & "|" & _
                                      TotalResPresen.ToString("#,##0") & "|", DLinSubTotal, Estilos.ReducidaBold)

        'Último resumen género
        Listado.Detalle.Linea("", "275", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("TOTAL " & AuxGenero & "|" & _
                              TotalPaletsGen.ToString("#,##0") & "|" & _
                              TotalBultosGen.ToString("#,##0") & "|" & _
                              TotalKilosGen.ToString("#,##0") & "|" & _
                              TotalBrutosGen.ToString("#,##0") & "|" & _
                              TotalResGen.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
        Listado.Detalle.Linea("", "180", Estilos.ReducidaBold)

        'Total
        Listado.Detalle.Linea("", "275", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("TOTAL LISTADO|" & _
                              TotalPalets.ToString("#,##0") & "|" & _
                              TotalBultos.ToString("#,##0") & "|" & _
                              TotalKilos.ToString("#,##0") & "|" & _
                              TotalBrutos.ToString("#,##0") & "|" & _
                              TotalRes.ToString("#,##0") & "|", DLinTotal, Estilos.NormalBoldLineaDebajo)
        Listado.Detalle.Linea("", "180", Estilos.ReducidaBold)
    End Sub


    
End Class
