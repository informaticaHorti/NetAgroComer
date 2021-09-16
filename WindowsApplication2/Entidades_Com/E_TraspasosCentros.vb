Public Class E_TraspasosCentros
    Inherits Cdatos.Entidad

    Public TCE_IdTrapaso As Cdatos.bdcampo
    Public TCE_Numero As Cdatos.bdcampo
    Public TCE_Ejercicio As Cdatos.bdcampo
    Public TCE_Fecha As Cdatos.bdcampo
    Public TCE_IdCentroOrigen As Cdatos.bdcampo
    Public TCE_IdCentroDestino As Cdatos.bdcampo
    Public TCE_IdTransportista As Cdatos.bdcampo
    Public TCE_Matricula As Cdatos.bdcampo
    Public TCE_Observaciones As Cdatos.bdcampo
    Public TCE_FechaCarga As Cdatos.bdcampo
    Public TCE_HoraCarga As Cdatos.bdcampo
    Public TCE_FechaDescarga As Cdatos.bdcampo
    Public TCE_HoraDescarga As Cdatos.bdcampo
    Public TCE_Tractora As Cdatos.bdcampo
    Public TCE_IdValeOrigen As Cdatos.bdcampo
    Public TCE_IdValeDestino As Cdatos.bdcampo

    Public TCE_IdSemana As Cdatos.bdcampo


    Public TCE_IdUsuarioLog As Cdatos.bdcampo
    Public TCE_FechaLog As Cdatos.bdcampo
    Public TCE_HoraLog As Cdatos.bdcampo


    



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TraspasosCentros"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TCE_IdTrapaso = New Cdatos.bdcampo(CodigoEntidad & "IdTraspaso", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            TCE_Numero = New Cdatos.bdcampo(CodigoEntidad & "Numero", Cdatos.TiposCampo.EnteroPositivo, 8)
            TCE_Ejercicio = New Cdatos.bdcampo(CodigoEntidad & "Ejercicio", Cdatos.TiposCampo.EnteroPositivo, 2)
            TCE_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            TCE_IdCentroOrigen = New Cdatos.bdcampo(CodigoEntidad & "IdCentroOrigen", Cdatos.TiposCampo.EnteroPositivo, 3)
            TCE_IdCentroDestino = New Cdatos.bdcampo(CodigoEntidad & "IdCentroDestino", Cdatos.TiposCampo.EnteroPositivo, 3)
            TCE_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            TCE_Matricula = New Cdatos.bdcampo(CodigoEntidad & "Matricula", Cdatos.TiposCampo.Cadena, 20)
            TCE_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 50)
            TCE_FechaCarga = New Cdatos.bdcampo(CodigoEntidad & "FechaCarga", Cdatos.TiposCampo.Fecha, 10)
            TCE_HoraCarga = New Cdatos.bdcampo(CodigoEntidad & "HoraCarga", Cdatos.TiposCampo.Cadena, 10)
            TCE_FechaDescarga = New Cdatos.bdcampo(CodigoEntidad & "FechaDescarga", Cdatos.TiposCampo.Fecha, 10)
            TCE_HoraDescarga = New Cdatos.bdcampo(CodigoEntidad & "HoraDescarga", Cdatos.TiposCampo.Cadena, 10)
            TCE_Tractora = New Cdatos.bdcampo(CodigoEntidad & "Tractora", Cdatos.TiposCampo.Cadena, 20)
            TCE_IdValeOrigen = New Cdatos.bdcampo(CodigoEntidad & "IdValeOrigen", Cdatos.TiposCampo.Entero, 8)
            TCE_IdValeDestino = New Cdatos.bdcampo(CodigoEntidad & "IdValeDestino", Cdatos.TiposCampo.Entero, 8)
            TCE_IdSemana = New Cdatos.bdcampo(CodigoEntidad & "IdSemana", Cdatos.TiposCampo.CadenaNumero, 6)

            TCE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TCE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TCE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()



            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.TCE_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Acreedores As New E_Acreedores(idUsuario, cn)



        Dim sql As String = "SELECT TCE_IdTraspaso as IdTraspaso, TCE_Numero as Traspaso, TCE_Fecha as Fecha, " & vbCrLf
        sql = sql & " C1.Nombre as Origen, C2.Nombre as Destino" & vbCrLf
        sql = sql & " FROM TraspasosCentros" & vbCrLf
        sql = sql & " LEFT JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.puntoventa C1 ON C1.Idpuntoventa = TCE_IdCentroOrigen" & vbCrLf
        sql = sql & " LEFT JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.puntoventa C2 ON C2.Idpuntoventa = TCE_IdCentroDestino" & vbCrLf
        sql = sql & " WHERE TCE_Ejercicio = " & MiMaletin.Ejercicio.ToString & vbCrLf





        _btBusca.Params("IdTraspaso", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Acreedores.ACR_Codigo
        _btBusca.CL_camponombre = Acreedores.ACR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio
        '_btBusca.CL_Filtro = "PED_IdCentro = " & MiMaletin.IdCentro.ToString

        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdTraspaso"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTraspaso"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing

    End Sub

    Public Function LeerTraspaso(ByVal Campa As Integer, ByVal Numero As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.TCE_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.TCE_Numero, "=", Numero.ToString)

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


    Public Function ExistePedido(ByVal Campa As Integer, ByVal Numpedido As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.TCE_Ejercicio, "=", Campa.ToString)
        CONSULTA.WheCampo(Me.TCE_Numero, "=", Numpedido.ToString)

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
                existe = ExistePedido(Campa, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de pedidos", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Private Sub E_TraspasosCentros_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos

        Dim IdTraspaso As String = Me.TCE_IdTrapaso.Valor
        Dim TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)

        If VaInt(IdTraspaso) > 0 Then

            Dim sql As String = "SELECT TLI_IdLinea as IdLinea FROM TraspasosCentros_Lineas WHERE TLI_IdTraspaso = " & IdTraspaso
            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)

            For Each row As DataRow In dt.Rows
                Dim IdLinea As String = (row("IdLInea").ToString & "").Trim
                If TraspasosCentros_Lineas.LeerId(IdLinea) Then
                    TraspasosCentros_Lineas.ActualizaCodigos(False)
                End If
            Next

        End If

    End Sub


    Public Overrides Function Eliminar() As Boolean

        Dim TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
        Dim IdTraspaso As String = Me.TCE_IdTrapaso.Valor
        Dim IdValeOrigen As String = Me.TCE_IdValeOrigen.Valor
        Dim IdValeDestino As String = Me.TCE_IdValeDestino.Valor


        If VaInt(IdTraspaso) > 0 Then

            Dim sql As String = "SELECT TLI_IdLinea as IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo FROM TraspasosCentros_Lineas WHERE TLI_IdTraspaso = " & IdTraspaso
            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)

            For Each row As DataRow In dt.Rows

                'Borramos los hijos
                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                If TraspasosCentros_Lineas.LeerId(IdLinea) Then
                    TraspasosCentros_Lineas.Eliminar()
                End If

            Next

            If VaInt(IdValeOrigen) > 0 Then

                sql = "SELECT VEV_IdVale FROM ValeEnvases WHERE VEV_IdVale = " & IdValeOrigen
                Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

                Dim dtO As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dtO) Then
                    If dtO.Rows.Count > 0 Then
                        Dim IdVale As String = (dtO.Rows(0)("VEV_IdVale").ToString & "").Trim
                        If ValeEnvases.LeerId(IdVale) Then
                            ValeEnvases.Eliminar()
                        End If
                    End If
                End If

            End If


            If VaInt(IdValeDestino) > 0 Then

                sql = "SELECT VEV_IdVale FROM ValeEnvases WHERE VEV_IdVale = " & IdValeDestino
                Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

                Dim dtO As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dtO) Then
                    If dtO.Rows.Count > 0 Then
                        Dim IdVale As String = (dtO.Rows(0)("VEV_IdVale").ToString & "").Trim
                        If ValeEnvases.LeerId(IdVale) Then
                            ValeEnvases.Eliminar()
                        End If
                    End If
                End If

            End If

        End If



        Return MyBase.Eliminar()

    End Function


    'Private Sub E_TraspasosCentros_EliminaHijos() Handles Me.EliminaHijos


    'Dim TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
    'Dim IdTraspaso As String = Me.TCE_IdTrapaso.Valor


    'If VaInt(IdTraspaso) > 0 Then

    '    Dim sql As String = "SELECT TLI_IdLinea as IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo FROM TraspasosCentros_Lineas WHERE TLI_IdTraspaso = " & IdTraspaso
    '    Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)

    '    For Each row As DataRow In dt.Rows

    '        'Borramos los hijos
    '        Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
    '        If TraspasosCentros_Lineas.LeerId(IdLinea) Then
    '            TraspasosCentros_Lineas.ActualizaCodigos(True)
    '            TraspasosCentros_Lineas.Eliminar()
    '        End If

    '    Next


    'End If

    'End Sub
End Class
