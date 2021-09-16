
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoConfecEnvase
    Inherits FrConsulta

    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
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

        Dim oTipoEtiqueta As New Cdatos.bdcampo("@CASE CEL_TipoEtiqueta WHEN 'C' THEN 'CESTA' WHEN 'J' THEN 'CAJA' ELSE '' END", Cdatos.TiposCampo.Cadena, 10)

        'Consulta Resumido
        consultaRes.SelCampo(ConfecEnvase.CEV_Idconfec, "confeccion")
        consultaRes.SelCampo(ConfecEnvase.CEV_Nombre, "nombreconfeccion")
        consultaRes.SelCampo(ConfecEnvase.CEV_Abreviatura, "abreviatura")
        consultaRes.SelCampo(ConfecEnvase.CEV_IncrementoTara, "incrementotara")
        consultaRes.SelCampo(ConfecEnvase.CEV_TotalCoste, "totalcoste")
        consultaRes.SelCampo(ConfecEnvase.CEV_TotalTara, "totaltara")
        consultaRes.SelCampo(ConfecEnvase.CEV_IdEnvase, "envase")
        consultaRes.SelCampo(Envases.ENV_Nombre, "nombreenvase", ConfecEnvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        'consultaRes.SelCampo(oTipoEtiqueta, "TipoEti")

        'Consulta Detallado
        consultaDet.SelCampo(ConfecEnvaseLineas.CEL_Idmaterial, "material")
        consultaDet.SelCampo(ConfecEnvase.CEV_Idconfec, "confeccion", ConfecEnvaseLineas.CEL_Idconfec)
        consultaDet.SelCampo(ConfecEnvase.CEV_Nombre, "nombreconfeccion")
        consultaDet.SelCampo(Envases.ENV_Nombre, "envase", ConfecEnvaseLineas.CEL_Idmaterial)
        consultaDet.SelCampo(ConfecEnvaseLineas.CEL_Cantidad, "cantidad")
        consultaDet.SelCampo(oTipoEtiqueta, "TipoEti")
        

        ' Detallado o resumido

        If RbDetallado.Checked Then
            sql = consultaDet.Sel(_IncluirTodosLosCampos)
            GridView1.Columns.Clear()
            Dim dt As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(sql)

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
            Dim dt As DataTable = ConfecEnvase.MiConexion.ConsultaSQL(sql)
            Grid.DataSource = dt
            
            AjustaColumnasRes()
        End If




    End Sub
    Private Sub AjustaColumnasDet()

        Grid.ForceInitialize()
        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "TIPOETI"
                    c.Visible = True
                    c.MinWidth = 70
                    c.MaxWidth = 70
                Case "MATERIAL"
                    c.Visible = True
                    c.Width = 5
                Case "CONFECCION"
                    c.Visible = True
                    c.Width = 5
                Case "NOMBRECONFECCION"
                    c.Visible = True
                    c.Width = 5
                Case "ENVASE"
                    c.Visible = True
                    c.Width = 100
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
        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "TIPOETI"
                    c.Visible = True
                    c.MinWidth = 70
                    c.MaxWidth = 70
                Case "CONFECCION"
                    c.Visible = True
                    c.Width = 10
                Case "ENVASE"
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
                Case "NOMBREENVASE"
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