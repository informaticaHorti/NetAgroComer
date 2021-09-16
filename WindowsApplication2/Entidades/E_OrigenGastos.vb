Public Class E_OrigenGastos
    Inherits Cdatos.Entidad

    Public ORG_Idorigen As Cdatos.bdcampo
    Public ORG_Nombre As Cdatos.bdcampo
    Public ORG_tipo As Cdatos.bdcampo
    Public ORG_cuenta As Cdatos.bdcampo

    Public ORG_IdUsuarioLog As Cdatos.bdcampo
    Public ORG_FechaLog As Cdatos.bdcampo
    Public ORG_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "origengastos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ORG_Idorigen = New Cdatos.bdcampo(CodigoEntidad & "Idorigen", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            ORG_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            ORG_tipo = New Cdatos.bdcampo(CodigoEntidad & "Tipo", Cdatos.TiposCampo.Cadena, 2)
            ORG_cuenta = New Cdatos.bdcampo(CodigoEntidad & "Cuenta", Cdatos.TiposCampo.Cuenta, 15)

            ORG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ORG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ORG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select ORG_Idorigen as IdOrigen, ORG_Nombre as Nombre from origengastos"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idorigen"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaOrigenGastos"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmOrigenGastos"

    End Sub

End Class
