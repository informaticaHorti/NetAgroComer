Public Class E_ValoresEjercicio
    Inherits Cdatos.Entidad

    Public VEJ_IdEjercicio As Cdatos.bdcampo
    Public VEJ_TipoConexion As Cdatos.bdcampo
    Public VEJ_Bloqueada As Cdatos.bdcampo
    
    Public VEJ_IdUsuarioLog As Cdatos.bdcampo
    Public VEJ_FechaLog As Cdatos.bdcampo
    Public VEJ_HoraLog As Cdatos.bdcampo


    Public Enum TipoConexionTecnicos
        TecnicosSQL = 1
        TecnicosNet = 2
    End Enum



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValoresEjercicio"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VEJ_IdEjercicio = New Cdatos.bdcampo(CodigoEntidad & "IdEjercicio", Cdatos.TiposCampo.Entero, 10, 0, True)
            VEJ_TipoConexion = New Cdatos.bdcampo(CodigoEntidad & "TipoConexion", Cdatos.TiposCampo.EnteroPositivo, 2)
            VEJ_Bloqueada = New Cdatos.bdcampo(CodigoEntidad & "Bloqueada", Cdatos.TiposCampo.Cadena, 1)
            
            VEJ_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VEJ_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VEJ_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

End Class
