Public Class E_Idiomas

    Inherits Cdatos.Entidad
    Public Ididioma As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Idiomas"
            MiConexion = conexion
            NombreBd = "Comun"

            Ididioma = New Cdatos.bdcampo(CodigoEntidad & "Ididioma", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select IdIdioma, Nombre from Idiomas"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdIdioma"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaIdiomas"
        _btBusca.CL_ch1000 = False



    End Sub

End Class
