
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoMedianerias

    Inherits FrConsulta

    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Medianeria As New E_Medianeria(Idusuario, cn)
    Dim medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)


        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)


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



        'Dim consulta As New Cdatos.E_select
        'consulta.SelCampo(medianeria_lineas.MEL_Id, "id")
        'consulta.SelCampo(Medianeria.MED_IdAgricultor, "Codigo", medianeria_lineas.MEL_Idmedianeria)
        'consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Medianeria.MED_IdAgricultor)
        'consulta.SelCampo(Medianeria.MED_Numero, "Numero")
        'consulta.SelCampo(Medianeria.MED_Nombre, "Nombre")
        'consulta.SelCampo(medianeria_lineas.MEL_Idagricultor, "Cmed")
        ''  consulta.SelCampo(Agricultor.AGR_Nombre, "Medianero", medianeria_lineas.MEL_Idagricultor)
        'consulta.SelCampo(medianeria_lineas.MEL_porcentaje, "Porc")
        'If TxDAgricultor.Text <> "" Then
        '    consulta.WheCampo(Medianeria.MED_IdAgricultor, ">=", TxDAgricultor.Text)
        'End If
        'If TxAAgricultor.Text <> "" Then
        '    consulta.WheCampo(Medianeria.MED_IdAgricultor, "<=", TxAAgricultor.Text)
        'End If

        'Dim sql As String = consulta.SQL
        Dim SQL As String = ""
        sql = "Select NetAgroComer.dbo.Medianeria_lineas.MEL_Id AS id, "
        sql = sql + " NetAgroComer.dbo.Medianeria.MED_idagricultor AS Codigo, "
        sql = sql + " agr1.AGR_Nombre AS Agricultor, "
        sql = sql + " NetAgroComer.dbo.Medianeria.MED_numero AS Numero, "
        sql = sql + " NetAgroComer.dbo.Medianeria.MED_nombre AS Nombre, "
        sql = sql + " NetAgroComer.dbo.Medianeria_lineas.MEL_idagricultor AS Cmed, "
        sql = sql + " agr2.AGR_Nombre AS Medianero, "
        sql = sql + " NetAgroComer.dbo.Medianeria_lineas.MEL_porcentaje AS Porc from NetAgroComer.dbo.Medianeria_lineas"
        sql = sql + " LEFT OUTER JOIN NetAgroComer.dbo.Medianeria ON NetAgroComer.dbo.Medianeria_lineas.MEL_idmedianeria = NetAgroComer.dbo.Medianeria.MED_idmedianeria"
        sql = sql + " LEFT OUTER JOIN NetAgroComer.dbo.Agricultores as agr1 ON NetAgroComer.dbo.Medianeria.MED_idagricultor = agr1.AGR_Idagricultor"
        sql = sql + " LEFT OUTER JOIN NetAgroComer.dbo.Agricultores as agr2 ON NetAgroComer.dbo.Medianeria_lineas.MEL_idagricultor = agr2.AGR_Idagricultor"

        SQL = SQL + " WHERE MED_IDAGRICULTOR<>0 "
        If TxDAgricultor.Text <> "" Then
            sql = sql + " AND MED_idagricultor>=" + TxDAgricultor.Text
        End If

        If TxDAgricultor.Text <> "" Then
            sql = sql + " AND MED_idagricultor<=" + TxAAgricultor.Text
        End If

        SQL = SQL + " order by MED_IDAGRICULTOR"



        GridView1.Columns.Clear()
        Dim dt As DataTable = Medianeria.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CMED"
                    c.Visible = True
                    c.Width = 50
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "MEDIANERO"
                    c.Visible = True
                    c.Width = 300
                    c.MinWidth = 300
                    c.MaxWidth = 300
                Case "PORC"
                    c.Visible = True
                    c.Width = 50
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "CODIGO"
                    c.GroupIndex = 0
                    c.Visible = False
                Case "AGRICULTOR"
                    c.GroupIndex = 1
                    c.Visible = False
                Case "NUMERO"
                    c.GroupIndex = 2
                    c.Visible = False
                Case "NOMBRE"
                    c.GroupIndex = 3
                    c.Visible = False

                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub
End Class