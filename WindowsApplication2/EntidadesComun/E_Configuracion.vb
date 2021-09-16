Public Class E_Configuracion

    Inherits Cdatos.Entidad

    Public IdConfiguracion As Cdatos.bdcampo
    Public IdPerfil As Cdatos.bdcampo
    Public IdAplicacion As Cdatos.bdcampo
    Public IdUsuario As Cdatos.bdcampo
    Public Formulario As Cdatos.bdcampo
    Public Xml As Cdatos.bdcampo
    Public NombreConfiguracion As Cdatos.bdcampo
    Public Version As Cdatos.bdcampo
    'Public XmlDefectoSN As Cdatos.bdcampo


    Private err As Errores



    Public Sub New()

        Me.New(0, Nothing)

    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Configuracion"
            MiConexion = conexion
            NombreBd = "Comun"


            Me.IdConfiguracion = New Cdatos.bdcampo("IdConfiguracion", Cdatos.TiposCampo.Entero, 10, 0, True)
            Me.IdPerfil = New Cdatos.bdcampo("IdPerfil", Cdatos.TiposCampo.Entero, 3, 0)
            Me.IdAplicacion = New Cdatos.bdcampo("IdAplicacion", Cdatos.TiposCampo.Entero, 3, 0)
            Me.IdUsuario = New Cdatos.bdcampo("IdUsuario", Cdatos.TiposCampo.Entero, 10, 0)
            Me.Formulario = New Cdatos.bdcampo("Formulario", Cdatos.TiposCampo.Cadena, 500)
            Me.Xml = New Cdatos.bdcampo("Xml", Cdatos.TiposCampo.Cadena, 999999999)
            Me.NombreConfiguracion = New Cdatos.bdcampo("NombreConfiguracion", Cdatos.TiposCampo.Cadena, 100)
            Me.Version = New Cdatos.bdcampo("Version", Cdatos.TiposCampo.Cadena, 50)
            'Me.XmlDefectoSN = New Cdatos.bdcampo("XmlDefectoSN", Cdatos.TiposCampo.Cadena, 1)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub



    Public Function ObtenerConfiguracion(ByVal IdUsuario As Integer, ByVal Formulario As String, ByVal NombreConfiguracion As String, ByVal Todos As Boolean) As DataTable


        Dim dt As New DataTable

        Try
            Dim maestro As String = "0." & Formulario
            'Formulario = IdUsuario.ToString & "." & Formulario
            Dim sql As String = ""

            'Dim sql As String = "SELECT IdConfiguracion, Xml, NombreConfiguracion FROM Configuracion WHERE (IdUsuario = " & IdUsuario.ToString() & " OR IdUsuario = 0)" & _
            '    " AND (Formulario = '" & Formulario & "' OR Formulario = '" & maestro & "')"
            'If Not Todos Then sql = sql & " AND NombreConfiguracion = '" & NombreConfiguracion & "'"

            If Not Todos Then
                sql = "SELECT IdConfiguracion, Xml, NombreConfiguracion FROM Configuracion WHERE IdUsuario = " & IdUsuario.ToString() & _
                    " AND Formulario = '" & Formulario & "'" & " AND NombreConfiguracion = '" & NombreConfiguracion & "'"
                'If Not Todos Then sql = sql & " AND NombreConfiguracion = '" & NombreConfiguracion & "'"

            Else
                sql = "SELECT IdConfiguracion, Xml, NombreConfiguracion FROM Configuracion WHERE (IdUsuario = " & IdUsuario.ToString() & " OR IdUsuario = 0)" & _
                " AND (Formulario = '" & Formulario & "' OR Formulario = '" & maestro & "')"
            End If


            dt = MiConexion.ConsultaSQL(sql)

        Catch ex As Exception
            err.Muestraerror("Error al obtener la configuracion de la plantilla '" & NombreConfiguracion & "'", "ObtenerConfiguracion", ex.Message)
        End Try


        Return dt


    End Function


    Public Function GuardaConfiguracionPorDefecto(ByVal IdUsuario As Integer, ByVal Formulario As String, ByVal xml As String) As Boolean

        Dim resultado As Boolean = True

        Try

            Dim dt As DataTable = ObtenerConfiguracion(IdUsuario, Formulario, "", False)
            If dt.Rows.Count < 1 Then

                Dim Id As Integer = MaxId()
                Dim sql As String = "INSERT INTO Configuracion (IdConfiguracion, IdUsuario, Formulario, Xml, NombreConfiguracion) "
                sql = sql & " VALUES (" & Id.ToString & ", " & IdUsuario.ToString & ", '" & Formulario & "', '" & xml & "', '' )"

                MiConexion.OrdenSql(sql)

            End If

        Catch ex As Exception
            resultado = False
            err.Muestraerror("Error al guardar la configuracion por defecto", "GuardaConfiguracionPorDefecto", ex.Message)
        End Try


        Return resultado

    End Function



    Public Function GuardarConfiguracion(ByVal IdUsuario As Integer, ByVal Formulario As String, ByVal xml As String, ByVal NombreConfiguracion As String) As Boolean

        Dim resultado As Boolean = True
        Dim sql As String = ""

        xml = xml.Replace("'", "''")

        Dim dt As DataTable = ObtenerConfiguracion(IdUsuario, Formulario, NombreConfiguracion, False)
        If dt.Rows.Count > 0 Then
            sql = "UPDATE Configuracion SET xml = '" & xml & "'"
            sql = sql & " WHERE IdUsuario = " & IdUsuario.ToString & " AND Formulario = '" & Formulario & "' AND NombreConfiguracion = '" & NombreConfiguracion & "'"
        Else
            Dim Id As Integer = MaxId()
            sql = "INSERT INTO Configuracion (IdConfiguracion, IdUsuario, Formulario, Xml, NombreConfiguracion) "
            sql = sql & " VALUES (" & Id.ToString & ", " & IdUsuario.ToString & ", '" & Formulario & "', '" & xml & "', '" & NombreConfiguracion & "' )"
        End If


        Try

            resultado = MiConexion.OrdenSql(sql)

        Catch ex As Exception
            resultado = False
            err.Muestraerror("Error al guardar la configuración de la plantilla '" & NombreConfiguracion & "'", "GuardarConfiguracion", ex.Message)
        End Try



        Return resultado

    End Function


    Public Function BorrarConfiguracion(ByVal IdUsuario As Integer, ByVal Formulario As String, NombreConfiguracion As String) As Boolean

        Dim resultado As Boolean = True
        Dim sql As String = ""

        Dim dt As DataTable = ObtenerConfiguracion(IdUsuario, Formulario, NombreConfiguracion, False)
        If dt.Rows.Count > 0 Then
            sql = "DELETE FROM Configuracion " & vbCrLf
            sql = sql & " WHERE IdUsuario = " & IdUsuario.ToString & " AND Formulario = '" & Formulario & "' AND NombreConfiguracion = '" & NombreConfiguracion & "'"
        End If

        Try
            resultado = MiConexion.OrdenSql(sql)
        Catch ex As Exception
            resultado = False
            err.Muestraerror("Error al borrar la configuración de la plantilla '" & NombreConfiguracion & "'", "BorrarConfiguracion", ex.Message)
        End Try


        Return resultado

    End Function



    Public Function PermisoAplicacion(ByVal nIdUsuario As Integer, ByVal nIdPerfil As Integer, ByVal nIdAplicacion As Integer) As Boolean

        Try

            Dim resultado As Boolean = False
            Dim dt As New DataTable

            Try

                Dim sql As String = "SELECT  TOP 1 IdPerfil, IdUsuario, IdAplicacion, Formulario, Tipo, Xml FROM Configuracion " & _
                " where IdUsuario = " & nIdUsuario.ToString & " And IdPerfil = " & nIdPerfil.ToString & _
                " And Idaplicacion = " & nIdAplicacion.ToString

                dt = MiConexion.ConsultaSQL(sql)

                If dt.Rows.Count > 0 Then
                    resultado = True
                Else
                    resultado = False
                End If

            Catch ex As Exception
                Throw New Exception("Error al consultar la configuración")
            End Try

            Return resultado

        Catch ex As Exception
            err.Muestraerror("No se pudo devolver el permiso a la aplicacion " & IdAplicacion.ToString & " del usuario " & idUsuario.ToString & " del perfil " & idPerfil.ToString, "Function PermisoAplicacion(ByVal idUsuario As Integer, ByVal idPerfil As Integer, ByVal IdAplicacion As Integer) As Boolean", ex.Message)
            Return False
        End Try

    End Function


    Public Function ListaAplicacionesUsuario(ByVal IdUsuario As Integer, ByVal idPerfil As Integer) As List(Of E_Aplicacion)
        Dim lista As New List(Of E_Aplicacion)

        Dim dt As New DataTable
        Dim sql As String = "Select Configuracion.IdAplicacion " & _
            " FROM Configuracion LEFT JOIN Aplicacion ON Configuracion.IdAplicacion = Aplicacion.IdAplicacion" & _
            " WHERE IdUsuario=" & IdUsuario & " AND IdPerfil=" & idPerfil & " AND TIPO IS NULL AND XML IS NULL AND FORMULARIO IS NULL" & _
            " ORDER BY Aplicacion.Nombre"
        dt = MiConexion.ConsultaSQL(sql)

        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows

                Dim apli As New E_Aplicacion(IdUsuario, Cncomun)
                If apli.LeerId(dr("IdAplicacion").ToString) Then
                    lista.Add(apli)
                End If
            Next
        End If
        Return lista

    End Function


    Public Function AñadirPermisosAplicacion(ByVal IdUsuario As Integer, ByVal IdPerfil As Integer, ByVal IdAPlicacion As Integer) As Boolean

        Try

            Dim o As String = "Insert Into Configuracion ( IdConfiguracion, IdPerfil, IdUsuario,IdAplicacion) VALUES (" & MaxId.ToString & "," & IdPerfil & "," & IdUsuario & ", " & IdAPlicacion & ")"
            MiConexion.OrdenSql(o)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function EliminarPermisosAplicacion(ByVal IdUsuario As Integer, ByVal IdPerfil As Integer, ByVal IdAPlicacion As Integer) As Boolean

        Try
            Dim o As String = "DELETE FROM Configuracion WHERE IdAplicacion=" & IdAPlicacion & " AND IdPerfil= " & IdPerfil & " AND IdUsuario=" & IdUsuario & ""
            MiConexion.OrdenSql(o)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Overrides Function ObtieneContador(ByVal nombreTabla As String, ByVal TipoContador As String, ByVal idUsuario As Integer, Optional ByVal ultimo As Integer = 0) As Integer

        Try
            Dim resultado As Integer = 0
            Dim dt As New DataTable
            Dim consulta As String = ""
            Dim v As Integer = 0

            If ultimo <> 0 Then
                If ultimo = -1 Then ' BORRA EL CONTADOR
                    ultimo = 0
                End If
                v = Vcontador(TipoContador)
                If v >= 0 Then
                    MiConexion.OrdenSql("Update Contadores set UltimoNumero=" & ultimo.ToString & ", IdUsuario=" & idUsuario.ToString & " WHERE NombreTabla='" & nombreTabla & "' AND TipoContador='" & TipoContador & "'")
                Else
                    MiConexion.OrdenSql("Insert Into Contadores (NombreTabla, TipoContador, UltimoNumero, IdUsuario) VALUES ('" & nombreTabla & "','" & TipoContador & "'," & ultimo.ToString & "," & idUsuario.ToString & ")")
                End If
                Return ultimo
            End If

            v = Vcontador(TipoContador)

            If v >= 0 Then
                resultado = v + 1
                MiConexion.OrdenSql("Update Contadores set UltimoNumero=" & resultado.ToString & ", IdUsuario=" & idUsuario.ToString & " WHERE NombreTabla='" & nombreTabla & "' AND TipoContador='" & TipoContador & "'")
            Else
                MiConexion.OrdenSql("Insert Into Contadores (NombreTabla, TipoContador, UltimoNumero, IdUsuario) VALUES ('" & nombreTabla & "','" & TipoContador & "',1," & idUsuario.ToString & ")")
                resultado = 1
            End If

            dt = New DataTable
            consulta = "Select IdUsuario From Contadores WHERE NombreTabla='" & nombreTabla & "' AND TipoContador='" & TipoContador & "'"
            dt = MiConexion.ConsultaSQL(consulta)
            Dim e As Boolean = False

            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    If CInt(dt.Rows(0)(0)) = idUsuario Then
                        e = True
                    End If
                End If
            End If

            If e = False Then
                Return ObtieneContador(nombreTabla, TipoContador, idUsuario)
            Else
                Return resultado
            End If

        Catch ex As Exception
            err.Muestraerror(ex.Message, "ObtieneContador", ex.Message)
            Return 0
        End Try

    End Function


    Public Overrides Function Vcontador(ByVal TipoContador) As Integer
        Dim resultado As Integer = 0
        Dim dt As New DataTable
        Dim consulta As String = ""

        dt = New DataTable
        consulta = "Select UltimoNumero From Contadores WHERE NombreTabla='" & NombreTabla & "' AND TipoContador='" & TipoContador & "'"
        dt = MiConexion.ConsultaSQL(consulta)

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Return CInt(dt.Rows(0)(0))
            Else

                Return -1
            End If
        Else
            Return -1
        End If




    End Function


End Class


