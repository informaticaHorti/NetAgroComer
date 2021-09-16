
Class E_FamiliasGeneros
    Inherits Cdatos.Entidad

    Public FAG_idfamilia As Cdatos.bdcampo
    Public FAG_nombre As Cdatos.bdcampo
    Public FAG_intrastat1 As Cdatos.bdcampo
    Public FAG_intrastat2 As Cdatos.bdcampo
    Public FAG_desde As Cdatos.bdcampo
    Public FAG_hasta As Cdatos.bdcampo
    Public FAG_valorestadistico As Cdatos.bdcampo
    Public FAG_Acreditado As Cdatos.bdcampo

    Public FAG_IdUsuarioLog As Cdatos.bdcampo
    Public FAG_FechaLog As Cdatos.bdcampo
    Public FAG_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()

        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FamiliasGeneros"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FAG_idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.Entero, 4, 0, True)
            FAG_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 40)
            FAG_intrastat1 = New Cdatos.bdcampo(CodigoEntidad & "intrastat1", Cdatos.TiposCampo.Cadena, 15)
            FAG_intrastat2 = New Cdatos.bdcampo(CodigoEntidad & "intrastat2", Cdatos.TiposCampo.Cadena, 15)
            FAG_desde = New Cdatos.bdcampo(CodigoEntidad & "desde", Cdatos.TiposCampo.CadenaNumero, 4)
            FAG_hasta = New Cdatos.bdcampo(CodigoEntidad & "hasta", Cdatos.TiposCampo.CadenaNumero, 4)
            FAG_valorestadistico = New Cdatos.bdcampo(CodigoEntidad & "valorestadistico", Cdatos.TiposCampo.Importe, 10, 2)

            FAG_Acreditado = New Cdatos.bdcampo(CodigoEntidad & "Acreditado", Cdatos.TiposCampo.Cadena, 1)

            FAG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FAG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select FAG_IdFamilia as IdFamilia, FAG_Nombre as Nombre from FamiliasGeneros"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idfamilia"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFamilias"
        _btBusca.CL_ch1000 = False

    End Sub



End Class

