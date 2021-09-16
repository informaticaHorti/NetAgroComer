
Imports System.Drawing


Module C1_ClasificacionesProveedores




    Public Sub C1_ListadoClasificacionesProveedor(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean, bEmision As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional Impresora As String = "",
                                                  Optional rutaPDF As String = "", Optional ArchivoPDF As String = "", Optional ByRef NumPDF As Integer = 0)



        'Ruta exportación PDF se toma de configuraciones diversas por defecto
        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
            If rutaPDF.Trim = "" Then
                rutaPDF = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
            End If
            If rutaPDF.Trim <> "" And Not rutaPDF.EndsWith("\") Then rutaPDF = rutaPDF & "\"
        End If



        If bHojaPorCliente And TipoImpresion <> NetAgro.TipoImpresion.Preliminar Then

            'Si está marcada la opción de una hoja por cliente y no es preliminar
            C1_ListadoClasificacionesProveedor_Directa(dt, Semana, Campa, Año, AgrDesde, AgrHasta, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones,
                                                       TipoEntrada, Valorados, lstRecogida, bGenerarPDF, bHojaPorCliente, bEmision, TipoImpresion, Impresora, rutaPDF, ArchivoPDF, NumPDF)

        Else

            'Preliminar o un archivo para todos
            C1_ListadoClasificacionesProveedor_UnArchivo(dt, Semana, Campa, Año, AgrDesde, AgrHasta, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada,
                                                         Valorados, lstRecogida, bGenerarPDF, bHojaPorCliente, bEmision, TipoImpresion, Impresora, rutaPDF, ArchivoPDF, NumPDF)

        End If


    End Sub


    Private Sub C1_ListadoClasificacionesProveedor_Directa(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean, bEmision As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional Impresora As String = "",
                                                  Optional rutaPDF As String = "", Optional ArchivoPDF As String = "", Optional ByRef NumPDF As Integer = 0)



        Dim lstAgr As New List(Of String)

        'Impresión de trabajos individuales, primero por empresa y después por agricultor
        For Each row As DataRow In dt.Rows
            Dim CodAgr As String = (row("IdAgricultor").ToString & "").Trim
            If Not lstAgr.Contains(CodAgr) Then
                lstAgr.Add(CodAgr)
            End If
        Next


        Dim Documentos As New List(Of Object)


        For Each IdAgricultor As String In lstAgr


            'Filtramos los documentos sólo para el agricultor
            Dim dtAgr As DataTable = dt.Select("IdAgricultor = " & IdAgricultor).CopyToDataTable


            Dim Listado As Listado = C1_AñadeClasificacionAgr(dtAgr, Semana, Campa, Año, IdAgricultor, IdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida)
            If bGenerarPDF Then

                'Exportación a PDF (en caso de cliente por página)
                If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then

                    ArchivoPDF = "ListadoClasif_" & VaInt(IdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"
                    C1_ListadoClasificacionesProveedor(dtAgr, Semana, Campa, Año, IdAgricultor, IdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                       True, False, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                    NumPDF = NumPDF + 1

                End If

            End If


            'Impresión
            If TipoImpresion = NetAgro.TipoImpresion.ExportacionPDF Then
                Listado.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)
            Else
                Listado.Imprimir(TipoImpresion, Impresora)
            End If


        Next



    End Sub



    Private Sub C1_ListadoClasificacionesProveedor_UnArchivo(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean, bEmision As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional Impresora As String = "",
                                                  Optional rutaPDF As String = "", Optional ArchivoPDF As String = "", Optional ByRef NumPDF As Integer = 0)


        NumPDF = 0


        If AgrDesde.Trim = "" Then AgrDesde = "00001"
        If AgrHasta.Trim = "" Then AgrHasta = "99999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"

        Dim Observaciones As String = ""
        If bObservaciones Then
            Observaciones = "SI"
        Else
            Observaciones = "NO"
        End If


        Dim Empresas As String = ""
        For Each s As String In lstEmpresas
            If Empresas <> "" Then Empresas = Empresas & ","
            Empresas = Empresas & s
        Next
        If Empresas = "" Then Empresas = "TODAS"


        Dim TextoTipoEntrada As String = ""
        If TipoEntrada = "F" Then
            TextoTipoEntrada = "Solo FIRME"
        ElseIf TipoEntrada = "C" Then
            TextoTipoEntrada = "Solo CONFECCION"
        ElseIf TipoEntrada = "S" Then
            TextoTipoEntrada = "Solo S/CLASIF."
        Else
            TextoTipoEntrada = "TODAS"
        End If
        TextoTipoEntrada = "Tipo de Entrada: " & TextoTipoEntrada


        Dim Recogida As String = ""
        For Each s As String In lstRecogida
            If Recogida <> "" Then Recogida = Recogida & ","
            Recogida = Recogida & s
        Next
        If Recogida = "" Then Recogida = "TODOS"



        'Tipo de categorías
        Dim lstTiposCat As New List(Of Integer)
        Dim DcTiposCat As New Dictionary(Of Integer, String)

        Dim TiposDeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Dim dtTiposCat As DataTable = TiposDeCategoria.Tabla
        If Not IsNothing(dtTiposCat) Then
            For Each row As DataRow In dtTiposCat.Rows

                Dim IdTipoCat As Integer = VaInt(row("Id"))
                Dim TipoCat As String = (row("Abrev").ToString & "").Trim
                lstTiposCat.Add(IdTipoCat)
                DcTiposCat(IdTipoCat) = TipoCat

                If lstTiposCat.Count = 5 Then Exit For

            Next
        End If
        Dim DcGeneros As New Dictionary(Of Integer, String)

        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
            If rutaPDF.Trim = "" Then
                rutaPDF = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
            End If
            If rutaPDF.Trim <> "" Then rutaPDF = rutaPDF & "\"
        End If

        Dim Listado As New Listado()

        Listado.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.documento.PageLayout.PageSettings.Landscape = False
        Listado.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Listado.f.documento.PageLayout.PageSettings.LeftMargin = "8mm"
        Listado.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"


        Listado.EstableceListado(TipoImpresion)


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea("Resumen de Clasificaciones por Proveedor|Semana " & Semana & "|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "<85|<45|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Proveedor " & AgrDesde & " Hasta Proveedor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "110|>80", Estilos.NormalBold)
        If Not bEmision Then
            Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Mostrar observaciones: " & Observaciones, "95|>95", Estilos.NormalBold)
            Listado.Cabecera.Linea("Empresas: " & Empresas & "|" & TextoTipoEntrada, "115|>75", Estilos.NormalBold)
            Listado.Cabecera.Linea("C.Recogida: " & Recogida & "|Valorados: " & Valorados, "115|>75", Estilos.NormalBold)
        End If
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "15|=15|=15|40|>15|4|30|>15|>21"
        Dim Cabecera As String = "PARTIDA|FECHA|COD|GENERO|KILOSENT||CAT./CAL.|KILOS|%"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosPar As Decimal = 0
        Dim TotalKilosEntAgr As Decimal = 0
        Dim TotalAlbaran As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxPartida As String = ""
        Dim bCabecera As Boolean = True
        Dim bObs As Boolean = False
        Dim bAgricultorConClasificados As Boolean = False

        Dim DcTiposCatAgr As New Dictionary(Of Integer, Decimal)
        Dim DcTiposCatGenAgr As New Dictionary(Of Integer, Dictionary(Of Integer, Decimal))
        Dim lstGenerosAgr As New List(Of Integer)
        Dim DcTiposCatPar As New Dictionary(Of Integer, Decimal)


        Dim lstPartidasSinClasificar As New List(Of DataRow)


        Try


            For Each row As DataRow In dt.Rows

                Dim Clasificada As String = (row("Clasif").ToString & "").Trim.ToUpper

                Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
                Dim bCambioAgricultor As Boolean = (AuxIdAgricultor <> IdAgricultor And AuxIdAgricultor <> "")


                Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                Dim Partida As String = VaDec(row("Partida")).ToString("00000000")
                Dim Albaran As String = VaDec(row("Albaran")).ToString("000000")
                Dim Cultivo As String = (row("Cultivo").ToString & "").Trim
                Dim Obs As String = " Observaciones: " & (row("ObservacionesProveedor").ToString & "").Trim
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

                Dim Genero As String = (row("Genero").ToString & "").Trim
                DcGeneros(VaInt(IdGenero)) = Genero

                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim KilosEnt As Decimal = VaDec(row("KilosEnt"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Porcentaje As Decimal = 0
                If KilosEnt <> 0 Then Porcentaje = Kilos / KilosEnt * 100


                Dim bCambioGenero As Boolean = (AuxIdGenero <> IdGenero And AuxIdGenero <> "")
                Dim bCambioPartida As Boolean = (Partida <> AuxPartida And AuxPartida <> "")

                If bCambioAgricultor Then
                    bCambioPartida = True
                    bCambioGenero = True
                End If

                If bCambioGenero Then
                    bCambioPartida = True
                End If


                bAgricultorConClasificados = AgricultorConClasificacion(DcTiposCatAgr)


                If bCambioPartida Then

                    'Resumen partida anterior
                    If bAgricultorConClasificados Then
                        Listado.Detalle.Linea("|||||||TOTAL...|" & TotalKilosPar.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)

                        ImprimeResumenCategoriasPartida(Listado, lstTiposCat, DcTiposCat, DcTiposCatPar)
                    End If

                    DcTiposCatPar.Clear()

                    TotalKilosPar = 0
                    bCabecera = True
                End If


                If bCambioGenero Then
                    If bAgricultorConClasificados Then
                        'Cambio de género
                        ImprimeResumenCategoriasGenero(Listado, AuxIdGenero, DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)
                    End If
                End If


                If bCambioAgricultor Then

                    'Resumen por géneros
                    'ImprimeResumenCategoriasGenero(Listado, lstGenerosAgr, DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)

                    If AuxIdAgricultor = "4325" Then
                        Dim a As String = ""
                    End If


                    If bAgricultorConClasificados Then

                        'Resumen agricultor anterior
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
                        Listado.Detalle.Linea("Total K. Entrados: " & TotalKilosEntAgr.ToString("#,##0.00"), "170", Estilos.ReducidaBoldLineaDebajo)

                        'Separacion por tipos de categorías
                        ImprimeResumenCategorias(Listado, lstTiposCat, DcTiposCat, DcTiposCatAgr, TotalKilosEntAgr)
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)

                    End If


                    'Partidas sin clasificar por agricultor
                    ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "170")



                    TotalKilosEntAgr = 0
                    DcTiposCatAgr.Clear()
                    DcTiposCatGenAgr.Clear()
                    lstGenerosAgr.Clear()
                    lstPartidasSinClasificar.Clear()


                    If AuxIdAgricultor <> "" Then

                        If bHojaPorCliente Then Listado.Detalle.SaltoPagina()

                        If bGenerarPDF Then
                            'Exportación a PDF (en caso de cliente por página)
                            If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
                                ArchivoPDF = "ListadoClasif_" & VaInt(AuxIdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"

                                Dim dv As New DataView(dt)
                                dv.RowFilter = "IdAgricultor = " & AuxIdAgricultor
                                Dim dtClasif As DataTable = dv.ToTable

                                C1_ListadoClasificacionesProveedor(dtClasif, Semana, Campa, Año, AuxIdAgricultor, AuxIdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                                   True, False, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                                NumPDF = NumPDF + 1

                                dtClasif.Dispose()
                                dtClasif = Nothing

                            End If
                        End If

                    End If


                End If



                'Nuevo agricultor
                If IdAgricultor <> AuxIdAgricultor Then
                    Listado.Detalle.Linea("", "170", Estilos.ReducidaLineaDebajo)
                    Listado.Detalle.Linea(VaInt(IdAgricultor).ToString("00000") & "|" & Agricultor, "15|155", Estilos.NormalBoldLineaDebajo)
                End If



                If Clasificada = "S" Then

                    'Nuevo albarán
                    If Partida <> AuxPartida Then
                        Dim alb As String = "Albarán: " & Albaran & "   Cultivo: " & Cultivo & " " & Obs
                        Listado.Detalle.Linea(alb, "170", Estilos.ReducidaBold)
                    End If


                    'Líneas de listado
                    If bCabecera Then
                        Dim det As String = Partida & "|"
                        det = det & Fecha & "|"
                        det = det & VaInt(IdGenero).ToString("00000") & "|"
                        det = det & Genero & "|"
                        det = det & KilosEnt.ToString("#,##0.00") & "||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Porcentaje.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, DLin, Estilos.Reducida)
                        bCabecera = False
                        bObs = True
                    Else
                        Dim det As String = "|"
                        det = det & "|||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Porcentaje.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, "15|<70|>15|4|30|>15|>21", Estilos.Reducida)
                        bObs = False
                    End If
                Else
                    lstPartidasSinClasificar.Add(row)
                End If



                Dim IdTipoCat As Integer = VaInt(row("IdTipoCategoria"))
                AcumulaCategorias(IdTipoCat, VaInt(IdGenero), Kilos, DcTiposCatAgr, lstGenerosAgr, DcTiposCatGenAgr)
                AcumulaPartidas(IdTipoCat, Kilos, DcTiposCatPar)


                TotalKilosPar = TotalKilosPar + Kilos
                TotalKilosEntAgr = TotalKilosEntAgr + Kilos
                TotalAlbaran = TotalAlbaran + Kilos


                AuxIdGenero = IdGenero
                AuxPartida = Partida
                AuxIdAgricultor = IdAgricultor
                AuxAgricultor = Agricultor



                Application.DoEvents()

            Next


            If bGenerarPDF Then
                'Exportación a PDF (en caso de cliente por página)
                If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
                    ArchivoPDF = "ListadoClasif_" & VaInt(AuxIdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"

                    Dim dv As New DataView(dt)
                    dv.RowFilter = "IdAgricultor = " & AuxIdAgricultor
                    Dim dtClasif As DataTable = dv.ToTable

                    C1_ListadoClasificacionesProveedor(dtClasif, Semana, Campa, Año, AuxIdAgricultor, AuxIdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                       True, False, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                    NumPDF = NumPDF + 1


                    dtClasif.Dispose()
                    dtClasif = Nothing

                End If
            End If



            Dim bConClasificados As Boolean = AgricultorConClasificacion(DcTiposCatAgr)
            If bConClasificados Then

                'Último total partida
                Listado.Detalle.Linea("|||||||TOTAL...|" & TotalKilosPar.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)


                'Último resumen partida
                ImprimeResumenCategoriasPartida(Listado, lstTiposCat, DcTiposCat, DcTiposCatPar)


                'Último resumen por género
                ImprimeResumenCategoriasGenero(Listado, VaInt(AuxIdGenero), DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)

                'Ultimo total proveedor
                Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
                Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                      AuxAgricultor & "|" & _
                                      "Total K. Entrados: " & TotalKilosEntAgr.ToString("#,##0.00"), "15|90|65", Estilos.ReducidaBoldLineaDebajo)

                'Separacion por tipos de categorías
                ImprimeResumenCategorias(Listado, lstTiposCat, DcTiposCat, DcTiposCatAgr, TotalKilosEntAgr)
                Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)

            End If


            'Partidas sin clasificar por agricultor
            ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "170")




            'Previsualizar
            If TipoImpresion = NetAgro.TipoImpresion.ExportacionPDF Then
                Listado.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)
            Else
                'Listado.Imprimir(TipoImpresion.Preliminar)
                Listado.Imprimir(TipoImpresion, Impresora)
            End If


        Catch ex As Exception

        End Try




        'Listado.Dispose()


    End Sub


    Public Function C1_AñadeClasificacionAgr(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                            ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal GenDesde As String, ByVal GenHasta As String,
                            ByRef lstEmpresas As List(Of String), bObservaciones As Boolean,
                            ByVal TipoEntrada As String, Valorados As String, lstRecogida As List(Of String)) As Listado


        If dt.Rows.Count > 0 Then
            Dim dv As New DataView(dt)
            dv.Sort = "IdAgricultor, IdGenero, Albaran, Partida, IdCategoria, Categoria"
            dt = dv.ToTable
        End If


        If AgrDesde.Trim = "" Then AgrDesde = "00001"
        If AgrHasta.Trim = "" Then AgrHasta = "99999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"

        Dim Observaciones As String = ""
        If bObservaciones Then
            Observaciones = "SI"
        Else
            Observaciones = "NO"
        End If


        Dim Empresas As String = ""
        For Each s As String In lstEmpresas
            If Empresas <> "" Then Empresas = Empresas & ","
            Empresas = Empresas & s
        Next
        If Empresas = "" Then Empresas = "TODAS"


        Dim TextoTipoEntrada As String = ""
        If TipoEntrada = "F" Then
            TextoTipoEntrada = "Solo FIRME"
        ElseIf TipoEntrada = "C" Then
            TextoTipoEntrada = "Solo CONFECCION"
        ElseIf TipoEntrada = "S" Then
            TextoTipoEntrada = "Solo S/CLASIF."
        Else
            TextoTipoEntrada = "TODAS"
        End If
        TextoTipoEntrada = "Tipo de Entrada: " & TextoTipoEntrada


        Dim Recogida As String = ""
        For Each s As String In lstRecogida
            If Recogida <> "" Then Recogida = Recogida & ","
            Recogida = Recogida & s
        Next
        If Recogida = "" Then Recogida = "TODOS"



        'Tipo de categorías
        Dim lstTiposCat As New List(Of Integer)
        Dim DcTiposCat As New Dictionary(Of Integer, String)

        Dim TiposDeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Dim dtTiposCat As DataTable = TiposDeCategoria.Tabla
        If Not IsNothing(dtTiposCat) Then
            For Each row As DataRow In dtTiposCat.Rows

                Dim IdTipoCat As Integer = VaInt(row("Id"))
                Dim TipoCat As String = (row("Abrev").ToString & "").Trim
                lstTiposCat.Add(IdTipoCat)
                DcTiposCat(IdTipoCat) = TipoCat

                If lstTiposCat.Count = 5 Then Exit For

            Next
        End If
        Dim DcGeneros As New Dictionary(Of Integer, String)


        Dim Listado As New Listado()

        Listado.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.documento.PageLayout.PageSettings.Landscape = False
        Listado.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Listado.f.documento.PageLayout.PageSettings.LeftMargin = "8mm"
        Listado.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"
        Listado.ForzarSaltoPagina = True


        Listado.EstableceListado(TipoImpresion.Cancelar)


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea("Resumen de Clasificaciones por Proveedor|Semana " & Semana & "|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "<85|<45|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Proveedor " & AgrDesde & " Hasta Proveedor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "110|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "15|=15|=15|40|>15|4|30|>15|>21"
        Dim Cabecera As String = "PARTIDA|FECHA|COD|GENERO|KILOSENT||CAT./CAL.|KILOS|%"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosPar As Decimal = 0
        Dim TotalKilosEntAgr As Decimal = 0
        Dim TotalAlbaran As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxPartida As String = ""
        Dim bCambioAgricultor As Boolean = False
        Dim bCabecera As Boolean = True
        Dim bObs As Boolean = False
        Dim bAgricultorConClasificados As Boolean = False

        Dim DcTiposCatAgr As New Dictionary(Of Integer, Decimal)
        Dim DcTiposCatGenAgr As New Dictionary(Of Integer, Dictionary(Of Integer, Decimal))
        Dim lstGenerosAgr As New List(Of Integer)
        Dim DcTiposCatPar As New Dictionary(Of Integer, Decimal)


        Dim lstPartidasSinClasificar As New List(Of DataRow)


        Try

            For Each row As DataRow In dt.Rows

                Dim Clasificada As String = (row("Clasif").ToString & "").Trim.ToUpper


                Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
                Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                Dim Partida As String = VaDec(row("Partida")).ToString("00000000")
                Dim Albaran As String = VaDec(row("Albaran")).ToString("000000")
                Dim Cultivo As String = (row("Cultivo").ToString & "").Trim
                Dim Obs As String = " Observaciones: " & (row("ObservacionesProveedor").ToString & "").Trim
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

                Dim Genero As String = (row("Genero").ToString & "").Trim
                DcGeneros(VaInt(IdGenero)) = Genero

                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim KilosEnt As Decimal = VaDec(row("KilosEnt"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Porcentaje As Decimal = 0
                If KilosEnt <> 0 Then Porcentaje = Kilos / KilosEnt * 100

                bCambioAgricultor = (AuxIdAgricultor <> IdAgricultor And AuxIdAgricultor <> "")
                Dim bCambioGenero As Boolean = (AuxIdGenero <> IdGenero And AuxIdGenero <> "")
                Dim bCambioPartida As Boolean = (Partida <> AuxPartida And AuxPartida <> "")

                If bCambioAgricultor Then
                    bCambioPartida = True
                    bCambioGenero = True
                End If

                If bCambioGenero Then
                    bCambioPartida = True
                End If


                bAgricultorConClasificados = AgricultorConClasificacion(DcTiposCatAgr)


                If bCambioPartida Then

                    If bAgricultorConClasificados Then

                        'Resumen partida anterior
                        Listado.Detalle.Linea("|||||||TOTAL...|" & TotalKilosPar.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)

                        ImprimeResumenCategoriasPartida(Listado, lstTiposCat, DcTiposCat, DcTiposCatPar)
                    End If

                    DcTiposCatPar.Clear()

                    TotalKilosPar = 0
                    bCabecera = True
                End If


                If bCambioGenero Then
                    If bAgricultorConClasificados Then
                        'Cambio de género
                        ImprimeResumenCategoriasGenero(Listado, AuxIdGenero, DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)
                    End If
                End If


                If bCambioAgricultor Then

                    'Resumen por géneros
                    'ImprimeResumenCategoriasGenero(Listado, lstGenerosAgr, DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)

                    If bAgricultorConClasificados Then

                        'Resumen agricultor anterior
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
                        Listado.Detalle.Linea("Total K. Entrados: " & TotalKilosEntAgr.ToString("#,##0.00"), "170", Estilos.ReducidaBoldLineaDebajo)

                        'Separacion por tipos de categorías
                        ImprimeResumenCategorias(Listado, lstTiposCat, DcTiposCat, DcTiposCatAgr, TotalKilosEntAgr)
                        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)

                    End If


                    'Partidas sin clasificar por agricultor
                    ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "170")


                    TotalKilosEntAgr = 0
                    DcTiposCatAgr.Clear()
                    DcTiposCatGenAgr.Clear()
                    lstGenerosAgr.Clear()
                    lstPartidasSinClasificar.Clear()


                    If AuxIdAgricultor <> "" Then
                        Listado.Detalle.SaltoPagina()
                    End If


                End If



                'Nuevo agricultor
                If IdAgricultor <> AuxIdAgricultor Then
                    Listado.Detalle.Linea("", "170", Estilos.ReducidaLineaDebajo)
                    Listado.Detalle.Linea(VaInt(IdAgricultor).ToString("00000") & "|" & Agricultor, "15|155", Estilos.NormalBoldLineaDebajo)
                End If


                If Clasificada = "S" Then

                    'Nuevo albarán
                    If Partida <> AuxPartida Then
                        Dim alb As String = "Albarán: " & Albaran & "   Cultivo: " & Cultivo & " " & Obs
                        Listado.Detalle.Linea(alb, "170", Estilos.ReducidaBold)
                    End If

                    'Líneas de listado
                    If bCabecera Then
                        Dim det As String = Partida & "|"
                        det = det & Fecha & "|"
                        det = det & VaInt(IdGenero).ToString("00000") & "|"
                        det = det & Genero & "|"
                        det = det & KilosEnt.ToString("#,##0.00") & "||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Porcentaje.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, DLin, Estilos.Reducida)
                        bCabecera = False
                        bObs = True
                    Else
                        Dim det As String = "|"
                        det = det & "|||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Porcentaje.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, "15|<70|>15|4|30|>15|>21", Estilos.Reducida)
                        bObs = False
                    End If

                Else
                    lstPartidasSinClasificar.Add(row)
                End If



                Dim IdTipoCat As Integer = VaInt(row("IdTipoCategoria"))
                AcumulaCategorias(IdTipoCat, VaInt(IdGenero), Kilos, DcTiposCatAgr, lstGenerosAgr, DcTiposCatGenAgr)
                AcumulaPartidas(IdTipoCat, Kilos, DcTiposCatPar)


                TotalKilosPar = TotalKilosPar + Kilos
                TotalKilosEntAgr = TotalKilosEntAgr + Kilos
                TotalAlbaran = TotalAlbaran + Kilos



                AuxIdAgricultor = IdAgricultor
                AuxIdGenero = IdGenero
                AuxAgricultor = Agricultor
                AuxPartida = Partida


                Application.DoEvents()

            Next


            Dim bConClasificados As Boolean = AgricultorConClasificacion(DcTiposCatAgr)
            If bConClasificados Then

                'Último total partida
                Listado.Detalle.Linea("|||||||TOTAL...|" & TotalKilosPar.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)


                'Último resumen partida
                ImprimeResumenCategoriasPartida(Listado, lstTiposCat, DcTiposCat, DcTiposCatPar)


                'Último resumen por género
                ImprimeResumenCategoriasGenero(Listado, VaInt(AuxIdGenero), DcGeneros, lstTiposCat, DcTiposCat, DcTiposCatGenAgr)

                'Ultimo total proveedor
                Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
                Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                      AuxAgricultor & "|" & _
                                      "Total K. Entrados: " & TotalKilosEntAgr.ToString("#,##0.00"), "15|90|65", Estilos.ReducidaBoldLineaDebajo)

                'Separacion por tipos de categorías
                ImprimeResumenCategorias(Listado, lstTiposCat, DcTiposCat, DcTiposCatAgr, TotalKilosEntAgr)
                Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)

            End If


            'Partidas sin clasificar por agricultor
            ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "170")

        Catch ex As Exception

        End Try





        Return Listado

    End Function




    Private Class GastoF

        Public Nombre As String = ""
        Public Importe As Decimal = 0

        Public Sub New(Nombre As String, Importe As Decimal)
            Me.Nombre = Nombre
            Me.Importe = Importe
        End Sub

    End Class


    Private Class TipoIva

        Public TipoIva As String = ""
        Public Importe As Decimal = 0

        Public Sub New(TipoIva As String, Importe As Decimal)
            Me.TipoIva = TipoIva
            Me.Importe = Importe
        End Sub

    End Class


    Private Class TotalClasificacionDesglosado

        Public TotalGenero As Decimal = 0
        Public PorComision As Decimal = 0
        Public Comision As Decimal = 0
        Public BaseImponible As Decimal = 0
        Public lstTiposIVA As New List(Of TipoIva)
        Public PorRet As Decimal = 0
        Public CuotaRet As Decimal = 0
        Public CuotaFondo As Decimal = 0
        Public Liquido As Decimal = 0
        Public OtrosGastos As Decimal = 0
        Public Contingencia As Decimal = 0

    End Class




    Public Sub C1_ListadoClasificacionesProveedorDesglosado(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional Impresora As String = "",
                                                  Optional rutaPDF As String = "", Optional ArchivoPDF As String = "")



        'Ruta exportación PDF se toma de configuraciones diversas por defecto
        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
            If rutaPDF.Trim = "" Then
                rutaPDF = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
            End If
            If rutaPDF.Trim <> "" And Not rutaPDF.EndsWith("\") Then rutaPDF = rutaPDF & "\"
        End If



        If bHojaPorCliente And TipoImpresion <> NetAgro.TipoImpresion.Preliminar Then

            'Si está marcada la opción de una hoja por cliente y no es preliminar
            C1_ListadoClasificacionesProveedorDesglosado_Directa(dt, Semana, Campa, Año, AgrDesde, AgrHasta, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones,
                                                                   TipoEntrada, Valorados, lstRecogida, bGenerarPDF, bHojaPorCliente, TipoImpresion, rutaPDF, ArchivoPDF)

        Else

            'Preliminar o un archivo para todos
            C1_ListadoClasificacionesProveedorDesglosado_UnArchivo(dt, Semana, Campa, Año, AgrDesde, AgrHasta, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones,
                                                                   TipoEntrada, Valorados, lstRecogida, bGenerarPDF, bHojaPorCliente, TipoImpresion, rutaPDF, ArchivoPDF)

        End If


    End Sub



    Private Sub C1_ListadoClasificacionesProveedorDesglosado_Directa(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional rutaPDF As String = "", Optional ArchivoPDF As String = "")



        Dim lstAgr As New List(Of String)

        'Impresión de trabajos individuales, primero por empresa y después por agricultor
        For Each row As DataRow In dt.Rows
            Dim CodAgr As String = (row("IdAgricultor").ToString & "").Trim
            If Not lstAgr.Contains(CodAgr) Then
                lstAgr.Add(CodAgr)
            End If
        Next


        Dim Documentos As New List(Of Object)


        For Each IdAgricultor As String In lstAgr


            'Filtramos los documentos sólo para el agricultor
            Dim dtAgr As DataTable = dt.Select("IdAgricultor = " & IdAgricultor).CopyToDataTable


            Dim Listado As Listado = C1_AñadeClasificacionAgr_Detallado(dtAgr, Semana, Campa, Año, AgrDesde, AgrHasta, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados,
                                                                        lstRecogida, bHojaPorCliente, TipoImpresion, rutaPDF, ArchivoPDF)
            If bGenerarPDF Then

                'Exportación a PDF (en caso de cliente por página)
                If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then

                    ArchivoPDF = "ListadoClasif_" & VaInt(IdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"
                    C1_ListadoClasificacionesProveedorDesglosado(dtAgr, Semana, Campa, Año, IdAgricultor, IdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                       True, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                End If

            End If


            'Impresión
            If TipoImpresion = NetAgro.TipoImpresion.ExportacionPDF Then
                Listado.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)
            Else
                Listado.Imprimir(NetAgro.TipoImpresion.Preliminar)
            End If


        Next



    End Sub


    Private Function C1_AñadeClasificacionAgr_Detallado(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String), bHojaPorCliente As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional rutaPDF As String = "", Optional ArchivoPDF As String = "") As Listado



        If AgrDesde.Trim = "" Then AgrDesde = "00001"
        If AgrHasta.Trim = "" Then AgrHasta = "99999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"

        Dim Observaciones As String = ""
        If bObservaciones Then
            Observaciones = "SI"
        Else
            Observaciones = "NO"
        End If


        Dim Empresas As String = ""
        For Each s As String In lstEmpresas
            If Empresas <> "" Then Empresas = Empresas & ","
            Empresas = Empresas & s
        Next
        If Empresas = "" Then Empresas = "TODAS"


        Dim TextoTipoEntrada As String = ""
        If TipoEntrada = "F" Then
            TextoTipoEntrada = "Solo FIRME"
        ElseIf TipoEntrada = "C" Then
            TextoTipoEntrada = "Solo CONFECCION"
        ElseIf TipoEntrada = "S" Then
            TextoTipoEntrada = "Solo S/CLASIF."
        Else
            TextoTipoEntrada = "TODAS"
        End If
        TextoTipoEntrada = "Tipo de Entrada: " & TextoTipoEntrada


        Dim Recogida As String = ""
        For Each s As String In lstRecogida
            If Recogida <> "" Then Recogida = Recogida & ","
            Recogida = Recogida & s
        Next
        If Recogida = "" Then Recogida = "TODOS"



        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
            If rutaPDF.Trim = "" Then
                rutaPDF = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
            End If
            If rutaPDF.Trim <> "" Then rutaPDF = rutaPDF & "\"
        End If

        Dim Listado As New Listado()

        Listado.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.documento.PageLayout.PageSettings.Landscape = False
        Listado.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Listado.f.documento.PageLayout.PageSettings.LeftMargin = "8mm"
        Listado.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"



        Listado.EstableceListado(TipoImpresion.Cancelar)


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea("Resumen de Clasificaciones por Proveedor|Semana " & Semana & "|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "<85|<45|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Proveedor " & AgrDesde & " Hasta Proveedor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "110|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Mostrar observaciones: " & Observaciones, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Empresas: " & Empresas & "|" & TextoTipoEntrada, "115|>75", Estilos.NormalBold)
        Listado.Cabecera.Linea("C.Recogida: " & Recogida & "|Valorados: " & Valorados, "115|>75", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "12|<18|15|40|>15|4|30|>15|>21|>21"
        Dim Cabecera As String = "ALBAR|FECHA|PARTIDA|GENERO|KILOSENT||CAT./CAL.|KILOS|PRECIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosAlb As Decimal = 0
        Dim TotalKilosEntAgr As Decimal = 0
        Dim TotalKilosAlbaran As Decimal = 0
        Dim TotalImpAlb As Decimal = 0
        Dim TotalImpEntAgr As Decimal = 0
        Dim TotalImpAlbaran As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdAlbaran As String = ""
        Dim AuxPartida As String = ""
        Dim bCabecera As Boolean = True
        Dim bObs As Boolean = False
        Dim AuxObs As String = ""

        Dim DcAgricultoresClasif As New Dictionary(Of Integer, Boolean)
        Dim DcAgricultores As New Dictionary(Of Integer, TotalClasificacionDesglosado)


        Dim lstPartidasSinClasificar As New List(Of DataRow)


        Dim GastoAlb As Decimal = 0


        Try

            For Each row As DataRow In dt.Rows

                Dim Clasificada As String = (row("Clasif").ToString & "").Trim.ToUpper
                Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                If Clasificada = "S" Then DcAgricultoresClasif(IdAgricultor) = True


                Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                Dim Albaran As String = VaDec(row("Albaran")).ToString("000000")
                'Dim Partida As String = (row("Partida").ToString & "").Trim
                Dim Partida As String = VaDec(row("Partida")).ToString("00000000")
                Dim Cultivo As String = (row("Cultivo").ToString & "").Trim
                Dim Obs As String = (row("ObservacionesProveedor").ToString & "").Trim
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

                Dim Genero As String = (row("Genero").ToString & "").Trim

                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim KilosEnt As Decimal = VaDec(row("KilosEnt"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Importe As Decimal = VaDec(row("Importe"))

                Dim bCambioAgricultor As Boolean = (AuxIdAgricultor <> IdAgricultor And AuxIdAgricultor <> "")
                Dim bCambioAlbaran As Boolean = (IdAlbaran <> AuxIdAlbaran And AuxIdAlbaran <> "")
                Dim bCambioPartida As Boolean = (Partida <> AuxPartida And AuxPartida <> "")

                If bCambioAgricultor Then
                    bCambioAlbaran = True
                    bCambioPartida = True
                End If

                If bCambioAlbaran Then
                    bCambioPartida = True
                End If


                If bCambioPartida Then
                    If DcAgricultoresClasif.ContainsKey(IdAgricultor) Then
                        If bObservaciones Then
                            If AuxObs.Trim <> "" Then Listado.Detalle.Linea("|||Observ.: " & AuxObs & "|||||", DLin, Estilos.MinimaCursiva)
                        End If
                    End If
                End If


                If bCambioAlbaran Then

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                        'Resumen albarán anterior
                        Listado.Detalle.Linea("|||||||-------------||--------------", DLin, Estilos.ReducidaBold)
                        Listado.Detalle.Linea("|||||||" & TotalKilosAlb.ToString("#,##0.00") & "||" & TotalImpAlb.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
                    End If

                    GastoAlb = GastosAlbaranEntrada(VaInt(AuxIdAlbaran), TotalKilosAlb, TotalImpAlb)

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                        ImprimirResumenPreciosClasificacionAlbaranes(Listado, AuxIdAlbaran, AuxIdAgricultor, TotalImpAlb, DcAgricultores, GastoAlb)
                    End If

                    TotalKilosAlb = 0
                    TotalImpAlb = 0
                    bCabecera = True

                End If


                If bCambioAgricultor Then

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then

                        'Resumen agricultor anterior
                        Listado.Detalle.Linea("", "191", Estilos.ReducidaBold)
                        Listado.Detalle.Linea("", "191", Estilos.ReducidaBoldLineaDebajo)

                        ImprimirResumenPreciosClasificacionAgricultores(Listado, AuxIdAgricultor, AuxAgricultor, TotalKilosEntAgr, DcAgricultores)
                        'Listado.Detalle.Linea("TOTAL|" & VaInt(AuxIdAgricultor).ToString("00000") & " " & AuxAgricultor & "|" & TotalKilosEntAgr.ToString("#,##0.00") & "||" & TotalImpEntAgr.ToString("#,##0.00"),
                        '                      "12|122|>15|21|>21", Estilos.ReducidaBold)

                    End If

                    'Partidas sin clasificar por agricultor
                    Listado.Detalle.Linea("", "191", Estilos.Normal)
                    ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "191")


                    TotalKilosEntAgr = 0
                    TotalImpEntAgr = 0

                    lstPartidasSinClasificar.Clear()


                    If AuxIdAgricultor <> "" Then
                        If bHojaPorCliente Then Listado.Detalle.SaltoPagina()
                    End If


                End If



                'Nuevo agricultor
                If IdAgricultor <> AuxIdAgricultor Then
                    Listado.Detalle.Linea("", "191", Estilos.ReducidaLineaDebajo)
                    Listado.Detalle.Linea(VaInt(IdAgricultor).ToString("00000") & "|" & Agricultor, "15|176", Estilos.NormalBoldLineaDebajo)
                End If


                If Clasificada = "S" Then

                    'Líneas de listado
                    If bCabecera Then
                        Dim det As String = Albaran & "|"
                        det = det & Fecha & "|"
                        det = det & Partida & "|"
                        det = det & Genero & "|"
                        det = det & KilosEnt.ToString("#,##0.00") & "||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Precio.ToString("#,##0.0000") & "|"
                        det = det & Importe.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, DLin, Estilos.Reducida)
                        bCabecera = False
                    Else

                        If Partida <> AuxPartida Then
                            'Cambio de partida
                            Dim det As String = "||"
                            det = det & Partida & "|"
                            det = det & Genero & "|"
                            det = det & KilosEnt.ToString("#,##0.00") & "||"
                            det = det & Categoria & "|"
                            det = det & Kilos.ToString("#,##0.00") & "|"
                            det = det & Precio.ToString("#,##0.0000") & "|"
                            det = det & Importe.ToString("#,##0.00")
                            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

                        Else
                            'Misma partida
                            Dim det As String = "||||||"
                            det = det & Categoria & "|"
                            det = det & Kilos.ToString("#,##0.00") & "|"
                            det = det & Precio.ToString("#,##0.0000") & "|"
                            det = det & Importe.ToString("#,##0.00")
                            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

                        End If

                    End If

                Else
                    lstPartidasSinClasificar.Add(row)
                End If


                TotalKilosAlb = TotalKilosAlb + Kilos
                TotalKilosEntAgr = TotalKilosEntAgr + Kilos
                TotalKilosAlbaran = TotalKilosAlbaran + Kilos

                TotalImpAlb = TotalImpAlb + Importe
                TotalImpEntAgr = TotalImpEntAgr + Importe
                TotalImpAlbaran = TotalImpAlbaran + Importe


                AuxIdAgricultor = IdAgricultor
                AuxAgricultor = Agricultor
                AuxIdAlbaran = IdAlbaran
                AuxPartida = Partida
                AuxObs = Obs



                Application.DoEvents()

            Next

            If bObservaciones Then
                If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                    If AuxObs.Trim <> "" Then Listado.Detalle.Linea("|||Observ.: " & AuxObs & "|||||", DLin, Estilos.MinimaCursiva)
                End If
            End If


            If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then

                'Último total albarán
                Listado.Detalle.Linea("|||||||-------------||--------------", DLin, Estilos.ReducidaBold)
                Listado.Detalle.Linea("|||||||" & TotalKilosAlb.ToString("#,##0.00") & "||" & TotalImpAlb.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
                GastoAlb = GastosAlbaranEntrada(VaInt(AuxIdAlbaran), TotalKilosAlb, TotalImpAlb)

                ImprimirResumenPreciosClasificacionAlbaranes(Listado, AuxIdAlbaran, AuxIdAgricultor, TotalImpAlb, DcAgricultores, GastoAlb)


                'Ultimo total proveedor
                Listado.Detalle.Linea("", "191", Estilos.ReducidaBoldLineaDebajo)
                ImprimirResumenPreciosClasificacionAgricultores(Listado, AuxIdAgricultor, AuxAgricultor, TotalKilosEntAgr, DcAgricultores)

            End If

            'Partidas sin clasificar por agricultor
            Listado.Detalle.Linea("", "191", Estilos.Normal)
            ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "191")


        Catch ex As Exception

        End Try



        Return Listado

    End Function


    Private Sub C1_ListadoClasificacionesProveedorDesglosado_UnArchivo(dt As DataTable, Semana As String, Campa As String, Año As String, AgrDesde As String, AgrHasta As String,
                                                  FechaDesde As String, FechaHasta As String,
                                                  GenDesde As String, GenHasta As String,
                                                  lstEmpresas As List(Of String), bObservaciones As Boolean,
                                                  TipoEntrada As String, Valorados As String, lstRecogida As List(Of String),
                                                  bGenerarPDF As Boolean, bHojaPorCliente As Boolean,
                                                  Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar, Optional rutaPDF As String = "", Optional ArchivoPDF As String = "")




        If AgrDesde.Trim = "" Then AgrDesde = "00001"
        If AgrHasta.Trim = "" Then AgrHasta = "99999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"

        Dim Observaciones As String = ""
        If bObservaciones Then
            Observaciones = "SI"
        Else
            Observaciones = "NO"
        End If


        Dim Empresas As String = ""
        For Each s As String In lstEmpresas
            If Empresas <> "" Then Empresas = Empresas & ","
            Empresas = Empresas & s
        Next
        If Empresas = "" Then Empresas = "TODAS"


        Dim TextoTipoEntrada As String = ""
        If TipoEntrada = "F" Then
            TextoTipoEntrada = "Solo FIRME"
        ElseIf TipoEntrada = "C" Then
            TextoTipoEntrada = "Solo CONFECCION"
        ElseIf TipoEntrada = "S" Then
            TextoTipoEntrada = "Solo S/CLASIF."
        Else
            TextoTipoEntrada = "TODAS"
        End If
        TextoTipoEntrada = "Tipo de Entrada: " & TextoTipoEntrada


        Dim Recogida As String = ""
        For Each s As String In lstRecogida
            If Recogida <> "" Then Recogida = Recogida & ","
            Recogida = Recogida & s
        Next
        If Recogida = "" Then Recogida = "TODOS"



        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
            If rutaPDF.Trim = "" Then
                rutaPDF = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
            End If
            If rutaPDF.Trim <> "" Then rutaPDF = rutaPDF & "\"
        End If

        Dim Listado As New Listado()

        Listado.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.documento.PageLayout.PageSettings.Landscape = False
        Listado.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Listado.f.documento.PageLayout.PageSettings.LeftMargin = "8mm"
        Listado.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"



        Listado.EstableceListado(TipoImpresion)


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea("Resumen de Clasificaciones por Proveedor|Semana " & Semana & "|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "<85|<45|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Proveedor " & AgrDesde & " Hasta Proveedor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "110|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Mostrar observaciones: " & Observaciones, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Empresas: " & Empresas & "|" & TextoTipoEntrada, "115|>75", Estilos.NormalBold)
        Listado.Cabecera.Linea("C.Recogida: " & Recogida & "|Valorados: " & Valorados, "115|>75", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "12|<18|15|40|>15|4|30|>15|>21|>21"
        Dim Cabecera As String = "ALBAR|FECHA|PARTIDA|GENERO|KILOSENT||CAT./CAL.|KILOS|PRECIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosAlb As Decimal = 0
        Dim TotalKilosEntAgr As Decimal = 0
        Dim TotalKilosAlbaran As Decimal = 0
        Dim TotalImpAlb As Decimal = 0
        Dim TotalImpEntAgr As Decimal = 0
        Dim TotalImpAlbaran As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdAlbaran As String = ""
        Dim AuxPartida As String = ""
        Dim bCabecera As Boolean = True
        Dim bObs As Boolean = False
        Dim AuxObs As String = ""

        Dim DcAgricultoresClasif As New Dictionary(Of Integer, Boolean)
        Dim DcAgricultores As New Dictionary(Of Integer, TotalClasificacionDesglosado)


        Dim lstPartidasSinClasificar As New List(Of DataRow)


        Dim GastoAlb As Decimal = 0


        Try

            For Each row As DataRow In dt.Rows

                Dim Clasificada As String = (row("Clasif").ToString & "").Trim.ToUpper
                Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                If Clasificada = "S" Then DcAgricultoresClasif(IdAgricultor) = True


                Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                Dim Albaran As String = VaDec(row("Albaran")).ToString("000000")
                'Dim Partida As String = (row("Partida").ToString & "").Trim
                Dim Partida As String = VaDec(row("Partida")).ToString("00000000")
                Dim Cultivo As String = (row("Cultivo").ToString & "").Trim
                Dim Obs As String = (row("ObservacionesProveedor").ToString & "").Trim
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

                Dim Genero As String = (row("Genero").ToString & "").Trim

                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim KilosEnt As Decimal = VaDec(row("KilosEnt"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Importe As Decimal = VaDec(row("Importe"))

                Dim bCambioAgricultor As Boolean = (AuxIdAgricultor <> IdAgricultor And AuxIdAgricultor <> "")
                Dim bCambioAlbaran As Boolean = (IdAlbaran <> AuxIdAlbaran And AuxIdAlbaran <> "")
                Dim bCambioPartida As Boolean = (Partida <> AuxPartida And AuxPartida <> "")

                If bCambioAgricultor Then
                    bCambioAlbaran = True
                    bCambioPartida = True
                End If

                If bCambioAlbaran Then
                    bCambioPartida = True
                End If


                If bCambioPartida Then
                    If DcAgricultoresClasif.ContainsKey(IdAgricultor) Then
                        If bObservaciones Then
                            If AuxObs.Trim <> "" Then Listado.Detalle.Linea("|||Observ.: " & AuxObs & "|||||", DLin, Estilos.MinimaCursiva)
                        End If
                    End If
                End If


                If bCambioAlbaran Then

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                        'Resumen albarán anterior
                        Listado.Detalle.Linea("|||||||-------------||--------------", DLin, Estilos.ReducidaBold)
                        Listado.Detalle.Linea("|||||||" & TotalKilosAlb.ToString("#,##0.00") & "||" & TotalImpAlb.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
                    End If

                    GastoAlb = GastosAlbaranEntrada(VaInt(AuxIdAlbaran), TotalKilosAlb, TotalImpAlb)

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                        ImprimirResumenPreciosClasificacionAlbaranes(Listado, AuxIdAlbaran, AuxIdAgricultor, TotalImpAlb, DcAgricultores, GastoAlb)
                    End If

                    TotalKilosAlb = 0
                    TotalImpAlb = 0
                    bCabecera = True

                End If


                If bCambioAgricultor Then

                    If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then

                        'Resumen agricultor anterior
                        Listado.Detalle.Linea("", "191", Estilos.ReducidaBold)
                        Listado.Detalle.Linea("", "191", Estilos.ReducidaBoldLineaDebajo)

                        ImprimirResumenPreciosClasificacionAgricultores(Listado, AuxIdAgricultor, AuxAgricultor, TotalKilosEntAgr, DcAgricultores)
                        'Listado.Detalle.Linea("TOTAL|" & VaInt(AuxIdAgricultor).ToString("00000") & " " & AuxAgricultor & "|" & TotalKilosEntAgr.ToString("#,##0.00") & "||" & TotalImpEntAgr.ToString("#,##0.00"),
                        '                      "12|122|>15|21|>21", Estilos.ReducidaBold)

                    End If

                    'Partidas sin clasificar por agricultor
                    Listado.Detalle.Linea("", "191", Estilos.Normal)
                    ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "191")


                    TotalKilosEntAgr = 0
                    TotalImpEntAgr = 0

                    lstPartidasSinClasificar.Clear()


                    If AuxIdAgricultor <> "" Then

                        If bHojaPorCliente Then Listado.Detalle.SaltoPagina()

                        If bGenerarPDF Then
                            'Exportación a PDF (en caso de cliente por página)
                            If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
                                ArchivoPDF = "ListadoClasifD_" & VaInt(AuxIdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"

                                Dim dv As New DataView(dt)
                                dv.RowFilter = "IdAgricultor = " & AuxIdAgricultor
                                Dim dtClasif As DataTable = dv.ToTable

                                C1_ListadoClasificacionesProveedorDesglosado(dtClasif, Semana, Campa, Año, AuxIdAgricultor, AuxIdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                                   True, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                                dtClasif.Dispose()
                                dtClasif = Nothing

                            End If
                        End If

                    End If


                End If



                'Nuevo agricultor
                If IdAgricultor <> AuxIdAgricultor Then
                    Listado.Detalle.Linea("", "191", Estilos.ReducidaLineaDebajo)
                    Listado.Detalle.Linea(VaInt(IdAgricultor).ToString("00000") & "|" & Agricultor, "15|176", Estilos.NormalBoldLineaDebajo)
                End If


                If Clasificada = "S" Then

                    'Líneas de listado
                    If bCabecera Then
                        Dim det As String = Albaran & "|"
                        det = det & Fecha & "|"
                        det = det & Partida & "|"
                        det = det & Genero & "|"
                        det = det & KilosEnt.ToString("#,##0.00") & "||"
                        det = det & Categoria & "|"
                        det = det & Kilos.ToString("#,##0.00") & "|"
                        det = det & Precio.ToString("#,##0.0000") & "|"
                        det = det & Importe.ToString("#,##0.00")
                        Listado.Detalle.Linea(det, DLin, Estilos.Reducida)
                        bCabecera = False
                    Else

                        If Partida <> AuxPartida Then
                            'Cambio de partida
                            Dim det As String = "||"
                            det = det & Partida & "|"
                            det = det & Genero & "|"
                            det = det & KilosEnt.ToString("#,##0.00") & "||"
                            det = det & Categoria & "|"
                            det = det & Kilos.ToString("#,##0.00") & "|"
                            det = det & Precio.ToString("#,##0.0000") & "|"
                            det = det & Importe.ToString("#,##0.00")
                            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

                        Else
                            'Misma partida
                            Dim det As String = "||||||"
                            det = det & Categoria & "|"
                            det = det & Kilos.ToString("#,##0.00") & "|"
                            det = det & Precio.ToString("#,##0.0000") & "|"
                            det = det & Importe.ToString("#,##0.00")
                            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

                        End If

                    End If

                Else
                    lstPartidasSinClasificar.Add(row)
                End If


                TotalKilosAlb = TotalKilosAlb + Kilos
                TotalKilosEntAgr = TotalKilosEntAgr + Kilos
                TotalKilosAlbaran = TotalKilosAlbaran + Kilos

                TotalImpAlb = TotalImpAlb + Importe
                TotalImpEntAgr = TotalImpEntAgr + Importe
                TotalImpAlbaran = TotalImpAlbaran + Importe


                AuxIdAgricultor = IdAgricultor
                AuxAgricultor = Agricultor
                AuxIdAlbaran = IdAlbaran
                AuxPartida = Partida
                AuxObs = Obs



                Application.DoEvents()

            Next

            If bObservaciones Then
                If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then
                    If AuxObs.Trim <> "" Then Listado.Detalle.Linea("|||Observ.: " & AuxObs & "|||||", DLin, Estilos.MinimaCursiva)
                End If
            End If




            If bGenerarPDF Then
                'Exportación a PDF (en caso de cliente por página)
                If TipoImpresion <> NetAgro.TipoImpresion.ExportacionPDF Then
                    ArchivoPDF = "ListadoClasifD_" & VaInt(AuxIdAgricultor).ToString("00000") & "_" & VaInt(Campa).ToString("00") & "_" & Año & VaInt(Semana).ToString("00") & ".pdf"

                    Dim dv As New DataView(dt)
                    dv.RowFilter = "IdAgricultor = " & AuxIdAgricultor
                    Dim dtClasif As DataTable = dv.ToTable

                    C1_ListadoClasificacionesProveedorDesglosado(dtClasif, Semana, Campa, Año, AuxIdAgricultor, AuxIdAgricultor, FechaDesde, FechaHasta, GenDesde, GenHasta, lstEmpresas, bObservaciones, TipoEntrada, Valorados, lstRecogida, False,
                                                       True, NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)

                    dtClasif.Dispose()
                    dtClasif = Nothing

                End If
            End If


            If DcAgricultoresClasif.ContainsKey(AuxIdAgricultor) Then

                'Último total albarán
                Listado.Detalle.Linea("|||||||-------------||--------------", DLin, Estilos.ReducidaBold)
                Listado.Detalle.Linea("|||||||" & TotalKilosAlb.ToString("#,##0.00") & "||" & TotalImpAlb.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
                GastoAlb = GastosAlbaranEntrada(VaInt(AuxIdAlbaran), TotalKilosAlb, TotalImpAlb)

                ImprimirResumenPreciosClasificacionAlbaranes(Listado, AuxIdAlbaran, AuxIdAgricultor, TotalImpAlb, DcAgricultores, GastoAlb)


                'Ultimo total proveedor
                Listado.Detalle.Linea("", "191", Estilos.ReducidaBoldLineaDebajo)
                ImprimirResumenPreciosClasificacionAgricultores(Listado, AuxIdAgricultor, AuxAgricultor, TotalKilosEntAgr, DcAgricultores)

            End If

            'Partidas sin clasificar por agricultor
            Listado.Detalle.Linea("", "191", Estilos.Normal)
            ImprimePartidasSinClasificarAgricultor(Listado, lstPartidasSinClasificar, "191")


            'Previsualizar
            If TipoImpresion = NetAgro.TipoImpresion.ExportacionPDF Then
                Listado.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , rutaPDF, ArchivoPDF)
            Else
                Listado.Imprimir(TipoImpresion.Preliminar)
            End If

        Catch ex As Exception

        End Try


        'Listado.Dispose()


    End Sub


    Private Sub ImprimirResumenPreciosClasificacionAlbaranes(ByRef Listado As Listado, IdAlbaran As String, IdAgricultor As String, TotalGenero As Decimal,
                                                             ByRef DcAgricultores As Dictionary(Of Integer, TotalClasificacionDesglosado), OtrosGastos As Decimal)


        Dim DLin As String = "119|30|>21|>21"

        Dim tot As New TotalClasificacionDesglosado
        tot.TotalGenero = TotalGenero
        tot.OtrosGastos = OtrosGastos



        Dim TotalLiquido As Decimal = 0


        'IVA, Retención, Fondo operativo
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        If Agricultores.LeerId(IdAgricultor) Then

            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
            If TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor) Then

                Dim PorIVA As Decimal = VaDec(TipoAgricultor.TPA_poriva.Valor)
                Dim PorRet As Decimal = VaDec(TipoAgricultor.TPA_porret.Valor)
                Dim TipoRet As String = (TipoAgricultor.TPA_tiporet.Valor & "").Trim
                tot.PorRet = PorRet
                Dim PorFondo As Decimal = VaDec(TipoAgricultor.TPA_porfondo.Valor)
                Dim PorComision As Decimal = VaDec(TipoAgricultor.TPA_porcomision.Valor)
                tot.PorComision = PorComision
                Dim PorContingencia As Decimal = VaDec(TipoAgricultor.TPA_PorContingencia.Valor)


                'Canon
                Dim Comision As Decimal = TotalGenero * PorComision / 100
                tot.Comision = Comision



                'Base Imponible
                Dim BaseImponible As Decimal = TotalGenero - Comision - tot.OtrosGastos
                tot.BaseImponible = BaseImponible


                TotalLiquido = BaseImponible


                'IVA
                Dim CuotaIva As Decimal = BaseImponible * PorIVA / 100
                Dim TipoIva As New TipoIva("IVA " & PorIVA.ToString("#,##0.00"), CuotaIva)
                tot.lstTiposIVA.Add(TipoIva)


                'Retención
                Dim CuotaRet As Decimal = 0
                If TipoRet = "B" Then
                    CuotaRet = BaseImponible * PorRet / 100
                Else
                    CuotaRet = (BaseImponible + CuotaIva) * PorRet / 100
                End If
                tot.CuotaRet = CuotaRet


                'Fondo Operativo
                Dim CuotaFondo As Decimal = BaseImponible * PorFondo / 100
                tot.CuotaFondo = CuotaFondo



                'Contingencia
                Dim Contingencia As Decimal = BaseImponible * PorContingencia / 100
                tot.Contingencia = Contingencia

                TotalLiquido = BaseImponible + CuotaIva - CuotaRet - CuotaFondo - Contingencia

            End If
        End If


        tot.Liquido = TotalLiquido



        ''Comisión
        'Listado.Detalle.Linea("|Canon " & tot.PorComision.ToString("#,##0.00") & "%...||" & tot.Comision.ToString("#,##0.00"), DLin, Estilos.Reducida)
        ''BaseImponible
        'Listado.Detalle.Linea("|Base Imponible...||" & tot.BaseImponible.ToString("#,##0.00"), DLin, Estilos.Reducida)
        ''IVA
        'For Each Iva As TipoIva In tot.lstTiposIVA
        '    Listado.Detalle.Linea("|" & Iva.TipoIva & "%...||" & Iva.Importe.ToString("#,##0.00"), DLin, Estilos.Reducida)
        'Next
        ''CuotaRet
        'Listado.Detalle.Linea("|Retencion IRPF...||" & tot.CuotaRet.ToString("#,##0.00"), DLin, Estilos.Reducida)
        ''Fondo Operativo
        'Listado.Detalle.Linea("|Fondo Operativo...||" & tot.CuotaFondo.ToString("#,##0.00"), DLin, Estilos.Reducida)
        ''Total Líquido
        'Listado.Detalle.Linea("|TOTAL LIQUIDO...||" & tot.Liquido.ToString("#,##0.00"), DLin, Estilos.Reducida)


        If DcAgricultores.ContainsKey(IdAgricultor) Then
            Dim totAgr As TotalClasificacionDesglosado = DcAgricultores(IdAgricultor)
            totAgr.TotalGenero += tot.TotalGenero

            totAgr.PorComision = tot.PorComision
            totAgr.Comision += tot.Comision
            totAgr.BaseImponible += tot.BaseImponible

            For Each iva As TipoIva In tot.lstTiposIVA
                Dim bEncontrado As Boolean = False
                For Each iva_a In totAgr.lstTiposIVA
                    If iva_a.TipoIva = iva.TipoIva Then
                        iva_a.Importe += iva.Importe
                        bEncontrado = True
                    End If
                Next
                If Not bEncontrado Then
                    totAgr.lstTiposIVA.Add(iva)
                End If
            Next

            totAgr.CuotaRet += tot.CuotaRet
            totAgr.CuotaFondo += tot.CuotaFondo
            totAgr.Liquido += tot.Liquido
            totAgr.OtrosGastos += tot.OtrosGastos
            totAgr.Contingencia += tot.Contingencia

            DcAgricultores(IdAgricultor) = totAgr
        Else
            Dim totAgr As New TotalClasificacionDesglosado
            totAgr.TotalGenero = tot.TotalGenero
            totAgr.Comision = tot.Comision
            totAgr.BaseImponible = tot.BaseImponible
            For Each Iva In tot.lstTiposIVA
                totAgr.lstTiposIVA.Add(Iva)
            Next
            totAgr.PorRet = tot.PorRet
            totAgr.PorComision = tot.PorComision
            totAgr.CuotaRet = tot.CuotaRet
            totAgr.CuotaFondo = tot.CuotaFondo
            totAgr.Liquido = tot.Liquido
            totAgr.OtrosGastos = tot.OtrosGastos
            totAgr.Contingencia = tot.Contingencia
            DcAgricultores(IdAgricultor) = totAgr
        End If

        Listado.Detalle.Linea("", "150", Estilos.ReducidaBold)

    End Sub


    Private Sub ImprimirResumenPreciosClasificacionAgricultores(ByRef Listado As Listado, IdAgricultor As String, Agricultor As String, TotalKilosEntAgr As Decimal,
                                                                ByRef DcAgricultores As Dictionary(Of Integer, TotalClasificacionDesglosado))

        If DcAgricultores.ContainsKey(IdAgricultor) Then


            Dim DLin As String = "119|30|>21|>21"
            Dim tot As TotalClasificacionDesglosado = DcAgricultores(IdAgricultor)



            Listado.Detalle.Linea("TOTAL|" & VaInt(IdAgricultor).ToString("00000") & " " & Agricultor & "|" & TotalKilosEntAgr.ToString("#,##0.00") & "||" & tot.TotalGenero.ToString("#,##0.00"),
                                      "12|116|>21|21|>21", Estilos.ReducidaBold)


            'Comision
            Listado.Detalle.Linea("|Canon " & tot.PorComision.ToString("#,##0.00") & "%...|| -" & tot.Comision.ToString("#,##0.00"), DLin, Estilos.Reducida)
            'Portes
            Listado.Detalle.Linea("|Portes  || -" & tot.OtrosGastos.ToString("#,##0.00"), DLin, Estilos.Reducida)
            'BaseImponible
            Listado.Detalle.Linea("|Base Imponible...||" & tot.BaseImponible.ToString("#,##0.00"), DLin, Estilos.Reducida)
            'IVA
            For Each iva As TipoIva In tot.lstTiposIVA
                Listado.Detalle.Linea("|" & iva.TipoIva & "%...||" & iva.Importe.ToString("#,##0.00"), DLin, Estilos.Reducida)
            Next
            'CuotaRet
            Listado.Detalle.Linea("|Retencion IRPF " & tot.PorRet & "%...|| -" & tot.CuotaRet.ToString("#,##0.00"), DLin, Estilos.Reducida)
            'Fondo Operativo
            Listado.Detalle.Linea("|Fondo Operativo...|| -" & tot.CuotaFondo.ToString("#,##0.00"), DLin, Estilos.Reducida)
            'Contingencia (si existe)
            If tot.Contingencia <> 0 Then
                Listado.Detalle.Linea("|Fondo Contingencia...|| -" & tot.Contingencia.ToString("#,##0.00"), DLin, Estilos.Reducida)
            End If
            'Total Líquido
            Listado.Detalle.Linea("|T. LIQUIDO AGR...||" & tot.Liquido.ToString("#,##0.00"), DLin, Estilos.ReducidaBoldLineaDebajo)



        End If

    End Sub



    Private Sub AcumulaCategorias(IdTipoCat As Integer, IdGenero As Integer, Kilos As Decimal,
                                  ByRef DcTiposCatAgr As Dictionary(Of Integer, Decimal),
                                  ByRef lstGenerosAgr As List(Of Integer),
                                  ByRef DcTiposCatGenAgr As Dictionary(Of Integer, Dictionary(Of Integer, Decimal)))


        'Acumula por agricultor
        If DcTiposCatAgr.ContainsKey(IdTipoCat) Then
            DcTiposCatAgr(IdTipoCat) = DcTiposCatAgr(IdTipoCat) + Kilos
        Else
            DcTiposCatAgr(IdTipoCat) = Kilos
        End If

        'Acumula por género
        If DcTiposCatGenAgr.ContainsKey(IdGenero) Then
            Dim Dc As Dictionary(Of Integer, Decimal) = DcTiposCatGenAgr(IdGenero)
            If Dc.ContainsKey(IdTipoCat) Then
                Dc(IdTipoCat) = Dc(IdTipoCat) + Kilos
            Else
                Dc(IdTipoCat) = Kilos
            End If
            DcTiposCatGenAgr(IdGenero) = Dc
        Else
            Dim Dc As New Dictionary(Of Integer, Decimal)
            Dc(IdTipoCat) = Kilos
            DcTiposCatGenAgr(IdGenero) = Dc
            lstGenerosAgr.Add(IdGenero)
        End If


    End Sub


    Private Sub AcumulaPartidas(IdTipoCat As Integer, Kilos As Decimal, DcTiposCatPar As Dictionary(Of Integer, Decimal))

        If DcTiposCatPar.ContainsKey(IdTipoCat) Then
            DcTiposCatPar(IdTipoCat) = DcTiposCatPar(IdTipoCat) + Kilos
        Else
            DcTiposCatPar(IdTipoCat) = Kilos
        End If

    End Sub


    Private Sub ImprimeResumenCategorias(Listado As Listado, lstTiposCat As List(Of Integer),
                                                DcTiposCat As Dictionary(Of Integer, String),
                                                DcImportesTiposCat As Dictionary(Of Integer, Decimal),
                                                TotalAlbaran As Decimal)


        Dim DLinTipoCat As String = "=34|=34|=34|=34|=34"


        Dim Total1 As Decimal = 0
        Dim Total2 As Decimal = 0
        Dim Total3 As Decimal = 0
        Dim Total4 As Decimal = 0
        Dim Total5 As Decimal = 0

        Dim Nombre1 As String = ""
        Dim Nombre2 As String = ""
        Dim Nombre3 As String = ""
        Dim Nombre4 As String = ""
        Dim Nombre5 As String = ""

        Dim Porcentaje1 As Decimal = 0
        Dim Porcentaje2 As Decimal = 0
        Dim Porcentaje3 As Decimal = 0
        Dim Porcentaje4 As Decimal = 0
        Dim Porcentaje5 As Decimal = 0



        If lstTiposCat.Count > 0 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(0)) Then
                Total1 = DcImportesTiposCat(lstTiposCat(0))
            End If
            Nombre1 = DcTiposCat(lstTiposCat(0))
            If TotalAlbaran <> 0 Then Porcentaje1 = Total1 / TotalAlbaran * 100
        End If
        If lstTiposCat.Count > 1 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(1)) Then
                Total2 = DcImportesTiposCat(lstTiposCat(1))
            End If
            Nombre2 = DcTiposCat(lstTiposCat(1))
            If TotalAlbaran <> 0 Then Porcentaje2 = Total2 / TotalAlbaran * 100
        End If
        If lstTiposCat.Count > 2 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(2)) Then
                Total3 = DcImportesTiposCat(lstTiposCat(2))
            End If
            Nombre3 = DcTiposCat(lstTiposCat(2))
            If TotalAlbaran <> 0 Then Porcentaje3 = Total3 / TotalAlbaran * 100
        End If
        If lstTiposCat.Count > 3 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(3)) Then
                Total4 = DcImportesTiposCat(lstTiposCat(3))
            End If
            Nombre4 = DcTiposCat(lstTiposCat(3))
            If TotalAlbaran <> 0 Then Porcentaje4 = Total4 / TotalAlbaran * 100
        End If
        If lstTiposCat.Count > 4 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(4)) Then
                Total5 = DcImportesTiposCat(lstTiposCat(4))
            End If
            Nombre5 = DcTiposCat(lstTiposCat(4))
            If TotalAlbaran <> 0 Then Porcentaje5 = Total5 / TotalAlbaran * 100
        End If


        Dim strTotal1 As String = "" : If Total1 <> 0 Then strTotal1 = Total1.ToString("#,##0.00")
        Dim strTotal2 As String = "" : If Total2 <> 0 Then strTotal2 = Total2.ToString("#,##0.00")
        Dim strTotal3 As String = "" : If Total3 <> 0 Then strTotal3 = Total3.ToString("#,##0.00")
        Dim strTotal4 As String = "" : If Total4 <> 0 Then strTotal4 = Total4.ToString("#,##0.00")
        Dim strTotal5 As String = "" : If Total5 <> 0 Then strTotal5 = Total5.ToString("#,##0.00")


        Listado.Detalle.Linea("TOTAL " & Nombre1 & "|" & "TOTAL " & Nombre2 & "|" & "TOTAL " & Nombre3 & "|" & "TOTAL " & Nombre4 & "|" & "TOTAL " & Nombre5,
                              DLinTipoCat, Estilos.ReducidaBold)

        Listado.Detalle.Linea(strTotal1 & " (" & Porcentaje1.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal2 & " (" & Porcentaje2.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal3 & " (" & Porcentaje3.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal4 & " (" & Porcentaje4.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal5 & " (" & Porcentaje5.ToString("#,##0.00") & "%" & ")",
                              DLinTipoCat, Estilos.ReducidaLineaDebajo)
        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)


    End Sub


    Private Sub ImprimeResumenCategoriasPartida(Listado As Listado,
                                               lstTiposCat As List(Of Integer), DcTiposCat As Dictionary(Of Integer, String),
                                               ByRef DcImportesTiposCat As Dictionary(Of Integer, Decimal))



        Dim DLinTipoCat As String = "=34|=34|=34|=34|=34"

        Dim Total1 As Decimal = 0
        Dim Total2 As Decimal = 0
        Dim Total3 As Decimal = 0
        Dim Total4 As Decimal = 0
        Dim Total5 As Decimal = 0

        Dim Nombre1 As String = ""
        Dim Nombre2 As String = ""
        Dim Nombre3 As String = ""
        Dim Nombre4 As String = ""
        Dim Nombre5 As String = ""

        Dim Porcentaje1 As Decimal = 0
        Dim Porcentaje2 As Decimal = 0
        Dim Porcentaje3 As Decimal = 0
        Dim Porcentaje4 As Decimal = 0
        Dim Porcentaje5 As Decimal = 0



        Dim Total As Decimal = 0

        For Each clave As Integer In DcImportesTiposCat.Keys
            Total = Total + DcImportesTiposCat(clave)
        Next


        If lstTiposCat.Count > 0 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(0)) Then
                Total1 = DcImportesTiposCat(lstTiposCat(0))
            End If
            Nombre1 = DcTiposCat(lstTiposCat(0))
            If Total <> 0 Then Porcentaje1 = Total1 / Total * 100
        End If
        If lstTiposCat.Count > 1 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(1)) Then
                Total2 = DcImportesTiposCat(lstTiposCat(1))
            End If
            Nombre2 = DcTiposCat(lstTiposCat(1))
            If Total <> 0 Then Porcentaje2 = Total2 / Total * 100
        End If
        If lstTiposCat.Count > 2 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(2)) Then
                Total3 = DcImportesTiposCat(lstTiposCat(2))
            End If
            Nombre3 = DcTiposCat(lstTiposCat(2))
            If Total <> 0 Then Porcentaje3 = Total3 / Total * 100
        End If
        If lstTiposCat.Count > 3 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(3)) Then
                Total4 = DcImportesTiposCat(lstTiposCat(3))
            End If
            Nombre4 = DcTiposCat(lstTiposCat(3))
            If Total <> 0 Then Porcentaje4 = Total4 / Total * 100
        End If
        If lstTiposCat.Count > 4 Then
            If DcImportesTiposCat.ContainsKey(lstTiposCat(4)) Then
                Total5 = DcImportesTiposCat(lstTiposCat(4))
            End If
            Nombre5 = DcTiposCat(lstTiposCat(4))
            If Total <> 0 Then Porcentaje5 = Total5 / Total * 100
        End If


        Dim strTotal1 As String = "" : If Total1 <> 0 Then strTotal1 = Total1.ToString("#,##0.00")
        Dim strTotal2 As String = "" : If Total2 <> 0 Then strTotal2 = Total2.ToString("#,##0.00")
        Dim strTotal3 As String = "" : If Total3 <> 0 Then strTotal3 = Total3.ToString("#,##0.00")
        Dim strTotal4 As String = "" : If Total4 <> 0 Then strTotal4 = Total4.ToString("#,##0.00")
        Dim strTotal5 As String = "" : If Total5 <> 0 Then strTotal5 = Total5.ToString("#,##0.00")

        'Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
        'Listado.Detalle.Linea("TOTAL PARTIDA|", "105|65", Estilos.ReducidaLineaDebajo)

        Listado.Detalle.Linea("RESUMEN PARTIDA", "170", Estilos.ReducidaLineaDebajo)
        Listado.Detalle.Linea("TOTAL " & Nombre1 & "|" & "TOTAL " & Nombre2 & "|" & "TOTAL " & Nombre3 & "|" & "TOTAL " & Nombre4 & "|" & "TOTAL " & Nombre5,
                              DLinTipoCat, Estilos.Reducida)

        Listado.Detalle.Linea(strTotal1 & " (" & Porcentaje1.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal2 & " (" & Porcentaje2.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal3 & " (" & Porcentaje3.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal4 & " (" & Porcentaje4.ToString("#,##0.00") & "%" & ")" & "|" & _
                              strTotal5 & " (" & Porcentaje5.ToString("#,##0.00") & "%" & ")",
                              DLinTipoCat, Estilos.ReducidaLineaDebajo)
        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
        Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)


    End Sub


    Private Sub ImprimeResumenCategoriasGenero(Listado As Listado, IdGenero As Integer,
                                               DcGeneros As Dictionary(Of Integer, String),
                                               lstTiposCat As List(Of Integer), DcTiposCat As Dictionary(Of Integer, String),
                                               ByRef DcTiposCatGenAgr As Dictionary(Of Integer, Dictionary(Of Integer, Decimal)))


        If DcTiposCatGenAgr.ContainsKey(IdGenero) Then


            Dim DLinTipoCat As String = "=34|=34|=34|=34|=34"

            Dim Total1 As Decimal = 0
            Dim Total2 As Decimal = 0
            Dim Total3 As Decimal = 0
            Dim Total4 As Decimal = 0
            Dim Total5 As Decimal = 0

            Dim Nombre1 As String = ""
            Dim Nombre2 As String = ""
            Dim Nombre3 As String = ""
            Dim Nombre4 As String = ""
            Dim Nombre5 As String = ""

            Dim Porcentaje1 As Decimal = 0
            Dim Porcentaje2 As Decimal = 0
            Dim Porcentaje3 As Decimal = 0
            Dim Porcentaje4 As Decimal = 0
            Dim Porcentaje5 As Decimal = 0

            Dim NombreGenero As String = ""
            If DcGeneros.ContainsKey(IdGenero) Then NombreGenero = DcGeneros(IdGenero)


            Dim DcImportesTiposCat As Dictionary(Of Integer, Decimal) = DcTiposCatGenAgr(IdGenero)
            Dim Total As Decimal = 0

            For Each clave As Integer In DcImportesTiposCat.Keys
                Total = Total + DcImportesTiposCat(clave)
            Next


            If lstTiposCat.Count > 0 Then
                If DcImportesTiposCat.ContainsKey(lstTiposCat(0)) Then
                    Total1 = DcImportesTiposCat(lstTiposCat(0))
                End If
                Nombre1 = DcTiposCat(lstTiposCat(0))
                If Total <> 0 Then Porcentaje1 = Total1 / Total * 100
            End If
            If lstTiposCat.Count > 1 Then
                If DcImportesTiposCat.ContainsKey(lstTiposCat(1)) Then
                    Total2 = DcImportesTiposCat(lstTiposCat(1))
                End If
                Nombre2 = DcTiposCat(lstTiposCat(1))
                If Total <> 0 Then Porcentaje2 = Total2 / Total * 100
            End If
            If lstTiposCat.Count > 2 Then
                If DcImportesTiposCat.ContainsKey(lstTiposCat(2)) Then
                    Total3 = DcImportesTiposCat(lstTiposCat(2))
                End If
                Nombre3 = DcTiposCat(lstTiposCat(2))
                If Total <> 0 Then Porcentaje3 = Total3 / Total * 100
            End If
            If lstTiposCat.Count > 3 Then
                If DcImportesTiposCat.ContainsKey(lstTiposCat(3)) Then
                    Total4 = DcImportesTiposCat(lstTiposCat(3))
                End If
                Nombre4 = DcTiposCat(lstTiposCat(3))
                If Total <> 0 Then Porcentaje4 = Total4 / Total * 100
            End If
            If lstTiposCat.Count > 4 Then
                If DcImportesTiposCat.ContainsKey(lstTiposCat(4)) Then
                    Total5 = DcImportesTiposCat(lstTiposCat(4))
                End If
                Nombre5 = DcTiposCat(lstTiposCat(4))
                If Total <> 0 Then Porcentaje5 = Total5 / Total * 100
            End If


            Dim strTotal1 As String = "" : If Total1 <> 0 Then strTotal1 = Total1.ToString("#,##0.00")
            Dim strTotal2 As String = "" : If Total2 <> 0 Then strTotal2 = Total2.ToString("#,##0.00")
            Dim strTotal3 As String = "" : If Total3 <> 0 Then strTotal3 = Total3.ToString("#,##0.00")
            Dim strTotal4 As String = "" : If Total4 <> 0 Then strTotal4 = Total4.ToString("#,##0.00")
            Dim strTotal5 As String = "" : If Total5 <> 0 Then strTotal5 = Total5.ToString("#,##0.00")

            Listado.Detalle.Linea("", "170", Estilos.ReducidaBoldLineaDebajo)
            Listado.Detalle.Linea("TOTAL " & _
                                  NombreGenero & "|" & _
                                  "Total producto: " & Total.ToString("#,##0.00"), "105|65", Estilos.ReducidaLineaDebajo)


            Listado.Detalle.Linea("TOTAL " & Nombre1 & "|" & "TOTAL " & Nombre2 & "|" & "TOTAL " & Nombre3 & "|" & "TOTAL " & Nombre4 & "|" & "TOTAL " & Nombre5,
                                  DLinTipoCat, Estilos.Reducida)

            Listado.Detalle.Linea(strTotal1 & " (" & Porcentaje1.ToString("#,##0.00") & "%" & ")" & "|" & _
                                  strTotal2 & " (" & Porcentaje2.ToString("#,##0.00") & "%" & ")" & "|" & _
                                  strTotal3 & " (" & Porcentaje3.ToString("#,##0.00") & "%" & ")" & "|" & _
                                  strTotal4 & " (" & Porcentaje4.ToString("#,##0.00") & "%" & ")" & "|" & _
                                  strTotal5 & " (" & Porcentaje5.ToString("#,##0.00") & "%" & ")",
                                  DLinTipoCat, Estilos.ReducidaLineaDebajo)
            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)



        End If



    End Sub



    Private Function GastosAlbaranEntrada(idalbaran As Integer, Kilos As Decimal, ImpAlbaran As Decimal) As Decimal

        Dim sql As String = "Select AEG_Gasto as Gasto,AEG_Tipo as Tipo from albentrada_gastos where AEG_idalbaran=" + idalbaran.ToString + " and AEG_tipoFC='F'"
        Dim dt As DataTable = cn.ConsultaSQL(sql)
        Dim igasto As Decimal = 0

        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Select Case rw("Tipo").ToString
                    Case "K"
                        igasto = igasto + Kilos * VaDec(rw("Gasto"))
                    Case "%"
                        igasto = igasto + ImpAlbaran * VaDec(rw("Gasto")) / 100
                    Case "I"
                        igasto = igasto + VaDec(rw("Gasto"))

                End Select
            Next

        End If

        Return igasto


    End Function



    Private Sub ImprimePartidasSinClasificarAgricultor(ByRef Listado As Listado, ByVal lstPartidasSinClasificar As List(Of DataRow), ancho As String)


        If lstPartidasSinClasificar.Count > 0 Then

            Dim DLin As String = "18|18|18|=15|=15|" & (VaInt(ancho) - 105).ToString & "|>21"
            Dim Cabecera As String = "ALBARAN|CULTIVO|PARTIDA|FECHA|COD|GENERO|KILOSENT"


            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
            Listado.Detalle.Linea("PARTIDAS SIN CLASIFICAR: ", ancho, Estilos.NormalBold)
            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
            Listado.Detalle.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)

            Dim TotalKilosEnt As Decimal = 0

            For Each row As DataRow In lstPartidasSinClasificar

                Dim Albaran As String = VaDec(row("Albaran")).ToString("000000")
                Dim Cultivo As String = (row("Cultivo").ToString & "").Trim
                Dim Partida As String = VaDec(row("Partida")).ToString("00000000")
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim KilosEnt As Decimal = VaDec(row("KilosEnt"))

                TotalKilosEnt = TotalKilosEnt + KilosEnt

                Dim det As String = Albaran & "|"
                det = det & Cultivo & "|"
                det = det & Partida & "|"
                det = det & Fecha & "|"
                det = det & IdGenero & "|"
                det = det & Genero & "|"
                det = det & KilosEnt.ToString("#,##0.00")

                Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            Next

            'Total
            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
            Listado.Detalle.Linea(TotalKilosEnt.ToString("#,##0.00"), ">" & ancho, Estilos.ReducidaBoldLineaEncima)

            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)
            Listado.Detalle.Linea("", "170", Estilos.ReducidaBold)

        End If


    End Sub


    Private Function AgricultorConClasificacion(DcTiposCatAgr As Dictionary(Of Integer, Decimal)) As Boolean

        Dim bRes As Boolean = False


        For Each clave As Integer In DcTiposCatAgr.Keys
            If clave > 0 Then
                bRes = True
                Exit For
            End If
        Next


        Return bRes

    End Function



End Module
