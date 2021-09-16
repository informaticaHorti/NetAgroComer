Public Class E_tiposiva
    Inherits Cdatos.Entidad

    Public TIV_Id As Cdatos.bdcampo
    Public TIV_iva As Cdatos.bdcampo
    Public TIV_re As Cdatos.bdcampo

    Public TIV_IdUsuarioLog As Cdatos.bdcampo
    Public TIV_FechaLog As Cdatos.bdcampo
    Public TIV_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Tiposiva"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TIV_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            TIV_iva = New Cdatos.bdcampo(CodigoEntidad & "iva", Cdatos.TiposCampo.Importe, 6, 2)
            TIV_re = New Cdatos.bdcampo(CodigoEntidad & "re", Cdatos.TiposCampo.Importe, 6, 2)

            TIV_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TIV_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TIV_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select TIV_Id as Id, TIV_iva as iva, TIV_re as re from tiposiva order by TIV_Id")
        Return dt
    End Function


End Class
