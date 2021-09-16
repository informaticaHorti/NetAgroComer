Public Class E_Acreedores_gastos

    Inherits Cdatos.Entidad

    Public ACG_Id As Cdatos.bdcampo
    Public ACG_Idacreedor As Cdatos.bdcampo
    Public ACG_Idorigengasto As Cdatos.bdcampo

    Public ACG_IdUsuarioLog As Cdatos.bdcampo
    Public ACG_FechaLog As Cdatos.bdcampo
    Public ACG_HoraLog As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Acreedores_Gastos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ACG_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            ACG_Idacreedor = New Cdatos.bdcampo(CodigoEntidad & "IdAcreedor", Cdatos.TiposCampo.EnteroPositivo, 5, 0)
            ACG_Idorigengasto = New Cdatos.bdcampo(CodigoEntidad & "IdOrigenGasto", Cdatos.TiposCampo.EnteroPositivo, 3, 0)

            ACG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ACG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ACG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function LeerAcreedor_Origen(ByVal idacreedor As String, ByVal idorigen As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select ACG_Id as Id from Acreedores_Gastos where ACG_IdAcreedor=" + idacreedor + " and ACG_IdOrigenGasto=" + idorigen
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function
End Class
