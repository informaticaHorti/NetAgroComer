Public Class E_DevEnvases
    Inherits Cdatos.Entidad

    Public DEV_Idvale As Cdatos.bdcampo
    Public DEV_Campa As Cdatos.bdcampo
    Public DEV_Idcentro As Cdatos.bdcampo
    Public DEV_Numero As Cdatos.bdcampo
    Public DEV_Fecha As Cdatos.bdcampo
    Public DEV_IdAlmacen As Cdatos.bdcampo
    Public DEV_Idcliente As Cdatos.bdcampo
    Public DEV_Referencia As Cdatos.bdcampo
    Public DEV_idvaleenvase As Cdatos.bdcampo
    Public DEV_IdConcepto As Cdatos.bdcampo
    Public DEV_Concepto As Cdatos.bdcampo

    Public DEV_IdUsuarioLog As Cdatos.bdcampo
    Public DEV_FechaLog As Cdatos.bdcampo
    Public DEV_HoraLog As Cdatos.bdcampo


    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DevEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DEV_Idvale = New Cdatos.bdcampo(CodigoEntidad & "idvale", Cdatos.TiposCampo.Entero, 8, 0, True)
            DEV_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            DEV_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            DEV_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            DEV_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            DEV_IdAlmacen = New Cdatos.bdcampo(CodigoEntidad & "idalmacen", Cdatos.TiposCampo.Entero, 3)
            DEV_Idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.Entero, 5)
            DEV_Referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 15)
            DEV_idvaleenvase = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvase", Cdatos.TiposCampo.Entero, 10)
            DEV_IdConcepto = New Cdatos.bdcampo(CodigoEntidad & "idconcepto", Cdatos.TiposCampo.Entero, 3)
            DEV_Concepto = New Cdatos.bdcampo(CodigoEntidad & "concepto", Cdatos.TiposCampo.Cadena, 30)

            DEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.DEV_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Clientes As New E_Clientes(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.DEV_Idvale, "IdVale")
        consulta.SelCampo(Me.DEV_Idcliente, "Codigo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.DEV_Idcliente)
        consulta.SelCampo(Me.DEV_Campa, "Campa")
        consulta.SelCampo(Me.DEV_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.DEV_Idcentro, Centros.IdCentro)
        consulta.SelCampo(Me.DEV_Numero, "Numero")
        consulta.SelCampo(Me.DEV_Fecha, "Fecha")

        _btBusca.Params("IdCentro", , -1)

        _btBusca.CL_BuscaAlb = True
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "idvale"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValeEnvases"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


    End Sub

    Public Function LeerVale(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numvale As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.DEV_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.DEV_Idcentro, "=", Centro.ToString)
        Else
            CONSULTA.WheCampo(Me.DEV_Numero, "=", numvale.ToString)
        End If
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

        CONSULTA.WheCampo(Me.DEV_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.DEV_Idcentro, "=", Centro.ToString)
        Else
            CONSULTA.WheCampo(Me.DEV_Numero, "=", numvale.ToString)
        End If
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


    Private Sub E_DevEnvases_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from devenvases_lineas where DEL_idvale=" + Me.DEV_Idvale.Valor
        MiConexion.OrdenSql(sql)

        Dim valeenvase As New E_ValeEnvases(Idusuario, cn)
        If valeenvase.LeerId(Me.DEV_idvaleenvase.Valor) = True Then
            valeenvase.Eliminar()
        End If
    End Sub


    Public Sub CrearValeEnvasesDevolucion(ByVal ValeDev As String)

        Dim sql As String

        Dim Envases As New E_Envases(Idusuario, cn)
        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim ConsultaP As New Cdatos.E_select
        Dim ConsultaB As New Cdatos.E_select
        Dim x As Integer = 0
        Dim Operacion As String = "DV"
        Dim IdVale As Integer = 0
        Dim Dt As New DataTable



        If Me.LeerId(ValeDev) = True Then

            IdVale = VaInt(Me.DEV_idvaleenvase.Valor)
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



            sql = "Select DEL_idenvase as idenvase, DEL_CANTIDAD AS cantidad from DevEnvases_lineas where DEL_IDVALE=" + ValeDev
            Dt = Me.MiConexion.ConsultaSQL(sql)
            If Not Dt Is Nothing Then
                For Each rw As DataRow In Dt.Rows
                    Dim dte As DataTable = AGRO_DevolucionClientes(Me.DEV_Idcliente.Valor, rw("idenvase").ToString, Me.DEV_Fecha.Valor, VaInt(rw("Cantidad")))
                    For Each rwe As DataRow In dte.Rows
                        If VaInt(rwe("devolucion")) > 0 Then
                            IdVale = CrearCabeceraEnvases(Operacion, IdVale)
                            CreaLineaEnvases(IdVale, rw("idenvase"), rwe("devolucion").ToString, rwe("precio").ToString)
                        End If
                    Next

                Next
            End If


            Me.DEV_idvaleenvase.Valor = IdVale
            Me.Actualizar()
        End If


    End Sub

    Private Sub CreaLineaEnvases(ByVal idvale As Integer, ByVal idenvase As Integer, ByVal uds As String, ByVal Precio As String)
        Dim idLinea As Integer = 0

        ValeEnvases_lineas.VaciaEntidad()
        idLinea = ValeEnvases_lineas.MaxId
        ValeEnvases_lineas.VEL_Id.Valor = idLinea.ToString
        ValeEnvases_lineas.VEL_idvale.Valor = idvale.ToString
        ValeEnvases_lineas.VEL_idenvase.Valor = idenvase
        ValeEnvases_lineas.VEL_retira.Valor = "0"
        ValeEnvases_lineas.VEL_entrega.Valor = uds
        ValeEnvases_lineas.VEL_precioretira.Valor = "0"
        ValeEnvases_lineas.VEL_precioentrega.Valor = Precio
        ValeEnvases_lineas.VEL_idmarca.Valor = "0"
        ValeEnvases_lineas.VEL_idalmacen.Valor = Me.DEV_IdAlmacen.Valor
        ValeEnvases_lineas.VEL_Automatica.Valor = "S"
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
        ValeEnvases.VEV_Campa.Valor = Me.DEV_Campa.Valor
        ValeEnvases.VEV_Idcentro.Valor = Me.DEV_Idcentro.Valor
        ValeEnvases.VEV_Numero.Valor = Me.DEV_Numero.Valor
        ValeEnvases.VEV_Fecha.Valor = Me.DEV_Fecha.Valor
        ValeEnvases.VEV_IdAlmacen.Valor = Me.DEV_IdAlmacen.Valor
        ValeEnvases.VEV_IdConcepto.Valor = Me.DEV_IdConcepto.Valor
        ValeEnvases.VEV_Concepto.Valor = Me.DEV_Concepto.Valor
        ValeEnvases.VEV_TipoSujeto.Valor = "C"
        ValeEnvases.VEV_Codigo.Valor = Me.DEV_Idcliente.Valor


        If bNuevo Then
            ValeEnvases.Insertar()
        Else
            ValeEnvases.Actualizar()
        End If



        Return IdVale

    End Function




End Class
