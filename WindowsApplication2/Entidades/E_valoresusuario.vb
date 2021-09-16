Public Class E_valoresusuario
    Inherits Cdatos.Entidad

    Public VUS_Iduser As Cdatos.bdcampo
    Public VUS_IdCentroRecogida As Cdatos.bdcampo
    Public VUS_ImpresoraFacturasClientes As Cdatos.bdcampo
    Public VUS_ImpresoraCMRNacional As Cdatos.bdcampo
    Public VUS_ImpresoraCMRInternacional As Cdatos.bdcampo
    Public VUS_ImpresoraEtiquetaCMR As Cdatos.bdcampo
    Public VUS_RutaMensajeCorreoNET As Cdatos.bdcampo
    Public VUS_RutaGeneracionPDF As Cdatos.bdcampo
    Public VUS_RutaMensajeFax As Cdatos.bdcampo
    Public VUS_PrefijoFax As Cdatos.bdcampo
    Public VUS_SufijoFax As Cdatos.bdcampo
    Public VUS_ImpresoraPalets As Cdatos.bdcampo
    Public VUS_ImpresoraEmail_PDF As Cdatos.bdcampo
    Public VUS_idgrupomensajes As Cdatos.bdcampo
    Public VUS_ImpresoraMuestreo As Cdatos.bdcampo
    Public VUS_ImpresoraAlbEntrada As Cdatos.bdcampo
    Public VUS_ImpresoraClasificacionesProveedor As Cdatos.bdcampo
    Public VUS_ImpresoraValeEnvases As Cdatos.bdcampo
    Public VUS_ImpresoraLoteEntrada As Cdatos.bdcampo
    Public VUS_ImpresoraPaletSemiterminado As Cdatos.bdcampo
    Public VUS_ImpresoraPartidaControlada As Cdatos.bdcampo
    Public VUS_ImpresoraPartidaNoControlada As Cdatos.bdcampo
    Public VUS_ImpresoraLiquidaciones As Cdatos.bdcampo
    Public VUS_ImpresoraTalones As Cdatos.bdcampo
    Public VUS_ValidarOperario As Cdatos.bdcampo
    Public VUS_ImpresoraCartelones As Cdatos.bdcampo

    Public VUS_DescNavegador1 As Cdatos.bdcampo
    Public VUS_DescNavegador2 As Cdatos.bdcampo
    Public VUS_DescNavegador3 As Cdatos.bdcampo
    Public VUS_DescNavegador4 As Cdatos.bdcampo
    Public VUS_DescNavegador5 As Cdatos.bdcampo
    Public VUS_DescNavegador6 As Cdatos.bdcampo
    Public VUS_DescNavegador7 As Cdatos.bdcampo
    Public VUS_DescNavegador8 As Cdatos.bdcampo
    Public VUS_DescNavegador9 As Cdatos.bdcampo
    Public VUS_DescNavegador10 As Cdatos.bdcampo

    Public VUS_UrlNavegador1 As Cdatos.bdcampo
    Public VUS_UrlNavegador2 As Cdatos.bdcampo
    Public VUS_UrlNavegador3 As Cdatos.bdcampo
    Public VUS_UrlNavegador4 As Cdatos.bdcampo
    Public VUS_UrlNavegador5 As Cdatos.bdcampo
    Public VUS_UrlNavegador6 As Cdatos.bdcampo
    Public VUS_UrlNavegador7 As Cdatos.bdcampo
    Public VUS_UrlNavegador8 As Cdatos.bdcampo
    Public VUS_UrlNavegador9 As Cdatos.bdcampo
    Public VUS_UrlNavegador10 As Cdatos.bdcampo

    Public VUS_ImpresoraLotesControlados As Cdatos.bdcampo
    Public VUS_ImpresoraLotesNoControlados As Cdatos.bdcampo
    Public VUS_ImpresoraPaletSemitControlados As Cdatos.bdcampo
    Public VUS_ImpresoraPaletSemitNoControlados As Cdatos.bdcampo


    Public VUS_IdUsuarioLog As Cdatos.bdcampo
    Public VUS_FechaLog As Cdatos.bdcampo
    Public VUS_HoraLog As Cdatos.bdcampo





    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Valoresusuario"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VUS_Iduser = New Cdatos.bdcampo(CodigoEntidad & "Iduser", Cdatos.TiposCampo.Entero, 3, 0, True)
            VUS_IdCentroRecogida = New Cdatos.bdcampo(CodigoEntidad & "IdCentrorecogida", Cdatos.TiposCampo.Entero, 3)
            VUS_ImpresoraFacturasClientes = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraFacturasClientes", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraCMRNacional = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraCMRNacional", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraCMRInternacional = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraCMRInternacional", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraEtiquetaCMR = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraEtiquetaCMR", Cdatos.TiposCampo.Cadena, 255)
            VUS_RutaMensajeCorreoNET = New Cdatos.bdcampo(CodigoEntidad & "RutaMensajeCorreoNET", Cdatos.TiposCampo.Cadena, 255)
            VUS_RutaGeneracionPDF = New Cdatos.bdcampo(CodigoEntidad & "RutaGeneracionPDF", Cdatos.TiposCampo.Cadena, 255)
            VUS_RutaMensajeFax = New Cdatos.bdcampo(CodigoEntidad & "RutaMensajeFax", Cdatos.TiposCampo.Cadena, 255)
            VUS_PrefijoFax = New Cdatos.bdcampo(CodigoEntidad & "PrefijoFax", Cdatos.TiposCampo.Cadena, 50)
            VUS_SufijoFax = New Cdatos.bdcampo(CodigoEntidad & "SufijoFax", Cdatos.TiposCampo.Cadena, 50)
            VUS_ImpresoraPalets = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPalets", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraEmail_PDF = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraEmail_PDF", Cdatos.TiposCampo.Cadena, 255)
            VUS_idgrupomensajes = New Cdatos.bdcampo(CodigoEntidad & "Idgrupomensajes", Cdatos.TiposCampo.Entero, 3)
            VUS_ImpresoraMuestreo = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraMuestreo", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraAlbEntrada = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraAlbEntrada", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraClasificacionesProveedor = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraClasificacionesProveedor", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraValeEnvases = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraValeEnvases", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraLoteEntrada = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraLoteEntrada", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraPaletSemiterminado = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPaletSemiterminado", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraPartidaControlada = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPartidaControlada", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraPartidaNoControlada = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPartidaNoControlada", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraLiquidaciones = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraLiquidaciones", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraTalones = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraTalones", Cdatos.TiposCampo.Cadena, 255)
            VUS_ValidarOperario = New Cdatos.bdcampo(CodigoEntidad & "ValidarOperario", Cdatos.TiposCampo.Cadena, 1)
            VUS_ImpresoraCartelones = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraCartelones", Cdatos.TiposCampo.Cadena, 255)

            VUS_DescNavegador1 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador1", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador2 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador2", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador3 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador3", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador4 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador4", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador5 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador5", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador6 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador6", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador7 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador7", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador8 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador8", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador9 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador9", Cdatos.TiposCampo.Cadena, 20)
            VUS_DescNavegador10 = New Cdatos.bdcampo(CodigoEntidad & "DescNavegador10", Cdatos.TiposCampo.Cadena, 20)

            VUS_UrlNavegador1 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador1", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador2 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador2", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador3 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador3", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador4 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador4", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador5 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador5", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador6 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador6", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador7 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador7", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador8 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador8", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador9 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador9", Cdatos.TiposCampo.Cadena, 512)
            VUS_UrlNavegador10 = New Cdatos.bdcampo(CodigoEntidad & "UrlNavegador10", Cdatos.TiposCampo.Cadena, 512)

            VUS_ImpresoraLotesControlados = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraLotesControlados", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraLotesNoControlados = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraLotesNoControlados", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraPaletSemitControlados = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPaletSemitControlados", Cdatos.TiposCampo.Cadena, 255)
            VUS_ImpresoraPaletSemitNoControlados = New Cdatos.bdcampo(CodigoEntidad & "ImpresoraPaletSemitNoControlados", Cdatos.TiposCampo.Cadena, 255)



            VUS_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VUS_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VUS_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

End Class
