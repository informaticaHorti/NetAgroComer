Public Class E_DAT_OPERADORES
    Inherits Cdatos.Entidad

    Public DOP_Id As Cdatos.bdcampo
    Public DOP_Nombre As Cdatos.bdcampo
    Public DOP_IdEmpresa As Cdatos.bdcampo
    Public DOP_Usuario As Cdatos.bdcampo
    Public DOP_Clave As Cdatos.bdcampo
    Public DOP_Tipo As Cdatos.bdcampo
    Public DOP_IdOperadorDAT As Cdatos.bdcampo

    Public DOP_IdUsuarioLog As Cdatos.bdcampo
    Public DOP_FechaLog As Cdatos.bdcampo
    Public DOP_HoraLog As Cdatos.bdcampo



    Dim err As New Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DAT_OPERADORES"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DOP_Id = New Cdatos.bdcampo(CodigoEntidad & "ID", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            DOP_Nombre = New Cdatos.bdcampo(CodigoEntidad & "NOMBRE", Cdatos.TiposCampo.Cadena, 200)
            DOP_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "IDEMPRESA", Cdatos.TiposCampo.EnteroPositivo, 5)
            DOP_Usuario = New Cdatos.bdcampo(CodigoEntidad & "USUARIO", Cdatos.TiposCampo.Cadena, 20)
            DOP_Clave = New Cdatos.bdcampo(CodigoEntidad & "CLAVE", Cdatos.TiposCampo.Cadena, 20)
            DOP_Tipo = New Cdatos.bdcampo(CodigoEntidad & "TIPO", Cdatos.TiposCampo.Cadena, 2)
            DOP_IdOperadorDAT = New Cdatos.bdcampo(CodigoEntidad & "IDOPERADORDAT", Cdatos.TiposCampo.EnteroPositivo, 5)

            DOP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IDUSUARIOLOG", Cdatos.TiposCampo.EnteroPositivo, 4)
            DOP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FECHALOG", Cdatos.TiposCampo.Fecha, 15)
            DOP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HORALOG", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
