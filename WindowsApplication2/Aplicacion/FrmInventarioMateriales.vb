Imports DevExpress.XtraEditors.Controls

Public Class FrmInventarioMateriales
    Inherits FrConsulta




    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim EnvasesIniciales As New E_envasesInicial(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim Recuento As New E_Recuento(Idusuario, cn)


    Private err As New Errores()



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)
        CbFamilias.CheckAll()
        'ParamChk(ChkActuprecios, Nothing, "S", "N")


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        'Dim IdAlmacen As String = ""
        'If VaInt(CbAlmacenes.SelectedValue) Then IdAlmacen = VaInt(CbAlmacenes.SelectedValue).ToString

        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)
        Dim lstcodigos As New List(Of String)
        Dim dtfinal2 As DataTable = Agro_inventario(TxDato2.Text, "", "", lstcodigos, lstAlmacenes, lstFamilias, True)

      
        Dim dv As New DataView(dtfinal2)
        dv.Sort = "IdFamiliaEnvase, IdEnvase, IdMarca"
        dtfinal2 = dv.ToTable


        GridView1.Columns.Clear()
        Grid.DataSource = dtfinal2

        AjustaColumnas()


    End Sub




    Private Sub AjustaColumnas()

        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("IdMarca")) Then .ColumnByFieldName("IdMarca").Visible = False
            If Not IsNothing(.ColumnByFieldName("PMC_Recuento")) Then .ColumnByFieldName("PMC_Recuento").Visible = False
            If Not IsNothing(.ColumnByFieldName("Total")) Then .ColumnByFieldName("Total").Visible = False
            If Not IsNothing(.ColumnByFieldName("FamiliaEnvase")) Then
                .ColumnByFieldName("FamiliaEnvase").GroupIndex = 1
                .ColumnByFieldName("FamiliaEnvase").Visible = False
            End If

        End With


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDFAMILIAENVASE", "EXIINITOTAL", "VEXIINITOTAL", "UDSCOMTOTAL", "VCOMTOTAL"
                    'c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    'c.DisplayFormat.FormatString = "#"
                    'c.MaxWidth = 35
                    c.Visible = False

                Case "IDENVASE"
                    c.Caption = "Cod"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "MARCA"

                Case "IDMARCA"
                    c.Visible = False

                Case "STMARCA"
                    c.Width = 50



                Case "PMC", "PMC_RECUENTO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                    c.Width = 80

                Case Else
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

            End Select

        Next


        AñadeResumenCampo("ExiIni", "{0:n2}")
        AñadeResumenCampo("VExiIni", "{0:n2}")
        AñadeResumenCampo("UdsCom0", "{0:n2}")
        AñadeResumenCampo("UdsCom", "{0:n2}")
        AñadeResumenCampo("VCom", "{0:n2}")
        AñadeResumenCampo("MovEnv", "{0:n2}")
        AñadeResumenCampo("ExiPal", "{0:n2}")
        AñadeResumenCampo("Exist", "{0:n2}")
        AñadeResumenCampo("Recuento", "{0:n2}")
        AñadeResumenCampo("Difer", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "PMC", "{0:n6}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("ValExist", "{0:n2}")
        AñadeResumenCampo("ValRec", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "PMC_Recuento", "{0:n6}", DevExpress.Data.SummaryItemType.Custom)


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "PMC" Then

                        Dim PMC As Decimal = 0

                        Dim ExistIni As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim ValIni As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        Dim UdsCom As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                        Dim ValCom As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))

                        If (ExistIni + UdsCom) <> 0 Then PMC = (ValIni + ValCom) / (ExistIni + UdsCom)

                        e.TotalValue = PMC

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PMC" Then

                        Dim PMC As Decimal = 0
                        Dim ExistIni As Decimal = 0
                        Dim UdsCom As Decimal = 0
                        Dim ValIni As Decimal = 0
                        Dim ValCom As Decimal = 0


                        Dim colExistIni As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("ExiIni")
                        If Not IsNothing(colExistIni) Then ExistIni = VaDec(colExistIni.SummaryItem.SummaryValue)

                        Dim colValIni As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("VExiIni")
                        If Not IsNothing(colValIni) Then ValIni = VaDec(colValIni.SummaryItem.SummaryValue)

                        Dim colUdsCom As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("UdsCom")
                        If Not IsNothing(colUdsCom) Then UdsCom = VaDec(colUdsCom.SummaryItem.SummaryValue)

                        Dim colValCom As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("VCom")
                        If Not IsNothing(colValCom) Then ValCom = VaDec(colValCom.SummaryItem.SummaryValue)


                        If (ExistIni + UdsCom) <> 0 Then PMC = (ValIni + ValCom) / (ExistIni + UdsCom)

                        e.TotalValue = PMC

                    End If


                End If

            End If




        Catch ex As Exception

        End Try


    End Sub


    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva

        GridView1.OptionsView.ShowGroupPanel = False


        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)


        Dim dt As New DataTable
        Dim sql As String = "SELECT FEV_IdFamilia as Familia, FEV_Nombre as Nombre FROM FamiliaEnvases ORDER BY Familia"
        dt = cn.ConsultaSQL(sql)

        CbFamilias.Properties.DataSource = dt
        CbFamilias.Properties.ValueMember = "Familia"
        CbFamilias.Properties.DisplayMember = "Nombre"

        CbFamilias.CheckAll()
        'BtAux.Text = "Inf. Inventariables"
        'BtAux.Width = 115
        'BtAux.Image = NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        'BtAux.Visible = True


        ComprobarBotones()


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        LineasDescripcion.Add("  Hasta fecha : " & TxDato2.Text)

        Dim almacenes As String = FiltroCheckedComboBox("Almacen", cbAlmacenes)
        Dim familias As String = FiltroCheckedComboBox("Familia", CbFamilias)

        If familias <> "" Then LineasDescripcion.Add(familias)
        If almacenes <> "" Then LineasDescripcion.Add(almacenes)

        
        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstAlmacenes As New List(Of String)
                For Each it As CheckedListBoxItem In cbAlmacenes.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstAlmacenes.Add(it.Value.ToString)
                    End If
                Next

                Dim lstFamilias As New List(Of String)
                For Each it As CheckedListBoxItem In CbFamilias.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstFamilias.Add(it.Value.ToString)
                    End If
                Next

                Dim listado As New Listado_InventarioMateriales(dt, MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy"), TxDato2.Text, True, lstAlmacenes, lstFamilias, TipoImpresion.Preliminar)
                listado.ImprimirListado()

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

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs)

        Dim sql As String = "SELECT IdAlbaran, IdVale, Albaran, CE, ImporteAlb, ROUND(ImporteVale,2) AS ImporteVale" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT AMA_IdAlb as IdAlbaran, AMA_Serie as Serie, AMA_Numero as Albaran, AMA_IdCentro as CE, AMA_IdValeEnvase as IdVale, " & vbCrLf
        sql = sql & " AMA_Importe as ImporteAlb," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) as ImporteVale FROM ValeEnvases_Lineas WHERE VEL_IdVale = AMA_IdValeEnvase) as ImporteVale" & vbCrLf
        sql = sql & " FROM AlbMaterial" & vbCrLf
        sql = sql & " LEFT JOIN AlbMaterialLineas ON AMA_IdAlb = AML_IdAlb" & vbCrLf
        sql = sql & " GROUP BY AMA_IdAlb, AMA_IdCentro, AMA_Serie, AMA_Numero, AMA_IdValeEnvase, AMA_Importe" & vbCrLf
        sql = sql & " ) AS K" & vbCrLf
        sql = sql & " WHERE ABS(COALESCE(ImporteAlb, 0) - ROUND(COALESCE(ImporteVale, 0), 2)) > 0.02" & vbCrLf
        sql = sql & " ORDER BY Albaran" & vbCrLf

        Dim dt As DataTable = ValeEnvases_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            Dim lstParametros As New List(Of Parametros)
            lstParametros.Add(New Parametros("IdAlbaran", False, "", -1))
            lstParametros.Add(New Parametros("IdVale", False, "", -1))
            lstParametros.Add(New Parametros("Serie", False, "", 70))
            lstParametros.Add(New Parametros("Albaran", False, "", 70))
            lstParametros.Add(New Parametros("CE", False, "", 25))
            lstParametros.Add(New Parametros("ImporteAlb", False, "#,##0.00", 80))
            lstParametros.Add(New Parametros("ImporteVale", False, "#,##0.00", 80))

            Dim frm As New FrConsultaGenerica(dt, lstParametros, "Comprobar precios de compra")
            frm.ShowDialog()
        Else
            MsgBox("No hay datos")
        End If


    End Sub

   


    Private Sub chkMarcas_CheckedChanged(sender As System.Object, e As System.EventArgs)
        ComprobarBotones()
    End Sub

    Private Sub CbFamilias_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CbFamilias.EditValueChanged
        ComprobarBotones()
    End Sub

    Private Sub cbAlmacenes_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbAlmacenes.EditValueChanged
        ComprobarBotones()
    End Sub


    Private Sub ComprobarBotones()

        Dim bActivar As Boolean = False

        Dim CentrosSeleccionados As Integer = 0
        Dim FamiliasSeleccionados As Integer = 0
        Dim FamiliasTotales As Integer = 0
        If Not IsNothing(CbFamilias.Properties.GetItems()) Then FamiliasTotales = CbFamilias.Properties.GetItems().Count


        Dim familias As List(Of String) = ValoresDeCombo(CbFamilias)
        FamiliasSeleccionados = familias.Count

        Dim centros As List(Of String) = ValoresDeCombo(cbAlmacenes)
        CentrosSeleccionados = centros.Count

        If (FamiliasSeleccionados = 0 Or FamiliasSeleccionados = FamiliasTotales) And
            (CentrosSeleccionados = 1 Or CentrosSeleccionados = centros.Count) Then
            bActivar = True
        End If



    End Sub


  


  

    Private Sub btAjusteInventario_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class

