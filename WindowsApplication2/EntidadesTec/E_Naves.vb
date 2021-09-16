Public Class E_Naves

    Inherits Cdatos.Entidad

    Public NAV_IdFinca As Cdatos.bdcampo
    Public NAV_IdNave As Cdatos.bdcampo
    Public NAV_Nombre As Cdatos.bdcampo
    Public NAV_Superficie As Cdatos.bdcampo
    Public NAV_IdEstructura As Cdatos.bdcampo
    Public NAV_IdSustratoCultivo As Cdatos.bdcampo
    Public NAV_IdMalla As Cdatos.bdcampo
    Public NAV_LineosMarcoGoteo As Cdatos.bdcampo
    Public NAV_GoterosMarcoGoteo As Cdatos.bdcampo
    Public NAV_NumTanquesAbonados As Cdatos.bdcampo
    Public NAV_CaudalGoteros As Cdatos.bdcampo
    Public NAV_Altura As Cdatos.bdcampo
    Public NAV_Calefaccion As Cdatos.bdcampo
    Public NAV_Ventilacion As Cdatos.bdcampo
    Public NAV_Nebulizacion As Cdatos.bdcampo
    Public NAV_ControlClima As Cdatos.bdcampo
    Public NAV_HidroPonico As Cdatos.bdcampo
    Public NAV_DoblePuerta As Cdatos.bdcampo
    Public NAV_Asegurada As Cdatos.bdcampo
    Public NAV_IdAgriaSoc As Cdatos.bdcampo
    Public NAV_FechaFinArr As Cdatos.bdcampo
    Public NAV_FechaSeguro As Cdatos.bdcampo
    Public NAV_Nave As Cdatos.bdcampo



    Public NAV_IdUsuarioLog As Cdatos.bdcampo
    Public NAV_FechaLog As Cdatos.bdcampo
    Public NAV_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub
    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Naves"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            NAV_IdNave = New Cdatos.bdcampo(CodigoEntidad & "IdNave", Cdatos.TiposCampo.Entero, 5, , True)
            NAV_IdFinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.Entero, 5)
            NAV_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            NAV_Superficie = New Cdatos.bdcampo(CodigoEntidad & "Superficie", Cdatos.TiposCampo.Importe, 8)
            NAV_IdEstructura = New Cdatos.bdcampo(CodigoEntidad & "IdEstructura", Cdatos.TiposCampo.Entero, 4)
            NAV_IdSustratoCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdSustratoCultivo", Cdatos.TiposCampo.Entero, 4)
            NAV_IdMalla = New Cdatos.bdcampo(CodigoEntidad & "IdMalla", Cdatos.TiposCampo.Entero, 4)
            NAV_LineosMarcoGoteo = New Cdatos.bdcampo(CodigoEntidad & "IdLineosMarcoGoteo", Cdatos.TiposCampo.Importe, 8, 2)
            NAV_GoterosMarcoGoteo = New Cdatos.bdcampo(CodigoEntidad & "GoterosMarcoGoteo", Cdatos.TiposCampo.Importe, 8, 2)
            NAV_NumTanquesAbonados = New Cdatos.bdcampo(CodigoEntidad & "NumTanquesAbonado", Cdatos.TiposCampo.Importe, 8, 2)
            NAV_CaudalGoteros = New Cdatos.bdcampo(CodigoEntidad & "CaudalGoteros", Cdatos.TiposCampo.Importe, 8, 2)
            NAV_Altura = New Cdatos.bdcampo(CodigoEntidad & "Altura", Cdatos.TiposCampo.Importe, 8, 2)
            NAV_Calefaccion = New Cdatos.bdcampo(CodigoEntidad & "Calefaccion", Cdatos.TiposCampo.Cadena, 1)
            NAV_Ventilacion = New Cdatos.bdcampo(CodigoEntidad & "Ventilacion", Cdatos.TiposCampo.Cadena, 1)
            NAV_Nebulizacion = New Cdatos.bdcampo(CodigoEntidad & "Nebulizacion", Cdatos.TiposCampo.Cadena, 1)
            NAV_ControlClima = New Cdatos.bdcampo(CodigoEntidad & "ControlClima", Cdatos.TiposCampo.Cadena, 1)
            NAV_HidroPonico = New Cdatos.bdcampo(CodigoEntidad & "HidroPonico", Cdatos.TiposCampo.Cadena, 1)
            NAV_DoblePuerta = New Cdatos.bdcampo(CodigoEntidad & "DoblePuerta", Cdatos.TiposCampo.Cadena, 1)
            NAV_Asegurada = New Cdatos.bdcampo(CodigoEntidad & "Asegurada", Cdatos.TiposCampo.Cadena, 1)
            NAV_IdAgriaSoc = New Cdatos.bdcampo(CodigoEntidad & "IdAgriaSoc", Cdatos.TiposCampo.Cadena, 5)
            NAV_FechaFinArr = New Cdatos.bdcampo(CodigoEntidad & "FechaFinArre", Cdatos.TiposCampo.Fecha, 10)
            NAV_FechaSeguro = New Cdatos.bdcampo(CodigoEntidad & "FechaSeguro", Cdatos.TiposCampo.Fecha, 10)
            NAV_Nave = New Cdatos.bdcampo(CodigoEntidad & "Nave", Cdatos.TiposCampo.Cadena, 10)




            NAV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            NAV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            NAV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()



        Catch ex As Exception
            err.Muestraerror("Error en la creacion de la entidad ", "New", ex.Message)
        End Try

       
    End Sub

End Class
