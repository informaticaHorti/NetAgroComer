
Imports NetAgro.EDI.Comun
Imports NetAgro.EDI
Imports System.Text
Imports NetAgro.EDICOM.Comun


Namespace EDICOM

    Public Class EDICOM_ObservacionesGlobalesPedido
        Inherits MensajeRecibidoEDI


        Public ClavePedido As String = ""
        Public NumeroLinea As Integer = 0
        Public Tema As Tema_Observaciones_EDICOM = Tema_Observaciones_EDICOM.Vacio
        Public Texto1 As String = ""
        Public Texto2 As String = ""
        Public Texto3 As String = ""
        Public Texto4 As String = ""
        Public Texto5 As String = ""



        Public Sub New(ByVal linea As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Observaciones_cabecera_pedido, linea)

            If _linea.Length >= 366 Then

                Me.ClavePedido = _linea.Substring(0, 8).Trim
                Me.NumeroLinea = VaInt(_linea.Substring(8, 5).Trim)

                Dim TemaObvs As String = _linea.Substring(13, 3).Trim
                Dim indice As Integer = Array.IndexOf(Temas_Observaciones_EDICOM, TemaObvs) : If indice > -1 Then Me.Tema = CType(indice, Tema_Observaciones_EDICOM)

                Texto1 = _linea.Substring(16, 70).Trim
                Texto2 = _linea.Substring(86, 70).Trim
                Texto3 = _linea.Substring(156, 70).Trim
                Texto4 = _linea.Substring(226, 70).Trim
                Texto5 = _linea.Substring(296, 70).Trim

            End If

        End Sub


    End Class



End Namespace

