
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmClasificacionesProveedor
    Inherits FrConsulta


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim TiposDeCategoria As New E_TiposdeCategoria(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)



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

        ParamTx(TxSemana, SemanasPartes.SEV_Semana, LbSemana)
        ParamTx(TxAgricultorDesde, Agricultores.AGR_idagricultor, LbDesdeAgricultor)
        ParamTx(TxAgricultorHasta, Agricultores.AGR_IdAgricultor, LbHastaAgricultor)
        ParamTx(TxFechaDesde, AlbEntrada.AEN_Fecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbEntrada.AEN_Fecha, LbHastaFecha, True)
        ParamTx(TxGeneroDesde, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxGeneroHasta, Generos.GEN_IdGenero, LbHastaGenero)
        ParamChk(ChkMostrarObservaciones, Nothing, "S", "N")
        ParamChk(ChkHojaPorCliente, Nothing, "S", "N")
        ParamChk(ChkGenerarPDF, Nothing, "S", "N")


        AsociarControles(TxAgricultorDesde, BtBuscaAgricultorDesde, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxAgricultorHasta, BtBuscaAgricultorHasta, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorHasta)
        AsociarControles(TxGeneroDesde, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxGeneroHasta, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)


    End Sub


    Private Sub FrmClasificacionesProveedores_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BImprimir.Visible = False

        BtAux.Text = "I.Directa"
        BtAux.Image = My.Resources.Action_file_quick_print_16x16_32
        BtAux.Visible = True


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)
        CbCentrosRecogida = ComboCentrosRecogida(CbCentrosRecogida)
        CbPventa = ComboPuntoventa(CbPventa, MiMaletin.IdPuntoVenta)

        CbCentrosRecogida.CheckAll()

        TxRutaPDF.Text = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
        If TxRutaPDF.Text.Trim <> "" Then TxRutaPDF.Text = TxRutaPDF.Text & "\"


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        ChkMostrarObservaciones.Checked = True

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridView1.Columns.Clear()


        Dim sqlWhere As String = ""
        AñadeCondicion(sqlWhere, CadenaWhereLista(Agricultores.AGR_idempresa, ListadeCombo(CbEmpresas)))
        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(CbPventa)))

        If TxAgricultorDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor >= " & TxAgricultorDesde.Text)
        If TxAgricultorHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor <= " & TxAgricultorHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha <= '" & TxFechaHasta.Text & "'")
        If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEL_IdGenero >= " & TxGeneroDesde.Text)
        If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEL_IdGenero <= " & TxGeneroHasta.Text)

        If RbFirme.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'F'")
        ElseIf RbComision.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'C'")
        ElseIf rbSClasif.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'S'")
        End If

        If RbSIValorados.Checked Then
            AñadeCondicion(sqlWhere, "AEL_FechaValoracion > '" & VaDate("") & "'")
        ElseIf rbNOValorados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(AEL_FechaValoracion,'" & VaDate("") & "') = '" & VaDate("") & "'")
        End If


        Dim lstRecogida As List(Of String) = ListadeCombo(CbCentrosRecogida)
        If lstRecogida.Count > 0 Then AñadeCondicion(sqlWhere, CadenaWhereLista(Agricultores.AGR_idcrecogida, lstRecogida, ""))

        
        Dim sql As String = Agro_ConsultaClasificacionesProveedor(ChkDetallarPrecios.Checked, sqlWhere)


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt



        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")


        AjustaColumnas()



    End Sub



    Private Sub AñadeCondicion(ByRef sqlWhere As String, condicion As String)

        If condicion.Trim <> "" Then

            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & condicion & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND " & condicion & vbCrLf
            End If

        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDALBARAN", "IDTIPOCATEGORIA", "CAMPA", "OBSERVACIONESPROVEEDOR", "CLASIF"
                    c.Visible = False

                Case "OBSERVACIONES"
                    If Not ChkMostrarObservaciones.Checked Then
                        c.Visible = False
                    End If

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
                    'c.GroupIndex = 0

                Case "ALBARAN"
                    'c.GroupIndex = 1

                Case "IDCATEGORIA"
                    c.Caption = "IdCat"
                    c.MinWidth = 45
                    c.MaxWidth = 45

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 60

                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000"

                Case "KILOS", "KILOSENT"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 70

                Case "FECHA"
                    c.MinWidth = 80

                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"

                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100

            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim TipoImpresion As TipoImpresion = TipoImpresion.Preliminar
        Dim Impresora As String = ""
        
        Impresion(TipoImpresion, Impresora)

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraPorDefecto
        Dim Impresora As String = ""

        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        If ValoresUsuario.LeerId(Idusuario.ToString) Then
            Impresora = ValoresUsuario.VUS_ImpresoraClasificacionesProveedor.Valor
        End If

        If Impresora.Trim <> "" Then
            TipoImpresion = NetAgro.TipoImpresion.ImpresoraSeleccionada
        End If

        Impresion(TipoImpresion, Impresora)

    End Sub


    Private Sub Impresion(TipoImpresion As TipoImpresion, Impresora As String)

        Dim bDatos As Boolean = True


        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then


                Dim lstEmpresas As List(Of String) = ListadeCombo(CbEmpresas)
                Dim lstRecogida As List(Of String) = ListadeCombo(CbCentrosRecogida)

                Dim TipoEntrada As String = ""
                If RbFirme.Checked Then
                    TipoEntrada = "F"
                ElseIf RbComision.Checked Then
                    TipoEntrada = "C"
                ElseIf rbSClasif.Checked Then
                    TipoEntrada = "S"
                Else
                    TipoEntrada = "T"
                End If

                Dim Valorados As String = ""
                If RbSIValorados.Checked Then
                    Valorados = "SI"
                ElseIf rbNOValorados.Checked Then
                    Valorados = "NO"
                Else
                    Valorados = "TODOS"
                End If


                Dim año As String = ""
                Dim campa As String = ""

                Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
                If SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text)) Then
                    campa = VaInt(SemanasPartes.SEV_Ejercicio.Valor).ToString("00")
                    año = (SemanasPartes.SEV_Ano.Valor & "").Trim
                End If



                If Not ChkDetallarPrecios.Checked Then
                    Dim NumPDF As Integer = 0
                    C1_ListadoClasificacionesProveedor(dt, TxSemana.Text, campa, año, TxAgricultorDesde.Text, TxAgricultorHasta.Text, TxFechaDesde.Text, TxFechaHasta.Text,
                                                                    TxGeneroDesde.Text, TxGeneroHasta.Text, lstEmpresas, ChkMostrarObservaciones.Checked,
                                                                    TipoEntrada, Valorados, lstRecogida, ChkGenerarPDF.Checked, ChkHojaPorCliente.Checked, False, TipoImpresion, Impresora, TxRutaPDF.Text, ,
                                                                    NumPDF)

                    If ChkGenerarPDF.Checked And ChkHojaPorCliente.Checked Then
                        MsgBox("Se han generado " & NumPDF.ToString & " ficheros")
                    End If


                Else
                    C1_ListadoClasificacionesProveedorDesglosado(dt, TxSemana.Text, campa, año, TxAgricultorDesde.Text, TxAgricultorHasta.Text, TxFechaDesde.Text, TxFechaHasta.Text,
                                                                    TxGeneroDesde.Text, TxGeneroHasta.Text, lstEmpresas, ChkMostrarObservaciones.Checked,
                                                                    TipoEntrada, Valorados, lstRecogida, ChkGenerarPDF.Checked, ChkHojaPorCliente.Checked, TipoImpresion, Impresora, TxRutaPDF.Text)
                End If



            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MsgBox("No hay datos que imprimir")
        End If

    End Sub



    Private Sub TxSemana_Valida(edicion As System.Boolean) Handles TxSemana.Valida
        If edicion Then

            Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
            Dim IdSemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text))
            If IdSemana > 0 Then

                Dim FechaIni As String = SemanasPartes.SEV_FechaInicialEntrada.Valor
                Dim FechaFin As String = SemanasPartes.SEV_FechaFinalEntrada.Valor

                If VaDate(FechaIni) > VaDate("") Then TxFechaDesde.Text = VaDate(FechaIni).ToString("dd/MM/yyyy")
                If VaDate(FechaFin) > VaDate("") Then TxFechaHasta.Text = VaDate(FechaFin).ToString("dd/MM/yyyy")

            ElseIf TxSemana.Text.Trim = "" Then

                TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
                TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

            End If

        End If
    End Sub


    Private Sub btRuta_Click(sender As System.Object, e As System.EventArgs) Handles btRuta.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TxRutaPDF.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub


    Public Overrides Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.GridView1_RowCellStyle(sender, e)

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            Dim Clasificado As String = (row("Clasif").ToString & "").Trim
            If Clasificado = "N" Then
                e.Appearance.BackColor = Color.Red
            End If

        End If

    End Sub

End Class