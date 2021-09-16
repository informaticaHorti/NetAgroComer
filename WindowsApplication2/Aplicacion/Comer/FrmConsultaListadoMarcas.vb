
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoMarcas
    Inherits FrConsulta

    Dim Marcas As New E_Marcas(Idusuario, cn)

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
        consulta.SelCampo(Marcas.MAR_Idmarca, "codigo")
        consulta.SelCampo(Marcas.MAR_Nombre, "nombre")

        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)


        GridView1.Columns.Clear()
        Dim dt As DataTable = Marcas.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO", "NOMBRE"
                    c.Visible = True

                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()
    End Sub
End Class