Public Class E_albsalida_palets
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public ASP_Id As Cdatos.bdcampo
    Public ASP_IdAlbaran As Cdatos.bdcampo
    Public ASP_Idpalet As Cdatos.bdcampo

    Public ASP_IdUsuarioLog As Cdatos.bdcampo
    Public ASP_FechaLog As Cdatos.bdcampo
    Public ASP_HoraLog As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "albsalida_palets"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ASP_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, 0, True)
            ASP_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.Entero, 10)
            ASP_Idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.Entero, 10)

            ASP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ASP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ASP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function AlbaranPalet(ByVal idpalet As String) As String

        Dim ret As String = ""
        Dim sql As String

        sql = "Select ASP_idalbaran as idalbaran from albsalida_palets where ASP_idpalet=" + idpalet
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0).ToString
            End If
        End If
        Return ret

    End Function

End Class
