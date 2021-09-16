
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaAlbEntHis

    Inherits FrConsulta

    Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Centro As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim Centrosrecogida As New E_centrosrecogida(Idusuario, cn)


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
        ParamTx(TxDato3, Albentrada.AEN_Fecha, Lb3)
        ParamTx(TxDato4, Albentrada.AEN_Fecha, Lb4)

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
        consulta.SelCampo(Albentrada_hislineas.AHL_idalbaran, "IdAlbaran")
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha", Albentrada_hislineas.AHL_idalbaran)

        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran")

        consulta.SelCampo(Centrosrecogida.CER_Nombre, "CentroRecogida", Albentrada.AEN_IdRecogida)
        consulta.SelCampo(AlbEntrada_his.AEH_idproveedor, "CodAgr", Albentrada_hislineas.AHL_idalbhis)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada_his.AEH_idproveedor)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_hislineas.AHL_idgenero)
        consulta.SelCampo(Subfamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", Albentrada_hislineas.AHL_idenvase)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_hislineas.AHL_idcategoria)
        consulta.SelCampo(Albentrada_hislineas.AHL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_hislineas.AHL_kilos, "Kilos")
        consulta.SelCampo(Albentrada_hislineas.AHL_precio, "Precio")
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "FC", AlbEntrada_his.AEH_idalbaran)
        consulta.SelCampo(Albentrada_hislineas.AHL_idlineaentrada, "idlineaentrada")
        consulta.SelCampo(Albentrada_lineas.AEL_fechamuestreo, "Muestreo", Albentrada_hislineas.AHL_idlineaentrada)
        Dim Importe As New Cdatos.bdcampo("@AHL_KILOS*AHL_PRECIO", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(Importe, "Importe")


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Agricultores.AGR_IdAgricultor, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato4.Text)
        If RbComision.Checked = True Then consulta.WheCampo(Albentrada.AEN_TipoFCS, "=", "C")
        If RbFirme.Checked = True Then consulta.WheCampo(Albentrada.AEN_TipoFCS, "=", "F")
        '        If RbFacturadosSi.Checked = True Then consulta.WheCampo(AlbEntrada_his.AEH_idfactura, ">", "0")
        '        If RbFacturadosNo.Checked = True Then consulta.WheCampo(AlbEntrada_his.AEH_idfactura, "=", "0")
        If RbValorSi.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_precio, "<>", "0")
        If RbValorno.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_precio, "=", "0")
        If RbMuestreoSi.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_fechamuestreo, "<>", "01/01/1900")
        If RbMuestreoNo.Checked = True Then consulta.WheCampo(Albentrada_lineas.AEL_fechamuestreo, "=", "01/01/1900")
        If RbConfecSi.Checked = True Then consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "=", "S")
        If RbConfecNo.Checked = True Then consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "<>", "S")

        Dim WHE As String = consulta.Whe


        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Albentrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If

        If RbFacturadosSi.Checked = True Then
            WHE = WHE + " AND (ALBENTRADA_HIS.AEH_IDFACTURA > 0 ) "
        End If
        If RbFacturadosNo.Checked = True Then
            WHE = WHE + " AND (ALBENTRADA_HIS.AEH_IDFACTURA = 0 ) "
        End If

        consulta.WheCampo(AlbEntrada_his.AEH_idfactura, ">", "0")
        If RbFacturadosNo.Checked = True Then consulta.WheCampo(AlbEntrada_his.AEH_idfactura, "=", "0")

        Dim sql As String = consulta.Sel & WHE

        sql = sql & " order by Albaran,Fecha"

        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbEntrada_his.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Albaran")) Then
            GridView1.Columns.ColumnByFieldName("Albaran").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If


        'OJO con las mayúsculas / minúsculas


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")

        AjustaColumnas()



    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "FECHA", "CENTRORECOGIDA", "AGRICULTOR", "GENERO", "ENVASE", "BULTOS", "KILOS", "PRECIO", "CATEGORIA", "IMPORTE", "MUESTREO", "CODAGR"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS", "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "PRECIO", "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100
                Case "CENTRORECOGIDA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA", "MUESTREO"
                    c.MinWidth = 85
                Case "CODAGR"
                    c.Width = 55
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

                Dim Confeccionadas As String = ""
                Dim FirmeComision As String = ""
                Dim Facturados As String = ""
                Dim Valorados As String = ""
                Dim LineasMuestreadas As String = ""


                If RbConfecSi.Checked Then
                    Confeccionadas = "SI"
                ElseIf RbConfecNo.Checked Then
                    Confeccionadas = "NO"
                ElseIf RbConfecTodas.Checked Then
                    Confeccionadas = "Todos"
                End If

                If RbFirme.Checked Then
                    FirmeComision = "Firme"
                ElseIf RbComision.Checked Then
                    FirmeComision = "Comision"
                ElseIf RbFctodos.Checked Then
                    FirmeComision = "Todos"
                End If

                If RbFacturadosSi.Checked Then
                    Facturados = "SI"
                ElseIf RbFacturadosNo.Checked Then
                    Facturados = "NO"
                ElseIf RbFacturadosTodos.Checked Then
                    Facturados = "Todos"
                End If

                If RbValorSi.Checked Then
                    Valorados = "SI"
                ElseIf RbValorno.Checked Then
                    Valorados = "NO"
                ElseIf RbValorTodos.Checked Then
                    Valorados = "Todos"
                End If

                If RbMuestreoSi.Checked Then
                    LineasMuestreadas = "SI"
                ElseIf RbMuestreoNo.Checked Then
                    LineasMuestreadas = "NO"
                ElseIf RbMuestreoTodos.Checked Then
                    LineasMuestreadas = "Todos"
                End If


                ImprimirConsultaEntradasHistorico(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, Confeccionadas,
                                                  FirmeComision, Facturados, Valorados, LineasMuestreadas,
                                                  lstPuntoVenta, lstFamilias)

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