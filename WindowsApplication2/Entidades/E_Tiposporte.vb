Public Class E_TiposPorte

    Inherits Cdatos.Entidad

    Public TPO_Id As Cdatos.bdcampo
    Public TPO_Nombre As Cdatos.bdcampo
    Public TPO_OrigenDestino As Cdatos.bdcampo

    Public TPO_IdUsuarioLog As Cdatos.bdcampo
    Public TPO_FechaLog As Cdatos.bdcampo
    Public TPO_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TiposPorte"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            TPO_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            TPO_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            TPO_OrigenDestino = New Cdatos.bdcampo(CodigoEntidad & "OrigenDestino", Cdatos.TiposCampo.Cadena, 1)

            TPO_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPO_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TPO_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TPO_Id as Id, TPO_Nombre as Nombre,TPO_OrigenDestino as OD from TiposPorte"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTipoporte"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTiposPorte"

    End Sub


End Class
