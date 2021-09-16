Imports System.Net
Imports System.IO
Imports NetAgro.EDICOM
Imports NetAgro.EDI

Namespace EDICOM


    Public Class EDICOM_GeneradorFacturaElectronica
        Inherits EDI.EDI_GeneradorFacturasElectronicas


        'Public Const FORMATO_POR_DEFECTO = "D93A"




        Private Class stClave_Impuesto

            Public TipoImpuesto As String
            Public Porcentaje As Decimal = 0

            Public Sub New(ByVal TipoImpuesto As Comun.TipoImpuesto_EDICOM, ByVal Porcentaje As Decimal)

                Me.TipoImpuesto = Comun.TiposImpuesto_EDICOM(TipoImpuesto)
                Me.Porcentaje = Porcentaje

            End Sub

        End Class

        Private Class stDatos_Impuesto

            Public BaseImponible As Decimal = 0
            Public Importe As Decimal = 0

            Public Sub New(ByVal BaseImponible As Decimal, ByVal Importe As Decimal)
                Me.BaseImponible = BaseImponible
                Me.Importe = Importe
            End Sub

        End Class




        Public Sub New(ByVal carpeta_destino As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, carpeta_destino)

        End Sub


        Protected Overrides Function Datos_a_Factura(ByVal dt As DataTable,
                                                     ByVal dtGastosFactura As DataTable,
                                                     ByVal dtLineas As DataTable,
                                                     ByVal dtOtrosConceptos As DataTable,
                                                     Optional ByVal IdIdioma As Integer = 1) As EDI.EDI_Factura


            Dim Factura As EDICOM_Factura = Nothing


            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then


                    Dim row As DataRow = dt.Rows(0)


                    Factura = New EDICOM_Factura()

                    Dim bGenerarObservacionesGlobales As Boolean = False
                    Dim bGenerarFicheroDescuentosCargos As Boolean = False
                    Dim dtImpuestos As DataTable = GeneraTablaImpuestos(row)
                    Dim FormatoEDI As E_FormatosEDI.Formato


                    GeneraCabeceraYPie(Factura, row, dtGastosFactura, dtImpuestos, bGenerarFicheroDescuentosCargos, FormatoEDI)                         'Genera datos para CABFAC
                    GeneraObservacionesGlobales(Factura, row)                                                                                           'Genera datos para OBSFAC (si procede)

                    If bGenerarFicheroDescuentosCargos Then
                        GeneraDescuentosYCargosGlobales(Factura, row, dtGastosFactura)                                                                  'Genera datos para DTOFAC (si procede)
                    End If

                    GeneraLineasFactura(Factura, row, dtLineas, dtOtrosConceptos, FormatoEDI)                                                           'Genera datos para LINFAC, OBSLFAC y DTOLFAC

                    'En caso de que haya más de 6 tipos de impuesto, hay que usar el fichero IMPFAC.TXT
                    If dtImpuestos.Rows.Count > 6 Then
                        GeneraDesgloseImpuestos(Factura, row, dtImpuestos)                                                                              'Genera datos para IMPFAC (si procede)
                    End If



                End If


            End If



            Return Factura

        End Function


        Private Sub GeneraCabeceraYPie(ByRef Factura As EDICOM_Factura, ByVal row As DataRow, ByVal dtGastosFactura As DataTable, ByVal dtImpuestos As DataTable,
                                       ByRef bGenerarFicheroDescuentosCargos As Boolean, ByRef FormatoEDI As E_FormatosEDI.Formato)


            bGenerarFicheroDescuentosCargos = False
            FormatoEDI = E_FormatosEDI.Formato.Ninguno


            Dim Serie As String = (row("SerieFac").ToString & "").Trim
            Dim Numero As String = (row("Factura").ToString & "").Trim
            If Serie <> "" Then Numero = Serie & "-" & Numero
            Dim EDI_Emisor As String = (row("GLN_Emisor").ToString & "").Trim
            Dim EDI_Vendedor As String = (row("GLN_Vendedor").ToString & "").Trim
            Dim EDI_Cliente As String = (row("GLN_Cliente").ToString & "").Trim
            Dim EDI_Receptor_Mercancia As String = (row("GLN_Descarga").ToString & "").Trim
            Dim EDI_Comprador As String = (row("GLN_Comprador").ToString & "").Trim
            Dim EDI_Pagador As String = (row("GLN_Pagador").ToString & "").Trim
            Dim Fecha As DateTime = VaDate(row("FechaFra"))
            Dim Cliente As String = (row("Nombre").ToString & "").Trim
            Dim domicilio_cliente As String = (row("Domicilio").ToString & "").Trim
            Dim poblacion_cliente As String = (row("Poblacion").ToString & "").Trim
            Dim codpostal_cliente As String = (row("CPostal").ToString & "").Trim
            Dim UsarReceptorComoClienteEDI As String = (row("UsarReceptorComoClienteEDI").ToString() & "").Trim

            Select Case VaInt(row("FormatoEDI"))

                Case VaInt(E_FormatosEDI.Formato.Alcampo)
                    FormatoEDI = E_FormatosEDI.Formato.Alcampo

                Case VaInt(E_FormatosEDI.Formato.Mercadona)
                    FormatoEDI = E_FormatosEDI.Formato.Mercadona

                Case VaInt(E_FormatosEDI.Formato.DIA)
                    FormatoEDI = E_FormatosEDI.Formato.DIA

                Case Else
                    FormatoEDI = E_FormatosEDI.Formato.Ninguno

            End Select
            CType(Factura.Cabecera, EDICOM_CabeceraYPieFactura).FormatoEDI = FormatoEDI


            Dim TotalGastosFra As Decimal = VaDec(row("TotalGastosFra"))

            Dim Base1 As Decimal = VaDec(row("Base1"))
            Dim Base2 As Decimal = VaDec(row("Base2"))
            Dim Base3 As Decimal = VaDec(row("Base3"))
            Dim Base4 As Decimal = VaDec(row("Base4"))
            Dim ImporteBruto As Decimal = Base1 + Base2 + Base3 + Base4 + TotalGastosFra                        'Suma de los importes brutos de las líneas (Cantidad x Precio) sin tener en cuenta los descuentos
            Dim ImporteNeto As Decimal = Base1 + Base2 + Base3 + Base4                                          'Suma de los importes netos de las líneas (Sin descuentos, ni cargos ni impuestos)
            Dim BaseImponible As Decimal = Base1 + Base2 + Base3 + Base4                                        'Importe neto + cargos (gastos) - descuentos

            'Dim Suplido As Decimal = VaDec(row("Suplido"))
            'Dim TotalFactura As Decimal = VaDec(row("TotalFactura")) + Suplido
            Dim TotalFactura As Decimal = VaDec(row("TotalFactura"))
            Dim FechaVencimiento As DateTime = VaDate(row("FechaVto"))
            'Dim porcentaje_retencion As Decimal = VaDec(row("PorRetencion"))

            Dim Pedido As String = (row("RefPedido").ToString & "").Trim
            Dim Departamento As String = (row("Departamento").ToString & "").Trim
            Dim SerieAlbaran As String = (row("SerieAlb").ToString & "").Trim
            Dim Albaran As String = (row("Alb").ToString & "").Trim
            If SerieAlbaran <> "" Then Albaran = SerieAlbaran & "-" & Albaran
            Dim FechaLlegada As String = "" : If VaDate(row("FechaLlegada")) > VaDate("") Then FechaLlegada = VaDate(row("FechaLlegada")).ToString("yyyyMMdd")

            Dim empresa As String = (row("Empresa").ToString & "").Trim
            Dim domicilio_empresa As String = (row("Domicilio_empresa").ToString & "").Trim
            Dim poblacion_empresa As String = (row("Poblacion_empresa").ToString & "").Trim
            Dim cpostal_empresa As String = (row("CPostal_empresa").ToString & "").Trim
            Dim provincia_empresa As String = (row("Provincia_empresa").ToString & "").Trim
            Dim nif_empresa As String = (row("NIF_Empresa").ToString & "").Trim
            Dim registro_mercantil As String = (row("RegistroMercantil").ToString & "").Trim


            Dim nif_cliente As String = (row("CIF").ToString & "").Trim



            'En caso de que haya más de 5 descuentos, hay que usar el fichero DTOFAC.TXT
            If FormatoEDI = E_FormatosEDI.Formato.Alcampo And dtGastosFactura.Rows.Count > 5 Then
                bGenerarFicheroDescuentosCargos = True
            End If


            'Datos de la cabecera de la factura
            Factura.Numero = Numero
            Factura.EDI_Vendedor = EDI_Vendedor
            Factura.EDI_Emisor = EDI_Emisor
            Factura.EDI_Comprador = EDI_Comprador
            If FormatoEDI = E_FormatosEDI.Formato.Alcampo Then
                Factura.DepartamentoPedido = Departamento
            End If
            Factura.EDI_Receptor = EDI_Receptor_Mercancia
            If FormatoEDI = E_FormatosEDI.Formato.Mercadona Or FormatoEDI = E_FormatosEDI.Formato.DIA Then
                Factura.EDI_Cliente = EDI_Cliente
            End If

            If UsarReceptorComoClienteEDI = "S" Then
                Factura.EDI_Cliente = Factura.EDI_Receptor
            End If

            Select Case FormatoEDI
                Case E_FormatosEDI.Formato.Mercadona
                    Factura.EDI_Pagador = EDI_Pagador                           'Campo PAGADOR sólo Mercadona
            End Select
            Factura.Pedido = Pedido
            Factura.FechaFactura = Fecha
            Select Case TotalFactura
                Case Is >= 0
                    Factura.TipoFactura = Comun.NombreDocumento_EDICOM.Factura_comercial
                Case Else
                    Factura.TipoFactura = Comun.NombreDocumento_EDICOM.Nota_de_abono
                    If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then
                        Factura.RazonCargoAbono = Comun.Razon_Cargo_Abono_EDICOM.Diferencias
                    End If
            End Select
            If FormatoEDI <> E_FormatosEDI.Formato.Alcampo Then
                Factura.FuncionDocumento = Comun.FuncionDocumento_EDICOM.Original
            End If
            Factura.RazonSocial_Cliente = Cliente
            Factura.Domicilio_Cliente = domicilio_cliente
            Factura.Poblacion_Cliente = poblacion_cliente
            Factura.CodPostal_Cliente = codpostal_cliente
            Factura.NIF_Cliente = nif_cliente
            Factura.Albaran = Albaran
            Factura.CodigoMoneda = "EUR"


            'Factura.ImporteBruto = ImporteBruto
            Factura.ImporteNeto = ImporteNeto


            'Si el número de impuestos diferentes impuestos es inferior o igual al número de impuestos que admite el fichero de cabecera, lo enviamos en la cabecera,
            'si no, lo enviamos en un fichero aparte
            If dtImpuestos.Rows.Count <= 6 Then

                Dim TotalImpuestos As Decimal = 0


                For indice As Integer = 0 To dtImpuestos.Rows.Count - 1

                    If indice < 6 Then

                        Dim rowImpuesto As DataRow = dtImpuestos.Rows(indice)
                        Dim indice_impuesto As Integer = indice + 1

                        Dim Tipo As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Vacio
                        Dim TipoImpuesto As String = (rowImpuesto("TipoImpuesto").ToString & "").Trim
                        If TipoImpuesto <> EDICOM.Comun.TiposImpuesto_EDICOM(EDICOM.Comun.TipoImpuesto_EDICOM.Vacio) Then
                            Dim pos As Integer = Array.IndexOf(EDICOM.Comun.TiposImpuesto_EDICOM, TipoImpuesto)
                            If pos >= 0 Then
                                Tipo = CType(pos, Comun.TipoImpuesto_EDICOM)
                            End If
                        End If
                        Dim Porcentaje As Decimal = VaDec(rowImpuesto("Porcentaje"))
                        Dim Base As Decimal = VaDec(rowImpuesto("BaseImponible"))
                        Dim Importe As Decimal = VaDec(rowImpuesto("Importe"))

                        AñadeImpuesto(Factura, Base, Importe, Porcentaje, Tipo, indice_impuesto, FormatoEDI)
                        indice_impuesto = indice_impuesto + 1
                        TotalImpuestos = TotalImpuestos + Importe

                    End If

                Next


                Factura.TotalImpuestos = TotalImpuestos

            End If



            'Total impuestos se añade en su apartado (GeneraTotalesImpuestos)
            Factura.BaseImponible = BaseImponible
            Factura.TotalFactura = TotalFactura
            If FormatoEDI = E_FormatosEDI.Formato.Alcampo Or FormatoEDI = E_FormatosEDI.Formato.DIA Then
                Factura.FechaVencimiento = FechaVencimiento
                Factura.ImporteVencimientoUnico = TotalFactura
            End If



            'Todo el apartado de los descuentos es sólo para ALCAMPO
            'Si el número de impuestos diferentes impuestos es inferior o igual al número de impuestos que admite el fichero de cabecera, lo enviamos en la cabecera,
            'si no, lo enviamos en un fichero aparte
            If (FormatoEDI = E_FormatosEDI.Formato.Alcampo Or (FormatoEDI = E_FormatosEDI.Formato.DIA)) And Not bGenerarFicheroDescuentosCargos Then

                Dim TotalDescuentos As Decimal = 0

                For indice As Integer = 0 To dtGastosFactura.Rows.Count - 1

                    Dim rowGastos As DataRow = dtGastosFactura.Rows(indice)

                    Dim tipogasto As String = (rowGastos("TipoGasto").ToString & "").Trim
                    Dim porcentaje As Decimal = VaDec(rowGastos("ValorGasto"))
                    Dim importe As Decimal = VaDec(rowGastos("ImpGastoEuros"))
                    If tipogasto <> "%" Then
                        porcentaje = 0
                    End If

                    If FormatoEDI = E_FormatosEDI.Formato.Alcampo Then
                        AñadeDescuentos(Factura, indice, porcentaje, importe)
                    End If

                    TotalDescuentos = TotalDescuentos + importe

                Next

                Factura.TotalDescuentos = TotalDescuentos

            End If


            'Datos emisor
            Factura.RazonSocial_Emisor = empresa
            Factura.Domicilio_Emisor = domicilio_empresa
            Factura.Poblacion_Emisor = poblacion_empresa
            Factura.CodPostal_Emisor = cpostal_empresa
            Factura.NIF_Emisor = nif_empresa
            Factura.RegistroMercantil_Emisor = registro_mercantil
            If FormatoEDI <> E_FormatosEDI.Formato.DIA Then
                Factura.FechaEfectivaServicio = FechaLlegada
            End If

            Select Case FormatoEDI

                Case E_FormatosEDI.Formato.DIA
                    Factura.NIF_IV = nif_cliente        'NIF empresa destinataria de la factura
                    Factura.NIF_SU = nif_empresa        'NIF empresa a quien se pidió la mercancía

                Case E_FormatosEDI.Formato.Mercadona
                    Factura.NIF_II = nif_empresa        'NIF empresa emisora de la factura
                    Factura.NIF_IV = nif_cliente        'NIF empresa destinataria de la factura
                    Factura.NIF_PR = nif_cliente        'NIF empresa que paga la factura
                    Factura.NIF_SU = nif_empresa        'NIF empresa a quien se pidió la mercancía

                Case Else

            End Select



        End Sub


        Private Sub AñadeImpuesto(ByRef Factura As EDICOM_Factura, ByVal base As Decimal, ByVal importe As Decimal, ByVal porcentaje As Decimal,
                                  ByVal Tipo As Comun.TipoImpuesto_EDICOM, ByVal numero_impuesto As Integer, ByVal FormatoEDI As E_FormatosEDI.Formato)


            Select Case numero_impuesto

                Case 1
                    Factura.BaseImponible1 = base
                    Factura.TipoImpuesto1 = Tipo
                    Factura.TasaImpuesto1 = porcentaje
                    Factura.ImporteImpuesto1 = importe

                Case 2
                    Factura.BaseImponible2 = base
                    Factura.TipoImpuesto2 = Tipo
                    Factura.TasaImpuesto2 = porcentaje
                    Factura.ImporteImpuesto2 = importe

                Case 3
                    Factura.BaseImponible3 = base
                    Factura.TipoImpuesto3 = Tipo
                    Factura.TasaImpuesto3 = porcentaje
                    Factura.ImporteImpuesto3 = importe

                Case 4
                    Factura.BaseImponible4 = base
                    Factura.TipoImpuesto4 = Tipo
                    Factura.TasaImpuesto4 = porcentaje
                    Factura.ImporteImpuesto4 = importe

                Case 5
                    Factura.BaseImponible5 = base
                    Factura.TipoImpuesto5 = Tipo
                    Factura.TasaImpuesto5 = porcentaje
                    Factura.ImporteImpuesto5 = importe

                Case 6
                    Factura.BaseImponible6 = base
                    Factura.TipoImpuesto6 = Tipo
                    Factura.TasaImpuesto6 = porcentaje
                    Factura.ImporteImpuesto6 = importe

            End Select


        End Sub


        Private Sub AñadeDescuentos(ByRef Factura As EDICOM_Factura, ByVal indice As Integer, ByVal porcentaje As Decimal, ByVal importe As Decimal)

            Select Case indice

                Case 0
                    Factura.CalificadorDescuentoCargo1 = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                    Factura.SecuenciaDescuentoCargo1 = 1
                    Factura.TipoDescuentoCargo1 = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial
                    If porcentaje <> 0 Then Factura.PorcentajeDescuentoCargo1 = porcentaje
                    Factura.ImporteDescuentoCargo1 = importe

                Case 1
                    Factura.CalificadorDescuentoCargo2 = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                    Factura.SecuenciaDescuentoCargo2 = 1
                    Factura.TipoDescuentoCargo2 = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial
                    If porcentaje <> 0 Then Factura.PorcentajeDescuentoCargo2 = porcentaje
                    Factura.ImporteDescuentoCargo2 = importe

                Case 2
                    Factura.CalificadorDescuentoCargo3 = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                    Factura.SecuenciaDescuentoCargo3 = 1
                    Factura.TipoDescuentoCargo3 = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial
                    If porcentaje <> 0 Then Factura.PorcentajeDescuentoCargo3 = porcentaje
                    Factura.ImporteDescuentoCargo3 = importe

                Case 3
                    Factura.CalificadorDescuentoCargo4 = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                    Factura.SecuenciaDescuentoCargo4 = 1
                    Factura.TipoDescuentoCargo4 = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial
                    If porcentaje <> 0 Then Factura.PorcentajeDescuentoCargo4 = porcentaje
                    Factura.ImporteDescuentoCargo4 = importe

                Case 4
                    Factura.CalificadorDescuentoCargo5 = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                    Factura.SecuenciaDescuentoCargo5 = 1
                    Factura.TipoDescuentoCargo5 = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial
                    If porcentaje <> 0 Then Factura.PorcentajeDescuentoCargo5 = porcentaje
                    Factura.ImporteDescuentoCargo5 = importe

            End Select

        End Sub


        Private Sub GeneraObservacionesGlobales(ByRef Factura As EDICOM_Factura, row As DataRow)

            'Observaciones cabecera
            Dim obsc1 As String = (row("Obs1").ToString & "").Trim
            Dim obsc2 As String = (row("Obs2").ToString & "").Trim
            Dim obsc3 As String = (row("Obs3").ToString & "").Trim

            If obsc1 <> "" Or obsc2 <> "" Then

                'Linea de observaciones de cabecera de factura
                Dim ObservacionesFactura1 As New EDICOM_ObservacionesGlobalesFactura(Factura.Numero, 1, obsc1, obsc2, obsc3, "", "")
                Factura.AñadeObservacionesGlobales(ObservacionesFactura1)

            End If

        End Sub


        Private Sub GeneraDescuentosYCargosGlobales(ByRef Factura As EDICOM_Factura, row As DataRow, dtGastosFactura As DataTable)


            If dtGastosFactura.Rows.Count > 0 Then


                Dim TotalDescuentos As Decimal = 0


                Dim indice_gastos As Integer = 0


                'Descuentos/cargos de factura
                If Not IsNothing(dtGastosFactura) Then

                    For indice_gastos = 0 To dtGastosFactura.Rows.Count - 1

                        Dim rowGastos As DataRow = dtGastosFactura.Rows(indice_gastos)

                        Dim tipogasto As String = (rowGastos("TipoGasto").ToString & "").Trim
                        Dim porcentaje As Decimal = VaDec(rowGastos("ValorGasto"))
                        Dim importe As Decimal = VaDec(rowGastos("ImpGastoEuros"))
                        Dim descripcion As String = (rowGastos("Descripcion").ToString & "").Trim

                        Dim descuento As New EDICOM_DescuentosYCargosGlobalesFactura
                        descuento.NumeroFactura = Factura.Numero
                        descuento.NumeroLinea = indice_gastos + 1
                        descuento.CalificadorDescuentoCargo = Comun.Calificador_Descuento_Cargo_EDICOM.Descuento
                        descuento.Secuencia = 1
                        descuento.Importe = importe
                        If tipogasto = "%" Then
                            descuento.Porcentaje = porcentaje
                        End If
                        descuento.TipoDescuentoCargo = Comun.Tipo_Descuento_Cargo_EDICOM.Descuento_comercial


                        Factura.AñadeDescuentosYCargosGlobales(descuento)        'Añade descuentos en factura (sólo cabecera)


                        TotalDescuentos = TotalDescuentos + importe

                    Next

                End If


                Factura.TotalDescuentos = TotalDescuentos


            End If

        End Sub



        Private Sub GeneraLineasFactura(ByRef Factura As EDICOM_Factura, ByVal rowFactura As DataRow, ByVal dtLineas As DataTable, ByVal dtOtrosConceptos As DataTable, ByVal FormatoEDI As E_FormatosEDI.Formato,
                                        Optional IdIdioma As Integer = 1)



            Dim Iva1 As Decimal = 0
            Dim Iva2 As Decimal = 0
            Dim Iva3 As Decimal = 0

            Dim RE1 As Decimal = 0
            Dim RE2 As Decimal = 0
            Dim RE3 As Decimal = 0

            Dim CampaAlb As String = ""


            If Not IsNothing(rowFactura) Then

                Iva1 = VaDec(rowFactura("Iva1"))
                Iva2 = VaDec(rowFactura("Iva2"))
                Iva3 = VaDec(rowFactura("Iva3"))

                RE1 = VaDec(rowFactura("RE1"))
                RE2 = VaDec(rowFactura("RE2"))
                RE3 = VaDec(rowFactura("RE3"))

                CampaAlb = (rowFactura("CampaAlb").ToString & "").Trim

            End If


            Dim IdFactura As String = (rowFactura("IdFactura").ToString & "").Trim


            'Líneas de detalle
            If Not IsNothing(dtLineas) Then

                Dim indice_linea As Integer = 0




                For Each rowAlbaran As DataRow In dtLineas.Rows


                    'Obtiene datos comunes del albarán 
                    Dim IdAlbaran As String = (rowAlbaran("IdAlbaran").ToString & "").Trim
                    Dim Pedido As String = (rowAlbaran("Pedido").ToString & "").Trim
                    Dim FechaAlbaran As String = "" : If VaDate(rowAlbaran("Fecha")) > VaDate("") Then FechaAlbaran = VaDate(rowAlbaran("Fecha")).ToString("yyyyMMdd")
                    Dim FechaPedido As String = "" : If VaDate(rowAlbaran("FechaPedido")) > VaDate("") Then FechaPedido = VaDate(rowAlbaran("FechaPedido")).ToString("yyyyMMdd")
                    Dim Observaciones As String = (rowAlbaran("Observaciones").ToString & "").Trim
                    Dim RefCliente As String = (rowAlbaran("Referencia").ToString & "").Trim
                    Dim RefValoracion As String = (rowAlbaran("ReferenciaValoracion").ToString & "").Trim


                    'Productos
                    Dim IdPresentacion As String = (rowAlbaran("IdPresentacion").ToString & "").Trim
                    Dim CodigoArticuloEDI As String = (rowAlbaran("CodigoArticuloEDI").ToString & "").Trim
                    Dim ReferenciaCliente As String = (rowAlbaran("ReferenciaCliente").ToString & "").Trim
                    Dim Presentacion As String = (rowAlbaran("Presentacion").ToString & "").Trim
                    Dim Genero As String = (rowAlbaran("Genero").ToString & "").Trim
                    Dim Confeccion As String = (rowAlbaran("Confeccion").ToString & "").Trim
                    Dim Categoria As String = (rowAlbaran("Categoria").ToString & "").Trim
                    Dim Bultos As Integer = VaInt(rowAlbaran("Bultos"))
                    Dim Kilos As Integer = VaInt(rowAlbaran("Kilos"))
                    Dim PrecioBruto As Decimal = VaDec(rowAlbaran("Precio"))
                    Dim PrecioNeto As Decimal = VaDec(rowAlbaran("PrecioNeto"))
                    Dim Importe As Decimal = VaDec(rowAlbaran("ImporteNeto"))
                    Dim Palets As Integer = VaInt(rowAlbaran("Palets"))
                    Dim TipoPrecio As String = (rowAlbaran("TipoPrecio").ToString()).Trim
                    Dim Piezas As Integer = VaInt(rowAlbaran("Piezas"))

                    Dim Descripcion As String = Presentacion
                    If Descripcion.Trim = "" Then
                        Descripcion = Genero & " " & Confeccion
                    End If

                    Dim linea_detalle As New EDICOM_DetalleFactura
                    linea_detalle.NumeroFactura = Factura.Numero
                    linea_detalle.NumeroLinea = indice_linea + 1
                    linea_detalle.ReferenciaEAN = CodigoArticuloEDI

                    If FormatoEDI = E_FormatosEDI.Formato.DIA Then
                        linea_detalle.ReferenciaCliente = ReferenciaCliente
                    End If

                    If FormatoEDI = E_FormatosEDI.Formato.Alcampo Then
                        linea_detalle.ReferenciaProveedor = IdPresentacion
                    End If
                    linea_detalle.Descripcion = Descripcion

                    If TipoPrecio = "P" Then
                        linea_detalle.Cantidad = Piezas
                    Else
                        linea_detalle.Cantidad = Kilos
                    End If

                    If FormatoEDI = E_FormatosEDI.Formato.DIA Then
                        linea_detalle.CantidadEntregada = Palets
                    End If

                    If FormatoEDI <> E_FormatosEDI.Formato.Mercadona Then

                        If TipoPrecio = "P" Then
                            linea_detalle.UMedida = Comun.Unidad_Medida_EDICOM.Piezas
                        Else
                            linea_detalle.UMedida = Comun.Unidad_Medida_EDICOM.Kilos
                        End If

                    End If


                    linea_detalle.PrecioBruto = PrecioBruto
                    linea_detalle.PrecioNeto = PrecioNeto


                    'Impuestos
                    'El desglose de impuestos en la línea de la factura solo lo pide Mercadona
                    If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then

                        Dim Cuota1 As Decimal = VaDec(rowAlbaran("Cuota1"))
                        Dim CuotaRe1 As Decimal = VaDec(rowAlbaran("CuotaRe1"))

                        Dim indice_impuesto_productos As Integer = 1
                        If Cuota1 <> 0 Then
                            Dim Cuota As Decimal = Importe * Iva1 / 100
                            AñadeImpuestoLinea(linea_detalle, indice_impuesto_productos, Comun.TipoImpuesto_EDICOM.IVA, Iva1, Cuota)
                            indice_impuesto_productos = indice_impuesto_productos + 1
                        End If
                        If CuotaRe1 <> 0 Then
                            Dim CuotaRe As Decimal = Importe * RE1 / 100
                            AñadeImpuestoLinea(linea_detalle, indice_impuesto_productos, Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia, RE1, CuotaRe)
                            indice_impuesto_productos = indice_impuesto_productos + 1
                        End If
                    End If

                    linea_detalle.ImporteNeto = Importe

                    'Dia No quiere el pedido en la linea 13/03/19 -> Carmen Lozano DiaGroup - Pero ahora no se la pasan los edicon sin este campo asi que se aguanten los de dia
                    'If FormatoEDI = E_FormatosEDI.Formato.DIA Then
                    '    linea_detalle.Pedido = Pedido
                    'End If



                    'Observaciones
                    Dim lst As New List(Of String)

                    If Observaciones <> "" Then lst.Add(Observaciones)
                    If RefCliente <> "" Then lst.Add("Referencia cliente: " & RefCliente)
                    If RefValoracion <> "" Then lst.Add("Referencia valoración: " & RefValoracion)

                    If lst.Count >= 0 Then

                        Dim Obs1 As String = "" : If lst.Count > 0 Then Obs1 = lst(0)
                        Dim Obs2 As String = "" : If lst.Count > 1 Then Obs2 = lst(1)
                        Dim Obs3 As String = "" : If lst.Count > 2 Then Obs3 = lst(2)
                        Dim Obs4 As String = "" : If lst.Count > 3 Then Obs4 = lst(3)
                        Dim Obs5 As String = "" : If lst.Count > 4 Then Obs5 = lst(4)

                        Dim ObservacionesLinea2 As New EDICOM_ObservacionesLineasFactura(Factura.Numero, linea_detalle.NumeroLinea, 1, Obs1, Obs2, Obs3, Obs4, Obs5)
                        linea_detalle.ObservacionesLinea.Add(ObservacionesLinea2)
                    End If


                    Factura.AñadeLineasFactura(linea_detalle)                                                'Añade la línea de producto

                    indice_linea = indice_linea + 1


                Next



                'Envases
                Dim dtEnvases As DataTable = Tabla_SQL_LineasFactura_Envases(IdFactura, CampaAlb)
                If Not IsNothing(dtEnvases) Then

                    For Each rowEnvase As DataRow In dtEnvases.Rows

                        Dim IdEnvase As String = (rowEnvase("IdEnvase").ToString & "").Trim
                        Dim Envase As String = (rowEnvase("NombreEnvase").ToString & "").Trim
                        Dim UdsEnvase As Integer = VaInt(rowEnvase("UdsEnvase"))
                        Dim PrecioEnv As Decimal = VaDec(rowEnvase("PrecioEnv"))
                        Dim ImporteEnv As Decimal = VaDec(rowEnvase("ImporteEnv"))

                        If ImporteEnv <> 0 Then

                            Dim linea_envase As New EDICOM_DetalleFactura
                            linea_envase.NumeroFactura = Factura.Numero
                            linea_envase.NumeroLinea = indice_linea + 1
                            linea_envase.ReferenciaEAN = IdEnvase
                            If FormatoEDI = E_FormatosEDI.Formato.DIA Then
                                linea_envase.ReferenciaCliente = IdEnvase
                            End If
                            If FormatoEDI = E_FormatosEDI.Formato.Alcampo Then
                                linea_envase.ReferenciaProveedor = IdEnvase
                            End If
                            linea_envase.Descripcion = Envase
                            linea_envase.Cantidad = UdsEnvase
                            If FormatoEDI <> E_FormatosEDI.Formato.Mercadona Then
                                linea_envase.UMedida = Comun.Unidad_Medida_EDICOM.Piezas
                            End If
                            linea_envase.PrecioBruto = PrecioEnv
                            linea_envase.PrecioNeto = PrecioEnv

                            'Impuestos
                            If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then
                                Dim indice_impuesto_envases As Integer = 1

                                Dim Cuota2 As Decimal = ImporteEnv * Iva2 / 100
                                Dim CuotaRe2 As Decimal = ImporteEnv * RE2 / 100

                                If Cuota2 <> 0 Then
                                    Dim Cuota As Decimal = ImporteEnv * Iva2 / 100
                                    AñadeImpuestoLinea(linea_envase, indice_impuesto_envases, Comun.TipoImpuesto_EDICOM.IVA, Iva2, Cuota)
                                    indice_impuesto_envases = indice_impuesto_envases + 1
                                End If
                                If CuotaRe2 <> 0 Then
                                    Dim CuotaRe As Decimal = ImporteEnv * RE2 / 100
                                    AñadeImpuestoLinea(linea_envase, indice_impuesto_envases, Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia, RE2, CuotaRe)
                                    indice_impuesto_envases = indice_impuesto_envases + 1
                                End If
                            End If


                            linea_envase.ImporteNeto = ImporteEnv


                            Factura.AñadeLineasFactura(linea_envase)                                                'Añade la línea de envase

                            indice_linea = indice_linea + 1

                        End If

                    Next

                End If


                'Otros conceptos
                If Not IsNothing(dtOtrosConceptos) Then

                    For Each rowOtros As DataRow In dtOtrosConceptos.Rows


                        Dim Codigo As String = (rowOtros("Codigo").ToString & "").Trim
                        Dim Concepto As String = (rowOtros("OtrosConcepto").ToString & "").Trim
                        Dim Cantidad As Integer = VaInt(rowOtros("OtrosCantidad"))
                        Dim Precio As Decimal = VaDec(rowOtros("OtrosPrecio"))
                        Dim Importe As Decimal = VaDec(rowOtros("OtrosImporte"))
                        Dim Tipo As String = (rowOtros("Tipo").ToString & "").Trim



                        If Importe <> 0 Then

                            Dim linea_otros As New EDICOM_DetalleFactura
                            linea_otros.NumeroFactura = Factura.Numero
                            linea_otros.NumeroLinea = indice_linea + 1
                            linea_otros.ReferenciaEAN = Codigo
                            If FormatoEDI = E_FormatosEDI.Formato.DIA Then
                                linea_otros.ReferenciaCliente = Codigo
                            End If
                            If FormatoEDI = E_FormatosEDI.Formato.Alcampo Then
                                linea_otros.ReferenciaProveedor = Codigo
                            End If
                            linea_otros.Descripcion = Concepto
                            linea_otros.PrecioBruto = Precio
                            linea_otros.PrecioNeto = Precio
                            linea_otros.Cantidad = Cantidad



                            Dim indice_impuesto As Integer = 1

                            Select Case Tipo

                                Case "G"

                                    If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then

                                        Dim Cuota1 As Decimal = Importe * Iva1 / 100
                                        Dim CuotaRe1 As Decimal = Importe * RE1 / 100

                                        If Cuota1 <> 0 Then
                                            Dim Cuota As Decimal = Importe * Iva1 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.IVA, Iva1, Cuota)
                                            indice_impuesto = indice_impuesto + 1
                                        End If
                                        If CuotaRe1 <> 0 Then
                                            Dim CuotaRe As Decimal = Importe * RE1 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia, RE1, CuotaRe)
                                            indice_impuesto = indice_impuesto + 1
                                        End If

                                    Else
                                        linea_otros.UMedida = Comun.Unidad_Medida_EDICOM.Kilos
                                    End If
                                    

                                Case "E"

                                    If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then

                                        Dim Cuota2 As Decimal = Importe * Iva2 / 100
                                        Dim CuotaRe2 As Decimal = Importe * RE2 / 100

                                        If Cuota2 <> 0 Then
                                            Dim Cuota As Decimal = Importe * Iva2 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.IVA, Iva2, Cuota)
                                            indice_impuesto = indice_impuesto + 1
                                        End If
                                        If CuotaRe2 <> 0 Then
                                            Dim CuotaRe As Decimal = Importe * RE2 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia, RE2, CuotaRe)
                                            indice_impuesto = indice_impuesto + 1
                                        End If

                                    Else
                                        linea_otros.UMedida = Comun.Unidad_Medida_EDICOM.Piezas
                                    End If

                                Case Else

                                    If FormatoEDI = E_FormatosEDI.Formato.Mercadona Then
                                        Dim Cuota3 As Decimal = Importe * Iva3 / 100
                                        Dim CuotaRe3 As Decimal = Importe * RE3 / 100

                                        If Cuota3 <> 0 Then
                                            Dim Cuota As Decimal = Importe * Iva3 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.IVA, Iva3, Cuota)
                                            indice_impuesto = indice_impuesto + 1
                                        End If
                                        If CuotaRe3 <> 0 Then
                                            Dim CuotaRe As Decimal = Importe * RE3 / 100
                                            AñadeImpuestoLinea(linea_otros, indice_impuesto, Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia, RE3, CuotaRe)
                                            indice_impuesto = indice_impuesto + 1
                                        End If
                                    Else
                                        linea_otros.UMedida = Comun.Unidad_Medida_EDICOM.Piezas
                                    End If

                            End Select

                            linea_otros.ImporteNeto = Importe



                            Factura.AñadeLineasFactura(linea_otros)                                                'Añade la línea de otros conceptos

                            indice_linea = indice_linea + 1

                        End If



                    Next

                End If

            End If


        End Sub


        Private Sub AñadeImpuestoLinea(linea As EDICOM_DetalleFactura, indice_impuesto As Integer, Tipo As Comun.TipoImpuesto_EDICOM, Porcentaje As Decimal, Importe As Decimal)


            Importe = Math.Round(Importe, 3)

            Select Case indice_impuesto

                Case 1
                    linea.TipoImpuesto1 = Tipo
                    linea.PorcentajeImpuesto1 = Porcentaje
                    linea.ImporteImpuesto1 = Importe

                Case 2
                    linea.TipoImpuesto2 = Tipo
                    linea.PorcentajeImpuesto2 = Porcentaje
                    linea.ImporteImpuesto2 = Importe

                Case 3
                    linea.TipoImpuesto3 = Tipo
                    linea.PorcentajeImpuesto3 = Porcentaje
                    linea.ImporteImpuesto3 = Importe

            End Select

        End Sub



        Private Sub GeneraDesgloseImpuestos(ByRef Factura As EDICOM_Factura, row As DataRow, ByVal dtImpuestos As DataTable)


            Dim TotalImpuestos As Decimal = 0


            If Not IsNothing(dtImpuestos) Then

                For indice_impuestos As Integer = 0 To dtImpuestos.Rows.Count - 1

                    Dim rowImpuesto As DataRow = dtImpuestos.Rows(indice_impuestos)

                    Dim TipoImpuesto As String = (rowImpuesto("TipoImpuesto").ToString & "").Trim
                    Dim PorcentajeImpuesto As Decimal = VaDec(rowImpuesto("Porcentaje"))
                    Dim BaseImpuesto As Decimal = VaDec(rowImpuesto("BaseImponible"))
                    Dim ImporteImpuesto As Decimal = VaDec(rowImpuesto("Importe"))


                    'If indice_impuestos >= 6 Then

                    Dim impuesto As New EDICOM_DesgloseImpuestosFactura

                    impuesto.NumeroFactura = Factura.Numero
                    impuesto.NumeroLinea = indice_impuestos + 1
                    If TipoImpuesto <> EDICOM.Comun.TiposImpuesto_EDICOM(EDICOM.Comun.TipoImpuesto_EDICOM.Vacio) Then
                        Dim pos As Integer = Array.IndexOf(EDICOM.Comun.TiposImpuesto_EDICOM, TipoImpuesto)
                        If pos >= 0 Then
                            impuesto.Tipo = CType(pos, Comun.TipoImpuesto_EDICOM)
                        Else
                            impuesto.Tipo = Comun.TipoImpuesto_EDICOM.Vacio
                        End If
                    End If
                    impuesto.Porcentaje = PorcentajeImpuesto
                    impuesto.Importe = ImporteImpuesto
                    impuesto.Base = BaseImpuesto

                    Factura.AñadeDesgloseImpuestos(impuesto)                    'Añade registro de impuestos a la cabecera

                    'End If

                    TotalImpuestos = TotalImpuestos + ImporteImpuesto

                Next

            End If


            Factura.TotalImpuestos = TotalImpuestos


        End Sub


        Private Function GeneraTablaImpuestos(row As DataRow) As DataTable

            'Impuestos
            Dim acumImpuestos As New Acumulador


            Dim Base1 As Decimal = VaDec(row("Base1"))
            Dim Base2 As Decimal = VaDec(row("Base2"))
            Dim Base3 As Decimal = VaDec(row("Base3"))
            Dim Base4 As Decimal = VaDec(row("Base4"))

            Dim Iva1 As Decimal = VaDec(row("Iva1"))
            Dim Iva2 As Decimal = VaDec(row("Iva2"))
            Dim Iva3 As Decimal = VaDec(row("Iva3"))
            Dim Iva4 As Decimal = VaDec(row("Iva4"))

            Dim CuotaIva1 As Decimal = VaDec(row("Cuota1"))
            Dim CuotaIva2 As Decimal = VaDec(row("Cuota2"))
            Dim CuotaIva3 As Decimal = VaDec(row("Cuota3"))
            Dim CuotaIva4 As Decimal = VaDec(row("Cuota4"))


            Dim Re1 As Decimal = VaDec(row("Re1"))
            Dim Re2 As Decimal = VaDec(row("Re2"))
            Dim Re3 As Decimal = VaDec(row("Re3"))
            Dim Re4 As Decimal = VaDec(row("Re4"))

            Dim CuotaRe1 As Decimal = VaDec(row("CuotaRe1"))
            Dim CuotaRe2 As Decimal = VaDec(row("CuotaRe2"))
            Dim CuotaRe3 As Decimal = VaDec(row("CuotaRe3"))
            Dim CuotaRe4 As Decimal = VaDec(row("CuotaRe4"))

            'Dim porcentaje_retencion As Decimal = VaDec(row("PorRetencion"))



            'Exento iva
            If CuotaIva1 = 0 And CuotaIva2 = 0 And CuotaIva3 = 0 And CuotaIva4 = 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Exento
                Dim stClave As New stClave_Impuesto(TipoImpuesto, 0.0)
                Dim stDatos As New stDatos_Impuesto(Base1 + Base2 + Base3 + Base4, 0.0)
                acumImpuestos.Suma(stClave, stDatos)
            End If


            'Iva
            If CuotaIva1 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.IVA
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Iva1)
                Dim stDatos As New stDatos_Impuesto(Base1, CuotaIva1)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaIva2 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.IVA
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Iva2)
                Dim stDatos As New stDatos_Impuesto(Base2, CuotaIva2)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaIva3 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.IVA
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Iva3)
                Dim stDatos As New stDatos_Impuesto(Base3, CuotaIva3)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaIva4 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.IVA
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Iva4)
                Dim stDatos As New stDatos_Impuesto(Base4, CuotaIva4)
                acumImpuestos.Suma(stClave, stDatos)
            End If

            'Recargo equivalencia
            If CuotaRe1 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Re1)
                Dim stDatos As New stDatos_Impuesto(Base1, CuotaRe1)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaRe2 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Re2)
                Dim stDatos As New stDatos_Impuesto(Base2, CuotaRe2)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaRe3 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Re3)
                Dim stDatos As New stDatos_Impuesto(Base3, CuotaRe3)
                acumImpuestos.Suma(stClave, stDatos)
            End If
            If CuotaRe4 <> 0 Then
                Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Recargo_de_equivalencia
                Dim stClave As New stClave_Impuesto(TipoImpuesto, Re4)
                Dim stDatos As New stDatos_Impuesto(Base4, CuotaRe4)
                acumImpuestos.Suma(stClave, stDatos)
            End If


            ''IRPF
            'If porcentaje_retencion <> 0 Then
            '    Dim base_retencion As Decimal = Base1 + Base2 + Base3 + Base4
            '    Dim importe_retencion As Decimal = base_retencion * porcentaje_retencion / 100
            '    If importe_retencion <> 0 Then
            '        Dim TipoImpuesto As Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Retenciones_servicios_profesionales
            '        Dim stClave As New stClave_Impuesto(TipoImpuesto, porcentaje_retencion)
            '        Dim stDatos As New stDatos_Impuesto(Base1 + Base2 + Base3 + Base4, importe_retencion)
            '        acumImpuestos.Suma(stClave, stDatos)
            '    End If
            'End If




            Dim dtImpuestos As DataTable = acumImpuestos.DataTable


            Return dtImpuestos

        End Function


        '    Private Sub ReemplazaCamposEDI(TipoMensaje As String, FormatoEDI As String, registro As Object)


        '        Dim sql As String = "SELECT FED_Campo as Campo, FED_ValorCampo as Valor FROM FormatosEDI WHERE FED_ProveedorEDI = " & VaInt(EDI.Comun.ProveedorEDI.SERES).ToString
        '        sql = sql & " AND FED_IdFormatoEDI = " & FormatoEDI

        '        Dim DcCampos As New Dictionary(Of String, String)

        '        Dim dt As DataTable = cn.ConsultaSQL(sql)
        '        If Not IsNothing(dt) Then
        '            For Each row As DataRow In dt.Rows

        '                Dim Campo As String = (row("Campo").ToString & "").Trim.ToLower
        '                Campo = Campo.Replace(TipoMensaje.ToLower & "_", "")
        '                Dim Valor As String = (row("Valor").ToString & "")

        '                DcCampos(Campo) = Valor

        '            Next
        '        End If



        '        Dim Campos() As Reflection.FieldInfo = registro.GetType.GetFields(Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public)
        '        If Campos.Length > 0 Then
        '            For Each campo As Reflection.FieldInfo In Campos
        '                If Not IsNothing(campo) Then


        '                    Dim bCambiar As Boolean = True


        '                    'Campos de referencia adicional para el comprador de ZENALCO
        '                    If VaInt(FormatoEDI) = VaInt(E_FormatosEDI.Formato.Zenalco) Then

        '                        If TypeOf registro Is SERES.SERES_RegistroInformacionPartes Then

        '                            If campo.Name.ToLower = "calificadorreferenciaadicional" Or campo.Name.ToLower = "referenciaadicional" Then

        '                                If CType(registro, SERES.SERES_RegistroInformacionPartes).Calificador_interlocutor = Comun.Calificador_interlocutor.Comprador Then
        '                                    bCambiar = True
        '                                Else
        '                                    bCambiar = False
        '                                End If

        '                            End If

        '                        End If

        '                    End If



        '                    If bCambiar Then
        '                        If DcCampos.ContainsKey(campo.Name.ToLower) Then
        '                            campo.SetValue(registro, DcCampos(campo.Name.ToLower))
        '                        End If
        '                    End If

        '                End If
        '            Next
        '        End If



        '    End Sub


        Public Overrides Function Resultado() As System.Collections.Generic.List(Of EDI.EDI_ArchivoSalida)

            Dim lst As New List(Of EDI.EDI_ArchivoSalida)


            Dim CABFAC As New EDI.EDI_ArchivoSalida("CABFAC.TXT")
            Dim OBSFAC As New EDI.EDI_ArchivoSalida("OBSFAC.TXT")
            Dim DTOFAC As New EDI.EDI_ArchivoSalida("DTOFAC.TXT")
            Dim LINFAC As New EDI.EDI_ArchivoSalida("LINFAC.TXT")
            Dim OBSLFAC As New EDI.EDI_ArchivoSalida("OBSLFAC.TXT")
            Dim IMPFAC As New EDI.EDI_ArchivoSalida("IMPFAC.TXT")


            For Each Factura As EDICOM_Factura In Me.Facturas

                CABFAC.Lineas.Add(Factura.Cabecera.linea())

                If Not IsNothing(Factura.Fichero_ObservacionesGlobales) Then
                    OBSFAC.Lineas.Add(Factura.Fichero_ObservacionesGlobales.linea())
                End If

                For Each dtocargo As EDICOM_DescuentosYCargosGlobalesFactura In Factura.DescuentosCargosFactura
                    DTOFAC.Lineas.Add(dtocargo.linea())
                Next
                
                For Each detalle As EDICOM_DetalleFactura In Factura.Lineas
                    'Líneas
                    LINFAC.Lineas.Add(detalle.linea())
                    'Observaciones de la línea
                    If detalle.ObservacionesLinea.Count > 0 Then
                        For Each observacion As EDICOM_ObservacionesLineasFactura In detalle.ObservacionesLinea
                            OBSLFAC.Lineas.Add(observacion.linea())
                        Next
                    End If
                Next

                For Each impuesto As EDICOM_DesgloseImpuestosFactura In Factura.ImpuestosFactura
                    IMPFAC.Lineas.Add(impuesto.linea())
                Next

            Next


            lst.Add(CABFAC)
            If OBSFAC.Lineas.Count > 0 Then lst.Add(OBSFAC)
            If DTOFAC.Lineas.Count > 0 Then lst.Add(DTOFAC)
            lst.Add(LINFAC)
            If OBSLFAC.Lineas.Count > 0 Then lst.Add(OBSLFAC)
            If IMPFAC.Lineas.Count > 0 Then lst.Add(IMPFAC)


            Return lst

        End Function


        Public Overrides Function GuardarArchivos(Optional codificacion As System.Text.Encoding = Nothing) As System.Collections.Generic.Dictionary(Of EDI.EDI_ArchivoSalida, String)


            If IsNothing(codificacion) Then
                codificacion = System.Text.Encoding.UTF8
            End If


            Dim DcArchivos As New Dictionary(Of EDI_ArchivoSalida, String)


            If Directory.Exists(Carpeta_destino) Then

                For Each archivo_salida As EDI_ArchivoSalida In Resultado()

                    If archivo_salida.Guardar(Carpeta_destino, archivo_salida.Nombre, codificacion) Then
                        DcArchivos(archivo_salida) = Carpeta_destino & archivo_salida.Nombre
                    End If

                Next

            Else
                MsgBox("No existe la carpeta de destino " & Carpeta_destino)
            End If



            Return DcArchivos

        End Function


        Public Overrides Function SubirArchivoFTP(ByVal archivo As String, ByVal url_ftp As String, ByVal carpeta_destino As String, ByVal usuario As String, ByVal clave As String) As Boolean


            'Throw New Exception("Función no implementada para ficheros EDICOM")
            Return True

        End Function


    End Class


End Namespace


