Public Class E_ProgramaCalidadTecnicos
    Inherits Cdatos.Entidad

    Public PCT_Idprograma As Cdatos.bdcampo
    Public PCT_Nombre As Cdatos.bdcampo
    Public PCT_Controlado As Cdatos.bdcampo

    Public PCT_IdUsuarioLog As Cdatos.bdcampo
    Public PCT_FechaLog As Cdatos.bdcampo
    Public PCT_HoraLog As Cdatos.bdcampo


    'Public Enum ProgramasCalidad
    '    NoControlado = 3
    '    NoControladoLimpio = 103
    'End Enum


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ProgramaCalidadTecnicos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PCT_Idprograma = New Cdatos.bdcampo(CodigoEntidad & "Idprograma", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            PCT_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            PCT_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)

            PCT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PCT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PCT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select PCT_IdPrograma as Codigo, PCT_Nombre as Nombre from ProgramaCalidadTecnicos"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Codigo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaPrograma"
        _btBusca.CL_ch1000 = False

    End Sub
    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select PCT_idprograma as IdPrograma,PCT_Nombre as  Nombre from ProgramaCalidadTecnicos order by PCT_idprograma")
        Dim row As DataRow = dt.NewRow()
        row("IdPrograma") = 0
        row("Nombre") = "General"
        dt.Rows.Add(row)


        Return dt
    End Function


End Class
