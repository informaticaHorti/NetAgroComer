Imports System.Drawing

Module ValePortes




    Private Sub ImprimeValePorte_Uno(DatosEmpresa As DatosEmpresa, Factura As E_Facturas, Cliente As E_Clientes,
                                 TipoImpresion As TipoImpresion, Impresora As String, rutaPDF As String,
                                 Importe As Decimal, Palets As Integer, PrecioPalet As Decimal)


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


        Dim miBoleta As New miFactura()
        Dim altura As Integer = 10
        Dim margen_izquierdo As Integer = 15




        'Datos empresa 
        ImprimeCabeceraValePortes(miBoleta, DatosEmpresa, altura, margen_izquierdo)

        'Datos factura y cliente
        ImprimeDatosFacturaCliente(miBoleta, Factura, Cliente, altura, margen_izquierdo)

        'Detalles
        ImprimeDetallesValePorte(miBoleta, PrecioPalet, Palets, Importe, Factura, altura, margen_izquierdo)




        'Añadimos el documento al informe
        Informe.AñadeDetalles(miBoleta)


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
                        Dim err As New Errores
                        err.Muestraerror("Error al exportar el documento con id" & Factura.FRA_idfactura.Valor & " a PDF", "ImprimirAlbaranFactura", ex.Message)
                    End Try

                Else
                    Informe.ImpresionDirecta()
                End If

            Case Else
                Informe.ImpresionDirecta()
        End Select



        Informe.Dispose()


    End Sub


    Private Function ObtenValePorte_Uno(DatosEmpresa As DatosEmpresa, Factura As E_Facturas, Cliente As E_Clientes,
                                 Importe As Decimal, Palets As Integer, PrecioPalet As Decimal) As miFactura


        Dim miBoleta As New miFactura()
        Dim altura As Integer = 10
        Dim margen_izquierdo As Integer = 15




        'Datos empresa 
        ImprimeCabeceraValePortes(miBoleta, DatosEmpresa, altura, margen_izquierdo)

        'Datos factura y cliente
        ImprimeDatosFacturaCliente(miBoleta, Factura, Cliente, altura, margen_izquierdo)

        'Detalles
        ImprimeDetallesValePorte(miBoleta, PrecioPalet, Palets, Importe, Factura, altura, margen_izquierdo)


        'Añadimos el documento al informe
        'Informe.AñadeDetalles(miBoleta)

        Return miBoleta


    End Function


    Private Sub ImprimeCabeceraValePortes(miBoleta As miFactura, DatosEmpresa As DatosEmpresa, ByRef altura As Integer, margen_izquierdo As Integer)



        miBoleta.Titulo(MiMaletin.NombreEmpresa, margen_izquierdo + 2, altura, 170, 6, milinea.stilos.GrandeBold)
        miBoleta.Titulo("VALE DE PORTES DE CLIENTES", margen_izquierdo + 2, altura + 10, 85, 6, milinea.stilos.GrandeBold)

        altura = altura + 7
        miBoleta.Titulo(DatosEmpresa.FilaDatos, 102, altura, 100, 10, milinea.stilos.Reducida)
        altura = altura + 11

        miBoleta.Cuadro(margen_izquierdo, altura, 180, 80, 0.25, Color.Black)
        miBoleta.LineaH(margen_izquierdo, altura + 23, 180, 0.25, Color.Black)
        miBoleta.Cuadro(100, altura + 2, 85, 17, 0.25, Color.Black)
        altura = altura + 5



    End Sub


    Private Sub ImprimeDatosFacturaCliente(miBoleta As miFactura, Factura As E_Facturas, Cliente As E_Clientes, ByRef altura As Integer, margen_izquierdo As Integer)

        Dim NumFactura As String = VaInt(Factura.FRA_factura.Valor).ToString("000000")
        If (Factura.FRA_serie.Valor & "").Trim <> "" Then NumFactura = (Factura.FRA_serie.Valor & "").Trim & " " & NumFactura
        Dim Fecha As String = ""
        If VaDate(Factura.FRA_fecha.Valor) > VaDate("") Then Fecha = VaDate(Factura.FRA_fecha.Valor).ToString("dd/MM/yyyy")
        Dim CodCliente As String = VaInt(Factura.FRA_idcliente.Valor).ToString("00000")


        miBoleta.Titulo("N. Factura:", margen_izquierdo + 2, altura, 20, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(NumFactura, 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Cliente.CLI_Nombre.Valor, 105, altura, 75, 4, milinea.stilos.ReducidaBold)
        altura = altura + 4
        miBoleta.Titulo("Fecha:", margen_izquierdo + 2, altura, 20, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Fecha, 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Cliente.CLI_Domicilio.Valor, 105, altura, 75, 4, milinea.stilos.ReducidaBold)
        altura = altura + 4
        miBoleta.Titulo("Cliente:", margen_izquierdo + 2, altura, 20, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(CodCliente, 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Cliente.CLI_Poblacion.Valor & " " & Cliente.CLI_Provincia.Valor, 105, altura, 75, 4, milinea.stilos.ReducidaBold)
        altura = altura + 4 + 5

    End Sub


    Private Sub ImprimeDetallesValePorte(miBoleta As miFactura, PrecioPalet As Decimal, Palets As Integer, Importe As Decimal, Factura As E_Facturas,
                                         ByRef altura As Integer, margen_izquierdo As Integer)

        Dim BaseAltura As Integer = altura + 3
        altura = altura + 5

        miBoleta.Titulo("Precio Palet:", margen_izquierdo + 2, altura, 22, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(PrecioPalet.ToString("#,##0.00"), 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        altura = altura + 10
        miBoleta.Titulo("Palets:", margen_izquierdo + 2, altura, 22, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Palets.ToString("#,##0"), 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        altura = altura + 10
        miBoleta.Titulo("Total Porte:", margen_izquierdo + 2, altura, 22, 4, milinea.stilos.ReducidaBold)
        miBoleta.Titulo(Importe.ToString("#,##0.00"), 40, altura, 55, 4, milinea.stilos.ReducidaBold)
        altura = altura + 10


        Dim texto_pago As String = "Para el abono del porte asociado a la factura será imprescindible presentar dicho vale; sin firma y sello el vale no tiene validez."
        miBoleta.Titulo("Condiciones de pago", margen_izquierdo + 2, altura, 55, 2, milinea.stilos.MinimaBold)
        altura = altura + 3
        miBoleta.Titulo(texto_pago, margen_izquierdo + 2, altura, 46, 8, milinea.stilos.Minima)


        'Código de barras
        Dim NumFactura As String = VaInt(Factura.FRA_factura.Valor).ToString("000000")
        Dim Serie As String = VaInt(Factura.FRA_serie.Valor & "").ToString("00")
        NumFactura = Serie & NumFactura


        Dim Code39 As New Font("C39HrP24DhTt", 27)
        Dim cod_barras As String
        cod_barras = "*" & NumFactura & "*"
        miBoleta.Titulo(cod_barras, 135, BaseAltura, 35, 25, milinea.stilos.Custom, , Code39)

        miBoleta.Titulo("Firma y sello:", 125, BaseAltura + 15, 15, 3, milinea.stilos.Minima)


    End Sub

End Module
