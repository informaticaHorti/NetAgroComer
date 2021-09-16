
Public Class TipoFacturaRecibida
    Public Const ComprasGenero As String = "GE"
    Public Const GastosCompras As String = "GC"
    Public Const GastosVentas As String = "GV"
    Public Const Materiales As String = "MA"
    Public Const Otros As String = "OT"
    Public Const Fianza As String = "FZ"
End Class

Public Class E_Facturasrecibidas
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public FRR_Id As Cdatos.bdcampo
    Public FRR_numero As Cdatos.bdcampo
    Public FRR_fechafactura As Cdatos.bdcampo
    Public FRR_numerofactura As Cdatos.bdcampo
    Public FRR_ejercicio As Cdatos.bdcampo
    Public FRR_idcentro As Cdatos.bdcampo
    Public FRR_idproveedor As Cdatos.bdcampo
    Public FRR_idregimen As Cdatos.bdcampo
    Public FRR_fechactb As Cdatos.bdcampo
    Public FRR_base1 As Cdatos.bdcampo
    Public FRR_base2 As Cdatos.bdcampo
    Public FRR_base3 As Cdatos.bdcampo
    Public FRR_base4 As Cdatos.bdcampo
    Public FRR_iva1 As Cdatos.bdcampo
    Public FRR_iva2 As Cdatos.bdcampo
    Public FRR_iva3 As Cdatos.bdcampo
    Public FRR_iva4 As Cdatos.bdcampo
    Public FRR_cuota1 As Cdatos.bdcampo
    Public FRR_cuota2 As Cdatos.bdcampo
    Public FRR_cuota3 As Cdatos.bdcampo
    Public FRR_cuota4 As Cdatos.bdcampo
    Public FRR_baseret As Cdatos.bdcampo
    Public FRR_ret As Cdatos.bdcampo
    Public FRR_cuotaret As Cdatos.bdcampo
    Public FRR_igasto1 As Cdatos.bdcampo
    Public FRR_ctagasto1 As Cdatos.bdcampo
    Public FRR_igasto2 As Cdatos.bdcampo
    Public FRR_ctagasto2 As Cdatos.bdcampo
    Public FRR_igasto3 As Cdatos.bdcampo
    Public FRR_ctagasto3 As Cdatos.bdcampo
    Public FRR_igasto4 As Cdatos.bdcampo
    Public FRR_ctagasto4 As Cdatos.bdcampo
    Public FRR_totalfac As Cdatos.bdcampo
    Public FRR_tipofactura As Cdatos.bdcampo
    Public FRR_IdCuenta As Cdatos.bdcampo
    Public FRR_IdPuntoVenta As Cdatos.bdcampo
    Public FRR_ClaveIRPF As Cdatos.bdcampo
    Public FRR_IdAsientoNet As Cdatos.bdcampo
    'Public FRR_IdFacturaNet As Cdatos.bdcampo
    Public FRR_CtaCartera As Cdatos.bdcampo
    Public FRR_IdBanco As Cdatos.bdcampo
    Public FRR_IdFormaPago As Cdatos.bdcampo
    Public FRR_FechaVto As Cdatos.bdcampo
    Public FRR_ImporteVto As Cdatos.bdcampo
    Public FRR_Modificable As Cdatos.bdcampo
    Public FRR_IdEmpresa As Cdatos.bdcampo

    'Public FRR_TipoRectificativa As Cdatos.bdcampo

    Public FRR_FondoOperativo As Cdatos.bdcampo

    Public FRR_IdUsuarioLog As Cdatos.bdcampo
    Public FRR_FechaLog As Cdatos.bdcampo
    Public FRR_HoraLog As Cdatos.bdcampo


    Private Acreedores As New E_Acreedores(Idusuario, cn)
    Private Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "facturasrecibidas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FRR_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, 0, True)
            FRR_numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 10)
            FRR_fechafactura = New Cdatos.bdcampo(CodigoEntidad & "fechafactura", Cdatos.TiposCampo.Fecha, 10)
            FRR_numerofactura = New Cdatos.bdcampo(CodigoEntidad & "numerofactura", Cdatos.TiposCampo.Cadena, 15)
            FRR_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "ejercicio", Cdatos.TiposCampo.Entero, 10)
            FRR_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 10)
            FRR_idproveedor = New Cdatos.bdcampo(CodigoEntidad & "idproveedor", Cdatos.TiposCampo.Entero, 5)
            FRR_idregimen = New Cdatos.bdcampo(CodigoEntidad & "idregimen", Cdatos.TiposCampo.Entero, 10)
            FRR_fechactb = New Cdatos.bdcampo(CodigoEntidad & "fechactb", Cdatos.TiposCampo.Fecha, 10)

            FRR_base1 = New Cdatos.bdcampo(CodigoEntidad & "base1", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_base2 = New Cdatos.bdcampo(CodigoEntidad & "base2", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_base3 = New Cdatos.bdcampo(CodigoEntidad & "base3", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_base4 = New Cdatos.bdcampo(CodigoEntidad & "base4", Cdatos.TiposCampo.Importe, 10, 2)

            FRR_iva1 = New Cdatos.bdcampo(CodigoEntidad & "iva1", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_iva2 = New Cdatos.bdcampo(CodigoEntidad & "iva2", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_iva3 = New Cdatos.bdcampo(CodigoEntidad & "iva3", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_iva4 = New Cdatos.bdcampo(CodigoEntidad & "iva4", Cdatos.TiposCampo.Importe, 10, 2)

            FRR_cuota1 = New Cdatos.bdcampo(CodigoEntidad & "cuota1", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_cuota2 = New Cdatos.bdcampo(CodigoEntidad & "cuota2", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_cuota3 = New Cdatos.bdcampo(CodigoEntidad & "cuota3", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_cuota4 = New Cdatos.bdcampo(CodigoEntidad & "cuota4", Cdatos.TiposCampo.Importe, 10, 2)


            FRR_baseret = New Cdatos.bdcampo(CodigoEntidad & "baseret", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_ret = New Cdatos.bdcampo(CodigoEntidad & "ret", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_cuotaret = New Cdatos.bdcampo(CodigoEntidad & "cuotaret", Cdatos.TiposCampo.Importe, 10, 2)

            FRR_igasto1 = New Cdatos.bdcampo(CodigoEntidad & "igasto1", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_ctagasto1 = New Cdatos.bdcampo(CodigoEntidad & "ctagasto1", Cdatos.TiposCampo.Cuenta, 11)
            FRR_igasto2 = New Cdatos.bdcampo(CodigoEntidad & "igasto2", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_ctagasto2 = New Cdatos.bdcampo(CodigoEntidad & "ctagasto2", Cdatos.TiposCampo.Cuenta, 11)
            FRR_igasto3 = New Cdatos.bdcampo(CodigoEntidad & "igasto3", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_ctagasto3 = New Cdatos.bdcampo(CodigoEntidad & "ctagasto3", Cdatos.TiposCampo.Cuenta, 11)
            FRR_igasto4 = New Cdatos.bdcampo(CodigoEntidad & "igasto4", Cdatos.TiposCampo.Importe, 10, 2)
            FRR_ctagasto4 = New Cdatos.bdcampo(CodigoEntidad & "ctagasto4", Cdatos.TiposCampo.Cuenta, 11)

            FRR_totalfac = New Cdatos.bdcampo(CodigoEntidad & "totalfac", Cdatos.TiposCampo.Importe, 12, 2)
            FRR_tipofactura = New Cdatos.bdcampo(CodigoEntidad & "tipofactura", Cdatos.TiposCampo.Cadena, 2)
            FRR_IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "idcuenta", Cdatos.TiposCampo.Cuenta, 11)
            FRR_IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.Entero, 10)
            FRR_ClaveIRPF = New Cdatos.bdcampo(CodigoEntidad & "ClaveIRPF", Cdatos.TiposCampo.Cadena, 5)
            FRR_IdAsientoNet = New Cdatos.bdcampo(CodigoEntidad & "IdAsientoNet", Cdatos.TiposCampo.EnteroPositivo, 10)
            FRR_CtaCartera = New Cdatos.bdcampo(CodigoEntidad & "CtaCartera", Cdatos.TiposCampo.Cuenta, 11)
            FRR_IdBanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.EnteroPositivo, 10)
            FRR_IdFormaPago = New Cdatos.bdcampo(CodigoEntidad & "IdFormaPago", Cdatos.TiposCampo.EnteroPositivo, 10)
            FRR_FechaVto = New Cdatos.bdcampo("FechaVto", Cdatos.TiposCampo.Fecha, 8)
            FRR_ImporteVto = New Cdatos.bdcampo("ImporteVto", Cdatos.TiposCampo.Importe, 18, 2)
            FRR_Modificable = New Cdatos.bdcampo(CodigoEntidad & "Modificable", Cdatos.TiposCampo.Cadena, 1)
            FRR_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "Idempresa", Cdatos.TiposCampo.EnteroPositivo, 2)

            'FRR_TipoRectificativa = New Cdatos.bdcampo(CodigoEntidad & "TipoRectificativa", Cdatos.TiposCampo.Cadena, 2)

            FRR_FondoOperativo = New Cdatos.bdcampo(CodigoEntidad & "FondoOperativo", Cdatos.TiposCampo.Cadena, 1)

            FRR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FRR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FRR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()



            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.FRR_numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT FRR_Id as Id, FRR_Numero as Numero, FRR_Ejercicio as Campa," & vbCrLf
        sql = sql & " CE.Nombre as Centro, FRR_FechaFactura as Fecha," & vbCrLf
        sql = sql & " FRR_IdProveedor as Codigo," & vbCrLf
        sql = sql & " COALESCE(ACR_Nombre,'') + COALESCE(AGR_Nombre,'') as Proveedor," & vbCrLf
        sql = sql & " FRR_TipoFactura as TipoFactura," & vbCrLf
        sql = sql & " FRR_NumeroFactura as NumFactura, FRR_TotalFac as Total" & vbCrLf
        sql = sql & " FROM FacturasRecibidas" & vbCrLf
        sql = sql & " LEFT JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.Centros CE ON CE.IdCentro = FRR_IdCentro" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON (FRR_TipoFactura = 'GE' AND AGR_IdAgricultor = FRR_IdProveedor)" & vbCrLf
        sql = sql & " LEFT JOIN Acreedores ON ((FRR_TipoFactura = 'GC' OR FRR_TipoFactura = 'GV' OR FRR_TipoFactura = 'MA' OR FRR_TipoFactura = 'OT') AND ACR_Codigo = FRR_IdProveedor)"


        _btBusca.Params("Id", , -1)
        '        _btBusca.Params("Centro", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Acreedores.ACR_Codigo
        _btBusca.CL_camponombre = Acreedores.ACR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Codigo"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFacrec"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing

    End Sub


    Public Function Leerfac(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, ByVal numfac As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)
        CONSULTA.WheCampo(Me.FRR_IdEmpresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.FRR_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.FRR_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.FRR_numero, "=", numfac.ToString)

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


    Public Function ExisteFac(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, ByVal numfac As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.FRR_IdEmpresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.FRR_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.FRR_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.FRR_numero, "=", numfac.ToString)

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


    Public Function MaxIdCampa(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(idempresa.ToString + "_" + Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(idempresa.ToString + "_" + Campa.ToString, vmax)

                End If
                existe = ExisteFac(idempresa, Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Public Function Contabiliza(ByVal IdFactura As Integer) As Integer

        Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim FacturasRecibidasImportaciones As New E_FacturasRecibidasImportaciones(Idusuario, cn)
        Dim TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim TipoDocumento As New E_TipoDocumento(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


        Dim Resultado As Integer

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        If Me.LeerId(IdFactura) = False Then
            Return 0
        End If



        Dim NombreProveedor As String = ""
        If Cuentas.LeerId(Me.FRR_IdCuenta.Valor) Then NombreProveedor = Cuentas.Nombre.Valor & ""

        Dim Base1 As Decimal = VaDec(Me.FRR_base1.Valor)
        Dim Base2 As Decimal = VaDec(Me.FRR_base2.Valor)
        Dim Base3 As Decimal = VaDec(Me.FRR_base3.Valor)
        Dim Base4 As Decimal = VaDec(Me.FRR_base4.Valor)

        Dim CuotaIva1 As Decimal = VaDec(Me.FRR_cuota1.Valor)
        Dim CuotaIva2 As Decimal = VaDec(Me.FRR_cuota2.Valor)
        Dim CuotaIva3 As Decimal = VaDec(Me.FRR_cuota3.Valor)
        Dim CuotaIva4 As Decimal = VaDec(Me.FRR_cuota4.Valor)

        Dim CuotaRet As Decimal = VaDec(Me.FRR_cuotaret.Valor)

        Dim Importe = (Base1 + Base2 + Base3 + Base4 + CuotaIva1 + CuotaIva2 + CuotaIva3 + CuotaIva4 - CuotaRet)

        Dim ImporteIvaImportacion As Decimal = 0
        Dim ImporteSuplidoImportacion As Decimal = 0
        Dim ConImportacion As Boolean = False

        If FacturasRecibidasImportaciones.LeerId(IdFactura) Then
            ImporteIvaImportacion = VaDec(FacturasRecibidasImportaciones.FRI_CuotaIva.Valor)
            ImporteSuplidoImportacion = VaDec(FacturasRecibidasImportaciones.FRI_BaseSuplido.Valor)
            ConImportacion = True
        End If

        Dim Actividad As Integer = 0
        Dim Seccion As Integer = 0
        If PuntoVenta.LeerId(Me.FRR_IdPuntoVenta.Valor) Then
            Actividad = PuntoVenta.IdActividad.Valor
            Seccion = PuntoVenta.IdSeccion.Valor
        End If


        asiLin.Concepto = "S/FRA. " & NombreProveedor
        asiLin.Cuenta = Me.FRR_IdCuenta.Valor & ""
        asiLin.DH = "H"
        asiLin.Documento = Me.FRR_numerofactura.Valor
        asiLin.Importe = VaDec((Importe + ImporteIvaImportacion + ImporteSuplidoImportacion).ToString("0.00"))
        asiLin.idConcepto = 0
        asiLin.IdActividad = Actividad
        asiLin.IdSeccion = Seccion
        asiLin.IdDepartamento = 0
        asiLin.IdSubDepartamento = 0
        asiLin.SRPC = "S"

        ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'DESGLOSE IVA
        Dim Descripcion As String = ""
        Dim CodigoPais As String = ""
        Dim TipoFactura As String = (Me.FRR_tipofactura.Valor & "").Trim.ToUpper

        Select Case TipoFactura

            Case "GE"
                CodigoPais = SII_ObtenerDatosProveedor(Me.FRR_idproveedor.Valor, "", Me.FRR_numerofactura.Valor, Descripcion)

            Case Else
                CodigoPais = SII_ObtenerDatosAcreedor(Me.FRR_idproveedor.Valor, "", Me.FRR_numerofactura.Valor, Descripcion)

        End Select



        Dim ClaveRegimen As Integer = -1

        If TipoIvaSoportado.LeerId(Me.FRR_idregimen.Valor & "") Then
            ClaveRegimen = VaInt(TipoIvaSoportado.ClaveRegimenTrascendencia.Valor)
        End If




        Dim cl As New Contabilizacion.clIva
        cl.FechaFactura = Me.FRR_fechafactura.Valor & ""
        cl.IdTipoIva = Me.FRR_idregimen.Valor & ""
        cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
        cl.TotalFactura = VaDec(Me.FRR_totalfac.Valor)
        cl.Nif = Cuentas.Nif.Valor & ""
        cl.Descripcion = Descripcion

        cl.Nombre = NombreProveedor
        cl.NumCuenta = Me.FRR_IdCuenta.Valor & ""
        cl.Serie = ""
        cl.NumFactura = Me.FRR_numerofactura.Valor & ""
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


        For i = 0 To 3

            Select Case i + 1

                Case 1

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base1
                    desglose.cuota = CuotaIva1
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRR_iva1.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 2

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base2
                    desglose.cuota = CuotaIva2
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRR_iva2.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 3

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base3
                    desglose.cuota = CuotaIva3
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRR_iva3.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 4

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base4
                    desglose.cuota = CuotaIva4
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRR_iva4.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

            End Select

        Next


        'DESGLOSE RETENCIÓN
        Dim ret As New Contabilizacion.clIva.Retencion
        ret.base = VaDec(Me.FRR_baseret.Valor)
        ret.clave = Me.FRR_ClaveIRPF.Valor & ""
        ret.cuota = VaDec(Me.FRR_cuotaret.Valor)
        ret.porcentaje = VaDec(Me.FRR_ret.Valor)
        cl.MiRetencion = ret

        ''-------------------------------------
        asiLin.clIva = cl
        c.ListaClAsientosLineas.Add(asiLin)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim EmitirPago As String = "N"

        '  BASE IMPONIBLE(CUENTAS) Y SUPLIDOS
        Dim ConceptoLinea As String = "S/FRA. " & NombreProveedor

        If VaDec(Me.FRR_igasto1.Valor) <> 0 Then



            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = ConceptoLinea
            asiLin.Cuenta = Me.FRR_ctagasto1.Valor
            asiLin.DH = "D"
            asiLin.Importe = VaDec(Me.FRR_igasto1.Valor)
            asiLin.SRPC = ""
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            If VaDec(Me.FRR_ImporteVto.Valor) <> 0 Then

                If TipoDocumento.LeerId(Me.FRR_IdFormaPago.Valor) = True Then
                    EmitirPago = TipoDocumento.EmitirPago.Valor
                End If
                asiLin.SRPC = "P"

                asiLin.clcartera = New Contabilizacion.clCartera


                asiLin.clcartera.Cuenta = Me.FRR_IdCuenta.Valor
                asiLin.clcartera.CuentaCartera = Me.FRR_CtaCartera.Valor
                asiLin.clcartera.Documento = Me.FRR_numerofactura.Valor
                asiLin.clcartera.Fecha = Me.FRR_fechafactura.Valor
                asiLin.clcartera.PagoCobro = "P"
                Dim lcartera As New Contabilizacion.clCartera.DesgloseCartera
                lcartera.IdBanco = Me.FRR_IdBanco.Valor
                lcartera.IdTipo = Me.FRR_IdFormaPago.Valor
                lcartera.Importe = VaDec(Me.FRR_ImporteVto.Valor)
                lcartera.Vencimiento = Me.FRR_FechaVto.Valor
                If EmitirPago = "S" Then
                    lcartera.Estado = "1"
                Else
                    lcartera.Estado = "2"
                End If


                If Me.FRR_FondoOperativo.Valor = "S" Then

                    Dim CtaCartera As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_FONDOOPERATIVO_CARTERA)
                    Dim Situacion As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.SITUACION_FONDOOPERATIVO_CARTERA)

                    asiLin.clcartera.CuentaCartera = CtaCartera
                    lcartera.Estado = "1"
                    lcartera.IdBanco = Situacion

                End If




                asiLin.clcartera.LineasCartera.Add(lcartera)

            End If

            c.ListaClAsientosLineas.Add(asiLin)


        End If

        If VaDec(Me.FRR_igasto2.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = ConceptoLinea
            asiLin.Cuenta = Me.FRR_ctagasto2.Valor
            asiLin.DH = "D"
            asiLin.Importe = VaDec(Me.FRR_igasto2.Valor)
            asiLin.SRPC = ""
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        If VaDec(Me.FRR_igasto3.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = ConceptoLinea
            asiLin.Cuenta = Me.FRR_ctagasto3.Valor
            asiLin.DH = "D"
            asiLin.Importe = VaDec(Me.FRR_igasto3.Valor)
            asiLin.SRPC = ""
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        If VaDec(Me.FRR_igasto4.Valor) <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = ConceptoLinea
            asiLin.Cuenta = Me.FRR_ctagasto4.Valor
            asiLin.DH = "D"
            asiLin.Importe = VaDec(Me.FRR_igasto4.Valor)
            asiLin.SRPC = ""
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'IVAS
        For i = 0 To 3

            Dim Cuota As Decimal = 0
            Dim Cuenta As String = ""
            Select Case i
                Case 0 : Cuenta = TipoIvaSoportado.Cuenta1.Valor : Cuota = CuotaIva1
                Case 1 : Cuenta = TipoIvaSoportado.Cuenta2.Valor : Cuota = CuotaIva2
                Case 2 : Cuenta = TipoIvaSoportado.Cuenta3.Valor : Cuota = CuotaIva3
                Case 3 : Cuenta = TipoIvaSoportado.Cuenta4.Valor : Cuota = CuotaIva4
            End Select

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "S/FRA. " & NombreProveedor
            asiLin.Cuenta = Cuenta
            asiLin.DH = "D"
            asiLin.Importe = VaDec(Cuota.ToString("0.00"))
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)

        Next


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'RETENCIONES (la contrapartida ya la hemos asignado)
        asiLin = New Contabilizacion.clAsientoLineas
        asiLin.Concepto = "S/FRA. " & NombreProveedor
        asiLin.DH = "H"
        asiLin.Cuenta = TipoIvaSoportado.CuentaRet.Valor
        asiLin.Importe = VaDec(CuotaRet.ToString("0.00"))
        asiLin.Documento = Me.FRR_numerofactura.Valor
        asiLin.idConcepto = 0
        asiLin.IdActividad = Actividad
        asiLin.IdSeccion = Seccion
        asiLin.IdDepartamento = 0
        asiLin.IdSubDepartamento = 0
        c.ListaClAsientosLineas.Add(asiLin)


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'IMPORTACIONES (Si procede)
        If ConImportacion Then

            TipoIvaSoportado = New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            TipoIvaSoportado.LeerId(FacturasRecibidasImportaciones.FRI_IdTipoIva.Valor)

            Dim CtaImportacion As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            CtaImportacion.LeerId(FacturasRecibidasImportaciones.FRI_idcuenta.Valor)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'PARTE1
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = FacturasRecibidasImportaciones.FRI_Concepto.Valor
            asiLin.Cuenta = TipoIvaSoportado.Cuenta1.Valor
            asiLin.DH = "D"
            asiLin.Documento = FacturasRecibidasImportaciones.FRI_Documento.Valor
            asiLin.idConcepto = 1
            asiLin.Importe = VaDec(ImporteIvaImportacion)
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            asiLin.SRPC = "S"


            Dim clI As New Contabilizacion.clIva
            clI.FechaFactura = Me.FRR_fechafactura.Valor
            clI.IdTipoIva = FacturasRecibidasImportaciones.FRI_IdTipoIva.Valor
            clI.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
            cl.TotalFactura = VaDec(VaDec(FacturasRecibidasImportaciones.FRI_Base.Valor).ToString("0.00")) + ImporteIvaImportacion
            clI.Nif = CtaImportacion.Nif.Valor
            clI.Nombre = CtaImportacion.Nombre.Valor
            clI.NumCuenta = FacturasRecibidasImportaciones.FRI_idcuenta.Valor
            clI.Serie = ""
            clI.NumFactura = FacturasRecibidasImportaciones.FRI_Documento.Valor
            clI.Soportado = True
            clI.Descripcion = FacturasRecibidasImportaciones.FRI_Concepto.Valor & ""

            If CodigoPais = "" Or CodigoPais = "ES" Then
                clI.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.NIF).ToString
            Else
                clI.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.DocumentoPaisResidencia).ToString
                clI.CodigoPais = CodigoPais
            End If

            If ClaveRegimen <> -1 Then
                clI.FechaHora_AEAT = Now.ToString("yyyyMMddHHmmss")
            Else
                clI.Ignorar_AEAT = True
            End If

            'clI.TipoIdentificacion = FacturasRecibidasImportaciones.FRI_TipoIdentificacion.Valor & ""
            'clI.CodigoPais = FacturasRecibidasImportaciones.FRI_CodigoPais.Valor & ""

            Dim desgloseI As New Contabilizacion.clIva.DesgloseIvas
            desgloseI.base = VaDec(FacturasRecibidasImportaciones.FRI_Base.Valor)
            desgloseI.cuota = ImporteIvaImportacion
            desgloseI.CuotaRecargo = 0
            desgloseI.porcentaje = FacturasRecibidasImportaciones.FRI_PorcentajeIva.Valor
            desgloseI.porcenRecargo = 0
            clI.MisDesgloseIvas.Add(desgloseI)

            asiLin.clIva = clI
            c.ListaClAsientosLineas.Add(asiLin)


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'PARTE1
            asiLin = New Contabilizacion.clAsientoLineas

            asiLin.Concepto = FacturasRecibidasImportaciones.FRI_Concepto.Valor
            asiLin.Cuenta = FacturasRecibidasImportaciones.FRI_CuentaSuplido.Valor
            asiLin.DH = "D"
            asiLin.Documento = FacturasRecibidasImportaciones.FRI_Documento.Valor
            asiLin.idConcepto = 1
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            asiLin.Importe = VaDec(ImporteSuplidoImportacion)
            asiLin.SRPC = "S"
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' contabilizacion del recibo cuando hay cuenta de cartera
        If EmitirPago = "N" And Me.FRR_CtaCartera.Valor <> "" Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "S/FRA. " & NombreProveedor
            asiLin.DH = "H"
            asiLin.Cuenta = Me.FRR_CtaCartera.Valor
            asiLin.Importe = VaDec(Me.FRR_ImporteVto.Valor)
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)


            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "S/FRA. " & NombreProveedor
            asiLin.DH = "D"
            asiLin.Cuenta = Me.FRR_IdCuenta.Valor
            asiLin.Importe = VaDec(Me.FRR_ImporteVto.Valor)
            asiLin.Documento = Me.FRR_numerofactura.Valor
            asiLin.idConcepto = 0
            asiLin.IdActividad = Actividad
            asiLin.IdSeccion = Seccion
            asiLin.IdDepartamento = 0
            asiLin.IdSubDepartamento = 0
            c.ListaClAsientosLineas.Add(asiLin)


        End If


        ''Fondo operativo
        'If Me.FRR_FondoOperativo.Valor = "S" And (Subvencionable <> 0 Or NoFondoMasIVA <> 0) Then

        '    Dim Concepto As String = "FRA. F.O. RECIBIDA G.C."
        '    Dim Documento As String = VaInt(Me.FRR_idproveedor.Valor) & "/ " & (Me.FRR_numerofactura.Valor & "").Trim


        '    Dim PrefijoCtaSubvencionable As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_FONDOOPERATIVO_SUBVENCIONABLE)           '5540
        '    Dim PrefijoCtaNoSubvencionable As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_FONDOOPERATIVO_NOSUBVENCIONABLE)       '554700


        '    If PrefijoCtaSubvencionable.Trim = "" Then
        '        MsgBox("Error al contabilizar, falta indicar el prefijo de la cuenta para el importe subvencionable en configuraciones diversas")
        '        Return 0
        '    End If

        '    If PrefijoCtaNoSubvencionable.Trim = "" Then
        '        MsgBox("Error al contabilizar, falta indicar el prefijo de la cuenta para el importe NO subvencionable en configuraciones diversas")
        '        Return 0
        '    End If


        '    Dim CtaSubvencionableOrigen As String = PrefijoCtaSubvencionable & MiMaletin.Ejercicio.ToString("00") & "00100"
        '    Dim CtaSubvencionableDestino As String = PrefijoCtaSubvencionable & MiMaletin.Ejercicio.ToString("00") & "10100"
        '    Dim CtaNoFondoMasIVAOrigen As String = PrefijoCtaNoSubvencionable & "00100"
        '    Dim CtaNoFondoMasIVADestino As String = PrefijoCtaNoSubvencionable & "10100"


        '    If Subvencionable <> 0 Then

        '        asiLin = New Contabilizacion.clAsientoLineas
        '        asiLin.Concepto = Concepto
        '        asiLin.Cuenta = CtaSubvencionableOrigen
        '        asiLin.DH = "D"
        '        asiLin.Documento = Documento
        '        asiLin.IdActividad = Actividad
        '        asiLin.idConcepto = 0
        '        asiLin.IdSeccion = Seccion
        '        asiLin.IdDepartamento = 0
        '        asiLin.IdSubDepartamento = 0
        '        asiLin.Importe = Subvencionable
        '        asiLin.SRPC = ""
        '        c.ListaClAsientosLineas.Add(asiLin)

        '        asiLin = New Contabilizacion.clAsientoLineas
        '        asiLin.Concepto = Concepto
        '        asiLin.Cuenta = CtaSubvencionableDestino
        '        asiLin.DH = "H"
        '        asiLin.Documento = Documento
        '        asiLin.IdActividad = Actividad
        '        asiLin.idConcepto = 0
        '        asiLin.IdSeccion = Seccion
        '        asiLin.IdDepartamento = 0
        '        asiLin.IdSubDepartamento = 0
        '        asiLin.Importe = Subvencionable
        '        asiLin.SRPC = ""
        '        c.ListaClAsientosLineas.Add(asiLin)

        '    End If

        '    If NoFondoMasIVA <> 0 Then
        '        asiLin = New Contabilizacion.clAsientoLineas
        '        asiLin.Concepto = Concepto
        '        asiLin.Cuenta = CtaNoFondoMasIVAOrigen
        '        asiLin.DH = "D"
        '        asiLin.Documento = Documento
        '        asiLin.IdActividad = Actividad
        '        asiLin.idConcepto = 0
        '        asiLin.IdSeccion = Seccion
        '        asiLin.IdDepartamento = 0
        '        asiLin.IdSubDepartamento = 0
        '        asiLin.Importe = NoFondoMasIVA
        '        asiLin.SRPC = ""
        '        c.ListaClAsientosLineas.Add(asiLin)


        '        asiLin = New Contabilizacion.clAsientoLineas
        '        asiLin.Concepto = Concepto
        '        asiLin.Cuenta = CtaNoFondoMasIVADestino
        '        asiLin.DH = "H"
        '        asiLin.Documento = Documento
        '        asiLin.IdActividad = Actividad
        '        asiLin.idConcepto = 0
        '        asiLin.IdSeccion = Seccion
        '        asiLin.IdDepartamento = 0
        '        asiLin.IdSubDepartamento = 0
        '        asiLin.Importe = NoFondoMasIVA
        '        asiLin.SRPC = ""

        '    End If


        '    c.ListaClAsientosLineas.Add(asiLin)


        'End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'CONTABILIZAR


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FRR_IdEmpresa.Valor)), VaInt(Me.FRR_IdAsientoNet.Valor), VaInt(Me.FRR_idcentro.Valor), CDate(Me.FRR_fechactb.Valor), Me.FRR_ejercicio.Valor, VaInt(Me.FRR_IdPuntoVenta.Valor), E_Asientos.AsientoFacturasRecibida, IdFactura)

        If Resultado > 0 Then
            Me.FRR_IdAsientoNet.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function



    Private Sub E_Facturasrecibidas_EliminaHijos() Handles Me.EliminaHijos

        'Elimina las Importaciones de la factura
        Dim FacturasRecibidasImportaciones As New E_FacturasRecibidasImportaciones(Idusuario, cn)
        If FacturasRecibidasImportaciones.LeerId(Me.FRR_Id.Valor) Then
            FacturasRecibidasImportaciones.Eliminar()
        End If

        'Actualiza los albaranes/gastos con idfactura = 0
        Dim tipoFactura As String = (Me.FRR_tipofactura.Valor & "").Trim
        Dim consulta As New Cdatos.E_select


        Select Case tipoFactura.ToUpper

            Case TipoFacturaRecibida.ComprasGenero

                Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
                consulta.SelCampo(AlbEntrada_His.AEH_id, "Id")
                consulta.WheCampo(AlbEntrada_His.AEH_idfacturafirme, "=", Me.FRR_Id.Valor)

                Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)
                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If AlbEntrada_His.LeerId(Id) Then
                        AlbEntrada_His.AEH_idfacturafirme.Valor = "0"
                        AlbEntrada_His.Actualizar()
                    End If
                Next

            Case TipoFacturaRecibida.GastosCompras

                Dim AlbEntrada_HisGastos As New E_albentrada_hisgastos(Idusuario, cn)
                consulta.SelCampo(AlbEntrada_HisGastos.AHG_id, "Id")
                consulta.WheCampo(AlbEntrada_HisGastos.AHG_idfacturaproveedor, "=", Me.FRR_Id.Valor)

                Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)
                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If AlbEntrada_HisGastos.LeerId(Id) Then
                        AlbEntrada_HisGastos.AHG_idfacturaproveedor.Valor = "0"
                        AlbEntrada_HisGastos.Actualizar()
                    End If
                Next

            Case TipoFacturaRecibida.GastosVentas

                Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
                consulta.SelCampo(AlbSalida_Gastos.ASG_id, "Id")
                consulta.WheCampo(AlbSalida_Gastos.ASG_idfactura, "=", Me.FRR_Id.Valor)

                Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)
                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If AlbSalida_Gastos.LeerId(Id) Then
                        AlbSalida_Gastos.ASG_idfactura.Valor = "0"
                        AlbSalida_Gastos.Actualizar()
                    End If
                Next

            Case TipoFacturaRecibida.Materiales

                Dim AlbMaterial As New E_AlbMaterial(Idusuario, cn)
                consulta.SelCampo(AlbMaterial.AMA_Idalb, "Id")
                consulta.WheCampo(AlbMaterial.AMA_idfactura, "=", Me.FRR_Id.Valor)

                Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)
                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If AlbMaterial.LeerId(Id) Then
                        AlbMaterial.AMA_idfactura.Valor = "0"
                        AlbMaterial.Actualizar()
                    End If
                Next

        End Select

    End Sub



End Class
