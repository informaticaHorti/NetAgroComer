
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmListadoEnvasesPorAlbaran
    Inherits FrConsulta


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)



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
        ParamTx(TxDato5, Envases.ENV_IdEnvase, Lb5)
        ParamTx(TxDato6, Envases.ENV_IdEnvase, Lb6)
        ParamTx(TxDato7, AlbSalida.ASA_fechasalida, Lb7)

        AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)
        AsociarControles(TxDato5, BtBusca5, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_5)
        AsociarControles(TxDato6, BtBusca6, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_6)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

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

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "FechaSal")
        consulta.SelCampo(AlbSalida.ASA_idcliente, "IdCliente")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        consulta.SelCampo(Facturas.FRA_factura, "Factura", AlbSalida.ASA_idfactura)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idenvase, "IdEnvase", AlbSalida.ASA_idvaleenvase, ValeEnvases_Lineas.VEL_idvale)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvases_Lineas.VEL_idmarca, Marcas.MAR_Idmarca)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_retira, "Retira")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_precioretira, "PrecioRetira")
        Dim strEntrega As New Cdatos.bdcampo("@VEL_Entrega * -1", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(strEntrega, "Entrega")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_precioentrega, "PrecioEntrega")
        Dim strImporteRetira As New Cdatos.bdcampo("@(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0))", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(strImporteRetira, "ImporteRetira")
        Dim strImporteEntrega As New Cdatos.bdcampo("@(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0))", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(strImporteEntrega, "ImporteEntrega")
        If TxDato1.Text <> "" Then consulta.WheCampo(AlbSalida.ASA_idcliente, ">=", TxDato1.Text)
        If TxDato2.Text <> "" Then consulta.WheCampo(AlbSalida.ASA_idcliente, "<=", TxDato2.Text)
        If TxDato3.Text <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)
        If TxDato5.Text <> "" Then consulta.WheCampo(ValeEnvases_Lineas.VEL_idenvase, ">=", TxDato5.Text)
        If TxDato6.Text <> "" Then consulta.WheCampo(ValeEnvases_Lineas.VEL_idenvase, "<=", TxDato6.Text)
        If RbSiFacturados.Checked Then
            consulta.WheCampo(AlbSalida.ASA_idfactura, ">", "0")
        ElseIf RbNoFacturados.Checked Then
            consulta.WheCampo(AlbSalida.ASA_idfactura, "=", "0")
        End If

        If TxDato7.Text <> "" Then
            consulta.WheCampo(Facturas.FRA_fecha, ">=", TxDato7.Text)
        End If



        Dim sql As String = consulta.SQL & vbCrLf


        Dim lst As List(Of String) = ListadeCombo(cbPuntoVenta)
        If lst.Count > 0 Then
            If consulta.Whe = "" Then
                sql = sql & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, lst, " WHERE ") & vbCrLf
            Else
                sql = sql & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, lst, " AND ") & vbCrLf
            End If
        End If

        sql = sql & " ORDER BY ASA_FechaSalida, ASA_Albaran, VEL_IdEnvase"


        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        If chkSoloPrecio.Checked Then
            Dim dv As New DataView(dt)
            dv.RowFilter = "PrecioRetira <> 0 OR PrecioEntrega <> 0"
            dt = dv.ToTable
        End If


        Grid.DataSource = dt
        AjustaColumnas()


        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("ImporteRetira", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("ImporteEntrega", "{0:n2}")



    End Sub



    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "IDVALEENVASE", "IDMARCA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDCLIENTE"
                    c.Caption = "CodCli"
                    c.Width = 50
                Case "RETIRA", "ENTREGA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 75
                Case "PRECIORETIRA", "PRECIOENTREGA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80
            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        Dim lstPuntosVenta As New List(Of String)
        For Each it As CheckedListBoxItem In cbPuntoVenta.Properties.GetItems
            If it.CheckState = CheckState.Checked Then
                lstPuntosVenta.Add(VaInt(it.Value).ToString)
            End If
        Next
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim Facturados As String = ""
                If RbSiFacturados.Checked Then
                    Facturados = "S"
                ElseIf RbNoFacturados.Checked Then
                    Facturados = "N"
                End If

                ImprimirListadoAlbaranesEnvases(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, TxDato5.Text, TxDato6.Text, lstPuntosVenta, Facturados, chkSoloPrecio.Checked)
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

        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim envases As String = FiltroDesdeHasta("Envase", TxDato5.Text, TxDato6.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbPuntoVenta)

        Dim RbFacturados As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim StrFacturados As String() = {"SI", "NO", "TODOS"}
        Dim Facturados As String = FiltroRadioButton("Facturados", RbFacturados, StrFacturados)

        Dim soloconprecio As String = FiltroCheckBox("", chkSoloPrecio, "SOLO CON PRECIO", "")


        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If envases <> "" Then LineasDescripcion.Add(envases)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If soloconprecio <> "" Then LineasDescripcion.Add(soloconprecio)



        MyBase.Imprimir()
    End Sub


End Class