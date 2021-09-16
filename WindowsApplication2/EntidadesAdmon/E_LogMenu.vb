Public Class E_LogMenu
    Inherits Cdatos.Entidad


    Private err As New Errores


    Public LOM_Id As Cdatos.bdcampo
    Public LOM_IdPerfil As Cdatos.bdcampo
    Public LOM_NombreBoton As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "LogMenu"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            LOM_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            LOM_IdPerfil = New Cdatos.bdcampo(CodigoEntidad & "IdPerfil", Cdatos.TiposCampo.Entero, 10)
            LOM_NombreBoton = New Cdatos.bdcampo(CodigoEntidad & "NombreBoton", Cdatos.TiposCampo.Cadena, 100)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function AñadirPermisosPerfil(nIdPerfil As Integer, NombreControl As String)

        Try

            Dim elemento_menu As New E_LogMenu(Idusuario, cn)
            elemento_menu.LOM_Id.Valor = elemento_menu.MaxId()
            elemento_menu.LOM_IdPerfil.Valor = nIdPerfil.ToString
            elemento_menu.LOM_NombreBoton.Valor = NombreControl.ToLower.Trim
            elemento_menu.Insertar()

            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function BorrarPermisosPerfil(nIdPerfil As Integer) As Boolean

        Try

            Dim sql As String = "DELETE FROM LogMenu WHERE LOM_IdPerfil = " & nIdPerfil
            MiConexion.OrdenSql(sql)
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function



End Class
