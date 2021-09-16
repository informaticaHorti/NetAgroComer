Public Class E_Lineas
    Inherits Cdatos.Entidad

    Public LIN_Idlinea As Cdatos.bdcampo
    Public LIN_Nombre As Cdatos.bdcampo
    Public LIN_Idcentro As Cdatos.bdcampo
    Public LIN_ResponsableCalidad As Cdatos.bdcampo
    Public LIN_ResponsableLimpieza As Cdatos.bdcampo
    Public LIN_SoloPrecalibradoSN As Cdatos.bdcampo
    Public LIN_PermitirPrecalibradoSN As Cdatos.bdcampo
    Public LIN_IdLineaCalidad As Cdatos.bdcampo

    Public LIN_IdUsuarioLog As Cdatos.bdcampo
    Public LIN_FechaLog As Cdatos.bdcampo
    Public LIN_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            LIN_Idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            LIN_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            LIN_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "Idcentro", Cdatos.TiposCampo.EnteroPositivo, 3) ' es el punto de venta
            LIN_ResponsableCalidad = New Cdatos.bdcampo(CodigoEntidad & "ResponsableCalidad", Cdatos.TiposCampo.Cadena, 50)
            LIN_ResponsableLimpieza = New Cdatos.bdcampo(CodigoEntidad & "ResponsableLimpieza", Cdatos.TiposCampo.Cadena, 50)
            LIN_SoloPrecalibradoSN = New Cdatos.bdcampo(CodigoEntidad & "SoloPrecalibradoSN", Cdatos.TiposCampo.Cadena, 1)
            LIN_PermitirPrecalibradoSN = New Cdatos.bdcampo(CodigoEntidad & "PermitirPrecalibrado", Cdatos.TiposCampo.Cadena, 1)
            LIN_IdLineaCalidad = New Cdatos.bdcampo(CodigoEntidad & "IdLineaCalidad", Cdatos.TiposCampo.EnteroPositivo, 4)

            LIN_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            LIN_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            LIN_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select lin_Idlinea as Idlinea, LIN_Nombre as Nombre,LIN_idcentro as IdCentro FROM LINEAS"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdLinea"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaLineas"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmLineas"

    End Sub

   
End Class
