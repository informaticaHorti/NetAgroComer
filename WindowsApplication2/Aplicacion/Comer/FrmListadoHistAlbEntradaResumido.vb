
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmListadoHistAlbEntradaResumido
    Inherits FrConsulta

    Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Centro As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim Centrosrecogida As New E_centrosrecogida(Idusuario, cn)


    Dim err As New Errores

    Private Class DatosAlbaran

        Public Albaran As String = ""
        Public Fecha As String = ""
        Public PuntoVenta As String = ""
        Public Factura As String = ""
        Public Cliente As String = ""

        Public Sub New(Albaran As String, fecha As String, PuntoVenta As String, Factura As String, Cliente As String)
            Me.Albaran = Albaran
            Me.Fecha = fecha
            Me.PuntoVenta = PuntoVenta
            Me.Factura = Factura
            Me.Cliente = Cliente
        End Sub

    End Class



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Agricultores.AGR_IdAgricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_IdAgricultor, Lb2)
        ParamTx(TxDato3, Albentrada.AEN_Fecha, Lb3)
        ParamTx(TxDato4, Albentrada.AEN_Fecha, Lb4)
        ParamTx(TxDato5, Albentrada_hislineas.AHL_idgenero, Lb5)
        ParamTx(TxDato6, Albentrada_hislineas.AHL_idgenero, Lb6)

        AsociarControles(TxDato1, BtBusca1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_2)
        AsociarControles(TxDato5, BtBusca5, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb_5)
        AsociarControles(TxDato6, BtBusca6, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb_6)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_hislineas.AHL_idalbaran, "IdAlbaran")
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha", Albentrada_hislineas.AHL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran")
        consulta.SelCampo(AlbEntrada_his.AEH_idproveedor, "CodAgr", Albentrada_hislineas.AHL_idalbhis)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada_his.AEH_idproveedor)
        consulta.SelCampo(Albentrada_hislineas.AHL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_hislineas.AHL_kilos, "Kilos")
        Dim Importe As New Cdatos.bdcampo("@AHL_KILOS*AHL_PRECIO", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(Importe, "Importe")
        consulta.SelCampo(Albentrada.AEN_EntradaConfeccionada, "EntradaConfeccionada", AlbEntrada_his.AEH_idalbaran)
        consulta.SelCampo(Albentrada_lineas.AEL_fechamuestreo, "FechaMuestreo", Albentrada.AEN_IdAlbaran)

        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato4.Text)
        If TxDato5.Text.Trim <> "" Then consulta.WheCampo(Albentrada_hislineas.AHL_idgenero, ">=", TxDato5.Text)
        If TxDato6.Text.Trim <> "" Then consulta.WheCampo(Albentrada_hislineas.AHL_idgenero, "<=", TxDato6.Text)
        If RbValorSi.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_precio, "<>", "0")
        If RbValorno.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_precio, "=", "0")
        If RbMuestreoSi.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_fechamuestreo, "<>", "01/01/1900")
        If RbMuestreoNo.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_fechamuestreo, "=", "01/01/1900")
        If RbConfecSi.Checked = True Then consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "=", "S")
        If RbConfecNo.Checked = True Then consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "<>", "S")

        Dim WHE As String = consulta.Whe

        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ")
        End If

        If RbFacturadosSi.Checked = True Then
            WHE = WHE + " AND (ALBENTRADA_HIS.AEH_IDFACTURA > 0 ) "
        End If
        If RbFacturadosNo.Checked = True Then
            WHE = WHE + " AND (ALBENTRADA_HIS.AEH_IDFACTURA = 0 ) "
        End If

        consulta.WheCampo(AlbEntrada_his.AEH_idfactura, ">", "0")
        If RbFacturadosNo.Checked = True Then consulta.WheCampo(AlbEntrada_his.AEH_idfactura, "=", "0")

        Dim sql As String = consulta.Sel & WHE


        sql = "SELECT IdAlbaran, Albaran, Fecha, RIGHT('00000' + CAST (CodAgr as varchar), 5) + ' ' + Agricultor as NombreAgricultor," & vbCrLf & _
            " CodAgr, Agricultor, SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, SUM(Importe) as Importe" & vbCrLf & _
            " FROM (" & vbCrLf & sql & vbCrLf & ") AS G" & vbCrLf & _
            " GROUP BY CodAgr, Agricultor, IdAlbaran, Albaran, Fecha" & vbCrLf
        sql = sql & " ORDER BY CodAgr, IdAlbaran, Fecha"


        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbEntrada_his.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("NombreAgricultor")) Then
            GridView1.Columns.ColumnByFieldName("NombreAgricultor").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "Precio", "{0:n5}", DevExpress.Data.SummaryItemType.Custom)

        AjustaColumnas()



    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "FECHA", "CENTRORECOGIDA", "GENERO", "ENVASE", "BULTOS", "KILOS", "PRECIO", "CATEGORIA", "IMPORTE", "MUESTREO"
                    c.Visible = True
                Case "NOMBREAGRICULTOR"
                    c.Caption = "Agricultor"
                    c.Visible = False
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS", "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "PRECIO", "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100
                Case "CENTRORECOGIDA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA"
                    c.MinWidth = 85
                    c.MaxWidth = 85
                Case "CODAGR"
                    c.Width = 55
            End Select
        Next
    End Sub
    Public Overrides Sub Informe()
        MyBase.Informe()
        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim Confeccionadas As String = ""
                Dim FirmeComision As String = ""
                Dim Facturados As String = ""
                Dim Valorados As String = ""
                Dim LineasMuestreadas As String = ""


                If RbConfecSi.Checked Then
                    Confeccionadas = "SI"
                ElseIf RbConfecNo.Checked Then
                    Confeccionadas = "NO"
                ElseIf RbConfecTodas.Checked Then
                    Confeccionadas = "Todos"
                End If

                If RbFacturadosSi.Checked Then
                    Facturados = "SI"
                ElseIf RbFacturadosNo.Checked Then
                    Facturados = "NO"
                ElseIf RbFacturadosTodos.Checked Then
                    Facturados = "Todos"
                End If

                If RbValorSi.Checked Then
                    Valorados = "SI"
                ElseIf RbValorno.Checked Then
                    Valorados = "NO"
                ElseIf RbValorTodos.Checked Then
                    Valorados = "Todos"
                End If

                If RbMuestreoSi.Checked Then
                    LineasMuestreadas = "SI"
                ElseIf RbMuestreoNo.Checked Then
                    LineasMuestreadas = "NO"
                ElseIf RbMuestreoTodos.Checked Then
                    LineasMuestreadas = "Todos"
                End If


                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)

                ImprimirListadoHistAlbaranesEntradaResumido(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, TxDato5.Text, TxDato6.Text,
                                                    Confeccionadas, FirmeComision, Facturados, Valorados, LineasMuestreadas,
                                                    lstPuntoVenta)

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If
        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If
    End Sub


    Public Overrides Sub Imprimir()

        Dim agricultores As String = FiltroDesdeHasta("Proveedor", TxDato1.Text, TxDato3.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim generos As String = FiltroDesdeHasta("Genero", TxDato5.Text, TxDato6.Text)
        Dim puntoventa As String = FiltroCheckedComboBox("Punto de Venta", cbPuntoVenta)

        Dim RbConfeccionadas As RadioButton() = {RbConfecSi, RbConfecNo, RbConfecTodas}
        Dim StrConfeccionadas As String() = {"SI", "NO", "Todas"}
        Dim confeccionadas As String = FiltroRadioButton("Entradas confeccionadas", RbConfeccionadas, StrConfeccionadas)

        Dim RbFacturados As RadioButton() = {RbFacturadosSi, RbFacturadosNo, RbFacturadosTodos}
        Dim StrFacturados As String() = {"SI", "NO", "Todos"}
        Dim facturados As String = FiltroRadioButton("Albaranes facturados", RbFacturados, StrFacturados)

        Dim RbValorados As RadioButton() = {RbValorSi, RbValorno, RbValorTodos}
        Dim StrValorados As String() = {"SI", "NO", "Todos"}
        Dim valorados As String = FiltroRadioButton("Albaranes valorados", RbValorados, StrValorados)

        Dim RbMuestreados As RadioButton() = {RbMuestreoSi, RbMuestreoNo, RbMuestreoTodos}
        Dim StrMuestreados As String() = {"SI", "NO", "Todos"}
        Dim muestreados As String = FiltroRadioButton("Albaranes muestreados", RbMuestreados, StrMuestreados)


        LineasDescripcion.Clear()

        If agricultores <> "" Then LineasDescripcion.Add(agricultores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If generos <> "" Then LineasDescripcion.Add(generos)
        If puntoventa <> "" Then LineasDescripcion.Add(puntoventa)
        If confeccionadas <> "" Then LineasDescripcion.Add(confeccionadas)
        If facturados <> "" Then LineasDescripcion.Add(facturados)
        If valorados <> "" Then LineasDescripcion.Add(valorados)
        If muestreados <> "" Then LineasDescripcion.Add(muestreados)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)


        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then

                Dim pm As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "PRECIO" Then

                    Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                    Dim Importe As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                    If Kilos <> 0 Then pm = Importe / Kilos

                End If
                e.TotalValue = pm

            End If


            If e.IsTotalSummary Then

                Dim pm As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "PRECIO" Then

                    Dim kilos As Decimal = 0
                    Dim Importe As Decimal = 0

                    Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Kilos")
                    If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                    Dim colImporte As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Importe")
                    If Not IsNothing(colImporte) Then Importe = VaDec(colImporte.SummaryItem.SummaryValue)

                    If kilos <> 0 Then pm = Importe / kilos

                End If
                e.TotalValue = pm

            End If

        End If


    End Sub


End Class