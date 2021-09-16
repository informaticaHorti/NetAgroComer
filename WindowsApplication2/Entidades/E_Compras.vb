Public Class E_Compras
    Inherits Cdatos.Entidad

    Public COM_IdGenero As Cdatos.bdcampo
    Public COM_KilosComprados As Cdatos.bdcampo
    Public COM_BultosComprados As Cdatos.bdcampo

    Public COM_IdUsuarioLog As Cdatos.bdcampo
    Public COM_FechaLog As Cdatos.bdcampo
    Public COM_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()

        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)
        Try
            NombreTabla = "Compras"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            COM_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 5, 0, True)
            COM_KilosComprados = New Cdatos.bdcampo(CodigoEntidad & "kiloscomprados", Cdatos.TiposCampo.Importe, 10, 2)
            COM_BultosComprados = New Cdatos.bdcampo(CodigoEntidad & "bultoscomprados", Cdatos.TiposCampo.Importe, 10)

            COM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            COM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            COM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub




End Class
