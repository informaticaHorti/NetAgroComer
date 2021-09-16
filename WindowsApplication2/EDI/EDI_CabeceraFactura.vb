
Namespace EDI

    Public Class EDI_CabeceraFactura
        Inherits RegistroEDI


        'Campos comunes, naturales a la cabecera de la factura

        Public NumeroFactura As String = ""
        Public FechaFactura As String = ""
        Public CodigoMoneda As String = ""
        Public ImporteNeto As Decimal = 0
        Public BaseImponible As Decimal = 0
        Public ImporteBruto As Decimal = 0
        Public TotalImpuestos As Decimal = 0
        Public TotalFactura As Decimal = 0
        Public FechaVencimientoUnico As String = ""



        Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro)
            MyBase.New(Proveedor, TipoRegistro)

        End Sub


        Public Overrides Function linea() As String
            Return ""
        End Function


    End Class

End Namespace



