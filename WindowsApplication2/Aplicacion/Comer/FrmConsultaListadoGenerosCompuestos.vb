
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoGenerosCompuestos
    Inherits FrConsulta

    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosCompuestos As New E_GenerosCompuestos(Idusuario, cn)
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

        Dim sel As String = "Select NetAgroComer.dbo.GenerosCompuestos.GEC_idgenerocompuesto AS idgenerocompuesto,"
        sel = sel & "NetAgroComer.dbo.GenerosCompuestos.GEC_idgenero AS idgenero, "
        sel = sel & "NetAgroComer.dbo.Generos.GEN_NombreGenero AS nombregenero, "
        sel = sel & "Generos2.GEN_NombreGenero AS nombregenerocompuesto, "
        sel = sel & "NetAgroComer.dbo.GenerosCompuestos.GEC_porcentaje AS porcentaje "
        Dim fr As String = "from NetAgroComer.dbo.GenerosCompuestos"
        fr = fr & " LEFT OUTER JOIN NetAgroComer.dbo.Generos ON NetAgroComer.dbo.GenerosCompuestos.GEC_idgenero = NetAgroComer.dbo.Generos.GEN_IdGenero"
        fr = fr & " LEFT OUTER JOIN Generos as Generos2 on GenerosCompuestos.GEC_idgenerocompuesto = generos2.gen_Idgenero "

        Dim sql As String = sel & fr

        GridView1.Columns.Clear()
        Dim dt As DataTable = GenerosCompuestos.MiConexion.ConsultaSQL(Sql)
        Grid.DataSource = dt
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("idgenero")) Then
            GridView1.Columns.ColumnByFieldName("idgenero").GroupIndex = 1
            GridView1.Columns.ColumnByFieldName("nombregenero").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If
        AjustaColumnas()

    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "NOMBREGENEROCOMPUESTO"
                    c.Visible = True
                    c.Width = 80
                Case "IDGENERO"
                    c.Visible = True
                    c.Width = 5
                Case "IDGENEROG"
                    c.Visible = True
                    c.Width = 5
                Case "NOMBREGENERO"
                    c.Visible = True
                    c.Width = 5
                Case "IDGENEROCOMPUESTO"
                    c.Visible = True
                    c.Width = 5
                Case "PORCENTAJE"
                    c.Visible = True
                    c.Width = 5
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub

End Class