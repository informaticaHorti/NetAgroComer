Public Class E_Conceptos346

    Inherits Cdatos.Entidad

    Public C46_idconcepto As Cdatos.bdcampo
    Public C46_nombre As Cdatos.bdcampo
    Public C46_clave As Cdatos.bdcampo
    Public C46_tipo As Cdatos.bdcampo

    Public C46_IdUsuarioLog As Cdatos.bdcampo
    Public C46_FechaLog As Cdatos.bdcampo
    Public C46_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Conceptos346"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            C46_idconcepto = New Cdatos.bdcampo(CodigoEntidad & "idconcepto", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            C46_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            C46_clave = New Cdatos.bdcampo(CodigoEntidad & "clave", Cdatos.TiposCampo.Cadena, 1)
            C46_tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)

            C46_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            C46_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            C46_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select C46_Idconcepto as Id, C46_Nombre as Nombre from Conceptos346"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAlcance"
        _btBusca.CL_ch1000 = False


    End Sub

End Class
