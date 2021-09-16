Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI


Namespace EDICOM

    Public Class EDICOM_DescuentosYCargosGlobalesFactura
        Inherits EDI.RegistroEDI


        Public NumeroFactura As String = ""
        Public NumeroLinea As Integer = 0
        Public CalificadorDescuentoCargo As EDICOM.Comun.Calificador_Descuento_Cargo_EDICOM = Comun.Calificador_Descuento_Cargo_EDICOM.Vacio
        Public Secuencia As Integer = 0
        Public TipoDescuentoCargo As EDICOM.Comun.Tipo_Descuento_Cargo_EDICOM = Comun.Tipo_Descuento_Cargo_EDICOM.Vacio
        Public Porcentaje As Decimal = 0
        Public Importe As Decimal = 0
        Public TipoImpuesto As EDICOM.Comun.TipoImpuesto_EDICOM = Comun.TipoImpuesto_EDICOM.Vacio
        Public PorcentajeImpuesto As Decimal = 0
        Public ImporteImpuesto As Decimal = 0
        Public BaseImpuesto As Decimal = 0


        Public Sub New()
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Descuentos_y_cargos_cabecera)
        End Sub



        Public Overrides Function linea() As String

            Dim CalificadorDescuentoCargo As String = EDICOM.Comun.Calificadores_Descuento_Cargo_EDICOM(Me.CalificadorDescuentoCargo)
            Dim TipoDescuentoCargo As String = EDICOM.Comun.Tipos_Descuento_Cargo_EDICOM(Me.TipoDescuentoCargo)
            Dim TipoImpuesto As String = EDICOM.Comun.TiposImpuesto_EDICOM(Me.TipoImpuesto)


            '                                                                                                                   POS         LONGITUD
            Dim str As New StringBuilder(PadTexto(NumeroFactura, 15))       'Número de factura                                  1           15
            str.Append(PadNumeroSigno(NumeroLinea, 5, True))                'Número de descuento/cargo                          16          5
            str.Append(PadTexto(CalificadorDescuentoCargo, 3))              'Calificador dto/cargo: A=Descuento, C=Cargo        21          3
            str.Append(PadNumeroSigno(Secuencia, 2, False))                 'Secuencia de cálculo                               24          2
            str.Append(PadTexto(TipoDescuentoCargo, 3))                     'Tipo de dto/cargo                                  26          3
            str.Append(PadImporteSigno(Porcentaje, 8, 3, False))            'Porcentaje dto/cargo                               29          8
            str.Append(PadImporteSigno(Importe, 15, 3, False))              'Importe dto/cargo                                  37          15
            str.Append(PadTexto(TipoImpuesto, 3))                           'Tipo impuesto                                      52          3
            str.Append(PadImporteSigno(PorcentajeImpuesto, 8, 3, False))    'Porcentaje impuesto                                55          8
            str.Append(PadImporteSigno(ImporteImpuesto, 15, 3, False))      'Importe impuesto                                   63          15
            str.Append(PadImporteSigno(BaseImpuesto, 15, 3, False))         'Base imponible impuesto                            78          15
            


            Return str.ToString


        End Function


    End Class


End Namespace

