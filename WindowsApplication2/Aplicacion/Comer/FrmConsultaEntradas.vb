
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaEntradas
    Inherits FrConsulta


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)





    Dim err As New Errores


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Agricultores.AGR_idagricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_IdAgricultor, Lb2)
        ParamTx(TxDato5, AlbEntrada.AEN_Fecha, Lb5)
        ParamTx(TxDato6, AlbEntrada.AEN_Fecha, Lb6)

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


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato5.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato6.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String
        Dim WHE As String

        GridView1.Columns.Clear()

        If chkDetallarClasificacion.Checked Then
            Consulta.SelCampo(AlbEntrada_LineasCla.ALC_id, "IdLineaCla")
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLinea", AlbEntrada_LineasCla.ALC_idlineaentrada, AlbEntrada_Lineas.AEL_idlinea)
            Consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
            Consulta.SelCampo(PuntoVenta.Nombre, "PVenta", AlbEntrada.AEN_IdPuntoVenta)
            Consulta.SelCampo(AlbEntrada.AEN_IdAgricultor, "Codigo")
            Consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
            Consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
            Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero)
            Consulta.SelCampo(SubFamilias.SFA_idfamilia, "Idfamilia", Generos.GEN_IdsubFamilia)
            Consulta.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_Lineas.AEL_idenvase)
            '  Consulta.SelCampo(AlbEntrada_Lineas.AEL_bultos, "Bultos")
            Consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_LineasCla.ALC_idcategoria)
            Consulta.SelCampo(AlbEntrada_LineasCla.ALC_kilosnetos, "Kilos")
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
        Else
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLinea")
            Consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
            Consulta.SelCampo(PuntoVenta.Nombre, "PVenta", AlbEntrada.AEN_IdPuntoVenta)
            Consulta.SelCampo(AlbEntrada.AEN_IdAgricultor, "Codigo")
            Consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)

            Consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
            Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero)
            Consulta.SelCampo(SubFamilias.SFA_idfamilia, "Idfamilia", Generos.GEN_IdsubFamilia)
            Consulta.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_Lineas.AEL_idenvase)
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_bultos, "Bultos")
            Consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_Lineas.AEL_idcategoria)
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
            Consulta.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")

        End If




        If TxDato1.Text.Trim <> "" Then Consulta.WheCampo(Agricultores.AGR_IdAgricultor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then Consulta.WheCampo(Agricultores.AGR_IdAgricultor, "<=", TxDato2.Text)
        If TxDato5.Text.Trim <> "" Then Consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDato5.Text)
        If TxDato6.Text.Trim <> "" Then Consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxDato6.Text)
        If RbFirme.Checked Then Consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "=", "F")
        If RbComision.Checked Then Consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "=", "C")
        If RbSiMuestreo.Checked Then Consulta.WheCampo(AlbEntrada_Lineas.AEL_fechamuestreo, "<>", "01/01/1900")
        If RbNoMuestreo.Checked Then Consulta.WheCampo(AlbEntrada_Lineas.AEL_fechamuestreo, "=", "01/01/1900")


        WHE = Consulta.Whe
        If WHE = "" Then
            WHE = CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ")
        End If


        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If


        'sql = Consulta.Sel(ChkTodos.Checked) + WHE + " order by fecha"
        sql = Consulta.Sel(_IncluirTodosLosCampos) + WHE + " order by fecha"




        DT = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = DT


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n2}")


        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ALBARAN", "PVENTA", "CODIGO", "NOMBRE", "FECHA", "GENERO", "ENVASE", "BULTOS", "CATEGORIA", "KILOS", "PARTIDA", "PROGRAMA", "FINCA", "NAVE"
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
                    c.Width = 60
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "FECHA"
                    c.MinWidth = 80
                Case "ENVASE", "GENERO", "FINCA"
                    c.Width = 75
                Case "CATEGORIA", "PARTIDA", "NAVE"
                    c.Width = 30

            End Select
        Next


        'Merge
        GridView1.OptionsView.AllowCellMerge = True

        If Not IsNothing(Grid.DataSource) Then
            With GridView1.Columns
                Dim c As DevExpress.XtraGrid.Columns.GridColumn = .ColumnByFieldName("Kilos")
                If Not IsNothing(c) Then c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            End With
        End If

    End Sub


    Public Overrides Sub CellMerge(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs)

        ''Sólo fusionar si las anteriores a la izquierda y arriba están fusionadas
        'If e.Column.VisibleIndex > 0 And e.RowHandle2 > 0 Then

        '    Try
        '        Dim columna1 As DevExpress.XtraGrid.Columns.GridColumn = GridView1.VisibleColumns(e.Column.VisibleIndex - 1)
        '        If Not IsMergedCell(e.RowHandle2 - 1, columna1) Then
        '            e.Merge = False
        '            e.Handled = True
        '        Else
        '            MyBase.CellMerge(sender, e)
        '        End If
        '    Catch ex As Exception
        '        err.Muestraerror(ex.Message, "CellMerge", ex.Message)
        '    End Try


        'End If

        Dim bFusionar As Boolean = True

        For ind_col As Integer = 0 To e.Column.VisibleIndex - 1

            Dim row1 As DataRow = GridView1.GetDataRow(e.RowHandle2 - 1)
            Dim row2 As DataRow = GridView1.GetDataRow(e.RowHandle2)

            If IsNothing(row1) Or IsNothing(row2) Then
                bFusionar = False
                Exit For
            End If


            If row2("Albaran").ToString = "119" Then
                Dim a As String = ""
            End If

            Dim NombreColumna As String = GridView1.VisibleColumns(ind_col).FieldName

            If row1(NombreColumna).ToString <> row2(NombreColumna).ToString Then
                bFusionar = False
                Exit For
            End If

        Next


        If Not bFusionar Then
            e.Merge = False
            e.Handled = True
        End If

    End Sub


    Private Function IsMergedCell(ByVal rowHandle As Integer, columna As DevExpress.XtraGrid.Columns.GridColumn) As Boolean

        Dim viewInfo As GridViewInfo = TryCast(GridView1.GetViewInfo(), GridViewInfo)
        Dim cellInfo As GridCellInfo = viewInfo.GetGridCellInfo(rowHandle, columna)
        If cellInfo IsNot Nothing Then
            Return cellInfo.IsMerged
        End If
        Return False

    End Function


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim PuntoVenta As String = ""
        Dim Familias As String = ""

        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)

        For Each s As String In lstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next
        For Each s As String In lstFamilias
            If Familias <> "" Then Familias = Familias & ","
            Familias = Familias & s
        Next


        Dim TipoAlbaran As String = ""
        If RbFirme.Checked Then
            TipoAlbaran = "Tipo albaran: FIRME"
        ElseIf RbComision.Checked Then
            TipoAlbaran = "Tipo albaran: COMISION"
        ElseIf RbTodosFC.Checked Then
            TipoAlbaran = "Tipo albaran: FIRME Y COMISION"
        End If

        Dim Muestreados As String = "Muestreados: "
        If RbSiMuestreo.Checked Then
            Muestreados = Muestreados & "SI"
        ElseIf RbNoMuestreo.Checked Then
            Muestreados = Muestreados & "NO"
        ElseIf RbTodosMuestreo.Checked Then
            Muestreados = Muestreados & "TODOS"
        End If


        'Agricultor, fecha
        If TxDato1.Text.Trim <> "" Or TxDato2.Text.Trim <> "" Then LineasDescripcion.Add("Desde agricultor " & TxDato1.Text & " hasta agricultor " & TxDato2.Text)
        If TxDato5.Text.Trim <> "" Or TxDato6.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDato5.Text & " hasta " & TxDato6.Text)
        If lstPuntoVenta.Count > 0 Then LineasDescripcion.Add("Punto de venta: " & PuntoVenta)
        If lstFamilias.Count > 0 Then LineasDescripcion.Add("Familias: " & Familias)
        LineasDescripcion.Add(TipoAlbaran)
        LineasDescripcion.Add(Muestreados)
        If chkDetallarClasificacion.Checked Then LineasDescripcion.Add("Detallar clasificacion")




        MyBase.Imprimir()
    End Sub

    
End Class