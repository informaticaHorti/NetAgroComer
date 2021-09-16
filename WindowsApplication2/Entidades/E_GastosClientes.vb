Public Class E_GastosClientes
    Inherits Cdatos.Entidad

    Public GCL_Idlinea As Cdatos.bdcampo
    Public GCL_IdCliente As Cdatos.bdcampo
    Public GCL_TipoAFC As Cdatos.bdcampo
    Public GCL_IdGasto As Cdatos.bdcampo
    Public GCL_ValorGasto As Cdatos.bdcampo
    Public GCL_IdAcreedor As Cdatos.bdcampo

    Public GCL_IdUsuarioLog As Cdatos.bdcampo
    Public GCL_FechaLog As Cdatos.bdcampo
    Public GCL_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "GastosClientes"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GCL_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "Idlinea", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            GCL_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            GCL_TipoAFC = New Cdatos.bdcampo(CodigoEntidad & "TipoAFC", Cdatos.TiposCampo.Cadena, 1)
            GCL_IdGasto = New Cdatos.bdcampo(CodigoEntidad & "IdGasto", Cdatos.TiposCampo.EnteroPositivo, 5)
            GCL_ValorGasto = New Cdatos.bdcampo(CodigoEntidad & "ValorGasto", Cdatos.TiposCampo.Importe, 12, 6)
            GCL_IdAcreedor = New Cdatos.bdcampo(CodigoEntidad & "IdAcreedor", Cdatos.TiposCampo.EnteroPositivo, 5)

            GCL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GCL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GCL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




    End Sub



End Class
