
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmMuestreoPartidas_OLD
    Inherits FrConsulta


    Private Agricultores As New E_Agricultores(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Private Produccion As New E_Produccion(Idusuario, cn)
    Private Lineas_Producto As New E_Lineas_producto(Idusuario, cn)


    Dim err As New Errores

    Private _IdLinea As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdLinea As String)
        Me.New()


        _IdLinea = IdLinea


    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDesdeFecha, AlbEntrada.AEN_Fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, AlbEntrada.AEN_Fecha, LbHastaFecha)
        ParamTx(TxDesdeAgricultor, Agricultores.AGR_IdAgricultor, LbDeAgr)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_IdAgricultor, LbHastaAgr)


        AsociarControles(TxDesdeAgricultor, BtBuscaDesdeAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_DesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaHastaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_HastaAgricultor)



        Dim sql As String = "SELECT GEN_IdGenero as Id, GEN_NombreGenero as Nombre FROM Generos"
        Dim dt As DataTable = cn.ConsultaSQL(sql)

        CbGeneros.Properties.DataSource = dt
        CbGeneros.Properties.ValueMember = "Id"
        CbGeneros.Properties.DisplayMember = "Nombre"

    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        BtAux.Text = "Clasificar"
        BtAux.Image = NetAgro.My.Resources.Resources.App_klines_game_16x16_32
        BtAux.Visible = True




        If VaInt(_IdLinea) > 0 Then

            Dim sql As String = "SELECT DISTINCT GEN_IdGenero as IdGenero FROM Lineas_Producto" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdSubFamilia = LNP_IdSubFamilia" & vbCrLf
            sql = sql & " WHERE LNP_IdLinea = " & _IdLinea & vbCrLf


            Dim dt As DataTable = Lineas_Producto.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                dt.PrimaryKey = New DataColumn() {dt.Columns("IdGenero")}

                For Each it As CheckedListBoxItem In CbGeneros.Properties.GetItems()

                    Dim IdGenero As String = it.Value.ToString & ""
                    Dim row As DataRow = dt.Rows.Find(VaInt(IdGenero))

                    If Not IsNothing(row) Then
                        it.CheckState = CheckState.Checked
                    End If

                Next

            End If

        End If


        _IdLinea = ""



        BConsultar.PerformClick()


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "IdAlbaran")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
        CONSULTA.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idgenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
        Dim oConsumidosPartida As New Cdatos.bdcampo("@(SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLineaEntrada = AEL_IdLinea)", Produccion.PRD_KilosConsumidos.TipoBd, Produccion.PRD_KilosConsumidos.Longitud, Produccion.PRD_KilosConsumidos.Decimales)
        CONSULTA.SelCampo(oConsumidosPartida, "KilosConsumidos")
        Dim oEstado As New Cdatos.bdcampo("@''", Cdatos.TiposCampo.Cadena, 25)
        CONSULTA.SelCampo(oEstado, "Estado")
        If TxDesdeFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDesdeFecha.Text)
        If TxHastaFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxHastaFecha.Text)
        If TxDesdeAgricultor.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxDesdeAgricultor.Text)
        If TxHastaAgricultor.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxHastaAgricultor.Text)


        Dim sql As String = CONSULTA.SQL & vbCrLf
        If CONSULTA.Whe.Trim = "" Then
            sql = sql & " WHERE COALESCE(AEL_FechaMuestreo, '" & VaDate("").ToString("dd/MM/yyyy") & "') = '" & VaDate("").ToString("dd/MM/yyyy") & "'" & vbCrLf
        Else
            sql = sql & " AND COALESCE(AEL_FechaMuestreo, '" & VaDate("").ToString("dd/MM/yyyy") & "') = '" & VaDate("").ToString("dd/MM/yyyy") & "'" & vbCrLf
        End If
        sql = sql & CadenaWhereLista(AlbEntrada_Lineas.AEL_idgenero, ListadeCombo(CbGeneros), " AND ") & vbCrLf
        sql = sql & " ORDER BY AEN_Fecha, AEL_IdLinea"


        'sql = "SELECT IdLinea, Partida, IdAlbaran, IdAgricultor, Agricultor, Fecha, IdGenero, Genero, Kilos, KilosConsumidosPartida as KilosConsumidos, Estado " & vbCrLf & _
        '    " FROM (" & vbCrLf & sql & vbCrLf & ") as X " & vbCrLf
        'sql = sql & " ORDER BY Fecha"


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        'For Each row As DataRow In dt.Rows
        '    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
        '    Dim Kilos As Decimal = VaDec(row("Kilos"))
        '    Dim KilosConsumidos As Decimal = VaDec(row("KilosConsumidos"))
        '    row("KilosConsumidos") = CalculaKilosConsumidos(IdLinea, Kilos, KilosConsumidos)
        'Next



        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("KilosConsumidos", "{0:n2}")


        AjustaColumnas()


    End Sub


    Private Function CalculaKilosConsumidos(IdLinea As String, KilosPartida As Decimal, KilosConsumidos As Decimal) As Decimal

        'Dim kg1 As Decimal = KilosConsumidos


        '1) Comprobamos si tiene precalibrados la partida y calculamos los pendientes de consumir de los precalibrados

        '2) En caso contrario, comprobamos si la partida tiene lote y si tiene precalibrados el lote y comprobamos los pendientes de consumir de los precalibrados

        '3) Si la partida tiene lote, pero el lote no tiene precalibrados, calculamos lo pendiente de consumir del lote

        '4) Si la partida no tiene lote, calculamos lo consumido de la producción de la partida


        'Dim lstPrecalibrados As New List(Of String)

        'Dim sqlL As String = "SELECT LTL_IdLote as IdLote FROM Lotes_Lineas WHERE LTL_IdLineaEntrada = " & IdLinea
        'Dim sqlC As String = "SELECT LPL_IdLote as IdLoteProduccion FROM LotesProduccion_Lineas WHERE LPL_IdLineaEntrada = " & IdLinea

        'Dim dtC As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sqlC)
        'If Not IsNothing(dtC) Then
        '    For Each row As DataRow In dtC.Rows
        '        Dim IdLoteProduccion As String = (row("IdLoteProduccion").ToString & "").Trim
        '        lstPrecalibrados.Add(IdLoteProduccion)
        '    Next
        'End If


        'If lstPrecalibrados.Count > 0 Then
        '    Return CalculaKilosConsumidosPrecalibrado(IdLinea)
        'Else

        '    Dim lstLotes As New List(Of String)

        '    Dim dtL As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sqlL)
        '    If Not IsNothing(dtL) Then
        '        For Each row As DataRow In dtC.Rows
        '            Dim IdLote As String = (row("IdLote").ToString & "").Trim
        '            lstLotes.Add(IdLote)
        '        Next
        '    End If




        'End If









        ''Está la partida en algún lote de entrada?
        'Dim TotalPorcentaje As Decimal = 0
        'Dim TotalLotes As Integer = 0


        'Dim sql As String = "SELECT LTE_IdLote as IdLote, " & vbCrLf
        'sql = sql & " (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) as Kilos," & vbCrLf
        'sql = sql & " (SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLote = LTE_IdLote) as Consumidos" & vbCrLf
        'sql = sql & " FROM Lotes_lineas LEFT JOIN Lotes ON LTE_IdLote = LTL_IdLote WHERE LTL_IdLineaEntrada = " & IdLinea & vbCrLf
        'sql = sql & " GROUP BY LTE_IdLote" & vbCrLf

        'Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        'If Not IsNothing(dt) Then
        '    For Each row As DataRow In dt.Rows

        '        Dim IdLote As Integer = VaInt(row("IdLote"))
        '        Dim Consumidos As Decimal = VaDec(row("Consumidos"))
        '        Dim Kilos As Decimal = VaDec(row("Kilos"))

        '        Dim porcentaje As Decimal = 0
        '        If Kilos <> 0 Then porcentaje = Consumidos / Kilos

        '        'TotalKg = TotalKg + Kilos
        '        TotalPorcentaje = TotalPorcentaje + porcentaje
        '        TotalLotes = TotalLotes + 1

        '    Next
        'End If

        'Dim ajuste1 As Decimal = 0
        'If TotalLotes <> 0 Then ajuste1 = TotalPorcentaje / TotalLotes

        ''kg1 = KilosPartida * ajuste1
        ''KilosConsumidos = KilosConsumidos + kg



        ''kg = 0
        'TotalLotes = 0
        'TotalPorcentaje = 0

        ''Está la partida en algún precalibrado?
        'sql = "SELECT LPD_IdLote as IdLote, " & vbCrLf
        'sql = sql & " (SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote) as Kilos," & vbCrLf
        'sql = sql & " (SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLoteProduccion = LPD_IdLote) as Consumidos" & vbCrLf
        'sql = sql & " FROM LotesProduccion_lineas LEFT JOIN LotesProduccion ON LPD_IdLote = LPL_IdLote WHERE LPL_IdLineaEntrada = " & IdLinea & vbCrLf
        'sql = sql & " GROUP BY LPD_IdLote" & vbCrLf

        'dt = AlbEntrada.MiConexion.ConsultaSQL(sql)
        'If Not IsNothing(dt) Then
        '    For Each row As DataRow In dt.Rows

        '        Dim IdLote As Integer = VaInt(row("IdLote"))
        '        Dim Consumidos As Decimal = VaDec(row("Consumidos"))
        '        Dim Kilos As Decimal = VaDec(row("Kilos"))

        '        Dim porcentaje As Decimal = 0
        '        If Kilos <> 0 Then porcentaje = Consumidos / Kilos

        '        'TotalKg = TotalKg + Kilos
        '        TotalPorcentaje = TotalPorcentaje + porcentaje
        '        TotalLotes = TotalLotes + 1

        '    Next
        'End If

        'Dim ajuste2 As Decimal = 0
        'If TotalLotes <> 0 Then ajuste2 = TotalPorcentaje / TotalLotes

        ''kg = KilosPartida * ajuste

        'Dim ajuste As Decimal = 0


        'Dim cont As Integer = 0
        'If ajuste1 <> 0 Then
        '    ajuste = ajuste + ajuste1
        '    cont = cont + 1
        'End If

        'If ajuste2 <> 0 Then
        '    ajuste = ajuste + ajuste2
        '    cont = cont + 1
        'End If

        'If cont <> 0 Then ajuste = ajuste / cont



        'Dim kg As Decimal = KilosPartida * ajuste
        'Return KilosConsumidos + kg


        Return 0

    End Function



    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PARTIDA", "FECHA", "IDAGRICULTOR", "AGRICULTOR", "IDGENERO", "GENERO", "KILOS", "KILOSCONSUMIDOS", "ESTADO"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "ESTADO"
                    c.Width = 100

                Case "KILOS",
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "KILOSCONSUMIDOS"
                    c.Caption = "Consumidos"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "FECHA"
                    c.MinWidth = 80

            End Select

        Next


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim Generos As String = ""

        Dim lstGeneros As List(Of String) = ListadeCombo(CbGeneros)
        For Each s As String In lstGeneros
            If Generos <> "" Then Generos = Generos & ","
            Generos = Generos & s
        Next


        'Agricultor, fecha
        If TxDesdeFecha.Text.Trim <> "" Or TxHastaFecha.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDesdeFecha.Text & " hasta " & TxHastaFecha.Text)
        If TxDesdeAgricultor.Text.Trim <> "" Or TxHastaAgricultor.Text.Trim <> "" Then LineasDescripcion.Add("Desde agricultor " & TxDesdeAgricultor.Text & " hasta agricultor " & TxHastaAgricultor.Text)
        If lstGeneros.Count > 0 Then LineasDescripcion.Add("Generos: " & Generos)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        MyBase.CustomColumnDisplayText(sender, e)

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.ToUpper.Trim = "ESTADO" Then

                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Consumido As Decimal = VaDec(row("KilosConsumidos"))


                If Consumido = 0 Then

                    'Sin confeccionar
                    e.DisplayText = "SIN CONFECCIONAR"

                ElseIf Kilos - Consumido <= 0 Then

                    'consumida
                    e.DisplayText = "CONSUMIDA"

                Else

                    'en curso
                    e.DisplayText = "MANIPULADA"

                End If


            End If

        End If

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            If column.FieldName.ToUpper.Trim = "ESTADO" Then

                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Consumido As Decimal = VaDec(row("KilosConsumidos"))


                If Consumido = 0 Then

                    'Sin confeccionar
                    e.Appearance.BackColor = Color.Red

                ElseIf Kilos - Consumido <= 0 Then

                    'consumida
                    e.Appearance.BackColor = Color.LightGreen

                Else

                    'en curso
                    e.Appearance.BackColor = Color.Yellow

                End If


            End If

        End If

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim row As DataRow = GridView1.GetFocusedDataRow()
        If Not IsNothing(row) Then

            Dim IdLinea As String = (row("IdLinea").ToString & "").Trim

            If VaInt(IdLinea) > 0 Then

                Dim frm As New FrmClasificacionPartidas(IdLinea)
                frm.ShowDialog()

                If frm.Resultado = ResultadoFormulario.Guardar Then
                    BConsultar.PerformClick()
                End If

            End If

        End If

    End Sub

    'Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
    '    MyBase.GridClik(row, column)

    '    If Not IsNothing(row) Then

    '        Dim IdLinea As String = (row("IdLinea").ToString & "").Trim

    '        If VaInt(IdLinea) > 0 Then

    '            Dim frm As New FrmClasificacionPartidas(IdLinea)
    '            frm.ShowDialog()

    '            If frm.Resultado = ResultadoFormulario.Guardar Then
    '                BConsultar.PerformClick()
    '            End If

    '        End If

    '    End If

    'End Sub


End Class