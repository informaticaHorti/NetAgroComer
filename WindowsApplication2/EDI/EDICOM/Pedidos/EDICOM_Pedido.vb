Imports System.Text
Imports NetAgro.EDICOM
Imports NetAgro.EDICOM.Comun

Namespace EDICOM


    Public Class EDICOM_Pedido
        Inherits EDI.EDI_Pedido


        Public ObservacionesGlobales As New List(Of EDICOM_ObservacionesGlobalesPedido)




        'Tipo mensaje (o función mensaje)
        Public Property TipoMensaje As Tipo_Mensaje_Pedido_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoMensaje
            End Get
            Set(value As Tipo_Mensaje_Pedido_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoMensaje = value
            End Set
        End Property


        Public Property Recogida As Codigo_Recogida_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).Recogida
            End Get
            Set(value As Codigo_Recogida_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).Recogida = value
            End Set
        End Property


        Public Property CalificadorDtoCargo1 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo1
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo1 = value
            End Set
        End Property


        Public Property SecuenciaCalculo1 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo1
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo1 = value
            End Set
        End Property


        Public Property TipoDtoCargo1 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo1
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo1 = value
            End Set
        End Property


        Public Property PorcentajeDtoCargo1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo1 = value
            End Set
        End Property


        Public Property ImporteDtoCargo1 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo1
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo1 = value
            End Set
        End Property


        Public Property CalificadorDtoCargo2 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo2
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo2 = value
            End Set
        End Property


        Public Property SecuenciaCalculo2 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo2
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo2 = value
            End Set
        End Property


        Public Property TipoDtoCargo2 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo2
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo2 = value
            End Set
        End Property


        Public Property PorcentajeDtoCargo2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo2 = value
            End Set
        End Property


        Public Property ImporteDtoCargo2 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo2
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo2 = value
            End Set
        End Property


        Public Property CalificadorDtoCargo3 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo3
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo3 = value
            End Set
        End Property


        Public Property SecuenciaCalculo3 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo3
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo3 = value
            End Set
        End Property


        Public Property TipoDtoCargo3 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo3
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo3 = value
            End Set
        End Property


        Public Property PorcentajeDtoCargo3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo3 = value
            End Set
        End Property


        Public Property ImporteDtoCargo3 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo3
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo3 = value
            End Set
        End Property


        Public Property CalificadorDtoCargo4 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo4
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo4 = value
            End Set
        End Property


        Public Property SecuenciaCalculo4 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo4
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo4 = value
            End Set
        End Property


        Public Property TipoDtoCargo4 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo4
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo4 = value
            End Set
        End Property


        Public Property PorcentajeDtoCargo4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo4 = value
            End Set
        End Property


        Public Property ImporteDtoCargo4 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo4
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo4 = value
            End Set
        End Property


        Public Property CalificadorDtoCargo5 As Calificador_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo5
            End Get
            Set(value As Calificador_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).CalificadorDtoCargo5 = value
            End Set
        End Property


        Public Property SecuenciaCalculo5 As Integer
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo5
            End Get
            Set(value As Integer)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).SecuenciaCalculo5 = value
            End Set
        End Property


        Public Property TipoDtoCargo5 As Tipo_Descuento_Cargo_EDICOM
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo5
            End Get
            Set(value As Tipo_Descuento_Cargo_EDICOM)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).TipoDtoCargo5 = value
            End Set
        End Property


        Public Property PorcentajeDtoCargo5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).PorcentajeDtoCargo5 = value
            End Set
        End Property


        Public Property ImporteDtoCargo5 As Decimal
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo5
            End Get
            Set(value As Decimal)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).ImporteDtoCargo5 = value
            End Set
        End Property


        Public Property Transportista As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).Transportista
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).Transportista = value
            End Set
        End Property


        Public Property AlmacenRecogida As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).AlmacenRecogida
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).AlmacenRecogida = value
            End Set
        End Property


        Public Property DestinoMensaje As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).DestinoMensaje
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).DestinoMensaje = value
            End Set
        End Property


        Public Property RefCliente As String
            Get
                Return CType(Cabecera, EDICOM_CabeceraYPiePedido).RefCliente
            End Get
            Set(value As String)
                CType(Cabecera, EDICOM_CabeceraYPiePedido).RefCliente = value
            End Set
        End Property


        


        Public Sub New(linea_cabecera As String)

            Cabecera = New EDICOM_CabeceraYPiePedido(linea_cabecera)

        End Sub


        Public Sub AñadeObservacionesGlobales(ObservacionesGlobales As EDICOM_ObservacionesGlobalesPedido)
            Me.ObservacionesGlobales.Add(ObservacionesGlobales)
        End Sub

        Public Sub AñadeLineasPedido(DetallePedido As EDICOM_DetallePedido)
            Me.Lineas.Add(DetallePedido)
        End Sub



    End Class


End Namespace



