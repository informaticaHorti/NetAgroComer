Public Class E_ChequesPermisos
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdPermiso AS Cdatos.bdcampo
	Public IdCuenta AS Cdatos.bdcampo
	Public Defecto AS Cdatos.bdcampo
	Public IdUsuario AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "ChequesPermisos"
            NombreBd = "CobrosPagos"
			MiConexion = conexion

			IdPermiso = New Cdatos.bdcampo(CodigoEntidad & "IdPermiso", Cdatos.TiposCampo.Entero, 10)
			IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "IdCuenta", Cdatos.TiposCampo.Cadena, 3)
            Defecto = New Cdatos.bdcampo(CodigoEntidad & "Defecto", Cdatos.TiposCampo.Entero, 1)
            Me.IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


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

    Public Function xCuentaxDefecto(ByVal idusu As Integer) As Integer
        Dim csql As String = ""
        Dim dt As New DataTable

        Dim ret As Integer = 1                   ' valor predeterminado

        csql = " select top 1 idcuenta "
        csql = csql & " from ChequesPermisos "
        csql = csql & " where IdUsuario='" & idusu & "' and defecto='1' "
        csql = csql & " order by idcuenta "
        dt = MiConexion.ConsultaSQL(csql)
        If dt.Rows.Count > 0 Then
            ret = FnVaInt(dt.Rows(0)(0).ToString)
        End If

        Return ret

    End Function

End Class
