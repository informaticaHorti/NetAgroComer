Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI


Namespace EDICOM

    Public Class EDICOM_DescuentosYCargosLineasFactura
        Inherits EDI.RegistroEDI


        Public NumeroFactura As String = ""
        Public NumeroLineaFactura As Integer = 0
        Public NumeroLineaDescuentoCargo As Integer = 0
        Public CalificadorDescuentoCargo As EDICOM.Comun.Calificador_Descuento_Cargo_EDICOM = Comun.Calificador_Descuento_Cargo_EDICOM.Vacio
        Public Secuencia As Integer = 0
        Public TipoDescuentoCargo As EDICOM.Comun.Tipo_Descuento_Cargo_EDICOM = Comun.Tipo_Descuento_Cargo_EDICOM.Vacio
        Public Porcentaje As Decimal = 0
        Public Importe As Decimal = 0


        Public Sub New()
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Descuentos_y_cargos_linea_detalle)

        End Sub



        Public Overrides Function linea() As String


            Dim CalificadorDescuentoCargo As String = EDICOM.Comun.Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo)
            Dim TipoDescuentoCargo As String = EDICOM.Comun.Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo)


            '                                                                                                                   POS         LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))               'Número de factura                                  1           15
            str.Append(PadNumeroSigno(NumeroLineaFactura, 5, False))                'Número de línea de factura                         16          5
            str.Append(PadNumeroSigno(NumeroLineaDescuentoCargo, 5, False))         'Número de descuento/cargo                          21          5
            str.Append(PadTexto(CalificadorDescuentoCargo, 3))                      'Calificador dto/cargo: A=Descuento, C=Cargo        26          3
            str.Append(PadNumeroSigno(Secuencia, 2, False))                         'Secuencia de cálculo                               29          2
            str.Append(PadTexto(TipoDescuentoCargo, 3))                             'Tipo de dto/cargo                                  31          3
            str.Append(PadImporteSigno(Porcentaje, 8, 3, False))                    'Porcentaje dto/cargo                               34          8
            str.Append(PadImporteSigno(Importe, 15, 3, False))                      'Importe dto/cargo                                  42          15



            Return str.ToString

        End Function


    End Class


End Namespace

