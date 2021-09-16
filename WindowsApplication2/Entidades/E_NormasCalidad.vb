Public Class E_NormasCalidad
    Inherits Cdatos.Entidad

    Public NOR_IdNorma As Cdatos.bdcampo
    Public NOR_Nombre As Cdatos.bdcampo
    Public NOR_Controlado As Cdatos.bdcampo

    Public NOR_IdUsuarioLog As Cdatos.bdcampo
    Public NOR_FechaLog As Cdatos.bdcampo
    Public NOR_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "NormasCalidad"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            NOR_IdNorma = New Cdatos.bdcampo(CodigoEntidad & "IdNorma", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            NOR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            NOR_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)

            NOR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            NOR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            NOR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select NOR_IdNorma as Codigo, NOR_Nombre as Nombre from NormasCalidad"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Codigo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaNorma"
        _btBusca.CL_ch1000 = False

    End Sub


    Public Function Tabla() As DataTable

        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select NOR_IdNorma as IdNorma, NOR_Nombre as  Nombre from NormasCalidad order by NOR_IdNorma")
        Dim row As DataRow = dt.NewRow()
        row("IdNorma") = 0
        row("Nombre") = "General"
        dt.Rows.Add(row)


        Return dt

    End Function


End Class
