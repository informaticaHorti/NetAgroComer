Public Class E_LotesProduccion
    Inherits Cdatos.Entidad


    Public LPD_Idlote As Cdatos.bdcampo
    Public LPD_Campa As Cdatos.bdcampo
    Public LPD_Lote As Cdatos.bdcampo
    Public LPD_Fecha As Cdatos.bdcampo
    Public LPD_Idgenero As Cdatos.bdcampo
    Public LPD_IdUbicacionPV As Cdatos.bdcampo
    Public LPD_IdCategoria As Cdatos.bdcampo
    Public LPD_Calidad As Cdatos.bdcampo
    Public LPD_FechaProducto As Cdatos.bdcampo
    Public LPD_IdEnvase As Cdatos.bdcampo
    Public LPD_KilosxBulto As Cdatos.bdcampo
    Public LPD_Controlado As Cdatos.bdcampo
    Public LPD_GP As Cdatos.bdcampo
    Public LPD_Color As Cdatos.bdcampo

    Public LPD_IdProgramaCalidad As Cdatos.bdcampo

    Public LPD_IdUsuarioLog As Cdatos.bdcampo
    Public LPD_FechaLog As Cdatos.bdcampo
    Public LPD_HoraLog As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Generos As New E_Generos(idUsuario, cn)


        Try

            NombreTabla = "LotesProduccion"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LPD_Idlote = New Cdatos.bdcampo(CodigoEntidad & "IdLote", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            LPD_Campa = New Cdatos.bdcampo(CodigoEntidad & "Campa", Cdatos.TiposCampo.EnteroPositivo, 2)
            LPD_Lote = New Cdatos.bdcampo(CodigoEntidad & "Lote", Cdatos.TiposCampo.EnteroPositivo, 6)
            LPD_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            LPD_Idgenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            LPD_IdUbicacionPV = New Cdatos.bdcampo(CodigoEntidad & "IdUbicacionPV", Cdatos.TiposCampo.EnteroPositivo, 3)
            LPD_IdCategoria = New Cdatos.bdcampo(CodigoEntidad & "IdCategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            LPD_Calidad = New Cdatos.bdcampo(CodigoEntidad & "Calidad", Cdatos.TiposCampo.Cadena, 1)
            LPD_FechaProducto = New Cdatos.bdcampo(CodigoEntidad & "FechaProducto", Cdatos.TiposCampo.Fecha, 10)
            LPD_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "IdEnvase", Cdatos.TiposCampo.Entero, 5)
            LPD_KilosxBulto = New Cdatos.bdcampo(CodigoEntidad & "KilosxBulto", Cdatos.TiposCampo.Importe, 5, 2)
            LPD_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)
            LPD_GP = New Cdatos.bdcampo(CodigoEntidad & "GP", Cdatos.TiposCampo.Cadena, 1)
            LPD_Color = New Cdatos.bdcampo(CodigoEntidad & "Color", Cdatos.TiposCampo.Cadena, 1)

            LPD_IdProgramaCalidad = New Cdatos.bdcampo(CodigoEntidad & "IdProgramaCalidad", Cdatos.TiposCampo.Entero, 4)

            LPD_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LPD_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LPD_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.LPD_Lote)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Palet Semiterminado"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.LPD_Idlote, "Idlote")
        consulta.SelCampo(Me.LPD_Lote, "Lote")
        consulta.SelCampo(Me.LPD_Fecha, "Fecha")
        consulta.SelCampo(Me.LPD_Idgenero, "Codigo")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Me.LPD_Idgenero)
        consulta.SelCampo(Me.LPD_IdUbicacionPV, "PV")
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

        CONSULTA.WheCampo(Me.LPD_Campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LPD_Lote, "=", numlote.ToString)

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

        CONSULTA.WheCampo(Me.LPD_Campa, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.LPD_Lote, "=", numlote.ToString)

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


    Private Sub E_LotesProduccion_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos


    End Sub



    Private Sub E_LotesProduccion_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        Dim dt As New DataTable
        Dim lotesproduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)

        sql = "select * from lotesproduccion_lineas where LPL_idlote=" + LPD_Idlote.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                lotesproduccion_lineas.CargaCampos(rw)
                lotesproduccion_lineas.Eliminar()
            Next
        End If


    End Sub


    Public Function kilosLote(idlote As String) As Decimal
        Dim ret As Decimal
        Dim sql As String = "select sum(lpl_kilos) as kilos from lotesproduccion_lineas where lpl_idlote=" + idlote
        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("kilos"))
            End If
        End If

        Return ret

    End Function



End Class
