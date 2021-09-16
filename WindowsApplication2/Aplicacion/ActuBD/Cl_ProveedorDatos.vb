Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports NetAgro.Constructor

Namespace ProveedorDatos

    Public Class Cl_ProveedorDatos

        'Variables miembro y propiedades
        Protected _TipoConexion As Tipo_Conexion = Tipo_Conexion.SqlServer
        Protected _TipoProveedor As Tipo_Proveedor = Tipo_Proveedor.OleDb
        Protected _CadenaConexion As String = ""
        Protected _Cn As Common.DbConnection = Nothing
        Protected _constructor As Cl_ConstructorConsultas = Nothing
        Protected _bErrorConexion As Boolean = False

        Public Property TipoProveedor As Tipo_Proveedor
            Set(ByVal value As Tipo_Proveedor)
                _TipoProveedor = value
            End Set
            Get
                Return _TipoProveedor
            End Get
        End Property

        Public Property TipoConexion As Tipo_Conexion
            Set(ByVal value As Tipo_Conexion)
                _TipoConexion = value
            End Set
            Get
                Return _TipoConexion
            End Get
        End Property

        Public Property CadenaConexion As String
            Set(ByVal value As String)
                _CadenaConexion = value
            End Set
            Get
                Return _CadenaConexion
            End Get
        End Property

        Public ReadOnly Property ErrorConexion As String
            Get
                Return _bErrorConexion
            End Get
        End Property

        ' obtengo la conexion según el tipo de conexion; error si no está implementada
        Public Sub New(ByVal TipoConexion As Tipo_Conexion, ByVal TipoProveedor As Tipo_Proveedor, _
                       ByVal conexion As String, ByVal constructor As Cl_ConstructorConsultas)

            _TipoConexion = TipoConexion
            _TipoProveedor = TipoProveedor
            _CadenaConexion = conexion
            _constructor = constructor

            Select Case _TipoConexion

                Case Tipo_Conexion.SqlServer
                    Select Case _TipoProveedor
                        Case Tipo_Proveedor.Odbc
                            _Cn = New System.Data.Odbc.OdbcConnection(conexion)
                            Dim cmd As New OdbcCommand("", _Cn)
                        Case Tipo_Proveedor.OleDb
                            _Cn = New OleDbConnection(conexion)
                            Dim cmd As New OleDb.OleDbCommand("", _Cn)
                        Case Tipo_Proveedor.SqlClient
                            _Cn = New sqlConnection(conexion)
                            Dim cmd As New SqlCommand("", _Cn)
                    End Select

                Case Tipo_Conexion.Firebird
                    Select Case _TipoProveedor
                        Case Tipo_Proveedor.Odbc
                            _Cn = New System.Data.Odbc.OdbcConnection(conexion)
                            Dim cmd As New OdbcCommand("", _Cn)
                        Case Else
                            Throw New ExcepcionActualizacion("Tipo de proveedor no implementado para la conexión: " & TipoConexion.ToString())
                    End Select

                Case Tipo_Conexion.Pervasive
                    Select Case _TipoProveedor
                        Case Tipo_Proveedor.OleDb
                            _Cn = New OleDbConnection(conexion)
                            Dim cmd As New OleDbCommand("", _Cn)
                        Case Else
                            Throw New ExcepcionActualizacion("Tipo de proveedor no implementado para la conexión: " & TipoConexion.ToString())
                    End Select

                Case Else
                    Throw New ExcepcionActualizacion("Tipo de conexión no implementada: " & TipoConexion.ToString())

            End Select

            'Abre la conexión
            If _Cn.State = ConnectionState.Open Then _Cn.Close()

            Try
                _Cn.Open()

            Catch ex As Exception
                _bErrorConexion = True
                MsgBox("No se puede abrir la conexión " & _Cn.Database)
            End Try

        End Sub

        ''' <summary>
        ''' Obtiene un objeto DataTable de la consulta efectuada según 
        ''' el tipo de proveedor y para el tipo de conexión establecido
        ''' </summary>
        ''' <param name="sql">Comando sql</param>
        ''' <returns>Objeto DataTable</returns>
        ''' <remarks></remarks>
        Public Function ObtenerTabla(ByVal sql As String) As DataTable

            Dim dt As DataTable = Nothing

            ' según el tipo de proveedor!
            Select Case _TipoProveedor

                Case Tipo_Proveedor.Odbc
                    dt = ObtenerTablaODBC(sql)
                Case Tipo_Proveedor.OleDb
                    dt = ObtenerTablaOLEDB(sql)
                Case Tipo_Proveedor.SqlClient
                    dt = ObtenerTablaSqlClient(sql)

            End Select

            Return dt

        End Function

        Public Function EjecutarComando(ByVal sql As String) As Integer

            Dim filas As Integer = 0

            ' segun el tipo de proveedor!
            Select Case _TipoProveedor

                Case Tipo_Proveedor.Odbc
                    filas = EjecutarComandoODBC(sql)
                Case Tipo_Proveedor.OleDb
                    filas = EjecutarComandoOLEDB(sql)
                Case Tipo_Proveedor.SqlClient
                    filas = EjecutarComandoSqlClient(sql)

            End Select

            Return filas

        End Function

        Public Function EjecutarEscalar(ByVal sql As String) As Object

            Dim resultado As Object = Nothing

            ' segun el tipo de proveedor!
            Select Case _TipoProveedor
                Case Tipo_Proveedor.Odbc
                    resultado = EjecutarEscalarODBC(sql)
                Case Tipo_Proveedor.OleDb
                    resultado = EjecutarEscalarOLEDB(sql)
                Case Tipo_Proveedor.SqlClient
                    resultado = EjecutarEscalarSqlClient(sql)

            End Select

            Return resultado

        End Function

        Protected Function ObtenerTabla(ByVal cmd As Common.DbCommand) As DataTable

            Dim dt As New DataTable
            Dim dr As Common.DbDataReader = cmd.ExecuteReader()

            Try
                dt.Load(dr)
            Catch ex As ConstraintException
                Dim a As String = ""
            End Try

            Return dt

        End Function

        Protected Function ObtenerTablaOLEDB(ByVal sql As String)

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, _Cn)
            Return ObtenerTabla(CType(cmd, Common.DbCommand))

        End Function

        Protected Function ObtenerTablaODBC(ByVal sql As String)

            Dim cmd As Odbc.OdbcCommand = New Odbc.OdbcCommand(sql, _Cn)
            Return ObtenerTabla(CType(cmd, Common.DbCommand))

        End Function

        Protected Function ObtenerTablaSqlClient(ByVal sql As String)

            Dim cmd As SqlCommand = New SqlCommand(sql, _Cn)
            Return ObtenerTabla(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarComando(ByVal cmd As Common.DbCommand)

            Return cmd.ExecuteNonQuery()

        End Function

        Protected Function EjecutarComandoOLEDB(ByVal sql As String)

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, _Cn)
            Return EjecutarComando(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarComandoODBC(ByVal sql As String)

            Dim cmd As OdbcCommand = New Odbc.OdbcCommand(sql, _Cn)
            Return EjecutarComando(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarComandoSqlClient(ByVal sql As String)

            Dim cmd As SqlCommand = New SqlCommand(sql, _Cn)
            Return EjecutarComando(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarEscalar(ByVal cmd As Common.DbCommand) As Object

            Return cmd.ExecuteScalar()

        End Function

        Protected Function EjecutarEscalarOLEDB(ByVal sql As String) As Object

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, _Cn)
            Return EjecutarEscalar(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarEscalarODBC(ByVal sql As String) As Object

            Dim cmd As Odbc.OdbcCommand = New Odbc.OdbcCommand(sql, _Cn)
            Return EjecutarEscalar(CType(cmd, Common.DbCommand))

        End Function

        Protected Function EjecutarEscalarSqlClient(ByVal sql As String) As Object

            Dim cmd As SqlCommand = New SqlCommand(sql, _Cn)
            Return EjecutarEscalar(CType(cmd, Common.DbCommand))

        End Function

#Region "Schemas"

        ''' <summary>
        ''' Comprueba si existe un campo en una tabla de Pervasive
        ''' </summary>
        ''' <param name="nombre_tabla">Nombre de la tabla</param>
        ''' <param name="nombre_campo">Nombre del campo</param>
        ''' <returns>Verdadero o falso</returns>
        ''' <remarks></remarks>
        Public Function ExisteCampoPervasive(ByVal nombre_tabla As String, ByVal nombre_campo As String) As Boolean

            Dim bRes As Boolean = False

            Dim dt As DataTable = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, nombre_tabla.ToLower()})
            If dt.Rows.Count = 0 Then dt = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, nombre_tabla.ToUpper()})

            For Each row In dt.Rows
                Dim nombre_columna As String = row("COLUMN_NAME").ToString() & ""
                If nombre_columna.ToLower().Trim() = nombre_campo.ToLower().Trim() Then
                    bRes = True
                    Exit For
                End If
            Next


            dt.Dispose()

            Return bRes

        End Function


        ''' <summary>
        ''' Comprueba si existe una tabla en la base de datos de pervasive
        ''' </summary>
        ''' <param name="nombre_tabla">Nombre de la tabla</param>
        ''' <returns>Verdadero o falso</returns>
        ''' <remarks></remarks>
        Public Function ExisteTablaPervasive(ByVal nombre_tabla As String) As Boolean

            Dim bRes As Boolean = False

            Dim dt As DataTable = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, Nothing})

            For Each row In dt.Rows
                Dim tabla As String = row("TABLE_NAME").ToString() & ""
                If tabla.ToLower().Trim() = nombre_tabla.ToLower().Trim() Then
                    bRes = True
                    Exit For
                End If
            Next


            dt.Dispose()

            Return bRes


        End Function


        ''' <summary>
        ''' Obtiene la longitud de un campo en una tabla de Pervasive
        ''' </summary>
        ''' <param name="nombre_tabla">Nombre de la tabla</param>
        ''' <param name="nombre_campo">Nombre del campo</param>
        ''' <returns>Devuelve un entero con la longitud</returns>
        ''' <remarks>En pervasive esta función debe realizarse mediante un schema</remarks>
        Public Function ObtenerLongitudCampoPervasive(ByVal nombre_tabla As String, ByVal nombre_campo As String) As Integer

            Dim nLongitud As Integer = -1

            Dim dt As DataTable = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, nombre_tabla.ToLower()})
            If dt.Rows.Count = 0 Then CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, nombre_tabla.ToUpper()})


            For Each row In dt.Rows
                Dim nombre_columna As String = row("COLUMN_NAME").ToString() & ""
                If nombre_columna.ToLower().Trim() = nombre_campo.ToLower().Trim() Then
                    If row("DATA_TYPE") = 129 Then
                        Dim cLongitud As String = (row("CHARACTER_MAXIMUM_LENGTH") & "").ToString()
                        If Not Integer.TryParse(cLongitud, nLongitud) Or cLongitud.Trim = "" Then nLongitud = -1
                    End If

                    Exit For
                End If
            Next


            dt.Dispose()


            If nLongitud = -1 Then Throw New ExcepcionActualizacion("Error al obtener la longitud del campo " & nombre_campo & _
                " de la tabla " & nombre_tabla)

            Return nLongitud

        End Function


        ''' <summary>
        ''' Devuelve si existe o no un indice en una tabla de Pervasive
        ''' </summary>
        ''' <param name="nombre_tabla">Nombre de la tabla</param>
        ''' <param name="nombre_indice">Nombre del índice</param>
        ''' <returns>True o False</returns>
        ''' <remarks>En Pervasive, esta función ha de realizarse mediante un schema</remarks>
        Public Function ExisteConstraintPVS(ByVal nombre_tabla As String, ByVal nombre_indice As String) As Boolean

            Dim bRes As Boolean = False

            Dim dt As DataTable = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, New Object() {Nothing, Nothing, Nothing, Nothing, nombre_tabla.ToLower()})
            If dt.Rows.Count = 0 Then CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, New Object() {Nothing, Nothing, Nothing, Nothing, nombre_tabla.ToUpper()})


            For Each row In dt.Rows
                Dim indice As String = row("INDEX_NAME").ToString() & ""
                If indice.ToLower().Trim() = nombre_indice.ToLower().Trim() Then
                    bRes = True
                    Exit For
                End If
            Next

            dt.Dispose()



            Return bRes

        End Function




        'TODO: Comprobar. No se conecta Postgre vía ODBC??
        Public Function ExisteCampoPostgre8(ByVal nombre_tabla As String, ByVal nombre_campo As String) As Boolean

            Dim bRes As Boolean = False

            Dim dt As DataTable = CType(_Cn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, nombre_tabla})
            For Each row In dt.Rows
                Dim nombre_columna As String = row("COLUMN_NAME").ToString() & ""
                If nombre_columna.ToLower().Trim() = nombre_campo.ToLower().Trim() Then
                    bRes = True
                    Exit For
                End If
            Next


            Return bRes

        End Function




#End Region

        Public Sub Dispose()

            If _Cn.State = ConnectionState.Open Then _Cn.Close()

        End Sub

    End Class



End Namespace


