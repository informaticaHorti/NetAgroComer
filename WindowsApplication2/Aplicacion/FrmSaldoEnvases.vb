
Public Class FrmSaldoEnvases
    Inherits FrConsulta


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)

    Dim Tsujeto As String


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub


    Public Sub InitTipo(ByVal TipoSujeto As String)
        Tsujeto = TipoSujeto
        Select Case TipoSujeto
            Case "A"
                LbTipo.Text = "Agricultores"
                AsociarControles(TxDato8, BtBusca2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb10)

            Case "C"
                LbTipo.Text = "Clientes"
                AsociarControles(TxDato8, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb10)


        End Select

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato8, Nothing, Lb11, True, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxDato4, Nothing, Lb4, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato5, Nothing, Lb6, False, Cdatos.TiposCampo.Fecha)
        ParamChk(chkSoloRetornables, Nothing, "S", "N")
        ParamChk(ChkDetallarMarcas, Nothing, "S", "N")

    End Sub


    Private Sub FrmSaldoEnvases_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        LbCampa.Text = MiMaletin.Ejercicio.ToString

        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)

    End Sub



    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim Valeenvase As New E_ValeEnvases(Idusuario, cn)

        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String

        'Dim fDesde As String = "01/09/2013"

        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)

        sql = Valeenvase.SaldoEnvases(Tsujeto, ChkDetallarMarcas.Checked, TxDato4.Text, TxDato5.Text, TxDato8.Text, TxDato8.Text, "", "", lstAlmacenes)
        DT = Valeenvase.MiConexion.ConsultaSQL(sql)


        Dim DT2 As New DataTable

        Dim Codigo As New DataColumn("Codigo", GetType(Int32))
        DT2.Columns.Add(Codigo)

        Dim Nombre As New DataColumn("Nombre", GetType(String))
        DT2.Columns.Add(Nombre)

        Dim idEnvase As New DataColumn("IdEnvase", GetType(Int32))
        DT2.Columns.Add(idEnvase)

        Dim Envase As New DataColumn("Envase", GetType(String))
        DT2.Columns.Add(Envase)


        If ChkDetallarMarcas.Checked Then
            Dim IdMarca As New DataColumn("IdMarca", GetType(Int32))
            DT2.Columns.Add(IdMarca)

            Dim Marca As New DataColumn("Marca", GetType(String))
            DT2.Columns.Add(Marca)
        End If


        Dim Inicial As New DataColumn("Inicial", GetType(String))
        DT2.Columns.Add(Inicial)

        Dim retira As New DataColumn("Retira", GetType(Int32))
        DT2.Columns.Add(retira)

        Dim entrega As New DataColumn("Entrega", GetType(Int32))
        DT2.Columns.Add(entrega)

        Dim Saldo As New DataColumn("Saldo", GetType(String))
        DT2.Columns.Add(Saldo)

        Dim Inicialv As New DataColumn("InicialV", GetType(String))
        DT2.Columns.Add(Inicialv)

        Dim retirav As New DataColumn("RetiraV", GetType(Int32))
        DT2.Columns.Add(retirav)

        Dim entregav As New DataColumn("EntregaV", GetType(Int32))
        DT2.Columns.Add(entregav)

        Dim Saldov As New DataColumn("SaldoV", GetType(String))
        DT2.Columns.Add(Saldov)

        Dim V_inicial As New DataColumn("V_inicial", GetType(Int32))
        DT2.Columns.Add("V_inicial")

        Dim V_inicialv As New DataColumn("V_inicialv", GetType(Int32))
        DT2.Columns.Add("V_inicialv")

        Dim V_saldo As New DataColumn("V_saldo", GetType(Int32))
        DT2.Columns.Add("V_saldo")

        Dim V_saldov As New DataColumn("V_saldov", GetType(Int32))
        DT2.Columns.Add("V_saldov")

        If Not DT Is Nothing Then
            For Each rw In DT.Rows
                If chkSoloRetornables.CheckState = CheckState.Unchecked Or rw("ret").ToString = "S" Then
                    If ChkDetallarMarcas.Checked Then
                        DT2.Rows.Add(VaInt(rw("codigo")), rw("nombre").ToString, VaInt(rw("idenvase")), rw("nombreenvase").ToString, VaInt(rw("idmarca")), rw("marca"), StSaldo(VaInt(rw("inicial"))), VaInt(rw("retira")), VaInt(rw("entrega")), StSaldo(VaInt(rw("saldo"))), StSaldo(VaInt(rw("inicialvalorado"))), VaInt(rw("retiravalorado")), VaInt(rw("entregavalorado")), StSaldo(VaInt(rw("saldovalorado"))), VaInt(rw("inicial")), VaInt(rw("inicialvalorado")), VaInt(rw("saldo")), VaInt(rw("saldovalorado")))
                    Else
                        DT2.Rows.Add(VaInt(rw("codigo")), rw("nombre").ToString, VaInt(rw("idenvase")), rw("nombreenvase").ToString, StSaldo(VaInt(rw("inicial"))), VaInt(rw("retira")), VaInt(rw("entrega")), StSaldo(VaInt(rw("saldo"))), StSaldo(VaInt(rw("inicialvalorado"))), VaInt(rw("retiravalorado")), VaInt(rw("entregavalorado")), StSaldo(VaInt(rw("saldovalorado"))), VaInt(rw("inicial")), VaInt(rw("inicialvalorado")), VaInt(rw("saldo")), VaInt(rw("saldovalorado")))
                    End If
                End If
            Next
        End If


        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        DT2.Columns.Add(colSel)


        GridView1.Columns.Clear()


        Grid.DataSource = DT2
        GridView1.BestFitColumns()
        AjustaColumnas()




        'OJO con las mayúsculas / minúsculas
        '  AñadeResumenCampo("bultos", "{0:n2}")
        '  AñadeResumenCampo("Kilos", "{0:n2}")



    End Sub

    Private Sub AjustaColumnas()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "S"
                        c.MaxWidth = 25

                    Case "TIPO", "V_INICIAL", "V_SALDO", "V_INICIALV", "V_SALDOV"
                        c.Visible = False

                    Case "RETIRA", "RETIRAV", "ENTREGA", "ENTREGAV"
                        c.Width = 75
                    Case "CODIGO", "NOMBRE"
                        If TxDato8.Text <> "" Then
                            c.Visible = False
                        Else
                            c.Visible = True
                        End If

                    Case "SALDO", "SALDOV", "INICIAL", "INICIALV"
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        c.Width = 90

                End Select

            Next

            AñadeResumenCampo("Importe", "{0:n2}")


        Catch ex As Exception
            '  err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub


    Private Sub FrmConsultaAlbaranes_AntesDeMostrarTablaDinamica(ByVal f As NetAgro.FrTablaDinamica) Handles MyBase.AntesDeMostrarTablaDinamica

        'Ejemplo para añadir descripciones al informe
        'Dim lst As New List(Of String)
        'lst.Add("Aquí se pueden añadir")
        'lst.Add("líneas de descripción")
        'f.LineasDescripcion = lst

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Fechaspordefecto()

    End Sub
    Private Sub Fechaspordefecto()
        TxDato4.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato5.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub

    Private Sub FrmConsultaAlbaranes_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles MyBase.DespuesDeIncluirCampoCalculado
        AñadeResumenCampo(c.FieldName, "{0:n2}")
    End Sub

    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        Select column.FieldName.ToUpper.Trim
            Case "S"
                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If

            Case Else

                Dim I As Integer = VaInt(row("idenvase"))
                If I > 0 Then
                    Dim fr As New FrmExtractoEnvases
                    fr.InitDatos(Tsujeto, row("Codigo"), row("Nombre"), I.ToString, row("Envase").ToString, TxDato4.Text, TxDato5.Text, row("v_inicial"), row("v_inicialv"), row("v_saldo"), row("v_saldov"))
                    fr.ShowDialog()
                End If

        End Select


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        If TxDato8.Text.Trim <> "" Then LineasDescripcion.Add("Cliente: " & VaInt(TxDato8.Text).ToString("00000") & " " & Lb10.Text)
        If VaDate(TxDato4.Text) <> VaDate("") Or VaDate(TxDato5.Text) <> VaDate("") Then LineasDescripcion.Add("Desde Fecha: " & TxDato4.Text & " hasta Fecha: " & TxDato5.Text)
        If chkSoloRetornables.Checked Then LineasDescripcion.Add("Sólo retornables")
        If ChkDetallarMarcas.Checked Then LineasDescripcion.Add("Detallar marcas")



        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstEnvases As New List(Of String)
                For indice As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    If Not IsNothing(row) Then
                        If row("S") = True Then
                            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
                            lstEnvases.Add(IdEnvase)
                        End If
                    End If
                Next


                Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)

                Dim listado As New Listado_SaldoEnvases(Tsujeto, ChkDetallarMarcas.Checked, TxDato8.Text, Lb10.Text, TxDato4.Text, TxDato5.Text, chkSoloRetornables.Checked, lstEnvases, lstAlmacenes, TipoImpresion.Preliminar)
                listado.ImprimirListado()

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


    
    
    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class