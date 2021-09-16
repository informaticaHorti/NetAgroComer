Public Class E_albentrada_gastos
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public AEG_Id As Cdatos.bdcampo
    Public AEG_IdAlbaran As Cdatos.bdcampo
    Public AEG_IdGasto As Cdatos.bdcampo
    Public AEG_Gasto As Cdatos.bdcampo
    Public AEG_Tipo As Cdatos.bdcampo
    Public AEG_IdAcreedor As Cdatos.bdcampo
    Public AEG_TipoFC As Cdatos.bdcampo

    Public AEG_IdUsuarioLog As Cdatos.bdcampo
    Public AEG_FechaLog As Cdatos.bdcampo
    Public AEG_HoraLog As Cdatos.bdcampo

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "albentrada_gastos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            AEG_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, 0, True)
            AEG_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.Entero, 5)
            AEG_IdGasto = New Cdatos.bdcampo(CodigoEntidad & "idgasto", Cdatos.TiposCampo.Entero, 10)
            AEG_Gasto = New Cdatos.bdcampo(CodigoEntidad & "gasto", Cdatos.TiposCampo.Importe, 18, 4)
            AEG_Tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)
            AEG_IdAcreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5)
            AEG_TipoFC = New Cdatos.bdcampo(CodigoEntidad & "tipofc", Cdatos.TiposCampo.Cadena, 1)

            AEG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AEG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
