Public Class E_GastosComercio
    Inherits Cdatos.Entidad

    Public GCO_Idgasto As Cdatos.bdcampo
    Public GCO_Nombre As Cdatos.bdcampo
    Public GCO_Tipobkp As Cdatos.bdcampo
    Public GCO_idgrupo As Cdatos.bdcampo
    Public GCO_idacreedor As Cdatos.bdcampo
    Public GCO_Tipogastofc As Cdatos.bdcampo

    Public GCO_IdUsuarioLog As Cdatos.bdcampo
    Public GCO_FechaLog As Cdatos.bdcampo
    Public GCO_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "GastosComercio"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GCO_Idgasto = New Cdatos.bdcampo(CodigoEntidad & "Idgasto", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            GCO_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            GCO_idgrupo = New Cdatos.bdcampo(CodigoEntidad & "idgrupo", Cdatos.TiposCampo.EnteroPositivo, 3)
            GCO_Tipobkp = New Cdatos.bdcampo(CodigoEntidad & "Tipobkp", Cdatos.TiposCampo.Cadena, 1)
            GCO_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.EnteroPositivo, 5)
            GCO_Tipogastofc = New Cdatos.bdcampo(CodigoEntidad & "tipogastofc", Cdatos.TiposCampo.Cadena, 1)

            GCO_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GCO_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GCO_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select GCO_Idgasto as IdGasto, GCO_Nombre as Nombre, GCO_tipobkp as TipoBKP,GCO_tipogastofc as FC from GastosComercio"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idgasto"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaGastosComercio"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "Frmgastoscomercio"


    End Sub



End Class
