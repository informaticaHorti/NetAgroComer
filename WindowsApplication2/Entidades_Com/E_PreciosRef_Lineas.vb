Public Class E_PreciosRef_Lineas
    Inherits Cdatos.Entidad

    Public PFL_IdLinea As Cdatos.bdcampo
    Public PFL_Idvalora As Cdatos.bdcampo
    Public PFL_Idgensal As Cdatos.bdcampo
    Public PFL_Idcategoria As Cdatos.bdcampo
    Public PFL_Precio As Cdatos.bdcampo
    Public PFL_BKP As Cdatos.bdcampo

    Public PFL_IdUsuarioLog As Cdatos.bdcampo
    Public PFL_FechaLog As Cdatos.bdcampo
    Public PFL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "PreciosRef_Lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PFL_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PFL_Idvalora = New Cdatos.bdcampo(CodigoEntidad & "Idvalora ", Cdatos.TiposCampo.EnteroPositivo, 10)
            PFL_Idgensal = New Cdatos.bdcampo(CodigoEntidad & "Idgensal", Cdatos.TiposCampo.EnteroPositivo, 4)
            PFL_Idcategoria = New Cdatos.bdcampo(CodigoEntidad & "Idcategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            PFL_Precio = New Cdatos.bdcampo(CodigoEntidad & "Precio", Cdatos.TiposCampo.Importe, 10, 4)
            PFL_BKP = New Cdatos.bdcampo(CodigoEntidad & "BKP", Cdatos.TiposCampo.Cadena, 1)

            PFL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PFL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PFL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function LeerPrecio(idvaloracion As Integer, idgensal As Integer, idcategoria As Integer, ByRef Precio As Decimal, ByRef Tipo As String) As Boolean
        Dim ret As Boolean = False
        Precio = 0
        Tipo = "K"
        Dim sql As String = ""
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PFL_Precio, "Precio")
        consulta.SelCampo(Me.PFL_BKP, "Tipo")
        consulta.WheCampo(Me.PFL_Idvalora, "=", idvaloracion.ToString)
        consulta.WheCampo(Me.PFL_Idgensal, "=", idgensal.ToString)
        consulta.WheCampo(Me.PFL_Idcategoria, "=", idcategoria.ToString)
        sql = consulta.SQL
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = True
                Precio = VaDec(dt.Rows(0)("Precio"))
                Tipo = dt.Rows(0)("Tipo").ToString
            End If
        End If


        Return ret

    End Function
End Class
