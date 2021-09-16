Public Class E_Cultivos

    Inherits Cdatos.Entidad

    Public CUL_IdCultivo As Cdatos.bdcampo
    Public CUL_IdFinca As Cdatos.bdcampo
    Public CUL_IdNave As Cdatos.bdcampo
    Public CUL_IdGenero As Cdatos.bdcampo
    Public CUL_IdTemporada As Cdatos.bdcampo
    Public CUL_IdCasaComer As Cdatos.bdcampo
    Public CUL_IdVariedad As Cdatos.bdcampo
    Public CUL_IdProgramaCalidad As Cdatos.bdcampo
    Public CUL_IdSustratoSemi As Cdatos.bdcampo
    Public CUL_IdBandeja As Cdatos.bdcampo
    Public CUL_IdSemillero As Cdatos.bdcampo
    Public CUL_Superficie As Cdatos.bdcampo
    Public CUL_ProducEstimada As Cdatos.bdcampo
    Public CUL_ProducReal As Cdatos.bdcampo
    Public CUL_LineosMarcoPla As Cdatos.bdcampo
    Public CUL_PlantasMarcoPla As Cdatos.bdcampo
    Public CUL_NumPlantas As Cdatos.bdcampo
    Public CUL_PlantasXalveolo As Cdatos.bdcampo
    Public CUL_FechaSiembraProgra As Cdatos.bdcampo
    Public CUL_FechaSiembraReal As Cdatos.bdcampo
    Public CUL_FechaRecoleProgra As Cdatos.bdcampo
    Public CUL_FechaRecoleReal As Cdatos.bdcampo
    Public CUL_FechaFinalizaProgra As Cdatos.bdcampo
    Public CUL_FechaFinalizaReal As Cdatos.bdcampo
    Public CUL_FechaCuajeProgra As Cdatos.bdcampo
    Public CUL_FechaCuajeReal As Cdatos.bdcampo
    Public CUL_PartidaSemillero As Cdatos.bdcampo
    Public CUL_Bloquear As Cdatos.bdcampo
    Public CUL_Observaciones As Cdatos.bdcampo
    Public CUL_IdProgCalidad2 As Cdatos.bdcampo
    Public CUL_IdProgCalidad3 As Cdatos.bdcampo
    Public CUL_DesdeFechaSeguridad As Cdatos.bdcampo
    Public CUL_DesdeHoraSeguridad As Cdatos.bdcampo
    Public CUL_HastaFechaSeguridad As Cdatos.bdcampo
    Public CUL_HastaHoraSeguridad As Cdatos.bdcampo
    Public CUL_IdSustratoCultivo As Cdatos.bdcampo
    Public CUL_PlantaSm2 As Cdatos.bdcampo
    Public CUL_Ucth As Cdatos.bdcampo

    Public CUL_Campa As Cdatos.bdcampo
    Public CUL_Cultivo As Cdatos.bdcampo

    Public CUL_TipoCultivo As Cdatos.bdcampo
    Public CUL_Activo As Cdatos.bdcampo

    Public CUL_IdPlanificacion As Cdatos.bdcampo
    Public CUL_Coeficiente As Cdatos.bdcampo
    Public CUL_IdTecnico As Cdatos.bdcampo

    Public CUL_CalidadEntradas As Cdatos.bdcampo

    Public CUL_IdUsuarioLog As Cdatos.bdcampo
    Public CUL_FechaLog As Cdatos.bdcampo
    Public CUL_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)
        Try
            NombreTabla = "Cultivos"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CUL_IdCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdCultivo", Cdatos.TiposCampo.Entero, 10, , True)
            CUL_IdFinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.Entero, 5)
            CUL_IdNave = New Cdatos.bdcampo(CodigoEntidad & "IdNave", Cdatos.TiposCampo.Entero, 5)
            CUL_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 5)
            CUL_IdTemporada = New Cdatos.bdcampo(CodigoEntidad & "IdTemporada", Cdatos.TiposCampo.Entero, 4)
            CUL_IdCasaComer = New Cdatos.bdcampo(CodigoEntidad & "IdCasasComercial", Cdatos.TiposCampo.Entero, 4)
            CUL_IdVariedad = New Cdatos.bdcampo(CodigoEntidad & "IdVariedad", Cdatos.TiposCampo.Entero, 4)
            CUL_IdProgramaCalidad = New Cdatos.bdcampo(CodigoEntidad & "IdProgramaCalidad", Cdatos.TiposCampo.Entero, 4)
            CUL_IdSustratoSemi = New Cdatos.bdcampo(CodigoEntidad & "IdSustratoSemi", Cdatos.TiposCampo.Entero, 4)
            CUL_IdBandeja = New Cdatos.bdcampo(CodigoEntidad & "IdBandeja", Cdatos.TiposCampo.Entero, 4)
            CUL_IdSemillero = New Cdatos.bdcampo(CodigoEntidad & "IdSemillero", Cdatos.TiposCampo.Entero, 4)
            CUL_Superficie = New Cdatos.bdcampo(CodigoEntidad & "Superficie", Cdatos.TiposCampo.Importe, 8)
            CUL_ProducEstimada = New Cdatos.bdcampo(CodigoEntidad & "ProduccionEstimada", Cdatos.TiposCampo.Importe, 8)
            CUL_ProducReal = New Cdatos.bdcampo(CodigoEntidad & "ProduccionReal", Cdatos.TiposCampo.Importe, 8)
            CUL_LineosMarcoPla = New Cdatos.bdcampo(CodigoEntidad & "LiuneosMarcoPlan", Cdatos.TiposCampo.Importe, 8)
            CUL_PlantasMarcoPla = New Cdatos.bdcampo(CodigoEntidad & "PlantaMarcoPla", Cdatos.TiposCampo.Importe, 8)
            CUL_NumPlantas = New Cdatos.bdcampo(CodigoEntidad & "NumPlantas", Cdatos.TiposCampo.Importe, 8)
            CUL_PlantasXalveolo = New Cdatos.bdcampo(CodigoEntidad & "PlantasXalVeolo", Cdatos.TiposCampo.Importe, 8)
            CUL_FechaSiembraProgra = New Cdatos.bdcampo(CodigoEntidad & "FechaSiembraProgra", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaSiembraReal = New Cdatos.bdcampo(CodigoEntidad & "FechaSiembraReal", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaRecoleProgra = New Cdatos.bdcampo(CodigoEntidad & "FechaRecoleProgra", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaRecoleReal = New Cdatos.bdcampo(CodigoEntidad & "FechaRecoleReal", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaFinalizaProgra = New Cdatos.bdcampo(CodigoEntidad & "FechaFinalizaProgra", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaFinalizaReal = New Cdatos.bdcampo(CodigoEntidad & "FechaFinalizaReal", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaCuajeProgra = New Cdatos.bdcampo(CodigoEntidad & "FechaCuajeProgra", Cdatos.TiposCampo.Fecha, 10)
            CUL_FechaCuajeReal = New Cdatos.bdcampo(CodigoEntidad & "FechaCuajeReal", Cdatos.TiposCampo.Fecha, 10)
            CUL_PartidaSemillero = New Cdatos.bdcampo(CodigoEntidad & "PartidaSemillero", Cdatos.TiposCampo.Cadena, 30)
            CUL_Bloquear = New Cdatos.bdcampo(CodigoEntidad & "Bloquear", Cdatos.TiposCampo.Cadena, 1)
            CUL_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "Observaciones", Cdatos.TiposCampo.Cadena, 50)
            CUL_IdProgCalidad2 = New Cdatos.bdcampo(CodigoEntidad & "IdProgCalidad2", Cdatos.TiposCampo.Cadena, 4)
            CUL_IdProgCalidad3 = New Cdatos.bdcampo(CodigoEntidad & "IdProgCalidad3", Cdatos.TiposCampo.Cadena, 4)
            CUL_DesdeFechaSeguridad = New Cdatos.bdcampo(CodigoEntidad & "DesdeFechaSeguridad", Cdatos.TiposCampo.Fecha, 10)
            CUL_DesdeHoraSeguridad = New Cdatos.bdcampo(CodigoEntidad & "DesdeHoraSeguridad", Cdatos.TiposCampo.Fecha, 10)
            CUL_HastaFechaSeguridad = New Cdatos.bdcampo(CodigoEntidad & "HastaFechaSeguridad", Cdatos.TiposCampo.Fecha, 10)
            CUL_HastaHoraSeguridad = New Cdatos.bdcampo(CodigoEntidad & "HastaHoraSeguridad", Cdatos.TiposCampo.Fecha, 10)
            CUL_IdSustratoCultivo = New Cdatos.bdcampo(CodigoEntidad & "IdSustratoCultivo", Cdatos.TiposCampo.Entero, 4)
            CUL_PlantaSm2 = New Cdatos.bdcampo(CodigoEntidad & "PlantaSm2", Cdatos.TiposCampo.Importe, 10, 2)
            CUL_Ucth = New Cdatos.bdcampo(CodigoEntidad & "Ucth", Cdatos.TiposCampo.Cadena, 10)

            CUL_Campa = New Cdatos.bdcampo(CodigoEntidad & "Campa", Cdatos.TiposCampo.Cadena, 5)
            CUL_Cultivo = New Cdatos.bdcampo(CodigoEntidad & "Cultivo", Cdatos.TiposCampo.Cadena, 10)

            CUL_TipoCultivo = New Cdatos.bdcampo(CodigoEntidad & "TipoCultivo", Cdatos.TiposCampo.EnteroPositivo, 10)
            CUL_Activo = New Cdatos.bdcampo(CodigoEntidad & "Activo", Cdatos.TiposCampo.Cadena, 1)


            CUL_IdPlanificacion = New Cdatos.bdcampo(CodigoEntidad & "IdPlanificacion", Cdatos.TiposCampo.EnteroPositivo, 10)
            CUL_Coeficiente = New Cdatos.bdcampo(CodigoEntidad & "Coeficiente", Cdatos.TiposCampo.Importe, 10, 2)
            CUL_IdTecnico = New Cdatos.bdcampo(CodigoEntidad & "IdTecnico", Cdatos.TiposCampo.EnteroPositivo, 5)

            CUL_CalidadEntradas = New Cdatos.bdcampo(CodigoEntidad & "CalidadEntradas", Cdatos.TiposCampo.Cadena, 1)

            CUL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CUL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CUL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error al crear la entidad ", "New", ex.Message)
        End Try

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Me.CUL_FechaSiembraProgra, "SiembraProgra")
        CONSULTA.SelCampo(Me.CUL_FechaSiembraReal, "SiembraReal")
        CONSULTA.SelCampo(Me.CUL_FechaCuajeProgra, "FechaCuajeProgramada")
        CONSULTA.SelCampo(Me.CUL_FechaCuajeReal, "FechaCuajeReal")
        CONSULTA.SelCampo(Me.CUL_FechaRecoleProgra, "FechaIniRecole")
        CONSULTA.SelCampo(Me.CUL_FechaRecoleReal, "FechaRecoleReal")
        CONSULTA.SelCampo(Me.CUL_FechaFinalizaProgra, "FechaFinaliProgra")
        CONSULTA.SelCampo(Me.CUL_FechaRecoleReal, "FechaRecoleReal")


    End Sub

End Class
