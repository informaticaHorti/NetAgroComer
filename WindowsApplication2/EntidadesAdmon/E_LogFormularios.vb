

Public Class E_LogFormularios
    Inherits Cdatos.Entidad


    Private err As New Errores


    Public LOF_Id As Cdatos.bdcampo
    Public LOF_IdPerfil As Cdatos.bdcampo
    Public LOF_NombreFormulario As Cdatos.bdcampo
    Public LOF_Permisos As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "LogFormularios"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LOF_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            LOF_IdPerfil = New Cdatos.bdcampo(CodigoEntidad & "IdPerfil", Cdatos.TiposCampo.Entero, 10)
            LOF_NombreFormulario = New Cdatos.bdcampo(CodigoEntidad & "NombreFormulario", Cdatos.TiposCampo.Cadena, 150)
            LOF_Permisos = New Cdatos.bdcampo(CodigoEntidad & "Permisos", Cdatos.TiposCampo.Cadena, 3)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub



    Public Function AñadirPermisosPerfil(nIdPerfil As Integer, cNombreFormulario As String, cPermisos As String)

        Try

            Dim permiso_formulario As New E_LogFormularios(Idusuario, cn)
            permiso_formulario.LOF_Id.Valor = permiso_formulario.MaxId()
            permiso_formulario.LOF_IdPerfil.Valor = nIdPerfil.ToString
            permiso_formulario.LOF_NombreFormulario.Valor = cNombreFormulario.ToLower.Trim
            permiso_formulario.LOF_Permisos.Valor = cPermisos
            permiso_formulario.Insertar()

            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function BorrarPermisosPerfil(nIdPerfil As Integer) As Boolean

        Try

            Dim sql As String = "DELETE FROM LogFormularios WHERE LOF_IdPerfil = " & nIdPerfil
            MiConexion.OrdenSql(sql)
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function



End Class


Public Class PermisosFormularios

    Public Const Alta As String = "A"
    Public Const Modificaciones As String = "M"
    Public Const Bajas As String = "B"

    Public Shared Function Tabla() As DataTable

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Id", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(System.String)))

        Dim row As DataRow = dt.NewRow
        row("Id") = PermisosFormularios.Alta
        row("Nombre") = "Altas"
        dt.Rows.Add(row)

        row = dt.NewRow
        row("Id") = PermisosFormularios.Modificaciones
        row("Nombre") = "Modificaciones"
        dt.Rows.Add(row)

        row = dt.NewRow
        row("Id") = PermisosFormularios.Bajas
        row("Nombre") = "Bajas"
        dt.Rows.Add(row)


        Return dt

    End Function

End Class

