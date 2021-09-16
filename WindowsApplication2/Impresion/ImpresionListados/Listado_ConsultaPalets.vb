Public Class Listado_ConsultaPalets
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property FechaDesde As String
    Property FechaHasta As String
    Property PuntosVenta As List(Of String)
    Property Familias As List(Of String)
    Property ImprimirCliente As String
    Property EnExistencias As String
    Property Confeccionadas As String
    Property EnvasePropio As String
    Property MostrarPartidas As Boolean
    Property TipoImpresion As Boolean


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoGenero As String = ""
    Dim FormatoPalet As String = ""
    Dim FormatoPartida As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina


    Public Sub New(ByVal dt As DataTable, ByVal fechaDesde As String, ByVal fechaHasta As String, _
                   ByVal puntosVenta As List(Of String), ByVal familias As List(Of String), _
                   ByVal imprimirCliente As String, ByVal enExistencias As String, _
                   ByVal confeccionadas As String, ByVal envasePropio As String, ByVal mostrarPartidas As Boolean,
                   ByVal TipoImpresion As TipoImpresion)


        Me.Dt = dt
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.PuntosVenta = puntosVenta
        Me.Familias = familias
        Me.ImprimirCliente = imprimirCliente
        Me.EnExistencias = enExistencias
        Me.Confeccionadas = confeccionadas
        Me.EnvasePropio = envasePropio
        Me.MostrarPartidas = mostrarPartidas
        Me.TipoImpresion = TipoImpresion

    End Sub



    Public Overrides Sub ImprimirListado()

        MargenIzq = 13
        Ancho = AnchoPagina - MargenIzq - MargenDer
        EstableceListado(Orientacion.Vertical, TipoImpresion)

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

        Dim listaPuntosVenta As String = MetodosComunesListados.ObtenerListaFiltros(PuntosVenta)
        Dim listaFamilias As String = MetodosComunesListados.ObtenerListaFiltros(Familias)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado de existencias de palets"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Len(FechaDesde) > 0 Or Len(FechaHasta) > 0 Then
            Texto = "Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta & " | "
            Texto = Texto & "Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If Len(listaPuntosVenta) > 0 Then
            Texto = "Punto de Venta: " & listaPuntosVenta
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        If Len(listaFamilias) > 0 Then
            Texto = "Familia: " & listaFamilias
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Texto = ImprimirCliente & "|" & EnExistencias
        Formato = (Ancho - 92).ToString & "|>92"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Texto = Confeccionadas & "|" & EnvasePropio
        Formato = (Ancho - 92).ToString & "|>92"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        If MostrarPartidas Then
            Texto = "Mostrar partidas"
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)
    End Sub

    Private Sub ConfiguraDetalle()

        FormatoGenero = "30|155"
        FormatoPalet = "13|15|15|>13|25|23|19|5|>11|>15|>15|>16"
        FormatoPartida = "11|19|61"

        Texto = "Palet | Fecha | Cat/Cal | Nº | TipoPalet | Envase | Marca | Cal | Dias | Bultos | Kilos |KBrutos"
        Listado.Cabecera.Linea(Texto, FormatoPalet, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Reducida)

        Dim generoConfeccionActual As String = ""
        Dim idPaletActual As String = ""

        Dim TotalBultos As Decimal = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalBrutos As Decimal = 0

        Dim TotalBultosGen As Decimal = 0
        Dim TotalKilosGen As Decimal = 0
        Dim TotalBrutosGen As Decimal = 0
        Dim TotalPaletsGen As Decimal = 0

        Dim TotalBultosPal As Decimal = 0
        Dim TotalKilosPal As Decimal = 0
        Dim TotalBrutosPal As Decimal = 0

        For Each row As DataRow In Dt.Rows

            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim IdConfec As Integer = VaInt(row("IdConfecEnvase"))
            Dim GeneroConfeccion As String = IdGenero.ToString("00000") & IdConfec.ToString("00000")
            Dim IdPalet As String = (row("IdPalet").ToString & "").Trim

            Dim Cal As String = (row("Cal").ToString & "").Trim
            Dim Dias As String = VaInt(row("Dias")).ToString

            Dim Bultos As Decimal = VaDec(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("KilosNetos"))
            Dim Brutos As Decimal = VaDec(row("KgBrutos"))

            If generoConfeccionActual = "" Or generoConfeccionActual <> GeneroConfeccion Then
                'Total por GeneroConfección
                If generoConfeccionActual <> "" Then
                    Dim totGen As String = "||T.Genero:|" & TotalPaletsGen.ToString("#,##0") & "|"
                    totGen = totGen & "|||||" & TotalBultosGen.ToString("#,##0") & "|"
                    totGen = totGen & TotalKilosGen.ToString("#,##0") & "|"
                    totGen = totGen & TotalBrutosGen.ToString("#,##0")
                    Listado.Detalle.Linea(totGen, FormatoPalet, Estilos.ReducidaBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)
                End If

                TotalBultosGen = 0
                TotalKilosGen = 0
                TotalBrutosGen = 0
                TotalPaletsGen = 0
                TotalBultosPal = 0
                TotalKilosPal = 0
                TotalBrutosPal = 0

                Dim ConfecEnvase As String = (row("ConfecEnvase").ToString & "").Trim
                Listado.Detalle.Linea(GeneroConfeccion & "|" & ConfecEnvase, FormatoGenero, Estilos.GrandeBold)

                idPaletActual = ""
            End If

            Dim Palet As String = VaInt(row("Palet")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim TipoPalet As String = (row("ConfecPalet").ToString & "").Trim
            Dim Envase As String = (row("Envase").ToString & "")
            Dim Marca As String = (row("Marca").ToString & "")

            Dim det As String = Palet & "|"
            det = det & Fecha & "|"
            det = det & Categoria & "|"
            If idPaletActual <> IdPalet Then
                det = det & "1" & "|"
            Else
                det = det & "|"
            End If
            det = det & TipoPalet & "|"
            det = det & Envase & "|"
            det = det & Marca & "|"
            det = det & Cal & "|"
            det = det & Dias & "|"
            det = det & Bultos.ToString("#,##0") & "|"
            det = det & Kilos.ToString("#,##0") & "|"
            det = det & Brutos.ToString("#,##0")

            Listado.Detalle.Linea(det, FormatoPalet, Estilos.Reducida)

            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos
            TotalBrutos = TotalBrutos + Brutos
            TotalBultosGen = TotalBultosGen + Bultos
            TotalKilosGen = TotalKilosGen + Kilos
            TotalBrutosGen = TotalBrutosGen + Brutos
            TotalBultosPal = TotalBultosPal + Bultos
            TotalKilosPal = TotalKilosPal + Kilos
            TotalBrutosPal = TotalBrutosPal + Brutos

            If idPaletActual <> IdPalet Then TotalPaletsGen = TotalPaletsGen + 1

            If MostrarPartidas Then
                Dim IdLineaPalet As String = row("IdLinea").ToString & ""

                Dim sql As String = "SELECT 'P' as Tipo, AEL_Muestreo as Numero, AGR_Nombre as Agricultor" & vbCrLf
                sql = sql & " FROM Palets_Traza" & vbCrLf
                sql = sql & " INNER JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLT_IdLineaEntrada" & vbCrLf
                sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
                sql = sql & " LEFT JOIN Agricultores on AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
                sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet
                sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
                sql = sql & " UNION ALL" & vbCrLf
                sql = sql & " SELECT 'L' as Tipo, LTE_Lote as Numero, '' as Agricultor" & vbCrLf
                sql = sql & " FROM Palets_Traza" & vbCrLf
                sql = sql & " INNER JOIN Lotes ON LTE_IdLote = PLT_IdLote" & vbCrLf
                sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet & vbCrLf
                sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
                sql = sql & " UNION ALL" & vbCrLf
                sql = sql & " SELECT 'C' as Tipo, LPD_Lote as Numero, '' as Agricultor" & vbCrLf
                sql = sql & " FROM Palets_Traza" & vbCrLf
                sql = sql & " INNER JOIN LotesProduccion ON LPD_IdLote = PLT_IdPrecalibrado" & vbCrLf
                sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet & vbCrLf
                sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf

                Dim dtPartida As DataTable = cn.ConsultaSQL(sql)
                If Not IsNothing(dtPartida) Then
                    For Each rowPartida As DataRow In dtPartida.Rows
                        Dim Tipo As String = (rowPartida("Tipo").ToString & "").ToUpper.Trim
                        Dim Numero As String = (rowPartida("Numero").ToString & "").Trim
                        Dim Agricultor As String = (rowPartida("Agricultor").ToString & "").Trim

                        Select Case Tipo
                            Case "P"
                                Tipo = "Partida: "
                            Case "L"
                                Tipo = "Lote: "
                            Case "C"
                                Tipo = "P.Semi.: "
                        End Select

                        Listado.Detalle.Linea(Tipo & "|" & Numero & "|" & Agricultor, FormatoPartida, Estilos.Minima)
                    Next
                End If
            End If

            generoConfeccionActual = GeneroConfeccion
            idPaletActual = IdPalet


            Application.DoEvents()

        Next

        'Número de palets diferentes
        Dim TotalPalets As Integer = 0

        Dim DcPalet As New Dictionary(Of Integer, Integer)
        For indice As Integer = 0 To Dt.Rows.Count - 1
            Dim row As DataRow = Dt.Rows(indice)
            If Not IsNothing(row) Then
                Dim IdPalet As Integer = VaInt(row("IdPalet"))
                If Not DcPalet.ContainsKey(IdPalet) Then
                    DcPalet(IdPalet) = IdPalet
                    TotalPalets = TotalPalets + 1
                End If
            End If
        Next

        'Último total por género
        Dim totGen2 As String = "||T.Genero:|" & TotalPaletsGen.ToString("#,##0") & "|"
        totGen2 = totGen2 & "|||||" & TotalBultosGen.ToString("#,##0") & "|"
        totGen2 = totGen2 & TotalKilosGen.ToString("#,##0") & "|"
        totGen2 = totGen2 & TotalBrutosGen.ToString("#,##0")
        Listado.Detalle.Linea(totGen2, FormatoPalet, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)

        'Gran total
        Dim tot As String = "||T.Genero:|" & TotalPalets.ToString("#,##0") & "|"
        tot = tot & "|||||" & TotalBultos.ToString("#,##0") & "|"
        tot = tot & TotalKilos.ToString("#,##0") & "|"
        tot = tot & TotalBrutos.ToString("#,##0")
        Listado.Detalle.Linea(tot, FormatoPalet, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", "200".Trim, Estilos.NormalBold)

    End Sub


End Class
