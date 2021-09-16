
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class FrmResumenPaletsGastosConfeccion
    Inherits FrConsulta


    Private Class AcumulaPalets
        Inherits Acumulador

        Public Sub SumaPalets(stClave As Object, stDatos As Object, IdPalet As Integer)
            MyBase.Suma(stClave, stDatos)

            Dim clave As stClave_ResumenPaletsGastos = ObtenerClave(stClave)

            If Not clave.DcPalets.ContainsKey(IdPalet) Then
                Dc(clave).Palets = Dc(clave).Palets + 1
            End If

        End Sub

    End Class


    Private Class stClave_ResumenPaletsGastos

        Public DcPalets As New Dictionary(Of Integer, Integer)

        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdPresentacion As Integer = 0
        Public Presentacion As String = ""
        Public IdTipoPalet As Integer = 0
        Public TipoPalet As String = ""


        Public Sub New(IdGenero As Integer, Genero As String, IdPresentacion As Integer, Presentacion As String,
                       IdTipoPalet As Integer, TipoPalet As String)

            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdPresentacion = IdPresentacion
            Me.Presentacion = Presentacion
            Me.IdTipoPalet = IdTipoPalet
            Me.TipoPalet = TipoPalet

        End Sub

    End Class


    Private Class stDatos_ResumenPaletsGastos

        Public Palets As Decimal = 0
        Public Bultos As Decimal = 0
        Public Kilos As Decimal = 0
        Public GtoEst As Decimal = 0
        Public GtoEstxKilo As Decimal = 0
        Public GtoMat As Decimal = 0
        Public GtoMatxKilo As Decimal = 0
        Public GtoConf As Decimal = 0
        Public GtoConfxKilo As Decimal = 0
        Public TotalGtos As Decimal = 0
        Public TotalGtosxKilo As Decimal = 0

        Public Sub New(Palets As Decimal, Bultos As Decimal, Kilos As Decimal, GtoEst As Decimal, GtoMat As Decimal,
                       GtoConf As Decimal, TotalGtos As Decimal)

            Me.Palets = Palets
            Me.Bultos = Bultos
            Me.Kilos = Kilos
            Me.GtoEst = GtoEst
            Me.GtoMat = GtoMat
            Me.GtoConf = GtoConf
            Me.TotalGtos = TotalGtos

        End Sub

    End Class


    Private CosteManipulado As New E_CosteManipulado(Idusuario, cn)
    Private AlbSalida As New E_AlbSalida(Idusuario, cn)
    Private AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Private AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Private Palets As New E_palets(Idusuario, cn)
    Private Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Private GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private ConfecPalet As New E_ConfecPalet(Idusuario, cn)



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
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgensal, "IdPresentacion")
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        CONSULTA.SelCampo(Generos.GEN_IdGenero, "IdGenero", GenerosSalida.GES_IdGenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero")
        CONSULTA.SelCampo(Palets.PAL_idpalet, "IdPalet", Palets_Lineas.PLL_idpalet, Palets.PAL_idpalet)
        CONSULTA.SelCampo(Palets.PAL_idtipopalet, "IdTipoPalet")
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", Palets.PAL_idtipopalet, ConfecPalet.CPA_Idconfec)
        CONSULTA.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        CONSULTA.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(Palets_Lineas.PLL_costeestructura, "GtoEst")
        CONSULTA.SelCampo(Palets_Lineas.PLL_costematerial, "GtoMat")
        CONSULTA.SelCampo(Palets_Lineas.PLL_costeconfeccion, "GtoConf")
        CONSULTA.SelCampo(Palets.PAL_fecha, "FechaPalet")
        CONSULTA.SelCampo(Palets.PAL_idcentro, "IdCentro")
        CONSULTA.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Palets.ASP_IdAlbaran, AlbSalida.ASA_idalbaran)
        

        'Filtros
        If TxDato1.Text <> "" Then
            If RbFechaAlbSalida.Checked Then
                CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato1.Text)
            ElseIf RbFechaPalet.Checked Then
                CONSULTA.WheCampo(Palets.PAL_fecha, ">=", TxDato1.Text)
            End If
        End If
        If TxDato2.Text <> "" Then
            If RbFechaAlbSalida.Checked Then
                CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato2.Text)
            ElseIf RbFechaPalet.Checked Then
                CONSULTA.WheCampo(Palets.PAL_fecha, "<=", TxDato2.Text)
            End If
        End If
        CONSULTA.WheCampo(Palets.PAL_idcentro, "=", MiMaletin.IdCentro.ToString)


        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY IdGenero, IdPresentacion, IdTipoPalet"
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        Dim acum As New AcumulaPalets

        For Each row As DataRow In dt.Rows

            Dim IdPalet As Integer = VaInt(row("IdPalet"))
            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim IdTipoPalet As Integer = VaInt(row("IdTipoPalet"))
            Dim TipoPalet As String = (row("TipoPalet").ToString & "").Trim
            If RbResumido.Checked Then
                IdTipoPalet = 0
                TipoPalet = ""
            End If
            Dim FechaPalet As String = ""
            If VaDate(row("FechaPalet")) > VaDate("") Then FechaPalet = VaDate(row("FechaPalet")).ToString("dd/MM/yyyy")
            Dim IdCentro As String = (row("IdCentro").ToString & "").Trim

            Dim Bultos As Decimal = VaDec(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))

            Dim GtoEst As Decimal = VaDec(row("GtoEst"))
            Dim GtoMat As Decimal = VaDec(row("GtoMat"))
            Dim GtoConf As Decimal = VaDec(row("GtoConf"))
            Dim TotalGto As Decimal = GtoEst + GtoMat + GtoConf


            Dim Palets As Integer = 0

            Dim stClave As New stClave_ResumenPaletsGastos(IdGenero, Genero, IdPresentacion, Presentacion, IdTipoPalet, TipoPalet)
            Dim stDatos As New stDatos_ResumenPaletsGastos(Palets, Bultos, Kilos, GtoEst, GtoMat, GtoConf, TotalGto)
            acum.SumaPalets(stClave, stDatos, IdPalet)

        Next



        dt = acum.DataTable


        If Not IsNothing(dt) Then
            If dt.Columns.Contains("Palets") Then dt.Columns("Palets").SetOrdinal(6)
            If dt.Columns.Contains("Linea") Then dt.Columns("Linea").SetOrdinal(20)
            If dt.Columns.Contains("Tarea") Then dt.Columns("Tarea").SetOrdinal(20)
        End If


        'Calculo los gastos por kilo
        For Each row As DataRow In dt.Rows

            Dim Kilos As Decimal = VaDec(row("Kilos"))

            Dim GtoEstxKilo As Decimal = 0
            Dim GtoMatxKilo As Decimal = 0
            Dim GtoConfxKilo As Decimal = 0
            Dim TotalGtoxKilo As Decimal = 0
            Dim CosteManxKilo As Decimal = 0

            Dim GtoEst As Decimal = VaDec(row("GtoEst"))
            Dim GtoMat As Decimal = VaDec(row("GtoMat"))
            Dim GtoConf As Decimal = VaDec(row("GtoConf"))
            Dim TotalGto As Decimal = VaDec(row("TotalGtos"))

            If Kilos <> 0 Then
                GtoEstxKilo = GtoEst / Kilos
                GtoMatxKilo = GtoMat / Kilos
                GtoConfxKilo = GtoConf / Kilos
                TotalGtoxKilo = TotalGto / Kilos
            End If

            row("GtoEstxKilo") = GtoEstxKilo
            row("GtoMatxKilo") = GtoMatxKilo
            row("GtoConfxKilo") = GtoConfxKilo
            row("TotalGtosxKilo") = TotalGtoxKilo


        Next


        GridView1.Columns.Clear()
        Grid.DataSource = dt
        AjustaColumnas()


        AñadeResumenCampo("Palets", "{0:n0}")
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("GtoEst", "{0:n2}")
        AñadeResumenCampo("GtoMat", "{0:n2}")
        AñadeResumenCampo("GtoConf", "{0:n2}")
        AñadeResumenCampo("TotalGtos", "{0:n2}")

        Funciones.AñadeResumenCampo(GridView1, "GtoEstxKilo", "{0:n5}", DevExpress.Data.SummaryItemType.Custom)
        Funciones.AñadeResumenCampo(GridView1, "GtoMatxKilo", "{0:n5}", DevExpress.Data.SummaryItemType.Custom)
        Funciones.AñadeResumenCampo(GridView1, "GtoConfxKilo", "{0:n5}", DevExpress.Data.SummaryItemType.Custom)
        Funciones.AñadeResumenCampo(GridView1, "TotalGtosxKilo", "{0:n5}", DevExpress.Data.SummaryItemType.Custom)


    End Sub





    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPRESENTACION", "IDTIPOPALET", "ALBARAN", "IDGENERO", "GENERO"
                    c.Visible = False
                Case "TIPOPALET"
                    If RbResumido.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If

            End Select
        Next


        GridView1.BestFitColumns()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "GTOEST", "GTOMAT", "GTOCONF", "TOTALGTOS"
                        c.Width = 80
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"
                    Case "KILOS"
                        c.Width = 80
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                    Case "PALETS", "BULTOS"
                        c.Width = 65
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                    Case "GTOESTXKILO", "GTOMATXKILO", "GTOCONFXKILO", "TOTALGTOSXKILO"
                        c.Caption = "GtoxK"
                        c.Width = 80
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00000"
         


                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub



    Private Sub FrmDiferenciaProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub



    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim TipoListado As String = ""
                Dim FiltroFechas As String = ""
                If TxDato1.Text.Trim <> "" And TxDato2.Text <> "" Then
                    If RbFechaAlbSalida.Checked Then
                        FiltroFechas = "Filtrado por Fecha Albarán Salida"
                    ElseIf RbFechaPalet.Checked Then
                        FiltroFechas = "Filtrado por Fecha de Palet"
                    End If
                End If

                If RbDetallado.Checked Then
                    ImprimirResumenPaletsGastosConfeccion(dt, TxDato1.Text, TxDato2.Text, "Tipo Listado: Detallado por Presentacion", FiltroFechas, True)
                ElseIf RbResumido.Checked Then
                    ImprimirResumenPaletsGastosConfeccion(dt, TxDato1.Text, TxDato2.Text, "Tipo Listado: Resumido", FiltroFechas, False)
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

        Dim RbTipoListado As RadioButton() = {RbDetallado, RbResumido}
        Dim StrTipoListado As String() = {"Detallado", "Resumido"}
        Dim tipolistado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)

        Dim RbFiltroFechas As RadioButton() = {RbFechaAlbSalida, RbFechaPalet}
        Dim StrFiltroFechas As String() = {"Por fecha de Albarán de Salida", "Por Fecha de Palet"}
        Dim filtrofechas As String = FiltroRadioButton("Filtrado por fecha: ", RbFiltroFechas, StrFiltroFechas)


        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If tipolistado <> "" Then LineasDescripcion.Add(tipolistado)
        If fechas <> "" And filtrofechas <> "" Then LineasDescripcion.Add(filtrofechas)



        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs)


        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then

                Dim gto As Decimal = 0
                Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                Dim pm As Decimal = 0


                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                Select Case item.FieldName.ToUpper.Trim
                    Case "GTOESTXKILO"
                        gto = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                    Case "GTOMATXKILO"
                        gto = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                    Case "GTOCONFXKILO"
                        gto = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                    Case "TOTALGTOSXKILO"
                        gto = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                End Select

                If Kilos <> 0 Then pm = gto / Kilos
                e.TotalValue = pm

            End If


            If e.IsTotalSummary Then

                Dim pm As Decimal = 0
                Dim kilos As Decimal = 0
                Dim gto As Decimal = 0

                Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Kilos")
                If Not IsNothing(colKilos) Then

                    kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    Select Case item.FieldName.ToUpper.Trim
                        Case "GTOESTXKILO"
                            Dim colGto As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("GtoEst")
                            If Not IsNothing(colGto) Then gto = VaDec(colGto.SummaryItem.SummaryValue)
                        Case "GTOMATXKILO"
                            Dim colGto As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("GtoMat")
                            If Not IsNothing(colGto) Then gto = VaDec(colGto.SummaryItem.SummaryValue)
                        Case "GTOCONFXKILO"
                            Dim colGto As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("GtoConf")
                            If Not IsNothing(colGto) Then gto = VaDec(colGto.SummaryItem.SummaryValue)
                        Case "TOTALGTOSXKILO"
                            Dim colGto As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("TotalGtos")
                            If Not IsNothing(colGto) Then gto = VaDec(colGto.SummaryItem.SummaryValue)
                    End Select

                End If

                If kilos <> 0 Then pm = gto / kilos
                e.TotalValue = pm

            End If

        End If


    End Sub


End Class
