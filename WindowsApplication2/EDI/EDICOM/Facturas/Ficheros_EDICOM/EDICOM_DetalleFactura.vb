Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI
Imports NetAgro.EDICOM.Comun


Namespace EDICOM

    Public Class EDICOM_DetalleFactura
        Inherits EDI.EDI_LineaFactura


        Public ObservacionesLinea As New List(Of EDICOM_ObservacionesLineasFactura)


        Public NumeroFactura As String = ""
        Public NumeroLinea As Integer = 0
        Public ReferenciaEAN As String = ""
        Public ReferenciaCliente As String = ""
        Public ReferenciaProveedor As String = ""
        Public Descripcion As String = ""
        Public Cantidad As Decimal = 0
        Public CantidadEntregada As Integer = 0
        Public UMedida As Unidad_Medida_EDICOM = Unidad_Medida_EDICOM.Vacio
        Public PrecioBruto As Decimal = 0
        Public PrecioNeto As Decimal = 0

        'Impuestos
        Public TipoImpuesto1 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public PorcentajeImpuesto1 As Decimal = 0
        Public ImporteImpuesto1 As Decimal = 0
        Public TipoImpuesto2 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public PorcentajeImpuesto2 As Decimal = 0
        Public ImporteImpuesto2 As Decimal = 0
        Public TipoImpuesto3 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public PorcentajeImpuesto3 As Decimal = 0
        Public ImporteImpuesto3 As Decimal = 0

        'Descuentos y cargos
        Public CalificadorDescuentoCargo1 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaDescuentoCargo1 As Integer = 0
        Public TipoDescuentoCargo1 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDescuentoCargo1 As Decimal = 0
        Public ImporteDescuentoCargo1 As Decimal = 0
        Public CalificadorDescuentoCargo2 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaDescuentoCargo2 As Integer = 0
        Public TipoDescuentoCargo2 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDescuentoCargo2 As Decimal = 0
        Public ImporteDescuentoCargo2 As Decimal = 0
        Public CalificadorDescuentoCargo3 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaDescuentoCargo3 As Integer = 0
        Public TipoDescuentoCargo3 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDescuentoCargo3 As Decimal = 0
        Public ImporteDescuentoCargo3 As Decimal = 0
        Public CalificadorDescuentoCargo4 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaDescuentoCargo4 As Integer = 0
        Public TipoDescuentoCargo4 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDescuentoCargo4 As Decimal = 0
        Public ImporteDescuentoCargo4 As Decimal = 0

        Public Lote As String = ""
        Public TipoArticulo As Comun.Tipo_Articulo_EDICOM = Tipo_Articulo_EDICOM.Vacio
        Public ImporteBruto As Decimal = 0





        Public ImporteNeto As Decimal = 0
        Public Pedido As String = ""



        Public Sub New()
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Linea_detalle)
        End Sub



        Public Overrides Function linea() As String

            Dim UMedida As String = Unidades_Medida_EDICOM(Me.UMedida)

            Dim TipoImpuesto1 As String = TiposImpuesto_EDICOM(Me.TipoImpuesto1)
            Dim TipoImpuesto2 As String = TiposImpuesto_EDICOM(Me.TipoImpuesto2)
            Dim TipoImpuesto3 As String = TiposImpuesto_EDICOM(Me.TipoImpuesto3)

            Dim CalificadorDescuentoCargo1 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo1)
            Dim CalificadorDescuentoCargo2 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo2)
            Dim CalificadorDescuentoCargo3 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo3)
            Dim CalificadorDescuentoCargo4 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo4)

            Dim TipoDescuentoCargo1 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo1)
            Dim TipoDescuentoCargo2 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo2)
            Dim TipoDescuentoCargo3 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo3)
            Dim TipoDescuentoCargo4 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo4)

            Dim TipoArticulo As String = Tipos_Articulo_EDICOM(Me.TipoArticulo)


            '                                                                                                                       POS             LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))                   'Número factura                             1               15
            str.Append(PadNumeroSigno(NumeroLinea, 5, True))                            'Número de línea                            16              5
            str.Append(PadTexto(ReferenciaEAN, 17))                                     'Referencia EAN del artículo                21              17
            str.Append(PadTexto(ReferenciaCliente, 35))                                 'Referencia artículo (cliente)              38              35
            str.Append(PadTexto(ReferenciaProveedor, 35))                               'Referencia artículo (proveedor)            73              35
            str.Append(PadVacio(2))                                                     'Variable promocional                       108             2
            str.Append(PadVacio(14))                                                    'Código DUN14                               110             14
            str.Append(PadTexto(Descripcion, 70))                                       'Descripción artículo                       124             70
            str.Append(PadImporteSigno(Cantidad, 15, 3, True))                          'Cantidad facturada                         194             15
            'str.Append(PadVacio(10))                                                   'Cantidad entregada (unidades)              209             10
            str.Append(PadNumeroSigno(CantidadEntregada, 10, False))                    'Cantidad entregada (unidades)              209             10
            str.Append(PadTexto(UMedida, 3))                                            'Unidad de medida                           219             3
            str.Append(PadImporteSigno(PrecioBruto, 15, 3, True))                       'Precio bruto                               222             15
            str.Append(PadImporteSigno(PrecioNeto, 15, 3, True))                        'Precio neto                                237             15
            str.Append(PadTexto(TipoImpuesto1, 3))                                      'Tipo impuesto 1                            252             3
            str.Append(PadImporteSigno(PorcentajeImpuesto1, 8, 3, True))                'Porcentaje impuesto 1                      255             8
            str.Append(PadImporteSigno(ImporteImpuesto1, 15, 3, True))                  'Importe impuesto 1                         263             15
            str.Append(PadTexto(TipoImpuesto2, 3))                                      'Tipo impuesto 2                            278             3
            str.Append(PadImporteSigno(PorcentajeImpuesto2, 8, 3, False))               'Porcentaje impuesto 2                      281             8
            str.Append(PadImporteSigno(ImporteImpuesto2, 15, 3, False))                 'Importe impuesto 2                         289             15
            str.Append(PadTexto(TipoImpuesto3, 3))                                      'Tipo impuesto 3                            304             3
            str.Append(PadImporteSigno(PorcentajeImpuesto3, 8, 3, False))               'Porcentaje impuesto 3                      307             8       
            str.Append(PadImporteSigno(ImporteImpuesto3, 15, 3, False))                 'Importe impuesto 3                         315             15
            str.Append(PadTexto(CalificadorDescuentoCargo1, 3))                         'Calificador dto/cargo 1                    330             3
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo1, 2, False))              'Secuencia dto/cargo 1                      333             2   
            str.Append(PadTexto(TipoDescuentoCargo1, 3))                                'Tipo de dto/cargo 1                        335             3
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo1, 8, 3, False))         'Porcentaje dto/cargo 1                     338             8
            str.Append(PadImporteSigno(ImporteDescuentoCargo1, 15, 3, False))           'Importe dto/cargo 1                        346             15
            str.Append(PadTexto(CalificadorDescuentoCargo2, 3))                         'Calificador dto/cargo 2                    361             3
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo2, 2, False))              'Secuencia dto/cargo 2                      364             2
            str.Append(PadTexto(TipoDescuentoCargo2, 3))                                'Tipo de dto/cargo 2                        366             3
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo2, 8, 3, False))         'Porcentaje dto/cargo 2                     369             8
            str.Append(PadImporteSigno(ImporteDescuentoCargo2, 15, 3, False))           'Importe dto/cargo 2                        377             15
            str.Append(PadTexto(CalificadorDescuentoCargo3, 3))                         'Calificador dto/cargo 3                    392             3
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo3, 2, False))              'Secuencia dto/cargo 3                      395             2
            str.Append(PadTexto(TipoDescuentoCargo3, 3))                                'Tipo de dto/cargo 3                        397             3
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo3, 8, 3, False))         'Porcentaje dto/cargo 3                     400             8
            str.Append(PadImporteSigno(ImporteDescuentoCargo3, 15, 3, False))           'Importe dto/cargo 3                        408             15
            str.Append(PadTexto(CalificadorDescuentoCargo4, 3))                         'Calificador dto/cargo 4                    423             3
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo4, 2, False))              'Secuencia dto/cargo 4                      426             2
            str.Append(PadTexto(TipoDescuentoCargo4, 3))                                'Tipo de dto/cargo 4                        428             3
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo4, 8, 3, False))         'Porcentaje dto/cargo 4                     431             8
            str.Append(PadImporteSigno(ImporteDescuentoCargo4, 15, 3, False))           'Importe dto/cargo 4                        439             15
            str.Append(PadVacio(15))                                                    'Cantidad bonificada                        454             15
            str.Append(PadImporteSigno(ImporteNeto, 15, 3, True))                       'Importe neto línea                         469             15
            str.Append(PadVacio(15))                                                    'Importe punto verde línea                  484             15
            str.Append(PadTexto(Pedido, 17))                                            'Nº Pedido                                  499             17
            str.Append(PadVacio(17))                                                    'Nº Albarán                                 516             17
            str.Append(PadVacio(17))                                                    'Lote                                       533             17
            str.Append(PadVacio(12))                                                    'Fecha de carga                             550             12
            str.Append(PadVacio(12))                                                    'Fecha de entrega                           562             12
            str.Append(PadVacio(17))                                                    'Matrícula                                  574             17
            str.Append(PadTexto(TipoArticulo, 3))                                       'Tipo de artículo                           591             3
            str.Append(PadVacio(15))                                                    'Cantidad devolución                        594             15
            str.Append(PadVacio(17))                                                    'Número de sección                          609             17
            str.Append(PadVacio(17))                                                    'Número de identicket                       626             17
            str.Append(PadImporteSigno(ImporteBruto, 15, 3, False))                     'Importe bruto                              643             15
            str.Append(PadVacio(12))                                                    'Fecha del albarán                          658             12
            str.Append(PadVacio(35))                                                    'Autor obra facturada                       670             35
            str.Append(PadVacio(35))                                                    'Título obra facturada                      705             35
            str.Append(PadVacio(15))                                                    'Nº unidades consumo por unidad fact.       740             15
            str.Append(PadVacio(3))                                                     'Unidad medida campo anterior               755             3
            str.Append(PadVacio(12))                                                    'Fecha efectiva del servicio                758             12
            str.Append(PadVacio(35))                                                    'Categoría neumático                        770             35
            str.Append(PadVacio(3))                                                     'Indicación de sublínea                     805             3
            str.Append(PadVacio(35))                                                    'Normativa exención IVA 1                   808             35
            str.Append(PadVacio(35))                                                    'Normativa exención IVA 2                   843             35
            str.Append(PadVacio(35))                                                    'Normativa exención IVA 3                   878             35
            str.Append(PadVacio(17))                                                    'Tipo embalaje                              913             17
            str.Append(PadVacio(35))                                                    'Número línea pedido                        930             35
            str.Append(PadVacio(35))                                                    'Grupo producto (comprador)                 965             35
            str.Append(PadVacio(35))                                                    'Nº pedido y pos. producto interno          1000            35
            str.Append(PadVacio(12))                                                    'Fecha pedido                               1035            12
            str.Append(PadVacio(9))                                                     'Calificador de precio                      1047            9
            str.Append(PadVacio(3))                                                     'Unidad medida de precio neto               1056            3
            str.Append(PadVacio(3))                                                     'Categoría arancel, impuesto cod.           1059            3
            str.Append(PadVacio(35))                                                    'Modelo                                     1062            35
            str.Append(PadVacio(35))                                                    'Color                                      1097            35
            str.Append(PadVacio(18))                                                    'Importe Rappel                             1132            18
            str.Append(PadVacio(15))                                                    'Precio neto según distribuidor             1150            15
            str.Append(PadVacio(18))                                                    'Peso artículo                              1165            18
            str.Append(PadVacio(3))                                                     'Unidad peso artículo                       1183            3
            str.Append(PadVacio(35))                                                    'Carta de porte                             1186            35
            str.Append(PadVacio(5))                                                     'Nº línea dependencia de sublínea           1221            5



            Return str.ToString

        End Function


    End Class


End Namespace

