Public Class E_CentrosUsuario
    Inherits Cdatos.Entidad

    Public Id As Cdatos.bdcampo
    Public IdUsuario As Cdatos.bdcampo
    Public IdCentro As Cdatos.bdcampo


    Dim err As Errores




    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CentrosUsuario"
            MiConexion = conexion
            NombreBd = "Comun"


            Me.Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 6, 0, True)
            Me.IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10, 0)
            Me.IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 2, 0)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function TablaCentrosUsuario(IdUsuario As String) As DataTable

        Dim dt As New DataTable


        If VaInt(IdUsuario) > 0 Then
            dt = MiConexion.ConsultaSQL("SELECT IdCentro FROM CentrosUsuario WHERE IdUsuario = " & IdUsuario & " ORDER BY IdCentro")
        End If


        Return dt

    End Function



    Public Sub BorrarCentrosUsuario(IdUsuario As Integer)

        If IdUsuario > 0 Then
            Dim sql As String = "DELETE FROM CentrosUsuario WHERE IdUsuario = " & IdUsuario.ToString
            MiConexion.OrdenSql(sql)
        End If

    End Sub


    Public Sub AñadirCentrosUsuario(IdUsuario As Integer, IdCentro As Integer)

        If IdUsuario > 0 And IdCentro > 0 Then

            Dim CentrosUsuario As New E_CentrosUsuario(IdUsuario, Cncomun)
            CentrosUsuario.Id.Valor = CentrosUsuario.MaxId
            CentrosUsuario.IdUsuario.Valor = IdUsuario.ToString
            CentrosUsuario.IdCentro.Valor = IdCentro.ToString
            CentrosUsuario.Insertar()

        End If

    End Sub







End Class
