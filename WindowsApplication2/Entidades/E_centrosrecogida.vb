Public Class E_centrosrecogida
    Inherits Cdatos.Entidad


    Public CER_Idrecogida As Cdatos.bdcampo
    Public CER_Nombre As Cdatos.bdcampo
    Public CER_EntradaAlhondiga As Cdatos.bdcampo
    Public CER_IdAlmacenEnvases As Cdatos.bdcampo
    Public CER_CopiasBoletinMuestreo As Cdatos.bdcampo
    Public CER_CopiasAlbaranEntrada As Cdatos.bdcampo

    Public CER_IdUsuarioLog As Cdatos.bdcampo
    Public CER_FechaLog As Cdatos.bdcampo
    Public CER_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Centrosrecogida"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CER_Idrecogida = New Cdatos.bdcampo(CodigoEntidad & "Idrecogida", Cdatos.TiposCampo.Entero, 3, 0, True)
            CER_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            CER_EntradaAlhondiga = New Cdatos.bdcampo(CodigoEntidad & "EntradaAlhondiga", Cdatos.TiposCampo.Cadena, 1)
            CER_IdAlmacenEnvases = New Cdatos.bdcampo(CodigoEntidad & "IdAlmacenEnvases", Cdatos.TiposCampo.Entero, 3)
            CER_CopiasBoletinMuestreo = New Cdatos.bdcampo(CodigoEntidad & "CopiasBoletinMuestreo", Cdatos.TiposCampo.Entero, 2)
            CER_CopiasAlbaranEntrada = New Cdatos.bdcampo(CodigoEntidad & "CopiasAlbaranEntrada", Cdatos.TiposCampo.Entero, 2)

            CER_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CER_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CER_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select CER_Idrecogida as IdRecogida, CER_Nombre as Nombre, CER_EntradaAlhondiga as EntradaAlbaran from CentrosRecogida"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idrecogida"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCentroRecogida"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmCrecogida"

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select CER_Idrecogida as IdRecogida, CER_Nombre as Nombre from CentrosRecogida order by CER_idrecogida")

        Return dt
    End Function

End Class
