Public Class E_Paises
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdPais AS Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
	Public Siglas AS Cdatos.bdcampo
	Public Comunitario AS Cdatos.bdcampo
	Public IdIdioma AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "Paises"
            NombreBd = "Comun"
			MiConexion = conexion

            IdPais = New Cdatos.bdcampo(CodigoEntidad & "IdPais", Cdatos.TiposCampo.Entero, 10, , True)
			Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
			Siglas = New Cdatos.bdcampo(CodigoEntidad & "Siglas", Cdatos.TiposCampo.Cadena, 3)
			Comunitario = New Cdatos.bdcampo(CodigoEntidad & "Comunitario", Cdatos.TiposCampo.Cadena, 1)
			IdIdioma = New Cdatos.bdcampo(CodigoEntidad & "IdIdioma", Cdatos.TiposCampo.Entero, 10)

            MiListadeCampos = ListadeCampos()


            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select idPais,nombre, siglas from paises"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idpais"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaPais"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Function Tabla() As DataTable

        Dim dt As DataTable


        Try

            Dim sql As String = "SELECT IdPais as Id, Nombre FROM Paises"
            dt = MiConexion.ConsultaSQL(sql)

        Catch ex As Exception
            dt = New DataTable
            err.Muestraerror("Error al obtener los países", "E_Paises.Tabla", ex.Message)
        End Try


        Return dt

    End Function


    Public Function NacionalExportacionTodos() As DataTable

        Try

            Dim dt As New DataTable
            dt.Columns.Add(New DataColumn("Id", GetType(Int32)))
            dt.Columns.Add(New DataColumn("Nombre", GetType(String)))

            Dim row As DataRow = dt.NewRow()
            row("Id") = 0
            row("Nombre") = "Todos"
            dt.Rows.Add(row)

            row = dt.NewRow()
            row("Id") = 1
            row("Nombre") = "Nacional"
            dt.Rows.Add(row)

            row = dt.NewRow()
            row("Id") = 2
            row("Nombre") = "Exportación"
            dt.Rows.Add(row)

            Return dt

        Catch ex As Exception
            Return New DataTable
        End Try


    End Function


End Class
