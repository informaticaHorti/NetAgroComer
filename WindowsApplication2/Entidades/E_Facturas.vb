Public Class E_Facturas
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public FRA_idfactura As Cdatos.bdcampo
    Public FRA_serie As Cdatos.bdcampo
    Public FRA_factura As Cdatos.bdcampo
    Public FRA_fecha As Cdatos.bdcampo
    Public FRA_idcliente As Cdatos.bdcampo
    Public FRA_idpuntoventa As Cdatos.bdcampo
    Public FRA_campa As Cdatos.bdcampo
    Public FRA_tipofactura As Cdatos.bdcampo
    Public FRA_cdpais As Cdatos.bdcampo
    Public FRA_cddivisa As Cdatos.bdcampo
    Public FRA_valorcambio As Cdatos.bdcampo
    Public FRA_totalfactura As Cdatos.bdcampo
    'Public FRA_idfacturaNet As Cdatos.bdcampo
    Public FRA_idasientoNet As Cdatos.bdcampo
    Public FRA_Base1 As Cdatos.bdcampo
    Public FRA_Base2 As Cdatos.bdcampo
    Public FRA_Base3 As Cdatos.bdcampo
    Public FRA_Base4 As Cdatos.bdcampo
    Public FRA_Iva1 As Cdatos.bdcampo
    Public FRA_Iva2 As Cdatos.bdcampo
    Public FRA_Iva3 As Cdatos.bdcampo
    Public FRA_Iva4 As Cdatos.bdcampo
    Public FRA_Cuota1 As Cdatos.bdcampo
    Public FRA_Cuota2 As Cdatos.bdcampo
    Public FRA_Cuota3 As Cdatos.bdcampo
    Public FRA_Cuota4 As Cdatos.bdcampo
    Public FRA_Re1 As Cdatos.bdcampo
    Public FRA_Re2 As Cdatos.bdcampo
    Public FRA_Re3 As Cdatos.bdcampo
    Public FRA_Re4 As Cdatos.bdcampo
    Public FRA_CuotaRe1 As Cdatos.bdcampo
    Public FRA_CuotaRe2 As Cdatos.bdcampo
    Public FRA_CuotaRe3 As Cdatos.bdcampo
    Public FRA_CuotaRe4 As Cdatos.bdcampo
    Public FRA_idvaleenvase As Cdatos.bdcampo
    Public FRA_FacturaEnvases As Cdatos.bdcampo
    Public FRA_FacturaGasto As Cdatos.bdcampo
    Public FRA_clientealbaranes As Cdatos.bdcampo
    Public FRA_idformadepago As Cdatos.bdcampo
    Public FRA_fechavto As Cdatos.bdcampo
    Public FRA_cuentaventas1 As Cdatos.bdcampo
    Public FRA_cuentaventas2 As Cdatos.bdcampo
    Public FRA_cuentaventas3 As Cdatos.bdcampo
    Public FRA_alhcom As Cdatos.bdcampo
    Public FRA_idcentro As Cdatos.bdcampo
    Public FRA_obs1 As Cdatos.bdcampo
    Public FRA_obs2 As Cdatos.bdcampo
    Public FRA_RefCliente As Cdatos.bdcampo
    Public FRA_idempresa As Cdatos.bdcampo
    Public FRA_Suplido As Cdatos.bdcampo
    Public FRA_idacreedor As Cdatos.bdcampo
    Public FRA_IdTipoIva As Cdatos.bdcampo


    Public FRA_IdUsuarioLog As Cdatos.bdcampo
    Public FRA_FechaLog As Cdatos.bdcampo
    Public FRA_HoraLog As Cdatos.bdcampo



    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Facturas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FRA_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.Entero, 10, 0, True)
            FRA_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            FRA_serie = New Cdatos.bdcampo(CodigoEntidad & "serie", Cdatos.TiposCampo.Cadena, 3)
            FRA_factura = New Cdatos.bdcampo(CodigoEntidad & "factura", Cdatos.TiposCampo.Entero, 6)
            FRA_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            FRA_idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.Entero, 5)
            FRA_idpuntoventa = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.Entero, 2)
            FRA_tipofactura = New Cdatos.bdcampo(CodigoEntidad & "tipofactura", Cdatos.TiposCampo.Cadena, 1)
            FRA_cdpais = New Cdatos.bdcampo(CodigoEntidad & "cdpais", Cdatos.TiposCampo.Entero, 2)
            FRA_cddivisa = New Cdatos.bdcampo(CodigoEntidad & "cddivisa", Cdatos.TiposCampo.Entero, 2)
            FRA_valorcambio = New Cdatos.bdcampo(CodigoEntidad & "valorcambio", Cdatos.TiposCampo.Importe, 10, 6)
            FRA_totalfactura = New Cdatos.bdcampo(CodigoEntidad & "totalfactura", Cdatos.TiposCampo.Importe, 10, 2)
            'FRA_idfacturaNet = New Cdatos.bdcampo(CodigoEntidad & "idfacturanet", Cdatos.TiposCampo.Entero, 6)
            FRA_idasientoNet = New Cdatos.bdcampo(CodigoEntidad & "idasientonet", Cdatos.TiposCampo.Entero, 6)
            FRA_Base1 = New Cdatos.bdcampo(CodigoEntidad & "base1", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Base2 = New Cdatos.bdcampo(CodigoEntidad & "base2", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Base3 = New Cdatos.bdcampo(CodigoEntidad & "base3", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Base4 = New Cdatos.bdcampo(CodigoEntidad & "base4", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Iva1 = New Cdatos.bdcampo(CodigoEntidad & "iva1", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Iva2 = New Cdatos.bdcampo(CodigoEntidad & "iva2", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Iva3 = New Cdatos.bdcampo(CodigoEntidad & "iva3", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Iva4 = New Cdatos.bdcampo(CodigoEntidad & "iva4", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Cuota1 = New Cdatos.bdcampo(CodigoEntidad & "cuota1", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Cuota2 = New Cdatos.bdcampo(CodigoEntidad & "cuota2", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Cuota3 = New Cdatos.bdcampo(CodigoEntidad & "cuota3", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Cuota4 = New Cdatos.bdcampo(CodigoEntidad & "cuota4", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Re1 = New Cdatos.bdcampo(CodigoEntidad & "re1", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Re2 = New Cdatos.bdcampo(CodigoEntidad & "re2", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Re3 = New Cdatos.bdcampo(CodigoEntidad & "re3", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_Re4 = New Cdatos.bdcampo(CodigoEntidad & "re4", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_CuotaRe1 = New Cdatos.bdcampo(CodigoEntidad & "cuotare1", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_CuotaRe2 = New Cdatos.bdcampo(CodigoEntidad & "cuotare2", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_CuotaRe3 = New Cdatos.bdcampo(CodigoEntidad & "cuotare3", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_CuotaRe4 = New Cdatos.bdcampo(CodigoEntidad & "cuotare4", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_idvaleenvase = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvase", Cdatos.TiposCampo.Entero, 6)
            FRA_FacturaEnvases = New Cdatos.bdcampo(CodigoEntidad & "FacturaEnvases", Cdatos.TiposCampo.Cadena, 2)
            FRA_FacturaGasto = New Cdatos.bdcampo(CodigoEntidad & "FacturaGasto", Cdatos.TiposCampo.Cadena, 2)
            FRA_clientealbaranes = New Cdatos.bdcampo(CodigoEntidad & "clientealbaranes", Cdatos.TiposCampo.Entero, 6)
            FRA_idformadepago = New Cdatos.bdcampo(CodigoEntidad & "idformadepago", Cdatos.TiposCampo.Entero, 6)
            FRA_fechavto = New Cdatos.bdcampo(CodigoEntidad & "fechavto", Cdatos.TiposCampo.Fecha, 10)
            FRA_cuentaventas1 = New Cdatos.bdcampo(CodigoEntidad & "cuentaventas1", Cdatos.TiposCampo.Cuenta, 11)
            FRA_cuentaventas2 = New Cdatos.bdcampo(CodigoEntidad & "cuentaventas2", Cdatos.TiposCampo.Cuenta, 11)
            FRA_cuentaventas3 = New Cdatos.bdcampo(CodigoEntidad & "cuentaventas3", Cdatos.TiposCampo.Cuenta, 11)
            FRA_alhcom = New Cdatos.bdcampo(CodigoEntidad & "alhcom", Cdatos.TiposCampo.Cadena, 1)
            FRA_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 2)
            FRA_obs1 = New Cdatos.bdcampo(CodigoEntidad & "obs1", Cdatos.TiposCampo.Cadena, 50)
            FRA_obs2 = New Cdatos.bdcampo(CodigoEntidad & "obs2", Cdatos.TiposCampo.Cadena, 50)
            FRA_RefCliente = New Cdatos.bdcampo(CodigoEntidad & "RefCliente", Cdatos.TiposCampo.Cadena, 50)
            FRA_idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.Entero, 2)
            FRA_Suplido = New Cdatos.bdcampo(CodigoEntidad & "Suplido", Cdatos.TiposCampo.Importe, 10, 2)
            FRA_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "IdAcreedor", Cdatos.TiposCampo.EnteroPositivo, 5)
            FRA_IdTipoIva = New Cdatos.bdcampo(CodigoEntidad & "IdTipoIva", Cdatos.TiposCampo.Entero, 10)

            FRA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FRA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FRA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.FRA_serie)
            _lstCamposDocumento.Add(Me.FRA_factura)

            'Para la subida automática a Gestión Documental (DOCUMENTO_ERP)
            _lstCamposDocumentoExtendido.Add(Me.FRA_idempresa)
            _lstCamposDocumentoExtendido.Add(Me.FRA_campa)
            _lstCamposDocumentoExtendido.AddRange(_lstCamposDocumento)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Factura de Cliente"


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.FRA_idfactura, "IdFactura")
        consulta.SelCampo(Me.FRA_serie, "Serie")
        consulta.SelCampo(Me.FRA_factura, "Factura")
        consulta.SelCampo(Me.FRA_fecha, "Fecha")
        consulta.SelCampo(Me.FRA_idcliente, "codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.FRA_idcliente)
        consulta.SelCampo(Me.FRA_totalfactura, "TotalFactura")
        consulta.SelCampo(Me.FRA_alhcom, "AC")



        _btBusca.Params("IdFactura", , -1)
        _btBusca.Params("TotalFactura", "Total", , True, "#,##0.00")


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


        _btBusca.CL_CampoOrden = "Cliente"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Factura"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFaccli"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


        _btBusca.ParamConsultaAlb(consulta, "", Me.FRA_idcliente, Me.FRA_fecha, Me.FRA_idcentro, Me.FRA_idempresa)

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)

    End Sub



    Public Function LeerFac(ByVal IdEmpresa As Integer, ByVal Campa As Integer, ByVal serie As String, ByVal numfac As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.FRA_idempresa, "=", IdEmpresa.ToString)
        CONSULTA.WheCampo(Me.FRA_campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.FRA_serie, "=", serie)
        CONSULTA.WheCampo(Me.FRA_factura, "=", numfac.ToString)

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


    Public Function ExisteFac(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal serie As String, ByVal numfac As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)
        CONSULTA.WheCampo(Me.FRA_idempresa, "=", idempresa.ToString)
        CONSULTA.WheCampo(Me.FRA_campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.FRA_serie, "=", serie)
        CONSULTA.WheCampo(Me.FRA_factura, "=", numfac.ToString)

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


    Public Function MaxIdCampa(ByVal idempresa As Integer, ByVal Campa As Integer, ByVal serie As String, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(idempresa.ToString + "_" + Campa.ToString + "_" + serie, vmax)
                existe = ExisteFac(idempresa, Campa, serie, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
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


    Private Sub E_facturas_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        Dim dt As New DataTable

        sql = "update albsalidaalh set AAH_idfactura=0 where AAH_idfactura=" + Me.FRA_idfactura.Valor
        MiConexion.ConsultaSQL(sql)

        sql = "update albsalida set ASA_idfactura=0 where ASA_idfactura=" + Me.FRA_idfactura.Valor
        MiConexion.ConsultaSQL(sql)

        sql = "update valeenvases set VEV_IdFactura=0 where VEV_IdFactura=" + Me.FRA_idfactura.Valor
        MiConexion.ConsultaSQL(sql)

        sql = "update valeenvases_lineas set VEL_IdFacturaEnvase = 0 where VEL_IdFacturaEnvase = " + Me.FRA_idfactura.Valor
        MiConexion.ConsultaSQL(sql)


    End Sub


    Public Overrides Function Eliminar() As Boolean
        Return MyBase.Eliminar()

    End Function


    Public Function Contabiliza(ByVal IdFactura As Integer) As Integer

        Dim Resultado As Integer


        If Me.LeerId(IdFactura) = False Then
            Return 0
        End If

        Dim Emp As Integer = VaInt(Me.FRA_idempresa.Valor)

        Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Emp))
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Emp))
        Dim Tiposclientes As New E_Tiposclientes(Idusuario, cn)
        Dim IdCentro As String = ""

        Dim c As New Contabilizacion.clAsientos
        Dim asiLin As New Contabilizacion.clAsientoLineas

        Dim IdActividad As String = "0"
        Dim IdSeccion As String = "0"
        Dim IdDepartamento As String = "0"
        Dim IdSubDepartamento As String = "0"



        If PuntoVenta.LeerId(Me.FRA_idpuntoventa.Valor) Then
            IdActividad = VaInt(PuntoVenta.IdActividad.Valor).ToString
            IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor).ToString
            IdCentro = PuntoVenta.IdCentro.Valor
        End If



        Dim ClaveRegimen As Integer = -1


        Dim NombreCliente As String = ""
        Dim ClienteInterno As Boolean = False
        If Clientes.LeerId(Me.FRA_idcliente.Valor) Then NombreCliente = Clientes.CLI_Nombre.Valor & ""
        If Tiposclientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then

            Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, ConexCtb(Emp))
            If TipoIvaRepercutido.LeerId(Tiposclientes.TPC_idtipoiva.Valor) Then
                ClaveRegimen = VaInt(TipoIvaRepercutido.ClaveRegimenTrascendencia.Valor)
            End If


            If Tiposclientes.TPC_clienteinterno.Valor = "S" Then
                ClienteInterno = True
            End If

        End If
        Dim Cambio As Decimal = VaDec(Me.FRA_valorcambio.Valor)
        If Cambio = 0 Then Cambio = 1


        Dim CuentaCliente As String = ""
        Dim CuentaEnvRetornable As String = ""
        Dim TipoFactura As String = (Me.FRA_alhcom.Valor & "").Trim.ToUpper


        If ClienteInterno = False Then
            CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
            CuentaEnvRetornable = Left(Tiposclientes.TPC_ctadevenvases.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
        Else
            CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + "00000"
            CuentaEnvRetornable = Left(Tiposclientes.TPC_ctadevenvases.Valor, 6) + "00000"
        End If


        Dim CuentaAcreedor As String = ""
        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If VaInt(Me.FRA_idacreedor.Valor) > 0 Then
            If Acreedores.LeerId(Me.FRA_idacreedor.Valor) Then
                CuentaAcreedor = Acreedores.ACR_IdCuenta.Valor
            End If
        End If


        'If TipoFactura = "E" Then
        '    If ClienteInterno = False Then
        '        CuentaCliente = Left(Tiposclientes.TPC_ctaenvases.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
        '    Else
        '        CuentaCliente = Left(Tiposclientes.TPC_ctaenvases.Valor, 6) + "00000"
        '    End If
        'Else
        '    If ClienteInterno = False Then
        '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
        '    Else
        '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + "00000"
        '    End If
        'End If



        Dim Base1 As Decimal = VaDec(Me.FRA_Base1.Valor) * Cambio
        Dim Base2 As Decimal = VaDec(Me.FRA_Base2.Valor) * Cambio
        Dim Base3 As Decimal = VaDec(Me.FRA_Base3.Valor) * Cambio
        Dim Base4 As Decimal = VaDec(Me.FRA_Base4.Valor) * Cambio

        Dim CuotaIva1 As Decimal = VaDec(Me.FRA_Cuota1.Valor) * Cambio
        Dim CuotaIva2 As Decimal = VaDec(Me.FRA_Cuota2.Valor) * Cambio
        Dim CuotaIva3 As Decimal = VaDec(Me.FRA_Cuota3.Valor) * Cambio
        Dim CuotaIva4 As Decimal = VaDec(Me.FRA_Cuota4.Valor) * Cambio

        Dim CuotaRe1 As Decimal = VaDec(Me.FRA_CuotaRe1.Valor) * Cambio
        Dim CuotaRe2 As Decimal = VaDec(Me.FRA_CuotaRe2.Valor) * Cambio
        Dim CuotaRe3 As Decimal = VaDec(Me.FRA_CuotaRe3.Valor) * Cambio
        Dim CuotaRe4 As Decimal = VaDec(Me.FRA_CuotaRe4.Valor) * Cambio

        Dim Suplido As Decimal = VaDec(Me.FRA_Suplido.Valor) * Cambio

        Dim importe = (Base1 + Base2 + Base3 + Base4 + CuotaIva1 + CuotaIva2 + CuotaIva3 + CuotaIva4 + CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4)

        asiLin = New Contabilizacion.clAsientoLineas
        asiLin.Concepto = "N/FRA. " & NombreCliente
        asiLin.Cuenta = CuentaCliente
        asiLin.DH = "D"
        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
        asiLin.IdActividad = IdActividad
        asiLin.idConcepto = 0
        asiLin.IdSeccion = IdSeccion
        asiLin.IdDepartamento = IdDepartamento
        asiLin.IdSubDepartamento = IdSubDepartamento
        asiLin.Importe = VaDec(importe.ToString("0.00"))
        asiLin.SRPC = "R"


        'DESGLOSE IVA
        Cuentas.LeerId(CuentaCliente)

        Dim Descripcion As String = ""
        Dim CodigoPais As String = SII_ObtenerDatosCliente(FRA_idcliente.Valor, FRA_serie.Valor, FRA_factura.Valor, Descripcion)


        Dim cl As New Contabilizacion.clIva
        cl.FechaFactura = Me.FRA_fecha.Valor & ""
        If VaInt(Me.FRA_IdTipoIva.Valor) = 0 Then
            cl.IdTipoIva = Tiposclientes.TPC_idtipoiva.Valor & ""
        Else
            cl.IdTipoIva = Me.FRA_IdTipoIva.Valor & ""
        End If
        cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
        cl.TotalFactura = VaDec(importe.ToString("0.00"))
        cl.Nif = Cuentas.Nif.Valor & ""
        cl.Descripcion = Descripcion

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


        cl.Nombre = NombreCliente
        cl.NumCuenta = CuentaCliente & ""
        cl.Serie = Me.FRA_serie.Valor & ""
        cl.NumFactura = Me.FRA_factura.Valor & ""

        cl.Soportado = False
        cl.SujetoIVA = True
        cl.ExentoIVA = False


        For i = 0 To 3

            Select Case i + 1

                Case 1

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base1
                    desglose.cuota = CuotaIva1
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRA_Iva1.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 2

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base2
                    desglose.cuota = CuotaIva2
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRA_Iva2.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 3

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base3
                    desglose.cuota = CuotaIva3
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRA_Iva3.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

                Case 4

                    Dim desglose As New Contabilizacion.clIva.DesgloseIvas
                    desglose.base = Base4
                    desglose.cuota = CuotaIva4
                    desglose.CuotaRecargo = 0
                    desglose.porcentaje = VaDec(Me.FRA_Iva4.Valor)
                    desglose.porcenRecargo = 0
                    cl.MisDesgloseIvas.Add(desglose)

            End Select

        Next



        ''-------------------------------------
        asiLin.clIva = cl
        c.ListaClAsientosLineas.Add(asiLin)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' desglose de bases imponibles
        Dim Ibase1 As Decimal = 0
        Dim Ncta1 As String = ""
        Dim Ibase2 As Decimal = 0
        'Dim Ncta2 As String = ""
        Dim Ibase3 As Decimal = 0
        Dim Ncta3 As String = 0
        Dim Ibase4 As Decimal = 0
        Dim Ncta4 As String = ""


        '
        Ibase1 = Base1
        Ibase2 = Base2
        Ibase3 = Base3
        Ibase4 = Base4

        Ncta1 = Tiposclientes.TPC_ctaventas.Valor
        'Ncta2 = Me.FRA_cuentaventas2.Valor
        Ncta3 = Me.FRA_cuentaventas3.Valor
        Ncta4 = Me.FRA_cuentaventas3.Valor


        ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

       

        'If Ibase1 <> 0 Then

        '    Dim dc As Dictionary(Of Integer, Decimal) = DesglosarPorFamilia(IdFactura, Ibase1)

        '    For Each f In dc.Keys

        '        If dc(f) <> 0 Then
        '            asiLin = New Contabilizacion.clAsientoLineas
        '            asiLin.Concepto = "N/FRA. " & NombreCliente
        '            If f > 100 Then
        '                asiLin.Cuenta = Mid(Ncta1, 1, 8) + f.ToString.Substring(1, 1) + Mid(Ncta1, 10, 2)
        '            Else
        '                asiLin.Cuenta = Mid(Ncta1, 1, 8) + FnLeft(f, 1).PadLeft(1, "0") + Mid(Ncta1, 10, 2)
        '            End If
        '            asiLin.DH = "H"
        '            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
        '            asiLin.IdActividad = IdActividad
        '            asiLin.idConcepto = 0
        '            asiLin.IdSeccion = IdSeccion
        '            asiLin.IdDepartamento = IdDepartamento
        '            asiLin.IdSubDepartamento = IdSubDepartamento
        '            asiLin.Importe = VaDec(dc(f).ToString("0.00"))
        '            asiLin.SRPC = ""
        '            c.ListaClAsientosLineas.Add(asiLin)
        '        End If

        '    Next

        'End If

        If Ibase1 <> 0 Then

            Dim dt1 As DataTable = DesglosarPorFamilia(IdFactura, Ibase1)

            For Each row As DataRow In dt1.Rows

                Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
                Dim Importe_por_centro As Decimal = VaDec(row("Importe"))
                Dim IdActividad_por_centro As Integer = VaInt(row("IdActividad"))
                Dim IdSeccion_por_centro As Integer = VaInt(row("IdSeccion"))

                If Importe_por_centro <> 0 Then
                    asiLin = New Contabilizacion.clAsientoLineas
                    asiLin.Concepto = "N/FRA. " & NombreCliente
                    If IdFamilia > 100 Then
                        asiLin.Cuenta = Mid(Ncta1, 1, 8) + IdFamilia.ToString.Substring(1, 1) + Mid(Ncta1, 10, 2)
                    Else
                        asiLin.Cuenta = Mid(Ncta1, 1, 8) + FnLeft(IdFamilia, 1).PadLeft(1, "0") + Mid(Ncta1, 10, 2)
                    End If
                    asiLin.DH = "H"
                    asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
                    asiLin.IdActividad = IdActividad_por_centro
                    asiLin.idConcepto = 0
                    asiLin.IdSeccion = IdSeccion_por_centro
                    asiLin.IdDepartamento = IdDepartamento
                    asiLin.IdSubDepartamento = IdSubDepartamento
                    asiLin.Importe = VaDec(Importe_por_centro.ToString("0.00"))
                    asiLin.SRPC = ""
                    c.ListaClAsientosLineas.Add(asiLin)
                End If

            Next

        End If


        'If Ibase2 <> 0 Then

        '    Dim dc As Dictionary(Of Integer, DatosFraEnvases) = DesglosarEnvasesPorFamilia(IdFactura, Ibase2)

        '    For Each f In dc.Keys

        '        Dim ImporteEnvase As Decimal = dc(f).Importe
        '        If ImporteEnvase <> 0 Then
        '            asiLin = New Contabilizacion.clAsientoLineas
        '            asiLin.Concepto = "N/FRA. " & NombreCliente
        '            asiLin.Cuenta = dc(f).CtaDevFianzas
        '            asiLin.DH = "H"
        '            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
        '            asiLin.IdActividad = IdActividad
        '            asiLin.idConcepto = 0
        '            asiLin.IdSeccion = IdSeccion
        '            asiLin.IdDepartamento = IdDepartamento
        '            asiLin.IdSubDepartamento = IdSubDepartamento
        '            asiLin.Importe = VaDec(dc(f).Importe.ToString("0.00"))
        '            asiLin.SRPC = ""
        '            c.ListaClAsientosLineas.Add(asiLin)
        '        End If
        '    Next
        'End If


        If Ibase2 <> 0 Then


            Dim dt2 As DataTable = Nothing

            If TipoFactura = "E" Then
                dt2 = DesglosarEnvasesPorEnvase(IdFactura, Ibase2)
            Else
                dt2 = DesglosarEnvasesPorFamilia(IdFactura, Ibase2)
            End If


            For Each row As DataRow In dt2.Rows

                Dim ImporteEnvase_por_centro As Decimal = VaDec(row("Importe"))
                Dim CtaDevFianzas As String = (row("CtaDevFianzas").ToString & "").Trim
                Dim IdActividad_por_centro As Integer = VaInt(row("IdActividad"))
                Dim IdSeccion_por_centro As Integer = VaInt(row("IdSeccion"))

                If ImporteEnvase_por_centro <> 0 Then
                    asiLin = New Contabilizacion.clAsientoLineas
                    asiLin.Concepto = "N/FRA. " & NombreCliente
                    asiLin.Cuenta = CtaDevFianzas
                    asiLin.DH = "H"
                    asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
                    asiLin.IdActividad = IdActividad_por_centro
                    asiLin.idConcepto = 0
                    asiLin.IdSeccion = IdSeccion_por_centro
                    asiLin.IdDepartamento = IdDepartamento
                    asiLin.IdSubDepartamento = IdSubDepartamento
                    asiLin.Importe = ImporteEnvase_por_centro.ToString("0.00")
                    asiLin.SRPC = ""
                    c.ListaClAsientosLineas.Add(asiLin)
                End If
            Next
        End If

       

        If Ibase3 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Ncta3
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Ibase3.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        If Ibase4 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Ncta4
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Ibase4.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'CONTABILIZAR

        If CuotaIva1 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Tiposclientes.TPC_ctaivaventas.Valor
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva1).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        If CuotaIva2 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Tiposclientes.TPC_ctaivaenvases.Valor
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva2).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        If CuotaIva3 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Tiposclientes.TPC_ctaivavarios.Valor
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva3).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        If CuotaIva4 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Tiposclientes.TPC_ctaivavarios.Valor
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaIva4).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If

        If CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4 <> 0 Then
            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = Tiposclientes.TPC_ctarecargo.Valor
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec((CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4).ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If


        If Suplido <> 0 Then

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = CuentaCliente
            asiLin.DH = "H"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Suplido.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

            asiLin = New Contabilizacion.clAsientoLineas
            asiLin.Concepto = "N/FRA. " & NombreCliente
            asiLin.Cuenta = CuentaAcreedor
            asiLin.DH = "D"
            asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
            asiLin.IdActividad = IdActividad
            asiLin.idConcepto = 0
            asiLin.IdSeccion = IdSeccion
            asiLin.IdDepartamento = IdDepartamento
            asiLin.IdSubDepartamento = IdSubDepartamento
            asiLin.Importe = VaDec(Suplido.ToString("0.00"))
            asiLin.SRPC = ""
            c.ListaClAsientosLineas.Add(asiLin)

        End If




        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FRA_idempresa.Valor)), VaInt(Me.FRA_idasientoNet.Valor), VaInt(IdCentro), CDate(Me.FRA_fecha.Valor), Me.FRA_campa.Valor, VaInt(Me.FRA_idpuntoventa.Valor), E_Asientos.AsientoFacturasEmitida, IdFactura)

        If Resultado > 0 Then
            Me.FRA_idasientoNet.Valor = Resultado.ToString
            Me.Actualizar()
        End If


        Return Resultado


    End Function


    Private Function DesglosarPorFamilia(idfactura As Integer, Base As Decimal) As DataTable

        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim AlbSalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        Dim sql As String = ""
        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(AlbSalida_lineas.ASL_importegenerovta, "ImporteLinea")
        Consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia", AlbSalida_lineas.ASL_idgenero)
        Consulta.SelCampo(SubFamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        Consulta.SelCampo(AlbSalida_lineas.ASL_gastoF, "GastoF")
        Consulta.SelCampo(Albsalida.ASA_valorcambio, "Cambio", AlbSalida_lineas.ASL_idalbaran)
        Consulta.SelCampo(Albsalida.ASA_idpuntoventa, "IdPuntoVenta")
        Consulta.SelCampo(Albsalida.ASA_idcentro, "IdCentro")
        Consulta.SelCampo(PuntoVenta.IdActividad, "IdActividad")
        Consulta.SelCampo(PuntoVenta.IdSeccion, "IdSeccion", Albsalida.ASA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        Consulta.WheCampo(Albsalida.ASA_idfactura, "=", idfactura.ToString)
        sql = Consulta.SQL


        sql = sql & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT SUM(COALESCE(FLV_Cantidad,0) * COALESCE(FLV_Precio,0) * COALESCE(FRA_ValorCambio,1)) as ImporteLinea, " & vbCrLf
        sql = sql & " GEN_idsubfamilia as idsubfamilia, SFA_IdFamilia as idfamilia, 0.00 as GastoF, FRA_ValorCambio as Cambio," & vbCrLf
        sql = sql & " FRA_IdPuntoVenta as IdPuntoVenta, FRA_IdCentro as IdCentro, IdActividad, IdSeccion" & vbCrLf
        sql = sql & " FROM Facturaslineasvar" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = FLV_Codigo" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON SFA_Id = GEN_IdSubFamilia" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = FLV_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN " & PuntoVenta.NombreBd & ".dbo.PuntoVenta ON IdPuntoVenta = FRA_IdPuntoVenta" & vbCrLf
        sql = sql & " WHERE FLV_IdFactura = " & idfactura.ToString & vbCrLf
        sql = sql & " AND FLV_TipoGEC = 'G'" & vbCrLf
        sql = sql & " GROUP BY SFA_IdFamilia, GEN_IdSubFamilia, FRA_ValorCambio, FRA_IdPuntoVenta, FRA_IdCentro, IdActividad, IdSeccion" & vbCrLf


        Dim Total As Decimal = 0
        Dim max As Decimal = 0
        Dim nmax As Integer = 0


        Dim acum As New Acumulador


        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each row In dt.Rows

                Dim importe As Decimal = VaDec(row("importelinea")) - VaDec(row("GastoF"))
                importe = Math.Round(importe, 2)
                Total = Total + importe

                Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
                Dim IdPuntoVenta As Integer = VaInt(row("IdPuntoVenta"))
                Dim IdCentro As Integer = VaInt(row("IdCentro"))
                Dim IdActividad As Integer = VaInt(row("IdActividad"))
                Dim IdSeccion As Integer = VaInt(row("IdSeccion"))

                Dim stClave As New stClave_AlbaranesPorCentro(IdFamilia, IdPuntoVenta, IdCentro, IdActividad, IdSeccion)
                Dim stDatos As New stDatos_AlbaranesPorCentro(importe)
                acum.Suma(stClave, stDatos)

            Next

        End If


        Dim dtFinal As DataTable = acum.DataTable
        Dim MaxImporte As Decimal = 0


        If Not IsNothing(dtFinal) Then

            For indice As Integer = 0 To dtFinal.Rows.Count - 1

                Dim rowFinal As DataRow = dtFinal.Rows(indice)

                Dim Importe As Decimal = VaDec(rowFinal("Importe"))
                If Importe > MaxImporte Then
                    MaxImporte = Importe
                    nmax = indice
                End If

            Next


            If nmax >= 0 Then
                dtFinal.Rows(nmax)("Importe") = dtFinal.Rows(nmax)("Importe") + Base - Total
            End If

        End If


        Return dtFinal

    End Function



    'Public Function ContabilizaEnvases(ByVal IdFactura As Integer) As Integer

    '    Dim Resultado As Integer


    '    If Me.LeerId(IdFactura) = False Then
    '        Return 0
    '    End If

    '    Dim Emp As Integer = VaInt(Me.FRA_idempresa.Valor)

    '    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(Emp))
    '    Dim Clientes As New E_Clientes(Idusuario, cn)
    '    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(Emp))
    '    Dim Tiposclientes As New E_Tiposclientes(Idusuario, cn)
    '    Dim IdCentro As String = ""

    '    Dim c As New Contabilizacion.clAsientos
    '    Dim asiLin As New Contabilizacion.clAsientoLineas

    '    Dim IdActividad As String = "0"
    '    Dim IdSeccion As String = "0"
    '    Dim IdDepartamento As String = "0"
    '    Dim IdSubDepartamento As String = "0"



    '    If PuntoVenta.LeerId(Me.FRA_idpuntoventa.Valor) Then
    '        IdActividad = VaInt(PuntoVenta.IdActividad.Valor).ToString
    '        IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor).ToString
    '        IdCentro = PuntoVenta.IdCentro.Valor
    '    End If



    '    Dim ClaveRegimen As Integer = -1


    '    Dim NombreCliente As String = ""
    '    Dim ClienteInterno As Boolean = False
    '    If Clientes.LeerId(Me.FRA_idcliente.Valor) Then NombreCliente = Clientes.CLI_Nombre.Valor & ""
    '    If Tiposclientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then

    '        Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, ConexCtb(Emp))
    '        If TipoIvaRepercutido.LeerId(Tiposclientes.TPC_idtipoiva.Valor) Then
    '            ClaveRegimen = VaInt(TipoIvaRepercutido.ClaveRegimenTrascendencia.Valor)
    '        End If


    '        If Tiposclientes.TPC_clienteinterno.Valor = "S" Then
    '            ClienteInterno = True
    '        End If

    '    End If
    '    Dim Cambio As Decimal = VaDec(Me.FRA_valorcambio.Valor)
    '    If Cambio = 0 Then Cambio = 1


    '    Dim CuentaCliente As String = ""
    '    Dim CuentaEnvRetornable As String = ""
    '    Dim TipoFactura As String = (Me.FRA_alhcom.Valor & "").Trim.ToUpper


    '    If ClienteInterno = False Then
    '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
    '        CuentaEnvRetornable = Left(Tiposclientes.TPC_ctadevenvases.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
    '    Else
    '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + "00000"
    '        CuentaEnvRetornable = Left(Tiposclientes.TPC_ctadevenvases.Valor, 6) + "00000"
    '    End If


    '    Dim CuentaAcreedor As String = ""
    '    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    '    If VaInt(Me.FRA_idacreedor.Valor) > 0 Then
    '        If Acreedores.LeerId(Me.FRA_idacreedor.Valor) Then
    '            CuentaAcreedor = Acreedores.ACR_IdCuenta.Valor
    '        End If
    '    End If


    '    'If TipoFactura = "E" Then
    '    '    If ClienteInterno = False Then
    '    '        CuentaCliente = Left(Tiposclientes.TPC_ctaenvases.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
    '    '    Else
    '    '        CuentaCliente = Left(Tiposclientes.TPC_ctaenvases.Valor, 6) + "00000"
    '    '    End If
    '    'Else
    '    '    If ClienteInterno = False Then
    '    '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + Fnc0(Me.FRA_idcliente.Valor, 5)
    '    '    Else
    '    '        CuentaCliente = Left(Tiposclientes.TPC_ctacliente.Valor, 6) + "00000"
    '    '    End If
    '    'End If



    '    Dim Base1 As Decimal = VaDec(Me.FRA_Base1.Valor) * Cambio
    '    Dim Base2 As Decimal = VaDec(Me.FRA_Base2.Valor) * Cambio
    '    Dim Base3 As Decimal = VaDec(Me.FRA_Base3.Valor) * Cambio
    '    Dim Base4 As Decimal = VaDec(Me.FRA_Base4.Valor) * Cambio

    '    Dim CuotaIva1 As Decimal = VaDec(Me.FRA_Cuota1.Valor) * Cambio
    '    Dim CuotaIva2 As Decimal = VaDec(Me.FRA_Cuota2.Valor) * Cambio
    '    Dim CuotaIva3 As Decimal = VaDec(Me.FRA_Cuota3.Valor) * Cambio
    '    Dim CuotaIva4 As Decimal = VaDec(Me.FRA_Cuota4.Valor) * Cambio

    '    Dim CuotaRe1 As Decimal = VaDec(Me.FRA_CuotaRe1.Valor) * Cambio
    '    Dim CuotaRe2 As Decimal = VaDec(Me.FRA_CuotaRe2.Valor) * Cambio
    '    Dim CuotaRe3 As Decimal = VaDec(Me.FRA_CuotaRe3.Valor) * Cambio
    '    Dim CuotaRe4 As Decimal = VaDec(Me.FRA_CuotaRe4.Valor) * Cambio

    '    Dim Suplido As Decimal = VaDec(Me.FRA_Suplido.Valor) * Cambio

    '    Dim importe = (Base1 + Base2 + Base3 + Base4 + CuotaIva1 + CuotaIva2 + CuotaIva3 + CuotaIva4 + CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4)

    '    asiLin = New Contabilizacion.clAsientoLineas
    '    asiLin.Concepto = "N/FRA. " & NombreCliente
    '    asiLin.Cuenta = CuentaCliente
    '    asiLin.DH = "D"
    '    asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '    asiLin.IdActividad = IdActividad
    '    asiLin.idConcepto = 0
    '    asiLin.IdSeccion = IdSeccion
    '    asiLin.IdDepartamento = IdDepartamento
    '    asiLin.IdSubDepartamento = IdSubDepartamento
    '    asiLin.Importe = VaDec(importe.ToString("0.00"))
    '    asiLin.SRPC = "R"


    '    'DESGLOSE IVA
    '    Cuentas.LeerId(CuentaCliente)

    '    Dim Descripcion As String = ""
    '    Dim CodigoPais As String = SII_ObtenerDatosCliente(FRA_idcliente.Valor, FRA_serie.Valor, FRA_factura.Valor, Descripcion)


    '    Dim cl As New Contabilizacion.clIva
    '    cl.FechaFactura = Me.FRA_fecha.Valor & ""
    '    If VaInt(Me.FRA_IdTipoIva.Valor) = 0 Then
    '        cl.IdTipoIva = Tiposclientes.TPC_idtipoiva.Valor & ""
    '    Else
    '        cl.IdTipoIva = Me.FRA_IdTipoIva.Valor & ""
    '    End If
    '    cl.MisDesgloseIvas = New List(Of Contabilizacion.clIva.DesgloseIvas)
    '    cl.TotalFactura = VaDec(importe.ToString("0.00"))
    '    cl.Nif = Cuentas.Nif.Valor & ""
    '    cl.Descripcion = Descripcion

    '    If CodigoPais = "" Or CodigoPais = "ES" Then
    '        cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.NIF).ToString
    '    Else
    '        cl.TipoIdentificacion = VaInt(Funciones_SII.TipoIdentificacion.DocumentoPaisResidencia).ToString
    '        cl.CodigoPais = CodigoPais
    '    End If

    '    If ClaveRegimen <> -1 Then
    '        cl.FechaHora_AEAT = Now.ToString("yyyyMMddHHmmss")
    '    Else
    '        cl.Ignorar_AEAT = True
    '    End If


    '    cl.Nombre = NombreCliente
    '    cl.NumCuenta = CuentaCliente & ""
    '    cl.Serie = Me.FRA_serie.Valor & ""
    '    cl.NumFactura = Me.FRA_factura.Valor & ""

    '    cl.Soportado = False
    '    cl.SujetoIVA = True
    '    cl.ExentoIVA = False


    '    For i = 0 To 3

    '        Select Case i + 1

    '            Case 1

    '                Dim desglose As New Contabilizacion.clIva.DesgloseIvas
    '                desglose.base = Base1
    '                desglose.cuota = CuotaIva1
    '                desglose.CuotaRecargo = 0
    '                desglose.porcentaje = VaDec(Me.FRA_Iva1.Valor)
    '                desglose.porcenRecargo = 0
    '                cl.MisDesgloseIvas.Add(desglose)

    '            Case 2

    '                Dim desglose As New Contabilizacion.clIva.DesgloseIvas
    '                desglose.base = Base2
    '                desglose.cuota = CuotaIva2
    '                desglose.CuotaRecargo = 0
    '                desglose.porcentaje = VaDec(Me.FRA_Iva2.Valor)
    '                desglose.porcenRecargo = 0
    '                cl.MisDesgloseIvas.Add(desglose)

    '            Case 3

    '                Dim desglose As New Contabilizacion.clIva.DesgloseIvas
    '                desglose.base = Base3
    '                desglose.cuota = CuotaIva3
    '                desglose.CuotaRecargo = 0
    '                desglose.porcentaje = VaDec(Me.FRA_Iva3.Valor)
    '                desglose.porcenRecargo = 0
    '                cl.MisDesgloseIvas.Add(desglose)

    '            Case 4

    '                Dim desglose As New Contabilizacion.clIva.DesgloseIvas
    '                desglose.base = Base4
    '                desglose.cuota = CuotaIva4
    '                desglose.CuotaRecargo = 0
    '                desglose.porcentaje = VaDec(Me.FRA_Iva4.Valor)
    '                desglose.porcenRecargo = 0
    '                cl.MisDesgloseIvas.Add(desglose)

    '        End Select

    '    Next



    '    ''-------------------------------------
    '    asiLin.clIva = cl
    '    c.ListaClAsientosLineas.Add(asiLin)
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    ' desglose de bases imponibles
    '    Dim Ibase1 As Decimal = 0
    '    Dim Ncta1 As String = ""
    '    Dim Ibase2 As Decimal = 0
    '    Dim Ibase3 As Decimal = 0
    '    Dim Ncta3 As String = 0
    '    Dim Ibase4 As Decimal = 0
    '    Dim Ncta4 As String = ""


    '    '
    '    Ibase1 = Base1
    '    Ibase2 = Base2
    '    Ibase3 = Base3
    '    Ibase4 = Base4

    '    Ncta1 = Tiposclientes.TPC_ctaventas.Valor
    '    Ncta3 = Me.FRA_cuentaventas3.Valor
    '    Ncta4 = Me.FRA_cuentaventas3.Valor


    '    If Ibase1 <> 0 Then

    '        Dim dt1 As DataTable = DesglosarPorFamilia(IdFactura, Ibase1)

    '        For Each row As DataRow In dt1.Rows

    '            Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
    '            Dim Importe_por_centro As Decimal = VaDec(row("Importe"))
    '            Dim IdActividad_por_centro As Integer = VaInt(row("IdActividad"))
    '            Dim IdSeccion_por_centro As Integer = VaInt(row("IdSeccion"))

    '            If Importe_por_centro <> 0 Then
    '                asiLin = New Contabilizacion.clAsientoLineas
    '                asiLin.Concepto = "N/FRA. " & NombreCliente
    '                If IdFamilia > 100 Then
    '                    asiLin.Cuenta = Mid(Ncta1, 1, 8) + IdFamilia.ToString.Substring(1, 1) + Mid(Ncta1, 10, 2)
    '                Else
    '                    asiLin.Cuenta = Mid(Ncta1, 1, 8) + FnLeft(IdFamilia, 1).PadLeft(1, "0") + Mid(Ncta1, 10, 2)
    '                End If
    '                asiLin.DH = "H"
    '                asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '                asiLin.IdActividad = IdActividad_por_centro
    '                asiLin.idConcepto = 0
    '                asiLin.IdSeccion = IdSeccion_por_centro
    '                asiLin.IdDepartamento = IdDepartamento
    '                asiLin.IdSubDepartamento = IdSubDepartamento
    '                asiLin.Importe = VaDec(Importe_por_centro.ToString("0.00"))
    '                asiLin.SRPC = ""
    '                c.ListaClAsientosLineas.Add(asiLin)
    '            End If

    '        Next

    '    End If

    '    If Ibase2 <> 0 Then

    '        'TODO: 
    '        Dim dt2 As DataTable = DesglosarEnvasesPorEnvase(IdFactura, Ibase2)

    '        For Each row As DataRow In dt2.Rows

    '            Dim ImporteEnvase_por_centro As Decimal = VaDec(row("Importe"))
    '            Dim CtaDevFianzas As String = (row("CtaDevFianzas").ToString & "").Trim
    '            Dim IdActividad_por_centro As Integer = VaInt(row("IdActividad"))
    '            Dim IdSeccion_por_centro As Integer = VaInt(row("IdSeccion"))

    '            If ImporteEnvase_por_centro <> 0 Then
    '                asiLin = New Contabilizacion.clAsientoLineas
    '                asiLin.Concepto = "N/FRA. " & NombreCliente
    '                asiLin.Cuenta = CtaDevFianzas
    '                asiLin.DH = "H"
    '                asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '                asiLin.IdActividad = IdActividad_por_centro
    '                asiLin.idConcepto = 0
    '                asiLin.IdSeccion = IdSeccion_por_centro
    '                asiLin.IdDepartamento = IdDepartamento
    '                asiLin.IdSubDepartamento = IdSubDepartamento
    '                asiLin.Importe = ImporteEnvase_por_centro.ToString("0.00")
    '                asiLin.SRPC = ""
    '                c.ListaClAsientosLineas.Add(asiLin)
    '            End If
    '        Next
    '    End If



    '    If Ibase3 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Ncta3
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec(Ibase3.ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    If Ibase4 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Ncta4
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec(Ibase4.ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    'CONTABILIZAR

    '    If CuotaIva1 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Tiposclientes.TPC_ctaivaventas.Valor
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec((CuotaIva1).ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    If CuotaIva2 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Tiposclientes.TPC_ctaivaenvases.Valor
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec((CuotaIva2).ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    If CuotaIva3 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Tiposclientes.TPC_ctaivavarios.Valor
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec((CuotaIva3).ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    If CuotaIva4 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Tiposclientes.TPC_ctaivavarios.Valor
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec((CuotaIva4).ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If

    '    If CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4 <> 0 Then
    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = Tiposclientes.TPC_ctarecargo.Valor
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec((CuotaRe1 + CuotaRe2 + CuotaRe3 + CuotaRe4).ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If


    '    If Suplido <> 0 Then

    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = CuentaCliente
    '        asiLin.DH = "H"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec(Suplido.ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '        asiLin = New Contabilizacion.clAsientoLineas
    '        asiLin.Concepto = "N/FRA. " & NombreCliente
    '        asiLin.Cuenta = CuentaAcreedor
    '        asiLin.DH = "D"
    '        asiLin.Documento = Me.FRA_serie.Valor & " " & Me.FRA_factura.Valor
    '        asiLin.IdActividad = IdActividad
    '        asiLin.idConcepto = 0
    '        asiLin.IdSeccion = IdSeccion
    '        asiLin.IdDepartamento = IdDepartamento
    '        asiLin.IdSubDepartamento = IdSubDepartamento
    '        asiLin.Importe = VaDec(Suplido.ToString("0.00"))
    '        asiLin.SRPC = ""
    '        c.ListaClAsientosLineas.Add(asiLin)

    '    End If




    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    Resultado = c.Contabilizar(ConexCtb(VaInt(Me.FRA_idempresa.Valor)), VaInt(Me.FRA_idasientoNet.Valor), VaInt(IdCentro), CDate(Me.FRA_fecha.Valor), Me.FRA_campa.Valor, VaInt(Me.FRA_idpuntoventa.Valor), E_Asientos.AsientoFacturasEmitida, IdFactura)

    '    If Resultado > 0 Then
    '        Me.FRA_idasientoNet.Valor = Resultado.ToString
    '        Me.Actualizar()
    '    End If


    '    Return Resultado


    'End Function



    'Private Function DesglosarPorFamilia(idfactura As Integer, Base As Decimal) As Dictionary(Of Integer, Decimal)

    '    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    '    Dim AlbSalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    '    Dim Generos As New E_Generos(Idusuario, cn)
    '    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    '    Dim sql As String = ""
    '    Dim Consulta As New Cdatos.E_select
    '    Dim Dc As New Dictionary(Of Integer, Decimal)

    '    Consulta.SelCampo(AlbSalida_lineas.ASL_importegenerovta, "ImporteLinea")
    '    Consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia", AlbSalida_lineas.ASL_idgenero)
    '    Consulta.SelCampo(SubFamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
    '    Consulta.SelCampo(AlbSalida_lineas.ASL_gastoF, "GastoF")
    '    Consulta.SelCampo(Albsalida.ASA_valorcambio, "Cambio", AlbSalida_lineas.ASL_idalbaran)
    '    Consulta.WheCampo(Albsalida.ASA_idfactura, "=", idfactura.ToString)
    '    sql = Consulta.SQL


    '    sql = sql & vbCrLf
    '    sql = sql & " UNION ALL" & vbCrLf
    '    sql = sql & " SELECT SUM(COALESCE(FLV_Cantidad,0) * COALESCE(FLV_Precio,0) * COALESCE(FRA_ValorCambio,1)) as ImporteLinea, " & vbCrLf
    '    sql = sql & " GEN_idsubfamilia as idsubfamilia, SFA_IdFamilia as idfamilia, 0.00 as GastoF, FRA_ValorCambio as Cambio" & vbCrLf
    '    sql = sql & " FROM Facturaslineasvar" & vbCrLf
    '    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = FLV_Codigo" & vbCrLf
    '    sql = sql & " LEFT JOIN SubFamilias ON SFA_Id = GEN_IdSubFamilia" & vbCrLf
    '    sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = FLV_IdFactura" & vbCrLf
    '    sql = sql & " WHERE FLV_IdFactura = " & idfactura.ToString & vbCrLf
    '    sql = sql & " AND FLV_TipoGEC = 'G'" & vbCrLf
    '    sql = sql & " GROUP BY SFA_IdFamilia, GEN_IdSubFamilia, FRA_ValorCambio" & vbCrLf


    '    Dim T As Decimal = 0
    '    Dim max As Decimal = 0
    '    Dim nmax As Integer = 0

    '    Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
    '    If Not dt Is Nothing Then
    '        For Each rw In dt.Rows
    '            Dim i As Decimal = VaDec(rw("importelinea")) - VaDec(rw("GastoF"))
    '            'i = i * VaDec(rw("cambio"))
    '            T = T + i
    '            Dim idfamilia As Integer = VaInt(rw("idfamilia"))
    '            If Dc.ContainsKey(idfamilia) = False Then
    '                Dc.Add(idfamilia, i)
    '            Else
    '                Dc(idfamilia) = Dc(idfamilia) + i
    '            End If
    '            If Dc(idfamilia) >= max Then
    '                max = Dc(idfamilia)
    '                nmax = idfamilia
    '            End If
    '        Next
    '    End If



    '    If nmax > 0 Then
    '        Dc(nmax) = Dc(nmax) + Base - T
    '    End If

    '    Return Dc

    'End Function



    Private Function DesglosarEnvasesPorFamilia(IdFactura As Integer, Base As Decimal) As DataTable

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        Dim sql As String = "SELECT VEL_IdEnvase as IdEnvase, ENV_CtaDevFianzas as CtaDevFianzas," & vbCrLf
        sql = sql & " ASA_IdPuntoVenta as IdPuntoVenta, ASA_IdCentro as IdCentro, IdActividad, IdSeccion, " & vbCrLf
        sql = sql & " SUM(COALESCE(VEL_PrecioRetira,0) * COALESCE(VEL_Retira,0)) - SUM(COALESCE(VEL_PrecioEntrega,0) * COALESCE(VEL_Entrega,0)) as Importe" & vbCrLf
        sql = sql & " FROM AlbSalida" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases_Lineas ON VEL_IdVale = ASA_IdValeEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN " & PuntoVenta.NombreBd.ToString & ".dbo.PuntoVenta ON IdPuntoVenta = ASA_IdPuntoVenta " & vbCrLf
        sql = sql & " WHERE ASA_IdFactura = " & IdFactura.ToString & vbCrLf
        sql = sql & " AND (COALESCE(VEL_PrecioRetira, 0) <> 0 OR COALESCE(VEL_PrecioEntrega,0) <> 0)" & vbCrLf
        sql = sql & " GROUP BY VEL_IdEnvase, ENV_CtaDevFianzas, ASA_IdPuntoVenta, ASA_IdCentro, IdActividad, IdSeccion " & vbCrLf

        sql = sql & " UNION ALL " & vbCrLf

        sql = sql & " SELECT FLV_Codigo as IdEnvase, ENV_CtaDevFianzas as CtaDevFianzas," & vbCrLf
        sql = sql & " FRA_IdPuntoVenta as IdPuntoVenta, FRA_IdCentro as IdCentro, IdActividad, IdSeccion, " & vbCrLf
        sql = sql & " SUM(COALESCE(FLV_Cantidad,0) * COALESCE(FLV_Precio,0) * COALESCE(FRA_CdDivisa,1)) as Importe" & vbCrLf
        sql = sql & " FROM Facturaslineasvar" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = FLV_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = FLV_Codigo" & vbCrLf
        sql = sql & " LEFT JOIN " & PuntoVenta.NombreBd.ToString & ".dbo.PuntoVenta ON IdPuntoVenta = FRA_IdPuntoVenta " & vbCrLf
        sql = sql & " WHERE FLV_IdFactura = " & IdFactura.ToString & vbCrLf
        sql = sql & " AND FLV_TipoGEC = 'E'" & vbCrLf
        sql = sql & " GROUP BY FLV_Codigo, ENV_CtaDevFianzas, FRA_IdPuntoVenta, FRA_IdCentro, IdActividad, IdSeccion" & vbCrLf



        Dim Total As Decimal = 0
        Dim max As Decimal = 0
        Dim nmax As Integer = 0

        Dim acum As New Acumulador

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each row In dt.Rows

                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim CtaDevFianzas As String = (row("CtaDevFianzas").ToString & "").Trim
                Dim IdPuntoVenta As Integer = VaInt(row("IdPuntoVenta"))
                Dim IdCentro As Integer = VaInt(row("IdCentro"))
                Dim IdActividad As Integer = VaInt(row("IdActividad"))
                Dim IdSeccion As Integer = VaInt(row("IdSeccion"))
                Dim Importe As Decimal = VaDec(row("Importe"))
                Importe = Math.Round(Importe, 2)

                Total = Total + Importe


                Dim stClave As New stClave_EnvasesPorCentro(IdEnvase, CtaDevFianzas, IdPuntoVenta, IdCentro, IdActividad, IdSeccion)
                Dim stDatos As New stDatos_EnvasesPorCentro(Importe)
                acum.Suma(stClave, stDatos)

            Next

        End If


        Dim dtFinal As DataTable = acum.DataTable
        Dim MaxImporte As Decimal = 0

        If Not IsNothing(dtFinal) Then

            For indice As Integer = 0 To dtFinal.Rows.Count - 1

                Dim row As DataRow = dtFinal.Rows(indice)

                Dim Importe As Decimal = VaDec(row("Importe"))
                If Importe > MaxImporte Then
                    MaxImporte = Importe
                    nmax = indice
                End If

            Next


            If nmax >= 0 Then
                dtFinal.Rows(nmax)("Importe") = dtFinal.Rows(nmax)("Importe") + Base - Total
            End If


        End If


        Return dtFinal

    End Function



    Private Function DesglosarEnvasesPorEnvase(IdFactura As Integer, Base As Decimal) As DataTable

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        Dim sql As String = "SELECT VEL_IdEnvase as IdEnvase, ENV_CtaDevFianzas as CtaDevFianzas," & vbCrLf
        sql = sql & " VEV_IdAlmacen as IdPuntoVenta, VEV_IdCentro as IdCentro, IdActividad, IdSeccion, " & vbCrLf
        sql = sql & " SUM(COALESCE(VEL_PrecioFianza,0) * COALESCE(VEL_Retira,0)) as Importe" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN " & PuntoVenta.NombreBd.ToString & ".dbo.PuntoVenta ON IdPuntoVenta = VEV_IdAlmacen " & vbCrLf
        sql = sql & " WHERE VEL_IdFacturaEnvase = " & IdFactura.ToString & vbCrLf
        sql = sql & " AND COALESCE(VEL_PrecioFianza, 0) <> 0 " & vbCrLf
        sql = sql & " GROUP BY VEL_IdEnvase, ENV_CtaDevFianzas, VEV_IdAlmacen, VEV_IdCentro, IdActividad, IdSeccion " & vbCrLf


        Dim Total As Decimal = 0
        Dim max As Decimal = 0
        Dim nmax As Integer = 0

        Dim acum As New Acumulador

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each row In dt.Rows

                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim CtaDevFianzas As String = (row("CtaDevFianzas").ToString & "").Trim
                Dim IdPuntoVenta As Integer = VaInt(row("IdPuntoVenta"))
                Dim IdCentro As Integer = VaInt(row("IdCentro"))
                Dim IdActividad As Integer = VaInt(row("IdActividad"))
                Dim IdSeccion As Integer = VaInt(row("IdSeccion"))
                Dim Importe As Decimal = VaDec(row("Importe"))
                Importe = Math.Round(Importe, 2)

                Total = Total + Importe


                Dim stClave As New stClave_EnvasesPorCentro(IdEnvase, CtaDevFianzas, IdPuntoVenta, IdCentro, IdActividad, IdSeccion)
                Dim stDatos As New stDatos_EnvasesPorCentro(Importe)
                acum.Suma(stClave, stDatos)

            Next

        End If


        Dim dtFinal As DataTable = acum.DataTable
        Dim MaxImporte As Decimal = 0

        If Not IsNothing(dtFinal) Then

            For indice As Integer = 0 To dtFinal.Rows.Count - 1

                Dim row As DataRow = dtFinal.Rows(indice)

                Dim Importe As Decimal = VaDec(row("Importe"))
                If Importe > MaxImporte Then
                    MaxImporte = Importe
                    nmax = indice
                End If

            Next


            If nmax >= 0 Then
                dtFinal.Rows(nmax)("Importe") = dtFinal.Rows(nmax)("Importe") + Base - Total
            End If


        End If


        Return dtFinal

    End Function



    'Private Function DesglosarEnvasesPorFamilia(IdFactura As Integer, Base As Decimal) As Dictionary(Of Integer, DatosFraEnvases)

    '    Dim Dc As New Dictionary(Of Integer, DatosFraEnvases)


    '    Dim sql As String = "SELECT VEL_IdEnvase as IdEnvase, ENV_CtaDevFianzas as CtaDevFianzas," & vbCrLf
    '    sql = sql & " SUM(COALESCE(VEL_PrecioRetira,0) * COALESCE(VEL_Retira,0)) - SUM(COALESCE(VEL_PrecioEntrega,0) * COALESCE(VEL_Entrega,0)) as Importe" & vbCrLf
    '    sql = sql & " FROM AlbSalida" & vbCrLf
    '    sql = sql & " LEFT JOIN ValeEnvases_Lineas ON VEL_IdVale = ASA_IdValeEnvase" & vbCrLf
    '    sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
    '    sql = sql & " WHERE ASA_IdFactura = " & IdFactura.ToString & vbCrLf
    '    sql = sql & " AND (COALESCE(VEL_PrecioRetira, 0) <> 0 OR COALESCE(VEL_PrecioEntrega,0) <> 0)" & vbCrLf
    '    sql = sql & " GROUP BY VEL_IdEnvase, ENV_CtaDevFianzas " & vbCrLf
    '    sql = sql & " UNION ALL " & vbCrLf
    '    sql = sql & " SELECT FLV_Codigo as IdEnvase, ENV_CtaDevFianzas as CtaDevFianzas," & vbCrLf
    '    sql = sql & " SUM(COALESCE(FLV_Cantidad,0) * COALESCE(FLV_Precio,0) * COALESCE(FRA_CdDivisa,1)) as Importe" & vbCrLf
    '    sql = sql & " FROM Facturaslineasvar" & vbCrLf
    '    sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = FLV_IdFactura" & vbCrLf
    '    sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = FLV_Codigo" & vbCrLf
    '    sql = sql & " WHERE FLV_IdFactura = " & IdFactura.ToString & vbCrLf
    '    sql = sql & " AND FLV_TipoGEC = 'E'" & vbCrLf
    '    sql = sql & " GROUP BY FLV_Codigo, ENV_CtaDevFianzas" & vbCrLf



    '    Dim Total As Decimal = 0
    '    Dim max As Decimal = 0
    '    Dim nmax As Integer = 0

    '    Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
    '    If Not dt Is Nothing Then

    '        For Each rw In dt.Rows

    '            Dim IdEnvase As Integer = VaInt(rw("IdEnvase"))
    '            Dim CtaDevFianzas As String = (rw("CtaDevFianzas").ToString & "").Trim
    '            Dim Importe As Decimal = VaDec(rw("Importe"))

    '            Total = Total + Importe

    '            If Not Dc.ContainsKey(IdEnvase) Then

    '                Dim DatosFraEnvase As New DatosFraEnvases(IdEnvase, Importe, CtaDevFianzas)
    '                Dc.Add(IdEnvase, DatosFraEnvase)

    '            Else

    '                Dim DatosFraEnvase As DatosFraEnvases = Dc(IdEnvase)
    '                DatosFraEnvase.Importe = DatosFraEnvase.Importe + Importe
    '                Dc(IdEnvase) = DatosFraEnvase

    '            End If


    '            If Dc(IdEnvase).Importe >= max Then
    '                max = Dc(IdEnvase).Importe
    '                nmax = IdEnvase
    '            End If

    '        Next

    '    End If


    '    If nmax > 0 Then
    '        Dc(nmax).Importe = Dc(nmax).Importe + Base - Total
    '    End If



    '    Return Dc

    'End Function



    Private Sub ImportesFacturaDevEnv(Idfactura As String, ByRef ImporteEnvaseRet As Decimal, ByRef ImporteEnvasenoRet As Decimal, ByVal ImporteBase As Decimal)
        ' calcula el importe de las facturas de devolucion de envases

        Dim Valeenvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim sql As String
        ImporteEnvaseRet = 0
        ImporteEnvasenoRet = 0

        consulta.SelCampo(Valeenvases_lineas.VEL_retira, "retira")
        consulta.SelCampo(Valeenvases_lineas.VEL_entrega, "entrega")
        consulta.SelCampo(Valeenvases_lineas.VEL_precioretira, "precioretira")
        consulta.SelCampo(Valeenvases_lineas.VEL_precioentrega, "precioentrega")
        consulta.SelCampo(Envases.ENV_Retornable, "retornable", Valeenvases_lineas.VEL_idenvase)
        consulta.SelCampo(Valeenvases.VEV_idfactura, "idfactura", Valeenvases_lineas.VEL_idvale)
        consulta.WheCampo(Valeenvases.VEV_idfactura, "=", Idfactura)

        sql = consulta.SQL
        Dim envaseret As Decimal = 0
        Dim envasenoret As Decimal = 0

        Dim dt As DataTable = Valeenvases.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim i As Decimal = VaDec(rw("retira")) * VaDec(rw("precioretira")) - VaDec(rw("entrega")) * VaDec(rw("precioentrega"))
                If rw("retornable").ToString = "S" Then
                    envaseret = envaseret + i
                Else
                    envasenoret = envasenoret + i
                End If
            Next
        End If

        ImporteEnvaseRet = envaseret
        ImporteEnvasenoRet = envasenoret


        'Sumamos la posible diferencia a la cantidad mayor
        Dim Diferencia As Decimal = ImporteBase - ImporteEnvaseRet - ImporteEnvasenoRet

        If ImporteEnvaseRet > ImporteEnvasenoRet Then
            'ImporteEnvaseRet
            ImporteEnvaseRet = ImporteEnvaseRet + Diferencia
        Else
            'ImporteEnvaseNoRet
            ImporteEnvasenoRet = ImporteEnvasenoRet + Diferencia
        End If


    End Sub

    Public Function AlbaranesPendientes(idcliente As Integer, ByRef Total As Decimal) As DataTable
        Total = 0
        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran")
        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran")
        consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Albsalida.ASA_referencia, "Referencia")
        consulta.SelCampo(Albsalida.ASA_refvaloracion, "RefValoracion")
        consulta.SelCampo(Albsalida.ASA_valorcambio, "Cambio")
        Dim SE As String = "@(SELECT SUM(ASL_IMPORTEGENEROVTA) AS I FROM ALBSALIDA_LINEAS WHERE ASL_IdAlbaran=ASA_IDALBARAN) "
        Dim Importe As New Cdatos.bdcampo(SE, Cdatos.TiposCampo.Importe, 15, 2)
        consulta.SelCampo(Importe, "Importe")
        consulta.WheCampo(Albsalida.ASA_idcliente, "=", idcliente.ToString)
        consulta.WheCampo(Albsalida.ASA_idfactura, "=", "0")
        Dim SQL As String = consulta.SQL
        Dim DT As DataTable = Albsalida.MiConexion.ConsultaSQL(SQL)
        If Not DT Is Nothing Then
            For Each RW In DT.Rows
                Dim I As Decimal = VaDec(RW("IMPORTE")) * VaDec(RW("CAMBIO"))
                RW("IMPORTE") = I
                Total = Total + I
            Next
        End If

        Return DT
    End Function


    Public Function FacturasPendientes(Idcliente As Integer, ByRef Total As Decimal) As DataTable

        Total = 0

        Dim cobroslineas As New E_CobrosLineas(Idusuario, cn)



        'Dim Consulta As New Cdatos.E_select
        'Consulta.SelCampo(Me.FRA_idfactura, "IdFactura")
        'Consulta.SelCampo(Me.FRA_fecha, "Fecha")
        'Consulta.SelCampo(Me.FRA_serie, "Serie")
        'Consulta.SelCampo(Me.FRA_factura, "Factura")
        'Consulta.SelCampo(Me.FRA_totalfactura, "Importe")
        'Consulta.SelCampo(Me.FRA_RefCliente, "Referencia")
        'Consulta.SelCampo(Me.FRA_valorcambio, "Cambio")
        'Consulta.WheCampo(Me.FRA_idcliente, "=", Idcliente.ToString)


        'Dim sql As String = Consulta.SQL & vbCrLf
        'sql = sql & " ORDER BY Fecha, Serie, Factura" & vbCrLf



        Dim sql As String = "SELECT IdFactura, Fecha, Serie, Factura, Importe, Referencia, Cambio, Importe - Cobrado as Pendiente"
        sql = sql & " FROM " & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, FRA_Fecha as Fecha, FRA_Serie as Serie, FRA_Factura as Factura, COALESCE(FRA_TotalFactura,0.00) as Importe, FRA_RefCliente as Referencia," & vbCrLf
        sql = sql & " FRA_ValorCambio as Cambio, COALESCE((SELECT SUM(CBL_importecobradodivisa) as Cobrado FROM CobrosLineas WHERE CBL_IdFactura = FRA_IdFactura),0.00) as Cobrado" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " WHERE FRA_IdCliente = " & Idcliente.ToString & vbCrLf
        sql = sql & " ) as C" & vbCrLf
        sql = sql & " WHERE Importe - Cobrado <> 0" & vbCrLf
        sql = sql & " ORDER BY Fecha, Serie, Factura" & vbCrLf


        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            Total = VaDec(dt.Compute("SUM(Pendiente)", ""))
        End If


        'Dim colPte As New DataColumn("Pendiente", GetType(Decimal))
        'dt.Columns.Add(colPte)




        'For Each row As DataRow In dt.Rows

        '    Dim IdFactura As String = row("IdFactura").ToString & ""
        '    Dim cobrado As Decimal = cobroslineas.CobradoFactura(IdFactura)
        '    Dim Pte As Decimal = VaDec(row("Importe")) - cobrado
        '    Pte = Pte * VaDec(row("cambio"))

        '    row("Pendiente") = Pte

        '    Total = Total + Pte

        'Next


        'Dim dv As New DataView(dt)
        'dv.RowFilter = "Pendiente <> 0"
        'dt = dv.ToTable




        'OJO con las mayúsculas / minúsculas

        Return dt
    End Function



    



    Private Class stClave_AlbaranesPorCentro

        Public IdFamilia As Integer = 0
        Public IdPuntoVenta As Integer = 0
        Public IdCentro As Integer = 0
        Public IdActividad As Integer = 0
        Public IdSeccion As Integer = 0

        Public Sub New(ByVal IdFamilia As Integer, ByVal IdPuntoVenta As Integer, ByVal IdCentro As Integer, ByVal IdActividad As Integer, ByVal IdSeccion As Integer)

            Me.IdFamilia = IdFamilia
            Me.IdPuntoVenta = IdPuntoVenta
            Me.IdCentro = IdCentro
            Me.IdActividad = IdActividad
            Me.IdSeccion = IdSeccion

        End Sub

    End Class


    Private Class stDatos_AlbaranesPorCentro

        Public Importe As Decimal = 0


        Public Sub New(ByVal Importe As Decimal)

            Me.Importe = Importe

        End Sub

    End Class


    Private Class stClave_EnvasesPorCentro

        Public IdEnvase As Integer = 0
        Public CtaDevFianzas As String = ""
        Public IdPuntoVenta As Integer = 0
        Public IdCentro As Integer = 0
        Public IdActividad As Integer = 0
        Public IdSeccion As Integer = 0

        Public Sub New(ByVal IdEnvase As Integer, ByVal CtaDevFianzas As String, ByVal IdPuntoVenta As Integer, ByVal IdCentro As Integer, ByVal IdActividad As Integer, ByVal IdSeccion As Integer)

            Me.IdEnvase = IdEnvase
            Me.CtaDevFianzas = CtaDevFianzas
            Me.IdPuntoVenta = IdPuntoVenta
            Me.IdCentro = IdCentro
            Me.IdActividad = IdActividad
            Me.IdSeccion = IdSeccion

        End Sub


    End Class

    Private Class stDatos_EnvasesPorCentro

        Public Importe As Decimal = 0

        Public Sub New(Importe As Decimal)

            Me.Importe = Importe

        End Sub

    End Class



End Class
