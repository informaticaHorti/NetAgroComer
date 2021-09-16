Public Class E_OficinasBancarias
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdOficina As Cdatos.bdcampo
    Public IdEntidad As Cdatos.bdcampo
    Public IdCodPostal As Cdatos.bdcampo
    Public NumeroOficina As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Direccion As Cdatos.bdcampo
    Public Poblacion As Cdatos.bdcampo
    Public Provincia As Cdatos.bdcampo
    Public Telefono1 As Cdatos.bdcampo
    Public Telefono2 As Cdatos.bdcampo
    Public Fax As Cdatos.bdcampo
    Public Email As Cdatos.bdcampo
    Public Contacto As Cdatos.bdcampo
    Public Director As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "OficinasBancarias"
            NombreBd = "Comun"
            MiConexion = conexion

           
            IdOficina = New Cdatos.bdcampo(CodigoEntidad & "IdOficina", Cdatos.TiposCampo.CadenaNumero, 10, 0, True)
            IdEntidad = New Cdatos.bdcampo(CodigoEntidad & "IdEntidad", Cdatos.TiposCampo.CadenaNumero, 10)
            IdCodPostal = New Cdatos.bdcampo(CodigoEntidad & "IdCodPostal", Cdatos.TiposCampo.Cadena, 10)
            NumeroOficina = New Cdatos.bdcampo(CodigoEntidad & "NumeroOficina", Cdatos.TiposCampo.Cadena, 4)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            Direccion = New Cdatos.bdcampo(CodigoEntidad & "Direccion", Cdatos.TiposCampo.Cadena, 150)
            Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            Telefono1 = New Cdatos.bdcampo(CodigoEntidad & "Telefono1", Cdatos.TiposCampo.Cadena, 25)
            Telefono2 = New Cdatos.bdcampo(CodigoEntidad & "Telefono2", Cdatos.TiposCampo.Cadena, 25)
            Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 25)
            Email = New Cdatos.bdcampo(CodigoEntidad & "Email", Cdatos.TiposCampo.Cadena, 250)
            Contacto = New Cdatos.bdcampo(CodigoEntidad & "Contacto", Cdatos.TiposCampo.Cadena, 50)
            Director = New Cdatos.bdcampo(CodigoEntidad & "Director", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()


           
            _btBusca.CL_CampoOrden = "Nombre"
            _btBusca.CL_ConsultaSql = "Select idoficina,nombre from OficinasBancarias"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "idoficina"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaOficinaBanco"
            _btBusca.CL_ch1000 = False


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
