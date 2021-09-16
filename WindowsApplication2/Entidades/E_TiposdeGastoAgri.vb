Public Class E_TiposdeGastoAgri
    Inherits Cdatos.Entidad

    Public TGA_Idtipogasto As Cdatos.bdcampo
    Public TGA_Nombre As Cdatos.bdcampo
    Public TGA_Tipo As Cdatos.bdcampo
    Public TGA_idgrupo As Cdatos.bdcampo
    Public TGA_Cuenta As Cdatos.bdcampo
    Public TGA_Origen As Cdatos.bdcampo
    Public TGA_idacreedor As Cdatos.bdcampo
    Public TGA_tipogastofc As Cdatos.bdcampo
    Public TGA_ImprimirEnEntrada As Cdatos.bdcampo

    Public TGA_IdUsuarioLog As Cdatos.bdcampo
    Public TGA_FechaLog As Cdatos.bdcampo
    Public TGA_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TiposdeGastosAgri"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TGA_Idtipogasto = New Cdatos.bdcampo(CodigoEntidad & "Idtipogasto", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            TGA_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            TGA_Tipo = New Cdatos.bdcampo(CodigoEntidad & "Tipo", Cdatos.TiposCampo.Cadena, 1)
            TGA_idgrupo = New Cdatos.bdcampo(CodigoEntidad & "idgrupo", Cdatos.TiposCampo.EnteroPositivo, 2)
            TGA_Cuenta = New Cdatos.bdcampo(CodigoEntidad & "cuenta", Cdatos.TiposCampo.Cuenta, 11)
            TGA_Origen = New Cdatos.bdcampo(CodigoEntidad & "origen", Cdatos.TiposCampo.Cadena, 2)
            TGA_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.EnteroPositivo, 5)
            TGA_tipogastofc = New Cdatos.bdcampo(CodigoEntidad & "Tipogastofc", Cdatos.TiposCampo.Cadena, 1)
            TGA_ImprimirEnEntrada = New Cdatos.bdcampo(CodigoEntidad & "ImprimirEnEntrada", Cdatos.TiposCampo.Cadena, 1)

            TGA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TGA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TGA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = ""
        sql = " SELECT TGA_idtipogasto as IdTipoGasto, TGA_nombre as Nombre, TGA_tipo as Tipo, "
        sql = sql + " ORG_nombre AS Grupo"
        sql = sql + " FROM TiposdeGastosAgri INNER JOIN"
        sql = sql + " origengastos ON TGA_idgrupo = ORG_idorigen"


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idtipogasto"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTiposdeGastosAgri"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTiposdeGastosAgri"

    End Sub

End Class
