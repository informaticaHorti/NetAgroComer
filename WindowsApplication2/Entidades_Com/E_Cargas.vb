Public Class E_Cargas
    Inherits Cdatos.Entidad

    Public CAR_Idcarga As Cdatos.bdcampo
    Public CAR_Ejercicio As Cdatos.bdcampo
    Public CAR_IdCentro As Cdatos.bdcampo
    Public CAR_IdMuelle As Cdatos.bdcampo
    Public CAR_Numero As Cdatos.bdcampo
    Public CAR_Fecha As Cdatos.bdcampo
    Public CAR_IdTransportista As Cdatos.bdcampo
    Public CAR_Matricula As Cdatos.bdcampo
    Public CAR_IdConcepto As Cdatos.bdcampo
    Public CAR_Concepto As Cdatos.bdcampo
    Public CAR_Reparto As Cdatos.bdcampo
    Public CAR_Temperatura As Cdatos.bdcampo
    Public CAR_IdCargador As Cdatos.bdcampo
    Public CAR_idpedido1 As Cdatos.bdcampo
    Public CAR_idpedido2 As Cdatos.bdcampo
    Public CAR_idpedido3 As Cdatos.bdcampo
    Public CAR_idpedido4 As Cdatos.bdcampo
    Public CAR_idpedido5 As Cdatos.bdcampo
    Public CAR_idpedido6 As Cdatos.bdcampo
    Public CAR_idalbaran1 As Cdatos.bdcampo
    Public CAR_idalbaran2 As Cdatos.bdcampo
    Public CAR_idalbaran3 As Cdatos.bdcampo
    Public CAR_idalbaran4 As Cdatos.bdcampo
    Public CAR_idalbaran5 As Cdatos.bdcampo
    Public CAR_idalbaran6 As Cdatos.bdcampo

    Public CAR_IdUsuarioLog As Cdatos.bdcampo
    Public CAR_FechaLog As Cdatos.bdcampo
    Public CAR_HoraLog As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Cargas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

       

            CAR_Idcarga = New Cdatos.bdcampo(CodigoEntidad & "Idcarga", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CAR_Ejercicio = New Cdatos.bdcampo(CodigoEntidad & "Ejercicio", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            CAR_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            CAR_IdMuelle = New Cdatos.bdcampo(CodigoEntidad & "Idmuelle", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            CAR_Numero = New Cdatos.bdcampo(CodigoEntidad & "Numero", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            CAR_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10, 0)
            CAR_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 4, 0)
            CAR_Matricula = New Cdatos.bdcampo(CodigoEntidad & "Matricula", Cdatos.TiposCampo.Cadena, 20, 0)
            CAR_IdConcepto = New Cdatos.bdcampo(CodigoEntidad & "Idconcepto", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            CAR_Concepto = New Cdatos.bdcampo(CodigoEntidad & "Concepto", Cdatos.TiposCampo.Cadena, 30, 0)
            CAR_Reparto = New Cdatos.bdcampo(CodigoEntidad & "Reparto", Cdatos.TiposCampo.Cadena, 1, 0)
            CAR_Temperatura = New Cdatos.bdcampo(CodigoEntidad & "Temperatura", Cdatos.TiposCampo.Cadena, 10, 0)
            CAR_IdCargador = New Cdatos.bdcampo(CodigoEntidad & "Idcargador", Cdatos.TiposCampo.EnteroPositivo, 3, 0)
            CAR_idpedido1 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido1", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idpedido2 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido2", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idpedido3 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido3", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idpedido4 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido4", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idpedido5 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido5", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idpedido6 = New Cdatos.bdcampo(CodigoEntidad & "Idpedido6", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran1 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran1", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran2 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran2", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran3 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran3", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran4 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran4", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran5 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran5", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            CAR_idalbaran6 = New Cdatos.bdcampo(CodigoEntidad & "Idalbaran6", Cdatos.TiposCampo.EnteroPositivo, 6, 0)

            CAR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CAR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CAR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.CAR_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Transportistas As New E_Transportistas(idUsuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.CAR_Idcarga, "IdCarga")
        consulta.SelCampo(Me.CAR_Numero, "Carga")
        consulta.SelCampo(Me.CAR_Ejercicio, "Ejercicio")
        consulta.SelCampo(Me.CAR_IdCentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "CE", Me.CAR_IdCentro, Centros.IdCentro)
        consulta.SelCampo(Me.CAR_Fecha, "Fecha")
        consulta.SelCampo(Me.CAR_IdTransportista, "Codigo")
        consulta.SelCampo(Transportistas.TTA_Nombre, "Transportista", Me.CAR_IdTransportista)
        consulta.SelCampo(Me.CAR_Matricula, "Matricula")
        _btBusca.Params("Idcarga", , -1)
        _btBusca.Params("IdCentro", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Transportistas.TTA_IdTransportista
        _btBusca.CL_camponombre = Transportistas.TTA_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdCarga"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCarga"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = True


        _btBusca.ParamConsultaAlb(consulta, "", Me.CAR_IdTransportista, Me.CAR_Fecha, Me.CAR_IdCentro)


    End Sub



    Public Function LeerCarga(ByVal Campa As Integer, ByVal numero As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.CAR_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.CAR_Numero, "=", numero.tostring)

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

    Public Function ExisteCarga(ByVal Campa As Integer, ByVal numero As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.CAR_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.CAR_Numero, "=", numero.ToString)

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

    Public Function MaxIdCampa(ByVal Campa As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Campa.ToString, vmax)

                existe = ExisteCarga(Campa, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


End Class
