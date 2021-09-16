Imports System.Drawing
Imports DevExpress.XtraEditors


Module RemesasFactoring

    Private Class DatosCabecera

        Public IdRemesa As String = ""
        Public NumeroRemesa As String = ""
        Public Fecha As String = ""
        Public IdCentro As String = ""
        Public NombreCentro As String = ""
        Public NombreEmpresa As String = MiMaletin.NombreEmpresa

    End Class


    Public Sub ImprimirRemesaFactoring(ByVal IdRemesa As String, TipoImpresion As TipoImpresion, Impresora As String, rutaPDF As String, archivoPDF As String)

        Dim err As New Errores

        If VaDec(IdRemesa) > 0 Then


            Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)
            If RemesasFactoring.LeerId(IdRemesa) Then


                Dim NombreCentro As String = RemesasFactoring.REF_IdCentro.Valor & ""
                Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
                If Centros.LeerId(NombreCentro) Then NombreCentro = Centros.Nombre.Valor & ""


                'Datos Cabecera
                Dim DatosCabecera As New DatosCabecera
                DatosCabecera.IdRemesa = IdRemesa
                DatosCabecera.NumeroRemesa = RemesasFactoring.REF_Remesa.Valor & ""
                If VaDate(RemesasFactoring.REF_Fecha.Valor) > VaDate("") Then DatosCabecera.Fecha = VaDate(RemesasFactoring.REF_Fecha.Valor).ToString("dd/MM/yyyy")
                DatosCabecera.IdCentro = RemesasFactoring.REF_IdCentro.Valor & ""
                DatosCabecera.NombreCentro = Centros.Nombre.Valor & ""

                


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
                Col.Add(Col(1) + 18)        'Col2
                Col.Add(Col(2) + 23)        'Col3
                Col.Add(Col(3) + 70)        'Col4
                Col.Add(Col(4) + 23)        'Col5
                Col.Add(Col(5) + 23)        'Col6


                'Cabecera
                Dim miFactura As New miFactura()
                Dim BaseLineaDetalle As Integer = 0
                Dim pag_actual As Integer = 1
                Dim inicio_pag_actual As Integer = 7
                Dim altura As Integer = inicio_pag_actual


                'Imprime cabecera
                ImprimeCabeceraRemesaFactoring(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineaDetalle)


                'Detalle y totales detalle
                Dim TotalImporte As Decimal = 0
                ImprimeDetalleRemesaFactoring(DatosCabecera, miFactura, altura, margen_izquierdo, BaseLineaDetalle, Col,
                                      pag_actual, inicio_pag_actual, TotalImporte)

                'Total Remesa
                ImprimeTotalRemesaFactoring(DatosCabecera, miFactura, altura, margen_izquierdo, pag_actual, inicio_pag_actual, TotalImporte)




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
                                err.Muestraerror("Error al exportar el documento con id" & IdRemesa & " a PDF", "ImprimirRemesaFactoring", ex.Message)
                            End Try

                        Else
                            Informe.ImpresionDirecta()
                        End If

                    Case Else
                        Informe.ImpresionDirecta()
                End Select

                Informe.Dispose()


            Else
                XtraMessageBox.Show("Error al leer la remesa de factoring con id " & IdRemesa, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            XtraMessageBox.Show("Error al leer la remesa de factoring con id " & IdRemesa, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ImprimeCabeceraRemesaFactoring(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura,
                            ByRef altura As Integer, ByRef inicio_pag_actual As Integer,
                            ByVal margen_izquierdo As Integer, Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)


        'Imprime cabecera
        inicio_pag_actual = altura
        miFactura.Titulo(DatosCabecera.NombreEmpresa, margen_izquierdo, altura, 190, 6, milinea.stilos.Cabecera)
        altura = altura + 6
        miFactura.Titulo("REMESA FACTORING", margen_izquierdo, altura, 90, 6, milinea.stilos.GrandeBold)
        altura = altura + 16
        miFactura.Titulo("Nº Remesa: ", margen_izquierdo, altura, 23, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.NumeroRemesa, margen_izquierdo + 22, altura, 100, 5, milinea.stilos.NormalBold)
        altura = altura + 5
        miFactura.Titulo("Fecha: ", margen_izquierdo, altura, 23, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.Fecha, margen_izquierdo + 22, altura, 100, 5, milinea.stilos.NormalBold)
        altura = altura + 5
        miFactura.Titulo("Centro: ", margen_izquierdo, altura, 23, 5, milinea.stilos.NormalBold)
        miFactura.Titulo(DatosCabecera.NombreCentro, margen_izquierdo + 22, altura, 100, 5, milinea.stilos.NormalBold)
        altura = altura + 5

        altura = altura + 10


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            miFactura.LineaH(margen_izquierdo, altura, 180, 0.25, Color.Black)
            miFactura.LineaH(margen_izquierdo, altura + 5, 180, 0.25, Color.Black)
            miFactura.Titulo("Albarán", Col(1) + 1, altura + 1, 17, 5, milinea.stilos.ReducidaBold, "=")
            miFactura.Titulo("Fecha", Col(2) + 1, altura + 1, 22, 5, milinea.stilos.ReducidaBold, "=")
            miFactura.Titulo("Cliente", Col(3) + 1, altura + 1, 69, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Importe", Col(4) + 1, altura + 1, 22, 5, milinea.stilos.ReducidaBold, ">")
            miFactura.Titulo("GastoF", Col(5) + 1, altura + 1, 22, 5, milinea.stilos.ReducidaBold, ">")
            miFactura.Titulo("Total", Col(6) + 1, altura + 1, 22, 5, milinea.stilos.ReducidaBold, ">")

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleRemesaFactoring(ByVal DatosCabecera As DatosCabecera, ByRef miFactura As miFactura,
                                    ByRef altura As Integer, margen_izquierdo As Integer, BaseLineas As Integer,
                                    Col As List(Of Integer), ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                    ByRef TotalImporte As Decimal)


        'Líneas Detalle
        Dim dtLineas As DataTable = GeneraLineasImpresion(DatosCabecera.IdRemesa)


        'Debug
        'Dim dt As DataTable = dtLineas.Copy
        'For indice As Integer = 0 To 50
        '    For Each row As DataRow In dtLineas.Rows
        '        dt.ImportRow(row)
        '    Next
        'Next
        'dtLineas = dt


        TotalImporte = 0



        If Not IsNothing(dtLineas) Then

            For Each row As DataRow In dtLineas.Rows

                Dim Albaran As String = (row("Albaran").ToString & "").Trim
                Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim Cliente As String = (row("CodCli").ToString & "").Trim & " - " & (row("Cliente").ToString & "").Trim
                Dim Importe As String = VaDec(row("Importe")).ToString("#,#0.00")
                Dim GastoF As String = VaDec(row("GastosF")).ToString("#,##0.00")
                Dim Total As String = VaDec(row("Total")).ToString("#,##0.00")

                TotalImporte = TotalImporte + VaDec(row("Total"))

                'Comprueba salto de linea
                Dim altura_linea As Integer = 5
                If CompruebaSaltoPagina(altura, altura_linea, pag_actual) Then
                    pag_actual = pag_actual + 1
                    ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas, Col)
                End If

                miFactura.Titulo(Albaran, Col(1) + 1, altura, 17, 5, milinea.stilos.Reducida, ">")
                miFactura.Titulo(Fecha, Col(2) + 1, altura, 22, 5, milinea.stilos.Reducida, "=")
                miFactura.Titulo(Cliente, Col(3) + 1, altura, 69, 5, milinea.stilos.Reducida)
                miFactura.Titulo(Importe, Col(4) + 1, altura, 22, 5, milinea.stilos.Reducida, ">")
                miFactura.Titulo(GastoF, Col(5) + 1, altura, 22, 5, milinea.stilos.Reducida, ">")
                miFactura.Titulo(Total, Col(6) + 1, altura, 22, 5, milinea.stilos.Reducida, ">")

                altura = altura + 5

            Next

        End If

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


    Private Sub ImprimeTotalRemesaFactoring(ByVal DatosCabecera As DatosCabecera, ByVal miFactura As miFactura,
                                    ByRef altura As Integer, ByVal margen_izquierdo As Integer, ByRef pag_actual As Integer,
                                    ByRef inicio_pag_actual As Integer, TotalImporte As Decimal)

        miFactura.Titulo("Total remesa: " & TotalImporte.ToString("#,##0.00"), margen_izquierdo, altura, 180, 5, milinea.stilos.NormalBold, ">")


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


        ImprimeCabeceraRemesaFactoring(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineas)


    End Sub


    Private Function GeneraLineasImpresion(IdRemesa As String) As DataTable

        Dim RemesasFactoring_Lineas As New E_RemesasFactoring_Lineas(Idusuario, cn)
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(RemesasFactoring_Lineas.RFL_Id, "RFL_Id")
        CONSULTA.SelCampo(AlbSalida.ASA_albaran, "Albaran", RemesasFactoring_Lineas.RFL_IdAlbaran, AlbSalida.ASA_idalbaran)
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        CONSULTA.SelCampo(AlbSalida.ASA_idcliente, "CodCli")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        Dim oImporte As New Cdatos.bdcampo("@(SELECT SUM(ASL_ImporteGeneroVta) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran) * COALESCE(ASA_ValorCambio,1)", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")
        Dim oGastos As New Cdatos.bdcampo("@(SELECT SUM(ASC_GastoF) FROM AlbSalida_LineasCostes WHERE ASC_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oGastos, "GastosF")
        Dim strTotal As String = "(COALESCE((SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0)) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran),0) + " & _
        " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) - " & _
        " COALESCE((SELECT SUM(COALESCE(ASG_ImporteGastoDivisa,0)) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASA_IdAlbaran),0)) * COALESCE(ASA_ValorCambio,1)"
        Dim oTotal As New Cdatos.bdcampo("@" & strTotal, Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oTotal, "Total")
        CONSULTA.WheCampo(RemesasFactoring_Lineas.RFL_IdRemesa, "=", IdRemesa)


        Dim sql As String = CONSULTA.SQL ' & " ORDER BY RFL_Id"""
        Dim dt As DataTable = RemesasFactoring_Lineas.MiConexion.ConsultaSQL(sql)



        Return dt

    End Function


End Module
