Imports System.Drawing
Imports System.Drawing.Printing


Module C1_TicketPalet


    Private margen_izquierdo As Integer = 4
    Dim ancho_linea As Decimal = 2



    Public Sub C1_ImprimirTicketPalet(ByVal IdPalet As String, TipoImpresion As TipoImpresion,
                                      Optional Impresora As String = "",
                                      Optional rutaPDF As String = "",
                                      Optional archivoPDF As String = "")




        Dim Palet As New E_palets(Idusuario, cn)

        If Palet.LeerId(IdPalet) Then


            Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_PALETS, MiMaletin.IdPuntoVenta)


            Dim Impreso As New Impreso
            'Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            If papel = "A5" Then
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
            Else
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
            End If
            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

            Impreso.EstableceImpreso(TipoImpresion)


            Dim altura As Integer = 12


            Try

                'Cabecera
                ImprimeCabeceraTicketPalet(Palet, altura, Impreso)

                'Líneas Palet
                Dim NumLineas As Integer = 0
                Dim Controlado As Boolean = False

                ImprimeDetalleTicketPalet(IdPalet, Palet, altura, Impreso, NumLineas, Controlado)

                'Controlado o no
                If NumLineas > 1 Then
                    ImprimePaletControlado(Impreso, altura, Controlado)
                End If



                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then
                    Impresora = valoresusuario.VUS_ImpresoraPalets.Valor
                End If


                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

            Catch ex As Exception

            End Try


        Else
            MsgBox("Error al imprimir el palet con Id: " & IdPalet)
        End If


    End Sub


    Private Sub ImprimeCabeceraTicketPalet(Palet As E_palets, ByRef altura As Integer, ByRef Impreso As Impreso)

        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)


        'Obtenemos los datos
        Dim Campa As String = VaInt(Palet.PAL_campa.Valor).ToString("00")
        Dim NumPalet As String = VaInt(Palet.PAL_palet.Valor).ToString("000000")
        Dim TipoPalet As String = ""
        Dim Fecha As String = ""
        If VaDate(Palet.PAL_fecha.Valor) > VaDate("") Then Fecha = VaDate(Palet.PAL_fecha.Valor).ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")
        Dim Bultos As String = "0"


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Palet.PAL_palet, "Palet")
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", Palet.PAL_idtipopalet, ConfecPalet.CPA_Idconfec)
        Dim oBultos As New Cdatos.bdcampo("@(SELECT SUM(PLL_Bultos) FROM Palets_Lineas WHERE PLL_IdPalet = PAL_IdPalet)", Cdatos.TiposCampo.Importe, 18)
        CONSULTA.SelCampo(oBultos, "Bultos")
        CONSULTA.WheCampo(Palet.PAL_idpalet, "=", Palet.PAL_idpalet.Valor)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        Dim dt As DataTable = Palet.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                TipoPalet = (dt.Rows(0)("TipoPalet").ToString & "").Trim
                Bultos = VaInt(dt.Rows(0)("Bultos")).ToString("#,##0")
            End If
        End If



        If Palet.PAL_finalizado.Valor = "N" Then
            Impreso.Detalle.Titulo("SIN TERMINAR", margen_izquierdo, 9, 200, 20, Estilos.GrandeBold, ">")
        Else

            'Codigo de barras
            Dim Code39 As New Font("C39HrP24DhTt", 45)
            Dim CodBar As String = "*" & "TP" & Campa & "." & Palet.PAL_palet.Valor & "*"
            Impreso.Detalle.Titulo(CodBar, margen_izquierdo, 9, 200, 20, Estilos.Custom, ">", , Code39)

        End If


        'Cabecera
        Impreso.Detalle.Titulo("PALET N:", margen_izquierdo, altura, 15, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(NumPalet & "  " & TipoPalet, margen_izquierdo + 15, altura - 2, 150, 7, Estilos.Cabecera)
        altura = altura + 7
        Impreso.Detalle.Titulo("FECHA: ", margen_izquierdo, altura, 15, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Fecha, margen_izquierdo + 15, altura - 2, 40, 7, Estilos.Cabecera)
        Impreso.Detalle.Titulo("HORA: ", margen_izquierdo + 15 + 40, altura, 15, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Hora, margen_izquierdo + 15 + 35 + 18, altura - 2, 30, 7, Estilos.Cabecera)
        Impreso.Detalle.Titulo("TOTAL BULTOS: ", margen_izquierdo + 15 + 75, altura, 25, 6, Estilos.Normal)
        Impreso.Detalle.Titulo(Bultos, margen_izquierdo + 15 + 75 + 30, altura - 2, 30, 7, Estilos.Cabecera)
        altura = altura + 8


    End Sub


    Private Sub ImprimeDetalleTicketPalet(IdPalet As String, Palet As E_palets, ByRef altura As Integer, ByRef Impreso As Impreso, ByRef NumLineas As Integer, ByRef Controlado As Boolean)


        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)

        NumLineas = 0
        Controlado = True


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Palets_Lineas.PLL_idlinea, "IdLinea")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgensal, "IdPresentacion")
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Palets_Lineas.PLL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca, Marcas.MAR_Idmarca)
        CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria, CategoriasSalida.CAS_Id)
        CONSULTA.SelCampo(Pedidos_Lineas.PEL_idpedido, "IdPedido", Palets_Lineas.PLL_idpedidolinea, Pedidos_Lineas.PEL_idlinea)
        CONSULTA.SelCampo(Pedidos.PED_pedido, "Pedido", Pedidos_Lineas.PEL_idpedido, Pedidos.PED_idpedido)
        CONSULTA.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_piezasxbulto, "PxB")
        CONSULTA.SelCampo(Palets_Lineas.PLL_kilosbrutos, "KilosBrutos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_kilosnetos, "KilosNetos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_Controlado, "Controlado")
        CONSULTA.WheCampo(Palets_Lineas.PLL_idpalet, "=", IdPalet)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " ORDER BY PLL_IdLinea" & vbCrLf


        Dim linea As Integer = 0


        Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            NumLineas = dt.Rows.Count


            For Each row As DataRow In dt.Rows

                ImprimeLineaPalet(Palet.PAL_finalizado.Valor, row, altura, Impreso)
                linea = linea + 1

                If linea > 3 Then

                    Impreso.Detalle.LineaH(margen_izquierdo, altura, 200, ancho_linea)
                    Impreso.Detalle.Titulo("(SIGUE)", margen_izquierdo, 143, 180, 4, Estilos.Normal, ">")
                    Impreso.Detalle.SaltoPagina()
                    linea = 1

                    altura = 20
                    ImprimeCabeceraTicketPalet(Palet, altura, Impreso)

                End If

                Dim LineaControlada As String = (row("Controlado").ToString & "").Trim.ToUpper
                If LineaControlada <> "S" Then
                    Controlado = False
                End If


                Application.DoEvents()

            Next

            Impreso.Detalle.LineaH(margen_izquierdo, altura, 200, ancho_linea)

            altura = altura + 2

        End If





    End Sub


    Private Sub ImprimeLineaPalet(Terminado As String, row As DataRow, ByRef altura As Integer, ByRef Impreso As Impreso)


        'Obtener datos
        Dim IdLineaPalet As String = (row("IdLinea").ToString & "").Trim
        Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
        Dim ConfecEnvase As String = (row("Confeccion").ToString & "").Trim
        Dim Marca As String = (row("Marca").ToString & "").Trim
        Dim Categoria As String = (row("Categoria").ToString & "").Trim
        Dim Pedido As String = (row("Pedido").ToString & "").Trim
        Dim Bultos As Integer = VaInt(row("Bultos"))
        Dim PxB As Integer = VaInt(row("PxB"))
        Dim Piezas As Decimal = Bultos * PxB
        Dim KilosBrutos As String = VaInt(row("KilosBrutos")).ToString("#,##0")
        Dim KilosNetos As String = VaInt(row("KilosNetos")).ToString("#,##0")
        Dim Controlado As String = (row("Controlado").ToString & "").ToUpper.Trim
        If Controlado = "S" Then
            Controlado = "CONTROLADO"
        Else
            Controlado = "NO CONTROLADO"
        End If
        Dim Trazabilidad As String = TrazabilidadPalet(IdLineaPalet)



        Dim Col As New List(Of Integer)
        Col.Add(0)
        Col.Add(margen_izquierdo)
        Col.Add(Col(1) + 135)
        Col.Add(Col(1) + 135 + 25)


        'Imprime línea
        Impreso.Detalle.LineaH(Col(1), altura, 200, ancho_linea)
        altura = altura + 2
        Impreso.Detalle.Titulo("PRODUCTO: ", Col(1), altura, 19, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Presentacion, Col(1) + 20, altura - 2, 100, 7, Estilos.Cabecera)
        Impreso.Detalle.Titulo("CATEGORIA: ", Col(2), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Categoria, Col(2) + 20, altura - 2, 70, 7, Estilos.Cabecera)
        altura = altura + 7
        Impreso.Detalle.Titulo("ENVASE: ", Col(1), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(ConfecEnvase, Col(1) + 20, altura - 2, 100, 7, Estilos.Cabecera)
        Impreso.Detalle.Titulo("MARCA: ", Col(2), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Marca, Col(2) + 20, altura - 2, 41, 7, Estilos.Cabecera)
        Col(2) = Col(2) - 15
        altura = altura + 7
        Impreso.Detalle.Titulo("PEDIDO: ", Col(1), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Pedido, Col(1) + 20, altura - 2, 100, 7, Estilos.Cabecera)
        Impreso.Detalle.Titulo("BULTOS: ", Col(2), altura, 15, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Bultos.ToString("#,##0"), Col(2) + 15, altura - 2, 15, 7, Estilos.Cabecera, ">")
        Impreso.Detalle.Titulo("K.BRUTOS: ", Col(3), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(KilosBrutos, Col(3) + 20, altura - 2, 15, 7, Estilos.Cabecera, ">")
        altura = altura + 7
        Impreso.Detalle.Titulo("PIEZAS: ", Col(2), altura, 15, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Piezas.ToString("#,##0"), Col(2) + 15, altura - 2, 15, 7, Estilos.Cabecera, ">")
        Impreso.Detalle.Titulo("K.NETOS: ", Col(3), altura, 18, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(KilosNetos, Col(3) + 20, altura - 2, 15, 7, Estilos.Cabecera, ">")
        altura = altura + 7
        If Terminado = "N" Then
            Impreso.Detalle.Titulo("TRAZABILIDAD: ", Col(1), altura, 27, 4, Estilos.Normal)
            Impreso.Detalle.Titulo(Trazabilidad, Col(1) + 27, altura - 2, 125, 7, Estilos.Cabecera)
        End If
        Impreso.Detalle.Titulo(Controlado, margen_izquierdo, altura - 2, 180, 7, Estilos.Cabecera, ">")
        altura = altura + 6

        'altura = altura + 1


    End Sub


    Private Sub ImprimePaletControlado(ByRef Impreso As Impreso, ByRef altura As Integer, Controlado As Boolean)

        If Controlado Then
            Impreso.Detalle.Titulo("PALET CONTROLADO", margen_izquierdo, altura - 2, 180, 7, Estilos.Cabecera)
        Else
            Impreso.Detalle.Titulo("PALET NO CONTROLADO", margen_izquierdo, altura - 2, 180, 7, Estilos.Cabecera)
        End If

    End Sub


    Private Function TrazabilidadPalet(IdLineaPalet As String) As String

        Dim res As String = ""


        If VaInt(IdLineaPalet) > 0 Then

            Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)


            'Dim sql As String = "SELECT DISTINCT AEL_Muestreo as Partida " & vbCrLf
            'sql = sql & " FROM Palets_Lineas" & vbCrLf
            'sql = sql & " INNER JOIN Palets_Traza ON PLT_IdLineaPalet = PLL_IdLinea" & vbCrLf
            'sql = sql & " INNER JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLT_IdLineaEntrada" & vbCrLf
            'sql = sql & " WHERE PLL_IdLinea = " & IdLineaPalet


            Dim sql As String = "SELECT DISTINCT 'P' as Tipo, AEL_Muestreo as Numero" & vbCrLf
            sql = sql & " FROM Palets_Lineas" & vbCrLf
            sql = sql & " INNER JOIN Palets_Traza ON (PLT_IdLineaPalet = PLL_IdLinea AND COALESCE(PLT_IdProgramaCliente,0) = 0)" & vbCrLf
            sql = sql & " INNER JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLT_IdLineaEntrada" & vbCrLf
            sql = sql & " WHERE PLL_IdLinea = " & IdLineaPalet & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " Select DISTINCT 'L' as Tipo, LTE_Lote as Numero " & vbCrLf
            sql = sql & " FROM Palets_Lineas" & vbCrLf
            'sql = sql & " INNER JOIN Palets_Traza ON PLT_IdLineaPalet = PLL_IdLinea" & vbCrLf
            sql = sql & " INNER JOIN Palets_Traza ON (PLT_IdLineaPalet = PLL_IdLinea AND COALESCE(PLT_IdProgramaCliente,0) = 0)" & vbCrLf
            sql = sql & " INNER JOIN Lotes ON LTE_IdLote = PLT_IdLote" & vbCrLf
            sql = sql & " WHERE PLL_IdLinea = " & IdLineaPalet & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " Select DISTINCT 'C' as Tipo, LPD_Lote as Numero " & vbCrLf
            sql = sql & " FROM Palets_Lineas" & vbCrLf
            'sql = sql & " INNER JOIN Palets_Traza ON PLT_IdLineaPalet = PLL_IdLinea" & vbCrLf
            sql = sql & " INNER JOIN Palets_Traza ON (PLT_IdLineaPalet = PLL_IdLinea AND COALESCE(PLT_IdProgramaCliente,0) = 0)" & vbCrLf
            sql = sql & " INNER JOIN LotesProduccion ON LPD_IdLote = PLT_IdPrecalibrado" & vbCrLf
            sql = sql & " WHERE PLL_IdLinea = " & IdLineaPalet & vbCrLf



            Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim Tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
                    Dim Partida As String = (row("Numero").ToString & "").Trim

                    If res.Trim <> "" Then res = res & ","
                    res = res & Tipo & Partida


                    Application.DoEvents()

                Next

            End If



        End If
        

        Return res

    End Function
    

End Module
