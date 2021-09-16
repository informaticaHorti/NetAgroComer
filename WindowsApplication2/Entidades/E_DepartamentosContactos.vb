Public Class E_DepartamentosContactos
    Inherits Cdatos.Entidad

    Public DPT_IdDepartamento As Cdatos.bdcampo
    Public DPT_Nombre As Cdatos.bdcampo

    Public DPT_IdUsuarioLog As Cdatos.bdcampo
    Public DPT_FechaLog As Cdatos.bdcampo
    Public DPT_HoraLog As Cdatos.bdcampo

    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Vendedor As New E_Vendedores(idUsuario, cn)
        Try

            NombreTabla = "DepartamentosContactos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DPT_IdDepartamento = New Cdatos.bdcampo(CodigoEntidad & "IdDepartamento", Cdatos.TiposCampo.Entero, 5, 0, True)
            DPT_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)

            DPT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DPT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DPT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select DPT_IdDepartamento as IdDepartamento, DPT_Nombre as Nombre from DepartamentosContactos"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdDepartamento"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaDepartamentos"
        _btBusca.CL_ch1000 = False

        _btBusca.Params("IdDepartamento", "Id", 10)
        _btBusca.cl_formu = "FrmDepartamentos"

    End Sub



End Class
