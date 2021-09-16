Imports System.Text
Imports NetAgro.EDICOM.Comun


Namespace EDICOM


    Public Class EDICOM_CabeceraYPieFactura
        Inherits EDI.EDI_CabeceraFactura

        Public FormatoEDI As E_FormatosEDI.Formato

        Public Vendedor As String = ""
        Public Emisor As String = ""
        Public Cobrador As String = ""
        Public Comprador As String = ""
        Public Departamento As String = ""
        Public Receptor As String = ""
        Public Cliente As String = ""
        Public Pagador As String = ""

        Public Pedido As String = ""
        Public Nodo As NombreDocumento_EDICOM = NombreDocumento_EDICOM.Vacio
        Public Funcion As FuncionDocumento_EDICOM = FuncionDocumento_EDICOM.Vacio


        'Datos cliente
        Public RazonSocial_Cliente As String = ""
        Public Domicilio_Cliente As String = ""
        Public Poblacion_Cliente As String = ""
        Public CodPostal_Cliente As String = ""
        Public NIF_Cliente As String = ""


        Public Razon As Razon_Cargo_Abono_EDICOM = Razon_Cargo_Abono_EDICOM.Vacio
        Public Albaran As String = ""
        Private Contrato As String = ""
        Public NumeroFactura_Sustitutiva As String = ""
        Private FormaPago As String = ""


        Public ImporteCargos As Decimal = 0
        Public ImporteDescuentos As Decimal = 0


        'Totales Factura
        Public Base1 As Decimal = 0
        Public Base2 As Decimal = 0
        Public Base3 As Decimal = 0
        Public Base4 As Decimal = 0
        Public Base5 As Decimal = 0
        Public Base6 As Decimal = 0

        Public TipoImpuesto1 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public TipoImpuesto2 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public TipoImpuesto3 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public TipoImpuesto4 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public TipoImpuesto5 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio
        Public TipoImpuesto6 As TipoImpuesto_EDICOM = TipoImpuesto_EDICOM.Vacio

        Public TasaImpuesto1 As Decimal = 0
        Public TasaImpuesto2 As Decimal = 0
        Public TasaImpuesto3 As Decimal = 0
        Public TasaImpuesto4 As Decimal = 0
        Public TasaImpuesto5 As Decimal = 0
        Public TasaImpuesto6 As Decimal = 0

        Public ImporteImpuesto1 As Decimal = 0
        Public ImporteImpuesto2 As Decimal = 0
        Public ImporteImpuesto3 As Decimal = 0
        Public ImporteImpuesto4 As Decimal = 0
        Public ImporteImpuesto5 As Decimal = 0
        Public ImporteImpuesto6 As Decimal = 0


        'Descuentos y cargos en la cabecera de la factura
        Public CalificadorDescuentoCargo1 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public CalificadorDescuentoCargo2 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public CalificadorDescuentoCargo3 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public CalificadorDescuentoCargo4 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public CalificadorDescuentoCargo5 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio

        Public SecuenciaDescuentoCargo1 As Integer = 0
        Public SecuenciaDescuentoCargo2 As Integer = 0
        Public SecuenciaDescuentoCargo3 As Integer = 0
        Public SecuenciaDescuentoCargo4 As Integer = 0
        Public SecuenciaDescuentoCargo5 As Integer = 0

        Public TipoDescuentoCargo1 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public TipoDescuentoCargo2 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public TipoDescuentoCargo3 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public TipoDescuentoCargo4 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public TipoDescuentoCargo5 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio

        Public PorcentajeDescuentoCargo1 As Decimal = 0
        Public PorcentajeDescuentoCargo2 As Decimal = 0
        Public PorcentajeDescuentoCargo3 As Decimal = 0
        Public PorcentajeDescuentoCargo4 As Decimal = 0
        Public PorcentajeDescuentoCargo5 As Decimal = 0

        Public ImporteDescuentoCargo1 As Decimal = 0
        Public ImporteDescuentoCargo2 As Decimal = 0
        Public ImporteDescuentoCargo3 As Decimal = 0
        Public ImporteDescuentoCargo4 As Decimal = 0
        Public ImporteDescuentoCargo5 As Decimal = 0


        'Datos emisor
        Public RazonSocial_Emisor As String = ""
        Public Domicilio_Emisor As String = ""
        Public Poblacion_Emisor As String = ""
        Public CodPostal_Emisor As String = ""
        Public NIF_Emisor As String = ""
        Public RegistroMercantil_Emisor As String = ""


        'Recogida
        Public Recogida As String = ""
        Public Destino As String = ""
        Public FechaEfectivaServicio As String = ""


        Public NIF_II As String = ""            'Emisor de la factura
        Public NIF_PE As String = ""            'A quién se paga
        Public NIF_IV As String = ""            'Destinatario de la factura
        Public NIF_PR As String = ""            'Pagador de la factura
        Public NIF_SU As String = ""            'A quién se pidió la mercancía


        Public ImporteVencimientoUnico As Decimal = 0




        Public Sub New()
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Cabecera)
        End Sub




        Public Overrides Function linea() As String


            MyBase.CodigoMoneda = "EUR"


            Dim Nodo As String = EDICOM.Comun.NombresDocumento_EDICOM(Me.Nodo)
            Dim Funcion As String = EDICOM.Comun.FuncionesDocumento_EDICOM(Me.Funcion)
            Dim Razon As String = EDICOM.Comun.Razones_Cargo_Abono_EDICOM(Me.Razon)

            Dim TipoImpuesto1 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto1)
            Dim TipoImpuesto2 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto2)
            Dim TipoImpuesto3 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto3)
            Dim TipoImpuesto4 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto4)
            Dim TipoImpuesto5 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto5)
            Dim TipoImpuesto6 As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto6)

            Dim CalificadorDescuentoCargo1 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo1)
            Dim CalificadorDescuentoCargo2 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo2)
            Dim CalificadorDescuentoCargo3 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo3)
            Dim CalificadorDescuentoCargo4 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo4)
            Dim CalificadorDescuentoCargo5 As String = Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo5)

            Dim TipoDescuentoCargo1 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo1)
            Dim TipoDescuentoCargo2 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo2)
            Dim TipoDescuentoCargo3 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo3)
            Dim TipoDescuentoCargo4 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo4)
            Dim TipoDescuentoCargo5 As String = Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo5)



            '                                                                                                                       POS     LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))               'Número de factura"                             1           (15)
            str.Append(PadTexto(Vendedor, 17))                                      'Código EDI vendedor                            16          (17)
            str.Append(PadTexto(Emisor, 17))                                        'Código EDI emisor de la factura                33          (17)
            str.Append(PadTexto(Cobrador, 17))                                      'Código EDI de a quién se paga                  50          (17)
            str.Append(PadTexto(Comprador, 17))                                     'Código EDI de quién hace el pedido             67          (17)
            str.Append(PadTexto(Departamento, 13))                                  'Código EDI departamento que hace el pedido     84          (13)
            str.Append(PadTexto(Receptor, 17))                                      'Código EDI del receptor mercancía              97          (17)
            str.Append(PadTexto(Cliente, 17))                                       'Código EDI destinatario factura                114         (17)
            str.Append(PadTexto(Pagador, 17))                                       'Código EDI de quién paga                       131         (17)
            str.Append(PadTexto(Pedido, 17))                                        'Nº Pedido del destinatario                     148         (17)
            str.Append(PadTexto(FechaFactura, 12))                                  'Fecha factura YYYYMMDD                         165         (12)
            str.Append(PadTexto(Nodo, 3))                                           'Nombre documento(tipo de factura)              177         (3)
            str.Append(PadTexto(Funcion, 3))                                        'Función del documento                          180         (3)
            str.Append(PadTexto(RazonSocial_Cliente, 70))                           'Razón social del cliente                       183         (70)
            str.Append(PadTexto(Domicilio_Cliente, 35))                             'Dirección cliente                              253         (35)
            str.Append(PadTexto(Poblacion_Cliente, 35))                             'Población cliente                              288         (35)
            str.Append(PadTexto(CodPostal_Cliente, 5))                              'Código postal cliente                          323         (5)
            str.Append(PadTexto(NIF_Cliente, 17))                                   'NIF cliente                                    328         (17)
            str.Append(PadTexto(Razon, 3))                                          'Razón para cargo o abono                       345         (3)
            str.Append(PadTexto(Albaran, 17))                                       'Albarán de la factura                          348         (17)
            str.Append(PadTexto(Contrato, 17))                                      'Nº de contrato en facturas de servicios        365         (17)
            str.Append(PadTexto(NumeroFactura_Sustitutiva, 17))                     'Nº factura sustitutiva                         382         (17)
            str.Append(PadTexto(FormaPago, 3))                                      'Forma de pago                                  399         (3)
            str.Append(PadTexto(CodigoMoneda, 3))                                   'Divisa (EUR)                                   402         (3)
            str.Append(PadImporteSigno(ImporteBruto, 15, 3, False))                 'Sumatorio brutos                               405         (15)
            str.Append(PadImporteSigno(ImporteNeto, 15, 3, True))                   'Sumatorio netos                                420         (15)
            str.Append(PadImporteSigno(ImporteCargos, 15, 3, False))                'Sumatorio cargos                               435         (15)
            str.Append(PadImporteSigno(ImporteDescuentos, 15, 3, False))            'Sumatorio descuentos                           450         (15)
            str.Append(PadImporteSigno(Base1, 15, 3, False))                        'Base imponible 1                               465         (15)
            str.Append(PadTexto(TipoImpuesto1, 3))                                  'Tipo de impuesto 1                             480         (3)
            str.Append(PadImporteSigno(TasaImpuesto1, 8, 3, False))                 'Porcentaje de impuesto 1                       483         (8)
            str.Append(PadImporteSigno(ImporteImpuesto1, 15, 3, False))             'Importe impuesto 1                             491         (15)
            str.Append(PadImporteSigno(Base2, 15, 3, False))                        'Base imponible 2                               506         (15)
            str.Append(PadTexto(TipoImpuesto2, 3))                                  'Tipo de impuesto 2                             521         (3)
            str.Append(PadImporteSigno(TasaImpuesto2, 8, 3, False))                 'Porcentaje de impuesto 2                       524         (8)
            str.Append(PadImporteSigno(ImporteImpuesto2, 15, 3, False))             'Importe impuesto 2                             532         (15)
            str.Append(PadImporteSigno(Base3, 15, 3, False))                        'Base imponible 3                               547         (15)
            str.Append(PadTexto(TipoImpuesto3, 3))                                  'Tipo de impuesto 3                             532         (3)
            str.Append(PadImporteSigno(TasaImpuesto3, 8, 3, False))                 'Porcentaje de impuesto 3                       565         (8)
            str.Append(PadImporteSigno(ImporteImpuesto3, 15, 3, False))             'Importe impuesto 3                             573         (15)
            str.Append(PadImporteSigno(Base4, 15, 3, False))                        'Base imponible 4                               588         (15)
            str.Append(PadTexto(TipoImpuesto4, 3))                                  'Tipo de impuesto 4                             603         (3)
            str.Append(PadImporteSigno(TasaImpuesto4, 8, 3, False))                 'Porcentaje de impuesto 4                       606         (8)
            str.Append(PadImporteSigno(ImporteImpuesto4, 15, 3, False))             'Importe impuesto 4                             614         (15)
            str.Append(PadImporteSigno(Base5, 15, 3, False))                        'Base imponible 5                               629         (15)
            str.Append(PadTexto(TipoImpuesto5, 3))                                  'Tipo de impuesto 5                             644         (3)
            str.Append(PadImporteSigno(TasaImpuesto5, 8, 3, False))                 'Porcentaje de impuesto 5                       647         (8)
            str.Append(PadImporteSigno(ImporteImpuesto5, 15, 3, False))             'Importe impuesto 5                             655         (15)
            str.Append(PadImporteSigno(Base6, 15, 3, False))                        'Base imponible 6                               670         (15)
            str.Append(PadTexto(TipoImpuesto6, 3))                                  'Tipo de impuesto 6                             685         (3)
            str.Append(PadImporteSigno(TasaImpuesto6, 8, 3, False))                 'Porcentaje de impuesto 6                       688         (8)
            str.Append(PadImporteSigno(ImporteImpuesto6, 15, 3, False))             'Importe impuesto 6                             696         (15)
            str.Append(PadImporteSigno(BaseImponible, 15, 3, True))                 'Base imponible factura                         711         (15)
            str.Append(PadImporteSigno(TotalImpuestos, 15, 3, True))                'Total impuestos factura                        726         (15)
            str.Append(PadImporteSigno(TotalFactura, 15, 3, True))                  'Total factura                                  741         (15)
            If FormatoEDI = E_FormatosEDI.Formato.Alcampo Or FormatoEDI = E_FormatosEDI.Formato.DIA Then
                str.Append(PadTexto(FechaVencimientoUnico, 8))                      'Fecha primer vencimiento YYYYMMDD              756         (8)
                str.Append(PadImporteSigno(ImporteVencimientoUnico, 15, 3, True))  'Importe primer vencimiento                     764         (15)
            Else
                str.Append(PadVacio(8))                                             'Fecha primer vencimiento YYYYMMDD              756         (8)
                str.Append(PadVacio(15))                                            'Importe primer vencimiento                     764         (15)
            End If
            str.Append(PadVacio(8))                                                 'Fecha segundo vencimiento                      779         (8)
            str.Append(PadVacio(15))                                                'Importe segundo vencimiento                    787         (15)
            str.Append(PadVacio(8))                                                 'Fecha tercer vencimiento                       802         (8)
            str.Append(PadVacio(15))                                                'Importe tercer vencimiento                     810         (15)
            str.Append(PadVacio(15))                                                'Total punto verde                              825         (15)
            str.Append(PadTexto(CalificadorDescuentoCargo1, 3))                     'Calificador dto/cargo 1                        840         (3)
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo1, 2, False))          'Secuencia dto/cargo 1                          843         (2)
            str.Append(PadTexto(TipoDescuentoCargo1, 3))                            'Tipo dto/cargo 1                               845         (3)
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo1, 8, 3, False))     '% dto/cargo 1                                  848         (8)
            str.Append(PadImporteSigno(ImporteDescuentoCargo1, 15, 3, False))       'Importe dto/cargo 1                            856         (15)
            str.Append(PadTexto(CalificadorDescuentoCargo2, 3))                     'Calificador dto/cargo 2                        871         (3)
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo2, 2, False))          'Secuencia dto/cargo 2                          874         (2)
            str.Append(PadTexto(TipoDescuentoCargo2, 3))                            'Tipo dto/cargo 2                               876         (3)
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo2, 8, 3, False))     '% dto/cargo 2                                  879         (8)
            str.Append(PadImporteSigno(ImporteDescuentoCargo2, 15, 3, False))       'Importe dto/cargo 2                            887         (15)
            str.Append(PadTexto(CalificadorDescuentoCargo3, 3))                     'Calificador dto/cargo 3                        902         (3)
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo3, 2, False))          'Secuencia dto/cargo 3                          905         (2)
            str.Append(PadTexto(TipoDescuentoCargo3, 3))                            'Tipo dto/cargo 3                               907         (3)
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo3, 8, 3, False))     '% dto/cargo 3                                  910         (8)
            str.Append(PadImporteSigno(ImporteDescuentoCargo3, 15, 3, False))       'Importe dto/cargo 3                            918         (15)
            str.Append(PadTexto(CalificadorDescuentoCargo4, 3))                     'Calificador dto/cargo 4                        933         (3)
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo4, 2, False))          'Secuencia dto/cargo 4                          936         (2)
            str.Append(PadTexto(TipoDescuentoCargo4, 3))                            'Tipo dto/cargo 4                               938         (3)
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo4, 8, 3, False))     '% dto/cargo 4                                  941         (8)
            str.Append(PadImporteSigno(ImporteDescuentoCargo4, 15, 3, False))       'Importe dto/cargo 4                            949         (15)
            str.Append(PadTexto(CalificadorDescuentoCargo5, 3))                     'Calificador dto/cargo 5                        964         (3)
            str.Append(PadNumeroSigno(SecuenciaDescuentoCargo5, 2, False))          'Secuencia dto/cargo 5                          967         (2)
            str.Append(PadTexto(TipoDescuentoCargo5, 3))                            'Tipo dto/cargo 5                               969         (3)
            str.Append(PadImporteSigno(PorcentajeDescuentoCargo5, 8, 3, False))     '% dto/cargo 5                                  972         (8)
            str.Append(PadImporteSigno(ImporteDescuentoCargo5, 15, 3, False))       'Importe dto/cargo 5                            980         (15)
            str.Append(PadTexto(RazonSocial_Emisor, 70))                            'Razón social emisor                            995         (70)
            str.Append(PadTexto(Domicilio_Emisor, 35))                              'Domicilio emisor                               1065        (35)
            str.Append(PadTexto(Poblacion_Emisor, 35))                              'Población emisor                               1100        (35)
            str.Append(PadTexto(CodPostal_Emisor, 5))                               'Codigo postal emisor                           1135        (5)
            str.Append(PadTexto(NIF_Emisor, 17))                                    'NIF Emisor                                     1140        (17)
            str.Append(PadTexto(RegistroMercantil_Emisor, 70))                      'Registro mercantil emisor                      1157        (70)
            str.Append(PadVacio(17))                                                'Nota de cargo que se abona                     1227        (17)
            str.Append(PadVacio(17))                                                'Número de relación de entregas                 1244        (17)
            str.Append(PadVacio(17))                                                'Código EDI de recogida mercancías              1261        (17)
            str.Append(PadVacio(17))                                                'Código EDI destio mensaje                      1278        (17)
            str.Append(PadTexto(FechaEfectivaServicio, 12))                         'Fecha efectiva del servicio YYYYMMDD ?         1295        (12)
            str.Append(PadVacio(17))                                                'Nº confirmación recepción                      1307        (17)
            str.Append(PadVacio(17))                                                'Nº identicket                                  1324        (17)
            str.Append(PadVacio(35))                                                'Información de contacto                        1341        (35)
            str.Append(PadVacio(35))                                                'Teléfono de contacto                           1376        (35)
            str.Append(PadVacio(35))                                                'Fax de contacto                                1411        (35)
            str.Append(PadVacio(25))                                                'Código de proveedor                            1446        (25)
            str.Append(PadVacio(12))                                                'Fecha de albarán                               1471        (12)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA1                        1483        (35)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA2                        1518        (35)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA3                        1553        (35)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA4                        1588        (35)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA5                        1623        (35)
            str.Append(PadVacio(35))                                                'Directiva exencion IVA6                        1658        (35)
            str.Append(PadVacio(8))                                                 'Fecha documento                                1693        (8)
            str.Append(PadVacio(35))                                                'Referencia de pago                             1701        (35)
            str.Append(PadVacio(17))                                                'Emisor del mensaje                             1736        (17)
            str.Append(PadTexto(NIF_II, 17))                                        'NIFII - NIF empresa emisora de factura         1753        (17)
            str.Append(PadTexto(NIF_PE, 17))                                        'NIFPE - NIF empresa a la que se paga           1770        (17)
            str.Append(PadTexto(NIF_IV, 17))                                        'NIFIV - NIF empresa destinataria fra           1787        (17)
            str.Append(PadTexto(NIF_PR, 17))                                        'NIFPR - NIF pagador factura                    1804        (17)
            str.Append(PadTexto(NIF_SU, 17))                                        'NIFSU - NIF empresa a quien se pidió mercancia 1821        (17)
            str.Append(PadVacio(17))                                                'NUMMOVI - Nº documento movimiento              1838        (17)
            str.Append(PadVacio(17))                                                'NUMINCOR - Nº documento incorporado            1855        (17)
            str.Append(PadVacio(15))                                                'Importe del documento incorporado              1872        (15)
            str.Append(PadVacio(8))                                                 'Fecha entrada mercancía                        1887        (8)
            str.Append(PadVacio(8))                                                 'Fecha emisión del mensaje                      1895        (8)
            str.Append(PadVacio(35))                                                'Número completo mensaje                        1903        (35)
            str.Append(PadVacio(16))                                                'Período de facturación                         1938        (16)
            str.Append(PadVacio(12))                                                'Fecha pedido                                   1954        (12)
            str.Append(PadVacio(17))                                                'Código de aprobación factura                   1971        (17)
            str.Append(PadVacio(17))                                                'Número de devolución                           1988        (17)
            str.Append(PadVacio(12))                                                'Fecha número de devolución                     2000        (12)
            str.Append(PadVacio(17))                                                'Nº notificación de devolución                  2012        (17)
            str.Append(PadVacio(12))                                                'Fecha Nº notificación de devolución            2029        (12)
            str.Append(PadVacio(17))                                                'Código EDI sede social comprador               2041        (17)
            str.Append(PadVacio(35))                                                'Nombre del buque                               2058        (35)
            str.Append(PadVacio(12))                                                'Fecha de embarque                              2093        (12)
            str.Append(PadVacio(35))                                                'Forwarder                                      2105        (35)
            str.Append(PadVacio(70))                                                'Nombre del lugar receptor de la mercancía      2140        (70)
            str.Append(PadVacio(35))                                                'Dirección lugar receptor mercancía             2210        (35)
            str.Append(PadVacio(35))                                                'Ciudad lugar receptor mercancía                2245        (35)
            str.Append(PadVacio(17))                                                'Cod Postal lugar receptor mercancía            2280        (17)
            str.Append(PadVacio(3))                                                 'Agencia tributaria emisor                      2297        (3)
            str.Append(PadVacio(35))                                                'Capital social emisor                          2300        (35)
            str.Append(PadVacio(35))                                                'Id lugar carga mercancía                       2335        (35)
            str.Append(PadVacio(12))                                                'Fecha y hora carga mercancía                   2370        (12)
            str.Append(PadVacio(35))                                                'Id lugar carga mercancía                       2382        (35)
            str.Append(PadVacio(17))                                                'Matrícula transportista                        2417        (17)
            str.Append(PadVacio(12))                                                'Número vendedor (cliente)                      2434        (12)
            str.Append(PadVacio(35))                                                'Código postal del cliente extendido            2446        (35)
            str.Append(PadVacio(17))                                                'Código postal del emisor extendido             2481        (17)
            str.Append(PadVacio(17))                                                'Fecha factura sustituida                       2498        (17)
            str.Append(PadVacio(12))                                                'País emisor de factura                         2515        (12)
            str.Append(PadVacio(3))                                                 'Relación de tiempo codificado                  2527        (3)
            str.Append(PadVacio(3))                                                 'Relación de tiempo codificado                  2530        (3)
            str.Append(PadVacio(3))                                                 'Nº días en los que vence la factura            2533        (3)
            str.Append(PadVacio(8))                                                 'Porcentaje dto para vto factura                2536        (8)
            str.Append(PadVacio(3))                                                 'Tipo impuesto dto 1                            2544        (3)
            str.Append(PadVacio(8))                                                 '% impuesto dto 1                               2547        (8)
            str.Append(PadVacio(15))                                                'Importe impuesto dto 1                         2555        (15)
            str.Append(PadVacio(15))                                                'Base imponible impuesto dto 1                  2570        (15)
            str.Append(PadVacio(3))                                                 'Tipo impuesto dto 2                            2585        (3)
            str.Append(PadVacio(8))                                                 '% impuesto dto 2                               2588        (8)
            str.Append(PadVacio(15))                                                'Importe impuesto dto 2                         2596        (15)
            str.Append(PadVacio(15))                                                'Base imponible impuesto dto 2                  2611        (15)
            str.Append(PadVacio(3))                                                 'Tipo impuesto dto 3                            2626        (3)
            str.Append(PadVacio(8))                                                 '% impuesto dto 3                               2629        (8)
            str.Append(PadVacio(15))                                                'Importe impuesto dto 3                         2637        (15)
            str.Append(PadVacio(15))                                                'Base imponible impuesto dto 3                  2652        (15)
            str.Append(PadVacio(3))                                                 'Tipo impuesto dto 4                            2667        (3)
            str.Append(PadVacio(8))                                                 '% impuesto dto 4                               2670        (8)
            str.Append(PadVacio(15))                                                'Importe impuesto dto 4                         2678        (15)
            str.Append(PadVacio(15))                                                'Base imponible impuesto dto 4                  2693        (15)
            str.Append(PadVacio(3))                                                 'Tipo impuesto dto 5                            2708        (3)
            str.Append(PadVacio(8))                                                 '% impuesto dto 5                               2711        (8)
            str.Append(PadVacio(15))                                                'Importe impuesto dto 5                         2719        (15)
            str.Append(PadVacio(15))                                                'Base imponible impuesto dto 5                  2734        (15)
            str.Append(PadVacio(3))                                                 'País comprador                                 2749        (3)
            str.Append(PadVacio(1))                                                 'Regimen especial criterio caja                 2752        (1)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado        2753        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 1      2756        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 2      2759        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 3      2762        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 4      2765        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 5      2768        (3)
            str.Append(PadVacio(3))                                                 'Categoria arancel o impuesto codificado 6      2771        (3)
            str.Append(PadVacio(35))                                                'Nº autorización devolución                     2774        (35)
            str.Append(PadVacio(35))                                                'Nº pedido (vendedor)                           2809        (35)
            str.Append(PadVacio(12))                                                'Fecha cálculo impuestos                        2844        (12)



            Return str.ToString

        End Function

    End Class


End Namespace



