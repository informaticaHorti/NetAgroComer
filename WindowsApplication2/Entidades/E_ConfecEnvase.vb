Public Class E_ConfecEnvase
    Inherits Cdatos.Entidad


    Public CEV_Idconfec As Cdatos.bdcampo
    Public CEV_Nombre As Cdatos.bdcampo
    Public CEV_Abreviatura As Cdatos.bdcampo
    Public CEV_TotalTara As Cdatos.bdcampo
    Public CEV_TotalCoste As Cdatos.bdcampo
    Public CEV_IdEnvase As Cdatos.bdcampo
    Public CEV_IncrementoTara As Cdatos.bdcampo

    Public CEV_IdUsuarioLog As Cdatos.bdcampo
    Public CEV_FechaLog As Cdatos.bdcampo
    Public CEV_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()

        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "confecenvase"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CEV_Idconfec = New Cdatos.bdcampo(CodigoEntidad & "idconfec", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            CEV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            CEV_Abreviatura = New Cdatos.bdcampo(CodigoEntidad & "abreviatura", Cdatos.TiposCampo.Cadena, 25)
            CEV_TotalTara = New Cdatos.bdcampo(CodigoEntidad & "totaltara", Cdatos.TiposCampo.Importe, 20, 4)
            CEV_TotalCoste = New Cdatos.bdcampo(CodigoEntidad & "totalcoste", Cdatos.TiposCampo.Importe, 20, 4)
            CEV_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            CEV_IncrementoTara = New Cdatos.bdcampo(CodigoEntidad & "incrementotara", Cdatos.TiposCampo.Importe, 8, 4)

            CEV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CEV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CEV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select CEV_Idconfec as IdConfec, CEV_Nombre as Nombre from confecenvase"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdConfec"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaConfecEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmConfEnvases"

    End Sub



    Private Sub E_ConfecEnvase_EliminaHijos() Handles Me.Eliminahijos
        Dim sql As String
        sql = "Delete from confecenvaselineas where CEL__idconfec=" + CEV_Idconfec.Valor
        Me.MiConexion.OrdenSql(sql)


    End Sub


End Class
