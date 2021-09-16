Public Class E_Subfamilias
    Inherits Cdatos.Entidad

    Public SFA_id As Cdatos.bdcampo
    Public SFA_idfamilia As Cdatos.bdcampo
    Public SFA_nombre As Cdatos.bdcampo
    Public SFA_codigo As Cdatos.bdcampo

    Public SFA_IdUsuarioLog As Cdatos.bdcampo
    Public SFA_FechaLog As Cdatos.bdcampo
    Public SFA_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Subfamilias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            SFA_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 4, 0, True)
            SFA_idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 4)
            SFA_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 40)
            SFA_codigo = New Cdatos.bdcampo(CodigoEntidad & "codigo", Cdatos.TiposCampo.Entero, 4)

            SFA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            SFA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            SFA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim FamiliasGeneros As New E_FamiliasGeneros(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.SFA_id, "Id")
        consulta.SelCampo(Me.SFA_nombre, "Nombre")
        consulta.SelCampo(Me.SFA_idfamilia, "IdFamilia")
        consulta.SelCampo(FamiliasGeneros.FAG_nombre, "Familia", Me.SFA_idfamilia, FamiliasGeneros.FAG_idfamilia)
        consulta.SelCampo(Me.SFA_codigo, "Codigo")

        _btBusca.Params("IdFamilia", , -1)


        _btBusca.CL_CampoOrden = "Nombre"
        '_btBusca.CL_ConsultaSql = "Select SFA_id as Id, SFA_Nombre as Nombre, SFA_idfamilia as IdFamilia, SFA_codigo as Codigo from Subfamilias"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaSubFamilia"
        _btBusca.CL_ch1000 = False

    End Sub

    Public Function LeerSubfam(ByVal IdFamilia As Integer, ByVal Codigo As Integer) As Integer
        Dim ret As Integer
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select SFA_id as Id from subfamilias where SFA_idfamilia=" & IdFamilia.ToString & " and SFA_codigo=" & Codigo.ToString
        dt = MiConexion.ConsultaSQL(Sql)
        If dt.Rows.Count > 0 Then
            ret = VaInt(dt.Rows(0)(0))
        End If
        Return ret

    End Function
    Private Sub E_SubFamilias_EliminaHijos() Handles Me.EliminaHijos
        'Dim sql As String
        'sql = "Delete from subfamcatent where idsubfamilia=" + id.Valor
        'Me.MiConexion.OrdenSql(sql)

        'sql = "Delete from subfamcatsal where idsubfamilia=" + id.Valor
        'Me.MiConexion.OrdenSql(sql)


    End Sub


End Class
