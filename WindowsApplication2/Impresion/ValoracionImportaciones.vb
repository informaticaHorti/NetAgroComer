Imports System.Drawing

Module ValoracionImportaciones

    Public Structure Importaciones_DatosProveedor
        Public Nombre As String
        Public Domicilio As String
        Public Poblacion As String
        Public CodPostal As String
        Public Provincia As String
        Public Pais As String
    End Structure


    Public Structure Importaciones_ResumenCostes
        Public Porte As Decimal
        Public Arancel As Decimal
        Public Transitario As Decimal
        Public Comision As Decimal
        Public PorcentajeComision As Decimal
        Public Otros As Decimal
        Public TotalGastos As Decimal
    End Structure


    Public Structure Importaciones_DatosImportaciones
        Public FechaFactura As String
        Public FechaLlegada As String
        Public Factura As String
        Public Albaran As String
        Public Matricula As String
        Public AgenciaTransporte As String
        Public Observaciones As String
    End Structure


    Public Sub ImprimirValoracionImportaciones(dt As DataTable, DatosImportacion As Importaciones_DatosImportaciones,
                                               DatosProveedor As Importaciones_DatosProveedor,
                                               ResumenCostes As Importaciones_ResumenCostes,
                                               TipoImpresion As TipoImpresion, Impresora As String, Optional rutaPDF As String = "")


        Dim err As New Errores


        Try


            Dim DatosEmpresa As New DatosEmpresa
            DatosEmpresa.ObtenerDatosEmpresa()


            Dim margen_izquierdo As Integer = 10
            Dim altura As Integer = 12
            Dim max_lineas As Integer = 13


            'Meollo
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


            Dim documento As New miFactura()

            Dim Col(9) As Integer
            Col(0) = margen_izquierdo
            Col(1) = margen_izquierdo + 2
            Col(2) = margen_izquierdo + 55
            Col(3) = margen_izquierdo + 80
            Col(4) = margen_izquierdo + 100
            Col(5) = margen_izquierdo + 115
            Col(6) = margen_izquierdo + 132
            Col(7) = margen_izquierdo + 147
            Col(8) = margen_izquierdo + 164
            Col(9) = margen_izquierdo + 176




            'Datos Empresa
            ImprimeDatosEmpresa(documento, DatosEmpresa, margen_izquierdo, altura)

            'Datos Proveedor
            ImprimeDatosProveedor(documento, DatosProveedor, margen_izquierdo, altura)

            'Datos Importación
            ImprimeDatosImportacion(documento, DatosImportacion, margen_izquierdo, altura)

            'Cuadro Productos 1
            ImprimeCuadroImportacion1(documento, dt, margen_izquierdo, altura, Col, max_lineas)

            'Resumen Costes
            ImprimeResumenCostes(documento, ResumenCostes, margen_izquierdo, altura)

            'Cuadro Productos 2
            ImprimeCuadroImportacion2(documento, dt, margen_izquierdo, altura, Col, max_lineas, DatosImportacion)


            'Añadimos el documento al informe
            Informe.AñadeDetalles(documento)


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
                    If rutaPDF.Trim <> "" Then
                        Informe.Contenedor.CreateDocument()
                        Try
                            Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                            options.Compressed = True
                            Informe.Contenedor.ExportToPdf(rutaPDF, options)

                        Catch ex As Exception
                            err.Muestraerror("Error al exportar el documento a PDF", "ImprimirValoracionImportaciones", ex.Message)
                        End Try

                    Else
                        Informe.ImpresionDirecta()
                    End If

                Case Else
                    Informe.ImpresionDirecta()
            End Select


            Informe.Dispose()



        Catch ex As Exception
            err.Muestraerror("Error al imprimir la valoración de importaciones", "ImprimirValoracionImportaciones", ex.Message)
        End Try



    End Sub


    Private Sub ImprimeDatosEmpresa(documento As miFactura, DatosEmpresa As DatosEmpresa, margen_izquierdo As Integer, ByRef altura As Integer)

        Dim poblacion As String = DatosEmpresa.CPostal & " " & DatosEmpresa.Poblacion & " - " & DatosEmpresa.Provincia

        documento.Titulo(MiMaletin.NombreEmpresa, margen_izquierdo, altura, 125, 4, milinea.stilos.NormalBold)
        altura = altura + 4
        documento.Titulo(DatosEmpresa.Domicilio, margen_izquierdo, altura, 125, 4, milinea.stilos.NormalBold)
        altura = altura + 4
        documento.Titulo(poblacion, margen_izquierdo, altura, 125, 4, milinea.stilos.NormalBold)
        altura = altura + 4
        documento.Titulo(DatosEmpresa.NIF, margen_izquierdo, altura, 125, 4, milinea.stilos.NormalBold)
        altura = altura + 8

    End Sub


    Private Sub ImprimeDatosProveedor(documento As miFactura, DatosProveedor As Importaciones_DatosProveedor, margen_izquierdo As Integer, ByRef altura As Integer)

        Dim basealtura As Integer = altura
        margen_izquierdo = margen_izquierdo + 110


        documento.Titulo(DatosProveedor.Nombre, margen_izquierdo, basealtura, 80, 4, milinea.stilos.NormalBold)
        basealtura = basealtura + 4
        documento.Titulo(DatosProveedor.Domicilio, margen_izquierdo, basealtura, 80, 4, milinea.stilos.NormalBold)
        basealtura = basealtura + 4
        documento.Titulo(DatosProveedor.Poblacion, margen_izquierdo, basealtura, 80, 4, milinea.stilos.NormalBold)
        basealtura = basealtura + 4
        documento.Titulo(DatosProveedor.Provincia, margen_izquierdo, basealtura, 80, 4, milinea.stilos.NormalBold)
        basealtura = basealtura + 4
        documento.Titulo(DatosProveedor.Pais, margen_izquierdo, basealtura, 80, 4, milinea.stilos.NormalBold)


        altura = altura + 4

    End Sub


    Private Sub ImprimeDatosImportacion(documento As miFactura, DatosImportacion As Importaciones_DatosImportaciones, margen_izquierdo As Integer, ByRef altura As Integer)

        documento.Titulo("Fecha Factura:", margen_izquierdo, altura, 55, 4, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.FechaFactura, margen_izquierdo + 40, altura, 60, 5, milinea.stilos.Normal)
        altura = altura + 5
        documento.Titulo("Fecha Llegada:", margen_izquierdo, altura, 55, 5, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.FechaLlegada, margen_izquierdo + 40, altura, 60, 5, milinea.stilos.Normal)
        altura = altura + 5
        documento.Titulo("Factura:", margen_izquierdo, altura, 55, 4, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.Factura, margen_izquierdo + 40, altura, 60, 5, milinea.stilos.Normal)
        altura = altura + 5
        documento.Titulo("Albarán:", margen_izquierdo, altura, 55, 4, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.Albaran, margen_izquierdo + 40, altura, 60, 5, milinea.stilos.Normal)
        altura = altura + 5
        documento.Titulo("Matrícula:", margen_izquierdo, altura, 55, 4, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.Matricula, margen_izquierdo + 40, altura, 60, 5, milinea.stilos.Normal)
        altura = altura + 5
        documento.Titulo("Agencia de Transporte:", margen_izquierdo, altura, 55, 5, milinea.stilos.Normal)
        documento.Titulo(DatosImportacion.AgenciaTransporte, margen_izquierdo + 40, altura, 70, 5, milinea.stilos.Normal)
        altura = altura + 10

    End Sub


    Private Sub ImprimeCuadroImportacion1(documento As miFactura, dt As DataTable, margen_izquierdo As Integer,
                                          ByRef altura As Integer, Col As Integer(), max_lineas As Integer)

        Dim basealtura As Integer = altura
        Dim altura_final As Integer = altura + (max_lineas * 4) + 2

        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1

        documento.Titulo("PRODUCTO", Col(1), altura, 45, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("CATEGORIA", Col(2), altura, 20, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("MARCA", Col(3), altura, 20, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("PALETS", Col(4), altura, 12, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("CAJAS", Col(5), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("KILOS", Col(6), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("P.VENTA", Col(7), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("VTA.TOTAL", Col(8), altura, 18, 3, milinea.stilos.ReducidaBold, ">")

        altura = altura + 4
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1


        Dim TotalPalets As Decimal = 0
        Dim TotalCajas As Decimal = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalVta As Decimal = 0


        'Detalle
        Dim cont As String = 0
        For Each row As DataRow In dt.Rows

            Dim Producto As String = (row("Genero").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Palets As Decimal = VaDec(row("Palets"))
            Dim Cajas As Decimal = VaDec(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim PVenta As Decimal = VaDec(row("Margen"))
            Dim VtaTotal As Decimal = VaDec(row("ImpMargen"))

            TotalPalets = TotalPalets + Palets
            TotalCajas = TotalCajas + Cajas
            TotalKilos = TotalKilos + Kilos
            TotalVta = TotalVta + VtaTotal


            If cont < max_lineas Then

                documento.Titulo(Producto, Col(1), altura, 44, 4, milinea.stilos.Reducida)
                documento.Titulo(Categoria, Col(2), altura, 19, 4, milinea.stilos.Reducida)
                documento.Titulo(Marca, Col(3), altura, 19, 4, milinea.stilos.Reducida)
                documento.Titulo(Palets.ToString("#,##0"), Col(4), altura, 9, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(Cajas.ToString("#,##0"), Col(5), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(Kilos.ToString("#,##0"), Col(6), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(PVenta.ToString("#,##0.00"), Col(7), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(VtaTotal.ToString("#,##0.00"), Col(8), altura, 14, 4, milinea.stilos.Reducida, ">")

                altura = altura + 4

            Else
                documento.Titulo("(más...)", Col(1), altura_final + 1, 40, 4, milinea.stilos.ReducidaBold)
                Exit For
            End If

        Next


        altura = altura_final
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1

        documento.Titulo(TotalPalets.ToString("#,##0"), Col(4), altura, 9, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalCajas.ToString("#,##0"), Col(5), altura, 14, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalKilos.ToString("#,##0"), Col(6), altura, 14, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalVta.ToString("#,##0.00"), Col(8) - 6, altura, 20, 4, milinea.stilos.ReducidaBold, ">")

        altura = altura + 5
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)

        documento.LineaV(margen_izquierdo, basealtura, altura - basealtura, 0.25, Color.Black)
        documento.LineaV(margen_izquierdo + 190, basealtura, altura - basealtura, 0.25, Color.Black)


        altura = altura + 10


    End Sub


    Private Sub ImprimeResumenCostes(documento As miFactura, ResumenCostes As Importaciones_ResumenCostes, margen_izquierdo As Integer, ByRef altura As Integer)


        Dim basealtura As Integer = altura


        documento.LineaH(margen_izquierdo, altura, 84, 0.25, Color.Black)
        altura = altura + 1
        documento.Titulo("RESUMEN DE COSTES", margen_izquierdo + 2, altura, 84, 4, milinea.stilos.ReducidaBold)
        altura = altura + 4
        documento.LineaH(margen_izquierdo, altura, 84, 0.25, Color.Black)
        altura = altura + 1
        documento.Titulo("Porte", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.Reducida)
        documento.Titulo(ResumenCostes.Porte.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        documento.Titulo("Arancel", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.Reducida)
        documento.Titulo(ResumenCostes.Arancel.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        documento.Titulo("Transitario", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.Reducida)
        documento.Titulo(ResumenCostes.Transitario.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        documento.Titulo("Comisión " & ResumenCostes.PorcentajeComision.ToString("#,##0.##") & "%", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.Reducida)
        documento.Titulo(ResumenCostes.Comision.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        documento.Titulo("Otros Gastos", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.Reducida)
        documento.Titulo(ResumenCostes.Otros.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        altura = altura + 1
        documento.LineaH(margen_izquierdo, altura, 84, 0.25, Color.Black)
        altura = altura + 1
        documento.Titulo("Total gastos", margen_izquierdo + 2, altura, 40, 4, milinea.stilos.ReducidaBold)
        documento.Titulo(ResumenCostes.TotalGastos.ToString("#,##0.00"), margen_izquierdo + 40, altura, 43, 4, milinea.stilos.Reducida, ">")
        altura = altura + 4
        documento.LineaH(margen_izquierdo, altura, 84, 0.25, Color.Black)


        documento.LineaV(margen_izquierdo, basealtura, altura - basealtura, 0.25, Color.Black)
        documento.LineaV(margen_izquierdo + 84, basealtura, altura - basealtura, 0.25, Color.Black)


        altura = altura + 8


    End Sub

    Private Sub ImprimeCuadroImportacion2(documento As miFactura, dt As DataTable, margen_izquierdo As Integer,
                                          ByRef altura As Integer, Col As Integer(), max_lineas As Integer,
                                          DatosImportacion As Importaciones_DatosImportaciones)


        documento.Titulo("LIQUIDACION FINAL", margen_izquierdo, altura, 120, 5, milinea.stilos.Normal)

        altura = altura + 10


        Dim basealtura As Integer = altura
        Dim altura_final As Integer = altura + (max_lineas * 4) + 2

        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1

        documento.Titulo("PRODUCTO", Col(1), altura, 45, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("CATEGORIA", Col(2), altura, 20, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("MARCA", Col(3), altura, 20, 3, milinea.stilos.ReducidaBold)
        documento.Titulo("PALETS", Col(4), altura, 12, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("CAJAS", Col(5), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("KILOS", Col(6), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("P.VENTA", Col(7), altura, 15, 3, milinea.stilos.ReducidaBold, ">")
        documento.Titulo("VTA.TOTAL", Col(8), altura, 18, 3, milinea.stilos.ReducidaBold, ">")

        altura = altura + 4
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1


        Dim TotalPalets As Decimal = 0
        Dim TotalCajas As Decimal = 0
        Dim TotalKilos As Decimal = 0
        Dim TotalVta As Decimal = 0


        'Detalle
        Dim cont As String = 0
        For Each row As DataRow In dt.Rows

            Dim Producto As String = (row("Genero").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Palets As Decimal = VaDec(row("Palets"))
            Dim Cajas As Decimal = VaDec(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim PVenta As Decimal = VaDec(row("PFinal"))
            Dim VtaTotal As Decimal = VaDec(row("ImpCompra"))

            TotalPalets = TotalPalets + Palets
            TotalCajas = TotalCajas + Cajas
            TotalKilos = TotalKilos + Kilos
            TotalVta = TotalVta + VtaTotal


            If cont < max_lineas Then

                documento.Titulo(Producto, Col(1), altura, 44, 4, milinea.stilos.Reducida)
                documento.Titulo(Categoria, Col(2), altura, 19, 4, milinea.stilos.Reducida)
                documento.Titulo(Marca, Col(3), altura, 19, 4, milinea.stilos.Reducida)
                documento.Titulo(Palets.ToString("#,##0"), Col(4), altura, 9, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(Cajas.ToString("#,##0"), Col(5), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(Kilos.ToString("#,##0"), Col(6), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(PVenta.ToString("#,##0.00"), Col(7), altura, 14, 4, milinea.stilos.Reducida, ">")
                documento.Titulo(VtaTotal.ToString("#,##0.00"), Col(8), altura, 14, 4, milinea.stilos.Reducida, ">")

                altura = altura + 4

            Else
                documento.Titulo("(más...)", Col(1), altura_final + 1, 40, 4, milinea.stilos.ReducidaBold)
                Exit For
            End If

        Next


        altura = altura_final
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        altura = altura + 1

        documento.Titulo(TotalPalets.ToString("#,##0"), Col(4), altura, 9, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalCajas.ToString("#,##0"), Col(5), altura, 14, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalKilos.ToString("#,##0"), Col(6), altura, 14, 4, milinea.stilos.ReducidaBold, ">")
        documento.Titulo(TotalVta.ToString("#,##0.00"), Col(8) - 6, altura, 20, 4, milinea.stilos.ReducidaBold, ">")

        altura = altura + 5
        documento.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)

        documento.LineaV(margen_izquierdo, basealtura, altura - basealtura, 0.25, Color.Black)
        documento.LineaV(margen_izquierdo + 190, basealtura, altura - basealtura, 0.25, Color.Black)


        altura = altura + 8
        documento.Titulo(DatosImportacion.Observaciones, margen_izquierdo, altura, 190, 5, milinea.stilos.Normal, "=")
        altura = altura + 4

        documento.Titulo("Atentamente", margen_izquierdo, altura, 120, 5, milinea.stilos.Normal)
        altura = altura + 20
        documento.Titulo("ENRIQUE VARGAS GARBÍN", margen_izquierdo, altura, 120, 5, milinea.stilos.Normal)


    End Sub


End Module
