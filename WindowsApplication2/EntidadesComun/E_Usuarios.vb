Public Class E_Usuarios
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdUsuario AS Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Login As Cdatos.bdcampo
	Public Pw AS Cdatos.bdcampo
	Public IdPerfil AS Cdatos.bdcampo
    Public Nif As Cdatos.bdcampo
    Public CambioEjercicio As Cdatos.bdcampo
    Public CambioPV As Cdatos.bdcampo
    Public FotosSaldosAgricultores As Cdatos.bdcampo
    Public CambioCR As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Usuarios"
            NombreBd = "Comun"
			MiConexion = conexion

            Me.IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10, , True)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            Login = New Cdatos.bdcampo(CodigoEntidad & "Login", Cdatos.TiposCampo.Cadena, 30)
            Pw = New Cdatos.bdcampo(CodigoEntidad & "Pw", Cdatos.TiposCampo.Cadena, 15)
			IdPerfil = New Cdatos.bdcampo(CodigoEntidad & "IdPerfil", Cdatos.TiposCampo.Entero, 10)
            Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            CambioEjercicio = New Cdatos.bdcampo(CodigoEntidad & "CambioEjercicio", Cdatos.TiposCampo.Cadena, 1)
            CambioPV = New Cdatos.bdcampo(CodigoEntidad & "CambioPV", Cdatos.TiposCampo.Cadena, 1)
            FotosSaldosAgricultores = New Cdatos.bdcampo(CodigoEntidad & "FotosSaldosAgricultores", Cdatos.TiposCampo.Cadena, 1)
            CambioCR = New Cdatos.bdcampo(CodigoEntidad & "CambioCR", Cdatos.TiposCampo.Cadena, 1)


            MiListadeCampos = ListadeCampos()


            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select IdUsuario,Nombre from Usuarios WHERE IdUsuario > 0 order by Nombre"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdUsuario"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaUsuario"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Function BuscaUsuario(ByVal Login As String, ByVal pass As String, ByRef nIdPerfil As Integer, ByRef NombreUsuario As String) As Integer

        Dim resultado As Integer = 0

        Try

            'Dim dt As DataTable = MiConexion.ConsultaSQL("Select IdUsuario, IdPerfil From Usuarios Where Nombre='" & Nombre & "' AND pw='" & pass & "'")
            Dim dt As DataTable = MiConexion.ConsultaSQL("Select IdUsuario, IdPerfil, Nombre From Usuarios Where Login='" & Login & "' AND pw='" & pass & "'")
            If dt.Rows.Count > 0 Then
                resultado = VaInt(dt.Rows(0)("IdUsuario"))
                nIdPerfil = VaInt(dt.Rows(0)("IdPerfil"))
                NombreUsuario = (dt.Rows(0)("Nombre").ToString).Trim
            End If

            If resultado = 0 Then
                dt = MiConexion.ConsultaSQL("Select IdUsuario, IdPerfil, Nombre From Usuarios Where Nombre='" & Login & "' AND pw='" & pass & "'")
                If dt.Rows.Count > 0 Then
                    resultado = VaInt(dt.Rows(0)("IdUsuario"))
                    nIdPerfil = VaInt(dt.Rows(0)("IdPerfil"))
                    NombreUsuario = (dt.Rows(0)("Nombre").ToString).Trim
                End If
            End If


        Catch ex As Exception
            err.Muestraerror("No se encontro al usuario " & Login, "Function BuscaUsuario", ex.Message)
        End Try


        Return resultado

    End Function


    Public Function Tabla() As DataTable

        Dim dt As DataTable


        Try

            Dim sql As String = "SELECT IdUsuario, Nombre FROM Usuarios ORDER BY Nombre"
            dt = MiConexion.ConsultaSQL(sql)

        Catch ex As Exception
            dt = New DataTable
        End Try


        Return dt

    End Function


    


End Class
