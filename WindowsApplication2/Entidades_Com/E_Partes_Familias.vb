Public Class E_Partes_familias

    Inherits Cdatos.Entidad

    Public PFM_id As Cdatos.bdcampo
    Public PFM_idparte As Cdatos.bdcampo
    Public PFM_IDfamilia As Cdatos.bdcampo

    Public PFM_IdUsuarioLog As Cdatos.bdcampo
    Public PFM_FechaLog As Cdatos.bdcampo
    Public PFM_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Partes_Familias"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PFM_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PFM_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 10)
            PFM_IDfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 6)

            PFM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PFM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PFM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



    Public Function LeerParte_Familia(ByVal idparte As String, ByVal idfamilia As String) As Integer

        Dim ret As Integer
        Dim sql As String = "Select PFM_Id as Id from partes_familias where PFM_Idparte=" + idparte + " and PFM_Idfamilia=" + idfamilia
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0)

            End If
        End If
        Return ret

    End Function


   
End Class
