Public Class E_Envases
    Inherits Cdatos.Entidad


    Public ENV_IdEnvase As Cdatos.bdcampo
    Public ENV_Nombre As Cdatos.bdcampo
    Public ENV_Abreviatura As Cdatos.bdcampo
    Public ENV_IdfamiliaEnvase As Cdatos.bdcampo
    Public ENV_Tipo As Cdatos.bdcampo
    Public ENV_PrecioVenta As Cdatos.bdcampo
    Public ENV_CosteSalida As Cdatos.bdcampo
    Public ENV_PrecioAbono As Cdatos.bdcampo
    Public ENV_StockMinimo As Cdatos.bdcampo
    Public ENV_TaraEntrada As Cdatos.bdcampo
    Public ENV_TaraSalida As Cdatos.bdcampo
    Public ENV_Retornable As Cdatos.bdcampo
    Public ENV_IdTipoiva As Cdatos.bdcampo
    Public ENV_StockMarca As Cdatos.bdcampo
    Public ENV_PMC As Cdatos.bdcampo
    Public ENV_Inventariable As Cdatos.bdcampo
    Public ENV_idsubfamilia As Cdatos.bdcampo
    Public ENV_idmedida As Cdatos.bdcampo
    Public ENV_largo As Cdatos.bdcampo
    Public ENV_ancho As Cdatos.bdcampo
    Public ENV_alto As Cdatos.bdcampo
    Public ENV_idtipomaterial As Cdatos.bdcampo
    Public ENV_Udmedida As Cdatos.bdcampo

    Public ENV_CtaDevFianzas As Cdatos.bdcampo

    Public ENV_IdAcreedorFianza As Cdatos.bdcampo
    Public ENV_CodigoFianza As Cdatos.bdcampo
    Public ENV_PrecioFianza As Cdatos.bdcampo

    'Public ENV_Revisado As Cdatos.bdcampo
    Public ENV_EnvaseRevisado As Cdatos.bdcampo
    Public ENV_EnvaseObsoleto As Cdatos.bdcampo

    Public ENV_DescriptorFichero As Cdatos.bdcampo

    Public ENV_IdUsuarioLog As Cdatos.bdcampo
    Public ENV_FechaLog As Cdatos.bdcampo
    Public ENV_HoraLog As Cdatos.bdcampo

    Dim err As Errores



    Public Sub New()

        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim FamiliaEnvases As New E_FamiliaEnvases(idUsuario, cn)


        Try
            NombreTabla = "Envases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            ENV_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.Entero, 5, 0, True)
            ENV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            ENV_Abreviatura = New Cdatos.bdcampo(CodigoEntidad & "abreviatura", Cdatos.TiposCampo.Cadena, 20)
            ENV_IdfamiliaEnvase = New Cdatos.bdcampo(CodigoEntidad & "idfamiliaenvase", Cdatos.TiposCampo.EnteroPositivo, 3, 0, False, FamiliaEnvases, FamiliaEnvases.FEV_IdFamilia, FamiliaEnvases.FEV_Nombre)
            ENV_Tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)
            ENV_PrecioVenta = New Cdatos.bdcampo(CodigoEntidad & "precioventa", Cdatos.TiposCampo.Importe, 8, 3)
            ENV_CosteSalida = New Cdatos.bdcampo(CodigoEntidad & "costesalida", Cdatos.TiposCampo.Importe, 12, 6)
            ENV_PrecioAbono = New Cdatos.bdcampo(CodigoEntidad & "precioabono", Cdatos.TiposCampo.Importe, 8, 3)
            ENV_StockMinimo = New Cdatos.bdcampo(CodigoEntidad & "stockminimo", Cdatos.TiposCampo.Importe, 8, 2)
            ENV_TaraEntrada = New Cdatos.bdcampo(CodigoEntidad & "taraentrada", Cdatos.TiposCampo.Importe, 20, 4)
            ENV_TaraSalida = New Cdatos.bdcampo(CodigoEntidad & "tarasalida", Cdatos.TiposCampo.Importe, 20, 4)
            ENV_Retornable = New Cdatos.bdcampo(CodigoEntidad & "retornable", Cdatos.TiposCampo.Cadena, 1)
            ENV_IdTipoiva = New Cdatos.bdcampo(CodigoEntidad & "idtipoiva", Cdatos.TiposCampo.EnteroPositivo, 1)
            ENV_StockMarca = New Cdatos.bdcampo(CodigoEntidad & "stockmarca", Cdatos.TiposCampo.Cadena, 1)
            ENV_PMC = New Cdatos.bdcampo(CodigoEntidad & "PMC", Cdatos.TiposCampo.Importe, 10, 6)
            ENV_Inventariable = New Cdatos.bdcampo(CodigoEntidad & "Inventariable", Cdatos.TiposCampo.Cadena, 1)
            ENV_idsubfamilia = New Cdatos.bdcampo(CodigoEntidad & "idsubfamilia", Cdatos.TiposCampo.EnteroPositivo, 4)
            ENV_idmedida = New Cdatos.bdcampo(CodigoEntidad & "idmedida", Cdatos.TiposCampo.EnteroPositivo, 3)
            ENV_largo = New Cdatos.bdcampo(CodigoEntidad & "largo", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENV_ancho = New Cdatos.bdcampo(CodigoEntidad & "ancho", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENV_alto = New Cdatos.bdcampo(CodigoEntidad & "alto", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENV_idtipomaterial = New Cdatos.bdcampo(CodigoEntidad & "idtipomaterial", Cdatos.TiposCampo.EnteroPositivo, 3)
            ENV_Udmedida = New Cdatos.bdcampo(CodigoEntidad & "udmedida", Cdatos.TiposCampo.EnteroPositivo, 2)
            ENV_CtaDevFianzas = New Cdatos.bdcampo(CodigoEntidad & "CtaDevFianzas", Cdatos.TiposCampo.Cuenta, 11)
            ENV_IdAcreedorFianza = New Cdatos.bdcampo(CodigoEntidad & "IdAcreedorFianza", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENV_CodigoFianza = New Cdatos.bdcampo(CodigoEntidad & "CodigoFianza", Cdatos.TiposCampo.Cadena, 50)
            ENV_PrecioFianza = New Cdatos.bdcampo(CodigoEntidad & "PrecioFianza", Cdatos.TiposCampo.Importe, 8, 4)

            'ENV_Revisado = New Cdatos.bdcampo(CodigoEntidad & "Revisado", Cdatos.TiposCampo.Cadena, 1)
            ENV_EnvaseRevisado = New Cdatos.bdcampo(CodigoEntidad & "EnvaseRevisado", Cdatos.TiposCampo.EnteroPositivo, 1)
            ENV_EnvaseObsoleto = New Cdatos.bdcampo(CodigoEntidad & "EnvaseObsoleto", Cdatos.TiposCampo.Cadena, 1)

            ENV_DescriptorFichero = New Cdatos.bdcampo(CodigoEntidad & "DescriptorFichero", Cdatos.TiposCampo.Cadena, 10)


            ENV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ENV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ENV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select ENV_Idenvase as IdEnvase, ENV_tipo as Tipo, ENV_Nombre as Nombre, ENV_Inventariable as Inv, ENV_EnvaseObsoleto as Obsoleto from Envases"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idenvase"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmEnvases"
        


    End Sub



End Class
