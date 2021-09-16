Imports DevExpress.XtraEditors.Controls


Public Class FrmConsultaProduccion
    Inherits FrConsulta


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

        ParamTx(TxDato1, Produccion.PRD_Fecha, Lb1)
        ParamTx(TxDato2, Produccion.PRD_Fecha, Lb2)
        cbPventa = ComboPuntoventa(cbPventa, MiMaletin.IdPuntoVenta)

        CargaLineas()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub CargaLineas()

        Dim sql As String
        Dim lineas As New E_Lineas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim dT As New DataTable
        consulta.SelCampo(lineas.LIN_Idlinea, "Codigo")
        consulta.SelCampo(lineas.LIN_Nombre, "Nombre")
        sql = consulta.SQL
        sql = sql + CadenaWhereLista(lineas.LIN_Idcentro, ListadeCombo(cbPventa), " where ")

        dT = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)

        CbLineas.Properties.DataSource = dT
        CbLineas.Properties.ValueMember = "Codigo"
        CbLineas.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In CbLineas.Properties.GetItems()
            it.CheckState = CheckState.Checked
        Next

    End Sub


    Private Sub FrmConsultaPaletsResumida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = Now.ToShortDateString
        TxDato2.Text = Now.ToShortDateString
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim consulta As New Cdatos.E_select
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Lotes As New E_Lotes(Idusuario, cn)
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        Dim Lineas As New E_Lineas(Idusuario, cn)

        consulta.SelCampo(Produccion.PRD_Id, "Id")
        consulta.SelCampo(Produccion.PRD_IdLinea, "idlinea")
        consulta.SelCampo(Produccion.PRD_Fecha, "Fecha")
        consulta.SelCampo(Produccion.PRD_IdCentro, "Alm")
        consulta.SelCampo(Lineas.LIN_Nombre, "Linea", Produccion.PRD_IdLinea)
        consulta.SelCampo(Produccion.PRD_IdLineaEntrada, "idlineaentrada")
        consulta.SelCampo(Produccion.PRD_IdLote, "idlote")
        consulta.SelCampo(Produccion.PRD_IdLoteProduccion, "idloteproduccion")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", Produccion.PRD_IdLineaEntrada)
        consulta.SelCampo(Lotes.LTE_Lote, "Lote", Produccion.PRD_IdLote)
        consulta.SelCampo(Lotes.LTE_Idgenero, "idgenerolote")
        consulta.SelCampo(LotesProduccion.LPD_Lote, "PreCalib", Produccion.PRD_IdLoteProduccion)
        consulta.SelCampo(LotesProduccion.LPD_Idgenero, "idgeneroprecalibrado")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Producto", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Produccion.PRD_KilosConsumidos, "Kilos")
        consulta.SelCampo(Produccion.PRD_HoraInicio, "Inicio")
        consulta.SelCampo(Produccion.PRD_HoraFinal, "Final")

        consulta.WheCampo(Produccion.PRD_Fecha, ">=", TxDato1.Text)
        consulta.WheCampo(Produccion.PRD_Fecha, "<=", TxDato2.Text)
        consulta.WheCampo(Produccion.PRD_HoraFinal, "<>", "")



        Dim WHE As String = consulta.Whe & vbCrLf
        WHE = WHE & CadenaWhereLista(Produccion.PRD_IdCentro, ListadeCombo(cbPventa), " AND ")
        WHE = WHE & CadenaWhereLista(Produccion.PRD_IdLinea, ListadeCombo(CbLineas), " AND ")
        Dim SQL As String = consulta.Sel + WHE
        Dim dt As DataTable = Produccion.MiConexion.ConsultaSQL(SQL)

        dt.Columns.Add(New DataColumn("Tiempo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("KgxHora", GetType(Decimal)))


        For Each rw In dt.Rows

            Dim KilosConsumidos As Integer = VaInt(rw("Kilos"))
            Dim HoraInicio As String = (rw("Inicio").ToString & "").Trim
            Dim HoraFinal As String = (rw("Final").ToString & "").Trim

            Dim Inicio As DateTime
            Dim Final As DateTime


            If DateTime.TryParse(HoraInicio, Inicio) And DateTime.TryParse(HoraFinal, Final) Then
                Dim segundos As Decimal = DateDiff(DateInterval.Second, Inicio, Final)
                Dim horas As Decimal = segundos / 3600
                If horas <> 0 Then
                    rw("KgxHora") = KilosConsumidos / horas
                    rw("Tiempo") = horas
                End If
            End If

            If VaInt(rw("idlote")) > 0 Then
                If VaInt(rw("idgenerolote")) > 0 Then
                    If Generos.LeerId(rw("idgenerolote").ToString) = True Then
                        rw("producto") = Generos.GEN_NombreGenero.Valor
                    End If
                End If
            End If

            If VaInt(rw("idloteproduccion")) > 0 Then
                If VaInt(rw("idgeneroprecalibrado")) > 0 Then
                    If Generos.LeerId(rw("idgeneroprecalibrado").ToString) = True Then
                        rw("Producto") = Generos.GEN_NombreGenero.Valor
                    End If
                End If
            End If

        Next




        Grid.DataSource = dt

        AjustaColumnas()



    End Sub



    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "FECHA", "PARTIDA", "LOTE", "INICIO", "FINAL", "ID"
                    c.Width = 60

                Case "PRECALIB"
                    c.Caption = "L.Precalib"
                    c.Width = 60

                Case "ALM"
                    c.Width = 50

                Case "PRODUCTO", "LINEA"
                    c.Width = 100

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "TIEMPO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Caption = "Tiempo(H)"

                Case "KGXHORA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case Else
                    c.Visible = False

            End Select
        Next


        Funciones.AñadeResumenCampo(GridView1, "Tiempo", "{0:n4}")
        Funciones.AñadeResumenCampo(GridView1, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(GridView1, "KgxHora", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)


    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        'Manolo Escánez 04/05/2017: Quitar refresco automático
        'Dim indice As Integer = GridView1.FocusedRowHandle
        'Consultar()
        'GridView1.FocusedRowHandle = indice

    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

        'Manolo Escánez 04/05/2017: Quitar refresco automático
        'Timer1.Start()
        Consultar()

    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)


        'If DateTime.TryParse(HoraInicio, Inicio) And DateTime.TryParse(HoraFinal, Final) Then
        '    Dim segundos As Decimal = DateDiff(DateInterval.Second, Inicio, Final)
        '    Dim horas As Decimal = segundos / 3600
        '    If horas <> 0 Then
        '        rw("KgxHora") = KilosConsumidos / horas
        '    End If
        'End If




        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then

                Dim kh As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "KGXHORA" Then

                    Dim Horas As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                    Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                    If Horas <> 0 Then kh = Kilos / Horas

                End If
                e.TotalValue = kh

            End If


            If e.IsTotalSummary Then

                Dim kh As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "KGXHORA" Then

                    Dim kilos As Decimal = 0
                    Dim horas As Decimal = 0

                    Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Kilos")
                    If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                    Dim colHoras As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Tiempo")
                    If Not IsNothing(colHoras) Then horas = VaDec(colHoras.SummaryItem.SummaryValue)

                    If horas <> 0 Then kh = kilos / horas

                End If
                e.TotalValue = kh

            End If

        End If


    End Sub


    Private Sub cbCentro_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbPventa.EditValueChanged
        CargaLineas()
    End Sub
End Class