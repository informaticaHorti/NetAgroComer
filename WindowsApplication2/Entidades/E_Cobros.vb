Public Class E_Cobros
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public COB_IdCobro As Cdatos.bdcampo
    Public COB_FechaCobro As Cdatos.bdcampo
    Public COB_FechaCtb As Cdatos.bdcampo
    Public COB_IdCentro As Cdatos.bdcampo
    Public COB_IdCliente As Cdatos.bdcampo
    Public COB_IdDivisa As Cdatos.bdcampo
    Public COB_Cambio As Cdatos.bdcampo
    Public COB_CobradoDivisa As Cdatos.bdcampo
    Public COB_CobradoEuros As Cdatos.bdcampo
    Public COB_ImporteEfectivo As Cdatos.bdcampo
    Public COB_CuentaEfectivo As Cdatos.bdcampo
    Public COB_CtaGastosFinan As Cdatos.bdcampo
    Public COB_CtaDifCambio As Cdatos.bdcampo
    Public COB_CtaOtrosGtos1 As Cdatos.bdcampo
    Public COB_CtaOtrosGtos2 As Cdatos.bdcampo
    Public COB_CuentaVencimiento As Cdatos.bdcampo
    Public COB_ImporteGtosFinan As Cdatos.bdcampo
    Public COB_ImporteDifCambio As Cdatos.bdcampo
    Public COB_ImporteGtos1 As Cdatos.bdcampo
    Public COB_ImporteGtos2 As Cdatos.bdcampo
    Public COB_Concepto As Cdatos.bdcampo
    Public COB_CuentaDifCobro As Cdatos.bdcampo
    Public COB_ImporteDifCobro As Cdatos.bdcampo
    Public COB_idasiento As Cdatos.bdcampo
    Public COB_IdActividad As Cdatos.bdcampo
    Public COB_IdSeccion As Cdatos.bdcampo
    Public COB_IdDepartamento As Cdatos.bdcampo
    Public COB_IdSubdepartamento As Cdatos.bdcampo
    Public COB_Ejercicio As Cdatos.bdcampo
    Public COB_NumeroCobro As Cdatos.bdcampo
    Public COB_IdFPago As Cdatos.bdcampo
    Public COB_IdBanco As Cdatos.bdcampo
    Public COB_ConceptoDifCobro As Cdatos.bdcampo
    Public COB_ConceptoGtosFinan As Cdatos.bdcampo
    Public COB_ConceptoOtrosGtos1 As Cdatos.bdcampo
    Public COB_ConceptoOtrosGtos2 As Cdatos.bdcampo
    Public COB_ConceptoDifCambio As Cdatos.bdcampo
    Public COB_IdPuntoVenta As Cdatos.bdcampo
    Public COB_Idconcepto1 As Cdatos.bdcampo
    Public COB_Idconcepto2 As Cdatos.bdcampo
    Public COB_Idconcepto3 As Cdatos.bdcampo
    Public COB_IdBancoTalon As Cdatos.bdcampo
    Public COB_SerieTalon As Cdatos.bdcampo
    Public COB_NumeroTalon As Cdatos.bdcampo
    Public COB_IdEmpresa As Cdatos.bdcampo
    Public COB_IdSituacion As Cdatos.bdcampo

    Public COB_IdUsuarioLog As Cdatos.bdcampo
    Public COB_FechaLog As Cdatos.bdcampo
    Public COB_HoraLog As Cdatos.bdcampo



	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "Cobros"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            COB_IdCobro = New Cdatos.bdcampo(CodigoEntidad & "IdCobro", Cdatos.TiposCampo.Entero, 10, 0, True)
            COB_FechaCobro = New Cdatos.bdcampo(CodigoEntidad & "FechaCobro", Cdatos.TiposCampo.Fecha, 8)
            COB_FechaCtb = New Cdatos.bdcampo(CodigoEntidad & "FechaCtb", Cdatos.TiposCampo.Fecha, 8)
            COB_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 3)
            COB_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            COB_IdDivisa = New Cdatos.bdcampo(CodigoEntidad & "IdDivisa", Cdatos.TiposCampo.Entero, 2)
            COB_Cambio = New Cdatos.bdcampo(CodigoEntidad & "Cambio", Cdatos.TiposCampo.Importe, 12, 6)
            COB_CobradoDivisa = New Cdatos.bdcampo(CodigoEntidad & "CobradoDivisa", Cdatos.TiposCampo.Importe, 18, 2)
            COB_CobradoEuros = New Cdatos.bdcampo(CodigoEntidad & "CobradoEuros", Cdatos.TiposCampo.Importe, 18, 2)
            COB_ImporteEfectivo = New Cdatos.bdcampo(CodigoEntidad & "ImporteEfectivo", Cdatos.TiposCampo.Importe, 18, 2)
            COB_CuentaEfectivo = New Cdatos.bdcampo(CodigoEntidad & "CuentaEfectivo", Cdatos.TiposCampo.Cuenta, 11)
            COB_CtaGastosFinan = New Cdatos.bdcampo(CodigoEntidad & "CtaGastosFinan", Cdatos.TiposCampo.Cuenta, 11)
            COB_CtaDifCambio = New Cdatos.bdcampo(CodigoEntidad & "CtaDifCambio", Cdatos.TiposCampo.Cuenta, 11)
            COB_CtaOtrosGtos1 = New Cdatos.bdcampo(CodigoEntidad & "CtaOtrosGtos1", Cdatos.TiposCampo.Cuenta, 11)
            COB_CtaOtrosGtos2 = New Cdatos.bdcampo(CodigoEntidad & "CtaOtrosGtos2", Cdatos.TiposCampo.Cuenta, 11)
            COB_CuentaVencimiento = New Cdatos.bdcampo(CodigoEntidad & "CuentaVencimiento", Cdatos.TiposCampo.Cuenta, 11)
            COB_ImporteGtosFinan = New Cdatos.bdcampo(CodigoEntidad & "ImporteGtosFinan", Cdatos.TiposCampo.Importe, 19, 2)
            COB_ImporteDifCambio = New Cdatos.bdcampo(CodigoEntidad & "ImporteDifCambio", Cdatos.TiposCampo.Importe, 19, 2)
            COB_ImporteGtos1 = New Cdatos.bdcampo(CodigoEntidad & "ImporteGtos1", Cdatos.TiposCampo.Importe, 19, 2)
            COB_ImporteGtos2 = New Cdatos.bdcampo(CodigoEntidad & "ImporteGtos2", Cdatos.TiposCampo.Importe, 19, 2)
            COB_Concepto = New Cdatos.bdcampo(CodigoEntidad & "Concepto", Cdatos.TiposCampo.Cadena, 50)
            COB_CuentaDifCobro = New Cdatos.bdcampo(CodigoEntidad & "CuentaDifCobro", Cdatos.TiposCampo.Cuenta, 11)
            COB_ImporteDifCobro = New Cdatos.bdcampo(CodigoEntidad & "ImporteDifCobro", Cdatos.TiposCampo.Importe, 18, 2)
            COB_idasiento = New Cdatos.bdcampo(CodigoEntidad & "idasiento", Cdatos.TiposCampo.Entero, 6)
            COB_IdActividad = New Cdatos.bdcampo(CodigoEntidad & "IdActividad", Cdatos.TiposCampo.Entero, 2)
            COB_IdSeccion = New Cdatos.bdcampo(CodigoEntidad & "IdSeccion", Cdatos.TiposCampo.Entero, 2)
            COB_IdDepartamento = New Cdatos.bdcampo(CodigoEntidad & "IdDepartamento", Cdatos.TiposCampo.Entero, 2)
            COB_IdSubdepartamento = New Cdatos.bdcampo(CodigoEntidad & "IdSubdepartamento", Cdatos.TiposCampo.Entero, 2)
            COB_Ejercicio = New Cdatos.bdcampo(CodigoEntidad & "Ejercicio", Cdatos.TiposCampo.Entero, 2)
            COB_NumeroCobro = New Cdatos.bdcampo(CodigoEntidad & "NumeroCobro", Cdatos.TiposCampo.Cadena, 6)
            COB_IdFPago = New Cdatos.bdcampo(CodigoEntidad & "IdFPago", Cdatos.TiposCampo.Entero, 3)
            COB_IdBanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.Entero, 2)
            COB_ConceptoDifCobro = New Cdatos.bdcampo(CodigoEntidad & "ConceptoDifCobro", Cdatos.TiposCampo.Cadena, 50)
            COB_ConceptoGtosFinan = New Cdatos.bdcampo(CodigoEntidad & "ConceptoGtosFinan", Cdatos.TiposCampo.Cadena, 50)
            COB_ConceptoOtrosGtos1 = New Cdatos.bdcampo(CodigoEntidad & "ConceptoOtrosGtos1", Cdatos.TiposCampo.Cadena, 50)
            COB_ConceptoOtrosGtos2 = New Cdatos.bdcampo(CodigoEntidad & "ConceptoOtrosGtos2", Cdatos.TiposCampo.Cadena, 50)
            COB_ConceptoDifCambio = New Cdatos.bdcampo(CodigoEntidad & "ConceptoDifCambio", Cdatos.TiposCampo.Cadena, 50)
            COB_IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "IdPuntoVenta", Cdatos.TiposCampo.Entero, 3)
            COB_Idconcepto1 = New Cdatos.bdcampo(CodigoEntidad & "IdConcepto1", Cdatos.TiposCampo.Entero, 3)
            COB_Idconcepto2 = New Cdatos.bdcampo(CodigoEntidad & "IdConcepto2", Cdatos.TiposCampo.Entero, 3)
            COB_Idconcepto3 = New Cdatos.bdcampo(CodigoEntidad & "IdConcepto3", Cdatos.TiposCampo.Entero, 3)
            COB_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "IdEmpresa", Cdatos.TiposCampo.Entero, 2)
            COB_IdSituacion = New Cdatos.bdcampo(CodigoEntidad & "IdSituacion", Cdatos.TiposCampo.Entero, 2)

            COB_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            COB_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            COB_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()



            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.COB_NumeroCobro)


            '---------------- boton busqueda
            Dim Clientes As New E_Clientes(idUsuario, cn)
            Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            Dim Consulta As New Cdatos.E_select

            Consulta.SelCampo(Me.COB_IdCobro, "IdCobro")
            Consulta.SelCampo(Me.COB_NumeroCobro, "NumeroCobro")
            Consulta.SelCampo(Me.COB_FechaCobro, "FechaCobro")
            Consulta.SelCampo(Me.COB_Ejercicio, "Ejercicio")
            Consulta.SelCampo(Centros.Nombre, "Centro", Me.COB_IdCentro)
            Consulta.SelCampo(Me.COB_IdCliente, "IdCliente")
            Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.COB_IdCliente)
            Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
            Consulta.SelCampo(oBloqueo, "Bloqueo")
            Dim oCobradoDivisa As New Cdatos.bdcampo("@(SELECT SUM(CBL_ImporteCobradoDivisa) FROM CobrosLineas WHERE CBL_IdCobro = COB_IdCobro)", Me.COB_CobradoDivisa.TipoBd, Me.COB_CobradoDivisa.Longitud, Me.COB_CobradoDivisa.Decimales)
            Consulta.SelCampo(oCobradoDivisa, "CobradoDivisa")
            'Consulta.SelCampo(Me.COB_CobradoDivisa, "CobradoDivisa")


            '_btBusca.CL_CampoOrden = "FechaCobro"
            '_btBusca.CL_ConsultaSql = Consulta.SQL + " order by fechacobro desc"
            '_btBusca.CL_ControlAsociado = Nothing
            '_btBusca.CL_DevuelveCampo = "NumeroCobro"
            '_btBusca.CL_Entidad = Me
            '_btBusca.CL_Filtro = Nothing
            '_btBusca.cl_formu = Nothing
            '_btBusca.Name = "BtBuscaCobros"
            '_btBusca.CL_ch1000 = True
            ''_btBusca.DevuelveId = True


            _btBusca.Params("IdCobro", , -1)
            _btBusca.Params("CobradoDivisa", , , , "#,##0.00")


            _btBusca.CL_BuscaAlb = True ' busqueda por codigo
            _btBusca.CL_campocodigo = Clientes.CLI_Codigo
            _btBusca.CL_camponombre = Clientes.CLI_Nombre
            _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
            _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



            _btBusca.CL_CampoOrden = "FechaCobro DESC"
            _btBusca.CL_ConsultaSql = Consulta.SQL
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdCobro"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.Name = "BtBuscaCobros"
            _btBusca.CL_ch1000 = True
            _btBusca.cl_formu = Nothing
            '_btBusca.CL_xCentro = True


            _btBusca.ParamConsultaAlb(Consulta, "COB_FechaCobro DESC", Me.COB_IdCliente, Me.COB_FechaCobro, Me.COB_IdCentro)

            Dim Dc As New Dictionary(Of Object, Color)
            Dc("S") = Color.Red
            Dc("N") = Color.LimeGreen
            _btBusca.Params("Bloqueo", "B", 15, , , Dc)
            '_btBusca.CL_ParamBusqueda("Bloqueado").


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function LeerCobro(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, ByVal numcobro As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0

        Dim SQL As String


        CONSULTA.SelTodos(Me)
        CONSULTA.WheCampo(Me.COB_IdEmpresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.COB_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.COB_IdCentro, "=", Centro.ToString)

        CONSULTA.WheCampo(Me.COB_NumeroCobro, "=", numcobro)
        SQL = CONSULTA.SQL
        Dt = Me.MiConexion.ConsultaSQL(SQL)
        VaciaEntidad()
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

    Public Function ExisteCobro(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, ByVal numcobro As String) As Boolean

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Boolean = False

        Dim SQL As String


        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.COB_IdEmpresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.COB_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.COB_IdCentro, "=", Centro.ToString)

        CONSULTA.WheCampo(Me.COB_NumeroCobro, "=", numcobro)
        SQL = CONSULTA.SQL

        Dt = Me.MiConexion.ConsultaSQL(SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = True
                End If
            End If
        End If


        Return ret

    End Function



    Public Function MaxIdCampa(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer

        Try

            Dim max As Integer = 0
            Dim existe As Boolean = True

            While existe = True
                max = ValorMaximo(idempresa.ToString + "_" + Campa.ToString + "_" + Centro.ToString, vmax)
                existe = ExisteCobro(idempresa, Campa, Centro, max)
            End While

            Return max

        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de cobros", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function



    Private Sub E_Cobros_EliminaHijos() Handles Me.EliminaHijos

        If VaInt(Me.COB_IdCobro.Valor) > 0 Then

            Dim sql As String
            Dim dt As New DataTable
            Dim cobros_lineas As New E_CobrosLineas(Idusuario, cn)
            Dim cobros_vto As New E_CobrosVencimientos(Idusuario, cn)

            sql = "SELECT * FROM CobrosLineas WHERE CBL_IdCobro = " + Me.COB_IdCobro.Valor

            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    cobros_lineas.CargaCampos(rw)
                    cobros_lineas.Eliminar()
                Next
            End If


            sql = "SELECT * FROM CobrosVencimientos WHERE CVT_IdCobro=" + Me.COB_IdCobro.Valor

            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    cobros_vto.CargaCampos(rw)
                    cobros_vto.Eliminar()
                Next
            End If

        End If


    End Sub

    Public Function Contabiliza(ByVal Idcobro As Integer, ByVal VEjervb6 As String, ByRef rAsientoVb6 As String, ByVal vb6 As Boolean) As Integer


        Dim Resultado As Integer = 0


        Dim asiLin As New Contabilizacion.clAsientoLineas
        Dim Facturas As New E_Facturas(Idusuario, cn)
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim Actividadcobro As Integer
        Dim Seccioncobro As Integer
        Dim Icobrado As Decimal
        Dim c As New Contabilizacion.clAsientos
        Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        'Dim ExentoIVA As String = "N"
        'Dim RecargoEq As String = "N"



        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"


        If Me.LeerId(Idcobro) = False Then
            MsgBox("Error al leer el cobro con Id: " & Idcobro)
            Return 0
        End If



        Actividadcobro = COB_IdActividad.Valor
        Seccioncobro = COB_IdSeccion.Valor


        
        Dim CtaClienteCobro As String = ""
        Dim Clientes As New E_Clientes(Idusuario, cn)
        If Clientes.LeerId(Me.COB_IdCliente.Valor) Then

            Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
            If TiposClientes.LeerId(Clientes.CLI_IdTipo.Valor) Then
                CtaClienteCobro = TiposClientes.TPC_ctacliente.Valor & "00000000000"
                CtaClienteCobro = CtaClienteCobro.Substring(0, 5) & VaInt(Me.COB_IdCliente.Valor).ToString("000000")
            End If

        Else
            MsgBox("No se encuentra el cliente con Id: " & Me.COB_IdCliente.Valor)
            Return 0
        End If




        Dim sql As String = "SELECT CBL_IdFactura as IdFactura, CBL_ImporteCobradoDivisa as ImporteCobradoDivisa, CBL_Cambio as Cambio" & vbCrLf
        sql = sql & " FROM CobrosLineas WHERE CBL_IdCobro = " & Idcobro


        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

        For Each dr As DataRow In dt.Rows

            asiLin = New Contabilizacion.clAsientoLineas

            asiLin.DH = "H"
            asiLin.Concepto = "COBRO " & Me.COB_NumeroCobro.Valor & ". S/PAGO N/FRA."
            asiLin.idConcepto = 0
            asiLin.Importe = dr("ImporteCobradoDivisa") * VaDec(dr("Cambio"))
            asiLin.SRPC = ""

            If Facturas.LeerId(dr("IdFactura")) Then

                If PuntoVenta.LeerId(Facturas.FRA_idpuntoventa.Valor) Then
                    asiLin.IdActividad = PuntoVenta.IdActividad.Valor
                    asiLin.IdSeccion = PuntoVenta.IdSeccion.Valor
                End If

                asiLin.Documento = Facturas.FRA_serie.Valor & " " & Facturas.FRA_factura.Valor
                asiLin.IdDepartamento = IdDepartamento
                asiLin.IdSubDepartamento = IdSubDepartamento

            End If


            'Obtenemos la cuenta del cliente de la factura
            Dim CtaCliente As String = ""
            If Clientes.LeerId(Me.COB_IdCliente.Valor) Then

                Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
                If TiposClientes.LeerId(Clientes.CLI_IdTipo.Valor) Then
                    CtaCliente = TiposClientes.TPC_ctacliente.Valor & "00000000000"
                    CtaCliente = CtaCliente.Substring(0, 5) & VaInt(Facturas.FRA_idcliente.Valor).ToString("000000")
                End If

            Else
                MsgBox("No se encuentra el cliente con Id: " & Me.COB_IdCliente.Valor)
                Return 0
            End If


            asiLin.Cuenta = CtaCliente
            asiLin.idConcepto = 0
            asiLin.Importe = dr("ImporteCobradoDivisa") * VaDec(dr("Cambio"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
            Icobrado = dr("ImporteCobradoDivisa") * VaDec(dr("Cambio"))

        Next
        ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '  CuentaEfectivo
        If VaDec(Me.COB_ImporteEfectivo.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Me.COB_Concepto.Valor
            asiLin.Cuenta = Me.COB_CuentaEfectivo.Valor
            asiLin.DH = "D"
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(Me.COB_ImporteEfectivo.Valor)
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        'GastosFinanciero
        If VaDec(Me.COB_ImporteGtosFinan.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Me.COB_ConceptoGtosFinan.Valor
            asiLin.Cuenta = Me.COB_CtaGastosFinan.Valor
            asiLin.DH = "D"
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(Me.COB_ImporteGtosFinan.Valor)
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If


        'DifCambio
        If VaDec(Me.COB_ImporteDifCambio.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Me.COB_ConceptoDifCambio.Valor
            asiLin.Cuenta = Me.COB_CtaDifCambio.Valor
            asiLin.DH = "D"
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(Me.COB_ImporteDifCambio.Valor)
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        'OtrosGastos1
        If VaDec(Me.COB_ImporteGtos1.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Me.COB_ConceptoOtrosGtos1.Valor
            asiLin.Cuenta = Me.COB_CtaOtrosGtos1.Valor
            asiLin.DH = "D"
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(Me.COB_ImporteGtos1.Valor)
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        'OtrosGastos2
        If VaDec(Me.COB_ImporteGtos2.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = Me.COB_ConceptoOtrosGtos2.Valor
            asiLin.Cuenta = Me.COB_CtaOtrosGtos2.Valor
            asiLin.DH = "D"
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(Me.COB_ImporteGtos2.Valor)
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If


        'Dif cobro
        If VaDec(Me.COB_ImporteDifCobro.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "Diferencia cobro"
            asiLin.Cuenta = Me.COB_CuentaDifCobro.Valor
            Select Case VaDec(Me.COB_ImporteDifCobro.Valor)
                Case Is >= 0
                    asiLin.DH = "D"
                    asiLin.Importe = VaDec(Me.COB_ImporteDifCobro.Valor)
                Case Else
                    asiLin.DH = "H"
                    asiLin.Importe = -VaDec(Me.COB_ImporteDifCobro.Valor)
            End Select
            asiLin.Documento = Me.COB_NumeroCobro.Valor
            asiLin.IdActividad = Actividadcobro
            asiLin.idConcepto = 0
            asiLin.IdDepartamento = 0
            asiLin.IdSeccion = Seccioncobro
            asiLin.IdSubDepartamento = 0
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Vencimientos
        Dim CobrosVencimientos As New E_CobrosVencimientos(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelTodos(CobrosVencimientos)
        consulta.WheCampo(CobrosVencimientos.CVT_IdCobro, "=", Idcobro.ToString)

        Dim sqlVto As String = consulta.SQL


        Dim TVto As Decimal = 0
        Dim Pvto As Integer = 0


        Dim dtvto As DataTable = MiConexion.ConsultaSQL(sqlVto)
        For Each rw As DataRow In dtvto.Rows

            CobrosVencimientos.CargaCampos(rw)

            TVto = TVto + VaDec(CobrosVencimientos.CVT_Importe.Valor)
            Pvto = Pvto + 1

            'Sólo la primera vez
            'If VaDec(CobrosVencimientos.CVT_Importe.Valor) <> 0 Then
            If Pvto = 1 Then

                asiLin = New Contabilizacion.clAsientoLineas
                asiLin.Concepto = CobrosVencimientos.CVT_Concepto.Valor
                asiLin.Cuenta = Me.COB_CuentaVencimiento.Valor
                asiLin.DH = "D"
                asiLin.Documento = Me.COB_NumeroCobro.Valor
                asiLin.IdActividad = Actividadcobro
                asiLin.idConcepto = 0
                asiLin.IdDepartamento = 0
                asiLin.IdSeccion = Seccioncobro
                asiLin.IdSubDepartamento = 0
                asiLin.Importe = VaDec(CobrosVencimientos.CVT_Importe.Valor)
                asiLin.SRPC = "C"

                asiLin.clcartera = New Contabilizacion.clCartera
                asiLin.clcartera.Cuenta = CtaClienteCobro
                asiLin.clcartera.CuentaCartera = Me.COB_CuentaVencimiento.Valor
                asiLin.clcartera.Documento = Me.COB_NumeroCobro.Valor
                'asiLin.clcartera.Documento = (rw("CVT_Documento").ToString() & "").Trim
                asiLin.clcartera.Fecha = Me.COB_FechaCobro.Valor
                asiLin.clcartera.PagoCobro = "C"

            End If

            asiLin.Importe = TVto


            'Cartera
            If VaDec(CobrosVencimientos.CVT_Importe.Valor) <> 0 Then
                Dim lcartera As New Contabilizacion.clCartera.DesgloseCartera
                lcartera.IdBanco = Me.COB_IdSituacion.Valor
                lcartera.IdTipo = CobrosVencimientos.CVT_Tipodocumento.Valor & ""
                lcartera.Importe = VaDec(CobrosVencimientos.CVT_Importe.Valor)
                lcartera.Vencimiento = VaDate(CobrosVencimientos.CVT_Fecha.Valor).ToString("dd/MM/yyyy")
                'lcartera.Estado = "1"
                lcartera.Estado = "2"       'Estado
                asiLin.clcartera.LineasCartera.Add(lcartera)
            End If


        Next

        If Pvto > 0 Then
            c.ListaClAsientosLineas.Add(asiLin)
        End If


        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''CONTABILIZAR
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.COB_IdEmpresa.Valor)), VaInt(Me.COB_idasiento.Valor), VaInt(Me.COB_IdCentro.Valor), CDate(Me.COB_FechaCtb.Valor), Me.COB_Ejercicio.Valor, VaInt(Me.COB_IdPuntoVenta.Valor), E_Asientos.AsientoCobro, Idcobro)

        If Resultado > 0 Then
            Me.COB_idasiento.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado

    End Function


    Public Function GeneraDatosImpresion(ByRef TotalCobradoEuros As Decimal) As DataTable

        Dim IdCobro As String = ""
        If Not IsNothing(Me.COB_IdCobro) Then
            IdCobro = Me.COB_IdCobro.Valor & ""
        End If

        If VaInt(IdCobro) < 1 Then
            err.Muestraerror("IdCobro no válido", "Cobros.GeneraDatosImpresion", "No se puede consultar Cobro con Id " & IdCobro)
        End If

        Return GeneraDatosImpresion(IdCobro, TotalCobradoEuros)

    End Function


    Public Function GeneraDatosImpresion(ByVal IdCobro As String, ByRef TotalCobradoEuros As Decimal) As DataTable

        Dim dt As DataTable = Nothing
        TotalCobradoEuros = 0

        If VaInt(IdCobro) > 0 Then


            Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            Dim centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            Dim CobrosLineas As New E_CobrosLineas(Idusuario, cn)
            Dim Facturas As New E_Facturas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(CobrosLineas.CBL_IdLinea, "IdLinea")
            CONSULTA.SelCampo(Facturas.FRA_idpuntoventa, "IdPuntoVenta", CobrosLineas.CBL_IdFactura)
            CONSULTA.SelCampo(PuntoVenta.Nombre, "PV", Facturas.FRA_idpuntoventa, PuntoVenta.IdPuntoVenta)
            CONSULTA.SelCampo(Facturas.FRA_serie, "Serie")
            CONSULTA.SelCampo(Facturas.FRA_factura, "Numero")
            CONSULTA.SelCampo(Nothing, "Factura")
            CONSULTA.SelCampo(Facturas.FRA_fecha, "Fecha")
            CONSULTA.SelCampo(Facturas.FRA_totalfactura, "Importe_Fac")
            CONSULTA.SelCampo(CobrosLineas.CBL_ImporteCobradoDivisa, "Cobrado")
            CONSULTA.SelCampo(Nothing, "Cobrado_Euros")
            CONSULTA.SelCampo(CobrosLineas.CBL_IdFactura, "Idfactura")
            CONSULTA.SelCampo(Facturas.FRA_valorcambio, "ValorCambio")
            CONSULTA.WheCampo(CobrosLineas.CBL_IdCobro, "=", IdCobro)

            Dim Sql As String = CONSULTA.SQL
            Sql = Sql + " order by idlinea"


            dt = MiConexion.ConsultaSQL(Sql)


            For Each dr As DataRow In dt.Rows

                Dim Serie As String = (dr("Serie").ToString & "").Trim
                Dim Factura As String = (dr("Numero").ToString & "").Trim
                If Serie <> "" Then Factura = Serie & "-" & Factura

                dr("Factura") = Factura
                Dim Fecha As String = ""
                If VaDate(dr("Fecha")) > VaDate("") Then Fecha = VaDate(dr("Fecha")).ToString("dd/MM/yyyy")
                dr("Fecha") = Fecha
                dr("Cobrado_Euros") = Math.Round(dr("Cobrado") * VaDec(dr("ValorCambio")), 2)
                TotalCobradoEuros = TotalCobradoEuros + dr("Cobrado_Euros")

            Next

        Else
            dt = New DataTable
        End If


        Return dt

    End Function


End Class




