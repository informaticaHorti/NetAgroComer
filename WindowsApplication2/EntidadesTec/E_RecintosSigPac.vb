Public Class E_RecintosSigPac

    Inherits Cdatos.Entidad

    Public REC_Id As Cdatos.bdcampo
    Public REC_IdFinca As Cdatos.bdcampo
    Public REC_IdNave As Cdatos.bdcampo
    Public REC_Provincia As Cdatos.bdcampo
    Public REC_Municipio As Cdatos.bdcampo
    Public REC_Poligono As Cdatos.bdcampo
    Public REC_Parcela As Cdatos.bdcampo
    Public REC_Recinto As Cdatos.bdcampo
    Public REC_SubRecinto As Cdatos.bdcampo
    Public REC_SuperficieSigPac As Cdatos.bdcampo
    Public REC_IdAgricultor As Cdatos.bdcampo
    Public REC_Tipo As Cdatos.bdcampo

    Public REC_IdUsuarioLog As Cdatos.bdcampo
    Public REC_FechaLog As Cdatos.bdcampo
    Public REC_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(IdUsuario)

        Try
            NombreTabla = "RecintosSigpac"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            REC_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Cadena, 10, , True)
            REC_IdFinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.Cadena, 5)
            REC_IdNave = New Cdatos.bdcampo(CodigoEntidad & "IdNave", Cdatos.TiposCampo.Cadena, 5)
            REC_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 2)
            REC_Municipio = New Cdatos.bdcampo(CodigoEntidad & "Municipio", Cdatos.TiposCampo.Cadena, 5)
            REC_Poligono = New Cdatos.bdcampo(CodigoEntidad & "Poligono", Cdatos.TiposCampo.Cadena, 3)
            REC_Parcela = New Cdatos.bdcampo(CodigoEntidad & "Parcela", Cdatos.TiposCampo.Cadena, 5)
            REC_Recinto = New Cdatos.bdcampo(CodigoEntidad & "Recinto", Cdatos.TiposCampo.Cadena, 5)
            REC_SuperficieSigPac = New Cdatos.bdcampo(CodigoEntidad & "SuperficieSigPac", Cdatos.TiposCampo.Importe, 8)
            REC_SubRecinto = New Cdatos.bdcampo(CodigoEntidad & "SubRecinto", Cdatos.TiposCampo.Cadena, 10)
            REC_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.Cadena, 5)
            REC_Tipo = New Cdatos.bdcampo(CodigoEntidad & "RegimenTenencia", Cdatos.TiposCampo.Cadena, 2)

            REC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            REC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            REC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error al crear la entidad ", "New", ex.Message)
        End Try

        

    End Sub


End Class
