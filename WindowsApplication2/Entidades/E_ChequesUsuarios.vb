Public Class E_ChequesUsuarios
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public Password AS Cdatos.bdcampo
	Public Impresora AS Cdatos.bdcampo
	Public IdUsu AS Cdatos.bdcampo
	Public IMPRESORA2 AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "ChequesUsuarios"
            NombreBd = "CobrosPagos"
			MiConexion = conexion

            IdUsu = New Cdatos.bdcampo(CodigoEntidad & "IdUsu", Cdatos.TiposCampo.Entero, 10, , True)
            Password = New Cdatos.bdcampo(CodigoEntidad & "Password", Cdatos.TiposCampo.Cadena, 50)
			Impresora = New Cdatos.bdcampo(CodigoEntidad & "Impresora", Cdatos.TiposCampo.Cadena, 100)
			IMPRESORA2 = New Cdatos.bdcampo(CodigoEntidad & "IMPRESORA2", Cdatos.TiposCampo.Cadena, 100)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function BuscaUsuario(ByVal Nombre As String, ByVal pass As String) As Boolean

        Try

            Dim dt As DataTable = Nothing
            Dim resultado As Boolean = False

            Try
                dt = MiConexion.ConsultaSQL("Select IdUsu From ChequesUsuarios Where IdUsu ='" & Nombre & "' AND password='" & pass & "'")
                If dt.Rows.Count <= 0 Then
                    resultado = False
                ElseIf dt.Rows.Count > 0 Then
                    resultado = True
                End If

            Catch ex As Exception
                resultado = False
            End Try

            Return resultado


        Catch ex As Exception
            err.Muestraerror("No se encontro al usuario " & Nombre, "Function BuscaUsuario(ByVal Nombre As String,", ex.Message)
            Return False
        End Try

    End Function


    Public Function PermisoCuenta(ByVal cuenta As String, ByVal idusu As String) As Boolean

        Dim resultado As Boolean = False
        Dim s As String = "Select * FROM ChequesPermisos where IdCuenta='" & cuenta & "' AND IdUsuario='" & idusu & "'"

        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL(s)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0) IsNot DBNull.Value Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function


End Class
