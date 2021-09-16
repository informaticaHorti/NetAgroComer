
Namespace EDI


    Public Class EDI_Factura

        Public Cabecera As EDI_CabeceraFactura
        Public Lineas As New List(Of EDI_LineaFactura)

        Public Formato As String = ""


        'Serie y número de factura
        Public Property Numero As String
            Get
                Return Cabecera.NumeroFactura
            End Get
            Set(value As String)
                Cabecera.NumeroFactura = value
            End Set
        End Property


        'Fecha factura
        Public Property FechaFactura As DateTime
            Get
                Return VaDate(Cabecera.FechaFactura)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaFactura = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaFactura = "00000000"
                End If
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


        'Importe neto factura
        Public Property ImporteNeto As Decimal
            Get
                Return Cabecera.ImporteNeto
            End Get
            Set(value As Decimal)
                Cabecera.ImporteNeto = value
            End Set
        End Property


        'Base imponible
        Public Property BaseImponible As Decimal
            Get
                Return Cabecera.BaseImponible
            End Get
            Set(value As Decimal)
                Cabecera.BaseImponible = value
            End Set
        End Property


        'Importe bruto
        Public Property ImporteBruto As Decimal
            Get
                Return Cabecera.ImporteBruto
            End Get
            Set(value As Decimal)
                Cabecera.ImporteBruto = value
            End Set
        End Property


        'Importe impuestos
        Public Property TotalImpuestos As Decimal
            Get
                Return Cabecera.TotalImpuestos
            End Get
            Set(value As Decimal)
                Cabecera.TotalImpuestos = value
            End Set
        End Property


        'Total factura 
        Public Property TotalFactura As Decimal
            Get
                Return Cabecera.TotalFactura
            End Get
            Set(value As Decimal)
                Cabecera.TotalFactura = value
            End Set
        End Property


        'Fecha vencimiento único
        Public Property FechaVencimiento As DateTime
            Get
                Return VaDate(Cabecera.FechaVencimientoUnico)
            End Get
            Set(value As DateTime)
                If value > VaDate("") Then
                    Cabecera.FechaVencimientoUnico = value.ToString("yyyyMMdd")
                Else
                    Cabecera.FechaVencimientoUnico = "00000000"
                End If
            End Set
        End Property


        Public Sub New()

        End Sub


    End Class


End Namespace


