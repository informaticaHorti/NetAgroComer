Public Class E_Empresas
    Inherits Cdatos.Entidad

    Public EMP_Idempresa As Cdatos.bdcampo
    Public EMP_Nombre As Cdatos.bdcampo
    Public EMP_Domicilio As Cdatos.bdcampo
    Public EMP_CIF As Cdatos.bdcampo

    Public EMP_Telefono As Cdatos.bdcampo

    Public EMP_IdUsuarioLog As Cdatos.bdcampo
    Public EMP_FechaLog As Cdatos.bdcampo
    Public EMP_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Empresas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            Emp_Idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.EnteroPositivo, 2, 0, True)
            EMP_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            EMP_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 200)
            EMP_CIF = New Cdatos.bdcampo(CodigoEntidad & "CIF", Cdatos.TiposCampo.Cadena, 15)

            EMP_Telefono = New Cdatos.bdcampo(CodigoEntidad & "Telefono", Cdatos.TiposCampo.Cadena, 15)

            EMP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            EMP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            EMP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select EMP_Idempresa as Id, EMP_Nombre as Nombre from Empresas"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaEmpresas"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmEmpresas"

       

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select EMP_idempresa as Idempresa,EMP_Nombre as  Nombre from Empresas order by EMP_idempresa")


        Return dt
    End Function

End Class
