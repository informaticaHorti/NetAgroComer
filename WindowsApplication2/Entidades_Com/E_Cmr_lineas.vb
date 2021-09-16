Public Class E_Cmr_lineas
    Inherits Cdatos.Entidad

    Public CML_IdCmrlin As Cdatos.bdcampo
    Public CML_Idcmr As Cdatos.bdcampo
    Public CML_Idfamilia As Cdatos.bdcampo
    Public CML_idmarca As Cdatos.bdcampo
    Public CML_idpalet As Cdatos.bdcampo
    Public CML_envase As Cdatos.bdcampo
    Public CML_palets As Cdatos.bdcampo
    Public CML_bultos As Cdatos.bdcampo
    Public CML_knetos As Cdatos.bdcampo
    Public CML_kbrutos As Cdatos.bdcampo

    Public CML_PaletsTransporte As Cdatos.bdcampo

    Public CML_IdUsuarioLog As Cdatos.bdcampo
    Public CML_FechaLog As Cdatos.bdcampo
    Public CML_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "cmr_lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CML_IdCmrlin = New Cdatos.bdcampo(CodigoEntidad & "idcmrlin", Cdatos.TiposCampo.Entero, 8, 0, True)
            CML_Idcmr = New Cdatos.bdcampo(CodigoEntidad & "idcmr", Cdatos.TiposCampo.Entero, 10)
            CML_Idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 5)
            CML_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.Entero, 5)
            CML_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.Entero, 5)
            CML_envase = New Cdatos.bdcampo(CodigoEntidad & "envase", Cdatos.TiposCampo.Cadena, 100)
            CML_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 5)
            CML_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 5)
            CML_knetos = New Cdatos.bdcampo(CodigoEntidad & "knetos", Cdatos.TiposCampo.Entero, 10)
            CML_kbrutos = New Cdatos.bdcampo(CodigoEntidad & "kbrutos", Cdatos.TiposCampo.Entero, 10)

            CML_PaletsTransporte = New Cdatos.bdcampo(CodigoEntidad & "PaletsTransporte", Cdatos.TiposCampo.Importe, 5, 2)

            CML_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CML_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CML_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub



End Class
