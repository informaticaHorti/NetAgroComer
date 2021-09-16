Public Class E_LiquidacionAgr
    Inherits Cdatos.Entidad

    Public LIQ_Idliquidacion As Cdatos.bdcampo
    Public LIQ_ejercicio As Cdatos.bdcampo
    Public LIQ_idempresa As Cdatos.bdcampo
    Public LIQ_idcentro As Cdatos.bdcampo
    Public LIQ_serie As Cdatos.bdcampo
    Public LIQ_numero As Cdatos.bdcampo
    Public LIQ_fecha As Cdatos.bdcampo
    Public LIQ_Idagricultor As Cdatos.bdcampo
    Public LIQ_ImpFacturas As Cdatos.bdcampo
    Public LIQ_ImpAnterior As Cdatos.bdcampo
    Public LIQ_DtoAnticipos As Cdatos.bdcampo
    Public LIQ_DtoSumi As Cdatos.bdcampo
    Public LIQ_DtoPortes As Cdatos.bdcampo
    Public LIQ_Apagar As Cdatos.bdcampo
    Public LIQ_Idbanco As Cdatos.bdcampo
    Public LIQ_Nutalon As Cdatos.bdcampo
    Public LIQ_IdAsiento As Cdatos.bdcampo
    Public LIQ_DeFecha As Cdatos.bdcampo
    Public LIQ_Afecha As Cdatos.bdcampo

    Public LIQ_IdFormaPago As Cdatos.bdcampo
    Public LIQ_FechaVto As Cdatos.bdcampo
    Public LIQ_SituacionCartera As Cdatos.bdcampo
    Public LIQ_TipoDocumento As Cdatos.bdcampo

    Public LIQ_IdUsuarioLog As Cdatos.bdcampo
    Public LIQ_FechaLog As Cdatos.bdcampo
    Public LIQ_HoraLog As Cdatos.bdcampo




    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "LiquidacionAgr"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            LIQ_Idliquidacion = New Cdatos.bdcampo(CodigoEntidad & "idliquidacion", Cdatos.TiposCampo.Entero, 8, 0, True)
            LIQ_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "ejercicio", Cdatos.TiposCampo.Entero, 2)
            LIQ_idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.Entero, 2)
            LIQ_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 2)
            LIQ_serie = New Cdatos.bdcampo(CodigoEntidad & "serie", Cdatos.TiposCampo.Cadena, 8)
            LIQ_numero = New Cdatos.bdcampo(CodigoEntidad & "numerofactur", Cdatos.TiposCampo.Entero, 8)
            LIQ_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            LIQ_Idagricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.Entero, 5)
            LIQ_ImpFacturas = New Cdatos.bdcampo(CodigoEntidad & "ImpFacturas", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_ImpAnterior = New Cdatos.bdcampo(CodigoEntidad & "ImpAnterior", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_DtoAnticipos = New Cdatos.bdcampo(CodigoEntidad & "DtoAnticipos", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_DtoSumi = New Cdatos.bdcampo(CodigoEntidad & "DtoSumi", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_DtoPortes = New Cdatos.bdcampo(CodigoEntidad & "DtoPortes", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_Apagar = New Cdatos.bdcampo(CodigoEntidad & "Apagar", Cdatos.TiposCampo.Importe, 12, 2)
            LIQ_Idbanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.EnteroPositivo, 3)
            LIQ_Nutalon = New Cdatos.bdcampo(CodigoEntidad & "Nutalon", Cdatos.TiposCampo.EnteroPositivo, 10)
            LIQ_IdAsiento = New Cdatos.bdcampo(CodigoEntidad & "idasiento", Cdatos.TiposCampo.Entero, 8)
            LIQ_DeFecha = New Cdatos.bdcampo(CodigoEntidad & "Defecha", Cdatos.TiposCampo.Fecha, 10)
            LIQ_Afecha = New Cdatos.bdcampo(CodigoEntidad & "Afecha", Cdatos.TiposCampo.Fecha, 10)

            LIQ_IdFormaPago = New Cdatos.bdcampo(CodigoEntidad & "IdFormaPago", Cdatos.TiposCampo.EnteroPositivo, 3)
            LIQ_FechaVto = New Cdatos.bdcampo(CodigoEntidad & "FechaVto", Cdatos.TiposCampo.Fecha, 10)
            LIQ_SituacionCartera = New Cdatos.bdcampo(CodigoEntidad & "SituacionCartera", Cdatos.TiposCampo.EnteroPositivo, 10)
            LIQ_TipoDocumento = New Cdatos.bdcampo(CodigoEntidad & "TipoDocumento", Cdatos.TiposCampo.EnteroPositivo, 10)

            LIQ_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LIQ_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LIQ_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.LIQ_numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Agricultores As New E_Agricultores(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.LIQ_Idliquidacion, "IdLiquidacion")
        consulta.SelCampo(Me.LIQ_ejercicio, "Ejer")
        consulta.SelCampo(Me.LIQ_serie, "Serie")
        consulta.SelCampo(Me.LIQ_numero, "Numero")
        consulta.SelCampo(Me.LIQ_fecha, "Fecha")
        consulta.SelCampo(Me.LIQ_Idagricultor, "Codigo")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Me.LIQ_Idagricultor)
        consulta.SelCampo(Me.LIQ_Apagar, "Importe")
        consulta.SelCampo(Me.LIQ_Nutalon, "Nutalon")
        _btBusca.Params("Idliquidacion", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idliquidacion"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFac"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultores.AGR_IdAgricultor
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        _btBusca.ParamConsultaAlb(consulta, "", Me.LIQ_Idagricultor, Me.LIQ_fecha, Nothing, Me.LIQ_idempresa)


    End Sub

    Public Function LeerLiquidacion(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Serie As String, ByVal numero As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.LIQ_idempresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.LIQ_ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LIQ_serie, "=", Serie)
        CONSULTA.WheCampo(Me.LIQ_numero, "=", numero.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                    CargaCampos(Dt.Rows(0))
                End If
            End If
        End If
        Return ret
    End Function


    Public Function ExisteLiquidacion(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal serie As String, ByVal factura As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelCampo(Me.LIQ_Idliquidacion)

        CONSULTA.WheCampo(Me.LIQ_idempresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.LIQ_ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LIQ_serie, "=", serie)
        CONSULTA.WheCampo(Me.LIQ_numero, "=", factura.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                End If
            End If
        End If
        Return ret
    End Function


    Public Function MaxIdCampa(ByVal Empresa As Integer, ByVal Campa As Integer, ByVal Serie As String, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0

                max = ValorMaximo(Empresa.ToString + "_" + Campa.ToString + "_" + Serie, vmax)

                existe = ExisteLiquidacion(Empresa, Campa, Serie, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de facturas", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

    Public Function UltimoNumero(ByVal Empresa As Integer, ByVal Campa As Integer, ByVal Serie As String) As Integer
        Return Vcontador(Empresa.ToString + "_" + Campa.ToString + "_" + Serie)
    End Function

    Public Sub ActuContador(ByVal Empresa As Integer, ByVal Campa As Integer, ByVal Serie As String, Ultimo As Integer)




        Dim v As Integer = 0
        Dim sql As String = ""
        Dim TipoContador As String = Empresa.ToString + "_" + Campa.ToString + "_" + Serie



        ' esto se puede poner el en base de la entidad, pasandole el tipocontador y el ultimo
        Try
            v = Vcontador(TipoContador)
            If v >= 0 Then
                sql = "Update Contadores set " & PrefijoContador & "UltimoNumero=" & Ultimo.ToString & ", " & PrefijoContador & "IdUsuario=" & Idusuario.ToString & " WHERE " & PrefijoContador & "NombreTabla='" & NombreTabla & "' AND " & PrefijoContador & "TipoContador='" & TipoContador & "'"
            Else
                sql = "Insert Into Contadores (" & PrefijoContador & "NombreTabla, " & PrefijoContador & "TipoContador, " & PrefijoContador & "UltimoNumero, " & PrefijoContador & "IdUsuario) VALUES ('" & NombreTabla & "','" & TipoContador & "'," & Ultimo.ToString & "," & Idusuario.ToString & ")"
            End If
            MiConexion.OrdenSql(sql)
        Catch ex As Exception
            MsgBox("No puedo actualizar el contador")
        End Try



    End Sub


    Private Sub E_Almmaterial_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "update facturaagr set fgr_idliquidacion=0 where fgr_idliquidacion = " + Me.LIQ_Idliquidacion.Valor
        MiConexion.OrdenSql(sql)


    End Sub


    Public Function Contabiliza(ByVal IdLiqui As Integer) As Integer

        Dim Resultado As Integer




        If Me.LeerId(IdLiqui) = False Then
            Return 0
        End If

        If VaInt(Me.LIQ_Nutalon.Valor) = 0 Then
            Return 0

        End If

        If VaDec(Me.LIQ_Apagar.Valor) = 0 Then
            Return 0
        End If

        Dim Ectb As Integer = VaInt(Me.LIQ_idempresa.Valor)

        Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Ectb))
        Dim Bancos As New E_Bancos(Idusuario, ConexCtb(Ectb))
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Ectb))
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Dim IdCentro As String = Me.LIQ_idcentro.Valor
        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Dim TipoDocumento As New E_TipoDocumento(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"



        '        If PuntoVenta.LeerId(Me.fgr_idpuntoventa.Valor) Then
        ' IdActividad = VaInt(PuntoVenta.IdActividad.Valor).ToString
        ' IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor).ToString
        ' IdCentro = PuntoVenta.IdCentro.Valor
        ' End If



        Dim NombreAgricultor As String = ""
        If Agricultores.LeerId(Me.LIQ_Idagricultor.Valor) Then NombreAgricultor = Agricultores.AGR_Nombre.Valor & ""
        If TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor) = True Then

        End If
        Dim CuentaBanco As String = ""
        If Bancos.LeerId(Me.LIQ_Idbanco.Valor) = True Then
            CuentaBanco = Bancos.CuentaTesoreria.Valor
        End If
        Dim CuentaAgricultor As String = ""
        Dim CuentaAnticipos As String = ""
        Dim CuentaSuministros As String = ""
        Dim CuentaPortes As String = ""
        Dim CuentaCartera As String = ""
        Dim RegCuentaCartera As String = ""

        Dim RegTipoDocumento As String = ""
        Dim RegSituacion As String = ""
        Dim RegFechaVto As String = ""
        Dim RegEstado As String = ""
        Dim RegCuentaAgricultor As String = ""



        CuentaAgricultor = Left(TipoAgricultor.TPA_ctaprov.Valor, 6) + Fnc0(Me.LIQ_Idagricultor.Valor, 5)
        CuentaAnticipos = Left(TipoAgricultor.TPA_ctaanti.Valor, 6) + Fnc0(Me.LIQ_Idagricultor.Valor, 5)
        CuentaSuministros = Left(TipoAgricultor.TPA_ctasumi.Valor, 6) + Fnc0(Me.LIQ_Idagricultor.Valor, 5)
        CuentaPortes = Left(TipoAgricultor.TPA_ctaotros.Valor, 6) + Fnc0(Me.LIQ_Idagricultor.Valor, 5)
        CuentaCartera = Left(TipoAgricultor.TPA_CtaCartera.Valor, 6) + Fnc0(Me.LIQ_Idagricultor.Valor, 5)

        RegCuentaCartera = CuentaCartera
        RegSituacion = Me.LIQ_SituacionCartera.Valor
        RegTipoDocumento = Me.LIQ_TipoDocumento.Valor
        RegFechaVto = Me.LIQ_FechaVto.Valor
        RegCuentaAgricultor = CuentaAgricultor
   

        Dim Ifac As Decimal = VaDec(Me.LIQ_ImpFacturas.Valor) + VaDec(Me.LIQ_ImpAnterior.Valor)
        Dim IAnt As Decimal = VaDec(Me.LIQ_DtoAnticipos.Valor)
        Dim ISum As Decimal = VaDec(Me.LIQ_DtoSumi.Valor)
        Dim IPor As Decimal = VaDec(Me.LIQ_DtoPortes.Valor)
        Dim Ipag As Decimal = VaDec(Me.LIQ_Apagar.Valor)



        If Ifac <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "LIQ " & NombreAgricultor
            asiLin.Cuenta = CuentaAgricultor
            asiLin.DH = "D"
            asiLin.Documento = Me.LIQ_serie.Valor & " " & Me.LIQ_numero.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Ifac.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        If IAnt <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "LIQ " & NombreAgricultor
            asiLin.Cuenta = CuentaAnticipos
            asiLin.DH = "H"
            asiLin.Documento = Me.LIQ_serie.Valor & " " & Me.LIQ_numero.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(IAnt.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        If ISum <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "LIQ " & NombreAgricultor
            asiLin.Cuenta = CuentaSuministros
            asiLin.DH = "H"
            asiLin.Documento = Me.LIQ_serie.Valor & " " & Me.LIQ_numero.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(ISum.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        If IPor <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "LIQ " & NombreAgricultor
            asiLin.Cuenta = CuentaPortes
            asiLin.DH = "H"
            asiLin.Documento = Me.LIQ_serie.Valor & " " & Me.LIQ_numero.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(IPor.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If


        Dim bCartera As Boolean = True
        'If VaDate(Me.LIQ_FechaVto.Valor) > VaDate("") Then
        '    'el asiento lo hacemos contra la cuenta de cartera, en lugar de contra la cuenta del banco
        '    bCartera = True
        'End If


        If Ipag <> 0 Then


            Dim DocumentoCartera As String = ""
            Select Case VaInt(Me.LIQ_IdFormaPago.Valor)
                Case E_Agricultores.FormasPago.Talon
                    DocumentoCartera = "T-" + Me.LIQ_Nutalon.Valor
                Case E_Agricultores.FormasPago.Pagare
                    DocumentoCartera = "P-" + Me.LIQ_Nutalon.Valor
                Case E_Agricultores.FormasPago.Transferencia
                    DocumentoCartera = "TR-" + Me.LIQ_Nutalon.Valor
                    RegCuentaAgricultor = RegCuentaCartera
                    RegCuentaCartera = ""
                    RegTipoDocumento = Agricultores.AGR_TipoDocumento.Valor
                    RegSituacion = Agricultores.AGR_SituacionCartera.Valor
                    RegFechaVto = Me.LIQ_fecha.Valor

            End Select


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "LIQ " & NombreAgricultor
            'If bCartera Then
            asiLin.Cuenta = CuentaCartera
            'Else
            'asiLin.Cuenta = CuentaBanco
            'End If
            asiLin.DH = "H"
            asiLin.Documento = DocumentoCartera
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Ipag.ToString("0.00"))
            asiLin.SRPC = ""


            If VaDec(Ipag) <> 0 And bCartera Then


                Dim EmitirPago As String = "N"

                'If TipoDocumento.LeerId(Me.LIQ_TipoDocumento.Valor) = True Then
                If TipoDocumento.LeerId(RegTipoDocumento) = True Then
                    EmitirPago = TipoDocumento.EmitirPago.Valor
                End If

                asiLin.SRPC = "P"
                asiLin.clcartera = New Contabilizacion.clCartera
                asiLin.clcartera.Cuenta = RegCuentaAgricultor
                asiLin.clcartera.CuentaCartera = RegCuentaCartera
                asiLin.clcartera.Documento = DocumentoCartera
                asiLin.clcartera.Fecha = Me.LIQ_fecha.Valor
                asiLin.clcartera.PagoCobro = "P"

                Dim lcartera As New Contabilizacion.clCartera.DesgloseCartera
                lcartera.IdBanco = RegSituacion
                lcartera.IdTipo = RegTipoDocumento
                lcartera.Importe = VaDec(Ipag)
                lcartera.Vencimiento = RegFechaVto

                If EmitirPago = "S" Then
                    lcartera.Estado = "1"
                Else
                    lcartera.Estado = "2"
                End If

                asiLin.clcartera.LineasCartera.Add(lcartera)

            End If


            c.ListaClAsientosLineas.Add(asiLin)
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.LIQ_idempresa.Valor)), VaInt(Me.LIQ_IdAsiento.Valor), VaInt(Me.LIQ_idcentro.Valor), CDate(Me.LIQ_fecha.Valor), Me.LIQ_ejercicio.Valor, VaInt(Me.LIQ_idcentro.Valor), E_Asientos.AsientoLiquidacion, IdLiqui)

        If Resultado > 0 Then
            Me.LIQ_IdAsiento.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado






    End Function
End Class
