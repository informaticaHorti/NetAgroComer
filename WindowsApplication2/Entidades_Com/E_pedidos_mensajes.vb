Public Class E_mensajesentidades
    Inherits Cdatos.Entidad

    Public PMJ_id As Cdatos.bdcampo
    Public PMJ_identidad As Cdatos.bdcampo
    Public PMJ_entidad As Cdatos.bdcampo
    Public PMJ_mensaje As Cdatos.bdcampo
    Public PMJ_fecha As Cdatos.bdcampo
    Public PMJ_hora As Cdatos.bdcampo
    Public PMJ_idusuarioDe As Cdatos.bdcampo
    Public PMJ_idusuarioPara As Cdatos.bdcampo
    Public PMJ_fechaleido As Cdatos.bdcampo
    Public PMJ_horaleido As Cdatos.bdcampo
    Public PMJ_idusuarioLeido As Cdatos.bdcampo
    Public PMJ_Referencia As Cdatos.bdcampo

    Public PMJ_IdUsuarioLog As Cdatos.bdcampo
    Public PMJ_FechaLog As Cdatos.bdcampo
    Public PMJ_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "mensajesentidades"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PMJ_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PMJ_identidad = New Cdatos.bdcampo(CodigoEntidad & "identidad", Cdatos.TiposCampo.EnteroPositivo, 6)
            PMJ_entidad = New Cdatos.bdcampo(CodigoEntidad & "entidad", Cdatos.TiposCampo.Cadena, 50)
            PMJ_mensaje = New Cdatos.bdcampo(CodigoEntidad & "mensaje", Cdatos.TiposCampo.Cadena, 50)
            PMJ_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            PMJ_hora = New Cdatos.bdcampo(CodigoEntidad & "hora", Cdatos.TiposCampo.Cadena, 10)
            PMJ_idusuarioDe = New Cdatos.bdcampo(CodigoEntidad & "idusuarioDe", Cdatos.TiposCampo.EnteroPositivo, 4)
            PMJ_idusuarioPara = New Cdatos.bdcampo(CodigoEntidad & "idusuarioPara", Cdatos.TiposCampo.EnteroPositivo, 4)
            PMJ_fechaleido = New Cdatos.bdcampo(CodigoEntidad & "fechaleido", Cdatos.TiposCampo.Fecha, 10)
            PMJ_horaleido = New Cdatos.bdcampo(CodigoEntidad & "horaleido", Cdatos.TiposCampo.Cadena, 10)
            PMJ_idusuarioleido = New Cdatos.bdcampo(CodigoEntidad & "idusuarioleido", Cdatos.TiposCampo.EnteroPositivo, 4)
            PMJ_Referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 50)

            PMJ_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PMJ_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PMJ_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function Pendientes(idusuario As Integer, Entidad As String, identidad As Integer) As Integer

        Dim ret As Integer

        Dim sql As String
        sql = "Select pmj_id from mensajesentidades where pmj_idusuariopara=" + idusuario.ToString + " and pmj_idusuarioleido=0 and pmj_entidad='" + Entidad + "' and pmj_identidad=" + identidad.ToString
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows.Count
            End If
        End If

        Return ret

    End Function



End Class
