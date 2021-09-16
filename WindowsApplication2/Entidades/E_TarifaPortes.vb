Public Class E_TarifaPortes

    Inherits Cdatos.Entidad

    Public TPV_Id As Cdatos.bdcampo
    Public TPV_Nombre As Cdatos.bdcampo
    Public TPV_Precio1 As Cdatos.bdcampo
    Public TPV_Precio2 As Cdatos.bdcampo
    Public TPV_Precio3 As Cdatos.bdcampo
    Public TPV_Precio4 As Cdatos.bdcampo
    Public TPV_Precio5 As Cdatos.bdcampo
    Public TPV_PrecioEnvio As Cdatos.bdcampo
    Public TPV_idgasto As Cdatos.bdcampo

    Public TPV_IdUsuarioLog As Cdatos.bdcampo
    Public TPV_FechaLog As Cdatos.bdcampo
    Public TPV_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TarifaPortes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            TPV_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            TPV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            TPV_Precio1 = New Cdatos.bdcampo(CodigoEntidad & "Precio1", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_Precio2 = New Cdatos.bdcampo(CodigoEntidad & "Precio2", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_Precio3 = New Cdatos.bdcampo(CodigoEntidad & "Precio3", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_Precio4 = New Cdatos.bdcampo(CodigoEntidad & "Precio4", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_Precio5 = New Cdatos.bdcampo(CodigoEntidad & "Precio5", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_PrecioEnvio = New Cdatos.bdcampo(CodigoEntidad & "PrecioEnvio", Cdatos.TiposCampo.Importe, 10, 2)
            TPV_idgasto = New Cdatos.bdcampo(CodigoEntidad & "IdGasto", Cdatos.TiposCampo.EnteroPositivo, 5)

            TPV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TPV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TPV_Id as Id, TPV_Nombre as Nombre from TarifaPortes"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTarifaPortes"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTarifaPortes"

    End Sub


End Class
