Public Class E_BloqueoLineaFecha

    Inherits Cdatos.Entidad
    Public BLF_Id As Cdatos.bdcampo
    Public BLF_Fecha As Cdatos.bdcampo
    Public BLF_IdLinea As Cdatos.bdcampo
    Public BLF_IdUsuario As Cdatos.bdcampo

    Public BLF_IdUsuarioLog As Cdatos.bdcampo
    Public BLF_FechaLog As Cdatos.bdcampo
    Public BLF_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "BloqueoLineaFecha"
            NombreBd = "NetAgroComer"
            MiConexion = conexion


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            BLF_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 3, 0, True)
            BLF_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            BLF_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 4)
            BLF_IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10)

            BLF_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            BLF_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            BLF_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try



    End Sub


    Public Function CargaConfiguracion() As List(Of String)

        Dim lst As New List(Of String)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Me.BLF_IdLinea, "IdLinea")
        CONSULTA.WheCampo(Me.BLF_Fecha, "=", VaDate("").ToString("dd/MM/yyyy"))
        CONSULTA.WheCampo(Me.BLF_IdUsuario, "=", Idusuario.ToString)


        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " ORDER BY BLF_Id"


        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows

                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                If VaInt(IdLinea) > 0 Then
                    lst.Add(IdLinea)
                End If

            Next
        End If


        Return lst

    End Function



    Public Sub GuardaConfiguracion(lst As List(Of String))

        Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)

        Dim sql As String = "DELETE FROM BloqueoLineaFecha WHERE BLF_IdUsuario = " & Idusuario.ToString & " AND BLF_Fecha = '01/01/1900'"
        BloqueoLineaFecha.MiConexion.ConsultaSQL(sql)


        For Each IdLinea As String In lst

            BloqueoLineaFecha = New E_BloqueoLineaFecha(Idusuario, cn)
            BloqueoLineaFecha.BLF_Id.Valor = BloqueoLineaFecha.MaxId()
            BloqueoLineaFecha.BLF_Fecha.Valor = VaDate("").ToString("dd/MM/yyyy")
            BloqueoLineaFecha.BLF_IdLinea.Valor = IdLinea
            BloqueoLineaFecha.BLF_IdUsuario.Valor = Idusuario.ToString
            BloqueoLineaFecha.Insertar()

        Next

    End Sub



    Public Function LeerPorLineaFecha(IdLinea As String, Fecha As String,
                                      Optional IdUsuario As String = "") As Integer

        Dim res As Integer = 0

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelTodos(Me)
        CONSULTA.WheCampo(Me.BLF_Fecha, "=", Fecha)
        CONSULTA.WheCampo(Me.BLF_IdLinea, "=", IdLinea)
        If VaInt(IdUsuario) > 0 Then CONSULTA.WheCampo(Me.BLF_IdUsuario, "=", IdUsuario)

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    res = dt.Rows(0)(0)
                    CargaCampos(dt.Rows(0))
                End If
            End If
        End If


        Return res

    End Function


End Class
