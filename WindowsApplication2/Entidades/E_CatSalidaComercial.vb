Public Class E_CatSalidaComercial
    Inherits Cdatos.Entidad


    Public CSC_Id As Cdatos.bdcampo
    Public CSC_Idcatcomercial As Cdatos.bdcampo
    Public CSC_idCatsalida As Cdatos.bdcampo

    Public CSC_IdUsuarioLog As Cdatos.bdcampo
    Public CSC_FechaLog As Cdatos.bdcampo
    Public CSC_HoraLog As Cdatos.bdcampo


   
    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)





        Try
            NombreTabla = "CatSalidaComercial"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CSC_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CSC_Idcatcomercial = New Cdatos.bdcampo(CodigoEntidad & "idcatcomercial", Cdatos.TiposCampo.EnteroPositivo, 4)
            CSC_idCatsalida = New Cdatos.bdcampo(CodigoEntidad & "idcatsalida", Cdatos.TiposCampo.EnteroPositivo, 4)

            CSC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CSC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CSC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)


        End Try



    End Sub

    Public Function LeerCat(IdCatComercial As String, IdCatSalida As String) As Integer
        Dim sql As String
        Dim ret As Integer = 0
        sql = "Select CSC_id as id from CatSalidaComercial where CSC_idcatcomercial=" + IdCatComercial + " and CSC_idCatSalida=" + IdCatSalida
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)(0))
            End If
        End If
        Return ret
    End Function

    Public Function CategoriaComercial(IdCatSalida As String) As Integer
        Dim sql As String
        Dim ret As Integer = 0
        sql = "Select CSC_idcatcomercial as id from CatSalidaComercial where CSC_idCatSalida=" + IdCatSalida
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)(0))
            End If
        End If
        Return ret

    End Function

End Class
