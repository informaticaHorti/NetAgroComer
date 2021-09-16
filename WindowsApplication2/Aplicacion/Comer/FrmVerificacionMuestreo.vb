
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmVerificacionMuestreo
    Inherits FrConsulta


    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Produccion As New E_Produccion(Idusuario, cn)

    
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

        ParamTx(TxSemana, SemanasPartes.SEV_Semana, LbSemana)
        ParamTx(TxDesdeFecha, AlbEntrada.AEN_Fecha, LbDesdeFecha, True)
        ParamTx(TxHastaFecha, AlbEntrada.AEN_Fecha, LbHastaFecha, True)


    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub




    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = " SELECT AEL_Muestreo as Partida,AEN_Albaran as albaran,AEN_Fecha as fecha,AEN_idpuntoventa as AlM, AEL_KilosNetos as KgEnt, " & vbCrLf
        sql = sql & " (SELECT SUM(ALC_KilosNetos) FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = AEL_IdLinea) as KgMuestreo" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql = sql & " where COALESCE(AEL_FechaMuestreo,'" & VaDate("") & "') > '" & VaDate("") & "'" & vbCrLf ' muestreados
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " and AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then
            sql = sql & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        End If
        sql = "SELECT Partida,Albaran,Fecha,ALM, KgEnt, KgMuestreo, KgMuestreo - KgEnt as Diferencia" & vbCrLf & " FROM (" & vbCrLf & sql & vbCrLf & ") as T" & vbCrLf & " WHERE COALESCE(KgMuestreo,0) - COALESCE(KgEnt,0) <> 0" & vbCrLf & " ORDER BY Partida"

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        

        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("KgEnt", "{0:n0}")
        AñadeResumenCampo("KgMuestreo", "{0:n0}")
        AñadeResumenCampo("Diferencia", "{0:n0}")


        AjustaColumnas()


        If Not IsNothing(dt) Then
            If dt.Rows.Count = 0 Then
                MsgBox("No se detecta ninguna diferencia")
            Else
                MsgBox("Se dectectaron " & dt.Rows.Count.ToString & " diferencia(s)", MsgBoxStyle.Exclamation)
            End If
        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PARTIDA", "KGENT", "KGMUESTREO", "DIFERENCIA", "LINEA", "ALBARAN", "FECHA", "ALM"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "PARTIDA"
                    c.MinWidth = 100
                    c.MaxWidth = 100

                Case "KGENT", "KGMUESTREO", "DIFERENCIA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100

                Case "LINEA"
                    c.MinWidth = 55

            End Select

        Next


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        If TxDesdeFecha.Text.Trim <> "" Or TxHastaFecha.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDesdeFecha.Text & " hasta " & TxHastaFecha.Text)


        MyBase.Imprimir()

    End Sub



    Private Sub TxSemana_Valida(edicion As System.Boolean) Handles TxSemana.Valida

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        If SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text)) > 0 Then
            If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then TxDesdeFecha.Text = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
            If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then TxHastaFecha.Text = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")
        End If

    End Sub



End Class