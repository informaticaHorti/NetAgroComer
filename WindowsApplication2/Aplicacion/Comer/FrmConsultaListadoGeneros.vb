
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaListadoGeneros
    Inherits FrConsulta

    Dim Generos As New E_Generos(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasGeneros As New E_FamiliasGeneros(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim CategoriaEntrada As New E_CategoriasEntrada(Idusuario, cn)

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
        consulta.SelCampo(Generos.GEN_IdGenero, "codigo")
        consulta.SelCampo(Generos.GEN_NombreGenero, "genero")
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia")
        consulta.SelCampo(Generos.GEN_Abreviacion, "abreviacion")
        consulta.SelCampo(SubFamilias.SFA_nombre, "subfamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "idfamilia")
        consulta.SelCampo(SubFamilias.SFA_codigo, "codigosfa")
        consulta.SelCampo(FamiliasGeneros.FAG_idfamilia, "idfamilia")
        consulta.SelCampo(FamiliasGeneros.FAG_nombre, "familia", SubFamilias.SFA_idfamilia, FamiliasGeneros.FAG_idfamilia)
        consulta.SelCampo(Envases.ENV_Nombre, "envase", Generos.GEN_IdEnvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(CategoriaEntrada.CAE_Id, "idcae")
        consulta.SelCampo(CategoriaEntrada.CAE_Categoria, "categoria", Generos.GEN_Idcategoria, CategoriaEntrada.CAE_Id)

        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)

        GridView1.Columns.Clear()
        Dim dt As DataTable = Generos.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO", "GENERO", "SUBFAMILIA", "FAMILIA", "ABREVIACION", "ENVASE", "CATEGORIA"
                    c.Visible = True

                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

    End Sub
End Class