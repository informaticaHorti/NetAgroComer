
Namespace EDI


    Public MustInherit Class RegistroEDI


        Public ProveedorEDI As Comun.ProveedorEDI
        Public TipoRegistro As Comun.TipoRegistro



        Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro)

            Me.ProveedorEDI = Proveedor
            Me.TipoRegistro = TipoRegistro

        End Sub


        Public MustOverride Function linea() As String



    End Class


End Namespace

