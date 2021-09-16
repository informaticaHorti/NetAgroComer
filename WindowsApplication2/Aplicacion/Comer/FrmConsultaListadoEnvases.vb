
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoEnvases
    Inherits FrConsulta

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim FamiliaEnvases As New E_FamiliaEnvases(Idusuario, cn)
    Dim TiposIva As New E_tiposiva(Idusuario, cn)

    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        ParamTx(TxDEnvase, Envases.ENV_IdEnvase, LbDEnvase)
        ParamTx(TxAEnvase, Envases.ENV_IdEnvase, LbAEnvase)


        AsociarControles(TxDEnvase, BtBuscaDEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, LbNomDEnvase)
        AsociarControles(TxAEnvase, BtBuscaAEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, LbNomAEnvase)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


        CargaFamilias()

    End Sub


    Private Sub CargaFamilias()

        Dim dt As New DataTable
        Dim sql As String = "SELECT FEV_IdFamilia as Familia, FEV_Nombre as Nombre FROM FamiliaEnvases ORDER BY Familia"
        dt = cn.ConsultaSQL(sql)

        CbFamilias.Properties.DataSource = dt
        CbFamilias.Properties.ValueMember = "Familia"
        CbFamilias.Properties.DisplayMember = "Nombre"
        CbFamilias.CheckAll()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Envases.ENV_IdEnvase, "codigo")
        consulta.SelCampo(Envases.ENV_Nombre, "envase")
        consulta.SelCampo(Envases.ENV_Abreviatura, "abreviatura")
        consulta.SelCampo(Envases.ENV_Tipo, "tipoenvase")
        consulta.SelCampo(Envases.ENV_PrecioVenta, "precioventa")
        consulta.SelCampo(Envases.ENV_CosteSalida, "costesalida")
        consulta.SelCampo(Envases.ENV_PrecioAbono, "precioabono")
        consulta.SelCampo(Envases.ENV_StockMinimo, "stockminimo")
        consulta.SelCampo(Envases.ENV_TaraEntrada, "taraentrada")
        consulta.SelCampo(Envases.ENV_TaraSalida, "tarasalida")
        consulta.SelCampo(Envases.ENV_Retornable, "retornable")
        consulta.SelCampo(Envases.ENV_StockMarca, "stockmarca")
        consulta.SelCampo(FamiliaEnvases.FEV_IdFamilia, "idfamilia")
        consulta.SelCampo(FamiliaEnvases.FEV_Nombre, "familia", Envases.ENV_IdfamiliaEnvase, FamiliaEnvases.FEV_IdFamilia)
        consulta.SelCampo(TiposIva.TIV_Id, "idiva")
        consulta.SelCampo(TiposIva.TIV_iva, "iva", Envases.ENV_IdTipoiva, TiposIva.TIV_Id)


        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & vbCrLf
        sql = sql & " WHERE 1 = 1" & vbCrLf
        If TxDEnvase.Text.Trim <> "" Then sql = sql & " AND ENV_IdEnvase >= " & TxDEnvase.Text & vbCrLf
        If TxAEnvase.Text.Trim <> "" Then sql = sql & " AND ENV_IdEnvase <= " & TxAEnvase.Text & vbCrLf
        sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, ListadeCombo(CbFamilias), " AND ")

        GridView1.Columns.Clear()

        Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO", "ENVASE", "ABREVIATURA", "TIPOENVASE", "PRECIOVENTA", "COSTESALIDA", "PRECIOABONO", "STOCKMINIMO",
                    "TARAENTRADA", "TARASALIDA", "RETORNABLE", "STOCKMARCA", "FAMILIA", "IVA"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim envases As String = FiltroDesdeHasta("Envase", TxDEnvase.Text, TxAEnvase.Text)
        Dim familias As String = FiltroCheckedComboBox("Familias", CbFamilias)

        If envases.Trim <> "" Then LineasDescripcion.Add(envases)
        If familias.Trim <> "" Then LineasDescripcion.Add(familias)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then

            Dim columna As String = column.FieldName.ToUpper

            Select Case columna

                Case "CODIGO", "ENVASE"

                    Dim IdEnvase As String = (row("Codigo").ToString & "").Trim
                    If VaDec(IdEnvase) > 0 Then

                        Dim frm As New FrmEnvases
                        frm.init(IdEnvase)
                        frm.ShowDialog()

                    End If

                    

            End Select


        End If

    End Sub

End Class