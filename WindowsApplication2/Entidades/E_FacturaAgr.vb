Public Class E_FacturaAgr
    Inherits Cdatos.Entidad



    Private Const CTA_PUENTE_REA As String = "47200000100"



    Public FGR_Idfactura As Cdatos.bdcampo
    Public FGR_ejercicio As Cdatos.bdcampo
    Public FGR_serie As Cdatos.bdcampo
    Public FGR_numerofactura As Cdatos.bdcampo
    Public FGR_fecha As Cdatos.bdcampo
    Public FGR_Idagricultor As Cdatos.bdcampo
    Public FGR_IdagricultorALB As Cdatos.bdcampo
    Public FGR_Idsemana As Cdatos.bdcampo
    Public FGR_Igenero As Cdatos.bdcampo
    Public FGR_BaseImponible As Cdatos.bdcampo
    Public FGR_iva As Cdatos.bdcampo
    Public FGR_CuotaIva As Cdatos.bdcampo
    Public FGR_fondo As Cdatos.bdcampo
    Public FGR_cuotafondo As Cdatos.bdcampo
    Public FGR_Baseretencion As Cdatos.bdcampo
    Public FGR_retencion As Cdatos.bdcampo
    Public FGR_tiporetencion As Cdatos.bdcampo
    Public FGR_cuotaretencion As Cdatos.bdcampo
    Public FGR_TotalFactura As Cdatos.bdcampo
    Public FGR_IdAsiento As Cdatos.bdcampo
    Public FGR_IdLiquidacion As Cdatos.bdcampo
    Public FGR_porcomision As Cdatos.bdcampo
    Public FGR_comision As Cdatos.bdcampo
    Public FGR_otrosgastos As Cdatos.bdcampo
    Public FGR_idempresa As Cdatos.bdcampo
    Public FGR_idcentro As Cdatos.bdcampo
    Public FGR_PorContingencia As Cdatos.bdcampo
    Public FGR_CuotaContingencia As Cdatos.bdcampo

    Public FGR_FechaAsientoREA As Cdatos.bdcampo
    Public FGR_EjercicioREA As Cdatos.bdcampo
    Public FGR_IdAsientoREA As Cdatos.bdcampo
    Public FGR_IdAsientoREA_Ret As Cdatos.bdcampo

    Public FGR_IdTipoIva As Cdatos.bdcampo

    Public FGR_AnnoFondo As Cdatos.bdcampo


    Public FGR_IdUsuarioLog As Cdatos.bdcampo
    Public FGR_FechaLog As Cdatos.bdcampo
    Public FGR_HoraLog As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "facturaagr"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            FGR_Idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.Entero, 8, 0, True)
            FGR_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "ejercicio", Cdatos.TiposCampo.Entero, 2)
            FGR_serie = New Cdatos.bdcampo(CodigoEntidad & "serie", Cdatos.TiposCampo.Cadena, 8)
            FGR_numerofactura = New Cdatos.bdcampo(CodigoEntidad & "numerofactur", Cdatos.TiposCampo.Entero, 8)
            FGR_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            FGR_Idagricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.Entero, 5)
            FGR_IdagricultorALB = New Cdatos.bdcampo(CodigoEntidad & "idagricultoralb", Cdatos.TiposCampo.Entero, 5)
            FGR_Idsemana = New Cdatos.bdcampo(CodigoEntidad & "idsemana", Cdatos.TiposCampo.Entero, 5)
            FGR_Igenero = New Cdatos.bdcampo(CodigoEntidad & "Igenero", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_BaseImponible = New Cdatos.bdcampo(CodigoEntidad & "BaseImponible", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_iva = New Cdatos.bdcampo(CodigoEntidad & "iva", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_CuotaIva = New Cdatos.bdcampo(CodigoEntidad & "cuotaiva", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_fondo = New Cdatos.bdcampo(CodigoEntidad & "fondo", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_cuotafondo = New Cdatos.bdcampo(CodigoEntidad & "cuotafondo", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_tiporetencion = New Cdatos.bdcampo(CodigoEntidad & "tiporetencion", Cdatos.TiposCampo.Cadena, 1)
            FGR_Baseretencion = New Cdatos.bdcampo(CodigoEntidad & "baseretencion", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_retencion = New Cdatos.bdcampo(CodigoEntidad & "retencion", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_cuotaretencion = New Cdatos.bdcampo(CodigoEntidad & "cuotaretencion", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_TotalFactura = New Cdatos.bdcampo(CodigoEntidad & "totalfactura", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_IdAsiento = New Cdatos.bdcampo(CodigoEntidad & "idasiento", Cdatos.TiposCampo.Entero, 8)
            FGR_IdLiquidacion = New Cdatos.bdcampo(CodigoEntidad & "idliquidacion", Cdatos.TiposCampo.Entero, 8)
            FGR_porcomision = New Cdatos.bdcampo(CodigoEntidad & "porcomision", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_comision = New Cdatos.bdcampo(CodigoEntidad & "comision", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_otrosgastos = New Cdatos.bdcampo(CodigoEntidad & "otrosgastos", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.Entero, 2)
            FGR_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 2)
            FGR_PorContingencia = New Cdatos.bdcampo(CodigoEntidad & "PorContingencia", Cdatos.TiposCampo.Importe, 12, 2)
            FGR_CuotaContingencia = New Cdatos.bdcampo(CodigoEntidad & "CuotaContingencia", Cdatos.TiposCampo.Importe, 12, 2)

            FGR_FechaAsientoREA = New Cdatos.bdcampo(CodigoEntidad & "FechaAsientoREA", Cdatos.TiposCampo.Fecha, 10)
            FGR_EjercicioREA = New Cdatos.bdcampo(CodigoEntidad & "EjercicioREA", Cdatos.TiposCampo.Entero, 2)
            FGR_IdAsientoREA = New Cdatos.bdcampo(CodigoEntidad & "IdAsientoREA", Cdatos.TiposCampo.Entero, 8)
            FGR_IdAsientoREA_Ret = New Cdatos.bdcampo(CodigoEntidad & "IdAsientoREA_Ret", Cdatos.TiposCampo.Entero, 8)

            FGR_IdTipoIva = New Cdatos.bdcampo(CodigoEntidad & "IdTipoIva", Cdatos.TiposCampo.Entero, 10)

            FGR_AnnoFondo = New Cdatos.bdcampo(CodigoEntidad & "AnnoFondo", Cdatos.TiposCampo.Cadena, 4)

            FGR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FGR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FGR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.FGR_serie)
            _lstCamposDocumento.Add(Me.FGR_numerofactura)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Factura de Agricultor"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Agricultores As New E_Agricultores(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.FGR_Idfactura, "Idfactura")
        consulta.SelCampo(Me.FGR_ejercicio, "Ejer")
        consulta.SelCampo(Me.FGR_serie, "Serie")
        consulta.SelCampo(Me.FGR_numerofactura, "Numero")
        consulta.SelCampo(Me.FGR_fecha, "Fecha")
        consulta.SelCampo(Me.FGR_Idagricultor, "Codigo")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Me.FGR_Idagricultor)
        consulta.SelCampo(Me.FGR_TotalFactura, "TotalFactura")
        _btBusca.Params("Idfactura", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idfactura"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFac"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultores.AGR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        _btBusca.ParamConsultaAlb(consulta, "", Me.FGR_Idagricultor, Me.FGR_fecha, Nothing, Me.FGR_idempresa)


    End Sub


    Public Function LeerFactura(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Serie As String, ByVal Factura As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.FGR_idempresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.FGR_ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.FGR_serie, "=", Serie)
        CONSULTA.WheCampo(Me.FGR_numerofactura, "=", Factura.ToString)

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


    Public Function ExisteFactura(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal serie As String, ByVal factura As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelCampo(Me.FGR_Idfactura)

        CONSULTA.WheCampo(Me.FGR_idempresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.FGR_ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.FGR_serie, "=", serie)
        CONSULTA.WheCampo(Me.FGR_numerofactura, "=", factura.ToString)

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

                existe = ExisteFactura(Empresa, Campa, Serie, max)
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
        sql = "update albentrada_his set aeh_idfactura=0 where aeh_idfactura = " + Me.FGR_Idfactura.Valor
        MiConexion.OrdenSql(sql)

        If VaInt(Me.FGR_Idfactura.Valor) > 0 Then
            sql = "SELECT FAL_Id as Id FROM FacturaAgr_Lineas WHERE FAL_IdFactura = " & Me.FGR_Idfactura.Valor

            Dim FacturaAgr_Lineas As New E_FacturaAgr_lineas(Idusuario, cn)

            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If FacturaAgr_Lineas.LeerId(Id) Then
                        FacturaAgr_Lineas.Eliminar()
                    End If
                Next
            End If

        End If


    End Sub


    Public Function Contabiliza(ByVal IdFactura As Integer) As List(Of Integer)

        Dim lst As New List(Of Integer)

        If Me.LeerId(IdFactura) = False Then
            Return lst
        End If


        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

        Agricultores.LeerId(Me.FGR_Idagricultor.Valor)
        TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor)


        Dim EsREA As String = (TipoAgricultor.TPA_compensa.Valor & "").Trim
        If EsREA = "S" Then
            lst.AddRange(Contabiliza_Con_REA(IdFactura, Agricultores, TipoAgricultor))
        Else
            lst.Add(Contabiliza_Sin_REA(IdFactura, Agricultores, TipoAgricultor))
        End If



        Return lst

    End Function



    Private Function Contabiliza_Sin_REA(ByVal IdFactura As Integer, ByVal Agricultores As E_Agricultores, ByVal TipoAgricultor As E_TipoAgricultor) As Integer

        Dim Resultado As Integer


        Dim Ectb As Integer = VaInt(Me.FGR_idempresa.Valor)
        Dim IdCentro As String = Me.FGR_idcentro.Valor

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"



        Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Ectb))
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Ectb))


        '        If PuntoVenta.LeerId(Me.fgr_idpuntoventa.Valor) Then
        ' IdActividad = VaInt(PuntoVenta.IdActividad.Valor).ToString
        ' IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor).ToString
        ' IdCentro = PuntoVenta.IdCentro.Valor
        ' End If



        Dim NombreAgricultor As String = Agricultores.AGR_Nombre.Valor & ""
        Dim CuentaAgricultor As String = ""
        CuentaAgricultor = Left(TipoAgricultor.TPA_ctaprov.Valor, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)


        Dim ClaveRegimen As Integer = -1

        Dim TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If TipoIvaSoportado.LeerId(TipoAgricultor.TPA_idtipoiva.Valor) Then
            ClaveRegimen = VaInt(TipoIvaSoportado.ClaveRegimenTrascendencia.Valor)
        End If



        Dim BaseImponible As Decimal = VaDec(Me.FGR_BaseImponible.Valor)

        Dim CuotaIva As Decimal = VaDec(Me.FGR_CuotaIva.Valor)
        Dim CuotaFondo As Decimal = VaDec(Me.FGR_cuotafondo.Valor)
        Dim CuotaContingencia As Decimal = VaDec(Me.FGR_CuotaContingencia.Valor)
        Dim CuotaRet As Decimal = VaDec(Me.FGR_cuotaretencion.Valor)
        Dim BaseRet As Decimal = VaDec(Me.FGR_Baseretencion.Valor)
        Dim TotalFactura As Decimal = VaDec(Me.FGR_TotalFactura.Valor)
        Dim Pret As Decimal = VaDec(Me.FGR_retencion.Valor)
        Dim PorComision As Decimal = VaDec(Me.FGR_porcomision.Valor)
        Dim OtrosGastos As Decimal = VaDec(Me.FGR_otrosgastos.Valor)
        Dim CuentaBase As String = TipoAgricultor.TPA_ctacompracomer.Valor
        Dim CuentaIVA As String = TipoAgricultor.TPA_ctaivaalbcomer.Valor
        Dim CuentaRet As String = TipoAgricultor.TPA_ctaretcomer.Valor
        Dim CuentaFondo As String = TipoAgricultor.TPA_ctafondo.Valor
        Dim CuentaContingencia As String = TipoAgricultor.TPA_CtaContingencia.Valor


        asiLin = New Contabilizacion.clAsientoLineas
        asiLin.Concepto = "FRA. " & NombreAgricultor
        asiLin.Cuenta = CuentaAgricultor
        asiLin.DH = "H"
        asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
        asiLin.IdActividad = IdActividad
        asiLin.idConcepto = 0
        asiLin.IdSeccion = IdSeccion
        asiLin.IdDepartamento = IdDepartamento
        asiLin.IdSubDepartamento = IdSubDepartamento
        asiLin.Importe = VaDec((TotalFactura + CuotaRet + CuotaFondo + CuotaContingencia).ToString("0.00"))
        asiLin.SRPC = "S"


        'DESGLOSE IVA
        Cuentas.LeerId(CuentaAgricultor)


        Dim Descripcion As String = ""
        Dim CodigoPais As String = SII_ObtenerDatosProveedor(FGR_Idagricultor.Valor, FGR_serie.Valor, FGR_numerofactura.Valor, Descripcion)

        Dim cl As New Contabilizacion.clIva
        cl.FechaFactura = Me.FGR_fecha.Valor & ""
        If VaInt(Me.FGR_IdTipoIva.Valor) = 0 Then
            cl.IdTipoIva = TipoAgricultor.TPA_idtipoiva.Valor & ""
        Else
            cl.IdTipoIva = Me.FGR_IdTipoIva.Valor & ""
        End If
        cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
        cl.TotalFactura = VaDec(BaseImponible + CuotaIva - CuotaRet.ToString("0.00"))

        cl.Descripcion = Descripcion

        cl.Nif = Agricultores.AGR_Nif.Valor & ""
        cl.Nombre = NombreAgricultor
        cl.NumCuenta = CuentaAgricultor & ""
        cl.Serie = Me.FGR_serie.Valor & ""
        cl.NumFactura = Me.FGR_numerofactura.Valor

        If CodigoPais = "" Or CodigoPais = "ES" Then
            cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.NIF).ToString
        Else
            cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.DocumentoPaisResidencia).ToString
            cl.CodigoPais = CodigoPais
        End If

        If ClaveRegimen <> -1 Then
            cl.FechaHora_AEAT = Now.ToString("yyyyMMddHHmmss")
        Else
            cl.Ignorar_AEAT = True
        End If



        'DESGLOSE RETENCIÓN
        Dim ret As New Contabilizacion.clIva.Retencion
        ret.base = BaseRet
        ret.clave = ""
        ret.cuota = CuotaRet
        ret.porcentaje = Pret
        cl.MiRetencion = ret

        cl.Soportado = True


        Dim desglose As New Contabilizacion.clIva.DesgloseIvas
        desglose.base = BaseImponible
        desglose.cuota = CuotaIva
        desglose.CuotaRecargo = 0
        desglose.porcentaje = VaDec(Me.FGR_iva.Valor)
        desglose.porcenRecargo = 0
        cl.MisDesgloseIvas.Add(desglose)



        ''-------------------------------------
        asiLin.clIva = cl
        c.ListaClAsientosLineas.Add(asiLin)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        If CuotaRet + CuotaFondo + CuotaContingencia <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = CuentaAgricultor
            asiLin.DH = "D"
            asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaRet + CuotaFondo + CuotaContingencia).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If



        If BaseImponible <> 0 Then
            Dim dc As Dictionary(Of Integer, Decimal) = DesglosarPorFamilia(IdFactura, BaseImponible, PorComision, OtrosGastos)
            For Each f In dc.Keys
                If dc(f) <> 0 Then
                    asiLin = New Contabilizacion.clAsientoLineas
                    asiLin.Concepto = "FRA. " & NombreAgricultor
                    'asiLin.Cuenta = Mid(CuentaBase, 1, 8) + Fnc0(f, 2) + Mid(CuentaBase, 11, 1)

                    asiLin.Cuenta = Mid(CuentaBase, 1, 8) + FnLeft(f, 1).PadLeft(1, "0") + Mid(CuentaBase, 10, 2)

                    asiLin.DH = "D"
                    asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
                    asiLin.IdActividad = IdActividad
                    asiLin.idConcepto = 0
                    asiLin.IdSeccion = IdSeccion
                    asiLin.IdDepartamento = IdDepartamento
                    asiLin.IdSubDepartamento = IdSubDepartamento
                    asiLin.Importe = VaDec(dc(f).ToString("0.00"))
                    asiLin.SRPC = ""
                    c.ListaClAsientosLineas.Add(asiLin)
                End If
            Next
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'CONTABILIZAR

        If CuotaIva <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = CuentaIVA
            asiLin.DH = "D"
            asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If CuotaRet <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaRet, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaRet).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If CuotaFondo <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaFondo, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaFondo).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If CuotaContingencia <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaContingencia, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaContingencia).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FGR_idempresa.Valor)), VaInt(Me.FGR_IdAsiento.Valor), VaInt(IdCentro), CDate(Me.FGR_fecha.Valor), Me.FGR_ejercicio.Valor, VaInt(IdCentro), E_Asientos.AsientoAlbaranAgricultor, IdFactura)

        If Resultado > 0 Then
            Me.FGR_IdAsiento.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function


    Private Function Contabiliza_Con_REA(ByVal IdFactura As Integer, ByVal Agricultores As E_Agricultores, ByVal TipoAgricultor As E_TipoAgricultor) As List(Of Integer)

        Dim lst As New List(Of Integer)

        lst.Add(Contabiliza_Con_REA_AsientoFactura(IdFactura, Agricultores, TipoAgricultor))
        lst.Add(Contabiliza_Con_REA_AsientoREA_IVA(IdFactura, Agricultores, TipoAgricultor))
        lst.Add(Contabiliza_Con_REA_AsientoREA_RETENCION(IdFactura, Agricultores, TipoAgricultor))

        Return lst

    End Function


    Private Function Contabiliza_Con_REA_AsientoFactura(ByVal IdFactura As Integer, ByVal Agricultores As E_Agricultores, ByVal TipoAgricultor As E_TipoAgricultor) As Integer

        Dim Resultado As Integer


        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"


        Dim IdCentro As String = Me.FGR_idcentro.Valor


        Dim NombreAgricultor As String = Agricultores.AGR_Nombre.Valor & ""
        Dim CuentaAgricultor As String = Left(TipoAgricultor.TPA_ctaprov.Valor, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)


        Dim BaseImponible As Decimal = VaDec(Me.FGR_BaseImponible.Valor)
        Dim CuotaIva As Decimal = VaDec(Me.FGR_CuotaIva.Valor)
        Dim CuotaFondo As Decimal = VaDec(Me.FGR_cuotafondo.Valor)
        Dim CuotaContingencia As Decimal = VaDec(Me.FGR_CuotaContingencia.Valor)
        Dim CuotaRet As Decimal = VaDec(Me.FGR_cuotaretencion.Valor)
        Dim TotalFactura As Decimal = VaDec(Me.FGR_TotalFactura.Valor)
        Dim PorComision As Decimal = VaDec(Me.FGR_porcomision.Valor)
        Dim OtrosGastos As Decimal = VaDec(Me.FGR_otrosgastos.Valor)
        Dim CuentaBase As String = TipoAgricultor.TPA_ctacompracomer.Valor
        Dim CuentaFondo As String = TipoAgricultor.TPA_ctafondo.Valor
        Dim CuentaContingencia As String = TipoAgricultor.TPA_CtaContingencia.Valor



        asiLin = New Contabilizacion.clAsientoLineas
        asiLin.Concepto = "FRA. " & NombreAgricultor
        asiLin.Cuenta = CuentaAgricultor
        asiLin.DH = "H"
        asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
        asiLin.IdActividad = IdActividad
        asiLin.idConcepto = 0
        asiLin.IdSeccion = IdSeccion
        asiLin.IdDepartamento = IdDepartamento
        asiLin.IdSubDepartamento = IdSubDepartamento
        asiLin.Importe = VaDec((TotalFactura + CuotaRet + CuotaFondo + CuotaContingencia).ToString("0.00"))
        asiLin.SRPC = ""
        c.ListaClAsientosLineas.Add(asiLin)



        If CuotaFondo + CuotaContingencia <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = CuentaAgricultor
            asiLin.DH = "D"
            asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaFondo + CuotaContingencia).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If



        If BaseImponible <> 0 Then
            Dim dc As Dictionary(Of Integer, Decimal) = DesglosarPorFamilia(IdFactura, BaseImponible, PorComision, OtrosGastos)
            For Each f In dc.Keys
                If dc(f) <> 0 Then
                    asiLin = New Contabilizacion.clAsientoLineas
                    asiLin.Concepto = "FRA. " & NombreAgricultor
                    'asiLin.Cuenta = Mid(CuentaBase, 1, 8) + Fnc0(f, 2) + Mid(CuentaBase, 11, 1)

                    asiLin.Cuenta = Mid(CuentaBase, 1, 8) + FnLeft(f, 1).PadLeft(1, "0") + Mid(CuentaBase, 10, 2)

                    asiLin.DH = "D"
                    asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
                    asiLin.IdActividad = IdActividad
                    asiLin.idConcepto = 0
                    asiLin.IdSeccion = IdSeccion
                    asiLin.IdDepartamento = IdDepartamento
                    asiLin.IdSubDepartamento = IdSubDepartamento
                    asiLin.Importe = VaDec(dc(f).ToString("0.00"))
                    asiLin.SRPC = ""
                    c.ListaClAsientosLineas.Add(asiLin)
                End If
            Next
        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'CONTABILIZAR

        If CuotaIva <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = CTA_PUENTE_REA
            asiLin.DH = "D"
            asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If CuotaFondo <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaFondo, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaFondo).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If CuotaContingencia <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaContingencia, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaContingencia).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FGR_idempresa.Valor)), VaInt(Me.FGR_IdAsiento.Valor), VaInt(IdCentro), CDate(Me.FGR_fecha.Valor), Me.FGR_ejercicio.Valor, VaInt(IdCentro), E_Asientos.AsientoAlbaranAgricultor, IdFactura)

        If Resultado > 0 Then
            Me.FGR_IdAsiento.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function


    Private Function Contabiliza_Con_REA_AsientoREA_IVA(ByVal IdFactura As Integer, ByVal Agricultores As E_Agricultores, ByVal TipoAgricultor As E_TipoAgricultor) As Integer

        Dim Resultado As Integer = 0


        Dim Ectb As Integer = VaInt(Me.FGR_idempresa.Valor)
        Dim IdCentro As String = Me.FGR_idcentro.Valor

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"



        Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Ectb))
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Ectb))


        Dim NombreAgricultor As String = Agricultores.AGR_Nombre.Valor & ""
        Dim CuentaAgricultor As String = Left(TipoAgricultor.TPA_ctaprov.Valor, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)


        Dim BaseImponible As Decimal = VaDec(Me.FGR_BaseImponible.Valor)

        Dim CuotaIva As Decimal = VaDec(Me.FGR_CuotaIva.Valor)
        Dim CuotaRet As Decimal = VaDec(Me.FGR_cuotaretencion.Valor)
        Dim BaseRet As Decimal = VaDec(Me.FGR_Baseretencion.Valor)
        Dim Pret As Decimal = VaDec(Me.FGR_retencion.Valor)
        Dim CuentaIVA As String = TipoAgricultor.TPA_ctaivaalbcomer.Valor
        Dim CuentaRet As String = TipoAgricultor.TPA_ctaretcomer.Valor



        Dim ClaveRegimen As Integer = -1

        Dim TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If TipoIvaSoportado.LeerId(TipoAgricultor.TPA_idtipoiva.Valor) Then
            ClaveRegimen = VaInt(TipoIvaSoportado.ClaveRegimenTrascendencia.Valor)
        End If



        'ASIENTO CON LA BASE Y EL IVA


        'CUOTA IVA

        If CuotaIva <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = CTA_PUENTE_REA
            asiLin.DH = "H"
            asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva).ToString("0.00"))
            asiLin.SRPC = "S"


            'DESGLOSE IVA

            Dim Descripcion As String = ""
            Dim CodigoPais As String = SII_ObtenerDatosProveedor(FGR_Idagricultor.Valor, FGR_serie.Valor, FGR_numerofactura.Valor, Descripcion)

            Dim cl As New Contabilizacion.clIva
            cl.FechaFactura = Me.FGR_fecha.Valor & "" ' la fecha original de la factura
            If VaInt(Me.FGR_IdTipoIva.Valor) = 0 Then
                cl.IdTipoIva = TipoAgricultor.TPA_idtipoiva.Valor & ""
            Else
                cl.IdTipoIva = Me.FGR_IdTipoIva.Valor & ""
            End If
            cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
            cl.TotalFactura = VaDec(BaseImponible + CuotaIva - CuotaRet.ToString("0.00"))
            cl.Nif = Agricultores.AGR_Nif.Valor & ""
            cl.Descripcion = Descripcion

            cl.Nombre = NombreAgricultor
            cl.NumCuenta = CuentaAgricultor & ""
            cl.Serie = Me.FGR_serie.Valor & ""
            cl.NumFactura = Me.FGR_numerofactura.Valor
            cl.Soportado = True

            If CodigoPais = "" Or CodigoPais = "ES" Then
                cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.NIF).ToString
            Else
                cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.DocumentoPaisResidencia).ToString
                cl.CodigoPais = CodigoPais
            End If

            If ClaveRegimen <> -1 Then
                cl.FechaHora_AEAT = Now.ToString("yyyyMMddHHmmss")
            Else
                cl.Ignorar_AEAT = True
            End If


            Dim desglose As New Contabilizacion.clIva.DesgloseIvas
            desglose.base = BaseImponible
            desglose.cuota = CuotaIva
            desglose.CuotaRecargo = 0
            desglose.porcentaje = VaDec(Me.FGR_iva.Valor)
            desglose.porcenRecargo = 0
            cl.MisDesgloseIvas.Add(desglose)

            '---------------------------------------------
            asiLin.clIva = cl
            c.ListaClAsientosLineas.Add(asiLin)
            '---------------------------------------------


        End If


            If CuotaIva <> 0 Then
                asiLin = New Contabilizacion.clAsientoLineas
                asiLin.Concepto = "FRA. " & NombreAgricultor
                asiLin.Cuenta = CuentaIVA
                asiLin.DH = "D"
                asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
                asiLin.IdActividad = IdActividad
                asiLin.idConcepto = 0
                asiLin.IdSeccion = IdSeccion
                asiLin.IdDepartamento = IdDepartamento
                asiLin.IdSubDepartamento = IdSubDepartamento
                asiLin.Importe = VaDec((CuotaIva).ToString("0.00"))
                asiLin.SRPC = ""
                c.ListaClAsientosLineas.Add(asiLin)

            End If



            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FGR_idempresa.Valor)), VaInt(Me.FGR_IdAsientoREA.Valor), VaInt(IdCentro), CDate(Me.FGR_FechaAsientoREA.Valor), Me.FGR_EjercicioREA.Valor, VaInt(IdCentro), E_Asientos.AsientoAlbaranAgricultor, IdFactura)

            If Resultado > 0 Then
                Me.FGR_IdAsientoREA.Valor = Resultado.ToString
                Me.Actualizar()
            End If


            Return Resultado


    End Function



    Private Function Contabiliza_Con_REA_AsientoREA_RETENCION(ByVal IdFactura As Integer, ByVal Agricultores As E_Agricultores, ByVal TipoAgricultor As E_TipoAgricultor) As Integer

        Dim Resultado As Integer = 0


        Dim Ectb As Integer = VaInt(Me.FGR_idempresa.Valor)
        Dim IdCentro As String = Me.FGR_idcentro.Valor

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"



        Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Ectb))
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Ectb))


        Dim NombreAgricultor As String = Agricultores.AGR_Nombre.Valor & ""
        Dim CuentaAgricultor As String = Left(TipoAgricultor.TPA_ctaprov.Valor, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)


        Dim BaseImponible As Decimal = VaDec(Me.FGR_BaseImponible.Valor)

        Dim CuotaIva As Decimal = VaDec(Me.FGR_CuotaIva.Valor)
        Dim CuotaRet As Decimal = VaDec(Me.FGR_cuotaretencion.Valor)
        Dim BaseRet As Decimal = VaDec(Me.FGR_Baseretencion.Valor)
        Dim Pret As Decimal = VaDec(Me.FGR_retencion.Valor)
        Dim CuentaIVA As String = TipoAgricultor.TPA_ctaivaalbcomer.Valor
        Dim CuentaRet As String = TipoAgricultor.TPA_ctaretcomer.Valor



        'ASIENTO CON LA BASE Y LA RETENCION

        asiLin = New Contabilizacion.clAsientoLineas
        asiLin.Concepto = "FRA. " & NombreAgricultor
        asiLin.Cuenta = CuentaAgricultor
        asiLin.DH = "D"
        asiLin.Documento = Me.FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
        asiLin.IdActividad = IdActividad
        asiLin.idConcepto = 0
        asiLin.IdSeccion = IdSeccion
        asiLin.IdDepartamento = IdDepartamento
        asiLin.IdSubDepartamento = IdSubDepartamento
        asiLin.Importe = VaDec((CuotaRet).ToString("0.00"))
        asiLin.SRPC = "S"


        'DESGLOSE RETENCIÓN
        Dim cl As New Contabilizacion.clIva
        cl.FechaFactura = Me.FGR_fecha.Valor & "" ' la fecha original de la factura
        cl.IdTipoIva = "99"
        cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
        cl.TotalFactura = VaDec(BaseImponible + CuotaIva - CuotaRet.ToString("0.00"))
        cl.Nif = Agricultores.AGR_Nif.Valor & ""
        cl.Nombre = NombreAgricultor
        cl.NumCuenta = CuentaAgricultor & ""
        cl.Serie = Me.FGR_serie.Valor & ""
        cl.NumFactura = Me.FGR_numerofactura.Valor
        cl.Soportado = True
        cl.Ignorar_AEAT = True


        Dim desglose As New Contabilizacion.clIva.DesgloseIvas
        desglose.base = 0
        desglose.cuota = 0
        desglose.CuotaRecargo = 0
        desglose.porcentaje = 0
        desglose.porcenRecargo = 0
        cl.MisDesgloseIvas.Add(desglose)


        Dim ret As New Contabilizacion.clIva.Retencion
        ret.base = BaseRet
        ret.clave = ""
        ret.cuota = CuotaRet
        ret.porcentaje = Pret
        cl.MiRetencion = ret


        asiLin.clIva = cl
        c.ListaClAsientosLineas.Add(asiLin)


        If CuotaRet <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "FRA. " & NombreAgricultor
            asiLin.Cuenta = Mid(CuentaRet, 1, 6) + Fnc0(Me.FGR_Idagricultor.Valor, 5)
            asiLin.DH = "H"
            asiLin.Documento = FGR_serie.Valor & " " & Me.FGR_numerofactura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaRet).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FGR_idempresa.Valor)), VaInt(Me.FGR_IdAsientoREA_Ret.Valor), VaInt(IdCentro), CDate(Me.FGR_FechaAsientoREA.Valor), Me.FGR_EjercicioREA.Valor, VaInt(IdCentro), E_Asientos.AsientoAlbaranAgricultor, IdFactura)

        If Resultado > 0 Then
            Me.FGR_IdAsientoREA_Ret.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function



    Private Function DesglosarPorFamilia(idfactura As Integer, Base As Decimal, PorComision As Decimal, OtrosGastos As Decimal) As Dictionary(Of Integer, Decimal)


        Dim FacturaAgr_lineas As New E_FacturaAgr_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Subfamilias As New E_Subfamilias(Idusuario, cn)

        Dim sql As String = ""
        Dim Consulta As New Cdatos.E_select
        Dim Dc As New Dictionary(Of Integer, Decimal)
        Dim KilosFac As Decimal = 0
        Dim gtkilo As Decimal = 0

        sql = "Select sum(FAL_KILOS) AS kilos from FACTURAAGR_LINEAS WHERE FAL_IDFACTURA=" + idfactura.ToString
        Dim DT As DataTable = FacturaAgr_lineas.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                KilosFac = VaDec(DT.Rows(0)("kilos"))
            End If
        End If


        If KilosFac <> 0 Then
            gtkilo = OtrosGastos / KilosFac
        End If


        Consulta.SelCampo(FacturaAgr_lineas.FAL_importe, "Importe")
        Consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia", FacturaAgr_lineas.FAL_idgenero)
        Consulta.SelCampo(Subfamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        Consulta.SelCampo(FacturaAgr_lineas.FAL_kilos, "kilos")
        Consulta.WheCampo(FacturaAgr_lineas.FAL_idfactura, "=", idfactura.ToString)
        sql = Consulta.SQL


        Dim T As Decimal = 0
        Dim max As Decimal = 0
        Dim nmax As Integer = 0

        DT = Me.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            For Each rw In DT.Rows
                Dim i As Decimal = VaDec(rw("importe"))
                Dim k As Decimal = VaDec(rw("kilos"))
                i = i - i * PorComision / 100
                i = i - k * gtkilo
                i = Math.Round(i, 2)

                T = T + i


                Dim idfamilia As Integer = VaInt(rw("idfamilia"))
                If idfamilia > 100 Then
                    idfamilia = VaInt(idfamilia.ToString.Substring(1, 1))
                Else
                    idfamilia = VaInt(FnLeft(idfamilia.ToString, 1))
                End If



                If Dc.ContainsKey(idfamilia) = False Then
                    Dc.Add(idfamilia, i)
                Else
                    Dc(idfamilia) = Dc(idfamilia) + i
                End If
                If Dc(idfamilia) >= max Then
                    max = Dc(idfamilia)
                    nmax = idfamilia
                End If
            Next
        End If


        'If DT.Rows.Count = 0 Then
        '        If Dc.Count = 1 Then
        ' Dc(0) = Base
        ' Else


        If nmax > 0 Then
            Dc(nmax) = Dc(nmax) + Base - T
        End If


        'End If


        Return Dc

    End Function


End Class
