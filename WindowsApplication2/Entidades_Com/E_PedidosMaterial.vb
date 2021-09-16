Public Class E_PedidosMaterial
    Inherits Cdatos.Entidad

    Public PMA_Idpedido As Cdatos.bdcampo
    Public PMA_Campa As Cdatos.bdcampo
    Public PMA_Idcentro As Cdatos.bdcampo
    Public PMA_Numero As Cdatos.bdcampo
    Public PMA_Fecha As Cdatos.bdcampo
    Public PMA_Idacreedor As Cdatos.bdcampo
    Public PMA_referencia As Cdatos.bdcampo
    Public PMA_observaciones As Cdatos.bdcampo

    Public PMA_IdUsuarioLog As Cdatos.bdcampo
    Public PMA_FechaLog As Cdatos.bdcampo
    Public PMA_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "PedidosMaterial"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PMA_Idpedido = New Cdatos.bdcampo(CodigoEntidad & "idpedido", Cdatos.TiposCampo.Entero, 8, 0, True)
            PMA_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            PMA_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            PMA_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            PMA_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            PMA_Idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5)
            PMA_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 25)
            PMA_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)

            PMA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PMA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PMA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.PMA_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Acreedores As New E_Acreedores(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PMA_Idpedido, "Idpedido")
        consulta.SelCampo(Me.PMA_Campa, "Campa")
        consulta.SelCampo(Me.PMA_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.PMA_Idcentro)
        consulta.SelCampo(Me.PMA_Numero, "Numero")
        consulta.SelCampo(Me.PMA_Fecha, "Fecha")
        consulta.SelCampo(Me.PMA_Idacreedor, "Codigo")
        consulta.SelCampo(Acreedores.ACR_Nombre, "Nombre", Me.PMA_Idacreedor)
        consulta.SelCampo(Me.PMA_referencia, "Referencia")

        _btBusca.Params("IdCentro", , -1)
        _btBusca.Params("Idpedido", , -1)


        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        '_btBusca.CL_DevuelveCampo = "numero"
        _btBusca.CL_DevuelveCampo = "Idpedido"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValeEnvases"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Acreedores.ACR_Codigo
        _btBusca.CL_camponombre = Acreedores.ACR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


    End Sub

    Public Function LeerPedido(ByVal Campa As Integer, ByVal Centro As Integer, ByVal pedido As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PMA_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PMA_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PMA_Numero, "=", pedido.ToString)

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


    Public Function ExistePedido(ByVal Campa As Integer, ByVal Centro As Integer, ByVal pedido As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PMA_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PMA_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PMA_Numero, "=", pedido.ToString)

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
                existe = ExistePedido(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de pedidos", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Private Sub E_ValeEnvases_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from pedidosmateriallineas where PML_idpedido=" + Me.PMA_Idpedido.Valor
        MiConexion.OrdenSql(sql)
    End Sub



   
End Class
