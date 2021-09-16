
Public Class FrmExtractoEnvasesPorMaterial
    Inherits FrConsulta


    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Envases.ENV_IdEnvase, Lb1, True)
        ParamTx(TxDato2, Envases.ENV_IdEnvase, Lb2, True)
        ParamChk(ChkMarcas, Nothing, "S", "N")
        ParamTx(TxDato3, Nothing, Lb3, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDato4, Nothing, Lb4, True, Cdatos.TiposCampo.Fecha, True)

        AsociarControles(TxDato1, BtBusca1, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_2)



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)
        BInforme.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        GridView1.OptionsView.ShowGroupPanel = False

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


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()


        GridView1.Columns.Clear()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim Acreedores As New E_Acreedores(Idusuario, cn)

        Dim lst As New List(Of String)
        For Each it As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cbAlmacenes.Properties.GetItems()
            If it.CheckState = CheckState.Checked Then
                lst.Add(it.Value.ToString & "")
            End If
        Next


        Dim sqlAlmacenes As String = ""
        Dim sqlAlmInicial As String = ""

        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)


        For Each s As String In lst

            If sqlAlmInicial.Trim <> "" Then sqlAlmInicial = sqlAlmInicial & " OR"
            sqlAlmInicial = sqlAlmInicial & " ENI_Codigo = " & s

            If sqlAlmacenes.Trim <> "" Then sqlAlmacenes = sqlAlmacenes & " OR"
            sqlAlmacenes = sqlAlmacenes & " VEL_IdAlmacen = " & s

        Next
        If sqlAlmInicial.Trim <> "" Then sqlAlmInicial = " AND (" & sqlAlmInicial & ")"
        If sqlAlmacenes.Trim <> "" Then sqlAlmacenes = " AND (" & sqlAlmacenes & ")"


        'Saldos iniciales
        Dim sql As String = "SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " ENI_Inicial as Inicial, 0 as InicialValorado" & vbCrLf
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENI_IdEnvase = ENV_IdEnvase" & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & vbCrLf
        sql = sql & " AND ENI_Tipo = 'AL'" & vbCrLf
        sql = sql & " AND COALESCE(ENI_Precio, 0) = 0" & vbCrLf
        If TxDato1.Text.Trim <> "" Then sql = sql & " AND ENI_IdEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sql = sql & " AND ENI_IdEnvase <= " & TxDato2.Text & vbCrLf
        sql = sql & sqlAlmInicial & vbCrLf
        If lstFamilias.Count > 0 Then sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " 0 as Inicial, ENI_Inicial as InicialValorado" & vbCrLf
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENI_IdEnvase = ENV_IdEnvase" & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & vbCrLf
        sql = sql & " AND ENI_Tipo = 'AL'" & vbCrLf
        sql = sql & " AND COALESCE(ENI_Precio, 0) <> 0" & vbCrLf
        If TxDato1.Text.Trim <> "" Then sql = sql & " AND ENI_IdEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sql = sql & " AND ENI_IdEnvase <= " & TxDato2.Text & vbCrLf
        sql = sql & sqlAlmInicial & vbCrLf
        If lstFamilias.Count > 0 Then sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " COALESCE(VEL_Entrega,0) - COALESCE(VEL_Retira,0) as Inicial, 0 as InicialValorado" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " WHERE (COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0)) = 0" & vbCrLf
        If TxDato1.Text <> "" Then sql = sql & " AND VEL_IdEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
        If TxDato3.Text.Trim <> "" Then sql = sql & " AND VEV_Fecha < '" & TxDato3.Text & "'" & vbCrLf
        sql = sql & " AND VEV_FECHA >= '" & Format(MiMaletin.FechaInicioEjercicio, "dd/MM/yyyy") + "'"
        sql = sql & sqlAlmacenes & vbCrLf
        If lstFamilias.Count > 0 Then sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " 0 as Inicial, COALESCE(VEL_Entrega,0) - COALESCE(VEL_Retira,0) as InicialValorado" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        If ChkMarcas.Checked Then sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " WHERE (COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0)) <> 0" & vbCrLf
        If TxDato1.Text <> "" Then sql = sql & " AND VEL_IdEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase <= " & TxDato2.Text & vbCrLf
        If TxDato3.Text.Trim <> "" Then sql = sql & " AND VEV_Fecha < '" & TxDato3.Text & "'" & vbCrLf
        sql = sql & " AND VEV_FECHA >= '" & Format(MiMaletin.FechaInicioEjercicio, "dd/MM/yyyy") + "'"
        sql = sql & sqlAlmacenes & vbCrLf
        If lstFamilias.Count > 0 Then sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf

        If ChkMarcas.Checked Then
            sql = "SELECT IdEnvase, Envase, IdMarca, Marca, SUM(Inicial) AS Inicial, SUM(InicialValorado) as InicialValorado FROM (" & vbCrLf & sql & vbCrLf & ") AS S " & vbCrLf & " GROUP BY IdEnvase, Envase, IdMarca, Marca"
        Else
            sql = "SELECT IdEnvase, Envase, SUM(Inicial) AS Inicial, SUM(InicialValorado) as InicialValorado FROM (" & vbCrLf & sql & vbCrLf & ") AS S " & vbCrLf & " GROUP BY IdEnvase, Envase"
        End If


        Dim dtIniciales As DataTable = Envases.MiConexion.ConsultaSQL(sql)

        'If Not IsNothing(dt) Then
        '    If dt.Rows.Count > 0 Then
        '        Inicial = VaDec(dt.Rows(0)("Inicial"))
        '        InicialValorado = VaDec(dt.Rows(0)("InicialValorado"))
        '    End If
        'End If

        'LbSaldoini.Text = (Inicial + InicialValorado).ToString("#,##0.00")



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idalmacen, "IdAlmacen")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        If ChkMarcas.Checked Then
            consulta.SelCampo(ValeEnvases_Lineas.VEL_idmarca, "IdMarca")
            consulta.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvases_Lineas.VEL_idmarca)
        End If
        consulta.SelCampo(AlmacenEnvases.AEV_Nombre, "Almacen", ValeEnvases_Lineas.VEL_idalmacen, AlmacenEnvases.AEV_Idalmacen)
        consulta.SelCampo(ValeEnvases.VEV_Numero, "Numero", ValeEnvases_Lineas.VEL_idvale, ValeEnvases.VEV_Idvale)
        consulta.SelCampo(ValeEnvases.VEV_Referencia, "Referencia")
        consulta.SelCampo(ValeEnvases.VEV_Fecha, "Fecha")
        consulta.SelCampo(ValeEnvases.VEV_Concepto, "Concepto")
        consulta.SelCampo(ValeEnvases.VEV_TipoSujeto, "Ts")
        consulta.SelCampo(ValeEnvases.VEV_Operacion, "Op")
        consulta.SelCampo(ValeEnvases.VEV_Codigo, "Codigo")
        consulta.SelCampo(ValeEnvases.VEV_TipoSujeto, "Nombre")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_entrega, "Entrega")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_precioentrega, "PrecioE")
        Dim oImporteEntrega As New Cdatos.bdcampo("@COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oImporteEntrega, "ImporteE")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_retira, "Retira")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_precioretira, "PrecioR")
        Dim oImporteRetira As New Cdatos.bdcampo("@COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oImporteEntrega, "ImporteR")
        consulta.SelCampo(New Cdatos.bdcampo("@'N'", Cdatos.TiposCampo.Cadena, 1), "EsInicial")
        consulta.SelCampo(New Cdatos.bdcampo("@COALESCE(VEL_Entrega,0) - COALESCE(VEL_Retira,0)", Cdatos.TiposCampo.Importe, 18, 2), "Calculo")
        'Dim oImporte As New Cdatos.bdcampo("@(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - (COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0))", Cdatos.TiposCampo.Importe, 18, 2)
        'consulta.SelCampo(oImporte, "Importe")
        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(ValeEnvases_Lineas.VEL_idenvase, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(ValeEnvases_Lineas.VEL_idenvase, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(ValeEnvases.VEV_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(ValeEnvases.VEV_Fecha, "<=", TxDato4.Text)

        sql = consulta.SQL & vbCrLf
        sql = sql & sqlAlmacenes & vbCrLf
        If lstFamilias.Count > 0 Then
            If consulta.Whe.Trim = "" Then
                sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " WHERE ") & vbCrLf
            Else
                sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ") & vbCrLf
            End If
        End If
        'sql = sql & " ORDER BY Fecha"

        Dim dtMovimientos As DataTable = Envases.MiConexion.ConsultaSQL(sql)


        Dim colSaldo As New DataColumn("Saldo", GetType(Decimal))
        colSaldo.DefaultValue = 0
        dtMovimientos.Columns.Add(colSaldo)




        'Inserta los saldos iniciales
        For Each row As DataRow In dtIniciales.Rows

            Dim fila As DataRow = dtMovimientos.NewRow()
            fila("IdEnvase") = row("IdEnvase")
            fila("Envase") = row("Envase")
            If ChkMarcas.Checked Then
                fila("IdMarca") = row("IdMarca")
                fila("Marca") = row("Marca")
            End If
            fila("Fecha") = VaDate(TxDato3.Text)
            fila("Concepto") = "Saldo Inicial"
            fila("Saldo") = VaDec(row("Inicial")) + VaDec(row("InicialValorado"))
            fila("TS") = ""
            fila("EsInicial") = "S"
            fila("Calculo") = fila("Saldo")
            dtMovimientos.Rows.Add(fila)

        Next


        If Not IsNothing(dtMovimientos) Then
            If dtMovimientos.Rows.Count > 0 Then
                Dim dv As New DataView(dtMovimientos)
                If ChkMarcas.Checked Then
                    dv.Sort = "IdEnvase, IdMarca, Fecha, EsInicial DESC"
                Else
                    dv.Sort = "IdEnvase, Fecha, EsInicial DESC"
                End If
                dtMovimientos = dv.ToTable
            End If
        End If





        Grid.DataSource = dtMovimientos
        AjustaColumnas()


        Dim Saldo As Decimal = 0
        Dim AuxIdEnvase As Integer = 0
        Dim AuxIdMarca As Integer = 0

        For Each rw In dtMovimientos.Rows


            If ChkMarcas.Checked Then
                If AuxIdEnvase <> VaInt(rw("IdEnvase")) Or AuxIdMarca <> VaInt(rw("IdMarca")) Then
                    'Cambio de envase
                    Saldo = 0
                End If
            Else
                If AuxIdEnvase <> VaInt(rw("IdEnvase")) Then
                    'Cambio de envase
                    Saldo = 0
                End If
            End If




            'Recalcula los saldos
            If VaDec(rw("Saldo")) <> 0 Then
                'Saldo inicial
                Saldo = VaDec(rw("Saldo"))
            Else
                'movimiento
                Saldo = Saldo + VaDec(rw("Entrega")) - VaDec(rw("Retira"))
                rw("Saldo") = Saldo
            End If


            'If VaDec(rw("Saldo")) <> 0 Then
            '    'Saldo inicial
            '    Saldo = VaDec(rw("Saldo"))
            'Else
            '    'movimiento
            '    Saldo = VaDec(rw("Entrega")) - VaDec(rw("Retira"))
            '    rw("Saldo") = Saldo
            'End If



            Dim codigo As String = rw("codigo").ToString

            Dim IdEnvase As String = VaInt(rw("IdEnvase")).ToString("00000")
            rw("Envase") = IdEnvase & " " & rw("Envase").ToString

            If ChkMarcas.Checked Then
                Dim IdMarca As String = VaInt(rw("IdMarca")).ToString("00000")
                rw("Marca") = IdMarca & " " & rw("Marca").ToString
            End If



            Select Case rw("Ts")
                Case "A"
                    If Agricultores.LeerId(codigo) = True Then
                        rw("Nombre") = Agricultores.AGR_Nombre.Valor
                    End If

                Case "C"
                    If Clientes.LeerId(codigo) = True Then
                        rw("Nombre") = Clientes.CLI_Nombre.Valor
                    End If

                Case "R"
                    If Acreedores.LeerId(codigo) = True Then
                        rw("Nombre") = Acreedores.ACR_Nombre.Valor
                    End If
                Case Else
                    rw("Nombre") = ""

            End Select



            AuxIdEnvase = VaInt(rw("IdEnvase"))

            If ChkMarcas.Checked Then
                AuxIdMarca = VaInt(rw("IdMarca"))
            End If

        Next




        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Calculo", "{0:n2}")
        AñadeResumenCampo("Saldo", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)


    End Sub


    Private Sub AjustaColumnas()

        With GridView1.Columns
            If Not IsNothing(.ColumnByFieldName("IdAlmacen")) Then .ColumnByFieldName("IdAlmacen").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdEnvase")) Then
                .ColumnByFieldName("IdEnvase").Visible = False
            End If
            If Not IsNothing(.ColumnByFieldName("Envase")) Then
                .ColumnByFieldName("Envase").Visible = False
                .ColumnByFieldName("Envase").GroupIndex = 1
            End If
            If Not IsNothing(.ColumnByFieldName("Marca")) Then
                .ColumnByFieldName("Marca").Visible = False
                .ColumnByFieldName("Marca").GroupIndex = 2
            End If
            If Not IsNothing(.ColumnByFieldName("EsInicial")) Then .ColumnByFieldName("EsInicial").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdMarca")) Then .ColumnByFieldName("IdMarca").Visible = False
            If Not IsNothing(.ColumnByFieldName("Calculo")) Then .ColumnByFieldName("Calculo").Visible = False
        End With

        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "NUMERO"
                    c.Caption = "Nº Vale"
                    c.Width = 70

                Case "FECHA"
                    c.MinWidth = 75

                Case "CODIGO"
                    c.MinWidth = 45

                Case "ENTREGA", "RETIRA", "SALDO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 75

                Case "PRECIOR", "PRECIOE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                    c.Width = 85

                Case "IMPORTEE", "IMPORTER"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85

                Case "NOMBRE"
                    c.Width = 150
                Case "TS"
                    c.MinWidth = 20

                Case "OP"
                    c.MinWidth = 30

                Case "MARCA"
                    c.MinWidth = 75

            End Select

        Next


    End Sub


    Private Sub cbAlmacenes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbAlmacenes.KeyDown

        If e.KeyCode = Keys.Enter Then

            If cbAlmacenes.IsPopupOpen Then
                cbAlmacenes.ClosePopup()
            End If

            BConsultar.Select()
            BConsultar.Focus()

        End If

    End Sub


    Private Sub TxDato3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato3.KeyDown
        If e.KeyCode = Keys.Up Then
            cbAlmacenes.Select()
            cbAlmacenes.Focus()
            cbAlmacenes.ShowPopup()
        End If
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim envases As String = FiltroDesdeHasta("Envase", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim almacenes As String = FiltroCheckedComboBox("Almacen", cbAlmacenes)

        If envases <> "" Then LineasDescripcion.Add(envases)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If almacenes <> "" Then LineasDescripcion.Add(almacenes)


        MyBase.Imprimir()

    End Sub

    Private Sub TxAMarca_Valida(edicion As System.Boolean)

        If edicion Then
            cbAlmacenes.Select()
            cbAlmacenes.Focus()
            cbAlmacenes.ShowPopup()
        End If


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then


                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "SALDO" Then

                        Dim saldo_total As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                        e.TotalValue = saldo_total

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "SALDO" Then

                        Dim saldo_total As Decimal = 0
                        Dim saldo As Decimal = 0

                        Dim colCalculo As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Calculo")
                        If Not IsNothing(colCalculo) Then saldo_total = VaDec(colCalculo.SummaryItem.SummaryValue)

                        e.TotalValue = saldo_total

                    End If

                End If

            End If


        Catch ex As Exception

        End Try

    End Sub


    Private Sub FrmExtractoEnvasesPorMaterial_DespuesDeAplicarPlantilla() Handles MyBase.DespuesDeAplicarPlantilla

        GridView1.BeginUpdate()
        Dim maxLevel As Integer = CInt(1)
        GridView1.DataController.CollapseAll()
        GridView1.DataController.GroupInfo.LastExpandableLevel = maxLevel
        GridView1.DataController.ExpandAll()
        GridView1.DataController.GroupInfo.LastExpandableLevel = -1
        GridView1.EndUpdate()

    End Sub


    Private Sub TxDato3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato3_Valida(edicion As Boolean) Handles TxDato3.Valida
        If CDate(TxDato3.Text) < MiMaletin.FechaInicioEjercicio Then
            MsgBox("La fecha debe ser superior a " + MiMaletin.FechaInicioEjercicio.ToString)
            TxDato3.MiError = True
        End If
    End Sub
End Class