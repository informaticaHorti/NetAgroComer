Public Class E_Lineas_producto

    Inherits Cdatos.Entidad

    Public LNP_Id As Cdatos.bdcampo
    Public LNP_idlinea As Cdatos.bdcampo
    Public LNP_idsubfamilia As Cdatos.bdcampo

    Public LNP_IdUsuarioLog As Cdatos.bdcampo
    Public LNP_FechaLog As Cdatos.bdcampo
    Public LNP_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Lineas_producto"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LNP_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            LNP_idlinea = New Cdatos.bdcampo(CodigoEntidad & "Idlinea", Cdatos.TiposCampo.EnteroPositivo, 4)
            LNP_idsubfamilia = New Cdatos.bdcampo(CodigoEntidad & "Idsubfamilia", Cdatos.TiposCampo.EnteroPositivo, 4)

            LNP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LNP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LNP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function LeerLineaProducto(idlinea As Integer, idproducto As Integer) As Integer
        Dim ret As Integer

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.LNP_Id, "id")
        consulta.WheCampo(Me.LNP_idlinea, "=", idlinea.ToString)
        consulta.WheCampo(Me.LNP_idsubfamilia, "=", idproducto)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)
            End If
        End If

        Return ret


    End Function


End Class
