
Namespace EDI

    Public Class EDI_LineaPedido
        Inherits MensajeRecibidoEDI


        Public EAN_Articulo As String = ""
        Public DUN14 As String = ""
        Public Descripcion As String = ""
        Public Descripcion2 As String = ""
        Public Cantidad As Decimal = 0


        Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro, linea As String)
            MyBase.New(Proveedor, TipoRegistro, linea)
        End Sub



        Public Overrides Function linea() As String
            Return _linea
        End Function

    End Class

End Namespace
