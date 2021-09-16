
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaSalidasResumido
    Inherits FrConsulta


    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)


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

        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1)
        ParamTx(TxDato2, Clientes.CLI_Codigo, Lb2)
        ParamTx(TxDato3, AlbSalida.ASA_fechasalida, Lb3)
        ParamTx(TxDato4, AlbSalida.ASA_fechasalida, Lb4)
        ParamTx(TxDato5, AlbSalida_Lineas.ASL_idgenero, Lb5)
        ParamTx(TxDato6, AlbSalida_Lineas.ASL_idgenero, Lb6)


        AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)
        AsociarControles(TxDato5, BtBusca5, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb_5)
        AsociarControles(TxDato6, BtBusca6, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb_6)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

        GridView1.OptionsView.ShowGroupPanel = False

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
        consulta.SelCampo(AlbSalida_Lineas.ASL_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
        consulta.SelCampo(AlbSalida.ASA_idvaleenvase, "IdVale")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(AlbSalida.ASA_idcliente, "CodCli")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        consulta.SelCampo(Clientes.CLI_Nombre, "NombreCliente")
        Dim oBultos As New Cdatos.bdcampo("@SUM(ASL_Bultos)", AlbSalida_Lineas.ASL_bultos.TipoBd, AlbSalida_Lineas.ASL_bultos.Longitud, AlbSalida_Lineas.ASL_bultos.Decimales)
        consulta.SelCampo(oBultos, "Bultos")
        Dim oBultosVen As New Cdatos.bdcampo("@SUM(ASL_BultosVendidos)", AlbSalida_Lineas.ASL_bultosvendidos.TipoBd, AlbSalida_Lineas.ASL_bultosvendidos.Longitud, AlbSalida_Lineas.ASL_bultosvendidos.Decimales)
        consulta.SelCampo(oBultosVen, "BultosVen")
        Dim oDifBultos As New Cdatos.bdcampo("@SUM(COALESCE(ASL_Bultos,0)) - SUM(COALESCE(ASL_BultosVendidos,0))", AlbSalida_Lineas.ASL_bultosvendidos.TipoBd, AlbSalida_Lineas.ASL_bultosvendidos.Longitud, AlbSalida_Lineas.ASL_bultosvendidos.Decimales)
        consulta.SelCampo(oDifBultos, "DifBultos")
        Dim oKilos As New Cdatos.bdcampo("@SUM(ASL_KilosNetos)", AlbSalida_Lineas.ASL_kilosnetos.TipoBd, AlbSalida_Lineas.ASL_kilosnetos.Longitud, AlbSalida_Lineas.ASL_kilosnetos.Decimales)
        consulta.SelCampo(oKilos, "Kilos")
        Dim oKilosVen As New Cdatos.bdcampo("@SUM(ASL_KilosVendidos)", AlbSalida_Lineas.ASL_kilosvendidos.TipoBd, AlbSalida_Lineas.ASL_kilosvendidos.Longitud, AlbSalida_Lineas.ASL_kilosvendidos.Decimales)
        consulta.SelCampo(oKilosVen, "KilosVen")
        Dim oDifKilos As New Cdatos.bdcampo("@SUM(COALESCE(ASL_KilosNetos,0)) - SUM(COALESCE(ASL_KilosVendidos,0))", AlbSalida_Lineas.ASL_kilosvendidos.TipoBd, AlbSalida_Lineas.ASL_kilosvendidos.Longitud, AlbSalida_Lineas.ASL_kilosvendidos.Decimales)
        consulta.SelCampo(oDifKilos, "DifKilos")
        Dim oImpEst As New Cdatos.bdcampo("@SUM(COALESCE(ASL_ImporteGeneroEstimado,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegeneroestimado.TipoBd, AlbSalida_Lineas.ASL_importegeneroestimado.Longitud, AlbSalida_Lineas.ASL_importegeneroestimado.Decimales)
        consulta.SelCampo(oImpEst, "ImpEst")
        Dim oImpSal As New Cdatos.bdcampo("@SUM(COALESCE(ASL_ImporteGenero,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegenero.TipoBd, AlbSalida_Lineas.ASL_importegenero.Longitud, AlbSalida_Lineas.ASL_importegenero.Decimales)
        consulta.SelCampo(oImpSal, "ImpSal")
        Dim oImpVen As New Cdatos.bdcampo("@SUM(COALESCE(ASL_importegenerovta,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegenerovta.TipoBd, AlbSalida_Lineas.ASL_importegenerovta.Longitud, AlbSalida_Lineas.ASL_importegenerovta.Decimales)
        consulta.SelCampo(oImpVen, "ImpVen")
        Dim oDifSal As New Cdatos.bdcampo("@SUM(COALESCE(ASL_ImporteGenero,0) * COALESCE(ASA_ValorCambio,1)) - SUM(COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegeneroestimado.TipoBd, AlbSalida_Lineas.ASL_importegeneroestimado.Longitud, AlbSalida_Lineas.ASL_importegeneroestimado.Decimales)
        consulta.SelCampo(oDifSal, "DifSal")
        Dim oDifEst As New Cdatos.bdcampo("@SUM(COALESCE(ASL_ImporteGeneroEstimado,0) * COALESCE(ASA_ValorCambio,1)) - SUM(COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegeneroestimado.TipoBd, AlbSalida_Lineas.ASL_importegeneroestimado.Longitud, AlbSalida_Lineas.ASL_importegeneroestimado.Decimales)
        consulta.SelCampo(oDifEst, "DifEst")
        Dim oGtoFra As New Cdatos.bdcampo("@(SELECT SUM(ASG_ImporteGastoEuros) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASL_IdAlbaran)", AlbSalida_Gastos.ASG_importegastoeuros.TipoBd, AlbSalida_Gastos.ASG_importegastoeuros.Longitud, AlbSalida_Gastos.ASG_importegastoeuros.Decimales)
        consulta.SelCampo(oGtoFra, "GtoFra")

        'Filtros
        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)
        If TxDato5.Text.Trim <> "" Then consulta.WheCampo(AlbSalida_Lineas.ASL_idgenero, ">=", TxDato5.Text)
        If TxDato6.Text.Trim <> "" Then consulta.WheCampo(AlbSalida_Lineas.ASL_idgenero, "<=", TxDato6.Text)


        Dim WHE As String = consulta.Whe


        'Entradas confeccionadas S/N
        If RbConfecSI.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F')  " & vbCrLf
        End If

        If RbConfecNO.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'C')  " & vbCrLf
        End If


        'Albaranes Valorados S/N
        If RbValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F' OR (ASA_TipoFC = 'C' AND ASA_FechaValoracion > '" & VaDate("").ToString("dd/MM/yyyy") & "')) " & vbCrLf
        End If

        If RbNoValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " ( ASA_TipoFC = 'C' AND ASA_FechaValoracion <= '" & VaDate("").ToString("dd/MM/yyyy") & "') " & vbCrLf

        End If


        'Albaranes Facturados S/N
        If RbSiFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            End If
        ElseIf RbNoFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            End If
        End If


        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If



        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & vbCrLf & WHE & vbCrLf
        sql = sql & " GROUP BY ASA_IdCliente, CLI_Nombre, ASL_IdAlbaran, ASA_Albaran, ASA_FechaSalida, ASA_IdValeEnvase " & vbCrLf
        sql = sql & " ORDER BY ASA_IdCliente, ASL_IdAlbaran"


        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            dt.Columns.Add("ImpEnv", GetType(Decimal)).SetOrdinal(18)
        End If


        For Each row As DataRow In dt.Rows

            Dim CodCli As String = VaInt(row("CodCli")).ToString("00000")
            Dim Cliente As String = row("Cliente").ToString & ""
            row("NombreCliente") = CodCli & " " & Cliente

            'Calcular ImpEnv
            Dim IdVale As String = (row("IdVale").ToString & "").Trim
            row("ImpEnv") = AlbSalida.TotalEnvases(IdVale)
        Next


        




        Grid.DataSource = dt
        AjustaColumnas()

        With GridView1.Columns
            If Not IsNothing(.ColumnByFieldName("NombreCliente")) Then
                .ColumnByFieldName("NombreCliente").GroupIndex = 1
            End If
        End With




        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("BultosVen", "{0:n0}")
        AñadeResumenCampo("DifBultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("KilosVen", "{0:n0}")
        AñadeResumenCampo("DifKilos", "{0:n0}")
        AñadeResumenCampo("ImpEst", "{0:n2}")
        AñadeResumenCampo("ImpSal", "{0:n2}")
        AñadeResumenCampo("ImpVen", "{0:n2}")
        AñadeResumenCampo("DifSal", "{0:n2}")
        AñadeResumenCampo("DifEst", "{0:n2}")
        AñadeResumenCampo("ImpEnv", "{0:n2}")
        AñadeResumenCampo("GtoFra", "{0:n2}")



    End Sub



    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "IDVALE"
                    c.Visible = False
                Case "NOMBRECLIENTE"
                    c.Caption = "Cliente"
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS"
                    c.Caption = "BulSal"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 55
                Case "BULTOSVEN"
                    c.Caption = "BulVen"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 55
                Case "DIFBULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 55
                Case "KILOS"
                    c.Caption = "KilosSal"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "KILOSVEN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "DIFKILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "IMPEST", "IMPSAL", "IMPVEN", "DIFSAL", "DIFEST", "IMPENV", "GTOFRA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 75

                Case "ALBARAN"
                    c.Width = 65

                Case "FECHA"
                    c.Width = 80

                Case "CODCLI"
                    c.Width = 55

            End Select
        Next


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim generos As String = FiltroDesdeHasta("Genero", TxDato5.Text, TxDato6.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbPuntoVenta)

        Dim RbAlbValorado As RadioButton() = {RbValorados, RbNoValorados}
        Dim StrAlbValorado As String() = {"SI", "NO"}
        Dim TipoAlbaranes As String = FiltroRadioButton("Albaranes Valorados", RbAlbValorado, StrAlbValorado)

        Dim RbFacturados As RadioButton() = {RbSiFacturados, RbNoFacturados}
        Dim StrFacturados As String() = {"SI", "NO"}
        Dim Facturados As String = FiltroRadioButton("Albaranes Facturados", RbFacturados, StrFacturados)

        Dim RbConfec As RadioButton() = {RbConfecSI, RbConfecNO, RbConfecTodas}
        Dim StrConfec As String() = {"SI", "NO", "Todas"}
        Dim confeccionadas As String = FiltroRadioButton("Entradas confeccionadas", RbConfec, StrConfec)



        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If generos <> "" Then LineasDescripcion.Add(generos)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If TipoAlbaranes <> "" Then LineasDescripcion.Add(TipoAlbaranes)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If confeccionadas <> "" Then LineasDescripcion.Add(confeccionadas)



        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim Confeccionadas As String = ""
                Dim Facturados As String = ""
                Dim Valorados As String = ""


                If RbConfecSi.Checked Then
                    Confeccionadas = "SI"
                ElseIf RbConfecNo.Checked Then
                    Confeccionadas = "NO"
                ElseIf RbConfecTodas.Checked Then
                    Confeccionadas = "Todos"
                End If

                If RbSiFacturados.Checked Then
                    Facturados = "SI"
                ElseIf RbNoFacturados.Checked Then
                    Facturados = "NO"
                ElseIf RbTodosFacturados.Checked Then
                    Facturados = "Todos"
                End If

                If RbValorados.Checked Then
                    Valorados = "SI"
                ElseIf RbNoValorados.Checked Then
                    Valorados = "NO"
                ElseIf RbTodosValorados.Checked Then
                    Valorados = "Todos"
                End If


                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)

                ImprimirListadoConsultaSalidasResumido(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, TxDato5.Text, TxDato6.Text,
                                                    Valorados, Facturados, Confeccionadas, lstPuntoVenta)

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


End Class