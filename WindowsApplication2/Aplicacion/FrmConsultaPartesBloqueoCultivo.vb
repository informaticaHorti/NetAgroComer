
Public Class FrmConsultaPartesBloqueoCultivo
    Inherits FrConsulta



    Private Agricultores As New E_Agricultores(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub




    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeAgricultor, Agricultores.AGR_idagricultor, LbDesdeAgricultor)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_idagricultor, LbHastaAgricultor)
        ParamTx(TxDesdeFecha, Nothing, LbDesdeFecha, False, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxHastaFecha, Nothing, LbHastaFecha, False, Cdatos.TiposCampo.Fecha, True)

        AsociarControles(TxDesdeAgricultor, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomDesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaAg2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomHastaAgricultor)


    End Sub


    Private Sub FrmConsultaPrevisiones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        If TxDesdeFecha.Text.Trim = "" Then TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        If TxHastaFecha.Text.Trim = "" Then TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        If VaDate(TxDesdeFecha.Text) = VaDate("") Or VaDate(TxHastaFecha.Text) = VaDate("") Then
            MsgBox("Debe introducir fechas válidas")
            Exit Sub
        End If


        GridView1.Columns.Clear()


        Dim sql As String = "SELECT BCU_IdBloqueo as Parte, BCU_Fecha as Fecha, BCU_Hora as Hora, FIN_Nombre as Finca, AGR_Nombre as Agricultor, " & vbCrLf
        sql = sql & " BCU_DeFecha as DesdeFecha, BCU_DeHora as DesdeHora, BCU_AFecha as HastaFecha, BCU_AHora as HastaHora, BCU_Motivo as Motivo" & vbCrLf
        sql = sql & " FROM BloqueoCultivos" & vbCrLf
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Cultivos ON CUL_IdCultivo = BCU_IdCultivo" & vbCrLf
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Fincas ON FIN_IdFinca = CUL_IdFinca" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FIN_IdAgricultor" & vbCrLf
        sql = sql & " WHERE 1 = 1" & vbCrLf
        If TxDesdeAgricultor.Text.Trim <> "" Then sql = sql & " AND FIN_IdAgricultor >= " & TxDesdeAgricultor.Text & vbCrLf
        If TxHastaAgricultor.Text.Trim <> "" Then sql = sql & " AND FIN_IdAgricultor <= " & TxHastaAgricultor.Text & vbCrLf
        sql = sql & " AND " & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " (BCU_DeFecha >= '" & TxDesdeFecha.Text & "' AND BCU_DeFecha <= '" & TxHastaFecha.Text & "')" & vbCrLf
        sql = sql & " OR " & vbCrLf
        sql = sql & " (BCU_AFecha >= '" & TxDesdeFecha.Text & "' AND BCU_AFecha <= '" & TxHastaFecha.Text & "')" & vbCrLf
        sql = sql & " )" & vbCrLf
        sql = sql & " ORDER BY BCU_Fecha" & vbCrLf

        

        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim
        '        Case "IDAGRICULTOR"
        '            c.Caption = "CodAgr"
        '            c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '            c.DisplayFormat.FormatString = "00000"
        '            c.MaxWidth = 50
        '        Case "IDGENERO"
        '            c.Caption = "CodGen"
        '            c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '            c.DisplayFormat.FormatString = "00000"
        '            c.MaxWidth = 50
        '        Case "KILOS"
        '            c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '            c.DisplayFormat.FormatString = "#,##0.00"
        '            c.Width = 70
        '        Case "FECHA"
        '            c.Width = 75
        '    End Select
        'Next

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim agricultores As String = FiltroDesdeHasta("Agricultor", TxDesdeAgricultor.Text, TxHastaAgricultor.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)


        If agricultores <> "" Then LineasDescripcion.Add(agricultores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)

        MyBase.Imprimir()

    End Sub



End Class