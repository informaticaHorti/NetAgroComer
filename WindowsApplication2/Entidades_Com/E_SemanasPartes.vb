Public Class E_SemanasPartes
    Inherits Cdatos.Entidad


    Public SEV_IdSemana As Cdatos.bdcampo
    Public SEV_Ejercicio As Cdatos.bdcampo
    Public SEV_Semana As Cdatos.bdcampo
    Public SEV_Ano As Cdatos.bdcampo
    Public SEV_FechaInicialEntrada As Cdatos.bdcampo
    Public SEV_FechaFinalEntrada As Cdatos.bdcampo
    Public SEV_FechaInicialSalida As Cdatos.bdcampo
    Public SEV_FechaFinalSalida As Cdatos.bdcampo
    Public SEV_LiquidadoSN As Cdatos.bdcampo

    Public SEV_IdUsuarioLog As Cdatos.bdcampo
    Public SEV_FechaLog As Cdatos.bdcampo
    Public SEV_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "SemanasPartes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            SEV_IdSemana = New Cdatos.bdcampo(CodigoEntidad & "IdSemana", Cdatos.TiposCampo.CadenaNumero, 6, 0, True)
            SEV_Ejercicio = New Cdatos.bdcampo(CodigoEntidad & "Ejercicio", Cdatos.TiposCampo.Entero, 2)
            SEV_Semana = New Cdatos.bdcampo(CodigoEntidad & "Semana", Cdatos.TiposCampo.Entero, 2)
            SEV_Ano = New Cdatos.bdcampo(CodigoEntidad & "Ano", Cdatos.TiposCampo.Entero, 2)
            SEV_FechaInicialEntrada = New Cdatos.bdcampo(CodigoEntidad & "FechaInicialEntrada", Cdatos.TiposCampo.Fecha, 10)
            SEV_FechaFinalEntrada = New Cdatos.bdcampo(CodigoEntidad & "FechaFinalEntrada", Cdatos.TiposCampo.Fecha, 10)
            SEV_FechaInicialSalida = New Cdatos.bdcampo(CodigoEntidad & "FechaInicialSalida", Cdatos.TiposCampo.Fecha, 10)
            SEV_FechaFinalSalida = New Cdatos.bdcampo(CodigoEntidad & "FechaFinalSalida", Cdatos.TiposCampo.Fecha, 10)
            SEV_LiquidadoSN = New Cdatos.bdcampo(CodigoEntidad & "LiquidadoSN", Cdatos.TiposCampo.Cadena, 1)

            SEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            SEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            SEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.SEV_Ejercicio, "Campa")
        consulta.SelCampo(Me.SEV_Ano, "Año")
        consulta.SelCampo(Me.SEV_Semana, "Sem")
        consulta.SelCampo(Me.SEV_FechaInicialEntrada, "FechaDesde_C")
        consulta.SelCampo(Me.SEV_FechaFinalEntrada, "FechaHasta_C")
        consulta.SelCampo(Me.SEV_FechaInicialSalida, "FechaDesde_V")
        consulta.SelCampo(Me.SEV_FechaFinalSalida, "FechaHasta_V")



        _btBusca.CL_BuscaAlb = False ' busqueda por codigo



        _btBusca.CL_CampoOrden = "Sem"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Sem"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaSemana"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub


    Public Function LeerSemana(Ejercicio As Integer, Semana As Integer)

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.SEV_Ejercicio, "=", Ejercicio.ToString)
        CONSULTA.WheCampo(Me.SEV_Semana, "=", Semana.ToString)

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


    Public Function ExisteSemana(ByVal Campa As Integer, ByVal semana As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.SEV_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.SEV_Semana, "=", semana.ToString)

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
