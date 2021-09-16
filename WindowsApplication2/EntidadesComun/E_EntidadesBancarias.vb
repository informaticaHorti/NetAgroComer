Public Class E_EntidadesBancarias
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdEntidad As Cdatos.bdcampo
    Public NumeroBanco As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public PaginaWeb As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "EntidadesBancarias"
            MiConexion = conexion
            NombreBd = "Comun"

            IdEntidad = New Cdatos.bdcampo(CodigoEntidad & "IdEntidad", Cdatos.TiposCampo.CadenaNumero, 10, 0, True)
            NumeroBanco = New Cdatos.bdcampo(CodigoEntidad & "NumeroBanco", Cdatos.TiposCampo.Cadena, 4)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            PaginaWeb = New Cdatos.bdcampo(CodigoEntidad & "PaginaWeb", Cdatos.TiposCampo.Cadena, 100)


            MiListadeCampos = ListadeCampos()

            _btBusca.CL_CampoOrden = "nombre"
            _btBusca.CL_ConsultaSql = "Select identidad,numerobanco,nombre from Entidadesbancarias"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "identidad"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaEntidadesBanco"
            _btBusca.CL_ch1000 = False


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
