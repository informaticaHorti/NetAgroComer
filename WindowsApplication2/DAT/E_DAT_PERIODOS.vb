Public Class E_DAT_PERIODOS
    Inherits Cdatos.Entidad



    Public DPE_ID As Cdatos.bdcampo
    Public DPE_IDAGRICULTOR As Cdatos.bdcampo
    Public DPE_IDGENERO As Cdatos.bdcampo
    Public DPE_FECHAINICIO As Cdatos.bdcampo
    Public DPE_FECHAFIN As Cdatos.bdcampo



    Dim err As New Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DAT_PERIODOS"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            DPE_ID = New Cdatos.bdcampo(CodigoEntidad & "ID", Cdatos.TiposCampo.EnteroPositivo, 10, , True)
            DPE_IDAGRICULTOR = New Cdatos.bdcampo(CodigoEntidad & "IDAGRICULTOR", Cdatos.TiposCampo.Entero, 5)
            DPE_IDGENERO = New Cdatos.bdcampo(CodigoEntidad & "IDGENERO", Cdatos.TiposCampo.Entero, 5)
            DPE_FECHAINICIO = New Cdatos.bdcampo(CodigoEntidad & "FECHAINICIO", Cdatos.TiposCampo.Fecha, 10)
            DPE_FECHAFIN = New Cdatos.bdcampo(CodigoEntidad & "FECHAFIN", Cdatos.TiposCampo.Fecha, 10)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




        Dim Agricultores As New E_Agricultores(idUsuario, cn)
        Dim Generos As New E_Generos(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.DPE_ID, "ID")
        consulta.SelCampo(Me.DPE_IDAGRICULTOR, "CODAGR")
        consulta.SelCampo(Agricultores.AGR_Nombre, "AGRICULTOR", Me.DPE_IDAGRICULTOR)
        consulta.SelCampo(Me.DPE_IDGENERO, "CODGEN")
        consulta.SelCampo(Generos.GEN_NombreGenero, "GENERO", Me.DPE_IDGENERO)
        consulta.SelCampo(Me.DPE_FECHAINICIO, "FECHAINICIO")
        consulta.SelCampo(Me.DPE_FECHAFIN, "FECHAFIN")

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " ORDER BY DPE_FECHAINICIO DESC"





        _btBusca.Params("ID", , -1)
        _btBusca.Params("CODAGR", "CODAGR", 60)
        _btBusca.Params("AGRICULTOR", "AGRICULTOR", 200)
        _btBusca.Params("CODGEN", "CODGEN", 60)
        _btBusca.Params("GENERO", "GENERO", 150)
        _btBusca.Params("FECHAINICIO", "INICIO", 75)
        _btBusca.Params("FECHAFIN", "FIN", 75)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultores.AGR_Nombre
        _btBusca.CL_dfecha = Today.AddDays(-180).Date
        _btBusca.CL_hfecha = Today.Date

        '_btBusca.CL_CampoOrden = "Agricultor"
        '_btBusca.CL_CampoOrden = "Fecha DESC"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "ID"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaDATPeriodo"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = True


        _btBusca.ParamConsultaAlb(consulta, "AEN_Fecha DESC", Me.DPE_IDAGRICULTOR, Me.DPE_FECHAINICIO, Nothing)



    End Sub


    Public Function EsDATPeriodo(ByVal IdAgricultor As String, ByVal IdGenero As String, ByVal Fecha As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(IdAgricultor) = 0 Or VaInt(IdGenero) = 0 Or VaDate(Fecha) = VaDate("") Then

            Return bRes

        Else

            Dim sql As String = "SELECT DPE_ID FROM DAT_PERIODOS WHERE DPE_IDAGRICULTOR = " & IdAgricultor & " AND DPE_IDGENERO = " & IdGenero & " AND '" & Fecha & "' >= DPE_FECHAINICIO AND '" & Fecha & "' <= 'DPE_FECHAFIN'"
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then
                    bRes = True
                End If

            End If


        End If



        Return bRes

    End Function
    


    'Public Overrides Function FechaLogToString(ByVal Fecha As Date) As String

    '    Return Fecha.ToString("yyyyMMdd")

    'End Function



End Class
