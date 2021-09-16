Public Class E_partes_Ventas
    Inherits Cdatos.Entidad

    Public PVL_idlinea As Cdatos.bdcampo
    Public PVL_idparte As Cdatos.bdcampo
    Public PVL_idgenero As Cdatos.bdcampo
    Public PVL_idcategoria As Cdatos.bdcampo
    Public PVL_idalbaran As Cdatos.bdcampo
    Public PVL_kilossalida As Cdatos.bdcampo
    Public PVL_iventa As Cdatos.bdcampo
    Public PVL_GastosF As Cdatos.bdcampo
    Public PVL_GastosC As Cdatos.bdcampo
    Public PVL_Estructura As Cdatos.bdcampo
    Public PVL_Materiales As Cdatos.bdcampo
    Public PVL_Manipulacion As Cdatos.bdcampo

    Public PVL_IdUsuarioLog As Cdatos.bdcampo
    Public PVL_FechaLog As Cdatos.bdcampo
    Public PVL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "partes_ventas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PVL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PVL_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 6)
            PVL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PVL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PVL_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            PVL_kilossalida = New Cdatos.bdcampo(CodigoEntidad & "kilossalida", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_iventa = New Cdatos.bdcampo(CodigoEntidad & "iventa", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_GastosF = New Cdatos.bdcampo(CodigoEntidad & "gastosF", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_GastosC = New Cdatos.bdcampo(CodigoEntidad & "gastosC", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_Estructura = New Cdatos.bdcampo(CodigoEntidad & "estructura", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_Materiales = New Cdatos.bdcampo(CodigoEntidad & "materiales", Cdatos.TiposCampo.Importe, 18, 2)
            PVL_Manipulacion = New Cdatos.bdcampo(CodigoEntidad & "manipulacion", Cdatos.TiposCampo.Importe, 18, 2)

            PVL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PVL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PVL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
