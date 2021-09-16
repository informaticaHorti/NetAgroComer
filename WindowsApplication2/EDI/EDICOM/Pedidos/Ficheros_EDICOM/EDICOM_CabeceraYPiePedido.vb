Imports System.Text
Imports NetAgro.EDICOM.Comun


Namespace EDICOM


    Public Class EDICOM_CabeceraYPiePedido
        Inherits EDI.EDI_CabeceraPedido

        Public FormatoEDI As E_FormatosEDI.Formato

        
        Public Nodo As Tipo_Nodo_EDICOM = Tipo_Nodo_EDICOM.Vacio
        Public TipoMensaje As Tipo_Mensaje_Pedido_EDICOM = Tipo_Mensaje_Pedido_EDICOM.Vacio

        
        Public Recogida As Codigo_Recogida_EDICOM = Codigo_Recogida_EDICOM.Vacio

        Public CalificadorDtoCargo1 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaCalculo1 As Integer = 1
        Public TipoDtoCargo1 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDtoCargo1 As Decimal = 0
        Public ImporteDtoCargo1 As Decimal = 0

        Public CalificadorDtoCargo2 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaCalculo2 As Integer = 1
        Public TipoDtoCargo2 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDtoCargo2 As Decimal = 0
        Public ImporteDtoCargo2 As Decimal = 0

        Public CalificadorDtoCargo3 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaCalculo3 As Integer = 1
        Public TipoDtoCargo3 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDtoCargo3 As Decimal = 0
        Public ImporteDtoCargo3 As Decimal = 0

        Public CalificadorDtoCargo4 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaCalculo4 As Integer = 1
        Public TipoDtoCargo4 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDtoCargo4 As Decimal = 0
        Public ImporteDtoCargo4 As Decimal = 0

        Public CalificadorDtoCargo5 As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
        Public SecuenciaCalculo5 As Integer = 1
        Public TipoDtoCargo5 As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
        Public PorcentajeDtoCargo5 As Decimal = 0
        Public ImporteDtoCargo5 As Decimal = 0


        Public Transportista As String = ""
        Public AlmacenRecogida As String = ""
        Public DestinoMensaje As String = ""
        Public RefCliente As String = ""

        Public TotalKilosBrutos As Decimal = 0
        Public NumPromo As String = ""
        Public Consignador As String = ""
        Public NumeroPedidoEmisor As String = ""




        Public Sub New(linea As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, EDI.Comun.TipoRegistro.Cabecera_pedido, linea)


            If _linea.Length >= 2419 Then


                Me.ClavePedido = _linea.Substring(0, 8).Trim                                                                            'CLAVE

                Dim nodo As String = _linea.Substring(8, 3)                                                                             'NODO
                Dim indice_nodo As Integer = Array.IndexOf(Tipos_Nodo_EDICOM, nodo) : If indice_nodo > -1 Then Me.Nodo = Tipos_Nodo_EDICOM(indice_nodo)

                Dim funcion As String = _linea.Substring(11, 3).Trim                                                                    'FUNCION
                Dim indice_function As Integer = Array.IndexOf(Tipos_Mensaje_Pedido_EDICOM, funcion)
                If indice_function > -1 Then
                    Me.TipoMensaje = Tipos_Mensaje_Pedido_EDICOM(indice_function)
                    _funcionmensaje = Tipos_Mensaje_Pedido_EDICOM(indice_function)
                End If

                Me.NumeroPedido = _linea.Substring(14, 15).Trim                                                                         'NUMPED
                Me.FechaPedido = TraducirFecha_EDICOM(_linea.Substring(29, 12).Trim)                                                    'FECHA

                Me.FechaEntregaRequerida = TraducirFecha_EDICOM(_linea.Substring(53, 12).Trim)                                          'FECHAERE

                Me.Comprador = _linea.Substring(163, 17).Trim                                                                           'COMPRADOR

                Me.Receptor = _linea.Substring(214, 17).Trim                                                                            'RECEPTOR
                Me.Vendedor = _linea.Substring(248, 17).Trim                                                                            'VENDEDOR

                Dim recogida As String = _linea.Substring(285, 3).Trim                                                                  'RECOGIDA
                Dim indice_recogida As Integer = Array.IndexOf(Codigos_Recogida_EDICOM, recogida) : If indice_recogida > -1 Then Me.Recogida = Codigos_Recogida_EDICOM(indice_recogida)

                Me.TotalKilosBrutos = TraducirImporte_EDICOM(_linea.Substring(1368, 15), 3)                                             'PESBRUTOT
                Me.NumPromo = _linea.Substring(1480, 35)                                                                                'NUMPROMO
                Me.Consignador = _linea.Substring(1752, 35)                                                                             'UCONSIGNADOR
                Me.RefCliente = _linea.Substring(2419, 15)                                                                              'NUMPEDEMISOR


            End If

        End Sub


        Private Sub AñadirDescuentoCargo(ByVal Orden As Integer, ByVal Calif As String, ByVal Secuen As String, ByVal Tipo As String, ByVal Porcen As String, ByVal Imp As String)


            Dim CalificadorDtoCargo As Calificador_Descuento_Cargo_EDICOM = Calificador_Descuento_Cargo_EDICOM.Vacio
            Dim Secuencia As Integer = VaInt(Secuen)
            Dim TipoDtoCargo As Tipo_Descuento_Cargo_EDICOM = Tipo_Descuento_Cargo_EDICOM.Vacio
            Dim Porcentaje As Decimal = TraducirImporte_EDICOM(Porcen, 3)
            Dim Importe As Decimal = TraducirImporte_EDICOM(Imp, 3)

            Dim indice As Integer = Array.IndexOf(Calificadores_Descuento_Cargo_EDICOM, Calif) : If indice > -1 Then CalificadorDtoCargo = CType(indice, Calificador_Descuento_Cargo_EDICOM)
            indice = Array.IndexOf(Tipos_Descuento_Cargo_EDICOM, Tipo) : If indice > -1 Then TipoDtoCargo = CType(indice, Tipo_Descuento_Cargo_EDICOM)

            Select Case Orden

                Case 1
                    Me.CalificadorDtoCargo1 = CalificadorDtoCargo
                    Me.SecuenciaCalculo1 = Secuencia
                    Me.TipoDtoCargo1 = TipoDtoCargo
                    Me.PorcentajeDtoCargo1 = Porcentaje
                    Me.ImporteDtoCargo1 = Importe

                Case 2
                    Me.CalificadorDtoCargo2 = CalificadorDtoCargo
                    Me.SecuenciaCalculo2 = Secuencia
                    Me.TipoDtoCargo2 = TipoDtoCargo
                    Me.PorcentajeDtoCargo2 = Porcentaje
                    Me.ImporteDtoCargo2 = Importe

                Case 3
                    Me.CalificadorDtoCargo3 = CalificadorDtoCargo
                    Me.SecuenciaCalculo3 = Secuencia
                    Me.TipoDtoCargo3 = TipoDtoCargo
                    Me.PorcentajeDtoCargo3 = Porcentaje
                    Me.ImporteDtoCargo3 = Importe

                Case 4
                    Me.CalificadorDtoCargo4 = CalificadorDtoCargo
                    Me.SecuenciaCalculo4 = Secuencia
                    Me.TipoDtoCargo4 = TipoDtoCargo
                    Me.PorcentajeDtoCargo4 = Porcentaje
                    Me.ImporteDtoCargo4 = Importe

                Case 5
                    Me.CalificadorDtoCargo5 = CalificadorDtoCargo
                    Me.SecuenciaCalculo5 = Secuencia
                    Me.TipoDtoCargo5 = TipoDtoCargo
                    Me.PorcentajeDtoCargo5 = Porcentaje
                    Me.ImporteDtoCargo5 = Importe

            End Select


        End Sub



    End Class


End Namespace



