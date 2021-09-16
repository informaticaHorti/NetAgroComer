Public Class E_ProgramasCalidad

    Inherits Cdatos.Entidad

    Public PCL_IdPrograma As Cdatos.bdcampo
    Public PCL_Nombre As Cdatos.bdcampo
    Public PCL_ControladoSN As Cdatos.bdcampo

    Public PCL_IdUsuarioLog As Cdatos.bdcampo
    Public PCL_FechaLog As Cdatos.bdcampo
    Public PCL_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ProgramasCalidad"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE TecnicosNet
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PCL_IdPrograma = New Cdatos.bdcampo(CodigoEntidad & "IdPrograma", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PCL_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            PCL_ControladoSN = New Cdatos.bdcampo(CodigoEntidad & "ControladoSN", Cdatos.TiposCampo.Cadena, 1)

            PCL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PCL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PCL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "SELECT PCL_IdPrograma as Id, PCL_Nombre as Nombre, PCL_ControladoSN as Controlado FROM ProgramasCalidad"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaProgCalidad"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
