
Namespace EDICOM


    Public Class Comun


        'CABECERA FACTURA
        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'Nodo
        Public Shared NombresDocumento_EDICOM As String() = {"", "380", "381", "383", "384", "385", "325", "389", "E8", "XX1", "130"}

        Public Enum NombreDocumento_EDICOM

            Vacio
            Factura_comercial
            Nota_de_abono
            Nota_de_cargo
            Factura_corregida
            Factura_recapitulativa
            Factura_proforma
            Autofactura
            Autofactura_negativa
            Rectificacion_autofactura_a_favor_proveedor
            Hojas_de_datos_facturacion

        End Enum


        'Funcion
        Public Shared FuncionesDocumento_EDICOM As String() = {"", "9", "31", "5", "7", "43"}

        Public Enum FuncionDocumento_EDICOM

            Vacio
            Original
            Copia
            Sustitutiva
            Duplicado
            Transmision_Adicional

        End Enum


        'Razon
        Public Shared Razones_Cargo_Abono_EDICOM As String() = {"", "1A", "2A", "3A"}

        Public Enum Razon_Cargo_Abono_EDICOM
            Vacio
            Devolucion_mercancias
            Rappel
            Diferencias
        End Enum


        'Tipos de impuestos
        Public Shared TiposImpuesto_EDICOM As String() = {"", "VAT", "ENV", "EXT", "IGI", "ACT", "RE", "RET", "OTH", "TA1", "TA2", "RPT", "EPH", "ERE", "ELB", "EVR", "TAA", "TAB", "TAC", "TAD", "TA4", "TA6"}

        Public Enum TipoImpuesto_EDICOM

            Vacio
            IVA
            Envases_y_residuos
            Exento
            IGIC
            Alhocoles
            Recargo_de_equivalencia
            Retenciones_servicios_profesionales
            Otros
            Reciclaje_harinas_carnicas
            Residuos_aparatos_electricos
            Derechos_autor
            EcoPilhas
            EcoREEE
            EcoLub
            EvoValor
            Reciclaje_Neumaticos_A
            Reciclaje_Neumaticos_B
            Reciclaje_Neumaticos_C
            Reciclaje_Neumaticos_D
            Reciclaje_Aceites
            Reciclarje_Pilas

        End Enum


        'Calificador descuento/cargo
        Public Shared Calificadores_Descuento_Cargo_EDICOM As String() = {"", "A", "C", "N"}

        Public Enum Calificador_Descuento_Cargo_EDICOM

            Vacio
            Descuento
            Cargo
            Informativo

        End Enum


        'Tipos de descuento/cargo
        Public Shared Tipos_Descuento_Cargo_EDICOM As String() = {"", "EAB", "TD", "FC", "PC", "SH", "IN", "CW", "RAD", "ABH", "ACQ", "FI", "IS", "CRA", "CRB", "CRC", "CRD", "CRS", "DI", "TX"}

        Public Enum Tipo_Descuento_Cargo_EDICOM

            Vacio
            Descuento_pronto_pago
            Descuento_comercial
            Cargo_por_fletes
            Cargo_embalajes
            Cargo_montajes
            Cargo_seguros
            Descuento_contenedor_o_envase_retornado
            Cargo_contenedor_o_envase_retornable
            Rappel
            Royalties
            Cargo_financiero
            Cargo_servicios_facturacion
            Ecotasa_neumaticos_A
            Ecotasa_neumaticos_B
            Ecotasa_neumaticos_C
            Ecotasa_neumaticos_D
            Ecotasa_aceite
            Descuento
            Contribucion_impuesta_por_autoridad

        End Enum


        'Categorías impuesto
        Public Shared Categorias_Impuesto_EDICOM As String() = {"", "E", "S", "Z"}

        Public Enum Categoria_Impuesto_EDICOM

            Vacio
            Exento
            Tarifa_reglamentaria
            Tarifa_cero

        End Enum


        'Unidades de medida
        Public Shared Unidades_Medida_EDICOM As String() = {"", "KGM", "LTR"}

        Public Enum Unidad_Medida_EDICOM

            Vacio
            Kilos
            Litros

        End Enum


        'Tipos de artículos
        Public Shared Tipos_Articulo_EDICOM As String() = {"", "M", "S", "C"}

        Public Enum Tipo_Articulo_EDICOM

            Vacio
            Mercancia
            Servicio
            Material_Consignado

        End Enum



        'PEDIDOS
        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        'Nodo
        Public Shared Tipos_Nodo_EDICOM As String() = {"", "220", "221", "224", "225", "227", "22E", "237", "402"}

        Public Enum Tipo_Nodo_EDICOM

            Vacio
            Order                           'Pedido normal
            Blanket_Order                   'Pedido abierto ?
            Rush_Order                      'Pedido urgente
            Repair_Order                    '??
            Consignment_Order               'Pedido en Consignacion
            Manufacturer_Raised_Order       'Propuesta de Pedido
            Cross_Docking_Services_Order
            Cross_Docking_Order


        End Enum



        'Funciones del mensaje
        Public Shared Tipos_Mensaje_Pedido_EDICOM As String() = {"", "5", "9"}

        Public Enum Tipo_Mensaje_Pedido_EDICOM

            Vacio
            Reemplazo
            Original

        End Enum


        'Códigos recogida mercancía
        Public Shared Codigos_Recogida_EDICOM As String() = {"", "4", "10E"}

        Public Enum Codigo_Recogida_EDICOM

            Vacio
            Recogida_por_el_Cliente
            Entregado_por_el_Proveedor

        End Enum


        'Temas de observaciones
        Public Shared Temas_Observaciones_EDICOM As String() = {"", "AAI", "INV", "DEL", "PUR"}

        Public Enum Tema_Observaciones_EDICOM

            Vacio
            Informacion_General
            Informacion_Facturacion
            Informacion_Entrega
            Informacion_Compra

        End Enum


        'Formatos de unidad de expedición
        Public Shared Formatos_Unidad_Expedicion_EDICOM As String() = {"", "08", "09", "200", "201", "202", "203", "204", "CS", "PK"}

        Public Enum Formato_Unidad_Expedicion_EDICOM

            Vacio
            Palet_sin_retorno
            Palet_retornable
            Palet_ISO_0_1_BARRA_2_EUROPALET 'Estandar 80x60
            Palet_ISO_1_1_BARRA_1_EUROPALET 'Estandar 80x120
            Palet_ISO_2                     'Estandar 100x120
            Palet_1_BARRA_4_EURO            'Estandar 60x40
            Palet_1_BARRA_8_EURO            'Estandar 40x30
            Caja
            Numero_bultos

        End Enum



        Public Shared Function TraducirFecha_EDICOM(ByVal Fecha As String) As DateTime

            Dim res As DateTime = VaDate("")


            If Fecha.Length >= 8 Then

                Dim año As String = Fecha.Substring(0, 4)
                Dim mes As String = Fecha.Substring(4, 2)
                Dim dia As String = Fecha.Substring(6, 2)

                res = VaDate(dia & "/" & mes & "/" & año)

            End If


            Return res

        End Function


        Public Shared Function TraducirImporte_EDICOM(ByVal Importe As String, Decimales As Integer) As Decimal

            Dim res As Decimal = 0

            If Importe.Length > Decimales Then

                Dim parte_decimal As String = Importe.Substring(Importe.Length - Decimales, Decimales)
                Dim parte_entera As String = Importe.Substring(0, Importe.Length - Decimales)

                res = VaDec(parte_entera) + (VaDec(parte_decimal) / (10 ^ Decimales))

            End If



            Return res

        End Function

    End Class


End Namespace

