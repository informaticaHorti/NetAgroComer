Public Class E_pedidos_almacen
    Inherits Cdatos.Entidad

    Public PAC_id As Cdatos.bdcampo
    Public PAC_idlineapedido As Cdatos.bdcampo
    Public PAC_idalmacen As Cdatos.bdcampo
    Public PAC_palets As Cdatos.bdcampo
    Public PAC_estadoetiqueta As Cdatos.bdcampo

    Public PAC_IdUsuarioLog As Cdatos.bdcampo
    Public PAC_FechaLog As Cdatos.bdcampo
    Public PAC_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "pedidos_almacen"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PAC_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PAC_idlineapedido = New Cdatos.bdcampo(CodigoEntidad & "idlineapedido", Cdatos.TiposCampo.EnteroPositivo, 6)
            PAC_idalmacen = New Cdatos.bdcampo(CodigoEntidad & "Idalmacen", Cdatos.TiposCampo.EnteroPositivo, 3)
            PAC_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.EnteroPositivo, 6)
            PAC_estadoetiqueta = New Cdatos.bdcampo(CodigoEntidad & "estadoetiqueta", Cdatos.TiposCampo.Entero, 1)

            PAC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PAC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PAC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Sub Borralineas(idlineapedido As Integer)


        Dim sql As String = ""

        If idlineapedido > 0 Then
            sql = "Delete from pedidos_almacen where pac_idlineapedido=" + idlineapedido.ToString
            Me.MiConexion.OrdenSql(sql)
        End If


    End Sub

End Class
