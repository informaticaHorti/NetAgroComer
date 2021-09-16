
Namespace Contabilizacion


    

    Public Class clAsientos

        Public Const CuentaPorDefecto As String = "55500000000"
        'Public Const CuentaPorDefectoVB6 As String = "555000000"

        Private _ListaclAsientosLineas As New List(Of clAsientoLineas)
        Public Property ListaClAsientosLineas As List(Of clAsientoLineas)
            Get
                Return _ListaclAsientosLineas
            End Get
            Set(ByVal value As List(Of clAsientoLineas))
                _ListaclAsientosLineas = value
            End Set
        End Property



        ''' <summary>
        ''' Devuelve el idAsiento que ha contabilizado
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Contabilizar(ConCtb As Cdatos.Conexion, ByVal idasiento As Integer, ByVal idcentro As Integer, ByVal FechaAsiento As Date, ByVal EjNet As Integer, ByVal IdPventa As Integer, ByVal TipoOperacion As String, ByVal IdOperacion As Integer) As Integer

            'If CentroAsientos > 0 Then
            '    idcentro = CentroAsientos
            'End If

            Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
            If ValoresPVenta.LeerId(IdPventa.ToString) Then

                Dim CentroAsientos As Integer = VaInt(ValoresPVenta.VPV_CentroCtb.Valor)
                If CentroAsientos > 0 Then idcentro = CentroAsientos

            End If


            If ConectarFinancieroContabilidad <> "S" Then
                Return 0
            End If

            Dim resultado As Integer = 0
            Dim EntiPventa As New E_PuntoVenta(Idusuario, ConCtb)
            Dim IdActividad As Integer = 0
            Dim IdSeccion As Integer = 0
            Dim EjerNet As Integer = 0
            Dim AsientoNet As Integer = 0
            Dim Asientos As New E_Asientos(Idusuario, ConCtb)



            If EntiPventa.LeerId(IdPventa) = True Then ' leo el punto de venta por si no tiene seccion y activdad
                IdActividad = EntiPventa.IdActividad.Valor
                IdSeccion = EntiPventa.IdSeccion.Valor
            End If

            If idasiento = 999999 Then Return 0

            EjerNet = EjNet

            If idasiento > 0 Then ' modificar un asiento

                If Asientos.LeerId(idasiento) Then

                    ' comprobar que el asiento es el correcto

                    EjerNet = Asientos.Ejercicio.Valor
                    AsientoNet = Asientos.Asiento.Valor

                    If AnularAsiento(ConCtb, idasiento, Asientos.Asiento.Valor) = 0 Then
                        'MsgBox("Asiento anulado con éxito")
                    End If
                End If


            Else
                idasiento = Asientos.MaxId
            End If



            If AsientoNet = 0 Then
                AsientoNet = Asientos.MaxNumeroAsiento(EjerNet, "0", idcentro.ToString, 0)
            End If


            If ListaClAsientosLineas.Count > 0 Then
                Asientos.VaciaEntidad()
                Asientos.Diario.Valor = ""
                Asientos.Fecha.Valor = StDate(FechaAsiento)
                Asientos.Tipo.Valor = "0"
                Asientos.IdCentro.Valor = StInt(idcentro)
                Asientos.Ejercicio.Valor = EjerNet
                Asientos.IdAsiento.Valor = idasiento
                Asientos.Asiento.Valor = AsientoNet
                Asientos.CdOrigen.Valor = TipoOperacion
                Asientos.IdOrigen.Valor = IdOperacion

                Asientos.Insertar()

                For Each lin As clAsientoLineas In ListaClAsientosLineas

                    If lin.Importe <> 0 Then
                        Dim LinAsi As New E_AsientoLineas(Idusuario, ConCtb)

                        LinAsi.Concepto.Valor = lin.Concepto
                        If lin.DH.ToUpper = "D" Then
                            If lin.Importe < 0 Then
                                LinAsi.Haber.Valor = StDec(-lin.Importe)
                                LinAsi.Debe.Valor = "0"
                            Else
                                LinAsi.Debe.Valor = StDec(lin.Importe)
                                LinAsi.Haber.Valor = "0"
                            End If

                        Else
                            If lin.Importe < 0 Then
                                LinAsi.Debe.Valor = StDec(-lin.Importe)
                                LinAsi.Haber.Valor = "0"
                            Else
                                LinAsi.Haber.Valor = StDec(lin.Importe)
                                LinAsi.Debe.Valor = "0"
                            End If

                        End If
                        LinAsi.Documento.Valor = lin.Documento
                        LinAsi.Fecha.Valor = Asientos.Fecha.Valor

                        If VaInt(lin.IdActividad) = 0 Then
                            lin.IdActividad = IdActividad
                        End If
                        LinAsi.IdActividad.Valor = lin.IdActividad

                        LinAsi.IdAsiento.Valor = Asientos.IdAsiento.Valor
                        LinAsi.IdConcepto.Valor = StInt(lin.idConcepto)

                        LinAsi.IdDepartamento.Valor = StInt(lin.IdDepartamento)
                        LinAsi.IdPunteo43.Valor = ""
                        LinAsi.IdPunteoManual.Valor = ""
                        LinAsi.IdRegistro.Valor = ""

                        If (lin.Cuenta & "").Trim = "" Then
                            LinAsi.NumeroCuenta.Valor = CuentaPorDefecto
                        Else
                            LinAsi.NumeroCuenta.Valor = lin.Cuenta
                        End If

                        If VaInt(lin.IdSeccion) = 0 Then
                            lin.IdSeccion = IdSeccion
                        End If
                        LinAsi.IdSeccion.Valor = lin.IdSeccion
                        LinAsi.IdSubDepartamento.Valor = StInt(lin.IdSubDepartamento)


                        LinAsi.IdApunte.Valor = StInt(LinAsi.MaxId(0))
                        LinAsi.Tipo.Valor = Asientos.Tipo.Valor
                        LinAsi.SRPC.Valor = lin.SRPC
                        LinAsi.Insertar()

                        If lin.clcartera IsNot Nothing Then
                            Dim Cartera As New E_Cartera(Idusuario, ConCtb)
                            Dim Cartera_lineas As New E_Cartera_lineas(Idusuario, ConCtb)
                            Cartera.VaciaEntidad()
                            Cartera.IdRegistro.Valor = LinAsi.IdApunte.Valor
                            Cartera.Cuenta.Valor = lin.clcartera.Cuenta
                            Cartera.CuentaCartera.Valor = lin.clcartera.CuentaCartera
                            Cartera.FechaDocumento.Valor = lin.clcartera.Fecha
                            Cartera.NumeroDocumento.Valor = lin.clcartera.Documento
                            Cartera.PagoCobro.Valor = lin.clcartera.PagoCobro
                            Cartera.Insertar()

                            For Each lcartera In lin.clcartera.LineasCartera
                                Cartera_lineas.VaciaEntidad()
                                Dim id As Integer = Cartera_lineas.MaxId
                                Cartera_lineas.Idlinea.Valor = id.ToString
                                Cartera_lineas.Idregistro.Valor = LinAsi.IdApunte.Valor
                                If Val(lcartera.Estado) = 0 Then
                                    Cartera_lineas.Estado.Valor = "1"
                                Else
                                    Cartera_lineas.Estado.Valor = lcartera.Estado
                                End If
                                Cartera_lineas.DocPago.Valor = ""
                                Cartera_lineas.FechaCancelacion.Valor = "01/01/1900"
                                Cartera_lineas.Idbanco.Valor = lcartera.IdBanco.ToString
                                Cartera_lineas.IdTipodoc.Valor = lcartera.IdTipo.ToString
                                Cartera_lineas.Importe.Valor = lcartera.Importe.ToString
                                Cartera_lineas.Vencimiento.Valor = lcartera.Vencimiento.ToString
                                Cartera_lineas.Insertar()
                            Next

                        End If

                        If lin.clIva IsNot Nothing Then
                            If lin.clIva.Soportado Then
                                Dim EntiIvaSop As New E_IvaSoportado(Idusuario, ConCtb)
                                If lin.clIva.MisDesgloseIvas.Count > 0 Then

                                    For i = 1 To 4
                                        Select Case i
                                            Case 1
                                                If lin.clIva.MisDesgloseIvas.Count >= 1 Then
                                                    If VaInt(lin.clIva.MisDesgloseIvas(i - 1).base) <> 0 Then
                                                        EntiIvaSop.Base1.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).base)
                                                        EntiIvaSop.Cuota1.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).cuota)
                                                        EntiIvaSop.CuotaRe1.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).CuotaRecargo)
                                                        EntiIvaSop.Re1.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcenRecargo)
                                                        EntiIvaSop.Iva1.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcentaje)
                                                    End If
                                                End If

                                            Case 2
                                                If VaInt(lin.clIva.MisDesgloseIvas.Count) >= 2 Then
                                                    If VaInt(lin.clIva.MisDesgloseIvas(i - 1).base) <> 0 Then
                                                        If lin.clIva.MisDesgloseIvas.Count >= 2 Then
                                                            EntiIvaSop.Base2.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).base)
                                                            EntiIvaSop.Cuota2.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).cuota)
                                                            EntiIvaSop.CuotaRe2.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).CuotaRecargo)
                                                            EntiIvaSop.Re2.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcenRecargo)
                                                            EntiIvaSop.Iva2.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcentaje)
                                                        End If
                                                    End If
                                                End If

                                            Case 3
                                                If VaInt(lin.clIva.MisDesgloseIvas.Count) >= 3 Then
                                                    If VaInt(lin.clIva.MisDesgloseIvas(i - 1).base) <> 0 Then
                                                        If lin.clIva.MisDesgloseIvas.Count >= 3 Then
                                                            EntiIvaSop.Base3.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).base)
                                                            EntiIvaSop.Cuota3.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).cuota)
                                                            EntiIvaSop.CuotaRe3.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).CuotaRecargo)
                                                            EntiIvaSop.Re3.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcenRecargo)
                                                            EntiIvaSop.Iva3.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcentaje)
                                                        End If
                                                    End If
                                                End If
                                            Case 4
                                                If VaInt(lin.clIva.MisDesgloseIvas.Count) >= 4 Then
                                                    If VaInt(lin.clIva.MisDesgloseIvas(i - 1).base) <> 0 Then
                                                        If lin.clIva.MisDesgloseIvas.Count >= 4 Then
                                                            EntiIvaSop.Base4.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).base)
                                                            EntiIvaSop.Cuota4.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).cuota)
                                                            EntiIvaSop.CuotaRe4.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).CuotaRecargo)
                                                            EntiIvaSop.Re4.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcenRecargo)
                                                            EntiIvaSop.Iva4.Valor = StDec(lin.clIva.MisDesgloseIvas(i - 1).porcentaje)
                                                        End If
                                                    End If
                                                End If
                                        End Select
                                    Next
                                    If lin.clIva.MiRetencion.base <> 0 Then
                                        EntiIvaSop.CuotaRetencion.Valor = StDec(lin.clIva.MiRetencion.cuota)
                                        EntiIvaSop.BaseRetencion.Valor = StDec(lin.clIva.MiRetencion.base)
                                        EntiIvaSop.TipoRetencion.Valor = StDec(lin.clIva.MiRetencion.porcentaje)
                                        EntiIvaSop.ClaveRetencion.Valor = lin.clIva.MiRetencion.clave
                                    End If
                                End If

                                EntiIvaSop.SerieDocumento.Valor = lin.clIva.Serie
                                EntiIvaSop.Documento.Valor = lin.clIva.NumFactura
                                EntiIvaSop.FechaFac.Valor = StDate(lin.clIva.FechaFactura)
                                EntiIvaSop.Descripcion_AEAT.Valor = lin.clIva.Descripcion

                                If (lin.clIva.NumCuenta & "").Trim = "" Then
                                    EntiIvaSop.idcuenta.Valor = CuentaPorDefecto
                                Else
                                    EntiIvaSop.idcuenta.Valor = lin.clIva.NumCuenta
                                End If

                                EntiIvaSop.IdRegistro.Valor = LinAsi.IdApunte.Valor
                                EntiIvaSop.idTipoIvaSoportado.Valor = StInt(lin.clIva.IdTipoIva)
                                EntiIvaSop.nif.Valor = lin.clIva.Nif
                                EntiIvaSop.nombre.Valor = lin.clIva.Nombre
                                EntiIvaSop.TotalFactura.Valor = StDec(lin.clIva.TotalFactura)
                                EntiIvaSop.TipoIdentificacion.Valor = lin.clIva.TipoIdentificacion
                                EntiIvaSop.CodigoPais.Valor = lin.clIva.CodigoPais

                                If Not lin.clIva.Ignorar_AEAT Then
                                    If (lin.clIva.FechaHora_AEAT & "").Trim <> "" Then
                                        'EntiIvaSop.FechaHora_AEAT.Valor = lin.clIva.FechaHora_AEAT
                                        EntiIvaSop.FechaHora_AEAT.Valor = Now.ToString("yyyyMMddHHmmss")
                                    End If
                                Else
                                    EntiIvaSop.Ignorar_AEAT.Valor = "S"
                                End If

                                EntiIvaSop.Insertar()

                                LinAsi.TipoSRPC.Valor = "S"
                                LinAsi.Actualizar()
                            Else
                                Dim EntiIvaRep As New E_IvaRepercutido(Idusuario, ConCtb)
                                If lin.clIva.MisDesgloseIvas.Count > 0 Then
                                    For i = 0 To 3
                                        Select Case i + 1
                                            Case 1
                                                EntiIvaRep.Base1.Valor = StDec(lin.clIva.MisDesgloseIvas(i).base)
                                                EntiIvaRep.Cuota1.Valor = StDec(lin.clIva.MisDesgloseIvas(i).cuota)
                                                EntiIvaRep.CuotaRe1.Valor = StDec(lin.clIva.MisDesgloseIvas(i).CuotaRecargo)
                                                EntiIvaRep.Re1.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcenRecargo)
                                                EntiIvaRep.Iva1.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcentaje)
                                            Case 2
                                                EntiIvaRep.Base2.Valor = StDec(lin.clIva.MisDesgloseIvas(i).base)
                                                EntiIvaRep.Cuota2.Valor = StDec(lin.clIva.MisDesgloseIvas(i).cuota)
                                                EntiIvaRep.CuotaRe2.Valor = StDec(lin.clIva.MisDesgloseIvas(i).CuotaRecargo)
                                                EntiIvaRep.Re2.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcenRecargo)
                                                EntiIvaRep.Iva2.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcentaje)
                                            Case 3
                                                EntiIvaRep.Base3.Valor = StDec(lin.clIva.MisDesgloseIvas(i).base)
                                                EntiIvaRep.Cuota3.Valor = StDec(lin.clIva.MisDesgloseIvas(i).cuota)
                                                EntiIvaRep.CuotaRe3.Valor = StDec(lin.clIva.MisDesgloseIvas(i).CuotaRecargo)
                                                EntiIvaRep.Re3.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcenRecargo)
                                                EntiIvaRep.Iva3.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcentaje)
                                            Case 4
                                                EntiIvaRep.Base4.Valor = StDec(lin.clIva.MisDesgloseIvas(i).base)
                                                EntiIvaRep.Cuota4.Valor = StDec(lin.clIva.MisDesgloseIvas(i).cuota)
                                                EntiIvaRep.CuotaRe4.Valor = StDec(lin.clIva.MisDesgloseIvas(i).CuotaRecargo)
                                                EntiIvaRep.Re4.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcenRecargo)
                                                EntiIvaRep.Iva4.Valor = StDec(lin.clIva.MisDesgloseIvas(i).porcentaje)
                                        End Select
                                    Next
                                End If
                                If lin.clIva.MiRetencion.base > 0 Then
                                    EntiIvaRep.CuotaRetencion.Valor = StDec(lin.clIva.MiRetencion.cuota)
                                    EntiIvaRep.BaseRetencion.Valor = StDec(lin.clIva.MiRetencion.base)
                                    EntiIvaRep.TipoRetencion.Valor = StDec(lin.clIva.MiRetencion.porcentaje)
                                    EntiIvaRep.ClaveRetencion.Valor = lin.clIva.MiRetencion.clave
                                End If



                                If lin.clIva.SujetoIVA Then
                                    EntiIvaRep.SujetoIVA.Valor = "S"
                                Else
                                    EntiIvaRep.SujetoIVA.Valor = "N"
                                End If

                                If lin.clIva.ExentoIVA Then
                                    EntiIvaRep.ExentoIVA.Valor = "S"
                                Else
                                    EntiIvaRep.ExentoIVA.Valor = "N"
                                End If


                                EntiIvaRep.SerieDocumento.Valor = lin.clIva.Serie
                                EntiIvaRep.Documento.Valor = lin.clIva.NumFactura
                                EntiIvaRep.FechaFac.Valor = StDate(lin.clIva.FechaFactura)
                                EntiIvaRep.Descripcion_AEAT.Valor = lin.clIva.Descripcion

                                If (lin.clIva.NumCuenta & "").Trim = "" Then
                                    EntiIvaRep.idcuenta.Valor = CuentaPorDefecto
                                Else
                                    EntiIvaRep.idcuenta.Valor = lin.clIva.NumCuenta
                                End If


                                EntiIvaRep.IdRegistro.Valor = LinAsi.IdApunte.Valor
                                EntiIvaRep.idTipoIvaRepercutido.Valor = StInt(lin.clIva.IdTipoIva)
                                EntiIvaRep.nif.Valor = lin.clIva.Nif
                                EntiIvaRep.nombre.Valor = lin.clIva.Nombre
                                EntiIvaRep.TotalFactura.Valor = StDec(lin.clIva.TotalFactura)
                                EntiIvaRep.TipoIdentificacion.Valor = lin.clIva.TipoIdentificacion
                                EntiIvaRep.CodigoPais.Valor = lin.clIva.CodigoPais

                                If Not lin.clIva.Ignorar_AEAT Then
                                    If (lin.clIva.FechaHora_AEAT & "").Trim <> "" Then
                                        'EntiIvaRep.FechaHora_AEAT.Valor = lin.clIva.FechaHora_AEAT
                                        EntiIvaRep.FechaHora_AEAT.Valor = Now.ToString("yyyyMMddHHmmss")
                                    End If
                                Else
                                    EntiIvaRep.Ignorar_AEAT.Valor = "S"
                                End If

                                EntiIvaRep.Insertar()


                                LinAsi.TipoSRPC.Valor = "R"
                                LinAsi.Actualizar()
                            End If
                        End If
                    End If
                Next
                resultado = VaInt(Asientos.IdAsiento.Valor)

            Else
                Throw New Exception("No hay nada que contabilizar")
                resultado = 0
            End If

            Return resultado


        End Function


        Public Function AnularAsiento(ConCtb As Cdatos.Conexion, ByVal _Idasiento As Integer, ByVal _NumAsiento As Integer) As Integer

            If _Idasiento = 999999 Then Return -1

            If _Idasiento > 0 Then

                Dim Asientos As New E_Asientos(Idusuario, ConCtb)

                If Asientos.LeerId(_Idasiento) = True Then
                    If FnVaInt(Asientos.Asiento.Valor) = _NumAsiento Then
                        Asientos.Eliminar()
                        Return 0
                    Else
                        MsgBox("¡No encuentro el Asiento " & _NumAsiento.ToString & " asociado al IdAsiento " & _Idasiento.ToString & "!", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, " Atención")
                        Return 1
                    End If
                Else
                    Return 1
                End If
            Else
                Return 1
            End If


        End Function


    End Class

    Public Class clAsientoLineas
        Private _Cuenta As String
        Public Property Cuenta As String
            Get
                Return _Cuenta
            End Get
            Set(ByVal value As String)
                _Cuenta = value
            End Set
        End Property
        Private _idConcepto As Integer
        Public Property idConcepto As Integer
            Get
                Return _idConcepto
            End Get
            Set(ByVal value As Integer)
                _idConcepto = value
            End Set
        End Property
        Private _Concepto As String
        Public Property Concepto As String
            Get
                Return _Concepto
            End Get
            Set(ByVal value As String)
                _Concepto = value
            End Set
        End Property
        Private _Documento As String
        Public Property Documento As String
            Get
                Return _Documento
            End Get
            Set(ByVal value As String)
                _Documento = value
            End Set
        End Property

        Private _Importe As Decimal
        Public Property Importe As Decimal
            Get
                Return _Importe
            End Get
            Set(ByVal value As Decimal)
                _Importe = value
            End Set
        End Property

        Private _DH As String
        Public Property DH As String
            Get
                Return _DH
            End Get
            Set(ByVal value As String)
                _DH = value
            End Set
        End Property

        Private _IdActividad As Integer
        Public Property IdActividad As Integer
            Get
                Return _IdActividad
            End Get
            Set(ByVal value As Integer)
                _IdActividad = value
            End Set
        End Property
        Private _IdSeccion As Integer
        Public Property IdSeccion As Integer
            Get
                Return _IdSeccion
            End Get
            Set(ByVal value As Integer)
                _IdSeccion = value
            End Set
        End Property
        Private _IdDepartamento As Integer
        Public Property IdDepartamento As Integer
            Get
                Return _IdDepartamento
            End Get
            Set(ByVal value As Integer)
                _IdDepartamento = value
            End Set
        End Property
        Private _IdSubDepartamento As Integer
        Public Property IdSubDepartamento As Integer
            Get
                Return _IdSubDepartamento
            End Get
            Set(ByVal value As Integer)
                _IdSubDepartamento = value
            End Set
        End Property

        Private _SRPC As String
        Public Property SRPC As String
            Get
                Return _SRPC
            End Get
            Set(ByVal value As String)
                _SRPC = value
            End Set
        End Property

        Private _clIva As clIva
        Public Property clIva As clIva
            Get
                Return _clIva
            End Get
            Set(ByVal value As clIva)
                _clIva = value
            End Set
        End Property


        Private _clcartera As clCartera
        Public Property clcartera As clCartera
            Get
                Return _clcartera
            End Get
            Set(ByVal value As clCartera)
                _clcartera = value
            End Set
        End Property

    End Class
    Public Class clCartera
        Public Structure DesgloseCartera
            Public Importe As Decimal
            Public Vencimiento As String
            Public IdTipo As String
            Public IdBanco As String
            Public Estado As String
        End Structure

        Public PagoCobro As String
        Public Documento As String
        Public Fecha As String
        Public Cuenta As String
        Public CuentaCartera As String
        Public LineasCartera As New List(Of DesgloseCartera)

    End Class

    Public Class clIva

        Public Structure DesgloseIvas
            Public base As Decimal
            Public porcentaje As Decimal
            Public cuota As Decimal
            Public porcenRecargo As Decimal
            Public CuotaRecargo As Decimal
        End Structure

        Public Structure Retencion
            Public base As Decimal
            Public porcentaje As Decimal
            Public cuota As Decimal
            Public clave As String
        End Structure


        Private _Soportado As Boolean
        Public Property Soportado As Boolean
            Get
                Return _Soportado
            End Get
            Set(ByVal value As Boolean)
                _Soportado = value
            End Set
        End Property
        Private _Nombre As String
        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
            End Set
        End Property
        Private _TipoIdentificacion As String
        Public Property TipoIdentificacion As String
            Get
                Return _TipoIdentificacion
            End Get
            Set(value As String)
                _TipoIdentificacion = value
            End Set
        End Property
        Private _CodigoPais As String
        Public Property CodigoPais As String
            Get
                Return _CodigoPais
            End Get
            Set(value As String)
                _CodigoPais = value
            End Set
        End Property
        Private _Nif As String
        Public Property Nif As String
            Get
                Return _Nif
            End Get
            Set(ByVal value As String)
                _Nif = value
            End Set
        End Property
        Private _FechaFactura As Date
        Public Property FechaFactura As Date
            Get
                Return _FechaFactura
            End Get
            Set(ByVal value As Date)
                _FechaFactura = value
            End Set
        End Property
        Private _Serie As String
        Public Property Serie
            Get
                Return _Serie
            End Get
            Set(value)
                _Serie = value
            End Set
        End Property
        Private _NumFactura As String
        Public Property NumFactura As String
            Get
                Return _NumFactura
            End Get
            Set(ByVal value As String)
                _NumFactura = value
            End Set
        End Property
        Private _NumCuenta As String
        Public Property NumCuenta As String
            Get
                Return _NumCuenta
            End Get
            Set(ByVal value As String)
                _NumCuenta = value
            End Set
        End Property
        Private _IdTipoIva As Integer
        Public Property IdTipoIva As Integer
            Get
                Return _IdTipoIva
            End Get
            Set(ByVal value As Integer)
                _IdTipoIva = value
            End Set
        End Property

        Private _TotalFactura As Decimal

        Public Property TotalFactura As Decimal
            Get
                Return _TotalFactura
            End Get
            Set(ByVal value As Decimal)
                _TotalFactura = value
            End Set
        End Property
        Private _Descripcion As String
        Public Property Descripcion As String
            Get
                Return _Descripcion
            End Get
            Set(value As String)
                _Descripcion = value
            End Set
        End Property

        Private _SujetoIVA As Boolean = False
        Public Property SujetoIVA As Boolean
            Get
                Return _SujetoIVA
            End Get
            Set(value As Boolean)
                _SujetoIVA = value
            End Set
        End Property
        Private _ExentoIVA As Boolean
        Public Property ExentoIVA
            Get
                Return _ExentoIVA
            End Get
            Set(value)
                _ExentoIVA = value
            End Set
        End Property

        Private _DegloseIvas As List(Of DesgloseIvas)
        Public Property MisDesgloseIvas As List(Of DesgloseIvas)
            Get
                Return _DegloseIvas
            End Get
            Set(ByVal value As List(Of DesgloseIvas))
                _DegloseIvas = value
            End Set
        End Property

        Private _Retencion As Retencion
        Public Property MiRetencion As Retencion
            Get
                Return _Retencion
            End Get
            Set(ByVal value As Retencion)
                _Retencion = value
            End Set
        End Property

        Private _FechaHora_AEAT As String
        Public Property FechaHora_AEAT As String
            Get
                Return _FechaHora_AEAT
            End Get
            Set(value As String)
                _FechaHora_AEAT = value
            End Set
        End Property

        Private _Ignorar_AEAT As Boolean = False
        Public Property Ignorar_AEAT As Boolean
            Get
                Return _Ignorar_AEAT
            End Get
            Set(value As Boolean)
                _Ignorar_AEAT = value
            End Set
        End Property


    End Class




