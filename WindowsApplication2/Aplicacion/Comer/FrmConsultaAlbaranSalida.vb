
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaAlbaranSalida
    Inherits FrConsulta

    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim AlbSalidalineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)

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


    'Private Class stClaves_Salidas

    '    Public IdAlbaran As Integer = 0
    '    Public IdGenero As Integer = 0
    '    Public IdCategoria As Integer = 0
    '    Public IdTipoConfeccion As Integer = 0
    '    Public IdTipoPalet As Integer = 0


    '    Public Albaran As String = ""
    '    Public Fecha As String = ""
    '    Public PVenta As String = ""
    '    Public Factura As String = ""
    '    Public Cliente As String = ""
    '    Public Genero As String = ""
    '    Public Categoria As String = ""
    '    Public Confeccion As String = ""
    '    Public ConfecPalet As String = ""


    '    Public Sub New(IdAlbaran As Integer, IdGenero As Integer, IdCategoria As Integer, IdTipoConfeccion As Integer, IdTipoPalet As Integer)
    '        Me.IdAlbaran = IdAlbaran
    '        Me.IdGenero = IdGenero
    '        Me.IdCategoria = IdCategoria
    '        Me.IdTipoConfeccion = IdTipoConfeccion
    '        Me.IdTipoPalet = IdTipoPalet
    '    End Sub

    'End Class

    'Private Class stDatos_Salidas

    '    Public Palets As Integer = 0
    '    Public Bultos As Integer = 0
    '    Public KilosCliente As Decimal = 0

    '    Public Sub New(Palets As Integer, Bultos As Integer, KilosCliente As Decimal)
    '        Me.Palets = Palets
    '        Me.Bultos = Bultos
    '        Me.KilosCliente = KilosCliente
    '    End Sub

    'End Class


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)

        ListaControles = lc

        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1)
        ParamTx(TxDato2, Clientes.CLI_Codigo, Lb2)
        ParamTx(TxDato3, AlbSalida.ASA_fechasalida, Lb3)
        ParamTx(TxDato4, AlbSalida.ASA_fechasalida, Lb4)

        AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)

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

        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)
        If RbSiFacturados.Checked Then consulta.WheCampo(AlbSalida.ASA_fechavaloracion, ">", VaDate("").ToString("dd/MM/yyyy"))
        If RbNoFacturados.Checked Then consulta.WheCampo(AlbSalida.ASA_fechavaloracion, "<=", VaDate("").ToString("dd/MM/yyyy"))

        Dim WHE As String = consulta.Whe

        'Facturado SN
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

        Dim orby As String = " ORDER BY fecha, albaran"
        Dim sel = "Select ASA_idalbaran AS IdAlbaran,ASA_albaran AS Albaran, "
        sel = sel & "ASA_fechasalida AS Fecha,"
        sel = sel & "ContabilidadCosta.dbo.PuntoVenta.Nombre AS PVenta, "
        sel = sel & "ASA_IdCliente as CodCli,"
        sel = sel & "CLI_Nombre AS Cliente, "
        If chkDivisa.Checked Then
            sel = sel & "SUM(ASL_importegenero) AS Importe, "
        Else
            sel = sel & "SUM(COALESCE(ASL_ImporteGenero,0) * COALESCE(ASA_ValorCambio,1)) as Importe, "
        End If
        sel = sel & "FRA_serie AS Serie, "
        sel = sel & "FRA_factura AS Factura "
        sel = sel & "from AlbSalida"
        sel = sel & " LEFT OUTER JOIN Albsalida_lineas ON  ASA_idalbaran = ASL_idalbaran "
        sel = sel & " LEFT OUTER JOIN ContabilidadCosta.dbo.PuntoVenta ON ASA_idpuntoventa = ContabilidadCosta.dbo.PuntoVenta.IdPuntoVenta "
        sel = sel & " LEFT OUTER JOIN Clientes ON ASA_idcliente = Clientes.CLI_Idcliente "
        sel = sel & " LEFT OUTER JOIN Facturas ON ASA_idfactura = Facturas.FRA_idfactura"

        Dim grby As String = "group by ASA_idalbaran,ASA_albaran,ASA_fechasalida,ContabilidadCosta.dbo.PuntoVenta.Nombre,ASA_IdCliente, CLI_Nombre,"
        grby = grby & "FRA_serie, FRA_factura"



        Dim sql As String = sel & WHE & grby & orby

        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        'If Not IsNothing(GridView1.Columns.ColumnByFieldName("Albaran")) Then
        '    GridView1.Columns.ColumnByFieldName("Albaran").GroupIndex = 1
        '    GridView1.ExpandAllGroups()
        'End If

        AñadeResumenCampo("Importe", "{0:n2}")
        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "FECHA", "PVENTA", "SERIE", "FACTURA", "CLIENTE", "IMPORTE", "CODCLI"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CODCLI"
                    c.Width = 50
                Case "PVENTA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA"
                    c.MinWidth = 85
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select
        Next
    End Sub

    Public Overrides Sub Informe()
        MyBase.Informe()
        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                ImprimirInformeAlbaranSalidas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, chkDivisa.Checked)
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
        Dim pv As String = FiltroCheckedComboBox("Punto de venta", cbPuntoVenta)

        Dim RbFacturado As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim StrFacturado As String() = {"SI", "NO", "TODOS"}
        Dim Facturados As String = FiltroRadioButton("Facturados", RbFacturado, StrFacturado)

        Dim divisa As String = FiltroCheckBox("Moneda", chkDivisa, "Divisa", "Euros")

        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If pv <> "" Then LineasDescripcion.Add(pv)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If divisa <> "" Then LineasDescripcion.Add(divisa)


        MyBase.Imprimir()

    End Sub

End Class