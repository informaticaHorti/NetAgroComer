
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmListadoGastosPr


    Inherits FrConsulta

    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
    Dim Centrosrecogida As New E_centrosrecogida(Idusuario, cn)
    Dim TiposdeGastsAgri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)

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

        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(AgricultorGastos.AGG_IdAgricultor, "Codigo")
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", AgricultorGastos.AGG_IdAgricultor)
        Consulta.SelCampo(Centrosrecogida.CER_Nombre, "CentroRec", AgricultorGastos.AGG_idcentrorec)
        Consulta.SelCampo(TiposdeGastsAgri.TGA_Nombre, "Gasto", AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(AgricultorGastos.AGG_TipoFC, "FC")
        Consulta.SelCampo(AgricultorGastos.AGG_Valor, "Valor")
        Consulta.SelCampo(Acreedores.ACR_Nombre, "Acreedor", AgricultorGastos.AGG_IdAcreedor)
        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "<=", TxAAgricultor.Text)
        End If

        Dim SQL As String = Consulta.SQL
        SQL = SQL + " ORDER BY AGG_IDAGRICULTOR"

        GridView1.Columns.Clear()
        Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(SQL)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CENTROREC"
                    c.Visible = True
                    c.Width = 100
                    c.MinWidth = 100
                    c.MaxWidth = 100

                Case "VALOR"
                    c.Visible = True
                    c.Width = 100
                    c.MinWidth = 100
                    c.MaxWidth = 100

                Case "GASTO", "ACREEDOR"
                    c.Visible = True
                    c.Width = 200
                    c.MinWidth = 200
                    c.MaxWidth = 200
                Case "FC"
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
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub
End Class