Public Class E_ParteExistencias
    Inherits Cdatos.Entidad


    Public PSM_idparte As Cdatos.bdcampo
    Public PSM_campa As Cdatos.bdcampo
    Public PSM_idcentro As Cdatos.bdcampo
    Public PSM_fechafinal As Cdatos.bdcampo
    Public PSM_fechainicial As Cdatos.bdcampo

    Public PSM_IdUsuarioLog As Cdatos.bdcampo
    Public PSM_FechaLog As Cdatos.bdcampo
    Public PSM_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "ParteExistencias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PSM_idparte = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PSM_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            PSM_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 2)
            PSM_fechafinal = New Cdatos.bdcampo(CodigoEntidad & "fechafinal", Cdatos.TiposCampo.Fecha, 10)
            PSM_fechainicial = New Cdatos.bdcampo(CodigoEntidad & "fechainicial", Cdatos.TiposCampo.Fecha, 10)

            PSM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PSM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PSM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PSM_idparte, "IdParte")
        consulta.SelCampo(Me.PSM_campa, "Ejercicio")
        consulta.SelCampo(Me.PSM_idcentro, "Codigo")
        consulta.SelCampo(Centros.Nombre, "CE", Me.PSM_idcentro)
        consulta.SelCampo(Me.PSM_fechafinal, "Fecha")
        consulta.SelCampo(Me.PSM_fechainicial, "FechaInicial")

        _btBusca.Params("Idparte", , -1)
        _btBusca.Params("Codigo", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Centros.IdCentro
        _btBusca.CL_camponombre = Centros.Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idparte"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaParte"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub

    Public Function LeerParte(ByVal Campa As Integer, ByVal Centro As Integer, ByVal FechaFinal As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PSM_campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.PSM_idcentro, "=", Centro.ToString)
        CONSULTA.WheCampo(Me.PSM_fechafinal, "=", FechaFinal)

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


    Public Function ExisteParte(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Fecha As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PSM_campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.PSM_idcentro, "=", Centro.ToString)
        CONSULTA.WheCampo(Me.PSM_fechafinal, "=", PSM_fechafinal.ToString)

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
