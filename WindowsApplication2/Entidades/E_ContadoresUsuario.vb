Public Class E_ContadoresUsuario
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public COU_Id As Cdatos.bdcampo
    Public COU_IdUsuarioCopia As Cdatos.bdcampo
    Public COU_FechaCopia As Cdatos.bdcampo
    Public COU_HoraCopia As Cdatos.bdcampo
    Public COU_Tabla As Cdatos.bdcampo
    Public COU_TipoContador As Cdatos.bdcampo
    Public COU_UltimoNumero As Cdatos.bdcampo
    Public COU_IdUsuario As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "ContadoresUsuario"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            COU_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, , True)
            COU_IdUsuarioCopia = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioCopia", Cdatos.TiposCampo.Entero, 10)
            COU_FechaCopia = New Cdatos.bdcampo(CodigoEntidad & "FechaCopia", Cdatos.TiposCampo.Fecha, 8)
            COU_HoraCopia = New Cdatos.bdcampo(CodigoEntidad & "HoraCopia", Cdatos.TiposCampo.Cadena, 8)    'Formato HH:mm:ss
            COU_Tabla = New Cdatos.bdcampo(CodigoEntidad & "Tabla", Cdatos.TiposCampo.Cadena, 50)
            COU_TipoContador = New Cdatos.bdcampo(CodigoEntidad & "TipoContador", Cdatos.TiposCampo.Cadena, 50)
            COU_UltimoNumero = New Cdatos.bdcampo(CodigoEntidad & "UltimoNumero", Cdatos.TiposCampo.Entero, 10)
            COU_IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
