Public Class E_CategoriasComercial

    Inherits Cdatos.Entidad

    Public CAC_IdCategoria As Cdatos.bdcampo
    Public CAC_Nombre As Cdatos.bdcampo

    Public CAC_IdUsuarioLog As Cdatos.bdcampo
    Public CAC_FechaLog As Cdatos.bdcampo
    Public CAC_HoraLog As Cdatos.bdcampo


    Public BtBuscaCom As New BtBusca
    Public BtBuscaFam As New BtBusca
    Public BtBuscaComCliente As New BtBusca

    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CategoriasComercial"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CAC_IdCategoria = New Cdatos.bdcampo(CodigoEntidad & "IdCategoria", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            CAC_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)

            CAC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CAC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CAC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select CAC_Idcategoria as Id, CAC_Nombre as Nombre from CategoriasComercial"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCatComercial"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmCatComercial"




        Dim Consulta2 As New Cdatos.E_select

        Dim Sql As String

        Consulta2.SelCampo(FamiliasCategorias.FAC_idCategoriaComercial, "IdCategoria")
        Consulta2.SelCampo(Me.CAC_Nombre, "Categoria", FamiliasCategorias.FAC_idCategoriaComercial)
        Consulta2.SelCampo(FamiliasCategorias.FAC_Idfamilia, "IdFamilia")
        Consulta2.WheCampo(FamiliasCategorias.FAC_idCategoriaComercial, ">", "0")


        Sql = Consulta2.SQL



        BtBuscaCom.CL_CampoOrden = "Categoria"
        BtBuscaCom.CL_ConsultaSql = Sql
        BtBuscaCom.CL_ControlAsociado = Nothing
        BtBuscaCom.CL_DevuelveCampo = "IdCategoria"
        BtBuscaCom.CL_Entidad = Me
        BtBuscaCom.CL_Filtro = Nothing
        BtBuscaCom.Name = "BtCateFam"
        BtBuscaCom.CL_ch1000 = False

        BtBuscaCom.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaCom.Location = New System.Drawing.Point(134, 303)
        BtBuscaCom.Size = New System.Drawing.Size(33, 23)
        BtBuscaCom.UseVisualStyleBackColor = True


        BtBuscaCom.Params("IdFamilia", , -1)
        BtBuscaCom.cl_formu = "FrmCatSalida"




        
        Dim sqlPedidos As String = "SELECT DISTINCT PCC_IdCategoria as IdCategoria, PCC_nomcate as Categoria, FAC_Idfamilia as IdFamilia " & vbCrLf
        sqlPedidos = sqlPedidos & " FROM Pedidos_Clientes" & vbCrLf
        sqlPedidos = sqlPedidos & " INNER JOIN FamiliasCategorias ON FAC_idCategoriaComercial = PCC_IdCategoria" & vbCrLf
        sqlPedidos = sqlPedidos & " WHERE PCC_Activo = 'S' " & vbCrLf
        sqlPedidos = sqlPedidos & " AND PCC_IdCategoria > 0" & vbCrLf
        sqlPedidos = sqlPedidos & " AND FAC_idCategoriaComercial > 0 " & vbCrLf


        BtBuscaComCliente.CL_CampoOrden = "Categoria"
        BtBuscaComCliente.CL_ConsultaSql = sqlPedidos
        BtBuscaComCliente.CL_ControlAsociado = Nothing
        BtBuscaComCliente.CL_DevuelveCampo = "IdCategoria"
        BtBuscaComCliente.CL_Entidad = Me
        BtBuscaComCliente.CL_Filtro = Nothing
        BtBuscaComCliente.Name = "BtBuscaComCliente"
        BtBuscaComCliente.CL_ch1000 = False

        BtBuscaComCliente.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaComCliente.Location = New System.Drawing.Point(134, 303)
        BtBuscaComCliente.Size = New System.Drawing.Size(33, 23)
        BtBuscaComCliente.UseVisualStyleBackColor = True


        BtBuscaComCliente.Params("IdFamilia", , -1)
        BtBuscaComCliente.cl_formu = "FrmPedidos"



    End Sub



End Class
