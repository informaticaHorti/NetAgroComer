Public Class E_ValoraImportaciones
    Inherits Cdatos.Entidad

    Public VAI_IdAlbEntrada As Cdatos.bdcampo
    Public VAI_FechaSalida As Cdatos.bdcampo
    Public VAI_FechaLlegada As Cdatos.bdcampo
    Public VAI_NumFactura As Cdatos.bdcampo
    Public VAI_Matricula As Cdatos.bdcampo
    Public VAI_Observaciones As Cdatos.bdcampo
    Public VAI_TransporteEntrada As Cdatos.bdcampo
    Public VAI_Porte As Cdatos.bdcampo
    Public VAI_Arancel As Cdatos.bdcampo
    Public VAI_Transitario As Cdatos.bdcampo
    Public VAI_Comision As Cdatos.bdcampo
    Public VAI_OtrosGastos As Cdatos.bdcampo
    Public VAI_CerradoSN As Cdatos.bdcampo
    Public VAI_ClaveBloqueo As Cdatos.bdcampo
    Public VAI_FechaFactura As Cdatos.bdcampo
    Public VAI_ImporteComision As Cdatos.bdcampo

    Public VAI_IdUsuarioLog As Cdatos.bdcampo
    Public VAI_FechaLog As Cdatos.bdcampo
    Public VAI_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValoraImportaciones"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VAI_IdAlbEntrada = New Cdatos.bdcampo(CodigoEntidad & "IdAlbEntrada", Cdatos.TiposCampo.Entero, 6, 0, True)
            VAI_FechaSalida = New Cdatos.bdcampo(CodigoEntidad & "FechaSalida", Cdatos.TiposCampo.Fecha, 10)
            VAI_FechaLlegada = New Cdatos.bdcampo(CodigoEntidad & "FechaLlegada", Cdatos.TiposCampo.Fecha, 10)
            VAI_NumFactura = New Cdatos.bdcampo(CodigoEntidad & "NumFactura", Cdatos.TiposCampo.Cadena, 10)
            VAI_Matricula = New Cdatos.bdcampo(CodigoEntidad & "Matricula", Cdatos.TiposCampo.Cadena, 15)
            VAI_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 50)
            VAI_TransporteEntrada = New Cdatos.bdcampo(CodigoEntidad & "TransporteEntrada", Cdatos.TiposCampo.Cadena, 50)
            VAI_Porte = New Cdatos.bdcampo(CodigoEntidad & "Porte", Cdatos.TiposCampo.Importe, 18, 2)
            VAI_Arancel = New Cdatos.bdcampo(CodigoEntidad & "Arancel", Cdatos.TiposCampo.Importe, 18, 2)
            VAI_Transitario = New Cdatos.bdcampo(CodigoEntidad & "Transitario", Cdatos.TiposCampo.Importe, 18, 2)
            VAI_Comision = New Cdatos.bdcampo(CodigoEntidad & "Comision", Cdatos.TiposCampo.Importe, 18, 2)
            VAI_OtrosGastos = New Cdatos.bdcampo(CodigoEntidad & "OtrosGastos", Cdatos.TiposCampo.Importe, 18, 2)
            VAI_CerradoSN = New Cdatos.bdcampo(CodigoEntidad & "CerradoSN", Cdatos.TiposCampo.Cadena, 1)
            VAI_ClaveBloqueo = New Cdatos.bdcampo(CodigoEntidad & "ClaveBloqueo", Cdatos.TiposCampo.Cadena, 20)
            VAI_FechaFactura = New Cdatos.bdcampo(CodigoEntidad & "FechaFactura", Cdatos.TiposCampo.Fecha, 10)
            VAI_ImporteComision = New Cdatos.bdcampo(CodigoEntidad & "ImporteComision", Cdatos.TiposCampo.Importe, 18, 2)

            VAI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VAI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VAI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
