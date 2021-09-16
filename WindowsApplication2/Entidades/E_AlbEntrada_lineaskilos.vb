Public Class E_AlbEntrada_lineaskilos
    Inherits Cdatos.Entidad


    Public ALK_id As Cdatos.bdcampo
    Public ALK_idlineaentrada As Cdatos.bdcampo
    Public ALK_bultos As Cdatos.bdcampo
    Public ALK_kilos As Cdatos.bdcampo

    Public ALK_IdUsuarioLog As Cdatos.bdcampo
    Public ALK_FechaLog As Cdatos.bdcampo
    Public ALK_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Albentrada_lineas As New E_AlbEntrada_lineas(idUsuario, cn)

        Try
            NombreTabla = "AlbEntrada_lineaskilos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ALK_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            ALK_idlineaentrada = New Cdatos.bdcampo(CodigoEntidad & "idlineaentrada", Cdatos.TiposCampo.EnteroPositivo, 6, 0, False, Albentrada_lineas, Albentrada_lineas.AEL_idlinea, Albentrada_lineas.AEL_idgenero)
            ALK_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.EnteroPositivo, 5, 0, False)
            ALK_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 6, 2)

            ALK_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ALK_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ALK_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
