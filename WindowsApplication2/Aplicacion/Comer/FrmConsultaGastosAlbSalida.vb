
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaGastosAlbSalida



    Inherits FrConsulta

    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)

    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim FActurasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


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
        ParamTx(TxDato3, Albsalida.ASA_fechasalida, Lb3)
        ParamTx(TxDato4, Albsalida.ASA_fechasalida, Lb4)

        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        BInforme.Visible = False
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

        BInforme.Visible = False

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

        consulta.SelCampo(Albsalida_gastos.ASG_id, "Id")
        consulta.SelCampo(Albsalida_gastos.ASG_idgasto, "Codigo")
        consulta.SelCampo(GastosComercio.GCO_Nombre, "Gasto", Albsalida_gastos.ASG_idgasto)
        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Albsalida_gastos.ASG_idalbaran)
        consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Albsalida.ASA_idcliente, "Cliente")
        consulta.SelCampo(Clientes.CLI_Nombre, "Nombre", Albsalida.ASA_idcliente)
        consulta.SelCampo(PuntoVenta.Nombre, "Pventa", Albsalida.ASA_idpuntoventa)
        If chkMostrarOrigenGastos.Checked Then
            Dim oPalets As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oPalets, "Palets")
            Dim oBultos As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oBultos, "Bultos")
            Dim oKilos As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oKilos, "Kilos")
            Dim oImporte As New Cdatos.bdcampo("@0.00", Cdatos.TiposCampo.Importe, 18, 2)
            consulta.SelCampo(oImporte, "Importe")

        End If
        consulta.SelCampo(Albsalida_gastos.ASG_valorgasto, "Vgasto")
        consulta.SelCampo(Albsalida_gastos.ASG_tipokbp, "Tipo")
        consulta.SelCampo(Albsalida_gastos.ASG_importegastoeuros, "ImpGasto")
        consulta.SelCampo(Albsalida_gastos.ASG_tipofc, "Fc")
        consulta.SelCampo(Albsalida_gastos.ASG_idacreedor, "Acreedor")
        consulta.SelCampo(Acreedores.ACR_Nombre, "NombreAcreedor", Albsalida_gastos.ASG_idacreedor)
        consulta.SelCampo(FActurasrecibidas.FRR_numerofactura, "Factura", Albsalida_gastos.ASG_idfactura)




        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxDato4.Text)
        If RbFacturadosSi.Checked = True Then consulta.WheCampo(Albsalida_gastos.ASG_idfactura, ">", "0")
        If RbFacturadosNo.Checked = True Then consulta.WheCampo(Albsalida_gastos.ASG_idfactura, "=", "0")

        Dim WHE As String = consulta.Whe


        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(Albsalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Albsalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        Dim sql As String = consulta.Sel & WHE

        sql = sql & " order by Albaran,Fecha"

        GridView1.Columns.Clear()
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)

        If chkMostrarOrigenGastos.Checked Then
            For Each row As DataRow In dt.Rows
                Dim IdAlbSalidaGasto As String = (row("Id").ToString & "").Trim

                Dim Palets As Decimal = 0
                Dim Bultos As Decimal = 0
                Dim Kilos As Decimal = 0
                Dim Importe As Decimal = 0

                'row("Importe") = ImporteOrigenGasto(IdAlbSalidaGasto)
                OrigenGasto(IdAlbSalidaGasto, Palets, Bultos, Kilos, Importe)

                row("Palets") = Palets
                row("Bultos") = Bultos
                row("Kilos") = Kilos
                row("Importe") = Importe

            Next
        End If


        Grid.DataSource = dt


        AñadeResumenCampo("Palets", "{0:n0}")
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

                Case "ALBARAN", "FECHA", "PVENTA", "NOMBRE", "CLIENTE", "CODIGO", "GASTO", "VGASTO", "TIPO", "IMPORTE", "IMPGASTO", "NOMBREACREEDOR", "FACTURA", "FC", "PALETS", "BULTOS", "KILOS"
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
                Case "BULTOS", "PALETS"
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


    Private Sub OrigenGasto(IdAlbSalidaGasto As String,
                            ByRef Palets As Decimal, ByRef Bultos As Decimal, ByRef Kilos As Decimal, ByRef Importe As Decimal)

        Dim sql As String = "SELECT Tipo, ValorGasto, SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, SUM(Palets) as Palets, SUM(IGenero) as IGenero" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT ASG_TipoKBP as Tipo, ASG_ValorGasto as ValorGasto, ASL_Bultos as Bultos, ASL_KilosCliente as Kilos, " & vbCrLf
        sql = sql & " ASL_Palets as Palets, COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1) as IGenero " & vbCrLf
        sql = sql & " FROM Albsalida_gastos" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Lineas ON ASG_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASG_IdAlbaran = ASA_IdAlbaran" & vbCrLf
        sql = sql & " WHERE ASG_Id = " & IdAlbSalidaGasto & vbCrLf
        sql = sql & " ) AS G" & vbCrLf
        sql = sql & " GROUP BY Tipo, ValorGasto" & vbCrLf

        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
                Select Case Tipo

                    Case "B"
                        Bultos = VaDec(row("Bultos"))
                    Case "K"
                        Kilos = VaDec(row("Kilos"))
                    Case "P"
                        Palets = VaDec(row("Palets"))
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


    Public Overrides Sub Imprimir()

        Dim acreedores As String = FiltroDesdeHasta("Acreedor", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbPuntoVenta)

        Dim RbFacturados As RadioButton() = {RbFacturadosSi, RbFacturadosNo, RbFacturadosTodos}
        Dim StrFacturados As String() = {"SI", "NO", "TODOS"}
        Dim Facturados As String = FiltroRadioButton("Facturados", RbFacturados, StrFacturados)

        Dim MostrarOrigen As String = FiltroCheckBox("", chkMostrarOrigenGastos, "Mostrar origen del gasto", "")


        If acreedores <> "" Then LineasDescripcion.Add(acreedores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If MostrarOrigen <> "" Then LineasDescripcion.Add(MostrarOrigen)



        MyBase.Imprimir()
    End Sub


End Class