Public Class E_LogTablas
    Inherits Cdatos.Entidad

    Public LOT_Tabla As Cdatos.bdcampo
    Public LOT_LogSN As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "LogTablas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LOT_Tabla = New Cdatos.bdcampo(CodigoEntidad & "Tabla", Cdatos.TiposCampo.Cadena, 50, 0, True)
            LOT_LogSN = New Cdatos.bdcampo(CodigoEntidad & "LogSN", Cdatos.TiposCampo.Cadena, 1)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function Tablas() As DataTable

        Dim dt As DataTable

        Try

            Dim sql As String = "SELECT LOT_Tabla as Tabla, LOT_LogSN as LogSN FROM LogTablas ORDER BY LOT_TABLA"
            dt = MiConexion.ConsultaSQL(Sql)

        Catch ex As Exception
            dt = New DataTable
            err.Muestraerror("Error al obtener las tablas para loguear", "E_LogTablas.Tablas", ex.Message)
        End Try


        Return dt

    End Function


    Public Function NoRegistrarTablas() As Boolean

        Dim bRes As Boolean = True


        Try

            Dim sql As String = "DELETE FROM LogTablas"
            MiConexion.OrdenSql(sql)

        Catch ex As Exception
            bRes = False
        End Try


        Return bRes

    End Function


    Public Function RegistrarTabla(Tabla As String) As Boolean

        Dim bRes As Boolean = True

        Try

            Dim LogTabla As New E_LogTablas(Idusuario, cn)
            LogTabla.LOT_Tabla.Valor = Tabla.Trim.ToLower
            LogTabla.LOT_LogSN.Valor = "S"
            LogTabla.Insertar()

        Catch ex As Exception
            bRes = False
        End Try


        Return bRes

    End Function


End Class
