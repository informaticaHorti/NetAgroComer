Imports System.Text
Imports NetAgro.EDICOM
Imports NetAgro.EDICOM.Comun

Namespace EDICOM


    Public Class EDICOM_Factura
        Inherits EDI.EDI_Factura


        Public Fichero_ObservacionesGlobales As EDICOM_ObservacionesGlobalesFactura
        Public DescuentosCargosFactura As New List(Of EDICOM_DescuentosYCargosGlobalesFactura)
        Public ImpuestosFactura As New List(Of EDICOM_DesgloseImpuestosFactura)
        'Public Fichero_ObservacionesLineas As EDICOM_ObservacionesLineasFactura



        'Vendedor
        Public Property EDI_Vendedor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Vendedor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Vendedor = value
            End Set
        End Property

        'Emisor
        Public Property EDI_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Emisor = value
            End Set
        End Property

        'Cobrador
        Public Property EDI_Cobrador As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Cobrador
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Cobrador = value
            End Set
        End Property

        'Comprador
        Public Property EDI_Comprador As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Comprador
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Comprador = value
            End Set
        End Property

        'Departamento
        Public Property DepartamentoPedido As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Departamento
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Departamento = value
            End Set
        End Property

        'Receptor
        Public Property EDI_Receptor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Receptor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Receptor = value
            End Set
        End Property

        'Cliente
        Public Property EDI_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Cliente = value
            End Set
        End Property

        'Pagador
        Public Property EDI_Pagador As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Pagador
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Pagador = value
            End Set
        End Property

        'Tipo de factura
        Public Property TipoFactura As Comun.NombreDocumento_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Nodo
            End Get
            Set(value As Comun.NombreDocumento_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Nodo = value
            End Set
        End Property


        'Función del documento
        Public Property FuncionDocumento As Comun.FuncionDocumento_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Funcion
            End Get
            Set(value As Comun.FuncionDocumento_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Funcion = value
            End Set
        End Property


        'Razón social cliente
        Public Property RazonSocial_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).RazonSocial_Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).RazonSocial_Cliente = value
            End Set
        End Property

        'Razón social cliente
        Public Property Domicilio_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Domicilio_Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Domicilio_Cliente = value
            End Set
        End Property

        'Poblacion cliente
        Public Property Poblacion_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Poblacion_Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Poblacion_Cliente = value
            End Set
        End Property

        'CodPostal cliente
        Public Property CodPostal_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CodPostal_Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CodPostal_Cliente = value
            End Set
        End Property

        'NIF cliente
        Public Property NIF_Cliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_Cliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_Cliente = value
            End Set
        End Property

        'Razón de cargo o abono
        Public Property RazonCargoAbono As Comun.Razon_Cargo_Abono_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Razon
            End Get
            Set(value As Comun.Razon_Cargo_Abono_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Razon = value
            End Set
        End Property


        Public Property Pedido As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Pedido
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Pedido = value
            End Set
        End Property

        Public Property Albaran As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Albaran
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Albaran = value
            End Set
        End Property


        'Bases
        Public Property BaseImponible1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base1 = value
            End Set
        End Property

        Public Property BaseImponible2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base2 = value
            End Set
        End Property

        Public Property BaseImponible3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base3 = value
            End Set
        End Property

        Public Property BaseImponible4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base4 = value
            End Set
        End Property

        Public Property BaseImponible5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base5 = value
            End Set
        End Property

        Public Property BaseImponible6 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Base6
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Base6 = value
            End Set
        End Property


        'Tipoimpuestos
        Public Property TipoImpuesto1 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto1
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto1 = value
            End Set
        End Property

        Public Property TipoImpuesto2 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto2
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto2 = value
            End Set
        End Property

        Public Property TipoImpuesto3 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto3
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto3 = value
            End Set
        End Property

        Public Property TipoImpuesto4 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto4
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto4 = value
            End Set
        End Property

        Public Property TipoImpuesto5 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto5
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto5 = value
            End Set
        End Property

        Public Property TipoImpuesto6 As Comun.TipoImpuesto_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto6
            End Get
            Set(value As Comun.TipoImpuesto_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoImpuesto6 = value
            End Set
        End Property


        'Porcentajes impuestos
        Public Property TasaImpuesto1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto1 = value
            End Set
        End Property

        Public Property TasaImpuesto2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto2 = value
            End Set
        End Property

        Public Property TasaImpuesto3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto3 = value
            End Set
        End Property

        Public Property TasaImpuesto4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto4 = value
            End Set
        End Property

        Public Property TasaImpuesto5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto5 = value
            End Set
        End Property

        Public Property TasaImpuesto6 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto6
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TasaImpuesto6 = value
            End Set
        End Property


        'Importes impuestos
        Public Property ImporteImpuesto1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto1 = value
            End Set
        End Property

        Public Property ImporteImpuesto2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto2 = value
            End Set
        End Property

        Public Property ImporteImpuesto3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto3 = value
            End Set
        End Property

        Public Property ImporteImpuesto4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto4 = value
            End Set
        End Property

        Public Property ImporteImpuesto5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto5 = value
            End Set
        End Property

        Public Property ImporteImpuesto6 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto6
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteImpuesto6 = value
            End Set
        End Property

        'Fecha vencimiento único
        Public Overloads Property FechaVencimiento As DateTime
            Get
                Return VaDate(Cabecera.FechaVencimientoUnico)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaVencimientoUnico = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaVencimientoUnico = "        "
                End If
            End Set
        End Property


        'Importe vencimiento único
        Public Property ImporteVencimientoUnico As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteVencimientoUnico
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteVencimientoUnico = value
            End Set
        End Property



        'Descuentos en factura
        Public Property CalificadorDescuentoCargo1 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo1
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo1 = value
            End Set
        End Property
        Public Property CalificadorDescuentoCargo2 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo2
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo2 = value
            End Set
        End Property
        Public Property CalificadorDescuentoCargo3 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo3
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo3 = value
            End Set
        End Property
        Public Property CalificadorDescuentoCargo4 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo4
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo4 = value
            End Set
        End Property
        Public Property CalificadorDescuentoCargo5 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo5
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CalificadorDescuentoCargo5 = value
            End Set
        End Property

        Public Property SecuenciaDescuentoCargo1 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo1
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo1 = value
            End Set
        End Property
        Public Property SecuenciaDescuentoCargo2 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo2
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo2 = value
            End Set
        End Property
        Public Property SecuenciaDescuentoCargo3 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo3
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo3 = value
            End Set
        End Property
        Public Property SecuenciaDescuentoCargo4 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo4
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo4 = value
            End Set
        End Property
        Public Property SecuenciaDescuentoCargo5 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo5
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).SecuenciaDescuentoCargo5 = value
            End Set
        End Property

        Public Property TipoDescuentoCargo1 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo1
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo1 = value
            End Set
        End Property
        Public Property TipoDescuentoCargo2 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo2
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo2 = value
            End Set
        End Property
        Public Property TipoDescuentoCargo3 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo3
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo3 = value
            End Set
        End Property
        Public Property TipoDescuentoCargo4 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo4
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo4 = value
            End Set
        End Property
        Public Property TipoDescuentoCargo5 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo5
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).TipoDescuentoCargo5 = value
            End Set
        End Property

        Public Property PorcentajeDescuentoCargo1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo1 = value
            End Set
        End Property
        Public Property PorcentajeDescuentoCargo2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo2 = value
            End Set
        End Property
        Public Property PorcentajeDescuentoCargo3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo3 = value
            End Set
        End Property
        Public Property PorcentajeDescuentoCargo4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo4 = value
            End Set
        End Property
        Public Property PorcentajeDescuentoCargo5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).PorcentajeDescuentoCargo5 = value
            End Set
        End Property

        Public Property ImporteDescuentoCargo1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo1 = value
            End Set
        End Property
        Public Property ImporteDescuentoCargo2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo2 = value
            End Set
        End Property
        Public Property ImporteDescuentoCargo3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo3 = value
            End Set
        End Property
        Public Property ImporteDescuentoCargo4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo4 = value
            End Set
        End Property
        Public Property ImporteDescuentoCargo5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentoCargo5 = value
            End Set
        End Property


        'Razón social emisor
        Public Property RazonSocial_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).RazonSocial_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).RazonSocial_Emisor = value
            End Set
        End Property

        'Razón social Emisor
        Public Property Domicilio_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Domicilio_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Domicilio_Emisor = value
            End Set
        End Property

        'Poblacion Emisor
        Public Property Poblacion_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).Poblacion_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).Poblacion_Emisor = value
            End Set
        End Property

        'CodPostal Emisor
        Public Property CodPostal_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).CodPostal_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).CodPostal_Emisor = value
            End Set
        End Property

        'NIF Emisor
        Public Property NIF_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_Emisor = value
            End Set
        End Property

        'Registro mercantil emisor
        Public Property RegistroMercantil_Emisor As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).RegistroMercantil_Emisor
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).RegistroMercantil_Emisor = value
            End Set
        End Property

        'Fecha efectiva de entrega de mercancía o servicio
        Public Property FechaEfectivaServicio As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).FechaEfectivaServicio
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).FechaEfectivaServicio = value
            End Set
        End Property


        'Total descuentos
        Public Property TotalDescuentos As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentos
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).ImporteDescuentos = value
            End Set
        End Property


        'NIFs
        Public Property NIF_II As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_II
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_II = value
            End Set
        End Property
        Public Property NIF_PE As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_PE
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_PE = value
            End Set
        End Property
        Public Property NIF_IV As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_IV
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_IV = value
            End Set
        End Property
        Public Property NIF_PR As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_PR
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_PR = value
            End Set
        End Property
        Public Property NIF_SU As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_SU
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPieFactura).NIF_SU = value
            End Set
        End Property



        ''Total cargos
        'Public Property TotalCargos As Decimal
        '    Get
        '        Return CType(Cabecera, SERES_RegistroCabeceraFactura).TotalIncrementosImporteBruto
        '    End Get
        '    Set(value As Decimal)
        '        CType(Cabecera, SERES_RegistroCabeceraFactura).TotalIncrementosImporteBruto = value
        '    End Set
        'End Property



        Public Sub New()

            'Fichero_CabeceraYPieFactura = New EDICOM_CabeceraYPieFactura()
            Cabecera = New EDICOM_CabeceraYPieFactura

        End Sub


        Public Sub AñadeObservacionesGlobales(ObservacionesGlobales As EDICOM_ObservacionesGlobalesFactura)
            Me.Fichero_ObservacionesGlobales = ObservacionesGlobales
        End Sub

        Public Sub AñadeDescuentosYCargosGlobales(DescuentosYCargosGlobales As EDICOM_DescuentosYCargosGlobalesFactura)
            Me.DescuentosCargosFactura.Add(DescuentosYCargosGlobales)
        End Sub

        Public Sub AñadeLineasFactura(DetalleFactura As EDICOM_DetalleFactura)
            Me.Lineas.Add(DetalleFactura)
        End Sub

        Public Sub AñadeDesgloseImpuestos(DesgloseImpuestos As EDICOM_DesgloseImpuestosFactura)
            Me.ImpuestosFactura.Add(DesgloseImpuestos)
        End Sub



        'Public Function Resultado() As List(Of String)

        '    Dim lst As New List(Of String)


        '    lst.Add(RegistroControl.linea)
        '    lst.Add(Cabecera.linea)

        '    For Each parte As SERES_RegistroInformacionPartes In Partes
        '        lst.Add(parte.linea)
        '    Next

        '    For Each observacion As SERES_RegistroObservacionesCabeceraFactura In ObservacionesCabecera
        '        lst.Add(observacion.linea)
        '    Next

        '    For Each descuento_cargo As SERES_RegistroDescuentoCargoFactura In Descuentos
        '        lst.Add(descuento_cargo.linea)
        '    Next

        '    For Each linea_detalle As SERES_RegistroLineaDetalleFactura In Lineas
        '        lst.Add(linea_detalle.linea)
        '        For Each observacion_linea As SERES_RegistroObservacionesLineaFactura In linea_detalle.Observaciones
        '            lst.Add(observacion_linea.linea)
        '        Next
        '    Next
        '    For Each impuesto As SERES_RegistroImpuestosFactura In Impuestos
        '        lst.Add(impuesto.linea)
        '    Next


        '    Return lst

        'End Function


    End Class


End Namespace



