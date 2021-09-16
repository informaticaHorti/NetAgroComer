Public Class E_DomiciliosFianzas
    Inherits Cdatos.Entidad

    Public DFZ_Id As Cdatos.bdcampo
    Public DFZ_IdDomicilio As Cdatos.bdcampo
    Public DFZ_IdEnvase As Cdatos.bdcampo
    Public DFZ_CodigoFianza As Cdatos.bdcampo

    Public DFZ_IdUsuarioLog As Cdatos.bdcampo
    Public DFZ_FechaLog As Cdatos.bdcampo
    Public DFZ_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DomiciliosFianzas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            DFZ_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            DFZ_IdDomicilio = New Cdatos.bdcampo(CodigoEntidad & "IdDomicilio", Cdatos.TiposCampo.Entero, 10)
            DFZ_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "IdEnvase", Cdatos.TiposCampo.Entero, 6)
            DFZ_CodigoFianza = New Cdatos.bdcampo(CodigoEntidad & "CodigoFianza", Cdatos.TiposCampo.Cadena, 15)


            DFZ_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DFZ_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DFZ_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

End Class
