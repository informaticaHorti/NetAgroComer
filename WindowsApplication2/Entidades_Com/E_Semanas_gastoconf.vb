Public Class E_Semanas_gastoconf
    Inherits Cdatos.Entidad

    Public SGK_id As Cdatos.bdcampo
    Public SGK_idsemana As Cdatos.bdcampo
    Public SGK_idgenero As Cdatos.bdcampo
    Public SGK_gasto As Cdatos.bdcampo

    Public SGK_IdUsuarioLog As Cdatos.bdcampo
    Public SGK_FechaLog As Cdatos.bdcampo
    Public SGK_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "semanas_gastoconf"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            SGK_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            SGK_idsemana = New Cdatos.bdcampo(CodigoEntidad & "idsemana", Cdatos.TiposCampo.EnteroPositivo, 6)
            SGK_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            SGK_gasto = New Cdatos.bdcampo(CodigoEntidad & "gasto", Cdatos.TiposCampo.Importe, 10, 4)
 
            SGK_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            SGK_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            SGK_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Public Function GastoGenero(idsemana As Integer, idgenero As Integer) As Decimal
        Dim ret As Decimal

        Dim sql As String = "Select SGK_gasto as Gasto from semanas_gastoconf where sgk_idsemana=" + idsemana.ToString + " and sgk_idgenero=" + idgenero.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("Gasto"))
            End If
        End If
        Return ret

    End Function

    Public Function LeerGasto(idsemana As Integer, idgenero As Integer) As Integer
        Dim ret As Integer

        Dim sql As String = "Select SGK_id as id from semanas_gastoconf where sgk_idsemana=" + idsemana.ToString + " and sgk_idgenero=" + idgenero.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaDec(dt.Rows(0)("Id"))
            End If
        End If
        Return ret

    End Function

End Class
