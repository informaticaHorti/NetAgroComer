Imports System.Drawing
Imports DevExpress.XtraEditors


Module FacturacionEnvases


#Region "Clases para impresión facturas de envases"

    Private Class LineaDesgloseEnvases

        Public Bultos As Decimal = 0
        Public Envase As String = ""
        Public Precio As Decimal = 0
        Public Importe As Decimal = 0

        Public Sub New(Bultos As Decimal, Envase As String, Precio As Decimal, Importe As Decimal)

            Me.Bultos = Bultos
            Me.Envase = Envase
            Me.Precio = Precio
            Me.Importe = Importe

        End Sub

    End Class



    Private Class DatosCabecera

        Public IdFactura As String = ""
        Public NumAlbaran As String = "" 'Sólo en caso de que sea factura, para guardar el Albaran
        Public IdAlbaran As String = "" 'Idem
        Public IdCliente As Integer = 0
        Public Fecha As String = ""
        Public NumeroDocumento As String = ""
        Public NIF As String = ""
        Public Nombre As String = ""
        Public Domicilio As String = ""
        Public Poblacion As String = ""
        Public Provincia As String = ""
        Public CPostal As String = ""
        Public Base1 As Decimal = 0
        Public Base2 As Decimal = 0
        Public Base3 As Decimal = 0
        Public Iva1 As Decimal = 0
        Public Iva2 As Decimal = 0
        Public Iva3 As Decimal = 0
        Public Cuota1 As Decimal = 0
        Public Cuota2 As Decimal = 0
        Public Cuota3 As Decimal = 0
        Public Re1 As Decimal = 0
        Public Re2 As Decimal = 0
        Public Re3 As Decimal = 0
        Public CuotaRe1 As Decimal = 0
        Public CuotaRe2 As Decimal = 0
        Public CuotaRe3 As Decimal = 0

        Public FacturaGasto As Integer = 0

        Public EsCopia As Boolean = False
        Public DatosEmpresa As New DatosEmpresa   'De momento, como una variable con retornos de carro

    End Class


#End Region


