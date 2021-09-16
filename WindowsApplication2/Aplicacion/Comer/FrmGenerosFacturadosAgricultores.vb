
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic



Public Class FrmGenerosFacturadosAgricultores
    Inherits FrConsulta



    Private FacturaAgr_Lineas As New E_FacturaAgr_lineas(Idusuario, cn)
    Private FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private SubFamilias As New E_Subfamilias(Idusuario, cn)
    Private Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Private SemanasPartes As New E_SemanasPartes(Idusuario, cn)





    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxSemana, SemanasPartes.SEV_Semana, LbSemana)
        ParamTx(TxDeFecha, FacturaAgr.FGR_fecha, LbDeFecha, True)
        ParamTx(TxAFecha, FacturaAgr.FGR_fecha, LbAFecha, True)
        ParamTx(TxAgricultorDesde, FacturaAgr.FGR_Idagricultor, LbDeAgricultor)
        ParamTx(TxAgricultorHasta, FacturaAgr.FGR_Idagricultor, LbAAgricultor)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(FacturaAgr_Lineas.FAL_id, "IdLinea")
        CONSULTA.SelCampo(FacturaAgr.FGR_fecha, "Fecha", FacturaAgr_Lineas.FAL_idfactura)
        CONSULTA.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFamilia", FacturaAgr_Lineas.FAL_idgenero)
        CONSULTA.SelCampo(SubFamilias.SFA_nombre, "SubFamilia", Generos.GEN_IdsubFamilia)
        CONSULTA.SelCampo(FacturaAgr_Lineas.FAL_idgenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero")
        CONSULTA.SelCampo(FacturaAgr_Lineas.FAL_idcategoria, "IdCategoria")
        CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", FacturaAgr_Lineas.FAL_idcategoria)
        CONSULTA.SelCampo(FacturaAgr_Lineas.FAL_kilos, "Kilos")
        CONSULTA.SelCampo(FacturaAgr_Lineas.FAL_importe, "Importe")
        If TxDeFecha.Text.Trim <> "" Then CONSULTA.WheCampo(FacturaAgr.FGR_fecha, ">=", TxDeFecha.Text)
        If TxAFecha.Text.Trim <> "" Then CONSULTA.WheCampo(FacturaAgr.FGR_fecha, "<=", TxAFecha.Text)
        If TxAgricultorDesde.Text.Trim <> "" Then CONSULTA.WheCampo(FacturaAgr.FGR_Idagricultor, ">=", TxAgricultorDesde.Text)
        If TxAgricultorHasta.Text.Trim <> "" Then CONSULTA.WheCampo(FacturaAgr.FGR_Idagricultor, "<=", TxAgricultorHasta.Text)


        Dim sql As String = CONSULTA.SQL & vbCrLf

        'Empresa
        If CONSULTA.Whe.Trim <> "" Then
            sql = sql & CadenaWhereLista(FacturaAgr.FGR_idempresa, ListadeCombo(CbEmpresas), " AND ") & vbCrLf
        Else
            sql = sql & CadenaWhereLista(FacturaAgr.FGR_idempresa, ListadeCombo(CbEmpresas), " WHERE ") & vbCrLf
        End If

        If CONSULTA.Whe.Trim <> "" Then
            sql = sql & CadenaWhereLista(FacturaAgr.FGR_idcentro, ListadeCombo(cbCentro), " AND ") & vbCrLf
        Else
            sql = sql & CadenaWhereLista(FacturaAgr.FGR_idcentro, ListadeCombo(cbCentro), " WHERE ") & vbCrLf
        End If

        sql = "SELECT IdSubFamilia, SubFamilia, IdGenero, Genero, IdCategoria, Categoria, SUM(Kilos) as Kilos, 0.00 as PMC, SUM(Importe) as Importe" & vbCrLf & _
            " FROM ( " & vbCrLf & sql & " ) as G" & vbCrLf & _
            " GROUP BY IdSubFamilia, SubFamilia, IdGenero, Genero, IdCategoria, Categoria" & vbCrLf & _
            " ORDER BY IdSubFamilia, IdGenero, IdCategoria"



        Dim dt As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)


        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim PMC As Decimal = 0
                Dim Importe As Decimal = VaDec(row("Importe"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))

                If Kilos <> 0 Then PMC = Importe / Kilos
                row("PMC") = PMC

            Next
        End If


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()


    End Sub



    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDSUBFAMILIA", "IDCATEGORIA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "SUBFAMILIA"
                    c.GroupIndex = 1
                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Width = 50
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 90
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 90
                Case "PMC"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Width = 90
            End Select
        Next


        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")


    End Sub

    Private Sub TxSemana_Valida(edicion As System.Boolean) Handles TxSemana.Valida

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        Dim IdSemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text))

        If IdSemana > 0 Then
            TxDeFecha.Text = VaDate(SemanasPartes.SEV_FechaInicialSalida.Valor).ToString("dd/MM/yyyy")
            TxAFecha.Text = VaDate(SemanasPartes.SEV_FechaFinalSalida.Valor).ToString("dd/MM/yyyy")
        End If



    End Sub
End Class