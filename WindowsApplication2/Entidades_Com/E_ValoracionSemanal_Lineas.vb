Public Class E_ValoracionSemanal_Lineas
    Inherits Cdatos.Entidad


    Public VSL_IdLinea As Cdatos.bdcampo
    Public VSL_IdValora As Cdatos.bdcampo
    Public VSL_IdGenero As Cdatos.bdcampo
    Public VSL_IdCategoria As Cdatos.bdcampo
    Public VSL_Precio As Cdatos.bdcampo
    Public VSL_Kilos As Cdatos.bdcampo

    Public VSL_IdUsuarioLog As Cdatos.bdcampo
    Public VSL_FechaLog As Cdatos.bdcampo
    Public VSL_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "ValoracionSemanal_Lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VSL_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            VSL_IdValora = New Cdatos.bdcampo(CodigoEntidad & "IdValora ", Cdatos.TiposCampo.EnteroPositivo, 10)
            VSL_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.EnteroPositivo, 4)
            VSL_IdCategoria = New Cdatos.bdcampo(CodigoEntidad & "IdCategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            VSL_Precio = New Cdatos.bdcampo(CodigoEntidad & "Precio", Cdatos.TiposCampo.Importe, 10, 4)
            VSL_Kilos = New Cdatos.bdcampo(CodigoEntidad & "Kilos", Cdatos.TiposCampo.Importe, 10, 0)

            VSL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VSL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VSL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function LeerPrecio(idvaloracion As Integer, idgenero As Integer, idcategoria As Integer,
                               ByRef Precio As Decimal) As Boolean


        Dim ret As Boolean = False
        Precio = 0


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.VSL_Precio, "Precio")
        consulta.WheCampo(Me.VSL_IdValora, "=", idvaloracion.ToString)
        consulta.WheCampo(Me.VSL_IdGenero, "=", idgenero.ToString)
        consulta.WheCampo(Me.VSL_IdCategoria, "=", idcategoria.ToString)
        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = True
                Precio = VaDec(dt.Rows(0)("Precio"))
            End If
        End If


        Return ret

    End Function
End Class
