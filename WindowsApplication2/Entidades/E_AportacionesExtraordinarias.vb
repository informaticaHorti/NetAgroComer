Public Class E_AportacionesExtraordinarias
    Inherits Cdatos.Entidad

    Public APX_Id As Cdatos.bdcampo
    Public APX_FechaAportacion As Cdatos.bdcampo
    Public APX_IdAgricultor As Cdatos.bdcampo
    Public APX_AportacionFondo As Cdatos.bdcampo
    Public APX_AportacionNoFondoMasIVA As Cdatos.bdcampo
    Public APX_TotalAportacion As Cdatos.bdcampo
    Public APX_IdBanco As Cdatos.bdcampo
    Public APX_Concepto As Cdatos.bdcampo
    Public APX_IdAsiento_Hortichuelas As Cdatos.bdcampo
    Public APX_IdAsiento_HortiHorto As Cdatos.bdcampo

    Public APX_AnnoFondo As Cdatos.bdcampo

    Public APX_IdUsuarioLog As Cdatos.bdcampo
    Public APX_FechaLog As Cdatos.bdcampo
    Public APX_HoraLog As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "AportacionesExtraordinarias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            APX_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            APX_FechaAportacion = New Cdatos.bdcampo(CodigoEntidad & "FechaAportacion", Cdatos.TiposCampo.Fecha, 10)
            APX_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.EnteroPositivo, 5)
            APX_AportacionFondo = New Cdatos.bdcampo(CodigoEntidad & "AportacionFondo", Cdatos.TiposCampo.Importe, 18, 2)
            APX_AportacionNoFondoMasIVA = New Cdatos.bdcampo(CodigoEntidad & "AportacionNoFondoMasIVA", Cdatos.TiposCampo.Importe, 18, 2)
            APX_TotalAportacion = New Cdatos.bdcampo(CodigoEntidad & "TotalAportacion", Cdatos.TiposCampo.Importe, 18, 2)
            APX_IdBanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.EnteroPositivo, 3)
            APX_Concepto = New Cdatos.bdcampo(CodigoEntidad & "Concepto", Cdatos.TiposCampo.Cadena, 250)
            APX_IdAsiento_Hortichuelas = New Cdatos.bdcampo(CodigoEntidad & "IdAsiento_Hortichuelas", Cdatos.TiposCampo.EnteroPositivo, 8)
            APX_IdAsiento_HortiHorto = New Cdatos.bdcampo(CodigoEntidad & "IdAsiento_HortiHorto", Cdatos.TiposCampo.EnteroPositivo, 8)

            APX_AnnoFondo = New Cdatos.bdcampo(CodigoEntidad & "AnnoFondo", Cdatos.TiposCampo.EnteroPositivo, 4)

            APX_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            APX_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            APX_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        '_btBusca.CL_CampoOrden = "FechaAportacion"
        '_btBusca.CL_ConsultaSql = "SELECT APX_Id as Numero, APX_Nombre as Nombre from zonas"
        '_btBusca.CL_ControlAsociado = Nothing
        '_btBusca.CL_DevuelveCampo = "Idzona"
        '_btBusca.CL_Entidad = Me
        '_btBusca.CL_Filtro = Nothing
        '_btBusca.Name = "BtBuscaZonas"
        '_btBusca.cl_formu = "FrmZonas"
        '_btBusca.CL_ch1000 = False
        '_btBusca.cl_formu = "FrmZonas"


        Dim Agricultores As New E_Agricultores(idUsuario, cn)
        Dim Bancos As New E_Bancos(idUsuario, ConexCtb(VaInt(MiMaletin.IdEmpresaCTB)))


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.APX_Id, "Numero")
        consulta.SelCampo(Me.APX_FechaAportacion, "FechaAportacion")
        consulta.SelCampo(Me.APX_IdAgricultor, "CodAgr")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Me.APX_IdAgricultor, Agricultores.AGR_IdAgricultor)
        consulta.SelCampo(Me.APX_TotalAportacion, "TotalAportacion")
        consulta.SelCampo(Me.APX_Concepto, "Concepto")
        consulta.SelCampo(Me.APX_IdBanco, "IdBanco")
        consulta.SelCampo(Bancos.Nombre, "Banco")

        _btBusca.Params("IdBanco", , -1)
        _btBusca.Params("TotalAportacion", , , , "#,##0.00")

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultores.AGR_IdAgricultor
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "FechaAportacion"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Numero"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAportacionEx"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = True


        _btBusca.ParamConsultaAlb(consulta, "APX_FechaAportacion DESC", Me.APX_IdAgricultor, Me.APX_FechaAportacion, Nothing)


    End Sub



    Public Function Contabiliza(ByVal IdAportacion As Integer, ByRef IdAsientoHortiHorto As Integer) As Integer


        Dim Resultado As Integer = 0
        IdAsientoHortiHorto = 0



        If Me.LeerId(IdAportacion) = False Then
            Return 0
        End If


        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        If Not Agricultores.LeerId(Me.APX_IdAgricultor.Valor) Then
            MsgBox("Error al generar el asiento: no se puede leer el agricultor con código " & Me.APX_IdAgricultor.Valor)
            Return 0
        End If

        Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If Not Bancos.LeerId(Me.APX_IdBanco.Valor) Then
            MsgBox("Error al generar el asiento: no se puede leer el banco con código " & Me.APX_IdBanco.Valor)
            Return 0
        End If



        Dim AñoNatural As String = VaDate(Me.APX_FechaAportacion.Valor).ToString("yy")
        Dim CtaBancariaFondo As String = Bancos.CuentaTesoreria.Valor
        Dim CodigoAgricultor As String = VaInt(Me.APX_IdAgricultor.Valor).ToString("00000")

        Dim Concepto As String = Me.APX_Concepto.Valor
        Dim Documento As String = Me.APX_Id.Valor

        Dim AportacionFondo As Decimal = VaDec(Me.APX_AportacionFondo.Valor)
        Dim AportacionNoFondoMasIVA As Decimal = VaDec(Me.APX_AportacionNoFondoMasIVA.Valor)
        Dim TotalAportacion As Decimal = VaDec(Me.APX_TotalAportacion.Valor)

        


        Dim IdEmpresa As Integer = VaInt(Agricultores.AGR_idempresa.Valor)

        Select Case IdEmpresa

            Case 1
                'Hortichuelas
                Resultado = Contabiliza_Hortichuelas(IdAportacion, Concepto, Documento, AñoNatural, CtaBancariaFondo, CodigoAgricultor, AportacionFondo, AportacionNoFondoMasIVA, TotalAportacion)

            Case 2
                'HortiHorto
                Resultado = Contabiliza_HortiHorto_1(IdAportacion, Concepto, Documento, AñoNatural, CtaBancariaFondo, AportacionFondo, AportacionNoFondoMasIVA, TotalAportacion)
                IdAsientoHortiHorto = Contabiliza_HortiHorto_2(IdAportacion, Concepto, Documento, AñoNatural, CodigoAgricultor, AportacionFondo, AportacionNoFondoMasIVA)

        End Select




        Return Resultado


    End Function


    Private Function Contabiliza_Hortichuelas(IdAportacion As Integer, Concepto As String, Documento As String, AñoNatural As String, CtaBancariaFondo As String, CodigoAgricultor As String,
                                              AportacionFondo As Decimal, AportacionNoFondoMasIVA As Decimal, TotalAportacion As Decimal) As Integer


        Dim Resultado As Integer = 0


        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas


        Dim IdEmpresa As Integer = 1

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"


        'Cuentas con cargos al haber
        Dim CtaAportacionFondo As String = "5540" & AñoNatural & CodigoAgricultor
        Dim CtaAportacionNoFondoMasIVA As String = "5547" & AñoNatural & CodigoAgricultor



        If TotalAportacion <> 0 Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaBancariaFondo
            asiLin.DH = "D"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = TotalAportacion
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaAportacionFondo
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionFondo
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaAportacionNoFondoMasIVA
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionNoFondoMasIVA
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(IdEmpresa), VaInt(Me.APX_IdAsiento_Hortichuelas), MiMaletin.IdCentro, CDate(Me.APX_FechaAportacion.Valor), MiMaletin.Ejercicio, MiMaletin.IdPuntoVenta, E_Asientos.AsientoAportacionesExternas, IdAportacion)

        If Resultado > 0 Then
            Me.APX_IdAsiento_Hortichuelas.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function



    Private Function Contabiliza_HortiHorto_1(IdAportacion As Integer, Concepto As String, Documento As String, AñoNatural As String, CtaBancariaFondo As String,
                                              AportacionFondo As Decimal, AportacionNoFondoMasIVA As Decimal, TotalAportacion As Decimal) As Integer

        Dim Resultado As Integer = 0



        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdEmpresa As Integer = 1

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"


        'Cuentas con cargos al haber
        Dim CtaAportacionFondo As String = "5540" & AñoNatural & "00002"
        Dim CtaAportacionNoFondoMasIVA As String = "5547" & AñoNatural & "00002"


        If TotalAportacion <> 0 Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaBancariaFondo
            asiLin.DH = "D"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = TotalAportacion
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaAportacionFondo
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionFondo
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaAportacionNoFondoMasIVA
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionNoFondoMasIVA
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(IdEmpresa), VaInt(Me.APX_IdAsiento_Hortichuelas), MiMaletin.IdCentro, CDate(Me.APX_FechaAportacion.Valor), MiMaletin.Ejercicio, MiMaletin.IdPuntoVenta, E_Asientos.AsientoAportacionesExternas, IdAportacion)

        If Resultado > 0 Then
            Me.APX_IdAsiento_Hortichuelas.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado

    End Function


    Private Function Contabiliza_HortiHorto_2(IdAportacion As Integer, Concepto As String, Documento As String, AñoNatural As String, CodigoAgricultor As String,
                                              AportacionFondo As Decimal, AportacionNoFondoMasIVA As Decimal) As Integer

        Dim Resultado As Integer = 0


        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdEmpresa As Integer = 2

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"


        'Cuentas con cargos al haber
        Dim CtaOrigenAportacionFondo As String = "5540" & AñoNatural & "00000"
        Dim CtaOrigenAportacionNoFondoMasIVA As String = "5547" & AñoNatural & "00000"
        Dim CtaDestinoAportacionFondo As String = "5540" & AñoNatural & CodigoAgricultor
        Dim CtaDestinoAportacionNoFondoMasIVA As String = "5547" & AñoNatural & CodigoAgricultor


        If AportacionFondo <> 0 Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaOrigenAportacionFondo
            asiLin.DH = "D"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionFondo
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaDestinoAportacionFondo
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionFondo
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If AportacionNoFondoMasIVA <> 0 Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaOrigenAportacionNoFondoMasIVA
            asiLin.DH = "D"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionNoFondoMasIVA
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Concepto
            asiLin.Cuenta = CtaDestinoAportacionNoFondoMasIVA
            asiLin.DH = "H"
            asiLin.Documento = Documento
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = AportacionNoFondoMasIVA
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(IdEmpresa), VaInt(Me.APX_IdAsiento_HortiHorto), MiMaletin.IdCentro, CDate(Me.APX_FechaAportacion.Valor), MiMaletin.Ejercicio, MiMaletin.IdPuntoVenta, E_Asientos.AsientoAportacionesExternas, IdAportacion)

        If Resultado > 0 Then
            Me.APX_IdAsiento_HortiHorto.Valor = Resultado.ToString
            Me.Actualizar()
        End If



        Return Resultado

    End Function


End Class
