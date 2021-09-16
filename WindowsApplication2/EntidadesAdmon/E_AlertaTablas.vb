Public Class E_AlertaTablas
    Inherits Cdatos.Entidad

    Public ALT_Tabla As Cdatos.bdcampo
    Public ALT_SN As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "AlertaTablas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ALT_Tabla = New Cdatos.bdcampo(CodigoEntidad & "Tabla", Cdatos.TiposCampo.Cadena, 50, 0, True)
            ALT_SN = New Cdatos.bdcampo(CodigoEntidad & "SN", Cdatos.TiposCampo.Cadena, 1)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function Tablas() As DataTable

        Dim dt As DataTable

        Try

            Dim sql As String = "SELECT ALT_Tabla as Tabla, ALT_SN as LOGSN FROM AlertaTablas ORDER BY ALT_TABLA"
            dt = MiConexion.ConsultaSQL(sql)

        Catch ex As Exception
            dt = New DataTable
            err.Muestraerror("Error al obtener las tablas para loguear", "E_AlertaTablas.Tablas", ex.Message)
        End Try


        Return dt

    End Function


    Public Function NoRegistrarTablas() As Boolean

        Dim bRes As Boolean = True


        Try

            Dim sql As String = "DELETE FROM AlertaTablas"
            MiConexion.OrdenSql(sql)

        Catch ex As Exception
            bRes = False
        End Try


        Return bRes

    End Function


    Public Function RegistrarTabla(ByVal Tabla As String) As Boolean

        Dim bRes As Boolean = True

        Try

            Dim alertaTabla As New E_AlertaTablas(Idusuario, cn)
            alertaTabla.ALT_Tabla.Valor = Tabla.Trim.ToLower
            alertaTabla.ALT_SN.Valor = "S"
            alertaTabla.Insertar()

        Catch ex As Exception
            bRes = False
        End Try


        Return bRes

    End Function


End Class
