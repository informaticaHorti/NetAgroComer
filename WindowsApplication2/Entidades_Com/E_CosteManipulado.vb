Public Class E_CosteManipulado
    Inherits Cdatos.Entidad

    Public CMP_Id As Cdatos.bdcampo
    Public CMP_Fecha As Cdatos.bdcampo
    Public CMP_IdCentro As Cdatos.bdcampo
    Public CMP_Linea As Cdatos.bdcampo
    Public CMP_Tarea As Cdatos.bdcampo
    Public CMP_CosteKilo As Cdatos.bdcampo

    Public CMP_IdUsuarioLog As Cdatos.bdcampo
    Public CMP_FechaLog As Cdatos.bdcampo
    Public CMP_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CosteManipulado"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CMP_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 8, 0, True)
            CMP_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)
            CMP_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 3)
            CMP_Linea = New Cdatos.bdcampo(CodigoEntidad & "Linea", Cdatos.TiposCampo.Entero, 8)
            CMP_Tarea = New Cdatos.bdcampo(CodigoEntidad & "Tarea", Cdatos.TiposCampo.Entero, 8)
            CMP_CosteKilo = New Cdatos.bdcampo(CodigoEntidad & "CosteKilo", Cdatos.TiposCampo.Importe, 18, 4)

            CMP_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CMP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CMP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
