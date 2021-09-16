Public Class E_UsuariosWeb
    Inherits Cdatos.Entidad

    Public UWB_Id As Cdatos.bdcampo
    Public UWB_Codigo As Cdatos.bdcampo
    Public UWB_Linea As Cdatos.bdcampo
    Public UWB_IdAgricultor As Cdatos.bdcampo
    Public UWB_Password As Cdatos.bdcampo

    Public UWB_IdUsuarioLog As Cdatos.bdcampo
    Public UWB_FechaLog As Cdatos.bdcampo
    Public UWB_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "UsuariosWeb"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            UWB_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            UWB_Codigo = New Cdatos.bdcampo(CodigoEntidad & "Codigo", Cdatos.TiposCampo.EnteroPositivo, 5)
            UWB_Linea = New Cdatos.bdcampo(CodigoEntidad & "Linea", Cdatos.TiposCampo.EnteroPositivo, 10)
            UWB_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.EnteroPositivo, 5)
            UWB_Password = New Cdatos.bdcampo(CodigoEntidad & "Password", Cdatos.TiposCampo.Cadena, 15)

            UWB_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            UWB_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            UWB_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function LeerUsuario(Codigo As String) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.UWB_Codigo, "=", Codigo)
        CONSULTA.WheCampo(Me.UWB_Linea, "=", "0")

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


    Public Function EstaAsociado(IdAgricultor As String) As String

        Dim Codigo As String = ""


        If VaInt(IdAgricultor) > 0 Then

            Dim sql As String = "SELECT UWB_Codigo as Codigo FROM UsuariosWeb WHERE UWB_IdAgricultor = " & IdAgricultor & " AND UWB_Linea > 0"
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Codigo = (dt.Rows(0)("Codigo").ToString & "").Trim
                End If
            End If


        End If



        Return Codigo

    End Function


End Class
