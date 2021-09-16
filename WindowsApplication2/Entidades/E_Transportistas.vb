Public Class E_Transportistas
    Inherits Cdatos.Entidad

    Public TTA_IdTransportista As Cdatos.bdcampo
    Public TTA_Nombre As Cdatos.bdcampo
    Public TTA_Nif As Cdatos.bdcampo
    Public TTA_TipoPorte As Cdatos.bdcampo

    Public TTA_IdUsuarioLog As Cdatos.bdcampo
    Public TTA_FechaLog As Cdatos.bdcampo
    Public TTA_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Transportistas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TTA_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "idtransportista", Cdatos.TiposCampo.Entero, 5, 0, True)
            TTA_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            TTA_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            TTA_TipoPorte = New Cdatos.bdcampo(CodigoEntidad & "tipoporte", Cdatos.TiposCampo.Cadena, 2)

            TTA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TTA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TTA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TTA_Idtransportista as IdTransportista, TTA_Nombre as Nombre from transportistas"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idtransportista"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTransportista"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTransportistas"

    End Sub



End Class
