Public Class E_Reclama_resolucion
    Inherits Cdatos.Entidad

    Public RCS_Idsolucion As Cdatos.bdcampo
    Public RCS_Nombre As Cdatos.bdcampo

    Public RCS_IdUsuarioLog As Cdatos.bdcampo
    Public RCS_FechaLog As Cdatos.bdcampo
    Public RCS_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Reclama_resolucion"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            RCS_Idsolucion = New Cdatos.bdcampo(CodigoEntidad & "idsolucion", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            RCS_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)

            RCS_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            RCS_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            RCS_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select RCS_Idsolucion as Idsolucion, RCS_Nombre as Nombre from Reclama_resolucion"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idsolucion"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaresolucion"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
