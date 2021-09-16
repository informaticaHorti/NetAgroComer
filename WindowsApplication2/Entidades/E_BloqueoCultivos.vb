Public Class E_BloqueoCultivos
    Inherits Cdatos.Entidad

    Public BCU_IdBloqueo As Cdatos.bdcampo
    Public BCU_Fecha As Cdatos.bdcampo
    Public BCU_Hora As Cdatos.bdcampo
    Public BCU_IdAgricultor As Cdatos.bdcampo
    Public BCU_IdCultivo As Cdatos.bdcampo
    Public BCU_DeFecha As Cdatos.bdcampo
    Public BCU_DeHora As Cdatos.bdcampo
    Public BCU_AFecha As Cdatos.bdcampo
    Public BCU_AHora As Cdatos.bdcampo
    Public BCU_Motivo As Cdatos.bdcampo


    Public BCU_IdUsuarioLog As Cdatos.bdcampo
    Public BCU_FechaLog As Cdatos.bdcampo
    Public BCU_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "BloqueoCultivos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            BCU_IdBloqueo = New Cdatos.bdcampo(CodigoEntidad & "IdBloqueo", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            BCU_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 15)
            BCU_Hora = New Cdatos.bdcampo(CodigoEntidad & "Hora", Cdatos.TiposCampo.Cadena, 8)
            BCU_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.Entero, 5)
            BCU_IdCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdCultivo", Cdatos.TiposCampo.Entero, 8)
            BCU_DeFecha = New Cdatos.bdcampo(CodigoEntidad & "DeFecha", Cdatos.TiposCampo.Fecha, 15)
            BCU_DeHora = New Cdatos.bdcampo(CodigoEntidad & "DeHora", Cdatos.TiposCampo.Cadena, 8)
            BCU_AFecha = New Cdatos.bdcampo(CodigoEntidad & "AFecha", Cdatos.TiposCampo.Fecha, 15)
            BCU_AHora = New Cdatos.bdcampo(CodigoEntidad & "AHora", Cdatos.TiposCampo.Cadena, 8)
            BCU_Motivo = New Cdatos.bdcampo(CodigoEntidad & "Motivo", Cdatos.TiposCampo.Cadena, 255)

            BCU_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            BCU_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            BCU_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "CodAgr"
        _btBusca.CL_ConsultaSql = "SELECT BCU_IdBloqueo as Id, BCU_IdAgricultor as CodAgr, AGR_Nombre as Agricultor, BCU_IdCultivo as IdCultivo, BCU_Motivo as Motivo FROM BloqueoCultivos LEFT JOIN Agricultores ON AGR_IdAgricultor = BCU_IdAgricultor ORDER BY BCU_IdAgricultor, BCU_IdCultivo"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaBloqueosCultivo"
        '_btBusca.cl_formu = "FrmBloqueoCultivos"
        _btBusca.CL_ch1000 = False


    End Sub

End Class
