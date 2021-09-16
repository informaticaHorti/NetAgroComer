Public Class E_Observaciones
    Inherits Cdatos.Entidad

    Public OBS_Id As Cdatos.bdcampo
    Public OBS_Tipo As Cdatos.bdcampo
    Public OBS_Codigo As Cdatos.bdcampo
    Public OBS_Texto As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Observaciones"
            NombreBd = "NetAgro"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            OBS_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            OBS_Tipo = New Cdatos.bdcampo(CodigoEntidad & "Tipo", Cdatos.TiposCampo.Cadena, 3)
            OBS_Codigo = New Cdatos.bdcampo(CodigoEntidad & "Codigo", Cdatos.TiposCampo.Cadena, 20)
            OBS_Texto = New Cdatos.bdcampo(CodigoEntidad & "Texto", Cdatos.TiposCampo.Cadena, 4000)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Public Function LeerCodigo(tipo As String, codigo As String) As String
        Dim res As String = ""

        Dim sql As String = "Select OBS_ID AS ID FROM OBSERVACIONES WHERE OBS_TIPO='" + tipo + "' AND OBS_CODIGO='" + codigo + "'"
        Dim DT As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                res = DT.Rows(0)(0).ToString
            End If
        End If


        Return res

    End Function
End Class