#Region "Facturas"

    Public Sub ImprimirFacturaEnvases(ByVal IdFactura As String, TipoImpresion As TipoImpresion, bCopia As Boolean, Impresora As String, rutaPDF As String, archivoPDF As String)

        Dim err As New Errores

        If VaDec(IdFactura) > 0 Then

            'Datos Cabecera
            Dim DatosCabecera As New DatosCabecera
            DatosCabecera.IdFactura = IdFactura
            DatosCabecera.EsCopia = bCopia


            Dim Informe As New miInforme(False)
            Informe.Contenedor.PaperKind = Printing.PaperKind.A4
            Informe.Contenedor.PrintingSystem.ShowMarginsWarning = False

            Informe.Contenedor.MinMargins.Top = 0
            Informe.Contenedor.MinMargins.Left = 0
            Informe.Contenedor.MinMargins.Right = 0
            Informe.Contenedor.MinMargins.Bottom = 0

            Informe.Contenedor.Margins.Top = 0
            Informe.Contenedor.Margins.Left = 0
            Informe.Contenedor.Margins.Right = 0
            Informe.Contenedor.Margins.Bottom = 0


            'Cabecera factura
            Dim margen_izquierdo As Integer = 14
            Dim Col As New List(Of Integer)
            Col.Add(0)
            Col.Add(margen_izquierdo)   'Col1
            Col.Add(Col(1) + 17)        'Col2
            Col.Add(Col(2) + 85)        'Col3
            Col.Add(Col(3) + 50)        'Col4


            'Cabecera
            Dim miFactura As New miFactura()
            Dim BaseLineas As Integer = 0
            Dim NumFactura As String = ""
            Dim Fecha As String = ""
            Dim Cliente As String = ""
            Dim pag_actual As Integer = 1
            Dim inicio_pag_actual As Integer = 7
            Dim altura As Integer = inicio_pag_actual


            'Obtenemos los datos de la cabecera
            Try
                ObtenerDatosCabecera(DatosCabecera, IdFactura)
            Catch ex As Exception
                err.Muestraerror("Error al imprimir en tipo de documento", "ImprimirFacturaEnvases", ex.Message)
                Exit Sub
            End Try


            'Imprime cabecera
            ImprimeCabeceraFacturaEnvases(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineas)

            'Detalle y totales detalle
            Dim TotalBultos As Decimal = 0
            Dim TotalImporte As Decimal = 0
            Dim ImporteGenerosGastos As Decimal = 0
            'Dim Envases As New ListaEnvases
            ImprimeDetalleFacturaEnvases(DatosCabecera, miFactura, altura, margen_izquierdo, BaseLineas, Col,
                                  ImporteGenerosGastos, pag_actual, inicio_pag_actual, TotalBultos, TotalImporte)




            'Totales
            ImprimeTotalesFacturaEnvases(DatosCabecera, miFactura, altura, Col, TotalBultos, TotalImporte, ImporteGenerosGastos, margen_izquierdo, pag_actual, inicio_pag_actual)

            'Pie
            ImprimePieFacturaEnvases(DatosCabecera, miFactura, altura, margen_izquierdo, pag_actual, inicio_pag_actual)


            'Datos fiscales
            miFactura.Titulo_Pie(DatosCabecera.DatosEmpresa.DatosFiscalesEmpresa, 7, 1, 196, 3, milinea.stilos.Minima, "=")


            'Añadimos el documento al informe
            Informe.AñadeDetalles(miFactura)



            'Impresión / previsualización / exportación
            Select Case TipoImpresion

                Case TipoImpresion.Preliminar
                    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)

                Case TipoImpresion.ImpresoraSeleccionada
                    If Impresora.Trim <> "" Then
                        Informe.ImpresionDirecta(Impresora)
                    Else
                        Informe.ImpresionDirecta()
                    End If

                Case TipoImpresion.ExportacionPDF
                    If rutaPDF.Trim <> "" And archivoPDF.Trim <> "" Then
                        Informe.Contenedor.CreateDocument()
                        Try
                            Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                            options.Compressed = True
                            Informe.Contenedor.ExportToPdf(rutaPDF & archivoPDF, options)

                        Catch ex As Exception
                            err.Muestraerror("Error al exportar el documento con id" & IdFactura & " a PDF", "ImprimirAlbaranFactura", ex.Message)
                        End Try

                    Else
                        Informe.ImpresionDirecta()
                    End If

                Case Else
                    Informe.ImpresionDirecta()
            End Select


            Informe.Dispose()


        Else
            XtraMessageBox.Show("No hay datos que imprimir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ObtenerDatosCabecera(ByRef DatosCabecera As DatosCabecera, Id As String)


        Dim Factura As New E_Facturas(Idusuario, cn)
        If Not Factura.LeerId(Id) Then
            XtraMessageBox.Show("No existe la factura con Id " & Id, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        DatosCabecera.IdCliente = VaInt(Factura.FRA_idcliente.Valor)
        If VaDate(Factura.FRA_fecha.Valor) <> VaDate("") Then DatosCabecera.Fecha = VaDate(Factura.FRA_fecha.Valor).ToString("dd/MM/yyyy")
        DatosCabecera.NumeroDocumento = Factura.FRA_factura.Valor
        If (Factura.FRA_serie.Valor & "").Trim <> "" Then DatosCabecera.NumeroDocumento = (Factura.FRA_serie.Valor & "").Trim & "-" & DatosCabecera.NumeroDocumento

        DatosCabecera.Base1 = Factura.FRA_Base1.Valor
        DatosCabecera.Base2 = Factura.FRA_Base2.Valor
        DatosCabecera.Base3 = Factura.FRA_Base3.Valor
        DatosCabecera.Iva1 = Factura.FRA_Iva1.Valor
        DatosCabecera.Iva2 = Factura.FRA_Iva2.Valor
        DatosCabecera.Iva3 = Factura.FRA_Iva3.Valor
        DatosCabecera.Cuota1 = Factura.FRA_Cuota1.Valor
        DatosCabecera.Cuota2 = Factura.FRA_Cuota2.Valor
        DatosCabecera.Cuota3 = Factura.FRA_Cuota3.Valor
        DatosCabecera.Re1 = Factura.FRA_Re1.Valor
        DatosCabecera.Re2 = Factura.FRA_Re2.Valor
        DatosCabecera.Re3 = Factura.FRA_Re3.Valor
        DatosCabecera.CuotaRe1 = Factura.FRA_CuotaRe1.Valor
        DatosCabecera.CuotaRe2 = Factura.FRA_CuotaRe2.Valor
        DatosCabecera.CuotaRe3 = Factura.FRA_CuotaRe3.Valor

        DatosCabecera.FacturaGasto = VaInt(Factura.FRA_FacturaGasto.Valor)


        'Dim CONSULTA As New Cdatos.E_select
        'CONSULTA.SelCampo(AlbSalidaALH.AAH_idalbaran, "IdAlbaran")
        'CONSULTA.SelCampo(AlbSalidaALH.AAH_albaran, "Albaran")
        'CONSULTA.WheCampo(AlbSalidaALH.AAH_idfactura, "=", Id)

        'Dim dt As DataTable = AlbSalidaALH.MiConexion.ConsultaSQL(CONSULTA.SQL)
        'If Not IsNothing(dt) Then
        '    If dt.Rows.Count > 0 Then
        '        DatosCabecera.NumAlbaran = dt.Rows(0)("Albaran")
        '        DatosCabecera.IdAlbaran = dt.Rows(0)("IdAlbaran")
        '    End If
        'End If


        'Datos cliente
        Dim Clientes As New E_Clientes(Idusuario, cn)
        If Clientes.LeerId(DatosCabecera.IdCliente) Then

            DatosCabecera.NIF = (Clientes.CLI_Nif.Valor & "").Trim
            DatosCabecera.Nombre = (Clientes.CLI_Nombre.Valor & "").Trim
            DatosCabecera.Domicilio = (Clientes.CLI_Domicilio.Valor & "").Trim
            DatosCabecera.Poblacion = (Clientes.CLI_Poblacion.Valor & "").Trim
            DatosCabecera.Provincia = (Clientes.CLI_Provincia.Valor & "").Trim
            DatosCabecera.CPostal = (Clientes.CLI_CPostal.Valor & "").Trim

        End If


    End Sub


    Private Sub ImprimeCabeceraFacturaEnvases(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                              ByRef inicio_pag_actual As Integer,
                                              margen_izquierdo As Integer, Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)


        Dim titulo As String = "FACTURA"

        'Imprime cabecera
        inicio_pag_actual = altura
        miFactura.Titulo(DatosCabecera.DatosEmpresa.NombreEmpresa, 110, altura, 90, 6, milinea.stilos.GrandeBold)
        altura = altura + 6

        miFactura.Titulo(DatosCabecera.DatosEmpresa.FilaDatos(), 110, altura, 90, 14, milinea.stilos.MinimaBold)
        altura = altura + 14


        If DatosCabecera.EsCopia Then
            miFactura.Titulo("##### COPIA #####", 135, altura, 52, 5, milinea.stilos.GrandeBold)
        End If
        altura = altura + 6


        miFactura.Cuadro(margen_izquierdo, altura, 95, 28, 0.25, Color.Black)
        miFactura.Titulo(DatosCabecera.Nombre, margen_izquierdo + 3, altura + 3, 91, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.Domicilio, margen_izquierdo + 3, altura + 9, 91, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.Poblacion, margen_izquierdo + 3, altura + 15, 91, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.Provincia & " " & DatosCabecera.CPostal, margen_izquierdo + 3, altura + 21, 91, 5, milinea.stilos.NormalBold)
        altura = altura + 2
        miFactura.Cuadro(135, altura, 52, 10, 0.25, Color.Black)
        miFactura.LineaH(135, altura + 5, 52, 0.25, Color.Black)
        miFactura.LineaV(163, altura, 10, 0.25, Color.Black)
        miFactura.Titulo("FECHA", 140, altura + 1, 20, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.Fecha, 136, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        miFactura.Titulo(titulo, 168, altura + 1, 20, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.NumeroDocumento, 164, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        altura = altura + 13
        miFactura.Cuadro(135, altura, 52, 10, 0.25, Color.Black)
        miFactura.LineaH(135, altura + 5, 52, 0.25, Color.Black)
        miFactura.LineaV(163, altura, 10, 0.25, Color.Black)
        miFactura.Titulo("N.I.F.", 140, altura + 1, 20, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.NIF, 136, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        miFactura.Titulo("CODIGO", 168, altura + 1, 20, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(VaInt(DatosCabecera.IdCliente).ToString("00000"), 164, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        'miFactura.Titulo("Albaran nº " & VaInt(DatosCabecera.NumAlbaran).ToString("000000"), 140, altura + 11, 48, 5, milinea.stilos.Reducida, "<")
        altura = altura + 10 + 3 + 5


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            miFactura.LineaH(margen_izquierdo, altura, 180, 0.25, Color.Black)
            miFactura.LineaH(margen_izquierdo, altura + 5, 180, 0.25, Color.Black)
            miFactura.Titulo("BULTOS", Col(1) + 2, altura + 1, 18, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("ENVASE", Col(2) + 10, altura + 1, 55, 5, milinea.stilos.ReducidaBold, "<")
            miFactura.Titulo("PRECIO", Col(3) + 5, altura + 1, 25, 5, milinea.stilos.ReducidaBold, "=")
            miFactura.Titulo("IMPORTE", Col(4) + 5, altura + 1, 25, 5, milinea.stilos.ReducidaBold, "=")

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleFacturaEnvases(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                             margen_izquierdo As Integer, BaseLineas As Integer, Col As List(Of Integer),
                                             ByRef TotalImporteGenerosGastos As Decimal, ByRef pag_actual As Integer,
                                             ByRef inicio_pag_actual As Integer, ByRef TotalBultos As Decimal, ByRef TotalImporte As Decimal)


        'Líneas Detalle

        'TotalImporteGenerosGastos = 0

        Dim ValeEnvase As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvase_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvase.VEV_Idvale, "Idvale")
        consulta.SelCampo(ValeEnvase.VEV_Campa, "Campa")
        consulta.SelCampo(ValeEnvase.VEV_Numero, "Albaran")
        consulta.SelCampo(ValeEnvase.VEV_Idcentro, "CE")
        consulta.SelCampo(ValeEnvase.VEV_Fecha, "Fecha")
        consulta.SelCampo(ValeEnvase.VEV_Referencia, "Referencia")
        consulta.SelCampo(ValeEnvase.VEV_Concepto, "Concepto")
        consulta.WheCampo(ValeEnvase.VEV_TipoSujeto, "=", "C")
        Dim sql As String = consulta.SQL & vbCrLf & " AND COALESCE(VEV_IdFactura,0) = " & DatosCabecera.IdFactura & vbCrLf
        sql = sql + "AND  (VEV_OPERACION='CC' OR VEV_OPERACION='DV') "
        Dim dt As DataTable = ValeEnvase.MiConexion.ConsultaSQL(sql)


        For Each rowVale As DataRow In dt.Rows

            Dim IdVaLe As String = (rowVale("IdVale").ToString & "").Trim

            sql = "SELECT SUM(VEL_Retira - VEL_Entrega) as Bultos, ENV_Nombre as Envase," & vbCrLf
            sql = sql & " VEL_PrecioRetira as PrecioRetira, VEL_PrecioEntrega as PrecioEntrega," & vbCrLf
            sql = sql & " SUM(VEL_RETIRA * VEL_PRECIORETIRA) - SUM(VEL_ENTREGA * VEL_PRECIOENTREGA) as Importe" & vbCrLf
            sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
            sql = sql & " WHERE VEL_IdVale = " & IdVaLe & vbCrLf
            sql = sql & " GROUP BY VEL_Id, VEL_IdEnvase, ENV_Nombre, VEL_PrecioRetira, VEL_PrecioEntrega" & vbCrLf
            sql = sql & " HAVING (SUM(VEL_RETIRA * VEL_PRECIORETIRA) - SUM(VEL_ENTREGA * VEL_PRECIOENTREGA)) <> 0" & vbCrLf

            Dim dtLineas As DataTable = ValeEnvase.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dtLineas) Then

                If dtLineas.Rows.Count > 0 Then


                    'TODO: Línea cabecera valeenvase
                    Dim Campa As String = VaInt(rowVale("Campa")).ToString("00")
                    Dim Albaran As String = (rowVale("Albaran").ToString & "").Trim
                    Dim Centro As String = (rowVale("CE").ToString & "").Trim
                    Dim Fecha As String = ""
                    If VaDate(rowVale("Fecha")) <> VaDate("") Then Fecha = VaDate(rowVale("Fecha")).ToString("dd/MM/yyyy")
                    Dim Concepto As String = (rowVale("Concepto").ToString & "").Trim

                    Dim texto_cabecera_vale As String = "Alb.: " & Campa & "-" & Albaran & " " & Concepto & ". CE.: " & Centro & " Fec.: " & Fecha
                    miFactura.Titulo(texto_cabecera_vale, Col(1) + 1, altura, 100, 4, milinea.stilos.ReducidaBold)
                    altura = altura + 4


                    For Each row As DataRow In dtLineas.Rows


                        'Líneas desglose valeenvase
                        Dim Bultos As Decimal = VaDec(row("Bultos"))
                        Dim Envase As String = row("Envase").ToString & ""
                        Dim PrecioRetira As Decimal = VaDec(row("PrecioRetira"))
                        Dim PrecioEntrega As Decimal = VaDec(row("PrecioEntrega"))
                        Dim Importe As Decimal = VaDec(row("Importe"))

                        Dim Precio As Decimal = 0
                        If Bultos > 0 Then
                            Precio = PrecioRetira
                        ElseIf Bultos < 0 Then
                            Precio = PrecioEntrega
                        End If


                        TotalBultos = TotalBultos + Bultos
                        TotalImporte = TotalImporte + Importe

                        Dim linea As New LineaDesgloseEnvases(Bultos, Envase, Precio, Importe)
                        ImprimeLineaFacturaEnvases(DatosCabecera, miFactura, linea, altura, Col, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas)

                    Next

                    altura = altura + 4

                End If

            End If

        Next






        altura = altura + 1



        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 127 Then
            altura = BaseLineas + 127
        End If



        'Líneas laterales
        miFactura.LineaH(margen_izquierdo, altura, 180, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 180, BaseLineas, altura - BaseLineas, 0.25, Color.Black)

        altura = altura + 2



    End Sub


    Private Sub ImprimeLineaFacturaEnvases(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, linea As LineaDesgloseEnvases,
                                    ByRef altura As Integer, Col As List(Of Integer), ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                    margen_izquierdo As Integer, ByRef BaseLineas As Integer)


        'Comprueba salto de linea
        Dim altura_linea As Integer = 4
        If CompruebaSaltoPagina(altura, altura_linea, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas, Col)
        End If


        miFactura.Titulo(linea.Bultos.ToString("#,##0"), Col(1) + 1, altura, 14, 5, milinea.stilos.Reducida, ">")
        miFactura.Titulo(linea.Envase, Col(2) + 1, altura, 83, 5, milinea.stilos.Reducida)
        miFactura.Titulo(linea.Precio.ToString("#,##0.000000"), Col(3) + 1, altura, 23, 5, milinea.stilos.Reducida, ">")
        miFactura.Titulo(linea.Importe.ToString("#,##0.000"), Col(4) + 1, altura, 23, 5, milinea.stilos.Reducida, ">")

        altura = altura + 5


    End Sub


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer, pag_actual As Integer) As Boolean

        Dim bRes As Boolean = False

        'Detectamos si debe efectuarse un salto de página
        Dim pagina As Integer = ((altura + altura_linea) \ 282) + 1
        If pagina > pag_actual Then
            bRes = True
        End If


        Return bRes

    End Function


    Private Sub ImprimeSaltoPagina(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                          ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer, margen_izquierdo As Integer,
                                          ByRef BaseLineas As Integer, Col As List(Of Integer))


        'Líneas laterales
        If BaseLineas > 0 Then
            miFactura.LineaH(margen_izquierdo, altura, 180, 0.25, Color.Black)
            miFactura.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
            miFactura.LineaV(margen_izquierdo + 180, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
        End If


        Dim salto As Integer = ((297 - 15) * (pag_actual - 1))

        'Para asegurarnos de que el pie de página no suba
        miFactura.LineaH(0, salto - 1, 210, 0.25, Color.Transparent)
        miFactura.SaltoPagina(salto)

        altura = salto
        altura = altura + 7


        ImprimeCabeceraFacturaEnvases(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineas)


    End Sub



    Private Sub ImprimeTotalesFacturaEnvases(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                             Col As List(Of Integer), TotalBultos As Decimal, TotalImporte As Decimal,
                                             ImporteGenerosGastos As Decimal, margen_izquierdo As Integer, ByRef pag_actual As Integer,
                                             ByRef inicio_pag_actual As Integer)


        'Totales de Bultos, Kilos e Importe
        miFactura.Cuadro(Col(1), altura, 18, 5, 0.25, Color.Black)
        miFactura.Titulo(TotalBultos.ToString("#,##0"), Col(1) + 1, altura + 1, 14, 5, milinea.stilos.Reducida, ">")

        'Comisiones
        'Dim GastosCabecera As Decimal = CalculaTotalGasto(DatosCabecera.IdAlbaran)
        'If GastosCabecera <> 0 Then
        '    miFactura.Titulo("TOTAL GASTO   " & GastosCabecera.ToString("#,##0.00"), 43, altura + 1, 45, 5, milinea.stilos.Reducida)
        'End If

        miFactura.Cuadro(Col(4) - 6, altura, 34, 5, 0.25, Color.Black)
        miFactura.Titulo(TotalImporte.ToString("#,##0.00"), Col(4) - 5, altura + 1, 30, 5, milinea.stilos.Reducida, ">")

        altura = altura + 14


        'Comprueba salto de linea
        Dim alto As Integer = 31
        If CompruebaSaltoPagina(altura, alto, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, 0, Col)
        End If


        miFactura.Titulo("Base Imponible", 60, altura, 20, 3, milinea.stilos.MinimaBold)
        miFactura.Titulo("%", 87, altura, 4, 3, milinea.stilos.MinimaBold)
        miFactura.Titulo("Importe I.V.A.", 98, altura, 20, 3, milinea.stilos.MinimaBold)
        miFactura.Titulo("%", 119, altura, 4, 3, milinea.stilos.MinimaBold)
        miFactura.Titulo("Importe R.E.", 133, altura, 20, 3, milinea.stilos.MinimaBold)
        altura = altura + 3

        miFactura.LineaH(55, altura, 95, 0.25, Color.Black)
        miFactura.LineaH(55, altura + 14, 95, 0.25, Color.Black)
        miFactura.LineaV(55, altura, 14, 0.25, Color.Black)
        miFactura.LineaV(84, altura, 14, 0.25, Color.Black)
        miFactura.LineaV(93, altura, 14, 0.25, Color.Black)
        miFactura.LineaV(116, altura, 14, 0.25, Color.Black)
        miFactura.LineaV(125, altura, 14, 0.25, Color.Black)
        miFactura.LineaV(150, altura, 14, 0.25, Color.Black)


        'Bases
        If VaDec(DatosCabecera.Base1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Base1).ToString("#,##0.00"), 57, altura + 1, 24, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Base2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Base2).ToString("#,##0.00"), 57, altura + 5, 24, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Base3) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Base3).ToString("#,##0.00"), 57, altura + 9, 24, 5, milinea.stilos.Reducida, ">")

        '%IVA
        If VaDec(DatosCabecera.Iva1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Iva1).ToString("#,##0.00"), 83, altura + 1, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Iva2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Iva2).ToString("#,##0.00"), 83, altura + 5, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Iva3) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Iva3).ToString("#,##0.00"), 83, altura + 9, 10, 5, milinea.stilos.Reducida, ">")

        'CuotaIVA
        If VaDec(DatosCabecera.Cuota1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Cuota1).ToString("#,##0.00"), 94, altura + 1, 22, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Cuota2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Cuota2).ToString("#,##0.00"), 94, altura + 5, 22, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Cuota3) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Cuota3).ToString("#,##0.00"), 94, altura + 9, 22, 5, milinea.stilos.Reducida, ">")

        '%RE
        If VaDec(DatosCabecera.Re1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Re1).ToString("#,##0.00"), 115, altura + 1, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Re2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Re2).ToString("#,##0.00"), 115, altura + 5, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Re3) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Re3).ToString("#,##0.00"), 115, altura + 9, 10, 5, milinea.stilos.Reducida, ">")

        'CuotaRE
        If VaDec(DatosCabecera.CuotaRe1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaRe1).ToString("#,##0.00"), 126, altura + 1, 23, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.CuotaRe2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaRe2).ToString("#,##0.00"), 126, altura + 5, 23, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.CuotaRe3) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaRe3).ToString("#,##0.00"), 126, altura + 9, 23, 5, milinea.stilos.Reducida, ">")

        'Totales bases
        miFactura.Cuadro(Col(4) - 6, altura, 34, 14, 0.25, Color.Black)
        Dim TotalBase1 As Decimal = VaDec(DatosCabecera.Base1) + VaDec(DatosCabecera.Cuota1) + VaDec(DatosCabecera.CuotaRe1)
        Dim TotalBase2 As Decimal = VaDec(DatosCabecera.Base2) + VaDec(DatosCabecera.Cuota2) + VaDec(DatosCabecera.CuotaRe2)
        Dim TotalBase3 As Decimal = VaDec(DatosCabecera.Base3) + VaDec(DatosCabecera.Cuota3) + VaDec(DatosCabecera.CuotaRe3)
        Dim TotalFactura As Decimal = TotalBase1 + TotalBase2 + TotalBase3

        If TotalBase1 <> 0 Then miFactura.Titulo(TotalBase1.ToString("#,##0.00"), Col(4) - 5, altura + 1, 30, 5, milinea.stilos.Reducida, ">")
        If TotalBase2 <> 0 Then miFactura.Titulo(TotalBase2.ToString("#,##0.00"), Col(4) - 5, altura + 5, 30, 5, milinea.stilos.Reducida, ">")
        If TotalBase3 <> 0 Then miFactura.Titulo(TotalBase3.ToString("#,##0.00"), Col(4) - 5, altura + 9, 30, 5, milinea.stilos.Reducida, ">")


        Dim titulo As String = "FACTURA"

        miFactura.Titulo("Matricula vehiculo:", 58, altura + 18, 25, 5, milinea.stilos.Minima)
        miFactura.Titulo("TOTAL " & titulo, 128, altura + 19, 30, 5, milinea.stilos.ReducidaBold, ">")
        altura = altura + 5

        miFactura.Titulo("El Comprador o persona autorizada", 10, altura, 40, 3, milinea.stilos.MinimaBold)
        miFactura.Titulo("D.N.I. Nº", 10, altura + 20, 40, 3, milinea.stilos.MinimaBold)
        altura = altura + 13


        'Total factura
        miFactura.Cuadro(Col(4) - 6, altura, 34, 5, 0.25, Color.Black)
        miFactura.Titulo(TotalFactura.ToString("#,##0.00"), Col(4) - 5, altura + 1, 30, 5, milinea.stilos.ReducidaBold, ">")

        altura = altura + 13

    End Sub


    Private Sub ImprimePieFacturaEnvases(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                         margen_izquierdo As Integer, ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer)


        'Comprueba salto de linea
        Dim alto As Integer = 30
        If CompruebaSaltoPagina(altura, alto, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, 0, Nothing)
        End If



        'Detalle envases
        Dim BaseAltura As Integer = altura


        'Instrucciones de pago
        Dim fuente As New Font("Tahoma", 7, FontStyle.Regular)
        Dim fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)


        miFactura.LineaH(margen_izquierdo + 104 + 2, altura, 75, 0.25, Color.Black)
        miFactura.LineaH(margen_izquierdo + 104 + 2, altura + 32 + 1, 75, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 104 + 2, altura, 33, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 104 + 2 + 75, altura, 33, 0.25, Color.Black)

        miFactura.Titulo("INSTRUCCIONES DE PAGO:", margen_izquierdo + 104 + 2 + 1, altura + 1, 73, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 5
        miFactura.Titulo("A Vencimiento, sírvase ingresar en nuestra cuenta, como sigue:", margen_izquierdo + 104 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("-Banco: " & DatosCabecera.DatosEmpresa.NombreBanco, margen_izquierdo + 104 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("-Entidad/Sucursal: ", margen_izquierdo + 104 + 3, altura, 22, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.EntidadSucursal, margen_izquierdo + 104 + 3 + 20, altura, 22, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-IBAN: ", margen_izquierdo + 104 + 3, altura, 10, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.IBAN, margen_izquierdo + 104 + 2 + 9, altura, 63, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-Swift Code: ", margen_izquierdo + 104 + 3, altura, 17, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.Swift, margen_izquierdo + 104 + 3 + 14, altura, 56, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-Beneficiario: HORTOFRUTICOLA COSTA DE ALMERIA, S.L.", margen_izquierdo + 104 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("CIF: B04257028", margen_izquierdo + 104 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)



        'Saldo de envases
        altura = BaseAltura


        Dim titulo As String = "FACTURA"

        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 19, altura, 8, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 36, altura, 8, 0.25, Color.Black)
        miFactura.Titulo(titulo, margen_izquierdo + 2, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("FECHA", margen_izquierdo + 21, altura + 1, 17, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("CLIENTE", margen_izquierdo + 38, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        altura = altura + 4
        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)
        miFactura.Titulo(DatosCabecera.NumeroDocumento, margen_izquierdo + 2, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo(DatosCabecera.Fecha, margen_izquierdo + 21, altura + 1, 22, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo(DatosCabecera.IdCliente.ToString("00000") & " " & DatosCabecera.Nombre, margen_izquierdo + 38, altura + 1, 63, 3, milinea.stilos.MinimaBold)
        altura = altura + 4
        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)
        miFactura.Titulo("ENVASE", margen_izquierdo + 2, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("SALDO AL " & DatosCabecera.Fecha, margen_izquierdo + 50, altura + 1, 40, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("RETIRA", margen_izquierdo + 90, altura + 1, 13, 4, milinea.stilos.MinimaBold)
        altura = altura + 4

        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)


        'Detalles envases
        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim sql As String = ValeEnvases.SaldoEnvases("C", MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy"), DatosCabecera.Fecha, DatosCabecera.IdCliente.ToString, DatosCabecera.IdCliente.ToString, "", "")
        sql = sql & " ORDER BY NombreEnvase"
        Dim dtEnvases As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)




        Dim minimo_alto_envases As Integer = 21


        For indice As Integer = 0 To dtEnvases.Rows.Count - 1


            Dim row As DataRow = dtEnvases.Rows(indice)
            If Not IsNothing(row) And indice <= 5 Then

                Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
                Dim Saldo As Integer = VaInt(row("Saldo"))
                Dim Retira As Integer = VaInt(row("Retira"))

                'Descuenta los saldos de esta factura
                'If Envases.DcEnvasesRetornables.ContainsKey(IdEnvase) Then
                '    Saldo = Saldo - Envases.DcEnvasesRetornables(IdEnvase).TotalBultos
                '    Retira = Retira - Envases.DcEnvasesRetornables(IdEnvase).TotalBultos
                'End If
                'If Envases.DcEnvasesNORetornables.ContainsKey(IdEnvase) Then
                '    Saldo = Saldo - Envases.DcEnvasesNORetornables(IdEnvase).TotalBultos
                '    Retira = Retira - Envases.DcEnvasesNORetornables(IdEnvase).TotalBultos
                'End If

                If Saldo <> 0 Or Retira <> 0 Then

                    If CompruebaSaltoPagina(altura, 4, pag_actual) Then

                        altura = altura + 1
                        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)
                        miFactura.LineaV(margen_izquierdo, BaseAltura, altura - BaseAltura, 0.25, Color.Black)
                        miFactura.LineaV(margen_izquierdo + 104, BaseAltura, altura - BaseAltura, 0.25, Color.Black)

                        pag_actual = pag_actual + 1
                        ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, 0, Nothing)

                        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)
                        BaseAltura = altura

                        altura = altura + 3

                    End If

                    miFactura.Titulo(row("NombreEnvase").ToString, margen_izquierdo + 2, altura + 1, 40, 3, milinea.stilos.Minima)
                    miFactura.Titulo(Saldo.ToString("#,##0"), margen_izquierdo + 43, altura + 1, 20, 3, milinea.stilos.Minima, ">")
                    miFactura.Titulo(Retira.ToString("#,##0"), margen_izquierdo + 80, altura + 1, 20, 3, milinea.stilos.Minima, ">")
                    altura = altura + 3

                End If

            End If

        Next


        If altura - BaseAltura < 33 Then
            altura = BaseAltura + 33
        Else
            altura = altura + 3
        End If


        'Linea final horizontal
        miFactura.LineaH(margen_izquierdo, altura, 104, 0.25, Color.Black)

        'Lineas laterales
        miFactura.LineaV(margen_izquierdo, BaseAltura, altura - BaseAltura, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 104, BaseAltura, altura - BaseAltura, 0.25, Color.Black)



        Dim salto As Integer = ((297 - 15) * (pag_actual))
        miFactura.LineaH(0, salto - 1, 210, 0.25, Color.Transparent)
        miFactura.SaltoPagina(salto)


    End Sub



    Private Function CalculaTotalGasto(IdAlbaran As String) As Decimal

        Dim res As Decimal = 0

        Dim sql As String = "SELECT SUM(AAG_ImporteGasto) AS ImporteGasto FROM AlbSalidaALH_Gastos WHERE  AAG_IdAlbaran = " & IdAlbaran & " AND AAG_IDLinea = 0 AND AAG_TipoGastoFC = 'F'"
        Dim dt As DataTable = cn.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            res = -VaDec(dt.Rows(0)("ImporteGasto"))
        End If


        Return res

    End Function


#End Region



End Module
