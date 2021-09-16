Public Class E_Vendedores
    Inherits Cdatos.Entidad

    Public VED_idcomercial As Cdatos.bdcampo
    Public VED_nombre As Cdatos.bdcampo
    Public VED_telefono As Cdatos.bdcampo

    Public VED_IdUsuarioLog As Cdatos.bdcampo
    Public VED_FechaLog As Cdatos.bdcampo
    Public VED_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Vendedores"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VED_idcomercial = New Cdatos.bdcampo(CodigoEntidad & "idcomercial", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            VED_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 40)
            VED_telefono = New Cdatos.bdcampo(CodigoEntidad & "telefono", Cdatos.TiposCampo.Cadena, 25)

            VED_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VED_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VED_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select VED_Idcomercial as IdComercial, VED_Nombre as Nombre from vendedores"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idcomercial"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaVendedor"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmVendedor"

    End Sub

End Class
