
Namespace EDI

    Public Class EDI_LineaFactura
        Inherits RegistroEDI





        Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro)
            MyBase.New(Proveedor, TipoRegistro)
        End Sub



        Public Overrides Function linea() As String
            Return ""
        End Function

    End Class

End Namespace
