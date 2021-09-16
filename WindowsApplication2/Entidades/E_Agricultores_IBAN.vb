Public Class E_Agricultores_IBAN
    Inherits Cdatos.Entidad

    Public AIB_Id As Cdatos.bdcampo
    Public AIB_IdAgricultor As Cdatos.bdcampo
    Public AIB_Entidad As Cdatos.bdcampo
    Public AIB_IBAN As Cdatos.bdcampo

    Public AIB_IdUsuarioLog As Cdatos.bdcampo
    Public AIB_FechaLog As Cdatos.bdcampo
    Public AIB_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Agricultores_IBAN"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            AIB_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 8, 0, True)
            AIB_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "Idagricultor", Cdatos.TiposCampo.Entero, 5)
            AIB_Entidad = New Cdatos.bdcampo(CodigoEntidad & "Entidad", Cdatos.TiposCampo.Cadena, 50)
            AIB_IBAN = New Cdatos.bdcampo(CodigoEntidad & "IBAN", Cdatos.TiposCampo.Cadena, 50)

            AIB_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AIB_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AIB_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Id"
        _btBusca.CL_ConsultaSql = "SELECT AIB_Id as Id, AIB_Entidad as Entidad, AIB_IBAN as IBAN FROM Agricultores_IBAN "
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IBAN"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaIBANAgricultor"
        _btBusca.CL_ch1000 = False

        _btBusca.Params("Id", , -1)

    End Sub


   
End Class
