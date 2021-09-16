Imports System.Drawing


Module C1_ValeGastos


    Dim ancho_linea As Decimal = 2


    Public Sub C1_ImprimirValeGastosEntrada(IdAlbaran As String, TipoImpresion As TipoImpresion,
                                        Optional Impresora As String = "",
                                        Optional rutaPDF As String = "",
                                        Optional archivoPDF As String = "")

        Dim err As New Errores()
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        If AlbEntrada.LeerId(IdAlbaran) Then

            If Agricultores.LeerId(AlbEntrada.AEN_IdAgricultor.Valor) Then

                Try

                    Dim AlbEntrada_Gastos As New E_albentrada_gastos(Idusuario, cn)


                    Dim sql As String = "SELECT ACR_Nombre as Acreedor, ACR_Codigo as IdAcreedor, TGA_ImprimirEnEntrada as ImprimirEnEntrada," & vbCrLf
                    sql = sql & " (SELECT SUM(AEL_Bultos) FROM AlbEntrada_Lineas as Bultos WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Bultos," & vbCrLf
                    sql = sql & " (SELECT SUM(AEL_KilosNetos) FROM AlbEntrada_Lineas as Kilos WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Kilos," & vbCrLf
                    sql = sql & " (SELECT SUM(AEL_Palets) FROM AlbEntrada_Lineas as Palets WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Palets," & vbCrLf
                    sql = sql & " AEG_tipo AS tipo, AEG_gasto AS valor" & vbCrLf
                    sql = sql & " FROM NetAgroComer.dbo.albentrada_gastos" & vbCrLf
                    sql = sql & " LEFT JOIN Acreedores ON ACR_Codigo = AEG_IdAcreedor" & vbCrLf
                    sql = sql & " LEFT JOIN AlbEntrada ON AEG_IdAlbaran = AEN_IdAlbaran" & vbCrLf
                    sql = sql & " LEFT JOIN TiposDeGastosAgri ON TGA_IdTipoGasto = AEG_IdGasto" & vbCrLf
                    sql = sql & " WHERE albentrada_gastos.AEG_idalbaran = " & IdAlbaran & vbCrLf
                    sql = sql & " AND COALESCE(AEG_IdAcreedor, 0) > 0" & vbCrLf
                    sql = sql & " AND COALESCE(TGA_ImprimirEnEntrada,'N') = 'S'" & vbCrLf

                    Dim dt As DataTable = AlbEntrada_Gastos.MiConexion.ConsultaSQL(sql)


                    If Not IsNothing(dt) Then

                        Dim NumeroGasto As Integer = 1

                        For Each row As DataRow In dt.Rows

                            Dim tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
                            Dim ImprimirEnEntrada As String = (row("ImprimirEnEntrada").ToString & "").ToUpper.Trim

                            If tipo = "K" Or tipo = "B" Or tipo = "P" Or tipo = "I" Then
                                ImprimeValePorte_Uno(AlbEntrada, Agricultores, row, NumeroGasto, TipoImpresion, Impresora, rutaPDF, archivoPDF)
                                NumeroGasto = NumeroGasto + 1
                            End If


                            Application.DoEvents()

                        Next

                    End If

                Catch ex As Exception
                    err.Muestraerror("Error al imprimir el vale de gastos", "ImprimirBoletaValeGastos", ex.Message)
                End Try

            Else
                err.Muestraerror("No puedo leer el agricultor con código: " & AlbEntrada.AEN_IdAgricultor.Valor, "ImprimirBoletaValeGastos", "No puedo leer el agricultor con código: " & AlbEntrada.AEN_IdAgricultor.Valor)
            End If

        Else
            err.Muestraerror("No puedo leer el albarán con Id: " & IdAlbaran, "ImprimirBoletaValeGastos", "No puedo leer el albarán con Id: " & IdAlbaran)
        End If





    End Sub


    Private Sub ImprimeValePorte_Uno(AlbEntrada As E_AlbEntrada, Agricultor As E_Agricultores, row As DataRow, NumeroGasto As Integer,
                                 TipoImpresion As TipoImpresion, Impresora As String, rutaPDF As String, ArchivoPDF As String)



        'Línea
        Dim Tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
        Dim IdAcreedor As String = VaInt(row("IdAcreedor")).ToString("00000")
        Dim Acreedor As String = row("Acreedor").ToString & ""
        Dim KilosBultosPalets As String = ""
        Dim PxKBP As String = ""
        Dim Total As String = ""


        Select Case Tipo

            Case "K"
                Dim nKilos As Decimal = VaDec(row("Kilos"))
                Dim Precio As Decimal = VaDec(row("Valor"))

                KilosBultosPalets = nKilos.ToString("#,##0")
                PxKBP = Precio.ToString("#,##0.0000")
                Total = (nKilos * Precio).ToString("#,##0.00")

            Case "B"
                Dim nBultos As Decimal = VaDec(row("Bultos"))
                Dim Precio As Decimal = VaDec(row("Valor"))

                KilosBultosPalets = nBultos.ToString("#,##0")
                PxKBP = Precio.ToString("#,##0.0000")
                Total = (nBultos * Precio).ToString("#,##0.00")

            Case "P"
                Dim nPalets As Decimal = VaDec(row("Palets"))
                Dim Precio As Decimal = VaDec(row("Valor"))

                KilosBultosPalets = nPalets.ToString("#,##0")
                PxKBP = Precio.ToString("#,##0.0000")
                Total = (nPalets * Precio).ToString("#,##0.00")

            Case "I"
                Total = VaDec(row("Valor")).ToString("#,##0.00")

        End Select


        'Sólo imprime si tiene gasto o si tiene transportista
        Dim bImprimir As Boolean = True
        If Total <> 0 Or VaInt(IdAcreedor) > 0 Then
            bImprimir = True
        Else
            bImprimir = False
        End If

        'If Total = 0 Then
        '    Exit Sub
        'End If


        If Not bImprimir Then
            Exit Sub
        End If



        Dim Impreso As New Impreso
        Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
        Impreso.f.Documento.PageLayout.PageSettings.Landscape = True
        

        Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
        Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
        Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
        Impreso.f.Documento.PageLayout.PageSettings.RightMargin = "0mm"

        Impreso.EstableceImpreso(TipoImpresion)


        Dim altura As Integer = 25
        Dim margen_izquierdo As Integer = 15


        Dim Col As New List(Of Integer)
        Col.Add(0)
        Col.Add(margen_izquierdo + 2)               'Col1
        Col.Add(Col(1) + 65)                        'Col2
        Col.Add(Col(2) + 37)                        'Col3
        Col.Add(Col(3) + 43)                        'Col4



        Try

            'Título
            Impreso.Detalle.Titulo("VALE DE GASTOS", margen_izquierdo + 2, altura, 85, 6, Estilos.GrandeBold)
            altura = altura + 9
            Impreso.Detalle.Cuadro(margen_izquierdo, altura, 178, 94, ancho_linea, Color.Black)
            Impreso.Detalle.LineaH(margen_izquierdo, altura + 21, 178, ancho_linea, Color.Black)
            Impreso.Detalle.LineaH(margen_izquierdo, altura + 28, 178, ancho_linea, Color.Black)


            'Datos albarán
            ImprimeDatosAlbaranAgricultor(AlbEntrada, Agricultor, Impreso, altura, margen_izquierdo)

            'Cabecera líneas
            ImprimeCabeceraLineasValeGastos(row, Impreso, altura, margen_izquierdo, Col)

            'Detalle de gasto
            ImprimeDetalleValeGastos(IdAcreedor, Acreedor, KilosBultosPalets, PxKBP, Total, Tipo, Impreso, altura, margen_izquierdo, Col)

            'CodBarras
            ImprimirCodigoBarrasValeGastos(row, AlbEntrada, Impreso, NumeroGasto)


            'Impresión / previsualización / exportación
            Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
            If valoresusuario.LeerId(Idusuario) = True Then
                Impresora = valoresusuario.VUS_ImpresoraValeEnvases.Valor
            End If


            Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, ArchivoPDF)

        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImprimeDatosAlbaranAgricultor(AlbEntrada As E_AlbEntrada, Agricultor As E_Agricultores, Impreso As Impreso, ByRef altura As Integer, margen_izquierdo As Integer)


        Dim Ejercicio As String = VaInt(AlbEntrada.AEN_Campa.Valor).ToString("00")
        Dim NumAlbaran As String = AlbEntrada.AEN_Albaran.Valor
        Dim Campa As String = VaInt(AlbEntrada.AEN_Campa.Valor).ToString("00")
        Dim FechaSubasta As String = ""
        If VaDate(AlbEntrada.AEN_Fecha.Valor) > VaDate("") Then FechaSubasta = VaDate(AlbEntrada.AEN_Fecha.Valor).ToString("dd/MM/yyyy")
        Dim hora As String = Now.ToString("HH:mm")




        Impreso.Detalle.Cuadro(margen_izquierdo + 85, altura + 2, 84, 17, ancho_linea, Color.Black)
        altura = altura + 5


        Impreso.Detalle.Titulo("N. Albaran: ", margen_izquierdo + 2, altura, 20, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Campa & "-" & NumAlbaran, margen_izquierdo + 25, altura, 17, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo("N. Refer.: ", margen_izquierdo + 44, altura, 15, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Agricultor.AGR_Nombre.Valor, margen_izquierdo + 90, altura, 75, 4, Estilos.ReducidaBold)
        'miBoleta.Titulo(Referencia, margen_izquierdo + 63, altura, 17, 4, Estilos.Reducida)
        altura = altura + 4

        Impreso.Detalle.Titulo("Fecha: ", margen_izquierdo + 2, altura, 20, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(FechaSubasta, margen_izquierdo + 25, altura, 50, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Agricultor.AGR_Domicilio.Valor, margen_izquierdo + 90, altura, 75, 4, Estilos.ReducidaBold)
        altura = altura + 4

        Impreso.Detalle.Titulo("Codigo: ", margen_izquierdo + 2, altura, 20, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(VaInt(Agricultor.AGR_IdAgricultor.Valor).ToString("00000"), margen_izquierdo + 25, altura, 17, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo("H.: ", margen_izquierdo + 44, altura, 7, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(hora, margen_izquierdo + 53, altura, 30, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Agricultor.AGR_Poblacion.Valor, margen_izquierdo + 90, altura, 75, 4, Estilos.ReducidaBold)

        altura = altura + 10


    End Sub


    Private Sub ImprimeCabeceraLineasValeGastos(row As DataRow, Impreso As Impreso, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer))

        Dim fuente As New Font("Tahoma", 8, FontStyle.Bold Xor FontStyle.Italic)
        Dim tipo As String = (row("tipo").ToString & "").ToUpper.Trim

        Dim Titulo_Kilos As String = ""
        Dim Titulo_Precio As String = ""

        Select Case tipo

            Case "K"
                Titulo_Kilos = "Kilos"
                Titulo_Precio = "Precio x Kilo"

            Case "B"
                Titulo_Kilos = "Bultos"
                Titulo_Precio = "Precio x Bulto"

            Case "P"
                Titulo_Kilos = "Palets"
                Titulo_Precio = "Precio x Palet"

                'Case "I"
                'Titulo_Precio = "Gasto por Kilo" 'TODO: Comprobar


        End Select


        Impreso.Detalle.Titulo("Acreedor", Col(1), altura, 50, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Titulo_Kilos, Col(2), altura, 42, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Titulo_Precio, Col(3), altura, 48, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Total porte", Col(4), altura, 30, 4, Estilos.Custom, , , fuente)
        altura = altura + 10




    End Sub


    Private Sub ImprimeDetalleValeGastos(IdAcreedor As String, Acreedor As String, KilosBultosPalets As String, PxKBP As String, Total As String, tipo As String,
                                         Impreso As Impreso, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer))


        Impreso.Detalle.Titulo(IdAcreedor & "-" & Acreedor, Col(1), altura, 64, 4, Estilos.Reducida)
        If tipo <> "I" Then Impreso.Detalle.Titulo(KilosBultosPalets, Col(2), altura, 36, 4, Estilos.Reducida)
        If tipo <> "I" Then Impreso.Detalle.Titulo(PxKBP, Col(3), altura, 42, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Total, Col(4), altura, 24, 4, Estilos.Reducida)
        altura = altura + 4


    End Sub


    Private Sub ImprimirCodigoBarrasValeGastos(row As DataRow, AlbEntrada As E_AlbEntrada, Impreso As Impreso, NumeroGasto As Integer)

        Dim Campa As String = VaInt(AlbEntrada.AEN_Campa.Valor).ToString("00")
        Dim IdCentro As String = VaInt(AlbEntrada.AEN_IdCentro.Valor).ToString("00")
        Dim NumAlbaran As String = VaInt(AlbEntrada.AEN_Albaran.Valor).ToString("000000")


        Dim Code39 As New Font("C39HrP24DhTt", 30)
        Dim cod_barras As String = "*" & Campa & IdCentro & NumAlbaran & NumeroGasto.ToString & "*"
        Impreso.Detalle.Titulo(cod_barras, 115, 120, 65, 15, Estilos.Custom, , , Code39)

    End Sub




End Module
