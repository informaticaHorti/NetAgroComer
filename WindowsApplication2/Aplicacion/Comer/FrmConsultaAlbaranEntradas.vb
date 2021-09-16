
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaAlbaranEntradas
    Inherits FrConsulta

    Dim AlbEntradaLineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Centro As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
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

        ParamTx(TxDato1, Agricultores.AGR_IdAgricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_IdAgricultor, Lb2)
        ParamTx(TxDato3, AlbEntrada.AEN_Fecha, Lb3)
        ParamTx(TxDato4, AlbEntrada.AEN_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        CbFamilias = ComboFamilias(CbFamilias)
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
        consulta.SelCampo(AlbEntradaLineas.AEL_idlinea, "IdLinea")
        consulta.SelCampo(AlbEntrada.AEN_IdAlbaran, "IdAlbaran")
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntradaLineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PuntoVenta", AlbEntrada.AEN_IdPuntoVenta, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(AlbEntrada.AEN_IdAgricultor, "CodAgr")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntradaLineas.AEL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "Idfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntradaLineas.AEL_idenvase)
        consulta.SelCampo(AlbEntradaLineas.AEL_bultos, "Bultos")
        consulta.SelCampo(AlbEntradaLineas.AEL_kilosnetos, "Kilos")
        consulta.SelCampo(AlbEntradaLineas.AEL_muestreo, "Muestreo")


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxDato4.Text)

        Dim WHE As String = consulta.Whe


        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If
        Dim sql As String = consulta.Sel & WHE

        sql = sql & " order by Albaran,Fecha"

        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Albaran")) Then
            GridView1.Columns.ColumnByFieldName("Albaran").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If

        'OJO con las mayúsculas / minúsculas
        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n0}")

        AjustaColumnas()



    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "FECHA", "PUNTOVENTA", "CODAGR", "AGRICULTOR", "GENERO", "ENVASE", "BULTOS", "KILOS", "MUESTREO"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "PUNTOVENTA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA", "CODAGR"
                    c.MinWidth = 85
            End Select
        Next
    End Sub

    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
                Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)
                ImprimirInformeAlbaranEntradas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstPuntoVenta, lstFamilias)
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

        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)

        Dim PuntoVenta As String = ""
        Dim Familias As String = ""


        If TxDato1.Text.Trim <> "" Or TxDato2.Text.Trim <> "" Then
            LineasDescripcion.Add("Desde agricultor " & TxDato1.Text & " hasta agricultor " & TxDato2.Text)
        End If
        If TxDato3.Text.Trim <> "" Or TxDato4.Text.Trim <> "" Then
            LineasDescripcion.Add("Desde " & TxDato3.Text & " hasta " & TxDato4.Text)
        End If

        If lstPuntoVenta.Count > 0 Then
            For Each s As String In lstPuntoVenta
                If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
                PuntoVenta = PuntoVenta & s
            Next
            LineasDescripcion.Add("Punto de Venta: " & PuntoVenta)
        End If
        If lstFamilias.Count > 0 Then
            For Each s As String In lstFamilias
                If Familias.Trim <> "" Then Familias = Familias & ","
                Familias = Familias & s
            Next
            LineasDescripcion.Add("Familias: " & Familias)
        End If


        MyBase.Imprimir()

    End Sub
   

End Class