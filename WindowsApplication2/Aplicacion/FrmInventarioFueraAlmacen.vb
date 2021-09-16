Imports DevExpress.XtraEditors.Controls

Public Class FrmInventarioFueraAlmacen
    Inherits FrConsulta



    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    'Dim Agricultores As New E_Agricultores(Idusuario, cn)



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

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato3, Envases.ENV_IdEnvase, Lb3)
        ParamTx(TxDato4, Envases.ENV_IdEnvase, Lb4)


        AsociarControles(TxDato3, BtBusca3, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_3)
        AsociarControles(TxDato4, BtBusca4, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_4)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim sql As String = ""

        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)

        If RbDetallado.Checked Then

            sql = "SELECT IdEnvase, NombreEnvase as Envase, Codigo as IdAgricultor, Nombre as Agricultor, Ret," & vbCrLf
            sql = sql & " SUM(Inicial) as Inicial, '' as InicialStr, SUM(InicialValorado) as InicialValorado, " & vbCrLf
            sql = sql & " SUM(Retira) as Retira, SUM(Entrega) as Entrega, SUM(Saldo) as Saldo, SUM(RetiraValorado) as RetiraValorado," & vbCrLf
            sql = sql & " SUM(EntregaValorado) as EntregaValorado, SUM(SaldoValorado) as SaldoValorado, '' as SaldoStr" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & ValeEnvases.SaldoEnvases("A", False, TxDato1.Text, TxDato2.Text, "", "", TxDato3.Text, TxDato4.Text, lstAlmacenes) & vbCrLf
            sql = sql & " ) AS G" & vbCrLf
            sql = sql & " WHERE COALESCE(IdEnvase,0) <> 0" & vbCrLf
            If RbSiRetornables.Checked Then
                sql = sql & " AND Ret = 'S'" & vbCrLf
            ElseIf RbNoRetornables.Checked Then
                sql = sql & " AND Ret = 'N'" & vbCrLf
            End If
            sql = sql & " GROUP BY IdEnvase, NombreEnvase, Ret, Codigo, Nombre" & vbCrLf
            sql = sql & vbCrLf & "ORDER BY IdEnvase, Codigo "

        Else

            sql = "SELECT IdEnvase, NombreEnvase as Envase, Ret," & vbCrLf
            sql = sql & " SUM(Inicial) as Inicial, SUM(InicialValorado) as InicialValorado, '' as InicialStr, " & vbCrLf
            sql = sql & " SUM(Retira) as Retira, SUM(Entrega) as Entrega, SUM(Saldo) as Saldo, SUM(RetiraValorado) as RetiraValorado," & vbCrLf
            sql = sql & " SUM(EntregaValorado) as EntregaValorado, SUM(SaldoValorado) as SaldoValorado, '' as SaldoStr" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & ValeEnvases.SaldoEnvases("A", False, TxDato1.Text, TxDato2.Text, "", "", TxDato3.Text, TxDato4.Text, lstAlmacenes) & vbCrLf
            sql = sql & " ) AS G" & vbCrLf
            sql = sql & " WHERE COALESCE(IdEnvase,0) <> 0" & vbCrLf
            If RbSiRetornables.Checked Then
                sql = sql & " AND Ret = 'S'" & vbCrLf
            ElseIf RbNoRetornables.Checked Then
                sql = sql & " AND Ret = 'N'" & vbCrLf
            End If
            sql = sql & " GROUP BY IdEnvase, NombreEnvase, Ret" & vbCrLf
            sql = sql & vbCrLf & "ORDER BY IdEnvase"

        End If


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(Sql)


        GridView1.Columns.Clear()


        If Not IsNothing(dt) Then


            For Each row As DataRow In dt.Rows

                Dim Saldo As Decimal = 0
                Dim Inicial As Decimal = 0

                If RbSiValorado.Checked Then
                    Saldo = VaDec(row("SaldoValorado"))
                    Inicial = VaDec(row("InicialValorado"))
                Else
                    Saldo = VaDec(row("Saldo"))
                    Inicial = VaDec(row("Inicial"))
                End If

                row("InicialStr") = StSaldo(Inicial)
                row("SaldoStr") = StSaldo(Saldo)
                row("Envase") = VaInt(row("IdEnvase")).ToString("00000") & " " & row("Envase").ToString

            Next


            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim dv As New DataView(dt)
                    If RbSiValorado.Checked Then
                        dv.RowFilter = "(InicialValorado <> 0 or RetiraValorado <> 0 or EntregaValorado <> 0 or SaldoValorado <> 0) "
                    ElseIf RbNoValorado.Checked Then
                        dv.RowFilter = "(Inicial <> 0 or Retira <> 0 or Entrega <> 0 or Saldo <> 0) "
                    End If
                    dt = dv.ToTable
                End If
            End If

        End If


        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()


        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("IdEnvase")) Then .ColumnByFieldName("IdEnvase").Visible = False
            If Not IsNothing(.ColumnByFieldName("Ret")) Then .ColumnByFieldName("Ret").Visible = False
            If Not IsNothing(.ColumnByFieldName("Saldo")) Then .ColumnByFieldName("Saldo").Visible = False
            If Not IsNothing(.ColumnByFieldName("SaldoValorado")) Then .ColumnByFieldName("SaldoValorado").Visible = False
            If Not IsNothing(.ColumnByFieldName("Inicial")) Then .ColumnByFieldName("Inicial").Visible = False
            If Not IsNothing(.ColumnByFieldName("InicialValorado")) Then .ColumnByFieldName("InicialValorado").Visible = False

            If Not ChkIncluirSaldoAnterior.Checked Then
                If Not IsNothing(.ColumnByFieldName("InicialStr")) Then .ColumnByFieldName("InicialStr").Visible = False
            End If

            If RbResumido.Checked Then
                If Not IsNothing(.ColumnByFieldName("IdAgricultor")) Then .ColumnByFieldName("IdAgricultor").Visible = False
                If Not IsNothing(.ColumnByFieldName("Agricultor")) Then .ColumnByFieldName("Agricultor").Visible = False
            End If

            If Not IsNothing(.ColumnByFieldName("Envase")) Then
                .ColumnByFieldName("Envase").Visible = False
                .ColumnByFieldName("Envase").GroupIndex = 1
            End If

            If RbSiValorado.Checked Then
                If Not IsNothing(.ColumnByFieldName("Retira")) Then .ColumnByFieldName("Retira").Visible = False
                If Not IsNothing(.ColumnByFieldName("Entrega")) Then .ColumnByFieldName("Entrega").Visible = False
            ElseIf RbNoValorado.Checked Then
                If Not IsNothing(.ColumnByFieldName("RetiraValorado")) Then .ColumnByFieldName("RetiraValorado").Visible = False
                If Not IsNothing(.ColumnByFieldName("EntregaValorado")) Then .ColumnByFieldName("EntregaValorado").Visible = False
            End If

        End With



        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDENVASE"
                    c.Caption = "CodEnv"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "INICIAL", "INICIALVALORADO", "INICIALSTR"
                    c.Caption = "Sal.Anterior"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "RETIRA", "ENTREGA", "SALDO", "RETIRAVALORADO", "ENTREGAVALORADO", "SALDOVALORADO"
                    'If RbSiValorado.Checked Then c.Caption = c.FieldName & "Valorado"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "SALDOSTR"
                    If RbSiValorado.Checked Then
                        c.Caption = "Saldo Valorado"
                    Else
                        c.Caption = "Saldo"
                    End If
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    c.Width = 80

            End Select

        Next


        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Inicial", "{0:n2}")
        AñadeResumenCampo("RetiraValorado", "{0:n2}")
        AñadeResumenCampo("EntregaValorado", "{0:n2}")
        AñadeResumenCampo("InicialValorado", "{0:n2}")
        AñadeResumenCampo("Saldo", "{0:n2}")
        AñadeResumenCampo("SaldoValorado", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "SaldoStr", "", DevExpress.Data.SummaryItemType.Custom)
        Funciones.AñadeResumenCampo(GridView1, "InicialStr", "", DevExpress.Data.SummaryItemType.Custom)




    End Sub



    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva

        GridView1.OptionsView.ShowGroupPanel = False

        BInforme.Visible = False

        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)
        Dim envases As String = FiltroDesdeHasta("Envase", TxDato3.Text, TxDato4.Text)
        Dim almacenes As String = FiltroCheckedComboBox("Almacen", cbAlmacenes)


        Dim RbValorados As RadioButton() = {RbSiValorado, RbNoValorado}
        Dim StrValorados As String() = {"SI", "NO"}
        Dim Valorados As String = FiltroRadioButton("Valorados", RbValorados, StrValorados)

        Dim RbRetornables As RadioButton() = {RbSiRetornables, RbNoRetornables, RbTodosRetornables}
        Dim StrRetornables As String() = {"SI", "NO", "Todos"}
        Dim Retornables As String = FiltroRadioButton("Retornables", RbRetornables, StrRetornables)

        Dim RbTipoListado As RadioButton() = {RbResumido, RbDetallado}
        Dim StrTipoListado As String() = {"Resumido", "Detallado"}
        Dim TipoListado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)



        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If envases <> "" Then LineasDescripcion.Add(envases)
        If almacenes <> "" Then LineasDescripcion.Add(almacenes)
        If Retornables <> "" Then LineasDescripcion.Add(Retornables)
        If Valorados <> "" Then LineasDescripcion.Add(Valorados)
        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)


        Dim Informe As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
        Informe.Landscape = False




        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                'Dim lstFamilias As New List(Of String)
                'For Each it As CheckedListBoxItem In CbFamilias.Properties.GetItems()
                '    If it.CheckState = CheckState.Checked Then
                '        lstFamilias.Add(it.Value.ToString)
                '    End If
                'Next

                'ImprimirInventarioMateriales(dt, TxDato1.Text, TxDato2.Text, chkMarcas.Checked, CbAlmacenes.Text, lstFamilias)

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


    Public Overrides Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)


        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then


                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                If item.FieldName.ToUpper.Trim = "SALDOSTR" Then

                    Dim Saldo As Decimal = 0
                    If RbSiValorado.Checked Then
                        Saldo = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(7)))
                    Else
                        Saldo = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                        Dim a As String = ""
                    End If
                    e.TotalValue = StSaldo(Saldo)

                ElseIf item.FieldName.ToUpper.Trim = "INICIALSTR" Then

                    Dim Inicial As Decimal = 0
                    If RbSiValorado.Checked Then
                        Inicial = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                    Else
                        Inicial = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                    End If
                    e.TotalValue = StSaldo(Inicial)

                End If


                'Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                'Dim a As String = ""

            End If


            If e.IsTotalSummary Then

                Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item


                If item.FieldName.ToUpper.Trim = "SALDOSTR" Then

                    Dim saldo As Decimal = 0
                    If RbSiValorado.Checked Then
                        Dim colSaldoValorado As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("SaldoValorado")
                        If Not IsNothing(colSaldoValorado) Then
                            saldo = VaDec(colSaldoValorado.SummaryItem.SummaryValue)
                        End If
                    Else
                        Dim colSaldo As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Saldo")
                        If Not IsNothing(colSaldo) Then
                            saldo = VaDec(colSaldo.SummaryItem.SummaryValue)
                        End If
                    End If
                    e.TotalValue = StSaldo(saldo)

                ElseIf item.FieldName.ToUpper.Trim = "INICIALSTR" Then

                    Dim Inicial As Decimal = 0
                    If RbSiValorado.Checked Then
                        Dim colInicialValorado As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("InicialValorado")
                        If Not IsNothing(colInicialValorado) Then
                            Inicial = VaDec(colInicialValorado.SummaryItem.SummaryValue)
                        End If
                    Else
                        Dim colInicial As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Inicial")
                        If Not IsNothing(colInicial) Then
                            Inicial = VaDec(colInicial.SummaryItem.SummaryValue)
                        End If
                    End If
                    e.TotalValue = StSaldo(Inicial)

                End If

            End If


        End If


    End Sub


End Class

