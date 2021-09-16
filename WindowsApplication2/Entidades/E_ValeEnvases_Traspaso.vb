Public Class E_ValeEnvases_Traspaso
    Inherits Cdatos.Entidad

    Public VET_Idvale As Cdatos.bdcampo
    Public VET_Campa As Cdatos.bdcampo
    Public VET_Idcentro As Cdatos.bdcampo
    Public VET_Numero As Cdatos.bdcampo
    Public VET_Fecha As Cdatos.bdcampo
    Public VET_IdAlmacenOrigen As Cdatos.bdcampo
    Public VET_IdAlmacenDestino As Cdatos.bdcampo
    Public VET_Concepto As Cdatos.bdcampo
    Public VET_IdValeOrigen As Cdatos.bdcampo
    Public VET_IdValeDestino As Cdatos.bdcampo
    Public VET_IdAsientoNet As Cdatos.bdcampo
    Public VET_IdTransportista As Cdatos.bdcampo
    Public VET_Matricula As Cdatos.bdcampo
    Public VET_Tractora As Cdatos.bdcampo

    Public VET_IdUsuarioLog As Cdatos.bdcampo
    Public VET_FechaLog As Cdatos.bdcampo
    Public VET_HoraLog As Cdatos.bdcampo




    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValeEnvases_Traspaso"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VET_Idvale = New Cdatos.bdcampo(CodigoEntidad & "idvale", Cdatos.TiposCampo.Entero, 8, 0, True)
            VET_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            VET_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            VET_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            VET_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            VET_IdAlmacenOrigen = New Cdatos.bdcampo(CodigoEntidad & "idalmacenorigen", Cdatos.TiposCampo.Entero, 3)
            VET_IdAlmacenDestino = New Cdatos.bdcampo(CodigoEntidad & "idalmacendestino", Cdatos.TiposCampo.Entero, 3)
            VET_Concepto = New Cdatos.bdcampo(CodigoEntidad & "concepto", Cdatos.TiposCampo.Cadena, 30)
            VET_IdValeOrigen = New Cdatos.bdcampo(CodigoEntidad & "idvaleorigen", Cdatos.TiposCampo.Entero, 6)
            VET_IdValeDestino = New Cdatos.bdcampo(CodigoEntidad & "idvaledestino", Cdatos.TiposCampo.Entero, 6)
            VET_IdAsientoNet = New Cdatos.bdcampo(CodigoEntidad & "IdAsientoNet", Cdatos.TiposCampo.Entero, 6)
            VET_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            VET_Matricula = New Cdatos.bdcampo(CodigoEntidad & "Matricula", Cdatos.TiposCampo.Cadena, 20)
            VET_Tractora = New Cdatos.bdcampo(CodigoEntidad & "Tractora", Cdatos.TiposCampo.Cadena, 20)

            VET_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VET_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VET_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.VET_Numero)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Vale de Traspaso de Envases"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.VET_Idvale, "IdVale")
        consulta.SelCampo(Me.VET_Campa, "Campa")
        consulta.SelCampo(Me.VET_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.VET_Idcentro, Centros.IdCentro)
        consulta.SelCampo(Me.VET_Numero, "Numero")
        consulta.SelCampo(Me.VET_Fecha, "Fecha")

        _btBusca.Params("IdCentro", , -1)

        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VET_Idvale as IdVale, VET_campa as Campa, VET_idcentro as IdCentro, VET_numero as Numero, VET_fecha as Fecha from Valeenvases_traspaso"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "numero"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValeEnvasesTraspaso"
        _btBusca.CL_ch1000 = False

    End Sub

    Public Function LeerVale(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numvale As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VET_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.VET_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.VET_Numero, "=", numvale.ToString)

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


    Public Function ExisteVale(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numvale As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VET_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.VET_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.VET_Numero, "=", numvale.ToString)

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
                existe = ExisteVale(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de envases", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Private Sub E_ValeEnvases_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
        sql = "Delete from valeenvases_traspaso_lineas where VTL_idvaletraspaso = " + Me.VET_Idvale.Valor
        MiConexion.OrdenSql(sql)

        If VaInt(Me.VET_IdValeOrigen.Valor) > 0 Then
            If Valeenvases.LeerId(Me.VET_IdValeOrigen.Valor) = True Then
                Valeenvases.Eliminar()
            End If
        End If

        If VaInt(Me.VET_IdValeDestino.Valor) > 0 Then
            If Valeenvases.LeerId(Me.VET_IdValeDestino.Valor) = True Then
                Valeenvases.Eliminar()
            End If
        End If

    End Sub

    Public Sub CrearValeEnvasesTraspaso(ByVal IdValeTraspaso As String)

        Dim sql As String
        Dim dt As New DataTable
        Dim ConsultaP As New Cdatos.E_select
        Dim ConsultaB As New Cdatos.E_select
        Dim x As Integer = 0
        Dim Operacion As String = ""
        Dim IdVale As Integer = 0
        If Me.LeerId(IdValeTraspaso) = True Then



            'creo un vale origen como retira
            IdVale = VaInt(Me.VET_IdValeOrigen.Valor)
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

            If VaInt(Me.VET_IdAlmacenOrigen.Valor) > 0 Then

                sql = "Select VTL_idenvase as idenvase, VTL_uds as uds, VTL_precio as precio,VTL_idmarca as idmarca from valeenvases_traspaso_lineas where VTL_idvaletraspaso=" + IdValeTraspaso
                dt = Me.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw As DataRow In dt.Rows
                        IdVale = CrearCabeceraEnvases("TO", Me.VET_IdAlmacenOrigen.Valor, IdVale)
                        CreaLineaEnvases(IdVale, rw("idenvase"), rw("uds").ToString, "0", rw("precio"), 0, Me.VET_IdAlmacenOrigen.Valor, rw("idmarca"))
                    Next
                End If

                Me.VET_IdValeOrigen.Valor = IdVale

            End If


            'creo un vale destino como entrega
            IdVale = VaInt(Me.VET_IdValeDestino.Valor)
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


            If VaInt(Me.VET_IdAlmacenDestino.Valor) > 0 Then

                sql = "Select VTL_idenvase as idenvase, VTL_uds as uds, VTL_precio as precio ,VTL_idmarca as idmarca from valeenvases_traspaso_lineas where VTL_idvaletraspaso=" + IdValeTraspaso
                dt = Me.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw As DataRow In dt.Rows
                        IdVale = CrearCabeceraEnvases("TD", Me.VET_IdAlmacenDestino.Valor, IdVale)
                        CreaLineaEnvases(IdVale, rw("idenvase"), "0", rw("uds").ToString, 0, rw("precio"), Me.VET_IdAlmacenDestino.Valor, rw("idmarca"))
                    Next
                End If
                Me.VET_IdValeDestino.Valor = IdVale
            End If

            Me.Actualizar()

        End If


    End Sub


    Private Sub CreaLineaEnvases(ByVal idvale As Integer, ByVal idenvase As Integer, ByVal Retira As String, ByVal Entrega As String, ByVal PrecioRetira As Double, ByVal PrecioEntrega As Double, ByVal idalmacen As String, ByVal idmarca As Integer)
        Dim idLinea As Integer = 0

        ValeEnvases_lineas.VaciaEntidad()
        idLinea = ValeEnvases_lineas.MaxId
        ValeEnvases_lineas.VEL_Id.Valor = idLinea.ToString
        ValeEnvases_lineas.VEL_idvale.Valor = idvale.ToString
        ValeEnvases_lineas.VEL_idenvase.Valor = idenvase
        ValeEnvases_lineas.VEL_retira.Valor = Retira
        ValeEnvases_lineas.VEL_entrega.Valor = Entrega
        ValeEnvases_lineas.VEL_precioretira.Valor = PrecioRetira.ToString
        ValeEnvases_lineas.VEL_precioentrega.Valor = PrecioEntrega.ToString
        ValeEnvases_lineas.VEL_idmarca.Valor = idmarca.ToString
        ValeEnvases_lineas.VEL_idalmacen.Valor = idalmacen
        ValeEnvases_lineas.VEL_Automatica.Valor = "S"
        ValeEnvases_lineas.Insertar()

    End Sub


    Private Function CrearCabeceraEnvases(ByVal Operacion As String, ByVal idalmacen As Integer, IdVale As Integer) As Integer

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

        Dim bNuevo As Boolean = (IdVale = 0)


        If bNuevo Then
            IdVale = ValeEnvases.MaxId
        ElseIf Not ValeEnvases.LeerId(IdVale) Then
            bNuevo = True
        End If

        ValeEnvases.VEV_Idvale.Valor = IdVale.ToString
        ValeEnvases.VEV_Operacion.Valor = Operacion
        ValeEnvases.VEV_Campa.Valor = Me.VET_Campa.Valor
        ValeEnvases.VEV_Idcentro.Valor = Me.VET_Idcentro.Valor
        ValeEnvases.VEV_Numero.Valor = Me.VET_Numero.Valor
        ValeEnvases.VEV_Fecha.Valor = Me.VET_Fecha.Valor
        ValeEnvases.VEV_IdAlmacen.Valor = idalmacen.ToString
        ValeEnvases.VEV_IdConcepto.Valor = "0"
        ValeEnvases.VEV_Concepto.Valor = Me.VET_Concepto.Valor
        ValeEnvases.VEV_TipoSujeto.Valor = ""
        ValeEnvases.VEV_Codigo.Valor = ""


        If bNuevo Then
            ValeEnvases.Insertar()
        Else
            ValeEnvases.Actualizar()
        End If



        Return IdVale

    End Function


    'Public Function Contabiliza(ByVal IdValeTraspaso As Integer) As Integer

    '    Dim Resultado As Integer


    '    If Me.LeerId(IdValeTraspaso) = False Then
    '        Return 0
    '    End If


    '    Dim c As New Contabilizacion.clAsientos
    '    Dim asiLin As New Contabilizacion.clAsientoLineas

    '    Dim IdPuntoVenta As String = MiMaletin.IdPuntoVenta.ToString & ""
    '    Dim IdCentro As String = "0"
    '    Dim IdActividad As String = "0"
    '    Dim IdSeccion As String = "0"
    '    Dim IdDepartamento As String = "0"
    '    Dim IdSubDepartamento As String = "0"

    '    'TODO: IdAlmOrigen y IdAlmDestino son centros? PV? AlmEnvases?
    '    Dim IdAlmOrigen As String = VaInt(Me.VET_IdAlmacenOrigen.Valor).ToString("00")
    '    Dim IdAlmDestino As String = VaInt(Me.VET_IdAlmacenDestino.Valor).ToString("00")

    '    Dim Importe As Decimal = 0




    '    Dim PuntoVenta As New E_PuntoVenta(Idusuario,ConexCTB(Mimaletin.IdempresaCTB))
    '    If PuntoVenta.LeerId(IdPuntoVenta) Then
    '        IdActividad = VaInt(PuntoVenta.IdActividad.Valor).ToString
    '        IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor).ToString
    '        IdCentro = PuntoVenta.IdCentro.Valor
    '    End If



    '    'Calculamos el importe
    '    Dim sql As String = "SELECT SUM(COALESCE(VTL_Uds,0) * COALESCE(VTL_Precio,0)) as Importe" & vbCrLf
    '    sql = sql & " FROM ValeEnvases_Traspaso_Lineas" & vbCrLf
    '    'sql = sql & " LEFT JOIN Envases ON VTL_IdEnvase = ENV_IdEnvase" & vbCrLf
    '    sql = sql & " WHERE VTL_IdValeTraspaso = " & IdValeTraspaso
    '    'sql = sql & " AND COALESCE(ENV_Retornable,'') <> 'S'" & vbCrLf

    '    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
    '    If Not IsNothing(dt) Then
    '        If dt.Rows.Count > 0 Then
    '            Importe = VaDec(dt.Rows(0)("Importe"))
    '        End If
    '    End If


    '    'Si el importe es 0 no contabilizamos y no mostramos ningún mensaje
    '    If Importe = 0 Then
    '        Return -1
    '    End If



    '    'Ejemplo: Centro Origen = 09 - Centro Destino = 08
    '    '-------------------   -----------------------
    '    '43900800001 (D)                  70200800000 (H)           (M. Terceros Varios a Vtas Aprovisionamientos)
    '    '60200900000 (D)                  40200900001 (H)           (Aprov. Internos a Exportación Varios)
    '    '-------------------   -----------------------

    '    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    '    Dim Cta_MatVarios As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CTA_TRASP_ALM_MATERIALES_VARIOS.ToString, 0, 0, 0)
    '    Dim Cta_Vtas_Aprov As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CTA_TRASP_ALM_VENTAS_APROV.ToString, 0, 0, 0)
    '    Dim Cta_Aprov_Internos As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CTA_TRASP_ALM_APROV_INTERNOS.ToString, 0, 0, 0)
    '    Dim Cta_Varios As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CTA_TRASP_ALM_VARIOS.ToString, 0, 0, 0)

    '    Cta_MatVarios = Cta_MatVarios.Replace("XX", IdAlmDestino)
    '    Cta_Vtas_Aprov = Cta_Vtas_Aprov.Replace("XX", IdAlmDestino)
    '    Cta_Aprov_Internos = Cta_Aprov_Internos.Replace("XX", IdAlmOrigen)
    '    Cta_Varios = Cta_Varios.Replace("XX", IdAlmOrigen)



    '    'Centro Origen (M. Terceros Varios)
    '    asiLin = New Contabilizacion.clAsientoLineas
    '    asiLin.Concepto = "TRASPASO ALM.- " & Me.VET_Concepto.Valor
    '    asiLin.Cuenta = "4390" & VaInt(Me.VET_IdAlmacenDestino.Valor).ToString("00") & "00001"
    '    asiLin.DH = "D"
    '    asiLin.Documento = Me.VET_Numero.Valor
    '    asiLin.IdActividad = IdActividad
    '    asiLin.idConcepto = 0
    '    asiLin.IdSeccion = IdSeccion
    '    asiLin.IdDepartamento = IdDepartamento
    '    asiLin.IdSubDepartamento = IdSubDepartamento
    '    asiLin.Importe = VaDec(Importe.ToString("0.00"))
    '    asiLin.SRPC = "R"
    '    c.ListaClAsientosLineas.Add(asiLin)
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    '    'Centro Origen (Ventas aprovisionamientos)
    '    asiLin = New Contabilizacion.clAsientoLineas
    '    asiLin.Concepto = "TRASPASO ALM.- " & Me.VET_Concepto.Valor
    '    asiLin.Cuenta = "7020" & VaInt(Me.VET_IdAlmacenDestino.Valor).ToString("00") & "00000"
    '    asiLin.DH = "H"
    '    asiLin.Documento = Me.VET_Numero.Valor
    '    asiLin.IdActividad = IdActividad
    '    asiLin.idConcepto = 0
    '    asiLin.IdSeccion = IdSeccion
    '    asiLin.IdDepartamento = IdDepartamento
    '    asiLin.IdSubDepartamento = IdSubDepartamento
    '    asiLin.Importe = VaDec(Importe.ToString("0.00"))
    '    asiLin.SRPC = "S"
    '    c.ListaClAsientosLineas.Add(asiLin)
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    '    'Centro Destino (Aprov. Internos)
    '    asiLin = New Contabilizacion.clAsientoLineas
    '    asiLin.Concepto = "TRASPASO ALM.- " & Me.VET_Concepto.Valor
    '    asiLin.Cuenta = "6020" & VaInt(Me.VET_IdAlmacenOrigen.Valor).ToString("00") & "00000"
    '    asiLin.DH = "D"
    '    asiLin.Documento = Me.VET_Numero.Valor
    '    asiLin.IdActividad = IdActividad
    '    asiLin.idConcepto = 0
    '    asiLin.IdSeccion = IdSeccion
    '    asiLin.IdDepartamento = IdDepartamento
    '    asiLin.IdSubDepartamento = IdSubDepartamento
    '    asiLin.Importe = VaDec(Importe.ToString("0.00"))
    '    asiLin.SRPC = "R"
    '    c.ListaClAsientosLineas.Add(asiLin)
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    '    'Centro Destino (Ejemplo exportacion)
    '    asiLin = New Contabilizacion.clAsientoLineas
    '    asiLin.Concepto = "TRASPASO ALM.- " & Me.VET_Concepto.Valor
    '    asiLin.Cuenta = "4020" & VaInt(Me.VET_IdAlmacenOrigen.Valor).ToString("00") & "00001"
    '    asiLin.DH = "H"
    '    asiLin.Documento = Me.VET_Numero.Valor
    '    asiLin.IdActividad = IdActividad
    '    asiLin.idConcepto = 0
    '    asiLin.IdSeccion = IdSeccion
    '    asiLin.IdDepartamento = IdDepartamento
    '    asiLin.IdSubDepartamento = IdSubDepartamento
    '    asiLin.Importe = VaDec(Importe.ToString("0.00"))
    '    asiLin.SRPC = "S"
    '    c.ListaClAsientosLineas.Add(asiLin)
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




    '    ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    Resultado = c.Contabilizar(VaInt(Me.VET_IdAsientoNet.Valor), VaInt(IdCentro), CDate(Me.VET_Fecha.Valor), Me.VET_Campa.Valor, VaInt(IdPuntoVenta), E_Asientos.AsientoTraspasoAlmacen, IdValeTraspaso)

    '    If Resultado > 0 Then
    '        Me.VET_IdAsientoNet.Valor = Resultado.ToString
    '        Me.Actualizar()
    '    End If


    '    Return Resultado


    'End Function



End Class
