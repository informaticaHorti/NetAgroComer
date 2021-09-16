Public Class E_AgricultoresTec
    Inherits Cdatos.Entidad

    Public AGR_IdAgricultor As Cdatos.bdcampo
    Public AGR_Nombre As Cdatos.bdcampo
    Public AGR_Domicilio As Cdatos.bdcampo
    Public AGR_Poblacion As Cdatos.bdcampo
    Public AGR_Provincia As Cdatos.bdcampo
    Public AGR_Cpostal As Cdatos.bdcampo
    Public AGR_Nif As Cdatos.bdcampo
    Public AGR_Telefono As Cdatos.bdcampo
    Public AGR_Movil As Cdatos.bdcampo
    Public AGR_Fax As Cdatos.bdcampo
    Public AGR_Mail As Cdatos.bdcampo
    Public AGR_IdPrincipal As Cdatos.bdcampo
    Public AGR_Bloqueado As Cdatos.bdcampo
    Public AGR_CarnetPlaga As Cdatos.bdcampo
    Public AGR_NCarnet As Cdatos.bdcampo
    Public AGR_IdCRecogida As Cdatos.bdcampo

    Public AGR_IdUsuarioLog As Cdatos.bdcampo
    Public AGR_FechaLog As Cdatos.bdcampo
    Public AGR_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        'MyBase.new()

        Me.New(0, Nothing)

    End Sub
    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Agricultores"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AGR_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "Idagricultor", Cdatos.TiposCampo.Entero, 5, 0, True)
            AGR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            AGR_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            AGR_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 50)
            AGR_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            AGR_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 30)
            AGR_Cpostal = New Cdatos.bdcampo(CodigoEntidad & "CPostal", Cdatos.TiposCampo.Cadena, 10)
            AGR_Telefono = New Cdatos.bdcampo(CodigoEntidad & "Telefono", Cdatos.TiposCampo.Cadena, 30)
            AGR_Movil = New Cdatos.bdcampo(CodigoEntidad & "Movil", Cdatos.TiposCampo.Cadena, 30)
            AGR_Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 30)
            AGR_Mail = New Cdatos.bdcampo(CodigoEntidad & "Mail", Cdatos.TiposCampo.Cadena, 50)
            AGR_IdPrincipal = New Cdatos.bdcampo(CodigoEntidad & "IdPrincipal", Cdatos.TiposCampo.EnteroPositivo, 10)
            AGR_Bloqueado = New Cdatos.bdcampo(CodigoEntidad & "Bloqueado", Cdatos.TiposCampo.Cadena, 1)
            AGR_CarnetPlaga = New Cdatos.bdcampo(CodigoEntidad & "CarnetPlaga", Cdatos.TiposCampo.Cadena, 1)
            AGR_NCarnet = New Cdatos.bdcampo(CodigoEntidad & "NCarnet", Cdatos.TiposCampo.Cadena, 20)
            AGR_IdCRecogida = New Cdatos.bdcampo(CodigoEntidad & "IdCRecogida", Cdatos.TiposCampo.EnteroPositivo, 11)

            AGR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AGR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)

        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select AGR_IdAgricultor as IdAgricultor, AGR_Nombre as Nombre, AGR_Nif as NIF from Agricultores"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdAgricultor"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAgricultor"
        _btBusca.CL_ch1000 = False


    End Sub



End Class
