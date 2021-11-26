Public Class E_FianzasEnvases
    Inherits Cdatos.Entidad

    Public FZE_Id As Cdatos.bdcampo
    Public FZE_IdCliente As Cdatos.bdcampo
    Public FZE_IdDomicilio As Cdatos.bdcampo
    Public FZE_TipoFacturacion As Cdatos.bdcampo
    Public FZE_IdSubFamiliaEnvase As Cdatos.bdcampo

    Public FZE_IdUsuarioLog As Cdatos.bdcampo
    Public FZE_FechaLog As Cdatos.bdcampo
    Public FZE_HoraLog As Cdatos.bdcampo



    Public Class TipoFacturacion

        Public Const FacturarEnAlbaran As String = "A"
        Public Const FacturarAparte As String = "B"
        Public Const NoFacturar As String = "C"

    End Class


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FianzasEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            FZE_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            FZE_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.Entero, 5)
            FZE_IdDomicilio = New Cdatos.bdcampo(CodigoEntidad & "IdDomicilio", Cdatos.TiposCampo.Entero, 10)
            FZE_IdSubFamiliaEnvase = New Cdatos.bdcampo(CodigoEntidad & "IdSubFamiliaEnvase", Cdatos.TiposCampo.Entero, 4)
            FZE_TipoFacturacion = New Cdatos.bdcampo(CodigoEntidad & "TipoFacturacion", Cdatos.TiposCampo.Cadena, 1)

            FZE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FZE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FZE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        '_btBusca.CL_CampoOrden = "Nombre"
        '_btBusca.CL_ConsultaSql = "Select FZE_Idzona as IdZona, FZE_Nombre as Nombre from zonas"
        '_btBusca.CL_ControlAsociado = Nothing
        '_btBusca.CL_DevuelveCampo = "Idzona"
        '_btBusca.CL_Entidad = Me
        '_btBusca.CL_Filtro = Nothing
        '_btBusca.Name = "BtBuscaZonas"
        '_btBusca.cl_formu = "FrmZonas"
        '_btBusca.CL_ch1000 = False
        '_btBusca.cl_formu = "FrmZonas"


    End Sub


    Public Shared Function TipoEnvase(ByVal IdCliente As String, ByVal IdDomicilio As String, ByVal IdSubFamilia As String) As String

        Dim res As String = ""


        Dim sql As String = "SELECT FZE_TipoFacturacion as Tipo FROM FianzasEnvases WHERE FZE_IdCliente = " & IdCliente & " AND COALESCE(FZE_IdDomicilio,0) = " & VaInt(IdDomicilio).ToString & " AND FZE_IdSubFamiliaEnvase = " & IdSubFamilia & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf & vbCrLf
        sql = sql & "SELECT FZE_TipoFacturacion as Tipo FROM FianzasEnvases WHERE FZE_IdCliente = " & IdCliente & " AND COALESCE(FZE_IdDomicilio,0) = 0 AND FZE_IdSubFamiliaEnvase = " & IdSubFamilia & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf & vbCrLf
        sql = sql & " SELECT CASE CLI_FacturaEnvaseComercio WHEN 'S' THEN '" & TipoFacturacion.FacturarEnAlbaran & "' ELSE '" & TipoFacturacion.NoFacturar & "' END as Tipo FROM Clientes WHERE CLI_IdCliente = " & IdCliente & vbCrLf

        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                res = (row("Tipo").ToString & "").Trim

            End If
        End If



        Return res

    End Function

End Class
