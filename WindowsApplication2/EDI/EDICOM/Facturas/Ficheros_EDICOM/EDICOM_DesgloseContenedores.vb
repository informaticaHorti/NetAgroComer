
Imports NetAgro.EDI.Comun
Imports NetAgro.EDI


Namespace EDICOM

    Public Class EDICOM_DesgloseContenedores
        Inherits EDI.RegistroEDI




        Public Sub New(Proveedor As EDI.Comun.ProveedorEDI, TipoRegistro As EDI.Comun.TipoRegistro)
            MyBase.New(Proveedor, TipoRegistro)

        End Sub



        Public Overrides Function linea() As String


            Return ""

        End Function


    End Class


End Namespace

