Public Class E_Centrospventa
    Inherits Cdatos.Entidad


    Public CRP_id As Cdatos.bdcampo
    Public CRP_idcentroR As Cdatos.bdcampo
    Public CRP_idpventa As Cdatos.bdcampo
    Public CRP_idseccion As Cdatos.bdcampo
    Public CRP_idactividad As Cdatos.bdcampo

    Public CRP_IdUsuarioLog As Cdatos.bdcampo
    Public CRP_FechaLog As Cdatos.bdcampo
    Public CRP_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)



        Try
            NombreTabla = "centrospventa"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CRP_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            CRP_idcentroR = New Cdatos.bdcampo(CodigoEntidad & "idcentror", Cdatos.TiposCampo.EnteroPositivo, 3)
            CRP_idpventa = New Cdatos.bdcampo(CodigoEntidad & "idpventa", Cdatos.TiposCampo.EnteroPositivo, 3)
            CRP_idseccion = New Cdatos.bdcampo(CodigoEntidad & "idseccion", Cdatos.TiposCampo.EnteroPositivo, 3)
            CRP_idactividad = New Cdatos.bdcampo(CodigoEntidad & "idactividad", Cdatos.TiposCampo.EnteroPositivo, 3)

            CRP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CRP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CRP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




    End Sub

    Public Sub SeccionActividad(idcrecogida As String, idpventa As String, ByRef idseccion As String, ByRef idactividad As String)

        Dim sql As String = "Select CRP_IDSECCION AS idseccion,CRP_IDACTIVIDAD AS idactividad from centrospventa where crp_idcentror=" + idcrecogida + " and crp_idpventa=" + idpventa
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                idseccion = dt.Rows(0)("idseccion").ToString
                idactividad = dt.Rows(0)("idactividad").ToString
            End If
        End If

        If idseccion = "" Then
            Dim puntoventa As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            If puntoventa.LeerId(idpventa) = True Then
                idseccion = puntoventa.IdSeccion.Valor
                idactividad = puntoventa.IdActividad.Valor
            End If
        End If



    End Sub
End Class
