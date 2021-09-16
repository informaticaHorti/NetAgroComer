Public Class E_GenerosTecnicos

    Inherits Cdatos.Entidad

    Public GEN_IdGenero As Cdatos.bdcampo
    Public GEN_Nombre As Cdatos.bdcampo
    Public GEN_IdFamilia As Cdatos.bdcampo

    Public GEN_IdUsuarioLog As Cdatos.bdcampo
    Public GEN_FechaLog As Cdatos.bdcampo
    Public GEN_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.new(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)
        Try
            NombreTabla = "Generos"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            GEN_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 6, , True)
            GEN_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            GEN_IdFamilia = New Cdatos.bdcampo(CodigoEntidad & "IdFamilia", Cdatos.TiposCampo.Entero, 4)

            GEN_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GEN_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GEN_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error al crear Entidad", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "SELECT GEN_IdGenero as Id, GEN_Nombre as Nombre, GEN_IdFamilia as Familia FROM Generos"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaGeneros"
        _btBusca.CL_ch1000 = False



    End Sub

End Class
