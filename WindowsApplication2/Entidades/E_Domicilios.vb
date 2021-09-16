Public Class E_Domicilios
    Inherits Cdatos.Entidad

    Public DOM_Id As Cdatos.bdcampo
    Public DOM_IdCliente As Cdatos.bdcampo
    Public DOM_Domicilio As Cdatos.bdcampo
    Public DOM_Poblacion As Cdatos.bdcampo
    Public DOM_Provincia As Cdatos.bdcampo
    Public DOM_Kilos As Cdatos.bdcampo
    Public DOM_Precio As Cdatos.bdcampo

    Public DOM_IdUsuarioLog As Cdatos.bdcampo
    Public DOM_FechaLog As Cdatos.bdcampo
    Public DOM_HoraLog As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Domicilios"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            DOM_Id = New Cdatos.bdcampo(CodigoEntidad & "iddomicilio", Cdatos.TiposCampo.Entero, 5, 0, True)
            DOM_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "Idcliente", Cdatos.TiposCampo.Entero, 5)
            DOM_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 50)
            DOM_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            DOM_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            DOM_Kilos = New Cdatos.bdcampo(CodigoEntidad & "Kilos", Cdatos.TiposCampo.Entero, 5)
            DOM_Precio = New Cdatos.bdcampo(CodigoEntidad & "Precio", Cdatos.TiposCampo.Importe, 7, 4)

            DOM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DOM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DOM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Overrides Function MaxId(Optional ByVal v As Integer = 0) As Integer

        Try

            Dim max As Integer = 0
            Dim existe As Boolean = True

            While existe = True
                max = ValorMaximo("")
                existe = ExisteId(max.ToString)
            End While

            Return max

        Catch ex As Exception
            err.MuestraError("No se pudo obtener el maximo", "Function ObtieneMax() As Integer", ex.Message)
            Return 0
        End Try

    End Function



End Class
