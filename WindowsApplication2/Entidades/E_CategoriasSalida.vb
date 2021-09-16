Public Class E_CategoriasSalida
    Inherits Cdatos.Entidad

    Public CAS_Id As Cdatos.bdcampo
    Public CAS_Categoria As Cdatos.bdcampo
    Public CAS_Calibre As Cdatos.bdcampo
    Public CAS_CategoriaCalibre As Cdatos.bdcampo
    Public CAS_IdTipoCategoria As Cdatos.bdcampo
    Public CAS_IdTipoCalibre As Cdatos.bdcampo
    Public CAS_IdCategoriaEntrada As Cdatos.bdcampo

    Public CAS_IdUsuarioLog As Cdatos.bdcampo
    Public CAS_FechaLog As Cdatos.bdcampo
    Public CAS_HoraLog As Cdatos.bdcampo

    Public BtBuscaComercial As New BtBusca
    Public BtBuscaFamilias As New BtBusca

    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CategoriasSalida"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CAS_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            CAS_Categoria = New Cdatos.bdcampo(CodigoEntidad & "categoria", Cdatos.TiposCampo.Cadena, 25)
            CAS_Calibre = New Cdatos.bdcampo(CodigoEntidad & "calibre", Cdatos.TiposCampo.Cadena, 25)
            CAS_CategoriaCalibre = New Cdatos.bdcampo(CodigoEntidad & "categoriacalibre", Cdatos.TiposCampo.Cadena, 25)
            CAS_IdTipoCategoria = New Cdatos.bdcampo(CodigoEntidad & "idtipocategoria", Cdatos.TiposCampo.Cadena, 1)
            CAS_IdTipoCalibre = New Cdatos.bdcampo(CodigoEntidad & "idtipocalibre", Cdatos.TiposCampo.Cadena, 3)
            CAS_IdCategoriaEntrada = New Cdatos.bdcampo(CodigoEntidad & "idcategoriaentrada", Cdatos.TiposCampo.Cadena, 5)

            CAS_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CAS_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CAS_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "CategoriaCalibre"
        _btBusca.CL_ConsultaSql = "Select CAS_Id as Id, CAS_CategoriaCalibre as CategoriaCalibre from CategoriasSalida"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCatSalida"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmCatSalida"


        Dim catsalidacomercial As New E_CatSalidaComercial(idUsuario, cn)
        Dim categoriascomercial As New E_CategoriasComercial(idUsuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(catsalidacomercial.CSC_idCatsalida, "CatSalida")
        consulta.SelCampo(Me.CAS_CategoriaCalibre, "Nombre", catsalidacomercial.CSC_idCatsalida)
        consulta.SelCampo(catsalidacomercial.CSC_Idcatcomercial, "idcomercial")
        consulta.SelCampo(categoriascomercial.CAC_Nombre, "CatComercial", catsalidacomercial.CSC_Idcatcomercial)

        BtBuscaComercial.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaComercial.CL_CampoOrden = "Nombre"
        BtBuscaComercial.CL_ConsultaSql = consulta.SQL
        BtBuscaComercial.CL_ControlAsociado = Nothing
        BtBuscaComercial.CL_DevuelveCampo = "CatSalida"
        BtBuscaComercial.CL_Entidad = Me
        BtBuscaComercial.CL_Filtro = Nothing
        BtBuscaComercial.Name = "BtBuscaCatSalida"
        BtBuscaComercial.CL_ch1000 = False



        Dim Consulta2 As New Cdatos.E_select

        Dim Sql As String

        Consulta2.SelCampo(FamiliasCategorias.FAC_idCategoriaComercial, "IdCategoria")
        Consulta2.SelCampo(Me.CAS_CategoriaCalibre, "Categoria", FamiliasCategorias.FAC_idCategoriaComercial)
        Consulta2.SelCampo(FamiliasCategorias.FAC_Idfamilia, "IdFamilia")
        Consulta2.WheCampo(FamiliasCategorias.FAC_idCategoriaComercial, ">", "0")

        Sql = Consulta2.SQL + " AND ISNULL(CAS_ID,0)>0"



        BtBuscaFamilias.CL_CampoOrden = "Categoria"
        BtBuscaFamilias.CL_ConsultaSql = Sql
        BtBuscaFamilias.CL_ControlAsociado = Nothing
        BtBuscaFamilias.CL_DevuelveCampo = "IdCategoria"
        BtBuscaFamilias.CL_Entidad = Me
        BtBuscaFamilias.CL_Filtro = Nothing
        BtBuscaFamilias.Name = "BtCateFam"
        BtBuscaFamilias.CL_ch1000 = False

        BtBuscaFamilias.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaFamilias.Location = New System.Drawing.Point(134, 303)
        BtBuscaFamilias.Size = New System.Drawing.Size(33, 23)
        BtBuscaFamilias.UseVisualStyleBackColor = True


        BtBuscaFamilias.Params("IdFamilia", , -1)
        BtBuscaFamilias.cl_formu = "FrmCatSalida"




    End Sub



End Class
