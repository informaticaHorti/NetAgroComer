Public Class E_ValoracionSemanal
    Inherits Cdatos.Entidad


    Public VSC_IdValora As Cdatos.bdcampo
    Public VSC_IdEjercicio As Cdatos.bdcampo
    Public VSC_Valoracion As Cdatos.bdcampo
    Public VSC_FechaValoracion As Cdatos.bdcampo
    Public VSC_TipoCS As Cdatos.bdcampo
    Public VSC_IdAgricultorDesde As Cdatos.bdcampo
    Public VSC_IdAgricultorHasta As Cdatos.bdcampo
    Public VSC_IdSemana As Cdatos.bdcampo
    Public VSC_DFecha As Cdatos.bdcampo
    Public VSC_AFecha As Cdatos.bdcampo
    Public VSC_idgenero As Cdatos.bdcampo
    Public VSC_idcentro As Cdatos.bdcampo

    Public VSC_IdUsuarioLog As Cdatos.bdcampo
    Public VSC_FechaLog As Cdatos.bdcampo
    Public VSC_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValoracionSemanal"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VSC_IdValora = New Cdatos.bdcampo(CodigoEntidad & "IdValora", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            VSC_IdEjercicio = New Cdatos.bdcampo(CodigoEntidad & "IdEjercicio", Cdatos.TiposCampo.Entero, 2)
            VSC_Valoracion = New Cdatos.bdcampo(CodigoEntidad & "Valoracion", Cdatos.TiposCampo.Entero, 10)
            VSC_FechaValoracion = New Cdatos.bdcampo(CodigoEntidad & "FechaValoracion", Cdatos.TiposCampo.Fecha, 10)
            VSC_TipoCS = New Cdatos.bdcampo(CodigoEntidad & "TipoCS", Cdatos.TiposCampo.Cadena, 1)
            VSC_IdAgricultorDesde = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultorDesde", Cdatos.TiposCampo.Entero, 6)
            VSC_IdAgricultorHasta = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultorHasta", Cdatos.TiposCampo.Entero, 6)
            VSC_IdSemana = New Cdatos.bdcampo(CodigoEntidad & "IdSemana", Cdatos.TiposCampo.CadenaNumero, 6, 0)
            VSC_DFecha = New Cdatos.bdcampo(CodigoEntidad & "DFecha", Cdatos.TiposCampo.Fecha, 10)
            VSC_AFecha = New Cdatos.bdcampo(CodigoEntidad & "AFecha", Cdatos.TiposCampo.Fecha, 10)
            VSC_idgenero = New Cdatos.bdcampo(CodigoEntidad & "Idgenero", Cdatos.TiposCampo.EnteroPositivo, 6, 0)
            VSC_idcentro = New Cdatos.bdcampo(CodigoEntidad & "Idcentro", Cdatos.TiposCampo.EnteroPositivo, 3, 0)

            VSC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VSC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VSC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.VSC_Valoracion)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try



        Dim sql As String = "SELECT VSC_IdValora as IdValora, VSC_Valoracion as Valoracion, VSC_TipoCS as Tipo, VSC_FechaValoracion as FechaValoracion," & vbCrLf
        sql = sql & " VSC_DFecha as Desde, VSC_AFecha as Hasta, VSC_IdAgricultorDesde as AgrDesde, VSC_IdAgricultorHasta as AgrHasta" & vbCrLf
        sql = sql & " FROM ValoracionSemanal" & vbCrLf
        sql = sql & " WHERE VSC_IdEjercicio = " & MiMaletin.Ejercicio.ToString & vbCrLf
        sql = sql & " ORDER BY VSC_FechaValoracion DESC" & vbCrLf


        Dim Agricultores As New E_Agricultores(idUsuario, cn)

        _btBusca.Params("IdValora", , -1)
        '_btBusca.Params("Codigo", , -1)

        _btBusca.CL_BuscaAlb = False ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultores.AGR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        '_btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Valoracion"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaValora"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub


    Public Function MaxIdCampa(ByVal Campa As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Campa.ToString, vmax)
                existe = LeerValoracion(Campa, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de Valoracion S/Clasif", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Public Function LeerValoracion(ByVal IdEjercicio As Integer, ByVal Valoracion As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VSC_IdEjercicio, "=", IdEjercicio.ToString)
        CONSULTA.WheCampo(Me.VSC_Valoracion, "=", Valoracion.ToString)

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


    Public Function ExisteValoracion(ByVal IdEjercicio As Integer, ByVal Valoracion As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.VSC_IdEjercicio, "=", IdEjercicio.ToString)
        CONSULTA.WheCampo(Me.VSC_Valoracion, "=", Valoracion.ToString)

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


    Private Sub E_ValoracionSemanal_EliminaHijos() Handles Me.EliminaHijos

        Dim IdValoracion As String = Me.VSC_IdValora.Valor

        If VaInt(IdValoracion) > 0 Then

            Dim ValoracionSemanal_Lineas As New E_ValoracionSemanal_Lineas(Idusuario, cn)

            Dim sql As String = "SELECT VSL_IdLinea FROM ValoracionSemanal_Lineas WHERE VSL_IdValora = " & Me.VSC_IdValora.Valor
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    Dim IdLinea As String = (row("VSL_IdLinea").ToString & "").Trim
                    If ValoracionSemanal_Lineas.LeerId(IdLinea) Then
                        ValoracionSemanal_Lineas.Eliminar()
                    End If

                Next
            End If


            'Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)

            'sql = "SELECT AEL_IdLinea FROM AlbEntrada_Lineas WHERE AEL_IdValoracion = " & IdValoracion
            'dt = MiConexion.ConsultaSQL(sql)
            'If Not IsNothing(dt) Then
            '    For Each row As DataRow In dt.Rows

            '        Dim IdLinea As String = (row("AEL_IdLinea").ToString & "").Trim
            '        If AlbEntrada_Lineas.LeerId(IdLinea) Then
            '            AlbEntrada_Lineas.AEL_IdValoracion.Valor = "0"
            '            AlbEntrada_Lineas.AEL_FechaValoracion.Valor = VaDate("")
            '            AlbEntrada_Lineas.Actualizar()
            '        End If

            '    Next
            'End If


        End If

    End Sub
End Class
