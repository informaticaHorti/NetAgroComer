Imports System.Text

Imports NetAgro.EDI.Comun
Imports NetAgro.EDI
Imports NetAgro.EDICOM.Comun


Namespace EDICOM

    Public Class EDICOM_DetallePedido
        Inherits EDI.EDI_LineaPedido


        Public ObservacionesLinea As New List(Of EDICOM_ObservacionesLineasPedido)
        Public DesgloseLinea As New List(Of EDICOM_DesgloseLineasPedido)


        Public ClavePedido As String = ""
        Public NumeroLinea As Integer = 0

        Public VariablePromocional As String = ""
        Public RefCliente As String = ""
        Public RefProveedor As String = ""
        Public UMedida As Unidad_Medida_EDICOM = Unidad_Medida_EDICOM.Vacio

        Public FechaEntrega As String = ""

        Public RefAcicional As String = ""
        Public UltimoConsignatario As String = ""

        'Public Precioneto As Decimal = 0
        'Public PVP As Decimal = 0

        'Public Formato1 As Formato_Unidad_Expedicion_EDICOM = Formato_Unidad_Expedicion_EDICOM.Vacio
        'Public UnidadesExpedicion1 As Decimal = 0
        'Public Formato2 As Formato_Unidad_Expedicion_EDICOM = Formato_Unidad_Expedicion_EDICOM.Vacio
        'Public UnidadesExpedicion2 As Decimal = 0
        'Public Formato3 As Formato_Unidad_Expedicion_EDICOM = Formato_Unidad_Expedicion_EDICOM.Vacio
        'Public UnidadesExpedicion3 As Decimal = 0

        'Public DescripcionCodificada As String = ""






        Public Sub New(linea As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Linea_detalle_pedido, linea)


            If _linea.Length >= 1744 Then

                ClavePedido = _linea.Substring(0, 8).Trim                                          'CLAVE1
                NumeroLinea = VaInt(_linea.Substring(8, 5).Trim)                                    'CLAVE2
                EAN_Articulo = _linea.Substring(13, 17).Trim                                        'REFEAN

                VariablePromocional = _linea.Substring(44, 2).Trim                                  'VP
                RefCliente = _linea.Substring(46, 35).Trim                                          'REFCLI
                RefProveedor = _linea.Substring(81, 35)                                              'REFPROV


                Descripcion = _linea.Substring(151, 35).Trim                                        'DESCMER
                Descripcion2 = _linea.Substring(186, 35).Trim                                       'DESCMER2
                Cantidad = TraducirImporte_EDICOM(_linea.Substring(256, 15).Trim, 3)                'CANTPED

                Dim umedida As String = _linea.Substring(271, 3)                                    'UMEDIDA
                Dim indice As Integer = Array.IndexOf(Unidades_Medida_EDICOM, umedida) : If indice > -1 Then Me.UMedida = CType(indice, Unidad_Medida_EDICOM)

                Me.FechaEntrega = TraducirFecha_EDICOM(_linea.Substring(319, 12).Trim)              'FECHAE
                
                Me.RefAcicional = _linea.Substring(1744, 15).Trim                                   'REFADICIONAL
                Me.UltimoConsignatario = _linea.Substring(1759, 15)                                 'LINULTCONSIG

            End If


        End Sub



    End Class


End Namespace

