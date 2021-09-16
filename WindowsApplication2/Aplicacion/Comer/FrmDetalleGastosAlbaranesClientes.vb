Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls



Public Class FrmDetalleGastosAlbaranesClientes
    Inherits FrConsulta



    Private AlbSalida As New E_AlbSalida(Idusuario, cn)
    Private AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)
    Private AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
    Private GastosComercio As New E_GastosComercio(Idusuario, cn)



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
        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato3, Clientes.CLI_Nombre, Lb3)
        ParamTx(TxDato4, Clientes.CLI_Nombre, Lb4)

        AsociarControles(TxDato3, BtBusca3, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_3)
        AsociarControles(TxDato4, BtBusca4, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_4)

    End Sub


    Private Sub FrmDiferenciaProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Fechaspordefecto()
    End Sub


    Private Sub Fechaspordefecto()

        TxDato1.Text = MiMaletin.FechaInicioEjercicio
        TxDato2.Text = Now.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()


    End Sub


    Private Sub CargaGrid()


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_idalbaran, "IdAlbaran")
        CONSULTA.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        CONSULTA.SelCampo(AlbSalida.ASA_idcliente, "IdCliente")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        Dim oKilos As New Cdatos.bdcampo("@SUM(ASL_KilosNetos)", AlbSalida_Lineas.ASL_kilosnetos.TipoBd, AlbSalida_Lineas.ASL_kilosnetos.Longitud, AlbSalida_Lineas.ASL_kilosnetos.Decimales)
        CONSULTA.SelCampo(oKilos, "Kilos")
        Dim oImpVta As New Cdatos.bdcampo("@SUM(COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1))", AlbSalida_Lineas.ASL_importegenerovta.TipoBd, AlbSalida_Lineas.ASL_importegenerovta.Longitud, AlbSalida_Lineas.ASL_importegenerovta.Decimales)
        CONSULTA.SelCampo(oImpVta, "ImpVta")
        If TxDato1.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_idcliente, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_idcliente, "<=", TxDato4.Text)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        If CONSULTA.Whe.Trim = "" Then
            sql = sql & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE " & vbCrLf)
        Else
            sql = sql & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND " & vbCrLf)
        End If
        sql = sql & " GROUP BY ASL_IdAlbaran, ASA_Albaran, ASA_FechaSalida, ASA_IdCliente, CLI_Nombre"


        If RbDetalladoAlbaran.Checked Then
            sql = "SELECT IdAlbaran, Albaran, Fecha, IdCliente, Cliente, Kilos, ImpVta, ASG_IdGasto as IdGasto, GCO_Nombre as Gasto, " & vbCrLf & _
                " ASG_TipoKBP as KBP, ASG_ValorGasto as Valor, ASG_ImporteGastoEuros as ImpGto, ASG_TipoFC as FC" & vbCrLf & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") AS G" & vbCrLf & _
                " LEFT JOIN AlbSalida_Gastos ON G.IdAlbaran = ASG_IdAlbaran" & vbCrLf & _
                " LEFT JOIN GastosComercio ON GCO_IdGasto = ASG_IdGasto" & vbCrLf & _
                " ORDER BY Albaran, ASG_IdGasto"
        ElseIf RbTotalizadoCliente.Checked Then
            sql = "SELECT IdCliente, Cliente, ASG_IdGasto as IdGasto, GCO_Nombre as Gasto, " & vbCrLf & _
                " SUM(ASG_ImporteGastoEuros) as ImpGto, ASG_TipoFC as FC" & vbCrLf & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") AS G" & vbCrLf & _
                " LEFT JOIN AlbSalida_Gastos ON G.IdAlbaran = ASG_IdAlbaran" & vbCrLf & _
                " LEFT JOIN GastosComercio ON GCO_IdGasto = ASG_IdGasto" & vbCrLf & _
                " GROUP BY IdCliente, Cliente, ASG_IdGasto, GCO_Nombre, ASG_TipoFC" & vbCrLf & _
                " ORDER BY IdCliente, ASG_IdGasto, ASG_TipoFC"
        End If


        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        GridView1.Columns.Clear()
        Grid.DataSource = dt
        AjustaColumnas()


        AñadeResumenCampo("ImpGto", "{0:n2}")


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "IDCLIENTE", "IDGASTO"
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "GASTO"
                        c.Width = 200

                    Case "KILOS"
                        c.Width = 80
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"

                    Case "IMPVTA"
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"

                    Case "IMPGTO"
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"
                        c.MinWidth = 100
                        c.Width = 100

                    Case "VALOR"
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.0000"
                        c.Width = 80

                    Case "FC"
                        c.MaxWidth = 30
                        c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)

                If RbDetalladoAlbaran.Checked Then
                    ImprimirDetalleGastosDetalladoAlbaran(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta)
                ElseIf RbTotalizadoCliente.Checked Then
                    ImprimirGastosAlbaranTotalizadosCliente(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta)
                End If

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

        LineasDescripcion.Clear()


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)
        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato3.Text, TxDato4.Text)
        Dim puntoventa As String = FiltroCheckedComboBox("Punto de venta", cbPuntoVenta)

        Dim RbTipoListado As RadioButton() = {RbDetalladoAlbaran, RbTotalizadoCliente}
        Dim StrTipoListado As String() = {"Detallado por albarán", "Totalizado por cliente"}
        Dim TipoListado As String = FiltroRadioButton("Tipo de listado", RbTipoListado, StrTipoListado)

        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)
        If puntoventa <> "" Then LineasDescripcion.Add(puntoventa)


        MyBase.Imprimir()

    End Sub



End Class
