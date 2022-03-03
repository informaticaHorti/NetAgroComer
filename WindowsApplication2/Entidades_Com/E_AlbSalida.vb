Public Class E_AlbSalida
    Inherits Cdatos.Entidad

    Public ASA_idalbaran As Cdatos.bdcampo
    Public ASA_ejercicio As Cdatos.bdcampo
    Public ASA_idpuntoventa As Cdatos.bdcampo
    Public ASA_idcentro As Cdatos.bdcampo
    Public ASA_albaran As Cdatos.bdcampo
    Public ASA_fechasalida As Cdatos.bdcampo
    Public ASA_idcliente As Cdatos.bdcampo
    Public ASA_iddomicilio As Cdatos.bdcampo
    Public ASA_idpedido As Cdatos.bdcampo
    Public ASA_referencia As Cdatos.bdcampo
    Public ASA_iddivisa As Cdatos.bdcampo
    Public ASA_valorcambio As Cdatos.bdcampo
    Public ASA_fechavaloracion As Cdatos.bdcampo
    Public ASA_idfactura As Cdatos.bdcampo
    Public ASA_tipofc As Cdatos.bdcampo
    Public ASA_idvaleenvase As Cdatos.bdcampo
    Public ASA_idvaleenvasematerial As Cdatos.bdcampo
    Public ASA_idtransportista As Cdatos.bdcampo
    Public ASA_matriculacamion As Cdatos.bdcampo
    Public ASA_matricularemolque As Cdatos.bdcampo
    Public ASA_observaciones As Cdatos.bdcampo
    Public ASA_refvaloracion As Cdatos.bdcampo
    Public ASA_Factoring As Cdatos.bdcampo
    Public ASA_IdVendedor As Cdatos.bdcampo
    Public ASA_idtipoporte As Cdatos.bdcampo
    Public ASA_movilchofer As Cdatos.bdcampo
    Public ASA_numregtemperatura As Cdatos.bdcampo
    Public ASA_idcarga As Cdatos.bdcampo
    Public ASA_HoraSalida As Cdatos.bdcampo
    Public ASA_IdEmpresa As Cdatos.bdcampo

    Public ASA_IdUsuarioLog As Cdatos.bdcampo
    Public ASA_FechaLog As Cdatos.bdcampo
    Public ASA_HoraLog As Cdatos.bdcampo


    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)
    Private Valorespventa As New E_valorespventa(Idusuario, cn)

    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "AlbSalida"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ASA_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            ASA_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "ejercicio", Cdatos.TiposCampo.EnteroPositivo, 2)
            ASA_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 3)
            ASA_idpuntoventa = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.EnteroPositivo, 3)
            ASA_albaran = New Cdatos.bdcampo(CodigoEntidad & "albaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            ASA_fechasalida = New Cdatos.bdcampo(CodigoEntidad & "fechasalida", Cdatos.TiposCampo.Fecha, 10)
            ASA_idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASA_iddomicilio = New Cdatos.bdcampo(CodigoEntidad & "iddomicilio", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASA_idpedido = New Cdatos.bdcampo(CodigoEntidad & "idpedido", Cdatos.TiposCampo.EnteroPositivo, 6)
            ASA_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 50)
            ASA_iddivisa = New Cdatos.bdcampo(CodigoEntidad & "iddivisa", Cdatos.TiposCampo.EnteroPositivo, 3)
            ASA_valorcambio = New Cdatos.bdcampo(CodigoEntidad & "valorcambio", Cdatos.TiposCampo.Importe, 10, 6)
            ASA_fechavaloracion = New Cdatos.bdcampo(CodigoEntidad & "fechavaloracion", Cdatos.TiposCampo.Fecha, 10)
            ASA_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 6)
            ASA_tipofc = New Cdatos.bdcampo(CodigoEntidad & "tipofc", Cdatos.TiposCampo.Cadena, 1)
            ASA_idvaleenvase = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvase", Cdatos.TiposCampo.EnteroPositivo, 10)
            ASA_idvaleenvasematerial = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvasematerial", Cdatos.TiposCampo.EnteroPositivo, 10)
            ASA_idtransportista = New Cdatos.bdcampo(CodigoEntidad & "idtransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASA_matriculacamion = New Cdatos.bdcampo(CodigoEntidad & "matriculacamion", Cdatos.TiposCampo.Cadena, 20)
            ASA_matricularemolque = New Cdatos.bdcampo(CodigoEntidad & "matricularemolque", Cdatos.TiposCampo.Cadena, 20)
            ASA_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)
            ASA_refvaloracion = New Cdatos.bdcampo(CodigoEntidad & "refvaloracion", Cdatos.TiposCampo.Cadena, 15)
            ASA_Factoring = New Cdatos.bdcampo(CodigoEntidad & "Factoring", Cdatos.TiposCampo.Cadena, 1)
            ASA_IdVendedor = New Cdatos.bdcampo(CodigoEntidad & "IdVendedor", Cdatos.TiposCampo.EnteroPositivo, 4, 0, False)
            ASA_idtipoporte = New Cdatos.bdcampo(CodigoEntidad & "Idtipoporte", Cdatos.TiposCampo.EnteroPositivo, 4, 0, False)
            ASA_movilchofer = New Cdatos.bdcampo(CodigoEntidad & "movilchofer", Cdatos.TiposCampo.Cadena, 12)
            ASA_numregtemperatura = New Cdatos.bdcampo(CodigoEntidad & "numregtemperatura", Cdatos.TiposCampo.Cadena, 20)
            ASA_idcarga = New Cdatos.bdcampo(CodigoEntidad & "idcarga", Cdatos.TiposCampo.EnteroPositivo, 6)
            ASA_HoraSalida = New Cdatos.bdcampo(CodigoEntidad & "HoraSalida", Cdatos.TiposCampo.Hora, 8)
            ASA_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "Idempresa", Cdatos.TiposCampo.EnteroPositivo, 4, 0, False)


            ASA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ASA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ASA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.ASA_albaran)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Albaran Salida"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim facturas As New E_Facturas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(Me.ASA_albaran, "Albaran")
        consulta.SelCampo(Me.ASA_IdEmpresa, "Emp")
        consulta.SelCampo(Me.ASA_ejercicio, "Ejercicio")
        consulta.SelCampo(Me.ASA_idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "CE", Me.ASA_idcentro, Centros.IdCentro)
        consulta.SelCampo(Me.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Me.ASA_idcliente, "Codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.ASA_idcliente)
        consulta.SelCampo(facturas.FRA_serie, "Serie", Me.ASA_idfactura)
        consulta.SelCampo(facturas.FRA_factura, "Factura")
        consulta.SelCampo(Me.ASA_referencia, "RefCliente")
        consulta.SelCampo(Me.ASA_matriculacamion, "MatCamion")
        consulta.SelCampo(Me.ASA_matricularemolque, "MatRemolque")
        consulta.SelCampo(Me.ASA_refvaloracion, "CtaVenta")
        _btBusca.Params("IdAlbaran", , -1)
        _btBusca.Params("IdCentro", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Cliente"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdAlbaran"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAlbSal"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = True


        _btBusca.ParamConsultaAlb(consulta, "ASA_FechaSalida DESC", Me.ASA_idcliente, Me.ASA_fechasalida, Me.ASA_idcentro)

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)


    End Sub

    Public Function LeerAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numalba As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.ASA_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.ASA_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.ASA_albaran, "=", numalba.ToString)

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


    Public Function ExisteAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numalba As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.ASA_ejercicio, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.ASA_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.ASA_albaran, "=", numalba.ToString)

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

    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)

                End If
                existe = ExisteAlb(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

    Private Sub E_AlbSalida_ActualizaHijos(ByVal nuevo As Boolean) Handles Me.ActualizaHijos

    End Sub



    Private Sub E_Albsalida_EliminaHijos() Handles Me.EliminaHijos

        Dim sql As String
        Dim dt As New DataTable
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim AlbSalida_palets As New E_albsalida_palets(Idusuario, cn)

        sql = "select * from albsalida_lineas where ASL_idalbaran=" + ASA_idalbaran.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                Albsalida_lineas.CargaCampos(rw)
                Albsalida_lineas.Eliminar()
            Next
        End If


        sql = "select * from albsalida_palets where ASP_idalbaran=" + ASA_idalbaran.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                AlbSalida_palets.CargaCampos(rw)
                AlbSalida_palets.Eliminar()
            Next
        End If


        If VaInt(Me.ASA_idvaleenvase.Valor) > 0 Then
            If ValeEnvases.LeerId(Me.ASA_idvaleenvase.Valor) = True Then
                ValeEnvases.Eliminar()
            End If
        End If

        If VaInt(Me.ASA_idvaleenvasematerial.Valor) > 0 Then
            If ValeEnvases.LeerId(Me.ASA_idvaleenvasematerial.Valor) = True Then
                ValeEnvases.Eliminar()
            End If
        End If


        Dim Campa As Integer = VaInt(Me.ASA_ejercicio.Valor)
        Dim IdCentro As Integer = VaInt(Me.ASA_idcentro.Valor)
        Dim Albaran As Integer = VaInt(Me.ASA_albaran.Valor)

        Dim CMR As New E_Cmr(Idusuario, cn)
        If CMR.LeerCmr(Campa, IdCentro, Albaran) Then
            CMR.Eliminar()
        End If



    End Sub

    Public Class stClave_Consumo

        Public Idmaterial As Integer = 0
        Public Idmarca As Integer = 0
        Public Retornable As String
        Public Precio As Decimal
        Public Coste As Decimal
        Public EsPropio As String = "S"
        Public TipoEnvase As String = ""
        Public PrecioFianza As Decimal = 0




        Public Sub New(ByVal Idmaterial As Integer, ByVal Idmarca As Integer, Retornable As String, Precio As Decimal, Coste As Decimal, Espropio As String, TipoEnvase As String, PrecioFianza As Decimal)

            Me.Idmaterial = Idmaterial
            Me.Idmarca = Idmarca
            Me.Retornable = Retornable
            Me.Precio = Precio
            Me.Coste = Coste
            Me.EsPropio = Espropio
            Me.TipoEnvase = TipoEnvase
            Me.PrecioFianza = PrecioFianza

        End Sub

    End Class

    Public Class stDatos_consumo
        Public cantidad As Double = 0

        Public Sub New(ByVal cantidad As Double)
            Me.cantidad = cantidad
        End Sub

    End Class


    'Public Sub CrearValeEnvasesSalida(ByVal Nalbaran As String, ByVal Retornable As String, FacturaEnvases As String,
    '                                  IdCliente As String, IdDomicilio As String)


    Public Sub CrearValeEnvasesSalida(ByVal Nalbaran As String, ByVal Retornable As String, IdCliente As String, IdDomicilio As String)


        Dim sql As String
        Dim dt As New DataTable
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim ConsultaP As New Cdatos.E_select
        Dim ConsultaB As New Cdatos.E_select
        Dim x As Integer = 0
        Dim Operacion As String = ""
        Dim IdVale As Integer = 0
        Dim Uds As String
        Dim idmarca As String = ""

        If Me.LeerId(Nalbaran) = True Then

            If Retornable = "S" Then
                IdVale = VaInt(Me.ASA_idvaleenvase.Valor)
                If IdVale > 0 Then

                    'Borra sólo las líneas automáticas
                    Dim VEL As New E_ValeEnvases_Lineas(Idusuario, cn)

                    Dim sqlL As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdVale & " AND VEL_Automatica = 'S'"
                    Dim dtL As DataTable = ValeEnvases_lineas.MiConexion.ConsultaSQL(sqlL)
                    If Not IsNothing(dtL) Then
                        For Each rowL As DataRow In dtL.Rows
                            If VEL.LeerId(rowL("VEL_Id")) Then
                                VEL.Eliminar()
                            End If
                        Next
                    End If

                End If

            End If



            If Retornable = "N" Then
                IdVale = VaInt(Me.ASA_idvaleenvasematerial.Valor)
                If IdVale > 0 Then

                    'Borra sólo las líneas automáticas
                    Dim VEL As New E_ValeEnvases_Lineas(Idusuario, cn)

                    Dim sqlL As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdVale & " AND VEL_Automatica = 'S'"
                    Dim dtL As DataTable = ValeEnvases_lineas.MiConexion.ConsultaSQL(sqlL)
                    If Not IsNothing(dtL) Then
                        For Each rowL As DataRow In dtL.Rows
                            If VEL.LeerId(rowL("VEL_Id")) Then
                                VEL.Eliminar()
                            End If
                        Next
                    End If

                End If
            End If


            If Retornable = "S" Then
                Operacion = "SC"
            Else
                Operacion = "SM"
            End If

            'Dim Wret As String
            'If Retornable = "N" Then
            '    Wret = "S"
            'Else
            '    Wret = "N"
            'End If

            Dim consulta As New Cdatos.E_select
            Dim Confecpaletlineas As New E_ConfecPaletLineas(Idusuario, cn)
            Dim Confecenvaselineas As New E_ConfecEnvaseLineas(Idusuario, cn)
            Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
            Dim palets As New E_palets(Idusuario, cn)
            Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
            Dim Generosalida As New E_GenerosSalida(Idusuario, cn)

            ' materiales del tipo de palet


            'consulta.SelCampo(palets.PAL_palet, "numeropalet")
            consulta.SelCampo(palets.PAL_envasepropio, "envasepropio")
            consulta.SelCampo(palets.PAL_materialpropio, "materialpropio")
            consulta.SelCampo(Confecpaletlineas.CPL_Idmaterial, "idmaterial", palets.PAL_idtipopalet, Confecpaletlineas.CPL_Idconfec)

            consulta.SelCampo(Confecpaletlineas.CPL_Cantidad, "cantidad")
            consulta.SelCampo(Envases.ENV_Retornable, "envaseretornable", Confecpaletlineas.CPL_Idmaterial)
            consulta.SelCampo(Envases.ENV_PrecioVenta, "Precio")
            consulta.SelCampo(Envases.ENV_CosteSalida, "Coste")
            consulta.SelCampo(Envases.ENV_Tipo, "tipo")
            consulta.SelCampo(Envases.ENV_idsubfamilia, "IdSubFamilia")
            consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", palets.PAL_idpalet, Albsalida_palets.ASP_Idpalet)
            consulta.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", Nalbaran)
            consulta.WheCampo(Envases.ENV_Retornable, "=", Retornable)
            sql = consulta.SQL
            'sql = sql + " group by cpl_idmaterial,env_retornable,ASP_idalbaran "

            Dim precio As String = ""
            Dim preciofianza As String = ""

            Dim Acum As New Acumulador
            Acum.Borrar()

            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    Dim Envasepropio As String = rw("envasepropio").ToString
                    Dim Materialpropio As String = rw("materialpropio").ToString
                    Dim tipo As String = rw("tipo").ToString
                    Dim CreaLinea As Boolean = True ' siempre creamos la linea
                    Dim Espropio As String = "S"
                    'If Envasepropio = "S" And tipo = "P" Then ' creamos la linea cuando el envase o el material es propio
                    '    CreaLinea = True
                    'End If
                    'If Materialpropio = "S" And tipo <> "P" Then ' creamos la linea cuando el envase o el material es propio
                    '    CreaLinea = True
                    'End If
                    If tipo = "P" Then
                        Espropio = Envasepropio
                    Else
                        Espropio = Materialpropio
                    End If
                    If CreaLinea = True Then

                        Uds = VaDec(rw("cantidad")).ToString


                        Dim IdSubFamilia As String = (rw("IdSubFamilia").ToString & "").Trim
                        Dim TipoEnvase As String = E_FianzasEnvases.TipoEnvase(IdCliente, IdDomicilio, IdSubFamilia)


                        precio = ""
                        'If rw("envaseretornable").ToString = "S" And FacturaEnvases = "S" Then
                        If rw("envaseretornable").ToString = "S" And
                            (TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarEnAlbaran Or TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarYDeclarar) Then
                            precio = rw("precio").ToString
                        ElseIf rw("envaseretornable").ToString = "S" And TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
                            preciofianza = rw("precio").ToString
                        End If
                        Dim coste As String = rw("Coste").ToString
                        Dim cantidad As Double = VaDec(rw("cantidad"))
                        Dim envaseretornable As String = rw("envaseretornable").ToString
                        Dim idmaterial As Integer = VaInt(rw("idmaterial"))


                        Dim clave As New stClave_Consumo(idmaterial, 0, envaseretornable, VaDec(precio), coste, Espropio, TipoEnvase, VaDec(preciofianza))
                        Dim datos As New stDatos_consumo(cantidad)
                        Acum.Suma(clave, datos)

                    End If
                Next
            End If

            'Materiales del tipo de envase 

            Dim consulta2 As New Cdatos.E_select

            consulta2.SelCampo(palets_lineas.PLL_idgensal, "idgensal")
            consulta2.SelCampo(palets_lineas.PLL_idtipoconfeccion, "idtipoconfeccion")
            consulta2.SelCampo(palets_lineas.PLL_bultos, "bultos")
            consulta2.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
            consulta2.SelCampo(palets_lineas.PLL_idmarcamat, "idmarcamaterial")
            consulta2.SelCampo(palets_lineas.PLL_idmarcaeti, "idmarcaetiqueta")
            consulta2.SelCampo(palets.PAL_envasepropio, "envasepropio", palets_lineas.PLL_idpalet)
            consulta2.SelCampo(palets.PAL_materialpropio, "materialpropio")
            consulta2.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", palets_lineas.PLL_idpalet, Albsalida_palets.ASP_Idpalet)

            consulta2.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", Nalbaran)

            sql = consulta2.SQL
            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    Dim bultos As Integer = VaDec(rw("bultos"))
                    Dim marcaEnv As Integer = VaInt(rw("idmarca"))
                    Dim marcaMat As Integer = VaInt(rw("idmarcamaterial"))
                    Dim marcaEti As Integer = VaInt(rw("idmarcaetiqueta"))
                    Dim envasepropio As String = rw("envasepropio").ToString
                    Dim materialpropio As String = rw("materialpropio").ToString
                    Dim consulta4 As New Cdatos.E_select
                    consulta4.SelCampo(Confecenvaselineas.CEL_Cantidad, "cantidad")
                    consulta4.SelCampo(Confecenvaselineas.CEL_Idmaterial, "idmaterial")
                    consulta4.SelCampo(Envases.ENV_Tipo, "tipo", Confecenvaselineas.CEL_Idmaterial)
                    consulta4.SelCampo(Envases.ENV_Retornable, "envaseretornable")
                    consulta4.SelCampo(Envases.ENV_PrecioVenta, "precio")
                    consulta4.SelCampo(Envases.ENV_CosteSalida, "coste")
                    consulta4.SelCampo(Envases.ENV_StockMarca, "StockMarca")
                    consulta4.SelCampo(Envases.ENV_idsubfamilia, "IdSubFamilia")
                    consulta4.WheCampo(Confecenvaselineas.CEL_Idconfec, "=", rw("idtipoconfeccion").ToString)
                    consulta4.WheCampo(Envases.ENV_Retornable, "=", Retornable)

                    sql = consulta4.SQL
                    Dim dt4 As DataTable = Confecenvaselineas.MiConexion.ConsultaSQL(sql)
                    If Not dt4 Is Nothing Then
                        For Each rw4 In dt4.Rows
                            Dim marca As Integer = 0
                            If rw4("StockMarca").ToString = "S" Then
                                Select Case rw4("tipo").ToString
                                    Case "E"
                                        marca = marcaEnv
                                    Case "M"
                                        marca = marcaMat
                                    Case "Q"
                                        marca = marcaEti

                                End Select
                            End If
                            Dim CreaLinea As Boolean = True
                            Dim Espropio As String = "S"
                            'If envasepropio = "S" And rw4("tipo").ToString = "E" Then ' creamos la linea cuando el envase o el material es propio
                            '    CreaLinea = True
                            'End If
                            'If materialpropio = "S" And rw4("tipo").ToString <> "E" Then ' creamos la linea cuando el envase o el material es propio
                            '    CreaLinea = True
                            'End If
                            If rw4("tipo").ToString = "E" Then
                                Espropio = envasepropio
                            Else
                                Espropio = materialpropio
                            End If
                            If CreaLinea = True Then
                                Dim idmaterial As Integer = VaInt(rw4("idmaterial"))
                                Dim cantidad As Double = VaDec(rw4("cantidad")) * bultos
                                Dim envaseretornable As String = rw4("envaseretornable").ToString

                                Dim IdSubFamilia As String = (rw4("IdSubFamilia").ToString & "").Trim
                                Dim TipoEnvase As String = E_FianzasEnvases.TipoEnvase(IdCliente, IdDomicilio, IdSubFamilia)

                                Dim precioenvase As String = ""
                                Dim precioenvasefianza As String = ""
                                'If envaseretornable = "S" And FacturaEnvases = "S" Then
                                If envaseretornable = "S" And
                                    (TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarEnAlbaran Or TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarYDeclarar) Then
                                    precioenvase = rw4("precio").ToString
                                ElseIf envaseretornable = "S" And TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
                                    precioenvasefianza = rw4("precio").ToString
                                End If


                                Dim Coste As Double = VaDec(rw4("coste"))

                                Dim clave As New stClave_Consumo(idmaterial, marca, envaseretornable, VaDec(precioenvase), Coste, Espropio, TipoEnvase, VaDec(precioenvasefianza))
                                Dim datos As New stDatos_consumo(cantidad)
                                Acum.Suma(clave, datos)
                            End If
                            ' acumular la cantidad por los bultos y por el material y la marca
                        Next
                    End If
                Next




            End If


            For Each clave As stClave_Consumo In Acum.Dc.Keys
                Dim dato As stDatos_consumo = Acum.Dc(clave)


                Uds = dato.cantidad
                precio = ""
                preciofianza = ""

                'If clave.Retornable = "S" And FacturaEnvases = "S" Then
                If clave.Retornable = "S" And (clave.TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarEnAlbaran Or clave.TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarYDeclarar) Then
                    precio = clave.Precio.ToString
                ElseIf clave.Retornable = "S" And clave.TipoEnvase = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
                    preciofianza = clave.PrecioFianza.ToString
                End If

                'If IdVale = 0 Then
                IdVale = CrearCabeceraEnvases(Operacion, IdVale)
                'End If
                Dim coste As String = clave.Coste.ToString

                CreaLineaEnvases(IdVale, clave.Idmaterial, Uds, precio, clave.Idmarca.ToString, Me.ASA_idpuntoventa.Valor, coste, clave.EsPropio, clave.TipoEnvase, preciofianza)

            Next


            If Retornable = "S" Then
                Me.ASA_idvaleenvase.Valor = IdVale
            Else
                Me.ASA_idvaleenvasematerial.Valor = IdVale
            End If
            Me.Actualizar()

        End If

    End Sub

    Private Sub CreaLineaEnvases(ByVal idvale As Integer, ByVal idenvase As Integer, ByVal uds As String, ByVal Precio As String, ByVal idmarca As String, ByVal idalmacen As String, Coste As String,
                                 Espropio As String, TipoEnvase As String, PrecioFianza As String)

        Dim idLinea As Integer = 0

        ValeEnvases_lineas.VaciaEntidad()
        idLinea = ValeEnvases_lineas.MaxId
        ValeEnvases_lineas.VEL_Id.Valor = idLinea.ToString
        ValeEnvases_lineas.VEL_idvale.Valor = idvale.ToString
        ValeEnvases_lineas.VEL_idenvase.Valor = idenvase
        ValeEnvases_lineas.VEL_retira.Valor = uds
        ValeEnvases_lineas.VEL_entrega.Valor = "0"
        ValeEnvases_lineas.VEL_precioretira.Valor = Precio
        ValeEnvases_lineas.VEL_precioentrega.Valor = "0"
        ValeEnvases_lineas.VEL_idmarca.Valor = idmarca
        ValeEnvases_lineas.VEL_idalmacen.Valor = idalmacen
        ValeEnvases_lineas.VEL_preciocoste.Valor = Coste
        ValeEnvases_lineas.VEL_Automatica.Valor = "S"
        ValeEnvases_lineas.VEL_MaterialPropio.Valor = "S"
        ValeEnvases_lineas.VEL_TipoEnvase.Valor = TipoEnvase
        ValeEnvases_lineas.VEL_PrecioFianza.Valor = PrecioFianza
        ValeEnvases_lineas.Insertar()

    End Sub


    Private Function CrearCabeceraEnvases(ByVal Operacion As String, IdVale As Integer) As Integer

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

        Dim bNuevo As Boolean = (IdVale = 0)


        If bNuevo Then
            IdVale = ValeEnvases.MaxId
        ElseIf Not ValeEnvases.LeerId(IdVale) Then
            bNuevo = True
        End If

        ValeEnvases.VEV_Idvale.Valor = IdVale.ToString
        ValeEnvases.VEV_Operacion.Valor = Operacion
        ValeEnvases.VEV_Campa.Valor = Me.ASA_ejercicio.Valor
        ValeEnvases.VEV_Idcentro.Valor = Me.ASA_idcentro.Valor
        ValeEnvases.VEV_Numero.Valor = Me.ASA_albaran.Valor
        ValeEnvases.VEV_Fecha.Valor = Me.ASA_fechasalida.Valor
        ValeEnvases.VEV_IdAlmacen.Valor = Me.ASA_idpuntoventa.Valor
        ValeEnvases.VEV_IdConcepto.Valor = "0"
        ValeEnvases.VEV_Concepto.Valor = "ALBARAN SALIDA " + Me.ASA_albaran.Valor
        ValeEnvases.VEV_TipoSujeto.Valor = "C"
        ValeEnvases.VEV_Codigo.Valor = Me.ASA_idcliente.Valor
        ValeEnvases.VEV_Referencia.Valor = Me.ASA_referencia.Valor


        If bNuevo Then
            ValeEnvases.Insertar()
        Else
            ValeEnvases.Actualizar()
        End If



        Return IdVale

    End Function


    Public Function TotalGenero(IdAlbSalida As String, bValorado As Boolean) As Decimal

        Dim total As Decimal = 0

        If VaInt(IdAlbSalida) > 0 Then

            Dim sql As String = ""

            'Si es valorado (factura) que coja el importe del ImporteGeneroVTA, si es el albarán, de ImporteGenero
            If bValorado Then
                sql = "SELECT SUM(ASL_ImporteGeneroVTA) as ImporteGenero FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = " & IdAlbSalida
            Else
                sql = "SELECT SUM(ASL_ImporteGenero) as ImporteGenero FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = " & IdAlbSalida
            End If



            Dim dte As DataTable = MiConexion.ConsultaSQL(sql)
            If Not dte Is Nothing Then
                If dte.Rows.Count > 0 Then
                    total = VaDec(dte.Rows(0)("ImporteGenero"))
                End If
            End If


        End If


        Return total

    End Function


    Public Function TotalEnvases(IdValeEnvase As String) As Decimal

        Dim total As Decimal = 0

        If VaInt(IdValeEnvase) > 0 Then


            Dim sql As String = "SELECT SUM(VEL_RETIRA * VEL_PRECIORETIRA) - SUM(VEL_ENTREGA * VEL_PRECIOENTREGA) AS ienvases FROM valeenvases_lineas where VEL_IDVALE=" + IdValeEnvase
            Dim dte As DataTable = MiConexion.ConsultaSQL(sql)
            If Not dte Is Nothing Then
                If dte.Rows.Count > 0 Then
                    total = VaDec(dte.Rows(0)("ienvases"))
                End If
            End If


        End If


        Return total

    End Function


    Public Function GastosFactura(IdAlbSalida As String) As Decimal

        Dim total As Decimal = 0

        If VaInt(IdAlbSalida) > 0 Then


            Dim sql As String = "SELECT SUM(ASG_importegastodivisa) as Importe FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = " & IdAlbSalida


            Dim dte As DataTable = MiConexion.ConsultaSQL(sql)
            If Not dte Is Nothing Then
                If dte.Rows.Count > 0 Then
                    total = VaDec(dte.Rows(0)("Importe"))
                End If
            End If


        End If


        Return total

    End Function


    Public Function ConsultaCostesPartida(IdLineaPalet As String, bDevuelveTabla As Boolean) As String

        Dim sql As String = ""
        sql = sql & " SELECT IdLineaEntrada, Albaran, Agricultor, Partida, " & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " Producto, " & vbCrLf
        End If
        sql = sql & " Kilos, CASE Kilos WHEN 0 THEN 0 ELSE Importe / Kilos END as Precio" & vbCrLf
        sql = sql & " FROM(" & vbCrLf
        sql = sql & " SELECT PLT_IdLineaEntrada as IdLineaEntrada, " & vbCrLf
        sql = sql & " AEN_Albaran as Albaran, AGR_Nombre as Agricultor, AEL_Muestreo as Partida," & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " GEN_NombreGenero as Producto, " & vbCrLf
        End If
        sql = sql & " (SELECT SUM(ALC_KilosNetos) FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = AEL_IdLinea) as Kilos," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(ALC_KilosNetos,0) * COALESCE(ALC_Precio,0)) FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = AEL_IdLinea) as Importe" & vbCrLf
        sql = sql & " FROM Palets_Traza" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLT_IdLineaEntrada" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran " & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
            sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet & vbCrLf
        Else
            sql = sql & " WHERE PLT_IdLineaPalet = PLL_IdLinea" & vbCrLf
        End If
        sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
        sql = sql & " ) AS Z" & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " ORDER BY Albaran, IdLineaEntrada" & vbCrLf
        End If


        Return sql

    End Function


    Public Function ConsultaCostesLineaAlbaran(IdLineaAlbaran As String, bDevuelveTabla As Boolean) As String

        Dim sqlPartida As String = ConsultaCostesPartida("", False)


        Dim sql As String = ""
        sql = sql & " SELECT PLL_IdPalet as IdPalet, PLL_IdLinea as IdLineaPalet, PAL_Palet as Palet, PAL_Fecha as Fecha," & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " GEN_NombreGenero as Producto," & vbCrLf
        End If
        sql = sql & " COALESCE(PLL_KilosNetos,0) as Kilos, COALESCE(PLL_Bultos,0) as Bultos, " & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT CASE COUNT(IdLineaEntrada) WHEN 0 THEN 0 ELSE SUM(Precio) / COUNT(IdLineaEntrada) END " & vbCrLf
        sql = sql & " FROM (" & vbCrLf

        sql = sql & sqlPartida

        sql = sql & " ) AS PrecioCoste" & vbCrLf
        sql = sql & " ) AS Precio" & vbCrLf
        sql = sql & " FROM AlbSalida_lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " INNER JOIN Palets_Lineas ON (PLL_IdPalet = ASP_IdPalet " & vbCrLf
        sql = sql & " AND PLL_IdGenero = ASL_IdGenero AND PLL_IdTipoConfeccion = ASL_IdTipoConfeccion " & vbCrLf
        sql = sql & " AND PLL_IdCategoria = ASL_IdCategoria AND PLL_IdMarca = ASL_IdMarca)" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PLL_IdPalet = PAL_IdPalet" & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " LEFT JOIN Generos on GEN_IdGenero = PLL_IdGenero" & vbCrLf
        End If
        'sql = sql & " WHERE ASL_IdAlbaran = " & IdAlbaran & vbCrLf
        sql = sql & " WHERE ASL_IdLinea = " & IdLineaAlbaran & vbCrLf
        If bDevuelveTabla Then
            sql = sql & " ORDER BY PAL_Palet, PLL_IdLinea" & vbCrLf
        End If



        Return sql

    End Function



    Public Function PrecioCosteLineaAlbaran(IdLineaAlbaran As String) As Decimal

        Dim res As Decimal = 0


        If VaInt(IdLineaAlbaran) > 0 Then

            Dim sql As String = ""
            sql = sql & " SELECT CASE SUM(Kilos) WHEN 0 THEN 0 ELSE SUM(Kilos * Precio) / SUM(Kilos) END as PrecioFinal" & vbCrLf
            sql = sql & " FROM(" & vbCrLf

            sql = sql & ConsultaCostesLineaAlbaran(IdLineaAlbaran, False)

            sql = sql & " ) AS P" & vbCrLf


            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    res = VaDec(dt.Rows(0)("PrecioFinal"))

                End If
            End If

        End If



        Return res

    End Function


    Public Function TotalKilos(idalbsalida As String) As Decimal
        Dim total As Decimal = 0

        If VaInt(idalbsalida) > 0 Then

            Dim sql As String = ""


            sql = "SELECT SUM(ASL_kilosnetos) as kilos FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = " & idalbsalida



            Dim dte As DataTable = MiConexion.ConsultaSQL(sql)
            If Not dte Is Nothing Then
                If dte.Rows.Count > 0 Then
                    total = VaDec(dte.Rows(0)("Kilos"))
                End If
            End If


        End If


        Return total


    End Function


End Class
