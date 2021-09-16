Imports System.Drawing


Module C1_Cobros

    Public Sub C1_ImprimirCobro(IdCobro As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim Cobros As New E_Cobros(Idusuario, cn)


        If Cobros.LeerId(IdCobro) Then


            Dim Listado As New Listado()

            Listado.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Listado.Documento.PageLayout.PageSettings.Landscape = False
            Listado.Documento.PageLayout.PageSettings.TopMargin = "10mm"
            Listado.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
            Listado.Documento.PageLayout.PageSettings.BottomMargin = "12mm"


            Dim Numero As String = VaInt(Cobros.COB_NumeroCobro.Valor).ToString("00000000")
            Dim IdCentro As String = VaInt(Cobros.COB_IdCentro.Valor).ToString
            Dim Cliente As String = Cobros.COB_IdCliente.Valor & ""

            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Clientes.LeerId(Cliente) Then
                Cliente = VaInt(Cliente).ToString("00000") & " - " & Clientes.CLI_Nombre.Valor
            End If



            Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea("RECIBO DE COBRO Nº " & Numero & "|" & " CENTRO " & IdCentro & "|" & "F.Impresion: " & Today.ToString("dd/MM/yyyy"), "80|30|>80", Estilos.NormalBold)
            Listado.Cabecera.Linea("CLIENTE " & Cliente, "180", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)


            'Líneas de cobro (facturas)
            Dim CobrosLineas As New E_CobrosLineas(Idusuario, cn)
            Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            Dim Facturas As New E_Facturas(Idusuario, cn)


            Dim Dlin As String = "35|5|30|20|>30|>30|>30"
            Dim Cabecera As String = "P.VENTA||FACTURA|FECHA|IMPORTE DV|COBRADO DV|COBRADO €"
            Listado.Cabecera.Linea(Cabecera, Dlin, Estilos.NormalBoldLineaDebajo)
            Listado.Cabecera.Linea("", "", Estilos.NormalBold)


            'Líneas de detalle
            Dim TotalCobradoEuros As Decimal = 0
            Dim dt As DataTable = Cobros.GeneraDatosImpresion(TotalCobradoEuros)

            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim PV As String = row("PV").ToString & ""
                    Dim Factura As String = row("Factura").ToString & ""
                    Dim Fecha As String = ""
                    If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                    Dim ImporteDV As Decimal = VaDec(row("Importe_Fac"))
                    Dim CobradoDV As Decimal = VaDec(row("Cobrado"))
                    Dim CobradoEuros As Decimal = VaDec(row("Cobrado_Euros"))


                    Dim detalle As String = ""
                    detalle = detalle & PV & "||"
                    detalle = detalle & Factura & "|"
                    detalle = detalle & Fecha & "|"
                    detalle = detalle & ImporteDV.ToString("#,##0.00") & "|"
                    detalle = detalle & CobradoDV.ToString("#,##0.00") & "|"
                    detalle = detalle & CobradoEuros.ToString("#,##0.00")

                    Listado.Detalle.Linea(detalle, Dlin, Estilos.Reducida)

                Next

            End If

            Listado.Detalle.Linea("", "180", Estilos.Normal)
            Listado.Detalle.Linea("|||INGRESO: " & TotalCobradoEuros.ToString("#,##0.00"), "40|30|20|>90", Estilos.NormalBoldLineaEncima)
            Listado.Detalle.Linea(" ", "180", Estilos.NormalBold)
            Listado.Detalle.Linea(" ", "180", Estilos.NormalBold)



            'Conceptos
            Dim DLin2 As String = "20|100|>30"
            Dim Cabecera2 As String = "CUENTA|CONCEPTO|IMPORTE"

            'Cuenta tesorería
            Dim CtaTesoreria As String = (Cobros.COB_CuentaEfectivo.Valor & "").Trim
            Dim CtaGastosFinan As String = (Cobros.COB_CtaGastosFinan.Valor & "").Trim
            Dim CtaDifCambio As String = (Cobros.COB_CtaDifCambio.Valor & "").Trim


            If CtaTesoreria <> "" Or CtaGastosFinan <> "" Or CtaDifCambio <> "" Then
                Listado.Detalle.Linea(Cabecera2, DLin2, Estilos.ReducidaBoldLineaDebajo)
            End If


            If CtaTesoreria.Trim <> "" Then

                Dim Concepto As String = (Cobros.COB_Concepto.Valor & "").Trim
                Dim Importe As Decimal = VaDec(Cobros.COB_ImporteEfectivo.Valor)

                Dim detalle As String = CtaTesoreria & "|" & Concepto & "|" & Importe.ToString("#,##0.00")
                Listado.Detalle.Linea(detalle, DLin2, Estilos.Reducida)
                Listado.Detalle.Linea("", "180", Estilos.Reducida)

            End If

            If CtaGastosFinan.Trim <> "" Then

                Dim Concepto As String = (Cobros.COB_ConceptoGtosFinan.Valor & "").Trim
                Dim Importe As Decimal = VaDec(Cobros.COB_ImporteGtosFinan.Valor)

                Dim detalle As String = CtaGastosFinan & "|" & Concepto & "|" & Importe.ToString("#,##0.00")
                Listado.Detalle.Linea(detalle, DLin2, Estilos.Reducida)
                Listado.Detalle.Linea("", "180", Estilos.Reducida)

            End If

            If CtaDifCambio.Trim <> "" Then

                Dim Concepto As String = (Cobros.COB_ConceptoDifCambio.Valor & "").Trim
                Dim Importe As Decimal = VaDec(Cobros.COB_ImporteDifCambio.Valor)

                Dim detalle As String = CtaDifCambio & "|" & Concepto & "|" & Importe.ToString("#,##0.00")
                Listado.Detalle.Linea(detalle, DLin2, Estilos.Reducida)
                Listado.Detalle.Linea("", "180", Estilos.Reducida)

            End If

            Listado.Detalle.Linea("", "180", Estilos.Reducida)
            Listado.Detalle.Linea("", "180", Estilos.Reducida)
            Listado.Detalle.Linea("", "180", Estilos.Reducida)
            Listado.Detalle.Linea("", "180", Estilos.Reducida)


            'Vencimientos
            Dim Cabecera3 As String = "VENCIMIENTO|CONCEPTO|IMPORTE"

            Dim CobrosVencimientos As New E_CobrosVencimientos(Idusuario, cn)
            Dim dtVtos As DataTable = CobrosVencimientos.ObtenerVencimientosCobro(IdCobro)

            If Not IsNothing(dtVtos) Then
                If dtVtos.Rows.Count > 0 Then

                    Listado.Detalle.Linea(Cabecera3, DLin2, Estilos.ReducidaBoldLineaDebajo)

                    '4 máximo
                    Dim cont As Integer = 0
                    For Each row As DataRow In dtVtos.Rows

                        If cont > 3 Then Exit For

                        Dim vencimiento As String = ""
                        If VaDate(row("Fecha")) > VaDate("") Then vencimiento = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                        Dim concepto As String = (row("Concepto").ToString & "").Trim
                        Dim Importe As Decimal = VaDec(row("Importe"))

                        Dim detalle As String = vencimiento & "|" & concepto & "|" & Importe.ToString("#,##0.00")
                        Listado.Detalle.Linea(detalle, DLin2, Estilos.Reducida)
                        Listado.Detalle.Linea("", "180", Estilos.Reducida)

                        cont = cont + 1

                    Next



                End If
            End If




            'Impresión
            Listado.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)
            Listado.Dispose()

        Else
            MsgBox("No se puede leer Cobro con Id: " & IdCobro)
        End If


    End Sub


End Module
