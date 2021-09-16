Public Class FrmSubFamCat

    Inherits FrMantenimiento

    Dim Familias As New E_FamiliasGeneros(Idusuario, cn)
    Dim subFamilias As New E_Subfamilias(Idusuario, cn)
    Dim SCatEnt As New E_SubFamCatEnt(Idusuario, cn)
    Dim SCatSal As New E_SubFamCatSal(Idusuario, cn)
    Dim CatEnt As New E_CategoriasEntrada(Idusuario, cn)
    Dim CatSal As New E_CategoriasSalida(Idusuario, cn)


    Dim Primero As Boolean






    Public Overrides Sub borrapan()
        MyBase.BorraPan()

    End Sub




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()
    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
        CargaLineasGridSal()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        SCatEnt.IdSubFam.Valor = LbId.Text
        SCatSal.IdSubFam.Valor = LbId.Text
        Return MyBase.GuardarLineas(Gr)
    End Function

    Public Overrides Sub Guardar()
        Dim a = ""

        MyBase.Guardar()

    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = subFamilias.LeerSubfam(VaInt(TxDato1.Text), VaInt(TxDato2.Text))

    End Sub
    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select subfamcatent.id,categoriasentrada.categoriacalibre as Categoria from subfamcatent,categoriasentrada where idsubfamilia=" + LbId.Text + " and categoriasentrada.id=subfamcatent.idcategoria"
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub



    Private Sub CargaLineasGridsal()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select subfamcatsal.id,categoriassalida.categoriacalibre as Salida,"
        sql = sql + " categoriasentrada.categoriacalibre as Entrada "
        sql = sql + " from subfamcatsal,categoriassalida,categoriasentrada "
        sql = sql + " where subfamcatsal.idsubfamilia=" + LbId.Text + " and "
        sql = sql + " categoriasentrada.id=subfamcatsal.idcategoriaentrada and "
        sql = sql + " categoriassalida.id=subfamcatsal.idcategoria"

        ClGrid2.Consulta = sql
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
    End Sub

    Private Sub parametrosfrm()
        EntidadFrm = subFamilias


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, subFamilias.idfamilia, Lb1, True)
        ParamTx(TxDato2, subFamilias.codigo, Lb2, True)

        CampoClave = 1 ' ultimo campo de la clave
        ParamTx(TxDato5, SCatEnt.idCategoria, Lb11)


        ParamTx(TxDato3, SCatSal.idCategoria, Lb4)
        ParamTx(TxDato4, SCatSal.idCategoriaEntrada, Lb6)


        AsociarControles(TxDato1, BtBuscaFamilia, Familias.btBusca, Familias, Familias.nombre, Lb7)
        AsociarControles(TxDato2, BtBuscaSfam, subFamilias.btBusca, subFamilias)
        AsociarControles(TxDato5, BtBuscaCatEnt1, CatEnt.btBusca, CatEnt, CatEnt.CategoriaCalibre, Lb10)
        AsociarControles(TxDato4, BtBuscaCatEnt2, CatEnt.btBusca, CatEnt, CatEnt.CategoriaCalibre, Lb5)
        AsociarControles(TxDato3, BtBuscaCatSal, CatSal.btBusca, CatSal, CatSal.CategoriaCalibre, Lb3)


        AsociarGrid(ClGrid1, TxDato5, TxDato5, SCatEnt)

        AsociarGrid(ClGrid2, TxDato3, TxDato4, SCatSal)


        PropiedadesCamposGr(ClGrid1, SCatEnt.Id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid1, SCatEnt.idCategoria.NombreCampo, "Categoria", True, 50)


        PropiedadesCamposGr(ClGrid2, SCatSal.Id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid2, SCatSal.idCategoria.NombreCampo, "Categoria", True, 50)
        PropiedadesCamposGr(ClGrid2, SCatSal.idCategoriaEntrada.NombreCampo, "Categoria", True, 50)



       



    End Sub

    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato2.TextChanged

    End Sub

    Private Sub TxDato2_Valida(ByVal edicion As Boolean) Handles TxDato2.Valida
        Dim I As Integer
        If edicion = True Then
            I = subFamilias.LeerSubfam(VaInt(TxDato1.Text), VaInt(TxDato2.Text))
            If I = 0 Then
                TxDato2.MiError = True
            Else
                If subFamilias.LeerId(I.ToString) = True Then
                    Lb8.Text = subFamilias.nombre.Valor
                End If
            End If
        End If
    End Sub

   
    Private Sub TxDato1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub

    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        BtBuscaSfam.CL_Filtro = "Idfamilia=" + TxDato1.Text
    End Sub
End Class