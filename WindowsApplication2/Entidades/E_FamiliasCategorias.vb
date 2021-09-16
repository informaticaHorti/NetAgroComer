Public Class E_FamiliasCategorias
    Inherits Cdatos.Entidad


    Public FAC_Id As Cdatos.bdcampo
    Public FAC_Idfamilia As Cdatos.bdcampo
    Public FAC_idCategoriaentrada As Cdatos.bdcampo
    Public FAC_idCategoriaComercial As Cdatos.bdcampo

    Public FAC_IdUsuarioLog As Cdatos.bdcampo
    Public FAC_FechaLog As Cdatos.bdcampo
    Public FAC_HoraLog As Cdatos.bdcampo

 


    Dim Familiasgeneros As New E_FamiliasGeneros(Idusuario, cn)

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

       



        Try
            NombreTabla = "FamiliasCategorias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FAC_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            FAC_Idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAC_idCategoriaentrada = New Cdatos.bdcampo(CodigoEntidad & "idcategoriaentrada", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAC_idCategoriaComercial = New Cdatos.bdcampo(CodigoEntidad & "idcategoriacomercial", Cdatos.TiposCampo.EnteroPositivo, 4)

            FAC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FAC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try



    End Sub



    Public Function LeerCat(ByVal idfamilia As Integer, ByVal idcat As Integer, ByVal entradasalida As String) As Integer

        Dim dt As New DataTable
        Dim sql As String = ""

        Select Case entradasalida
            Case "E"
                sql = "Select FAC_id as Id from familiascategorias where FAC_idfamilia=" + idfamilia.ToString + " and FAC_idcategoriaentrada=" + idcat.ToString
            Case "S"
                sql = "Select FAC_id as Id from familiascategorias where FAC_idfamilia=" + idfamilia.ToString + " and FAC_idcategoriasalida=" + idcat.ToString
            Case "C"
                sql = "Select FAC_id as Id from familiascategorias where FAC_idfamilia=" + idfamilia.ToString + " and FAC_idcategoriacomercial=" + idcat.ToString

        End Select

        Dim ret As Integer = 0
        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)
            End If
        End If
        Return ret
    End Function


End Class
