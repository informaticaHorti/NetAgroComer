Public Class E_AbonoEnvasesALH

    Inherits Cdatos.Entidad

    Public ABE_id As Cdatos.bdcampo
    Public ABE_idalbaran As Cdatos.bdcampo
    Public ABE_idenvase As Cdatos.bdcampo
    Public ABE_uds As Cdatos.bdcampo
    Public ABE_precio As Cdatos.bdcampo

    Public ABE_IdUsuarioLog As Cdatos.bdcampo
    Public ABE_FechaLog As Cdatos.bdcampo
    Public ABE_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "abonoenvasesalh"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ABE_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            ABE_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 10)
            ABE_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            ABE_uds = New Cdatos.bdcampo(CodigoEntidad & "uds", Cdatos.TiposCampo.Entero, 6)
            ABE_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 12, 6)

            ABE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ABE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ABE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function AbonoEnvases(idalbaran As String) As Decimal
        Dim ret As Decimal = 0

        Dim sql As String = "Select sum(abe_uds*abe_precio) from abonoenvasesalh where abe_idalbaran=" + idalbaran
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)(0))
            End If
        End If

        Return ret

    End Function

End Class
