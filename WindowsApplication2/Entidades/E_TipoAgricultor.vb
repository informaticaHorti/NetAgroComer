Public Class E_TipoAgricultor
    Inherits Cdatos.Entidad

    Public TPA_idtipo As Cdatos.bdcampo
    Public TPA_nombre As Cdatos.bdcampo
    Public TPA_poriva As Cdatos.bdcampo
    Public TPA_porret As Cdatos.bdcampo
    Public TPA_tiporet As Cdatos.bdcampo
    Public TPA_idtipoiva As Cdatos.bdcampo
    Public TPA_agrimayo As Cdatos.bdcampo
    Public TPA_ctaprov As Cdatos.bdcampo
    Public TPA_ctasumi As Cdatos.bdcampo
    Public TPA_ctaanti As Cdatos.bdcampo
    Public TPA_seriecomer As Cdatos.bdcampo
    Public TPA_ctacompracomer As Cdatos.bdcampo
    Public TPA_ctaivaalbcomer As Cdatos.bdcampo
    Public TPA_ctaretcomer As Cdatos.bdcampo
    Public TPA_ctafondo As Cdatos.bdcampo
    Public TPA_porfondo As Cdatos.bdcampo
    Public TPA_porcomision As Cdatos.bdcampo
    Public TPA_idgasto As Cdatos.bdcampo
    Public TPA_compensa As Cdatos.bdcampo
    Public TPA_tipofactura As Cdatos.bdcampo
    Public TPA_FondoOperativoSN As Cdatos.bdcampo
    Public TPA_SocioHortichuelasSN As Cdatos.bdcampo
    Public TPA_ctaotros As Cdatos.bdcampo
    Public TPA_CtaContingencia As Cdatos.bdcampo
    Public TPA_PorContingencia As Cdatos.bdcampo
    Public TPA_CtaCartera As Cdatos.bdcampo

    Public TPA_IdUsuarioLog As Cdatos.bdcampo
    Public TPA_FechaLog As Cdatos.bdcampo
    Public TPA_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TipoAgricultor"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TPA_idtipo = New Cdatos.bdcampo(CodigoEntidad & "idtipo", Cdatos.TiposCampo.Entero, 5, 0, True)
            TPA_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            TPA_poriva = New Cdatos.bdcampo(CodigoEntidad & "poriva", Cdatos.TiposCampo.Importe, 8, 2)
            TPA_porret = New Cdatos.bdcampo(CodigoEntidad & "porret", Cdatos.TiposCampo.Importe, 8, 2)
            TPA_tiporet = New Cdatos.bdcampo(CodigoEntidad & "tiporet", Cdatos.TiposCampo.Cadena, 1)
            TPA_idtipoiva = New Cdatos.bdcampo(CodigoEntidad & "idtipoiva", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPA_agrimayo = New Cdatos.bdcampo(CodigoEntidad & "agrimayo", Cdatos.TiposCampo.Cadena, 1)

            TPA_ctaprov = New Cdatos.bdcampo(CodigoEntidad & "ctaprov", Cdatos.TiposCampo.CadenaNumero, 6)
            TPA_ctasumi = New Cdatos.bdcampo(CodigoEntidad & "ctasumi", Cdatos.TiposCampo.CadenaNumero, 6)
            TPA_ctaanti = New Cdatos.bdcampo(CodigoEntidad & "ctaanti", Cdatos.TiposCampo.CadenaNumero, 6)

            TPA_seriecomer = New Cdatos.bdcampo(CodigoEntidad & "seriecomer", Cdatos.TiposCampo.Cadena, 3)

            TPA_ctacompracomer = New Cdatos.bdcampo(CodigoEntidad & "ctacompracomer", Cdatos.TiposCampo.Cuenta, 11)
            TPA_ctaivaalbcomer = New Cdatos.bdcampo(CodigoEntidad & "ctaivaalbcomer", Cdatos.TiposCampo.Cuenta, 11)
            TPA_ctaretcomer = New Cdatos.bdcampo(CodigoEntidad & "ctaretcomer", Cdatos.TiposCampo.Cuenta, 11)

            TPA_ctafondo = New Cdatos.bdcampo(CodigoEntidad & "ctafondo", Cdatos.TiposCampo.Cuenta, 11)
            TPA_porfondo = New Cdatos.bdcampo(CodigoEntidad & "porfondo", Cdatos.TiposCampo.Importe, 8, 2)
            TPA_porcomision = New Cdatos.bdcampo(CodigoEntidad & "porcomision", Cdatos.TiposCampo.Importe, 8, 2)
            TPA_idgasto = New Cdatos.bdcampo(CodigoEntidad & "idgasto", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPA_compensa = New Cdatos.bdcampo(CodigoEntidad & "compensa", Cdatos.TiposCampo.Cadena, 1)
            TPA_tipofactura = New Cdatos.bdcampo(CodigoEntidad & "tipofactura", Cdatos.TiposCampo.Cadena, 1)

            TPA_FondoOperativoSN = New Cdatos.bdcampo(CodigoEntidad & "FondoOperativoSN", Cdatos.TiposCampo.Cadena, 1)
            TPA_SocioHortichuelasSN = New Cdatos.bdcampo(CodigoEntidad & "SocioHortichuelasSN", Cdatos.TiposCampo.Cadena, 1)
            TPA_ctaotros = New Cdatos.bdcampo(CodigoEntidad & "ctaotros", Cdatos.TiposCampo.CadenaNumero, 6)

            TPA_CtaContingencia = New Cdatos.bdcampo(CodigoEntidad & "CtaContingencia", Cdatos.TiposCampo.Cuenta, 11)
            TPA_PorContingencia = New Cdatos.bdcampo(CodigoEntidad & "PorContingencia", Cdatos.TiposCampo.Importe, 8, 2)

            TPA_CtaCartera = New Cdatos.bdcampo(CodigoEntidad & "CtaCartera", Cdatos.TiposCampo.CadenaNumero, 6)

            TPA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TPA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TPA_IdTipo as IdTipo, TPA_Nombre as Nombre from TipoAgricultor"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdTipo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTipoAgricultor"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTiposdeAgricultores"

    End Sub



End Class

