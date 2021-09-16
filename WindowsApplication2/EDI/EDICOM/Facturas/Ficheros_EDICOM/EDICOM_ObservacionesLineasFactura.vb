
Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI



Namespace EDICOM

    Public Class EDICOM_ObservacionesLineasFactura
        Inherits EDI.RegistroEDI


        Private NumeroFactura As String = ""
        Private NumeroLineaFactura As Integer = 0
        Private NumeroLineaObservacion As Integer = 0
        Private Tema As String = "AAI"       'Información general
        Private Texto1 As String = ""
        Private Texto2 As String = ""
        Private Texto3 As String = ""
        Private Texto4 As String = ""
        Private Texto5 As String = ""



        Public Sub New(ByVal NumeroFactura As String, ByVal NumeroLineaFactura As Integer, ByVal NumeroLineaObservacion As Integer,
                       ByVal obs1 As String, ByVal obs2 As String, ByVal obs3 As String, ByVal obs4 As String, ByVal obs5 As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Observaciones_linea_detalle)

            Me.NumeroFactura = NumeroFactura
            Me.NumeroLineaFactura = NumeroLineaFactura
            Me.NumeroLineaObservacion = NumeroLineaObservacion
            Texto1 = obs1
            Texto2 = obs2
            Texto3 = obs3
            Texto4 = obs4
            Texto5 = obs5


        End Sub



        Public Overrides Function linea() As String


            '                                                                                                           POS     LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))               'Número de factura                  1       (15)
            str.Append(PadNumeroSigno(NumeroLineaFactura, 5, True))                 'Número de línea de observación     16      (5)
            str.Append(PadNumeroSigno(NumeroLineaObservacion, 3, True))             'Número de línea de observación     21      (3)
            str.Append(PadTexto(Me.Tema, 3))                                        'Tema del texto                     24      (3)
            str.Append(PadTexto(Me.Texto1, 70))                                     'Texto1                             27      (70)
            str.Append(PadTexto(Me.Texto2, 70))                                     'Texto2                             97      (70)
            str.Append(PadTexto(Me.Texto3, 70))                                     'Texto3                             167     (70)
            str.Append(PadTexto(Me.Texto4, 70))                                     'Texto4                             237     (70)
            str.Append(PadTexto(Me.Texto5, 70))                                     'Texto5                             307     (70)



            Return str.ToString

        End Function


    End Class


End Namespace

