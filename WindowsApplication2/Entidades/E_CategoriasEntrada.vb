Public Class E_CategoriasEntrada
    Inherits Cdatos.Entidad


    Public CAE_Id As Cdatos.bdcampo
    Public CAE_Categoria As Cdatos.bdcampo
    Public CAE_Calibre As Cdatos.bdcampo
    Public CAE_CategoriaCalibre As Cdatos.bdcampo
    Public CAE_IdTipoCategoria As Cdatos.bdcampo
    Public CAE_idtipocalibre As Cdatos.bdcampo
    Public CAE_clasificacion As Cdatos.bdcampo

    Public CAE_IdUsuarioLog As Cdatos.bdcampo
    Public CAE_FechaLog As Cdatos.bdcampo
    Public CAE_HoraLog As Cdatos.bdcampo

    Public bTBuscaEnt As New BtBusca

    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "CategoriasEntrada"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            CAE_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            CAE_Categoria = New Cdatos.bdcampo(CodigoEntidad & "categoria", Cdatos.TiposCampo.Cadena, 25)
            CAE_Calibre = New Cdatos.bdcampo(CodigoEntidad & "calibre", Cdatos.TiposCampo.Cadena, 25)
            CAE_CategoriaCalibre = New Cdatos.bdcampo(CodigoEntidad & "categoriacalibre", Cdatos.TiposCampo.Cadena, 25)
            CAE_IdTipoCategoria = New Cdatos.bdcampo(CodigoEntidad & "idtipocategoria", Cdatos.TiposCampo.Cadena, 1)
            CAE_idtipocalibre = New Cdatos.bdcampo(CodigoEntidad & "idtipocalibre", Cdatos.TiposCampo.Cadena, 3)
            CAE_clasificacion = New Cdatos.bdcampo(CodigoEntidad & "clasificacion", Cdatos.TiposCampo.Cadena, 1)

            CAE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CAE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CAE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "CategoriaCalibre"
        _btBusca.CL_ConsultaSql = "Select CAE_Id as Id, CAE_categoriacalibre as CategoriaCalibre from CategoriasEntrada"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaCatEntrada"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmCatEntrada"


        Dim Consulta As New Cdatos.E_select
        Dim SQL As String



        Consulta.SelCampo(FamiliasCategorias.FAC_idCategoriaentrada, "IdCategoria")
        Consulta.SelCampo(Me.CAE_CategoriaCalibre, "Categoria", FamiliasCategorias.FAC_idCategoriaentrada)
        Consulta.SelCampo(FamiliasCategorias.FAC_Idfamilia, "IdFamilia")
        Consulta.WheCampo(FamiliasCategorias.FAC_idCategoriaentrada, ">", "0")


        Sql = Consulta.SQL



        BtBuscaEnt.CL_CampoOrden = "Categoria"
        BtBuscaEnt.CL_ConsultaSql = Sql
        BtBuscaEnt.CL_ControlAsociado = Nothing
        BtBuscaEnt.CL_DevuelveCampo = "IdCategoria"
        BtBuscaEnt.CL_Entidad = Me
        BtBuscaEnt.CL_Filtro = Nothing
        BtBuscaEnt.Name = "BtCateFam"
        BtBuscaEnt.CL_ch1000 = False
        bTBuscaEnt.Image = Global.NetAgro.My.Resources.Lupa16_
        bTBuscaEnt.Location = New System.Drawing.Point(134, 303)
        bTBuscaEnt.Size = New System.Drawing.Size(33, 23)
        bTBuscaEnt.UseVisualStyleBackColor = True

        bTBuscaEnt.Params("IdFamilia", , -1)
        bTBuscaEnt.cl_formu = "FrmCatEntrada"




    End Sub


End Class
