Public Class E_Lotes
    Inherits Cdatos.Entidad


    Public LTE_Idlote As Cdatos.bdcampo
    Public LTE_Campa As Cdatos.bdcampo
    Public LTE_Lote As Cdatos.bdcampo
    Public LTE_Fecha As Cdatos.bdcampo
    Public LTE_Idgenero As Cdatos.bdcampo
    Public LTE_IdUbicacionPV As Cdatos.bdcampo
    Public LTE_Calidad As Cdatos.bdcampo
    Public LTE_FechaProducto As Cdatos.bdcampo
    Public LTE_IdEnvase As Cdatos.bdcampo
    Public LTE_Controlado As Cdatos.bdcampo
    Public LTE_Color As Cdatos.bdcampo

    Public LTE_IdProgramaCalidad As Cdatos.bdcampo

    Public LTE_IdUsuarioLog As Cdatos.bdcampo
    Public LTE_FechaLog As Cdatos.bdcampo
    Public LTE_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Generos As New E_Generos(idUsuario, cn)


        Try
            NombreTabla = "Lotes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LTE_Idlote = New Cdatos.bdcampo(CodigoEntidad & "idlote", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            LTE_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.EnteroPositivo, 2)
            LTE_Lote = New Cdatos.bdcampo(CodigoEntidad & "lote", Cdatos.TiposCampo.EnteroPositivo, 6)
            LTE_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            LTE_Idgenero = New Cdatos.bdcampo(CodigoEntidad & "Idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            LTE_IdUbicacionPV = New Cdatos.bdcampo(CodigoEntidad & "IdUbicacionPV", Cdatos.TiposCampo.EnteroPositivo, 3)
            LTE_Calidad = New Cdatos.bdcampo(CodigoEntidad & "Calidad", Cdatos.TiposCampo.Cadena, 1)
            LTE_FechaProducto = New Cdatos.bdcampo(CodigoEntidad & "FechaProducto", Cdatos.TiposCampo.Fecha, 10)
            LTE_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "IdEnvase", Cdatos.TiposCampo.Entero, 5)
            LTE_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)
            LTE_Color = New Cdatos.bdcampo(CodigoEntidad & "Color", Cdatos.TiposCampo.Cadena, 1)

            LTE_IdProgramaCalidad = New Cdatos.bdcampo(CodigoEntidad & "IdProgramaCalidad", Cdatos.TiposCampo.Entero, 4)

            LTE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LTE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LTE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.LTE_Lote)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Lote"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.LTE_Idlote, "Idlote")
        consulta.SelCampo(Me.LTE_Lote, "Lote")
        consulta.SelCampo(Me.LTE_Fecha, "Fecha")
        consulta.SelCampo(Me.LTE_Idgenero, "Codigo")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Me.LTE_Idgenero)
        consulta.SelCampo(Me.LTE_IdUbicacionPV, "PV")
        ' en la consulta tiene que haber un campo que se llame codigo,y otro fecha

        _btBusca.Params("Idlote", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Generos.GEN_IdGenero
        _btBusca.CL_camponombre = Generos.GEN_NombreGenero
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        '_btBusca.CL_CampoOrden = "Agricultor"
        _btBusca.CL_CampoOrden = "Codigo"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdLote"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaLotes"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = False
    End Sub

    Public Function LeerLote(ByVal Campa As Integer, ByVal numlote As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.LTE_Campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LTE_Lote, "=", numlote.ToString)

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




    Public Function MaxIdCampa(ByVal Campa As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Campa.ToString, vmax)
                existe = ExisteLote(Campa, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Public Function ExisteLote(ByVal Campa As Integer, ByVal numlote As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.LTE_Campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LTE_Lote, "=", numlote.ToString)

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


    Private Sub E_AlbEntrada_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos
 

    End Sub



    Private Sub E_Albentrada_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        Dim dt As New DataTable
        Dim lotes_lineas As New E_lotes_lineas(Idusuario, cn)

        sql = "select * from lotes_lineas where LTL_idlote=" + LTE_Idlote.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                lotes_lineas.CargaCampos(rw)
                lotes_lineas.Eliminar()
            Next
        End If


    End Sub


    Public Function kilosLote(idlote As String) As Decimal
        Dim ret As Decimal
        Dim sql As String = "select sum(ltl_kilos) as kilos from lotes_lineas where ltl_idlote=" + idlote
        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("kilos"))
            End If
        End If

        Return ret

    End Function


End Class
