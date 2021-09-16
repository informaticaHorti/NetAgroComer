Imports NetAgro.EDI

Public Class MensajeRecibidoEDI
    Inherits EDI.RegistroEDI



    Protected _linea As String = ""
    Protected _funcionmensaje As EDI.Comun.FuncionMensaje = Comun.FuncionMensaje.Original

    Public ReadOnly Property FuncionMensaje As EDI.Comun.FuncionMensaje
        Get
            Return _funcionmensaje
        End Get
    End Property
        


    Public Sub New(Proveedor As Comun.ProveedorEDI, TipoRegistro As Comun.TipoRegistro, linea As String)
        MyBase.New(Proveedor, TipoRegistro)

        _linea = linea

    End Sub


    Public Overrides Function linea() As String
        Return _linea
    End Function

End Class
