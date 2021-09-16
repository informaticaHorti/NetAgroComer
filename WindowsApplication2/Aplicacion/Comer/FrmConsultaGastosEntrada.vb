
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaGastosEntrada



    Inherits FrConsulta

    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim tiposdegastoagri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim FActurasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


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
    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1)
        ParamTx(TxDato2, Acreedores.ACR_Codigo, Lb2)
        ParamTx(TxDato3, Albentrada.AEN_Fecha, Lb3)
        ParamTx(TxDato4, Albentrada.AEN_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

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


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_hisgastos.AHG_id, "Id")
        consulta.SelCampo(Albentrada_hisgastos.AHG_idgasto, "Codigo")
        consulta.SelCampo(tiposdegastoagri.TGA_Nombre, "Gasto", Albentrada_hisgastos.AHG_idgasto)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_hisgastos.AHG_idalbaran)
        consulta.SelCampo(Albentrada_his.AEH_nmed, "Med", Albentrada_hisgastos.AHG_idalbhis)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Albentrada_his.AEH_idproveedor, "Agri")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Albentrada_his.AEH_idproveedor)
        consulta.SelCampo(PuntoVenta.Nombre, "Pventa", Albentrada.AEN_IdPuntoVenta)
        If chkMostrarOrigenGastos.Checked Then
            Dim oBultos As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oBultos, "Bultos")
            Dim oKilos As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oKilos, "Kilos")
            Dim oImporte As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oImporte, "Importe")
        End If
        consulta.SelCampo(Albentrada_hisgastos.AHG_valor, "Vgasto")
        consulta.SelCampo(Albentrada_hisgastos.AHG_tipo, "Tipo")
        consulta.SelCampo(Albentrada_hisgastos.AHG_importe, "ImpGasto")
        consulta.SelCampo(Albentrada_hisgastos.AHG_factura_comercial, "FC")
        consulta.SelCampo(Albentrada_hisgastos.AHG_idacreedor, "Acreedor")
        consulta.SelCampo(Acreedores.ACR_Nombre, "NombreAcreedor", Albentrada_hisgastos.AHG_idacreedor)
        consulta.SelCampo(FActurasrecibidas.FRR_numerofactura, "Factura", Albentrada_hisgastos.AHG_idfacturaproveedor)


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato4.Text)
        If RbFacturadosSi.Checked = True Then consulta.WheCampo(Albentrada_hisgastos.AHG_idfacturaproveedor, ">", "0")
        If RbFacturadosNo.Checked = True Then consulta.WheCampo(Albentrada_hisgastos.AHG_idfacturaproveedor, "=", "0")

        Dim WHE As String = consulta.Whe


        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        Dim sql As String = consulta.Sel & WHE

        sql = sql & " order by Albaran,Fecha"

        GridView1.Columns.Clear()
        Dim dt As DataTable = Albentrada_his.MiConexion.ConsultaSQL(sql)


        If chkMostrarOrigenGastos.Checked Then
            For Each row As DataRow In dt.Rows

                Dim IdAlbEntradaHisGasto As String = (row("Id").ToString & "").Trim

                Dim Bultos As Decimal = 0
                Dim Kilos As Decimal = 0
                Dim Importe As Decimal = 0

                'row("Importe") = ImporteOrigenGasto(IdAlbEntradaHisGasto)

                OrigenGasto(IdAlbEntradaHisGasto, Bultos, Kilos, Importe)

                row("Bultos") = Bultos
                row("Kilos") = Kilos
                row("Importe") = Importe

            Next
        End If


        Grid.DataSource = dt


        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("Importe", "{0:n2}")
        AñadeResumenCampo("ImpGasto", "{0:n2}")

        AjustaColumnas()



    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "MED", "FECHA", "PVENTA", "NOMBRE", "AGRI", "CODIGO", "GASTO", "VGASTO", "TIPO", "FC", "IMPORTE", "IMPGASTO", "NOMBREACREEDOR", "FACTURA", "BULTOS", "KILOS"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "VGASTO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Width = 100
                Case "IMPORTE", "IMPGASTO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100
                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80


            End Select
        Next
    End Sub


    Public Sub OrigenGasto(IdAlbEntradaHisGasto As String,
                            ByRef Bultos As Decimal, ByRef Kilos As Decimal, ByRef Importe As Decimal)


        Dim sql As String = "SELECT AHG_Tipo as Tipo, AHG_Valor as ValorGasto, SUM(AHL_Bultos) as Bultos, SUM(AHL_Kilos) as Kilos," & vbCrLf
        ' sql = sql & " SUM(COALESCE(AHL_Kilos,0) * COALESCE(AHL_Precio,0)) as IGenero" & vbCrLf
        sql = sql & " SUM(COALESCE(AHL_importegenero,0)) as IGenero" & vbCrLf
        sql = sql & " FROM Albentrada_hisgastos" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_HisLineas ON AHL_IdAlbHis = AHG_IdAlbHis" & vbCrLf
        sql = sql & " WHERE AHG_Id = " & IdAlbEntradaHisGasto & vbCrLf
        sql = sql & " GROUP BY AHG_Tipo, AHG_Valor" & vbCrLf

        Dim dt As DataTable = Albentrada_his.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
                Select Case Tipo

                    Case "B"
                        Bultos = VaDec(row("Bultos"))
                    Case "K"
                        Kilos = VaDec(row("Kilos"))
                    Case "%"
                        Importe = VaDec(row("IGenero"))
                    Case "I"
                        Importe = VaDec(row("ValorGasto"))

                End Select

            Next
        End If


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()
        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                'ImprimirInformeAlbaranEntradas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text)
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