Public Class E_GenerosCompuestos
    Inherits Cdatos.Entidad

    Public GEC_IdLinea As Cdatos.bdcampo
    Public GEC_IdGenero As Cdatos.bdcampo
    Public GEC_Porcentaje As Cdatos.bdcampo
    Public GEC_IdGeneroCompuesto As Cdatos.bdcampo

    Public GEC_IdUsuarioLog As Cdatos.bdcampo
    Public GEC_FechaLog As Cdatos.bdcampo
    Public GEC_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "GenerosCompuestos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GEC_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.Entero, 5, 0, True)
            GEC_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            GEC_Porcentaje = New Cdatos.bdcampo(CodigoEntidad & "porcentaje", Cdatos.TiposCampo.Importe, 6, 2)
            GEC_IdGeneroCompuesto = New Cdatos.bdcampo(CodigoEntidad & "idgenerocompuesto", Cdatos.TiposCampo.Entero, 5)

            GEC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GEC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GEC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function Composicion(IdGenero As Integer, NombreGenero As String, IdFamilia As Integer) As DataTable

        Dim ret As New DataTable
        ret.Columns.Add("idgenero", GetType(System.Int32))
        ret.Columns.Add("Genero", GetType(String))
        ret.Columns.Add("porcentaje", GetType(System.Decimal))
        ret.Columns.Add("IdFamilia", GetType(Integer))


        Dim sql As String = "SELECT GEC_idgenerocompuesto as idgenero, GEN_NombreGenero AS Genero, GEC_porcentaje as porcentaje, SFA_IdFamilia as IdFamilia" & vbCrLf
        sql = sql & " FROM GENEROSCOMPUESTOS" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = GEC_IdGeneroCompuesto" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON SFA_Id = GEN_IdSubFamilia" & vbCrLf
        sql = sql & " WHERE GEC_idgenero=" + idgenero.ToString & vbCrLf


        Dim dtc As DataTable = Me.MiConexion.ConsultaSQL(sql)
        Dim p As Decimal = 0

        If Not dtc Is Nothing Then

            For Each rw In dtc.Rows
                p = p + VaDec(rw("porcentaje"))
            Next

            If p <> 100 Then
                ret.Rows.Add(IdGenero, NombreGenero, 100, IdFamilia)
            Else
                ret = dtc
            End If

        End If



        Return ret

    End Function



End Class
