Public Class E_valorespventa
    Inherits Cdatos.Entidad

    Public VPV_idpventa As Cdatos.bdcampo
    Public VPV_tipoactividad As Cdatos.bdcampo
    Public VPV_EmpresaFacturacion As Cdatos.bdcampo
    Public VPV_DomicilioFacturacion As Cdatos.bdcampo
    Public VPV_CPostalFacturacion As Cdatos.bdcampo
    Public VPV_PoblacionFacturacion As Cdatos.bdcampo
    Public VPV_ProvinciaFacturacion As Cdatos.bdcampo
    Public VPV_IdPaisFacturacion As Cdatos.bdcampo
    Public VPV_AptdoCorreosFacturacion As Cdatos.bdcampo
    Public VPV_TelefonosFacturacion As Cdatos.bdcampo
    Public VPV_FaxFacturacion As Cdatos.bdcampo
    Public VPV_EmailFacturacion As Cdatos.bdcampo
    Public VPV_WebFacturacion As Cdatos.bdcampo
    Public VPV_LineaDatosFiscales As Cdatos.bdcampo
    Public VPV_NombreBanco As Cdatos.bdcampo
    Public VPV_EntidadSucursal As Cdatos.bdcampo
    Public VPV_IBAN As Cdatos.bdcampo
    Public VPV_SWIFT As Cdatos.bdcampo
    Public VPV_Color As Cdatos.bdcampo
    Public VPV_TextoContrato As Cdatos.bdcampo
    Public VPV_IdEmpresa As Cdatos.bdcampo
    Public VPV_Nif As Cdatos.bdcampo
    Public VPV_GGN As Cdatos.bdcampo
    Public VPV_EcologicoSN As Cdatos.bdcampo
    Public VPV_NumRegistroEco As Cdatos.bdcampo
    Public VPV_CentroCtb As Cdatos.bdcampo
    Public VPV_IdDestinoTransito As Cdatos.bdcampo

    Public VPV_ReglamentoEcoEU As Cdatos.bdcampo
    Public VPV_AutorizacionAduanera As Cdatos.bdcampo

    Public VPV_IdUsuarioLog As Cdatos.bdcampo
    Public VPV_FechaLog As Cdatos.bdcampo
    Public VPV_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Valorespventa"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VPV_idpventa = New Cdatos.bdcampo(CodigoEntidad & "Idpventa", Cdatos.TiposCampo.Entero, 3, 0, True)
            VPV_tipoactividad = New Cdatos.bdcampo(CodigoEntidad & "tipoactividad", Cdatos.TiposCampo.Cadena, 1)
            VPV_EmpresaFacturacion = New Cdatos.bdcampo(CodigoEntidad & "EmpresaFacturacion", Cdatos.TiposCampo.Cadena, 50)
            VPV_DomicilioFacturacion = New Cdatos.bdcampo(CodigoEntidad & "DomicilioFacturacion", Cdatos.TiposCampo.Cadena, 150)
            VPV_CPostalFacturacion = New Cdatos.bdcampo(CodigoEntidad & "CPostalFacturacion", Cdatos.TiposCampo.Cadena, 7)
            VPV_PoblacionFacturacion = New Cdatos.bdcampo(CodigoEntidad & "PoblacionFacturacion", Cdatos.TiposCampo.Cadena, 150)
            VPV_ProvinciaFacturacion = New Cdatos.bdcampo(CodigoEntidad & "ProvinciaFacturacion", Cdatos.TiposCampo.Cadena, 150)
            VPV_IdPaisFacturacion = New Cdatos.bdcampo(CodigoEntidad & "IdPaisFacturacion", Cdatos.TiposCampo.Entero, 3)
            VPV_AptdoCorreosFacturacion = New Cdatos.bdcampo(CodigoEntidad & "AptdoCorreosFacturacion", Cdatos.TiposCampo.Cadena, 10)
            VPV_TelefonosFacturacion = New Cdatos.bdcampo(CodigoEntidad & "TelefonosFacturacion", Cdatos.TiposCampo.Cadena, 50)
            VPV_FaxFacturacion = New Cdatos.bdcampo(CodigoEntidad & "FaxFacturacion", Cdatos.TiposCampo.Cadena, 25)
            VPV_EmailFacturacion = New Cdatos.bdcampo(CodigoEntidad & "EmailFacturacion", Cdatos.TiposCampo.Cadena, 250)
            VPV_WebFacturacion = New Cdatos.bdcampo(CodigoEntidad & "WebFacturacion", Cdatos.TiposCampo.Cadena, 255)
            VPV_LineaDatosFiscales = New Cdatos.bdcampo(CodigoEntidad & "LineaDatosFiscales", Cdatos.TiposCampo.Cadena, 255)
            VPV_NombreBanco = New Cdatos.bdcampo(CodigoEntidad & "NombreBanco", Cdatos.TiposCampo.Cadena, 70)
            VPV_EntidadSucursal = New Cdatos.bdcampo(CodigoEntidad & "EntidadSucursal", Cdatos.TiposCampo.Cadena, 10)
            VPV_IBAN = New Cdatos.bdcampo(CodigoEntidad & "IBAN", Cdatos.TiposCampo.Cadena, 50)
            VPV_SWIFT = New Cdatos.bdcampo(CodigoEntidad & "SWIFT", Cdatos.TiposCampo.Cadena, 50)
            VPV_Color = New Cdatos.bdcampo(CodigoEntidad & "Color", Cdatos.TiposCampo.Cadena, 12)
            VPV_TextoContrato = New Cdatos.bdcampo(CodigoEntidad & "TextoContrato", Cdatos.TiposCampo.Cadena, 250)
            VPV_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "IdEmpresa", Cdatos.TiposCampo.Entero, 3)
            VPV_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            VPV_GGN = New Cdatos.bdcampo(CodigoEntidad & "GGN", Cdatos.TiposCampo.Cadena, 20)
            VPV_EcologicoSN = New Cdatos.bdcampo(CodigoEntidad & "EcologicoSN", Cdatos.TiposCampo.Cadena, 1)
            VPV_NumRegistroEco = New Cdatos.bdcampo(CodigoEntidad & "NumRegistroEco", Cdatos.TiposCampo.Cadena, 25)
            VPV_CentroCtb = New Cdatos.bdcampo(CodigoEntidad & "CentroCtb", Cdatos.TiposCampo.Entero, 2)
            VPV_IdDestinoTransito = New Cdatos.bdcampo(CodigoEntidad & "IdDestinoTransito", Cdatos.TiposCampo.Entero, 3)

            VPV_ReglamentoEcoEU = New Cdatos.bdcampo(CodigoEntidad & "ReglamentoEcoEU", Cdatos.TiposCampo.Cadena, 25)
            VPV_AutorizacionAduanera = New Cdatos.bdcampo(CodigoEntidad & "AutorizacionAduanera", Cdatos.TiposCampo.Cadena, 25)


            VPV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VPV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VPV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

End Class
