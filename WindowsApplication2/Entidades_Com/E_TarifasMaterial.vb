Public Class E_TarifasMaterial
    Inherits Cdatos.Entidad


    Public TMA_idacreedor As Cdatos.bdcampo
    Public TMA_fechatarifa As Cdatos.bdcampo

    Public TMA_IdUsuarioLog As Cdatos.bdcampo
    Public TMA_FechaLog As Cdatos.bdcampo
    Public TMA_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "tarifasmaterial"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            TMA_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            TMA_fechatarifa = New Cdatos.bdcampo(CodigoEntidad & "fechatarifa", Cdatos.TiposCampo.Fecha, 10)

            TMA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TMA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TMA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Acreedores As New E_Acreedores(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.TMA_fechatarifa, "Fecha")
        consulta.SelCampo(Me.TMA_idacreedor, "Codigo")
        consulta.SelCampo(Acreedores.ACR_Nombre, "Acreedor", Me.TMA_idacreedor)
 

        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Codigo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTarifaMaterial"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = False ' busqueda por codigo
        _btBusca.CL_campocodigo = Nothing
        _btBusca.CL_camponombre = Nothing



    End Sub



    Private Sub E_tarifasmaterial_EliminaHijos() Handles Me.EliminaHijos

       
        Dim sql As String = "Delete from tarifasmateriallineas where TML_idacreedor=" + Me.TMA_idacreedor.Valor
        Me.MiConexion.OrdenSql(sql)


    End Sub



End Class
