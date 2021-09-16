Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI


Namespace EDICOM

    Public Class EDICOM_DesgloseImpuestosFactura
        Inherits EDI.RegistroEDI


        Public NumeroFactura As String = ""
        Public NumeroLinea As Integer = 0
        Public Base As Decimal = 0
        Public Tipo As EDICOM.Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Vacio
        Public Porcentaje As Decimal = 0
        Public Importe As Decimal = 0
        Public NormaExencion As String = ""
        Public CategoriaImpuesto As EDICOM.Comun.Categoria_Impuesto_EDICOM = Comun.Categoria_Impuesto_EDICOM.Vacio




        Public Sub New()
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Impuestos)

        End Sub



        Public Overrides Function linea() As String


            Dim Tipo As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.Tipo)
            Dim CategoriaImpuesto As String = EDICOM.Comun.Categorias_Impuesto_EDICOM(Me.CategoriaImpuesto)


            '                                                                                                                   POS         LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))               'Número de factura                          1           (15)
            str.Append(PadNumeroSigno(NumeroLinea, 5, True))                        'Número de descuento/cargo                  16          (5)
            str.Append(PadImporteSigno(Base, 15, 3, True))                          'Base imponible                             21          (15)
            str.Append(PadTexto(Tipo, 3))                                           'Tipo impuesto                              36          (3)
            str.Append(PadImporteSigno(Porcentaje, 8, 3, True))                     'Porcentaje                                 39          (8)
            str.Append(PadImporteSigno(Importe, 15, 3, True))                       'Importe                                    47          (15)
            str.Append(PadTexto(NormaExencion, 35))                                 'Norma exención                             62          (35)
            str.Append(PadTexto(CategoriaImpuesto, 3))                              'Categoria impuesto                         97          (3)




            Return str.ToString

        End Function


    End Class


End Namespace

