
Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI
Imports NetAgro.EDICOM.Comun



Namespace EDICOM

    Public Class EDICOM_DesgloseLineasPedido
        Inherits MensajeRecibidoEDI


        Public ClavePedido As String = ""
        Public NumeroLinea As Integer = 0
        Public NumeroLocalizacion As Integer = 0
        Public Lugar As String = ""
        Public Cantidad As Decimal = 0
        Public FechaEntregaSolicitada As DateTime = VaDate("")
        


        Public Sub New(linea As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Desglose_linea_pedido, linea)


            If linea.Length >= 169 Then

                Me.ClavePedido = _linea.Substring(0, 8).Trim
                Me.NumeroLinea = VaInt(_linea.Substring(8, 5).Trim)
                Me.NumeroLocalizacion = VaInt(_linea.Substring(13, 5))
                Me.Lugar = _linea.Substring(18, 17).Trim
                Me.Cantidad = TraducirImporte_EDICOM(_linea.Substring(35, 15), 3)
                Me.FechaEntregaSolicitada = TraducirFecha_EDICOM(_linea.Substring(50, 12).Trim)


            End If


        End Sub


    End Class


End Namespace

