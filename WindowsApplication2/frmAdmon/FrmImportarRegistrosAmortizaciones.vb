Imports DevExpress.XtraEditors
Imports System.Data.OleDb


Public Class FrmImportarRegistrosAmortizaciones
    Inherits FrConsulta



    Dim AmorRegistros As New E_AmorRegistros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()



    End Sub



    Private Sub FrmImportarRegistrosAmortizaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BtAux.Image = NetAgro.My.Resources.Resources.Action_window_no_fullscreen_16x16_32
        BtAux.Text = "Importar registros amort."
        BtAux.Width = 140
        BtAux.Visible = True

        BInforme.Visible = False


    End Sub


    Private Sub btExplorar_Click(sender As System.Object, e As System.EventArgs) Handles btExplorar.Click

        ObtenerFichero()
        Consultar()

    End Sub


    Private Sub ObtenerFichero()


        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros xlsx (*.xlsx)|*.xlsx"
        dOpenFile.ShowDialog()

        If dOpenFile.FileName.Trim <> "" Then

            Dim fichero As String = dOpenFile.FileName
            TxRutafichero.Text = ObtenerCadenaConexion(fichero)

            BConsultar.Select()
            BConsultar.Focus()

        End If


    End Sub


    Private Function ObtenerCadenaConexion(fichero As String) As String


        Dim cadenaconexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fichero & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"""

        Return cadenaconexion

    End Function


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim dtFinal As DataTable = CreaDataTable()


        If TxRutafichero.Text.Trim <> "" Then

            Dim ExcelConnection As New System.Data.OleDb.OleDbConnection(TxRutafichero.Text)
            Try

                ExcelConnection.Open()


                Dim dtHojas As DataTable = ExcelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                Dim lstHojas As New List(Of String)

                For Each rowHoja As DataRow In dtHojas.Rows
                    lstHojas.Add(rowHoja("TABLE_NAME").ToString())
                Next


                For Each hoja As String In lstHojas

                    Dim dt As New DataTable
                    Dim da As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [" & hoja & "] WHERE RTRIM([número elemento]) <> ''", ExcelConnection)
                    da.Fill(dt)

                    If Not IsNothing(dt) Then

                        ProgressBar1.Value = 0

                        If dt.Rows.Count > 0 Then

                            ProgressBar1.Maximum = dt.Rows.Count - 1

                            For indice As Integer = 0 To dt.Rows.Count - 1

                                Dim row As DataRow = dt.Rows(indice)

                                Dim elemento As Integer = VaInt(row("número elemento"))
                                If elemento > 0 Then

                                    Dim Factura As String = (row("número factura").ToString & "").Trim
                                    Dim FechaInicio As DateTime = VaDate(row("fecha inic amortiz"))
                                    Dim Concepto As String = (row("Concepto").ToString & "").Trim
                                    Dim FechaCompra As DateTime = VaDate(row("fecha compra"))
                                    Dim Unidades As Decimal = VaDec(row("unidades"))
                                    Dim Precio As Decimal = VaDec(row("precio compra"))
                                    Dim ImporteNeto As Decimal = Unidades * Precio
                                    Dim Anterior As Decimal = VaDec(row("amortiz anterior"))
                                    Dim FechaTope As DateTime = VaDate(row("fecha tope"))
                                    Dim Porcentaje As Decimal = VaDec(row("porcentaje")) * 100
                                    Dim CtaAcreedor As String = (row("cuenta acreedor").ToString & "").Trim
                                    Dim FechaBaja As DateTime = VaDate(row("fecha baja"))
                                    Dim Observaciones As String = (row("observaciones").ToString & "").Trim
                                    Dim ValorInicial As Decimal = Unidades * Precio
                                    Dim PuntoVenta As Integer = VaInt(row("punto venta"))
                                    Dim IdCentro As Integer = ObtenerCentro(PuntoVenta)

                                    Dim fila As DataRow = dtFinal.NewRow()

                                    fila("Elemento") = elemento
                                    fila("Factura") = Factura
                                    If FechaInicio > VaDate("") Then fila("FechaInicio") = FechaInicio
                                    fila("Concepto") = Concepto
                                    If FechaCompra > VaDate("") Then fila("FechaCompra") = FechaCompra
                                    fila("Unidades") = Unidades
                                    fila("Precio") = Precio
                                    fila("ImporteNeto") = ImporteNeto
                                    fila("Anterior") = Anterior
                                    If FechaTope > VaDate("") Then fila("FechaTope") = FechaTope
                                    fila("Porcentaje") = Porcentaje
                                    fila("CtaAcreedor") = CtaAcreedor
                                    If FechaBaja > VaDate("") Then fila("FechaBaja") = FechaBaja
                                    fila("Observaciones") = Observaciones
                                    fila("Tipo") = "L"
                                    fila("ValorInicial") = ValorInicial
                                    fila("PuntoVenta") = PuntoVenta
                                    fila("IdCentro") = IdCentro

                                    dtFinal.Rows.Add(fila)

                                End If


                                ProgressBar1.Value = indice

                            Next


                        End If

                    End If

                Next


            Catch ex As Exception
                MsgBox("Error al abrir el fichero excel" & vbCrLf & vbCrLf & ex.Message)
            End Try


            If ExcelConnection.State = ConnectionState.Open Then ExcelConnection.Close()

        Else
            MsgBox("No se ha indicado ningún fichero excel para importar")
        End If






        If Not IsNothing(dtFinal) Then
            If dtFinal.Rows.Count > 0 Then

                Dim colsel As New DataColumn("S", GetType(Boolean))
                colsel.DefaultValue = True
                dtFinal.Columns.Add(colsel)

            End If
        End If


        Grid.DataSource = dtFinal
        AjustaColumnas()


    End Sub


    Private Function CreaDataTable() As DataTable

        Dim dt As New DataTable

        dt.Columns.Add("Elemento", GetType(Integer))
        dt.Columns.Add("Factura", GetType(String))
        dt.Columns.Add("FechaInicio", GetType(DateTime))
        dt.Columns.Add("Concepto", GetType(String))
        dt.Columns.Add("FechaCompra", GetType(DateTime))
        dt.Columns.Add("Unidades", GetType(Decimal))
        dt.Columns.Add("Precio", GetType(Decimal))
        dt.Columns.Add("ImporteNeto", GetType(Decimal))
        dt.Columns.Add("Anterior", GetType(Decimal))
        dt.Columns.Add("FechaTope", GetType(DateTime))
        dt.Columns.Add("Porcentaje", GetType(Decimal))
        dt.Columns.Add("CtaAcreedor", GetType(String))
        dt.Columns.Add("FechaBaja", GetType(DateTime))
        dt.Columns.Add("Observaciones", GetType(String))
        dt.Columns.Add("Tipo", GetType(String))
        dt.Columns.Add("ValorInicial", GetType(Decimal))
        dt.Columns.Add("PuntoVenta", GetType(Integer))
        dt.Columns.Add("IdCentro", GetType(Integer))


        Return dt

    End Function


    Private Function ObtenerCentro(IdPuntoVenta As Integer) As Integer

        Dim res As Integer = 0


        If IdPuntoVenta > 0 Then

            Dim sql As String = "SELECT IdCentro FROM PuntoVenta WHERE IdPuntoVenta = " & IdPuntoVenta

            Dim dt As DataTable = AmorRegistros.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    res = VaInt(row("IdCentro"))

                End If

            End If


        End If

        Return res

    End Function


    Private Sub AjustaColumnas()


        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.Trim.ToUpper

        '    End Select
        'Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.Trim.ToUpper

                Case "PRECIO", "IMPORTENETO", "VALORINICIAL", "ANTERIOR"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 80
                    c.MaxWidth = 120

                Case "PORCENTAJE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "PUNTOVENTA"
                    c.Caption = "PV"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "TIPO"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "IDCENTRO"
                    c.Caption = "CE"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


                Case "FECHAINICIO", "FECHACOMPRA", "FECHATOPE", "FECHABAJA"
                    c.MinWidth = 75
                    c.MaxWidth = 75

            End Select

        Next

    End Sub


    Private Sub AjustaColumnasNIF()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.Trim.ToUpper

                Case "CODIGO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Width = 60

                Case "NIF_CLIENTE", "NIF_CUENTA"
                    c.Width = 80

                Case "S"
                    c.MaxWidth = 25

                Case "CUENTA"
                    c.Width = 90


            End Select

        Next

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea importar las amortizaciones desde el fichero de excel?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then



        End If


    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If column.FieldName.Trim.ToUpper = "S" Then

            If row("S") = False Then
                row("S") = True
            Else
                row("S") = False
            End If

        End If

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub



End Class