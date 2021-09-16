Public Class E_EnvasesPalets

    Inherits Cdatos.Entidad


    Public ENP_id As Cdatos.bdcampo
    Public ENP_idenvase As Cdatos.bdcampo
    Public ENP_idmedidapalet As Cdatos.bdcampo
    Public ENP_cajasfila As Cdatos.bdcampo
    Public ENP_maxfilas As Cdatos.bdcampo

    Public ENP_IdUsuarioLog As Cdatos.bdcampo
    Public ENP_FechaLog As Cdatos.bdcampo
    Public ENP_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)



        Try
            NombreTabla = "envasespalets"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ENP_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            ENP_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENP_idmedidapalet = New Cdatos.bdcampo(CodigoEntidad & "idmedidapalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            ENP_cajasfila = New Cdatos.bdcampo(CodigoEntidad & "cajasfila", Cdatos.TiposCampo.EnteroPositivo, 3)
            ENP_maxfilas = New Cdatos.bdcampo(CodigoEntidad & "maxfilas", Cdatos.TiposCampo.EnteroPositivo, 3)

            ENP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ENP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ENP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




    End Sub


    Public Function MaxBultosPalet(idConfeEnvase As String, idConfecPalet As String) As Integer

        Dim ret As Integer
        Dim dt As New DataTable
        Dim sql As String
        Dim idenvase As Integer
        Dim idpalet As Integer
        Dim idmedida As Integer

        If VaInt(idConfeEnvase) > 0 And VaInt(idConfecPalet) > 0 Then
            sql = "Select CEV_idenvase as idenvase from confecenvase where CEV_idconfec=" + idConfeEnvase
            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    idenvase = VaInt(dt.Rows(0)(0))
                End If
            End If

            sql = "Select CPA_idpalet as idpalet from confecpalet where CPA_idconfec=" + idConfecPalet
            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    idpalet = VaInt(dt.Rows(0)(0))
                End If
            End If

            If idpalet > 0 Then
                sql = "Select ENV_idmedida as idmedida from envases where ENV_idenvase=" + idpalet.ToString
                dt = Me.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        idmedida = VaInt(dt.Rows(0)(0))
                    End If
                End If
            End If

            If idenvase > 0 And idmedida > 0 Then
                ret = MaxBultos(idenvase.ToString, idmedida.ToString)
            End If
        End If

        Return ret

    End Function

    Private Function MaxBultos(idenvase As String, idmedidapalet As String) As Integer
        Dim ret As Integer
        Dim consulta As New Cdatos.E_select
        Dim Envases As New E_Envases(Idusuario, cn)

        Dim sql As String
        sql = "SELECT ENP_cajasfila * ENP_maxfilas from ENVASESPALETS WHERE ENP_IDENVASE=" + idenvase + " AND ENP_IDMEDIDAPALET=" + idmedidapalet
        Dim DT As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                ret = VaInt(DT.Rows(0)(0))
            End If
        End If

        Return ret

    End Function

End Class
