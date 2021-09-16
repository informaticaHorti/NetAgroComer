Public Class E_AlbEntrada_his
    Inherits Cdatos.Entidad


    Public AEH_id As Cdatos.bdcampo
    Public AEH_idalbaran As Cdatos.bdcampo
    Public AEH_idproveedor As Cdatos.bdcampo
    Public AEH_porcentaje As Cdatos.bdcampo
    Public AEH_idtarifa As Cdatos.bdcampo
    Public AEH_importegenero As Cdatos.bdcampo
    Public AEH_tgastosfac As Cdatos.bdcampo
    Public AEH_tgastoscom As Cdatos.bdcampo
    Public AEH_baseimponible As Cdatos.bdcampo
    Public AEH_tipoiva As Cdatos.bdcampo
    Public AEH_cuotaiva As Cdatos.bdcampo
    Public AEH_tiporet As Cdatos.bdcampo
    Public AEH_poret As Cdatos.bdcampo
    Public AEH_cuotaret As Cdatos.bdcampo
    Public AEH_totalalbaran As Cdatos.bdcampo
    Public AEH_idfactura As Cdatos.bdcampo
    Public AEH_nmed As Cdatos.bdcampo
    Public AEH_kilos As Cdatos.bdcampo
    Public AEH_idempresa As Cdatos.bdcampo
    Public AEH_idfacturafirme As Cdatos.bdcampo

    Public AEH_IdUsuarioLog As Cdatos.bdcampo
    Public AEH_FechaLog As Cdatos.bdcampo
    Public AEH_HoraLog As Cdatos.bdcampo


    'Public AEH_idfacturaNet As Cdatos.bdcampo
    'Public AEH_idasientoNet As Cdatos.bdcampo
    'Public AEH_idpuntoventa As Cdatos.bdcampo
    'Public AEH_idrecogida As Cdatos.bdcampo
    'Public AEH_campa As Cdatos.bdcampo
    'Public AEH_centro As Cdatos.bdcampo
    'Public AEH_albaran As Cdatos.bdcampo
    'Public AEH_fecha As Cdatos.bdcampo
    'Public AEH_idsubasta As Cdatos.bdcampo
    'Public AEH_importeenvase As Cdatos.bdcampo



    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try

            NombreTabla = "AlbEntrada_his"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AEH_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            AEH_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            AEH_idproveedor = New Cdatos.bdcampo(CodigoEntidad & "idproveedor", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEH_porcentaje = New Cdatos.bdcampo(CodigoEntidad & "porcentaje", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_idtarifa = New Cdatos.bdcampo(CodigoEntidad & "idtarifa", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEH_importegenero = New Cdatos.bdcampo(CodigoEntidad & "importegenero", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_tgastosfac = New Cdatos.bdcampo(CodigoEntidad & "tgastosfac", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_tgastoscom = New Cdatos.bdcampo(CodigoEntidad & "tgastoscom", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_baseimponible = New Cdatos.bdcampo(CodigoEntidad & "baseimponible", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_tipoiva = New Cdatos.bdcampo(CodigoEntidad & "tipoiva", Cdatos.TiposCampo.Importe, 5, 2)
            AEH_cuotaiva = New Cdatos.bdcampo(CodigoEntidad & "cuotaiva", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_tiporet = New Cdatos.bdcampo(CodigoEntidad & "tiporet", Cdatos.TiposCampo.Cadena, 1, 0)
            AEH_poret = New Cdatos.bdcampo(CodigoEntidad & "poret", Cdatos.TiposCampo.Importe, 5, 2)
            AEH_cuotaret = New Cdatos.bdcampo(CodigoEntidad & "cuotaret", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_totalalbaran = New Cdatos.bdcampo(CodigoEntidad & "totalalbaran", Cdatos.TiposCampo.Importe, 10, 2)
            AEH_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 6)
            AEH_nmed = New Cdatos.bdcampo(CodigoEntidad & "nmed", Cdatos.TiposCampo.EnteroPositivo, 1)
            AEH_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 8, 2)
            AEH_idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.EnteroPositivo, 2)
            AEH_idfacturafirme = New Cdatos.bdcampo(CodigoEntidad & "idfacturafirme", Cdatos.TiposCampo.EnteroPositivo, 6)

            AEH_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEH_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AEH_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim agricultores As New E_Agricultores(idUsuario, cn)
        Dim Albentrada As New E_AlbEntrada(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.AEH_id, "id")
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha", Me.AEH_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Campa, "Campa")
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran")
        consulta.SelCampo(Albentrada.AEN_IdPuntoVenta, "PV")
        consulta.SelCampo(Me.AEH_idproveedor, "Codigo")
        consulta.SelCampo(agricultores.AGR_Nombre, "Proveedor", Me.AEH_idproveedor, agricultores.AGR_IdAgricultor)
        ' en la consulta tiene que haber un campo que se llame codigo,y otro fecha

        _btBusca.Params("id", , -1)
        _btBusca.Params("idcentro", , -1)


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = agricultores.AGR_IdAgricultor
        _btBusca.CL_camponombre = agricultores.AGR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        _btBusca.CL_CampoOrden = "AGR_IdAgricultor"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = False

    End Sub



    Public Function LeerAlb(ByVal Campa As String, ByVal Nualb As String, ByVal nmed As String) As Integer
        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)



        CONSULTA.SelCampo(Me.AEH_id)
        CONSULTA.SelCampo(Albentrada.AEN_IdAlbaran, "idalbaran", Me.AEH_idalbaran)
        CONSULTA.WheCampo(Albentrada.AEN_Campa, "=", Campa)
        CONSULTA.WheCampo(Albentrada.AEN_Albaran, "=", Nualb)
        CONSULTA.WheCampo(Me.AEH_nmed, "=", nmed)

        Dim SQL As String = CONSULTA.SQL
        Dt = Me.MiConexion.ConsultaSQL(SQL)

        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                End If
            End If
        End If
        Return ret


    End Function


    Private Sub E_AlbEntrada_his_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from albentrada_hislineas where AHL_idalbhis=" + Me.AEH_id.Valor
        Me.MiConexion.OrdenSql(sql)


        sql = "Delete from albentrada_hisgastos where AHG_idalbhis=" + Me.AEH_id.Valor
        Me.MiConexion.OrdenSql(sql)



    End Sub



    Public Function AlbaranFacturado(ByVal idalbaran As String) As String
        Dim ret As String = ""
        Dim sql As String

        sql = "Select AEH_id as albaran, AEH_nmed as nmed from albentrada_his where AEH_idalbaran=" + idalbaran + " and (AEH_idfactura > 0 or AEH_idfacturaFirme >0)"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ret = ret + rw("albaran").ToString + "-" + rw("nmed").ToString + " / "
            Next

        End If
        Return ret
    End Function



    Public Function GastosFacturados(ByVal idalbaran As String) As String
        Dim ret As String = ""

        Dim sql As String

        sql = "Select AHG_importe as importe from albentrada_hisgastos where AHG_idalbaran=" + idalbaran + " and AHG_idfacturaproveedor > 0"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ret = ret + rw("importe").ToString & " / "
            Next

        End If
        Return ret


    End Function



End Class
