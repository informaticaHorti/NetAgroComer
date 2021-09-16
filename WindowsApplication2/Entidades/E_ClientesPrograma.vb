Public Class E_ClientesPrograma
    Inherits Cdatos.Entidad

    Public CPR_id As Cdatos.bdcampo
    Public CPR_idcliente As Cdatos.bdcampo
    Public CPR_idprograma As Cdatos.bdcampo

    Public CPR_IdUsuarioLog As Cdatos.bdcampo
    Public CPR_FechaLog As Cdatos.bdcampo
    Public CPR_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ClientesPrograma"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CPR_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CPR_idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            CPR_idprograma = New Cdatos.bdcampo(CodigoEntidad & "idprograma", Cdatos.TiposCampo.EnteroPositivo, 2)

            CPR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CPR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CPR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function LeerCliente_programa(ByVal idcliente As String, ByVal idprograma As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select CPR_Id as Id from ClientesPrograma where CPR_Idcliente=" + idcliente + " and CPR_Idprograma=" + idprograma
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function

End Class
