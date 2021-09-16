Public Class Listado_ListadoAlbaranesEntrada
    Inherits Listado_ImpresionBase


    Property Datos As DataTable
    Property AgrDesde As String
    Property AgrHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property AlbDesde As String
    Property AlbHasta As String
    Property GenDesde As String
    Property GenHasta As String
    Property CatDesde As String
    Property CatHasta As String
    Property LstEmpresas As List(Of String)
    Property LstCentroRecogida As List(Of String)
    Property TipoEntrada As String
    Property TipoGenero As String
    Property Facturados As String
    Property BIncluirSinCategoria As Boolean
    Property BMostrarAlbaranes As Boolean
    Property TipoListado As Integer
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal datos As DataTable, ByVal agrDesde As String, ByVal agrHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal albDesde As String, ByVal albHasta As String, _
                   ByVal genDesde As String, ByVal genHasta As String, ByVal catDesde As String, ByVal catHasta As String, _
                   ByVal lstEmpresas As List(Of String), ByVal lstCentroRecogida As List(Of String), _
                   ByVal tipoEntrada As String, ByVal tipoGenero As String, ByVal facturados As String, _
                   ByVal bIncluirSinCategoria As Boolean, ByVal bMostrarAlbaranes As Boolean, ByVal tipoListado As Integer,
                   ByVal TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.AgrDesde = agrDesde
        Me.AgrHasta = agrHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.AlbDesde = albDesde
        Me.AlbHasta = albHasta
        Me.GenDesde = genDesde
        Me.GenHasta = genHasta
        Me.CatDesde = catDesde
        Me.CatHasta = catHasta
        Me.LstEmpresas = lstEmpresas
        Me.LstCentroRecogida = lstCentroRecogida
        Me.TipoEntrada = tipoEntrada
        Me.TipoGenero = tipoGenero
        Me.Facturados = facturados
        Me.BIncluirSinCategoria = bIncluirSinCategoria
        Me.BMostrarAlbaranes = bMostrarAlbaranes
        Me.TipoListado = tipoListado
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        If AgrDesde.Trim = "" Then AgrDesde = "00001"
        If AgrHasta.Trim = "" Then AgrHasta = "99999"
        If AlbDesde.Trim = "" Then AlbDesde = "000001"
        If AlbHasta.Trim = "" Then AlbHasta = "999999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"
        If CatDesde.Trim = "" Then CatDesde = "001"
        If CatHasta.Trim = "" Then CatHasta = "999"

        MargenSup = 10
        MargenIzq = 10

        EstableceListado(Orientacion.Vertical, TipoImpresion)


        Try

            Select Case TipoListado
                Case 0
                    ConfigurarListadoDetalladoAlbaranesEntrada(True)
                Case 1
                    ConfigurarListadoDetalladoAlbaranesEntrada(False)
                Case 2
                    ConfigurarListadoResumidoAlbaranesEntrada()
                Case 3
                    ConfigurarListadoResumidoGeneroAlbaranesEntrada()
                Case 4
                    ConfigurarListadoResumidoGeneroYFincaAlbaranesEntrada()
                Case 5
                    ConfigurarListadoResumidoGenero()
            End Select


            Previsualiza()


        Catch ex As Exception

        End Try

    End Sub



    Private Sub ConfigurarListadoDetalladoAlbaranesEntrada(ByVal bClasificado As Boolean)

        Dim IncluirSinCat As String = ""
        If BIncluirSinCategoria Then IncluirSinCat = "Incluir Sin Categoría"

        Dim CentroRecogida As String = ""
        For Each s As String In LstCentroRecogida
            If CentroRecogida <> "" Then CentroRecogida = CentroRecogida & ","
            CentroRecogida = CentroRecogida & s
        Next

        Dim Empresa As String = ""
        For Each s As String In LstEmpresas
            If Empresa <> "" Then Empresa = Empresa & ","
            Empresa = Empresa & s
        Next

        If CentroRecogida = "" Then CentroRecogida = "TODOS"
        If Empresa = "" Then Empresa = "TODAS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        If bClasificado Then
            Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO DETALLADO CON CLASIFICACIÓN|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Else
            Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO DETALLADO SIN CLASIFICACIÓN|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        End If
        Listado.Cabecera.Linea("Desde Agricultor " & AgrDesde & " Hasta Agricultor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "|" & IncluirSinCat, "95|>95", Estilos.NormalBold)
        If CentroRecogida <> "" Or Empresa <> "" Then
            Listado.Cabecera.Linea("Centro Recogida: " & CentroRecogida & "|" & "Empresa: " & Empresa, "95|>95", Estilos.NormalBold)
        End If
        If TipoEntrada <> "" Or TipoGenero <> "" Then
            Listado.Cabecera.Linea("Tipo de Entrada: " & TipoEntrada & "|" & "Tipo de Género: " & TipoGenero, "95|>95", Estilos.NormalBold)
        End If
        If Facturados <> "" Then Listado.Cabecera.Linea("Alb. Facturados: " & Facturados, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinAgr As String = "18|100|>15|>20|>15|>23"
        'Dim DLin As String = "18|18|20|41|2|16|2|>15|>20|>15|>23"
        Dim DLin As String = "15|18|18|31|2|13|2|=4|15|>15|>20|>15|>23"
        Dim Cabecera As String = ""
        If Not bClasificado Then
            Cabecera = "ALBARÁN|FECHA|PARTIDA|GENERO||CT/CL||C|PROG|BULTOS|KILOS|PRECIO|IMPORTE"
        Else
            Cabecera = "ALBARÁN|FECHA|PARTIDA|GENERO||CT/CL||C|PROG||KILOS|PRECIO|IMPORTE"
        End If

        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalBultosAlb As Integer = 0
        Dim TotalKilosAlb As Decimal = 0
        Dim TotalImporteAlb As Decimal = 0

        Dim TotalBultosAgr As Integer = 0
        Dim TotalKilosAgr As Decimal = 0
        Dim TotalImporteAgr As Decimal = 0

        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdAlbaran As String = ""
        Dim AuxPartida As String = ""

        For Each row As DataRow In Datos.Rows

            Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
            Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
            Dim Agricultor As String = (row("Agricultor").ToString & "").Trim

            Dim Bultos As Integer = 0
            If Not bClasificado Then Bultos = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))

            Dim IdPuntoVenta As String = VaInt(row("PV")).ToString("00")
            Dim Albaran As String = IdPuntoVenta & "-" & VaInt(row("Albaran")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Partida As String = row("Partida").ToString & ""
            Dim Genero As String = row("Genero").ToString
            Dim Observaciones As String = row("Observaciones").ToString
            Dim categoria As String = ""
            If bClasificado Then categoria = row("Categoria").ToString
            Dim Precio As String = VaDec(row("Precio")).ToString("#,##0.000")
            Dim Controlado As String = (row("Controlado").ToString & "").Trim
            Dim Programa As String = (row("Programa").ToString & "").Trim

            If IdAlbaran <> AuxIdAlbaran Or (IdAgricultor <> AuxIdAgricultor And VaInt(AuxIdAgricultor) <> 0) Then
                If AuxIdAlbaran <> "" Then
                    'Resumen albarán anterior
                    If bClasificado Then
                        Listado.Detalle.Linea("|||----------||----------------", DLinAgr, Estilos.ReducidaBold)
                        Listado.Detalle.Linea("|Total Albarán...|" & _
                                             "| " & _
                                              TotalKilosAlb.ToString("#,##0.00") & "|" & _
                                              "|" & _
                                              TotalImporteAlb.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)
                    Else
                        Listado.Detalle.Linea("||-------|----------||----------------", DLinAgr, Estilos.ReducidaBold)
                        Listado.Detalle.Linea("|Total Albarán...|" & _
                                              TotalBultosAlb.ToString("#,##0") & "|" & _
                                              TotalKilosAlb.ToString("#,##0.00") & "||" & _
                                              TotalImporteAlb.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)
                    End If
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)


                    TotalBultosAlb = 0
                    TotalKilosAlb = 0
                    TotalImporteAlb = 0
                End If
            Else
                Albaran = ""
                Fecha = ""
            End If

            If IdAgricultor <> AuxIdAgricultor Then
                If AuxIdAgricultor <> "" Then
                    'Resumen agricultor anterior
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                    Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                          AuxAgricultor & "|" & _
                                           " |" & _
                                          TotalKilosAgr.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalBultosAgr = 0
                    TotalKilosAgr = 0
                    TotalImporteAgr = 0
                End If
            End If

            'Líneas de listado
            Dim det As String = Albaran & "|"
            det = det & Fecha & "|"
            det = det & Partida & "|"
            det = det & Genero & "||"
            det = det & categoria & "||"
            det = det & Controlado & "|"
            det = det & Programa & "|"
            If bClasificado Then
                det = det & " |"
            Else
                det = det & Bultos.ToString("#,##0") & "|"
            End If
            det = det & Kilos.ToString("#,##0.00") & "|"
            det = det & Precio & "|"
            det = det & Importe.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            If Observaciones.Trim <> "" And AuxPartida <> Partida Then
                Listado.Detalle.Linea("||" & Observaciones & "|||||||", DLin, Estilos.MinimaCursiva)
            End If

            TotalBultosAlb = TotalBultosAlb + Bultos
            TotalKilosAlb = TotalKilosAlb + Kilos
            TotalImporteAlb = TotalImporteAlb + Importe

            TotalBultosAgr = TotalBultosAgr + Bultos
            TotalKilosAgr = TotalKilosAgr + Kilos
            TotalImporteAgr = TotalImporteAgr + Importe

            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe

            AuxIdAgricultor = IdAgricultor
            AuxAgricultor = Agricultor
            AuxIdAlbaran = IdAlbaran
            AuxPartida = Partida


            Application.DoEvents()

        Next

        'Último total del albarán
        If bClasificado Then
            Listado.Detalle.Linea("|||----------||----------------", DLinAgr, Estilos.ReducidaBold)
            Listado.Detalle.Linea("|Total Albarán...|" & _
                                  " |" & _
                                  TotalKilosAlb.ToString("#,##0.00") & "|" & _
                                  "|" & _
                                  TotalImporteAlb.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)
        Else
            Listado.Detalle.Linea("||-------|----------||----------------", DLinAgr, Estilos.ReducidaBold)
            Listado.Detalle.Linea("|Total Albarán...|" & _
                                  TotalBultosAlb.ToString("#,##0") & "|" & _
                                  TotalKilosAlb.ToString("#,##0.00") & "||" & _
                                  TotalImporteAlb.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)
        End If
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)


        'Último total del agricultor
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        If Not bClasificado Then
            Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                  AuxAgricultor & "|" & _
                                  TotalBultosAgr.ToString("#,##0") & "|" & _
                                  TotalKilosAgr.ToString("#,##0.00") & "|" & _
                                  "|" & _
                                  TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)
        Else
            Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                              AuxAgricultor & "||" & _
                              TotalKilosAgr.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)
        End If

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        If Not bClasificado Then
            Listado.Detalle.Linea("|TOTAL LISTADO...|" & _
                                  TotalBultos.ToString("#,##0") & "|" & _
                                  TotalKilos.ToString("#,##0.00") & "|" & _
                                  "|" & _
                                  TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)
        Else
            Listado.Detalle.Linea("|TOTAL LISTADO...||" & _
                                  TotalKilos.ToString("#,##0.00") & "|" & _
                                  "|" & _
                                  TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)

        End If

    End Sub

    Private Sub ConfigurarListadoResumidoAlbaranesEntrada()
        Dim IncluirSinCat As String = ""
        If BIncluirSinCategoria Then IncluirSinCat = "Incluir Sin Categoría"

        Dim CentroRecogida As String = ""

        For Each s As String In LstCentroRecogida
            If CentroRecogida <> "" Then CentroRecogida = CentroRecogida & ","
            CentroRecogida = CentroRecogida & s
        Next

        Dim Empresa As String = ""
        For Each s As String In LstEmpresas
            If Empresa <> "" Then Empresa = Empresa & ","
            Empresa = Empresa & s
        Next

        If CentroRecogida = "" Then CentroRecogida = "TODOS"
        If Empresa = "" Then Empresa = "TODAS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO RESUMIDO|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Agricultor " & AgrDesde & " Hasta Agricultor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "|" & IncluirSinCat, "95|>95", Estilos.NormalBold)
        If CentroRecogida <> "" Or Empresa <> "" Then
            Listado.Cabecera.Linea("Centro Recogida: " & CentroRecogida & "|" & "Empresa: " & Empresa, "95|>95", Estilos.NormalBold)
        End If
        If TipoEntrada <> "" Or TipoGenero <> "" Then
            Listado.Cabecera.Linea("Tipo de Entrada: " & TipoEntrada & "|" & "Tipo de Género: " & TipoGenero, "95|>95", Estilos.NormalBold)
        End If
        If Facturados <> "" Then Listado.Cabecera.Linea("Alb. Facturados: " & Facturados, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinAgr As String = "18|99|>15|>20|>15|>23"
        Dim DLin As String = "18|18|61|2|16|2|>15|>20|>15|>23"
        Dim Cabecera As String = "ALBARÁN|FECHA|GENERO||CT/CL||BULTOS|KILOS|PRECIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalBultosAgr As Integer = 0
        Dim TotalKilosAgr As Decimal = 0
        Dim TotalImporteAgr As Decimal = 0

        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""

        For Each row As DataRow In Datos.Rows
            Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
            Dim Agricultor As String = (row("Agricultor").ToString & "").Trim

            '   Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))

            Dim IdPuntoVenta As String = VaInt(row("PV")).ToString("00")
            Dim Albaran As String = IdPuntoVenta & "-" & VaInt(row("Albaran")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

            If IdAgricultor <> AuxIdAgricultor Then
                If AuxIdAgricultor <> "" Then
                    'Resumen agricultor anterior
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                    Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                          AuxAgricultor & "|" & _
                                          TotalBultosAgr.ToString("#,##0") & "|" & _
                                          TotalKilosAgr.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalBultosAgr = 0
                    TotalKilosAgr = 0
                    TotalImporteAgr = 0
                End If
            End If

            'Líneas de listado
            If BMostrarAlbaranes Then
                Dim det As String = Albaran & "|"
                det = det & Fecha & "|"
                det = det & "||"
                det = det & "||"
                det = det & " |" ' Bultos.ToString("#,##0") & "|"
                det = det & Kilos.ToString("#,##0.00") & "|"
                det = det & "|"
                det = det & Importe.ToString("#,##0.00")
                Listado.Detalle.Linea(det, DLin, Estilos.Reducida)
            End If

            ' TotalBultosAgr = TotalBultosAgr + Bultos
            TotalKilosAgr = TotalKilosAgr + Kilos
            TotalImporteAgr = TotalImporteAgr + Importe

            '  TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe

            AuxIdAgricultor = IdAgricultor
            AuxAgricultor = Agricultor


            Application.DoEvents()

        Next

        'Último total del agricultor
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                              AuxAgricultor & "|" & _
                              TotalBultosAgr.ToString("#,##0") & "|" & _
                              TotalKilosAgr.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("|TOTAL LISTADO...|" & _
                              TotalBultos.ToString("#,##0") & "|" & _
                              TotalKilos.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfigurarListadoResumidoGeneroAlbaranesEntrada()
        Dim IncluirSinCat As String = ""
        If BIncluirSinCategoria Then IncluirSinCat = "Incluir Sin Categoría"

        Dim CentroRecogida As String = ""
        For Each s As String In LstCentroRecogida
            If CentroRecogida <> "" Then CentroRecogida = CentroRecogida & ","
            CentroRecogida = CentroRecogida & s
        Next

        Dim Empresa As String = ""
        For Each s As String In LstEmpresas
            If Empresa <> "" Then Empresa = Empresa & ","
            Empresa = Empresa & s
        Next

        If CentroRecogida = "" Then CentroRecogida = "TODOS"
        If Empresa = "" Then Empresa = "TODAS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO RESUMIDO POR AGRICULTOR-GÉNERO|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Agricultor " & AgrDesde & " Hasta Agricultor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "|" & IncluirSinCat, "95|>95", Estilos.NormalBold)
        If CentroRecogida <> "" Or Empresa <> "" Then
            Listado.Cabecera.Linea("Centro Recogida: " & CentroRecogida & "|" & "Empresa: " & Empresa, "95|>95", Estilos.NormalBold)
        End If
        If TipoEntrada <> "" Or TipoGenero <> "" Then
            Listado.Cabecera.Linea("Tipo de Entrada: " & TipoEntrada & "|" & "Tipo de Género: " & TipoGenero, "95|>95", Estilos.NormalBold)
        End If
        If Facturados <> "" Then Listado.Cabecera.Linea("Alb. Facturados: " & Facturados, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinAgr As String = "20|105|>20|>20|>25"
        Dim DLin As String = "20|68|2|33|2|>20|>20|>25"
        Dim Cabecera As String = "COD|GENERO||CT/CL||KILOS|P.MEDIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosGen As Decimal = 0
        Dim TotalImporteGen As Decimal = 0

        Dim TotalKilosAgr As Decimal = 0
        Dim TotalImporteAgr As Decimal = 0

        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxGenero As String = ""

        For Each row As DataRow In Datos.Rows
            Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
            Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))
            Dim IdGenero As String = VaInt(row("IdGenero")).ToString("00000")
            Dim Genero As String = row("Genero").ToString
            Dim Categoria As String = row("Categoria").ToString
            Dim Precio As String = VaDec(row("Precio")).ToString("#,##0.000")

            If IdGenero <> AuxIdGenero Or (IdAgricultor <> AuxIdAgricultor And AuxIdAgricultor <> "") Then
                If AuxIdGenero <> "" Then
                    'Resumen género anterior
                    Listado.Detalle.Linea("|Total Género...|" & _
                                          TotalKilosGen.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalKilosGen = 0
                    TotalImporteGen = 0
                End If
            End If

            If IdAgricultor <> AuxIdAgricultor Then
                If AuxIdAgricultor <> "" Then
                    'Resumen agricultor anterior
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                    Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                          AuxAgricultor & "|" & _
                                          TotalKilosAgr.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)
                    TotalKilosAgr = 0
                    TotalImporteAgr = 0
                    TotalKilosGen = 0
                    TotalImporteGen = 0
                End If
            End If

            'Líneas de listado
            Dim det As String = IdGenero & "|"
            det = det & Genero & "||"
            det = det & Categoria & "||"
            det = det & Kilos.ToString("#,##0.00") & "|"
            det = det & Precio & "|"
            det = det & Importe.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalKilosGen = TotalKilosGen + Kilos
            TotalImporteGen = TotalImporteGen + Importe
            TotalKilosAgr = TotalKilosAgr + Kilos
            TotalImporteAgr = TotalImporteAgr + Importe
            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe

            AuxIdAgricultor = IdAgricultor
            AuxAgricultor = Agricultor
            AuxIdGenero = IdGenero
            AuxGenero = Genero


            Application.DoEvents()

        Next

        'Último total del género
        Listado.Detalle.Linea("|Total Género...|" & _
                              TotalKilosGen.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

        'Último total del agricultor
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                              AuxAgricultor & "|" & _
                              TotalKilosAgr.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("|TOTAL LISTADO...|" & _
                              TotalKilos.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfigurarListadoResumidoGeneroYFincaAlbaranesEntrada()
        Dim IncluirSinCat As String = ""
        If BIncluirSinCategoria Then IncluirSinCat = "Incluir Sin Categoría"

        Dim CentroRecogida As String = ""
        For Each s As String In LstCentroRecogida
            If CentroRecogida <> "" Then CentroRecogida = CentroRecogida & ","
            CentroRecogida = CentroRecogida & s
        Next

        Dim Empresa As String = ""
        For Each s As String In LstEmpresas
            If Empresa <> "" Then Empresa = Empresa & ","
            Empresa = Empresa & s
        Next

        If CentroRecogida = "" Then CentroRecogida = "TODOS"
        If Empresa = "" Then Empresa = "TODAS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO RESUMIDO POR GÉNERO Y FINCA|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Agricultor " & AgrDesde & " Hasta Agricultor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "|" & IncluirSinCat, "95|>95", Estilos.NormalBold)
        If CentroRecogida <> "" Or Empresa <> "" Then
            Listado.Cabecera.Linea("Centro Recogida: " & CentroRecogida & "|" & "Empresa: " & Empresa, "95|>95", Estilos.NormalBold)
        End If
        If TipoEntrada <> "" Or TipoGenero <> "" Then
            Listado.Cabecera.Linea("Tipo de Entrada: " & TipoEntrada & "|" & "Tipo de Género: " & TipoGenero, "95|>95", Estilos.NormalBold)
        End If
        If Facturados <> "" Then Listado.Cabecera.Linea("Alb. Facturados: " & Facturados, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinAgr As String = "15|116|>20|>15|>24"
        Dim DLin As String = "15|12|12|58|2|10|20|2|>20|>15|>24"
        Dim Cabecera As String = "DUEÑO|FINCA|COD.|GENERO||COD.|CT/CL||KILOS|P.MEDIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosGen As Decimal = 0
        Dim TotalImporteGen As Decimal = 0

        Dim TotalKilosAgr As Decimal = 0
        Dim TotalImporteAgr As Decimal = 0

        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0

        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxGenero As String = ""

        For Each row As DataRow In Datos.Rows
            Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
            Dim Agricultor As String = (row("Agricultor").ToString & "").Trim

            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))

            Dim Finca As String = row("Finca").ToString
            Dim IdGenero As String = VaInt(row("IdGenero")).ToString("00000")
            Dim Genero As String = row("Genero").ToString
            Dim IdCategoria As String = row("IdCategoria").ToString
            Dim Categoria As String = row("Categoria").ToString
            Dim Precio As String = VaDec(row("Precio")).ToString("#,##0.000")

            If IdGenero <> AuxIdGenero Or (IdAgricultor <> AuxIdAgricultor And AuxIdAgricultor <> "") Then
                If AuxIdGenero <> "" Then
                    'Resumen género anterior
                    Listado.Detalle.Linea("|Total Género...|" & _
                                          TotalKilosGen.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalKilosGen = 0
                    TotalImporteGen = 0
                End If
            End If

            If IdAgricultor <> AuxIdAgricultor Then
                If AuxIdAgricultor <> "" Then
                    'Resumen agricultor anterior
                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                    Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                                          AuxAgricultor & "|" & _
                                          TotalKilosAgr.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalKilosAgr = 0
                    TotalImporteAgr = 0
                    TotalKilosGen = 0
                    TotalImporteGen = 0
                End If
            End If

            'Líneas de listado
            Dim det As String = "|"
            det = det & Finca & "|"
            det = det & IdGenero & "|"
            det = det & Genero & "||"
            det = det & IdCategoria & "|"
            det = det & Categoria & "||"
            det = det & Kilos.ToString("#,##0.00") & "|"
            det = det & Precio & "|"
            det = det & Importe.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalKilosGen = TotalKilosGen + Kilos
            TotalImporteGen = TotalImporteGen + Importe
            TotalKilosAgr = TotalKilosAgr + Kilos
            TotalImporteAgr = TotalImporteAgr + Importe

            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe

            AuxIdAgricultor = IdAgricultor
            AuxAgricultor = Agricultor
            AuxIdGenero = IdGenero
            AuxGenero = Genero

            Application.DoEvents()

        Next

        'Último total del género
        Listado.Detalle.Linea("|Total Género...|" & _
                              TotalKilosGen.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

        'Último total del agricultor
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea(VaInt(AuxIdAgricultor).ToString("00000") & "|" & _
                              AuxAgricultor & "|" & _
                              TotalKilosAgr.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteAgr.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaDebajo)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("|TOTAL LISTADO...|" & _
                              TotalKilos.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfigurarListadoResumidoGenero()
        Dim IncluirSinCat As String = ""
        If BIncluirSinCategoria Then IncluirSinCat = "Incluir Sin Categoría"

        Dim CentroRecogida As String = ""
        For Each s As String In LstCentroRecogida
            If CentroRecogida <> "" Then CentroRecogida = CentroRecogida & ","
            CentroRecogida = CentroRecogida & s
        Next

        Dim Empresa As String = ""
        For Each s As String In LstEmpresas
            If Empresa <> "" Then Empresa = Empresa & ","
            Empresa = Empresa & s
        Next

        If CentroRecogida = "" Then CentroRecogida = "TODOS"
        If Empresa = "" Then Empresa = "TODAS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea("ALBARANES DE ENTRADA - LISTADO RESUMIDO POR GÉNERO|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Agricultor " & AgrDesde & " Hasta Agricultor " & AgrHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "|" & IncluirSinCat, "95|>95", Estilos.NormalBold)
        If CentroRecogida <> "" Or Empresa <> "" Then
            Listado.Cabecera.Linea("Centro Recogida: " & CentroRecogida & "|" & "Empresa: " & Empresa, "95|>95", Estilos.NormalBold)
        End If
        If TipoEntrada <> "" Or TipoGenero <> "" Then
            Listado.Cabecera.Linea("Tipo de Entrada: " & TipoEntrada & "|" & "Tipo de Género: " & TipoGenero, "95|>95", Estilos.NormalBold)
        End If
        If Facturados <> "" Then Listado.Cabecera.Linea("Alb. Facturados: " & Facturados, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinAgr As String = "20|105|>20|>20|>25"
        Dim DLin As String = "20|68|2|33|2|>20|>20|>25"
        Dim Cabecera As String = "COD|GENERO||CT/CL||KILOS|P.MEDIO|IMPORTE"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosGen As Decimal = 0
        Dim TotalImporteGen As Decimal = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0
        Dim AuxIdAgricultor As String = ""
        Dim AuxAgricultor As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxGenero As String = ""

        For Each row As DataRow In Datos.Rows
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))
            Dim IdGenero As String = VaInt(row("IdGenero")).ToString("00000")
            Dim Genero As String = row("Genero").ToString
            Dim Categoria As String = row("Categoria").ToString
            Dim Precio As String = VaDec(row("Precio")).ToString("#,##0.000")

            If IdGenero <> AuxIdGenero Then
                If AuxIdGenero <> "" Then
                    'Resumen género anterior
                    Listado.Detalle.Linea("|Total Género...|" & _
                                          TotalKilosGen.ToString("#,##0.00") & "|" & _
                                          "|" & _
                                          TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

                    Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                    TotalKilosGen = 0
                    TotalImporteGen = 0
                End If
            End If

            'Líneas de listado
            Dim det As String = IdGenero & "|"
            det = det & Genero & "||"
            det = det & Categoria & "||"
            det = det & Kilos.ToString("#,##0.00") & "|"
            det = det & Precio & "|"
            det = det & Importe.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalKilosGen = TotalKilosGen + Kilos
            TotalImporteGen = TotalImporteGen + Importe


            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe

            AuxIdGenero = IdGenero
            AuxGenero = Genero


            Application.DoEvents()

        Next

        'Último total del género
        Listado.Detalle.Linea("|Total Género...|" & _
                              TotalKilosGen.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporteGen.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBold)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("|TOTAL LISTADO...|" & _
                              TotalKilos.ToString("#,##0.00") & "|" & _
                              "|" & _
                              TotalImporte.ToString("#,##0.00"), DLinAgr, Estilos.ReducidaBoldLineaEncima)
    End Sub

End Class
