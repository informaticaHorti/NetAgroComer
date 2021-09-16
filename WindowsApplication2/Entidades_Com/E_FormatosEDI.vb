Public Class E_FormatosEDI
    Inherits Cdatos.Entidad

    Public FED_Id As Cdatos.bdcampo
    Public FED_IdFormatoEDI As Cdatos.bdcampo
    Public FED_ProveedorEDI As Cdatos.bdcampo
    Public FED_Campo As Cdatos.bdcampo
    Public FED_ValorCampo As Cdatos.bdcampo

    Public FED_IdUsuarioLog As Cdatos.bdcampo
    Public FED_FechaLog As Cdatos.bdcampo
    Public FED_HoraLog As Cdatos.bdcampo

    Dim err As Errores


    Public Enum Formato
        Ninguno = 0
        'Zenalco = 1
        'Guisona = 2
        'LIDL = 3
        'Mercadona = 4
        'Alcampo = 5
        'DIA = 6
        Edeka = 7
    End Enum




    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        'NOTA: De momento sólo se usa esta tabla en NetAgro_MySql, pero sí se usan los formatos. El enum debería usar los mismos códigos en todos los proyectos, Hortichuelas, Costa, NetAgro_MySql, etc.
        'Por compatibilidad se ha copiado la entidad

        Try
            NombreTabla = "FormatosEDI"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            FED_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 8, 0, True)
            FED_IdFormatoEDI = New Cdatos.bdcampo(CodigoEntidad & "IdFormatoEDI", Cdatos.TiposCampo.Entero, 5)
            FED_ProveedorEDI = New Cdatos.bdcampo(CodigoEntidad & "ProveedorEDI", Cdatos.TiposCampo.Entero, 5)
            FED_Campo = New Cdatos.bdcampo(CodigoEntidad & "Campo", Cdatos.TiposCampo.Cadena, 200)
            FED_ValorCampo = New Cdatos.bdcampo(CodigoEntidad & "ValorCampo", Cdatos.TiposCampo.Cadena, 100)

            FED_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FED_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FED_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
