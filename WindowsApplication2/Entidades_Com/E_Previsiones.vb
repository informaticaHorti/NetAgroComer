Public Class E_Previsiones


    Inherits Cdatos.Entidad

    Public PVR_idprevision As Cdatos.bdcampo
    Public PVR_idagricultor As Cdatos.bdcampo
    Public PVR_fecha As Cdatos.bdcampo
    Public PVR_observaciones As Cdatos.bdcampo

    Public PVR_IdUsuarioLog As Cdatos.bdcampo
    Public PVR_FechaLog As Cdatos.bdcampo
    Public PVR_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Previsiones"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PVR_idprevision = New Cdatos.bdcampo(CodigoEntidad & "idprevision", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PVR_idagricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.Entero, 5)
            PVR_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            PVR_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)

            PVR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PVR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PVR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


 

    End Sub

    Public Function LeerPrevision(ByVal idagricultor As Integer, ByVal Fecha As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PVR_idagricultor, "=", idagricultor.ToString)
        CONSULTA.WheCampo(Me.PVR_fecha, "=", Fecha)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                    CargaCampos(Dt.Rows(0))
                End If
            End If
        End If
        Return ret
    End Function




End Class
