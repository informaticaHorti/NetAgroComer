Public Class E_PreciosRef


    Inherits Cdatos.Entidad

    Public PRF_idvalora As Cdatos.bdcampo
    Public PRF_idcliente As Cdatos.bdcampo
    Public PRF_dfecha As Cdatos.bdcampo
    Public PRF_afecha As Cdatos.bdcampo
    Public PRF_cambio As Cdatos.bdcampo

    Public PRF_IdUsuarioLog As Cdatos.bdcampo
    Public PRF_FechaLog As Cdatos.bdcampo
    Public PRF_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "PreciosRef"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PRF_idvalora = New Cdatos.bdcampo(CodigoEntidad & "IdValora", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PRF_idcliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.Entero, 6)
            PRF_dfecha = New Cdatos.bdcampo(CodigoEntidad & "Dfecha", Cdatos.TiposCampo.Fecha, 10)
            PRF_afecha = New Cdatos.bdcampo(CodigoEntidad & "afecha", Cdatos.TiposCampo.Fecha, 10)
            PRF_cambio = New Cdatos.bdcampo(CodigoEntidad & "cambio", Cdatos.TiposCampo.Importe, 18, 6)

            PRF_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PRF_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PRF_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Clientes As New E_Clientes(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PRF_idvalora, "Idvalora")
        consulta.SelCampo(Me.PRF_idcliente, "Codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Me.PRF_idcliente)
        consulta.SelCampo(Me.PRF_dfecha, "Fecha")
        consulta.SelCampo(Me.PRF_afecha, "Hasta")
        consulta.SelCampo(Me.PRF_cambio, "Cambio")

        _btBusca.Params("IdRecuento", , -1)
        _btBusca.Params("Codigo", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idvalora"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValora"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)


    End Sub

    Public Function LeerValora(ByVal cliente As Integer, ByVal Desdefecha As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PRF_idcliente, "=", cliente.ToString)
        CONSULTA.WheCampo(Me.PRF_dfecha, "=", Desdefecha)

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


    Public Function ExisteValora(ByVal Cliente As Integer, ByVal Fecha As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PRF_idcliente, "=", Cliente.ToString)
        CONSULTA.WheCampo(Me.PRF_dfecha, "=", Fecha)

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



End Class
