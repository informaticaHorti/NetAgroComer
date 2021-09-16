
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaListadoCatSalida
    Inherits FrConsulta
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim TiposCategorias As New E_TiposdeCategoria(Idusuario, cn)


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False

        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub
    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(CategoriasSalida.CAS_Id, "codigo")
        consulta.SelCampo(CategoriasSalida.CAS_Categoria, "categoria")
        consulta.SelCampo(CategoriasSalida.CAS_Calibre, "calibre")
        consulta.SelCampo(CategoriasEntrada.CAE_Id, "idcategoriaentrada")
        consulta.SelCampo(CategoriasEntrada.CAE_Categoria, "categoriaentrada", CategoriasSalida.CAS_IdCategoriaEntrada, CategoriasEntrada.CAE_Id)
        consulta.SelCampo(TiposCategorias.TCA_Id, "idtipocategoria")
        consulta.SelCampo(TiposCategorias.TCA_Nombre, "tipocategoria", CategoriasSalida.CAS_IdTipoCategoria, TiposCategorias.TCA_Id)


        Dim sql As String = consulta.Sel
        GridView1.Columns.Clear()
        Dim dt As DataTable = CategoriasSalida.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO", "CATEGORIA", "CALIBRE", "CATEGORIAENTRADA", "TIPOCATEGORIA"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()
    End Sub
End Class