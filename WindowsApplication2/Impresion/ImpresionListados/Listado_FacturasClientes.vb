Public Class Listado_FacturasClientes
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property Empresas As List(Of String)
    Property CliDesde As String
    Property CliHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property SerieDesde As String
    Property SerieHasta As String
    Property DetallarFacturas As Boolean
    Property FacturasCobradas As String
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim AnchoPagina As Integer = 280
    Dim Ancho As Integer = AnchoPagina

    Dim CabeceraDetallada As String = "N. Fra|Fecha|Albaran|Referencia|F.Salida|BaseImpGen|BaseImpEnv|I.V.A.|Gto. Sup.|T.Factura|Cobrado|Imp.Pte.|Acum.Pte."
    Dim CabeceraResumida As String = "Cliente|BaseImpGen|BaseImpEnv|I.V.A.|Gto. Sup.|T.Factura|Cobrado|Imp.Pte.|Acum.Pte."
    Dim FormatoDetallado As String = "25|20|23|30|18|>20|>20|>20|>20|>20|>20|>20|>20"
    Dim FormatoResumido As String = "116|>20|>20|>20|>20|>20|>20|>20|>20"


    Public Sub New(ByVal dt As DataTable, ByVal lstEmpresas As List(Of String), ByVal CliDesde As String, ByVal CliHasta As String,
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal SerieDesde As String, ByVal SerieHasta As String,
                   ByVal bDetallarFacturas As Boolean, ByVal FacturasCobradas As String, TipoImpresion As TipoImpresion)

        Me.Dt = dt
        Me.Empresas = lstEmpresas
        Me.CliDesde = CliDesde
        Me.CliHasta = CliHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.SerieDesde = SerieDesde
        Me.SerieHasta = SerieHasta
        Me.DetallarFacturas = bDetallarFacturas
        Me.FacturasCobradas = FacturasCobradas
        Me.TipoImpresion = TipoImpresion

    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 10
        Ancho = AnchoPagina - MargenIzq - MargenDer
        EstableceListado(Orientacion.Horizontal, TipoImpresion)

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

        Dim listaEmpresas As String = MetodosComunesListados.ObtenerListaFiltros(Empresas)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado de Facturas de Clientes"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Len(FechaDesde) > 0 Or Len(FechaHasta) > 0 Then
            Texto = "Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta & " | "
            Texto = Texto & "Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If listaEmpresas.Trim <> "" Then listaEmpresas = "Empresa: " & listaEmpresas

        Texto = "Desde Cliente " & CliDesde & " hasta Cliente " & CliHasta & " | " & listaEmpresas
        Formato = (Ancho - 130).ToString & "|>130"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Dim detallar As String = ""
        If DetallarFacturas Then
            detallar = "SI"
        Else
            detallar = "NO"
        End If


        Texto = "Desde Serie " & SerieDesde & " hasta Serie " & SerieHasta & " | " & "Detallar facturas: " & detallar
        Formato = (Ancho - 130).ToString & "|>130"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Texto = "Facturas cobradas: " & FacturasCobradas
        Formato = (Ancho).ToString
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)


        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)


    End Sub

    Private Sub ConfiguraDetalle()

        If DetallarFacturas Then
            Listado.Cabecera.Linea(CabeceraDetallada, FormatoDetallado, Estilos.ReducidaBoldLineaDebajo)
        Else
            Listado.Cabecera.Linea(CabeceraResumida, FormatoResumido, Estilos.ReducidaBoldLineaDebajo)
        End If
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Reducida)



        'Dim TotalBaseImp As Decimal = 0
        Dim TotalBaseImpGen As Decimal = 0
        Dim TotalBaseImpEnv As Decimal = 0
        Dim TotalIva As Decimal = 0
        Dim TotalGastoSup As Decimal = 0
        Dim TotalTotalFactura As Decimal = 0
        Dim TotalCobrado As Decimal = 0
        Dim TotalPendiente As Decimal = 0
        Dim TotalAcumPte As Decimal = 0

        'Dim TotalBaseImpCli As Decimal = 0
        Dim TotalBaseImpCliGen As Decimal = 0
        Dim TotalBaseImpCliEnv As Decimal = 0
        Dim TotalIvaCli As Decimal = 0
        Dim TotalGastoSupCli As Decimal = 0
        Dim TotalTotalFacturaCli As Decimal = 0
        Dim TotalCobradoCli As Decimal = 0
        Dim TotalPendienteCli As Decimal = 0
        Dim TotalAcumPteCli As Decimal = 0


        Dim AuxIdCliente As String = ""
        Dim AuxCliente As String = ""

        For Each row As DataRow In Dt.Rows

            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim Factura As String = (row("Factura").ToString & "").Trim
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Albaran As String = (row("Albaran").ToString & "").Trim
            Dim Referencia As String = (row("Referencia").ToString & "").Trim
            Dim FechaSalida As String = ""
            If VaDate(row("FechaSalida")) > VaDate("") Then FechaSalida = VaDate(row("FechaSalida")).ToString("dd/MM/yyyy")

            'Dim BaseImp As Decimal = VaDec(row("BaseImp"))
            Dim BaseImpGen As Decimal = VaDec(row("BaseImpGen"))
            Dim BaseImpEnv As Decimal = VaDec(row("BaseImpEnv"))
            Dim BaseImpVar As Decimal = VaDec(row("BaseImpVar"))
            Dim BaseImp As Decimal = BaseImpGen + BaseImpEnv + BaseImpVar


            Dim Iva As Decimal = VaDec(row("Iva"))
            Dim GastoSup As Decimal = VaDec(row("GastoSup"))
            Dim TotalFactura As Decimal = VaDec(row("TotalFactura"))
            Dim Cobrado As Decimal = VaDec(row("Cobrado"))
            Dim Pendiente As Decimal = VaDec(row("Pendiente"))
            Dim AcumPte As Decimal = VaDec(row("AcumPte"))


            If AuxIdCliente <> IdCliente And AuxIdCliente <> "" Then

                If DetallarFacturas Then

                    Listado.Detalle.Linea(AuxCliente & "|" & _
                                          TotalBaseImpCliGen.ToString("#,##0.00") & "|" & _
                                          TotalBaseImpCliEnv.ToString("#,##0.00") & "|" & _
                                          TotalIvaCli.ToString("#,##0.00") & "|" & _
                                          TotalGastoSupCli.ToString("#,##0.00") & "|" & _
                                          TotalTotalFacturaCli.ToString("#,##0.00") & "|" & _
                                          TotalCobradoCli.ToString("#,##0.00") & "|" & _
                                          TotalPendienteCli.ToString("#,##0.00") & "|" & _
                                          TotalAcumPteCli.ToString("#,##0.00"), FormatoResumido, Estilos.ReducidaBoldLineaEncima)
                    Listado.Detalle.Linea(" ", "200", Estilos.ReducidaBold)

                End If



                If DetallarFacturas Then
                    TotalAcumPte = TotalAcumPte + TotalAcumPteCli
                End If

                'TotalBaseImpCli = 0
                TotalBaseImpCliGen = 0
                TotalBaseImpCliEnv = 0
                TotalIvaCli = 0
                TotalGastoSupCli = 0
                TotalTotalFacturaCli = 0
                TotalCobradoCli = 0
                TotalPendienteCli = 0
                TotalAcumPteCli = 0

            End If


            'TotalBaseImpCli = TotalBaseImpCli + BaseImp
            TotalBaseImpCliGen = TotalBaseImpCliGen + BaseImpGen
            TotalBaseImpCliEnv = TotalBaseImpCliEnv + BaseImpEnv
            TotalIvaCli = TotalIvaCli + Iva
            TotalGastoSupCli = TotalGastoSupCli + GastoSup
            TotalTotalFacturaCli = TotalTotalFacturaCli + TotalFactura
            TotalCobradoCli = TotalCobradoCli + Cobrado
            TotalPendienteCli = TotalPendienteCli + Pendiente


            'TotalBaseImp = TotalBaseImp + BaseImp
            TotalBaseImpGen = TotalBaseImpGen + BaseImpGen
            TotalBaseImpEnv = TotalBaseImpEnv + BaseImpEnv
            TotalIva = TotalIva + Iva
            TotalGastoSup = TotalGastoSup + GastoSup
            TotalTotalFactura = TotalTotalFactura + TotalFactura
            TotalCobrado = TotalCobrado + Cobrado
            TotalPendiente = TotalPendiente + Pendiente

            If DetallarFacturas Then
                TotalAcumPteCli = AcumPte
            Else
                TotalAcumPteCli = TotalAcumPteCli + AcumPte
                TotalAcumPte = TotalAcumPte + AcumPte
            End If


            Dim det As String = ""

            If DetallarFacturas Then
                det = det & Factura & "|"
                det = det & Fecha & "|"
                det = det & Albaran & "|"
                det = det & Referencia & "|"
                det = det & FechaSalida & "|"
            Else
                det = det & Cliente & "|"
            End If
            'det = det & BaseImp.ToString("#,##0.00") & "|"
            det = det & BaseImpGen.ToString("#,##0.00") & "|"
            det = det & BaseImpEnv.ToString("#,##0.00") & "|"
            det = det & Iva.ToString("#,##0.00") & "|"
            det = det & GastoSup.ToString("#,##0.00") & "|"
            det = det & TotalFactura.ToString("#,##0.00") & "|"
            det = det & Cobrado.ToString("#,##0.00") & "|"
            det = det & Pendiente.ToString("#,##0.00") & "|"
            det = det & AcumPte.ToString("#,##0.00")
            If DetallarFacturas Then
                Listado.Detalle.Linea(det, FormatoDetallado, Estilos.Reducida)
            Else
                Listado.Detalle.Linea(det, FormatoResumido, Estilos.Reducida)
            End If



            AuxIdCliente = IdCliente
            AuxCliente = Cliente

            Application.DoEvents()

        Next


        Dim tot As String = ""

        'Último total cliente
        If DetallarFacturas Then
            tot = AuxCliente & "|"
            'tot = tot & TotalBaseImpCli.ToString("#,##0.00") & "|"
            tot = tot & TotalBaseImpCliGen.ToString("#,##0.00") & "|"
            tot = tot & TotalBaseImpCliEnv.ToString("#,##0.00") & "|"
            tot = tot & TotalIvaCli.ToString("#,##0.00") & "|"
            tot = tot & TotalGastoSupCli.ToString("#,##0.00") & "|"
            tot = tot & TotalTotalFacturaCli.ToString("#,##0.00") & "|"
            tot = tot & TotalCobradoCli.ToString("#,##0.00") & "|"
            tot = tot & TotalPendienteCli.ToString("#,##0.00") & "|"
            tot = tot & TotalAcumPteCli.ToString("#,##0.00")
            Listado.Detalle.Linea(tot, FormatoResumido, Estilos.ReducidaBoldLineaEncima)
            Listado.Detalle.Linea(" ", "200", Estilos.ReducidaBold)
        End If


        If DetallarFacturas Then
            TotalAcumPte = TotalAcumPte + TotalAcumPteCli
        End If


        'Gran total
        tot = "   TOTAL LISTADO|"
        tot = tot & TotalBaseImpGen.ToString("#,##0.00") & "|"
        tot = tot & TotalBaseImpEnv.ToString("#,##0.00") & "|"
        tot = tot & TotalIva.ToString("#,##0.00") & "|"
        tot = tot & TotalGastoSup.ToString("#,##0.00") & "|"
        tot = tot & TotalTotalFactura.ToString("#,##0.00") & "|"
        tot = tot & TotalCobrado.ToString("#,##0.00") & "|"
        tot = tot & TotalPendiente.ToString("#,##0.00") & "|"
        tot = tot & TotalAcumPte.ToString("#,##0.00")
        Listado.Detalle.Linea(" ", "274", Estilos.ReducidaBoldLineaDebajo)
        Listado.Detalle.Linea(tot, FormatoResumido, Estilos.ReducidaBold)


    End Sub


End Class
