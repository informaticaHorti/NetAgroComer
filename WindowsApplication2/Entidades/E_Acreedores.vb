Public Class E_Acreedores
    Inherits Cdatos.Entidad

    Public ACR_Codigo As Cdatos.bdcampo
    Public ACR_Nombre As Cdatos.bdcampo
    Public ACR_Nif As Cdatos.bdcampo
    Public ACR_Domicilio As Cdatos.bdcampo
    Public ACR_Poblacion As Cdatos.bdcampo
    Public ACR_Provincia As Cdatos.bdcampo
    Public ACR_CPostal As Cdatos.bdcampo
    Public ACR_Telefono1 As Cdatos.bdcampo
    Public ACR_Telefono2 As Cdatos.bdcampo
    Public ACR_Fax As Cdatos.bdcampo
    Public ACR_Mail As Cdatos.bdcampo
    Public ACR_IdCuenta As Cdatos.bdcampo
    Public ACR_PorceRet As Cdatos.bdcampo
    Public ACR_PorceIva As Cdatos.bdcampo
    Public ACR_CuentaGasto As Cdatos.bdcampo
    Public ACR_IdBanco As Cdatos.bdcampo
    Public ACR_IdTipo As Cdatos.bdcampo
    Public ACR_Dias As Cdatos.bdcampo
    Public ACR_CodigoFianza As Cdatos.bdcampo


    Public ACR_IdUsuarioLog As Cdatos.bdcampo
    Public ACR_FechaLog As Cdatos.bdcampo
    Public ACR_HoraLog As Cdatos.bdcampo


    Public BtBuscaXtipo As BtBusca

    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Vendedor As New E_Vendedores(idUsuario, cn)
        Try

            NombreTabla = "Acreedores"
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            MiConexion = conexion

            ACR_Codigo = New Cdatos.bdcampo(CodigoEntidad & "Codigo", Cdatos.TiposCampo.Entero, 5, 0, True)
            ACR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            ACR_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            ACR_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 150)
            ACR_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            ACR_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            ACR_CPostal = New Cdatos.bdcampo(CodigoEntidad & "CPostal", Cdatos.TiposCampo.Cadena, 7)
            ACR_Telefono1 = New Cdatos.bdcampo(CodigoEntidad & "Telefono1", Cdatos.TiposCampo.Cadena, 15)
            ACR_Telefono2 = New Cdatos.bdcampo(CodigoEntidad & "Telefono2", Cdatos.TiposCampo.Cadena, 15)
            ACR_Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 15)
            ACR_Mail = New Cdatos.bdcampo(CodigoEntidad & "Mail", Cdatos.TiposCampo.Cadena, 250)
            ACR_IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "IdCuenta", Cdatos.TiposCampo.Cuenta, 15)
            ACR_PorceRet = New Cdatos.bdcampo(CodigoEntidad & "PorceRet", Cdatos.TiposCampo.Importe, 18, 2)
            ACR_PorceIva = New Cdatos.bdcampo(CodigoEntidad & "PorceIva", Cdatos.TiposCampo.Importe, 18, 2)
            ACR_CuentaGasto = New Cdatos.bdcampo(CodigoEntidad & "Cuentagasto", Cdatos.TiposCampo.Cuenta, 15)
            ACR_IdBanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.EnteroPositivo, 3)
            ACR_IdTipo = New Cdatos.bdcampo(CodigoEntidad & "IdTipo", Cdatos.TiposCampo.EnteroPositivo, 3)
            ACR_Dias = New Cdatos.bdcampo(CodigoEntidad & "Dias", Cdatos.TiposCampo.EnteroPositivo, 3)
            ACR_CodigoFianza = New Cdatos.bdcampo(CodigoEntidad & "CodigoFianza", Cdatos.TiposCampo.Cadena, 70)

            ACR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ACR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ACR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select ACR_Codigo as Codigo, ACR_Nombre as Nombre, ACR_Nif as NIF from Acreedores"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Codigo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAcredores"
        _btBusca.CL_ch1000 = False

        Dim sql As String
        sql = "SELECT     ACR_codigo as codigo, ACR_Nombre as nombre, ORG_Nombre as origen, ORG_Tipo as tipo"
        sql = sql + " FROM         origengastos RIGHT OUTER JOIN"
        sql = sql + "             acreedores_gastos ON ORG_Idorigen = ACG_Idorigengasto RIGHT OUTER JOIN"
        sql = sql + "              Acreedores ON ACG_Idacreedor = ACR_codigo"


        BtBuscaXtipo = New BtBusca()
        BtBuscaXtipo.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaXtipo.Location = New System.Drawing.Point(134, 303)
        BtBuscaXtipo.Size = New System.Drawing.Size(33, 23)
        BtBuscaXtipo.UseVisualStyleBackColor = True

        BtBuscaXtipo.CL_CampoOrden = "nombre"
        BtBuscaXtipo.CL_ConsultaSql = sql
        BtBuscaXtipo.CL_ControlAsociado = Nothing
        BtBuscaXtipo.CL_DevuelveCampo = "codigo"
        BtBuscaXtipo.CL_Entidad = Me
        BtBuscaXtipo.CL_Filtro = Nothing
        BtBuscaXtipo.Name = "BtBuscaAcredores"
        BtBuscaXtipo.CL_ch1000 = False

    End Sub



End Class
