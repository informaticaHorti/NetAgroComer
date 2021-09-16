Public Class E_TiposdeCategoria
    Inherits Cdatos.Entidad

    Public TCA_Id As Cdatos.bdcampo
    Public TCA_Nombre As Cdatos.bdcampo
    Public TCA_Tipo As Cdatos.bdcampo
    Public TCA_Abreviatura As Cdatos.bdcampo

    Public TCA_IdUsuarioLog As Cdatos.bdcampo
    Public TCA_FechaLog As Cdatos.bdcampo
    Public TCA_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TiposdeCategorias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TCA_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            TCA_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 25)
            TCA_Tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)
            TCA_Abreviatura = New Cdatos.bdcampo(CodigoEntidad & "Abreviatura", Cdatos.TiposCampo.Cadena, 5)

            TCA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TCA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TCA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TCA_Id as Id, TCA_Nombre as Nombre from tiposdecategorias"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTiposdeCategorias"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTiposCat"
        _
    End Sub



    Public Function Tabla() As DataTable

        Dim sql As String = "SELECT TCA_Id as Id, TCA_Nombre as TipoCat, TCA_Abreviatura as Abrev FROM TiposDeCategorias ORDER BY TCA_Id"
        Return MiConexion.ConsultaSQL(sql)

    End Function



End Class
