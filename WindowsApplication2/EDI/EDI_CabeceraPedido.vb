
Namespace EDI

    Public Class EDI_CabeceraPedido
        Inherits MensajeRecibidoEDI


        'Campos comunes, naturales a la cabecera del pedido
        Public ClavePedido As String = ""
        Public NumeroPedido As String = ""
        Public FechaPedido As String = ""
        Public Departamento As String = ""
        Public PrimeraFechaEntrega As DateTime = VaDate("")
        Public FechaEntregaRequerida As DateTime = VaDate("")
        Public FechaTopeEntrega As DateTime = VaDate("")
        Public Cliente As String = ""

        Public Emisor As String = ""
        Public Comprador As String = ""
        Public Receptor As String = ""
        Public Vendedor As String = ""
        Public Pagador As String = ""
        Public CodigoMoneda As String = ""
        Public Bultos As Decimal = 0

        Public NumeroPedidoEmisor As String = ""



        Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro, linea As String)
            MyBase.New(Proveedor, TipoRegistro, linea)

        End Sub


        Public Overrides Function linea() As String
            Return _linea
        End Function


    End Class

End Namespace



