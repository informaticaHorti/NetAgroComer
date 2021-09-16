Public Class E_Generos
    Inherits Cdatos.Entidad


    Public GEN_IdGenero As Cdatos.bdcampo
    Public GEN_NombreGenero As Cdatos.bdcampo
    Public GEN_IdsubFamilia As Cdatos.bdcampo
    Public GEN_Abreviacion As Cdatos.bdcampo
    Public GEN_IdEnvase As Cdatos.bdcampo
    Public GEN_Idcategoria As Cdatos.bdcampo
    Public GEN_GastoConfeccion As Cdatos.bdcampo
    'Public GEN_IdGeneroTecnicos As Cdatos.bdcampo

    Public GEN_IdUsuarioLog As Cdatos.bdcampo
    Public GEN_FechaLog As Cdatos.bdcampo
    Public GEN_HoraLog As Cdatos.bdcampo



    Public BtBuscaGenerosCliente As BtBusca



    Dim err As Errores
    Public Sub New()

        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)
        Dim Familia As New E_FamiliasGeneros(idUsuario, cn)
        Dim Envase As New E_Envases(idUsuario, cn)
        Try
            NombreTabla = "Generos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GEN_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 5, 0, True)
            GEN_NombreGenero = New Cdatos.bdcampo(CodigoEntidad & "NombreGenero", Cdatos.TiposCampo.Cadena, 40)
            GEN_IdsubFamilia = New Cdatos.bdcampo(CodigoEntidad & "IdsubFamilia", Cdatos.TiposCampo.Entero, 4)
            GEN_Abreviacion = New Cdatos.bdcampo(CodigoEntidad & "abreviacion", Cdatos.TiposCampo.Cadena, 25)
            GEN_IdEnvase = New Cdatos.bdcampo(CodigoEntidad & "Idenvase", Cdatos.TiposCampo.Entero, 5)
            GEN_Idcategoria = New Cdatos.bdcampo(CodigoEntidad & "Idcategoria", Cdatos.TiposCampo.Entero, 5)
            GEN_GastoConfeccion = New Cdatos.bdcampo(CodigoEntidad & "GastoConfeccion", Cdatos.TiposCampo.Importe, 10, 4)

            'GEN_IdGeneroTecnicos = New Cdatos.bdcampo(CodigoEntidad & "IdGeneroTecnicos", Cdatos.TiposCampo.Cadena, 5)

            GEN_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GEN_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GEN_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "NombreGenero"
        _btBusca.CL_ConsultaSql = "Select GEN_IdGenero as IdGenero, GEN_NombreGenero as NombreGenero from Generos"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdGenero"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.cl_formu = Nothing
        _btBusca.Name = "BtBuscaGenero"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmGeneros"



        'BtBusca géneros de cliente (pedidos_cliente)
        BtBuscaGenerosCliente = New BtBusca()
        BtBuscaGenerosCliente.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaGenerosCliente.Location = New System.Drawing.Point(134, 303)
        BtBuscaGenerosCliente.Size = New System.Drawing.Size(33, 23)
        BtBuscaGenerosCliente.UseVisualStyleBackColor = True

        BtBuscaGenerosCliente.CL_CampoOrden = "NombreGenero"
        BtBuscaGenerosCliente.CL_ConsultaSql = "SELECT DISTINCT PCC_IdGenero as IdGenero, GEN_NombreGenero as NombreGenero FROM Pedidos_Clientes LEFT JOIN Generos ON GEN_IdGenero = PCC_IdGenero WHERE PCC_Activo = 'S' AND PCC_IdGenero > 0"
        BtBuscaGenerosCliente.CL_ControlAsociado = Nothing
        BtBuscaGenerosCliente.CL_DevuelveCampo = "IdGenero"
        BtBuscaGenerosCliente.CL_Entidad = Me
        BtBuscaGenerosCliente.CL_Filtro = Nothing
        BtBuscaGenerosCliente.cl_formu = Nothing
        BtBuscaGenerosCliente.Name = "BtBuscaGenerosCliente"
        BtBuscaGenerosCliente.CL_ch1000 = False
        BtBuscaGenerosCliente.cl_formu = "FrmPedidos"


    End Sub

    Public Function idfamiliagenero()
        Dim Subfamilias As New E_Subfamilias(Idusuario, cn)

        If Subfamilias.LeerId(Me.GEN_IdsubFamilia.Valor) = True Then
            Return Subfamilias.SFA_idfamilia.Valor
        Else
            Return ""
        End If


    End Function

End Class
