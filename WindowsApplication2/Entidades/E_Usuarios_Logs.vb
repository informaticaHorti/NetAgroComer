Public Class E_Usuarios_Logs


    Inherits Cdatos.Entidad

    Public USL_Id As Cdatos.bdcampo
    Public USL_Idusuario As Cdatos.bdcampo
    Public USL_IdMaquina As Cdatos.bdcampo
    Public USL_IdCentro As Cdatos.bdcampo
    Public USL_Fecha As Cdatos.bdcampo
    Public USL_Hora As Cdatos.bdcampo
    Public USL_Activo As Cdatos.bdcampo
    Public USL_Aplicacion As Cdatos.bdcampo
    Public USL_usuario As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Usuarios_Logs"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            USL_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            USL_Idusuario = New Cdatos.bdcampo(CodigoEntidad & "Idusuario", Cdatos.TiposCampo.EnteroPositivo, 4)
            USL_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "Idcentro", Cdatos.TiposCampo.EnteroPositivo, 4)
            USL_IdMaquina = New Cdatos.bdcampo(CodigoEntidad & "Idmaquina", Cdatos.TiposCampo.Cadena, 25)
            USL_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            USL_Hora = New Cdatos.bdcampo(CodigoEntidad & "Hora", Cdatos.TiposCampo.Cadena, 8)
            USL_Activo = New Cdatos.bdcampo(CodigoEntidad & "Activo", Cdatos.TiposCampo.Cadena, 1)
            USL_Aplicacion = New Cdatos.bdcampo(CodigoEntidad & "Aplicacion", Cdatos.TiposCampo.Cadena, 20)
            USL_usuario = New Cdatos.bdcampo(CodigoEntidad & "Usuario", Cdatos.TiposCampo.Cadena, 25)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    

    Public Sub NuevoUsuario(Iduser As String, IdMaquina As String, Idcentro As String, Aplicacion As String, Usuario As String)
        ' busco si ya existe este usuario para este dia

        Try

            If IdMaquina = "" Then
                IdMaquina = ObtenerIpLocal()
            End If

            Dim sql As String
            Dim Fecha As String = Format(Now, "dd/MM/yyyy")
            Dim hora As String = Format(Now, "hh:mm:ss")

            'sql = "Select usl_id from usuarios_logs where usl_idusuario=" + Iduser + " and usl_fecha='" + Fecha + "'"
            sql = "SELECT USL_Id FROM Usuarios_Logs WHERE USL_IdUsuario = " & Iduser
            sql = sql & " AND USL_Fecha = '" & Fecha & "' AND USL_IdMaquina = '" & IdMaquina & "'"
            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count = 0 Then
                    Me.VaciaEntidad()
                    Dim id As String = Me.MaxId
                    Me.USL_Id.Valor = id
                    Me.USL_Idusuario.Valor = Iduser
                    Me.USL_IdMaquina.Valor = IdMaquina
                    Me.USL_IdCentro.Valor = Idcentro
                    Me.USL_Fecha.Valor = Fecha
                    Me.USL_Hora.Valor = hora
                    Me.USL_Activo.Valor = "S"
                    Me.USL_Aplicacion.Valor = Aplicacion
                    Me.USL_usuario.Valor = Usuario
                    Me.Insertar()
                ElseIf dt.Rows.Count > 0 Then
                    If Me.LeerId(dt.Rows(0)(0).ToString) = True Then
                        Me.USL_Hora.Valor = hora
                        Me.USL_Activo.Valor = "S"
                        Me.Actualizar()
                    End If
                End If
            End If


            Dim Nusu As Integer = UsuariosConectados(Fecha)
            If Nusu > PicoActual(Fecha) Then
                ActualizarPico(Fecha, hora, Nusu)
            End If

        Catch ex As Exception
            MsgBox("Error  en nuevo usuario")
        End Try


    End Sub


    Public Sub CierraUsuario(iduser As String)
        ' busco si ya existe este usuario para este dia
        Dim sql As String
        Dim Fecha As String = Format(Now, "dd/MM/yyyy")
        Dim hora As String = Format(Now, "hh:mm:ss")

        sql = "Select usl_id from usuarios_logs where usl_idusuario=" + iduser + " and usl_fecha='" + Fecha + "'"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If Me.LeerId(dt.Rows(0)(0).ToString) = True Then
                    Me.USL_Activo.Valor = "N"
                    Me.Actualizar()
                End If
            End If
        End If

    End Sub
    Private Function PicoActual(fecha As String) As Integer
        Dim sql As String
        Dim ret As Integer

        sql = "Select usl_usuario from usuarios_logs where usl_idusuario=0 and usl_fecha='" + fecha + "'"
        Dim dt0 As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt0 Is Nothing Then
            If dt0.Rows.Count > 0 Then
                ret = VaInt(dt0.Rows(0)(0))
            End If
        End If

        Return ret

    End Function

    Private Function UsuariosConectados(fecha As String) As Integer
        Dim sql As String
        Dim ret As Integer

        sql = "Select DISTINCT usl_idUSUARIO,USL_IDMAQUINA from usuarios_logs where usl_fecha='" + fecha + "' AND usl_activo='S' and usl_idusuario>0"
        Dim dt0 As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt0 Is Nothing Then
            ret = dt0.Rows.Count
        End If
        Return ret

    End Function

    Private Sub ActualizarPico(fecha As String, hora As String, usuarios As Integer)
        Dim sql As String
        Dim id0 As String = ""

        ' actualizar el registro de pico para este dia

        sql = "select usl_id from usuarios_logs where usl_idusuario=0 and usl_fecha='" + fecha + "'"
        Dim dt0 As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt0 Is Nothing Then
            If dt0.Rows.Count > 0 Then
                id0 = dt0.Rows(0)(0).ToString
            End If
        End If
        If VaInt(id0) = 0 Then
            Me.VaciaEntidad()
            id0 = Me.MaxId
            Me.USL_Id.Valor = id0
            Me.USL_Idusuario.Valor = "0"
            Me.USL_Fecha.Valor = fecha
            Me.USL_Hora.Valor = hora
            Me.USL_usuario.Valor = usuarios.ToString
            Me.Insertar()
        Else
            If Me.LeerId(id0) = True Then
                Me.USL_usuario.Valor = usuarios.ToString
                Me.Actualizar()
            End If
        End If

    End Sub

End Class
