Public Class E_partedestrio_lineas
    Inherits Cdatos.Entidad

    Public PDL_idlinea As Cdatos.bdcampo
    Public PDL_idparte As Cdatos.bdcampo
    Public PDL_idgenero As Cdatos.bdcampo
    Public PDL_kilos As Cdatos.bdcampo




    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "partedestrio_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PDL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PDL_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 6)
            PDL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PDL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 18, 2)




            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
