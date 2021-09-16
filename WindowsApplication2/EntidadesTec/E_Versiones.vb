Public Class E_Versiones
    Inherits Cdatos.Entidad


    Public VER_Id As Cdatos.bdcampo
    Public VER_IdAgricultor As Cdatos.bdcampo
    Public VER_IdFamilia As Cdatos.bdcampo
    Public VER_Version As Cdatos.bdcampo

    Public VER_IdUsuarioLog As Cdatos.bdcampo
    Public VER_FechaLog As Cdatos.bdcampo
    Public VER_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            _DescripcionDocumental = "Versiones documentos"

            NombreTabla = "Versiones"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE TecnicosNet
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VER_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            VER_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.EnteroPositivo, 5)
            VER_IdFamilia = New Cdatos.bdcampo(CodigoEntidad & "IdFamilia", Cdatos.TiposCampo.EnteroPositivo, 4)
            VER_Version = New Cdatos.bdcampo(CodigoEntidad & "Version", Cdatos.TiposCampo.Cadena, 5)

            VER_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VER_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VER_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

       

    End Sub



    Public Function LeerVersionFamilia(IdAgricultor As String, IdFamilia As String) As Integer


        Dim ret As Integer = 0
        If VaInt(IdAgricultor) <> 0 Then

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelTodos(Me)
            CONSULTA.WheCampo(Me.VER_IdAgricultor, "=", VaInt(IdAgricultor).ToString)
            CONSULTA.WheCampo(Me.VER_IdFamilia, "=", VaInt(IdFamilia).ToString)

            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)(0) IsNot DBNull.Value Then
                        ret = VaInt(dt.Rows(0)(0))
                        CargaCampos(dt.Rows(0))
                    End If
                End If
            End If

        End If


        Return ret

    End Function



    Public Function LeerVersionActual(IdFamilia As String) As Integer


        Dim ret As Integer = 0


        If VaInt(IdFamilia) > 0 Then

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelTodos(Me)
            CONSULTA.WheCampo(Me.VER_IdAgricultor, "=", "0")
            CONSULTA.WheCampo(Me.VER_IdFamilia, "=", VaInt(IdFamilia).ToString)

            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)(0) IsNot DBNull.Value Then
                        ret = VaInt(dt.Rows(0)(0))
                        CargaCampos(dt.Rows(0))
                    End If
                End If
            End If

        End If



        Return ret

    End Function




End Class
