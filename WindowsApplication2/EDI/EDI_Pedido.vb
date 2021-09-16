
Namespace EDI


    Public Class EDI_Pedido

        Public Cabecera As EDI_CabeceraPedido
        Public Lineas As New List(Of EDI_LineaPedido)

        Public Formato As String = ""


        'Clave de pedido
        Public Property ClavePedido As String
            Get
                Return Cabecera.ClavePedido
            End Get
            Set(value As String)
                Cabecera.ClavePedido = value
            End Set
        End Property


        'Número de pedido
        Public Property NumeroPedido As String
            Get
                Return Cabecera.NumeroPedido
            End Get
            Set(value As String)
                Cabecera.NumeroPedido = value
            End Set
        End Property


        'Fecha pedido
        Public Property FechaPedido As DateTime
            Get
                Return VaDate(Cabecera.FechaPedido)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaPedido = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaPedido = "00000000"
                End If
            End Set
        End Property


        Public Property Departamento As String
            Get
                Return CType(Cabecera, EDI_CabeceraPedido).Departamento
            End Get
            Set(value As String)
                CType(Cabecera, EDI_CabeceraPedido).Departamento = value
            End Set
        End Property


        'Numero de bultos del pedido
        Public Property Bultos As Decimal
            Get
                Return Cabecera.Bultos
            End Get
            Set(value As Decimal)
                Cabecera.Bultos = value
            End Set
        End Property


        'Cliente (a quién se factura)
        'Public Property Cliente As String
        '    Get
        '        Return Cabecera.Cliente
        '    End Get
        '    Set(value As String)
        '        Cabecera.Cliente = value
        '    End Set
        'End Property


        Public Property Emisor As String
            Get
                Return Cabecera.Emisor
            End Get
            Set(value As String)
                Cabecera.Emisor = value
            End Set
        End Property


        Public Property Comprador As String
            Get
                Return Cabecera.Comprador
            End Get
            Set(value As String)
                Cabecera.Comprador = value
            End Set
        End Property


        Public Property Receptor As String
            Get
                Return Cabecera.Receptor
            End Get
            Set(value As String)
                Cabecera.Receptor = value
            End Set
        End Property


        Public Property Vendedor As String
            Get
                Return Cabecera.Vendedor
            End Get
            Set(value As String)
                Cabecera.Vendedor = value
            End Set
        End Property


        Public Property Pagador As String
            Get
                Return Cabecera.Pagador
            End Get
            Set(value As String)
                Cabecera.Pagador = value
            End Set
        End Property


        'Codigo moneda
        Public Property CodigoMoneda As String
            Get
                Return Cabecera.CodigoMoneda
            End Get
            Set(value As String)
                Cabecera.CodigoMoneda = value
            End Set
        End Property


        Public Property PrimeraFechaEntrega As DateTime
            Get
                Return VaDate(Cabecera.PrimeraFechaEntrega)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.PrimeraFechaEntrega = value.ToString("dd/MM/yyyy")
                Else
                    Cabecera.PrimeraFechaEntrega = "00000000"
                End If
            End Set
        End Property


        'Fecha de entrega requerida del pedido
        Public Property FechaEntregaRequerida As DateTime
            Get
                Return VaDate(Cabecera.FechaEntregaRequerida)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaEntregaRequerida = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaEntregaRequerida = "00000000"
                End If
            End Set
        End Property


        'Fecha topo entrega del pedido
        Public Property FechaTopeEntrega As DateTime
            Get
                Return VaDate(Cabecera.FechaTopeEntrega)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaTopeEntrega = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaTopeEntrega = "00000000"
                End If
            End Set
        End Property


        Public Property NumeroPedidoEmisor
            Get
                Return Cabecera.NumeroPedidoEmisor
            End Get
            Set(value)
                Cabecera.NumeroPedidoEmisor = value
            End Set
        End Property
        

        Public Sub New()


        End Sub


    End Class


End Namespace


