Public Class E_FamiliasDescuentos
    Inherits Cdatos.Entidad


    Public FAD_id As Cdatos.bdcampo
    Public FAD_idfamilia As Cdatos.bdcampo
    Public FAD_dtobascula As Cdatos.bdcampo
    Public FAD_DtoBasculaFirme As Cdatos.bdcampo
    Public FAD_mermasfirme As Cdatos.bdcampo
    Public FAD_estructura As Cdatos.bdcampo
    Public FAD_idcentro As Cdatos.bdcampo
    Public FAD_DtoBasculaFirmeSinClasif As Cdatos.bdcampo

    Public FAD_IdUsuarioLog As Cdatos.bdcampo
    Public FAD_FechaLog As Cdatos.bdcampo
    Public FAD_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FamiliasDescuentos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            FAD_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 5, 0, True)
            FAD_idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 4)
            FAD_dtobascula = New Cdatos.bdcampo(CodigoEntidad & "dtobascula", Cdatos.TiposCampo.Importe, 6, 3)
            FAD_DtoBasculaFirme = New Cdatos.bdcampo(CodigoEntidad & "dtobasculafirme", Cdatos.TiposCampo.Importe, 6, 3)
            FAD_mermasfirme = New Cdatos.bdcampo(CodigoEntidad & "mermasfirme", Cdatos.TiposCampo.Importe, 6, 3)
            FAD_estructura = New Cdatos.bdcampo(CodigoEntidad & "estructura", Cdatos.TiposCampo.Importe, 6, 3)
            FAD_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 2)
            FAD_DtoBasculaFirmeSinClasif = New Cdatos.bdcampo(CodigoEntidad & "DtoBasculaFirmeSinClasif", Cdatos.TiposCampo.Importe, 6, 3)

            FAD_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAD_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FAD_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function LeerDescuentos(ByVal idfamilia As Integer, ByVal idcentro As Integer) As DataTable
        Dim ret As New DataTable
        Dim Consulta As New Cdatos.E_select
        Consulta.SelTodos(Me)
        Consulta.WheCampo(Me.FAD_idfamilia, "=", idfamilia.ToString)
        Consulta.WheCampo(Me.FAD_idcentro, "=", idcentro.ToString)
        ret = Me.MiConexion.ConsultaSQL(Consulta.SQL)

        Return ret

    End Function


End Class
