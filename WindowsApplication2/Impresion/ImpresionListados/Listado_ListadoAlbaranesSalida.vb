Public Class Listado_ListadoAlbaranesSalida
    Inherits Listado_ImpresionBase

#Region "Propiedades"

    Property Datos As DataTable
    Property CliDesde As String
    Property CliHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property AlbDesde As String
    Property AlbHasta As String
    Property GenDesde As String
    Property GenHasta As String
    Property CatDesde As String
    Property CatHasta As String
    Property DomDesde As String
    Property DomHasta As String
    Property LstPuntoVenta As List(Of String)
    Property tipoVenta As String
    Property ConPrecioSalida As String
    Property Valorados As String
    Property Facturados As String
    Property TipoListado As Integer
    Property TipoImpresion As TipoImpresion

#End Region

#Region "Constructores"

    Public Sub New(ByVal datos As DataTable, ByVal cliDesde As String, ByVal cliHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal albDesde As String, _
                   ByVal albHasta As String, ByVal genDesde As String, ByVal genHasta As String, _
                   ByVal catDesde As String, ByVal catHasta As String, ByVal domDesde As String, _
                   ByVal domHasta As String, ByVal lstPuntoVenta As List(Of String), ByVal tipoVenta As String, _
                   ByVal conPrecioSalida As String, ByVal valorados As String, ByVal facturados As String, _
                   ByVal tipoListado As Integer, ByVal TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.CliDesde = cliDesde
        Me.CliHasta = cliHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.AlbDesde = albDesde
        Me.AlbHasta = albHasta
        Me.GenDesde = genDesde
        Me.GenHasta = genHasta
        Me.CatDesde = catDesde
        Me.CatHasta = catHasta
        Me.DomDesde = domDesde
        Me.DomHasta = domHasta
        Me.LstPuntoVenta = lstPuntoVenta
        Me.tipoVenta = tipoVenta
        Me.ConPrecioSalida = conPrecioSalida
        Me.Valorados = valorados
        Me.Facturados = facturados
        Me.TipoListado = tipoListado
        Me.TipoImpresion = TipoImpresion
    End Sub

#End Region

    Public Overrides Sub ImprimirListado()
        If CliDesde.Trim = "" Then CliDesde = "00001"
        If CliHasta.Trim = "" Then CliHasta = "99999"
        If AlbDesde.Trim = "" Then AlbDesde = "000001"
        If AlbHasta.Trim = "" Then AlbHasta = "999999"
        If GenDesde.Trim = "" Then GenDesde = "00001"
        If GenHasta.Trim = "" Then GenHasta = "99999"
        If CatDesde.Trim = "" Then CatDesde = "001"
        If CatHasta.Trim = "" Then CatHasta = "999"
        If DomDesde.Trim = "" Then DomDesde = "001"
        If DomHasta.Trim = "" Then DomHasta = "999"


        MargenSup = 10
        MargenIzq = 8


        Dim Orientacion As Orientacion = Orientacion.Horizontal

        Select Case TipoListado
            Case 2
                Orientacion = NetAgro.Orientacion.Vertical
            Case 3, 4
                MargenIzq = 10
                Orientacion = NetAgro.Orientacion.Vertical
        End Select

        EstableceListado(Orientacion, TipoImpresion)


        Try

            Select Case TipoListado
                Case 0
                    ConfigurarListadoDetallado()
                Case 1
                    ConfigurarListadoResumido()
                Case 2
                    ConfigurarListadoDetalladoPorPalet()
                Case 3
                    ConfigurarListadoResumidoPorGeneroYCategoria()
                Case 4
                    ConfigurarListadoResumidoPorGenero()
            End Select

            Previsualiza()


        Catch ex As Exception

        End Try
        
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
        Listado.Cabecera.Linea("LISTADO DETALLADO ALBARANES DE SALIDA|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "200|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Cliente " & CliDesde & " Hasta Cliente " & CliHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "| Desde Domic. " & DomDesde & " Hasta Domic. " & DomHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Tipo de venta: " & tipoVenta & "|" & "Con precio salida: " & ConPrecioSalida, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Valorados: " & Valorados & "|" & "Facturados: " & Facturados, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto venta: " & PuntoVenta, "280", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinFra As String = "115|>10|>13|>16|>16|>16|>16|>20|>20|>20|>18"
        'Dim DLin As String = "15|20|61|2|15|2|>10|>13|>16|>16|>16|>16|>20|>20|>20|>18"
        Dim DLin As String = "12|16|15|53|2|15|2|>10|>13|>16|>16|>16|>16|>20|>20|>20|>18"
        Dim Cabecera As String = "ALBAR.|F.SALIDA|PED.|GENERO||CT/CL||B.SAL|B.VEND|K.SALID|K.VEND|Pr.SALID|Pr.VENTA|IMP.SALIDA|IMP.VENTA|DIFER|IMP.ENV"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalBultosSalAlb As Integer = 0
        Dim TotalBultosVenAlb As Integer = 0
        Dim TotalKilosSalAlb As Decimal = 0
        Dim TotalKilosVenAlb As Decimal = 0
        Dim TotalImporteSalAlb As Decimal = 0
        Dim TotalImporteVenAlb As Decimal = 0
        Dim TotalDiferenciaAlb As Decimal = 0

        Dim TotalBultosSalDom As Integer = 0
        Dim TotalBultosVenDom As Integer = 0
        Dim TotalKilosSalDom As Decimal = 0
        Dim TotalKilosVenDom As Decimal = 0
        Dim TotalImporteSalDom As Decimal = 0
        Dim TotalImporteVenDom As Decimal = 0
        Dim TotalDiferenciaDom As Decimal = 0
        Dim TotalImporteEnvDom As Decimal = 0

        Dim TotalBultosSalCli As Integer = 0
        Dim TotalBultosVenCli As Integer = 0
        Dim TotalKilosSalCli As Decimal = 0
        Dim TotalKilosVenCli As Decimal = 0
        Dim TotalImporteSalCli As Decimal = 0
        Dim TotalImporteVenCli As Decimal = 0
        Dim TotalDiferenciaCli As Decimal = 0
        Dim TotalImporteEnvCli As Decimal = 0

        Dim TotalBultosSal As Integer = 0
        Dim TotalBultosVen As Integer = 0
        Dim TotalKilosSal As Decimal = 0
        Dim TotalKilosVen As Decimal = 0
        Dim TotalImporteSal As Decimal = 0
        Dim TotalImporteVen As Decimal = 0
        Dim TotalDiferencia As Decimal = 0
        Dim TotalImporteEnv As Decimal = 0

        Dim AuxIdCliente As String = ""
        Dim AuxCliente As String = ""
        Dim AuxIdDomicilio As String = ""
        Dim AuxDomicilio As String = ""
        Dim AuxIdAlbaran As String = ""
        Dim AuxDatosFactura As String = ""
        Dim AuxImporteEnv As Decimal = 0

        For Each row As DataRow In Datos.Rows
            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim IdDomicilio As String = (row("IdDomicilio").ToString & "").Trim
            Dim Domicilio As String = (row("Domicilio").ToString & "").Trim
            If VaInt(IdDomicilio) > 0 Then
                Domicilio = VaInt(IdDomicilio).ToString("00") & " - " & Domicilio
            End If
            Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
            Dim DatosFactura As String = ""
            If VaInt(row("IdFactura")) > 0 Then
                DatosFactura = "Fac: " & VaInt(row("Campa")).ToString("00") & "/" & VaInt(row("Serie")).ToString("00") & "-" & VaInt(row("Albaran")).ToString("000000")
                DatosFactura = DatosFactura & " - Mat: " & (row("Matricula").ToString & "").Trim
            End If

            Dim BultosSal As Integer = VaInt(row("BultosSal"))
            Dim BultosVen As Integer = VaInt(row("BultosVen"))
            Dim KilosSal As Decimal = VaDec(row("KilosSal"))
            Dim KilosVen As Decimal = VaDec(row("KilosVen"))
            Dim ImporteSal As Decimal = VaDec(row("ImporteSal"))
            Dim ImporteVen As Decimal = VaDec(row("ImporteVen"))
            Dim ImporteEnv As Decimal = VaDec(row("ImporteEnv"))
            Dim Diferencia As Decimal = VaDec(row("Diferencia"))

            Dim Albaran As String = VaInt(row("Albaran")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Pedido As String = row("Pedido").ToString
            Dim Genero As String = row("Presentacion").ToString
            Dim Categoria As String = row("Categoria").ToString
            Dim PrecioSal As String = VaDec(row("PrecioSal")).ToString("#,##0.0000")
            Dim PrecioVen As String = VaDec(row("PrecioVen")).ToString("#,##0.0000")

            Dim bCambioCliente As Boolean = (IdCliente <> AuxIdCliente And AuxIdCliente <> "")
            Dim bCambioDomicilio As Boolean = (IdDomicilio <> AuxIdDomicilio And AuxIdCliente <> "")        'AuxIdCliente <> "" ?? --> Para controlar que no sea el primer registro
            Dim bCambioAlbaran As Boolean = (IdAlbaran <> AuxIdAlbaran And AuxIdAlbaran <> "")

            If bCambioCliente Then
                bCambioDomicilio = True
                bCambioAlbaran = True
            End If

            If bCambioDomicilio Then
                bCambioAlbaran = True
            End If

            If bCambioAlbaran Then
                'Resumen albarán anterior
                Listado.Detalle.Linea("|-------|------|--------|------|||----------|---------|----------|-------", DLinFra, Estilos.Reducida)

                Listado.Detalle.Linea(AuxDatosFactura & "|" & _
                                      TotalBultosSalAlb.ToString("#,##0") & "|" & _
                                      TotalBultosVenAlb.ToString("#,##0") & "|" & _
                                      TotalKilosSalAlb.ToString("#,##0") & "|" & _
                                      TotalKilosVenAlb.ToString("#,##0") & "|||" & _
                                      TotalImporteSalAlb.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenAlb.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaAlb.ToString("#,##0.00") & "|" & _
                                      AuxImporteEnv.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

                TotalBultosSalAlb = 0
                TotalBultosVenAlb = 0
                TotalKilosSalAlb = 0
                TotalKilosVenAlb = 0
                TotalImporteSalAlb = 0
                TotalImporteVenAlb = 0
                TotalDiferenciaAlb = 0
            End If

            If bCambioDomicilio Then
                'Resumen domicilio anterior
                Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                                      TotalBultosSalDom.ToString("#,##0") & "|" & _
                                      TotalBultosVenDom.ToString("#,##0") & "|" & _
                                      TotalKilosSalDom.ToString("#,##0") & "|" & _
                                      TotalKilosVenDom.ToString("#,##0") & "|||" & _
                                      TotalImporteSalDom.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenDom.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaDom.ToString("#,##0.00") & "|" & _
                                      TotalImporteEnvDom.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

                TotalBultosSalDom = 0
                TotalBultosVenDom = 0
                TotalKilosSalDom = 0
                TotalKilosVenDom = 0
                TotalImporteSalDom = 0
                TotalImporteVenDom = 0
                TotalDiferenciaDom = 0
                TotalImporteEnvDom = 0
            End If

            If bCambioCliente Then
                'Resumen cliente anterior
                Listado.Detalle.Linea("", "280", Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                                      TotalBultosSalCli.ToString("#,##0") & "|" & _
                                      TotalBultosVenCli.ToString("#,##0") & "|" & _
                                      TotalKilosSalCli.ToString("#,##0") & "|" & _
                                      TotalKilosVenCli.ToString("#,##0") & "|||" & _
                                      TotalImporteSalCli.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenCli.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaCli.ToString("#,##0.00") & "|" & _
                                      TotalImporteEnvCli.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

                TotalBultosSalCli = 0
                TotalBultosVenCli = 0
                TotalKilosSalCli = 0
                TotalKilosVenCli = 0
                TotalImporteSalCli = 0
                TotalImporteVenCli = 0
                TotalDiferenciaCli = 0
                TotalImporteEnvCli = 0
            End If

            'Líneas de listado
            Dim det As String = Albaran & "|"
            det = det & Fecha & "|"
            det = det & Pedido & "|"
            det = det & Genero & "||"
            det = det & Categoria & "||"
            det = det & BultosSal.ToString("#,##0") & "|"
            det = det & BultosVen.ToString("#,##0") & "|"
            det = det & KilosSal.ToString("#,##0") & "|"
            det = det & KilosVen.ToString("#,##0") & "|"
            det = det & PrecioSal & "|"
            det = det & PrecioVen & "|"
            det = det & ImporteSal.ToString("#,##0.00") & "|"
            det = det & ImporteVen.ToString("#,##0.00") & "|"
            det = det & Diferencia.ToString("#,##0.00") & "|"
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalBultosSalAlb = TotalBultosSalAlb + BultosSal
            TotalBultosVenAlb = TotalBultosVenAlb + BultosVen
            TotalKilosSalAlb = TotalKilosSalAlb + KilosSal
            TotalKilosVenAlb = TotalKilosVenAlb + KilosVen
            TotalImporteSalAlb = TotalImporteSalAlb + ImporteSal
            TotalImporteVenAlb = TotalImporteVenAlb + ImporteVen
            TotalDiferenciaAlb = TotalDiferenciaAlb + Diferencia

            TotalBultosSalDom = TotalBultosSalDom + BultosSal
            TotalBultosVenDom = TotalBultosVenDom + BultosVen
            TotalKilosSalDom = TotalKilosSalDom + KilosSal
            TotalKilosVenDom = TotalKilosVenDom + KilosVen
            TotalImporteSalDom = TotalImporteSalDom + ImporteSal
            TotalImporteVenDom = TotalImporteVenDom + ImporteVen
            TotalDiferenciaDom = TotalDiferenciaDom + Diferencia
            TotalImporteEnvDom = TotalImporteEnvDom + ImporteEnv

            TotalBultosSalCli = TotalBultosSalCli + BultosSal
            TotalBultosVenCli = TotalBultosVenCli + BultosVen
            TotalKilosSalCli = TotalKilosSalCli + KilosSal
            TotalKilosVenCli = TotalKilosVenCli + KilosVen
            TotalImporteSalCli = TotalImporteSalCli + ImporteSal
            TotalImporteVenCli = TotalImporteVenCli + ImporteVen
            TotalDiferenciaCli = TotalDiferenciaCli + Diferencia
            TotalImporteEnvCli = TotalImporteEnvCli + ImporteEnv

            TotalBultosSal = TotalBultosSal + BultosSal
            TotalBultosVen = TotalBultosVen + BultosVen
            TotalKilosSal = TotalKilosSal + KilosSal
            TotalKilosVen = TotalKilosVen + KilosVen
            TotalImporteSal = TotalImporteSal + ImporteSal
            TotalImporteVen = TotalImporteVen + ImporteVen
            TotalDiferencia = TotalDiferencia + Diferencia
            TotalImporteEnv = TotalImporteEnv + ImporteEnv

            AuxIdCliente = IdCliente
            AuxCliente = Cliente
            AuxIdDomicilio = IdDomicilio
            AuxDomicilio = Domicilio
            AuxIdAlbaran = IdAlbaran
            AuxDatosFactura = DatosFactura
            AuxImporteEnv = ImporteEnv


            Application.DoEvents()

        Next

        ''Último total del albarán
        Listado.Detalle.Linea("|-------|------|--------|------|||----------|---------|----------|-------", DLinFra, Estilos.Reducida)

        Listado.Detalle.Linea(AuxDatosFactura & "|" & _
                              TotalBultosSalAlb.ToString("#,##0") & "|" & _
                              TotalBultosVenAlb.ToString("#,##0") & "|" & _
                              TotalKilosSalAlb.ToString("#,##0") & "|" & _
                              TotalKilosVenAlb.ToString("#,##0") & "|||" & _
                              TotalImporteSalAlb.ToString("#,##0.00") & "|" & _
                              TotalImporteVenAlb.ToString("#,##0.00") & "|" & _
                              TotalDiferenciaAlb.ToString("#,##0.00") & "|" & _
                              AuxImporteEnv.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

        Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

        'Último total por domicilio
        Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                              TotalBultosSalDom.ToString("#,##0") & "|" & _
                              TotalBultosVenDom.ToString("#,##0") & "|" & _
                              TotalKilosSalDom.ToString("#,##0") & "|" & _
                              TotalKilosVenDom.ToString("#,##0") & "|||" & _
                              TotalImporteSalDom.ToString("#,##0.00") & "|" & _
                              TotalImporteVenDom.ToString("#,##0.00") & "|" & _
                              TotalDiferenciaDom.ToString("#,##0.00") & "|" & _
                              TotalImporteEnvDom.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

        Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

        'Último total del cliente
        Listado.Detalle.Linea("", "280", Estilos.ReducidaBoldLineaDebajo)

        Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                              TotalBultosSalCli.ToString("#,##0") & "|" & _
                              TotalBultosVenCli.ToString("#,##0") & "|" & _
                              TotalKilosSalCli.ToString("#,##0") & "|" & _
                              TotalKilosVenCli.ToString("#,##0") & "|||" & _
                              TotalImporteSalCli.ToString("#,##0.00") & "|" & _
                              TotalImporteVenCli.ToString("#,##0.00") & "|" & _
                              TotalDiferenciaCli.ToString("#,##0.00") & "|" & _
                              TotalImporteEnvCli.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaDebajo)

        Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("    TOTAL LISTADO...|" & _
                              TotalBultosSal.ToString("#,##0") & "|" & _
                              TotalBultosVen.ToString("#,##0") & "|" & _
                              TotalKilosSal.ToString("#,##0") & "|" & _
                              TotalKilosVen.ToString("#,##0") & "|||" & _
                              TotalImporteSal.ToString("#,##0.00") & "|" & _
                              TotalImporteVen.ToString("#,##0.00") & "|" & _
                              TotalDiferencia.ToString("#,##0.00") & "|" & _
                              TotalImporteEnv.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfigurarListadoResumido()
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
        Listado.Cabecera.Linea("LISTADO RESUMIDO ALBARANES DE SALIDA|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "200|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Cliente " & CliDesde & " Hasta Cliente " & CliHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "| Desde Domic. " & DomDesde & " Hasta Domic. " & DomHasta, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Tipo de venta: " & tipoVenta & "|" & "Con precio salida: " & ConPrecioSalida, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Valorados: " & Valorados & "|" & "Facturados: " & Facturados, "140|>140", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto venta: " & PuntoVenta, "280", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLinFra As String = "147|>10|>13|>16|>16|>20|>20|>20|>18"
        'Dim DLin As String = "15|20|110|2|>10|>13|>16|>16|>20|>20|>20|>18"
        Dim DLin As String = "15|20|15|95|2|>10|>13|>16|>16|>20|>20|>20|>18"
        Dim Cabecera As String = "ALBAR.|F.SALIDA|PED.|FACTURA||B.SAL|B.VEND|K.SALID|K.VEND|IMP.SALIDA|IMP.VENTA|DIFER|IMP.ENV"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalBultosSalDom As Integer = 0
        Dim TotalBultosVenDom As Integer = 0
        Dim TotalKilosSalDom As Decimal = 0
        Dim TotalKilosVenDom As Decimal = 0
        Dim TotalImporteSalDom As Decimal = 0
        Dim TotalImporteVenDom As Decimal = 0
        Dim TotalDiferenciaDom As Decimal = 0
        Dim TotalImporteEnvDom As Decimal = 0

        Dim TotalBultosSalCli As Integer = 0
        Dim TotalBultosVenCli As Integer = 0
        Dim TotalKilosSalCli As Decimal = 0
        Dim TotalKilosVenCli As Decimal = 0
        Dim TotalImporteSalCli As Decimal = 0
        Dim TotalImporteVenCli As Decimal = 0
        Dim TotalDiferenciaCli As Decimal = 0
        Dim TotalImporteEnvCli As Decimal = 0

        Dim TotalBultosSal As Integer = 0
        Dim TotalBultosVen As Integer = 0
        Dim TotalKilosSal As Decimal = 0
        Dim TotalKilosVen As Decimal = 0
        Dim TotalImporteSal As Decimal = 0
        Dim TotalImporteVen As Decimal = 0
        Dim TotalDiferencia As Decimal = 0
        Dim TotalImporteEnv As Decimal = 0

        Dim AuxIdCliente As String = ""
        Dim AuxCliente As String = ""
        Dim AuxIdDomicilio As String = ""
        Dim AuxDomicilio As String = ""
        Dim AuxDatosFactura As String = ""

        For Each row As DataRow In Datos.Rows
            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim IdDomicilio As String = (row("IdDomicilio").ToString & "").Trim
            Dim Domicilio As String = (row("Domicilio").ToString & "").Trim
            If VaInt(IdDomicilio) > 0 Then
                Domicilio = VaInt(IdDomicilio).ToString("00") & " - " & Domicilio
            End If
            Dim DatosFactura As String = ""
            If VaInt(row("IdFactura")) > 0 Then
                DatosFactura = "Fac: " & VaInt(row("Campa")).ToString("00") & "/" & VaInt(row("Serie")).ToString("00") & "-" & VaInt(row("Factura")).ToString("000000")
                DatosFactura = DatosFactura & " - Mat: " & (row("Matricula").ToString & "").Trim
            End If

            Dim BultosSal As Integer = VaInt(row("BultosSal"))
            Dim BultosVen As Integer = VaInt(row("BultosVen"))
            Dim KilosSal As Decimal = VaDec(row("KilosSal"))
            Dim KilosVen As Decimal = VaDec(row("KilosVen"))
            Dim ImporteSal As Decimal = VaDec(row("ImporteSal"))
            Dim ImporteVen As Decimal = VaDec(row("ImporteVen"))
            Dim ImporteEnv As Decimal = VaDec(row("ImporteEnv"))
            Dim Diferencia As Decimal = VaDec(row("Diferencia"))

            Dim Albaran As String = VaInt(row("Albaran")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Pedido As String = row("Pedido").ToString

            Dim bCambioCliente As Boolean = (IdCliente <> AuxIdCliente And AuxIdCliente <> "")
            Dim bCambioDomicilio As Boolean = (IdDomicilio <> AuxIdDomicilio And AuxIdCliente <> "")        'AuxIdCliente <> "" ?? --> Para controlar que no sea el primer registro

            If bCambioCliente Then
                bCambioDomicilio = True
            End If

            If bCambioDomicilio Then
                'Resumen domicilio anterior
                Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                                      TotalBultosSalDom.ToString("#,##0") & "|" & _
                                      TotalBultosVenDom.ToString("#,##0") & "|" & _
                                      TotalKilosSalDom.ToString("#,##0") & "|" & _
                                      TotalKilosVenDom.ToString("#,##0") & "|" & _
                                      TotalImporteSalDom.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenDom.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaDom.ToString("#,##0.00") & "|" & _
                                      TotalImporteEnvDom.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

                TotalBultosSalDom = 0
                TotalBultosVenDom = 0
                TotalKilosSalDom = 0
                TotalKilosVenDom = 0
                TotalImporteSalDom = 0
                TotalImporteVenDom = 0
                TotalDiferenciaDom = 0
                TotalImporteEnvDom = 0
            End If

            If bCambioCliente Then
                'Resumen cliente anterior
                Listado.Detalle.Linea("", "280", Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                                      TotalBultosSalCli.ToString("#,##0") & "|" & _
                                      TotalBultosVenCli.ToString("#,##0") & "|" & _
                                      TotalKilosSalCli.ToString("#,##0") & "|" & _
                                      TotalKilosVenCli.ToString("#,##0") & "|" & _
                                      TotalImporteSalCli.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenCli.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaCli.ToString("#,##0.00") & "|" & _
                                      TotalImporteEnvCli.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

                TotalBultosSalCli = 0
                TotalBultosVenCli = 0
                TotalKilosSalCli = 0
                TotalKilosVenCli = 0
                TotalImporteSalCli = 0
                TotalImporteVenCli = 0
                TotalDiferenciaCli = 0
                TotalImporteEnvCli = 0
            End If

            'Líneas de listado
            Dim det As String = Albaran & "|"
            det = det & Fecha & "|"
            det = det & Pedido & "|"
            det = det & DatosFactura & "||"
            det = det & BultosSal.ToString("#,##0") & "|"
            det = det & BultosVen.ToString("#,##0") & "|"
            det = det & KilosSal.ToString("#,##0") & "|"
            det = det & KilosVen.ToString("#,##0") & "|"
            det = det & ImporteSal.ToString("#,##0.00") & "|"
            det = det & ImporteVen.ToString("#,##0.00") & "|"
            det = det & Diferencia.ToString("#,##0.00") & "|"
            det = det & ImporteEnv.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalBultosSalDom = TotalBultosSalDom + BultosSal
            TotalBultosVenDom = TotalBultosVenDom + BultosVen
            TotalKilosSalDom = TotalKilosSalDom + KilosSal
            TotalKilosVenDom = TotalKilosVenDom + KilosVen
            TotalImporteSalDom = TotalImporteSalDom + ImporteSal
            TotalImporteVenDom = TotalImporteVenDom + ImporteVen
            TotalDiferenciaDom = TotalDiferenciaDom + Diferencia
            TotalImporteEnvDom = TotalImporteEnvDom + ImporteEnv

            TotalBultosSalCli = TotalBultosSalCli + BultosSal
            TotalBultosVenCli = TotalBultosVenCli + BultosVen
            TotalKilosSalCli = TotalKilosSalCli + KilosSal
            TotalKilosVenCli = TotalKilosVenCli + KilosVen
            TotalImporteSalCli = TotalImporteSalCli + ImporteSal
            TotalImporteVenCli = TotalImporteVenCli + ImporteVen
            TotalDiferenciaCli = TotalDiferenciaCli + Diferencia
            TotalImporteEnvCli = TotalImporteEnvCli + ImporteEnv

            TotalBultosSal = TotalBultosSal + BultosSal
            TotalBultosVen = TotalBultosVen + BultosVen
            TotalKilosSal = TotalKilosSal + KilosSal
            TotalKilosVen = TotalKilosVen + KilosVen
            TotalImporteSal = TotalImporteSal + ImporteSal
            TotalImporteVen = TotalImporteVen + ImporteVen
            TotalDiferencia = TotalDiferencia + Diferencia
            TotalImporteEnv = TotalImporteEnv + ImporteEnv

            AuxIdCliente = IdCliente
            AuxCliente = Cliente
            AuxIdDomicilio = IdDomicilio
            AuxDomicilio = Domicilio
            AuxDatosFactura = DatosFactura


            Application.DoEvents()

        Next

        'Último total por domicilio
        Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                              TotalBultosSalDom.ToString("#,##0") & "|" & _
                              TotalBultosVenDom.ToString("#,##0") & "|" & _
                              TotalKilosSalDom.ToString("#,##0") & "|" & _
                              TotalKilosVenDom.ToString("#,##0") & "|" & _
                              TotalImporteSalDom.ToString("#,##0.00") & "|" & _
                              TotalImporteVenDom.ToString("#,##0.00") & "|" & _
                              TotalDiferenciaDom.ToString("#,##0.00") & "|" & _
                              TotalImporteEnvDom.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBold)

        Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

        'Último total del cliente
        Listado.Detalle.Linea("", "280", Estilos.ReducidaBoldLineaDebajo)

        Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                              TotalBultosSalCli.ToString("#,##0") & "|" & _
                              TotalBultosVenCli.ToString("#,##0") & "|" & _
                              TotalKilosSalCli.ToString("#,##0") & "|" & _
                              TotalKilosVenCli.ToString("#,##0") & "|" & _
                              TotalImporteSalCli.ToString("#,##0.00") & "|" & _
                              TotalImporteVenCli.ToString("#,##0.00") & "|" & _
                              TotalDiferenciaCli.ToString("#,##0.00") & "|" & _
                              TotalImporteEnvCli.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaDebajo)

        Listado.Detalle.Linea("", "280", Estilos.ReducidaBold)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("    TOTAL LISTADO...|" & _
                              TotalBultosSal.ToString("#,##0") & "|" & _
                              TotalBultosVen.ToString("#,##0") & "|" & _
                              TotalKilosSal.ToString("#,##0") & "|" & _
                              TotalKilosVen.ToString("#,##0") & "|" & _
                              TotalImporteSal.ToString("#,##0.00") & "|" & _
                              TotalImporteVen.ToString("#,##0.00") & "|" & _
                              TotalDiferencia.ToString("#,##0.00") & "|" & _
                              TotalImporteEnv.ToString("#,##0.00"), DLinFra, Estilos.ReducidaBoldLineaEncima)
    End Sub

    Private Sub ConfigurarListadoDetalladoPorPalet()
        Dim PuntoVenta As String = ""
        For Each s As String In LstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next

        If PuntoVenta = "" Then PuntoVenta = "TODOS"


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea("LISTADO DE ALBARANES POR PALET|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Cliente " & CliDesde & " Hasta Cliente " & CliHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "| Desde Domic. " & DomDesde & " Hasta Domic. " & DomHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Tipo de venta: " & tipoVenta & "|" & "Con precio salida: " & ConPrecioSalida, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Valorados: " & Valorados & "|" & "Facturados: " & Facturados, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto venta: " & PuntoVenta, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)

        'Detalle
        Dim DLinAlb As String = "142|>16|>15|>17"
        Dim DLin As String = "68|2|16|2|18|2|>16|=18|>16|>15|>17"
        Dim Cabecera As String = "GÉNERO||CT/CL||MARCA||N.PALET|F.CONFEC|PALETS|BULTOS|KILOS"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalPaletsAlb As Integer = 0
        Dim TotalBultosAlb As Integer = 0
        Dim TotalKilosAlb As Decimal = 0

        Dim TotalPaletsDom As Integer = 0
        Dim TotalBultosDom As Integer = 0
        Dim TotalKilosDom As Decimal = 0

        Dim TotalPaletsCli As Integer = 0
        Dim TotalBultosCli As Integer = 0
        Dim TotalKilosCli As Decimal = 0

        Dim TotalPalets As Integer = 0
        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0

        Dim AuxIdCliente As String = ""
        Dim AuxCliente As String = ""
        Dim AuxIdDomicilio As String = ""
        Dim AuxDomicilio As String = ""
        Dim AuxIdAlbaran As String = ""
        Dim AuxDatosAlbaran As String = ""

        Dim DcPalets As New Dictionary(Of Integer, Integer)

        For Each row As DataRow In Datos.Rows
            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim IdDomicilio As String = (row("IdDomicilio").ToString & "").Trim
            Dim Domicilio As String = (row("Domicilio").ToString & "").Trim
            If VaInt(IdDomicilio) > 0 Then
                Domicilio = VaInt(IdDomicilio).ToString("00") & " - " & Domicilio
            End If
            Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
            Dim DatosAlbaran As String = "Albarán: " & VaInt(row("Albaran")).ToString("000000")
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then DatosAlbaran = DatosAlbaran & " Fecha: " & VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Pedido As String = (row("Pedido").ToString & "").Trim
            If Pedido <> "" Then DatosAlbaran = DatosAlbaran & " - Ped.: " & Pedido

            Dim IdPalet As Integer = VaInt(row("IdPalet"))
            Dim Palets As Integer = 0
            If Not DcPalets.ContainsKey(IdPalet) Then
                Palets = 1
                DcPalets(IdPalet) = IdPalet
            End If
            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))

            Dim Presentacion As String = row("Presentacion").ToString
            Dim Categoria As String = row("Categoria").ToString
            Dim Marca As String = row("Marca").ToString
            Dim Palet As String = VaInt(row("Palet")).ToString("0000000")
            Dim FConfec As String = ""
            If VaDate(row("FechaPal")) > VaDate("") Then FConfec = VaDate(row("FechaPal")).ToString("dd/MM/yyyy")

            Dim bCambioCliente As Boolean = (IdCliente <> AuxIdCliente And AuxIdCliente <> "")
            Dim bCambioDomicilio As Boolean = (IdDomicilio <> AuxIdDomicilio And AuxIdCliente <> "")        'AuxIdCliente <> "" ?? --> Para controlar que no sea el primer registro
            Dim bCambioAlbaran As Boolean = (IdAlbaran <> AuxIdAlbaran And AuxIdAlbaran <> "")

            If bCambioCliente Then
                bCambioDomicilio = True
                bCambioAlbaran = True
            End If

            If bCambioDomicilio Then
                bCambioAlbaran = True
            End If

            If bCambioAlbaran Then
                'Resumen albarán anterior
                Listado.Detalle.Linea("|-------|-------|----------", DLinAlb, Estilos.Reducida)

                Listado.Detalle.Linea(AuxDatosAlbaran & "|" & _
                                      TotalPaletsAlb.ToString("#,##0") & "|" & _
                                      TotalBultosAlb.ToString("#,##0") & "|" & _
                                      TotalKilosAlb.ToString("#,##0"), DLinAlb, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                TotalPaletsAlb = 0
                TotalBultosAlb = 0
                TotalKilosAlb = 0
            End If

            If bCambioDomicilio Then
                'Resumen domicilio anterior
                Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                                      TotalPaletsDom.ToString("#,##0") & "|" & _
                                      TotalBultosDom.ToString("#,##0") & "|" & _
                                      TotalKilosDom.ToString("#,##0"), DLinAlb, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                TotalPaletsDom = 0
                TotalBultosDom = 0
                TotalKilosDom = 0
            End If

            If bCambioCliente Then
                'Resumen cliente anterior
                Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                                      TotalPaletsCli.ToString("#,##0") & "|" & _
                                      TotalBultosCli.ToString("#,##0") & "|" & _
                                      TotalKilosCli.ToString("#,##0"), DLinAlb, Estilos.ReducidaBoldLineaDebajo)

                Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                TotalPaletsCli = 0
                TotalBultosCli = 0
                TotalKilosCli = 0
            End If

            'Líneas de listado
            Dim det As String = Presentacion & "||"
            det = det & Categoria & "||"
            det = det & Marca & "||"
            det = det & Palet & "|"
            det = det & FConfec & "|"
            det = det & Palets.ToString("#,##0") & "|"
            det = det & Bultos.ToString("#,##0") & "|"
            det = det & Kilos.ToString("#,##0") & "|"
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalPaletsAlb = TotalPaletsAlb + Palets
            TotalBultosAlb = TotalBultosAlb + Bultos
            TotalKilosAlb = TotalKilosAlb + Kilos

            TotalPaletsDom = TotalPaletsDom + Palets
            TotalBultosDom = TotalBultosDom + Bultos
            TotalKilosDom = TotalKilosDom + Kilos

            TotalPaletsCli = TotalPaletsCli + Palets
            TotalBultosCli = TotalBultosCli + Bultos
            TotalKilosCli = TotalKilosCli + Kilos

            TotalPalets = TotalPalets + Palets
            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos

            AuxIdCliente = IdCliente
            AuxCliente = Cliente
            AuxIdDomicilio = IdDomicilio
            AuxDomicilio = Domicilio
            AuxIdAlbaran = IdAlbaran
            AuxDatosAlbaran = DatosAlbaran


            Application.DoEvents()

        Next

        'Último total albarán
        Listado.Detalle.Linea("|-------|-------|----------", DLinAlb, Estilos.Reducida)

        Listado.Detalle.Linea(AuxDatosAlbaran & "|" & _
                              TotalPaletsAlb.ToString("#,##0") & "|" & _
                              TotalBultosAlb.ToString("#,##0") & "|" & _
                              TotalKilosAlb.ToString("#,##0"), DLinAlb, Estilos.ReducidaBold)
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

        'Último total domicilio
        Listado.Detalle.Linea("     Tot.Domic. " & AuxDomicilio & "|" & _
                                      TotalPaletsDom.ToString("#,##0") & "|" & _
                                      TotalBultosDom.ToString("#,##0") & "|" & _
                                      TotalKilosDom.ToString("#,##0"), DLinAlb, Estilos.ReducidaBold)
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

        'Ultimo total cliente
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea(VaInt(AuxIdCliente).ToString("00000") & " " & AuxCliente & "|" & _
                              TotalPaletsCli.ToString("#,##0") & "|" & _
                              TotalBultosCli.ToString("#,##0") & "|" & _
                              TotalKilosCli.ToString("#,##0"), DLinAlb, Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

        'Totales
        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)
        Listado.Detalle.Linea("    TOTAL LISTADO...|" & _
                              TotalPalets.ToString("#,##0") & "|" & _
                              TotalBultos.ToString("#,##0") & "|" & _
                              TotalKilos.ToString("#,##0"), DLinAlb, Estilos.ReducidaBold)
    End Sub

    Private Sub ConfigurarListadoResumidoPorGeneroYCategoria()
        Dim PuntoVenta As String = ""
        For Each s As String In LstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next

        If PuntoVenta = "" Then PuntoVenta = "TODOS"

        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea("LISTADO RESUMIDO POR GÉNERO Y CATEG. DE ALBARANES DE SALIDA|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Cliente " & CliDesde & " Hasta Cliente " & CliHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "| Desde Domic. " & DomDesde & " Hasta Domic. " & DomHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Tipo de venta: " & tipoVenta & "|" & "Con precio salida: " & ConPrecioSalida, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Valorados: " & Valorados & "|" & "Facturados: " & Facturados, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto venta: " & PuntoVenta, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "54|2|18|2|>18|>18|>18|>20|>20|>20"
        Dim Cabecera As String = "GENERO||CT/CL||K.SALID|K.VENDID|DIFER|IMP.SALIDA|IMP.VENTA|DIFERENC"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosSalGen As Decimal = 0
        Dim TotalKilosVenGen As Decimal = 0
        Dim TotalDifKilosGen As Decimal = 0
        Dim TotalImporteSalGen As Decimal = 0
        Dim TotalImporteVenGen As Decimal = 0
        Dim TotalDiferenciaGen As Decimal = 0

        Dim TotalKilosSal As Decimal = 0
        Dim TotalKilosVen As Decimal = 0
        Dim TotalDifKilos As Decimal = 0
        Dim TotalImporteSal As Decimal = 0
        Dim TotalImporteVen As Decimal = 0
        Dim TotalDiferencia As Decimal = 0

        Dim AuxIdPresentacion As String = ""
        Dim AuxPresentacion As String = ""

        For Each row As DataRow In Datos.Rows
            Dim IdPresentacion As String = (row("IdPresentacion").ToString & "").Trim
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim IdCategoria As String = (row("IdCategoria").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim KilosSal As Decimal = VaDec(row("KilosSal"))
            Dim KilosVen As Decimal = VaDec(row("KilosVen"))
            Dim DifKilos As Decimal = VaDec(row("DifKilos"))
            Dim ImporteSal As Decimal = VaDec(row("ImporteSal"))
            Dim ImporteVen As Decimal = VaDec(row("ImporteVen"))
            Dim Diferencia As Decimal = VaDec(row("Diferencia"))

            If IdPresentacion <> AuxIdPresentacion And AuxIdPresentacion <> "" Then
                'Resumen género anterior
                Listado.Detalle.Linea("||TOTAL..." & "||" & _
                                      TotalKilosSalGen.ToString("#,##0") & "|" & _
                                      TotalKilosVenGen.ToString("#,##0") & "|" & _
                                      TotalDifKilosGen.ToString("#,##0") & "|" & _
                                      TotalImporteSalGen.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenGen.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaGen.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)

                Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                TotalKilosSalGen = 0
                TotalKilosVenGen = 0
                TotalDifKilosGen = 0
                TotalImporteSalGen = 0
                TotalImporteVenGen = 0
                TotalDiferenciaGen = 0
            End If

            'Líneas de listado
            Dim det As String = Presentacion & "||"
            det = det & Categoria & "||"
            det = det & KilosSal.ToString("#,##0") & "|"
            det = det & KilosVen.ToString("#,##0") & "|"
            det = det & DifKilos.ToString("#,##0") & "|"
            det = det & ImporteSal.ToString("#,##0.00") & "|"
            det = det & ImporteVen.ToString("#,##0.00") & "|"
            det = det & Diferencia.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalKilosSalGen = TotalKilosSalGen + KilosSal
            TotalKilosVenGen = TotalKilosVenGen + KilosVen
            TotalDifKilosGen = TotalDifKilosGen + DifKilos
            TotalImporteSalGen = TotalImporteSalGen + ImporteSal
            TotalImporteVenGen = TotalImporteVenGen + ImporteVen
            TotalDiferenciaGen = TotalDiferenciaGen + Diferencia

            TotalKilosSal = TotalKilosSal + KilosSal
            TotalKilosVen = TotalKilosVen + KilosVen
            TotalDifKilos = TotalDifKilos + DifKilos
            TotalImporteSal = TotalImporteSal + ImporteSal
            TotalImporteVen = TotalImporteVen + ImporteVen
            TotalDiferencia = TotalDiferencia + Diferencia

            AuxIdPresentacion = IdPresentacion
            AuxPresentacion = Presentacion


            Application.DoEvents()

        Next

        'Último total por género
        Listado.Detalle.Linea("||TOTAL..." & "||" & _
                                      TotalKilosSalGen.ToString("#,##0") & "|" & _
                                      TotalKilosVenGen.ToString("#,##0") & "|" & _
                                      TotalDifKilosGen.ToString("#,##0") & "|" & _
                                      TotalImporteSalGen.ToString("#,##0.00") & "|" & _
                                      TotalImporteVenGen.ToString("#,##0.00") & "|" & _
                                      TotalDiferenciaGen.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)

        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

        'Totales
        Listado.Detalle.Linea("TOTAL LISTADO||||" & _
                                      TotalKilosSal.ToString("#,##0") & "|" & _
                                      TotalKilosVen.ToString("#,##0") & "|" & _
                                      TotalDifKilos.ToString("#,##0") & "|" & _
                                      TotalImporteSal.ToString("#,##0.00") & "|" & _
                                      TotalImporteVen.ToString("#,##0.00") & "|" & _
                                      TotalDiferencia.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
    End Sub

    Private Sub ConfigurarListadoResumidoPorGenero()
        Dim PuntoVenta As String = ""
        For Each s As String In LstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next

        If PuntoVenta = "" Then PuntoVenta = "TODOS"


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "190", Estilos.NormalBold)
        Listado.Cabecera.Linea("LISTADO RESUMIDO POR GÉNERO DE ALBARANES DE SALIDA|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Cliente " & CliDesde & " Hasta Cliente " & CliHasta & "|Desde " & FechaDesde & " Hasta " & FechaHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Género " & GenDesde & " Hasta Género " & GenHasta & "|Desde Categ. " & CatDesde & " Hasta Categ. " & CatHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Desde Albarán " & AlbDesde & " Hasta Albarán " & AlbHasta & "| Desde Domic. " & DomDesde & " Hasta Domic. " & DomHasta, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Tipo de venta: " & tipoVenta & "|" & "Con precio salida: " & ConPrecioSalida, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Valorados: " & Valorados & "|" & "Facturados: " & Facturados, "95|>95", Estilos.NormalBold)
        Listado.Cabecera.Linea("Punto venta: " & PuntoVenta, "190", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "74|2|>18|>18|>18|>20|>20|>20"
        Dim Cabecera As String = "GENERO||K.SALID|K.VENDID|DIFER|IMP.SALIDA|IMP.VENTA|DIFERENC"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalKilosSal As Decimal = 0
        Dim TotalKilosVen As Decimal = 0
        Dim TotalDifKilos As Decimal = 0
        Dim TotalImporteSal As Decimal = 0
        Dim TotalImporteVen As Decimal = 0
        Dim TotalDiferencia As Decimal = 0

        For Each row As DataRow In Datos.Rows
            Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim KilosSal As Decimal = VaDec(row("KilosSal"))
            Dim KilosVen As Decimal = VaDec(row("KilosVen"))
            Dim DifKilos As Decimal = VaDec(row("DifKilos"))
            Dim ImporteSal As Decimal = VaDec(row("ImporteSal"))
            Dim ImporteVen As Decimal = VaDec(row("ImporteVen"))
            Dim Diferencia As Decimal = VaDec(row("Diferencia"))

            'Líneas de listado
            Dim det As String = Genero & "||"
            det = det & KilosSal.ToString("#,##0") & "|"
            det = det & KilosVen.ToString("#,##0") & "|"
            det = det & DifKilos.ToString("#,##0") & "|"
            det = det & ImporteSal.ToString("#,##0.00") & "|"
            det = det & ImporteVen.ToString("#,##0.00") & "|"
            det = det & Diferencia.ToString("#,##0.00")
            Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

            TotalKilosSal = TotalKilosSal + KilosSal
            TotalKilosVen = TotalKilosVen + KilosVen
            TotalDifKilos = TotalDifKilos + DifKilos
            TotalImporteSal = TotalImporteSal + ImporteSal
            TotalImporteVen = TotalImporteVen + ImporteVen
            TotalDiferencia = TotalDiferencia + Diferencia


            Application.DoEvents()

        Next

        'Totales
        Listado.Detalle.Linea("TOTAL LISTADO||" & _
                                      TotalKilosSal.ToString("#,##0") & "|" & _
                                      TotalKilosVen.ToString("#,##0") & "|" & _
                                      TotalDifKilos.ToString("#,##0") & "|" & _
                                      TotalImporteSal.ToString("#,##0.00") & "|" & _
                                      TotalImporteVen.ToString("#,##0.00") & "|" & _
                                      TotalDiferencia.ToString("#,##0.00"), DLin, Estilos.ReducidaBold)
    End Sub

End Class
