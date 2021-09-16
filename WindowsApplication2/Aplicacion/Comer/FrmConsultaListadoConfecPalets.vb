
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoConfecPalets
    Inherits FrConsulta


    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecPaletLineas As New E_ConfecPaletLineas(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)

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

        Dim consultaRes As New Cdatos.E_select
        Dim consultaDet As New Cdatos.E_select
        Dim sql As String = ""

        'Consulta Resumido

        consultaRes.SelCampo(ConfecPalet.CPA_Idconfec, "confeccion")
        consultaRes.SelCampo(ConfecPalet.CPA_Nombre, "nombreconfeccion")
        consultaRes.SelCampo(ConfecPalet.CPA_Abreviatura, "abreviatura")
        consultaRes.SelCampo(ConfecPalet.CPA_IncrementoTara, "incrementotara")
        consultaRes.SelCampo(ConfecPalet.CPA_TotalCoste, "totalcoste")
        consultaRes.SelCampo(ConfecPalet.CPA_TotalTara, "totaltara")
        consultaRes.SelCampo(ConfecPalet.CPA_IdPalet, "idpalet")
        consultaRes.SelCampo(Palets.PAL_palet, "palet", ConfecPalet.CPA_IdPalet, Palets.PAL_idpalet)

        'Consulta Detallado
        consultaDet.SelCampo(ConfecPaletLineas.CPL_Idmaterial, "material")
        consultaDet.SelCampo(ConfecPalet.CPA_Idconfec, "confeccion", ConfecPaletLineas.CPL_Idconfec)
        consultaDet.SelCampo(ConfecPalet.CPA_Nombre, "nombreconfeccion")
        consultaDet.SelCampo(Palets.PAL_palet, "palet", ConfecPaletLineas.CPL_Idmaterial)
        consultaDet.SelCampo(ConfecPaletLineas.CPL_Cantidad, "cantidad")


        '' Detallado o resumido

        If RbDetallado.Checked Then
            sql = consultaDet.Sel(_IncluirTodosLosCampos)
            GridView1.Columns.Clear()
            Dim dt As DataTable = ConfecPaletLineas.MiConexion.ConsultaSQL(sql)

            Grid.DataSource = dt

            If Not IsNothing(GridView1.Columns.ColumnByFieldName("confeccion")) Then
                GridView1.Columns.ColumnByFieldName("confeccion").GroupIndex = 1
                GridView1.Columns.ColumnByFieldName("nombreconfeccion").GroupIndex = 1
                GridView1.ExpandAllGroups()
            End If
            AjustaColumnasDet()

        ElseIf RbResumido.Checked Then
            sql = consultaRes.Sel(_IncluirTodosLosCampos)
            GridView1.Columns.Clear()
            Dim dt As DataTable = ConfecPalet.MiConexion.ConsultaSQL(sql)
            Grid.DataSource = dt

            AjustaColumnasRes()
        End If

    End Sub
    Private Sub AjustaColumnasDet()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "MATERIAL"
                    c.Visible = True
                    c.Width = 5
                Case "CONFECCION"
                    c.Visible = True
                    c.Width = 5
                Case "NOMBRECONFECCION"
                    c.Visible = True
                    c.Width = 5
                Case "PALET"
                    c.Visible = True
                    c.Width = 5
                Case "CANTIDAD"
                    c.Visible = True
                    c.Width = 5
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub

    Private Sub AjustaColumnasRes()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CONFECCION"
                    c.Visible = True
                    c.Width = 10
                Case "IDPALET"
                    c.Visible = True
                    c.Width = 10
                Case "ABREVIATURA"
                    c.Visible = True
                    c.Width = 40
                Case "INCREMENTOTARA"
                    c.Visible = True
                    c.Width = 25
                Case "NOMBRECONFECCION"
                    c.Visible = True
                    c.Width = 85
                Case "TOTALCOSTE"
                    c.Visible = True
                    c.Width = 20
                Case "TOTALTARA"
                    c.Visible = True
                    c.Width = 15
                Case "PALET"
                    c.Visible = True
                    c.Width = 60
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()
        If RbDetallado.Checked Then
            LineasDescripcion.Add("LISTADO DETALLADO")
        ElseIf RbResumido.Checked Then
            LineasDescripcion.Add("LISTADO RESUMIDO")
        End If


        MyBase.Imprimir()

    End Sub

End Class