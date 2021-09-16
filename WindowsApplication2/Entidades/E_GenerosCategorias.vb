Public Class E_GenerosCategorias
    Inherits Cdatos.Entidad

    Public GCA_id As Cdatos.bdcampo
    Public GCA_idpresentacion As Cdatos.bdcampo
    Public GCA_tipo As Cdatos.bdcampo
    Public GCA_codigo As Cdatos.bdcampo

    Public GCA_IdUsuarioLog As Cdatos.bdcampo
    Public GCA_FechaLog As Cdatos.bdcampo
    Public GCA_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "GenerosCategorias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GCA_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            GCA_idpresentacion = New Cdatos.bdcampo(CodigoEntidad & "idpresentacion", Cdatos.TiposCampo.EnteroPositivo, 10)
            GCA_tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)
            GCA_codigo = New Cdatos.bdcampo(CodigoEntidad & "codigo", Cdatos.TiposCampo.EnteroPositivo, 3)

            GCA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GCA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GCA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function LeerGenero_Categoria(ByVal idpresentacion As String, ByVal idcategoria As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select GCA_Id as Id from GenerosCategorias where GCA_Idpresentacion=" + idpresentacion + " and GCA_tipo='C'  and GCA_codigo=" + idcategoria
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function


    Public Function LeerGenero_Marca(ByVal idpresentacion As String, ByVal idmarca As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select GCA_Id as Id from GenerosCategorias where GCA_Idpresentacion=" + idpresentacion + "  and GCA_tipo='M'  and GCA_codigo=" + idmarca
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function


End Class
