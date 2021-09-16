Public Class E_RecetasTec

    Inherits Cdatos.Entidad

    Public RET_IdReceta As Cdatos.bdcampo
    Public RET_Fecha As Cdatos.bdcampo
    Public RET_Referencia As Cdatos.bdcampo
    Public RET_IdTecnico As Cdatos.bdcampo
    Public RET_IdFinca As Cdatos.bdcampo
    Public RET_Numero As Cdatos.bdcampo
    Public RET_HoraVisita As Cdatos.bdcampo
    Public RET_Serie As Cdatos.bdcampo
    Public RET_Soleado As Cdatos.bdcampo
    Public RET_Nublado As Cdatos.bdcampo
    Public RET_Lluvia As Cdatos.bdcampo
    Public RET_Viento As Cdatos.bdcampo
    Public RET_Obsmet As Cdatos.bdcampo
    Public RET_Reco1 As Cdatos.bdcampo
    Public RET_Reco2 As Cdatos.bdcampo
    Public RET_Reco3 As Cdatos.bdcampo

    Public RET_Reco4 As Cdatos.bdcampo
    Public RET_Reco5 As Cdatos.bdcampo
    Public RET_Reco6 As Cdatos.bdcampo

    Public RET_Aplicador As Cdatos.bdcampo

    Public RET_HoraEdicion As Cdatos.bdcampo
    Public RET_FechaEdicion As Cdatos.bdcampo
    Public RET_NumMaquina As Cdatos.bdcampo

    Public RET_IdUsuarioLog As Cdatos.bdcampo
    Public RET_FechaLog As Cdatos.bdcampo
    Public RET_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "RecetasTec"
            NombreBd = "TecnicosNet"
            MiConexion = conexion


            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            RET_IdReceta = New Cdatos.bdcampo(CodigoEntidad & "IdReceta", Cdatos.TiposCampo.EnteroPositivo, 10, , True)
            RET_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 15)
            RET_Referencia = New Cdatos.bdcampo(CodigoEntidad & "Referencia", Cdatos.TiposCampo.Cadena, 50)
            RET_IdTecnico = New Cdatos.bdcampo(CodigoEntidad & "IdTecnico", Cdatos.TiposCampo.EnteroPositivo, 10)
            RET_IdFinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.EnteroPositivo, 10)
            RET_Numero = New Cdatos.bdcampo(CodigoEntidad & "Numero", Cdatos.TiposCampo.Cadena, 30)
            RET_HoraVisita = New Cdatos.bdcampo(CodigoEntidad & "HoraVisita", Cdatos.TiposCampo.Cadena, 8)
            RET_Serie = New Cdatos.bdcampo(CodigoEntidad & "Serie", Cdatos.TiposCampo.Cadena, 10)
            RET_Soleado = New Cdatos.bdcampo(CodigoEntidad & "Soleado", Cdatos.TiposCampo.Cadena, 1)
            RET_Nublado = New Cdatos.bdcampo(CodigoEntidad & "Nublado", Cdatos.TiposCampo.Cadena, 1)
            RET_Lluvia = New Cdatos.bdcampo(CodigoEntidad & "LLuvia", Cdatos.TiposCampo.Cadena, 1)
            RET_Viento = New Cdatos.bdcampo(CodigoEntidad & "Viento", Cdatos.TiposCampo.Cadena, 1)
            RET_Obsmet = New Cdatos.bdcampo(CodigoEntidad & "ObsMet", Cdatos.TiposCampo.Cadena, 50)
            RET_Reco1 = New Cdatos.bdcampo(CodigoEntidad & "Reco1", Cdatos.TiposCampo.Cadena, 150)
            RET_Reco2 = New Cdatos.bdcampo(CodigoEntidad & "Reco2", Cdatos.TiposCampo.Cadena, 150)
            RET_Reco3 = New Cdatos.bdcampo(CodigoEntidad & "Reco3", Cdatos.TiposCampo.Cadena, 150)

            RET_Reco4 = New Cdatos.bdcampo(CodigoEntidad & "Reco4", Cdatos.TiposCampo.Cadena, 150)
            RET_Reco5 = New Cdatos.bdcampo(CodigoEntidad & "Reco5", Cdatos.TiposCampo.Cadena, 150)
            RET_Reco6 = New Cdatos.bdcampo(CodigoEntidad & "Reco6", Cdatos.TiposCampo.Cadena, 150)


            RET_Aplicador = New Cdatos.bdcampo(CodigoEntidad & "Aplicador", Cdatos.TiposCampo.Cadena, 100)

            RET_HoraEdicion = New Cdatos.bdcampo(CodigoEntidad & "HoraEdicion", Cdatos.TiposCampo.Cadena, 8)
            RET_FechaEdicion = New Cdatos.bdcampo(CodigoEntidad & "FechaEdicion", Cdatos.TiposCampo.Fecha, 15)
            RET_NumMaquina = New Cdatos.bdcampo(CodigoEntidad & "NumMaquina", Cdatos.TiposCampo.EnteroPositivo, 10)


            RET_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            RET_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            RET_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error en la entidad ", "New", ex.Message)
        End Try


        'Descripción de la tabla para la gestion documental
        _DescripcionDocumental = "Recetas"



        'Dim Agricultor As New E_Agricultores(idUsuario, cn)
        'Dim sql As String = "Select RET_IdReceta as IdReceta,RET_Serie as Serie,RET_Numero as Numero, RET_Fecha as Fecha,Fin_Idagricultor as Codigo, FIN_Nombre as Finca, TEC_Nombre as Tecnico" & vbCrLf
        'sql = sql & " FROM RecetasTec" & vbCrLf
        'sql = sql & " LEFT JOIN fincas ON RET_IdFinca = FIN_IdFinca" & vbCrLf
        'sql = sql & " LEFT JOIN tecnicos ON RET_IdTecnico = TEC_IdTecnico" & vbCrLf



        '_btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = sql
        '_btBusca.CL_ControlAsociado = Nothing
        '_btBusca.CL_DevuelveCampo = "IdReceta"
        '_btBusca.CL_Entidad = Me
        '_btBusca.CL_Filtro = Nothing
        '_btBusca.Name = "BtBuscaRecetas"
        '_btBusca.CL_ch1000 = False
        '_btBusca.CL_BuscaAlb = True
        '_btBusca.CL_campocodigo = Agricultor.AGR_IdAgricultor
        '_btBusca.CL_camponombre = Agricultor.AGR_Nombre
        '_btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        '_btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


    End Sub

    Public Function LeerRecetaSerie(Serie As String, ByVal Receta As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.RET_Serie, "=", Serie)
        CONSULTA.WheCampo(Me.RET_Numero, "=", Receta.ToString)
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

    Public Function ExisteRecetaSerie(serie As String, ByVal Receta As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.RET_Serie, "=", serie)
        CONSULTA.WheCampo(Me.RET_Numero, "=", Receta.ToString)
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


    Public Function MaxIdSerie(serie As String, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(serie, vmax)
                existe = ExisteRecetaSerie(serie, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de recetas", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function




    'Private Sub E_Recetas_EliminaHijos() Handles Me.EliminaHijos


    '    If VaInt(Me.RET_IdReceta.Valor) > 0 Then

    '        'Dim RecetasCultivos As New E_RecetasCultivosTEC(Idusuario, cn)

    '        'Dim sql As String = "SELECT RCU_IdRecetaCul FROM RecetasCultivosTec WHERE RCU_IdReceta = " & Me.RET_IdReceta.Valor
    '        'Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
    '        'Dim idPedidoLinea As String = ""
    '        'Dim IdLinea As String = ""
    '        'For Each row As DataRow In dt.Rows
    '        '    IdLinea = (row("RCU_IdRecetaCul").ToString & "").Trim
    '        '    If RecetasCultivos.LeerId(IdLinea) Then
    '        '        RecetasCultivos.Eliminar()
    '        '    End If
    '        'Next




    '        'Dim RecetasTratamientos As New E_RecetasTratamientos(Idusuario, cn)

    '        'Dim sql2 As String = "SELECT RTR_IdRecetaTra FROM RecetasTratamientos WHERE RTR_IdReceta = " & Me.RET_IdReceta.Valor
    '        'Dim dt2 As DataTable = MiConexion.ConsultaSQL(sql2)
    '        'Dim idPedidoLinea2 As String = ""
    '        'Dim IdLinea2 As String = ""
    '        'For Each row2 As DataRow In dt2.Rows
    '        '    IdLinea2 = (row2("RTR_IdRecetaTra").ToString & "").Trim
    '        '    If RecetasTratamientos.LeerId(IdLinea2) Then
    '        '        RecetasTratamientos.Eliminar()
    '        '    End If
    '        'Next

    '        'TRATAMIENTOS
    '        Dim RecetasAplTrata As New E_RecetasAplTrata(Idusuario, cn)
    '        Dim Consulta As New Cdatos.E_select
    '        Consulta.SelCampo(RecetasAplTrata.RPT_IdRecetaAPL, "IdRecetaApl")
    '        Consulta.WheCampo(RecetasAplTrata.RPT_IdReceta, "=", Me.RET_IdReceta.Valor)
    '        Dim dt As DataTable = MiConexion.ConsultaSQL(Consulta.SQL)
    '        Dim IdLinea As String = ""

    '        If Not IsNothing(dt) And dt.Rows.Count > 0 Then

    '            For Each row As DataRow In dt.Rows

    '                IdLinea = (row("IdRecetaApl").ToString & "").Trim
    '                If RecetasAplTrata.LeerId(IdLinea) Then
    '                    RecetasAplTrata.Eliminar()
    '                End If

    '                Dim RecetasTratamientos As New E_RecetasTratamientos(Idusuario, cn)
    '                Dim Consulta2 As New Cdatos.E_select
    '                Consulta2.SelCampo(RecetasTratamientos.RTR_IdRecetaTra, "IdRecetaTra")
    '                Consulta2.WheCampo(RecetasTratamientos.RTR_IdRecetaApl, "=", IdLinea)

    '                Dim dt2 As DataTable = RecetasTratamientos.MiConexion.ConsultaSQL(Consulta2.SQL)

    '                If Not IsNothing(dt2) And dt2.Rows.Count > 0 Then

    '                    For Each rw In dt2.Rows

    '                        Dim IdL As String = (rw("IdRecetaTra").ToString & "").Trim

    '                        If RecetasTratamientos.LeerId(IdL) Then
    '                            RecetasTratamientos.Eliminar()
    '                        End If

    '                    Next

    '                End If


    '            Next


    '        End If




    '        'ABONOS
    '        Dim RecetasAplAbo As New E_RecetasAplAbono(Idusuario, cn)
    '        Dim Consulta3 As New Cdatos.E_select
    '        Consulta3.SelCampo(RecetasAplAbo.RPA_IdRecetaAPL, "IdRecetaApl")
    '        Consulta3.WheCampo(RecetasAplAbo.RPA_IdReceta, "=", Me.RET_IdReceta.Valor)
    '        Dim dt3 As DataTable = RecetasAplAbo.MiConexion.ConsultaSQL(Consulta3.SQL)
    '        Dim IdLinea3 As String = ""

    '        If Not IsNothing(dt3) And dt3.Rows.Count > 0 Then

    '            For Each row As DataRow In dt3.Rows

    '                IdLinea3 = (row("IdRecetaApl").ToString & "").Trim
    '                If RecetasAplAbo.LeerId(IdLinea3) Then
    '                    RecetasAplAbo.Eliminar()
    '                End If

    '                Dim RecetasAbono As New E_RecetasAbonados(Idusuario, cn)
    '                Dim Consulta2 As New Cdatos.E_select
    '                Consulta2.SelCampo(RecetasAbono.RTA_IdRecetaAbo, "IdRecetaTra")
    '                Consulta2.WheCampo(RecetasAbono.RTA_IdRecetaApl, "=", IdLinea3)

    '                Dim dt2 As DataTable = RecetasAbono.MiConexion.ConsultaSQL(Consulta2.SQL)

    '                If Not IsNothing(dt2) And dt2.Rows.Count > 0 Then

    '                    For Each rw In dt2.Rows

    '                        Dim IdL As String = (rw("IdRecetaTra").ToString & "").Trim

    '                        If RecetasAbono.LeerId(IdL) Then
    '                            RecetasAbono.Eliminar()
    '                        End If

    '                    Next

    '                End If
    '            Next

    '        End If
    '    End If


    'End Sub
End Class