End Namespace


Public Class Generica
    'Public Shared Function GeneraAsientoVB6() As Integer
    '     IdAsientoVb6 = 0
    '     Dim enti As New Centros(_maletin.IdUsuario, _maletin.ConexionContabilidad, _maletin.ConexionComun)
    '     If enti.LeerId(c.IdCentro.ToString) Then
    ' If enti.GenerarAsientoVB6.Valor = "S" Then
    ' Dim contaVb6 As New ContabilidadVB6.Contabilizacion(_maletin.IdUsuario, _maletin.longitudCuenta, _maletin.ConexionContabilidad, _maletin.ConexionComun, _maletin.Conexionvb6)
    ' IdAsientoVb6 = contaVb6.Contabilizar(c, _maletin.IdCentro, c.FechaAsiento, enti.EjercicioVb6.Valor, _maletin.TipoCtbvb6, IdAsientoVb6, "", aSientoNet, _maletin.IdUsuario, _maletin.ConexionComun)
    ' Dim EntiEqui As New AsientosEquiv(_maletin.IdUsuario, _maletin.ConexionContabilidad, _maletin.ConexionComun)
    ' If EntiEqui.ExisteId(aSientoNet.ToString) = False Then
    ' EntiEqui.AsientoCtb.Valor = Format(VaInt(IdAsientoVb6.ToString), "000000")
    ' EntiEqui.CamCtb.Valor = enti.EjercicioVb6.Valor
    ' EntiEqui.IdAsiento.Valor = aSientoNet.ToString
    ' EntiEqui.TipCtb.Valor = _maletin.TipoCtbvb6.ToString
    ' EntiEqui.Insertar()
    ' End If
    ' End If
    ' End If
    '
    'Return IdAsientoVb6
    'End Function
    Public Shared Function EliminaAsiento(ConCtb As Cdatos.Conexion, ByVal idAsiento As Integer) As Boolean
        Dim resultado As Boolean = False
        Dim Entiasi As New E_Asientos(Idusuario, ConCtb)
        If Entiasi.LeerId(idAsiento.ToString) Then
            If Entiasi.Eliminar Then

                Return True
            End If
        End If
        Return resultado
    End Function
    Public Shared Function Ctas11(ByVal cta9 As String) As String

        Dim r As String = ""
        Dim parte1 As String = ""
        Dim parte2 As String = ""
        Dim parte3 As String = ""

        If cta9.Trim.Length >= 9 Then
            parte1 = cta9.Substring(0, 4)
            parte2 = cta9.Substring(4, 1)
            parte3 = cta9.Substring(5, 4)
            r = parte1 & "0" & parte2 & "0" & parte3
        End If

        Return r

    End Function

End Class

