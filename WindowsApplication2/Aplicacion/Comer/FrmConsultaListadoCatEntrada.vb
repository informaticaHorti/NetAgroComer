
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaListadoCatEntrada
    Inherits FrConsulta

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
        consulta.SelCampo(CategoriasEntrada.CAE_Id, "codigo")
        consulta.SelCampo(CategoriasEntrada.CAE_Categoria, "categoria")
        consulta.SelCampo(CategoriasEntrada.CAE_Calibre, "calibre")
        consulta.SelCampo(TiposCategorias.TCA_Id, "idtca")
        consulta.SelCampo(TiposCategorias.TCA_Nombre, "tipocategoria", CategoriasEntrada.CAE_IdTipoCategoria, TiposCategorias.TCA_Id)


        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)
        GridView1.Columns.Clear()
        Dim dt As DataTable = CategoriasEntrada.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO", "CATEGORIA", "CALIBRE", "TIPOCATEGORIA"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next
        GridView1.BestFitColumns()
    End Sub
End Class